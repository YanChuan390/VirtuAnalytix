using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using HighlightPlus;
using Il2CppDummyDll;
using RenderHeads.Media.AVProVideo;
using SeanTools;
using Unity.XR.PXR;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Networking;
using UnityEngine.Rendering;
using UnityEngine.Scripting;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class LogText : MonoBehaviour
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x718AF0", Offset = "0x718AF0", VA = "0x718AF0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x718CE4", Offset = "0x718CE4", VA = "0x718CE4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x718C2C", Offset = "0x718C2C", VA = "0x718C2C")]
	public string GetUpPath(string path)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x718C64", Offset = "0x718C64", VA = "0x718C64")]
	private string GetNowTime()
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x718CEC", Offset = "0x718CEC", VA = "0x718CEC")]
	public LogText()
	{
	}
}
[Token(Token = "0x2000003")]
public class BrushPoint : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Stone stone;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public BrushPointManager manager;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Collider collider;

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x718CF4", Offset = "0x718CF4", VA = "0x718CF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x718DAC", Offset = "0x718DAC", VA = "0x718DAC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x718DB0", Offset = "0x718DB0", VA = "0x718DB0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x718DB4", Offset = "0x718DB4", VA = "0x718DB4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x718EB4", Offset = "0x718EB4", VA = "0x718EB4")]
	public BrushPoint()
	{
	}
}
[Token(Token = "0x2000004")]
public class BrushPointManager : MonoBehaviour
{
	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isRight;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool canPlayAudio;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Animator BrushAni;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool isFirstTrigger;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Quaternion brushRot;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject smokePrefab;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform brushPointTrans;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector3 StartBrush_pos;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public Vector3 StopBrush_pos;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int DrawLineCount;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int MaxDrawLineCount;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Stone stone;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool BeInteractive;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public BoxCollider[] brushPoints;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Transform target;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 curpos;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private Vector3 lastpos;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float NeedSpeed;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private float curSpeed;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private bool startDrawline;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Action DrawLine;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public XRNode Hand;

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x718EBC", Offset = "0x718EBC", VA = "0x718EBC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x718F30", Offset = "0x718F30", VA = "0x718F30")]
	private void Start()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x719058", Offset = "0x719058", VA = "0x719058")]
	private void Update()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x719494", Offset = "0x719494", VA = "0x719494")]
	public void PlayEffectAudio()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x719608", Offset = "0x719608", VA = "0x719608")]
	private void ResetCanPlayAudio()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x719328", Offset = "0x719328", VA = "0x719328")]
	private void CreateSmoke()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x7192C4", Offset = "0x7192C4", VA = "0x7192C4")]
	private Quaternion BrushAngles()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x719614", Offset = "0x719614", VA = "0x719614")]
	private void DetectDir()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x71916C", Offset = "0x71916C", VA = "0x71916C")]
	private void ResetPoints()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x7191EC", Offset = "0x7191EC", VA = "0x7191EC")]
	private float Speed()
	{
		return default(float);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x7191D4", Offset = "0x7191D4", VA = "0x7191D4")]
	private void PlayAcion()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x719740", Offset = "0x719740", VA = "0x719740")]
	public bool CanAddDrawLineCount()
	{
		return default(bool);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x719748", Offset = "0x719748", VA = "0x719748")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x71984C", Offset = "0x71984C", VA = "0x71984C")]
	private void ResetDrawLineCount()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x719858", Offset = "0x719858", VA = "0x719858")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x718E78", Offset = "0x718E78", VA = "0x718E78")]
	public void AddDrawLineCount()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x719920", Offset = "0x719920", VA = "0x719920")]
	public BrushPointManager()
	{
	}
}
[Token(Token = "0x2000005")]
public class B_1HDJG : Sean_SceneBase
{
	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject smoke;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public SpriteRenderer[] Tips;

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x719944", Offset = "0x719944", VA = "0x719944")]
	private new void Awake()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x7199E8", Offset = "0x7199E8", VA = "0x7199E8")]
	private void Start()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x719C0C", Offset = "0x719C0C", VA = "0x719C0C")]
	public B_1HDJG()
	{
	}
}
[Token(Token = "0x2000006")]
public class B_1HDJG_Game1 : Sean_GameBase
{
	[Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class <_Init>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public B_1HDJG_Game1 <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x71E1F8", Offset = "0x71E1F8", VA = "0x71E1F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x71E240", Offset = "0x71E240", VA = "0x71E240", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x719E54", Offset = "0x719E54", VA = "0x719E54")]
		[DebuggerHidden]
		public <_Init>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x71C720", Offset = "0x71C720", VA = "0x71C720", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x71C724", Offset = "0x71C724", VA = "0x71C724", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x71E200", Offset = "0x71E200", VA = "0x71E200", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class <DelayStartShowArrow>d__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public B_1HDJG_Game1 <>4__this;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x71E378", Offset = "0x71E378", VA = "0x71E378", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x71E3C0", Offset = "0x71E3C0", VA = "0x71E3C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x71ADF4", Offset = "0x71ADF4", VA = "0x71ADF4")]
		[DebuggerHidden]
		public <DelayStartShowArrow>d__55(int <>1__state)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x71E248", Offset = "0x71E248", VA = "0x71E248", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x71E24C", Offset = "0x71E24C", VA = "0x71E24C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x71E380", Offset = "0x71E380", VA = "0x71E380", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class <ShowTappingTips>d__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public B_1HDJG_Game1 <>4__this;

		[Token(Token = "0x17000005")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x71E5C4", Offset = "0x71E5C4", VA = "0x71E5C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x71E60C", Offset = "0x71E60C", VA = "0x71E60C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x71B830", Offset = "0x71B830", VA = "0x71B830")]
		[DebuggerHidden]
		public <ShowTappingTips>d__59(int <>1__state)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x71E3C8", Offset = "0x71E3C8", VA = "0x71E3C8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x71E3CC", Offset = "0x71E3CC", VA = "0x71E3CC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x71E5CC", Offset = "0x71E5CC", VA = "0x71E5CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class <ShowBrushingTips>d__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public B_1HDJG_Game1 <>4__this;

		[Token(Token = "0x17000007")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x71E758", Offset = "0x71E758", VA = "0x71E758", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x71E7A0", Offset = "0x71E7A0", VA = "0x71E7A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x71C19C", Offset = "0x71C19C", VA = "0x71C19C")]
		[DebuggerHidden]
		public <ShowBrushingTips>d__63(int <>1__state)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x71E614", Offset = "0x71E614", VA = "0x71E614", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x71E618", Offset = "0x71E618", VA = "0x71E618", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x71E760", Offset = "0x71E760", VA = "0x71E760", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject RightHand;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject LeftHand;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<GameObject> TapSmokes;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int CurShowTipsCount;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public SpriteRenderer Tips_L;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public SpriteRenderer Tips_R;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Tween tipsTw_L;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Tween tipsTw_R;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Animator[] ani;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private saizhanggui_sc001_v04 _saizhanggui_sc001_v04;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Stone stone;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<GameObject> Tap_Points;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private BrushPointManager _BrushPointManager;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private B_1HDJG _B_1HDJG;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public DeviceEventBase chuizi;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private DeviceEventBase zhuizi;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private DeviceEventBase shuazi;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private SpriteRenderer NPC_UI;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Sean_DeviceController sean_Device;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public SpriteRenderer tips_L;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public SpriteRenderer tips_R;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private bool canShowHandTips_L;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
	private bool canShowHandTips_R;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public GameObject zhuizi_vfx;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public GameObject chuizi_vfx;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public GameObject shuziTips;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public GameObject TappingTips;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public GameObject TappingTips2;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public GameObject TappingTips1;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[SerializeField]
	private int CurrentTapIndex;

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x719C14", Offset = "0x719C14", VA = "0x719C14")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x719D4C", Offset = "0x719D4C", VA = "0x719D4C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x719DC0", Offset = "0x719DC0", VA = "0x719DC0")]
	public void Init()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x719DE0", Offset = "0x719DE0", VA = "0x719DE0")]
	[IteratorStateMachine(typeof(<_Init>d__33))]
	public IEnumerator _Init()
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x719E7C", Offset = "0x719E7C", VA = "0x719E7C")]
	private void DelayShowArrow()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x719F3C", Offset = "0x719F3C", VA = "0x719F3C")]
	private void SetDisappearArrow()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x71A01C", Offset = "0x71A01C", VA = "0x71A01C")]
	private void BrushStoneHapticImpulse()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x71A060", Offset = "0x71A060", VA = "0x71A060")]
	private void SetBrushHand(Sean_HandBase handbase)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x71A084", Offset = "0x71A084", VA = "0x71A084")]
	private void InitToolsScripts(Transform trans)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x71A2F8", Offset = "0x71A2F8", VA = "0x71A2F8")]
	public void GrapPlaySound(string name)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x71A4E0", Offset = "0x71A4E0", VA = "0x71A4E0")]
	public void ReleasePlaySound(string name)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x71A6C4", Offset = "0x71A6C4", VA = "0x71A6C4")]
	private void ThisCollisionEnter(Collision obj)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x71A6C8", Offset = "0x71A6C8", VA = "0x71A6C8")]
	private void DeviceTriggerEnterClick(Sean_HandBase obj)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x71A6CC", Offset = "0x71A6CC", VA = "0x71A6CC")]
	private void Update()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x71A6D0", Offset = "0x71A6D0", VA = "0x71A6D0")]
	private void ReleaseHand(XRNode hand)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x71A70C", Offset = "0x71A70C", VA = "0x71A70C")]
	private void DelaySetCanShowHandTipsTrue_L()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x71A718", Offset = "0x71A718", VA = "0x71A718")]
	private void DelaySetCanShowHandTipsTrue_R()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x71A724", Offset = "0x71A724", VA = "0x71A724")]
	private SpriteRenderer ShowHandTips()
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x71A9C8", Offset = "0x71A9C8", VA = "0x71A9C8")]
	private SpriteRenderer ShowHandTipsSolo()
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x71A888", Offset = "0x71A888", VA = "0x71A888")]
	public SpriteRenderer ShowhandTips_L()
	{
		return null;
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x71A928", Offset = "0x71A928", VA = "0x71A928")]
	public SpriteRenderer ShowhandTips_R()
	{
		return null;
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x71AA18", Offset = "0x71AA18", VA = "0x71AA18")]
	public SpriteRenderer StophandTips_L()
	{
		return null;
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x71AB48", Offset = "0x71AB48", VA = "0x71AB48")]
	public SpriteRenderer StophandTips_R()
	{
		return null;
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x71AC78", Offset = "0x71AC78", VA = "0x71AC78")]
	public void StarthandTips(XRNode hand)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x71AD00", Offset = "0x71AD00", VA = "0x71AD00")]
	public void StarthandTipsSolo(XRNode hand)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x71AD80", Offset = "0x71AD80", VA = "0x71AD80")]
	[IteratorStateMachine(typeof(<DelayStartShowArrow>d__55))]
	private IEnumerator DelayStartShowArrow()
	{
		return null;
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x71AE1C", Offset = "0x71AE1C", VA = "0x71AE1C")]
	public void StophandTips(Sean_HandBase handbase)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x71AF6C", Offset = "0x71AF6C", VA = "0x71AF6C")]
	public void StophandTipsSolo(Sean_HandBase handbase)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x71B1F0", Offset = "0x71B1F0", VA = "0x71B1F0")]
	public void StartGame1()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x71B7BC", Offset = "0x71B7BC", VA = "0x71B7BC")]
	[IteratorStateMachine(typeof(<ShowTappingTips>d__59))]
	private IEnumerator ShowTappingTips()
	{
		return null;
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x71B700", Offset = "0x71B700", VA = "0x71B700")]
	private void ShowTapPointUI(int index)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x71B858", Offset = "0x71B858", VA = "0x71B858")]
	public void TappingStone(int TapBrokenIndex)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x71B9D0", Offset = "0x71B9D0", VA = "0x71B9D0")]
	public void StartGame2()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x71C128", Offset = "0x71C128", VA = "0x71C128")]
	[IteratorStateMachine(typeof(<ShowBrushingTips>d__63))]
	private IEnumerator ShowBrushingTips()
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x71C1C4", Offset = "0x71C1C4", VA = "0x71C1C4")]
	public void Game1Finished()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x71C558", Offset = "0x71C558", VA = "0x71C558")]
	[ContextMenu("进入刷石头任务")]
	private void StartBrushStone()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x71C560", Offset = "0x71C560", VA = "0x71C560")]
	[ContextMenu("进入敲石头任务")]
	private void StartTapStone()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x71C564", Offset = "0x71C564", VA = "0x71C564")]
	[ContextMenu("黑场切换场景")]
	private void FadeToNext()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x71C5C8", Offset = "0x71C5C8", VA = "0x71C5C8")]
	public B_1HDJG_Game1()
	{
	}
}
[Token(Token = "0x200000B")]
public class chuizi1 : MonoBehaviour
{
	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 curpos;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 lastpos;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 curEuler;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 lastEuler;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float NeedSpeed;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float curSpeed;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool canPlayAudio;

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x71E7A8", Offset = "0x71E7A8", VA = "0x71E7A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x71E7AC", Offset = "0x71E7AC", VA = "0x71E7AC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x71E7C4", Offset = "0x71E7C4", VA = "0x71E7C4")]
	private float Speed()
	{
		return default(float);
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x71E8AC", Offset = "0x71E8AC", VA = "0x71E8AC")]
	private float angularSpeed()
	{
		return default(float);
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x71E9A8", Offset = "0x71E9A8", VA = "0x71E9A8")]
	public bool canPlayAcion()
	{
		return default(bool);
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x71E9B8", Offset = "0x71E9B8", VA = "0x71E9B8")]
	public void PlayEffectAudio()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x71EAA0", Offset = "0x71EAA0", VA = "0x71EAA0")]
	private void ResetCanPlayAudio()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x71EAAC", Offset = "0x71EAAC", VA = "0x71EAAC")]
	public chuizi1()
	{
	}
}
[Token(Token = "0x200000C")]
public class DelayPlayDoorVoice : MonoBehaviour
{
	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource audio;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool CanDetect;

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x71EAC8", Offset = "0x71EAC8", VA = "0x71EAC8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x71EB20", Offset = "0x71EB20", VA = "0x71EB20")]
	private void Start()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x71EB24", Offset = "0x71EB24", VA = "0x71EB24")]
	private void Update()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x71EBC0", Offset = "0x71EBC0", VA = "0x71EBC0")]
	public void DelayPlay()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x71EC10", Offset = "0x71EC10", VA = "0x71EC10")]
	public void PlayVoice()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x71EC38", Offset = "0x71EC38", VA = "0x71EC38")]
	public void PlayVoice2()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x71EC80", Offset = "0x71EC80", VA = "0x71EC80")]
	public DelayPlayDoorVoice()
	{
	}
}
[Token(Token = "0x200000D")]
public class saizhanggui_sc001_v04 : MonoBehaviour
{
	[Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class <DofadeAudio>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public saizhanggui_sc001_v04 <>4__this;

		[Token(Token = "0x17000009")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x71F8AC", Offset = "0x71F8AC", VA = "0x71F8AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x71F8F4", Offset = "0x71F8F4", VA = "0x71F8F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x71F1C8", Offset = "0x71F1C8", VA = "0x71F1C8")]
		[DebuggerHidden]
		public <DofadeAudio>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x71F780", Offset = "0x71F780", VA = "0x71F780", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x71F784", Offset = "0x71F784", VA = "0x71F784", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x71F8B4", Offset = "0x71F8B4", VA = "0x71F8B4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class <FadeToNextSceneIE>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public saizhanggui_sc001_v04 <>4__this;

		[Token(Token = "0x1700000B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x71FAFC", Offset = "0x71FAFC", VA = "0x71FAFC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x71FB44", Offset = "0x71FB44", VA = "0x71FB44", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x71F688", Offset = "0x71F688", VA = "0x71F688")]
		[DebuggerHidden]
		public <FadeToNextSceneIE>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x71F8FC", Offset = "0x71F8FC", VA = "0x71F8FC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x71F900", Offset = "0x71F900", VA = "0x71F900", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x71FB04", Offset = "0x71FB04", VA = "0x71FB04", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject Smoke;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PXR_ScreenFade_X _PXR_ScreenFade;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject ui;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Animator clothAni;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Animator clothAni2;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Action animatorEnd;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AnimationClip clip;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private AnimatorStateInfo stateinfo;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public AudioSource audis;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Animator ani;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public string aniName;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject stone;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool isEnd;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject ani2;

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x71EC88", Offset = "0x71EC88", VA = "0x71EC88")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x71F154", Offset = "0x71F154", VA = "0x71F154")]
	[IteratorStateMachine(typeof(<DofadeAudio>d__15))]
	private IEnumerator DofadeAudio()
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x71F1F0", Offset = "0x71F1F0", VA = "0x71F1F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x71F28C", Offset = "0x71F28C", VA = "0x71F28C")]
	private void ShowUI()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x71F2AC", Offset = "0x71F2AC", VA = "0x71F2AC")]
	private void StartPlayAudio()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x71F2F8", Offset = "0x71F2F8", VA = "0x71F2F8")]
	private void Ani1_End()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x71F43C", Offset = "0x71F43C", VA = "0x71F43C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x71F468", Offset = "0x71F468", VA = "0x71F468")]
	private void isAniEnd(string name)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x71C3AC", Offset = "0x71C3AC", VA = "0x71C3AC")]
	public void PlayEndingAni()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x71C57C", Offset = "0x71C57C", VA = "0x71C57C")]
	public void FadeToNextScene()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x71F614", Offset = "0x71F614", VA = "0x71F614")]
	[IteratorStateMachine(typeof(<FadeToNextSceneIE>d__24))]
	public IEnumerator FadeToNextSceneIE()
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x71F6B0", Offset = "0x71F6B0", VA = "0x71F6B0")]
	private void DelayToNextScene()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x71F084", Offset = "0x71F084", VA = "0x71F084")]
	public void AddAnimationEvent(AnimationClip clip, string functionName, bool isStart = false, float offset = 0.1f)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x71F724", Offset = "0x71F724", VA = "0x71F724")]
	[ContextMenu("下一个动画")]
	private void PlayNextAni()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x71F728", Offset = "0x71F728", VA = "0x71F728")]
	public saizhanggui_sc001_v04()
	{
	}
}
[Token(Token = "0x2000010")]
public class SceneStartFade : MonoBehaviour
{
	[Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class <DelayStartNext>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SceneStartFade <>4__this;

		[Token(Token = "0x1700000D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x720578", Offset = "0x720578", VA = "0x720578", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x7205C0", Offset = "0x7205C0", VA = "0x7205C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x71FF74", Offset = "0x71FF74", VA = "0x71FF74")]
		[DebuggerHidden]
		public <DelayStartNext>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x7202F0", Offset = "0x7202F0", VA = "0x7202F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x7202F4", Offset = "0x7202F4", VA = "0x7202F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x720580", Offset = "0x720580", VA = "0x720580", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class <AppearScene>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SceneStartFade <>4__this;

		[Token(Token = "0x1700000F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x720850", Offset = "0x720850", VA = "0x720850", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x720898", Offset = "0x720898", VA = "0x720898", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x720090", Offset = "0x720090", VA = "0x720090")]
		[DebuggerHidden]
		public <AppearScene>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x7205C8", Offset = "0x7205C8", VA = "0x7205C8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x7205CC", Offset = "0x7205CC", VA = "0x7205CC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x720858", Offset = "0x720858", VA = "0x720858", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class <MoveCameraMaskIE>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SceneStartFade <>4__this;

		[Token(Token = "0x17000011")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x7209BC", Offset = "0x7209BC", VA = "0x7209BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x720A04", Offset = "0x720A04", VA = "0x720A04", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x7202B8", Offset = "0x7202B8", VA = "0x7202B8")]
		[DebuggerHidden]
		public <MoveCameraMaskIE>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x7208A0", Offset = "0x7208A0", VA = "0x7208A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x7208A4", Offset = "0x7208A4", VA = "0x7208A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x7209C4", Offset = "0x7209C4", VA = "0x7209C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioSource SZG_BGM;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioClip[] audioClips;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioSource audioSource;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioSource audio2;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public MediaPlayer player;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform videoMaks;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Renderer videoRender;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform mask;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Renderer maskRender;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject[] scenes;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public VideoFadeControl fadeControl;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool canTriggerEvent;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
	private bool canTriggerEvent1;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public PXR_ScreenFade_X screenFade;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool isPlayingEvent;

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x71FB4C", Offset = "0x71FB4C", VA = "0x71FB4C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x71FC6C", Offset = "0x71FC6C", VA = "0x71FC6C")]
	private void _Start()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x71FD64", Offset = "0x71FD64", VA = "0x71FD64")]
	private void Start()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x71FDB4", Offset = "0x71FDB4", VA = "0x71FDB4")]
	private void PlayNextAudio()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x71FE58", Offset = "0x71FE58", VA = "0x71FE58")]
	private void PlayerEvent(MediaPlayer arg0, MediaPlayerEvent.EventType arg1, ErrorCode arg2)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x71FF00", Offset = "0x71FF00", VA = "0x71FF00")]
	[IteratorStateMachine(typeof(<DelayStartNext>d__20))]
	private IEnumerator DelayStartNext()
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x71FF9C", Offset = "0x71FF9C", VA = "0x71FF9C")]
	private void PlayerEvent2(MediaPlayer arg0, MediaPlayerEvent.EventType arg1, ErrorCode arg2)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x71FFE4", Offset = "0x71FFE4", VA = "0x71FFE4")]
	private void _PlayerEvent()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x72001C", Offset = "0x72001C", VA = "0x72001C")]
	[IteratorStateMachine(typeof(<AppearScene>d__23))]
	private IEnumerator AppearScene()
	{
		return null;
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x7200B8", Offset = "0x7200B8", VA = "0x7200B8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x720224", Offset = "0x720224", VA = "0x720224")]
	private void MoveMask()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x720244", Offset = "0x720244", VA = "0x720244")]
	[IteratorStateMachine(typeof(<MoveCameraMaskIE>d__26))]
	private IEnumerator MoveCameraMaskIE()
	{
		return null;
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x7201C8", Offset = "0x7201C8", VA = "0x7201C8")]
	[ContextMenu("跳过片头")]
	private void PassBegining()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x7202E0", Offset = "0x7202E0", VA = "0x7202E0")]
	public SceneStartFade()
	{
	}
}
[Token(Token = "0x2000014")]
public class ShuaiZiTest : MonoBehaviour
{
	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public BrushPointManager _BrushPointManager;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool startPlayBrushAni;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool canPlayBrushAni;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Tween tw;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Renderer brushAniRender;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Material BrushAniMat;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool canUpdate;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform brushPointTrans;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector3 StartBrush_pos;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public Vector3 StopBrush_pos;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Text text;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Transform shuaziTrans;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool isActive;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private Vector3 preAngle;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Queue<Vector3> shuaziQueue;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Queue<Vector3> brushPointQueue;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Vector3 dir;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private Vector3 dir2;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public float offset;

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x720A0C", Offset = "0x720A0C", VA = "0x720A0C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x720A3C", Offset = "0x720A3C", VA = "0x720A3C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x720A8C", Offset = "0x720A8C", VA = "0x720A8C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x720AEC", Offset = "0x720AEC", VA = "0x720AEC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x720AF4", Offset = "0x720AF4", VA = "0x720AF4")]
	private void Update()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x721034", Offset = "0x721034", VA = "0x721034")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x720C40", Offset = "0x720C40", VA = "0x720C40")]
	private void QueueWork()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x720D0C", Offset = "0x720D0C", VA = "0x720D0C")]
	private void BrushQueueWork()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x7211B4", Offset = "0x7211B4", VA = "0x7211B4")]
	private void SetCanUpdate()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x7211C4", Offset = "0x7211C4", VA = "0x7211C4")]
	public void SetCanUpdateDelay()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x72121C", Offset = "0x72121C", VA = "0x72121C")]
	public void SetCantUpdate()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x721084", Offset = "0x721084", VA = "0x721084")]
	private void PlayBrushAni(float VertexOffset = 1f, float time = 0.1f)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x721274", Offset = "0x721274", VA = "0x721274")]
	private void PlayBrushAni2(float VertexOffset = 1f, float time = 0.1f)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x7213A4", Offset = "0x7213A4", VA = "0x7213A4")]
	private void ResetAni()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x7213B4", Offset = "0x7213B4", VA = "0x7213B4")]
	public ShuaiZiTest()
	{
	}
}
[Token(Token = "0x2000015")]
public class shuaziStoneTrigger : MonoBehaviour
{
	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x7215D4", Offset = "0x7215D4", VA = "0x7215D4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x7215D8", Offset = "0x7215D8", VA = "0x7215D8")]
	private void Update()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x7215DC", Offset = "0x7215DC", VA = "0x7215DC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x72167C", Offset = "0x72167C", VA = "0x72167C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x721718", Offset = "0x721718", VA = "0x721718")]
	public shuaziStoneTrigger()
	{
	}
}
[Token(Token = "0x2000016")]
public class Smoke : MonoBehaviour
{
	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem ps;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool startPlay;

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x721720", Offset = "0x721720", VA = "0x721720")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x721778", Offset = "0x721778", VA = "0x721778")]
	private void Start()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x7217A4", Offset = "0x7217A4", VA = "0x7217A4")]
	private void Update()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x721840", Offset = "0x721840", VA = "0x721840")]
	public Smoke()
	{
	}
}
[Token(Token = "0x2000017")]
public class Stone : MonoBehaviour
{
	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public JiaGuChangeControl _JiaGuChangeControl;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Animator animator;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int Tap_count;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int Brush_count;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Action AllActionEnd;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Action<int> TapAcionTrigger;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool canPlayTapAction;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private bool canPlayBrushAcion;

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x721848", Offset = "0x721848", VA = "0x721848")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x7218EC", Offset = "0x7218EC", VA = "0x7218EC")]
	private void Start()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x7218F0", Offset = "0x7218F0", VA = "0x7218F0")]
	private void Update()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x7218F4", Offset = "0x7218F4", VA = "0x7218F4")]
	public void PlayTapAcion()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x7196A8", Offset = "0x7196A8", VA = "0x7196A8")]
	public void PlayBrushAcion()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x721AA8", Offset = "0x721AA8", VA = "0x721AA8")]
	public Stone()
	{
	}
}
[Token(Token = "0x2000018")]
public class SZG2 : MonoBehaviour
{
	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x721AB8", Offset = "0x721AB8", VA = "0x721AB8")]
	private void Start()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x721ABC", Offset = "0x721ABC", VA = "0x721ABC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x721AC0", Offset = "0x721AC0", VA = "0x721AC0")]
	public void FadeToNextScene()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x721B6C", Offset = "0x721B6C", VA = "0x721B6C")]
	private void DelayToNextScene()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x721BE0", Offset = "0x721BE0", VA = "0x721BE0")]
	public SZG2()
	{
	}
}
[Token(Token = "0x2000019")]
public class SZG_smoke : MonoBehaviour
{
	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleSystem ps;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float minTime;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float maxTime;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool canPlay;

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x721BE8", Offset = "0x721BE8", VA = "0x721BE8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x721C40", Offset = "0x721C40", VA = "0x721C40")]
	private void Start()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x721C44", Offset = "0x721C44", VA = "0x721C44")]
	private void Update()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x721CCC", Offset = "0x721CCC", VA = "0x721CCC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x721CD4", Offset = "0x721CD4", VA = "0x721CD4")]
	private void Replay()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x71F5E8", Offset = "0x71F5E8", VA = "0x71F5E8")]
	public void Stop()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x721D00", Offset = "0x721D00", VA = "0x721D00")]
	public SZG_smoke()
	{
	}
}
[Token(Token = "0x200001A")]
public class TappingPoint_1 : MonoBehaviour
{
	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Action onTriggerEnter;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Action onTriggerExit;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Action TouchingTappingPoint;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Action NoTouchingTappingPoint;

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x721D1C", Offset = "0x721D1C", VA = "0x721D1C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x721D20", Offset = "0x721D20", VA = "0x721D20")]
	private void Update()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x721D24", Offset = "0x721D24", VA = "0x721D24")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x721EC4", Offset = "0x721EC4", VA = "0x721EC4")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x721F94", Offset = "0x721F94", VA = "0x721F94")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x722084", Offset = "0x722084", VA = "0x722084")]
	public TappingPoint_1()
	{
	}
}
[Token(Token = "0x200001B")]
public class TappingPoint_2 : TappingPoint_1
{
	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x72208C", Offset = "0x72208C", VA = "0x72208C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x722090", Offset = "0x722090", VA = "0x722090")]
	private void Update()
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x722094", Offset = "0x722094", VA = "0x722094")]
	public TappingPoint_2()
	{
	}
}
[Token(Token = "0x200001C")]
public class Topofhandle_point : MonoBehaviour
{
	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public EffectAudio effectAudio;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool canPlayAudio;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool canPlayAudio2;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private B_1HDJG _B_1HDJG;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool BeInteractive;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private int count;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Collider collider;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Stone stone;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int TapCount;

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x72209C", Offset = "0x72209C", VA = "0x72209C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x722160", Offset = "0x722160", VA = "0x722160")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x722164", Offset = "0x722164", VA = "0x722164")]
	private void Update()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x722168", Offset = "0x722168", VA = "0x722168")]
	public void PlayAction()
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x7221F0", Offset = "0x7221F0", VA = "0x7221F0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x7222BC", Offset = "0x7222BC", VA = "0x7222BC")]
	public void PlayEffectAudio2()
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x72248C", Offset = "0x72248C", VA = "0x72248C")]
	private void ResetCanPlayAudio2()
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x722360", Offset = "0x722360", VA = "0x722360")]
	public void PlayEffectAudio()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x722498", Offset = "0x722498", VA = "0x722498")]
	private void ResetCanPlayAudio()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x7224A4", Offset = "0x7224A4", VA = "0x7224A4")]
	public Topofhandle_point()
	{
	}
}
[Token(Token = "0x200001D")]
public class ABLoadFile_X : MonoBehaviour
{
	[Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class <ABBaoJiaZai>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ABLoadFile_X <>4__this;

		[Token(Token = "0x17000013")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x722AEC", Offset = "0x722AEC", VA = "0x722AEC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x722B34", Offset = "0x722B34", VA = "0x722B34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x7227B4", Offset = "0x7227B4", VA = "0x7227B4")]
		[DebuggerHidden]
		public <ABBaoJiaZai>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x72283C", Offset = "0x72283C", VA = "0x72283C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x722840", Offset = "0x722840", VA = "0x722840", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x722AF4", Offset = "0x722AF4", VA = "0x722AF4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool IsOBB;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float delay;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AssetBundleCreateRequest request;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ABLoadFile_X instance;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string fileName;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string filePath;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Action FinishedLoadCallBack;

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x7224BC", Offset = "0x7224BC", VA = "0x7224BC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x722560", Offset = "0x722560", VA = "0x722560")]
	public void Reload(string name)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x722664", Offset = "0x722664", VA = "0x722664")]
	public void DestroySelf()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x7226D0", Offset = "0x7226D0", VA = "0x7226D0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x722734", Offset = "0x722734", VA = "0x722734")]
	private void DelayReload()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x72273C", Offset = "0x72273C", VA = "0x72273C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x7225DC", Offset = "0x7225DC", VA = "0x7225DC")]
	public bool DetectHasFile(string fileName)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x722638", Offset = "0x722638", VA = "0x722638")]
	public void StartLoadAB(string path)
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x722740", Offset = "0x722740", VA = "0x722740")]
	[IteratorStateMachine(typeof(<ABBaoJiaZai>d__15))]
	private IEnumerator ABBaoJiaZai()
	{
		return null;
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x7227DC", Offset = "0x7227DC", VA = "0x7227DC")]
	public ABLoadFile_X()
	{
	}
}
[Token(Token = "0x200001F")]
public class AniCtrl : MonoBehaviour
{
	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int index;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private AnimatorStateInfo stateinfo;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Animator currentAni;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Animator targetAni;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string aniName;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Action AniEndTrigger;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool isEnd;

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x722B3C", Offset = "0x722B3C", VA = "0x722B3C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x722B94", Offset = "0x722B94", VA = "0x722B94")]
	private void Start()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x722B98", Offset = "0x722B98", VA = "0x722B98")]
	private void Update()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x722BF8", Offset = "0x722BF8", VA = "0x722BF8")]
	private void isAniEnd(string name)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x722CC8", Offset = "0x722CC8", VA = "0x722CC8")]
	public void PlayNextAni()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x722D14", Offset = "0x722D14", VA = "0x722D14")]
	public AniCtrl()
	{
	}
}
[Token(Token = "0x2000020")]
public class B_2XXJG : Sean_SceneBase
{
	[Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class <ShowPXRFadeIE>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public B_2XXJG <>4__this;

		[Token(Token = "0x17000015")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x7233F8", Offset = "0x7233F8", VA = "0x7233F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x723440", Offset = "0x723440", VA = "0x723440", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x722E94", Offset = "0x722E94", VA = "0x722E94")]
		[DebuggerHidden]
		public <ShowPXRFadeIE>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x722FF4", Offset = "0x722FF4", VA = "0x722FF4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x722FF8", Offset = "0x722FF8", VA = "0x722FF8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x723400", Offset = "0x723400", VA = "0x723400", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class <StartPlayGameIE>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public B_2XXJG <>4__this;

		[Token(Token = "0x17000017")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x723874", Offset = "0x723874", VA = "0x723874", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x7238BC", Offset = "0x7238BC", VA = "0x7238BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x722F50", Offset = "0x722F50", VA = "0x722F50")]
		[DebuggerHidden]
		public <StartPlayGameIE>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x723448", Offset = "0x723448", VA = "0x723448", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x72344C", Offset = "0x72344C", VA = "0x72344C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x72387C", Offset = "0x72387C", VA = "0x72387C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
	public bool DoorAudioFinished;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x73")]
	private bool firstPlay;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[SerializeField]
	private bool videoFinished;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
	private bool loadFinished;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public MediaPlayer tomorrowPlayer;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public AudioSource tiaozhuanBGM;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public PXR_ScreenFade_X _PXR_ScreenFade;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float delay;

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x722D6C", Offset = "0x722D6C", VA = "0x722D6C")]
	private new void Awake()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x722E00", Offset = "0x722E00", VA = "0x722E00")]
	private void ShowPXRFade()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x722E20", Offset = "0x722E20", VA = "0x722E20")]
	[IteratorStateMachine(typeof(<ShowPXRFadeIE>d__10))]
	private IEnumerator ShowPXRFadeIE()
	{
		return null;
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x722EBC", Offset = "0x722EBC", VA = "0x722EBC")]
	private void StartPlayGame()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x722EDC", Offset = "0x722EDC", VA = "0x722EDC")]
	[IteratorStateMachine(typeof(<StartPlayGameIE>d__12))]
	private IEnumerator StartPlayGameIE()
	{
		return null;
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x722F78", Offset = "0x722F78", VA = "0x722F78")]
	private void Start()
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x722F7C", Offset = "0x722F7C", VA = "0x722F7C")]
	private new void Update()
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x722FC4", Offset = "0x722FC4", VA = "0x722FC4")]
	protected void PlayerEvent3(MediaPlayer arg0, MediaPlayerEvent.EventType arg1, ErrorCode arg2)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x722FD8", Offset = "0x722FD8", VA = "0x722FD8")]
	public B_2XXJG()
	{
	}
}
[Token(Token = "0x2000023")]
public class B_2XXJG_Game1 : Sean_GameBase
{
	[Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class <ShowHegaiTips>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public B_2XXJG_Game1 <>4__this;

		[Token(Token = "0x17000019")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x726C64", Offset = "0x726C64", VA = "0x726C64", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x726CAC", Offset = "0x726CAC", VA = "0x726CAC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x725DAC", Offset = "0x725DAC", VA = "0x725DAC")]
		[DebuggerHidden]
		public <ShowHegaiTips>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x726B10", Offset = "0x726B10", VA = "0x726B10", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x726B14", Offset = "0x726B14", VA = "0x726B14", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x726C6C", Offset = "0x726C6C", VA = "0x726C6C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class <ShowGupianTips>d__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public B_2XXJG_Game1 <>4__this;

		[Token(Token = "0x1700001B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x726E10", Offset = "0x726E10", VA = "0x726E10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x726E58", Offset = "0x726E58", VA = "0x726E58", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x72611C", Offset = "0x72611C", VA = "0x72611C")]
		[DebuggerHidden]
		public <ShowGupianTips>d__37(int <>1__state)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x726CB4", Offset = "0x726CB4", VA = "0x726CB4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x726CB8", Offset = "0x726CB8", VA = "0x726CB8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x726E18", Offset = "0x726E18", VA = "0x726E18", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class <DestroyHeziIE>d__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public B_2XXJG_Game1 <>4__this;

		[Token(Token = "0x1700001D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x727054", Offset = "0x727054", VA = "0x727054", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x72709C", Offset = "0x72709C", VA = "0x72709C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x7263E4", Offset = "0x7263E4", VA = "0x7263E4")]
		[DebuggerHidden]
		public <DestroyHeziIE>d__42(int <>1__state)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x726E60", Offset = "0x726E60", VA = "0x726E60", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x726E64", Offset = "0x726E64", VA = "0x726E64", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x72705C", Offset = "0x72705C", VA = "0x72705C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject heziAni;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject[] AniTips;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public SpriteRenderer Tips;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool canShowHandTips;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Tween tipsTw;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int CurShowTipsCount;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform APos;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Transform BPos;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Transform VR;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private GameObject gupian;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private DeviceEventBase _gupian;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<Transform> GripObjs;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Transform hezi;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private SpriteRenderer NPC_UI;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private SpriteRenderer HightArea;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Tween HightAreaTw;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private DeviceEventBase hegai;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Transform hezi_gaiPos;

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x7238C4", Offset = "0x7238C4", VA = "0x7238C4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x723D88", Offset = "0x723D88", VA = "0x723D88")]
	public void GrapPlaySound(string name)
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x723EC8", Offset = "0x723EC8", VA = "0x723EC8")]
	public void ReleasePlaySound(string name)
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x724008", Offset = "0x724008", VA = "0x724008")]
	private void ReleaseHand(XRNode hand)
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x724014", Offset = "0x724014", VA = "0x724014")]
	private void _Start()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x724B64", Offset = "0x724B64", VA = "0x724B64")]
	private void Start()
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x724B68", Offset = "0x724B68", VA = "0x724B68")]
	private void Update()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x72504C", Offset = "0x72504C", VA = "0x72504C")]
	private void StartGame1()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x72526C", Offset = "0x72526C", VA = "0x72526C")]
	private void StartGame2()
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x72556C", Offset = "0x72556C", VA = "0x72556C")]
	private void DelayToShowGupianGrapTips()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x724B94", Offset = "0x724B94", VA = "0x724B94")]
	public void StartGame3()
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x725A14", Offset = "0x725A14", VA = "0x725A14")]
	public void SetGupianActive(Sean_HandBase hand)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x725BA8", Offset = "0x725BA8", VA = "0x725BA8")]
	private void ShowHightArea()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x725CC8", Offset = "0x725CC8", VA = "0x725CC8")]
	public void MoveCameraToBPos()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x7254A0", Offset = "0x7254A0", VA = "0x7254A0")]
	private void StopHandTips()
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x725D38", Offset = "0x725D38", VA = "0x725D38")]
	[IteratorStateMachine(typeof(<ShowHegaiTips>d__33))]
	private IEnumerator ShowHegaiTips()
	{
		return null;
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x725DD4", Offset = "0x725DD4", VA = "0x725DD4")]
	public void StophandTips(Sean_HandBase handbase)
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x725F74", Offset = "0x725F74", VA = "0x725F74")]
	public void StarthandTips(XRNode hand)
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x726008", Offset = "0x726008", VA = "0x726008")]
	public SpriteRenderer ShowhandTips()
	{
		return null;
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x7260A8", Offset = "0x7260A8", VA = "0x7260A8")]
	[IteratorStateMachine(typeof(<ShowGupianTips>d__37))]
	private IEnumerator ShowGupianTips()
	{
		return null;
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x726144", Offset = "0x726144", VA = "0x726144")]
	public void StophandTips2(Sean_HandBase handbase)
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x7262D8", Offset = "0x7262D8", VA = "0x7262D8")]
	public void StarthandTips2(XRNode hand)
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x725878", Offset = "0x725878", VA = "0x725878")]
	public SpriteRenderer ShowhandTips2()
	{
		return null;
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x725918", Offset = "0x725918", VA = "0x725918")]
	public void DestroyHezi()
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x726370", Offset = "0x726370", VA = "0x726370")]
	[IteratorStateMachine(typeof(<DestroyHeziIE>d__42))]
	private IEnumerator DestroyHeziIE()
	{
		return null;
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x72640C", Offset = "0x72640C", VA = "0x72640C")]
	public void FadeToNextScene()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x726580", Offset = "0x726580", VA = "0x726580")]
	[ContextMenu("摧毁盒子")]
	private void StartDestoryHezi()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x726584", Offset = "0x726584", VA = "0x726584")]
	[ContextMenu("开始交互2拿骨片")]
	private void _StartGame2()
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x726588", Offset = "0x726588", VA = "0x726588")]
	[ContextMenu("开始下个脚本")]
	private void _StartGame3()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x72658C", Offset = "0x72658C", VA = "0x72658C")]
	public B_2XXJG_Game1()
	{
	}
}
[Token(Token = "0x2000028")]
public class B_2XXJG_Game2 : Sean_GameBase
{
	[Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class <SetOutlineTrueIE>d__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DeviceEventBase obj;

		[Token(Token = "0x1700001F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x72B6A4", Offset = "0x72B6A4", VA = "0x72B6A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x72B6EC", Offset = "0x72B6EC", VA = "0x72B6EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x729990", Offset = "0x729990", VA = "0x729990")]
		[DebuggerHidden]
		public <SetOutlineTrueIE>d__38(int <>1__state)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x72B5AC", Offset = "0x72B5AC", VA = "0x72B5AC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x72B5B0", Offset = "0x72B5B0", VA = "0x72B5B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x72B6AC", Offset = "0x72B6AC", VA = "0x72B6AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class <AutoFinishedGame>d__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public B_2XXJG_Game2 <>4__this;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x17000021")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x72BB64", Offset = "0x72BB64", VA = "0x72BB64", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x72BBAC", Offset = "0x72BBAC", VA = "0x72BBAC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x72A970", Offset = "0x72A970", VA = "0x72A970")]
		[DebuggerHidden]
		public <AutoFinishedGame>d__53(int <>1__state)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x72B890", Offset = "0x72B890", VA = "0x72B890", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x72B894", Offset = "0x72B894", VA = "0x72B894", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x72BB6C", Offset = "0x72BB6C", VA = "0x72BB6C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class <ShowGupianTips>d__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public B_2XXJG_Game2 <>4__this;

		[Token(Token = "0x17000023")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x72BE10", Offset = "0x72BE10", VA = "0x72BE10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x72BE58", Offset = "0x72BE58", VA = "0x72BE58", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x72AE80", Offset = "0x72AE80", VA = "0x72AE80")]
		[DebuggerHidden]
		public <ShowGupianTips>d__60(int <>1__state)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x72BCBC", Offset = "0x72BCBC", VA = "0x72BCBC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x72BCC0", Offset = "0x72BCC0", VA = "0x72BCC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x72BE18", Offset = "0x72BE18", VA = "0x72BE18", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject RightHand;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject LeftHand;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject[] Effects;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool Pian_A_Finished;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private bool Pian_B_Finished;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	private bool Pian_C_Finished;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject staticPian_A;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject staticPian_B;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject staticPian_C;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public AudioSource xun;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public AudioSource TA;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public SpriteRenderer[] stoneSuccessTips;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject StaticObjs;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public SpriteRenderer NPC_UI;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject[] AniTips;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject Effect;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public SpriteRenderer Tips;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private bool canShowHandTips;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Tween tipsTw;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private int CurShowTipsCount;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public int LinkCount;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public List<Transform> GripObjs;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Transform APos;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Transform BPos;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Transform VR;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public GameObject conectColliderManagerPrefab;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public SpriteRenderer[] spriteRs;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Tween[] spriteTws;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private Tween[] spriteSuccesTws;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private int LinkCount2;

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x7270A4", Offset = "0x7270A4", VA = "0x7270A4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x7277C8", Offset = "0x7277C8", VA = "0x7277C8")]
	private void ReleaseHand(XRNode hand)
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x7277D4", Offset = "0x7277D4", VA = "0x7277D4")]
	public void GrapPlaySound(string name)
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x727964", Offset = "0x727964", VA = "0x727964")]
	public void ReleasePlaySound(string name)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x727AF4", Offset = "0x727AF4", VA = "0x727AF4")]
	private void AppearNPC_UI()
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x727BB0", Offset = "0x727BB0", VA = "0x727BB0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x729898", Offset = "0x729898", VA = "0x729898")]
	public void SetOutlineFalse(Sean_HandBase hand, DeviceEventBase obj)
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x7298F8", Offset = "0x7298F8", VA = "0x7298F8")]
	public void SetOutlineTrue(XRNode hand, DeviceEventBase obj)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x72991C", Offset = "0x72991C", VA = "0x72991C")]
	[IteratorStateMachine(typeof(<SetOutlineTrueIE>d__38))]
	private IEnumerator SetOutlineTrueIE(DeviceEventBase obj)
	{
		return null;
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x7299B8", Offset = "0x7299B8", VA = "0x7299B8")]
	public void ShowOutLine(Collider collider)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x729A24", Offset = "0x729A24", VA = "0x729A24")]
	public void DisppearOutLine(Collider collider)
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x729A90", Offset = "0x729A90", VA = "0x729A90")]
	private void Update()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x729AEC", Offset = "0x729AEC", VA = "0x729AEC")]
	private void UpdateStoneConnectCount()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x729D14", Offset = "0x729D14", VA = "0x729D14")]
	private void DisappearEffects()
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x729DA4", Offset = "0x729DA4", VA = "0x729DA4")]
	private void ChangeXunBGM()
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x729E00", Offset = "0x729E00", VA = "0x729E00")]
	private void SetHandHapticlmpulse(Sean_HandBase handbase)
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x729E70", Offset = "0x729E70", VA = "0x729E70")]
	private void DisappearStoneUI()
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x729F18", Offset = "0x729F18", VA = "0x729F18")]
	private void ShowStoneSuccessTips(int index)
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x72A0F4", Offset = "0x72A0F4", VA = "0x72A0F4")]
	private void DisappearStoneSuccessTips_A()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x72A128", Offset = "0x72A128", VA = "0x72A128")]
	private void DisappearStoneSuccessTips_B()
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x72A160", Offset = "0x72A160", VA = "0x72A160")]
	private void DisappearStoneSuccessTips_C()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x72A198", Offset = "0x72A198", VA = "0x72A198")]
	public void StoneConnectFinised(int index, XRNode hand)
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x72A57C", Offset = "0x72A57C", VA = "0x72A57C")]
	public void ShowGripObjs()
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x729CA0", Offset = "0x729CA0", VA = "0x729CA0")]
	[IteratorStateMachine(typeof(<AutoFinishedGame>d__53))]
	private IEnumerator AutoFinishedGame()
	{
		return null;
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x72A998", Offset = "0x72A998", VA = "0x72A998")]
	public void ShowStoneConectUIs()
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x72AAA0", Offset = "0x72AAA0", VA = "0x72AAA0")]
	public void ShowStoneConectUIs(int index)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x72AC58", Offset = "0x72AC58", VA = "0x72AC58")]
	private void DeviceTriggerEnterClick2(Sean_HandBase hand, DeviceEventBase obj)
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x72ADE4", Offset = "0x72ADE4", VA = "0x72ADE4")]
	public void AddConnectSum()
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x72ADF4", Offset = "0x72ADF4", VA = "0x72ADF4")]
	private void DetectConnected()
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x72A4B0", Offset = "0x72A4B0", VA = "0x72A4B0")]
	private void StopHandTips()
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x72AE0C", Offset = "0x72AE0C", VA = "0x72AE0C")]
	[IteratorStateMachine(typeof(<ShowGupianTips>d__60))]
	private IEnumerator ShowGupianTips()
	{
		return null;
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x72AEA8", Offset = "0x72AEA8", VA = "0x72AEA8")]
	public void StophandTips(Sean_HandBase handbase)
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x72B034", Offset = "0x72B034", VA = "0x72B034")]
	public void StarthandTips(XRNode hand)
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x72B0C8", Offset = "0x72B0C8", VA = "0x72B0C8")]
	public SpriteRenderer ShowhandTips()
	{
		return null;
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x72B168", Offset = "0x72B168", VA = "0x72B168")]
	public void FadeToNextScene()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x72B214", Offset = "0x72B214", VA = "0x72B214")]
	private void DelayToNextScene()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x72B284", Offset = "0x72B284", VA = "0x72B284")]
	[ContextMenu("黑场切换场景")]
	private void FadeToNext()
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x72B288", Offset = "0x72B288", VA = "0x72B288")]
	public B_2XXJG_Game2()
	{
	}
}
[Token(Token = "0x2000030")]
public class ConectCollider : MonoBehaviour
{
	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string ColliderName;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool isTrigger;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool isStatic;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ConectCollidersManager manager;

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x72BE60", Offset = "0x72BE60", VA = "0x72BE60")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x72BED4", Offset = "0x72BED4", VA = "0x72BED4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x72BED8", Offset = "0x72BED8", VA = "0x72BED8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x72BEDC", Offset = "0x72BEDC", VA = "0x72BEDC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x72BFE8", Offset = "0x72BFE8", VA = "0x72BFE8")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x72C048", Offset = "0x72C048", VA = "0x72C048")]
	public void SetName()
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x72C100", Offset = "0x72C100", VA = "0x72C100")]
	public ConectCollider()
	{
	}
}
[Token(Token = "0x2000031")]
public class ConectCollidersManager : MonoBehaviour
{
	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Action<int, XRNode> ConectFinished;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int ConnectNeedCount;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int currentCount;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool isStatic;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform parent;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform target;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool Finished;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int index;

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x72C108", Offset = "0x72C108", VA = "0x72C108")]
	private void Awake()
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x72C10C", Offset = "0x72C10C", VA = "0x72C10C")]
	private void Start()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x72C110", Offset = "0x72C110", VA = "0x72C110")]
	private void Update()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x72C138", Offset = "0x72C138", VA = "0x72C138")]
	public void PlayAction()
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x7296D8", Offset = "0x7296D8", VA = "0x7296D8")]
	public void Init(bool isStatic = false)
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x72C35C", Offset = "0x72C35C", VA = "0x72C35C")]
	public ConectCollidersManager()
	{
	}
}
[Token(Token = "0x2000032")]
public class DelayDisappearVoice : MonoBehaviour
{
	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool destroyParent;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource audio;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float delay;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float Dofade_delay;

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x72C3F0", Offset = "0x72C3F0", VA = "0x72C3F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x72C448", Offset = "0x72C448", VA = "0x72C448")]
	private void Start()
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x72C498", Offset = "0x72C498", VA = "0x72C498")]
	private void Update()
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x72C49C", Offset = "0x72C49C", VA = "0x72C49C")]
	public void DisappearAudio()
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x72C4B4", Offset = "0x72C4B4", VA = "0x72C4B4")]
	public DelayDisappearVoice()
	{
	}
}
[Token(Token = "0x2000033")]
public class DelayPlayVoice : MonoBehaviour
{
	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool destroyParent;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource audio;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float delay;

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x72C4C8", Offset = "0x72C4C8", VA = "0x72C4C8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x72C520", Offset = "0x72C520", VA = "0x72C520")]
	private void Start()
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x72C570", Offset = "0x72C570", VA = "0x72C570")]
	private void Update()
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x72C574", Offset = "0x72C574", VA = "0x72C574")]
	public void PlayAudio()
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x72C64C", Offset = "0x72C64C", VA = "0x72C64C")]
	public DelayPlayVoice()
	{
	}
}
[Token(Token = "0x2000034")]
public class DeskObjs : MonoBehaviour
{
	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string TriggerName;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Action onTriggerEnter;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform staticPos;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GupianConnect link;

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x72C65C", Offset = "0x72C65C", VA = "0x72C65C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x72C660", Offset = "0x72C660", VA = "0x72C660")]
	private void Update()
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x72C664", Offset = "0x72C664", VA = "0x72C664")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x72C6C0", Offset = "0x72C6C0", VA = "0x72C6C0")]
	public void ResetPos()
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x72C7CC", Offset = "0x72C7CC", VA = "0x72C7CC")]
	public DeskObjs()
	{
	}
}
[Token(Token = "0x2000035")]
public class GupianConnect : MonoBehaviour
{
	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Action onConnect;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int index;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool isStatic;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject connectPosPrefab;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool hasBorther;

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x72C824", Offset = "0x72C824", VA = "0x72C824")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x72C934", Offset = "0x72C934", VA = "0x72C934")]
	private void Start()
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x72CC98", Offset = "0x72CC98", VA = "0x72CC98")]
	private void Update()
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x72CC9C", Offset = "0x72CC9C", VA = "0x72CC9C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x72C940", Offset = "0x72C940", VA = "0x72C940")]
	private void LinkToOthers()
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x72D058", Offset = "0x72D058", VA = "0x72D058")]
	public GupianConnect()
	{
	}
}
[Token(Token = "0x2000036")]
public class heziAni : MonoBehaviour
{
	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int index;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private AnimatorStateInfo stateinfo;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Animator currentAni;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Animator targetAni;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string aniName;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool isEnd;

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x72D060", Offset = "0x72D060", VA = "0x72D060")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x72D064", Offset = "0x72D064", VA = "0x72D064")]
	private void Start()
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x72D0B4", Offset = "0x72D0B4", VA = "0x72D0B4")]
	private void DelayDestroy()
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x72D120", Offset = "0x72D120", VA = "0x72D120")]
	private void Update()
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x72D124", Offset = "0x72D124", VA = "0x72D124")]
	private void isAniEnd(string name)
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x72D1E0", Offset = "0x72D1E0", VA = "0x72D1E0")]
	public heziAni()
	{
	}
}
[Token(Token = "0x2000037")]
public class LiuTizhi : MonoBehaviour
{
	[Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class <StartPlayAniIE>d__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LiuTizhi <>4__this;

		[Token(Token = "0x17000025")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x72E24C", Offset = "0x72E24C", VA = "0x72E24C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x72E294", Offset = "0x72E294", VA = "0x72E294", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x72DCE8", Offset = "0x72DCE8", VA = "0x72DCE8")]
		[DebuggerHidden]
		public <StartPlayAniIE>d__45(int <>1__state)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x72E088", Offset = "0x72E088", VA = "0x72E088", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x72E08C", Offset = "0x72E08C", VA = "0x72E08C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x72E254", Offset = "0x72E254", VA = "0x72E254", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool canDetectAudio;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Action auidoIsEnd;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float DelayPlayAni;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool aniIsEnd;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool gupianHasFinished;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
	private bool isLoadingNextScene;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AudioClip secondAudioClip;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public B_2XXJG_Game2 game2;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject gupian_G;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Action ani1IsEnd;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Action ani2IsEnd;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Action startInteraction;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int index;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private AnimatorStateInfo stateinfo;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Animator gupianAni;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Animator bookAni;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Animator currentAni;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Animator ClothAni;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Animator kouziAni;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Animator targetAni;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public string aniName;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public string aniName2;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Action AniEndTrigger;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private bool isEnd;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public AudioSource audios;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public AudioSource audios2;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static LiuTizhi Instance;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private int currentIndex;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public GameObject gupian_A;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public GameObject gupian_B;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public GameObject gupian_C;

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x72D238", Offset = "0x72D238", VA = "0x72D238")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x72D618", Offset = "0x72D618", VA = "0x72D618")]
	public void StopAni()
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x72D298", Offset = "0x72D298", VA = "0x72D298")]
	public void Init()
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x72D7B8", Offset = "0x72D7B8", VA = "0x72D7B8")]
	public void ChangeAuido()
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x72D858", Offset = "0x72D858", VA = "0x72D858")]
	public void DofadeAudio(float delay = 2f, float value = 0f)
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x72D900", Offset = "0x72D900", VA = "0x72D900")]
	public void DisappearGupian()
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x72D920", Offset = "0x72D920", VA = "0x72D920")]
	public void AppearGupian()
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x72D960", Offset = "0x72D960", VA = "0x72D960")]
	private void ShowBookEffect()
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x72D9B8", Offset = "0x72D9B8", VA = "0x72D9B8")]
	private void Ani_1_IsEnd()
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x72DA74", Offset = "0x72DA74", VA = "0x72DA74")]
	private void Ani_2_IsEnd()
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x72DBA4", Offset = "0x72DBA4", VA = "0x72DBA4")]
	private void StartInteraction()
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x72DBC0", Offset = "0x72DBC0", VA = "0x72DBC0")]
	private void Start()
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x72DBC4", Offset = "0x72DBC4", VA = "0x72DBC4")]
	public void StartPlayAni()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x72DC58", Offset = "0x72DC58", VA = "0x72DC58")]
	public void StartPlayAudio()
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x72DBE4", Offset = "0x72DBE4", VA = "0x72DBE4")]
	[IteratorStateMachine(typeof(<StartPlayAniIE>d__45))]
	public IEnumerator StartPlayAniIE()
	{
		return null;
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x72DD10", Offset = "0x72DD10", VA = "0x72DD10")]
	public void PlayNextAni()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x72DDBC", Offset = "0x72DDBC", VA = "0x72DDBC")]
	private void Update()
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x72DE0C", Offset = "0x72DE0C", VA = "0x72DE0C")]
	private bool isAudioEnd()
	{
		return default(bool);
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x72D6E8", Offset = "0x72D6E8", VA = "0x72D6E8")]
	public void AddAnimationEvent(AnimationClip clip, string functionName, bool isStart = false, float offset = 0.1f)
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x72DAB8", Offset = "0x72DAB8", VA = "0x72DAB8")]
	public void PlayEndingAni()
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x72DE28", Offset = "0x72DE28", VA = "0x72DE28")]
	private void RePlayAudio()
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x72DEB8", Offset = "0x72DEB8", VA = "0x72DEB8")]
	public void AniIsFinieshed()
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x72DF6C", Offset = "0x72DF6C", VA = "0x72DF6C")]
	public void FadeToNextScene()
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x72DFFC", Offset = "0x72DFFC", VA = "0x72DFFC")]
	[ContextMenu("播放第二个动画")]
	public void PlayNextAni2()
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x72E000", Offset = "0x72E000", VA = "0x72E000")]
	[ContextMenu("开始播放动画")]
	public void _StartPlayAni()
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x72E020", Offset = "0x72E020", VA = "0x72E020")]
	public LiuTizhi()
	{
	}
}
[Token(Token = "0x2000039")]
public class VRCameraFadeAniMananger : MonoBehaviour
{
	[Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class <ChangeCameraIE3>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VRCameraFadeAniMananger <>4__this;

		[Token(Token = "0x17000027")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x72EE14", Offset = "0x72EE14", VA = "0x72EE14", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x72EE5C", Offset = "0x72EE5C", VA = "0x72EE5C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x72E4E4", Offset = "0x72E4E4", VA = "0x72E4E4")]
		[DebuggerHidden]
		public <ChangeCameraIE3>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x72E9F8", Offset = "0x72E9F8", VA = "0x72E9F8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x72E9FC", Offset = "0x72E9FC", VA = "0x72E9FC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x72EE1C", Offset = "0x72EE1C", VA = "0x72EE1C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class <ChangeCameraIE4>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VRCameraFadeAniMananger <>4__this;

		[Token(Token = "0x17000029")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x72F270", Offset = "0x72F270", VA = "0x72F270", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x72F2B8", Offset = "0x72F2B8", VA = "0x72F2B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x72E580", Offset = "0x72E580", VA = "0x72E580")]
		[DebuggerHidden]
		public <ChangeCameraIE4>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x72EE64", Offset = "0x72EE64", VA = "0x72EE64", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x72EE68", Offset = "0x72EE68", VA = "0x72EE68", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x72F278", Offset = "0x72F278", VA = "0x72F278", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class <UnloadAllObj>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VRCameraFadeAniMananger <>4__this;

		[Token(Token = "0x1700002B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x72F4A8", Offset = "0x72F4A8", VA = "0x72F4A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x72F4F0", Offset = "0x72F4F0", VA = "0x72F4F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x72E61C", Offset = "0x72E61C", VA = "0x72E61C")]
		[DebuggerHidden]
		public <UnloadAllObj>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x72F2C0", Offset = "0x72F2C0", VA = "0x72F2C0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x72F2C4", Offset = "0x72F2C4", VA = "0x72F2C4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x72F4B0", Offset = "0x72F4B0", VA = "0x72F4B0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float JisiDelay;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private bool isPress;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	private bool canClick;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject jisi_BGM;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string FadeScene;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Color PXRFadeColor;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject effect;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject EffectAudios;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float GCTime;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public PXR_ScreenFade_X _PXR_ScreenFade;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Tween moveTw;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject liutizi;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform target;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static VRCameraFadeAniMananger instance;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public B_2XXJG _B2XXJG;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Sean_SceneBase scene;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject[] vr;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Transform suidao;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Transform suidaoMove;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Transform vr0;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Transform vr1;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public GameObject TestEnvironmet;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private float suidaoMoveZTime;

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x72E29C", Offset = "0x72E29C", VA = "0x72E29C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x72E430", Offset = "0x72E430", VA = "0x72E430")]
	private void Start()
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x72E434", Offset = "0x72E434", VA = "0x72E434")]
	private void Update()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x72E470", Offset = "0x72E470", VA = "0x72E470")]
	[IteratorStateMachine(typeof(<ChangeCameraIE3>d__26))]
	private IEnumerator ChangeCameraIE3()
	{
		return null;
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x72E50C", Offset = "0x72E50C", VA = "0x72E50C")]
	[IteratorStateMachine(typeof(<ChangeCameraIE4>d__27))]
	private IEnumerator ChangeCameraIE4()
	{
		return null;
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x72DF4C", Offset = "0x72DF4C", VA = "0x72DF4C")]
	public void ChangeVRCamera()
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x72E5A8", Offset = "0x72E5A8", VA = "0x72E5A8")]
	[IteratorStateMachine(typeof(<UnloadAllObj>d__29))]
	public IEnumerator UnloadAllObj()
	{
		return null;
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x72E644", Offset = "0x72E644", VA = "0x72E644")]
	public void ReleaseMemory()
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x72E664", Offset = "0x72E664", VA = "0x72E664")]
	public void DestroySceneObjs()
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x72E680", Offset = "0x72E680", VA = "0x72E680")]
	public void DestroySelf()
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x72E774", Offset = "0x72E774", VA = "0x72E774")]
	public void SetVRPos(Transform target)
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x72E858", Offset = "0x72E858", VA = "0x72E858")]
	public VRCameraFadeAniMananger()
	{
	}
}
[Token(Token = "0x200003E")]
public class B_3zhenren : Sean_SceneBase
{
	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject VRFade;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public SpriteRenderer[] Tips;

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x72F4F8", Offset = "0x72F4F8", VA = "0x72F4F8")]
	private new void Awake()
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x72F644", Offset = "0x72F644", VA = "0x72F644")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x72F838", Offset = "0x72F838", VA = "0x72F838")]
	private void Start()
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x72F83C", Offset = "0x72F83C", VA = "0x72F83C")]
	private new void Update()
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x72F844", Offset = "0x72F844", VA = "0x72F844")]
	public void StartGame1()
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x72FCEC", Offset = "0x72FCEC", VA = "0x72FCEC")]
	public B_3zhenren()
	{
	}
}
[Token(Token = "0x200003F")]
public class B_3zhenren_Game1 : Sean_GameBase
{
	[Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class <ShowHuoshiTips>d__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public B_3zhenren_Game1 <>4__this;

		[Token(Token = "0x1700002D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x73696C", Offset = "0x73696C", VA = "0x73696C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x7369B4", Offset = "0x7369B4", VA = "0x7369B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x734D8C", Offset = "0x734D8C", VA = "0x734D8C")]
		[DebuggerHidden]
		public <ShowHuoshiTips>d__62(int <>1__state)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x736770", Offset = "0x736770", VA = "0x736770", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x736774", Offset = "0x736774", VA = "0x736774", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x736974", Offset = "0x736974", VA = "0x736974", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class <ShowMukuai1Tips>d__71 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public B_3zhenren_Game1 <>4__this;

		[Token(Token = "0x1700002F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x736B40", Offset = "0x736B40", VA = "0x736B40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x736B88", Offset = "0x736B88", VA = "0x736B88", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x735418", Offset = "0x735418", VA = "0x735418")]
		[DebuggerHidden]
		public <ShowMukuai1Tips>d__71(int <>1__state)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x7369BC", Offset = "0x7369BC", VA = "0x7369BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x7369C0", Offset = "0x7369C0", VA = "0x7369C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x736B48", Offset = "0x736B48", VA = "0x736B48", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class <ShowMukuai2Tips>d__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public B_3zhenren_Game1 <>4__this;

		[Token(Token = "0x17000031")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x736CD0", Offset = "0x736CD0", VA = "0x736CD0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x736D18", Offset = "0x736D18", VA = "0x736D18", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x735808", Offset = "0x735808", VA = "0x735808")]
		[DebuggerHidden]
		public <ShowMukuai2Tips>d__74(int <>1__state)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x736B90", Offset = "0x736B90", VA = "0x736B90", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x736B94", Offset = "0x736B94", VA = "0x736B94", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x736CD8", Offset = "0x736CD8", VA = "0x736CD8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class <ShowKeziTips>d__81 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public B_3zhenren_Game1 <>4__this;

		[Token(Token = "0x17000033")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x736E6C", Offset = "0x736E6C", VA = "0x736E6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x736EB4", Offset = "0x736EB4", VA = "0x736EB4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x735DDC", Offset = "0x735DDC", VA = "0x735DDC")]
		[DebuggerHidden]
		public <ShowKeziTips>d__81(int <>1__state)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x736D20", Offset = "0x736D20", VA = "0x736D20", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x736D24", Offset = "0x736D24", VA = "0x736D24", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x736E74", Offset = "0x736E74", VA = "0x736E74", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int curOutLineIndex;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Tween doudiTipsTw;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public SpriteRenderer[] doudiTips;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool isStartTriggerLetters;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private letteringManager _letteringManager;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private DeviceEventBase _kedao;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private DeviceEventBase _mukuai;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private DeviceEventBase _gutou;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int CurShowTipsCount;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Tween tipsTw_L;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Tween tipsTw_R;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject[] AniTips;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public SpriteRenderer Tips_L;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public SpriteRenderer Tips_R;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public SpriteRenderer tips_L;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public SpriteRenderer tips_R;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private bool canShowHandTips_L;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
	private bool canShowHandTips_R;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Transform APos;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Transform BPos;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Transform VR;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private bool isHandRayDisappear;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public kedao kedao;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public SpriteRenderer[] huoshi_UI;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public SpriteRenderer guike_UI;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Tween[] huoshiUITws;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private Tween guikeTw;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public huopenTrigger huopen;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public BoxCollider[] staticColliders;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private int CurrentStaticHuoshiCount;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private gutou gutou;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private DeviceEventBase huoshi1;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private DeviceEventBase huoshi5;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public Mukuai mukuai;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public ParticleSystem smoke;

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x72FCF4", Offset = "0x72FCF4", VA = "0x72FCF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x730458", Offset = "0x730458", VA = "0x730458")]
	private void Start()
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x731730", Offset = "0x731730", VA = "0x731730")]
	private void ShowAniTips(int index)
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x72F8C8", Offset = "0x72F8C8", VA = "0x72F8C8")]
	public void StartGame1()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x7319D0", Offset = "0x7319D0", VA = "0x7319D0")]
	private void DelayZhenrenPlayAudio()
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x731A24", Offset = "0x731A24", VA = "0x731A24")]
	private void StartGame2()
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x732640", Offset = "0x732640", VA = "0x732640")]
	private void DelayShowMukuaiTips()
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x73268C", Offset = "0x73268C", VA = "0x73268C")]
	private void StartGame3()
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x732E24", Offset = "0x732E24", VA = "0x732E24")]
	private void StartGame4()
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x733960", Offset = "0x733960", VA = "0x733960")]
	private void FinishAllGame()
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x733E58", Offset = "0x733E58", VA = "0x733E58")]
	private void DelayFadeToNextScene()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x732C88", Offset = "0x732C88", VA = "0x732C88")]
	private void DisappearHuoshiUI()
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x733EDC", Offset = "0x733EDC", VA = "0x733EDC")]
	private void DisappearGuikeUI()
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x733F60", Offset = "0x733F60", VA = "0x733F60")]
	private void TriggerStaticObj(Collider collider, DeviceEventBase obj)
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x7344F4", Offset = "0x7344F4", VA = "0x7344F4")]
	private void ShowGuikeUI()
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x73234C", Offset = "0x73234C", VA = "0x73234C")]
	private void ShowHuoshiUI()
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x734674", Offset = "0x734674", VA = "0x734674")]
	private void Update()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x734770", Offset = "0x734770", VA = "0x734770")]
	public void ShowOtherLetters()
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x734774", Offset = "0x734774", VA = "0x734774")]
	public void MoveCameraToBPos()
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x7347A8", Offset = "0x7347A8", VA = "0x7347A8")]
	private void ThisCollisionEnter(Collision obj)
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x7347AC", Offset = "0x7347AC", VA = "0x7347AC")]
	private void kedaoTriggerEnterClick(Sean_HandBase obj)
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x7347D0", Offset = "0x7347D0", VA = "0x7347D0")]
	private void DeviceTriggerEnterClick(Sean_HandBase obj)
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x7347D4", Offset = "0x7347D4", VA = "0x7347D4")]
	public void GrapPlaySound(string name)
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x734A00", Offset = "0x734A00", VA = "0x734A00")]
	public void ReleasePlaySound(string name)
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x7321FC", Offset = "0x7321FC", VA = "0x7321FC")]
	private void StopHandTips()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x734BFC", Offset = "0x734BFC", VA = "0x734BFC")]
	private void showDoudiTips(int index)
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x7320E0", Offset = "0x7320E0", VA = "0x7320E0")]
	private void stopDoudiTips(int index)
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x734D18", Offset = "0x734D18", VA = "0x734D18")]
	[IteratorStateMachine(typeof(<ShowHuoshiTips>d__62))]
	private IEnumerator ShowHuoshiTips()
	{
		return null;
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x734DB4", Offset = "0x734DB4", VA = "0x734DB4")]
	private SpriteRenderer ShowHandTips()
	{
		return null;
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x734E30", Offset = "0x734E30", VA = "0x734E30")]
	public SpriteRenderer ShowhandTips_L()
	{
		return null;
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x734ED4", Offset = "0x734ED4", VA = "0x734ED4")]
	public SpriteRenderer ShowhandTips_R()
	{
		return null;
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x734F78", Offset = "0x734F78", VA = "0x734F78")]
	public void StarthandTips(XRNode hand)
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x73500C", Offset = "0x73500C", VA = "0x73500C")]
	public void StophandTips(Sean_HandBase handbase)
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x7350F8", Offset = "0x7350F8", VA = "0x7350F8")]
	public SpriteRenderer StophandTips_L()
	{
		return null;
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x735230", Offset = "0x735230", VA = "0x735230")]
	public SpriteRenderer StophandTips_R()
	{
		return null;
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x735368", Offset = "0x735368", VA = "0x735368")]
	private void ReleaseHand(XRNode hand)
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x7353A4", Offset = "0x7353A4", VA = "0x7353A4")]
	[IteratorStateMachine(typeof(<ShowMukuai1Tips>d__71))]
	private IEnumerator ShowMukuai1Tips()
	{
		return null;
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x735440", Offset = "0x735440", VA = "0x735440")]
	public void StarthandTipsSolo(XRNode hand)
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x7354D8", Offset = "0x7354D8", VA = "0x7354D8")]
	public void StophandTipsSolo(Sean_HandBase handbase)
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x735794", Offset = "0x735794", VA = "0x735794")]
	[IteratorStateMachine(typeof(<ShowMukuai2Tips>d__74))]
	private IEnumerator ShowMukuai2Tips()
	{
		return null;
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x735830", Offset = "0x735830", VA = "0x735830")]
	public void StarthandTipsSolo2(XRNode hand)
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x7358D4", Offset = "0x7358D4", VA = "0x7358D4")]
	public void StophandTipsSolo2(Sean_HandBase handbase)
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x735B90", Offset = "0x735B90", VA = "0x735B90")]
	private void ShowSmoke()
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x735BAC", Offset = "0x735BAC", VA = "0x735BAC")]
	private void AppearGutouGlowEffect()
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x735C0C", Offset = "0x735C0C", VA = "0x735C0C")]
	private void DelayAppearGutouGlowEffect()
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x735C6C", Offset = "0x735C6C", VA = "0x735C6C")]
	private void DisappearGutouGlowEffect()
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x735D68", Offset = "0x735D68", VA = "0x735D68")]
	[IteratorStateMachine(typeof(<ShowKeziTips>d__81))]
	private IEnumerator ShowKeziTips()
	{
		return null;
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x735E04", Offset = "0x735E04", VA = "0x735E04")]
	public void StarthandTipsSolo3(XRNode hand)
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x735E9C", Offset = "0x735E9C", VA = "0x735E9C")]
	public void StophandTipsSolo3(Sean_HandBase handbase)
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x736158", Offset = "0x736158", VA = "0x736158")]
	private void AppearGutouGlowEffect2(XRNode node)
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x7361BC", Offset = "0x7361BC", VA = "0x7361BC")]
	private void DisappearGutouGlowEffect2()
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x736238", Offset = "0x736238", VA = "0x736238")]
	public void FadeToNextScene()
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x7362E4", Offset = "0x7362E4", VA = "0x7362E4")]
	private void DelayToNextScene()
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x736354", Offset = "0x736354", VA = "0x736354")]
	[ContextMenu("黑场切换场景")]
	private void FadeToNext()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x736358", Offset = "0x736358", VA = "0x736358")]
	[ContextMenu("进入烤木块任务")]
	private void StartKaoMukuai()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x73635C", Offset = "0x73635C", VA = "0x73635C")]
	[ContextMenu("进入刻字任务")]
	private void StartKezi()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x736360", Offset = "0x736360", VA = "0x736360")]
	[ContextMenu("进入烤石头任务")]
	private void StartKaogutou()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x7346A0", Offset = "0x7346A0", VA = "0x7346A0")]
	[ContextMenu("刻字完成")]
	private void _FinishAllGame()
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x736364", Offset = "0x736364", VA = "0x736364")]
	public B_3zhenren_Game1()
	{
	}
}
[Token(Token = "0x2000045")]
public class CameraMoveAni : MonoBehaviour
{
	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator ani;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CameraMoveAni instance;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private B_3zhenren _B_3zhenren;

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x736EBC", Offset = "0x736EBC", VA = "0x736EBC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x7370C8", Offset = "0x7370C8", VA = "0x7370C8")]
	private void Start()
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x7370CC", Offset = "0x7370CC", VA = "0x7370CC")]
	private void Update()
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x7370D0", Offset = "0x7370D0", VA = "0x7370D0")]
	private void EndingMove()
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x736FF8", Offset = "0x736FF8", VA = "0x736FF8")]
	public void AddAnimationEvent(AnimationClip clip, string functionName, bool isStart = false, float offset = 0.1f)
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x7370E8", Offset = "0x7370E8", VA = "0x7370E8")]
	public CameraMoveAni()
	{
	}
}
[Token(Token = "0x2000046")]
public class ChangePos : MonoBehaviour
{
	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform vr;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool isGrip;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool UpisGrip;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform[] poses;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int index;

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x7370F0", Offset = "0x7370F0", VA = "0x7370F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x737158", Offset = "0x737158", VA = "0x737158")]
	private void Start()
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x73715C", Offset = "0x73715C", VA = "0x73715C")]
	public void InitPos()
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x7371BC", Offset = "0x7371BC", VA = "0x7371BC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x73727C", Offset = "0x73727C", VA = "0x73727C")]
	public void ChangeNextPos()
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x7372E8", Offset = "0x7372E8", VA = "0x7372E8")]
	public ChangePos()
	{
	}
}
[Token(Token = "0x2000047")]
public class DelayLoadGame : MonoBehaviour
{
	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator Camera_ani;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject vrCameraFadeAniManager;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject[] Scene;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public zhenren _zhenrenPangbai;

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x7372F0", Offset = "0x7372F0", VA = "0x7372F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x737434", Offset = "0x737434", VA = "0x737434")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x737438", Offset = "0x737438", VA = "0x737438")]
	private void Start()
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x73743C", Offset = "0x73743C", VA = "0x73743C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x737440", Offset = "0x737440", VA = "0x737440")]
	private void StartPlayGame()
	{
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x7375D8", Offset = "0x7375D8", VA = "0x7375D8")]
	public DelayLoadGame()
	{
	}
}
[Token(Token = "0x2000048")]
public class EffectCtrl : MonoBehaviour
{
	[Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class <DelayPlayEffect>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EffectCtrl <>4__this;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int index;

		[Token(Token = "0x17000035")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x7377EC", Offset = "0x7377EC", VA = "0x7377EC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x737834", Offset = "0x737834", VA = "0x737834", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x7376D0", Offset = "0x7376D0", VA = "0x7376D0")]
		[DebuggerHidden]
		public <DelayPlayEffect>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x737700", Offset = "0x737700", VA = "0x737700", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x737704", Offset = "0x737704", VA = "0x737704", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x7377F4", Offset = "0x7377F4", VA = "0x7377F4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] effects;

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x7375E0", Offset = "0x7375E0", VA = "0x7375E0")]
	private void Start()
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x7376CC", Offset = "0x7376CC", VA = "0x7376CC")]
	private void Update()
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x737638", Offset = "0x737638", VA = "0x737638")]
	[IteratorStateMachine(typeof(<DelayPlayEffect>d__3))]
	public IEnumerator DelayPlayEffect(int index, float delay = 0f)
	{
		return null;
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x7376F8", Offset = "0x7376F8", VA = "0x7376F8")]
	public EffectCtrl()
	{
	}
}
[Token(Token = "0x200004A")]
public class EnvironmentAll : MonoBehaviour
{
	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static EnvironmentAll Instance;

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x73783C", Offset = "0x73783C", VA = "0x73783C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x7378E0", Offset = "0x7378E0", VA = "0x7378E0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x7378E4", Offset = "0x7378E4", VA = "0x7378E4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x737598", Offset = "0x737598", VA = "0x737598")]
	public void ShowEnvironment()
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x7378E8", Offset = "0x7378E8", VA = "0x7378E8")]
	public void DestroySelf()
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x737954", Offset = "0x737954", VA = "0x737954")]
	public EnvironmentAll()
	{
	}
}
[Token(Token = "0x200004B")]
public enum RenderingMode
{
	[Token(Token = "0x40001C3")]
	Opaque,
	[Token(Token = "0x40001C4")]
	Cutout,
	[Token(Token = "0x40001C5")]
	Fade,
	[Token(Token = "0x40001C6")]
	Transparent
}
[Token(Token = "0x200004C")]
public class Guike : MonoBehaviour
{
	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Action FinishedAction;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string TargetName;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float CurrentTime;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float DelayTime;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Renderer[] renders;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Color[] InitColor;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<Material> mats;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool Test;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	[SerializeField]
	private bool Finished;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private int currentMatIndex;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject letteringManager;

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x73795C", Offset = "0x73795C", VA = "0x73795C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x737B54", Offset = "0x737B54", VA = "0x737B54")]
	private void Start()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x737B64", Offset = "0x737B64", VA = "0x737B64")]
	private void Update()
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x737B68", Offset = "0x737B68", VA = "0x737B68")]
	private void UpdateMat()
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x737D2C", Offset = "0x737D2C", VA = "0x737D2C")]
	public void ColliderDisappear()
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x737D88", Offset = "0x737D88", VA = "0x737D88")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x737C60", Offset = "0x737C60", VA = "0x737C60")]
	public void ChangeMat(float value, int matIndex)
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x737DD4", Offset = "0x737DD4", VA = "0x737DD4")]
	private void setMaterialRenderingMode(Material material, RenderingMode renderingMode)
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x7380A8", Offset = "0x7380A8", VA = "0x7380A8")]
	public Guike()
	{
	}
}
[Token(Token = "0x200004D")]
public class gutou : MonoBehaviour
{
	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool autoPlayAction;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private EffectAudio Firing_niugu;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool canBeTrigger;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Action FinishedAction;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Action TriggerEnterAction;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Action TriggerExitAction;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string TargetName;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string TargetName2;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float CurrentTime;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float DelayTime;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color InitColor;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Material mat;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool Test;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	[SerializeField]
	private bool Finished;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int currentMatIndex;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private GameObject letteringManager;

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x738168", Offset = "0x738168", VA = "0x738168")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x738230", Offset = "0x738230", VA = "0x738230")]
	private void Start()
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x732DC0", Offset = "0x732DC0", VA = "0x732DC0")]
	public void SetCanBeTrigger()
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x733904", Offset = "0x733904", VA = "0x733904")]
	public void SetMeshCollider()
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x738234", Offset = "0x738234", VA = "0x738234")]
	private void Update()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x738244", Offset = "0x738244", VA = "0x738244")]
	private void UpdateMat()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x734498", Offset = "0x734498", VA = "0x734498")]
	public void ColliderDisappear()
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x738338", Offset = "0x738338", VA = "0x738338")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x7383C0", Offset = "0x7383C0", VA = "0x7383C0")]
	private void AutoUpdateMat()
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x738534", Offset = "0x738534", VA = "0x738534")]
	public void DisappearFiring_niugu()
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x7385BC", Offset = "0x7385BC", VA = "0x7385BC")]
	private void OnCollisionStay(Collision collision)
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x73861C", Offset = "0x73861C", VA = "0x73861C")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x7383EC", Offset = "0x7383EC", VA = "0x7383EC")]
	private void PlayFiring_niuguAudio()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x7382D4", Offset = "0x7382D4", VA = "0x7382D4")]
	public void ChangeMat(float value)
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x738718", Offset = "0x738718", VA = "0x738718")]
	public gutou()
	{
	}
}
[Token(Token = "0x200004E")]
public class huopenTrigger : MonoBehaviour
{
	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool canTriggerFireSpark;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static huopenTrigger instance;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject FireTrigger;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string TagName;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int FireCreatCount;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int FireCreatNeedCount;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject FirePs;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool BeTrigger;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private B_3zhenren b_3Zhenren;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Action CreateFireSuccess;

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x7387A4", Offset = "0x7387A4", VA = "0x7387A4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x738858", Offset = "0x738858", VA = "0x738858")]
	private void Start()
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x73885C", Offset = "0x73885C", VA = "0x73885C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x738984", Offset = "0x738984", VA = "0x738984")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x738988", Offset = "0x738988", VA = "0x738988")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x73898C", Offset = "0x73898C", VA = "0x73898C")]
	public void CreatFire()
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x738ADC", Offset = "0x738ADC", VA = "0x738ADC")]
	private void DelayPlayAudio()
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x738BAC", Offset = "0x738BAC", VA = "0x738BAC")]
	private void DelayPlayFireAudio()
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x738C4C", Offset = "0x738C4C", VA = "0x738C4C")]
	public huopenTrigger()
	{
	}
}
[Token(Token = "0x200004F")]
public class huoshi : MonoBehaviour
{
	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string TargetName;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParticleSystem ps;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private huopenTrigger huopen;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public B_3zhenren b_3Zhenren;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string[] effectAudioNames;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int index;

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x738CB4", Offset = "0x738CB4", VA = "0x738CB4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x738F10", Offset = "0x738F10", VA = "0x738F10")]
	private void Start()
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x738F14", Offset = "0x738F14", VA = "0x738F14")]
	private void Update()
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x738F18", Offset = "0x738F18", VA = "0x738F18")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x739198", Offset = "0x739198", VA = "0x739198")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x739260", Offset = "0x739260", VA = "0x739260")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x739340", Offset = "0x739340", VA = "0x739340")]
	public huoshi()
	{
	}
}
[Token(Token = "0x2000050")]
public class kedao : MonoBehaviour
{
	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool canPlayAudio;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int index;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioClip[] clips;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioSource audioS;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int layerNumber;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Action<XRNode> DeviceTriggerEnterClick;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Action<XRNode> DeviceTriggerStayClick;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Action<XRNode> DeviceTriggerExitClick;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform point;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public XRNode Hand;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private bool isGrip;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	[SerializeField]
	private bool UpisGrip;

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x739398", Offset = "0x739398", VA = "0x739398")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x739420", Offset = "0x739420", VA = "0x739420")]
	private void Start()
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x739424", Offset = "0x739424", VA = "0x739424")]
	private void Update()
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x739778", Offset = "0x739778", VA = "0x739778")]
	private void DelayResetKeziAudio()
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x7396C8", Offset = "0x7396C8", VA = "0x7396C8")]
	private void PlayKeziAudio()
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x7396D4", Offset = "0x7396D4", VA = "0x7396D4")]
	private void PlayAudio()
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x739780", Offset = "0x739780", VA = "0x739780")]
	public kedao()
	{
	}
}
[Token(Token = "0x2000051")]
public class Lettering : MonoBehaviour
{
	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Vector3> points;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public DOTweenPath path;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int Count;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject Prefab;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public letteringManager manager;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int index;

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x739790", Offset = "0x739790", VA = "0x739790")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x7398FC", Offset = "0x7398FC", VA = "0x7398FC")]
	private void Start()
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x739900", Offset = "0x739900", VA = "0x739900")]
	private void Update()
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x739904", Offset = "0x739904", VA = "0x739904")]
	public void SetLetteringCount()
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x7399D8", Offset = "0x7399D8", VA = "0x7399D8")]
	public Lettering()
	{
	}
}
[Token(Token = "0x2000052")]
public class letteringManager : MonoBehaviour
{
	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public kedao _kedao;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Action isRiFinished;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Action isYueFinished;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Action isShuiFinished;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool ri;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool yue;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	public bool shui;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
	private bool RiFinished;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool YueFinished;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	private bool ShuiFinished;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int riSum;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int yueSum;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int shuiSum;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int offsetCount;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Action FinishedAllLetters;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Action TriggerLetters;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Lettering[] letters;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Dictionary<int, int> LetterDic;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int[] LetterSum;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool isFinised;

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x739A60", Offset = "0x739A60", VA = "0x739A60")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x739B78", Offset = "0x739B78", VA = "0x739B78")]
	private void Start()
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x739BE8", Offset = "0x739BE8", VA = "0x739BE8")]
	private void Update()
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x739BEC", Offset = "0x739BEC", VA = "0x739BEC")]
	public void UpdateCount()
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x739CA8", Offset = "0x739CA8", VA = "0x739CA8")]
	public bool UpdateCount(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x739924", Offset = "0x739924", VA = "0x739924")]
	public void SetCount(int index)
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x739E14", Offset = "0x739E14", VA = "0x739E14")]
	public letteringManager()
	{
	}
}
[Token(Token = "0x2000053")]
public class letteringPointCollider : MonoBehaviour
{
	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MyPainter painter;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Collider collider;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MeshRenderer render;

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x739E9C", Offset = "0x739E9C", VA = "0x739E9C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x739FCC", Offset = "0x739FCC", VA = "0x739FCC")]
	private void Start()
	{
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x739FD0", Offset = "0x739FD0", VA = "0x739FD0")]
	private void Update()
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x739624", Offset = "0x739624", VA = "0x739624")]
	public void PlayAciton()
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x739FD4", Offset = "0x739FD4", VA = "0x739FD4")]
	public letteringPointCollider()
	{
	}
}
[Token(Token = "0x2000054")]
public class Mukuai : MonoBehaviour
{
	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material mukuaiFadeMat;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Action FinishedAction;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string TargetName;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float CurrentTime;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float DelayTime;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Renderer[] renders;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Color InitColor;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material mat;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool Test;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	[SerializeField]
	private bool Finished;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int currentMatIndex;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private EffectAudio Firing_mukuai;

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x739FDC", Offset = "0x739FDC", VA = "0x739FDC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x73A0A0", Offset = "0x73A0A0", VA = "0x73A0A0")]
	private void Start()
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x73A0A4", Offset = "0x73A0A4", VA = "0x73A0A4")]
	private void Update()
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x733818", Offset = "0x733818", VA = "0x733818")]
	public void mukuaiDisappear()
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x73A0D0", Offset = "0x73A0D0", VA = "0x73A0D0")]
	private void UpdateMat()
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x73A1B4", Offset = "0x73A1B4", VA = "0x73A1B4")]
	public void ColliderDisappear()
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x73A210", Offset = "0x73A210", VA = "0x73A210")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x73A384", Offset = "0x73A384", VA = "0x73A384")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x73A480", Offset = "0x73A480", VA = "0x73A480")]
	private void DelayResetFiring_mukuai()
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x73A264", Offset = "0x73A264", VA = "0x73A264")]
	private void PlayFiring_mukuaiAudio()
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x73A150", Offset = "0x73A150", VA = "0x73A150")]
	public void ChangeMat(float value)
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x73A48C", Offset = "0x73A48C", VA = "0x73A48C")]
	public Mukuai()
	{
	}
}
[Token(Token = "0x2000055")]
public class Spark : MonoBehaviour
{
	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x73A558", Offset = "0x73A558", VA = "0x73A558")]
	private void Start()
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x73A55C", Offset = "0x73A55C", VA = "0x73A55C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x73A560", Offset = "0x73A560", VA = "0x73A560")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x73A5F8", Offset = "0x73A5F8", VA = "0x73A5F8")]
	public Spark()
	{
	}
}
[Token(Token = "0x2000056")]
public class VRCameraCtrlManager : MonoBehaviour
{
	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PXR_ScreenFade_X _PXR_ScreenFade;

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private B_3zhenren ren;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static VRCameraCtrlManager instance;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject[] vr;

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x73A600", Offset = "0x73A600", VA = "0x73A600")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x73A7F8", Offset = "0x73A7F8", VA = "0x73A7F8")]
	private void Start()
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x73A860", Offset = "0x73A860", VA = "0x73A860")]
	private void DelayInit()
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x73A880", Offset = "0x73A880", VA = "0x73A880")]
	private void Update()
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x73A7D8", Offset = "0x73A7D8", VA = "0x73A7D8")]
	public void InitVr()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x73A884", Offset = "0x73A884", VA = "0x73A884")]
	public void ShowVr(int index)
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x73A91C", Offset = "0x73A91C", VA = "0x73A91C")]
	public VRCameraCtrlManager()
	{
	}
}
[Token(Token = "0x2000057")]
public class VRCameraFadeAniMananger2 : MonoBehaviour
{
	[Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class <ChangeCameraIE4>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VRCameraFadeAniMananger2 <>4__this;

		[Token(Token = "0x17000037")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x73B6E0", Offset = "0x73B6E0", VA = "0x73B6E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x73B728", Offset = "0x73B728", VA = "0x73B728", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x73AB7C", Offset = "0x73AB7C", VA = "0x73AB7C")]
		[DebuggerHidden]
		public <ChangeCameraIE4>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x73B4F0", Offset = "0x73B4F0", VA = "0x73B4F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x73B4F4", Offset = "0x73B4F4", VA = "0x73B4F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x73B6E8", Offset = "0x73B6E8", VA = "0x73B6E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class <ChangeCameraIE3>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VRCameraFadeAniMananger2 <>4__this;

		[Token(Token = "0x17000039")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0x73BB90", Offset = "0x73BB90", VA = "0x73BB90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x73BBD8", Offset = "0x73BBD8", VA = "0x73BBD8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x73AC18", Offset = "0x73AC18", VA = "0x73AC18")]
		[DebuggerHidden]
		public <ChangeCameraIE3>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x73B7B4", Offset = "0x73B7B4", VA = "0x73B7B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x73B7B8", Offset = "0x73B7B8", VA = "0x73B7B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x73BB98", Offset = "0x73BB98", VA = "0x73BB98", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class <ChangeCameraIE2>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VRCameraFadeAniMananger2 <>4__this;

		[Token(Token = "0x1700003B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x73BFB0", Offset = "0x73BFB0", VA = "0x73BFB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000309")]
			[Address(RVA = "0x73BFF8", Offset = "0x73BFF8", VA = "0x73BFF8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x73ACB4", Offset = "0x73ACB4", VA = "0x73ACB4")]
		[DebuggerHidden]
		public <ChangeCameraIE2>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x73BBE0", Offset = "0x73BBE0", VA = "0x73BBE0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x73BBE4", Offset = "0x73BBE4", VA = "0x73BBE4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x73BFB8", Offset = "0x73BFB8", VA = "0x73BFB8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class <UnloadAllObj>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VRCameraFadeAniMananger2 <>4__this;

		[Token(Token = "0x1700003D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x73C388", Offset = "0x73C388", VA = "0x73C388", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600030F")]
			[Address(RVA = "0x73C3D0", Offset = "0x73C3D0", VA = "0x73C3D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x73AD50", Offset = "0x73AD50", VA = "0x73AD50")]
		[DebuggerHidden]
		public <UnloadAllObj>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x73C000", Offset = "0x73C000", VA = "0x73C000", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x73C004", Offset = "0x73C004", VA = "0x73C004", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x73C390", Offset = "0x73C390", VA = "0x73C390", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float ChangeSceneDelay;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Color PXR_FadeColor;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject effect;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AudioSource[] audios;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float GCTime;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public PXR_ScreenFade_X _PXR_ScreenFade;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Tween moveTw;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform target;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static VRCameraFadeAniMananger2 instance;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public B_3zhenren _B_3zhenren;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Sean_SceneBase scene;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject[] vr;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Transform suidao;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Transform suidaoMove;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Transform vr0;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Transform vr1;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject TestEnvironmet;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float suidaoMoveZTime;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject OBJS;

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x73A924", Offset = "0x73A924", VA = "0x73A924")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x73AAC8", Offset = "0x73AAC8", VA = "0x73AAC8")]
	private void Start()
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x73AACC", Offset = "0x73AACC", VA = "0x73AACC")]
	private void Update()
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x73AB08", Offset = "0x73AB08", VA = "0x73AB08")]
	[IteratorStateMachine(typeof(<ChangeCameraIE4>d__22))]
	private IEnumerator ChangeCameraIE4()
	{
		return null;
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x73ABA4", Offset = "0x73ABA4", VA = "0x73ABA4")]
	[IteratorStateMachine(typeof(<ChangeCameraIE3>d__23))]
	private IEnumerator ChangeCameraIE3()
	{
		return null;
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x73AC40", Offset = "0x73AC40", VA = "0x73AC40")]
	[IteratorStateMachine(typeof(<ChangeCameraIE2>d__24))]
	private IEnumerator ChangeCameraIE2()
	{
		return null;
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x733EBC", Offset = "0x733EBC", VA = "0x733EBC")]
	public void ChangeVRCamera()
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x73ACDC", Offset = "0x73ACDC", VA = "0x73ACDC")]
	[IteratorStateMachine(typeof(<UnloadAllObj>d__26))]
	public IEnumerator UnloadAllObj()
	{
		return null;
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x73AD78", Offset = "0x73AD78", VA = "0x73AD78")]
	public void ReleaseMemory()
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x73AD98", Offset = "0x73AD98", VA = "0x73AD98")]
	public void DestroySceneObjs()
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x73AE7C", Offset = "0x73AE7C", VA = "0x73AE7C")]
	public void DestroySelf()
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x73AF70", Offset = "0x73AF70", VA = "0x73AF70")]
	public void SetVRPos(Transform target)
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x73B054", Offset = "0x73B054", VA = "0x73B054")]
	public VRCameraFadeAniMananger2()
	{
	}
}
[Token(Token = "0x200005D")]
public class zhenren : MonoBehaviour
{
	[Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class <DelaySetChangeAudioFalse>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public zhenren <>4__this;

		[Token(Token = "0x1700003F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x73C97C", Offset = "0x73C97C", VA = "0x73C97C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x73C9C4", Offset = "0x73C9C4", VA = "0x73C9C4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x73C6A4", Offset = "0x73C6A4", VA = "0x73C6A4")]
		[DebuggerHidden]
		public <DelaySetChangeAudioFalse>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x73C8C4", Offset = "0x73C8C4", VA = "0x73C8C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x73C8C8", Offset = "0x73C8C8", VA = "0x73C8C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x73C984", Offset = "0x73C984", VA = "0x73C984", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioSource jisiBGM;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool CanReplayAni;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static zhenren Instance;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioClip[] clips;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AudioSource source;

	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Animator zhenrenAni;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject jisiXunhuanAudio;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool ChangeAudio;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject effectAudios;

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x73C3D8", Offset = "0x73C3D8", VA = "0x73C3D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x73C630", Offset = "0x73C630", VA = "0x73C630")]
	[IteratorStateMachine(typeof(<DelaySetChangeAudioFalse>d__10))]
	private IEnumerator DelaySetChangeAudioFalse()
	{
		return null;
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x73C6CC", Offset = "0x73C6CC", VA = "0x73C6CC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x73C6D0", Offset = "0x73C6D0", VA = "0x73C6D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x731980", Offset = "0x731980", VA = "0x731980")]
	public void PlayAudio(int index)
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x731868", Offset = "0x731868", VA = "0x731868")]
	public void ChangeBGMAudioVolum(float value = 0.7f, float delay = 1f)
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x73C77C", Offset = "0x73C77C", VA = "0x73C77C")]
	private void PlayJisixunhuanAudio()
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x733DB0", Offset = "0x733DB0", VA = "0x733DB0")]
	public void PlayChangeSceneAudios()
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x73C804", Offset = "0x73C804", VA = "0x73C804")]
	public void AddAnimationEvent(AnimationClip clip, string functionName, float offset = 0f)
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x73C8B4", Offset = "0x73C8B4", VA = "0x73C8B4")]
	public zhenren()
	{
	}
}
[Token(Token = "0x200005F")]
public class B_4XXJG : Sean_SceneBase
{
	[Token(Token = "0x6000320")]
	[Address(RVA = "0x73C9CC", Offset = "0x73C9CC", VA = "0x73C9CC")]
	private new void Awake()
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0x73CA58", Offset = "0x73CA58", VA = "0x73CA58")]
	private void Start()
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x73CA5C", Offset = "0x73CA5C", VA = "0x73CA5C")]
	public B_4XXJG()
	{
	}
}
[Token(Token = "0x2000060")]
public class B_4XXJG_Game1 : Sean_GameBase
{
	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public LTZ_Night ltz;

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x73CA64", Offset = "0x73CA64", VA = "0x73CA64")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x73CAE8", Offset = "0x73CAE8", VA = "0x73CAE8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x73CAEC", Offset = "0x73CAEC", VA = "0x73CAEC")]
	private void Ani_1_IsEnd()
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x73CB3C", Offset = "0x73CB3C", VA = "0x73CB3C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x73CB40", Offset = "0x73CB40", VA = "0x73CB40")]
	public void AddAnimationEvent(AnimationClip clip, string functionName, float offset = 0.1f)
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x73CBF0", Offset = "0x73CBF0", VA = "0x73CBF0")]
	public B_4XXJG_Game1()
	{
	}
}
[Token(Token = "0x2000061")]
public class changeScene : MonoBehaviour
{
	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SpriteRenderer sprite;

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Hand testhand;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isPress;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool isPress2;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	private bool isLoadScene;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Image circleImg;

	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float Delay;

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x73CBF8", Offset = "0x73CBF8", VA = "0x73CBF8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x73CC6C", Offset = "0x73CC6C", VA = "0x73CC6C")]
	private void Start()
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x73CC70", Offset = "0x73CC70", VA = "0x73CC70")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x73CCE8", Offset = "0x73CCE8", VA = "0x73CCE8")]
	private void Update()
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x73CE80", Offset = "0x73CE80", VA = "0x73CE80")]
	public changeScene()
	{
	}
}
[Token(Token = "0x2000062")]
public class LTZ_Night : MonoBehaviour
{
	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static LTZ_Night instance;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator currentAni;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Animator ClothAni;

	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Animator ClothAni2;

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AudioSource audios;

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x73CE90", Offset = "0x73CE90", VA = "0x73CE90")]
	private void Awake()
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x73D118", Offset = "0x73D118", VA = "0x73D118")]
	private void Start()
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x73D11C", Offset = "0x73D11C", VA = "0x73D11C")]
	public void StartPlayAni()
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x73D1FC", Offset = "0x73D1FC", VA = "0x73D1FC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x73D068", Offset = "0x73D068", VA = "0x73D068")]
	public void AddAnimationEvent(AnimationClip clip, string functionName, float offset = 0.1f)
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x73D200", Offset = "0x73D200", VA = "0x73D200")]
	public void FadeToNextScene()
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0x73D284", Offset = "0x73D284", VA = "0x73D284")]
	private void Ani_1_IsEnd()
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0x73D2D4", Offset = "0x73D2D4", VA = "0x73D2D4")]
	public LTZ_Night()
	{
	}
}
[Token(Token = "0x2000063")]
public class VRCameraCtrlManager2 : MonoBehaviour
{
	[Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class <startPlay>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VRCameraCtrlManager2 <>4__this;

		[Token(Token = "0x17000041")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x73D814", Offset = "0x73D814", VA = "0x73D814", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x73D85C", Offset = "0x73D85C", VA = "0x73D85C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x73D510", Offset = "0x73D510", VA = "0x73D510")]
		[DebuggerHidden]
		public <startPlay>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x73D718", Offset = "0x73D718", VA = "0x73D718", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x73D71C", Offset = "0x73D71C", VA = "0x73D71C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x73D81C", Offset = "0x73D81C", VA = "0x73D81C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class <StartShowShuxinSceneIE>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VRCameraCtrlManager2 <>4__this;

		[Token(Token = "0x17000043")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000349")]
			[Address(RVA = "0x73DCF8", Offset = "0x73DCF8", VA = "0x73DCF8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600034B")]
			[Address(RVA = "0x73DD40", Offset = "0x73DD40", VA = "0x73DD40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x73D644", Offset = "0x73D644", VA = "0x73D644")]
		[DebuggerHidden]
		public <StartShowShuxinSceneIE>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x73D864", Offset = "0x73D864", VA = "0x73D864", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x73D868", Offset = "0x73D868", VA = "0x73D868", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x73DD00", Offset = "0x73DD00", VA = "0x73DD00", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MediaPlayer Player;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject ChangeScene;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public AudioClip shuxinAudio;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public AudioClip jiaguAudio;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AudioSource shuxinAudioS;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AudioSource jiaguAudioS;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AudioSource BGMAudios;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material jiaguSkybox;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public PXR_ScreenFade_X _PXR_ScreenFade;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject shuxin_Scene;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject jiagu_Scene;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Color FogInitColor;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public B_4XXJG _B_4XXJG;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static VRCameraCtrlManager2 instance;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject[] vr;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject[] SceneObjs;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float jiaguDelay;

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x73D2DC", Offset = "0x73D2DC", VA = "0x73D2DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x73D47C", Offset = "0x73D47C", VA = "0x73D47C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x73D49C", Offset = "0x73D49C", VA = "0x73D49C")]
	[IteratorStateMachine(typeof(<startPlay>d__19))]
	private IEnumerator startPlay()
	{
		return null;
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x73D538", Offset = "0x73D538", VA = "0x73D538")]
	private void Update()
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x73B33C", Offset = "0x73B33C", VA = "0x73B33C")]
	public void InitVr()
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x73D264", Offset = "0x73D264", VA = "0x73D264")]
	public void StartShowShuxinScene()
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x73D5D0", Offset = "0x73D5D0", VA = "0x73D5D0")]
	[IteratorStateMachine(typeof(<StartShowShuxinSceneIE>d__23))]
	public IEnumerator StartShowShuxinSceneIE()
	{
		return null;
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0x73D66C", Offset = "0x73D66C", VA = "0x73D66C")]
	private void ChangeSkybox(Material newSkybox)
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0x73D678", Offset = "0x73D678", VA = "0x73D678")]
	public void ShowVr(int index)
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0x73D710", Offset = "0x73D710", VA = "0x73D710")]
	public VRCameraCtrlManager2()
	{
	}
}
[Token(Token = "0x2000066")]
public class GameCountCtrl : MonoBehaviour
{
	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isLockBowuguan;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int Count;

	[Token(Token = "0x17000045")]
	public static GameCountCtrl Instance
	{
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x73DD48", Offset = "0x73DD48", VA = "0x73DD48")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x73DD90", Offset = "0x73DD90", VA = "0x73DD90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x73DDE8", Offset = "0x73DDE8", VA = "0x73DDE8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x73DFB4", Offset = "0x73DFB4", VA = "0x73DFB4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x73DFB8", Offset = "0x73DFB8", VA = "0x73DFB8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x73DFBC", Offset = "0x73DFBC", VA = "0x73DFBC")]
	public GameCountCtrl()
	{
	}
}
[Token(Token = "0x2000067")]
public class LOGO : Sean_SceneBase
{
	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Sprite sprite;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public MediaPlayer player2;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool canPlayAciton;

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x73DFC4", Offset = "0x73DFC4", VA = "0x73DFC4")]
	private new void Awake()
	{
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x73E704", Offset = "0x73E704", VA = "0x73E704")]
	private void Init()
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x73E778", Offset = "0x73E778", VA = "0x73E778")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x73E8B8", Offset = "0x73E8B8", VA = "0x73E8B8")]
	protected void PlayerEvent2(MediaPlayer arg0, MediaPlayerEvent.EventType arg1, ErrorCode arg2)
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x73E8F4", Offset = "0x73E8F4", VA = "0x73E8F4", Slot = "6")]
	protected virtual void _PlayerEvent()
	{
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x73E9BC", Offset = "0x73E9BC", VA = "0x73E9BC")]
	protected void PlayerEvent3(MediaPlayer arg0, MediaPlayerEvent.EventType arg1, ErrorCode arg2)
	{
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x73EA70", Offset = "0x73EA70", VA = "0x73EA70")]
	private new void Update()
	{
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x73EB68", Offset = "0x73EB68", VA = "0x73EB68")]
	public LOGO()
	{
	}
}
[Token(Token = "0x2000068")]
public class LOGO_0 : Sean_GameBase
{
	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private SpriteRenderer[] prologue;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Tween[] tws;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<string, bool> IshitDict;

	[Token(Token = "0x600035A")]
	[Address(RVA = "0x73EB78", Offset = "0x73EB78", VA = "0x73EB78")]
	private void Awake()
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x73ECA0", Offset = "0x73ECA0", VA = "0x73ECA0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x73ED64", Offset = "0x73ED64", VA = "0x73ED64")]
	private void Start()
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x73F1D8", Offset = "0x73F1D8", VA = "0x73F1D8")]
	private void RayOnClick(XRNode xR, RaycastHit obj)
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x73F3A0", Offset = "0x73F3A0", VA = "0x73F3A0")]
	private void DelayToNextScene()
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x73F3BC", Offset = "0x73F3BC", VA = "0x73F3BC")]
	private void RayOnEnter(XRNode xR, RaycastHit obj)
	{
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0x73F7E4", Offset = "0x73F7E4", VA = "0x73F7E4")]
	private void RayOnExit2(XRNode xR, string obj)
	{
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0x73F484", Offset = "0x73F484", VA = "0x73F484")]
	public void UIDoScale(Transform uiTrans)
	{
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0x73F7EC", Offset = "0x73F7EC", VA = "0x73F7EC")]
	public void UIResetScale(string name)
	{
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0x73FB90", Offset = "0x73FB90", VA = "0x73FB90")]
	[ContextMenu("放大UI1")]
	public void dfer1()
	{
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x73FBD0", Offset = "0x73FBD0", VA = "0x73FBD0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x73FD88", Offset = "0x73FD88", VA = "0x73FD88")]
	public LOGO_0()
	{
	}
}
[Token(Token = "0x2000069")]
public class UICtrl : MonoBehaviour
{
	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private SpriteRenderer spriteRenderer;

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x73FF60", Offset = "0x73FF60", VA = "0x73FF60")]
	private void Awake()
	{
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x73FFB8", Offset = "0x73FFB8", VA = "0x73FFB8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x73FFCC", Offset = "0x73FFCC", VA = "0x73FFCC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x73FFD0", Offset = "0x73FFD0", VA = "0x73FFD0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x73FFD4", Offset = "0x73FFD4", VA = "0x73FFD4")]
	public UICtrl()
	{
	}
}
[Token(Token = "0x200006A")]
public class VoiceDelay : MonoBehaviour
{
	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isFirstLoad;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static VoiceDelay Instance;

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x73FFDC", Offset = "0x73FFDC", VA = "0x73FFDC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0x740080", Offset = "0x740080", VA = "0x740080")]
	private void Start()
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x740084", Offset = "0x740084", VA = "0x740084")]
	private void Update()
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x740088", Offset = "0x740088", VA = "0x740088")]
	public VoiceDelay()
	{
	}
}
[Token(Token = "0x200006B")]
public class SceneCite : UnityInstance<SceneCite>
{
	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected List<string> SceneObjsPath;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected List<string> SceneDestroyObjsPath;

	[Token(Token = "0x17000046")]
	public List<Transform> SceneObjCite
	{
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x740090", Offset = "0x740090", VA = "0x740090")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x740098", Offset = "0x740098", VA = "0x740098")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0x7400A0", Offset = "0x7400A0", VA = "0x7400A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0x74015C", Offset = "0x74015C", VA = "0x74015C")]
	public void Init()
	{
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0x740478", Offset = "0x740478", VA = "0x740478")]
	public SceneCite()
	{
	}
}
[Token(Token = "0x200006C")]
public class ARCameraTest : MonoBehaviour
{
	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float MoveSpeed;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float RotateSpeed;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float X;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float Y;

	[Token(Token = "0x600037C")]
	[Address(RVA = "0x740568", Offset = "0x740568", VA = "0x740568")]
	private void Start()
	{
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0x74056C", Offset = "0x74056C", VA = "0x74056C")]
	private void Update()
	{
	}

	[Token(Token = "0x600037E")]
	[Address(RVA = "0x740A5C", Offset = "0x740A5C", VA = "0x740A5C")]
	public ARCameraTest()
	{
	}
}
[Token(Token = "0x200006D")]
public class DeviceEventBase : MonoBehaviour
{
	[Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class <DelayResetInitIE>d__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DeviceEventBase <>4__this;

		[Token(Token = "0x17000047")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x7412AC", Offset = "0x7412AC", VA = "0x7412AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x7412F4", Offset = "0x7412F4", VA = "0x7412F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x7411C4", Offset = "0x7411C4", VA = "0x7411C4")]
		[DebuggerHidden]
		public <DelayResetInitIE>d__49(int <>1__state)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x7411EC", Offset = "0x7411EC", VA = "0x7411EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x7411F0", Offset = "0x7411F0", VA = "0x7411F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x7412B4", Offset = "0x7412B4", VA = "0x7412B4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isOnInitPos;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool BeGrapping;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool canPlayEffect;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool isForceReset;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ResetDelay;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float CurrentTime;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Action DeviceOnClick;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Action<XRNode, RaycastHit> RayOnEnter;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Action<XRNode, RaycastHit> RayOnStay;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Action<XRNode, RaycastHit> RayOnExit;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Action<XRNode, string> RayOnExit2;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Action<XRNode, RaycastHit> RayOnEnterClick;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Action<XRNode, RaycastHit> RayOnStayClick;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Action<XRNode, RaycastHit> RayOnExitClick;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Action<Collider, DeviceEventBase> ThisTriggerEnter;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Action<Collider, DeviceEventBase> ThisTriggerStay;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Action<Collider, DeviceEventBase> ThisTriggerExit;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Action<Collision> ThisCollisionEnter;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Action<Collision> ThisCollisionStay;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Action<Collision> ThisCollisionExit;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Action<Collider> DeviceTriggerEnter;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Action<Collider> DeviceTriggerStay;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Action<Collider> DeviceTriggerExit;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Action<Sean_HandBase> DeviceTriggerEnterClick;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Action<Sean_HandBase> DeviceTriggerStayClick;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Action<Sean_HandBase> DeviceTriggerExitClick;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Action<Sean_HandBase, DeviceEventBase> DeviceTriggerEnterClick2;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Action<Sean_HandBase, DeviceEventBase> DeviceTriggerStayClick2;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Action<Sean_HandBase, DeviceEventBase> DeviceTriggerExitClick2;

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Action<string> HandGrapSound;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Action<string> HandReleaseSound;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public Action<XRNode> HandRelease;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Action<XRNode, DeviceEventBase> HandRelease2;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Action<XRNode> ResetInitStateEvent;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public bool isObjcatch;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
	public bool isShake;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public List<string> CloseName;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public Vector3 pos;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	public Vector3 ro;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	[SerializeField]
	private Rigidbody rig;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public GlowControl effect;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public XRNode hand;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public XRGrabInteractable_X _XRGrabInteractable_X;

	[Token(Token = "0x600037F")]
	[Address(RVA = "0x740A70", Offset = "0x740A70", VA = "0x740A70")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0x740B44", Offset = "0x740B44", VA = "0x740B44")]
	public void ResetInitPos(Vector3 pos, Vector3 rot)
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0x740B60", Offset = "0x740B60", VA = "0x740B60")]
	protected void OnEnable()
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0x740D24", Offset = "0x740D24", VA = "0x740D24")]
	private void Update()
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x740D84", Offset = "0x740D84", VA = "0x740D84")]
	public void ForceReset()
	{
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x732620", Offset = "0x732620", VA = "0x732620")]
	public void DelayResetInit(float delay = 3f)
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x740D94", Offset = "0x740D94", VA = "0x740D94")]
	[IteratorStateMachine(typeof(<DelayResetInitIE>d__49))]
	private IEnumerator DelayResetInitIE(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x740E18", Offset = "0x740E18", VA = "0x740E18")]
	public void DisableEffect()
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x734354", Offset = "0x734354", VA = "0x734354")]
	public void ResetInitState()
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0x740E9C", Offset = "0x740E9C", VA = "0x740E9C")]
	public void StopHandTips()
	{
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x740EA0", Offset = "0x740EA0", VA = "0x740EA0")]
	private void CloseObj(Collision collision)
	{
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x741054", Offset = "0x741054", VA = "0x741054")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x741074", Offset = "0x741074", VA = "0x741074")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x741094", Offset = "0x741094", VA = "0x741094")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x7410B4", Offset = "0x7410B4", VA = "0x7410B4")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x7410F4", Offset = "0x7410F4", VA = "0x7410F4")]
	private void OnCollisionStay(Collision collision)
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x741110", Offset = "0x741110", VA = "0x741110")]
	private void OnCollisionExit(Collision collision)
	{
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0x74112C", Offset = "0x74112C", VA = "0x74112C")]
	public DeviceEventBase()
	{
	}
}
[Token(Token = "0x200006F")]
public class FingersValue : MonoBehaviour
{
	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public float _Thumb;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[HideInInspector]
	public float _Index;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public float _Middle;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[HideInInspector]
	public float _Ring;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public float _Pinky;

	[Token(Token = "0x6000397")]
	[Address(RVA = "0x7412FC", Offset = "0x7412FC", VA = "0x7412FC")]
	public FingersValue(float _Thumb, float _Index, float _Middle, float _Ring, float _Pinky)
	{
	}
}
[Token(Token = "0x2000070")]
public class Sean_DeviceController : MonoBehaviour
{
	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool hasRigCollision;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected InputFeatureUsage<bool> Key;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public Transform LeftLine;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public Transform RightLine;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	public Transform LeftHand;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	public Transform RightHand;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Sean_LeftLine sean_LeftLine;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Sean_RightLine sean_RightLine;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Sean_LeftHand sean_LeftHand;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Sean_RightHand sean_RightHand;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameplayHand GameplayHand_left;

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameplayHand GameplayHand_right;

	[Token(Token = "0x6000398")]
	[Address(RVA = "0x74134C", Offset = "0x74134C", VA = "0x74134C")]
	public void Init()
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x741898", Offset = "0x741898", VA = "0x741898")]
	public void SetHandNoTrigger(bool trueOrFalse = true)
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x7418C4", Offset = "0x7418C4", VA = "0x7418C4")]
	public bool SendHapticImpulse(bool RL, float amplitude, float duration)
	{
		return default(bool);
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x74194C", Offset = "0x74194C", VA = "0x74194C")]
	public void SetKey(InputFeatureUsage<bool> key)
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x7419D8", Offset = "0x7419D8", VA = "0x7419D8")]
	public void SetHandObjPa(Transform pa, Transform LeftPos, Transform RightPos)
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0x741F9C", Offset = "0x741F9C", VA = "0x741F9C")]
	public void SetHandObjPa(Transform pa)
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x741FDC", Offset = "0x741FDC", VA = "0x741FDC")]
	public void SetLine(bool isShow)
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x742038", Offset = "0x742038", VA = "0x742038")]
	public void SetGameplayHand(float value)
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x742060", Offset = "0x742060", VA = "0x742060")]
	public void AddGameplayHandFingerValue(string GripObj, FingersValue fingers)
	{
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x7420F0", Offset = "0x7420F0", VA = "0x7420F0")]
	public Sean_DeviceController()
	{
	}
}
[Token(Token = "0x2000071")]
public class Sean_DeviceKey : MonoBehaviour
{
	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected bool[] iskey;

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected bool[] Upiskey;

	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected XRNode Hand;

	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected InputFeatureUsage<bool> Key;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected List<Action<bool>> KeyEvent;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected List<Action> KeyDownEvent;

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x742164", Offset = "0x742164", VA = "0x742164")]
	protected void Awake()
	{
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x74245C", Offset = "0x74245C", VA = "0x74245C")]
	protected void Update()
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x7426FC", Offset = "0x7426FC", VA = "0x7426FC")]
	public Sean_DeviceKey()
	{
	}
}
[Token(Token = "0x2000073")]
public class Sean_GameBase : MonoBehaviour
{
	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Action action;

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Sean_SceneBase SceneBase;

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x742854", Offset = "0x742854", VA = "0x742854")]
	public Sean_GameBase()
	{
	}
}
[Token(Token = "0x2000074")]
public class Sean_HandBase : MonoBehaviour
{
	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected DeviceEventBase objBase;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool UpisGrip;

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool isGrip;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform TransObj;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public XRNode Hand;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public InputFeatureUsage<bool> Key;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public Sean_DeviceController sean_Device;

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x74285C", Offset = "0x74285C", VA = "0x74285C")]
	public Sean_HandBase()
	{
	}
}
[Token(Token = "0x2000075")]
public class Sean_LeftHand : Sean_HandBase
{
	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool HasTrigger;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool hasRigCollision;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public SpriteRenderer Tips;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Tween tipsTw;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float TipsCount;

	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool startTipsCounting;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected Tween DoMove;

	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool NoTrigger;

	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected List<string> ObjcatchName;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected List<Transform> Poss;

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Transform Pos;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private GameplayHand _GameplayHand;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Sean_DeviceController Controller;

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x74286C", Offset = "0x74286C", VA = "0x74286C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x7428C4", Offset = "0x7428C4", VA = "0x7428C4")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x741A40", Offset = "0x741A40", VA = "0x741A40")]
	public void UpdatePoss(Transform pos)
	{
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x742D7C", Offset = "0x742D7C", VA = "0x742D7C")]
	public SpriteRenderer ReShowHandTips()
	{
		return null;
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x742F40", Offset = "0x742F40", VA = "0x742F40")]
	protected void Update()
	{
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x743940", Offset = "0x743940", VA = "0x743940")]
	protected void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x743A58", Offset = "0x743A58", VA = "0x743A58")]
	protected void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x743B5C", Offset = "0x743B5C", VA = "0x743B5C")]
	protected void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x743C54", Offset = "0x743C54", VA = "0x743C54")]
	public Sean_LeftHand()
	{
	}
}
[Token(Token = "0x2000076")]
public class Sean_LeftLine : Sean_HandBase
{
	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool isLogoUIScene;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	protected RaycastHit hit;

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float RayDistance;

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x743D34", Offset = "0x743D34", VA = "0x743D34")]
	protected void Update()
	{
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x744380", Offset = "0x744380", VA = "0x744380")]
	public Sean_LeftLine()
	{
	}
}
[Token(Token = "0x2000077")]
public class Sean_RightHand : Sean_LeftHand
{
	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x744398", Offset = "0x744398", VA = "0x744398")]
	public Sean_RightHand()
	{
	}
}
[Token(Token = "0x2000078")]
public class Sean_RightLine : Sean_LeftLine
{
	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x74439C", Offset = "0x74439C", VA = "0x74439C")]
	public Sean_RightLine()
	{
	}
}
[Token(Token = "0x2000079")]
[RequireComponent(typeof(SceneCite))]
public class Sean_SceneBase : MonoBehaviour
{
	[Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class <UnloadSceneAsync>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string sceneName;

		[Token(Token = "0x1700004A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x7458DC", Offset = "0x7458DC", VA = "0x7458DC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x745924", Offset = "0x745924", VA = "0x745924", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x744AFC", Offset = "0x744AFC", VA = "0x744AFC")]
		[DebuggerHidden]
		public <UnloadSceneAsync>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x745754", Offset = "0x745754", VA = "0x745754", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x745758", Offset = "0x745758", VA = "0x745758", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x7458E4", Offset = "0x7458E4", VA = "0x7458E4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class <UnloadAllObj>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Sean_SceneBase <>4__this;

		[Token(Token = "0x1700004C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x745BA0", Offset = "0x745BA0", VA = "0x745BA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x745BE8", Offset = "0x745BE8", VA = "0x745BE8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x744B98", Offset = "0x744B98", VA = "0x744B98")]
		[DebuggerHidden]
		public <UnloadAllObj>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x74592C", Offset = "0x74592C", VA = "0x74592C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x745930", Offset = "0x745930", VA = "0x745930", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x745BA8", Offset = "0x745BA8", VA = "0x745BA8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class <DelayChange>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Sean_SceneBase <>4__this;

		[Token(Token = "0x1700004E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x745CA8", Offset = "0x745CA8", VA = "0x745CA8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x745CF0", Offset = "0x745CF0", VA = "0x745CF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x744C54", Offset = "0x744C54", VA = "0x744C54")]
		[DebuggerHidden]
		public <DelayChange>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x745BF0", Offset = "0x745BF0", VA = "0x745BF0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x745BF4", Offset = "0x745BF4", VA = "0x745BF4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x745CB0", Offset = "0x745CB0", VA = "0x745CB0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class <LoadLevelAdd>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Sean_SceneBase <>4__this;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AsyncOperation <async>5__2;

		[Token(Token = "0x17000050")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x745F24", Offset = "0x745F24", VA = "0x745F24", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x745F6C", Offset = "0x745F6C", VA = "0x745F6C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x744CF0", Offset = "0x744CF0", VA = "0x744CF0")]
		[DebuggerHidden]
		public <LoadLevelAdd>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x745CF8", Offset = "0x745CF8", VA = "0x745CF8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x745CFC", Offset = "0x745CFC", VA = "0x745CFC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x745F2C", Offset = "0x745F2C", VA = "0x745F2C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200007E")]
	[CompilerGenerated]
	private sealed class <LoadLevelAdd_NoVideo>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Sean_SceneBase <>4__this;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AsyncOperation <async>5__2;

		[Token(Token = "0x17000052")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x746100", Offset = "0x746100", VA = "0x746100", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x746148", Offset = "0x746148", VA = "0x746148", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x744D8C", Offset = "0x744D8C", VA = "0x744D8C")]
		[DebuggerHidden]
		public <LoadLevelAdd_NoVideo>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x745F74", Offset = "0x745F74", VA = "0x745F74", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x745F78", Offset = "0x745F78", VA = "0x745F78", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x746108", Offset = "0x746108", VA = "0x746108", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float GCTime;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Sean_DeviceController sean_Device;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool hasRigCollision;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	private bool isPress;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	private bool isLoadScene;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	public bool HasNoVideo;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	protected List<GameObject> games;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	protected int num;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	protected bool VideoPlayStop;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	protected Vector3 TestCameraPos;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string SceneName;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string AddSceneName;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	protected List<GameObject> SceneObjs;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool isGrip;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
	private bool UpisGrip;

	[Token(Token = "0x17000049")]
	public MediaPlayer player
	{
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x7443B4", Offset = "0x7443B4", VA = "0x7443B4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x7443BC", Offset = "0x7443BC", VA = "0x7443BC")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x7443C4", Offset = "0x7443C4", VA = "0x7443C4")]
	protected void Awake()
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x744A88", Offset = "0x744A88", VA = "0x744A88")]
	[IteratorStateMachine(typeof(<UnloadSceneAsync>d__18))]
	public IEnumerator UnloadSceneAsync(string sceneName)
	{
		return null;
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x744B24", Offset = "0x744B24", VA = "0x744B24")]
	[IteratorStateMachine(typeof(<UnloadAllObj>d__19))]
	public IEnumerator UnloadAllObj()
	{
		return null;
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x744BC0", Offset = "0x744BC0", VA = "0x744BC0")]
	public void ReleaseMemory()
	{
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x744BE0", Offset = "0x744BE0", VA = "0x744BE0")]
	[IteratorStateMachine(typeof(<DelayChange>d__21))]
	protected IEnumerator DelayChange()
	{
		return null;
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x744C7C", Offset = "0x744C7C", VA = "0x744C7C")]
	[IteratorStateMachine(typeof(<LoadLevelAdd>d__22))]
	private IEnumerator LoadLevelAdd()
	{
		return null;
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x744D18", Offset = "0x744D18", VA = "0x744D18")]
	[IteratorStateMachine(typeof(<LoadLevelAdd_NoVideo>d__23))]
	private IEnumerator LoadLevelAdd_NoVideo()
	{
		return null;
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x7444F8", Offset = "0x7444F8", VA = "0x7444F8")]
	protected void StartObj()
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x744E70", Offset = "0x744E70", VA = "0x744E70", Slot = "4")]
	protected virtual void StartGame()
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x744F80", Offset = "0x744F80", VA = "0x744F80")]
	protected void Update()
	{
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x7451FC", Offset = "0x7451FC", VA = "0x7451FC")]
	protected void PlayerEvent(MediaPlayer arg0, MediaPlayerEvent.EventType arg1, ErrorCode arg2)
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x745214", Offset = "0x745214", VA = "0x745214", Slot = "5")]
	protected virtual void PlayerEvent()
	{
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x745220", Offset = "0x745220", VA = "0x745220")]
	protected void Close(GameObject game)
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x744DB4", Offset = "0x744DB4", VA = "0x744DB4")]
	public void SetLine(bool isShose)
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x744DD0", Offset = "0x744DD0", VA = "0x744DD0")]
	public void SetSceneObjs(bool isShow)
	{
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x745348", Offset = "0x745348", VA = "0x745348")]
	public void DestroySceneObjs()
	{
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x74554C", Offset = "0x74554C", VA = "0x74554C")]
	public void AddPlayerEvent(string path, [Optional] Action ac)
	{
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x74513C", Offset = "0x74513C", VA = "0x74513C")]
	public void Next()
	{
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x74562C", Offset = "0x74562C", VA = "0x74562C")]
	public void LoadToNextScene()
	{
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x74564C", Offset = "0x74564C", VA = "0x74564C")]
	public Sean_SceneBase()
	{
	}
}
[Token(Token = "0x2000080")]
public class EffectAudio : MonoBehaviour
{
	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioSource audioS;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool startPlay;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float MaxVolume;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform target;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool hasTarget;

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x746170", Offset = "0x746170", VA = "0x746170")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x7461C8", Offset = "0x7461C8", VA = "0x7461C8")]
	private void Start()
	{
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x7461CC", Offset = "0x7461CC", VA = "0x7461CC")]
	public void SetSpaceAudio(float minDistance = 1f, float maxDistance = 500f)
	{
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x746240", Offset = "0x746240", VA = "0x746240")]
	private void Update()
	{
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x746314", Offset = "0x746314", VA = "0x746314")]
	public void RePlay(bool IsForceStopLastAudio = true)
	{
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x746354", Offset = "0x746354", VA = "0x746354")]
	public void OnPlayMusic(AudioClip clip, float volume)
	{
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x7463B4", Offset = "0x7463B4", VA = "0x7463B4")]
	public void RepeatPlayMusic(AudioClip clip, float volume)
	{
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x74641C", Offset = "0x74641C", VA = "0x74641C")]
	public void StopRepeatPlay()
	{
	}

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x74644C", Offset = "0x74644C", VA = "0x74644C")]
	public void DisappearAudio(float delay = 1f)
	{
	}

	[Token(Token = "0x60003F9")]
	[Address(RVA = "0x746514", Offset = "0x746514", VA = "0x746514")]
	public void AddVolume(float offset)
	{
	}

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x74659C", Offset = "0x74659C", VA = "0x74659C")]
	public void SetVolume(float Volume)
	{
	}

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0x7465B8", Offset = "0x7465B8", VA = "0x7465B8")]
	public void SetTarget(Transform target)
	{
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x7465DC", Offset = "0x7465DC", VA = "0x7465DC")]
	public void SetLoop(bool Isloop = true)
	{
	}

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0x7465FC", Offset = "0x7465FC", VA = "0x7465FC")]
	public EffectAudio()
	{
	}
}
[Token(Token = "0x2000081")]
public class EffectAudioMananger : MonoBehaviour
{
	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip BG;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioSource source;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static EffectAudioMananger instance;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AudioClip[] clips;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Dictionary<string, AudioClip> audioClipDic;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject effectAudioPrefab;

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x746678", Offset = "0x746678", VA = "0x746678")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0x746868", Offset = "0x746868", VA = "0x746868")]
	private void Start()
	{
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0x74686C", Offset = "0x74686C", VA = "0x74686C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0x746870", Offset = "0x746870", VA = "0x746870")]
	public EffectAudio PlayAudio(string name, float volume = 1f)
	{
		return null;
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0x746968", Offset = "0x746968", VA = "0x746968")]
	public EffectAudio PlayAudio(string name, Transform trans, float offsetX = 0f, float offsetY = 0f, float offsetZ = 0f, float volume = 1f, float minDistance = 1f, float maxDistance = 500f, bool hasParent = true, bool hasTarget = false)
	{
		return null;
	}

	[Token(Token = "0x6000404")]
	[Address(RVA = "0x746B1C", Offset = "0x746B1C", VA = "0x746B1C")]
	public EffectAudio RepeatPlayAudio(string name, float volume = 1f)
	{
		return null;
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0x746C14", Offset = "0x746C14", VA = "0x746C14")]
	public EffectAudio RepeatPlayAudio(string name, Transform trans, float offsetX = 0f, float offsetY = 0f, float offsetZ = 0f, float volume = 1f, float minDistance = 1f, float maxDistance = 500f, bool hasParent = true)
	{
		return null;
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0x746DA4", Offset = "0x746DA4", VA = "0x746DA4")]
	public void SetBGMusic(string name, float Volume = 0.2f)
	{
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0x746E3C", Offset = "0x746E3C", VA = "0x746E3C")]
	public void PlayBGMusic(float Volume = 0.5f)
	{
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0x746EF4", Offset = "0x746EF4", VA = "0x746EF4")]
	public void StopBGMusic(float delay = 1f)
	{
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0x746F84", Offset = "0x746F84", VA = "0x746F84")]
	public EffectAudioMananger()
	{
	}
}
[Token(Token = "0x2000082")]
public class FogCtrl : MonoBehaviour
{
	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static FogCtrl instance;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float DelayTime;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private Color color;

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool startChangeValue;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float InitValue;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float currentValue;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Tween tw;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Tween tw2;

	[Token(Token = "0x600040A")]
	[Address(RVA = "0x74700C", Offset = "0x74700C", VA = "0x74700C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0x747064", Offset = "0x747064", VA = "0x747064")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0x747068", Offset = "0x747068", VA = "0x747068")]
	private void Start()
	{
	}

	[Token(Token = "0x600040D")]
	[Address(RVA = "0x7470A0", Offset = "0x7470A0", VA = "0x7470A0")]
	private void Update()
	{
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0x7470A4", Offset = "0x7470A4", VA = "0x7470A4")]
	public void StartExponentialSquaredFog(Color color, float fogDensity = 0.1f)
	{
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0x7470D0", Offset = "0x7470D0", VA = "0x7470D0")]
	public void StartAppearFog(float _time)
	{
	}

	[Token(Token = "0x6000410")]
	[Address(RVA = "0x74743C", Offset = "0x74743C", VA = "0x74743C")]
	public void StartAppearFog(float _Starttime, float _endtime, float StartDistance, float fogEndDistance, float StartEnd, float EndEnd)
	{
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0x7477CC", Offset = "0x7477CC", VA = "0x7477CC")]
	public void DisappearFog(float _Starttime, float _endtime, float StartDistance, float fogEndDistance, float StartEnd, float EndEnd)
	{
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0x747C58", Offset = "0x747C58", VA = "0x747C58")]
	public void SetFogIsEnbale(bool isEnable)
	{
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0x747C64", Offset = "0x747C64", VA = "0x747C64")]
	public void SetFogIsEnbale(bool isEnable, float start, float end)
	{
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0x747C9C", Offset = "0x747C9C", VA = "0x747C9C")]
	[ContextMenu("变黑")]
	public void dfer()
	{
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0x747CA4", Offset = "0x747CA4", VA = "0x747CA4")]
	[ContextMenu("变亮")]
	public void dfer2()
	{
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0x747CAC", Offset = "0x747CAC", VA = "0x747CAC")]
	public FogCtrl()
	{
	}
}
[Token(Token = "0x2000085")]
public class NPCUI : MonoBehaviour
{
	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isLockRot;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RawImage raw;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform rt;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform targetObj;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SpriteRenderer NPC_UI;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Quaternion IniRot;

	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float InitY;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float InitX;

	[Token(Token = "0x6000428")]
	[Address(RVA = "0x747DCC", Offset = "0x747DCC", VA = "0x747DCC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0x747EE4", Offset = "0x747EE4", VA = "0x747EE4")]
	private void Start()
	{
	}

	[Token(Token = "0x600042A")]
	[Address(RVA = "0x747FA0", Offset = "0x747FA0", VA = "0x747FA0")]
	private void Update()
	{
	}

	[Token(Token = "0x600042B")]
	[Address(RVA = "0x748038", Offset = "0x748038", VA = "0x748038")]
	public Vector2 WorldToUGUIPos(RectTransform canvasRT, Camera camera, Vector3 worldPos)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0x7480D4", Offset = "0x7480D4", VA = "0x7480D4")]
	public NPCUI()
	{
	}
}
[Token(Token = "0x2000087")]
public class SendHapticImpulse : MonoBehaviour
{
	[Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class <SendHighHapticImpulseIEMoreTimesIE>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SendHapticImpulse <>4__this;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool RL;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float amplitude;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float duration;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float frequency;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int Times;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int <times>5__2;

		[Token(Token = "0x17000054")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x748854", Offset = "0x748854", VA = "0x748854", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x74889C", Offset = "0x74889C", VA = "0x74889C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x748504", Offset = "0x748504", VA = "0x748504")]
		[DebuggerHidden]
		public <SendHighHapticImpulseIEMoreTimesIE>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x74873C", Offset = "0x74873C", VA = "0x74873C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x748740", Offset = "0x748740", VA = "0x748740", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x74885C", Offset = "0x74885C", VA = "0x74885C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class <_SendHapticImpulseIE>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float duration;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SendHapticImpulse <>4__this;

		[Token(Token = "0x17000056")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0x748968", Offset = "0x748968", VA = "0x748968", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x7489B0", Offset = "0x7489B0", VA = "0x7489B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x7485B0", Offset = "0x7485B0", VA = "0x7485B0")]
		[DebuggerHidden]
		public <_SendHapticImpulseIE>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x7488A4", Offset = "0x7488A4", VA = "0x7488A4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x7488A8", Offset = "0x7488A8", VA = "0x7488A8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x748970", Offset = "0x748970", VA = "0x748970", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class <_SendHapticImpulseIE_R>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SendHapticImpulse <>4__this;

		[Token(Token = "0x17000058")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x748AEC", Offset = "0x748AEC", VA = "0x748AEC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x748B34", Offset = "0x748B34", VA = "0x748B34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x74864C", Offset = "0x74864C", VA = "0x74864C")]
		[DebuggerHidden]
		public <_SendHapticImpulseIE_R>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x7489B8", Offset = "0x7489B8", VA = "0x7489B8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x7489BC", Offset = "0x7489BC", VA = "0x7489BC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x748AF4", Offset = "0x748AF4", VA = "0x748AF4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class <_SendHapticImpulseIE_L>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SendHapticImpulse <>4__this;

		[Token(Token = "0x1700005A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000453")]
			[Address(RVA = "0x748C74", Offset = "0x748C74", VA = "0x748C74", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x748CBC", Offset = "0x748CBC", VA = "0x748CBC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x7486E8", Offset = "0x7486E8", VA = "0x7486E8")]
		[DebuggerHidden]
		public <_SendHapticImpulseIE_L>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x748B3C", Offset = "0x748B3C", VA = "0x748B3C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x748B40", Offset = "0x748B40", VA = "0x748B40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x748C7C", Offset = "0x748C7C", VA = "0x748C7C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static SendHapticImpulse Instance;

	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool startImpulse;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool RL;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Sean_DeviceController sean_Device;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float amplitude;

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float duration;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Coroutine leftHand;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Coroutine rightHand;

	[Token(Token = "0x6000432")]
	[Address(RVA = "0x748354", Offset = "0x748354", VA = "0x748354")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000433")]
	[Address(RVA = "0x7483AC", Offset = "0x7483AC", VA = "0x7483AC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0x74840C", Offset = "0x74840C", VA = "0x74840C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000435")]
	[Address(RVA = "0x748410", Offset = "0x748410", VA = "0x748410")]
	public void _SendHapticImpulse(bool RL, float amplitude, float duration = 1f)
	{
	}

	[Token(Token = "0x6000436")]
	[Address(RVA = "0x74842C", Offset = "0x74842C", VA = "0x74842C")]
	public void SendHighHapticImpulseIEMoreTimes(bool RL, float amplitude = 0.99f, float duration = 1f, int Times = 3, float frequency = 0.25f)
	{
	}

	[Token(Token = "0x6000437")]
	[Address(RVA = "0x748450", Offset = "0x748450", VA = "0x748450")]
	[IteratorStateMachine(typeof(<SendHighHapticImpulseIEMoreTimesIE>d__13))]
	public IEnumerator SendHighHapticImpulseIEMoreTimesIE(bool RL, float amplitude, float duration, int Times, float frequency)
	{
		return null;
	}

	[Token(Token = "0x6000438")]
	[Address(RVA = "0x74852C", Offset = "0x74852C", VA = "0x74852C")]
	[IteratorStateMachine(typeof(<_SendHapticImpulseIE>d__14))]
	private IEnumerator _SendHapticImpulseIE(bool RL, float amplitude, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000439")]
	[Address(RVA = "0x7485D8", Offset = "0x7485D8", VA = "0x7485D8")]
	[IteratorStateMachine(typeof(<_SendHapticImpulseIE_R>d__15))]
	private IEnumerator _SendHapticImpulseIE_R()
	{
		return null;
	}

	[Token(Token = "0x600043A")]
	[Address(RVA = "0x748674", Offset = "0x748674", VA = "0x748674")]
	[IteratorStateMachine(typeof(<_SendHapticImpulseIE_L>d__16))]
	private IEnumerator _SendHapticImpulseIE_L()
	{
		return null;
	}

	[Token(Token = "0x600043B")]
	[Address(RVA = "0x742E98", Offset = "0x742E98", VA = "0x742E98")]
	public void StartSendHapticImpulse(bool RL)
	{
	}

	[Token(Token = "0x600043C")]
	[Address(RVA = "0x748710", Offset = "0x748710", VA = "0x748710")]
	public void StopSendHapticImpulse(bool RL)
	{
	}

	[Token(Token = "0x600043D")]
	[Address(RVA = "0x748734", Offset = "0x748734", VA = "0x748734")]
	public SendHapticImpulse()
	{
	}
}
[Token(Token = "0x200008C")]
public class SwitchTest : MonoBehaviour
{
	[Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class <ChangeCameraIE4>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SwitchTest <>4__this;

		[Token(Token = "0x1700005C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000465")]
			[Address(RVA = "0x7495D4", Offset = "0x7495D4", VA = "0x7495D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000467")]
			[Address(RVA = "0x74961C", Offset = "0x74961C", VA = "0x74961C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x748F64", Offset = "0x748F64", VA = "0x748F64")]
		[DebuggerHidden]
		public <ChangeCameraIE4>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x749350", Offset = "0x749350", VA = "0x749350", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x749354", Offset = "0x749354", VA = "0x749354", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x7495DC", Offset = "0x7495DC", VA = "0x7495DC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class <UnloadAllObj>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SwitchTest <>4__this;

		[Token(Token = "0x1700005E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600046B")]
			[Address(RVA = "0x749770", Offset = "0x749770", VA = "0x749770", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x7497B8", Offset = "0x7497B8", VA = "0x7497B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x749000", Offset = "0x749000", VA = "0x749000")]
		[DebuggerHidden]
		public <UnloadAllObj>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x749624", Offset = "0x749624", VA = "0x749624", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x749628", Offset = "0x749628", VA = "0x749628", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x749778", Offset = "0x749778", VA = "0x749778", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool isPress;

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool isLoadScene;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioSource audio;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float GCTime;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public PXR_ScreenFade_X _PXR_ScreenFade;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Tween moveTw;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject liutizi;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform target;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static SwitchTest instance;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public B_2XXJG _B2XXJG;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Sean_SceneBase scene;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject[] vr;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform suidao;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform suidaoMove;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Transform vr0;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Transform vr1;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject TestEnvironmet;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float suidaoMoveZTime;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public string NextScene;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject obj;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public string FadeScene;

	[Token(Token = "0x6000456")]
	[Address(RVA = "0x748CC4", Offset = "0x748CC4", VA = "0x748CC4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0x748DF4", Offset = "0x748DF4", VA = "0x748DF4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0x748DF8", Offset = "0x748DF8", VA = "0x748DF8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0x748EF0", Offset = "0x748EF0", VA = "0x748EF0")]
	[IteratorStateMachine(typeof(<ChangeCameraIE4>d__24))]
	private IEnumerator ChangeCameraIE4()
	{
		return null;
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0x748ED0", Offset = "0x748ED0", VA = "0x748ED0")]
	public void ChangeVRCamera()
	{
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0x748F8C", Offset = "0x748F8C", VA = "0x748F8C")]
	[IteratorStateMachine(typeof(<UnloadAllObj>d__26))]
	public IEnumerator UnloadAllObj()
	{
		return null;
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0x749028", Offset = "0x749028", VA = "0x749028")]
	public void ReleaseMemory()
	{
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0x749048", Offset = "0x749048", VA = "0x749048")]
	public void DestroySceneObjs()
	{
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0x749060", Offset = "0x749060", VA = "0x749060")]
	public void DestroySelf()
	{
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0x749154", Offset = "0x749154", VA = "0x749154")]
	public void SetVRPos(Transform target)
	{
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0x749238", Offset = "0x749238", VA = "0x749238")]
	public SwitchTest()
	{
	}
}
[Token(Token = "0x200008F")]
public enum GongjvStyle
{
	[Token(Token = "0x4000378")]
	None,
	[Token(Token = "0x4000379")]
	chuizi,
	[Token(Token = "0x400037A")]
	shuazi,
	[Token(Token = "0x400037B")]
	zhuizi
}
[Token(Token = "0x2000090")]
public class XRGrabInteractable_X : XRGrabInteractable
{
	[Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class <FreezeRotIE>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public XRGrabInteractable_X <>4__this;

		[Token(Token = "0x17000060")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x74AAD8", Offset = "0x74AAD8", VA = "0x74AAD8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x74AB20", Offset = "0x74AB20", VA = "0x74AB20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x749DF4", Offset = "0x749DF4", VA = "0x749DF4")]
		[DebuggerHidden]
		public <FreezeRotIE>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x74A9F0", Offset = "0x74A9F0", VA = "0x74A9F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x74A9F4", Offset = "0x74A9F4", VA = "0x74A9F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x74AAE0", Offset = "0x74AAE0", VA = "0x74AAE0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class <SetHandStaticIE>d__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public XRGrabInteractable_X <>4__this;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform tr;

		[Token(Token = "0x17000062")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x74ACB0", Offset = "0x74ACB0", VA = "0x74ACB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x74ACF8", Offset = "0x74ACF8", VA = "0x74ACF8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x74A608", Offset = "0x74A608", VA = "0x74A608")]
		[DebuggerHidden]
		public <SetHandStaticIE>d__38(int <>1__state)
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x74AB28", Offset = "0x74AB28", VA = "0x74AB28", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x74AB2C", Offset = "0x74AB2C", VA = "0x74AB2C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x74ACB8", Offset = "0x74ACB8", VA = "0x74ACB8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	public ShuaiZiTest test;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
	public GongjvStyle style;

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
	private chuizi1 chuizi;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
	public Animator BrushAni;

	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
	private bool isCollison;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
	public Transform brushPointTrans;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
	public Vector3 StartBrush_pos;

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E4")]
	public Vector3 StopBrush_pos;

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
	public bool canGrap;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
	public string TargetName;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
	public uint handIndex;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
	[SerializeField]
	private Sean_HandBase sean_HandBase;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
	public DeviceEventBase _DeviceEventBase;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
	public Sean_LeftHand leftHand;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
	public Sean_RightHand righHand;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
	public float FreezeDelay;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
	public Transform leftAttachTransform;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
	public Transform rightAttachTransform;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
	private Vector3 InitHandPos;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34C")]
	private Quaternion InitHandRot;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
	public Transform handTR;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
	public Transform handCotroller;

	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
	private Vector3 InitScale;

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
	private Transform LastAttachTrans;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
	private Rigidbody rig;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
	private Coroutine freezeCor;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
	private bool isFreeze;

	[Token(Token = "0x600046E")]
	[Address(RVA = "0x7497C0", Offset = "0x7497C0", VA = "0x7497C0")]
	private new void Awake()
	{
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0x749928", Offset = "0x749928", VA = "0x749928")]
	private void Start()
	{
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0x74997C", Offset = "0x74997C", VA = "0x74997C")]
	private void DelaySetHands()
	{
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0x749B08", Offset = "0x749B08", VA = "0x749B08")]
	private void Update()
	{
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0x749B88", Offset = "0x749B88", VA = "0x749B88")]
	private Quaternion BrushAngles()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0x749C74", Offset = "0x749C74", VA = "0x749C74")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000474")]
	[Address(RVA = "0x749D80", Offset = "0x749D80", VA = "0x749D80")]
	[IteratorStateMachine(typeof(<FreezeRotIE>d__33))]
	private IEnumerator FreezeRotIE()
	{
		return null;
	}

	[Token(Token = "0x6000475")]
	[Address(RVA = "0x749E1C", Offset = "0x749E1C", VA = "0x749E1C")]
	private void OnCollisionStay(Collision collision)
	{
	}

	[Token(Token = "0x6000476")]
	[Address(RVA = "0x749EC8", Offset = "0x749EC8", VA = "0x749EC8")]
	private void OnCollisionExit(Collision collision)
	{
	}

	[Token(Token = "0x6000477")]
	[Address(RVA = "0x74A028", Offset = "0x74A028", VA = "0x74A028", Slot = "65")]
	protected override void OnSelectEntering(SelectEnterEventArgs args)
	{
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0x74A02C", Offset = "0x74A02C", VA = "0x74A02C", Slot = "66")]
	protected override void OnSelectEntered(SelectEnterEventArgs args)
	{
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0x74A578", Offset = "0x74A578", VA = "0x74A578")]
	[IteratorStateMachine(typeof(<SetHandStaticIE>d__38))]
	private IEnumerator SetHandStaticIE(Transform tr)
	{
		return null;
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0x74A630", Offset = "0x74A630", VA = "0x74A630", Slot = "68")]
	protected override void OnSelectExited(SelectExitEventArgs args)
	{
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0x74A828", Offset = "0x74A828", VA = "0x74A828")]
	public void OnSelectExitedSelf()
	{
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0x74A958", Offset = "0x74A958", VA = "0x74A958")]
	public XRGrabInteractable_X()
	{
	}
}
[Token(Token = "0x2000093")]
public class ABLoadFile : MonoBehaviour
{
	[Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class <ABBaoJiaZai>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ABLoadFile <>4__this;

		[Token(Token = "0x17000064")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x74B34C", Offset = "0x74B34C", VA = "0x74B34C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000065")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x74B394", Offset = "0x74B394", VA = "0x74B394", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x74AFE4", Offset = "0x74AFE4", VA = "0x74AFE4")]
		[DebuggerHidden]
		public <ABBaoJiaZai>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x74B094", Offset = "0x74B094", VA = "0x74B094", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x74B098", Offset = "0x74B098", VA = "0x74B098", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x74B354", Offset = "0x74B354", VA = "0x74B354", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool DontDestroySelf;

	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AssetBundleCreateRequest request;

	[Token(Token = "0x40003A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ABLoadFile instance;

	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<string> filenameList;

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string filePath;

	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Action FinishedLoadCallBack;

	[Token(Token = "0x6000489")]
	[Address(RVA = "0x74AD00", Offset = "0x74AD00", VA = "0x74AD00")]
	private void Awake()
	{
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0x74AEA4", Offset = "0x74AEA4", VA = "0x74AEA4")]
	public void Reload(string name)
	{
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0x7454B8", Offset = "0x7454B8", VA = "0x7454B8")]
	public void DestroySelf()
	{
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0x74AF68", Offset = "0x74AF68", VA = "0x74AF68")]
	private void Start()
	{
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0x74AF6C", Offset = "0x74AF6C", VA = "0x74AF6C")]
	private void Update()
	{
	}

	[Token(Token = "0x600048E")]
	[Address(RVA = "0x74AE1C", Offset = "0x74AE1C", VA = "0x74AE1C")]
	public bool DetectHasFile(string fileName)
	{
		return default(bool);
	}

	[Token(Token = "0x600048F")]
	[Address(RVA = "0x74AE78", Offset = "0x74AE78", VA = "0x74AE78")]
	public void StartLoadAB(string path)
	{
	}

	[Token(Token = "0x6000490")]
	[Address(RVA = "0x74AF70", Offset = "0x74AF70", VA = "0x74AF70")]
	[IteratorStateMachine(typeof(<ABBaoJiaZai>d__13))]
	private IEnumerator ABBaoJiaZai()
	{
		return null;
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0x74B00C", Offset = "0x74B00C", VA = "0x74B00C")]
	public ABLoadFile()
	{
	}
}
[Token(Token = "0x2000095")]
public class AssetDownCtr : MonoBehaviour
{
	[Token(Token = "0x2000096")]
	public delegate void CallBack();

	[Token(Token = "0x2000097")]
	public delegate void CallBack<in T>(T arg);

	[Token(Token = "0x2000098")]
	public delegate void CallBack<in T, in X>(T arg1, X arg2);

	[Token(Token = "0x2000099")]
	public delegate void CallBack<in T, in X, in Y>(T arg1, X arg2, Y arg3);

	[Token(Token = "0x200009A")]
	public delegate void CallBack<in T, in X, in Y, in Z>(T arg1, X arg2, Y arg3, Z arg4);

	[Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class <_LoadAssetsForServer>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string url;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string fileName;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AssetDownCtr <>4__this;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public CallBack action;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <quest>5__2;

		[Token(Token = "0x17000066")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x74CAE0", Offset = "0x74CAE0", VA = "0x74CAE0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x74CB28", Offset = "0x74CB28", VA = "0x74CB28", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x74B4F4", Offset = "0x74B4F4", VA = "0x74B4F4")]
		[DebuggerHidden]
		public <_LoadAssetsForServer>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x74C5D8", Offset = "0x74C5D8", VA = "0x74C5D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x74C5F4", Offset = "0x74C5F4", VA = "0x74C5F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x74CA30", Offset = "0x74CA30", VA = "0x74CA30")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x74CAE8", Offset = "0x74CAE8", VA = "0x74CAE8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class <DownloadFileForServer>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string url;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CallBack<float> callBack;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string fileSavePath;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UnityWebRequest <request>5__2;

		[Token(Token = "0x17000068")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x74CD18", Offset = "0x74CD18", VA = "0x74CD18", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x74CD60", Offset = "0x74CD60", VA = "0x74CD60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x74B5C0", Offset = "0x74B5C0", VA = "0x74B5C0")]
		[DebuggerHidden]
		public <DownloadFileForServer>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x74CB30", Offset = "0x74CB30", VA = "0x74CB30", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x74CB34", Offset = "0x74CB34", VA = "0x74CB34", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x74CD20", Offset = "0x74CD20", VA = "0x74CD20", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<string> filenameList;

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<UnityWebRequest> unityWebRequestList;

	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int downAssetNum;

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool isForceUpdate;

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	private bool isAlreadyLoadScenes;

	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string nextSceneName;

	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private UnityWebRequest OnlyUWR;

	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Slider progressSlider;

	[Token(Token = "0x40003AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Text tintText;

	[Token(Token = "0x40003B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string versionFilename;

	[Token(Token = "0x40003B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string remoteFilename;

	[Token(Token = "0x40003B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int localVersion;

	[Token(Token = "0x40003B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int remoteVersion;

	[Token(Token = "0x40003B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Action DownSuccessEvent;

	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private byte[] results;

	[Token(Token = "0x6000498")]
	[Address(RVA = "0x74B39C", Offset = "0x74B39C", VA = "0x74B39C")]
	public void LoadAssetsForServer2(string uri, string fileName, CallBack action)
	{
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0x74B434", Offset = "0x74B434", VA = "0x74B434")]
	[IteratorStateMachine(typeof(<_LoadAssetsForServer>d__21))]
	private IEnumerator _LoadAssetsForServer(string url, string fileName, CallBack action)
	{
		return null;
	}

	[Token(Token = "0x600049A")]
	[Address(RVA = "0x74B51C", Offset = "0x74B51C", VA = "0x74B51C")]
	[IteratorStateMachine(typeof(<DownloadFileForServer>d__22))]
	private IEnumerator DownloadFileForServer(string url, string resSaveName, string fileSavePath, CallBack<float> callBack)
	{
		return null;
	}

	[Token(Token = "0x600049B")]
	[Address(RVA = "0x74B5E8", Offset = "0x74B5E8", VA = "0x74B5E8")]
	public void SaveFile(byte[] res, string savePath, string fileUrl, CallBack action)
	{
	}

	[Token(Token = "0x600049C")]
	[Address(RVA = "0x74B900", Offset = "0x74B900", VA = "0x74B900")]
	private void Awake()
	{
	}

	[Token(Token = "0x600049D")]
	[Address(RVA = "0x74B944", Offset = "0x74B944", VA = "0x74B944")]
	private void Start()
	{
	}

	[Token(Token = "0x600049E")]
	[Address(RVA = "0x74BD28", Offset = "0x74BD28", VA = "0x74BD28")]
	private void Update()
	{
	}

	[Token(Token = "0x600049F")]
	[Address(RVA = "0x74BE0C", Offset = "0x74BE0C", VA = "0x74BE0C")]
	private bool DetectAllHasFile()
	{
		return default(bool);
	}

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0x74BF70", Offset = "0x74BF70", VA = "0x74BF70")]
	private void LoadAsset()
	{
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0x74C244", Offset = "0x74C244", VA = "0x74C244")]
	private void LoadScenes()
	{
	}

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0x74C2EC", Offset = "0x74C2EC", VA = "0x74C2EC")]
	private void CallAction()
	{
	}

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0x74B964", Offset = "0x74B964", VA = "0x74B964")]
	private int GetLocalVersioin(string filename)
	{
		return default(int);
	}

	[Token(Token = "0x60004A4")]
	[Address(RVA = "0x74BC6C", Offset = "0x74BC6C", VA = "0x74BC6C")]
	private void GetRemoteVersion()
	{
	}

	[Token(Token = "0x60004A5")]
	[Address(RVA = "0x74C364", Offset = "0x74C364", VA = "0x74C364")]
	private void CompreVersion()
	{
	}

	[Token(Token = "0x60004A6")]
	[Address(RVA = "0x74BEA4", Offset = "0x74BEA4", VA = "0x74BEA4")]
	public bool DetectHasFile(string fileName)
	{
		return default(bool);
	}

	[Token(Token = "0x60004A7")]
	[Address(RVA = "0x74C470", Offset = "0x74C470", VA = "0x74C470")]
	public AssetDownCtr()
	{
	}
}
[Token(Token = "0x200009D")]
public class MingDanCtrl : MonoBehaviour
{
	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshRenderer meshRenderer;

	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x74CD68", Offset = "0x74CD68", VA = "0x74CD68")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004CA")]
	[Address(RVA = "0x74CDE4", Offset = "0x74CDE4", VA = "0x74CDE4")]
	private void Start()
	{
	}

	[Token(Token = "0x60004CB")]
	[Address(RVA = "0x74CDE8", Offset = "0x74CDE8", VA = "0x74CDE8")]
	private void Update()
	{
	}

	[Token(Token = "0x60004CC")]
	[Address(RVA = "0x74CDEC", Offset = "0x74CDEC", VA = "0x74CDEC")]
	public void EnableMeshRenderer()
	{
	}

	[Token(Token = "0x60004CD")]
	[Address(RVA = "0x74CE0C", Offset = "0x74CE0C", VA = "0x74CE0C")]
	public MingDanCtrl()
	{
	}
}
[Token(Token = "0x200009E")]
public class AndroidRouse : MonoBehaviour
{
	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AndroidJavaObject Rouse;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Thread thread;

	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x74CE14", Offset = "0x74CE14", VA = "0x74CE14")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004CF")]
	[Address(RVA = "0x74CE20", Offset = "0x74CE20", VA = "0x74CE20")]
	private void Start()
	{
	}

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x74CE2C", Offset = "0x74CE2C", VA = "0x74CE2C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x74CE30", Offset = "0x74CE30", VA = "0x74CE30")]
	public void Init()
	{
	}

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x74D0C0", Offset = "0x74D0C0", VA = "0x74D0C0")]
	public void SetWithNoSleep()
	{
	}

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0x74D1B0", Offset = "0x74D1B0", VA = "0x74D1B0")]
	public void SetRestoreSettings()
	{
	}

	[Token(Token = "0x60004D4")]
	[Address(RVA = "0x74D33C", Offset = "0x74D33C", VA = "0x74D33C")]
	public void AndroidLockScreen()
	{
	}

	[Token(Token = "0x60004D5")]
	[Address(RVA = "0x74D42C", Offset = "0x74D42C", VA = "0x74D42C")]
	public void Close()
	{
	}

	[Token(Token = "0x60004D6")]
	[Address(RVA = "0x74D44C", Offset = "0x74D44C", VA = "0x74D44C")]
	public AndroidRouse()
	{
	}
}
[Token(Token = "0x200009F")]
public enum EffectSortType
{
	[Token(Token = "0x40003C7")]
	First,
	[Token(Token = "0x40003C8")]
	Second,
	[Token(Token = "0x40003C9")]
	Third
}
[Token(Token = "0x20000A0")]
public class JGFinishEffectCtrl : MonoBehaviour
{
	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform fireLine;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform fireFlak;

	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ParticleSystem.MainModule fireLineMainModule;

	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ParticleSystem.MainModule fireFlakMainModule;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private ParticleSystem.EmissionModule fireLineEmission;

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private ParticleSystem.EmissionModule fireFlakEmission;

	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public EffectSortType effectSortType;

	[Token(Token = "0x60004D7")]
	[Address(RVA = "0x74D454", Offset = "0x74D454", VA = "0x74D454")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004D8")]
	[Address(RVA = "0x74D5D4", Offset = "0x74D5D4", VA = "0x74D5D4")]
	private void Start()
	{
	}

	[Token(Token = "0x60004D9")]
	[Address(RVA = "0x74D5D8", Offset = "0x74D5D8", VA = "0x74D5D8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60004DA")]
	[Address(RVA = "0x74D62C", Offset = "0x74D62C", VA = "0x74D62C")]
	private void Update()
	{
	}

	[Token(Token = "0x60004DB")]
	[Address(RVA = "0x74D5DC", Offset = "0x74D5DC", VA = "0x74D5DC")]
	public void DisableEffect()
	{
	}

	[Token(Token = "0x60004DC")]
	[Address(RVA = "0x74D630", Offset = "0x74D630", VA = "0x74D630")]
	public void EnableEffect(EffectSortType effectSortType = EffectSortType.First)
	{
	}

	[Token(Token = "0x60004DD")]
	[Address(RVA = "0x74DB50", Offset = "0x74DB50", VA = "0x74DB50")]
	public JGFinishEffectCtrl()
	{
	}
}
[Token(Token = "0x20000A1")]
public class JGFinishEffectCtrl_All : MonoBehaviour
{
	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform fireLine;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem.MainModule fireLineMainModule;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ParticleSystem.EmissionModule fireLineEmission;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ParticleSystem.ShapeModule fireLineShapeModule;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float radius;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float rate;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float originalRadius;

	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float originalRate;

	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float targetRadius;

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float targetRate;

	[Token(Token = "0x60004DE")]
	[Address(RVA = "0x74DB58", Offset = "0x74DB58", VA = "0x74DB58")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004DF")]
	[Address(RVA = "0x74DC24", Offset = "0x74DC24", VA = "0x74DC24")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60004E0")]
	[Address(RVA = "0x74DDC8", Offset = "0x74DDC8", VA = "0x74DDC8")]
	private void Update()
	{
	}

	[Token(Token = "0x60004E1")]
	[Address(RVA = "0x74DE1C", Offset = "0x74DE1C", VA = "0x74DE1C")]
	public JGFinishEffectCtrl_All()
	{
	}
}
[Token(Token = "0x20000A2")]
public class JiaGuFlowCtrl : MonoBehaviour
{
	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform guPianTrans;

	[Token(Token = "0x40003DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int matIndex;

	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Material material;

	[Token(Token = "0x60004E6")]
	[Address(RVA = "0x74DE60", Offset = "0x74DE60", VA = "0x74DE60")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004E7")]
	[Address(RVA = "0x74DFF0", Offset = "0x74DFF0", VA = "0x74DFF0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60004E8")]
	[Address(RVA = "0x74E094", Offset = "0x74E094", VA = "0x74E094")]
	private void Update()
	{
	}

	[Token(Token = "0x60004E9")]
	[Address(RVA = "0x74E098", Offset = "0x74E098", VA = "0x74E098")]
	public void EnableFlowEffect()
	{
	}

	[Token(Token = "0x60004EA")]
	[Address(RVA = "0x74DFF4", Offset = "0x74DFF4", VA = "0x74DFF4")]
	public void DisableFlowEffect()
	{
	}

	[Token(Token = "0x60004EB")]
	[Address(RVA = "0x74E138", Offset = "0x74E138", VA = "0x74E138")]
	public JiaGuFlowCtrl()
	{
	}
}
[Token(Token = "0x20000A3")]
public class ShuCtrl : MonoBehaviour
{
	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform shuTransform;

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Material shuMaterial;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float duration;

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Tween tween;

	[Token(Token = "0x60004EC")]
	[Address(RVA = "0x74E148", Offset = "0x74E148", VA = "0x74E148")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004ED")]
	[Address(RVA = "0x74E250", Offset = "0x74E250", VA = "0x74E250")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60004EE")]
	[Address(RVA = "0x74E31C", Offset = "0x74E31C", VA = "0x74E31C")]
	private void Start()
	{
	}

	[Token(Token = "0x60004EF")]
	[Address(RVA = "0x74E320", Offset = "0x74E320", VA = "0x74E320")]
	private void Update()
	{
	}

	[Token(Token = "0x60004F0")]
	[Address(RVA = "0x74E324", Offset = "0x74E324", VA = "0x74E324")]
	public void EnableEffect()
	{
	}

	[Token(Token = "0x60004F1")]
	[Address(RVA = "0x74E254", Offset = "0x74E254", VA = "0x74E254")]
	public void DisableEffect()
	{
	}

	[Token(Token = "0x60004F2")]
	[Address(RVA = "0x74E428", Offset = "0x74E428", VA = "0x74E428")]
	public ShuCtrl()
	{
	}
}
[Token(Token = "0x20000A4")]
public class CameraCtrl : MonoBehaviour
{
	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool isMove;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform targetTrans;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float duration;

	[Token(Token = "0x60004F3")]
	[Address(RVA = "0x74E438", Offset = "0x74E438", VA = "0x74E438")]
	private void Start()
	{
	}

	[Token(Token = "0x60004F4")]
	[Address(RVA = "0x74E43C", Offset = "0x74E43C", VA = "0x74E43C")]
	private void Update()
	{
	}

	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x74E4E0", Offset = "0x74E4E0", VA = "0x74E4E0")]
	public CameraCtrl()
	{
	}
}
[Token(Token = "0x20000A5")]
public class EffectControl : MonoBehaviour
{
	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Material> materialList;

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x74E4FC", Offset = "0x74E4FC", VA = "0x74E4FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x74E5B0", Offset = "0x74E5B0", VA = "0x74E5B0")]
	private void Start()
	{
	}

	[Token(Token = "0x60004F8")]
	[Address(RVA = "0x74E5B4", Offset = "0x74E5B4", VA = "0x74E5B4")]
	private void Update()
	{
	}

	[Token(Token = "0x60004F9")]
	[Address(RVA = "0x74E500", Offset = "0x74E500", VA = "0x74E500")]
	public void DisableFlowEffect()
	{
	}

	[Token(Token = "0x60004FA")]
	[Address(RVA = "0x74E5B8", Offset = "0x74E5B8", VA = "0x74E5B8")]
	public void EnableFlowEffect()
	{
	}

	[Token(Token = "0x60004FB")]
	[Address(RVA = "0x74E674", Offset = "0x74E674", VA = "0x74E674")]
	public EffectControl()
	{
	}
}
[Token(Token = "0x20000A6")]
public class GlowControl : MonoBehaviour
{
	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public HighlightEffect _HighlightEffect;

	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected List<GameObject> glowObjList;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	protected List<Material> matList;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected float duration;

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	protected float initValue;

	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected TweenerCore<float, float, FloatOptions>[] temp_dt;

	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected TweenerCore<float, float, FloatOptions> temp_dt2;

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	protected bool isSkinMesh;

	[Token(Token = "0x60004FC")]
	[Address(RVA = "0x74E6FC", Offset = "0x74E6FC", VA = "0x74E6FC", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x60004FD")]
	[Address(RVA = "0x74EB88", Offset = "0x74EB88", VA = "0x74EB88", Slot = "5")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x60004FE")]
	[Address(RVA = "0x74EB94", Offset = "0x74EB94", VA = "0x74EB94", Slot = "6")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x60004FF")]
	[Address(RVA = "0x74EB98", Offset = "0x74EB98", VA = "0x74EB98", Slot = "7")]
	public virtual void DisableFlowEffect()
	{
	}

	[Token(Token = "0x6000500")]
	[Address(RVA = "0x74EDA0", Offset = "0x74EDA0", VA = "0x74EDA0", Slot = "8")]
	public virtual void EnableFlowEffect()
	{
	}

	[Token(Token = "0x6000501")]
	[Address(RVA = "0x74EFD0", Offset = "0x74EFD0", VA = "0x74EFD0")]
	public GlowControl()
	{
	}
}
[Token(Token = "0x20000A7")]
public class JiaGuChangeControl : MonoBehaviour
{
	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject jiaGuObj;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Material material;

	[Token(Token = "0x6000502")]
	[Address(RVA = "0x74F0B4", Offset = "0x74F0B4", VA = "0x74F0B4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000503")]
	[Address(RVA = "0x74F120", Offset = "0x74F120", VA = "0x74F120")]
	private void Start()
	{
	}

	[Token(Token = "0x6000504")]
	[Address(RVA = "0x74F124", Offset = "0x74F124", VA = "0x74F124")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000505")]
	[Address(RVA = "0x74F1D8", Offset = "0x74F1D8", VA = "0x74F1D8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000506")]
	[Address(RVA = "0x74F128", Offset = "0x74F128", VA = "0x74F128")]
	private void InitMaterial()
	{
	}

	[Token(Token = "0x6000507")]
	[Address(RVA = "0x74F23C", Offset = "0x74F23C", VA = "0x74F23C")]
	public void EnableFirstChange()
	{
	}

	[Token(Token = "0x6000508")]
	[Address(RVA = "0x74F290", Offset = "0x74F290", VA = "0x74F290")]
	public void EnableSecondChange()
	{
	}

	[Token(Token = "0x6000509")]
	[Address(RVA = "0x74F2E4", Offset = "0x74F2E4", VA = "0x74F2E4")]
	public void EnableThirdChange()
	{
	}

	[Token(Token = "0x600050A")]
	[Address(RVA = "0x74F338", Offset = "0x74F338", VA = "0x74F338")]
	public JiaGuChangeControl()
	{
	}
}
[Token(Token = "0x20000A8")]
public class SmokeControl : MonoBehaviour
{
	[Token(Token = "0x600050B")]
	[Address(RVA = "0x74F340", Offset = "0x74F340", VA = "0x74F340")]
	private void Start()
	{
	}

	[Token(Token = "0x600050C")]
	[Address(RVA = "0x74F344", Offset = "0x74F344", VA = "0x74F344")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600050D")]
	[Address(RVA = "0x74F3CC", Offset = "0x74F3CC", VA = "0x74F3CC")]
	private void Update()
	{
	}

	[Token(Token = "0x600050E")]
	[Address(RVA = "0x74F3D0", Offset = "0x74F3D0", VA = "0x74F3D0")]
	public SmokeControl()
	{
	}
}
[Token(Token = "0x20000A9")]
public class TargetPointControl : MonoBehaviour
{
	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private SpriteRenderer spriteRenderer;

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float duration;

	[Token(Token = "0x600050F")]
	[Address(RVA = "0x74F3D8", Offset = "0x74F3D8", VA = "0x74F3D8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000510")]
	[Address(RVA = "0x74F544", Offset = "0x74F544", VA = "0x74F544")]
	private void Update()
	{
	}

	[Token(Token = "0x6000511")]
	[Address(RVA = "0x74F548", Offset = "0x74F548", VA = "0x74F548")]
	public TargetPointControl()
	{
	}
}
[Token(Token = "0x20000AA")]
public class VideoFadeControl : MonoBehaviour
{
	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject videoObj;

	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Material videoMaterial;

	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Action FinishedFade;

	[Token(Token = "0x6000512")]
	[Address(RVA = "0x74F558", Offset = "0x74F558", VA = "0x74F558")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000513")]
	[Address(RVA = "0x74F5F0", Offset = "0x74F5F0", VA = "0x74F5F0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000514")]
	[Address(RVA = "0x74F5F4", Offset = "0x74F5F4", VA = "0x74F5F4")]
	public void VideoFade(float duration = 10f)
	{
	}

	[Token(Token = "0x6000515")]
	[Address(RVA = "0x74F6D4", Offset = "0x74F6D4", VA = "0x74F6D4")]
	public VideoFadeControl()
	{
	}
}
[Token(Token = "0x20000AB")]
public class ChangeScene2 : MonoBehaviour
{
	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string NextSceneName;

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SpriteRenderer sprite;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Hand testhand;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool isPress;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool isPress2;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	private bool isLoadScene;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Image circleImg;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float Delay;

	[Token(Token = "0x6000517")]
	[Address(RVA = "0x74F6F8", Offset = "0x74F6F8", VA = "0x74F6F8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000518")]
	[Address(RVA = "0x74F6FC", Offset = "0x74F6FC", VA = "0x74F6FC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000519")]
	[Address(RVA = "0x74F700", Offset = "0x74F700", VA = "0x74F700")]
	private void Update()
	{
	}

	[Token(Token = "0x600051A")]
	[Address(RVA = "0x74F7F0", Offset = "0x74F7F0", VA = "0x74F7F0")]
	private void LoadScene()
	{
	}

	[Token(Token = "0x600051B")]
	[Address(RVA = "0x74F84C", Offset = "0x74F84C", VA = "0x74F84C")]
	public ChangeScene2()
	{
	}
}
[Token(Token = "0x20000AC")]
public class LoadFile : MonoBehaviour
{
	[Token(Token = "0x20000AD")]
	public delegate void CallBack();

	[Token(Token = "0x20000AE")]
	public delegate void CallBack<in T>(T arg);

	[Token(Token = "0x20000AF")]
	public delegate void CallBack<in T, in X>(T arg1, X arg2);

	[Token(Token = "0x20000B0")]
	public delegate void CallBack<in T, in X, in Y>(T arg1, X arg2, Y arg3);

	[Token(Token = "0x20000B1")]
	public delegate void CallBack<in T, in X, in Y, in Z>(T arg1, X arg2, Y arg3, Z arg4);

	[Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class <LoadAssetsForServer>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityWebRequest unityWebRequest;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LoadFile <>4__this;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string fileName;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public CallBack action;

		[Token(Token = "0x1700006A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600053A")]
			[Address(RVA = "0x750000", Offset = "0x750000", VA = "0x750000", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600053C")]
			[Address(RVA = "0x750048", Offset = "0x750048", VA = "0x750048", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x74F968", Offset = "0x74F968", VA = "0x74F968")]
		[DebuggerHidden]
		public <LoadAssetsForServer>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x74FE78", Offset = "0x74FE78", VA = "0x74FE78", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x74FE7C", Offset = "0x74FE7C", VA = "0x74FE7C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x750008", Offset = "0x750008", VA = "0x750008", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class <DownloadFileForServer>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string url;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CallBack<float> callBack;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string fileSavePath;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UnityWebRequest <request>5__2;

		[Token(Token = "0x1700006C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000540")]
			[Address(RVA = "0x750238", Offset = "0x750238", VA = "0x750238", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x750280", Offset = "0x750280", VA = "0x750280", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x74FA34", Offset = "0x74FA34", VA = "0x74FA34")]
		[DebuggerHidden]
		public <DownloadFileForServer>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x750050", Offset = "0x750050", VA = "0x750050", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x750054", Offset = "0x750054", VA = "0x750054", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x750240", Offset = "0x750240", VA = "0x750240", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MediaPlayer mediaPlayer;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string filePath;

	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text text;

	[Token(Token = "0x600051C")]
	[Address(RVA = "0x74F85C", Offset = "0x74F85C", VA = "0x74F85C")]
	public void LoadAssetsForServer(string uri, string fileName, CallBack action)
	{
	}

	[Token(Token = "0x600051D")]
	[Address(RVA = "0x74F8A8", Offset = "0x74F8A8", VA = "0x74F8A8")]
	[IteratorStateMachine(typeof(<LoadAssetsForServer>d__9))]
	private IEnumerator LoadAssetsForServer(UnityWebRequest unityWebRequest, string fileName, CallBack action)
	{
		return null;
	}

	[Token(Token = "0x600051E")]
	[Address(RVA = "0x74F990", Offset = "0x74F990", VA = "0x74F990")]
	[IteratorStateMachine(typeof(<DownloadFileForServer>d__10))]
	private IEnumerator DownloadFileForServer(string url, string resSaveName, string fileSavePath, CallBack<float> callBack)
	{
		return null;
	}

	[Token(Token = "0x600051F")]
	[Address(RVA = "0x74FA5C", Offset = "0x74FA5C", VA = "0x74FA5C")]
	public void SaveFile(byte[] res, string savePath, string fileUrl, CallBack action)
	{
	}

	[Token(Token = "0x6000520")]
	[Address(RVA = "0x74FBD4", Offset = "0x74FBD4", VA = "0x74FBD4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000521")]
	[Address(RVA = "0x74FD54", Offset = "0x74FD54", VA = "0x74FD54")]
	private void CallAction()
	{
	}

	[Token(Token = "0x6000522")]
	[Address(RVA = "0x74FE30", Offset = "0x74FE30", VA = "0x74FE30")]
	public LoadFile()
	{
	}
}
[Token(Token = "0x20000B4")]
public class ObbVideoTest : MonoBehaviour
{
	[Token(Token = "0x400040D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool isPress;

	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool isChange;

	[Token(Token = "0x400040F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject goPre;

	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject go;

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float delayTime;

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Text showTextPre;

	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Text showText;

	[Token(Token = "0x6000543")]
	[Address(RVA = "0x750288", Offset = "0x750288", VA = "0x750288")]
	private void Start()
	{
	}

	[Token(Token = "0x6000544")]
	[Address(RVA = "0x75028C", Offset = "0x75028C", VA = "0x75028C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000545")]
	[Address(RVA = "0x750454", Offset = "0x750454", VA = "0x750454")]
	private void DelayVideo()
	{
	}

	[Token(Token = "0x6000546")]
	[Address(RVA = "0x7504EC", Offset = "0x7504EC", VA = "0x7504EC")]
	public ObbVideoTest()
	{
	}
}
[Token(Token = "0x20000B5")]
public class MousePainter : Painter
{
	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public PaintManager paintManager;

	[Token(Token = "0x6000547")]
	[Address(RVA = "0x7504FC", Offset = "0x7504FC", VA = "0x7504FC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000548")]
	[Address(RVA = "0x750A74", Offset = "0x750A74", VA = "0x750A74")]
	public MousePainter()
	{
	}
}
[Token(Token = "0x20000B6")]
public class MyPainter : Painter
{
	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform riTrans;

	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform yueTrans;

	[Token(Token = "0x4000417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform shuiTrans;

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int riCurrentIndex;

	[Token(Token = "0x4000419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int yueCurrentIndex;

	[Token(Token = "0x400041A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int shuiCurrentIndex;

	[Token(Token = "0x400041B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public PaintManager paintManager;

	[Token(Token = "0x400041C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Paintable paintable;

	[Token(Token = "0x6000549")]
	[Address(RVA = "0x750AA4", Offset = "0x750AA4", VA = "0x750AA4")]
	private void Start()
	{
	}

	[Token(Token = "0x600054A")]
	[Address(RVA = "0x750AA8", Offset = "0x750AA8", VA = "0x750AA8")]
	public void Painting(Transform trans)
	{
	}

	[Token(Token = "0x600054B")]
	[Address(RVA = "0x750B98", Offset = "0x750B98", VA = "0x750B98")]
	private void Update()
	{
	}

	[Token(Token = "0x600054C")]
	[Address(RVA = "0x750E5C", Offset = "0x750E5C", VA = "0x750E5C")]
	public MyPainter()
	{
	}
}
[Token(Token = "0x20000B7")]
public class Paintable : MonoBehaviour
{
	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool debugUV;

	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int textureSize;

	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Renderer rend;

	[Token(Token = "0x4000420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RenderTexture maskTexture;

	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RenderTexture copyTexture;

	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int maskTextureID;

	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public PaintManager paintManager;

	[Token(Token = "0x600054D")]
	[Address(RVA = "0x750E74", Offset = "0x750E74", VA = "0x750E74")]
	public Renderer GetRenderer()
	{
		return null;
	}

	[Token(Token = "0x600054E")]
	[Address(RVA = "0x750E7C", Offset = "0x750E7C", VA = "0x750E7C")]
	public RenderTexture GetMask()
	{
		return null;
	}

	[Token(Token = "0x600054F")]
	[Address(RVA = "0x750E84", Offset = "0x750E84", VA = "0x750E84")]
	public RenderTexture GetCopy()
	{
		return null;
	}

	[Token(Token = "0x6000550")]
	[Address(RVA = "0x750E8C", Offset = "0x750E8C", VA = "0x750E8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000551")]
	[Address(RVA = "0x750E90", Offset = "0x750E90", VA = "0x750E90")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000552")]
	[Address(RVA = "0x75115C", Offset = "0x75115C", VA = "0x75115C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000553")]
	[Address(RVA = "0x751160", Offset = "0x751160", VA = "0x751160")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000554")]
	[Address(RVA = "0x751214", Offset = "0x751214", VA = "0x751214")]
	public Paintable()
	{
	}
}
[Token(Token = "0x20000B8")]
public abstract class Painter : MonoBehaviour
{
	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Camera cam;

	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Space]
	public bool mouseSingleClick;

	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Space]
	public Color paintColor;

	[Token(Token = "0x4000427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float radius;

	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float strength;

	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float hardness;

	[Token(Token = "0x6000555")]
	[Address(RVA = "0x750A8C", Offset = "0x750A8C", VA = "0x750A8C")]
	protected Painter()
	{
	}
}
[Token(Token = "0x20000B9")]
public class PaintManager : Singleton<PaintManager>
{
	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Shader texturePaint;

	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Material paintMaterial;

	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int debugUVID;

	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int positionID;

	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int hardnessID;

	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int strengthID;

	[Token(Token = "0x4000430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int radiusID;

	[Token(Token = "0x4000431")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int colorID;

	[Token(Token = "0x4000432")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int textureID;

	[Token(Token = "0x4000433")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private CommandBuffer command;

	[Token(Token = "0x6000556")]
	[Address(RVA = "0x75127C", Offset = "0x75127C", VA = "0x75127C")]
	private new void Awake()
	{
	}

	[Token(Token = "0x6000557")]
	[Address(RVA = "0x750FF8", Offset = "0x750FF8", VA = "0x750FF8")]
	public void InitUVMask(Paintable paintable)
	{
	}

	[Token(Token = "0x6000558")]
	[Address(RVA = "0x7507AC", Offset = "0x7507AC", VA = "0x7507AC")]
	public void Paint(Paintable paintable, Vector3 pos, float radius = 1f, float hardness = 0.5f, float strength = 0.5f, [Optional] Color? color)
	{
	}

	[Token(Token = "0x6000559")]
	[Address(RVA = "0x75138C", Offset = "0x75138C", VA = "0x75138C")]
	public PaintManager()
	{
	}
}
[Token(Token = "0x20000BA")]
public class ParticlesPainter : Painter
{
	[Token(Token = "0x4000434")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float minRadius;

	[Token(Token = "0x4000435")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float maxRadius;

	[Token(Token = "0x4000436")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Space]
	private ParticleSystem part;

	[Token(Token = "0x4000437")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<ParticleCollisionEvent> collisionEvents;

	[Token(Token = "0x600055A")]
	[Address(RVA = "0x7514F0", Offset = "0x7514F0", VA = "0x7514F0")]
	private void Start()
	{
	}

	[Token(Token = "0x600055B")]
	[Address(RVA = "0x7515A4", Offset = "0x7515A4", VA = "0x7515A4")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x600055C")]
	[Address(RVA = "0x7517C8", Offset = "0x7517C8", VA = "0x7517C8")]
	public ParticlesPainter()
	{
	}
}
[Token(Token = "0x20000BB")]
public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
	[Token(Token = "0x4000438")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static T instance;

	[Token(Token = "0x1700006E")]
	public static T Instance
	{
		[Token(Token = "0x600055D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700006F")]
	public static bool IsInitialized
	{
		[Token(Token = "0x600055F")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600055E")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6000560")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000561")]
	public Singleton()
	{
	}
}
[Token(Token = "0x20000BC")]
public class FireControl : MonoBehaviour
{
	[Token(Token = "0x4000439")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ParticleSystem _particleSystem;

	[Token(Token = "0x400043A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject sparkObj;

	[Token(Token = "0x400043B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject glowObj;

	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Color glowColor;

	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Material glowMat;

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Material baseMaterial;

	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Color baseColor;

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Material logMaterial;

	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private AudioSource logSource;

	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Transform coalTrans;

	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Material coalMat;

	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float duration;

	[Token(Token = "0x4000445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private float minSize;

	[Token(Token = "0x4000446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float maxSize;

	[Token(Token = "0x4000447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float minSpeed;

	[Token(Token = "0x4000448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float maxSpeed;

	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float minRadius;

	[Token(Token = "0x6000562")]
	[Address(RVA = "0x7517E8", Offset = "0x7517E8", VA = "0x7517E8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000563")]
	[Address(RVA = "0x751854", Offset = "0x751854", VA = "0x751854")]
	private void Start()
	{
	}

	[Token(Token = "0x6000564")]
	[Address(RVA = "0x751858", Offset = "0x751858", VA = "0x751858")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000565")]
	[Address(RVA = "0x7519C0", Offset = "0x7519C0", VA = "0x7519C0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000566")]
	[Address(RVA = "0x7519EC", Offset = "0x7519EC", VA = "0x7519EC")]
	public void EnableFire()
	{
	}

	[Token(Token = "0x6000567")]
	[Address(RVA = "0x75185C", Offset = "0x75185C", VA = "0x75185C")]
	private void InitFire()
	{
	}

	[Token(Token = "0x6000568")]
	[Address(RVA = "0x751C10", Offset = "0x751C10", VA = "0x751C10")]
	public FireControl()
	{
	}
}
[Token(Token = "0x20000BD")]
public class GlowControl_MuKuai : GlowControl
{
	[Token(Token = "0x400044A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float fireDuration;

	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float fireInitValue;

	[Token(Token = "0x600056D")]
	[Address(RVA = "0x751D40", Offset = "0x751D40", VA = "0x751D40", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600056E")]
	[Address(RVA = "0x751DCC", Offset = "0x751DCC", VA = "0x751DCC", Slot = "6")]
	protected override void Update()
	{
	}

	[Token(Token = "0x600056F")]
	[Address(RVA = "0x751DD0", Offset = "0x751DD0", VA = "0x751DD0")]
	public void EnableFireEffect()
	{
	}

	[Token(Token = "0x6000570")]
	[Address(RVA = "0x751E4C", Offset = "0x751E4C", VA = "0x751E4C")]
	public GlowControl_MuKuai()
	{
	}
}
[Token(Token = "0x20000BE")]
public class GlowControl_NiuGu : GlowControl
{
	[Token(Token = "0x400044C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float fireDuration;

	[Token(Token = "0x400044D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float fireInitValue;

	[Token(Token = "0x400044E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material fontAnimMat;

	[Token(Token = "0x400044F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Transform vfxTrans;

	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int fontEffectIndex;

	[Token(Token = "0x6000571")]
	[Address(RVA = "0x751E58", Offset = "0x751E58", VA = "0x751E58", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000572")]
	[Address(RVA = "0x751F44", Offset = "0x751F44", VA = "0x751F44", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000573")]
	[Address(RVA = "0x75211C", Offset = "0x75211C", VA = "0x75211C", Slot = "6")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000574")]
	[Address(RVA = "0x752120", Offset = "0x752120", VA = "0x752120")]
	public void EnableFireEffect()
	{
	}

	[Token(Token = "0x6000575")]
	[Address(RVA = "0x751FD8", Offset = "0x751FD8", VA = "0x751FD8")]
	private void InitFontEffect()
	{
	}

	[Token(Token = "0x6000576")]
	[Address(RVA = "0x75219C", Offset = "0x75219C", VA = "0x75219C")]
	public void ShowFont1()
	{
	}

	[Token(Token = "0x6000577")]
	[Address(RVA = "0x752424", Offset = "0x752424", VA = "0x752424")]
	public void ShowFont2()
	{
	}

	[Token(Token = "0x6000578")]
	[Address(RVA = "0x752434", Offset = "0x752434", VA = "0x752434")]
	public void ShowFont3()
	{
	}

	[Token(Token = "0x6000579")]
	[Address(RVA = "0x7521A8", Offset = "0x7521A8", VA = "0x7521A8")]
	private void ShowFontEffect(int index)
	{
	}

	[Token(Token = "0x600057A")]
	[Address(RVA = "0x75244C", Offset = "0x75244C", VA = "0x75244C")]
	private void HideFontEffect()
	{
	}

	[Token(Token = "0x600057B")]
	[Address(RVA = "0x752520", Offset = "0x752520", VA = "0x752520")]
	public GlowControl_NiuGu()
	{
	}
}
[Token(Token = "0x20000C0")]
public enum FingerType
{
	[Token(Token = "0x4000455")]
	None,
	[Token(Token = "0x4000456")]
	Thumb,
	[Token(Token = "0x4000457")]
	Index,
	[Token(Token = "0x4000458")]
	Middle,
	[Token(Token = "0x4000459")]
	Ring,
	[Token(Token = "0x400045A")]
	Pinky
}
[Token(Token = "0x20000C1")]
public class Finger
{
	[Token(Token = "0x400045B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public FingerType type;

	[Token(Token = "0x400045C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float current;

	[Token(Token = "0x400045D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float target;

	[Token(Token = "0x6000580")]
	[Address(RVA = "0x752764", Offset = "0x752764", VA = "0x752764")]
	public Finger(FingerType finger)
	{
	}
}
[Token(Token = "0x20000C2")]
public class HandHider : MonoBehaviour
{
	[Token(Token = "0x400045E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject handObject;

	[Token(Token = "0x400045F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private XRDirectInteractor interactor;

	[Token(Token = "0x6000581")]
	[Address(RVA = "0x75278C", Offset = "0x75278C", VA = "0x75278C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000582")]
	[Address(RVA = "0x7527E4", Offset = "0x7527E4", VA = "0x7527E4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000583")]
	[Address(RVA = "0x752908", Offset = "0x752908", VA = "0x752908")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000584")]
	[Address(RVA = "0x752A2C", Offset = "0x752A2C", VA = "0x752A2C")]
	private void Show(SelectExitEventArgs interactable)
	{
	}

	[Token(Token = "0x6000585")]
	[Address(RVA = "0x752A4C", Offset = "0x752A4C", VA = "0x752A4C")]
	private void Hide(SelectEnterEventArgs interactable)
	{
	}

	[Token(Token = "0x6000586")]
	[Address(RVA = "0x752A6C", Offset = "0x752A6C", VA = "0x752A6C")]
	public HandHider()
	{
	}
}
[Token(Token = "0x20000C3")]
public abstract class BaseHand : MonoBehaviour
{
	[Token(Token = "0x4000460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected Pose defaultPose;

	[Token(Token = "0x4000461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected List<Transform> fingerRoots;

	[Token(Token = "0x4000462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected HandType handType;

	[Token(Token = "0x17000070")]
	public HandType HandType
	{
		[Token(Token = "0x6000587")]
		[Address(RVA = "0x752A74", Offset = "0x752A74", VA = "0x752A74")]
		get
		{
			return default(HandType);
		}
	}

	[Token(Token = "0x17000071")]
	public List<Transform> Joints
	{
		[Token(Token = "0x6000588")]
		[Address(RVA = "0x752A7C", Offset = "0x752A7C", VA = "0x752A7C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000589")]
		[Address(RVA = "0x752A84", Offset = "0x752A84", VA = "0x752A84")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x600058A")]
	[Address(RVA = "0x752A8C", Offset = "0x752A8C", VA = "0x752A8C", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x600058B")]
	[Address(RVA = "0x752AAC", Offset = "0x752AAC", VA = "0x752AAC")]
	protected List<Transform> CollectJoints()
	{
		return null;
	}

	[Token(Token = "0x600058C")]
	[Address(RVA = "0x752C7C", Offset = "0x752C7C", VA = "0x752C7C")]
	public List<Quaternion> GetJointRotations()
	{
		return null;
	}

	[Token(Token = "0x600058D")]
	[Address(RVA = "0x752E98", Offset = "0x752E98", VA = "0x752E98")]
	public void ApplyDefaultPose()
	{
	}

	[Token(Token = "0x600058E")]
	[Address(RVA = "0x752EA0", Offset = "0x752EA0", VA = "0x752EA0")]
	public void ApplyPose(Pose pose)
	{
	}

	[Token(Token = "0x600058F")]
	[Address(RVA = "0x752F28", Offset = "0x752F28", VA = "0x752F28")]
	public void ApplyFingerRotations(List<Quaternion> rotations)
	{
	}

	[Token(Token = "0x6000590")]
	[Address(RVA = "0x753008", Offset = "0x753008", VA = "0x753008")]
	private bool HasProperCount(List<Quaternion> rotations)
	{
		return default(bool);
	}

	[Token(Token = "0x6000591")]
	public abstract void ApplyOffset(Vector3 position, Quaternion rotation);

	[Token(Token = "0x6000592")]
	[Address(RVA = "0x753070", Offset = "0x753070", VA = "0x753070")]
	protected BaseHand()
	{
	}
}
[Token(Token = "0x20000C4")]
public class GameplayHand : BaseHand
{
	[Token(Token = "0x4000464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Dictionary<string, FingersValue> FingersAniValues;

	[Token(Token = "0x4000465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float _Thumb;

	[Token(Token = "0x4000466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float _Index;

	[Token(Token = "0x4000467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float _Middle;

	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float _Ring;

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float _Pinky;

	[Token(Token = "0x400046A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float speed;

	[Token(Token = "0x400046B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public XRBaseInteractor targetInteractor;

	[Token(Token = "0x400046C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private ActionBasedController controller;

	[Token(Token = "0x400046D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Animator animator;

	[Token(Token = "0x400046E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool isUpdateAnimator;

	[Token(Token = "0x400046F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
	public bool isCustomValue;

	[Token(Token = "0x4000470")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly List<Finger> gripFingers;

	[Token(Token = "0x4000471")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private FingersValue finger;

	[Token(Token = "0x4000472")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float Value;

	[Token(Token = "0x6000593")]
	[Address(RVA = "0x753128", Offset = "0x753128", VA = "0x753128")]
	private new void Awake()
	{
	}

	[Token(Token = "0x6000594")]
	[Address(RVA = "0x75327C", Offset = "0x75327C", VA = "0x75327C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000595")]
	[Address(RVA = "0x7533A0", Offset = "0x7533A0", VA = "0x7533A0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000596")]
	[Address(RVA = "0x7534C4", Offset = "0x7534C4", VA = "0x7534C4")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000597")]
	[Address(RVA = "0x753580", Offset = "0x753580", VA = "0x753580")]
	private void Update()
	{
	}

	[Token(Token = "0x6000598")]
	[Address(RVA = "0x753590", Offset = "0x753590", VA = "0x753590")]
	private void UpdateHand()
	{
	}

	[Token(Token = "0x6000599")]
	[Address(RVA = "0x7535CC", Offset = "0x7535CC", VA = "0x7535CC")]
	private void SetPointFingerTargets(List<Finger> fingers)
	{
	}

	[Token(Token = "0x600059A")]
	[Address(RVA = "0x753730", Offset = "0x753730", VA = "0x753730")]
	private void SetPointFingerTargets2(List<Finger> fingers)
	{
	}

	[Token(Token = "0x600059B")]
	[Address(RVA = "0x753BFC", Offset = "0x753BFC", VA = "0x753BFC")]
	public void SetFingerValue(bool isCustomValue, float Thumb = 0f, float Index = 0f, float Middle = 0f, float Ring = 0f, float Pinky = 0f)
	{
	}

	[Token(Token = "0x600059C")]
	[Address(RVA = "0x7438B0", Offset = "0x7438B0", VA = "0x7438B0")]
	public void SetFingerValue(string GripObj)
	{
	}

	[Token(Token = "0x600059D")]
	[Address(RVA = "0x7538C8", Offset = "0x7538C8", VA = "0x7538C8")]
	private void SmoothFinger(List<Finger> fingers)
	{
	}

	[Token(Token = "0x600059E")]
	[Address(RVA = "0x753A58", Offset = "0x753A58", VA = "0x753A58")]
	private void AnimateFinger(List<Finger> fingers)
	{
	}

	[Token(Token = "0x600059F")]
	[Address(RVA = "0x753C14", Offset = "0x753C14", VA = "0x753C14")]
	private void AnimateFinger(string finger, float blend)
	{
	}

	[Token(Token = "0x60005A0")]
	[Address(RVA = "0x753C30", Offset = "0x753C30", VA = "0x753C30")]
	private void TryApplyObjectPose(SelectEnterEventArgs interactable)
	{
	}

	[Token(Token = "0x60005A1")]
	[Address(RVA = "0x753D58", Offset = "0x753D58", VA = "0x753D58")]
	private void TryApplyDefaultPose(SelectExitEventArgs interactable)
	{
	}

	[Token(Token = "0x60005A2")]
	[Address(RVA = "0x753E7C", Offset = "0x753E7C", VA = "0x753E7C", Slot = "5")]
	public override void ApplyOffset(Vector3 position, Quaternion rotation)
	{
	}

	[Token(Token = "0x60005A3")]
	[Address(RVA = "0x754044", Offset = "0x754044", VA = "0x754044")]
	public GameplayHand()
	{
	}
}
[Token(Token = "0x20000C5")]
[ExecuteInEditMode]
[SelectionBase]
public class PreviewHand : BaseHand
{
	[Token(Token = "0x60005A4")]
	[Address(RVA = "0x7543E4", Offset = "0x7543E4", VA = "0x7543E4")]
	public void MirrorAndApplyPose(PreviewHand sourceHand)
	{
	}

	[Token(Token = "0x60005A5")]
	[Address(RVA = "0x754498", Offset = "0x754498", VA = "0x754498")]
	private List<Quaternion> MirrorJoints(List<Transform> joints)
	{
		return null;
	}

	[Token(Token = "0x60005A6")]
	[Address(RVA = "0x754700", Offset = "0x754700", VA = "0x754700")]
	private Quaternion MirrorJoint(Transform sourceTransform)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60005A7")]
	[Address(RVA = "0x7546D8", Offset = "0x7546D8", VA = "0x7546D8")]
	private Quaternion MirrorRotation(Transform sourceTransform)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60005A8")]
	[Address(RVA = "0x7546B4", Offset = "0x7546B4", VA = "0x7546B4")]
	private Vector3 MirrorPosition(Transform sourceTransform)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60005A9")]
	[Address(RVA = "0x754718", Offset = "0x754718", VA = "0x754718", Slot = "5")]
	public override void ApplyOffset(Vector3 position, Quaternion rotation)
	{
	}

	[Token(Token = "0x60005AA")]
	[Address(RVA = "0x7547AC", Offset = "0x7547AC", VA = "0x7547AC")]
	public PreviewHand()
	{
	}
}
[Serializable]
[Token(Token = "0x20000C6")]
public class HandInfo
{
	[Token(Token = "0x4000473")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3 attachPosition;

	[Token(Token = "0x4000474")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Quaternion attachRotation;

	[Token(Token = "0x4000475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Quaternion> fingerRotations;

	[Token(Token = "0x17000072")]
	public static HandInfo Empty
	{
		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x7547B0", Offset = "0x7547B0", VA = "0x7547B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60005AC")]
	[Address(RVA = "0x754908", Offset = "0x754908", VA = "0x754908")]
	public void Save(PreviewHand hand)
	{
	}

	[Token(Token = "0x60005AD")]
	[Address(RVA = "0x754808", Offset = "0x754808", VA = "0x754808")]
	public HandInfo()
	{
	}
}
[Token(Token = "0x20000C7")]
public enum HandType
{
	[Token(Token = "0x4000477")]
	None,
	[Token(Token = "0x4000478")]
	Left,
	[Token(Token = "0x4000479")]
	Right
}
[Token(Token = "0x20000C8")]
[CreateAssetMenu(fileName = "NewPoseData")]
[SerializeField]
public class Pose : ScriptableObject
{
	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public HandInfo leftHandInfo;

	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public HandInfo rightHandInfo;

	[Token(Token = "0x60005AE")]
	[Address(RVA = "0x752F00", Offset = "0x752F00", VA = "0x752F00")]
	public HandInfo GetHandInfo(HandType handType)
	{
		return null;
	}

	[Token(Token = "0x60005AF")]
	[Address(RVA = "0x754980", Offset = "0x754980", VA = "0x754980")]
	public Pose()
	{
	}
}
[Token(Token = "0x20000C9")]
public class PoseContainer : MonoBehaviour
{
	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Pose pose;

	[Token(Token = "0x60005B0")]
	[Address(RVA = "0x7549C0", Offset = "0x7549C0", VA = "0x7549C0")]
	public PoseContainer()
	{
	}
}
[Token(Token = "0x20000CA")]
[ExecuteInEditMode]
public class HandManager : MonoBehaviour
{
	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool hideHands;

	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject leftHandPrefab;

	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject rightHandPrefab;

	[Token(Token = "0x17000073")]
	public PreviewHand LeftHand
	{
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x7549C8", Offset = "0x7549C8", VA = "0x7549C8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x7549D0", Offset = "0x7549D0", VA = "0x7549D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000074")]
	public PreviewHand RightHand
	{
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x7549D8", Offset = "0x7549D8", VA = "0x7549D8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x7549E0", Offset = "0x7549E0", VA = "0x7549E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000075")]
	public bool HandsExist
	{
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x7549E8", Offset = "0x7549E8", VA = "0x7549E8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60005B6")]
	[Address(RVA = "0x754A78", Offset = "0x754A78", VA = "0x754A78")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60005B7")]
	[Address(RVA = "0x754ABC", Offset = "0x754ABC", VA = "0x754ABC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60005B8")]
	[Address(RVA = "0x754A7C", Offset = "0x754A7C", VA = "0x754A7C")]
	private void CreateHandPreviews()
	{
	}

	[Token(Token = "0x60005B9")]
	[Address(RVA = "0x754AC4", Offset = "0x754AC4", VA = "0x754AC4")]
	private PreviewHand CreateHand(GameObject prefab)
	{
		return null;
	}

	[Token(Token = "0x60005BA")]
	[Address(RVA = "0x754AC0", Offset = "0x754AC0", VA = "0x754AC0")]
	private void DestroyHandPreviews()
	{
	}

	[Token(Token = "0x60005BB")]
	[Address(RVA = "0x754BA0", Offset = "0x754BA0", VA = "0x754BA0")]
	public void UpdateHands(Pose pose, Transform parentTransform)
	{
	}

	[Token(Token = "0x60005BC")]
	[Address(RVA = "0x754C20", Offset = "0x754C20", VA = "0x754C20")]
	public void SavePose(Pose pose)
	{
	}

	[Token(Token = "0x60005BD")]
	[Address(RVA = "0x754C60", Offset = "0x754C60", VA = "0x754C60")]
	public HandManager()
	{
	}
}
[Token(Token = "0x20000CB")]
[ExecuteInEditMode]
public class SelectionHandler : MonoBehaviour
{
	[Token(Token = "0x17000076")]
	public XRBaseInteractable CurretInteractable
	{
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x754C70", Offset = "0x754C70", VA = "0x754C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x754C78", Offset = "0x754C78", VA = "0x754C78")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60005C0")]
	[Address(RVA = "0x754C80", Offset = "0x754C80", VA = "0x754C80")]
	public bool CheckForNewInteractable()
	{
		return default(bool);
	}

	[Token(Token = "0x60005C1")]
	[Address(RVA = "0x754CCC", Offset = "0x754CCC", VA = "0x754CCC")]
	private XRBaseInteractable GetInteractable()
	{
		return null;
	}

	[Token(Token = "0x60005C2")]
	[Address(RVA = "0x754D3C", Offset = "0x754D3C", VA = "0x754D3C")]
	private bool IsDifferentInteractable(XRBaseInteractable currentInteractable, XRBaseInteractable newInteractable)
	{
		return default(bool);
	}

	[Token(Token = "0x60005C3")]
	[Address(RVA = "0x754E20", Offset = "0x754E20", VA = "0x754E20")]
	public GameObject SetObjectPose(Pose pose)
	{
		return null;
	}

	[Token(Token = "0x60005C4")]
	[Address(RVA = "0x754E94", Offset = "0x754E94", VA = "0x754E94")]
	public Pose TryGetPose(GameObject targetObject)
	{
		return null;
	}

	[Token(Token = "0x60005C5")]
	[Address(RVA = "0x754E90", Offset = "0x754E90", VA = "0x754E90")]
	private void MarkActiveSceneAsDirty()
	{
	}

	[Token(Token = "0x60005C6")]
	[Address(RVA = "0x754F4C", Offset = "0x754F4C", VA = "0x754F4C")]
	public SelectionHandler()
	{
	}
}
[Token(Token = "0x20000CC")]
public static class Extensions
{
	[Token(Token = "0x60005C7")]
	[Address(RVA = "0x753FC4", Offset = "0x753FC4", VA = "0x753FC4")]
	public static Vector3 RotatePointAroundPivot(this Vector3 point, Vector3 pivot, Vector3 angles)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x20000CD")]
public class LightFlicker : MonoBehaviour
{
	[Token(Token = "0x4000483")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float initialValue;

	[Token(Token = "0x4000484")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Vector3 initialPosition;

	[Token(Token = "0x4000485")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 initialScale;

	[Token(Token = "0x4000486")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float initialTime;

	[Token(Token = "0x4000487")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Light lightRef;

	[Token(Token = "0x4000488")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float amount;

	[Token(Token = "0x4000489")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float speed;

	[Token(Token = "0x400048A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool adjustLocation;

	[Token(Token = "0x400048B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float locationAdjustAmount;

	[Token(Token = "0x400048C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool adjustScale;

	[Token(Token = "0x400048D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float scaleAdjustAmount;

	[Token(Token = "0x400048E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform scaleObject;

	[Token(Token = "0x60005C8")]
	[Address(RVA = "0x754F54", Offset = "0x754F54", VA = "0x754F54")]
	private void Start()
	{
	}

	[Token(Token = "0x60005C9")]
	[Address(RVA = "0x7550AC", Offset = "0x7550AC", VA = "0x7550AC")]
	private void Update()
	{
	}

	[Token(Token = "0x60005CA")]
	[Address(RVA = "0x75526C", Offset = "0x75526C", VA = "0x75526C")]
	public LightFlicker()
	{
	}
}
[Token(Token = "0x20000CE")]
public class TileAnimation : MonoBehaviour
{
	[Token(Token = "0x400048F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int xFrames;

	[Token(Token = "0x4000490")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int yFrames;

	[Token(Token = "0x4000491")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float speed;

	[Token(Token = "0x4000492")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool billboard;

	[Token(Token = "0x4000493")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Camera mainCamera;

	[Token(Token = "0x4000494")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool useURPProps;

	[Token(Token = "0x4000495")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int frame;

	[Token(Token = "0x4000496")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Renderer rendererReference;

	[Token(Token = "0x4000497")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int randomStart;

	[Token(Token = "0x60005CB")]
	[Address(RVA = "0x75528C", Offset = "0x75528C", VA = "0x75528C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005CC")]
	[Address(RVA = "0x755410", Offset = "0x755410", VA = "0x755410")]
	private void Update()
	{
	}

	[Token(Token = "0x60005CD")]
	[Address(RVA = "0x755760", Offset = "0x755760", VA = "0x755760")]
	public TileAnimation()
	{
	}
}
[Token(Token = "0x20000CF")]
public class Breathe : MonoBehaviour
{
	[Token(Token = "0x60005CE")]
	[Address(RVA = "0x75577C", Offset = "0x75577C", VA = "0x75577C")]
	private void Start()
	{
	}

	[Token(Token = "0x60005CF")]
	[Address(RVA = "0x755780", Offset = "0x755780", VA = "0x755780")]
	private void Update()
	{
	}

	[Token(Token = "0x60005D0")]
	[Address(RVA = "0x755870", Offset = "0x755870", VA = "0x755870")]
	public Breathe()
	{
	}
}
[Token(Token = "0x20000D0")]
public class LightMover : MonoBehaviour
{
	[Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private sealed class <Rando>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LightMover <>4__this;

		[Token(Token = "0x17000077")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x755AE8", Offset = "0x755AE8", VA = "0x755AE8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x755B30", Offset = "0x755B30", VA = "0x755B30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x7559E0", Offset = "0x7559E0", VA = "0x7559E0")]
		[DebuggerHidden]
		public <Rando>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x755A1C", Offset = "0x755A1C", VA = "0x755A1C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x755A20", Offset = "0x755A20", VA = "0x755A20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x755AF0", Offset = "0x755AF0", VA = "0x755AF0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000498")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float lerper;

	[Token(Token = "0x4000499")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float smoothTime;

	[Token(Token = "0x400049A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float velocity;

	[Token(Token = "0x60005D1")]
	[Address(RVA = "0x755878", Offset = "0x755878", VA = "0x755878")]
	private void Start()
	{
	}

	[Token(Token = "0x60005D2")]
	[Address(RVA = "0x75590C", Offset = "0x75590C", VA = "0x75590C")]
	private void Update()
	{
	}

	[Token(Token = "0x60005D3")]
	[Address(RVA = "0x755898", Offset = "0x755898", VA = "0x755898")]
	[IteratorStateMachine(typeof(<Rando>d__5))]
	private IEnumerator Rando()
	{
		return null;
	}

	[Token(Token = "0x60005D4")]
	[Address(RVA = "0x755A08", Offset = "0x755A08", VA = "0x755A08")]
	public LightMover()
	{
	}
}
[Token(Token = "0x20000D2")]
public class LookAt : MonoBehaviour
{
	[Token(Token = "0x400049E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Camera maincam;

	[Token(Token = "0x60005DB")]
	[Address(RVA = "0x755B38", Offset = "0x755B38", VA = "0x755B38")]
	private void Start()
	{
	}

	[Token(Token = "0x60005DC")]
	[Address(RVA = "0x755B5C", Offset = "0x755B5C", VA = "0x755B5C")]
	private void Update()
	{
	}

	[Token(Token = "0x60005DD")]
	[Address(RVA = "0x755BC8", Offset = "0x755BC8", VA = "0x755BC8")]
	public LookAt()
	{
	}
}
[Token(Token = "0x20000D3")]
public class MapChanger : MonoBehaviour
{
	[Token(Token = "0x400049F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int oldselected;

	[Token(Token = "0x40004A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Material targetmat;

	[Token(Token = "0x40004A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Renderer tarRenderer;

	[Token(Token = "0x40004A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Texture[] mattexes;

	[Token(Token = "0x60005DE")]
	[Address(RVA = "0x755BD0", Offset = "0x755BD0", VA = "0x755BD0")]
	private void Start()
	{
	}

	[Token(Token = "0x60005DF")]
	[Address(RVA = "0x755C60", Offset = "0x755C60", VA = "0x755C60")]
	public void SwitchTexture(int toWhich)
	{
	}

	[Token(Token = "0x60005E0")]
	[Address(RVA = "0x755D3C", Offset = "0x755D3C", VA = "0x755D3C")]
	public MapChanger()
	{
	}
}
[Token(Token = "0x20000D4")]
public class Probe : MonoBehaviour
{
	[Token(Token = "0x40004A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ReflectionProbe probe;

	[Token(Token = "0x60005E1")]
	[Address(RVA = "0x755DA8", Offset = "0x755DA8", VA = "0x755DA8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005E2")]
	[Address(RVA = "0x755E00", Offset = "0x755E00", VA = "0x755E00")]
	private void Update()
	{
	}

	[Token(Token = "0x60005E3")]
	[Address(RVA = "0x755E1C", Offset = "0x755E1C", VA = "0x755E1C")]
	public Probe()
	{
	}
}
namespace HighlightPlus
{
	[Token(Token = "0x20000D5")]
	public delegate bool OnObjectHighlightEvent(GameObject obj);
	[Token(Token = "0x20000D6")]
	public delegate bool OnRendererHighlightEvent(Renderer renderer);
	[Token(Token = "0x20000D7")]
	public delegate void OnTargetAnimatesEvent(ref Vector3 center, ref Quaternion rotation, ref Vector3 scale, float t);
	[Token(Token = "0x20000D8")]
	public enum NormalsOption
	{
		[Token(Token = "0x40004A5")]
		Smooth,
		[Token(Token = "0x40004A6")]
		PreserveOriginal,
		[Token(Token = "0x40004A7")]
		Reorient,
		[Token(Token = "0x40004A8")]
		Planar
	}
	[Token(Token = "0x20000D9")]
	public enum SeeThroughMode
	{
		[Token(Token = "0x40004AA")]
		WhenHighlighted,
		[Token(Token = "0x40004AB")]
		AlwaysWhenOccluded,
		[Token(Token = "0x40004AC")]
		Never
	}
	[Token(Token = "0x20000DA")]
	public enum QualityLevel
	{
		[Token(Token = "0x40004AE")]
		Fastest,
		[Token(Token = "0x40004AF")]
		High,
		[Token(Token = "0x40004B0")]
		Highest,
		[Token(Token = "0x40004B1")]
		Medium
	}
	[Token(Token = "0x20000DB")]
	public static class QualityLevelExtensions
	{
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x756328", Offset = "0x756328", VA = "0x756328")]
		public static bool UsesMultipleOffsets(this QualityLevel qualityLevel)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000DC")]
	public enum TargetOptions
	{
		[Token(Token = "0x40004B3")]
		Children,
		[Token(Token = "0x40004B4")]
		OnlyThisObject,
		[Token(Token = "0x40004B5")]
		RootToChildren,
		[Token(Token = "0x40004B6")]
		LayerInScene,
		[Token(Token = "0x40004B7")]
		LayerInChildren,
		[Token(Token = "0x40004B8")]
		Scripting
	}
	[Token(Token = "0x20000DD")]
	public enum Visibility
	{
		[Token(Token = "0x40004BA")]
		Normal,
		[Token(Token = "0x40004BB")]
		AlwaysOnTop,
		[Token(Token = "0x40004BC")]
		OnlyWhenOccluded
	}
	[Token(Token = "0x20000DE")]
	public enum GlowBlendMode
	{
		[Token(Token = "0x40004BE")]
		Additive,
		[Token(Token = "0x40004BF")]
		AlphaBlending
	}
	[Serializable]
	[Token(Token = "0x20000DF")]
	public struct GlowPassData
	{
		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float offset;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float alpha;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Color color;
	}
	[Token(Token = "0x20000E0")]
	[HelpURL("https://www.dropbox.com/s/v9qgn68ydblqz8x/Documentation.pdf?dl=0")]
	[ExecuteInEditMode]
	public class HighlightEffect : MonoBehaviour
	{
		[Token(Token = "0x20000E1")]
		private struct ModelMaterials
		{
			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool render;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool bakedTransform;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 currentPosition;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 currentRotation;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 currentScale;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool renderWasVisibleDuringSetup;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Mesh mesh;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Mesh originalMesh;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Renderer renderer;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public bool isSkinnedMesh;

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public NormalsOption normalsOption;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Material[] fxMatMask;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Material[] fxMatSolidColor;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Material[] fxMatSeeThroughInner;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Material[] fxMatSeeThroughBorder;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Material[] fxMatOverlay;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public Material[] fxMatInnerGlow;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Matrix4x4 renderingMatrix;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			public bool isCombined;

			[Token(Token = "0x17000082")]
			public bool preserveOriginalMesh
			{
				[Token(Token = "0x6000644")]
				[Address(RVA = "0x765D50", Offset = "0x765D50", VA = "0x765D50")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0x765D70", Offset = "0x765D70", VA = "0x765D70")]
			public void Init()
			{
			}
		}

		[Token(Token = "0x20000E2")]
		private enum FadingState
		{
			[Token(Token = "0x40005A7")]
			FadingOut = -1,
			[Token(Token = "0x40005A8")]
			NoFading,
			[Token(Token = "0x40005A9")]
			FadingIn
		}

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The current profile (optional). A profile let you store Highlight Plus settings and apply those settings easily to many objects. You can also load a profile and apply its settings at runtime, using the ProfileLoad() method of the Highlight Effect component.")]
		public HighlightProfile profile;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If enabled, settings from the profile will be applied to this component automatically when game starts or when any profile setting is updated.")]
		public bool profileSync;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[Tooltip("If enabled, effects will be visible also when not in Play mode.")]
		public bool previewInEditor;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Which cameras can render the effect.")]
		public LayerMask camerasLayerMask;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Different options to specify which objects are affected by this Highlight Effect component.")]
		public TargetOptions effectGroup;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("The layer that contains the affected objects by this effect when effectGroup is set to LayerMask.")]
		public LayerMask effectGroupLayer;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Only include objects whose names contains this text.")]
		public string effectNameFilter;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Combine meshes of all objects in this group affected by Highlight Effect reducing draw calls.")]
		public bool combineMeshes;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The alpha threshold for transparent cutout objects. Pixels with alpha below this value will be discarded.")]
		[Range(0f, 1f)]
		public float alphaCutOff;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("If back facing triangles are ignored.Backfaces triangles are not visible but you may set this property to false to force highlight effects to act on those triangles as well.")]
		public bool cullBackFaces;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		[Tooltip("Show highlight effects even if the object is not visible. If this object or its children use GPU Instancing tools, the MeshRenderer can be disabled although the object is visible. In this case, this option is useful to enable highlighting.")]
		public bool ignoreObjectVisibility;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		[Tooltip("Support reflection probes. Enable only if you want the effects to be visible in reflections.")]
		public bool reflectionProbes;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x43")]
		[Tooltip("Enables GPU instancing. Reduces draw calls in outline and outer glow effects on platforms that support GPU instancing. Should be enabled by default.")]
		public bool GPUInstancing;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Enables depth buffer clipping. Only applies to outline or outer glow in High Quality mode.")]
		public bool depthClip;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		[Tooltip("Fades out effects based on distance to camera")]
		public bool cameraDistanceFade;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The closest distance particles can get to the camera before they fade from the camera’s view.")]
		public float cameraDistanceFadeNear;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The farthest distance particles can get away from the camera before they fade from the camera’s view.")]
		public float cameraDistanceFadeFar;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Normals handling option:\nPreserve original: use original mesh normals.\nSmooth: average normals to produce a smoother outline/glow mesh based effect.\nReorient: recomputes normals based on vertex direction to centroid.\nPlanar: same than reorient but renders outline and glow in an optimized way for 2D or planar meshes like quads or planes.")]
		public NormalsOption normalsOption;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("Ignore highlighting on this object.")]
		public bool ignore;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		[SerializeField]
		private bool _highlighted;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float fadeInDuration;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float fadeOutDuration;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool flipY;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[Tooltip("Keeps the outline/glow size unaffected by object distance.")]
		public bool constantWidth;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("Mask to include or exclude certain submeshes. By default, all submeshes are included.")]
		public int subMeshMask;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Intensity of the overlay effect. A value of 0 disables the overlay completely.")]
		[Range(0f, 1f)]
		public float overlay;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[ColorUsage(true, true)]
		public Color overlayColor;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float overlayAnimationSpeed;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float overlayMinIntensity;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		[Tooltip("Controls the blending or mix of the overlay color with the natural colors of the object.")]
		public float overlayBlending;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Tooltip("Optional overlay texture.")]
		public Texture2D overlayTexture;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float overlayTextureScale;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[Range(0f, 1f)]
		[Tooltip("Intensity of the outline. A value of 0 disables the outline completely.")]
		public float outline;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[ColorUsage(true, true)]
		public Color outlineColor;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float outlineWidth;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public QualityLevel outlineQuality;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[Range(1f, 8f)]
		[Tooltip("Reduces the quality of the outline but improves performance a bit.")]
		public int outlineDownsampling;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public Visibility outlineVisibility;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public GlowBlendMode glowBlendMode;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool outlineOptimalBlit;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public bool outlineBlitDebug;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBE")]
		[Tooltip("If enabled, this object won't combine the outline with other objects.")]
		public bool outlineIndependent;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Range(0f, 5f)]
		[Tooltip("The intensity of the outer glow effect. A value of 0 disables the glow completely.")]
		public float glow;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float glowWidth;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public QualityLevel glowQuality;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[Range(1f, 8f)]
		[Tooltip("Reduces the quality of the glow but improves performance a bit.")]
		public int glowDownsampling;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[ColorUsage(true, true)]
		public Color glowHQColor;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Tooltip("When enabled, outer glow renders with dithering. When disabled, glow appears as a solid color.")]
		public bool glowDithering;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[Tooltip("Seed for the dithering effect")]
		public float glowMagicNumber1;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Tooltip("Another seed for the dithering effect that combines with first seed to create different patterns")]
		public float glowMagicNumber2;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public float glowAnimationSpeed;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Visibility glowVisibility;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[Tooltip("Performs a blit to screen only over the affected area, instead of a full-screen pass")]
		public bool glowOptimalBlit;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF5")]
		public bool glowBlitDebug;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF6")]
		[Tooltip("Blends glow passes one after another. If this option is disabled, glow passes won't overlap (in this case, make sure the glow pass 1 has a smaller offset than pass 2, etc.)")]
		public bool glowBlendPasses;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[NonReorderable]
		public GlowPassData[] glowPasses;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Tooltip("If enabled, glow effect will not use a stencil mask. This can be used to render the glow effect alone.")]
		public bool glowIgnoreMask;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[Range(0f, 5f)]
		[Tooltip("The intensity of the inner glow effect. A value of 0 disables the glow completely.")]
		public float innerGlow;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[Range(0f, 2f)]
		public float innerGlowWidth;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[ColorUsage(true, true)]
		public Color innerGlowColor;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public Visibility innerGlowVisibility;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[Tooltip("Enables the targetFX effect. This effect draws an animated sprite over the object.")]
		public bool targetFX;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public Texture2D targetFXTexture;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[ColorUsage(true, true)]
		public Color targetFXColor;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public Transform targetFXCenter;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public float targetFXRotationSpeed;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public float targetFXInitialScale;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public float targetFXEndScale;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		[Tooltip("Makes target scale relative to object renderer bounds")]
		public bool targetFXScaleToRenderBounds;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x155")]
		[Tooltip("Places target FX sprite at the bottom of the highlighted object.")]
		public bool targetFXAlignToGround;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[Tooltip("Fade out effect with altitude")]
		public float targetFXFadePower;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		public float targetFXGroundMaxDistance;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public LayerMask targetFXGroundLayerMask;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		public float targetFXTransitionDuration;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[Tooltip("The duration of the effect. A value of 0 will keep the target sprite on screen while object is highlighted.")]
		public float targetFXStayDuration;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		public Visibility targetFXVisibility;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[Tooltip("See-through mode for this Highlight Effect component.")]
		public SeeThroughMode seeThrough;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		[Tooltip("This mask setting let you specify which objects will be considered as occluders and cause the see-through effect for this Highlight Effect component. For example, you assign your walls to a different layer and specify that layer here, so only walls and not other objects, like ground or ceiling, will trigger the see-through effect.")]
		public LayerMask seeThroughOccluderMask;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		[Tooltip("A multiplier for the occluder volume size which can be used to reduce the actual size of occluders when Highlight Effect checks if they're occluding this object.")]
		[Range(0.01f, 0.6f)]
		public float seeThroughOccluderThreshold;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		[Tooltip("Uses stencil buffers to ensure pixel-accurate occlusion test. If this option is disabled, only physics raycasting is used to test for occlusion.")]
		public bool seeThroughOccluderMaskAccurate;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		[Tooltip("The interval of time between occlusion tests.")]
		public float seeThroughOccluderCheckInterval;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		[Tooltip("If enabled, occlusion test is performed for each children element. If disabled, the bounds of all children is combined and a single occlusion test is performed for the combined bounds.")]
		public bool seeThroughOccluderCheckIndividualObjects;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		[Tooltip("Shows the see-through effect only if the occluder if at this 'offset' distance from the object.")]
		public float seeThroughDepthOffset;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		[Tooltip("Hides the see-through effect if the occluder is further than this distance from the object (0 = infinite)")]
		public float seeThroughMaxDepth;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		[Range(0f, 5f)]
		public float seeThroughIntensity;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		[Range(0f, 1f)]
		public float seeThroughTintAlpha;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		[ColorUsage(true, true)]
		public Color seeThroughTintColor;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		[Range(0f, 1f)]
		public float seeThroughNoise;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		[Range(0f, 1f)]
		public float seeThroughBorder;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public Color seeThroughBorderColor;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		[Tooltip("Only display the border instead of the full see-through effect.")]
		public bool seeThroughBorderOnly;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		public float seeThroughBorderWidth;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[Tooltip("Renders see-through effect on overlapping objects in a sequence that's relative to the distance to the camera")]
		public bool seeThroughOrdered;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		[SerializeField]
		[HideInInspector]
		private ModelMaterials[] rms;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		[HideInInspector]
		private int rmsCount;

		[NonSerialized]
		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		public Transform target;

		[NonSerialized]
		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		public float highlightStartTime;

		[NonSerialized]
		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		public float targetFxStartTime;

		[NonSerialized]
		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		public bool isSelected;

		[NonSerialized]
		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		public HighlightProfile previousSettings;

		[Token(Token = "0x400052B")]
		private const float TAU = 0.70711f;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material fxMatMask;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Material fxMatSolidColor;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Material fxMatSeeThroughInner;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Material fxMatSeeThroughBorder;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Material fxMatOverlay;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Material fxMatClearStencil;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Material fxMatGlowRef;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static Material fxMatInnerGlow;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static Material fxMatOutlineRef;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static Material fxMatTargetRef;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static Material fxMatComposeGlowRef;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static Material fxMatComposeOutlineRef;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static Material fxMatBlurGlowRef;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static Material fxMatBlurOutlineRef;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static Material fxMatSeeThroughMask;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private Material _fxMatOutline;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private Material _fxMatGlow;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private Material _fxMatTarget;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private Material _fxMatComposeGlow;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private Material _fxMatComposeOutline;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private Material _fxMatBlurGlow;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private Material _fxMatBlurOutline;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static Vector4[] offsets;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private float fadeStartTime;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
		private FadingState fading;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private CommandBuffer cbMask;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private CommandBuffer cbSeeThrough;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private CommandBuffer cbGlow;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private CommandBuffer cbOutline;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private CommandBuffer cbOverlay;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private CommandBuffer cbInnerGlow;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private CommandBuffer cbSmoothBlend;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private int[] mipGlowBuffers;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private int[] mipOutlineBuffers;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private int glowRT;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2AC")]
		private int outlineRT;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static Mesh quadMesh;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static Mesh cubeMesh;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private int sourceRT;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B4")]
		private Matrix4x4 quadGlowMatrix;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F4")]
		private Matrix4x4 quadOutlineMatrix;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		private Vector3[] corners;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		private RenderTextureDescriptor sourceDesc;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x374")]
		private Color debugColor;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x384")]
		private Color blackColor;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x394")]
		private Visibility lastOutlineVisibility;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
		private bool requireUpdateMaterial;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x399")]
		private bool usingPipeline;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39C")]
		private float occlusionCheckLastTime;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		private int occlusionRenderFrame;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A4")]
		private bool lastOcclusionTestResult;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A5")]
		private bool useGPUInstancing;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		private MaterialPropertyBlock glowPropertyBlock;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		private MaterialPropertyBlock outlinePropertyBlock;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static readonly List<Vector4> matDataDirection;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static readonly List<Vector4> matDataGlow;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static readonly List<Vector4> matDataColor;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static Matrix4x4[] matrices;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public static readonly List<HighlightEffect> effects;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public static bool customSorting;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private static int customSortingFrame;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static Camera customSortingCamera;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
		private int skipThisFrame;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3BC")]
		private int outlineOffsetsMin;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
		private int outlineOffsetsMax;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C4")]
		private int glowOffsetsMin;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
		private int glowOffsetsMax;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static CombineInstance[] combineInstances;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3CC")]
		private Matrix4x4 matrix4X4Identity;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40C")]
		private bool maskRequired;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
		private List<Renderer> tempRR;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static List<Vector3> vertices;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static List<Vector3> normals;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static Vector3[] newNormals;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static int[] matches;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static readonly Dictionary<Vector3, int> vv;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static readonly Dictionary<int, Mesh> smoothMeshes;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static readonly Dictionary<int, Mesh> reorientedMeshes;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static readonly Dictionary<int, Mesh> combinedMeshes;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static readonly List<Material> rendererSharedMaterials;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
		private int combinedMeshesHashId;

		[Token(Token = "0x400057D")]
		private const int MAX_VERTEX_COUNT = 65535;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41C")]
		[Range(0f, 1f)]
		public float hitFxInitialIntensity;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
		public HitFxMode hitFxMode;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x424")]
		public float hitFxFadeOutDuration;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
		[ColorUsage(true, true)]
		public Color hitFxColor;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
		public float hitFxRadius;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x43C")]
		private float hitInitialIntensity;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
		private float hitStartTime;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x444")]
		private float hitFadeOutDuration;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x448")]
		private Color hitColor;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x458")]
		private bool hitActive;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45C")]
		private Vector3 hitPosition;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x468")]
		private float hitRadius;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static readonly List<HighlightSeeThroughOccluder> occluders;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static readonly Dictionary<Camera, int> occludersFrameCount;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static CommandBuffer cbOccluder;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static Material fxMatOccluder;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static RaycastHit[] hits;

		[Token(Token = "0x400058F")]
		private const int MAX_OCCLUDER_HITS = 50;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static RaycastHit[] occluderHits;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x470")]
		private readonly Dictionary<Camera, List<Renderer>> cachedOccludersPerCamera;

		[Token(Token = "0x17000079")]
		public bool highlighted
		{
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x756338", Offset = "0x756338", VA = "0x756338")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x756340", Offset = "0x756340", VA = "0x756340")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public int includedObjectsCount
		{
			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x7569E8", Offset = "0x7569E8", VA = "0x7569E8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700007B")]
		private Material fxMatOutline
		{
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x756A10", Offset = "0x756A10", VA = "0x756A10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		private Material fxMatGlow
		{
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x756B68", Offset = "0x756B68", VA = "0x756B68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		private Material fxMatTarget
		{
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x756CC0", Offset = "0x756CC0", VA = "0x756CC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		private Material fxMatComposeGlow
		{
			[Token(Token = "0x6000600")]
			[Address(RVA = "0x756DF0", Offset = "0x756DF0", VA = "0x756DF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		private Material fxMatComposeOutline
		{
			[Token(Token = "0x6000601")]
			[Address(RVA = "0x756F20", Offset = "0x756F20", VA = "0x756F20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		private Material fxMatBlurGlow
		{
			[Token(Token = "0x6000602")]
			[Address(RVA = "0x757050", Offset = "0x757050", VA = "0x757050")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		private Material fxMatBlurOutline
		{
			[Token(Token = "0x6000603")]
			[Address(RVA = "0x757180", Offset = "0x757180", VA = "0x757180")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000001")]
		public event OnObjectHighlightEvent OnObjectHighlightStart
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x7564E8", Offset = "0x7564E8", VA = "0x7564E8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x756588", Offset = "0x756588", VA = "0x756588")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event OnObjectHighlightEvent OnObjectHighlightEnd
		{
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x756628", Offset = "0x756628", VA = "0x756628")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x7566C8", Offset = "0x7566C8", VA = "0x7566C8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event OnRendererHighlightEvent OnRendererHighlightStart
		{
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x756768", Offset = "0x756768", VA = "0x756768")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x756808", Offset = "0x756808", VA = "0x756808")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event OnTargetAnimatesEvent OnTargetAnimates
		{
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x7568A8", Offset = "0x7568A8", VA = "0x7568A8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x756948", Offset = "0x756948", VA = "0x756948")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x7569F0", Offset = "0x7569F0", VA = "0x7569F0")]
		public void RestorePreviousHighlightEffectSettings()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x7572B0", Offset = "0x7572B0", VA = "0x7572B0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x7582B0", Offset = "0x7582B0", VA = "0x7582B0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x759CF4", Offset = "0x759CF4", VA = "0x759CF4")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x759CF8", Offset = "0x759CF8", VA = "0x759CF8")]
		private void DestroyMaterial(Material mat)
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x759D80", Offset = "0x759D80", VA = "0x759D80")]
		private void DestroyMaterialArray(Material[] mm)
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x759DD8", Offset = "0x759DD8", VA = "0x759DD8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x75A084", Offset = "0x75A084", VA = "0x75A084")]
		public static void DrawEffectsNow([Optional] Camera cam)
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x75A40C", Offset = "0x75A40C", VA = "0x75A40C")]
		private void OnRenderObject()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x75A43C", Offset = "0x75A43C", VA = "0x75A43C")]
		public void ProfileLoad(HighlightProfile profile)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x75A4E0", Offset = "0x75A4E0", VA = "0x75A4E0")]
		public void ProfileReload()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x75A568", Offset = "0x75A568", VA = "0x75A568")]
		public void ProfileSaveChanges(HighlightProfile profile)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x75A5FC", Offset = "0x75A5FC", VA = "0x75A5FC")]
		public void ProfileSaveChanges()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x75A684", Offset = "0x75A684", VA = "0x75A684")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x75A220", Offset = "0x75A220", VA = "0x75A220")]
		private void DoOnRenderObject(Camera cam)
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x75A6AC", Offset = "0x75A6AC", VA = "0x75A6AC")]
		private void RenderEffect(Camera cam)
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x760150", Offset = "0x760150", VA = "0x760150")]
		private void RenderMask(int k, Mesh mesh, bool alwaysOnTop)
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x7605AC", Offset = "0x7605AC", VA = "0x7605AC")]
		private void RenderSeeThroughClearStencil(int k, Mesh mesh)
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x7607C4", Offset = "0x7607C4", VA = "0x7607C4")]
		private void RenderSeeThroughMask(int k, Mesh mesh)
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x760A44", Offset = "0x760A44", VA = "0x760A44")]
		private bool ComputeSmoothQuadMatrix(Camera cam, Bounds bounds)
		{
			return default(bool);
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x762040", Offset = "0x762040", VA = "0x762040")]
		private void BuildMatrix(Camera cam, Vector3 scrMin, Vector3 scrMax, int border, ref Matrix4x4 quadMatrix)
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x760DFC", Offset = "0x760DFC", VA = "0x760DFC")]
		private void SmoothGlow(int rtWidth, int rtHeight)
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x761338", Offset = "0x761338", VA = "0x761338")]
		private void SmoothOutline(int rtWidth, int rtHeight)
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x761874", Offset = "0x761874", VA = "0x761874")]
		private void ComposeSmoothBlend(Visibility smoothGlowVisibility, Visibility smoothOutlineVisibility)
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x76228C", Offset = "0x76228C", VA = "0x76228C")]
		private void InitMaterial(ref Material material, string shaderName)
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x76241C", Offset = "0x76241C", VA = "0x76241C")]
		public void SetTarget(Transform transform)
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x762574", Offset = "0x762574", VA = "0x762574")]
		public void SetTargets(Transform transform, Renderer[] renderers)
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x756348", Offset = "0x756348", VA = "0x756348")]
		public void SetHighlighted(bool state)
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x7624EC", Offset = "0x7624EC", VA = "0x7624EC")]
		private void ImmediateFadeOut()
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x757F08", Offset = "0x757F08", VA = "0x757F08")]
		private void SetupMaterial()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x762628", Offset = "0x762628", VA = "0x762628")]
		private void SetupMaterial(Renderer[] rr)
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x762E18", Offset = "0x762E18", VA = "0x762E18")]
		private Renderer[] FindRenderersWithLayerInScene(LayerMask layer)
		{
			return null;
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x763050", Offset = "0x763050", VA = "0x763050")]
		private Renderer[] FindRenderersWithLayerInChildren(LayerMask layer)
		{
			return null;
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x757C04", Offset = "0x757C04", VA = "0x757C04")]
		private void CheckGeometrySupportDependencies()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x764B1C", Offset = "0x764B1C", VA = "0x764B1C")]
		private void CheckRequiredCommandBuffers()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x76326C", Offset = "0x76326C", VA = "0x76326C")]
		private void CheckCommandBuffers()
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x7604D4", Offset = "0x7604D4", VA = "0x7604D4")]
		private void CheckBlurCommandBuffer()
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x7634C4", Offset = "0x7634C4", VA = "0x7634C4")]
		private void Fork(Material mat, ref Material[] mats, Mesh mesh)
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x75FD28", Offset = "0x75FD28", VA = "0x75FD28")]
		private void BakeTransform(int objIndex, bool duplicateMesh)
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x764C74", Offset = "0x764C74", VA = "0x764C74")]
		public void UpdateMaterialProperties(bool forceNow = false)
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x7582B4", Offset = "0x7582B4", VA = "0x7582B4")]
		private void UpdateMaterialPropertiesNow()
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x760994", Offset = "0x760994", VA = "0x760994")]
		private float ComputeCameraDistanceFade(Vector3 position, Transform cameraTransform)
		{
			return default(float);
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x76226C", Offset = "0x76226C", VA = "0x76226C")]
		private int GetZTestValue(Visibility param)
		{
			return default(int);
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x757870", Offset = "0x757870", VA = "0x757870")]
		private void BuildQuad()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x757B64", Offset = "0x757B64", VA = "0x757B64")]
		private void BuildCube()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x764CAC", Offset = "0x764CAC", VA = "0x764CAC")]
		public bool Includes(Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x764D78", Offset = "0x764D78", VA = "0x764D78")]
		public void SetGlowColor(Color color)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x763C98", Offset = "0x763C98", VA = "0x763C98")]
		private void AverageNormals(int objIndex)
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x763688", Offset = "0x763688", VA = "0x763688")]
		private void ReorientNormals(int objIndex)
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x7645B4", Offset = "0x7645B4", VA = "0x7645B4")]
		private void CombineMeshes()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x764DFC", Offset = "0x764DFC", VA = "0x764DFC")]
		public void HitFX()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x764E84", Offset = "0x764E84", VA = "0x764E84")]
		public void HitFX(Vector3 position)
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x764E18", Offset = "0x764E18", VA = "0x764E18")]
		public void HitFX(Color color, float fadeOutDuration, float initialIntensity = 1f)
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x764ED0", Offset = "0x764ED0", VA = "0x764ED0")]
		public void HitFX(Color color, float fadeOutDuration, float initialIntensity, Vector3 position, float radius)
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x764F70", Offset = "0x764F70", VA = "0x764F70")]
		public void TargetFX()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x764FC8", Offset = "0x764FC8", VA = "0x764FC8")]
		public bool IsSeeThroughOccluded(Camera cam)
		{
			return default(bool);
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x765524", Offset = "0x765524", VA = "0x765524")]
		public static void RegisterOccluder(HighlightSeeThroughOccluder occluder)
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x76564C", Offset = "0x76564C", VA = "0x76564C")]
		public static void UnregisterOccluder(HighlightSeeThroughOccluder occluder)
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x75E5A4", Offset = "0x75E5A4", VA = "0x75E5A4")]
		public bool RenderSeeThroughOccluders(Camera cam)
		{
			return default(bool);
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x75F5E8", Offset = "0x75F5E8", VA = "0x75F5E8")]
		private bool CheckOcclusion(Camera cam)
		{
			return default(bool);
		}

		[Token(Token = "0x600063F")]
		private void AddWithoutRepetition<T>(List<T> target, List<T> source)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x75EAB8", Offset = "0x75EAB8", VA = "0x75EAB8")]
		private void CheckOcclusionAccurate(Camera cam)
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x76571C", Offset = "0x76571C", VA = "0x76571C")]
		public List<Renderer> GetOccluders(Camera camera)
		{
			return null;
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x765788", Offset = "0x765788", VA = "0x765788")]
		public HighlightEffect()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public enum HitFxMode
	{
		[Token(Token = "0x40005AB")]
		Overlay,
		[Token(Token = "0x40005AC")]
		InnerGlow,
		[Token(Token = "0x40005AD")]
		LocalHit
	}
	[Token(Token = "0x20000E4")]
	public delegate bool OnObjectSelectionEvent(GameObject obj);
	[Token(Token = "0x20000E5")]
	[RequireComponent(typeof(HighlightEffect))]
	[DefaultExecutionOrder(100)]
	[HelpURL("https://www.dropbox.com/s/v9qgn68ydblqz8x/Documentation.pdf?dl=0")]
	public class HighlightManager : MonoBehaviour
	{
		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Enables highlight when pointer is over this object.")]
		public bool highlightOnHover;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LayerMask layerMask;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Camera raycastCamera;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayCastSource raycastSource;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Minimum distance for target.")]
		public float minDistance;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Maximum distance for target. 0 = infinity")]
		public float maxDistance;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Blocks interaction if pointer is over an UI element")]
		public bool respectUI;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		[Tooltip("If the object will be selected by clicking with mouse or tapping on it.")]
		public bool selectOnClick;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Optional profile for objects selected by clicking on them")]
		public HighlightProfile selectedProfile;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Profile to use whtn object is selected and highlighted.")]
		public HighlightProfile selectedAndHighlightedProfile;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Automatically deselects other previously selected objects")]
		public bool singleSelection;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[Tooltip("Toggles selection on/off when clicking object")]
		public bool toggle;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private HighlightEffect baseEffect;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private HighlightEffect currentEffect;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform currentObject;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly List<HighlightEffect> selectedObjects;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static int lastTriggerTime;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static HighlightManager _instance;

		[Token(Token = "0x17000083")]
		public static HighlightManager instance
		{
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x766444", Offset = "0x766444", VA = "0x766444")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000005")]
		public event OnObjectSelectionEvent OnObjectSelected
		{
			[Token(Token = "0x600064A")]
			[Address(RVA = "0x765F64", Offset = "0x765F64", VA = "0x765F64")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600064B")]
			[Address(RVA = "0x766000", Offset = "0x766000", VA = "0x766000")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event OnObjectSelectionEvent OnObjectUnSelected
		{
			[Token(Token = "0x600064C")]
			[Address(RVA = "0x76609C", Offset = "0x76609C", VA = "0x76609C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600064D")]
			[Address(RVA = "0x766138", Offset = "0x766138", VA = "0x766138")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event OnObjectHighlightEvent OnObjectHighlightStart
		{
			[Token(Token = "0x600064E")]
			[Address(RVA = "0x7661D4", Offset = "0x7661D4", VA = "0x7661D4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600064F")]
			[Address(RVA = "0x766270", Offset = "0x766270", VA = "0x766270")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		public event OnObjectHighlightEvent OnObjectHighlightEnd
		{
			[Token(Token = "0x6000650")]
			[Address(RVA = "0x76630C", Offset = "0x76630C", VA = "0x76630C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x7663A8", Offset = "0x7663A8", VA = "0x7663A8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x76654C", Offset = "0x76654C", VA = "0x76654C")]
		[RuntimeInitializeOnLoadMethod]
		private void DomainReloadDisabledSupport()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x7665F0", Offset = "0x7665F0", VA = "0x7665F0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x766904", Offset = "0x766904", VA = "0x766904")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x766E70", Offset = "0x766E70", VA = "0x766E70")]
		private void Update()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x7675C0", Offset = "0x7675C0", VA = "0x7675C0")]
		private EventSystem CreateEventSystem()
		{
			return null;
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x766920", Offset = "0x766920", VA = "0x766920")]
		private void SwitchesCollider(Transform newObject)
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x7680D4", Offset = "0x7680D4", VA = "0x7680D4")]
		private bool CanInteract()
		{
			return default(bool);
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x767A04", Offset = "0x767A04", VA = "0x767A04")]
		private void ToggleSelection(Transform t, bool forceSelection)
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x767EA4", Offset = "0x767EA4", VA = "0x767EA4")]
		private void Highlight(bool state)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x766838", Offset = "0x766838", VA = "0x766838")]
		public static Camera GetCamera()
		{
			return null;
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x766BCC", Offset = "0x766BCC", VA = "0x766BCC")]
		private void internal_DeselectAll()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x7687EC", Offset = "0x7687EC", VA = "0x7687EC")]
		public static void DeselectAll()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x768AD4", Offset = "0x768AD4", VA = "0x768AD4")]
		public void SelectObject(Transform t)
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x768ADC", Offset = "0x768ADC", VA = "0x768ADC")]
		public void ToggleObject(Transform t)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x768AE4", Offset = "0x768AE4", VA = "0x768AE4")]
		public void UnselectObject(Transform t)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x768C98", Offset = "0x768C98", VA = "0x768C98")]
		public HighlightManager()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	[HelpURL("https://www.dropbox.com/s/v9qgn68ydblqz8x/Documentation.pdf?dl=0")]
	[CreateAssetMenu(menuName = "Highlight Plus Profile", fileName = "Highlight Plus Profile", order = 100)]
	public class HighlightProfile : ScriptableObject
	{
		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Different options to specify which objects are affected by this Highlight Effect component.")]
		public TargetOptions effectGroup;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The layer that contains the affected objects by this effect when effectGroup is set to LayerMask.")]
		public LayerMask effectGroupLayer;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Only include objects whose names contains this text.")]
		public string effectNameFilter;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Combine meshes of all objects in this group affected by Highlight Effect reducing draw calls.")]
		public bool combineMeshes;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("The alpha threshold for transparent cutout objects. Pixels with alpha below this value will be discarded.")]
		[Range(0f, 1f)]
		public float alphaCutOff;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("If back facing triangles are ignored.Backfaces triangles are not visible but you may set this property to false to force highlight effects to act on those triangles as well.")]
		public bool cullBackFaces;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool depthClip;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Normals handling option:\nPreserve original: use original mesh normals.\nSmooth: average normals to produce a smoother outline/glow mesh based effect.\nReorient: recomputes normals based on vertex direction to centroid.")]
		public NormalsOption normalsOption;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float fadeInDuration;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float fadeOutDuration;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Fades out effects based on distance to camera")]
		public bool cameraDistanceFade;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The closest distance particles can get to the camera before they fade from the camera’s view.")]
		public float cameraDistanceFadeNear;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The farthest distance particles can get away from the camera before they fade from the camera’s view.")]
		public float cameraDistanceFadeFar;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("Keeps the outline/glow size unaffected by object distance.")]
		public bool constantWidth;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		[Tooltip("Intensity of the overlay effect. A value of 0 disables the overlay completely.")]
		public float overlay;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[ColorUsage(true, true)]
		public Color overlayColor;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float overlayAnimationSpeed;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Range(0f, 1f)]
		public float overlayMinIntensity;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Range(0f, 1f)]
		[Tooltip("Controls the blending or mix of the overlay color with the natural colors of the object.")]
		public float overlayBlending;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("Optional overlay texture.")]
		public Texture2D overlayTexture;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float overlayTextureScale;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Tooltip("Intensity of the outline. A value of 0 disables the outline completely.")]
		[Range(0f, 1f)]
		public float outline;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[ColorUsage(true, true)]
		public Color outlineColor;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float outlineWidth;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public QualityLevel outlineQuality;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[Range(1f, 8f)]
		[Tooltip("Reduces the quality of the outline but improves performance a bit.")]
		public int outlineDownsampling;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool outlineOptimalBlit;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Visibility outlineVisibility;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[Tooltip("If enabled, this object won't combine the outline with other objects.")]
		public bool outlineIndependent;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[Range(0f, 5f)]
		[Tooltip("The intensity of the outer glow effect. A value of 0 disables the glow completely.")]
		public float glow;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float glowWidth;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public QualityLevel glowQuality;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(1f, 8f)]
		[Tooltip("Reduces the quality of the glow but improves performance a bit.")]
		public int glowDownsampling;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[ColorUsage(true, true)]
		public Color glowHQColor;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Tooltip("When enabled, outer glow renders with dithering. When disabled, glow appears as a solid color.")]
		public bool glowDithering;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		public bool glowOptimalBlit;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[Tooltip("Seed for the dithering effect")]
		public float glowMagicNumber1;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[Tooltip("Another seed for the dithering effect that combines with first seed to create different patterns")]
		public float glowMagicNumber2;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float glowAnimationSpeed;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Visibility glowVisibility;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public GlowBlendMode glowBlendMode;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Tooltip("Blends glow passes one after another. If this option is disabled, glow passes won't overlap (in this case, make sure the glow pass 1 has a smaller offset than pass 2, etc.)")]
		public bool glowBlendPasses;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public GlowPassData[] glowPasses;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[Tooltip("If enabled, glow effect will not use a stencil mask. This can be used to render the glow effect alone.")]
		public bool glowIgnoreMask;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[Range(0f, 5f)]
		[Tooltip("The intensity of the inner glow effect. A value of 0 disables the glow completely.")]
		public float innerGlow;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[Range(0f, 2f)]
		public float innerGlowWidth;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[ColorUsage(true, true)]
		public Color innerGlowColor;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public Visibility innerGlowVisibility;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[Tooltip("Enables the targetFX effect. This effect draws an animated sprite over the object.")]
		public bool targetFX;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public Texture2D targetFXTexture;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[ColorUsage(true, true)]
		public Color targetFXColor;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public float targetFXRotationSpeed;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		public float targetFXInitialScale;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public float targetFXEndScale;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[Tooltip("Makes target scale relative to object renderer bounds.")]
		public bool targetFXScaleToRenderBounds;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13D")]
		[Tooltip("Places target FX sprite at the bottom of the highlighted object.")]
		public bool targetFXAlignToGround;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[Tooltip("Max distance from the center of the highlighted object to the ground.")]
		public float targetFXGroundMaxDistance;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public LayerMask targetFXGroundLayerMask;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[Tooltip("Fade out effect with altitude")]
		public float targetFXFadePower;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public float targetFXTransitionDuration;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public float targetFXStayDuration;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		public Visibility targetFXVisibility;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[Tooltip("See-through mode for this Highlight Effect component.")]
		public SeeThroughMode seeThrough;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		[Tooltip("This mask setting let you specify which objects will be considered as occluders and cause the see-through effect for this Highlight Effect component. For example, you assign your walls to a different layer and specify that layer here, so only walls and not other objects, like ground or ceiling, will trigger the see-through effect.")]
		public LayerMask seeThroughOccluderMask;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[Tooltip("Uses stencil buffers to ensure pixel-accurate occlusion test. If this option is disabled, only physics raycasting is used to test for occlusion.")]
		public bool seeThroughOccluderMaskAccurate;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		[Tooltip("A multiplier for the occluder volume size which can be used to reduce the actual size of occluders when Highlight Effect checks if they're occluding this object.")]
		[Range(0.01f, 0.9f)]
		public float seeThroughOccluderThreshold;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[Tooltip("The interval of time between occlusion tests.")]
		public float seeThroughOccluderCheckInterval;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		[Tooltip("If enabled, occlusion test is performed for each children element. If disabled, the bounds of all children is combined and a single occlusion test is performed for the combined bounds.")]
		public bool seeThroughOccluderCheckIndividualObjects;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[Tooltip("Shows the see-through effect only if the occluder if at this 'offset' distance from the object.")]
		public float seeThroughDepthOffset;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		[Tooltip("Hides the see-through effect if the occluder is further than this distance from the object (0 = infinite)")]
		public float seeThroughMaxDepth;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[Range(0f, 5f)]
		public float seeThroughIntensity;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		[Range(0f, 1f)]
		public float seeThroughTintAlpha;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public Color seeThroughTintColor;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[Range(0f, 1f)]
		public float seeThroughNoise;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		[Range(0f, 1f)]
		public float seeThroughBorder;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public Color seeThroughBorderColor;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public float seeThroughBorderWidth;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		[Tooltip("Only display the border instead of the full see-through effect.")]
		public bool seeThroughBorderOnly;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AD")]
		[Tooltip("Renders see-through effect on overlapping objects in a sequence that's relative to the distance to the camera")]
		public bool seeThroughOrdered;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		[Range(0f, 1f)]
		public float hitFxInitialIntensity;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		public HitFxMode hitFxMode;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public float hitFxFadeOutDuration;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		[ColorUsage(true, true)]
		public Color hitFxColor;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		public float hitFxRadius;

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x768558", Offset = "0x768558", VA = "0x768558")]
		public void Load(HighlightEffect effect)
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x7682E0", Offset = "0x7682E0", VA = "0x7682E0")]
		public void Save(HighlightEffect effect)
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x768D6C", Offset = "0x768D6C", VA = "0x768D6C")]
		private GlowPassData[] GetGlowPassesCopy(GlowPassData[] glowPasses)
		{
			return null;
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x768E40", Offset = "0x768E40", VA = "0x768E40")]
		public void OnValidate()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x768F8C", Offset = "0x768F8C", VA = "0x768F8C")]
		public HighlightProfile()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public struct MeshData
	{
		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Renderer renderer;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int subMeshCount;
	}
	[Token(Token = "0x20000E8")]
	public enum DetectionMethod
	{
		[Token(Token = "0x400061B")]
		Stencil,
		[Token(Token = "0x400061C")]
		RayCast
	}
	[Token(Token = "0x20000E9")]
	[ExecuteInEditMode]
	public class HighlightSeeThroughOccluder : MonoBehaviour
	{
		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DetectionMethod detectionMethod;

		[NonSerialized]
		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MeshData[] meshData;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Renderer> rr;

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x769120", Offset = "0x769120", VA = "0x769120")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x769158", Offset = "0x769158", VA = "0x769158")]
		private void Init()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x7695A4", Offset = "0x7695A4", VA = "0x7695A4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x7695FC", Offset = "0x7695FC", VA = "0x7695FC")]
		public HighlightSeeThroughOccluder()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public enum TriggerMode
	{
		[Token(Token = "0x4000621")]
		ColliderEventsOnlyOnThisObject,
		[Token(Token = "0x4000622")]
		RaycastOnThisObjectAndChildren,
		[Token(Token = "0x4000623")]
		Volume
	}
	[Token(Token = "0x20000EB")]
	public enum RayCastSource
	{
		[Token(Token = "0x4000625")]
		MousePosition,
		[Token(Token = "0x4000626")]
		CameraDirection
	}
	[Token(Token = "0x20000EC")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(HighlightEffect))]
	[HelpURL("https://www.dropbox.com/s/v9qgn68ydblqz8x/Documentation.pdf?dl=0")]
	public class HighlightTrigger : MonoBehaviour
	{
		[Token(Token = "0x20000ED")]
		[CompilerGenerated]
		private sealed class <DoRayCast>d__38 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HighlightTrigger <>4__this;

			[Token(Token = "0x17000085")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600068A")]
				[Address(RVA = "0x76B4AC", Offset = "0x76B4AC", VA = "0x76B4AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000086")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600068C")]
				[Address(RVA = "0x76B4F4", Offset = "0x76B4F4", VA = "0x76B4F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000687")]
			[Address(RVA = "0x76A174", Offset = "0x76A174", VA = "0x76A174")]
			[DebuggerHidden]
			public <DoRayCast>d__38(int <>1__state)
			{
			}

			[Token(Token = "0x6000688")]
			[Address(RVA = "0x76AC50", Offset = "0x76AC50", VA = "0x76AC50", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000689")]
			[Address(RVA = "0x76AC54", Offset = "0x76AC54", VA = "0x76AC54", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600068B")]
			[Address(RVA = "0x76B4B4", Offset = "0x76B4B4", VA = "0x76B4B4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Enables highlight when pointer is over this object.")]
		public bool highlightOnHover;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Used to trigger automatic highlighting including children objects.")]
		public TriggerMode triggerMode;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Camera raycastCamera;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayCastSource raycastSource;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Minimum distance for target.")]
		public float minDistance;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Maximum distance for target. 0 = infinity")]
		public float maxDistance;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Blocks interaction if pointer is over an UI element")]
		public bool respectUI;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public LayerMask volumeLayerMask;

		[Token(Token = "0x400062F")]
		private const int MAX_RAYCAST_HITS = 100;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("If the object will be selected by clicking with mouse or tapping on it.")]
		public bool selectOnClick;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Profile to use when object is selected by clicking on it.")]
		public HighlightProfile selectedProfile;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Profile to use whtn object is selected and highlighted.")]
		public HighlightProfile selectedAndHighlightedProfile;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Automatically deselects any other selected object prior selecting this one")]
		public bool singleSelection;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		[Tooltip("Toggles selection on/off when clicking object")]
		public bool toggle;

		[NonSerialized]
		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Collider[] colliders;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Collider currentCollider;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static RaycastHit[] hits;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private HighlightEffect hb;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TriggerMode currentTriggerMode;

		[Token(Token = "0x17000084")]
		public HighlightEffect highlightEffect
		{
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x769604", Offset = "0x769604", VA = "0x769604")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000009")]
		public event OnObjectSelectionEvent OnObjectSelected
		{
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x76960C", Offset = "0x76960C", VA = "0x76960C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600066F")]
			[Address(RVA = "0x7696A8", Offset = "0x7696A8", VA = "0x7696A8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event OnObjectSelectionEvent OnObjectUnSelected
		{
			[Token(Token = "0x6000670")]
			[Address(RVA = "0x769744", Offset = "0x769744", VA = "0x769744")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000671")]
			[Address(RVA = "0x7697E0", Offset = "0x7697E0", VA = "0x7697E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public event OnObjectHighlightEvent OnObjectHighlightStart
		{
			[Token(Token = "0x6000672")]
			[Address(RVA = "0x76987C", Offset = "0x76987C", VA = "0x76987C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000673")]
			[Address(RVA = "0x769918", Offset = "0x769918", VA = "0x769918")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000C")]
		public event OnObjectHighlightEvent OnObjectHighlightEnd
		{
			[Token(Token = "0x6000674")]
			[Address(RVA = "0x7699B4", Offset = "0x7699B4", VA = "0x7699B4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000675")]
			[Address(RVA = "0x769A50", Offset = "0x769A50", VA = "0x769A50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x769AEC", Offset = "0x769AEC", VA = "0x769AEC")]
		[RuntimeInitializeOnLoadMethod]
		private void DomainReloadDisabledSupport()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x769B84", Offset = "0x769B84", VA = "0x769B84")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x769CF0", Offset = "0x769CF0", VA = "0x769CF0")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x769B88", Offset = "0x769B88", VA = "0x769B88")]
		public void Init()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x769EA0", Offset = "0x769EA0", VA = "0x769EA0")]
		private void Start()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x769E2C", Offset = "0x769E2C", VA = "0x769E2C")]
		[IteratorStateMachine(typeof(<DoRayCast>d__38))]
		private IEnumerator DoRayCast()
		{
			return null;
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x76A19C", Offset = "0x76A19C", VA = "0x76A19C")]
		private EventSystem CreateEventSystem()
		{
			return null;
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x76A344", Offset = "0x76A344", VA = "0x76A344")]
		private void SwitchCollider(Collider newCollider)
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x76A62C", Offset = "0x76A62C", VA = "0x76A62C")]
		private bool CanInteract()
		{
			return default(bool);
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x76A734", Offset = "0x76A734", VA = "0x76A734")]
		private void OnMouseDown()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x76AAC0", Offset = "0x76AAC0", VA = "0x76AAC0")]
		private void OnMouseEnter()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x76AB00", Offset = "0x76AB00", VA = "0x76AB00")]
		private void OnMouseExit()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x76A3FC", Offset = "0x76A3FC", VA = "0x76A3FC")]
		private void Highlight(bool state)
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x76A794", Offset = "0x76A794", VA = "0x76A794")]
		private void ToggleSelection()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x76AB40", Offset = "0x76AB40", VA = "0x76AB40")]
		public void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x76ABBC", Offset = "0x76ABBC", VA = "0x76ABBC")]
		public void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x76AC38", Offset = "0x76AC38", VA = "0x76AC38")]
		public HighlightTrigger()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public static class InputProxy
	{
		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3 lastPointerPosition;

		[Token(Token = "0x17000087")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x600068E")]
			[Address(RVA = "0x767768", Offset = "0x767768", VA = "0x767768")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000088")]
		public static int touchCount
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x7681DC", Offset = "0x7681DC", VA = "0x7681DC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x7668E0", Offset = "0x7668E0", VA = "0x7668E0")]
		public static void Init()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x7678BC", Offset = "0x7678BC", VA = "0x7678BC")]
		public static bool GetMouseButtonDown(int buttonIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x768240", Offset = "0x768240", VA = "0x768240")]
		public static int GetFingerIdFromTouch(int touchIndex)
		{
			return default(int);
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x76B4FC", Offset = "0x76B4FC", VA = "0x76B4FC")]
		public static bool GetKeyDown(string name)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000EF")]
	public static class ShaderParams
	{
		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int Cull;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static int BlurScale;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static int Speed;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static int ConstantWidth;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static int CutOff;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static int ZTest;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static int Flip;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static int Debug;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static int Color;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static int MainTex;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static int BlendSrc;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static int BlendDst;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static int OutlineWidth;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static int OutlineZTest;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static int OutlineDirection;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static int OutlineColor;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static int OutlineVertexWidth;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static int GlowZTest;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static int GlowStencilComp;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public static int GlowStencilOp;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static int GlowDirection;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public static int Glow;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static int GlowColor;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public static int Glow2;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static int SeeThrough;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public static int SeeThroughNoise;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static int SeeThroughBorderWidth;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public static int SeeThroughBorderConstantWidth;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static int SeeThroughTintColor;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public static int SeeThroughBorderColor;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static int SeeThroughStencilRef;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public static int SeeThroughStencilComp;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static int SeeThroughStencilPassOp;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public static int SeeThroughDepthOffset;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static int SeeThroughMaxDepth;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public static int SeeThroughOrdered;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static int InnerGlowWidth;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public static int InnerGlowZTest;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public static int InnerGlowColor;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public static int OverlayData;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public static int OverlayBackColor;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public static int OverlayColor;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public static int OverlayHitPosData;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public static int OverlayHitStartTime;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public static int OverlayTexture;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public static int TargetFXRenderData;

		[Token(Token = "0x4000670")]
		public const string SKW_ALPHACLIP = "HP_ALPHACLIP";

		[Token(Token = "0x4000671")]
		public const string SKW_DEPTHCLIP = "HP_DEPTHCLIP";

		[Token(Token = "0x4000672")]
		public const string SKW_DEPTH_OFFSET = "HP_DEPTH_OFFSET";

		[Token(Token = "0x4000673")]
		public const string SKW_USES_OVERLAY_TEXTURE = "HP_USES_OVERLAY_TEXTURE";

		[Token(Token = "0x4000674")]
		public const string SKW_SEETHROUGH_ONLY_BORDER = "HP_SEETHROUGH_ONLY_BORDER";
	}
}
namespace HighlightPlus.Demos
{
	[Token(Token = "0x20000F0")]
	public class HitFxDemo : MonoBehaviour
	{
		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip hitSound;

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x76BE00", Offset = "0x76BE00", VA = "0x76BE00")]
		private void Update()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x76BF3C", Offset = "0x76BF3C", VA = "0x76BF3C")]
		public HitFxDemo()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class ManualSelectionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private HighlightManager hm;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform objectToSelect;

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x76BF44", Offset = "0x76BF44", VA = "0x76BF44")]
		private void Start()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x76BFBC", Offset = "0x76BFBC", VA = "0x76BFBC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x76C03C", Offset = "0x76C03C", VA = "0x76C03C")]
		public ManualSelectionDemo()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class SphereHighlightEventExample : MonoBehaviour
	{
		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private HighlightEffect effect;

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x76C044", Offset = "0x76C044", VA = "0x76C044")]
		private void Start()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x76C10C", Offset = "0x76C10C", VA = "0x76C10C")]
		private bool ValidateHighlightObject(GameObject obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x76C114", Offset = "0x76C114", VA = "0x76C114")]
		private void HighlightStart()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x76C17C", Offset = "0x76C17C", VA = "0x76C17C")]
		private void HighlightEnd()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x76C1E4", Offset = "0x76C1E4", VA = "0x76C1E4")]
		private void Update()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x76C2D8", Offset = "0x76C2D8", VA = "0x76C2D8")]
		public SphereHighlightEventExample()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public class SphereSelectionEventsExample : MonoBehaviour
	{
		[Token(Token = "0x600069F")]
		[Address(RVA = "0x76C2E0", Offset = "0x76C2E0", VA = "0x76C2E0")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x76C3E4", Offset = "0x76C3E4", VA = "0x76C3E4")]
		private bool OnObjectSelected(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x76C480", Offset = "0x76C480", VA = "0x76C480")]
		private bool OnObjectUnSelected(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x76C51C", Offset = "0x76C51C", VA = "0x76C51C")]
		public SphereSelectionEventsExample()
		{
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x20000F4")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x76C524", Offset = "0x76C524", VA = "0x76C524")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x76C6D8", Offset = "0x76C6D8", VA = "0x76C6D8")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x76C864", Offset = "0x76C864", VA = "0x76C864")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x76CA04", Offset = "0x76CA04", VA = "0x76CA04")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x76CA6C", Offset = "0x76CA6C", VA = "0x76CA6C")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x76CAD4", Offset = "0x76CAD4", VA = "0x76CAD4")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x76CB2C", Offset = "0x76CB2C", VA = "0x76CB2C")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x76CBA4", Offset = "0x76CBA4", VA = "0x76CBA4")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x76CBFC", Offset = "0x76CBFC", VA = "0x76CBFC")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x76CC54", Offset = "0x76CC54", VA = "0x76CC54")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x76CCAC", Offset = "0x76CCAC", VA = "0x76CCAC")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x76CD04", Offset = "0x76CD04", VA = "0x76CD04")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x76CD64", Offset = "0x76CD64", VA = "0x76CD64")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x76CDC0", Offset = "0x76CDC0", VA = "0x76CDC0")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x76CE18", Offset = "0x76CE18", VA = "0x76CE18")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000F8")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x76CF38", Offset = "0x76CF38", VA = "0x76CF38")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x76D0F0", Offset = "0x76D0F0", VA = "0x76D0F0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x76D29C", Offset = "0x76D29C", VA = "0x76D29C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x76D448", Offset = "0x76D448", VA = "0x76D448")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x76D5F4", Offset = "0x76D5F4", VA = "0x76D5F4")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x76D7A8", Offset = "0x76D7A8", VA = "0x76D7A8")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x76DA10", Offset = "0x76DA10", VA = "0x76DA10")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x76DF1C", Offset = "0x76DF1C", VA = "0x76DF1C")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x76E190", Offset = "0x76E190", VA = "0x76E190")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x76E424", Offset = "0x76E424", VA = "0x76E424")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x76E5F8", Offset = "0x76E5F8", VA = "0x76E5F8")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x2000104")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x76EC0C", Offset = "0x76EC0C", VA = "0x76EC0C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x76EDBC", Offset = "0x76EDBC", VA = "0x76EDBC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x76EF64", Offset = "0x76EF64", VA = "0x76EF64")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x76F10C", Offset = "0x76F10C", VA = "0x76F10C")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x76F29C", Offset = "0x76F29C", VA = "0x76F29C")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x76F6D0", Offset = "0x76F6D0", VA = "0x76F6D0")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x76F9C4", Offset = "0x76F9C4", VA = "0x76F9C4")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x76FCDC", Offset = "0x76FCDC", VA = "0x76FCDC")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x76FEB0", Offset = "0x76FEB0", VA = "0x76FEB0")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x200010E")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x7704DC", Offset = "0x7704DC", VA = "0x7704DC")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x770690", Offset = "0x770690", VA = "0x770690")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x77081C", Offset = "0x77081C", VA = "0x77081C")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x7709F8", Offset = "0x7709F8", VA = "0x7709F8")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000112")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x2000113")]
		public static class Utils
		{
			[Token(Token = "0x600073D")]
			[Address(RVA = "0x7757BC", Offset = "0x7757BC", VA = "0x7757BC")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x770CF0", Offset = "0x770CF0", VA = "0x770CF0")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x770E7C", Offset = "0x770E7C", VA = "0x770E7C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x771030", Offset = "0x771030", VA = "0x771030")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x7711BC", Offset = "0x7711BC", VA = "0x7711BC")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x771370", Offset = "0x771370", VA = "0x771370")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x7714FC", Offset = "0x7714FC", VA = "0x7714FC")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x7716AC", Offset = "0x7716AC", VA = "0x7716AC")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x771890", Offset = "0x771890", VA = "0x771890")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x771A3C", Offset = "0x771A3C", VA = "0x771A3C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x771BE8", Offset = "0x771BE8", VA = "0x771BE8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x771D94", Offset = "0x771D94", VA = "0x771D94")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x771F48", Offset = "0x771F48", VA = "0x771F48")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x7720D4", Offset = "0x7720D4", VA = "0x7720D4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x772270", Offset = "0x772270", VA = "0x772270")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x77241C", Offset = "0x77241C", VA = "0x77241C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x7725C0", Offset = "0x7725C0", VA = "0x7725C0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x772764", Offset = "0x772764", VA = "0x772764")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x772918", Offset = "0x772918", VA = "0x772918")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x772AC0", Offset = "0x772AC0", VA = "0x772AC0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x772C68", Offset = "0x772C68", VA = "0x772C68")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x772E10", Offset = "0x772E10", VA = "0x772E10")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x772FBC", Offset = "0x772FBC", VA = "0x772FBC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x773168", Offset = "0x773168", VA = "0x773168")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x773304", Offset = "0x773304", VA = "0x773304")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x7734A4", Offset = "0x7734A4", VA = "0x7734A4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x773644", Offset = "0x773644", VA = "0x773644")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x7737F0", Offset = "0x7737F0", VA = "0x7737F0")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x7739AC", Offset = "0x7739AC", VA = "0x7739AC")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full)
		{
			return null;
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x773B98", Offset = "0x773B98", VA = "0x773B98")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full)
		{
			return null;
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x773D8C", Offset = "0x773D8C", VA = "0x773D8C")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x7741B4", Offset = "0x7741B4", VA = "0x7741B4")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x774354", Offset = "0x774354", VA = "0x774354")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x7744E4", Offset = "0x7744E4", VA = "0x7744E4")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x774674", Offset = "0x774674", VA = "0x774674")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x774810", Offset = "0x774810", VA = "0x774810")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x7749C4", Offset = "0x7749C4", VA = "0x7749C4")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x774BBC", Offset = "0x774BBC", VA = "0x774BBC")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x774D48", Offset = "0x774D48", VA = "0x774D48")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x774F80", Offset = "0x774F80", VA = "0x774F80")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x775198", Offset = "0x775198", VA = "0x775198")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x7753B0", Offset = "0x7753B0", VA = "0x7753B0")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x7755C8", Offset = "0x7755C8", VA = "0x7755C8")]
		public static TweenerCore<Vector2, Vector2, CircleOptions> DOShapeCircle(this RectTransform target, Vector2 center, float endValueDegrees, float duration, bool relativeCenter = false, bool snapping = false)
		{
			return null;
		}
	}
	[Token(Token = "0x200013D")]
	public static class DOTweenModuleUnityVersion
	{
		[StructLayout(3)]
		[Token(Token = "0x2000140")]
		[CompilerGenerated]
		private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60007D3")]
			[Address(RVA = "0x777BB0", Offset = "0x777BB0", VA = "0x777BB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x777DE8", Offset = "0x777DE8", VA = "0x777DE8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000141")]
		[CompilerGenerated]
		private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x777DF4", Offset = "0x777DF4", VA = "0x777DF4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x778050", Offset = "0x778050", VA = "0x778050", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000142")]
		[CompilerGenerated]
		private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x77805C", Offset = "0x77805C", VA = "0x77805C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x778280", Offset = "0x778280", VA = "0x778280", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000143")]
		[CompilerGenerated]
		private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int elapsedLoops;

			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x77828C", Offset = "0x77828C", VA = "0x77828C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x7784CC", Offset = "0x7784CC", VA = "0x7784CC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000144")]
		[CompilerGenerated]
		private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float position;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x7784D8", Offset = "0x7784D8", VA = "0x7784D8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x778730", Offset = "0x778730", VA = "0x778730", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000145")]
		[CompilerGenerated]
		private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x77873C", Offset = "0x77873C", VA = "0x77873C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x778968", Offset = "0x778968", VA = "0x778968", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x77677C", Offset = "0x77677C", VA = "0x77677C")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x77695C", Offset = "0x77695C", VA = "0x77695C")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x776B48", Offset = "0x776B48", VA = "0x776B48")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x776C44", Offset = "0x776C44", VA = "0x776C44")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x776D40", Offset = "0x776D40", VA = "0x776D40")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x776E3C", Offset = "0x776E3C", VA = "0x776E3C")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x776F4C", Offset = "0x776F4C", VA = "0x776F4C")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x77706C", Offset = "0x77706C", VA = "0x77706C")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x777168", Offset = "0x777168", VA = "0x777168")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x777374", Offset = "0x777374", VA = "0x777374")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x777580", Offset = "0x777580", VA = "0x777580")]
		[AsyncStateMachine(typeof(<AsyncWaitForCompletion>d__10))]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x77766C", Offset = "0x77766C", VA = "0x77766C")]
		[AsyncStateMachine(typeof(<AsyncWaitForRewind>d__11))]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x777758", Offset = "0x777758", VA = "0x777758")]
		[AsyncStateMachine(typeof(<AsyncWaitForKill>d__12))]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x777844", Offset = "0x777844", VA = "0x777844")]
		[AsyncStateMachine(typeof(<AsyncWaitForElapsedLoops>d__13))]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x777938", Offset = "0x777938", VA = "0x777938")]
		[AsyncStateMachine(typeof(<AsyncWaitForPosition>d__14))]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x777A34", Offset = "0x777A34", VA = "0x777A34")]
		[AsyncStateMachine(typeof(<AsyncWaitForStart>d__15))]
		public static Task AsyncWaitForStart(this Tween t)
		{
			return null;
		}
	}
	[Token(Token = "0x2000146")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x2000147")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000089")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60007DF")]
				[Address(RVA = "0x778974", Offset = "0x778974", VA = "0x778974", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x776C14", Offset = "0x776C14", VA = "0x776C14")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000148")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700008A")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60007E1")]
				[Address(RVA = "0x7789A4", Offset = "0x7789A4", VA = "0x7789A4", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x776D10", Offset = "0x776D10", VA = "0x776D10")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000149")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700008B")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60007E3")]
				[Address(RVA = "0x778A04", Offset = "0x778A04", VA = "0x778A04", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x776E0C", Offset = "0x776E0C", VA = "0x776E0C")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x200014A")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x1700008C")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60007E5")]
				[Address(RVA = "0x778A20", Offset = "0x778A20", VA = "0x778A20", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x776F10", Offset = "0x776F10", VA = "0x776F10")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x200014B")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x1700008D")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60007E7")]
				[Address(RVA = "0x778A60", Offset = "0x778A60", VA = "0x778A60", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x777028", Offset = "0x777028", VA = "0x777028")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x200014C")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700008E")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60007E9")]
				[Address(RVA = "0x778AB8", Offset = "0x778AB8", VA = "0x778AB8", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x777138", Offset = "0x777138", VA = "0x777138")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x200014D")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x200014E")]
		public static class Physics
		{
			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x778C48", Offset = "0x778C48", VA = "0x778C48")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x778D48", Offset = "0x778D48", VA = "0x778D48")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x778DD4", Offset = "0x778DD4", VA = "0x778DD4")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x778E60", Offset = "0x778E60", VA = "0x778E60")]
			[Preserve]
			public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x778AEC", Offset = "0x778AEC", VA = "0x778AEC")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x778BA0", Offset = "0x778BA0", VA = "0x778BA0")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
	[Token(Token = "0x200014F")]
	[AddComponentMenu("DOTween/DOTween Animation")]
	public class DOTweenAnimation : ABSAnimationComponent
	{
		[Token(Token = "0x2000150")]
		public enum AnimationType
		{
			[Token(Token = "0x400072A")]
			None,
			[Token(Token = "0x400072B")]
			Move,
			[Token(Token = "0x400072C")]
			LocalMove,
			[Token(Token = "0x400072D")]
			Rotate,
			[Token(Token = "0x400072E")]
			LocalRotate,
			[Token(Token = "0x400072F")]
			Scale,
			[Token(Token = "0x4000730")]
			Color,
			[Token(Token = "0x4000731")]
			Fade,
			[Token(Token = "0x4000732")]
			Text,
			[Token(Token = "0x4000733")]
			PunchPosition,
			[Token(Token = "0x4000734")]
			PunchRotation,
			[Token(Token = "0x4000735")]
			PunchScale,
			[Token(Token = "0x4000736")]
			ShakePosition,
			[Token(Token = "0x4000737")]
			ShakeRotation,
			[Token(Token = "0x4000738")]
			ShakeScale,
			[Token(Token = "0x4000739")]
			CameraAspect,
			[Token(Token = "0x400073A")]
			CameraBackgroundColor,
			[Token(Token = "0x400073B")]
			CameraFieldOfView,
			[Token(Token = "0x400073C")]
			CameraOrthoSize,
			[Token(Token = "0x400073D")]
			CameraPixelRect,
			[Token(Token = "0x400073E")]
			CameraRect,
			[Token(Token = "0x400073F")]
			UIWidthHeight
		}

		[Token(Token = "0x2000151")]
		public enum TargetType
		{
			[Token(Token = "0x4000741")]
			Unset,
			[Token(Token = "0x4000742")]
			Camera,
			[Token(Token = "0x4000743")]
			CanvasGroup,
			[Token(Token = "0x4000744")]
			Image,
			[Token(Token = "0x4000745")]
			Light,
			[Token(Token = "0x4000746")]
			RectTransform,
			[Token(Token = "0x4000747")]
			Renderer,
			[Token(Token = "0x4000748")]
			SpriteRenderer,
			[Token(Token = "0x4000749")]
			Rigidbody,
			[Token(Token = "0x400074A")]
			Rigidbody2D,
			[Token(Token = "0x400074B")]
			Text,
			[Token(Token = "0x400074C")]
			Transform,
			[Token(Token = "0x400074D")]
			tk2dBaseSprite,
			[Token(Token = "0x400074E")]
			tk2dTextMesh,
			[Token(Token = "0x400074F")]
			TextMeshPro,
			[Token(Token = "0x4000750")]
			TextMeshProUGUI
		}

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool targetIsSelf;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject targetGO;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool tweenTargetIsTargetGO;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float delay;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float duration;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Ease easeType;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AnimationCurve easeCurve;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public LoopType loopType;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int loops;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string id;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool isRelative;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool isFrom;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		public bool isIndependentUpdate;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		public bool autoKill;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool autoGenerate;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		public bool isActive;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA6")]
		public bool isValid;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Component target;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AnimationType animationType;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetType targetType;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public TargetType forcedTargetType;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool autoPlay;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public bool useTargetAsV3;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float endValueFloat;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector3 endValueV3;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Vector2 endValueV2;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Color endValueColor;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public string endValueString;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Rect endValueRect;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Transform endValueTransform;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public bool optionalBool0;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
		public bool optionalBool1;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public float optionalFloat0;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public int optionalInt0;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public RotateMode optionalRotationMode;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public ScrambleMode optionalScrambleMode;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public ShakeRandomnessMode optionalShakeRandomnessMode;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public string optionalString;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool _tweenAutoGenerationCalled;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int _playCount;

		[Token(Token = "0x1400000D")]
		public static event Action<DOTweenAnimation> OnReset
		{
			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x779034", Offset = "0x779034", VA = "0x779034")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x779100", Offset = "0x779100", VA = "0x779100")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x7791CC", Offset = "0x7791CC", VA = "0x7791CC")]
		private static void Dispatch_OnReset(DOTweenAnimation anim)
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x779238", Offset = "0x779238", VA = "0x779238")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x77A844", Offset = "0x77A844", VA = "0x77A844")]
		private void Start()
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x77A884", Offset = "0x77A884", VA = "0x77A884")]
		private void Reset()
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x77A888", Offset = "0x77A888", VA = "0x77A888")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x77A8C0", Offset = "0x77A8C0", VA = "0x77A8C0")]
		public void RewindThenRecreateTween()
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x77A8F8", Offset = "0x77A8F8", VA = "0x77A8F8")]
		public void RewindThenRecreateTweenAndPlay()
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x77A930", Offset = "0x77A930", VA = "0x77A930")]
		public void RecreateTween()
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x77A93C", Offset = "0x77A93C", VA = "0x77A93C")]
		public void RecreateTweenAndPlay()
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x779284", Offset = "0x779284", VA = "0x779284")]
		public void CreateTween(bool regenerateIfExists = false, bool andPlay = true)
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x77AB90", Offset = "0x77AB90", VA = "0x77AB90")]
		public List<Tween> GetTweens()
		{
			return null;
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x77ACE8", Offset = "0x77ACE8", VA = "0x77ACE8")]
		public void SetAnimationTarget(Component tweenTarget, bool useTweenTargetGameObjectForGroupOperations = true)
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x77ADD4", Offset = "0x77ADD4", VA = "0x77ADD4", Slot = "4")]
		public override void DOPlay()
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x77AE54", Offset = "0x77AE54", VA = "0x77AE54", Slot = "5")]
		public override void DOPlayBackwards()
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x77AED4", Offset = "0x77AED4", VA = "0x77AED4", Slot = "6")]
		public override void DOPlayForward()
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x77AF54", Offset = "0x77AF54", VA = "0x77AF54", Slot = "7")]
		public override void DOPause()
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x77AFD4", Offset = "0x77AFD4", VA = "0x77AFD4", Slot = "8")]
		public override void DOTogglePause()
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x77B054", Offset = "0x77B054", VA = "0x77B054", Slot = "9")]
		public override void DORewind()
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x77B138", Offset = "0x77B138", VA = "0x77B138", Slot = "10")]
		public override void DORestart()
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x77B148", Offset = "0x77B148", VA = "0x77B148", Slot = "11")]
		public override void DORestart(bool fromHere)
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x77B4A8", Offset = "0x77B4A8", VA = "0x77B4A8", Slot = "12")]
		public override void DOComplete()
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x77B52C", Offset = "0x77B52C", VA = "0x77B52C", Slot = "13")]
		public override void DOKill()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x77B5C0", Offset = "0x77B5C0", VA = "0x77B5C0")]
		public void DOPlayById(string id)
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x77B648", Offset = "0x77B648", VA = "0x77B648")]
		public void DOPlayAllById(string id)
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x77B6A0", Offset = "0x77B6A0", VA = "0x77B6A0")]
		public void DOPauseAllById(string id)
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x77B6F8", Offset = "0x77B6F8", VA = "0x77B6F8")]
		public void DOPlayBackwardsById(string id)
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x77B780", Offset = "0x77B780", VA = "0x77B780")]
		public void DOPlayBackwardsAllById(string id)
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x77B7D8", Offset = "0x77B7D8", VA = "0x77B7D8")]
		public void DOPlayForwardById(string id)
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x77B860", Offset = "0x77B860", VA = "0x77B860")]
		public void DOPlayForwardAllById(string id)
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x77B8B8", Offset = "0x77B8B8", VA = "0x77B8B8")]
		public void DOPlayNext()
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x77B9F4", Offset = "0x77B9F4", VA = "0x77B9F4")]
		public void DORewindAndPlayNext()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x77BA88", Offset = "0x77BA88", VA = "0x77BA88")]
		public void DORewindAllById(string id)
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x77BAF8", Offset = "0x77BAF8", VA = "0x77BAF8")]
		public void DORestartById(string id)
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x77BB90", Offset = "0x77BB90", VA = "0x77BB90")]
		public void DORestartAllById(string id)
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x77BC04", Offset = "0x77BC04", VA = "0x77BC04")]
		public void DOKillById(string id)
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x77BC90", Offset = "0x77BC90", VA = "0x77BC90")]
		public void DOKillAllById(string id)
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x77A960", Offset = "0x77A960", VA = "0x77A960")]
		public static TargetType TypeToDOTargetType(Type t)
		{
			return default(TargetType);
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x77BCEC", Offset = "0x77BCEC", VA = "0x77BCEC")]
		public Tween CreateEditorPreview()
		{
			return null;
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x77A948", Offset = "0x77A948", VA = "0x77A948")]
		private GameObject GetTweenGO()
		{
			return null;
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x77AB70", Offset = "0x77AB70", VA = "0x77AB70")]
		private GameObject GetTweenTarget()
		{
			return null;
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x77B254", Offset = "0x77B254", VA = "0x77B254")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x77BD24", Offset = "0x77BD24", VA = "0x77BD24")]
		public DOTweenAnimation()
		{
		}
	}
	[Token(Token = "0x2000152")]
	public static class DOTweenAnimationExtensions
	{
		[Token(Token = "0x600081E")]
		public static bool IsSameOrSubclassOf<T>(this Component t)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000153")]
	public static class DOTweenProShortcuts
	{
		[Token(Token = "0x600081F")]
		[Address(RVA = "0x77BF18", Offset = "0x77BF18", VA = "0x77BF18")]
		static DOTweenProShortcuts()
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x77BF68", Offset = "0x77BF68", VA = "0x77BF68")]
		public static Tweener DOSpiral(this Transform target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x77C32C", Offset = "0x77C32C", VA = "0x77C32C")]
		public static Tweener DOSpiral(this Rigidbody target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}
	}
}
namespace Unity.XR.PXR
{
	[Token(Token = "0x2000156")]
	public class PXR_ScreenFade_X : MonoBehaviour
	{
		[Token(Token = "0x2000157")]
		[CompilerGenerated]
		private sealed class <ScreenShowBlackMask>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PXR_ScreenFade_X <>4__this;

			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <nowTime>5__2;

			[Token(Token = "0x1700008F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000839")]
				[Address(RVA = "0x77DA8C", Offset = "0x77DA8C", VA = "0x77DA8C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000090")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600083B")]
				[Address(RVA = "0x77DAD4", Offset = "0x77DAD4", VA = "0x77DAD4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000836")]
			[Address(RVA = "0x77D598", Offset = "0x77D598", VA = "0x77D598")]
			[DebuggerHidden]
			public <ScreenShowBlackMask>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x6000837")]
			[Address(RVA = "0x77D97C", Offset = "0x77D97C", VA = "0x77D97C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000838")]
			[Address(RVA = "0x77D980", Offset = "0x77D980", VA = "0x77D980", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600083A")]
			[Address(RVA = "0x77DA94", Offset = "0x77DA94", VA = "0x77DA94", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000158")]
		[CompilerGenerated]
		private sealed class <ScreenFade>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PXR_ScreenFade_X <>4__this;

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <nowTime>5__2;

			[Token(Token = "0x17000091")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600083F")]
				[Address(RVA = "0x77DBEC", Offset = "0x77DBEC", VA = "0x77DBEC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000092")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000841")]
				[Address(RVA = "0x77DC34", Offset = "0x77DC34", VA = "0x77DC34", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600083C")]
			[Address(RVA = "0x77D634", Offset = "0x77D634", VA = "0x77D634")]
			[DebuggerHidden]
			public <ScreenFade>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x600083D")]
			[Address(RVA = "0x77DADC", Offset = "0x77DADC", VA = "0x77DADC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600083E")]
			[Address(RVA = "0x77DAE0", Offset = "0x77DAE0", VA = "0x77DAE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000840")]
			[Address(RVA = "0x77DBF4", Offset = "0x77DBF4", VA = "0x77DBF4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float InitAlpha;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The gradient of time.")]
		public float gradientTime;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Basic color.")]
		public Color fadeColor;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The default value is 4000.")]
		private int renderQueue;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private MeshRenderer gradientMeshRenderer;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private MeshFilter gradientMeshFilter;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material gradientMaterial;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool isGradient;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float currentAlpha;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float nowFadeAlpha;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<Vector3> verts;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<int> indices;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int N;

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x77C748", Offset = "0x77C748", VA = "0x77C748")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x77C92C", Offset = "0x77C92C", VA = "0x77C92C")]
		public void StartDisappearFade(float time = 1f)
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x77CA00", Offset = "0x77CA00", VA = "0x77CA00")]
		public void StartAppearFade(float time = 1f)
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x77CAD4", Offset = "0x77CAD4", VA = "0x77CAD4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x77CAD8", Offset = "0x77CAD8", VA = "0x77CAD8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x77C768", Offset = "0x77C768", VA = "0x77C768")]
		private void CreateFadeMesh()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x77C924", Offset = "0x77C924", VA = "0x77C924")]
		public void SetCurrentAlpha(float alpha)
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x77D524", Offset = "0x77D524", VA = "0x77D524")]
		[IteratorStateMachine(typeof(<ScreenShowBlackMask>d__20))]
		private IEnumerator ScreenShowBlackMask()
		{
			return null;
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x77D5C0", Offset = "0x77D5C0", VA = "0x77D5C0")]
		[IteratorStateMachine(typeof(<ScreenFade>d__21))]
		private IEnumerator ScreenFade()
		{
			return null;
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x77D41C", Offset = "0x77D41C", VA = "0x77D41C")]
		private void SetAlpha()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x77CBFC", Offset = "0x77CBFC", VA = "0x77CBFC")]
		private void CreateModel()
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x77D65C", Offset = "0x77D65C", VA = "0x77D65C")]
		public void CreateMakePos(int num)
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x77D7C8", Offset = "0x77D7C8", VA = "0x77D7C8")]
		public void OtherMakePos(int num)
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x77CADC", Offset = "0x77CADC", VA = "0x77CADC")]
		private void DestoryGradientMesh()
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x77D954", Offset = "0x77D954", VA = "0x77D954")]
		public PXR_ScreenFade_X()
		{
		}
	}
}
