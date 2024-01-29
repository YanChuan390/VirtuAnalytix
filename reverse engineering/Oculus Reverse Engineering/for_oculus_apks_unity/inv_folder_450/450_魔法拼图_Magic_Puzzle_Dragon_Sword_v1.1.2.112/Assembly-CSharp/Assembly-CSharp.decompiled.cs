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
	[Address(RVA = "0xF03960", Offset = "0xF03960", VA = "0xF03960")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xF03A24", Offset = "0xF03A24", VA = "0xF03A24")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xF03AE8", Offset = "0xF03AE8", VA = "0xF03AE8")]
	private void AddToChatOutput(string newText)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xF03F84", Offset = "0xF03F84", VA = "0xF03F84")]
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
	[Address(RVA = "0xF145B8", Offset = "0xF145B8", VA = "0xF145B8")]
	public void OnButtonClick()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xF146C4", Offset = "0xF146C4", VA = "0xF146C4")]
	public DropdownSample()
	{
	}
}
[Token(Token = "0x2000004")]
public class EnvMapAnimator : MonoBehaviour
{
	[Token(Token = "0x2000005")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73BFE4", Offset = "0x73BFE4")]
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
			[Address(RVA = "0x1063614", Offset = "0x1063614", VA = "0x1063614", Slot = "4")]
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
			[Address(RVA = "0x106365C", Offset = "0x106365C", VA = "0x106365C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x106342C", Offset = "0x106342C", VA = "0x106342C")]
		[DebuggerHidden]
		public <Start>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x1063458", Offset = "0x1063458", VA = "0x1063458", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x106345C", Offset = "0x106345C", VA = "0x106345C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x106361C", Offset = "0x106361C", VA = "0x106361C", Slot = "8")]
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
	[Address(RVA = "0xF14830", Offset = "0xF14830", VA = "0xF14830")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xF148B8", Offset = "0xF148B8", VA = "0xF148B8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73CCE8", Offset = "0x73CCE8")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xF14930", Offset = "0xF14930", VA = "0xF14930")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73BFF4", Offset = "0x73BFF4")]
	private struct <EnterMainScene>d__5 : IAsyncStateMachine
	{
		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x10615A0", Offset = "0x10615A0", VA = "0x10615A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1061704", Offset = "0x1061704", VA = "0x1061704", Slot = "5")]
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
	[Address(RVA = "0xEF8AAC", Offset = "0xEF8AAC", VA = "0xEF8AAC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xEF8C24", Offset = "0xEF8C24", VA = "0xEF8C24")]
	private void Start()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xEF9228", Offset = "0xEF9228", VA = "0xEF9228")]
	private void OnLoginBack(object Id)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xEF922C", Offset = "0xEF922C", VA = "0xEF922C")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x73CD98", Offset = "0x73CD98")]
	public void EnterMainScene()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xEF8B94", Offset = "0xEF8B94", VA = "0xEF8B94")]
	private void LoadEventHandle()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xEF92E0", Offset = "0xEF92E0", VA = "0xEF92E0")]
	public void OnPlatformBack(object data)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xEF9448", Offset = "0xEF9448", VA = "0xEF9448")]
	private void Update()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xEF94C8", Offset = "0xEF94C8", VA = "0xEF94C8")]
	public AppEntry()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xEF966C", Offset = "0xEF966C", VA = "0xEF966C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CDF8", Offset = "0x73CDF8")]
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
		[Address(RVA = "0x1061718", Offset = "0x1061718", VA = "0x1061718", Slot = "6")]
		public override void OnFinished(bool _result)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x106180C", Offset = "0x106180C", VA = "0x106180C")]
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
		[Address(RVA = "0x1061710", Offset = "0x1061710", VA = "0x1061710")]
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
	[Address(RVA = "0xEF972C", Offset = "0xEF972C", VA = "0xEF972C", Slot = "4")]
	public override string Desc()
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xEF8E58", Offset = "0xEF8E58", VA = "0xEF8E58")]
	public static AppInitOp Create()
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xEF978C", Offset = "0xEF978C", VA = "0xEF978C", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xEF9790", Offset = "0xEF9790", VA = "0xEF9790", Slot = "7")]
	public override bool OnExecute()
	{
		return default(bool);
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xEF986C", Offset = "0xEF986C", VA = "0xEF986C", Slot = "5")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xEF9874", Offset = "0xEF9874", VA = "0xEF9874")]
	private void RegisterModel()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xEF9964", Offset = "0xEF9964", VA = "0xEF9964")]
	private void LoadStaticConfig()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xEF9FF4", Offset = "0xEF9FF4", VA = "0xEF9FF4")]
	private void InitInstance()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xEFA430", Offset = "0xEFA430", VA = "0xEFA430")]
	private void UnZipfile(string[] filePathList)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xEFA5C8", Offset = "0xEFA5C8", VA = "0xEFA5C8")]
	private void OnZipFinish()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xEFA678", Offset = "0xEFA678", VA = "0xEFA678")]
	private void CombinConfig()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xEFAAC4", Offset = "0xEFAAC4", VA = "0xEFAAC4")]
	private void CombinConfigList(string directory, string subPath = "")
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xEFA924", Offset = "0xEFA924", VA = "0xEFA924")]
	private void CombinJson(string jsonStr, string fileName)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xEF9770", Offset = "0xEF9770", VA = "0xEF9770")]
	public AppInitOp()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xEFAC94", Offset = "0xEFAC94", VA = "0xEFAC94")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CE18", Offset = "0x73CE18")]
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
	[Address(RVA = "0xEFB758", Offset = "0xEFB758", VA = "0xEFB758")]
	private void Start()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xEFB82C", Offset = "0xEFB82C", VA = "0xEFB82C")]
	public void LoadAssetSuccess()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xEFB934", Offset = "0xEFB934", VA = "0xEFB934")]
	private void Update()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xEFB938", Offset = "0xEFB938", VA = "0xEFB938")]
	public AssetBundleTest()
	{
	}
}
[Token(Token = "0x200000E")]
public class Billboard2D : MonoBehaviour
{
	[Token(Token = "0x6000032")]
	[Address(RVA = "0xF00A3C", Offset = "0xF00A3C", VA = "0xF00A3C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xF00CC4", Offset = "0xF00CC4", VA = "0xF00CC4")]
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
	[Address(RVA = "0xF04390", Offset = "0xF04390", VA = "0xF04390", Slot = "4")]
	public virtual void HoverEntered(HoverEnterEventArgs hoverEnterEventArgs)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xF04408", Offset = "0xF04408", VA = "0xF04408", Slot = "5")]
	public virtual void HoverExited(HoverExitEventArgs hoverExitEventArgs)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xF04480", Offset = "0xF04480", VA = "0xF04480")]
	private void OnTriggerEvent(float value, XRRayInteractor hands, Transform handTrans)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xF04498", Offset = "0xF04498", VA = "0xF04498")]
	private void OnTriggerOffEvent()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xF044A4", Offset = "0xF044A4", VA = "0xF044A4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xF0486C", Offset = "0xF0486C", VA = "0xF0486C")]
	private void Update()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xF04954", Offset = "0xF04954", VA = "0xF04954")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xF04B00", Offset = "0xF04B00", VA = "0xF04B00")]
	public Common3dInteraction()
	{
	}
}
[Token(Token = "0x2000010")]
public abstract class AsyncOpBase
{
	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C4E8", Offset = "0x73C4E8")]
	private EAsyncOpStatus <Status>k__BackingField;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C4F8", Offset = "0x73C4F8")]
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
		[Address(RVA = "0xEFB940", Offset = "0xEFB940", VA = "0xEFB940")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CE28", Offset = "0x73CE28")]
		get
		{
			return default(EAsyncOpStatus);
		}
		[Token(Token = "0x600003D")]
		[Address(RVA = "0xEFB948", Offset = "0xEFB948", VA = "0xEFB948")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CE38", Offset = "0x73CE38")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000004")]
	internal object Result
	{
		[Token(Token = "0x600003E")]
		[Address(RVA = "0xEFB950", Offset = "0xEFB950", VA = "0xEFB950")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CE48", Offset = "0x73CE48")]
		get
		{
			return null;
		}
		[Token(Token = "0x600003F")]
		[Address(RVA = "0xEFB958", Offset = "0xEFB958", VA = "0xEFB958")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CE58", Offset = "0x73CE58")]
		private set
		{
		}
	}

	[Token(Token = "0x17000005")]
	internal IReadOnlyList<AsyncOpRef> Dependencies
	{
		[Token(Token = "0x6000040")]
		[Address(RVA = "0xEFB960", Offset = "0xEFB960", VA = "0xEFB960")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000006")]
	internal bool Done
	{
		[Token(Token = "0x6000041")]
		[Address(RVA = "0xEFB968", Offset = "0xEFB968", VA = "0xEFB968")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000007")]
	internal bool Executing
	{
		[Token(Token = "0x6000042")]
		[Address(RVA = "0xEFB97C", Offset = "0xEFB97C", VA = "0xEFB97C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000008")]
	internal bool Succeeded
	{
		[Token(Token = "0x6000043")]
		[Address(RVA = "0xEFB98C", Offset = "0xEFB98C", VA = "0xEFB98C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000009")]
	internal bool Failed
	{
		[Token(Token = "0x6000044")]
		[Address(RVA = "0xEFB99C", Offset = "0xEFB99C", VA = "0xEFB99C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000045")]
	public abstract string Desc();

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xEFA848", Offset = "0xEFA848", VA = "0xEFA848")]
	protected internal void Complete(object result, bool success)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xEF9774", Offset = "0xEF9774", VA = "0xEF9774")]
	public void Init()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xEFB9AC", Offset = "0xEFB9AC", VA = "0xEFB9AC")]
	public void Destroy()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xEFBB20", Offset = "0xEFBB20", VA = "0xEFBB20")]
	public bool AddDependent(AsyncOpBase r)
	{
		return default(bool);
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xEFBBC0", Offset = "0xEFBBC0", VA = "0xEFBBC0")]
	public bool AddSubOp(AsyncOpBase r)
	{
		return default(bool);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xEFBC6C", Offset = "0xEFBC6C", VA = "0xEFBC6C")]
	public object GetSubOpResult(int index)
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xEFBD04", Offset = "0xEFBD04", VA = "0xEFBD04")]
	private bool IsDependenciesDone(out bool success)
	{
		return default(bool);
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xEFBE28", Offset = "0xEFBE28", VA = "0xEFBE28")]
	private bool ExecuteImpl()
	{
		return default(bool);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xEFBE7C", Offset = "0xEFBE7C", VA = "0xEFBE7C")]
	public bool Execute()
	{
		return default(bool);
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xEFBEB4", Offset = "0xEFBEB4", VA = "0xEFBEB4")]
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
	[Address(RVA = "0xEFBF4C", Offset = "0xEFBF4C", VA = "0xEFBF4C")]
	public void Acquire()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xEFBF5C", Offset = "0xEFBF5C", VA = "0xEFBF5C")]
	public int Release()
	{
		return default(int);
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xEFABE4", Offset = "0xEFABE4", VA = "0xEFABE4")]
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
			[Address(RVA = "0x10618CC", Offset = "0x10618CC", VA = "0x10618CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x106181C", Offset = "0x106181C", VA = "0x106181C")]
		public AsyncOpNode(AsyncOpBase op, Action onComplete)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1061878", Offset = "0x1061878", VA = "0x1061878")]
		public void Complete()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x10618D4", Offset = "0x10618D4", VA = "0x10618D4")]
		public bool Update()
		{
			return default(bool);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x106191C", Offset = "0x106191C", VA = "0x106191C")]
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
	[Address(RVA = "0xEFBFA4", Offset = "0xEFBFA4", VA = "0xEFBFA4")]
	internal AsyncOpChannel(int index)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xEFC03C", Offset = "0xEFC03C", VA = "0xEFC03C")]
	internal void PushOp(AsyncOpBase r, Action onComplete)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xEFC0DC", Offset = "0xEFC0DC", VA = "0xEFC0DC")]
	private void ExecuteNext()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xEFC1A4", Offset = "0xEFC1A4", VA = "0xEFC1A4")]
	internal void Update()
	{
	}
}
[Token(Token = "0x2000013")]
public class AsyncOpDummy : AsyncOpBase
{
	[Token(Token = "0x600005F")]
	[Address(RVA = "0xEFC218", Offset = "0xEFC218", VA = "0xEFC218")]
	public static AsyncOpDummy Create()
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xEFC294", Offset = "0xEFC294", VA = "0xEFC294", Slot = "4")]
	public override string Desc()
	{
		return null;
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xEFC2D8", Offset = "0xEFC2D8", VA = "0xEFC2D8", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xEFC2DC", Offset = "0xEFC2DC", VA = "0xEFC2DC", Slot = "7")]
	public override bool OnExecute()
	{
		return default(bool);
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xEFC2FC", Offset = "0xEFC2FC", VA = "0xEFC2FC", Slot = "5")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xEFC290", Offset = "0xEFC290", VA = "0xEFC290")]
	public AsyncOpDummy()
	{
	}
}
[Token(Token = "0x2000014")]
public struct AsyncOpRef
{
	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C508", Offset = "0x73C508")]
	private AsyncOpBase <Op>k__BackingField;

	[Token(Token = "0x1700000B")]
	internal AsyncOpBase Op
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0xEFC300", Offset = "0xEFC300", VA = "0xEFC300")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CE68", Offset = "0x73CE68")]
		readonly get
		{
			return null;
		}
		[Token(Token = "0x6000066")]
		[Address(RVA = "0xEFC308", Offset = "0xEFC308", VA = "0xEFC308")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CEA0", Offset = "0x73CEA0")]
		private set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public bool Valid
	{
		[Token(Token = "0x6000069")]
		[Address(RVA = "0xEFC310", Offset = "0xEFC310", VA = "0xEFC310")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000D")]
	public object Result
	{
		[Token(Token = "0x600006A")]
		[Address(RVA = "0xEFA90C", Offset = "0xEFA90C", VA = "0xEFA90C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000E")]
	public bool Done
	{
		[Token(Token = "0x600006C")]
		[Address(RVA = "0xEFBDE4", Offset = "0xEFBDE4", VA = "0xEFBDE4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000F")]
	public bool Executing
	{
		[Token(Token = "0x600006D")]
		[Address(RVA = "0xEFC330", Offset = "0xEFC330", VA = "0xEFC330")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000010")]
	public bool Succeeded
	{
		[Token(Token = "0x600006E")]
		[Address(RVA = "0xEFBE08", Offset = "0xEFBE08", VA = "0xEFBE08")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000011")]
	public bool Failed
	{
		[Token(Token = "0x600006F")]
		[Address(RVA = "0xEFC350", Offset = "0xEFC350", VA = "0xEFC350")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xEF8ED0", Offset = "0xEF8ED0", VA = "0xEF8ED0")]
	internal AsyncOpRef(AsyncOpBase op)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xEF96EC", Offset = "0xEF96EC", VA = "0xEF96EC")]
	public int Release()
	{
		return default(int);
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xEFC320", Offset = "0xEFC320", VA = "0xEFC320")]
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
	[Address(RVA = "0xEF9538", Offset = "0xEF9538", VA = "0xEF9538")]
	public AsyncPipeline(int seqCount)
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xEF8F08", Offset = "0xEF8F08", VA = "0xEF8F08")]
	public void PushOp(AsyncOpBase r, [Optional] Action onComplete)
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xEF9460", Offset = "0xEF9460", VA = "0xEF9460")]
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
	[Address(RVA = "0xEFCC4C", Offset = "0xEFCC4C", VA = "0xEFCC4C")]
	public void Init(int id, string resName, Transform parent, bool is3DSound = false)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xEFCEC0", Offset = "0xEFCEC0", VA = "0xEFCEC0")]
	public void Init(int id, string resName, Transform parent, Vector3 pos, bool is3DSound = false)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xEFCF1C", Offset = "0xEFCF1C", VA = "0xEFCF1C")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xEFD094", Offset = "0xEFD094", VA = "0xEFD094")]
	private void OnLoadAudioClipComplete()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xEFD21C", Offset = "0xEFD21C", VA = "0xEFD21C")]
	public void Play(bool loop = false)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xEFD000", Offset = "0xEFD000", VA = "0xEFD000")]
	public void Stop()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xEFD1C0", Offset = "0xEFD1C0", VA = "0xEFD1C0")]
	private void PlayInternal()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xEFD2C0", Offset = "0xEFD2C0", VA = "0xEFD2C0")]
	public void SetVolume(float volume)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xEFD368", Offset = "0xEFD368", VA = "0xEFD368")]
	public bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xEFD464", Offset = "0xEFD464", VA = "0xEFD464")]
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
		[Address(RVA = "0xEFEC2C", Offset = "0xEFEC2C", VA = "0xEFEC2C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000089")]
		[Address(RVA = "0xEFEC90", Offset = "0xEFEC90", VA = "0xEFEC90")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public static bool EnableSound
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0xEFEDE4", Offset = "0xEFEDE4", VA = "0xEFEDE4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600008B")]
		[Address(RVA = "0xEFEE48", Offset = "0xEFEE48", VA = "0xEFEE48")]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public static float MusicVolume
	{
		[Token(Token = "0x600008C")]
		[Address(RVA = "0xEFF060", Offset = "0xEFF060", VA = "0xEFF060")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600008D")]
		[Address(RVA = "0xEFF0C4", Offset = "0xEFF0C4", VA = "0xEFF0C4")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public static float SoundVolume
	{
		[Token(Token = "0x600008E")]
		[Address(RVA = "0xEFF17C", Offset = "0xEFF17C", VA = "0xEFF17C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600008F")]
		[Address(RVA = "0xEFF1E0", Offset = "0xEFF1E0", VA = "0xEFF1E0")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	private static float FinalMusicVolume
	{
		[Token(Token = "0x6000090")]
		[Address(RVA = "0xEFE014", Offset = "0xEFE014", VA = "0xEFE014")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000017")]
	private static float FinalSoundVolume
	{
		[Token(Token = "0x6000091")]
		[Address(RVA = "0xEFE2F8", Offset = "0xEFE2F8", VA = "0xEFE2F8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xEFA248", Offset = "0xEFA248", VA = "0xEFA248")]
	public static void Init()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xEFD46C", Offset = "0xEFD46C", VA = "0xEFD46C")]
	public static void ClearAudio()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xEFDA88", Offset = "0xEFDA88", VA = "0xEFDA88")]
	public static void Destroy()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xEFDE3C", Offset = "0xEFDE3C", VA = "0xEFDE3C")]
	public static void PlayMusic(string resName)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xEFE0A4", Offset = "0xEFE0A4", VA = "0xEFE0A4")]
	public static void StopMusic()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xEFE158", Offset = "0xEFE158", VA = "0xEFE158")]
	public static int PlaySound2D(string resName)
	{
		return default(int);
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xEFE4EC", Offset = "0xEFE4EC", VA = "0xEFE4EC")]
	public static int PlaySound3D(string resName, Transform localTransfrm)
	{
		return default(int);
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xEFE684", Offset = "0xEFE684", VA = "0xEFE684")]
	public static void StopSound(int id)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xEFE710", Offset = "0xEFE710", VA = "0xEFE710")]
	private static Audio FindSound(int id, bool logError = true)
	{
		return null;
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xEFE7BC", Offset = "0xEFE7BC", VA = "0xEFE7BC")]
	private static void ReleaseSound(int id)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xEFE8C0", Offset = "0xEFE8C0", VA = "0xEFE8C0")]
	private static void Update()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xEFED3C", Offset = "0xEFED3C", VA = "0xEFED3C")]
	private static void ApplyMusicVolume()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xEFEEF4", Offset = "0xEFEEF4", VA = "0xEFEEF4")]
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
	[Address(RVA = "0xEFE388", Offset = "0xEFE388", VA = "0xEFE388")]
	public static Audio Requre(string resName, int Id, Transform parent, float volume)
	{
		return null;
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xEFD6C8", Offset = "0xEFD6C8", VA = "0xEFD6C8")]
	public static void Release(Audio audio)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xEFD848", Offset = "0xEFD848", VA = "0xEFD848")]
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
	private SpriteSetter m_spriteSetter;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool autoScale;

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xF1D1E0", Offset = "0xF1D1E0", VA = "0xF1D1E0")]
	private void Start()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xF1D1F4", Offset = "0xF1D1F4", VA = "0xF1D1F4")]
	public void SetSprite(int key)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xF1D464", Offset = "0xF1D464", VA = "0xF1D464")]
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
	[Address(RVA = "0xF1D474", Offset = "0xF1D474", VA = "0xF1D474")]
	private void Awake()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xF1D4D0", Offset = "0xF1D4D0", VA = "0xF1D4D0")]
	public void Start()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xF1D4D8", Offset = "0xF1D4D8", VA = "0xF1D4D8")]
	public void SetFont(int key)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xF1D5A8", Offset = "0xF1D5A8", VA = "0xF1D5A8")]
	private void SetFontStyle(int key)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xF1DA34", Offset = "0xF1DA34", VA = "0xF1DA34")]
	private void SetStyle(string styleKey)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xF1DC9C", Offset = "0xF1DC9C", VA = "0xF1DC9C")]
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

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xF21744", Offset = "0xF21744", VA = "0xF21744")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xF21A14", Offset = "0xF21A14", VA = "0xF21A14")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xF21A18", Offset = "0xF21A18", VA = "0xF21A18")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xF21748", Offset = "0xF21748", VA = "0xF21748")]
	public void RefreshSprite()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xF21A1C", Offset = "0xF21A1C", VA = "0xF21A1C")]
	public Sprite LoadSourceSprite(string relativePath)
	{
		return null;
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xF21B48", Offset = "0xF21B48", VA = "0xF21B48")]
	public MultiImage()
	{
	}
}
[Token(Token = "0x200001D")]
public class ParticleSystemCmpt : MonoBehaviour
{
	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xF22934", Offset = "0xF22934", VA = "0xF22934")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xF22A90", Offset = "0xF22A90", VA = "0xF22A90")]
	private void OnParticleSystemStopped()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xF22B04", Offset = "0xF22B04", VA = "0xF22B04")]
	public ParticleSystemCmpt()
	{
	}
}
[Token(Token = "0x200001E")]
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
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xF28030", Offset = "0xF28030", VA = "0xF28030")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xF280F4", Offset = "0xF280F4", VA = "0xF280F4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xF28100", Offset = "0xF28100", VA = "0xF28100")]
	private void OnResLoadComplete()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xF28188", Offset = "0xF28188", VA = "0xF28188")]
	public void SetTexture(string imageName, string parmName)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xF28204", Offset = "0xF28204", VA = "0xF28204")]
	private void LoadImage()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xF282EC", Offset = "0xF282EC", VA = "0xF282EC")]
	public RendererSetter()
	{
	}
}
[Token(Token = "0x200001F")]
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
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xE5BE0C", Offset = "0xE5BE0C", VA = "0xE5BE0C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xE5BEC0", Offset = "0xE5BEC0", VA = "0xE5BEC0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xE5BECC", Offset = "0xE5BECC", VA = "0xE5BECC")]
	private void OnResLoadComplete()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xE5C120", Offset = "0xE5C120", VA = "0xE5C120")]
	public void SetSprite(string imageName)
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xE5C188", Offset = "0xE5C188", VA = "0xE5C188")]
	private void LoadImage()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xE5C280", Offset = "0xE5C280", VA = "0xE5C280")]
	public SpriteSetter()
	{
	}
}
[Token(Token = "0x2000020")]
public class EventHandel : MonoBehaviour
{
	[Token(Token = "0x2000021")]
	public delegate void TriggerEvent(float value, XRRayInteractor hands, Transform handTrans);

	[Token(Token = "0x2000022")]
	public delegate void OnHoverEnteredEvent(Transform interactor, Transform hands);

	[Token(Token = "0x2000023")]
	public delegate void OnHoverExitedEvent(Transform interactor, Transform hands);

	[Token(Token = "0x2000024")]
	public delegate void OnSelectEnterEvent(Transform interactor, Transform hands);

	[Token(Token = "0x2000025")]
	public delegate void OnSelectExitEvent(Transform interactor, Transform hands);

	[Token(Token = "0x2000026")]
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

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xF14938", Offset = "0xF14938", VA = "0xF14938")]
	public void Awake()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xF1499C", Offset = "0xF1499C", VA = "0xF1499C")]
	public void OnHoverEntered(HoverEnterEventArgs hoverEnterEvent)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xF14B24", Offset = "0xF14B24", VA = "0xF14B24")]
	public void OnHoverExited(HoverExitEventArgs hoverExitEvent)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xF14CAC", Offset = "0xF14CAC", VA = "0xF14CAC")]
	public void OnSelectEnter(SelectEnterEventArgs selectEnterEvent)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xF14E34", Offset = "0xF14E34", VA = "0xF14E34")]
	public void OnSeleceExited(SelectExitEventArgs selectExitEvent)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xF14FBC", Offset = "0xF14FBC", VA = "0xF14FBC")]
	public void OnTrigger(float valus, XRRayInteractor xRRay, Transform handTrans)
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xF14FD0", Offset = "0xF14FD0", VA = "0xF14FD0")]
	public void OnTriggerClick()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xF14FE4", Offset = "0xF14FE4", VA = "0xF14FE4")]
	public void OnTriggerOff()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xF14FF8", Offset = "0xF14FF8", VA = "0xF14FF8")]
	public void OnPrimary2DAxis(Vector2 valus, Transform handTrans)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xF1500C", Offset = "0xF1500C", VA = "0xF1500C")]
	public EventHandel()
	{
	}
}
[Token(Token = "0x2000027")]
public class EventManager
{
	[Token(Token = "0x2000028")]
	private class ActionItem
	{
		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<object, Action<object>> actionList;

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1064C30", Offset = "0x1064C30", VA = "0x1064C30")]
		public ActionItem()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1064CB4", Offset = "0x1064CB4", VA = "0x1064CB4")]
		public void Add(Action<object> callback, object target)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1064E2C", Offset = "0x1064E2C", VA = "0x1064E2C")]
		public void Clear()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1064E80", Offset = "0x1064E80", VA = "0x1064E80")]
		public void Send(object parm)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1064FD0", Offset = "0x1064FD0", VA = "0x1064FD0")]
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
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xF15238", Offset = "0xF15238", VA = "0xF15238")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xF152FC", Offset = "0xF152FC", VA = "0xF152FC")]
	public EventManager()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xF15380", Offset = "0xF15380", VA = "0xF15380")]
	public void AddEvent(string eventKey, Action<object> callback, object target)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xF154B0", Offset = "0xF154B0", VA = "0xF154B0")]
	public void RemoveEvent(string eventKey, object target)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xF1557C", Offset = "0xF1557C", VA = "0xF1557C")]
	public void SendEvent(string eventKey, [Optional] object parm)
	{
	}
}
[Token(Token = "0x2000029")]
public class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static T instance;

	[Token(Token = "0x1700001B")]
	public static T Instance
	{
		[Token(Token = "0x60000E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000E5")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x60000E6")]
	public MonoSingleton()
	{
	}
}
[Token(Token = "0x200002A")]
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
		[Token(Token = "0x60000E7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000E8")]
	public Singleton()
	{
	}
}
[Token(Token = "0x200002B")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C518", Offset = "0x73C518")]
	private GameObject <GameObject>k__BackingField;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C528", Offset = "0x73C528")]
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
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xF24C24", Offset = "0xF24C24", VA = "0xF24C24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CEB0", Offset = "0x73CEB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xF24C2C", Offset = "0xF24C2C", VA = "0xF24C2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CEC0", Offset = "0x73CEC0")]
		private set
		{
		}
	}

	[Token(Token = "0x1700001E")]
	public Transform Transform
	{
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xF24C34", Offset = "0xF24C34", VA = "0xF24C34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CED0", Offset = "0x73CED0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xF24C3C", Offset = "0xF24C3C", VA = "0xF24C3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CEE0", Offset = "0x73CEE0")]
		private set
		{
		}
	}

	[Token(Token = "0x1700001F")]
	public bool Valid
	{
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xF24C44", Offset = "0xF24C44", VA = "0xF24C44")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xF24CB0", Offset = "0xF24CB0", VA = "0xF24CB0")]
	internal PrefabInstance(PrefabPoolNode pool)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xF24D08", Offset = "0xF24D08", VA = "0xF24D08")]
	public void Init(GameObject prefab)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xF24F40", Offset = "0xF24F40", VA = "0xF24F40")]
	public void Destroy()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xF24EAC", Offset = "0xF24EAC", VA = "0xF24EAC")]
	private void ActiveImpl()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xF2500C", Offset = "0xF2500C", VA = "0xF2500C")]
	internal void InternalAcquire(Action<object> onLoadComplete, [Optional] object extraParm)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xF25058", Offset = "0xF25058", VA = "0xF25058")]
	private void InternalRelease()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xF25094", Offset = "0xF25094", VA = "0xF25094")]
	public void Release()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xF251DC", Offset = "0xF251DC", VA = "0xF251DC")]
	public void SetParent(Transform transform)
	{
	}
}
[Token(Token = "0x200002C")]
public static class PrefabPool
{
	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Transform poolNodeTrans;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Dictionary<string, PrefabPoolNode> Nodes;

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xF252AC", Offset = "0xF252AC", VA = "0xF252AC")]
	public static void Init()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xF25414", Offset = "0xF25414", VA = "0xF25414")]
	public static void Destroy()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xF257C4", Offset = "0xF257C4", VA = "0xF257C4")]
	public static PrefabInstance CreateInstance(string prefabName, Action<object> onLoadComplete, [Optional] object extraParm)
	{
		return null;
	}
}
[Token(Token = "0x200002D")]
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

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xF25A44", Offset = "0xF25A44", VA = "0xF25A44")]
	internal void Init(string prefabName, Transform pooNode)
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xF255B0", Offset = "0xF255B0", VA = "0xF255B0")]
	internal void Destroy()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xF25EA4", Offset = "0xF25EA4", VA = "0xF25EA4")]
	private void Update()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xF261C8", Offset = "0xF261C8", VA = "0xF261C8")]
	private void OnLoadComplete()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0xF25C40", Offset = "0xF25C40", VA = "0xF25C40")]
	internal PrefabInstance CreateInstance(Action<object> onLoadComplete, [Optional] object extraParm)
	{
		return null;
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0xF250C8", Offset = "0xF250C8", VA = "0xF250C8")]
	internal void InternalFree(PrefabInstance inst)
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0xF2591C", Offset = "0xF2591C", VA = "0xF2591C")]
	public PrefabPoolNode()
	{
	}
}
[Token(Token = "0x200002E")]
public class AssetBundleAssetOp : ResAsyncOp
{
	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string resPath;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C538", Offset = "0x73C538")]
	private UnityEngine.Object <asset>k__BackingField;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private AssetBundleRequest requestOperation;

	[Token(Token = "0x17000020")]
	public UnityEngine.Object asset
	{
		[Token(Token = "0x6000103")]
		[Address(RVA = "0xEFAEA4", Offset = "0xEFAEA4", VA = "0xEFAEA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CEF0", Offset = "0x73CEF0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000104")]
		[Address(RVA = "0xEFAEAC", Offset = "0xEFAEAC", VA = "0xEFAEAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CF00", Offset = "0x73CF00")]
		private set
		{
		}
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0xEFAE9C", Offset = "0xEFAE9C", VA = "0xEFAE9C", Slot = "4")]
	public override string Desc()
	{
		return null;
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0xEFAEB4", Offset = "0xEFAEB4", VA = "0xEFAEB4")]
	public static AssetBundleAssetOp Create(string pathId)
	{
		return null;
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xEFAF5C", Offset = "0xEFAF5C", VA = "0xEFAF5C")]
	public void SetResPath(string path)
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0xEFAF64", Offset = "0xEFAF64", VA = "0xEFAF64", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xEFB00C", Offset = "0xEFB00C", VA = "0xEFB00C", Slot = "7")]
	public override bool OnExecute()
	{
		return default(bool);
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0xEFB2E0", Offset = "0xEFB2E0", VA = "0xEFB2E0", Slot = "5")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xEFB2E8", Offset = "0xEFB2E8", VA = "0xEFB2E8")]
	public void LocalRequestOperationCompleted(AsyncOperation operation)
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xEFAF54", Offset = "0xEFAF54", VA = "0xEFAF54")]
	public AssetBundleAssetOp()
	{
	}
}
[Token(Token = "0x200002F")]
public class AssetBundleOp : ResAsyncOp
{
	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string resPath;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C548", Offset = "0x73C548")]
	private AssetBundle <assetBundle>k__BackingField;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private AssetBundleCreateRequest requestOperation;

	[Token(Token = "0x17000021")]
	public AssetBundle assetBundle
	{
		[Token(Token = "0x600010D")]
		[Address(RVA = "0xEFB394", Offset = "0xEFB394", VA = "0xEFB394")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CF10", Offset = "0x73CF10")]
		get
		{
			return null;
		}
		[Token(Token = "0x600010E")]
		[Address(RVA = "0xEFB39C", Offset = "0xEFB39C", VA = "0xEFB39C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CF20", Offset = "0x73CF20")]
		private set
		{
		}
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xEFB38C", Offset = "0xEFB38C", VA = "0xEFB38C", Slot = "4")]
	public override string Desc()
	{
		return null;
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xEFB3A4", Offset = "0xEFB3A4", VA = "0xEFB3A4")]
	public static AssetBundleOp Create(string pathId)
	{
		return null;
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xEFB44C", Offset = "0xEFB44C", VA = "0xEFB44C")]
	public void SetResPaht(string resPath)
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xEFB480", Offset = "0xEFB480", VA = "0xEFB480", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xEFB5B8", Offset = "0xEFB5B8", VA = "0xEFB5B8", Slot = "7")]
	public override bool OnExecute()
	{
		return default(bool);
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xEFB700", Offset = "0xEFB700", VA = "0xEFB700")]
	private void LocalRequestOperationCompleted(AsyncOperation async)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xEFB750", Offset = "0xEFB750", VA = "0xEFB750", Slot = "5")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xEFB444", Offset = "0xEFB444", VA = "0xEFB444")]
	public AssetBundleOp()
	{
	}
}
[Token(Token = "0x2000030")]
public abstract class ResAsyncOp : AsyncOpBase
{
	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string Id;

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xF282F4", Offset = "0xF282F4", VA = "0xF282F4", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xF28448", Offset = "0xF28448", VA = "0xF28448", Slot = "5")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xF286AC", Offset = "0xF286AC", VA = "0xF286AC")]
	protected ResAsyncOp()
	{
	}
}
[Token(Token = "0x2000031")]
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
[Token(Token = "0x2000032")]
public class ResDefine
{
	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string ResRootPath;

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xF286B4", Offset = "0xF286B4", VA = "0xF286B4")]
	public ResDefine()
	{
	}
}
[Token(Token = "0x2000033")]
public struct LoadResArgs
{
	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C558", Offset = "0x73C558")]
	private ResType <resType>k__BackingField;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C568", Offset = "0x73C568")]
	private string <resPath>k__BackingField;

	[Token(Token = "0x17000022")]
	public ResType resType
	{
		[Token(Token = "0x600011B")]
		[Address(RVA = "0xF1F810", Offset = "0xF1F810", VA = "0xF1F810")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CF30", Offset = "0x73CF30")]
		readonly get
		{
			return default(ResType);
		}
		[Token(Token = "0x600011C")]
		[Address(RVA = "0xF1F818", Offset = "0xF1F818", VA = "0xF1F818")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CF68", Offset = "0x73CF68")]
		set
		{
		}
	}

	[Token(Token = "0x17000023")]
	public string resPath
	{
		[Token(Token = "0x600011D")]
		[Address(RVA = "0xF1F820", Offset = "0xF1F820", VA = "0xF1F820")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CF78", Offset = "0x73CF78")]
		readonly get
		{
			return null;
		}
		[Token(Token = "0x600011E")]
		[Address(RVA = "0xF1F828", Offset = "0xF1F828", VA = "0xF1F828")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CFB0", Offset = "0x73CFB0")]
		set
		{
		}
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xF1F830", Offset = "0xF1F830", VA = "0xF1F830")]
	public LoadResArgs(string resPath, ResType resType)
	{
	}
}
[Token(Token = "0x2000034")]
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

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xF28720", Offset = "0xF28720", VA = "0xF28720")]
	public static string GetResTypeName(ResType t)
	{
		return null;
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xF28DC0", Offset = "0xF28DC0", VA = "0xF28DC0")]
	public static Type GetAssetTypeByResType(ResType t)
	{
		return null;
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xF293D4", Offset = "0xF293D4", VA = "0xF293D4")]
	public static string GetResTypeFilterName(ResType t)
	{
		return null;
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xF29998", Offset = "0xF29998", VA = "0xF29998")]
	public static string GetResName(string assetName, ResType t)
	{
		return null;
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xF29A24", Offset = "0xF29A24", VA = "0xF29A24")]
	public static string GetResPath(string resName, bool isDlc)
	{
		return null;
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xF29C60", Offset = "0xF29C60", VA = "0xF29C60")]
	public static string SpliceResName(string resName)
	{
		return null;
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xF29CC0", Offset = "0xF29CC0", VA = "0xF29CC0")]
	public static bool ExitObbResManifest(string manifestPath)
	{
		return default(bool);
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xF29BFC", Offset = "0xF29BFC", VA = "0xF29BFC")]
	public static string StreamingAssetsPath()
	{
		return null;
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xF29AA4", Offset = "0xF29AA4", VA = "0xF29AA4")]
	public static string PersistentDataPath()
	{
		return null;
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xF29D74", Offset = "0xF29D74", VA = "0xF29D74")]
	public static string GetRegularPath(string path)
	{
		return null;
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0xF29EEC", Offset = "0xF29EEC", VA = "0xF29EEC")]
	public ResHelper()
	{
	}
}
[Token(Token = "0x2000035")]
public class ResItem
{
	[Token(Token = "0x600012B")]
	[Address(RVA = "0xF29EF4", Offset = "0xF29EF4", VA = "0xF29EF4")]
	public ResItem()
	{
	}
}
[Token(Token = "0x2000036")]
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

	[Token(Token = "0x600012C")]
	[Address(RVA = "0xF29EFC", Offset = "0xF29EFC", VA = "0xF29EFC")]
	public static void Init()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0xF2A124", Offset = "0xF2A124", VA = "0xF2A124")]
	public static void CombinManifest(string json)
	{
	}

	[Token(Token = "0x600012E")]
	public static T LoadResource<T>(string resPath) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0xF2A2C8", Offset = "0xF2A2C8", VA = "0xF2A2C8")]
	public static void ReleaseResourceAssets()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0xF2A34C", Offset = "0xF2A34C", VA = "0xF2A34C")]
	public static AsyncOpRef LoadAssetList(LoadResArgs[] args, Action onLoadSuccess)
	{
		return default(AsyncOpRef);
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xF239CC", Offset = "0xF239CC", VA = "0xF239CC")]
	public static void Update()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0xF284A8", Offset = "0xF284A8", VA = "0xF284A8")]
	public static void AddResToCache(ResAsyncOp op)
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0xF28358", Offset = "0xF28358", VA = "0xF28358")]
	public static void RemoveResFromCache(string id)
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xF25DF0", Offset = "0xF25DF0", VA = "0xF25DF0")]
	public static AsyncOpRef LoadAsset(string resPath, ResType resType, Action onLoadSuccess)
	{
		return default(AsyncOpRef);
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xF2A55C", Offset = "0xF2A55C", VA = "0xF2A55C")]
	public static AsyncOpRef LoadAssetBundle(string resPath, string[] dependencies, bool isDlc, Action onLoadSuccess)
	{
		return default(AsyncOpRef);
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xF2A490", Offset = "0xF2A490", VA = "0xF2A490")]
	private static AsyncOpBase CreateAssetOp(string resPath, ResType resType)
	{
		return null;
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xF2A8DC", Offset = "0xF2A8DC", VA = "0xF2A8DC")]
	private static AsyncOpBase CreateAssetEditorOp(string resPath, ResType resType)
	{
		return null;
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xF2A7F8", Offset = "0xF2A7F8", VA = "0xF2A7F8")]
	private static AsyncOpBase CreateAssetFromBundle(string resName)
	{
		return null;
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0xF2A628", Offset = "0xF2A628", VA = "0xF2A628")]
	private static AsyncOpBase CreateAssetBundleOp(string bundleName, string[] dependencies, bool isDlc)
	{
		return null;
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0xF2AA40", Offset = "0xF2AA40", VA = "0xF2AA40")]
	public static AsyncOpRef LoadScene(string sceneName, Action onLoadSuccess, [Optional] LoadResArgs[] otherAssets)
	{
		return default(AsyncOpRef);
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0xF2AB98", Offset = "0xF2AB98", VA = "0xF2AB98")]
	private static AsyncOpBase CreateSceneOp(string sceneName)
	{
		return null;
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0xF2A8E4", Offset = "0xF2A8E4", VA = "0xF2A8E4")]
	private static ResManifest.Item GetResInfoByAssetName(string assetName)
	{
		return null;
	}

	[Token(Token = "0x600013D")]
	public static T LoadJsonFromPathSync<T>(string fullPath) where T : class
	{
		return null;
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0xF2AD0C", Offset = "0xF2AD0C", VA = "0xF2AD0C")]
	public static string LoadJsonFromPath(string fullPath)
	{
		return null;
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xF2AFF4", Offset = "0xF2AFF4", VA = "0xF2AFF4")]
	public static string LoadTextFromFileSync(string path)
	{
		return null;
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0xF2ADE0", Offset = "0xF2ADE0", VA = "0xF2ADE0")]
	public static string LoadTextWithWebRequestSync(string path)
	{
		return null;
	}
}
[Token(Token = "0x2000037")]
public class ResManifest : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000038")]
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

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1068254", Offset = "0x1068254", VA = "0x1068254")]
		public Item()
		{
		}
	}

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Item[] Items;

	[Token(Token = "0x6000142")]
	[Address(RVA = "0xF2B144", Offset = "0xF2B144", VA = "0xF2B144")]
	public ResManifest()
	{
	}
}
[Token(Token = "0x2000039")]
public class SceneOP : ResAsyncOp
{
	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string sceneName;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private AsyncOperation operation;

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xF2AC7C", Offset = "0xF2AC7C", VA = "0xF2AC7C")]
	public static SceneOP Create(string sceneName)
	{
		return null;
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0xF2D434", Offset = "0xF2D434", VA = "0xF2D434", Slot = "5")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0xF2D438", Offset = "0xF2D438", VA = "0xF2D438", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0xF2D4B0", Offset = "0xF2D4B0", VA = "0xF2D4B0", Slot = "7")]
	public override bool OnExecute()
	{
		return default(bool);
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0xF2D5B4", Offset = "0xF2D5B4", VA = "0xF2D5B4")]
	private void LoadSceneCompleted(AsyncOperation op)
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0xF2D5EC", Offset = "0xF2D5EC", VA = "0xF2D5EC", Slot = "4")]
	public override string Desc()
	{
		return null;
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0xF2D42C", Offset = "0xF2D42C", VA = "0xF2D42C")]
	public SceneOP()
	{
	}
}
[Token(Token = "0x200003A")]
public class AnimationEventSound : MonoBehaviour
{
	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip audioClip1;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioClip audioClip2;

	[Token(Token = "0x600014B")]
	[Address(RVA = "0xEF862C", Offset = "0xEF862C", VA = "0xEF862C")]
	public void PlaySound1()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0xEF870C", Offset = "0xEF870C", VA = "0xEF870C")]
	public void PlaySound2()
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0xEF87EC", Offset = "0xEF87EC", VA = "0xEF87EC")]
	public AnimationEventSound()
	{
	}
}
[Token(Token = "0x200003B")]
public class SoundManager : MonoSingleton<SoundManager>
{
	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource _audioSource;

	[Token(Token = "0x600014E")]
	[Address(RVA = "0xE5BCC4", Offset = "0xE5BCC4", VA = "0xE5BCC4", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0xE5BD50", Offset = "0xE5BD50", VA = "0xE5BD50")]
	public void PlaySound(AudioClip clip, bool loop = false)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0xE5BDA4", Offset = "0xE5BDA4", VA = "0xE5BDA4")]
	public void StopSound()
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0xE5BDC0", Offset = "0xE5BDC0", VA = "0xE5BDC0")]
	public SoundManager()
	{
	}
}
[Token(Token = "0x200003C")]
public class EdenButton : Button
{
	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public string clickAudio;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73C578", Offset = "0x73C578")]
	public AudioClip clickSound;

	[Token(Token = "0x6000152")]
	[Address(RVA = "0xF146CC", Offset = "0xF146CC", VA = "0xF146CC", Slot = "41")]
	public override void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0xF147E4", Offset = "0xF147E4", VA = "0xF147E4")]
	public EdenButton()
	{
	}
}
[Token(Token = "0x200003D")]
public class Empty4Raycast : MaskableGraphic
{
	[Token(Token = "0x6000154")]
	[Address(RVA = "0xF147EC", Offset = "0xF147EC", VA = "0xF147EC")]
	protected Empty4Raycast()
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0xF14814", Offset = "0xF14814", VA = "0xF14814", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}
}
[Token(Token = "0x200003E")]
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
		[Token(Token = "0x6000156")]
		[Address(RVA = "0xF1FE24", Offset = "0xF1FE24", VA = "0xF1FE24")]
		set
		{
		}
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0xF1FE2C", Offset = "0xF1FE2C", VA = "0xF1FE2C", Slot = "34")]
	public override void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0xF1FE48", Offset = "0xF1FE48", VA = "0xF1FE48", Slot = "35")]
	public override void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0xF1FE64", Offset = "0xF1FE64", VA = "0xF1FE64", Slot = "32")]
	public override void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0xF1FED0", Offset = "0xF1FED0", VA = "0xF1FED0", Slot = "33")]
	public override void OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0xF1FF0C", Offset = "0xF1FF0C", VA = "0xF1FF0C", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0xF1FF14", Offset = "0xF1FF14", VA = "0xF1FF14")]
	private void Update()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0xF1FF78", Offset = "0xF1FF78", VA = "0xF1FF78")]
	public LongPressBtnImmediately()
	{
	}
}
[Token(Token = "0x200003F")]
public class LongPressedAni : MonoBehaviour
{
	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LongPressedButton longPressedButton;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73C5B0", Offset = "0x73C5B0")]
	public float longPressTime;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73C5E8", Offset = "0x73C5E8")]
	public Image imgFront;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73C620", Offset = "0x73C620")]
	public Image imgAni;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73C658", Offset = "0x73C658")]
	public Action OnPressEnd;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string clickAudio;

	[Token(Token = "0x600015E")]
	[Address(RVA = "0xF200D0", Offset = "0xF200D0", VA = "0xF200D0")]
	private void Start()
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0xF202BC", Offset = "0xF202BC", VA = "0xF202BC")]
	private void onExit()
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0xF202F4", Offset = "0xF202F4", VA = "0xF202F4")]
	private void OnEnter()
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0xF20330", Offset = "0xF20330", VA = "0xF20330")]
	private void OnLongPressBegin()
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0xF20440", Offset = "0xF20440", VA = "0xF20440")]
	private void OnLongPressEnd()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0xF204A0", Offset = "0xF204A0", VA = "0xF204A0")]
	private void onLongPressCancel()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0xF20374", Offset = "0xF20374", VA = "0xF20374")]
	protected void PlaySound()
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0xF204F0", Offset = "0xF204F0", VA = "0xF204F0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0xF20624", Offset = "0xF20624", VA = "0xF20624")]
	public LongPressedAni()
	{
	}
}
[Token(Token = "0x2000040")]
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
		[Token(Token = "0x6000167")]
		[Address(RVA = "0xF20634", Offset = "0xF20634", VA = "0xF20634")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0xF2063C", Offset = "0xF2063C", VA = "0xF2063C", Slot = "34")]
	public override void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0xF20658", Offset = "0xF20658", VA = "0xF20658", Slot = "35")]
	public override void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0xF2068C", Offset = "0xF2068C", VA = "0xF2068C", Slot = "32")]
	public override void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0xF206DC", Offset = "0xF206DC", VA = "0xF206DC", Slot = "33")]
	public override void OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0xF2060C", Offset = "0xF2060C", VA = "0xF2060C")]
	public float Progress()
	{
		return default(float);
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0xF206E4", Offset = "0xF206E4", VA = "0xF206E4", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0xF2074C", Offset = "0xF2074C", VA = "0xF2074C")]
	private void Update()
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0xF207E8", Offset = "0xF207E8", VA = "0xF207E8")]
	public LongPressedButton()
	{
	}
}
[Token(Token = "0x2000041")]
public class PointTrigger : Selectable
{
	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73C690", Offset = "0x73C690")]
	public Button.ButtonClickedEvent onPointDown;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public string pointDownAudio;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73C6C8", Offset = "0x73C6C8")]
	public Button.ButtonClickedEvent onPointUp;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public string pointUpClip;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73C700", Offset = "0x73C700")]
	public Button.ButtonClickedEvent onPointEnter;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public string pointEnterClip;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73C738", Offset = "0x73C738")]
	public Button.ButtonClickedEvent onPointExit;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public string pointExitClip;

	[Token(Token = "0x6000170")]
	[Address(RVA = "0xF24238", Offset = "0xF24238", VA = "0xF24238")]
	private void PlayerSound(string audio)
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0xF2429C", Offset = "0xF2429C", VA = "0xF2429C", Slot = "32")]
	public override void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0xF242D0", Offset = "0xF242D0", VA = "0xF242D0", Slot = "33")]
	public override void OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0xF24304", Offset = "0xF24304", VA = "0xF24304", Slot = "34")]
	public override void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0xF24338", Offset = "0xF24338", VA = "0xF24338", Slot = "35")]
	public override void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0xF2436C", Offset = "0xF2436C", VA = "0xF2436C")]
	public PointTrigger()
	{
	}
}
[Token(Token = "0x2000042")]
public class Portal : MonoBehaviour
{
	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LongPressBtnImmediately longPressedButton;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73C770", Offset = "0x73C770")]
	public float longPressTime;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73C7A8", Offset = "0x73C7A8")]
	public int themeIndex;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73C7E0", Offset = "0x73C7E0")]
	public string sceneName;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Animator ani;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73C818", Offset = "0x73C818")]
	public float delayEnterTime;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject pressGO1;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Animator pressAni2;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73C850", Offset = "0x73C850")]
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

	[Token(Token = "0x6000176")]
	[Address(RVA = "0xF24480", Offset = "0xF24480", VA = "0xF24480")]
	private void Start()
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0xF245BC", Offset = "0xF245BC", VA = "0xF245BC")]
	private void OnEnter()
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0xF245EC", Offset = "0xF245EC", VA = "0xF245EC")]
	private void onExit()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0xF2461C", Offset = "0xF2461C", VA = "0xF2461C")]
	private void OnLongPressEnd()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0xF246E0", Offset = "0xF246E0", VA = "0xF246E0")]
	private void OnLongPressBegin()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0xF247BC", Offset = "0xF247BC", VA = "0xF247BC")]
	private void OnLongPressed()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0xF24908", Offset = "0xF24908", VA = "0xF24908")]
	private void ResetAni()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0xF24980", Offset = "0xF24980", VA = "0xF24980")]
	public void EnterScene()
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0xF24754", Offset = "0xF24754", VA = "0xF24754")]
	private void PlayStartSound()
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0xF248A0", Offset = "0xF248A0", VA = "0xF248A0")]
	private void PlayEndSound()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0xF24C04", Offset = "0xF24C04", VA = "0xF24C04")]
	public Portal()
	{
	}
}
[Token(Token = "0x2000043")]
public class PrefabReference : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000044")]
	private class Property
	{
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityEngine.Object Value;

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x106824C", Offset = "0x106824C", VA = "0x106824C")]
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

	[Token(Token = "0x6000181")]
	[Address(RVA = "0xF261CC", Offset = "0xF261CC", VA = "0xF261CC")]
	private void InitDictionary()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0xF262C4", Offset = "0xF262C4", VA = "0xF262C4")]
	public UnityEngine.Object TryGetProperty(Type t, string name)
	{
		return null;
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0xF26364", Offset = "0xF26364", VA = "0xF26364")]
	public UnityEngine.Object GetProperty(Type t, string name)
	{
		return null;
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0xF2636C", Offset = "0xF2636C", VA = "0xF2636C")]
	public UnityEngine.Object GetProperty(string name)
	{
		return null;
	}

	[Token(Token = "0x6000185")]
	public T GetProperty<T>(string name) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0xF262CC", Offset = "0xF262CC", VA = "0xF262CC")]
	private UnityEngine.Object GetPropertyInternal(Type t, string name, bool logError)
	{
		return null;
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0xF26404", Offset = "0xF26404", VA = "0xF26404")]
	public void ForEachProperties(Action<string, UnityEngine.Object> action)
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0xF264B0", Offset = "0xF264B0", VA = "0xF264B0")]
	public PrefabReference()
	{
	}
}
[Token(Token = "0x2000045")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C8B8", Offset = "0x73C8B8")]
	private GameObject <uiGameObject>k__BackingField;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C8C8", Offset = "0x73C8C8")]
	private Transform <uiTransform>k__BackingField;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<string> mEventKeyList;

	[Token(Token = "0x17000026")]
	public GameObject uiGameObject
	{
		[Token(Token = "0x600018A")]
		[Address(RVA = "0xE6BC94", Offset = "0xE6BC94", VA = "0xE6BC94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CFC0", Offset = "0x73CFC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600018B")]
		[Address(RVA = "0xE6BC9C", Offset = "0xE6BC9C", VA = "0xE6BC9C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CFD0", Offset = "0x73CFD0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000027")]
	protected Transform uiTransform
	{
		[Token(Token = "0x600018C")]
		[Address(RVA = "0xE6BCA4", Offset = "0xE6BCA4", VA = "0xE6BCA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CFE0", Offset = "0x73CFE0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600018D")]
		[Address(RVA = "0xE6BCAC", Offset = "0xE6BCAC", VA = "0xE6BCAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CFF0", Offset = "0x73CFF0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000028")]
	internal abstract string Name
	{
		[Token(Token = "0x6000190")]
		get;
	}

	[Token(Token = "0x17000029")]
	protected abstract string PrefabName
	{
		[Token(Token = "0x6000191")]
		get;
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0xE6BCB4", Offset = "0xE6BCB4", VA = "0xE6BCB4")]
	public void CreateGameObject(GameObject prefab, Transform parent)
	{
	}

	[Token(Token = "0x600018F")]
	public T GetProperty<T>(string name) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0xE6BDD8", Offset = "0xE6BDD8", VA = "0xE6BDD8")]
	internal void Show()
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0xE6BE7C", Offset = "0xE6BE7C", VA = "0xE6BE7C")]
	internal void Hide()
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0xE6BF2C", Offset = "0xE6BF2C", VA = "0xE6BF2C")]
	public void Destroy()
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0xE6C064", Offset = "0xE6C064", VA = "0xE6C064")]
	public void AddEvent(string eventKey, Action<object> action)
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0xE6C118", Offset = "0xE6C118", VA = "0xE6C118", Slot = "6")]
	public virtual void OnCreate()
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0xE6C11C", Offset = "0xE6C11C", VA = "0xE6C11C", Slot = "7")]
	public virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0xE6C120", Offset = "0xE6C120", VA = "0xE6C120", Slot = "8")]
	public virtual void OnOpen(object args)
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0xE6C124", Offset = "0xE6C124", VA = "0xE6C124", Slot = "9")]
	public virtual void OnClose()
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0xE6C128", Offset = "0xE6C128", VA = "0xE6C128")]
	protected UIBase()
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0xE6C1AC", Offset = "0xE6C1AC", VA = "0xE6C1AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D000", Offset = "0x73D000")]
	private void <Destroy>b__20_0(string key)
	{
	}
}
[Token(Token = "0x2000046")]
public static class UIManager
{
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C004", Offset = "0x73C004")]
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

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x106B338", Offset = "0x106B338", VA = "0x106B338")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x106B340", Offset = "0x106B340", VA = "0x106B340")]
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

	[Token(Token = "0x600019C")]
	[Address(RVA = "0xE6C230", Offset = "0xE6C230", VA = "0xE6C230")]
	internal static bool Init(UIManifest manifest)
	{
		return default(bool);
	}

	[Token(Token = "0x600019D")]
	public static void OpenWindow<T>([Optional] object args) where T : UIWindow
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0xE6C42C", Offset = "0xE6C42C", VA = "0xE6C42C")]
	public static void OpenWindow(Type type, [Optional] object args)
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0xE6C4BC", Offset = "0xE6C4BC", VA = "0xE6C4BC")]
	private static void OpenWindow(string name, [Optional] object args)
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0xE6C730", Offset = "0xE6C730", VA = "0xE6C730")]
	public static Transform GetUIParent(int orderLevel)
	{
		return null;
	}

	[Token(Token = "0x60001A1")]
	public static void CloseWindow<T>() where T : UIWindow
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0xE6C738", Offset = "0xE6C738", VA = "0xE6C738")]
	public static void CloseWindow(string name)
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0xE585DC", Offset = "0xE585DC", VA = "0xE585DC")]
	public static void CloaseAll()
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0xE6C80C", Offset = "0xE6C80C", VA = "0xE6C80C")]
	public static UIWindow GetWindow(string name)
	{
		return null;
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0xE5E568", Offset = "0xE5E568", VA = "0xE5E568")]
	public static void ShowConfirmWindow(Transform par, int contentKey, UnityAction confirmCb)
	{
	}
}
[Token(Token = "0x2000048")]
public class UIManifest
{
	[Token(Token = "0x2000049")]
	public class Window
	{
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C8E8", Offset = "0x73C8E8")]
		private int <OrderLevel>k__BackingField;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C8F8", Offset = "0x73C8F8")]
		private string <Name>k__BackingField;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C908", Offset = "0x73C908")]
		private string <PrefabName>k__BackingField;

		[Token(Token = "0x1700002B")]
		public int OrderLevel
		{
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x106B5C4", Offset = "0x106B5C4", VA = "0x106B5C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D030", Offset = "0x73D030")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x106B5CC", Offset = "0x106B5CC", VA = "0x106B5CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D040", Offset = "0x73D040")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public string Name
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x106B5D4", Offset = "0x106B5D4", VA = "0x106B5D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D050", Offset = "0x73D050")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x106B5DC", Offset = "0x106B5DC", VA = "0x106B5DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D060", Offset = "0x73D060")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public string PrefabName
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x106B5E4", Offset = "0x106B5E4", VA = "0x106B5E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D070", Offset = "0x73D070")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x106B5EC", Offset = "0x106B5EC", VA = "0x106B5EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D080", Offset = "0x73D080")]
			private set
			{
			}
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x106B5F4", Offset = "0x106B5F4", VA = "0x106B5F4")]
		public Window()
		{
		}
	}

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C8D8", Offset = "0x73C8D8")]
	private Window[] <Windows>k__BackingField;

	[Token(Token = "0x1700002A")]
	public Window[] Windows
	{
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xE6C998", Offset = "0xE6C998", VA = "0xE6C998")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D010", Offset = "0x73D010")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xE6C9A0", Offset = "0xE6C9A0", VA = "0xE6C9A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D020", Offset = "0x73D020")]
		private set
		{
		}
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0xE6C9A8", Offset = "0xE6C9A8", VA = "0xE6C9A8")]
	public UIManifest()
	{
	}
}
[Token(Token = "0x200004A")]
public abstract class UIWindow : UIBase
{
	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C918", Offset = "0x73C918")]
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
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xE6C9B0", Offset = "0xE6C9B0", VA = "0xE6C9B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D090", Offset = "0x73D090")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xE6C9B8", Offset = "0xE6C9B8", VA = "0xE6C9B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D0A0", Offset = "0x73D0A0")]
		set
		{
		}
	}

	[Token(Token = "0x1700002F")]
	internal override string Name
	{
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xE6C9C0", Offset = "0xE6C9C0", VA = "0xE6C9C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000030")]
	protected override string PrefabName
	{
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xE6C9DC", Offset = "0xE6C9DC", VA = "0xE6C9DC", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0xE6C3F4", Offset = "0xE6C3F4", VA = "0xE6C3F4")]
	public bool Create(UIManifest.Window windowConifg)
	{
		return default(bool);
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0xE6C624", Offset = "0xE6C624", VA = "0xE6C624")]
	public void OpenInternal([Optional] object args)
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0xE6C9F8", Offset = "0xE6C9F8", VA = "0xE6C9F8")]
	public void PrefabLoadSuccess()
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0xE6C8B8", Offset = "0xE6C8B8", VA = "0xE6C8B8")]
	public void CloseInternal()
	{
	}

	[Token(Token = "0x60001BB")]
	public void OpenWindow<T>([Optional] object args) where T : UIWindow
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0xE6CAC4", Offset = "0xE6CAC4", VA = "0xE6CAC4", Slot = "7")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0xE6CAD0", Offset = "0xE6CAD0", VA = "0xE6CAD0")]
	public void OpenWindow(Type type, [Optional] object args)
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0xE6CB40", Offset = "0xE6CB40", VA = "0xE6CB40")]
	protected UIWindow()
	{
	}
}
[Token(Token = "0x200004B")]
public static class ClassUtil
{
	[Token(Token = "0x60001BF")]
	public static TBaseClass CreateDerivedInstance<TBaseClass>(string derivedClassName)
	{
		return (TBaseClass)null;
	}

	[Token(Token = "0x60001C0")]
	public static TBaseClass CreateDerivedInstance<TBaseClass>(Type derivedClassType)
	{
		return (TBaseClass)null;
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0xF03F94", Offset = "0xF03F94", VA = "0xF03F94")]
	public static object CreateInstance(string typeName)
	{
		return null;
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0xF04058", Offset = "0xF04058", VA = "0xF04058")]
	public static object CreateInstance(Type t)
	{
		return null;
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0xF04060", Offset = "0xF04060", VA = "0xF04060")]
	public static Vector3 ArrayToVector3(float[] arr)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0xF04094", Offset = "0xF04094", VA = "0xF04094")]
	public static Vector3 ArrayToVector3(double[] arr)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0xF040D4", Offset = "0xF040D4", VA = "0xF040D4")]
	public static Vector3 ArrayToVector3(int[] arr)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0xF04114", Offset = "0xF04114", VA = "0xF04114")]
	public static string SubstringSingle(string source, string startStr, string endStr)
	{
		return null;
	}
}
[Token(Token = "0x200004C")]
public class DontDestroyOnLoad : MonoBehaviour
{
	[Token(Token = "0x60001C7")]
	[Address(RVA = "0xF1454C", Offset = "0xF1454C", VA = "0xF1454C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0xF145B0", Offset = "0xF145B0", VA = "0xF145B0")]
	public DontDestroyOnLoad()
	{
	}
}
[Token(Token = "0x200004D")]
public class LightingSetting : MonoBehaviour
{
	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material skyBox;

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0xF1F7FC", Offset = "0xF1F7FC", VA = "0xF1F7FC")]
	private void Start()
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0xF1F808", Offset = "0xF1F808", VA = "0xF1F808")]
	public LightingSetting()
	{
	}
}
[Token(Token = "0x200004E")]
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

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0xF1891C", Offset = "0xF1891C", VA = "0xF1891C")]
	public Gird()
	{
	}
}
[Token(Token = "0x200004F")]
public class GameObjectScrollView : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000050")]
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

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x10655C0", Offset = "0x10655C0", VA = "0x10655C0")]
		public Property()
		{
		}
	}

	[Token(Token = "0x2000051")]
	private class GirdSize
	{
		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int curentCount;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int totalCount;

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x10655B8", Offset = "0x10655B8", VA = "0x10655B8")]
		public GirdSize()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C014", Offset = "0x73C014")]
	private sealed class <>c
	{
		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<Property> <>9__8_0;

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1065368", Offset = "0x1065368", VA = "0x1065368")]
		public <>c()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1065370", Offset = "0x1065370", VA = "0x1065370")]
		internal int <InitGrid>b__8_0(Property m1, Property m2)
		{
			return default(int);
		}
	}

	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C024", Offset = "0x73C024")]
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

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x106539C", Offset = "0x106539C", VA = "0x106539C")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x10653A4", Offset = "0x10653A4", VA = "0x10653A4")]
		internal void <CoverTransform>b__0()
		{
		}
	}

	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C034", Offset = "0x73C034")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CubeRoot cubeRoot;

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1065448", Offset = "0x1065448", VA = "0x1065448")]
		public <>c__DisplayClass14_0()
		{
		}
	}

	[Token(Token = "0x2000055")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C044", Offset = "0x73C044")]
	private sealed class <>c__DisplayClass14_1
	{
		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollViewPlane scrollViewPlane;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public <>c__DisplayClass14_0 CS$<>8__locals1;

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x1065450", Offset = "0x1065450", VA = "0x1065450")]
		public <>c__DisplayClass14_1()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1065458", Offset = "0x1065458", VA = "0x1065458")]
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

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0xF17078", Offset = "0xF17078", VA = "0xF17078")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0xF1707C", Offset = "0xF1707C", VA = "0xF1707C")]
	private void InitGrid()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0xF17440", Offset = "0xF17440", VA = "0xF17440")]
	private ScrollViewPlane GetEmptyPlane(bool IsResetPos, int planeIndex = -1)
	{
		return null;
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0xF1759C", Offset = "0xF1759C", VA = "0xF1759C")]
	public int AddTransform(CubeRoot cubeRoot, bool isOld, int planeIndex = -1)
	{
		return default(int);
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0xF176B4", Offset = "0xF176B4", VA = "0xF176B4")]
	public void AddTransformShow(CubeRoot cubeRoot, bool isOld)
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0xF177A0", Offset = "0xF177A0", VA = "0xF177A0")]
	public bool CoverTransform(CubeRoot cubeRoot, Transform handTransform, Vector3 forword, Action<int> action)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0xF17FA8", Offset = "0xF17FA8", VA = "0xF17FA8")]
	private Gird GetEmptyGird(out ScrollViewPlane outscrollViewPlane)
	{
		return null;
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0xF181B4", Offset = "0xF181B4", VA = "0xF181B4")]
	public void OrganizeItems(List<CubeRoot> cubeRoots, int nStageID)
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0xF18080", Offset = "0xF18080", VA = "0xF18080")]
	private Vector3 GetCubeRotate(Gird grid)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0xF18570", Offset = "0xF18570", VA = "0xF18570")]
	public void RemoveTransform(CubeRoot cubeRoot)
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0xF18618", Offset = "0xF18618", VA = "0xF18618")]
	public void Clear()
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0xF1861C", Offset = "0xF1861C", VA = "0xF1861C")]
	public GameObjectScrollView()
	{
	}
}
[Token(Token = "0x2000056")]
public class ScrollViewData
{
	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ScrollViewData m_instance;

	[Token(Token = "0x17000031")]
	public static ScrollViewData instance
	{
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xE5956C", Offset = "0xE5956C", VA = "0xE5956C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0xE5963C", Offset = "0xE5963C", VA = "0xE5963C")]
	public Vector3 GetStageItemRotation(string itemId, Vector3 defaultRotation)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0xE59634", Offset = "0xE59634", VA = "0xE59634")]
	public ScrollViewData()
	{
	}
}
[Token(Token = "0x2000057")]
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
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xE597A4", Offset = "0xE597A4", VA = "0xE597A4")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0xE598F4", Offset = "0xE598F4", VA = "0xE598F4")]
	public void InitScrollViewPlane(Vector3 spacing, Vector2 girdSize, bool resetPos)
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0xE59AB0", Offset = "0xE59AB0", VA = "0xE59AB0")]
	public bool AddViewItem(CubeRoot cubeRoot, bool isOld)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0xE59D48", Offset = "0xE59D48", VA = "0xE59D48")]
	private Gird FindSameGird(CubeRoot cubeRoot, bool isOld)
	{
		return null;
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0xE5A1A8", Offset = "0xE5A1A8", VA = "0xE5A1A8")]
	public Gird GetEmptyGird(Vector3 point, CubeRoot cubeRoot)
	{
		return null;
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0xE5A4D4", Offset = "0xE5A4D4", VA = "0xE5A4D4")]
	public Gird GetEmptyGirdForIndex()
	{
		return null;
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0xE5A638", Offset = "0xE5A638", VA = "0xE5A638")]
	public bool IsWhereEmptyGird()
	{
		return default(bool);
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0xE5A770", Offset = "0xE5A770", VA = "0xE5A770")]
	public Gird GetEmptyGirdForOrganize()
	{
		return null;
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0xE5A8D0", Offset = "0xE5A8D0", VA = "0xE5A8D0")]
	public void RemoveGirdRoot(CubeRoot cubeRoot)
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0xE5AC6C", Offset = "0xE5AC6C", VA = "0xE5AC6C")]
	public ScrollViewPlane()
	{
	}
}
[Token(Token = "0x2000058")]
public class ItemView : MonoBehaviour
{
	[Token(Token = "0x60001F0")]
	[Address(RVA = "0xF1C8C4", Offset = "0xF1C8C4", VA = "0xF1C8C4")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0xF1C8C8", Offset = "0xF1C8C8", VA = "0xF1C8C8")]
	private void Update()
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0xF1C8CC", Offset = "0xF1C8CC", VA = "0xF1C8CC")]
	public ItemView()
	{
	}
}
[Token(Token = "0x2000059")]
public static class ZipWrapper
{
	[Token(Token = "0x200005A")]
	public abstract class ZipCallback
	{
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x106F1AC", Offset = "0x106F1AC", VA = "0x106F1AC", Slot = "4")]
		public virtual bool OnPreZip(ZipEntry _entry)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x106F1B4", Offset = "0x106F1B4", VA = "0x106F1B4", Slot = "5")]
		public virtual void OnPostZip(ZipEntry _entry)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x106F1B8", Offset = "0x106F1B8", VA = "0x106F1B8", Slot = "6")]
		public virtual void OnFinished(bool _result)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x106F1BC", Offset = "0x106F1BC", VA = "0x106F1BC")]
		protected ZipCallback()
		{
		}
	}

	[Token(Token = "0x200005B")]
	public abstract class UnzipCallback
	{
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x106F1A0", Offset = "0x106F1A0", VA = "0x106F1A0", Slot = "4")]
		public virtual bool OnPreUnzip(ZipEntry _entry)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x106F1A8", Offset = "0x106F1A8", VA = "0x106F1A8", Slot = "5")]
		public virtual void OnPostUnzip(ZipEntry _entry)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x1061808", Offset = "0x1061808", VA = "0x1061808", Slot = "6")]
		public virtual void OnFinished(bool _result)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x1061814", Offset = "0x1061814", VA = "0x1061814")]
		protected UnzipCallback()
		{
		}
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0xE6F9B4", Offset = "0xE6F9B4", VA = "0xE6F9B4")]
	public static bool Zip(string[] _fileOrDirectoryArray, string _outputPathName, [Optional] string _password, [Optional] ZipCallback _zipCallback)
	{
		return default(bool);
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0xE705E4", Offset = "0xE705E4", VA = "0xE705E4")]
	public static bool UnzipFile(string _filePathName, string _outputPath, [Optional] string _password, [Optional] UnzipCallback _unzipCallback)
	{
		return default(bool);
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0xE70E20", Offset = "0xE70E20", VA = "0xE70E20")]
	public static bool UnzipFile(byte[] _fileBytes, string _outputPath, [Optional] string _password, [Optional] UnzipCallback _unzipCallback)
	{
		return default(bool);
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0xE707A0", Offset = "0xE707A0", VA = "0xE707A0")]
	public static bool UnzipFile(Stream _inputStream, string _outputPath, [Optional] string _password, [Optional] UnzipCallback _unzipCallback, string filePaht = "")
	{
		return default(bool);
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0xE70170", Offset = "0xE70170", VA = "0xE70170")]
	private static bool ZipFile(string _filePathName, string _parentRelPath, ZipOutputStream _zipOutputStream, [Optional] ZipCallback _zipCallback)
	{
		return default(bool);
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0xE6FC5C", Offset = "0xE6FC5C", VA = "0xE6FC5C")]
	private static bool ZipDirectory(string _path, string _parentRelPath, ZipOutputStream _zipOutputStream, [Optional] ZipCallback _zipCallback)
	{
		return default(bool);
	}
}
[Token(Token = "0x200005C")]
public abstract class BaseHand : MonoBehaviour
{
	[Token(Token = "0x6000201")]
	public abstract void OnTriggerPress();

	[Token(Token = "0x6000202")]
	public abstract void OnTriggerDevice(float triggerValue);

	[Token(Token = "0x6000203")]
	public abstract void OnPrimary2DAxis(Vector2 value);

	[Token(Token = "0x6000204")]
	public abstract void onPrimary2DPress();

	[Token(Token = "0x6000205")]
	public abstract void onResetHand();

	[Token(Token = "0x6000206")]
	[Address(RVA = "0xEFF834", Offset = "0xEFF834", VA = "0xEFF834")]
	protected BaseHand()
	{
	}
}
[Token(Token = "0x200005D")]
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

	[Token(Token = "0x6000207")]
	[Address(RVA = "0xF27CCC", Offset = "0xF27CCC", VA = "0xF27CCC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0xF27E1C", Offset = "0xF27E1C", VA = "0xF27E1C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0xF27F40", Offset = "0xF27F40", VA = "0xF27F40")]
	public void OnTriggerEvent(float valus, XRRayInteractor xRRay, Transform handTrans)
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0xF28028", Offset = "0xF28028", VA = "0xF28028")]
	public RayLineFeedback()
	{
	}
}
[Token(Token = "0x200005E")]
public class ScreenFade : MonoBehaviour
{
	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C054", Offset = "0x73C054")]
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
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x10687B4", Offset = "0x10687B4", VA = "0x10687B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x10687FC", Offset = "0x10687FC", VA = "0x10687FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x1068650", Offset = "0x1068650", VA = "0x1068650")]
		[DebuggerHidden]
		public <Fade>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x106867C", Offset = "0x106867C", VA = "0x106867C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x1068680", Offset = "0x1068680", VA = "0x1068680", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x10687BC", Offset = "0x10687BC", VA = "0x10687BC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C938", Offset = "0x73C938")]
	public float fadeTime;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73C970", Offset = "0x73C970")]
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

	[Token(Token = "0x600020B")]
	[Address(RVA = "0xE58EF4", Offset = "0xE58EF4", VA = "0xE58EF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0xE592E0", Offset = "0xE592E0", VA = "0xE592E0")]
	public void FadeIn(Action fadeCallBack)
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0xE593AC", Offset = "0xE593AC", VA = "0xE593AC")]
	public void FadeOut(Action fadeCallBack)
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0xE58F1C", Offset = "0xE58F1C", VA = "0xE58F1C")]
	private void CreateFadeMesh()
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0xE592D8", Offset = "0xE592D8", VA = "0xE592D8")]
	public void SetCurrentAlpha(float alpha)
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0xE59320", Offset = "0xE59320", VA = "0xE59320")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73D0B0", Offset = "0x73D0B0")]
	private IEnumerator Fade(float startAlpha, float endAlpha)
	{
		return null;
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0xE593EC", Offset = "0xE593EC", VA = "0xE593EC")]
	private void SetMaterialAlpha()
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0xE59504", Offset = "0xE59504", VA = "0xE59504")]
	public ScreenFade()
	{
	}
}
[Token(Token = "0x2000060")]
public class XRHandControllerEvent : MonoBehaviour
{
	[Token(Token = "0x2000061")]
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

	[Token(Token = "0x6000219")]
	[Address(RVA = "0xE6E28C", Offset = "0xE6E28C", VA = "0xE6E28C")]
	private void Start()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0xE6E8A4", Offset = "0xE6E8A4", VA = "0xE6E8A4")]
	private void RigestDeviceHand()
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0xE6EB28", Offset = "0xE6EB28", VA = "0xE6EB28")]
	private void Act(InputDevice device)
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0xE6ECF0", Offset = "0xE6ECF0", VA = "0xE6ECF0")]
	private void Update()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0xE6F10C", Offset = "0xE6F10C", VA = "0xE6F10C")]
	private void OnTrigger(float triggerValue)
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0xE6F340", Offset = "0xE6F340", VA = "0xE6F340")]
	private void OnTriggerClick()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0xE6F2B0", Offset = "0xE6F2B0", VA = "0xE6F2B0")]
	private void OnTriggerOff()
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0xE6F3D0", Offset = "0xE6F3D0", VA = "0xE6F3D0")]
	private void OnPrimary2D(Vector2 primaryVec)
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0xE6F524", Offset = "0xE6F524", VA = "0xE6F524")]
	public void HandHaptic(float value = 0.3f, float duration = 0.3f)
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0xE6EC70", Offset = "0xE6EC70", VA = "0xE6EC70")]
	public string TypeById(HandType handType)
	{
		return null;
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0xE6F5DC", Offset = "0xE6F5DC", VA = "0xE6F5DC")]
	private void OnApplicationFocus(bool isFocus)
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0xE6F6BC", Offset = "0xE6F6BC", VA = "0xE6F6BC")]
	public XRHandControllerEvent()
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0xE6F6D0", Offset = "0xE6F6D0", VA = "0xE6F6D0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D160", Offset = "0x73D160")]
	private void <Start>b__13_0(HoverEnterEventArgs HoverEnterEvent)
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0xE6F774", Offset = "0xE6F774", VA = "0xE6F774")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D170", Offset = "0x73D170")]
	private void <Start>b__13_1(HoverExitEventArgs HoverExitEvent)
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0xE6F818", Offset = "0xE6F818", VA = "0xE6F818")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D180", Offset = "0x73D180")]
	private void <Start>b__13_2(SelectEnterEventArgs HoverEnterEvent)
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0xE6F8BC", Offset = "0xE6F8BC", VA = "0xE6F8BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D190", Offset = "0x73D190")]
	private void <Start>b__13_3(SelectExitEventArgs HoverExitEvent)
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0xE6F960", Offset = "0xE6F960", VA = "0xE6F960")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D1A0", Offset = "0x73D1A0")]
	private void <Start>b__13_4()
	{
	}
}
[Token(Token = "0x2000062")]
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
		[Token(Token = "0x600022B")]
		[Address(RVA = "0xEFC3E4", Offset = "0xEFC3E4", VA = "0xEFC3E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000036")]
	public List<string> AttachIds
	{
		[Token(Token = "0x600022C")]
		[Address(RVA = "0xEFC3EC", Offset = "0xEFC3EC", VA = "0xEFC3EC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000037")]
	public List<string> AudioUrl
	{
		[Token(Token = "0x600022D")]
		[Address(RVA = "0xEFC3F4", Offset = "0xEFC3F4", VA = "0xEFC3F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0xEFC380", Offset = "0xEFC380", VA = "0xEFC380", Slot = "4")]
	public override string GetConfigKey()
	{
		return null;
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0xEFC3FC", Offset = "0xEFC3FC", VA = "0xEFC3FC", Slot = "5")]
	public override void Trans(string json, string key)
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0xEFC4A4", Offset = "0xEFC4A4", VA = "0xEFC4A4")]
	public static void Parse(_Attachments_ attachments)
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0xEFC6CC", Offset = "0xEFC6CC", VA = "0xEFC6CC")]
	public static void AddParse(List<_attachment_vo_> attachments)
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0xEFC8B0", Offset = "0xEFC8B0", VA = "0xEFC8B0")]
	public static Hashtable GetAllData()
	{
		return null;
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0xEFC914", Offset = "0xEFC914", VA = "0xEFC914")]
	public static AttachmentCfg GetData(string id)
	{
		return null;
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0xEFC9CC", Offset = "0xEFC9CC", VA = "0xEFC9CC")]
	public static string[] Path()
	{
		return null;
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0xEFC6C4", Offset = "0xEFC6C4", VA = "0xEFC6C4")]
	public AttachmentCfg()
	{
	}
}
[Serializable]
[Token(Token = "0x2000063")]
public class _Attachments_ : BaseConfigs
{
	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public new List<_attachment_vo_> data;

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x1061520", Offset = "0x1061520", VA = "0x1061520")]
	public _Attachments_()
	{
	}
}
[Serializable]
[Token(Token = "0x2000064")]
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

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x1061560", Offset = "0x1061560", VA = "0x1061560")]
	public _attachment_vo_()
	{
	}
}
[Token(Token = "0x2000065")]
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
		[Token(Token = "0x6000239")]
		[Address(RVA = "0xF05310", Offset = "0xF05310", VA = "0xF05310")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000039")]
	public string Value
	{
		[Token(Token = "0x600023A")]
		[Address(RVA = "0xF05318", Offset = "0xF05318", VA = "0xF05318")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003A")]
	public string Desc
	{
		[Token(Token = "0x600023B")]
		[Address(RVA = "0xF05320", Offset = "0xF05320", VA = "0xF05320")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0xF052AC", Offset = "0xF052AC", VA = "0xF052AC", Slot = "4")]
	public override string GetConfigKey()
	{
		return null;
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0xF05328", Offset = "0xF05328", VA = "0xF05328", Slot = "5")]
	public override void Trans(string json, string key)
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0xF053D0", Offset = "0xF053D0", VA = "0xF053D0")]
	public static void Parse(_Consts_ consts)
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0xF055F8", Offset = "0xF055F8", VA = "0xF055F8")]
	public static void AddParse(List<_const_vo_> consts)
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0xF057DC", Offset = "0xF057DC", VA = "0xF057DC")]
	public static Hashtable GetAllData()
	{
		return null;
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0xF05840", Offset = "0xF05840", VA = "0xF05840")]
	public static ConstCfg GetData(string key)
	{
		return null;
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0xF058F8", Offset = "0xF058F8", VA = "0xF058F8")]
	public static string[] Path()
	{
		return null;
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0xF055F0", Offset = "0xF055F0", VA = "0xF055F0")]
	public ConstCfg()
	{
	}
}
[Serializable]
[Token(Token = "0x2000066")]
public class _Consts_ : BaseConfigs
{
	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public new List<_const_vo_> data;

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x1061528", Offset = "0x1061528", VA = "0x1061528")]
	public _Consts_()
	{
	}
}
[Serializable]
[Token(Token = "0x2000067")]
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

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x1061568", Offset = "0x1061568", VA = "0x1061568")]
	public _const_vo_()
	{
	}
}
[Token(Token = "0x2000068")]
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
		[Token(Token = "0x6000247")]
		[Address(RVA = "0xF1C938", Offset = "0xF1C938", VA = "0xF1C938")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700003C")]
	public string Cn
	{
		[Token(Token = "0x6000248")]
		[Address(RVA = "0xF1C940", Offset = "0xF1C940", VA = "0xF1C940")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003D")]
	public string CnFontStyle
	{
		[Token(Token = "0x6000249")]
		[Address(RVA = "0xF1C948", Offset = "0xF1C948", VA = "0xF1C948")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003E")]
	public string En
	{
		[Token(Token = "0x600024A")]
		[Address(RVA = "0xF1C950", Offset = "0xF1C950", VA = "0xF1C950")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003F")]
	public string EnFontStyle
	{
		[Token(Token = "0x600024B")]
		[Address(RVA = "0xF1C958", Offset = "0xF1C958", VA = "0xF1C958")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000040")]
	public string CnImagePath
	{
		[Token(Token = "0x600024C")]
		[Address(RVA = "0xF1C960", Offset = "0xF1C960", VA = "0xF1C960")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000041")]
	public string EnImagePath
	{
		[Token(Token = "0x600024D")]
		[Address(RVA = "0xF1C968", Offset = "0xF1C968", VA = "0xF1C968")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000042")]
	public string Des
	{
		[Token(Token = "0x600024E")]
		[Address(RVA = "0xF1C970", Offset = "0xF1C970", VA = "0xF1C970")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0xF1C8D4", Offset = "0xF1C8D4", VA = "0xF1C8D4", Slot = "4")]
	public override string GetConfigKey()
	{
		return null;
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0xF1C978", Offset = "0xF1C978", VA = "0xF1C978", Slot = "5")]
	public override void Trans(string json, string key)
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0xF1CA20", Offset = "0xF1CA20", VA = "0xF1CA20")]
	public static void Parse(_Languages_ languages)
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0xF1CCE0", Offset = "0xF1CCE0", VA = "0xF1CCE0")]
	public static void AddParse(List<_language_vo_> languages)
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0xF1CF5C", Offset = "0xF1CF5C", VA = "0xF1CF5C")]
	public static Hashtable GetAllData()
	{
		return null;
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0xF1CFC0", Offset = "0xF1CFC0", VA = "0xF1CFC0")]
	public static LanguageCfg GetData(int key)
	{
		return null;
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0xF1D0A8", Offset = "0xF1D0A8", VA = "0xF1D0A8")]
	public static string[] Path()
	{
		return null;
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0xF1CCD8", Offset = "0xF1CCD8", VA = "0xF1CCD8")]
	public LanguageCfg()
	{
	}
}
[Serializable]
[Token(Token = "0x2000069")]
public class _Languages_ : BaseConfigs
{
	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public new List<_language_vo_> data;

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x1061530", Offset = "0x1061530", VA = "0x1061530")]
	public _Languages_()
	{
	}
}
[Serializable]
[Token(Token = "0x200006A")]
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

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x1061570", Offset = "0x1061570", VA = "0x1061570")]
	public _language_vo_()
	{
	}
}
[Token(Token = "0x200006B")]
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
		[Token(Token = "0x600025A")]
		[Address(RVA = "0xE5DAC0", Offset = "0xE5DAC0", VA = "0xE5DAC0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000044")]
	public string Name
	{
		[Token(Token = "0x600025B")]
		[Address(RVA = "0xE5DAC8", Offset = "0xE5DAC8", VA = "0xE5DAC8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000045")]
	public string Description
	{
		[Token(Token = "0x600025C")]
		[Address(RVA = "0xE5DAD0", Offset = "0xE5DAD0", VA = "0xE5DAD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000046")]
	public string TitleImage
	{
		[Token(Token = "0x600025D")]
		[Address(RVA = "0xE5DAD8", Offset = "0xE5DAD8", VA = "0xE5DAD8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000047")]
	public List<int> StageList
	{
		[Token(Token = "0x600025E")]
		[Address(RVA = "0xE5DAE0", Offset = "0xE5DAE0", VA = "0xE5DAE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0xE5DA5C", Offset = "0xE5DA5C", VA = "0xE5DA5C", Slot = "4")]
	public override string GetConfigKey()
	{
		return null;
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0xE5DAE8", Offset = "0xE5DAE8", VA = "0xE5DAE8", Slot = "5")]
	public override void Trans(string json, string key)
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0xE5DB90", Offset = "0xE5DB90", VA = "0xE5DB90")]
	public static void Parse(_StageGroups_ stageGroups)
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0xE5DE14", Offset = "0xE5DE14", VA = "0xE5DE14")]
	public static void AddParse(List<_stageGroup_vo_> stageGroups)
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0xE5E054", Offset = "0xE5E054", VA = "0xE5E054")]
	public static Hashtable GetAllData()
	{
		return null;
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0xE5C6C0", Offset = "0xE5C6C0", VA = "0xE5C6C0")]
	public static StageGroupCfg GetData(int id)
	{
		return null;
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0xE5E0B8", Offset = "0xE5E0B8", VA = "0xE5E0B8")]
	public static string[] Path()
	{
		return null;
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0xE5DE0C", Offset = "0xE5DE0C", VA = "0xE5DE0C")]
	public StageGroupCfg()
	{
	}
}
[Serializable]
[Token(Token = "0x200006C")]
public class _StageGroups_ : BaseConfigs
{
	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public new List<_stageGroup_vo_> data;

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x1061538", Offset = "0x1061538", VA = "0x1061538")]
	public _StageGroups_()
	{
	}
}
[Serializable]
[Token(Token = "0x200006D")]
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

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x1061578", Offset = "0x1061578", VA = "0x1061578")]
	public _stageGroup_vo_()
	{
	}
}
[Token(Token = "0x200006E")]
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
		[Token(Token = "0x600026A")]
		[Address(RVA = "0xE5EB8C", Offset = "0xE5EB8C", VA = "0xE5EB8C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000049")]
	public Vector3 ItemPos
	{
		[Token(Token = "0x600026B")]
		[Address(RVA = "0xE5EB94", Offset = "0xE5EB94", VA = "0xE5EB94")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700004A")]
	public Vector4 ItemRotation
	{
		[Token(Token = "0x600026C")]
		[Address(RVA = "0xE5EBA0", Offset = "0xE5EBA0", VA = "0xE5EBA0")]
		get
		{
			return default(Vector4);
		}
	}

	[Token(Token = "0x1700004B")]
	public string AttDataId
	{
		[Token(Token = "0x600026D")]
		[Address(RVA = "0xE5EBAC", Offset = "0xE5EBAC", VA = "0xE5EBAC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0xE5EB28", Offset = "0xE5EB28", VA = "0xE5EB28", Slot = "4")]
	public override string GetConfigKey()
	{
		return null;
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0xE5EBB4", Offset = "0xE5EBB4", VA = "0xE5EBB4", Slot = "5")]
	public override void Trans(string json, string key)
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0xE5EC5C", Offset = "0xE5EC5C", VA = "0xE5EC5C")]
	public static void Parse(_StageItems_ stageItems)
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0xE5EE88", Offset = "0xE5EE88", VA = "0xE5EE88")]
	public static void AddParse(List<_stageItem_vo_> stageItems)
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0xE5F070", Offset = "0xE5F070", VA = "0xE5F070")]
	public static Hashtable GetAllData()
	{
		return null;
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0xE596E8", Offset = "0xE596E8", VA = "0xE596E8")]
	public static StageItemCfg GetData(string id)
	{
		return null;
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0xE5F0D4", Offset = "0xE5F0D4", VA = "0xE5F0D4")]
	public static string[] Path()
	{
		return null;
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0xE5EE80", Offset = "0xE5EE80", VA = "0xE5EE80")]
	public StageItemCfg()
	{
	}
}
[Serializable]
[Token(Token = "0x200006F")]
public class _StageItems_ : BaseConfigs
{
	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public new List<_stageItem_vo_> data;

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x1061540", Offset = "0x1061540", VA = "0x1061540")]
	public _StageItems_()
	{
	}
}
[Serializable]
[Token(Token = "0x2000070")]
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

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x1061580", Offset = "0x1061580", VA = "0x1061580")]
	public _stageItem_vo_()
	{
	}
}
[Token(Token = "0x2000071")]
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
		[Token(Token = "0x6000279")]
		[Address(RVA = "0xE5F3B0", Offset = "0xE5F3B0", VA = "0xE5F3B0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700004D")]
	public string Name
	{
		[Token(Token = "0x600027A")]
		[Address(RVA = "0xE5F3B8", Offset = "0xE5F3B8", VA = "0xE5F3B8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700004E")]
	public int ChipCount
	{
		[Token(Token = "0x600027B")]
		[Address(RVA = "0xE5F3C0", Offset = "0xE5F3C0", VA = "0xE5F3C0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700004F")]
	public int StarCount
	{
		[Token(Token = "0x600027C")]
		[Address(RVA = "0xE5F3C8", Offset = "0xE5F3C8", VA = "0xE5F3C8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000050")]
	public string PathUrl
	{
		[Token(Token = "0x600027D")]
		[Address(RVA = "0xE5F3D0", Offset = "0xE5F3D0", VA = "0xE5F3D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000051")]
	public string BundleName
	{
		[Token(Token = "0x600027E")]
		[Address(RVA = "0xE5F3D8", Offset = "0xE5F3D8", VA = "0xE5F3D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000052")]
	public string ItemForm
	{
		[Token(Token = "0x600027F")]
		[Address(RVA = "0xE5F3E0", Offset = "0xE5F3E0", VA = "0xE5F3E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000053")]
	public string AttachForm
	{
		[Token(Token = "0x6000280")]
		[Address(RVA = "0xE5F3E8", Offset = "0xE5F3E8", VA = "0xE5F3E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000054")]
	public string BGM
	{
		[Token(Token = "0x6000281")]
		[Address(RVA = "0xE5F3F0", Offset = "0xE5F3F0", VA = "0xE5F3F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000055")]
	public float AttDis
	{
		[Token(Token = "0x6000282")]
		[Address(RVA = "0xE5F3F8", Offset = "0xE5F3F8", VA = "0xE5F3F8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000056")]
	public float AttAngle
	{
		[Token(Token = "0x6000283")]
		[Address(RVA = "0xE5F400", Offset = "0xE5F400", VA = "0xE5F400")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000057")]
	public List<string> ShowItems
	{
		[Token(Token = "0x6000284")]
		[Address(RVA = "0xE5F408", Offset = "0xE5F408", VA = "0xE5F408")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000058")]
	public string Scene
	{
		[Token(Token = "0x6000285")]
		[Address(RVA = "0xE5F410", Offset = "0xE5F410", VA = "0xE5F410")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0xE5F34C", Offset = "0xE5F34C", VA = "0xE5F34C", Slot = "4")]
	public override string GetConfigKey()
	{
		return null;
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0xE5F418", Offset = "0xE5F418", VA = "0xE5F418", Slot = "5")]
	public override void Trans(string json, string key)
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0xE5F4C0", Offset = "0xE5F4C0", VA = "0xE5F4C0")]
	public static void Parse(_Stagess_ stagess)
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0xE5F7B4", Offset = "0xE5F7B4", VA = "0xE5F7B4")]
	public static void AddParse(List<_stages_vo_> stagess)
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0xE5FA64", Offset = "0xE5FA64", VA = "0xE5FA64")]
	public static Hashtable GetAllData()
	{
		return null;
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0xE5C7A8", Offset = "0xE5C7A8", VA = "0xE5C7A8")]
	public static StagesCfg GetData(int id)
	{
		return null;
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0xE5FAC8", Offset = "0xE5FAC8", VA = "0xE5FAC8")]
	public static string[] Path()
	{
		return null;
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0xE5F7AC", Offset = "0xE5F7AC", VA = "0xE5F7AC")]
	public StagesCfg()
	{
	}
}
[Serializable]
[Token(Token = "0x2000072")]
public class _Stagess_ : BaseConfigs
{
	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public new List<_stages_vo_> data;

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x1061548", Offset = "0x1061548", VA = "0x1061548")]
	public _Stagess_()
	{
	}
}
[Serializable]
[Token(Token = "0x2000073")]
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

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x1061588", Offset = "0x1061588", VA = "0x1061588")]
	public _stages_vo_()
	{
	}
}
[Token(Token = "0x2000074")]
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
		[Token(Token = "0x6000291")]
		[Address(RVA = "0xE5FC64", Offset = "0xE5FC64", VA = "0xE5FC64")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700005A")]
	public string Name
	{
		[Token(Token = "0x6000292")]
		[Address(RVA = "0xE5FC6C", Offset = "0xE5FC6C", VA = "0xE5FC6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700005B")]
	public string StarImage
	{
		[Token(Token = "0x6000293")]
		[Address(RVA = "0xE5FC74", Offset = "0xE5FC74", VA = "0xE5FC74")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700005C")]
	public string StarImage2
	{
		[Token(Token = "0x6000294")]
		[Address(RVA = "0xE5FC7C", Offset = "0xE5FC7C", VA = "0xE5FC7C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0xE5FC00", Offset = "0xE5FC00", VA = "0xE5FC00", Slot = "4")]
	public override string GetConfigKey()
	{
		return null;
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0xE5FC84", Offset = "0xE5FC84", VA = "0xE5FC84", Slot = "5")]
	public override void Trans(string json, string key)
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0xE5FD2C", Offset = "0xE5FD2C", VA = "0xE5FD2C")]
	public static void Parse(_StarMedals_ starMedals)
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0xE5FF9C", Offset = "0xE5FF9C", VA = "0xE5FF9C")]
	public static void AddParse(List<_starMedal_vo_> starMedals)
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0xE601C8", Offset = "0xE601C8", VA = "0xE601C8")]
	public static Hashtable GetAllData()
	{
		return null;
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0xE5CAC8", Offset = "0xE5CAC8", VA = "0xE5CAC8")]
	public static StarMedalCfg GetData(int id)
	{
		return null;
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0xE6022C", Offset = "0xE6022C", VA = "0xE6022C")]
	public static string[] Path()
	{
		return null;
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0xE5FF94", Offset = "0xE5FF94", VA = "0xE5FF94")]
	public StarMedalCfg()
	{
	}
}
[Serializable]
[Token(Token = "0x2000075")]
public class _StarMedals_ : BaseConfigs
{
	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public new List<_starMedal_vo_> data;

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x1061550", Offset = "0x1061550", VA = "0x1061550")]
	public _StarMedals_()
	{
	}
}
[Serializable]
[Token(Token = "0x2000076")]
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

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x1061590", Offset = "0x1061590", VA = "0x1061590")]
	public _starMedal_vo_()
	{
	}
}
[Token(Token = "0x2000077")]
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
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xE67D88", Offset = "0xE67D88", VA = "0xE67D88")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700005E")]
	public string Name
	{
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xE67D90", Offset = "0xE67D90", VA = "0xE67D90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700005F")]
	public string Icon
	{
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xE67D98", Offset = "0xE67D98", VA = "0xE67D98")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000060")]
	public string MainPicture
	{
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xE67DA0", Offset = "0xE67DA0", VA = "0xE67DA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000061")]
	public string ScenePath
	{
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xE67DA8", Offset = "0xE67DA8", VA = "0xE67DA8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000062")]
	public List<int> StageGroupList
	{
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xE67DB0", Offset = "0xE67DB0", VA = "0xE67DB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000063")]
	public string EffectAssemble
	{
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xE67DB8", Offset = "0xE67DB8", VA = "0xE67DB8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000064")]
	public string EffectMiddle
	{
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xE67DC0", Offset = "0xE67DC0", VA = "0xE67DC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000065")]
	public string EffectCorrect
	{
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xE67DC8", Offset = "0xE67DC8", VA = "0xE67DC8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000066")]
	public string EffectGround
	{
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xE67DD0", Offset = "0xE67DD0", VA = "0xE67DD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000067")]
	public string DragAudio
	{
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xE67DD8", Offset = "0xE67DD8", VA = "0xE67DD8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000068")]
	public string Bgm
	{
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xE67DE0", Offset = "0xE67DE0", VA = "0xE67DE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000069")]
	public string SceneName
	{
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xE67DE8", Offset = "0xE67DE8", VA = "0xE67DE8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0xE67D24", Offset = "0xE67D24", VA = "0xE67D24", Slot = "4")]
	public override string GetConfigKey()
	{
		return null;
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0xE67DF0", Offset = "0xE67DF0", VA = "0xE67DF0", Slot = "5")]
	public override void Trans(string json, string key)
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0xE67E98", Offset = "0xE67E98", VA = "0xE67E98")]
	public static void Parse(_Themes_ themes)
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0xE681BC", Offset = "0xE681BC", VA = "0xE681BC")]
	public static void AddParse(List<_theme_vo_> themes)
	{
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0xE6849C", Offset = "0xE6849C", VA = "0xE6849C")]
	public static Hashtable GetAllData()
	{
		return null;
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0xE68500", Offset = "0xE68500", VA = "0xE68500")]
	public static ThemeCfg GetData(int id)
	{
		return null;
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0xE685E8", Offset = "0xE685E8", VA = "0xE685E8")]
	public static string[] Path()
	{
		return null;
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0xE681B4", Offset = "0xE681B4", VA = "0xE681B4")]
	public ThemeCfg()
	{
	}
}
[Serializable]
[Token(Token = "0x2000078")]
public class _Themes_ : BaseConfigs
{
	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public new List<_theme_vo_> data;

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x1061558", Offset = "0x1061558", VA = "0x1061558")]
	public _Themes_()
	{
	}
}
[Serializable]
[Token(Token = "0x2000079")]
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

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x1061598", Offset = "0x1061598", VA = "0x1061598")]
	public _theme_vo_()
	{
	}
}
[Token(Token = "0x200007A")]
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

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0xF15014", Offset = "0xF15014", VA = "0xF15014")]
	public EventKey()
	{
	}
}
[Token(Token = "0x200007B")]
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

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0xEFAD30", Offset = "0xEFAD30", VA = "0xEFAD30")]
	public void StartAround(float time, Vector3 centerPos, Vector3 axis, float angle)
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0xEFAD84", Offset = "0xEFAD84", VA = "0xEFAD84")]
	private void Update()
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0xEFAE58", Offset = "0xEFAE58", VA = "0xEFAE58")]
	public AroundCom()
	{
	}
}
[Token(Token = "0x200007C")]
public class Cube : MonoBehaviour
{
	[Token(Token = "0x200007D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C064", Offset = "0x73C064")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string index;

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1062A08", Offset = "0x1062A08", VA = "0x1062A08")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x1062A10", Offset = "0x1062A10", VA = "0x1062A10")]
		internal bool <InsertCollider>b__0(string value)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200007E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C074", Offset = "0x73C074")]
	private sealed class <>c__DisplayClass15_0
	{
		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string index;

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x1062A50", Offset = "0x1062A50", VA = "0x1062A50")]
		public <>c__DisplayClass15_0()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x1062A58", Offset = "0x1062A58", VA = "0x1062A58")]
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
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xF06634", Offset = "0xF06634", VA = "0xF06634")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700006B")]
	public string ID
	{
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xF0663C", Offset = "0xF0663C", VA = "0xF0663C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700006C")]
	public CubeRoot Root
	{
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xF06644", Offset = "0xF06644", VA = "0xF06644")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0xF0664C", Offset = "0xF0664C", VA = "0xF0664C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0xF06788", Offset = "0xF06788", VA = "0xF06788")]
	public void InsertCollider(CubeColliderData data, Cube otherCube)
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0xF069D4", Offset = "0xF069D4", VA = "0xF069D4")]
	public void RemoveCollider(CubeColliderData data, Cube otherCube)
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0xF06BD8", Offset = "0xF06BD8", VA = "0xF06BD8")]
	public void InitRoot(CubeRoot root)
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0xF06BE0", Offset = "0xF06BE0", VA = "0xF06BE0")]
	public void InitData(string id, List<AttachData> attDatas)
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0xF06C14", Offset = "0xF06C14", VA = "0xF06C14")]
	public void InitShowID(string id)
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0xF06C1C", Offset = "0xF06C1C", VA = "0xF06C1C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0xF06CE4", Offset = "0xF06CE4", VA = "0xF06CE4")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0xF06FBC", Offset = "0xF06FBC", VA = "0xF06FBC")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0xF070E8", Offset = "0xF070E8", VA = "0xF070E8")]
	public Cube()
	{
	}
}
[Token(Token = "0x200007F")]
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

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0xF073A0", Offset = "0xF073A0", VA = "0xF073A0")]
	private void Start()
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0xF07604", Offset = "0xF07604", VA = "0xF07604")]
	private void Update()
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0xF07608", Offset = "0xF07608", VA = "0xF07608")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0xF0798C", Offset = "0xF0798C", VA = "0xF0798C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0xF07C64", Offset = "0xF07C64", VA = "0xF07C64")]
	public CubeColliderData()
	{
	}
}
[Token(Token = "0x2000080")]
public class CubeRoot : MonoBehaviour
{
	[Token(Token = "0x2000081")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C084", Offset = "0x73C084")]
	private sealed class <>c__DisplayClass23_0
	{
		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Cube cube;

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x10631E4", Offset = "0x10631E4", VA = "0x10631E4")]
		public <>c__DisplayClass23_0()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x10631EC", Offset = "0x10631EC", VA = "0x10631EC")]
		internal bool <InsertDropData>b__0(Cube item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C094", Offset = "0x73C094")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Cube cube;

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1063264", Offset = "0x1063264", VA = "0x1063264")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x106326C", Offset = "0x106326C", VA = "0x106326C")]
		internal bool <RemoveDropData>b__0(Cube item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000083")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C0A4", Offset = "0x73C0A4")]
	private sealed class <>c__DisplayClass29_0
	{
		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Cube cubeBase;

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x10632E4", Offset = "0x10632E4", VA = "0x10632E4")]
		public <>c__DisplayClass29_0()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x10632EC", Offset = "0x10632EC", VA = "0x10632EC")]
		internal bool <AssembleCubes>b__0(CubeData item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C0B4", Offset = "0x73C0B4")]
	private sealed class <>c__DisplayClass29_1
	{
		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Cube cube;

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x1063318", Offset = "0x1063318", VA = "0x1063318")]
		public <>c__DisplayClass29_1()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x1063320", Offset = "0x1063320", VA = "0x1063320")]
		internal bool <AssembleCubes>b__2(CubeData item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C0C4", Offset = "0x73C0C4")]
	private sealed class <>c__DisplayClass36_0
	{
		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Hand hand;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CubeRoot <>4__this;

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x106334C", Offset = "0x106334C", VA = "0x106334C")]
		public <>c__DisplayClass36_0()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1063354", Offset = "0x1063354", VA = "0x1063354")]
		internal void <FollowHand>b__0()
		{
		}
	}

	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C0D4", Offset = "0x73C0D4")]
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
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x1063194", Offset = "0x1063194", VA = "0x1063194", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x10631DC", Offset = "0x10631DC", VA = "0x10631DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x10630F0", Offset = "0x10630F0", VA = "0x10630F0")]
		[DebuggerHidden]
		public <<AssembleCubes>g__XRGrabTrue|29_1>d(int <>1__state)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x106311C", Offset = "0x106311C", VA = "0x106311C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x1063120", Offset = "0x1063120", VA = "0x1063120", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x106319C", Offset = "0x106319C", VA = "0x106319C", Slot = "8")]
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
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xF1294C", Offset = "0xF1294C", VA = "0xF1294C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xF12954", Offset = "0xF12954", VA = "0xF12954")]
		set
		{
		}
	}

	[Token(Token = "0x1700006E")]
	public Hand HoldHand
	{
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xF12A7C", Offset = "0xF12A7C", VA = "0xF12A7C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xF1295C", Offset = "0xF1295C", VA = "0xF1295C")]
		set
		{
		}
	}

	[Token(Token = "0x1700006F")]
	public DG.Tweening.Tween TweenMove
	{
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xF135C8", Offset = "0xF135C8", VA = "0xF135C8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xF135D0", Offset = "0xF135D0", VA = "0xF135D0")]
		set
		{
		}
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0xF12A84", Offset = "0xF12A84", VA = "0xF12A84")]
	private void Start()
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0xF12A88", Offset = "0xF12A88", VA = "0xF12A88")]
	public void InsertDropData(Cube cube)
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0xF12C14", Offset = "0xF12C14", VA = "0xF12C14")]
	public void RemoveDropData(Cube cube)
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0xF12DA0", Offset = "0xF12DA0", VA = "0xF12DA0")]
	public void RefreshData()
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0xF12EB8", Offset = "0xF12EB8", VA = "0xF12EB8")]
	public void InitShow(Vector3 defaultPos)
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0xF12ECC", Offset = "0xF12ECC", VA = "0xF12ECC")]
	public void InitCube(Cube cube)
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0xF12F94", Offset = "0xF12F94", VA = "0xF12F94")]
	public void InsertCube(Cube cube)
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0xF1300C", Offset = "0xF1300C", VA = "0xF1300C")]
	public void AssembleCubes(List<Cube> cubes, List<CubeData> m_arrCubeDatas)
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0xF13518", Offset = "0xF13518", VA = "0xF13518")]
	public void ClearData()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0xF135D8", Offset = "0xF135D8", VA = "0xF135D8")]
	public bool IsPlayingMove()
	{
		return default(bool);
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0xF13608", Offset = "0xF13608", VA = "0xF13608")]
	public void FollowHand(Hand hand)
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0xF13AF8", Offset = "0xF13AF8", VA = "0xF13AF8")]
	public void StopFollow()
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0xF13B4C", Offset = "0xF13B4C", VA = "0xF13B4C")]
	public bool IsFollowHand()
	{
		return default(bool);
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0xF13B54", Offset = "0xF13B54", VA = "0xF13B54")]
	public CubeRoot()
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0xF134A0", Offset = "0xF134A0", VA = "0xF134A0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73D1B0", Offset = "0x73D1B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D1B0", Offset = "0x73D1B0")]
	internal static IEnumerator <AssembleCubes>g__XRGrabTrue|29_1(XRGrabInteractable xrgrab)
	{
		return null;
	}
}
[Token(Token = "0x2000087")]
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
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xF13C30", Offset = "0xF13C30", VA = "0xF13C30")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xF13C38", Offset = "0xF13C38", VA = "0xF13C38")]
		set
		{
		}
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0xF13C68", Offset = "0xF13C68", VA = "0xF13C68")]
	public CubeRootShow()
	{
	}
}
[Token(Token = "0x2000088")]
public class TransLateAni : MonoBehaviour
{
	[Token(Token = "0x60002FA")]
	[Address(RVA = "0xE6BA3C", Offset = "0xE6BA3C", VA = "0xE6BA3C")]
	public void PlayStartEnd()
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0xE6BB3C", Offset = "0xE6BB3C", VA = "0xE6BB3C")]
	public void PlayEndEnd()
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0xE6BC3C", Offset = "0xE6BC3C", VA = "0xE6BC3C")]
	public TransLateAni()
	{
	}
}
[Token(Token = "0x2000089")]
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

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0xF07C6C", Offset = "0xF07C6C", VA = "0xF07C6C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0xF07E94", Offset = "0xF07E94", VA = "0xF07E94")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0xF0802C", Offset = "0xF0802C", VA = "0xF0802C")]
	public void OnHverEnterEvent(Transform interactor, Transform hands)
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0xF08224", Offset = "0xF08224", VA = "0xF08224")]
	public void OnHverExitEvent(Transform interactor, Transform hands)
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0xF083B0", Offset = "0xF083B0", VA = "0xF083B0")]
	public CubeFeedback()
	{
	}
}
[Token(Token = "0x200008A")]
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

	[Token(Token = "0x6000302")]
	[Address(RVA = "0xF1AFB8", Offset = "0xF1AFB8", VA = "0xF1AFB8")]
	public HoverCache(string grabTransName)
	{
	}
}
[Token(Token = "0x200008B")]
public class CubeManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C0E4", Offset = "0x73C0E4")]
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

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1062AFC", Offset = "0x1062AFC", VA = "0x1062AFC")]
		public <>c()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1062B04", Offset = "0x1062B04", VA = "0x1062B04")]
		internal bool <PortalLoadSuccess>b__23_0(PrefabInstance item)
		{
			return default(bool);
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x1062B5C", Offset = "0x1062B5C", VA = "0x1062B5C")]
		internal bool <PortalLoadSuccess>b__23_2(PrefabInstance item)
		{
			return default(bool);
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x1062BB4", Offset = "0x1062BB4", VA = "0x1062BB4")]
		internal int <InitData>b__31_0(CubeData m1, CubeData m2)
		{
			return default(int);
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x1062BE0", Offset = "0x1062BE0", VA = "0x1062BE0")]
		internal void <Assemble>b__37_1(GameObject item)
		{
		}
	}

	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C0F4", Offset = "0x73C0F4")]
	private sealed class <>c__DisplayClass28_0
	{
		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x1062C00", Offset = "0x1062C00", VA = "0x1062C00")]
		public <>c__DisplayClass28_0()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x1062C08", Offset = "0x1062C08", VA = "0x1062C08")]
		internal bool <FindPrefab>b__0(PrefabInstance item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C104", Offset = "0x73C104")]
	private sealed class <>c__DisplayClass29_0
	{
		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string cubeRootId;

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1062C2C", Offset = "0x1062C2C", VA = "0x1062C2C")]
		public <>c__DisplayClass29_0()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x1062C34", Offset = "0x1062C34", VA = "0x1062C34")]
		internal bool <InitCube>b__0(CubeModeData item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C114", Offset = "0x73C114")]
	private sealed class <>c__DisplayClass29_1
	{
		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string dataId;

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1062C58", Offset = "0x1062C58", VA = "0x1062C58")]
		public <>c__DisplayClass29_1()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x1062C60", Offset = "0x1062C60", VA = "0x1062C60")]
		internal bool <InitCube>b__1(CubeData item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x1062C84", Offset = "0x1062C84", VA = "0x1062C84")]
		internal bool <InitCube>b__2(CubeData item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C124", Offset = "0x73C124")]
	private sealed class <>c__DisplayClass36_0
	{
		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Cube cube;

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x1062CA8", Offset = "0x1062CA8", VA = "0x1062CA8")]
		public <>c__DisplayClass36_0()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x1062CB0", Offset = "0x1062CB0", VA = "0x1062CB0")]
		internal bool <Drop>b__0(AttachData item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C134", Offset = "0x73C134")]
	private sealed class <>c__DisplayClass37_0
	{
		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string mainCubeID;

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x1062CDC", Offset = "0x1062CDC", VA = "0x1062CDC")]
		public <>c__DisplayClass37_0()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1062CE4", Offset = "0x1062CE4", VA = "0x1062CE4")]
		internal bool <Assemble>b__0(Cube item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C144", Offset = "0x73C144")]
	private sealed class <>c__DisplayClass42_0
	{
		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int stageGroupId;

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1062D08", Offset = "0x1062D08", VA = "0x1062D08")]
		public <>c__DisplayClass42_0()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1062D10", Offset = "0x1062D10", VA = "0x1062D10")]
		internal void <ShowTransDoor>b__0()
		{
		}
	}

	[Token(Token = "0x2000093")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C154", Offset = "0x73C154")]
	private sealed class <>c__DisplayClass45_0
	{
		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string rootId;

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1062DD8", Offset = "0x1062DD8", VA = "0x1062DD8")]
		public <>c__DisplayClass45_0()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1062DE0", Offset = "0x1062DE0", VA = "0x1062DE0")]
		internal bool <OrganizeItems>b__0(CubeRoot item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C164", Offset = "0x73C164")]
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

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1062E04", Offset = "0x1062E04", VA = "0x1062E04")]
		public <>c__DisplayClass46_0()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1062E0C", Offset = "0x1062E0C", VA = "0x1062E0C")]
		internal void <Pull>b__0(int planeIndex)
		{
		}
	}

	[Token(Token = "0x2000095")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C174", Offset = "0x73C174")]
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
			[Token(Token = "0x6000341")]
			[Address(RVA = "0x1062FF0", Offset = "0x1062FF0", VA = "0x1062FF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x1063038", Offset = "0x1063038", VA = "0x1063038", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x1062F4C", Offset = "0x1062F4C", VA = "0x1062F4C")]
		[DebuggerHidden]
		public <CheckPulledCube>d__47(int <>1__state)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1062F78", Offset = "0x1062F78", VA = "0x1062F78", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1062F7C", Offset = "0x1062F7C", VA = "0x1062F7C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1062FF8", Offset = "0x1062FF8", VA = "0x1062FF8", Slot = "8")]
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

	[Token(Token = "0x6000303")]
	[Address(RVA = "0xF08480", Offset = "0xF08480", VA = "0xF08480")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0xF0957C", Offset = "0xF0957C", VA = "0xF0957C")]
	private void PortalLoadSuccess(object parm)
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0xF089C0", Offset = "0xF089C0", VA = "0xF089C0")]
	public void LoadJson()
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0xF0992C", Offset = "0xF0992C", VA = "0xF0992C")]
	private void StartGame()
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0xF0AC3C", Offset = "0xF0AC3C", VA = "0xF0AC3C")]
	private void PreloadCube()
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0xF0B0E0", Offset = "0xF0B0E0", VA = "0xF0B0E0")]
	private void CubeLoadSuccess(object parm)
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0xF0B1E0", Offset = "0xF0B1E0", VA = "0xF0B1E0")]
	public PrefabInstance FindPrefab(string id)
	{
		return null;
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0xF0B2DC", Offset = "0xF0B2DC", VA = "0xF0B2DC", Slot = "4")]
	public virtual void InitCube()
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0xF0C1B0", Offset = "0xF0C1B0", VA = "0xF0C1B0")]
	private void InitShowPanel(string baseUrl)
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0xF09CB0", Offset = "0xF09CB0", VA = "0xF09CB0")]
	public void InitData()
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0xF0CAAC", Offset = "0xF0CAAC", VA = "0xF0CAAC")]
	private void GetClass(string className)
	{
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0xF0CBB0", Offset = "0xF0CBB0", VA = "0xF0CBB0")]
	private CubeRoot CheckDragCube(Hand hand)
	{
		return null;
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0xF0D01C", Offset = "0xF0D01C", VA = "0xF0D01C")]
	public void Drag(Hand hand, CubeRoot root)
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0xF0D7A4", Offset = "0xF0D7A4", VA = "0xF0D7A4")]
	public bool CheckHandInRoot(Hand hand)
	{
		return default(bool);
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0xF0DA34", Offset = "0xF0DA34", VA = "0xF0DA34")]
	public void Drop(Hand hand)
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0xF0DF90", Offset = "0xF0DF90", VA = "0xF0DF90")]
	private void Assemble(Cube cubeMain, CubeRoot cubeRoot, [Optional] Hand hand)
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0xF0F59C", Offset = "0xF0F59C", VA = "0xF0F59C", Slot = "5")]
	public virtual void EffectOfLastTwo(CubeRoot cubeRoot, Cube cube)
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0xF0F778", Offset = "0xF0F778", VA = "0xF0F778", Slot = "6")]
	public virtual void EffectOfAssembleFinish(CubeRoot cubeRoot, Cube cube)
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0xF0F944", Offset = "0xF0F944", VA = "0xF0F944", Slot = "7")]
	public virtual void AssembleFinish()
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0xF0F948", Offset = "0xF0F948", VA = "0xF0F948")]
	private int GetStageGroupId(int stageId)
	{
		return default(int);
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0xF0F1E8", Offset = "0xF0F1E8", VA = "0xF0F1E8")]
	private void ShowTransDoor()
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0xF0D310", Offset = "0xF0D310", VA = "0xF0D310")]
	private void AddDragSignalRoots(CubeRoot root)
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0xF0EE6C", Offset = "0xF0EE6C", VA = "0xF0EE6C")]
	private void RemoveDragSignalRoots(CubeRoot root)
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0xF0FE6C", Offset = "0xF0FE6C", VA = "0xF0FE6C")]
	public void OrganizeItems(object parm)
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0xF102C0", Offset = "0xF102C0", VA = "0xF102C0")]
	public void Pull(Hand hand, float btnDistance)
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0xF10A38", Offset = "0xF10A38", VA = "0xF10A38")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73D270", Offset = "0x73D270")]
	private IEnumerator CheckPulledCube(Hand hand, string RootId)
	{
		return null;
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0xF10AE0", Offset = "0xF10AE0", VA = "0xF10AE0")]
	public void InsertPulledCube(Hand hand, string RootId)
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0xF0D278", Offset = "0xF0D278", VA = "0xF0D278")]
	protected void PlaySound(string name)
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0xF0AE24", Offset = "0xF0AE24", VA = "0xF0AE24")]
	private void PlayBGM()
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0xF10E5C", Offset = "0xF10E5C", VA = "0xF10E5C")]
	public void OnExitGame(Action action)
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0xF0EF90", Offset = "0xF0EF90", VA = "0xF0EF90")]
	private void RefreshProgress()
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0xF1136C", Offset = "0xF1136C", VA = "0xF1136C")]
	public void AddCubeColliderData(object parm)
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0xF0D434", Offset = "0xF0D434", VA = "0xF0D434")]
	public void ClearCubeColliderData()
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0xF11550", Offset = "0xF11550", VA = "0xF11550")]
	public CubeManager()
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0xF11778", Offset = "0xF11778", VA = "0xF11778")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D2D0", Offset = "0x73D2D0")]
	private void <PortalLoadSuccess>b__23_1(object parm)
	{
	}
}
[Token(Token = "0x2000096")]
public class GMmgr : MonoBehaviour
{
	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject appConsole;

	[Token(Token = "0x6000344")]
	[Address(RVA = "0xF16D9C", Offset = "0xF16D9C", VA = "0xF16D9C")]
	private void OpenAppConsole(object obj)
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0xF16EB8", Offset = "0xF16EB8", VA = "0xF16EB8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0xF17068", Offset = "0xF17068", VA = "0xF17068")]
	public GMmgr()
	{
	}
}
[Token(Token = "0x2000097")]
public class GameDefind
{
	[Token(Token = "0x6000347")]
	[Address(RVA = "0xF17070", Offset = "0xF17070", VA = "0xF17070")]
	public GameDefind()
	{
	}
}
[Token(Token = "0x2000098")]
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

	[Token(Token = "0x6000348")]
	[Address(RVA = "0xEFC378", Offset = "0xEFC378", VA = "0xEFC378")]
	public CubeData()
	{
	}
}
[Token(Token = "0x2000099")]
public class AttachData : CubeData
{
	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string audioUrl;

	[Token(Token = "0x6000349")]
	[Address(RVA = "0xEFC370", Offset = "0xEFC370", VA = "0xEFC370")]
	public AttachData()
	{
	}
}
[Token(Token = "0x200009A")]
public enum RootType
{
	[Token(Token = "0x4000254")]
	Item,
	[Token(Token = "0x4000255")]
	Show
}
[Token(Token = "0x200009B")]
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
[Token(Token = "0x200009C")]
public enum CubeRootType
{
	[Token(Token = "0x400025D")]
	Item,
	[Token(Token = "0x400025E")]
	Show
}
[Token(Token = "0x200009D")]
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
[Token(Token = "0x200009E")]
public static class GAME_UTILS
{
	[Token(Token = "0x600034A")]
	[Address(RVA = "0xF16860", Offset = "0xF16860", VA = "0xF16860")]
	public static string FirstCharToUpper(string str)
	{
		return null;
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0xF16948", Offset = "0xF16948", VA = "0xF16948")]
	public static Vector3 GetCenterPos(Transform transform_)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0xF16A24", Offset = "0xF16A24", VA = "0xF16A24")]
	public static float RoundTwoDecimal(float T)
	{
		return default(float);
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0xF16A68", Offset = "0xF16A68", VA = "0xF16A68")]
	private static bool PointIsInsideMeshCollider(Collider c, Vector3 p)
	{
		return default(bool);
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0xF16CF8", Offset = "0xF16CF8", VA = "0xF16CF8")]
	public static bool IsInterCollider(Collider[] colliders, Vector3 point)
	{
		return default(bool);
	}
}
[Token(Token = "0x200009F")]
public class GuideManager : CubeManager
{
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C184", Offset = "0x73C184")]
	private sealed class <>c__DisplayClass17_0
	{
		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Count;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GuideManager <>4__this;

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x10655E4", Offset = "0x10655E4", VA = "0x10655E4")]
		public <>c__DisplayClass17_0()
		{
		}
	}

	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C194", Offset = "0x73C194")]
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

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x10655EC", Offset = "0x10655EC", VA = "0x10655EC")]
		public <>c__DisplayClass17_1()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x10655F4", Offset = "0x10655F4", VA = "0x10655F4")]
		internal void <InitCube>b__0()
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x20000A2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C1A4", Offset = "0x73C1A4")]
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

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x106584C", Offset = "0x106584C", VA = "0x106584C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x1066AB0", Offset = "0x1066AB0", VA = "0x1066AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x20000A3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C1B4", Offset = "0x73C1B4")]
	private sealed class <>c__DisplayClass19_0
	{
		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Cube cube;

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x1065818", Offset = "0x1065818", VA = "0x1065818")]
		public <>c__DisplayClass19_0()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x1065820", Offset = "0x1065820", VA = "0x1065820")]
		internal bool <PlayFlyAnim>b__0(CubeData item)
		{
			return default(bool);
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x20000A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C1C4", Offset = "0x73C1C4")]
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

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x1066ABC", Offset = "0x1066ABC", VA = "0x1066ABC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x10672B4", Offset = "0x10672B4", VA = "0x10672B4", Slot = "5")]
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
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73C9B8", Offset = "0x73C9B8")]
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

	[Token(Token = "0x600034F")]
	[Address(RVA = "0xF18924", Offset = "0xF18924", VA = "0xF18924", Slot = "4")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x73D330", Offset = "0x73D330")]
	public override void InitCube()
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0xF189FC", Offset = "0xF189FC", VA = "0xF189FC", Slot = "7")]
	public override void AssembleFinish()
	{
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0xF18C8C", Offset = "0xF18C8C", VA = "0xF18C8C")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x73D390", Offset = "0x73D390")]
	private void PlayFlyAnim(CubeRoot root)
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0xF18D8C", Offset = "0xF18D8C", VA = "0xF18D8C")]
	private void update()
	{
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0xF18D90", Offset = "0xF18D90", VA = "0xF18D90")]
	public GuideManager()
	{
	}
}
[Token(Token = "0x20000A5")]
public class Hand : BaseHand
{
	[Token(Token = "0x20000A6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C1D4", Offset = "0x73C1D4")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Cube cube;

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x10672C0", Offset = "0x10672C0", VA = "0x10672C0")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x10672C8", Offset = "0x10672C8", VA = "0x10672C8")]
		internal bool <IsInsertedRoot>b__0(Cube item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000A7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C1E4", Offset = "0x73C1E4")]
	private sealed class <>c__DisplayClass25_0
	{
		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Cube cube;

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x1067340", Offset = "0x1067340", VA = "0x1067340")]
		public <>c__DisplayClass25_0()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1067348", Offset = "0x1067348", VA = "0x1067348")]
		internal bool <InsertDragRoot>b__0(Cube item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C1F4", Offset = "0x73C1F4")]
	private sealed class <>c__DisplayClass26_0
	{
		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Cube cube;

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x10673C0", Offset = "0x10673C0", VA = "0x10673C0")]
		public <>c__DisplayClass26_0()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x10673C8", Offset = "0x10673C8", VA = "0x10673C8")]
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
		[Token(Token = "0x600035D")]
		[Address(RVA = "0xF18E1C", Offset = "0xF18E1C", VA = "0xF18E1C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600035E")]
		[Address(RVA = "0xF18E24", Offset = "0xF18E24", VA = "0xF18E24")]
		set
		{
		}
	}

	[Token(Token = "0x17000076")]
	public bool IsFollowHand
	{
		[Token(Token = "0x600035F")]
		[Address(RVA = "0xF18E2C", Offset = "0xF18E2C", VA = "0xF18E2C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000360")]
		[Address(RVA = "0xF18E34", Offset = "0xF18E34", VA = "0xF18E34")]
		set
		{
		}
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0xF18E40", Offset = "0xF18E40", VA = "0xF18E40")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0xF192C0", Offset = "0xF192C0", VA = "0xF192C0")]
	private void SetHandPress(object obj)
	{
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0xF19344", Offset = "0xF19344", VA = "0xF19344")]
	public void HideXrRay(object parm)
	{
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0xF19364", Offset = "0xF19364", VA = "0xF19364")]
	public void ShowXrRay(object parm)
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0xF19384", Offset = "0xF19384", VA = "0xF19384")]
	public void InitCubeManager(object parm)
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0xF194D8", Offset = "0xF194D8", VA = "0xF194D8")]
	public void ClearEvent(object parm)
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0xF1984C", Offset = "0xF1984C", VA = "0xF1984C")]
	public bool IsInsertedRoot(Cube cube)
	{
		return default(bool);
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0xF19998", Offset = "0xF19998", VA = "0xF19998")]
	public void InsertDragRoot(Cube cube)
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0xF19B5C", Offset = "0xF19B5C", VA = "0xF19B5C")]
	public void RemoveDragRoot(Cube cube)
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0xF19EB4", Offset = "0xF19EB4", VA = "0xF19EB4")]
	public CubeRoot GetDragRoot()
	{
		return null;
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0xF1961C", Offset = "0xF1961C", VA = "0xF1961C")]
	private void RefreshLine()
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0xF1A174", Offset = "0xF1A174", VA = "0xF1A174")]
	public void DragCubeRoot(CubeRoot root)
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0xF1A268", Offset = "0xF1A268", VA = "0xF1A268", Slot = "5")]
	public override void OnTriggerDevice(float triggerValue)
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0xF1A690", Offset = "0xF1A690", VA = "0xF1A690", Slot = "4")]
	public override void OnTriggerPress()
	{
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0xF1A848", Offset = "0xF1A848", VA = "0xF1A848")]
	public void OrganizeItems(object parm)
	{
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0xF1A9A4", Offset = "0xF1A9A4", VA = "0xF1A9A4")]
	public CubeRoot PreDragCubeRoot()
	{
		return null;
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0xF1A9AC", Offset = "0xF1A9AC", VA = "0xF1A9AC")]
	public void InsertPreDragCubeRoot(CubeRoot root)
	{
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0xF1AA88", Offset = "0xF1AA88", VA = "0xF1AA88")]
	public void RemovePreDragCubeRoot(CubeRoot root)
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0xF19DAC", Offset = "0xF19DAC", VA = "0xF19DAC")]
	public void ClearPreDragCubeRoot()
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0xF1AC60", Offset = "0xF1AC60", VA = "0xF1AC60", Slot = "6")]
	public override void OnPrimary2DAxis(Vector2 value)
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0xF1AC64", Offset = "0xF1AC64", VA = "0xF1AC64", Slot = "7")]
	public override void onPrimary2DPress()
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0xF1AD08", Offset = "0xF1AD08", VA = "0xF1AD08")]
	public void HandHaptic(float value = 0.4f, float duration = 0.3f)
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0xF1AD88", Offset = "0xF1AD88", VA = "0xF1AD88")]
	public void HandHapticStrong(object pram)
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0xF1ADF8", Offset = "0xF1ADF8", VA = "0xF1ADF8", Slot = "8")]
	public override void onResetHand()
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0xF1AF2C", Offset = "0xF1AF2C", VA = "0xF1AF2C")]
	public Hand()
	{
	}
}
[Token(Token = "0x20000A9")]
public class CheckChangeTest : MonoBehaviour
{
	[Token(Token = "0x6000380")]
	[Address(RVA = "0xF03F8C", Offset = "0xF03F8C", VA = "0xF03F8C")]
	public CheckChangeTest()
	{
	}
}
[Token(Token = "0x20000AA")]
public class CubeColliderCreate : MonoBehaviour
{
	[Token(Token = "0x6000381")]
	[Address(RVA = "0xF071B8", Offset = "0xF071B8", VA = "0xF071B8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0xF07394", Offset = "0xF07394", VA = "0xF07394")]
	private void Update()
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0xF07398", Offset = "0xF07398", VA = "0xF07398")]
	public CubeColliderCreate()
	{
	}
}
[Token(Token = "0x20000AB")]
public class CubeTest : MonoBehaviour
{
	[Token(Token = "0x20000AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C204", Offset = "0x73C204")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x10633F4", Offset = "0x10633F4", VA = "0x10633F4")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x10633FC", Offset = "0x10633FC", VA = "0x10633FC")]
		internal bool <OnCollisionEnter>b__0(string item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000AD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C214", Offset = "0x73C214")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1063410", Offset = "0x1063410", VA = "0x1063410")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1063418", Offset = "0x1063418", VA = "0x1063418")]
		internal bool <OnTriggerEnter>b__0(string item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<string> colliderNames;

	[Token(Token = "0x6000384")]
	[Address(RVA = "0xF13C6C", Offset = "0xF13C6C", VA = "0xF13C6C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0xF13C70", Offset = "0xF13C70", VA = "0xF13C70")]
	private void Update()
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0xF13C74", Offset = "0xF13C74", VA = "0xF13C74")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0xF13E9C", Offset = "0xF13E9C", VA = "0xF13E9C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0xF140AC", Offset = "0xF140AC", VA = "0xF140AC")]
	public CubeTest()
	{
	}
}
[Token(Token = "0x20000AE")]
public class ExportData : MonoBehaviour
{
	[Token(Token = "0x600038D")]
	[Address(RVA = "0xF15614", Offset = "0xF15614", VA = "0xF15614")]
	private void Start()
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0xF156D4", Offset = "0xF156D4", VA = "0xF156D4")]
	public void CheckTargetDirForMe(Transform target, Transform self)
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0xF15E14", Offset = "0xF15E14", VA = "0xF15E14")]
	private void Update()
	{
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0xF15E18", Offset = "0xF15E18", VA = "0xF15E18")]
	public ExportData()
	{
	}
}
[Token(Token = "0x20000AF")]
public class BackUpWindow : UIWindow
{
	[Serializable]
	[Token(Token = "0x20000B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C224", Offset = "0x73C224")]
	private sealed class <>c
	{
		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action <>9__0_0;

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x10619C4", Offset = "0x10619C4", VA = "0x10619C4")]
		public <>c()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x10619CC", Offset = "0x10619CC", VA = "0x10619CC")]
		internal void <OnOpen>b__0_0()
		{
		}
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0xEFF4E8", Offset = "0xEFF4E8", VA = "0xEFF4E8", Slot = "8")]
	public override void OnOpen(object args)
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0xEFF660", Offset = "0xEFF660", VA = "0xEFF660")]
	public BackUpWindow()
	{
	}
}
[Token(Token = "0x20000B1")]
public class BookAniEvent : MonoBehaviour
{
	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityAction cb;

	[Token(Token = "0x6000396")]
	[Address(RVA = "0xF00CCC", Offset = "0xF00CCC", VA = "0xF00CCC")]
	public void OnOpened()
	{
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0xF00CE0", Offset = "0xF00CE0", VA = "0xF00CE0")]
	public BookAniEvent()
	{
	}
}
[Token(Token = "0x20000B2")]
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
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73CA10", Offset = "0x73CA10")]
	public float showTime;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Animation rootAnimation;

	[Token(Token = "0x6000398")]
	[Address(RVA = "0xF02814", Offset = "0xF02814", VA = "0xF02814")]
	private void OnSceneLoadedAnimEnd(object obj)
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0xF02830", Offset = "0xF02830", VA = "0xF02830")]
	private void OnBookOpened()
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0xF02858", Offset = "0xF02858", VA = "0xF02858")]
	private void Start()
	{
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0xF02A3C", Offset = "0xF02A3C", VA = "0xF02A3C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0xF02B68", Offset = "0xF02B68", VA = "0xF02B68")]
	public BookRoot()
	{
	}
}
[Token(Token = "0x20000B3")]
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

	[Token(Token = "0x600039D")]
	[Address(RVA = "0xF05124", Offset = "0xF05124", VA = "0xF05124")]
	private void Start()
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0xF05210", Offset = "0xF05210", VA = "0xF05210")]
	public void SetConfirmData(UnityAction cb)
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0xF05218", Offset = "0xF05218", VA = "0xF05218")]
	public void SetFonet(int key)
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0xF05234", Offset = "0xF05234", VA = "0xF05234")]
	private void OnConfirm()
	{
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0xF0527C", Offset = "0xF0527C", VA = "0xF0527C")]
	public ConfirmWindow()
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0xF05284", Offset = "0xF05284", VA = "0xF05284")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D410", Offset = "0x73D410")]
	private void <Start>b__4_0()
	{
	}
}
[Token(Token = "0x20000B4")]
public class LevelWindow : UIWindow
{
	[Token(Token = "0x20000B5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C234", Offset = "0x73C234")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LevelWindow <>4__this;

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x10674DC", Offset = "0x10674DC", VA = "0x10674DC")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x10674E4", Offset = "0x10674E4", VA = "0x10674E4")]
		internal void <CreateLevel>b__3()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20000B6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C244", Offset = "0x73C244")]
	private sealed class <>c
	{
		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<int> <>9__3_2;

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x10674A4", Offset = "0x10674A4", VA = "0x10674A4")]
		public <>c()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x10674AC", Offset = "0x10674AC", VA = "0x10674AC")]
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

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0xF1E92C", Offset = "0xF1E92C", VA = "0xF1E92C", Slot = "8")]
	public override void OnOpen(object args)
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0xF1E9A8", Offset = "0xF1E9A8", VA = "0xF1E9A8")]
	private void CreateLevel()
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0xF1F258", Offset = "0xF1F258", VA = "0xF1F258")]
	public void OnChoseLevel(int id)
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0xF1F34C", Offset = "0xF1F34C", VA = "0xF1F34C")]
	public void OnStartGame(bool isRestart)
	{
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0xF1F7E4", Offset = "0xF1F7E4", VA = "0xF1F7E4")]
	public LevelWindow()
	{
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0xF1F7EC", Offset = "0xF1F7EC", VA = "0xF1F7EC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D420", Offset = "0x73D420")]
	private void <CreateLevel>b__3_0()
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0xF1F7F4", Offset = "0xF1F7F4", VA = "0xF1F7F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D430", Offset = "0x73D430")]
	private void <CreateLevel>b__3_1()
	{
	}
}
[Token(Token = "0x20000B7")]
public class OrganizeItemsWindow : UIWindow
{
	[Serializable]
	[Token(Token = "0x20000B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C254", Offset = "0x73C254")]
	private sealed class <>c
	{
		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action <>9__0_0;

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x1067984", Offset = "0x1067984", VA = "0x1067984")]
		public <>c()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x106798C", Offset = "0x106798C", VA = "0x106798C")]
		internal void <OnOpen>b__0_0()
		{
		}
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0xF227B4", Offset = "0xF227B4", VA = "0xF227B4", Slot = "8")]
	public override void OnOpen(object args)
	{
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0xF2292C", Offset = "0xF2292C", VA = "0xF2292C")]
	public OrganizeItemsWindow()
	{
	}
}
[Token(Token = "0x20000B9")]
public class PullGuideWindow : UIWindow
{
	[Token(Token = "0x60003B4")]
	[Address(RVA = "0xF264B8", Offset = "0xF264B8", VA = "0xF264B8")]
	public PullGuideWindow()
	{
	}
}
[Token(Token = "0x20000BA")]
public class ThemeAnimEvent : MonoBehaviour
{
	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Dictionary<string, Action> callbackDic;

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0xE67B84", Offset = "0xE67B84", VA = "0xE67B84")]
	private void OnActionEnd(string key)
	{
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0xE67CA0", Offset = "0xE67CA0", VA = "0xE67CA0")]
	public ThemeAnimEvent()
	{
	}
}
[Token(Token = "0x20000BB")]
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

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0xE68720", Offset = "0xE68720", VA = "0xE68720")]
	public ThemeData(bool completed)
	{
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0xE68750", Offset = "0xE68750", VA = "0xE68750")]
	public ThemeData(string modleName, string Image_level, int stageGroupId)
	{
	}
}
[Token(Token = "0x20000BC")]
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

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0xE687B4", Offset = "0xE687B4", VA = "0xE687B4")]
	private void OnHoverEntered(Transform interactor, Transform hands)
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0xE688AC", Offset = "0xE688AC", VA = "0xE688AC")]
	private void OnHoverExited(Transform interactor, Transform hands)
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0xE6899C", Offset = "0xE6899C", VA = "0xE6899C")]
	private void OnTriggerEvent(float value, XRRayInteractor hands, Transform handTrans)
	{
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0xE68AB0", Offset = "0xE68AB0", VA = "0xE68AB0")]
	public void InitOrgData()
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0xE68AB4", Offset = "0xE68AB4", VA = "0xE68AB4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0xE68D64", Offset = "0xE68D64", VA = "0xE68D64")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0xE68F84", Offset = "0xE68F84", VA = "0xE68F84")]
	public ThemeObjInteraction()
	{
	}
}
[Token(Token = "0x20000BD")]
public enum HoverType
{
	[Token(Token = "0x40002B9")]
	spotlight,
	[Token(Token = "0x40002BA")]
	fresnel
}
[Token(Token = "0x20000BE")]
public class ThemeProgressLabel : MonoBehaviour
{
	[Token(Token = "0x20000BF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C264", Offset = "0x73C264")]
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
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x106B254", Offset = "0x106B254", VA = "0x106B254", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x106B29C", Offset = "0x106B29C", VA = "0x106B29C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x106B154", Offset = "0x106B154", VA = "0x106B154")]
		[DebuggerHidden]
		public <PlayIdelCoroutine>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x106B180", Offset = "0x106B180", VA = "0x106B180", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x106B184", Offset = "0x106B184", VA = "0x106B184", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x106B25C", Offset = "0x106B25C", VA = "0x106B25C", Slot = "8")]
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
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xE691B4", Offset = "0xE691B4", VA = "0xE691B4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0xE69008", Offset = "0xE69008", VA = "0xE69008")]
	private void PlayAction()
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0xE6929C", Offset = "0xE6929C", VA = "0xE6929C")]
	private void PlayAmin(string anim)
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0xE693C8", Offset = "0xE693C8", VA = "0xE693C8")]
	private void PlayIdel()
	{
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0xE69470", Offset = "0xE69470", VA = "0xE69470")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73D440", Offset = "0x73D440")]
	private IEnumerator PlayIdelCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0xE694E8", Offset = "0xE694E8", VA = "0xE694E8")]
	private void SetActionAnimEvent()
	{
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0xE6974C", Offset = "0xE6974C", VA = "0xE6974C")]
	private void ObjHoverEntered(HoverEnterEventArgs hoverEnterEventArgs)
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0xE69BC0", Offset = "0xE69BC0", VA = "0xE69BC0")]
	private void ObjHoverExited(HoverExitEventArgs hoverExitEventArgs)
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0xE69A60", Offset = "0xE69A60", VA = "0xE69A60")]
	private void SetMaterialEffect(GameObject obj, bool isEnable, string Attribute = "_fresnelOFF")
	{
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0xE699C8", Offset = "0xE699C8", VA = "0xE699C8")]
	private void SetSpotlight()
	{
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0xE69DD0", Offset = "0xE69DD0", VA = "0xE69DD0")]
	private void OnTriggerEvent(float value, XRRayInteractor hands, Transform handTrans)
	{
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0xE69340", Offset = "0xE69340", VA = "0xE69340")]
	private void PlayAudio()
	{
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0xE58D68", Offset = "0xE58D68", VA = "0xE58D68")]
	public void OnSceneLoaded(object stageId)
	{
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0xE69F00", Offset = "0xE69F00", VA = "0xE69F00")]
	private void PlaySceneLoadedAction(object stageId)
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0xE69FA4", Offset = "0xE69FA4", VA = "0xE69FA4")]
	public void SetData(ThemeData themeData)
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0xE6A4BC", Offset = "0xE6A4BC", VA = "0xE6A4BC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0xE6A7B0", Offset = "0xE6A7B0", VA = "0xE6A7B0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0xE6A930", Offset = "0xE6A930", VA = "0xE6A930")]
	public ThemeProgressLabel()
	{
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0xE6A9B4", Offset = "0xE6A9B4", VA = "0xE6A9B4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D4A0", Offset = "0x73D4A0")]
	private void <SetActionAnimEvent>b__24_0()
	{
	}
}
[Token(Token = "0x20000C0")]
public class ThemeProgressMgr : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000C1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C274", Offset = "0x73C274")]
	private sealed class <>c
	{
		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<StageGroupCfg> <>9__10_0;

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x106B308", Offset = "0x106B308", VA = "0x106B308")]
		public <>c()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x106B310", Offset = "0x106B310", VA = "0x106B310")]
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

	[Token(Token = "0x60003D9")]
	public static T GetOrAddComponent<T>(GameObject obj) where T : Component
	{
		return null;
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0xE6AA70", Offset = "0xE6AA70", VA = "0xE6AA70")]
	private void OnTriggerEvent(float value, XRRayInteractor hands, Transform handTrans)
	{
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0xE6AB40", Offset = "0xE6AB40", VA = "0xE6AB40")]
	private void SetMaterialEffect(GameObject obj, bool isEnable, string Attribute = "_fresnelOFF")
	{
	}

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0xE6AC64", Offset = "0xE6AC64", VA = "0xE6AC64")]
	private void OnClickBackBrn()
	{
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0xE6AC8C", Offset = "0xE6AC8C", VA = "0xE6AC8C")]
	private void PlayBgm(ThemeCfg themeCfg)
	{
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0xE6ACFC", Offset = "0xE6ACFC", VA = "0xE6ACFC")]
	public void InitData(ThemeCfg themeCfg)
	{
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0xE6B440", Offset = "0xE6B440", VA = "0xE6B440")]
	public void BackToMainScene()
	{
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0xE6B2AC", Offset = "0xE6B2AC", VA = "0xE6B2AC")]
	public void InitThemeList(List<ThemeData> themeData)
	{
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0xE6B468", Offset = "0xE6B468", VA = "0xE6B468")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0xE6B848", Offset = "0xE6B848", VA = "0xE6B848")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0xE6B96C", Offset = "0xE6B96C", VA = "0xE6B96C")]
	public ThemeProgressMgr()
	{
	}
}
[Token(Token = "0x20000C2")]
public class TweenObjOrgData : MonoBehaviour
{
	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 _orgScale;

	[Token(Token = "0x1700007A")]
	public Vector3 orgScale
	{
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xE6BC44", Offset = "0xE6BC44", VA = "0xE6BC44")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0xE6BC50", Offset = "0xE6BC50", VA = "0xE6BC50")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0xE6BC8C", Offset = "0xE6BC8C", VA = "0xE6BC8C")]
	public TweenObjOrgData()
	{
	}
}
[Serializable]
[Token(Token = "0x20000C3")]
public class CubeModel : BaseModel
{
	[Token(Token = "0x20000C4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C284", Offset = "0x73C284")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Id;

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x106306C", Offset = "0x106306C", VA = "0x106306C")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1063074", Offset = "0x1063074", VA = "0x1063074")]
		internal bool <ClearDataById>b__0(CubeModeData item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000C5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C294", Offset = "0x73C294")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Id;

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1063098", Offset = "0x1063098", VA = "0x1063098")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x10630A0", Offset = "0x10630A0", VA = "0x10630A0")]
		internal bool <AssembleItems>b__0(CubeModeData item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000C6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C2A4", Offset = "0x73C2A4")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Id;

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x10630C4", Offset = "0x10630C4", VA = "0x10630C4")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x10630CC", Offset = "0x10630CC", VA = "0x10630CC")]
		internal bool <UpdateTransform>b__0(CubeModeData item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000C7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C2B4", Offset = "0x73C2B4")]
	private sealed class <>c__DisplayClass11_0
	{
		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Id;

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1063040", Offset = "0x1063040", VA = "0x1063040")]
		public <>c__DisplayClass11_0()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1063048", Offset = "0x1063048", VA = "0x1063048")]
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

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0xF11940", Offset = "0xF11940", VA = "0xF11940", Slot = "6")]
	public override void Init()
	{
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0xF0C838", Offset = "0xF0C838", VA = "0xF0C838")]
	public void InsertData(string Id, string cubeId, Vector3 pos, Quaternion rotation, int planeIndex)
	{
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0xF0ED34", Offset = "0xF0ED34", VA = "0xF0ED34")]
	public void ClearDataById(string Id)
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0xF0EB1C", Offset = "0xF0EB1C", VA = "0xF0EB1C")]
	public void AssembleItems(string Id, List<Cube> cubes)
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0xF0E9CC", Offset = "0xF0E9CC", VA = "0xF0E9CC")]
	public void UpdateTransform(string Id, Transform transform, int planeIndex = -1)
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0xF11944", Offset = "0xF11944", VA = "0xF11944")]
	public void ToJson()
	{
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0xF0C9B0", Offset = "0xF0C9B0", VA = "0xF0C9B0")]
	public CubeModeData GetDataById(string Id)
	{
		return null;
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0xF0941C", Offset = "0xF0941C", VA = "0xF0941C")]
	public CubeModel()
	{
	}
}
[Serializable]
[Token(Token = "0x20000C8")]
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

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0xF11938", Offset = "0xF11938", VA = "0xF11938")]
	public CubeModeData()
	{
	}
}
[Token(Token = "0x20000C9")]
public class GameSceneModel : BaseModel
{
	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public new static string modelName;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CA48", Offset = "0x73CA48")]
	private SceneData <sceneData>k__BackingField;

	[Token(Token = "0x1700007B")]
	public override string ModelName
	{
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xF18738", Offset = "0xF18738", VA = "0xF18738", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xF1879C", Offset = "0xF1879C", VA = "0xF1879C", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x1700007C")]
	public SceneData sceneData
	{
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xF18808", Offset = "0xF18808", VA = "0xF18808")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D500", Offset = "0x73D500")]
		get
		{
			return default(SceneData);
		}
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xF18814", Offset = "0xF18814", VA = "0xF18814")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D510", Offset = "0x73D510")]
		set
		{
		}
	}

	[Token(Token = "0x1700007D")]
	public string sceneName
	{
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xF18824", Offset = "0xF18824", VA = "0xF18824")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700007E")]
	public int stageId
	{
		[Token(Token = "0x6000400")]
		[Address(RVA = "0xF1882C", Offset = "0xF1882C", VA = "0xF1882C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700007F")]
	public bool isRestart
	{
		[Token(Token = "0x6000401")]
		[Address(RVA = "0xF18834", Offset = "0xF18834", VA = "0xF18834")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0xF18844", Offset = "0xF18844", VA = "0xF18844", Slot = "6")]
	public override void Init()
	{
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0xF1884C", Offset = "0xF1884C", VA = "0xF1884C", Slot = "7")]
	public override void Destroy()
	{
	}

	[Token(Token = "0x6000404")]
	[Address(RVA = "0xF18854", Offset = "0xF18854", VA = "0xF18854")]
	public GameSceneModel()
	{
	}
}
[Token(Token = "0x20000CA")]
public class LoginModel : BaseModel
{
	[Token(Token = "0x20000CB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C2C4", Offset = "0x73C2C4")]
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
			[Token(Token = "0x6000411")]
			[Address(RVA = "0x10678D0", Offset = "0x10678D0", VA = "0x10678D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x1067918", Offset = "0x1067918", VA = "0x1067918", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x1067508", Offset = "0x1067508", VA = "0x1067508")]
		[DebuggerHidden]
		public <SendLoginMsg>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x1067534", Offset = "0x1067534", VA = "0x1067534", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x1067538", Offset = "0x1067538", VA = "0x1067538", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x10678D8", Offset = "0x10678D8", VA = "0x10678D8", Slot = "8")]
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
		[Token(Token = "0x6000406")]
		[Address(RVA = "0xF1F9DC", Offset = "0xF1F9DC", VA = "0xF1F9DC", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000407")]
		[Address(RVA = "0xF1FA40", Offset = "0xF1FA40", VA = "0xF1FA40", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000081")]
	private string reportUrl
	{
		[Token(Token = "0x6000408")]
		[Address(RVA = "0xF1FAAC", Offset = "0xF1FAAC", VA = "0xF1FAAC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0xF1FAF0", Offset = "0xF1FAF0", VA = "0xF1FAF0", Slot = "6")]
	public override void Init()
	{
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0xF1FAF8", Offset = "0xF1FAF8", VA = "0xF1FAF8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73D520", Offset = "0x73D520")]
	public IEnumerator SendLoginMsg()
	{
		return null;
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0xF1FB70", Offset = "0xF1FB70", VA = "0xF1FB70")]
	public void LoginBackMsg(object msg)
	{
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0xF1FD5C", Offset = "0xF1FD5C", VA = "0xF1FD5C")]
	public LoginModel()
	{
	}
}
[Serializable]
[Token(Token = "0x20000CC")]
public class PlayerDataModel : BaseModel
{
	[Token(Token = "0x20000CD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C2D4", Offset = "0x73C2D4")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int nStageId;

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x1067C98", Offset = "0x1067C98", VA = "0x1067C98")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x1067CA0", Offset = "0x1067CA0", VA = "0x1067CA0")]
		internal bool <RefreshStageInfo>b__0(StageInfo item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000CE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C2E4", Offset = "0x73C2E4")]
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
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x10681FC", Offset = "0x10681FC", VA = "0x10681FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000423")]
			[Address(RVA = "0x1068244", Offset = "0x1068244", VA = "0x1068244", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x1067CC4", Offset = "0x1067CC4", VA = "0x1067CC4")]
		[DebuggerHidden]
		public <SendStageMsg>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x1067CF0", Offset = "0x1067CF0", VA = "0x1067CF0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x1067CF4", Offset = "0x1067CF4", VA = "0x1067CF4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x1068204", Offset = "0x1068204", VA = "0x1068204", Slot = "8")]
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
		[Token(Token = "0x6000414")]
		[Address(RVA = "0xF23C38", Offset = "0xF23C38", VA = "0xF23C38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000085")]
	public override string ModelName
	{
		[Token(Token = "0x6000417")]
		[Address(RVA = "0xF23FCC", Offset = "0xF23FCC", VA = "0xF23FCC", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000418")]
		[Address(RVA = "0xF24030", Offset = "0xF24030", VA = "0xF24030", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0xF23C7C", Offset = "0xF23C7C", VA = "0xF23C7C")]
	public void SetDefaultData()
	{
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0xF23E60", Offset = "0xF23E60", VA = "0xF23E60")]
	public void RefreshStageInfo(int nStageId, float fProgress)
	{
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0xF2409C", Offset = "0xF2409C", VA = "0xF2409C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73D5D0", Offset = "0x73D5D0")]
	public IEnumerator SendStageMsg(int nStageId)
	{
		return null;
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0xF24124", Offset = "0xF24124", VA = "0xF24124")]
	public PlayerDataModel()
	{
	}
}
[Serializable]
[Token(Token = "0x20000CF")]
public class StageInfo
{
	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int stageId;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float stageProgress;

	[Token(Token = "0x6000424")]
	[Address(RVA = "0xE5EB20", Offset = "0xE5EB20", VA = "0xE5EB20")]
	public StageInfo()
	{
	}
}
[Serializable]
[Token(Token = "0x20000D0")]
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
		[Token(Token = "0x6000425")]
		[Address(RVA = "0xE6CD80", Offset = "0xE6CD80", VA = "0xE6CD80", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000426")]
		[Address(RVA = "0xE6CDE4", Offset = "0xE6CDE4", VA = "0xE6CDE4", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x6000427")]
	[Address(RVA = "0xE6CE50", Offset = "0xE6CE50", VA = "0xE6CE50")]
	public UserModel()
	{
	}
}
[Token(Token = "0x20000D1")]
public class PlayerController : MonoBehaviour
{
	[Token(Token = "0x20000D2")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CA58", Offset = "0x73CA58")]
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
		[Token(Token = "0x6000429")]
		[Address(RVA = "0xF23304", Offset = "0xF23304", VA = "0xF23304")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D680", Offset = "0x73D680")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600042A")]
		[Address(RVA = "0xF2330C", Offset = "0xF2330C", VA = "0xF2330C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D690", Offset = "0x73D690")]
		private set
		{
		}
	}

	[Token(Token = "0x1700008A")]
	public static PlayerController instance
	{
		[Token(Token = "0x600042B")]
		[Address(RVA = "0xF23314", Offset = "0xF23314", VA = "0xF23314")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0xF23378", Offset = "0xF23378", VA = "0xF23378")]
	public void RegisterUpdate(Action callback)
	{
	}

	[Token(Token = "0x600042D")]
	[Address(RVA = "0xF23404", Offset = "0xF23404", VA = "0xF23404")]
	public void UnRegisterUpdate(Action callback)
	{
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0xF23490", Offset = "0xF23490", VA = "0xF23490")]
	private void Awake()
	{
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0xF23690", Offset = "0xF23690", VA = "0xF23690")]
	public void PlayStart()
	{
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0xF237A8", Offset = "0xF237A8", VA = "0xF237A8")]
	public void PlayEnd()
	{
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0xF23854", Offset = "0xF23854", VA = "0xF23854")]
	public void PlayStartEnd(object obj)
	{
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0xF23868", Offset = "0xF23868", VA = "0xF23868")]
	public void PlayEndEnd(object obj)
	{
	}

	[Token(Token = "0x6000433")]
	[Address(RVA = "0xF2390C", Offset = "0xF2390C", VA = "0xF2390C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0xF23A3C", Offset = "0xF23A3C", VA = "0xF23A3C")]
	private void InvokeActions(List<Action> actions)
	{
	}

	[Token(Token = "0x6000435")]
	[Address(RVA = "0xF23B28", Offset = "0xF23B28", VA = "0xF23B28")]
	public PlayerController()
	{
	}
}
[Token(Token = "0x20000D3")]
public class SceneCameraPos : MonoBehaviour
{
	[Token(Token = "0x600043B")]
	[Address(RVA = "0xF2C024", Offset = "0xF2C024", VA = "0xF2C024")]
	private void Awake()
	{
	}

	[Token(Token = "0x600043C")]
	[Address(RVA = "0xF2C0D8", Offset = "0xF2C0D8", VA = "0xF2C0D8")]
	public SceneCameraPos()
	{
	}
}
[Token(Token = "0x20000D4")]
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
[Token(Token = "0x20000D5")]
public class TestVO
{
	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<int> list1;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Vector3> list2;

	[Token(Token = "0x600043D")]
	[Address(RVA = "0xE6661C", Offset = "0xE6661C", VA = "0xE6661C")]
	public TestVO()
	{
	}
}
[Token(Token = "0x20000D6")]
public class Test : MonoBehaviour
{
	[Token(Token = "0x600043E")]
	[Address(RVA = "0xE660A8", Offset = "0xE660A8", VA = "0xE660A8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0xE66130", Offset = "0xE66130", VA = "0xE66130")]
	private void Start()
	{
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0xE662F0", Offset = "0xE662F0", VA = "0xE662F0")]
	public void TestAttrbute()
	{
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0xE66418", Offset = "0xE66418", VA = "0xE66418")]
	public void testDataConfig()
	{
	}

	[Token(Token = "0x6000442")]
	[Address(RVA = "0xE6641C", Offset = "0xE6641C", VA = "0xE6641C")]
	public void testJson()
	{
	}

	[Token(Token = "0x6000443")]
	[Address(RVA = "0xE66624", Offset = "0xE66624", VA = "0xE66624")]
	public void testStaticConfigData()
	{
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0xE66628", Offset = "0xE66628", VA = "0xE66628")]
	private void Update()
	{
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0xE6662C", Offset = "0xE6662C", VA = "0xE6662C")]
	public Test()
	{
	}
}
[Serializable]
[Token(Token = "0x20000D7")]
public class TestModel : BaseModel
{
	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<string> nameList;

	[Token(Token = "0x6000446")]
	[Address(RVA = "0xE66634", Offset = "0xE66634", VA = "0xE66634", Slot = "6")]
	public override void Init()
	{
	}

	[Token(Token = "0x6000447")]
	[Address(RVA = "0xE666B8", Offset = "0xE666B8", VA = "0xE666B8", Slot = "7")]
	public override void Destroy()
	{
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0xE663B4", Offset = "0xE663B4", VA = "0xE663B4")]
	public TestModel()
	{
	}
}
[Token(Token = "0x20000D8")]
public class FirebasePlatform : IPlatform
{
	[Serializable]
	[Token(Token = "0x20000D9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C2F4", Offset = "0x73C2F4")]
	private sealed class <>c
	{
		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<System.Threading.Tasks.Task<DependencyStatus>> <>9__1_0;

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x1065124", Offset = "0x1065124", VA = "0x1065124")]
		public <>c()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x106512C", Offset = "0x106512C", VA = "0x106512C")]
		internal void <InitCrashlytics>b__1_0(System.Threading.Tasks.Task<DependencyStatus> task)
		{
		}
	}

	[Token(Token = "0x6000449")]
	[Address(RVA = "0xF15E20", Offset = "0xF15E20", VA = "0xF15E20", Slot = "4")]
	public override void InitSdk(SDKData sdkData)
	{
	}

	[Token(Token = "0x600044A")]
	[Address(RVA = "0xF15E94", Offset = "0xF15E94", VA = "0xF15E94")]
	private void InitCrashlytics()
	{
	}

	[Token(Token = "0x600044B")]
	[Address(RVA = "0xF15FF8", Offset = "0xF15FF8", VA = "0xF15FF8", Slot = "5")]
	public override void SetUserId(string userId)
	{
	}

	[Token(Token = "0x600044C")]
	[Address(RVA = "0xF16060", Offset = "0xF16060", VA = "0xF16060", Slot = "7")]
	public override void SendState(string name, string parameterName, string parameterValue)
	{
	}

	[Token(Token = "0x600044D")]
	[Address(RVA = "0xF160E0", Offset = "0xF160E0", VA = "0xF160E0", Slot = "6")]
	public override void SendState(string eventName, Dictionary<string, string> extraInfos)
	{
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0xF16850", Offset = "0xF16850", VA = "0xF16850")]
	public FirebasePlatform()
	{
	}
}
[Token(Token = "0x20000DA")]
public class IAPManager : MonoBehaviour
{
	[Token(Token = "0x6000452")]
	[Address(RVA = "0xF1AFEC", Offset = "0xF1AFEC", VA = "0xF1AFEC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0xF1B33C", Offset = "0xF1B33C", VA = "0xF1B33C")]
	public void Getpurch()
	{
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0xF1B404", Offset = "0xF1B404", VA = "0xF1B404")]
	public void PurchasesDurableCache(Oculus.Platform.Message<PurchaseList> msg)
	{
	}

	[Token(Token = "0x6000455")]
	[Address(RVA = "0xF1B018", Offset = "0xF1B018", VA = "0xF1B018")]
	public void FetchProductPrices()
	{
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0xF1B928", Offset = "0xF1B928", VA = "0xF1B928")]
	private void OnAssetDeatilsLis(Oculus.Platform.Message<AssetDetailsList> msg)
	{
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0xF1BDEC", Offset = "0xF1BDEC", VA = "0xF1BDEC")]
	private void GetProductsBySKUCallback(Oculus.Platform.Message<ProductList> msg)
	{
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0xF1B274", Offset = "0xF1B274", VA = "0xF1B274")]
	public void FetchPurchasedProducts()
	{
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0xF1C300", Offset = "0xF1C300", VA = "0xF1C300")]
	private void GetViewerPurchasesCallback(Oculus.Platform.Message<PurchaseList> msg)
	{
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0xF1C220", Offset = "0xF1C220", VA = "0xF1C220")]
	public void BuyPowerBallsPressed()
	{
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0xF1C75C", Offset = "0xF1C75C", VA = "0xF1C75C")]
	private void LaunchCheckoutFlowCallback(Oculus.Platform.Message<Purchase> msg)
	{
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0xF1C8BC", Offset = "0xF1C8BC", VA = "0xF1C8BC")]
	public IAPManager()
	{
	}
}
[Token(Token = "0x20000DB")]
public class OculusPlatform : IPlatform
{
	[Token(Token = "0x600045D")]
	[Address(RVA = "0xF21DD0", Offset = "0xF21DD0", VA = "0xF21DD0", Slot = "4")]
	public override void InitSdk(SDKData sdkData)
	{
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0xF2200C", Offset = "0xF2200C", VA = "0xF2200C")]
	private void Initialize(Oculus.Platform.Message msg)
	{
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0xF222C8", Offset = "0xF222C8", VA = "0xF222C8")]
	private void EntitlementCheckCallback(Oculus.Platform.Message msg)
	{
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0xF223F0", Offset = "0xF223F0", VA = "0xF223F0")]
	public void GetPlatformUser()
	{
	}

	[Token(Token = "0x6000461")]
	[Address(RVA = "0xF2250C", Offset = "0xF2250C", VA = "0xF2250C")]
	private void GetLoggedInUserCallback(Oculus.Platform.Message msg)
	{
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0xF22198", Offset = "0xF22198", VA = "0xF22198")]
	private void OnErrmsg(int code)
	{
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0xF227AC", Offset = "0xF227AC", VA = "0xF227AC")]
	public OculusPlatform()
	{
	}
}
[Token(Token = "0x20000DC")]
public class PicoPlatform : IPlatform
{
	[Token(Token = "0x6000464")]
	[Address(RVA = "0xF22B0C", Offset = "0xF22B0C", VA = "0xF22B0C", Slot = "4")]
	public override void InitSdk(SDKData sdkData)
	{
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0xF22D40", Offset = "0xF22D40", VA = "0xF22D40")]
	public void SdkInitComplete(Pico.Platform.Message<Pico.Platform.PlatformInitializeResult> msg)
	{
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0xF22FC8", Offset = "0xF22FC8", VA = "0xF22FC8")]
	public void GetLoginUser()
	{
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0xF23090", Offset = "0xF23090", VA = "0xF23090")]
	public void OnLoinUser(Pico.Platform.Message<Pico.Platform.Models.User> msg)
	{
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0xF22E98", Offset = "0xF22E98", VA = "0xF22E98")]
	private void OnErrmsg(int code)
	{
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0xF232FC", Offset = "0xF232FC", VA = "0xF232FC")]
	public PicoPlatform()
	{
	}
}
namespace Eden.SceneManagerSystem
{
	[Token(Token = "0x20000DD")]
	public enum LoadingType
	{
		[Token(Token = "0x4000311")]
		progress,
		[Token(Token = "0x4000312")]
		cameraAnim
	}
	[Token(Token = "0x20000DE")]
	public class SceneMgr : MonoBehaviour
	{
		[Token(Token = "0x20000DF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C304", Offset = "0x73C304")]
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
				[Token(Token = "0x6000484")]
				[Address(RVA = "0x1068600", Offset = "0x1068600", VA = "0x1068600", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000486")]
				[Address(RVA = "0x1068648", Offset = "0x1068648", VA = "0x1068648", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000481")]
			[Address(RVA = "0x106825C", Offset = "0x106825C", VA = "0x106825C")]
			[DebuggerHidden]
			public <LoadSceneAsync>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x6000482")]
			[Address(RVA = "0x1068288", Offset = "0x1068288", VA = "0x1068288", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000483")]
			[Address(RVA = "0x106828C", Offset = "0x106828C", VA = "0x106828C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000485")]
			[Address(RVA = "0x1068608", Offset = "0x1068608", VA = "0x1068608", Slot = "8")]
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
			[Token(Token = "0x600046A")]
			[Address(RVA = "0xF1F490", Offset = "0xF1F490", VA = "0xF1F490")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		public SceneType curSceneType
		{
			[Token(Token = "0x600046B")]
			[Address(RVA = "0xF24BE4", Offset = "0xF24BE4", VA = "0xF24BE4")]
			get
			{
				return default(SceneType);
			}
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xF2C0E0", Offset = "0xF2C0E0", VA = "0xF2C0E0")]
		public void Init(Action callBack)
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xF2C2D8", Offset = "0xF2C2D8", VA = "0xF2C2D8")]
		private void OnLoadingLoaded()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xF2C688", Offset = "0xF2C688", VA = "0xF2C688")]
		private void SetCameraClearFlags(CameraClearFlags cameraClearFlags)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xF2C7B8", Offset = "0xF2C7B8", VA = "0xF2C7B8")]
		private void OpenLoading()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xF2C880", Offset = "0xF2C880", VA = "0xF2C880")]
		private void CloseLoading()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xF2C948", Offset = "0xF2C948", VA = "0xF2C948")]
		private void UpdateLoading(float progress)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xF2C978", Offset = "0xF2C978", VA = "0xF2C978")]
		public static void ResetPlayerPos([Optional] string sceneName)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xF2CC08", Offset = "0xF2CC08", VA = "0xF2CC08")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73D6A0", Offset = "0x73D6A0")]
		private IEnumerator LoadSceneAsync()
		{
			return null;
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xF2CC80", Offset = "0xF2CC80", VA = "0xF2CC80")]
		private void LoadSceneAsyncAnimEvent()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xF2CCC0", Offset = "0xF2CCC0", VA = "0xF2CCC0")]
		private void _LoadSceneAsync()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xF2CE1C", Offset = "0xF2CE1C", VA = "0xF2CE1C")]
		private void SceneLoadSuccess()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xF2CF08", Offset = "0xF2CF08", VA = "0xF2CF08")]
		private void OnSceneInitSuccess(object parm)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xF2CF0C", Offset = "0xF2CF0C", VA = "0xF2CF0C")]
		private void OnAnimOpend()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xF2CF10", Offset = "0xF2CF10", VA = "0xF2CF10")]
		private void OnAnimClosed()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xF2CF68", Offset = "0xF2CF68", VA = "0xF2CF68")]
		private void InitAnimEvent()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xF2CF6C", Offset = "0xF2CF6C", VA = "0xF2CF6C")]
		private void SetActionAnimEvent(string clipName, Action action)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xF1F66C", Offset = "0xF1F66C", VA = "0xF1F66C")]
		public void LoadSceneAsync(string sceneName, [Optional] Action onSceneLoaded, SceneType sceneType = SceneType.None, [Optional] SceneData sceneData, [Optional] Action onSceneLoadedAnimPlayed)
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xF2CF70", Offset = "0xF2CF70", VA = "0xF2CF70")]
		public void LoadSceneSync(string sceneName, [Optional] Action onSceneLoaded, SceneType sceneType = SceneType.None)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xF2D0F8", Offset = "0xF2D0F8", VA = "0xF2D0F8")]
		public void LoadMainScene([Optional] Action onSceneLoaded)
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xF2D218", Offset = "0xF2D218", VA = "0xF2D218")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xF2D27C", Offset = "0xF2D27C", VA = "0xF2D27C")]
		public SceneMgr()
		{
		}
	}
	[Token(Token = "0x20000E0")]
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
	[Token(Token = "0x20000E1")]
	public abstract class SceneTypeBase
	{
		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SceneData sceneData;

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xE58244", Offset = "0xE58244", VA = "0xE58244", Slot = "4")]
		public virtual bool NeedRegisterSceneData()
		{
			return default(bool);
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xE5824C", Offset = "0xE5824C", VA = "0xE5824C", Slot = "5")]
		public virtual void LoadSceneBefore()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xE58438", Offset = "0xE58438", VA = "0xE58438", Slot = "6")]
		public virtual void LoadSceneIng()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xE5843C", Offset = "0xE5843C", VA = "0xE5843C", Slot = "7")]
		public virtual void LoadSceneAfter()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xE584FC", Offset = "0xE584FC", VA = "0xE584FC", Slot = "8")]
		public virtual void LoadSceneAfterAnim()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xE58584", Offset = "0xE58584", VA = "0xE58584", Slot = "9")]
		public virtual void UnloadScene()
		{
		}

		[Token(Token = "0x600048D")]
		public abstract SceneType GetSceneType();

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xE587D0", Offset = "0xE587D0", VA = "0xE587D0")]
		protected SceneTypeBase()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class SceneTypeBook : SceneTypeBase
	{
		[Token(Token = "0x600048F")]
		[Address(RVA = "0xE587D8", Offset = "0xE587D8", VA = "0xE587D8", Slot = "5")]
		public override void LoadSceneBefore()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xE587DC", Offset = "0xE587DC", VA = "0xE587DC", Slot = "6")]
		public override void LoadSceneIng()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xE587E0", Offset = "0xE587E0", VA = "0xE587E0", Slot = "7")]
		public override void LoadSceneAfter()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xE587E4", Offset = "0xE587E4", VA = "0xE587E4", Slot = "9")]
		public override void UnloadScene()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xE587E8", Offset = "0xE587E8", VA = "0xE587E8", Slot = "10")]
		public override SceneType GetSceneType()
		{
			return default(SceneType);
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xE587F0", Offset = "0xE587F0", VA = "0xE587F0")]
		public SceneTypeBook()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public class SceneTypeGame : SceneTypeBase
	{
		[Token(Token = "0x6000495")]
		[Address(RVA = "0xE587F8", Offset = "0xE587F8", VA = "0xE587F8", Slot = "5")]
		public override void LoadSceneBefore()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xE587FC", Offset = "0xE587FC", VA = "0xE587FC", Slot = "4")]
		public override bool NeedRegisterSceneData()
		{
			return default(bool);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xE58804", Offset = "0xE58804", VA = "0xE58804", Slot = "6")]
		public override void LoadSceneIng()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xE58808", Offset = "0xE58808", VA = "0xE58808", Slot = "7")]
		public override void LoadSceneAfter()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xE588A8", Offset = "0xE588A8", VA = "0xE588A8", Slot = "9")]
		public override void UnloadScene()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xE58A6C", Offset = "0xE58A6C", VA = "0xE58A6C", Slot = "10")]
		public override SceneType GetSceneType()
		{
			return default(SceneType);
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xE58A74", Offset = "0xE58A74", VA = "0xE58A74")]
		public SceneTypeGame()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class SceneTypeGuide : SceneTypeBase
	{
		[Token(Token = "0x600049C")]
		[Address(RVA = "0xE58A7C", Offset = "0xE58A7C", VA = "0xE58A7C", Slot = "5")]
		public override void LoadSceneBefore()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xE58A80", Offset = "0xE58A80", VA = "0xE58A80", Slot = "6")]
		public override void LoadSceneIng()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xE58A84", Offset = "0xE58A84", VA = "0xE58A84", Slot = "7")]
		public override void LoadSceneAfter()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xE58A90", Offset = "0xE58A90", VA = "0xE58A90", Slot = "9")]
		public override void UnloadScene()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xE58A94", Offset = "0xE58A94", VA = "0xE58A94", Slot = "10")]
		public override SceneType GetSceneType()
		{
			return default(SceneType);
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xE58A9C", Offset = "0xE58A9C", VA = "0xE58A9C")]
		public SceneTypeGuide()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class SceneTypeTheme : SceneTypeBase
	{
		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int? _lookAt;

		[Token(Token = "0x1700008F")]
		public static int? lookAt
		{
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0xE58B0C", Offset = "0xE58B0C", VA = "0xE58B0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0xE58AA4", Offset = "0xE58AA4", VA = "0xE58AA4")]
			set
			{
			}
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xE58B74", Offset = "0xE58B74", VA = "0xE58B74", Slot = "5")]
		public override void LoadSceneBefore()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xE58B78", Offset = "0xE58B78", VA = "0xE58B78", Slot = "4")]
		public override bool NeedRegisterSceneData()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xE58B80", Offset = "0xE58B80", VA = "0xE58B80", Slot = "6")]
		public override void LoadSceneIng()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xE58B84", Offset = "0xE58B84", VA = "0xE58B84", Slot = "7")]
		public override void LoadSceneAfter()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xE58EDC", Offset = "0xE58EDC", VA = "0xE58EDC", Slot = "9")]
		public override void UnloadScene()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xE58EE0", Offset = "0xE58EE0", VA = "0xE58EE0", Slot = "10")]
		public override SceneType GetSceneType()
		{
			return default(SceneType);
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xE58EE8", Offset = "0xE58EE8", VA = "0xE58EE8")]
		public SceneTypeTheme()
		{
		}
	}
}
namespace Game.UI.Book
{
	[Token(Token = "0x20000E6")]
	public class Back2BookScene : MonoBehaviour
	{
		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly string _bookSceneName;

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xEFF444", Offset = "0xEFF444", VA = "0xEFF444")]
		public void Back2Book()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xEFF48C", Offset = "0xEFF48C", VA = "0xEFF48C")]
		public Back2BookScene()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class BookManager : MonoBehaviour
	{
		[Token(Token = "0x20000E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C314", Offset = "0x73C314")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x4000341")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UnityAction cb;

			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x10625A8", Offset = "0x10625A8", VA = "0x10625A8")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x10625B0", Offset = "0x10625B0", VA = "0x10625B0")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73CA88", Offset = "0x73CA88")]
		public float bookFadeTime;

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xF00CE8", Offset = "0xF00CE8", VA = "0xF00CE8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xF01100", Offset = "0xF01100", VA = "0xF01100")]
		public void PreLoad()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xF011BC", Offset = "0xF011BC", VA = "0xF011BC")]
		public void BuildTestData()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xF00FA0", Offset = "0xF00FA0", VA = "0xF00FA0")]
		public void ShowCanvas(bool show = true, float time = 1f, [Optional] UnityAction cb)
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xF012C0", Offset = "0xF012C0", VA = "0xF012C0")]
		private void CheckGuideTextShow()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xF0153C", Offset = "0xF0153C", VA = "0xF0153C")]
		private void CloseGuideTextGo()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xF01620", Offset = "0xF01620", VA = "0xF01620")]
		private void OnEnterStage(object data)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xF01784", Offset = "0xF01784", VA = "0xF01784")]
		private void EnterTheme()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xF0182C", Offset = "0xF0182C", VA = "0xF0182C")]
		private void OnStageGroupInfoClosed()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xF018B4", Offset = "0xF018B4", VA = "0xF018B4")]
		private void OnCellViewSelected(int stageGroupId)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xF01380", Offset = "0xF01380", VA = "0xF01380")]
		private int GetMaxThemeIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xF01378", Offset = "0xF01378", VA = "0xF01378")]
		private int GetCurrentThemeIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xF014A4", Offset = "0xF014A4", VA = "0xF014A4")]
		private void ShowTheme(int themeIndex)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xF0196C", Offset = "0xF0196C", VA = "0xF0196C")]
		private bool CheckDoorShow(int themeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xF01954", Offset = "0xF01954", VA = "0xF01954")]
		private void ShowRightPage(int themeIndex)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xF018B8", Offset = "0xF018B8", VA = "0xF018B8")]
		private void ShowLeftPage(int themeIndex)
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xF02394", Offset = "0xF02394", VA = "0xF02394")]
		private void ShowPreviousTheme()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xF0247C", Offset = "0xF0247C", VA = "0xF0247C")]
		private void ShowNextTheme()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xF01438", Offset = "0xF01438", VA = "0xF01438")]
		private void CheckLeftAndRightBtn()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xF01854", Offset = "0xF01854", VA = "0xF01854")]
		private void SetLeftAndRightBtn(bool show)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xF02564", Offset = "0xF02564", VA = "0xF02564")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xF026BC", Offset = "0xF026BC", VA = "0xF026BC")]
		public BookManager()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xF026CC", Offset = "0xF026CC", VA = "0xF026CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D750", Offset = "0x73D750")]
		private void <ShowPreviousTheme>b__27_0()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xF02768", Offset = "0xF02768", VA = "0xF02768")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D760", Offset = "0x73D760")]
		private void <ShowPreviousTheme>b__27_1()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xF02770", Offset = "0xF02770", VA = "0xF02770")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D770", Offset = "0x73D770")]
		private void <ShowNextTheme>b__28_0()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xF0280C", Offset = "0xF0280C", VA = "0xF0280C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D780", Offset = "0x73D780")]
		private void <ShowNextTheme>b__28_1()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public delegate void SelectedDelegate(RowCellView rowCellView);
	[Token(Token = "0x20000EA")]
	public class CellView : EnhancedScrollerCellView
	{
		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RowCellView[] rowCellViews;

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xF0385C", Offset = "0xF0385C", VA = "0xF0385C")]
		public void SetData(ref SmallList<Data> data, int startingIndex, SelectedDelegate selected)
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xF03958", Offset = "0xF03958", VA = "0xF03958")]
		public CellView()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class Controller : MonoBehaviour, IEnhancedScrollerDelegate
	{
		[Token(Token = "0x20000EC")]
		public delegate void OnCellViewSelected(int stageGroupId);

		[Serializable]
		[Token(Token = "0x20000ED")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C324", Offset = "0x73C324")]
		private sealed class <>c
		{
			[Token(Token = "0x4000348")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000349")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Comparison<StageGroupCfg> <>9__7_0;

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x1062704", Offset = "0x1062704", VA = "0x1062704")]
			public <>c()
			{
			}

			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x106270C", Offset = "0x106270C", VA = "0x106270C")]
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

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xF05A30", Offset = "0xF05A30", VA = "0xF05A30")]
		private void Start()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xF01E88", Offset = "0xF01E88", VA = "0xF01E88")]
		public void LoadData(int themeIndex)
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xF05EA8", Offset = "0xF05EA8", VA = "0xF05EA8")]
		public static int GetMaxProgressStageId(int sgcId)
		{
			return default(int);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xF05A50", Offset = "0xF05A50", VA = "0xF05A50")]
		public static float GetStageGroupMaxProgress(int sgcId)
		{
			return default(float);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xF06320", Offset = "0xF06320", VA = "0xF06320")]
		private void CellViewSelected(RowCellView cellView)
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xF0642C", Offset = "0xF0642C", VA = "0xF0642C")]
		private void OnSelectItem(int stageId)
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xF06440", Offset = "0xF06440", VA = "0xF06440", Slot = "4")]
		public int GetNumberOfCells(EnhancedScroller scroller)
		{
			return default(int);
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xF06470", Offset = "0xF06470", VA = "0xF06470", Slot = "5")]
		public float GetCellViewSize(EnhancedScroller scroller, int dataIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xF0647C", Offset = "0xF0647C", VA = "0xF0647C", Slot = "6")]
		public EnhancedScrollerCellView GetCellView(EnhancedScroller scroller, int dataIndex, int cellIndex)
		{
			return null;
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xF06624", Offset = "0xF06624", VA = "0xF06624")]
		public Controller()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public delegate void SelectedChangedDelegate(bool val);
	[Token(Token = "0x20000EF")]
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
			[Token(Token = "0x60004E6")]
			[Address(RVA = "0xF14158", Offset = "0xF14158", VA = "0xF14158")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0xF14160", Offset = "0xF14160", VA = "0xF14160")]
			set
			{
			}
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xF14130", Offset = "0xF14130", VA = "0xF14130")]
		public Data()
		{
		}
	}
	[Token(Token = "0x20000F0")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CAC0", Offset = "0x73CAC0")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73CAD0", Offset = "0x73CAD0")]
		public float selectZ;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x73CB08", Offset = "0x73CB08")]
		public float zTime;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private bool _isSelect;

		[Token(Token = "0x17000091")]
		public int DataIndex
		{
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0xF2B14C", Offset = "0xF2B14C", VA = "0xF2B14C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D790", Offset = "0x73D790")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0xF2B154", Offset = "0xF2B154", VA = "0xF2B154")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D7A0", Offset = "0x73D7A0")]
			private set
			{
			}
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xF2B15C", Offset = "0xF2B15C", VA = "0xF2B15C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xF2B21C", Offset = "0xF2B21C", VA = "0xF2B21C")]
		private void ShowSelectEffect(bool show)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xF2B3E4", Offset = "0xF2B3E4", VA = "0xF2B3E4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xF2B4C4", Offset = "0xF2B4C4", VA = "0xF2B4C4")]
		public void SetData(int dataIndex, Data data, SelectedDelegate selected)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xF2B9B0", Offset = "0xF2B9B0", VA = "0xF2B9B0")]
		private void SetContainerPos(int dataIndex)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xF2BA90", Offset = "0xF2BA90", VA = "0xF2BA90")]
		private void SelectedChanged(bool selected)
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xF2B31C", Offset = "0xF2B31C", VA = "0xF2B31C")]
		public void OnSelected()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xF2BAF8", Offset = "0xF2BAF8", VA = "0xF2BAF8")]
		public RowCellView()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class StageDiffcultyController : MonoBehaviour, IEnhancedScrollerDelegate
	{
		[Token(Token = "0x20000F2")]
		public delegate void OnDifficultyCellViewSelected(StageDifficultyCellView cellView);

		[Serializable]
		[Token(Token = "0x20000F3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C334", Offset = "0x73C334")]
		private sealed class <>c
		{
			[Token(Token = "0x4000372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Comparison<int> <>9__7_0;

			[Token(Token = "0x6000502")]
			[Address(RVA = "0x1069364", Offset = "0x1069364", VA = "0x1069364")]
			public <>c()
			{
			}

			[Token(Token = "0x6000503")]
			[Address(RVA = "0x106936C", Offset = "0x106936C", VA = "0x106936C")]
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

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xE5C288", Offset = "0xE5C288", VA = "0xE5C288")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xE5C2A8", Offset = "0xE5C2A8", VA = "0xE5C2A8")]
		public void LoadData(int stageGroupId)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xE5C898", Offset = "0xE5C898", VA = "0xE5C898")]
		private string GetStarLevelText(int stageDataStarCount)
		{
			return null;
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xE5CBB0", Offset = "0xE5CBB0", VA = "0xE5CBB0")]
		public void SelectFirstItem()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xE5C920", Offset = "0xE5C920", VA = "0xE5C920")]
		private float GetStageProgress(int stage)
		{
			return default(float);
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xE5CE20", Offset = "0xE5CE20", VA = "0xE5CE20")]
		private void CellViewSelected(StageDifficultyCellView cellView)
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xE5CF8C", Offset = "0xE5CF8C", VA = "0xE5CF8C")]
		private void OnSelectItem(StageDifficultyCellView cellView)
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xE5CFA0", Offset = "0xE5CFA0", VA = "0xE5CFA0", Slot = "4")]
		public int GetNumberOfCells(EnhancedScroller scroller)
		{
			return default(int);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xE5CFD0", Offset = "0xE5CFD0", VA = "0xE5CFD0", Slot = "5")]
		public float GetCellViewSize(EnhancedScroller scroller, int dataIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xE5CFD8", Offset = "0xE5CFD8", VA = "0xE5CFD8", Slot = "6")]
		public EnhancedScrollerCellView GetCellView(EnhancedScroller scroller, int dataIndex, int cellIndex)
		{
			return null;
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xE5D428", Offset = "0xE5D428", VA = "0xE5D428")]
		public StageDiffcultyController()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public delegate void DifficultySelectedDelegate(StageDifficultyCellView view);
	[Token(Token = "0x20000F5")]
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

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xE5D438", Offset = "0xE5D438", VA = "0xE5D438")]
		private void Start()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xE5D43C", Offset = "0xE5D43C", VA = "0xE5D43C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xE5CC94", Offset = "0xE5CC94", VA = "0xE5CC94")]
		public void OnClickBtn()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xE5D1A4", Offset = "0xE5D1A4", VA = "0xE5D1A4")]
		public void SetData(StageDifficultyData data, DifficultySelectedDelegate selectedDelegate)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xE5D944", Offset = "0xE5D944", VA = "0xE5D944")]
		private void SelectedChanged(bool selected)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xE5D9D0", Offset = "0xE5D9D0", VA = "0xE5D9D0")]
		public void OnPointEnter()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xE5D958", Offset = "0xE5D958", VA = "0xE5D958")]
		public void OnPointExit()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xE5DA48", Offset = "0xE5DA48", VA = "0xE5DA48")]
		public void OnPointClick()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xE5DA4C", Offset = "0xE5DA4C", VA = "0xE5DA4C")]
		public StageDifficultyCellView()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public delegate void SelectedDifficultyChangedDelegate(bool val);
	[Token(Token = "0x20000F7")]
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
			[Token(Token = "0x6000515")]
			[Address(RVA = "0xE5DA54", Offset = "0xE5DA54", VA = "0xE5DA54")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000516")]
			[Address(RVA = "0xE5CF5C", Offset = "0xE5CF5C", VA = "0xE5CF5C")]
			set
			{
			}
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xE5C890", Offset = "0xE5C890", VA = "0xE5C890")]
		public StageDifficultyData()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class StageGroupInfo : MonoBehaviour
	{
		[Token(Token = "0x20000F9")]
		public delegate void OnStageGroupInfoClosed();

		[Token(Token = "0x20000FA")]
		public delegate void OnEnterStage(int stageId);

		[Token(Token = "0x20000FB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C344", Offset = "0x73C344")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SceneData sceneData;

			[Token(Token = "0x600052A")]
			[Address(RVA = "0x106972C", Offset = "0x106972C", VA = "0x106972C")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x600052B")]
			[Address(RVA = "0x1069734", Offset = "0x1069734", VA = "0x1069734")]
			internal void <OnStartGame>b__0()
			{
			}
		}

		[Token(Token = "0x20000FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C354", Offset = "0x73C354")]
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
				[Token(Token = "0x600052F")]
				[Address(RVA = "0x1069950", Offset = "0x1069950", VA = "0x1069950", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000094")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000531")]
				[Address(RVA = "0x1069998", Offset = "0x1069998", VA = "0x1069998", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600052C")]
			[Address(RVA = "0x10698A8", Offset = "0x10698A8", VA = "0x10698A8")]
			[DebuggerHidden]
			public <SelectFirstItem>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x600052D")]
			[Address(RVA = "0x10698D4", Offset = "0x10698D4", VA = "0x10698D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600052E")]
			[Address(RVA = "0x10698D8", Offset = "0x10698D8", VA = "0x10698D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000530")]
			[Address(RVA = "0x1069958", Offset = "0x1069958", VA = "0x1069958", Slot = "8")]
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

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xE5E1F0", Offset = "0xE5E1F0", VA = "0xE5E1F0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xE5E294", Offset = "0xE5E294", VA = "0xE5E294")]
		private void OnStartGame()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xE5E7AC", Offset = "0xE5E7AC", VA = "0xE5E7AC")]
		private void OnClickBackBtn()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xE5E7C0", Offset = "0xE5E7C0", VA = "0xE5E7C0")]
		public void InitShow(int stageGroupId)
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xE5E918", Offset = "0xE5E918", VA = "0xE5E918")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73D7B0", Offset = "0x73D7B0")]
		private IEnumerator SelectFirstItem()
		{
			return null;
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xE5E990", Offset = "0xE5E990", VA = "0xE5E990")]
		private void OnCellViewSelected(StageDifficultyCellView cellView)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xE5E9B0", Offset = "0xE5E9B0", VA = "0xE5E9B0")]
		private void SetStartBtnText(float cellViewStageProgress)
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xE5EA0C", Offset = "0xE5EA0C", VA = "0xE5EA0C")]
		private int GetStartBtnText(float cellViewStageProgress)
		{
			return default(int);
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xE5EA48", Offset = "0xE5EA48", VA = "0xE5EA48")]
		public void Deinit()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xE5EB18", Offset = "0xE5EB18", VA = "0xE5EB18")]
		public StageGroupInfo()
		{
		}
	}
}
namespace UnityEngine.XR.Interaction.Toolkit
{
	[Token(Token = "0x20000FD")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73CB50", Offset = "0x73CB50")]
		[SerializeField]
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
			[Token(Token = "0x6000532")]
			[Address(RVA = "0xF264C0", Offset = "0xF264C0", VA = "0xF264C0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000533")]
			[Address(RVA = "0xF264C8", Offset = "0xF264C8", VA = "0xF264C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public bool overrideInteractorLineLength
		{
			[Token(Token = "0x6000534")]
			[Address(RVA = "0xF264D8", Offset = "0xF264D8", VA = "0xF264D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000535")]
			[Address(RVA = "0xF264E0", Offset = "0xF264E0", VA = "0xF264E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public float lineLength
		{
			[Token(Token = "0x6000536")]
			[Address(RVA = "0xF264EC", Offset = "0xF264EC", VA = "0xF264EC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000537")]
			[Address(RVA = "0xF264F4", Offset = "0xF264F4", VA = "0xF264F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public AnimationCurve widthCurve
		{
			[Token(Token = "0x6000538")]
			[Address(RVA = "0xF264FC", Offset = "0xF264FC", VA = "0xF264FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000539")]
			[Address(RVA = "0xF26504", Offset = "0xF26504", VA = "0xF26504")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public Gradient validColorGradient
		{
			[Token(Token = "0x600053A")]
			[Address(RVA = "0xF26534", Offset = "0xF26534", VA = "0xF26534")]
			get
			{
				return null;
			}
			[Token(Token = "0x600053B")]
			[Address(RVA = "0xF2653C", Offset = "0xF2653C", VA = "0xF2653C")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public Gradient invalidColorGradient
		{
			[Token(Token = "0x600053C")]
			[Address(RVA = "0xF26544", Offset = "0xF26544", VA = "0xF26544")]
			get
			{
				return null;
			}
			[Token(Token = "0x600053D")]
			[Address(RVA = "0xF2654C", Offset = "0xF2654C", VA = "0xF2654C")]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public bool smoothMovement
		{
			[Token(Token = "0x600053E")]
			[Address(RVA = "0xF26554", Offset = "0xF26554", VA = "0xF26554")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600053F")]
			[Address(RVA = "0xF2655C", Offset = "0xF2655C", VA = "0xF2655C")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public float followTightness
		{
			[Token(Token = "0x6000540")]
			[Address(RVA = "0xF26568", Offset = "0xF26568", VA = "0xF26568")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000541")]
			[Address(RVA = "0xF26570", Offset = "0xF26570", VA = "0xF26570")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public float snapThresholdDistance
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0xF26578", Offset = "0xF26578", VA = "0xF26578")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000543")]
			[Address(RVA = "0xF26580", Offset = "0xF26580", VA = "0xF26580")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public GameObject reticle
		{
			[Token(Token = "0x6000544")]
			[Address(RVA = "0xF26588", Offset = "0xF26588", VA = "0xF26588")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000545")]
			[Address(RVA = "0xF26590", Offset = "0xF26590", VA = "0xF26590")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public bool stopLineAtFirstRaycastHit
		{
			[Token(Token = "0x6000546")]
			[Address(RVA = "0xF26598", Offset = "0xF26598", VA = "0xF26598")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000547")]
			[Address(RVA = "0xF265A0", Offset = "0xF265A0", VA = "0xF265A0")]
			set
			{
			}
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xF265AC", Offset = "0xF265AC", VA = "0xF265AC")]
		protected void Reset()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xF265B0", Offset = "0xF265B0", VA = "0xF265B0")]
		protected void OnValidate()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xF2665C", Offset = "0xF2665C", VA = "0xF2665C")]
		protected void Awake()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xF267CC", Offset = "0xF267CC", VA = "0xF267CC")]
		protected void OnEnable()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xF26860", Offset = "0xF26860", VA = "0xF26860")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xF26774", Offset = "0xF26774", VA = "0xF26774")]
		private void ClearLineRenderer()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xF26AA4", Offset = "0xF26AA4", VA = "0xF26AA4")]
		[AttributeAttribute(Name = "BeforeRenderOrderAttribute", RVA = "0x73D860", Offset = "0x73D860")]
		private void OnBeforeRenderLineVisual()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xF26AA8", Offset = "0xF26AA8", VA = "0xF26AA8")]
		private void UpdateLineVisual()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xF265E8", Offset = "0xF265E8", VA = "0xF265E8")]
		private void UpdateSettings()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xF26994", Offset = "0xF26994", VA = "0xF26994")]
		private bool TryFindLineRenderer()
		{
			return default(bool);
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xF27650", Offset = "0xF27650", VA = "0xF27650")]
		public bool AttachCustomReticle(GameObject reticleInstance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xF277A0", Offset = "0xF277A0", VA = "0xF277A0")]
		public bool RemoveCustomReticle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xF27520", Offset = "0xF27520", VA = "0xF27520")]
		public Vector3[] getLineAtPoint(Vector3 start, Vector3 end)
		{
			return null;
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xF274E0", Offset = "0xF274E0", VA = "0xF274E0")]
		private Vector3 GetReticleScale(Vector3 start, Vector3 end)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xF27894", Offset = "0xF27894", VA = "0xF27894")]
		public void SetGradient(float value)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xF27898", Offset = "0xF27898", VA = "0xF27898")]
		public RayLine()
		{
		}
	}
}
namespace Framework
{
	[Token(Token = "0x20000FE")]
	public static class Url
	{
		[Token(Token = "0x6000558")]
		[Address(RVA = "0xE6CB44", Offset = "0xE6CB44", VA = "0xE6CB44")]
		public static bool IsUrl(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xE6CC44", Offset = "0xE6CC44", VA = "0xE6CC44")]
		public static string StringToMd5(string input)
		{
			return null;
		}
	}
}
namespace CoreFrameWork
{
	[Token(Token = "0x20000FF")]
	public class LogUtil
	{
		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string _tag;

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xF1F83C", Offset = "0xF1F83C", VA = "0xF1F83C")]
		public static void Init(string tag)
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xF1A5C8", Offset = "0xF1A5C8", VA = "0xF1A5C8")]
		public static void Log(string message)
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xF1F8A8", Offset = "0xF1F8A8", VA = "0xF1F8A8")]
		public static void Warn(string message)
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xF1F970", Offset = "0xF1F970", VA = "0xF1F970")]
		public LogUtil()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class XRConfigs : MonoBehaviour
	{
		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float eyeTextureResolutionScale;

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xE6E1E0", Offset = "0xE6E1E0", VA = "0xE6E1E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xE6E274", Offset = "0xE6E274", VA = "0xE6E274")]
		private void Start()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xE6E278", Offset = "0xE6E278", VA = "0xE6E278")]
		private void Update()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xE6E27C", Offset = "0xE6E27C", VA = "0xE6E27C")]
		public XRConfigs()
		{
		}
	}
}
namespace ZYB.SDK
{
	[Token(Token = "0x2000101")]
	public abstract class IPlatform
	{
		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isInit;

		[Token(Token = "0x6000563")]
		public abstract void InitSdk(SDKData sdkData);

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xF1605C", Offset = "0xF1605C", VA = "0xF1605C", Slot = "5")]
		public virtual void SetUserId(string userId)
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xF1684C", Offset = "0xF1684C", VA = "0xF1684C", Slot = "6")]
		public virtual void SendState(string eventName, Dictionary<string, string> extraInfos)
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xF160DC", Offset = "0xF160DC", VA = "0xF160DC", Slot = "7")]
		public virtual void SendState(string name, string parameterName, string parameterValue)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xF16858", Offset = "0xF16858", VA = "0xF16858")]
		protected IPlatform()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class SDKManager
	{
		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<string, IPlatform> XRSdkImpl;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<string, IPlatform> AnalyticsSdk;

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xF2BBA4", Offset = "0xF2BBA4", VA = "0xF2BBA4")]
		public static void InitSDK(SDKPlatform config)
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xF2BEE4", Offset = "0xF2BEE4", VA = "0xF2BEE4")]
		public static Dictionary<string, IPlatform> GetAnalyticsSdk()
		{
			return null;
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xF2BF48", Offset = "0xF2BF48", VA = "0xF2BF48")]
		public SDKManager()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class SDKData
	{
		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CC38", Offset = "0x73CC38")]
		private string <SDK_Type>k__BackingField;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CC48", Offset = "0x73CC48")]
		private string <PlatformType>k__BackingField;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CC58", Offset = "0x73CC58")]
		private string <APP_KEY>k__BackingField;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CC68", Offset = "0x73CC68")]
		private string <RefClassName>k__BackingField;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CC78", Offset = "0x73CC78")]
		private object <Other>k__BackingField;

		[Token(Token = "0x170000A0")]
		public string SDK_Type
		{
			[Token(Token = "0x600056C")]
			[Address(RVA = "0xF2BB4C", Offset = "0xF2BB4C", VA = "0xF2BB4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D884", Offset = "0x73D884")]
			get
			{
				return null;
			}
			[Token(Token = "0x600056D")]
			[Address(RVA = "0xF2BB54", Offset = "0xF2BB54", VA = "0xF2BB54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D894", Offset = "0x73D894")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public string PlatformType
		{
			[Token(Token = "0x600056E")]
			[Address(RVA = "0xF2BB5C", Offset = "0xF2BB5C", VA = "0xF2BB5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D8A4", Offset = "0x73D8A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600056F")]
			[Address(RVA = "0xF2BB64", Offset = "0xF2BB64", VA = "0xF2BB64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D8B4", Offset = "0x73D8B4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public string APP_KEY
		{
			[Token(Token = "0x6000570")]
			[Address(RVA = "0xF2BB6C", Offset = "0xF2BB6C", VA = "0xF2BB6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D8C4", Offset = "0x73D8C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000571")]
			[Address(RVA = "0xF2BB74", Offset = "0xF2BB74", VA = "0xF2BB74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D8D4", Offset = "0x73D8D4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public string RefClassName
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0xF2BB7C", Offset = "0xF2BB7C", VA = "0xF2BB7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D8E4", Offset = "0x73D8E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000573")]
			[Address(RVA = "0xF2BB84", Offset = "0xF2BB84", VA = "0xF2BB84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D8F4", Offset = "0x73D8F4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public object Other
		{
			[Token(Token = "0x6000574")]
			[Address(RVA = "0xF2BB8C", Offset = "0xF2BB8C", VA = "0xF2BB8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D904", Offset = "0x73D904")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000575")]
			[Address(RVA = "0xF2BB94", Offset = "0xF2BB94", VA = "0xF2BB94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D914", Offset = "0x73D914")]
			set
			{
			}
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xF2BB9C", Offset = "0xF2BB9C", VA = "0xF2BB9C")]
		public SDKData()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class SDKPlatform
	{
		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73CC88", Offset = "0x73CC88")]
		private SDKData[] <platform>k__BackingField;

		[Token(Token = "0x170000A5")]
		public SDKData[] platform
		{
			[Token(Token = "0x6000577")]
			[Address(RVA = "0xF2C00C", Offset = "0xF2C00C", VA = "0xF2C00C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D924", Offset = "0x73D924")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000578")]
			[Address(RVA = "0xF2C014", Offset = "0xF2C014", VA = "0xF2C014")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D934", Offset = "0x73D934")]
			set
			{
			}
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xF2C01C", Offset = "0xF2C01C", VA = "0xF2C01C")]
		public SDKPlatform()
		{
		}
	}
	[Token(Token = "0x2000105")]
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

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xF227A4", Offset = "0xF227A4", VA = "0xF227A4")]
		public PlatformLoginData()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class StatsManager
	{
		[Token(Token = "0x600057B")]
		[Address(RVA = "0xE60364", Offset = "0xE60364", VA = "0xE60364")]
		public static void SetUserInfo()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xE60580", Offset = "0xE60580", VA = "0xE60580")]
		public static void Send(string eventKey)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xE5D528", Offset = "0xE5D528", VA = "0xE5D528")]
		public static void Send(string eventKey, Dictionary<string, string> extraInfos)
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xE605F4", Offset = "0xE605F4", VA = "0xE605F4")]
		public static long GetTimeStamp()
		{
			return default(long);
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xE60700", Offset = "0xE60700", VA = "0xE60700")]
		public StatsManager()
		{
		}
	}
}
namespace ZYB.Utils
{
	[Token(Token = "0x2000107")]
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
			[Token(Token = "0x6000580")]
			[Address(RVA = "0xF1DCAC", Offset = "0xF1DCAC", VA = "0xF1DCAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000581")]
			[Address(RVA = "0xF1DD10", Offset = "0xF1DD10", VA = "0xF1DD10")]
			set
			{
			}
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xF1DD7C", Offset = "0xF1DD7C", VA = "0xF1DD7C")]
		public static void Init()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xF1E578", Offset = "0xF1E578", VA = "0xF1E578")]
		private static void ConfigLoaded()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xF1E380", Offset = "0xF1E380", VA = "0xF1E380")]
		private static string GetCurrentLanguageSetting()
		{
			return null;
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xF1E4F8", Offset = "0xF1E4F8", VA = "0xF1E4F8")]
		private static void Init(Hashtable table)
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xF1D7C4", Offset = "0xF1D7C4", VA = "0xF1D7C4")]
		public static string Text(int key)
		{
			return null;
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xF1E614", Offset = "0xF1E614", VA = "0xF1E614")]
		public static string Text(int key, string[] param)
		{
			return null;
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xF1D334", Offset = "0xF1D334", VA = "0xF1D334")]
		public static string TextImagePath(int languageId)
		{
			return null;
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xF1D904", Offset = "0xF1D904", VA = "0xF1D904")]
		public static string TextStyle(int languageId)
		{
			return null;
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xF1D6C4", Offset = "0xF1D6C4", VA = "0xF1D6C4")]
		public static TMP_FontAsset Font()
		{
			return null;
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xF1E884", Offset = "0xF1E884", VA = "0xF1E884")]
		public LanguageUtils()
		{
		}
	}
	[Token(Token = "0x2000108")]
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

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xF1E57C", Offset = "0xF1E57C", VA = "0xF1E57C")]
		public string getText(string type)
		{
			return null;
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xF1E754", Offset = "0xF1E754", VA = "0xF1E754")]
		public string GetTextImage(string type)
		{
			return null;
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xF1E7EC", Offset = "0xF1E7EC", VA = "0xF1E7EC")]
		public string GetSyle(string type)
		{
			return null;
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xF1E4F0", Offset = "0xF1E4F0", VA = "0xF1E4F0")]
		public LanguageVO()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class LanguageType
	{
		[Token(Token = "0x40003CC")]
		public const string cn = "cn";

		[Token(Token = "0x40003CD")]
		public const string en = "en";

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xF1DCA4", Offset = "0xF1DCA4", VA = "0xF1DCA4")]
		public LanguageType()
		{
		}
	}
}
namespace ZYB.Model
{
	[Token(Token = "0x200010A")]
	public class BaseModel
	{
		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string modelName;

		[Token(Token = "0x170000A7")]
		public virtual string ModelName
		{
			[Token(Token = "0x6000593")]
			[Address(RVA = "0xEFF840", Offset = "0xEFF840", VA = "0xEFF840", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000594")]
			[Address(RVA = "0xEFF8A4", Offset = "0xEFF8A4", VA = "0xEFF8A4", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xEFF83C", Offset = "0xEFF83C", VA = "0xEFF83C")]
		static BaseModel()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xEFF910", Offset = "0xEFF910", VA = "0xEFF910", Slot = "6")]
		public virtual void Init()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xEFFA4C", Offset = "0xEFFA4C", VA = "0xEFFA4C", Slot = "7")]
		public virtual void Destroy()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xEFFAC0", Offset = "0xEFFAC0", VA = "0xEFFAC0")]
		public BaseModel()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class ModelManager
	{
		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Hashtable modelTable;

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xF20964", Offset = "0xF20964", VA = "0xF20964")]
		public static void Register(BaseModel model)
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xF20C0C", Offset = "0xF20C0C", VA = "0xF20C0C")]
		public static void Unregister(BaseModel model)
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xF20CB4", Offset = "0xF20CB4", VA = "0xF20CB4")]
		public static void UnregisterAll()
		{
		}

		[Token(Token = "0x600059B")]
		public static T GetModel<T>(string key)
		{
			return (T)null;
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xF210DC", Offset = "0xF210DC", VA = "0xF210DC")]
		public static void ForceSerialize(BaseModel model)
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xF21280", Offset = "0xF21280", VA = "0xF21280")]
		public static void ForceSerializeAll()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xF21640", Offset = "0xF21640", VA = "0xF21640")]
		public ModelManager()
		{
		}
	}
	[Token(Token = "0x200010C")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x73C374", Offset = "0x73C374")]
	public class ModelSerializable : Attribute
	{
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xF216C0", Offset = "0xF216C0", VA = "0xF216C0")]
		public ModelSerializable()
		{
		}
	}
}
namespace StaticConfig
{
	[Token(Token = "0x200010D")]
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

		[Token(Token = "0x60005A1")]
		public abstract string GetConfigKey();

		[Token(Token = "0x60005A2")]
		public abstract void Trans(string json, string key);

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xEFF668", Offset = "0xEFF668", VA = "0xEFF668")]
		public void clear()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xEFF670", Offset = "0xEFF670", VA = "0xEFF670")]
		public void LoadConfig(string path, Action<string> loadSuccess)
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xEFF750", Offset = "0xEFF750", VA = "0xEFF750")]
		private void OpLoadSuccess()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xEFCBCC", Offset = "0xEFCBCC", VA = "0xEFCBCC")]
		protected BaseConfig()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public abstract class BaseConfigs
	{
		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<BaseConfigVO> data;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string classReference;

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xEFF82C", Offset = "0xEFF82C", VA = "0xEFF82C")]
		protected BaseConfigs()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class BaseConfigVO
	{
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xEFF824", Offset = "0xEFF824", VA = "0xEFF824")]
		public BaseConfigVO()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class ConfigManger
	{
		[Token(Token = "0x2000111")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C3A8", Offset = "0x73C3A8")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string path;

			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x10625C4", Offset = "0x10625C4", VA = "0x10625C4")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x10625CC", Offset = "0x10625CC", VA = "0x10625CC")]
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

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xF04B10", Offset = "0xF04B10", VA = "0xF04B10")]
		public static void Load(string path, [Optional] Action onLoadSuccess)
		{
		}

		[Token(Token = "0x60005AA")]
		public static void load<T>(string path)
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xEF9CBC", Offset = "0xEF9CBC", VA = "0xEF9CBC")]
		public static void LoadList(string[] paths, Action onLoadSuccess)
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xF04BF4", Offset = "0xF04BF4", VA = "0xF04BF4")]
		private static void LoadSimpleSuccess(AsyncOpRef opRef, string path)
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xF04E70", Offset = "0xF04E70", VA = "0xF04E70")]
		public static void clear(BaseConfig config)
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xF04F6C", Offset = "0xF04F6C", VA = "0xF04F6C")]
		public static void clear(string path)
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xF05090", Offset = "0xF05090", VA = "0xF05090")]
		public ConfigManger()
		{
		}
	}
}
namespace TMPro
{
	[Serializable]
	[Token(Token = "0x2000112")]
	public class TMP_DigitValidator : TMP_InputValidator
	{
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xE60708", Offset = "0xE60708", VA = "0xE60708", Slot = "4")]
		public override char Validate(ref string text, ref int pos, char ch)
		{
			return default(char);
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xE6078C", Offset = "0xE6078C", VA = "0xE6078C")]
		public TMP_DigitValidator()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000113")]
	public class TMP_PhoneNumberValidator : TMP_InputValidator
	{
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xE61034", Offset = "0xE61034", VA = "0xE61034", Slot = "4")]
		public override char Validate(ref string text, ref int pos, char ch)
		{
			return default(char);
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xE614B4", Offset = "0xE614B4", VA = "0xE614B4")]
		public TMP_PhoneNumberValidator()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class TMP_TextEventHandler : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Serializable]
		[Token(Token = "0x2000115")]
		public class CharacterSelectionEvent : UnityEvent<char, int>
		{
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x1069ECC", Offset = "0x1069ECC", VA = "0x1069ECC")]
			public CharacterSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000116")]
		public class SpriteSelectionEvent : UnityEvent<char, int>
		{
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x1069FB0", Offset = "0x1069FB0", VA = "0x1069FB0")]
			public SpriteSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000117")]
		public class WordSelectionEvent : UnityEvent<string, int, int>
		{
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x1069FFC", Offset = "0x1069FFC", VA = "0x1069FFC")]
			public WordSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000118")]
		public class LineSelectionEvent : UnityEvent<string, int, int>
		{
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x1069F18", Offset = "0x1069F18", VA = "0x1069F18")]
			public LineSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000119")]
		public class LinkSelectionEvent : UnityEvent<string, string, int>
		{
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x1069F64", Offset = "0x1069F64", VA = "0x1069F64")]
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
			[Token(Token = "0x60005B7")]
			[Address(RVA = "0xE627DC", Offset = "0xE627DC", VA = "0xE627DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0xE627E4", Offset = "0xE627E4", VA = "0xE627E4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public SpriteSelectionEvent onSpriteSelection
		{
			[Token(Token = "0x60005B9")]
			[Address(RVA = "0xE627EC", Offset = "0xE627EC", VA = "0xE627EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005BA")]
			[Address(RVA = "0xE627F4", Offset = "0xE627F4", VA = "0xE627F4")]
			set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public WordSelectionEvent onWordSelection
		{
			[Token(Token = "0x60005BB")]
			[Address(RVA = "0xE627FC", Offset = "0xE627FC", VA = "0xE627FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0xE62804", Offset = "0xE62804", VA = "0xE62804")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public LineSelectionEvent onLineSelection
		{
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0xE6280C", Offset = "0xE6280C", VA = "0xE6280C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005BE")]
			[Address(RVA = "0xE62814", Offset = "0xE62814", VA = "0xE62814")]
			set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public LinkSelectionEvent onLinkSelection
		{
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0xE6281C", Offset = "0xE6281C", VA = "0xE6281C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005C0")]
			[Address(RVA = "0xE62824", Offset = "0xE62824", VA = "0xE62824")]
			set
			{
			}
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xE6282C", Offset = "0xE6282C", VA = "0xE6282C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xE62A04", Offset = "0xE62A04", VA = "0xE62A04")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xE63150", Offset = "0xE63150", VA = "0xE63150", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xE63154", Offset = "0xE63154", VA = "0xE63154", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xE62EBC", Offset = "0xE62EBC", VA = "0xE62EBC")]
		private void SendOnCharacterSelection(char character, int characterIndex)
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xE62F34", Offset = "0xE62F34", VA = "0xE62F34")]
		private void SendOnSpriteSelection(char character, int characterIndex)
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xE62FAC", Offset = "0xE62FAC", VA = "0xE62FAC")]
		private void SendOnWordSelection(string word, int charIndex, int length)
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xE63038", Offset = "0xE63038", VA = "0xE63038")]
		private void SendOnLineSelection(string line, int charIndex, int length)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xE630C4", Offset = "0xE630C4", VA = "0xE630C4")]
		private void SendOnLinkSelection(string linkID, string linkText, int linkIndex)
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xE63158", Offset = "0xE63158", VA = "0xE63158")]
		public TMP_TextEventHandler()
		{
		}
	}
}
namespace TMPro.Examples
{
	[Token(Token = "0x200011A")]
	public class Benchmark01 : MonoBehaviour
	{
		[Token(Token = "0x200011B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C3B8", Offset = "0x73C3B8")]
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
				[Token(Token = "0x60005D5")]
				[Address(RVA = "0x106200C", Offset = "0x106200C", VA = "0x106200C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005D7")]
				[Address(RVA = "0x1062054", Offset = "0x1062054", VA = "0x1062054", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x10619F4", Offset = "0x10619F4", VA = "0x10619F4")]
			[DebuggerHidden]
			public <Start>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x1061A20", Offset = "0x1061A20", VA = "0x1061A20", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x1061A24", Offset = "0x1061A24", VA = "0x1061A24", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x1062014", Offset = "0x1062014", VA = "0x1062014", Slot = "8")]
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

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xEFFAC8", Offset = "0xEFFAC8", VA = "0xEFFAC8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73D944", Offset = "0x73D944")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xEFFB40", Offset = "0xEFFB40", VA = "0xEFFB40")]
		public Benchmark01()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class Benchmark01_UGUI : MonoBehaviour
	{
		[Token(Token = "0x200011D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C3C8", Offset = "0x73C3C8")]
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
				[Token(Token = "0x60005DD")]
				[Address(RVA = "0x1062558", Offset = "0x1062558", VA = "0x1062558", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005DF")]
				[Address(RVA = "0x10625A0", Offset = "0x10625A0", VA = "0x10625A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x106205C", Offset = "0x106205C", VA = "0x106205C")]
			[DebuggerHidden]
			public <Start>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x1062088", Offset = "0x1062088", VA = "0x1062088", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x106208C", Offset = "0x106208C", VA = "0x106208C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x1062560", Offset = "0x1062560", VA = "0x1062560", Slot = "8")]
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

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xEFFB48", Offset = "0xEFFB48", VA = "0xEFFB48")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73D9F4", Offset = "0x73D9F4")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xEFFBC0", Offset = "0xEFFBC0", VA = "0xEFFBC0")]
		public Benchmark01_UGUI()
		{
		}
	}
	[Token(Token = "0x200011E")]
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

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xEFFBC8", Offset = "0xEFFBC8", VA = "0xEFFBC8")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xF0021C", Offset = "0xF0021C", VA = "0xF0021C")]
		public Benchmark02()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class Benchmark03 : MonoBehaviour
	{
		[Token(Token = "0x2000120")]
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

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xF0022C", Offset = "0xF0022C", VA = "0xF0022C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xF00230", Offset = "0xF00230", VA = "0xF00230")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xF006EC", Offset = "0xF006EC", VA = "0xF006EC")]
		public Benchmark03()
		{
		}
	}
	[Token(Token = "0x2000121")]
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

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xF006FC", Offset = "0xF006FC", VA = "0xF006FC")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xF00A20", Offset = "0xF00A20", VA = "0xF00A20")]
		public Benchmark04()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class CameraController : MonoBehaviour
	{
		[Token(Token = "0x2000123")]
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

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xF02B78", Offset = "0xF02B78", VA = "0xF02B78")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xF02C08", Offset = "0xF02C08", VA = "0xF02C08")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xF02D08", Offset = "0xF02D08", VA = "0xF02D08")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xF03020", Offset = "0xF03020", VA = "0xF03020")]
		private void GetPlayerInput()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xF037F8", Offset = "0xF037F8", VA = "0xF037F8")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class ObjectSpin : MonoBehaviour
	{
		[Token(Token = "0x2000125")]
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

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xF21B50", Offset = "0xF21B50", VA = "0xF21B50")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xF21C80", Offset = "0xF21C80", VA = "0xF21C80")]
		private void Update()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xF21DBC", Offset = "0xF21DBC", VA = "0xF21DBC")]
		public ObjectSpin()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class ShaderPropAnimator : MonoBehaviour
	{
		[Token(Token = "0x2000127")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C3D8", Offset = "0x73C3D8")]
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
				[Token(Token = "0x60005F6")]
				[Address(RVA = "0x10689A0", Offset = "0x10689A0", VA = "0x10689A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005F8")]
				[Address(RVA = "0x10689E8", Offset = "0x10689E8", VA = "0x10689E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x1068804", Offset = "0x1068804", VA = "0x1068804")]
			[DebuggerHidden]
			public <AnimateProperties>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x1068830", Offset = "0x1068830", VA = "0x1068830", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x1068834", Offset = "0x1068834", VA = "0x1068834", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x10689A8", Offset = "0x10689A8", VA = "0x10689A8", Slot = "8")]
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

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xE5B658", Offset = "0xE5B658", VA = "0xE5B658")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xE5B6D8", Offset = "0xE5B6D8", VA = "0xE5B6D8")]
		private void Start()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xE5B704", Offset = "0xE5B704", VA = "0xE5B704")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73DAA4", Offset = "0x73DAA4")]
		private IEnumerator AnimateProperties()
		{
			return null;
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xE5B77C", Offset = "0xE5B77C", VA = "0xE5B77C")]
		public ShaderPropAnimator()
		{
		}
	}
	[Token(Token = "0x2000128")]
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

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xE5B784", Offset = "0xE5B784", VA = "0xE5B784")]
		private void Start()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xE5B84C", Offset = "0xE5B84C", VA = "0xE5B84C")]
		private void Update()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xE5B8E4", Offset = "0xE5B8E4", VA = "0xE5B8E4")]
		public SimpleScript()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class SkewTextExample : MonoBehaviour
	{
		[Token(Token = "0x200012A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C3E8", Offset = "0x73C3E8")]
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
				[Token(Token = "0x6000604")]
				[Address(RVA = "0x10692B0", Offset = "0x10692B0", VA = "0x10692B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000606")]
				[Address(RVA = "0x10692F8", Offset = "0x10692F8", VA = "0x10692F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0x10689F0", Offset = "0x10689F0", VA = "0x10689F0")]
			[DebuggerHidden]
			public <WarpText>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000602")]
			[Address(RVA = "0x1068A1C", Offset = "0x1068A1C", VA = "0x1068A1C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000603")]
			[Address(RVA = "0x1068A20", Offset = "0x1068A20", VA = "0x1068A20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0x10692B8", Offset = "0x10692B8", VA = "0x10692B8", Slot = "8")]
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

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xE5B8EC", Offset = "0xE5B8EC", VA = "0xE5B8EC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xE5B958", Offset = "0xE5B958", VA = "0xE5B958")]
		private void Start()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xE5B9FC", Offset = "0xE5B9FC", VA = "0xE5B9FC")]
		private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			return null;
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xE5B984", Offset = "0xE5B984", VA = "0xE5B984")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73DB54", Offset = "0x73DB54")]
		private IEnumerator WarpText()
		{
			return null;
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xE5BA80", Offset = "0xE5BA80", VA = "0xE5BA80")]
		public SkewTextExample()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public class TMP_ExampleScript_01 : MonoBehaviour
	{
		[Token(Token = "0x200012C")]
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

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xE60794", Offset = "0xE60794", VA = "0xE60794")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xE609B0", Offset = "0xE609B0", VA = "0xE609B0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xE60A48", Offset = "0xE60A48", VA = "0xE60A48")]
		public TMP_ExampleScript_01()
		{
		}
	}
	[Token(Token = "0x200012D")]
	public class TMP_FrameRateCounter : MonoBehaviour
	{
		[Token(Token = "0x200012E")]
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

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xE60A50", Offset = "0xE60A50", VA = "0xE60A50")]
		private void Awake()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xE60E80", Offset = "0xE60E80", VA = "0xE60E80")]
		private void Start()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xE60EAC", Offset = "0xE60EAC", VA = "0xE60EAC")]
		private void Update()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xE60C78", Offset = "0xE60C78", VA = "0xE60C78")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xE6101C", Offset = "0xE6101C", VA = "0xE6101C")]
		public TMP_FrameRateCounter()
		{
		}
	}
	[Token(Token = "0x200012F")]
	public class TMP_TextEventCheck : MonoBehaviour
	{
		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TMP_TextEventHandler TextEventHandler;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xE614BC", Offset = "0xE614BC", VA = "0xE614BC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xE617D0", Offset = "0xE617D0", VA = "0xE617D0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xE61AAC", Offset = "0xE61AAC", VA = "0xE61AAC")]
		private void OnCharacterSelection(char c, int index)
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xE61CEC", Offset = "0xE61CEC", VA = "0xE61CEC")]
		private void OnSpriteSelection(char c, int index)
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xE61F2C", Offset = "0xE61F2C", VA = "0xE61F2C")]
		private void OnWordSelection(string word, int firstCharacterIndex, int length)
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xE621F0", Offset = "0xE621F0", VA = "0xE621F0")]
		private void OnLineSelection(string lineText, int firstCharacterIndex, int length)
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xE624B4", Offset = "0xE624B4", VA = "0xE624B4")]
		private void OnLinkSelection(string linkID, string linkText, int linkIndex)
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xE627D4", Offset = "0xE627D4", VA = "0xE627D4")]
		public TMP_TextEventCheck()
		{
		}
	}
	[Token(Token = "0x2000130")]
	public class TMP_TextInfoDebugTool : MonoBehaviour
	{
		[Token(Token = "0x6000617")]
		[Address(RVA = "0xE632B0", Offset = "0xE632B0", VA = "0xE632B0")]
		public TMP_TextInfoDebugTool()
		{
		}
	}
	[Token(Token = "0x2000131")]
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

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xE632B8", Offset = "0xE632B8", VA = "0xE632B8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xE6335C", Offset = "0xE6335C", VA = "0xE6335C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xE63A7C", Offset = "0xE63A7C", VA = "0xE63A7C", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xE63B00", Offset = "0xE63B00", VA = "0xE63B00", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xE63B80", Offset = "0xE63B80", VA = "0xE63B80")]
		public TMP_TextSelector_A()
		{
		}
	}
	[Token(Token = "0x2000132")]
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

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xE63B98", Offset = "0xE63B98", VA = "0xE63B98")]
		private void Awake()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xE63D74", Offset = "0xE63D74", VA = "0xE63D74")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xE63E64", Offset = "0xE63E64", VA = "0xE63E64")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xE63F54", Offset = "0xE63F54", VA = "0xE63F54")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xE6400C", Offset = "0xE6400C", VA = "0xE6400C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xE65504", Offset = "0xE65504", VA = "0xE65504", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xE65510", Offset = "0xE65510", VA = "0xE65510", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xE65518", Offset = "0xE65518", VA = "0xE65518", Slot = "6")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xE6551C", Offset = "0xE6551C", VA = "0xE6551C", Slot = "7")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xE64C74", Offset = "0xE64C74", VA = "0xE64C74")]
		private void RestoreCachedVertexAttributes(int index)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xE65520", Offset = "0xE65520", VA = "0xE65520")]
		public TMP_TextSelector_B()
		{
		}
	}
	[Token(Token = "0x2000133")]
	public class TMP_UiFrameRateCounter : MonoBehaviour
	{
		[Token(Token = "0x2000134")]
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

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xE65538", Offset = "0xE65538", VA = "0xE65538")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xE6599C", Offset = "0xE6599C", VA = "0xE6599C")]
		private void Start()
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xE659C8", Offset = "0xE659C8", VA = "0xE659C8")]
		private void Update()
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xE65758", Offset = "0xE65758", VA = "0xE65758")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xE65B38", Offset = "0xE65B38", VA = "0xE65B38")]
		public TMP_UiFrameRateCounter()
		{
		}
	}
	[Token(Token = "0x2000135")]
	public class TMPro_InstructionOverlay : MonoBehaviour
	{
		[Token(Token = "0x2000136")]
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

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xE65B50", Offset = "0xE65B50", VA = "0xE65B50")]
		private void Awake()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xE65DD0", Offset = "0xE65DD0", VA = "0xE65DD0")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xE65EF8", Offset = "0xE65EF8", VA = "0xE65EF8")]
		public TMPro_InstructionOverlay()
		{
		}
	}
	[Token(Token = "0x2000137")]
	public class TeleType : MonoBehaviour
	{
		[Token(Token = "0x2000138")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C3F8", Offset = "0x73C3F8")]
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
				[Token(Token = "0x6000636")]
				[Address(RVA = "0x106A2D0", Offset = "0x106A2D0", VA = "0x106A2D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000638")]
				[Address(RVA = "0x106A318", Offset = "0x106A318", VA = "0x106A318", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000633")]
			[Address(RVA = "0x106A048", Offset = "0x106A048", VA = "0x106A048")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000634")]
			[Address(RVA = "0x106A074", Offset = "0x106A074", VA = "0x106A074", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000635")]
			[Address(RVA = "0x106A078", Offset = "0x106A078", VA = "0x106A078", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000637")]
			[Address(RVA = "0x106A2D8", Offset = "0x106A2D8", VA = "0x106A2D8", Slot = "8")]
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

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xE65F08", Offset = "0xE65F08", VA = "0xE65F08")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xE65FB0", Offset = "0xE65FB0", VA = "0xE65FB0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73DC04", Offset = "0x73DC04")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xE66028", Offset = "0xE66028", VA = "0xE66028")]
		public TeleType()
		{
		}
	}
	[Token(Token = "0x2000139")]
	public class TextConsoleSimulator : MonoBehaviour
	{
		[Token(Token = "0x200013A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C408", Offset = "0x73C408")]
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
				[Token(Token = "0x6000644")]
				[Address(RVA = "0x106A4D0", Offset = "0x106A4D0", VA = "0x106A4D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000646")]
				[Address(RVA = "0x106A518", Offset = "0x106A518", VA = "0x106A518", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000641")]
			[Address(RVA = "0x106A320", Offset = "0x106A320", VA = "0x106A320")]
			[DebuggerHidden]
			public <RevealCharacters>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0x106A34C", Offset = "0x106A34C", VA = "0x106A34C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000643")]
			[Address(RVA = "0x106A350", Offset = "0x106A350", VA = "0x106A350", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0x106A4D8", Offset = "0x106A4D8", VA = "0x106A4D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200013B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C418", Offset = "0x73C418")]
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
				[Token(Token = "0x600064A")]
				[Address(RVA = "0x106A744", Offset = "0x106A744", VA = "0x106A744", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600064C")]
				[Address(RVA = "0x106A78C", Offset = "0x106A78C", VA = "0x106A78C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0x106A520", Offset = "0x106A520", VA = "0x106A520")]
			[DebuggerHidden]
			public <RevealWords>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0x106A54C", Offset = "0x106A54C", VA = "0x106A54C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000649")]
			[Address(RVA = "0x106A550", Offset = "0x106A550", VA = "0x106A550", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600064B")]
			[Address(RVA = "0x106A74C", Offset = "0x106A74C", VA = "0x106A74C", Slot = "8")]
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

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xE6673C", Offset = "0xE6673C", VA = "0xE6673C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xE667A8", Offset = "0xE667A8", VA = "0xE667A8")]
		private void Start()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xE6686C", Offset = "0xE6686C", VA = "0xE6686C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xE6695C", Offset = "0xE6695C", VA = "0xE6695C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xE66A4C", Offset = "0xE66A4C", VA = "0xE66A4C")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xE667D8", Offset = "0xE667D8", VA = "0xE667D8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73DCB4", Offset = "0x73DCB4")]
		private IEnumerator RevealCharacters(TMP_Text textComponent)
		{
			return null;
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xE66A58", Offset = "0xE66A58", VA = "0xE66A58")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73DD14", Offset = "0x73DD14")]
		private IEnumerator RevealWords(TMP_Text textComponent)
		{
			return null;
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xE66AD0", Offset = "0xE66AD0", VA = "0xE66AD0")]
		public TextConsoleSimulator()
		{
		}
	}
	[Token(Token = "0x200013C")]
	public class TextMeshProFloatingText : MonoBehaviour
	{
		[Token(Token = "0x200013D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C428", Offset = "0x73C428")]
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
				[Token(Token = "0x6000656")]
				[Address(RVA = "0x106B104", Offset = "0x106B104", VA = "0x106B104", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000658")]
				[Address(RVA = "0x106B14C", Offset = "0x106B14C", VA = "0x106B14C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000653")]
			[Address(RVA = "0x106AC68", Offset = "0x106AC68", VA = "0x106AC68")]
			[DebuggerHidden]
			public <DisplayTextMeshProFloatingText>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000654")]
			[Address(RVA = "0x106AC94", Offset = "0x106AC94", VA = "0x106AC94", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000655")]
			[Address(RVA = "0x106AC98", Offset = "0x106AC98", VA = "0x106AC98", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0x106B10C", Offset = "0x106B10C", VA = "0x106B10C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200013E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C438", Offset = "0x73C438")]
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
				[Token(Token = "0x600065C")]
				[Address(RVA = "0x106AC18", Offset = "0x106AC18", VA = "0x106AC18", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600065E")]
				[Address(RVA = "0x106AC60", Offset = "0x106AC60", VA = "0x106AC60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000659")]
			[Address(RVA = "0x106A794", Offset = "0x106A794", VA = "0x106A794")]
			[DebuggerHidden]
			public <DisplayTextMeshFloatingText>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x600065A")]
			[Address(RVA = "0x106A7C0", Offset = "0x106A7C0", VA = "0x106A7C0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0x106A7C4", Offset = "0x106A7C4", VA = "0x106A7C4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0x106AC20", Offset = "0x106AC20", VA = "0x106AC20", Slot = "8")]
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

		[Token(Token = "0x600064D")]
		[Address(RVA = "0xE66AD8", Offset = "0xE66AD8", VA = "0xE66AD8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0xE66BC0", Offset = "0xE66BC0", VA = "0xE66BC0")]
		private void Start()
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xE66FDC", Offset = "0xE66FDC", VA = "0xE66FDC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73DE14", Offset = "0x73DE14")]
		public IEnumerator DisplayTextMeshProFloatingText()
		{
			return null;
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xE67054", Offset = "0xE67054", VA = "0xE67054")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73DE74", Offset = "0x73DE74")]
		public IEnumerator DisplayTextMeshFloatingText()
		{
			return null;
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xE670CC", Offset = "0xE670CC", VA = "0xE670CC")]
		public TextMeshProFloatingText()
		{
		}
	}
	[Token(Token = "0x200013F")]
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

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xE6782C", Offset = "0xE6782C", VA = "0xE6782C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xE67830", Offset = "0xE67830", VA = "0xE67830")]
		private void Start()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xE67B74", Offset = "0xE67B74", VA = "0xE67B74")]
		public TextMeshSpawner()
		{
		}
	}
	[Token(Token = "0x2000140")]
	public class VertexColorCycler : MonoBehaviour
	{
		[Token(Token = "0x2000141")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C448", Offset = "0x73C448")]
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
				[Token(Token = "0x6000669")]
				[Address(RVA = "0x106B90C", Offset = "0x106B90C", VA = "0x106B90C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600066B")]
				[Address(RVA = "0x106B954", Offset = "0x106B954", VA = "0x106B954", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000666")]
			[Address(RVA = "0x106B5FC", Offset = "0x106B5FC", VA = "0x106B5FC")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0x106B628", Offset = "0x106B628", VA = "0x106B628", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000668")]
			[Address(RVA = "0x106B62C", Offset = "0x106B62C", VA = "0x106B62C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600066A")]
			[Address(RVA = "0x106B914", Offset = "0x106B914", VA = "0x106B914", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xE6CF20", Offset = "0xE6CF20", VA = "0xE6CF20")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xE6CF7C", Offset = "0xE6CF7C", VA = "0xE6CF7C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xE6CFA8", Offset = "0xE6CFA8", VA = "0xE6CFA8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73DF74", Offset = "0x73DF74")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xE6D020", Offset = "0xE6D020", VA = "0xE6D020")]
		public VertexColorCycler()
		{
		}
	}
	[Token(Token = "0x2000142")]
	public class VertexJitter : MonoBehaviour
	{
		[Token(Token = "0x2000143")]
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

		[Token(Token = "0x2000144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C458", Offset = "0x73C458")]
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
				[Token(Token = "0x6000676")]
				[Address(RVA = "0x106C204", Offset = "0x106C204", VA = "0x106C204", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000678")]
				[Address(RVA = "0x106C24C", Offset = "0x106C24C", VA = "0x106C24C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000673")]
			[Address(RVA = "0x106B95C", Offset = "0x106B95C", VA = "0x106B95C")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000674")]
			[Address(RVA = "0x106B988", Offset = "0x106B988", VA = "0x106B988", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000675")]
			[Address(RVA = "0x106B98C", Offset = "0x106B98C", VA = "0x106B98C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000677")]
			[Address(RVA = "0x106C20C", Offset = "0x106C20C", VA = "0x106C20C", Slot = "8")]
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

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xE6D028", Offset = "0xE6D028", VA = "0xE6D028")]
		private void Awake()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xE6D084", Offset = "0xE6D084", VA = "0xE6D084")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xE6D174", Offset = "0xE6D174", VA = "0xE6D174")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xE6D264", Offset = "0xE6D264", VA = "0xE6D264")]
		private void Start()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xE6D308", Offset = "0xE6D308", VA = "0xE6D308")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xE6D290", Offset = "0xE6D290", VA = "0xE6D290")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73E024", Offset = "0x73E024")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xE6D390", Offset = "0xE6D390", VA = "0xE6D390")]
		public VertexJitter()
		{
		}
	}
	[Token(Token = "0x2000145")]
	public class VertexShakeA : MonoBehaviour
	{
		[Token(Token = "0x2000146")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C468", Offset = "0x73C468")]
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
				[Token(Token = "0x6000683")]
				[Address(RVA = "0x106CCAC", Offset = "0x106CCAC", VA = "0x106CCAC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000685")]
				[Address(RVA = "0x106CCF4", Offset = "0x106CCF4", VA = "0x106CCF4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000680")]
			[Address(RVA = "0x106C254", Offset = "0x106C254", VA = "0x106C254")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000681")]
			[Address(RVA = "0x106C280", Offset = "0x106C280", VA = "0x106C280", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000682")]
			[Address(RVA = "0x106C284", Offset = "0x106C284", VA = "0x106C284", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000684")]
			[Address(RVA = "0x106CCB4", Offset = "0x106CCB4", VA = "0x106CCB4", Slot = "8")]
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

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xE6D3A8", Offset = "0xE6D3A8", VA = "0xE6D3A8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xE6D404", Offset = "0xE6D404", VA = "0xE6D404")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xE6D4F4", Offset = "0xE6D4F4", VA = "0xE6D4F4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xE6D5E4", Offset = "0xE6D5E4", VA = "0xE6D5E4")]
		private void Start()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xE6D688", Offset = "0xE6D688", VA = "0xE6D688")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xE6D610", Offset = "0xE6D610", VA = "0xE6D610")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73E0D4", Offset = "0x73E0D4")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xE6D700", Offset = "0xE6D700", VA = "0xE6D700")]
		public VertexShakeA()
		{
		}
	}
	[Token(Token = "0x2000147")]
	public class VertexShakeB : MonoBehaviour
	{
		[Token(Token = "0x2000148")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C478", Offset = "0x73C478")]
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
				[Token(Token = "0x6000690")]
				[Address(RVA = "0x106DBE0", Offset = "0x106DBE0", VA = "0x106DBE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000692")]
				[Address(RVA = "0x106DC28", Offset = "0x106DC28", VA = "0x106DC28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600068D")]
			[Address(RVA = "0x106CCFC", Offset = "0x106CCFC", VA = "0x106CCFC")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600068E")]
			[Address(RVA = "0x106CD28", Offset = "0x106CD28", VA = "0x106CD28", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600068F")]
			[Address(RVA = "0x106CD2C", Offset = "0x106CD2C", VA = "0x106CD2C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000691")]
			[Address(RVA = "0x106DBE8", Offset = "0x106DBE8", VA = "0x106DBE8", Slot = "8")]
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

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xE6D710", Offset = "0xE6D710", VA = "0xE6D710")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xE6D76C", Offset = "0xE6D76C", VA = "0xE6D76C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xE6D85C", Offset = "0xE6D85C", VA = "0xE6D85C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xE6D94C", Offset = "0xE6D94C", VA = "0xE6D94C")]
		private void Start()
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xE6D9F0", Offset = "0xE6D9F0", VA = "0xE6D9F0")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xE6D978", Offset = "0xE6D978", VA = "0xE6D978")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73E184", Offset = "0x73E184")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xE6DA68", Offset = "0xE6DA68", VA = "0xE6DA68")]
		public VertexShakeB()
		{
		}
	}
	[Token(Token = "0x2000149")]
	public class VertexZoom : MonoBehaviour
	{
		[Token(Token = "0x200014A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C488", Offset = "0x73C488")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<float> modifiedCharScale;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Comparison<int> <>9__0;

			[Token(Token = "0x600069A")]
			[Address(RVA = "0x106DC30", Offset = "0x106DC30", VA = "0x106DC30")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x600069B")]
			[Address(RVA = "0x106DC38", Offset = "0x106DC38", VA = "0x106DC38")]
			internal int <AnimateVertexColors>b__0(int a, int b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200014B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C498", Offset = "0x73C498")]
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
				[Token(Token = "0x600069F")]
				[Address(RVA = "0x106E8EC", Offset = "0x106E8EC", VA = "0x106E8EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006A1")]
				[Address(RVA = "0x106E934", Offset = "0x106E934", VA = "0x106E934", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0x106DCF8", Offset = "0x106DCF8", VA = "0x106DCF8")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600069D")]
			[Address(RVA = "0x106DD24", Offset = "0x106DD24", VA = "0x106DD24", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0x106DD28", Offset = "0x106DD28", VA = "0x106DD28", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x106E8F4", Offset = "0x106E8F4", VA = "0x106E8F4", Slot = "8")]
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

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xE6DA80", Offset = "0xE6DA80", VA = "0xE6DA80")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xE6DADC", Offset = "0xE6DADC", VA = "0xE6DADC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xE6DBCC", Offset = "0xE6DBCC", VA = "0xE6DBCC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xE6DCBC", Offset = "0xE6DCBC", VA = "0xE6DCBC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xE6DD60", Offset = "0xE6DD60", VA = "0xE6DD60")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xE6DCE8", Offset = "0xE6DCE8", VA = "0xE6DCE8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73E234", Offset = "0x73E234")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xE6DDE8", Offset = "0xE6DDE8", VA = "0xE6DDE8")]
		public VertexZoom()
		{
		}
	}
	[Token(Token = "0x200014C")]
	public class WarpTextExample : MonoBehaviour
	{
		[Token(Token = "0x200014D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73C4A8", Offset = "0x73C4A8")]
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
				[Token(Token = "0x60006AA")]
				[Address(RVA = "0x106F150", Offset = "0x106F150", VA = "0x106F150", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006AC")]
				[Address(RVA = "0x106F198", Offset = "0x106F198", VA = "0x106F198", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x106E93C", Offset = "0x106E93C", VA = "0x106E93C")]
			[DebuggerHidden]
			public <WarpText>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x106E968", Offset = "0x106E968", VA = "0x106E968", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x106E96C", Offset = "0x106E96C", VA = "0x106E96C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x106F158", Offset = "0x106F158", VA = "0x106F158", Slot = "8")]
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

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xE6DE00", Offset = "0xE6DE00", VA = "0xE6DE00")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xE6DE6C", Offset = "0xE6DE6C", VA = "0xE6DE6C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xE6DF10", Offset = "0xE6DF10", VA = "0xE6DF10")]
		private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			return null;
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xE6DE98", Offset = "0xE6DE98", VA = "0xE6DE98")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73E2E4", Offset = "0x73E2E4")]
		private IEnumerator WarpText()
		{
			return null;
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xE6DF94", Offset = "0xE6DF94", VA = "0xE6DF94")]
		public WarpTextExample()
		{
		}
	}
}
