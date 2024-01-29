using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Bright.Config;
using Bright.Serialization;
using Com.Zqgame.VRGrilFriend;
using Com.Zqgame.VRGrilFriend.Tb;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Framework;
using Framework.Net;
using Framework.UI;
using Framework.Video;
using Framework.Work;
using Framework.XR;
using Il2CppDummyDll;
using Pico.Platform;
using Pico.Platform.Models;
using Qiyu.Sdk.Platform;
using RenderHeads.Media.AVProVideo;
using SimpleJSON;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.XR.Interaction.Toolkit;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class PlatformTest : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D338", Offset = "0x75D338")]
	private sealed class <>c
	{
		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<QiyuMessage.MessageResult<QiyuMessage.SDKInit>> <>9__4_0;

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x1C3BB20", Offset = "0x1C3BB20", VA = "0x1C3BB20")]
		public <>c()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x1C3BB28", Offset = "0x1C3BB28", VA = "0x1C3BB28")]
		internal void <Start>b__4_0(QiyuMessage.MessageResult<QiyuMessage.SDKInit> msg)
		{
		}
	}

	[Token(Token = "0x4000001")]
	private const string TAG = "PlatformTest";

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text uid;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text nickName;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text pic;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xB174C0", Offset = "0xB174C0", VA = "0xB174C0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xB17680", Offset = "0xB17680", VA = "0xB17680")]
	private void OnGetDeepLink(QiyuMessage.MessageResult<QiyuMessage.DeepLinkParam> msg)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xB17750", Offset = "0xB17750", VA = "0xB17750")]
	public void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xB1781C", Offset = "0xB1781C", VA = "0xB1781C")]
	public void GoHomeLogin()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xB1787C", Offset = "0xB1787C", VA = "0xB1787C")]
	public void GetQiyuAccountInfo()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xB17974", Offset = "0xB17974", VA = "0xB17974")]
	public void OpenApp()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xB17A18", Offset = "0xB17A18", VA = "0xB17A18")]
	private void TestQiyuPrefs()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xB17D24", Offset = "0xB17D24", VA = "0xB17D24")]
	public void OnClickButton(GameObject btn)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xB17F5C", Offset = "0xB17F5C", VA = "0xB17F5C")]
	public PlatformTest()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xB17F64", Offset = "0xB17F64", VA = "0xB17F64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76068C", Offset = "0x76068C")]
	private void <GetQiyuAccountInfo>b__8_0(QiyuMessage.MessageResult<QiyuMessage.QiyuAccountInfo> msg)
	{
	}
}
[Token(Token = "0x2000004")]
public class QiyuDLCTest : MonoBehaviour
{
	[Token(Token = "0x2000005")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D348", Offset = "0x75D348")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string text;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public QiyuDLCTest <>4__this;

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1C454A8", Offset = "0x1C454A8", VA = "0x1C454A8")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1C454B0", Offset = "0x1C454B0", VA = "0x1C454B0")]
		internal void <OnClickButton>b__3(QiyuMessage.MessageResult<QiyuMessage.QiyuDlcAssetDetails> msg)
		{
		}
	}

	[Token(Token = "0x4000007")]
	private const string TAG = "QiyuDLCTest";

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text textField;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Dropdown dropdown_sku;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xB1FF24", Offset = "0xB1FF24", VA = "0xB1FF24")]
	private void Start()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xB200B4", Offset = "0xB200B4", VA = "0xB200B4")]
	public void OnClickButton(GameObject btn)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xB205BC", Offset = "0xB205BC", VA = "0xB205BC")]
	public QiyuDLCTest()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xB205C4", Offset = "0xB205C4", VA = "0xB205C4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76069C", Offset = "0x76069C")]
	private void <Start>b__3_0(QiyuMessage.MessageResult<QiyuMessage.SDKInit> msg)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xB2073C", Offset = "0xB2073C", VA = "0xB2073C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7606AC", Offset = "0x7606AC")]
	private void <OnClickButton>b__4_0(QiyuMessage.MessageResult<QiyuMessage.QiyuDlcAssetStatus> msg)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xB20950", Offset = "0xB20950", VA = "0xB20950")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7606BC", Offset = "0x7606BC")]
	private void <OnClickButton>b__4_1(QiyuMessage.QiyuDlcNotifications progress)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xB20B04", Offset = "0xB20B04", VA = "0xB20B04")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7606CC", Offset = "0x7606CC")]
	private void <OnClickButton>b__4_2(QiyuMessage.MessageResult<string> msg)
	{
	}
}
[Token(Token = "0x2000006")]
public class QiyuPayTest : MonoBehaviour
{
	[Token(Token = "0x2000007")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D358", Offset = "0x75D358")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string text;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public QiyuPayTest <>4__this;

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1C45934", Offset = "0x1C45934", VA = "0x1C45934")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1C4593C", Offset = "0x1C4593C", VA = "0x1C4593C")]
		internal void <OnClickButton>b__2(QiyuMessage.MessageResult<List<QiyuMessage.QiyuPaySkuInfo>> msg)
		{
		}
	}

	[Token(Token = "0x2000008")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D368", Offset = "0x75D368")]
	private sealed class <>c__DisplayClass5_1
	{
		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string text;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public QiyuPayTest <>4__this;

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1C45CB4", Offset = "0x1C45CB4", VA = "0x1C45CB4")]
		public <>c__DisplayClass5_1()
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1C45CBC", Offset = "0x1C45CBC", VA = "0x1C45CBC")]
		internal void <OnClickButton>b__3(QiyuMessage.MessageResult<QiyuMessage.QiyuPayHistoryOrders> msg)
		{
		}
	}

	[Token(Token = "0x400000C")]
	private const string TAG = "QiyuPayTest";

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text textField;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Dropdown dropdown_sku;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Dropdown dropdown_orderId;

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xB20C58", Offset = "0xB20C58", VA = "0xB20C58")]
	private void Start()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xB20E30", Offset = "0xB20E30", VA = "0xB20E30")]
	public void OnClickButton(GameObject btn)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xB213C8", Offset = "0xB213C8", VA = "0xB213C8")]
	public QiyuPayTest()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xB213D0", Offset = "0xB213D0", VA = "0xB213D0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7606DC", Offset = "0x7606DC")]
	private void <Start>b__4_0(QiyuMessage.MessageResult<QiyuMessage.SDKInit> msg)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xB21548", Offset = "0xB21548", VA = "0xB21548")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7606EC", Offset = "0x7606EC")]
	private void <OnClickButton>b__5_0(QiyuMessage.MessageResult<string> msg)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xB2172C", Offset = "0xB2172C", VA = "0xB2172C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7606FC", Offset = "0x7606FC")]
	private void <OnClickButton>b__5_1(QiyuMessage.MessageResult<QiyuMessage.QiyuPayOrderResult> msg)
	{
	}
}
[Token(Token = "0x2000009")]
public class Texture2DTest : MonoBehaviour
{
	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RawImage RawImage;

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x9EAFAC", Offset = "0x9EAFAC", VA = "0x9EAFAC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x9EB118", Offset = "0x9EB118", VA = "0x9EB118")]
	private void Update()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x9EAFB0", Offset = "0x9EAFB0", VA = "0x9EAFB0")]
	private void Test()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x9EB198", Offset = "0x9EB198", VA = "0x9EB198")]
	public Texture2DTest()
	{
	}
}
[Token(Token = "0x200000A")]
public class XRKeyTest : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200000B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D378", Offset = "0x75D378")]
	private sealed class <>c
	{
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<InputAction.CallbackContext> <>9__4_0;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<InputAction.CallbackContext> <>9__4_1;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Action<InputAction.CallbackContext> <>9__4_2;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Action<InputAction.CallbackContext> <>9__4_3;

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1C5BB14", Offset = "0x1C5BB14", VA = "0x1C5BB14")]
		public <>c()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1C5BB1C", Offset = "0x1C5BB1C", VA = "0x1C5BB1C")]
		internal void <Start>b__4_0(InputAction.CallbackContext e)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1C5BB90", Offset = "0x1C5BB90", VA = "0x1C5BB90")]
		internal void <Start>b__4_1(InputAction.CallbackContext e)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1C5BC04", Offset = "0x1C5BC04", VA = "0x1C5BC04")]
		internal void <Start>b__4_2(InputAction.CallbackContext e)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1C5BC78", Offset = "0x1C5BC78", VA = "0x1C5BC78")]
		internal void <Start>b__4_3(InputAction.CallbackContext e)
		{
		}
	}

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public InputActionProperty Key1;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public InputActionProperty Key2;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public InputActionProperty Key3;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public InputActionProperty Key4;

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1C05880", Offset = "0x1C05880", VA = "0x1C05880")]
	private void Start()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1C05C0C", Offset = "0x1C05C0C", VA = "0x1C05C0C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1C05C10", Offset = "0x1C05C10", VA = "0x1C05C10")]
	public XRKeyTest()
	{
	}
}
namespace Framework.VR
{
	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x75D388", Offset = "0x75D388")]
	public class XRSelectable : UIBehaviour
	{
		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RectOffset ColliderPadding;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<GameObject> OnClick;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Selectable mSelectable;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private IPointerClickHandler mPointerClickHandler;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoxCollider mCollider;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform rectTransform;

		[Token(Token = "0x17000001")]
		public Selectable Selectable
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x1C07418", Offset = "0x1C07418", VA = "0x1C07418")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		public IPointerClickHandler PointerClickHandler
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x1C07420", Offset = "0x1C07420", VA = "0x1C07420")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1C07428", Offset = "0x1C07428", VA = "0x1C07428", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1C078F0", Offset = "0x1C078F0", VA = "0x1C078F0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1C07928", Offset = "0x1C07928", VA = "0x1C07928", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1C07960", Offset = "0x1C07960", VA = "0x1C07960", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1C07528", Offset = "0x1C07528", VA = "0x1C07528")]
		public void CreateActivator()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1C07988", Offset = "0x1C07988", VA = "0x1C07988")]
		public XRSelectable()
		{
		}
	}
}
namespace Framework.Video
{
	[Token(Token = "0x200000D")]
	public class AVProVideoPlayer : BaseVideoPlayer
	{
		[StructLayout(3)]
		[Token(Token = "0x200000E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D410", Offset = "0x75D410")]
		private struct <Prepare>d__36 : IAsyncStateMachine
		{
			[Token(Token = "0x400002E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400002F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000030")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AVProVideoPlayer <>4__this;

			[Token(Token = "0x4000031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SourceInfo info;

			[Token(Token = "0x4000032")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public CancellationToken cancellationToken;

			[Token(Token = "0x4000033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask.Awaiter <>u__1;

			[Token(Token = "0x6000051")]
			[Address(RVA = "0x1C09E04", Offset = "0x1C09E04", VA = "0x1C09E04", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000052")]
			[Address(RVA = "0x1C0A5A0", Offset = "0x1C0A5A0", VA = "0x1C0A5A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x200000F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D420", Offset = "0x75D420")]
		private sealed class <>c__DisplayClass43_0
		{
			[Token(Token = "0x4000034")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AVProVideoPlayer <>4__this;

			[Token(Token = "0x4000035")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public long lastTime;

			[Token(Token = "0x4000036")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public double start;

			[Token(Token = "0x4000037")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public double tempEnd;

			[Token(Token = "0x6000053")]
			[Address(RVA = "0x1C09B70", Offset = "0x1C09B70", VA = "0x1C09B70")]
			public <>c__DisplayClass43_0()
			{
			}

			[Token(Token = "0x6000054")]
			[Address(RVA = "0x1C09B78", Offset = "0x1C09B78", VA = "0x1C09B78")]
			internal void <Play>b__0(float f)
			{
			}
		}

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E1DC", Offset = "0x75E1DC")]
		private readonly GameObject <gameObject>k__BackingField;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private SourceInfo m_Info;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private string m_Name;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private MediaPlayer m_Player;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Texture m_RenderTex;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private uint m_PlayingTimer;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private bool m_IsBuffing;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float m_Chahe;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private bool m_IsSeeking;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static uint m_InstanceID;

		[Token(Token = "0x17000003")]
		public override GameObject gameObject
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x1C159E8", Offset = "0x1C159E8", VA = "0x1C159E8", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76070C", Offset = "0x76070C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		public override string Name
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x1C159F0", Offset = "0x1C159F0", VA = "0x1C159F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		public override bool IsLoop
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x1C159F8", Offset = "0x1C159F8", VA = "0x1C159F8", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x1C15A14", Offset = "0x1C15A14", VA = "0x1C15A14", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public override float PlaybackSpeed
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x1C15A34", Offset = "0x1C15A34", VA = "0x1C15A34", Slot = "8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x1C15A50", Offset = "0x1C15A50", VA = "0x1C15A50", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public override float Volume
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x1C15A6C", Offset = "0x1C15A6C", VA = "0x1C15A6C", Slot = "10")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x1C15A8C", Offset = "0x1C15A8C", VA = "0x1C15A8C", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public override float Progress
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x1C15AAC", Offset = "0x1C15AAC", VA = "0x1C15AAC", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000009")]
		public override long ClockTime
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x1C15C48", Offset = "0x1C15C48", VA = "0x1C15C48", Slot = "13")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x1700000A")]
		public override long Length
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x1C15D58", Offset = "0x1C15D58", VA = "0x1C15D58", Slot = "14")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x1700000B")]
		public override bool IsSeeking
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x1C15E64", Offset = "0x1C15E64", VA = "0x1C15E64", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000C")]
		public override Texture RenderTarget
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x1C15E6C", Offset = "0x1C15E6C", VA = "0x1C15E6C", Slot = "16")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x1C15E74", Offset = "0x1C15E74", VA = "0x1C15E74", Slot = "17")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1C15EFC", Offset = "0x1C15EFC", VA = "0x1C15EFC")]
		internal AVProVideoPlayer()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1C162D4", Offset = "0x1C162D4", VA = "0x1C162D4")]
		private void OnPlayerEvents(MediaPlayer player, MediaPlayerEvent.EventType eventType, ErrorCode code)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1C165FC", Offset = "0x1C165FC", VA = "0x1C165FC", Slot = "18")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x76071C", Offset = "0x76071C")]
		internal override UniTask Prepare(SourceInfo info, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1C167BC", Offset = "0x1C167BC", VA = "0x1C167BC", Slot = "20")]
		public override bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1C168D4", Offset = "0x1C168D4", VA = "0x1C168D4", Slot = "21")]
		public override bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1C169F4", Offset = "0x1C169F4", VA = "0x1C169F4", Slot = "22")]
		public override void Stop()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1C16B00", Offset = "0x1C16B00", VA = "0x1C16B00", Slot = "23")]
		public override void Seek(double time)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x1C16BD4", Offset = "0x1C16BD4", VA = "0x1C16BD4", Slot = "25")]
		public override void Release()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1C16D24", Offset = "0x1C16D24", VA = "0x1C16D24", Slot = "24")]
		public override void Replay()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1C16E1C", Offset = "0x1C16E1C", VA = "0x1C16E1C", Slot = "19")]
		internal override void Play(double start, double end)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1C17400", Offset = "0x1C17400", VA = "0x1C17400")]
		private static void LogError(string message)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1C17520", Offset = "0x1C17520", VA = "0x1C17520")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76077C", Offset = "0x76077C")]
		private bool <Prepare>b__36_0()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000010")]
	public enum EOut
	{
		[Token(Token = "0x4000039")]
		Skybox,
		[Token(Token = "0x400003A")]
		Camera,
		[Token(Token = "0x400003B")]
		Sphere
	}
	[Token(Token = "0x2000011")]
	public abstract class BaseVideoPlayer
	{
		[Token(Token = "0x2000012")]
		public enum EVideoPlayState
		{
			[Token(Token = "0x400004C")]
			Free,
			[Token(Token = "0x400004D")]
			Prepare,
			[Token(Token = "0x400004E")]
			Ready,
			[Token(Token = "0x400004F")]
			Playing,
			[Token(Token = "0x4000050")]
			Pause,
			[Token(Token = "0x4000051")]
			Stop
		}

		[StructLayout(3)]
		[Token(Token = "0x2000013")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D430", Offset = "0x75D430")]
		private struct <AsyncWaitForCompletion>d__54 : IAsyncStateMachine
		{
			[Token(Token = "0x4000052")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000053")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000054")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BaseVideoPlayer <>4__this;

			[Token(Token = "0x4000055")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter <>u__1;

			[Token(Token = "0x6000078")]
			[Address(RVA = "0x1C0A5AC", Offset = "0x1C0A5AC", VA = "0x1C0A5AC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000079")]
			[Address(RVA = "0x1C0A994", Offset = "0x1C0A994", VA = "0x1C0A994", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static GameObject m_Root;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static GameObject m_Sphere;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E1EC", Offset = "0x75E1EC")]
		private EVideoPlayState <State>k__BackingField;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E1FC", Offset = "0x75E1FC")]
		private long <BeginTime>k__BackingField;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E20C", Offset = "0x75E20C")]
		private long <EndTime>k__BackingField;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected UniTask m_Check;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<BaseVideoPlayer> preparedEvent;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action<BaseVideoPlayer> playEvent;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Action<BaseVideoPlayer> pauseEvent;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Action<BaseVideoPlayer> stopEvent;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Action<BaseVideoPlayer> replayEvent;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Action<BaseVideoPlayer, long> playingEvent;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Action<BaseVideoPlayer, float> bufferingEvent;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Action<BaseVideoPlayer, Texture> textureEvent;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Action<BaseVideoPlayer> seekCompleted;

		[Token(Token = "0x1700000D")]
		public abstract GameObject gameObject
		{
			[Token(Token = "0x6000055")]
			get;
		}

		[Token(Token = "0x1700000E")]
		public abstract string Name
		{
			[Token(Token = "0x6000056")]
			get;
		}

		[Token(Token = "0x1700000F")]
		public bool IsPreparing
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x1C18704", Offset = "0x1C18704", VA = "0x1C18704")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000010")]
		public bool IsPrepared
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x1C18714", Offset = "0x1C18714", VA = "0x1C18714")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000011")]
		public bool IsPlaying
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x1C18724", Offset = "0x1C18724", VA = "0x1C18724")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000012")]
		public abstract bool IsLoop
		{
			[Token(Token = "0x600005A")]
			get;
			[Token(Token = "0x600005B")]
			set;
		}

		[Token(Token = "0x17000013")]
		public EVideoPlayState State
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x1C18738", Offset = "0x1C18738", VA = "0x1C18738")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76079C", Offset = "0x76079C")]
			get
			{
				return default(EVideoPlayState);
			}
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x1C18740", Offset = "0x1C18740", VA = "0x1C18740")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7607AC", Offset = "0x7607AC")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public abstract float PlaybackSpeed
		{
			[Token(Token = "0x600005E")]
			get;
			[Token(Token = "0x600005F")]
			set;
		}

		[Token(Token = "0x17000015")]
		public abstract float Volume
		{
			[Token(Token = "0x6000060")]
			get;
			[Token(Token = "0x6000061")]
			set;
		}

		[Token(Token = "0x17000016")]
		public abstract float Progress
		{
			[Token(Token = "0x6000062")]
			get;
		}

		[Token(Token = "0x17000017")]
		public abstract long ClockTime
		{
			[Token(Token = "0x6000063")]
			get;
		}

		[Token(Token = "0x17000018")]
		public abstract long Length
		{
			[Token(Token = "0x6000064")]
			get;
		}

		[Token(Token = "0x17000019")]
		public long BeginTime
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x1C18748", Offset = "0x1C18748", VA = "0x1C18748")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7607BC", Offset = "0x7607BC")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x1C18750", Offset = "0x1C18750", VA = "0x1C18750")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7607CC", Offset = "0x7607CC")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public long EndTime
		{
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x1C18758", Offset = "0x1C18758", VA = "0x1C18758")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7607DC", Offset = "0x7607DC")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x1C18760", Offset = "0x1C18760", VA = "0x1C18760")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7607EC", Offset = "0x7607EC")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public abstract bool IsSeeking
		{
			[Token(Token = "0x6000069")]
			get;
		}

		[Token(Token = "0x1700001C")]
		public abstract Texture RenderTarget
		{
			[Token(Token = "0x600006A")]
			get;
			[Token(Token = "0x600006B")]
			protected set;
		}

		[Token(Token = "0x600006C")]
		internal abstract UniTask Prepare(SourceInfo info, CancellationToken cancellationToken);

		[Token(Token = "0x600006D")]
		internal abstract void Play(double start, double end);

		[Token(Token = "0x600006E")]
		public abstract bool Resume();

		[Token(Token = "0x600006F")]
		public abstract bool Pause();

		[Token(Token = "0x6000070")]
		public abstract void Stop();

		[Token(Token = "0x6000071")]
		public abstract void Seek(double time);

		[Token(Token = "0x6000072")]
		public abstract void Replay();

		[Token(Token = "0x6000073")]
		public abstract void Release();

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1C18768", Offset = "0x1C18768", VA = "0x1C18768")]
		public void Copy(BaseVideoPlayer player)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1C18A7C", Offset = "0x1C18A7C", VA = "0x1C18A7C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7607FC", Offset = "0x7607FC")]
		public UniTask AsyncWaitForCompletion()
		{
			return default(UniTask);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1C18C00", Offset = "0x1C18C00", VA = "0x1C18C00")]
		public void RemoveAllListener()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1C162C4", Offset = "0x1C162C4", VA = "0x1C162C4")]
		protected BaseVideoPlayer()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public enum EDefinition
	{
		[Token(Token = "0x4000057")]
		Dx4K,
		[Token(Token = "0x4000058")]
		Dx8K
	}
	[Token(Token = "0x2000015")]
	public readonly struct SourceInfo
	{
		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E21C", Offset = "0x75E21C")]
		private readonly string <Name>k__BackingField;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E22C", Offset = "0x75E22C")]
		private readonly VideoSource <Source>k__BackingField;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E23C", Offset = "0x75E23C")]
		private readonly VideoClip <Clip>k__BackingField;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E24C", Offset = "0x75E24C")]
		private readonly string <Url>k__BackingField;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E25C", Offset = "0x75E25C")]
		private readonly double <Duration>k__BackingField;

		[Token(Token = "0x1700001D")]
		public string Name
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x9E1360", Offset = "0x9E1360", VA = "0x9E1360")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76086C", Offset = "0x76086C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		public VideoSource Source
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x9E1368", Offset = "0x9E1368", VA = "0x9E1368")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76087C", Offset = "0x76087C")]
			get
			{
				return default(VideoSource);
			}
		}

		[Token(Token = "0x1700001F")]
		public VideoClip Clip
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x9E1370", Offset = "0x9E1370", VA = "0x9E1370")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76088C", Offset = "0x76088C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		public string Url
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x9E1378", Offset = "0x9E1378", VA = "0x9E1378")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76089C", Offset = "0x76089C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		public double Duration
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x9E1380", Offset = "0x9E1380", VA = "0x9E1380")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7608AC", Offset = "0x7608AC")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x9E1388", Offset = "0x9E1388", VA = "0x9E1388")]
		public SourceInfo(string name, VideoClip clip, double duration = 0.0)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x9E1428", Offset = "0x9E1428", VA = "0x9E1428")]
		public SourceInfo(string name, string uri, double duration = 0.0)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x9E1488", Offset = "0x9E1488", VA = "0x9E1488", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000016")]
	public class UnityVideoPlayer : BaseVideoPlayer
	{
		[StructLayout(3)]
		[Token(Token = "0x2000017")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D450", Offset = "0x75D450")]
		private struct <Prepare>d__36 : IAsyncStateMachine
		{
			[Token(Token = "0x4000069")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400006A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400006B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UnityVideoPlayer <>4__this;

			[Token(Token = "0x400006C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SourceInfo info;

			[Token(Token = "0x400006D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public CancellationToken cancellationToken;

			[Token(Token = "0x400006E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask.Awaiter <>u__1;

			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x1C50A7C", Offset = "0x1C50A7C", VA = "0x1C50A7C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x1C51110", Offset = "0x1C51110", VA = "0x1C51110", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000018")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D460", Offset = "0x75D460")]
		private sealed class <>c__DisplayClass49_0
		{
			[Token(Token = "0x400006F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UnityVideoPlayer <>4__this;

			[Token(Token = "0x4000070")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public long lastTime;

			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x1C508EC", Offset = "0x1C508EC", VA = "0x1C508EC")]
			public <>c__DisplayClass49_0()
			{
			}

			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x1C508F4", Offset = "0x1C508F4", VA = "0x1C508F4")]
			internal void <Update>b__0(float f)
			{
			}
		}

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E26C", Offset = "0x75E26C")]
		private readonly GameObject <gameObject>k__BackingField;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string m_Name;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private VideoPlayer m_Player;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AudioSource m_Audio;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private uint m_TimerId;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RenderTexture m_RenderTexture;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Camera m_MainCamera;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private double tempStart;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private double tempEnd;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool m_IsSeeking;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static uint m_InstanceID;

		[Token(Token = "0x17000022")]
		public override GameObject gameObject
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x9ED424", Offset = "0x9ED424", VA = "0x9ED424", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7608BC", Offset = "0x7608BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		public override string Name
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x9ED42C", Offset = "0x9ED42C", VA = "0x9ED42C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		public override float PlaybackSpeed
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x9ED434", Offset = "0x9ED434", VA = "0x9ED434", Slot = "8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x9ED450", Offset = "0x9ED450", VA = "0x9ED450", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public override float Volume
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x9ED46C", Offset = "0x9ED46C", VA = "0x9ED46C", Slot = "10")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x9ED488", Offset = "0x9ED488", VA = "0x9ED488", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public override float Progress
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x9ED4A4", Offset = "0x9ED4A4", VA = "0x9ED4A4", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000027")]
		public override long ClockTime
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x9ED53C", Offset = "0x9ED53C", VA = "0x9ED53C", Slot = "13")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000028")]
		public override long Length
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x9ED5C8", Offset = "0x9ED5C8", VA = "0x9ED5C8", Slot = "14")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000029")]
		public override bool IsSeeking
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x9ED654", Offset = "0x9ED654", VA = "0x9ED654", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002A")]
		public override Texture RenderTarget
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x9ED65C", Offset = "0x9ED65C", VA = "0x9ED65C", Slot = "16")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x9ED664", Offset = "0x9ED664", VA = "0x9ED664", Slot = "17")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public override bool IsLoop
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x9ED778", Offset = "0x9ED778", VA = "0x9ED778", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x9ED794", Offset = "0x9ED794", VA = "0x9ED794", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x9ED7B4", Offset = "0x9ED7B4", VA = "0x9ED7B4")]
		internal UnityVideoPlayer()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x9EE13C", Offset = "0x9EE13C", VA = "0x9EE13C", Slot = "18")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7608CC", Offset = "0x7608CC")]
		internal override UniTask Prepare(SourceInfo info, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x9EE2FC", Offset = "0x9EE2FC", VA = "0x9EE2FC", Slot = "19")]
		internal override void Play(double start, double end)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x9EE79C", Offset = "0x9EE79C", VA = "0x9EE79C", Slot = "20")]
		public override bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x9EE7EC", Offset = "0x9EE7EC", VA = "0x9EE7EC", Slot = "21")]
		public override bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x9EE878", Offset = "0x9EE878", VA = "0x9EE878", Slot = "22")]
		public override void Stop()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x9EE8F4", Offset = "0x9EE8F4", VA = "0x9EE8F4", Slot = "23")]
		public override void Seek(double interval)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x9EE91C", Offset = "0x9EE91C", VA = "0x9EE91C", Slot = "24")]
		public override void Replay()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x9EEAE0", Offset = "0x9EEAE0", VA = "0x9EEAE0", Slot = "25")]
		public override void Release()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x9EED0C", Offset = "0x9EED0C", VA = "0x9EED0C")]
		private void OnPrepareCompleted(VideoPlayer player)
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x9EED80", Offset = "0x9EED80", VA = "0x9EED80")]
		private void OnStarted(VideoPlayer player)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x9EEDFC", Offset = "0x9EEDFC", VA = "0x9EEDFC")]
		private void OnSeekComplete(VideoPlayer player)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x9EEE68", Offset = "0x9EEE68", VA = "0x9EEE68")]
		private void OnFrameReady(VideoPlayer source, long frameIdx)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x9EEF2C", Offset = "0x9EEF2C", VA = "0x9EEF2C")]
		private void OnLoopPointReached(VideoPlayer player)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x9EE9B4", Offset = "0x9EE9B4", VA = "0x9EE9B4")]
		private void Update()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x9EDF5C", Offset = "0x9EDF5C", VA = "0x9EDF5C")]
		public RenderTexture GetRenderTexture(int width = 4096, int height = 4096)
		{
			return null;
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x9EE70C", Offset = "0x9EE70C", VA = "0x9EE70C")]
		private static void LogError(string message)
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x9EEF3C", Offset = "0x9EEF3C", VA = "0x9EEF3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76092C", Offset = "0x76092C")]
		private bool <Prepare>b__36_0()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x75D470", Offset = "0x75D470")]
	public class VideoConfig : ScriptableObject
	{
		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VideoConfig _instance;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_Enable;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool CloudPlayback;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public EOut Out;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool IsLog;

		[Token(Token = "0x1700002C")]
		public static VideoConfig Instance
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x9DD440", Offset = "0x9DD440", VA = "0x9DD440")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public bool Enable
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x9F22F8", Offset = "0x9F22F8", VA = "0x9F22F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x9F2300", Offset = "0x9F2300", VA = "0x9F2300")]
		public VideoConfig()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class VideoDownloadController
	{
		[Serializable]
		[Token(Token = "0x200001B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D4B4", Offset = "0x75D4B4")]
		private sealed class <>c
		{
			[Token(Token = "0x4000079")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400007A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<FileDownload, GameAssetsFileInfo> <>9__8_0;

			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x1C56C64", Offset = "0x1C56C64", VA = "0x1C56C64")]
			public <>c()
			{
			}

			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x1C56C6C", Offset = "0x1C56C6C", VA = "0x1C56C6C")]
			internal GameAssetsFileInfo <GetOrCreateTask>b__8_0(FileDownload x)
			{
				return default(GameAssetsFileInfo);
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200001C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D4C4", Offset = "0x75D4C4")]
		private struct <TryGetSourceInfo>d__19 : IAsyncStateMachine
		{
			[Token(Token = "0x400007B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400007C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TupleElementNamesAttribute", RVA = "0x75E28C", Offset = "0x75E28C")]
			public AsyncUniTaskMethodBuilder<(bool, SourceInfo)> <>t__builder;

			[Token(Token = "0x400007D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string videoName;

			[Token(Token = "0x400007E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string dirName;

			[Token(Token = "0x400007F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public CancellationToken token;

			[Token(Token = "0x4000080")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private UniTask<VideoClip>.Awaiter <>u__1;

			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x1C57580", Offset = "0x1C57580", VA = "0x1C57580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x1C57EE8", Offset = "0x1C57EE8", VA = "0x1C57EE8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200001D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D4D4", Offset = "0x75D4D4")]
		private struct <CheckServerFilesIntegrity>d__22 : IAsyncStateMachine
		{
			[Token(Token = "0x4000081")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000082")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			[Token(Token = "0x4000083")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private List<GameAssetsFileInfo>.Enumerator <>7__wrap1;

			[Token(Token = "0x4000084")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private GameAssetsFileInfo <fileInfo>5__3;

			[Token(Token = "0x4000085")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private UniTask<long>.Awaiter <>u__1;

			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x1C56C90", Offset = "0x1C56C90", VA = "0x1C56C90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x1C57574", Offset = "0x1C57574", VA = "0x1C57574", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<int, List<string>> chapterDict;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<int, Dictionary<EDefinition, DownloadTask>> taskDict;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static bool IsInit;

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x9F2308", Offset = "0x9F2308", VA = "0x9F2308")]
		private VideoDownloadController()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x9F2310", Offset = "0x9F2310", VA = "0x9F2310")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x76094C", Offset = "0x76094C")]
		public static void Init()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x9F264C", Offset = "0x9F264C", VA = "0x9F264C")]
		public static bool Check(int chapter, EDefinition def)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x9F2A88", Offset = "0x9F2A88", VA = "0x9F2A88")]
		public static void Dispose(int chapter, EDefinition def)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x9F2B7C", Offset = "0x9F2B7C", VA = "0x9F2B7C")]
		public static void Delete(int chapter, EDefinition def)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x9F3030", Offset = "0x9F3030", VA = "0x9F3030")]
		public static DownloadTask GetOrCreateTask(int chapter, EDefinition def)
		{
			return null;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x9F35EC", Offset = "0x9F35EC", VA = "0x9F35EC")]
		public static bool TryGetTask(int chapter, EDefinition def, out DownloadTask task)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x9F3710", Offset = "0x9F3710", VA = "0x9F3710")]
		public static long GetDownloadSize(int chapter, EDefinition definition)
		{
			return default(long);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x9F38FC", Offset = "0x9F38FC", VA = "0x9F38FC")]
		public static long GetRealDownloadSize(int chapter, EDefinition definition)
		{
			return default(long);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x9F3D90", Offset = "0x9F3D90", VA = "0x9F3D90")]
		public static long GetLocalFileSize(int chapter, EDefinition definition)
		{
			return default(long);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x9F4164", Offset = "0x9F4164", VA = "0x9F4164")]
		public static long GetLocalDownloadFileSize(EDefinition def)
		{
			return default(long);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x9F2EE0", Offset = "0x9F2EE0", VA = "0x9F2EE0")]
		public static GameAssetsFileInfo GetRemoteVideoInfo(string videoName, [Optional] string dirName)
		{
			return default(GameAssetsFileInfo);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x9F3CB0", Offset = "0x9F3CB0", VA = "0x9F3CB0")]
		public static string GetPersistentDataPath(string videoName, [Optional] string dirName)
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x9F4608", Offset = "0x9F4608", VA = "0x9F4608")]
		public static UniTask<(bool, SourceInfo)> TryGetSourceInfo(string videoName, [Optional] CancellationToken token)
		{
			return default(UniTask<(bool, SourceInfo)>);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x9F47BC", Offset = "0x9F47BC", VA = "0x9F47BC")]
		public static UniTask<(bool, SourceInfo)> TryGetSourceInfo(string videoName, EDefinition definition, [Optional] CancellationToken token)
		{
			return default(UniTask<(bool, SourceInfo)>);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x9F2894", Offset = "0x9F2894", VA = "0x9F2894")]
		public static bool HasVideo(string videoName, string dirName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x9F46A0", Offset = "0x9F46A0", VA = "0x9F46A0")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x760960", Offset = "0x760960")]
		public static UniTask<(bool, SourceInfo)> TryGetSourceInfo(string videoName, string dirName, [Optional] CancellationToken token)
		{
			return default(UniTask<(bool, SourceInfo)>);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x9F2830", Offset = "0x9F2830", VA = "0x9F2830")]
		public static string DefinitionToString(EDefinition definition)
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x9F4868", Offset = "0x9F4868", VA = "0x9F4868")]
		public static EDefinition StringToDefinition(string path)
		{
			return default(EDefinition);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x9F4960", Offset = "0x9F4960", VA = "0x9F4960")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7609C0", Offset = "0x7609C0")]
		private static UniTaskVoid CheckServerFilesIntegrity()
		{
			return default(UniTaskVoid);
		}
	}
	[Token(Token = "0x200001E")]
	public class VideoHelper : MonoBehaviour
	{
		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_VideoName;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_ClockTime;

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1BF82D0", Offset = "0x1BF82D0", VA = "0x1BF82D0")]
		private void Update()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1BF8404", Offset = "0x1BF8404", VA = "0x1BF8404")]
		public VideoHelper()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public enum EVideoPlayMode
	{
		[Token(Token = "0x4000089")]
		Local,
		[Token(Token = "0x400008A")]
		Remote
	}
	[Token(Token = "0x2000020")]
	public enum EVideoAngle
	{
		[Token(Token = "0x400008C")]
		Degrees360,
		[Token(Token = "0x400008D")]
		Degrees180
	}
	[Token(Token = "0x2000021")]
	public enum EVideoLayout
	{
		[Token(Token = "0x400008F")]
		None,
		[Token(Token = "0x4000090")]
		SideBySide,
		[Token(Token = "0x4000091")]
		OverUnder
	}
	[Token(Token = "0x2000022")]
	public enum ERemotePlayer
	{
		[Token(Token = "0x4000093")]
		UMP,
		[Token(Token = "0x4000094")]
		AVPro
	}
	[Token(Token = "0x2000023")]
	public class VRVideoPlayer
	{
		[StructLayout(3)]
		[Token(Token = "0x2000024")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D4E4", Offset = "0x75D4E4")]
		private struct <Prepare>d__77 : IAsyncStateMachine
		{
			[Token(Token = "0x40000A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40000A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SourceInfo info;

			[Token(Token = "0x40000A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public CancellationToken cancellationToken;

			[Token(Token = "0x40000A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private BaseVideoPlayer <player>5__2;

			[Token(Token = "0x40000A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter <>u__1;

			[Token(Token = "0x40000AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask.Awaiter <>u__2;

			[Token(Token = "0x600010B")]
			[Address(RVA = "0x1C53F0C", Offset = "0x1C53F0C", VA = "0x1C53F0C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600010C")]
			[Address(RVA = "0x1C54500", Offset = "0x1C54500", VA = "0x1C54500", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000025")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D4F4", Offset = "0x75D4F4")]
		private struct <Play>d__78 : IAsyncStateMachine
		{
			[Token(Token = "0x40000AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40000AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EVideoAngle angle;

			[Token(Token = "0x40000AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public EVideoLayout layout;

			[Token(Token = "0x40000AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SourceInfo info;

			[Token(Token = "0x40000B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public CancellationToken cancellationToken;

			[Token(Token = "0x40000B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public double startTime;

			[Token(Token = "0x40000B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public double endTime;

			[Token(Token = "0x40000B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private BaseVideoPlayer <player>5__2;

			[Token(Token = "0x40000B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private UniTask.Awaiter <>u__1;

			[Token(Token = "0x600010D")]
			[Address(RVA = "0x1C536DC", Offset = "0x1C536DC", VA = "0x1C536DC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600010E")]
			[Address(RVA = "0x1C53F00", Offset = "0x1C53F00", VA = "0x1C53F00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000026")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D504", Offset = "0x75D504")]
		private sealed class <>c
		{
			[Token(Token = "0x40000B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<BaseVideoPlayer> <>9__83_0;

			[Token(Token = "0x40000B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Predicate<BaseVideoPlayer> <>9__83_1;

			[Token(Token = "0x40000B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Action<BaseVideoPlayer, Texture> <>9__84_1;

			[Token(Token = "0x6000110")]
			[Address(RVA = "0x1C52180", Offset = "0x1C52180", VA = "0x1C52180")]
			public <>c()
			{
			}

			[Token(Token = "0x6000111")]
			[Address(RVA = "0x1C52188", Offset = "0x1C52188", VA = "0x1C52188")]
			internal bool <GetPlayer>b__83_0(BaseVideoPlayer x)
			{
				return default(bool);
			}

			[Token(Token = "0x6000112")]
			[Address(RVA = "0x1C52204", Offset = "0x1C52204", VA = "0x1C52204")]
			internal bool <GetPlayer>b__83_1(BaseVideoPlayer x)
			{
				return default(bool);
			}

			[Token(Token = "0x6000113")]
			[Address(RVA = "0x1C52280", Offset = "0x1C52280", VA = "0x1C52280")]
			internal void <CreatePlayer>b__84_1(BaseVideoPlayer sender, Texture tex)
			{
			}
		}

		[Token(Token = "0x2000027")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D514", Offset = "0x75D514")]
		private sealed class <>c__DisplayClass84_0
		{
			[Token(Token = "0x40000B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public BaseVideoPlayer player;

			[Token(Token = "0x6000114")]
			[Address(RVA = "0x1C52330", Offset = "0x1C52330", VA = "0x1C52330")]
			public <>c__DisplayClass84_0()
			{
			}

			[Token(Token = "0x6000115")]
			[Address(RVA = "0x1C52338", Offset = "0x1C52338", VA = "0x1C52338")]
			internal void <CreatePlayer>b__0(BaseVideoPlayer sender)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000028")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D524", Offset = "0x75D524")]
		private struct <SetBackGround>d__88 : IAsyncStateMachine
		{
			[Token(Token = "0x40000BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40000BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string texName;

			[Token(Token = "0x40000BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Texture <tex>5__2;

			[Token(Token = "0x40000BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<Texture>.Awaiter <>u__1;

			[Token(Token = "0x6000116")]
			[Address(RVA = "0x1C54B3C", Offset = "0x1C54B3C", VA = "0x1C54B3C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000117")]
			[Address(RVA = "0x1C552B0", Offset = "0x1C552B0", VA = "0x1C552B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000029")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D534", Offset = "0x75D534")]
		private struct <SetBackGround>d__89 : IAsyncStateMachine
		{
			[Token(Token = "0x40000BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40000C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Texture texture;

			[Token(Token = "0x40000C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UniTask<Material>.Awaiter <>u__1;

			[Token(Token = "0x6000118")]
			[Address(RVA = "0x1C552BC", Offset = "0x1C552BC", VA = "0x1C552BC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000119")]
			[Address(RVA = "0x1C5592C", Offset = "0x1C5592C", VA = "0x1C5592C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200002A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D544", Offset = "0x75D544")]
		private struct <SetHighlightTex>d__91 : IAsyncStateMachine
		{
			[Token(Token = "0x40000C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40000C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Texture2D[] textures;

			[Token(Token = "0x40000C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Texture2D <tex>5__2;

			[Token(Token = "0x40000C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <i>5__3;

			[Token(Token = "0x40000C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Material>.Awaiter <>u__1;

			[Token(Token = "0x600011A")]
			[Address(RVA = "0x1C55F4C", Offset = "0x1C55F4C", VA = "0x1C55F4C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600011B")]
			[Address(RVA = "0x1C565E0", Offset = "0x1C565E0", VA = "0x1C565E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200002B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D554", Offset = "0x75D554")]
		private struct <SetHighlightTex>d__93 : IAsyncStateMachine
		{
			[Token(Token = "0x40000C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40000CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int index;

			[Token(Token = "0x40000CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Texture2D tex;

			[Token(Token = "0x40000CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<Material>.Awaiter <>u__1;

			[Token(Token = "0x600011C")]
			[Address(RVA = "0x1C565EC", Offset = "0x1C565EC", VA = "0x1C565EC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600011D")]
			[Address(RVA = "0x1C56BF4", Offset = "0x1C56BF4", VA = "0x1C56BF4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200002C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D564", Offset = "0x75D564")]
		private struct <SetHighlightAlpha>d__94 : IAsyncStateMachine
		{
			[Token(Token = "0x40000CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40000D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int index;

			[Token(Token = "0x40000D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float alpha;

			[Token(Token = "0x40000D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UniTask<Material>.Awaiter <>u__1;

			[Token(Token = "0x600011E")]
			[Address(RVA = "0x1C55938", Offset = "0x1C55938", VA = "0x1C55938", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600011F")]
			[Address(RVA = "0x1C55F40", Offset = "0x1C55F40", VA = "0x1C55F40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200002D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D574", Offset = "0x75D574")]
		private struct <SetAllHighlightAlpha>d__95 : IAsyncStateMachine
		{
			[Token(Token = "0x40000D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40000D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float alpha;

			[Token(Token = "0x40000D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UniTask<Material>.Awaiter <>u__1;

			[Token(Token = "0x6000120")]
			[Address(RVA = "0x1C5450C", Offset = "0x1C5450C", VA = "0x1C5450C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000121")]
			[Address(RVA = "0x1C54B30", Offset = "0x1C54B30", VA = "0x1C54B30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200002E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D584", Offset = "0x75D584")]
		private struct <ClearAllHighlight>d__96 : IAsyncStateMachine
		{
			[Token(Token = "0x40000D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40000D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private UniTask<Material>.Awaiter <>u__1;

			[Token(Token = "0x6000122")]
			[Address(RVA = "0x1C5258C", Offset = "0x1C5258C", VA = "0x1C5258C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000123")]
			[Address(RVA = "0x1C52BAC", Offset = "0x1C52BAC", VA = "0x1C52BAC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200002F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D594", Offset = "0x75D594")]
		private struct <GetSkyMat>d__97 : IAsyncStateMachine
		{
			[Token(Token = "0x40000DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Material> <>t__builder;

			[Token(Token = "0x40000DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter <>u__1;

			[Token(Token = "0x6000124")]
			[Address(RVA = "0x1C531EC", Offset = "0x1C531EC", VA = "0x1C531EC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000125")]
			[Address(RVA = "0x1C53680", Offset = "0x1C53680", VA = "0x1C53680", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000030")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D5A4", Offset = "0x75D5A4")]
		private struct <CrossFade>d__98 : IAsyncStateMachine
		{
			[Token(Token = "0x40000DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40000DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Color <target>5__2;

			[Token(Token = "0x40000E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter <>u__1;

			[Token(Token = "0x6000126")]
			[Address(RVA = "0x1C52BB8", Offset = "0x1C52BB8", VA = "0x1C52BB8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000127")]
			[Address(RVA = "0x1C531E0", Offset = "0x1C531E0", VA = "0x1C531E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<BaseVideoPlayer> m_Pool;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<string, Texture2D> m_TexMapping;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static BaseVideoPlayer m_Player;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static bool m_IsInit;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private static bool m_MultiPlayerCache;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		private static bool m_GlobalPause;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		private static bool m_LocalPause;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static bool m_BlackScreen;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		private static bool m_IsCrossFade;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		private static bool m_IsLog;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static GameObject m_Root;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static GameObject m_Sphere;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Material m_SkyMat;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static Texture m_SkyTex;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static Camera m_MainCamera;

		[Token(Token = "0x1700002E")]
		public static BaseVideoPlayer Player
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x9EEF4C", Offset = "0x9EEF4C", VA = "0x9EEF4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public static bool AbleToPlay
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x9EF730", Offset = "0x9EF730", VA = "0x9EF730")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000030")]
		public static float PlaybackSpeed
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x9EF7D8", Offset = "0x9EF7D8", VA = "0x9EF7D8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x9EF884", Offset = "0x9EF884", VA = "0x9EF884")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public static float Volume
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x9EF940", Offset = "0x9EF940", VA = "0x9EF940")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x9DDC0C", Offset = "0x9DDC0C", VA = "0x9DDC0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public static bool IsLoop
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x9EF9EC", Offset = "0x9EF9EC", VA = "0x9EF9EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x9EB5EC", Offset = "0x9EB5EC", VA = "0x9EB5EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public static EVideoAngle VideoAngle
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x9EFA98", Offset = "0x9EFA98", VA = "0x9EFA98")]
			get
			{
				return default(EVideoAngle);
			}
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x9EFBE0", Offset = "0x9EFBE0", VA = "0x9EFBE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public static EVideoLayout VideoLayout
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x9EFCF0", Offset = "0x9EFCF0", VA = "0x9EFCF0")]
			get
			{
				return default(EVideoLayout);
			}
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x9EFE38", Offset = "0x9EFE38", VA = "0x9EFE38")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public static float Rotation
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x9EFF48", Offset = "0x9EFF48", VA = "0x9EFF48")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x9F0048", Offset = "0x9F0048", VA = "0x9F0048")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public static bool MultiPlayerCache
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x9F0158", Offset = "0x9F0158", VA = "0x9F0158")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x9F01BC", Offset = "0x9F01BC", VA = "0x9F01BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public static bool BlackScreen
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x9F0228", Offset = "0x9F0228", VA = "0x9F0228")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x9F028C", Offset = "0x9F028C", VA = "0x9F028C")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public static bool IsCrossFade
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x9F03A8", Offset = "0x9F03A8", VA = "0x9F03A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x9F040C", Offset = "0x9F040C", VA = "0x9F040C")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public static bool IsLog
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x9F0498", Offset = "0x9F0498", VA = "0x9F0498")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x9F04FC", Offset = "0x9F04FC", VA = "0x9F04FC")]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public static event Action<BaseVideoPlayer> preparedEvent
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x9EEFB0", Offset = "0x9EEFB0", VA = "0x9EEFB0")]
			add
			{
			}
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x9EF070", Offset = "0x9EF070", VA = "0x9EF070")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public static event Action<BaseVideoPlayer> playEvent
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x9E216C", Offset = "0x9E216C", VA = "0x9E216C")]
			add
			{
			}
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x9E25FC", Offset = "0x9E25FC", VA = "0x9E25FC")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public static event Action<BaseVideoPlayer> pauseEvent
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x9EF130", Offset = "0x9EF130", VA = "0x9EF130")]
			add
			{
			}
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x9EF1F0", Offset = "0x9EF1F0", VA = "0x9EF1F0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public static event Action<BaseVideoPlayer> stopEvent
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x9E222C", Offset = "0x9E222C", VA = "0x9E222C")]
			add
			{
			}
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x9E26BC", Offset = "0x9E26BC", VA = "0x9E26BC")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public static event Action<BaseVideoPlayer> replayEvent
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x9E23AC", Offset = "0x9E23AC", VA = "0x9E23AC")]
			add
			{
			}
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x9E283C", Offset = "0x9E283C", VA = "0x9E283C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public static event Action<BaseVideoPlayer, long> playingEvent
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x9E22EC", Offset = "0x9E22EC", VA = "0x9E22EC")]
			add
			{
			}
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x9E277C", Offset = "0x9E277C", VA = "0x9E277C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public static event Action<BaseVideoPlayer, float> bufferingEvent
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x9EF2B0", Offset = "0x9EF2B0", VA = "0x9EF2B0")]
			add
			{
			}
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x9EF370", Offset = "0x9EF370", VA = "0x9EF370")]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		public static event Action<BaseVideoPlayer, Texture> textureEvent
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x9EF430", Offset = "0x9EF430", VA = "0x9EF430")]
			add
			{
			}
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x9EF4F0", Offset = "0x9EF4F0", VA = "0x9EF4F0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public static event Action<BaseVideoPlayer> seekCompleted
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x9EF5B0", Offset = "0x9EF5B0", VA = "0x9EF5B0")]
			add
			{
			}
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x9EF670", Offset = "0x9EF670", VA = "0x9EF670")]
			remove
			{
			}
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x9DD5AC", Offset = "0x9DD5AC", VA = "0x9DD5AC")]
		public static bool Init()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x9F0CA0", Offset = "0x9F0CA0", VA = "0x9F0CA0")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x760A40", Offset = "0x760A40")]
		public static UniTask Prepare(SourceInfo info, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x9F0E4C", Offset = "0x9F0E4C", VA = "0x9F0E4C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x760AA0", Offset = "0x760AA0")]
		public static UniTaskVoid Play(SourceInfo info, double startTime, double endTime, EVideoAngle angle, EVideoLayout layout, CancellationToken cancellationToken)
		{
			return default(UniTaskVoid);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x9F0F44", Offset = "0x9F0F44", VA = "0x9F0F44")]
		public static void GlobalResume()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x9F1050", Offset = "0x9F1050", VA = "0x9F1050")]
		public static void GlobalPause()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x9F1160", Offset = "0x9F1160", VA = "0x9F1160")]
		public static void LocalResume()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x9F13C0", Offset = "0x9F13C0", VA = "0x9F13C0")]
		public static void LocalPause()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x9F080C", Offset = "0x9F080C", VA = "0x9F080C")]
		private static BaseVideoPlayer GetPlayer(VideoSource source)
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x9F0568", Offset = "0x9F0568", VA = "0x9F0568")]
		private static BaseVideoPlayer CreatePlayer(VideoSource source)
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x9F12A4", Offset = "0x9F12A4", VA = "0x9F12A4")]
		private static void Log(string message)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x9F1508", Offset = "0x9F1508", VA = "0x9F1508")]
		public static void Clear()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x9F0AB0", Offset = "0x9F0AB0", VA = "0x9F0AB0")]
		private static void SwitchPlayer(BaseVideoPlayer player)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x9F16FC", Offset = "0x9F16FC", VA = "0x9F16FC")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x760B00", Offset = "0x760B00")]
		public static UniTaskVoid SetBackGround(string texName)
		{
			return default(UniTaskVoid);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x9F1658", Offset = "0x9F1658", VA = "0x9F1658")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x760B60", Offset = "0x760B60")]
		private static UniTaskVoid SetBackGround(Texture texture)
		{
			return default(UniTaskVoid);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x9F17A8", Offset = "0x9F17A8", VA = "0x9F17A8")]
		public static void SetHighlightTex(params string[] texNames)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x9F1B10", Offset = "0x9F1B10", VA = "0x9F1B10")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x760BC0", Offset = "0x760BC0")]
		public static UniTaskVoid SetHighlightTex(params Texture2D[] textures)
		{
			return default(UniTaskVoid);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x9DAACC", Offset = "0x9DAACC", VA = "0x9DAACC")]
		public static void SetHighlightTex(int index, string texName)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x9F1BB4", Offset = "0x9F1BB4", VA = "0x9F1BB4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x760C20", Offset = "0x760C20")]
		public static UniTaskVoid SetHighlightTex(int index, Texture2D tex)
		{
			return default(UniTaskVoid);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x9F1C70", Offset = "0x9F1C70", VA = "0x9F1C70")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x760C80", Offset = "0x760C80")]
		public static UniTaskVoid SetHighlightAlpha(int index, float alpha)
		{
			return default(UniTaskVoid);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x9F1D14", Offset = "0x9F1D14", VA = "0x9F1D14")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x760CE0", Offset = "0x760CE0")]
		public static UniTaskVoid SetAllHighlightAlpha(float alpha)
		{
			return default(UniTaskVoid);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x9DA444", Offset = "0x9DA444", VA = "0x9DA444")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x760D40", Offset = "0x760D40")]
		public static UniTaskVoid ClearAllHighlight()
		{
			return default(UniTaskVoid);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x9F1DB0", Offset = "0x9F1DB0", VA = "0x9F1DB0")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x760DA0", Offset = "0x760DA0")]
		private static UniTask<Material> GetSkyMat()
		{
			return default(UniTask<Material>);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x9F0318", Offset = "0x9F0318", VA = "0x9F0318")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x760E00", Offset = "0x760E00")]
		public static UniTaskVoid CrossFade()
		{
			return default(UniTaskVoid);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x9F1E6C", Offset = "0x9F1E6C", VA = "0x9F1E6C")]
		public static void Screenshot()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x9F1FD8", Offset = "0x9F1FD8", VA = "0x9F1FD8")]
		public VRVideoPlayer()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x9F2100", Offset = "0x9F2100", VA = "0x9F2100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x760E60", Offset = "0x760E60")]
		internal static void <Init>g__onPreRender|76_0(Camera camera)
		{
		}
	}
}
namespace Framework.UI
{
	[Token(Token = "0x2000031")]
	public class ButtonPointerListener : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
	{
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1C19C08", Offset = "0x1C19C08", VA = "0x1C19C08", Slot = "8")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1C19D38", Offset = "0x1C19D38", VA = "0x1C19D38", Slot = "6")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1C19D3C", Offset = "0x1C19D3C", VA = "0x1C19D3C", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1C19D40", Offset = "0x1C19D40", VA = "0x1C19D40", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1C19D44", Offset = "0x1C19D44", VA = "0x1C19D44", Slot = "7")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1C19D48", Offset = "0x1C19D48", VA = "0x1C19D48")]
		public ButtonPointerListener()
		{
		}
	}
}
namespace Framework.XR
{
	[Token(Token = "0x2000032")]
	public abstract class XRCanvas : AbstractMono, ICanvas
	{
		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_Hight;

		[Token(Token = "0x1700003A")]
		public float Height
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x1BFEE80", Offset = "0x1BFEE80", VA = "0x1BFEE80")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x1BFEE88", Offset = "0x1BFEE88", VA = "0x1BFEE88")]
			set
			{
			}
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1BFEE90", Offset = "0x1BFEE90", VA = "0x1BFEE90", Slot = "7")]
		public virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1BFF034", Offset = "0x1BFF034", VA = "0x1BFF034", Slot = "8")]
		public virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1BFF1D8", Offset = "0x1BFF1D8", VA = "0x1BFF1D8", Slot = "9")]
		protected virtual void OnXROriginTransform(PoseData data)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1BFF250", Offset = "0x1BFF250", VA = "0x1BFF250")]
		protected XRCanvas()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class DebugConsoleWindowUI : UIPanel
	{
		[Token(Token = "0x2000034")]
		public struct LogInfo
		{
			[Token(Token = "0x40000EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string Condition;

			[Token(Token = "0x40000EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string StackTrace;

			[Token(Token = "0x40000ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LogType Type;
		}

		[Token(Token = "0x2000035")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D5B4", Offset = "0x75D5B4")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x40000EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Toggle toggle;

			[Token(Token = "0x40000EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DebugConsoleWindowUI <>4__this;

			[Token(Token = "0x6000142")]
			[Address(RVA = "0x1C0A9A0", Offset = "0x1C0A9A0", VA = "0x1C0A9A0")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x6000143")]
			[Address(RVA = "0x1C0A9A8", Offset = "0x1C0A9A8", VA = "0x1C0A9A8")]
			internal void <Start>b__0(bool isOn)
			{
			}
		}

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UICircularScrollView Content;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Text StackText;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Button ClearBtn;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<Toggle> ToggleGroup;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<LogInfo> TotalLogs;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<LogInfo, int> LogNumber;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<int, LogInfo> CurLogs;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly Dictionary<int, bool> CurFilter;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool isNeedRefresh;

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1C1F70C", Offset = "0x1C1F70C", VA = "0x1C1F70C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1C1F864", Offset = "0x1C1F864", VA = "0x1C1F864")]
		private void Start()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1C1FBBC", Offset = "0x1C1FBBC", VA = "0x1C1FBBC", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1C1FC6C", Offset = "0x1C1FC6C", VA = "0x1C1FC6C")]
		private void OnUpdateItem(int index, GameObject obj)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1C1FEB8", Offset = "0x1C1FEB8", VA = "0x1C1FEB8")]
		private void OnClickItem(int index, GameObject obj)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1C1FFCC", Offset = "0x1C1FFCC", VA = "0x1C1FFCC")]
		private void OnLogCallback(string condition, string stackTrace, LogType type)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1C20298", Offset = "0x1C20298", VA = "0x1C20298")]
		private void NeedRefresh()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1C2030C", Offset = "0x1C2030C", VA = "0x1C2030C")]
		private void RefreshUI()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1C2066C", Offset = "0x1C2066C", VA = "0x1C2066C")]
		private void Clear()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1C20784", Offset = "0x1C20784", VA = "0x1C20784", Slot = "9")]
		public override void Open([Optional] object arg)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1C19CC8", Offset = "0x1C19CC8", VA = "0x1C19CC8")]
		public void Log(string condition)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1C207AC", Offset = "0x1C207AC", VA = "0x1C207AC", Slot = "6")]
		protected override Transform GetCanvas()
		{
			return null;
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1C2082C", Offset = "0x1C2082C", VA = "0x1C2082C")]
		public DebugConsoleWindowUI()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class XRInteractablePositionUI : UIPanel
	{
		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly List<XRInteractablePosition> m_Targets;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text m_Value;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RectTransform m_RectTransform;

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1C052C4", Offset = "0x1C052C4", VA = "0x1C052C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1C053B4", Offset = "0x1C053B4", VA = "0x1C053B4", Slot = "9")]
		public override void Open([Optional] object arg)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1C0509C", Offset = "0x1C0509C", VA = "0x1C0509C")]
		public void Close(XRInteractablePosition target)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1C05478", Offset = "0x1C05478", VA = "0x1C05478")]
		private void Update()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1C057C8", Offset = "0x1C057C8", VA = "0x1C057C8", Slot = "6")]
		protected override Transform GetCanvas()
		{
			return null;
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1C057D0", Offset = "0x1C057D0", VA = "0x1C057D0")]
		public XRInteractablePositionUI()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x75D5C4", Offset = "0x75D5C4")]
	public class TeleportEventAdapter : MonoBehaviour
	{
		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<TeleportingEventArgs> OnTeleporting;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<HoverEnterEventArgs> OnFirstHoverEntered;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<HoverExitEventArgs> OnLaseHoverExited;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Action<SelectEnterEventArgs> OnFirstSelectEntered;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Action<SelectExitEventArgs> OnLaseSelectExited;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Action<SelectEnterEventArgs> OnSelectEntered;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Action<SelectExitEventArgs> OnSelectExited;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private BaseTeleportationInteractable teleportationInteractable;

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x9EA48C", Offset = "0x9EA48C", VA = "0x9EA48C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x9EA4E8", Offset = "0x9EA4E8", VA = "0x9EA4E8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x9EA894", Offset = "0x9EA894", VA = "0x9EA894")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x9EAC40", Offset = "0x9EAC40", VA = "0x9EAC40")]
		private void Teleporting(TeleportingEventArgs args)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x9EACBC", Offset = "0x9EACBC", VA = "0x9EACBC")]
		private void FirstHoverEntered(HoverEnterEventArgs args)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x9EAD38", Offset = "0x9EAD38", VA = "0x9EAD38")]
		private void LastHoverExited(HoverExitEventArgs args)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x9EADB4", Offset = "0x9EADB4", VA = "0x9EADB4")]
		private void FirstSelectEntered(SelectEnterEventArgs args)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x9EAE30", Offset = "0x9EAE30", VA = "0x9EAE30")]
		private void LastSelectExited(SelectExitEventArgs args)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x9EAEAC", Offset = "0x9EAEAC", VA = "0x9EAEAC")]
		private void SelectEntered(SelectEnterEventArgs args)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x9EAF28", Offset = "0x9EAF28", VA = "0x9EAF28")]
		private void SelectExited(SelectExitEventArgs args)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x9EAFA4", Offset = "0x9EAFA4", VA = "0x9EAFA4")]
		public TeleportEventAdapter()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0x75D624", Offset = "0x75D624")]
	public class XRControllerSwitch : MonoBehaviour
	{
		[Token(Token = "0x2000039")]
		public enum EGlove
		{
			[Token(Token = "0x4000111")]
			Hand,
			[Token(Token = "0x4000112")]
			Test
		}

		[Serializable]
		[Token(Token = "0x200003A")]
		public struct HandModel
		{
			[Token(Token = "0x4000113")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public EGlove Glove;

			[Token(Token = "0x4000114")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform Model;
		}

		[Serializable]
		[Token(Token = "0x200003B")]
		public struct RayHandler
		{
			[Token(Token = "0x4000115")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public EHand Hand;

			[Token(Token = "0x4000116")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public UnityEngine.Vector3? Dir;
		}

		[Serializable]
		[Token(Token = "0x200003C")]
		public class RayEvent : UnityEvent<RayHandler>
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x1C5B8E0", Offset = "0x1C5B8E0", VA = "0x1C5B8E0")]
			public RayEvent()
			{
			}
		}

		[Token(Token = "0x40000FB")]
		public const int Animator_Layer_Touch = 1;

		[Token(Token = "0x40000FC")]
		public const int Animator_Layer_Grab = 2;

		[Token(Token = "0x40000FD")]
		public const int Animator_Layer_Grip = 3;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EHand Hand;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x75E368", Offset = "0x75E368")]
		[SerializeField]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x75E368", Offset = "0x75E368")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75E368", Offset = "0x75E368")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x75E368", Offset = "0x75E368")]
		private GameObject m_DirectControllerGameObject;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x75E40C", Offset = "0x75E40C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75E40C", Offset = "0x75E40C")]
		private GameObject m_RayControllerGameObject;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float ToIndexPointStateDistance;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x75E47C", Offset = "0x75E47C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75E47C", Offset = "0x75E47C")]
		[SerializeField]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x75E47C", Offset = "0x75E47C")]
		private int m_UseHandIndex;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E4FC", Offset = "0x75E4FC")]
		private bool <IsTouchMode>k__BackingField;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x75E50C", Offset = "0x75E50C")]
		public List<HandModel> UseHands;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public RayEvent Raying;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private XRBaseController m_RayController;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private XRRayInteractor m_RayInteractor;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private XRInteractorLineVisual m_RayLineVisual;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private XRBaseController m_DirectController;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private XRDirectInteractor m_DirectIntreactor;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator m_ModelAnimator;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_TrackState;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float m_ActiviteValue;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float m_SelectValue;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private RaycastHit m_Hit;

		[Token(Token = "0x1700003B")]
		public GameObject directControllerGameObject
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x1BFF3C0", Offset = "0x1BFF3C0", VA = "0x1BFF3C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x1BFF3C8", Offset = "0x1BFF3C8", VA = "0x1BFF3C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public GameObject rayControllerGameObject
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x1BFF3D0", Offset = "0x1BFF3D0", VA = "0x1BFF3D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x1BFF3D8", Offset = "0x1BFF3D8", VA = "0x1BFF3D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public int UseHandIndex
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x1BFF3E0", Offset = "0x1BFF3E0", VA = "0x1BFF3E0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003E")]
		public float ActiviteValue
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x1BFF3E8", Offset = "0x1BFF3E8", VA = "0x1BFF3E8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003F")]
		public float SelectValue
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x1BFF3F0", Offset = "0x1BFF3F0", VA = "0x1BFF3F0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000040")]
		public bool IsTouchMode
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x1BFF3F8", Offset = "0x1BFF3F8", VA = "0x1BFF3F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x760F20", Offset = "0x760F20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x1BFF400", Offset = "0x1BFF400", VA = "0x1BFF400")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x760F30", Offset = "0x760F30")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public XRDirectInteractor DirectIntreactor
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x1BFF40C", Offset = "0x1BFF40C", VA = "0x1BFF40C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1BFF414", Offset = "0x1BFF414", VA = "0x1BFF414")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x1C0025C", Offset = "0x1C0025C", VA = "0x1C0025C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1C004D4", Offset = "0x1C004D4", VA = "0x1C004D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1C00688", Offset = "0x1C00688", VA = "0x1C00688")]
		private void Update()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1C00A8C", Offset = "0x1C00A8C", VA = "0x1C00A8C")]
		private void OnMouseInput()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1C0087C", Offset = "0x1C0087C", VA = "0x1C0087C")]
		private void OnXRInput()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1C00C1C", Offset = "0x1C00C1C", VA = "0x1C00C1C")]
		private void OnTrackingState(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1C00CB0", Offset = "0x1C00CB0", VA = "0x1C00CB0")]
		private void OnActivateValue(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1C00D08", Offset = "0x1C00D08", VA = "0x1C00D08")]
		private void OnSelectValue(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1C00D60", Offset = "0x1C00D60", VA = "0x1C00D60")]
		private void OnSelectEnter(SelectEnterEventArgs arg)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x1C00D64", Offset = "0x1C00D64", VA = "0x1C00D64")]
		private void OnSelectExit(SelectExitEventArgs arg)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1C00598", Offset = "0x1C00598", VA = "0x1C00598")]
		private void SetRayInteractor(bool enable)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x1BFF6A8", Offset = "0x1BFF6A8", VA = "0x1BFF6A8")]
		private void FindDirectControllerComponents()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1BFFA50", Offset = "0x1BFFA50", VA = "0x1BFFA50")]
		private void FindRayControllerComponents()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1C00D68", Offset = "0x1C00D68", VA = "0x1C00D68")]
		public void SwitchHand(EGlove glove)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x1BFFDBC", Offset = "0x1BFFDBC", VA = "0x1BFFDBC")]
		public void SwitchHand(int index)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x1C00E30", Offset = "0x1C00E30", VA = "0x1C00E30")]
		public bool IsSelf(IXRSelectInteractor interactor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x1C00F88", Offset = "0x1C00F88", VA = "0x1C00F88")]
		public void SetRayState(bool isShow)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x1C00FA8", Offset = "0x1C00FA8", VA = "0x1C00FA8")]
		public XRControllerSwitch()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class XRDevicesManager : AbstractMono, IManager
	{
		[Serializable]
		[Token(Token = "0x200003E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D638", Offset = "0x75D638")]
		private sealed class <>c
		{
			[Token(Token = "0x400012C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400012D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<XRControllerSwitch, bool> <>9__53_0;

			[Token(Token = "0x400012E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<XRControllerSwitch, bool> <>9__53_1;

			[Token(Token = "0x6000193")]
			[Address(RVA = "0x1C5B990", Offset = "0x1C5B990", VA = "0x1C5B990")]
			public <>c()
			{
			}

			[Token(Token = "0x6000194")]
			[Address(RVA = "0x1C5B998", Offset = "0x1C5B998", VA = "0x1C5B998")]
			internal bool <Awake>b__53_0(XRControllerSwitch x)
			{
				return default(bool);
			}

			[Token(Token = "0x6000195")]
			[Address(RVA = "0x1C5B9B8", Offset = "0x1C5B9B8", VA = "0x1C5B9B8")]
			internal bool <Awake>b__53_1(XRControllerSwitch x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private XROrigin m_Origin;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private XRControllerSwitch m_LeftController;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private XRControllerSwitch m_RightController;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E57C", Offset = "0x75E57C")]
		private PoseData <OriganInfo>k__BackingField;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E58C", Offset = "0x75E58C")]
		private PoseData <LeftControllerInfo>k__BackingField;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E59C", Offset = "0x75E59C")]
		private PoseData <RightControllerInfo>k__BackingField;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E5AC", Offset = "0x75E5AC")]
		private static bool <IsPause>k__BackingField;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Transform m_Head;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform m_LeftHand;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Transform m_RightHand;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private UnityEngine.Vector3 m_LateOriginPosition;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private UnityEngine.Vector3 m_LateOriginRotation;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private UnityEngine.Vector3 m_LateLeftControllerPosition;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private UnityEngine.Vector3 m_LateLeftControllerRotate;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private UnityEngine.Vector3 m_LateRightControllerPosition;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private UnityEngine.Vector3 m_LateRightControllerRotate;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private UnityEngine.Vector3 m_NormalOriganPosition;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private UnityEngine.Vector3 m_OriganPositionOffset;

		[Token(Token = "0x17000042")]
		public XROrigin Origin
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x1C0144C", Offset = "0x1C0144C", VA = "0x1C0144C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public XRControllerSwitch LeftController
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x1C01454", Offset = "0x1C01454", VA = "0x1C01454")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public XRControllerSwitch RightController
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x1C0145C", Offset = "0x1C0145C", VA = "0x1C0145C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public Transform Head
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x1C01464", Offset = "0x1C01464", VA = "0x1C01464")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public Transform LeftHand
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x1C0146C", Offset = "0x1C0146C", VA = "0x1C0146C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public Transform RightHand
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x1C01474", Offset = "0x1C01474", VA = "0x1C01474")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public PoseData OriganInfo
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x1C0147C", Offset = "0x1C0147C", VA = "0x1C0147C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x760FA0", Offset = "0x760FA0")]
			get
			{
				return default(PoseData);
			}
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x1C0149C", Offset = "0x1C0149C", VA = "0x1C0149C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x760FB0", Offset = "0x760FB0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public PoseData LeftControllerInfo
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x1C014C8", Offset = "0x1C014C8", VA = "0x1C014C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x760FC0", Offset = "0x760FC0")]
			get
			{
				return default(PoseData);
			}
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x1C014E4", Offset = "0x1C014E4", VA = "0x1C014E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x760FD0", Offset = "0x760FD0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public PoseData RightControllerInfo
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x1C0150C", Offset = "0x1C0150C", VA = "0x1C0150C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x760FE0", Offset = "0x760FE0")]
			get
			{
				return default(PoseData);
			}
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x1C0152C", Offset = "0x1C0152C", VA = "0x1C0152C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x760FF0", Offset = "0x760FF0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public UnityEngine.Vector3 OriganPositionOffset
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x1C01558", Offset = "0x1C01558", VA = "0x1C01558")]
			get
			{
				return default(UnityEngine.Vector3);
			}
		}

		[Token(Token = "0x1700004C")]
		public static bool IsPause
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x1C01568", Offset = "0x1C01568", VA = "0x1C01568")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761000", Offset = "0x761000")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x1C015CC", Offset = "0x1C015CC", VA = "0x1C015CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761010", Offset = "0x761010")]
			set
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public static event Action<PoseData> OnXROriginTransform
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x1BFEF40", Offset = "0x1BFEF40", VA = "0x1BFEF40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x760F40", Offset = "0x760F40")]
			add
			{
			}
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x1BFF0E4", Offset = "0x1BFF0E4", VA = "0x1BFF0E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x760F50", Offset = "0x760F50")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public static event Action<PoseData> OnLeftControllerTransform
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x1C0106C", Offset = "0x1C0106C", VA = "0x1C0106C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x760F60", Offset = "0x760F60")]
			add
			{
			}
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x1C01164", Offset = "0x1C01164", VA = "0x1C01164")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x760F70", Offset = "0x760F70")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000C")]
		public static event Action<PoseData> OnRightControllerTransform
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x1C0125C", Offset = "0x1C0125C", VA = "0x1C0125C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x760F80", Offset = "0x760F80")]
			add
			{
			}
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x1C01354", Offset = "0x1C01354", VA = "0x1C01354")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x760F90", Offset = "0x760F90")]
			remove
			{
			}
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x1C01638", Offset = "0x1C01638", VA = "0x1C01638", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x1C01B84", Offset = "0x1C01B84", VA = "0x1C01B84")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x1C01C44", Offset = "0x1C01C44", VA = "0x1C01C44")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1C01D04", Offset = "0x1C01D04", VA = "0x1C01D04")]
		private void Update()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1C01E54", Offset = "0x1C01E54", VA = "0x1C01E54")]
		private void XRDevicesListener()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1C026F8", Offset = "0x1C026F8", VA = "0x1C026F8")]
		private void OnHMDState(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1BFE3FC", Offset = "0x1BFE3FC", VA = "0x1BFE3FC")]
		public EHand GetController(IXRInteractor interactor)
		{
			return default(EHand);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1BFE5E8", Offset = "0x1BFE5E8", VA = "0x1BFE5E8")]
		public XRControllerSwitch GetController(EHand hand)
		{
			return null;
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1C02820", Offset = "0x1C02820", VA = "0x1C02820")]
		public XRDevicesManager()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public struct PoseData
	{
		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform transform;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public UnityEngine.Vector3 position;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public UnityEngine.Vector3 deltaPosition;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEngine.Vector3 Rotate;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public UnityEngine.Vector3 DeltaRotate;

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xB1FCD0", Offset = "0xB1FCD0", VA = "0xB1FCD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x75D648", Offset = "0x75D648")]
	public class XRGrabingActiveTarget : MonoBehaviour
	{
		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_Target;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool InitCheck;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float HideDelay;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private XRGrabInteractable m_XRGrab;

		[Token(Token = "0x1700004D")]
		public GameObject Target
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x1C02924", Offset = "0x1C02924", VA = "0x1C02924")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x1C0292C", Offset = "0x1C0292C", VA = "0x1C0292C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1C029C8", Offset = "0x1C029C8", VA = "0x1C029C8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1C02B18", Offset = "0x1C02B18", VA = "0x1C02B18")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1C02C68", Offset = "0x1C02C68", VA = "0x1C02C68")]
		private void SelectEntered(SelectEnterEventArgs args)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1C02C88", Offset = "0x1C02C88", VA = "0x1C02C88")]
		private void SelectExited(SelectExitEventArgs args)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1C02D28", Offset = "0x1C02D28", VA = "0x1C02D28")]
		public XRGrabingActiveTarget()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1C02D30", Offset = "0x1C02D30", VA = "0x1C02D30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761020", Offset = "0x761020")]
		private void <SelectExited>b__10_0(uint u)
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class XRHelper
	{
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E5CC", Offset = "0x75E5CC")]
		private static bool <IsOpenVibration>k__BackingField;

		[Token(Token = "0x1700004E")]
		public static bool IsOpenVibration
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x1C02D50", Offset = "0x1C02D50", VA = "0x1C02D50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761030", Offset = "0x761030")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x1C02DB4", Offset = "0x1C02DB4", VA = "0x1C02DB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761040", Offset = "0x761040")]
			set
			{
			}
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1BFD7E0", Offset = "0x1BFD7E0", VA = "0x1BFD7E0")]
		public static void Recenter()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1C02E20", Offset = "0x1C02E20", VA = "0x1C02E20")]
		public static void SetControllerVibration(EHand hand, int time, float strength)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1C03030", Offset = "0x1C03030", VA = "0x1C03030")]
		private static void SetXRToolKitVibration(EHand hand, int time, float strength)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1C03488", Offset = "0x1C03488", VA = "0x1C03488")]
		public XRHelper()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class XRInputEventAdapter : MonoBehaviour
	{
		[Token(Token = "0x2000043")]
		public enum EMap
		{
			[Token(Token = "0x400013E")]
			HMD,
			[Token(Token = "0x400013F")]
			LeftHand,
			[Token(Token = "0x4000140")]
			RightHand
		}

		[Token(Token = "0x2000044")]
		public enum EAction
		{
			[Token(Token = "0x4000142")]
			Position,
			[Token(Token = "0x4000143")]
			Rotation,
			[Token(Token = "0x4000144")]
			TrackingState,
			[Token(Token = "0x4000145")]
			Select,
			[Token(Token = "0x4000146")]
			SelectValue,
			[Token(Token = "0x4000147")]
			Activate,
			[Token(Token = "0x4000148")]
			ActivateValue,
			[Token(Token = "0x4000149")]
			UIPress,
			[Token(Token = "0x400014A")]
			UIPressValue,
			[Token(Token = "0x400014B")]
			HapticDevice,
			[Token(Token = "0x400014C")]
			TeleportSelect,
			[Token(Token = "0x400014D")]
			TeleportModeActivate,
			[Token(Token = "0x400014E")]
			TeleportModeCancel,
			[Token(Token = "0x400014F")]
			Turn,
			[Token(Token = "0x4000150")]
			Move,
			[Token(Token = "0x4000151")]
			RotateAnchor,
			[Token(Token = "0x4000152")]
			TranslateAnchor,
			[Token(Token = "0x4000153")]
			Touchpad,
			[Token(Token = "0x4000154")]
			TouchpadTouch,
			[Token(Token = "0x4000155")]
			TouchpadAxis,
			[Token(Token = "0x4000156")]
			Sure,
			[Token(Token = "0x4000157")]
			Back,
			[Token(Token = "0x4000158")]
			Menu,
			[Token(Token = "0x4000159")]
			Any
		}

		[Token(Token = "0x2000045")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D6A8", Offset = "0x75D6A8")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x400015A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InputActionMap map;

			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x1C5B9D8", Offset = "0x1C5B9D8", VA = "0x1C5B9D8")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x1C5B9E0", Offset = "0x1C5B9E0", VA = "0x1C5B9E0")]
			internal bool <Awake>b__0(string item)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000046")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D6B8", Offset = "0x75D6B8")]
		private sealed class <>c__DisplayClass6_1
		{
			[Token(Token = "0x400015B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InputAction action;

			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x1C5BA14", Offset = "0x1C5BA14", VA = "0x1C5BA14")]
			public <>c__DisplayClass6_1()
			{
			}

			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x1C5BA1C", Offset = "0x1C5BA1C", VA = "0x1C5BA1C")]
			internal bool <Awake>b__1(string item)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PlayerInput Player;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<int, Dictionary<int, InputAction>> inputActionMap;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<int, Dictionary<int, Action<InputAction.CallbackContext>>> performedMap;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static bool isRegister;

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1C034E0", Offset = "0x1C034E0", VA = "0x1C034E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1C03EB8", Offset = "0x1C03EB8", VA = "0x1C03EB8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1C0437C", Offset = "0x1C0437C", VA = "0x1C0437C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1C0483C", Offset = "0x1C0483C", VA = "0x1C0483C")]
		public static bool IsPressed(EMap map, EAction action)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AA")]
		public static T GetValue<T>(EMap map, EAction action) where T : struct
		{
			return (T)null;
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1BFA804", Offset = "0x1BFA804", VA = "0x1BFA804")]
		public static void Register(EMap map, EAction action, Action<InputAction.CallbackContext> callback)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1BFB05C", Offset = "0x1BFB05C", VA = "0x1BFB05C")]
		public static void Unregister(EMap map, EAction action, Action<InputAction.CallbackContext> callback)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1C049C0", Offset = "0x1C049C0", VA = "0x1C049C0")]
		public XRInputEventAdapter()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x75D6C8", Offset = "0x75D6C8")]
	public class XRInteractablePosition : MonoBehaviour
	{
		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private XRBaseInteractable interactable;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_Parent;

		[Token(Token = "0x1700004F")]
		public Transform SphereParent
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x1C04AB4", Offset = "0x1C04AB4", VA = "0x1C04AB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1C04ABC", Offset = "0x1C04ABC", VA = "0x1C04ABC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x1C04B78", Offset = "0x1C04B78", VA = "0x1C04B78")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x1C04DE0", Offset = "0x1C04DE0", VA = "0x1C04DE0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1C05140", Offset = "0x1C05140", VA = "0x1C05140")]
		private void OnHoverEntered(HoverEnterEventArgs args)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1C05180", Offset = "0x1C05180", VA = "0x1C05180")]
		private void OnHoverExited(HoverExitEventArgs args)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x1C0518C", Offset = "0x1C0518C", VA = "0x1C0518C")]
		private void OnSelectEntered(SelectEnterEventArgs args)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x1C05218", Offset = "0x1C05218", VA = "0x1C05218")]
		private void OnSelectExited(SelectExitEventArgs args)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x1C052BC", Offset = "0x1C052BC", VA = "0x1C052BC")]
		public XRInteractablePosition()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class XRRayControllerManager : AbstractMono, IManager
	{
		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<GameObject> gameObjects;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly List<Type> m_Windows;

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x1C062C8", Offset = "0x1C062C8", VA = "0x1C062C8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x1C06980", Offset = "0x1C06980", VA = "0x1C06980")]
		private void Start()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x1C06D8C", Offset = "0x1C06D8C", VA = "0x1C06D8C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x1C06E48", Offset = "0x1C06E48", VA = "0x1C06E48")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x1C06F04", Offset = "0x1C06F04", VA = "0x1C06F04")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x1C06C88", Offset = "0x1C06C88", VA = "0x1C06C88")]
		private void OnNormalUIStateChanged(UIPanel window, bool enable)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x1C071CC", Offset = "0x1C071CC", VA = "0x1C071CC")]
		public static void Register(GameObject window)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x1C07250", Offset = "0x1C07250", VA = "0x1C07250")]
		public static void Unregister(GameObject window)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x1C072DC", Offset = "0x1C072DC", VA = "0x1C072DC")]
		public XRRayControllerManager()
		{
		}
	}
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0x75D728", Offset = "0x75D728")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x75D728", Offset = "0x75D728")]
	public class XRSocketInteractorHelper : MonoBehaviour
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private XRGrabInteractable CloneTarget;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool Hightlight;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MeshFilter[] interactableTuples;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private XRSocketInteractor m_XRSocket;

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1C079F8", Offset = "0x1C079F8", VA = "0x1C079F8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1C07BC8", Offset = "0x1C07BC8", VA = "0x1C07BC8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1C07AAC", Offset = "0x1C07AAC", VA = "0x1C07AAC")]
		private void InitMesh()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x1C07C28", Offset = "0x1C07C28", VA = "0x1C07C28")]
		private void DrawHoveredInteractables()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x1C07DD4", Offset = "0x1C07DD4", VA = "0x1C07DD4")]
		private UnityEngine.Matrix4x4 GetHoverMeshMatrix(IXRInteractable interactable, MeshFilter meshFilter, float hoverScale)
		{
			return default(UnityEngine.Matrix4x4);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1C08390", Offset = "0x1C08390", VA = "0x1C08390")]
		private static UnityEngine.Vector3 InverseTransformDirection(Pose pose, UnityEngine.Vector3 direction)
		{
			return default(UnityEngine.Vector3);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1C083E0", Offset = "0x1C083E0", VA = "0x1C083E0")]
		public void SetTarget(XRGrabInteractable interactable)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x1C084B8", Offset = "0x1C084B8", VA = "0x1C084B8")]
		public XRSocketInteractorHelper()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x75D79C", Offset = "0x75D79C")]
	public class XRTouchScreenFinger : MonoBehaviour
	{
		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private EHand m_Hand;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CollisionDetection m_Collision;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject m_XRButton;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PointerEventData m_PointerEventData;

		[Token(Token = "0x17000050")]
		public EHand Hand
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x1C091E4", Offset = "0x1C091E4", VA = "0x1C091E4")]
			get
			{
				return default(EHand);
			}
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x1C091EC", Offset = "0x1C091EC", VA = "0x1C091EC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1C092C8", Offset = "0x1C092C8", VA = "0x1C092C8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1C0938C", Offset = "0x1C0938C", VA = "0x1C0938C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1C09450", Offset = "0x1C09450", VA = "0x1C09450")]
		private void OnTrigger(TriggerDetectionArg arg)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1C0974C", Offset = "0x1C0974C", VA = "0x1C0974C")]
		private void OnActivation(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x1C09840", Offset = "0x1C09840", VA = "0x1C09840")]
		public XRTouchScreenFinger()
		{
		}
	}
}
namespace Com.Zqgame.VRGrilFriend
{
	[Token(Token = "0x200004B")]
	public class CameraLookAround : MonoBehaviour
	{
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1C1EF40", Offset = "0x1C1EF40", VA = "0x1C1EF40")]
		public CameraLookAround()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class DataDefine
	{
		[Token(Token = "0x4000168")]
		public const int MAX_SAVE_DATA_COUNT = 3;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string SettingDataPath;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly string SaveDataPath;

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1C1F648", Offset = "0x1C1F648", VA = "0x1C1F648")]
		public DataDefine()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public class Param
	{
		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Value;

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xB10640", Offset = "0xB10640", VA = "0xB10640")]
		public Param()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004E")]
	public class PlayerData
	{
		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E60C", Offset = "0x75E60C")]
		private int <InstanceID>k__BackingField;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E61C", Offset = "0x75E61C")]
		private long <RegisterTime>k__BackingField;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E62C", Offset = "0x75E62C")]
		private int <PreVideoPlotId>k__BackingField;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<int> PlotProp;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<int> UnlockedPlot;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<int> UnlockedPhoto;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<int> CompletedChapter;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<Param> Params;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_IsNew;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_FirstGotoHome;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string m_Name;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int m_Age;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool m_Sex;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int m_MainPlotID;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int m_Chapter;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int m_MaxChapter;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private bool m_IsPlayBegin;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
		private bool m_IsPlayEnd;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int m_VideoClockTime;

		[Token(Token = "0x17000051")]
		public int InstanceID
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0xB180B0", Offset = "0xB180B0", VA = "0xB180B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761050", Offset = "0x761050")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0xB180B8", Offset = "0xB180B8", VA = "0xB180B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761060", Offset = "0x761060")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public bool IsNew
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0xB180C0", Offset = "0xB180C0", VA = "0xB180C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0xB180C8", Offset = "0xB180C8", VA = "0xB180C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public bool FirstGotoHome
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0xB180FC", Offset = "0xB180FC", VA = "0xB180FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0xB18104", Offset = "0xB18104", VA = "0xB18104")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public string Name
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0xB18138", Offset = "0xB18138", VA = "0xB18138")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0xB18140", Offset = "0xB18140", VA = "0xB18140")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public int Age
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0xB181A8", Offset = "0xB181A8", VA = "0xB181A8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0xB181B0", Offset = "0xB181B0", VA = "0xB181B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public bool Sex
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0xB181D8", Offset = "0xB181D8", VA = "0xB181D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0xB181E0", Offset = "0xB181E0", VA = "0xB181E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public int MainPlotID
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0xB18214", Offset = "0xB18214", VA = "0xB18214")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0xB1821C", Offset = "0xB1821C", VA = "0xB1821C")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public int Chapter
		{
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0xB18244", Offset = "0xB18244", VA = "0xB18244")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0xB1824C", Offset = "0xB1824C", VA = "0xB1824C")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public int MaxChapter
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0xB18274", Offset = "0xB18274", VA = "0xB18274")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0xB1827C", Offset = "0xB1827C", VA = "0xB1827C")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public bool IsPlayBegin
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0xB182A4", Offset = "0xB182A4", VA = "0xB182A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0xB182AC", Offset = "0xB182AC", VA = "0xB182AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public bool IsPlayEnd
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0xB182E0", Offset = "0xB182E0", VA = "0xB182E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0xB182E8", Offset = "0xB182E8", VA = "0xB182E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public long RegisterTime
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0xB1831C", Offset = "0xB1831C", VA = "0xB1831C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761070", Offset = "0x761070")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0xB18324", Offset = "0xB18324", VA = "0xB18324")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761080", Offset = "0x761080")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public int PreVideoPlotId
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0xB1832C", Offset = "0xB1832C", VA = "0xB1832C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761090", Offset = "0x761090")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0xB18334", Offset = "0xB18334", VA = "0xB18334")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7610A0", Offset = "0x7610A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public int VideoClockTime
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0xB1833C", Offset = "0xB1833C", VA = "0xB1833C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0xB18344", Offset = "0xB18344", VA = "0xB18344")]
			set
			{
			}
		}

		[Token(Token = "0x1400000D")]
		public event Action OnDataChanged
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0xB1836C", Offset = "0xB1836C", VA = "0xB1836C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7610B0", Offset = "0x7610B0")]
			add
			{
			}
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0xB1840C", Offset = "0xB1840C", VA = "0xB1840C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7610C0", Offset = "0x7610C0")]
			remove
			{
			}
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xB184AC", Offset = "0xB184AC", VA = "0xB184AC")]
		private void OnDataSave()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xB18530", Offset = "0xB18530", VA = "0xB18530")]
		public PlayerData()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xB18728", Offset = "0xB18728", VA = "0xB18728")]
		public PlayerData(int index)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xB18928", Offset = "0xB18928", VA = "0xB18928")]
		public PlayerData(int index, int mainPlot)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xB18B6C", Offset = "0xB18B6C", VA = "0xB18B6C")]
		public void RecordPlotGoods(params EPlayerProp[] values)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xB18C44", Offset = "0xB18C44", VA = "0xB18C44")]
		public bool HasProp(EPlayerProp id)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xB18CA8", Offset = "0xB18CA8", VA = "0xB18CA8")]
		public void UnlockPlot(int plotID)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xB18D28", Offset = "0xB18D28", VA = "0xB18D28")]
		public bool PlotIsLocked(int plotID)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xB18DB4", Offset = "0xB18DB4", VA = "0xB18DB4")]
		public void UnlockPhoto(params int[] photoIDs)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xB10D68", Offset = "0xB10D68", VA = "0xB10D68")]
		public bool PhotoIsLocked(int photoID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xB18E8C", Offset = "0xB18E8C", VA = "0xB18E8C")]
		public void CompleteChapter(int chapter)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xB18F0C", Offset = "0xB18F0C", VA = "0xB18F0C")]
		public bool ChapterIsComplete(int chapter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xB18F70", Offset = "0xB18F70", VA = "0xB18F70")]
		public void SetParamValue(string name, int value)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xB19130", Offset = "0xB19130", VA = "0xB19130")]
		public int GetParamValue(string name)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200004F")]
	public class SaveData
	{
		[StructLayout(3)]
		[Token(Token = "0x2000050")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D7FC", Offset = "0x75D7FC")]
		private struct <OnPlayerDataChanged>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4000185")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000186")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x4000187")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SaveData <>4__this;

			[Token(Token = "0x4000188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter <>u__1;

			[Token(Token = "0x6000211")]
			[Address(RVA = "0x1C4B4D4", Offset = "0x1C4B4D4", VA = "0x1C4B4D4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000212")]
			[Address(RVA = "0x1C4B6C0", Offset = "0x1C4B6C0", VA = "0x1C4B6C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E64C", Offset = "0x75E64C")]
		private PlayerData[] <PlayerDatas>k__BackingField;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool m_Paid;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool m_TempPayPermission;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		private bool isNeedSave;

		[Token(Token = "0x1700005F")]
		public bool Paid
		{
			[Token(Token = "0x6000205")]
			[Address(RVA = "0xB230D4", Offset = "0xB230D4", VA = "0xB230D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000206")]
			[Address(RVA = "0xB230DC", Offset = "0xB230DC", VA = "0xB230DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public bool TempPayPermission
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0xB23274", Offset = "0xB23274", VA = "0xB23274")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000208")]
			[Address(RVA = "0xB2327C", Offset = "0xB2327C", VA = "0xB2327C")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public PlayerData[] PlayerDatas
		{
			[Token(Token = "0x6000209")]
			[Address(RVA = "0xB23288", Offset = "0xB23288", VA = "0xB23288")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7610D0", Offset = "0x7610D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600020A")]
			[Address(RVA = "0xB23290", Offset = "0xB23290", VA = "0xB23290")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7610E0", Offset = "0x7610E0")]
			set
			{
			}
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xB23298", Offset = "0xB23298", VA = "0xB23298")]
		public SaveData()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xB23300", Offset = "0xB23300", VA = "0xB23300")]
		public void ResetData(int index)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xB23368", Offset = "0xB23368", VA = "0xB23368")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7610F0", Offset = "0x7610F0")]
		private void OnPlayerDataChanged()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xB23448", Offset = "0xB23448", VA = "0xB23448")]
		public void SetPlayer(int index, PlayerData player)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xB23100", Offset = "0xB23100", VA = "0xB23100")]
		public void Serialize()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xB2359C", Offset = "0xB2359C", VA = "0xB2359C")]
		public static SaveData Deserialize()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000051")]
	public class SettingData
	{
		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool m_IsOpenSubtitle;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool m_IsVibration;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_VibrationStrength;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_Volume;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private EDefinition m_VideoDefinition;

		[Token(Token = "0x17000062")]
		public bool IsOpenSubtitle
		{
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x9DFDD4", Offset = "0x9DFDD4", VA = "0x9DFDD4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x9DFDDC", Offset = "0x9DFDDC", VA = "0x9DFDDC")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public bool IsVibration
		{
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x9DFE10", Offset = "0x9DFE10", VA = "0x9DFE10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x9DFE18", Offset = "0x9DFE18", VA = "0x9DFE18")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public float VibrationStrength
		{
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x9DFE4C", Offset = "0x9DFE4C", VA = "0x9DFE4C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x9DFE54", Offset = "0x9DFE54", VA = "0x9DFE54")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public float Volume
		{
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x9DFE7C", Offset = "0x9DFE7C", VA = "0x9DFE7C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x9DFE84", Offset = "0x9DFE84", VA = "0x9DFE84")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public EDefinition VideoDefinition
		{
			[Token(Token = "0x600021B")]
			[Address(RVA = "0x9DFEAC", Offset = "0x9DFEAC", VA = "0x9DFEAC")]
			get
			{
				return default(EDefinition);
			}
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x9DFEB4", Offset = "0x9DFEB4", VA = "0x9DFEB4")]
			set
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public event Action OnDataChanged
		{
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x9DFEDC", Offset = "0x9DFEDC", VA = "0x9DFEDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761160", Offset = "0x761160")]
			add
			{
			}
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x9DFF7C", Offset = "0x9DFF7C", VA = "0x9DFF7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761170", Offset = "0x761170")]
			remove
			{
			}
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x9E001C", Offset = "0x9E001C", VA = "0x9E001C")]
		private void OnChanged()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x9E0194", Offset = "0x9E0194", VA = "0x9E0194")]
		public SettingData()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x9E0020", Offset = "0x9E0020", VA = "0x9E0020")]
		public void Serialize()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x9DD318", Offset = "0x9DD318", VA = "0x9DD318")]
		public static SettingData Deserialize()
		{
			return null;
		}
	}
	[Token(Token = "0x2000052")]
	public class SphereManager
	{
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static GameObjectPool spherePool;

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x9E1570", Offset = "0x9E1570", VA = "0x9E1570")]
		public static GameObject GetSphere()
		{
			return null;
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x9E162C", Offset = "0x9E162C", VA = "0x9E162C")]
		public static void Release(GameObject obj)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x9E168C", Offset = "0x9E168C", VA = "0x9E168C")]
		public SphereManager()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public abstract class XRBaseSphere
	{
		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E66C", Offset = "0x75E66C")]
		private readonly XRSphere <Entity>k__BackingField;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E67C", Offset = "0x75E67C")]
		private readonly InteractConfigData <Config>k__BackingField;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private HoverEnterEvent m_HoverEnter;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HoverExitEvent m_HoverExit;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private IntegerEvent m_Complete;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_ActivateValue;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_SelectValue;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected bool m_IsTrigger;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected int m_Result;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected UnityEngine.Vector3 m_TargetPos;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected readonly List<IXRInteractor> XRInteractors;

		[Token(Token = "0x17000067")]
		public XRSphere Entity
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x1BFD940", Offset = "0x1BFD940", VA = "0x1BFD940")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761180", Offset = "0x761180")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		public InteractConfigData Config
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x1BFD948", Offset = "0x1BFD948", VA = "0x1BFD948")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761190", Offset = "0x761190")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		public abstract float Progress
		{
			[Token(Token = "0x6000228")]
			get;
		}

		[Token(Token = "0x1700006A")]
		public HoverEnterEvent HoverEvent
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x1BFD950", Offset = "0x1BFD950", VA = "0x1BFD950")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		public HoverExitEvent HoverExit
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x1BFD958", Offset = "0x1BFD958", VA = "0x1BFD958")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006C")]
		public IntegerEvent Complete
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x1BFD960", Offset = "0x1BFD960", VA = "0x1BFD960")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		public float TriggerValue
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x1BFD968", Offset = "0x1BFD968", VA = "0x1BFD968")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700006E")]
		public float GrabValue
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x1BFD970", Offset = "0x1BFD970", VA = "0x1BFD970")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1BFD978", Offset = "0x1BFD978", VA = "0x1BFD978")]
		public XRBaseSphere(InteractConfigData config)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1BFE254", Offset = "0x1BFE254", VA = "0x1BFE254")]
		private void UpdateImpl()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x1BFE614", Offset = "0x1BFE614", VA = "0x1BFE614", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1BFE72C", Offset = "0x1BFE72C", VA = "0x1BFE72C", Slot = "6")]
		public virtual void Release()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x1BFEB14", Offset = "0x1BFEB14", VA = "0x1BFEB14", Slot = "7")]
		protected virtual void OnHoverEntered(HoverEnterEventArgs args)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x1BFECC8", Offset = "0x1BFECC8", VA = "0x1BFECC8", Slot = "8")]
		protected virtual void OnHoverExited(HoverExitEventArgs args)
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class XRContinueSphere : XRBaseSphere
	{
		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float m_Time;

		[Token(Token = "0x1700006F")]
		public override float Progress
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x1BFF2B4", Offset = "0x1BFF2B4", VA = "0x1BFF2B4", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1BFF2DC", Offset = "0x1BFF2DC", VA = "0x1BFF2DC")]
		public XRContinueSphere(InteractConfigData config)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1BFF2E0", Offset = "0x1BFF2E0", VA = "0x1BFF2E0", Slot = "6")]
		public override void Release()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1BFF314", Offset = "0x1BFF314", VA = "0x1BFF314", Slot = "5")]
		protected override void Update()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class XRMoveSphere : XRBaseSphere
	{
		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private UnityEngine.Vector3 lastPos;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private UnityEngine.Vector3 offset;

		[Token(Token = "0x17000070")]
		public override float Progress
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x1C05C18", Offset = "0x1C05C18", VA = "0x1C05C18", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x1C05D7C", Offset = "0x1C05D7C", VA = "0x1C05D7C")]
		public XRMoveSphere(InteractConfigData config)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1C05D80", Offset = "0x1C05D80", VA = "0x1C05D80", Slot = "6")]
		public override void Release()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1C05DE4", Offset = "0x1C05DE4", VA = "0x1C05DE4", Slot = "5")]
		protected override void Update()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class XRSphereManager
	{
		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<XRBaseSphere> spheres;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E6BC", Offset = "0x75E6BC")]
		private static bool <IsCanGrab>k__BackingField;

		[Token(Token = "0x17000071")]
		public static bool IsCanGrab
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x1C085A4", Offset = "0x1C085A4", VA = "0x1C085A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7611A0", Offset = "0x7611A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x1C08608", Offset = "0x1C08608", VA = "0x1C08608")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7611B0", Offset = "0x7611B0")]
			private set
			{
			}
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1C08674", Offset = "0x1C08674", VA = "0x1C08674")]
		public static XRBaseSphere CreateSphere(InteractConfigData config)
		{
			return null;
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1BFE1D0", Offset = "0x1BFE1D0", VA = "0x1BFE1D0")]
		public static void Register(XRBaseSphere sphere)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1BFEA88", Offset = "0x1BFEA88", VA = "0x1BFEA88")]
		public static void Unregister(XRBaseSphere sphere)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1C08ACC", Offset = "0x1C08ACC", VA = "0x1C08ACC")]
		public static void ReleaseAll()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1C08BA8", Offset = "0x1C08BA8", VA = "0x1C08BA8")]
		public static void EnableGrabMode(bool enable)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1C08E0C", Offset = "0x1C08E0C", VA = "0x1C08E0C")]
		public XRSphereManager()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class XRTimelimitSphere : XRBaseSphere
	{
		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private uint m_TimerID;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private uint m_LimitID;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool m_TimeOver;

		[Token(Token = "0x17000072")]
		public override float Progress
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x1C08EB0", Offset = "0x1C08EB0", VA = "0x1C08EB0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1C08980", Offset = "0x1C08980", VA = "0x1C08980")]
		public XRTimelimitSphere(InteractConfigData config)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1C08EB8", Offset = "0x1C08EB8", VA = "0x1C08EB8", Slot = "6")]
		public override void Release()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1C08F90", Offset = "0x1C08F90", VA = "0x1C08F90", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1C08FEC", Offset = "0x1C08FEC", VA = "0x1C08FEC")]
		private void OnComplete()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1C0914C", Offset = "0x1C0914C", VA = "0x1C0914C")]
		private void OnVideoPause()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1C09158", Offset = "0x1C09158", VA = "0x1C09158")]
		private void OnVideoResume()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x1C09164", Offset = "0x1C09164", VA = "0x1C09164")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7611C0", Offset = "0x7611C0")]
		private void <.ctor>b__5_0(uint u)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x1C09178", Offset = "0x1C09178", VA = "0x1C09178")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7611D0", Offset = "0x7611D0")]
		private void <OnComplete>b__8_0(uint u)
		{
		}
	}
	[Token(Token = "0x2000058")]
	public class XRTriggerSphere : XRBaseSphere
	{
		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private uint m_TimerID;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject m_HandSphere;

		[Token(Token = "0x17000073")]
		public override float Progress
		{
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x1C09848", Offset = "0x1C09848", VA = "0x1C09848", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x1C08774", Offset = "0x1C08774", VA = "0x1C08774")]
		public XRTriggerSphere(InteractConfigData config)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x1C09850", Offset = "0x1C09850", VA = "0x1C09850", Slot = "6")]
		public override void Release()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1C0988C", Offset = "0x1C0988C", VA = "0x1C0988C", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x1C099A0", Offset = "0x1C099A0", VA = "0x1C099A0")]
		private void OnComplete()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1C09B00", Offset = "0x1C09B00", VA = "0x1C09B00")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7611E0", Offset = "0x7611E0")]
		private void <OnComplete>b__7_0(uint u)
		{
		}
	}
	[Token(Token = "0x2000059")]
	public enum EFSMState
	{
		[Token(Token = "0x40001A6")]
		None,
		[Token(Token = "0x40001A7")]
		EmptyScene,
		[Token(Token = "0x40001A8")]
		EnterScene,
		[Token(Token = "0x40001A9")]
		MainScene,
		[Token(Token = "0x40001AA")]
		PlotScene,
		[Token(Token = "0x40001AB")]
		TrailerScene
	}
	[Token(Token = "0x200005A")]
	public class FSMManager : AbstractMono, IManager
	{
		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<EFSMState, IFSMState> m_FSMStateMap;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private EFSMState m_CurrentState;

		[Token(Token = "0x17000074")]
		public EFSMState CurrentState
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x1C21D00", Offset = "0x1C21D00", VA = "0x1C21D00")]
			get
			{
				return default(EFSMState);
			}
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1C21D08", Offset = "0x1C21D08", VA = "0x1C21D08", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1C21F04", Offset = "0x1C21F04", VA = "0x1C21F04")]
		private void Update()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1C22040", Offset = "0x1C22040", VA = "0x1C22040", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1C220D4", Offset = "0x1C220D4", VA = "0x1C220D4")]
		public void ChangeState(EFSMState state)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x1C222CC", Offset = "0x1C222CC", VA = "0x1C222CC")]
		public IFSMState GetState(EFSMState state)
		{
			return null;
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1C22378", Offset = "0x1C22378", VA = "0x1C22378")]
		public FSMManager()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public interface IFSMState
	{
		[Token(Token = "0x1400000F")]
		event Action OnStart;

		[Token(Token = "0x600025E")]
		void OnEnter([Optional] object arg);

		[Token(Token = "0x600025F")]
		void OnExit([Optional] object arg);

		[Token(Token = "0x6000260")]
		void OnUpdate(float delta);
	}
	[Token(Token = "0x200005C")]
	public class EmptyScene : IFSMState
	{
		[Token(Token = "0x14000010")]
		public event Action OnStart
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x1C2157C", Offset = "0x1C2157C", VA = "0x1C2157C", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761210", Offset = "0x761210")]
			add
			{
			}
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x1C2161C", Offset = "0x1C2161C", VA = "0x1C2161C", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761220", Offset = "0x761220")]
			remove
			{
			}
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x1C216BC", Offset = "0x1C216BC", VA = "0x1C216BC", Slot = "6")]
		public void OnEnter([Optional] object arg)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1C216D0", Offset = "0x1C216D0", VA = "0x1C216D0", Slot = "7")]
		public void OnExit([Optional] object arg)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1C216D4", Offset = "0x1C216D4", VA = "0x1C216D4", Slot = "8")]
		public void OnUpdate(float delta)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x1C216D8", Offset = "0x1C216D8", VA = "0x1C216D8")]
		public EmptyScene()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class EntryScene : IFSMState
	{
		[StructLayout(3)]
		[Token(Token = "0x200005E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D80C", Offset = "0x75D80C")]
		private struct <OnEnter>d__7 : IAsyncStateMachine
		{
			[Token(Token = "0x40001B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40001B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40001B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public EntryScene <>4__this;

			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter <>u__1;

			[Token(Token = "0x600026F")]
			[Address(RVA = "0x1C0B8A8", Offset = "0x1C0B8A8", VA = "0x1C0B8A8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000270")]
			[Address(RVA = "0x1C0BD50", Offset = "0x1C0BD50", VA = "0x1C0BD50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200005F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D81C", Offset = "0x75D81C")]
		private struct <PlayBackGroundVideo>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x40001B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40001B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40001BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public EntryScene <>4__this;

			[Token(Token = "0x40001BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private SourceInfo <info>5__2;

			[Token(Token = "0x40001BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TupleElementNamesAttribute", RVA = "0x75E6EC", Offset = "0x75E6EC")]
			private UniTask<(bool, SourceInfo)>.Awaiter <>u__1;

			[Token(Token = "0x40001BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private UniTask.Awaiter <>u__2;

			[Token(Token = "0x6000271")]
			[Address(RVA = "0x1C0BD5C", Offset = "0x1C0BD5C", VA = "0x1C0BD5C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000272")]
			[Address(RVA = "0x1C0C6B8", Offset = "0x1C0C6B8", VA = "0x1C0C6B8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000060")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D82C", Offset = "0x75D82C")]
		private struct <CheckDownload>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x40001BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40001BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40001C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EntryScene <>4__this;

			[Token(Token = "0x40001C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UniTask<bool>.Awaiter <>u__1;

			[Token(Token = "0x6000273")]
			[Address(RVA = "0x1C0AEF8", Offset = "0x1C0AEF8", VA = "0x1C0AEF8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000274")]
			[Address(RVA = "0x1C0B89C", Offset = "0x1C0B89C", VA = "0x1C0B89C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40001AF")]
		public const string Video_Uri = "Entry";

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private uint m_MusicID;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private bool m_Check;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CancellationTokenSource m_Cts;

		[Token(Token = "0x14000011")]
		public event Action OnStart
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x1C216E0", Offset = "0x1C216E0", VA = "0x1C216E0", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761230", Offset = "0x761230")]
			add
			{
			}
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x1C21780", Offset = "0x1C21780", VA = "0x1C21780", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761240", Offset = "0x761240")]
			remove
			{
			}
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1C21820", Offset = "0x1C21820", VA = "0x1C21820", Slot = "6")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x761250", Offset = "0x761250")]
		public void OnEnter([Optional] object arg)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x1C21900", Offset = "0x1C21900", VA = "0x1C21900", Slot = "7")]
		public void OnExit([Optional] object arg)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x1C21A60", Offset = "0x1C21A60", VA = "0x1C21A60", Slot = "8")]
		public void OnUpdate(float delta)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x1C21A64", Offset = "0x1C21A64", VA = "0x1C21A64")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7612B0", Offset = "0x7612B0")]
		private UniTask PlayBackGroundVideo()
		{
			return default(UniTask);
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1C21BE8", Offset = "0x1C21BE8", VA = "0x1C21BE8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x761310", Offset = "0x761310")]
		private UniTaskVoid CheckDownload()
		{
			return default(UniTaskVoid);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x1C21C90", Offset = "0x1C21C90", VA = "0x1C21C90")]
		public EntryScene()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class MainScene : IFSMState
	{
		[Serializable]
		[Token(Token = "0x2000062")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D83C", Offset = "0x75D83C")]
		private sealed class <>c
		{
			[Token(Token = "0x40001C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40001C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<int, bool> <>9__8_0;

			[Token(Token = "0x600027D")]
			[Address(RVA = "0x1C0FE60", Offset = "0x1C0FE60", VA = "0x1C0FE60")]
			public <>c()
			{
			}

			[Token(Token = "0x600027E")]
			[Address(RVA = "0x1C0FE68", Offset = "0x1C0FE68", VA = "0x1C0FE68")]
			internal bool <PlayBackGroundVideo>b__8_0(int x)
			{
				return default(bool);
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000063")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D84C", Offset = "0x75D84C")]
		private struct <PlayBackGroundVideo>d__8 : IAsyncStateMachine
		{
			[Token(Token = "0x40001C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40001C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40001C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MainScene <>4__this;

			[Token(Token = "0x40001CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private string <videoName>5__2;

			[Token(Token = "0x40001CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private SourceInfo <info>5__3;

			[Token(Token = "0x40001CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TupleElementNamesAttribute", RVA = "0x75E798", Offset = "0x75E798")]
			private UniTask<(bool, SourceInfo)>.Awaiter <>u__1;

			[Token(Token = "0x40001CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private UniTask.Awaiter <>u__2;

			[Token(Token = "0x600027F")]
			[Address(RVA = "0x1C0FE74", Offset = "0x1C0FE74", VA = "0x1C0FE74", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000280")]
			[Address(RVA = "0x1C10D20", Offset = "0x1C10D20", VA = "0x1C10D20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40001C2")]
		public const string Main_BACKGROUND = "background";

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CancellationTokenSource m_Cts;

		[Token(Token = "0x14000012")]
		public event Action OnStart
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0xB0EADC", Offset = "0xB0EADC", VA = "0xB0EADC", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7613A0", Offset = "0x7613A0")]
			add
			{
			}
			[Token(Token = "0x6000276")]
			[Address(RVA = "0xB0EB7C", Offset = "0xB0EB7C", VA = "0xB0EB7C", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7613B0", Offset = "0x7613B0")]
			remove
			{
			}
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xB0EC1C", Offset = "0xB0EC1C", VA = "0xB0EC1C", Slot = "6")]
		public void OnEnter([Optional] object arg)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xB0EDB8", Offset = "0xB0EDB8", VA = "0xB0EDB8", Slot = "7")]
		public void OnExit([Optional] object arg)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xB0EF68", Offset = "0xB0EF68", VA = "0xB0EF68", Slot = "8")]
		public void OnUpdate(float delta)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xB0ED14", Offset = "0xB0ED14", VA = "0xB0ED14")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7613C0", Offset = "0x7613C0")]
		private UniTaskVoid PlayBackGroundVideo()
		{
			return default(UniTaskVoid);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xB0EF6C", Offset = "0xB0EF6C", VA = "0xB0EF6C")]
		public MainScene()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class PlotScene : IFSMState
	{
		[Token(Token = "0x14000013")]
		public event Action OnStart
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0xB1B85C", Offset = "0xB1B85C", VA = "0xB1B85C", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761430", Offset = "0x761430")]
			add
			{
			}
			[Token(Token = "0x6000282")]
			[Address(RVA = "0xB1B8FC", Offset = "0xB1B8FC", VA = "0xB1B8FC", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761440", Offset = "0x761440")]
			remove
			{
			}
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xB1B99C", Offset = "0xB1B99C", VA = "0xB1B99C", Slot = "6")]
		public void OnEnter([Optional] object arg)
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xB1BA84", Offset = "0xB1BA84", VA = "0xB1BA84", Slot = "7")]
		public void OnExit([Optional] object arg)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xB1BBB0", Offset = "0xB1BBB0", VA = "0xB1BBB0", Slot = "8")]
		public void OnUpdate(float delta)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xB1BCB4", Offset = "0xB1BCB4", VA = "0xB1BCB4")]
		public PlotScene()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class TrailerScene : IFSMState
	{
		[StructLayout(3)]
		[Token(Token = "0x2000066")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D85C", Offset = "0x75D85C")]
		private struct <OnEnter>d__5 : IAsyncStateMachine
		{
			[Token(Token = "0x40001D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40001D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40001D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TrailerScene <>4__this;

			[Token(Token = "0x40001D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private SourceInfo <info>5__2;

			[Token(Token = "0x40001D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TupleElementNamesAttribute", RVA = "0x75E854", Offset = "0x75E854")]
			private UniTask<(bool, SourceInfo)>.Awaiter <>u__1;

			[Token(Token = "0x40001D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private UniTask.Awaiter <>u__2;

			[Token(Token = "0x6000290")]
			[Address(RVA = "0x1C4CE48", Offset = "0x1C4CE48", VA = "0x1C4CE48", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000291")]
			[Address(RVA = "0x1C4DA74", Offset = "0x1C4DA74", VA = "0x1C4DA74", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000067")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D86C", Offset = "0x75D86C")]
		private struct <PlayBackGroundVideo>d__8 : IAsyncStateMachine
		{
			[Token(Token = "0x40001D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40001D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40001DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TrailerScene <>4__this;

			[Token(Token = "0x40001DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private SourceInfo <info>5__2;

			[Token(Token = "0x40001DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TupleElementNamesAttribute", RVA = "0x75E8F0", Offset = "0x75E8F0")]
			private UniTask<(bool, SourceInfo)>.Awaiter <>u__1;

			[Token(Token = "0x40001DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private UniTask.Awaiter <>u__2;

			[Token(Token = "0x6000292")]
			[Address(RVA = "0x1C4DA80", Offset = "0x1C4DA80", VA = "0x1C4DA80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000293")]
			[Address(RVA = "0x1C4E504", Offset = "0x1C4E504", VA = "0x1C4E504", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40001CF")]
		public const string Video_Uri = "Entry";

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CancellationTokenSource m_Cts;

		[Token(Token = "0x14000014")]
		public event Action OnStart
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x9EB1A0", Offset = "0x9EB1A0", VA = "0x9EB1A0", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761450", Offset = "0x761450")]
			add
			{
			}
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x9EB240", Offset = "0x9EB240", VA = "0x9EB240", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761460", Offset = "0x761460")]
			remove
			{
			}
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x9EB2E0", Offset = "0x9EB2E0", VA = "0x9EB2E0", Slot = "6")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x761470", Offset = "0x761470")]
		public void OnEnter([Optional] object arg)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x9EB3B8", Offset = "0x9EB3B8", VA = "0x9EB3B8", Slot = "7")]
		public void OnExit([Optional] object arg)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x9EB69C", Offset = "0x9EB69C", VA = "0x9EB69C", Slot = "8")]
		public void OnUpdate(float delta)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x9EB6A0", Offset = "0x9EB6A0", VA = "0x9EB6A0")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7614D0", Offset = "0x7614D0")]
		private UniTaskVoid PlayBackGroundVideo()
		{
			return default(UniTaskVoid);
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x9EB744", Offset = "0x9EB744", VA = "0x9EB744")]
		private void OnEmptySkipVideo(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x9EB890", Offset = "0x9EB890", VA = "0x9EB890")]
		private void OnWindowClose(UIPanel window, bool state)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x9EB9B8", Offset = "0x9EB9B8", VA = "0x9EB9B8")]
		public TrailerScene()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x75D87C", Offset = "0x75D87C")]
	public class GameConfig : ScriptableObject
	{
		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool GM;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool AdministratorPermissions;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static GameConfig _instance;

		[Token(Token = "0x17000075")]
		public static GameConfig Instance
		{
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x1C17E08", Offset = "0x1C17E08", VA = "0x1C17E08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1C23F54", Offset = "0x1C23F54", VA = "0x1C23F54")]
		public GameConfig()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public enum EPlayMode
	{

	}
	[Token(Token = "0x200006A")]
	public enum EAchievement
	{
		[Token(Token = "0x40001E3")]
		None,
		[Token(Token = "0x40001E4")]
		Steel_straight_man,
		[Token(Token = "0x40001E5")]
		Hand_in_hand_success,
		[Token(Token = "0x40001E6")]
		Dressing_talent,
		[Token(Token = "0x40001E7")]
		Highly_skilled,
		[Token(Token = "0x40001E8")]
		Understanding,
		[Token(Token = "0x40001E9")]
		See_parents,
		[Token(Token = "0x40001EA")]
		Is_the_end_of_the_fruit,
		[Token(Token = "0x40001EB")]
		Master_of_love
	}
	[Token(Token = "0x200006B")]
	public enum EAchievementType
	{
		[Token(Token = "0x40001ED")]
		Simple,
		[Token(Token = "0x40001EE")]
		Count
	}
	[Token(Token = "0x200006C")]
	public enum EHand
	{
		[Token(Token = "0x40001F0")]
		None,
		[Token(Token = "0x40001F1")]
		Left,
		[Token(Token = "0x40001F2")]
		Right
	}
	[Token(Token = "0x200006D")]
	public enum EInteraction
	{
		[Token(Token = "0x40001F4")]
		Pose,
		[Token(Token = "0x40001F5")]
		Trigger,
		[Token(Token = "0x40001F6")]
		Continue,
		[Token(Token = "0x40001F7")]
		Move,
		[Token(Token = "0x40001F8")]
		Timelimit
	}
	[Token(Token = "0x200006E")]
	public enum EParent
	{
		[Token(Token = "0x40001FA")]
		None,
		[Token(Token = "0x40001FB")]
		Head,
		[Token(Token = "0x40001FC")]
		LeftController,
		[Token(Token = "0x40001FD")]
		RightController
	}
	[Token(Token = "0x200006F")]
	public enum EPerson
	{
		[Token(Token = "0x40001FF")]
		Self,
		[Token(Token = "0x4000200")]
		GirlFriend,
		[Token(Token = "0x4000201")]
		Confidante,
		[Token(Token = "0x4000202")]
		Father,
		[Token(Token = "0x4000203")]
		Other
	}
	[Token(Token = "0x2000070")]
	public enum EPlayerProp
	{
		[Token(Token = "0x4000205")]
		None = 0,
		[Token(Token = "0x4000206")]
		Home = 1,
		[Token(Token = "0x4000207")]
		素描 = 2,
		[Token(Token = "0x4000208")]
		雏菊 = 3,
		[Token(Token = "0x4000209")]
		诗集 = 4,
		[Token(Token = "0x400020A")]
		相框 = 5,
		[Token(Token = "0x400020B")]
		足球 = 6,
		[Token(Token = "0x400020C")]
		玩偶 = 7,
		[Token(Token = "0x400020D")]
		婚纱 = 8,
		[Token(Token = "0x400020E")]
		通关 = 100,
		[Token(Token = "0x400020F")]
		A线 = 101,
		[Token(Token = "0x4000210")]
		B线 = 102
	}
	[Token(Token = "0x2000071")]
	public enum EPlotType
	{
		[Token(Token = "0x4000212")]
		None,
		[Token(Token = "0x4000213")]
		Video,
		[Token(Token = "0x4000214")]
		Talk,
		[Token(Token = "0x4000215")]
		Interact,
		[Token(Token = "0x4000216")]
		AutoChoice,
		[Token(Token = "0x4000217")]
		ButtonChoice,
		[Token(Token = "0x4000218")]
		InteractChoice
	}
	[Token(Token = "0x2000072")]
	public enum EPose
	{
		[Token(Token = "0x400021A")]
		None,
		[Token(Token = "0x400021B")]
		Nod,
		[Token(Token = "0x400021C")]
		Refuse,
		[Token(Token = "0x400021D")]
		Bye,
		[Token(Token = "0x400021E")]
		LookAround
	}
	[Token(Token = "0x2000073")]
	public enum ETrigger
	{
		[Token(Token = "0x4000220")]
		Idel,
		[Token(Token = "0x4000221")]
		Touch,
		[Token(Token = "0x4000222")]
		Grab,
		[Token(Token = "0x4000223")]
		Grip
	}
	[Token(Token = "0x2000074")]
	public sealed class Option : BeanBase
	{
		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E98C", Offset = "0x75E98C")]
		private string <Desc>k__BackingField;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E99C", Offset = "0x75E99C")]
		private int[] <NeedGoods>k__BackingField;

		[Token(Token = "0x4000226")]
		public const int __ID__ = -1926269803;

		[Token(Token = "0x17000076")]
		public string Desc
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0xB101F4", Offset = "0xB101F4", VA = "0xB101F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761550", Offset = "0x761550")]
			get
			{
				return null;
			}
			[Token(Token = "0x600029A")]
			[Address(RVA = "0xB101FC", Offset = "0xB101FC", VA = "0xB101FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761560", Offset = "0x761560")]
			private set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public int[] NeedGoods
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0xB10204", Offset = "0xB10204", VA = "0xB10204")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761570", Offset = "0x761570")]
			get
			{
				return null;
			}
			[Token(Token = "0x600029C")]
			[Address(RVA = "0xB1020C", Offset = "0xB1020C", VA = "0xB1020C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761580", Offset = "0x761580")]
			private set
			{
			}
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xB0FC2C", Offset = "0xB0FC2C", VA = "0xB0FC2C")]
		public Option(JSONNode _json)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xB10148", Offset = "0xB10148", VA = "0xB10148")]
		public Option(string desc, int[] need_goods)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xB10198", Offset = "0xB10198", VA = "0xB10198")]
		public static Option DeserializeOption(JSONNode _json)
		{
			return null;
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xB10214", Offset = "0xB10214", VA = "0xB10214", Slot = "5")]
		public override int GetTypeId()
		{
			return default(int);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xB10220", Offset = "0xB10220", VA = "0xB10220")]
		public void Resolve(Dictionary<string, object> _tables)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xB10224", Offset = "0xB10224", VA = "0xB10224")]
		public void TranslateText(Func<string, string, string> translator)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xB10228", Offset = "0xB10228", VA = "0xB10228", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000075")]
	public sealed class Subtitle : BeanBase
	{
		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E9AC", Offset = "0x75E9AC")]
		private float <ShowPoint>k__BackingField;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E9BC", Offset = "0x75E9BC")]
		private float <HidePoint>k__BackingField;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E9CC", Offset = "0x75E9CC")]
		private string <Content>k__BackingField;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E9DC", Offset = "0x75E9DC")]
		private EPerson <Person>k__BackingField;

		[Token(Token = "0x400022B")]
		public const int __ID__ = -1995853768;

		[Token(Token = "0x17000078")]
		public float ShowPoint
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x9E1C14", Offset = "0x9E1C14", VA = "0x9E1C14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761590", Offset = "0x761590")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x9E1C1C", Offset = "0x9E1C1C", VA = "0x9E1C1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7615A0", Offset = "0x7615A0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public float HidePoint
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x9E1C24", Offset = "0x9E1C24", VA = "0x9E1C24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7615B0", Offset = "0x7615B0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x9E1C2C", Offset = "0x9E1C2C", VA = "0x9E1C2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7615C0", Offset = "0x7615C0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public string Content
		{
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x9E1C34", Offset = "0x9E1C34", VA = "0x9E1C34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7615D0", Offset = "0x7615D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x9E1C3C", Offset = "0x9E1C3C", VA = "0x9E1C3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7615E0", Offset = "0x7615E0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public EPerson Person
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x9E1C44", Offset = "0x9E1C44", VA = "0x9E1C44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7615F0", Offset = "0x7615F0")]
			get
			{
				return default(EPerson);
			}
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x9E1C4C", Offset = "0x9E1C4C", VA = "0x9E1C4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761600", Offset = "0x761600")]
			private set
			{
			}
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x9E18D0", Offset = "0x9E18D0", VA = "0x9E18D0")]
		public Subtitle(JSONNode _json)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x9E1B5C", Offset = "0x9E1B5C", VA = "0x9E1B5C")]
		public Subtitle(float show_point, float hide_point, string content, EPerson person)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x9E1BB8", Offset = "0x9E1BB8", VA = "0x9E1BB8")]
		public static Subtitle DeserializeSubtitle(JSONNode _json)
		{
			return null;
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x9E1C54", Offset = "0x9E1C54", VA = "0x9E1C54", Slot = "5")]
		public override int GetTypeId()
		{
			return default(int);
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x9E1C60", Offset = "0x9E1C60", VA = "0x9E1C60")]
		public void Resolve(Dictionary<string, object> _tables)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x9E1C64", Offset = "0x9E1C64", VA = "0x9E1C64")]
		public void TranslateText(Func<string, string, string> translator)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x9E1C68", Offset = "0x9E1C68", VA = "0x9E1C68", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000076")]
	public sealed class Tables
	{
		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E9EC", Offset = "0x75E9EC")]
		private readonly TableWindowMappingData <TableWindowMappingData>k__BackingField;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E9FC", Offset = "0x75E9FC")]
		private readonly TableMainPlotData <TableMainPlotData>k__BackingField;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75EA0C", Offset = "0x75EA0C")]
		private readonly TableButtonChoiceData <TableButtonChoiceData>k__BackingField;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75EA1C", Offset = "0x75EA1C")]
		private readonly TableInteractConfigData <TableInteractConfigData>k__BackingField;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75EA2C", Offset = "0x75EA2C")]
		private readonly TableScenePropData <TableScenePropData>k__BackingField;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75EA3C", Offset = "0x75EA3C")]
		private readonly TableGlobalConfigData <TableGlobalConfigData>k__BackingField;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75EA4C", Offset = "0x75EA4C")]
		private readonly TableSubtitleData <TableSubtitleData>k__BackingField;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75EA5C", Offset = "0x75EA5C")]
		private readonly TablePhotoData <TablePhotoData>k__BackingField;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75EA6C", Offset = "0x75EA6C")]
		private readonly TablePersonColorDaa <TablePersonColorDaa>k__BackingField;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75EA7C", Offset = "0x75EA7C")]
		private readonly TableChapterData <TableChapterData>k__BackingField;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75EA8C", Offset = "0x75EA8C")]
		private readonly TableAchievementData <TableAchievementData>k__BackingField;

		[Token(Token = "0x1700007C")]
		public TableWindowMappingData TableWindowMappingData
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x9E9A88", Offset = "0x9E9A88", VA = "0x9E9A88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761610", Offset = "0x761610")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		public TableMainPlotData TableMainPlotData
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x9E9A90", Offset = "0x9E9A90", VA = "0x9E9A90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761620", Offset = "0x761620")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		public TableButtonChoiceData TableButtonChoiceData
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x9E9A98", Offset = "0x9E9A98", VA = "0x9E9A98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761630", Offset = "0x761630")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		public TableInteractConfigData TableInteractConfigData
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x9E9AA0", Offset = "0x9E9AA0", VA = "0x9E9AA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761640", Offset = "0x761640")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		public TableScenePropData TableScenePropData
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x9E9AA8", Offset = "0x9E9AA8", VA = "0x9E9AA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761650", Offset = "0x761650")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		public TableGlobalConfigData TableGlobalConfigData
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x9E9AB0", Offset = "0x9E9AB0", VA = "0x9E9AB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761660", Offset = "0x761660")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		public TableSubtitleData TableSubtitleData
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x9E9AB8", Offset = "0x9E9AB8", VA = "0x9E9AB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761670", Offset = "0x761670")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		public TablePhotoData TablePhotoData
		{
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x9E9AC0", Offset = "0x9E9AC0", VA = "0x9E9AC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761680", Offset = "0x761680")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		public TablePersonColorDaa TablePersonColorDaa
		{
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x9E9AC8", Offset = "0x9E9AC8", VA = "0x9E9AC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761690", Offset = "0x761690")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		public TableChapterData TableChapterData
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x9E9AD0", Offset = "0x9E9AD0", VA = "0x9E9AD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7616A0", Offset = "0x7616A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		public TableAchievementData TableAchievementData
		{
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x9E9AD8", Offset = "0x9E9AD8", VA = "0x9E9AD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7616B0", Offset = "0x7616B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x9DCB50", Offset = "0x9DCB50", VA = "0x9DCB50")]
		public Tables(Func<string, JSONNode> loader)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x9E9AE0", Offset = "0x9E9AE0", VA = "0x9E9AE0")]
		public void TranslateText(Func<string, string, string> translator)
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class GuideManager : AbstractMono, IManager
	{
		[Token(Token = "0x2000078")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D8DC", Offset = "0x75D8DC")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x400023C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject handGo;

			[Token(Token = "0x400023D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UnityEngine.Vector3 endPos;

			[Token(Token = "0x400023E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool isPlay;

			[Token(Token = "0x400023F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Animator anim;

			[Token(Token = "0x4000240")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public InteractConfigData config;

			[Token(Token = "0x4000241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float time;

			[Token(Token = "0x4000242")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public GuideManager <>4__this;

			[Token(Token = "0x4000243")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public int handID;

			[Token(Token = "0x4000244")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public XRBaseSphere sphere;

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x1C0DC64", Offset = "0x1C0DC64", VA = "0x1C0DC64")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x1C0DC6C", Offset = "0x1C0DC6C", VA = "0x1C0DC6C")]
			internal void <DOGuide>b__0(float f)
			{
			}
		}

		[Token(Token = "0x2000079")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D8EC", Offset = "0x75D8EC")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000245")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject handGo;

			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x1C0DF24", Offset = "0x1C0DF24", VA = "0x1C0DF24")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x1C0DF2C", Offset = "0x1C0DF2C", VA = "0x1C0DF2C")]
			internal void <DOByePose>b__0(uint u)
			{
			}

			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x1C0DF4C", Offset = "0x1C0DF4C", VA = "0x1C0DF4C")]
			internal void <DOByePose>b__1(float t)
			{
			}
		}

		[Token(Token = "0x4000237")]
		public const float ANIMATION_RATE = 1f / 120f;

		[Token(Token = "0x4000238")]
		private const float MOVE_SPEED = 0.03f;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject m_LeftHand;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject m_RightHand;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Dictionary<int, uint> GuideTimerMap;

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1C24C88", Offset = "0x1C24C88", VA = "0x1C24C88", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1C24F34", Offset = "0x1C24F34", VA = "0x1C24F34")]
		public XRBaseSphere DOGuide(InteractConfigData config, [Optional] XRBaseSphere sphere)
		{
			return null;
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1C2562C", Offset = "0x1C2562C", VA = "0x1C2562C")]
		public void DOGuide(EPose pose)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1C2563C", Offset = "0x1C2563C", VA = "0x1C2563C")]
		public void DOByePose()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1C25A2C", Offset = "0x1C25A2C", VA = "0x1C25A2C")]
		public void StopGuide()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x1C25BB4", Offset = "0x1C25BB4", VA = "0x1C25BB4")]
		public void StopGuide(EHand hand)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1C25590", Offset = "0x1C25590", VA = "0x1C25590")]
		private GameObject GetHand(EHand hand)
		{
			return null;
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x1C25C8C", Offset = "0x1C25C8C", VA = "0x1C25C8C")]
		public GuideManager()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class ByePose : BasePlayerPose
	{
		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float m_ShoulderHeight;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_RightDelta;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_LeftDelta;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_LastValue;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float[] m_DeltaRange;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_ArrayIndex;

		[Token(Token = "0x17000087")]
		public override float Progress
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x1C19D50", Offset = "0x1C19D50", VA = "0x1C19D50", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000088")]
		public override float Range
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x1C19DA0", Offset = "0x1C19DA0", VA = "0x1C19DA0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x1C19DAC", Offset = "0x1C19DAC", VA = "0x1C19DAC", Slot = "6")]
		protected override void OnOriginTransform(PoseData data)
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x1C19DC4", Offset = "0x1C19DC4", VA = "0x1C19DC4", Slot = "8")]
		protected override void OnRightControllerTransform(PoseData data)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x1C19FF8", Offset = "0x1C19FF8", VA = "0x1C19FF8")]
		public ByePose()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public abstract class BasePlayerPose
	{
		[Token(Token = "0x400024C")]
		protected const int Frame = 50;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75EA9C", Offset = "0x75EA9C")]
		private readonly float <Range>k__BackingField;

		[Token(Token = "0x17000089")]
		public abstract float Progress
		{
			[Token(Token = "0x60002CF")]
			get;
		}

		[Token(Token = "0x1700008A")]
		public virtual float Range
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x1C185D0", Offset = "0x1C185D0", VA = "0x1C185D0", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7616C0", Offset = "0x7616C0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x1C185D8", Offset = "0x1C185D8", VA = "0x1C185D8")]
		public BasePlayerPose()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x1C186F8", Offset = "0x1C186F8", VA = "0x1C186F8", Slot = "6")]
		protected virtual void OnOriginTransform(PoseData data)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1C186FC", Offset = "0x1C186FC", VA = "0x1C186FC", Slot = "7")]
		protected virtual void OnLeftControllerTransform(PoseData data)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1C18700", Offset = "0x1C18700", VA = "0x1C18700", Slot = "8")]
		protected virtual void OnRightControllerTransform(PoseData data)
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class PlayerPoseManager : AbstractMono, IManager
	{
		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Action<EPose> OnPoseComplete;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private NodPose m_Nod;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RefusePose m_Refuse;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ByePose m_Bye;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private LookAroundPose m_LookAround;

		[Token(Token = "0x1700008B")]
		public NodPose Nod
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0xB196F8", Offset = "0xB196F8", VA = "0xB196F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		public RefusePose Refuse
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0xB19700", Offset = "0xB19700", VA = "0xB19700")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008D")]
		public ByePose Bye
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0xB19708", Offset = "0xB19708", VA = "0xB19708")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		public LookAroundPose LookAround
		{
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0xB19710", Offset = "0xB19710", VA = "0xB19710")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000015")]
		public static event Action<PoseData> OnXROriginTransform
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0xB19280", Offset = "0xB19280", VA = "0xB19280")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7616D0", Offset = "0x7616D0")]
			add
			{
			}
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0xB1933C", Offset = "0xB1933C", VA = "0xB1933C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7616E0", Offset = "0x7616E0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000016")]
		public static event Action<PoseData> OnLeftControllerTransform
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0xB193F8", Offset = "0xB193F8", VA = "0xB193F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7616F0", Offset = "0x7616F0")]
			add
			{
			}
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0xB194B8", Offset = "0xB194B8", VA = "0xB194B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761700", Offset = "0x761700")]
			remove
			{
			}
		}

		[Token(Token = "0x14000017")]
		public static event Action<PoseData> OnRightControllerTransform
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0xB19578", Offset = "0xB19578", VA = "0xB19578")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761710", Offset = "0x761710")]
			add
			{
			}
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0xB19638", Offset = "0xB19638", VA = "0xB19638")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761720", Offset = "0x761720")]
			remove
			{
			}
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xB19718", Offset = "0xB19718", VA = "0xB19718")]
		public PlayerPoseManager()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class LookAroundPose : BasePlayerPose
	{
		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float m_RotateDelta;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float[] m_DeltaRange;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_ArrayIndex;

		[Token(Token = "0x1700008F")]
		public override float Progress
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0xB0B2F0", Offset = "0xB0B2F0", VA = "0xB0B2F0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000090")]
		public override float Range
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0xB0B31C", Offset = "0xB0B31C", VA = "0xB0B31C", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xB0B328", Offset = "0xB0B328", VA = "0xB0B328", Slot = "6")]
		protected override void OnOriginTransform(PoseData data)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xB0B488", Offset = "0xB0B488", VA = "0xB0B488")]
		public LookAroundPose()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class NodPose : BasePlayerPose
	{
		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float m_UpDelta;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_DownDelta;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float[] m_DeltaRange;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int m_ArrayIndex;

		[Token(Token = "0x17000091")]
		public override float Progress
		{
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0xB0F9A4", Offset = "0xB0F9A4", VA = "0xB0F9A4", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000092")]
		public override float Range
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0xB0FA18", Offset = "0xB0FA18", VA = "0xB0FA18", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xB0FA24", Offset = "0xB0FA24", VA = "0xB0FA24", Slot = "6")]
		protected override void OnOriginTransform(PoseData data)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xB0FBC4", Offset = "0xB0FBC4", VA = "0xB0FBC4")]
		public NodPose()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class RefusePose : BasePlayerPose
	{
		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float[] m_DeltaRange;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_ArrayIndex;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_RightDelta;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_LeftDelta;

		[Token(Token = "0x17000093")]
		public override float Progress
		{
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0xB22900", Offset = "0xB22900", VA = "0xB22900", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000094")]
		public override float Range
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0xB22974", Offset = "0xB22974", VA = "0xB22974", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xB22980", Offset = "0xB22980", VA = "0xB22980", Slot = "6")]
		protected override void OnOriginTransform(PoseData data)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xB1985C", Offset = "0xB1985C", VA = "0xB1985C")]
		public RefusePose()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public struct APIRequestResult
	{
		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75EADC", Offset = "0x75EADC")]
		private bool <Success>k__BackingField;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75EAEC", Offset = "0x75EAEC")]
		private string <Message>k__BackingField;

		[Token(Token = "0x17000095")]
		public bool Success
		{
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x1C159C4", Offset = "0x1C159C4", VA = "0x1C159C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761730", Offset = "0x761730")]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x1C159CC", Offset = "0x1C159CC", VA = "0x1C159CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761768", Offset = "0x761768")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public string Message
		{
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x1C159D8", Offset = "0x1C159D8", VA = "0x1C159D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x761778", Offset = "0x761778")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x1C159E0", Offset = "0x1C159E0", VA = "0x1C159E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7617B0", Offset = "0x7617B0")]
			set
			{
			}
		}
	}
	[Token(Token = "0x2000081")]
	public class EditorServices : PlatformServices
	{
		[StructLayout(3)]
		[Token(Token = "0x2000082")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D8FC", Offset = "0x75D8FC")]
		private struct <CheckPayState>d__0 : IAsyncStateMachine
		{
			[Token(Token = "0x4000263")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000264")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<APIRequestResult> <>t__builder;

			[Token(Token = "0x4000265")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter <>u__1;

			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x1C0AAC8", Offset = "0x1C0AAC8", VA = "0x1C0AAC8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x1C0AE9C", Offset = "0x1C0AE9C", VA = "0x1C0AE9C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1C214C4", Offset = "0x1C214C4", VA = "0x1C214C4", Slot = "17")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7617C0", Offset = "0x7617C0")]
		public override UniTask<APIRequestResult> CheckPayState()
		{
			return default(UniTask<APIRequestResult>);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1C21574", Offset = "0x1C21574", VA = "0x1C21574")]
		public EditorServices()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public interface IPlatformAccount
	{
		[Token(Token = "0x60002F4")]
		UniTask<APIRequestResult> IsLogin();

		[Token(Token = "0x60002F5")]
		UniTask<(APIRequestResult, AccountInfo)> GetAccountInfo();
	}
	[Token(Token = "0x2000084")]
	public struct AccountInfo
	{
		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string Uid;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Name;
	}
	[Token(Token = "0x2000085")]
	public interface IPlatformAchievement
	{
		[Token(Token = "0x60002F6")]
		UniTask<(APIRequestResult, bool)> UnlockAchievement(EAchievement achievement);

		[Token(Token = "0x60002F7")]
		UniTask<(APIRequestResult, AchievementData)> GetAchievementCount(EAchievement achievement);

		[Token(Token = "0x60002F8")]
		UniTask<(APIRequestResult, AchievementData)> AddAchievementCount(EAchievement achievement, int count);

		[Token(Token = "0x60002F9")]
		UniTask<(APIRequestResult, AchievementData)> AddAchievementByIndex(EAchievement achievement, int index);
	}
	[Serializable]
	[Token(Token = "0x2000086")]
	public struct AchievementData
	{
		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string Name;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public long Count;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool Unlocked;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public byte[] ExtraData;
	}
	[Token(Token = "0x2000087")]
	public interface IPlatformInit
	{
		[Token(Token = "0x17000097")]
		bool IsInit
		{
			[Token(Token = "0x60002FA")]
			get;
		}

		[Token(Token = "0x60002FB")]
		UniTask<APIRequestResult> Init();
	}
	[Token(Token = "0x2000088")]
	public interface IPlatformPay
	{
		[Token(Token = "0x60002FC")]
		UniTask<APIRequestResult> Pay();

		[Token(Token = "0x60002FD")]
		UniTask<APIRequestResult> CheckPayState();

		[Token(Token = "0x60002FE")]
		UniTask<(APIRequestResult, float)> GetPrice();

		[Token(Token = "0x60002FF")]
		UniTask<(APIRequestResult, List<OrderInfo>)> GetOrdersList();
	}
	[Token(Token = "0x2000089")]
	public struct OrderInfo
	{
		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string Name;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string SKU;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Price;

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xB10428", Offset = "0xB10428", VA = "0xB10428", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200008A")]
	public abstract class PlatformServices : IPlatformInit, IPlatformPay, IPlatformAchievement, IPlatformAccount
	{
		[StructLayout(3)]
		[Token(Token = "0x200008B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D90C", Offset = "0x75D90C")]
		private struct <Init>d__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4000270")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000271")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<APIRequestResult> <>t__builder;

			[Token(Token = "0x4000272")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PlatformServices <>4__this;

			[Token(Token = "0x4000273")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter <>u__1;

			[Token(Token = "0x600030E")]
			[Address(RVA = "0x1C3AC2C", Offset = "0x1C3AC2C", VA = "0x1C3AC2C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600030F")]
			[Address(RVA = "0x1C3AF98", Offset = "0x1C3AF98", VA = "0x1C3AF98", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200008C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D91C", Offset = "0x75D91C")]
		private struct <CheckPayState>d__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4000274")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000275")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<APIRequestResult> <>t__builder;

			[Token(Token = "0x4000276")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter <>u__1;

			[Token(Token = "0x6000310")]
			[Address(RVA = "0x1C39A94", Offset = "0x1C39A94", VA = "0x1C39A94", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000311")]
			[Address(RVA = "0x1C39DEC", Offset = "0x1C39DEC", VA = "0x1C39DEC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200008D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D92C", Offset = "0x75D92C")]
		private struct <Pay>d__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4000277")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000278")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<APIRequestResult> <>t__builder;

			[Token(Token = "0x4000279")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter <>u__1;

			[Token(Token = "0x6000312")]
			[Address(RVA = "0x1C3B3A8", Offset = "0x1C3B3A8", VA = "0x1C3B3A8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000313")]
			[Address(RVA = "0x1C3B700", Offset = "0x1C3B700", VA = "0x1C3B700", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200008E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D93C", Offset = "0x75D93C")]
		private struct <UnlockAchievement>d__6 : IAsyncStateMachine
		{
			[Token(Token = "0x400027A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400027B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TupleElementNamesAttribute", RVA = "0x75EAFC", Offset = "0x75EAFC")]
			public AsyncUniTaskMethodBuilder<(APIRequestResult, bool)> <>t__builder;

			[Token(Token = "0x400027C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter <>u__1;

			[Token(Token = "0x6000314")]
			[Address(RVA = "0x1C3B75C", Offset = "0x1C3B75C", VA = "0x1C3B75C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000315")]
			[Address(RVA = "0x1C3BA60", Offset = "0x1C3BA60", VA = "0x1C3BA60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200008F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D94C", Offset = "0x75D94C")]
		private struct <GetAchievementCount>d__7 : IAsyncStateMachine
		{
			[Token(Token = "0x400027D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400027E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TupleElementNamesAttribute", RVA = "0x75EB98", Offset = "0x75EB98")]
			public AsyncUniTaskMethodBuilder<(APIRequestResult, AchievementData)> <>t__builder;

			[Token(Token = "0x400027F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter <>u__1;

			[Token(Token = "0x6000316")]
			[Address(RVA = "0x1C3A1A8", Offset = "0x1C3A1A8", VA = "0x1C3A1A8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000317")]
			[Address(RVA = "0x1C3A4C4", Offset = "0x1C3A4C4", VA = "0x1C3A4C4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000090")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D95C", Offset = "0x75D95C")]
		private struct <AddAchievementCount>d__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4000280")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000281")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TupleElementNamesAttribute", RVA = "0x75EC34", Offset = "0x75EC34")]
			public AsyncUniTaskMethodBuilder<(APIRequestResult, AchievementData)> <>t__builder;

			[Token(Token = "0x4000282")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter <>u__1;

			[Token(Token = "0x6000318")]
			[Address(RVA = "0x1C3971C", Offset = "0x1C3971C", VA = "0x1C3971C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000319")]
			[Address(RVA = "0x1C39A38", Offset = "0x1C39A38", VA = "0x1C39A38", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000091")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D96C", Offset = "0x75D96C")]
		private struct <AddAchievementByIndex>d__9 : IAsyncStateMachine
		{
			[Token(Token = "0x4000283")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000284")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TupleElementNamesAttribute", RVA = "0x75ECD0", Offset = "0x75ECD0")]
			public AsyncUniTaskMethodBuilder<(APIRequestResult, AchievementData)> <>t__builder;

			[Token(Token = "0x4000285")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter <>u__1;

			[Token(Token = "0x600031A")]
			[Address(RVA = "0x1C393A4", Offset = "0x1C393A4", VA = "0x1C393A4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600031B")]
			[Address(RVA = "0x1C396C0", Offset = "0x1C396C0", VA = "0x1C396C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000092")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D97C", Offset = "0x75D97C")]
		private struct <IsLogin>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4000286")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000287")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<APIRequestResult> <>t__builder;

			[Token(Token = "0x4000288")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter <>u__1;

			[Token(Token = "0x600031C")]
			[Address(RVA = "0x1C3AFF4", Offset = "0x1C3AFF4", VA = "0x1C3AFF4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600031D")]
			[Address(RVA = "0x1C3B34C", Offset = "0x1C3B34C", VA = "0x1C3B34C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000093")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D98C", Offset = "0x75D98C")]
		private struct <GetAccountInfo>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4000289")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400028A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<(APIRequestResult, AccountInfo)> <>t__builder;

			[Token(Token = "0x400028B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter <>u__1;

			[Token(Token = "0x600031E")]
			[Address(RVA = "0x1C39E48", Offset = "0x1C39E48", VA = "0x1C39E48", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600031F")]
			[Address(RVA = "0x1C3A14C", Offset = "0x1C3A14C", VA = "0x1C3A14C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000094")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D99C", Offset = "0x75D99C")]
		private struct <GetPrice>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x400028C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400028D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<(APIRequestResult, float)> <>t__builder;

			[Token(Token = "0x400028E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter <>u__1;

			[Token(Token = "0x6000320")]
			[Address(RVA = "0x1C3A8C8", Offset = "0x1C3A8C8", VA = "0x1C3A8C8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000321")]
			[Address(RVA = "0x1C3ABD0", Offset = "0x1C3ABD0", VA = "0x1C3ABD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000095")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D9AC", Offset = "0x75D9AC")]
		private struct <GetOrdersList>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x400028F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000290")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<(APIRequestResult, List<OrderInfo>)> <>t__builder;

			[Token(Token = "0x4000291")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter <>u__1;

			[Token(Token = "0x6000322")]
			[Address(RVA = "0x1C3A520", Offset = "0x1C3A520", VA = "0x1C3A520", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000323")]
			[Address(RVA = "0x1C3A86C", Offset = "0x1C3A86C", VA = "0x1C3A86C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected bool m_IsInit;

		[Token(Token = "0x17000098")]
		public bool IsInit
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0xB16C70", Offset = "0xB16C70", VA = "0xB16C70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xB16C78", Offset = "0xB16C78", VA = "0xB16C78", Slot = "16")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x761830", Offset = "0x761830")]
		public virtual UniTask<APIRequestResult> Init()
		{
			return default(UniTask<APIRequestResult>);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xB16D54", Offset = "0xB16D54", VA = "0xB16D54", Slot = "17")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x761890", Offset = "0x761890")]
		public virtual UniTask<APIRequestResult> CheckPayState()
		{
			return default(UniTask<APIRequestResult>);
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xB16E04", Offset = "0xB16E04", VA = "0xB16E04", Slot = "18")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7618F0", Offset = "0x7618F0")]
		public virtual UniTask<APIRequestResult> Pay()
		{
			return default(UniTask<APIRequestResult>);
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xB16EB4", Offset = "0xB16EB4", VA = "0xB16EB4", Slot = "19")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x761950", Offset = "0x761950")]
		public virtual UniTask<(APIRequestResult, bool)> UnlockAchievement(EAchievement achievement)
		{
			return default(UniTask<(APIRequestResult, bool)>);
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xB16F74", Offset = "0xB16F74", VA = "0xB16F74", Slot = "20")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7619B0", Offset = "0x7619B0")]
		public virtual UniTask<(APIRequestResult, AchievementData)> GetAchievementCount(EAchievement achievement)
		{
			return default(UniTask<(APIRequestResult, AchievementData)>);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xB17040", Offset = "0xB17040", VA = "0xB17040", Slot = "21")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x761A10", Offset = "0x761A10")]
		public virtual UniTask<(APIRequestResult, AchievementData)> AddAchievementCount(EAchievement achievement, int count)
		{
			return default(UniTask<(APIRequestResult, AchievementData)>);
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xB1710C", Offset = "0xB1710C", VA = "0xB1710C", Slot = "22")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x761A70", Offset = "0x761A70")]
		public virtual UniTask<(APIRequestResult, AchievementData)> AddAchievementByIndex(EAchievement achievement, int index)
		{
			return default(UniTask<(APIRequestResult, AchievementData)>);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xB171D8", Offset = "0xB171D8", VA = "0xB171D8", Slot = "23")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x761AD0", Offset = "0x761AD0")]
		public virtual UniTask<APIRequestResult> IsLogin()
		{
			return default(UniTask<APIRequestResult>);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xB17288", Offset = "0xB17288", VA = "0xB17288", Slot = "24")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x761B30", Offset = "0x761B30")]
		public virtual UniTask<(APIRequestResult, AccountInfo)> GetAccountInfo()
		{
			return default(UniTask<(APIRequestResult, AccountInfo)>);
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xB17340", Offset = "0xB17340", VA = "0xB17340", Slot = "25")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x761B90", Offset = "0x761B90")]
		public virtual UniTask<(APIRequestResult, float)> GetPrice()
		{
			return default(UniTask<(APIRequestResult, float)>);
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xB17400", Offset = "0xB17400", VA = "0xB17400", Slot = "26")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x761BF0", Offset = "0x761BF0")]
		public virtual UniTask<(APIRequestResult, List<OrderInfo>)> GetOrdersList()
		{
			return default(UniTask<(APIRequestResult, List<OrderInfo>)>);
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xB13F7C", Offset = "0xB13F7C", VA = "0xB13F7C")]
		protected PlatformServices()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class PicoServices : PlatformServices
	{
		[StructLayout(3)]
		[Token(Token = "0x2000097")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D9BC", Offset = "0x75D9BC")]
		private struct <UnlockAchievement>d__0 : IAsyncStateMachine
		{
			[Token(Token = "0x4000294")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000295")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TupleElementNamesAttribute", RVA = "0x75EE08", Offset = "0x75EE08")]
			public AsyncUniTaskMethodBuilder<(APIRequestResult, bool)> <>t__builder;

			[Token(Token = "0x4000296")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public EAchievement achievement;

			[Token(Token = "0x4000297")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private APIRequestResult <requestResult>5__2;

			[Token(Token = "0x4000298")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private bool <justUnlocked>5__3;

			[Token(Token = "0x4000299")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask<Message<AchievementUpdate>>.Awaiter <>u__1;

			[Token(Token = "0x6000330")]
			[Address(RVA = "0x1C37800", Offset = "0x1C37800", VA = "0x1C37800", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000331")]
			[Address(RVA = "0x1C38034", Offset = "0x1C38034", VA = "0x1C38034", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000098")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D9CC", Offset = "0x75D9CC")]
		private struct <GetAchievementCount>d__1 : IAsyncStateMachine
		{
			[Token(Token = "0x400029A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400029B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TupleElementNamesAttribute", RVA = "0x75EEA4", Offset = "0x75EEA4")]
			public AsyncUniTaskMethodBuilder<(APIRequestResult, AchievementData)> <>t__builder;

			[Token(Token = "0x400029C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public EAchievement achievement;

			[Token(Token = "0x400029D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private APIRequestResult <requestResult>5__2;

			[Token(Token = "0x400029E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private AchievementData <data>5__3;

			[Token(Token = "0x400029F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private UniTask<Message<AchievementProgressList>>.Awaiter <>u__1;

			[Token(Token = "0x6000332")]
			[Address(RVA = "0x1C3423C", Offset = "0x1C3423C", VA = "0x1C3423C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000333")]
			[Address(RVA = "0x1C34C98", Offset = "0x1C34C98", VA = "0x1C34C98", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000099")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D9DC", Offset = "0x75D9DC")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40002A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public APIRequestResult requestResult;

			[Token(Token = "0x40002A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EAchievement achievement;

			[Token(Token = "0x40002A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AchievementData data;

			[Token(Token = "0x40002A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public int count;

			[Token(Token = "0x40002A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool next;

			[Token(Token = "0x6000334")]
			[Address(RVA = "0x1C12FE0", Offset = "0x1C12FE0", VA = "0x1C12FE0")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000335")]
			[Address(RVA = "0x1C12FE8", Offset = "0x1C12FE8", VA = "0x1C12FE8")]
			internal void <AddAchievementCount>b__0(Message<AchievementUpdate> msg)
			{
			}

			[Token(Token = "0x6000336")]
			[Address(RVA = "0x1C131C8", Offset = "0x1C131C8", VA = "0x1C131C8")]
			internal bool <AddAchievementCount>b__1()
			{
				return default(bool);
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200009A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D9EC", Offset = "0x75D9EC")]
		private struct <AddAchievementCount>d__2 : IAsyncStateMachine
		{
			[Token(Token = "0x40002A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TupleElementNamesAttribute", RVA = "0x75EF40", Offset = "0x75EF40")]
			public AsyncUniTaskMethodBuilder<(APIRequestResult, AchievementData)> <>t__builder;

			[Token(Token = "0x40002A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public EAchievement achievement;

			[Token(Token = "0x40002A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public int count;

			[Token(Token = "0x40002A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private <>c__DisplayClass2_0 <>8__1;

			[Token(Token = "0x40002AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask.Awaiter <>u__1;

			[Token(Token = "0x6000337")]
			[Address(RVA = "0x1C142B0", Offset = "0x1C142B0", VA = "0x1C142B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000338")]
			[Address(RVA = "0x1C14968", Offset = "0x1C14968", VA = "0x1C14968", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x200009B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D9FC", Offset = "0x75D9FC")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40002AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public APIRequestResult requestResult;

			[Token(Token = "0x40002AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EAchievement achievement;

			[Token(Token = "0x40002AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AchievementData data;

			[Token(Token = "0x40002AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public int[] array;

			[Token(Token = "0x40002AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public byte[] extraData;

			[Token(Token = "0x40002B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public bool next;

			[Token(Token = "0x6000339")]
			[Address(RVA = "0x1C131D0", Offset = "0x1C131D0", VA = "0x1C131D0")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600033A")]
			[Address(RVA = "0x1C131D8", Offset = "0x1C131D8", VA = "0x1C131D8")]
			internal void <AddAchievementByIndex>b__0(Message<AchievementUpdate> msg)
			{
			}

			[Token(Token = "0x600033B")]
			[Address(RVA = "0x1C133CC", Offset = "0x1C133CC", VA = "0x1C133CC")]
			internal bool <AddAchievementByIndex>b__1()
			{
				return default(bool);
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200009C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DA0C", Offset = "0x75DA0C")]
		private struct <AddAchievementByIndex>d__3 : IAsyncStateMachine
		{
			[Token(Token = "0x40002B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TupleElementNamesAttribute", RVA = "0x75EFDC", Offset = "0x75EFDC")]
			public AsyncUniTaskMethodBuilder<(APIRequestResult, AchievementData)> <>t__builder;

			[Token(Token = "0x40002B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public EAchievement achievement;

			[Token(Token = "0x40002B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public PicoServices <>4__this;

			[Token(Token = "0x40002B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private <>c__DisplayClass3_0 <>8__1;

			[Token(Token = "0x40002B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public int index;

			[Token(Token = "0x40002B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TupleElementNamesAttribute", RVA = "0x75F078", Offset = "0x75F078")]
			private UniTask<(APIRequestResult, AchievementData)>.Awaiter <>u__1;

			[Token(Token = "0x40002B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private UniTask.Awaiter <>u__2;

			[Token(Token = "0x600033C")]
			[Address(RVA = "0x1C133D4", Offset = "0x1C133D4", VA = "0x1C133D4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600033D")]
			[Address(RVA = "0x1C14254", Offset = "0x1C14254", VA = "0x1C14254", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200009D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DA1C", Offset = "0x75DA1C")]
		private struct <Init>d__6 : IAsyncStateMachine
		{
			[Token(Token = "0x40002B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<APIRequestResult> <>t__builder;

			[Token(Token = "0x40002BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PicoServices <>4__this;

			[Token(Token = "0x40002BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private APIRequestResult <requestResult>5__2;

			[Token(Token = "0x40002BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<Message<PlatformInitializeResult>>.Awaiter <>u__1;

			[Token(Token = "0x600033E")]
			[Address(RVA = "0x1C36074", Offset = "0x1C36074", VA = "0x1C36074", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600033F")]
			[Address(RVA = "0x1C36924", Offset = "0x1C36924", VA = "0x1C36924", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200009E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DA2C", Offset = "0x75DA2C")]
		private struct <Pay>d__8 : IAsyncStateMachine
		{
			[Token(Token = "0x40002BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<APIRequestResult> <>t__builder;

			[Token(Token = "0x40002C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private APIRequestResult <requestResult>5__2;

			[Token(Token = "0x40002C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Product <product>5__3;

			[Token(Token = "0x40002C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<Message<ProductList>>.Awaiter <>u__1;

			[Token(Token = "0x40002C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<Message<Purchase>>.Awaiter <>u__2;

			[Token(Token = "0x6000340")]
			[Address(RVA = "0x1C36980", Offset = "0x1C36980", VA = "0x1C36980", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000341")]
			[Address(RVA = "0x1C377A4", Offset = "0x1C377A4", VA = "0x1C377A4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200009F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DA3C", Offset = "0x75DA3C")]
		private struct <CheckPayState>d__9 : IAsyncStateMachine
		{
			[Token(Token = "0x40002C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<APIRequestResult> <>t__builder;

			[Token(Token = "0x40002C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private APIRequestResult <requestResult>5__2;

			[Token(Token = "0x40002C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<Message<PurchaseList>>.Awaiter <>u__1;

			[Token(Token = "0x6000342")]
			[Address(RVA = "0x1C33890", Offset = "0x1C33890", VA = "0x1C33890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000343")]
			[Address(RVA = "0x1C341E0", Offset = "0x1C341E0", VA = "0x1C341E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DA4C", Offset = "0x75DA4C")]
		private struct <GetPrice>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x40002C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<(APIRequestResult, float)> <>t__builder;

			[Token(Token = "0x40002CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private APIRequestResult <requestResult>5__2;

			[Token(Token = "0x40002CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float <price>5__3;

			[Token(Token = "0x40002CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<Message<ProductList>>.Awaiter <>u__1;

			[Token(Token = "0x6000344")]
			[Address(RVA = "0x1C35784", Offset = "0x1C35784", VA = "0x1C35784", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000345")]
			[Address(RVA = "0x1C36018", Offset = "0x1C36018", VA = "0x1C36018", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000A1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DA5C", Offset = "0x75DA5C")]
		private struct <GetOrdersList>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x40002CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<(APIRequestResult, List<OrderInfo>)> <>t__builder;

			[Token(Token = "0x40002CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private APIRequestResult <requestResult>5__2;

			[Token(Token = "0x40002D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private List<OrderInfo> <orders>5__3;

			[Token(Token = "0x40002D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<Message<ProductList>>.Awaiter <>u__1;

			[Token(Token = "0x6000346")]
			[Address(RVA = "0x1C34CF4", Offset = "0x1C34CF4", VA = "0x1C34CF4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000347")]
			[Address(RVA = "0x1C35728", Offset = "0x1C35728", VA = "0x1C35728", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TupleElementNamesAttribute", RVA = "0x75ED6C", Offset = "0x75ED6C")]
		private static Dictionary<int, (string, string)> codeMap;

		[Token(Token = "0x4000293")]
		public const string SKU = "PAY_IAP_000001_Test";

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xB136E8", Offset = "0xB136E8", VA = "0xB136E8", Slot = "19")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x761D00", Offset = "0x761D00")]
		public override UniTask<(APIRequestResult, bool)> UnlockAchievement(EAchievement achievement)
		{
			return default(UniTask<(APIRequestResult, bool)>);
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xB137C0", Offset = "0xB137C0", VA = "0xB137C0", Slot = "20")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x761D60", Offset = "0x761D60")]
		public override UniTask<(APIRequestResult, AchievementData)> GetAchievementCount(EAchievement achievement)
		{
			return default(UniTask<(APIRequestResult, AchievementData)>);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xB138A4", Offset = "0xB138A4", VA = "0xB138A4", Slot = "21")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x761DC0", Offset = "0x761DC0")]
		public override UniTask<(APIRequestResult, AchievementData)> AddAchievementCount(EAchievement achievement, int count)
		{
			return default(UniTask<(APIRequestResult, AchievementData)>);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xB1398C", Offset = "0xB1398C", VA = "0xB1398C", Slot = "22")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x761E20", Offset = "0x761E20")]
		public override UniTask<(APIRequestResult, AchievementData)> AddAchievementByIndex(EAchievement achievement, int index)
		{
			return default(UniTask<(APIRequestResult, AchievementData)>);
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xB13A94", Offset = "0xB13A94", VA = "0xB13A94")]
		public static string GetErrorMessage(int code, bool isChinese = true)
		{
			return null;
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xB13B88", Offset = "0xB13B88", VA = "0xB13B88", Slot = "16")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x761E80", Offset = "0x761E80")]
		public override UniTask<APIRequestResult> Init()
		{
			return default(UniTask<APIRequestResult>);
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xB13C64", Offset = "0xB13C64", VA = "0xB13C64", Slot = "18")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x761EE0", Offset = "0x761EE0")]
		public override UniTask<APIRequestResult> Pay()
		{
			return default(UniTask<APIRequestResult>);
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xB13D20", Offset = "0xB13D20", VA = "0xB13D20", Slot = "17")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x761F40", Offset = "0x761F40")]
		public override UniTask<APIRequestResult> CheckPayState()
		{
			return default(UniTask<APIRequestResult>);
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xB13DDC", Offset = "0xB13DDC", VA = "0xB13DDC", Slot = "25")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x761FA0", Offset = "0x761FA0")]
		public override UniTask<(APIRequestResult, float)> GetPrice()
		{
			return default(UniTask<(APIRequestResult, float)>);
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xB13EA8", Offset = "0xB13EA8", VA = "0xB13EA8", Slot = "26")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x762000", Offset = "0x762000")]
		public override UniTask<(APIRequestResult, List<OrderInfo>)> GetOrdersList()
		{
			return default(UniTask<(APIRequestResult, List<OrderInfo>)>);
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xB13F74", Offset = "0xB13F74", VA = "0xB13F74")]
		public PicoServices()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class PlatformManager : AbstractMono, IManager
	{
		[StructLayout(3)]
		[Token(Token = "0x20000A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DA6C", Offset = "0x75DA6C")]
		private struct <Awake>d__5 : IAsyncStateMachine
		{
			[Token(Token = "0x40002D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40002D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PlatformManager <>4__this;

			[Token(Token = "0x40002D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<APIRequestResult>.Awaiter <>u__1;

			[Token(Token = "0x600034F")]
			[Address(RVA = "0x1C38090", Offset = "0x1C38090", VA = "0x1C38090", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000350")]
			[Address(RVA = "0x1C38738", Offset = "0x1C38738", VA = "0x1C38738", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DA7C", Offset = "0x75DA7C")]
		private struct <CheckUserPayState>d__6 : IAsyncStateMachine
		{
			[Token(Token = "0x40002D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40002DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PlatformManager <>4__this;

			[Token(Token = "0x40002DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UniTask.Awaiter <>u__1;

			[Token(Token = "0x40002DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<APIRequestResult>.Awaiter <>u__2;

			[Token(Token = "0x6000351")]
			[Address(RVA = "0x1C38744", Offset = "0x1C38744", VA = "0x1C38744", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000352")]
			[Address(RVA = "0x1C39398", Offset = "0x1C39398", VA = "0x1C39398", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75F114", Offset = "0x75F114")]
		private PlatformServices <Service>k__BackingField;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_Initing;

		[Token(Token = "0x17000099")]
		public PlatformServices Service
		{
			[Token(Token = "0x6000348")]
			[Address(RVA = "0xB16A70", Offset = "0xB16A70", VA = "0xB16A70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7620F0", Offset = "0x7620F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000349")]
			[Address(RVA = "0xB16A78", Offset = "0xB16A78", VA = "0xB16A78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x762100", Offset = "0x762100")]
			private set
			{
			}
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xB16A80", Offset = "0xB16A80", VA = "0xB16A80", Slot = "4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x762110", Offset = "0x762110")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xB16B58", Offset = "0xB16B58", VA = "0xB16B58")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x762170", Offset = "0x762170")]
		public UniTaskVoid CheckUserPayState()
		{
			return default(UniTaskVoid);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xB16BFC", Offset = "0xB16BFC", VA = "0xB16BFC")]
		public PlatformManager()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xB16C60", Offset = "0xB16C60", VA = "0xB16C60")]
		[DebuggerHidden]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7621D0", Offset = "0x7621D0")]
		private void <>n__0()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xB16C68", Offset = "0xB16C68", VA = "0xB16C68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x762208", Offset = "0x762208")]
		private bool <CheckUserPayState>b__6_0()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000A5")]
	public class QiyuServices : PlatformServices
	{
		[StructLayout(3)]
		[Token(Token = "0x20000A6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DA8C", Offset = "0x75DA8C")]
		private struct <IsLogin>d__0 : IAsyncStateMachine
		{
			[Token(Token = "0x40002E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<APIRequestResult> <>t__builder;

			[Token(Token = "0x40002E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter <>u__1;

			[Token(Token = "0x6000364")]
			[Address(RVA = "0x1C4A27C", Offset = "0x1C4A27C", VA = "0x1C4A27C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000365")]
			[Address(RVA = "0x1C4A6C8", Offset = "0x1C4A6C8", VA = "0x1C4A6C8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20000A7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DA9C", Offset = "0x75DA9C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40002E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public APIRequestResult requestResult;

			[Token(Token = "0x40002E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AccountInfo info;

			[Token(Token = "0x40002E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool complete;

			[Token(Token = "0x6000366")]
			[Address(RVA = "0x1C46B24", Offset = "0x1C46B24", VA = "0x1C46B24")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000367")]
			[Address(RVA = "0x1C46B2C", Offset = "0x1C46B2C", VA = "0x1C46B2C")]
			internal void <GetAccountInfo>b__0(QiyuMessage.MessageResult<QiyuMessage.QiyuAccountInfo> msg)
			{
			}

			[Token(Token = "0x6000368")]
			[Address(RVA = "0x1C46C64", Offset = "0x1C46C64", VA = "0x1C46C64")]
			internal bool <GetAccountInfo>b__1()
			{
				return default(bool);
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DAAC", Offset = "0x75DAAC")]
		private struct <GetAccountInfo>d__1 : IAsyncStateMachine
		{
			[Token(Token = "0x40002E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<(APIRequestResult, AccountInfo)> <>t__builder;

			[Token(Token = "0x40002EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public QiyuServices <>4__this;

			[Token(Token = "0x40002EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private <>c__DisplayClass1_0 <>8__1;

			[Token(Token = "0x40002ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<APIRequestResult>.Awaiter <>u__1;

			[Token(Token = "0x40002EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private UniTask.Awaiter <>u__2;

			[Token(Token = "0x6000369")]
			[Address(RVA = "0x1C48184", Offset = "0x1C48184", VA = "0x1C48184", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600036A")]
			[Address(RVA = "0x1C48AFC", Offset = "0x1C48AFC", VA = "0x1C48AFC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20000A9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DABC", Offset = "0x75DABC")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40002EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public APIRequestResult requestResult;

			[Token(Token = "0x40002F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public QiyuServices <>4__this;

			[Token(Token = "0x600036B")]
			[Address(RVA = "0x1C46C6C", Offset = "0x1C46C6C", VA = "0x1C46C6C")]
			public <>c__DisplayClass8_0()
			{
			}
		}

		[Token(Token = "0x20000AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DACC", Offset = "0x75DACC")]
		private sealed class <>c__DisplayClass8_1
		{
			[Token(Token = "0x40002F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool complete;

			[Token(Token = "0x40002F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass8_0 CS$<>8__locals1;

			[Token(Token = "0x600036C")]
			[Address(RVA = "0x1C46C74", Offset = "0x1C46C74", VA = "0x1C46C74")]
			public <>c__DisplayClass8_1()
			{
			}

			[Token(Token = "0x600036D")]
			[Address(RVA = "0x1C46C7C", Offset = "0x1C46C7C", VA = "0x1C46C7C")]
			internal void <Init>b__0(QiyuMessage.MessageResult<QiyuMessage.SDKInit> msg)
			{
			}

			[Token(Token = "0x600036E")]
			[Address(RVA = "0x1C46E7C", Offset = "0x1C46E7C", VA = "0x1C46E7C")]
			internal bool <Init>b__1()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DADC", Offset = "0x75DADC")]
		private sealed class <>c__DisplayClass8_2
		{
			[Token(Token = "0x40002F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool complete;

			[Token(Token = "0x40002F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass8_0 CS$<>8__locals2;

			[Token(Token = "0x600036F")]
			[Address(RVA = "0x1C46E84", Offset = "0x1C46E84", VA = "0x1C46E84")]
			public <>c__DisplayClass8_2()
			{
			}

			[Token(Token = "0x6000370")]
			[Address(RVA = "0x1C46E8C", Offset = "0x1C46E8C", VA = "0x1C46E8C")]
			internal void <Init>b__2(QiyuMessage.MessageResult<QiyuMessage.SDKInit> msg)
			{
			}

			[Token(Token = "0x6000371")]
			[Address(RVA = "0x1C4708C", Offset = "0x1C4708C", VA = "0x1C4708C")]
			internal bool <Init>b__3()
			{
				return default(bool);
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DAEC", Offset = "0x75DAEC")]
		private struct <Init>d__8 : IAsyncStateMachine
		{
			[Token(Token = "0x40002F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<APIRequestResult> <>t__builder;

			[Token(Token = "0x40002F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public QiyuServices <>4__this;

			[Token(Token = "0x40002F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private <>c__DisplayClass8_0 <>8__1;

			[Token(Token = "0x40002F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter <>u__1;

			[Token(Token = "0x6000372")]
			[Address(RVA = "0x1C49284", Offset = "0x1C49284", VA = "0x1C49284", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000373")]
			[Address(RVA = "0x1C4A220", Offset = "0x1C4A220", VA = "0x1C4A220", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20000AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DAFC", Offset = "0x75DAFC")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x40002FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public APIRequestResult requestResult;

			[Token(Token = "0x40002FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool complete;

			[Token(Token = "0x6000374")]
			[Address(RVA = "0x1C460B8", Offset = "0x1C460B8", VA = "0x1C460B8")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6000375")]
			[Address(RVA = "0x1C460C0", Offset = "0x1C460C0", VA = "0x1C460C0")]
			internal void <CheckPayState>b__0(QiyuMessage.MessageResult<QiyuMessage.QiyuPayHistoryOrders> msg)
			{
			}

			[Token(Token = "0x6000376")]
			[Address(RVA = "0x1C463C0", Offset = "0x1C463C0", VA = "0x1C463C0")]
			internal bool <CheckPayState>b__1()
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x20000AE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DB0C", Offset = "0x75DB0C")]
		private sealed class <>c
		{
			[Token(Token = "0x40002FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40002FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<QiyuMessage.QiyuPayOrderResult, bool> <>9__12_2;

			[Token(Token = "0x6000378")]
			[Address(RVA = "0x1C46090", Offset = "0x1C46090", VA = "0x1C46090")]
			public <>c()
			{
			}

			[Token(Token = "0x6000379")]
			[Address(RVA = "0x1C46098", Offset = "0x1C46098", VA = "0x1C46098")]
			internal bool <CheckPayState>b__12_2(QiyuMessage.QiyuPayOrderResult order)
			{
				return default(bool);
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000AF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DB1C", Offset = "0x75DB1C")]
		private struct <CheckPayState>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x40002FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<APIRequestResult> <>t__builder;

			[Token(Token = "0x4000300")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private <>c__DisplayClass12_0 <>8__1;

			[Token(Token = "0x4000301")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter <>u__1;

			[Token(Token = "0x600037A")]
			[Address(RVA = "0x1C47A2C", Offset = "0x1C47A2C", VA = "0x1C47A2C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600037B")]
			[Address(RVA = "0x1C48128", Offset = "0x1C48128", VA = "0x1C48128", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20000B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DB2C", Offset = "0x75DB2C")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x4000302")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public APIRequestResult requestResult;

			[Token(Token = "0x4000303")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool checkSku;

			[Token(Token = "0x600037C")]
			[Address(RVA = "0x1C463C8", Offset = "0x1C463C8", VA = "0x1C463C8")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x600037D")]
			[Address(RVA = "0x1C463D0", Offset = "0x1C463D0", VA = "0x1C463D0")]
			internal void <Pay>b__0(QiyuMessage.MessageResult<List<QiyuMessage.QiyuPaySkuInfo>> msg)
			{
			}

			[Token(Token = "0x600037E")]
			[Address(RVA = "0x1C4658C", Offset = "0x1C4658C", VA = "0x1C4658C")]
			internal bool <Pay>b__1()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000B1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DB3C", Offset = "0x75DB3C")]
		private sealed class <>c__DisplayClass13_1
		{
			[Token(Token = "0x4000304")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string order_id;

			[Token(Token = "0x4000305")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool complete;

			[Token(Token = "0x4000306")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public <>c__DisplayClass13_0 CS$<>8__locals1;

			[Token(Token = "0x600037F")]
			[Address(RVA = "0x1C46594", Offset = "0x1C46594", VA = "0x1C46594")]
			public <>c__DisplayClass13_1()
			{
			}

			[Token(Token = "0x6000380")]
			[Address(RVA = "0x1C4659C", Offset = "0x1C4659C", VA = "0x1C4659C")]
			internal void <Pay>b__2(QiyuMessage.MessageResult<string> msg)
			{
			}

			[Token(Token = "0x6000381")]
			[Address(RVA = "0x1C4675C", Offset = "0x1C4675C", VA = "0x1C4675C")]
			internal bool <Pay>b__3()
			{
				return default(bool);
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000B2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DB4C", Offset = "0x75DB4C")]
		private struct <Pay>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4000307")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000308")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<APIRequestResult> <>t__builder;

			[Token(Token = "0x4000309")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private <>c__DisplayClass13_0 <>8__1;

			[Token(Token = "0x400030A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private <>c__DisplayClass13_1 <>8__2;

			[Token(Token = "0x400030B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public QiyuServices <>4__this;

			[Token(Token = "0x400030C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter <>u__1;

			[Token(Token = "0x400030D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask<APIRequestResult>.Awaiter <>u__2;

			[Token(Token = "0x6000382")]
			[Address(RVA = "0x1C4A724", Offset = "0x1C4A724", VA = "0x1C4A724", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000383")]
			[Address(RVA = "0x1C4B478", Offset = "0x1C4B478", VA = "0x1C4B478", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20000B3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DB5C", Offset = "0x75DB5C")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x400030E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public APIRequestResult requestResult;

			[Token(Token = "0x400030F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool getResult;

			[Token(Token = "0x6000384")]
			[Address(RVA = "0x1C46764", Offset = "0x1C46764", VA = "0x1C46764")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x6000385")]
			[Address(RVA = "0x1C4676C", Offset = "0x1C4676C", VA = "0x1C4676C")]
			internal void <CheckPayResult>b__0(QiyuMessage.MessageResult<QiyuMessage.QiyuPayOrderResult> msg)
			{
			}

			[Token(Token = "0x6000386")]
			[Address(RVA = "0x1C46904", Offset = "0x1C46904", VA = "0x1C46904")]
			internal bool <CheckPayResult>b__1()
			{
				return default(bool);
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DB6C", Offset = "0x75DB6C")]
		private struct <CheckPayResult>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x4000310")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000311")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<APIRequestResult> <>t__builder;

			[Token(Token = "0x4000312")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private <>c__DisplayClass14_0 <>8__1;

			[Token(Token = "0x4000313")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string id;

			[Token(Token = "0x4000314")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<bool>.Awaiter <>u__1;

			[Token(Token = "0x4000315")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask.Awaiter <>u__2;

			[Token(Token = "0x6000387")]
			[Address(RVA = "0x1C47094", Offset = "0x1C47094", VA = "0x1C47094", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000388")]
			[Address(RVA = "0x1C479D0", Offset = "0x1C479D0", VA = "0x1C479D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20000B5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DB7C", Offset = "0x75DB7C")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x4000316")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public APIRequestResult requestResult;

			[Token(Token = "0x4000317")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float price;

			[Token(Token = "0x4000318")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool checkSku;

			[Token(Token = "0x6000389")]
			[Address(RVA = "0x1C4690C", Offset = "0x1C4690C", VA = "0x1C4690C")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x600038A")]
			[Address(RVA = "0x1C46914", Offset = "0x1C46914", VA = "0x1C46914")]
			internal void <GetPrice>b__0(QiyuMessage.MessageResult<List<QiyuMessage.QiyuPaySkuInfo>> msg)
			{
			}

			[Token(Token = "0x600038B")]
			[Address(RVA = "0x1C46B1C", Offset = "0x1C46B1C", VA = "0x1C46B1C")]
			internal bool <GetPrice>b__1()
			{
				return default(bool);
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000B6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DB8C", Offset = "0x75DB8C")]
		private struct <GetPrice>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4000319")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400031A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<(APIRequestResult, float)> <>t__builder;

			[Token(Token = "0x400031B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private <>c__DisplayClass15_0 <>8__1;

			[Token(Token = "0x400031C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter <>u__1;

			[Token(Token = "0x600038C")]
			[Address(RVA = "0x1C48B58", Offset = "0x1C48B58", VA = "0x1C48B58", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600038D")]
			[Address(RVA = "0x1C49228", Offset = "0x1C49228", VA = "0x1C49228", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<string, string> codeMap;

		[Token(Token = "0x40002DE")]
		public const string APP_ID = "74149928";

		[Token(Token = "0x40002DF")]
		public const string APP_SECRET = "976132424ab8956d50b3132199c46890";

		[Token(Token = "0x40002E0")]
		public const string APP_TOKEN = "eyJhbGciOiJIUzUxMiJ9.eyJzdWIiOiI3NDE0OTkyOCIsImV4cCI6MTY3ODA2NTU2NSwiZGV2aWNlSWQiOiJRWVZSMDAwMDAwMDAwMDAwMDAwMCIsImlhdCI6MTY3NzQ2MDc2NSwianRpIjoiZDYwYTU4MjhkOTgzNDc2ZWE2YWMxODMxZjRiMjBhMjkifQ.clc6jjyqHLQ-FcoMlyVhl89K2lqDD4DKYJVWG61cYYollLMzpOqNmyn5FdnrucW1NlfbGEChoOy_Iz-Nx_Ptbw";

		[Token(Token = "0x40002E1")]
		public const string SKU = "PAY_IAP_000001_Test";

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		private bool m_InitPay;

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xB21878", Offset = "0xB21878", VA = "0xB21878", Slot = "23")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x762238", Offset = "0x762238")]
		public override UniTask<APIRequestResult> IsLogin()
		{
			return default(UniTask<APIRequestResult>);
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xB21928", Offset = "0xB21928", VA = "0xB21928", Slot = "24")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x762298", Offset = "0x762298")]
		public override UniTask<(APIRequestResult, AccountInfo)> GetAccountInfo()
		{
			return default(UniTask<(APIRequestResult, AccountInfo)>);
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xB21A10", Offset = "0xB21A10", VA = "0xB21A10")]
		public static void GetQiyuAccountInfo(RequestCallback callback)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xB21A7C", Offset = "0xB21A7C", VA = "0xB21A7C")]
		public static string GetErrorMessage(string code)
		{
			return null;
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xB21B40", Offset = "0xB21B40", VA = "0xB21B40", Slot = "16")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7622F8", Offset = "0x7622F8")]
		public override UniTask<APIRequestResult> Init()
		{
			return default(UniTask<APIRequestResult>);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xB21C1C", Offset = "0xB21C1C", VA = "0xB21C1C")]
		public static void InitQiyuSDK(RequestCallback callback, string app_id, string app_secret)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xB21CA0", Offset = "0xB21CA0", VA = "0xB21CA0", Slot = "17")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x762358", Offset = "0x762358")]
		public override UniTask<APIRequestResult> CheckPayState()
		{
			return default(UniTask<APIRequestResult>);
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xB21D50", Offset = "0xB21D50", VA = "0xB21D50", Slot = "18")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7623B8", Offset = "0x7623B8")]
		public override UniTask<APIRequestResult> Pay()
		{
			return default(UniTask<APIRequestResult>);
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xB21E2C", Offset = "0xB21E2C", VA = "0xB21E2C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x762418", Offset = "0x762418")]
		private UniTask<APIRequestResult> CheckPayResult(string id)
		{
			return default(UniTask<APIRequestResult>);
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xB21F08", Offset = "0xB21F08", VA = "0xB21F08", Slot = "25")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x762478", Offset = "0x762478")]
		public override UniTask<(APIRequestResult, float)> GetPrice()
		{
			return default(UniTask<(APIRequestResult, float)>);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xB21FD0", Offset = "0xB21FD0", VA = "0xB21FD0")]
		public static void InitQiyuPay(RequestCallback callback)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xB2203C", Offset = "0xB2203C", VA = "0xB2203C")]
		public static void GetSkuList(RequestCallback callback, string skuList = "")
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xB220B8", Offset = "0xB220B8", VA = "0xB220B8")]
		public static void PlaceOrder(RequestCallback callback, string sku)
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xB22134", Offset = "0xB22134", VA = "0xB22134")]
		public static void QueryOrderResult(RequestCallback callback, string orderId)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xB221B0", Offset = "0xB221B0", VA = "0xB221B0")]
		public static void QueryHistoryOrders(RequestCallback callback, string sku, int curPage = 1, int pageSize = 10)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xB22244", Offset = "0xB22244", VA = "0xB22244")]
		public QiyuServices()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class SkyworthServices : PlatformServices
	{
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x9E1358", Offset = "0x9E1358", VA = "0x9E1358")]
		public SkyworthServices()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public class Plot
	{
		[Token(Token = "0x20000B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DB9C", Offset = "0x75DB9C")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x400032D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Plot <>4__this;

			[Token(Token = "0x400032E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ManualWindowUI window;

			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x1C3BD20", Offset = "0x1C3BD20", VA = "0x1C3BD20")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x1C3BD28", Offset = "0x1C3BD28", VA = "0x1C3BD28")]
			internal void <Run>b__1(uint u)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DBAC", Offset = "0x75DBAC")]
		private sealed class <>c
		{
			[Token(Token = "0x400032F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000330")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<int, InteractConfigData> <>9__16_0;

			[Token(Token = "0x4000331")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Comparison<InteractConfigData> <>9__34_0;

			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x1C3BC84", Offset = "0x1C3BC84", VA = "0x1C3BC84")]
			public <>c()
			{
			}

			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x1C3BC8C", Offset = "0x1C3BC8C", VA = "0x1C3BC8C")]
			internal InteractConfigData <Run>b__16_0(int x)
			{
				return null;
			}

			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x1C3BCF4", Offset = "0x1C3BCF4", VA = "0x1C3BCF4")]
			internal int <Execute>b__34_0(InteractConfigData x, InteractConfigData y)
			{
				return default(int);
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000BB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DBBC", Offset = "0x75DBBC")]
		private struct <Run>d__16 : IAsyncStateMachine
		{
			[Token(Token = "0x4000332")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000333")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<int> <>t__builder;

			[Token(Token = "0x4000334")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Plot <>4__this;

			[Token(Token = "0x4000335")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter <>u__1;

			[Token(Token = "0x4000336")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<int>.Awaiter <>u__2;

			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x1C413F4", Offset = "0x1C413F4", VA = "0x1C413F4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x1C42540", Offset = "0x1C42540", VA = "0x1C42540", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DBCC", Offset = "0x75DBCC")]
		private struct <Playing>d__21 : IAsyncStateMachine
		{
			[Token(Token = "0x4000337")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000338")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x4000339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Plot <>4__this;

			[Token(Token = "0x400033A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public long time;

			[Token(Token = "0x400033B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public BaseVideoPlayer player;

			[Token(Token = "0x400033C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private long <temp>5__2;

			[Token(Token = "0x400033D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int <length>5__3;

			[Token(Token = "0x400033E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private int <i>5__4;

			[Token(Token = "0x400033F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private long <insertTime>5__5;

			[Token(Token = "0x4000340")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private long <waitTime>5__6;

			[Token(Token = "0x4000341")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private UniTask.Awaiter <>u__1;

			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x1C40B6C", Offset = "0x1C40B6C", VA = "0x1C40B6C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x1C413E8", Offset = "0x1C413E8", VA = "0x1C413E8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20000BD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DBDC", Offset = "0x75DBDC")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x4000342")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InteractConfigData config;

			[Token(Token = "0x4000343")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public XRBaseSphere sphere;

			[Token(Token = "0x4000344")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Plot <>4__this;

			[Token(Token = "0x4000345")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BaseVideoPlayer player;

			[Token(Token = "0x4000346")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public long insertTime;

			[Token(Token = "0x4000347")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public long waitTime;

			[Token(Token = "0x4000348")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool isComplete;

			[Token(Token = "0x4000349")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public long otherTime;

			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x1C3BD58", Offset = "0x1C3BD58", VA = "0x1C3BD58")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x1C3BD60", Offset = "0x1C3BD60", VA = "0x1C3BD60")]
			internal void <DOInteract>g__OnHoverEnter|0(HoverEnterEventArgs args)
			{
			}

			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x1C3BFD4", Offset = "0x1C3BFD4", VA = "0x1C3BFD4")]
			internal void <DOInteract>g__OnComplete|1(int result)
			{
			}

			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x1C3C240", Offset = "0x1C3C240", VA = "0x1C3C240")]
			internal bool <DOInteract>b__2()
			{
				return default(bool);
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000BE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DBEC", Offset = "0x75DBEC")]
		private struct <DOInteract>d__22 : IAsyncStateMachine
		{
			[Token(Token = "0x400034A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400034B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400034C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractConfigData config;

			[Token(Token = "0x400034D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Plot <>4__this;

			[Token(Token = "0x400034E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BaseVideoPlayer player;

			[Token(Token = "0x400034F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public long insertTime;

			[Token(Token = "0x4000350")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public long waitTime;

			[Token(Token = "0x4000351")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private <>c__DisplayClass22_0 <>8__1;

			[Token(Token = "0x4000352")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public CancellationToken token;

			[Token(Token = "0x4000353")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float <lastPro>5__2;

			[Token(Token = "0x4000354")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private float <t>5__3;

			[Token(Token = "0x4000355")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask.Awaiter <>u__1;

			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x1C3C3D4", Offset = "0x1C3C3D4", VA = "0x1C3C3D4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x1C3D914", Offset = "0x1C3D914", VA = "0x1C3D914", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000BF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DBFC", Offset = "0x75DBFC")]
		private struct <DOPose>d__26 : IAsyncStateMachine
		{
			[Token(Token = "0x4000356")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000357")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000358")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractConfigData config;

			[Token(Token = "0x4000359")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Plot <>4__this;

			[Token(Token = "0x400035A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CancellationToken token;

			[Token(Token = "0x400035B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter <>u__1;

			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x1C3D920", Offset = "0x1C3D920", VA = "0x1C3D920", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x1C3DFFC", Offset = "0x1C3DFFC", VA = "0x1C3DFFC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DC0C", Offset = "0x75DC0C")]
		private struct <UnlockAchievement>d__27 : IAsyncStateMachine
		{
			[Token(Token = "0x400035C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400035D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			[Token(Token = "0x400035E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Plot <>4__this;

			[Token(Token = "0x400035F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TupleElementNamesAttribute", RVA = "0x75F144", Offset = "0x75F144")]
			private UniTask<(APIRequestResult, bool)>.Awaiter <>u__1;

			[Token(Token = "0x4000360")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TupleElementNamesAttribute", RVA = "0x75F1E0", Offset = "0x75F1E0")]
			private UniTask<(APIRequestResult, AchievementData)>.Awaiter <>u__2;

			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x1C4259C", Offset = "0x1C4259C", VA = "0x1C4259C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x1C43748", Offset = "0x1C43748", VA = "0x1C43748", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000C1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DC1C", Offset = "0x75DC1C")]
		private struct <PlayVideo>d__28 : IAsyncStateMachine
		{
			[Token(Token = "0x4000361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Plot <>4__this;

			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float start;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float end;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private SourceInfo <info>5__2;

			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TupleElementNamesAttribute", RVA = "0x75F27C", Offset = "0x75F27C")]
			private UniTask<(bool, SourceInfo)>.Awaiter <>u__1;

			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private UniTask.Awaiter <>u__2;

			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private UniTask<bool>.Awaiter <>u__3;

			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x1C3F320", Offset = "0x1C3F320", VA = "0x1C3F320", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x1C40B60", Offset = "0x1C40B60", VA = "0x1C40B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20000C2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DC2C", Offset = "0x75DC2C")]
		private sealed class <>c__DisplayClass35_0
		{
			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public XRSphere sphere;

			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x1C3C280", Offset = "0x1C3C280", VA = "0x1C3C280")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x1C3C288", Offset = "0x1C3C288", VA = "0x1C3C288")]
			internal void <OnInteractiAfter>b__0(float f)
			{
			}
		}

		[Token(Token = "0x20000C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DC3C", Offset = "0x75DC3C")]
		private sealed class <>c__DisplayClass35_1
		{
			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float strength;

			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x1C3C330", Offset = "0x1C3C330", VA = "0x1C3C330")]
			public <>c__DisplayClass35_1()
			{
			}

			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x1C3C338", Offset = "0x1C3C338", VA = "0x1C3C338")]
			internal void <OnInteractiAfter>b__1(float f)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DC4C", Offset = "0x75DC4C")]
		private struct <Execute>d__39 : IAsyncStateMachine
		{
			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<int> <>t__builder;

			[Token(Token = "0x400036F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ButtonChoiceData choice;

			[Token(Token = "0x4000370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Plot <>4__this;

			[Token(Token = "0x4000371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter <>u__1;

			[Token(Token = "0x4000372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private long <stopTime>5__2;

			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private bool <isShow>5__3;

			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x1C3E008", Offset = "0x1C3E008", VA = "0x1C3E008", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x1C3F2C4", Offset = "0x1C3F2C4", VA = "0x1C3F2C4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400031D")]
		public const EVideoAngle Angle = EVideoAngle.Degrees180;

		[Token(Token = "0x400031E")]
		public const EVideoLayout Layout = EVideoLayout.SideBySide;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, int> m_ParamCacheMap;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75F124", Offset = "0x75F124")]
		private readonly MainPlotData <Data>k__BackingField;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75F134", Offset = "0x75F134")]
		private BaseVideoPlayer <Player>k__BackingField;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private uint TimerID;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int result;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CancellationTokenSource m_Cts;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isHoverEnter;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private long lastTime;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private EPose m_CurPose;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool m_PoseState;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<uint> m_SubtitleID;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private InteractConfigData[] insertInteracts;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private uint m_AfterTimerID;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private long showTime;

		[Token(Token = "0x1700009A")]
		public MainPlotData Data
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0xB198C4", Offset = "0xB198C4", VA = "0xB198C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x762548", Offset = "0x762548")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		public BaseVideoPlayer Player
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0xB198CC", Offset = "0xB198CC", VA = "0xB198CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x762558", Offset = "0x762558")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000391")]
			[Address(RVA = "0xB198D4", Offset = "0xB198D4", VA = "0xB198D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x762568", Offset = "0x762568")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public List<uint> SubtitleID
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0xB198DC", Offset = "0xB198DC", VA = "0xB198DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		public InteractConfigData[] InsertInteracts
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0xB1A88C", Offset = "0xB1A88C", VA = "0xB1A88C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009E")]
		public long ChoiceShowTime
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0xB1AC44", Offset = "0xB1AC44", VA = "0xB1AC44")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xB198E4", Offset = "0xB198E4", VA = "0xB198E4")]
		public Plot(MainPlotData data)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xB19B1C", Offset = "0xB19B1C", VA = "0xB19B1C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x762578", Offset = "0x762578")]
		public UniTask<int> Run()
		{
			return default(UniTask<int>);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xB19BDC", Offset = "0xB19BDC", VA = "0xB19BDC")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xB19FD4", Offset = "0xB19FD4", VA = "0xB19FD4")]
		public void SkipInteract()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xB1A16C", Offset = "0xB1A16C", VA = "0xB1A16C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7625D8", Offset = "0x7625D8")]
		private void Playing(BaseVideoPlayer player, long time)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xB1A268", Offset = "0xB1A268", VA = "0xB1A268")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x762638", Offset = "0x762638")]
		private UniTask DOInteract(InteractConfigData config, BaseVideoPlayer player, long insertTime, long waitTime, [Optional] CancellationToken token)
		{
			return default(UniTask);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xB1A44C", Offset = "0xB1A44C", VA = "0xB1A44C")]
		private void OnPoseComplete(EPose pose)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xB1A46C", Offset = "0xB1A46C", VA = "0xB1A46C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x762698", Offset = "0x762698")]
		private UniTask DOPose(InteractConfigData config, [Optional] CancellationToken token)
		{
			return default(UniTask);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xB1A634", Offset = "0xB1A634", VA = "0xB1A634")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7626F8", Offset = "0x7626F8")]
		private UniTaskVoid UnlockAchievement()
		{
			return default(UniTaskVoid);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xB1A6D8", Offset = "0xB1A6D8", VA = "0xB1A6D8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x762758", Offset = "0x762758")]
		private UniTask PlayVideo(string name, float start, float end)
		{
			return default(UniTask);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xB1A894", Offset = "0xB1A894", VA = "0xB1A894")]
		private void Execute(InteractConfigData[] interact)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xB1AA10", Offset = "0xB1AA10", VA = "0xB1AA10")]
		private void OnInteractiAfter(InteractConfigData config, XRSphere sphere)
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xB1AC4C", Offset = "0xB1AC4C", VA = "0xB1AC4C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7627B8", Offset = "0x7627B8")]
		private UniTask<int> Execute(ButtonChoiceData choice)
		{
			return default(UniTask<int>);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xB1ADB4", Offset = "0xB1ADB4", VA = "0xB1ADB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x762818", Offset = "0x762818")]
		private bool <DOPose>b__26_0()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xB1ADBC", Offset = "0xB1ADBC", VA = "0xB1ADBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x762828", Offset = "0x762828")]
		internal static void <PlayVideo>g__function|28_0()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class PlotManager
	{
		[Serializable]
		[Token(Token = "0x20000C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DC5C", Offset = "0x75DC5C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<ChapterData, int> <>9__15_0;

			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x1C437B8", Offset = "0x1C437B8", VA = "0x1C437B8")]
			public <>c()
			{
			}

			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x1C437C0", Offset = "0x1C437C0", VA = "0x1C437C0")]
			internal int <Run>b__15_0(ChapterData x)
			{
				return default(int);
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000C7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DC6C", Offset = "0x75DC6C")]
		private struct <Run>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x400037A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400037B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			[Token(Token = "0x400037C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private UniTask<int>.Awaiter <>u__1;

			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x1C437D8", Offset = "0x1C437D8", VA = "0x1C437D8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x1C4537C", Offset = "0x1C4537C", VA = "0x1C4537C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<string, int> m_ParamCacheMap;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75F328", Offset = "0x75F328")]
		private static Plot <Entity>k__BackingField;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75F338", Offset = "0x75F338")]
		private static bool <Next>k__BackingField;

		[Token(Token = "0x1700009F")]
		public static Plot Entity
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0xB1B154", Offset = "0xB1B154", VA = "0xB1B154")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7628C8", Offset = "0x7628C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0xB1B1B8", Offset = "0xB1B1B8", VA = "0xB1B1B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7628D8", Offset = "0x7628D8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public static bool Next
		{
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0xB1B224", Offset = "0xB1B224", VA = "0xB1B224")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7628E8", Offset = "0x7628E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0xB1B288", Offset = "0xB1B288", VA = "0xB1B288")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7628F8", Offset = "0x7628F8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public static MainPlotData Data
		{
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0xB1B2F4", Offset = "0xB1B2F4", VA = "0xB1B2F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000018")]
		public static event Action<int> OnPlotChanged
		{
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0xB1AF6C", Offset = "0xB1AF6C", VA = "0xB1AF6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7628A8", Offset = "0x7628A8")]
			add
			{
			}
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0xB1B060", Offset = "0xB1B060", VA = "0xB1B060")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7628B8", Offset = "0x7628B8")]
			remove
			{
			}
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xB1B3A0", Offset = "0xB1B3A0", VA = "0xB1B3A0")]
		public static bool Prepare(int plotID, bool isNext = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xB1B5DC", Offset = "0xB1B5DC", VA = "0xB1B5DC")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x762908", Offset = "0x762908")]
		public static UniTaskVoid Run()
		{
			return default(UniTaskVoid);
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xB1B664", Offset = "0xB1B664", VA = "0xB1B664")]
		public static void Stop()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xB1B7C8", Offset = "0xB1B7C8", VA = "0xB1B7C8")]
		public PlotManager()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public class SceneInteractPropManager : AbstractMono, IManager
	{
		[Token(Token = "0x20000C9")]
		public class SceneInteractRayData
		{
			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UnityEngine.Vector3? Dir;

			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EPlayerProp Prop;

			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x1C4BDE8", Offset = "0x1C4BDE8", VA = "0x1C4BDE8")]
			public SceneInteractRayData()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DC7C", Offset = "0x75DC7C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<int, bool> <>9__9_0;

			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<int, bool> <>9__10_0;

			[Token(Token = "0x4000387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<int, bool> <>9__15_0;

			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x1C4BDBC", Offset = "0x1C4BDBC", VA = "0x1C4BDBC")]
			public <>c()
			{
			}

			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x1C4BDC4", Offset = "0x1C4BDC4", VA = "0x1C4BDC4")]
			internal bool <AddHighlightTex>b__9_0(int x)
			{
				return default(bool);
			}

			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x1C4BDD0", Offset = "0x1C4BDD0", VA = "0x1C4BDD0")]
			internal bool <RemoveHighlightTex>b__10_0(int x)
			{
				return default(bool);
			}

			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x1C4BDDC", Offset = "0x1C4BDDC", VA = "0x1C4BDDC")]
			internal bool <OnFocusSceneProp>b__15_0(int x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Dictionary<EHand, SceneInteractRayData> m_SceneInteractProps;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<int, List<string>> m_HighlightTexs;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private EPlayerProp m_LeftHandHighlightTex;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private EPlayerProp m_RightHandHighlightTex;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<EHand, EPlayerProp> onFocusSceneProp;

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x9D9700", Offset = "0x9D9700", VA = "0x9D9700")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x9D9C70", Offset = "0x9D9C70", VA = "0x9D9C70")]
		public void RegisterListener()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x9D9FC4", Offset = "0x9D9FC4", VA = "0x9D9FC4")]
		public void UnregisterListener()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x9DA4D4", Offset = "0x9DA4D4", VA = "0x9DA4D4")]
		public static void AddHighlightTex(EPlayerProp id, bool isNormal = false)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x9DAD50", Offset = "0x9DAD50", VA = "0x9DAD50")]
		public static void RemoveHighlightTex(EPlayerProp id, bool isNormal = false)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x9DB118", Offset = "0x9DB118", VA = "0x9DB118")]
		public static void ClearHighlightTex()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x9DB1E4", Offset = "0x9DB1E4", VA = "0x9DB1E4")]
		private void OnRay(XRControllerSwitch.RayHandler handler)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x9DB2E8", Offset = "0x9DB2E8", VA = "0x9DB2E8")]
		private void OnLeftHandActivate(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x9DB55C", Offset = "0x9DB55C", VA = "0x9DB55C")]
		private void OnRightHandActivate(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x9DB5F8", Offset = "0x9DB5F8", VA = "0x9DB5F8")]
		private void OnFocusSceneProp(EHand hand, EPlayerProp prop)
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x9DB384", Offset = "0x9DB384", VA = "0x9DB384")]
		private void OnActiveSceneProp(EPlayerProp prop)
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x9DBB34", Offset = "0x9DBB34", VA = "0x9DBB34")]
		public SceneInteractPropManager()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public class SceneOnlyScripts
	{
		[Serializable]
		[Token(Token = "0x20000CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DC8C", Offset = "0x75DC8C")]
		private sealed class <>c
		{
			[Token(Token = "0x400038D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400038E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, JSONNode> <>9__22_0;

			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<string, string> <>9__22_1;

			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x1C4BE54", Offset = "0x1C4BE54", VA = "0x1C4BE54")]
			public <>c()
			{
			}

			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x1C4BE5C", Offset = "0x1C4BE5C", VA = "0x1C4BE5C")]
			internal JSONNode <BeforeSceneLoad>b__22_0(string file)
			{
				return null;
			}

			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x1C4BEC4", Offset = "0x1C4BEC4", VA = "0x1C4BEC4")]
			internal string <BeforeSceneLoad>b__22_1(string window)
			{
				return null;
			}
		}

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75F348", Offset = "0x75F348")]
		private static Tables <Table>k__BackingField;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75F358", Offset = "0x75F358")]
		private static SaveData <Save>k__BackingField;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75F368", Offset = "0x75F368")]
		private static SettingData <Setting>k__BackingField;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75F378", Offset = "0x75F378")]
		private static int <PlayerIndex>k__BackingField;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75F388", Offset = "0x75F388")]
		private static TableGlobalConfigData <GlobalConfig>k__BackingField;

		[Token(Token = "0x170000A2")]
		public static Tables Table
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x9DBC70", Offset = "0x9DBC70", VA = "0x9DBC70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x762978", Offset = "0x762978")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x9DBCBC", Offset = "0x9DBCBC", VA = "0x9DBCBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x762988", Offset = "0x762988")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public static SaveData Save
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x9DBD10", Offset = "0x9DBD10", VA = "0x9DBD10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x762998", Offset = "0x762998")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x9DBD5C", Offset = "0x9DBD5C", VA = "0x9DBD5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7629A8", Offset = "0x7629A8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public static SettingData Setting
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x9DBDB0", Offset = "0x9DBDB0", VA = "0x9DBDB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7629B8", Offset = "0x7629B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x9DBDFC", Offset = "0x9DBDFC", VA = "0x9DBDFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7629C8", Offset = "0x7629C8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public static int PlayerIndex
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x9DBE50", Offset = "0x9DBE50", VA = "0x9DBE50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7629D8", Offset = "0x7629D8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x9DBE9C", Offset = "0x9DBE9C", VA = "0x9DBE9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7629E8", Offset = "0x7629E8")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public static PlayerData Player
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x9DAA20", Offset = "0x9DAA20", VA = "0x9DAA20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A7")]
		public static TableGlobalConfigData GlobalConfig
		{
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x9DBEEC", Offset = "0x9DBEEC", VA = "0x9DBEEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7629F8", Offset = "0x7629F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x9DBF38", Offset = "0x9DBF38", VA = "0x9DBF38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x762A08", Offset = "0x762A08")]
			private set
			{
			}
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x9DBF8C", Offset = "0x9DBF8C", VA = "0x9DBF8C")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x762A18", Offset = "0x762A18")]
		private static void BeforeSceneLoad()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x9DDCC8", Offset = "0x9DDCC8", VA = "0x9DDCC8")]
		public SceneOnlyScripts()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class SubtitleController : AbstractMono, IManager
	{
		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Dictionary<Subtitle, uint> Used;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SubtitleData m_Data;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_clockTime;

		[Token(Token = "0x170000A8")]
		public float ClockTime
		{
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x9E1FD4", Offset = "0x9E1FD4", VA = "0x9E1FD4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x9E1FDC", Offset = "0x9E1FDC", VA = "0x9E1FDC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x9E246C", Offset = "0x9E246C", VA = "0x9E246C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x9E28FC", Offset = "0x9E28FC", VA = "0x9E28FC")]
		private void OnPlay(BaseVideoPlayer player)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x9E2AE0", Offset = "0x9E2AE0", VA = "0x9E2AE0")]
		private void OnStop(BaseVideoPlayer player)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x9E2E04", Offset = "0x9E2E04", VA = "0x9E2E04")]
		private void OnVideoRePlayed(BaseVideoPlayer player)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x9E2FE0", Offset = "0x9E2FE0", VA = "0x9E2FE0")]
		private void OnTimeChanged(BaseVideoPlayer player, long time)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x9E3448", Offset = "0x9E3448", VA = "0x9E3448")]
		public SubtitleController()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class BackCanvas : XRCanvas
	{
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1C17D64", Offset = "0x1C17D64", VA = "0x1C17D64")]
		private void Start()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1C17F74", Offset = "0x1C17F74", VA = "0x1C17F74")]
		public BackCanvas()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class FarCanvas : XRCanvas
	{
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1C22468", Offset = "0x1C22468", VA = "0x1C22468")]
		public FarCanvas()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public class LogoCanvas : XRCanvas
	{
		[Token(Token = "0x6000401")]
		[Address(RVA = "0xB0B2E8", Offset = "0xB0B2E8", VA = "0xB0B2E8")]
		public LogoCanvas()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class MainCanvas : XRCanvas
	{
		[Token(Token = "0x6000402")]
		[Address(RVA = "0xB0B4F0", Offset = "0xB0B4F0", VA = "0xB0B4F0")]
		public MainCanvas()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class MenuCanvas : XRCanvas
	{
		[Token(Token = "0x6000403")]
		[Address(RVA = "0xB0F57C", Offset = "0xB0F57C", VA = "0xB0F57C")]
		public MenuCanvas()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class MidCanvas : XRCanvas
	{
		[Token(Token = "0x6000404")]
		[Address(RVA = "0xB0F584", Offset = "0xB0F584", VA = "0xB0F584")]
		public MidCanvas()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class NearCanvas : XRCanvas
	{
		[Token(Token = "0x6000405")]
		[Address(RVA = "0xB0F998", Offset = "0xB0F998", VA = "0xB0F998")]
		private void Start()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xB0F99C", Offset = "0xB0F99C", VA = "0xB0F99C")]
		public NearCanvas()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class RelativeCanvas : XRCanvas
	{
		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_Camera;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_Z;

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xB22B10", Offset = "0xB22B10", VA = "0xB22B10")]
		private void Start()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xB22BD4", Offset = "0xB22BD4", VA = "0xB22BD4", Slot = "9")]
		protected override void OnXROriginTransform(PoseData data)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xB22D68", Offset = "0xB22D68", VA = "0xB22D68")]
		public RelativeCanvas()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class PhotoAlbumItemUI : MonoBehaviour
	{
		[StructLayout(3)]
		[Token(Token = "0x20000D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DC9C", Offset = "0x75DC9C")]
		private struct <SetData>d__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PhotoAlbumItemUI <>4__this;

			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PhotoData data;

			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Image <>7__wrap1;

			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter <>u__1;

			[Token(Token = "0x600040F")]
			[Address(RVA = "0x1C10F8C", Offset = "0x1C10F8C", VA = "0x1C10F8C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000410")]
			[Address(RVA = "0x1C11680", Offset = "0x1C11680", VA = "0x1C11680", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PhotoData m_Data;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button m_Select;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image m_Picture;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_Locked;

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xB10AE4", Offset = "0xB10AE4", VA = "0xB10AE4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xB10B80", Offset = "0xB10B80", VA = "0xB10B80")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xB10C1C", Offset = "0xB10C1C", VA = "0xB10C1C")]
		private void OnClick()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xB10DF4", Offset = "0xB10DF4", VA = "0xB10DF4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x762A2C", Offset = "0x762A2C")]
		public UniTaskVoid SetData(PhotoData data)
		{
			return default(UniTaskVoid);
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xB10EB8", Offset = "0xB10EB8", VA = "0xB10EB8")]
		public PhotoAlbumItemUI()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class PhotoAlbumPageUI : AbstractMono
	{
		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly List<PhotoAlbumItemUI> m_List;

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xB10EC0", Offset = "0xB10EC0", VA = "0xB10EC0")]
		public void SetData(PhotoData[] photos)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xB111A4", Offset = "0xB111A4", VA = "0xB111A4")]
		public PhotoAlbumPageUI()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class PlotTreeBadEndUI : MonoBehaviour
	{
		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button m_ClickBtn;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_BadEnd;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_Locked;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text m_PlotName;

		[Token(Token = "0x170000A9")]
		public int PlotID
		{
			[Token(Token = "0x6000413")]
			[Address(RVA = "0xB1BCBC", Offset = "0xB1BCBC", VA = "0xB1BCBC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xB1BCD8", Offset = "0xB1BCD8", VA = "0xB1BCD8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xB1BE70", Offset = "0xB1BE70", VA = "0xB1BE70")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xB1BF0C", Offset = "0xB1BF0C", VA = "0xB1BF0C")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xB1BFE8", Offset = "0xB1BFE8", VA = "0xB1BFE8")]
		private void OnClick()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xB1C29C", Offset = "0xB1C29C", VA = "0xB1C29C")]
		public PlotTreeBadEndUI()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class PlotTreeChapterItemUI : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DCAC", Offset = "0x75DCAC")]
		private sealed class <>c
		{
			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<ChapterData, int> <>9__13_0;

			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<ChapterData, int> <>9__14_0;

			[Token(Token = "0x6000424")]
			[Address(RVA = "0x1C453EC", Offset = "0x1C453EC", VA = "0x1C453EC")]
			public <>c()
			{
			}

			[Token(Token = "0x6000425")]
			[Address(RVA = "0x1C453F4", Offset = "0x1C453F4", VA = "0x1C453F4")]
			internal int <OnClick>b__13_0(ChapterData x)
			{
				return default(int);
			}

			[Token(Token = "0x6000426")]
			[Address(RVA = "0x1C4540C", Offset = "0x1C4540C", VA = "0x1C4540C")]
			internal int <RefreshUI>b__14_0(ChapterData x)
			{
				return default(int);
			}
		}

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button m_Click;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text m_ChapterText;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text m_NameText;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_Unlock;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject m_Locked;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image m_Fill;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text m_Percent;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text m_Progress;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_Chapter;

		[Token(Token = "0x170000AA")]
		public int Chapter
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0xB1C2A4", Offset = "0xB1C2A4", VA = "0xB1C2A4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xB1C2AC", Offset = "0xB1C2AC", VA = "0xB1C2AC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xB1C348", Offset = "0xB1C348", VA = "0xB1C348")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xB1C3E4", Offset = "0xB1C3E4", VA = "0xB1C3E4")]
		private void OnClick()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xB1CAD0", Offset = "0xB1CAD0", VA = "0xB1CAD0")]
		private void RefreshUI()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xB1D1E8", Offset = "0xB1D1E8", VA = "0xB1D1E8")]
		public void SetData(int chapter)
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xB1D1F0", Offset = "0xB1D1F0", VA = "0xB1D1F0")]
		public PlotTreeChapterItemUI()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xB1D1F8", Offset = "0xB1D1F8", VA = "0xB1D1F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x762A9C", Offset = "0x762A9C")]
		private bool <OnClick>b__13_1(MainPlotData x)
		{
			return default(bool);
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xB1D21C", Offset = "0xB1D21C", VA = "0xB1D21C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x762AAC", Offset = "0x762AAC")]
		private bool <RefreshUI>b__14_1(MainPlotData item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xB1D240", Offset = "0xB1D240", VA = "0xB1D240")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x762ABC", Offset = "0x762ABC")]
		private bool <RefreshUI>b__14_2(MainPlotData item)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000DC")]
	public class PlotTreeChoiceUI : UIPanel
	{
		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PlotTreeItemUI m_First;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PlotTreeItemUI m_Second;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button m_Back;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private MainPlotData[] m_Choices;

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xB1D9B4", Offset = "0xB1D9B4", VA = "0xB1D9B4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xB1DA40", Offset = "0xB1DA40", VA = "0xB1DA40")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xB1DACC", Offset = "0xB1DACC", VA = "0xB1DACC")]
		private void RefreshUI()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xB1DBF8", Offset = "0xB1DBF8", VA = "0xB1DBF8", Slot = "9")]
		public override void Open([Optional] object arg)
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xB1DC90", Offset = "0xB1DC90", VA = "0xB1DC90", Slot = "6")]
		protected override Transform GetCanvas()
		{
			return null;
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xB1DD10", Offset = "0xB1DD10", VA = "0xB1DD10")]
		public PlotTreeChoiceUI()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class PlotTreeClothesItemUI : MonoBehaviour
	{
		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> Plots;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button m_ClickBtn;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_Picture;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_LockedIcon;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text m_PlotName;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_IsNext;

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xB1DD74", Offset = "0xB1DD74", VA = "0xB1DD74")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xB1E070", Offset = "0xB1E070", VA = "0xB1E070")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xB1E10C", Offset = "0xB1E10C", VA = "0xB1E10C")]
		private void OnClick()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xB1E3C0", Offset = "0xB1E3C0", VA = "0xB1E3C0")]
		public PlotTreeClothesItemUI()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class PlotTreeItemUI : MonoBehaviour
	{
		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button m_ClickBtn;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_Picture;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_LockedIcon;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text m_PlotName;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_IsNext;

		[Token(Token = "0x170000AB")]
		public int PlotID
		{
			[Token(Token = "0x6000431")]
			[Address(RVA = "0xB1E444", Offset = "0xB1E444", VA = "0xB1E444")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000AC")]
		public bool IsNext
		{
			[Token(Token = "0x6000432")]
			[Address(RVA = "0xB1E460", Offset = "0xB1E460", VA = "0xB1E460")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xB1E468", Offset = "0xB1E468", VA = "0xB1E468")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xB1E744", Offset = "0xB1E744", VA = "0xB1E744")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xB1E7E0", Offset = "0xB1E7E0", VA = "0xB1E7E0")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xB1E8BC", Offset = "0xB1E8BC", VA = "0xB1E8BC")]
		private void OnClick()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xB1EB78", Offset = "0xB1EB78", VA = "0xB1EB78")]
		public PlotTreeItemUI()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class PlotTreeNextUI : MonoBehaviour
	{
		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int m_NextChapter;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button m_Click;

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xB1EB80", Offset = "0xB1EB80", VA = "0xB1EB80")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xB1EC38", Offset = "0xB1EC38", VA = "0xB1EC38")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xB1ECD4", Offset = "0xB1ECD4", VA = "0xB1ECD4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xB1ED70", Offset = "0xB1ED70", VA = "0xB1ED70")]
		private void OnClick()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xB1EE84", Offset = "0xB1EE84", VA = "0xB1EE84")]
		public PlotTreeNextUI()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public class SaveItemUI : MonoBehaviour
	{
		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button m_Btn;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text m_Title;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text m_Chapter;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text m_Date;

		[Token(Token = "0x170000AD")]
		public Button Btn
		{
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x9D8964", Offset = "0x9D8964", VA = "0x9D8964")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AE")]
		public Text Title
		{
			[Token(Token = "0x600043E")]
			[Address(RVA = "0x9D896C", Offset = "0x9D896C", VA = "0x9D896C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AF")]
		public Text Chapter
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x9D8974", Offset = "0x9D8974", VA = "0x9D8974")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B0")]
		public Text Date
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x9D897C", Offset = "0x9D897C", VA = "0x9D897C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x9D8984", Offset = "0x9D8984", VA = "0x9D8984")]
		public void SetData(PlayerData data, bool isCreate)
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x9D8F00", Offset = "0x9D8F00", VA = "0x9D8F00")]
		public SaveItemUI()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	internal struct DownloadSpeedNode
	{
		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float Interval;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public long Size;
	}
	[Token(Token = "0x20000E2")]
	public class VideoDownloadItemUI : MonoBehaviour
	{
		[StructLayout(3)]
		[Token(Token = "0x20000E3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DCBC", Offset = "0x75DCBC")]
		private struct <Download>d__23 : IAsyncStateMachine
		{
			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public VideoDownloadItemUI <>4__this;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private EDefinition <def>5__2;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<bool>.Awaiter <>u__1;

			[Token(Token = "0x600044E")]
			[Address(RVA = "0x1C58818", Offset = "0x1C58818", VA = "0x1C58818", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600044F")]
			[Address(RVA = "0x1C59554", Offset = "0x1C59554", VA = "0x1C59554", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DCCC", Offset = "0x75DCCC")]
		private struct <<Awake>b__16_0>d : IAsyncStateMachine
		{
			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public VideoDownloadItemUI <>4__this;

			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private EDefinition <def>5__2;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<bool>.Awaiter <>u__1;

			[Token(Token = "0x6000450")]
			[Address(RVA = "0x1C57F44", Offset = "0x1C57F44", VA = "0x1C57F44", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000451")]
			[Address(RVA = "0x1C5880C", Offset = "0x1C5880C", VA = "0x1C5880C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text m_ChapterName;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text m_ChapterTitle;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image m_Progress;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text m_DownloadState;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image m_Play;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image m_Pause;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image m_Complete;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button m_DownloadBtn;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button m_PlayPauseBtn;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button m_DeleteBtn;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int m_Chapter;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private DownloadTask m_Task;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private UnityAction m_DownloadAction;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private UnityAction m_DeleteAction;

		[Token(Token = "0x170000B1")]
		public bool Downloading
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x9F4ADC", Offset = "0x9F4ADC", VA = "0x9F4ADC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x9F4B04", Offset = "0x9F4B04", VA = "0x9F4B04")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x9F4C24", Offset = "0x9F4C24", VA = "0x9F4C24")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x9F4CF8", Offset = "0x9F4CF8", VA = "0x9F4CF8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x9F4DCC", Offset = "0x9F4DCC", VA = "0x9F4DCC")]
		public void SetData(int chapter)
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x9F4E90", Offset = "0x9F4E90", VA = "0x9F4E90")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x9F5440", Offset = "0x9F5440", VA = "0x9F5440")]
		public void Stop()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x9F557C", Offset = "0x9F557C", VA = "0x9F557C")]
		private void PlayPause()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x9F54D8", Offset = "0x9F54D8", VA = "0x9F54D8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x762ACC", Offset = "0x762ACC")]
		private UniTaskVoid Download()
		{
			return default(UniTaskVoid);
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x9F55BC", Offset = "0x9F55BC", VA = "0x9F55BC")]
		public VideoDownloadItemUI()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x9F55C4", Offset = "0x9F55C4", VA = "0x9F55C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x762B2C", Offset = "0x762B2C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x762B2C", Offset = "0x762B2C")]
		private UniTaskVoid <Awake>b__16_0()
		{
			return default(UniTaskVoid);
		}
	}
	[Token(Token = "0x20000E5")]
	public class MenuButtonHighlight : ButtonHighlight
	{
		[StructLayout(3)]
		[Token(Token = "0x20000E6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DCDC", Offset = "0x75DCDC")]
		private struct <OnPointerExit>d__3 : IAsyncStateMachine
		{
			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MenuButtonHighlight <>4__this;

			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public PointerEventData eventData;

			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x6000456")]
			[Address(RVA = "0x1C10D2C", Offset = "0x1C10D2C", VA = "0x1C10D2C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0x1C10F80", Offset = "0x1C10F80", VA = "0x1C10F80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject AnimationSprite;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject AnimationLine;

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xB0F3E0", Offset = "0xB0F3E0", VA = "0xB0F3E0", Slot = "10")]
		public override void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xB0F46C", Offset = "0xB0F46C", VA = "0xB0F46C", Slot = "11")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x762BBC", Offset = "0x762BBC")]
		public override void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xB0F56C", Offset = "0xB0F56C", VA = "0xB0F56C")]
		public MenuButtonHighlight()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xB0F574", Offset = "0xB0F574", VA = "0xB0F574")]
		[DebuggerHidden]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x762C1C", Offset = "0x762C1C")]
		private void <>n__0(PointerEventData eventData)
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class BadEndWindowUI : UIPanel, IEnumerator
	{
		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RenderTexture m_RenderTexture;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VideoPlayer player;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RawImage m_RawImage;

		[Token(Token = "0x170000B2")]
		public object Current
		{
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x1C17F7C", Offset = "0x1C17F7C", VA = "0x1C17F7C", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x1C17F84", Offset = "0x1C17F84", VA = "0x1C17F84", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x1C180B0", Offset = "0x1C180B0", VA = "0x1C180B0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x1C182AC", Offset = "0x1C182AC", VA = "0x1C182AC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x1C18360", Offset = "0x1C18360", VA = "0x1C18360", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x1C18400", Offset = "0x1C18400", VA = "0x1C18400")]
		private void OnPrepareCompleted(VideoPlayer player)
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x1C1841C", Offset = "0x1C1841C", VA = "0x1C1841C")]
		private void OnPlayStop(VideoPlayer p)
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x1C18164", Offset = "0x1C18164", VA = "0x1C18164")]
		private RenderTexture GetRenderTexture()
		{
			return null;
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x1C18428", Offset = "0x1C18428", VA = "0x1C18428", Slot = "6")]
		protected override Transform GetCanvas()
		{
			return null;
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x1C184A8", Offset = "0x1C184A8", VA = "0x1C184A8", Slot = "9")]
		public override void Open([Optional] object arg)
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x1C184FC", Offset = "0x1C184FC", VA = "0x1C184FC", Slot = "10")]
		public override void Close()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x1C18544", Offset = "0x1C18544", VA = "0x1C18544", Slot = "11")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x1C18568", Offset = "0x1C18568", VA = "0x1C18568", Slot = "13")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1C1856C", Offset = "0x1C1856C", VA = "0x1C1856C")]
		public BadEndWindowUI()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class DialogWindowUI : UIPanel, IEnumerator
	{
		[Token(Token = "0x20000E9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DCEC", Offset = "0x75DCEC")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int index;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DialogWindowUI <>4__this;

			[Token(Token = "0x6000475")]
			[Address(RVA = "0x1C0AA8C", Offset = "0x1C0AA8C", VA = "0x1C0AA8C")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x6000476")]
			[Address(RVA = "0x1C0AA94", Offset = "0x1C0AA94", VA = "0x1C0AA94")]
			internal void <RefreshUI>g__function|0()
			{
			}
		}

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text m_TalkerName;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text m_TalkMessage;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75F698", Offset = "0x75F698")]
		private int <Result>k__BackingField;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject m_ChoicePanel;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject m_OptionCell;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject m_TalkPanle;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ButtonChoiceData m_ChoicePlotData;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<GameObject> m_CellPool;

		[Token(Token = "0x170000B3")]
		public Text TalkerName
		{
			[Token(Token = "0x6000466")]
			[Address(RVA = "0x1C20A94", Offset = "0x1C20A94", VA = "0x1C20A94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B4")]
		public Text TalkMessage
		{
			[Token(Token = "0x6000467")]
			[Address(RVA = "0x1C20A9C", Offset = "0x1C20A9C", VA = "0x1C20A9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B5")]
		public int Result
		{
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x1C20AA4", Offset = "0x1C20AA4", VA = "0x1C20AA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x762C64", Offset = "0x762C64")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000469")]
			[Address(RVA = "0x1C20AAC", Offset = "0x1C20AAC", VA = "0x1C20AAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x762C74", Offset = "0x762C74")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public object Current
		{
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x1C20AB4", Offset = "0x1C20AB4", VA = "0x1C20AB4", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x1C20ABC", Offset = "0x1C20ABC", VA = "0x1C20ABC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x1C20B20", Offset = "0x1C20B20", VA = "0x1C20B20", Slot = "9")]
		public override void Open([Optional] object arg)
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x1C20F40", Offset = "0x1C20F40", VA = "0x1C20F40", Slot = "10")]
		public override void Close()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x1C21028", Offset = "0x1C21028", VA = "0x1C21028", Slot = "11")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x1C2104C", Offset = "0x1C2104C", VA = "0x1C2104C", Slot = "13")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x1C20C70", Offset = "0x1C20C70", VA = "0x1C20C70")]
		private void RefreshUI()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x1C2116C", Offset = "0x1C2116C", VA = "0x1C2116C")]
		private GameObject GetCell()
		{
			return null;
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x1C21050", Offset = "0x1C21050", VA = "0x1C21050")]
		private void ReleasePool()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x1C21394", Offset = "0x1C21394", VA = "0x1C21394", Slot = "6")]
		protected override Transform GetCanvas()
		{
			return null;
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x1C21414", Offset = "0x1C21414", VA = "0x1C21414")]
		public DialogWindowUI()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class FirstHomeTipWindowUI : UIPanel
	{
		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text m_Message;

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x1C22470", Offset = "0x1C22470", VA = "0x1C22470", Slot = "9")]
		public override void Open([Optional] object arg)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x1C22510", Offset = "0x1C22510", VA = "0x1C22510", Slot = "6")]
		protected override Transform GetCanvas()
		{
			return null;
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x1C22590", Offset = "0x1C22590", VA = "0x1C22590")]
		public FirstHomeTipWindowUI()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class GMWindowUI : UIPanel
	{
		[StructLayout(3)]
		[Token(Token = "0x20000EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DCFC", Offset = "0x75DCFC")]
		private struct <OnGetOrdersList>d__27 : IAsyncStateMachine
		{
			[Token(Token = "0x4000409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400040A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x400040B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<(APIRequestResult, List<OrderInfo>)>.Awaiter <>u__1;

			[Token(Token = "0x600048F")]
			[Address(RVA = "0x1C0C6C4", Offset = "0x1C0C6C4", VA = "0x1C0C6C4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000490")]
			[Address(RVA = "0x1C0CDA4", Offset = "0x1C0CDA4", VA = "0x1C0CDA4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000ED")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DD0C", Offset = "0x75DD0C")]
		private struct <OnUnlockAchievement>d__28 : IAsyncStateMachine
		{
			[Token(Token = "0x400040C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400040D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x400040E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GMWindowUI <>4__this;

			[Token(Token = "0x400040F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private EAchievement <achievement>5__2;

			[Token(Token = "0x4000410")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <index>5__3;

			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TupleElementNamesAttribute", RVA = "0x75F828", Offset = "0x75F828")]
			private UniTask<(APIRequestResult, bool)>.Awaiter <>u__1;

			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TupleElementNamesAttribute", RVA = "0x75F8C4", Offset = "0x75F8C4")]
			private UniTask<(APIRequestResult, AchievementData)>.Awaiter <>u__2;

			[Token(Token = "0x6000491")]
			[Address(RVA = "0x1C0CDB0", Offset = "0x1C0CDB0", VA = "0x1C0CDB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0x1C0DC58", Offset = "0x1C0DC58", VA = "0x1C0DC58", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Slider m_VideoSpeedSlider;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text m_VideoSpeedText;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Slider m_CameraDistanceSlider;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text m_CameraDistanceText;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Slider m_VibrationStrengthSlider;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text m_VibrationStrengthText;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Slider m_VibrationTimeSlider;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text m_VibrationTimeText;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button m_OpenConsoleWindow;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button m_ClearSaveData;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button m_OpenTransformWindow;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Button m_OpenPoseWindow;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Button m_GetOrdersList;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Button m_UnlockAchievement;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Toggle m_Admin;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Toggle m_Grab;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Toggle m_VideoLog;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Toggle m_CloudPlayback;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Dropdown m_AchievementID;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Dropdown m_AchievementIndex;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float defaultScale;

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x1C225F4", Offset = "0x1C225F4", VA = "0x1C225F4")]
		private void Start()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x1C228E4", Offset = "0x1C228E4", VA = "0x1C228E4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x1C22EA0", Offset = "0x1C22EA0", VA = "0x1C22EA0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x1C23470", Offset = "0x1C23470", VA = "0x1C23470")]
		private void Update()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x1C235BC", Offset = "0x1C235BC", VA = "0x1C235BC")]
		private void OnOpenTransformWindow()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x1C23644", Offset = "0x1C23644", VA = "0x1C23644")]
		private void OnOpenPoseWindow()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x1C236CC", Offset = "0x1C236CC", VA = "0x1C236CC")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x762C84", Offset = "0x762C84")]
		private void OnGetOrdersList()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x1C23790", Offset = "0x1C23790", VA = "0x1C23790")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x762CE4", Offset = "0x762CE4")]
		private void OnUnlockAchievement()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x1C23868", Offset = "0x1C23868", VA = "0x1C23868")]
		private void OnCloudPlayback(bool enable)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x1C2389C", Offset = "0x1C2389C", VA = "0x1C2389C")]
		private void OnAdmin(bool isOn)
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x1C238CC", Offset = "0x1C238CC", VA = "0x1C238CC")]
		private void OnSetGrab(bool isOn)
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x1C23930", Offset = "0x1C23930", VA = "0x1C23930")]
		private void OnSetVideoLog(bool isOn)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x1C239DC", Offset = "0x1C239DC", VA = "0x1C239DC")]
		private void OnXROriginTransform(PoseData data)
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x1C23A50", Offset = "0x1C23A50", VA = "0x1C23A50")]
		private void OnClearSaveData()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x1C23AF4", Offset = "0x1C23AF4", VA = "0x1C23AF4")]
		private void OnVideoSpeedChanged(float value)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x1C227DC", Offset = "0x1C227DC", VA = "0x1C227DC")]
		private void OnCameraDistanceChanged(float value)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x1C23B60", Offset = "0x1C23B60", VA = "0x1C23B60")]
		private void OnVibrationStrengthChanged(float value)
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x1C23CA4", Offset = "0x1C23CA4", VA = "0x1C23CA4")]
		private void OnVibrationTimeChanged(float value)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x1C23DE8", Offset = "0x1C23DE8", VA = "0x1C23DE8")]
		private void OnOpenConsoleWindow()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x1C23E70", Offset = "0x1C23E70", VA = "0x1C23E70", Slot = "6")]
		protected override Transform GetCanvas()
		{
			return null;
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x1C23EF0", Offset = "0x1C23EF0", VA = "0x1C23EF0")]
		public GMWindowUI()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class LoadingWindowUI : UIPanel
	{
		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_Icon;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text m_Progress;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_Speed;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float m_AngleZ;

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xB0B150", Offset = "0xB0B150", VA = "0xB0B150")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xB0B1B4", Offset = "0xB0B1B4", VA = "0xB0B1B4")]
		public void SetProgress(float value)
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xB0B278", Offset = "0xB0B278", VA = "0xB0B278")]
		public LoadingWindowUI()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class MainMenuWindowUI : AbstractMono, IWindow
	{
		[StructLayout(3)]
		[Token(Token = "0x20000F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DD1C", Offset = "0x75DD1C")]
		private struct <OnGameOver>d__16 : IAsyncStateMachine
		{
			[Token(Token = "0x400041E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400041F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			[Token(Token = "0x4000420")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private UniTask<bool>.Awaiter <>u__1;

			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x1C0F888", Offset = "0x1C0F888", VA = "0x1C0F888", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x1C0FDF0", Offset = "0x1C0FDF0", VA = "0x1C0FDF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_Logo;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_Layout;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button m_StartGame;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button m_ContinueGame;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button m_Setting;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button m_GameOver;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UnityAction m_GameOverAction;

		[Token(Token = "0x170000B7")]
		public GameObject Logo
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0xB0B4F8", Offset = "0xB0B4F8", VA = "0xB0B4F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xB0B500", Offset = "0xB0B500", VA = "0xB0B500", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xB0B5D8", Offset = "0xB0B5D8", VA = "0xB0B5D8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xB0B780", Offset = "0xB0B780", VA = "0xB0B780")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xB0B8D8", Offset = "0xB0B8D8", VA = "0xB0B8D8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xB0BA30", Offset = "0xB0BA30", VA = "0xB0BA30")]
		private void OnStartGame()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xB0BB94", Offset = "0xB0BB94", VA = "0xB0BB94")]
		private void OnContinueGame()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xB0BC64", Offset = "0xB0BC64", VA = "0xB0BC64")]
		private void OnSetting()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xB0BCF8", Offset = "0xB0BCF8", VA = "0xB0BCF8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x762D64", Offset = "0x762D64")]
		private UniTaskVoid OnGameOver()
		{
			return default(UniTaskVoid);
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xB0BD80", Offset = "0xB0BD80", VA = "0xB0BD80", Slot = "7")]
		public void Open([Optional] object arg)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xB0BAFC", Offset = "0xB0BAFC", VA = "0xB0BAFC", Slot = "8")]
		public void Close()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xB0BE18", Offset = "0xB0BE18", VA = "0xB0BE18")]
		public MainMenuWindowUI()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xB0BE7C", Offset = "0xB0BE7C", VA = "0xB0BE7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x762DC4", Offset = "0x762DC4")]
		private void <Start>b__10_0()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class ManualWindowUI : UIPanel, IEnumerator
	{
		[Token(Token = "0x4000421")]
		private const string PICO_NEO3 = "Pico Neo 3";

		[Token(Token = "0x4000422")]
		private const string PICO_4 = "PICO 4";

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button m_Close;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_PicoNeo3;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_Pico4;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject m_Qiyu;

		[Token(Token = "0x170000B8")]
		public object Current
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0xB0EFDC", Offset = "0xB0EFDC", VA = "0xB0EFDC", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xB0EFE4", Offset = "0xB0EFE4", VA = "0xB0EFE4")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xB0F23C", Offset = "0xB0F23C", VA = "0xB0F23C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xB0F2C8", Offset = "0xB0F2C8", VA = "0xB0F2C8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xB0F354", Offset = "0xB0F354", VA = "0xB0F354", Slot = "11")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xB0F378", Offset = "0xB0F378", VA = "0xB0F378", Slot = "13")]
		public void Reset()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xB0F37C", Offset = "0xB0F37C", VA = "0xB0F37C")]
		public ManualWindowUI()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class MonitorPoseWindowUI : UIPanel
	{
		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text m_Nod;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text m_Refuse;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text m_LookAround;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text m_Bye;

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xB0F58C", Offset = "0xB0F58C", VA = "0xB0F58C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xB0F934", Offset = "0xB0F934", VA = "0xB0F934")]
		public MonitorPoseWindowUI()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public class PhotoAlbumWindowUI : UIPanel
	{
		[StructLayout(3)]
		[Token(Token = "0x20000F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DD2C", Offset = "0x75DD2C")]
		private struct <OnExport>d__18 : IAsyncStateMachine
		{
			[Token(Token = "0x4000435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000436")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			[Token(Token = "0x4000437")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PhotoAlbumWindowUI <>4__this;

			[Token(Token = "0x4000438")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private bool <result>5__2;

			[Token(Token = "0x4000439")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private List<PhotoData>.Enumerator <>7__wrap2;

			[Token(Token = "0x400043A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private PhotoData <item>5__4;

			[Token(Token = "0x400043B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<Texture2D>.Awaiter <>u__1;

			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x1C11778", Offset = "0x1C11778", VA = "0x1C11778", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x1C1216C", Offset = "0x1C1216C", VA = "0x1C1216C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DD3C", Offset = "0x75DD3C")]
		private sealed class <>c
		{
			[Token(Token = "0x400043C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400043D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<MainPlotData, IEnumerable<int>> <>9__20_0;

			[Token(Token = "0x400043E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<int, PhotoData> <>9__20_1;

			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x1C116F0", Offset = "0x1C116F0", VA = "0x1C116F0")]
			public <>c()
			{
			}

			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x1C116F8", Offset = "0x1C116F8", VA = "0x1C116F8")]
			internal IEnumerable<int> <InitFuncCallBack>b__20_0(MainPlotData x)
			{
				return null;
			}

			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x1C11710", Offset = "0x1C11710", VA = "0x1C11710")]
			internal PhotoData <InitFuncCallBack>b__20_1(int x)
			{
				return null;
			}
		}

		[Token(Token = "0x400042B")]
		public const int PAGE_CELL_COUNT = 9;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75FA70", Offset = "0x75FA70")]
		private GameObjectPool <ItemPool>k__BackingField;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private FlipPageCircularScrollView m_Scroll;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text m_Page;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button m_Pre;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button m_Next;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button m_Back;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button m_Export;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_Size;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private UnityAction m_ExportAction;

		[Token(Token = "0x170000B9")]
		public GameObjectPool ItemPool
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0xB11254", Offset = "0xB11254", VA = "0xB11254")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x762DE4", Offset = "0x762DE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0xB1125C", Offset = "0xB1125C", VA = "0xB1125C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x762DF4", Offset = "0x762DF4")]
			private set
			{
			}
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xB11264", Offset = "0xB11264", VA = "0xB11264", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xB11408", Offset = "0xB11408", VA = "0xB11408")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xB115FC", Offset = "0xB115FC", VA = "0xB115FC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xB117F0", Offset = "0xB117F0", VA = "0xB117F0")]
		private void OnPrePage()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xB11814", Offset = "0xB11814", VA = "0xB11814")]
		private void OnNextPage()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xB11838", Offset = "0xB11838", VA = "0xB11838")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x762E04", Offset = "0x762E04")]
		private UniTaskVoid OnExport()
		{
			return default(UniTaskVoid);
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xB118DC", Offset = "0xB118DC", VA = "0xB118DC")]
		private void RefreshUI()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xB119C0", Offset = "0xB119C0", VA = "0xB119C0")]
		private void InitFuncCallBack(int index, GameObject go)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xB11CFC", Offset = "0xB11CFC", VA = "0xB11CFC")]
		private void FuncOnPageCallBack(int page)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xB11E20", Offset = "0xB11E20", VA = "0xB11E20", Slot = "9")]
		public override void Open([Optional] object arg)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xB11E4C", Offset = "0xB11E4C", VA = "0xB11E4C", Slot = "6")]
		protected override Transform GetCanvas()
		{
			return null;
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xB11ECC", Offset = "0xB11ECC", VA = "0xB11ECC")]
		public PhotoAlbumWindowUI()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class PhotoWallWindowUI : UIPanel
	{
		[StructLayout(3)]
		[Token(Token = "0x20000F7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DD4C", Offset = "0x75DD4C")]
		private struct <OnInitScrollRect>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4000449")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400044A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject gameObject;

			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public PhotoWallWindowUI <>4__this;

			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int index;

			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Image <>7__wrap1;

			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<Sprite>.Awaiter <>u__1;

			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x1C12178", Offset = "0x1C12178", VA = "0x1C12178", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x1C125E4", Offset = "0x1C125E4", VA = "0x1C125E4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FlipPageCircularScrollView m_ScrollView;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform m_Layout;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_Point;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button m_Pre;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button m_Next;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject m_Locked;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly List<GameObject> m_PointList;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GameObjectPool PointPool;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MainPlotData m_Data;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private uint m_Timer;

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xB124E0", Offset = "0xB124E0", VA = "0xB124E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xB12694", Offset = "0xB12694", VA = "0xB12694")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x762E74", Offset = "0x762E74")]
		private void OnInitScrollRect(int index, GameObject gameObject)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xB12790", Offset = "0xB12790", VA = "0xB12790")]
		private void OnPageFunc(int page)
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xB12914", Offset = "0xB12914", VA = "0xB12914")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xB12A00", Offset = "0xB12A00", VA = "0xB12A00")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xB12AEC", Offset = "0xB12AEC", VA = "0xB12AEC", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xB12AF4", Offset = "0xB12AF4", VA = "0xB12AF4")]
		private void OnPlotChanged(int id)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xB12E70", Offset = "0xB12E70", VA = "0xB12E70")]
		private void OnPagePre()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xB12EBC", Offset = "0xB12EBC", VA = "0xB12EBC")]
		private void OnPageNext()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xB1286C", Offset = "0xB1286C", VA = "0xB1286C")]
		private void AutoCarousel()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xB12F04", Offset = "0xB12F04", VA = "0xB12F04", Slot = "6")]
		protected override Transform GetCanvas()
		{
			return null;
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xB12F84", Offset = "0xB12F84", VA = "0xB12F84", Slot = "10")]
		public override void Close()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xB12FB0", Offset = "0xB12FB0", VA = "0xB12FB0")]
		public PhotoWallWindowUI()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xB13060", Offset = "0xB13060", VA = "0xB13060")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x762ED4", Offset = "0x762ED4")]
		private void <AutoCarousel>b__19_0(uint u)
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class PhotoWindowUI : UIPanel
	{
		[StructLayout(3)]
		[Token(Token = "0x20000F9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DD5C", Offset = "0x75DD5C")]
		private struct <Open>d__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object arg;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public PhotoWindowUI <>4__this;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter <>u__1;

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x1C125F0", Offset = "0x1C125F0", VA = "0x1C125F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x1C1290C", Offset = "0x1C1290C", VA = "0x1C1290C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000FA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DD6C", Offset = "0x75DD6C")]
		private struct <SetTexture>d__9 : IAsyncStateMachine
		{
			[Token(Token = "0x400045A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400045C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PhotoWindowUI <>4__this;

			[Token(Token = "0x400045D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string texName;

			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Texture2D>.Awaiter <>u__1;

			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x1C12918", Offset = "0x1C12918", VA = "0x1C12918", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x1C12FD4", Offset = "0x1C12FD4", VA = "0x1C12FD4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RawImage m_Picture;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button m_Close;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button m_Save;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string m_TexName;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Texture2D m_MainTex;

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xB13064", Offset = "0xB13064", VA = "0xB13064")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xB13140", Offset = "0xB13140", VA = "0xB13140")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xB1321C", Offset = "0xB1321C", VA = "0xB1321C")]
		private void OnSavePicture()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xB13364", Offset = "0xB13364", VA = "0xB13364", Slot = "9")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x762EF4", Offset = "0x762EF4")]
		public override void Open([Optional] object arg)
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xB13458", Offset = "0xB13458", VA = "0xB13458")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x762F54", Offset = "0x762F54")]
		private UniTask SetTexture(string texName)
		{
			return default(UniTask);
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xB135FC", Offset = "0xB135FC", VA = "0xB135FC", Slot = "6")]
		protected override Transform GetCanvas()
		{
			return null;
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xB1367C", Offset = "0xB1367C", VA = "0xB1367C")]
		public PhotoWindowUI()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xB136E0", Offset = "0xB136E0", VA = "0xB136E0")]
		[DebuggerHidden]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x762FB4", Offset = "0x762FB4")]
		private void <>n__0(object arg)
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public class PlotTreeChapterUI : UIPanel
	{
		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UICircularScrollView m_ScrollView;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button m_Back;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ScrollRect m_Rect;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UnityEngine.Vector2 m_AxisValue;

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xB1D298", Offset = "0xB1D298", VA = "0xB1D298", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xB1D398", Offset = "0xB1D398", VA = "0xB1D398")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xB1D4F4", Offset = "0xB1D4F4", VA = "0xB1D4F4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xB1D650", Offset = "0xB1D650", VA = "0xB1D650")]
		private void Update()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xB1D710", Offset = "0xB1D710", VA = "0xB1D710")]
		private void OnScrollRectInitFunc(int index, GameObject item)
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xB1D77C", Offset = "0xB1D77C", VA = "0xB1D77C")]
		private void OnTouchPadAxis(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xB1D800", Offset = "0xB1D800", VA = "0xB1D800")]
		private void RefreshUI()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xB1D8A0", Offset = "0xB1D8A0", VA = "0xB1D8A0", Slot = "9")]
		public override void Open([Optional] object arg)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xB1D8D0", Offset = "0xB1D8D0", VA = "0xB1D8D0", Slot = "6")]
		protected override Transform GetCanvas()
		{
			return null;
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xB1D950", Offset = "0xB1D950", VA = "0xB1D950")]
		public PlotTreeChapterUI()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class PlotTreeWindowUI : UIPanel
	{
		[Serializable]
		[Token(Token = "0x20000FD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DD7C", Offset = "0x75DD7C")]
		private sealed class <>c
		{
			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<ChapterData, int> <>9__10_0;

			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x1C45488", Offset = "0x1C45488", VA = "0x1C45488")]
			public <>c()
			{
			}

			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x1C45490", Offset = "0x1C45490", VA = "0x1C45490")]
			internal int <RefreshUI>b__10_0(ChapterData x)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_Layout;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text m_Title;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button m_Replay;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button m_Back;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<ScrollRect> m_Chapters;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int m_Chapter;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private UnityEngine.Vector2 m_AxisValue;

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xB1EE8C", Offset = "0xB1EE8C", VA = "0xB1EE8C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xB1F038", Offset = "0xB1F038", VA = "0xB1F038")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xB1F1E4", Offset = "0xB1F1E4", VA = "0xB1F1E4")]
		private void Update()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xB1F2FC", Offset = "0xB1F2FC", VA = "0xB1F2FC")]
		private void RefreshUI()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xB1F690", Offset = "0xB1F690", VA = "0xB1F690")]
		private void OnReplay()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xB1F9E0", Offset = "0xB1F9E0", VA = "0xB1F9E0")]
		private void OnTouchPadAxis(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xB1FAD0", Offset = "0xB1FAD0", VA = "0xB1FAD0", Slot = "9")]
		public override void Open([Optional] object arg)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xB1FB68", Offset = "0xB1FB68", VA = "0xB1FB68", Slot = "6")]
		protected override Transform GetCanvas()
		{
			return null;
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xB1FBE8", Offset = "0xB1FBE8", VA = "0xB1FBE8")]
		public PlotTreeWindowUI()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xB1FC98", Offset = "0xB1FC98", VA = "0xB1FC98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76300C", Offset = "0x76300C")]
		private bool <OnReplay>b__11_0(MainPlotData item)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000FE")]
	public class SaveWindowUI : UIPanel
	{
		[Token(Token = "0x20000FF")]
		public enum EOpenSaveWindowMode
		{
			[Token(Token = "0x4000473")]
			Create,
			[Token(Token = "0x4000474")]
			Use
		}

		[Token(Token = "0x2000100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DD8C", Offset = "0x75DD8C")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int index;

			[Token(Token = "0x4000476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SaveWindowUI <>4__this;

			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x1C4B6CC", Offset = "0x1C4B6CC", VA = "0x1C4B6CC")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x1C4B6D4", Offset = "0x1C4B6D4", VA = "0x1C4B6D4")]
			internal void <Awake>g__function|0()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000101")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DD9C", Offset = "0x75DD9C")]
		private struct <OnClick>d__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SaveWindowUI <>4__this;

			[Token(Token = "0x400047A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int index;

			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<bool>.Awaiter <>u__1;

			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x1C4B71C", Offset = "0x1C4B71C", VA = "0x1C4B71C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x1C4BD4C", Offset = "0x1C4BD4C", VA = "0x1C4BD4C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_Layout;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_CellGameObject;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button m_Close;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private EOpenSaveWindowMode m_OpenMode;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<SaveItemUI> m_CellPool;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<SaveItemUI, UnityAction> dict;

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x9D8F08", Offset = "0x9D8F08", VA = "0x9D8F08", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x9D9194", Offset = "0x9D9194", VA = "0x9D9194", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x9D9310", Offset = "0x9D9310", VA = "0x9D9310")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x76301C", Offset = "0x76301C")]
		private UniTaskVoid OnClick(int index)
		{
			return default(UniTaskVoid);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x9D93C4", Offset = "0x9D93C4", VA = "0x9D93C4")]
		private void RefreshUI()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x9D94CC", Offset = "0x9D94CC", VA = "0x9D94CC", Slot = "9")]
		public override void Open([Optional] object arg)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x9D9564", Offset = "0x9D9564", VA = "0x9D9564", Slot = "10")]
		public override void Close()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x9D95F8", Offset = "0x9D95F8", VA = "0x9D95F8")]
		public SaveWindowUI()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class ScenePropTipWindowUI : UIPanel
	{
		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text m_Message;

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x9DFB48", Offset = "0x9DFB48", VA = "0x9DFB48", Slot = "9")]
		public override void Open([Optional] object arg)
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x9DFBE8", Offset = "0x9DFBE8", VA = "0x9DFBE8", Slot = "6")]
		protected override Transform GetCanvas()
		{
			return null;
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x9DFC68", Offset = "0x9DFC68", VA = "0x9DFC68")]
		public ScenePropTipWindowUI()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class SettingWindowUI : UIPanel
	{
		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Toggle m_Subtitle;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Toggle m_Vibration;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Slider m_Vioce_Slider;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Slider m_VibrationValue_Slider;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Toggle m_Definition4k;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Toggle m_Definition8k;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button m_Manual;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button m_Download;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button m_Close;

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x9E0234", Offset = "0x9E0234", VA = "0x9E0234", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x9E038C", Offset = "0x9E038C", VA = "0x9E038C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x9E0520", Offset = "0x9E0520", VA = "0x9E0520")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x9E08BC", Offset = "0x9E08BC", VA = "0x9E08BC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x9E0C08", Offset = "0x9E0C08", VA = "0x9E0C08")]
		private void OnPlotSubtitleChanged(bool isOn)
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x9E0C94", Offset = "0x9E0C94", VA = "0x9E0C94")]
		private void OnVibrationChanged(bool isOn)
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x9E0E44", Offset = "0x9E0E44", VA = "0x9E0E44")]
		private void OnVibrationValueChanged(float value)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x9E0F44", Offset = "0x9E0F44", VA = "0x9E0F44")]
		private void OnVoiceValueChanged(float value)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x9E1050", Offset = "0x9E1050", VA = "0x9E1050")]
		private void OnDefinition8K(bool isOn)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x9E10D4", Offset = "0x9E10D4", VA = "0x9E10D4")]
		private void OnDefinition4K(bool isOn)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x9E1150", Offset = "0x9E1150", VA = "0x9E1150")]
		private void OnManual()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x9E11D8", Offset = "0x9E11D8", VA = "0x9E11D8")]
		private void OnDownload()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x9E1260", Offset = "0x9E1260", VA = "0x9E1260", Slot = "10")]
		public override void Close()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x9E12F4", Offset = "0x9E12F4", VA = "0x9E12F4")]
		public SettingWindowUI()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class SubtitleWindowUI : AbstractMono, IWindow
	{
		[Token(Token = "0x2000105")]
		private class SubtitleInfo
		{
			[Token(Token = "0x400048E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint ID;

			[Token(Token = "0x400048F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public uint TimerID;

			[Token(Token = "0x4000490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string Content;

			[Token(Token = "0x4000491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EPerson Person;

			[Token(Token = "0x4000492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Text Text;

			[Token(Token = "0x600051F")]
			[Address(RVA = "0x1C4BFEC", Offset = "0x1C4BFEC", VA = "0x1C4BFEC")]
			public SubtitleInfo()
			{
			}
		}

		[Token(Token = "0x2000106")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DDAC", Offset = "0x75DDAC")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x4000493")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint id;

			[Token(Token = "0x6000520")]
			[Address(RVA = "0x1C4BF38", Offset = "0x1C4BF38", VA = "0x1C4BF38")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x6000521")]
			[Address(RVA = "0x1C4BF40", Offset = "0x1C4BF40", VA = "0x1C4BF40")]
			internal void <Add>b__0(uint u)
			{
			}
		}

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_Layout;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text m_Item;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<uint, SubtitleInfo> m_TotalSubtitils;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<uint> m_Release;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static uint SUBTITLT_INSTANCE_ID;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static bool m_IsPause;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static GameObjectPool m_Pool;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UnityEngine.Vector2 m_AnchoredPosition;

		[Token(Token = "0x170000BA")]
		public static bool IsPause
		{
			[Token(Token = "0x6000511")]
			[Address(RVA = "0x9E3DCC", Offset = "0x9E3DCC", VA = "0x9E3DCC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000512")]
			[Address(RVA = "0x9E3E30", Offset = "0x9E3E30", VA = "0x9E3E30")]
			set
			{
			}
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x9E3FF4", Offset = "0x9E3FF4", VA = "0x9E3FF4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x9E4114", Offset = "0x9E4114", VA = "0x9E4114")]
		private void Update()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x9E46C8", Offset = "0x9E46C8", VA = "0x9E46C8")]
		private void SetItemUp(Text item, int high)
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x9E4648", Offset = "0x9E4648", VA = "0x9E4648")]
		private static Color ToColor(EPerson person)
		{
			return default(Color);
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x9E4850", Offset = "0x9E4850", VA = "0x9E4850", Slot = "6")]
		protected override Transform GetCanvas()
		{
			return null;
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x9E48D0", Offset = "0x9E48D0", VA = "0x9E48D0")]
		public static uint[] Add(string[] messages, EPerson person, float duration = 0f)
		{
			return null;
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x9E3248", Offset = "0x9E3248", VA = "0x9E3248")]
		public static uint Add(string message, EPerson person, float duration = 0f)
		{
			return default(uint);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x9E2CD0", Offset = "0x9E2CD0", VA = "0x9E2CD0")]
		public static void Remove(params uint[] subtitleIds)
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x9E49F8", Offset = "0x9E49F8", VA = "0x9E49F8", Slot = "7")]
		public void Open([Optional] object arg)
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x9E4A78", Offset = "0x9E4A78", VA = "0x9E4A78", Slot = "8")]
		public void Close()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x9E4CE4", Offset = "0x9E4CE4", VA = "0x9E4CE4")]
		public SubtitleWindowUI()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class TeamLogoWindowUI : UIPanel
	{
		[StructLayout(3)]
		[Token(Token = "0x2000108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DDBC", Offset = "0x75DDBC")]
		private struct <OnVideoPrepare>d__9 : IAsyncStateMachine
		{
			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			[Token(Token = "0x400049A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TeamLogoWindowUI <>4__this;

			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TupleElementNamesAttribute", RVA = "0x75FCD0", Offset = "0x75FCD0")]
			private UniTask<(bool, SourceInfo)>.Awaiter <>u__1;

			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask.Awaiter <>u__2;

			[Token(Token = "0x600052D")]
			[Address(RVA = "0x1C4C50C", Offset = "0x1C4C50C", VA = "0x1C4C50C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600052E")]
			[Address(RVA = "0x1C4CE3C", Offset = "0x1C4CE3C", VA = "0x1C4CE3C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000109")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DDCC", Offset = "0x75DDCC")]
		private struct <OnPlayStop>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TeamLogoWindowUI <>4__this;

			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter <>u__1;

			[Token(Token = "0x600052F")]
			[Address(RVA = "0x1C4BFF4", Offset = "0x1C4BFF4", VA = "0x1C4BFF4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000530")]
			[Address(RVA = "0x1C4C500", Offset = "0x1C4C500", VA = "0x1C4C500", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RenderTexture m_RenderTexture;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VideoPlayer player;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RawImage m_RawImage;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SourceInfo open;

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x9E9BB0", Offset = "0x9E9BB0", VA = "0x9E9BB0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x9E9E00", Offset = "0x9E9E00", VA = "0x9E9E00")]
		private void Start()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x9E9E1C", Offset = "0x9E9E1C", VA = "0x9E9E1C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x9E9EF8", Offset = "0x9E9EF8", VA = "0x9E9EF8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x9E9F8C", Offset = "0x9E9F8C", VA = "0x9E9F8C")]
		private void OnSkip(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x9EA1C8", Offset = "0x9EA1C8", VA = "0x9EA1C8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x76308C", Offset = "0x76308C")]
		private UniTaskVoid OnVideoPrepare()
		{
			return default(UniTaskVoid);
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x9EA26C", Offset = "0x9EA26C", VA = "0x9EA26C")]
		private void OnPrepareCompleted(VideoPlayer p)
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x9EA0E8", Offset = "0x9EA0E8", VA = "0x9EA0E8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7630EC", Offset = "0x7630EC")]
		private void OnPlayStop(VideoPlayer p)
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x9E9CB8", Offset = "0x9E9CB8", VA = "0x9E9CB8")]
		private RenderTexture GetRenderTexture()
		{
			return null;
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x9EA3A8", Offset = "0x9EA3A8", VA = "0x9EA3A8", Slot = "6")]
		protected override Transform GetCanvas()
		{
			return null;
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x9EA428", Offset = "0x9EA428", VA = "0x9EA428")]
		public TeamLogoWindowUI()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class TransformWindowUI : UIPanel
	{
		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text m_PosInfo;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text m_RotateInfo;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text m_ScaleInfo;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button m_PosXA;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button m_PosYA;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button m_PosZA;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button m_PosXR;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button m_PosYR;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button m_PosZR;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button m_RotateXA;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button m_RotateYA;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Button m_RotateZA;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Button m_RotateXR;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Button m_RotateYR;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Button m_RotateZR;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Button m_ScaleA;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Button m_ScaleR;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Toggle m_T1;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Toggle m_T2;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Toggle m_T3;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Toggle m_T4;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private GameObject window;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float baseNumber;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float default_scale;

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x9EBA28", Offset = "0x9EBA28", VA = "0x9EBA28")]
		private void Start()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x9EC130", Offset = "0x9EC130", VA = "0x9EC130")]
		private void Update()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x9EC408", Offset = "0x9EC408", VA = "0x9EC408", Slot = "6")]
		protected override Transform GetCanvas()
		{
			return null;
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x9EC488", Offset = "0x9EC488", VA = "0x9EC488")]
		public TransformWindowUI()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x9EC4F8", Offset = "0x9EC4F8", VA = "0x9EC4F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76316C", Offset = "0x76316C")]
		private void <Start>b__24_0()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x9EC554", Offset = "0x9EC554", VA = "0x9EC554")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76317C", Offset = "0x76317C")]
		private void <Start>b__24_1()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x9EC5B0", Offset = "0x9EC5B0", VA = "0x9EC5B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76318C", Offset = "0x76318C")]
		private void <Start>b__24_2()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x9EC60C", Offset = "0x9EC60C", VA = "0x9EC60C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76319C", Offset = "0x76319C")]
		private void <Start>b__24_3()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x9EC65C", Offset = "0x9EC65C", VA = "0x9EC65C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7631AC", Offset = "0x7631AC")]
		private void <Start>b__24_4()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x9EC6AC", Offset = "0x9EC6AC", VA = "0x9EC6AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7631BC", Offset = "0x7631BC")]
		private void <Start>b__24_5()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x9EC6FC", Offset = "0x9EC6FC", VA = "0x9EC6FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7631CC", Offset = "0x7631CC")]
		private void <Start>b__24_6()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x9EC778", Offset = "0x9EC778", VA = "0x9EC778")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7631DC", Offset = "0x7631DC")]
		private void <Start>b__24_7()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x9EC7F4", Offset = "0x9EC7F4", VA = "0x9EC7F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7631EC", Offset = "0x7631EC")]
		private void <Start>b__24_8()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x9EC870", Offset = "0x9EC870", VA = "0x9EC870")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7631FC", Offset = "0x7631FC")]
		private void <Start>b__24_9()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x9EC8E0", Offset = "0x9EC8E0", VA = "0x9EC8E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76320C", Offset = "0x76320C")]
		private void <Start>b__24_10()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x9EC950", Offset = "0x9EC950", VA = "0x9EC950")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76321C", Offset = "0x76321C")]
		private void <Start>b__24_11()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x9EC9C0", Offset = "0x9EC9C0", VA = "0x9EC9C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76322C", Offset = "0x76322C")]
		private void <Start>b__24_12()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x9ECAB0", Offset = "0x9ECAB0", VA = "0x9ECAB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76323C", Offset = "0x76323C")]
		private void <Start>b__24_13()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x9ECBA0", Offset = "0x9ECBA0", VA = "0x9ECBA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76324C", Offset = "0x76324C")]
		private void <Start>b__24_14(bool isOn)
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x9ECBB4", Offset = "0x9ECBB4", VA = "0x9ECBB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76325C", Offset = "0x76325C")]
		private void <Start>b__24_15(bool isOn)
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x9ECBC8", Offset = "0x9ECBC8", VA = "0x9ECBC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76326C", Offset = "0x76326C")]
		private void <Start>b__24_16(bool isOn)
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x9ECBD8", Offset = "0x9ECBD8", VA = "0x9ECBD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76327C", Offset = "0x76327C")]
		private void <Start>b__24_17(bool isOn)
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class TrialEndWindowUI : UIPanel
	{
		[StructLayout(3)]
		[Token(Token = "0x200010C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DDDC", Offset = "0x75DDDC")]
		private struct <RefreshUI>d__17 : IAsyncStateMachine
		{
			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TrialEndWindowUI <>4__this;

			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float <price>5__2;

			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<(APIRequestResult, float)>.Awaiter <>u__1;

			[Token(Token = "0x6000554")]
			[Address(RVA = "0x1C4FF90", Offset = "0x1C4FF90", VA = "0x1C4FF90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000555")]
			[Address(RVA = "0x1C508E0", Offset = "0x1C508E0", VA = "0x1C508E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200010D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DDEC", Offset = "0x75DDEC")]
		private struct <OnPay>d__19 : IAsyncStateMachine
		{
			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40004CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TrialEndWindowUI <>4__this;

			[Token(Token = "0x40004CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UniTask<APIRequestResult>.Awaiter <>u__1;

			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<bool>.Awaiter <>u__2;

			[Token(Token = "0x6000556")]
			[Address(RVA = "0x1C4E510", Offset = "0x1C4E510", VA = "0x1C4E510", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000557")]
			[Address(RVA = "0x1C4FF84", Offset = "0x1C4FF84", VA = "0x1C4FF84", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button m_Close;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button m_Trailer;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button m_Pay;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image m_Ten;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image m_Unit;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image m_UnTen;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image m_UnUnit;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_Replay;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_CanClick;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private uint m_Timer;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private UnityAction m_PayAction;

		[Token(Token = "0x170000BB")]
		public bool Replay
		{
			[Token(Token = "0x6000547")]
			[Address(RVA = "0x9ECBE8", Offset = "0x9ECBE8", VA = "0x9ECBE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x9ECBF0", Offset = "0x9ECBF0", VA = "0x9ECBF0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x9ECCC8", Offset = "0x9ECCC8", VA = "0x9ECCC8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x9ECE34", Offset = "0x9ECE34", VA = "0x9ECE34")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x9ECF38", Offset = "0x9ECF38", VA = "0x9ECF38")]
		private void Trailer()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x9ECF58", Offset = "0x9ECF58", VA = "0x9ECF58")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x76328C", Offset = "0x76328C")]
		private UniTaskVoid RefreshUI()
		{
			return default(UniTaskVoid);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x9ECFFC", Offset = "0x9ECFFC", VA = "0x9ECFFC")]
		private Sprite GetSpriteForNumber(char number)
		{
			return null;
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x9ED0A0", Offset = "0x9ED0A0", VA = "0x9ED0A0")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x7632EC", Offset = "0x7632EC")]
		private UniTaskVoid OnPay()
		{
			return default(UniTaskVoid);
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x9ED144", Offset = "0x9ED144", VA = "0x9ED144", Slot = "6")]
		protected override Transform GetCanvas()
		{
			return null;
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x9ED1C4", Offset = "0x9ED1C4", VA = "0x9ED1C4", Slot = "9")]
		public override void Open([Optional] object arg)
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x9ED204", Offset = "0x9ED204", VA = "0x9ED204")]
		public TrialEndWindowUI()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x9ED268", Offset = "0x9ED268", VA = "0x9ED268")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76334C", Offset = "0x76334C")]
		private void <OnEnable>b__14_0(uint u)
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x9ED274", Offset = "0x9ED274", VA = "0x9ED274")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76335C", Offset = "0x76335C")]
		internal static void <OnPay>g__function|19_0()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class VideoDownloadWindowUI : UIPanel
	{
		[Token(Token = "0x200010F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DDFC", Offset = "0x75DDFC")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FileDownload download;

			[Token(Token = "0x6000567")]
			[Address(RVA = "0x1C59674", Offset = "0x1C59674", VA = "0x1C59674")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x6000568")]
			[Address(RVA = "0x1C5967C", Offset = "0x1C5967C", VA = "0x1C5967C")]
			internal bool <Start>b__0(MainPlotData x)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DE0C", Offset = "0x75DE0C")]
		private sealed class <>c
		{
			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40004DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<ChapterData, bool> <>9__23_0;

			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<ChapterData, int> <>9__23_1;

			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<ChapterData, bool> <>9__24_2;

			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<ChapterData, int> <>9__24_3;

			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<ChapterData, bool> <>9__25_0;

			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Func<ChapterData, int> <>9__25_1;

			[Token(Token = "0x600056A")]
			[Address(RVA = "0x1C595C4", Offset = "0x1C595C4", VA = "0x1C595C4")]
			public <>c()
			{
			}

			[Token(Token = "0x600056B")]
			[Address(RVA = "0x1C595CC", Offset = "0x1C595CC", VA = "0x1C595CC")]
			internal bool <RefreshUI>b__23_0(ChapterData x)
			{
				return default(bool);
			}

			[Token(Token = "0x600056C")]
			[Address(RVA = "0x1C595EC", Offset = "0x1C595EC", VA = "0x1C595EC")]
			internal int <RefreshUI>b__23_1(ChapterData x)
			{
				return default(int);
			}

			[Token(Token = "0x600056D")]
			[Address(RVA = "0x1C59604", Offset = "0x1C59604", VA = "0x1C59604")]
			internal bool <OnDownloadAll>b__24_2(ChapterData x)
			{
				return default(bool);
			}

			[Token(Token = "0x600056E")]
			[Address(RVA = "0x1C59624", Offset = "0x1C59624", VA = "0x1C59624")]
			internal int <OnDownloadAll>b__24_3(ChapterData x)
			{
				return default(int);
			}

			[Token(Token = "0x600056F")]
			[Address(RVA = "0x1C5963C", Offset = "0x1C5963C", VA = "0x1C5963C")]
			internal bool <OnStopAll>b__25_0(ChapterData x)
			{
				return default(bool);
			}

			[Token(Token = "0x6000570")]
			[Address(RVA = "0x1C5965C", Offset = "0x1C5965C", VA = "0x1C5965C")]
			internal int <OnStopAll>b__25_1(ChapterData x)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000111")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DE1C", Offset = "0x75DE1C")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DownloadTask task;

			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public VideoDownloadWindowUI <>4__this;

			[Token(Token = "0x6000571")]
			[Address(RVA = "0x1C596A8", Offset = "0x1C596A8", VA = "0x1C596A8")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x6000572")]
			[Address(RVA = "0x1C596B0", Offset = "0x1C596B0", VA = "0x1C596B0")]
			internal bool <OnDownloadAll>b__0(ChapterData x)
			{
				return default(bool);
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000112")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DE2C", Offset = "0x75DE2C")]
		private struct <OnDownloadAll>d__24 : IAsyncStateMachine
		{
			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public VideoDownloadWindowUI <>4__this;

			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UniTask<bool>.Awaiter <>u__1;

			[Token(Token = "0x6000573")]
			[Address(RVA = "0x1C5977C", Offset = "0x1C5977C", VA = "0x1C5977C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000574")]
			[Address(RVA = "0x1C5AE1C", Offset = "0x1C5AE1C", VA = "0x1C5AE1C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private EDefinition m_VideoDefinition;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UICircularScrollView m_ScrollView;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Toggle m_4K;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Toggle m_8K;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button m_DownloadAll;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button m_StopAll;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button m_Close;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_Time;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ScrollRect m_Rect;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private UnityEngine.Vector2 m_AxisValue;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private UnityAction m_DownloadAllAction;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly List<VideoDownloadItemUI> downloadItemUIs;

		[Token(Token = "0x170000BC")]
		public EDefinition VideoDefinition
		{
			[Token(Token = "0x6000558")]
			[Address(RVA = "0x9F5668", Offset = "0x9F5668", VA = "0x9F5668")]
			get
			{
				return default(EDefinition);
			}
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x9F5670", Offset = "0x9F5670", VA = "0x9F5670", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x9F57F8", Offset = "0x9F57F8", VA = "0x9F57F8")]
		private void Start()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x9F5D40", Offset = "0x9F5D40", VA = "0x9F5D40")]
		private void Update()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x9F62BC", Offset = "0x9F62BC", VA = "0x9F62BC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x9F65B4", Offset = "0x9F65B4", VA = "0x9F65B4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x9F6858", Offset = "0x9F6858", VA = "0x9F6858")]
		private void OnScrollViewInitFunc(int index, GameObject obj)
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x9F68F0", Offset = "0x9F68F0", VA = "0x9F68F0")]
		private void OnTouchPadAxis(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x9F6974", Offset = "0x9F6974", VA = "0x9F6974")]
		private void On4K(bool isOn)
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x9F6AA4", Offset = "0x9F6AA4", VA = "0x9F6AA4")]
		private void On8K(bool isOn)
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x9F5F1C", Offset = "0x9F5F1C", VA = "0x9F5F1C")]
		private void RefreshUI()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x9F6BD8", Offset = "0x9F6BD8", VA = "0x9F6BD8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x76338C", Offset = "0x76338C")]
		private UniTaskVoid OnDownloadAll()
		{
			return default(UniTaskVoid);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x9F6C80", Offset = "0x9F6C80", VA = "0x9F6C80")]
		private void OnStopAll()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x9F6F9C", Offset = "0x9F6F9C", VA = "0x9F6F9C")]
		public VideoDownloadWindowUI()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x9F704C", Offset = "0x9F704C", VA = "0x9F704C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7633EC", Offset = "0x7633EC")]
		private long <OnDownloadAll>b__24_1(ChapterData x)
		{
			return default(long);
		}
	}
	[Token(Token = "0x2000113")]
	public class VideoProgressWindowUI : UIPanel
	{
		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Dictionary<float, Text> m_SignMap;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text m_VideoStartTime;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text m_VideoEndTime;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text m_VideoNowTime;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text m_VideoFocusTime;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text m_ItemSign;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Text m_ChoiceShowTime;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Slider m_Progress;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SliderHelper m_Helper;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObjectPool m_Pool;

		[Token(Token = "0x170000BD")]
		private long Length
		{
			[Token(Token = "0x6000575")]
			[Address(RVA = "0x1BF840C", Offset = "0x1BF840C", VA = "0x1BF840C")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x1BF85B4", Offset = "0x1BF85B4", VA = "0x1BF85B4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x1BF867C", Offset = "0x1BF867C", VA = "0x1BF867C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x1BF8740", Offset = "0x1BF8740", VA = "0x1BF8740")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x1BF8804", Offset = "0x1BF8804", VA = "0x1BF8804")]
		private void Update()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x1BF9798", Offset = "0x1BF9798", VA = "0x1BF9798")]
		private void OnSeek(float value)
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x1BF98CC", Offset = "0x1BF98CC", VA = "0x1BF98CC", Slot = "6")]
		protected override Transform GetCanvas()
		{
			return null;
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x1BF994C", Offset = "0x1BF994C", VA = "0x1BF994C")]
		public VideoProgressWindowUI()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class SaveButtonHighlight : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
	{
		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite m_Highlight;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Sprite m_Default;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color m_TitleColor;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color m_DateColor;

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xB22D70", Offset = "0xB22D70", VA = "0xB22D70")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xB22F30", Offset = "0xB22F30", VA = "0xB22F30", Slot = "6")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xB22F34", Offset = "0xB22F34", VA = "0xB22F34", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xB22DF4", Offset = "0xB22DF4", VA = "0xB22DF4", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xB230CC", Offset = "0xB230CC", VA = "0xB230CC")]
		public SaveButtonHighlight()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class InteractPoseWork : Work
	{
		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76000C", Offset = "0x76000C")]
		private readonly EPose <Pose>k__BackingField;

		[Token(Token = "0x170000BE")]
		public EPose Pose
		{
			[Token(Token = "0x6000582")]
			[Address(RVA = "0x1C28504", Offset = "0x1C28504", VA = "0x1C28504")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76340C", Offset = "0x76340C")]
			get
			{
				return default(EPose);
			}
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x1C2850C", Offset = "0x1C2850C", VA = "0x1C2850C")]
		public InteractPoseWork(EPose pose)
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x1C286B4", Offset = "0x1C286B4", VA = "0x1C286B4")]
		private void OnPoseComplete(EPose pose)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x1C28860", Offset = "0x1C28860", VA = "0x1C28860", Slot = "8")]
		public override void Reset()
		{
		}
	}
	[Token(Token = "0x2000116")]
	public class WorldManager : AbstractMono, IManager
	{
		[StructLayout(3)]
		[Token(Token = "0x2000117")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DE3C", Offset = "0x75DE3C")]
		private struct <OnBack>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public WorldManager <>4__this;

			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<bool>.Awaiter <>u__1;

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x1C5AED8", Offset = "0x1C5AED8", VA = "0x1C5AED8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x1C5B8D4", Offset = "0x1C5B8D4", VA = "0x1C5B8D4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DE4C", Offset = "0x75DE4C")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int start_chapter;

			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x1C5AEAC", Offset = "0x1C5AEAC", VA = "0x1C5AEAC")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x1C5AEB4", Offset = "0x1C5AEB4", VA = "0x1C5AEB4")]
			internal bool <StartGame>b__1(MainPlotData x)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000119")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DE5C", Offset = "0x75DE5C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<ChapterData, bool> <>9__38_0;

			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x1C5AE8C", Offset = "0x1C5AE8C", VA = "0x1C5AE8C")]
			public <>c()
			{
			}

			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x1C5AE94", Offset = "0x1C5AE94", VA = "0x1C5AE94")]
			internal bool <StartGame>b__38_0(ChapterData x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly CoolDown m_CD;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private uint m_LeftRecenterTimer;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private uint m_RightRecenterTimer;

		[Token(Token = "0x40004FC")]
		private const float INTERNAL = 0.5f;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int count;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float lastTime;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private long lateTime;

		[Token(Token = "0x14000019")]
		public static event Action OnVideoPause
		{
			[Token(Token = "0x6000586")]
			[Address(RVA = "0x1BF9E70", Offset = "0x1BF9E70", VA = "0x1BF9E70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76341C", Offset = "0x76341C")]
			add
			{
			}
			[Token(Token = "0x6000587")]
			[Address(RVA = "0x1BF9F2C", Offset = "0x1BF9F2C", VA = "0x1BF9F2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76342C", Offset = "0x76342C")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001A")]
		public static event Action OnVideoResume
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x1BF9FE8", Offset = "0x1BF9FE8", VA = "0x1BF9FE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76343C", Offset = "0x76343C")]
			add
			{
			}
			[Token(Token = "0x6000589")]
			[Address(RVA = "0x1BFA0A8", Offset = "0x1BFA0A8", VA = "0x1BFA0A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76344C", Offset = "0x76344C")]
			remove
			{
			}
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x1BFA168", Offset = "0x1BFA168", VA = "0x1BFA168")]
		private void Start()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x1BFA26C", Offset = "0x1BFA26C", VA = "0x1BFA26C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x1BFAAC0", Offset = "0x1BFAAC0", VA = "0x1BFAAC0")]
		private void Update()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x1BFAAC4", Offset = "0x1BFAAC4", VA = "0x1BFAAC4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x1BFB26C", Offset = "0x1BFB26C", VA = "0x1BFB26C")]
		private void OnDestory()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x1BFB2C4", Offset = "0x1BFB2C4", VA = "0x1BFB2C4")]
		private void OnSure(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x1BFB304", Offset = "0x1BFB304", VA = "0x1BFB304")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x76345C", Offset = "0x76345C")]
		private void OnBack(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x1BFB3E4", Offset = "0x1BFB3E4", VA = "0x1BFB3E4")]
		private void LeftTryReconter(float value)
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x1BFB544", Offset = "0x1BFB544", VA = "0x1BFB544")]
		private void RightTryReconter(float value)
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x1BFB6A4", Offset = "0x1BFB6A4", VA = "0x1BFB6A4")]
		private void OnInputDeviceChange(InputDevice device, InputDeviceChange state)
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x1BFB6A8", Offset = "0x1BFB6A8", VA = "0x1BFB6A8")]
		private void OnYes(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x1BFB7D0", Offset = "0x1BFB7D0", VA = "0x1BFB7D0")]
		private void OnShowLog(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x1BFB834", Offset = "0x1BFB834", VA = "0x1BFB834")]
		private void Test(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x1BFB8BC", Offset = "0x1BFB8BC", VA = "0x1BFB8BC")]
		private void Camera(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x1BFBC0C", Offset = "0x1BFBC0C", VA = "0x1BFBC0C")]
		private void Interact(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x1BFBCD4", Offset = "0x1BFBCD4", VA = "0x1BFBCD4")]
		private void OnSettingChange()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x1BFBD7C", Offset = "0x1BFBD7C", VA = "0x1BFBD7C")]
		private void OnVideoPrepared(BaseVideoPlayer player)
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x1BFBE14", Offset = "0x1BFBE14", VA = "0x1BFBE14")]
		private void OnVideoPlayed(BaseVideoPlayer player)
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x1BFC0E8", Offset = "0x1BFC0E8", VA = "0x1BFC0E8")]
		private void OnVideoPaused(BaseVideoPlayer player)
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x1BFC3BC", Offset = "0x1BFC3BC", VA = "0x1BFC3BC")]
		private void OnVideoStoped(BaseVideoPlayer player)
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x1BFC6D8", Offset = "0x1BFC6D8", VA = "0x1BFC6D8")]
		private void OnVideoRePlayed(BaseVideoPlayer player)
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x1BFC9AC", Offset = "0x1BFC9AC", VA = "0x1BFC9AC")]
		private void OnVideoPlaying(BaseVideoPlayer player, long time)
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x1BFC9D0", Offset = "0x1BFC9D0", VA = "0x1BFC9D0")]
		private void OnBuffering(BaseVideoPlayer player, float buffer)
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x1BFCAFC", Offset = "0x1BFCAFC", VA = "0x1BFCAFC")]
		private void OnVideoTexture(BaseVideoPlayer player, Texture texture)
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x1BFCDD0", Offset = "0x1BFCDD0", VA = "0x1BFCDD0")]
		private void OnSeekCompleted(BaseVideoPlayer player)
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x1BFCF2C", Offset = "0x1BFCF2C", VA = "0x1BFCF2C")]
		public static void StartGame(int saveId, bool isNew)
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x1BFD444", Offset = "0x1BFD444", VA = "0x1BFD444")]
		public static void Resume()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1BFD580", Offset = "0x1BFD580", VA = "0x1BFD580")]
		public static void Pause()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x1BFD6C0", Offset = "0x1BFD6C0", VA = "0x1BFD6C0")]
		public WorldManager()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x1BFD774", Offset = "0x1BFD774", VA = "0x1BFD774")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7634BC", Offset = "0x7634BC")]
		private void <LeftTryReconter>b__15_0(uint u)
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x1BFD8D4", Offset = "0x1BFD8D4", VA = "0x1BFD8D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7634CC", Offset = "0x7634CC")]
		private void <RightTryReconter>b__17_0(uint u)
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class XRSphere : XRBaseInteractable
	{
		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public UnityEvent OnUpdate;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static GameObjectPool m_Pool;

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x1C084C0", Offset = "0x1C084C0", VA = "0x1C084C0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1BFE100", Offset = "0x1BFE100", VA = "0x1BFE100")]
		public static XRSphere Get()
		{
			return null;
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1BFE9A8", Offset = "0x1BFE9A8", VA = "0x1BFE9A8")]
		public static void Release(XRSphere sphere)
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1C084D4", Offset = "0x1C084D4", VA = "0x1C084D4")]
		public static void ReleaseAll()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1C08534", Offset = "0x1C08534", VA = "0x1C08534")]
		public XRSphere()
		{
		}
	}
}
namespace Com.Zqgame.VRGrilFriend.Tb
{
	[Token(Token = "0x200011B")]
	public sealed class AchievementData : BeanBase
	{
		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76003C", Offset = "0x76003C")]
		private int <Id>k__BackingField;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76004C", Offset = "0x76004C")]
		private string <Name>k__BackingField;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76005C", Offset = "0x76005C")]
		private string <ApiName>k__BackingField;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76006C", Offset = "0x76006C")]
		private EAchievementType <ApiType>k__BackingField;

		[Token(Token = "0x400050D")]
		public const int __ID__ = -760248327;

		[Token(Token = "0x170000BF")]
		public int Id
		{
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x1C179B8", Offset = "0x1C179B8", VA = "0x1C179B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7634EC", Offset = "0x7634EC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005B9")]
			[Address(RVA = "0x1C179C0", Offset = "0x1C179C0", VA = "0x1C179C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7634FC", Offset = "0x7634FC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		public string Name
		{
			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x1C179C8", Offset = "0x1C179C8", VA = "0x1C179C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76350C", Offset = "0x76350C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005BB")]
			[Address(RVA = "0x1C179D0", Offset = "0x1C179D0", VA = "0x1C179D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76351C", Offset = "0x76351C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public string ApiName
		{
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x1C179D8", Offset = "0x1C179D8", VA = "0x1C179D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76352C", Offset = "0x76352C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x1C179E0", Offset = "0x1C179E0", VA = "0x1C179E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76353C", Offset = "0x76353C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C2")]
		public EAchievementType ApiType
		{
			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x1C179E8", Offset = "0x1C179E8", VA = "0x1C179E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76354C", Offset = "0x76354C")]
			get
			{
				return default(EAchievementType);
			}
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x1C179F0", Offset = "0x1C179F0", VA = "0x1C179F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76355C", Offset = "0x76355C")]
			private set
			{
			}
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x1C17530", Offset = "0x1C17530", VA = "0x1C17530")]
		public AchievementData(JSONNode _json)
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1C178F0", Offset = "0x1C178F0", VA = "0x1C178F0")]
		public AchievementData(int id, string name, string api_name, EAchievementType api_type)
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1C1795C", Offset = "0x1C1795C", VA = "0x1C1795C")]
		public static AchievementData DeserializeAchievementData(JSONNode _json)
		{
			return null;
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x1C179F8", Offset = "0x1C179F8", VA = "0x1C179F8", Slot = "5")]
		public override int GetTypeId()
		{
			return default(int);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x1C17A04", Offset = "0x1C17A04", VA = "0x1C17A04")]
		public void Resolve(Dictionary<string, object> _tables)
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x1C17A08", Offset = "0x1C17A08", VA = "0x1C17A08")]
		public void TranslateText(Func<string, string, string> translator)
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x1C17A0C", Offset = "0x1C17A0C", VA = "0x1C17A0C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200011C")]
	public sealed class ButtonChoiceData : BeanBase
	{
		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76007C", Offset = "0x76007C")]
		private int <Id>k__BackingField;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76008C", Offset = "0x76008C")]
		private float <WaitTime>k__BackingField;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76009C", Offset = "0x76009C")]
		private bool <IsVidoeEnd>k__BackingField;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7600AC", Offset = "0x7600AC")]
		private float <InsertTime>k__BackingField;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7600BC", Offset = "0x7600BC")]
		private string <Content>k__BackingField;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7600CC", Offset = "0x7600CC")]
		private Option[] <Choices>k__BackingField;

		[Token(Token = "0x4000514")]
		public const int __ID__ = -972488387;

		[Token(Token = "0x170000C3")]
		public int Id
		{
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x1C195D8", Offset = "0x1C195D8", VA = "0x1C195D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76356C", Offset = "0x76356C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x1C195E0", Offset = "0x1C195E0", VA = "0x1C195E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76357C", Offset = "0x76357C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public float WaitTime
		{
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x1C195E8", Offset = "0x1C195E8", VA = "0x1C195E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76358C", Offset = "0x76358C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x1C195F0", Offset = "0x1C195F0", VA = "0x1C195F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76359C", Offset = "0x76359C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public bool IsVidoeEnd
		{
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x1C195F8", Offset = "0x1C195F8", VA = "0x1C195F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7635AC", Offset = "0x7635AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x1C19600", Offset = "0x1C19600", VA = "0x1C19600")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7635BC", Offset = "0x7635BC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public float InsertTime
		{
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x1C1960C", Offset = "0x1C1960C", VA = "0x1C1960C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7635CC", Offset = "0x7635CC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x1C19614", Offset = "0x1C19614", VA = "0x1C19614")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7635DC", Offset = "0x7635DC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public string Content
		{
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x1C1961C", Offset = "0x1C1961C", VA = "0x1C1961C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7635EC", Offset = "0x7635EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x1C19624", Offset = "0x1C19624", VA = "0x1C19624")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7635FC", Offset = "0x7635FC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public Option[] Choices
		{
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x1C1962C", Offset = "0x1C1962C", VA = "0x1C1962C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76360C", Offset = "0x76360C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x1C19634", Offset = "0x1C19634", VA = "0x1C19634")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76361C", Offset = "0x76361C")]
			private set
			{
			}
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x1C18CA4", Offset = "0x1C18CA4", VA = "0x1C18CA4")]
		public ButtonChoiceData(JSONNode _json)
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1C194F8", Offset = "0x1C194F8", VA = "0x1C194F8")]
		public ButtonChoiceData(int id, float wait_time, bool is_vidoe_end, float insert_time, string content, Option[] choices)
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x1C1957C", Offset = "0x1C1957C", VA = "0x1C1957C")]
		public static ButtonChoiceData DeserializeButtonChoiceData(JSONNode _json)
		{
			return null;
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x1C1963C", Offset = "0x1C1963C", VA = "0x1C1963C", Slot = "5")]
		public override int GetTypeId()
		{
			return default(int);
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x1C19648", Offset = "0x1C19648", VA = "0x1C19648")]
		public void Resolve(Dictionary<string, object> _tables)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x1C196E4", Offset = "0x1C196E4", VA = "0x1C196E4")]
		public void TranslateText(Func<string, string, string> translator)
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x1C19780", Offset = "0x1C19780", VA = "0x1C19780", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200011D")]
	public sealed class ChapterData : BeanBase
	{
		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7600DC", Offset = "0x7600DC")]
		private int <Index>k__BackingField;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7600EC", Offset = "0x7600EC")]
		private string <Name>k__BackingField;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7600FC", Offset = "0x7600FC")]
		private bool <IsLock>k__BackingField;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76010C", Offset = "0x76010C")]
		private bool <Begin>k__BackingField;

		[Token(Token = "0x4000519")]
		public const int __ID__ = 1309668887;

		[Token(Token = "0x170000C9")]
		public int Index
		{
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x1C1F2B4", Offset = "0x1C1F2B4", VA = "0x1C1F2B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76362C", Offset = "0x76362C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x1C1F2BC", Offset = "0x1C1F2BC", VA = "0x1C1F2BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76363C", Offset = "0x76363C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public string Name
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x1C1F2C4", Offset = "0x1C1F2C4", VA = "0x1C1F2C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76364C", Offset = "0x76364C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x1C1F2CC", Offset = "0x1C1F2CC", VA = "0x1C1F2CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76365C", Offset = "0x76365C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public bool IsLock
		{
			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x1C1F2D4", Offset = "0x1C1F2D4", VA = "0x1C1F2D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76366C", Offset = "0x76366C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x1C1F2DC", Offset = "0x1C1F2DC", VA = "0x1C1F2DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76367C", Offset = "0x76367C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public bool Begin
		{
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x1C1F2E8", Offset = "0x1C1F2E8", VA = "0x1C1F2E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76368C", Offset = "0x76368C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x1C1F2F0", Offset = "0x1C1F2F0", VA = "0x1C1F2F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76369C", Offset = "0x76369C")]
			private set
			{
			}
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x1C1EF48", Offset = "0x1C1EF48", VA = "0x1C1EF48")]
		public ChapterData(JSONNode _json)
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x1C1F1F0", Offset = "0x1C1F1F0", VA = "0x1C1F1F0")]
		public ChapterData(int index, string name, bool is_lock, bool begin)
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x1C1F258", Offset = "0x1C1F258", VA = "0x1C1F258")]
		public static ChapterData DeserializeChapterData(JSONNode _json)
		{
			return null;
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x1C1F2FC", Offset = "0x1C1F2FC", VA = "0x1C1F2FC", Slot = "5")]
		public override int GetTypeId()
		{
			return default(int);
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x1C1F308", Offset = "0x1C1F308", VA = "0x1C1F308")]
		public void Resolve(Dictionary<string, object> _tables)
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x1C1F30C", Offset = "0x1C1F30C", VA = "0x1C1F30C")]
		public void TranslateText(Func<string, string, string> translator)
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x1C1F310", Offset = "0x1C1F310", VA = "0x1C1F310", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200011E")]
	public sealed class GlobalConfigData : BeanBase
	{
		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76011C", Offset = "0x76011C")]
		private bool <GM>k__BackingField;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76012C", Offset = "0x76012C")]
		private bool <Pay>k__BackingField;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76013C", Offset = "0x76013C")]
		private bool <UnlockAll>k__BackingField;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76014C", Offset = "0x76014C")]
		private bool <VideoSlider>k__BackingField;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76015C", Offset = "0x76015C")]
		private string <ServerIP>k__BackingField;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76016C", Offset = "0x76016C")]
		private int <PayChapter>k__BackingField;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76017C", Offset = "0x76017C")]
		private string <ImageBackGround>k__BackingField;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76018C", Offset = "0x76018C")]
		private string <TrailerVideo>k__BackingField;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76019C", Offset = "0x76019C")]
		private string <SKU>k__BackingField;

		[Token(Token = "0x4000523")]
		public const int __ID__ = 1388589455;

		[Token(Token = "0x170000CD")]
		public bool GM
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x1C245CC", Offset = "0x1C245CC", VA = "0x1C245CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7636AC", Offset = "0x7636AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x1C245D4", Offset = "0x1C245D4", VA = "0x1C245D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7636BC", Offset = "0x7636BC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CE")]
		public bool Pay
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x1C245E0", Offset = "0x1C245E0", VA = "0x1C245E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7636CC", Offset = "0x7636CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x1C245E8", Offset = "0x1C245E8", VA = "0x1C245E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7636DC", Offset = "0x7636DC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public bool UnlockAll
		{
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x1C245F4", Offset = "0x1C245F4", VA = "0x1C245F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7636EC", Offset = "0x7636EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x1C245FC", Offset = "0x1C245FC", VA = "0x1C245FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7636FC", Offset = "0x7636FC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D0")]
		public bool VideoSlider
		{
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x1C24608", Offset = "0x1C24608", VA = "0x1C24608")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76370C", Offset = "0x76370C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x1C24610", Offset = "0x1C24610", VA = "0x1C24610")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76371C", Offset = "0x76371C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public string ServerIP
		{
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x1C2461C", Offset = "0x1C2461C", VA = "0x1C2461C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76372C", Offset = "0x76372C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x1C24624", Offset = "0x1C24624", VA = "0x1C24624")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76373C", Offset = "0x76373C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		public int PayChapter
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x1C2462C", Offset = "0x1C2462C", VA = "0x1C2462C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76374C", Offset = "0x76374C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x1C24634", Offset = "0x1C24634", VA = "0x1C24634")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76375C", Offset = "0x76375C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public string ImageBackGround
		{
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x1C2463C", Offset = "0x1C2463C", VA = "0x1C2463C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76376C", Offset = "0x76376C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x1C24644", Offset = "0x1C24644", VA = "0x1C24644")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76377C", Offset = "0x76377C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D4")]
		public string TrailerVideo
		{
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x1C2464C", Offset = "0x1C2464C", VA = "0x1C2464C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76378C", Offset = "0x76378C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x1C24654", Offset = "0x1C24654", VA = "0x1C24654")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76379C", Offset = "0x76379C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public string SKU
		{
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x1C2465C", Offset = "0x1C2465C", VA = "0x1C2465C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7637AC", Offset = "0x7637AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x1C24664", Offset = "0x1C24664", VA = "0x1C24664")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7637BC", Offset = "0x7637BC")]
			private set
			{
			}
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x1C23F5C", Offset = "0x1C23F5C", VA = "0x1C23F5C")]
		public GlobalConfigData(JSONNode _json)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x1C244AC", Offset = "0x1C244AC", VA = "0x1C244AC")]
		public GlobalConfigData(bool GM, bool Pay, bool Unlock_All, bool Video_Slider, string Server_IP, int Pay_Chapter, string Image_BackGround, string Trailer_Video, string SKU)
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x1C24570", Offset = "0x1C24570", VA = "0x1C24570")]
		public static GlobalConfigData DeserializeGlobalConfigData(JSONNode _json)
		{
			return null;
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x1C2466C", Offset = "0x1C2466C", VA = "0x1C2466C", Slot = "5")]
		public override int GetTypeId()
		{
			return default(int);
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x1C24678", Offset = "0x1C24678", VA = "0x1C24678")]
		public void Resolve(Dictionary<string, object> _tables)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x1C2467C", Offset = "0x1C2467C", VA = "0x1C2467C")]
		public void TranslateText(Func<string, string, string> translator)
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x1C24680", Offset = "0x1C24680", VA = "0x1C24680", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200011F")]
	public sealed class InteractConfigData : BeanBase
	{
		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7601AC", Offset = "0x7601AC")]
		private int <Id>k__BackingField;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7601BC", Offset = "0x7601BC")]
		private string <Name>k__BackingField;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7601CC", Offset = "0x7601CC")]
		private float <InsertTime>k__BackingField;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7601DC", Offset = "0x7601DC")]
		private float <WaitTime>k__BackingField;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7601EC", Offset = "0x7601EC")]
		private float <ContinueTime>k__BackingField;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7601FC", Offset = "0x7601FC")]
		private float <DelayTime>k__BackingField;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76020C", Offset = "0x76020C")]
		private string[] <Descs>k__BackingField;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76021C", Offset = "0x76021C")]
		private EInteraction <Interaction>k__BackingField;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76022C", Offset = "0x76022C")]
		private EPose <Pose>k__BackingField;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76023C", Offset = "0x76023C")]
		private EParent <SphereParent>k__BackingField;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76024C", Offset = "0x76024C")]
		private UnityEngine.Vector3 <SphereStartPos>k__BackingField;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76025C", Offset = "0x76025C")]
		private UnityEngine.Vector3 <SphereEndPos>k__BackingField;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76026C", Offset = "0x76026C")]
		private float <SphereScale>k__BackingField;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76027C", Offset = "0x76027C")]
		private ETrigger <SphereTrigger>k__BackingField;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76028C", Offset = "0x76028C")]
		private EHand <GuideHand>k__BackingField;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76029C", Offset = "0x76029C")]
		private UnityEngine.Vector3 <GuideStartPos>k__BackingField;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7602AC", Offset = "0x7602AC")]
		private UnityEngine.Vector3 <GuideEndPos>k__BackingField;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7602BC", Offset = "0x7602BC")]
		private UnityEngine.Vector3 <GuideRotate>k__BackingField;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7602CC", Offset = "0x7602CC")]
		private ETrigger <DefaultAni>k__BackingField;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7602DC", Offset = "0x7602DC")]
		private ETrigger <TriggerAni>k__BackingField;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7602EC", Offset = "0x7602EC")]
		private float <GuideStayTime>k__BackingField;

		[Token(Token = "0x4000539")]
		public const int __ID__ = 823789666;

		[Token(Token = "0x170000D6")]
		public int Id
		{
			[Token(Token = "0x6000602")]
			[Address(RVA = "0x1C27438", Offset = "0x1C27438", VA = "0x1C27438")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7637CC", Offset = "0x7637CC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000603")]
			[Address(RVA = "0x1C27440", Offset = "0x1C27440", VA = "0x1C27440")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7637DC", Offset = "0x7637DC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public string Name
		{
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x1C27448", Offset = "0x1C27448", VA = "0x1C27448")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7637EC", Offset = "0x7637EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000605")]
			[Address(RVA = "0x1C27450", Offset = "0x1C27450", VA = "0x1C27450")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7637FC", Offset = "0x7637FC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D8")]
		public float InsertTime
		{
			[Token(Token = "0x6000606")]
			[Address(RVA = "0x1C27458", Offset = "0x1C27458", VA = "0x1C27458")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76380C", Offset = "0x76380C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000607")]
			[Address(RVA = "0x1C27460", Offset = "0x1C27460", VA = "0x1C27460")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76381C", Offset = "0x76381C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public float WaitTime
		{
			[Token(Token = "0x6000608")]
			[Address(RVA = "0x1C27468", Offset = "0x1C27468", VA = "0x1C27468")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76382C", Offset = "0x76382C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000609")]
			[Address(RVA = "0x1C27470", Offset = "0x1C27470", VA = "0x1C27470")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76383C", Offset = "0x76383C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public float ContinueTime
		{
			[Token(Token = "0x600060A")]
			[Address(RVA = "0x1C27478", Offset = "0x1C27478", VA = "0x1C27478")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76384C", Offset = "0x76384C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600060B")]
			[Address(RVA = "0x1C27480", Offset = "0x1C27480", VA = "0x1C27480")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76385C", Offset = "0x76385C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		public float DelayTime
		{
			[Token(Token = "0x600060C")]
			[Address(RVA = "0x1C27488", Offset = "0x1C27488", VA = "0x1C27488")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76386C", Offset = "0x76386C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600060D")]
			[Address(RVA = "0x1C27490", Offset = "0x1C27490", VA = "0x1C27490")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76387C", Offset = "0x76387C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public string[] Descs
		{
			[Token(Token = "0x600060E")]
			[Address(RVA = "0x1C27498", Offset = "0x1C27498", VA = "0x1C27498")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76388C", Offset = "0x76388C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600060F")]
			[Address(RVA = "0x1C274A0", Offset = "0x1C274A0", VA = "0x1C274A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76389C", Offset = "0x76389C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DD")]
		public EInteraction Interaction
		{
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x1C274A8", Offset = "0x1C274A8", VA = "0x1C274A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7638AC", Offset = "0x7638AC")]
			get
			{
				return default(EInteraction);
			}
			[Token(Token = "0x6000611")]
			[Address(RVA = "0x1C274B0", Offset = "0x1C274B0", VA = "0x1C274B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7638BC", Offset = "0x7638BC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DE")]
		public EPose Pose
		{
			[Token(Token = "0x6000612")]
			[Address(RVA = "0x1C274B8", Offset = "0x1C274B8", VA = "0x1C274B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7638CC", Offset = "0x7638CC")]
			get
			{
				return default(EPose);
			}
			[Token(Token = "0x6000613")]
			[Address(RVA = "0x1C274C0", Offset = "0x1C274C0", VA = "0x1C274C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7638DC", Offset = "0x7638DC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DF")]
		public EParent SphereParent
		{
			[Token(Token = "0x6000614")]
			[Address(RVA = "0x1C274C8", Offset = "0x1C274C8", VA = "0x1C274C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7638EC", Offset = "0x7638EC")]
			get
			{
				return default(EParent);
			}
			[Token(Token = "0x6000615")]
			[Address(RVA = "0x1C274D0", Offset = "0x1C274D0", VA = "0x1C274D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7638FC", Offset = "0x7638FC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E0")]
		public UnityEngine.Vector3 SphereStartPos
		{
			[Token(Token = "0x6000616")]
			[Address(RVA = "0x1C274D8", Offset = "0x1C274D8", VA = "0x1C274D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76390C", Offset = "0x76390C")]
			get
			{
				return default(UnityEngine.Vector3);
			}
			[Token(Token = "0x6000617")]
			[Address(RVA = "0x1C274E4", Offset = "0x1C274E4", VA = "0x1C274E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76391C", Offset = "0x76391C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E1")]
		public UnityEngine.Vector3 SphereEndPos
		{
			[Token(Token = "0x6000618")]
			[Address(RVA = "0x1C274F0", Offset = "0x1C274F0", VA = "0x1C274F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76392C", Offset = "0x76392C")]
			get
			{
				return default(UnityEngine.Vector3);
			}
			[Token(Token = "0x6000619")]
			[Address(RVA = "0x1C274FC", Offset = "0x1C274FC", VA = "0x1C274FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76393C", Offset = "0x76393C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E2")]
		public float SphereScale
		{
			[Token(Token = "0x600061A")]
			[Address(RVA = "0x1C27508", Offset = "0x1C27508", VA = "0x1C27508")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76394C", Offset = "0x76394C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600061B")]
			[Address(RVA = "0x1C27510", Offset = "0x1C27510", VA = "0x1C27510")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76395C", Offset = "0x76395C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E3")]
		public ETrigger SphereTrigger
		{
			[Token(Token = "0x600061C")]
			[Address(RVA = "0x1C27518", Offset = "0x1C27518", VA = "0x1C27518")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76396C", Offset = "0x76396C")]
			get
			{
				return default(ETrigger);
			}
			[Token(Token = "0x600061D")]
			[Address(RVA = "0x1C27520", Offset = "0x1C27520", VA = "0x1C27520")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76397C", Offset = "0x76397C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E4")]
		public EHand GuideHand
		{
			[Token(Token = "0x600061E")]
			[Address(RVA = "0x1C27528", Offset = "0x1C27528", VA = "0x1C27528")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76398C", Offset = "0x76398C")]
			get
			{
				return default(EHand);
			}
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x1C27530", Offset = "0x1C27530", VA = "0x1C27530")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76399C", Offset = "0x76399C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E5")]
		public UnityEngine.Vector3 GuideStartPos
		{
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x1C27538", Offset = "0x1C27538", VA = "0x1C27538")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7639AC", Offset = "0x7639AC")]
			get
			{
				return default(UnityEngine.Vector3);
			}
			[Token(Token = "0x6000621")]
			[Address(RVA = "0x1C27544", Offset = "0x1C27544", VA = "0x1C27544")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7639BC", Offset = "0x7639BC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E6")]
		public UnityEngine.Vector3 GuideEndPos
		{
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x1C27550", Offset = "0x1C27550", VA = "0x1C27550")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7639CC", Offset = "0x7639CC")]
			get
			{
				return default(UnityEngine.Vector3);
			}
			[Token(Token = "0x6000623")]
			[Address(RVA = "0x1C2755C", Offset = "0x1C2755C", VA = "0x1C2755C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7639DC", Offset = "0x7639DC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public UnityEngine.Vector3 GuideRotate
		{
			[Token(Token = "0x6000624")]
			[Address(RVA = "0x1C27568", Offset = "0x1C27568", VA = "0x1C27568")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7639EC", Offset = "0x7639EC")]
			get
			{
				return default(UnityEngine.Vector3);
			}
			[Token(Token = "0x6000625")]
			[Address(RVA = "0x1C27574", Offset = "0x1C27574", VA = "0x1C27574")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7639FC", Offset = "0x7639FC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		public ETrigger DefaultAni
		{
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x1C27580", Offset = "0x1C27580", VA = "0x1C27580")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763A0C", Offset = "0x763A0C")]
			get
			{
				return default(ETrigger);
			}
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x1C27588", Offset = "0x1C27588", VA = "0x1C27588")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763A1C", Offset = "0x763A1C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		public ETrigger TriggerAni
		{
			[Token(Token = "0x6000628")]
			[Address(RVA = "0x1C27590", Offset = "0x1C27590", VA = "0x1C27590")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763A2C", Offset = "0x763A2C")]
			get
			{
				return default(ETrigger);
			}
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x1C27598", Offset = "0x1C27598", VA = "0x1C27598")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763A3C", Offset = "0x763A3C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		public float GuideStayTime
		{
			[Token(Token = "0x600062A")]
			[Address(RVA = "0x1C275A0", Offset = "0x1C275A0", VA = "0x1C275A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763A4C", Offset = "0x763A4C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600062B")]
			[Address(RVA = "0x1C275A8", Offset = "0x1C275A8", VA = "0x1C275A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763A5C", Offset = "0x763A5C")]
			private set
			{
			}
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x1C25D3C", Offset = "0x1C25D3C", VA = "0x1C25D3C")]
		public InteractConfigData(JSONNode _json)
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x1C27258", Offset = "0x1C27258", VA = "0x1C27258")]
		public InteractConfigData(int id, string name, float insert_time, float wait_time, float continue_time, float delay_time, string[] descs, EInteraction interaction, EPose pose, EParent sphere_parent, UnityEngine.Vector3 sphere_start_pos, UnityEngine.Vector3 sphere_end_pos, float sphere_scale, ETrigger sphere_trigger, EHand guide_hand, UnityEngine.Vector3 guide_start_pos, UnityEngine.Vector3 guide_end_pos, UnityEngine.Vector3 guide_rotate, ETrigger default_ani, ETrigger trigger_ani, float guide_stay_time)
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x1C273DC", Offset = "0x1C273DC", VA = "0x1C273DC")]
		public static InteractConfigData DeserializeInteractConfigData(JSONNode _json)
		{
			return null;
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x1C275B0", Offset = "0x1C275B0", VA = "0x1C275B0", Slot = "5")]
		public override int GetTypeId()
		{
			return default(int);
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x1C275BC", Offset = "0x1C275BC", VA = "0x1C275BC")]
		public void Resolve(Dictionary<string, object> _tables)
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x1C275C0", Offset = "0x1C275C0", VA = "0x1C275C0")]
		public void TranslateText(Func<string, string, string> translator)
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x1C275C4", Offset = "0x1C275C4", VA = "0x1C275C4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000120")]
	public sealed class MainPlotData : BeanBase
	{
		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7602FC", Offset = "0x7602FC")]
		private int <Id>k__BackingField;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76030C", Offset = "0x76030C")]
		private int <Chapter>k__BackingField;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76031C", Offset = "0x76031C")]
		private bool <IsBegin>k__BackingField;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76032C", Offset = "0x76032C")]
		private bool <IsBadEnd>k__BackingField;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76033C", Offset = "0x76033C")]
		private string <Name>k__BackingField;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76034C", Offset = "0x76034C")]
		private string <VideoName>k__BackingField;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76035C", Offset = "0x76035C")]
		private float <VideoStartTime>k__BackingField;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76036C", Offset = "0x76036C")]
		private float <VideoEndTime>k__BackingField;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76037C", Offset = "0x76037C")]
		private string <Thumbnail>k__BackingField;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76038C", Offset = "0x76038C")]
		private int[] <Interacts>k__BackingField;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76039C", Offset = "0x76039C")]
		private int <ChoiceId>k__BackingField;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7603AC", Offset = "0x7603AC")]
		private int[] <Next>k__BackingField;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7603BC", Offset = "0x7603BC")]
		private EPlayerProp[] <Rewards>k__BackingField;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7603CC", Offset = "0x7603CC")]
		private int[] <Photos>k__BackingField;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7603DC", Offset = "0x7603DC")]
		private string <ParamName>k__BackingField;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7603EC", Offset = "0x7603EC")]
		private int <ParamValue>k__BackingField;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7603FC", Offset = "0x7603FC")]
		private string <Tip>k__BackingField;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76040C", Offset = "0x76040C")]
		private string[] <Pictures>k__BackingField;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76041C", Offset = "0x76041C")]
		private EAchievement <AchievementName>k__BackingField;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76042C", Offset = "0x76042C")]
		private int <AchievementIndex>k__BackingField;

		[Token(Token = "0x400054E")]
		public const int __ID__ = -59063164;

		[Token(Token = "0x170000EB")]
		public int Id
		{
			[Token(Token = "0x6000633")]
			[Address(RVA = "0xB0DC74", Offset = "0xB0DC74", VA = "0xB0DC74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763A6C", Offset = "0x763A6C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000634")]
			[Address(RVA = "0xB0DC7C", Offset = "0xB0DC7C", VA = "0xB0DC7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763A7C", Offset = "0x763A7C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public int Chapter
		{
			[Token(Token = "0x6000635")]
			[Address(RVA = "0xB0DC84", Offset = "0xB0DC84", VA = "0xB0DC84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763A8C", Offset = "0x763A8C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000636")]
			[Address(RVA = "0xB0DC8C", Offset = "0xB0DC8C", VA = "0xB0DC8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763A9C", Offset = "0x763A9C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		public bool IsBegin
		{
			[Token(Token = "0x6000637")]
			[Address(RVA = "0xB0DC94", Offset = "0xB0DC94", VA = "0xB0DC94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763AAC", Offset = "0x763AAC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000638")]
			[Address(RVA = "0xB0DC9C", Offset = "0xB0DC9C", VA = "0xB0DC9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763ABC", Offset = "0x763ABC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000EE")]
		public bool IsBadEnd
		{
			[Token(Token = "0x6000639")]
			[Address(RVA = "0xB0DCA8", Offset = "0xB0DCA8", VA = "0xB0DCA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763ACC", Offset = "0x763ACC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600063A")]
			[Address(RVA = "0xB0DCB0", Offset = "0xB0DCB0", VA = "0xB0DCB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763ADC", Offset = "0x763ADC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000EF")]
		public string Name
		{
			[Token(Token = "0x600063B")]
			[Address(RVA = "0xB0DCBC", Offset = "0xB0DCBC", VA = "0xB0DCBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763AEC", Offset = "0x763AEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600063C")]
			[Address(RVA = "0xB0DCC4", Offset = "0xB0DCC4", VA = "0xB0DCC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763AFC", Offset = "0x763AFC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F0")]
		public string VideoName
		{
			[Token(Token = "0x600063D")]
			[Address(RVA = "0xB0DCCC", Offset = "0xB0DCCC", VA = "0xB0DCCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763B0C", Offset = "0x763B0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600063E")]
			[Address(RVA = "0xB0DCD4", Offset = "0xB0DCD4", VA = "0xB0DCD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763B1C", Offset = "0x763B1C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public float VideoStartTime
		{
			[Token(Token = "0x600063F")]
			[Address(RVA = "0xB0DCDC", Offset = "0xB0DCDC", VA = "0xB0DCDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763B2C", Offset = "0x763B2C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000640")]
			[Address(RVA = "0xB0DCE4", Offset = "0xB0DCE4", VA = "0xB0DCE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763B3C", Offset = "0x763B3C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public float VideoEndTime
		{
			[Token(Token = "0x6000641")]
			[Address(RVA = "0xB0DCEC", Offset = "0xB0DCEC", VA = "0xB0DCEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763B4C", Offset = "0x763B4C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000642")]
			[Address(RVA = "0xB0DCF4", Offset = "0xB0DCF4", VA = "0xB0DCF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763B5C", Offset = "0x763B5C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		public string Thumbnail
		{
			[Token(Token = "0x6000643")]
			[Address(RVA = "0xB0DCFC", Offset = "0xB0DCFC", VA = "0xB0DCFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763B6C", Offset = "0x763B6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000644")]
			[Address(RVA = "0xB0DD04", Offset = "0xB0DD04", VA = "0xB0DD04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763B7C", Offset = "0x763B7C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		public int[] Interacts
		{
			[Token(Token = "0x6000645")]
			[Address(RVA = "0xB0DD0C", Offset = "0xB0DD0C", VA = "0xB0DD0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763B8C", Offset = "0x763B8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000646")]
			[Address(RVA = "0xB0DD14", Offset = "0xB0DD14", VA = "0xB0DD14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763B9C", Offset = "0x763B9C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public int ChoiceId
		{
			[Token(Token = "0x6000647")]
			[Address(RVA = "0xB0DD1C", Offset = "0xB0DD1C", VA = "0xB0DD1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763BAC", Offset = "0x763BAC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000648")]
			[Address(RVA = "0xB0DD24", Offset = "0xB0DD24", VA = "0xB0DD24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763BBC", Offset = "0x763BBC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		public int[] Next
		{
			[Token(Token = "0x6000649")]
			[Address(RVA = "0xB0DD2C", Offset = "0xB0DD2C", VA = "0xB0DD2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763BCC", Offset = "0x763BCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600064A")]
			[Address(RVA = "0xB0DD34", Offset = "0xB0DD34", VA = "0xB0DD34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763BDC", Offset = "0x763BDC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public EPlayerProp[] Rewards
		{
			[Token(Token = "0x600064B")]
			[Address(RVA = "0xB0DD3C", Offset = "0xB0DD3C", VA = "0xB0DD3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763BEC", Offset = "0x763BEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600064C")]
			[Address(RVA = "0xB0DD44", Offset = "0xB0DD44", VA = "0xB0DD44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763BFC", Offset = "0x763BFC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public int[] Photos
		{
			[Token(Token = "0x600064D")]
			[Address(RVA = "0xB0DD4C", Offset = "0xB0DD4C", VA = "0xB0DD4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763C0C", Offset = "0x763C0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600064E")]
			[Address(RVA = "0xB0DD54", Offset = "0xB0DD54", VA = "0xB0DD54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763C1C", Offset = "0x763C1C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public string ParamName
		{
			[Token(Token = "0x600064F")]
			[Address(RVA = "0xB0DD5C", Offset = "0xB0DD5C", VA = "0xB0DD5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763C2C", Offset = "0x763C2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000650")]
			[Address(RVA = "0xB0DD64", Offset = "0xB0DD64", VA = "0xB0DD64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763C3C", Offset = "0x763C3C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public int ParamValue
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0xB0DD6C", Offset = "0xB0DD6C", VA = "0xB0DD6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763C4C", Offset = "0x763C4C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000652")]
			[Address(RVA = "0xB0DD74", Offset = "0xB0DD74", VA = "0xB0DD74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763C5C", Offset = "0x763C5C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public string Tip
		{
			[Token(Token = "0x6000653")]
			[Address(RVA = "0xB0DD7C", Offset = "0xB0DD7C", VA = "0xB0DD7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763C6C", Offset = "0x763C6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000654")]
			[Address(RVA = "0xB0DD84", Offset = "0xB0DD84", VA = "0xB0DD84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763C7C", Offset = "0x763C7C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000FC")]
		public string[] Pictures
		{
			[Token(Token = "0x6000655")]
			[Address(RVA = "0xB0DD8C", Offset = "0xB0DD8C", VA = "0xB0DD8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763C8C", Offset = "0x763C8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000656")]
			[Address(RVA = "0xB0DD94", Offset = "0xB0DD94", VA = "0xB0DD94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763C9C", Offset = "0x763C9C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		public EAchievement AchievementName
		{
			[Token(Token = "0x6000657")]
			[Address(RVA = "0xB0DD9C", Offset = "0xB0DD9C", VA = "0xB0DD9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763CAC", Offset = "0x763CAC")]
			get
			{
				return default(EAchievement);
			}
			[Token(Token = "0x6000658")]
			[Address(RVA = "0xB0DDA4", Offset = "0xB0DDA4", VA = "0xB0DDA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763CBC", Offset = "0x763CBC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		public int AchievementIndex
		{
			[Token(Token = "0x6000659")]
			[Address(RVA = "0xB0DDAC", Offset = "0xB0DDAC", VA = "0xB0DDAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763CCC", Offset = "0x763CCC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600065A")]
			[Address(RVA = "0xB0DDB4", Offset = "0xB0DDB4", VA = "0xB0DDB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763CDC", Offset = "0x763CDC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xB0BEAC", Offset = "0xB0BEAC", VA = "0xB0BEAC")]
		public MainPlotData(JSONNode _json)
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xB0DA78", Offset = "0xB0DA78", VA = "0xB0DA78")]
		public MainPlotData(int id, int chapter, bool is_begin, bool is_bad_end, string name, string video_name, float video_start_time, float video_end_time, string thumbnail, int[] interacts, int choice_id, int[] next, EPlayerProp[] rewards, int[] photos, string param_name, int param_value, string tip, string[] pictures, EAchievement achievement_name, int achievement_index)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xB0DC18", Offset = "0xB0DC18", VA = "0xB0DC18")]
		public static MainPlotData DeserializeMainPlotData(JSONNode _json)
		{
			return null;
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xB0DDBC", Offset = "0xB0DDBC", VA = "0xB0DDBC", Slot = "5")]
		public override int GetTypeId()
		{
			return default(int);
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xB0DDC8", Offset = "0xB0DDC8", VA = "0xB0DDC8")]
		public void Resolve(Dictionary<string, object> _tables)
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xB0DDCC", Offset = "0xB0DDCC", VA = "0xB0DDCC")]
		public void TranslateText(Func<string, string, string> translator)
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xB0DDD0", Offset = "0xB0DDD0", VA = "0xB0DDD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000121")]
	public sealed class PersonColorData : BeanBase
	{
		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76043C", Offset = "0x76043C")]
		private EPerson <ID>k__BackingField;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76044C", Offset = "0x76044C")]
		private string <Color>k__BackingField;

		[Token(Token = "0x4000551")]
		public const int __ID__ = 965239384;

		[Token(Token = "0x170000FF")]
		public EPerson ID
		{
			[Token(Token = "0x6000662")]
			[Address(RVA = "0xB10874", Offset = "0xB10874", VA = "0xB10874")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763CEC", Offset = "0x763CEC")]
			get
			{
				return default(EPerson);
			}
			[Token(Token = "0x6000663")]
			[Address(RVA = "0xB1087C", Offset = "0xB1087C", VA = "0xB1087C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763CFC", Offset = "0x763CFC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public string Color
		{
			[Token(Token = "0x6000664")]
			[Address(RVA = "0xB10884", Offset = "0xB10884", VA = "0xB10884")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763D0C", Offset = "0x763D0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000665")]
			[Address(RVA = "0xB1088C", Offset = "0xB1088C", VA = "0xB1088C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763D1C", Offset = "0x763D1C")]
			private set
			{
			}
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xB10648", Offset = "0xB10648", VA = "0xB10648")]
		public PersonColorData(JSONNode _json)
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xB107D4", Offset = "0xB107D4", VA = "0xB107D4")]
		public PersonColorData(EPerson ID, string Color)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xB10818", Offset = "0xB10818", VA = "0xB10818")]
		public static PersonColorData DeserializePersonColorData(JSONNode _json)
		{
			return null;
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xB10894", Offset = "0xB10894", VA = "0xB10894", Slot = "5")]
		public override int GetTypeId()
		{
			return default(int);
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xB108A0", Offset = "0xB108A0", VA = "0xB108A0")]
		public void Resolve(Dictionary<string, object> _tables)
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xB108A4", Offset = "0xB108A4", VA = "0xB108A4")]
		public void TranslateText(Func<string, string, string> translator)
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xB108A8", Offset = "0xB108A8", VA = "0xB108A8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000122")]
	public sealed class PhotoData : BeanBase
	{
		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76045C", Offset = "0x76045C")]
		private int <Id>k__BackingField;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76046C", Offset = "0x76046C")]
		private string <Name>k__BackingField;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76047C", Offset = "0x76047C")]
		private string <Path>k__BackingField;

		[Token(Token = "0x4000555")]
		public const int __ID__ = -1343726212;

		[Token(Token = "0x17000101")]
		public int Id
		{
			[Token(Token = "0x600066D")]
			[Address(RVA = "0xB12218", Offset = "0xB12218", VA = "0xB12218")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763D2C", Offset = "0x763D2C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600066E")]
			[Address(RVA = "0xB12220", Offset = "0xB12220", VA = "0xB12220")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763D3C", Offset = "0x763D3C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000102")]
		public string Name
		{
			[Token(Token = "0x600066F")]
			[Address(RVA = "0xB12228", Offset = "0xB12228", VA = "0xB12228")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763D4C", Offset = "0x763D4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000670")]
			[Address(RVA = "0xB12230", Offset = "0xB12230", VA = "0xB12230")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763D5C", Offset = "0x763D5C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000103")]
		public string Path
		{
			[Token(Token = "0x6000671")]
			[Address(RVA = "0xB12238", Offset = "0xB12238", VA = "0xB12238")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763D6C", Offset = "0x763D6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000672")]
			[Address(RVA = "0xB12240", Offset = "0xB12240", VA = "0xB12240")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763D7C", Offset = "0x763D7C")]
			private set
			{
			}
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xB11F30", Offset = "0xB11F30", VA = "0xB11F30")]
		public PhotoData(JSONNode _json)
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xB12164", Offset = "0xB12164", VA = "0xB12164")]
		public PhotoData(int id, string name, string path)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xB121BC", Offset = "0xB121BC", VA = "0xB121BC")]
		public static PhotoData DeserializePhotoData(JSONNode _json)
		{
			return null;
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xB12248", Offset = "0xB12248", VA = "0xB12248", Slot = "5")]
		public override int GetTypeId()
		{
			return default(int);
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xB12254", Offset = "0xB12254", VA = "0xB12254")]
		public void Resolve(Dictionary<string, object> _tables)
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xB12258", Offset = "0xB12258", VA = "0xB12258")]
		public void TranslateText(Func<string, string, string> translator)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xB1225C", Offset = "0xB1225C", VA = "0xB1225C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000123")]
	public sealed class ScenePropData : BeanBase
	{
		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76048C", Offset = "0x76048C")]
		private EPlayerProp <Id>k__BackingField;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76049C", Offset = "0x76049C")]
		private string <Desc>k__BackingField;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7604AC", Offset = "0x7604AC")]
		private UnityEngine.Vector3 <Dir>k__BackingField;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7604BC", Offset = "0x7604BC")]
		private float <Angle>k__BackingField;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7604CC", Offset = "0x7604CC")]
		private bool <Always>k__BackingField;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7604DC", Offset = "0x7604DC")]
		private string <S1N>k__BackingField;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7604EC", Offset = "0x7604EC")]
		private string <S1H>k__BackingField;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7604FC", Offset = "0x7604FC")]
		private string <S2N>k__BackingField;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76050C", Offset = "0x76050C")]
		private string <S2H>k__BackingField;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76051C", Offset = "0x76051C")]
		private string <S3N>k__BackingField;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76052C", Offset = "0x76052C")]
		private string <S3H>k__BackingField;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76053C", Offset = "0x76053C")]
		private string <S4N>k__BackingField;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76054C", Offset = "0x76054C")]
		private string <S4H>k__BackingField;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76055C", Offset = "0x76055C")]
		private string <S5N>k__BackingField;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76056C", Offset = "0x76056C")]
		private string <S5H>k__BackingField;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76057C", Offset = "0x76057C")]
		private string <S6N>k__BackingField;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76058C", Offset = "0x76058C")]
		private string <S6H>k__BackingField;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76059C", Offset = "0x76059C")]
		private string <S7N>k__BackingField;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7605AC", Offset = "0x7605AC")]
		private string <S7H>k__BackingField;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7605BC", Offset = "0x7605BC")]
		private string <S8N>k__BackingField;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7605CC", Offset = "0x7605CC")]
		private string <S8H>k__BackingField;

		[Token(Token = "0x400056B")]
		public const int __ID__ = 1262858969;

		[Token(Token = "0x17000104")]
		public EPlayerProp Id
		{
			[Token(Token = "0x600067A")]
			[Address(RVA = "0x9DED24", Offset = "0x9DED24", VA = "0x9DED24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763D8C", Offset = "0x763D8C")]
			get
			{
				return default(EPlayerProp);
			}
			[Token(Token = "0x600067B")]
			[Address(RVA = "0x9DED2C", Offset = "0x9DED2C", VA = "0x9DED2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763D9C", Offset = "0x763D9C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000105")]
		public string Desc
		{
			[Token(Token = "0x600067C")]
			[Address(RVA = "0x9DED34", Offset = "0x9DED34", VA = "0x9DED34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763DAC", Offset = "0x763DAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600067D")]
			[Address(RVA = "0x9DED3C", Offset = "0x9DED3C", VA = "0x9DED3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763DBC", Offset = "0x763DBC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000106")]
		public UnityEngine.Vector3 Dir
		{
			[Token(Token = "0x600067E")]
			[Address(RVA = "0x9DED44", Offset = "0x9DED44", VA = "0x9DED44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763DCC", Offset = "0x763DCC")]
			get
			{
				return default(UnityEngine.Vector3);
			}
			[Token(Token = "0x600067F")]
			[Address(RVA = "0x9DED50", Offset = "0x9DED50", VA = "0x9DED50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763DDC", Offset = "0x763DDC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000107")]
		public float Angle
		{
			[Token(Token = "0x6000680")]
			[Address(RVA = "0x9DED5C", Offset = "0x9DED5C", VA = "0x9DED5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763DEC", Offset = "0x763DEC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000681")]
			[Address(RVA = "0x9DED64", Offset = "0x9DED64", VA = "0x9DED64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763DFC", Offset = "0x763DFC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000108")]
		public bool Always
		{
			[Token(Token = "0x6000682")]
			[Address(RVA = "0x9DED6C", Offset = "0x9DED6C", VA = "0x9DED6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763E0C", Offset = "0x763E0C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000683")]
			[Address(RVA = "0x9DED74", Offset = "0x9DED74", VA = "0x9DED74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763E1C", Offset = "0x763E1C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000109")]
		public string S1N
		{
			[Token(Token = "0x6000684")]
			[Address(RVA = "0x9DED80", Offset = "0x9DED80", VA = "0x9DED80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763E2C", Offset = "0x763E2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000685")]
			[Address(RVA = "0x9DED88", Offset = "0x9DED88", VA = "0x9DED88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763E3C", Offset = "0x763E3C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700010A")]
		public string S1H
		{
			[Token(Token = "0x6000686")]
			[Address(RVA = "0x9DED90", Offset = "0x9DED90", VA = "0x9DED90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763E4C", Offset = "0x763E4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000687")]
			[Address(RVA = "0x9DED98", Offset = "0x9DED98", VA = "0x9DED98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763E5C", Offset = "0x763E5C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700010B")]
		public string S2N
		{
			[Token(Token = "0x6000688")]
			[Address(RVA = "0x9DEDA0", Offset = "0x9DEDA0", VA = "0x9DEDA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763E6C", Offset = "0x763E6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000689")]
			[Address(RVA = "0x9DEDA8", Offset = "0x9DEDA8", VA = "0x9DEDA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763E7C", Offset = "0x763E7C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700010C")]
		public string S2H
		{
			[Token(Token = "0x600068A")]
			[Address(RVA = "0x9DEDB0", Offset = "0x9DEDB0", VA = "0x9DEDB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763E8C", Offset = "0x763E8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600068B")]
			[Address(RVA = "0x9DEDB8", Offset = "0x9DEDB8", VA = "0x9DEDB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763E9C", Offset = "0x763E9C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700010D")]
		public string S3N
		{
			[Token(Token = "0x600068C")]
			[Address(RVA = "0x9DEDC0", Offset = "0x9DEDC0", VA = "0x9DEDC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763EAC", Offset = "0x763EAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600068D")]
			[Address(RVA = "0x9DEDC8", Offset = "0x9DEDC8", VA = "0x9DEDC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763EBC", Offset = "0x763EBC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700010E")]
		public string S3H
		{
			[Token(Token = "0x600068E")]
			[Address(RVA = "0x9DEDD0", Offset = "0x9DEDD0", VA = "0x9DEDD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763ECC", Offset = "0x763ECC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x9DEDD8", Offset = "0x9DEDD8", VA = "0x9DEDD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763EDC", Offset = "0x763EDC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700010F")]
		public string S4N
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x9DEDE0", Offset = "0x9DEDE0", VA = "0x9DEDE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763EEC", Offset = "0x763EEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x9DEDE8", Offset = "0x9DEDE8", VA = "0x9DEDE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763EFC", Offset = "0x763EFC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000110")]
		public string S4H
		{
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x9DEDF0", Offset = "0x9DEDF0", VA = "0x9DEDF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763F0C", Offset = "0x763F0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x9DEDF8", Offset = "0x9DEDF8", VA = "0x9DEDF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763F1C", Offset = "0x763F1C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000111")]
		public string S5N
		{
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x9DEE00", Offset = "0x9DEE00", VA = "0x9DEE00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763F2C", Offset = "0x763F2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x9DEE08", Offset = "0x9DEE08", VA = "0x9DEE08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763F3C", Offset = "0x763F3C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000112")]
		public string S5H
		{
			[Token(Token = "0x6000696")]
			[Address(RVA = "0x9DEE10", Offset = "0x9DEE10", VA = "0x9DEE10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763F4C", Offset = "0x763F4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000697")]
			[Address(RVA = "0x9DEE18", Offset = "0x9DEE18", VA = "0x9DEE18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763F5C", Offset = "0x763F5C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000113")]
		public string S6N
		{
			[Token(Token = "0x6000698")]
			[Address(RVA = "0x9DEE20", Offset = "0x9DEE20", VA = "0x9DEE20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763F6C", Offset = "0x763F6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000699")]
			[Address(RVA = "0x9DEE28", Offset = "0x9DEE28", VA = "0x9DEE28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763F7C", Offset = "0x763F7C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000114")]
		public string S6H
		{
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x9DEE30", Offset = "0x9DEE30", VA = "0x9DEE30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763F8C", Offset = "0x763F8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600069B")]
			[Address(RVA = "0x9DEE38", Offset = "0x9DEE38", VA = "0x9DEE38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763F9C", Offset = "0x763F9C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000115")]
		public string S7N
		{
			[Token(Token = "0x600069C")]
			[Address(RVA = "0x9DEE40", Offset = "0x9DEE40", VA = "0x9DEE40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763FAC", Offset = "0x763FAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x9DEE48", Offset = "0x9DEE48", VA = "0x9DEE48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763FBC", Offset = "0x763FBC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000116")]
		public string S7H
		{
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x9DEE50", Offset = "0x9DEE50", VA = "0x9DEE50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763FCC", Offset = "0x763FCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x9DEE58", Offset = "0x9DEE58", VA = "0x9DEE58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763FDC", Offset = "0x763FDC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000117")]
		public string S8N
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x9DEE60", Offset = "0x9DEE60", VA = "0x9DEE60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763FEC", Offset = "0x763FEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x9DEE68", Offset = "0x9DEE68", VA = "0x9DEE68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x763FFC", Offset = "0x763FFC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000118")]
		public string S8H
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x9DEE70", Offset = "0x9DEE70", VA = "0x9DEE70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76400C", Offset = "0x76400C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x9DEE78", Offset = "0x9DEE78", VA = "0x9DEE78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76401C", Offset = "0x76401C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x9DDCD0", Offset = "0x9DDCD0", VA = "0x9DDCD0")]
		public ScenePropData(JSONNode _json)
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x9DEACC", Offset = "0x9DEACC", VA = "0x9DEACC")]
		public ScenePropData(EPlayerProp id, string desc, UnityEngine.Vector3 dir, float angle, bool always, string s1_n, string s1_h, string s2_n, string s2_h, string s3_n, string s3_h, string s4_n, string s4_h, string s5_n, string s5_h, string s6_n, string s6_h, string s7_n, string s7_h, string s8_n, string s8_h)
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x9DECC8", Offset = "0x9DECC8", VA = "0x9DECC8")]
		public static ScenePropData DeserializeScenePropData(JSONNode _json)
		{
			return null;
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x9DEE80", Offset = "0x9DEE80", VA = "0x9DEE80", Slot = "5")]
		public override int GetTypeId()
		{
			return default(int);
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x9DEE8C", Offset = "0x9DEE8C", VA = "0x9DEE8C")]
		public void Resolve(Dictionary<string, object> _tables)
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x9DEE90", Offset = "0x9DEE90", VA = "0x9DEE90")]
		public void TranslateText(Func<string, string, string> translator)
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x9DEE94", Offset = "0x9DEE94", VA = "0x9DEE94", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000124")]
	public sealed class SubtitleData : BeanBase
	{
		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7605DC", Offset = "0x7605DC")]
		private string <VideoName>k__BackingField;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7605EC", Offset = "0x7605EC")]
		private Subtitle[] <Subtitles>k__BackingField;

		[Token(Token = "0x400056E")]
		public const int __ID__ = 1582853986;

		[Token(Token = "0x17000119")]
		public string VideoName
		{
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x9E3AD0", Offset = "0x9E3AD0", VA = "0x9E3AD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76402C", Offset = "0x76402C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x9E3AD8", Offset = "0x9E3AD8", VA = "0x9E3AD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76403C", Offset = "0x76403C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700011A")]
		public Subtitle[] Subtitles
		{
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x9E3AE0", Offset = "0x9E3AE0", VA = "0x9E3AE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76404C", Offset = "0x76404C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x9E3AE8", Offset = "0x9E3AE8", VA = "0x9E3AE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76405C", Offset = "0x76405C")]
			private set
			{
			}
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x9E34F8", Offset = "0x9E34F8", VA = "0x9E34F8")]
		public SubtitleData(JSONNode _json)
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x9E3A24", Offset = "0x9E3A24", VA = "0x9E3A24")]
		public SubtitleData(string video_name, Subtitle[] subtitles)
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x9E3A74", Offset = "0x9E3A74", VA = "0x9E3A74")]
		public static SubtitleData DeserializeSubtitleData(JSONNode _json)
		{
			return null;
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x9E3AF0", Offset = "0x9E3AF0", VA = "0x9E3AF0", Slot = "5")]
		public override int GetTypeId()
		{
			return default(int);
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x9E3AFC", Offset = "0x9E3AFC", VA = "0x9E3AFC")]
		public void Resolve(Dictionary<string, object> _tables)
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x9E3B64", Offset = "0x9E3B64", VA = "0x9E3B64")]
		public void TranslateText(Func<string, string, string> translator)
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x9E3BCC", Offset = "0x9E3BCC", VA = "0x9E3BCC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000125")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x75DE6C", Offset = "0x75DE6C")]
	public sealed class TableAchievementData
	{
		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<int, AchievementData> _dataMap;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<AchievementData> _dataList;

		[Token(Token = "0x1700011B")]
		public Dictionary<int, AchievementData> DataMap
		{
			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x9E5240", Offset = "0x9E5240", VA = "0x9E5240")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011C")]
		public List<AchievementData> DataList
		{
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x9E5248", Offset = "0x9E5248", VA = "0x9E5248")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011D")]
		public AchievementData Item
		{
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x9E5330", Offset = "0x9E5330", VA = "0x9E5330")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x9E4E3C", Offset = "0x9E4E3C", VA = "0x9E4E3C")]
		public TableAchievementData(JSONNode _json)
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x9E5250", Offset = "0x9E5250", VA = "0x9E5250")]
		public AchievementData GetOrDefault(int key)
		{
			return null;
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x9E52CC", Offset = "0x9E52CC", VA = "0x9E52CC")]
		public AchievementData Get(int key)
		{
			return null;
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x9E5394", Offset = "0x9E5394", VA = "0x9E5394")]
		public void Resolve(Dictionary<string, object> _tables)
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x9E54BC", Offset = "0x9E54BC", VA = "0x9E54BC")]
		public void TranslateText(Func<string, string, string> translator)
		{
		}
	}
	[Token(Token = "0x2000126")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x75DEA4", Offset = "0x75DEA4")]
	public sealed class TableButtonChoiceData
	{
		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<int, ButtonChoiceData> _dataMap;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<ButtonChoiceData> _dataList;

		[Token(Token = "0x1700011E")]
		public Dictionary<int, ButtonChoiceData> DataMap
		{
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x9E59E8", Offset = "0x9E59E8", VA = "0x9E59E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011F")]
		public List<ButtonChoiceData> DataList
		{
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x9E59F0", Offset = "0x9E59F0", VA = "0x9E59F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000120")]
		public ButtonChoiceData Item
		{
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x9E5AD8", Offset = "0x9E5AD8", VA = "0x9E5AD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x9E55E4", Offset = "0x9E55E4", VA = "0x9E55E4")]
		public TableButtonChoiceData(JSONNode _json)
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x9E59F8", Offset = "0x9E59F8", VA = "0x9E59F8")]
		public ButtonChoiceData GetOrDefault(int key)
		{
			return null;
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x9E5A74", Offset = "0x9E5A74", VA = "0x9E5A74")]
		public ButtonChoiceData Get(int key)
		{
			return null;
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x9E5B3C", Offset = "0x9E5B3C", VA = "0x9E5B3C")]
		public void Resolve(Dictionary<string, object> _tables)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x9E5C64", Offset = "0x9E5C64", VA = "0x9E5C64")]
		public void TranslateText(Func<string, string, string> translator)
		{
		}
	}
	[Token(Token = "0x2000127")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x75DEDC", Offset = "0x75DEDC")]
	public sealed class TableChapterData
	{
		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<int, ChapterData> _dataMap;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<ChapterData> _dataList;

		[Token(Token = "0x17000121")]
		public Dictionary<int, ChapterData> DataMap
		{
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x9E6190", Offset = "0x9E6190", VA = "0x9E6190")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000122")]
		public List<ChapterData> DataList
		{
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x9E6198", Offset = "0x9E6198", VA = "0x9E6198")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000123")]
		public ChapterData Item
		{
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x9E6204", Offset = "0x9E6204", VA = "0x9E6204")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x9E5D8C", Offset = "0x9E5D8C", VA = "0x9E5D8C")]
		public TableChapterData(JSONNode _json)
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x9D8E84", Offset = "0x9D8E84", VA = "0x9D8E84")]
		public ChapterData GetOrDefault(int key)
		{
			return null;
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x9E61A0", Offset = "0x9E61A0", VA = "0x9E61A0")]
		public ChapterData Get(int key)
		{
			return null;
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x9E6268", Offset = "0x9E6268", VA = "0x9E6268")]
		public void Resolve(Dictionary<string, object> _tables)
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x9E6390", Offset = "0x9E6390", VA = "0x9E6390")]
		public void TranslateText(Func<string, string, string> translator)
		{
		}
	}
	[Token(Token = "0x2000128")]
	public sealed class TableGlobalConfigData
	{
		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly GlobalConfigData _data;

		[Token(Token = "0x17000124")]
		public bool GM
		{
			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x9E65A0", Offset = "0x9E65A0", VA = "0x9E65A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000125")]
		public bool Pay
		{
			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x9E65BC", Offset = "0x9E65BC", VA = "0x9E65BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000126")]
		public bool UnlockAll
		{
			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x9E65D8", Offset = "0x9E65D8", VA = "0x9E65D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000127")]
		public bool VideoSlider
		{
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x9E65F4", Offset = "0x9E65F4", VA = "0x9E65F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000128")]
		public string ServerIP
		{
			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x9E6610", Offset = "0x9E6610", VA = "0x9E6610")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000129")]
		public int PayChapter
		{
			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x9E662C", Offset = "0x9E662C", VA = "0x9E662C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700012A")]
		public string ImageBackGround
		{
			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x9E6648", Offset = "0x9E6648", VA = "0x9E6648")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012B")]
		public string TrailerVideo
		{
			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x9E6664", Offset = "0x9E6664", VA = "0x9E6664")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012C")]
		public string SKU
		{
			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x9E6680", Offset = "0x9E6680", VA = "0x9E6680")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x9E64B8", Offset = "0x9E64B8", VA = "0x9E64B8")]
		public TableGlobalConfigData(JSONNode _json)
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x9E669C", Offset = "0x9E669C", VA = "0x9E669C")]
		public void Resolve(Dictionary<string, object> _tables)
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x9E66B8", Offset = "0x9E66B8", VA = "0x9E66B8")]
		public void TranslateText(Func<string, string, string> translator)
		{
		}
	}
	[Token(Token = "0x2000129")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x75DF14", Offset = "0x75DF14")]
	public sealed class TableInteractConfigData
	{
		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<int, InteractConfigData> _dataMap;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<InteractConfigData> _dataList;

		[Token(Token = "0x1700012D")]
		public Dictionary<int, InteractConfigData> DataMap
		{
			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x9E6AD8", Offset = "0x9E6AD8", VA = "0x9E6AD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012E")]
		public List<InteractConfigData> DataList
		{
			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x9E6AE0", Offset = "0x9E6AE0", VA = "0x9E6AE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012F")]
		public InteractConfigData Item
		{
			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x9E6BC8", Offset = "0x9E6BC8", VA = "0x9E6BC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x9E66D4", Offset = "0x9E66D4", VA = "0x9E66D4")]
		public TableInteractConfigData(JSONNode _json)
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x9E6AE8", Offset = "0x9E6AE8", VA = "0x9E6AE8")]
		public InteractConfigData GetOrDefault(int key)
		{
			return null;
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x9E6B64", Offset = "0x9E6B64", VA = "0x9E6B64")]
		public InteractConfigData Get(int key)
		{
			return null;
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x9E6C2C", Offset = "0x9E6C2C", VA = "0x9E6C2C")]
		public void Resolve(Dictionary<string, object> _tables)
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x9E6D54", Offset = "0x9E6D54", VA = "0x9E6D54")]
		public void TranslateText(Func<string, string, string> translator)
		{
		}
	}
	[Token(Token = "0x200012A")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x75DF4C", Offset = "0x75DF4C")]
	public sealed class TableMainPlotData
	{
		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<int, MainPlotData> _dataMap;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<MainPlotData> _dataList;

		[Token(Token = "0x17000130")]
		public Dictionary<int, MainPlotData> DataMap
		{
			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x9E7280", Offset = "0x9E7280", VA = "0x9E7280")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000131")]
		public List<MainPlotData> DataList
		{
			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x9E7288", Offset = "0x9E7288", VA = "0x9E7288")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000132")]
		public MainPlotData Item
		{
			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x9E7370", Offset = "0x9E7370", VA = "0x9E7370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x9E6E7C", Offset = "0x9E6E7C", VA = "0x9E6E7C")]
		public TableMainPlotData(JSONNode _json)
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x9E7290", Offset = "0x9E7290", VA = "0x9E7290")]
		public MainPlotData GetOrDefault(int key)
		{
			return null;
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x9E730C", Offset = "0x9E730C", VA = "0x9E730C")]
		public MainPlotData Get(int key)
		{
			return null;
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x9E73D4", Offset = "0x9E73D4", VA = "0x9E73D4")]
		public void Resolve(Dictionary<string, object> _tables)
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x9E74FC", Offset = "0x9E74FC", VA = "0x9E74FC")]
		public void TranslateText(Func<string, string, string> translator)
		{
		}
	}
	[Token(Token = "0x200012B")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x75DF84", Offset = "0x75DF84")]
	public sealed class TablePersonColorDaa
	{
		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<EPerson, PersonColorData> _dataMap;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<PersonColorData> _dataList;

		[Token(Token = "0x17000133")]
		public Dictionary<EPerson, PersonColorData> DataMap
		{
			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x9E7A28", Offset = "0x9E7A28", VA = "0x9E7A28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000134")]
		public List<PersonColorData> DataList
		{
			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x9E7A30", Offset = "0x9E7A30", VA = "0x9E7A30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000135")]
		public PersonColorData Item
		{
			[Token(Token = "0x60006EC")]
			[Address(RVA = "0x9E7A9C", Offset = "0x9E7A9C", VA = "0x9E7A9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x9E7624", Offset = "0x9E7624", VA = "0x9E7624")]
		public TablePersonColorDaa(JSONNode _json)
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x9E47D4", Offset = "0x9E47D4", VA = "0x9E47D4")]
		public PersonColorData GetOrDefault(EPerson key)
		{
			return null;
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x9E7A38", Offset = "0x9E7A38", VA = "0x9E7A38")]
		public PersonColorData Get(EPerson key)
		{
			return null;
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x9E7B00", Offset = "0x9E7B00", VA = "0x9E7B00")]
		public void Resolve(Dictionary<string, object> _tables)
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x9E7C28", Offset = "0x9E7C28", VA = "0x9E7C28")]
		public void TranslateText(Func<string, string, string> translator)
		{
		}
	}
	[Token(Token = "0x200012C")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x75DFBC", Offset = "0x75DFBC")]
	public sealed class TablePhotoData
	{
		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<int, PhotoData> _dataMap;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<PhotoData> _dataList;

		[Token(Token = "0x17000136")]
		public Dictionary<int, PhotoData> DataMap
		{
			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x9E8154", Offset = "0x9E8154", VA = "0x9E8154")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000137")]
		public List<PhotoData> DataList
		{
			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x9E815C", Offset = "0x9E815C", VA = "0x9E815C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000138")]
		public PhotoData Item
		{
			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x9E8244", Offset = "0x9E8244", VA = "0x9E8244")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x9E7D50", Offset = "0x9E7D50", VA = "0x9E7D50")]
		public TablePhotoData(JSONNode _json)
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x9E8164", Offset = "0x9E8164", VA = "0x9E8164")]
		public PhotoData GetOrDefault(int key)
		{
			return null;
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x9E81E0", Offset = "0x9E81E0", VA = "0x9E81E0")]
		public PhotoData Get(int key)
		{
			return null;
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x9E82A8", Offset = "0x9E82A8", VA = "0x9E82A8")]
		public void Resolve(Dictionary<string, object> _tables)
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x9E83D0", Offset = "0x9E83D0", VA = "0x9E83D0")]
		public void TranslateText(Func<string, string, string> translator)
		{
		}
	}
	[Token(Token = "0x200012D")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x75DFF4", Offset = "0x75DFF4")]
	public sealed class TableScenePropData
	{
		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<EPlayerProp, ScenePropData> _dataMap;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<ScenePropData> _dataList;

		[Token(Token = "0x17000139")]
		public Dictionary<EPlayerProp, ScenePropData> DataMap
		{
			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x9E88F8", Offset = "0x9E88F8", VA = "0x9E88F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013A")]
		public List<ScenePropData> DataList
		{
			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x9E8900", Offset = "0x9E8900", VA = "0x9E8900")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013B")]
		public ScenePropData Item
		{
			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x9E896C", Offset = "0x9E896C", VA = "0x9E896C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x9E84F8", Offset = "0x9E84F8", VA = "0x9E84F8")]
		public TableScenePropData(JSONNode _json)
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x9DA9A4", Offset = "0x9DA9A4", VA = "0x9DA9A4")]
		public ScenePropData GetOrDefault(EPlayerProp key)
		{
			return null;
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x9E8908", Offset = "0x9E8908", VA = "0x9E8908")]
		public ScenePropData Get(EPlayerProp key)
		{
			return null;
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x9E89D0", Offset = "0x9E89D0", VA = "0x9E89D0")]
		public void Resolve(Dictionary<string, object> _tables)
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x9E8AD8", Offset = "0x9E8AD8", VA = "0x9E8AD8")]
		public void TranslateText(Func<string, string, string> translator)
		{
		}
	}
	[Token(Token = "0x200012E")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x75E02C", Offset = "0x75E02C")]
	public sealed class TableSubtitleData
	{
		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, SubtitleData> _dataMap;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<SubtitleData> _dataList;

		[Token(Token = "0x1700013C")]
		public Dictionary<string, SubtitleData> DataMap
		{
			[Token(Token = "0x6000700")]
			[Address(RVA = "0x9E8FE0", Offset = "0x9E8FE0", VA = "0x9E8FE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013D")]
		public List<SubtitleData> DataList
		{
			[Token(Token = "0x6000701")]
			[Address(RVA = "0x9E8FE8", Offset = "0x9E8FE8", VA = "0x9E8FE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013E")]
		public SubtitleData Item
		{
			[Token(Token = "0x6000704")]
			[Address(RVA = "0x9E9054", Offset = "0x9E9054", VA = "0x9E9054")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x9E8BE0", Offset = "0x9E8BE0", VA = "0x9E8BE0")]
		public TableSubtitleData(JSONNode _json)
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x9E2A64", Offset = "0x9E2A64", VA = "0x9E2A64")]
		public SubtitleData GetOrDefault(string key)
		{
			return null;
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x9E8FF0", Offset = "0x9E8FF0", VA = "0x9E8FF0")]
		public SubtitleData Get(string key)
		{
			return null;
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x9E90B8", Offset = "0x9E90B8", VA = "0x9E90B8")]
		public void Resolve(Dictionary<string, object> _tables)
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x9E91CC", Offset = "0x9E91CC", VA = "0x9E91CC")]
		public void TranslateText(Func<string, string, string> translator)
		{
		}
	}
	[Token(Token = "0x200012F")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x75E064", Offset = "0x75E064")]
	public sealed class TableWindowMappingData
	{
		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, WindowMappingData> _dataMap;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<WindowMappingData> _dataList;

		[Token(Token = "0x1700013F")]
		public Dictionary<string, WindowMappingData> DataMap
		{
			[Token(Token = "0x6000708")]
			[Address(RVA = "0x9E96E4", Offset = "0x9E96E4", VA = "0x9E96E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000140")]
		public List<WindowMappingData> DataList
		{
			[Token(Token = "0x6000709")]
			[Address(RVA = "0x9E96EC", Offset = "0x9E96EC", VA = "0x9E96EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000141")]
		public WindowMappingData Item
		{
			[Token(Token = "0x600070C")]
			[Address(RVA = "0x9E97D4", Offset = "0x9E97D4", VA = "0x9E97D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x9E92E0", Offset = "0x9E92E0", VA = "0x9E92E0")]
		public TableWindowMappingData(JSONNode _json)
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x9E96F4", Offset = "0x9E96F4", VA = "0x9E96F4")]
		public WindowMappingData GetOrDefault(string key)
		{
			return null;
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x9E9770", Offset = "0x9E9770", VA = "0x9E9770")]
		public WindowMappingData Get(string key)
		{
			return null;
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x9E9838", Offset = "0x9E9838", VA = "0x9E9838")]
		public void Resolve(Dictionary<string, object> _tables)
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x9E9960", Offset = "0x9E9960", VA = "0x9E9960")]
		public void TranslateText(Func<string, string, string> translator)
		{
		}
	}
	[Token(Token = "0x2000130")]
	public sealed class WindowMappingData : BeanBase
	{
		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7605FC", Offset = "0x7605FC")]
		private string <Name>k__BackingField;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76060C", Offset = "0x76060C")]
		private string <Prefab>k__BackingField;

		[Token(Token = "0x4000586")]
		public const int __ID__ = -278396920;

		[Token(Token = "0x17000142")]
		public string Name
		{
			[Token(Token = "0x6000712")]
			[Address(RVA = "0x1BF9C5C", Offset = "0x1BF9C5C", VA = "0x1BF9C5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76406C", Offset = "0x76406C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000713")]
			[Address(RVA = "0x1BF9C64", Offset = "0x1BF9C64", VA = "0x1BF9C64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76407C", Offset = "0x76407C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000143")]
		public string Prefab
		{
			[Token(Token = "0x6000714")]
			[Address(RVA = "0x1BF9C6C", Offset = "0x1BF9C6C", VA = "0x1BF9C6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76408C", Offset = "0x76408C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000715")]
			[Address(RVA = "0x1BF9C74", Offset = "0x1BF9C74", VA = "0x1BF9C74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76409C", Offset = "0x76409C")]
			private set
			{
			}
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x1BF99FC", Offset = "0x1BF99FC", VA = "0x1BF99FC")]
		public WindowMappingData(JSONNode _json)
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x1BF9BB0", Offset = "0x1BF9BB0", VA = "0x1BF9BB0")]
		public WindowMappingData(string name, string prefab)
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x1BF9C00", Offset = "0x1BF9C00", VA = "0x1BF9C00")]
		public static WindowMappingData DeserializeWindowMappingData(JSONNode _json)
		{
			return null;
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x1BF9C7C", Offset = "0x1BF9C7C", VA = "0x1BF9C7C", Slot = "5")]
		public override int GetTypeId()
		{
			return default(int);
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x1BF9C88", Offset = "0x1BF9C88", VA = "0x1BF9C88")]
		public void Resolve(Dictionary<string, object> _tables)
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x1BF9C8C", Offset = "0x1BF9C8C", VA = "0x1BF9C8C")]
		public void TranslateText(Func<string, string, string> translator)
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x1BF9C90", Offset = "0x1BF9C90", VA = "0x1BF9C90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace SimpleJSON
{
	[Token(Token = "0x2000131")]
	public enum JSONNodeType
	{
		[Token(Token = "0x4000588")]
		Array = 1,
		[Token(Token = "0x4000589")]
		Object = 2,
		[Token(Token = "0x400058A")]
		String = 3,
		[Token(Token = "0x400058B")]
		Number = 4,
		[Token(Token = "0x400058C")]
		NullValue = 5,
		[Token(Token = "0x400058D")]
		Boolean = 6,
		[Token(Token = "0x400058E")]
		None = 7,
		[Token(Token = "0x400058F")]
		Custom = 255
	}
	[Token(Token = "0x2000132")]
	public enum JSONTextMode
	{
		[Token(Token = "0x4000591")]
		Compact,
		[Token(Token = "0x4000592")]
		Indent
	}
	[Token(Token = "0x2000133")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x75E09C", Offset = "0x75E09C")]
	public abstract class JSONNode
	{
		[Token(Token = "0x2000134")]
		public struct Enumerator
		{
			[Token(Token = "0x2000135")]
			private enum Type
			{
				[Token(Token = "0x40005A1")]
				None,
				[Token(Token = "0x40005A2")]
				Array,
				[Token(Token = "0x40005A3")]
				Object
			}

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Type type;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private Dictionary<string, JSONNode>.Enumerator m_Object;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator m_Array;

			[Token(Token = "0x1700016C")]
			public bool IsValid
			{
				[Token(Token = "0x60007E2")]
				[Address(RVA = "0x1C0EC84", Offset = "0x1C0EC84", VA = "0x1C0EC84")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700016D")]
			public KeyValuePair<string, JSONNode> Current
			{
				[Token(Token = "0x60007E5")]
				[Address(RVA = "0x1C0ED10", Offset = "0x1C0ED10", VA = "0x1C0ED10")]
				get
				{
					return default(KeyValuePair<string, JSONNode>);
				}
			}

			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x1C0EC94", Offset = "0x1C0EC94", VA = "0x1C0EC94")]
			public Enumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x1C0ECC8", Offset = "0x1C0ECC8", VA = "0x1C0ECC8")]
			public Enumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x1C0EDE4", Offset = "0x1C0EDE4", VA = "0x1C0EDE4")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000136")]
		public struct ValueEnumerator
		{
			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Enumerator m_Enumerator;

			[Token(Token = "0x1700016E")]
			public JSONNode Current
			{
				[Token(Token = "0x60007EA")]
				[Address(RVA = "0x1C0F454", Offset = "0x1C0F454", VA = "0x1C0F454")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x1C0F328", Offset = "0x1C0F328", VA = "0x1C0F328")]
			public ValueEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x1C0F39C", Offset = "0x1C0F39C", VA = "0x1C0F39C")]
			public ValueEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x1C0F428", Offset = "0x1C0F428", VA = "0x1C0F428")]
			public ValueEnumerator(Enumerator aEnumerator)
			{
			}

			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x1C0F49C", Offset = "0x1C0F49C", VA = "0x1C0F49C")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x1C0F4A0", Offset = "0x1C0F4A0", VA = "0x1C0F4A0")]
			public ValueEnumerator GetEnumerator()
			{
				return default(ValueEnumerator);
			}
		}

		[Token(Token = "0x2000137")]
		public struct KeyEnumerator
		{
			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Enumerator m_Enumerator;

			[Token(Token = "0x1700016F")]
			public string Current
			{
				[Token(Token = "0x60007F0")]
				[Address(RVA = "0x1C0EFA8", Offset = "0x1C0EFA8", VA = "0x1C0EFA8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x1C0EE7C", Offset = "0x1C0EE7C", VA = "0x1C0EE7C")]
			public KeyEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x1C0EEF0", Offset = "0x1C0EEF0", VA = "0x1C0EEF0")]
			public KeyEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x1C0EF7C", Offset = "0x1C0EF7C", VA = "0x1C0EF7C")]
			public KeyEnumerator(Enumerator aEnumerator)
			{
			}

			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x1C0EFE8", Offset = "0x1C0EFE8", VA = "0x1C0EFE8")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x1C0EFEC", Offset = "0x1C0EFEC", VA = "0x1C0EFEC")]
			public KeyEnumerator GetEnumerator()
			{
				return default(KeyEnumerator);
			}
		}

		[Token(Token = "0x2000138")]
		public class LinqEnumerator : IEnumerator<KeyValuePair<string, JSONNode>>, IEnumerator, IDisposable, IEnumerable<KeyValuePair<string, JSONNode>>, IEnumerable
		{
			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private JSONNode m_Node;

			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Enumerator m_Enumerator;

			[Token(Token = "0x17000170")]
			public KeyValuePair<string, JSONNode> Current
			{
				[Token(Token = "0x60007F4")]
				[Address(RVA = "0x1C0F0F0", Offset = "0x1C0F0F0", VA = "0x1C0F0F0", Slot = "4")]
				get
				{
					return default(KeyValuePair<string, JSONNode>);
				}
			}

			[Token(Token = "0x17000171")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007F5")]
				[Address(RVA = "0x1C0F0F8", Offset = "0x1C0F0F8", VA = "0x1C0F0F8", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x1C0EFFC", Offset = "0x1C0EFFC", VA = "0x1C0EFFC")]
			internal LinqEnumerator(JSONNode aNode)
			{
			}

			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x1C0F160", Offset = "0x1C0F160", VA = "0x1C0F160", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x1C0F168", Offset = "0x1C0F168", VA = "0x1C0F168", Slot = "5")]
			public void Dispose()
			{
			}

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x1C0F1A0", Offset = "0x1C0F1A0", VA = "0x1C0F1A0", Slot = "9")]
			public IEnumerator<KeyValuePair<string, JSONNode>> GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x1C0F200", Offset = "0x1C0F200", VA = "0x1C0F200", Slot = "8")]
			public void Reset()
			{
			}

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x1C0F2C8", Offset = "0x1C0F2C8", VA = "0x1C0F2C8", Slot = "10")]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000139")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E0D4", Offset = "0x75E0D4")]
		private sealed class <get_Children>d__43 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x17000172")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x60007FE")]
				[Address(RVA = "0x1C0E3EC", Offset = "0x1C0E3EC", VA = "0x1C0E3EC", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000173")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000800")]
				[Address(RVA = "0x1C0E434", Offset = "0x1C0E434", VA = "0x1C0E434", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x1C0E398", Offset = "0x1C0E398", VA = "0x1C0E398")]
			[DebuggerHidden]
			public <get_Children>d__43(int <>1__state)
			{
			}

			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x1C0E3D0", Offset = "0x1C0E3D0", VA = "0x1C0E3D0", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x1C0E3D4", Offset = "0x1C0E3D4", VA = "0x1C0E3D4", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x1C0E3F4", Offset = "0x1C0E3F4", VA = "0x1C0E3F4", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000801")]
			[Address(RVA = "0x1C0E43C", Offset = "0x1C0E43C", VA = "0x1C0E43C", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000802")]
			[Address(RVA = "0x1C0E4D0", Offset = "0x1C0E4D0", VA = "0x1C0E4D0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x200013A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E0E4", Offset = "0x75E0E4")]
		private sealed class <get_DeepChildren>d__45 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONNode <>4__this;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IEnumerator<JSONNode> <>7__wrap1;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IEnumerator<JSONNode> <>7__wrap2;

			[Token(Token = "0x17000174")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000808")]
				[Address(RVA = "0x1C0EB80", Offset = "0x1C0EB80", VA = "0x1C0EB80", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000175")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600080A")]
				[Address(RVA = "0x1C0EBC8", Offset = "0x1C0EBC8", VA = "0x1C0EBC8", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000803")]
			[Address(RVA = "0x1C0E4D4", Offset = "0x1C0E4D4", VA = "0x1C0E4D4")]
			[DebuggerHidden]
			public <get_DeepChildren>d__45(int <>1__state)
			{
			}

			[Token(Token = "0x6000804")]
			[Address(RVA = "0x1C0E50C", Offset = "0x1C0E50C", VA = "0x1C0E50C", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000805")]
			[Address(RVA = "0x1C0E714", Offset = "0x1C0E714", VA = "0x1C0E714", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000806")]
			[Address(RVA = "0x1C0E658", Offset = "0x1C0E658", VA = "0x1C0E658")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000807")]
			[Address(RVA = "0x1C0E59C", Offset = "0x1C0E59C", VA = "0x1C0E59C")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x6000809")]
			[Address(RVA = "0x1C0EB88", Offset = "0x1C0EB88", VA = "0x1C0EB88", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600080B")]
			[Address(RVA = "0x1C0EBD0", Offset = "0x1C0EBD0", VA = "0x1C0EBD0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600080C")]
			[Address(RVA = "0x1C0EC80", Offset = "0x1C0EC80", VA = "0x1C0EC80", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool forceASCII;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public static bool longAsString;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public static bool allowLineComments;

		[Token(Token = "0x4000596")]
		[ThreadStatic]
		private static StringBuilder m_EscapeBuilder;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public static byte Color32DefaultAlpha;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float ColorDefaultAlpha;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static JSONContainerType VectorContainerType;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static JSONContainerType QuaternionContainerType;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static JSONContainerType RectContainerType;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static JSONContainerType ColorContainerType;

		[Token(Token = "0x17000144")]
		public abstract JSONNodeType Tag
		{
			[Token(Token = "0x600071A")]
			get;
		}

		[Token(Token = "0x17000145")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x600071B")]
			[Address(RVA = "0x1C2B304", Offset = "0x1C2B304", VA = "0x1C2B304", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600071C")]
			[Address(RVA = "0x1C2B30C", Offset = "0x1C2B30C", VA = "0x1C2B30C", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000146")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x600071D")]
			[Address(RVA = "0x1C2B310", Offset = "0x1C2B310", VA = "0x1C2B310", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600071E")]
			[Address(RVA = "0x1C2B318", Offset = "0x1C2B318", VA = "0x1C2B318", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000147")]
		public virtual string Value
		{
			[Token(Token = "0x600071F")]
			[Address(RVA = "0x1C2B31C", Offset = "0x1C2B31C", VA = "0x1C2B31C", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000720")]
			[Address(RVA = "0x1C2B360", Offset = "0x1C2B360", VA = "0x1C2B360", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000148")]
		public virtual int Count
		{
			[Token(Token = "0x6000721")]
			[Address(RVA = "0x1C2B364", Offset = "0x1C2B364", VA = "0x1C2B364", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000149")]
		public virtual bool IsNumber
		{
			[Token(Token = "0x6000722")]
			[Address(RVA = "0x1C2B36C", Offset = "0x1C2B36C", VA = "0x1C2B36C", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700014A")]
		public virtual bool IsString
		{
			[Token(Token = "0x6000723")]
			[Address(RVA = "0x1C2B374", Offset = "0x1C2B374", VA = "0x1C2B374", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700014B")]
		public virtual bool IsBoolean
		{
			[Token(Token = "0x6000724")]
			[Address(RVA = "0x1C2B37C", Offset = "0x1C2B37C", VA = "0x1C2B37C", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700014C")]
		public virtual bool IsNull
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x1C2B384", Offset = "0x1C2B384", VA = "0x1C2B384", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700014D")]
		public virtual bool IsArray
		{
			[Token(Token = "0x6000726")]
			[Address(RVA = "0x1C2B38C", Offset = "0x1C2B38C", VA = "0x1C2B38C", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700014E")]
		public virtual bool IsObject
		{
			[Token(Token = "0x6000727")]
			[Address(RVA = "0x1C2B394", Offset = "0x1C2B394", VA = "0x1C2B394", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700014F")]
		public virtual bool Inline
		{
			[Token(Token = "0x6000728")]
			[Address(RVA = "0x1C2B39C", Offset = "0x1C2B39C", VA = "0x1C2B39C", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000729")]
			[Address(RVA = "0x1C2B3A4", Offset = "0x1C2B3A4", VA = "0x1C2B3A4", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000150")]
		public virtual IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x6000731")]
			[Address(RVA = "0x1C2B438", Offset = "0x1C2B438", VA = "0x1C2B438", Slot = "27")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7640AC", Offset = "0x7640AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000151")]
		public IEnumerable<JSONNode> DeepChildren
		{
			[Token(Token = "0x6000732")]
			[Address(RVA = "0x1C2B494", Offset = "0x1C2B494", VA = "0x1C2B494")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x76410C", Offset = "0x76410C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000152")]
		public IEnumerable<KeyValuePair<string, JSONNode>> Linq
		{
			[Token(Token = "0x6000739")]
			[Address(RVA = "0x1C2B648", Offset = "0x1C2B648", VA = "0x1C2B648")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000153")]
		public KeyEnumerator Keys
		{
			[Token(Token = "0x600073A")]
			[Address(RVA = "0x1C2B6A8", Offset = "0x1C2B6A8", VA = "0x1C2B6A8")]
			get
			{
				return default(KeyEnumerator);
			}
		}

		[Token(Token = "0x17000154")]
		public ValueEnumerator Values
		{
			[Token(Token = "0x600073B")]
			[Address(RVA = "0x1C2B6FC", Offset = "0x1C2B6FC", VA = "0x1C2B6FC")]
			get
			{
				return default(ValueEnumerator);
			}
		}

		[Token(Token = "0x17000155")]
		public virtual double AsDouble
		{
			[Token(Token = "0x600073C")]
			[Address(RVA = "0x1C2B750", Offset = "0x1C2B750", VA = "0x1C2B750", Slot = "33")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x600073D")]
			[Address(RVA = "0x1C2B834", Offset = "0x1C2B834", VA = "0x1C2B834", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x17000156")]
		public virtual int AsInt
		{
			[Token(Token = "0x600073E")]
			[Address(RVA = "0x1C2B8C8", Offset = "0x1C2B8C8", VA = "0x1C2B8C8", Slot = "35")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600073F")]
			[Address(RVA = "0x1C2B900", Offset = "0x1C2B900", VA = "0x1C2B900", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x17000157")]
		public virtual float AsFloat
		{
			[Token(Token = "0x6000740")]
			[Address(RVA = "0x1C2B918", Offset = "0x1C2B918", VA = "0x1C2B918", Slot = "37")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000741")]
			[Address(RVA = "0x1C2B93C", Offset = "0x1C2B93C", VA = "0x1C2B93C", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x17000158")]
		public virtual bool AsBool
		{
			[Token(Token = "0x6000742")]
			[Address(RVA = "0x1C2B950", Offset = "0x1C2B950", VA = "0x1C2B950", Slot = "39")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000743")]
			[Address(RVA = "0x1C2BA14", Offset = "0x1C2BA14", VA = "0x1C2BA14", Slot = "40")]
			set
			{
			}
		}

		[Token(Token = "0x17000159")]
		public virtual long AsLong
		{
			[Token(Token = "0x6000744")]
			[Address(RVA = "0x1C2BA98", Offset = "0x1C2BA98", VA = "0x1C2BA98", Slot = "41")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000745")]
			[Address(RVA = "0x1C2BAD8", Offset = "0x1C2BAD8", VA = "0x1C2BAD8", Slot = "42")]
			set
			{
			}
		}

		[Token(Token = "0x1700015A")]
		public virtual ulong AsULong
		{
			[Token(Token = "0x6000746")]
			[Address(RVA = "0x1C2BB18", Offset = "0x1C2BB18", VA = "0x1C2BB18", Slot = "43")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x6000747")]
			[Address(RVA = "0x1C2BB58", Offset = "0x1C2BB58", VA = "0x1C2BB58", Slot = "44")]
			set
			{
			}
		}

		[Token(Token = "0x1700015B")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x6000748")]
			[Address(RVA = "0x1C2BB98", Offset = "0x1C2BB98", VA = "0x1C2BB98", Slot = "45")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015C")]
		public virtual JSONObject AsObject
		{
			[Token(Token = "0x6000749")]
			[Address(RVA = "0x1C2BC14", Offset = "0x1C2BC14", VA = "0x1C2BC14", Slot = "46")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015D")]
		internal static StringBuilder EscapeBuilder
		{
			[Token(Token = "0x600075D")]
			[Address(RVA = "0x1C2C2A4", Offset = "0x1C2C2A4", VA = "0x1C2C2A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015E")]
		public virtual decimal AsDecimal
		{
			[Token(Token = "0x600076F")]
			[Address(RVA = "0x1C2D654", Offset = "0x1C2D654", VA = "0x1C2D654", Slot = "48")]
			get
			{
				return default(decimal);
			}
			[Token(Token = "0x6000770")]
			[Address(RVA = "0x1C2D6FC", Offset = "0x1C2D6FC", VA = "0x1C2D6FC", Slot = "49")]
			set
			{
			}
		}

		[Token(Token = "0x1700015F")]
		public virtual char AsChar
		{
			[Token(Token = "0x6000773")]
			[Address(RVA = "0x1C2D7E0", Offset = "0x1C2D7E0", VA = "0x1C2D7E0", Slot = "50")]
			get
			{
				return default(char);
			}
			[Token(Token = "0x6000774")]
			[Address(RVA = "0x1C2D88C", Offset = "0x1C2D88C", VA = "0x1C2D88C", Slot = "51")]
			set
			{
			}
		}

		[Token(Token = "0x17000160")]
		public virtual uint AsUInt
		{
			[Token(Token = "0x6000777")]
			[Address(RVA = "0x1C2D9C4", Offset = "0x1C2D9C4", VA = "0x1C2D9C4", Slot = "52")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6000778")]
			[Address(RVA = "0x1C2D9F4", Offset = "0x1C2D9F4", VA = "0x1C2D9F4", Slot = "53")]
			set
			{
			}
		}

		[Token(Token = "0x17000161")]
		public virtual byte AsByte
		{
			[Token(Token = "0x600077B")]
			[Address(RVA = "0x1C2DA8C", Offset = "0x1C2DA8C", VA = "0x1C2DA8C", Slot = "54")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x600077C")]
			[Address(RVA = "0x1C2DAAC", Offset = "0x1C2DAAC", VA = "0x1C2DAAC", Slot = "55")]
			set
			{
			}
		}

		[Token(Token = "0x17000162")]
		public virtual sbyte AsSByte
		{
			[Token(Token = "0x600077F")]
			[Address(RVA = "0x1C2DB44", Offset = "0x1C2DB44", VA = "0x1C2DB44", Slot = "56")]
			get
			{
				return default(sbyte);
			}
			[Token(Token = "0x6000780")]
			[Address(RVA = "0x1C2DB64", Offset = "0x1C2DB64", VA = "0x1C2DB64", Slot = "57")]
			set
			{
			}
		}

		[Token(Token = "0x17000163")]
		public virtual short AsShort
		{
			[Token(Token = "0x6000783")]
			[Address(RVA = "0x1C2DBFC", Offset = "0x1C2DBFC", VA = "0x1C2DBFC", Slot = "58")]
			get
			{
				return default(short);
			}
			[Token(Token = "0x6000784")]
			[Address(RVA = "0x1C2DC1C", Offset = "0x1C2DC1C", VA = "0x1C2DC1C", Slot = "59")]
			set
			{
			}
		}

		[Token(Token = "0x17000164")]
		public virtual ushort AsUShort
		{
			[Token(Token = "0x6000787")]
			[Address(RVA = "0x1C2DCB4", Offset = "0x1C2DCB4", VA = "0x1C2DCB4", Slot = "60")]
			get
			{
				return default(ushort);
			}
			[Token(Token = "0x6000788")]
			[Address(RVA = "0x1C2DCD4", Offset = "0x1C2DCD4", VA = "0x1C2DCD4", Slot = "61")]
			set
			{
			}
		}

		[Token(Token = "0x17000165")]
		public virtual DateTime AsDateTime
		{
			[Token(Token = "0x600078B")]
			[Address(RVA = "0x1C2DD6C", Offset = "0x1C2DD6C", VA = "0x1C2DD6C", Slot = "62")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x600078C")]
			[Address(RVA = "0x1C2DE58", Offset = "0x1C2DE58", VA = "0x1C2DE58", Slot = "63")]
			set
			{
			}
		}

		[Token(Token = "0x17000166")]
		public virtual TimeSpan AsTimeSpan
		{
			[Token(Token = "0x600078F")]
			[Address(RVA = "0x1C2DFC0", Offset = "0x1C2DFC0", VA = "0x1C2DFC0", Slot = "64")]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6000790")]
			[Address(RVA = "0x1C2E0A4", Offset = "0x1C2E0A4", VA = "0x1C2E0A4", Slot = "65")]
			set
			{
			}
		}

		[Token(Token = "0x17000167")]
		public virtual Guid AsGuid
		{
			[Token(Token = "0x6000793")]
			[Address(RVA = "0x1C2E180", Offset = "0x1C2E180", VA = "0x1C2E180", Slot = "66")]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6000794")]
			[Address(RVA = "0x1C2E214", Offset = "0x1C2E214", VA = "0x1C2E214", Slot = "67")]
			set
			{
			}
		}

		[Token(Token = "0x17000168")]
		public virtual byte[] AsByteArray
		{
			[Token(Token = "0x6000797")]
			[Address(RVA = "0x1C2E2F8", Offset = "0x1C2E2F8", VA = "0x1C2E2F8", Slot = "68")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000798")]
			[Address(RVA = "0x1C2E41C", Offset = "0x1C2E41C", VA = "0x1C2E41C", Slot = "69")]
			set
			{
			}
		}

		[Token(Token = "0x17000169")]
		public virtual List<byte> AsByteList
		{
			[Token(Token = "0x600079B")]
			[Address(RVA = "0x1C2E5B4", Offset = "0x1C2E5B4", VA = "0x1C2E5B4", Slot = "70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600079C")]
			[Address(RVA = "0x1C2E6F4", Offset = "0x1C2E6F4", VA = "0x1C2E6F4", Slot = "71")]
			set
			{
			}
		}

		[Token(Token = "0x1700016A")]
		public virtual string[] AsStringArray
		{
			[Token(Token = "0x600079F")]
			[Address(RVA = "0x1C2E8A0", Offset = "0x1C2E8A0", VA = "0x1C2E8A0", Slot = "72")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x1C2EA04", Offset = "0x1C2EA04", VA = "0x1C2EA04", Slot = "73")]
			set
			{
			}
		}

		[Token(Token = "0x1700016B")]
		public virtual List<string> AsStringList
		{
			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x1C2EB9C", Offset = "0x1C2EB9C", VA = "0x1C2EB9C", Slot = "74")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x1C2ECD8", Offset = "0x1C2ECD8", VA = "0x1C2ECD8", Slot = "75")]
			set
			{
			}
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x1C2B3A8", Offset = "0x1C2B3A8", VA = "0x1C2B3A8", Slot = "20")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x1C2B3AC", Offset = "0x1C2B3AC", VA = "0x1C2B3AC", Slot = "21")]
		public virtual void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x1C2B414", Offset = "0x1C2B414", VA = "0x1C2B414", Slot = "22")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x1C2B41C", Offset = "0x1C2B41C", VA = "0x1C2B41C", Slot = "23")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x1C2B424", Offset = "0x1C2B424", VA = "0x1C2B424", Slot = "24")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x1C2B42C", Offset = "0x1C2B42C", VA = "0x1C2B42C", Slot = "25")]
		public virtual void Clear()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x1C2B430", Offset = "0x1C2B430", VA = "0x1C2B430", Slot = "26")]
		public virtual JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x1C2B50C", Offset = "0x1C2B50C", VA = "0x1C2B50C", Slot = "28")]
		public virtual bool HasKey(string aKey)
		{
			return default(bool);
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x1C2B514", Offset = "0x1C2B514", VA = "0x1C2B514", Slot = "29")]
		public virtual JSONNode GetValueOrDefault(string aKey, JSONNode aDefault)
		{
			return null;
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x1C2B51C", Offset = "0x1C2B51C", VA = "0x1C2B51C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x1C2B5AC", Offset = "0x1C2B5AC", VA = "0x1C2B5AC", Slot = "30")]
		public virtual string ToString(int aIndent)
		{
			return null;
		}

		[Token(Token = "0x6000737")]
		internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);

		[Token(Token = "0x6000738")]
		public abstract Enumerator GetEnumerator();

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x1C2BC90", Offset = "0x1C2BC90", VA = "0x1C2BC90")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x1C17860", Offset = "0x1C17860", VA = "0x1C17860")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x1C2BD30", Offset = "0x1C2BD30", VA = "0x1C2BD30")]
		public static implicit operator JSONNode(double n)
		{
			return null;
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x1C2BD98", Offset = "0x1C2BD98", VA = "0x1C2BD98")]
		public static implicit operator double(JSONNode d)
		{
			return default(double);
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x1C2BE2C", Offset = "0x1C2BE2C", VA = "0x1C2BE2C")]
		public static implicit operator JSONNode(float n)
		{
			return null;
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x1C193D0", Offset = "0x1C193D0", VA = "0x1C193D0")]
		public static implicit operator float(JSONNode d)
		{
			return default(float);
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x1C2BE94", Offset = "0x1C2BE94", VA = "0x1C2BE94")]
		public static implicit operator JSONNode(int n)
		{
			return null;
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x1C177CC", Offset = "0x1C177CC", VA = "0x1C177CC")]
		public static implicit operator int(JSONNode d)
		{
			return default(int);
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x1C2BEF4", Offset = "0x1C2BEF4", VA = "0x1C2BEF4")]
		public static implicit operator JSONNode(long n)
		{
			return null;
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x1C2BFE0", Offset = "0x1C2BFE0", VA = "0x1C2BFE0")]
		public static implicit operator long(JSONNode d)
		{
			return default(long);
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x1C2C074", Offset = "0x1C2C074", VA = "0x1C2C074")]
		public static implicit operator JSONNode(ulong n)
		{
			return null;
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x1C2C160", Offset = "0x1C2C160", VA = "0x1C2C160")]
		public static implicit operator ulong(JSONNode d)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x1C2C1F4", Offset = "0x1C2C1F4", VA = "0x1C2C1F4")]
		public static implicit operator JSONNode(bool b)
		{
			return null;
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x1C19464", Offset = "0x1C19464", VA = "0x1C19464")]
		public static implicit operator bool(JSONNode d)
		{
			return default(bool);
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x1C2C250", Offset = "0x1C2C250", VA = "0x1C2C250")]
		public static implicit operator JSONNode(KeyValuePair<string, JSONNode> aKeyValue)
		{
			return null;
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x1C29548", Offset = "0x1C29548", VA = "0x1C29548")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x1C29D8C", Offset = "0x1C29D8C", VA = "0x1C29D8C")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x1C2C290", Offset = "0x1C2C290", VA = "0x1C2C290", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x1C2C29C", Offset = "0x1C2C29C", VA = "0x1C2C29C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x1C2C384", Offset = "0x1C2C384", VA = "0x1C2C384")]
		internal static string Escape(string aText)
		{
			return null;
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x1C2C68C", Offset = "0x1C2C68C", VA = "0x1C2C68C")]
		private static JSONNode ParseElement(string token, bool quoted)
		{
			return null;
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x1C289C8", Offset = "0x1C289C8", VA = "0x1C289C8")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		[Token(Token = "0x6000761")]
		public abstract void SerializeBinary(BinaryWriter aWriter);

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x1C2C8E8", Offset = "0x1C2C8E8", VA = "0x1C2C8E8")]
		public void SaveToBinaryStream(Stream aData)
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x1C2C964", Offset = "0x1C2C964", VA = "0x1C2C964")]
		public void SaveToCompressedStream(Stream aData)
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x1C2C9B8", Offset = "0x1C2C9B8", VA = "0x1C2C9B8")]
		public void SaveToCompressedFile(string aFileName)
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x1C2CA0C", Offset = "0x1C2CA0C", VA = "0x1C2CA0C")]
		public string SaveToCompressedBase64()
		{
			return null;
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x1C2CA60", Offset = "0x1C2CA60", VA = "0x1C2CA60")]
		public void SaveToBinaryFile(string aFileName)
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x1C2CBF0", Offset = "0x1C2CBF0", VA = "0x1C2CBF0")]
		public string SaveToBinaryBase64()
		{
			return null;
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x1C2CDC4", Offset = "0x1C2CDC4", VA = "0x1C2CDC4")]
		public static JSONNode DeserializeBinary(BinaryReader aReader)
		{
			return null;
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x1C2D168", Offset = "0x1C2D168", VA = "0x1C2D168")]
		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x1C2D1BC", Offset = "0x1C2D1BC", VA = "0x1C2D1BC")]
		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x1C2D210", Offset = "0x1C2D210", VA = "0x1C2D210")]
		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x1C2D264", Offset = "0x1C2D264", VA = "0x1C2D264")]
		public static JSONNode LoadFromBinaryStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x1C2D3F4", Offset = "0x1C2D3F4", VA = "0x1C2D3F4")]
		public static JSONNode LoadFromBinaryFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x1C2D56C", Offset = "0x1C2D56C", VA = "0x1C2D56C")]
		public static JSONNode LoadFromBinaryBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x1C2D744", Offset = "0x1C2D744", VA = "0x1C2D744")]
		public static implicit operator JSONNode(decimal aDecimal)
		{
			return null;
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x1C2D7C0", Offset = "0x1C2D7C0", VA = "0x1C2D7C0")]
		public static implicit operator decimal(JSONNode aNode)
		{
			return default(decimal);
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x1C2D928", Offset = "0x1C2D928", VA = "0x1C2D928")]
		public static implicit operator JSONNode(char aChar)
		{
			return null;
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x1C2D9A4", Offset = "0x1C2D9A4", VA = "0x1C2D9A4")]
		public static implicit operator char(JSONNode aNode)
		{
			return default(char);
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x1C2DA0C", Offset = "0x1C2DA0C", VA = "0x1C2DA0C")]
		public static implicit operator JSONNode(uint aUInt)
		{
			return null;
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x1C2DA6C", Offset = "0x1C2DA6C", VA = "0x1C2DA6C")]
		public static implicit operator uint(JSONNode aNode)
		{
			return default(uint);
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x1C2DAC0", Offset = "0x1C2DAC0", VA = "0x1C2DAC0")]
		public static implicit operator JSONNode(byte aByte)
		{
			return null;
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x1C2DB24", Offset = "0x1C2DB24", VA = "0x1C2DB24")]
		public static implicit operator byte(JSONNode aNode)
		{
			return default(byte);
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x1C2DB78", Offset = "0x1C2DB78", VA = "0x1C2DB78")]
		public static implicit operator JSONNode(sbyte aSByte)
		{
			return null;
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x1C2DBDC", Offset = "0x1C2DBDC", VA = "0x1C2DBDC")]
		public static implicit operator sbyte(JSONNode aNode)
		{
			return default(sbyte);
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x1C2DC30", Offset = "0x1C2DC30", VA = "0x1C2DC30")]
		public static implicit operator JSONNode(short aShort)
		{
			return null;
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x1C2DC94", Offset = "0x1C2DC94", VA = "0x1C2DC94")]
		public static implicit operator short(JSONNode aNode)
		{
			return default(short);
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x1C2DCE8", Offset = "0x1C2DCE8", VA = "0x1C2DCE8")]
		public static implicit operator JSONNode(ushort aUShort)
		{
			return null;
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x1C2DD4C", Offset = "0x1C2DD4C", VA = "0x1C2DD4C")]
		public static implicit operator ushort(JSONNode aNode)
		{
			return default(ushort);
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x1C2DEEC", Offset = "0x1C2DEEC", VA = "0x1C2DEEC")]
		public static implicit operator JSONNode(DateTime aDateTime)
		{
			return null;
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x1C2DFA0", Offset = "0x1C2DFA0", VA = "0x1C2DFA0")]
		public static implicit operator DateTime(JSONNode aNode)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x1C2E0E4", Offset = "0x1C2E0E4", VA = "0x1C2E0E4")]
		public static implicit operator JSONNode(TimeSpan aTimeSpan)
		{
			return null;
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x1C2E160", Offset = "0x1C2E160", VA = "0x1C2E160")]
		public static implicit operator TimeSpan(JSONNode aNode)
		{
			return default(TimeSpan);
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x1C2E25C", Offset = "0x1C2E25C", VA = "0x1C2E25C")]
		public static implicit operator JSONNode(Guid aGuid)
		{
			return null;
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x1C2E2D8", Offset = "0x1C2E2D8", VA = "0x1C2E2D8")]
		public static implicit operator Guid(JSONNode aNode)
		{
			return default(Guid);
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x1C2E51C", Offset = "0x1C2E51C", VA = "0x1C2E51C")]
		public static implicit operator JSONNode(byte[] aByteArray)
		{
			return null;
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x1C2E594", Offset = "0x1C2E594", VA = "0x1C2E594")]
		public static implicit operator byte[](JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x1C2E808", Offset = "0x1C2E808", VA = "0x1C2E808")]
		public static implicit operator JSONNode(List<byte> aByteList)
		{
			return null;
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x1C2E880", Offset = "0x1C2E880", VA = "0x1C2E880")]
		public static implicit operator List<byte>(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x1C2EB04", Offset = "0x1C2EB04", VA = "0x1C2EB04")]
		public static implicit operator JSONNode(string[] aStringArray)
		{
			return null;
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x1C2EB7C", Offset = "0x1C2EB7C", VA = "0x1C2EB7C")]
		public static implicit operator string[](JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x1C2EDEC", Offset = "0x1C2EDEC", VA = "0x1C2EDEC")]
		public static implicit operator JSONNode(List<string> aStringList)
		{
			return null;
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x1C2EE64", Offset = "0x1C2EE64", VA = "0x1C2EE64")]
		public static implicit operator List<string>(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x1C2EE84", Offset = "0x1C2EE84", VA = "0x1C2EE84")]
		public static implicit operator JSONNode(int? aValue)
		{
			return null;
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x1C2EF68", Offset = "0x1C2EF68", VA = "0x1C2EF68")]
		public static implicit operator int?(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x1C2F048", Offset = "0x1C2F048", VA = "0x1C2F048")]
		public static implicit operator JSONNode(float? aValue)
		{
			return null;
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x1C2F128", Offset = "0x1C2F128", VA = "0x1C2F128")]
		public static implicit operator float?(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x1C2F204", Offset = "0x1C2F204", VA = "0x1C2F204")]
		public static implicit operator JSONNode(double? aValue)
		{
			return null;
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x1C2F2EC", Offset = "0x1C2F2EC", VA = "0x1C2F2EC")]
		public static implicit operator double?(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x1C2F3C4", Offset = "0x1C2F3C4", VA = "0x1C2F3C4")]
		public static implicit operator JSONNode(bool? aValue)
		{
			return null;
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x1C2F4A8", Offset = "0x1C2F4A8", VA = "0x1C2F4A8")]
		public static implicit operator bool?(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x1C2F588", Offset = "0x1C2F588", VA = "0x1C2F588")]
		public static implicit operator JSONNode(long? aValue)
		{
			return null;
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x1C2F66C", Offset = "0x1C2F66C", VA = "0x1C2F66C")]
		public static implicit operator long?(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x1C2F748", Offset = "0x1C2F748", VA = "0x1C2F748")]
		public static implicit operator JSONNode(short? aValue)
		{
			return null;
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x1C2F82C", Offset = "0x1C2F82C", VA = "0x1C2F82C")]
		public static implicit operator short?(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x1C2F90C", Offset = "0x1C2F90C", VA = "0x1C2F90C")]
		private static JSONNode GetContainer(JSONContainerType aType)
		{
			return null;
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x1C2F994", Offset = "0x1C2F994", VA = "0x1C2F994")]
		public static implicit operator JSONNode(UnityEngine.Vector2 aVec)
		{
			return null;
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x1C2FB88", Offset = "0x1C2FB88", VA = "0x1C2FB88")]
		public static implicit operator JSONNode(UnityEngine.Vector3 aVec)
		{
			return null;
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x1C2FE0C", Offset = "0x1C2FE0C", VA = "0x1C2FE0C")]
		public static implicit operator JSONNode(UnityEngine.Vector4 aVec)
		{
			return null;
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x1C30100", Offset = "0x1C30100", VA = "0x1C30100")]
		public static implicit operator JSONNode(Color aCol)
		{
			return null;
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x1C303F4", Offset = "0x1C303F4", VA = "0x1C303F4")]
		public static implicit operator JSONNode(Color32 aCol)
		{
			return null;
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x1C306AC", Offset = "0x1C306AC", VA = "0x1C306AC")]
		public static implicit operator JSONNode(UnityEngine.Quaternion aRot)
		{
			return null;
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x1C309A0", Offset = "0x1C309A0", VA = "0x1C309A0")]
		public static implicit operator JSONNode(Rect aRect)
		{
			return null;
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x1C30CF0", Offset = "0x1C30CF0", VA = "0x1C30CF0")]
		public static implicit operator JSONNode(RectOffset aRect)
		{
			return null;
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x1C31038", Offset = "0x1C31038", VA = "0x1C31038")]
		public static implicit operator UnityEngine.Vector2(JSONNode aNode)
		{
			return default(UnityEngine.Vector2);
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x1C31090", Offset = "0x1C31090", VA = "0x1C31090")]
		public static implicit operator UnityEngine.Vector3(JSONNode aNode)
		{
			return default(UnityEngine.Vector3);
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x1C310E8", Offset = "0x1C310E8", VA = "0x1C310E8")]
		public static implicit operator UnityEngine.Vector4(JSONNode aNode)
		{
			return default(UnityEngine.Vector4);
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x1C31124", Offset = "0x1C31124", VA = "0x1C31124")]
		public static implicit operator Color(JSONNode aNode)
		{
			return default(Color);
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x1C31160", Offset = "0x1C31160", VA = "0x1C31160")]
		public static implicit operator Color32(JSONNode aNode)
		{
			return default(Color32);
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x1C311A0", Offset = "0x1C311A0", VA = "0x1C311A0")]
		public static implicit operator UnityEngine.Quaternion(JSONNode aNode)
		{
			return default(UnityEngine.Quaternion);
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x1C311DC", Offset = "0x1C311DC", VA = "0x1C311DC")]
		public static implicit operator Rect(JSONNode aNode)
		{
			return default(Rect);
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x1C31214", Offset = "0x1C31214", VA = "0x1C31214")]
		public static implicit operator RectOffset(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x1C31288", Offset = "0x1C31288", VA = "0x1C31288")]
		public UnityEngine.Vector2 ReadVector2(UnityEngine.Vector2 aDefault)
		{
			return default(UnityEngine.Vector2);
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x1C313CC", Offset = "0x1C313CC", VA = "0x1C313CC")]
		public UnityEngine.Vector2 ReadVector2(string aXName, string aYName)
		{
			return default(UnityEngine.Vector2);
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x1C31068", Offset = "0x1C31068", VA = "0x1C31068")]
		public UnityEngine.Vector2 ReadVector2()
		{
			return default(UnityEngine.Vector2);
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x1C2FA4C", Offset = "0x1C2FA4C", VA = "0x1C2FA4C")]
		public JSONNode WriteVector2(UnityEngine.Vector2 aVec, string aXName = "x", string aYName = "y")
		{
			return null;
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x1C31488", Offset = "0x1C31488", VA = "0x1C31488")]
		public UnityEngine.Vector3 ReadVector3(UnityEngine.Vector3 aDefault)
		{
			return default(UnityEngine.Vector3);
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x1C31648", Offset = "0x1C31648", VA = "0x1C31648")]
		public UnityEngine.Vector3 ReadVector3(string aXName, string aYName, string aZName)
		{
			return default(UnityEngine.Vector3);
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x1C310C0", Offset = "0x1C310C0", VA = "0x1C310C0")]
		public UnityEngine.Vector3 ReadVector3()
		{
			return default(UnityEngine.Vector3);
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x1C2FC68", Offset = "0x1C2FC68", VA = "0x1C2FC68")]
		public JSONNode WriteVector3(UnityEngine.Vector3 aVec, string aXName = "x", string aYName = "y", string aZName = "z")
		{
			return null;
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x1C3173C", Offset = "0x1C3173C", VA = "0x1C3173C")]
		public UnityEngine.Vector4 ReadVector4(UnityEngine.Vector4 aDefault)
		{
			return default(UnityEngine.Vector4);
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x1C310FC", Offset = "0x1C310FC", VA = "0x1C310FC")]
		public UnityEngine.Vector4 ReadVector4()
		{
			return default(UnityEngine.Vector4);
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x1C2FEAC", Offset = "0x1C2FEAC", VA = "0x1C2FEAC")]
		public JSONNode WriteVector4(UnityEngine.Vector4 aVec)
		{
			return null;
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x1C31998", Offset = "0x1C31998", VA = "0x1C31998")]
		public Color ReadColor(Color aDefault)
		{
			return default(Color);
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x1C31138", Offset = "0x1C31138", VA = "0x1C31138")]
		public Color ReadColor()
		{
			return default(Color);
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x1C301A0", Offset = "0x1C301A0", VA = "0x1C301A0")]
		public JSONNode WriteColor(Color aCol)
		{
			return null;
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x1C31C64", Offset = "0x1C31C64", VA = "0x1C31C64")]
		public Color32 ReadColor32(Color32 aDefault)
		{
			return default(Color32);
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x1C31184", Offset = "0x1C31184", VA = "0x1C31184")]
		public Color32 ReadColor32()
		{
			return default(Color32);
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x1C3046C", Offset = "0x1C3046C", VA = "0x1C3046C")]
		public JSONNode WriteColor32(Color32 aCol)
		{
			return null;
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x1C31F14", Offset = "0x1C31F14", VA = "0x1C31F14")]
		public UnityEngine.Quaternion ReadQuaternion(UnityEngine.Quaternion aDefault)
		{
			return default(UnityEngine.Quaternion);
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x1C311B4", Offset = "0x1C311B4", VA = "0x1C311B4")]
		public UnityEngine.Quaternion ReadQuaternion()
		{
			return default(UnityEngine.Quaternion);
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x1C3074C", Offset = "0x1C3074C", VA = "0x1C3074C")]
		public JSONNode WriteQuaternion(UnityEngine.Quaternion aRot)
		{
			return null;
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x1C32170", Offset = "0x1C32170", VA = "0x1C32170")]
		public Rect ReadRect(Rect aDefault)
		{
			return default(Rect);
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x1C31200", Offset = "0x1C31200", VA = "0x1C31200")]
		public Rect ReadRect()
		{
			return default(Rect);
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x1C30A40", Offset = "0x1C30A40", VA = "0x1C30A40")]
		public JSONNode WriteRect(Rect aRect)
		{
			return null;
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x1C323CC", Offset = "0x1C323CC", VA = "0x1C323CC")]
		public RectOffset ReadRectOffset(RectOffset aDefault)
		{
			return null;
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x1C31228", Offset = "0x1C31228", VA = "0x1C31228")]
		public RectOffset ReadRectOffset()
		{
			return null;
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x1C30D68", Offset = "0x1C30D68", VA = "0x1C30D68")]
		public JSONNode WriteRectOffset(RectOffset aRect)
		{
			return null;
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x1C32668", Offset = "0x1C32668", VA = "0x1C32668")]
		public UnityEngine.Matrix4x4 ReadMatrix()
		{
			return default(UnityEngine.Matrix4x4);
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x1C32734", Offset = "0x1C32734", VA = "0x1C32734")]
		public JSONNode WriteMatrix(UnityEngine.Matrix4x4 aMatrix)
		{
			return null;
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x1C2A0E8", Offset = "0x1C2A0E8", VA = "0x1C2A0E8")]
		protected JSONNode()
		{
		}
	}
	[Token(Token = "0x200013B")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x75E0F4", Offset = "0x75E0F4")]
	public class JSONArray : JSONNode
	{
		[Token(Token = "0x200013C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E12C", Offset = "0x75E12C")]
		private sealed class <get_Children>d__24 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONArray <>4__this;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x1700017D")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000824")]
				[Address(RVA = "0x1C0E294", Offset = "0x1C0E294", VA = "0x1C0E294", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700017E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000826")]
				[Address(RVA = "0x1C0E2DC", Offset = "0x1C0E2DC", VA = "0x1C0E2DC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000820")]
			[Address(RVA = "0x1C0E060", Offset = "0x1C0E060", VA = "0x1C0E060")]
			[DebuggerHidden]
			public <get_Children>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x6000821")]
			[Address(RVA = "0x1C0E098", Offset = "0x1C0E098", VA = "0x1C0E098", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000822")]
			[Address(RVA = "0x1C0E108", Offset = "0x1C0E108", VA = "0x1C0E108", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000823")]
			[Address(RVA = "0x1C0E0B4", Offset = "0x1C0E0B4", VA = "0x1C0E0B4")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000825")]
			[Address(RVA = "0x1C0E29C", Offset = "0x1C0E29C", VA = "0x1C0E29C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000827")]
			[Address(RVA = "0x1C0E2E4", Offset = "0x1C0E2E4", VA = "0x1C0E2E4", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000828")]
			[Address(RVA = "0x1C0E394", Offset = "0x1C0E394", VA = "0x1C0E394", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<JSONNode> m_List;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inline;

		[Token(Token = "0x17000176")]
		public override bool Inline
		{
			[Token(Token = "0x600080D")]
			[Address(RVA = "0x1C29220", Offset = "0x1C29220", VA = "0x1C29220", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600080E")]
			[Address(RVA = "0x1C29228", Offset = "0x1C29228", VA = "0x1C29228", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000177")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x600080F")]
			[Address(RVA = "0x1C29234", Offset = "0x1C29234", VA = "0x1C29234", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000178")]
		public override bool IsArray
		{
			[Token(Token = "0x6000810")]
			[Address(RVA = "0x1C2923C", Offset = "0x1C2923C", VA = "0x1C2923C", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000179")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000812")]
			[Address(RVA = "0x1C292D4", Offset = "0x1C292D4", VA = "0x1C292D4", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000813")]
			[Address(RVA = "0x1C2941C", Offset = "0x1C2941C", VA = "0x1C2941C", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x1700017A")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000814")]
			[Address(RVA = "0x1C296E0", Offset = "0x1C296E0", VA = "0x1C296E0", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000815")]
			[Address(RVA = "0x1C2973C", Offset = "0x1C2973C", VA = "0x1C2973C", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700017B")]
		public override int Count
		{
			[Token(Token = "0x6000816")]
			[Address(RVA = "0x1C29814", Offset = "0x1C29814", VA = "0x1C29814", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700017C")]
		public override IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x600081C")]
			[Address(RVA = "0x1C29E08", Offset = "0x1C29E08", VA = "0x1C29E08", Slot = "27")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x76424C", Offset = "0x76424C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x1C29244", Offset = "0x1C29244", VA = "0x1C29244", Slot = "32")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x1C29860", Offset = "0x1C29860", VA = "0x1C29860", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x1C29938", Offset = "0x1C29938", VA = "0x1C29938", Slot = "23")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x1C299F8", Offset = "0x1C299F8", VA = "0x1C299F8", Slot = "24")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x1C29A64", Offset = "0x1C29A64", VA = "0x1C29A64", Slot = "25")]
		public override void Clear()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x1C29AB8", Offset = "0x1C29AB8", VA = "0x1C29AB8", Slot = "26")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x1C29E80", Offset = "0x1C29E80", VA = "0x1C29E80", Slot = "31")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x1C2A000", Offset = "0x1C2A000", VA = "0x1C2A000", Slot = "47")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x1C29CDC", Offset = "0x1C29CDC", VA = "0x1C29CDC")]
		public JSONArray()
		{
		}
	}
	[Token(Token = "0x200013D")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x75E13C", Offset = "0x75E13C")]
	public class JSONObject : JSONNode
	{
		[Token(Token = "0x200013E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E174", Offset = "0x75E174")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public JSONNode aNode;

			[Token(Token = "0x600083F")]
			[Address(RVA = "0x1C0F4B0", Offset = "0x1C0F4B0", VA = "0x1C0F4B0")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6000840")]
			[Address(RVA = "0x1C0F4B8", Offset = "0x1C0F4B8", VA = "0x1C0F4B8")]
			internal bool <Remove>b__0(KeyValuePair<string, JSONNode> k)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200013F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E184", Offset = "0x75E184")]
		private sealed class <get_Children>d__27 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONObject <>4__this;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x17000186")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000845")]
				[Address(RVA = "0x1C0F784", Offset = "0x1C0F784", VA = "0x1C0F784", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000187")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000847")]
				[Address(RVA = "0x1C0F7CC", Offset = "0x1C0F7CC", VA = "0x1C0F7CC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000841")]
			[Address(RVA = "0x1C0F53C", Offset = "0x1C0F53C", VA = "0x1C0F53C")]
			[DebuggerHidden]
			public <get_Children>d__27(int <>1__state)
			{
			}

			[Token(Token = "0x6000842")]
			[Address(RVA = "0x1C0F574", Offset = "0x1C0F574", VA = "0x1C0F574", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000843")]
			[Address(RVA = "0x1C0F5E4", Offset = "0x1C0F5E4", VA = "0x1C0F5E4", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000844")]
			[Address(RVA = "0x1C0F590", Offset = "0x1C0F590", VA = "0x1C0F590")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000846")]
			[Address(RVA = "0x1C0F78C", Offset = "0x1C0F78C", VA = "0x1C0F78C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000848")]
			[Address(RVA = "0x1C0F7D4", Offset = "0x1C0F7D4", VA = "0x1C0F7D4", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000849")]
			[Address(RVA = "0x1C0F884", Offset = "0x1C0F884", VA = "0x1C0F884", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, JSONNode> m_Dict;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inline;

		[Token(Token = "0x1700017F")]
		public override bool Inline
		{
			[Token(Token = "0x6000829")]
			[Address(RVA = "0xB099E8", Offset = "0xB099E8", VA = "0xB099E8", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600082A")]
			[Address(RVA = "0xB099F0", Offset = "0xB099F0", VA = "0xB099F0", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000180")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x600082B")]
			[Address(RVA = "0xB099FC", Offset = "0xB099FC", VA = "0xB099FC", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000181")]
		public override bool IsObject
		{
			[Token(Token = "0x600082C")]
			[Address(RVA = "0xB09A04", Offset = "0xB09A04", VA = "0xB09A04", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000182")]
		public override JSONNode Item
		{
			[Token(Token = "0x600082E")]
			[Address(RVA = "0xB09A9C", Offset = "0xB09A9C", VA = "0xB09A9C", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600082F")]
			[Address(RVA = "0xB09B70", Offset = "0xB09B70", VA = "0xB09B70", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000183")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000830")]
			[Address(RVA = "0xB09CB4", Offset = "0xB09CB4", VA = "0xB09CB4", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000831")]
			[Address(RVA = "0xB09D60", Offset = "0xB09D60", VA = "0xB09D60", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000184")]
		public override int Count
		{
			[Token(Token = "0x6000832")]
			[Address(RVA = "0xB09EB8", Offset = "0xB09EB8", VA = "0xB09EB8", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000185")]
		public override IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x600083B")]
			[Address(RVA = "0xB0A7E8", Offset = "0xB0A7E8", VA = "0xB0A7E8", Slot = "27")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x76431C", Offset = "0x76431C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0xB09A0C", Offset = "0xB09A0C", VA = "0xB09A0C", Slot = "32")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xB09F0C", Offset = "0xB09F0C", VA = "0xB09F0C", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0xB0A0C0", Offset = "0xB0A0C0", VA = "0xB0A0C0", Slot = "22")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0xB0A190", Offset = "0xB0A190", VA = "0xB0A190", Slot = "23")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xB0A278", Offset = "0xB0A278", VA = "0xB0A278", Slot = "24")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xB0A45C", Offset = "0xB0A45C", VA = "0xB0A45C", Slot = "25")]
		public override void Clear()
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xB0A4B0", Offset = "0xB0A4B0", VA = "0xB0A4B0", Slot = "26")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xB0A6FC", Offset = "0xB0A6FC", VA = "0xB0A6FC", Slot = "28")]
		public override bool HasKey(string aKey)
		{
			return default(bool);
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xB0A760", Offset = "0xB0A760", VA = "0xB0A760", Slot = "29")]
		public override JSONNode GetValueOrDefault(string aKey, JSONNode aDefault)
		{
			return null;
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xB0A860", Offset = "0xB0A860", VA = "0xB0A860", Slot = "31")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xB0AB84", Offset = "0xB0AB84", VA = "0xB0AB84", Slot = "47")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0xB0A64C", Offset = "0xB0A64C", VA = "0xB0A64C")]
		public JSONObject()
		{
		}
	}
	[Token(Token = "0x2000140")]
	public class JSONString : JSONNode
	{
		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_Data;

		[Token(Token = "0x17000188")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x600084A")]
			[Address(RVA = "0xB0AD80", Offset = "0xB0AD80", VA = "0xB0AD80", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000189")]
		public override bool IsString
		{
			[Token(Token = "0x600084B")]
			[Address(RVA = "0xB0AD88", Offset = "0xB0AD88", VA = "0xB0AD88", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700018A")]
		public override string Value
		{
			[Token(Token = "0x600084D")]
			[Address(RVA = "0xB0ADB0", Offset = "0xB0ADB0", VA = "0xB0ADB0", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600084E")]
			[Address(RVA = "0xB0ADB8", Offset = "0xB0ADB8", VA = "0xB0ADB8", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0xB0AD90", Offset = "0xB0AD90", VA = "0xB0AD90", Slot = "32")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xB0ADC0", Offset = "0xB0ADC0", VA = "0xB0ADC0")]
		public JSONString(string aData)
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0xB0AE40", Offset = "0xB0AE40", VA = "0xB0AE40", Slot = "26")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0xB0AEA0", Offset = "0xB0AEA0", VA = "0xB0AEA0", Slot = "31")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xB0AF58", Offset = "0xB0AF58", VA = "0xB0AF58", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xB0B090", Offset = "0xB0B090", VA = "0xB0B090", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xB0B0B0", Offset = "0xB0B0B0", VA = "0xB0B0B0", Slot = "25")]
		public override void Clear()
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xB0B100", Offset = "0xB0B100", VA = "0xB0B100", Slot = "47")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x2000141")]
	public class JSONNumber : JSONNode
	{
		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private double m_Data;

		[Token(Token = "0x1700018B")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x6000856")]
			[Address(RVA = "0xB0931C", Offset = "0xB0931C", VA = "0xB0931C", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x1700018C")]
		public override bool IsNumber
		{
			[Token(Token = "0x6000857")]
			[Address(RVA = "0xB09324", Offset = "0xB09324", VA = "0xB09324", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700018D")]
		public override string Value
		{
			[Token(Token = "0x6000859")]
			[Address(RVA = "0xB0934C", Offset = "0xB0934C", VA = "0xB0934C", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600085A")]
			[Address(RVA = "0xB093C0", Offset = "0xB093C0", VA = "0xB093C0", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x1700018E")]
		public override double AsDouble
		{
			[Token(Token = "0x600085B")]
			[Address(RVA = "0xB0948C", Offset = "0xB0948C", VA = "0xB0948C", Slot = "33")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x600085C")]
			[Address(RVA = "0xB09494", Offset = "0xB09494", VA = "0xB09494", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x1700018F")]
		public override long AsLong
		{
			[Token(Token = "0x600085D")]
			[Address(RVA = "0xB0949C", Offset = "0xB0949C", VA = "0xB0949C", Slot = "41")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600085E")]
			[Address(RVA = "0xB094BC", Offset = "0xB094BC", VA = "0xB094BC", Slot = "42")]
			set
			{
			}
		}

		[Token(Token = "0x17000190")]
		public override ulong AsULong
		{
			[Token(Token = "0x600085F")]
			[Address(RVA = "0xB094C8", Offset = "0xB094C8", VA = "0xB094C8", Slot = "43")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x6000860")]
			[Address(RVA = "0xB094E0", Offset = "0xB094E0", VA = "0xB094E0", Slot = "44")]
			set
			{
			}
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xB0932C", Offset = "0xB0932C", VA = "0xB0932C", Slot = "32")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xB094EC", Offset = "0xB094EC", VA = "0xB094EC")]
		public JSONNumber(double aData)
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0xB09564", Offset = "0xB09564", VA = "0xB09564")]
		public JSONNumber(string aData)
		{
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0xB095E8", Offset = "0xB095E8", VA = "0xB095E8", Slot = "26")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0xB09650", Offset = "0xB09650", VA = "0xB09650", Slot = "31")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0xB09690", Offset = "0xB09690", VA = "0xB09690")]
		private static bool IsNumeric(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xB09834", Offset = "0xB09834", VA = "0xB09834", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0xB09984", Offset = "0xB09984", VA = "0xB09984", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0xB09990", Offset = "0xB09990", VA = "0xB09990", Slot = "25")]
		public override void Clear()
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0xB09998", Offset = "0xB09998", VA = "0xB09998", Slot = "47")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x2000142")]
	public class JSONBool : JSONNode
	{
		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool m_Data;

		[Token(Token = "0x17000191")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x600086A")]
			[Address(RVA = "0x1C2A0F0", Offset = "0x1C2A0F0", VA = "0x1C2A0F0", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000192")]
		public override bool IsBoolean
		{
			[Token(Token = "0x600086B")]
			[Address(RVA = "0x1C2A0F8", Offset = "0x1C2A0F8", VA = "0x1C2A0F8", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000193")]
		public override string Value
		{
			[Token(Token = "0x600086D")]
			[Address(RVA = "0x1C2A120", Offset = "0x1C2A120", VA = "0x1C2A120", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600086E")]
			[Address(RVA = "0x1C2A12C", Offset = "0x1C2A12C", VA = "0x1C2A12C", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000194")]
		public override bool AsBool
		{
			[Token(Token = "0x600086F")]
			[Address(RVA = "0x1C2A1B4", Offset = "0x1C2A1B4", VA = "0x1C2A1B4", Slot = "39")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000870")]
			[Address(RVA = "0x1C2A1BC", Offset = "0x1C2A1BC", VA = "0x1C2A1BC", Slot = "40")]
			set
			{
			}
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x1C2A100", Offset = "0x1C2A100", VA = "0x1C2A100", Slot = "32")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x1C2A1C8", Offset = "0x1C2A1C8", VA = "0x1C2A1C8")]
		public JSONBool(bool aData)
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x1C2A244", Offset = "0x1C2A244", VA = "0x1C2A244")]
		public JSONBool(string aData)
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x1C2A2C8", Offset = "0x1C2A2C8", VA = "0x1C2A2C8", Slot = "26")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x1C2A328", Offset = "0x1C2A328", VA = "0x1C2A328", Slot = "31")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x1C2A3AC", Offset = "0x1C2A3AC", VA = "0x1C2A3AC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x1C2A430", Offset = "0x1C2A430", VA = "0x1C2A430", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x1C2A43C", Offset = "0x1C2A43C", VA = "0x1C2A43C", Slot = "25")]
		public override void Clear()
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x1C2A444", Offset = "0x1C2A444", VA = "0x1C2A444", Slot = "47")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x2000143")]
	public class JSONNull : JSONNode
	{
		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static JSONNull m_StaticInstance;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static bool reuseSameInstance;

		[Token(Token = "0x17000195")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x600087B")]
			[Address(RVA = "0xB090B0", Offset = "0xB090B0", VA = "0xB090B0", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000196")]
		public override bool IsNull
		{
			[Token(Token = "0x600087C")]
			[Address(RVA = "0xB090B8", Offset = "0xB090B8", VA = "0xB090B8", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000197")]
		public override string Value
		{
			[Token(Token = "0x600087E")]
			[Address(RVA = "0xB090E0", Offset = "0xB090E0", VA = "0xB090E0", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600087F")]
			[Address(RVA = "0xB09124", Offset = "0xB09124", VA = "0xB09124", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000198")]
		public override bool AsBool
		{
			[Token(Token = "0x6000880")]
			[Address(RVA = "0xB09128", Offset = "0xB09128", VA = "0xB09128", Slot = "39")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000881")]
			[Address(RVA = "0xB09130", Offset = "0xB09130", VA = "0xB09130", Slot = "40")]
			set
			{
			}
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0xB08FB0", Offset = "0xB08FB0", VA = "0xB08FB0")]
		public static JSONNull CreateOrGet()
		{
			return null;
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0xB0904C", Offset = "0xB0904C", VA = "0xB0904C")]
		private JSONNull()
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0xB090C0", Offset = "0xB090C0", VA = "0xB090C0", Slot = "32")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0xB09134", Offset = "0xB09134", VA = "0xB09134", Slot = "26")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0xB0918C", Offset = "0xB0918C", VA = "0xB0918C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0xB09224", Offset = "0xB09224", VA = "0xB09224", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0xB0922C", Offset = "0xB0922C", VA = "0xB0922C", Slot = "31")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0xB09284", Offset = "0xB09284", VA = "0xB09284", Slot = "47")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x2000144")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x75E194", Offset = "0x75E194")]
	internal class JSONLazyCreator : JSONNode
	{
		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private JSONNode m_Node;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_Key;

		[Token(Token = "0x17000199")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x6000888")]
			[Address(RVA = "0x1C2A490", Offset = "0x1C2A490", VA = "0x1C2A490", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x1700019A")]
		public override JSONNode Item
		{
			[Token(Token = "0x600088D")]
			[Address(RVA = "0x1C2A54C", Offset = "0x1C2A54C", VA = "0x1C2A54C", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600088E")]
			[Address(RVA = "0x1C2A5A8", Offset = "0x1C2A5A8", VA = "0x1C2A5A8", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x1700019B")]
		public override JSONNode Item
		{
			[Token(Token = "0x600088F")]
			[Address(RVA = "0x1C2A644", Offset = "0x1C2A644", VA = "0x1C2A644", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000890")]
			[Address(RVA = "0x1C2A6B0", Offset = "0x1C2A6B0", VA = "0x1C2A6B0", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700019C")]
		public override int AsInt
		{
			[Token(Token = "0x6000897")]
			[Address(RVA = "0x1C2A8EC", Offset = "0x1C2A8EC", VA = "0x1C2A8EC", Slot = "35")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000898")]
			[Address(RVA = "0x1C2A970", Offset = "0x1C2A970", VA = "0x1C2A970", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x1700019D")]
		public override float AsFloat
		{
			[Token(Token = "0x6000899")]
			[Address(RVA = "0x1C2A9F8", Offset = "0x1C2A9F8", VA = "0x1C2A9F8", Slot = "37")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600089A")]
			[Address(RVA = "0x1C2AA7C", Offset = "0x1C2AA7C", VA = "0x1C2AA7C", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x1700019E")]
		public override double AsDouble
		{
			[Token(Token = "0x600089B")]
			[Address(RVA = "0x1C2AB04", Offset = "0x1C2AB04", VA = "0x1C2AB04", Slot = "33")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x600089C")]
			[Address(RVA = "0x1C2AB88", Offset = "0x1C2AB88", VA = "0x1C2AB88", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x1700019F")]
		public override long AsLong
		{
			[Token(Token = "0x600089D")]
			[Address(RVA = "0x1C2AC10", Offset = "0x1C2AC10", VA = "0x1C2AC10", Slot = "41")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600089E")]
			[Address(RVA = "0x1C2AD28", Offset = "0x1C2AD28", VA = "0x1C2AD28", Slot = "42")]
			set
			{
			}
		}

		[Token(Token = "0x170001A0")]
		public override ulong AsULong
		{
			[Token(Token = "0x600089F")]
			[Address(RVA = "0x1C2AE64", Offset = "0x1C2AE64", VA = "0x1C2AE64", Slot = "43")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x1C2AF7C", Offset = "0x1C2AF7C", VA = "0x1C2AF7C", Slot = "44")]
			set
			{
			}
		}

		[Token(Token = "0x170001A1")]
		public override bool AsBool
		{
			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x1C2B0B8", Offset = "0x1C2B0B8", VA = "0x1C2B0B8", Slot = "39")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x1C2B138", Offset = "0x1C2B138", VA = "0x1C2B138", Slot = "40")]
			set
			{
			}
		}

		[Token(Token = "0x170001A2")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x1C2B1BC", Offset = "0x1C2B1BC", VA = "0x1C2B1BC", Slot = "45")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A3")]
		public override JSONObject AsObject
		{
			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x1C2B230", Offset = "0x1C2B230", VA = "0x1C2B230", Slot = "46")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x1C2A498", Offset = "0x1C2A498", VA = "0x1C2A498", Slot = "32")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x1C2938C", Offset = "0x1C2938C", VA = "0x1C2938C")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x1C2A4B8", Offset = "0x1C2A4B8", VA = "0x1C2A4B8")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		[Token(Token = "0x600088C")]
		private T Set<T>(T aVal) where T : JSONNode
		{
			return null;
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x1C2A758", Offset = "0x1C2A758", VA = "0x1C2A758", Slot = "21")]
		public override void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x1C2A7F4", Offset = "0x1C2A7F4", VA = "0x1C2A7F4", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x1C2A89C", Offset = "0x1C2A89C", VA = "0x1C2A89C")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x1C2A8B4", Offset = "0x1C2A8B4", VA = "0x1C2A8B4")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x1C2A8CC", Offset = "0x1C2A8CC", VA = "0x1C2A8CC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x1C2A8E4", Offset = "0x1C2A8E4", VA = "0x1C2A8E4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x1C2B2A8", Offset = "0x1C2B2A8", VA = "0x1C2B2A8", Slot = "31")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x1C2B300", Offset = "0x1C2B300", VA = "0x1C2B300", Slot = "47")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x2000145")]
	public static class JSON
	{
		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x1C28968", Offset = "0x1C28968", VA = "0x1C28968")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}
	}
	[Token(Token = "0x2000146")]
	public enum JSONContainerType
	{
		[Token(Token = "0x40005C8")]
		Array,
		[Token(Token = "0x40005C9")]
		Object
	}
}
namespace Bright.Common
{
	[Token(Token = "0x2000147")]
	public static class StringUtil
	{
		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x9E1694", Offset = "0x9E1694", VA = "0x9E1694")]
		public static string ToStr(object o)
		{
			return null;
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x9E16F4", Offset = "0x9E16F4", VA = "0x9E16F4")]
		public static string ToStr(object o, StringBuilder sb)
		{
			return null;
		}

		[Token(Token = "0x60008AA")]
		public static string ArrayToString<T>(T[] arr)
		{
			return null;
		}

		[Token(Token = "0x60008AB")]
		public static string CollectionToString<T>(IEnumerable<T> arr)
		{
			return null;
		}

		[Token(Token = "0x60008AC")]
		public static string CollectionToString<TK, TV>(IDictionary<TK, TV> dic)
		{
			return null;
		}
	}
}
namespace Bright.Serialization
{
	[Token(Token = "0x2000148")]
	public enum EDeserializeError
	{
		[Token(Token = "0x40005CB")]
		OK,
		[Token(Token = "0x40005CC")]
		NOT_ENOUGH,
		[Token(Token = "0x40005CD")]
		EXCEED_SIZE
	}
	[Token(Token = "0x2000149")]
	public class SerializationException : Exception
	{
		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x9DEA68", Offset = "0x9DEA68", VA = "0x9DEA68")]
		public SerializationException()
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x9DFCE4", Offset = "0x9DFCE4", VA = "0x9DFCE4")]
		public SerializationException(string msg)
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x9DFD58", Offset = "0x9DFD58", VA = "0x9DFD58")]
		public SerializationException(string message, Exception innerException)
		{
		}
	}
	[Token(Token = "0x200014A")]
	public readonly struct SegmentSaveState
	{
		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76062C", Offset = "0x76062C")]
		private readonly int <ReaderIndex>k__BackingField;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76063C", Offset = "0x76063C")]
		private readonly int <WriterIndex>k__BackingField;

		[Token(Token = "0x170001A4")]
		public int ReaderIndex
		{
			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x9DFCD4", Offset = "0x9DFCD4", VA = "0x9DFCD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7643EC", Offset = "0x7643EC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001A5")]
		public int WriterIndex
		{
			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x9DFCDC", Offset = "0x9DFCDC", VA = "0x9DFCDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7643FC", Offset = "0x7643FC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x9DFCCC", Offset = "0x9DFCCC", VA = "0x9DFCCC")]
		public SegmentSaveState(int readerIndex, int writerIndex)
		{
		}
	}
	[Token(Token = "0x200014B")]
	public sealed class ByteBuf : ICloneable, IEquatable<ByteBuf>
	{
		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76064C", Offset = "0x76064C")]
		private int <ReaderIndex>k__BackingField;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76065C", Offset = "0x76065C")]
		private int <WriterIndex>k__BackingField;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Action<ByteBuf> _releaser;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76066C", Offset = "0x76066C")]
		private byte[] <Bytes>k__BackingField;

		[Token(Token = "0x40005D4")]
		private const int MIN_CAPACITY = 16;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76067C", Offset = "0x76067C")]
		private static Func<byte[], int, int, string> <StringCacheFinder>k__BackingField;

		[Token(Token = "0x170001A6")]
		public int ReaderIndex
		{
			[Token(Token = "0x60008BB")]
			[Address(RVA = "0x1C1A468", Offset = "0x1C1A468", VA = "0x1C1A468")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76440C", Offset = "0x76440C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x1C1A470", Offset = "0x1C1A470", VA = "0x1C1A470")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76441C", Offset = "0x76441C")]
			set
			{
			}
		}

		[Token(Token = "0x170001A7")]
		public int WriterIndex
		{
			[Token(Token = "0x60008BD")]
			[Address(RVA = "0x1C1A478", Offset = "0x1C1A478", VA = "0x1C1A478")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76442C", Offset = "0x76442C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x1C1A480", Offset = "0x1C1A480", VA = "0x1C1A480")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76443C", Offset = "0x76443C")]
			set
			{
			}
		}

		[Token(Token = "0x170001A8")]
		public int Capacity
		{
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x1C1A2CC", Offset = "0x1C1A2CC", VA = "0x1C1A2CC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001A9")]
		public int Size
		{
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x1C1A488", Offset = "0x1C1A488", VA = "0x1C1A488")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001AA")]
		public bool Empty
		{
			[Token(Token = "0x60008C1")]
			[Address(RVA = "0x1C1A494", Offset = "0x1C1A494", VA = "0x1C1A494")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001AB")]
		public bool NotEmpty
		{
			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x1C1A4A4", Offset = "0x1C1A4A4", VA = "0x1C1A4A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001AC")]
		public byte[] Bytes
		{
			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x1C1A4D4", Offset = "0x1C1A4D4", VA = "0x1C1A4D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76444C", Offset = "0x76444C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x1C1A4DC", Offset = "0x1C1A4DC", VA = "0x1C1A4DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76445C", Offset = "0x76445C")]
			private set
			{
			}
		}

		[Token(Token = "0x170001AD")]
		public int Remaining
		{
			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x1C1A608", Offset = "0x1C1A608", VA = "0x1C1A608")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001AE")]
		public int NotCompactWritable
		{
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0x1C1A654", Offset = "0x1C1A654", VA = "0x1C1A654")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001AF")]
		public static Func<byte[], int, int, string> StringCacheFinder
		{
			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x1C1D1D0", Offset = "0x1C1D1D0", VA = "0x1C1D1D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76446C", Offset = "0x76446C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008FC")]
			[Address(RVA = "0x1C1D21C", Offset = "0x1C1D21C", VA = "0x1C1D21C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x76447C", Offset = "0x76447C")]
			set
			{
			}
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x1C1A05C", Offset = "0x1C1A05C", VA = "0x1C1A05C")]
		public ByteBuf()
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x1C1A148", Offset = "0x1C1A148", VA = "0x1C1A148")]
		public ByteBuf(int capacity)
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x1C1A270", Offset = "0x1C1A270", VA = "0x1C1A270")]
		public ByteBuf(byte[] bytes)
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x1C1A2E8", Offset = "0x1C1A2E8", VA = "0x1C1A2E8")]
		public ByteBuf(byte[] bytes, int readIndex, int writeIndex)
		{
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x1C1A334", Offset = "0x1C1A334", VA = "0x1C1A334")]
		public ByteBuf(int capacity, Action<ByteBuf> releaser)
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x1C1A364", Offset = "0x1C1A364", VA = "0x1C1A364")]
		public static ByteBuf Wrap(byte[] bytes)
		{
			return null;
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x1C1A3E8", Offset = "0x1C1A3E8", VA = "0x1C1A3E8")]
		public void Replace(byte[] bytes)
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x1C1A42C", Offset = "0x1C1A42C", VA = "0x1C1A42C")]
		public void Replace(byte[] bytes, int beginPos, int endPos)
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x1C1A4B4", Offset = "0x1C1A4B4", VA = "0x1C1A4B4")]
		public void AddWriteIndex(int add)
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x1C1A4C4", Offset = "0x1C1A4C4", VA = "0x1C1A4C4")]
		public void AddReadIndex(int add)
		{
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x1C1A4E4", Offset = "0x1C1A4E4", VA = "0x1C1A4E4")]
		public byte[] CopyData()
		{
			return null;
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x1C1A614", Offset = "0x1C1A614", VA = "0x1C1A614")]
		public void DiscardReadBytes()
		{
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x1C1A678", Offset = "0x1C1A678", VA = "0x1C1A678")]
		public void WriteBytesWithoutSize(byte[] bs)
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x1C1A694", Offset = "0x1C1A694", VA = "0x1C1A694")]
		public void WriteBytesWithoutSize(byte[] bs, int offset, int len)
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x1C1A718", Offset = "0x1C1A718", VA = "0x1C1A718")]
		public void Clear()
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x1C1A720", Offset = "0x1C1A720", VA = "0x1C1A720")]
		private static int PropSize(int initSize, int needSize)
		{
			return default(int);
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x1C1A7AC", Offset = "0x1C1A7AC", VA = "0x1C1A7AC")]
		private void EnsureWrite0(int size)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x1C1A8A0", Offset = "0x1C1A8A0", VA = "0x1C1A8A0")]
		public void EnsureWrite(int size)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x1C1A8D0", Offset = "0x1C1A8D0", VA = "0x1C1A8D0")]
		private void EnsureRead(int size)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x1C1A924", Offset = "0x1C1A924", VA = "0x1C1A924")]
		private bool CanRead(int size)
		{
			return default(bool);
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x1C1A938", Offset = "0x1C1A938", VA = "0x1C1A938")]
		public void Append(byte x)
		{
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x1C1A9BC", Offset = "0x1C1A9BC", VA = "0x1C1A9BC")]
		public void WriteBool(bool b)
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x1C1AA44", Offset = "0x1C1AA44", VA = "0x1C1AA44")]
		public bool ReadBool()
		{
			return default(bool);
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x1C1AADC", Offset = "0x1C1AADC", VA = "0x1C1AADC")]
		public void WriteByte(byte x)
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x1C1AB60", Offset = "0x1C1AB60", VA = "0x1C1AB60")]
		public byte ReadByte()
		{
			return default(byte);
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x1C1ABF0", Offset = "0x1C1ABF0", VA = "0x1C1ABF0")]
		public void WriteShort(short x)
		{
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x1C1ADC0", Offset = "0x1C1ADC0", VA = "0x1C1ADC0")]
		public short ReadShort()
		{
			return default(short);
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x1C1AEF8", Offset = "0x1C1AEF8", VA = "0x1C1AEF8")]
		public short ReadFshort()
		{
			return default(short);
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x1C1AFA0", Offset = "0x1C1AFA0", VA = "0x1C1AFA0")]
		public void WriteFshort(short x)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x1C1B04C", Offset = "0x1C1B04C", VA = "0x1C1B04C")]
		public void WriteInt(int x)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x1C1B3E4", Offset = "0x1C1B3E4", VA = "0x1C1B3E4")]
		public int ReadInt()
		{
			return default(int);
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x1C1B050", Offset = "0x1C1B050", VA = "0x1C1B050")]
		public void WriteUint(uint x)
		{
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x1C1B3E8", Offset = "0x1C1B3E8", VA = "0x1C1B3E8")]
		public uint ReadUint()
		{
			return default(uint);
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x1C1B5C4", Offset = "0x1C1B5C4", VA = "0x1C1B5C4")]
		public void WriteUint_Unsafe(uint x)
		{
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x1C1B7E0", Offset = "0x1C1B7E0", VA = "0x1C1B7E0")]
		public uint ReadUint_Unsafe()
		{
			return default(uint);
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x1C1B90C", Offset = "0x1C1B90C", VA = "0x1C1B90C")]
		public int ReadFint()
		{
			return default(int);
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x1C1B9E8", Offset = "0x1C1B9E8", VA = "0x1C1B9E8")]
		public void WriteFint(int x)
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x1C1BAE4", Offset = "0x1C1BAE4", VA = "0x1C1BAE4")]
		public int ReadFint_Safe()
		{
			return default(int);
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x1C1BBC0", Offset = "0x1C1BBC0", VA = "0x1C1BBC0")]
		public void WriteFint_Safe(int x)
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x1C1BCBC", Offset = "0x1C1BCBC", VA = "0x1C1BCBC")]
		public void WriteLong(long x)
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x1C1C5E4", Offset = "0x1C1C5E4", VA = "0x1C1C5E4")]
		public long ReadLong()
		{
			return default(long);
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x1C1CA88", Offset = "0x1C1CA88", VA = "0x1C1CA88")]
		public void WriteNumberAsLong(double x)
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x1C1CAA4", Offset = "0x1C1CAA4", VA = "0x1C1CAA4")]
		public double ReadLongAsNumber()
		{
			return default(double);
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x1C1BCC0", Offset = "0x1C1BCC0", VA = "0x1C1BCC0")]
		private void WriteUlong(ulong x)
		{
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x1C1C5E8", Offset = "0x1C1C5E8", VA = "0x1C1C5E8")]
		public ulong ReadUlong()
		{
			return default(ulong);
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x1C1CABC", Offset = "0x1C1CABC", VA = "0x1C1CABC")]
		public void WriteFlong(long x)
		{
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x1C1CC58", Offset = "0x1C1CC58", VA = "0x1C1CC58")]
		public long ReadFlong()
		{
			return default(long);
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x1C1CD98", Offset = "0x1C1CD98", VA = "0x1C1CD98")]
		private unsafe static void Copy8(byte* dst, byte* src)
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x1C1CDDC", Offset = "0x1C1CDDC", VA = "0x1C1CDDC")]
		private unsafe static void Copy4(byte* dst, byte* src)
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x1C1CE00", Offset = "0x1C1CE00", VA = "0x1C1CE00")]
		public void WriteFloat(float x)
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x1C1CEC8", Offset = "0x1C1CEC8", VA = "0x1C1CEC8")]
		public float ReadFloat()
		{
			return default(float);
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x1C1CF64", Offset = "0x1C1CF64", VA = "0x1C1CF64")]
		public void WriteDouble(double x)
		{
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x1C1D010", Offset = "0x1C1D010", VA = "0x1C1D010")]
		public double ReadDouble()
		{
			return default(double);
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x1C1D0AC", Offset = "0x1C1D0AC", VA = "0x1C1D0AC")]
		public void WriteSize(int n)
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x1C1D0B0", Offset = "0x1C1D0B0", VA = "0x1C1D0B0")]
		public int ReadSize()
		{
			return default(int);
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x1C1D0B4", Offset = "0x1C1D0B4", VA = "0x1C1D0B4")]
		public void WriteSint(int x)
		{
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x1C1D0BC", Offset = "0x1C1D0BC", VA = "0x1C1D0BC")]
		public int ReadSint()
		{
			return default(int);
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x1C1D0D4", Offset = "0x1C1D0D4", VA = "0x1C1D0D4")]
		public void WriteSlong(long x)
		{
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x1C1D0DC", Offset = "0x1C1D0DC", VA = "0x1C1D0DC")]
		public long ReadSlong()
		{
			return default(long);
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x1C1D0F4", Offset = "0x1C1D0F4", VA = "0x1C1D0F4")]
		public void WriteString(string x)
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x1C1D270", Offset = "0x1C1D270", VA = "0x1C1D270")]
		public string ReadString()
		{
			return null;
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x1C1D3BC", Offset = "0x1C1D3BC", VA = "0x1C1D3BC")]
		public void WriteBytes(byte[] x)
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x1C1D460", Offset = "0x1C1D460", VA = "0x1C1D460")]
		public byte[] ReadBytes()
		{
			return null;
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x1C1D5E0", Offset = "0x1C1D5E0", VA = "0x1C1D5E0")]
		public void WriteComplex(Complex x)
		{
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x1C1D614", Offset = "0x1C1D614", VA = "0x1C1D614")]
		public Complex ReadComplex()
		{
			return default(Complex);
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x1C1D66C", Offset = "0x1C1D66C", VA = "0x1C1D66C")]
		public void WriteVector2(System.Numerics.Vector2 x)
		{
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x1C1D6A0", Offset = "0x1C1D6A0", VA = "0x1C1D6A0")]
		public System.Numerics.Vector2 ReadVector2()
		{
			return default(System.Numerics.Vector2);
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x1C1D6F8", Offset = "0x1C1D6F8", VA = "0x1C1D6F8")]
		public void WriteVector3(System.Numerics.Vector3 x)
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x1C1D73C", Offset = "0x1C1D73C", VA = "0x1C1D73C")]
		public System.Numerics.Vector3 ReadVector3()
		{
			return default(System.Numerics.Vector3);
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x1C1D7AC", Offset = "0x1C1D7AC", VA = "0x1C1D7AC")]
		public void WriteVector4(System.Numerics.Vector4 x)
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x1C1D808", Offset = "0x1C1D808", VA = "0x1C1D808")]
		public System.Numerics.Vector4 ReadVector4()
		{
			return default(System.Numerics.Vector4);
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x1C1D88C", Offset = "0x1C1D88C", VA = "0x1C1D88C")]
		public void WriteQuaternion(System.Numerics.Quaternion x)
		{
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x1C1D8E8", Offset = "0x1C1D8E8", VA = "0x1C1D8E8")]
		public System.Numerics.Quaternion ReadQuaternion()
		{
			return default(System.Numerics.Quaternion);
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x1C1D96C", Offset = "0x1C1D96C", VA = "0x1C1D96C")]
		public void WriteMatrix4x4(System.Numerics.Matrix4x4 x)
		{
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x1C1DA44", Offset = "0x1C1DA44", VA = "0x1C1DA44")]
		public System.Numerics.Matrix4x4 ReadMatrix4x4()
		{
			return default(System.Numerics.Matrix4x4);
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x1C1DB94", Offset = "0x1C1DB94", VA = "0x1C1DB94")]
		internal void SkipBytes()
		{
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x1C1DBFC", Offset = "0x1C1DBFC", VA = "0x1C1DBFC")]
		public void WriteByteBufWithSize(ByteBuf o)
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x1C1DC70", Offset = "0x1C1DC70", VA = "0x1C1DC70")]
		public void WriteByteBufWithoutSize(ByteBuf o)
		{
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x1C1DC9C", Offset = "0x1C1DC9C", VA = "0x1C1DC9C")]
		public bool TryReadByte(out byte x)
		{
			return default(bool);
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x1C1DD04", Offset = "0x1C1DD04", VA = "0x1C1DD04")]
		public EDeserializeError TryDeserializeInplaceByteBuf(int maxSize, ByteBuf inplaceTempBody)
		{
			return default(EDeserializeError);
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x1C1DF98", Offset = "0x1C1DF98", VA = "0x1C1DF98")]
		public void WriteRawTag(byte b1)
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x1C1E01C", Offset = "0x1C1E01C", VA = "0x1C1E01C")]
		public void WriteRawTag(byte b1, byte b2)
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x1C1E0D0", Offset = "0x1C1E0D0", VA = "0x1C1E0D0")]
		public void WriteRawTag(byte b1, byte b2, byte b3)
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x1C1E1AC", Offset = "0x1C1E1AC", VA = "0x1C1E1AC")]
		public void BeginWriteSegment(out int oldSize)
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x1C1E20C", Offset = "0x1C1E20C", VA = "0x1C1E20C")]
		public void EndWriteSegment(int oldSize)
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x1C1E5D0", Offset = "0x1C1E5D0", VA = "0x1C1E5D0")]
		public void ReadSegment(out int startIndex, out int segmentSize)
		{
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x1C1E954", Offset = "0x1C1E954", VA = "0x1C1E954")]
		public void ReadSegment(ByteBuf buf)
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x1C1E9B4", Offset = "0x1C1E9B4", VA = "0x1C1E9B4")]
		public void EnterSegment(out SegmentSaveState saveState)
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x1C1EA18", Offset = "0x1C1EA18", VA = "0x1C1EA18")]
		public void LeaveSegment(SegmentSaveState saveState)
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x1C1EA24", Offset = "0x1C1EA24", VA = "0x1C1EA24", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x1C1EB84", Offset = "0x1C1EB84", VA = "0x1C1EB84", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x1C1EC04", Offset = "0x1C1EC04", VA = "0x1C1EC04", Slot = "5")]
		public bool Equals(ByteBuf other)
		{
			return default(bool);
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x1C1ECBC", Offset = "0x1C1ECBC", VA = "0x1C1ECBC", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x1C1ED28", Offset = "0x1C1ED28", VA = "0x1C1ED28")]
		public static ByteBuf FromString(string value)
		{
			return null;
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x1C1EE68", Offset = "0x1C1EE68", VA = "0x1C1EE68", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x1C1EEE0", Offset = "0x1C1EEE0", VA = "0x1C1EEE0")]
		public void Release()
		{
		}
	}
	[Token(Token = "0x200014C")]
	public interface ITypeId
	{
		[Token(Token = "0x6000921")]
		int GetTypeId();
	}
}
namespace Bright.Config
{
	[Token(Token = "0x200014D")]
	public abstract class BeanBase : ITypeId
	{
		[Token(Token = "0x6000922")]
		public abstract int GetTypeId();

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x1C177C4", Offset = "0x1C177C4", VA = "0x1C177C4")]
		protected BeanBase()
		{
		}
	}
}
