using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using DG.Tweening;
using Eden.SceneManagerSystem;
using EnhancedUI;
using EnhancedUI.EnhancedScroller;
using Firebase;
using Game.UI.Book;
using ICSharpCode.SharpZipLib.Zip;
using Il2CppDummyDll;
using Oculus.Platform;
using Oculus.Platform.Models;
using Pico.Platform;
using Pico.Platform.Models;
using StaticConfig;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using ZYB.Model;
using ZYB.SDK;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class ChatController : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TMP_InputField ChatInputField;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TMP_Text ChatDisplayOutput;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Scrollbar ChatScrollbar;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1683148", Offset = "0x1683148", VA = "0x1683148")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x168320C", Offset = "0x168320C", VA = "0x168320C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x16832D0", Offset = "0x16832D0", VA = "0x16832D0")]
	private void AddToChatOutput(string newText)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x168376C", Offset = "0x168376C", VA = "0x168376C")]
	public ChatController()
	{
	}
}
[Token(Token = "0x2000003")]
public class DropdownSample : MonoBehaviour
{
	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMeshProUGUI text;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TMP_Dropdown dropdownWithoutPlaceholder;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TMP_Dropdown dropdownWithPlaceholder;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x954B48", Offset = "0x954B48", VA = "0x954B48")]
	public void OnButtonClick()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x954C54", Offset = "0x954C54", VA = "0x954C54")]
	public DropdownSample()
	{
	}
}
[Token(Token = "0x2000004")]
public class EnvMapAnimator : MonoBehaviour
{
	[Token(Token = "0x2000005")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674168", Offset = "0x674168")]
	private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EnvMapAnimator <>4__this;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Matrix4x4 <matrix>5__2;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0xC4D054", Offset = "0xC4D054", VA = "0xC4D054", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0xC4D09C", Offset = "0xC4D09C", VA = "0xC4D09C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0xC4CE6C", Offset = "0xC4CE6C", VA = "0xC4CE6C")]
		[DebuggerHidden]
		public <Start>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0xC4CE98", Offset = "0xC4CE98", VA = "0xC4CE98", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0xC4CE9C", Offset = "0xC4CE9C", VA = "0xC4CE9C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0xC4D05C", Offset = "0xC4D05C", VA = "0xC4D05C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 RotationSpeeds;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private TMP_Text m_textMeshPro;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Material m_material;

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x954DC0", Offset = "0x954DC0", VA = "0x954DC0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x954E48", Offset = "0x954E48", VA = "0x954E48")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x674E6C", Offset = "0x674E6C")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x954EC0", Offset = "0x954EC0", VA = "0x954EC0")]
	public EnvMapAnimator()
	{
	}
}
[Token(Token = "0x2000006")]
public enum APPCHANNEL
{
	[Token(Token = "0x400000F")]
	OCULUS_QUEST2 = 1,
	[Token(Token = "0x4000010")]
	PICO_NEO3
}
[Token(Token = "0x2000007")]
public static class AppConfig
{
	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string APP_NAME;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string PACKAGE_NAME;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static string APP_ID;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static string PLATFORM;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static APPCHANNEL CHANNEL;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static string DEVICE_NAME;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static string VERSION_NAME;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static int VERSION_CODE;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static string USER_ID;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static string SIGNATURE;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static bool DEBUG;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public static SystemLanguage LANGUAGE;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static string SERVER_URL;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public static string[] SERVER_URLs;
}
[Token(Token = "0x2000008")]
public class AppEntry : MonoBehaviour
{
	[StructLayout(3)]
	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674178", Offset = "0x674178")]
	private struct <EnterMainScene>d__5 : IAsyncStateMachine
	{
		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xC4AFE0", Offset = "0xC4AFE0", VA = "0xC4AFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xC4B144", Offset = "0xC4B144", VA = "0xC4B144", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AsyncOpRef initOpRef;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AsyncPipeline pipeline;

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1678290", Offset = "0x1678290", VA = "0x1678290")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1678408", Offset = "0x1678408", VA = "0x1678408")]
	private void Start()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1678A0C", Offset = "0x1678A0C", VA = "0x1678A0C")]
	private void OnLoginBack(object Id)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1678A10", Offset = "0x1678A10", VA = "0x1678A10")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x674F1C", Offset = "0x674F1C")]
	public void EnterMainScene()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1678378", Offset = "0x1678378", VA = "0x1678378")]
	private void LoadEventHandle()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1678AC4", Offset = "0x1678AC4", VA = "0x1678AC4")]
	public void OnPlatformBack(object data)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1678C2C", Offset = "0x1678C2C", VA = "0x1678C2C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1678CAC", Offset = "0x1678CAC", VA = "0x1678CAC")]
	public AppEntry()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1678E50", Offset = "0x1678E50", VA = "0x1678E50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674F7C", Offset = "0x674F7C")]
	private void <Start>b__3_0()
	{
	}
}
[Token(Token = "0x200000A")]
public class AppInitOp : AsyncOpBase
{
	[Token(Token = "0x200000B")]
	public class UnZipCallback : ZipWrapper.UnzipCallback
	{
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action callbackAction;

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xC4B158", Offset = "0xC4B158", VA = "0xC4B158", Slot = "6")]
		public override void OnFinished(bool _result)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xC4B24C", Offset = "0xC4B24C", VA = "0xC4B24C")]
		public UnZipCallback()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200000C")]
	private class TempDataConfig
	{
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public _Themes_ themes;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public _Stagess_ stages;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public _StageGroups_ stageGroup;

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xC4B150", Offset = "0xC4B150", VA = "0xC4B150")]
		public TempDataConfig()
		{
		}
	}

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private UIManifest UIManifest;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private SDKPlatform sdkConfig;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private AsyncOpRef themeBundleRef;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int zipCount;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int curZipCount;

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1678F10", Offset = "0x1678F10", VA = "0x1678F10", Slot = "4")]
	public override string Desc()
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x167863C", Offset = "0x167863C", VA = "0x167863C")]
	public static AppInitOp Create()
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1678F70", Offset = "0x1678F70", VA = "0x1678F70", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1678F74", Offset = "0x1678F74", VA = "0x1678F74", Slot = "7")]
	public override bool OnExecute()
	{
		return default(bool);
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1679050", Offset = "0x1679050", VA = "0x1679050", Slot = "5")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1679058", Offset = "0x1679058", VA = "0x1679058")]
	private void RegisterModel()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1679148", Offset = "0x1679148", VA = "0x1679148")]
	private void LoadStaticConfig()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x16797D8", Offset = "0x16797D8", VA = "0x16797D8")]
	private void InitInstance()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1679C14", Offset = "0x1679C14", VA = "0x1679C14")]
	private void UnZipfile(string[] filePathList)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1679DAC", Offset = "0x1679DAC", VA = "0x1679DAC")]
	private void OnZipFinish()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1679E5C", Offset = "0x1679E5C", VA = "0x1679E5C")]
	private void CombinConfig()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x167A2A8", Offset = "0x167A2A8", VA = "0x167A2A8")]
	private void CombinConfigList(string directory, string subPath = "")
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x167A108", Offset = "0x167A108", VA = "0x167A108")]
	private void CombinJson(string jsonStr, string fileName)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1678F54", Offset = "0x1678F54", VA = "0x1678F54")]
	public AppInitOp()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x167A478", Offset = "0x167A478", VA = "0x167A478")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674F9C", Offset = "0x674F9C")]
	private void <OnExecute>b__8_0()
	{
	}
}
[Token(Token = "0x200000D")]
public class AssetBundleTest : MonoBehaviour
{
	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AsyncOpRef asyncOpRef;

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x167AF3C", Offset = "0x167AF3C", VA = "0x167AF3C")]
	private void Start()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x167B010", Offset = "0x167B010", VA = "0x167B010")]
	public void LoadAssetSuccess()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x167B118", Offset = "0x167B118", VA = "0x167B118")]
	private void Update()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x167B11C", Offset = "0x167B11C", VA = "0x167B11C")]
	public AssetBundleTest()
	{
	}
}
[Token(Token = "0x200000E")]
public class Billboard2D : MonoBehaviour
{
	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1680220", Offset = "0x1680220", VA = "0x1680220")]
	private void Update()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x16804A8", Offset = "0x16804A8", VA = "0x16804A8")]
	public Billboard2D()
	{
	}
}
[Token(Token = "0x200000F")]
public class Common3dInteraction : MonoBehaviour
{
	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public XRGrabInteractable obj3d;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float longPressTime;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Action onLongPressBegin;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Action onLongPress;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Action onLongPressEnd;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Action onLongPressCancel;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Action<HoverEnterEventArgs> onHoverEnter;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Action<HoverExitEventArgs> onHoverExit;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool enable;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	private bool isHover;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
	private bool isTrigger;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float startClickT;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool isPress;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool hasBeenTriggeredPress;

	[Token(Token = "0x400003B")]
	private const float triggerValue = 0.7f;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private EventHandel eventHandel;

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1683B78", Offset = "0x1683B78", VA = "0x1683B78", Slot = "4")]
	public virtual void HoverEntered(HoverEnterEventArgs hoverEnterEventArgs)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1683BF0", Offset = "0x1683BF0", VA = "0x1683BF0", Slot = "5")]
	public virtual void HoverExited(HoverExitEventArgs hoverExitEventArgs)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1683C68", Offset = "0x1683C68", VA = "0x1683C68")]
	private void OnTriggerEvent(float value, XRRayInteractor hands, Transform handTrans)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1683C80", Offset = "0x1683C80", VA = "0x1683C80")]
	private void OnTriggerOffEvent()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1683C8C", Offset = "0x1683C8C", VA = "0x1683C8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1684054", Offset = "0x1684054", VA = "0x1684054")]
	private void Update()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x168413C", Offset = "0x168413C", VA = "0x168413C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x16842E8", Offset = "0x16842E8", VA = "0x16842E8")]
	public Common3dInteraction()
	{
	}
}
[Token(Token = "0x2000010")]
public abstract class AsyncOpBase
{
	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67466C", Offset = "0x67466C")]
	private EAsyncOpStatus <Status>k__BackingField;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67467C", Offset = "0x67467C")]
	private object <Result>k__BackingField;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int mRefCount;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected readonly List<AsyncOpRef> mDependencies;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected readonly List<AsyncOpRef> mSubOps;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool mExecuted;

	[Token(Token = "0x17000003")]
	public EAsyncOpStatus Status
	{
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x167B124", Offset = "0x167B124", VA = "0x167B124")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674FAC", Offset = "0x674FAC")]
		get
		{
			return default(EAsyncOpStatus);
		}
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x167B12C", Offset = "0x167B12C", VA = "0x167B12C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674FBC", Offset = "0x674FBC")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000004")]
	internal object Result
	{
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x167B134", Offset = "0x167B134", VA = "0x167B134")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674FCC", Offset = "0x674FCC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x167B13C", Offset = "0x167B13C", VA = "0x167B13C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674FDC", Offset = "0x674FDC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000005")]
	internal IReadOnlyList<AsyncOpRef> Dependencies
	{
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x167B144", Offset = "0x167B144", VA = "0x167B144")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000006")]
	internal bool Done
	{
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x167B14C", Offset = "0x167B14C", VA = "0x167B14C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000007")]
	internal bool Executing
	{
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x167B160", Offset = "0x167B160", VA = "0x167B160")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000008")]
	internal bool Succeeded
	{
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x167B170", Offset = "0x167B170", VA = "0x167B170")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000009")]
	internal bool Failed
	{
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x167B180", Offset = "0x167B180", VA = "0x167B180")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000045")]
	public abstract string Desc();

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x167A02C", Offset = "0x167A02C", VA = "0x167A02C")]
	protected internal void Complete(object result, bool success)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x1678F58", Offset = "0x1678F58", VA = "0x1678F58")]
	public void Init()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x167B190", Offset = "0x167B190", VA = "0x167B190")]
	public void Destroy()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x167B304", Offset = "0x167B304", VA = "0x167B304")]
	public bool AddDependent(AsyncOpBase r)
	{
		return default(bool);
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x167B3A4", Offset = "0x167B3A4", VA = "0x167B3A4")]
	public bool AddSubOp(AsyncOpBase r)
	{
		return default(bool);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x167B450", Offset = "0x167B450", VA = "0x167B450")]
	public object GetSubOpResult(int index)
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x167B4E8", Offset = "0x167B4E8", VA = "0x167B4E8")]
	private bool IsDependenciesDone(out bool success)
	{
		return default(bool);
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x167B60C", Offset = "0x167B60C", VA = "0x167B60C")]
	private bool ExecuteImpl()
	{
		return default(bool);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x167B660", Offset = "0x167B660", VA = "0x167B660")]
	public bool Execute()
	{
		return default(bool);
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x167B698", Offset = "0x167B698", VA = "0x167B698")]
	internal bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x6000050")]
	public abstract void OnInit();

	[Token(Token = "0x6000051")]
	public abstract void OnDestroy();

	[Token(Token = "0x6000052")]
	public abstract bool OnExecute();

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x167B730", Offset = "0x167B730", VA = "0x167B730")]
	public void Acquire()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x167B740", Offset = "0x167B740", VA = "0x167B740")]
	public int Release()
	{
		return default(int);
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x167A3C8", Offset = "0x167A3C8", VA = "0x167A3C8")]
	protected AsyncOpBase()
	{
	}
}
[Token(Token = "0x2000011")]
internal class AsyncOpChannel
{
	[Token(Token = "0x2000012")]
	private struct AsyncOpNode
	{
		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private AsyncOpRef mOpRef;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private Action mOnComplete;

		[Token(Token = "0x1700000A")]
		public bool Valid
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0xC4B30C", Offset = "0xC4B30C", VA = "0xC4B30C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xC4B25C", Offset = "0xC4B25C", VA = "0xC4B25C")]
		public AsyncOpNode(AsyncOpBase op, Action onComplete)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xC4B2B8", Offset = "0xC4B2B8", VA = "0xC4B2B8")]
		public void Complete()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xC4B314", Offset = "0xC4B314", VA = "0xC4B314")]
		public bool Update()
		{
			return default(bool);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xC4B35C", Offset = "0xC4B35C", VA = "0xC4B35C")]
		public void Execute()
		{
		}
	}

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly List<AsyncOpNode> mOps;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int mOpsCount;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private readonly int mIndex;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AsyncOpNode mExecutingOp;

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x167B788", Offset = "0x167B788", VA = "0x167B788")]
	internal AsyncOpChannel(int index)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x167B820", Offset = "0x167B820", VA = "0x167B820")]
	internal void PushOp(AsyncOpBase r, Action onComplete)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x167B8C0", Offset = "0x167B8C0", VA = "0x167B8C0")]
	private void ExecuteNext()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x167B988", Offset = "0x167B988", VA = "0x167B988")]
	internal void Update()
	{
	}
}
[Token(Token = "0x2000013")]
public class AsyncOpDummy : AsyncOpBase
{
	[Token(Token = "0x600005F")]
	[Address(RVA = "0x167B9FC", Offset = "0x167B9FC", VA = "0x167B9FC")]
	public static AsyncOpDummy Create()
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x167BA78", Offset = "0x167BA78", VA = "0x167BA78", Slot = "4")]
	public override string Desc()
	{
		return null;
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x167BABC", Offset = "0x167BABC", VA = "0x167BABC", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x167BAC0", Offset = "0x167BAC0", VA = "0x167BAC0", Slot = "7")]
	public override bool OnExecute()
	{
		return default(bool);
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x167BAE0", Offset = "0x167BAE0", VA = "0x167BAE0", Slot = "5")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x167BA74", Offset = "0x167BA74", VA = "0x167BA74")]
	public AsyncOpDummy()
	{
	}
}
[Token(Token = "0x2000014")]
public struct AsyncOpRef
{
	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67468C", Offset = "0x67468C")]
	private AsyncOpBase <Op>k__BackingField;

	[Token(Token = "0x1700000B")]
	internal AsyncOpBase Op
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x167BAE4", Offset = "0x167BAE4", VA = "0x167BAE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674FEC", Offset = "0x674FEC")]
		readonly get
		{
			return null;
		}
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x167BAEC", Offset = "0x167BAEC", VA = "0x167BAEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675024", Offset = "0x675024")]
		private set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public bool Valid
	{
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x167BAF4", Offset = "0x167BAF4", VA = "0x167BAF4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000D")]
	public object Result
	{
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x167A0F0", Offset = "0x167A0F0", VA = "0x167A0F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000E")]
	public bool Done
	{
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x167B5C8", Offset = "0x167B5C8", VA = "0x167B5C8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000F")]
	public bool Executing
	{
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x167BB14", Offset = "0x167BB14", VA = "0x167BB14")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000010")]
	public bool Succeeded
	{
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x167B5EC", Offset = "0x167B5EC", VA = "0x167B5EC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000011")]
	public bool Failed
	{
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x167BB34", Offset = "0x167BB34", VA = "0x167BB34")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x16786B4", Offset = "0x16786B4", VA = "0x16786B4")]
	internal AsyncOpRef(AsyncOpBase op)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x1678ED0", Offset = "0x1678ED0", VA = "0x1678ED0")]
	public int Release()
	{
		return default(int);
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x167BB04", Offset = "0x167BB04", VA = "0x167BB04")]
	public object GetSubResult(int index)
	{
		return null;
	}
}
[Token(Token = "0x2000015")]
public enum EAsyncOpStatus
{
	[Token(Token = "0x400004B")]
	None,
	[Token(Token = "0x400004C")]
	Executing,
	[Token(Token = "0x400004D")]
	Succeeded,
	[Token(Token = "0x400004E")]
	Failed
}
[Token(Token = "0x2000016")]
public class AsyncPipeline
{
	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private int mCurChannelIndex;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly AsyncOpChannel[] mChannels;

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x1678D1C", Offset = "0x1678D1C", VA = "0x1678D1C")]
	public AsyncPipeline(int seqCount)
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x16786EC", Offset = "0x16786EC", VA = "0x16786EC")]
	public void PushOp(AsyncOpBase r, [Optional] Action onComplete)
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x1678C44", Offset = "0x1678C44", VA = "0x1678C44")]
	public void Update()
	{
	}
}
[Token(Token = "0x2000017")]
public class Audio
{
	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int Id;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject mGameObject;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform mTransform;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioSource mAudioSource;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioClip mAudioClip;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private AsyncOpRef mRefAudioClip;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool mPlaying;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private bool mLoop;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float mVolume;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float mDuration;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float mElapsedTime;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool mLoading;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string resName;

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x167C430", Offset = "0x167C430", VA = "0x167C430")]
	public void Init(int id, string resName, Transform parent, bool is3DSound = false)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x167C6A4", Offset = "0x167C6A4", VA = "0x167C6A4")]
	public void Init(int id, string resName, Transform parent, Vector3 pos, bool is3DSound = false)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x167C700", Offset = "0x167C700", VA = "0x167C700")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x167C878", Offset = "0x167C878", VA = "0x167C878")]
	private void OnLoadAudioClipComplete()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x167CA00", Offset = "0x167CA00", VA = "0x167CA00")]
	public void Play(bool loop = false)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x167C7E4", Offset = "0x167C7E4", VA = "0x167C7E4")]
	public void Stop()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x167C9A4", Offset = "0x167C9A4", VA = "0x167C9A4")]
	private void PlayInternal()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x167CAA4", Offset = "0x167CAA4", VA = "0x167CAA4")]
	public void SetVolume(float volume)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x167CB4C", Offset = "0x167CB4C", VA = "0x167CB4C")]
	public bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x167CC48", Offset = "0x167CC48", VA = "0x167CC48")]
	public Audio()
	{
	}
}
[Token(Token = "0x2000018")]
public static class AudioManager
{
	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int mNextSoundId;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static GameObject mGameObject;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Transform mTransform;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly Dictionary<int, Audio> mSounds;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static Audio mMusic;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static readonly HashSet<int> mRemveSoundIds;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static bool mEnableMusic;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private static bool mEnableSound;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private static float mMusicVolume;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static float mSoundVolume;

	[Token(Token = "0x17000012")]
	public static bool EnableMusic
	{
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x167E410", Offset = "0x167E410", VA = "0x167E410")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x167E474", Offset = "0x167E474", VA = "0x167E474")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public static bool EnableSound
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x167E5C8", Offset = "0x167E5C8", VA = "0x167E5C8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x167E62C", Offset = "0x167E62C", VA = "0x167E62C")]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public static float MusicVolume
	{
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x167E844", Offset = "0x167E844", VA = "0x167E844")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x167E8A8", Offset = "0x167E8A8", VA = "0x167E8A8")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public static float SoundVolume
	{
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x167E960", Offset = "0x167E960", VA = "0x167E960")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x167E9C4", Offset = "0x167E9C4", VA = "0x167E9C4")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	private static float FinalMusicVolume
	{
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x167D7F8", Offset = "0x167D7F8", VA = "0x167D7F8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000017")]
	private static float FinalSoundVolume
	{
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x167DADC", Offset = "0x167DADC", VA = "0x167DADC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x1679A2C", Offset = "0x1679A2C", VA = "0x1679A2C")]
	public static void Init()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x167CC50", Offset = "0x167CC50", VA = "0x167CC50")]
	public static void ClearAudio()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x167D26C", Offset = "0x167D26C", VA = "0x167D26C")]
	public static void Destroy()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x167D620", Offset = "0x167D620", VA = "0x167D620")]
	public static void PlayMusic(string resName)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x167D888", Offset = "0x167D888", VA = "0x167D888")]
	public static void StopMusic()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x167D93C", Offset = "0x167D93C", VA = "0x167D93C")]
	public static int PlaySound2D(string resName)
	{
		return default(int);
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x167DCD0", Offset = "0x167DCD0", VA = "0x167DCD0")]
	public static int PlaySound3D(string resName, Transform localTransfrm)
	{
		return default(int);
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x167DE68", Offset = "0x167DE68", VA = "0x167DE68")]
	public static void StopSound(int id)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x167DEF4", Offset = "0x167DEF4", VA = "0x167DEF4")]
	private static Audio FindSound(int id, bool logError = true)
	{
		return null;
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x167DFA0", Offset = "0x167DFA0", VA = "0x167DFA0")]
	private static void ReleaseSound(int id)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x167E0A4", Offset = "0x167E0A4", VA = "0x167E0A4")]
	private static void Update()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x167E520", Offset = "0x167E520", VA = "0x167E520")]
	private static void ApplyMusicVolume()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x167E6D8", Offset = "0x167E6D8", VA = "0x167E6D8")]
	private static void ApplySoundVolume()
	{
	}
}
[Token(Token = "0x2000019")]
public static class AudioPool
{
	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<string, List<Audio>> mPools;

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x167DB6C", Offset = "0x167DB6C", VA = "0x167DB6C")]
	public static Audio Requre(string resName, int Id, Transform parent, float volume)
	{
		return null;
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x167CEAC", Offset = "0x167CEAC", VA = "0x167CEAC")]
	public static void Release(Audio audio)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x167D02C", Offset = "0x167D02C", VA = "0x167D02C")]
	public static void ReleaseAll()
	{
	}
}
[Token(Token = "0x200001A")]
public class LanguageSprite : MonoBehaviour
{
	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int languageKey;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal SpriteSetter m_spriteSetter;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool autoScale;

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x95D770", Offset = "0x95D770", VA = "0x95D770")]
	private void Start()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x95D78C", Offset = "0x95D78C", VA = "0x95D78C", Slot = "4")]
	public virtual void SetSprite(int key)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x95D9FC", Offset = "0x95D9FC", VA = "0x95D9FC")]
	public LanguageSprite()
	{
	}
}
[Token(Token = "0x200001B")]
public class LanguageText : MonoBehaviour
{
	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TextMeshProUGUI m_textMeshPro;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int languageKey;

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x95DA0C", Offset = "0x95DA0C", VA = "0x95DA0C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x95DA68", Offset = "0x95DA68", VA = "0x95DA68")]
	public void Start()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x95DA70", Offset = "0x95DA70", VA = "0x95DA70")]
	public void SetFont(int key)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x95DB40", Offset = "0x95DB40", VA = "0x95DB40")]
	private void SetFontStyle(int key)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x95DFCC", Offset = "0x95DFCC", VA = "0x95DFCC")]
	private void SetStyle(string styleKey)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x95E240", Offset = "0x95E240", VA = "0x95E240")]
	private bool FormatPares(string value, out float outValue)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x95E2C4", Offset = "0x95E2C4", VA = "0x95E2C4")]
	public LanguageText()
	{
	}
}
[Token(Token = "0x200001C")]
public class MultiImage : MonoBehaviour
{
	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string spriteName;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Image m_Image;

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x961D6C", Offset = "0x961D6C", VA = "0x961D6C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x96203C", Offset = "0x96203C", VA = "0x96203C")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x962040", Offset = "0x962040", VA = "0x962040")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x961D70", Offset = "0x961D70", VA = "0x961D70")]
	public void RefreshSprite()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x962044", Offset = "0x962044", VA = "0x962044")]
	public Sprite LoadSourceSprite(string relativePath)
	{
		return null;
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x962170", Offset = "0x962170", VA = "0x962170")]
	public MultiImage()
	{
	}
}
[Token(Token = "0x200001D")]
public class ParticleSystemCmpt : MonoBehaviour
{
	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x962F5C", Offset = "0x962F5C", VA = "0x962F5C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x9630B8", Offset = "0x9630B8", VA = "0x9630B8")]
	private void OnParticleSystemStopped()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x96312C", Offset = "0x96312C", VA = "0x96312C")]
	public ParticleSystemCmpt()
	{
	}
}
[Token(Token = "0x200001E")]
public class PicoLanguageSprite : LanguageSprite
{
	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x963134", Offset = "0x963134", VA = "0x963134", Slot = "4")]
	public override void SetSprite(int key)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x963468", Offset = "0x963468", VA = "0x963468")]
	public PicoLanguageSprite()
	{
	}
}
[Token(Token = "0x200001F")]
public class RendererSetter : MonoBehaviour
{
	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string mSpriteName;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string mParmName;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AsyncOpRef mResRef;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Material mMat;

	[Token(Token = "0x17000018")]
	public Material material
	{
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x96899C", Offset = "0x96899C", VA = "0x96899C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x968A60", Offset = "0x968A60", VA = "0x968A60")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x968A6C", Offset = "0x968A6C", VA = "0x968A6C")]
	private void OnResLoadComplete()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x968AF4", Offset = "0x968AF4", VA = "0x968AF4")]
	public void SetTexture(string imageName, string parmName)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x968B70", Offset = "0x968B70", VA = "0x968B70")]
	private void LoadImage()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x968C58", Offset = "0x968C58", VA = "0x968C58")]
	public RendererSetter()
	{
	}
}
[Token(Token = "0x2000020")]
public class SpriteSetter : MonoBehaviour
{
	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string mSpriteName;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AsyncOpRef mResRef;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Image mImage;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool autoScale;

	[Token(Token = "0x17000019")]
	public Image SpriteRenderer
	{
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x93F264", Offset = "0x93F264", VA = "0x93F264")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x93F318", Offset = "0x93F318", VA = "0x93F318")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x93F324", Offset = "0x93F324", VA = "0x93F324")]
	private void OnResLoadComplete()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x93F578", Offset = "0x93F578", VA = "0x93F578")]
	public void SetSprite(string imageName)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x93F5E0", Offset = "0x93F5E0", VA = "0x93F5E0")]
	private void LoadImage()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x93F6D8", Offset = "0x93F6D8", VA = "0x93F6D8")]
	public SpriteSetter()
	{
	}
}
[Token(Token = "0x2000021")]
public class EventHandel : MonoBehaviour
{
	[Token(Token = "0x2000022")]
	public delegate void TriggerEvent(float value, XRRayInteractor hands, Transform handTrans);

	[Token(Token = "0x2000023")]
	public delegate void OnHoverEnteredEvent(Transform interactor, Transform hands);

	[Token(Token = "0x2000024")]
	public delegate void OnHoverExitedEvent(Transform interactor, Transform hands);

	[Token(Token = "0x2000025")]
	public delegate void OnSelectEnterEvent(Transform interactor, Transform hands);

	[Token(Token = "0x2000026")]
	public delegate void OnSelectExitEvent(Transform interactor, Transform hands);

	[Token(Token = "0x2000027")]
	public delegate void OnPrimary2D(Vector2 value, Transform hands);

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TriggerEvent onTriggerEvent;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Action onTriggerOffEvent;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TriggerEvent onTriggerPressEvent;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Action onTriggerClickEvent;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public OnHoverEnteredEvent onHoverEnteredEvent;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public OnHoverEnteredEvent onHoverExitedEvent;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public OnSelectEnterEvent onSelectEnterEvent;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public OnSelectEnterEvent onSelectExitEvent;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public OnPrimary2D onPrimary2D;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public OnPrimary2D onPrimary2DPress;

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x954EC8", Offset = "0x954EC8", VA = "0x954EC8")]
	public void Awake()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x954F2C", Offset = "0x954F2C", VA = "0x954F2C")]
	public void OnHoverEntered(HoverEnterEventArgs hoverEnterEvent)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x9550B4", Offset = "0x9550B4", VA = "0x9550B4")]
	public void OnHoverExited(HoverExitEventArgs hoverExitEvent)
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x95523C", Offset = "0x95523C", VA = "0x95523C")]
	public void OnSelectEnter(SelectEnterEventArgs selectEnterEvent)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x9553C4", Offset = "0x9553C4", VA = "0x9553C4")]
	public void OnSeleceExited(SelectExitEventArgs selectExitEvent)
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x95554C", Offset = "0x95554C", VA = "0x95554C")]
	public void OnTrigger(float valus, XRRayInteractor xRRay, Transform handTrans)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x955560", Offset = "0x955560", VA = "0x955560")]
	public void OnTriggerClick()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x955574", Offset = "0x955574", VA = "0x955574")]
	public void OnTriggerOff()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x955588", Offset = "0x955588", VA = "0x955588")]
	public void OnPrimary2DAxis(Vector2 valus, Transform handTrans)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x95559C", Offset = "0x95559C", VA = "0x95559C")]
	public EventHandel()
	{
	}
}
[Token(Token = "0x2000028")]
public class EventManager
{
	[Token(Token = "0x2000029")]
	private class ActionItem
	{
		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<object, Action<object>> actionList;

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xC4E670", Offset = "0xC4E670", VA = "0xC4E670")]
		public ActionItem()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xC4E6F4", Offset = "0xC4E6F4", VA = "0xC4E6F4")]
		public void Add(Action<object> callback, object target)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xC4E86C", Offset = "0xC4E86C", VA = "0xC4E86C")]
		public void Clear()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xC4E8C0", Offset = "0xC4E8C0", VA = "0xC4E8C0")]
		public void Send(object parm)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xC4EA10", Offset = "0xC4EA10", VA = "0xC4EA10")]
		public bool Remove(object target)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static EventManager _instance;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Dictionary<string, ActionItem> _globalEventMap;

	[Token(Token = "0x1700001A")]
	public static EventManager Instance
	{
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x9557C8", Offset = "0x9557C8", VA = "0x9557C8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x95588C", Offset = "0x95588C", VA = "0x95588C")]
	public EventManager()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x955910", Offset = "0x955910", VA = "0x955910")]
	public void AddEvent(string eventKey, Action<object> callback, object target)
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x955A40", Offset = "0x955A40", VA = "0x955A40")]
	public void RemoveEvent(string eventKey, object target)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x955B0C", Offset = "0x955B0C", VA = "0x955B0C")]
	public void SendEvent(string eventKey, [Optional] object parm)
	{
	}
}
[Token(Token = "0x200002A")]
public class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static T instance;

	[Token(Token = "0x1700001B")]
	public static T Instance
	{
		[Token(Token = "0x60000E7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000E8")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x60000E9")]
	public MonoSingleton()
	{
	}
}
[Token(Token = "0x200002B")]
public class Singleton<T> where T : class, new()
{
	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static T instance;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly object lockObj;

	[Token(Token = "0x1700001C")]
	public static T Instance
	{
		[Token(Token = "0x60000EA")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000EB")]
	public Singleton()
	{
	}
}
[Token(Token = "0x200002C")]
public class PrefabInstance
{
	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string ID;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly PrefabPoolNode pool;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67469C", Offset = "0x67469C")]
	private GameObject <GameObject>k__BackingField;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6746AC", Offset = "0x6746AC")]
	private Transform <Transform>k__BackingField;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform parentTransform;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3 localPosition;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Quaternion localRotation;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private bool active;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Action<object> onLoadComplete;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private object extraParm;

	[Token(Token = "0x1700001D")]
	public GameObject GameObject
	{
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x965590", Offset = "0x965590", VA = "0x965590")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675034", Offset = "0x675034")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x965598", Offset = "0x965598", VA = "0x965598")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675044", Offset = "0x675044")]
		private set
		{
		}
	}

	[Token(Token = "0x1700001E")]
	public Transform Transform
	{
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x9655A0", Offset = "0x9655A0", VA = "0x9655A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675054", Offset = "0x675054")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x9655A8", Offset = "0x9655A8", VA = "0x9655A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675064", Offset = "0x675064")]
		private set
		{
		}
	}

	[Token(Token = "0x1700001F")]
	public bool Valid
	{
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x9655B0", Offset = "0x9655B0", VA = "0x9655B0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x96561C", Offset = "0x96561C", VA = "0x96561C")]
	internal PrefabInstance(PrefabPoolNode pool)
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x965674", Offset = "0x965674", VA = "0x965674")]
	public void Init(GameObject prefab)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x9658AC", Offset = "0x9658AC", VA = "0x9658AC")]
	public void Destroy()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x965818", Offset = "0x965818", VA = "0x965818")]
	private void ActiveImpl()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x965978", Offset = "0x965978", VA = "0x965978")]
	internal void InternalAcquire(Action<object> onLoadComplete, [Optional] object extraParm)
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x9659C4", Offset = "0x9659C4", VA = "0x9659C4")]
	private void InternalRelease()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x965A00", Offset = "0x965A00", VA = "0x965A00")]
	public void Release()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x965B48", Offset = "0x965B48", VA = "0x965B48")]
	public void SetParent(Transform transform)
	{
	}
}
[Token(Token = "0x200002D")]
public static class PrefabPool
{
	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Transform poolNodeTrans;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Dictionary<string, PrefabPoolNode> Nodes;

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x965C18", Offset = "0x965C18", VA = "0x965C18")]
	public static void Init()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x965D80", Offset = "0x965D80", VA = "0x965D80")]
	public static void Destroy()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x966130", Offset = "0x966130", VA = "0x966130")]
	public static PrefabInstance CreateInstance(string prefabName, Action<object> onLoadComplete, [Optional] object extraParm)
	{
		return null;
	}
}
[Token(Token = "0x200002E")]
public class PrefabPoolNode
{
	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string PrefabName;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AsyncOpRef mResRef;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform mPoolNode;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly List<PrefabInstance> mIdleInstances;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly HashSet<PrefabInstance> mActiveInstances;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly HashSet<PrefabInstance> mWaitInitInstances;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly List<PrefabInstance> mTempWaitInitInstances;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool mHasWaitInitInstance;

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x9663B0", Offset = "0x9663B0", VA = "0x9663B0")]
	internal void Init(string prefabName, Transform pooNode)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x965F1C", Offset = "0x965F1C", VA = "0x965F1C")]
	internal void Destroy()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x966810", Offset = "0x966810", VA = "0x966810")]
	private void Update()
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x966B34", Offset = "0x966B34", VA = "0x966B34")]
	private void OnLoadComplete()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x9665AC", Offset = "0x9665AC", VA = "0x9665AC")]
	internal PrefabInstance CreateInstance(Action<object> onLoadComplete, [Optional] object extraParm)
	{
		return null;
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x965A34", Offset = "0x965A34", VA = "0x965A34")]
	internal void InternalFree(PrefabInstance inst)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x966288", Offset = "0x966288", VA = "0x966288")]
	public PrefabPoolNode()
	{
	}
}
[Token(Token = "0x200002F")]
public class AssetBundleAssetOp : ResAsyncOp
{
	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string resPath;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6746BC", Offset = "0x6746BC")]
	private UnityEngine.Object <asset>k__BackingField;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private AssetBundleRequest requestOperation;

	[Token(Token = "0x17000020")]
	public UnityEngine.Object asset
	{
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x167A688", Offset = "0x167A688", VA = "0x167A688")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675074", Offset = "0x675074")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x167A690", Offset = "0x167A690", VA = "0x167A690")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675084", Offset = "0x675084")]
		private set
		{
		}
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x167A680", Offset = "0x167A680", VA = "0x167A680", Slot = "4")]
	public override string Desc()
	{
		return null;
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x167A698", Offset = "0x167A698", VA = "0x167A698")]
	public static AssetBundleAssetOp Create(string pathId)
	{
		return null;
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x167A740", Offset = "0x167A740", VA = "0x167A740")]
	public void SetResPath(string path)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x167A748", Offset = "0x167A748", VA = "0x167A748", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x167A7F0", Offset = "0x167A7F0", VA = "0x167A7F0", Slot = "7")]
	public override bool OnExecute()
	{
		return default(bool);
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x167AAC4", Offset = "0x167AAC4", VA = "0x167AAC4", Slot = "5")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x167AACC", Offset = "0x167AACC", VA = "0x167AACC")]
	public void LocalRequestOperationCompleted(AsyncOperation operation)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x167A738", Offset = "0x167A738", VA = "0x167A738")]
	public AssetBundleAssetOp()
	{
	}
}
[Token(Token = "0x2000030")]
public class AssetBundleOp : ResAsyncOp
{
	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string resPath;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6746CC", Offset = "0x6746CC")]
	private AssetBundle <assetBundle>k__BackingField;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private AssetBundleCreateRequest requestOperation;

	[Token(Token = "0x17000021")]
	public AssetBundle assetBundle
	{
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x167AB78", Offset = "0x167AB78", VA = "0x167AB78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675094", Offset = "0x675094")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x167AB80", Offset = "0x167AB80", VA = "0x167AB80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6750A4", Offset = "0x6750A4")]
		private set
		{
		}
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x167AB70", Offset = "0x167AB70", VA = "0x167AB70", Slot = "4")]
	public override string Desc()
	{
		return null;
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x167AB88", Offset = "0x167AB88", VA = "0x167AB88")]
	public static AssetBundleOp Create(string pathId)
	{
		return null;
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x167AC30", Offset = "0x167AC30", VA = "0x167AC30")]
	public void SetResPaht(string resPath)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x167AC64", Offset = "0x167AC64", VA = "0x167AC64", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x167AD9C", Offset = "0x167AD9C", VA = "0x167AD9C", Slot = "7")]
	public override bool OnExecute()
	{
		return default(bool);
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x167AEE4", Offset = "0x167AEE4", VA = "0x167AEE4")]
	private void LocalRequestOperationCompleted(AsyncOperation async)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x167AF34", Offset = "0x167AF34", VA = "0x167AF34", Slot = "5")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x167AC28", Offset = "0x167AC28", VA = "0x167AC28")]
	public AssetBundleOp()
	{
	}
}
[Token(Token = "0x2000031")]
public abstract class ResAsyncOp : AsyncOpBase
{
	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string Id;

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x968C60", Offset = "0x968C60", VA = "0x968C60", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x968DB4", Offset = "0x968DB4", VA = "0x968DB4", Slot = "5")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x969018", Offset = "0x969018", VA = "0x969018")]
	protected ResAsyncOp()
	{
	}
}
[Token(Token = "0x2000032")]
public enum ResType
{
	[Token(Token = "0x40000A4")]
	None = -1,
	[Token(Token = "0x40000A5")]
	Scene,
	[Token(Token = "0x40000A6")]
	Prefab,
	[Token(Token = "0x40000A7")]
	Shader,
	[Token(Token = "0x40000A8")]
	Model,
	[Token(Token = "0x40000A9")]
	Mesh,
	[Token(Token = "0x40000AA")]
	Material,
	[Token(Token = "0x40000AB")]
	Texture,
	[Token(Token = "0x40000AC")]
	Sprite,
	[Token(Token = "0x40000AD")]
	AudioClip,
	[Token(Token = "0x40000AE")]
	AnimationClip,
	[Token(Token = "0x40000AF")]
	AnimatorController,
	[Token(Token = "0x40000B0")]
	Font,
	[Token(Token = "0x40000B1")]
	TextAsset,
	[Token(Token = "0x40000B2")]
	Num
}
[Token(Token = "0x2000033")]
public class ResDefine
{
	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string ResRootPath;

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x969020", Offset = "0x969020", VA = "0x969020")]
	public ResDefine()
	{
	}
}
[Token(Token = "0x2000034")]
public struct LoadResArgs
{
	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6746DC", Offset = "0x6746DC")]
	private ResType <resType>k__BackingField;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6746EC", Offset = "0x6746EC")]
	private string <resPath>k__BackingField;

	[Token(Token = "0x17000022")]
	public ResType resType
	{
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x95FE38", Offset = "0x95FE38", VA = "0x95FE38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6750B4", Offset = "0x6750B4")]
		readonly get
		{
			return default(ResType);
		}
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x95FE40", Offset = "0x95FE40", VA = "0x95FE40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6750EC", Offset = "0x6750EC")]
		set
		{
		}
	}

	[Token(Token = "0x17000023")]
	public string resPath
	{
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x95FE48", Offset = "0x95FE48", VA = "0x95FE48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6750FC", Offset = "0x6750FC")]
		readonly get
		{
			return null;
		}
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x95FE50", Offset = "0x95FE50", VA = "0x95FE50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675134", Offset = "0x675134")]
		set
		{
		}
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x95FE58", Offset = "0x95FE58", VA = "0x95FE58")]
	public LoadResArgs(string resPath, ResType resType)
	{
	}
}
[Token(Token = "0x2000035")]
public class ResHelper : MonoBehaviour
{
	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string[] resTypeName;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Type[] resTypeAssetType;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static string[] resTypeFilterName;

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x96908C", Offset = "0x96908C", VA = "0x96908C")]
	public static string GetResTypeName(ResType t)
	{
		return null;
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x96972C", Offset = "0x96972C", VA = "0x96972C")]
	public static Type GetAssetTypeByResType(ResType t)
	{
		return null;
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x969D40", Offset = "0x969D40", VA = "0x969D40")]
	public static string GetResTypeFilterName(ResType t)
	{
		return null;
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x96A304", Offset = "0x96A304", VA = "0x96A304")]
	public static string GetResName(string assetName, ResType t)
	{
		return null;
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x96A390", Offset = "0x96A390", VA = "0x96A390")]
	public static string GetResPath(string resName, bool isDlc)
	{
		return null;
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x96A5CC", Offset = "0x96A5CC", VA = "0x96A5CC")]
	public static string SpliceResName(string resName)
	{
		return null;
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x96A62C", Offset = "0x96A62C", VA = "0x96A62C")]
	public static bool ExitObbResManifest(string manifestPath)
	{
		return default(bool);
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x96A568", Offset = "0x96A568", VA = "0x96A568")]
	public static string StreamingAssetsPath()
	{
		return null;
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x96A410", Offset = "0x96A410", VA = "0x96A410")]
	public static string PersistentDataPath()
	{
		return null;
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x96A6E0", Offset = "0x96A6E0", VA = "0x96A6E0")]
	public static string GetRegularPath(string path)
	{
		return null;
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x96A858", Offset = "0x96A858", VA = "0x96A858")]
	public ResHelper()
	{
	}
}
[Token(Token = "0x2000036")]
public class ResItem
{
	[Token(Token = "0x600012E")]
	[Address(RVA = "0x96A860", Offset = "0x96A860", VA = "0x96A860")]
	public ResItem()
	{
	}
}
[Token(Token = "0x2000037")]
public static class ResManager
{
	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<string, ResAsyncOp> cacheResOps;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Dictionary<string, UnityEngine.Object> m_Resource;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static AsyncPipeline asyncPipeline;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static ResManifest.Item[] items;

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x96A868", Offset = "0x96A868", VA = "0x96A868")]
	public static void Init()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x96AA90", Offset = "0x96AA90", VA = "0x96AA90")]
	public static void CombinManifest(string json)
	{
	}

	[Token(Token = "0x6000131")]
	public static T LoadResource<T>(string resPath) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x96AC34", Offset = "0x96AC34", VA = "0x96AC34")]
	public static void ReleaseResourceAssets()
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x96ACB8", Offset = "0x96ACB8", VA = "0x96ACB8")]
	public static AsyncOpRef LoadAssetList(LoadResArgs[] args, Action onLoadSuccess)
	{
		return default(AsyncOpRef);
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x964338", Offset = "0x964338", VA = "0x964338")]
	public static void Update()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x968E14", Offset = "0x968E14", VA = "0x968E14")]
	public static void AddResToCache(ResAsyncOp op)
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x968CC4", Offset = "0x968CC4", VA = "0x968CC4")]
	public static void RemoveResFromCache(string id)
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x96675C", Offset = "0x96675C", VA = "0x96675C")]
	public static AsyncOpRef LoadAsset(string resPath, ResType resType, Action onLoadSuccess)
	{
		return default(AsyncOpRef);
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x96AEC8", Offset = "0x96AEC8", VA = "0x96AEC8")]
	public static AsyncOpRef LoadAssetBundle(string resPath, string[] dependencies, bool isDlc, Action onLoadSuccess)
	{
		return default(AsyncOpRef);
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x96ADFC", Offset = "0x96ADFC", VA = "0x96ADFC")]
	private static AsyncOpBase CreateAssetOp(string resPath, ResType resType)
	{
		return null;
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x96B248", Offset = "0x96B248", VA = "0x96B248")]
	private static AsyncOpBase CreateAssetEditorOp(string resPath, ResType resType)
	{
		return null;
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x96B164", Offset = "0x96B164", VA = "0x96B164")]
	private static AsyncOpBase CreateAssetFromBundle(string resName)
	{
		return null;
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x96AF94", Offset = "0x96AF94", VA = "0x96AF94")]
	private static AsyncOpBase CreateAssetBundleOp(string bundleName, string[] dependencies, bool isDlc)
	{
		return null;
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x96B3AC", Offset = "0x96B3AC", VA = "0x96B3AC")]
	public static AsyncOpRef LoadScene(string sceneName, Action onLoadSuccess, [Optional] LoadResArgs[] otherAssets)
	{
		return default(AsyncOpRef);
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x96B504", Offset = "0x96B504", VA = "0x96B504")]
	private static AsyncOpBase CreateSceneOp(string sceneName)
	{
		return null;
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x96B250", Offset = "0x96B250", VA = "0x96B250")]
	private static ResManifest.Item GetResInfoByAssetName(string assetName)
	{
		return null;
	}

	[Token(Token = "0x6000140")]
	public static T LoadJsonFromPathSync<T>(string fullPath) where T : class
	{
		return null;
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x96B5F0", Offset = "0x96B5F0", VA = "0x96B5F0")]
	public static string LoadJsonFromPath(string fullPath)
	{
		return null;
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x96B8D8", Offset = "0x96B8D8", VA = "0x96B8D8")]
	public static string LoadTextFromFileSync(string path)
	{
		return null;
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x96B6C4", Offset = "0x96B6C4", VA = "0x96B6C4")]
	public static string LoadTextWithWebRequestSync(string path)
	{
		return null;
	}
}
[Token(Token = "0x2000038")]
public class ResManifest : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000039")]
	public class Item
	{
		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string AssetName;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string AssetBundleName;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool UseDlc;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string[] Dependencies;

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xC51C94", Offset = "0xC51C94", VA = "0xC51C94")]
		public Item()
		{
		}
	}

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Item[] Items;

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x96BA28", Offset = "0x96BA28", VA = "0x96BA28")]
	public ResManifest()
	{
	}
}
[Token(Token = "0x200003A")]
public class SceneOP : ResAsyncOp
{
	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string sceneName;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private AsyncOperation operation;

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x93B444", Offset = "0x93B444", VA = "0x93B444")]
	public static SceneOP Create(string sceneName)
	{
		return null;
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x93B4DC", Offset = "0x93B4DC", VA = "0x93B4DC", Slot = "5")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x93B4E0", Offset = "0x93B4E0", VA = "0x93B4E0", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x93B558", Offset = "0x93B558", VA = "0x93B558", Slot = "7")]
	public override bool OnExecute()
	{
		return default(bool);
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x93B65C", Offset = "0x93B65C", VA = "0x93B65C")]
	private void LoadSceneCompleted(AsyncOperation op)
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x93B694", Offset = "0x93B694", VA = "0x93B694", Slot = "4")]
	public override string Desc()
	{
		return null;
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x93B4D4", Offset = "0x93B4D4", VA = "0x93B4D4")]
	public SceneOP()
	{
	}
}
[Token(Token = "0x200003B")]
public class AnimationEventSound : MonoBehaviour
{
	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip audioClip1;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioClip audioClip2;

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x1677E10", Offset = "0x1677E10", VA = "0x1677E10")]
	public void PlaySound1()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x1677EF0", Offset = "0x1677EF0", VA = "0x1677EF0")]
	public void PlaySound2()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x1677FD0", Offset = "0x1677FD0", VA = "0x1677FD0")]
	public AnimationEventSound()
	{
	}
}
[Token(Token = "0x200003C")]
public class SoundManager : MonoSingleton<SoundManager>
{
	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource _audioSource;

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x93F11C", Offset = "0x93F11C", VA = "0x93F11C", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x93F1A8", Offset = "0x93F1A8", VA = "0x93F1A8")]
	public void PlaySound(AudioClip clip, bool loop = false)
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x93F1FC", Offset = "0x93F1FC", VA = "0x93F1FC")]
	public void StopSound()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x93F218", Offset = "0x93F218", VA = "0x93F218")]
	public SoundManager()
	{
	}
}
[Token(Token = "0x200003D")]
public class EdenButton : Button
{
	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public string clickAudio;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6746FC", Offset = "0x6746FC")]
	public AudioClip clickSound;

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x954C5C", Offset = "0x954C5C", VA = "0x954C5C", Slot = "41")]
	public override void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x954D74", Offset = "0x954D74", VA = "0x954D74")]
	public EdenButton()
	{
	}
}
[Token(Token = "0x200003E")]
public class Empty4Raycast : MaskableGraphic
{
	[Token(Token = "0x6000157")]
	[Address(RVA = "0x954D7C", Offset = "0x954D7C", VA = "0x954D7C")]
	protected Empty4Raycast()
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x954DA4", Offset = "0x954DA4", VA = "0x954DA4", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}
}
[Token(Token = "0x200003F")]
public class LongPressBtnImmediately : Selectable
{
	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private float _longPressTime;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Button.ButtonClickedEvent onClick;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public Button.ButtonClickedEvent onLongPressBegin;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Button.ButtonClickedEvent onLongPress;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public Button.ButtonClickedEvent onLongPressEnd;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public Button.ButtonClickedEvent onEnter;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public Button.ButtonClickedEvent onExit;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private float pressStartTime;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private bool isDown;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x135")]
	private bool isLongPress;

	[Token(Token = "0x17000024")]
	public float longPressTime
	{
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x96044C", Offset = "0x96044C", VA = "0x96044C")]
		set
		{
		}
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x960454", Offset = "0x960454", VA = "0x960454", Slot = "34")]
	public override void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x960470", Offset = "0x960470", VA = "0x960470", Slot = "35")]
	public override void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x96048C", Offset = "0x96048C", VA = "0x96048C", Slot = "32")]
	public override void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x9604F8", Offset = "0x9604F8", VA = "0x9604F8", Slot = "33")]
	public override void OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x960534", Offset = "0x960534", VA = "0x960534", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x96053C", Offset = "0x96053C", VA = "0x96053C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x9605A0", Offset = "0x9605A0", VA = "0x9605A0")]
	public LongPressBtnImmediately()
	{
	}
}
[Token(Token = "0x2000040")]
public class LongPressedAni : MonoBehaviour
{
	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LongPressedButton longPressedButton;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x674734", Offset = "0x674734")]
	public float longPressTime;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x67476C", Offset = "0x67476C")]
	public Image imgFront;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6747A4", Offset = "0x6747A4")]
	public Image imgAni;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6747DC", Offset = "0x6747DC")]
	public Action OnPressEnd;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string clickAudio;

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x9606F8", Offset = "0x9606F8", VA = "0x9606F8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x9608E4", Offset = "0x9608E4", VA = "0x9608E4")]
	private void onExit()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x96091C", Offset = "0x96091C", VA = "0x96091C")]
	private void OnEnter()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x960958", Offset = "0x960958", VA = "0x960958")]
	private void OnLongPressBegin()
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x960A68", Offset = "0x960A68", VA = "0x960A68")]
	private void OnLongPressEnd()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x960AC8", Offset = "0x960AC8", VA = "0x960AC8")]
	private void onLongPressCancel()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x96099C", Offset = "0x96099C", VA = "0x96099C")]
	protected void PlaySound()
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x960B18", Offset = "0x960B18", VA = "0x960B18")]
	private void Update()
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x960C4C", Offset = "0x960C4C", VA = "0x960C4C")]
	public LongPressedAni()
	{
	}
}
[Token(Token = "0x2000041")]
public class LongPressedButton : Selectable
{
	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public float longPressTime;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Button.ButtonClickedEvent onClick;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public Button.ButtonClickedEvent onLongPressBegin;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Button.ButtonClickedEvent onLongPress;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public Button.ButtonClickedEvent onLongPressEnd;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public Button.ButtonClickedEvent onLongPressCancel;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public Button.ButtonClickedEvent onEnter;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public Button.ButtonClickedEvent onExit;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private int timer;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	private int _frames;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private bool isDown;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x141")]
	private bool isLongPress;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x142")]
	private bool hasLongPressStart;

	[Token(Token = "0x17000025")]
	public bool HasLongPress
	{
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x960C5C", Offset = "0x960C5C", VA = "0x960C5C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x960C64", Offset = "0x960C64", VA = "0x960C64", Slot = "34")]
	public override void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x960C80", Offset = "0x960C80", VA = "0x960C80", Slot = "35")]
	public override void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x960CB4", Offset = "0x960CB4", VA = "0x960CB4", Slot = "32")]
	public override void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x960D04", Offset = "0x960D04", VA = "0x960D04", Slot = "33")]
	public override void OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x960C34", Offset = "0x960C34", VA = "0x960C34")]
	public float Progress()
	{
		return default(float);
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x960D0C", Offset = "0x960D0C", VA = "0x960D0C", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x960D74", Offset = "0x960D74", VA = "0x960D74")]
	private void Update()
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x960E10", Offset = "0x960E10", VA = "0x960E10")]
	public LongPressedButton()
	{
	}
}
[Token(Token = "0x2000042")]
public class PointTrigger : Selectable
{
	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x674814", Offset = "0x674814")]
	public Button.ButtonClickedEvent onPointDown;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public string pointDownAudio;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x67484C", Offset = "0x67484C")]
	public Button.ButtonClickedEvent onPointUp;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public string pointUpClip;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x674884", Offset = "0x674884")]
	public Button.ButtonClickedEvent onPointEnter;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public string pointEnterClip;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6748BC", Offset = "0x6748BC")]
	public Button.ButtonClickedEvent onPointExit;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public string pointExitClip;

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x964BA4", Offset = "0x964BA4", VA = "0x964BA4")]
	private void PlayerSound(string audio)
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x964C08", Offset = "0x964C08", VA = "0x964C08", Slot = "32")]
	public override void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x964C3C", Offset = "0x964C3C", VA = "0x964C3C", Slot = "33")]
	public override void OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x964C70", Offset = "0x964C70", VA = "0x964C70", Slot = "34")]
	public override void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x964CA4", Offset = "0x964CA4", VA = "0x964CA4", Slot = "35")]
	public override void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x964CD8", Offset = "0x964CD8", VA = "0x964CD8")]
	public PointTrigger()
	{
	}
}
[Token(Token = "0x2000043")]
public class Portal : MonoBehaviour
{
	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LongPressBtnImmediately longPressedButton;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6748F4", Offset = "0x6748F4")]
	public float longPressTime;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x67492C", Offset = "0x67492C")]
	public int themeIndex;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x674964", Offset = "0x674964")]
	public string sceneName;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Animator ani;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x67499C", Offset = "0x67499C")]
	public float delayEnterTime;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject pressGO1;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Animator pressAni2;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6749D4", Offset = "0x6749D4")]
	public bool doorMove;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public SceneType sceneType;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Action onSceneLoaded;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Action onSceneLoadedAnimPlayed;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string longPressStartAudio;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public string longPressEndAudio;

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x964DEC", Offset = "0x964DEC", VA = "0x964DEC")]
	private void Start()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x964F28", Offset = "0x964F28", VA = "0x964F28")]
	private void OnEnter()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x964F58", Offset = "0x964F58", VA = "0x964F58")]
	private void onExit()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x964F88", Offset = "0x964F88", VA = "0x964F88")]
	private void OnLongPressEnd()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x96504C", Offset = "0x96504C", VA = "0x96504C")]
	private void OnLongPressBegin()
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x965128", Offset = "0x965128", VA = "0x965128")]
	private void OnLongPressed()
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x965274", Offset = "0x965274", VA = "0x965274")]
	private void ResetAni()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x9652EC", Offset = "0x9652EC", VA = "0x9652EC")]
	public void EnterScene()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x9650C0", Offset = "0x9650C0", VA = "0x9650C0")]
	private void PlayStartSound()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x96520C", Offset = "0x96520C", VA = "0x96520C")]
	private void PlayEndSound()
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x965570", Offset = "0x965570", VA = "0x965570")]
	public Portal()
	{
	}
}
[Token(Token = "0x2000044")]
public class PrefabReference : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000045")]
	private class Property
	{
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityEngine.Object Value;

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xC51C8C", Offset = "0xC51C8C", VA = "0xC51C8C")]
		public Property()
		{
		}
	}

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Property[] mProperties;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<string, Property> mCachedProperties;

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x966B38", Offset = "0x966B38", VA = "0x966B38")]
	private void InitDictionary()
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x966C30", Offset = "0x966C30", VA = "0x966C30")]
	public UnityEngine.Object TryGetProperty(Type t, string name)
	{
		return null;
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x966CD0", Offset = "0x966CD0", VA = "0x966CD0")]
	public UnityEngine.Object GetProperty(Type t, string name)
	{
		return null;
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x966CD8", Offset = "0x966CD8", VA = "0x966CD8")]
	public UnityEngine.Object GetProperty(string name)
	{
		return null;
	}

	[Token(Token = "0x6000188")]
	public T GetProperty<T>(string name) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x966C38", Offset = "0x966C38", VA = "0x966C38")]
	private UnityEngine.Object GetPropertyInternal(Type t, string name, bool logError)
	{
		return null;
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x966D70", Offset = "0x966D70", VA = "0x966D70")]
	public void ForEachProperties(Action<string, UnityEngine.Object> action)
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x966E1C", Offset = "0x966E1C", VA = "0x966E1C")]
	public PrefabReference()
	{
	}
}
[Token(Token = "0x2000046")]
public abstract class UIBase
{
	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[HideInInspector]
	public bool isLoaded;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	private bool isVisible;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public PrefabReference prefabReference;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674A3C", Offset = "0x674A3C")]
	private GameObject <uiGameObject>k__BackingField;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674A4C", Offset = "0x674A4C")]
	private Transform <uiTransform>k__BackingField;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<string> mEventKeyList;

	[Token(Token = "0x17000026")]
	public GameObject uiGameObject
	{
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x94F0EC", Offset = "0x94F0EC", VA = "0x94F0EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675144", Offset = "0x675144")]
		get
		{
			return null;
		}
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x94F0F4", Offset = "0x94F0F4", VA = "0x94F0F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675154", Offset = "0x675154")]
		private set
		{
		}
	}

	[Token(Token = "0x17000027")]
	protected Transform uiTransform
	{
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x94F0FC", Offset = "0x94F0FC", VA = "0x94F0FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675164", Offset = "0x675164")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x94F104", Offset = "0x94F104", VA = "0x94F104")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675174", Offset = "0x675174")]
		private set
		{
		}
	}

	[Token(Token = "0x17000028")]
	internal abstract string Name
	{
		[Token(Token = "0x6000193")]
		get;
	}

	[Token(Token = "0x17000029")]
	protected abstract string PrefabName
	{
		[Token(Token = "0x6000194")]
		get;
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x94F10C", Offset = "0x94F10C", VA = "0x94F10C")]
	public void CreateGameObject(GameObject prefab, Transform parent)
	{
	}

	[Token(Token = "0x6000192")]
	public T GetProperty<T>(string name) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x94F230", Offset = "0x94F230", VA = "0x94F230")]
	internal void Show()
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x94F2D4", Offset = "0x94F2D4", VA = "0x94F2D4")]
	internal void Hide()
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x94F384", Offset = "0x94F384", VA = "0x94F384")]
	public void Destroy()
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x94F4BC", Offset = "0x94F4BC", VA = "0x94F4BC")]
	public void AddEvent(string eventKey, Action<object> action)
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x94F570", Offset = "0x94F570", VA = "0x94F570", Slot = "6")]
	public virtual void OnCreate()
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x94F574", Offset = "0x94F574", VA = "0x94F574", Slot = "7")]
	public virtual void OnDestroy()
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x94F578", Offset = "0x94F578", VA = "0x94F578", Slot = "8")]
	public virtual void OnOpen(object args)
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x94F57C", Offset = "0x94F57C", VA = "0x94F57C", Slot = "9")]
	public virtual void OnClose()
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x94F580", Offset = "0x94F580", VA = "0x94F580")]
	protected UIBase()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x94F604", Offset = "0x94F604", VA = "0x94F604")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675184", Offset = "0x675184")]
	private void <Destroy>b__20_0(string key)
	{
	}
}
[Token(Token = "0x2000047")]
public static class UIManager
{
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674188", Offset = "0x674188")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject go;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform par;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int contentKey;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityAction confirmCb;

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xC54D78", Offset = "0xC54D78", VA = "0xC54D78")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xC54D80", Offset = "0xC54D80", VA = "0xC54D80")]
		internal void <ShowConfirmWindow>b__0()
		{
		}
	}

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static UIManifest mManifest;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly Dictionary<string, UIWindow> mWindows;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly List<string> mOpenedWindows;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static RectTransform uiRoot;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static AsyncOpRef confirmOp;

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x94F688", Offset = "0x94F688", VA = "0x94F688")]
	internal static bool Init(UIManifest manifest)
	{
		return default(bool);
	}

	[Token(Token = "0x60001A0")]
	public static void OpenWindow<T>([Optional] object args) where T : UIWindow
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x94F884", Offset = "0x94F884", VA = "0x94F884")]
	public static void OpenWindow(Type type, [Optional] object args)
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x94F914", Offset = "0x94F914", VA = "0x94F914")]
	private static void OpenWindow(string name, [Optional] object args)
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x94FB88", Offset = "0x94FB88", VA = "0x94FB88")]
	public static Transform GetUIParent(int orderLevel)
	{
		return null;
	}

	[Token(Token = "0x60001A4")]
	public static void CloseWindow<T>() where T : UIWindow
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x94FB90", Offset = "0x94FB90", VA = "0x94FB90")]
	public static void CloseWindow(string name)
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x93BA34", Offset = "0x93BA34", VA = "0x93BA34")]
	public static void CloaseAll()
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x94FC64", Offset = "0x94FC64", VA = "0x94FC64")]
	public static UIWindow GetWindow(string name)
	{
		return null;
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x9419C0", Offset = "0x9419C0", VA = "0x9419C0")]
	public static void ShowConfirmWindow(Transform par, int contentKey, UnityAction confirmCb)
	{
	}
}
[Token(Token = "0x2000049")]
public class UIManifest
{
	[Token(Token = "0x200004A")]
	public class Window
	{
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674A6C", Offset = "0x674A6C")]
		private int <OrderLevel>k__BackingField;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674A7C", Offset = "0x674A7C")]
		private string <Name>k__BackingField;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674A8C", Offset = "0x674A8C")]
		private string <PrefabName>k__BackingField;

		[Token(Token = "0x1700002B")]
		public int OrderLevel
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0xC55004", Offset = "0xC55004", VA = "0xC55004")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6751B4", Offset = "0x6751B4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0xC5500C", Offset = "0xC5500C", VA = "0xC5500C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6751C4", Offset = "0x6751C4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public string Name
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0xC55014", Offset = "0xC55014", VA = "0xC55014")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6751D4", Offset = "0x6751D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0xC5501C", Offset = "0xC5501C", VA = "0xC5501C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6751E4", Offset = "0x6751E4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public string PrefabName
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0xC55024", Offset = "0xC55024", VA = "0xC55024")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6751F4", Offset = "0x6751F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0xC5502C", Offset = "0xC5502C", VA = "0xC5502C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675204", Offset = "0x675204")]
			private set
			{
			}
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xC55034", Offset = "0xC55034", VA = "0xC55034")]
		public Window()
		{
		}
	}

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674A5C", Offset = "0x674A5C")]
	private Window[] <Windows>k__BackingField;

	[Token(Token = "0x1700002A")]
	public Window[] Windows
	{
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x94FDF0", Offset = "0x94FDF0", VA = "0x94FDF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675194", Offset = "0x675194")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x94FDF8", Offset = "0x94FDF8", VA = "0x94FDF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6751A4", Offset = "0x6751A4")]
		private set
		{
		}
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x94FE00", Offset = "0x94FE00", VA = "0x94FE00")]
	public UIManifest()
	{
	}
}
[Token(Token = "0x200004B")]
public abstract class UIWindow : UIBase
{
	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674A9C", Offset = "0x674A9C")]
	private UIManifest.Window <Config>k__BackingField;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private AsyncOpRef asyncOp;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private object openArgs;

	[Token(Token = "0x1700002E")]
	private UIManifest.Window Config
	{
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x94FE08", Offset = "0x94FE08", VA = "0x94FE08")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675214", Offset = "0x675214")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x94FE10", Offset = "0x94FE10", VA = "0x94FE10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675224", Offset = "0x675224")]
		set
		{
		}
	}

	[Token(Token = "0x1700002F")]
	internal override string Name
	{
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x94FE18", Offset = "0x94FE18", VA = "0x94FE18", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000030")]
	protected override string PrefabName
	{
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x94FE34", Offset = "0x94FE34", VA = "0x94FE34", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x94F84C", Offset = "0x94F84C", VA = "0x94F84C")]
	public bool Create(UIManifest.Window windowConifg)
	{
		return default(bool);
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x94FA7C", Offset = "0x94FA7C", VA = "0x94FA7C")]
	public void OpenInternal([Optional] object args)
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x94FE50", Offset = "0x94FE50", VA = "0x94FE50")]
	public void PrefabLoadSuccess()
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x94FD10", Offset = "0x94FD10", VA = "0x94FD10")]
	public void CloseInternal()
	{
	}

	[Token(Token = "0x60001BE")]
	public void OpenWindow<T>([Optional] object args) where T : UIWindow
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x94FF1C", Offset = "0x94FF1C", VA = "0x94FF1C", Slot = "7")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x94FF28", Offset = "0x94FF28", VA = "0x94FF28")]
	public void OpenWindow(Type type, [Optional] object args)
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x94FF98", Offset = "0x94FF98", VA = "0x94FF98")]
	protected UIWindow()
	{
	}
}
[Token(Token = "0x200004C")]
public static class ClassUtil
{
	[Token(Token = "0x60001C2")]
	public static TBaseClass CreateDerivedInstance<TBaseClass>(string derivedClassName)
	{
		return (TBaseClass)null;
	}

	[Token(Token = "0x60001C3")]
	public static TBaseClass CreateDerivedInstance<TBaseClass>(Type derivedClassType)
	{
		return (TBaseClass)null;
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x168377C", Offset = "0x168377C", VA = "0x168377C")]
	public static object CreateInstance(string typeName)
	{
		return null;
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x1683840", Offset = "0x1683840", VA = "0x1683840")]
	public static object CreateInstance(Type t)
	{
		return null;
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x1683848", Offset = "0x1683848", VA = "0x1683848")]
	public static Vector3 ArrayToVector3(float[] arr)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x168387C", Offset = "0x168387C", VA = "0x168387C")]
	public static Vector3 ArrayToVector3(double[] arr)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x16838BC", Offset = "0x16838BC", VA = "0x16838BC")]
	public static Vector3 ArrayToVector3(int[] arr)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x16838FC", Offset = "0x16838FC", VA = "0x16838FC")]
	public static string SubstringSingle(string source, string startStr, string endStr)
	{
		return null;
	}
}
[Token(Token = "0x200004D")]
public class DontDestroyOnLoad : MonoBehaviour
{
	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x954ADC", Offset = "0x954ADC", VA = "0x954ADC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x954B40", Offset = "0x954B40", VA = "0x954B40")]
	public DontDestroyOnLoad()
	{
	}
}
[Token(Token = "0x200004E")]
public class LightingSetting : MonoBehaviour
{
	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material skyBox;

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x95FE24", Offset = "0x95FE24", VA = "0x95FE24")]
	private void Start()
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x95FE30", Offset = "0x95FE30", VA = "0x95FE30")]
	public LightingSetting()
	{
	}
}
[Token(Token = "0x200004F")]
public class Gird
{
	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3 position;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform root;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public CubeRoot cubeRoot;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Quaternion quaternion;

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x958EAC", Offset = "0x958EAC", VA = "0x958EAC")]
	public Gird()
	{
	}
}
[Token(Token = "0x2000050")]
public class GameObjectScrollView : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000051")]
	private class Property
	{
		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UnityEngine.Object Value;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 spacing;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector2 girdSize;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool resetPos;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int Index;

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xC4F000", Offset = "0xC4F000", VA = "0xC4F000")]
		public Property()
		{
		}
	}

	[Token(Token = "0x2000052")]
	private class GirdSize
	{
		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int curentCount;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int totalCount;

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xC4EFF8", Offset = "0xC4EFF8", VA = "0xC4EFF8")]
		public GirdSize()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674198", Offset = "0x674198")]
	private sealed class <>c
	{
		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<Property> <>9__8_0;

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xC4EDA8", Offset = "0xC4EDA8", VA = "0xC4EDA8")]
		public <>c()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xC4EDB0", Offset = "0xC4EDB0", VA = "0xC4EDB0")]
		internal int <InitGrid>b__8_0(Property m1, Property m2)
		{
			return default(int);
		}
	}

	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6741A8", Offset = "0x6741A8")]
	private sealed class <>c__DisplayClass12_0
	{
		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CubeRoot cubeRoot;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<int> action;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ScrollViewPlane scrollViewPlane;

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xC4EDDC", Offset = "0xC4EDDC", VA = "0xC4EDDC")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xC4EDE4", Offset = "0xC4EDE4", VA = "0xC4EDE4")]
		internal void <CoverTransform>b__0()
		{
		}
	}

	[Token(Token = "0x2000055")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6741B8", Offset = "0x6741B8")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CubeRoot cubeRoot;

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xC4EE88", Offset = "0xC4EE88", VA = "0xC4EE88")]
		public <>c__DisplayClass14_0()
		{
		}
	}

	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6741C8", Offset = "0x6741C8")]
	private sealed class <>c__DisplayClass14_1
	{
		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollViewPlane scrollViewPlane;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public <>c__DisplayClass14_0 CS$<>8__locals1;

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xC4EE90", Offset = "0xC4EE90", VA = "0xC4EE90")]
		public <>c__DisplayClass14_1()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xC4EE98", Offset = "0xC4EE98", VA = "0xC4EE98")]
		internal void <OrganizeItems>b__0()
		{
		}
	}

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LayerMask layerMask;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<Property> mProperties;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<string, Gird> m_coverList;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<ScrollViewPlane> mViewPlane;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<int, GirdSize> planeDic;

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x957608", Offset = "0x957608", VA = "0x957608")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x95760C", Offset = "0x95760C", VA = "0x95760C")]
	private void InitGrid()
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x9579D0", Offset = "0x9579D0", VA = "0x9579D0")]
	private ScrollViewPlane GetEmptyPlane(bool IsResetPos, int planeIndex = -1)
	{
		return null;
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x957B2C", Offset = "0x957B2C", VA = "0x957B2C")]
	public int AddTransform(CubeRoot cubeRoot, bool isOld, int planeIndex = -1)
	{
		return default(int);
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x957C44", Offset = "0x957C44", VA = "0x957C44")]
	public void AddTransformShow(CubeRoot cubeRoot, bool isOld)
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x957D30", Offset = "0x957D30", VA = "0x957D30")]
	public bool CoverTransform(CubeRoot cubeRoot, Transform handTransform, Vector3 forword, Action<int> action)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x958538", Offset = "0x958538", VA = "0x958538")]
	private Gird GetEmptyGird(out ScrollViewPlane outscrollViewPlane)
	{
		return null;
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x958744", Offset = "0x958744", VA = "0x958744")]
	public void OrganizeItems(List<CubeRoot> cubeRoots, int nStageID)
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x958610", Offset = "0x958610", VA = "0x958610")]
	private Vector3 GetCubeRotate(Gird grid)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x958B00", Offset = "0x958B00", VA = "0x958B00")]
	public void RemoveTransform(CubeRoot cubeRoot)
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x958BA8", Offset = "0x958BA8", VA = "0x958BA8")]
	public void Clear()
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x958BAC", Offset = "0x958BAC", VA = "0x958BAC")]
	public GameObjectScrollView()
	{
	}
}
[Token(Token = "0x2000057")]
public class ScrollViewData
{
	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ScrollViewData m_instance;

	[Token(Token = "0x17000031")]
	public static ScrollViewData instance
	{
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x93C9C4", Offset = "0x93C9C4", VA = "0x93C9C4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x93CA94", Offset = "0x93CA94", VA = "0x93CA94")]
	public Vector3 GetStageItemRotation(string itemId, Vector3 defaultRotation)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x93CA8C", Offset = "0x93CA8C", VA = "0x93CA8C")]
	public ScrollViewData()
	{
	}
}
[Token(Token = "0x2000058")]
public class ScrollViewPlane : MonoBehaviour
{
	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int index;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform rectTransform;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 spacing;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<string, Gird> m_gridList;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool resetPos;

	[Token(Token = "0x17000032")]
	private Vector3 originPos
	{
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x93CBFC", Offset = "0x93CBFC", VA = "0x93CBFC")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x93CD4C", Offset = "0x93CD4C", VA = "0x93CD4C")]
	public void InitScrollViewPlane(Vector3 spacing, Vector2 girdSize, bool resetPos)
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x93CF08", Offset = "0x93CF08", VA = "0x93CF08")]
	public bool AddViewItem(CubeRoot cubeRoot, bool isOld)
	{
		return default(bool);
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x93D1A0", Offset = "0x93D1A0", VA = "0x93D1A0")]
	private Gird FindSameGird(CubeRoot cubeRoot, bool isOld)
	{
		return null;
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x93D600", Offset = "0x93D600", VA = "0x93D600")]
	public Gird GetEmptyGird(Vector3 point, CubeRoot cubeRoot)
	{
		return null;
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x93D92C", Offset = "0x93D92C", VA = "0x93D92C")]
	public Gird GetEmptyGirdForIndex()
	{
		return null;
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x93DA90", Offset = "0x93DA90", VA = "0x93DA90")]
	public bool IsWhereEmptyGird()
	{
		return default(bool);
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x93DBC8", Offset = "0x93DBC8", VA = "0x93DBC8")]
	public Gird GetEmptyGirdForOrganize()
	{
		return null;
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x93DD28", Offset = "0x93DD28", VA = "0x93DD28")]
	public void RemoveGirdRoot(CubeRoot cubeRoot)
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x93E0C4", Offset = "0x93E0C4", VA = "0x93E0C4")]
	public ScrollViewPlane()
	{
	}
}
[Token(Token = "0x2000059")]
public class ItemView : MonoBehaviour
{
	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x95CE54", Offset = "0x95CE54", VA = "0x95CE54")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x95CE58", Offset = "0x95CE58", VA = "0x95CE58")]
	private void Update()
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x95CE5C", Offset = "0x95CE5C", VA = "0x95CE5C")]
	public ItemView()
	{
	}
}
[Token(Token = "0x200005A")]
public static class ZipWrapper
{
	[Token(Token = "0x200005B")]
	public abstract class ZipCallback
	{
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xC58BEC", Offset = "0xC58BEC", VA = "0xC58BEC", Slot = "4")]
		public virtual bool OnPreZip(ZipEntry _entry)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xC58BF4", Offset = "0xC58BF4", VA = "0xC58BF4", Slot = "5")]
		public virtual void OnPostZip(ZipEntry _entry)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xC58BF8", Offset = "0xC58BF8", VA = "0xC58BF8", Slot = "6")]
		public virtual void OnFinished(bool _result)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xC58BFC", Offset = "0xC58BFC", VA = "0xC58BFC")]
		protected ZipCallback()
		{
		}
	}

	[Token(Token = "0x200005C")]
	public abstract class UnzipCallback
	{
		[Token(Token = "0x6000200")]
		[Address(RVA = "0xC58BE0", Offset = "0xC58BE0", VA = "0xC58BE0", Slot = "4")]
		public virtual bool OnPreUnzip(ZipEntry _entry)
		{
			return default(bool);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xC58BE8", Offset = "0xC58BE8", VA = "0xC58BE8", Slot = "5")]
		public virtual void OnPostUnzip(ZipEntry _entry)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xC4B248", Offset = "0xC4B248", VA = "0xC4B248", Slot = "6")]
		public virtual void OnFinished(bool _result)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xC4B254", Offset = "0xC4B254", VA = "0xC4B254")]
		protected UnzipCallback()
		{
		}
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0xC49A10", Offset = "0xC49A10", VA = "0xC49A10")]
	public static bool Zip(string[] _fileOrDirectoryArray, string _outputPathName, [Optional] string _password, [Optional] ZipCallback _zipCallback)
	{
		return default(bool);
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0xC4A640", Offset = "0xC4A640", VA = "0xC4A640")]
	public static bool UnzipFile(string _filePathName, string _outputPath, [Optional] string _password, [Optional] UnzipCallback _unzipCallback)
	{
		return default(bool);
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0xC4AE7C", Offset = "0xC4AE7C", VA = "0xC4AE7C")]
	public static bool UnzipFile(byte[] _fileBytes, string _outputPath, [Optional] string _password, [Optional] UnzipCallback _unzipCallback)
	{
		return default(bool);
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0xC4A7FC", Offset = "0xC4A7FC", VA = "0xC4A7FC")]
	public static bool UnzipFile(Stream _inputStream, string _outputPath, [Optional] string _password, [Optional] UnzipCallback _unzipCallback, string filePaht = "")
	{
		return default(bool);
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0xC4A1CC", Offset = "0xC4A1CC", VA = "0xC4A1CC")]
	private static bool ZipFile(string _filePathName, string _parentRelPath, ZipOutputStream _zipOutputStream, [Optional] ZipCallback _zipCallback)
	{
		return default(bool);
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0xC49CB8", Offset = "0xC49CB8", VA = "0xC49CB8")]
	private static bool ZipDirectory(string _path, string _parentRelPath, ZipOutputStream _zipOutputStream, [Optional] ZipCallback _zipCallback)
	{
		return default(bool);
	}
}
[Token(Token = "0x200005D")]
public abstract class BaseHand : MonoBehaviour
{
	[Token(Token = "0x6000204")]
	public abstract void OnTriggerPress();

	[Token(Token = "0x6000205")]
	public abstract void OnTriggerDevice(float triggerValue);

	[Token(Token = "0x6000206")]
	public abstract void OnPrimary2DAxis(Vector2 value);

	[Token(Token = "0x6000207")]
	public abstract void onPrimary2DPress();

	[Token(Token = "0x6000208")]
	public abstract void onResetHand();

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x167F018", Offset = "0x167F018", VA = "0x167F018")]
	protected BaseHand()
	{
	}
}
[Token(Token = "0x200005E")]
public class RayLineFeedback : MonoBehaviour
{
	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private EventHandel eventHandel;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float triggerValue;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RayLine rayLine;

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x968638", Offset = "0x968638", VA = "0x968638")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x968788", Offset = "0x968788", VA = "0x968788")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x9688AC", Offset = "0x9688AC", VA = "0x9688AC")]
	public void OnTriggerEvent(float valus, XRRayInteractor xRRay, Transform handTrans)
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x968994", Offset = "0x968994", VA = "0x968994")]
	public RayLineFeedback()
	{
	}
}
[Token(Token = "0x200005F")]
public class ScreenFade : MonoBehaviour
{
	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6741D8", Offset = "0x6741D8")]
	private sealed class <Fade>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ScreenFade <>4__this;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float startAlpha;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float endAlpha;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x17000033")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000219")]
			[Address(RVA = "0xC521F4", Offset = "0xC521F4", VA = "0xC521F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600021B")]
			[Address(RVA = "0xC5223C", Offset = "0xC5223C", VA = "0xC5223C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xC52090", Offset = "0xC52090", VA = "0xC52090")]
		[DebuggerHidden]
		public <Fade>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xC520BC", Offset = "0xC520BC", VA = "0xC520BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xC520C0", Offset = "0xC520C0", VA = "0xC520C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xC521FC", Offset = "0xC521FC", VA = "0xC521FC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x674ABC", Offset = "0x674ABC")]
	public float fadeTime;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x674AF4", Offset = "0x674AF4")]
	public Color fadeColor;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int renderQueue;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private MeshRenderer fadeMeshRenderer;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private MeshFilter fadeMeshFilter;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Material fadeMaterial;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool isFading;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float currentAlpha;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float nowFadeAlpha;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Action fadeCallBack;

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x93C34C", Offset = "0x93C34C", VA = "0x93C34C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x93C738", Offset = "0x93C738", VA = "0x93C738")]
	public void FadeIn(Action fadeCallBack)
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x93C804", Offset = "0x93C804", VA = "0x93C804")]
	public void FadeOut(Action fadeCallBack)
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x93C374", Offset = "0x93C374", VA = "0x93C374")]
	private void CreateFadeMesh()
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x93C730", Offset = "0x93C730", VA = "0x93C730")]
	public void SetCurrentAlpha(float alpha)
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x93C778", Offset = "0x93C778", VA = "0x93C778")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x675234", Offset = "0x675234")]
	private IEnumerator Fade(float startAlpha, float endAlpha)
	{
		return null;
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x93C844", Offset = "0x93C844", VA = "0x93C844")]
	private void SetMaterialAlpha()
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x93C95C", Offset = "0x93C95C", VA = "0x93C95C")]
	public ScreenFade()
	{
	}
}
[Token(Token = "0x2000061")]
public class XRHandControllerEvent : MonoBehaviour
{
	[Token(Token = "0x2000062")]
	public enum HandType
	{
		[Token(Token = "0x4000155")]
		Left,
		[Token(Token = "0x4000156")]
		Right
	}

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public InputDevice rightHand_device;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private XRRayInteractor m_xrRay;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public HandType handType;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private EventHandel eventHandel;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform Sphere;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float SphereScale;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float OriginScale;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool sphereChange;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public BaseHand hand;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool isTrigger;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool handPrimary;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
	private bool isTriggerButton;

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x9516E4", Offset = "0x9516E4", VA = "0x9516E4")]
	private void Start()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x951D28", Offset = "0x951D28", VA = "0x951D28")]
	private void RigestDeviceHand()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x951FAC", Offset = "0x951FAC", VA = "0x951FAC")]
	private void Act(InputDevice device)
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x952174", Offset = "0x952174", VA = "0x952174")]
	private void Update()
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x952590", Offset = "0x952590", VA = "0x952590")]
	private void OnTrigger(float triggerValue)
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x9527C4", Offset = "0x9527C4", VA = "0x9527C4")]
	private void OnTriggerClick()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x952734", Offset = "0x952734", VA = "0x952734")]
	private void OnTriggerOff()
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x952854", Offset = "0x952854", VA = "0x952854")]
	private void OnPrimary2D(Vector2 primaryVec)
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x9529A8", Offset = "0x9529A8", VA = "0x9529A8")]
	public void HandHaptic(float value = 0.3f, float duration = 0.3f)
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x9520F4", Offset = "0x9520F4", VA = "0x9520F4")]
	public string TypeById(HandType handType)
	{
		return null;
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x952AA0", Offset = "0x952AA0", VA = "0x952AA0")]
	private void OnApplicationFocus(bool isFocus)
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x952BE4", Offset = "0x952BE4", VA = "0x952BE4")]
	public XRHandControllerEvent()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x952BF8", Offset = "0x952BF8", VA = "0x952BF8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6752E4", Offset = "0x6752E4")]
	private void <Start>b__13_0(HoverEnterEventArgs HoverEnterEvent)
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x952C9C", Offset = "0x952C9C", VA = "0x952C9C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6752F4", Offset = "0x6752F4")]
	private void <Start>b__13_1(HoverExitEventArgs HoverExitEvent)
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x952D40", Offset = "0x952D40", VA = "0x952D40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675304", Offset = "0x675304")]
	private void <Start>b__13_2(SelectEnterEventArgs HoverEnterEvent)
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x952DE4", Offset = "0x952DE4", VA = "0x952DE4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675314", Offset = "0x675314")]
	private void <Start>b__13_3(SelectExitEventArgs HoverExitEvent)
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x952E88", Offset = "0x952E88", VA = "0x952E88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675324", Offset = "0x675324")]
	private void <Start>b__13_4()
	{
	}
}
[Token(Token = "0x2000063")]
public class AttachmentCfg : BaseConfig
{
	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Hashtable _ht;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string configkey;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string _id;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<string> _attachIds;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<string> _audioUrl;

	[Token(Token = "0x17000035")]
	public string Id
	{
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x167BBC8", Offset = "0x167BBC8", VA = "0x167BBC8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000036")]
	public List<string> AttachIds
	{
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x167BBD0", Offset = "0x167BBD0", VA = "0x167BBD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000037")]
	public List<string> AudioUrl
	{
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x167BBD8", Offset = "0x167BBD8", VA = "0x167BBD8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x167BB64", Offset = "0x167BB64", VA = "0x167BB64", Slot = "4")]
	public override string GetConfigKey()
	{
		return null;
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x167BBE0", Offset = "0x167BBE0", VA = "0x167BBE0", Slot = "5")]
	public override void Trans(string json, string key)
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x167BC88", Offset = "0x167BC88", VA = "0x167BC88")]
	public static void Parse(_Attachments_ attachments)
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x167BEB0", Offset = "0x167BEB0", VA = "0x167BEB0")]
	public static void AddParse(List<_attachment_vo_> attachments)
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x167C094", Offset = "0x167C094", VA = "0x167C094")]
	public static Hashtable GetAllData()
	{
		return null;
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x167C0F8", Offset = "0x167C0F8", VA = "0x167C0F8")]
	public static AttachmentCfg GetData(string id)
	{
		return null;
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x167C1B0", Offset = "0x167C1B0", VA = "0x167C1B0")]
	public static string[] Path()
	{
		return null;
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x167BEA8", Offset = "0x167BEA8", VA = "0x167BEA8")]
	public AttachmentCfg()
	{
	}
}
[Serializable]
[Token(Token = "0x2000064")]
public class _Attachments_ : BaseConfigs
{
	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public new List<_attachment_vo_> data;

	[Token(Token = "0x6000239")]
	[Address(RVA = "0xC4AF60", Offset = "0xC4AF60", VA = "0xC4AF60")]
	public _Attachments_()
	{
	}
}
[Serializable]
[Token(Token = "0x2000065")]
public class _attachment_vo_ : BaseConfigVO
{
	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string id;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<string> attachIds;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<string> audioUrl;

	[Token(Token = "0x600023A")]
	[Address(RVA = "0xC4AFA0", Offset = "0xC4AFA0", VA = "0xC4AFA0")]
	public _attachment_vo_()
	{
	}
}
[Token(Token = "0x2000066")]
public class ConstCfg : BaseConfig
{
	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Hashtable _ht;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string configkey;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string _key;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string _value;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string _desc;

	[Token(Token = "0x17000038")]
	public string Key
	{
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1684AF8", Offset = "0x1684AF8", VA = "0x1684AF8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000039")]
	public string Value
	{
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1684B00", Offset = "0x1684B00", VA = "0x1684B00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003A")]
	public string Desc
	{
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1684B08", Offset = "0x1684B08", VA = "0x1684B08")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x1684A94", Offset = "0x1684A94", VA = "0x1684A94", Slot = "4")]
	public override string GetConfigKey()
	{
		return null;
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x1684B10", Offset = "0x1684B10", VA = "0x1684B10", Slot = "5")]
	public override void Trans(string json, string key)
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x1684BB8", Offset = "0x1684BB8", VA = "0x1684BB8")]
	public static void Parse(_Consts_ consts)
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x1684DE0", Offset = "0x1684DE0", VA = "0x1684DE0")]
	public static void AddParse(List<_const_vo_> consts)
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x1684FC4", Offset = "0x1684FC4", VA = "0x1684FC4")]
	public static Hashtable GetAllData()
	{
		return null;
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x1685028", Offset = "0x1685028", VA = "0x1685028")]
	public static ConstCfg GetData(string key)
	{
		return null;
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x16850E0", Offset = "0x16850E0", VA = "0x16850E0")]
	public static string[] Path()
	{
		return null;
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x1684DD8", Offset = "0x1684DD8", VA = "0x1684DD8")]
	public ConstCfg()
	{
	}
}
[Serializable]
[Token(Token = "0x2000067")]
public class _Consts_ : BaseConfigs
{
	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public new List<_const_vo_> data;

	[Token(Token = "0x6000247")]
	[Address(RVA = "0xC4AF68", Offset = "0xC4AF68", VA = "0xC4AF68")]
	public _Consts_()
	{
	}
}
[Serializable]
[Token(Token = "0x2000068")]
public class _const_vo_ : BaseConfigVO
{
	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string key;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string value;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string desc;

	[Token(Token = "0x6000248")]
	[Address(RVA = "0xC4AFA8", Offset = "0xC4AFA8", VA = "0xC4AFA8")]
	public _const_vo_()
	{
	}
}
[Token(Token = "0x2000069")]
public class LanguageCfg : BaseConfig
{
	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Hashtable _ht;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string configkey;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int _key;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string _cn;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string _cnFontStyle;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string _en;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string _enFontStyle;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string _cnImagePath;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string _enImagePath;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string _des;

	[Token(Token = "0x1700003B")]
	public int Key
	{
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x95CEC8", Offset = "0x95CEC8", VA = "0x95CEC8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700003C")]
	public string Cn
	{
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x95CED0", Offset = "0x95CED0", VA = "0x95CED0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003D")]
	public string CnFontStyle
	{
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x95CED8", Offset = "0x95CED8", VA = "0x95CED8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003E")]
	public string En
	{
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x95CEE0", Offset = "0x95CEE0", VA = "0x95CEE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003F")]
	public string EnFontStyle
	{
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x95CEE8", Offset = "0x95CEE8", VA = "0x95CEE8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000040")]
	public string CnImagePath
	{
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x95CEF0", Offset = "0x95CEF0", VA = "0x95CEF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000041")]
	public string EnImagePath
	{
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x95CEF8", Offset = "0x95CEF8", VA = "0x95CEF8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000042")]
	public string Des
	{
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x95CF00", Offset = "0x95CF00", VA = "0x95CF00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x95CE64", Offset = "0x95CE64", VA = "0x95CE64", Slot = "4")]
	public override string GetConfigKey()
	{
		return null;
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x95CF08", Offset = "0x95CF08", VA = "0x95CF08", Slot = "5")]
	public override void Trans(string json, string key)
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x95CFB0", Offset = "0x95CFB0", VA = "0x95CFB0")]
	public static void Parse(_Languages_ languages)
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x95D270", Offset = "0x95D270", VA = "0x95D270")]
	public static void AddParse(List<_language_vo_> languages)
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x95D4EC", Offset = "0x95D4EC", VA = "0x95D4EC")]
	public static Hashtable GetAllData()
	{
		return null;
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x95D550", Offset = "0x95D550", VA = "0x95D550")]
	public static LanguageCfg GetData(int key)
	{
		return null;
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x95D638", Offset = "0x95D638", VA = "0x95D638")]
	public static string[] Path()
	{
		return null;
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x95D268", Offset = "0x95D268", VA = "0x95D268")]
	public LanguageCfg()
	{
	}
}
[Serializable]
[Token(Token = "0x200006A")]
public class _Languages_ : BaseConfigs
{
	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public new List<_language_vo_> data;

	[Token(Token = "0x600025A")]
	[Address(RVA = "0xC4AF70", Offset = "0xC4AF70", VA = "0xC4AF70")]
	public _Languages_()
	{
	}
}
[Serializable]
[Token(Token = "0x200006B")]
public class _language_vo_ : BaseConfigVO
{
	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int key;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string cn;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string cnFontStyle;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string en;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string enFontStyle;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string cnImagePath;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string enImagePath;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string des;

	[Token(Token = "0x600025B")]
	[Address(RVA = "0xC4AFB0", Offset = "0xC4AFB0", VA = "0xC4AFB0")]
	public _language_vo_()
	{
	}
}
[Token(Token = "0x200006C")]
public class StageGroupCfg : BaseConfig
{
	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Hashtable _ht;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string configkey;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int _id;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string _name;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string _description;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string _titleImage;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<int> _stageList;

	[Token(Token = "0x17000043")]
	public int Id
	{
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x940F18", Offset = "0x940F18", VA = "0x940F18")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000044")]
	public string Name
	{
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x940F20", Offset = "0x940F20", VA = "0x940F20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000045")]
	public string Description
	{
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x940F28", Offset = "0x940F28", VA = "0x940F28")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000046")]
	public string TitleImage
	{
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x940F30", Offset = "0x940F30", VA = "0x940F30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000047")]
	public List<int> StageList
	{
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x940F38", Offset = "0x940F38", VA = "0x940F38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x940EB4", Offset = "0x940EB4", VA = "0x940EB4", Slot = "4")]
	public override string GetConfigKey()
	{
		return null;
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x940F40", Offset = "0x940F40", VA = "0x940F40", Slot = "5")]
	public override void Trans(string json, string key)
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x940FE8", Offset = "0x940FE8", VA = "0x940FE8")]
	public static void Parse(_StageGroups_ stageGroups)
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x94126C", Offset = "0x94126C", VA = "0x94126C")]
	public static void AddParse(List<_stageGroup_vo_> stageGroups)
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x9414AC", Offset = "0x9414AC", VA = "0x9414AC")]
	public static Hashtable GetAllData()
	{
		return null;
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x93FB18", Offset = "0x93FB18", VA = "0x93FB18")]
	public static StageGroupCfg GetData(int id)
	{
		return null;
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x941510", Offset = "0x941510", VA = "0x941510")]
	public static string[] Path()
	{
		return null;
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x941264", Offset = "0x941264", VA = "0x941264")]
	public StageGroupCfg()
	{
	}
}
[Serializable]
[Token(Token = "0x200006D")]
public class _StageGroups_ : BaseConfigs
{
	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public new List<_stageGroup_vo_> data;

	[Token(Token = "0x600026A")]
	[Address(RVA = "0xC4AF78", Offset = "0xC4AF78", VA = "0xC4AF78")]
	public _StageGroups_()
	{
	}
}
[Serializable]
[Token(Token = "0x200006E")]
public class _stageGroup_vo_ : BaseConfigVO
{
	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string name;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string description;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string titleImage;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<int> stageList;

	[Token(Token = "0x600026B")]
	[Address(RVA = "0xC4AFB8", Offset = "0xC4AFB8", VA = "0xC4AFB8")]
	public _stageGroup_vo_()
	{
	}
}
[Token(Token = "0x200006F")]
public class StageItemCfg : BaseConfig
{
	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Hashtable _ht;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string configkey;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string _id;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 _itemPos;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector4 _ItemRotation;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string _attDataId;

	[Token(Token = "0x17000048")]
	public string Id
	{
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x941FE4", Offset = "0x941FE4", VA = "0x941FE4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000049")]
	public Vector3 ItemPos
	{
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x941FEC", Offset = "0x941FEC", VA = "0x941FEC")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700004A")]
	public Vector4 ItemRotation
	{
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x941FF8", Offset = "0x941FF8", VA = "0x941FF8")]
		get
		{
			return default(Vector4);
		}
	}

	[Token(Token = "0x1700004B")]
	public string AttDataId
	{
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x942004", Offset = "0x942004", VA = "0x942004")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x941F80", Offset = "0x941F80", VA = "0x941F80", Slot = "4")]
	public override string GetConfigKey()
	{
		return null;
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x94200C", Offset = "0x94200C", VA = "0x94200C", Slot = "5")]
	public override void Trans(string json, string key)
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x9420B4", Offset = "0x9420B4", VA = "0x9420B4")]
	public static void Parse(_StageItems_ stageItems)
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x9422E0", Offset = "0x9422E0", VA = "0x9422E0")]
	public static void AddParse(List<_stageItem_vo_> stageItems)
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x9424C8", Offset = "0x9424C8", VA = "0x9424C8")]
	public static Hashtable GetAllData()
	{
		return null;
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x93CB40", Offset = "0x93CB40", VA = "0x93CB40")]
	public static StageItemCfg GetData(string id)
	{
		return null;
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x94252C", Offset = "0x94252C", VA = "0x94252C")]
	public static string[] Path()
	{
		return null;
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x9422D8", Offset = "0x9422D8", VA = "0x9422D8")]
	public StageItemCfg()
	{
	}
}
[Serializable]
[Token(Token = "0x2000070")]
public class _StageItems_ : BaseConfigs
{
	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public new List<_stageItem_vo_> data;

	[Token(Token = "0x6000279")]
	[Address(RVA = "0xC4AF80", Offset = "0xC4AF80", VA = "0xC4AF80")]
	public _StageItems_()
	{
	}
}
[Serializable]
[Token(Token = "0x2000071")]
public class _stageItem_vo_ : BaseConfigVO
{
	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string id;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 itemPos;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector4 ItemRotation;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string attDataId;

	[Token(Token = "0x600027A")]
	[Address(RVA = "0xC4AFC0", Offset = "0xC4AFC0", VA = "0xC4AFC0")]
	public _stageItem_vo_()
	{
	}
}
[Token(Token = "0x2000072")]
public class StagesCfg : BaseConfig
{
	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Hashtable _ht;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string configkey;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int _id;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string _name;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _chipCount;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int _starCount;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string _pathUrl;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string _bundleName;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string _itemForm;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string _attachForm;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string _BGM;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float _attDis;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float _attAngle;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private List<string> _showItems;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private string _scene;

	[Token(Token = "0x1700004C")]
	public int Id
	{
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x942808", Offset = "0x942808", VA = "0x942808")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700004D")]
	public string Name
	{
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x942810", Offset = "0x942810", VA = "0x942810")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700004E")]
	public int ChipCount
	{
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x942818", Offset = "0x942818", VA = "0x942818")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700004F")]
	public int StarCount
	{
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x942820", Offset = "0x942820", VA = "0x942820")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000050")]
	public string PathUrl
	{
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x942828", Offset = "0x942828", VA = "0x942828")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000051")]
	public string BundleName
	{
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x942830", Offset = "0x942830", VA = "0x942830")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000052")]
	public string ItemForm
	{
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x942838", Offset = "0x942838", VA = "0x942838")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000053")]
	public string AttachForm
	{
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x942840", Offset = "0x942840", VA = "0x942840")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000054")]
	public string BGM
	{
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x942848", Offset = "0x942848", VA = "0x942848")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000055")]
	public float AttDis
	{
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x942850", Offset = "0x942850", VA = "0x942850")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000056")]
	public float AttAngle
	{
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x942858", Offset = "0x942858", VA = "0x942858")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000057")]
	public List<string> ShowItems
	{
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x942860", Offset = "0x942860", VA = "0x942860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000058")]
	public string Scene
	{
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x942868", Offset = "0x942868", VA = "0x942868")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x9427A4", Offset = "0x9427A4", VA = "0x9427A4", Slot = "4")]
	public override string GetConfigKey()
	{
		return null;
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x942870", Offset = "0x942870", VA = "0x942870", Slot = "5")]
	public override void Trans(string json, string key)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x942918", Offset = "0x942918", VA = "0x942918")]
	public static void Parse(_Stagess_ stagess)
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x942C0C", Offset = "0x942C0C", VA = "0x942C0C")]
	public static void AddParse(List<_stages_vo_> stagess)
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x942EBC", Offset = "0x942EBC", VA = "0x942EBC")]
	public static Hashtable GetAllData()
	{
		return null;
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x93FC00", Offset = "0x93FC00", VA = "0x93FC00")]
	public static StagesCfg GetData(int id)
	{
		return null;
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x942F20", Offset = "0x942F20", VA = "0x942F20")]
	public static string[] Path()
	{
		return null;
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x942C04", Offset = "0x942C04", VA = "0x942C04")]
	public StagesCfg()
	{
	}
}
[Serializable]
[Token(Token = "0x2000073")]
public class _Stagess_ : BaseConfigs
{
	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public new List<_stages_vo_> data;

	[Token(Token = "0x6000291")]
	[Address(RVA = "0xC4AF88", Offset = "0xC4AF88", VA = "0xC4AF88")]
	public _Stagess_()
	{
	}
}
[Serializable]
[Token(Token = "0x2000074")]
public class _stages_vo_ : BaseConfigVO
{
	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string name;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int chipCount;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int starCount;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string pathUrl;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string bundleName;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string itemForm;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string attachForm;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string BGM;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float attDis;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float attAngle;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<string> showItems;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string scene;

	[Token(Token = "0x6000292")]
	[Address(RVA = "0xC4AFC8", Offset = "0xC4AFC8", VA = "0xC4AFC8")]
	public _stages_vo_()
	{
	}
}
[Token(Token = "0x2000075")]
public class StarMedalCfg : BaseConfig
{
	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Hashtable _ht;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string configkey;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int _id;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string _name;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string _starImage;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string _starImage2;

	[Token(Token = "0x17000059")]
	public int Id
	{
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x9430BC", Offset = "0x9430BC", VA = "0x9430BC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700005A")]
	public string Name
	{
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x9430C4", Offset = "0x9430C4", VA = "0x9430C4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700005B")]
	public string StarImage
	{
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x9430CC", Offset = "0x9430CC", VA = "0x9430CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700005C")]
	public string StarImage2
	{
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x9430D4", Offset = "0x9430D4", VA = "0x9430D4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x943058", Offset = "0x943058", VA = "0x943058", Slot = "4")]
	public override string GetConfigKey()
	{
		return null;
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x9430DC", Offset = "0x9430DC", VA = "0x9430DC", Slot = "5")]
	public override void Trans(string json, string key)
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x943184", Offset = "0x943184", VA = "0x943184")]
	public static void Parse(_StarMedals_ starMedals)
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x9433F4", Offset = "0x9433F4", VA = "0x9433F4")]
	public static void AddParse(List<_starMedal_vo_> starMedals)
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x943620", Offset = "0x943620", VA = "0x943620")]
	public static Hashtable GetAllData()
	{
		return null;
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x93FF20", Offset = "0x93FF20", VA = "0x93FF20")]
	public static StarMedalCfg GetData(int id)
	{
		return null;
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x943684", Offset = "0x943684", VA = "0x943684")]
	public static string[] Path()
	{
		return null;
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x9433EC", Offset = "0x9433EC", VA = "0x9433EC")]
	public StarMedalCfg()
	{
	}
}
[Serializable]
[Token(Token = "0x2000076")]
public class _StarMedals_ : BaseConfigs
{
	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public new List<_starMedal_vo_> data;

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0xC4AF90", Offset = "0xC4AF90", VA = "0xC4AF90")]
	public _StarMedals_()
	{
	}
}
[Serializable]
[Token(Token = "0x2000077")]
public class _starMedal_vo_ : BaseConfigVO
{
	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string name;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string starImage;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string starImage2;

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0xC4AFD0", Offset = "0xC4AFD0", VA = "0xC4AFD0")]
	public _starMedal_vo_()
	{
	}
}
[Token(Token = "0x2000078")]
public class ThemeCfg : BaseConfig
{
	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Hashtable _ht;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string configkey;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int _id;

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string _name;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string _icon;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string _mainPicture;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string _scenePath;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<int> _stageGroupList;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string _effectAssemble;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string _effectMiddle;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private string _effectCorrect;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private string _effectGround;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private string _dragAudio;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private string _bgm;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private string _sceneName;

	[Token(Token = "0x1700005D")]
	public int Id
	{
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x94B1E0", Offset = "0x94B1E0", VA = "0x94B1E0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700005E")]
	public string Name
	{
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x94B1E8", Offset = "0x94B1E8", VA = "0x94B1E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700005F")]
	public string Icon
	{
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x94B1F0", Offset = "0x94B1F0", VA = "0x94B1F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000060")]
	public string MainPicture
	{
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x94B1F8", Offset = "0x94B1F8", VA = "0x94B1F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000061")]
	public string ScenePath
	{
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x94B200", Offset = "0x94B200", VA = "0x94B200")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000062")]
	public List<int> StageGroupList
	{
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x94B208", Offset = "0x94B208", VA = "0x94B208")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000063")]
	public string EffectAssemble
	{
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x94B210", Offset = "0x94B210", VA = "0x94B210")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000064")]
	public string EffectMiddle
	{
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x94B218", Offset = "0x94B218", VA = "0x94B218")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000065")]
	public string EffectCorrect
	{
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x94B220", Offset = "0x94B220", VA = "0x94B220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000066")]
	public string EffectGround
	{
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x94B228", Offset = "0x94B228", VA = "0x94B228")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000067")]
	public string DragAudio
	{
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x94B230", Offset = "0x94B230", VA = "0x94B230")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000068")]
	public string Bgm
	{
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x94B238", Offset = "0x94B238", VA = "0x94B238")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000069")]
	public string SceneName
	{
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x94B240", Offset = "0x94B240", VA = "0x94B240")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x94B17C", Offset = "0x94B17C", VA = "0x94B17C", Slot = "4")]
	public override string GetConfigKey()
	{
		return null;
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x94B248", Offset = "0x94B248", VA = "0x94B248", Slot = "5")]
	public override void Trans(string json, string key)
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x94B2F0", Offset = "0x94B2F0", VA = "0x94B2F0")]
	public static void Parse(_Themes_ themes)
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x94B614", Offset = "0x94B614", VA = "0x94B614")]
	public static void AddParse(List<_theme_vo_> themes)
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x94B8F4", Offset = "0x94B8F4", VA = "0x94B8F4")]
	public static Hashtable GetAllData()
	{
		return null;
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x94B958", Offset = "0x94B958", VA = "0x94B958")]
	public static ThemeCfg GetData(int id)
	{
		return null;
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x94BA40", Offset = "0x94BA40", VA = "0x94BA40")]
	public static string[] Path()
	{
		return null;
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x94B60C", Offset = "0x94B60C", VA = "0x94B60C")]
	public ThemeCfg()
	{
	}
}
[Serializable]
[Token(Token = "0x2000079")]
public class _Themes_ : BaseConfigs
{
	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public new List<_theme_vo_> data;

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0xC4AF98", Offset = "0xC4AF98", VA = "0xC4AF98")]
	public _Themes_()
	{
	}
}
[Serializable]
[Token(Token = "0x200007A")]
public class _theme_vo_ : BaseConfigVO
{
	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string name;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string icon;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string mainPicture;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string scenePath;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<int> stageGroupList;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string effectAssemble;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string effectMiddle;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string effectCorrect;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string effectGround;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string dragAudio;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string bgm;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public string sceneName;

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0xC4AFD8", Offset = "0xC4AFD8", VA = "0xC4AFD8")]
	public _theme_vo_()
	{
	}
}
[Token(Token = "0x200007B")]
public class EventKey
{
	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string OnLoginBack;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly string OnPlatformSdkBack;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly string InitCubeManager;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static readonly string ExitGameScene;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static readonly string OnSceneClear;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static readonly string OnSceneLoaded;

	[Token(Token = "0x40001DF")]
	public const string OnSceneLoadedAnimEnd = "OnSceneLoadedAnimEnd";

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static readonly string OnEnterStage;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static readonly string OnClickOrganizeItems;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static readonly string OnHandHaptic;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static readonly string TranslateStartEnd;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static readonly string TranslateEndEnd;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static readonly string SetHandPress;

	[Token(Token = "0x40001E6")]
	public const string OpenAppConsole = "OpenAppConsole";

	[Token(Token = "0x40001E7")]
	public const string OnCubeColliderEnter = "OnCubeColliderEnter";

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x9555A4", Offset = "0x9555A4", VA = "0x9555A4")]
	public EventKey()
	{
	}
}
[Token(Token = "0x200007C")]
public class AroundCom : MonoBehaviour
{
	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 m_vCenter;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 m_vAxis;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float m_fTotalTime;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float m_fTotlaAngle;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float m_fCount;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float m_fDeltaAngle;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float m_fCountAngle;

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x167A514", Offset = "0x167A514", VA = "0x167A514")]
	public void StartAround(float time, Vector3 centerPos, Vector3 axis, float angle)
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x167A568", Offset = "0x167A568", VA = "0x167A568")]
	private void Update()
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x167A63C", Offset = "0x167A63C", VA = "0x167A63C")]
	public AroundCom()
	{
	}
}
[Token(Token = "0x200007D")]
public class Cube : MonoBehaviour
{
	[Token(Token = "0x200007E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6741E8", Offset = "0x6741E8")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string index;

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xC4C448", Offset = "0xC4C448", VA = "0xC4C448")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xC4C450", Offset = "0xC4C450", VA = "0xC4C450")]
		internal bool <InsertCollider>b__0(string value)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6741F8", Offset = "0x6741F8")]
	private sealed class <>c__DisplayClass15_0
	{
		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string index;

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xC4C490", Offset = "0xC4C490", VA = "0xC4C490")]
		public <>c__DisplayClass15_0()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xC4C498", Offset = "0xC4C498", VA = "0xC4C498")]
		internal bool <RemoveCollider>b__0(string value)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<AttachData> m_attData;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string m_strId;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private CubeRoot m_cubeRoot;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<string, List<string>> colliderData;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Collider[] m_collider;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool m_bIsCheckCollider;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Hand m_hand;

	[Token(Token = "0x1700006A")]
	public List<AttachData> AttData
	{
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1685E1C", Offset = "0x1685E1C", VA = "0x1685E1C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700006B")]
	public string ID
	{
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1685E24", Offset = "0x1685E24", VA = "0x1685E24")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700006C")]
	public CubeRoot Root
	{
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1685E2C", Offset = "0x1685E2C", VA = "0x1685E2C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x1685E34", Offset = "0x1685E34", VA = "0x1685E34")]
	private void Start()
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x1685F70", Offset = "0x1685F70", VA = "0x1685F70")]
	public void InsertCollider(CubeColliderData data, Cube otherCube)
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x16861BC", Offset = "0x16861BC", VA = "0x16861BC")]
	public void RemoveCollider(CubeColliderData data, Cube otherCube)
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x16863C0", Offset = "0x16863C0", VA = "0x16863C0")]
	public void InitRoot(CubeRoot root)
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x16863C8", Offset = "0x16863C8", VA = "0x16863C8")]
	public void InitData(string id, List<AttachData> attDatas)
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x16863FC", Offset = "0x16863FC", VA = "0x16863FC")]
	public void InitShowID(string id)
	{
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x1686404", Offset = "0x1686404", VA = "0x1686404")]
	private void Update()
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x16864CC", Offset = "0x16864CC", VA = "0x16864CC")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x16867A4", Offset = "0x16867A4", VA = "0x16867A4")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x16868D0", Offset = "0x16868D0", VA = "0x16868D0")]
	public Cube()
	{
	}
}
[Token(Token = "0x2000080")]
public class CubeColliderData : MonoBehaviour
{
	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Cube parentCube;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string strType;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string nIndex;

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x1686B88", Offset = "0x1686B88", VA = "0x1686B88")]
	private void Start()
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x1686DEC", Offset = "0x1686DEC", VA = "0x1686DEC")]
	private void Update()
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x1686DF0", Offset = "0x1686DF0", VA = "0x1686DF0")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x1687174", Offset = "0x1687174", VA = "0x1687174")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x168744C", Offset = "0x168744C", VA = "0x168744C")]
	public CubeColliderData()
	{
	}
}
[Token(Token = "0x2000081")]
public class CubeRoot : MonoBehaviour
{
	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674208", Offset = "0x674208")]
	private sealed class <>c__DisplayClass23_0
	{
		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Cube cube;

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xC4CC24", Offset = "0xC4CC24", VA = "0xC4CC24")]
		public <>c__DisplayClass23_0()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xC4CC2C", Offset = "0xC4CC2C", VA = "0xC4CC2C")]
		internal bool <InsertDropData>b__0(Cube item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000083")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674218", Offset = "0x674218")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Cube cube;

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xC4CCA4", Offset = "0xC4CCA4", VA = "0xC4CCA4")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xC4CCAC", Offset = "0xC4CCAC", VA = "0xC4CCAC")]
		internal bool <RemoveDropData>b__0(Cube item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674228", Offset = "0x674228")]
	private sealed class <>c__DisplayClass29_0
	{
		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Cube cubeBase;

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xC4CD24", Offset = "0xC4CD24", VA = "0xC4CD24")]
		public <>c__DisplayClass29_0()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xC4CD2C", Offset = "0xC4CD2C", VA = "0xC4CD2C")]
		internal bool <AssembleCubes>b__0(CubeData item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674238", Offset = "0x674238")]
	private sealed class <>c__DisplayClass29_1
	{
		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Cube cube;

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xC4CD58", Offset = "0xC4CD58", VA = "0xC4CD58")]
		public <>c__DisplayClass29_1()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xC4CD60", Offset = "0xC4CD60", VA = "0xC4CD60")]
		internal bool <AssembleCubes>b__2(CubeData item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674248", Offset = "0x674248")]
	private sealed class <>c__DisplayClass36_0
	{
		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Hand hand;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CubeRoot <>4__this;

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xC4CD8C", Offset = "0xC4CD8C", VA = "0xC4CD8C")]
		public <>c__DisplayClass36_0()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xC4CD94", Offset = "0xC4CD94", VA = "0xC4CD94")]
		internal void <FollowHand>b__0()
		{
		}
	}

	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674258", Offset = "0x674258")]
	private sealed class <<AssembleCubes>g__XRGrabTrue|29_1>d : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public XRGrabInteractable xrgrab;

		[Token(Token = "0x17000070")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0xC4CBD4", Offset = "0xC4CBD4", VA = "0xC4CBD4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0xC4CC1C", Offset = "0xC4CC1C", VA = "0xC4CC1C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xC4CB30", Offset = "0xC4CB30", VA = "0xC4CB30")]
		[DebuggerHidden]
		public <<AssembleCubes>g__XRGrabTrue|29_1>d(int <>1__state)
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xC4CB5C", Offset = "0xC4CB5C", VA = "0xC4CB5C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xC4CB60", Offset = "0xC4CB60", VA = "0xC4CB60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xC4CBDC", Offset = "0xC4CBDC", VA = "0xC4CBDC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CubeRootType typeRoot;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<Cube> m_arrCubes;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Hand m_hand;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private XRGrabInteractable m_xrGrab;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 targetPosition;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float fSpeed;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private DG.Tweening.Tween tweenFollow;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool bIsFollowHand;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string ID;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RootType type;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public Vector3 defaultPos;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public CubeState cubeState;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public Vector3 originPos;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool IsHover;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
	public bool IsInGrid;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<Cube> arrDropCube;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 m_vecFollow;

	[Token(Token = "0x1700006D")]
	public List<Cube> arrCubes
	{
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x952EDC", Offset = "0x952EDC", VA = "0x952EDC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x952EE4", Offset = "0x952EE4", VA = "0x952EE4")]
		set
		{
		}
	}

	[Token(Token = "0x1700006E")]
	public Hand HoldHand
	{
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x95300C", Offset = "0x95300C", VA = "0x95300C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x952EEC", Offset = "0x952EEC", VA = "0x952EEC")]
		set
		{
		}
	}

	[Token(Token = "0x1700006F")]
	public DG.Tweening.Tween TweenMove
	{
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x953B58", Offset = "0x953B58", VA = "0x953B58")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x953B60", Offset = "0x953B60", VA = "0x953B60")]
		set
		{
		}
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x953014", Offset = "0x953014", VA = "0x953014")]
	private void Start()
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x953018", Offset = "0x953018", VA = "0x953018")]
	public void InsertDropData(Cube cube)
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x9531A4", Offset = "0x9531A4", VA = "0x9531A4")]
	public void RemoveDropData(Cube cube)
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x953330", Offset = "0x953330", VA = "0x953330")]
	public void RefreshData()
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x953448", Offset = "0x953448", VA = "0x953448")]
	public void InitShow(Vector3 defaultPos)
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x95345C", Offset = "0x95345C", VA = "0x95345C")]
	public void InitCube(Cube cube)
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x953524", Offset = "0x953524", VA = "0x953524")]
	public void InsertCube(Cube cube)
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x95359C", Offset = "0x95359C", VA = "0x95359C")]
	public void AssembleCubes(List<Cube> cubes, List<CubeData> m_arrCubeDatas)
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x953AA8", Offset = "0x953AA8", VA = "0x953AA8")]
	public void ClearData()
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x953B68", Offset = "0x953B68", VA = "0x953B68")]
	public bool IsPlayingMove()
	{
		return default(bool);
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x953B98", Offset = "0x953B98", VA = "0x953B98")]
	public void FollowHand(Hand hand)
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x954088", Offset = "0x954088", VA = "0x954088")]
	public void StopFollow()
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x9540DC", Offset = "0x9540DC", VA = "0x9540DC")]
	public bool IsFollowHand()
	{
		return default(bool);
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x9540E4", Offset = "0x9540E4", VA = "0x9540E4")]
	public CubeRoot()
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x953A30", Offset = "0x953A30", VA = "0x953A30")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x675334", Offset = "0x675334")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675334", Offset = "0x675334")]
	internal static IEnumerator <AssembleCubes>g__XRGrabTrue|29_1(XRGrabInteractable xrgrab)
	{
		return null;
	}
}
[Token(Token = "0x2000088")]
public class CubeRootShow : CubeRoot
{
	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Gird m_gird;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Vector3 DefaultRotation;

	[Token(Token = "0x17000072")]
	public Gird Gird
	{
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x9541C0", Offset = "0x9541C0", VA = "0x9541C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x9541C8", Offset = "0x9541C8", VA = "0x9541C8")]
		set
		{
		}
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x9541F8", Offset = "0x9541F8", VA = "0x9541F8")]
	public CubeRootShow()
	{
	}
}
[Token(Token = "0x2000089")]
public class TransLateAni : MonoBehaviour
{
	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x94EE94", Offset = "0x94EE94", VA = "0x94EE94")]
	public void PlayStartEnd()
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x94EF94", Offset = "0x94EF94", VA = "0x94EF94")]
	public void PlayEndEnd()
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x94F094", Offset = "0x94F094", VA = "0x94F094")]
	public TransLateAni()
	{
	}
}
[Token(Token = "0x200008A")]
public class CubeFeedback : MonoBehaviour
{
	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<string, HoverCache> mHoverCache;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float triggerValue;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<string, bool> isHover;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GradientAlphaKey[] alphakeys;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private EventHandel eventHandel;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private RayLine rayLine;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private HoverCache hoverCache;

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x1687454", Offset = "0x1687454", VA = "0x1687454")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x168767C", Offset = "0x168767C", VA = "0x168767C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x1687814", Offset = "0x1687814", VA = "0x1687814")]
	public void OnHverEnterEvent(Transform interactor, Transform hands)
	{
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x1687A0C", Offset = "0x1687A0C", VA = "0x1687A0C")]
	public void OnHverExitEvent(Transform interactor, Transform hands)
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x1687B98", Offset = "0x1687B98", VA = "0x1687B98")]
	public CubeFeedback()
	{
	}
}
[Token(Token = "0x200008B")]
internal class HoverCache
{
	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string grabTransName;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isHover;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public DG.Tweening.Tween tween;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 originPos;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool isSelectEnter;

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x95B548", Offset = "0x95B548", VA = "0x95B548")]
	public HoverCache(string grabTransName)
	{
	}
}
[Token(Token = "0x200008C")]
public class CubeManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674268", Offset = "0x674268")]
	private sealed class <>c
	{
		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<PrefabInstance> <>9__23_0;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<PrefabInstance> <>9__23_2;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Comparison<CubeData> <>9__31_0;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Action<GameObject> <>9__37_1;

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xC4C53C", Offset = "0xC4C53C", VA = "0xC4C53C")]
		public <>c()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xC4C544", Offset = "0xC4C544", VA = "0xC4C544")]
		internal bool <PortalLoadSuccess>b__23_0(PrefabInstance item)
		{
			return default(bool);
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xC4C59C", Offset = "0xC4C59C", VA = "0xC4C59C")]
		internal bool <PortalLoadSuccess>b__23_2(PrefabInstance item)
		{
			return default(bool);
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xC4C5F4", Offset = "0xC4C5F4", VA = "0xC4C5F4")]
		internal int <InitData>b__31_0(CubeData m1, CubeData m2)
		{
			return default(int);
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xC4C620", Offset = "0xC4C620", VA = "0xC4C620")]
		internal void <Assemble>b__37_1(GameObject item)
		{
		}
	}

	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674278", Offset = "0x674278")]
	private sealed class <>c__DisplayClass28_0
	{
		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xC4C640", Offset = "0xC4C640", VA = "0xC4C640")]
		public <>c__DisplayClass28_0()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xC4C648", Offset = "0xC4C648", VA = "0xC4C648")]
		internal bool <FindPrefab>b__0(PrefabInstance item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674288", Offset = "0x674288")]
	private sealed class <>c__DisplayClass29_0
	{
		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string cubeRootId;

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xC4C66C", Offset = "0xC4C66C", VA = "0xC4C66C")]
		public <>c__DisplayClass29_0()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xC4C674", Offset = "0xC4C674", VA = "0xC4C674")]
		internal bool <InitCube>b__0(CubeModeData item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674298", Offset = "0x674298")]
	private sealed class <>c__DisplayClass29_1
	{
		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string dataId;

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xC4C698", Offset = "0xC4C698", VA = "0xC4C698")]
		public <>c__DisplayClass29_1()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xC4C6A0", Offset = "0xC4C6A0", VA = "0xC4C6A0")]
		internal bool <InitCube>b__1(CubeData item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xC4C6C4", Offset = "0xC4C6C4", VA = "0xC4C6C4")]
		internal bool <InitCube>b__2(CubeData item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6742A8", Offset = "0x6742A8")]
	private sealed class <>c__DisplayClass36_0
	{
		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Cube cube;

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xC4C6E8", Offset = "0xC4C6E8", VA = "0xC4C6E8")]
		public <>c__DisplayClass36_0()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xC4C6F0", Offset = "0xC4C6F0", VA = "0xC4C6F0")]
		internal bool <Drop>b__0(AttachData item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6742B8", Offset = "0x6742B8")]
	private sealed class <>c__DisplayClass37_0
	{
		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string mainCubeID;

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xC4C71C", Offset = "0xC4C71C", VA = "0xC4C71C")]
		public <>c__DisplayClass37_0()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xC4C724", Offset = "0xC4C724", VA = "0xC4C724")]
		internal bool <Assemble>b__0(Cube item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000093")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6742C8", Offset = "0x6742C8")]
	private sealed class <>c__DisplayClass42_0
	{
		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int stageGroupId;

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xC4C748", Offset = "0xC4C748", VA = "0xC4C748")]
		public <>c__DisplayClass42_0()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xC4C750", Offset = "0xC4C750", VA = "0xC4C750")]
		internal void <ShowTransDoor>b__0()
		{
		}
	}

	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6742D8", Offset = "0x6742D8")]
	private sealed class <>c__DisplayClass45_0
	{
		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string rootId;

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xC4C818", Offset = "0xC4C818", VA = "0xC4C818")]
		public <>c__DisplayClass45_0()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xC4C820", Offset = "0xC4C820", VA = "0xC4C820")]
		internal bool <OrganizeItems>b__0(CubeRoot item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000095")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6742E8", Offset = "0x6742E8")]
	private sealed class <>c__DisplayClass46_0
	{
		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CubeManager <>4__this;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Hand hand;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string RootId;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform RootTransform;

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xC4C844", Offset = "0xC4C844", VA = "0xC4C844")]
		public <>c__DisplayClass46_0()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xC4C84C", Offset = "0xC4C84C", VA = "0xC4C84C")]
		internal void <Pull>b__0(int planeIndex)
		{
		}
	}

	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6742F8", Offset = "0x6742F8")]
	private sealed class <CheckPulledCube>d__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CubeManager <>4__this;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Hand hand;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string RootId;

		[Token(Token = "0x17000073")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000344")]
			[Address(RVA = "0xC4CA30", Offset = "0xC4CA30", VA = "0xC4CA30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000346")]
			[Address(RVA = "0xC4CA78", Offset = "0xC4CA78", VA = "0xC4CA78", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xC4C98C", Offset = "0xC4C98C", VA = "0xC4C98C")]
		[DebuggerHidden]
		public <CheckPulledCube>d__47(int <>1__state)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xC4C9B8", Offset = "0xC4C9B8", VA = "0xC4C9B8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xC4C9BC", Offset = "0xC4C9BC", VA = "0xC4C9BC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xC4CA38", Offset = "0xC4CA38", VA = "0xC4CA38", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected List<CubeRoot> m_arrCubeRoots;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected List<CubeData> m_arrCubeDatas;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected Dictionary<string, List<AttachData>> m_dicAttachData;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<GameObject> showPanelList;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int strCurStage;

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public StagesCfg CurStage;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private AudioSource m_audioSource;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private AudioSource m_bgmSourece;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObjectScrollView m_scrollView;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private ThemeCfg curThemeCfg;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string m_strDragAudioUrl;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private string m_strEffectAssemble;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private string m_strEffectCorrect;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private string m_strEffectGround;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private string m_strEffectMiddle;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected GameObject rootNode;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Portal m_Portal;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private GameObject m_PortalTxt;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Dictionary<string, List<CubeColliderData>> _cubeDataList;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private int loadCount;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private List<PrefabInstance> prefabInstances;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private AsyncOpRef portalRef;

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x1687C68", Offset = "0x1687C68", VA = "0x1687C68")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x1688D64", Offset = "0x1688D64", VA = "0x1688D64")]
	private void PortalLoadSuccess(object parm)
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x16881A8", Offset = "0x16881A8", VA = "0x16881A8")]
	public void LoadJson()
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x1689114", Offset = "0x1689114", VA = "0x1689114")]
	private void StartGame()
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x168A424", Offset = "0x168A424", VA = "0x168A424")]
	private void PreloadCube()
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x168A8C8", Offset = "0x168A8C8", VA = "0x168A8C8")]
	private void CubeLoadSuccess(object parm)
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x168A9C8", Offset = "0x168A9C8", VA = "0x168A9C8")]
	public PrefabInstance FindPrefab(string id)
	{
		return null;
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x168AAC4", Offset = "0x168AAC4", VA = "0x168AAC4", Slot = "4")]
	public virtual void InitCube()
	{
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x168B998", Offset = "0x168B998", VA = "0x168B998")]
	private void InitShowPanel(string baseUrl)
	{
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x1689498", Offset = "0x1689498", VA = "0x1689498")]
	public void InitData()
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x168C294", Offset = "0x168C294", VA = "0x168C294")]
	private void GetClass(string className)
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x168C398", Offset = "0x168C398", VA = "0x168C398")]
	private CubeRoot CheckDragCube(Hand hand)
	{
		return null;
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x168C804", Offset = "0x168C804", VA = "0x168C804")]
	public void Drag(Hand hand, CubeRoot root)
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x168CF8C", Offset = "0x168CF8C", VA = "0x168CF8C")]
	public bool CheckHandInRoot(Hand hand)
	{
		return default(bool);
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x168D21C", Offset = "0x168D21C", VA = "0x168D21C")]
	public void Drop(Hand hand)
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x168D778", Offset = "0x168D778", VA = "0x168D778")]
	private void Assemble(Cube cubeMain, CubeRoot cubeRoot, [Optional] Hand hand)
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x168ED84", Offset = "0x168ED84", VA = "0x168ED84", Slot = "5")]
	public virtual void EffectOfLastTwo(CubeRoot cubeRoot, Cube cube)
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x168EF60", Offset = "0x168EF60", VA = "0x168EF60", Slot = "6")]
	public virtual void EffectOfAssembleFinish(CubeRoot cubeRoot, Cube cube)
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x168F12C", Offset = "0x168F12C", VA = "0x168F12C", Slot = "7")]
	public virtual void AssembleFinish()
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x168F130", Offset = "0x168F130", VA = "0x168F130")]
	private int GetStageGroupId(int stageId)
	{
		return default(int);
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x168E9D0", Offset = "0x168E9D0", VA = "0x168E9D0")]
	private void ShowTransDoor()
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x168CAF8", Offset = "0x168CAF8", VA = "0x168CAF8")]
	private void AddDragSignalRoots(CubeRoot root)
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x168E654", Offset = "0x168E654", VA = "0x168E654")]
	private void RemoveDragSignalRoots(CubeRoot root)
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x168F654", Offset = "0x168F654", VA = "0x168F654")]
	public void OrganizeItems(object parm)
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x168FAA8", Offset = "0x168FAA8", VA = "0x168FAA8")]
	public void Pull(Hand hand, float btnDistance)
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x1690220", Offset = "0x1690220", VA = "0x1690220")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6753F4", Offset = "0x6753F4")]
	private IEnumerator CheckPulledCube(Hand hand, string RootId)
	{
		return null;
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x16902C8", Offset = "0x16902C8", VA = "0x16902C8")]
	public void InsertPulledCube(Hand hand, string RootId)
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0x168CA60", Offset = "0x168CA60", VA = "0x168CA60")]
	protected void PlaySound(string name)
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x168A60C", Offset = "0x168A60C", VA = "0x168A60C")]
	private void PlayBGM()
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x1690644", Offset = "0x1690644", VA = "0x1690644")]
	public void OnExitGame(Action action)
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x168E778", Offset = "0x168E778", VA = "0x168E778")]
	private void RefreshProgress()
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x1690B54", Offset = "0x1690B54", VA = "0x1690B54")]
	public void AddCubeColliderData(object parm)
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x168CC1C", Offset = "0x168CC1C", VA = "0x168CC1C")]
	public void ClearCubeColliderData()
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x1690D38", Offset = "0x1690D38", VA = "0x1690D38")]
	public CubeManager()
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x1690F60", Offset = "0x1690F60", VA = "0x1690F60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675454", Offset = "0x675454")]
	private void <PortalLoadSuccess>b__23_1(object parm)
	{
	}
}
[Token(Token = "0x2000097")]
public class GMmgr : MonoBehaviour
{
	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject appConsole;

	[Token(Token = "0x6000347")]
	[Address(RVA = "0x95732C", Offset = "0x95732C", VA = "0x95732C")]
	private void OpenAppConsole(object obj)
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x957448", Offset = "0x957448", VA = "0x957448")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x9575F8", Offset = "0x9575F8", VA = "0x9575F8")]
	public GMmgr()
	{
	}
}
[Token(Token = "0x2000098")]
public class GameDefind
{
	[Token(Token = "0x600034A")]
	[Address(RVA = "0x957600", Offset = "0x957600", VA = "0x957600")]
	public GameDefind()
	{
	}
}
[Token(Token = "0x2000099")]
public class CubeData
{
	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string id;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 pos;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector4 defaultRotation;

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x167BB5C", Offset = "0x167BB5C", VA = "0x167BB5C")]
	public CubeData()
	{
	}
}
[Token(Token = "0x200009A")]
public class AttachData : CubeData
{
	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string audioUrl;

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x167BB54", Offset = "0x167BB54", VA = "0x167BB54")]
	public AttachData()
	{
	}
}
[Token(Token = "0x200009B")]
public enum RootType
{
	[Token(Token = "0x4000254")]
	Item,
	[Token(Token = "0x4000255")]
	Show
}
[Token(Token = "0x200009C")]
public enum CubeState
{
	[Token(Token = "0x4000257")]
	Idle,
	[Token(Token = "0x4000258")]
	Hover,
	[Token(Token = "0x4000259")]
	Grag,
	[Token(Token = "0x400025A")]
	Pull,
	[Token(Token = "0x400025B")]
	Follow
}
[Token(Token = "0x200009D")]
public enum CubeRootType
{
	[Token(Token = "0x400025D")]
	Item,
	[Token(Token = "0x400025E")]
	Show
}
[Token(Token = "0x200009E")]
public enum CompleteLevel
{
	[Token(Token = "0x4000260")]
	Undone,
	[Token(Token = "0x4000261")]
	Beginner,
	[Token(Token = "0x4000262")]
	Advanced,
	[Token(Token = "0x4000263")]
	Master
}
[Token(Token = "0x200009F")]
public static class GAME_UTILS
{
	[Token(Token = "0x600034D")]
	[Address(RVA = "0x956DF0", Offset = "0x956DF0", VA = "0x956DF0")]
	public static string FirstCharToUpper(string str)
	{
		return null;
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x956ED8", Offset = "0x956ED8", VA = "0x956ED8")]
	public static Vector3 GetCenterPos(Transform transform_)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x956FB4", Offset = "0x956FB4", VA = "0x956FB4")]
	public static float RoundTwoDecimal(float T)
	{
		return default(float);
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x956FF8", Offset = "0x956FF8", VA = "0x956FF8")]
	private static bool PointIsInsideMeshCollider(Collider c, Vector3 p)
	{
		return default(bool);
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x957288", Offset = "0x957288", VA = "0x957288")]
	public static bool IsInterCollider(Collider[] colliders, Vector3 point)
	{
		return default(bool);
	}
}
[Token(Token = "0x20000A0")]
public class GuideManager : CubeManager
{
	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674308", Offset = "0x674308")]
	private sealed class <>c__DisplayClass17_0
	{
		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Count;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GuideManager <>4__this;

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xC4F024", Offset = "0xC4F024", VA = "0xC4F024")]
		public <>c__DisplayClass17_0()
		{
		}
	}

	[Token(Token = "0x20000A2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674318", Offset = "0x674318")]
	private sealed class <>c__DisplayClass17_1
	{
		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CubeRoot comRoot;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public XRGrabInteractable xrGrab;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int tempIndex;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject cubeRoot;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public <>c__DisplayClass17_0 CS$<>8__locals1;

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xC4F02C", Offset = "0xC4F02C", VA = "0xC4F02C")]
		public <>c__DisplayClass17_1()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xC4F034", Offset = "0xC4F034", VA = "0xC4F034")]
		internal void <InitCube>b__0()
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x20000A3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674328", Offset = "0x674328")]
	private struct <InitCube>d__17 : IAsyncStateMachine
	{
		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GuideManager <>4__this;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private <>c__DisplayClass17_0 <>8__1;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private <>c__DisplayClass17_1 <>8__2;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int <i>5__2;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xC4F28C", Offset = "0xC4F28C", VA = "0xC4F28C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xC504F0", Offset = "0xC504F0", VA = "0xC504F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x20000A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674338", Offset = "0x674338")]
	private sealed class <>c__DisplayClass19_0
	{
		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Cube cube;

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xC4F258", Offset = "0xC4F258", VA = "0xC4F258")]
		public <>c__DisplayClass19_0()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xC4F260", Offset = "0xC4F260", VA = "0xC4F260")]
		internal bool <PlayFlyAnim>b__0(CubeData item)
		{
			return default(bool);
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x20000A5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674348", Offset = "0x674348")]
	private struct <PlayFlyAnim>d__19 : IAsyncStateMachine
	{
		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CubeRoot root;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GuideManager <>4__this;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xC504FC", Offset = "0xC504FC", VA = "0xC504FC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xC50CF4", Offset = "0xC50CF4", VA = "0xC50CF4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject[] CreateNode;

	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public GameObject[] DestNode;

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public GameObject[] CenterNode_0;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public GameObject[] CenterNode_1;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public GameObject FlyEffct;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public GameObject BookBeginPos;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public GameObject BookDestPos;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public float FlyTime;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	public int FlyDelayTime;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public GameObject Book;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public Ease EaseFly;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	public int FlyToBeginTime;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public int FlyToDestTime;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x674B3C", Offset = "0x674B3C")]
	public string[] flyAudios;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public string[] flyEndAudios;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public Ease EaseFlyEnd;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private GameObject Intro;

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x958EB4", Offset = "0x958EB4", VA = "0x958EB4", Slot = "4")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6754B4", Offset = "0x6754B4")]
	public override void InitCube()
	{
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x958F8C", Offset = "0x958F8C", VA = "0x958F8C", Slot = "7")]
	public override void AssembleFinish()
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x95921C", Offset = "0x95921C", VA = "0x95921C")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x675514", Offset = "0x675514")]
	private void PlayFlyAnim(CubeRoot root)
	{
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x95931C", Offset = "0x95931C", VA = "0x95931C")]
	private void update()
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x959320", Offset = "0x959320", VA = "0x959320")]
	public GuideManager()
	{
	}
}
[Token(Token = "0x20000A6")]
public class Hand : BaseHand
{
	[Token(Token = "0x20000A7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674358", Offset = "0x674358")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Cube cube;

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xC50D00", Offset = "0xC50D00", VA = "0xC50D00")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xC50D08", Offset = "0xC50D08", VA = "0xC50D08")]
		internal bool <IsInsertedRoot>b__0(Cube item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674368", Offset = "0x674368")]
	private sealed class <>c__DisplayClass25_0
	{
		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Cube cube;

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xC50D80", Offset = "0xC50D80", VA = "0xC50D80")]
		public <>c__DisplayClass25_0()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xC50D88", Offset = "0xC50D88", VA = "0xC50D88")]
		internal bool <InsertDragRoot>b__0(Cube item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000A9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674378", Offset = "0x674378")]
	private sealed class <>c__DisplayClass26_0
	{
		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Cube cube;

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xC50E00", Offset = "0xC50E00", VA = "0xC50E00")]
		public <>c__DisplayClass26_0()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xC50E08", Offset = "0xC50E08", VA = "0xC50E08")]
		internal bool <RemoveDragRoot>b__0(Cube item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private XRRayInteractor m_xrRay;

	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private CubeManager m_cubeManager;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private EventHandel eventHandel;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public bool isHold;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private CubeRoot m_holdCubeRoot;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private CubeRoot m_DragByTriggerEnd;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public List<Cube> DragCube;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Transform reticle;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private RayLine rayLine;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private CubeRoot preDragCubeRoot;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool bIsFollowCube;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	private bool bIsCanPress;

	[Token(Token = "0x17000075")]
	public CubeRoot HoldCubeRoot
	{
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x9593AC", Offset = "0x9593AC", VA = "0x9593AC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x9593B4", Offset = "0x9593B4", VA = "0x9593B4")]
		set
		{
		}
	}

	[Token(Token = "0x17000076")]
	public bool IsFollowHand
	{
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x9593BC", Offset = "0x9593BC", VA = "0x9593BC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x9593C4", Offset = "0x9593C4", VA = "0x9593C4")]
		set
		{
		}
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x9593D0", Offset = "0x9593D0", VA = "0x9593D0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x959850", Offset = "0x959850", VA = "0x959850")]
	private void SetHandPress(object obj)
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x9598D4", Offset = "0x9598D4", VA = "0x9598D4")]
	public void HideXrRay(object parm)
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x9598F4", Offset = "0x9598F4", VA = "0x9598F4")]
	public void ShowXrRay(object parm)
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x959914", Offset = "0x959914", VA = "0x959914")]
	public void InitCubeManager(object parm)
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x959A68", Offset = "0x959A68", VA = "0x959A68")]
	public void ClearEvent(object parm)
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x959DDC", Offset = "0x959DDC", VA = "0x959DDC")]
	public bool IsInsertedRoot(Cube cube)
	{
		return default(bool);
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x959F28", Offset = "0x959F28", VA = "0x959F28")]
	public void InsertDragRoot(Cube cube)
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x95A0EC", Offset = "0x95A0EC", VA = "0x95A0EC")]
	public void RemoveDragRoot(Cube cube)
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x95A444", Offset = "0x95A444", VA = "0x95A444")]
	public CubeRoot GetDragRoot()
	{
		return null;
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x959BAC", Offset = "0x959BAC", VA = "0x959BAC")]
	private void RefreshLine()
	{
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x95A704", Offset = "0x95A704", VA = "0x95A704")]
	public void DragCubeRoot(CubeRoot root)
	{
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x95A7F8", Offset = "0x95A7F8", VA = "0x95A7F8", Slot = "5")]
	public override void OnTriggerDevice(float triggerValue)
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x95AC20", Offset = "0x95AC20", VA = "0x95AC20", Slot = "4")]
	public override void OnTriggerPress()
	{
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x95ADD8", Offset = "0x95ADD8", VA = "0x95ADD8")]
	public void OrganizeItems(object parm)
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x95AF34", Offset = "0x95AF34", VA = "0x95AF34")]
	public CubeRoot PreDragCubeRoot()
	{
		return null;
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0x95AF3C", Offset = "0x95AF3C", VA = "0x95AF3C")]
	public void InsertPreDragCubeRoot(CubeRoot root)
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x95B018", Offset = "0x95B018", VA = "0x95B018")]
	public void RemovePreDragCubeRoot(CubeRoot root)
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x95A33C", Offset = "0x95A33C", VA = "0x95A33C")]
	public void ClearPreDragCubeRoot()
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0x95B1F0", Offset = "0x95B1F0", VA = "0x95B1F0", Slot = "6")]
	public override void OnPrimary2DAxis(Vector2 value)
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0x95B1F4", Offset = "0x95B1F4", VA = "0x95B1F4", Slot = "7")]
	public override void onPrimary2DPress()
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0x95B298", Offset = "0x95B298", VA = "0x95B298")]
	public void HandHaptic(float value = 0.4f, float duration = 0.3f)
	{
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0x95B318", Offset = "0x95B318", VA = "0x95B318")]
	public void HandHapticStrong(object pram)
	{
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0x95B388", Offset = "0x95B388", VA = "0x95B388", Slot = "8")]
	public override void onResetHand()
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0x95B4BC", Offset = "0x95B4BC", VA = "0x95B4BC")]
	public Hand()
	{
	}
}
[Token(Token = "0x20000AA")]
public class CheckChangeTest : MonoBehaviour
{
	[Token(Token = "0x6000383")]
	[Address(RVA = "0x1683774", Offset = "0x1683774", VA = "0x1683774")]
	public CheckChangeTest()
	{
	}
}
[Token(Token = "0x20000AB")]
public class CubeColliderCreate : MonoBehaviour
{
	[Token(Token = "0x6000384")]
	[Address(RVA = "0x16869A0", Offset = "0x16869A0", VA = "0x16869A0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x1686B7C", Offset = "0x1686B7C", VA = "0x1686B7C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x1686B80", Offset = "0x1686B80", VA = "0x1686B80")]
	public CubeColliderCreate()
	{
	}
}
[Token(Token = "0x20000AC")]
public class CubeTest : MonoBehaviour
{
	[Token(Token = "0x20000AD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674388", Offset = "0x674388")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xC4CE34", Offset = "0xC4CE34", VA = "0xC4CE34")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xC4CE3C", Offset = "0xC4CE3C", VA = "0xC4CE3C")]
		internal bool <OnCollisionEnter>b__0(string item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674398", Offset = "0x674398")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xC4CE50", Offset = "0xC4CE50", VA = "0xC4CE50")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xC4CE58", Offset = "0xC4CE58", VA = "0xC4CE58")]
		internal bool <OnTriggerEnter>b__0(string item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<string> colliderNames;

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x9541FC", Offset = "0x9541FC", VA = "0x9541FC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0x954200", Offset = "0x954200", VA = "0x954200")]
	private void Update()
	{
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x954204", Offset = "0x954204", VA = "0x954204")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x95442C", Offset = "0x95442C", VA = "0x95442C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x95463C", Offset = "0x95463C", VA = "0x95463C")]
	public CubeTest()
	{
	}
}
[Token(Token = "0x20000AF")]
public class ExportData : MonoBehaviour
{
	[Token(Token = "0x6000390")]
	[Address(RVA = "0x955BA4", Offset = "0x955BA4", VA = "0x955BA4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0x955C64", Offset = "0x955C64", VA = "0x955C64")]
	public void CheckTargetDirForMe(Transform target, Transform self)
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0x9563A4", Offset = "0x9563A4", VA = "0x9563A4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0x9563A8", Offset = "0x9563A8", VA = "0x9563A8")]
	public ExportData()
	{
	}
}
[Token(Token = "0x20000B0")]
public class BackUpWindow : UIWindow
{
	[Serializable]
	[Token(Token = "0x20000B1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6743A8", Offset = "0x6743A8")]
	private sealed class <>c
	{
		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action <>9__0_0;

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xC4B404", Offset = "0xC4B404", VA = "0xC4B404")]
		public <>c()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xC4B40C", Offset = "0xC4B40C", VA = "0xC4B40C")]
		internal void <OnOpen>b__0_0()
		{
		}
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0x167ECCC", Offset = "0x167ECCC", VA = "0x167ECCC", Slot = "8")]
	public override void OnOpen(object args)
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0x167EE44", Offset = "0x167EE44", VA = "0x167EE44")]
	public BackUpWindow()
	{
	}
}
[Token(Token = "0x20000B2")]
public class BookAniEvent : MonoBehaviour
{
	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityAction cb;

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x16804B0", Offset = "0x16804B0", VA = "0x16804B0")]
	public void OnOpened()
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x16804C4", Offset = "0x16804C4", VA = "0x16804C4")]
	public BookAniEvent()
	{
	}
}
[Token(Token = "0x20000B3")]
public class BookRoot : MonoBehaviour
{
	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public BookAniEvent bookEvent;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public BookManager bookManager;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x674B94", Offset = "0x674B94")]
	public float showTime;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Animation rootAnimation;

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x1681FFC", Offset = "0x1681FFC", VA = "0x1681FFC")]
	private void OnSceneLoadedAnimEnd(object obj)
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x1682018", Offset = "0x1682018", VA = "0x1682018")]
	private void OnBookOpened()
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0x1682040", Offset = "0x1682040", VA = "0x1682040")]
	private void Start()
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x1682224", Offset = "0x1682224", VA = "0x1682224")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x1682350", Offset = "0x1682350", VA = "0x1682350")]
	public BookRoot()
	{
	}
}
[Token(Token = "0x20000B4")]
public class ConfirmWindow : MonoBehaviour
{
	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Button confirmBtn;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Button cancelBtn;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UnityAction onConfirmCb;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public LanguageText tipText;

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x168490C", Offset = "0x168490C", VA = "0x168490C")]
	private void Start()
	{
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x16849F8", Offset = "0x16849F8", VA = "0x16849F8")]
	public void SetConfirmData(UnityAction cb)
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x1684A00", Offset = "0x1684A00", VA = "0x1684A00")]
	public void SetFonet(int key)
	{
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x1684A1C", Offset = "0x1684A1C", VA = "0x1684A1C")]
	private void OnConfirm()
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x1684A64", Offset = "0x1684A64", VA = "0x1684A64")]
	public ConfirmWindow()
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x1684A6C", Offset = "0x1684A6C", VA = "0x1684A6C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675594", Offset = "0x675594")]
	private void <Start>b__4_0()
	{
	}
}
[Token(Token = "0x20000B5")]
public class LevelWindow : UIWindow
{
	[Token(Token = "0x20000B6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6743B8", Offset = "0x6743B8")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LevelWindow <>4__this;

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xC50F1C", Offset = "0xC50F1C", VA = "0xC50F1C")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xC50F24", Offset = "0xC50F24", VA = "0xC50F24")]
		internal void <CreateLevel>b__3()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20000B7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6743C8", Offset = "0x6743C8")]
	private sealed class <>c
	{
		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<int> <>9__3_2;

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xC50EE4", Offset = "0xC50EE4", VA = "0xC50EE4")]
		public <>c()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xC50EEC", Offset = "0xC50EEC", VA = "0xC50EEC")]
		internal int <CreateLevel>b__3_2(int x, int y)
		{
			return default(int);
		}
	}

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject btn_go;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int chooseId;

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x95EF54", Offset = "0x95EF54", VA = "0x95EF54", Slot = "8")]
	public override void OnOpen(object args)
	{
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x95EFD0", Offset = "0x95EFD0", VA = "0x95EFD0")]
	private void CreateLevel()
	{
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x95F880", Offset = "0x95F880", VA = "0x95F880")]
	public void OnChoseLevel(int id)
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x95F974", Offset = "0x95F974", VA = "0x95F974")]
	public void OnStartGame(bool isRestart)
	{
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x95FE0C", Offset = "0x95FE0C", VA = "0x95FE0C")]
	public LevelWindow()
	{
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x95FE14", Offset = "0x95FE14", VA = "0x95FE14")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6755A4", Offset = "0x6755A4")]
	private void <CreateLevel>b__3_0()
	{
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x95FE1C", Offset = "0x95FE1C", VA = "0x95FE1C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6755B4", Offset = "0x6755B4")]
	private void <CreateLevel>b__3_1()
	{
	}
}
[Token(Token = "0x20000B8")]
public class OrganizeItemsWindow : UIWindow
{
	[Serializable]
	[Token(Token = "0x20000B9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6743D8", Offset = "0x6743D8")]
	private sealed class <>c
	{
		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action <>9__0_0;

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xC513C4", Offset = "0xC513C4", VA = "0xC513C4")]
		public <>c()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xC513CC", Offset = "0xC513CC", VA = "0xC513CC")]
		internal void <OnOpen>b__0_0()
		{
		}
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x962DDC", Offset = "0x962DDC", VA = "0x962DDC", Slot = "8")]
	public override void OnOpen(object args)
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x962F54", Offset = "0x962F54", VA = "0x962F54")]
	public OrganizeItemsWindow()
	{
	}
}
[Token(Token = "0x20000BA")]
public class PullGuideWindow : UIWindow
{
	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x966E24", Offset = "0x966E24", VA = "0x966E24")]
	public PullGuideWindow()
	{
	}
}
[Token(Token = "0x20000BB")]
public class ThemeAnimEvent : MonoBehaviour
{
	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Dictionary<string, Action> callbackDic;

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x94AFDC", Offset = "0x94AFDC", VA = "0x94AFDC")]
	private void OnActionEnd(string key)
	{
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x94B0F8", Offset = "0x94B0F8", VA = "0x94B0F8")]
	public ThemeAnimEvent()
	{
	}
}
[Token(Token = "0x20000BC")]
public class ThemeData
{
	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool completed;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string modleName;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string Image_level;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int stageGroupId;

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x94BB78", Offset = "0x94BB78", VA = "0x94BB78")]
	public ThemeData(bool completed)
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x94BBA8", Offset = "0x94BBA8", VA = "0x94BBA8")]
	public ThemeData(string modleName, string Image_level, int stageGroupId)
	{
	}
}
[Token(Token = "0x20000BD")]
public class ThemeObjInteraction : MonoBehaviour
{
	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private EventHandel eventHandel;

	[Token(Token = "0x40002B4")]
	private const float scaleSize = 1.5f;

	[Token(Token = "0x40002B5")]
	private const float doTweenCostTime = 0.3f;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform hoverObj;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<Transform, Vector3> orgScaleDic;

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x94BC0C", Offset = "0x94BC0C", VA = "0x94BC0C")]
	private void OnHoverEntered(Transform interactor, Transform hands)
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x94BD04", Offset = "0x94BD04", VA = "0x94BD04")]
	private void OnHoverExited(Transform interactor, Transform hands)
	{
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x94BDF4", Offset = "0x94BDF4", VA = "0x94BDF4")]
	private void OnTriggerEvent(float value, XRRayInteractor hands, Transform handTrans)
	{
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x94BF08", Offset = "0x94BF08", VA = "0x94BF08")]
	public void InitOrgData()
	{
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x94BF0C", Offset = "0x94BF0C", VA = "0x94BF0C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x94C1BC", Offset = "0x94C1BC", VA = "0x94C1BC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x94C3DC", Offset = "0x94C3DC", VA = "0x94C3DC")]
	public ThemeObjInteraction()
	{
	}
}
[Token(Token = "0x20000BE")]
public enum HoverType
{
	[Token(Token = "0x40002B9")]
	spotlight,
	[Token(Token = "0x40002BA")]
	fresnel
}
[Token(Token = "0x20000BF")]
public class ThemeProgressLabel : MonoBehaviour
{
	[Token(Token = "0x20000C0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6743E8", Offset = "0x6743E8")]
	private sealed class <PlayIdelCoroutine>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ThemeProgressLabel <>4__this;

		[Token(Token = "0x17000078")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0xC54C94", Offset = "0xC54C94", VA = "0xC54C94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0xC54CDC", Offset = "0xC54CDC", VA = "0xC54CDC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xC54B94", Offset = "0xC54B94", VA = "0xC54B94")]
		[DebuggerHidden]
		public <PlayIdelCoroutine>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xC54BC0", Offset = "0xC54BC0", VA = "0xC54BC0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xC54BC4", Offset = "0xC54BC4", VA = "0xC54BC4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xC54C9C", Offset = "0xC54C9C", VA = "0xC54C9C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject model;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParticleSystem particleSys;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Image Image_level;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string dragAudio;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public HoverType hoverType;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject spotlight;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Renderer[] fresnelSkinnedMeshs;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private EventHandel eventHandel;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Animator animator;

	[Token(Token = "0x40002C4")]
	private const string idel = "idel";

	[Token(Token = "0x40002C5")]
	private const string action = "action";

	[Token(Token = "0x40002C6")]
	private const float idelTimeMin = 8f;

	[Token(Token = "0x40002C7")]
	private const float idelTimeMax = 26f;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Transform hoverObj;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool isHover;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ThemeData themeData;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<string> hoverHandList;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool playingAction;

	[Token(Token = "0x17000077")]
	private bool isAnimAction
	{
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x94C60C", Offset = "0x94C60C", VA = "0x94C60C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x94C460", Offset = "0x94C460", VA = "0x94C460")]
	private void PlayAction()
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x94C6F4", Offset = "0x94C6F4", VA = "0x94C6F4")]
	private void PlayAmin(string anim)
	{
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x94C820", Offset = "0x94C820", VA = "0x94C820")]
	private void PlayIdel()
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x94C8C8", Offset = "0x94C8C8", VA = "0x94C8C8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6755C4", Offset = "0x6755C4")]
	private IEnumerator PlayIdelCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x94C940", Offset = "0x94C940", VA = "0x94C940")]
	private void SetActionAnimEvent()
	{
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x94CBA4", Offset = "0x94CBA4", VA = "0x94CBA4")]
	private void ObjHoverEntered(HoverEnterEventArgs hoverEnterEventArgs)
	{
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x94D018", Offset = "0x94D018", VA = "0x94D018")]
	private void ObjHoverExited(HoverExitEventArgs hoverExitEventArgs)
	{
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x94CEB8", Offset = "0x94CEB8", VA = "0x94CEB8")]
	private void SetMaterialEffect(GameObject obj, bool isEnable, string Attribute = "_fresnelOFF")
	{
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x94CE20", Offset = "0x94CE20", VA = "0x94CE20")]
	private void SetSpotlight()
	{
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x94D228", Offset = "0x94D228", VA = "0x94D228")]
	private void OnTriggerEvent(float value, XRRayInteractor hands, Transform handTrans)
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x94C798", Offset = "0x94C798", VA = "0x94C798")]
	private void PlayAudio()
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x93C1C0", Offset = "0x93C1C0", VA = "0x93C1C0")]
	public void OnSceneLoaded(object stageId)
	{
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x94D358", Offset = "0x94D358", VA = "0x94D358")]
	private void PlaySceneLoadedAction(object stageId)
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x94D3FC", Offset = "0x94D3FC", VA = "0x94D3FC")]
	public void SetData(ThemeData themeData)
	{
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x94D914", Offset = "0x94D914", VA = "0x94D914")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x94DC08", Offset = "0x94DC08", VA = "0x94DC08")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x94DD88", Offset = "0x94DD88", VA = "0x94DD88")]
	public ThemeProgressLabel()
	{
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x94DE0C", Offset = "0x94DE0C", VA = "0x94DE0C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675624", Offset = "0x675624")]
	private void <SetActionAnimEvent>b__24_0()
	{
	}
}
[Token(Token = "0x20000C1")]
public class ThemeProgressMgr : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000C2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6743F8", Offset = "0x6743F8")]
	private sealed class <>c
	{
		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<StageGroupCfg> <>9__10_0;

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xC54D48", Offset = "0xC54D48", VA = "0xC54D48")]
		public <>c()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xC54D50", Offset = "0xC54D50", VA = "0xC54D50")]
		internal int <InitData>b__10_0(StageGroupCfg v1, StageGroupCfg v2)
		{
			return default(int);
		}
	}

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<ThemeProgressLabel> themeProgressLabelList;

	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource audioSource;

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private EventHandel eventHandel;

	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<Transform, Vector3> orgScaleDic;

	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform hoverObj;

	[Token(Token = "0x60003DC")]
	public static T GetOrAddComponent<T>(GameObject obj) where T : Component
	{
		return null;
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x94DEC8", Offset = "0x94DEC8", VA = "0x94DEC8")]
	private void OnTriggerEvent(float value, XRRayInteractor hands, Transform handTrans)
	{
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x94DF98", Offset = "0x94DF98", VA = "0x94DF98")]
	private void SetMaterialEffect(GameObject obj, bool isEnable, string Attribute = "_fresnelOFF")
	{
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x94E0BC", Offset = "0x94E0BC", VA = "0x94E0BC")]
	private void OnClickBackBrn()
	{
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x94E0E4", Offset = "0x94E0E4", VA = "0x94E0E4")]
	private void PlayBgm(ThemeCfg themeCfg)
	{
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x94E154", Offset = "0x94E154", VA = "0x94E154")]
	public void InitData(ThemeCfg themeCfg)
	{
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x94E898", Offset = "0x94E898", VA = "0x94E898")]
	public void BackToMainScene()
	{
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x94E704", Offset = "0x94E704", VA = "0x94E704")]
	public void InitThemeList(List<ThemeData> themeData)
	{
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x94E8C0", Offset = "0x94E8C0", VA = "0x94E8C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x94ECA0", Offset = "0x94ECA0", VA = "0x94ECA0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x94EDC4", Offset = "0x94EDC4", VA = "0x94EDC4")]
	public ThemeProgressMgr()
	{
	}
}
[Token(Token = "0x20000C3")]
public class TweenObjOrgData : MonoBehaviour
{
	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 _orgScale;

	[Token(Token = "0x1700007A")]
	public Vector3 orgScale
	{
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x94F09C", Offset = "0x94F09C", VA = "0x94F09C")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x94F0A8", Offset = "0x94F0A8", VA = "0x94F0A8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x94F0E4", Offset = "0x94F0E4", VA = "0x94F0E4")]
	public TweenObjOrgData()
	{
	}
}
[Serializable]
[Token(Token = "0x20000C4")]
public class CubeModel : BaseModel
{
	[Token(Token = "0x20000C5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674408", Offset = "0x674408")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Id;

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xC4CAAC", Offset = "0xC4CAAC", VA = "0xC4CAAC")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xC4CAB4", Offset = "0xC4CAB4", VA = "0xC4CAB4")]
		internal bool <ClearDataById>b__0(CubeModeData item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000C6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674418", Offset = "0x674418")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Id;

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xC4CAD8", Offset = "0xC4CAD8", VA = "0xC4CAD8")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xC4CAE0", Offset = "0xC4CAE0", VA = "0xC4CAE0")]
		internal bool <AssembleItems>b__0(CubeModeData item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000C7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674428", Offset = "0x674428")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Id;

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xC4CB04", Offset = "0xC4CB04", VA = "0xC4CB04")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xC4CB0C", Offset = "0xC4CB0C", VA = "0xC4CB0C")]
		internal bool <UpdateTransform>b__0(CubeModeData item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674438", Offset = "0x674438")]
	private sealed class <>c__DisplayClass11_0
	{
		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Id;

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xC4CA80", Offset = "0xC4CA80", VA = "0xC4CA80")]
		public <>c__DisplayClass11_0()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xC4CA88", Offset = "0xC4CA88", VA = "0xC4CA88")]
		internal bool <GetDataById>b__0(CubeModeData item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<CubeModeData> listData;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<string> m_arrDragSingalRoots;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string name;

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 ooo;

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string isUsePull;

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x1691128", Offset = "0x1691128", VA = "0x1691128", Slot = "6")]
	public override void Init()
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x168C020", Offset = "0x168C020", VA = "0x168C020")]
	public void InsertData(string Id, string cubeId, Vector3 pos, Quaternion rotation, int planeIndex)
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x168E51C", Offset = "0x168E51C", VA = "0x168E51C")]
	public void ClearDataById(string Id)
	{
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x168E304", Offset = "0x168E304", VA = "0x168E304")]
	public void AssembleItems(string Id, List<Cube> cubes)
	{
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x168E1B4", Offset = "0x168E1B4", VA = "0x168E1B4")]
	public void UpdateTransform(string Id, Transform transform, int planeIndex = -1)
	{
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x169112C", Offset = "0x169112C", VA = "0x169112C")]
	public void ToJson()
	{
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x168C198", Offset = "0x168C198", VA = "0x168C198")]
	public CubeModeData GetDataById(string Id)
	{
		return null;
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x1688C04", Offset = "0x1688C04", VA = "0x1688C04")]
	public CubeModel()
	{
	}
}
[Serializable]
[Token(Token = "0x20000C9")]
public class CubeModeData
{
	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string Id;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<string> arrCubeName;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 position;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Quaternion rotation;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int planeIndex;

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0x1691120", Offset = "0x1691120", VA = "0x1691120")]
	public CubeModeData()
	{
	}
}
[Token(Token = "0x20000CA")]
public class GameSceneModel : BaseModel
{
	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public new static string modelName;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674BCC", Offset = "0x674BCC")]
	private SceneData <sceneData>k__BackingField;

	[Token(Token = "0x1700007B")]
	public override string ModelName
	{
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x958CC8", Offset = "0x958CC8", VA = "0x958CC8", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x958D2C", Offset = "0x958D2C", VA = "0x958D2C", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x1700007C")]
	public SceneData sceneData
	{
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x958D98", Offset = "0x958D98", VA = "0x958D98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675684", Offset = "0x675684")]
		get
		{
			return default(SceneData);
		}
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x958DA4", Offset = "0x958DA4", VA = "0x958DA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675694", Offset = "0x675694")]
		set
		{
		}
	}

	[Token(Token = "0x1700007D")]
	public string sceneName
	{
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x958DB4", Offset = "0x958DB4", VA = "0x958DB4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700007E")]
	public int stageId
	{
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x958DBC", Offset = "0x958DBC", VA = "0x958DBC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700007F")]
	public bool isRestart
	{
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x958DC4", Offset = "0x958DC4", VA = "0x958DC4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0x958DD4", Offset = "0x958DD4", VA = "0x958DD4", Slot = "6")]
	public override void Init()
	{
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0x958DDC", Offset = "0x958DDC", VA = "0x958DDC", Slot = "7")]
	public override void Destroy()
	{
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0x958DE4", Offset = "0x958DE4", VA = "0x958DE4")]
	public GameSceneModel()
	{
	}
}
[Token(Token = "0x20000CB")]
public class LoginModel : BaseModel
{
	[Token(Token = "0x20000CC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674448", Offset = "0x674448")]
	private sealed class <SendLoginMsg>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LoginModel <>4__this;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UnityWebRequest <www>5__2;

		[Token(Token = "0x17000082")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000414")]
			[Address(RVA = "0xC51310", Offset = "0xC51310", VA = "0xC51310", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000416")]
			[Address(RVA = "0xC51358", Offset = "0xC51358", VA = "0xC51358", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xC50F48", Offset = "0xC50F48", VA = "0xC50F48")]
		[DebuggerHidden]
		public <SendLoginMsg>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xC50F74", Offset = "0xC50F74", VA = "0xC50F74", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xC50F78", Offset = "0xC50F78", VA = "0xC50F78", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xC51318", Offset = "0xC51318", VA = "0xC51318", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public new static string modelName;

	[Token(Token = "0x17000080")]
	public override string ModelName
	{
		[Token(Token = "0x6000409")]
		[Address(RVA = "0x960004", Offset = "0x960004", VA = "0x960004", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600040A")]
		[Address(RVA = "0x960068", Offset = "0x960068", VA = "0x960068", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000081")]
	private string reportUrl
	{
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x9600D4", Offset = "0x9600D4", VA = "0x9600D4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0x960118", Offset = "0x960118", VA = "0x960118", Slot = "6")]
	public override void Init()
	{
	}

	[Token(Token = "0x600040D")]
	[Address(RVA = "0x960120", Offset = "0x960120", VA = "0x960120")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6756A4", Offset = "0x6756A4")]
	public IEnumerator SendLoginMsg()
	{
		return null;
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0x960198", Offset = "0x960198", VA = "0x960198")]
	public void LoginBackMsg(object msg)
	{
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0x960384", Offset = "0x960384", VA = "0x960384")]
	public LoginModel()
	{
	}
}
[Serializable]
[Token(Token = "0x20000CD")]
public class PlayerDataModel : BaseModel
{
	[Token(Token = "0x20000CE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674458", Offset = "0x674458")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int nStageId;

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xC516D8", Offset = "0xC516D8", VA = "0xC516D8")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xC516E0", Offset = "0xC516E0", VA = "0xC516E0")]
		internal bool <RefreshStageInfo>b__0(StageInfo item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000CF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674468", Offset = "0x674468")]
	private sealed class <SendStageMsg>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlayerDataModel <>4__this;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int nStageId;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UnityWebRequest <www>5__2;

		[Token(Token = "0x17000086")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0xC51C3C", Offset = "0xC51C3C", VA = "0xC51C3C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000426")]
			[Address(RVA = "0xC51C84", Offset = "0xC51C84", VA = "0xC51C84", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xC51704", Offset = "0xC51704", VA = "0xC51704")]
		[DebuggerHidden]
		public <SendStageMsg>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xC51730", Offset = "0xC51730", VA = "0xC51730", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xC51734", Offset = "0xC51734", VA = "0xC51734", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xC51C44", Offset = "0xC51C44", VA = "0xC51C44", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public new static string modelName;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string playerId;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int currentThemeIndex;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<StageInfo> stageInfoList;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool showBookTips;

	[Token(Token = "0x17000084")]
	private string reportUrl
	{
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x9645A4", Offset = "0x9645A4", VA = "0x9645A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000085")]
	public override string ModelName
	{
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x964938", Offset = "0x964938", VA = "0x964938", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x96499C", Offset = "0x96499C", VA = "0x96499C", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0x9645E8", Offset = "0x9645E8", VA = "0x9645E8")]
	public void SetDefaultData()
	{
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0x9647CC", Offset = "0x9647CC", VA = "0x9647CC")]
	public void RefreshStageInfo(int nStageId, float fProgress)
	{
	}

	[Token(Token = "0x600041C")]
	[Address(RVA = "0x964A08", Offset = "0x964A08", VA = "0x964A08")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x675754", Offset = "0x675754")]
	public IEnumerator SendStageMsg(int nStageId)
	{
		return null;
	}

	[Token(Token = "0x600041D")]
	[Address(RVA = "0x964A90", Offset = "0x964A90", VA = "0x964A90")]
	public PlayerDataModel()
	{
	}
}
[Serializable]
[Token(Token = "0x20000D0")]
public class StageInfo
{
	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int stageId;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float stageProgress;

	[Token(Token = "0x6000427")]
	[Address(RVA = "0x941F78", Offset = "0x941F78", VA = "0x941F78")]
	public StageInfo()
	{
	}
}
[Serializable]
[Token(Token = "0x20000D1")]
public class UserModel : BaseModel
{
	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public new static string modelName;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string userId;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string nickname;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int guideId;

	[Token(Token = "0x17000088")]
	public override string ModelName
	{
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x9501D8", Offset = "0x9501D8", VA = "0x9501D8", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x95023C", Offset = "0x95023C", VA = "0x95023C", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x600042A")]
	[Address(RVA = "0x9502A8", Offset = "0x9502A8", VA = "0x9502A8")]
	public UserModel()
	{
	}
}
[Token(Token = "0x20000D2")]
public class PlayerController : MonoBehaviour
{
	[Token(Token = "0x20000D3")]
	public delegate void DelagateAni();

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static PlayerController _instance;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject MainCamera;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject TranltatePrefab;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Animator m_aniTransltate;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public DelagateAni EventStart;

	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public DelagateAni EventEnd;

	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674BDC", Offset = "0x674BDC")]
	private float <DeltaTime>k__BackingField;

	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly List<Action> onUpdates;

	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<Action> tempInvokeActions;

	[Token(Token = "0x17000089")]
	public float DeltaTime
	{
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x963C70", Offset = "0x963C70", VA = "0x963C70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675804", Offset = "0x675804")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x963C78", Offset = "0x963C78", VA = "0x963C78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675814", Offset = "0x675814")]
		private set
		{
		}
	}

	[Token(Token = "0x1700008A")]
	public static PlayerController instance
	{
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x963C80", Offset = "0x963C80", VA = "0x963C80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0x963CE4", Offset = "0x963CE4", VA = "0x963CE4")]
	public void RegisterUpdate(Action callback)
	{
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0x963D70", Offset = "0x963D70", VA = "0x963D70")]
	public void UnRegisterUpdate(Action callback)
	{
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0x963DFC", Offset = "0x963DFC", VA = "0x963DFC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0x963FFC", Offset = "0x963FFC", VA = "0x963FFC")]
	public void PlayStart()
	{
	}

	[Token(Token = "0x6000433")]
	[Address(RVA = "0x964114", Offset = "0x964114", VA = "0x964114")]
	public void PlayEnd()
	{
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0x9641C0", Offset = "0x9641C0", VA = "0x9641C0")]
	public void PlayStartEnd(object obj)
	{
	}

	[Token(Token = "0x6000435")]
	[Address(RVA = "0x9641D4", Offset = "0x9641D4", VA = "0x9641D4")]
	public void PlayEndEnd(object obj)
	{
	}

	[Token(Token = "0x6000436")]
	[Address(RVA = "0x964278", Offset = "0x964278", VA = "0x964278")]
	private void Update()
	{
	}

	[Token(Token = "0x6000437")]
	[Address(RVA = "0x9643A8", Offset = "0x9643A8", VA = "0x9643A8")]
	private void InvokeActions(List<Action> actions)
	{
	}

	[Token(Token = "0x6000438")]
	[Address(RVA = "0x964494", Offset = "0x964494", VA = "0x964494")]
	public PlayerController()
	{
	}
}
[Token(Token = "0x20000D4")]
public class SceneCameraPos : MonoBehaviour
{
	[Token(Token = "0x600043E")]
	[Address(RVA = "0x96C96C", Offset = "0x96C96C", VA = "0x96C96C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0x96CA20", Offset = "0x96CA20", VA = "0x96CA20")]
	public SceneCameraPos()
	{
	}
}
[Token(Token = "0x20000D5")]
public struct SceneData
{
	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string sceneName;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public int stageId;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public bool isRestart;
}
[Token(Token = "0x20000D6")]
public class TestVO
{
	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<int> list1;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Vector3> list2;

	[Token(Token = "0x6000440")]
	[Address(RVA = "0x949A74", Offset = "0x949A74", VA = "0x949A74")]
	public TestVO()
	{
	}
}
[Token(Token = "0x20000D7")]
public class Test : MonoBehaviour
{
	[Token(Token = "0x6000441")]
	[Address(RVA = "0x949500", Offset = "0x949500", VA = "0x949500")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000442")]
	[Address(RVA = "0x949588", Offset = "0x949588", VA = "0x949588")]
	private void Start()
	{
	}

	[Token(Token = "0x6000443")]
	[Address(RVA = "0x949748", Offset = "0x949748", VA = "0x949748")]
	public void TestAttrbute()
	{
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0x949870", Offset = "0x949870", VA = "0x949870")]
	public void testDataConfig()
	{
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0x949874", Offset = "0x949874", VA = "0x949874")]
	public void testJson()
	{
	}

	[Token(Token = "0x6000446")]
	[Address(RVA = "0x949A7C", Offset = "0x949A7C", VA = "0x949A7C")]
	public void testStaticConfigData()
	{
	}

	[Token(Token = "0x6000447")]
	[Address(RVA = "0x949A80", Offset = "0x949A80", VA = "0x949A80")]
	private void Update()
	{
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0x949A84", Offset = "0x949A84", VA = "0x949A84")]
	public Test()
	{
	}
}
[Serializable]
[Token(Token = "0x20000D8")]
public class TestModel : BaseModel
{
	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<string> nameList;

	[Token(Token = "0x6000449")]
	[Address(RVA = "0x949A8C", Offset = "0x949A8C", VA = "0x949A8C", Slot = "6")]
	public override void Init()
	{
	}

	[Token(Token = "0x600044A")]
	[Address(RVA = "0x949B10", Offset = "0x949B10", VA = "0x949B10", Slot = "7")]
	public override void Destroy()
	{
	}

	[Token(Token = "0x600044B")]
	[Address(RVA = "0x94980C", Offset = "0x94980C", VA = "0x94980C")]
	public TestModel()
	{
	}
}
[Token(Token = "0x20000D9")]
public class FirebasePlatform : IPlatform
{
	[Serializable]
	[Token(Token = "0x20000DA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674478", Offset = "0x674478")]
	private sealed class <>c
	{
		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<System.Threading.Tasks.Task<DependencyStatus>> <>9__1_0;

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xC4EB64", Offset = "0xC4EB64", VA = "0xC4EB64")]
		public <>c()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xC4EB6C", Offset = "0xC4EB6C", VA = "0xC4EB6C")]
		internal void <InitCrashlytics>b__1_0(System.Threading.Tasks.Task<DependencyStatus> task)
		{
		}
	}

	[Token(Token = "0x600044C")]
	[Address(RVA = "0x9563B0", Offset = "0x9563B0", VA = "0x9563B0", Slot = "4")]
	public override void InitSdk(SDKData sdkData)
	{
	}

	[Token(Token = "0x600044D")]
	[Address(RVA = "0x956424", Offset = "0x956424", VA = "0x956424")]
	private void InitCrashlytics()
	{
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0x956588", Offset = "0x956588", VA = "0x956588", Slot = "5")]
	public override void SetUserId(string userId)
	{
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x9565F0", Offset = "0x9565F0", VA = "0x9565F0", Slot = "7")]
	public override void SendState(string name, string parameterName, string parameterValue)
	{
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0x956670", Offset = "0x956670", VA = "0x956670", Slot = "6")]
	public override void SendState(string eventName, Dictionary<string, string> extraInfos)
	{
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0x956DE0", Offset = "0x956DE0", VA = "0x956DE0")]
	public FirebasePlatform()
	{
	}
}
[Token(Token = "0x20000DB")]
public class IAPManager : MonoBehaviour
{
	[Token(Token = "0x6000455")]
	[Address(RVA = "0x95B57C", Offset = "0x95B57C", VA = "0x95B57C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0x95B8CC", Offset = "0x95B8CC", VA = "0x95B8CC")]
	public void Getpurch()
	{
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0x95B994", Offset = "0x95B994", VA = "0x95B994")]
	public void PurchasesDurableCache(Oculus.Platform.Message<Oculus.Platform.Models.PurchaseList> msg)
	{
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0x95B5A8", Offset = "0x95B5A8", VA = "0x95B5A8")]
	public void FetchProductPrices()
	{
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0x95BEB8", Offset = "0x95BEB8", VA = "0x95BEB8")]
	private void OnAssetDeatilsLis(Oculus.Platform.Message<Oculus.Platform.Models.AssetDetailsList> msg)
	{
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0x95C37C", Offset = "0x95C37C", VA = "0x95C37C")]
	private void GetProductsBySKUCallback(Oculus.Platform.Message<Oculus.Platform.Models.ProductList> msg)
	{
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0x95B804", Offset = "0x95B804", VA = "0x95B804")]
	public void FetchPurchasedProducts()
	{
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0x95C890", Offset = "0x95C890", VA = "0x95C890")]
	private void GetViewerPurchasesCallback(Oculus.Platform.Message<Oculus.Platform.Models.PurchaseList> msg)
	{
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0x95C7B0", Offset = "0x95C7B0", VA = "0x95C7B0")]
	public void BuyPowerBallsPressed()
	{
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0x95CCEC", Offset = "0x95CCEC", VA = "0x95CCEC")]
	private void LaunchCheckoutFlowCallback(Oculus.Platform.Message<Oculus.Platform.Models.Purchase> msg)
	{
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0x95CE4C", Offset = "0x95CE4C", VA = "0x95CE4C")]
	public IAPManager()
	{
	}
}
[Token(Token = "0x20000DC")]
public class OculusPlatform : IPlatform
{
	[Token(Token = "0x6000460")]
	[Address(RVA = "0x9623F8", Offset = "0x9623F8", VA = "0x9623F8", Slot = "4")]
	public override void InitSdk(SDKData sdkData)
	{
	}

	[Token(Token = "0x6000461")]
	[Address(RVA = "0x962634", Offset = "0x962634", VA = "0x962634")]
	private void Initialize(Oculus.Platform.Message msg)
	{
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0x9628F0", Offset = "0x9628F0", VA = "0x9628F0")]
	private void EntitlementCheckCallback(Oculus.Platform.Message msg)
	{
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x962A18", Offset = "0x962A18", VA = "0x962A18")]
	public void GetPlatformUser()
	{
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0x962B34", Offset = "0x962B34", VA = "0x962B34")]
	private void GetLoggedInUserCallback(Oculus.Platform.Message msg)
	{
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0x9627C0", Offset = "0x9627C0", VA = "0x9627C0")]
	private void OnErrmsg(int code)
	{
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0x962DD4", Offset = "0x962DD4", VA = "0x962DD4")]
	public OculusPlatform()
	{
	}
}
[Token(Token = "0x20000DD")]
public class PicoPlatform : IPlatform
{
	[Token(Token = "0x6000467")]
	[Address(RVA = "0x963478", Offset = "0x963478", VA = "0x963478", Slot = "4")]
	public override void InitSdk(SDKData sdkData)
	{
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0x9636AC", Offset = "0x9636AC", VA = "0x9636AC")]
	public void SdkInitComplete(Pico.Platform.Message<Pico.Platform.PlatformInitializeResult> msg)
	{
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0x963934", Offset = "0x963934", VA = "0x963934")]
	public void GetLoginUser()
	{
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0x9639FC", Offset = "0x9639FC", VA = "0x9639FC")]
	public void OnLoinUser(Pico.Platform.Message<Pico.Platform.Models.User> msg)
	{
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0x963804", Offset = "0x963804", VA = "0x963804")]
	private void OnErrmsg(int code)
	{
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0x963C68", Offset = "0x963C68", VA = "0x963C68")]
	public PicoPlatform()
	{
	}
}
namespace Eden.SceneManagerSystem
{
	[Token(Token = "0x20000DE")]
	public enum LoadingType
	{
		[Token(Token = "0x4000311")]
		progress,
		[Token(Token = "0x4000312")]
		cameraAnim
	}
	[Token(Token = "0x20000DF")]
	public class SceneMgr : MonoBehaviour
	{
		[Token(Token = "0x20000E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674488", Offset = "0x674488")]
		private sealed class <LoadSceneAsync>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000329")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400032A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400032B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SceneMgr <>4__this;

			[Token(Token = "0x400032C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private AsyncOperation <asyncOperation>5__2;

			[Token(Token = "0x1700008D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000487")]
				[Address(RVA = "0xC52040", Offset = "0xC52040", VA = "0xC52040", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000489")]
				[Address(RVA = "0xC52088", Offset = "0xC52088", VA = "0xC52088", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000484")]
			[Address(RVA = "0xC51C9C", Offset = "0xC51C9C", VA = "0xC51C9C")]
			[DebuggerHidden]
			public <LoadSceneAsync>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x6000485")]
			[Address(RVA = "0xC51CC8", Offset = "0xC51CC8", VA = "0xC51CC8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000486")]
			[Address(RVA = "0xC51CCC", Offset = "0xC51CCC", VA = "0xC51CCC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000488")]
			[Address(RVA = "0xC52048", Offset = "0xC52048", VA = "0xC52048", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static SceneMgr _instance;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Dictionary<SceneType, SceneTypeBase> sceneTypeObjDic;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SceneTypeBase curSceneObj;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string curSceneName;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Action onSceneLoaded;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Action onSceneLoadedAnimPlayed;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float startLoadT;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private LoadingType loadingType;

		[Token(Token = "0x400031B")]
		private const string loadingProgressResPath = "ui_prefab/loading/sceneloading";

		[Token(Token = "0x400031C")]
		private const string loadingCameraAnimResPath = "ui_prefab/loading/zhuanchang_02";

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GameObject loadingObj;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Slider loadingProgress;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ScreenFade screenFade;

		[Token(Token = "0x4000320")]
		private const string animClipOpen = "zhuanchang_start";

		[Token(Token = "0x4000321")]
		private const string animClipClose = "zhuanchang_end";

		[Token(Token = "0x4000322")]
		private const string loadingAnimOpen = "open";

		[Token(Token = "0x4000323")]
		private const string loadingAnimClose = "close";

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly bool minLoadTimeEnable;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private readonly float minLoadTime;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Camera camera;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private AsyncOpRef loadingRef;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Action initCallBack;

		[Token(Token = "0x1700008B")]
		public static SceneMgr instance
		{
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x95FAB8", Offset = "0x95FAB8", VA = "0x95FAB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		public SceneType curSceneType
		{
			[Token(Token = "0x600046E")]
			[Address(RVA = "0x965550", Offset = "0x965550", VA = "0x965550")]
			get
			{
				return default(SceneType);
			}
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x96CA28", Offset = "0x96CA28", VA = "0x96CA28")]
		public void Init(Action callBack)
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x96CC20", Offset = "0x96CC20", VA = "0x96CC20")]
		private void OnLoadingLoaded()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x96CFD0", Offset = "0x96CFD0", VA = "0x96CFD0")]
		private void SetCameraClearFlags(CameraClearFlags cameraClearFlags)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x96D100", Offset = "0x96D100", VA = "0x96D100")]
		private void OpenLoading()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x96D1C8", Offset = "0x96D1C8", VA = "0x96D1C8")]
		private void CloseLoading()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x96D290", Offset = "0x96D290", VA = "0x96D290")]
		private void UpdateLoading(float progress)
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x96D2C0", Offset = "0x96D2C0", VA = "0x96D2C0")]
		public static void ResetPlayerPos([Optional] string sceneName)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x96D550", Offset = "0x96D550", VA = "0x96D550")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x675824", Offset = "0x675824")]
		private IEnumerator LoadSceneAsync()
		{
			return null;
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x96D5C8", Offset = "0x96D5C8", VA = "0x96D5C8")]
		private void LoadSceneAsyncAnimEvent()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x96D608", Offset = "0x96D608", VA = "0x96D608")]
		private void _LoadSceneAsync()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x96D764", Offset = "0x96D764", VA = "0x96D764")]
		private void SceneLoadSuccess()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x96D850", Offset = "0x96D850", VA = "0x96D850")]
		private void OnSceneInitSuccess(object parm)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x96D854", Offset = "0x96D854", VA = "0x96D854")]
		private void OnAnimOpend()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x96D858", Offset = "0x96D858", VA = "0x96D858")]
		private void OnAnimClosed()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x96D8B0", Offset = "0x96D8B0", VA = "0x96D8B0")]
		private void InitAnimEvent()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x96D8B4", Offset = "0x96D8B4", VA = "0x96D8B4")]
		private void SetActionAnimEvent(string clipName, Action action)
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x95FC94", Offset = "0x95FC94", VA = "0x95FC94")]
		public void LoadSceneAsync(string sceneName, [Optional] Action onSceneLoaded, SceneType sceneType = SceneType.None, [Optional] SceneData sceneData, [Optional] Action onSceneLoadedAnimPlayed)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x96D8B8", Offset = "0x96D8B8", VA = "0x96D8B8")]
		public void LoadSceneSync(string sceneName, [Optional] Action onSceneLoaded, SceneType sceneType = SceneType.None)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x96DA40", Offset = "0x96DA40", VA = "0x96DA40")]
		public void LoadMainScene([Optional] Action onSceneLoaded)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x96DB60", Offset = "0x96DB60", VA = "0x96DB60")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x96DBC4", Offset = "0x96DBC4", VA = "0x96DBC4")]
		public SceneMgr()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public enum SceneType
	{
		[Token(Token = "0x400032E")]
		None,
		[Token(Token = "0x400032F")]
		Guide,
		[Token(Token = "0x4000330")]
		Book,
		[Token(Token = "0x4000331")]
		Game,
		[Token(Token = "0x4000332")]
		Theme
	}
	[Token(Token = "0x20000E2")]
	public abstract class SceneTypeBase
	{
		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SceneData sceneData;

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x93B69C", Offset = "0x93B69C", VA = "0x93B69C", Slot = "4")]
		public virtual bool NeedRegisterSceneData()
		{
			return default(bool);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x93B6A4", Offset = "0x93B6A4", VA = "0x93B6A4", Slot = "5")]
		public virtual void LoadSceneBefore()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x93B890", Offset = "0x93B890", VA = "0x93B890", Slot = "6")]
		public virtual void LoadSceneIng()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x93B894", Offset = "0x93B894", VA = "0x93B894", Slot = "7")]
		public virtual void LoadSceneAfter()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x93B954", Offset = "0x93B954", VA = "0x93B954", Slot = "8")]
		public virtual void LoadSceneAfterAnim()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x93B9DC", Offset = "0x93B9DC", VA = "0x93B9DC", Slot = "9")]
		public virtual void UnloadScene()
		{
		}

		[Token(Token = "0x6000490")]
		public abstract SceneType GetSceneType();

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x93BC28", Offset = "0x93BC28", VA = "0x93BC28")]
		protected SceneTypeBase()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public class SceneTypeBook : SceneTypeBase
	{
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x93BC30", Offset = "0x93BC30", VA = "0x93BC30", Slot = "5")]
		public override void LoadSceneBefore()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x93BC34", Offset = "0x93BC34", VA = "0x93BC34", Slot = "6")]
		public override void LoadSceneIng()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x93BC38", Offset = "0x93BC38", VA = "0x93BC38", Slot = "7")]
		public override void LoadSceneAfter()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x93BC3C", Offset = "0x93BC3C", VA = "0x93BC3C", Slot = "9")]
		public override void UnloadScene()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x93BC40", Offset = "0x93BC40", VA = "0x93BC40", Slot = "10")]
		public override SceneType GetSceneType()
		{
			return default(SceneType);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x93BC48", Offset = "0x93BC48", VA = "0x93BC48")]
		public SceneTypeBook()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class SceneTypeGame : SceneTypeBase
	{
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x93BC50", Offset = "0x93BC50", VA = "0x93BC50", Slot = "5")]
		public override void LoadSceneBefore()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x93BC54", Offset = "0x93BC54", VA = "0x93BC54", Slot = "4")]
		public override bool NeedRegisterSceneData()
		{
			return default(bool);
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x93BC5C", Offset = "0x93BC5C", VA = "0x93BC5C", Slot = "6")]
		public override void LoadSceneIng()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x93BC60", Offset = "0x93BC60", VA = "0x93BC60", Slot = "7")]
		public override void LoadSceneAfter()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x93BD00", Offset = "0x93BD00", VA = "0x93BD00", Slot = "9")]
		public override void UnloadScene()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x93BEC4", Offset = "0x93BEC4", VA = "0x93BEC4", Slot = "10")]
		public override SceneType GetSceneType()
		{
			return default(SceneType);
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x93BECC", Offset = "0x93BECC", VA = "0x93BECC")]
		public SceneTypeGame()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class SceneTypeGuide : SceneTypeBase
	{
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x93BED4", Offset = "0x93BED4", VA = "0x93BED4", Slot = "5")]
		public override void LoadSceneBefore()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x93BED8", Offset = "0x93BED8", VA = "0x93BED8", Slot = "6")]
		public override void LoadSceneIng()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x93BEDC", Offset = "0x93BEDC", VA = "0x93BEDC", Slot = "7")]
		public override void LoadSceneAfter()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x93BEE8", Offset = "0x93BEE8", VA = "0x93BEE8", Slot = "9")]
		public override void UnloadScene()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x93BEEC", Offset = "0x93BEEC", VA = "0x93BEEC", Slot = "10")]
		public override SceneType GetSceneType()
		{
			return default(SceneType);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x93BEF4", Offset = "0x93BEF4", VA = "0x93BEF4")]
		public SceneTypeGuide()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class SceneTypeTheme : SceneTypeBase
	{
		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int? _lookAt;

		[Token(Token = "0x1700008F")]
		public static int? lookAt
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x93BF64", Offset = "0x93BF64", VA = "0x93BF64")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x93BEFC", Offset = "0x93BEFC", VA = "0x93BEFC")]
			set
			{
			}
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x93BFCC", Offset = "0x93BFCC", VA = "0x93BFCC", Slot = "5")]
		public override void LoadSceneBefore()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x93BFD0", Offset = "0x93BFD0", VA = "0x93BFD0", Slot = "4")]
		public override bool NeedRegisterSceneData()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x93BFD8", Offset = "0x93BFD8", VA = "0x93BFD8", Slot = "6")]
		public override void LoadSceneIng()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x93BFDC", Offset = "0x93BFDC", VA = "0x93BFDC", Slot = "7")]
		public override void LoadSceneAfter()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x93C334", Offset = "0x93C334", VA = "0x93C334", Slot = "9")]
		public override void UnloadScene()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x93C338", Offset = "0x93C338", VA = "0x93C338", Slot = "10")]
		public override SceneType GetSceneType()
		{
			return default(SceneType);
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x93C340", Offset = "0x93C340", VA = "0x93C340")]
		public SceneTypeTheme()
		{
		}
	}
}
namespace Game.UI.Book
{
	[Token(Token = "0x20000E7")]
	public class Back2BookScene : MonoBehaviour
	{
		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly string _bookSceneName;

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x167EC28", Offset = "0x167EC28", VA = "0x167EC28")]
		public void Back2Book()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x167EC70", Offset = "0x167EC70", VA = "0x167EC70")]
		public Back2BookScene()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class BookManager : MonoBehaviour
	{
		[Token(Token = "0x20000E9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674498", Offset = "0x674498")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x4000341")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UnityAction cb;

			[Token(Token = "0x60004CB")]
			[Address(RVA = "0xC4BFE8", Offset = "0xC4BFE8", VA = "0xC4BFE8")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x60004CC")]
			[Address(RVA = "0xC4BFF0", Offset = "0xC4BFF0", VA = "0xC4BFF0")]
			internal void <ShowCanvas>b__0()
			{
			}
		}

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int currentThemeIndex;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int maxThemeIndex;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LanguageSprite themeTitleImage;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Button nextThemeBtn;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Button preThemeBtn;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Controller scrollerController;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject guideTextGo;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Portal portal;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _bookTurning;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x674C0C", Offset = "0x674C0C")]
		public float bookFadeTime;

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x16804CC", Offset = "0x16804CC", VA = "0x16804CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x16808E4", Offset = "0x16808E4", VA = "0x16808E4")]
		public void PreLoad()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x16809A0", Offset = "0x16809A0", VA = "0x16809A0")]
		public void BuildTestData()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x1680784", Offset = "0x1680784", VA = "0x1680784")]
		public void ShowCanvas(bool show = true, float time = 1f, [Optional] UnityAction cb)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x1680AA4", Offset = "0x1680AA4", VA = "0x1680AA4")]
		private void CheckGuideTextShow()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x1680D20", Offset = "0x1680D20", VA = "0x1680D20")]
		private void CloseGuideTextGo()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x1680E04", Offset = "0x1680E04", VA = "0x1680E04")]
		private void OnEnterStage(object data)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1680F68", Offset = "0x1680F68", VA = "0x1680F68")]
		private void EnterTheme()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x1681010", Offset = "0x1681010", VA = "0x1681010")]
		private void OnStageGroupInfoClosed()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x1681098", Offset = "0x1681098", VA = "0x1681098")]
		private void OnCellViewSelected(int stageGroupId)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x1680B64", Offset = "0x1680B64", VA = "0x1680B64")]
		private int GetMaxThemeIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x1680B5C", Offset = "0x1680B5C", VA = "0x1680B5C")]
		private int GetCurrentThemeIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x1680C88", Offset = "0x1680C88", VA = "0x1680C88")]
		private void ShowTheme(int themeIndex)
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1681154", Offset = "0x1681154", VA = "0x1681154")]
		private bool CheckDoorShow(int themeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x168113C", Offset = "0x168113C", VA = "0x168113C")]
		private void ShowRightPage(int themeIndex)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x168109C", Offset = "0x168109C", VA = "0x168109C")]
		private void ShowLeftPage(int themeIndex)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1681B7C", Offset = "0x1681B7C", VA = "0x1681B7C")]
		private void ShowPreviousTheme()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1681C64", Offset = "0x1681C64", VA = "0x1681C64")]
		private void ShowNextTheme()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1680C1C", Offset = "0x1680C1C", VA = "0x1680C1C")]
		private void CheckLeftAndRightBtn()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1681038", Offset = "0x1681038", VA = "0x1681038")]
		private void SetLeftAndRightBtn(bool show)
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1681D4C", Offset = "0x1681D4C", VA = "0x1681D4C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1681EA4", Offset = "0x1681EA4", VA = "0x1681EA4")]
		public BookManager()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1681EB4", Offset = "0x1681EB4", VA = "0x1681EB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6758D4", Offset = "0x6758D4")]
		private void <ShowPreviousTheme>b__27_0()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1681F50", Offset = "0x1681F50", VA = "0x1681F50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6758E4", Offset = "0x6758E4")]
		private void <ShowPreviousTheme>b__27_1()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1681F58", Offset = "0x1681F58", VA = "0x1681F58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6758F4", Offset = "0x6758F4")]
		private void <ShowNextTheme>b__28_0()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1681FF4", Offset = "0x1681FF4", VA = "0x1681FF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675904", Offset = "0x675904")]
		private void <ShowNextTheme>b__28_1()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public delegate void SelectedDelegate(RowCellView rowCellView);
	[Token(Token = "0x20000EB")]
	public class CellView : EnhancedScrollerCellView
	{
		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RowCellView[] rowCellViews;

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x1683044", Offset = "0x1683044", VA = "0x1683044")]
		public void SetData(ref SmallList<Data> data, int startingIndex, SelectedDelegate selected)
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x1683140", Offset = "0x1683140", VA = "0x1683140")]
		public CellView()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class Controller : MonoBehaviour, IEnhancedScrollerDelegate
	{
		[Token(Token = "0x20000ED")]
		public delegate void OnCellViewSelected(int stageGroupId);

		[Serializable]
		[Token(Token = "0x20000EE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6744A8", Offset = "0x6744A8")]
		private sealed class <>c
		{
			[Token(Token = "0x4000348")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000349")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Comparison<StageGroupCfg> <>9__7_0;

			[Token(Token = "0x60004E2")]
			[Address(RVA = "0xC4C144", Offset = "0xC4C144", VA = "0xC4C144")]
			public <>c()
			{
			}

			[Token(Token = "0x60004E3")]
			[Address(RVA = "0xC4C14C", Offset = "0xC4C14C", VA = "0xC4C14C")]
			internal int <LoadData>b__7_0(StageGroupCfg v1, StageGroupCfg v2)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public OnCellViewSelected onCellViewSelected;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SmallList<Data> _data;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EnhancedScroller scroller;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EnhancedScrollerCellView cellViewPrefab;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int numberOfCellsPerRow;

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x1685218", Offset = "0x1685218", VA = "0x1685218")]
		private void Start()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x1681670", Offset = "0x1681670", VA = "0x1681670")]
		public void LoadData(int themeIndex)
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x1685690", Offset = "0x1685690", VA = "0x1685690")]
		public static int GetMaxProgressStageId(int sgcId)
		{
			return default(int);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x1685238", Offset = "0x1685238", VA = "0x1685238")]
		public static float GetStageGroupMaxProgress(int sgcId)
		{
			return default(float);
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1685B08", Offset = "0x1685B08", VA = "0x1685B08")]
		private void CellViewSelected(RowCellView cellView)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1685C14", Offset = "0x1685C14", VA = "0x1685C14")]
		private void OnSelectItem(int stageId)
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1685C28", Offset = "0x1685C28", VA = "0x1685C28", Slot = "4")]
		public int GetNumberOfCells(EnhancedScroller scroller)
		{
			return default(int);
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x1685C58", Offset = "0x1685C58", VA = "0x1685C58", Slot = "5")]
		public float GetCellViewSize(EnhancedScroller scroller, int dataIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1685C64", Offset = "0x1685C64", VA = "0x1685C64", Slot = "6")]
		public EnhancedScrollerCellView GetCellView(EnhancedScroller scroller, int dataIndex, int cellIndex)
		{
			return null;
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1685E0C", Offset = "0x1685E0C", VA = "0x1685E0C")]
		public Controller()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public delegate void SelectedChangedDelegate(bool val);
	[Token(Token = "0x20000F0")]
	public class Data
	{
		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int stageId;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float maxProgress;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int maxProgressStageId;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string stageNameText;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string stageProgressText;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string stagePicPath;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool isActive;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SelectedChangedDelegate selectedChanged;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _selected;

		[Token(Token = "0x17000090")]
		public bool Selected
		{
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x9546E8", Offset = "0x9546E8", VA = "0x9546E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x9546F0", Offset = "0x9546F0", VA = "0x9546F0")]
			set
			{
			}
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x9546C0", Offset = "0x9546C0", VA = "0x9546C0")]
		public Data()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class RowCellView : MonoBehaviour
	{
		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject container;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform _rectTransform;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int stageId;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Image stagePic;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Image selectionPanel;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Button _button;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _bgImage;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject stageInfoPanel;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject basePanel;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public GameObject clickBtn;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674C44", Offset = "0x674C44")]
		private int <DataIndex>k__BackingField;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public SelectedDelegate selected;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Data _data;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public GameObject medalPanel;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Image medalImage;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Text medalText;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public GameObject comingSoonPanel;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public GameObject bgPanel;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public LanguageText nameText;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public TextMeshProUGUI progressText;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly Vector3 _oriScale;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private readonly Vector3 _selectScale;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private readonly float _oriZ;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x674C54", Offset = "0x674C54")]
		public float selectZ;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x674C8C", Offset = "0x674C8C")]
		public float zTime;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private bool _isSelect;

		[Token(Token = "0x17000091")]
		public int DataIndex
		{
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x96BA30", Offset = "0x96BA30", VA = "0x96BA30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675914", Offset = "0x675914")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004EC")]
			[Address(RVA = "0x96BA38", Offset = "0x96BA38", VA = "0x96BA38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675924", Offset = "0x675924")]
			private set
			{
			}
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x96BA40", Offset = "0x96BA40", VA = "0x96BA40")]
		private void Start()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x96BB00", Offset = "0x96BB00", VA = "0x96BB00")]
		private void ShowSelectEffect(bool show)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x96BCC8", Offset = "0x96BCC8", VA = "0x96BCC8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x96BDA8", Offset = "0x96BDA8", VA = "0x96BDA8")]
		public void SetData(int dataIndex, Data data, SelectedDelegate selected)
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x96C294", Offset = "0x96C294", VA = "0x96C294")]
		private void SetContainerPos(int dataIndex)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x96C374", Offset = "0x96C374", VA = "0x96C374")]
		private void SelectedChanged(bool selected)
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x96BC00", Offset = "0x96BC00", VA = "0x96BC00")]
		public void OnSelected()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x96C3DC", Offset = "0x96C3DC", VA = "0x96C3DC")]
		public RowCellView()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class StageDiffcultyController : MonoBehaviour, IEnhancedScrollerDelegate
	{
		[Token(Token = "0x20000F3")]
		public delegate void OnDifficultyCellViewSelected(StageDifficultyCellView cellView);

		[Serializable]
		[Token(Token = "0x20000F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6744B8", Offset = "0x6744B8")]
		private sealed class <>c
		{
			[Token(Token = "0x4000372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Comparison<int> <>9__7_0;

			[Token(Token = "0x6000505")]
			[Address(RVA = "0xC52DA4", Offset = "0xC52DA4", VA = "0xC52DA4")]
			public <>c()
			{
			}

			[Token(Token = "0x6000506")]
			[Address(RVA = "0xC52DAC", Offset = "0xC52DAC", VA = "0xC52DAC")]
			internal int <LoadData>b__7_0(int a, int b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public OnDifficultyCellViewSelected onCellViewSelected;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SmallList<StageDifficultyData> _data;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EnhancedScroller scroller;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EnhancedScrollerCellView cellViewPrefab;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int numberOfCellsPerRow;

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x93F6E0", Offset = "0x93F6E0", VA = "0x93F6E0")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x93F700", Offset = "0x93F700", VA = "0x93F700")]
		public void LoadData(int stageGroupId)
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x93FCF0", Offset = "0x93FCF0", VA = "0x93FCF0")]
		private string GetStarLevelText(int stageDataStarCount)
		{
			return null;
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x940008", Offset = "0x940008", VA = "0x940008")]
		public void SelectFirstItem()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x93FD78", Offset = "0x93FD78", VA = "0x93FD78")]
		private float GetStageProgress(int stage)
		{
			return default(float);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x940278", Offset = "0x940278", VA = "0x940278")]
		private void CellViewSelected(StageDifficultyCellView cellView)
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x9403E4", Offset = "0x9403E4", VA = "0x9403E4")]
		private void OnSelectItem(StageDifficultyCellView cellView)
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x9403F8", Offset = "0x9403F8", VA = "0x9403F8", Slot = "4")]
		public int GetNumberOfCells(EnhancedScroller scroller)
		{
			return default(int);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x940428", Offset = "0x940428", VA = "0x940428", Slot = "5")]
		public float GetCellViewSize(EnhancedScroller scroller, int dataIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x940430", Offset = "0x940430", VA = "0x940430", Slot = "6")]
		public EnhancedScrollerCellView GetCellView(EnhancedScroller scroller, int dataIndex, int cellIndex)
		{
			return null;
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x940880", Offset = "0x940880", VA = "0x940880")]
		public StageDiffcultyController()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public delegate void DifficultySelectedDelegate(StageDifficultyCellView view);
	[Token(Token = "0x20000F6")]
	public class StageDifficultyCellView : EnhancedScrollerCellView
	{
		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int stageId;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float stageProgress;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public PointTrigger btn;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private DifficultySelectedDelegate _onSelected;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private StageDifficultyData _data;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public LanguageText pieceCount;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Image starImage;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Sprite hoverImage;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Sprite idleImage;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Sprite selectImage;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool _isSelect;

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x940890", Offset = "0x940890", VA = "0x940890")]
		private void Start()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x940894", Offset = "0x940894", VA = "0x940894")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x9400EC", Offset = "0x9400EC", VA = "0x9400EC")]
		public void OnClickBtn()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x9405FC", Offset = "0x9405FC", VA = "0x9405FC")]
		public void SetData(StageDifficultyData data, DifficultySelectedDelegate selectedDelegate)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x940D9C", Offset = "0x940D9C", VA = "0x940D9C")]
		private void SelectedChanged(bool selected)
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x940E28", Offset = "0x940E28", VA = "0x940E28")]
		public void OnPointEnter()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x940DB0", Offset = "0x940DB0", VA = "0x940DB0")]
		public void OnPointExit()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x940EA0", Offset = "0x940EA0", VA = "0x940EA0")]
		public void OnPointClick()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x940EA4", Offset = "0x940EA4", VA = "0x940EA4")]
		public StageDifficultyCellView()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public delegate void SelectedDifficultyChangedDelegate(bool val);
	[Token(Token = "0x20000F8")]
	public class StageDifficultyData
	{
		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int stageId;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string difficultyText;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int pieceCountText;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float progress;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int stageGroupId;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SelectedDifficultyChangedDelegate selectedChanged;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _selected;

		[Token(Token = "0x17000092")]
		public bool Selected
		{
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x940EAC", Offset = "0x940EAC", VA = "0x940EAC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x9403B4", Offset = "0x9403B4", VA = "0x9403B4")]
			set
			{
			}
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x93FCE8", Offset = "0x93FCE8", VA = "0x93FCE8")]
		public StageDifficultyData()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class StageGroupInfo : MonoBehaviour
	{
		[Token(Token = "0x20000FA")]
		public delegate void OnStageGroupInfoClosed();

		[Token(Token = "0x20000FB")]
		public delegate void OnEnterStage(int stageId);

		[Token(Token = "0x20000FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6744C8", Offset = "0x6744C8")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SceneData sceneData;

			[Token(Token = "0x600052D")]
			[Address(RVA = "0xC5316C", Offset = "0xC5316C", VA = "0xC5316C")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x600052E")]
			[Address(RVA = "0xC53174", Offset = "0xC53174", VA = "0xC53174")]
			internal void <OnStartGame>b__0()
			{
			}
		}

		[Token(Token = "0x20000FD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6744D8", Offset = "0x6744D8")]
		private sealed class <SelectFirstItem>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000391")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000392")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public StageGroupInfo <>4__this;

			[Token(Token = "0x17000093")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000532")]
				[Address(RVA = "0xC53390", Offset = "0xC53390", VA = "0xC53390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000094")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000534")]
				[Address(RVA = "0xC533D8", Offset = "0xC533D8", VA = "0xC533D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600052F")]
			[Address(RVA = "0xC532E8", Offset = "0xC532E8", VA = "0xC532E8")]
			[DebuggerHidden]
			public <SelectFirstItem>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000530")]
			[Address(RVA = "0xC53314", Offset = "0xC53314", VA = "0xC53314", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000531")]
			[Address(RVA = "0xC53318", Offset = "0xC53318", VA = "0xC53318", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000533")]
			[Address(RVA = "0xC53398", Offset = "0xC53398", VA = "0xC53398", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StageDiffcultyController stageDifficultyController;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OnStageGroupInfoClosed onStageGroupInfoClosed;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OnEnterStage onEnterStage;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Button startBtn;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int stageId;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Text stageProgressText;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _rePlay;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public LanguageText nameText;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public LanguageText btnText;

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x941648", Offset = "0x941648", VA = "0x941648")]
		private void Start()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x9416EC", Offset = "0x9416EC", VA = "0x9416EC")]
		private void OnStartGame()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x941C04", Offset = "0x941C04", VA = "0x941C04")]
		private void OnClickBackBtn()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x941C18", Offset = "0x941C18", VA = "0x941C18")]
		public void InitShow(int stageGroupId)
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x941D70", Offset = "0x941D70", VA = "0x941D70")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x675934", Offset = "0x675934")]
		private IEnumerator SelectFirstItem()
		{
			return null;
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x941DE8", Offset = "0x941DE8", VA = "0x941DE8")]
		private void OnCellViewSelected(StageDifficultyCellView cellView)
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x941E08", Offset = "0x941E08", VA = "0x941E08")]
		private void SetStartBtnText(float cellViewStageProgress)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x941E64", Offset = "0x941E64", VA = "0x941E64")]
		private int GetStartBtnText(float cellViewStageProgress)
		{
			return default(int);
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x941EA0", Offset = "0x941EA0", VA = "0x941EA0")]
		public void Deinit()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x941F70", Offset = "0x941F70", VA = "0x941F70")]
		public StageGroupInfo()
		{
		}
	}
}
namespace UnityEngine.XR.Interaction.Toolkit
{
	[Token(Token = "0x20000FE")]
	public class RayLine : MonoBehaviour
	{
		[Token(Token = "0x4000393")]
		private const float k_MinLineWidth = 0.0001f;

		[Token(Token = "0x4000394")]
		private const float k_MaxLineWidth = 0.05f;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject sphereObject;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x674CD4", Offset = "0x674CD4")]
		private float m_LineWidth;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool m_OverrideInteractorLineLength;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_LineLength;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationCurve m_WidthCurve;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Gradient m_ValidColorGradient;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Gradient m_InvalidColorGradient;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool m_SmoothMovement;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_FollowTightness;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_SnapThresholdDistance;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject m_Reticle;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool m_StopLineAtFirstRaycastHit;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3 m_ReticlePos;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 m_ReticleNormal;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int m_EndPositionInLine;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_SnapCurve;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		private bool m_PerformSetup;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private GameObject m_ReticleToUse;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private LineRenderer m_LineRenderer;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Material m_LineMaterial;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ILineRenderable m_LineRenderable;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] m_TargetPoints;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int m_NoTargetPoints;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3[] m_RenderPoints;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int m_NoRenderPoints;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3[] m_PreviousRenderPoints;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int m_NoPreviousRenderPoints;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly Vector3[] m_ClearArray;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private GameObject m_CustomReticle;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool m_CustomReticleAttached;

		[Token(Token = "0x17000095")]
		public float lineWidth
		{
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x966E2C", Offset = "0x966E2C", VA = "0x966E2C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000536")]
			[Address(RVA = "0x966E34", Offset = "0x966E34", VA = "0x966E34")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public bool overrideInteractorLineLength
		{
			[Token(Token = "0x6000537")]
			[Address(RVA = "0x966E44", Offset = "0x966E44", VA = "0x966E44")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000538")]
			[Address(RVA = "0x966E4C", Offset = "0x966E4C", VA = "0x966E4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public float lineLength
		{
			[Token(Token = "0x6000539")]
			[Address(RVA = "0x966E58", Offset = "0x966E58", VA = "0x966E58")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600053A")]
			[Address(RVA = "0x966E60", Offset = "0x966E60", VA = "0x966E60")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public AnimationCurve widthCurve
		{
			[Token(Token = "0x600053B")]
			[Address(RVA = "0x966E68", Offset = "0x966E68", VA = "0x966E68")]
			get
			{
				return null;
			}
			[Token(Token = "0x600053C")]
			[Address(RVA = "0x966E70", Offset = "0x966E70", VA = "0x966E70")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public Gradient validColorGradient
		{
			[Token(Token = "0x600053D")]
			[Address(RVA = "0x966EA0", Offset = "0x966EA0", VA = "0x966EA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600053E")]
			[Address(RVA = "0x966EA8", Offset = "0x966EA8", VA = "0x966EA8")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public Gradient invalidColorGradient
		{
			[Token(Token = "0x600053F")]
			[Address(RVA = "0x966EB0", Offset = "0x966EB0", VA = "0x966EB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000540")]
			[Address(RVA = "0x966EB8", Offset = "0x966EB8", VA = "0x966EB8")]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public bool smoothMovement
		{
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x966EC0", Offset = "0x966EC0", VA = "0x966EC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x966EC8", Offset = "0x966EC8", VA = "0x966EC8")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public float followTightness
		{
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x966ED4", Offset = "0x966ED4", VA = "0x966ED4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000544")]
			[Address(RVA = "0x966EDC", Offset = "0x966EDC", VA = "0x966EDC")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public float snapThresholdDistance
		{
			[Token(Token = "0x6000545")]
			[Address(RVA = "0x966EE4", Offset = "0x966EE4", VA = "0x966EE4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000546")]
			[Address(RVA = "0x966EEC", Offset = "0x966EEC", VA = "0x966EEC")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public GameObject reticle
		{
			[Token(Token = "0x6000547")]
			[Address(RVA = "0x966EF4", Offset = "0x966EF4", VA = "0x966EF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000548")]
			[Address(RVA = "0x966EFC", Offset = "0x966EFC", VA = "0x966EFC")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public bool stopLineAtFirstRaycastHit
		{
			[Token(Token = "0x6000549")]
			[Address(RVA = "0x966F04", Offset = "0x966F04", VA = "0x966F04")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600054A")]
			[Address(RVA = "0x966F0C", Offset = "0x966F0C", VA = "0x966F0C")]
			set
			{
			}
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x966F18", Offset = "0x966F18", VA = "0x966F18")]
		protected void Reset()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x966F1C", Offset = "0x966F1C", VA = "0x966F1C")]
		protected void OnValidate()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x966FC8", Offset = "0x966FC8", VA = "0x966FC8")]
		protected void Awake()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x967138", Offset = "0x967138", VA = "0x967138")]
		protected void OnEnable()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x9671CC", Offset = "0x9671CC", VA = "0x9671CC")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x9670E0", Offset = "0x9670E0", VA = "0x9670E0")]
		private void ClearLineRenderer()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x967410", Offset = "0x967410", VA = "0x967410")]
		[AttributeAttribute(Name = "BeforeRenderOrderAttribute", RVA = "0x6759E4", Offset = "0x6759E4")]
		private void OnBeforeRenderLineVisual()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x967414", Offset = "0x967414", VA = "0x967414")]
		private void UpdateLineVisual()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x966F54", Offset = "0x966F54", VA = "0x966F54")]
		private void UpdateSettings()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x967300", Offset = "0x967300", VA = "0x967300")]
		private bool TryFindLineRenderer()
		{
			return default(bool);
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x967FBC", Offset = "0x967FBC", VA = "0x967FBC")]
		public bool AttachCustomReticle(GameObject reticleInstance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x96810C", Offset = "0x96810C", VA = "0x96810C")]
		public bool RemoveCustomReticle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x967E8C", Offset = "0x967E8C", VA = "0x967E8C")]
		public Vector3[] getLineAtPoint(Vector3 start, Vector3 end)
		{
			return null;
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x967E4C", Offset = "0x967E4C", VA = "0x967E4C")]
		private Vector3 GetReticleScale(Vector3 start, Vector3 end)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x968200", Offset = "0x968200", VA = "0x968200")]
		public void SetGradient(float value)
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x968204", Offset = "0x968204", VA = "0x968204")]
		public RayLine()
		{
		}
	}
}
namespace Framework
{
	[Token(Token = "0x20000FF")]
	public static class Url
	{
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x94FF9C", Offset = "0x94FF9C", VA = "0x94FF9C")]
		public static bool IsUrl(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x95009C", Offset = "0x95009C", VA = "0x95009C")]
		public static string StringToMd5(string input)
		{
			return null;
		}
	}
}
namespace CoreFrameWork
{
	[Token(Token = "0x2000100")]
	public class LogUtil
	{
		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string _tag;

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x95FE64", Offset = "0x95FE64", VA = "0x95FE64")]
		public static void Init(string tag)
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x95AB58", Offset = "0x95AB58", VA = "0x95AB58")]
		public static void Log(string message)
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x95FED0", Offset = "0x95FED0", VA = "0x95FED0")]
		public static void Warn(string message)
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x95FF98", Offset = "0x95FF98", VA = "0x95FF98")]
		public LogUtil()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class XRConfigs : MonoBehaviour
	{
		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float eyeTextureResolutionScale;

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x951638", Offset = "0x951638", VA = "0x951638")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x9516CC", Offset = "0x9516CC", VA = "0x9516CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x9516D0", Offset = "0x9516D0", VA = "0x9516D0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x9516D4", Offset = "0x9516D4", VA = "0x9516D4")]
		public XRConfigs()
		{
		}
	}
}
namespace ZYB.SDK
{
	[Token(Token = "0x2000102")]
	public abstract class IPlatform
	{
		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isInit;

		[Token(Token = "0x6000566")]
		public abstract void InitSdk(SDKData sdkData);

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x9565EC", Offset = "0x9565EC", VA = "0x9565EC", Slot = "5")]
		public virtual void SetUserId(string userId)
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x956DDC", Offset = "0x956DDC", VA = "0x956DDC", Slot = "6")]
		public virtual void SendState(string eventName, Dictionary<string, string> extraInfos)
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x95666C", Offset = "0x95666C", VA = "0x95666C", Slot = "7")]
		public virtual void SendState(string name, string parameterName, string parameterValue)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x956DE8", Offset = "0x956DE8", VA = "0x956DE8")]
		protected IPlatform()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class SDKManager
	{
		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<string, IPlatform> XRSdkImpl;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<string, IPlatform> AnalyticsSdk;

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x96C488", Offset = "0x96C488", VA = "0x96C488")]
		public static void InitSDK(SDKPlatform config)
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x96C82C", Offset = "0x96C82C", VA = "0x96C82C")]
		public static Dictionary<string, IPlatform> GetAnalyticsSdk()
		{
			return null;
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x96C890", Offset = "0x96C890", VA = "0x96C890")]
		public SDKManager()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class SDKData
	{
		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674DBC", Offset = "0x674DBC")]
		private string <SDK_Type>k__BackingField;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674DCC", Offset = "0x674DCC")]
		private string <PlatformType>k__BackingField;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674DDC", Offset = "0x674DDC")]
		private string <APP_KEY>k__BackingField;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674DEC", Offset = "0x674DEC")]
		private string <RefClassName>k__BackingField;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674DFC", Offset = "0x674DFC")]
		private object <Other>k__BackingField;

		[Token(Token = "0x170000A0")]
		public string SDK_Type
		{
			[Token(Token = "0x600056F")]
			[Address(RVA = "0x96C430", Offset = "0x96C430", VA = "0x96C430")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675A08", Offset = "0x675A08")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000570")]
			[Address(RVA = "0x96C438", Offset = "0x96C438", VA = "0x96C438")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675A18", Offset = "0x675A18")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public string PlatformType
		{
			[Token(Token = "0x6000571")]
			[Address(RVA = "0x96C440", Offset = "0x96C440", VA = "0x96C440")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675A28", Offset = "0x675A28")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000572")]
			[Address(RVA = "0x96C448", Offset = "0x96C448", VA = "0x96C448")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675A38", Offset = "0x675A38")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public string APP_KEY
		{
			[Token(Token = "0x6000573")]
			[Address(RVA = "0x96C450", Offset = "0x96C450", VA = "0x96C450")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675A48", Offset = "0x675A48")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000574")]
			[Address(RVA = "0x96C458", Offset = "0x96C458", VA = "0x96C458")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675A58", Offset = "0x675A58")]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public string RefClassName
		{
			[Token(Token = "0x6000575")]
			[Address(RVA = "0x96C460", Offset = "0x96C460", VA = "0x96C460")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675A68", Offset = "0x675A68")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000576")]
			[Address(RVA = "0x96C468", Offset = "0x96C468", VA = "0x96C468")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675A78", Offset = "0x675A78")]
			set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public object Other
		{
			[Token(Token = "0x6000577")]
			[Address(RVA = "0x96C470", Offset = "0x96C470", VA = "0x96C470")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675A88", Offset = "0x675A88")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x96C478", Offset = "0x96C478", VA = "0x96C478")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675A98", Offset = "0x675A98")]
			set
			{
			}
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x96C480", Offset = "0x96C480", VA = "0x96C480")]
		public SDKData()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class SDKPlatform
	{
		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674E0C", Offset = "0x674E0C")]
		private SDKData[] <platform>k__BackingField;

		[Token(Token = "0x170000A5")]
		public SDKData[] platform
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x96C954", Offset = "0x96C954", VA = "0x96C954")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675AA8", Offset = "0x675AA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x96C95C", Offset = "0x96C95C", VA = "0x96C95C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x675AB8", Offset = "0x675AB8")]
			set
			{
			}
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x96C964", Offset = "0x96C964", VA = "0x96C964")]
		public SDKPlatform()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class PlatformLoginData
	{
		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Code;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string UserId;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string DisplayName;

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x962DCC", Offset = "0x962DCC", VA = "0x962DCC")]
		public PlatformLoginData()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class StatsManager
	{
		[Token(Token = "0x600057E")]
		[Address(RVA = "0x9437BC", Offset = "0x9437BC", VA = "0x9437BC")]
		public static void SetUserInfo()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x9439D8", Offset = "0x9439D8", VA = "0x9439D8")]
		public static void Send(string eventKey)
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x940980", Offset = "0x940980", VA = "0x940980")]
		public static void Send(string eventKey, Dictionary<string, string> extraInfos)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x943A4C", Offset = "0x943A4C", VA = "0x943A4C")]
		public static long GetTimeStamp()
		{
			return default(long);
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x943B58", Offset = "0x943B58", VA = "0x943B58")]
		public StatsManager()
		{
		}
	}
}
namespace ZYB.Utils
{
	[Token(Token = "0x2000108")]
	public class LanguageUtils
	{
		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static TMP_FontAsset cnTMProFont;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static TMP_FontAsset enTMProFont;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string _curLanguage;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Hashtable _languageTable;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static bool _isInit;

		[Token(Token = "0x170000A6")]
		public static string LANGUAGE
		{
			[Token(Token = "0x6000583")]
			[Address(RVA = "0x95E2D4", Offset = "0x95E2D4", VA = "0x95E2D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000584")]
			[Address(RVA = "0x95E338", Offset = "0x95E338", VA = "0x95E338")]
			set
			{
			}
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x95E3A4", Offset = "0x95E3A4", VA = "0x95E3A4")]
		public static void Init()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x95EBA0", Offset = "0x95EBA0", VA = "0x95EBA0")]
		private static void ConfigLoaded()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x95E9A8", Offset = "0x95E9A8", VA = "0x95E9A8")]
		private static string GetCurrentLanguageSetting()
		{
			return null;
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x95EB20", Offset = "0x95EB20", VA = "0x95EB20")]
		private static void Init(Hashtable table)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x95DD5C", Offset = "0x95DD5C", VA = "0x95DD5C")]
		public static string Text(int key)
		{
			return null;
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x95EC3C", Offset = "0x95EC3C", VA = "0x95EC3C")]
		public static string Text(int key, string[] param)
		{
			return null;
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x95D8CC", Offset = "0x95D8CC", VA = "0x95D8CC")]
		public static string TextImagePath(int languageId)
		{
			return null;
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x95DE9C", Offset = "0x95DE9C", VA = "0x95DE9C")]
		public static string TextStyle(int languageId)
		{
			return null;
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x95DC5C", Offset = "0x95DC5C", VA = "0x95DC5C")]
		public static TMP_FontAsset Font()
		{
			return null;
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x95EEAC", Offset = "0x95EEAC", VA = "0x95EEAC")]
		public LanguageUtils()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class LanguageVO
	{
		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string cn;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string en;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string cnImagePath;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string enImagePath;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string cnFontStyle;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string enFontStyle;

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x95EBA4", Offset = "0x95EBA4", VA = "0x95EBA4")]
		public string getText(string type)
		{
			return null;
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x95ED7C", Offset = "0x95ED7C", VA = "0x95ED7C")]
		public string GetTextImage(string type)
		{
			return null;
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x95EE14", Offset = "0x95EE14", VA = "0x95EE14")]
		public string GetSyle(string type)
		{
			return null;
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x95EB18", Offset = "0x95EB18", VA = "0x95EB18")]
		public LanguageVO()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class LanguageType
	{
		[Token(Token = "0x40003CC")]
		public const string cn = "cn";

		[Token(Token = "0x40003CD")]
		public const string en = "en";

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x95E2CC", Offset = "0x95E2CC", VA = "0x95E2CC")]
		public LanguageType()
		{
		}
	}
}
namespace ZYB.Model
{
	[Token(Token = "0x200010B")]
	public class BaseModel
	{
		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string modelName;

		[Token(Token = "0x170000A7")]
		public virtual string ModelName
		{
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x167F024", Offset = "0x167F024", VA = "0x167F024", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000597")]
			[Address(RVA = "0x167F088", Offset = "0x167F088", VA = "0x167F088", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x167F020", Offset = "0x167F020", VA = "0x167F020")]
		static BaseModel()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x167F0F4", Offset = "0x167F0F4", VA = "0x167F0F4", Slot = "6")]
		public virtual void Init()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x167F230", Offset = "0x167F230", VA = "0x167F230", Slot = "7")]
		public virtual void Destroy()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x167F2A4", Offset = "0x167F2A4", VA = "0x167F2A4")]
		public BaseModel()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class ModelManager
	{
		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Hashtable modelTable;

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x960F8C", Offset = "0x960F8C", VA = "0x960F8C")]
		public static void Register(BaseModel model)
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x961234", Offset = "0x961234", VA = "0x961234")]
		public static void Unregister(BaseModel model)
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x9612DC", Offset = "0x9612DC", VA = "0x9612DC")]
		public static void UnregisterAll()
		{
		}

		[Token(Token = "0x600059E")]
		public static T GetModel<T>(string key)
		{
			return (T)null;
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x961704", Offset = "0x961704", VA = "0x961704")]
		public static void ForceSerialize(BaseModel model)
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x9618A8", Offset = "0x9618A8", VA = "0x9618A8")]
		public static void ForceSerializeAll()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x961C68", Offset = "0x961C68", VA = "0x961C68")]
		public ModelManager()
		{
		}
	}
	[Token(Token = "0x200010D")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6744F8", Offset = "0x6744F8")]
	public class ModelSerializable : Attribute
	{
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x961CE8", Offset = "0x961CE8", VA = "0x961CE8")]
		public ModelSerializable()
		{
		}
	}
}
namespace StaticConfig
{
	[Token(Token = "0x200010E")]
	public abstract class BaseConfig
	{
		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string configPath;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AsyncOpRef async;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Action<string> _LoadSuccess;

		[Token(Token = "0x60005A4")]
		public abstract string GetConfigKey();

		[Token(Token = "0x60005A5")]
		public abstract void Trans(string json, string key);

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x167EE4C", Offset = "0x167EE4C", VA = "0x167EE4C")]
		public void clear()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x167EE54", Offset = "0x167EE54", VA = "0x167EE54")]
		public void LoadConfig(string path, Action<string> loadSuccess)
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x167EF34", Offset = "0x167EF34", VA = "0x167EF34")]
		private void OpLoadSuccess()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x167C3B0", Offset = "0x167C3B0", VA = "0x167C3B0")]
		protected BaseConfig()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public abstract class BaseConfigs
	{
		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<BaseConfigVO> data;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string classReference;

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x167F010", Offset = "0x167F010", VA = "0x167F010")]
		protected BaseConfigs()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class BaseConfigVO
	{
		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x167F008", Offset = "0x167F008", VA = "0x167F008")]
		public BaseConfigVO()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class ConfigManger
	{
		[Token(Token = "0x2000112")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67452C", Offset = "0x67452C")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string path;

			[Token(Token = "0x60005B4")]
			[Address(RVA = "0xC4C004", Offset = "0xC4C004", VA = "0xC4C004")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60005B5")]
			[Address(RVA = "0xC4C00C", Offset = "0xC4C00C", VA = "0xC4C00C")]
			internal void <LoadList>b__0()
			{
			}
		}

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Action _onLoadListCallBack;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<string, AsyncOpRef> _opRefList;

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x16842F8", Offset = "0x16842F8", VA = "0x16842F8")]
		public static void Load(string path, [Optional] Action onLoadSuccess)
		{
		}

		[Token(Token = "0x60005AD")]
		public static void load<T>(string path)
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x16794A0", Offset = "0x16794A0", VA = "0x16794A0")]
		public static void LoadList(string[] paths, Action onLoadSuccess)
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x16843DC", Offset = "0x16843DC", VA = "0x16843DC")]
		private static void LoadSimpleSuccess(AsyncOpRef opRef, string path)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x1684658", Offset = "0x1684658", VA = "0x1684658")]
		public static void clear(BaseConfig config)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1684754", Offset = "0x1684754", VA = "0x1684754")]
		public static void clear(string path)
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1684878", Offset = "0x1684878", VA = "0x1684878")]
		public ConfigManger()
		{
		}
	}
}
namespace TMPro
{
	[Serializable]
	[Token(Token = "0x2000113")]
	public class TMP_DigitValidator : TMP_InputValidator
	{
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x943B60", Offset = "0x943B60", VA = "0x943B60", Slot = "4")]
		public override char Validate(ref string text, ref int pos, char ch)
		{
			return default(char);
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x943BE4", Offset = "0x943BE4", VA = "0x943BE4")]
		public TMP_DigitValidator()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000114")]
	public class TMP_PhoneNumberValidator : TMP_InputValidator
	{
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x94448C", Offset = "0x94448C", VA = "0x94448C", Slot = "4")]
		public override char Validate(ref string text, ref int pos, char ch)
		{
			return default(char);
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x94490C", Offset = "0x94490C", VA = "0x94490C")]
		public TMP_PhoneNumberValidator()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class TMP_TextEventHandler : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Serializable]
		[Token(Token = "0x2000116")]
		public class CharacterSelectionEvent : UnityEvent<char, int>
		{
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0xC5390C", Offset = "0xC5390C", VA = "0xC5390C")]
			public CharacterSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000117")]
		public class SpriteSelectionEvent : UnityEvent<char, int>
		{
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0xC539F0", Offset = "0xC539F0", VA = "0xC539F0")]
			public SpriteSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000118")]
		public class WordSelectionEvent : UnityEvent<string, int, int>
		{
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0xC53A3C", Offset = "0xC53A3C", VA = "0xC53A3C")]
			public WordSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000119")]
		public class LineSelectionEvent : UnityEvent<string, int, int>
		{
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0xC53958", Offset = "0xC53958", VA = "0xC53958")]
			public LineSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200011A")]
		public class LinkSelectionEvent : UnityEvent<string, string, int>
		{
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0xC539A4", Offset = "0xC539A4", VA = "0xC539A4")]
			public LinkSelectionEvent()
			{
			}
		}

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CharacterSelectionEvent m_OnCharacterSelection;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SpriteSelectionEvent m_OnSpriteSelection;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private WordSelectionEvent m_OnWordSelection;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LineSelectionEvent m_OnLineSelection;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LinkSelectionEvent m_OnLinkSelection;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera m_Camera;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Canvas m_Canvas;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_selectedLink;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_lastCharIndex;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int m_lastWordIndex;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int m_lastLineIndex;

		[Token(Token = "0x170000A8")]
		public CharacterSelectionEvent onCharacterSelection
		{
			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x945C34", Offset = "0x945C34", VA = "0x945C34")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005BB")]
			[Address(RVA = "0x945C3C", Offset = "0x945C3C", VA = "0x945C3C")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public SpriteSelectionEvent onSpriteSelection
		{
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x945C44", Offset = "0x945C44", VA = "0x945C44")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x945C4C", Offset = "0x945C4C", VA = "0x945C4C")]
			set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public WordSelectionEvent onWordSelection
		{
			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x945C54", Offset = "0x945C54", VA = "0x945C54")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x945C5C", Offset = "0x945C5C", VA = "0x945C5C")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public LineSelectionEvent onLineSelection
		{
			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x945C64", Offset = "0x945C64", VA = "0x945C64")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005C1")]
			[Address(RVA = "0x945C6C", Offset = "0x945C6C", VA = "0x945C6C")]
			set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public LinkSelectionEvent onLinkSelection
		{
			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x945C74", Offset = "0x945C74", VA = "0x945C74")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x945C7C", Offset = "0x945C7C", VA = "0x945C7C")]
			set
			{
			}
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x945C84", Offset = "0x945C84", VA = "0x945C84")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x945E5C", Offset = "0x945E5C", VA = "0x945E5C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x9465A8", Offset = "0x9465A8", VA = "0x9465A8", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x9465AC", Offset = "0x9465AC", VA = "0x9465AC", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x946314", Offset = "0x946314", VA = "0x946314")]
		private void SendOnCharacterSelection(char character, int characterIndex)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x94638C", Offset = "0x94638C", VA = "0x94638C")]
		private void SendOnSpriteSelection(char character, int characterIndex)
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x946404", Offset = "0x946404", VA = "0x946404")]
		private void SendOnWordSelection(string word, int charIndex, int length)
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x946490", Offset = "0x946490", VA = "0x946490")]
		private void SendOnLineSelection(string line, int charIndex, int length)
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x94651C", Offset = "0x94651C", VA = "0x94651C")]
		private void SendOnLinkSelection(string linkID, string linkText, int linkIndex)
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x9465B0", Offset = "0x9465B0", VA = "0x9465B0")]
		public TMP_TextEventHandler()
		{
		}
	}
}
namespace TMPro.Examples
{
	[Token(Token = "0x200011B")]
	public class Benchmark01 : MonoBehaviour
	{
		[Token(Token = "0x200011C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67453C", Offset = "0x67453C")]
		private sealed class <Start>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Benchmark01 <>4__this;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x170000AD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005D8")]
				[Address(RVA = "0xC4BA4C", Offset = "0xC4BA4C", VA = "0xC4BA4C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005DA")]
				[Address(RVA = "0xC4BA94", Offset = "0xC4BA94", VA = "0xC4BA94", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005D5")]
			[Address(RVA = "0xC4B434", Offset = "0xC4B434", VA = "0xC4B434")]
			[DebuggerHidden]
			public <Start>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60005D6")]
			[Address(RVA = "0xC4B460", Offset = "0xC4B460", VA = "0xC4B460", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005D7")]
			[Address(RVA = "0xC4B464", Offset = "0xC4B464", VA = "0xC4B464", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005D9")]
			[Address(RVA = "0xC4BA54", Offset = "0xC4BA54", VA = "0xC4BA54", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int BenchmarkType;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TMP_FontAsset TMProFont;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Font TextMeshFont;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TextContainer m_textContainer;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMesh m_textMesh;

		[Token(Token = "0x40003EA")]
		private const string label01 = "The <#0050FF>count is: </color>{0}";

		[Token(Token = "0x40003EB")]
		private const string label02 = "The <color=#0050FF>count is: </color>";

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material m_material01;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_material02;

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x167F2AC", Offset = "0x167F2AC", VA = "0x167F2AC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x675AC8", Offset = "0x675AC8")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x167F324", Offset = "0x167F324", VA = "0x167F324")]
		public Benchmark01()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class Benchmark01_UGUI : MonoBehaviour
	{
		[Token(Token = "0x200011E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67454C", Offset = "0x67454C")]
		private sealed class <Start>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Benchmark01_UGUI <>4__this;

			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x170000AF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005E0")]
				[Address(RVA = "0xC4BF98", Offset = "0xC4BF98", VA = "0xC4BF98", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005E2")]
				[Address(RVA = "0xC4BFE0", Offset = "0xC4BFE0", VA = "0xC4BFE0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005DD")]
			[Address(RVA = "0xC4BA9C", Offset = "0xC4BA9C", VA = "0xC4BA9C")]
			[DebuggerHidden]
			public <Start>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60005DE")]
			[Address(RVA = "0xC4BAC8", Offset = "0xC4BAC8", VA = "0xC4BAC8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005DF")]
			[Address(RVA = "0xC4BACC", Offset = "0xC4BACC", VA = "0xC4BACC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005E1")]
			[Address(RVA = "0xC4BFA0", Offset = "0xC4BFA0", VA = "0xC4BFA0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int BenchmarkType;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Canvas canvas;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TMP_FontAsset TMProFont;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Font TextMeshFont;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TextMeshProUGUI m_textMeshPro;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Text m_textMesh;

		[Token(Token = "0x40003F8")]
		private const string label01 = "The <#0050FF>count is: </color>";

		[Token(Token = "0x40003F9")]
		private const string label02 = "The <color=#0050FF>count is: </color>";

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material m_material01;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_material02;

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x167F32C", Offset = "0x167F32C", VA = "0x167F32C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x675B78", Offset = "0x675B78")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x167F3A4", Offset = "0x167F3A4", VA = "0x167F3A4")]
		public Benchmark01_UGUI()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class Benchmark02 : MonoBehaviour
	{
		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int SpawnType;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int NumberOfNPC;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool IsTextObjectScaleStatic;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshProFloatingText floatingText_Script;

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x167F3AC", Offset = "0x167F3AC", VA = "0x167F3AC")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x167FA00", Offset = "0x167FA00", VA = "0x167FA00")]
		public Benchmark02()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public class Benchmark03 : MonoBehaviour
	{
		[Token(Token = "0x2000121")]
		public enum BenchmarkType
		{
			[Token(Token = "0x4000408")]
			TMP_SDF_MOBILE,
			[Token(Token = "0x4000409")]
			TMP_SDF__MOBILE_SSD,
			[Token(Token = "0x400040A")]
			TMP_SDF,
			[Token(Token = "0x400040B")]
			TMP_BITMAP_MOBILE,
			[Token(Token = "0x400040C")]
			TEXTMESH_BITMAP
		}

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int NumberOfSamples;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public BenchmarkType Benchmark;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Font SourceFont;

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x167FA10", Offset = "0x167FA10", VA = "0x167FA10")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x167FA14", Offset = "0x167FA14", VA = "0x167FA14")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x167FED0", Offset = "0x167FED0", VA = "0x167FED0")]
		public Benchmark03()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class Benchmark04 : MonoBehaviour
	{
		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int SpawnType;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int MinPointSize;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int MaxPointSize;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int Steps;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform m_Transform;

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x167FEE0", Offset = "0x167FEE0", VA = "0x167FEE0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x1680204", Offset = "0x1680204", VA = "0x1680204")]
		public Benchmark04()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public class CameraController : MonoBehaviour
	{
		[Token(Token = "0x2000124")]
		public enum CameraModes
		{
			[Token(Token = "0x400042C")]
			Follow,
			[Token(Token = "0x400042D")]
			Isometric,
			[Token(Token = "0x400042E")]
			Free
		}

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform cameraTransform;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform dummyTarget;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform CameraTarget;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float FollowDistance;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float MaxFollowDistance;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float MinFollowDistance;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float ElevationAngle;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float MaxElevationAngle;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float MinElevationAngle;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float OrbitalAngle;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public CameraModes CameraMode;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool MovementSmoothing;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool RotationSmoothing;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		private bool previousSmoothing;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float MovementSmoothingValue;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float RotationSmoothingValue;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float MoveSensitivity;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 currentVelocity;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 desiredPosition;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float mouseX;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float mouseY;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 moveVector;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float mouseWheel;

		[Token(Token = "0x4000429")]
		private const string event_SmoothingValue = "Slider - Smoothing Value";

		[Token(Token = "0x400042A")]
		private const string event_FollowDistance = "Slider - Camera Zoom";

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x1682360", Offset = "0x1682360", VA = "0x1682360")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x16823F0", Offset = "0x16823F0", VA = "0x16823F0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x16824F0", Offset = "0x16824F0", VA = "0x16824F0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x1682808", Offset = "0x1682808", VA = "0x1682808")]
		private void GetPlayerInput()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x1682FE0", Offset = "0x1682FE0", VA = "0x1682FE0")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000125")]
	public class ObjectSpin : MonoBehaviour
	{
		[Token(Token = "0x2000126")]
		public enum MotionType
		{
			[Token(Token = "0x400043A")]
			Rotation,
			[Token(Token = "0x400043B")]
			BackAndForth,
			[Token(Token = "0x400043C")]
			Translation
		}

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float SpinSpeed;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int RotationRange;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_transform;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_time;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 m_prevPOS;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_initial_Rotation;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_initial_Position;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Color32 m_lightColor;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int frames;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MotionType Motion;

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x962178", Offset = "0x962178", VA = "0x962178")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x9622A8", Offset = "0x9622A8", VA = "0x9622A8")]
		private void Update()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x9623E4", Offset = "0x9623E4", VA = "0x9623E4")]
		public ObjectSpin()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class ShaderPropAnimator : MonoBehaviour
	{
		[Token(Token = "0x2000128")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67455C", Offset = "0x67455C")]
		private sealed class <AnimateProperties>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ShaderPropAnimator <>4__this;

			[Token(Token = "0x170000B1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005F9")]
				[Address(RVA = "0xC523E0", Offset = "0xC523E0", VA = "0xC523E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005FB")]
				[Address(RVA = "0xC52428", Offset = "0xC52428", VA = "0xC52428", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005F6")]
			[Address(RVA = "0xC52244", Offset = "0xC52244", VA = "0xC52244")]
			[DebuggerHidden]
			public <AnimateProperties>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60005F7")]
			[Address(RVA = "0xC52270", Offset = "0xC52270", VA = "0xC52270", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005F8")]
			[Address(RVA = "0xC52274", Offset = "0xC52274", VA = "0xC52274", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005FA")]
			[Address(RVA = "0xC523E8", Offset = "0xC523E8", VA = "0xC523E8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Renderer m_Renderer;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve GlowCurve;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m_frame;

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x93EAB0", Offset = "0x93EAB0", VA = "0x93EAB0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x93EB30", Offset = "0x93EB30", VA = "0x93EB30")]
		private void Start()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x93EB5C", Offset = "0x93EB5C", VA = "0x93EB5C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x675C28", Offset = "0x675C28")]
		private IEnumerator AnimateProperties()
		{
			return null;
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x93EBD4", Offset = "0x93EBD4", VA = "0x93EBD4")]
		public ShaderPropAnimator()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class SimpleScript : MonoBehaviour
	{
		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x4000445")]
		private const string label = "The <#0050FF>count is: </color>{0:2}";

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_frame;

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x93EBDC", Offset = "0x93EBDC", VA = "0x93EBDC")]
		private void Start()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x93ECA4", Offset = "0x93ECA4", VA = "0x93ECA4")]
		private void Update()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x93ED3C", Offset = "0x93ED3C", VA = "0x93ED3C")]
		public SimpleScript()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public class SkewTextExample : MonoBehaviour
	{
		[Token(Token = "0x200012B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67456C", Offset = "0x67456C")]
		private sealed class <WarpText>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SkewTextExample <>4__this;

			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <old_CurveScale>5__2;

			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <old_ShearValue>5__3;

			[Token(Token = "0x4000450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private AnimationCurve <old_curve>5__4;

			[Token(Token = "0x170000B3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000607")]
				[Address(RVA = "0xC52CF0", Offset = "0xC52CF0", VA = "0xC52CF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000609")]
				[Address(RVA = "0xC52D38", Offset = "0xC52D38", VA = "0xC52D38", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000604")]
			[Address(RVA = "0xC52430", Offset = "0xC52430", VA = "0xC52430")]
			[DebuggerHidden]
			public <WarpText>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0xC5245C", Offset = "0xC5245C", VA = "0xC5245C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000606")]
			[Address(RVA = "0xC52460", Offset = "0xC52460", VA = "0xC52460", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000608")]
			[Address(RVA = "0xC52CF8", Offset = "0xC52CF8", VA = "0xC52CF8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve VertexCurve;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float CurveScale;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float ShearAmount;

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x93ED44", Offset = "0x93ED44", VA = "0x93ED44")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x93EDB0", Offset = "0x93EDB0", VA = "0x93EDB0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x93EE54", Offset = "0x93EE54", VA = "0x93EE54")]
		private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			return null;
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x93EDDC", Offset = "0x93EDDC", VA = "0x93EDDC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x675CD8", Offset = "0x675CD8")]
		private IEnumerator WarpText()
		{
			return null;
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x93EED8", Offset = "0x93EED8", VA = "0x93EED8")]
		public SkewTextExample()
		{
		}
	}
	[Token(Token = "0x200012C")]
	public class TMP_ExampleScript_01 : MonoBehaviour
	{
		[Token(Token = "0x200012D")]
		public enum objectType
		{
			[Token(Token = "0x4000457")]
			TextMeshPro,
			[Token(Token = "0x4000458")]
			TextMeshProUGUI
		}

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public objectType ObjectType;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool isStatic;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TMP_Text m_text;

		[Token(Token = "0x4000454")]
		private const string k_label = "The count is <#0080ff>{0}</color>";

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int count;

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x943BEC", Offset = "0x943BEC", VA = "0x943BEC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x943E08", Offset = "0x943E08", VA = "0x943E08")]
		private void Update()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x943EA0", Offset = "0x943EA0", VA = "0x943EA0")]
		public TMP_ExampleScript_01()
		{
		}
	}
	[Token(Token = "0x200012E")]
	public class TMP_FrameRateCounter : MonoBehaviour
	{
		[Token(Token = "0x200012F")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x4000464")]
			TopLeft,
			[Token(Token = "0x4000465")]
			BottomLeft,
			[Token(Token = "0x4000466")]
			TopRight,
			[Token(Token = "0x4000467")]
			BottomRight
		}

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float UpdateInterval;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_LastInterval;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_Frames;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string htmlColorTag;

		[Token(Token = "0x400045E")]
		private const string fpsLabel = "{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS";

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_frameCounter_transform;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Camera m_camera;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private FpsCounterAnchorPositions last_AnchorPosition;

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x943EA8", Offset = "0x943EA8", VA = "0x943EA8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x9442D8", Offset = "0x9442D8", VA = "0x9442D8")]
		private void Start()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x944304", Offset = "0x944304", VA = "0x944304")]
		private void Update()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x9440D0", Offset = "0x9440D0", VA = "0x9440D0")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x944474", Offset = "0x944474", VA = "0x944474")]
		public TMP_FrameRateCounter()
		{
		}
	}
	[Token(Token = "0x2000130")]
	public class TMP_TextEventCheck : MonoBehaviour
	{
		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TMP_TextEventHandler TextEventHandler;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x944914", Offset = "0x944914", VA = "0x944914")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x944C28", Offset = "0x944C28", VA = "0x944C28")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x944F04", Offset = "0x944F04", VA = "0x944F04")]
		private void OnCharacterSelection(char c, int index)
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x945144", Offset = "0x945144", VA = "0x945144")]
		private void OnSpriteSelection(char c, int index)
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x945384", Offset = "0x945384", VA = "0x945384")]
		private void OnWordSelection(string word, int firstCharacterIndex, int length)
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x945648", Offset = "0x945648", VA = "0x945648")]
		private void OnLineSelection(string lineText, int firstCharacterIndex, int length)
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x94590C", Offset = "0x94590C", VA = "0x94590C")]
		private void OnLinkSelection(string linkID, string linkText, int linkIndex)
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x945C2C", Offset = "0x945C2C", VA = "0x945C2C")]
		public TMP_TextEventCheck()
		{
		}
	}
	[Token(Token = "0x2000131")]
	public class TMP_TextInfoDebugTool : MonoBehaviour
	{
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x946708", Offset = "0x946708", VA = "0x946708")]
		public TMP_TextInfoDebugTool()
		{
		}
	}
	[Token(Token = "0x2000132")]
	public class TMP_TextSelector_A : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Camera m_Camera;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_isHoveringObject;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int m_selectedLink;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_lastCharIndex;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int m_lastWordIndex;

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x946710", Offset = "0x946710", VA = "0x946710")]
		private void Awake()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x9467B4", Offset = "0x9467B4", VA = "0x9467B4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x946ED4", Offset = "0x946ED4", VA = "0x946ED4", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x946F58", Offset = "0x946F58", VA = "0x946F58", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x946FD8", Offset = "0x946FD8", VA = "0x946FD8")]
		public TMP_TextSelector_A()
		{
		}
	}
	[Token(Token = "0x2000133")]
	public class TMP_TextSelector_B : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler, IPointerUpHandler
	{
		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RectTransform TextPopup_Prefab_01;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform m_TextPopup_RectTransform;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshProUGUI m_TextPopup_TMPComponent;

		[Token(Token = "0x4000473")]
		private const string k_LinkText = "You have selected link <#ffff00>";

		[Token(Token = "0x4000474")]
		private const string k_WordText = "Word Index: <#ffff00>";

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshProUGUI m_TextMeshPro;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Canvas m_Canvas;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Camera m_Camera;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool isHoveringObject;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int m_selectedWord;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_selectedLink;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_lastIndex;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Matrix4x4 m_matrix;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TMP_MeshInfo[] m_cachedMeshInfoVertexData;

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x946FF0", Offset = "0x946FF0", VA = "0x946FF0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x9471CC", Offset = "0x9471CC", VA = "0x9471CC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x9472BC", Offset = "0x9472BC", VA = "0x9472BC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x9473AC", Offset = "0x9473AC", VA = "0x9473AC")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x947464", Offset = "0x947464", VA = "0x947464")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x94895C", Offset = "0x94895C", VA = "0x94895C", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x948968", Offset = "0x948968", VA = "0x948968", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x948970", Offset = "0x948970", VA = "0x948970", Slot = "6")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x948974", Offset = "0x948974", VA = "0x948974", Slot = "7")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x9480CC", Offset = "0x9480CC", VA = "0x9480CC")]
		private void RestoreCachedVertexAttributes(int index)
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x948978", Offset = "0x948978", VA = "0x948978")]
		public TMP_TextSelector_B()
		{
		}
	}
	[Token(Token = "0x2000134")]
	public class TMP_UiFrameRateCounter : MonoBehaviour
	{
		[Token(Token = "0x2000135")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x4000488")]
			TopLeft,
			[Token(Token = "0x4000489")]
			BottomLeft,
			[Token(Token = "0x400048A")]
			TopRight,
			[Token(Token = "0x400048B")]
			BottomRight
		}

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float UpdateInterval;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_LastInterval;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_Frames;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string htmlColorTag;

		[Token(Token = "0x4000483")]
		private const string fpsLabel = "{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS";

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshProUGUI m_TextMeshPro;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RectTransform m_frameCounter_transform;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private FpsCounterAnchorPositions last_AnchorPosition;

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x948990", Offset = "0x948990", VA = "0x948990")]
		private void Awake()
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x948DF4", Offset = "0x948DF4", VA = "0x948DF4")]
		private void Start()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x948E20", Offset = "0x948E20", VA = "0x948E20")]
		private void Update()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x948BB0", Offset = "0x948BB0", VA = "0x948BB0")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x948F90", Offset = "0x948F90", VA = "0x948F90")]
		public TMP_UiFrameRateCounter()
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class TMPro_InstructionOverlay : MonoBehaviour
	{
		[Token(Token = "0x2000137")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x4000493")]
			TopLeft,
			[Token(Token = "0x4000494")]
			BottomLeft,
			[Token(Token = "0x4000495")]
			TopRight,
			[Token(Token = "0x4000496")]
			BottomRight
		}

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x400048D")]
		private const string instructions = "Camera Control - <#ffff00>Shift + RMB\n</color>Zoom - <#ffff00>Mouse wheel.";

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextContainer m_textContainer;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform m_frameCounter_transform;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Camera m_camera;

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x948FA8", Offset = "0x948FA8", VA = "0x948FA8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x949228", Offset = "0x949228", VA = "0x949228")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x949350", Offset = "0x949350", VA = "0x949350")]
		public TMPro_InstructionOverlay()
		{
		}
	}
	[Token(Token = "0x2000138")]
	public class TeleType : MonoBehaviour
	{
		[Token(Token = "0x2000139")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67457C", Offset = "0x67457C")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400049A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TeleType <>4__this;

			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <totalVisibleCharacters>5__2;

			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <counter>5__3;

			[Token(Token = "0x170000B5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000639")]
				[Address(RVA = "0xC53D10", Offset = "0xC53D10", VA = "0xC53D10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600063B")]
				[Address(RVA = "0xC53D58", Offset = "0xC53D58", VA = "0xC53D58", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000636")]
			[Address(RVA = "0xC53A88", Offset = "0xC53A88", VA = "0xC53A88")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000637")]
			[Address(RVA = "0xC53AB4", Offset = "0xC53AB4", VA = "0xC53AB4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000638")]
			[Address(RVA = "0xC53AB8", Offset = "0xC53AB8", VA = "0xC53AB8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600063A")]
			[Address(RVA = "0xC53D18", Offset = "0xC53D18", VA = "0xC53D18", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string label01;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string label02;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_textMeshPro;

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x949360", Offset = "0x949360", VA = "0x949360")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x949408", Offset = "0x949408", VA = "0x949408")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x675D88", Offset = "0x675D88")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x949480", Offset = "0x949480", VA = "0x949480")]
		public TeleType()
		{
		}
	}
	[Token(Token = "0x200013A")]
	public class TextConsoleSimulator : MonoBehaviour
	{
		[Token(Token = "0x200013B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67458C", Offset = "0x67458C")]
		private sealed class <RevealCharacters>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TMP_Text textComponent;

			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TextConsoleSimulator <>4__this;

			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <totalVisibleCharacters>5__3;

			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int <visibleCount>5__4;

			[Token(Token = "0x170000B7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000647")]
				[Address(RVA = "0xC53F10", Offset = "0xC53F10", VA = "0xC53F10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000649")]
				[Address(RVA = "0xC53F58", Offset = "0xC53F58", VA = "0xC53F58", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000644")]
			[Address(RVA = "0xC53D60", Offset = "0xC53D60", VA = "0xC53D60")]
			[DebuggerHidden]
			public <RevealCharacters>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0xC53D8C", Offset = "0xC53D8C", VA = "0xC53D8C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0xC53D90", Offset = "0xC53D90", VA = "0xC53D90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0xC53F18", Offset = "0xC53F18", VA = "0xC53F18", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200013C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67459C", Offset = "0x67459C")]
		private sealed class <RevealWords>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TMP_Text textComponent;

			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <totalWordCount>5__2;

			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <totalVisibleCharacters>5__3;

			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <counter>5__4;

			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <visibleCount>5__5;

			[Token(Token = "0x170000B9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600064D")]
				[Address(RVA = "0xC54184", Offset = "0xC54184", VA = "0xC54184", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600064F")]
				[Address(RVA = "0xC541CC", Offset = "0xC541CC", VA = "0xC541CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600064A")]
			[Address(RVA = "0xC53F60", Offset = "0xC53F60", VA = "0xC53F60")]
			[DebuggerHidden]
			public <RevealWords>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600064B")]
			[Address(RVA = "0xC53F8C", Offset = "0xC53F8C", VA = "0xC53F8C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600064C")]
			[Address(RVA = "0xC53F90", Offset = "0xC53F90", VA = "0xC53F90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600064E")]
			[Address(RVA = "0xC5418C", Offset = "0xC5418C", VA = "0xC5418C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool hasTextChanged;

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x949B94", Offset = "0x949B94", VA = "0x949B94")]
		private void Awake()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x949C00", Offset = "0x949C00", VA = "0x949C00")]
		private void Start()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x949CC4", Offset = "0x949CC4", VA = "0x949CC4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x949DB4", Offset = "0x949DB4", VA = "0x949DB4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x949EA4", Offset = "0x949EA4", VA = "0x949EA4")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x949C30", Offset = "0x949C30", VA = "0x949C30")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x675E38", Offset = "0x675E38")]
		private IEnumerator RevealCharacters(TMP_Text textComponent)
		{
			return null;
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x949EB0", Offset = "0x949EB0", VA = "0x949EB0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x675E98", Offset = "0x675E98")]
		private IEnumerator RevealWords(TMP_Text textComponent)
		{
			return null;
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x949F28", Offset = "0x949F28", VA = "0x949F28")]
		public TextConsoleSimulator()
		{
		}
	}
	[Token(Token = "0x200013D")]
	public class TextMeshProFloatingText : MonoBehaviour
	{
		[Token(Token = "0x200013E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6745AC", Offset = "0x6745AC")]
		private sealed class <DisplayTextMeshProFloatingText>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TextMeshProFloatingText <>4__this;

			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <CountDuration>5__2;

			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <starting_Count>5__3;

			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <current_Count>5__4;

			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 <start_pos>5__5;

			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Color32 <start_color>5__6;

			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float <alpha>5__7;

			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <fadeDuration>5__8;

			[Token(Token = "0x170000BB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000659")]
				[Address(RVA = "0xC54B44", Offset = "0xC54B44", VA = "0xC54B44", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600065B")]
				[Address(RVA = "0xC54B8C", Offset = "0xC54B8C", VA = "0xC54B8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000656")]
			[Address(RVA = "0xC546A8", Offset = "0xC546A8", VA = "0xC546A8")]
			[DebuggerHidden]
			public <DisplayTextMeshProFloatingText>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0xC546D4", Offset = "0xC546D4", VA = "0xC546D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000658")]
			[Address(RVA = "0xC546D8", Offset = "0xC546D8", VA = "0xC546D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600065A")]
			[Address(RVA = "0xC54B4C", Offset = "0xC54B4C", VA = "0xC54B4C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200013F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6745BC", Offset = "0x6745BC")]
		private sealed class <DisplayTextMeshFloatingText>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TextMeshProFloatingText <>4__this;

			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <CountDuration>5__2;

			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <starting_Count>5__3;

			[Token(Token = "0x40004CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <current_Count>5__4;

			[Token(Token = "0x40004CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 <start_pos>5__5;

			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Color32 <start_color>5__6;

			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float <alpha>5__7;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <fadeDuration>5__8;

			[Token(Token = "0x170000BD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600065F")]
				[Address(RVA = "0xC54658", Offset = "0xC54658", VA = "0xC54658", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000661")]
				[Address(RVA = "0xC546A0", Offset = "0xC546A0", VA = "0xC546A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0xC541D4", Offset = "0xC541D4", VA = "0xC541D4")]
			[DebuggerHidden]
			public <DisplayTextMeshFloatingText>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0xC54200", Offset = "0xC54200", VA = "0xC54200", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600065E")]
			[Address(RVA = "0xC54204", Offset = "0xC54204", VA = "0xC54204", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000660")]
			[Address(RVA = "0xC54660", Offset = "0xC54660", VA = "0xC54660", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Font TheFont;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject m_floatingText;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMesh m_textMesh;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_transform;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform m_floatingText_Transform;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform m_cameraTransform;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 lastPOS;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion lastRotation;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int SpawnType;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool IsTextObjectScaleStatic;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static WaitForEndOfFrame k_WaitForEndOfFrame;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static WaitForSeconds[] k_WaitForSecondsRandom;

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x949F30", Offset = "0x949F30", VA = "0x949F30")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x94A018", Offset = "0x94A018", VA = "0x94A018")]
		private void Start()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x94A434", Offset = "0x94A434", VA = "0x94A434")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x675F98", Offset = "0x675F98")]
		public IEnumerator DisplayTextMeshProFloatingText()
		{
			return null;
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x94A4AC", Offset = "0x94A4AC", VA = "0x94A4AC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x675FF8", Offset = "0x675FF8")]
		public IEnumerator DisplayTextMeshFloatingText()
		{
			return null;
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x94A524", Offset = "0x94A524", VA = "0x94A524")]
		public TextMeshProFloatingText()
		{
		}
	}
	[Token(Token = "0x2000140")]
	public class TextMeshSpawner : MonoBehaviour
	{
		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int SpawnType;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int NumberOfNPC;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Font TheFont;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshProFloatingText floatingText_Script;

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x94AC84", Offset = "0x94AC84", VA = "0x94AC84")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x94AC88", Offset = "0x94AC88", VA = "0x94AC88")]
		private void Start()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x94AFCC", Offset = "0x94AFCC", VA = "0x94AFCC")]
		public TextMeshSpawner()
		{
		}
	}
	[Token(Token = "0x2000141")]
	public class VertexColorCycler : MonoBehaviour
	{
		[Token(Token = "0x2000142")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6745CC", Offset = "0x6745CC")]
		private sealed class <AnimateVertexColors>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexColorCycler <>4__this;

			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <currentCharacter>5__3;

			[Token(Token = "0x170000BF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600066C")]
				[Address(RVA = "0xC5534C", Offset = "0xC5534C", VA = "0xC5534C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600066E")]
				[Address(RVA = "0xC55394", Offset = "0xC55394", VA = "0xC55394", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000669")]
			[Address(RVA = "0xC5503C", Offset = "0xC5503C", VA = "0xC5503C")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x600066A")]
			[Address(RVA = "0xC55068", Offset = "0xC55068", VA = "0xC55068", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600066B")]
			[Address(RVA = "0xC5506C", Offset = "0xC5506C", VA = "0xC5506C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600066D")]
			[Address(RVA = "0xC55354", Offset = "0xC55354", VA = "0xC55354", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x950378", Offset = "0x950378", VA = "0x950378")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x9503D4", Offset = "0x9503D4", VA = "0x9503D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x950400", Offset = "0x950400", VA = "0x950400")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6760F8", Offset = "0x6760F8")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x950478", Offset = "0x950478", VA = "0x950478")]
		public VertexColorCycler()
		{
		}
	}
	[Token(Token = "0x2000143")]
	public class VertexJitter : MonoBehaviour
	{
		[Token(Token = "0x2000144")]
		private struct VertexAnim
		{
			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float angleRange;

			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float angle;

			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float speed;
		}

		[Token(Token = "0x2000145")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6745DC", Offset = "0x6745DC")]
		private sealed class <AnimateVertexColors>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexJitter <>4__this;

			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <loopCount>5__3;

			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private VertexAnim[] <vertexAnim>5__4;

			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TMP_MeshInfo[] <cachedMeshInfo>5__5;

			[Token(Token = "0x170000C1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000679")]
				[Address(RVA = "0xC55C44", Offset = "0xC55C44", VA = "0xC55C44", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600067B")]
				[Address(RVA = "0xC55C8C", Offset = "0xC55C8C", VA = "0xC55C8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000676")]
			[Address(RVA = "0xC5539C", Offset = "0xC5539C", VA = "0xC5539C")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000677")]
			[Address(RVA = "0xC553C8", Offset = "0xC553C8", VA = "0xC553C8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000678")]
			[Address(RVA = "0xC553CC", Offset = "0xC553CC", VA = "0xC553CC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0xC55C4C", Offset = "0xC55C4C", VA = "0xC55C4C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CurveScale;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x950480", Offset = "0x950480", VA = "0x950480")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x9504DC", Offset = "0x9504DC", VA = "0x9504DC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x9505CC", Offset = "0x9505CC", VA = "0x9505CC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x9506BC", Offset = "0x9506BC", VA = "0x9506BC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x950760", Offset = "0x950760", VA = "0x950760")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x9506E8", Offset = "0x9506E8", VA = "0x9506E8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6761A8", Offset = "0x6761A8")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x9507E8", Offset = "0x9507E8", VA = "0x9507E8")]
		public VertexJitter()
		{
		}
	}
	[Token(Token = "0x2000146")]
	public class VertexShakeA : MonoBehaviour
	{
		[Token(Token = "0x2000147")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6745EC", Offset = "0x6745EC")]
		private sealed class <AnimateVertexColors>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexShakeA <>4__this;

			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3[][] <copyOfVertices>5__3;

			[Token(Token = "0x170000C3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000686")]
				[Address(RVA = "0xC566EC", Offset = "0xC566EC", VA = "0xC566EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000688")]
				[Address(RVA = "0xC56734", Offset = "0xC56734", VA = "0xC56734", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000683")]
			[Address(RVA = "0xC55C94", Offset = "0xC55C94", VA = "0xC55C94")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000684")]
			[Address(RVA = "0xC55CC0", Offset = "0xC55CC0", VA = "0xC55CC0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000685")]
			[Address(RVA = "0xC55CC4", Offset = "0xC55CC4", VA = "0xC55CC4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000687")]
			[Address(RVA = "0xC566F4", Offset = "0xC566F4", VA = "0xC566F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float ScaleMultiplier;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float RotationMultiplier;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x950800", Offset = "0x950800", VA = "0x950800")]
		private void Awake()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x95085C", Offset = "0x95085C", VA = "0x95085C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x95094C", Offset = "0x95094C", VA = "0x95094C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x950A3C", Offset = "0x950A3C", VA = "0x950A3C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x950AE0", Offset = "0x950AE0", VA = "0x950AE0")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x950A68", Offset = "0x950A68", VA = "0x950A68")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x676258", Offset = "0x676258")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x950B58", Offset = "0x950B58", VA = "0x950B58")]
		public VertexShakeA()
		{
		}
	}
	[Token(Token = "0x2000148")]
	public class VertexShakeB : MonoBehaviour
	{
		[Token(Token = "0x2000149")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6745FC", Offset = "0x6745FC")]
		private sealed class <AnimateVertexColors>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexShakeB <>4__this;

			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3[][] <copyOfVertices>5__3;

			[Token(Token = "0x170000C5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000693")]
				[Address(RVA = "0xC57620", Offset = "0xC57620", VA = "0xC57620", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000695")]
				[Address(RVA = "0xC57668", Offset = "0xC57668", VA = "0xC57668", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000690")]
			[Address(RVA = "0xC5673C", Offset = "0xC5673C", VA = "0xC5673C")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000691")]
			[Address(RVA = "0xC56768", Offset = "0xC56768", VA = "0xC56768", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000692")]
			[Address(RVA = "0xC5676C", Offset = "0xC5676C", VA = "0xC5676C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000694")]
			[Address(RVA = "0xC57628", Offset = "0xC57628", VA = "0xC57628", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CurveScale;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x950B68", Offset = "0x950B68", VA = "0x950B68")]
		private void Awake()
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x950BC4", Offset = "0x950BC4", VA = "0x950BC4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x950CB4", Offset = "0x950CB4", VA = "0x950CB4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x950DA4", Offset = "0x950DA4", VA = "0x950DA4")]
		private void Start()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x950E48", Offset = "0x950E48", VA = "0x950E48")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x950DD0", Offset = "0x950DD0", VA = "0x950DD0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x676308", Offset = "0x676308")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x950EC0", Offset = "0x950EC0", VA = "0x950EC0")]
		public VertexShakeB()
		{
		}
	}
	[Token(Token = "0x200014A")]
	public class VertexZoom : MonoBehaviour
	{
		[Token(Token = "0x200014B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67460C", Offset = "0x67460C")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<float> modifiedCharScale;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Comparison<int> <>9__0;

			[Token(Token = "0x600069D")]
			[Address(RVA = "0xC57670", Offset = "0xC57670", VA = "0xC57670")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0xC57678", Offset = "0xC57678", VA = "0xC57678")]
			internal int <AnimateVertexColors>b__0(int a, int b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200014C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67461C", Offset = "0x67461C")]
		private sealed class <AnimateVertexColors>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexZoom <>4__this;

			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private <>c__DisplayClass10_0 <>8__1;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TMP_MeshInfo[] <cachedMeshInfoVertexData>5__3;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private List<int> <scaleSortingOrder>5__4;

			[Token(Token = "0x170000C7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006A2")]
				[Address(RVA = "0xC5832C", Offset = "0xC5832C", VA = "0xC5832C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006A4")]
				[Address(RVA = "0xC58374", Offset = "0xC58374", VA = "0xC58374", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0xC57738", Offset = "0xC57738", VA = "0xC57738")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0xC57764", Offset = "0xC57764", VA = "0xC57764", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0xC57768", Offset = "0xC57768", VA = "0xC57768", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0xC58334", Offset = "0xC58334", VA = "0xC58334", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CurveScale;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x950ED8", Offset = "0x950ED8", VA = "0x950ED8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x950F34", Offset = "0x950F34", VA = "0x950F34")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x951024", Offset = "0x951024", VA = "0x951024")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x951114", Offset = "0x951114", VA = "0x951114")]
		private void Start()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x9511B8", Offset = "0x9511B8", VA = "0x9511B8")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x951140", Offset = "0x951140", VA = "0x951140")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6763B8", Offset = "0x6763B8")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x951240", Offset = "0x951240", VA = "0x951240")]
		public VertexZoom()
		{
		}
	}
	[Token(Token = "0x200014D")]
	public class WarpTextExample : MonoBehaviour
	{
		[Token(Token = "0x200014E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67462C", Offset = "0x67462C")]
		private sealed class <WarpText>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WarpTextExample <>4__this;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <old_CurveScale>5__2;

			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private AnimationCurve <old_curve>5__3;

			[Token(Token = "0x170000C9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006AD")]
				[Address(RVA = "0xC58B90", Offset = "0xC58B90", VA = "0xC58B90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006AF")]
				[Address(RVA = "0xC58BD8", Offset = "0xC58BD8", VA = "0xC58BD8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0xC5837C", Offset = "0xC5837C", VA = "0xC5837C")]
			[DebuggerHidden]
			public <WarpText>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0xC583A8", Offset = "0xC583A8", VA = "0xC583A8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006AC")]
			[Address(RVA = "0xC583AC", Offset = "0xC583AC", VA = "0xC583AC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006AE")]
			[Address(RVA = "0xC58B98", Offset = "0xC58B98", VA = "0xC58B98", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve VertexCurve;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float AngleMultiplier;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float SpeedMultiplier;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float CurveScale;

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x951258", Offset = "0x951258", VA = "0x951258")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x9512C4", Offset = "0x9512C4", VA = "0x9512C4")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x951368", Offset = "0x951368", VA = "0x951368")]
		private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			return null;
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x9512F0", Offset = "0x9512F0", VA = "0x9512F0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x676468", Offset = "0x676468")]
		private IEnumerator WarpText()
		{
			return null;
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x9513EC", Offset = "0x9513EC", VA = "0x9513EC")]
		public WarpTextExample()
		{
		}
	}
}
