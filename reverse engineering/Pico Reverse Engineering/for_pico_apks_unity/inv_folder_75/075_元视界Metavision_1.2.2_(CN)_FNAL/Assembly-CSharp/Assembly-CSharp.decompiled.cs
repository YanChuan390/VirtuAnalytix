using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Il2CppDummyDll;
using LitJson;
using Pico.Platform.Models;
using PolyAndCode.UI;
using RenderHeads.Media.AVProVideo;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.Networking;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class Loading : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform rectComponent;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Image imageComp;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool up;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float rotateSpeed;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float openSpeed;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float closeSpeed;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x915A1C", Offset = "0x915A1C", VA = "0x915A1C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x915ABC", Offset = "0x915ABC", VA = "0x915ABC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x915B10", Offset = "0x915B10", VA = "0x915B10")]
	private void changeSize()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x915BB0", Offset = "0x915BB0", VA = "0x915BB0")]
	public Loading()
	{
	}
}
[Token(Token = "0x2000003")]
public class loadingbar : MonoBehaviour
{
	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform rectComponent;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Image imageComp;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x915BD0", Offset = "0x915BD0", VA = "0x915BD0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x915C78", Offset = "0x915C78", VA = "0x915C78")]
	private void Update()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x915CD8", Offset = "0x915CD8", VA = "0x915CD8")]
	public loadingbar()
	{
	}
}
[Token(Token = "0x2000004")]
public class loadingcolorful : MonoBehaviour
{
	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform rectComponent;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Image imageComp;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x915CE0", Offset = "0x915CE0", VA = "0x915CE0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x915D88", Offset = "0x915D88", VA = "0x915D88")]
	private void Update()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x915DE8", Offset = "0x915DE8", VA = "0x915DE8")]
	public loadingcolorful()
	{
	}
}
[Token(Token = "0x2000005")]
public class loadingtext : MonoBehaviour
{
	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform rectComponent;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Image imageComp;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text text;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Text textNormal;

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x915DF0", Offset = "0x915DF0", VA = "0x915DF0")]
	private void Start()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x915E98", Offset = "0x915E98", VA = "0x915E98")]
	private void Update()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x916070", Offset = "0x916070", VA = "0x916070")]
	public loadingtext()
	{
	}
}
[Token(Token = "0x2000006")]
public class rotatetotate : MonoBehaviour
{
	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform rectComponent;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Image imageComp;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool up;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float rotateSpeed;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x916080", Offset = "0x916080", VA = "0x916080")]
	private void Start()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x916114", Offset = "0x916114", VA = "0x916114")]
	private void Update()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x916154", Offset = "0x916154", VA = "0x916154")]
	public rotatetotate()
	{
	}
}
[Token(Token = "0x2000007")]
public class SimpleLoading : MonoBehaviour
{
	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform rectComponent;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Image imageComp;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float rotateSpeed;

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x916164", Offset = "0x916164", VA = "0x916164")]
	private void Start()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x9161F8", Offset = "0x9161F8", VA = "0x9161F8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x916238", Offset = "0x916238", VA = "0x916238")]
	public SimpleLoading()
	{
	}
}
[Token(Token = "0x2000008")]
public class simplerotate : MonoBehaviour
{
	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform rectComponent;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Image imageComp;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float rotateSpeed;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float currentvalue;

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x916248", Offset = "0x916248", VA = "0x916248")]
	private void Start()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x9162DC", Offset = "0x9162DC", VA = "0x9162DC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x916388", Offset = "0x916388", VA = "0x916388")]
	public simplerotate()
	{
	}
}
[Token(Token = "0x2000009")]
public class DemoCell : MonoBehaviour, ICell
{
	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text nameLabel;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text genderLabel;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text idLabel;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ContactInfo _contactInfo;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int _cellIndex;

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x916398", Offset = "0x916398", VA = "0x916398")]
	private void Start()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x916448", Offset = "0x916448", VA = "0x916448")]
	public void ConfigureCell(ContactInfo contactInfo, int cellIndex)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x9164D8", Offset = "0x9164D8", VA = "0x9164D8")]
	private void ButtonListener()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x91674C", Offset = "0x91674C", VA = "0x91674C")]
	public DemoCell()
	{
	}
}
[Token(Token = "0x200000A")]
public struct ContactInfo
{
	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string Name;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public string Gender;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string id;
}
[Token(Token = "0x200000B")]
public class RecyclableScrollerDemo : MonoBehaviour, IRecyclableScrollRectDataSource
{
	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RecyclableScrollRect _recyclableScrollRect;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int _dataLength;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<ContactInfo> _contactList;

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x916754", Offset = "0x916754", VA = "0x916754")]
	private void Awake()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x916780", Offset = "0x916780", VA = "0x916780")]
	private void InitData()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x916AB0", Offset = "0x916AB0", VA = "0x916AB0", Slot = "4")]
	public int GetItemCount()
	{
		return default(int);
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x916AF8", Offset = "0x916AF8", VA = "0x916AF8", Slot = "5")]
	public void SetCell(ICell cell, int index)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x916BE0", Offset = "0x916BE0", VA = "0x916BE0")]
	public RecyclableScrollerDemo()
	{
	}
}
[Token(Token = "0x200000C")]
public static class UIExtension
{
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x916C68", Offset = "0x916C68", VA = "0x916C68")]
	public static Vector3[] GetCorners(this RectTransform rectTransform)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x916CD4", Offset = "0x916CD4", VA = "0x916CD4")]
	public static float MaxY(this RectTransform rectTransform)
	{
		return default(float);
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x916D00", Offset = "0x916D00", VA = "0x916D00")]
	public static float MinY(this RectTransform rectTransform)
	{
		return default(float);
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x916D28", Offset = "0x916D28", VA = "0x916D28")]
	public static float MaxX(this RectTransform rectTransform)
	{
		return default(float);
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x916D54", Offset = "0x916D54", VA = "0x916D54")]
	public static float MinX(this RectTransform rectTransform)
	{
		return default(float);
	}
}
[Token(Token = "0x200000D")]
public class AppManager : MonoBehaviour
{
	[Token(Token = "0x4000028")]
	public const string AppID = "1";

	[Token(Token = "0x4000029")]
	public const string AppSecret = "E4970953-E6FB-0D2B-DFBF-6A1FE298D5E1";

	[Token(Token = "0x400002A")]
	public const string ApiUrlBase = "https://metapi.avatarease.com/v1/";

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool hasNetwork;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Account account;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static AppManager _instance;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static int LoginTime;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static long WatchTime;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static long StartTime;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static int StartId;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private static bool MovieResume;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static int PrimaryHand;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private MediaPlayer videoPlayer;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject sphere;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject ui;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject loading;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Text loadingLabel;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject controller;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject playImage;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject pauseImage;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Button emptyButton;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Text currentTime;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Text totalTime;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Text videoName;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Image progress;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private ImageLoader videoIcon;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private BarController _barController;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private InputActionReference _leftTriggerAction;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private InputActionReference _rightTriggerAction;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private AudioSource _clickAudio;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private UserController _userController;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private ToggleGroup _navToggles;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private GameObject _leftHand;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private GameObject _rightHand;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private InputActionReference _triggerAction;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static Dictionary<string, ISwitchController> switcherLists;

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x916D7C", Offset = "0x916D7C", VA = "0x916D7C")]
	public static string addSwitcher(ISwitchController _switch)
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x916F6C", Offset = "0x916F6C", VA = "0x916F6C")]
	public static void removeSwitcher(string _key)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x916FEC", Offset = "0x916FEC", VA = "0x916FEC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x9172C4", Offset = "0x9172C4", VA = "0x9172C4")]
	public void SetValidController()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x917C38", Offset = "0x917C38", VA = "0x917C38")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x9180E0", Offset = "0x9180E0", VA = "0x9180E0")]
	private void OnSwitchBar(InputAction.CallbackContext context)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x918154", Offset = "0x918154", VA = "0x918154")]
	public static Coroutine StartAsynchronous(IEnumerator routine)
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x918228", Offset = "0x918228", VA = "0x918228")]
	public static bool RefreshNetworkStatus()
	{
		return default(bool);
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x918298", Offset = "0x918298", VA = "0x918298")]
	public static ToggleGroup GetNavToggleGroup()
	{
		return null;
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x9182FC", Offset = "0x9182FC", VA = "0x9182FC")]
	public static void PlayVideo(ContentInfo contentInfo)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x91863C", Offset = "0x91863C", VA = "0x91863C")]
	public static void PlayClick()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x9186A8", Offset = "0x9186A8", VA = "0x9186A8")]
	public static void SkipVideo(float _progress)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x918718", Offset = "0x918718", VA = "0x918718")]
	private void SetVideoProgress(float _progress)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x918394", Offset = "0x918394", VA = "0x918394")]
	private void StartPlay(ContentInfo contentInfo)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x918E80", Offset = "0x918E80", VA = "0x918E80")]
	public void ExitPlay()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x9193D4", Offset = "0x9193D4", VA = "0x9193D4")]
	public void Login()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x9196AC", Offset = "0x9196AC", VA = "0x9196AC")]
	public void PlayOrPause()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x919954", Offset = "0x919954", VA = "0x919954")]
	public void Shutdown()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x91995C", Offset = "0x91995C", VA = "0x91995C")]
	private void OnApplicationFocus(bool hasFocus)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x9199F0", Offset = "0x9199F0", VA = "0x9199F0")]
	private void OnApplicationPause(bool hasPause)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x919FBC", Offset = "0x919FBC", VA = "0x919FBC")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x917A14", Offset = "0x917A14", VA = "0x917A14")]
	private void SubmitLogin(string type)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x919D58", Offset = "0x919D58", VA = "0x919D58")]
	private void SubmitLogout(string type)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x91A148", Offset = "0x91A148", VA = "0x91A148")]
	private void SubmitTime(string type)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x9191A0", Offset = "0x9191A0", VA = "0x9191A0")]
	private void SubmitWatch()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x91A35C", Offset = "0x91A35C", VA = "0x91A35C")]
	public AppManager()
	{
	}
}
[Token(Token = "0x2000010")]
public class BarController : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Toggle _isFav;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Button _volumnBtn;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Slider _volumnSlider;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private MediaPlayer _mediaPlayer;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Button _setting;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject _settingInfo;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Toggle _toggleLeft;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Toggle _toggleRight;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private AppManager _appManager;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int _contentId;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int _favId;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool isEnter;

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x91AC3C", Offset = "0x91AC3C", VA = "0x91AC3C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x91AFD8", Offset = "0x91AFD8", VA = "0x91AFD8", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x91AFE4", Offset = "0x91AFE4", VA = "0x91AFE4", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x91AFEC", Offset = "0x91AFEC", VA = "0x91AFEC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x91AC10", Offset = "0x91AC10", VA = "0x91AC10")]
	public void SetInfo(int contentId, int fav)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x91B040", Offset = "0x91B040", VA = "0x91B040")]
	public BarController()
	{
	}
}
[Token(Token = "0x2000011")]
public struct NavInfo
{
	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string id;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public int type;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string code;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string name;
}
[Token(Token = "0x2000012")]
public struct RecommendInfo
{
	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int id;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public string name;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<ContentInfo> items;
}
[Token(Token = "0x2000013")]
public struct Filter
{
	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string navKey;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public string key;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int sort;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int currentPage;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int totalPage;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<ContentInfo> items;
}
[Token(Token = "0x2000014")]
public struct Account
{
	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string identity;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public string channel;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string head;

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x91A6B4", Offset = "0x91A6B4", VA = "0x91A6B4")]
	public static Account Parse(User user)
	{
		return default(Account);
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x919580", Offset = "0x919580", VA = "0x919580")]
	public static Account Empty()
	{
		return default(Account);
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x919610", Offset = "0x919610", VA = "0x919610")]
	public void Save()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x91B6B8", Offset = "0x91B6B8", VA = "0x91B6B8")]
	public string ToJson()
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x9176E8", Offset = "0x9176E8", VA = "0x9176E8")]
	public static Account FromJson()
	{
		return default(Account);
	}
}
[Token(Token = "0x2000015")]
public struct CategoryInfo
{
	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string key;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public string parent_key;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<CategoryInfo> children;

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x91B7FC", Offset = "0x91B7FC", VA = "0x91B7FC")]
	public static CategoryInfo parse(JsonData data)
	{
		return default(CategoryInfo);
	}
}
[Token(Token = "0x2000016")]
public struct ContentInfo
{
	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int id;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public string identity;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<string> tags;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string description;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string cover;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public JsonData preview;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public JsonData opt;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int type;

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x91B928", Offset = "0x91B928", VA = "0x91B928")]
	public static ContentInfo parse(JsonData jsonData)
	{
		return default(ContentInfo);
	}
}
[Token(Token = "0x2000017")]
public class CategoryItem : MonoBehaviour, ICell
{
	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text _label;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Toggle _button;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private CategoryInfo _categoryInfo;

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x91BD28", Offset = "0x91BD28", VA = "0x91BD28")]
	public void ConfigureCell(CategoryInfo categoryInfo, bool isDefault, ToggleGroup _group)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x91BF9C", Offset = "0x91BF9C", VA = "0x91BF9C")]
	public CategoryItem()
	{
	}
}
[Token(Token = "0x2000019")]
public class CategoryLoader : MonoBehaviour, IRecyclableScrollRectDataSource
{
	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RecyclableScrollRect recyclableScrollRect;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<CategoryInfo> _items;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private CategoryInfo _last;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Toggle _lastButton;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Color _labelColor;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Color _labelColorSelected;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private ToggleGroup _group;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int _defautlIndex;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static CategoryLoader _instance;

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x91BFE4", Offset = "0x91BFE4", VA = "0x91BFE4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x91BEF0", Offset = "0x91BEF0", VA = "0x91BEF0")]
	public static void CategoryClicked(Toggle button, CategoryInfo info, bool isUserAction)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x91C03C", Offset = "0x91C03C", VA = "0x91C03C")]
	private void clickItem(Toggle button, CategoryInfo info, bool isUserAction)
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x91C208", Offset = "0x91C208", VA = "0x91C208")]
	public void InitData(List<CategoryInfo> info, int defautlIndex)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x91C2A0", Offset = "0x91C2A0", VA = "0x91C2A0", Slot = "4")]
	public int GetItemCount()
	{
		return default(int);
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x91C2E8", Offset = "0x91C2E8", VA = "0x91C2E8", Slot = "5")]
	public void SetCell(ICell cell, int index)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x91C3CC", Offset = "0x91C3CC", VA = "0x91C3CC")]
	public CategoryLoader()
	{
	}
}
[Token(Token = "0x200001A")]
public class ContentItem : MonoBehaviour, ICell
{
	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text label;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text tagText;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ImageLoader cover;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Button button;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private ContentInfo _contentInfo;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private int _index;

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x91C3DC", Offset = "0x91C3DC", VA = "0x91C3DC")]
	public void ConfigureCell(ContentInfo contentInfo, int cellIndex, int isTop)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x91C708", Offset = "0x91C708", VA = "0x91C708")]
	public void OnButtonHoverEffect()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x91C754", Offset = "0x91C754", VA = "0x91C754")]
	public ContentItem()
	{
	}
}
[Token(Token = "0x200001C")]
public class ContentLoader : MonoBehaviour, IRecyclableScrollRectDataSource
{
	[Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class <refreshLoadingStatus>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ContentLoader <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x91D504", Offset = "0x91D504", VA = "0x91D504", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x91D54C", Offset = "0x91D54C", VA = "0x91D54C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x91CDB8", Offset = "0x91CDB8", VA = "0x91CDB8")]
		[DebuggerHidden]
		public <refreshLoadingStatus>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x91D44C", Offset = "0x91D44C", VA = "0x91D44C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x91D450", Offset = "0x91D450", VA = "0x91D450", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x91D50C", Offset = "0x91D50C", VA = "0x91D50C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RecyclableScrollRect recyclableScrollRect;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<ContentInfo> _items;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Filter _filter;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool isLoading;

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x91C7DC", Offset = "0x91C7DC", VA = "0x91C7DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x91C808", Offset = "0x91C808", VA = "0x91C808")]
	public void InitData(Filter filter)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x91C888", Offset = "0x91C888", VA = "0x91C888")]
	private void LoadingContent()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x91CD44", Offset = "0x91CD44", VA = "0x91CD44")]
	[IteratorStateMachine(typeof(<refreshLoadingStatus>d__7))]
	private IEnumerator refreshLoadingStatus()
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x91CDE0", Offset = "0x91CDE0", VA = "0x91CDE0", Slot = "4")]
	public int GetItemCount()
	{
		return default(int);
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x91CE28", Offset = "0x91CE28", VA = "0x91CE28", Slot = "5")]
	public void SetCell(ICell cell, int index)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x91CF80", Offset = "0x91CF80", VA = "0x91CF80")]
	public ContentLoader()
	{
	}
}
[Token(Token = "0x200001E")]
public class HttpRequest
{
	[Token(Token = "0x200001F")]
	public delegate void Callback(UnityWebRequest resp);

	[Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class <GetRequest>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string url;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public JsonData headers;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Callback callback;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x91DE74", Offset = "0x91DE74", VA = "0x91DE74", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x91DEBC", Offset = "0x91DEBC", VA = "0x91DEBC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x91D5F8", Offset = "0x91D5F8", VA = "0x91D5F8")]
		[DebuggerHidden]
		public <GetRequest>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x91D904", Offset = "0x91D904", VA = "0x91D904", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x91D920", Offset = "0x91D920", VA = "0x91D920", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x91DDC4", Offset = "0x91DDC4", VA = "0x91DDC4")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x91DE7C", Offset = "0x91DE7C", VA = "0x91DE7C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class <DeleteRequest>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string url;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public JsonData headers;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Callback callback;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000005")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x91E438", Offset = "0x91E438", VA = "0x91E438", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x91E480", Offset = "0x91E480", VA = "0x91E480", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x91D6C4", Offset = "0x91D6C4", VA = "0x91D6C4")]
		[DebuggerHidden]
		public <DeleteRequest>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x91DEC4", Offset = "0x91DEC4", VA = "0x91DEC4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x91DEE0", Offset = "0x91DEE0", VA = "0x91DEE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x91E388", Offset = "0x91E388", VA = "0x91E388")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x91E440", Offset = "0x91E440", VA = "0x91E440", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class <PostRequest>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string url;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string postData;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public JsonData headers;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Callback callback;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000007")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x91EB80", Offset = "0x91EB80", VA = "0x91EB80", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x91EBC8", Offset = "0x91EBC8", VA = "0x91EBC8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x91D7AC", Offset = "0x91D7AC", VA = "0x91D7AC")]
		[DebuggerHidden]
		public <PostRequest>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x91E488", Offset = "0x91E488", VA = "0x91E488", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x91E4A4", Offset = "0x91E4A4", VA = "0x91E4A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x91EAD0", Offset = "0x91EAD0", VA = "0x91EAD0")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x91EB88", Offset = "0x91EB88", VA = "0x91EB88", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class <PutRequest>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string url;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string postData;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public JsonData headers;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Callback callback;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000009")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x91F2C4", Offset = "0x91F2C4", VA = "0x91F2C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x91F30C", Offset = "0x91F30C", VA = "0x91F30C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x91D894", Offset = "0x91D894", VA = "0x91D894")]
		[DebuggerHidden]
		public <PutRequest>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x91EBD0", Offset = "0x91EBD0", VA = "0x91EBD0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x91EBEC", Offset = "0x91EBEC", VA = "0x91EBEC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x91F214", Offset = "0x91F214", VA = "0x91F214")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x91F2CC", Offset = "0x91F2CC", VA = "0x91F2CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x91D554", Offset = "0x91D554", VA = "0x91D554")]
	[IteratorStateMachine(typeof(<GetRequest>d__1))]
	public IEnumerator GetRequest(string url, JsonData headers, Callback callback)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x91D620", Offset = "0x91D620", VA = "0x91D620")]
	[IteratorStateMachine(typeof(<DeleteRequest>d__2))]
	public IEnumerator DeleteRequest(string url, JsonData headers, Callback callback)
	{
		return null;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x91D6EC", Offset = "0x91D6EC", VA = "0x91D6EC")]
	[IteratorStateMachine(typeof(<PostRequest>d__3))]
	public IEnumerator PostRequest(string url, string postData, JsonData headers, Callback callback)
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x91D7D4", Offset = "0x91D7D4", VA = "0x91D7D4")]
	[IteratorStateMachine(typeof(<PutRequest>d__4))]
	public IEnumerator PutRequest(string url, string postData, JsonData headers, Callback callback)
	{
		return null;
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x91D8BC", Offset = "0x91D8BC", VA = "0x91D8BC")]
	public HttpRequest()
	{
	}
}
[Token(Token = "0x2000024")]
public class ImageLoader : MonoBehaviour
{
	[Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class <LoadTeture>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string url;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool memoryCache;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<Texture2D> cb;

		[Token(Token = "0x1700000B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x91FFF4", Offset = "0x91FFF4", VA = "0x91FFF4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x92003C", Offset = "0x92003C", VA = "0x92003C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x91F9FC", Offset = "0x91F9FC", VA = "0x91F9FC")]
		[DebuggerHidden]
		public <LoadTeture>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x91FEAC", Offset = "0x91FEAC", VA = "0x91FEAC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x91FEB0", Offset = "0x91FEB0", VA = "0x91FEB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x91FFFC", Offset = "0x91FFFC", VA = "0x91FFFC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class <LoadByIOTeture>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string filePath;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool memoryCache;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<Texture2D> cb;

		[Token(Token = "0x1700000D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x92018C", Offset = "0x92018C", VA = "0x92018C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x9201D4", Offset = "0x9201D4", VA = "0x9201D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x91FA24", Offset = "0x91FA24", VA = "0x91FA24")]
		[DebuggerHidden]
		public <LoadByIOTeture>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x920044", Offset = "0x920044", VA = "0x920044", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x920048", Offset = "0x920048", VA = "0x920048", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x920194", Offset = "0x920194", VA = "0x920194", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D texture2D;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Texture2D cachTexture2D;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool isImage;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RawImage _RawImage;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Image _Image;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Sprite _imageSprite;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Action _delayLoadAction;

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x91F314", Offset = "0x91F314", VA = "0x91F314")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x91F370", Offset = "0x91F370", VA = "0x91F370")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x91F5C0", Offset = "0x91F5C0", VA = "0x91F5C0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x91F518", Offset = "0x91F518", VA = "0x91F518")]
	private static Sprite CreateSpriteFromTexture2D(Texture2D _texture2D)
	{
		return null;
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x918960", Offset = "0x918960", VA = "0x918960")]
	public void Load(string imageURL, bool memoryCache = false)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x91F6A0", Offset = "0x91F6A0", VA = "0x91F6A0")]
	public void LoadBackSize(string imageURL, Action<Vector2> action)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x91F890", Offset = "0x91F890", VA = "0x91F890")]
	public void LoadByIO(string filePath, bool memoryCache = false)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x91F604", Offset = "0x91F604", VA = "0x91F604")]
	[IteratorStateMachine(typeof(<LoadTeture>d__14))]
	private IEnumerator LoadTeture(string url, bool memoryCache, Action<Texture2D> cb)
	{
		return null;
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x91F960", Offset = "0x91F960", VA = "0x91F960")]
	[IteratorStateMachine(typeof(<LoadByIOTeture>d__15))]
	private IEnumerator LoadByIOTeture(string filePath, bool memoryCache, Action<Texture2D> cb)
	{
		return null;
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x91FA4C", Offset = "0x91FA4C", VA = "0x91FA4C")]
	public ImageLoader()
	{
	}
}
[Token(Token = "0x2000029")]
public interface ISwitchController
{
	[Token(Token = "0x60000BC")]
	void UpdateController();
}
[Token(Token = "0x200002A")]
public class ListLoader : MonoBehaviour
{
	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private CategoryLoader _catgoryLoader;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<CategoryInfo> _infos;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private CategoryInfo _info;

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x9201DC", Offset = "0x9201DC", VA = "0x9201DC")]
	public void SetCategory(NavInfo info, string defaultSelect)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x9202DC", Offset = "0x9202DC", VA = "0x9202DC")]
	private CategoryInfo FindCategoryInfo(NavInfo info)
	{
		return default(CategoryInfo);
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x9203C4", Offset = "0x9203C4", VA = "0x9203C4")]
	public void InitData(JsonData data)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x920794", Offset = "0x920794", VA = "0x920794")]
	public ListLoader()
	{
	}
}
[Token(Token = "0x200002B")]
public class LoadImageManager : MonoSingleton<LoadImageManager>
{
	[Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool hasLoad;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<Texture2D> loadEnd;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LoadImageManager <>4__this;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string url;

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x920E68", Offset = "0x920E68", VA = "0x920E68")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x920E70", Offset = "0x920E70", VA = "0x920E70")]
		internal void <LoadImage>b__1(bool state, Texture2D localTexture)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x920EA0", Offset = "0x920EA0", VA = "0x920EA0")]
		internal void <LoadImage>b__0(bool state, Texture2D downloadTexture)
		{
		}
	}

	[Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class <LoadImage>d__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<Texture2D> loadEnd;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LoadImageManager <>4__this;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string url;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private <>c__DisplayClass0_0 <>8__1;

		[Token(Token = "0x1700000F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x9211E0", Offset = "0x9211E0", VA = "0x9211E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x921228", Offset = "0x921228", VA = "0x921228", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x92081C", Offset = "0x92081C", VA = "0x92081C")]
		[DebuggerHidden]
		public <LoadImage>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x920F04", Offset = "0x920F04", VA = "0x920F04", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x920F08", Offset = "0x920F08", VA = "0x920F08", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x9211E8", Offset = "0x9211E8", VA = "0x9211E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class <LoadByIO>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<Texture2D> loadEnd;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string filePath;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LoadImageManager <>4__this;

		[Token(Token = "0x17000011")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x9213B8", Offset = "0x9213B8", VA = "0x9213B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x921400", Offset = "0x921400", VA = "0x921400", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x920844", Offset = "0x920844", VA = "0x920844")]
		[DebuggerHidden]
		public <LoadByIO>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x921260", Offset = "0x921260", VA = "0x921260", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x921264", Offset = "0x921264", VA = "0x921264", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x9213C0", Offset = "0x9213C0", VA = "0x9213C0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class <LoadByIO>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string url;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<bool, Texture2D> downloadEnd;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <time>5__2;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private FileStream <fs>5__3;

		[Token(Token = "0x17000013")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x92183C", Offset = "0x92183C", VA = "0x92183C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x921884", Offset = "0x921884", VA = "0x921884", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x9208FC", Offset = "0x9208FC", VA = "0x9208FC")]
		[DebuggerHidden]
		public <LoadByIO>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x921408", Offset = "0x921408", VA = "0x921408", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x921424", Offset = "0x921424", VA = "0x921424", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x92178C", Offset = "0x92178C", VA = "0x92178C")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x921844", Offset = "0x921844", VA = "0x921844", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class <LoadByIO2>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string url;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<bool, Texture2D> downloadEnd;

		[Token(Token = "0x17000015")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x921978", Offset = "0x921978", VA = "0x921978", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x9219C0", Offset = "0x9219C0", VA = "0x9219C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x9209B4", Offset = "0x9209B4", VA = "0x9209B4")]
		[DebuggerHidden]
		public <LoadByIO2>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x92188C", Offset = "0x92188C", VA = "0x92188C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x921890", Offset = "0x921890", VA = "0x921890", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x921980", Offset = "0x921980", VA = "0x921980", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class <DownloadImage>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string url;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<bool, Texture2D> downloadEnd;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UnityWebRequest <request>5__2;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private DownloadHandlerTexture <downloadHandlerTexture>5__3;

		[Token(Token = "0x17000017")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x921E0C", Offset = "0x921E0C", VA = "0x921E0C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x921E54", Offset = "0x921E54", VA = "0x921E54", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x920A6C", Offset = "0x920A6C", VA = "0x920A6C")]
		[DebuggerHidden]
		public <DownloadImage>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x9219C8", Offset = "0x9219C8", VA = "0x9219C8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x9219E4", Offset = "0x9219E4", VA = "0x9219E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x921D5C", Offset = "0x921D5C", VA = "0x921D5C")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x921E14", Offset = "0x921E14", VA = "0x921E14", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x91FF50", Offset = "0x91FF50", VA = "0x91FF50")]
	[IteratorStateMachine(typeof(<LoadImage>d__0))]
	public IEnumerator LoadImage(string url, bool memoryCache, Action<Texture2D> loadEnd)
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x9200E8", Offset = "0x9200E8", VA = "0x9200E8")]
	[IteratorStateMachine(typeof(<LoadByIO>d__1))]
	public IEnumerator LoadByIO(string filePath, bool memoryCache, Action<Texture2D> loadEnd)
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x92086C", Offset = "0x92086C", VA = "0x92086C")]
	[IteratorStateMachine(typeof(<LoadByIO>d__2))]
	public IEnumerator LoadByIO(string url, Action<bool, Texture2D> downloadEnd)
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x920924", Offset = "0x920924", VA = "0x920924")]
	[IteratorStateMachine(typeof(<LoadByIO2>d__3))]
	public IEnumerator LoadByIO2(string url, Action<bool, Texture2D> downloadEnd)
	{
		return null;
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x9209DC", Offset = "0x9209DC", VA = "0x9209DC")]
	[IteratorStateMachine(typeof(<DownloadImage>d__4))]
	public IEnumerator DownloadImage(string url, Action<bool, Texture2D> downloadEnd)
	{
		return null;
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x920A94", Offset = "0x920A94", VA = "0x920A94")]
	private void Save2LocalPath(string url, Texture2D texture)
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x920C48", Offset = "0x920C48", VA = "0x920C48")]
	private string GetLocalPath()
	{
		return null;
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x920E20", Offset = "0x920E20", VA = "0x920E20")]
	public LoadImageManager()
	{
	}
}
[Token(Token = "0x2000033")]
public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static T _mInstance;

	[Token(Token = "0x17000019")]
	public static T Instance
	{
		[Token(Token = "0x60000EE")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000EF")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000F0")]
	protected virtual void Init()
	{
	}

	[Token(Token = "0x60000F1")]
	public void DestroySelf()
	{
	}

	[Token(Token = "0x60000F2")]
	public virtual void Dispose()
	{
	}

	[Token(Token = "0x60000F3")]
	protected MonoSingleton()
	{
	}
}
[Token(Token = "0x2000034")]
public class NavItem : MonoBehaviour, ICell
{
	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text label;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Toggle button;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private NavInfo _navInfo;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int _index;

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x921E5C", Offset = "0x921E5C", VA = "0x921E5C")]
	public void ConfigureCell(NavInfo navInfo, int cellIndex)
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x92203C", Offset = "0x92203C", VA = "0x92203C")]
	public NavItem()
	{
	}
}
[Token(Token = "0x2000036")]
public class NavLoader : MonoBehaviour, IRecyclableScrollRectDataSource
{
	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RecyclableScrollRect recyclableScrollRect;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RecommendItemsLoader recommendItemsLoader;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ListLoader listLoader;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ContentLoader contentLoader;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject _recommendObj;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject _listObj;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject _favObj;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Color _labelColor;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Color _labelColorSelected;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private SortSwitcher _sortSwitcher;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private ToggleGroup _toggleGroup;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Color _arrowColor;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Toggle _lastButton;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private NavInfo _lastNavInfo;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private NavInfo _lastCategoryNavInfo;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private bool initButtonColors;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private ColorBlock defaultColorBlock;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private ColorBlock selectedColorBlock;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private Dictionary<string, Filter> _contents;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private Filter _currentFilter;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static NavLoader _instance;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private List<NavInfo> _navs;

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x922108", Offset = "0x922108", VA = "0x922108")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x922084", Offset = "0x922084", VA = "0x922084")]
	public static void clickNav(NavInfo navInfo, Toggle button)
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x9221F8", Offset = "0x9221F8", VA = "0x9221F8")]
	private void clickItem(NavInfo navInfo, Toggle button)
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x9226B0", Offset = "0x9226B0", VA = "0x9226B0")]
	private void revertContent(NavInfo navInfo, Filter filter)
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x91C1A0", Offset = "0x91C1A0", VA = "0x91C1A0")]
	public static void updateFilter(int type, string data)
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x91D364", Offset = "0x91D364", VA = "0x91D364")]
	public static void updateFilterItems(Filter _filter)
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x9227C0", Offset = "0x9227C0", VA = "0x9227C0")]
	private void setFilterData(int type, string data)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x9228F4", Offset = "0x9228F4", VA = "0x9228F4")]
	private void InitData(string recommend, string categories)
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x922D68", Offset = "0x922D68", VA = "0x922D68", Slot = "4")]
	public int GetItemCount()
	{
		return default(int);
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x922DB0", Offset = "0x922DB0", VA = "0x922DB0", Slot = "5")]
	public void SetCell(ICell cell, int index)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x922E88", Offset = "0x922E88", VA = "0x922E88")]
	public NavLoader()
	{
	}
}
[Token(Token = "0x2000038")]
public class ProgressController : MonoBehaviour
{
	[Token(Token = "0x6000106")]
	[Address(RVA = "0x923148", Offset = "0x923148", VA = "0x923148")]
	public void OnSliderChange(float data)
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x9231A4", Offset = "0x9231A4", VA = "0x9231A4")]
	public ProgressController()
	{
	}
}
[Token(Token = "0x2000039")]
public class RecommendItemLoader : MonoBehaviour, IRecyclableScrollRectDataSource
{
	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RecyclableScrollRect recyclableScrollRect;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<ContentInfo> _items;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool _isTop;

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x9231AC", Offset = "0x9231AC", VA = "0x9231AC")]
	public void InitData(List<ContentInfo> items, bool isTop)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x9231FC", Offset = "0x9231FC", VA = "0x9231FC", Slot = "4")]
	public int GetItemCount()
	{
		return default(int);
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x923244", Offset = "0x923244", VA = "0x923244", Slot = "5")]
	public void SetCell(ICell cell, int index)
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x923400", Offset = "0x923400", VA = "0x923400")]
	public RecommendItemLoader()
	{
	}
}
[Token(Token = "0x200003A")]
public class RecommendItems : MonoBehaviour, ICell
{
	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject basic;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject top;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text label;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Text labelTop;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RecommendItemLoader _recommendItemLoader;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RecommendItemLoader _recommendItemLoaderTop;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private RecommendInfo _recommendInfo;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int _index;

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x923488", Offset = "0x923488", VA = "0x923488")]
	public void ConfigureCell(RecommendInfo recommendInfo, int cellIndex)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x92357C", Offset = "0x92357C", VA = "0x92357C")]
	public RecommendItems()
	{
	}
}
[Token(Token = "0x200003B")]
public class RecommendItemsLoader : MonoBehaviour, IRecyclableScrollRectDataSource
{
	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RecyclableScrollRect recyclableScrollRect;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<RecommendInfo> _items;

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x922D2C", Offset = "0x922D2C", VA = "0x922D2C")]
	public void InitData(JsonData data)
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x923584", Offset = "0x923584", VA = "0x923584")]
	public void initRecommends(JsonData data)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x923944", Offset = "0x923944", VA = "0x923944", Slot = "4")]
	public int GetItemCount()
	{
		return default(int);
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x92398C", Offset = "0x92398C", VA = "0x92398C", Slot = "5")]
	public void SetCell(ICell cell, int index)
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x923A74", Offset = "0x923A74", VA = "0x923A74")]
	public RecommendItemsLoader()
	{
	}
}
[Token(Token = "0x200003C")]
public static class RemoteKit
{
	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly DateTime StartTime;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static MD5 md5;

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x91A008", Offset = "0x91A008", VA = "0x91A008")]
	public static Coroutine Post(string url, string postData, JsonData headers, HttpRequest.Callback callback)
	{
		return null;
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x923EB0", Offset = "0x923EB0", VA = "0x923EB0")]
	public static Coroutine Put(string url, string postData, JsonData headers, HttpRequest.Callback callback)
	{
		return null;
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x923AFC", Offset = "0x923AFC", VA = "0x923AFC")]
	private static bool NoNetworkNotice()
	{
		return default(bool);
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x918D48", Offset = "0x918D48", VA = "0x918D48")]
	public static Coroutine Get(string url, JsonData headers, HttpRequest.Callback callback)
	{
		return null;
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x91B46C", Offset = "0x91B46C", VA = "0x91B46C")]
	public static Coroutine Delete(string url, JsonData headers, HttpRequest.Callback callback)
	{
		return null;
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x923B78", Offset = "0x923B78", VA = "0x923B78")]
	private static JsonData CommonHeaders(JsonData headers)
	{
		return null;
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x9190D0", Offset = "0x9190D0", VA = "0x9190D0")]
	public static long UnixTime()
	{
		return default(long);
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x920CE8", Offset = "0x920CE8", VA = "0x920CE8")]
	public static string Md5(string str)
	{
		return null;
	}
}
[Token(Token = "0x200003D")]
public class ScrollController : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, ISwitchController
{
	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ScrollRect _scrollRect;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float speed;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private bool isVertical;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private InputActionReference leftStick;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private InputActionReference rightStick;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private InputActionReference stick;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool _isEnter;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private bool _isScroll;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	private bool _direction;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string _key;

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x924090", Offset = "0x924090", VA = "0x924090")]
	private void Awake()
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x92412C", Offset = "0x92412C", VA = "0x92412C")]
	private void Update()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x92429C", Offset = "0x92429C", VA = "0x92429C")]
	private void ScrollUp()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x924238", Offset = "0x924238", VA = "0x924238")]
	private void ScrollDown()
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x924304", Offset = "0x924304", VA = "0x924304")]
	private void ScrollLeft()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x924368", Offset = "0x924368", VA = "0x924368")]
	private void ScrollRight()
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x9243D0", Offset = "0x9243D0", VA = "0x9243D0", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x9243DC", Offset = "0x9243DC", VA = "0x9243DC", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x9243E4", Offset = "0x9243E4", VA = "0x9243E4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x92441C", Offset = "0x92441C", VA = "0x92441C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x924450", Offset = "0x924450", VA = "0x924450")]
	private void OnDestory()
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x9244A8", Offset = "0x9244A8", VA = "0x9244A8", Slot = "6")]
	public void UpdateController()
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x92451C", Offset = "0x92451C", VA = "0x92451C")]
	public ScrollController()
	{
	}
}
[Token(Token = "0x200003E")]
public class SortSwitcher : MonoBehaviour
{
	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<Button> _buttons;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Color _labelColor;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Color _labelColorSelected;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Button _lastButton;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private ColorBlock defaultColorBlock;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private ColorBlock selectedColorBlock;

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x92453C", Offset = "0x92453C", VA = "0x92453C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x92275C", Offset = "0x92275C", VA = "0x92275C")]
	public void setDefault(int idx)
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x9246F0", Offset = "0x9246F0", VA = "0x9246F0")]
	private void btnClick(Button _tmp)
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x924908", Offset = "0x924908", VA = "0x924908")]
	public SortSwitcher()
	{
	}
}
[Token(Token = "0x2000040")]
public class UIHandler : MonoBehaviour, ISwitchController
{
	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform _sphereTransform;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform _uiTransform;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private InputActionReference _leftHandSelectRef;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private InputActionReference _leftHandRotateRef;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private InputActionReference _leftScroll;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private InputActionReference _rightHandSelectRef;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private InputActionReference _rightHandRotateRef;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private InputActionReference _rightScroll;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject _notice;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float _scaleRate;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool IsActive;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool _reset;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3 _lastRotation;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int clickedTimes;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private InputActionReference _handSelectRef;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private InputActionReference _handRotateRef;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private InputActionReference _scroll;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private string _key;

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x924A8C", Offset = "0x924A8C", VA = "0x924A8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x924AF8", Offset = "0x924AF8", VA = "0x924AF8")]
	private void ResetController()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x924BAC", Offset = "0x924BAC", VA = "0x924BAC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x924CF0", Offset = "0x924CF0", VA = "0x924CF0")]
	private void ResetAll()
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x924D6C", Offset = "0x924D6C", VA = "0x924D6C")]
	private void OnHold(InputAction.CallbackContext context)
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x924DD4", Offset = "0x924DD4", VA = "0x924DD4")]
	private void OnRelease(InputAction.CallbackContext context)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x924E84", Offset = "0x924E84", VA = "0x924E84")]
	private void ClearDouble()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x924E8C", Offset = "0x924E8C", VA = "0x924E8C")]
	private void OnRotateChange(InputAction.CallbackContext context)
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x925230", Offset = "0x925230", VA = "0x925230")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x925398", Offset = "0x925398", VA = "0x925398")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x925520", Offset = "0x925520", VA = "0x925520")]
	private void OnDestory()
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x925578", Offset = "0x925578", VA = "0x925578", Slot = "4")]
	public void UpdateController()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x92557C", Offset = "0x92557C", VA = "0x92557C")]
	public UIHandler()
	{
	}
}
[Token(Token = "0x2000041")]
public class UserContentLoader : MonoBehaviour, IRecyclableScrollRectDataSource
{
	[Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class <refreshLoadingStatus>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UserContentLoader <>4__this;

		[Token(Token = "0x1700001A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x925DB4", Offset = "0x925DB4", VA = "0x925DB4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x925DFC", Offset = "0x925DFC", VA = "0x925DFC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x925758", Offset = "0x925758", VA = "0x925758")]
		[DebuggerHidden]
		public <refreshLoadingStatus>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x925CFC", Offset = "0x925CFC", VA = "0x925CFC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x925D00", Offset = "0x925D00", VA = "0x925D00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x925DBC", Offset = "0x925DBC", VA = "0x925DBC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RecyclableScrollRect recyclableScrollRect;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<ContentInfo> _items;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int _type;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int _currentPage;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int _totalPage;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool isLoading;

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x925598", Offset = "0x925598", VA = "0x925598")]
	private void Awake()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x9255C4", Offset = "0x9255C4", VA = "0x9255C4")]
	public void InitData(int type)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x9255DC", Offset = "0x9255DC", VA = "0x9255DC")]
	private void LoadingContent()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x9256E4", Offset = "0x9256E4", VA = "0x9256E4")]
	[IteratorStateMachine(typeof(<refreshLoadingStatus>d__9))]
	private IEnumerator refreshLoadingStatus()
	{
		return null;
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x925780", Offset = "0x925780", VA = "0x925780", Slot = "4")]
	public int GetItemCount()
	{
		return default(int);
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x9257C8", Offset = "0x9257C8", VA = "0x9257C8", Slot = "5")]
	public void SetCell(ICell cell, int index)
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x925920", Offset = "0x925920", VA = "0x925920")]
	public UserContentLoader()
	{
	}
}
[Token(Token = "0x2000043")]
public class UserController : MonoBehaviour
{
	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text _userName;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ImageLoader imgLoader;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject _menu;

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x9178D4", Offset = "0x9178D4", VA = "0x9178D4")]
	public void Init()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x925E04", Offset = "0x925E04", VA = "0x925E04")]
	public UserController()
	{
	}
}
[Token(Token = "0x2000044")]
public class UserMenuLoader : MonoBehaviour
{
	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Toggle _fav;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Toggle _history;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject _recommend;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject _list;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject _favObj;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Text _favLabel;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private UserContentLoader _contentLoader;

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x925E0C", Offset = "0x925E0C", VA = "0x925E0C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x925F10", Offset = "0x925F10", VA = "0x925F10")]
	public UserMenuLoader()
	{
	}
}
[Token(Token = "0x2000045")]
public class Utils
{
	[Token(Token = "0x6000150")]
	[Address(RVA = "0x917EC8", Offset = "0x917EC8", VA = "0x917EC8")]
	public static string FormatTime(int s)
	{
		return null;
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x916E18", Offset = "0x916E18", VA = "0x916E18")]
	public static string GetNonceStr(int length)
	{
		return null;
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x9260AC", Offset = "0x9260AC", VA = "0x9260AC")]
	public Utils()
	{
	}
}
[Token(Token = "0x2000046")]
public class VideoHandler : MonoBehaviour, ISwitchController
{
	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform _sphereTransform;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private InputActionReference _leftHandSelectRef;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private InputActionReference _leftHandRotateRef;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private InputActionReference _leftScroll;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private InputActionReference _rightHandSelectRef;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private InputActionReference _rightHandRotateRef;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private InputActionReference _rightScroll;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float _moveRate;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private bool _isActive;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	private bool _reset;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3 _lastRotation;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int clickedTimes;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private InputActionReference _handSelectRef;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private InputActionReference _handRotateRef;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private InputActionReference _scroll;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private string _key;

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x9260B4", Offset = "0x9260B4", VA = "0x9260B4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x926120", Offset = "0x926120", VA = "0x926120")]
	private void ResetController()
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x9261D4", Offset = "0x9261D4", VA = "0x9261D4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x92633C", Offset = "0x92633C", VA = "0x92633C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x9264A8", Offset = "0x9264A8", VA = "0x9264A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x92660C", Offset = "0x92660C", VA = "0x92660C")]
	private void ResetAll()
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x926668", Offset = "0x926668", VA = "0x926668")]
	private void OnHold(InputAction.CallbackContext context)
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x9266A0", Offset = "0x9266A0", VA = "0x9266A0")]
	private void OnRelease(InputAction.CallbackContext context)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x92671C", Offset = "0x92671C", VA = "0x92671C")]
	private void ClearDouble()
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x926724", Offset = "0x926724", VA = "0x926724")]
	private void OnRotateChange(InputAction.CallbackContext context)
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x9268B4", Offset = "0x9268B4", VA = "0x9268B4")]
	private void OnBecameInvisible()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x9268BC", Offset = "0x9268BC", VA = "0x9268BC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x926914", Offset = "0x926914", VA = "0x926914", Slot = "4")]
	public void UpdateController()
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x926B70", Offset = "0x926B70", VA = "0x926B70")]
	public VideoHandler()
	{
	}
}
namespace PolyAndCode.UI;

[Token(Token = "0x2000047")]
public interface ICell
{
}
[Token(Token = "0x2000048")]
public interface IRecyclableScrollRectDataSource
{
	[Token(Token = "0x6000161")]
	int GetItemCount();

	[Token(Token = "0x6000162")]
	void SetCell(ICell cell, int index);
}
[Token(Token = "0x2000049")]
public class RecyclableScrollRect : ScrollRect
{
	[Token(Token = "0x200004A")]
	public enum DirectionType
	{
		[Token(Token = "0x4000169")]
		Vertical,
		[Token(Token = "0x400016A")]
		Horizontal
	}

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	[HideInInspector]
	public IRecyclableScrollRectDataSource DataSource;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public bool IsGrid;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public RectTransform PrototypeCell;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public bool SelfInitialize;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	public DirectionType Direction;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	[SerializeField]
	private int _segments;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private RecyclingSystem _recyclingSystem;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private Vector2 _prevAnchoredPos;

	[Token(Token = "0x1700001C")]
	public int Segments
	{
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x926BF8", Offset = "0x926BF8", VA = "0x926BF8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x926B88", Offset = "0x926B88", VA = "0x926B88")]
		set
		{
		}
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x926C00", Offset = "0x926C00", VA = "0x926C00", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x926C30", Offset = "0x926C30", VA = "0x926C30")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x91C274", Offset = "0x91C274", VA = "0x91C274")]
	public void Initialize(IRecyclableScrollRectDataSource dataSource)
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x927104", Offset = "0x927104", VA = "0x927104")]
	public void OnValueChangedListener(Vector2 normalizedPos)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x91C294", Offset = "0x91C294", VA = "0x91C294")]
	public void ReloadData()
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x91CBB0", Offset = "0x91CBB0", VA = "0x91CBB0")]
	public void ReloadData(IRecyclableScrollRectDataSource dataSource, bool keepPosition = false)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x92717C", Offset = "0x92717C", VA = "0x92717C")]
	public RecyclableScrollRect()
	{
	}
}
[Token(Token = "0x200004B")]
public class HorizontalRecyclingSystem : RecyclingSystem
{
	[Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class <InitCoroutine>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HorizontalRecyclingSystem <>4__this;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action onInitialized;

		[Token(Token = "0x1700001D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x928D30", Offset = "0x928D30", VA = "0x928D30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x928D78", Offset = "0x928D78", VA = "0x928D78", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x92737C", Offset = "0x92737C", VA = "0x92737C")]
		[DebuggerHidden]
		public <InitCoroutine>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x928B5C", Offset = "0x928B5C", VA = "0x928B5C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x928B60", Offset = "0x928B60", VA = "0x928B60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x928D38", Offset = "0x928D38", VA = "0x928D38", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly int _rows;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float _cellWidth;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float _cellHeight;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<RectTransform> _cellPool;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<ICell> _cachedCells;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Bounds _recyclableViewBounds;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly Vector3[] _corners;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool _recycling;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private int currentItemCount;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int leftMostCellIndex;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private int rightMostCellIndex;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int _leftMostCellRow;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private int _RightMostCellRow;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Vector2 zeroVector;

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x926FB8", Offset = "0x926FB8", VA = "0x926FB8")]
	public HorizontalRecyclingSystem(RectTransform prototypeCell, RectTransform viewport, RectTransform content, IRecyclableScrollRectDataSource dataSource, bool isGrid, int rows)
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x9272EC", Offset = "0x9272EC", VA = "0x9272EC", Slot = "4")]
	[IteratorStateMachine(typeof(<InitCoroutine>d__15))]
	public override IEnumerator InitCoroutine(Action onInitialized)
	{
		return null;
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x9273A4", Offset = "0x9273A4", VA = "0x9273A4")]
	private void SetRecyclingBounds()
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x927448", Offset = "0x927448", VA = "0x927448")]
	private void CreateCellPool()
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x927D5C", Offset = "0x927D5C", VA = "0x927D5C", Slot = "5")]
	public override Vector2 OnValueChangedListener(Vector2 direction)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x927E64", Offset = "0x927E64", VA = "0x927E64")]
	private Vector2 RecycleLeftToRight()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x928474", Offset = "0x928474", VA = "0x928474")]
	private Vector2 RecycleRightToleft()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x927C70", Offset = "0x927C70", VA = "0x927C70")]
	private void SetLeftAnchor(RectTransform rectTransform)
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x928A5C", Offset = "0x928A5C", VA = "0x928A5C")]
	public void OnDrawGizmos()
	{
	}
}
[Token(Token = "0x2000050")]
public abstract class RecyclingSystem
{
	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public IRecyclableScrollRectDataSource DataSource;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected RectTransform Viewport;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected RectTransform Content;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected RectTransform PrototypeCell;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected bool IsGrid;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	protected float MinPoolCoverage;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected int MinPoolSize;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	protected float RecyclingThreshold;

	[Token(Token = "0x6000184")]
	public abstract IEnumerator InitCoroutine([Optional] Action onInitialized);

	[Token(Token = "0x6000185")]
	public abstract Vector2 OnValueChangedListener(Vector2 direction);

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x9272CC", Offset = "0x9272CC", VA = "0x9272CC")]
	protected RecyclingSystem()
	{
	}
}
[Token(Token = "0x2000051")]
public class VerticalRecyclingSystem : RecyclingSystem
{
	[Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class <InitCoroutine>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VerticalRecyclingSystem <>4__this;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action onInitialized;

		[Token(Token = "0x1700001F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0xE908F4", Offset = "0xE908F4", VA = "0xE908F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0xE9093C", Offset = "0xE9093C", VA = "0xE9093C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xE90728", Offset = "0xE90728", VA = "0xE90728")]
		[DebuggerHidden]
		public <InitCoroutine>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xE90750", Offset = "0xE90750", VA = "0xE90750", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xE90754", Offset = "0xE90754", VA = "0xE90754", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xE908FC", Offset = "0xE908FC", VA = "0xE908FC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly int _coloumns;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float _cellWidth;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float _cellHeight;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<RectTransform> _cellPool;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<ICell> _cachedCells;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Bounds _recyclableViewBounds;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly Vector3[] _corners;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool _recycling;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private int currentItemCount;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int topMostCellIndex;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private int bottomMostCellIndex;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int _topMostCellColoumn;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private int _bottomMostCellColoumn;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Vector2 zeroVector;

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x926E6C", Offset = "0x926E6C", VA = "0x926E6C")]
	public VerticalRecyclingSystem(RectTransform prototypeCell, RectTransform viewport, RectTransform content, IRecyclableScrollRectDataSource dataSource, bool isGrid, int coloumns)
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x929064", Offset = "0x929064", VA = "0x929064", Slot = "4")]
	[IteratorStateMachine(typeof(<InitCoroutine>d__15))]
	public override IEnumerator InitCoroutine(Action onInitialized)
	{
		return null;
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x9290F4", Offset = "0x9290F4", VA = "0x9290F4")]
	private void SetRecyclingBounds()
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x929198", Offset = "0x929198", VA = "0x929198")]
	private void CreateCellPool()
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x929B2C", Offset = "0x929B2C", VA = "0x929B2C", Slot = "5")]
	public override Vector2 OnValueChangedListener(Vector2 direction)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x929C34", Offset = "0x929C34", VA = "0x929C34")]
	private Vector2 RecycleTopToBottom()
	{
		return default(Vector2);
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x92A210", Offset = "0x92A210", VA = "0x92A210")]
	private Vector2 RecycleBottomToTop()
	{
		return default(Vector2);
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x929A58", Offset = "0x929A58", VA = "0x929A58")]
	private void SetTopAnchor(RectTransform rectTransform)
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x929988", Offset = "0x929988", VA = "0x929988")]
	private void SetTopLeftAnchor(RectTransform rectTransform)
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x92A7A4", Offset = "0x92A7A4", VA = "0x92A7A4")]
	public void OnDrawGizmos()
	{
	}
}
