using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using Il2CppDummyDll;
using SA.Common.Animation;
using SA.Common.Pattern;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class MNP
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0xC277E4", Offset = "0xC277E4", VA = "0xC277E4")]
	public static void ShowPreloader(string title, string message)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xC27868", Offset = "0xC27868", VA = "0xC27868")]
	public static void HidePreloader()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xC2786C", Offset = "0xC2786C", VA = "0xC2786C")]
	public MNP()
	{
	}
}
[Token(Token = "0x2000003")]
public static class MNP_Config
{
	[Token(Token = "0x4000001")]
	public const string SUPPORT_EMAIL = "support@stansassets.com";

	[Token(Token = "0x4000002")]
	public const string WEBSITE_ROOT_URL = "https://stansassets.com/";

	[Token(Token = "0x4000003")]
	public const string BUNDLES_PATH = "Plugins/StansAssets/Bundles/";

	[Token(Token = "0x4000004")]
	public const string MODULS_PATH = "Plugins/StansAssets/Modules/";

	[Token(Token = "0x4000005")]
	public const string SUPPORT_MODULS_PATH = "Plugins/StansAssets/Support/";

	[Token(Token = "0x4000006")]
	public const string COMMON_LIB_PATH = "Plugins/StansAssets/Support/Common/";

	[Token(Token = "0x4000007")]
	public const string VERSION_INFO_PATH = "Plugins/StansAssets/Support/Versions/";

	[Token(Token = "0x4000008")]
	public const string NATIVE_LIBRARIES_PATH = "Plugins/StansAssets/Support/NativeLibraries/";

	[Token(Token = "0x4000009")]
	public const string EDITOR_TESTING_LIB_PATH = "Plugins/StansAssets/Support/EditorTesting/";

	[Token(Token = "0x400000A")]
	public const string SETTINGS_REMOVE_PATH = "Plugins/StansAssets/Support/Settings/";

	[Token(Token = "0x400000B")]
	public const string SETTINGS_PATH = "Plugins/StansAssets/Support/Settings/Resources/";

	[Token(Token = "0x400000C")]
	public const string ANDROID_DESTANATION_PATH = "Plugins/Android/";

	[Token(Token = "0x400000D")]
	public const string ANDROID_SOURCE_PATH = "Plugins/StansAssets/Support/NativeLibraries/Android/";

	[Token(Token = "0x400000E")]
	public const string IOS_DESTANATION_PATH = "Plugins/IOS/";

	[Token(Token = "0x400000F")]
	public const string IOS_SOURCE_PATH = "Plugins/StansAssets/Support/NativeLibraries/IOS/";

	[Token(Token = "0x4000010")]
	public const string AN_VERSION_INFO_PATH = "Plugins/StansAssets/Support/Versions/AN_VersionInfo.txt";

	[Token(Token = "0x4000011")]
	public const string UM_VERSION_INFO_PATH = "Plugins/StansAssets/Support/Versions/UM_VersionInfo.txt";

	[Token(Token = "0x4000012")]
	public const string GMA_VERSION_INFO_PATH = "Plugins/StansAssets/Support/Versions/GMA_VersionInfo.txt";

	[Token(Token = "0x4000013")]
	public const string MSP_VERSION_INFO_PATH = "Plugins/StansAssets/Support/Versions/MSP_VersionInfo.txt";

	[Token(Token = "0x4000014")]
	public const string ISN_VERSION_INFO_PATH = "Plugins/StansAssets/Support/Versions/ISN_VersionInfo.txt";

	[Token(Token = "0x4000015")]
	public const string MNP_VERSION_INFO_PATH = "Plugins/StansAssets/Support/Versions/MNP_VersionInfo.txt";

	[Token(Token = "0x4000016")]
	public const string AMN_VERSION_INFO_PATH = "Plugins/StansAssets/Support/Versions/AMN_VersionInfo.txt";
}
[Token(Token = "0x2000004")]
public class MNP_PlatformSettings : ScriptableObject
{
	[Token(Token = "0x4000017")]
	private const string ISNSettingsAssetName = "MNPSettings";

	[Token(Token = "0x4000018")]
	private const string ISNSettingsPath = "Plugins/StansAssets/Support/Settings/Resources/";

	[Token(Token = "0x4000019")]
	private const string ISNSettingsAssetExtension = ".asset";

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MNAndroidDialogTheme AndroidDialogTheme;

	[Token(Token = "0x400001B")]
	public const string VERSION_NUMBER = "5.1/24";

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static MNP_PlatformSettings instance;

	[Token(Token = "0x17000001")]
	public static MNP_PlatformSettings Instance
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0xC263FC", Offset = "0xC263FC", VA = "0xC263FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xC281C8", Offset = "0xC281C8", VA = "0xC281C8")]
	public MNP_PlatformSettings()
	{
	}
}
[Token(Token = "0x2000005")]
public class MNPopup
{
	[Token(Token = "0x2000045")]
	public delegate void MNPopupAction();

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected Dictionary<string, MNPopupAction> actions;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected MNPopupAction dismissCallback;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected string title;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected string message;

	[Token(Token = "0x4000021")]
	protected const int MAX_ACTIONS = 3;

	[Token(Token = "0x4000022")]
	protected const string DISMISS_ACTION = "com.stansassets.action.dismiss";

	[Token(Token = "0x17000002")]
	public string Title
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0xC2867C", Offset = "0xC2867C", VA = "0xC2867C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	public string Message
	{
		[Token(Token = "0x600000C")]
		[Address(RVA = "0xC28684", Offset = "0xC28684", VA = "0xC28684")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	public Dictionary<string, MNPopupAction> Actions
	{
		[Token(Token = "0x600000D")]
		[Address(RVA = "0xC2868C", Offset = "0xC2868C", VA = "0xC2868C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xC28204", Offset = "0xC28204", VA = "0xC28204")]
	public MNPopup(string title, string message)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xC28328", Offset = "0xC28328", VA = "0xC28328")]
	public void AddAction(string title, MNPopupAction callback)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xC28444", Offset = "0xC28444", VA = "0xC28444")]
	public void AddDismissListener(MNPopupAction callback)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xC2844C", Offset = "0xC2844C", VA = "0xC2844C")]
	public void Show()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xC28694", Offset = "0xC28694", VA = "0xC28694")]
	private void OnPopupCompleted(string action)
	{
	}
}
[Token(Token = "0x2000006")]
public sealed class MNRateUsPopup : MNPopup
{
	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private MNPopupAction remindListener;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private MNPopupAction declineListener;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private MNPopupAction rateUsListener;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string androidAppUrl;

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xC28868", Offset = "0xC28868", VA = "0xC28868")]
	public MNRateUsPopup(string title, string message, string rateUs, string decline, string remind)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xC289C8", Offset = "0xC289C8", VA = "0xC289C8")]
	public void SetAppleId(string id)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xC289CC", Offset = "0xC289CC", VA = "0xC289CC")]
	public void SetAndroidAppUrl(string appUrl)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xC289D4", Offset = "0xC289D4", VA = "0xC289D4")]
	public void AddRateUsListener(MNPopupAction callback)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xC289DC", Offset = "0xC289DC", VA = "0xC289DC")]
	public void AddRemindListener(MNPopupAction callback)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xC289E4", Offset = "0xC289E4", VA = "0xC289E4")]
	public void AddDeclineListener(MNPopupAction callback)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xC289EC", Offset = "0xC289EC", VA = "0xC289EC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844574", Offset = "0x844574")]
	private void <.ctor>b__4_0()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xC289FC", Offset = "0xC289FC", VA = "0xC289FC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844584", Offset = "0x844584")]
	private void <.ctor>b__4_1()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xC28A0C", Offset = "0xC28A0C", VA = "0xC28A0C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844594", Offset = "0x844594")]
	private void <.ctor>b__4_2()
	{
	}
}
[Token(Token = "0x2000007")]
public class MNP_EditorTesting : MNP_Singleton<MNP_EditorTesting>
{
	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MNP_EditorUIController UiController;

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xC27874", Offset = "0xC27874", VA = "0xC27874")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xC27A20", Offset = "0xC27A20", VA = "0xC27A20")]
	private void Start()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xC27A24", Offset = "0xC27A24", VA = "0xC27A24")]
	public void ShowPopup(string title, string message, Dictionary<string, MNPopup.MNPopupAction> actions, MNPopup.MNPopupAction dismiss)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xC27E50", Offset = "0xC27E50", VA = "0xC27E50")]
	public MNP_EditorTesting()
	{
	}
}
[Token(Token = "0x2000008")]
public class MNP_EditorUIController : MonoBehaviour
{
	[Token(Token = "0x2000046")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844334", Offset = "0x844334")]
	private sealed class <>c__DisplayClass11_0
	{
		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MNPopup.MNPopupAction a;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MNP_EditorUIController <>4__this;

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xC27EC8", Offset = "0xC27EC8", VA = "0xC27EC8")]
		public <>c__DisplayClass11_0()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xC28138", Offset = "0xC28138", VA = "0xC28138")]
		internal void <SetActions>b__0()
		{
		}
	}

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject Root;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text Title;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text Message;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private MNP_UIButton[] UIButtons;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private MNPopup.MNPopupAction dismiss;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool isActive;

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xC27EC0", Offset = "0xC27EC0", VA = "0xC27EC0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xC27EC4", Offset = "0xC27EC4", VA = "0xC27EC4")]
	private void Start()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xC2798C", Offset = "0xC2798C", VA = "0xC2798C")]
	public void Hide()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xC27A90", Offset = "0xC27A90", VA = "0xC27A90")]
	public void SetTitle(string title)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xC27AC0", Offset = "0xC27AC0", VA = "0xC27AC0")]
	public void SetMessage(string message)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xC27AF0", Offset = "0xC27AF0", VA = "0xC27AF0")]
	public void SetActions(Dictionary<string, MNPopup.MNPopupAction> actions, MNPopup.MNPopupAction dismissAction)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xC27E24", Offset = "0xC27E24", VA = "0xC27E24")]
	public void Show()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xC27ED0", Offset = "0xC27ED0", VA = "0xC27ED0")]
	public void OnDismiss()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xC28130", Offset = "0xC28130", VA = "0xC28130")]
	public MNP_EditorUIController()
	{
	}
}
[Token(Token = "0x2000009")]
public class MNP_UIButton : MonoBehaviour
{
	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Button Button;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text Title;

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xC281D4", Offset = "0xC281D4", VA = "0xC281D4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xC281D8", Offset = "0xC281D8", VA = "0xC281D8")]
	public void SetText(string text)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xC281FC", Offset = "0xC281FC", VA = "0xC281FC")]
	public MNP_UIButton()
	{
	}
}
[Token(Token = "0x200000A")]
public enum MNAndroidDialogTheme
{
	[Token(Token = "0x4000031")]
	ThemeDeviceDefaultDark,
	[Token(Token = "0x4000032")]
	ThemeDeviceDefaultLight,
	[Token(Token = "0x4000033")]
	ThemeHoloDark,
	[Token(Token = "0x4000034")]
	ThemeHoloLight,
	[Token(Token = "0x4000035")]
	ThemeTraditional
}
[Token(Token = "0x200000B")]
public enum MNDialogResult
{
	[Token(Token = "0x4000037")]
	YES,
	[Token(Token = "0x4000038")]
	NO,
	[Token(Token = "0x4000039")]
	RATED,
	[Token(Token = "0x400003A")]
	REMIND,
	[Token(Token = "0x400003B")]
	DECLINED,
	[Token(Token = "0x400003C")]
	CLOSED
}
[Token(Token = "0x200000C")]
public class MNAndroidNative
{
	[Token(Token = "0x400003D")]
	private const string CLASS_NAME = "com.stansassets.mnp.NativePopupsManager";

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xC2699C", Offset = "0xC2699C", VA = "0xC2699C")]
	private static void CallActivityFunction(string methodName, params object[] args)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xC265BC", Offset = "0xC265BC", VA = "0xC265BC")]
	public static void showMessage(string title, string message, string actions, MNAndroidDialogTheme theme)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xC26F00", Offset = "0xC26F00", VA = "0xC26F00")]
	public static void ShowPreloader(string title, string message, MNAndroidDialogTheme theme)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xC27058", Offset = "0xC27058", VA = "0xC27058")]
	public static void HidePreloader()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xC2712C", Offset = "0xC2712C", VA = "0xC2712C")]
	public static void RedirectStoreRatingPage(string url)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xC271E4", Offset = "0xC271E4", VA = "0xC271E4")]
	public MNAndroidNative()
	{
	}
}
[Token(Token = "0x200000D")]
public abstract class MNProxyPool
{
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844344", Offset = "0x844344")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string methodName;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public object[] args;

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xC287AC", Offset = "0xC287AC", VA = "0xC287AC")]
		public <>c__DisplayClass1_0()
		{
		}
	}

	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844354", Offset = "0x844354")]
	private sealed class <>c__DisplayClass1_1
	{
		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AndroidJavaObject bridge;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public <>c__DisplayClass1_0 CS$<>8__locals1;

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xC287B4", Offset = "0xC287B4", VA = "0xC287B4")]
		public <>c__DisplayClass1_1()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xC2883C", Offset = "0xC2883C", VA = "0xC2883C")]
		internal void <CallStatic>b__0()
		{
		}
	}

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<string, AndroidJavaObject> pool;

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xC26A1C", Offset = "0xC26A1C", VA = "0xC26A1C")]
	public static void CallStatic(string className, string methodName, params object[] args)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xC287BC", Offset = "0xC287BC", VA = "0xC287BC")]
	protected MNProxyPool()
	{
	}
}
[Token(Token = "0x200000E")]
public class MNAndroidAlert : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844364", Offset = "0x844364")]
	private sealed class <>c
	{
		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<string> <>9__7_0;

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xC26990", Offset = "0xC26990", VA = "0xC26990")]
		public <>c()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xC26998", Offset = "0xC26998", VA = "0xC26998")]
		internal void <.ctor>b__7_0(string <p0>)
		{
		}
	}

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string title;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string message;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerable<string> actions;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Action<string> OnComplete;

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xC26028", Offset = "0xC26028", VA = "0xC26028")]
	public static MNAndroidAlert Create(string title, string message, IEnumerable<string> actions)
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xC260F4", Offset = "0xC260F4", VA = "0xC260F4")]
	public void Show()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xC2674C", Offset = "0xC2674C", VA = "0xC2674C")]
	public void onPopUpCallBack(string result)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xC267F4", Offset = "0xC267F4", VA = "0xC267F4")]
	public MNAndroidAlert()
	{
	}
}
[Token(Token = "0x200000F")]
public class MNIOSAlert : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844374", Offset = "0x844374")]
	private sealed class <>c
	{
		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<string> <>9__7_0;

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xC277C0", Offset = "0xC277C0", VA = "0xC277C0")]
		public <>c()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xC277C8", Offset = "0xC277C8", VA = "0xC277C8")]
		internal void <.ctor>b__7_0(string <p0>)
		{
		}
	}

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string title;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string message;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerable<string> actions;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Action<string> OnComplete;

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xC271EC", Offset = "0xC271EC", VA = "0xC271EC")]
	public static MNIOSAlert Create(string title, string message, IEnumerable<string> actions)
	{
		return null;
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xC272B8", Offset = "0xC272B8", VA = "0xC272B8")]
	public void Show()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xC2757C", Offset = "0xC2757C", VA = "0xC2757C")]
	public void onPopUpCallBack(string result)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xC27624", Offset = "0xC27624", VA = "0xC27624")]
	public MNIOSAlert()
	{
	}
}
[Token(Token = "0x2000010")]
public class MNIOSNative
{
	[Token(Token = "0x6000039")]
	[Address(RVA = "0xC27578", Offset = "0xC27578", VA = "0xC27578")]
	public static void showMessage(string title, string message, string actions)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xC277CC", Offset = "0xC277CC", VA = "0xC277CC")]
	public static void RedirectToAppStoreRatingPage(string appleId)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xC277D0", Offset = "0xC277D0", VA = "0xC277D0")]
	public static void ShowPreloader()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xC277D4", Offset = "0xC277D4", VA = "0xC277D4")]
	public static void HidePreloader()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xC277D8", Offset = "0xC277D8", VA = "0xC277D8")]
	public static void dismissCurrentAlert()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xC277DC", Offset = "0xC277DC", VA = "0xC277DC")]
	public MNIOSNative()
	{
	}
}
[Token(Token = "0x2000011")]
public abstract class MNP_Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static T _instance;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool applicationIsQuitting;

	[Token(Token = "0x17000005")]
	public static T Instance
	{
		[Token(Token = "0x600003F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000006")]
	public static bool HasInstance
	{
		[Token(Token = "0x6000040")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000007")]
	public static bool IsDestroyed
	{
		[Token(Token = "0x6000041")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000042")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000043")]
	protected virtual void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000044")]
	protected MNP_Singleton()
	{
	}
}
[Token(Token = "0x2000012")]
public static class SA_UnityExtensions
{
	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Regex _regex;

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x18EFEBC", Offset = "0x18EFEBC", VA = "0x18EFEBC")]
	public static void MoveTo(this GameObject go, Vector3 position, float time, EaseType easeType = EaseType.linear, [Optional] Action OnCompleteAction)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x18EFF90", Offset = "0x18EFF90", VA = "0x18EFF90")]
	public static void ScaleTo(this GameObject go, Vector3 scale, float time, EaseType easeType = EaseType.linear, [Optional] Action OnCompleteAction)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x18F0064", Offset = "0x18F0064", VA = "0x18F0064")]
	public static Bounds GetRealBounds(this GameObject go)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x18F0274", Offset = "0x18F0274", VA = "0x18F0274")]
	public static Bounds GetRealBounds(this Component go)
	{
		return default(Bounds);
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x18F0484", Offset = "0x18F0484", VA = "0x18F0484")]
	public static Bounds GetRendererBounds(this GameObject go)
	{
		return default(Bounds);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x18F0710", Offset = "0x18F0710", VA = "0x18F0710")]
	public static Vector3 GetVertex(this GameObject go, VertexX x, VertexY y, VertexZ z)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x18F08A4", Offset = "0x18F08A4", VA = "0x18F08A4")]
	public static void Reset(this GameObject go)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x18F09E4", Offset = "0x18F09E4", VA = "0x18F09E4")]
	public static bool IsVisibleFrom(this Renderer renderer, Camera camera)
	{
		return default(bool);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x18F0924", Offset = "0x18F0924", VA = "0x18F0924")]
	public static void Reset(this Transform t)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x18F0A54", Offset = "0x18F0A54", VA = "0x18F0A54")]
	public static Bounds GetRendererBounds(this Transform t)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x18F0AE4", Offset = "0x18F0AE4", VA = "0x18F0AE4")]
	public static Vector3 GetVertex(this Transform t, VertexX x, VertexY y, VertexZ z)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x18F0B8C", Offset = "0x18F0B8C", VA = "0x18F0B8C")]
	public static Transform Clear(this Transform transform)
	{
		return null;
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x18F07B4", Offset = "0x18F07B4", VA = "0x18F07B4")]
	public static Vector3 GetVertex(this Bounds bounds, VertexX x, VertexY y, VertexZ z)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x18F0CF0", Offset = "0x18F0CF0", VA = "0x18F0CF0")]
	public static void SetAlpha(this Material material, float value)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x18F0D88", Offset = "0x18F0D88", VA = "0x18F0D88")]
	public static Sprite ToSprite(this Texture2D texture)
	{
		return null;
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x18F0E24", Offset = "0x18F0E24", VA = "0x18F0E24")]
	public static Texture2D Rotate(this Texture2D texture, float angle)
	{
		return null;
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x18F0E98", Offset = "0x18F0E98", VA = "0x18F0E98")]
	public static Vector3 Reset(this Vector3 vec)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x18F0EF8", Offset = "0x18F0EF8", VA = "0x18F0EF8")]
	public static Vector3 ResetXCoord(this Vector3 vec)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x18F0F00", Offset = "0x18F0F00", VA = "0x18F0F00")]
	public static Vector3 ResetYCoord(this Vector3 vec)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x18F0F08", Offset = "0x18F0F08", VA = "0x18F0F08")]
	public static Vector3 ResetZCoord(this Vector3 vec)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x18F0F10", Offset = "0x18F0F10", VA = "0x18F0F10")]
	public static Vector3 Average(this Vector3[] f)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x18F10C8", Offset = "0x18F10C8", VA = "0x18F10C8")]
	public static string GetLast(this string source, int count)
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x18F10F0", Offset = "0x18F10F0", VA = "0x18F10F0")]
	public static string GetFirst(this string source, int count)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x18F1120", Offset = "0x18F1120", VA = "0x18F1120")]
	public static void CopyToClipboard(this string source)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x18F1124", Offset = "0x18F1124", VA = "0x18F1124")]
	public static Uri CovertToURI(this string source)
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x18F1188", Offset = "0x18F1188", VA = "0x18F1188")]
	public static Dictionary<string, string> ParseQueryString(this Uri uri)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x18F04F8", Offset = "0x18F04F8", VA = "0x18F04F8")]
	public static Bounds CalculateBounds(GameObject obj)
	{
		return default(Bounds);
	}
}
[Token(Token = "0x2000013")]
public enum VertexX
{
	[Token(Token = "0x400004B")]
	Left,
	[Token(Token = "0x400004C")]
	Right,
	[Token(Token = "0x400004D")]
	Center
}
[Token(Token = "0x2000014")]
public enum VertexY
{
	[Token(Token = "0x400004F")]
	Top,
	[Token(Token = "0x4000050")]
	Bottom,
	[Token(Token = "0x4000051")]
	Center
}
[Token(Token = "0x2000015")]
public enum VertexZ
{
	[Token(Token = "0x4000053")]
	Front,
	[Token(Token = "0x4000054")]
	Back,
	[Token(Token = "0x4000055")]
	Center
}
namespace SA.Common
{
	[Token(Token = "0x2000016")]
	public class Config
	{
		[Token(Token = "0x4000056")]
		public const string LIB_VERSION = "24";

		[Token(Token = "0x4000057")]
		public const int VERSION_UNDEFINED = 0;

		[Token(Token = "0x4000058")]
		public const string VERSION_UNDEFINED_STRING = "Undefined";

		[Token(Token = "0x4000059")]
		public const string SUPPORT_EMAIL = "support@stansassets.com";

		[Token(Token = "0x400005A")]
		public const string WEBSITE_ROOT_URL = "https://stansassets.com/";

		[Token(Token = "0x400005B")]
		public const string BUNDLES_PATH = "Plugins/StansAssets/Bundles/";

		[Token(Token = "0x400005C")]
		public const string MODULS_PATH = "Plugins/StansAssets/Modules/";

		[Token(Token = "0x400005D")]
		public const string SUPPORT_MODULS_PATH = "Plugins/StansAssets/Support/";

		[Token(Token = "0x400005E")]
		public const string COMMON_LIB_PATH = "Plugins/StansAssets/Support/Common/";

		[Token(Token = "0x400005F")]
		public const string VERSION_INFO_PATH = "Plugins/StansAssets/Support/Versions/";

		[Token(Token = "0x4000060")]
		public const string NATIVE_LIBRARIES_PATH = "Plugins/StansAssets/Support/NativeLibraries/";

		[Token(Token = "0x4000061")]
		public const string EDITOR_TESTING_LIB_PATH = "Plugins/StansAssets/Support/EditorTesting/";

		[Token(Token = "0x4000062")]
		public const string SETTINGS_REMOVE_PATH = "Plugins/StansAssets/Support/Settings/";

		[Token(Token = "0x4000063")]
		public const string SETTINGS_PATH = "Plugins/StansAssets/Support/Settings/Resources/";

		[Token(Token = "0x4000064")]
		public const string ANDROID_DESTANATION_PATH = "Plugins/Android/";

		[Token(Token = "0x4000065")]
		public const string ANDROID_SOURCE_PATH = "Plugins/StansAssets/Support/NativeLibraries/Android/";

		[Token(Token = "0x4000066")]
		public const string IOS_DESTANATION_PATH = "Plugins/IOS/";

		[Token(Token = "0x4000067")]
		public const string IOS_SOURCE_PATH = "Plugins/StansAssets/Support/NativeLibraries/IOS/";

		[Token(Token = "0x4000068")]
		public const string SPOTIFY_VERSION_INFO_PATH = "Plugins/StansAssets/Support/Versions/Spotify_VersionInfo.txt";

		[Token(Token = "0x4000069")]
		public const string AN_VERSION_INFO_PATH = "Plugins/StansAssets/Support/Versions/AN_VersionInfo.txt";

		[Token(Token = "0x400006A")]
		public const string UM_VERSION_INFO_PATH = "Plugins/StansAssets/Support/Versions/UM_VersionInfo.txt";

		[Token(Token = "0x400006B")]
		public const string GMA_VERSION_INFO_PATH = "Plugins/StansAssets/Support/Versions/GMA_VersionInfo.txt";

		[Token(Token = "0x400006C")]
		public const string MSP_VERSION_INFO_PATH = "Plugins/StansAssets/Support/Versions/MSP_VersionInfo.txt";

		[Token(Token = "0x400006D")]
		public const string ISN_VERSION_INFO_PATH = "Plugins/StansAssets/Support/Versions/ISN_VersionInfo.txt";

		[Token(Token = "0x400006E")]
		public const string MNP_VERSION_INFO_PATH = "Plugins/StansAssets/Support/Versions/MNP_VersionInfo.txt";

		[Token(Token = "0x400006F")]
		public const string AMN_VERSION_INFO_PATH = "Plugins/StansAssets/Support/Versions/AMN_VersionInfo.txt";

		[Token(Token = "0x17000008")]
		public static string FB_SDK_VersionCode
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x18E7D04", Offset = "0x18E7D04", VA = "0x18E7D04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public static int FB_SDK_MajorVersionCode
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x18E8198", Offset = "0x18E8198", VA = "0x18E8198")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x18E8380", Offset = "0x18E8380", VA = "0x18E8380")]
		public Config()
		{
		}
	}
}
namespace SA.Common.Pattern
{
	[Token(Token = "0x2000017")]
	public abstract class NonMonoSingleton<T> where T : NonMonoSingleton<T>, new()
	{
		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T _Instance;

		[Token(Token = "0x1700000A")]
		public static T Instance
		{
			[Token(Token = "0x6000065")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000066")]
		protected NonMonoSingleton()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
	{
		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T _instance;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool applicationIsQuitting;

		[Token(Token = "0x1700000B")]
		public static T Instance
		{
			[Token(Token = "0x6000068")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		public static bool HasInstance
		{
			[Token(Token = "0x6000069")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000D")]
		public static bool IsDestroyed
		{
			[Token(Token = "0x600006A")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600006B")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600006C")]
		protected virtual void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600006D")]
		protected Singleton()
		{
		}
	}
}
namespace SA.Common.Util
{
	[Token(Token = "0x2000019")]
	public static class General
	{
		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string[] _rfc3339Formats;

		[Token(Token = "0x4000074")]
		private const string Rfc3339Format = "yyyy-MM-dd'T'HH:mm:ssK";

		[Token(Token = "0x4000075")]
		private const string MinRfc339Value = "0001-01-01T00:00:00Z";

		[Token(Token = "0x1700000E")]
		public static int CurrentTimeStamp
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x18EBD3C", Offset = "0x18EBD3C", VA = "0x18EBD3C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700000F")]
		public static string[] DateTimePatterns
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x18EC010", Offset = "0x18EC010", VA = "0x18EC010")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x18EBCFC", Offset = "0x18EBCFC", VA = "0x18EBCFC")]
		public static void Invoke(float time, Action callback, string name = "")
		{
		}

		[Token(Token = "0x6000070")]
		public static T ParseEnum<T>(string value)
		{
			return (T)null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x18EBDF4", Offset = "0x18EBDF4", VA = "0x18EBDF4")]
		public static string DateTimeToRfc3339(DateTime dateTime)
		{
			return null;
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x18EBED0", Offset = "0x18EBED0", VA = "0x18EBED0")]
		public static DateTime ConvertFromUnixTimestamp(long timestamp)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x18EBF38", Offset = "0x18EBF38", VA = "0x18EBF38")]
		public static long ConvertToUnixTimestamp(DateTime date)
		{
			return default(long);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x18EC4D4", Offset = "0x18EC4D4", VA = "0x18EC4D4")]
		public static bool TryParseRfc3339(string s, out DateTime result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x18EC64C", Offset = "0x18EC64C", VA = "0x18EC64C")]
		public static string HMAC(string key, string data)
		{
			return null;
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x18EC89C", Offset = "0x18EC89C", VA = "0x18EC89C")]
		public static void CleanupInstallation()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public static class IconManager
	{
		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<string, Texture2D> s_icons;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<float, Texture2D> s_colorIcons;

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x18EC90C", Offset = "0x18EC90C", VA = "0x18EC90C")]
		public static Texture2D GetIconFromHtmlColorString(string htmlString)
		{
			return null;
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x18EC9A0", Offset = "0x18EC9A0", VA = "0x18EC9A0")]
		public static Texture2D GetIconFromHtmlColorString(string htmlString, Color fallback)
		{
			return null;
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x18ECA34", Offset = "0x18ECA34", VA = "0x18ECA34")]
		public static Texture2D GetIcon(Color color, int width = 1, int height = 1)
		{
			return null;
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x18ECCE4", Offset = "0x18ECCE4", VA = "0x18ECCE4")]
		public static Texture2D GetIconAtPath(string path)
		{
			return null;
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x18ECE90", Offset = "0x18ECE90", VA = "0x18ECE90")]
		public static Texture2D Rotate(Texture2D tex, float angle)
		{
			return null;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x18ED2CC", Offset = "0x18ED2CC", VA = "0x18ED2CC")]
		private static Color getPixel(Texture2D tex, float x, float y)
		{
			return default(Color);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x18ED16C", Offset = "0x18ED16C", VA = "0x18ED16C")]
		private static float rot_x(float angle, float x, float y)
		{
			return default(float);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x18ED21C", Offset = "0x18ED21C", VA = "0x18ED21C")]
		private static float rot_y(float angle, float x, float y)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200001B")]
	public class IdFactory
	{
		[Token(Token = "0x200004B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844384", Offset = "0x844384")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000338")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public System.Random random;

			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x18ED608", Offset = "0x18ED608", VA = "0x18ED608")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x18ED618", Offset = "0x18ED618", VA = "0x18ED618")]
			internal char <get_RandomString>b__0(string s)
			{
				return default(char);
			}
		}

		[Token(Token = "0x4000078")]
		private const string PP_ID_KEY = "SA.Common.Util.IdFactory_Key";

		[Token(Token = "0x17000010")]
		public static int NextId
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x18ED464", Offset = "0x18ED464", VA = "0x18ED464")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000011")]
		public static string RandomString
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x18ED4E4", Offset = "0x18ED4E4", VA = "0x18ED4E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x18ED610", Offset = "0x18ED610", VA = "0x18ED610")]
		public IdFactory()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public static class Loader
	{
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x18ED660", Offset = "0x18ED660", VA = "0x18ED660")]
		public static void LoadWebTexture(string url, Action<Texture2D> callback)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x18ED6EC", Offset = "0x18ED6EC", VA = "0x18ED6EC")]
		public static void LoadPrefab(string localPath, Action<GameObject> callback)
		{
		}
	}
	[Token(Token = "0x200001D")]
	public static class Screen
	{
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x18ED734", Offset = "0x18ED734", VA = "0x18ED734")]
		public static void TakeScreenshot(Action<Texture2D> callback)
		{
		}
	}
}
namespace SA.Common.Extensions
{
	[Token(Token = "0x200001E")]
	public static class SA_TweenExtensions
	{
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x18EA0A8", Offset = "0x18EA0A8", VA = "0x18EA0A8")]
		public static void MoveTo(this GameObject go, Vector3 position, float time, EaseType easeType = EaseType.linear, [Optional] Action OnCompleteAction)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x18EA17C", Offset = "0x18EA17C", VA = "0x18EA17C")]
		public static void ScaleTo(this GameObject go, Vector3 scale, float time, EaseType easeType = EaseType.linear, [Optional] Action OnCompleteAction)
		{
		}
	}
	[Token(Token = "0x200001F")]
	public static class SA_TextureExtensions
	{
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x18E9FD0", Offset = "0x18E9FD0", VA = "0x18E9FD0")]
		public static Sprite ToSprite(this Texture texture)
		{
			return null;
		}
	}
}
namespace SA.Common.Models
{
	[Token(Token = "0x2000020")]
	public class Error
	{
		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _Code;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _Messgae;

		[Token(Token = "0x17000012")]
		public int Code
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x18EA48C", Offset = "0x18EA48C", VA = "0x18EA48C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000013")]
		public string Message
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x18EA494", Offset = "0x18EA494", VA = "0x18EA494")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x18EA250", Offset = "0x18EA250", VA = "0x18EA250")]
		public Error()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x18EA2D8", Offset = "0x18EA2D8", VA = "0x18EA2D8")]
		public Error(int code, string message = "")
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x18EA368", Offset = "0x18EA368", VA = "0x18EA368")]
		public Error(string errorData)
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class Invoker : MonoBehaviour
	{
		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Action _callback;

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x18EA49C", Offset = "0x18EA49C", VA = "0x18EA49C")]
		public static Invoker Create(string name)
		{
			return null;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x18EA534", Offset = "0x18EA534", VA = "0x18EA534")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x18EA5B0", Offset = "0x18EA5B0", VA = "0x18EA5B0")]
		public void StartInvoke(Action callback, float time)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x18EA630", Offset = "0x18EA630", VA = "0x18EA630")]
		private void TimeOut()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x18EA6BC", Offset = "0x18EA6BC", VA = "0x18EA6BC")]
		public Invoker()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class PrefabAsyncLoader : MonoBehaviour
	{
		[Token(Token = "0x200004C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844394", Offset = "0x844394")]
		private sealed class <Load>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400033A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400033B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PrefabAsyncLoader <>4__this;

			[Token(Token = "0x400033C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ResourceRequest <request>5__2;

			[Token(Token = "0x17000034")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002DD")]
				[Address(RVA = "0x18EAD78", Offset = "0x18EAD78", VA = "0x18EAD78", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000035")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002DF")]
				[Address(RVA = "0x18EADE0", Offset = "0x18EADE0", VA = "0x18EADE0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x18EA9B8", Offset = "0x18EA9B8", VA = "0x18EA9B8")]
			[DebuggerHidden]
			public <Load>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x18EAB58", Offset = "0x18EAB58", VA = "0x18EAB58", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x18EAB5C", Offset = "0x18EAB5C", VA = "0x18EAB5C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x18EAD80", Offset = "0x18EAD80", VA = "0x18EAD80", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200004D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8443A4", Offset = "0x8443A4")]
		private sealed class <>c
		{
			[Token(Token = "0x400033D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400033E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<GameObject> <>9__8_0;

			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x18EAB4C", Offset = "0x18EAB4C", VA = "0x18EAB4C")]
			public <>c()
			{
			}

			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x18EAB54", Offset = "0x18EAB54", VA = "0x18EAB54")]
			internal void <.ctor>b__8_0(GameObject <p0>)
			{
			}
		}

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string PrefabPath;

		[Token(Token = "0x14000001")]
		public event Action<GameObject> ObjectLoadedAction
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x18EA6C4", Offset = "0x18EA6C4", VA = "0x18EA6C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844774", Offset = "0x844774")]
			add
			{
			}
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x18EA768", Offset = "0x18EA768", VA = "0x18EA768")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844784", Offset = "0x844784")]
			remove
			{
			}
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x18EA80C", Offset = "0x18EA80C", VA = "0x18EA80C")]
		public static PrefabAsyncLoader Create()
		{
			return null;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x18EA888", Offset = "0x18EA888", VA = "0x18EA888")]
		private void Awake()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x18EA904", Offset = "0x18EA904", VA = "0x18EA904")]
		public void LoadAsync(string name)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x18EA93C", Offset = "0x18EA93C", VA = "0x18EA93C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x844794", Offset = "0x844794")]
		private IEnumerator Load()
		{
			return null;
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x18EA9E4", Offset = "0x18EA9E4", VA = "0x18EA9E4")]
		public PrefabAsyncLoader()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class Result
	{
		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected Error _Error;

		[Token(Token = "0x17000014")]
		public Error Error
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x18EAE24", Offset = "0x18EAE24", VA = "0x18EAE24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public bool HasError
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x18EAE2C", Offset = "0x18EAE2C", VA = "0x18EAE2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000016")]
		public bool IsSucceeded
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x18EAE3C", Offset = "0x18EAE3C", VA = "0x18EAE3C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000017")]
		public bool IsFailed
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x18EAE4C", Offset = "0x18EAE4C", VA = "0x18EAE4C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x18EADE8", Offset = "0x18EADE8", VA = "0x18EADE8")]
		public Result()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x18EADF0", Offset = "0x18EADF0", VA = "0x18EADF0")]
		public Result(Error error)
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class ScreenshotMaker : MonoBehaviour
	{
		[Token(Token = "0x200004E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8443B4", Offset = "0x8443B4")]
		private sealed class <SaveScreenshot>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400033F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000340")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000341")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ScreenshotMaker <>4__this;

			[Token(Token = "0x17000036")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002E6")]
				[Address(RVA = "0x18EB348", Offset = "0x18EB348", VA = "0x18EB348", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000037")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002E8")]
				[Address(RVA = "0x18EB3B0", Offset = "0x18EB3B0", VA = "0x18EB3B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x18EAFFC", Offset = "0x18EAFFC", VA = "0x18EAFFC")]
			[DebuggerHidden]
			public <SaveScreenshot>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x18EB19C", Offset = "0x18EB19C", VA = "0x18EB19C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x18EB1A0", Offset = "0x18EB1A0", VA = "0x18EB1A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x18EB350", Offset = "0x18EB350", VA = "0x18EB350", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200004F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8443C4", Offset = "0x8443C4")]
		private sealed class <>c
		{
			[Token(Token = "0x4000342")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000343")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<Texture2D> <>9__5_0;

			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x18EB190", Offset = "0x18EB190", VA = "0x18EB190")]
			public <>c()
			{
			}

			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x18EB198", Offset = "0x18EB198", VA = "0x18EB198")]
			internal void <.ctor>b__5_0(Texture2D <p0>)
			{
			}
		}

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<Texture2D> OnScreenshotReady;

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x18EAE5C", Offset = "0x18EAE5C", VA = "0x18EAE5C")]
		public static ScreenshotMaker Create()
		{
			return null;
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x18EAED8", Offset = "0x18EAED8", VA = "0x18EAED8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x18EAF54", Offset = "0x18EAF54", VA = "0x18EAF54")]
		public void GetScreenshot()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x18EAF80", Offset = "0x18EAF80", VA = "0x18EAF80")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8447F8", Offset = "0x8447F8")]
		private IEnumerator SaveScreenshot()
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x18EB028", Offset = "0x18EB028", VA = "0x18EB028")]
		public ScreenshotMaker()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class WWWTextureLoader : MonoBehaviour
	{
		[Token(Token = "0x2000050")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8443D4", Offset = "0x8443D4")]
		private sealed class <LoadCoroutin>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000344")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000345")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000346")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WWWTextureLoader <>4__this;

			[Token(Token = "0x4000347")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private WWW <www>5__2;

			[Token(Token = "0x17000038")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002EF")]
				[Address(RVA = "0x18EBC8C", Offset = "0x18EBC8C", VA = "0x18EBC8C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000039")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002F1")]
				[Address(RVA = "0x18EBCF4", Offset = "0x18EBCF4", VA = "0x18EBCF4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x18EB7DC", Offset = "0x18EB7DC", VA = "0x18EB7DC")]
			[DebuggerHidden]
			public <LoadCoroutin>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x18EBAD8", Offset = "0x18EBAD8", VA = "0x18EBAD8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x18EBADC", Offset = "0x18EBADC", VA = "0x18EBADC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x18EBC94", Offset = "0x18EBC94", VA = "0x18EBC94", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000051")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8443E4", Offset = "0x8443E4")]
		private sealed class <>c
		{
			[Token(Token = "0x4000348")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000349")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<Texture2D> <>9__10_0;

			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x18EBACC", Offset = "0x18EBACC", VA = "0x18EBACC")]
			public <>c()
			{
			}

			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x18EBAD4", Offset = "0x18EBAD4", VA = "0x18EBAD4")]
			internal void <.ctor>b__10_0(Texture2D <p0>)
			{
			}
		}

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Dictionary<string, Texture2D> LocalCache;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _url;

		[Token(Token = "0x14000002")]
		public event Action<Texture2D> OnLoad
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x18EB3B8", Offset = "0x18EB3B8", VA = "0x18EB3B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84485C", Offset = "0x84485C")]
			add
			{
			}
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x18EB45C", Offset = "0x18EB45C", VA = "0x18EB45C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84486C", Offset = "0x84486C")]
			remove
			{
			}
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x18EB500", Offset = "0x18EB500", VA = "0x18EB500")]
		public static WWWTextureLoader Create()
		{
			return null;
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x18EB57C", Offset = "0x18EB57C", VA = "0x18EB57C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x18EB5F8", Offset = "0x18EB5F8", VA = "0x18EB5F8")]
		public void LoadTexture(string url)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x18EB760", Offset = "0x18EB760", VA = "0x18EB760")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x84487C", Offset = "0x84487C")]
		private IEnumerator LoadCoroutin()
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x18EB808", Offset = "0x18EB808", VA = "0x18EB808")]
		private static void UpdateLocalCache(string url, Texture2D image)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x18EB8EC", Offset = "0x18EB8EC", VA = "0x18EB8EC")]
		public WWWTextureLoader()
		{
		}
	}
}
namespace SA.Common.Animation
{
	[Token(Token = "0x2000026")]
	public enum EaseType
	{
		[Token(Token = "0x4000084")]
		easeInQuad,
		[Token(Token = "0x4000085")]
		easeOutQuad,
		[Token(Token = "0x4000086")]
		easeInOutQuad,
		[Token(Token = "0x4000087")]
		easeInCubic,
		[Token(Token = "0x4000088")]
		easeOutCubic,
		[Token(Token = "0x4000089")]
		easeInOutCubic,
		[Token(Token = "0x400008A")]
		easeInQuart,
		[Token(Token = "0x400008B")]
		easeOutQuart,
		[Token(Token = "0x400008C")]
		easeInOutQuart,
		[Token(Token = "0x400008D")]
		easeInQuint,
		[Token(Token = "0x400008E")]
		easeOutQuint,
		[Token(Token = "0x400008F")]
		easeInOutQuint,
		[Token(Token = "0x4000090")]
		easeInSine,
		[Token(Token = "0x4000091")]
		easeOutSine,
		[Token(Token = "0x4000092")]
		easeInOutSine,
		[Token(Token = "0x4000093")]
		easeInExpo,
		[Token(Token = "0x4000094")]
		easeOutExpo,
		[Token(Token = "0x4000095")]
		easeInOutExpo,
		[Token(Token = "0x4000096")]
		easeInCirc,
		[Token(Token = "0x4000097")]
		easeOutCirc,
		[Token(Token = "0x4000098")]
		easeInOutCirc,
		[Token(Token = "0x4000099")]
		linear,
		[Token(Token = "0x400009A")]
		spring,
		[Token(Token = "0x400009B")]
		easeInBounce,
		[Token(Token = "0x400009C")]
		easeOutBounce,
		[Token(Token = "0x400009D")]
		easeInOutBounce,
		[Token(Token = "0x400009E")]
		easeInBack,
		[Token(Token = "0x400009F")]
		easeOutBack,
		[Token(Token = "0x40000A0")]
		easeInOutBack,
		[Token(Token = "0x40000A1")]
		easeInElastic,
		[Token(Token = "0x40000A2")]
		easeOutElastic,
		[Token(Token = "0x40000A3")]
		easeInOutElastic,
		[Token(Token = "0x40000A4")]
		punch
	}
	[Token(Token = "0x2000027")]
	public class ValuesTween : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000052")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8443F4", Offset = "0x8443F4")]
		private sealed class <>c
		{
			[Token(Token = "0x400034A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400034B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action <>9__20_0;

			[Token(Token = "0x400034C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action<float> <>9__20_1;

			[Token(Token = "0x400034D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Action<Vector3> <>9__20_2;

			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x18E7CF0", Offset = "0x18E7CF0", VA = "0x18E7CF0")]
			public <>c()
			{
			}

			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x18E7CF8", Offset = "0x18E7CF8", VA = "0x18E7CF8")]
			internal void <.ctor>b__20_0()
			{
			}

			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x18E7CFC", Offset = "0x18E7CFC", VA = "0x18E7CFC")]
			internal void <.ctor>b__20_1(float <p0>)
			{
			}

			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x18E7D00", Offset = "0x18E7D00", VA = "0x18E7D00")]
			internal void <.ctor>b__20_2(Vector3 <p0>)
			{
			}
		}

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool DestoryGameObjectOnComplete;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float FinalFloatValue;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 FinalVectorValue;

		[Token(Token = "0x14000003")]
		public event Action OnComplete
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x18E62C4", Offset = "0x18E62C4", VA = "0x18E62C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8448E0", Offset = "0x8448E0")]
			add
			{
			}
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x18E6368", Offset = "0x18E6368", VA = "0x18E6368")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8448F0", Offset = "0x8448F0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event Action<float> OnValueChanged
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x18E640C", Offset = "0x18E640C", VA = "0x18E640C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844900", Offset = "0x844900")]
			add
			{
			}
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x18E64B0", Offset = "0x18E64B0", VA = "0x18E64B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844910", Offset = "0x844910")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event Action<Vector3> OnVectorValueChanged
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x18E6554", Offset = "0x18E6554", VA = "0x18E6554")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844920", Offset = "0x844920")]
			add
			{
			}
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x18E65F8", Offset = "0x18E65F8", VA = "0x18E65F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844930", Offset = "0x844930")]
			remove
			{
			}
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x18E669C", Offset = "0x18E669C", VA = "0x18E669C")]
		public static ValuesTween Create()
		{
			return null;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x18E6718", Offset = "0x18E6718", VA = "0x18E6718")]
		private void Update()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x18E67C0", Offset = "0x18E67C0", VA = "0x18E67C0")]
		public void ValueTo(float from, float to, float time, EaseType easeType = EaseType.linear)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x18E6BF0", Offset = "0x18E6BF0", VA = "0x18E6BF0")]
		public void VectorTo(Vector3 from, Vector3 to, float time, EaseType easeType = EaseType.linear)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x18E7028", Offset = "0x18E7028", VA = "0x18E7028")]
		public void ScaleTo(Vector3 from, Vector3 to, float time, EaseType easeType = EaseType.linear)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x18E7460", Offset = "0x18E7460", VA = "0x18E7460")]
		public void VectorToS(Vector3 from, Vector3 to, float speed, EaseType easeType = EaseType.linear)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x18E7898", Offset = "0x18E7898", VA = "0x18E7898")]
		public void Stop()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x18E7954", Offset = "0x18E7954", VA = "0x18E7954")]
		private void onTweenComplete()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x18E7A48", Offset = "0x18E7A48", VA = "0x18E7A48")]
		public ValuesTween()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class SA_iTween : MonoBehaviour
	{
		[Token(Token = "0x2000053")]
		private delegate float EasingFunction(float start, float end, float Value);

		[Token(Token = "0x2000054")]
		private delegate void ApplyTween();

		[Token(Token = "0x2000055")]
		public enum LoopType
		{
			[Token(Token = "0x400034F")]
			none,
			[Token(Token = "0x4000350")]
			loop,
			[Token(Token = "0x4000351")]
			pingPong
		}

		[Token(Token = "0x2000056")]
		public enum NamedValueColor
		{
			[Token(Token = "0x4000353")]
			_Color,
			[Token(Token = "0x4000354")]
			_SpecColor,
			[Token(Token = "0x4000355")]
			_Emission,
			[Token(Token = "0x4000356")]
			_ReflectColor
		}

		[Token(Token = "0x2000057")]
		public static class Defaults
		{
			[Token(Token = "0x4000357")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static float time;

			[Token(Token = "0x4000358")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static float delay;

			[Token(Token = "0x4000359")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static NamedValueColor namedColorValue;

			[Token(Token = "0x400035A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static LoopType loopType;

			[Token(Token = "0x400035B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static EaseType easeType;

			[Token(Token = "0x400035C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public static float lookSpeed;

			[Token(Token = "0x400035D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static bool isLocal;

			[Token(Token = "0x400035E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public static Space space;

			[Token(Token = "0x400035F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static bool orientToPath;

			[Token(Token = "0x4000360")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public static Color color;

			[Token(Token = "0x4000361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public static float updateTimePercentage;

			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static float updateTime;

			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public static int cameraFadeDepth;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static float lookAhead;

			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public static bool useRealTime;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static Vector3 up;
		}

		[Token(Token = "0x2000058")]
		private class CRSpline
		{
			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] pts;

			[Token(Token = "0x6000303")]
			[Address(RVA = "0x18E592C", Offset = "0x18E592C", VA = "0x18E592C")]
			public CRSpline(params Vector3[] pts)
			{
			}

			[Token(Token = "0x6000304")]
			[Address(RVA = "0x18E59C0", Offset = "0x18E59C0", VA = "0x18E59C0")]
			public Vector3 Interp(float t)
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000059")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844404", Offset = "0x844404")]
		private sealed class <TweenDelay>d__149 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SA_iTween <>4__this;

			[Token(Token = "0x1700003A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000308")]
				[Address(RVA = "0x18E54DC", Offset = "0x18E54DC", VA = "0x18E54DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600030A")]
				[Address(RVA = "0x18E5544", Offset = "0x18E5544", VA = "0x18E5544", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000305")]
			[Address(RVA = "0x18E53CC", Offset = "0x18E53CC", VA = "0x18E53CC")]
			[DebuggerHidden]
			public <TweenDelay>d__149(int <>1__state)
			{
			}

			[Token(Token = "0x6000306")]
			[Address(RVA = "0x18E53F8", Offset = "0x18E53F8", VA = "0x18E53F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000307")]
			[Address(RVA = "0x18E53FC", Offset = "0x18E53FC", VA = "0x18E53FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000309")]
			[Address(RVA = "0x18E54E4", Offset = "0x18E54E4", VA = "0x18E54E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200005A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844414", Offset = "0x844414")]
		private sealed class <TweenRestart>d__151 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SA_iTween <>4__this;

			[Token(Token = "0x1700003C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600030E")]
				[Address(RVA = "0x18E5664", Offset = "0x18E5664", VA = "0x18E5664", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000310")]
				[Address(RVA = "0x18E56CC", Offset = "0x18E56CC", VA = "0x18E56CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600030B")]
			[Address(RVA = "0x18E554C", Offset = "0x18E554C", VA = "0x18E554C")]
			[DebuggerHidden]
			public <TweenRestart>d__151(int <>1__state)
			{
			}

			[Token(Token = "0x600030C")]
			[Address(RVA = "0x18E5578", Offset = "0x18E5578", VA = "0x18E5578", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600030D")]
			[Address(RVA = "0x18E557C", Offset = "0x18E557C", VA = "0x18E557C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600030F")]
			[Address(RVA = "0x18E566C", Offset = "0x18E566C", VA = "0x18E566C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200005B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844424", Offset = "0x844424")]
		private sealed class <Start>d__240 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400036F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SA_iTween <>4__this;

			[Token(Token = "0x1700003E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000314")]
				[Address(RVA = "0x18E535C", Offset = "0x18E535C", VA = "0x18E535C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000316")]
				[Address(RVA = "0x18E53C4", Offset = "0x18E53C4", VA = "0x18E53C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000311")]
			[Address(RVA = "0x18E5274", Offset = "0x18E5274", VA = "0x18E5274")]
			[DebuggerHidden]
			public <Start>d__240(int <>1__state)
			{
			}

			[Token(Token = "0x6000312")]
			[Address(RVA = "0x18E52A0", Offset = "0x18E52A0", VA = "0x18E52A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000313")]
			[Address(RVA = "0x18E52A4", Offset = "0x18E52A4", VA = "0x18E52A4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000315")]
			[Address(RVA = "0x18E5364", Offset = "0x18E5364", VA = "0x18E5364", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<Hashtable> tweens;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static GameObject cameraFade;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string id;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string type;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string method;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EaseType easeType;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float time;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float delay;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public LoopType loopType;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isRunning;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool isPaused;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string _name;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float runningTime;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float percentage;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float delayStarted;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool kinematic;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool isLocal;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		private bool loop;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
		private bool reverse;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool wasPaused;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool physics;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Hashtable tweenArguments;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Space space;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private EasingFunction ease;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ApplyTween apply;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AudioSource audioSource;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] vector3s;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector2[] vector2s;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Color[,] colors;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float[] floats;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Rect[] rects;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private CRSpline path;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3 preUpdate;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Vector3 postUpdate;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private NamedValueColor namedcolorvalue;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private float lastRealTime;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool useRealTime;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform thisTransform;

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xC33C48", Offset = "0xC33C48", VA = "0xC33C48")]
		public static void Init(GameObject target)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xC33F04", Offset = "0xC33F04", VA = "0xC33F04")]
		public static void CameraFadeFrom(float amount, float time)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xC342B0", Offset = "0xC342B0", VA = "0xC342B0")]
		public static void CameraFadeFrom(Hashtable args)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xC34DA0", Offset = "0xC34DA0", VA = "0xC34DA0")]
		public static void CameraFadeTo(float amount, float time)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xC3501C", Offset = "0xC3501C", VA = "0xC3501C")]
		public static void CameraFadeTo(Hashtable args)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xC35618", Offset = "0xC35618", VA = "0xC35618")]
		public static void ValueTo(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xC365E8", Offset = "0xC365E8", VA = "0xC365E8")]
		public static void FadeFrom(GameObject target, float alpha, float time)
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xC367D0", Offset = "0xC367D0", VA = "0xC367D0")]
		public static void FadeFrom(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xC36844", Offset = "0xC36844", VA = "0xC36844")]
		public static void FadeTo(GameObject target, float alpha, float time)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xC36A2C", Offset = "0xC36A2C", VA = "0xC36A2C")]
		public static void FadeTo(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xC36AA0", Offset = "0xC36AA0", VA = "0xC36AA0")]
		public static void ColorFrom(GameObject target, Color color, float time)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xC343C0", Offset = "0xC343C0", VA = "0xC343C0")]
		public static void ColorFrom(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xC36CB4", Offset = "0xC36CB4", VA = "0xC36CB4")]
		public static void ColorTo(GameObject target, Color color, float time)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xC3512C", Offset = "0xC3512C", VA = "0xC3512C")]
		public static void ColorTo(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xC36EC8", Offset = "0xC36EC8", VA = "0xC36EC8")]
		public static void AudioFrom(GameObject target, float volume, float pitch, float time)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xC37148", Offset = "0xC37148", VA = "0xC37148")]
		public static void AudioFrom(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xC37550", Offset = "0xC37550", VA = "0xC37550")]
		public static void AudioTo(GameObject target, float volume, float pitch, float time)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xC377D0", Offset = "0xC377D0", VA = "0xC377D0")]
		public static void AudioTo(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xC3792C", Offset = "0xC3792C", VA = "0xC3792C")]
		public static void Stab(GameObject target, AudioClip audioclip, float delay)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xC37AF8", Offset = "0xC37AF8", VA = "0xC37AF8")]
		public static void Stab(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xC37BA8", Offset = "0xC37BA8", VA = "0xC37BA8")]
		public static void LookFrom(GameObject target, Vector3 looktarget, float time)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xC37DAC", Offset = "0xC37DAC", VA = "0xC37DAC")]
		public static void LookFrom(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xC3840C", Offset = "0xC3840C", VA = "0xC3840C")]
		public static void LookTo(GameObject target, Vector3 looktarget, float time)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xC38610", Offset = "0xC38610", VA = "0xC38610")]
		public static void LookTo(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xC38930", Offset = "0xC38930", VA = "0xC38930")]
		public static void MoveTo(GameObject target, Vector3 position, float time)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xC38B34", Offset = "0xC38B34", VA = "0xC38B34")]
		public static void MoveTo(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xC38ED4", Offset = "0xC38ED4", VA = "0xC38ED4")]
		public static void MoveFrom(GameObject target, Vector3 position, float time)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xC390D8", Offset = "0xC390D8", VA = "0xC390D8")]
		public static void MoveFrom(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xC399D8", Offset = "0xC399D8", VA = "0xC399D8")]
		public static void MoveAdd(GameObject target, Vector3 amount, float time)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xC39BDC", Offset = "0xC39BDC", VA = "0xC39BDC")]
		public static void MoveAdd(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xC33D00", Offset = "0xC33D00", VA = "0xC33D00")]
		public static void MoveBy(GameObject target, Vector3 amount, float time)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xC39CB8", Offset = "0xC39CB8", VA = "0xC39CB8")]
		public static void MoveBy(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xC39D94", Offset = "0xC39D94", VA = "0xC39D94")]
		public static void ScaleTo(GameObject target, Vector3 scale, float time)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xC39F98", Offset = "0xC39F98", VA = "0xC39F98")]
		public static void ScaleTo(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xC3A330", Offset = "0xC3A330", VA = "0xC3A330")]
		public static void ScaleFrom(GameObject target, Vector3 scale, float time)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xC3A534", Offset = "0xC3A534", VA = "0xC3A534")]
		public static void ScaleFrom(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xC3A9E0", Offset = "0xC3A9E0", VA = "0xC3A9E0")]
		public static void ScaleAdd(GameObject target, Vector3 amount, float time)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xC3ABE4", Offset = "0xC3ABE4", VA = "0xC3ABE4")]
		public static void ScaleAdd(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xC3ACC0", Offset = "0xC3ACC0", VA = "0xC3ACC0")]
		public static void ScaleBy(GameObject target, Vector3 amount, float time)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xC3AEC4", Offset = "0xC3AEC4", VA = "0xC3AEC4")]
		public static void ScaleBy(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xC3AFA0", Offset = "0xC3AFA0", VA = "0xC3AFA0")]
		public static void RotateTo(GameObject target, Vector3 rotation, float time)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xC3B1A4", Offset = "0xC3B1A4", VA = "0xC3B1A4")]
		public static void RotateTo(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xC3B544", Offset = "0xC3B544", VA = "0xC3B544")]
		public static void RotateFrom(GameObject target, Vector3 rotation, float time)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xC3B748", Offset = "0xC3B748", VA = "0xC3B748")]
		public static void RotateFrom(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xC3BCAC", Offset = "0xC3BCAC", VA = "0xC3BCAC")]
		public static void RotateAdd(GameObject target, Vector3 amount, float time)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xC3BEB0", Offset = "0xC3BEB0", VA = "0xC3BEB0")]
		public static void RotateAdd(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xC3BF8C", Offset = "0xC3BF8C", VA = "0xC3BF8C")]
		public static void RotateBy(GameObject target, Vector3 amount, float time)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xC3C190", Offset = "0xC3C190", VA = "0xC3C190")]
		public static void RotateBy(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xC3C26C", Offset = "0xC3C26C", VA = "0xC3C26C")]
		public static void ShakePosition(GameObject target, Vector3 amount, float time)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xC3C470", Offset = "0xC3C470", VA = "0xC3C470")]
		public static void ShakePosition(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xC3C54C", Offset = "0xC3C54C", VA = "0xC3C54C")]
		public static void ShakeScale(GameObject target, Vector3 amount, float time)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xC3C750", Offset = "0xC3C750", VA = "0xC3C750")]
		public static void ShakeScale(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xC3C82C", Offset = "0xC3C82C", VA = "0xC3C82C")]
		public static void ShakeRotation(GameObject target, Vector3 amount, float time)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xC3CA30", Offset = "0xC3CA30", VA = "0xC3CA30")]
		public static void ShakeRotation(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xC3CB0C", Offset = "0xC3CB0C", VA = "0xC3CB0C")]
		public static void PunchPosition(GameObject target, Vector3 amount, float time)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xC3CD10", Offset = "0xC3CD10", VA = "0xC3CD10")]
		public static void PunchPosition(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xC3CE30", Offset = "0xC3CE30", VA = "0xC3CE30")]
		public static void PunchRotation(GameObject target, Vector3 amount, float time)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xC3D034", Offset = "0xC3D034", VA = "0xC3D034")]
		public static void PunchRotation(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xC3D154", Offset = "0xC3D154", VA = "0xC3D154")]
		public static void PunchScale(GameObject target, Vector3 amount, float time)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xC3D358", Offset = "0xC3D358", VA = "0xC3D358")]
		public static void PunchScale(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xC3D478", Offset = "0xC3D478", VA = "0xC3D478")]
		private void GenerateTargets()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xC3E538", Offset = "0xC3E538", VA = "0xC3E538")]
		private void GenerateRectTargets()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xC3E3C0", Offset = "0xC3E3C0", VA = "0xC3E3C0")]
		private void GenerateColorTargets()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xC3E154", Offset = "0xC3E154", VA = "0xC3E154")]
		private void GenerateVector3Targets()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xC3DEB4", Offset = "0xC3DEB4", VA = "0xC3DEB4")]
		private void GenerateVector2Targets()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xC3DCB4", Offset = "0xC3DCB4", VA = "0xC3DCB4")]
		private void GenerateFloatTargets()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xC3E680", Offset = "0xC3E680", VA = "0xC3E680")]
		private void GenerateColorToTargets()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xC3F000", Offset = "0xC3F000", VA = "0xC3F000")]
		private void GenerateAudioToTargets()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xC43EB0", Offset = "0xC43EB0", VA = "0xC43EB0")]
		private void GenerateStabTargets()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xC43678", Offset = "0xC43678", VA = "0xC43678")]
		private void GenerateLookToTargets()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xC3F328", Offset = "0xC3F328", VA = "0xC3F328")]
		private void GenerateMoveToPathTargets()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xC3FA7C", Offset = "0xC3FA7C", VA = "0xC3FA7C")]
		private void GenerateMoveToTargets()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xC400CC", Offset = "0xC400CC", VA = "0xC400CC")]
		private void GenerateMoveByTargets()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xC406DC", Offset = "0xC406DC", VA = "0xC406DC")]
		private void GenerateScaleToTargets()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xC40C38", Offset = "0xC40C38", VA = "0xC40C38")]
		private void GenerateScaleByTargets()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xC410A0", Offset = "0xC410A0", VA = "0xC410A0")]
		private void GenerateScaleAddTargets()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xC414FC", Offset = "0xC414FC", VA = "0xC414FC")]
		private void GenerateRotateToTargets()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xC41B30", Offset = "0xC41B30", VA = "0xC41B30")]
		private void GenerateRotateAddTargets()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xC41F94", Offset = "0xC41F94", VA = "0xC41F94")]
		private void GenerateRotateByTargets()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xC42464", Offset = "0xC42464", VA = "0xC42464")]
		private void GenerateShakePositionTargets()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xC42764", Offset = "0xC42764", VA = "0xC42764")]
		private void GenerateShakeScaleTargets()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xC42A38", Offset = "0xC42A38", VA = "0xC42A38")]
		private void GenerateShakeRotationTargets()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xC42D0C", Offset = "0xC42D0C", VA = "0xC42D0C")]
		private void GeneratePunchPositionTargets()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xC43050", Offset = "0xC43050", VA = "0xC43050")]
		private void GeneratePunchRotationTargets()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xC43368", Offset = "0xC43368", VA = "0xC43368")]
		private void GeneratePunchScaleTargets()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xC445DC", Offset = "0xC445DC", VA = "0xC445DC")]
		private void ApplyRectTargets()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xC448DC", Offset = "0xC448DC", VA = "0xC448DC")]
		private void ApplyColorTargets()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xC44B0C", Offset = "0xC44B0C", VA = "0xC44B0C")]
		private void ApplyVector3Targets()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xC44D00", Offset = "0xC44D00", VA = "0xC44D00")]
		private void ApplyVector2Targets()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xC44EA0", Offset = "0xC44EA0", VA = "0xC44EA0")]
		private void ApplyFloatTargets()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xC44FF8", Offset = "0xC44FF8", VA = "0xC44FF8")]
		private void ApplyColorToTargets()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xC45558", Offset = "0xC45558", VA = "0xC45558")]
		private void ApplyAudioToTargets()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xC456C4", Offset = "0xC456C4", VA = "0xC456C4")]
		private void ApplyStabTargets()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xC456C8", Offset = "0xC456C8", VA = "0xC456C8")]
		private void ApplyMoveToPathTargets()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xC45A40", Offset = "0xC45A40", VA = "0xC45A40")]
		private void ApplyMoveToTargets()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xC45C64", Offset = "0xC45C64", VA = "0xC45C64")]
		private void ApplyMoveByTargets()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xC45FBC", Offset = "0xC45FBC", VA = "0xC45FBC")]
		private void ApplyScaleToTargets()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xC46124", Offset = "0xC46124", VA = "0xC46124")]
		private void ApplyLookToTargets()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xC462FC", Offset = "0xC462FC", VA = "0xC462FC")]
		private void ApplyRotateToTargets()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xC46644", Offset = "0xC46644", VA = "0xC46644")]
		private void ApplyRotateAddTargets()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xC468F0", Offset = "0xC468F0", VA = "0xC468F0")]
		private void ApplyShakePositionTargets()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xC46D20", Offset = "0xC46D20", VA = "0xC46D20")]
		private void ApplyShakeScaleTargets()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xC46F34", Offset = "0xC46F34", VA = "0xC46F34")]
		private void ApplyShakeRotationTargets()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xC471BC", Offset = "0xC471BC", VA = "0xC471BC")]
		private void ApplyPunchPositionTargets()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xC47688", Offset = "0xC47688", VA = "0xC47688")]
		private void ApplyPunchRotationTargets()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xC479E8", Offset = "0xC479E8", VA = "0xC479E8")]
		private void ApplyPunchScaleTargets()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xC47C48", Offset = "0xC47C48", VA = "0xC47C48")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x844940", Offset = "0x844940")]
		private IEnumerator TweenDelay()
		{
			return null;
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xC47CC4", Offset = "0xC47CC4", VA = "0xC47CC4")]
		private void TweenStart()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xC48658", Offset = "0xC48658", VA = "0xC48658")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8449A4", Offset = "0x8449A4")]
		private IEnumerator TweenRestart()
		{
			return null;
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xC486D4", Offset = "0xC486D4", VA = "0xC486D4")]
		private void TweenUpdate()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xC487B8", Offset = "0xC487B8", VA = "0xC487B8")]
		private void TweenComplete()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xC48888", Offset = "0xC48888", VA = "0xC48888")]
		private void TweenLoop()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xC4892C", Offset = "0xC4892C", VA = "0xC4892C")]
		public static Rect RectUpdate(Rect currentValue, Rect targetValue, float speed)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xC48AF4", Offset = "0xC48AF4", VA = "0xC48AF4")]
		public static Vector3 Vector3Update(Vector3 currentValue, Vector3 targetValue, float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xC48C00", Offset = "0xC48C00", VA = "0xC48C00")]
		public static Vector2 Vector2Update(Vector2 currentValue, Vector2 targetValue, float speed)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xC48AB4", Offset = "0xC48AB4", VA = "0xC48AB4")]
		public static float FloatUpdate(float currentValue, float targetValue, float speed)
		{
			return default(float);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xC48CE4", Offset = "0xC48CE4", VA = "0xC48CE4")]
		public static void FadeUpdate(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xC49760", Offset = "0xC49760", VA = "0xC49760")]
		public static void FadeUpdate(GameObject target, float alpha, float time)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xC48DA4", Offset = "0xC48DA4", VA = "0xC48DA4")]
		public static void ColorUpdate(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xC49948", Offset = "0xC49948", VA = "0xC49948")]
		public static void ColorUpdate(GameObject target, Color color, float time)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xC49B5C", Offset = "0xC49B5C", VA = "0xC49B5C")]
		public static void AudioUpdate(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xC4A00C", Offset = "0xC4A00C", VA = "0xC4A00C")]
		public static void AudioUpdate(GameObject target, float volume, float pitch, float time)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xC4A28C", Offset = "0xC4A28C", VA = "0xC4A28C")]
		public static void RotateUpdate(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xC4A8F0", Offset = "0xC4A8F0", VA = "0xC4A8F0")]
		public static void RotateUpdate(GameObject target, Vector3 rotation, float time)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xC4AAF4", Offset = "0xC4AAF4", VA = "0xC4AAF4")]
		public static void ScaleUpdate(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xC4B0DC", Offset = "0xC4B0DC", VA = "0xC4B0DC")]
		public static void ScaleUpdate(GameObject target, Vector3 scale, float time)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xC4B2E0", Offset = "0xC4B2E0", VA = "0xC4B2E0")]
		public static void MoveUpdate(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xC4C488", Offset = "0xC4C488", VA = "0xC4C488")]
		public static void MoveUpdate(GameObject target, Vector3 position, float time)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xC4BB7C", Offset = "0xC4BB7C", VA = "0xC4BB7C")]
		public static void LookUpdate(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xC4C68C", Offset = "0xC4C68C", VA = "0xC4C68C")]
		public static void LookUpdate(GameObject target, Vector3 looktarget, float time)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xC4C890", Offset = "0xC4C890", VA = "0xC4C890")]
		public static float PathLength(Transform[] path)
		{
			return default(float);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xC44464", Offset = "0xC44464", VA = "0xC44464")]
		public static float PathLength(Vector3[] path)
		{
			return default(float);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xC4D174", Offset = "0xC4D174", VA = "0xC4D174")]
		public static Texture2D CameraTexture(Color color)
		{
			return null;
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xC4D2C0", Offset = "0xC4D2C0", VA = "0xC4D2C0")]
		public static void PutOnPath(GameObject target, Vector3[] path, float percent)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xC4D370", Offset = "0xC4D370", VA = "0xC4D370")]
		public static void PutOnPath(Transform target, Vector3[] path, float percent)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xC4D408", Offset = "0xC4D408", VA = "0xC4D408")]
		public static void PutOnPath(GameObject target, Transform[] path, float percent)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xC4D540", Offset = "0xC4D540", VA = "0xC4D540")]
		public static void PutOnPath(Transform target, Transform[] path, float percent)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xC4D660", Offset = "0xC4D660", VA = "0xC4D660")]
		public static Vector3 PointOnPath(Transform[] path, float percent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xC4D76C", Offset = "0xC4D76C", VA = "0xC4D76C")]
		public static void DrawLine(Vector3[] line)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xC4D9D0", Offset = "0xC4D9D0", VA = "0xC4D9D0")]
		public static void DrawLine(Vector3[] line, Color color)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xC4DA94", Offset = "0xC4DA94", VA = "0xC4DA94")]
		public static void DrawLine(Transform[] line)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xC4DC08", Offset = "0xC4DC08", VA = "0xC4DC08")]
		public static void DrawLine(Transform[] line, Color color)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xC4DD5C", Offset = "0xC4DD5C", VA = "0xC4DD5C")]
		public static void DrawLineGizmos(Vector3[] line)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xC4DE40", Offset = "0xC4DE40", VA = "0xC4DE40")]
		public static void DrawLineGizmos(Vector3[] line, Color color)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xC4DF04", Offset = "0xC4DF04", VA = "0xC4DF04")]
		public static void DrawLineGizmos(Transform[] line)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xC4E078", Offset = "0xC4E078", VA = "0xC4E078")]
		public static void DrawLineGizmos(Transform[] line, Color color)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xC4E1CC", Offset = "0xC4E1CC", VA = "0xC4E1CC")]
		public static void DrawLineHandles(Vector3[] line)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xC4E2B0", Offset = "0xC4E2B0", VA = "0xC4E2B0")]
		public static void DrawLineHandles(Vector3[] line, Color color)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xC4E374", Offset = "0xC4E374", VA = "0xC4E374")]
		public static void DrawLineHandles(Transform[] line)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xC4E4E8", Offset = "0xC4E4E8", VA = "0xC4E4E8")]
		public static void DrawLineHandles(Transform[] line, Color color)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xC4E63C", Offset = "0xC4E63C", VA = "0xC4E63C")]
		public static Vector3 PointOnPath(Vector3[] path, float percent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xC4E6B4", Offset = "0xC4E6B4", VA = "0xC4E6B4")]
		public static void DrawPath(Vector3[] path)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xC4E98C", Offset = "0xC4E98C", VA = "0xC4E98C")]
		public static void DrawPath(Vector3[] path, Color color)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xC4EA50", Offset = "0xC4EA50", VA = "0xC4EA50")]
		public static void DrawPath(Transform[] path)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xC4EBC4", Offset = "0xC4EBC4", VA = "0xC4EBC4")]
		public static void DrawPath(Transform[] path, Color color)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xC4ED18", Offset = "0xC4ED18", VA = "0xC4ED18")]
		public static void DrawPathGizmos(Vector3[] path)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xC4EDFC", Offset = "0xC4EDFC", VA = "0xC4EDFC")]
		public static void DrawPathGizmos(Vector3[] path, Color color)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xC4EEC0", Offset = "0xC4EEC0", VA = "0xC4EEC0")]
		public static void DrawPathGizmos(Transform[] path)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xC4F034", Offset = "0xC4F034", VA = "0xC4F034")]
		public static void DrawPathGizmos(Transform[] path, Color color)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xC4F188", Offset = "0xC4F188", VA = "0xC4F188")]
		public static void DrawPathHandles(Vector3[] path)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xC4F26C", Offset = "0xC4F26C", VA = "0xC4F26C")]
		public static void DrawPathHandles(Vector3[] path, Color color)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xC4F330", Offset = "0xC4F330", VA = "0xC4F330")]
		public static void DrawPathHandles(Transform[] path)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xC4F4A4", Offset = "0xC4F4A4", VA = "0xC4F4A4")]
		public static void DrawPathHandles(Transform[] path, Color color)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xC4F5F8", Offset = "0xC4F5F8", VA = "0xC4F5F8")]
		public static void CameraFadeDepth(int depth)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xC4F76C", Offset = "0xC4F76C", VA = "0xC4F76C")]
		public static void CameraFadeDestroy()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xC4F868", Offset = "0xC4F868", VA = "0xC4F868")]
		public static void CameraFadeSwap(Texture2D texture)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xC4F86C", Offset = "0xC4F86C", VA = "0xC4F86C")]
		public static GameObject CameraFadeAdd(Texture2D texture, int depth)
		{
			return null;
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xC4F9DC", Offset = "0xC4F9DC", VA = "0xC4F9DC")]
		public static GameObject CameraFadeAdd(Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xC4FB78", Offset = "0xC4FB78", VA = "0xC4FB78")]
		public static GameObject CameraFadeAdd()
		{
			return null;
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xC4FD14", Offset = "0xC4FD14", VA = "0xC4FD14")]
		public static void Resume(GameObject target)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xC4FE04", Offset = "0xC4FE04", VA = "0xC4FE04")]
		public static void Resume(GameObject target, bool includechildren)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xC500B0", Offset = "0xC500B0", VA = "0xC500B0")]
		public static void Resume(GameObject target, string type)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xC50208", Offset = "0xC50208", VA = "0xC50208")]
		public static void Resume(GameObject target, string type, bool includechildren)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xC505A4", Offset = "0xC505A4", VA = "0xC505A4")]
		public static void Resume()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xC506C4", Offset = "0xC506C4", VA = "0xC506C4")]
		public static void Resume(string type)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xC508F4", Offset = "0xC508F4", VA = "0xC508F4")]
		public static void Pause(GameObject target)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xC50A40", Offset = "0xC50A40", VA = "0xC50A40")]
		public static void Pause(GameObject target, bool includechildren)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xC50CEC", Offset = "0xC50CEC", VA = "0xC50CEC")]
		public static void Pause(GameObject target, string type)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xC50E98", Offset = "0xC50E98", VA = "0xC50E98")]
		public static void Pause(GameObject target, string type, bool includechildren)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xC51288", Offset = "0xC51288", VA = "0xC51288")]
		public static void Pause()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xC513A8", Offset = "0xC513A8", VA = "0xC513A8")]
		public static void Pause(string type)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xC515D8", Offset = "0xC515D8", VA = "0xC515D8")]
		public static int Count()
		{
			return default(int);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xC5164C", Offset = "0xC5164C", VA = "0xC5164C")]
		public static int Count(string type)
		{
			return default(int);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xC51828", Offset = "0xC51828", VA = "0xC51828")]
		public static int Count(GameObject target)
		{
			return default(int);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xC5188C", Offset = "0xC5188C", VA = "0xC5188C")]
		public static int Count(GameObject target, string type)
		{
			return default(int);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xC519E8", Offset = "0xC519E8", VA = "0xC519E8")]
		public static void Stop()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xC51C20", Offset = "0xC51C20", VA = "0xC51C20")]
		public static void Stop(string type)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xC51FA0", Offset = "0xC51FA0", VA = "0xC51FA0")]
		public static void StopByName(string name)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xC51B38", Offset = "0xC51B38", VA = "0xC51B38")]
		public static void Stop(GameObject target)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xC522E0", Offset = "0xC522E0", VA = "0xC522E0")]
		public static void Stop(GameObject target, bool includechildren)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xC51E50", Offset = "0xC51E50", VA = "0xC51E50")]
		public static void Stop(GameObject target, string type)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xC521D0", Offset = "0xC521D0", VA = "0xC521D0")]
		public static void StopByName(GameObject target, string name)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xC5258C", Offset = "0xC5258C", VA = "0xC5258C")]
		public static void Stop(GameObject target, string type, bool includechildren)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xC52920", Offset = "0xC52920", VA = "0xC52920")]
		public static void StopByName(GameObject target, string name, bool includechildren)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xC34180", Offset = "0xC34180", VA = "0xC34180")]
		public static Hashtable Hash(params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xC52C74", Offset = "0xC52C74", VA = "0xC52C74")]
		private SA_iTween(Hashtable h)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xC52CA8", Offset = "0xC52CA8", VA = "0xC52CA8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xC53D74", Offset = "0xC53D74", VA = "0xC53D74")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x844A08", Offset = "0x844A08")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xC53DF0", Offset = "0xC53DF0", VA = "0xC53DF0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xC53E30", Offset = "0xC53E30", VA = "0xC53E30")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xC53E70", Offset = "0xC53E70", VA = "0xC53E70")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xC53F84", Offset = "0xC53F84", VA = "0xC53F84")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xC54000", Offset = "0xC54000", VA = "0xC54000")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xC4D850", Offset = "0xC4D850", VA = "0xC4D850")]
		private static void DrawLineHelper(Vector3[] line, Color color, string method)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xC4E798", Offset = "0xC4E798", VA = "0xC4E798")]
		private static void DrawPathHelper(Vector3[] path, Color color, string method)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xC4CA84", Offset = "0xC4CA84", VA = "0xC4CA84")]
		private static Vector3[] PathControlPointGenerator(Vector3[] path)
		{
			return null;
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xC4CD48", Offset = "0xC4CD48", VA = "0xC4CD48")]
		private static Vector3 Interp(Vector3[] pts, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xC36494", Offset = "0xC36494", VA = "0xC36494")]
		private static void Launch(GameObject target, Hashtable args)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xC35AF4", Offset = "0xC35AF4", VA = "0xC35AF4")]
		private static Hashtable CleanArgs(Hashtable args)
		{
			return null;
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xC54004", Offset = "0xC54004", VA = "0xC54004")]
		private static string GenerateID()
		{
			return null;
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xC52CF0", Offset = "0xC52CF0", VA = "0xC52CF0")]
		private void RetrieveArgs()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xC54084", Offset = "0xC54084", VA = "0xC54084")]
		private void GetEasingFunction()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xC48740", Offset = "0xC48740", VA = "0xC48740")]
		private void UpdatePercentage()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xC47E3C", Offset = "0xC47E3C", VA = "0xC47E3C")]
		private void CallBack(string callbackType)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xC441F4", Offset = "0xC441F4", VA = "0xC441F4")]
		private void Dispose()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xC48114", Offset = "0xC48114", VA = "0xC48114")]
		private void ConflictCheck()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xC48654", Offset = "0xC48654", VA = "0xC48654")]
		private void EnableKinematic()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xC48928", Offset = "0xC48928", VA = "0xC48928")]
		private void DisableKinematic()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xC53FAC", Offset = "0xC53FAC", VA = "0xC53FAC")]
		private void ResumeDelay()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xC5448C", Offset = "0xC5448C", VA = "0xC5448C")]
		private float linear(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xC44390", Offset = "0xC44390", VA = "0xC44390")]
		private float clerp(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xC54514", Offset = "0xC54514", VA = "0xC54514")]
		private float spring(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xC54618", Offset = "0xC54618", VA = "0xC54618")]
		private float easeInQuad(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xC5462C", Offset = "0xC5462C", VA = "0xC5462C")]
		private float easeOutQuad(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xC54648", Offset = "0xC54648", VA = "0xC54648")]
		private float easeInOutQuad(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xC5469C", Offset = "0xC5469C", VA = "0xC5469C")]
		private float easeInCubic(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xC546B4", Offset = "0xC546B4", VA = "0xC546B4")]
		private float easeOutCubic(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xC546DC", Offset = "0xC546DC", VA = "0xC546DC")]
		private float easeInOutCubic(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xC54734", Offset = "0xC54734", VA = "0xC54734")]
		private float easeInQuart(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xC54750", Offset = "0xC54750", VA = "0xC54750")]
		private float easeOutQuart(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xC54778", Offset = "0xC54778", VA = "0xC54778")]
		private float easeInOutQuart(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xC547D4", Offset = "0xC547D4", VA = "0xC547D4")]
		private float easeInQuint(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xC547F4", Offset = "0xC547F4", VA = "0xC547F4")]
		private float easeOutQuint(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xC54824", Offset = "0xC54824", VA = "0xC54824")]
		private float easeInOutQuint(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xC5488C", Offset = "0xC5488C", VA = "0xC5488C")]
		private float easeInSine(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xC54924", Offset = "0xC54924", VA = "0xC54924")]
		private float easeOutSine(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xC549B8", Offset = "0xC549B8", VA = "0xC549B8")]
		private float easeInOutSine(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xC54A5C", Offset = "0xC54A5C", VA = "0xC54A5C")]
		private float easeInExpo(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xC54AF4", Offset = "0xC54AF4", VA = "0xC54AF4")]
		private float easeOutExpo(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xC54B8C", Offset = "0xC54B8C", VA = "0xC54B8C")]
		private float easeInOutExpo(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xC54C7C", Offset = "0xC54C7C", VA = "0xC54C7C")]
		private float easeInCirc(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xC54D28", Offset = "0xC54D28", VA = "0xC54D28")]
		private float easeOutCirc(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xC54DD4", Offset = "0xC54DD4", VA = "0xC54DD4")]
		private float easeInOutCirc(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xC54ECC", Offset = "0xC54ECC", VA = "0xC54ECC")]
		private float easeInBounce(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xC54F08", Offset = "0xC54F08", VA = "0xC54F08")]
		private float easeOutBounce(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xC54FD4", Offset = "0xC54FD4", VA = "0xC54FD4")]
		private float easeInOutBounce(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xC55058", Offset = "0xC55058", VA = "0xC55058")]
		private float easeInBack(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xC55088", Offset = "0xC55088", VA = "0xC55088")]
		private float easeOutBack(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xC550C8", Offset = "0xC550C8", VA = "0xC550C8")]
		private float easeInOutBack(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xC475C8", Offset = "0xC475C8", VA = "0xC475C8")]
		private float punch(float amplitude, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xC5514C", Offset = "0xC5514C", VA = "0xC5514C")]
		private float easeInElastic(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xC55234", Offset = "0xC55234", VA = "0xC55234")]
		private float easeOutElastic(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xC55318", Offset = "0xC55318", VA = "0xC55318")]
		private float easeInOutElastic(float start, float end, float value)
		{
			return default(float);
		}
	}
}
namespace SA.Common.Data
{
	[Token(Token = "0x2000029")]
	public class Converter
	{
		[Token(Token = "0x40000D1")]
		public const char DATA_SPLITTER = '|';

		[Token(Token = "0x40000D2")]
		public const string DATA_SPLITTER2 = "|%|";

		[Token(Token = "0x40000D3")]
		public const string ARRAY_SPLITTER = "%%%";

		[Token(Token = "0x40000D4")]
		public const string DATA_EOF = "endofline";

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x18E8388", Offset = "0x18E8388", VA = "0x18E8388")]
		public static string SerializeArray(List<string> array, string splitter = "%%%")
		{
			return null;
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x18E83F4", Offset = "0x18E83F4", VA = "0x18E83F4")]
		public static string SerializeArray(string[] array, string splitter = "%%%")
		{
			return null;
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x18E84CC", Offset = "0x18E84CC", VA = "0x18E84CC")]
		public static string[] ParseArray(string arrayData, string splitter = "%%%")
		{
			return null;
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x18E8654", Offset = "0x18E8654", VA = "0x18E8654")]
		public Converter()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public static class Json
	{
		[Token(Token = "0x200005C")]
		private sealed class Parser : IDisposable
		{
			[Token(Token = "0x2000063")]
			private enum TOKEN
			{
				[Token(Token = "0x4000386")]
				NONE,
				[Token(Token = "0x4000387")]
				CURLY_OPEN,
				[Token(Token = "0x4000388")]
				CURLY_CLOSE,
				[Token(Token = "0x4000389")]
				SQUARED_OPEN,
				[Token(Token = "0x400038A")]
				SQUARED_CLOSE,
				[Token(Token = "0x400038B")]
				COLON,
				[Token(Token = "0x400038C")]
				COMMA,
				[Token(Token = "0x400038D")]
				STRING,
				[Token(Token = "0x400038E")]
				NUMBER,
				[Token(Token = "0x400038F")]
				TRUE,
				[Token(Token = "0x4000390")]
				FALSE,
				[Token(Token = "0x4000391")]
				NULL
			}

			[Token(Token = "0x4000371")]
			private const string WHITE_SPACE = " \t\n\r";

			[Token(Token = "0x4000372")]
			private const string WORD_BREAK = " \t\n\r{}[],:\"";

			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StringReader json;

			[Token(Token = "0x17000040")]
			private char PeekChar
			{
				[Token(Token = "0x6000321")]
				[Address(RVA = "0x18E92C4", Offset = "0x18E92C4", VA = "0x18E92C4")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x17000041")]
			private char NextChar
			{
				[Token(Token = "0x6000322")]
				[Address(RVA = "0x18E90B4", Offset = "0x18E90B4", VA = "0x18E90B4")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x17000042")]
			private string NextWord
			{
				[Token(Token = "0x6000323")]
				[Address(RVA = "0x18E913C", Offset = "0x18E913C", VA = "0x18E913C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000043")]
			private TOKEN NextToken
			{
				[Token(Token = "0x6000324")]
				[Address(RVA = "0x18E8A10", Offset = "0x18E8A10", VA = "0x18E8A10")]
				get
				{
					return default(TOKEN);
				}
			}

			[Token(Token = "0x6000317")]
			[Address(RVA = "0x18E8814", Offset = "0x18E8814", VA = "0x18E8814")]
			private Parser(string jsonString)
			{
			}

			[Token(Token = "0x6000318")]
			[Address(RVA = "0x18E8668", Offset = "0x18E8668", VA = "0x18E8668")]
			public static object Parse(string jsonString)
			{
				return null;
			}

			[Token(Token = "0x6000319")]
			[Address(RVA = "0x18E88C0", Offset = "0x18E88C0", VA = "0x18E88C0", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x600031A")]
			[Address(RVA = "0x18E88FC", Offset = "0x18E88FC", VA = "0x18E88FC")]
			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			[Token(Token = "0x600031B")]
			[Address(RVA = "0x18E8E28", Offset = "0x18E8E28", VA = "0x18E8E28")]
			private List<object> ParseArray()
			{
				return null;
			}

			[Token(Token = "0x600031C")]
			[Address(RVA = "0x18E8898", Offset = "0x18E8898", VA = "0x18E8898")]
			private object ParseValue()
			{
				return null;
			}

			[Token(Token = "0x600031D")]
			[Address(RVA = "0x18E8EFC", Offset = "0x18E8EFC", VA = "0x18E8EFC")]
			private object ParseByToken(TOKEN token)
			{
				return null;
			}

			[Token(Token = "0x600031E")]
			[Address(RVA = "0x18E8BC0", Offset = "0x18E8BC0", VA = "0x18E8BC0")]
			private string ParseString()
			{
				return null;
			}

			[Token(Token = "0x600031F")]
			[Address(RVA = "0x18E8FD8", Offset = "0x18E8FD8", VA = "0x18E8FD8")]
			private object ParseNumber()
			{
				return null;
			}

			[Token(Token = "0x6000320")]
			[Address(RVA = "0x18E9220", Offset = "0x18E9220", VA = "0x18E9220")]
			private void EatWhitespace()
			{
			}
		}

		[Token(Token = "0x200005D")]
		private sealed class Serializer
		{
			[Token(Token = "0x4000374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StringBuilder builder;

			[Token(Token = "0x6000325")]
			[Address(RVA = "0x18E934C", Offset = "0x18E934C", VA = "0x18E934C")]
			private Serializer()
			{
			}

			[Token(Token = "0x6000326")]
			[Address(RVA = "0x18E8798", Offset = "0x18E8798", VA = "0x18E8798")]
			public static string Serialize(object obj)
			{
				return null;
			}

			[Token(Token = "0x6000327")]
			[Address(RVA = "0x18E93C0", Offset = "0x18E93C0", VA = "0x18E93C0")]
			private void SerializeValue(object value)
			{
			}

			[Token(Token = "0x6000328")]
			[Address(RVA = "0x18E9A70", Offset = "0x18E9A70", VA = "0x18E9A70")]
			private void SerializeObject(IDictionary obj)
			{
			}

			[Token(Token = "0x6000329")]
			[Address(RVA = "0x18E97B4", Offset = "0x18E97B4", VA = "0x18E97B4")]
			private void SerializeArray(IList anArray)
			{
			}

			[Token(Token = "0x600032A")]
			[Address(RVA = "0x18E9544", Offset = "0x18E9544", VA = "0x18E9544")]
			private void SerializeString(string str)
			{
			}

			[Token(Token = "0x600032B")]
			[Address(RVA = "0x18E9E58", Offset = "0x18E9E58", VA = "0x18E9E58")]
			private void SerializeOther(object value)
			{
			}
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x18E865C", Offset = "0x18E865C", VA = "0x18E865C")]
		public static object Deserialize(string json)
		{
			return null;
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x18E8794", Offset = "0x18E8794", VA = "0x18E8794")]
		public static string Serialize(object obj)
		{
			return null;
		}
	}
}
namespace SA.Manifest
{
	[Token(Token = "0x200002B")]
	public class Settings
	{
		[Token(Token = "0x40000D5")]
		public const string VERSION_NUMBER = "2.9/24";

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x18EF7CC", Offset = "0x18EF7CC", VA = "0x18EF7CC")]
		public Settings()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class ActivityTemplate : BaseTemplate
	{
		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool IsOpen;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _id;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _isLauncher;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string _name;

		[Token(Token = "0x17000018")]
		public bool IsLauncher
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x18EE5D4", Offset = "0x18EE5D4", VA = "0x18EE5D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000019")]
		public string Name
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x18EE5DC", Offset = "0x18EE5DC", VA = "0x18EE5DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public int Id
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x18EE5E4", Offset = "0x18EE5E4", VA = "0x18EE5E4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x18ED7EC", Offset = "0x18ED7EC", VA = "0x18ED7EC")]
		public ActivityTemplate(bool isLauncher, string name)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x18EDA7C", Offset = "0x18EDA7C", VA = "0x18EDA7C")]
		public void SetName(string name)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x18EDAEC", Offset = "0x18EDAEC", VA = "0x18EDAEC")]
		public void SetAsLauncher(bool isLauncher)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x18EDAF8", Offset = "0x18EDAF8", VA = "0x18EDAF8")]
		public static PropertyTemplate GetLauncherPropertyTemplate()
		{
			return null;
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x18EDD78", Offset = "0x18EDD78", VA = "0x18EDD78")]
		public bool IsLauncherProperty(PropertyTemplate property)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x18EDF80", Offset = "0x18EDF80", VA = "0x18EDF80", Slot = "4")]
		public override void ToXmlElement(XmlDocument doc, XmlElement parent)
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class ApplicationTemplate : BaseTemplate
	{
		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<int, ActivityTemplate> _activities;

		[Token(Token = "0x1700001B")]
		public Dictionary<int, ActivityTemplate> Activities
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x18EEBF0", Offset = "0x18EEBF0", VA = "0x18EEBF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x18EE5EC", Offset = "0x18EE5EC", VA = "0x18EE5EC")]
		public ApplicationTemplate()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x18EE664", Offset = "0x18EE664", VA = "0x18EE664")]
		public void AddActivity(ActivityTemplate activity)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x18EE6D4", Offset = "0x18EE6D4", VA = "0x18EE6D4")]
		public void RemoveActivity(ActivityTemplate activity)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x18EE740", Offset = "0x18EE740", VA = "0x18EE740")]
		public ActivityTemplate GetOrCreateActivityWithName(string name)
		{
			return null;
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x18EE7D0", Offset = "0x18EE7D0", VA = "0x18EE7D0")]
		public ActivityTemplate GetActivityWithName(string name)
		{
			return null;
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x18EE904", Offset = "0x18EE904", VA = "0x18EE904")]
		public ActivityTemplate GetLauncherActivity()
		{
			return null;
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x18EEA08", Offset = "0x18EEA08", VA = "0x18EEA08", Slot = "4")]
		public override void ToXmlElement(XmlDocument doc, XmlElement parent)
		{
		}
	}
	[Token(Token = "0x200002E")]
	public abstract class BaseTemplate
	{
		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected Dictionary<string, List<PropertyTemplate>> _properties;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Dictionary<string, string> _values;

		[Token(Token = "0x1700001C")]
		public Dictionary<string, string> Values
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x18EF468", Offset = "0x18EF468", VA = "0x18EF468")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public Dictionary<string, List<PropertyTemplate>> Properties
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x18EF470", Offset = "0x18EF470", VA = "0x18EF470")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x18EEBF8", Offset = "0x18EEBF8", VA = "0x18EEBF8")]
		public PropertyTemplate GetOrCreateIntentFilterWithName(string name)
		{
			return null;
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x18EECD8", Offset = "0x18EECD8", VA = "0x18EECD8")]
		public PropertyTemplate GetIntentFilterWithName(string name)
		{
			return null;
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x18EEEEC", Offset = "0x18EEEEC", VA = "0x18EEEEC")]
		public string GetIntentFilterName(PropertyTemplate intent)
		{
			return null;
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x18EF034", Offset = "0x18EF034", VA = "0x18EF034")]
		public PropertyTemplate GetOrCreatePropertyWithName(string tag, string name)
		{
			return null;
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x18EF0E8", Offset = "0x18EF0E8", VA = "0x18EF0E8")]
		public PropertyTemplate GetPropertyWithName(string tag, string name)
		{
			return null;
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x18EF274", Offset = "0x18EF274", VA = "0x18EF274")]
		public PropertyTemplate GetOrCreatePropertyWithTag(string tag)
		{
			return null;
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x18EF300", Offset = "0x18EF300", VA = "0x18EF300")]
		public PropertyTemplate GetPropertyWithTag(string tag)
		{
			return null;
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x18EEE2C", Offset = "0x18EEE2C", VA = "0x18EEE2C")]
		public List<PropertyTemplate> GetPropertiesWithTag(string tag)
		{
			return null;
		}

		[Token(Token = "0x60001DE")]
		public abstract void ToXmlElement(XmlDocument doc, XmlElement parent);

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x18ED910", Offset = "0x18ED910", VA = "0x18ED910")]
		public BaseTemplate()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x18EEE10", Offset = "0x18EEE10", VA = "0x18EEE10")]
		public void AddProperty(PropertyTemplate property)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x18EDC90", Offset = "0x18EDC90", VA = "0x18EDC90")]
		public void AddProperty(string tag, PropertyTemplate property)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x18ED9C0", Offset = "0x18ED9C0", VA = "0x18ED9C0")]
		public void SetValue(string key, string value)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x18EEF90", Offset = "0x18EEF90", VA = "0x18EEF90")]
		public string GetValue(string key)
		{
			return null;
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x18EF37C", Offset = "0x18EF37C", VA = "0x18EF37C")]
		public void RemoveProperty(PropertyTemplate property)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x18EF400", Offset = "0x18EF400", VA = "0x18EF400")]
		public void RemoveValue(string key)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x18EE2E8", Offset = "0x18EE2E8", VA = "0x18EE2E8")]
		public void AddPropertiesToXml(XmlDocument doc, XmlElement parent, BaseTemplate template)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x18EE074", Offset = "0x18EE074", VA = "0x18EE074")]
		public void AddAttributesToXml(XmlDocument doc, XmlElement parent, BaseTemplate template)
		{
		}
	}
	[Token(Token = "0x200002F")]
	public enum ManifestPermission
	{
		[Token(Token = "0x40000DE")]
		ACCESS_LOCATION_EXTRA_COMMANDS,
		[Token(Token = "0x40000DF")]
		ACCESS_NETWORK_STATE,
		[Token(Token = "0x40000E0")]
		ACCESS_NOTIFICATION_POLICY,
		[Token(Token = "0x40000E1")]
		ACCESS_WIFI_STATE,
		[Token(Token = "0x40000E2")]
		ACCESS_WIMAX_STATE,
		[Token(Token = "0x40000E3")]
		BLUETOOTH,
		[Token(Token = "0x40000E4")]
		BLUETOOTH_ADMIN,
		[Token(Token = "0x40000E5")]
		BROADCAST_STICKY,
		[Token(Token = "0x40000E6")]
		CHANGE_NETWORK_STATE,
		[Token(Token = "0x40000E7")]
		CHANGE_WIFI_MULTICAST_STATE,
		[Token(Token = "0x40000E8")]
		CHANGE_WIFI_STATE,
		[Token(Token = "0x40000E9")]
		CHANGE_WIMAX_STATE,
		[Token(Token = "0x40000EA")]
		DISABLE_KEYGUARD,
		[Token(Token = "0x40000EB")]
		EXPAND_STATUS_BAR,
		[Token(Token = "0x40000EC")]
		FLASHLIGHT,
		[Token(Token = "0x40000ED")]
		GET_PACKAGE_SIZE,
		[Token(Token = "0x40000EE")]
		INTERNET,
		[Token(Token = "0x40000EF")]
		KILL_BACKGROUND_PROCESSES,
		[Token(Token = "0x40000F0")]
		MODIFY_AUDIO_SETTINGS,
		[Token(Token = "0x40000F1")]
		NFC,
		[Token(Token = "0x40000F2")]
		READ_SYNC_SETTINGS,
		[Token(Token = "0x40000F3")]
		READ_SYNC_STATS,
		[Token(Token = "0x40000F4")]
		RECEIVE_BOOT_COMPLETED,
		[Token(Token = "0x40000F5")]
		REORDER_TASKS,
		[Token(Token = "0x40000F6")]
		REQUEST_INSTALL_PACKAGES,
		[Token(Token = "0x40000F7")]
		SET_TIME_ZONE,
		[Token(Token = "0x40000F8")]
		SET_WALLPAPER,
		[Token(Token = "0x40000F9")]
		SET_WALLPAPER_HINTS,
		[Token(Token = "0x40000FA")]
		SUBSCRIBED_FEEDS_READ,
		[Token(Token = "0x40000FB")]
		TRANSMIT_IR,
		[Token(Token = "0x40000FC")]
		USE_FINGERPRINT,
		[Token(Token = "0x40000FD")]
		VIBRATE,
		[Token(Token = "0x40000FE")]
		WAKE_LOCK,
		[Token(Token = "0x40000FF")]
		WRITE_SYNC_SETTINGS,
		[Token(Token = "0x4000100")]
		SET_ALARM,
		[Token(Token = "0x4000101")]
		INSTALL_SHORTCUT,
		[Token(Token = "0x4000102")]
		UNINSTALL_SHORTCUT,
		[Token(Token = "0x4000103")]
		READ_CALENDAR,
		[Token(Token = "0x4000104")]
		WRITE_CALENDAR,
		[Token(Token = "0x4000105")]
		CAMERA,
		[Token(Token = "0x4000106")]
		READ_CONTACTS,
		[Token(Token = "0x4000107")]
		WRITE_CONTACTS,
		[Token(Token = "0x4000108")]
		GET_ACCOUNTS,
		[Token(Token = "0x4000109")]
		ACCESS_FINE_LOCATION,
		[Token(Token = "0x400010A")]
		ACCESS_COARSE_LOCATION,
		[Token(Token = "0x400010B")]
		RECORD_AUDIO,
		[Token(Token = "0x400010C")]
		READ_PHONE_STATE,
		[Token(Token = "0x400010D")]
		CALL_PHONE,
		[Token(Token = "0x400010E")]
		READ_CALL_LOG,
		[Token(Token = "0x400010F")]
		WRITE_CALL_LOG,
		[Token(Token = "0x4000110")]
		ADD_VOICEMAIL,
		[Token(Token = "0x4000111")]
		USE_SIP,
		[Token(Token = "0x4000112")]
		PROCESS_OUTGOING_CALLS,
		[Token(Token = "0x4000113")]
		BODY_SENSORS,
		[Token(Token = "0x4000114")]
		SEND_SMS,
		[Token(Token = "0x4000115")]
		READ_SMS,
		[Token(Token = "0x4000116")]
		RECEIVE_SMS,
		[Token(Token = "0x4000117")]
		RECEIVE_WAP_PUSH,
		[Token(Token = "0x4000118")]
		RECEIVE_MMS,
		[Token(Token = "0x4000119")]
		READ_EXTERNAL_STORAGE,
		[Token(Token = "0x400011A")]
		WRITE_EXTERNAL_STORAGE,
		[Token(Token = "0x400011B")]
		UNDEFINED
	}
	[Token(Token = "0x2000030")]
	internal static class MenifestPermissionMethods
	{
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x18EF478", Offset = "0x18EF478", VA = "0x18EF478")]
		public static string GetFullName(this ManifestPermission permission)
		{
			return null;
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x18EF564", Offset = "0x18EF564", VA = "0x18EF564")]
		public static bool IsNormalPermission(this ManifestPermission permission)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000031")]
	public class PropertyTemplate : BaseTemplate
	{
		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool IsOpen;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string _tag;

		[Token(Token = "0x1700001E")]
		public string Tag
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x18EF5B4", Offset = "0x18EF5B4", VA = "0x18EF5B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		public string Name
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x18EF5BC", Offset = "0x18EF5BC", VA = "0x18EF5BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x18EF60C", Offset = "0x18EF60C", VA = "0x18EF60C")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public string Value
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x18EF66C", Offset = "0x18EF66C", VA = "0x18EF66C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x18EF6BC", Offset = "0x18EF6BC", VA = "0x18EF6BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public string Label
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x18EF71C", Offset = "0x18EF71C", VA = "0x18EF71C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x18EF76C", Offset = "0x18EF76C", VA = "0x18EF76C")]
			set
			{
			}
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x18EDC0C", Offset = "0x18EDC0C", VA = "0x18EDC0C")]
		public PropertyTemplate(string tag)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x18EF570", Offset = "0x18EF570", VA = "0x18EF570", Slot = "4")]
		public override void ToXmlElement(XmlDocument doc, XmlElement parent)
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class Template : BaseTemplate
	{
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ApplicationTemplate _applicationTemplate;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<PropertyTemplate> _permissions;

		[Token(Token = "0x17000022")]
		public ApplicationTemplate ApplicationTemplate
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x18EFEAC", Offset = "0x18EFEAC", VA = "0x18EFEAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		public List<PropertyTemplate> Permissions
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x18EFEB4", Offset = "0x18EFEB4", VA = "0x18EFEB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x18EF7D4", Offset = "0x18EF7D4", VA = "0x18EF7D4")]
		public Template()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x18EF874", Offset = "0x18EF874", VA = "0x18EF874")]
		public bool HasPermission(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x18EF9A0", Offset = "0x18EF9A0", VA = "0x18EF9A0")]
		public void RemovePermission(string name)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x18EFB54", Offset = "0x18EFB54", VA = "0x18EFB54")]
		public void RemovePermission(PropertyTemplate permission)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x18EFBBC", Offset = "0x18EFBBC", VA = "0x18EFBBC")]
		public void AddPermission(string name)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x18EFC68", Offset = "0x18EFC68", VA = "0x18EFC68")]
		public void AddPermission(PropertyTemplate permission)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x18EFCD0", Offset = "0x18EFCD0", VA = "0x18EFCD0", Slot = "4")]
		public override void ToXmlElement(XmlDocument doc, XmlElement parent)
		{
		}
	}
}
namespace SA.Analytics.Firebase
{
	[Token(Token = "0x2000033")]
	public static class Analytics
	{
		[Token(Token = "0x4000120")]
		private const string SEPARATOR1 = "%";

		[Token(Token = "0x4000121")]
		private const string SEPARATOR2 = "|";

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xC295F4", Offset = "0xC295F4", VA = "0xC295F4")]
		public static void Init()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xC296CC", Offset = "0xC296CC", VA = "0xC296CC")]
		public static void SetEnabled(bool enabled)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xC297B4", Offset = "0xC297B4", VA = "0xC297B4")]
		public static void SetMinimumSessionDuration(long milliseconds)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xC29898", Offset = "0xC29898", VA = "0xC29898")]
		public static void SetSessionTimeoutDuration(long milliseconds)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xC2997C", Offset = "0xC2997C", VA = "0xC2997C")]
		public static void SetUserId(string userId)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xC29A38", Offset = "0xC29A38", VA = "0xC29A38")]
		public static void SetUserProperty(string name, string value)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xC29B34", Offset = "0xC29B34", VA = "0xC29B34")]
		public static void LogEvent(string name, [Optional] Dictionary<string, object> data)
		{
		}
	}
	[Token(Token = "0x2000034")]
	public static class Proxy
	{
		[Token(Token = "0x4000122")]
		private const string CLASS_NAME = "com.stansassets.firebase.analytics.Bridge";

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xC295F8", Offset = "0xC295F8", VA = "0xC295F8")]
		public static void Init()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xC296D4", Offset = "0xC296D4", VA = "0xC296D4")]
		public static void SetEnabled(bool enabled)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xC297B8", Offset = "0xC297B8", VA = "0xC297B8")]
		public static void SetMinimumSessionDuration(long milliseconds)
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xC2989C", Offset = "0xC2989C", VA = "0xC2989C")]
		public static void SetSessionTimeoutDuration(long milliseconds)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xC29980", Offset = "0xC29980", VA = "0xC29980")]
		public static void SetUserId(string userId)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xC29A3C", Offset = "0xC29A3C", VA = "0xC29A3C")]
		public static void SetUserProperty(string name, string value)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xC29CFC", Offset = "0xC29CFC", VA = "0xC29CFC")]
		public static void LogEvent(string name, [Optional] string data)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xC29DF4", Offset = "0xC29DF4", VA = "0xC29DF4")]
		private static void CallStaticFunction(string methodName, params object[] args)
		{
		}
	}
}
namespace SA.Analytics.Google
{
	[Token(Token = "0x2000035")]
	public class CacheQueue : Singleton<CacheQueue>
	{
		[Token(Token = "0x200005E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844434", Offset = "0x844434")]
		private sealed class <Send>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CachedRequest request;

			[Token(Token = "0x4000378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CacheQueue <>4__this;

			[Token(Token = "0x4000379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private WWW <www>5__2;

			[Token(Token = "0x17000044")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600032F")]
				[Address(RVA = "0xC2B58C", Offset = "0xC2B58C", VA = "0xC2B58C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000045")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000331")]
				[Address(RVA = "0xC2B5F4", Offset = "0xC2B5F4", VA = "0xC2B5F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600032C")]
			[Address(RVA = "0xC2AFB0", Offset = "0xC2AFB0", VA = "0xC2AFB0")]
			[DebuggerHidden]
			public <Send>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600032D")]
			[Address(RVA = "0xC2B04C", Offset = "0xC2B04C", VA = "0xC2B04C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600032E")]
			[Address(RVA = "0xC2B050", Offset = "0xC2B050", VA = "0xC2B050", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000330")]
			[Address(RVA = "0xC2B594", Offset = "0xC2B594", VA = "0xC2B594", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool IsWorking;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CachedRequest _CurrentRequest;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<CachedRequest> _CurrentQueue;

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xC2A53C", Offset = "0xC2A53C", VA = "0xC2A53C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xC2A5B8", Offset = "0xC2A5B8", VA = "0xC2A5B8")]
		public void Run()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xC2ABAC", Offset = "0xC2ABAC", VA = "0xC2ABAC")]
		private void Stop()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xC2AC7C", Offset = "0xC2AC7C", VA = "0xC2AC7C")]
		private void Continue()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xC2ABE4", Offset = "0xC2ABE4", VA = "0xC2ABE4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x844A8C", Offset = "0x844A8C")]
		private IEnumerator Send(CachedRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xC2AFDC", Offset = "0xC2AFDC", VA = "0xC2AFDC")]
		public CacheQueue()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class Client
	{
		[Token(Token = "0x4000126")]
		private const string PROTOCOL_VERSION = "v=1";

		[Token(Token = "0x4000127")]
		private const string HTTP_URL = "http://www.google-analytics.com/collect";

		[Token(Token = "0x4000128")]
		private const string HTTPS_URL = "https://ssl.google-analytics.com/collect";

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string TrackingID;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string ClientID;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string AppName;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string AppVersion;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string DefaultHitData;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private StringBuilder builder;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private HitType currentHitType;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string DataSendUrl;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string lastScreenName;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string userId;

		[Token(Token = "0x17000024")]
		public string AnalyticsHost
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0xC30844", Offset = "0xC30844", VA = "0xC30844")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		public string LastScreenName
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0xC3084C", Offset = "0xC3084C", VA = "0xC3084C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		public string UserId
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0xC30854", Offset = "0xC30854", VA = "0xC30854")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xC2B724", Offset = "0xC2B724", VA = "0xC2B724")]
		public Client(string anonymousClientID)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xC2BA28", Offset = "0xC2BA28", VA = "0xC2BA28")]
		public void GenerateHeaders(string trackingId)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xC2BC04", Offset = "0xC2BC04", VA = "0xC2BC04")]
		public void SetAnonymizeIP()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xC2BC60", Offset = "0xC2BC60", VA = "0xC2BC60")]
		public void SetQueueTime(int time)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xC2BCDC", Offset = "0xC2BCDC", VA = "0xC2BCDC")]
		public void StartSession()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xC2BD38", Offset = "0xC2BD38", VA = "0xC2BD38")]
		public void EndSession()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xC2BD94", Offset = "0xC2BD94", VA = "0xC2BD94")]
		public void IPOverride(string ip)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xC2BEF4", Offset = "0xC2BEF4", VA = "0xC2BEF4")]
		public void UserAgentOverride(string userAgent)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xC2BF54", Offset = "0xC2BF54", VA = "0xC2BF54")]
		public void SetDocumentReferrer(string url)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xC2C258", Offset = "0xC2C258", VA = "0xC2C258")]
		public void SetCampaignName(string name)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xC2C354", Offset = "0xC2C354", VA = "0xC2C354")]
		public void SetCampaignSource(string source)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xC2C450", Offset = "0xC2C450", VA = "0xC2C450")]
		public void SetCampaignMedium(string medium)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xC2C54C", Offset = "0xC2C54C", VA = "0xC2C54C")]
		public void AddCampaignKeyword(string keyword)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xC2C648", Offset = "0xC2C648", VA = "0xC2C648")]
		public void SetCampaignContent(string content)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xC2C744", Offset = "0xC2C744", VA = "0xC2C744")]
		public void SetCampaignID(string id)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xC2C840", Offset = "0xC2C840", VA = "0xC2C840")]
		public void SetGoogleAdWordsID(string id)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xC2C8A0", Offset = "0xC2C8A0", VA = "0xC2C8A0")]
		public void SetGoogleDisplayAdsID(string id)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xC2C900", Offset = "0xC2C900", VA = "0xC2C900")]
		public void SetUserId(string id)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xC2C9C0", Offset = "0xC2C9C0", VA = "0xC2C9C0")]
		public void SetScreenResolution(int width, int height)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xC2CA68", Offset = "0xC2CA68", VA = "0xC2CA68")]
		public void SetViewportSize(int width, int height)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xC2CB10", Offset = "0xC2CB10", VA = "0xC2CB10")]
		public void SetDocumentEncoding(string encoding)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xC2CB70", Offset = "0xC2CB70", VA = "0xC2CB70")]
		public void SetScreenColors(string colorsBuffer)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xC2CBD0", Offset = "0xC2CBD0", VA = "0xC2CBD0")]
		public void SetUserLanguage(string lang)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xC2CC30", Offset = "0xC2CC30", VA = "0xC2CC30")]
		public void SetJavaEnablede(bool isEnabled)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xC2CCA8", Offset = "0xC2CCA8", VA = "0xC2CCA8")]
		public void SetFlashVersion(string version)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xC2CD08", Offset = "0xC2CD08", VA = "0xC2CD08")]
		public void SetHitType(HitType hit)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xC2CDBC", Offset = "0xC2CDBC", VA = "0xC2CDBC")]
		public void SetNoInteractionHit()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xC2CE18", Offset = "0xC2CE18", VA = "0xC2CE18")]
		public void SetDocumentlocationURL(string url)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xC2CF14", Offset = "0xC2CF14", VA = "0xC2CF14")]
		public void SetDocumentHostName(string host)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xC2D010", Offset = "0xC2D010", VA = "0xC2D010")]
		public void SetDocumentPath(string path)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xC2D10C", Offset = "0xC2D10C", VA = "0xC2D10C")]
		public void SetDocumentTitle(string title)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xC2D208", Offset = "0xC2D208", VA = "0xC2D208")]
		public void SetScreenName(string name)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xC2D314", Offset = "0xC2D314", VA = "0xC2D314")]
		public void SetLinkID(string id)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xC2D374", Offset = "0xC2D374", VA = "0xC2D374")]
		public void SetApplicationName(string name)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xC2D470", Offset = "0xC2D470", VA = "0xC2D470")]
		public void SetApplicationVersion(string version)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xC2D56C", Offset = "0xC2D56C", VA = "0xC2D56C")]
		public void SetApplicationInstallerID(string identifier)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xC2D668", Offset = "0xC2D668", VA = "0xC2D668")]
		public void SetEventCategory(string ec)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xC2D714", Offset = "0xC2D714", VA = "0xC2D714")]
		public void SetEventAction(string ea)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xC2D7C0", Offset = "0xC2D7C0", VA = "0xC2D7C0")]
		public void SetEventLabel(string el)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xC2D86C", Offset = "0xC2D86C", VA = "0xC2D86C")]
		public void SetEventValue(int val)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xC2D930", Offset = "0xC2D930", VA = "0xC2D930")]
		public void SetTransactionID(string ti)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xC2D9EC", Offset = "0xC2D9EC", VA = "0xC2D9EC")]
		public void SetTransactionAffiliation(string ta)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xC2DA98", Offset = "0xC2DA98", VA = "0xC2DA98")]
		public void SetTransactionRevenue(float tr)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xC2DBAC", Offset = "0xC2DBAC", VA = "0xC2DBAC")]
		public void SetTransactionShipping(float ts)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xC2DC68", Offset = "0xC2DC68", VA = "0xC2DC68")]
		public void SetTransactionTax(float tt)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xC2DD24", Offset = "0xC2DD24", VA = "0xC2DD24")]
		public void SetTransactionCouponCode(string tcc)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xC2DD84", Offset = "0xC2DD84", VA = "0xC2DD84")]
		public void SetItemName(string name)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xC2DE30", Offset = "0xC2DE30", VA = "0xC2DE30")]
		public void SetItemPrice(float ip)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xC2DEEC", Offset = "0xC2DEEC", VA = "0xC2DEEC")]
		public void SetItemQuantity(int iq)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xC2DFB0", Offset = "0xC2DFB0", VA = "0xC2DFB0")]
		public void SetItemCode(string ic)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xC2E05C", Offset = "0xC2E05C", VA = "0xC2E05C")]
		public void SetItemCategory(string iv)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xC2E108", Offset = "0xC2E108", VA = "0xC2E108")]
		public void SetCurrencyCode(string cu)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xC2E1C4", Offset = "0xC2E1C4", VA = "0xC2E1C4")]
		public void SetProductSKU(int productIndex, string sku)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xC2E300", Offset = "0xC2E300", VA = "0xC2E300")]
		public void SetSetProductName(int productIndex, string name)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xC2E43C", Offset = "0xC2E43C", VA = "0xC2E43C")]
		public void SetProductBrand(int productIndex, string brand)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xC2E578", Offset = "0xC2E578", VA = "0xC2E578")]
		public void SetProductCategory(int productIndex, string category)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xC2E6B4", Offset = "0xC2E6B4", VA = "0xC2E6B4")]
		public void SetProductVariant(int productIndex, string variant)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xC2E7F0", Offset = "0xC2E7F0", VA = "0xC2E7F0")]
		public void SetProductPrice(int productIndex, float prise)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xC2E884", Offset = "0xC2E884", VA = "0xC2E884")]
		public void SetProductQuantity(int productIndex, int quantit)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xC2E924", Offset = "0xC2E924", VA = "0xC2E924")]
		public void SetProductCouponCode(int productIndex, string couponCode)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xC2EA60", Offset = "0xC2EA60", VA = "0xC2EA60")]
		public void SetProductPosition(int productIndex, int pos)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xC2EB00", Offset = "0xC2EB00", VA = "0xC2EB00")]
		public void SetProductCustomDimension(int productIndex, int index, string val)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xC2EBA8", Offset = "0xC2EBA8", VA = "0xC2EBA8")]
		public void SetProductCustomMetric(int productIndex, int index, int metric)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xC2EC60", Offset = "0xC2EC60", VA = "0xC2EC60")]
		public void SetProductAction(string pa)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xC2ECC0", Offset = "0xC2ECC0", VA = "0xC2ECC0")]
		public void SetProductActionList(string val)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xC2ED20", Offset = "0xC2ED20", VA = "0xC2ED20")]
		public void SetCheckoutStep(int cos)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xC2ED90", Offset = "0xC2ED90", VA = "0xC2ED90")]
		public void SetCheckoutStepOption(string col)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xC2EDF0", Offset = "0xC2EDF0", VA = "0xC2EDF0")]
		public void SetSocialNetwork(string sn)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xC2EE9C", Offset = "0xC2EE9C", VA = "0xC2EE9C")]
		public void SetSocialAction(string action)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xC2EF48", Offset = "0xC2EF48", VA = "0xC2EF48")]
		public void SetSocialActionTarget(string target)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xC2EFF4", Offset = "0xC2EFF4", VA = "0xC2EFF4")]
		public void SetUserTimingCategory(string category)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xC2F0A0", Offset = "0xC2F0A0", VA = "0xC2F0A0")]
		public void SetUserTimingVariableName(string name)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xC2F14C", Offset = "0xC2F14C", VA = "0xC2F14C")]
		public void SetUserTimingTime(int time)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xC2F210", Offset = "0xC2F210", VA = "0xC2F210")]
		public void SetUserTimingLabel(string label)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xC2F2BC", Offset = "0xC2F2BC", VA = "0xC2F2BC")]
		public void SetPageLoadTime(int time)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xC2F380", Offset = "0xC2F380", VA = "0xC2F380")]
		public void SetDNSTime(int time)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xC2F444", Offset = "0xC2F444", VA = "0xC2F444")]
		public void SetPageDownloadTime(int time)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xC2F508", Offset = "0xC2F508", VA = "0xC2F508")]
		public void SetRedirectResponseTime(int time)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xC2F5CC", Offset = "0xC2F5CC", VA = "0xC2F5CC")]
		public void SetTCPConnectTime(int time)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xC2F690", Offset = "0xC2F690", VA = "0xC2F690")]
		public void SetServerResponseTime(int time)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xC2F754", Offset = "0xC2F754", VA = "0xC2F754")]
		public void SetPromotionID(int index, string id)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xC2F7E8", Offset = "0xC2F7E8", VA = "0xC2F7E8")]
		public void SetPromotionName(int index, string nm)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xC2F87C", Offset = "0xC2F87C", VA = "0xC2F87C")]
		public void SetPromotionCreative(int index, string cr)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xC2F910", Offset = "0xC2F910", VA = "0xC2F910")]
		public void SetPromotionPosition(int index, string ps)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xC2F9A4", Offset = "0xC2F9A4", VA = "0xC2F9A4")]
		public void SetPromotionAction(string promoa)
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xC2FA04", Offset = "0xC2FA04", VA = "0xC2FA04")]
		public void SetExceptionDescription(string description)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xC2FB0C", Offset = "0xC2FB0C", VA = "0xC2FB0C")]
		public void SetIsFatalException(bool isFatal)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xC2FBD4", Offset = "0xC2FBD4", VA = "0xC2FBD4")]
		public void SetNonInteractionFlag()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xC2FC30", Offset = "0xC2FC30", VA = "0xC2FC30")]
		public void SetCustomDimension(int index, string value)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xC2FD60", Offset = "0xC2FD60", VA = "0xC2FD60")]
		public void SetCustomMetric(int index, int value)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xC2FDF4", Offset = "0xC2FDF4", VA = "0xC2FDF4")]
		public void SetExperimentID(string id)
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xC2FEF0", Offset = "0xC2FEF0", VA = "0xC2FEF0")]
		public void SetExperimentVariant(string variant)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xC2FF50", Offset = "0xC2FF50", VA = "0xC2FF50")]
		public void SendPageHit(string host, string page, string title, string description = "", string linkId = "")
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xC301C8", Offset = "0xC301C8", VA = "0xC301C8")]
		public void SendEventHit(string category, string action, string label = "", int val = -1, bool trackLevelName = false)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xC303A4", Offset = "0xC303A4", VA = "0xC303A4")]
		public void SendTransactionHit(string id, string affiliation = "", string currencyCode = "", float revenue = 0f, float shipping = 0f, float tax = 0f)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xC3047C", Offset = "0xC3047C", VA = "0xC3047C")]
		public void SendItemHit(string transactionId, string name, string SKU, float price, int quantity = 1, string category = "", string currencyCode = "")
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xC30554", Offset = "0xC30554", VA = "0xC30554")]
		public void SendSocialHit(string action, string network, string target)
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xC305B4", Offset = "0xC305B4", VA = "0xC305B4")]
		public void SendExceptionHit(string description, bool IsFatal = false)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xC30608", Offset = "0xC30608", VA = "0xC30608")]
		public void SendUserTimingHit(string category, string variable, int time, string label)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xC30680", Offset = "0xC30680", VA = "0xC30680")]
		public void SendScreenHit(string screenName)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xC30054", Offset = "0xC30054", VA = "0xC30054")]
		public void CreateHit(HitType hit)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xC300AC", Offset = "0xC300AC", VA = "0xC300AC")]
		public void Send()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xC307CC", Offset = "0xC307CC", VA = "0xC307CC")]
		public WWW GenerateWWW(byte[] data)
		{
			return null;
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xC2BDF4", Offset = "0xC2BDF4", VA = "0xC2BDF4")]
		public void AppendData(string protocolToken, string val)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xC2C050", Offset = "0xC2C050", VA = "0xC2C050")]
		public void AppendData(string protocolToken, string val, string action, int maxSize, params HitType[] supportedHitTypes)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xC2DB54", Offset = "0xC2DB54", VA = "0xC2DB54")]
		private string FloatToCurrency(float val)
		{
			return null;
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xC3085C", Offset = "0xC3085C", VA = "0xC3085C")]
		private void CheckDataLength(string action, string data, int maxLength)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xC2BBFC", Offset = "0xC2BBFC", VA = "0xC2BBFC")]
		private string EscapeString(string original)
		{
			return null;
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xC2B958", Offset = "0xC2B958", VA = "0xC2B958")]
		private string EscapeString(string original, bool forced)
		{
			return null;
		}
	}
	[Token(Token = "0x2000037")]
	public class Manager : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200005F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844444", Offset = "0x844444")]
		private sealed class <>c
		{
			[Token(Token = "0x400037A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400037B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static UnityAction<Scene, LoadSceneMode> <>9__8_0;

			[Token(Token = "0x6000333")]
			[Address(RVA = "0xC337F8", Offset = "0xC337F8", VA = "0xC337F8")]
			public <>c()
			{
			}

			[Token(Token = "0x6000334")]
			[Address(RVA = "0xC33800", Offset = "0xC33800", VA = "0xC33800")]
			internal void <Awake>b__8_0(Scene arg0, LoadSceneMode arg1)
			{
			}
		}

		[Token(Token = "0x2000060")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844454", Offset = "0x844454")]
		private sealed class <SendAnalytics>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400037C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400037D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400037E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public byte[] data;

			[Token(Token = "0x400037F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string cache;

			[Token(Token = "0x4000380")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private WWW <www>5__2;

			[Token(Token = "0x17000046")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000338")]
				[Address(RVA = "0xC33B00", Offset = "0xC33B00", VA = "0xC33B00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000047")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600033A")]
				[Address(RVA = "0xC33B68", Offset = "0xC33B68", VA = "0xC33B68", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000335")]
			[Address(RVA = "0xC33390", Offset = "0xC33390", VA = "0xC33390")]
			[DebuggerHidden]
			public <SendAnalytics>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x6000336")]
			[Address(RVA = "0xC3385C", Offset = "0xC3385C", VA = "0xC3385C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000337")]
			[Address(RVA = "0xC33860", Offset = "0xC33860", VA = "0xC33860", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000339")]
			[Address(RVA = "0xC33B08", Offset = "0xC33B08", VA = "0xC33B08", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000133")]
		public const string GOOGLE_ANALYTICS_CLIENTID_PREF_KEY = "google_analytics_clientid_pref_key";

		[Token(Token = "0x4000134")]
		public const string GOOGLE_ANALYTICS_SYSTEM_INFO_SUBMITED = "system_info_submited";

		[Token(Token = "0x4000135")]
		public const string SYSTEM_INFO = "SystemInfo";

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Manager Instance;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string _ClientId;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Client cleint;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static string CurrentLevelName;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static bool IsSessionStarted;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844514", Offset = "0x844514")]
		private string <CampaignSource>k__BackingField;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844524", Offset = "0x844524")]
		private string <CampaignName>k__BackingField;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844534", Offset = "0x844534")]
		private string <CampaignContent>k__BackingField;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static System.Random random;

		[Token(Token = "0x17000027")]
		public string CampaignSource
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0xC331D0", Offset = "0xC331D0", VA = "0xC331D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844AF0", Offset = "0x844AF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600028B")]
			[Address(RVA = "0xC331D8", Offset = "0xC331D8", VA = "0xC331D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844B00", Offset = "0x844B00")]
			private set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public string CampaignName
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0xC331E0", Offset = "0xC331E0", VA = "0xC331E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844B10", Offset = "0x844B10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600028D")]
			[Address(RVA = "0xC331E8", Offset = "0xC331E8", VA = "0xC331E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844B20", Offset = "0x844B20")]
			private set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public string CampaignContent
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0xC331F0", Offset = "0xC331F0", VA = "0xC331F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844B30", Offset = "0x844B30")]
			get
			{
				return null;
			}
			[Token(Token = "0x600028F")]
			[Address(RVA = "0xC331F8", Offset = "0xC331F8", VA = "0xC331F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844B40", Offset = "0x844B40")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public static Client Client
		{
			[Token(Token = "0x6000290")]
			[Address(RVA = "0xC31A40", Offset = "0xC31A40", VA = "0xC31A40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public static string ClientId
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0xC33200", Offset = "0xC33200", VA = "0xC33200")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public static string LoadedLevelName
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0xC3032C", Offset = "0xC3032C", VA = "0xC3032C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xC31510", Offset = "0xC31510", VA = "0xC31510")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xC324D8", Offset = "0xC324D8", VA = "0xC324D8")]
		public static void SetTrackingId(string TrackingId)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xC32554", Offset = "0xC32554", VA = "0xC32554")]
		public static void StartTracking()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xC326B4", Offset = "0xC326B4", VA = "0xC326B4")]
		private void OnApplicationPause(bool paused)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xC327AC", Offset = "0xC327AC", VA = "0xC327AC")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xC3286C", Offset = "0xC3286C", VA = "0xC3286C")]
		private void HandleLog(string logString, string stackTrace, LogType type)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xC32990", Offset = "0xC32990", VA = "0xC32990")]
		private void OnReferalIntentReciver(string referrerString)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xC31D28", Offset = "0xC31D28", VA = "0xC31D28")]
		public static void SubmitSystemInfo()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xC33268", Offset = "0xC33268", VA = "0xC33268")]
		public static void RestorePrefKeys()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xC306B8", Offset = "0xC306B8", VA = "0xC306B8")]
		public static void Send(string request)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xC2B4F4", Offset = "0xC2B4F4", VA = "0xC2B4F4")]
		public static WWW SendSkipCache(string request)
		{
			return null;
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xC332F8", Offset = "0xC332F8", VA = "0xC332F8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x844B50", Offset = "0x844B50")]
		private IEnumerator SendAnalytics(byte[] data, string cache)
		{
			return null;
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xC31AE8", Offset = "0xC31AE8", VA = "0xC31AE8")]
		private static void SendFirstScreenHit()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xC333BC", Offset = "0xC333BC", VA = "0xC333BC")]
		private static void TrackNewLevel()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xC31948", Offset = "0xC31948", VA = "0xC31948")]
		private static void GenerateClientId()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xC33524", Offset = "0xC33524", VA = "0xC33524")]
		private static string RandomString(int size)
		{
			return null;
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xC33690", Offset = "0xC33690", VA = "0xC33690")]
		public Manager()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class RequestCache
	{
		[Token(Token = "0x400013F")]
		private const string DATA_SPLITTER = "|";

		[Token(Token = "0x4000140")]
		private const string RQUEST_DATA_SPLITTER = "%rps%";

		[Token(Token = "0x4000141")]
		private const string GA_DATA_CACHE_KEY = "GoogleAnalyticsRequestCache";

		[Token(Token = "0x1700002D")]
		public static string SavedData
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0xC33B70", Offset = "0xC33B70", VA = "0xC33B70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0xC33BEC", Offset = "0xC33BEC", VA = "0xC33BEC")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public static List<CachedRequest> CurrenCachedRequests
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0xC2A69C", Offset = "0xC2A69C", VA = "0xC2A69C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xC33974", Offset = "0xC33974", VA = "0xC33974")]
		public static void SaveRequest(string cache)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xC33A8C", Offset = "0xC33A8C", VA = "0xC33A8C")]
		public static void SendCachedRequests()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xC2AD78", Offset = "0xC2AD78", VA = "0xC2AD78")]
		public static void Clear()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xC2ADC4", Offset = "0xC2ADC4", VA = "0xC2ADC4")]
		public static void CacheRequests(List<CachedRequest> requests)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xC33C40", Offset = "0xC33C40", VA = "0xC33C40")]
		public RequestCache()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public enum HitType
	{
		[Token(Token = "0x4000143")]
		PAGEVIEW,
		[Token(Token = "0x4000144")]
		APPVIEW,
		[Token(Token = "0x4000145")]
		EVENT,
		[Token(Token = "0x4000146")]
		TRANSACTION,
		[Token(Token = "0x4000147")]
		ITEM,
		[Token(Token = "0x4000148")]
		SOCIAL,
		[Token(Token = "0x4000149")]
		EXCEPTION,
		[Token(Token = "0x400014A")]
		TIMING,
		[Token(Token = "0x400014B")]
		SCREENVIEW
	}
	[Token(Token = "0x200003A")]
	public class AndroidTools
	{
		[Token(Token = "0x2000061")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844464", Offset = "0x844464")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string methodName;

			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public object[] args;

			[Token(Token = "0x600033B")]
			[Address(RVA = "0xC2A464", Offset = "0xC2A464", VA = "0xC2A464")]
			public <>c__DisplayClass3_0()
			{
			}
		}

		[Token(Token = "0x2000062")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x844474", Offset = "0x844474")]
		private sealed class <>c__DisplayClass3_1
		{
			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AndroidJavaObject bridge;

			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass3_0 CS$<>8__locals1;

			[Token(Token = "0x600033C")]
			[Address(RVA = "0xC2A46C", Offset = "0xC2A46C", VA = "0xC2A46C")]
			public <>c__DisplayClass3_1()
			{
			}

			[Token(Token = "0x600033D")]
			[Address(RVA = "0xC2A510", Offset = "0xC2A510", VA = "0xC2A510")]
			internal void <CallStatic>b__0()
			{
			}
		}

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string ReferalIntentReciever;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<string, AndroidJavaObject> pool;

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xC2A358", Offset = "0xC2A358", VA = "0xC2A358")]
		public static void RequestReffer()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xC29E74", Offset = "0xC29E74", VA = "0xC29E74")]
		public static void CallStatic(string className, string methodName, params object[] args)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xC2A474", Offset = "0xC2A474", VA = "0xC2A474")]
		public AndroidTools()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class CachedRequest
	{
		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private long _TimeCreated;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _RequestBody;

		[Token(Token = "0x1700002F")]
		public long TimeCreated
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0xC2B64C", Offset = "0xC2B64C", VA = "0xC2B64C")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0xC2B654", Offset = "0xC2B654", VA = "0xC2B654")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public string RequestBody
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0xC2B65C", Offset = "0xC2B65C", VA = "0xC2B65C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0xC2B664", Offset = "0xC2B664", VA = "0xC2B664")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public string Delay
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0xC2B3FC", Offset = "0xC2B3FC", VA = "0xC2B3FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public List<string> DataForJSON
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0xC2B66C", Offset = "0xC2B66C", VA = "0xC2B66C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xC2B5FC", Offset = "0xC2B5FC", VA = "0xC2B5FC")]
		public CachedRequest()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xC2B604", Offset = "0xC2B604", VA = "0xC2B604")]
		public CachedRequest(string body, long ticks)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003C")]
	public class PlatfromBound
	{
		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RuntimePlatform platfrom;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int profileIndex;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int profileIndexTestMode;

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xC30E5C", Offset = "0xC30E5C", VA = "0xC30E5C")]
		public PlatfromBound()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003D")]
	public class Profile
	{
		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string TrackingID;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool IsOpen;

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xC312D4", Offset = "0xC312D4", VA = "0xC312D4")]
		public Profile()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class GA_Settings : ScriptableObject
	{
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string VERSION_NUMBER;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<Profile> accounts;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public List<PlatfromBound> platfromBounds;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool showAdditionalParams;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool showAdvancedParams;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool showCParams;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		public bool showAccounts;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool showPlatfroms;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool showTestingMode;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string AppName;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string AppVersion;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool UseHTTPS;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool StringEscaping;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		public bool EditorAnalytics;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x43")]
		public bool IsDisabled;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool IsTestingModeEnabled;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int TestingModeAccIndex;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool IsRequetsCachingEnabled;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool IsQueueTimeEnabled;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool AutoLevelTracking;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string LevelPrefix;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string LevelPostfix;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool AutoAppQuitTracking;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool AutoCampaignTracking;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		public bool AutoExceptionTracking;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		public bool AutoAppResumeTracking;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool SubmitSystemInfoOnFirstLaunch;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		public bool UsePlayerSettingsForAppInfo;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		public bool EnableFirebase;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string FirebaseAppId;

		[Token(Token = "0x4000174")]
		private const string AnalyticsSettingsAssetName = "GA_Settings";

		[Token(Token = "0x4000175")]
		private const string AnalyticsSettingsAssetExtension = ".asset";

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static GA_Settings instance;

		[Token(Token = "0x17000033")]
		public static GA_Settings Instance
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0xC2B23C", Offset = "0xC2B23C", VA = "0xC2B23C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xC30B74", Offset = "0xC30B74", VA = "0xC30B74")]
		public void UpdateVersionAndName()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xC30B78", Offset = "0xC30B78", VA = "0xC30B78")]
		public void AddProfile(Profile p)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xC30BE0", Offset = "0xC30BE0", VA = "0xC30BE0")]
		public void RemoveProfile(Profile p)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xC30C48", Offset = "0xC30C48", VA = "0xC30C48")]
		public void SetProfileIndexForPlatfrom(RuntimePlatform platfrom, int index, bool IsTesting)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xC30E64", Offset = "0xC30E64", VA = "0xC30E64")]
		public int GetProfileIndexForPlatfrom(RuntimePlatform platfrom, bool IsTestMode)
		{
			return default(int);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xC31034", Offset = "0xC31034", VA = "0xC31034")]
		public string[] GetProfileNames()
		{
			return null;
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xC3118C", Offset = "0xC3118C", VA = "0xC3118C")]
		public int GetProfileIndex(Profile p)
		{
			return default(int);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xC2B9F8", Offset = "0xC2B9F8", VA = "0xC2B9F8")]
		public Profile GetCurentProfile()
		{
			return null;
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xC3121C", Offset = "0xC3121C", VA = "0xC3121C")]
		public Profile GetPrfileForPlatfrom(RuntimePlatform platfrom, bool IsTestMode)
		{
			return null;
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xC3134C", Offset = "0xC3134C", VA = "0xC3134C")]
		public GA_Settings()
		{
		}
	}
}
namespace PlayFab
{
	[Token(Token = "0x200003F")]
	public enum PlayFabErrorCode
	{
		[Token(Token = "0x4000178")]
		Unknown = 1,
		[Token(Token = "0x4000179")]
		Success = 0,
		[Token(Token = "0x400017A")]
		UnkownError = 500,
		[Token(Token = "0x400017B")]
		InvalidParams = 1000,
		[Token(Token = "0x400017C")]
		AccountNotFound = 1001,
		[Token(Token = "0x400017D")]
		AccountBanned = 1002,
		[Token(Token = "0x400017E")]
		InvalidUsernameOrPassword = 1003,
		[Token(Token = "0x400017F")]
		InvalidTitleId = 1004,
		[Token(Token = "0x4000180")]
		InvalidEmailAddress = 1005,
		[Token(Token = "0x4000181")]
		EmailAddressNotAvailable = 1006,
		[Token(Token = "0x4000182")]
		InvalidUsername = 1007,
		[Token(Token = "0x4000183")]
		InvalidPassword = 1008,
		[Token(Token = "0x4000184")]
		UsernameNotAvailable = 1009,
		[Token(Token = "0x4000185")]
		InvalidSteamTicket = 1010,
		[Token(Token = "0x4000186")]
		AccountAlreadyLinked = 1011,
		[Token(Token = "0x4000187")]
		LinkedAccountAlreadyClaimed = 1012,
		[Token(Token = "0x4000188")]
		InvalidFacebookToken = 1013,
		[Token(Token = "0x4000189")]
		AccountNotLinked = 1014,
		[Token(Token = "0x400018A")]
		FailedByPaymentProvider = 1015,
		[Token(Token = "0x400018B")]
		CouponCodeNotFound = 1016,
		[Token(Token = "0x400018C")]
		InvalidContainerItem = 1017,
		[Token(Token = "0x400018D")]
		ContainerNotOwned = 1018,
		[Token(Token = "0x400018E")]
		KeyNotOwned = 1019,
		[Token(Token = "0x400018F")]
		InvalidItemIdInTable = 1020,
		[Token(Token = "0x4000190")]
		InvalidReceipt = 1021,
		[Token(Token = "0x4000191")]
		ReceiptAlreadyUsed = 1022,
		[Token(Token = "0x4000192")]
		ReceiptCancelled = 1023,
		[Token(Token = "0x4000193")]
		GameNotFound = 1024,
		[Token(Token = "0x4000194")]
		GameModeNotFound = 1025,
		[Token(Token = "0x4000195")]
		InvalidGoogleToken = 1026,
		[Token(Token = "0x4000196")]
		UserIsNotPartOfDeveloper = 1027,
		[Token(Token = "0x4000197")]
		InvalidTitleForDeveloper = 1028,
		[Token(Token = "0x4000198")]
		TitleNameConflicts = 1029,
		[Token(Token = "0x4000199")]
		UserisNotValid = 1030,
		[Token(Token = "0x400019A")]
		ValueAlreadyExists = 1031,
		[Token(Token = "0x400019B")]
		BuildNotFound = 1032,
		[Token(Token = "0x400019C")]
		PlayerNotInGame = 1033,
		[Token(Token = "0x400019D")]
		InvalidTicket = 1034,
		[Token(Token = "0x400019E")]
		InvalidDeveloper = 1035,
		[Token(Token = "0x400019F")]
		InvalidOrderInfo = 1036,
		[Token(Token = "0x40001A0")]
		RegistrationIncomplete = 1037,
		[Token(Token = "0x40001A1")]
		InvalidPlatform = 1038,
		[Token(Token = "0x40001A2")]
		UnknownError = 1039,
		[Token(Token = "0x40001A3")]
		SteamApplicationNotOwned = 1040,
		[Token(Token = "0x40001A4")]
		WrongSteamAccount = 1041,
		[Token(Token = "0x40001A5")]
		TitleNotActivated = 1042,
		[Token(Token = "0x40001A6")]
		RegistrationSessionNotFound = 1043,
		[Token(Token = "0x40001A7")]
		NoSuchMod = 1044,
		[Token(Token = "0x40001A8")]
		FileNotFound = 1045,
		[Token(Token = "0x40001A9")]
		DuplicateEmail = 1046,
		[Token(Token = "0x40001AA")]
		ItemNotFound = 1047,
		[Token(Token = "0x40001AB")]
		ItemNotOwned = 1048,
		[Token(Token = "0x40001AC")]
		ItemNotRecycleable = 1049,
		[Token(Token = "0x40001AD")]
		ItemNotAffordable = 1050,
		[Token(Token = "0x40001AE")]
		InvalidVirtualCurrency = 1051,
		[Token(Token = "0x40001AF")]
		WrongVirtualCurrency = 1052,
		[Token(Token = "0x40001B0")]
		WrongPrice = 1053,
		[Token(Token = "0x40001B1")]
		NonPositiveValue = 1054,
		[Token(Token = "0x40001B2")]
		InvalidRegion = 1055,
		[Token(Token = "0x40001B3")]
		RegionAtCapacity = 1056,
		[Token(Token = "0x40001B4")]
		ServerFailedToStart = 1057,
		[Token(Token = "0x40001B5")]
		NameNotAvailable = 1058,
		[Token(Token = "0x40001B6")]
		InsufficientFunds = 1059,
		[Token(Token = "0x40001B7")]
		InvalidDeviceID = 1060,
		[Token(Token = "0x40001B8")]
		InvalidPushNotificationToken = 1061,
		[Token(Token = "0x40001B9")]
		NoRemainingUses = 1062,
		[Token(Token = "0x40001BA")]
		InvalidPaymentProvider = 1063,
		[Token(Token = "0x40001BB")]
		PurchaseInitializationFailure = 1064,
		[Token(Token = "0x40001BC")]
		DuplicateUsername = 1065,
		[Token(Token = "0x40001BD")]
		InvalidBuyerInfo = 1066,
		[Token(Token = "0x40001BE")]
		NoGameModeParamsSet = 1067,
		[Token(Token = "0x40001BF")]
		BodyTooLarge = 1068,
		[Token(Token = "0x40001C0")]
		ReservedWordInBody = 1069,
		[Token(Token = "0x40001C1")]
		InvalidTypeInBody = 1070,
		[Token(Token = "0x40001C2")]
		InvalidRequest = 1071,
		[Token(Token = "0x40001C3")]
		ReservedEventName = 1072,
		[Token(Token = "0x40001C4")]
		InvalidUserStatistics = 1073,
		[Token(Token = "0x40001C5")]
		NotAuthenticated = 1074,
		[Token(Token = "0x40001C6")]
		StreamAlreadyExists = 1075,
		[Token(Token = "0x40001C7")]
		ErrorCreatingStream = 1076,
		[Token(Token = "0x40001C8")]
		StreamNotFound = 1077,
		[Token(Token = "0x40001C9")]
		InvalidAccount = 1078,
		[Token(Token = "0x40001CA")]
		PurchaseDoesNotExist = 1080,
		[Token(Token = "0x40001CB")]
		InvalidPurchaseTransactionStatus = 1081,
		[Token(Token = "0x40001CC")]
		APINotEnabledForGameClientAccess = 1082,
		[Token(Token = "0x40001CD")]
		NoPushNotificationARNForTitle = 1083,
		[Token(Token = "0x40001CE")]
		BuildAlreadyExists = 1084,
		[Token(Token = "0x40001CF")]
		BuildPackageDoesNotExist = 1085,
		[Token(Token = "0x40001D0")]
		CustomAnalyticsEventsNotEnabledForTitle = 1087,
		[Token(Token = "0x40001D1")]
		InvalidSharedGroupId = 1088,
		[Token(Token = "0x40001D2")]
		NotAuthorized = 1089,
		[Token(Token = "0x40001D3")]
		MissingTitleGoogleProperties = 1090,
		[Token(Token = "0x40001D4")]
		InvalidItemProperties = 1091,
		[Token(Token = "0x40001D5")]
		InvalidPSNAuthCode = 1092,
		[Token(Token = "0x40001D6")]
		InvalidItemId = 1093,
		[Token(Token = "0x40001D7")]
		PushNotEnabledForAccount = 1094,
		[Token(Token = "0x40001D8")]
		PushServiceError = 1095,
		[Token(Token = "0x40001D9")]
		ReceiptDoesNotContainInAppItems = 1096,
		[Token(Token = "0x40001DA")]
		ReceiptContainsMultipleInAppItems = 1097,
		[Token(Token = "0x40001DB")]
		InvalidBundleID = 1098,
		[Token(Token = "0x40001DC")]
		JavascriptException = 1099,
		[Token(Token = "0x40001DD")]
		InvalidSessionTicket = 1100,
		[Token(Token = "0x40001DE")]
		UnableToConnectToDatabase = 1101,
		[Token(Token = "0x40001DF")]
		InternalServerError = 1110,
		[Token(Token = "0x40001E0")]
		InvalidReportDate = 1111,
		[Token(Token = "0x40001E1")]
		ReportNotAvailable = 1112,
		[Token(Token = "0x40001E2")]
		DatabaseThroughputExceeded = 1113,
		[Token(Token = "0x40001E3")]
		InvalidGameTicket = 1115,
		[Token(Token = "0x40001E4")]
		ExpiredGameTicket = 1116,
		[Token(Token = "0x40001E5")]
		GameTicketDoesNotMatchLobby = 1117,
		[Token(Token = "0x40001E6")]
		LinkedDeviceAlreadyClaimed = 1118,
		[Token(Token = "0x40001E7")]
		DeviceAlreadyLinked = 1119,
		[Token(Token = "0x40001E8")]
		DeviceNotLinked = 1120,
		[Token(Token = "0x40001E9")]
		PartialFailure = 1121,
		[Token(Token = "0x40001EA")]
		PublisherNotSet = 1122,
		[Token(Token = "0x40001EB")]
		ServiceUnavailable = 1123,
		[Token(Token = "0x40001EC")]
		VersionNotFound = 1124,
		[Token(Token = "0x40001ED")]
		RevisionNotFound = 1125,
		[Token(Token = "0x40001EE")]
		InvalidPublisherId = 1126,
		[Token(Token = "0x40001EF")]
		DownstreamServiceUnavailable = 1127,
		[Token(Token = "0x40001F0")]
		APINotIncludedInTitleUsageTier = 1128,
		[Token(Token = "0x40001F1")]
		DAULimitExceeded = 1129,
		[Token(Token = "0x40001F2")]
		APIRequestLimitExceeded = 1130,
		[Token(Token = "0x40001F3")]
		InvalidAPIEndpoint = 1131,
		[Token(Token = "0x40001F4")]
		BuildNotAvailable = 1132,
		[Token(Token = "0x40001F5")]
		ConcurrentEditError = 1133,
		[Token(Token = "0x40001F6")]
		ContentNotFound = 1134,
		[Token(Token = "0x40001F7")]
		CharacterNotFound = 1135,
		[Token(Token = "0x40001F8")]
		CloudScriptNotFound = 1136,
		[Token(Token = "0x40001F9")]
		ContentQuotaExceeded = 1137,
		[Token(Token = "0x40001FA")]
		InvalidCharacterStatistics = 1138,
		[Token(Token = "0x40001FB")]
		PhotonNotEnabledForTitle = 1139,
		[Token(Token = "0x40001FC")]
		PhotonApplicationNotFound = 1140,
		[Token(Token = "0x40001FD")]
		PhotonApplicationNotAssociatedWithTitle = 1141,
		[Token(Token = "0x40001FE")]
		InvalidEmailOrPassword = 1142,
		[Token(Token = "0x40001FF")]
		FacebookAPIError = 1143,
		[Token(Token = "0x4000200")]
		InvalidContentType = 1144,
		[Token(Token = "0x4000201")]
		KeyLengthExceeded = 1145,
		[Token(Token = "0x4000202")]
		DataLengthExceeded = 1146,
		[Token(Token = "0x4000203")]
		TooManyKeys = 1147,
		[Token(Token = "0x4000204")]
		FreeTierCannotHaveVirtualCurrency = 1148,
		[Token(Token = "0x4000205")]
		MissingAmazonSharedKey = 1149,
		[Token(Token = "0x4000206")]
		AmazonValidationError = 1150,
		[Token(Token = "0x4000207")]
		InvalidPSNIssuerId = 1151,
		[Token(Token = "0x4000208")]
		PSNInaccessible = 1152,
		[Token(Token = "0x4000209")]
		ExpiredAuthToken = 1153,
		[Token(Token = "0x400020A")]
		FailedToGetEntitlements = 1154,
		[Token(Token = "0x400020B")]
		FailedToConsumeEntitlement = 1155,
		[Token(Token = "0x400020C")]
		TradeAcceptingUserNotAllowed = 1156,
		[Token(Token = "0x400020D")]
		TradeInventoryItemIsAssignedToCharacter = 1157,
		[Token(Token = "0x400020E")]
		TradeInventoryItemIsBundle = 1158,
		[Token(Token = "0x400020F")]
		TradeStatusNotValidForCancelling = 1159,
		[Token(Token = "0x4000210")]
		TradeStatusNotValidForAccepting = 1160,
		[Token(Token = "0x4000211")]
		TradeDoesNotExist = 1161,
		[Token(Token = "0x4000212")]
		TradeCancelled = 1162,
		[Token(Token = "0x4000213")]
		TradeAlreadyFilled = 1163,
		[Token(Token = "0x4000214")]
		TradeWaitForStatusTimeout = 1164,
		[Token(Token = "0x4000215")]
		TradeInventoryItemExpired = 1165,
		[Token(Token = "0x4000216")]
		TradeMissingOfferedAndAcceptedItems = 1166,
		[Token(Token = "0x4000217")]
		TradeAcceptedItemIsBundle = 1167,
		[Token(Token = "0x4000218")]
		TradeAcceptedItemIsStackable = 1168,
		[Token(Token = "0x4000219")]
		TradeInventoryItemInvalidStatus = 1169,
		[Token(Token = "0x400021A")]
		TradeAcceptedCatalogItemInvalid = 1170,
		[Token(Token = "0x400021B")]
		TradeAllowedUsersInvalid = 1171,
		[Token(Token = "0x400021C")]
		TradeInventoryItemDoesNotExist = 1172,
		[Token(Token = "0x400021D")]
		TradeInventoryItemIsConsumed = 1173,
		[Token(Token = "0x400021E")]
		TradeInventoryItemIsStackable = 1174,
		[Token(Token = "0x400021F")]
		TradeAcceptedItemsMismatch = 1175,
		[Token(Token = "0x4000220")]
		InvalidKongregateToken = 1176,
		[Token(Token = "0x4000221")]
		FeatureNotConfiguredForTitle = 1177,
		[Token(Token = "0x4000222")]
		NoMatchingCatalogItemForReceipt = 1178,
		[Token(Token = "0x4000223")]
		InvalidCurrencyCode = 1179,
		[Token(Token = "0x4000224")]
		NoRealMoneyPriceForCatalogItem = 1180,
		[Token(Token = "0x4000225")]
		TradeInventoryItemIsNotTradable = 1181,
		[Token(Token = "0x4000226")]
		TradeAcceptedCatalogItemIsNotTradable = 1182,
		[Token(Token = "0x4000227")]
		UsersAlreadyFriends = 1183,
		[Token(Token = "0x4000228")]
		LinkedIdentifierAlreadyClaimed = 1184,
		[Token(Token = "0x4000229")]
		CustomIdNotLinked = 1185,
		[Token(Token = "0x400022A")]
		TotalDataSizeExceeded = 1186,
		[Token(Token = "0x400022B")]
		DeleteKeyConflict = 1187,
		[Token(Token = "0x400022C")]
		InvalidXboxLiveToken = 1188,
		[Token(Token = "0x400022D")]
		ExpiredXboxLiveToken = 1189,
		[Token(Token = "0x400022E")]
		ResettableStatisticVersionRequired = 1190,
		[Token(Token = "0x400022F")]
		NotAuthorizedByTitle = 1191,
		[Token(Token = "0x4000230")]
		NoPartnerEnabled = 1192,
		[Token(Token = "0x4000231")]
		InvalidPartnerResponse = 1193,
		[Token(Token = "0x4000232")]
		APINotEnabledForGameServerAccess = 1194,
		[Token(Token = "0x4000233")]
		StatisticNotFound = 1195,
		[Token(Token = "0x4000234")]
		StatisticNameConflict = 1196,
		[Token(Token = "0x4000235")]
		StatisticVersionClosedForWrites = 1197,
		[Token(Token = "0x4000236")]
		StatisticVersionInvalid = 1198,
		[Token(Token = "0x4000237")]
		APIClientRequestRateLimitExceeded = 1199,
		[Token(Token = "0x4000238")]
		InvalidJSONContent = 1200,
		[Token(Token = "0x4000239")]
		InvalidDropTable = 1201,
		[Token(Token = "0x400023A")]
		StatisticVersionAlreadyIncrementedForScheduledInterval = 1202,
		[Token(Token = "0x400023B")]
		StatisticCountLimitExceeded = 1203,
		[Token(Token = "0x400023C")]
		StatisticVersionIncrementRateExceeded = 1204,
		[Token(Token = "0x400023D")]
		ContainerKeyInvalid = 1205,
		[Token(Token = "0x400023E")]
		CloudScriptExecutionTimeLimitExceeded = 1206,
		[Token(Token = "0x400023F")]
		NoWritePermissionsForEvent = 1207,
		[Token(Token = "0x4000240")]
		CloudScriptFunctionArgumentSizeExceeded = 1208,
		[Token(Token = "0x4000241")]
		CloudScriptAPIRequestCountExceeded = 1209,
		[Token(Token = "0x4000242")]
		CloudScriptAPIRequestError = 1210,
		[Token(Token = "0x4000243")]
		CloudScriptHTTPRequestError = 1211,
		[Token(Token = "0x4000244")]
		InsufficientGuildRole = 1212,
		[Token(Token = "0x4000245")]
		GuildNotFound = 1213,
		[Token(Token = "0x4000246")]
		OverLimit = 1214,
		[Token(Token = "0x4000247")]
		EventNotFound = 1215,
		[Token(Token = "0x4000248")]
		InvalidEventField = 1216,
		[Token(Token = "0x4000249")]
		InvalidEventName = 1217,
		[Token(Token = "0x400024A")]
		CatalogNotConfigured = 1218,
		[Token(Token = "0x400024B")]
		OperationNotSupportedForPlatform = 1219,
		[Token(Token = "0x400024C")]
		SegmentNotFound = 1220,
		[Token(Token = "0x400024D")]
		StoreNotFound = 1221,
		[Token(Token = "0x400024E")]
		InvalidStatisticName = 1222,
		[Token(Token = "0x400024F")]
		TitleNotQualifiedForLimit = 1223,
		[Token(Token = "0x4000250")]
		InvalidServiceLimitLevel = 1224,
		[Token(Token = "0x4000251")]
		ServiceLimitLevelInTransition = 1225,
		[Token(Token = "0x4000252")]
		CouponAlreadyRedeemed = 1226,
		[Token(Token = "0x4000253")]
		GameServerBuildSizeLimitExceeded = 1227,
		[Token(Token = "0x4000254")]
		GameServerBuildCountLimitExceeded = 1228,
		[Token(Token = "0x4000255")]
		VirtualCurrencyCountLimitExceeded = 1229,
		[Token(Token = "0x4000256")]
		VirtualCurrencyCodeExists = 1230,
		[Token(Token = "0x4000257")]
		TitleNewsItemCountLimitExceeded = 1231,
		[Token(Token = "0x4000258")]
		InvalidTwitchToken = 1232,
		[Token(Token = "0x4000259")]
		TwitchResponseError = 1233,
		[Token(Token = "0x400025A")]
		ProfaneDisplayName = 1234,
		[Token(Token = "0x400025B")]
		UserAlreadyAdded = 1235,
		[Token(Token = "0x400025C")]
		InvalidVirtualCurrencyCode = 1236,
		[Token(Token = "0x400025D")]
		VirtualCurrencyCannotBeDeleted = 1237,
		[Token(Token = "0x400025E")]
		IdentifierAlreadyClaimed = 1238,
		[Token(Token = "0x400025F")]
		IdentifierNotLinked = 1239,
		[Token(Token = "0x4000260")]
		InvalidContinuationToken = 1240,
		[Token(Token = "0x4000261")]
		ExpiredContinuationToken = 1241,
		[Token(Token = "0x4000262")]
		InvalidSegment = 1242,
		[Token(Token = "0x4000263")]
		InvalidSessionId = 1243,
		[Token(Token = "0x4000264")]
		SessionLogNotFound = 1244,
		[Token(Token = "0x4000265")]
		InvalidSearchTerm = 1245,
		[Token(Token = "0x4000266")]
		TwoFactorAuthenticationTokenRequired = 1246,
		[Token(Token = "0x4000267")]
		GameServerHostCountLimitExceeded = 1247,
		[Token(Token = "0x4000268")]
		PlayerTagCountLimitExceeded = 1248,
		[Token(Token = "0x4000269")]
		RequestAlreadyRunning = 1249,
		[Token(Token = "0x400026A")]
		ActionGroupNotFound = 1250,
		[Token(Token = "0x400026B")]
		MaximumSegmentBulkActionJobsRunning = 1251,
		[Token(Token = "0x400026C")]
		NoActionsOnPlayersInSegmentJob = 1252,
		[Token(Token = "0x400026D")]
		DuplicateStatisticName = 1253,
		[Token(Token = "0x400026E")]
		ScheduledTaskNameConflict = 1254,
		[Token(Token = "0x400026F")]
		ScheduledTaskCreateConflict = 1255,
		[Token(Token = "0x4000270")]
		InvalidScheduledTaskName = 1256,
		[Token(Token = "0x4000271")]
		InvalidTaskSchedule = 1257,
		[Token(Token = "0x4000272")]
		SteamNotEnabledForTitle = 1258,
		[Token(Token = "0x4000273")]
		LimitNotAnUpgradeOption = 1259,
		[Token(Token = "0x4000274")]
		NoSecretKeyEnabledForCloudScript = 1260,
		[Token(Token = "0x4000275")]
		TaskNotFound = 1261,
		[Token(Token = "0x4000276")]
		TaskInstanceNotFound = 1262,
		[Token(Token = "0x4000277")]
		InvalidIdentityProviderId = 1263,
		[Token(Token = "0x4000278")]
		MisconfiguredIdentityProvider = 1264,
		[Token(Token = "0x4000279")]
		InvalidScheduledTaskType = 1265,
		[Token(Token = "0x400027A")]
		BillingInformationRequired = 1266,
		[Token(Token = "0x400027B")]
		LimitedEditionItemUnavailable = 1267,
		[Token(Token = "0x400027C")]
		InvalidAdPlacementAndReward = 1268,
		[Token(Token = "0x400027D")]
		AllAdPlacementViewsAlreadyConsumed = 1269,
		[Token(Token = "0x400027E")]
		GoogleOAuthNotConfiguredForTitle = 1270,
		[Token(Token = "0x400027F")]
		GoogleOAuthError = 1271,
		[Token(Token = "0x4000280")]
		UserNotFriend = 1272,
		[Token(Token = "0x4000281")]
		InvalidSignature = 1273,
		[Token(Token = "0x4000282")]
		InvalidPublicKey = 1274,
		[Token(Token = "0x4000283")]
		GoogleOAuthNoIdTokenIncludedInResponse = 1275,
		[Token(Token = "0x4000284")]
		StatisticUpdateInProgress = 1276,
		[Token(Token = "0x4000285")]
		LeaderboardVersionNotAvailable = 1277,
		[Token(Token = "0x4000286")]
		StatisticAlreadyHasPrizeTable = 1279,
		[Token(Token = "0x4000287")]
		PrizeTableHasOverlappingRanks = 1280,
		[Token(Token = "0x4000288")]
		PrizeTableHasMissingRanks = 1281,
		[Token(Token = "0x4000289")]
		PrizeTableRankStartsAtZero = 1282,
		[Token(Token = "0x400028A")]
		InvalidStatistic = 1283,
		[Token(Token = "0x400028B")]
		ExpressionParseFailure = 1284,
		[Token(Token = "0x400028C")]
		ExpressionInvokeFailure = 1285,
		[Token(Token = "0x400028D")]
		ExpressionTooLong = 1286,
		[Token(Token = "0x400028E")]
		DataUpdateRateExceeded = 1287,
		[Token(Token = "0x400028F")]
		RestrictedEmailDomain = 1288,
		[Token(Token = "0x4000290")]
		EncryptionKeyDisabled = 1289,
		[Token(Token = "0x4000291")]
		EncryptionKeyMissing = 1290,
		[Token(Token = "0x4000292")]
		EncryptionKeyBroken = 1291,
		[Token(Token = "0x4000293")]
		NoSharedSecretKeyConfigured = 1292,
		[Token(Token = "0x4000294")]
		SecretKeyNotFound = 1293,
		[Token(Token = "0x4000295")]
		PlayerSecretAlreadyConfigured = 1294,
		[Token(Token = "0x4000296")]
		APIRequestsDisabledForTitle = 1295,
		[Token(Token = "0x4000297")]
		InvalidSharedSecretKey = 1296,
		[Token(Token = "0x4000298")]
		PrizeTableHasNoRanks = 1297,
		[Token(Token = "0x4000299")]
		ProfileDoesNotExist = 1298,
		[Token(Token = "0x400029A")]
		ContentS3OriginBucketNotConfigured = 1299,
		[Token(Token = "0x400029B")]
		InvalidEnvironmentForReceipt = 1300,
		[Token(Token = "0x400029C")]
		EncryptedRequestNotAllowed = 1301,
		[Token(Token = "0x400029D")]
		SignedRequestNotAllowed = 1302,
		[Token(Token = "0x400029E")]
		RequestViewConstraintParamsNotAllowed = 1303,
		[Token(Token = "0x400029F")]
		BadPartnerConfiguration = 1304,
		[Token(Token = "0x40002A0")]
		XboxBPCertificateFailure = 1305,
		[Token(Token = "0x40002A1")]
		XboxXASSExchangeFailure = 1306,
		[Token(Token = "0x40002A2")]
		InvalidEntityId = 1307,
		[Token(Token = "0x40002A3")]
		StatisticValueAggregationOverflow = 1308,
		[Token(Token = "0x40002A4")]
		EmailMessageFromAddressIsMissing = 1309,
		[Token(Token = "0x40002A5")]
		EmailMessageToAddressIsMissing = 1310,
		[Token(Token = "0x40002A6")]
		SmtpServerAuthenticationError = 1311,
		[Token(Token = "0x40002A7")]
		SmtpServerLimitExceeded = 1312,
		[Token(Token = "0x40002A8")]
		SmtpServerInsufficientStorage = 1313,
		[Token(Token = "0x40002A9")]
		SmtpServerCommunicationError = 1314,
		[Token(Token = "0x40002AA")]
		SmtpServerGeneralFailure = 1315,
		[Token(Token = "0x40002AB")]
		EmailClientTimeout = 1316,
		[Token(Token = "0x40002AC")]
		EmailClientCanceledTask = 1317,
		[Token(Token = "0x40002AD")]
		EmailTemplateMissing = 1318,
		[Token(Token = "0x40002AE")]
		InvalidHostForTitleId = 1319,
		[Token(Token = "0x40002AF")]
		EmailConfirmationTokenDoesNotExist = 1320,
		[Token(Token = "0x40002B0")]
		EmailConfirmationTokenExpired = 1321,
		[Token(Token = "0x40002B1")]
		AccountDeleted = 1322,
		[Token(Token = "0x40002B2")]
		PlayerSecretNotConfigured = 1323,
		[Token(Token = "0x40002B3")]
		InvalidSignatureTime = 1324,
		[Token(Token = "0x40002B4")]
		NoContactEmailAddressFound = 1325,
		[Token(Token = "0x40002B5")]
		InvalidAuthToken = 1326,
		[Token(Token = "0x40002B6")]
		AuthTokenDoesNotExist = 1327,
		[Token(Token = "0x40002B7")]
		AuthTokenExpired = 1328,
		[Token(Token = "0x40002B8")]
		AuthTokenAlreadyUsedToResetPassword = 1329,
		[Token(Token = "0x40002B9")]
		MembershipNameTooLong = 1330,
		[Token(Token = "0x40002BA")]
		MembershipNotFound = 1331,
		[Token(Token = "0x40002BB")]
		GoogleServiceAccountInvalid = 1332,
		[Token(Token = "0x40002BC")]
		GoogleServiceAccountParseFailure = 1333,
		[Token(Token = "0x40002BD")]
		EntityTokenMissing = 1334,
		[Token(Token = "0x40002BE")]
		EntityTokenInvalid = 1335,
		[Token(Token = "0x40002BF")]
		EntityTokenExpired = 1336,
		[Token(Token = "0x40002C0")]
		EntityTokenRevoked = 1337,
		[Token(Token = "0x40002C1")]
		InvalidProductForSubscription = 1338,
		[Token(Token = "0x40002C2")]
		XboxInaccessible = 1339,
		[Token(Token = "0x40002C3")]
		SubscriptionAlreadyTaken = 1340,
		[Token(Token = "0x40002C4")]
		SmtpAddonNotEnabled = 1341,
		[Token(Token = "0x40002C5")]
		APIConcurrentRequestLimitExceeded = 1342,
		[Token(Token = "0x40002C6")]
		XboxRejectedXSTSExchangeRequest = 1343,
		[Token(Token = "0x40002C7")]
		VariableNotDefined = 1344,
		[Token(Token = "0x40002C8")]
		TemplateVersionNotDefined = 1345,
		[Token(Token = "0x40002C9")]
		FileTooLarge = 1346,
		[Token(Token = "0x40002CA")]
		TitleDeleted = 1347,
		[Token(Token = "0x40002CB")]
		TitleContainsUserAccounts = 1348,
		[Token(Token = "0x40002CC")]
		TitleDeletionPlayerCleanupFailure = 1349,
		[Token(Token = "0x40002CD")]
		EntityFileOperationPending = 1350,
		[Token(Token = "0x40002CE")]
		NoEntityFileOperationPending = 1351,
		[Token(Token = "0x40002CF")]
		EntityProfileVersionMismatch = 1352,
		[Token(Token = "0x40002D0")]
		TemplateVersionTooOld = 1353,
		[Token(Token = "0x40002D1")]
		MembershipDefinitionInUse = 1354,
		[Token(Token = "0x40002D2")]
		PaymentPageNotConfigured = 1355,
		[Token(Token = "0x40002D3")]
		FailedLoginAttemptRateLimitExceeded = 1356,
		[Token(Token = "0x40002D4")]
		EntityBlockedByGroup = 1357,
		[Token(Token = "0x40002D5")]
		RoleDoesNotExist = 1358,
		[Token(Token = "0x40002D6")]
		EntityIsAlreadyMember = 1359,
		[Token(Token = "0x40002D7")]
		DuplicateRoleId = 1360,
		[Token(Token = "0x40002D8")]
		GroupInvitationNotFound = 1361,
		[Token(Token = "0x40002D9")]
		GroupApplicationNotFound = 1362,
		[Token(Token = "0x40002DA")]
		OutstandingInvitationAcceptedInstead = 1363,
		[Token(Token = "0x40002DB")]
		OutstandingApplicationAcceptedInstead = 1364,
		[Token(Token = "0x40002DC")]
		RoleIsGroupDefaultMember = 1365,
		[Token(Token = "0x40002DD")]
		RoleIsGroupAdmin = 1366,
		[Token(Token = "0x40002DE")]
		RoleNameNotAvailable = 1367,
		[Token(Token = "0x40002DF")]
		GroupNameNotAvailable = 1368,
		[Token(Token = "0x40002E0")]
		EmailReportAlreadySent = 1369,
		[Token(Token = "0x40002E1")]
		EmailReportRecipientBlacklisted = 1370,
		[Token(Token = "0x40002E2")]
		EventNamespaceNotAllowed = 1371,
		[Token(Token = "0x40002E3")]
		EventEntityNotAllowed = 1372,
		[Token(Token = "0x40002E4")]
		InvalidEntityType = 1373,
		[Token(Token = "0x40002E5")]
		NullTokenResultFromAad = 1374,
		[Token(Token = "0x40002E6")]
		InvalidTokenResultFromAad = 1375,
		[Token(Token = "0x40002E7")]
		NoValidCertificateForAad = 1376,
		[Token(Token = "0x40002E8")]
		InvalidCertificateForAad = 1377,
		[Token(Token = "0x40002E9")]
		DuplicateDropTableId = 1378,
		[Token(Token = "0x40002EA")]
		MultiplayerServerError = 1379,
		[Token(Token = "0x40002EB")]
		MultiplayerServerTooManyRequests = 1380,
		[Token(Token = "0x40002EC")]
		MultiplayerServerNoContent = 1381,
		[Token(Token = "0x40002ED")]
		MultiplayerServerBadRequest = 1382,
		[Token(Token = "0x40002EE")]
		MultiplayerServerUnauthorized = 1383,
		[Token(Token = "0x40002EF")]
		MultiplayerServerForbidden = 1384,
		[Token(Token = "0x40002F0")]
		MultiplayerServerNotFound = 1385,
		[Token(Token = "0x40002F1")]
		MultiplayerServerConflict = 1386,
		[Token(Token = "0x40002F2")]
		MultiplayerServerInternalServerError = 1387,
		[Token(Token = "0x40002F3")]
		MultiplayerServerUnavailable = 1388,
		[Token(Token = "0x40002F4")]
		ExplicitContentDetected = 1389,
		[Token(Token = "0x40002F5")]
		PIIContentDetected = 1390,
		[Token(Token = "0x40002F6")]
		InvalidScheduledTaskParameter = 1391,
		[Token(Token = "0x40002F7")]
		PerEntityEventRateLimitExceeded = 1392,
		[Token(Token = "0x40002F8")]
		TitleDefaultLanguageNotSet = 1393,
		[Token(Token = "0x40002F9")]
		EmailTemplateMissingDefaultVersion = 1394,
		[Token(Token = "0x40002FA")]
		FacebookInstantGamesIdNotLinked = 1395,
		[Token(Token = "0x40002FB")]
		InvalidFacebookInstantGamesSignature = 1396,
		[Token(Token = "0x40002FC")]
		FacebookInstantGamesAuthNotConfiguredForTitle = 1397,
		[Token(Token = "0x40002FD")]
		MatchmakingEntityInvalid = 2001,
		[Token(Token = "0x40002FE")]
		MatchmakingPlayerAttributesInvalid = 2002,
		[Token(Token = "0x40002FF")]
		MatchmakingCreateRequestMissing = 2003,
		[Token(Token = "0x4000300")]
		MatchmakingCreateRequestCreatorMissing = 2004,
		[Token(Token = "0x4000301")]
		MatchmakingCreateRequestCreatorIdMissing = 2005,
		[Token(Token = "0x4000302")]
		MatchmakingCreateRequestUserListMissing = 2006,
		[Token(Token = "0x4000303")]
		MatchmakingCreateRequestGiveUpAfterInvalid = 2007,
		[Token(Token = "0x4000304")]
		MatchmakingTicketIdMissing = 2008,
		[Token(Token = "0x4000305")]
		MatchmakingMatchIdMissing = 2009,
		[Token(Token = "0x4000306")]
		MatchmakingMatchIdIdMissing = 2010,
		[Token(Token = "0x4000307")]
		MatchmakingQueueNameMissing = 2011,
		[Token(Token = "0x4000308")]
		MatchmakingTitleIdMissing = 2012,
		[Token(Token = "0x4000309")]
		MatchmakingTicketIdIdMissing = 2013,
		[Token(Token = "0x400030A")]
		MatchmakingPlayerIdMissing = 2014,
		[Token(Token = "0x400030B")]
		MatchmakingJoinRequestUserMissing = 2015,
		[Token(Token = "0x400030C")]
		MatchmakingQueueConfigNotFound = 2016,
		[Token(Token = "0x400030D")]
		MatchmakingMatchNotFound = 2017,
		[Token(Token = "0x400030E")]
		MatchmakingTicketNotFound = 2018,
		[Token(Token = "0x400030F")]
		MatchmakingCreateTicketServerIdentityInvalid = 2019,
		[Token(Token = "0x4000310")]
		MatchmakingCreateTicketClientIdentityInvalid = 2020,
		[Token(Token = "0x4000311")]
		MatchmakingGetTicketUserMismatch = 2021,
		[Token(Token = "0x4000312")]
		MatchmakingJoinTicketServerIdentityInvalid = 2022,
		[Token(Token = "0x4000313")]
		MatchmakingJoinTicketUserIdentityMismatch = 2023,
		[Token(Token = "0x4000314")]
		MatchmakingCancelTicketServerIdentityInvalid = 2024,
		[Token(Token = "0x4000315")]
		MatchmakingCancelTicketUserIdentityMismatch = 2025,
		[Token(Token = "0x4000316")]
		MatchmakingGetMatchIdentityMismatch = 2026,
		[Token(Token = "0x4000317")]
		MatchmakingPlayerIdentityMismatch = 2027,
		[Token(Token = "0x4000318")]
		MatchmakingAlreadyJoinedTicket = 2028,
		[Token(Token = "0x4000319")]
		MatchmakingTicketAlreadyCompleted = 2029,
		[Token(Token = "0x400031A")]
		MatchmakingQueueNameInvalid = 2030,
		[Token(Token = "0x400031B")]
		MatchmakingQueueConfigInvalid = 2031,
		[Token(Token = "0x400031C")]
		MatchmakingMemberProfileInvalid = 2032,
		[Token(Token = "0x400031D")]
		WriteAttemptedDuringExport = 2033,
		[Token(Token = "0x400031E")]
		NintendoSwitchDeviceIdNotLinked = 2034,
		[Token(Token = "0x400031F")]
		MatchmakingNotEnabled = 2035
	}
	[Token(Token = "0x2000040")]
	public delegate void ErrorCallback(PlayFabError error);
	[Token(Token = "0x2000041")]
	public class PlayFabError
	{
		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string ApiEndpoint;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int HttpCode;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string HttpStatus;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PlayFabErrorCode Error;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string ErrorMessage;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Dictionary<string, List<string>> ErrorDetails;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public object CustomData;

		[Token(Token = "0x4000327")]
		[ThreadStatic]
		private static StringBuilder _tempSb;

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xC28E1C", Offset = "0xC28E1C", VA = "0xC28E1C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xC291F8", Offset = "0xC291F8", VA = "0xC291F8")]
		public string GenerateErrorReport()
		{
			return null;
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xC29568", Offset = "0xC29568", VA = "0xC29568")]
		public PlayFabError()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class PlayFabException : Exception
	{
		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public readonly PlayFabExceptionCode Code;

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xC29570", Offset = "0xC29570", VA = "0xC29570")]
		public PlayFabException(PlayFabExceptionCode code, string message)
		{
		}
	}
	[Token(Token = "0x2000043")]
	public enum PlayFabExceptionCode
	{
		[Token(Token = "0x400032A")]
		DeveloperKeyNotSet,
		[Token(Token = "0x400032B")]
		EntityTokenNotSet,
		[Token(Token = "0x400032C")]
		NotLoggedIn,
		[Token(Token = "0x400032D")]
		TitleNotSet
	}
}
