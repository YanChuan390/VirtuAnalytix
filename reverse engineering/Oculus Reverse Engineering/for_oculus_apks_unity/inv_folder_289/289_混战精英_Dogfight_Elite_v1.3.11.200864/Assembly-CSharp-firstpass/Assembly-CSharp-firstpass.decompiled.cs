using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Fusion;
using Il2CppDummyDll;
using Oculus.Platform;
using Oculus.Platform.Models;
using Rewired;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class Ext_UnityTexture2D
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1ED5DD4", Offset = "0x1ED4DD4", VA = "0x1ED5DD4")]
	public static void Fill(this Texture2D self, Color color)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1ED5ECC", Offset = "0x1ED4ECC", VA = "0x1ED5ECC")]
	public static Texture2D Resample(this Texture2D self, int width, int height, TextureFormat format, bool mipmaps)
	{
		return null;
	}
}
[Token(Token = "0x2000003")]
public class CameraHelper : MonoBehaviour
{
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1ED60AC", Offset = "0x1ED50AC", VA = "0x1ED60AC")]
	private static float sgn(float a)
	{
		return default(float);
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1ED60C8", Offset = "0x1ED50C8", VA = "0x1ED60C8")]
	public static void CalculateObliqueMatrix(ref Matrix4x4 projection, Vector4 clipPlane)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1ED6234", Offset = "0x1ED5234", VA = "0x1ED6234")]
	public static Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1ED63DC", Offset = "0x1ED53DC", VA = "0x1ED63DC")]
	public static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1ED6474", Offset = "0x1ED5474", VA = "0x1ED6474")]
	public CameraHelper()
	{
	}
}
[Token(Token = "0x2000004")]
public class destroyThisTimed : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float destroyTime;

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1ED647C", Offset = "0x1ED547C", VA = "0x1ED647C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1ED64F8", Offset = "0x1ED54F8", VA = "0x1ED64F8")]
	public destroyThisTimed()
	{
	}
}
[Token(Token = "0x2000005")]
[AddComponentMenu("EZ GUI/Controls/Action Button")]
public class UIActionBtn : UIButton
{
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1ED6508", Offset = "0x1ED5508", VA = "0x1ED6508", Slot = "180")]
	public override void OnInput(ref POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1ED68A4", Offset = "0x1ED58A4", VA = "0x1ED68A4")]
	public new static UIActionBtn Create(string name, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1ED69E4", Offset = "0x1ED59E4", VA = "0x1ED69E4")]
	public new static UIActionBtn Create(string name, Vector3 pos, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1ED6B6C", Offset = "0x1ED5B6C", VA = "0x1ED6B6C")]
	public UIActionBtn()
	{
	}
}
[Token(Token = "0x2000006")]
[AddComponentMenu("EZ GUI/Controls/Change Panel Button")]
public class UIBtnChangePanel : UIButton
{
	[Token(Token = "0x2000007")]
	public enum ChangeType
	{
		[Token(Token = "0x4000007")]
		BringIn,
		[Token(Token = "0x4000008")]
		BringInForward,
		[Token(Token = "0x4000009")]
		BringInBack,
		[Token(Token = "0x400000A")]
		Dismiss,
		[Token(Token = "0x400000B")]
		DismissCurrent,
		[Token(Token = "0x400000C")]
		Toggle,
		[Token(Token = "0x400000D")]
		Forward,
		[Token(Token = "0x400000E")]
		Back,
		[Token(Token = "0x400000F")]
		BringInImmediate,
		[Token(Token = "0x4000010")]
		DismissImmediate
	}

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
	public UIPanelManager panelManager;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
	public ChangeType changeType;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A4")]
	public bool detargetAllOthers;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
	public string panel;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1ED72B4", Offset = "0x1ED62B4", VA = "0x1ED72B4", Slot = "180")]
	public override void OnInput(ref POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1ED75FC", Offset = "0x1ED65FC", VA = "0x1ED75FC", Slot = "16")]
	public override void Copy(SpriteRoot s)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1ED7610", Offset = "0x1ED6610", VA = "0x1ED7610", Slot = "160")]
	public override void Copy(SpriteRoot s, ControlCopyFlags flags)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1ED77F4", Offset = "0x1ED67F4", VA = "0x1ED77F4")]
	public new static UIBtnChangePanel Create(string name, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1ED7934", Offset = "0x1ED6934", VA = "0x1ED7934")]
	public new static UIBtnChangePanel Create(string name, Vector3 pos, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1ED7ABC", Offset = "0x1ED6ABC", VA = "0x1ED7ABC")]
	public UIBtnChangePanel()
	{
	}
}
[Token(Token = "0x2000008")]
[AddComponentMenu("EZ GUI/Controls/Load Scene Button")]
public class UIBtnLoadScene : UIButton
{
	[Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class <LoadScene>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UIBtnLoadScene <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x1ED81C0", Offset = "0x1ED71C0", VA = "0x1ED81C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x1ED8200", Offset = "0x1ED7200", VA = "0x1ED8200", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1ED7D78", Offset = "0x1ED6D78", VA = "0x1ED7D78")]
		[DebuggerHidden]
		public <LoadScene>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1ED8124", Offset = "0x1ED7124", VA = "0x1ED8124", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1ED8128", Offset = "0x1ED7128", VA = "0x1ED8128", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1ED81C8", Offset = "0x1ED71C8", VA = "0x1ED81C8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
	public string scene;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
	public UIPanelBase loadingPanel;

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1ED7AC8", Offset = "0x1ED6AC8", VA = "0x1ED7AC8")]
	public void LoadSceneDelegate(UIPanelBase panel, EZTransition trans)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1ED7B48", Offset = "0x1ED6B48", VA = "0x1ED7B48", Slot = "180")]
	public override void OnInput(ref POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1ED7D58", Offset = "0x1ED6D58", VA = "0x1ED7D58")]
	protected void DoLoadScene()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1ED7AE8", Offset = "0x1ED6AE8", VA = "0x1ED7AE8")]
	[IteratorStateMachine(typeof(<LoadScene>d__5))]
	protected IEnumerator LoadScene()
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1ED7DA0", Offset = "0x1ED6DA0", VA = "0x1ED7DA0", Slot = "16")]
	public override void Copy(SpriteRoot s)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1ED7DB4", Offset = "0x1ED6DB4", VA = "0x1ED7DB4", Slot = "160")]
	public override void Copy(SpriteRoot s, ControlCopyFlags flags)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1ED7E58", Offset = "0x1ED6E58", VA = "0x1ED7E58")]
	public new static UIBtnLoadScene Create(string name, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1ED7F98", Offset = "0x1ED6F98", VA = "0x1ED7F98")]
	public new static UIBtnLoadScene Create(string name, Vector3 pos, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1ED8120", Offset = "0x1ED7120", VA = "0x1ED8120")]
	public UIBtnLoadScene()
	{
	}
}
[Token(Token = "0x200000A")]
[AddComponentMenu("EZ GUI/Controls/Weblink Button")]
public class UIBtnWWW : UIButton
{
	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
	public string URL;

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1ED8208", Offset = "0x1ED7208", VA = "0x1ED8208", Slot = "180")]
	public override void OnInput(ref POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1ED829C", Offset = "0x1ED729C", VA = "0x1ED829C")]
	protected void DoURL()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1ED8320", Offset = "0x1ED7320", VA = "0x1ED8320", Slot = "16")]
	public override void Copy(SpriteRoot s)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1ED8334", Offset = "0x1ED7334", VA = "0x1ED8334", Slot = "160")]
	public override void Copy(SpriteRoot s, ControlCopyFlags flags)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1ED83D0", Offset = "0x1ED73D0", VA = "0x1ED83D0")]
	public new static UIBtnWWW Create(string name, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1ED8510", Offset = "0x1ED7510", VA = "0x1ED8510")]
	public new static UIBtnWWW Create(string name, Vector3 pos, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1ED8698", Offset = "0x1ED7698", VA = "0x1ED8698")]
	public UIBtnWWW()
	{
	}
}
[Token(Token = "0x200000B")]
[AddComponentMenu("EZ GUI/Controls/Button")]
public class UIButton : AutoSpriteControlBase
{
	[Token(Token = "0x200000C")]
	public enum CONTROL_STATE
	{
		[Token(Token = "0x400002B")]
		NORMAL,
		[Token(Token = "0x400002C")]
		OVER,
		[Token(Token = "0x400002D")]
		ACTIVE,
		[Token(Token = "0x400002E")]
		DISABLED
	}

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
	public object Tag;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
	protected CONTROL_STATE m_ctrlState;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
	[HideInInspector]
	public TextureAnim[] states;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
	[HideInInspector]
	public EZTransitionList[] transitions;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
	private EZTransition prevTransition;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
	[HideInInspector]
	public string[] stateLabels;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
	public SpriteRoot[] layers;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
	public MonoBehaviour scriptWithMethodToInvoke;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
	public string methodToInvoke;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
	public POINTER_INFO.INPUT_EVENT whenToInvoke;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x364")]
	public float delay;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
	public AudioSource soundOnOver;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
	public AudioSource soundOnClick;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
	public bool repeat;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x379")]
	public bool alwaysFinishActiveTransition;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x37A")]
	protected bool transitionQueued;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
	protected EZTransition nextTransition;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
	protected CONTROL_STATE nextState;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
	protected int[,] stateIndices;

	[Token(Token = "0x17000003")]
	public CONTROL_STATE controlState
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1ED869C", Offset = "0x1ED769C", VA = "0x1ED869C")]
		get
		{
			return default(CONTROL_STATE);
		}
	}

	[Token(Token = "0x17000004")]
	public override bool controlIsEnabled
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1ED86A4", Offset = "0x1ED76A4", VA = "0x1ED86A4", Slot = "166")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1ED86AC", Offset = "0x1ED76AC", VA = "0x1ED86AC", Slot = "167")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public override TextureAnim[] States
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1ED86E4", Offset = "0x1ED76E4", VA = "0x1ED86E4", Slot = "79")]
		get
		{
			return null;
		}
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1ED86EC", Offset = "0x1ED76EC", VA = "0x1ED86EC", Slot = "80")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public override EZTransitionList[] Transitions
	{
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1ED8730", Offset = "0x1ED7730", VA = "0x1ED8730", Slot = "186")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1ED8738", Offset = "0x1ED7738", VA = "0x1ED8738", Slot = "187")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public override string Text
	{
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1ED9B10", Offset = "0x1ED8B10", VA = "0x1ED9B10", Slot = "156")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1ED9B18", Offset = "0x1ED8B18", VA = "0x1ED9B18", Slot = "157")]
		set
		{
		}
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1ED86F4", Offset = "0x1ED76F4", VA = "0x1ED86F4", Slot = "185")]
	public override EZTransitionList GetTransitions(int index)
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1ED8740", Offset = "0x1ED7740", VA = "0x1ED8740", Slot = "188")]
	public override string GetStateLabel(int index)
	{
		return null;
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1ED8770", Offset = "0x1ED7770", VA = "0x1ED8770", Slot = "189")]
	public override void SetStateLabel(int index, string label)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1ED65A0", Offset = "0x1ED55A0", VA = "0x1ED65A0", Slot = "180")]
	public override void OnInput(ref POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1ED87B8", Offset = "0x1ED77B8", VA = "0x1ED87B8", Slot = "13")]
	public override void Start()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1ED9334", Offset = "0x1ED8334", VA = "0x1ED9334", Slot = "19")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1ED93F8", Offset = "0x1ED83F8", VA = "0x1ED93F8", Slot = "20")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1ED9508", Offset = "0x1ED8508", VA = "0x1ED9508", Slot = "16")]
	public override void Copy(SpriteRoot s)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1ED76BC", Offset = "0x1ED66BC", VA = "0x1ED76BC", Slot = "160")]
	public override void Copy(SpriteRoot s, ControlCopyFlags flags)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1ED951C", Offset = "0x1ED851C", VA = "0x1ED951C", Slot = "191")]
	public virtual void SetControlState(CONTROL_STATE s)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x1ED9530", Offset = "0x1ED8530", VA = "0x1ED9530", Slot = "192")]
	public virtual void SetControlState(CONTROL_STATE s, bool suppressTransitions)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1ED99B0", Offset = "0x1ED89B0", VA = "0x1ED99B0")]
	protected int DetermineNextTransition(int newState, int prevState)
	{
		return default(int);
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1ED97B4", Offset = "0x1ED87B4", VA = "0x1ED97B4")]
	protected void StartTransition(int newState, int prevState, bool suppressTransition)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x1ED9860", Offset = "0x1ED8860", VA = "0x1ED9860")]
	protected void QueueTransition(int newState, int prevState, bool suppressTransition)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x1ED9A24", Offset = "0x1ED8A24", VA = "0x1ED9A24")]
	protected void RunFollowupTrans(EZTransition trans)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1ED9CA4", Offset = "0x1ED8CA4", VA = "0x1ED9CA4", Slot = "17")]
	public override void InitUVs()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x1ED9D00", Offset = "0x1ED8D00", VA = "0x1ED9D00")]
	public static UIButton Create(string name, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1ED9E40", Offset = "0x1ED8E40", VA = "0x1ED9E40")]
	public static UIButton Create(string name, Vector3 pos, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1ED9FC8", Offset = "0x1ED8FC8", VA = "0x1ED9FC8", Slot = "183")]
	public override void DrawPreTransitionUI(int selState, IGUIScriptSelector gui)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1ED6B70", Offset = "0x1ED5B70", VA = "0x1ED6B70")]
	public UIButton()
	{
	}
}
[Token(Token = "0x200000D")]
[AddComponentMenu("EZ GUI/Controls/3D Button")]
public class UIButton3D : ControlBase
{
	[Token(Token = "0x200000E")]
	public enum CONTROL_STATE
	{
		[Token(Token = "0x4000041")]
		NORMAL,
		[Token(Token = "0x4000042")]
		OVER,
		[Token(Token = "0x4000043")]
		ACTIVE,
		[Token(Token = "0x4000044")]
		DISABLED
	}

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	protected CONTROL_STATE m_ctrlState;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected string[] states;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	public EZTransitionList[] transitions;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private EZTransition prevTransition;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[HideInInspector]
	public string[] stateLabels;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public MonoBehaviour scriptWithMethodToInvoke;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public string methodToInvoke;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public POINTER_INFO.INPUT_EVENT whenToInvoke;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public float delay;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public AudioSource soundOnOver;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public AudioSource soundOnClick;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public bool repeat;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
	public bool alwaysFinishActiveTransition;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE2")]
	protected bool transitionQueued;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	protected EZTransition nextTransition;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	protected CONTROL_STATE nextState;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	protected bool m_started;

	[Token(Token = "0x17000008")]
	public CONTROL_STATE controlState
	{
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1EDA07C", Offset = "0x1ED907C", VA = "0x1EDA07C")]
		get
		{
			return default(CONTROL_STATE);
		}
	}

	[Token(Token = "0x17000009")]
	public override bool controlIsEnabled
	{
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1EDA084", Offset = "0x1ED9084", VA = "0x1EDA084", Slot = "79")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1EDA08C", Offset = "0x1ED908C", VA = "0x1EDA08C", Slot = "80")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public override string[] States
	{
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1EDA0AC", Offset = "0x1ED90AC", VA = "0x1EDA0AC", Slot = "99")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000B")]
	public override EZTransitionList[] Transitions
	{
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1EDA0F0", Offset = "0x1ED90F0", VA = "0x1EDA0F0", Slot = "105")]
		get
		{
			return null;
		}
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1EDA0F8", Offset = "0x1ED90F8", VA = "0x1EDA0F8", Slot = "106")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public override string Text
	{
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1EDADB4", Offset = "0x1ED9DB4", VA = "0x1EDADB4", Slot = "71")]
		get
		{
			return null;
		}
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1EDADBC", Offset = "0x1ED9DBC", VA = "0x1EDADBC", Slot = "72")]
		set
		{
		}
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1EDA0B4", Offset = "0x1ED90B4", VA = "0x1EDA0B4", Slot = "104")]
	public override EZTransitionList GetTransitions(int index)
	{
		return null;
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1EDA100", Offset = "0x1ED9100", VA = "0x1EDA100", Slot = "107")]
	public override string GetStateLabel(int index)
	{
		return null;
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x1EDA130", Offset = "0x1ED9130", VA = "0x1EDA130", Slot = "108")]
	public override void SetStateLabel(int index, string label)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1EDA178", Offset = "0x1ED9178", VA = "0x1EDA178", Slot = "93")]
	public override void OnInput(ref POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1EDA46C", Offset = "0x1ED946C", VA = "0x1EDA46C", Slot = "76")]
	public override void Start()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x1EDA6AC", Offset = "0x1ED96AC", VA = "0x1EDA6AC", Slot = "94")]
	public override void OnEnable()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1EDA770", Offset = "0x1ED9770", VA = "0x1EDA770", Slot = "95")]
	public override void OnDisable()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1EDA880", Offset = "0x1ED9880", VA = "0x1EDA880", Slot = "97")]
	public override void Copy(IControl c)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1EDA894", Offset = "0x1ED9894", VA = "0x1EDA894", Slot = "98")]
	public override void Copy(IControl c, ControlCopyFlags flags)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1EDA9C4", Offset = "0x1ED99C4", VA = "0x1EDA9C4", Slot = "112")]
	public virtual void SetControlState(CONTROL_STATE s)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1EDA9D8", Offset = "0x1ED99D8", VA = "0x1EDA9D8", Slot = "113")]
	public virtual void SetControlState(CONTROL_STATE s, bool suppressTransitions)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1EDAC54", Offset = "0x1ED9C54", VA = "0x1EDAC54")]
	protected int DetermineNextTransition(int newState, int prevState)
	{
		return default(int);
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1EDAADC", Offset = "0x1ED9ADC", VA = "0x1EDAADC")]
	protected void StartTransition(int newState, int prevState)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x1EDAB4C", Offset = "0x1ED9B4C", VA = "0x1EDAB4C")]
	protected void QueueTransition(int newState, int prevState)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x1EDACC8", Offset = "0x1ED9CC8", VA = "0x1EDACC8")]
	protected void RunFollowupTrans(EZTransition trans)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1EDB204", Offset = "0x1EDA204", VA = "0x1EDB204", Slot = "102")]
	public override void DrawPreTransitionUI(int selState, IGUIScriptSelector gui)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x1EDB2B8", Offset = "0x1EDA2B8", VA = "0x1EDB2B8")]
	public static UIButton3D Create(string name, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x1EDB3F8", Offset = "0x1EDA3F8", VA = "0x1EDB3F8")]
	public static UIButton3D Create(string name, Vector3 pos, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x1EDB580", Offset = "0x1EDA580", VA = "0x1EDB580")]
	public UIButton3D()
	{
	}
}
[Token(Token = "0x200000F")]
[AddComponentMenu("EZ GUI/Controls/List Button")]
public class UIListButton : UIListItem
{
	[Token(Token = "0x6000062")]
	[Address(RVA = "0x1EDBBB4", Offset = "0x1EDABB4", VA = "0x1EDBBB4", Slot = "180")]
	public override void OnInput(ref POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x1EDC468", Offset = "0x1EDB468", VA = "0x1EDC468")]
	public new static UIListButton Create(string name, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x1EDC5A8", Offset = "0x1EDB5A8", VA = "0x1EDC5A8")]
	public new static UIListButton Create(string name, Vector3 pos, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x1EDC730", Offset = "0x1EDB730", VA = "0x1EDC730")]
	public UIListButton()
	{
	}
}
[Token(Token = "0x2000010")]
[AddComponentMenu("EZ GUI/Controls/List Item")]
public class UIListItem : UIButton, IUIListObject, IUIObject, IEZDragDrop
{
	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
	[HideInInspector]
	public bool activeOnlyWhenSelected;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39C")]
	protected int m_index;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
	protected bool m_selected;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
	protected UIScrollList list;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
	protected Vector2 colliderTL;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
	protected Vector2 colliderBR;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
	protected Vector3 colliderCenter;

	[Token(Token = "0x1700000D")]
	public bool selected
	{
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1EDC748", Offset = "0x1EDB748", VA = "0x1EDC748", Slot = "212")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1EDC750", Offset = "0x1EDB750", VA = "0x1EDC750", Slot = "213")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public override string Text
	{
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1EDD0F0", Offset = "0x1EDC0F0", VA = "0x1EDD0F0", Slot = "157")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public int Index
	{
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1EDDCD4", Offset = "0x1EDCCD4", VA = "0x1EDDCD4", Slot = "207")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1EDDCDC", Offset = "0x1EDCCDC", VA = "0x1EDDCDC", Slot = "208")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public SpriteText TextObj
	{
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1EDDE98", Offset = "0x1EDCE98", VA = "0x1EDDE98", Slot = "211")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x1EDC770", Offset = "0x1EDB770", VA = "0x1EDC770", Slot = "12")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x1EDC1AC", Offset = "0x1EDB1AC", VA = "0x1EDC1AC")]
	protected void DoNeccessaryInput(ref POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x1EDC924", Offset = "0x1EDB924", VA = "0x1EDC924", Slot = "180")]
	public override void OnInput(ref POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x1EDCEE0", Offset = "0x1EDBEE0", VA = "0x1EDCEE0", Slot = "19")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x1EDCFD0", Offset = "0x1EDBFD0", VA = "0x1EDCFD0", Slot = "20")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x1EDD004", Offset = "0x1EDC004", VA = "0x1EDD004", Slot = "16")]
	public override void Copy(SpriteRoot s)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1EDD018", Offset = "0x1EDC018", VA = "0x1EDD018", Slot = "160")]
	public override void Copy(SpriteRoot s, ControlCopyFlags flags)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x1EDD1E0", Offset = "0x1EDC1E0", VA = "0x1EDD1E0", Slot = "163")]
	public override void FindOuterEdges()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x1EDD20C", Offset = "0x1EDC20C", VA = "0x1EDD20C", Slot = "23")]
	public override void TruncateRight(float pct)
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x1EDD3F4", Offset = "0x1EDC3F4", VA = "0x1EDD3F4", Slot = "24")]
	public override void TruncateLeft(float pct)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x1EDD5DC", Offset = "0x1EDC5DC", VA = "0x1EDD5DC", Slot = "25")]
	public override void TruncateTop(float pct)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x1EDD7C4", Offset = "0x1EDC7C4", VA = "0x1EDD7C4", Slot = "26")]
	public override void TruncateBottom(float pct)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x1EDD9AC", Offset = "0x1EDC9AC", VA = "0x1EDD9AC", Slot = "27")]
	public override void Untruncate()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x1EDDBBC", Offset = "0x1EDCBBC", VA = "0x1EDDBBC", Slot = "37")]
	public override void Hide(bool tf)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x1EDDCC4", Offset = "0x1EDCCC4", VA = "0x1EDDCC4", Slot = "205")]
	public void SetList(UIScrollList c)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x1EDDCCC", Offset = "0x1EDCCCC", VA = "0x1EDDCCC", Slot = "218")]
	public virtual UIScrollList GetScrollList()
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x1EDDCE4", Offset = "0x1EDCCE4", VA = "0x1EDDCE4")]
	public void FindText()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x1EDDEA0", Offset = "0x1EDCEA0", VA = "0x1EDDEA0", Slot = "193")]
	public bool IsContainer()
	{
		return default(bool);
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x1EDDEA8", Offset = "0x1EDCEA8", VA = "0x1EDDEA8")]
	public new static UIListItem Create(string name, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x1EDDFE8", Offset = "0x1EDCFE8", VA = "0x1EDDFE8")]
	public new static UIListItem Create(string name, Vector3 pos, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x1EDC73C", Offset = "0x1EDB73C", VA = "0x1EDC73C")]
	public UIListItem()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1EDE170", Offset = "0x1EDD170", VA = "0x1EDE170", Slot = "115")]
	private GameObject IUIObject.get_gameObject()
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1EDE178", Offset = "0x1EDD178", VA = "0x1EDE178", Slot = "116")]
	private Transform IUIObject.get_transform()
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1EDE180", Offset = "0x1EDD180", VA = "0x1EDE180", Slot = "118")]
	private string IUIObject.get_name()
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000011")]
[AddComponentMenu("EZ GUI/Controls/List Item Container")]
public class UIListItemContainer : ControlBase, IUIListObject, IUIObject, IEZDragDrop, IUIContainer
{
	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected List<SpriteRoot> uiObjs;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected List<SpriteText> textObjs;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected bool m_started;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected Camera renderCamera;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Vector2 topLeftEdge;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Vector2 bottomRightEdge;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Rect3D clippingRect;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private bool clipped;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private UIScrollList list;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	protected int index;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private bool m_selected;

	[Token(Token = "0x17000011")]
	public override IUIContainer Container
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1EDF358", Offset = "0x1EDE358", VA = "0x1EDF358", Slot = "83")]
		get
		{
			return null;
		}
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1EDF360", Offset = "0x1EDE360", VA = "0x1EDF360", Slot = "84")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public override EZTransitionList[] Transitions
	{
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1EDFE6C", Offset = "0x1EDEE6C", VA = "0x1EDFE6C", Slot = "105")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1EDFE74", Offset = "0x1EDEE74", VA = "0x1EDFE74", Slot = "106")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public override string[] States
	{
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1EDFE78", Offset = "0x1EDEE78", VA = "0x1EDFE78", Slot = "99")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000014")]
	public Vector2 TopLeftEdge
	{
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1EE0458", Offset = "0x1EDF458", VA = "0x1EE0458", Slot = "114")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17000015")]
	public Vector2 BottomRightEdge
	{
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1EE0460", Offset = "0x1EDF460", VA = "0x1EE0460", Slot = "115")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17000016")]
	public bool Managed
	{
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1EE05EC", Offset = "0x1EDF5EC", VA = "0x1EE05EC", Slot = "117")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000017")]
	public Rect3D ClippingRect
	{
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1EE05F4", Offset = "0x1EDF5F4", VA = "0x1EE05F4", Slot = "118")]
		get
		{
			return default(Rect3D);
		}
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1EE0614", Offset = "0x1EDF614", VA = "0x1EE0614", Slot = "119")]
		set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public bool Clipped
	{
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1EE0834", Offset = "0x1EDF834", VA = "0x1EE0834", Slot = "120")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1EE083C", Offset = "0x1EDF83C", VA = "0x1EE083C", Slot = "121")]
		set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public int Index
	{
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1EE0B40", Offset = "0x1EDFB40", VA = "0x1EE0B40", Slot = "126")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1EE0B48", Offset = "0x1EDFB48", VA = "0x1EE0B48", Slot = "127")]
		set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public override string Text
	{
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1EE0B50", Offset = "0x1EDFB50", VA = "0x1EE0B50", Slot = "72")]
		set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public SpriteText TextObj
	{
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1EE0C38", Offset = "0x1EDFC38", VA = "0x1EE0C38", Slot = "130")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001C")]
	public bool selected
	{
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1EE0C40", Offset = "0x1EDFC40", VA = "0x1EE0C40", Slot = "131")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1EE0C48", Offset = "0x1EDFC48", VA = "0x1EE0C48", Slot = "132")]
		set
		{
		}
	}

	[Token(Token = "0x1700001D")]
	public Camera RenderCamera
	{
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1EE0D50", Offset = "0x1EDFD50", VA = "0x1EE0D50", Slot = "134")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1EE0D58", Offset = "0x1EDFD58", VA = "0x1EE0D58", Slot = "135")]
		set
		{
		}
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1EDE188", Offset = "0x1EDD188", VA = "0x1EDE188", Slot = "76")]
	public override void Start()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1EDE1BC", Offset = "0x1EDD1BC", VA = "0x1EDE1BC")]
	public void ScanChildren()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1EDEA7C", Offset = "0x1EDDA7C", VA = "0x1EDEA7C", Slot = "137")]
	public void AddChild(GameObject go)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1EDEEC0", Offset = "0x1EDDEC0", VA = "0x1EDEEC0", Slot = "138")]
	public void RemoveChild(GameObject go)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1EDF350", Offset = "0x1EDE350", VA = "0x1EDF350", Slot = "139")]
	public void AddSubject(GameObject go)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x1EDF354", Offset = "0x1EDE354", VA = "0x1EDF354", Slot = "140")]
	public void RemoveSubject(GameObject go)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1EDF6B4", Offset = "0x1EDE6B4", VA = "0x1EDF6B4")]
	public void MakeChild(GameObject go)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x1EDF710", Offset = "0x1EDE710", VA = "0x1EDF710")]
	public SpriteRoot GetElement(string elementName)
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x1EDF7FC", Offset = "0x1EDE7FC", VA = "0x1EDF7FC")]
	public SpriteText GetTextElement(string elementName)
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x1EDF8E8", Offset = "0x1EDE8E8", VA = "0x1EDF8E8", Slot = "92")]
	public override void OnInput(POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x1EDFE64", Offset = "0x1EDEE64", VA = "0x1EDFE64", Slot = "104")]
	public override EZTransitionList GetTransitions(int index)
	{
		return null;
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x1EDFE80", Offset = "0x1EDEE80", VA = "0x1EDFE80", Slot = "112")]
	public bool IsContainer()
	{
		return default(bool);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x1EDFE88", Offset = "0x1EDEE88", VA = "0x1EDFE88", Slot = "113")]
	public void FindOuterEdges()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x1EE0468", Offset = "0x1EDF468", VA = "0x1EE0468", Slot = "116")]
	public void Hide(bool tf)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x1EE08B4", Offset = "0x1EDF8B4", VA = "0x1EE08B4", Slot = "122")]
	public void Unclip()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x1EE0A10", Offset = "0x1EDFA10", VA = "0x1EE0A10", Slot = "78")]
	public override void UpdateCollider()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x1EE0B30", Offset = "0x1EDFB30", VA = "0x1EE0B30", Slot = "124")]
	public void SetList(UIScrollList c)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x1EE0B38", Offset = "0x1EDFB38", VA = "0x1EE0B38", Slot = "141")]
	public virtual UIScrollList GetScrollList()
	{
		return null;
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x1EE0C54", Offset = "0x1EDFC54", VA = "0x1EE0C54", Slot = "133")]
	public void Delete()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x1EE0ED0", Offset = "0x1EDFED0", VA = "0x1EE0ED0", Slot = "136")]
	public void UpdateCamera()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x1EE1020", Offset = "0x1EE0020", VA = "0x1EE1020")]
	public UIListItemContainer()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1EE10E4", Offset = "0x1EE00E4", VA = "0x1EE10E4", Slot = "30")]
	private GameObject IUIObject.get_gameObject()
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x1EE10EC", Offset = "0x1EE00EC", VA = "0x1EE10EC", Slot = "31")]
	private Transform IUIObject.get_transform()
	{
		return null;
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x1EE10F4", Offset = "0x1EE00F4", VA = "0x1EE10F4", Slot = "33")]
	private string IUIObject.get_name()
	{
		return null;
	}
}
[Token(Token = "0x2000012")]
[AddComponentMenu("EZ GUI/Controls/Panel Tab")]
public class UIPanelTab : UIRadioBtn
{
	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
	public bool toggle;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
	public UIPanelManager panelManager;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
	public UIPanelBase panel;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
	public bool panelShowingAtStart;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A9")]
	protected bool panelIsShowing;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3AA")]
	protected bool internalCall;

	[Token(Token = "0x1700001E")]
	public override bool Value
	{
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1EE10FC", Offset = "0x1EE00FC", VA = "0x1EE10FC", Slot = "195")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1EE1104", Offset = "0x1EE0104", VA = "0x1EE1104", Slot = "196")]
		set
		{
		}
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x1EE1244", Offset = "0x1EE0244", VA = "0x1EE1244", Slot = "13")]
	public override void Start()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x1EE140C", Offset = "0x1EE040C", VA = "0x1EE140C", Slot = "180")]
	public override void OnInput(ref POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x1EE14C8", Offset = "0x1EE04C8", VA = "0x1EE14C8")]
	protected void DoPanelStuff()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x1EE1650", Offset = "0x1EE0650", VA = "0x1EE1650", Slot = "16")]
	public override void Copy(SpriteRoot s)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x1EE1664", Offset = "0x1EE0664", VA = "0x1EE1664", Slot = "160")]
	public override void Copy(SpriteRoot s, ControlCopyFlags flags)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x1EE1758", Offset = "0x1EE0758", VA = "0x1EE1758")]
	public new static UIPanelTab Create(string name, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x1EE1898", Offset = "0x1EE0898", VA = "0x1EE1898")]
	public new static UIPanelTab Create(string name, Vector3 pos, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x1EE1A20", Offset = "0x1EE0A20", VA = "0x1EE1A20")]
	public UIPanelTab()
	{
	}
}
[Serializable]
[Token(Token = "0x2000013")]
[AddComponentMenu("EZ GUI/Controls/Progress Arc")]
[RequireComponent(typeof(MeshRenderer))]
[ExecuteInEditMode]
[RequireComponent(typeof(MeshFilter))]
public class UIProgressArc : PackableStub, IUseCamera, ISpritePackable, ISpriteAnimatable, ISpriteAggregator, IEZLinkedListItem<ISpriteAnimatable>, IPackableControl, IControl
{
	[Token(Token = "0x2000014")]
	public enum UV_MAP_MODE
	{
		[Token(Token = "0x4000097")]
		Frontal,
		[Token(Token = "0x4000098")]
		Linear
	}

	[Token(Token = "0x2000015")]
	public enum LINEAR_UV_ANCHOR
	{
		[Token(Token = "0x400009A")]
		Front,
		[Token(Token = "0x400009B")]
		Back,
		[Token(Token = "0x400009C")]
		Both
	}

	[Token(Token = "0x2000016")]
	public delegate void AnimCompleteDelegate(UIProgressArc arc);

	[Token(Token = "0x2000017")]
	public delegate void AnimFrameDelegate(UIProgressArc arc, int frame);

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected Texture2D[] sourceTextures;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected CSpriteFrame[] spriteFrames;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public UVAnimation[] animations;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected UVAnimation curAnim;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool persistent;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int facets;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float outerRadius;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float innerRadius;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float startAngle;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float endAngle;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float m_value;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public UV_MAP_MODE uvMapMode;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public LINEAR_UV_ANCHOR linearUvAnchor;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float bleedCompensation;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool pixelPerfect;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Color color;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Camera renderCamera;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public bool hideAtStart;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
	public bool doNotTrimImages;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public int defaultAnim;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected int curAnimIndex;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected AnimCompleteDelegate animCompleteDelegate;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected AnimFrameDelegate animFrameDelegate;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected float timeSinceLastFrame;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	protected float timeBetweenAnimFrames;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected int framesToAdvance;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	protected bool animating;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	protected Mesh mesh;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	protected Mesh oldMesh;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	protected MeshFilter meshFilter;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	protected MeshRenderer meshRenderer;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	protected Texture texture;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	protected SPRITE_FRAME frameInfo;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	protected EZScreenPlacement screenPlacer;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	protected Vector3[] vertices;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	protected Vector2[] UVs;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	protected Color[] colors;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	protected int[] faces;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	protected bool m_started;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x131")]
	protected bool deleted;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x132")]
	protected bool m_hidden;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x133")]
	protected bool isClone;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	protected bool vertCountChanged;

	[Token(Token = "0x4000088")]
	protected const float RAD90 = (float)Math.PI / 2f;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	protected Vector2 uvsPerTexel;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	protected Vector2 texelsPerUV;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	protected float worldUnitsPerScreenPixel;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	protected Vector2 screenSize;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	[HideInInspector]
	public TextureAnim[] states;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	protected ISpriteAnimatable m_prev;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	protected ISpriteAnimatable m_next;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public string text;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public SpriteText spriteText;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public float textOffsetZ;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
	protected SpriteText.Anchor_Pos defaultTextAnchor;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	protected SpriteText.Alignment_Type defaultTextAlignment;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	[HideInInspector]
	public object data;

	[Token(Token = "0x1700001F")]
	public float Value
	{
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1EE357C", Offset = "0x1EE257C", VA = "0x1EE357C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1EE3584", Offset = "0x1EE2584", VA = "0x1EE3584")]
		set
		{
		}
	}

	[Token(Token = "0x17000020")]
	public Camera RenderCamera
	{
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1EE3648", Offset = "0x1EE2648", VA = "0x1EE3648", Slot = "14")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1EE3650", Offset = "0x1EE2650", VA = "0x1EE3650", Slot = "15")]
		set
		{
		}
	}

	[Token(Token = "0x17000021")]
	public Color Color
	{
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1EE36E0", Offset = "0x1EE26E0", VA = "0x1EE36E0", Slot = "20")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1EE36EC", Offset = "0x1EE26EC", VA = "0x1EE36EC", Slot = "21")]
		set
		{
		}
	}

	[Token(Token = "0x17000022")]
	public SpriteRoot.ANCHOR_METHOD Anchor
	{
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1EE3798", Offset = "0x1EE2798", VA = "0x1EE3798", Slot = "19")]
		get
		{
			return default(SpriteRoot.ANCHOR_METHOD);
		}
	}

	[Token(Token = "0x17000023")]
	public bool Persistent
	{
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1EE37D8", Offset = "0x1EE27D8", VA = "0x1EE37D8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1EE2878", Offset = "0x1EE1878", VA = "0x1EE2878")]
		set
		{
		}
	}

	[Token(Token = "0x17000024")]
	public virtual TextureAnim[] States
	{
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1EE37E0", Offset = "0x1EE27E0", VA = "0x1EE37E0", Slot = "60")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1EE37E8", Offset = "0x1EE27E8", VA = "0x1EE37E8", Slot = "61")]
		set
		{
		}
	}

	[Token(Token = "0x17000025")]
	public override CSpriteFrame DefaultFrame
	{
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1EE37F0", Offset = "0x1EE27F0", VA = "0x1EE37F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000026")]
	public virtual TextureAnim DefaultState
	{
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1EE38F0", Offset = "0x1EE28F0", VA = "0x1EE38F0", Slot = "62")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000027")]
	public bool SupportsArbitraryAnimations
	{
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1EE3E48", Offset = "0x1EE2E48", VA = "0x1EE3E48", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000028")]
	public override bool DoNotTrimImages
	{
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1EE5650", Offset = "0x1EE4650", VA = "0x1EE5650", Slot = "10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1EE5658", Offset = "0x1EE4658", VA = "0x1EE5658", Slot = "11")]
		set
		{
		}
	}

	[Token(Token = "0x17000029")]
	public override Texture2D[] SourceTextures
	{
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1EE5FFC", Offset = "0x1EE4FFC", VA = "0x1EE5FFC", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002A")]
	public override CSpriteFrame[] SpriteFrames
	{
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1EE6004", Offset = "0x1EE5004", VA = "0x1EE6004", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002B")]
	public ISpriteAnimatable prev
	{
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1EE600C", Offset = "0x1EE500C", VA = "0x1EE600C", Slot = "36")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1EE6014", Offset = "0x1EE5014", VA = "0x1EE6014", Slot = "37")]
		set
		{
		}
	}

	[Token(Token = "0x1700002C")]
	public ISpriteAnimatable next
	{
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1EE601C", Offset = "0x1EE501C", VA = "0x1EE601C", Slot = "38")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1EE6024", Offset = "0x1EE5024", VA = "0x1EE6024", Slot = "39")]
		set
		{
		}
	}

	[Token(Token = "0x1700002D")]
	public virtual EZTransitionList[] Transitions
	{
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1EE6158", Offset = "0x1EE5158", VA = "0x1EE6158", Slot = "86")]
		get
		{
			return null;
		}
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1EE6160", Offset = "0x1EE5160", VA = "0x1EE6160", Slot = "87")]
		set
		{
		}
	}

	[Token(Token = "0x1700002E")]
	public virtual string Text
	{
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1EE6248", Offset = "0x1EE5248", VA = "0x1EE6248", Slot = "91")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1EE6250", Offset = "0x1EE5250", VA = "0x1EE6250", Slot = "92")]
		set
		{
		}
	}

	[Token(Token = "0x1700002F")]
	public virtual bool IncludeTextInAutoCollider
	{
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1EE6710", Offset = "0x1EE5710", VA = "0x1EE6710", Slot = "93")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1EE6718", Offset = "0x1EE5718", VA = "0x1EE6718", Slot = "94")]
		set
		{
		}
	}

	[Token(Token = "0x17000030")]
	public object Data
	{
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1EE671C", Offset = "0x1EE571C", VA = "0x1EE671C", Slot = "57")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1EE6724", Offset = "0x1EE5724", VA = "0x1EE6724", Slot = "58")]
		set
		{
		}
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x1EE1A30", Offset = "0x1EE0A30", VA = "0x1EE1A30")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x1EE1EA4", Offset = "0x1EE0EA4", VA = "0x1EE1EA4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x1EE2794", Offset = "0x1EE1794", VA = "0x1EE2794")]
	private void CreateMesh()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x1EE28F0", Offset = "0x1EE18F0", VA = "0x1EE28F0")]
	private void InitMesh()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x1EE2A10", Offset = "0x1EE1A10", VA = "0x1EE2A10")]
	private void InitFaces()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x1EE2CA0", Offset = "0x1EE1CA0", VA = "0x1EE2CA0")]
	private void CalcGeometry(int affectedFacets)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x1EE2F28", Offset = "0x1EE1F28", VA = "0x1EE2F28")]
	private void CalcGeometryWithFrontalUVs(int affectedFacets)
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x1EE32C0", Offset = "0x1EE22C0", VA = "0x1EE32C0")]
	private void CalcFrontalUVs()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x1EE2B90", Offset = "0x1EE1B90", VA = "0x1EE2B90")]
	private void UpdateMesh(int affectedFacets)
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x1EE3654", Offset = "0x1EE2654", VA = "0x1EE3654", Slot = "12")]
	public void SetCamera()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x1EE22BC", Offset = "0x1EE12BC", VA = "0x1EE22BC", Slot = "13")]
	public void SetCamera(Camera c)
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x1EE365C", Offset = "0x1EE265C", VA = "0x1EE365C")]
	public void CalcSize()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x1EE36F8", Offset = "0x1EE26F8", VA = "0x1EE36F8")]
	public void SetColor(Color c)
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x1EE2AE0", Offset = "0x1EE1AE0", VA = "0x1EE2AE0")]
	protected void UpdateColors()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x1EE3704", Offset = "0x1EE2704", VA = "0x1EE3704")]
	protected void UpdateUVs()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x1EE37A0", Offset = "0x1EE27A0", VA = "0x1EE37A0", Slot = "59")]
	public virtual void Hide(bool tf)
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x1EE37D0", Offset = "0x1EE27D0", VA = "0x1EE37D0")]
	public bool IsHidden()
	{
		return default(bool);
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x1EE3968", Offset = "0x1EE2968", VA = "0x1EE3968", Slot = "63")]
	public virtual Vector2 GetDefaultPixelSize(PathFromGUIDDelegate guid2Path, AssetLoaderDelegate loader)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x1EE3CE0", Offset = "0x1EE2CE0", VA = "0x1EE3CE0")]
	public UVAnimation GetCurAnim()
	{
		return null;
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x1EE3CE8", Offset = "0x1EE2CE8", VA = "0x1EE3CE8")]
	public UVAnimation GetAnim(string name)
	{
		return null;
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x1EE3D80", Offset = "0x1EE2D80", VA = "0x1EE3D80", Slot = "64")]
	public virtual int GetStateIndex(string stateName)
	{
		return default(int);
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x1EE3DFC", Offset = "0x1EE2DFC", VA = "0x1EE3DFC", Slot = "65")]
	public virtual void SetState(int index)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x1EE3E0C", Offset = "0x1EE2E0C", VA = "0x1EE3E0C", Slot = "66")]
	public virtual void Clear()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x1EE3E50", Offset = "0x1EE2E50", VA = "0x1EE3E50", Slot = "67")]
	public virtual void Copy(SpriteRoot s)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x1EE40DC", Offset = "0x1EE30DC", VA = "0x1EE40DC", Slot = "68")]
	public virtual void Copy(IControl c)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x1EE40F0", Offset = "0x1EE30F0", VA = "0x1EE40F0", Slot = "69")]
	public virtual void Copy(IControl c, ControlCopyFlags f)
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x1EE40F4", Offset = "0x1EE30F4", VA = "0x1EE40F4", Slot = "70")]
	public virtual void CopyAll(SpriteRoot s)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x1EE4410", Offset = "0x1EE3410", VA = "0x1EE4410", Slot = "71")]
	public virtual bool StepAnim(float time)
	{
		return default(bool);
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x1EE4640", Offset = "0x1EE3640", VA = "0x1EE4640")]
	public void PlayAnim(UVAnimation anim, int frame)
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x1EE4844", Offset = "0x1EE3844", VA = "0x1EE4844")]
	public void PlayAnim(UVAnimation anim)
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x1EE484C", Offset = "0x1EE384C", VA = "0x1EE484C")]
	public void PlayAnim(int index, int frame)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x1EE4950", Offset = "0x1EE3950", VA = "0x1EE4950", Slot = "72")]
	public virtual void PlayAnim(int index)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x1EE4A50", Offset = "0x1EE3A50", VA = "0x1EE4A50")]
	public void PlayAnim(string name, int frame)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x1EE4B98", Offset = "0x1EE3B98", VA = "0x1EE4B98", Slot = "73")]
	public virtual void PlayAnim(string name)
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x1EE4BA0", Offset = "0x1EE3BA0", VA = "0x1EE4BA0")]
	public void PlayAnimInReverse(UVAnimation anim)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x1EE4CC0", Offset = "0x1EE3CC0", VA = "0x1EE4CC0")]
	public void PlayAnimInReverse(UVAnimation anim, int frame)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x1EE4DBC", Offset = "0x1EE3DBC", VA = "0x1EE4DBC", Slot = "74")]
	public virtual void PlayAnimInReverse(int index)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x1EE4EB8", Offset = "0x1EE3EB8", VA = "0x1EE4EB8")]
	public void PlayAnimInReverse(int index, int frame)
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x1EE4FBC", Offset = "0x1EE3FBC", VA = "0x1EE4FBC", Slot = "75")]
	public virtual void PlayAnimInReverse(string name)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x1EE5114", Offset = "0x1EE4114", VA = "0x1EE5114")]
	public void PlayAnimInReverse(string name, int frame)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x1EE5280", Offset = "0x1EE4280", VA = "0x1EE5280")]
	public void DoAnim(int index)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x1EE52B0", Offset = "0x1EE42B0", VA = "0x1EE52B0")]
	public void DoAnim(string name)
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x1EE5310", Offset = "0x1EE4310", VA = "0x1EE5310")]
	public void DoAnim(UVAnimation anim)
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x1EE5330", Offset = "0x1EE4330", VA = "0x1EE5330")]
	public void SetCurFrame(int index)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x1EE53A8", Offset = "0x1EE43A8", VA = "0x1EE53A8", Slot = "76")]
	public virtual void StopAnim()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x1EE3E38", Offset = "0x1EE2E38", VA = "0x1EE3E38")]
	public void PauseAnim()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x1EE5430", Offset = "0x1EE4430", VA = "0x1EE5430")]
	public void UnpauseAnim()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x1EE4780", Offset = "0x1EE3780", VA = "0x1EE4780")]
	protected void AddToAnimatedList()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x1EE53D0", Offset = "0x1EE43D0", VA = "0x1EE53D0")]
	protected void RemoveFromAnimatedList()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x1EE5440", Offset = "0x1EE4440", VA = "0x1EE5440", Slot = "77")]
	public virtual void Delete()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x1EE54DC", Offset = "0x1EE44DC", VA = "0x1EE54DC", Slot = "78")]
	public virtual void OnDestroy()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x1EE54EC", Offset = "0x1EE44EC", VA = "0x1EE54EC", Slot = "79")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x1EE5510", Offset = "0x1EE4510", VA = "0x1EE5510", Slot = "80")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x1EE5588", Offset = "0x1EE4588", VA = "0x1EE5588", Slot = "7")]
	public override Material GetPackedMaterial(out string errString)
	{
		return null;
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x1EE5644", Offset = "0x1EE4644", VA = "0x1EE5644", Slot = "9")]
	public override void SetUVs(Rect uvs)
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x1EE5664", Offset = "0x1EE4664", VA = "0x1EE5664", Slot = "4")]
	public override void Aggregate(PathFromGUIDDelegate guid2Path, LoadAssetDelegate load, GUIDFromPathDelegate path2Guid)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x1EE602C", Offset = "0x1EE502C", VA = "0x1EE602C", Slot = "44")]
	public void UpdateCollider()
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x1EE6030", Offset = "0x1EE5030", VA = "0x1EE6030", Slot = "81")]
	public virtual int DrawPreStateSelectGUI(int selState, bool inspector)
	{
		return default(int);
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x1EE6038", Offset = "0x1EE5038", VA = "0x1EE6038", Slot = "82")]
	public virtual int DrawPostStateSelectGUI(int selState)
	{
		return default(int);
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x1EE6040", Offset = "0x1EE5040", VA = "0x1EE6040", Slot = "83")]
	public virtual void DrawPreTransitionUI(int selState, IGUIScriptSelector gui)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x1EE6044", Offset = "0x1EE5044", VA = "0x1EE6044", Slot = "84")]
	public virtual string[] EnumStateElements()
	{
		return null;
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x1EE6150", Offset = "0x1EE5150", VA = "0x1EE6150", Slot = "85")]
	public virtual EZTransitionList GetTransitions(int index)
	{
		return null;
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x1EE6164", Offset = "0x1EE5164", VA = "0x1EE6164", Slot = "88")]
	public virtual string GetStateLabel(int index)
	{
		return null;
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x1EE616C", Offset = "0x1EE516C", VA = "0x1EE616C", Slot = "89")]
	public virtual void SetStateLabel(int index, string label)
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x1EE6170", Offset = "0x1EE5170", VA = "0x1EE6170", Slot = "90")]
	public virtual ASCSEInfo GetStateElementInfo(int stateNum)
	{
		return null;
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x1EE672C", Offset = "0x1EE572C", VA = "0x1EE672C")]
	public UIProgressArc()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x1EE6888", Offset = "0x1EE5888", VA = "0x1EE6888", Slot = "34")]
	private GameObject ISpriteAggregator.get_gameObject()
	{
		return null;
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x1EE6890", Offset = "0x1EE5890", VA = "0x1EE6890", Slot = "16")]
	private GameObject ISpritePackable.get_gameObject()
	{
		return null;
	}
}
[Token(Token = "0x2000018")]
[AddComponentMenu("EZ GUI/Controls/Progress Bar")]
public class UIProgressBar : AutoSpriteControlBase
{
	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x314")]
	protected float m_value;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
	protected AutoSprite emptySprite;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
	[HideInInspector]
	public TextureAnim[] states;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
	public SpriteRoot[] filledLayers;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
	public SpriteRoot[] emptyLayers;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
	protected int[] filledIndices;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
	protected int[] emptyIndices;

	[Token(Token = "0x17000031")]
	public float Value
	{
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1EE6B90", Offset = "0x1EE5B90", VA = "0x1EE6B90")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1EE6B98", Offset = "0x1EE5B98", VA = "0x1EE6B98")]
		set
		{
		}
	}

	[Token(Token = "0x17000032")]
	public override TextureAnim[] States
	{
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1EE6D0C", Offset = "0x1EE5D0C", VA = "0x1EE6D0C", Slot = "79")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1EE6D14", Offset = "0x1EE5D14", VA = "0x1EE6D14", Slot = "80")]
		set
		{
		}
	}

	[Token(Token = "0x17000033")]
	public override EZTransitionList[] Transitions
	{
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1EE6D24", Offset = "0x1EE5D24", VA = "0x1EE6D24", Slot = "186")]
		get
		{
			return null;
		}
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1EE6D2C", Offset = "0x1EE5D2C", VA = "0x1EE6D2C", Slot = "187")]
		set
		{
		}
	}

	[Token(Token = "0x17000034")]
	public override IUIContainer Container
	{
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1EE7B38", Offset = "0x1EE6B38", VA = "0x1EE7B38", Slot = "170")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1EE7B40", Offset = "0x1EE6B40", VA = "0x1EE7B40", Slot = "171")]
		set
		{
		}
	}

	[Token(Token = "0x17000035")]
	public override bool Clipped
	{
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1EE7D18", Offset = "0x1EE6D18", VA = "0x1EE7D18", Slot = "42")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1EE7D20", Offset = "0x1EE6D20", VA = "0x1EE7D20", Slot = "43")]
		set
		{
		}
	}

	[Token(Token = "0x17000036")]
	public override Rect3D ClippingRect
	{
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1EE7D78", Offset = "0x1EE6D78", VA = "0x1EE7D78", Slot = "40")]
		get
		{
			return default(Rect3D);
		}
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1EE7DB8", Offset = "0x1EE6DB8", VA = "0x1EE7DB8", Slot = "41")]
		set
		{
		}
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x1EE6D1C", Offset = "0x1EE5D1C", VA = "0x1EE6D1C", Slot = "185")]
	public override EZTransitionList GetTransitions(int index)
	{
		return null;
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x1EE6D30", Offset = "0x1EE5D30", VA = "0x1EE6D30", Slot = "180")]
	public override void OnInput(ref POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x1EE6D34", Offset = "0x1EE5D34", VA = "0x1EE6D34", Slot = "13")]
	public override void Start()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x1EE78A8", Offset = "0x1EE68A8", VA = "0x1EE78A8", Slot = "22")]
	public override void SetSize(float width, float height)
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x1EE7964", Offset = "0x1EE6964", VA = "0x1EE7964", Slot = "16")]
	public override void Copy(SpriteRoot s)
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x1EE7978", Offset = "0x1EE6978", VA = "0x1EE7978", Slot = "160")]
	public override void Copy(SpriteRoot s, ControlCopyFlags flags)
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x1EE7ADC", Offset = "0x1EE6ADC", VA = "0x1EE7ADC", Slot = "17")]
	public override void InitUVs()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x1EE6BB4", Offset = "0x1EE5BB4", VA = "0x1EE6BB4")]
	protected void UpdateProgress()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x1EE7CD8", Offset = "0x1EE6CD8", VA = "0x1EE7CD8", Slot = "28")]
	public override void Unclip()
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x1EE7E58", Offset = "0x1EE6E58", VA = "0x1EE7E58")]
	public static UIProgressBar Create(string name, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x1EE7F98", Offset = "0x1EE6F98", VA = "0x1EE7F98")]
	public static UIProgressBar Create(string name, Vector3 pos, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x1EE8120", Offset = "0x1EE7120", VA = "0x1EE8120", Slot = "37")]
	public override void Hide(bool tf)
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x1EE81D0", Offset = "0x1EE71D0", VA = "0x1EE81D0", Slot = "30")]
	public override void SetColor(Color c)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x1EE82B0", Offset = "0x1EE72B0", VA = "0x1EE82B0")]
	public UIProgressBar()
	{
	}
}
[Token(Token = "0x2000019")]
public interface IRadioButton
{
	[Token(Token = "0x17000037")]
	bool Value
	{
		[Token(Token = "0x600013E")]
		get;
		[Token(Token = "0x600013F")]
		set;
	}

	[Token(Token = "0x17000038")]
	string name
	{
		[Token(Token = "0x6000140")]
		get;
		[Token(Token = "0x6000141")]
		set;
	}
}
[Token(Token = "0x200001A")]
public class RadioBtnGroup
{
	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<RadioBtnGroup> groups;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int groupID;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<IRadioButton> buttons;

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x1EE841C", Offset = "0x1EE741C", VA = "0x1EE841C")]
	public RadioBtnGroup(int id)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x1EE8554", Offset = "0x1EE7554", VA = "0x1EE8554", Slot = "1")]
	~RadioBtnGroup()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x1EE8658", Offset = "0x1EE7658", VA = "0x1EE8658")]
	public static IRadioButton GetSelected(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x1EE86D8", Offset = "0x1EE76D8", VA = "0x1EE86D8")]
	public static IRadioButton GetSelected(int id)
	{
		return null;
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x1EE88DC", Offset = "0x1EE78DC", VA = "0x1EE88DC")]
	public static RadioBtnGroup GetGroup(int id)
	{
		return null;
	}
}
[Token(Token = "0x200001B")]
[AddComponentMenu("EZ GUI/Controls/Radio Button")]
public class UIRadioBtn : AutoSpriteControlBase, IRadioButton
{
	[Token(Token = "0x200001C")]
	protected enum CONTROL_STATE
	{
		[Token(Token = "0x40000BC")]
		True,
		[Token(Token = "0x40000BD")]
		False,
		[Token(Token = "0x40000BE")]
		Disabled,
		[Token(Token = "0x40000BF")]
		Over,
		[Token(Token = "0x40000C0")]
		Active
	}

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x314")]
	private CONTROL_STATE state;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
	private CONTROL_STATE layerState;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31C")]
	protected bool btnValue;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31D")]
	public bool useParentForGrouping;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
	public int radioGroup;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
	protected RadioBtnGroup group;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
	public bool defaultValue;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x331")]
	protected bool stateChangeWhileDeactivated;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
	[HideInInspector]
	public TextureAnim[] states;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
	[HideInInspector]
	public string[] stateLabels;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
	[HideInInspector]
	public EZTransitionList[] transitions;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
	private EZTransition prevTransition;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
	public SpriteRoot[] layers;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
	public MonoBehaviour scriptWithMethodToInvoke;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
	public string methodToInvoke;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
	public POINTER_INFO.INPUT_EVENT whenToInvoke;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x374")]
	public float delay;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
	public AudioSource soundToPlay;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
	public bool disableHoverEffect;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
	protected int[,] stateIndices;

	[Token(Token = "0x17000039")]
	public override bool controlIsEnabled
	{
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1EE8A90", Offset = "0x1EE7A90", VA = "0x1EE8A90", Slot = "166")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1EE8A98", Offset = "0x1EE7A98", VA = "0x1EE8A98", Slot = "167")]
		set
		{
		}
	}

	[Token(Token = "0x1700003A")]
	public virtual bool Value
	{
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1EE8BD0", Offset = "0x1EE7BD0", VA = "0x1EE8BD0", Slot = "195")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1EE8BD8", Offset = "0x1EE7BD8", VA = "0x1EE8BD8", Slot = "196")]
		set
		{
		}
	}

	[Token(Token = "0x1700003B")]
	public override TextureAnim[] States
	{
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1EE8BEC", Offset = "0x1EE7BEC", VA = "0x1EE8BEC", Slot = "79")]
		get
		{
			return null;
		}
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1EE8BF4", Offset = "0x1EE7BF4", VA = "0x1EE8BF4", Slot = "80")]
		set
		{
		}
	}

	[Token(Token = "0x1700003C")]
	public override EZTransitionList[] Transitions
	{
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1EE8CB0", Offset = "0x1EE7CB0", VA = "0x1EE8CB0", Slot = "186")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1EE8CB8", Offset = "0x1EE7CB8", VA = "0x1EE8CB8", Slot = "187")]
		set
		{
		}
	}

	[Token(Token = "0x1700003D")]
	public override CSpriteFrame DefaultFrame
	{
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1EE8CC0", Offset = "0x1EE7CC0", VA = "0x1EE8CC0", Slot = "81")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003E")]
	public override TextureAnim DefaultState
	{
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1EE8D70", Offset = "0x1EE7D70", VA = "0x1EE8D70", Slot = "82")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003F")]
	public override string Text
	{
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1EEA418", Offset = "0x1EE9418", VA = "0x1EEA418", Slot = "156")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1EEA420", Offset = "0x1EE9420", VA = "0x1EEA420", Slot = "157")]
		set
		{
		}
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x1EE8BFC", Offset = "0x1EE7BFC", VA = "0x1EE8BFC", Slot = "188")]
	public override string GetStateLabel(int index)
	{
		return null;
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x1EE8C2C", Offset = "0x1EE7C2C", VA = "0x1EE8C2C", Slot = "189")]
	public override void SetStateLabel(int index, string label)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x1EE8C74", Offset = "0x1EE7C74", VA = "0x1EE8C74", Slot = "185")]
	public override EZTransitionList GetTransitions(int index)
	{
		return null;
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x1EE8DB4", Offset = "0x1EE7DB4", VA = "0x1EE8DB4", Slot = "180")]
	public override void OnInput(ref POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x1EE9120", Offset = "0x1EE8120", VA = "0x1EE9120", Slot = "16")]
	public override void Copy(SpriteRoot s)
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x1EE9134", Offset = "0x1EE8134", VA = "0x1EE9134", Slot = "160")]
	public override void Copy(SpriteRoot s, ControlCopyFlags flags)
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x1EE9288", Offset = "0x1EE8288", VA = "0x1EE9288", Slot = "21")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x1EE92F8", Offset = "0x1EE82F8", VA = "0x1EE92F8")]
	public void SetGroup(GameObject parent)
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x1EE9458", Offset = "0x1EE8458", VA = "0x1EE9458")]
	public void SetGroup(Transform parent)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x1EE9334", Offset = "0x1EE8334", VA = "0x1EE9334")]
	public void SetGroup(int groupID)
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x1EE9614", Offset = "0x1EE8614", VA = "0x1EE9614", Slot = "12")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x1EE9634", Offset = "0x1EE8634", VA = "0x1EE9634", Slot = "13")]
	public override void Start()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x1EE948C", Offset = "0x1EE848C", VA = "0x1EE948C")]
	protected void PopOtherButtonsInGroup()
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x1EEA108", Offset = "0x1EE9108", VA = "0x1EEA108", Slot = "197")]
	protected virtual void SetValue(bool val)
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x1EEA120", Offset = "0x1EE9120", VA = "0x1EEA120", Slot = "198")]
	protected virtual void SetValue(bool val, bool suppressTransition)
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x1EEA19C", Offset = "0x1EE919C", VA = "0x1EEA19C", Slot = "199")]
	protected virtual void SetButtonState()
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x1EEA1B0", Offset = "0x1EE91B0", VA = "0x1EEA1B0", Slot = "200")]
	protected virtual void SetButtonState(bool suppressTransition)
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x1EE8FE4", Offset = "0x1EE7FE4", VA = "0x1EE8FE4")]
	protected void SetLayerState(CONTROL_STATE s)
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x1EEA2D4", Offset = "0x1EE92D4", VA = "0x1EEA2D4")]
	protected void StartTransition(int newState, int prevState)
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x1EEA3E0", Offset = "0x1EE93E0", VA = "0x1EEA3E0", Slot = "19")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x1EE8AB8", Offset = "0x1EE7AB8", VA = "0x1EE8AB8")]
	protected void DisableMe()
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x1EEA5AC", Offset = "0x1EE95AC", VA = "0x1EEA5AC", Slot = "17")]
	public override void InitUVs()
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x1EEA634", Offset = "0x1EE9634", VA = "0x1EEA634", Slot = "183")]
	public override void DrawPreTransitionUI(int selState, IGUIScriptSelector gui)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x1EEA6E8", Offset = "0x1EE96E8", VA = "0x1EEA6E8")]
	public static UIRadioBtn Create(string name, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x1EEA828", Offset = "0x1EE9828", VA = "0x1EEA828")]
	public static UIRadioBtn Create(string name, Vector3 pos, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x1EEA9B0", Offset = "0x1EE99B0", VA = "0x1EEA9B0")]
	public UIRadioBtn()
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x1EEAF30", Offset = "0x1EE9F30", VA = "0x1EEAF30", Slot = "193")]
	private string IRadioButton.get_name()
	{
		return null;
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x1EEAF38", Offset = "0x1EE9F38", VA = "0x1EEAF38", Slot = "194")]
	private void IRadioButton.set_name(string value)
	{
	}
}
[Token(Token = "0x200001D")]
[AddComponentMenu("EZ GUI/Controls/3D Radio Button")]
public class UIRadioBtn3D : ControlBase, IRadioButton
{
	[Token(Token = "0x200001E")]
	protected enum CONTROL_STATE
	{
		[Token(Token = "0x40000D2")]
		True,
		[Token(Token = "0x40000D3")]
		False,
		[Token(Token = "0x40000D4")]
		Disabled
	}

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private CONTROL_STATE state;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected bool btnValue;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
	public bool useParentForGrouping;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public int radioGroup;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected RadioBtnGroup group;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public bool defaultValue;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
	protected bool stateChangeWhileDeactivated;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected string[] states;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[HideInInspector]
	public EZTransitionList[] transitions;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private EZTransition prevTransition;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[HideInInspector]
	public string[] stateLabels;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public MonoBehaviour scriptWithMethodToInvoke;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public string methodToInvoke;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public POINTER_INFO.INPUT_EVENT whenToInvoke;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public float delay;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public AudioSource soundToPlay;

	[Token(Token = "0x17000040")]
	public override bool controlIsEnabled
	{
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x1EEAF40", Offset = "0x1EE9F40", VA = "0x1EEAF40", Slot = "79")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x1EEAF48", Offset = "0x1EE9F48", VA = "0x1EEAF48", Slot = "80")]
		set
		{
		}
	}

	[Token(Token = "0x17000041")]
	public bool Value
	{
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x1EEAFC4", Offset = "0x1EE9FC4", VA = "0x1EEAFC4", Slot = "112")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1EEAFCC", Offset = "0x1EE9FCC", VA = "0x1EEAFCC", Slot = "113")]
		set
		{
		}
	}

	[Token(Token = "0x17000042")]
	public override string[] States
	{
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x1EEB1C0", Offset = "0x1EEA1C0", VA = "0x1EEB1C0", Slot = "99")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000043")]
	public override EZTransitionList[] Transitions
	{
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x1EEB204", Offset = "0x1EEA204", VA = "0x1EEB204", Slot = "105")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1EEB20C", Offset = "0x1EEA20C", VA = "0x1EEB20C", Slot = "106")]
		set
		{
		}
	}

	[Token(Token = "0x17000044")]
	public override string Text
	{
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x1EEBBC0", Offset = "0x1EEABC0", VA = "0x1EEBBC0", Slot = "71")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x1EEBBC8", Offset = "0x1EEABC8", VA = "0x1EEBBC8", Slot = "72")]
		set
		{
		}
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x1EEB1C8", Offset = "0x1EEA1C8", VA = "0x1EEB1C8", Slot = "104")]
	public override EZTransitionList GetTransitions(int index)
	{
		return null;
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x1EEB214", Offset = "0x1EEA214", VA = "0x1EEB214", Slot = "107")]
	public override string GetStateLabel(int index)
	{
		return null;
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x1EEB244", Offset = "0x1EEA244", VA = "0x1EEB244", Slot = "108")]
	public override void SetStateLabel(int index, string label)
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x1EEB28C", Offset = "0x1EEA28C", VA = "0x1EEB28C", Slot = "93")]
	public override void OnInput(ref POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x1EEB3D4", Offset = "0x1EEA3D4", VA = "0x1EEB3D4", Slot = "94")]
	public override void OnEnable()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x1EEB40C", Offset = "0x1EEA40C", VA = "0x1EEB40C", Slot = "96")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x1EEB47C", Offset = "0x1EEA47C", VA = "0x1EEB47C")]
	public void SetGroup(GameObject parent)
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x1EEB4B8", Offset = "0x1EEA4B8", VA = "0x1EEB4B8")]
	public void SetGroup(int groupID)
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x1EEB5DC", Offset = "0x1EEA5DC", VA = "0x1EEB5DC", Slot = "75")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x1EEB5FC", Offset = "0x1EEA5FC", VA = "0x1EEB5FC", Slot = "76")]
	public override void Start()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x1EEB8D0", Offset = "0x1EEA8D0", VA = "0x1EEB8D0", Slot = "97")]
	public override void Copy(IControl c)
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x1EEB8E4", Offset = "0x1EEA8E4", VA = "0x1EEB8E4", Slot = "98")]
	public override void Copy(IControl c, ControlCopyFlags flags)
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x1EEB040", Offset = "0x1EEA040", VA = "0x1EEB040")]
	protected void PopOtherButtonsInGroup()
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x1EEBA34", Offset = "0x1EEAA34", VA = "0x1EEBA34", Slot = "116")]
	protected virtual void SetButtonState()
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x1EEBAD8", Offset = "0x1EEAAD8", VA = "0x1EEBAD8")]
	protected void StartTransition(int newState, int prevState)
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x1EEAF68", Offset = "0x1EE9F68", VA = "0x1EEAF68")]
	protected void DisableMe()
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x1EEBD54", Offset = "0x1EEAD54", VA = "0x1EEBD54", Slot = "102")]
	public override void DrawPreTransitionUI(int selState, IGUIScriptSelector gui)
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x1EEBE08", Offset = "0x1EEAE08", VA = "0x1EEBE08")]
	public static UIRadioBtn3D Create(string name, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x1EEBF48", Offset = "0x1EEAF48", VA = "0x1EEBF48")]
	public static UIRadioBtn3D Create(string name, Vector3 pos, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x1EEC0D0", Offset = "0x1EEB0D0", VA = "0x1EEC0D0")]
	public UIRadioBtn3D()
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x1EEC570", Offset = "0x1EEB570", VA = "0x1EEC570", Slot = "114")]
	private string IRadioButton.get_name()
	{
		return null;
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x1EEC578", Offset = "0x1EEB578", VA = "0x1EEC578", Slot = "115")]
	private void IRadioButton.set_name(string value)
	{
	}
}
[Token(Token = "0x200001F")]
public interface IUIListObject : IUIObject, IEZDragDrop
{
	[Token(Token = "0x17000045")]
	Vector2 TopLeftEdge
	{
		[Token(Token = "0x6000191")]
		get;
	}

	[Token(Token = "0x17000046")]
	Vector2 BottomRightEdge
	{
		[Token(Token = "0x6000192")]
		get;
	}

	[Token(Token = "0x17000047")]
	bool Managed
	{
		[Token(Token = "0x6000194")]
		get;
	}

	[Token(Token = "0x17000048")]
	Rect3D ClippingRect
	{
		[Token(Token = "0x6000195")]
		get;
		[Token(Token = "0x6000196")]
		set;
	}

	[Token(Token = "0x17000049")]
	bool Clipped
	{
		[Token(Token = "0x6000197")]
		get;
		[Token(Token = "0x6000198")]
		set;
	}

	[Token(Token = "0x1700004A")]
	int Index
	{
		[Token(Token = "0x600019D")]
		get;
		[Token(Token = "0x600019E")]
		set;
	}

	[Token(Token = "0x1700004B")]
	string Text
	{
		[Token(Token = "0x600019F")]
		get;
		[Token(Token = "0x60001A0")]
		set;
	}

	[Token(Token = "0x1700004C")]
	SpriteText TextObj
	{
		[Token(Token = "0x60001A1")]
		get;
	}

	[Token(Token = "0x1700004D")]
	bool selected
	{
		[Token(Token = "0x60001A2")]
		get;
		[Token(Token = "0x60001A3")]
		set;
	}

	[Token(Token = "0x1700004E")]
	Camera RenderCamera
	{
		[Token(Token = "0x60001A5")]
		get;
		[Token(Token = "0x60001A6")]
		set;
	}

	[Token(Token = "0x600018F")]
	bool IsContainer();

	[Token(Token = "0x6000190")]
	void FindOuterEdges();

	[Token(Token = "0x6000193")]
	void Hide(bool tf);

	[Token(Token = "0x6000199")]
	void Unclip();

	[Token(Token = "0x600019A")]
	void UpdateCollider();

	[Token(Token = "0x600019B")]
	void SetList(UIScrollList c);

	[Token(Token = "0x600019C")]
	UIScrollList GetScrollList();

	[Token(Token = "0x60001A4")]
	void Delete();

	[Token(Token = "0x60001A7")]
	void UpdateCamera();
}
[Serializable]
[Token(Token = "0x2000020")]
public class PrefabListItem
{
	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject item;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string itemText;

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x1EEC580", Offset = "0x1EEB580", VA = "0x1EEC580")]
	public PrefabListItem()
	{
	}
}
[Token(Token = "0x2000021")]
[AddComponentMenu("EZ GUI/Controls/Scroll List")]
public class UIScrollList : MonoBehaviour, IUIObject, IEZDragDrop
{
	[Token(Token = "0x2000022")]
	public enum ORIENTATION
	{
		[Token(Token = "0x4000130")]
		HORIZONTAL,
		[Token(Token = "0x4000131")]
		VERTICAL
	}

	[Token(Token = "0x2000023")]
	public enum DIRECTION
	{
		[Token(Token = "0x4000133")]
		TtoB_LtoR,
		[Token(Token = "0x4000134")]
		BtoT_RtoL
	}

	[Token(Token = "0x2000024")]
	public enum ALIGNMENT
	{
		[Token(Token = "0x4000136")]
		LEFT_TOP,
		[Token(Token = "0x4000137")]
		CENTER,
		[Token(Token = "0x4000138")]
		RIGHT_BOTTOM
	}

	[Token(Token = "0x2000025")]
	protected delegate float ItemAlignmentDel(IUIListObject item);

	[Token(Token = "0x2000026")]
	protected delegate bool SnapCoordProc(float val);

	[Token(Token = "0x2000027")]
	public delegate void ItemSnappedDelegate(IUIListObject item);

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool touchScroll;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float scrollWheelFactor;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float scrollDecelCoef;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool snap;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float minSnapDuration;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public EZAnimation.EASING_TYPE snapEasing;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public UISlider slider;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ORIENTATION orientation;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public DIRECTION direction;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ALIGNMENT alignment;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public Vector2 viewableArea;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	protected Vector2 viewableAreaActual;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public bool unitsInPixels;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Camera renderCamera;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected Rect3D clientClippingRect;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float itemSpacing;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	protected float itemSpacingActual;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public bool spacingAtEnds;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public float extraEndSpacing;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected float extraEndSpacingActual;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public bool activateWhenAdding;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
	public bool clipContents;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB6")]
	public bool clipWhenMoving;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB7")]
	public bool positionItemsImmediately;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public float dragThreshold;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject[] sceneItems;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public PrefabListItem[] prefabItems;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public MonoBehaviour scriptWithMethodToInvoke;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public string methodToInvokeOnSelect;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public SpriteManager manager;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public bool detargetOnDisable;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public EZAnimation.EASING_TYPE positionEasing;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public float positionEaseDuration;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public float positionEaseDelay;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public bool blockInputWhileEasing;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
	protected bool doItemEasing;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFA")]
	protected bool doPosEasing;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	protected List<EZAnimation> itemEasers;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	protected EZAnimation scrollPosAnim;

	[NonSerialized]
	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[HideInInspector]
	public bool repositionOnEnable;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	protected float contentExtents;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	protected IUIListObject selectedItem;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	protected IUIObject lastClickedControl;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	protected float scrollPos;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	protected GameObject mover;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	protected List<IUIListObject> items;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	protected List<IUIListObject> visibleItems;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	protected List<IUIListObject> tempVisItems;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	protected bool m_controlIsEnabled;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	protected IUIContainer container;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	protected EZInputDelegate inputDelegate;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	protected EZValueChangedDelegate changeDelegate;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	protected ItemSnappedDelegate itemSnappedDel;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	protected Vector3 cachedPos;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
	protected Quaternion cachedRot;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
	protected Vector3 cachedScale;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	protected bool m_started;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A1")]
	protected bool m_awake;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	protected List<IUIListObject> newItems;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	protected bool itemsInserted;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B1")]
	protected bool isScrolling;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B2")]
	protected bool noTouch;

	[Token(Token = "0x4000115")]
	protected const float reboundSpeed = 1f;

	[Token(Token = "0x4000116")]
	protected const float overscrollAllowance = 0.5f;

	[Token(Token = "0x4000117")]
	protected const float lowPassKernelWidthInSeconds = 0.045f;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
	protected float lowPassFilterFactor;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private float scrollInertia;

	[Token(Token = "0x400011A")]
	protected const float backgroundColliderOffset = 0.01f;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
	protected float scrollMax;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private float scrollDelta;

	[Token(Token = "0x400011D")]
	private const float scrollStopThreshold = 0.0001f;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
	private float scrollStopThresholdLog;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private float lastTime;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
	private float timeDelta;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private float inertiaLerpInterval;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
	private float inertiaLerpTime;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private float amtOfPlay;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
	private float autoScrollDuration;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private float autoScrollStart;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
	private float autoScrollPos;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private float autoScrollDelta;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
	private float autoScrollTime;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private bool autoScrolling;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F1")]
	private bool listMoved;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private EZAnimation.Interpolator autoScrollInterpolator;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private IUIListObject snappedItem;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private float localUnitsPerPixel;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	protected EZDragDropDelegate dragDropDelegate;

	[Token(Token = "0x1700004F")]
	public float ScrollPosition
	{
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1EF1F6C", Offset = "0x1EF0F6C", VA = "0x1EF1F6C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1EF1F74", Offset = "0x1EF0F74", VA = "0x1EF1F74")]
		set
		{
		}
	}

	[Token(Token = "0x17000050")]
	public IUIListObject SnappedItem
	{
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x1EF1F88", Offset = "0x1EF0F88", VA = "0x1EF1F88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000051")]
	public float ContentExtents
	{
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x1EF6F78", Offset = "0x1EF5F78", VA = "0x1EF6F78")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000052")]
	public float UnviewableArea
	{
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1EF6F80", Offset = "0x1EF5F80", VA = "0x1EF6F80")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000053")]
	public IUIListObject SelectedItem
	{
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x1EF6F88", Offset = "0x1EF5F88", VA = "0x1EF6F88")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1EF6F90", Offset = "0x1EF5F90", VA = "0x1EF6F90")]
		set
		{
		}
	}

	[Token(Token = "0x17000054")]
	public IUIObject LastClickedControl
	{
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1EF70E8", Offset = "0x1EF60E8", VA = "0x1EF70E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000055")]
	public int Count
	{
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x1EF731C", Offset = "0x1EF631C", VA = "0x1EF731C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000056")]
	public bool controlIsEnabled
	{
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x1EF87D8", Offset = "0x1EF77D8", VA = "0x1EF87D8", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x1EF87E0", Offset = "0x1EF77E0", VA = "0x1EF87E0", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000057")]
	public virtual bool DetargetOnDisable
	{
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x1EF88FC", Offset = "0x1EF78FC", VA = "0x1EF88FC", Slot = "53")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x1EF890C", Offset = "0x1EF790C", VA = "0x1EF890C", Slot = "54")]
		set
		{
		}
	}

	[Token(Token = "0x17000058")]
	public virtual IUIContainer Container
	{
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x1EF8924", Offset = "0x1EF7924", VA = "0x1EF8924", Slot = "55")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1EF892C", Offset = "0x1EF792C", VA = "0x1EF892C", Slot = "56")]
		set
		{
		}
	}

	[Token(Token = "0x17000059")]
	public object Data
	{
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x1EF8E2C", Offset = "0x1EF7E2C", VA = "0x1EF8E2C", Slot = "24")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x1EF8E34", Offset = "0x1EF7E34", VA = "0x1EF8E34", Slot = "25")]
		set
		{
		}
	}

	[Token(Token = "0x1700005A")]
	public bool IsDraggable
	{
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x1EF8E38", Offset = "0x1EF7E38", VA = "0x1EF8E38", Slot = "26")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x1EF8E40", Offset = "0x1EF7E40", VA = "0x1EF8E40", Slot = "27")]
		set
		{
		}
	}

	[Token(Token = "0x1700005B")]
	public LayerMask DropMask
	{
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x1EF8E44", Offset = "0x1EF7E44", VA = "0x1EF8E44", Slot = "28")]
		get
		{
			return default(LayerMask);
		}
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x1EF8E60", Offset = "0x1EF7E60", VA = "0x1EF8E60", Slot = "29")]
		set
		{
		}
	}

	[Token(Token = "0x1700005C")]
	public float DragOffset
	{
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x1EF8E64", Offset = "0x1EF7E64", VA = "0x1EF8E64", Slot = "36")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x1EF8E6C", Offset = "0x1EF7E6C", VA = "0x1EF8E6C", Slot = "37")]
		set
		{
		}
	}

	[Token(Token = "0x1700005D")]
	public EZAnimation.EASING_TYPE CancelDragEasing
	{
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x1EF8E70", Offset = "0x1EF7E70", VA = "0x1EF8E70", Slot = "38")]
		get
		{
			return default(EZAnimation.EASING_TYPE);
		}
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x1EF8E78", Offset = "0x1EF7E78", VA = "0x1EF8E78", Slot = "39")]
		set
		{
		}
	}

	[Token(Token = "0x1700005E")]
	public float CancelDragDuration
	{
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x1EF8E7C", Offset = "0x1EF7E7C", VA = "0x1EF8E7C", Slot = "40")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x1EF8E84", Offset = "0x1EF7E84", VA = "0x1EF8E84", Slot = "41")]
		set
		{
		}
	}

	[Token(Token = "0x1700005F")]
	public bool IsDragging
	{
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x1EF8E88", Offset = "0x1EF7E88", VA = "0x1EF8E88", Slot = "30")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x1EF8E90", Offset = "0x1EF7E90", VA = "0x1EF8E90", Slot = "31")]
		set
		{
		}
	}

	[Token(Token = "0x17000060")]
	public GameObject DropTarget
	{
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1EF8E94", Offset = "0x1EF7E94", VA = "0x1EF8E94", Slot = "32")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x1EF8E9C", Offset = "0x1EF7E9C", VA = "0x1EF8E9C", Slot = "33")]
		set
		{
		}
	}

	[Token(Token = "0x17000061")]
	public bool DropHandled
	{
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1EF8EA0", Offset = "0x1EF7EA0", VA = "0x1EF8EA0", Slot = "34")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x1EF8EA8", Offset = "0x1EF7EA8", VA = "0x1EF8EA8", Slot = "35")]
		set
		{
		}
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x1EEC588", Offset = "0x1EEB588", VA = "0x1EEC588")]
	protected void Awake()
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x1EEC5E0", Offset = "0x1EEB5E0", VA = "0x1EEC5E0")]
	protected void Start()
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x1EED5D0", Offset = "0x1EEC5D0", VA = "0x1EED5D0")]
	public void UpdateCamera()
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x1EECCFC", Offset = "0x1EEBCFC", VA = "0x1EECCFC")]
	public void SetupCameraAndSizes()
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x1EED75C", Offset = "0x1EEC75C", VA = "0x1EED75C")]
	protected void CalcScreenToWorldUnits()
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x1EED0C0", Offset = "0x1EEC0C0", VA = "0x1EED0C0")]
	protected void CalcClippingRect()
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x1EED974", Offset = "0x1EEC974", VA = "0x1EED974")]
	public void SliderMoved(IUIObject slider)
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x1EEDD00", Offset = "0x1EECD00", VA = "0x1EEDD00")]
	public void SliderInputDel(ref POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x1EEDAB4", Offset = "0x1EECAB4", VA = "0x1EEDAB4")]
	protected void ScrollListTo_Internal(float pos)
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x1EF1F58", Offset = "0x1EF0F58", VA = "0x1EF1F58")]
	public void ScrollListTo(float pos)
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x1EF1F90", Offset = "0x1EF0F90", VA = "0x1EF1F90")]
	public void ScrollToItem(IUIListObject item, float scrollTime, EZAnimation.EASING_TYPE easing)
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x1EF2D4C", Offset = "0x1EF1D4C", VA = "0x1EF2D4C")]
	public void ScrollToItem(int index, float scrollTime, EZAnimation.EASING_TYPE easing)
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x1EF2E00", Offset = "0x1EF1E00", VA = "0x1EF2E00")]
	public void ScrollToItem(IUIListObject item, float scrollTime)
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x1EF2E08", Offset = "0x1EF1E08", VA = "0x1EF2E08")]
	public void ScrollToItem(int index, float scrollTime)
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x1EF2E10", Offset = "0x1EF1E10", VA = "0x1EF2E10")]
	public void SetViewableAreaPixelDimensions(Camera cam, int width, int height)
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x1EF3054", Offset = "0x1EF2054", VA = "0x1EF3054")]
	public void InsertItem(IUIListObject item, int position)
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x1EF3D38", Offset = "0x1EF2D38", VA = "0x1EF3D38")]
	public void InsertItem(IUIListObject item, int position, bool doEasing)
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x1EF3D44", Offset = "0x1EF2D44", VA = "0x1EF3D44")]
	public void InsertItem(IUIListObject item, int position, string text)
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x1EF3060", Offset = "0x1EF2060", VA = "0x1EF3060")]
	public void InsertItem(IUIListObject item, int position, string text, bool doEasing)
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x1EF2174", Offset = "0x1EF1174", VA = "0x1EF2174")]
	protected void PositionNewItems()
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x1EED34C", Offset = "0x1EEC34C", VA = "0x1EED34C")]
	public void AddItem(GameObject itemGO)
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x1EF408C", Offset = "0x1EF308C", VA = "0x1EF408C")]
	public void AddItem(IUIListObject item)
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x1EF4004", Offset = "0x1EF3004", VA = "0x1EF4004")]
	public void AddItem(IUIListObject item, string text)
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x1EF4094", Offset = "0x1EF3094", VA = "0x1EF4094")]
	public IUIListObject CreateItem(GameObject prefab)
	{
		return null;
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x1EED548", Offset = "0x1EEC548", VA = "0x1EED548")]
	public IUIListObject CreateItem(GameObject prefab, string text)
	{
		return null;
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x1EF4118", Offset = "0x1EF3118", VA = "0x1EF4118")]
	public IUIListObject CreateItem(GameObject prefab, int position, bool doEasing)
	{
		return null;
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x1EF4548", Offset = "0x1EF3548", VA = "0x1EF4548")]
	public IUIListObject CreateItem(GameObject prefab, int position)
	{
		return null;
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x1EF4110", Offset = "0x1EF3110", VA = "0x1EF4110")]
	public IUIListObject CreateItem(GameObject prefab, int position, string text)
	{
		return null;
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x1EF4124", Offset = "0x1EF3124", VA = "0x1EF4124")]
	public IUIListObject CreateItem(GameObject prefab, int position, string text, bool doEasing)
	{
		return null;
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x1EF3D4C", Offset = "0x1EF2D4C", VA = "0x1EF3D4C")]
	protected void UpdateContentExtents(float change)
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x1EF4554", Offset = "0x1EF3554", VA = "0x1EF4554")]
	protected float ScrollPosInterpolator(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x1EF463C", Offset = "0x1EF363C", VA = "0x1EF463C")]
	protected float GetYCentered(IUIListObject item)
	{
		return default(float);
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x1EF4644", Offset = "0x1EF3644", VA = "0x1EF4644")]
	protected float GetYAlignTop(IUIListObject item)
	{
		return default(float);
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x1EF4704", Offset = "0x1EF3704", VA = "0x1EF4704")]
	protected float GetYAlignBottom(IUIListObject item)
	{
		return default(float);
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x1EF47C4", Offset = "0x1EF37C4", VA = "0x1EF47C4")]
	protected float GetXCentered(IUIListObject item)
	{
		return default(float);
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x1EF47CC", Offset = "0x1EF37CC", VA = "0x1EF47CC")]
	protected float GetXAlignLeft(IUIListObject item)
	{
		return default(float);
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x1EF488C", Offset = "0x1EF388C", VA = "0x1EF488C")]
	protected float GetXAlignRight(IUIListObject item)
	{
		return default(float);
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x1EF494C", Offset = "0x1EF394C", VA = "0x1EF494C")]
	public void PositionItems()
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x1EED5F0", Offset = "0x1EEC5F0", VA = "0x1EED5F0")]
	public void RepositionItems()
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x1EF4AB8", Offset = "0x1EF3AB8", VA = "0x1EF4AB8")]
	protected void PositionHorizontally(bool updateExtents)
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x1EF5828", Offset = "0x1EF4828", VA = "0x1EF5828")]
	protected void PositionVertically(bool updateExtents)
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x1EF66A8", Offset = "0x1EF56A8", VA = "0x1EF66A8")]
	protected void OnPosEasingDone(EZAnimation anim)
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x1EEE424", Offset = "0x1EED424", VA = "0x1EEE424")]
	protected void ClipItems()
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x1EF6744", Offset = "0x1EF5744", VA = "0x1EF6744")]
	public void DidSelect(IUIListObject item)
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x1EF686C", Offset = "0x1EF586C", VA = "0x1EF686C")]
	public void DidClick(IUIObject item)
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x1EF6928", Offset = "0x1EF5928", VA = "0x1EF6928")]
	public void ListDragged(POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x1EF6D88", Offset = "0x1EF5D88", VA = "0x1EF6D88")]
	public void ScrollWheel(float amt)
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x1EF6DD8", Offset = "0x1EF5DD8", VA = "0x1EF6DD8")]
	public void PointerReleased()
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x1EF6E20", Offset = "0x1EF5E20", VA = "0x1EF6E20")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x1EF6E60", Offset = "0x1EF5E60", VA = "0x1EF6E60", Slot = "52")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x1EF70F0", Offset = "0x1EF60F0", VA = "0x1EF70F0")]
	public void SetSelectedItem(int index)
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x1EF7364", Offset = "0x1EF6364", VA = "0x1EF7364")]
	public IUIListObject GetItem(int index)
	{
		return null;
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x1EF73E8", Offset = "0x1EF63E8", VA = "0x1EF73E8")]
	public void RemoveItem(int index, bool destroy)
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x1EF73F4", Offset = "0x1EF63F4", VA = "0x1EF73F4")]
	public void RemoveItem(int index, bool destroy, bool doEasing)
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x1EF7A40", Offset = "0x1EF6A40", VA = "0x1EF7A40")]
	public void RemoveItem(IUIListObject item, bool destroy)
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x1EF7A4C", Offset = "0x1EF6A4C", VA = "0x1EF7A4C")]
	public void RemoveItem(IUIListObject item, bool destroy, bool doEasing)
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x1EF7B14", Offset = "0x1EF6B14", VA = "0x1EF7B14")]
	public void ClearList(bool destroy)
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x1EF7E90", Offset = "0x1EF6E90", VA = "0x1EF7E90", Slot = "17")]
	public void OnInput(POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x1EF81B0", Offset = "0x1EF71B0", VA = "0x1EF81B0")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x1EEDD30", Offset = "0x1EECD30", VA = "0x1EEDD30")]
	protected void CalcSnapItem()
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x1EF864C", Offset = "0x1EF764C", VA = "0x1EF864C")]
	protected void AddItemsToContainer()
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x1EF7D00", Offset = "0x1EF6D00", VA = "0x1EF7D00")]
	protected void RemoveItemsFromContainer()
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x1EF8920", Offset = "0x1EF7920", VA = "0x1EF8920", Slot = "8")]
	public IUIObject GetControl(ref POINTER_INFO ptr)
	{
		return null;
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x1EF8978", Offset = "0x1EF7978", VA = "0x1EF8978", Slot = "15")]
	public bool RequestContainership(IUIContainer cont)
	{
		return default(bool);
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x1EF8B14", Offset = "0x1EF7B14", VA = "0x1EF8B14", Slot = "16")]
	public bool GotFocus()
	{
		return default(bool);
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x1EF8B1C", Offset = "0x1EF7B1C", VA = "0x1EF8B1C", Slot = "18")]
	public void SetInputDelegate(EZInputDelegate del)
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x1EF8B24", Offset = "0x1EF7B24", VA = "0x1EF8B24", Slot = "19")]
	public void AddInputDelegate(EZInputDelegate del)
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x1EF8BA4", Offset = "0x1EF7BA4", VA = "0x1EF8BA4", Slot = "20")]
	public void RemoveInputDelegate(EZInputDelegate del)
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x1EF8C24", Offset = "0x1EF7C24", VA = "0x1EF8C24", Slot = "21")]
	public void SetValueChangedDelegate(EZValueChangedDelegate del)
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x1EF8C2C", Offset = "0x1EF7C2C", VA = "0x1EF8C2C", Slot = "22")]
	public void AddValueChangedDelegate(EZValueChangedDelegate del)
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x1EF8CAC", Offset = "0x1EF7CAC", VA = "0x1EF8CAC", Slot = "23")]
	public void RemoveValueChangedDelegate(EZValueChangedDelegate del)
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x1EF8D2C", Offset = "0x1EF7D2C", VA = "0x1EF8D2C")]
	public void AddItemSnappedDelegate(ItemSnappedDelegate del)
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x1EF8DAC", Offset = "0x1EF7DAC", VA = "0x1EF8DAC")]
	public void RemoveItemSnappedDelegate(ItemSnappedDelegate del)
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x1EF8EAC", Offset = "0x1EF7EAC", VA = "0x1EF8EAC", Slot = "42")]
	public void DragUpdatePosition(POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x1EF8EB0", Offset = "0x1EF7EB0", VA = "0x1EF8EB0", Slot = "43")]
	public void CancelDrag()
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x1EF8EB4", Offset = "0x1EF7EB4", VA = "0x1EF8EB4", Slot = "44")]
	public void OnEZDragDrop_Internal(EZDragDropParams parms)
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x1EF8F14", Offset = "0x1EF7F14", VA = "0x1EF8F14", Slot = "45")]
	public void AddDragDropDelegate(EZDragDropDelegate del)
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x1EF8F94", Offset = "0x1EF7F94", VA = "0x1EF8F94", Slot = "46")]
	public void RemoveDragDropDelegate(EZDragDropDelegate del)
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x1EF9014", Offset = "0x1EF8014", VA = "0x1EF9014", Slot = "47")]
	public void SetDragDropDelegate(EZDragDropDelegate del)
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x1EF901C", Offset = "0x1EF801C", VA = "0x1EF901C", Slot = "48")]
	public void SetDragDropInternalDelegate(EZDragDropHelper.DragDrop_InternalDelegate del)
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x1EF9020", Offset = "0x1EF8020", VA = "0x1EF9020", Slot = "49")]
	public void AddDragDropInternalDelegate(EZDragDropHelper.DragDrop_InternalDelegate del)
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x1EF9024", Offset = "0x1EF8024", VA = "0x1EF9024", Slot = "50")]
	public void RemoveDragDropInternalDelegate(EZDragDropHelper.DragDrop_InternalDelegate del)
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x1EF9028", Offset = "0x1EF8028", VA = "0x1EF9028", Slot = "51")]
	public EZDragDropHelper.DragDrop_InternalDelegate GetDragDropInternalDelegate()
	{
		return null;
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x1EF9030", Offset = "0x1EF8030", VA = "0x1EF9030")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x1EF9784", Offset = "0x1EF8784", VA = "0x1EF9784")]
	public static UIScrollList Create(string name, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x1EF98C4", Offset = "0x1EF88C4", VA = "0x1EF98C4")]
	public static UIScrollList Create(string name, Vector3 pos, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x1EF9A4C", Offset = "0x1EF8A4C", VA = "0x1EF9A4C")]
	public void DrawPreTransitionUI(int selState, IGUIScriptSelector gui)
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x1EF9B00", Offset = "0x1EF8B00", VA = "0x1EF9B00")]
	public UIScrollList()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x1EF9CC8", Offset = "0x1EF8CC8", VA = "0x1EF9CC8", Slot = "11")]
	private GameObject IUIObject.get_gameObject()
	{
		return null;
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x1EF9CD0", Offset = "0x1EF8CD0", VA = "0x1EF9CD0", Slot = "12")]
	private Transform IUIObject.get_transform()
	{
		return null;
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x1EF9CD8", Offset = "0x1EF8CD8", VA = "0x1EF9CD8", Slot = "14")]
	private string IUIObject.get_name()
	{
		return null;
	}
}
[Token(Token = "0x2000028")]
[AddComponentMenu("EZ GUI/Controls/Slider")]
public class UISlider : AutoSpriteControlBase
{
	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x314")]
	protected float m_value;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
	public MonoBehaviour scriptWithMethodToInvoke;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
	public string methodToInvoke;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
	public float defaultValue;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32C")]
	public float stopKnobFromEdge;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
	public Vector3 knobOffset;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33C")]
	public Vector2 knobSize;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x344")]
	public Vector2 knobColliderSizeFactor;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
	protected AutoSprite emptySprite;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
	protected UIScrollKnob knob;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
	[HideInInspector]
	public TextureAnim[] states;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
	[HideInInspector]
	public EZTransitionList[] transitions;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
	public SpriteRoot[] filledLayers;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
	public SpriteRoot[] emptyLayers;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
	public SpriteRoot[] knobLayers;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
	protected float truncFloor;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38C")]
	protected float truncRange;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
	protected int[] filledIndices;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
	protected int[] emptyIndices;

	[Token(Token = "0x17000062")]
	public override bool controlIsEnabled
	{
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1EF9FC8", Offset = "0x1EF8FC8", VA = "0x1EF9FC8", Slot = "166")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x1EF9FD0", Offset = "0x1EF8FD0", VA = "0x1EF9FD0", Slot = "167")]
		set
		{
		}
	}

	[Token(Token = "0x17000063")]
	public float Value
	{
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x1EFA08C", Offset = "0x1EF908C", VA = "0x1EFA08C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x1EEDA88", Offset = "0x1EECA88", VA = "0x1EEDA88")]
		set
		{
		}
	}

	[Token(Token = "0x17000064")]
	public override TextureAnim[] States
	{
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1EFA194", Offset = "0x1EF9194", VA = "0x1EFA194", Slot = "79")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1EFA19C", Offset = "0x1EF919C", VA = "0x1EFA19C", Slot = "80")]
		set
		{
		}
	}

	[Token(Token = "0x17000065")]
	public override EZTransitionList[] Transitions
	{
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1EFA1E0", Offset = "0x1EF91E0", VA = "0x1EFA1E0", Slot = "186")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x1EFA1E8", Offset = "0x1EF91E8", VA = "0x1EFA1E8", Slot = "187")]
		set
		{
		}
	}

	[Token(Token = "0x17000066")]
	public override IUIContainer Container
	{
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1EFBE0C", Offset = "0x1EFAE0C", VA = "0x1EFBE0C", Slot = "170")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1EFBE14", Offset = "0x1EFAE14", VA = "0x1EFBE14", Slot = "171")]
		set
		{
		}
	}

	[Token(Token = "0x17000067")]
	public override bool Clipped
	{
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1EFC120", Offset = "0x1EFB120", VA = "0x1EFC120", Slot = "42")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x1EFC128", Offset = "0x1EFB128", VA = "0x1EFC128", Slot = "43")]
		set
		{
		}
	}

	[Token(Token = "0x17000068")]
	public override Rect3D ClippingRect
	{
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x1EFC1A0", Offset = "0x1EFB1A0", VA = "0x1EFC1A0", Slot = "40")]
		get
		{
			return default(Rect3D);
		}
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x1EFC1E0", Offset = "0x1EFB1E0", VA = "0x1EFC1E0", Slot = "41")]
		set
		{
		}
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x1EFA1A4", Offset = "0x1EF91A4", VA = "0x1EFA1A4", Slot = "185")]
	public override EZTransitionList GetTransitions(int index)
	{
		return null;
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x1EFA1F0", Offset = "0x1EF91F0", VA = "0x1EFA1F0", Slot = "12")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x1EFA210", Offset = "0x1EF9210", VA = "0x1EFA210", Slot = "13")]
	public override void Start()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x1EFB690", Offset = "0x1EFA690", VA = "0x1EFB690", Slot = "22")]
	public override void SetSize(float width, float height)
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x1EFB78C", Offset = "0x1EFA78C", VA = "0x1EFB78C", Slot = "16")]
	public override void Copy(SpriteRoot s)
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x1EFB7A0", Offset = "0x1EFA7A0", VA = "0x1EFB7A0", Slot = "160")]
	public override void Copy(SpriteRoot s, ControlCopyFlags flags)
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x1EFB570", Offset = "0x1EFA570", VA = "0x1EFB570")]
	protected Vector3 CalcKnobStartPos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x1EFB9A4", Offset = "0x1EFA9A4", VA = "0x1EFB9A4", Slot = "17")]
	public override void InitUVs()
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x1EFA094", Offset = "0x1EF9094", VA = "0x1EFA094")]
	protected void UpdateValue()
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x1EFBB58", Offset = "0x1EFAB58", VA = "0x1EFBB58")]
	public void ScrollKnobMoved(UIScrollKnob knob, float val)
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x1EFBC2C", Offset = "0x1EFAC2C", VA = "0x1EFBC2C", Slot = "173")]
	public override void SetInputDelegate(EZInputDelegate del)
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x1EFBCC4", Offset = "0x1EFACC4", VA = "0x1EFBCC4", Slot = "174")]
	public override void AddInputDelegate(EZInputDelegate del)
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x1EFBD64", Offset = "0x1EFAD64", VA = "0x1EFBD64", Slot = "175")]
	public override void RemoveInputDelegate(EZInputDelegate del)
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x1EFBA00", Offset = "0x1EFAA00", VA = "0x1EFBA00")]
	protected void UpdateAppearance(float truncVal)
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x1EFBE04", Offset = "0x1EFAE04", VA = "0x1EFBE04")]
	public UIScrollKnob GetKnob()
	{
		return null;
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x1EFC0C8", Offset = "0x1EFB0C8", VA = "0x1EFC0C8", Slot = "28")]
	public override void Unclip()
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x1EFC2CC", Offset = "0x1EFB2CC", VA = "0x1EFC2CC")]
	public static UISlider Create(string name, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x1EFC40C", Offset = "0x1EFB40C", VA = "0x1EFC40C")]
	public static UISlider Create(string name, Vector3 pos, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x1EFC594", Offset = "0x1EFB594", VA = "0x1EFC594", Slot = "37")]
	public override void Hide(bool tf)
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x1EFC688", Offset = "0x1EFB688", VA = "0x1EFC688", Slot = "30")]
	public override void SetColor(Color c)
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x1EFC7B8", Offset = "0x1EFB7B8", VA = "0x1EFC7B8", Slot = "183")]
	public override void DrawPreTransitionUI(int selState, IGUIScriptSelector gui)
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x1EFC86C", Offset = "0x1EFB86C", VA = "0x1EFC86C")]
	public UISlider()
	{
	}
}
[Token(Token = "0x2000029")]
[AddComponentMenu("EZ GUI/Controls/Toggle Button")]
public class UIStateToggleBtn : AutoSpriteControlBase
{
	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x314")]
	protected int curStateIndex;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
	protected bool stateChangeWhileDeactivated;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31C")]
	public int defaultState;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
	public bool ignoreClicks;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
	[HideInInspector]
	public TextureAnim[] states;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
	[HideInInspector]
	public string[] stateLabels;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
	[HideInInspector]
	public EZTransitionList[] transitions;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
	private EZTransition prevTransition;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
	public SpriteRoot[] layers;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
	public MonoBehaviour scriptWithMethodToInvoke;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
	public string methodToInvoke;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
	public POINTER_INFO.INPUT_EVENT whenToInvoke;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x364")]
	public float delay;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
	public AudioSource soundToPlay;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
	public bool disableHoverEffect;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
	protected int[,] stateIndices;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
	protected int overLayerState;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x384")]
	protected int activeLayerState;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
	protected int layerState;

	[Token(Token = "0x17000069")]
	public override bool controlIsEnabled
	{
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1F0B5CC", Offset = "0x1F0A5CC", VA = "0x1F0B5CC", Slot = "166")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1F0B5D4", Offset = "0x1F0A5D4", VA = "0x1F0B5D4", Slot = "167")]
		set
		{
		}
	}

	[Token(Token = "0x1700006A")]
	public int StateNum
	{
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1F0B794", Offset = "0x1F0A794", VA = "0x1F0B794")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700006B")]
	public string StateName
	{
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1F0B79C", Offset = "0x1F0A79C", VA = "0x1F0B79C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700006C")]
	public override TextureAnim[] States
	{
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x1F0B7D8", Offset = "0x1F0A7D8", VA = "0x1F0B7D8", Slot = "79")]
		get
		{
			return null;
		}
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1F0B7E0", Offset = "0x1F0A7E0", VA = "0x1F0B7E0", Slot = "80")]
		set
		{
		}
	}

	[Token(Token = "0x1700006D")]
	public override EZTransitionList[] Transitions
	{
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1F0B89C", Offset = "0x1F0A89C", VA = "0x1F0B89C", Slot = "186")]
		get
		{
			return null;
		}
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1F0B8A4", Offset = "0x1F0A8A4", VA = "0x1F0B8A4", Slot = "187")]
		set
		{
		}
	}

	[Token(Token = "0x1700006E")]
	public override CSpriteFrame DefaultFrame
	{
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1F0B8AC", Offset = "0x1F0A8AC", VA = "0x1F0B8AC", Slot = "81")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700006F")]
	public override TextureAnim DefaultState
	{
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x1F0B954", Offset = "0x1F0A954", VA = "0x1F0B954", Slot = "82")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000070")]
	public override string Text
	{
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x1F0C8D8", Offset = "0x1F0B8D8", VA = "0x1F0C8D8", Slot = "156")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1F0C8E0", Offset = "0x1F0B8E0", VA = "0x1F0C8E0", Slot = "157")]
		set
		{
		}
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x1F0B7E8", Offset = "0x1F0A7E8", VA = "0x1F0B7E8", Slot = "188")]
	public override string GetStateLabel(int index)
	{
		return null;
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x1F0B818", Offset = "0x1F0A818", VA = "0x1F0B818", Slot = "189")]
	public override void SetStateLabel(int index, string label)
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x1F0B860", Offset = "0x1F0A860", VA = "0x1F0B860", Slot = "185")]
	public override EZTransitionList GetTransitions(int index)
	{
		return null;
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x1F0B998", Offset = "0x1F0A998", VA = "0x1F0B998", Slot = "180")]
	public override void OnInput(ref POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x1F0BD30", Offset = "0x1F0AD30", VA = "0x1F0BD30", Slot = "12")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x1F0BD50", Offset = "0x1F0AD50", VA = "0x1F0BD50", Slot = "13")]
	public override void Start()
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x1F0C408", Offset = "0x1F0B408", VA = "0x1F0C408", Slot = "16")]
	public override void Copy(SpriteRoot s)
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x1F0C41C", Offset = "0x1F0B41C", VA = "0x1F0C41C", Slot = "160")]
	public override void Copy(SpriteRoot s, ControlCopyFlags flags)
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x1F0BBD4", Offset = "0x1F0ABD4", VA = "0x1F0BBD4")]
	public int ToggleState()
	{
		return default(int);
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x1F0C548", Offset = "0x1F0B548", VA = "0x1F0C548", Slot = "191")]
	public virtual void SetToggleState(int s, bool suppressTransition)
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x1F0C7D0", Offset = "0x1F0B7D0", VA = "0x1F0C7D0", Slot = "192")]
	public virtual void SetToggleState(int s)
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x1F0C7E4", Offset = "0x1F0B7E4", VA = "0x1F0C7E4", Slot = "193")]
	public virtual void SetToggleState(string stateName, bool suppressTransition)
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x1F0C888", Offset = "0x1F0B888", VA = "0x1F0C888", Slot = "194")]
	public virtual void SetToggleState(string stateName)
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x1F0BC00", Offset = "0x1F0AC00", VA = "0x1F0BC00")]
	protected void SetLayerState(int s)
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x1F0B5F8", Offset = "0x1F0A5F8", VA = "0x1F0B5F8")]
	protected void DisableMe()
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x1F0C89C", Offset = "0x1F0B89C", VA = "0x1F0C89C", Slot = "19")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x1F0CA6C", Offset = "0x1F0BA6C", VA = "0x1F0CA6C", Slot = "17")]
	public override void InitUVs()
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x1F0CAE0", Offset = "0x1F0BAE0", VA = "0x1F0CAE0", Slot = "181")]
	public override int DrawPreStateSelectGUI(int selState, bool inspector)
	{
		return default(int);
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x1F0D2A8", Offset = "0x1F0C2A8", VA = "0x1F0D2A8", Slot = "182")]
	public override int DrawPostStateSelectGUI(int selState)
	{
		return default(int);
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x1F0D4CC", Offset = "0x1F0C4CC", VA = "0x1F0D4CC", Slot = "183")]
	public override void DrawPreTransitionUI(int selState, IGUIScriptSelector gui)
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x1F0D580", Offset = "0x1F0C580", VA = "0x1F0D580")]
	public static UIStateToggleBtn Create(string name, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x1F0D6C0", Offset = "0x1F0C6C0", VA = "0x1F0D6C0")]
	public static UIStateToggleBtn Create(string name, Vector3 pos, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x1F0D848", Offset = "0x1F0C848", VA = "0x1F0D848")]
	public UIStateToggleBtn()
	{
	}
}
[Token(Token = "0x200002A")]
[AddComponentMenu("EZ GUI/Controls/3D Toggle Button")]
public class UIStateToggleBtn3D : ControlBase
{
	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	protected int curStateIndex;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public int defaultState;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	public string[] states;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[HideInInspector]
	public EZTransitionList[] transitions;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private EZTransition prevTransition;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[HideInInspector]
	public string[] stateLabels;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public MonoBehaviour scriptWithMethodToInvoke;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public string methodToInvoke;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public POINTER_INFO.INPUT_EVENT whenToInvoke;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public float delay;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public AudioSource soundToPlay;

	[Token(Token = "0x17000071")]
	public override bool controlIsEnabled
	{
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1F0DC04", Offset = "0x1F0CC04", VA = "0x1F0DC04", Slot = "79")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1F0DC0C", Offset = "0x1F0CC0C", VA = "0x1F0DC0C", Slot = "80")]
		set
		{
		}
	}

	[Token(Token = "0x17000072")]
	public int StateNum
	{
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1F0DD08", Offset = "0x1F0CD08", VA = "0x1F0DD08")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000073")]
	public string StateName
	{
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1F0DD10", Offset = "0x1F0CD10", VA = "0x1F0DD10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000074")]
	public override string[] States
	{
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1F0DD44", Offset = "0x1F0CD44", VA = "0x1F0DD44", Slot = "99")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000075")]
	public override EZTransitionList[] Transitions
	{
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1F0DD88", Offset = "0x1F0CD88", VA = "0x1F0DD88", Slot = "105")]
		get
		{
			return null;
		}
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1F0DD90", Offset = "0x1F0CD90", VA = "0x1F0DD90", Slot = "106")]
		set
		{
		}
	}

	[Token(Token = "0x17000076")]
	public override string Text
	{
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1F0E42C", Offset = "0x1F0D42C", VA = "0x1F0E42C", Slot = "71")]
		get
		{
			return null;
		}
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1F0E434", Offset = "0x1F0D434", VA = "0x1F0E434", Slot = "72")]
		set
		{
		}
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x1F0DD4C", Offset = "0x1F0CD4C", VA = "0x1F0DD4C", Slot = "104")]
	public override EZTransitionList GetTransitions(int index)
	{
		return null;
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x1F0DD98", Offset = "0x1F0CD98", VA = "0x1F0DD98", Slot = "107")]
	public override string GetStateLabel(int index)
	{
		return null;
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x1F0DDC8", Offset = "0x1F0CDC8", VA = "0x1F0DDC8", Slot = "108")]
	public override void SetStateLabel(int index, string label)
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x1F0DE10", Offset = "0x1F0CE10", VA = "0x1F0DE10", Slot = "93")]
	public override void OnInput(ref POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x1F0DFA4", Offset = "0x1F0CFA4", VA = "0x1F0DFA4", Slot = "75")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x1F0DFC4", Offset = "0x1F0CFC4", VA = "0x1F0DFC4", Slot = "76")]
	public override void Start()
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x1F0E1A4", Offset = "0x1F0D1A4", VA = "0x1F0E1A4", Slot = "97")]
	public override void Copy(IControl c)
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x1F0E1B8", Offset = "0x1F0D1B8", VA = "0x1F0E1B8", Slot = "98")]
	public override void Copy(IControl c, ControlCopyFlags flags)
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x1F0DF5C", Offset = "0x1F0CF5C", VA = "0x1F0DF5C")]
	public int ToggleState()
	{
		return default(int);
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x1F0E2D8", Offset = "0x1F0D2D8", VA = "0x1F0E2D8", Slot = "112")]
	public virtual void SetToggleState(int s)
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x1F0E3A4", Offset = "0x1F0D3A4", VA = "0x1F0E3A4", Slot = "113")]
	public virtual void SetToggleState(string stateName)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x1F0DC30", Offset = "0x1F0CC30", VA = "0x1F0DC30")]
	protected void DisableMe()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x1F0E5C0", Offset = "0x1F0D5C0", VA = "0x1F0E5C0", Slot = "100")]
	public override int DrawPreStateSelectGUI(int selState, bool inspector)
	{
		return default(int);
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x1F0ECEC", Offset = "0x1F0DCEC", VA = "0x1F0ECEC", Slot = "101")]
	public override int DrawPostStateSelectGUI(int selState)
	{
		return default(int);
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x1F0EEB4", Offset = "0x1F0DEB4", VA = "0x1F0EEB4", Slot = "102")]
	public override void DrawPreTransitionUI(int selState, IGUIScriptSelector gui)
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x1F0EF68", Offset = "0x1F0DF68", VA = "0x1F0EF68")]
	public static UIStateToggleBtn3D Create(string name, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x1F0F0A8", Offset = "0x1F0E0A8", VA = "0x1F0F0A8")]
	public static UIStateToggleBtn3D Create(string name, Vector3 pos, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x1F0F230", Offset = "0x1F0E230", VA = "0x1F0F230")]
	public UIStateToggleBtn3D()
	{
	}
}
[Token(Token = "0x200002B")]
[AddComponentMenu("EZ GUI/Controls/Text Field")]
public class UITextField : AutoSpriteControlBase, IKeyFocusable
{
	[Token(Token = "0x200002C")]
	public delegate void FocusDelegate(UITextField field);

	[Token(Token = "0x200002D")]
	public delegate string ValidationDelegate(UITextField field, string text, ref int insertionPoint);

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
	[HideInInspector]
	public TextureAnim[] states;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
	[HideInInspector]
	public EZTransitionList[] transitions;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
	public Vector2 margins;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
	protected Rect3D clientClippingRect;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
	protected Vector2 marginTopLeft;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
	protected Vector2 marginBottomRight;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
	public int maxLength;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x37C")]
	public bool multiline;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x37D")]
	public bool loseFocusOnReturn;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x37E")]
	public bool password;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
	public string maskingCharacter;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
	public Vector2 caretSize;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
	public ANCHOR_METHOD caretAnchor;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x394")]
	public Vector3 caretOffset;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
	public bool showCaretOnMobile;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A1")]
	public bool allowClickCaretPlacement;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A2")]
	protected bool maxLengthExceeded;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A4")]
	public TouchScreenKeyboardType type;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
	public bool autoCorrect;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A9")]
	public bool alert;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3AA")]
	public bool hideInput;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
	public MonoBehaviour scriptWithMethodToInvoke;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
	public string methodToInvoke;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
	protected EZKeyboardCommitDelegate commitDelegate;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
	protected ValidationDelegate validationDelegate;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
	public AudioSource typingSoundEffect;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
	public AudioSource fieldFullSound;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
	public bool customKeyboard;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E1")]
	public bool commitOnLostFocus;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E4")]
	public POINTER_INFO.INPUT_EVENT customFocusEvent;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
	protected AutoSprite caret;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
	protected FocusDelegate focusDelegate;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
	protected int insert;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3FC")]
	protected Vector3 cachedPos;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
	protected Quaternion cachedRot;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
	protected Vector3 cachedScale;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x424")]
	protected bool hasFocus;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
	protected Vector3 origTextPos;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
	protected int[,] stateIndices;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
	private bool resetUpon;

	[Token(Token = "0x17000077")]
	public override bool controlIsEnabled
	{
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x1F0F544", Offset = "0x1F0E544", VA = "0x1F0F544", Slot = "166")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x1F0F54C", Offset = "0x1F0E54C", VA = "0x1F0F54C", Slot = "167")]
		set
		{
		}
	}

	[Token(Token = "0x17000078")]
	public override TextureAnim[] States
	{
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1F0F558", Offset = "0x1F0E558", VA = "0x1F0F558", Slot = "79")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x1F0F560", Offset = "0x1F0E560", VA = "0x1F0F560", Slot = "80")]
		set
		{
		}
	}

	[Token(Token = "0x17000079")]
	public override EZTransitionList[] Transitions
	{
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x1F0F5A4", Offset = "0x1F0E5A4", VA = "0x1F0F5A4", Slot = "186")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x1F0F5AC", Offset = "0x1F0E5AC", VA = "0x1F0F5AC", Slot = "187")]
		set
		{
		}
	}

	[Token(Token = "0x1700007A")]
	public string Content
	{
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x1F10914", Offset = "0x1F0F914", VA = "0x1F10914", Slot = "198")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700007B")]
	public bool MaxLengthExceeded
	{
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1F12954", Offset = "0x1F11954", VA = "0x1F12954")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700007C")]
	public override IUIContainer Container
	{
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1F1295C", Offset = "0x1F1195C", VA = "0x1F1295C", Slot = "170")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1F12964", Offset = "0x1F11964", VA = "0x1F12964", Slot = "171")]
		set
		{
		}
	}

	[Token(Token = "0x1700007D")]
	public bool resetUponLoading
	{
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x1F12B34", Offset = "0x1F11B34", VA = "0x1F12B34", Slot = "191")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1F12B3C", Offset = "0x1F11B3C", VA = "0x1F12B3C", Slot = "192")]
		set
		{
		}
	}

	[Token(Token = "0x1700007E")]
	public override string Text
	{
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x1F12B48", Offset = "0x1F11B48", VA = "0x1F12B48", Slot = "156")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x1F12B50", Offset = "0x1F11B50", VA = "0x1F12B50", Slot = "157")]
		set
		{
		}
	}

	[Token(Token = "0x1700007F")]
	public override Rect3D ClippingRect
	{
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1F131F0", Offset = "0x1F121F0", VA = "0x1F131F0", Slot = "40")]
		get
		{
			return default(Rect3D);
		}
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x1F13230", Offset = "0x1F12230", VA = "0x1F13230", Slot = "41")]
		set
		{
		}
	}

	[Token(Token = "0x17000080")]
	public override bool Clipped
	{
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x1F1327C", Offset = "0x1F1227C", VA = "0x1F1327C", Slot = "42")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x1F13284", Offset = "0x1F12284", VA = "0x1F13284", Slot = "43")]
		set
		{
		}
	}

	[Token(Token = "0x17000081")]
	public bool Password
	{
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x1F132B4", Offset = "0x1F122B4", VA = "0x1F132B4", Slot = "199")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x1F132BC", Offset = "0x1F122BC", VA = "0x1F132BC")]
		set
		{
		}
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x1F0F568", Offset = "0x1F0E568", VA = "0x1F0F568", Slot = "185")]
	public override EZTransitionList GetTransitions(int index)
	{
		return null;
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x1F0F5B4", Offset = "0x1F0E5B4", VA = "0x1F0F5B4", Slot = "180")]
	public override void OnInput(ref POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x1F0F658", Offset = "0x1F0E658", VA = "0x1F0F658", Slot = "16")]
	public override void Copy(SpriteRoot s)
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x1F0F66C", Offset = "0x1F0E66C", VA = "0x1F0F66C", Slot = "160")]
	public override void Copy(SpriteRoot s, ControlCopyFlags flags)
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x1F0F9D4", Offset = "0x1F0E9D4", VA = "0x1F0F9D4")]
	public bool HasFocus()
	{
		return default(bool);
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x1F0F9DC", Offset = "0x1F0E9DC", VA = "0x1F0F9DC", Slot = "172")]
	public override bool GotFocus()
	{
		return default(bool);
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x1F0F9EC", Offset = "0x1F0E9EC", VA = "0x1F0F9EC", Slot = "195")]
	public string GetInputText(ref KEYBOARD_INFO info)
	{
		return null;
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x1F0FB54", Offset = "0x1F0EB54", VA = "0x1F0FB54", Slot = "194")]
	public string SetInputText(string inputText, ref int insertPt)
	{
		return null;
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x1F107F8", Offset = "0x1F0F7F8", VA = "0x1F107F8", Slot = "193")]
	public void LostFocus()
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x1F10740", Offset = "0x1F0F740", VA = "0x1F10740", Slot = "196")]
	public void Commit()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x1F0FA3C", Offset = "0x1F0EA3C", VA = "0x1F0FA3C")]
	protected void ShowCaret()
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x1F10B28", Offset = "0x1F0FB28", VA = "0x1F10B28", Slot = "37")]
	public override void Hide(bool tf)
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x1F10844", Offset = "0x1F0F844", VA = "0x1F10844")]
	protected void HideCaret()
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x1F10C10", Offset = "0x1F0FC10", VA = "0x1F10C10")]
	protected void PositionText(bool recur)
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x1F10730", Offset = "0x1F0F730", VA = "0x1F10730")]
	protected void PositionCaret()
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x1F110EC", Offset = "0x1F100EC", VA = "0x1F110EC")]
	protected void PositionCaret(bool recur)
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x1F117B0", Offset = "0x1F107B0", VA = "0x1F117B0")]
	protected void PositionInsertionPoint(Vector3 pt)
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x1F118C0", Offset = "0x1F108C0", VA = "0x1F118C0", Slot = "200")]
	public void GoUp()
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x1F119DC", Offset = "0x1F109DC", VA = "0x1F119DC", Slot = "201")]
	public void GoDown()
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x1F11AF8", Offset = "0x1F10AF8", VA = "0x1F11AF8", Slot = "197")]
	public void SetCommitDelegate(EZKeyboardCommitDelegate del)
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x1F11B00", Offset = "0x1F10B00", VA = "0x1F11B00")]
	public void AddCommitDelegate(EZKeyboardCommitDelegate del)
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x1F11B80", Offset = "0x1F10B80", VA = "0x1F11B80")]
	public void RemoveCommitDelegate(EZKeyboardCommitDelegate del)
	{
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x1F11C00", Offset = "0x1F10C00", VA = "0x1F11C00")]
	public void SetFocusDelegate(FocusDelegate del)
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x1F11C08", Offset = "0x1F10C08", VA = "0x1F11C08")]
	public void AddFocusDelegate(FocusDelegate del)
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x1F11C88", Offset = "0x1F10C88", VA = "0x1F11C88")]
	public void RemoveFocusDelegate(FocusDelegate del)
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x1F11D08", Offset = "0x1F10D08", VA = "0x1F11D08")]
	public void SetValidationDelegate(ValidationDelegate del)
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x1F11D10", Offset = "0x1F10D10", VA = "0x1F11D10")]
	public void AddValidationDelegate(ValidationDelegate del)
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x1F11D90", Offset = "0x1F10D90", VA = "0x1F11D90")]
	public void RemoveValidationDelegate(ValidationDelegate del)
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x1F11E10", Offset = "0x1F10E10", VA = "0x1F11E10", Slot = "12")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x1F11E30", Offset = "0x1F10E30", VA = "0x1F11E30", Slot = "13")]
	public override void Start()
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x1F1215C", Offset = "0x1F1115C", VA = "0x1F1215C")]
	protected void CreateCaret()
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x1F10924", Offset = "0x1F0F924", VA = "0x1F10924")]
	public void CalcClippingRect()
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x1F128EC", Offset = "0x1F118EC", VA = "0x1F128EC")]
	public void OnEZTranslated()
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x1F128F0", Offset = "0x1F118F0", VA = "0x1F128F0")]
	public void OnEZRotated()
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x1F128F4", Offset = "0x1F118F4", VA = "0x1F128F4")]
	public void OnEZScaled()
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x1F0F830", Offset = "0x1F0E830", VA = "0x1F0F830")]
	public void SetMargins(Vector2 marg)
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x1F128F8", Offset = "0x1F118F8", VA = "0x1F128F8", Slot = "17")]
	public override void InitUVs()
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x1F12EFC", Offset = "0x1F11EFC", VA = "0x1F12EFC")]
	public static UITextField Create(string name, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x1F1303C", Offset = "0x1F1203C", VA = "0x1F1303C")]
	public static UITextField Create(string name, Vector3 pos, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x1F131C4", Offset = "0x1F121C4", VA = "0x1F131C4", Slot = "28")]
	public override void Unclip()
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x1F132E4", Offset = "0x1F122E4", VA = "0x1F132E4", Slot = "183")]
	public override void DrawPreTransitionUI(int selState, IGUIScriptSelector gui)
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x1F13398", Offset = "0x1F12398", VA = "0x1F13398", Slot = "49")]
	public override void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x1F1344C", Offset = "0x1F1244C", VA = "0x1F1344C", Slot = "48")]
	public override void DoMirror()
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x1F13594", Offset = "0x1F12594", VA = "0x1F13594")]
	public UITextField()
	{
	}
}
[Token(Token = "0x200002E")]
public class UITextFieldMirror : AutoSpriteControlBaseMirror
{
	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public Vector2 margins;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public bool multiline;

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x1F13B58", Offset = "0x1F12B58", VA = "0x1F13B58", Slot = "4")]
	public override void Mirror(SpriteRoot s)
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x1F13BF8", Offset = "0x1F12BF8", VA = "0x1F13BF8", Slot = "5")]
	public override bool Validate(SpriteRoot s)
	{
		return default(bool);
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x1F13C00", Offset = "0x1F12C00", VA = "0x1F13C00", Slot = "6")]
	public override bool DidChange(SpriteRoot s)
	{
		return default(bool);
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x1F1358C", Offset = "0x1F1258C", VA = "0x1F1358C")]
	public UITextFieldMirror()
	{
	}
}
[Serializable]
[Token(Token = "0x200002F")]
[RequireComponent(typeof(MeshCollider))]
[AddComponentMenu("EZ GUI/Controls/Virtual Screen")]
public class UIVirtualScreen : MonoBehaviour, IUIObject, IEZDragDrop
{
	[Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class <DeactivateScreenCam>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UIVirtualScreen <>4__this;

		[Token(Token = "0x1700008E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x1F154B4", Offset = "0x1F144B4", VA = "0x1F154B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x1F154F4", Offset = "0x1F144F4", VA = "0x1F154F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x1F14B94", Offset = "0x1F13B94", VA = "0x1F14B94")]
		[DebuggerHidden]
		public <DeactivateScreenCam>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x1F1533C", Offset = "0x1F1433C", VA = "0x1F1533C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x1F15340", Offset = "0x1F14340", VA = "0x1F15340", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x1F154BC", Offset = "0x1F144BC", VA = "0x1F154BC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class <Start>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UIVirtualScreen <>4__this;

		[Token(Token = "0x17000090")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x1F155F8", Offset = "0x1F145F8", VA = "0x1F155F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000091")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x1F15638", Offset = "0x1F14638", VA = "0x1F15638", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1F1448C", Offset = "0x1F1348C", VA = "0x1F1448C")]
		[DebuggerHidden]
		public <Start>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1F154FC", Offset = "0x1F144FC", VA = "0x1F154FC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x1F15500", Offset = "0x1F14500", VA = "0x1F15500", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1F15600", Offset = "0x1F14600", VA = "0x1F15600", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Camera screenCamera;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public LayerMask layerMask;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float rayDepth;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool processPointerInfo;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject controlParent;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool onlyRenderWhenNeeded;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float renderTimeout;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected List<IUIObject> controls;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected bool shuttingDown;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected IUIContainer container;

	[Token(Token = "0x17000082")]
	public bool controlIsEnabled
	{
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1F14D34", Offset = "0x1F13D34", VA = "0x1F14D34", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1F14D3C", Offset = "0x1F13D3C", VA = "0x1F14D3C", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000083")]
	public bool DetargetOnDisable
	{
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x1F14D40", Offset = "0x1F13D40", VA = "0x1F14D40", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x1F14D48", Offset = "0x1F13D48", VA = "0x1F14D48", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x17000084")]
	public virtual IUIContainer Container
	{
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x1F14FFC", Offset = "0x1F13FFC", VA = "0x1F14FFC", Slot = "54")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1F15004", Offset = "0x1F14004", VA = "0x1F15004", Slot = "55")]
		set
		{
		}
	}

	[Token(Token = "0x17000085")]
	public object Data
	{
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x1F151E0", Offset = "0x1F141E0", VA = "0x1F151E0", Slot = "24")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x1F151E8", Offset = "0x1F141E8", VA = "0x1F151E8", Slot = "25")]
		set
		{
		}
	}

	[Token(Token = "0x17000086")]
	public bool IsDraggable
	{
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x1F151EC", Offset = "0x1F141EC", VA = "0x1F151EC", Slot = "26")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x1F151F4", Offset = "0x1F141F4", VA = "0x1F151F4", Slot = "27")]
		set
		{
		}
	}

	[Token(Token = "0x17000087")]
	public LayerMask DropMask
	{
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x1F151F8", Offset = "0x1F141F8", VA = "0x1F151F8", Slot = "28")]
		get
		{
			return default(LayerMask);
		}
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x1F15214", Offset = "0x1F14214", VA = "0x1F15214", Slot = "29")]
		set
		{
		}
	}

	[Token(Token = "0x17000088")]
	public bool IsDragging
	{
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x1F15218", Offset = "0x1F14218", VA = "0x1F15218", Slot = "30")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x1F15220", Offset = "0x1F14220", VA = "0x1F15220", Slot = "31")]
		set
		{
		}
	}

	[Token(Token = "0x17000089")]
	public GameObject DropTarget
	{
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x1F15224", Offset = "0x1F14224", VA = "0x1F15224", Slot = "32")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x1F1522C", Offset = "0x1F1422C", VA = "0x1F1522C", Slot = "33")]
		set
		{
		}
	}

	[Token(Token = "0x1700008A")]
	public bool DropHandled
	{
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x1F15230", Offset = "0x1F14230", VA = "0x1F15230", Slot = "34")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x1F15238", Offset = "0x1F14238", VA = "0x1F15238", Slot = "35")]
		set
		{
		}
	}

	[Token(Token = "0x1700008B")]
	public float DragOffset
	{
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x1F1523C", Offset = "0x1F1423C", VA = "0x1F1523C", Slot = "36")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x1F15244", Offset = "0x1F14244", VA = "0x1F15244", Slot = "37")]
		set
		{
		}
	}

	[Token(Token = "0x1700008C")]
	public EZAnimation.EASING_TYPE CancelDragEasing
	{
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x1F15248", Offset = "0x1F14248", VA = "0x1F15248", Slot = "38")]
		get
		{
			return default(EZAnimation.EASING_TYPE);
		}
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x1F15250", Offset = "0x1F14250", VA = "0x1F15250", Slot = "39")]
		set
		{
		}
	}

	[Token(Token = "0x1700008D")]
	public float CancelDragDuration
	{
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x1F15254", Offset = "0x1F14254", VA = "0x1F15254", Slot = "40")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x1F1525C", Offset = "0x1F1425C", VA = "0x1F1525C", Slot = "41")]
		set
		{
		}
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x1F13D58", Offset = "0x1F12D58", VA = "0x1F13D58", Slot = "52")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x1F1442C", Offset = "0x1F1342C", VA = "0x1F1442C", Slot = "53")]
	[IteratorStateMachine(typeof(<Start>d__10))]
	public virtual IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x1F13F5C", Offset = "0x1F12F5C", VA = "0x1F13F5C")]
	protected void SetupControls()
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x1F144B4", Offset = "0x1F134B4", VA = "0x1F144B4")]
	public void AddControl(IUIObject obj)
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x1F14624", Offset = "0x1F13624", VA = "0x1F14624")]
	public void RemoveControl(IUIObject obj)
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x1F14740", Offset = "0x1F13740", VA = "0x1F14740")]
	public void SetScreenCamera(Camera cam)
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x1F14748", Offset = "0x1F13748", VA = "0x1F14748")]
	public void SetControlParent(GameObject go)
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x1F1475C", Offset = "0x1F1375C", VA = "0x1F1475C")]
	protected void InputProcessor(ref POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x1F14B34", Offset = "0x1F13B34", VA = "0x1F14B34")]
	[IteratorStateMachine(typeof(<DeactivateScreenCam>d__17))]
	protected IEnumerator DeactivateScreenCam(float timeout)
	{
		return null;
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x1F14BBC", Offset = "0x1F13BBC", VA = "0x1F14BBC")]
	public void RenderFrame()
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x1F14C78", Offset = "0x1F13C78", VA = "0x1F14C78")]
	public void ForceOn()
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x1F14D4C", Offset = "0x1F13D4C", VA = "0x1F14D4C", Slot = "8")]
	public IUIObject GetControl(ref POINTER_INFO ptr)
	{
		return null;
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x1F1500C", Offset = "0x1F1400C", VA = "0x1F1500C", Slot = "15")]
	public bool RequestContainership(IUIContainer cont)
	{
		return default(bool);
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x1F151BC", Offset = "0x1F141BC", VA = "0x1F151BC", Slot = "16")]
	public bool GotFocus()
	{
		return default(bool);
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x1F151C4", Offset = "0x1F141C4", VA = "0x1F151C4", Slot = "17")]
	public void OnInput(POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x1F151C8", Offset = "0x1F141C8", VA = "0x1F151C8", Slot = "18")]
	public void SetInputDelegate(EZInputDelegate del)
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x1F151CC", Offset = "0x1F141CC", VA = "0x1F151CC", Slot = "19")]
	public void AddInputDelegate(EZInputDelegate del)
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x1F151D0", Offset = "0x1F141D0", VA = "0x1F151D0", Slot = "20")]
	public void RemoveInputDelegate(EZInputDelegate del)
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x1F151D4", Offset = "0x1F141D4", VA = "0x1F151D4", Slot = "21")]
	public void SetValueChangedDelegate(EZValueChangedDelegate del)
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x1F151D8", Offset = "0x1F141D8", VA = "0x1F151D8", Slot = "22")]
	public void AddValueChangedDelegate(EZValueChangedDelegate del)
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x1F151DC", Offset = "0x1F141DC", VA = "0x1F151DC", Slot = "23")]
	public void RemoveValueChangedDelegate(EZValueChangedDelegate del)
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x1F15260", Offset = "0x1F14260", VA = "0x1F15260", Slot = "42")]
	public void DragUpdatePosition(POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x1F15264", Offset = "0x1F14264", VA = "0x1F15264", Slot = "43")]
	public void CancelDrag()
	{
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x1F15268", Offset = "0x1F14268", VA = "0x1F15268", Slot = "44")]
	public void OnEZDragDrop_Internal(EZDragDropParams parms)
	{
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x1F1526C", Offset = "0x1F1426C", VA = "0x1F1526C", Slot = "45")]
	public void AddDragDropDelegate(EZDragDropDelegate del)
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x1F15270", Offset = "0x1F14270", VA = "0x1F15270", Slot = "46")]
	public void RemoveDragDropDelegate(EZDragDropDelegate del)
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x1F15274", Offset = "0x1F14274", VA = "0x1F15274", Slot = "47")]
	public void SetDragDropDelegate(EZDragDropDelegate del)
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x1F15278", Offset = "0x1F14278", VA = "0x1F15278", Slot = "48")]
	public void SetDragDropInternalDelegate(EZDragDropHelper.DragDrop_InternalDelegate del)
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x1F1527C", Offset = "0x1F1427C", VA = "0x1F1527C", Slot = "49")]
	public void AddDragDropInternalDelegate(EZDragDropHelper.DragDrop_InternalDelegate del)
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x1F15280", Offset = "0x1F14280", VA = "0x1F15280", Slot = "50")]
	public void RemoveDragDropInternalDelegate(EZDragDropHelper.DragDrop_InternalDelegate del)
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x1F15284", Offset = "0x1F14284", VA = "0x1F15284", Slot = "51")]
	public EZDragDropHelper.DragDrop_InternalDelegate GetDragDropInternalDelegate()
	{
		return null;
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x1F1528C", Offset = "0x1F1428C", VA = "0x1F1528C")]
	public UIVirtualScreen()
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x1F15324", Offset = "0x1F14324", VA = "0x1F15324", Slot = "11")]
	private GameObject IUIObject.get_gameObject()
	{
		return null;
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x1F1532C", Offset = "0x1F1432C", VA = "0x1F1532C", Slot = "12")]
	private Transform IUIObject.get_transform()
	{
		return null;
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x1F15334", Offset = "0x1F14334", VA = "0x1F15334", Slot = "14")]
	private string IUIObject.get_name()
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000032")]
[AddComponentMenu("EZ GUI/Panels/Bi-State Interactive Panel")]
public class UIBistateInteractivePanel : UIPanelBase
{
	[Token(Token = "0x2000033")]
	public enum STATE
	{
		[Token(Token = "0x40001B3")]
		SHOWING,
		[Token(Token = "0x40001B4")]
		HIDDEN
	}

	[Token(Token = "0x2000034")]
	public delegate void PanelStateChangeDelegate(STATE state);

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected STATE m_panelState;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected PanelStateChangeDelegate stateChangeDel;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[HideInInspector]
	public EZTransitionList transitions;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool requireTap;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
	public bool alwaysShowOnClick;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
	public bool dismissOnOutsideClick;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
	public bool dismissOnPeerClick;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public bool dismissOnChildClick;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
	public bool dismissOnMoveOff;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA6")]
	public bool showOnChildClick;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public STATE initialState;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	protected int lastActionID;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected POINTER_INFO.POINTER_TYPE lastPtrType;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	protected POINTER_INFO.POINTER_TYPE lastListenerType;

	[Token(Token = "0x17000092")]
	public STATE State
	{
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x1F15640", Offset = "0x1F14640", VA = "0x1F15640")]
		get
		{
			return default(STATE);
		}
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x1F15648", Offset = "0x1F14648", VA = "0x1F15648")]
		set
		{
		}
	}

	[Token(Token = "0x17000093")]
	public bool IsShowing
	{
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1F157CC", Offset = "0x1F147CC", VA = "0x1F157CC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000094")]
	public override EZTransitionList Transitions
	{
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1F157DC", Offset = "0x1F147DC", VA = "0x1F157DC", Slot = "56")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x1F157E4", Offset = "0x1F147E4", VA = "0x1F157E4", Slot = "76")]
	public override void OnInput(POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x1F159E4", Offset = "0x1F149E4", VA = "0x1F159E4")]
	protected void PanelClicked(POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x1F15A50", Offset = "0x1F14A50", VA = "0x1F15A50")]
	public void Awake()
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x1F15A40", Offset = "0x1F14A40", VA = "0x1F15A40")]
	public void ToggleState()
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x1F1564C", Offset = "0x1F1464C", VA = "0x1F1564C")]
	protected void SetPanelState(STATE s)
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x1F15C5C", Offset = "0x1F14C5C", VA = "0x1F15C5C", Slot = "60")]
	public override void StartTransition(UIPanelManager.SHOW_MODE mode)
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x1F15C68", Offset = "0x1F14C68", VA = "0x1F15C68")]
	protected void ClickListener(POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x1F15D50", Offset = "0x1F14D50", VA = "0x1F15D50")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x1F15D64", Offset = "0x1F14D64", VA = "0x1F15D64")]
	public void Reveal()
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x1F15D78", Offset = "0x1F14D78", VA = "0x1F15D78")]
	public void AddStateChangeDelegate(PanelStateChangeDelegate del)
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0x1F15DF8", Offset = "0x1F14DF8", VA = "0x1F15DF8")]
	public void RemoveStateChangeDelegate(PanelStateChangeDelegate del)
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0x1F15E78", Offset = "0x1F14E78", VA = "0x1F15E78")]
	public void SetStateChangeDelegate(PanelStateChangeDelegate del)
	{
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x1F15E80", Offset = "0x1F14E80", VA = "0x1F15E80")]
	public static UIBistateInteractivePanel Create(string name, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x1F15FC0", Offset = "0x1F14FC0", VA = "0x1F15FC0")]
	public static UIBistateInteractivePanel Create(string name, Vector3 pos, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x1F16148", Offset = "0x1F15148", VA = "0x1F16148")]
	public UIBistateInteractivePanel()
	{
	}
}
[Serializable]
[Token(Token = "0x2000035")]
[AddComponentMenu("EZ GUI/Panels/Interactive Panel")]
public class UIInteractivePanel : UIPanelBase
{
	[Token(Token = "0x2000036")]
	public enum STATE
	{
		[Token(Token = "0x40001BC")]
		NORMAL,
		[Token(Token = "0x40001BD")]
		OVER,
		[Token(Token = "0x40001BE")]
		DRAGGING
	}

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected STATE m_panelState;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[HideInInspector]
	public EZTransitionList transitions;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public bool draggable;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
	public bool constrainDragArea;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public Vector3 dragBoundaryMin;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Vector3 dragBoundaryMax;

	[Token(Token = "0x17000095")]
	public STATE State
	{
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1F164A4", Offset = "0x1F154A4", VA = "0x1F164A4")]
		get
		{
			return default(STATE);
		}
	}

	[Token(Token = "0x17000096")]
	public override EZTransitionList Transitions
	{
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x1F164AC", Offset = "0x1F154AC", VA = "0x1F164AC", Slot = "56")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0x1F164B4", Offset = "0x1F154B4", VA = "0x1F164B4", Slot = "76")]
	public override void OnInput(POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0x1F16A00", Offset = "0x1F15A00", VA = "0x1F16A00")]
	protected void SetPanelState(STATE s)
	{
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0x1F16A54", Offset = "0x1F15A54", VA = "0x1F16A54")]
	protected void StartTransition(STATE s, STATE prevState)
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x1F16AD8", Offset = "0x1F15AD8", VA = "0x1F16AD8")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0x1F16AEC", Offset = "0x1F15AEC", VA = "0x1F16AEC")]
	public void Reveal()
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0x1F16B00", Offset = "0x1F15B00", VA = "0x1F16B00")]
	public static UIInteractivePanel Create(string name, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0x1F16C40", Offset = "0x1F15C40", VA = "0x1F16C40")]
	public static UIInteractivePanel Create(string name, Vector3 pos, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0x1F16DC8", Offset = "0x1F15DC8", VA = "0x1F16DC8")]
	public UIInteractivePanel()
	{
	}
}
[Token(Token = "0x2000037")]
public struct POINTER_INFO
{
	[Token(Token = "0x2000038")]
	public enum INPUT_EVENT
	{
		[Token(Token = "0x40001D2")]
		NO_CHANGE,
		[Token(Token = "0x40001D3")]
		PRESS,
		[Token(Token = "0x40001D4")]
		RELEASE,
		[Token(Token = "0x40001D5")]
		TAP,
		[Token(Token = "0x40001D6")]
		MOVE,
		[Token(Token = "0x40001D7")]
		MOVE_OFF,
		[Token(Token = "0x40001D8")]
		RELEASE_OFF,
		[Token(Token = "0x40001D9")]
		DRAG
	}

	[Token(Token = "0x2000039")]
	public enum POINTER_TYPE
	{
		[Token(Token = "0x40001DB")]
		MOUSE = 1,
		[Token(Token = "0x40001DC")]
		TOUCHPAD,
		[Token(Token = "0x40001DD")]
		MOUSE_TOUCHPAD,
		[Token(Token = "0x40001DE")]
		RAY
	}

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public POINTER_TYPE type;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public Camera camera;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int actionID;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public INPUT_EVENT evt;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public RaycastHit hitInfo;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool active;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public Vector3 devicePos;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector3 origPos;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public Vector3 inputDelta;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool isTap;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public Ray ray;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public Ray prevRay;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public float rayDepth;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public IUIObject targetObj;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public int layerMask;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public bool callerIsControl;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public float activeTime;

	[Token(Token = "0x6000347")]
	[Address(RVA = "0x1F17178", Offset = "0x1F16178", VA = "0x1F17178")]
	public void Copy(POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x1F172D8", Offset = "0x1F162D8", VA = "0x1F172D8")]
	public void Reuse(POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x1F1739C", Offset = "0x1F1639C", VA = "0x1F1739C")]
	public void Reset(int actID)
	{
	}
}
[Token(Token = "0x200003A")]
public struct KEYBOARD_INFO
{
	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public TouchScreenKeyboardType type;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public bool autoCorrect;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
	public bool multiline;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
	public bool secure;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
	public bool alert;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public bool hideInput;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public int insert;
}
[Serializable]
[Token(Token = "0x200003B")]
public class EZCameraSettings
{
	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Camera camera;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LayerMask mask;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float rayDepth;

	[Token(Token = "0x600034A")]
	[Address(RVA = "0x1F1744C", Offset = "0x1F1644C", VA = "0x1F1744C")]
	public EZCameraSettings()
	{
	}
}
[Token(Token = "0x200003C")]
[AddComponentMenu("EZ GUI/Management/UI Manager")]
public class UIManager : MonoBehaviour
{
	[Token(Token = "0x200003D")]
	public enum POINTER_TYPE
	{
		[Token(Token = "0x4000226")]
		MOUSE,
		[Token(Token = "0x4000227")]
		TOUCHPAD,
		[Token(Token = "0x4000228")]
		AUTO_TOUCHPAD,
		[Token(Token = "0x4000229")]
		RAY,
		[Token(Token = "0x400022A")]
		MOUSE_AND_RAY,
		[Token(Token = "0x400022B")]
		TOUCHPAD_AND_RAY
	}

	[Token(Token = "0x200003E")]
	public enum RAY_ACTIVE_STATE
	{
		[Token(Token = "0x400022D")]
		Inactive,
		[Token(Token = "0x400022E")]
		Momentary,
		[Token(Token = "0x400022F")]
		Constant
	}

	[Token(Token = "0x200003F")]
	public enum OUTSIDE_VIEWPORT
	{
		[Token(Token = "0x4000231")]
		Process_All,
		[Token(Token = "0x4000232")]
		Ignore,
		[Token(Token = "0x4000233")]
		Move_Off
	}

	[Token(Token = "0x2000040")]
	public struct NonUIHitInfo
	{
		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int ptrIndex;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int camIndex;

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1F1E398", Offset = "0x1F1D398", VA = "0x1F1E398")]
		public NonUIHitInfo(int pIndex, int cIndex)
		{
		}
	}

	[Token(Token = "0x2000041")]
	public delegate void PointerPollerDelegate();

	[Token(Token = "0x2000042")]
	public delegate void PointerInfoDelegate(POINTER_INFO ptr);

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static UIManager s_Instance;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public POINTER_TYPE pointerType;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float dragThreshold;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float rayDragThreshold;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float rayDepth;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public LayerMask rayMask;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool focusWithRay;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string actionAxis;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public OUTSIDE_VIEWPORT inputOutsideViewport;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool warnOnNonUiHits;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Transform praycastingTransform;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public EZCameraSettings[] uiCameras;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Camera pRayCamera;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool blockInput;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float defaultDragOffset;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public EZAnimation.EASING_TYPE cancelDragEasing;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float cancelDragDuration;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public TextAsset defaultFont;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Material defaultFontMaterial;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool autoRotateKeyboardPortrait;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
	public bool autoRotateKeyboardPortraitUpsideDown;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
	public bool autoRotateKeyboardLandscapeLeft;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x83")]
	public bool autoRotateKeyboardLandscapeRight;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	protected bool rayActive;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected RAY_ACTIVE_STATE rayState;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected POINTER_INFO[,] pointers;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected NonUIHitInfo[] nonUIHits;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected bool[] usedPointers;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected bool[] usedNonUIHits;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected bool rayIsNonUIHit;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	protected int numPointers;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	protected int numTouchPointers;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	protected int[] activePointers;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	protected int numActivePointers;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	protected int numNonUIHits;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	protected POINTER_INFO rayPtr;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	protected PointerPollerDelegate pointerPoller;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	protected PointerInfoDelegate informNonUIHit;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	protected PointerInfoDelegate mouseTouchListeners;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	protected PointerInfoDelegate rayListeners;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private IUIObject pfocusObj;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	protected string controlText;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	protected int insert;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
	private KEYBOARD_INFO kbInfo;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
	protected int inputLockCount;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	protected bool m_started;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D9")]
	protected bool m_awake;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
	private float time;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private float startTime;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
	private float realtimeDelta;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private int lastUpdateFrame;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
	private int curActionID;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private int numTouches;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
	protected RaycastHit hit;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	protected Vector3 tempVec;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
	private bool down;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private IUIObject tempObj;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private POINTER_INFO tempPtr;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
	private StringBuilder sb;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
	public MyTouchScreenKeyboard iKeyboard;

	[Token(Token = "0x17000097")]
	public static UIManager instance
	{
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x1F0FE6C", Offset = "0x1F0EE6C", VA = "0x1F0FE6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000098")]
	public Transform raycastingTransform
	{
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1F17974", Offset = "0x1F16974", VA = "0x1F17974")]
		get
		{
			return null;
		}
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x1F1797C", Offset = "0x1F1697C", VA = "0x1F1797C")]
		set
		{
		}
	}

	[Token(Token = "0x17000099")]
	public Camera rayCamera
	{
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x1F17984", Offset = "0x1F16984", VA = "0x1F17984")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x1F1798C", Offset = "0x1F1698C", VA = "0x1F1798C")]
		set
		{
		}
	}

	[Token(Token = "0x1700009A")]
	protected IUIObject focusObj
	{
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x1F17994", Offset = "0x1F16994", VA = "0x1F17994")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x1F1799C", Offset = "0x1F1699C", VA = "0x1F1799C")]
		set
		{
		}
	}

	[Token(Token = "0x1700009B")]
	public bool IsKeyboardOpen
	{
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x1F1CEC4", Offset = "0x1F1BEC4", VA = "0x1F1CEC4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700009C")]
	public RAY_ACTIVE_STATE RayActive
	{
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1F1D28C", Offset = "0x1F1C28C", VA = "0x1F1D28C")]
		get
		{
			return default(RAY_ACTIVE_STATE);
		}
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1F1D294", Offset = "0x1F1C294", VA = "0x1F1D294")]
		set
		{
		}
	}

	[Token(Token = "0x1700009D")]
	public IUIObject FocusObject
	{
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1F10738", Offset = "0x1F0F738", VA = "0x1F10738")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1F100A8", Offset = "0x1F0F0A8", VA = "0x1F100A8")]
		set
		{
		}
	}

	[Token(Token = "0x1700009E")]
	public int InsertionPoint
	{
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x1F1E284", Offset = "0x1F1D284", VA = "0x1F1E284")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1F1E28C", Offset = "0x1F1D28C", VA = "0x1F1E28C")]
		set
		{
		}
	}

	[Token(Token = "0x1700009F")]
	public int PointerCount
	{
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1F1E294", Offset = "0x1F1D294", VA = "0x1F1E294")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x1F177B0", Offset = "0x1F167B0", VA = "0x1F177B0")]
	public static bool Exists()
	{
		return default(bool);
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x1F1792C", Offset = "0x1F1692C", VA = "0x1F1792C")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x1F17478", Offset = "0x1F16478", VA = "0x1F17478")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x1F17A60", Offset = "0x1F16A60", VA = "0x1F17A60")]
	public void ReplaceUICamera(Camera c)
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x1F185CC", Offset = "0x1F175CC", VA = "0x1F185CC")]
	private void SceneManager_sceneLoaded(Scene arg0, LoadSceneMode arg1)
	{
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x1F186F4", Offset = "0x1F176F4", VA = "0x1F186F4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x1F17B5C", Offset = "0x1F16B5C", VA = "0x1F17B5C")]
	protected void SetupPointers()
	{
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x1F18800", Offset = "0x1F17800", VA = "0x1F18800")]
	public void SetNonUIHitDelegate(PointerInfoDelegate del)
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0x1F18808", Offset = "0x1F17808", VA = "0x1F18808")]
	public void AddNonUIHitDelegate(PointerInfoDelegate del)
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x1F18888", Offset = "0x1F17888", VA = "0x1F18888")]
	public void RemoveNonUIHitDelegate(PointerInfoDelegate del)
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x1F15A5C", Offset = "0x1F14A5C", VA = "0x1F15A5C")]
	public void AddMouseTouchPtrListener(PointerInfoDelegate del)
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x1F15ADC", Offset = "0x1F14ADC", VA = "0x1F15ADC")]
	public void AddRayPtrListener(PointerInfoDelegate del)
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x1F15B5C", Offset = "0x1F14B5C", VA = "0x1F15B5C")]
	public void RemoveMouseTouchPtrListener(PointerInfoDelegate del)
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x1F15BDC", Offset = "0x1F14BDC", VA = "0x1F15BDC")]
	public void RemoveRayPtrListener(PointerInfoDelegate del)
	{
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0x1F18908", Offset = "0x1F17908", VA = "0x1F18908")]
	protected void AddNonUIHit(int ptrIndex, int camIndex)
	{
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0x1F189D8", Offset = "0x1F179D8", VA = "0x1F189D8")]
	protected void CallNonUIHitDelegate()
	{
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0x1F18B54", Offset = "0x1F17B54", VA = "0x1F18B54")]
	public bool DidPointerHitUI(int id)
	{
		return default(bool);
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0x1F18BD4", Offset = "0x1F17BD4", VA = "0x1F18BD4")]
	public bool DidAnyPointerHitUI()
	{
		return default(bool);
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x1F18C74", Offset = "0x1F17C74", VA = "0x1F18C74")]
	public void AddCamera(Camera cam)
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x1F18CA8", Offset = "0x1F17CA8", VA = "0x1F18CA8")]
	public void AddCamera(Camera cam, LayerMask mask, float depth, int index)
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x1F18E8C", Offset = "0x1F17E8C", VA = "0x1F18E8C")]
	public void RemoveCamera(int index)
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x1F18FC8", Offset = "0x1F17FC8", VA = "0x1F18FC8")]
	public void ReplaceCamera(int index, Camera cam)
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x1F19010", Offset = "0x1F18010", VA = "0x1F19010")]
	protected void BeginDrag(ref POINTER_INFO curPtr)
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x1F191DC", Offset = "0x1F181DC", VA = "0x1F191DC")]
	protected void DoDragUpdate(POINTER_INFO curPtr)
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x1F19AE4", Offset = "0x1F18AE4", VA = "0x1F19AE4", Slot = "4")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x1F19F9C", Offset = "0x1F18F9C", VA = "0x1F19F9C")]
	protected void DispatchInput()
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x1F1A384", Offset = "0x1F19384", VA = "0x1F1A384")]
	protected void DispatchHelper(ref POINTER_INFO curPtr, int camIndex)
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x1F1B5F8", Offset = "0x1F1A5F8", VA = "0x1F1B5F8")]
	protected void PollMouse()
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x1F1BD38", Offset = "0x1F1AD38", VA = "0x1F1BD38")]
	protected void PollMouseAndTouchpad()
	{
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x1F1B900", Offset = "0x1F1A900", VA = "0x1F1B900")]
	protected void PollMouse(ref POINTER_INFO curPtr)
	{
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x1F1C0D0", Offset = "0x1F1B0D0", VA = "0x1F1C0D0")]
	protected void PollTouchpad()
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x1F1C84C", Offset = "0x1F1B84C", VA = "0x1F1C84C")]
	protected void PollRay()
	{
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x1F1CE94", Offset = "0x1F1BE94", VA = "0x1F1CE94")]
	protected void PollMouseRay()
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x1F1CEAC", Offset = "0x1F1BEAC", VA = "0x1F1CEAC")]
	protected void PollTouchpadRay()
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x1F19BC8", Offset = "0x1F18BC8", VA = "0x1F19BC8")]
	protected void PollKeyboard()
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x1F1CED4", Offset = "0x1F1BED4", VA = "0x1F1CED4")]
	protected void ProcessKeyboard()
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0x1F1D29C", Offset = "0x1F1C29C", VA = "0x1F1D29C")]
	public void Detarget(IUIObject obj)
	{
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0x1F1D440", Offset = "0x1F1C440", VA = "0x1F1D440")]
	public void Detarget(int pointerID)
	{
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0x1F1D948", Offset = "0x1F1C948", VA = "0x1F1D948")]
	public void DetargetAllExcept(int pointerID)
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0x1F1D2A4", Offset = "0x1F1C2A4", VA = "0x1F1D2A4")]
	public void Retarget(IUIObject oldObj, IUIObject newObj)
	{
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0x1F1DEFC", Offset = "0x1F1CEFC", VA = "0x1F1DEFC")]
	public bool GetPointer(IUIObject obj, out POINTER_INFO ptr)
	{
		return default(bool);
	}

	[Token(Token = "0x600037E")]
	[Address(RVA = "0x1F1E0D4", Offset = "0x1F1D0D4", VA = "0x1F1E0D4")]
	public bool GetPointer(int pointerID, int camera, out POINTER_INFO ptr)
	{
		return default(bool);
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0x1F1E1B4", Offset = "0x1F1D1B4", VA = "0x1F1E1B4")]
	public void LockInput()
	{
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0x1F1E1CC", Offset = "0x1F1D1CC", VA = "0x1F1E1CC")]
	public void UnlockInput()
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0x1F1E1F0", Offset = "0x1F1D1F0", VA = "0x1F1E1F0")]
	public bool IsMsgTyping()
	{
		return default(bool);
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x1F1D20C", Offset = "0x1F1C20C", VA = "0x1F1D20C")]
	protected static int FindInsertionPoint(string before, string after)
	{
		return default(int);
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0x1F1B53C", Offset = "0x1F1A53C", VA = "0x1F1B53C")]
	protected void LogNonUIObjErr(GameObject obj)
	{
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x1F1E29C", Offset = "0x1F1D29C", VA = "0x1F1E29C")]
	public UIManager()
	{
	}
}
[Serializable]
[Token(Token = "0x2000043")]
[AddComponentMenu("EZ GUI/Panels/Panel")]
public class UIPanel : UIPanelBase
{
	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public EZTransitionList transitions;

	[Token(Token = "0x170000A0")]
	public override EZTransitionList Transitions
	{
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1F1E5D0", Offset = "0x1F1D5D0", VA = "0x1F1E5D0", Slot = "56")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0x1F1E5D8", Offset = "0x1F1D5D8", VA = "0x1F1E5D8")]
	public static UIPanel Create(string name, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0x1F1E718", Offset = "0x1F1D718", VA = "0x1F1E718")]
	public static UIPanel Create(string name, Vector3 pos, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0x1F1E8A0", Offset = "0x1F1D8A0", VA = "0x1F1E8A0")]
	public UIPanel()
	{
	}
}
[Serializable]
[Token(Token = "0x2000044")]
[AddComponentMenu("EZ GUI/Management/Panel Manager")]
public class UIPanelManager : MonoBehaviour, IUIContainer, IUIObject, IEZDragDrop
{
	[Token(Token = "0x2000045")]
	public enum SHOW_MODE
	{
		[Token(Token = "0x4000248")]
		BringInForward,
		[Token(Token = "0x4000249")]
		BringInBack,
		[Token(Token = "0x400024A")]
		DismissForward,
		[Token(Token = "0x400024B")]
		DismissBack
	}

	[Token(Token = "0x2000046")]
	public enum MENU_DIRECTION
	{
		[Token(Token = "0x400024D")]
		Forwards,
		[Token(Token = "0x400024E")]
		Backwards,
		[Token(Token = "0x400024F")]
		Auto
	}

	[Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class <Start>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UIPanelManager <>4__this;

		[Token(Token = "0x170000B0")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x1F21E30", Offset = "0x1F20E30", VA = "0x1F21E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B1")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x1F21E70", Offset = "0x1F20E70", VA = "0x1F21E70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1F1F250", Offset = "0x1F1E250", VA = "0x1F1F250")]
		[DebuggerHidden]
		public <Start>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1F21BD0", Offset = "0x1F20BD0", VA = "0x1F21BD0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1F21BD4", Offset = "0x1F20BD4", VA = "0x1F21BD4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x1F21E38", Offset = "0x1F20E38", VA = "0x1F21E38", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static UIPanelManager m_instance;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected List<UIPanelBase> panels;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UIPanelBase initialPanel;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool deactivateAllButInitialAtStart;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool linearNavigation;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool circular;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	public bool advancePastEnd;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected UIPanelBase curPanel;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected int transitioningPanelCount;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	protected bool m_started;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected List<UIPanelBase> breadcrumbs;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected bool m_controlIsEnabled;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected IUIContainer container;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected EZInputDelegate inputDelegate;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected EZValueChangedDelegate changeDelegate;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected EZDragDropDelegate dragDropDelegate;

	[Token(Token = "0x170000A1")]
	public static UIPanelManager instance
	{
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x1F1EC0C", Offset = "0x1F1DC0C", VA = "0x1F1EC0C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A2")]
	public UIPanelBase CurrentPanel
	{
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1F1EC9C", Offset = "0x1F1DC9C", VA = "0x1F1EC9C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A3")]
	public int TransitioningPanelCount
	{
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1F1FAC0", Offset = "0x1F1EAC0", VA = "0x1F1FAC0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000A4")]
	public virtual bool controlIsEnabled
	{
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x1F213EC", Offset = "0x1F203EC", VA = "0x1F213EC", Slot = "57")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x1F213F4", Offset = "0x1F203F4", VA = "0x1F213F4", Slot = "58")]
		set
		{
		}
	}

	[Token(Token = "0x170000A5")]
	public virtual bool DetargetOnDisable
	{
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x1F21400", Offset = "0x1F20400", VA = "0x1F21400", Slot = "59")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x1F21408", Offset = "0x1F20408", VA = "0x1F21408", Slot = "60")]
		set
		{
		}
	}

	[Token(Token = "0x170000A6")]
	public virtual IUIContainer Container
	{
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x1F21410", Offset = "0x1F20410", VA = "0x1F21410", Slot = "61")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x1F21418", Offset = "0x1F20418", VA = "0x1F21418", Slot = "62")]
		set
		{
		}
	}

	[Token(Token = "0x170000A7")]
	public object Data
	{
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x1F217D8", Offset = "0x1F207D8", VA = "0x1F217D8", Slot = "28")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x1F217E0", Offset = "0x1F207E0", VA = "0x1F217E0", Slot = "29")]
		set
		{
		}
	}

	[Token(Token = "0x170000A8")]
	public bool IsDraggable
	{
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x1F217E4", Offset = "0x1F207E4", VA = "0x1F217E4", Slot = "30")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x1F217EC", Offset = "0x1F207EC", VA = "0x1F217EC", Slot = "31")]
		set
		{
		}
	}

	[Token(Token = "0x170000A9")]
	public LayerMask DropMask
	{
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x1F217F0", Offset = "0x1F207F0", VA = "0x1F217F0", Slot = "32")]
		get
		{
			return default(LayerMask);
		}
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x1F2180C", Offset = "0x1F2080C", VA = "0x1F2180C", Slot = "33")]
		set
		{
		}
	}

	[Token(Token = "0x170000AA")]
	public float DragOffset
	{
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x1F21810", Offset = "0x1F20810", VA = "0x1F21810", Slot = "40")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x1F21818", Offset = "0x1F20818", VA = "0x1F21818", Slot = "41")]
		set
		{
		}
	}

	[Token(Token = "0x170000AB")]
	public EZAnimation.EASING_TYPE CancelDragEasing
	{
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x1F2181C", Offset = "0x1F2081C", VA = "0x1F2181C", Slot = "42")]
		get
		{
			return default(EZAnimation.EASING_TYPE);
		}
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1F21824", Offset = "0x1F20824", VA = "0x1F21824", Slot = "43")]
		set
		{
		}
	}

	[Token(Token = "0x170000AC")]
	public float CancelDragDuration
	{
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x1F21828", Offset = "0x1F20828", VA = "0x1F21828", Slot = "44")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1F21830", Offset = "0x1F20830", VA = "0x1F21830", Slot = "45")]
		set
		{
		}
	}

	[Token(Token = "0x170000AD")]
	public bool IsDragging
	{
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1F21834", Offset = "0x1F20834", VA = "0x1F21834", Slot = "34")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1F2183C", Offset = "0x1F2083C", VA = "0x1F2183C", Slot = "35")]
		set
		{
		}
	}

	[Token(Token = "0x170000AE")]
	public GameObject DropTarget
	{
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1F21840", Offset = "0x1F20840", VA = "0x1F21840", Slot = "36")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x1F21848", Offset = "0x1F20848", VA = "0x1F21848", Slot = "37")]
		set
		{
		}
	}

	[Token(Token = "0x170000AF")]
	public bool DropHandled
	{
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x1F2184C", Offset = "0x1F2084C", VA = "0x1F2184C", Slot = "38")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x1F21854", Offset = "0x1F20854", VA = "0x1F21854", Slot = "39")]
		set
		{
		}
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0x1F1EC54", Offset = "0x1F1DC54", VA = "0x1F1EC54")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x1F1ECA4", Offset = "0x1F1DCA4", VA = "0x1F1ECA4", Slot = "4")]
	public void AddChild(GameObject go)
	{
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x1F1EEF4", Offset = "0x1F1DEF4", VA = "0x1F1EEF4", Slot = "5")]
	public void RemoveChild(GameObject go)
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x1F1F064", Offset = "0x1F1E064", VA = "0x1F1F064", Slot = "6")]
	public void AddSubject(GameObject go)
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0x1F1F068", Offset = "0x1F1E068", VA = "0x1F1F068", Slot = "7")]
	public void RemoveSubject(GameObject go)
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x1F1F06C", Offset = "0x1F1E06C", VA = "0x1F1F06C")]
	public void MakeChild(GameObject go)
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x1F1F0C0", Offset = "0x1F1E0C0", VA = "0x1F1F0C0")]
	public UIPanelBase[] GetPanels()
	{
		return null;
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x1F1F110", Offset = "0x1F1E110", VA = "0x1F1F110")]
	public int GetPanelCount()
	{
		return default(int);
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x1F1F158", Offset = "0x1F1E158", VA = "0x1F1F158")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x1F1F1F0", Offset = "0x1F1E1F0", VA = "0x1F1F1F0")]
	[IteratorStateMachine(typeof(<Start>d__26))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x1F1F278", Offset = "0x1F1E278", VA = "0x1F1F278", Slot = "56")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x1F1F38C", Offset = "0x1F1E38C", VA = "0x1F1F38C")]
	public void ScanChildren()
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x1F1FAC8", Offset = "0x1F1EAC8", VA = "0x1F1FAC8")]
	protected void DecrementTransitioningPanels(UIPanelBase p, EZTransition t)
	{
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x1F1FAD8", Offset = "0x1F1EAD8", VA = "0x1F1FAD8")]
	protected void StartAndTrack(UIPanelBase p, SHOW_MODE mode)
	{
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x1F1FD28", Offset = "0x1F1ED28", VA = "0x1F1FD28")]
	public bool MoveForward()
	{
		return default(bool);
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x1F2008C", Offset = "0x1F1F08C", VA = "0x1F2008C")]
	public bool MoveBack()
	{
		return default(bool);
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x1F204F4", Offset = "0x1F1F4F4", VA = "0x1F204F4")]
	public void BringIn(UIPanelBase panel, MENU_DIRECTION dir)
	{
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x1F20728", Offset = "0x1F1F728", VA = "0x1F20728")]
	public void BringInImmediate(UIPanelBase panel, MENU_DIRECTION dir)
	{
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x1F208B4", Offset = "0x1F1F8B4", VA = "0x1F208B4")]
	public void BringIn(string panelName, MENU_DIRECTION dir)
	{
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x1F20A0C", Offset = "0x1F1FA0C", VA = "0x1F20A0C")]
	public void BringIn(UIPanelBase panel)
	{
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x1F20A14", Offset = "0x1F1FA14", VA = "0x1F20A14")]
	public void BringIn(string panelName)
	{
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x1F20A1C", Offset = "0x1F1FA1C", VA = "0x1F20A1C")]
	public void BringIn(int panelIndex)
	{
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x1F20B8C", Offset = "0x1F1FB8C", VA = "0x1F20B8C")]
	public void BringIn(int panelIndex, MENU_DIRECTION dir)
	{
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x1F20D0C", Offset = "0x1F1FD0C", VA = "0x1F20D0C")]
	public void BringInImmediate(string panelName, MENU_DIRECTION dir)
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x1F20E64", Offset = "0x1F1FE64", VA = "0x1F20E64")]
	public void BringInImmediate(UIPanelBase panel)
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x1F20E6C", Offset = "0x1F1FE6C", VA = "0x1F20E6C")]
	public void BringInImmediate(string panelName)
	{
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x1F20E74", Offset = "0x1F1FE74", VA = "0x1F20E74")]
	public void BringInImmediate(int panelIndex)
	{
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x1F20FE4", Offset = "0x1F1FFE4", VA = "0x1F20FE4")]
	public void BringInImmediate(int panelIndex, MENU_DIRECTION dir)
	{
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x1F21164", Offset = "0x1F20164", VA = "0x1F21164")]
	public void Dismiss(MENU_DIRECTION dir)
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x1F212FC", Offset = "0x1F202FC", VA = "0x1F212FC")]
	public void Dismiss()
	{
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x1F21304", Offset = "0x1F20304", VA = "0x1F21304")]
	public void DismissImmediate(MENU_DIRECTION dir)
	{
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x1F213E4", Offset = "0x1F203E4", VA = "0x1F213E4")]
	public void DismissImmediate()
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x1F1F62C", Offset = "0x1F1E62C", VA = "0x1F1F62C")]
	public static void SetLayerRecursively(GameObject go, int layer)
	{
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x1F2140C", Offset = "0x1F2040C", VA = "0x1F2140C", Slot = "12")]
	public IUIObject GetControl(ref POINTER_INFO ptr)
	{
		return null;
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x1F21420", Offset = "0x1F20420", VA = "0x1F21420", Slot = "19")]
	public bool RequestContainership(IUIContainer cont)
	{
		return default(bool);
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x1F215BC", Offset = "0x1F205BC", VA = "0x1F215BC", Slot = "20")]
	public bool GotFocus()
	{
		return default(bool);
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x1F215C4", Offset = "0x1F205C4", VA = "0x1F215C4", Slot = "63")]
	public virtual void SetInputDelegate(EZInputDelegate del)
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x1F215CC", Offset = "0x1F205CC", VA = "0x1F215CC", Slot = "64")]
	public virtual void AddInputDelegate(EZInputDelegate del)
	{
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x1F2164C", Offset = "0x1F2064C", VA = "0x1F2164C", Slot = "65")]
	public virtual void RemoveInputDelegate(EZInputDelegate del)
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x1F216CC", Offset = "0x1F206CC", VA = "0x1F216CC", Slot = "66")]
	public virtual void SetValueChangedDelegate(EZValueChangedDelegate del)
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x1F216D4", Offset = "0x1F206D4", VA = "0x1F216D4", Slot = "67")]
	public virtual void AddValueChangedDelegate(EZValueChangedDelegate del)
	{
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x1F21754", Offset = "0x1F20754", VA = "0x1F21754", Slot = "68")]
	public virtual void RemoveValueChangedDelegate(EZValueChangedDelegate del)
	{
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x1F217D4", Offset = "0x1F207D4", VA = "0x1F217D4", Slot = "69")]
	public virtual void OnInput(POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x1F21858", Offset = "0x1F20858", VA = "0x1F21858", Slot = "46")]
	public void DragUpdatePosition(POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x1F2185C", Offset = "0x1F2085C", VA = "0x1F2185C", Slot = "47")]
	public void CancelDrag()
	{
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x1F21860", Offset = "0x1F20860", VA = "0x1F21860", Slot = "48")]
	public void OnEZDragDrop_Internal(EZDragDropParams parms)
	{
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x1F218C0", Offset = "0x1F208C0", VA = "0x1F218C0", Slot = "49")]
	public void AddDragDropDelegate(EZDragDropDelegate del)
	{
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x1F21940", Offset = "0x1F20940", VA = "0x1F21940", Slot = "50")]
	public void RemoveDragDropDelegate(EZDragDropDelegate del)
	{
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x1F219C0", Offset = "0x1F209C0", VA = "0x1F219C0", Slot = "51")]
	public void SetDragDropDelegate(EZDragDropDelegate del)
	{
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x1F219C8", Offset = "0x1F209C8", VA = "0x1F219C8", Slot = "52")]
	public void SetDragDropInternalDelegate(EZDragDropHelper.DragDrop_InternalDelegate del)
	{
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x1F219CC", Offset = "0x1F209CC", VA = "0x1F219CC", Slot = "53")]
	public void AddDragDropInternalDelegate(EZDragDropHelper.DragDrop_InternalDelegate del)
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x1F219D0", Offset = "0x1F209D0", VA = "0x1F219D0", Slot = "54")]
	public void RemoveDragDropInternalDelegate(EZDragDropHelper.DragDrop_InternalDelegate del)
	{
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x1F219D4", Offset = "0x1F209D4", VA = "0x1F219D4", Slot = "55")]
	public EZDragDropHelper.DragDrop_InternalDelegate GetDragDropInternalDelegate()
	{
		return null;
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x1F219DC", Offset = "0x1F209DC", VA = "0x1F219DC")]
	public static UIPanelManager Create(string name, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x1F21B1C", Offset = "0x1F20B1C", VA = "0x1F21B1C")]
	public UIPanelManager()
	{
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x1F21BB8", Offset = "0x1F20BB8", VA = "0x1F21BB8", Slot = "15")]
	private GameObject IUIObject.get_gameObject()
	{
		return null;
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x1F21BC0", Offset = "0x1F20BC0", VA = "0x1F21BC0", Slot = "16")]
	private Transform IUIObject.get_transform()
	{
		return null;
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x1F21BC8", Offset = "0x1F20BC8", VA = "0x1F21BC8", Slot = "18")]
	private string IUIObject.get_name()
	{
		return null;
	}
}
[Token(Token = "0x2000048")]
public class ASCSEInfo
{
	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Texture2D tex;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextureAnim stateObj;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public EZTransitionList transitions;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string stateLabel;

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x1F21E78", Offset = "0x1F20E78", VA = "0x1F21E78")]
	public ASCSEInfo()
	{
	}
}
[Token(Token = "0x2000049")]
public abstract class AutoSpriteControlBase : AutoSpriteBase, IControl, IUIObject, IEZDragDrop, IPackableControl, ISpritePackable
{
	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	public string LanguageKey;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	protected bool nullCamera;

	[Token(Token = "0x4000259")]
	public const string DittoString = "[\"]";

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	public string text;

	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	public SpriteText spriteText;

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	public float textOffsetZ;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29C")]
	public bool includeTextInAutoCollider;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	protected SpriteText.Anchor_Pos defaultTextAnchor;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A4")]
	protected SpriteText.Alignment_Type defaultTextAlignment;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	public bool detargetOnDisable;

	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A9")]
	protected bool customCollider;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2AC")]
	protected Vector3 savedColliderSize;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
	protected Vector2 topLeftEdge;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
	protected Vector2 bottomRightEdge;

	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
	[HideInInspector]
	public object data;

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
	protected SpriteRoot[][] aggregateLayers;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
	public float scaleCollider;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2DC")]
	protected bool m_controlIsEnabled;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
	protected IUIContainer container;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
	protected EZInputDelegate inputDelegate;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
	protected EZValueChangedDelegate changeDelegate;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
	protected EZDragDropHelper dragDropHelper;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
	public bool isDraggable;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x304")]
	public LayerMask dropMask;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
	public float dragOffset;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30C")]
	public EZAnimation.EASING_TYPE cancelDragEasing;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
	public float cancelDragDuration;

	[Token(Token = "0x170000B2")]
	public virtual string Text
	{
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1F21E80", Offset = "0x1F20E80", VA = "0x1F21E80", Slot = "156")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1F21E88", Offset = "0x1F20E88", VA = "0x1F21E88", Slot = "157")]
		set
		{
		}
	}

	[Token(Token = "0x170000B3")]
	public object Data
	{
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1F223DC", Offset = "0x1F213DC", VA = "0x1F223DC", Slot = "128")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x1F223E4", Offset = "0x1F213E4", VA = "0x1F223E4", Slot = "129")]
		set
		{
		}
	}

	[Token(Token = "0x170000B4")]
	public virtual bool IncludeTextInAutoCollider
	{
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1F22460", Offset = "0x1F21460", VA = "0x1F22460", Slot = "158")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1F22468", Offset = "0x1F21468", VA = "0x1F22468", Slot = "159")]
		set
		{
		}
	}

	[Token(Token = "0x170000B5")]
	public override bool Clipped
	{
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1F22C1C", Offset = "0x1F21C1C", VA = "0x1F22C1C", Slot = "42")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1F22C24", Offset = "0x1F21C24", VA = "0x1F22C24", Slot = "43")]
		set
		{
		}
	}

	[Token(Token = "0x170000B6")]
	public override Rect3D ClippingRect
	{
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1F22D90", Offset = "0x1F21D90", VA = "0x1F22D90", Slot = "40")]
		get
		{
			return default(Rect3D);
		}
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x1F22DAC", Offset = "0x1F21DAC", VA = "0x1F22DAC", Slot = "41")]
		set
		{
		}
	}

	[Token(Token = "0x170000B7")]
	public override Camera RenderCamera
	{
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x1F22F8C", Offset = "0x1F21F8C", VA = "0x1F22F8C", Slot = "33")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1F22F94", Offset = "0x1F21F94", VA = "0x1F22F94", Slot = "34")]
		set
		{
		}
	}

	[Token(Token = "0x170000B8")]
	public Vector2 TopLeftEdge
	{
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x1F257B8", Offset = "0x1F247B8", VA = "0x1F257B8", Slot = "164")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x170000B9")]
	public Vector2 BottomRightEdge
	{
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x1F257C4", Offset = "0x1F247C4", VA = "0x1F257C4", Slot = "165")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x170000BA")]
	public virtual bool controlIsEnabled
	{
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1F257D0", Offset = "0x1F247D0", VA = "0x1F257D0", Slot = "166")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1F257D8", Offset = "0x1F247D8", VA = "0x1F257D8", Slot = "167")]
		set
		{
		}
	}

	[Token(Token = "0x170000BB")]
	public virtual bool DetargetOnDisable
	{
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x1F257E4", Offset = "0x1F247E4", VA = "0x1F257E4", Slot = "168")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x1F257F4", Offset = "0x1F247F4", VA = "0x1F257F4", Slot = "169")]
		set
		{
		}
	}

	[Token(Token = "0x170000BC")]
	public virtual IUIContainer Container
	{
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x1F2580C", Offset = "0x1F2480C", VA = "0x1F2580C", Slot = "170")]
		get
		{
			return null;
		}
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x1F25814", Offset = "0x1F24814", VA = "0x1F25814", Slot = "171")]
		set
		{
		}
	}

	[Token(Token = "0x170000BD")]
	public LayerMask DropMask
	{
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1F260F4", Offset = "0x1F250F4", VA = "0x1F260F4", Slot = "132")]
		get
		{
			return default(LayerMask);
		}
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1F260FC", Offset = "0x1F250FC", VA = "0x1F260FC", Slot = "133")]
		set
		{
		}
	}

	[Token(Token = "0x170000BE")]
	public bool IsDraggable
	{
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1F26104", Offset = "0x1F25104", VA = "0x1F26104", Slot = "130")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x1F2610C", Offset = "0x1F2510C", VA = "0x1F2610C", Slot = "131")]
		set
		{
		}
	}

	[Token(Token = "0x170000BF")]
	public float DragOffset
	{
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x1F26118", Offset = "0x1F25118", VA = "0x1F26118", Slot = "140")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1F26120", Offset = "0x1F25120", VA = "0x1F26120", Slot = "141")]
		set
		{
		}
	}

	[Token(Token = "0x170000C0")]
	public EZAnimation.EASING_TYPE CancelDragEasing
	{
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1F2627C", Offset = "0x1F2527C", VA = "0x1F2627C", Slot = "142")]
		get
		{
			return default(EZAnimation.EASING_TYPE);
		}
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1F26284", Offset = "0x1F25284", VA = "0x1F26284", Slot = "143")]
		set
		{
		}
	}

	[Token(Token = "0x170000C1")]
	public float CancelDragDuration
	{
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1F2628C", Offset = "0x1F2528C", VA = "0x1F2628C", Slot = "144")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x1F26294", Offset = "0x1F25294", VA = "0x1F26294", Slot = "145")]
		set
		{
		}
	}

	[Token(Token = "0x170000C2")]
	public bool IsDragging
	{
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x1F26200", Offset = "0x1F25200", VA = "0x1F26200", Slot = "134")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1F2629C", Offset = "0x1F2529C", VA = "0x1F2629C", Slot = "135")]
		set
		{
		}
	}

	[Token(Token = "0x170000C3")]
	public GameObject DropTarget
	{
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1F26314", Offset = "0x1F25314", VA = "0x1F26314", Slot = "136")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1F26330", Offset = "0x1F25330", VA = "0x1F26330", Slot = "137")]
		set
		{
		}
	}

	[Token(Token = "0x170000C4")]
	public bool DropHandled
	{
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x1F26524", Offset = "0x1F25524", VA = "0x1F26524", Slot = "138")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1F26540", Offset = "0x1F25540", VA = "0x1F26540", Slot = "139")]
		set
		{
		}
	}

	[Token(Token = "0x170000C5")]
	public bool UseDefaultCancelDragAnim
	{
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1F26A78", Offset = "0x1F25A78", VA = "0x1F26A78")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1F26A94", Offset = "0x1F25A94", VA = "0x1F26A94")]
		set
		{
		}
	}

	[Token(Token = "0x170000C6")]
	public abstract EZTransitionList[] Transitions
	{
		[Token(Token = "0x600044C")]
		get;
		[Token(Token = "0x600044D")]
		set;
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x1F223EC", Offset = "0x1F213EC", VA = "0x1F223EC", Slot = "14")]
	protected override void Init()
	{
	}

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x1F22480", Offset = "0x1F21480", VA = "0x1F22480", Slot = "13")]
	public override void Start()
	{
	}

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0x1F226A4", Offset = "0x1F216A4", VA = "0x1F226A4", Slot = "25")]
	public override void TruncateTop(float pct)
	{
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x1F2277C", Offset = "0x1F2177C", VA = "0x1F2277C", Slot = "26")]
	public override void TruncateBottom(float pct)
	{
	}

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0x1F22854", Offset = "0x1F21854", VA = "0x1F22854", Slot = "24")]
	public override void TruncateLeft(float pct)
	{
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0x1F2292C", Offset = "0x1F2192C", VA = "0x1F2292C", Slot = "23")]
	public override void TruncateRight(float pct)
	{
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x1F22A04", Offset = "0x1F21A04", VA = "0x1F22A04", Slot = "27")]
	public override void Untruncate()
	{
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0x1F22ACC", Offset = "0x1F21ACC", VA = "0x1F22ACC", Slot = "28")]
	public override void Unclip()
	{
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0x1F2303C", Offset = "0x1F2203C", VA = "0x1F2303C", Slot = "36")]
	public override void SetCamera(Camera c)
	{
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0x1F23100", Offset = "0x1F22100", VA = "0x1F23100", Slot = "37")]
	public override void Hide(bool tf)
	{
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0x1F2349C", Offset = "0x1F2249C", VA = "0x1F2349C", Slot = "94")]
	public void Copy(IControl c)
	{
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0x1F2356C", Offset = "0x1F2256C", VA = "0x1F2356C", Slot = "95")]
	public void Copy(IControl c, ControlCopyFlags flags)
	{
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0x1F23650", Offset = "0x1F22650", VA = "0x1F23650", Slot = "16")]
	public override void Copy(SpriteRoot s)
	{
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0x1F23664", Offset = "0x1F22664", VA = "0x1F23664", Slot = "160")]
	public virtual void Copy(SpriteRoot s, ControlCopyFlags flags)
	{
	}

	[Token(Token = "0x600040D")]
	[Address(RVA = "0x1F24A84", Offset = "0x1F23A84", VA = "0x1F24A84", Slot = "12")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0x1F24CA0", Offset = "0x1F23CA0", VA = "0x1F24CA0", Slot = "19")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0x1F24D6C", Offset = "0x1F23D6C", VA = "0x1F24D6C", Slot = "20")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000410")]
	[Address(RVA = "0x1F24E90", Offset = "0x1F23E90", VA = "0x1F24E90")]
	protected void OnResize(float newWidth, float newHeight, SpriteRoot sprite)
	{
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0x1F24EA0", Offset = "0x1F23EA0", VA = "0x1F24EA0", Slot = "161")]
	protected virtual void AddCollider()
	{
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0x1F25050", Offset = "0x1F24050", VA = "0x1F25050", Slot = "162")]
	public virtual void UpdateCollider()
	{
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0x1F25404", Offset = "0x1F24404", VA = "0x1F25404", Slot = "163")]
	public virtual void FindOuterEdges()
	{
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0x1F25808", Offset = "0x1F24808", VA = "0x1F25808", Slot = "112")]
	public IUIObject GetControl(ref POINTER_INFO ptr)
	{
		return null;
	}

	[Token(Token = "0x600041D")]
	[Address(RVA = "0x1F25BEC", Offset = "0x1F24BEC", VA = "0x1F25BEC", Slot = "119")]
	public bool RequestContainership(IUIContainer cont)
	{
		return default(bool);
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0x1F25D9C", Offset = "0x1F24D9C", VA = "0x1F25D9C", Slot = "172")]
	public virtual bool GotFocus()
	{
		return default(bool);
	}

	[Token(Token = "0x600041F")]
	[Address(RVA = "0x1F25DA4", Offset = "0x1F24DA4", VA = "0x1F25DA4", Slot = "173")]
	public virtual void SetInputDelegate(EZInputDelegate del)
	{
	}

	[Token(Token = "0x6000420")]
	[Address(RVA = "0x1F25DAC", Offset = "0x1F24DAC", VA = "0x1F25DAC", Slot = "174")]
	public virtual void AddInputDelegate(EZInputDelegate del)
	{
	}

	[Token(Token = "0x6000421")]
	[Address(RVA = "0x1F25E2C", Offset = "0x1F24E2C", VA = "0x1F25E2C", Slot = "175")]
	public virtual void RemoveInputDelegate(EZInputDelegate del)
	{
	}

	[Token(Token = "0x6000422")]
	[Address(RVA = "0x1F25EAC", Offset = "0x1F24EAC", VA = "0x1F25EAC", Slot = "176")]
	public virtual void SetValueChangedDelegate(EZValueChangedDelegate del)
	{
	}

	[Token(Token = "0x6000423")]
	[Address(RVA = "0x1F25EB4", Offset = "0x1F24EB4", VA = "0x1F25EB4", Slot = "177")]
	public virtual void AddValueChangedDelegate(EZValueChangedDelegate del)
	{
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0x1F25F34", Offset = "0x1F24F34", VA = "0x1F25F34", Slot = "178")]
	public virtual void RemoveValueChangedDelegate(EZValueChangedDelegate del)
	{
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0x1F25FB4", Offset = "0x1F24FB4", VA = "0x1F25FB4", Slot = "179")]
	public virtual void OnInput(POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0x1F25FC4", Offset = "0x1F24FC4", VA = "0x1F25FC4", Slot = "180")]
	public virtual void OnInput(ref POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x6000437")]
	[Address(RVA = "0x1F26560", Offset = "0x1F25560", VA = "0x1F26560", Slot = "146")]
	public void DragUpdatePosition(POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x6000438")]
	[Address(RVA = "0x1F265DC", Offset = "0x1F255DC", VA = "0x1F265DC")]
	public void DefaultDragUpdatePosition(POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x6000439")]
	[Address(RVA = "0x1F26870", Offset = "0x1F25870", VA = "0x1F26870")]
	public void SetDragPosUpdater(EZDragDropHelper.UpdateDragPositionDelegate del)
	{
	}

	[Token(Token = "0x600043A")]
	[Address(RVA = "0x1F2688C", Offset = "0x1F2588C", VA = "0x1F2688C", Slot = "147")]
	public void CancelDrag()
	{
	}

	[Token(Token = "0x600043D")]
	[Address(RVA = "0x1F26AB4", Offset = "0x1F25AB4", VA = "0x1F26AB4")]
	public void CancelFinished()
	{
	}

	[Token(Token = "0x600043E")]
	[Address(RVA = "0x1F26AD8", Offset = "0x1F25AD8", VA = "0x1F26AD8")]
	public void DoDefaultCancelDrag()
	{
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0x1F26D20", Offset = "0x1F25D20", VA = "0x1F26D20", Slot = "148")]
	public void OnEZDragDrop_Internal(EZDragDropParams parms)
	{
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0x1F27434", Offset = "0x1F26434", VA = "0x1F27434", Slot = "149")]
	public void AddDragDropDelegate(EZDragDropDelegate del)
	{
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0x1F274CC", Offset = "0x1F264CC", VA = "0x1F274CC", Slot = "150")]
	public void RemoveDragDropDelegate(EZDragDropDelegate del)
	{
	}

	[Token(Token = "0x6000442")]
	[Address(RVA = "0x1F27564", Offset = "0x1F26564", VA = "0x1F27564", Slot = "151")]
	public void SetDragDropDelegate(EZDragDropDelegate del)
	{
	}

	[Token(Token = "0x6000443")]
	[Address(RVA = "0x1F27580", Offset = "0x1F26580", VA = "0x1F27580", Slot = "152")]
	public void SetDragDropInternalDelegate(EZDragDropHelper.DragDrop_InternalDelegate del)
	{
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0x1F2759C", Offset = "0x1F2659C", VA = "0x1F2759C", Slot = "153")]
	public void AddDragDropInternalDelegate(EZDragDropHelper.DragDrop_InternalDelegate del)
	{
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0x1F27634", Offset = "0x1F26634", VA = "0x1F27634", Slot = "154")]
	public void RemoveDragDropInternalDelegate(EZDragDropHelper.DragDrop_InternalDelegate del)
	{
	}

	[Token(Token = "0x6000446")]
	[Address(RVA = "0x1F276CC", Offset = "0x1F266CC", VA = "0x1F276CC", Slot = "155")]
	public EZDragDropHelper.DragDrop_InternalDelegate GetDragDropInternalDelegate()
	{
		return null;
	}

	[Token(Token = "0x6000447")]
	[Address(RVA = "0x1F276E8", Offset = "0x1F266E8", VA = "0x1F276E8", Slot = "181")]
	public virtual int DrawPreStateSelectGUI(int selState, bool inspector)
	{
		return default(int);
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0x1F276F0", Offset = "0x1F266F0", VA = "0x1F276F0", Slot = "182")]
	public virtual int DrawPostStateSelectGUI(int selState)
	{
		return default(int);
	}

	[Token(Token = "0x6000449")]
	[Address(RVA = "0x1F276F8", Offset = "0x1F266F8", VA = "0x1F276F8", Slot = "183")]
	public virtual void DrawPreTransitionUI(int selState, IGUIScriptSelector gui)
	{
	}

	[Token(Token = "0x600044A")]
	[Address(RVA = "0x1F276FC", Offset = "0x1F266FC", VA = "0x1F276FC", Slot = "184")]
	public virtual string[] EnumStateElements()
	{
		return null;
	}

	[Token(Token = "0x600044B")]
	[Address(RVA = "0x1F27808", Offset = "0x1F26808", VA = "0x1F27808", Slot = "185")]
	public virtual EZTransitionList GetTransitions(int index)
	{
		return null;
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0x1F27810", Offset = "0x1F26810", VA = "0x1F27810", Slot = "188")]
	public virtual string GetStateLabel(int index)
	{
		return null;
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x1F27818", Offset = "0x1F26818", VA = "0x1F27818", Slot = "189")]
	public virtual void SetStateLabel(int index, string label)
	{
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0x1F2781C", Offset = "0x1F2681C", VA = "0x1F2781C", Slot = "190")]
	public virtual ASCSEInfo GetStateElementInfo(int stateNum)
	{
		return null;
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0x1F278F4", Offset = "0x1F268F4", VA = "0x1F278F4")]
	protected void UseStateLabel(int index)
	{
	}

	[Token(Token = "0x6000452")]
	[Address(RVA = "0x1F279F4", Offset = "0x1F269F4", VA = "0x1F279F4", Slot = "48")]
	public override void DoMirror()
	{
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0x1F27B3C", Offset = "0x1F26B3C", VA = "0x1F27B3C")]
	protected AutoSpriteControlBase()
	{
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0x1F27CB4", Offset = "0x1F26CB4", VA = "0x1F27CB4", Slot = "115")]
	private GameObject IUIObject.get_gameObject()
	{
		return null;
	}

	[Token(Token = "0x6000455")]
	[Address(RVA = "0x1F27CBC", Offset = "0x1F26CBC", VA = "0x1F27CBC", Slot = "116")]
	private Transform IUIObject.get_transform()
	{
		return null;
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0x1F27CC4", Offset = "0x1F26CC4", VA = "0x1F27CC4", Slot = "118")]
	private string IUIObject.get_name()
	{
		return null;
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0x1F27CCC", Offset = "0x1F26CCC", VA = "0x1F27CCC", Slot = "72")]
	private GameObject ISpritePackable.get_gameObject()
	{
		return null;
	}
}
[Token(Token = "0x200004A")]
public class AutoSpriteControlBaseMirror : SpriteRootMirror
{
	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private string text;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float textOffsetZ;

	[Token(Token = "0x6000458")]
	[Address(RVA = "0x1F27CD4", Offset = "0x1F26CD4", VA = "0x1F27CD4", Slot = "4")]
	public override void Mirror(SpriteRoot s)
	{
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0x1F27D84", Offset = "0x1F26D84", VA = "0x1F27D84", Slot = "6")]
	public override bool DidChange(SpriteRoot s)
	{
		return default(bool);
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0x1F27B34", Offset = "0x1F26B34", VA = "0x1F27B34")]
	public AutoSpriteControlBaseMirror()
	{
	}
}
[Token(Token = "0x200004B")]
[ExecuteInEditMode]
public abstract class ControlBase : MonoBehaviour, IControl, IUIObject, IEZDragDrop
{
	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected ControlBaseMirror mirror;

	[Token(Token = "0x4000275")]
	public const string DittoString = "[\"]";

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string text;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public SpriteText spriteText;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float textOffsetZ;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool includeTextInAutoCollider;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected SpriteText.Anchor_Pos defaultTextAnchor;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	protected SpriteText.Alignment_Type defaultTextAlignment;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected bool deleted;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool detargetOnDisable;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	protected bool customCollider;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public object data;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected bool m_controlIsEnabled;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected IUIContainer container;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected EZInputDelegate inputDelegate;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected EZValueChangedDelegate changeDelegate;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected EZDragDropHelper dragDropHelper;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool isDraggable;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public LayerMask dropMask;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float dragOffset;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public EZAnimation.EASING_TYPE cancelDragEasing;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float cancelDragDuration;

	[Token(Token = "0x170000C7")]
	public virtual string Text
	{
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x1F27EAC", Offset = "0x1F26EAC", VA = "0x1F27EAC", Slot = "71")]
		get
		{
			return null;
		}
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x1F27EB4", Offset = "0x1F26EB4", VA = "0x1F27EB4", Slot = "72")]
		set
		{
		}
	}

	[Token(Token = "0x170000C8")]
	public object Data
	{
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x1F2839C", Offset = "0x1F2739C", VA = "0x1F2839C", Slot = "43")]
		get
		{
			return null;
		}
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x1F283A4", Offset = "0x1F273A4", VA = "0x1F283A4", Slot = "44")]
		set
		{
		}
	}

	[Token(Token = "0x170000C9")]
	public virtual bool IncludeTextInAutoCollider
	{
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x1F283AC", Offset = "0x1F273AC", VA = "0x1F283AC", Slot = "73")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x1F283B4", Offset = "0x1F273B4", VA = "0x1F283B4", Slot = "74")]
		set
		{
		}
	}

	[Token(Token = "0x170000CA")]
	public virtual bool controlIsEnabled
	{
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1F289F0", Offset = "0x1F279F0", VA = "0x1F289F0", Slot = "79")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x1F289F8", Offset = "0x1F279F8", VA = "0x1F289F8", Slot = "80")]
		set
		{
		}
	}

	[Token(Token = "0x170000CB")]
	public virtual bool DetargetOnDisable
	{
		[Token(Token = "0x6000467")]
		[Address(RVA = "0x1F28A04", Offset = "0x1F27A04", VA = "0x1F28A04", Slot = "81")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000468")]
		[Address(RVA = "0x1F28A14", Offset = "0x1F27A14", VA = "0x1F28A14", Slot = "82")]
		set
		{
		}
	}

	[Token(Token = "0x170000CC")]
	public virtual IUIContainer Container
	{
		[Token(Token = "0x600046A")]
		[Address(RVA = "0x1F28A2C", Offset = "0x1F27A2C", VA = "0x1F28A2C", Slot = "83")]
		get
		{
			return null;
		}
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x1F28A34", Offset = "0x1F27A34", VA = "0x1F28A34", Slot = "84")]
		set
		{
		}
	}

	[Token(Token = "0x170000CD")]
	public bool IsDraggable
	{
		[Token(Token = "0x600047B")]
		[Address(RVA = "0x1F29D30", Offset = "0x1F28D30", VA = "0x1F29D30", Slot = "45")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x1F29D38", Offset = "0x1F28D38", VA = "0x1F29D38", Slot = "46")]
		set
		{
		}
	}

	[Token(Token = "0x170000CE")]
	public LayerMask DropMask
	{
		[Token(Token = "0x600047D")]
		[Address(RVA = "0x1F29D44", Offset = "0x1F28D44", VA = "0x1F29D44", Slot = "47")]
		get
		{
			return default(LayerMask);
		}
		[Token(Token = "0x600047E")]
		[Address(RVA = "0x1F29D4C", Offset = "0x1F28D4C", VA = "0x1F29D4C", Slot = "48")]
		set
		{
		}
	}

	[Token(Token = "0x170000CF")]
	public float DragOffset
	{
		[Token(Token = "0x600047F")]
		[Address(RVA = "0x1F29D54", Offset = "0x1F28D54", VA = "0x1F29D54", Slot = "55")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x1F29D5C", Offset = "0x1F28D5C", VA = "0x1F29D5C", Slot = "56")]
		set
		{
		}
	}

	[Token(Token = "0x170000D0")]
	public EZAnimation.EASING_TYPE CancelDragEasing
	{
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x1F29E58", Offset = "0x1F28E58", VA = "0x1F29E58", Slot = "57")]
		get
		{
			return default(EZAnimation.EASING_TYPE);
		}
		[Token(Token = "0x6000482")]
		[Address(RVA = "0x1F29E60", Offset = "0x1F28E60", VA = "0x1F29E60", Slot = "58")]
		set
		{
		}
	}

	[Token(Token = "0x170000D1")]
	public float CancelDragDuration
	{
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x1F29E68", Offset = "0x1F28E68", VA = "0x1F29E68", Slot = "59")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x1F29E70", Offset = "0x1F28E70", VA = "0x1F29E70", Slot = "60")]
		set
		{
		}
	}

	[Token(Token = "0x170000D2")]
	public bool IsDragging
	{
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x1F29E3C", Offset = "0x1F28E3C", VA = "0x1F29E3C", Slot = "49")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x1F29E78", Offset = "0x1F28E78", VA = "0x1F29E78", Slot = "50")]
		set
		{
		}
	}

	[Token(Token = "0x170000D3")]
	public GameObject DropTarget
	{
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x1F29EB8", Offset = "0x1F28EB8", VA = "0x1F29EB8", Slot = "51")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x1F29ED4", Offset = "0x1F28ED4", VA = "0x1F29ED4", Slot = "52")]
		set
		{
		}
	}

	[Token(Token = "0x170000D4")]
	public bool DropHandled
	{
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x1F29EEC", Offset = "0x1F28EEC", VA = "0x1F29EEC", Slot = "53")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x1F29F08", Offset = "0x1F28F08", VA = "0x1F29F08", Slot = "54")]
		set
		{
		}
	}

	[Token(Token = "0x170000D5")]
	public bool UseDefaultCancelDragAnim
	{
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x1F2A028", Offset = "0x1F29028", VA = "0x1F2A028")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x1F2A044", Offset = "0x1F29044", VA = "0x1F2A044")]
		set
		{
		}
	}

	[Token(Token = "0x170000D6")]
	public abstract string[] States
	{
		[Token(Token = "0x600049B")]
		get;
	}

	[Token(Token = "0x170000D7")]
	public abstract EZTransitionList[] Transitions
	{
		[Token(Token = "0x60004A1")]
		get;
		[Token(Token = "0x60004A2")]
		set;
	}

	[Token(Token = "0x6000461")]
	[Address(RVA = "0x1F283CC", Offset = "0x1F273CC", VA = "0x1F283CC", Slot = "75")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0x1F284A4", Offset = "0x1F274A4", VA = "0x1F284A4", Slot = "76")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x1F285C8", Offset = "0x1F275C8", VA = "0x1F285C8", Slot = "77")]
	protected virtual void AddCollider()
	{
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0x1F2868C", Offset = "0x1F2768C", VA = "0x1F2868C", Slot = "78")]
	public virtual void UpdateCollider()
	{
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0x1F28A28", Offset = "0x1F27A28", VA = "0x1F28A28", Slot = "27")]
	public IUIObject GetControl(ref POINTER_INFO ptr)
	{
		return null;
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0x1F28BEC", Offset = "0x1F27BEC", VA = "0x1F28BEC", Slot = "34")]
	public bool RequestContainership(IUIContainer cont)
	{
		return default(bool);
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0x1F28D9C", Offset = "0x1F27D9C", VA = "0x1F28D9C", Slot = "85")]
	public virtual bool GotFocus()
	{
		return default(bool);
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0x1F28DA4", Offset = "0x1F27DA4", VA = "0x1F28DA4", Slot = "86")]
	public virtual void SetInputDelegate(EZInputDelegate del)
	{
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0x1F28DAC", Offset = "0x1F27DAC", VA = "0x1F28DAC", Slot = "87")]
	public virtual void AddInputDelegate(EZInputDelegate del)
	{
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0x1F28E2C", Offset = "0x1F27E2C", VA = "0x1F28E2C", Slot = "88")]
	public virtual void RemoveInputDelegate(EZInputDelegate del)
	{
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0x1F28EAC", Offset = "0x1F27EAC", VA = "0x1F28EAC", Slot = "89")]
	public virtual void SetValueChangedDelegate(EZValueChangedDelegate del)
	{
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0x1F28EB4", Offset = "0x1F27EB4", VA = "0x1F28EB4", Slot = "90")]
	public virtual void AddValueChangedDelegate(EZValueChangedDelegate del)
	{
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0x1F28F34", Offset = "0x1F27F34", VA = "0x1F28F34", Slot = "91")]
	public virtual void RemoveValueChangedDelegate(EZValueChangedDelegate del)
	{
	}

	[Token(Token = "0x6000474")]
	[Address(RVA = "0x1F28FB4", Offset = "0x1F27FB4", VA = "0x1F28FB4", Slot = "92")]
	public virtual void OnInput(POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x6000475")]
	[Address(RVA = "0x1F28FC4", Offset = "0x1F27FC4", VA = "0x1F28FC4", Slot = "93")]
	public virtual void OnInput(ref POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x6000476")]
	[Address(RVA = "0x1F290F4", Offset = "0x1F280F4", VA = "0x1F290F4", Slot = "94")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000477")]
	[Address(RVA = "0x1F290F8", Offset = "0x1F280F8", VA = "0x1F290F8", Slot = "95")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0x1F29210", Offset = "0x1F28210", VA = "0x1F29210", Slot = "96")]
	public virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0x1F2921C", Offset = "0x1F2821C", VA = "0x1F2921C", Slot = "97")]
	public virtual void Copy(IControl ctl)
	{
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0x1F29230", Offset = "0x1F28230", VA = "0x1F29230", Slot = "98")]
	public virtual void Copy(IControl ctl, ControlCopyFlags flags)
	{
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0x1F29F28", Offset = "0x1F28F28", VA = "0x1F29F28", Slot = "61")]
	public void DragUpdatePosition(POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0x1F29FA4", Offset = "0x1F28FA4", VA = "0x1F29FA4")]
	public void DefaultDragUpdatePosition(POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0x1F29FF4", Offset = "0x1F28FF4", VA = "0x1F29FF4")]
	public void SetDragPosUpdater(EZDragDropHelper.UpdateDragPositionDelegate del)
	{
	}

	[Token(Token = "0x600048E")]
	[Address(RVA = "0x1F2A010", Offset = "0x1F29010", VA = "0x1F2A010", Slot = "62")]
	public void CancelDrag()
	{
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0x1F2A064", Offset = "0x1F29064", VA = "0x1F2A064")]
	public void CancelFinished()
	{
	}

	[Token(Token = "0x6000492")]
	[Address(RVA = "0x1F2A080", Offset = "0x1F29080", VA = "0x1F2A080")]
	public void DoDefaultCancelDrag()
	{
	}

	[Token(Token = "0x6000493")]
	[Address(RVA = "0x1F2A098", Offset = "0x1F29098", VA = "0x1F2A098", Slot = "63")]
	public void OnEZDragDrop_Internal(EZDragDropParams parms)
	{
	}

	[Token(Token = "0x6000494")]
	[Address(RVA = "0x1F2A0E8", Offset = "0x1F290E8", VA = "0x1F2A0E8", Slot = "64")]
	public void AddDragDropDelegate(EZDragDropDelegate del)
	{
	}

	[Token(Token = "0x6000495")]
	[Address(RVA = "0x1F2A100", Offset = "0x1F29100", VA = "0x1F2A100", Slot = "65")]
	public void RemoveDragDropDelegate(EZDragDropDelegate del)
	{
	}

	[Token(Token = "0x6000496")]
	[Address(RVA = "0x1F2A118", Offset = "0x1F29118", VA = "0x1F2A118", Slot = "66")]
	public void SetDragDropDelegate(EZDragDropDelegate del)
	{
	}

	[Token(Token = "0x6000497")]
	[Address(RVA = "0x1F2A134", Offset = "0x1F29134", VA = "0x1F2A134", Slot = "67")]
	public void SetDragDropInternalDelegate(EZDragDropHelper.DragDrop_InternalDelegate del)
	{
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0x1F2A150", Offset = "0x1F29150", VA = "0x1F2A150", Slot = "68")]
	public void AddDragDropInternalDelegate(EZDragDropHelper.DragDrop_InternalDelegate del)
	{
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0x1F2A168", Offset = "0x1F29168", VA = "0x1F2A168", Slot = "69")]
	public void RemoveDragDropInternalDelegate(EZDragDropHelper.DragDrop_InternalDelegate del)
	{
	}

	[Token(Token = "0x600049A")]
	[Address(RVA = "0x1F2A180", Offset = "0x1F29180", VA = "0x1F2A180", Slot = "70")]
	public EZDragDropHelper.DragDrop_InternalDelegate GetDragDropInternalDelegate()
	{
		return null;
	}

	[Token(Token = "0x600049C")]
	[Address(RVA = "0x1F2A19C", Offset = "0x1F2919C", VA = "0x1F2A19C", Slot = "100")]
	public virtual int DrawPreStateSelectGUI(int selState, bool inspector)
	{
		return default(int);
	}

	[Token(Token = "0x600049D")]
	[Address(RVA = "0x1F2A1A4", Offset = "0x1F291A4", VA = "0x1F2A1A4", Slot = "101")]
	public virtual int DrawPostStateSelectGUI(int selState)
	{
		return default(int);
	}

	[Token(Token = "0x600049E")]
	[Address(RVA = "0x1F2A1AC", Offset = "0x1F291AC", VA = "0x1F2A1AC", Slot = "102")]
	public virtual void DrawPreTransitionUI(int selState, IGUIScriptSelector gui)
	{
	}

	[Token(Token = "0x600049F")]
	[Address(RVA = "0x1F2A1B0", Offset = "0x1F291B0", VA = "0x1F2A1B0", Slot = "103")]
	public virtual string[] EnumStateElements()
	{
		return null;
	}

	[Token(Token = "0x60004A0")]
	public abstract EZTransitionList GetTransitions(int index);

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0x1F2A1C0", Offset = "0x1F291C0", VA = "0x1F2A1C0", Slot = "107")]
	public virtual string GetStateLabel(int index)
	{
		return null;
	}

	[Token(Token = "0x60004A4")]
	[Address(RVA = "0x1F2A1C8", Offset = "0x1F291C8", VA = "0x1F2A1C8", Slot = "108")]
	public virtual void SetStateLabel(int index, string label)
	{
	}

	[Token(Token = "0x60004A5")]
	[Address(RVA = "0x1F2A1CC", Offset = "0x1F291CC", VA = "0x1F2A1CC", Slot = "109")]
	public virtual ASCSEInfo GetStateElementInfo(int stateNum)
	{
		return null;
	}

	[Token(Token = "0x60004A6")]
	[Address(RVA = "0x1F2A270", Offset = "0x1F29270", VA = "0x1F2A270")]
	protected void UseStateLabel(int index)
	{
	}

	[Token(Token = "0x60004A7")]
	[Address(RVA = "0x1F2A370", Offset = "0x1F29370", VA = "0x1F2A370", Slot = "110")]
	public virtual void DoMirror()
	{
	}

	[Token(Token = "0x60004A8")]
	[Address(RVA = "0x1F2A478", Offset = "0x1F29478", VA = "0x1F2A478", Slot = "111")]
	public virtual void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60004A9")]
	[Address(RVA = "0x1F2A488", Offset = "0x1F29488", VA = "0x1F2A488")]
	protected ControlBase()
	{
	}

	[Token(Token = "0x60004AA")]
	[Address(RVA = "0x1F2A528", Offset = "0x1F29528", VA = "0x1F2A528", Slot = "30")]
	private GameObject IUIObject.get_gameObject()
	{
		return null;
	}

	[Token(Token = "0x60004AB")]
	[Address(RVA = "0x1F2A530", Offset = "0x1F29530", VA = "0x1F2A530", Slot = "31")]
	private Transform IUIObject.get_transform()
	{
		return null;
	}

	[Token(Token = "0x60004AC")]
	[Address(RVA = "0x1F2A538", Offset = "0x1F29538", VA = "0x1F2A538", Slot = "33")]
	private string IUIObject.get_name()
	{
		return null;
	}
}
[Token(Token = "0x200004C")]
public class ControlBaseMirror
{
	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private string text;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float textOffsetZ;

	[Token(Token = "0x60004AD")]
	[Address(RVA = "0x1F2A540", Offset = "0x1F29540", VA = "0x1F2A540", Slot = "4")]
	public virtual void Mirror(ControlBase c)
	{
	}

	[Token(Token = "0x60004AE")]
	[Address(RVA = "0x1F2A564", Offset = "0x1F29564", VA = "0x1F2A564", Slot = "5")]
	public virtual bool DidChange(ControlBase c)
	{
		return default(bool);
	}

	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x1F2A634", Offset = "0x1F29634", VA = "0x1F2A634", Slot = "6")]
	public virtual void Validate(ControlBase c)
	{
	}

	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x1F2A470", Offset = "0x1F29470", VA = "0x1F2A470")]
	public ControlBaseMirror()
	{
	}
}
[Token(Token = "0x200004D")]
public enum EZDragDropEvent
{
	[Token(Token = "0x400028D")]
	Begin,
	[Token(Token = "0x400028E")]
	Update,
	[Token(Token = "0x400028F")]
	DragEnter,
	[Token(Token = "0x4000290")]
	DragExit,
	[Token(Token = "0x4000291")]
	Cancelled,
	[Token(Token = "0x4000292")]
	CancelDone,
	[Token(Token = "0x4000293")]
	Dropped
}
[Token(Token = "0x200004E")]
public struct EZDragDropParams
{
	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public EZDragDropEvent evt;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IUIObject dragObj;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public POINTER_INFO ptr;

	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x1F2A638", Offset = "0x1F29638", VA = "0x1F2A638")]
	public EZDragDropParams(EZDragDropEvent e, IUIObject obj, POINTER_INFO p)
	{
	}
}
[Token(Token = "0x200004F")]
public delegate void EZDragDropDelegate(EZDragDropParams parms);
[Token(Token = "0x2000050")]
public interface IEZDragDrop
{
	[Token(Token = "0x170000D8")]
	object Data
	{
		[Token(Token = "0x60004B6")]
		get;
		[Token(Token = "0x60004B7")]
		set;
	}

	[Token(Token = "0x170000D9")]
	bool IsDraggable
	{
		[Token(Token = "0x60004B8")]
		get;
		[Token(Token = "0x60004B9")]
		set;
	}

	[Token(Token = "0x170000DA")]
	LayerMask DropMask
	{
		[Token(Token = "0x60004BA")]
		get;
		[Token(Token = "0x60004BB")]
		set;
	}

	[Token(Token = "0x170000DB")]
	bool IsDragging
	{
		[Token(Token = "0x60004BC")]
		get;
		[Token(Token = "0x60004BD")]
		set;
	}

	[Token(Token = "0x170000DC")]
	GameObject DropTarget
	{
		[Token(Token = "0x60004BE")]
		get;
		[Token(Token = "0x60004BF")]
		set;
	}

	[Token(Token = "0x170000DD")]
	bool DropHandled
	{
		[Token(Token = "0x60004C0")]
		get;
		[Token(Token = "0x60004C1")]
		set;
	}

	[Token(Token = "0x170000DE")]
	float DragOffset
	{
		[Token(Token = "0x60004C2")]
		get;
		[Token(Token = "0x60004C3")]
		set;
	}

	[Token(Token = "0x170000DF")]
	EZAnimation.EASING_TYPE CancelDragEasing
	{
		[Token(Token = "0x60004C4")]
		get;
		[Token(Token = "0x60004C5")]
		set;
	}

	[Token(Token = "0x170000E0")]
	float CancelDragDuration
	{
		[Token(Token = "0x60004C6")]
		get;
		[Token(Token = "0x60004C7")]
		set;
	}

	[Token(Token = "0x60004C8")]
	void DragUpdatePosition(POINTER_INFO ptr);

	[Token(Token = "0x60004C9")]
	void CancelDrag();

	[Token(Token = "0x60004CA")]
	void OnEZDragDrop_Internal(EZDragDropParams parms);

	[Token(Token = "0x60004CB")]
	void AddDragDropDelegate(EZDragDropDelegate del);

	[Token(Token = "0x60004CC")]
	void RemoveDragDropDelegate(EZDragDropDelegate del);

	[Token(Token = "0x60004CD")]
	void SetDragDropDelegate(EZDragDropDelegate del);

	[Token(Token = "0x60004CE")]
	void SetDragDropInternalDelegate(EZDragDropHelper.DragDrop_InternalDelegate del);

	[Token(Token = "0x60004CF")]
	void AddDragDropInternalDelegate(EZDragDropHelper.DragDrop_InternalDelegate del);

	[Token(Token = "0x60004D0")]
	void RemoveDragDropInternalDelegate(EZDragDropHelper.DragDrop_InternalDelegate del);

	[Token(Token = "0x60004D1")]
	EZDragDropHelper.DragDrop_InternalDelegate GetDragDropInternalDelegate();
}
[Token(Token = "0x2000051")]
public class EZDragDropHelper
{
	[Token(Token = "0x2000052")]
	public delegate void UpdateDragPositionDelegate(POINTER_INFO ptr);

	[Token(Token = "0x2000053")]
	public delegate void DragDrop_InternalDelegate(ref POINTER_INFO ptr);

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public IUIObject host;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected UpdateDragPositionDelegate dragPosUpdateDel;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected DragDrop_InternalDelegate dragDrop_InternalDel;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 touchCompensationOffset;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	protected Vector3 dragOrigin;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected Vector3 dragOriginOffset;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	protected Plane dragPlane;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	protected bool isDragging;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	protected bool isCanceling;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
	protected bool useDefaultCancelDragAnim;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected GameObject dropTarget;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected bool dropHandled;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected EZDragDropDelegate dragDropDelegate;

	[Token(Token = "0x170000E1")]
	private Plane DragPlane
	{
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x1F2A850", Offset = "0x1F29850", VA = "0x1F2A850")]
		get
		{
			return default(Plane);
		}
	}

	[Token(Token = "0x170000E2")]
	public bool UseDefaultCancelDragAnim
	{
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x1F2A85C", Offset = "0x1F2985C", VA = "0x1F2A85C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x1F2A864", Offset = "0x1F29864", VA = "0x1F2A864")]
		set
		{
		}
	}

	[Token(Token = "0x170000E3")]
	public bool IsDragging
	{
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1F2A880", Offset = "0x1F29880", VA = "0x1F2A880")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1F262DC", Offset = "0x1F252DC", VA = "0x1F262DC")]
		set
		{
		}
	}

	[Token(Token = "0x170000E4")]
	public bool IsCanceling
	{
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1F2A888", Offset = "0x1F29888", VA = "0x1F2A888")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000E5")]
	public GameObject DropTarget
	{
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x1F2A890", Offset = "0x1F29890", VA = "0x1F2A890")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1F26348", Offset = "0x1F25348", VA = "0x1F26348")]
		set
		{
		}
	}

	[Token(Token = "0x170000E6")]
	public bool DropHandled
	{
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x1F2A898", Offset = "0x1F29898", VA = "0x1F2A898")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x1F2A8A0", Offset = "0x1F298A0", VA = "0x1F2A8A0")]
		set
		{
		}
	}

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x1F24BCC", Offset = "0x1F23BCC", VA = "0x1F24BCC")]
	public EZDragDropHelper(IUIObject h)
	{
	}

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0x1F27BE8", Offset = "0x1F26BE8", VA = "0x1F27BE8")]
	public EZDragDropHelper()
	{
	}

	[Token(Token = "0x60004D7")]
	[Address(RVA = "0x1F2A870", Offset = "0x1F29870", VA = "0x1F2A870")]
	public void SetDragDropInternalDelegate(DragDrop_InternalDelegate del)
	{
	}

	[Token(Token = "0x60004D8")]
	[Address(RVA = "0x1F275B4", Offset = "0x1F265B4", VA = "0x1F275B4")]
	public void AddDragDropInternalDelegate(DragDrop_InternalDelegate del)
	{
	}

	[Token(Token = "0x60004D9")]
	[Address(RVA = "0x1F2764C", Offset = "0x1F2664C", VA = "0x1F2764C")]
	public void RemoveDragDropInternalDelegate(DragDrop_InternalDelegate del)
	{
	}

	[Token(Token = "0x60004DA")]
	[Address(RVA = "0x1F2A878", Offset = "0x1F29878", VA = "0x1F2A878")]
	public DragDrop_InternalDelegate GetDragDropInternalDelegate()
	{
		return null;
	}

	[Token(Token = "0x60004DE")]
	[Address(RVA = "0x1F26AD0", Offset = "0x1F25AD0", VA = "0x1F26AD0")]
	public void CancelFinished()
	{
	}

	[Token(Token = "0x60004E3")]
	[Address(RVA = "0x1F2A8AC", Offset = "0x1F298AC", VA = "0x1F2A8AC")]
	public void SetDragPosUpdater(UpdateDragPositionDelegate del)
	{
	}

	[Token(Token = "0x60004E4")]
	[Address(RVA = "0x1F2621C", Offset = "0x1F2521C", VA = "0x1F2621C")]
	public void DragUpdatePosition(POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x60004E5")]
	[Address(RVA = "0x1F2662C", Offset = "0x1F2562C", VA = "0x1F2662C")]
	public void DefaultDragUpdatePosition(POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x60004E6")]
	[Address(RVA = "0x1F268A4", Offset = "0x1F258A4", VA = "0x1F268A4")]
	public void CancelDrag()
	{
	}

	[Token(Token = "0x60004E7")]
	[Address(RVA = "0x1F26AF0", Offset = "0x1F25AF0", VA = "0x1F26AF0")]
	public void DoDefaultCancelDrag()
	{
	}

	[Token(Token = "0x60004E8")]
	[Address(RVA = "0x1F2A8B4", Offset = "0x1F298B4", VA = "0x1F2A8B4")]
	protected void FinishCancelDrag(EZAnimation anim)
	{
	}

	[Token(Token = "0x60004E9")]
	[Address(RVA = "0x1F26D70", Offset = "0x1F25D70", VA = "0x1F26D70")]
	public void OnEZDragDrop_Internal(EZDragDropParams parms)
	{
	}

	[Token(Token = "0x60004EA")]
	[Address(RVA = "0x1F2744C", Offset = "0x1F2644C", VA = "0x1F2744C")]
	public void AddDragDropDelegate(EZDragDropDelegate del)
	{
	}

	[Token(Token = "0x60004EB")]
	[Address(RVA = "0x1F274E4", Offset = "0x1F264E4", VA = "0x1F274E4")]
	public void RemoveDragDropDelegate(EZDragDropDelegate del)
	{
	}

	[Token(Token = "0x60004EC")]
	[Address(RVA = "0x1F2A9B0", Offset = "0x1F299B0", VA = "0x1F2A9B0")]
	public void SetDragDropDelegate(EZDragDropDelegate del)
	{
	}
}
[Token(Token = "0x2000054")]
public interface IGUIScriptSelector
{
	[Token(Token = "0x60004F5")]
	MonoBehaviour DrawScriptSelection(MonoBehaviour script, ref string method);
}
[Token(Token = "0x2000055")]
public enum ControlCopyFlags
{
	[Token(Token = "0x40002A5")]
	Appearance = 1,
	[Token(Token = "0x40002A6")]
	Sound = 2,
	[Token(Token = "0x40002A7")]
	Text = 4,
	[Token(Token = "0x40002A8")]
	Data = 8,
	[Token(Token = "0x40002A9")]
	State = 16,
	[Token(Token = "0x40002AA")]
	Transitions = 32,
	[Token(Token = "0x40002AB")]
	Invocation = 64,
	[Token(Token = "0x40002AC")]
	Settings = 128,
	[Token(Token = "0x40002AD")]
	DragDrop = 256,
	[Token(Token = "0x40002AE")]
	All = 65535
}
[Token(Token = "0x2000056")]
public interface IControl
{
	[Token(Token = "0x170000E7")]
	string Text
	{
		[Token(Token = "0x60004F6")]
		get;
		[Token(Token = "0x60004F7")]
		set;
	}

	[Token(Token = "0x170000E8")]
	bool IncludeTextInAutoCollider
	{
		[Token(Token = "0x60004F8")]
		get;
		[Token(Token = "0x60004F9")]
		set;
	}

	[Token(Token = "0x170000E9")]
	EZTransitionList[] Transitions
	{
		[Token(Token = "0x6000502")]
		get;
		[Token(Token = "0x6000503")]
		set;
	}

	[Token(Token = "0x170000EA")]
	object Data
	{
		[Token(Token = "0x6000507")]
		get;
		[Token(Token = "0x6000508")]
		set;
	}

	[Token(Token = "0x60004FA")]
	void UpdateCollider();

	[Token(Token = "0x60004FB")]
	void Copy(IControl c);

	[Token(Token = "0x60004FC")]
	void Copy(IControl c, ControlCopyFlags flags);

	[Token(Token = "0x60004FD")]
	int DrawPreStateSelectGUI(int selState, bool inspector);

	[Token(Token = "0x60004FE")]
	int DrawPostStateSelectGUI(int selState);

	[Token(Token = "0x60004FF")]
	void DrawPreTransitionUI(int selState, IGUIScriptSelector gui);

	[Token(Token = "0x6000500")]
	string[] EnumStateElements();

	[Token(Token = "0x6000501")]
	EZTransitionList GetTransitions(int index);

	[Token(Token = "0x6000504")]
	string GetStateLabel(int index);

	[Token(Token = "0x6000505")]
	void SetStateLabel(int index, string label);

	[Token(Token = "0x6000506")]
	ASCSEInfo GetStateElementInfo(int stateNum);
}
[Token(Token = "0x2000057")]
public delegate void EZKeyboardCommitDelegate(IKeyFocusable control);
[Token(Token = "0x2000058")]
public interface IKeyFocusable
{
	[Token(Token = "0x170000EB")]
	bool resetUponLoading
	{
		[Token(Token = "0x600050D")]
		get;
		[Token(Token = "0x600050E")]
		set;
	}

	[Token(Token = "0x170000EC")]
	string Content
	{
		[Token(Token = "0x6000514")]
		get;
	}

	[Token(Token = "0x170000ED")]
	bool Password
	{
		[Token(Token = "0x6000515")]
		get;
	}

	[Token(Token = "0x600050F")]
	void LostFocus();

	[Token(Token = "0x6000510")]
	string SetInputText(string inputText, ref int insertPt);

	[Token(Token = "0x6000511")]
	string GetInputText(ref KEYBOARD_INFO info);

	[Token(Token = "0x6000512")]
	void Commit();

	[Token(Token = "0x6000513")]
	void SetCommitDelegate(EZKeyboardCommitDelegate del);

	[Token(Token = "0x6000516")]
	void GoUp();

	[Token(Token = "0x6000517")]
	void GoDown();
}
[Token(Token = "0x2000059")]
public interface IPackableControl : ISpritePackable, IControl
{
}
[Token(Token = "0x200005A")]
public interface IUIContainer : IUIObject, IEZDragDrop
{
	[Token(Token = "0x6000518")]
	void AddChild(GameObject go);

	[Token(Token = "0x6000519")]
	void RemoveChild(GameObject go);

	[Token(Token = "0x600051A")]
	void AddSubject(GameObject go);

	[Token(Token = "0x600051B")]
	void RemoveSubject(GameObject go);
}
[Token(Token = "0x200005B")]
public delegate void EZInputDelegate(ref POINTER_INFO ptr);
[Token(Token = "0x200005C")]
public delegate void EZValueChangedDelegate(IUIObject obj);
[Token(Token = "0x200005D")]
public interface IUIObject : IEZDragDrop
{
	[Token(Token = "0x170000EE")]
	bool controlIsEnabled
	{
		[Token(Token = "0x6000524")]
		get;
		[Token(Token = "0x6000525")]
		set;
	}

	[Token(Token = "0x170000EF")]
	bool DetargetOnDisable
	{
		[Token(Token = "0x6000526")]
		get;
		[Token(Token = "0x6000527")]
		set;
	}

	[Token(Token = "0x170000F0")]
	IUIContainer Container
	{
		[Token(Token = "0x6000529")]
		get;
		[Token(Token = "0x600052A")]
		set;
	}

	[Token(Token = "0x170000F1")]
	GameObject gameObject
	{
		[Token(Token = "0x600052B")]
		get;
	}

	[Token(Token = "0x170000F2")]
	Transform transform
	{
		[Token(Token = "0x600052C")]
		get;
	}

	[Token(Token = "0x170000F3")]
	string name
	{
		[Token(Token = "0x600052E")]
		get;
	}

	[Token(Token = "0x6000528")]
	IUIObject GetControl(ref POINTER_INFO ptr);

	[Token(Token = "0x600052D")]
	new string ToString();

	[Token(Token = "0x600052F")]
	bool RequestContainership(IUIContainer cont);

	[Token(Token = "0x6000530")]
	bool GotFocus();

	[Token(Token = "0x6000531")]
	void OnInput(POINTER_INFO ptr);

	[Token(Token = "0x6000532")]
	void SetInputDelegate(EZInputDelegate del);

	[Token(Token = "0x6000533")]
	void AddInputDelegate(EZInputDelegate del);

	[Token(Token = "0x6000534")]
	void RemoveInputDelegate(EZInputDelegate del);

	[Token(Token = "0x6000535")]
	void SetValueChangedDelegate(EZValueChangedDelegate del);

	[Token(Token = "0x6000536")]
	void AddValueChangedDelegate(EZValueChangedDelegate del);

	[Token(Token = "0x6000537")]
	void RemoveValueChangedDelegate(EZValueChangedDelegate del);
}
[Serializable]
[Token(Token = "0x200005E")]
public abstract class UIPanelBase : MonoBehaviour, IUIContainer, IUIObject, IEZDragDrop
{
	[Token(Token = "0x200005F")]
	public delegate void TransitionCompleteDelegate(UIPanelBase panel, EZTransition transition);

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected EZLinkedList<EZLinkedListNode<IUIObject>> uiObjs;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected EZLinkedList<EZLinkedListNode<UIPanelBase>> childPanels;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public bool[] blockInput;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected EZTransition prevTransition;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected int prevTransIndex;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	protected bool m_started;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int index;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool deactivateAllOnDismiss;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	public bool detargetOnDisable;

	[NonSerialized]
	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected Dictionary<int, GameObject> subjects;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected TransitionCompleteDelegate tempTransCompleteDel;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected bool m_controlIsEnabled;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected IUIContainer container;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected EZInputDelegate inputDelegate;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected EZValueChangedDelegate changeDelegate;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected EZDragDropDelegate dragDropDelegate;

	[Token(Token = "0x170000F4")]
	public abstract EZTransitionList Transitions
	{
		[Token(Token = "0x6000538")]
		get;
	}

	[Token(Token = "0x170000F5")]
	public bool IsTransitioning
	{
		[Token(Token = "0x600054D")]
		[Address(RVA = "0x1F1FB94", Offset = "0x1F1EB94", VA = "0x1F1FB94")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000F6")]
	public virtual bool controlIsEnabled
	{
		[Token(Token = "0x600054E")]
		[Address(RVA = "0x1F2D220", Offset = "0x1F2C220", VA = "0x1F2D220", Slot = "64")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600054F")]
		[Address(RVA = "0x1F2D228", Offset = "0x1F2C228", VA = "0x1F2D228", Slot = "65")]
		set
		{
		}
	}

	[Token(Token = "0x170000F7")]
	public virtual bool DetargetOnDisable
	{
		[Token(Token = "0x6000550")]
		[Address(RVA = "0x1F2D234", Offset = "0x1F2C234", VA = "0x1F2D234", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000551")]
		[Address(RVA = "0x1F2D23C", Offset = "0x1F2C23C", VA = "0x1F2D23C", Slot = "67")]
		set
		{
		}
	}

	[Token(Token = "0x170000F8")]
	public virtual IUIContainer Container
	{
		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1F2D24C", Offset = "0x1F2C24C", VA = "0x1F2D24C", Slot = "68")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1F2D254", Offset = "0x1F2C254", VA = "0x1F2D254", Slot = "69")]
		set
		{
		}
	}

	[Token(Token = "0x170000F9")]
	public object Data
	{
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x1F2D8C8", Offset = "0x1F2C8C8", VA = "0x1F2D8C8", Slot = "28")]
		get
		{
			return null;
		}
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x1F2D8D0", Offset = "0x1F2C8D0", VA = "0x1F2D8D0", Slot = "29")]
		set
		{
		}
	}

	[Token(Token = "0x170000FA")]
	public bool IsDraggable
	{
		[Token(Token = "0x6000560")]
		[Address(RVA = "0x1F2D8D4", Offset = "0x1F2C8D4", VA = "0x1F2D8D4", Slot = "30")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x1F2D8DC", Offset = "0x1F2C8DC", VA = "0x1F2D8DC", Slot = "31")]
		set
		{
		}
	}

	[Token(Token = "0x170000FB")]
	public LayerMask DropMask
	{
		[Token(Token = "0x6000562")]
		[Address(RVA = "0x1F2D8E0", Offset = "0x1F2C8E0", VA = "0x1F2D8E0", Slot = "32")]
		get
		{
			return default(LayerMask);
		}
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x1F2D8FC", Offset = "0x1F2C8FC", VA = "0x1F2D8FC", Slot = "33")]
		set
		{
		}
	}

	[Token(Token = "0x170000FC")]
	public float DragOffset
	{
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x1F2D900", Offset = "0x1F2C900", VA = "0x1F2D900", Slot = "40")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x1F2D908", Offset = "0x1F2C908", VA = "0x1F2D908", Slot = "41")]
		set
		{
		}
	}

	[Token(Token = "0x170000FD")]
	public EZAnimation.EASING_TYPE CancelDragEasing
	{
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x1F2D90C", Offset = "0x1F2C90C", VA = "0x1F2D90C", Slot = "42")]
		get
		{
			return default(EZAnimation.EASING_TYPE);
		}
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1F2D914", Offset = "0x1F2C914", VA = "0x1F2D914", Slot = "43")]
		set
		{
		}
	}

	[Token(Token = "0x170000FE")]
	public float CancelDragDuration
	{
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x1F2D918", Offset = "0x1F2C918", VA = "0x1F2D918", Slot = "44")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x1F2D920", Offset = "0x1F2C920", VA = "0x1F2D920", Slot = "45")]
		set
		{
		}
	}

	[Token(Token = "0x170000FF")]
	public bool IsDragging
	{
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1F2D924", Offset = "0x1F2C924", VA = "0x1F2D924", Slot = "34")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x1F2D92C", Offset = "0x1F2C92C", VA = "0x1F2D92C", Slot = "35")]
		set
		{
		}
	}

	[Token(Token = "0x17000100")]
	public GameObject DropTarget
	{
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x1F2D930", Offset = "0x1F2C930", VA = "0x1F2D930", Slot = "36")]
		get
		{
			return null;
		}
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x1F2D938", Offset = "0x1F2C938", VA = "0x1F2D938", Slot = "37")]
		set
		{
		}
	}

	[Token(Token = "0x17000101")]
	public bool DropHandled
	{
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x1F2D93C", Offset = "0x1F2C93C", VA = "0x1F2D93C", Slot = "38")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x1F2D944", Offset = "0x1F2C944", VA = "0x1F2D944", Slot = "39")]
		set
		{
		}
	}

	[Token(Token = "0x6000539")]
	[Address(RVA = "0x1F2AFC4", Offset = "0x1F29FC4", VA = "0x1F2AFC4", Slot = "57")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x600053A")]
	[Address(RVA = "0x1F2B0C4", Offset = "0x1F2A0C4", VA = "0x1F2B0C4", Slot = "58")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x600053B")]
	[Address(RVA = "0x1F2B1A4", Offset = "0x1F2A1A4", VA = "0x1F2B1A4")]
	public void ScanChildren()
	{
	}

	[Token(Token = "0x600053C")]
	[Address(RVA = "0x1F2B788", Offset = "0x1F2A788", VA = "0x1F2B788", Slot = "59")]
	protected virtual void SetupTransitionSubjects()
	{
	}

	[Token(Token = "0x600053D")]
	[Address(RVA = "0x1F2BFFC", Offset = "0x1F2AFFC", VA = "0x1F2BFFC", Slot = "4")]
	public void AddChild(GameObject go)
	{
	}

	[Token(Token = "0x600053E")]
	[Address(RVA = "0x1F2C514", Offset = "0x1F2B514", VA = "0x1F2C514", Slot = "5")]
	public void RemoveChild(GameObject go)
	{
	}

	[Token(Token = "0x600053F")]
	[Address(RVA = "0x1F2CAB0", Offset = "0x1F2BAB0", VA = "0x1F2CAB0")]
	public void MakeChild(GameObject go)
	{
	}

	[Token(Token = "0x6000540")]
	[Address(RVA = "0x1F2C354", Offset = "0x1F2B354", VA = "0x1F2C354", Slot = "6")]
	public void AddSubject(GameObject go)
	{
	}

	[Token(Token = "0x6000541")]
	[Address(RVA = "0x1F2C8F4", Offset = "0x1F2B8F4", VA = "0x1F2C8F4", Slot = "7")]
	public void RemoveSubject(GameObject go)
	{
	}

	[Token(Token = "0x6000542")]
	[Address(RVA = "0x1F2CB04", Offset = "0x1F2BB04", VA = "0x1F2CB04")]
	public string[] GetTransitionNames()
	{
		return null;
	}

	[Token(Token = "0x6000543")]
	[Address(RVA = "0x1F2CC40", Offset = "0x1F2BC40", VA = "0x1F2CC40")]
	public EZTransition GetTransition(int index)
	{
		return null;
	}

	[Token(Token = "0x6000544")]
	[Address(RVA = "0x1F208B0", Offset = "0x1F1F8B0", VA = "0x1F208B0")]
	public EZTransition GetTransition(UIPanelManager.SHOW_MODE transition)
	{
		return null;
	}

	[Token(Token = "0x6000545")]
	[Address(RVA = "0x1F2CD0C", Offset = "0x1F2BD0C", VA = "0x1F2CD0C")]
	public EZTransition GetTransition(string transName)
	{
		return null;
	}

	[Token(Token = "0x6000546")]
	[Address(RVA = "0x1F2CDF4", Offset = "0x1F2BDF4", VA = "0x1F2CDF4", Slot = "60")]
	public virtual void StartTransition(UIPanelManager.SHOW_MODE mode)
	{
	}

	[Token(Token = "0x6000547")]
	[Address(RVA = "0x1F2CF04", Offset = "0x1F2BF04", VA = "0x1F2CF04", Slot = "61")]
	public virtual void StartTransition(string transName)
	{
	}

	[Token(Token = "0x6000548")]
	[Address(RVA = "0x1F2D08C", Offset = "0x1F2C08C", VA = "0x1F2D08C")]
	public void TransitionCompleted(EZTransition transition)
	{
	}

	[Token(Token = "0x6000549")]
	[Address(RVA = "0x1F2D1D4", Offset = "0x1F2C1D4", VA = "0x1F2D1D4", Slot = "62")]
	public virtual void BringIn()
	{
	}

	[Token(Token = "0x600054A")]
	[Address(RVA = "0x1F2D1E8", Offset = "0x1F2C1E8", VA = "0x1F2D1E8", Slot = "63")]
	public virtual void Dismiss()
	{
	}

	[Token(Token = "0x600054B")]
	[Address(RVA = "0x1F2D1FC", Offset = "0x1F2C1FC", VA = "0x1F2D1FC")]
	public static int CompareIndices(UIPanelBase a, UIPanelBase b)
	{
		return default(int);
	}

	[Token(Token = "0x600054C")]
	[Address(RVA = "0x1F1FCA8", Offset = "0x1F1ECA8", VA = "0x1F1FCA8")]
	public void AddTempTransitionDelegate(TransitionCompleteDelegate del)
	{
	}

	[Token(Token = "0x6000552")]
	[Address(RVA = "0x1F2D248", Offset = "0x1F2C248", VA = "0x1F2D248", Slot = "12")]
	public IUIObject GetControl(ref POINTER_INFO ptr)
	{
		return null;
	}

	[Token(Token = "0x6000555")]
	[Address(RVA = "0x1F1F924", Offset = "0x1F1E924", VA = "0x1F1F924", Slot = "19")]
	public bool RequestContainership(IUIContainer cont)
	{
		return default(bool);
	}

	[Token(Token = "0x6000556")]
	[Address(RVA = "0x1F2D564", Offset = "0x1F2C564", VA = "0x1F2D564", Slot = "20")]
	public bool GotFocus()
	{
		return default(bool);
	}

	[Token(Token = "0x6000557")]
	[Address(RVA = "0x1F2D56C", Offset = "0x1F2C56C", VA = "0x1F2D56C", Slot = "70")]
	public virtual void SetInputDelegate(EZInputDelegate del)
	{
	}

	[Token(Token = "0x6000558")]
	[Address(RVA = "0x1F2D574", Offset = "0x1F2C574", VA = "0x1F2D574", Slot = "71")]
	public virtual void AddInputDelegate(EZInputDelegate del)
	{
	}

	[Token(Token = "0x6000559")]
	[Address(RVA = "0x1F2D5F4", Offset = "0x1F2C5F4", VA = "0x1F2D5F4", Slot = "72")]
	public virtual void RemoveInputDelegate(EZInputDelegate del)
	{
	}

	[Token(Token = "0x600055A")]
	[Address(RVA = "0x1F2D674", Offset = "0x1F2C674", VA = "0x1F2D674", Slot = "73")]
	public virtual void SetValueChangedDelegate(EZValueChangedDelegate del)
	{
	}

	[Token(Token = "0x600055B")]
	[Address(RVA = "0x1F2D67C", Offset = "0x1F2C67C", VA = "0x1F2D67C", Slot = "74")]
	public virtual void AddValueChangedDelegate(EZValueChangedDelegate del)
	{
	}

	[Token(Token = "0x600055C")]
	[Address(RVA = "0x1F2D6FC", Offset = "0x1F2C6FC", VA = "0x1F2D6FC", Slot = "75")]
	public virtual void RemoveValueChangedDelegate(EZValueChangedDelegate del)
	{
	}

	[Token(Token = "0x600055D")]
	[Address(RVA = "0x1F2D77C", Offset = "0x1F2C77C", VA = "0x1F2D77C", Slot = "76")]
	public virtual void OnInput(POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x6000570")]
	[Address(RVA = "0x1F2D948", Offset = "0x1F2C948", VA = "0x1F2D948", Slot = "46")]
	public void DragUpdatePosition(POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x6000571")]
	[Address(RVA = "0x1F2D94C", Offset = "0x1F2C94C", VA = "0x1F2D94C", Slot = "47")]
	public void CancelDrag()
	{
	}

	[Token(Token = "0x6000572")]
	[Address(RVA = "0x1F2D950", Offset = "0x1F2C950", VA = "0x1F2D950", Slot = "48")]
	public void OnEZDragDrop_Internal(EZDragDropParams parms)
	{
	}

	[Token(Token = "0x6000573")]
	[Address(RVA = "0x1F2D9B0", Offset = "0x1F2C9B0", VA = "0x1F2D9B0", Slot = "49")]
	public void AddDragDropDelegate(EZDragDropDelegate del)
	{
	}

	[Token(Token = "0x6000574")]
	[Address(RVA = "0x1F2DA30", Offset = "0x1F2CA30", VA = "0x1F2DA30", Slot = "50")]
	public void RemoveDragDropDelegate(EZDragDropDelegate del)
	{
	}

	[Token(Token = "0x6000575")]
	[Address(RVA = "0x1F2DAB0", Offset = "0x1F2CAB0", VA = "0x1F2DAB0", Slot = "51")]
	public void SetDragDropDelegate(EZDragDropDelegate del)
	{
	}

	[Token(Token = "0x6000576")]
	[Address(RVA = "0x1F2DAB8", Offset = "0x1F2CAB8", VA = "0x1F2DAB8", Slot = "52")]
	public void SetDragDropInternalDelegate(EZDragDropHelper.DragDrop_InternalDelegate del)
	{
	}

	[Token(Token = "0x6000577")]
	[Address(RVA = "0x1F2DABC", Offset = "0x1F2CABC", VA = "0x1F2DABC", Slot = "53")]
	public void AddDragDropInternalDelegate(EZDragDropHelper.DragDrop_InternalDelegate del)
	{
	}

	[Token(Token = "0x6000578")]
	[Address(RVA = "0x1F2DAC0", Offset = "0x1F2CAC0", VA = "0x1F2DAC0", Slot = "54")]
	public void RemoveDragDropInternalDelegate(EZDragDropHelper.DragDrop_InternalDelegate del)
	{
	}

	[Token(Token = "0x6000579")]
	[Address(RVA = "0x1F2DAC4", Offset = "0x1F2CAC4", VA = "0x1F2DAC4", Slot = "55")]
	public EZDragDropHelper.DragDrop_InternalDelegate GetDragDropInternalDelegate()
	{
		return null;
	}

	[Token(Token = "0x600057A")]
	[Address(RVA = "0x1F1EAA8", Offset = "0x1F1DAA8", VA = "0x1F1EAA8")]
	protected UIPanelBase()
	{
	}

	[Token(Token = "0x600057B")]
	[Address(RVA = "0x1F2DACC", Offset = "0x1F2CACC", VA = "0x1F2DACC", Slot = "15")]
	private GameObject IUIObject.get_gameObject()
	{
		return null;
	}

	[Token(Token = "0x600057C")]
	[Address(RVA = "0x1F2DAD4", Offset = "0x1F2CAD4", VA = "0x1F2DAD4", Slot = "16")]
	private Transform IUIObject.get_transform()
	{
		return null;
	}

	[Token(Token = "0x600057D")]
	[Address(RVA = "0x1F2DADC", Offset = "0x1F2CADC", VA = "0x1F2DADC", Slot = "18")]
	private string IUIObject.get_name()
	{
		return null;
	}
}
[Token(Token = "0x2000060")]
public class UIScrollKnob : UIButton
{
	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
	protected Vector3 origPos;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
	protected UISlider slider;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
	protected float maxScrollPos;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B4")]
	protected Plane ctrlPlane;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C4")]
	protected Vector2 colliderSizeFactor;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3CC")]
	protected float colliderExtent;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
	private float dist;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D4")]
	private Vector3 inputPoint;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
	private Vector3 newPos;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3EC")]
	private Vector3 prevPoint;

	[Token(Token = "0x6000582")]
	[Address(RVA = "0x1F2DB2C", Offset = "0x1F2CB2C", VA = "0x1F2DB2C", Slot = "12")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000583")]
	[Address(RVA = "0x1F2DB68", Offset = "0x1F2CB68", VA = "0x1F2DB68", Slot = "180")]
	public override void OnInput(ref POINTER_INFO ptr)
	{
	}

	[Token(Token = "0x6000584")]
	[Address(RVA = "0x1F2DF70", Offset = "0x1F2CF70", VA = "0x1F2DF70")]
	public void SetStartPos(Vector3 startPos)
	{
	}

	[Token(Token = "0x6000585")]
	[Address(RVA = "0x1F2DCF0", Offset = "0x1F2CCF0", VA = "0x1F2DCF0")]
	protected Vector3 GetLocalInputPoint(Ray ray)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000586")]
	[Address(RVA = "0x1F2DF80", Offset = "0x1F2CF80", VA = "0x1F2DF80", Slot = "160")]
	public override void Copy(SpriteRoot s, ControlCopyFlags flags)
	{
	}

	[Token(Token = "0x6000587")]
	[Address(RVA = "0x1F2E05C", Offset = "0x1F2D05C", VA = "0x1F2E05C")]
	public void SetColliderSizeFactor(Vector2 csf)
	{
	}

	[Token(Token = "0x6000588")]
	[Address(RVA = "0x1F2E068", Offset = "0x1F2D068", VA = "0x1F2E068", Slot = "162")]
	public override void UpdateCollider()
	{
	}

	[Token(Token = "0x6000589")]
	[Address(RVA = "0x1F2DF38", Offset = "0x1F2CF38", VA = "0x1F2DF38")]
	public float GetScrollPos()
	{
		return default(float);
	}

	[Token(Token = "0x600058A")]
	[Address(RVA = "0x1F2E1B4", Offset = "0x1F2D1B4", VA = "0x1F2E1B4")]
	public void SetPosition(float pos)
	{
	}

	[Token(Token = "0x600058B")]
	[Address(RVA = "0x1F2E260", Offset = "0x1F2D260", VA = "0x1F2E260")]
	public void SetSlider(UISlider s)
	{
	}

	[Token(Token = "0x600058C")]
	[Address(RVA = "0x1F2E268", Offset = "0x1F2D268", VA = "0x1F2E268")]
	public UISlider GetSlider()
	{
		return null;
	}

	[Token(Token = "0x600058D")]
	[Address(RVA = "0x1F2E270", Offset = "0x1F2D270", VA = "0x1F2E270")]
	public void SetMaxScroll(float max)
	{
	}

	[Token(Token = "0x600058E")]
	[Address(RVA = "0x1F2E278", Offset = "0x1F2D278", VA = "0x1F2E278")]
	public void SetupAppearance()
	{
	}

	[Token(Token = "0x600058F")]
	[Address(RVA = "0x1F2E2BC", Offset = "0x1F2D2BC", VA = "0x1F2E2BC")]
	public new static UIScrollKnob Create(string name, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000590")]
	[Address(RVA = "0x1F2E3FC", Offset = "0x1F2D3FC", VA = "0x1F2E3FC")]
	public new static UIScrollKnob Create(string name, Vector3 pos, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x6000591")]
	[Address(RVA = "0x1F2E584", Offset = "0x1F2D584", VA = "0x1F2E584")]
	public UIScrollKnob()
	{
	}
}
[Token(Token = "0x2000061")]
public enum TweenAction
{
	[Token(Token = "0x40002CA")]
	MOVE_X,
	[Token(Token = "0x40002CB")]
	MOVE_Y,
	[Token(Token = "0x40002CC")]
	MOVE_Z,
	[Token(Token = "0x40002CD")]
	MOVE_LOCAL_X,
	[Token(Token = "0x40002CE")]
	MOVE_LOCAL_Y,
	[Token(Token = "0x40002CF")]
	MOVE_LOCAL_Z,
	[Token(Token = "0x40002D0")]
	MOVE_CURVED,
	[Token(Token = "0x40002D1")]
	MOVE_CURVED_LOCAL,
	[Token(Token = "0x40002D2")]
	MOVE_SPLINE,
	[Token(Token = "0x40002D3")]
	MOVE_SPLINE_LOCAL,
	[Token(Token = "0x40002D4")]
	SCALE_X,
	[Token(Token = "0x40002D5")]
	SCALE_Y,
	[Token(Token = "0x40002D6")]
	SCALE_Z,
	[Token(Token = "0x40002D7")]
	ROTATE_X,
	[Token(Token = "0x40002D8")]
	ROTATE_Y,
	[Token(Token = "0x40002D9")]
	ROTATE_Z,
	[Token(Token = "0x40002DA")]
	ROTATE_AROUND,
	[Token(Token = "0x40002DB")]
	ROTATE_AROUND_LOCAL,
	[Token(Token = "0x40002DC")]
	CANVAS_ROTATEAROUND,
	[Token(Token = "0x40002DD")]
	CANVAS_ROTATEAROUND_LOCAL,
	[Token(Token = "0x40002DE")]
	CANVAS_PLAYSPRITE,
	[Token(Token = "0x40002DF")]
	ALPHA,
	[Token(Token = "0x40002E0")]
	TEXT_ALPHA,
	[Token(Token = "0x40002E1")]
	CANVAS_ALPHA,
	[Token(Token = "0x40002E2")]
	CANVASGROUP_ALPHA,
	[Token(Token = "0x40002E3")]
	ALPHA_VERTEX,
	[Token(Token = "0x40002E4")]
	COLOR,
	[Token(Token = "0x40002E5")]
	CALLBACK_COLOR,
	[Token(Token = "0x40002E6")]
	TEXT_COLOR,
	[Token(Token = "0x40002E7")]
	CANVAS_COLOR,
	[Token(Token = "0x40002E8")]
	CANVAS_MOVE_X,
	[Token(Token = "0x40002E9")]
	CANVAS_MOVE_Y,
	[Token(Token = "0x40002EA")]
	CANVAS_MOVE_Z,
	[Token(Token = "0x40002EB")]
	CALLBACK,
	[Token(Token = "0x40002EC")]
	MOVE,
	[Token(Token = "0x40002ED")]
	MOVE_LOCAL,
	[Token(Token = "0x40002EE")]
	MOVE_TO_TRANSFORM,
	[Token(Token = "0x40002EF")]
	ROTATE,
	[Token(Token = "0x40002F0")]
	ROTATE_LOCAL,
	[Token(Token = "0x40002F1")]
	SCALE,
	[Token(Token = "0x40002F2")]
	VALUE3,
	[Token(Token = "0x40002F3")]
	GUI_MOVE,
	[Token(Token = "0x40002F4")]
	GUI_MOVE_MARGIN,
	[Token(Token = "0x40002F5")]
	GUI_SCALE,
	[Token(Token = "0x40002F6")]
	GUI_ALPHA,
	[Token(Token = "0x40002F7")]
	GUI_ROTATE,
	[Token(Token = "0x40002F8")]
	DELAYED_SOUND,
	[Token(Token = "0x40002F9")]
	CANVAS_MOVE,
	[Token(Token = "0x40002FA")]
	CANVAS_SCALE,
	[Token(Token = "0x40002FB")]
	CANVAS_SIZEDELTA
}
[Token(Token = "0x2000062")]
public enum LeanTweenType
{
	[Token(Token = "0x40002FD")]
	notUsed,
	[Token(Token = "0x40002FE")]
	linear,
	[Token(Token = "0x40002FF")]
	easeOutQuad,
	[Token(Token = "0x4000300")]
	easeInQuad,
	[Token(Token = "0x4000301")]
	easeInOutQuad,
	[Token(Token = "0x4000302")]
	easeInCubic,
	[Token(Token = "0x4000303")]
	easeOutCubic,
	[Token(Token = "0x4000304")]
	easeInOutCubic,
	[Token(Token = "0x4000305")]
	easeInQuart,
	[Token(Token = "0x4000306")]
	easeOutQuart,
	[Token(Token = "0x4000307")]
	easeInOutQuart,
	[Token(Token = "0x4000308")]
	easeInQuint,
	[Token(Token = "0x4000309")]
	easeOutQuint,
	[Token(Token = "0x400030A")]
	easeInOutQuint,
	[Token(Token = "0x400030B")]
	easeInSine,
	[Token(Token = "0x400030C")]
	easeOutSine,
	[Token(Token = "0x400030D")]
	easeInOutSine,
	[Token(Token = "0x400030E")]
	easeInExpo,
	[Token(Token = "0x400030F")]
	easeOutExpo,
	[Token(Token = "0x4000310")]
	easeInOutExpo,
	[Token(Token = "0x4000311")]
	easeInCirc,
	[Token(Token = "0x4000312")]
	easeOutCirc,
	[Token(Token = "0x4000313")]
	easeInOutCirc,
	[Token(Token = "0x4000314")]
	easeInBounce,
	[Token(Token = "0x4000315")]
	easeOutBounce,
	[Token(Token = "0x4000316")]
	easeInOutBounce,
	[Token(Token = "0x4000317")]
	easeInBack,
	[Token(Token = "0x4000318")]
	easeOutBack,
	[Token(Token = "0x4000319")]
	easeInOutBack,
	[Token(Token = "0x400031A")]
	easeInElastic,
	[Token(Token = "0x400031B")]
	easeOutElastic,
	[Token(Token = "0x400031C")]
	easeInOutElastic,
	[Token(Token = "0x400031D")]
	easeSpring,
	[Token(Token = "0x400031E")]
	easeShake,
	[Token(Token = "0x400031F")]
	punch,
	[Token(Token = "0x4000320")]
	once,
	[Token(Token = "0x4000321")]
	clamp,
	[Token(Token = "0x4000322")]
	pingPong,
	[Token(Token = "0x4000323")]
	animationCurve
}
[Token(Token = "0x2000063")]
public class LeanTween : MonoBehaviour
{
	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool throwErrors;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static float tau;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static float PI_DIV2;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static LTSeq[] sequences;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static LTDescr[] tweens;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static int[] tweensFinished;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static LTDescr tween;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static int tweenMaxSearch;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private static int maxTweens;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static int maxSequences;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static int frameRendered;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static GameObject _tweenEmpty;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static float dtEstimated;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public static float dtManual;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static float dtActual;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static uint global_counter;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static int i;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private static int j;

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static int finishedCnt;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public static AnimationCurve punch;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static AnimationCurve shake;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static int maxTweenReached;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public static int startSearch;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public static LTDescr d;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static Action<LTEvent>[] eventListeners;

	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static GameObject[] goListeners;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static int eventsMaxSearch;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public static int EVENTS_MAX;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public static int LISTENERS_MAX;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private static int INIT_LISTENERS_MAX;

	[Token(Token = "0x17000102")]
	public static int maxSearch
	{
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x1F2E644", Offset = "0x1F2D644", VA = "0x1F2E644")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000103")]
	public static int maxSimulataneousTweens
	{
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x1F2E69C", Offset = "0x1F2D69C", VA = "0x1F2E69C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000104")]
	public static int tweensRunning
	{
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x1F2E6F4", Offset = "0x1F2D6F4", VA = "0x1F2E6F4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000105")]
	public static GameObject tweenEmpty
	{
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x1F31C5C", Offset = "0x1F30C5C", VA = "0x1F31C5C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000592")]
	[Address(RVA = "0x1F2E58C", Offset = "0x1F2D58C", VA = "0x1F2E58C")]
	public static void init()
	{
	}

	[Token(Token = "0x6000596")]
	[Address(RVA = "0x1F2E5E4", Offset = "0x1F2D5E4", VA = "0x1F2E5E4")]
	public static void init(int maxSimultaneousTweens)
	{
	}

	[Token(Token = "0x6000597")]
	[Address(RVA = "0x1F2E7AC", Offset = "0x1F2D7AC", VA = "0x1F2E7AC")]
	public static void init(int maxSimultaneousTweens, int maxSimultaneousSequences)
	{
	}

	[Token(Token = "0x6000598")]
	[Address(RVA = "0x1F2EBD0", Offset = "0x1F2DBD0", VA = "0x1F2EBD0")]
	public static void reset()
	{
	}

	[Token(Token = "0x6000599")]
	[Address(RVA = "0x1F2ED18", Offset = "0x1F2DD18", VA = "0x1F2ED18")]
	public void Update()
	{
	}

	[Token(Token = "0x600059A")]
	[Address(RVA = "0x1F2F0E0", Offset = "0x1F2E0E0", VA = "0x1F2F0E0")]
	private static void onLevelWasLoaded54(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x600059B")]
	[Address(RVA = "0x1F2F140", Offset = "0x1F2E140", VA = "0x1F2F140")]
	private static void internalOnLevelWasLoaded(int lvl)
	{
	}

	[Token(Token = "0x600059C")]
	[Address(RVA = "0x1F2ED64", Offset = "0x1F2DD64", VA = "0x1F2ED64")]
	public static void update()
	{
	}

	[Token(Token = "0x600059D")]
	[Address(RVA = "0x1F2F494", Offset = "0x1F2E494", VA = "0x1F2F494")]
	public static void removeTween(int i, int uniqueId)
	{
	}

	[Token(Token = "0x600059E")]
	[Address(RVA = "0x1F2F190", Offset = "0x1F2E190", VA = "0x1F2F190")]
	public static void removeTween(int i)
	{
	}

	[Token(Token = "0x600059F")]
	[Address(RVA = "0x1F2F554", Offset = "0x1F2E554", VA = "0x1F2F554")]
	public static Vector3[] add(Vector3[] a, Vector3 b)
	{
		return null;
	}

	[Token(Token = "0x60005A0")]
	[Address(RVA = "0x1F2F6C0", Offset = "0x1F2E6C0", VA = "0x1F2F6C0")]
	public static float closestRot(float from, float to)
	{
		return default(float);
	}

	[Token(Token = "0x60005A1")]
	[Address(RVA = "0x1F2F710", Offset = "0x1F2E710", VA = "0x1F2F710")]
	public static void cancelAll()
	{
	}

	[Token(Token = "0x60005A2")]
	[Address(RVA = "0x1F2F760", Offset = "0x1F2E760", VA = "0x1F2F760")]
	public static void cancelAll(bool callComplete)
	{
	}

	[Token(Token = "0x60005A3")]
	[Address(RVA = "0x1F2F928", Offset = "0x1F2E928", VA = "0x1F2F928")]
	public static void cancel(GameObject gameObject)
	{
	}

	[Token(Token = "0x60005A4")]
	[Address(RVA = "0x1F2F980", Offset = "0x1F2E980", VA = "0x1F2F980")]
	public static void cancel(GameObject gameObject, bool callOnComplete)
	{
	}

	[Token(Token = "0x60005A5")]
	[Address(RVA = "0x1F2FB9C", Offset = "0x1F2EB9C", VA = "0x1F2FB9C")]
	public static void cancel(RectTransform rect)
	{
	}

	[Token(Token = "0x60005A6")]
	[Address(RVA = "0x1F2FC10", Offset = "0x1F2EC10", VA = "0x1F2FC10")]
	public static void cancel(GameObject gameObject, int uniqueId, bool callOnComplete = false)
	{
	}

	[Token(Token = "0x60005A7")]
	[Address(RVA = "0x1F2FE84", Offset = "0x1F2EE84", VA = "0x1F2FE84")]
	public static void cancel(LTRect ltRect, int uniqueId)
	{
	}

	[Token(Token = "0x60005A8")]
	[Address(RVA = "0x1F2FF90", Offset = "0x1F2EF90", VA = "0x1F2FF90")]
	public static void cancel(int uniqueId)
	{
	}

	[Token(Token = "0x60005A9")]
	[Address(RVA = "0x1F2FFE8", Offset = "0x1F2EFE8", VA = "0x1F2FFE8")]
	public static void cancel(int uniqueId, bool callOnComplete)
	{
	}

	[Token(Token = "0x60005AA")]
	[Address(RVA = "0x1F3021C", Offset = "0x1F2F21C", VA = "0x1F3021C")]
	public static LTDescr descr(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x60005AB")]
	[Address(RVA = "0x1F30460", Offset = "0x1F2F460", VA = "0x1F30460")]
	public static LTDescr description(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x60005AC")]
	[Address(RVA = "0x1F304B4", Offset = "0x1F2F4B4", VA = "0x1F304B4")]
	public static LTDescr[] descriptions([Optional] GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x60005AD")]
	[Address(RVA = "0x1F30740", Offset = "0x1F2F740", VA = "0x1F30740")]
	[Obsolete("Use 'pause( id )' instead")]
	public static void pause(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x60005AE")]
	[Address(RVA = "0x1F30794", Offset = "0x1F2F794", VA = "0x1F30794")]
	public static void pause(int uniqueId)
	{
	}

	[Token(Token = "0x60005AF")]
	[Address(RVA = "0x1F3087C", Offset = "0x1F2F87C", VA = "0x1F3087C")]
	public static void pause(GameObject gameObject)
	{
	}

	[Token(Token = "0x60005B0")]
	[Address(RVA = "0x1F309CC", Offset = "0x1F2F9CC", VA = "0x1F309CC")]
	public static void pauseAll()
	{
	}

	[Token(Token = "0x60005B1")]
	[Address(RVA = "0x1F30A90", Offset = "0x1F2FA90", VA = "0x1F30A90")]
	public static void resumeAll()
	{
	}

	[Token(Token = "0x60005B2")]
	[Address(RVA = "0x1F30B54", Offset = "0x1F2FB54", VA = "0x1F30B54")]
	[Obsolete("Use 'resume( id )' instead")]
	public static void resume(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x60005B3")]
	[Address(RVA = "0x1F30BA8", Offset = "0x1F2FBA8", VA = "0x1F30BA8")]
	public static void resume(int uniqueId)
	{
	}

	[Token(Token = "0x60005B4")]
	[Address(RVA = "0x1F30C90", Offset = "0x1F2FC90", VA = "0x1F30C90")]
	public static void resume(GameObject gameObject)
	{
	}

	[Token(Token = "0x60005B5")]
	[Address(RVA = "0x1F30DE0", Offset = "0x1F2FDE0", VA = "0x1F30DE0")]
	public static bool isTweening([Optional] GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x60005B6")]
	[Address(RVA = "0x1F30FCC", Offset = "0x1F2FFCC", VA = "0x1F30FCC")]
	public static bool isTweening(RectTransform rect)
	{
		return default(bool);
	}

	[Token(Token = "0x60005B7")]
	[Address(RVA = "0x1F3103C", Offset = "0x1F3003C", VA = "0x1F3103C")]
	public static bool isTweening(int uniqueId)
	{
		return default(bool);
	}

	[Token(Token = "0x60005B8")]
	[Address(RVA = "0x1F31144", Offset = "0x1F30144", VA = "0x1F31144")]
	public static bool isTweening(LTRect ltRect)
	{
		return default(bool);
	}

	[Token(Token = "0x60005B9")]
	[Address(RVA = "0x1F3124C", Offset = "0x1F3024C", VA = "0x1F3124C")]
	public static void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float arrowSize = 0f, [Optional] Transform arrowTransform)
	{
	}

	[Token(Token = "0x60005BA")]
	[Address(RVA = "0x1F31814", Offset = "0x1F30814", VA = "0x1F31814")]
	public static object logError(string error)
	{
		return null;
	}

	[Token(Token = "0x60005BB")]
	[Address(RVA = "0x1F318B4", Offset = "0x1F308B4", VA = "0x1F318B4")]
	public static LTDescr options(LTDescr seed)
	{
		return null;
	}

	[Token(Token = "0x60005BC")]
	[Address(RVA = "0x1F31924", Offset = "0x1F30924", VA = "0x1F31924")]
	public static LTDescr options()
	{
		return null;
	}

	[Token(Token = "0x60005BE")]
	[Address(RVA = "0x1F31CC4", Offset = "0x1F30CC4", VA = "0x1F31CC4")]
	private static LTDescr pushNewTween(GameObject gameObject, Vector3 to, float time, LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x60005BF")]
	[Address(RVA = "0x1F31DBC", Offset = "0x1F30DBC", VA = "0x1F31DBC")]
	public static LTDescr play(RectTransform rectTransform, Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x60005C0")]
	[Address(RVA = "0x1F31EA8", Offset = "0x1F30EA8", VA = "0x1F31EA8")]
	public static LTDescr alpha(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005C1")]
	[Address(RVA = "0x1F31F6C", Offset = "0x1F30F6C", VA = "0x1F31F6C")]
	public static LTSeq sequence(bool initSequence = true)
	{
		return null;
	}

	[Token(Token = "0x60005C2")]
	[Address(RVA = "0x1F32194", Offset = "0x1F31194", VA = "0x1F32194")]
	public static LTDescr alpha(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005C3")]
	[Address(RVA = "0x1F32244", Offset = "0x1F31244", VA = "0x1F32244")]
	public static LTDescr textAlpha(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005C4")]
	[Address(RVA = "0x1F322E8", Offset = "0x1F312E8", VA = "0x1F322E8")]
	public static LTDescr alphaText(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005C5")]
	[Address(RVA = "0x1F3238C", Offset = "0x1F3138C", VA = "0x1F3238C")]
	public static LTDescr alphaCanvas(CanvasGroup canvasGroup, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005C6")]
	[Address(RVA = "0x1F32430", Offset = "0x1F31430", VA = "0x1F32430")]
	public static LTDescr alphaVertex(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005C7")]
	[Address(RVA = "0x1F324BC", Offset = "0x1F314BC", VA = "0x1F324BC")]
	public static LTDescr color(GameObject gameObject, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005C8")]
	[Address(RVA = "0x1F325B4", Offset = "0x1F315B4", VA = "0x1F325B4")]
	public static LTDescr textColor(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005C9")]
	[Address(RVA = "0x1F3268C", Offset = "0x1F3168C", VA = "0x1F3268C")]
	public static LTDescr colorText(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005CA")]
	[Address(RVA = "0x1F32764", Offset = "0x1F31764", VA = "0x1F32764")]
	public static LTDescr delayedCall(float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x60005CB")]
	[Address(RVA = "0x1F32844", Offset = "0x1F31844", VA = "0x1F32844")]
	public static LTDescr delayedCall(float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x60005CC")]
	[Address(RVA = "0x1F32924", Offset = "0x1F31924", VA = "0x1F32924")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x60005CD")]
	[Address(RVA = "0x1F32A08", Offset = "0x1F31A08", VA = "0x1F32A08")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x60005CE")]
	[Address(RVA = "0x1F32AEC", Offset = "0x1F31AEC", VA = "0x1F32AEC")]
	public static LTDescr destroyAfter(LTRect rect, float delayTime)
	{
		return null;
	}

	[Token(Token = "0x60005CF")]
	[Address(RVA = "0x1F32BDC", Offset = "0x1F31BDC", VA = "0x1F32BDC")]
	public static LTDescr move(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005D0")]
	[Address(RVA = "0x1F32C78", Offset = "0x1F31C78", VA = "0x1F32C78")]
	public static LTDescr move(GameObject gameObject, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005D1")]
	[Address(RVA = "0x1F32D30", Offset = "0x1F31D30", VA = "0x1F32D30")]
	public static LTDescr move(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005D2")]
	[Address(RVA = "0x1F32E70", Offset = "0x1F31E70", VA = "0x1F32E70")]
	public static LTDescr move(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005D3")]
	[Address(RVA = "0x1F32F20", Offset = "0x1F31F20", VA = "0x1F32F20")]
	public static LTDescr move(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005D4")]
	[Address(RVA = "0x1F32FD0", Offset = "0x1F31FD0", VA = "0x1F32FD0")]
	public static LTDescr moveSpline(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005D5")]
	[Address(RVA = "0x1F330B4", Offset = "0x1F320B4", VA = "0x1F330B4")]
	public static LTDescr moveSpline(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005D6")]
	[Address(RVA = "0x1F33164", Offset = "0x1F32164", VA = "0x1F33164")]
	public static LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005D7")]
	[Address(RVA = "0x1F33248", Offset = "0x1F32248", VA = "0x1F33248")]
	public static LTDescr move(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005D8")]
	[Address(RVA = "0x1F332F8", Offset = "0x1F322F8", VA = "0x1F332F8")]
	public static LTDescr moveMargin(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005D9")]
	[Address(RVA = "0x1F333A8", Offset = "0x1F323A8", VA = "0x1F333A8")]
	public static LTDescr moveX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005DA")]
	[Address(RVA = "0x1F33434", Offset = "0x1F32434", VA = "0x1F33434")]
	public static LTDescr moveY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005DB")]
	[Address(RVA = "0x1F334C0", Offset = "0x1F324C0", VA = "0x1F334C0")]
	public static LTDescr moveZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005DC")]
	[Address(RVA = "0x1F3354C", Offset = "0x1F3254C", VA = "0x1F3354C")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005DD")]
	[Address(RVA = "0x1F335E8", Offset = "0x1F325E8", VA = "0x1F335E8")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005DE")]
	[Address(RVA = "0x1F33728", Offset = "0x1F32728", VA = "0x1F33728")]
	public static LTDescr moveLocalX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005DF")]
	[Address(RVA = "0x1F337B4", Offset = "0x1F327B4", VA = "0x1F337B4")]
	public static LTDescr moveLocalY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005E0")]
	[Address(RVA = "0x1F33840", Offset = "0x1F32840", VA = "0x1F33840")]
	public static LTDescr moveLocalZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005E1")]
	[Address(RVA = "0x1F338CC", Offset = "0x1F328CC", VA = "0x1F338CC")]
	public static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005E2")]
	[Address(RVA = "0x1F3397C", Offset = "0x1F3297C", VA = "0x1F3397C")]
	public static LTDescr moveLocal(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005E3")]
	[Address(RVA = "0x1F33A2C", Offset = "0x1F32A2C", VA = "0x1F33A2C")]
	public static LTDescr move(GameObject gameObject, Transform to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005E4")]
	[Address(RVA = "0x1F33B10", Offset = "0x1F32B10", VA = "0x1F33B10")]
	public static LTDescr rotate(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005E5")]
	[Address(RVA = "0x1F33BAC", Offset = "0x1F32BAC", VA = "0x1F33BAC")]
	public static LTDescr rotate(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005E6")]
	[Address(RVA = "0x1F33C50", Offset = "0x1F32C50", VA = "0x1F33C50")]
	public static LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005E7")]
	[Address(RVA = "0x1F33CEC", Offset = "0x1F32CEC", VA = "0x1F33CEC")]
	public static LTDescr rotateX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005E8")]
	[Address(RVA = "0x1F33D78", Offset = "0x1F32D78", VA = "0x1F33D78")]
	public static LTDescr rotateY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005E9")]
	[Address(RVA = "0x1F33E04", Offset = "0x1F32E04", VA = "0x1F33E04")]
	public static LTDescr rotateZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005EA")]
	[Address(RVA = "0x1F33E90", Offset = "0x1F32E90", VA = "0x1F33E90")]
	public static LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x60005EB")]
	[Address(RVA = "0x1F33F50", Offset = "0x1F32F50", VA = "0x1F33F50")]
	public static LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x60005EC")]
	[Address(RVA = "0x1F34010", Offset = "0x1F33010", VA = "0x1F34010")]
	public static LTDescr scale(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005ED")]
	[Address(RVA = "0x1F340AC", Offset = "0x1F330AC", VA = "0x1F340AC")]
	public static LTDescr scale(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005EE")]
	[Address(RVA = "0x1F3415C", Offset = "0x1F3315C", VA = "0x1F3415C")]
	public static LTDescr scaleX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005EF")]
	[Address(RVA = "0x1F341E8", Offset = "0x1F331E8", VA = "0x1F341E8")]
	public static LTDescr scaleY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005F0")]
	[Address(RVA = "0x1F34274", Offset = "0x1F33274", VA = "0x1F34274")]
	public static LTDescr scaleZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005F1")]
	[Address(RVA = "0x1F34300", Offset = "0x1F33300", VA = "0x1F34300")]
	public static LTDescr value(GameObject gameObject, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005F2")]
	[Address(RVA = "0x1F343B0", Offset = "0x1F333B0", VA = "0x1F343B0")]
	public static LTDescr value(float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005F3")]
	[Address(RVA = "0x1F34464", Offset = "0x1F33464", VA = "0x1F34464")]
	public static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005F4")]
	[Address(RVA = "0x1F3453C", Offset = "0x1F3353C", VA = "0x1F3453C")]
	public static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005F5")]
	[Address(RVA = "0x1F3460C", Offset = "0x1F3360C", VA = "0x1F3460C")]
	public static LTDescr value(GameObject gameObject, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005F6")]
	[Address(RVA = "0x1F34748", Offset = "0x1F33748", VA = "0x1F34748")]
	public static LTDescr value(GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005F7")]
	[Address(RVA = "0x1F3482C", Offset = "0x1F3382C", VA = "0x1F3482C")]
	public static LTDescr value(GameObject gameObject, Action<float, float> callOnUpdateRatio, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005F8")]
	[Address(RVA = "0x1F34910", Offset = "0x1F33910", VA = "0x1F34910")]
	public static LTDescr value(GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005F9")]
	[Address(RVA = "0x1F34A44", Offset = "0x1F33A44", VA = "0x1F34A44")]
	public static LTDescr value(GameObject gameObject, Action<Color, object> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005FA")]
	[Address(RVA = "0x1F34B78", Offset = "0x1F33B78", VA = "0x1F34B78")]
	public static LTDescr value(GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005FB")]
	[Address(RVA = "0x1F34C6C", Offset = "0x1F33C6C", VA = "0x1F34C6C")]
	public static LTDescr value(GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005FC")]
	[Address(RVA = "0x1F34D70", Offset = "0x1F33D70", VA = "0x1F34D70")]
	public static LTDescr value(GameObject gameObject, Action<float, object> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60005FD")]
	[Address(RVA = "0x1F34E58", Offset = "0x1F33E58", VA = "0x1F34E58")]
	public static LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x60005FE")]
	[Address(RVA = "0x1F34F3C", Offset = "0x1F33F3C", VA = "0x1F34F3C")]
	public static LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x60005FF")]
	[Address(RVA = "0x1F35024", Offset = "0x1F34024", VA = "0x1F35024")]
	public static LTDescr move(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000600")]
	[Address(RVA = "0x1F350E8", Offset = "0x1F340E8", VA = "0x1F350E8")]
	public static LTDescr moveX(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000601")]
	[Address(RVA = "0x1F3519C", Offset = "0x1F3419C", VA = "0x1F3519C")]
	public static LTDescr moveY(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000602")]
	[Address(RVA = "0x1F35250", Offset = "0x1F34250", VA = "0x1F35250")]
	public static LTDescr moveZ(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000603")]
	[Address(RVA = "0x1F35304", Offset = "0x1F34304", VA = "0x1F35304")]
	public static LTDescr rotate(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000604")]
	[Address(RVA = "0x1F35404", Offset = "0x1F34404", VA = "0x1F35404")]
	public static LTDescr rotate(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000605")]
	[Address(RVA = "0x1F35514", Offset = "0x1F34514", VA = "0x1F35514")]
	public static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000606")]
	[Address(RVA = "0x1F355FC", Offset = "0x1F345FC", VA = "0x1F355FC")]
	public static LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000607")]
	[Address(RVA = "0x1F356E4", Offset = "0x1F346E4", VA = "0x1F356E4")]
	public static LTDescr scale(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000608")]
	[Address(RVA = "0x1F357A8", Offset = "0x1F347A8", VA = "0x1F357A8")]
	public static LTDescr size(RectTransform rectTrans, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000609")]
	[Address(RVA = "0x1F35868", Offset = "0x1F34868", VA = "0x1F35868")]
	public static LTDescr alpha(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600060A")]
	[Address(RVA = "0x1F3591C", Offset = "0x1F3491C", VA = "0x1F3591C")]
	public static LTDescr color(RectTransform rectTrans, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x600060B")]
	[Address(RVA = "0x1F35A04", Offset = "0x1F34A04", VA = "0x1F35A04")]
	public static float tweenOnCurve(LTDescr tweenDescr, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x600060C")]
	[Address(RVA = "0x1F35A4C", Offset = "0x1F34A4C", VA = "0x1F35A4C")]
	public static Vector3 tweenOnCurveVector(LTDescr tweenDescr, float ratioPassed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600060D")]
	[Address(RVA = "0x1F35B24", Offset = "0x1F34B24", VA = "0x1F35B24")]
	public static float easeOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x600060E")]
	[Address(RVA = "0x1F35B3C", Offset = "0x1F34B3C", VA = "0x1F35B3C")]
	public static float easeInQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x600060F")]
	[Address(RVA = "0x1F35B4C", Offset = "0x1F34B4C", VA = "0x1F35B4C")]
	public static float easeInOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x6000610")]
	[Address(RVA = "0x1F35B9C", Offset = "0x1F34B9C", VA = "0x1F35B9C")]
	public static Vector3 easeInOutQuadOpt(Vector3 start, Vector3 diff, float ratioPassed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000611")]
	[Address(RVA = "0x1F35C28", Offset = "0x1F34C28", VA = "0x1F35C28")]
	public static float linear(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000612")]
	[Address(RVA = "0x1F35C4C", Offset = "0x1F34C4C", VA = "0x1F35C4C")]
	public static float clerp(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000613")]
	[Address(RVA = "0x1F35CB0", Offset = "0x1F34CB0", VA = "0x1F35CB0")]
	public static float spring(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000614")]
	[Address(RVA = "0x1F35D60", Offset = "0x1F34D60", VA = "0x1F35D60")]
	public static float easeInQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000615")]
	[Address(RVA = "0x1F35D74", Offset = "0x1F34D74", VA = "0x1F35D74")]
	public static float easeOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000616")]
	[Address(RVA = "0x1F35D90", Offset = "0x1F34D90", VA = "0x1F35D90")]
	public static float easeInOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000617")]
	[Address(RVA = "0x1F35DE4", Offset = "0x1F34DE4", VA = "0x1F35DE4")]
	public static float easeInOutQuadOpt2(float start, float diffBy2, float val, float val2)
	{
		return default(float);
	}

	[Token(Token = "0x6000618")]
	[Address(RVA = "0x1F35E1C", Offset = "0x1F34E1C", VA = "0x1F35E1C")]
	public static float easeInCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000619")]
	[Address(RVA = "0x1F35E34", Offset = "0x1F34E34", VA = "0x1F35E34")]
	public static float easeOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600061A")]
	[Address(RVA = "0x1F35E5C", Offset = "0x1F34E5C", VA = "0x1F35E5C")]
	public static float easeInOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600061B")]
	[Address(RVA = "0x1F35EB4", Offset = "0x1F34EB4", VA = "0x1F35EB4")]
	public static float easeInQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600061C")]
	[Address(RVA = "0x1F35ED0", Offset = "0x1F34ED0", VA = "0x1F35ED0")]
	public static float easeOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600061D")]
	[Address(RVA = "0x1F35EF8", Offset = "0x1F34EF8", VA = "0x1F35EF8")]
	public static float easeInOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600061E")]
	[Address(RVA = "0x1F35F54", Offset = "0x1F34F54", VA = "0x1F35F54")]
	public static float easeInQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600061F")]
	[Address(RVA = "0x1F35F74", Offset = "0x1F34F74", VA = "0x1F35F74")]
	public static float easeOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000620")]
	[Address(RVA = "0x1F35FA4", Offset = "0x1F34FA4", VA = "0x1F35FA4")]
	public static float easeInOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000621")]
	[Address(RVA = "0x1F3600C", Offset = "0x1F3500C", VA = "0x1F3600C")]
	public static float easeInSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000622")]
	[Address(RVA = "0x1F36044", Offset = "0x1F35044", VA = "0x1F36044")]
	public static float easeOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000623")]
	[Address(RVA = "0x1F36078", Offset = "0x1F35078", VA = "0x1F36078")]
	public static float easeInOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000624")]
	[Address(RVA = "0x1F360BC", Offset = "0x1F350BC", VA = "0x1F360BC")]
	public static float easeInExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000625")]
	[Address(RVA = "0x1F360F4", Offset = "0x1F350F4", VA = "0x1F360F4")]
	public static float easeOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000626")]
	[Address(RVA = "0x1F3612C", Offset = "0x1F3512C", VA = "0x1F3612C")]
	public static float easeInOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000627")]
	[Address(RVA = "0x1F3619C", Offset = "0x1F3519C", VA = "0x1F3619C")]
	public static float easeInCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000628")]
	[Address(RVA = "0x1F361C4", Offset = "0x1F351C4", VA = "0x1F361C4")]
	public static float easeOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000629")]
	[Address(RVA = "0x1F361EC", Offset = "0x1F351EC", VA = "0x1F361EC")]
	public static float easeInOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600062A")]
	[Address(RVA = "0x1F36240", Offset = "0x1F35240", VA = "0x1F36240")]
	public static float easeInBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600062B")]
	[Address(RVA = "0x1F362C8", Offset = "0x1F352C8", VA = "0x1F362C8")]
	public static float easeOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600062C")]
	[Address(RVA = "0x1F36390", Offset = "0x1F35390", VA = "0x1F36390")]
	public static float easeInOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600062D")]
	[Address(RVA = "0x1F36444", Offset = "0x1F35444", VA = "0x1F36444")]
	public static float easeInBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x600062E")]
	[Address(RVA = "0x1F36478", Offset = "0x1F35478", VA = "0x1F36478")]
	public static float easeOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x600062F")]
	[Address(RVA = "0x1F364B8", Offset = "0x1F354B8", VA = "0x1F364B8")]
	public static float easeInOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000630")]
	[Address(RVA = "0x1F36550", Offset = "0x1F35550", VA = "0x1F36550")]
	public static float easeInElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000631")]
	[Address(RVA = "0x1F36630", Offset = "0x1F35630", VA = "0x1F36630")]
	public static float easeOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000632")]
	[Address(RVA = "0x1F36704", Offset = "0x1F35704", VA = "0x1F36704")]
	public static float easeInOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000633")]
	[Address(RVA = "0x1F36864", Offset = "0x1F35864", VA = "0x1F36864")]
	public static void addListener(int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x6000634")]
	[Address(RVA = "0x1F368CC", Offset = "0x1F358CC", VA = "0x1F368CC")]
	public static void addListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x6000635")]
	[Address(RVA = "0x1F36CA8", Offset = "0x1F35CA8", VA = "0x1F36CA8")]
	public static bool removeListener(int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x6000636")]
	[Address(RVA = "0x1F36F0C", Offset = "0x1F35F0C", VA = "0x1F36F0C")]
	public static bool removeListener(int eventId)
	{
		return default(bool);
	}

	[Token(Token = "0x6000637")]
	[Address(RVA = "0x1F36D10", Offset = "0x1F35D10", VA = "0x1F36D10")]
	public static bool removeListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x6000638")]
	[Address(RVA = "0x1F36FC0", Offset = "0x1F35FC0", VA = "0x1F36FC0")]
	public static void dispatchEvent(int eventId)
	{
	}

	[Token(Token = "0x6000639")]
	[Address(RVA = "0x1F37018", Offset = "0x1F36018", VA = "0x1F37018")]
	public static void dispatchEvent(int eventId, object data)
	{
	}

	[Token(Token = "0x600063A")]
	[Address(RVA = "0x1F371E4", Offset = "0x1F361E4", VA = "0x1F371E4")]
	public LeanTween()
	{
	}
}
[Token(Token = "0x2000064")]
public class LTUtility
{
	[Token(Token = "0x600063C")]
	[Address(RVA = "0x1F37754", Offset = "0x1F36754", VA = "0x1F37754")]
	public static Vector3[] reverse(Vector3[] arr)
	{
		return null;
	}

	[Token(Token = "0x600063D")]
	[Address(RVA = "0x1F377F0", Offset = "0x1F367F0", VA = "0x1F377F0")]
	public LTUtility()
	{
	}
}
[Token(Token = "0x2000065")]
public class LTBezier
{
	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float length;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private Vector3 a;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 aa;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 bb;

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 cc;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float len;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float[] arcLengths;

	[Token(Token = "0x600063E")]
	[Address(RVA = "0x1F377F8", Offset = "0x1F367F8", VA = "0x1F377F8")]
	public LTBezier(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float precision)
	{
	}

	[Token(Token = "0x600063F")]
	[Address(RVA = "0x1F37AC4", Offset = "0x1F36AC4", VA = "0x1F37AC4")]
	private float map(float u)
	{
		return default(float);
	}

	[Token(Token = "0x6000640")]
	[Address(RVA = "0x1F37A6C", Offset = "0x1F36A6C", VA = "0x1F37A6C")]
	private Vector3 bezierPoint(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000641")]
	[Address(RVA = "0x1F37BE4", Offset = "0x1F36BE4", VA = "0x1F37BE4")]
	public Vector3 point(float t)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x2000066")]
public class LTBezierPath
{
	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3[] pts;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float length;

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool orientToPath;

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool orientToPath2d;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private LTBezier[] beziers;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float[] lengthRatio;

	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int currentBezier;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int previousBezier;

	[Token(Token = "0x17000106")]
	public float distance
	{
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x1F37F74", Offset = "0x1F36F74", VA = "0x1F37F74")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000642")]
	[Address(RVA = "0x1F37BFC", Offset = "0x1F36BFC", VA = "0x1F37BFC")]
	public LTBezierPath()
	{
	}

	[Token(Token = "0x6000643")]
	[Address(RVA = "0x1F37C04", Offset = "0x1F36C04", VA = "0x1F37C04")]
	public LTBezierPath(Vector3[] pts_)
	{
	}

	[Token(Token = "0x6000644")]
	[Address(RVA = "0x1F37C30", Offset = "0x1F36C30", VA = "0x1F37C30")]
	public void setPoints(Vector3[] pts_)
	{
	}

	[Token(Token = "0x6000646")]
	[Address(RVA = "0x1F37F7C", Offset = "0x1F36F7C", VA = "0x1F37F7C")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000647")]
	[Address(RVA = "0x1F38040", Offset = "0x1F37040", VA = "0x1F38040")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000648")]
	[Address(RVA = "0x1F380F4", Offset = "0x1F370F4", VA = "0x1F380F4")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000649")]
	[Address(RVA = "0x1F381A8", Offset = "0x1F371A8", VA = "0x1F381A8")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600064A")]
	[Address(RVA = "0x1F38214", Offset = "0x1F37214", VA = "0x1F38214")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x600064B")]
	[Address(RVA = "0x1F382B0", Offset = "0x1F372B0", VA = "0x1F382B0")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600064C")]
	[Address(RVA = "0x1F3831C", Offset = "0x1F3731C", VA = "0x1F3831C")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x600064D")]
	[Address(RVA = "0x1F38444", Offset = "0x1F37444", VA = "0x1F38444")]
	public float getRationInOneRange(float ratio)
	{
		return default(float);
	}

	[Token(Token = "0x600064E")]
	[Address(RVA = "0x1F3847C", Offset = "0x1F3747C", VA = "0x1F3847C")]
	public void gizmoDraw(float t = -1f)
	{
	}
}
[Serializable]
[Token(Token = "0x2000067")]
public class LTSpline
{
	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int DISTANCE_COUNT;

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int SUBLINE_COUNT;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float distance;

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public bool constantSpeed;

	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3[] pts;

	[NonSerialized]
	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3[] ptsAdj;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int ptsAdjLength;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool orientToPath;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool orientToPath2d;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int numSections;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int currPt;

	[Token(Token = "0x600064F")]
	[Address(RVA = "0x1F3855C", Offset = "0x1F3755C", VA = "0x1F3855C")]
	public LTSpline(Vector3[] pts)
	{
	}

	[Token(Token = "0x6000650")]
	[Address(RVA = "0x1F3895C", Offset = "0x1F3795C", VA = "0x1F3895C")]
	public LTSpline(Vector3[] pts, bool constantSpeed)
	{
	}

	[Token(Token = "0x6000651")]
	[Address(RVA = "0x1F38594", Offset = "0x1F37594", VA = "0x1F38594")]
	private void init(Vector3[] pts, bool constantSpeed)
	{
	}

	[Token(Token = "0x6000652")]
	[Address(RVA = "0x1F38BA0", Offset = "0x1F37BA0", VA = "0x1F38BA0")]
	public Vector3 map(float u)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000653")]
	[Address(RVA = "0x1F3899C", Offset = "0x1F3799C", VA = "0x1F3899C")]
	public Vector3 interp(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000654")]
	[Address(RVA = "0x1F38C98", Offset = "0x1F37C98", VA = "0x1F38C98")]
	public float ratioAtPoint(Vector3 pt)
	{
		return default(float);
	}

	[Token(Token = "0x6000655")]
	[Address(RVA = "0x1F38DC4", Offset = "0x1F37DC4", VA = "0x1F38DC4")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000656")]
	[Address(RVA = "0x1F38DDC", Offset = "0x1F37DDC", VA = "0x1F38DDC")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000657")]
	[Address(RVA = "0x1F38E90", Offset = "0x1F37E90", VA = "0x1F38E90")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000658")]
	[Address(RVA = "0x1F38FC8", Offset = "0x1F37FC8", VA = "0x1F38FC8")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000659")]
	[Address(RVA = "0x1F39034", Offset = "0x1F38034", VA = "0x1F39034")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x600065A")]
	[Address(RVA = "0x1F390D0", Offset = "0x1F380D0", VA = "0x1F390D0")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600065B")]
	[Address(RVA = "0x1F3913C", Offset = "0x1F3813C", VA = "0x1F3913C")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x600065C")]
	[Address(RVA = "0x1F391FC", Offset = "0x1F381FC", VA = "0x1F391FC")]
	public void gizmoDraw(float t = -1f)
	{
	}

	[Token(Token = "0x600065D")]
	[Address(RVA = "0x1F392B0", Offset = "0x1F382B0", VA = "0x1F392B0")]
	public void drawGizmo(Color color)
	{
	}

	[Token(Token = "0x600065E")]
	[Address(RVA = "0x1F393FC", Offset = "0x1F383FC", VA = "0x1F393FC")]
	public static void drawGizmo(Transform[] arr, Color color)
	{
	}

	[Token(Token = "0x600065F")]
	[Address(RVA = "0x1F39628", Offset = "0x1F38628", VA = "0x1F39628")]
	public static void drawLine(Transform[] arr, float width, Color color)
	{
	}

	[Token(Token = "0x6000660")]
	[Address(RVA = "0x1F39638", Offset = "0x1F38638", VA = "0x1F39638")]
	public void drawLinesGLLines(Material outlineMaterial, Color color, float width)
	{
	}

	[Token(Token = "0x6000661")]
	[Address(RVA = "0x1F39800", Offset = "0x1F38800", VA = "0x1F39800")]
	public Vector3[] generateVectors()
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000068")]
public class LTRect
{
	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Rect _rect;

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float alpha;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float rotation;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 pivot;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector2 margin;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Rect relativeRect;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool rotateEnabled;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	[HideInInspector]
	public bool rotateFinished;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	public bool alphaEnabled;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string labelStr;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public LTGUI.Element_Type type;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GUIStyle style;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool useColor;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Color color;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool fontScaleToFit;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	public bool useSimpleScale;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
	public bool sizeByHeight;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Texture texture;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int _id;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[HideInInspector]
	public int counter;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool colorTouched;

	[Token(Token = "0x17000107")]
	public bool hasInitiliazed
	{
		[Token(Token = "0x6000668")]
		[Address(RVA = "0x1F39F04", Offset = "0x1F38F04", VA = "0x1F39F04")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000108")]
	public int id
	{
		[Token(Token = "0x6000669")]
		[Address(RVA = "0x1F39F14", Offset = "0x1F38F14", VA = "0x1F39F14")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000109")]
	public float x
	{
		[Token(Token = "0x600066D")]
		[Address(RVA = "0x1F39F28", Offset = "0x1F38F28", VA = "0x1F39F28")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600066E")]
		[Address(RVA = "0x1F39F30", Offset = "0x1F38F30", VA = "0x1F39F30")]
		set
		{
		}
	}

	[Token(Token = "0x1700010A")]
	public float y
	{
		[Token(Token = "0x600066F")]
		[Address(RVA = "0x1F39F38", Offset = "0x1F38F38", VA = "0x1F39F38")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000670")]
		[Address(RVA = "0x1F39F40", Offset = "0x1F38F40", VA = "0x1F39F40")]
		set
		{
		}
	}

	[Token(Token = "0x1700010B")]
	public float width
	{
		[Token(Token = "0x6000671")]
		[Address(RVA = "0x1F39F48", Offset = "0x1F38F48", VA = "0x1F39F48")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000672")]
		[Address(RVA = "0x1F39F50", Offset = "0x1F38F50", VA = "0x1F39F50")]
		set
		{
		}
	}

	[Token(Token = "0x1700010C")]
	public float height
	{
		[Token(Token = "0x6000673")]
		[Address(RVA = "0x1F39F58", Offset = "0x1F38F58", VA = "0x1F39F58")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000674")]
		[Address(RVA = "0x1F39F60", Offset = "0x1F38F60", VA = "0x1F39F60")]
		set
		{
		}
	}

	[Token(Token = "0x1700010D")]
	public Rect rect
	{
		[Token(Token = "0x6000675")]
		[Address(RVA = "0x1F39F68", Offset = "0x1F38F68", VA = "0x1F39F68")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x6000676")]
		[Address(RVA = "0x1F3A138", Offset = "0x1F39138", VA = "0x1F3A138")]
		set
		{
		}
	}

	[Token(Token = "0x6000663")]
	[Address(RVA = "0x1F39A2C", Offset = "0x1F38A2C", VA = "0x1F39A2C")]
	public LTRect()
	{
	}

	[Token(Token = "0x6000664")]
	[Address(RVA = "0x1F39AF4", Offset = "0x1F38AF4", VA = "0x1F39AF4")]
	public LTRect(Rect rect)
	{
	}

	[Token(Token = "0x6000665")]
	[Address(RVA = "0x1F39B5C", Offset = "0x1F38B5C", VA = "0x1F39B5C")]
	public LTRect(float x, float y, float width, float height)
	{
	}

	[Token(Token = "0x6000666")]
	[Address(RVA = "0x1F39BD4", Offset = "0x1F38BD4", VA = "0x1F39BD4")]
	public LTRect(float x, float y, float width, float height, float alpha)
	{
	}

	[Token(Token = "0x6000667")]
	[Address(RVA = "0x1F39C54", Offset = "0x1F38C54", VA = "0x1F39C54")]
	public LTRect(float x, float y, float width, float height, float alpha, float rotation)
	{
	}

	[Token(Token = "0x600066A")]
	[Address(RVA = "0x1F39F20", Offset = "0x1F38F20", VA = "0x1F39F20")]
	public void setId(int id, int counter)
	{
	}

	[Token(Token = "0x600066B")]
	[Address(RVA = "0x1F39A88", Offset = "0x1F38A88", VA = "0x1F39A88")]
	public void reset()
	{
	}

	[Token(Token = "0x600066C")]
	[Address(RVA = "0x1F39CFC", Offset = "0x1F38CFC", VA = "0x1F39CFC")]
	public void resetForRotation()
	{
	}

	[Token(Token = "0x6000677")]
	[Address(RVA = "0x1F3A144", Offset = "0x1F39144", VA = "0x1F3A144")]
	public LTRect setStyle(GUIStyle style)
	{
		return null;
	}

	[Token(Token = "0x6000678")]
	[Address(RVA = "0x1F3A14C", Offset = "0x1F3914C", VA = "0x1F3A14C")]
	public LTRect setFontScaleToFit(bool fontScaleToFit)
	{
		return null;
	}

	[Token(Token = "0x6000679")]
	[Address(RVA = "0x1F3A158", Offset = "0x1F39158", VA = "0x1F3A158")]
	public LTRect setColor(Color color)
	{
		return null;
	}

	[Token(Token = "0x600067A")]
	[Address(RVA = "0x1F3A16C", Offset = "0x1F3916C", VA = "0x1F3A16C")]
	public LTRect setAlpha(float alpha)
	{
		return null;
	}

	[Token(Token = "0x600067B")]
	[Address(RVA = "0x1F3A174", Offset = "0x1F39174", VA = "0x1F3A174")]
	public LTRect setLabel(string str)
	{
		return null;
	}

	[Token(Token = "0x600067C")]
	[Address(RVA = "0x1F3A17C", Offset = "0x1F3917C", VA = "0x1F3A17C")]
	public LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect)
	{
		return null;
	}

	[Token(Token = "0x600067D")]
	[Address(RVA = "0x1F3A190", Offset = "0x1F39190", VA = "0x1F3A190")]
	public LTRect setUseSimpleScale(bool useSimpleScale)
	{
		return null;
	}

	[Token(Token = "0x600067E")]
	[Address(RVA = "0x1F3A1D8", Offset = "0x1F391D8", VA = "0x1F3A1D8")]
	public LTRect setSizeByHeight(bool sizeByHeight)
	{
		return null;
	}

	[Token(Token = "0x600067F")]
	[Address(RVA = "0x1F3A1E4", Offset = "0x1F391E4", VA = "0x1F3A1E4", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000069")]
public class LTEvent
{
	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public object data;

	[Token(Token = "0x6000680")]
	[Address(RVA = "0x1F3A374", Offset = "0x1F39374", VA = "0x1F3A374")]
	public LTEvent(int id, object data)
	{
	}
}
[Token(Token = "0x200006A")]
public class LTGUI
{
	[Token(Token = "0x200006B")]
	public enum Element_Type
	{
		[Token(Token = "0x4000380")]
		Texture,
		[Token(Token = "0x4000381")]
		Label
	}

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int RECT_LEVELS;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int RECTS_PER_LEVEL;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int BUTTONS_MAX;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static LTRect[] levels;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static int[] levelDepths;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static Rect[] buttons;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static int[] buttonLevels;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static int[] buttonLastFrame;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static LTRect r;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static Color color;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static bool isGUIEnabled;

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static int global_counter;

	[Token(Token = "0x6000681")]
	[Address(RVA = "0x1F3A3A4", Offset = "0x1F393A4", VA = "0x1F3A3A4")]
	public static void init()
	{
	}

	[Token(Token = "0x6000682")]
	[Address(RVA = "0x1F3A470", Offset = "0x1F39470", VA = "0x1F3A470")]
	public static void initRectCheck()
	{
	}

	[Token(Token = "0x6000683")]
	[Address(RVA = "0x1F3A5C4", Offset = "0x1F395C4", VA = "0x1F3A5C4")]
	public static void reset()
	{
	}

	[Token(Token = "0x6000684")]
	[Address(RVA = "0x1F3A70C", Offset = "0x1F3970C", VA = "0x1F3A70C")]
	public static void update(int updateLevel)
	{
	}

	[Token(Token = "0x6000685")]
	[Address(RVA = "0x1F3AE58", Offset = "0x1F39E58", VA = "0x1F3AE58")]
	public static bool checkOnScreen(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000686")]
	[Address(RVA = "0x1F3AED0", Offset = "0x1F39ED0", VA = "0x1F3AED0")]
	public static void destroy(int id)
	{
	}

	[Token(Token = "0x6000687")]
	[Address(RVA = "0x1F3B018", Offset = "0x1F3A018", VA = "0x1F3B018")]
	public static void destroyAll(int depth)
	{
	}

	[Token(Token = "0x6000688")]
	[Address(RVA = "0x1F3B0F4", Offset = "0x1F3A0F4", VA = "0x1F3B0F4")]
	public static LTRect label(Rect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000689")]
	[Address(RVA = "0x1F3B1B0", Offset = "0x1F3A1B0", VA = "0x1F3B1B0")]
	public static LTRect label(LTRect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x600068A")]
	[Address(RVA = "0x1F3B534", Offset = "0x1F3A534", VA = "0x1F3B534")]
	public static LTRect texture(Rect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x600068B")]
	[Address(RVA = "0x1F3B5F0", Offset = "0x1F3A5F0", VA = "0x1F3B5F0")]
	public static LTRect texture(LTRect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x600068C")]
	[Address(RVA = "0x1F3B22C", Offset = "0x1F3A22C", VA = "0x1F3B22C")]
	public static LTRect element(LTRect rect, int depth)
	{
		return null;
	}

	[Token(Token = "0x600068D")]
	[Address(RVA = "0x1F3B668", Offset = "0x1F3A668", VA = "0x1F3B668")]
	public static bool hasNoOverlap(Rect rect, int depth)
	{
		return default(bool);
	}

	[Token(Token = "0x600068E")]
	[Address(RVA = "0x1F3B924", Offset = "0x1F3A924", VA = "0x1F3B924")]
	public static bool pressedWithinRect(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x600068F")]
	[Address(RVA = "0x1F3BA64", Offset = "0x1F3AA64", VA = "0x1F3BA64")]
	public static bool checkWithinRect(Vector2 vec2, Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000690")]
	[Address(RVA = "0x1F3B9F4", Offset = "0x1F3A9F4", VA = "0x1F3B9F4")]
	public static Vector2 firstTouch()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000691")]
	[Address(RVA = "0x1F3BAE0", Offset = "0x1F3AAE0", VA = "0x1F3BAE0")]
	public LTGUI()
	{
	}
}
[Token(Token = "0x200006C")]
public class LeanAudioStream
{
	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int position;

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip audioClip;

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float[] audioArr;

	[Token(Token = "0x6000693")]
	[Address(RVA = "0x1F3BB54", Offset = "0x1F3AB54", VA = "0x1F3BB54")]
	public LeanAudioStream(float[] audioArr)
	{
	}

	[Token(Token = "0x6000694")]
	[Address(RVA = "0x1F3BB7C", Offset = "0x1F3AB7C", VA = "0x1F3BB7C")]
	public void OnAudioRead(float[] data)
	{
	}

	[Token(Token = "0x6000695")]
	[Address(RVA = "0x1F3BBE8", Offset = "0x1F3ABE8", VA = "0x1F3BBE8")]
	public void OnAudioSetPosition(int newPosition)
	{
	}
}
[Token(Token = "0x200006D")]
public class LeanAudio
{
	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float MIN_FREQEUNCY_PERIOD;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int PROCESSING_ITERATIONS_MAX;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static float[] generatedWaveDistances;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static int generatedWaveDistancesCount;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static float[] longList;

	[Token(Token = "0x6000696")]
	[Address(RVA = "0x1F3BBF0", Offset = "0x1F3ABF0", VA = "0x1F3BBF0")]
	public static LeanAudioOptions options()
	{
		return null;
	}

	[Token(Token = "0x6000697")]
	[Address(RVA = "0x1F3BD10", Offset = "0x1F3AD10", VA = "0x1F3BD10")]
	public static LeanAudioStream createAudioStream(AnimationCurve volume, AnimationCurve frequency, [Optional] LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x6000698")]
	[Address(RVA = "0x1F3C63C", Offset = "0x1F3B63C", VA = "0x1F3C63C")]
	public static AudioClip createAudio(AnimationCurve volume, AnimationCurve frequency, [Optional] LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x6000699")]
	[Address(RVA = "0x1F3BDD8", Offset = "0x1F3ADD8", VA = "0x1F3BDD8")]
	private static int createAudioWave(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options)
	{
		return default(int);
	}

	[Token(Token = "0x600069A")]
	[Address(RVA = "0x1F3C164", Offset = "0x1F3B164", VA = "0x1F3C164")]
	private static AudioClip createAudioFromWave(int waveLength, LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x600069B")]
	[Address(RVA = "0x1F3C6F8", Offset = "0x1F3B6F8", VA = "0x1F3C6F8")]
	private static void OnAudioSetPosition(int newPosition)
	{
	}

	[Token(Token = "0x600069C")]
	[Address(RVA = "0x1F3C6FC", Offset = "0x1F3B6FC", VA = "0x1F3C6FC")]
	public static AudioClip generateAudioFromCurve(AnimationCurve curve, int frequencyRate = 44100)
	{
		return null;
	}

	[Token(Token = "0x600069D")]
	[Address(RVA = "0x1F3C868", Offset = "0x1F3B868", VA = "0x1F3C868")]
	public static AudioSource play(AudioClip audio, float volume)
	{
		return null;
	}

	[Token(Token = "0x600069E")]
	[Address(RVA = "0x1F3CA64", Offset = "0x1F3BA64", VA = "0x1F3CA64")]
	public static AudioSource play(AudioClip audio)
	{
		return null;
	}

	[Token(Token = "0x600069F")]
	[Address(RVA = "0x1F3CB0C", Offset = "0x1F3BB0C", VA = "0x1F3CB0C")]
	public static AudioSource play(AudioClip audio, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x60006A0")]
	[Address(RVA = "0x1F3CB88", Offset = "0x1F3BB88", VA = "0x1F3CB88")]
	public static AudioSource play(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x60006A1")]
	[Address(RVA = "0x1F3C934", Offset = "0x1F3B934", VA = "0x1F3C934")]
	public static AudioSource playClipAt(AudioClip clip, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x60006A2")]
	[Address(RVA = "0x1F3CC38", Offset = "0x1F3BC38", VA = "0x1F3CC38")]
	public static void printOutAudioClip(AudioClip audioClip, ref AnimationCurve curve, float scaleX = 1f)
	{
	}

	[Token(Token = "0x60006A3")]
	[Address(RVA = "0x1F3CDD0", Offset = "0x1F3BDD0", VA = "0x1F3CDD0")]
	public LeanAudio()
	{
	}
}
[Token(Token = "0x200006E")]
public class LeanAudioOptions
{
	[Token(Token = "0x200006F")]
	public enum LeanAudioWaveStyle
	{
		[Token(Token = "0x4000393")]
		Sine,
		[Token(Token = "0x4000394")]
		Square,
		[Token(Token = "0x4000395")]
		Sawtooth,
		[Token(Token = "0x4000396")]
		Noise
	}

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public LeanAudioWaveStyle waveStyle;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3[] vibrato;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3[] modulation;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int frequencyRate;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float waveNoiseScale;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float waveNoiseInfluence;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool useSetData;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public LeanAudioStream stream;

	[Token(Token = "0x60006A5")]
	[Address(RVA = "0x1F3BCEC", Offset = "0x1F3ACEC", VA = "0x1F3BCEC")]
	public LeanAudioOptions()
	{
	}

	[Token(Token = "0x60006A6")]
	[Address(RVA = "0x1F3CE30", Offset = "0x1F3BE30", VA = "0x1F3CE30")]
	public LeanAudioOptions setFrequency(int frequencyRate)
	{
		return null;
	}

	[Token(Token = "0x60006A7")]
	[Address(RVA = "0x1F3CE38", Offset = "0x1F3BE38", VA = "0x1F3CE38")]
	public LeanAudioOptions setVibrato(Vector3[] vibrato)
	{
		return null;
	}

	[Token(Token = "0x60006A8")]
	[Address(RVA = "0x1F3CE40", Offset = "0x1F3BE40", VA = "0x1F3CE40")]
	public LeanAudioOptions setWaveSine()
	{
		return null;
	}

	[Token(Token = "0x60006A9")]
	[Address(RVA = "0x1F3CE48", Offset = "0x1F3BE48", VA = "0x1F3CE48")]
	public LeanAudioOptions setWaveSquare()
	{
		return null;
	}

	[Token(Token = "0x60006AA")]
	[Address(RVA = "0x1F3CE54", Offset = "0x1F3BE54", VA = "0x1F3CE54")]
	public LeanAudioOptions setWaveSawtooth()
	{
		return null;
	}

	[Token(Token = "0x60006AB")]
	[Address(RVA = "0x1F3CE60", Offset = "0x1F3BE60", VA = "0x1F3CE60")]
	public LeanAudioOptions setWaveNoise()
	{
		return null;
	}

	[Token(Token = "0x60006AC")]
	[Address(RVA = "0x1F3CE6C", Offset = "0x1F3BE6C", VA = "0x1F3CE6C")]
	public LeanAudioOptions setWaveStyle(LeanAudioWaveStyle style)
	{
		return null;
	}

	[Token(Token = "0x60006AD")]
	[Address(RVA = "0x1F3CE74", Offset = "0x1F3BE74", VA = "0x1F3CE74")]
	public LeanAudioOptions setWaveNoiseScale(float waveScale)
	{
		return null;
	}

	[Token(Token = "0x60006AE")]
	[Address(RVA = "0x1F3CE7C", Offset = "0x1F3BE7C", VA = "0x1F3CE7C")]
	public LeanAudioOptions setWaveNoiseInfluence(float influence)
	{
		return null;
	}
}
[Token(Token = "0x2000070")]
public class LeanTester : MonoBehaviour
{
	[Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class <timeoutCheck>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LeanTester <>4__this;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <pauseEndTime>5__2;

		[Token(Token = "0x1700010E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x1F3D374", Offset = "0x1F3C374", VA = "0x1F3D374", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x1F3D3B4", Offset = "0x1F3C3B4", VA = "0x1F3D3B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x1F3CF04", Offset = "0x1F3BF04", VA = "0x1F3CF04")]
		[DebuggerHidden]
		public <timeoutCheck>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x1F3CF3C", Offset = "0x1F3BF3C", VA = "0x1F3CF3C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x1F3CF40", Offset = "0x1F3BF40", VA = "0x1F3CF40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x1F3D37C", Offset = "0x1F3C37C", VA = "0x1F3D37C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float timeout;

	[Token(Token = "0x60006AF")]
	[Address(RVA = "0x1F3CE84", Offset = "0x1F3BE84", VA = "0x1F3CE84")]
	public void Start()
	{
	}

	[Token(Token = "0x60006B0")]
	[Address(RVA = "0x1F3CEA4", Offset = "0x1F3BEA4", VA = "0x1F3CEA4")]
	[IteratorStateMachine(typeof(<timeoutCheck>d__2))]
	private IEnumerator timeoutCheck()
	{
		return null;
	}

	[Token(Token = "0x60006B1")]
	[Address(RVA = "0x1F3CF2C", Offset = "0x1F3BF2C", VA = "0x1F3CF2C")]
	public LeanTester()
	{
	}
}
[Token(Token = "0x2000072")]
public class LeanTest
{
	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int expected;

	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static int tests;

	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static int passes;

	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static float timeout;

	[Token(Token = "0x40003A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static bool timeoutStarted;

	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public static bool testsFinished;

	[Token(Token = "0x60006B8")]
	[Address(RVA = "0x1F3D3BC", Offset = "0x1F3C3BC", VA = "0x1F3D3BC")]
	public static void debug(string name, bool didPass, [Optional] string failExplaination)
	{
	}

	[Token(Token = "0x60006B9")]
	[Address(RVA = "0x1F3D428", Offset = "0x1F3C428", VA = "0x1F3D428")]
	public static void expect(bool didPass, string definition, [Optional] string failExplaination)
	{
	}

	[Token(Token = "0x60006BA")]
	[Address(RVA = "0x1F3DB84", Offset = "0x1F3CB84", VA = "0x1F3DB84")]
	public static string padRight(int len)
	{
		return null;
	}

	[Token(Token = "0x60006BB")]
	[Address(RVA = "0x1F3D970", Offset = "0x1F3C970", VA = "0x1F3D970")]
	public static float printOutLength(string str)
	{
		return default(float);
	}

	[Token(Token = "0x60006BC")]
	[Address(RVA = "0x1F3DBF8", Offset = "0x1F3CBF8", VA = "0x1F3DBF8")]
	public static string formatBC(string str, string color)
	{
		return null;
	}

	[Token(Token = "0x60006BD")]
	[Address(RVA = "0x1F3D094", Offset = "0x1F3C094", VA = "0x1F3D094")]
	public static string formatB(string str)
	{
		return null;
	}

	[Token(Token = "0x60006BE")]
	[Address(RVA = "0x1F3DA98", Offset = "0x1F3CA98", VA = "0x1F3DA98")]
	public static string formatC(string str, string color)
	{
		return null;
	}

	[Token(Token = "0x60006BF")]
	[Address(RVA = "0x1F3D100", Offset = "0x1F3C100", VA = "0x1F3D100")]
	public static void overview()
	{
	}

	[Token(Token = "0x60006C0")]
	[Address(RVA = "0x1F3DC60", Offset = "0x1F3CC60", VA = "0x1F3DC60")]
	public LeanTest()
	{
	}
}
[Token(Token = "0x2000073")]
public class LTDescr
{
	[Token(Token = "0x2000074")]
	public delegate Vector3 EaseTypeDelegate();

	[Token(Token = "0x2000075")]
	public delegate void ActionMethodDelegate();

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool toggle;

	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool useEstimatedTime;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
	public bool useFrames;

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
	public bool useManualTime;

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public bool usesNormalDt;

	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
	public bool hasInitiliazed;

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
	public bool hasExtraOnCompletes;

	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
	public bool hasPhysics;

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool onCompleteOnRepeat;

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool onCompleteOnStart;

	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool useRecursion;

	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ratioPassed;

	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float passed;

	[Token(Token = "0x40003AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float delay;

	[Token(Token = "0x40003B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float time;

	[Token(Token = "0x40003B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float speed;

	[Token(Token = "0x40003B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float lastVal;

	[Token(Token = "0x40003B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private uint _id;

	[Token(Token = "0x40003B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int loopCount;

	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public uint counter;

	[Token(Token = "0x40003B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float direction;

	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float directionLast;

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float overshoot;

	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float period;

	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float scale;

	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool destroyOnComplete;

	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform trans;

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public LTRect ltRect;

	[Token(Token = "0x40003BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	internal Vector3 fromInternal;

	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	internal Vector3 toInternal;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	internal Vector3 diff;

	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	internal Vector3 diffDiv2;

	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public TweenAction type;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private LeanTweenType easeType;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public LeanTweenType loopType;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public bool hasUpdateCallback;

	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public EaseTypeDelegate easeMethod;

	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public SpriteRenderer spriteRen;

	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public RectTransform rectTransform;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Text uiText;

	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Image uiImage;

	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public RawImage rawImage;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Sprite[] sprites;

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public LTDescrOptional _optional;

	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float val;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static float dt;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Vector3 newVect;

	[Token(Token = "0x17000110")]
	public Vector3 from
	{
		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x1F3DCB8", Offset = "0x1F3CCB8", VA = "0x1F3DCB8")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x1F3DCC4", Offset = "0x1F3CCC4", VA = "0x1F3DCC4")]
		set
		{
		}
	}

	[Token(Token = "0x17000111")]
	public Vector3 to
	{
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x1F3DCD0", Offset = "0x1F3CCD0", VA = "0x1F3DCD0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x1F3DCDC", Offset = "0x1F3CCDC", VA = "0x1F3DCDC")]
		set
		{
		}
	}

	[Token(Token = "0x17000112")]
	public ActionMethodDelegate easeInternal
	{
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x1F3DCE8", Offset = "0x1F3CCE8", VA = "0x1F3DCE8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x1F3DCF0", Offset = "0x1F3CCF0", VA = "0x1F3DCF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000113")]
	public ActionMethodDelegate initInternal
	{
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x1F3DCF8", Offset = "0x1F3CCF8", VA = "0x1F3DCF8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x1F3DD00", Offset = "0x1F3CD00", VA = "0x1F3DD00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000114")]
	public int uniqueId
	{
		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x1F3E358", Offset = "0x1F3D358", VA = "0x1F3E358")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000115")]
	public int id
	{
		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x1F3E220", Offset = "0x1F3D220", VA = "0x1F3E220")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000116")]
	public LTDescrOptional optional
	{
		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x1F3E368", Offset = "0x1F3D368", VA = "0x1F3E368")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x1F3E370", Offset = "0x1F3D370", VA = "0x1F3E370")]
		set
		{
		}
	}

	[Token(Token = "0x60006CA")]
	[Address(RVA = "0x1F3DD08", Offset = "0x1F3CD08", VA = "0x1F3DD08", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60006CB")]
	[Address(RVA = "0x1F3E230", Offset = "0x1F3D230", VA = "0x1F3E230")]
	public LTDescr()
	{
	}

	[Token(Token = "0x60006CC")]
	[Address(RVA = "0x1F3E290", Offset = "0x1F3D290", VA = "0x1F3E290")]
	[Obsolete("Use 'LeanTween.cancel( id )' instead")]
	public LTDescr cancel(GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x60006D1")]
	[Address(RVA = "0x1F3E374", Offset = "0x1F3D374", VA = "0x1F3E374")]
	public void reset()
	{
	}

	[Token(Token = "0x60006D2")]
	[Address(RVA = "0x1F3E4A4", Offset = "0x1F3D4A4", VA = "0x1F3E4A4")]
	public LTDescr setMoveX()
	{
		return null;
	}

	[Token(Token = "0x60006D3")]
	[Address(RVA = "0x1F3E55C", Offset = "0x1F3D55C", VA = "0x1F3E55C")]
	public LTDescr setMoveY()
	{
		return null;
	}

	[Token(Token = "0x60006D4")]
	[Address(RVA = "0x1F3E618", Offset = "0x1F3D618", VA = "0x1F3E618")]
	public LTDescr setMoveZ()
	{
		return null;
	}

	[Token(Token = "0x60006D5")]
	[Address(RVA = "0x1F3E6D4", Offset = "0x1F3D6D4", VA = "0x1F3E6D4")]
	public LTDescr setMoveLocalX()
	{
		return null;
	}

	[Token(Token = "0x60006D6")]
	[Address(RVA = "0x1F3E790", Offset = "0x1F3D790", VA = "0x1F3E790")]
	public LTDescr setMoveLocalY()
	{
		return null;
	}

	[Token(Token = "0x60006D7")]
	[Address(RVA = "0x1F3E84C", Offset = "0x1F3D84C", VA = "0x1F3E84C")]
	public LTDescr setMoveLocalZ()
	{
		return null;
	}

	[Token(Token = "0x60006D8")]
	[Address(RVA = "0x1F3E908", Offset = "0x1F3D908", VA = "0x1F3E908")]
	private void initFromInternal()
	{
	}

	[Token(Token = "0x60006D9")]
	[Address(RVA = "0x1F3E910", Offset = "0x1F3D910", VA = "0x1F3E910")]
	public LTDescr setMoveCurved()
	{
		return null;
	}

	[Token(Token = "0x60006DA")]
	[Address(RVA = "0x1F3E9CC", Offset = "0x1F3D9CC", VA = "0x1F3E9CC")]
	public LTDescr setMoveCurvedLocal()
	{
		return null;
	}

	[Token(Token = "0x60006DB")]
	[Address(RVA = "0x1F3EA88", Offset = "0x1F3DA88", VA = "0x1F3EA88")]
	public LTDescr setMoveSpline()
	{
		return null;
	}

	[Token(Token = "0x60006DC")]
	[Address(RVA = "0x1F3EB44", Offset = "0x1F3DB44", VA = "0x1F3EB44")]
	public LTDescr setMoveSplineLocal()
	{
		return null;
	}

	[Token(Token = "0x60006DD")]
	[Address(RVA = "0x1F3EC00", Offset = "0x1F3DC00", VA = "0x1F3EC00")]
	public LTDescr setScaleX()
	{
		return null;
	}

	[Token(Token = "0x60006DE")]
	[Address(RVA = "0x1F3ECBC", Offset = "0x1F3DCBC", VA = "0x1F3ECBC")]
	public LTDescr setScaleY()
	{
		return null;
	}

	[Token(Token = "0x60006DF")]
	[Address(RVA = "0x1F3ED78", Offset = "0x1F3DD78", VA = "0x1F3ED78")]
	public LTDescr setScaleZ()
	{
		return null;
	}

	[Token(Token = "0x60006E0")]
	[Address(RVA = "0x1F3EE34", Offset = "0x1F3DE34", VA = "0x1F3EE34")]
	public LTDescr setRotateX()
	{
		return null;
	}

	[Token(Token = "0x60006E1")]
	[Address(RVA = "0x1F3EEF0", Offset = "0x1F3DEF0", VA = "0x1F3EEF0")]
	public LTDescr setRotateY()
	{
		return null;
	}

	[Token(Token = "0x60006E2")]
	[Address(RVA = "0x1F3EFAC", Offset = "0x1F3DFAC", VA = "0x1F3EFAC")]
	public LTDescr setRotateZ()
	{
		return null;
	}

	[Token(Token = "0x60006E3")]
	[Address(RVA = "0x1F3F068", Offset = "0x1F3E068", VA = "0x1F3F068")]
	public LTDescr setRotateAround()
	{
		return null;
	}

	[Token(Token = "0x60006E4")]
	[Address(RVA = "0x1F3F124", Offset = "0x1F3E124", VA = "0x1F3F124")]
	public LTDescr setRotateAroundLocal()
	{
		return null;
	}

	[Token(Token = "0x60006E5")]
	[Address(RVA = "0x1F3F1E0", Offset = "0x1F3E1E0", VA = "0x1F3F1E0")]
	public LTDescr setAlpha()
	{
		return null;
	}

	[Token(Token = "0x60006E6")]
	[Address(RVA = "0x1F3F29C", Offset = "0x1F3E29C", VA = "0x1F3F29C")]
	public LTDescr setTextAlpha()
	{
		return null;
	}

	[Token(Token = "0x60006E7")]
	[Address(RVA = "0x1F3F358", Offset = "0x1F3E358", VA = "0x1F3F358")]
	public LTDescr setAlphaVertex()
	{
		return null;
	}

	[Token(Token = "0x60006E8")]
	[Address(RVA = "0x1F3F414", Offset = "0x1F3E414", VA = "0x1F3F414")]
	public LTDescr setColor()
	{
		return null;
	}

	[Token(Token = "0x60006E9")]
	[Address(RVA = "0x1F3F4D0", Offset = "0x1F3E4D0", VA = "0x1F3F4D0")]
	public LTDescr setCallbackColor()
	{
		return null;
	}

	[Token(Token = "0x60006EA")]
	[Address(RVA = "0x1F3F58C", Offset = "0x1F3E58C", VA = "0x1F3F58C")]
	public LTDescr setTextColor()
	{
		return null;
	}

	[Token(Token = "0x60006EB")]
	[Address(RVA = "0x1F3F648", Offset = "0x1F3E648", VA = "0x1F3F648")]
	public LTDescr setCanvasAlpha()
	{
		return null;
	}

	[Token(Token = "0x60006EC")]
	[Address(RVA = "0x1F3F704", Offset = "0x1F3E704", VA = "0x1F3F704")]
	public LTDescr setCanvasGroupAlpha()
	{
		return null;
	}

	[Token(Token = "0x60006ED")]
	[Address(RVA = "0x1F3F7C0", Offset = "0x1F3E7C0", VA = "0x1F3F7C0")]
	public LTDescr setCanvasColor()
	{
		return null;
	}

	[Token(Token = "0x60006EE")]
	[Address(RVA = "0x1F3F87C", Offset = "0x1F3E87C", VA = "0x1F3F87C")]
	public LTDescr setCanvasMoveX()
	{
		return null;
	}

	[Token(Token = "0x60006EF")]
	[Address(RVA = "0x1F3F938", Offset = "0x1F3E938", VA = "0x1F3F938")]
	public LTDescr setCanvasMoveY()
	{
		return null;
	}

	[Token(Token = "0x60006F0")]
	[Address(RVA = "0x1F3F9F4", Offset = "0x1F3E9F4", VA = "0x1F3F9F4")]
	public LTDescr setCanvasMoveZ()
	{
		return null;
	}

	[Token(Token = "0x60006F1")]
	[Address(RVA = "0x1F3FAB0", Offset = "0x1F3EAB0", VA = "0x1F3FAB0")]
	private void initCanvasRotateAround()
	{
	}

	[Token(Token = "0x60006F2")]
	[Address(RVA = "0x1F3FAEC", Offset = "0x1F3EAEC", VA = "0x1F3FAEC")]
	public LTDescr setCanvasRotateAround()
	{
		return null;
	}

	[Token(Token = "0x60006F3")]
	[Address(RVA = "0x1F3FBA8", Offset = "0x1F3EBA8", VA = "0x1F3FBA8")]
	public LTDescr setCanvasRotateAroundLocal()
	{
		return null;
	}

	[Token(Token = "0x60006F4")]
	[Address(RVA = "0x1F3FC64", Offset = "0x1F3EC64", VA = "0x1F3FC64")]
	public LTDescr setCanvasPlaySprite()
	{
		return null;
	}

	[Token(Token = "0x60006F5")]
	[Address(RVA = "0x1F3FD20", Offset = "0x1F3ED20", VA = "0x1F3FD20")]
	public LTDescr setCanvasMove()
	{
		return null;
	}

	[Token(Token = "0x60006F6")]
	[Address(RVA = "0x1F3FDDC", Offset = "0x1F3EDDC", VA = "0x1F3FDDC")]
	public LTDescr setCanvasScale()
	{
		return null;
	}

	[Token(Token = "0x60006F7")]
	[Address(RVA = "0x1F3FE98", Offset = "0x1F3EE98", VA = "0x1F3FE98")]
	public LTDescr setCanvasSizeDelta()
	{
		return null;
	}

	[Token(Token = "0x60006F8")]
	[Address(RVA = "0x1F3FF54", Offset = "0x1F3EF54", VA = "0x1F3FF54")]
	private void callback()
	{
	}

	[Token(Token = "0x60006F9")]
	[Address(RVA = "0x1F3FFCC", Offset = "0x1F3EFCC", VA = "0x1F3FFCC")]
	public LTDescr setCallback()
	{
		return null;
	}

	[Token(Token = "0x60006FA")]
	[Address(RVA = "0x1F400E8", Offset = "0x1F3F0E8", VA = "0x1F400E8")]
	public LTDescr setValue3()
	{
		return null;
	}

	[Token(Token = "0x60006FB")]
	[Address(RVA = "0x1F40204", Offset = "0x1F3F204", VA = "0x1F40204")]
	public LTDescr setMove()
	{
		return null;
	}

	[Token(Token = "0x60006FC")]
	[Address(RVA = "0x1F402C0", Offset = "0x1F3F2C0", VA = "0x1F402C0")]
	public LTDescr setMoveLocal()
	{
		return null;
	}

	[Token(Token = "0x60006FD")]
	[Address(RVA = "0x1F4037C", Offset = "0x1F3F37C", VA = "0x1F4037C")]
	public LTDescr setMoveToTransform()
	{
		return null;
	}

	[Token(Token = "0x60006FE")]
	[Address(RVA = "0x1F40438", Offset = "0x1F3F438", VA = "0x1F40438")]
	public LTDescr setRotate()
	{
		return null;
	}

	[Token(Token = "0x60006FF")]
	[Address(RVA = "0x1F404F4", Offset = "0x1F3F4F4", VA = "0x1F404F4")]
	public LTDescr setRotateLocal()
	{
		return null;
	}

	[Token(Token = "0x6000700")]
	[Address(RVA = "0x1F405B0", Offset = "0x1F3F5B0", VA = "0x1F405B0")]
	public LTDescr setScale()
	{
		return null;
	}

	[Token(Token = "0x6000701")]
	[Address(RVA = "0x1F4066C", Offset = "0x1F3F66C", VA = "0x1F4066C")]
	public LTDescr setGUIMove()
	{
		return null;
	}

	[Token(Token = "0x6000702")]
	[Address(RVA = "0x1F40728", Offset = "0x1F3F728", VA = "0x1F40728")]
	public LTDescr setGUIMoveMargin()
	{
		return null;
	}

	[Token(Token = "0x6000703")]
	[Address(RVA = "0x1F407E4", Offset = "0x1F3F7E4", VA = "0x1F407E4")]
	public LTDescr setGUIScale()
	{
		return null;
	}

	[Token(Token = "0x6000704")]
	[Address(RVA = "0x1F408A0", Offset = "0x1F3F8A0", VA = "0x1F408A0")]
	public LTDescr setGUIAlpha()
	{
		return null;
	}

	[Token(Token = "0x6000705")]
	[Address(RVA = "0x1F4095C", Offset = "0x1F3F95C", VA = "0x1F4095C")]
	public LTDescr setGUIRotate()
	{
		return null;
	}

	[Token(Token = "0x6000706")]
	[Address(RVA = "0x1F40A18", Offset = "0x1F3FA18", VA = "0x1F40A18")]
	public LTDescr setDelayedSound()
	{
		return null;
	}

	[Token(Token = "0x6000707")]
	[Address(RVA = "0x1F40AD4", Offset = "0x1F3FAD4", VA = "0x1F40AD4")]
	private void init()
	{
	}

	[Token(Token = "0x6000708")]
	[Address(RVA = "0x1F40D14", Offset = "0x1F3FD14", VA = "0x1F40D14")]
	private void initSpeed()
	{
	}

	[Token(Token = "0x6000709")]
	[Address(RVA = "0x1F40E00", Offset = "0x1F3FE00", VA = "0x1F40E00")]
	public LTDescr updateNow()
	{
		return null;
	}

	[Token(Token = "0x600070A")]
	[Address(RVA = "0x1F40E18", Offset = "0x1F3FE18", VA = "0x1F40E18")]
	public bool updateInternal()
	{
		return default(bool);
	}

	[Token(Token = "0x600070B")]
	[Address(RVA = "0x1F40C1C", Offset = "0x1F3FC1C", VA = "0x1F40C1C")]
	public void callOnCompletes()
	{
	}

	[Token(Token = "0x600070C")]
	[Address(RVA = "0x1F410E4", Offset = "0x1F400E4", VA = "0x1F410E4")]
	public LTDescr setFromColor(Color col)
	{
		return null;
	}

	[Token(Token = "0x600070D")]
	[Address(RVA = "0x1F41120", Offset = "0x1F40120", VA = "0x1F41120")]
	private static void alphaRecursive(Transform transform, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x600070E")]
	[Address(RVA = "0x1F415A0", Offset = "0x1F405A0", VA = "0x1F415A0")]
	private static void colorRecursive(Transform transform, Color toColor, bool useRecursion = true)
	{
	}

	[Token(Token = "0x600070F")]
	[Address(RVA = "0x1F4198C", Offset = "0x1F4098C", VA = "0x1F4198C")]
	private static void alphaRecursive(RectTransform rectTransform, float val, int recursiveLevel = 0)
	{
	}

	[Token(Token = "0x6000710")]
	[Address(RVA = "0x1F41DCC", Offset = "0x1F40DCC", VA = "0x1F41DCC")]
	private static void alphaRecursiveSprite(Transform transform, float val)
	{
	}

	[Token(Token = "0x6000711")]
	[Address(RVA = "0x1F421A4", Offset = "0x1F411A4", VA = "0x1F421A4")]
	private static void colorRecursiveSprite(Transform transform, Color toColor)
	{
	}

	[Token(Token = "0x6000712")]
	[Address(RVA = "0x1F425A4", Offset = "0x1F415A4", VA = "0x1F425A4")]
	private static void colorRecursive(RectTransform rectTransform, Color toColor)
	{
	}

	[Token(Token = "0x6000713")]
	[Address(RVA = "0x1F429DC", Offset = "0x1F419DC", VA = "0x1F429DC")]
	private static void textAlphaChildrenRecursive(Transform trans, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x6000714")]
	[Address(RVA = "0x1F42D94", Offset = "0x1F41D94", VA = "0x1F42D94")]
	private static void textAlphaRecursive(Transform trans, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x6000715")]
	[Address(RVA = "0x1F4311C", Offset = "0x1F4211C", VA = "0x1F4311C")]
	private static void textColorRecursive(Transform trans, Color toColor)
	{
	}

	[Token(Token = "0x6000716")]
	[Address(RVA = "0x1F434D8", Offset = "0x1F424D8", VA = "0x1F434D8")]
	private static Color tweenColor(LTDescr tween, float val)
	{
		return default(Color);
	}

	[Token(Token = "0x6000717")]
	[Address(RVA = "0x1F43534", Offset = "0x1F42534", VA = "0x1F43534")]
	public LTDescr pause()
	{
		return null;
	}

	[Token(Token = "0x6000718")]
	[Address(RVA = "0x1F43550", Offset = "0x1F42550", VA = "0x1F43550")]
	public LTDescr resume()
	{
		return null;
	}

	[Token(Token = "0x6000719")]
	[Address(RVA = "0x1F4355C", Offset = "0x1F4255C", VA = "0x1F4355C")]
	public LTDescr setAxis(Vector3 axis)
	{
		return null;
	}

	[Token(Token = "0x600071A")]
	[Address(RVA = "0x1F4357C", Offset = "0x1F4257C", VA = "0x1F4357C")]
	public LTDescr setDelay(float delay)
	{
		return null;
	}

	[Token(Token = "0x600071B")]
	[Address(RVA = "0x1F43584", Offset = "0x1F42584", VA = "0x1F43584")]
	public LTDescr setEase(LeanTweenType easeType)
	{
		return null;
	}

	[Token(Token = "0x600071C")]
	[Address(RVA = "0x1F436C0", Offset = "0x1F426C0", VA = "0x1F436C0")]
	public LTDescr setEaseLinear()
	{
		return null;
	}

	[Token(Token = "0x600071D")]
	[Address(RVA = "0x1F448C8", Offset = "0x1F438C8", VA = "0x1F448C8")]
	public LTDescr setEaseSpring()
	{
		return null;
	}

	[Token(Token = "0x600071E")]
	[Address(RVA = "0x1F437D0", Offset = "0x1F427D0", VA = "0x1F437D0")]
	public LTDescr setEaseInQuad()
	{
		return null;
	}

	[Token(Token = "0x600071F")]
	[Address(RVA = "0x1F43748", Offset = "0x1F42748", VA = "0x1F43748")]
	public LTDescr setEaseOutQuad()
	{
		return null;
	}

	[Token(Token = "0x6000720")]
	[Address(RVA = "0x1F43858", Offset = "0x1F42858", VA = "0x1F43858")]
	public LTDescr setEaseInOutQuad()
	{
		return null;
	}

	[Token(Token = "0x6000721")]
	[Address(RVA = "0x1F438E0", Offset = "0x1F428E0", VA = "0x1F438E0")]
	public LTDescr setEaseInCubic()
	{
		return null;
	}

	[Token(Token = "0x6000722")]
	[Address(RVA = "0x1F43968", Offset = "0x1F42968", VA = "0x1F43968")]
	public LTDescr setEaseOutCubic()
	{
		return null;
	}

	[Token(Token = "0x6000723")]
	[Address(RVA = "0x1F439F0", Offset = "0x1F429F0", VA = "0x1F439F0")]
	public LTDescr setEaseInOutCubic()
	{
		return null;
	}

	[Token(Token = "0x6000724")]
	[Address(RVA = "0x1F43A78", Offset = "0x1F42A78", VA = "0x1F43A78")]
	public LTDescr setEaseInQuart()
	{
		return null;
	}

	[Token(Token = "0x6000725")]
	[Address(RVA = "0x1F43B00", Offset = "0x1F42B00", VA = "0x1F43B00")]
	public LTDescr setEaseOutQuart()
	{
		return null;
	}

	[Token(Token = "0x6000726")]
	[Address(RVA = "0x1F43B88", Offset = "0x1F42B88", VA = "0x1F43B88")]
	public LTDescr setEaseInOutQuart()
	{
		return null;
	}

	[Token(Token = "0x6000727")]
	[Address(RVA = "0x1F43C10", Offset = "0x1F42C10", VA = "0x1F43C10")]
	public LTDescr setEaseInQuint()
	{
		return null;
	}

	[Token(Token = "0x6000728")]
	[Address(RVA = "0x1F43C98", Offset = "0x1F42C98", VA = "0x1F43C98")]
	public LTDescr setEaseOutQuint()
	{
		return null;
	}

	[Token(Token = "0x6000729")]
	[Address(RVA = "0x1F43D20", Offset = "0x1F42D20", VA = "0x1F43D20")]
	public LTDescr setEaseInOutQuint()
	{
		return null;
	}

	[Token(Token = "0x600072A")]
	[Address(RVA = "0x1F43DA8", Offset = "0x1F42DA8", VA = "0x1F43DA8")]
	public LTDescr setEaseInSine()
	{
		return null;
	}

	[Token(Token = "0x600072B")]
	[Address(RVA = "0x1F43E30", Offset = "0x1F42E30", VA = "0x1F43E30")]
	public LTDescr setEaseOutSine()
	{
		return null;
	}

	[Token(Token = "0x600072C")]
	[Address(RVA = "0x1F43EB8", Offset = "0x1F42EB8", VA = "0x1F43EB8")]
	public LTDescr setEaseInOutSine()
	{
		return null;
	}

	[Token(Token = "0x600072D")]
	[Address(RVA = "0x1F43F40", Offset = "0x1F42F40", VA = "0x1F43F40")]
	public LTDescr setEaseInExpo()
	{
		return null;
	}

	[Token(Token = "0x600072E")]
	[Address(RVA = "0x1F43FC8", Offset = "0x1F42FC8", VA = "0x1F43FC8")]
	public LTDescr setEaseOutExpo()
	{
		return null;
	}

	[Token(Token = "0x600072F")]
	[Address(RVA = "0x1F44050", Offset = "0x1F43050", VA = "0x1F44050")]
	public LTDescr setEaseInOutExpo()
	{
		return null;
	}

	[Token(Token = "0x6000730")]
	[Address(RVA = "0x1F440D8", Offset = "0x1F430D8", VA = "0x1F440D8")]
	public LTDescr setEaseInCirc()
	{
		return null;
	}

	[Token(Token = "0x6000731")]
	[Address(RVA = "0x1F44160", Offset = "0x1F43160", VA = "0x1F44160")]
	public LTDescr setEaseOutCirc()
	{
		return null;
	}

	[Token(Token = "0x6000732")]
	[Address(RVA = "0x1F441E8", Offset = "0x1F431E8", VA = "0x1F441E8")]
	public LTDescr setEaseInOutCirc()
	{
		return null;
	}

	[Token(Token = "0x6000733")]
	[Address(RVA = "0x1F44270", Offset = "0x1F43270", VA = "0x1F44270")]
	public LTDescr setEaseInBounce()
	{
		return null;
	}

	[Token(Token = "0x6000734")]
	[Address(RVA = "0x1F442F8", Offset = "0x1F432F8", VA = "0x1F442F8")]
	public LTDescr setEaseOutBounce()
	{
		return null;
	}

	[Token(Token = "0x6000735")]
	[Address(RVA = "0x1F44380", Offset = "0x1F43380", VA = "0x1F44380")]
	public LTDescr setEaseInOutBounce()
	{
		return null;
	}

	[Token(Token = "0x6000736")]
	[Address(RVA = "0x1F44408", Offset = "0x1F43408", VA = "0x1F44408")]
	public LTDescr setEaseInBack()
	{
		return null;
	}

	[Token(Token = "0x6000737")]
	[Address(RVA = "0x1F44490", Offset = "0x1F43490", VA = "0x1F44490")]
	public LTDescr setEaseOutBack()
	{
		return null;
	}

	[Token(Token = "0x6000738")]
	[Address(RVA = "0x1F44518", Offset = "0x1F43518", VA = "0x1F44518")]
	public LTDescr setEaseInOutBack()
	{
		return null;
	}

	[Token(Token = "0x6000739")]
	[Address(RVA = "0x1F445A0", Offset = "0x1F435A0", VA = "0x1F445A0")]
	public LTDescr setEaseInElastic()
	{
		return null;
	}

	[Token(Token = "0x600073A")]
	[Address(RVA = "0x1F44628", Offset = "0x1F43628", VA = "0x1F44628")]
	public LTDescr setEaseOutElastic()
	{
		return null;
	}

	[Token(Token = "0x600073B")]
	[Address(RVA = "0x1F446B0", Offset = "0x1F436B0", VA = "0x1F446B0")]
	public LTDescr setEaseInOutElastic()
	{
		return null;
	}

	[Token(Token = "0x600073C")]
	[Address(RVA = "0x1F44738", Offset = "0x1F43738", VA = "0x1F44738")]
	public LTDescr setEasePunch()
	{
		return null;
	}

	[Token(Token = "0x600073D")]
	[Address(RVA = "0x1F44800", Offset = "0x1F43800", VA = "0x1F44800")]
	public LTDescr setEaseShake()
	{
		return null;
	}

	[Token(Token = "0x600073E")]
	[Address(RVA = "0x1F44950", Offset = "0x1F43950", VA = "0x1F44950")]
	private Vector3 tweenOnCurve()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600073F")]
	[Address(RVA = "0x1F44A10", Offset = "0x1F43A10", VA = "0x1F44A10")]
	private Vector3 easeInOutQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000740")]
	[Address(RVA = "0x1F44AB4", Offset = "0x1F43AB4", VA = "0x1F44AB4")]
	private Vector3 easeInQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000741")]
	[Address(RVA = "0x1F44B2C", Offset = "0x1F43B2C", VA = "0x1F44B2C")]
	private Vector3 easeOutQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000742")]
	[Address(RVA = "0x1F44BB0", Offset = "0x1F43BB0", VA = "0x1F44BB0")]
	private Vector3 easeLinear()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000743")]
	[Address(RVA = "0x1F44C24", Offset = "0x1F43C24", VA = "0x1F44C24")]
	private Vector3 easeSpring()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000744")]
	[Address(RVA = "0x1F44D20", Offset = "0x1F43D20", VA = "0x1F44D20")]
	private Vector3 easeInCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000745")]
	[Address(RVA = "0x1F44D9C", Offset = "0x1F43D9C", VA = "0x1F44D9C")]
	private Vector3 easeOutCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000746")]
	[Address(RVA = "0x1F44E28", Offset = "0x1F43E28", VA = "0x1F44E28")]
	private Vector3 easeInOutCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000747")]
	[Address(RVA = "0x1F44ED4", Offset = "0x1F43ED4", VA = "0x1F44ED4")]
	private Vector3 easeInQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000748")]
	[Address(RVA = "0x1F44F54", Offset = "0x1F43F54", VA = "0x1F44F54")]
	private Vector3 easeOutQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000749")]
	[Address(RVA = "0x1F44FE4", Offset = "0x1F43FE4", VA = "0x1F44FE4")]
	private Vector3 easeInOutQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600074A")]
	[Address(RVA = "0x1F450B8", Offset = "0x1F440B8", VA = "0x1F450B8")]
	private Vector3 easeInQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600074B")]
	[Address(RVA = "0x1F4513C", Offset = "0x1F4413C", VA = "0x1F4513C")]
	private Vector3 easeOutQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600074C")]
	[Address(RVA = "0x1F451D0", Offset = "0x1F441D0", VA = "0x1F451D0")]
	private Vector3 easeInOutQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600074D")]
	[Address(RVA = "0x1F4528C", Offset = "0x1F4428C", VA = "0x1F4528C")]
	private Vector3 easeInSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600074E")]
	[Address(RVA = "0x1F4534C", Offset = "0x1F4434C", VA = "0x1F4534C")]
	private Vector3 easeOutSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600074F")]
	[Address(RVA = "0x1F45400", Offset = "0x1F44400", VA = "0x1F45400")]
	private Vector3 easeInOutSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000750")]
	[Address(RVA = "0x1F45490", Offset = "0x1F44490", VA = "0x1F45490")]
	private Vector3 easeInExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000751")]
	[Address(RVA = "0x1F45518", Offset = "0x1F44518", VA = "0x1F45518")]
	private Vector3 easeOutExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000752")]
	[Address(RVA = "0x1F455A0", Offset = "0x1F445A0", VA = "0x1F455A0")]
	private Vector3 easeInOutExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000753")]
	[Address(RVA = "0x1F4566C", Offset = "0x1F4466C", VA = "0x1F4566C")]
	private Vector3 easeInCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000754")]
	[Address(RVA = "0x1F456FC", Offset = "0x1F446FC", VA = "0x1F456FC")]
	private Vector3 easeOutCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000755")]
	[Address(RVA = "0x1F45788", Offset = "0x1F44788", VA = "0x1F45788")]
	private Vector3 easeInOutCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000756")]
	[Address(RVA = "0x1F45868", Offset = "0x1F44868", VA = "0x1F45868")]
	private Vector3 easeInBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000757")]
	[Address(RVA = "0x1F45994", Offset = "0x1F44994", VA = "0x1F45994")]
	private Vector3 easeOutBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000758")]
	[Address(RVA = "0x1F45AFC", Offset = "0x1F44AFC", VA = "0x1F45AFC")]
	private Vector3 easeInOutBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000759")]
	[Address(RVA = "0x1F45CD8", Offset = "0x1F44CD8", VA = "0x1F45CD8")]
	private Vector3 easeInBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600075A")]
	[Address(RVA = "0x1F45D7C", Offset = "0x1F44D7C", VA = "0x1F45D7C")]
	private Vector3 easeOutBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600075B")]
	[Address(RVA = "0x1F45E24", Offset = "0x1F44E24", VA = "0x1F45E24")]
	private Vector3 easeInOutBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600075C")]
	[Address(RVA = "0x1F45F28", Offset = "0x1F44F28", VA = "0x1F45F28")]
	private Vector3 easeInElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600075D")]
	[Address(RVA = "0x1F46008", Offset = "0x1F45008", VA = "0x1F46008")]
	private Vector3 easeOutElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600075E")]
	[Address(RVA = "0x1F460E8", Offset = "0x1F450E8", VA = "0x1F460E8")]
	private Vector3 easeInOutElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600075F")]
	[Address(RVA = "0x1F461C8", Offset = "0x1F451C8", VA = "0x1F461C8")]
	public LTDescr setOvershoot(float overshoot)
	{
		return null;
	}

	[Token(Token = "0x6000760")]
	[Address(RVA = "0x1F461D0", Offset = "0x1F451D0", VA = "0x1F461D0")]
	public LTDescr setPeriod(float period)
	{
		return null;
	}

	[Token(Token = "0x6000761")]
	[Address(RVA = "0x1F461D8", Offset = "0x1F451D8", VA = "0x1F461D8")]
	public LTDescr setScale(float scale)
	{
		return null;
	}

	[Token(Token = "0x6000762")]
	[Address(RVA = "0x1F461E0", Offset = "0x1F451E0", VA = "0x1F461E0")]
	public LTDescr setEase(AnimationCurve easeCurve)
	{
		return null;
	}

	[Token(Token = "0x6000763")]
	[Address(RVA = "0x1F46274", Offset = "0x1F45274", VA = "0x1F46274")]
	public LTDescr setTo(Vector3 to)
	{
		return null;
	}

	[Token(Token = "0x6000764")]
	[Address(RVA = "0x1F462A4", Offset = "0x1F452A4", VA = "0x1F462A4")]
	public LTDescr setTo(Transform to)
	{
		return null;
	}

	[Token(Token = "0x6000765")]
	[Address(RVA = "0x1F462C0", Offset = "0x1F452C0", VA = "0x1F462C0")]
	public LTDescr setFrom(Vector3 from)
	{
		return null;
	}

	[Token(Token = "0x6000766")]
	[Address(RVA = "0x1F46384", Offset = "0x1F45384", VA = "0x1F46384")]
	public LTDescr setFrom(float from)
	{
		return null;
	}

	[Token(Token = "0x6000767")]
	[Address(RVA = "0x1F46390", Offset = "0x1F45390", VA = "0x1F46390")]
	public LTDescr setDiff(Vector3 diff)
	{
		return null;
	}

	[Token(Token = "0x6000768")]
	[Address(RVA = "0x1F4639C", Offset = "0x1F4539C", VA = "0x1F4639C")]
	public LTDescr setHasInitialized(bool has)
	{
		return null;
	}

	[Token(Token = "0x6000769")]
	[Address(RVA = "0x1F463A8", Offset = "0x1F453A8", VA = "0x1F463A8")]
	public LTDescr setId(uint id, uint global_counter)
	{
		return null;
	}

	[Token(Token = "0x600076A")]
	[Address(RVA = "0x1F463B4", Offset = "0x1F453B4", VA = "0x1F463B4")]
	public LTDescr setPassed(float passed)
	{
		return null;
	}

	[Token(Token = "0x600076B")]
	[Address(RVA = "0x1F463BC", Offset = "0x1F453BC", VA = "0x1F463BC")]
	public LTDescr setTime(float time)
	{
		return null;
	}

	[Token(Token = "0x600076C")]
	[Address(RVA = "0x1F463D8", Offset = "0x1F453D8", VA = "0x1F463D8")]
	public LTDescr setSpeed(float speed)
	{
		return null;
	}

	[Token(Token = "0x600076D")]
	[Address(RVA = "0x1F46400", Offset = "0x1F45400", VA = "0x1F46400")]
	public LTDescr setRepeat(int repeat)
	{
		return null;
	}

	[Token(Token = "0x600076E")]
	[Address(RVA = "0x1F46450", Offset = "0x1F45450", VA = "0x1F46450")]
	public LTDescr setLoopType(LeanTweenType loopType)
	{
		return null;
	}

	[Token(Token = "0x600076F")]
	[Address(RVA = "0x1F46458", Offset = "0x1F45458", VA = "0x1F46458")]
	public LTDescr setUseEstimatedTime(bool useEstimatedTime)
	{
		return null;
	}

	[Token(Token = "0x6000770")]
	[Address(RVA = "0x1F46468", Offset = "0x1F45468", VA = "0x1F46468")]
	public LTDescr setIgnoreTimeScale(bool useUnScaledTime)
	{
		return null;
	}

	[Token(Token = "0x6000771")]
	[Address(RVA = "0x1F46478", Offset = "0x1F45478", VA = "0x1F46478")]
	public LTDescr setUseFrames(bool useFrames)
	{
		return null;
	}

	[Token(Token = "0x6000772")]
	[Address(RVA = "0x1F46488", Offset = "0x1F45488", VA = "0x1F46488")]
	public LTDescr setUseManualTime(bool useManualTime)
	{
		return null;
	}

	[Token(Token = "0x6000773")]
	[Address(RVA = "0x1F46498", Offset = "0x1F45498", VA = "0x1F46498")]
	public LTDescr setLoopCount(int loopCount)
	{
		return null;
	}

	[Token(Token = "0x6000774")]
	[Address(RVA = "0x1F464A8", Offset = "0x1F454A8", VA = "0x1F464A8")]
	public LTDescr setLoopOnce()
	{
		return null;
	}

	[Token(Token = "0x6000775")]
	[Address(RVA = "0x1F464B4", Offset = "0x1F454B4", VA = "0x1F464B4")]
	public LTDescr setLoopClamp()
	{
		return null;
	}

	[Token(Token = "0x6000776")]
	[Address(RVA = "0x1F464D4", Offset = "0x1F454D4", VA = "0x1F464D4")]
	public LTDescr setLoopClamp(int loops)
	{
		return null;
	}

	[Token(Token = "0x6000777")]
	[Address(RVA = "0x1F464DC", Offset = "0x1F454DC", VA = "0x1F464DC")]
	public LTDescr setLoopPingPong()
	{
		return null;
	}

	[Token(Token = "0x6000778")]
	[Address(RVA = "0x1F464FC", Offset = "0x1F454FC", VA = "0x1F464FC")]
	public LTDescr setLoopPingPong(int loops)
	{
		return null;
	}

	[Token(Token = "0x6000779")]
	[Address(RVA = "0x1F46518", Offset = "0x1F45518", VA = "0x1F46518")]
	public LTDescr setOnComplete(Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x600077A")]
	[Address(RVA = "0x1F4653C", Offset = "0x1F4553C", VA = "0x1F4653C")]
	public LTDescr setOnComplete(Action<object> onComplete)
	{
		return null;
	}

	[Token(Token = "0x600077B")]
	[Address(RVA = "0x1F46560", Offset = "0x1F45560", VA = "0x1F46560")]
	public LTDescr setOnComplete(Action<object> onComplete, object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x600077C")]
	[Address(RVA = "0x1F4658C", Offset = "0x1F4558C", VA = "0x1F4658C")]
	public LTDescr setOnCompleteParam(object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x600077D")]
	[Address(RVA = "0x1F465B0", Offset = "0x1F455B0", VA = "0x1F465B0")]
	public LTDescr setOnUpdate(Action<float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x600077E")]
	[Address(RVA = "0x1F465D4", Offset = "0x1F455D4", VA = "0x1F465D4")]
	public LTDescr setOnUpdateRatio(Action<float, float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x600077F")]
	[Address(RVA = "0x1F465F8", Offset = "0x1F455F8", VA = "0x1F465F8")]
	public LTDescr setOnUpdateObject(Action<float, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000780")]
	[Address(RVA = "0x1F4661C", Offset = "0x1F4561C", VA = "0x1F4661C")]
	public LTDescr setOnUpdateVector2(Action<Vector2> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000781")]
	[Address(RVA = "0x1F46640", Offset = "0x1F45640", VA = "0x1F46640")]
	public LTDescr setOnUpdateVector3(Action<Vector3> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000782")]
	[Address(RVA = "0x1F46664", Offset = "0x1F45664", VA = "0x1F46664")]
	public LTDescr setOnUpdateColor(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000783")]
	[Address(RVA = "0x1F46688", Offset = "0x1F45688", VA = "0x1F46688")]
	public LTDescr setOnUpdateColor(Action<Color, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000784")]
	[Address(RVA = "0x1F466AC", Offset = "0x1F456AC", VA = "0x1F466AC")]
	public LTDescr setOnUpdate(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000785")]
	[Address(RVA = "0x1F466D0", Offset = "0x1F456D0", VA = "0x1F466D0")]
	public LTDescr setOnUpdate(Action<Color, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000786")]
	[Address(RVA = "0x1F466F4", Offset = "0x1F456F4", VA = "0x1F466F4")]
	public LTDescr setOnUpdate(Action<float, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x6000787")]
	[Address(RVA = "0x1F46720", Offset = "0x1F45720", VA = "0x1F46720")]
	public LTDescr setOnUpdate(Action<Vector3, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x6000788")]
	[Address(RVA = "0x1F4674C", Offset = "0x1F4574C", VA = "0x1F4674C")]
	public LTDescr setOnUpdate(Action<Vector2> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x6000789")]
	[Address(RVA = "0x1F46778", Offset = "0x1F45778", VA = "0x1F46778")]
	public LTDescr setOnUpdate(Action<Vector3> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600078A")]
	[Address(RVA = "0x1F467A4", Offset = "0x1F457A4", VA = "0x1F467A4")]
	public LTDescr setOnUpdateParam(object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600078B")]
	[Address(RVA = "0x1F467C0", Offset = "0x1F457C0", VA = "0x1F467C0")]
	public LTDescr setOrientToPath(bool doesOrient)
	{
		return null;
	}

	[Token(Token = "0x600078C")]
	[Address(RVA = "0x1F4687C", Offset = "0x1F4587C", VA = "0x1F4687C")]
	public LTDescr setOrientToPath2d(bool doesOrient2d)
	{
		return null;
	}

	[Token(Token = "0x600078D")]
	[Address(RVA = "0x1F468D8", Offset = "0x1F458D8", VA = "0x1F468D8")]
	public LTDescr setRect(LTRect rect)
	{
		return null;
	}

	[Token(Token = "0x600078E")]
	[Address(RVA = "0x1F468F4", Offset = "0x1F458F4", VA = "0x1F468F4")]
	public LTDescr setRect(Rect rect)
	{
		return null;
	}

	[Token(Token = "0x600078F")]
	[Address(RVA = "0x1F46988", Offset = "0x1F45988", VA = "0x1F46988")]
	public LTDescr setPath(LTBezierPath path)
	{
		return null;
	}

	[Token(Token = "0x6000790")]
	[Address(RVA = "0x1F469A4", Offset = "0x1F459A4", VA = "0x1F469A4")]
	public LTDescr setPoint(Vector3 point)
	{
		return null;
	}

	[Token(Token = "0x6000791")]
	[Address(RVA = "0x1F469C4", Offset = "0x1F459C4", VA = "0x1F469C4")]
	public LTDescr setDestroyOnComplete(bool doesDestroy)
	{
		return null;
	}

	[Token(Token = "0x6000792")]
	[Address(RVA = "0x1F469D0", Offset = "0x1F459D0", VA = "0x1F469D0")]
	public LTDescr setAudio(object audio)
	{
		return null;
	}

	[Token(Token = "0x6000793")]
	[Address(RVA = "0x1F46444", Offset = "0x1F45444", VA = "0x1F46444")]
	public LTDescr setOnCompleteOnRepeat(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x6000794")]
	[Address(RVA = "0x1F469EC", Offset = "0x1F459EC", VA = "0x1F469EC")]
	public LTDescr setOnCompleteOnStart(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x6000795")]
	[Address(RVA = "0x1F469F8", Offset = "0x1F459F8", VA = "0x1F469F8")]
	public LTDescr setRect(RectTransform rect)
	{
		return null;
	}

	[Token(Token = "0x6000796")]
	[Address(RVA = "0x1F46A00", Offset = "0x1F45A00", VA = "0x1F46A00")]
	public LTDescr setSprites(Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x6000797")]
	[Address(RVA = "0x1F46A08", Offset = "0x1F45A08", VA = "0x1F46A08")]
	public LTDescr setFrameRate(float frameRate)
	{
		return null;
	}

	[Token(Token = "0x6000798")]
	[Address(RVA = "0x1F46A30", Offset = "0x1F45A30", VA = "0x1F46A30")]
	public LTDescr setOnStart(Action onStart)
	{
		return null;
	}

	[Token(Token = "0x6000799")]
	[Address(RVA = "0x1F46A4C", Offset = "0x1F45A4C", VA = "0x1F46A4C")]
	public LTDescr setDirection(float direction)
	{
		return null;
	}

	[Token(Token = "0x600079A")]
	[Address(RVA = "0x1F46C0C", Offset = "0x1F45C0C", VA = "0x1F46C0C")]
	public LTDescr setRecursive(bool useRecursion)
	{
		return null;
	}
}
[Token(Token = "0x2000077")]
public class LTDescrOptional
{
	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public AnimationCurve animationCurve;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int initFrameCount;

	[Token(Token = "0x17000117")]
	public Transform toTrans
	{
		[Token(Token = "0x6000801")]
		[Address(RVA = "0x1F6C284", Offset = "0x1F6B284", VA = "0x1F6C284")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000802")]
		[Address(RVA = "0x1F6C28C", Offset = "0x1F6B28C", VA = "0x1F6C28C")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000118")]
	public Vector3 point
	{
		[Token(Token = "0x6000803")]
		[Address(RVA = "0x1F6C294", Offset = "0x1F6B294", VA = "0x1F6C294")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000804")]
		[Address(RVA = "0x1F6C2A0", Offset = "0x1F6B2A0", VA = "0x1F6C2A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000119")]
	public Vector3 axis
	{
		[Token(Token = "0x6000805")]
		[Address(RVA = "0x1F6C2AC", Offset = "0x1F6B2AC", VA = "0x1F6C2AC")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000806")]
		[Address(RVA = "0x1F6C2B8", Offset = "0x1F6B2B8", VA = "0x1F6C2B8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700011A")]
	public float lastVal
	{
		[Token(Token = "0x6000807")]
		[Address(RVA = "0x1F6C2C4", Offset = "0x1F6B2C4", VA = "0x1F6C2C4")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000808")]
		[Address(RVA = "0x1F6C2CC", Offset = "0x1F6B2CC", VA = "0x1F6C2CC")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700011B")]
	public Quaternion origRotation
	{
		[Token(Token = "0x6000809")]
		[Address(RVA = "0x1F6C2D4", Offset = "0x1F6B2D4", VA = "0x1F6C2D4")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x600080A")]
		[Address(RVA = "0x1F6C2E0", Offset = "0x1F6B2E0", VA = "0x1F6C2E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700011C")]
	public LTBezierPath path
	{
		[Token(Token = "0x600080B")]
		[Address(RVA = "0x1F6C2EC", Offset = "0x1F6B2EC", VA = "0x1F6C2EC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600080C")]
		[Address(RVA = "0x1F6C2F4", Offset = "0x1F6B2F4", VA = "0x1F6C2F4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700011D")]
	public LTSpline spline
	{
		[Token(Token = "0x600080D")]
		[Address(RVA = "0x1F6C2FC", Offset = "0x1F6B2FC", VA = "0x1F6C2FC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600080E")]
		[Address(RVA = "0x1F6C304", Offset = "0x1F6B304", VA = "0x1F6C304")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700011E")]
	public LTRect ltRect
	{
		[Token(Token = "0x600080F")]
		[Address(RVA = "0x1F6C30C", Offset = "0x1F6B30C", VA = "0x1F6C30C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000810")]
		[Address(RVA = "0x1F6C314", Offset = "0x1F6B314", VA = "0x1F6C314")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700011F")]
	public Action<float> onUpdateFloat
	{
		[Token(Token = "0x6000811")]
		[Address(RVA = "0x1F6C31C", Offset = "0x1F6B31C", VA = "0x1F6C31C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000812")]
		[Address(RVA = "0x1F6C324", Offset = "0x1F6B324", VA = "0x1F6C324")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000120")]
	public Action<float, float> onUpdateFloatRatio
	{
		[Token(Token = "0x6000813")]
		[Address(RVA = "0x1F6C32C", Offset = "0x1F6B32C", VA = "0x1F6C32C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000814")]
		[Address(RVA = "0x1F6C334", Offset = "0x1F6B334", VA = "0x1F6C334")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000121")]
	public Action<float, object> onUpdateFloatObject
	{
		[Token(Token = "0x6000815")]
		[Address(RVA = "0x1F6C33C", Offset = "0x1F6B33C", VA = "0x1F6C33C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000816")]
		[Address(RVA = "0x1F6C344", Offset = "0x1F6B344", VA = "0x1F6C344")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000122")]
	public Action<Vector2> onUpdateVector2
	{
		[Token(Token = "0x6000817")]
		[Address(RVA = "0x1F6C34C", Offset = "0x1F6B34C", VA = "0x1F6C34C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000818")]
		[Address(RVA = "0x1F6C354", Offset = "0x1F6B354", VA = "0x1F6C354")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000123")]
	public Action<Vector3> onUpdateVector3
	{
		[Token(Token = "0x6000819")]
		[Address(RVA = "0x1F6C35C", Offset = "0x1F6B35C", VA = "0x1F6C35C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600081A")]
		[Address(RVA = "0x1F6C364", Offset = "0x1F6B364", VA = "0x1F6C364")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000124")]
	public Action<Vector3, object> onUpdateVector3Object
	{
		[Token(Token = "0x600081B")]
		[Address(RVA = "0x1F6C36C", Offset = "0x1F6B36C", VA = "0x1F6C36C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600081C")]
		[Address(RVA = "0x1F6C374", Offset = "0x1F6B374", VA = "0x1F6C374")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000125")]
	public Action<Color> onUpdateColor
	{
		[Token(Token = "0x600081D")]
		[Address(RVA = "0x1F6C37C", Offset = "0x1F6B37C", VA = "0x1F6C37C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600081E")]
		[Address(RVA = "0x1F6C384", Offset = "0x1F6B384", VA = "0x1F6C384")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000126")]
	public Action<Color, object> onUpdateColorObject
	{
		[Token(Token = "0x600081F")]
		[Address(RVA = "0x1F6C38C", Offset = "0x1F6B38C", VA = "0x1F6C38C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000820")]
		[Address(RVA = "0x1F6C394", Offset = "0x1F6B394", VA = "0x1F6C394")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000127")]
	public Action onComplete
	{
		[Token(Token = "0x6000821")]
		[Address(RVA = "0x1F6C39C", Offset = "0x1F6B39C", VA = "0x1F6C39C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000822")]
		[Address(RVA = "0x1F6C3A4", Offset = "0x1F6B3A4", VA = "0x1F6C3A4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000128")]
	public Action<object> onCompleteObject
	{
		[Token(Token = "0x6000823")]
		[Address(RVA = "0x1F6C3AC", Offset = "0x1F6B3AC", VA = "0x1F6C3AC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000824")]
		[Address(RVA = "0x1F6C3B4", Offset = "0x1F6B3B4", VA = "0x1F6C3B4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000129")]
	public object onCompleteParam
	{
		[Token(Token = "0x6000825")]
		[Address(RVA = "0x1F6C3BC", Offset = "0x1F6B3BC", VA = "0x1F6C3BC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000826")]
		[Address(RVA = "0x1F6C3C4", Offset = "0x1F6B3C4", VA = "0x1F6C3C4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700012A")]
	public object onUpdateParam
	{
		[Token(Token = "0x6000827")]
		[Address(RVA = "0x1F6C3CC", Offset = "0x1F6B3CC", VA = "0x1F6C3CC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000828")]
		[Address(RVA = "0x1F6C3D4", Offset = "0x1F6B3D4", VA = "0x1F6C3D4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700012B")]
	public Action onStart
	{
		[Token(Token = "0x6000829")]
		[Address(RVA = "0x1F6C3DC", Offset = "0x1F6B3DC", VA = "0x1F6C3DC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600082A")]
		[Address(RVA = "0x1F6C3E4", Offset = "0x1F6B3E4", VA = "0x1F6C3E4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600082B")]
	[Address(RVA = "0x1F6C3EC", Offset = "0x1F6B3EC", VA = "0x1F6C3EC")]
	public void reset()
	{
	}

	[Token(Token = "0x600082C")]
	[Address(RVA = "0x1F6C468", Offset = "0x1F6B468", VA = "0x1F6C468")]
	public void callOnUpdate(float val, float ratioPassed)
	{
	}

	[Token(Token = "0x600082D")]
	[Address(RVA = "0x1F6C5CC", Offset = "0x1F6B5CC", VA = "0x1F6C5CC")]
	public LTDescrOptional()
	{
	}
}
[Token(Token = "0x2000078")]
public class LTSeq
{
	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public LTSeq previous;

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LTSeq current;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public LTDescr tween;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float totalDelay;

	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float timeScale;

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int debugIter;

	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public uint counter;

	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool toggle;

	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private uint _id;

	[Token(Token = "0x1700012C")]
	public int id
	{
		[Token(Token = "0x600082E")]
		[Address(RVA = "0x1F6C5D4", Offset = "0x1F6B5D4", VA = "0x1F6C5D4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600082F")]
	[Address(RVA = "0x1F6C5E4", Offset = "0x1F6B5E4", VA = "0x1F6C5E4")]
	public void reset()
	{
	}

	[Token(Token = "0x6000830")]
	[Address(RVA = "0x1F6C5F4", Offset = "0x1F6B5F4", VA = "0x1F6C5F4")]
	public void init(uint id, uint global_counter)
	{
	}

	[Token(Token = "0x6000831")]
	[Address(RVA = "0x1F6C60C", Offset = "0x1F6B60C", VA = "0x1F6C60C")]
	private LTSeq addOn()
	{
		return null;
	}

	[Token(Token = "0x6000832")]
	[Address(RVA = "0x1F6C6A0", Offset = "0x1F6B6A0", VA = "0x1F6C6A0")]
	private float addPreviousDelays()
	{
		return default(float);
	}

	[Token(Token = "0x6000833")]
	[Address(RVA = "0x1F6C6DC", Offset = "0x1F6B6DC", VA = "0x1F6C6DC")]
	public LTSeq append(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000834")]
	[Address(RVA = "0x1F6C700", Offset = "0x1F6B700", VA = "0x1F6C700")]
	public LTSeq append(Action callback)
	{
		return null;
	}

	[Token(Token = "0x6000835")]
	[Address(RVA = "0x1F6C7D0", Offset = "0x1F6B7D0", VA = "0x1F6C7D0")]
	public LTSeq append(Action<object> callback, object obj)
	{
		return null;
	}

	[Token(Token = "0x6000836")]
	[Address(RVA = "0x1F6C864", Offset = "0x1F6B864", VA = "0x1F6C864")]
	public LTSeq append(GameObject gameObject, Action callback)
	{
		return null;
	}

	[Token(Token = "0x6000837")]
	[Address(RVA = "0x1F6C8E8", Offset = "0x1F6B8E8", VA = "0x1F6C8E8")]
	public LTSeq append(GameObject gameObject, Action<object> callback, object obj)
	{
		return null;
	}

	[Token(Token = "0x6000838")]
	[Address(RVA = "0x1F6C77C", Offset = "0x1F6B77C", VA = "0x1F6C77C")]
	public LTSeq append(LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x6000839")]
	[Address(RVA = "0x1F6C98C", Offset = "0x1F6B98C", VA = "0x1F6C98C")]
	public LTSeq insert(LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x600083A")]
	[Address(RVA = "0x1F6C9D0", Offset = "0x1F6B9D0", VA = "0x1F6C9D0")]
	public LTSeq setScale(float timeScale)
	{
		return null;
	}

	[Token(Token = "0x600083B")]
	[Address(RVA = "0x1F6C9F0", Offset = "0x1F6B9F0", VA = "0x1F6C9F0")]
	private void setScaleRecursive(LTSeq seq, float timeScale, int count)
	{
	}

	[Token(Token = "0x600083C")]
	[Address(RVA = "0x1F6CA84", Offset = "0x1F6BA84", VA = "0x1F6CA84")]
	public LTSeq reverse()
	{
		return null;
	}

	[Token(Token = "0x600083D")]
	[Address(RVA = "0x1F6CA88", Offset = "0x1F6BA88", VA = "0x1F6CA88")]
	public LTSeq()
	{
	}
}
[Token(Token = "0x2000079")]
[AddComponentMenu("LeanTween/LeanTweenPath")]
public class LeanTweenPath : MonoBehaviour
{
	[Token(Token = "0x200007A")]
	public enum LeanTweenPathType
	{
		[Token(Token = "0x4000405")]
		bezier,
		[Token(Token = "0x4000406")]
		spline
	}

	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int count;

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform[] pts;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3[] path;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public LeanTweenPathType pathType;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float controlSize;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool showArrows;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool nodesMaximized;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	public bool creatorMaximized;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x43")]
	public bool importMaximized;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int i;

	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int k;

	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int lastCount;

	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Color curveColor;

	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static Color lineColor;

	[Token(Token = "0x1700012D")]
	public Vector3[] vec3
	{
		[Token(Token = "0x6000846")]
		[Address(RVA = "0x1F6EBA4", Offset = "0x1F6DBA4", VA = "0x1F6EBA4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000847")]
		[Address(RVA = "0x1F6ECD0", Offset = "0x1F6DCD0", VA = "0x1F6ECD0")]
		set
		{
		}
	}

	[Token(Token = "0x600083E")]
	[Address(RVA = "0x1F6CA90", Offset = "0x1F6BA90", VA = "0x1F6CA90")]
	private void init()
	{
	}

	[Token(Token = "0x600083F")]
	[Address(RVA = "0x1F6D8CC", Offset = "0x1F6C8CC", VA = "0x1F6D8CC")]
	private void reset()
	{
	}

	[Token(Token = "0x6000840")]
	[Address(RVA = "0x1F6D74C", Offset = "0x1F6C74C", VA = "0x1F6D74C")]
	public Transform createChild(int i, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000841")]
	[Address(RVA = "0x1F6DCC8", Offset = "0x1F6CCC8", VA = "0x1F6DCC8")]
	private void initNode(Transform trans, int i)
	{
	}

	[Token(Token = "0x6000842")]
	[Address(RVA = "0x1F6E16C", Offset = "0x1F6D16C", VA = "0x1F6E16C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000843")]
	[Address(RVA = "0x1F6E254", Offset = "0x1F6D254", VA = "0x1F6E254")]
	public void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000844")]
	[Address(RVA = "0x1F6E97C", Offset = "0x1F6D97C", VA = "0x1F6E97C")]
	public Vector3[] splineVector()
	{
		return null;
	}

	[Token(Token = "0x6000845")]
	[Address(RVA = "0x1F6EACC", Offset = "0x1F6DACC", VA = "0x1F6EACC")]
	public Vector3[] splineVectorNoEndCaps()
	{
		return null;
	}

	[Token(Token = "0x6000848")]
	[Address(RVA = "0x1F6ECD4", Offset = "0x1F6DCD4", VA = "0x1F6ECD4")]
	private void resetPath()
	{
	}

	[Token(Token = "0x6000849")]
	[Address(RVA = "0x1F6EDB0", Offset = "0x1F6DDB0", VA = "0x1F6EDB0")]
	public void addNode()
	{
	}

	[Token(Token = "0x600084A")]
	[Address(RVA = "0x1F6EDE0", Offset = "0x1F6DDE0", VA = "0x1F6EDE0")]
	public void addNodeAfter(int after)
	{
	}

	[Token(Token = "0x600084B")]
	[Address(RVA = "0x1F6F2C8", Offset = "0x1F6E2C8", VA = "0x1F6F2C8")]
	public void deleteNode(int i)
	{
	}

	[Token(Token = "0x600084C")]
	[Address(RVA = "0x1F6F37C", Offset = "0x1F6E37C", VA = "0x1F6F37C")]
	public LeanTweenPath()
	{
	}
}
[Token(Token = "0x200007B")]
[ExecuteInEditMode]
public class LeanTweenPathControl : MonoBehaviour
{
	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 lastPos;

	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3[] lastPosControl;

	[Token(Token = "0x4000409")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public LeanTweenPathControl[] controlRef;

	[Token(Token = "0x400040A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int i;

	[Token(Token = "0x400040B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool isControl;

	[Token(Token = "0x400040C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
	public bool isBezier;

	[Token(Token = "0x400040D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Material matPoints;

	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Material matControls;

	[Token(Token = "0x600084D")]
	[Address(RVA = "0x1F6F39C", Offset = "0x1F6E39C", VA = "0x1F6F39C")]
	public void createMaterials()
	{
	}

	[Token(Token = "0x600084E")]
	[Address(RVA = "0x1F6F548", Offset = "0x1F6E548", VA = "0x1F6F548")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600084F")]
	[Address(RVA = "0x1F6F54C", Offset = "0x1F6E54C", VA = "0x1F6F54C")]
	private void OnApplicationFocus()
	{
	}

	[Token(Token = "0x6000850")]
	[Address(RVA = "0x1F6F5F4", Offset = "0x1F6E5F4", VA = "0x1F6F5F4")]
	private void OnBecameInvisible()
	{
	}

	[Token(Token = "0x6000851")]
	[Address(RVA = "0x1F6F5A0", Offset = "0x1F6E5A0", VA = "0x1F6F5A0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000852")]
	[Address(RVA = "0x1F6DF04", Offset = "0x1F6CF04", VA = "0x1F6DF04")]
	public void init(LeanTweenPathControl[] controlRef, int i, bool isControl)
	{
	}

	[Token(Token = "0x6000853")]
	[Address(RVA = "0x1F6E0D4", Offset = "0x1F6D0D4", VA = "0x1F6E0D4")]
	public void init(int i)
	{
	}

	[Token(Token = "0x6000854")]
	[Address(RVA = "0x1F6F648", Offset = "0x1F6E648", VA = "0x1F6F648")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000855")]
	[Address(RVA = "0x1F6FA40", Offset = "0x1F6EA40", VA = "0x1F6FA40")]
	public LeanTweenPathControl()
	{
	}
}
[Token(Token = "0x200007C")]
public class MetroJoystick
{
	[Token(Token = "0x400040F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool fixedThrottle;

	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	public static bool pressedA;

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
	public static bool pressedB;

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
	public static bool pressedY;

	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static bool pressedX;

	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static float LX;

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static float LY;

	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static float RX;

	[Token(Token = "0x4000417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public static float RY;

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static bool DD;

	[Token(Token = "0x4000419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public static bool DU;

	[Token(Token = "0x400041A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public static bool DL;

	[Token(Token = "0x400041B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public static bool DR;

	[Token(Token = "0x6000856")]
	[Address(RVA = "0x1F6FA48", Offset = "0x1F6EA48", VA = "0x1F6FA48")]
	public MetroJoystick()
	{
	}
}
[Token(Token = "0x200007D")]
public class MyInputManager
{
	[Token(Token = "0x200007E")]
	public enum GearDirection
	{
		[Token(Token = "0x400046B")]
		Down,
		[Token(Token = "0x400046C")]
		Up
	}

	[Token(Token = "0x200007F")]
	public enum CharacterType
	{
		[Token(Token = "0x400046E")]
		Unknown,
		[Token(Token = "0x400046F")]
		Plane,
		[Token(Token = "0x4000470")]
		FPS,
		[Token(Token = "0x4000471")]
		Parachute,
		[Token(Token = "0x4000472")]
		Tank
	}

	[StructLayout(LayoutKind.Explicit)]
	[Token(Token = "0x2000080")]
	[NetworkInputWeaved(67)]
	public struct NetworkMyInput : INetworkInput
	{
		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector2 axis;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector2 look;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NetworkBool fire;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public NetworkBool bomb;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CharacterType type;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public NetworkBool spawning;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float rudder;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float maxspeed;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float enginepower;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public uint internalid;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public NetworkBool brake;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public NetworkBool crashed;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public NetworkBool controlReleased;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public NetworkBool droppedWheel;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public NetworkBool smoking;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public GearDirection CurrentGearDirection;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public NetworkBool isSwimming;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public NetworkBool isClimbing;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 myLeftRightRot;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 targetPosition;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Vector3 characterForward;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Quaternion steer;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float brakeTorque;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Quaternion torretRot;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Quaternion canonRot;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Quaternion headRot;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float targetTorque;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float steerAngle;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float motorRPM;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public int currentGear;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float shiftTime;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public Vector3 fromShoot;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Vector3 aimDirection;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public Vector3 grenadepos;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Vector3 linearVelocity;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public Vector3 angularVelocity;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public float impulse;
	}

	[Token(Token = "0x2000081")]
	private enum ActionIds
	{
		[Token(Token = "0x4000499")]
		MoveHorizontal = 0,
		[Token(Token = "0x400049A")]
		MoveVertical = 1,
		[Token(Token = "0x400049B")]
		Throttle = 2,
		[Token(Token = "0x400049C")]
		HorizontalView = 12,
		[Token(Token = "0x400049D")]
		VerticalView = 13,
		[Token(Token = "0x400049E")]
		Rudder = 21
	}

	[Token(Token = "0x400041C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static InputActionReference rightTrigger;

	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static InputActionReference leftTrigger;

	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static InputActionReference leftTriggerValue;

	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static InputActionReference rightJoystick;

	[Token(Token = "0x4000420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static InputActionReference leftJoystick;

	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static InputActionReference rightAButton;

	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static InputActionReference rightBButton;

	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static InputActionReference rightGrip;

	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static InputActionReference leftAButton;

	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static InputActionReference leftBButton;

	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static InputActionReference leftGrip;

	[Token(Token = "0x4000427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static int playerId;

	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static Player player;

	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static bool videoTouched;

	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public static bool IsFBSessionValid;

	[Token(Token = "0x4000439")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public static bool isVideoAdAvailable;

	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private static bool pUseCustomAndroidKeyboard;

	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x101")]
	public static bool amazon;

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x102")]
	public static bool isSamsungApp;

	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x103")]
	public static bool isOuya;

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public static bool isOculus;

	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x105")]
	private static bool tvdetected;

	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x106")]
	private static bool tvresult;

	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public static Dictionary<string, int> pingInfo;

	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private static string backButton;

	[Token(Token = "0x400044A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private static string menuButton;

	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private static string bombButton;

	[Token(Token = "0x400044C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private static string cameraButton;

	[Token(Token = "0x400044D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private static string brakeButton;

	[Token(Token = "0x400044E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private static string voiceButton;

	[Token(Token = "0x400044F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private static string parachuteButton;

	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private static string gearButton;

	[Token(Token = "0x4000451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private static string grenadeButton;

	[Token(Token = "0x4000452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public static bool reversedControls;

	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x181")]
	public static bool cursorVisible;

	[Token(Token = "0x4000454")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x182")]
	private static bool? isChromebook;

	[Token(Token = "0x4000455")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private static AndroidJavaClass androidUnityActivity;

	[Token(Token = "0x4000456")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string OculusUserId;

	[Token(Token = "0x4000457")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string OculusId;

	[Token(Token = "0x4000458")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public static bool canHaveHardwareJoystick;

	[Token(Token = "0x4000459")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool supportAcc;

	[Token(Token = "0x400045A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool supportsTouch;

	[Token(Token = "0x400045B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x191")]
	private static bool backPressed;

	[Token(Token = "0x400045C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x192")]
	private static bool pIsNotChatting;

	[Token(Token = "0x400045D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
	private static float fireRate;

	[Token(Token = "0x400045E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private static float nextFire;

	[Token(Token = "0x400045F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
	private static float nextBack;

	[Token(Token = "0x4000460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private static float menuFire;

	[Token(Token = "0x4000461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
	public static float menuRate;

	[Token(Token = "0x4000462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private static MyInputManager instance;

	[Token(Token = "0x4000463")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private static bool rotating;

	[Token(Token = "0x4000464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
	private static int fingerid;

	[Token(Token = "0x4000465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private static float yOffset;

	[Token(Token = "0x4000466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
	private static float widthScale;

	[Token(Token = "0x4000467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private static float heightScale;

	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Matrix4x4 calibrationMatrix;

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public bool calibratedOnce;

	[Token(Token = "0x1700012E")]
	public static bool UseCustomAndroidKeyboard
	{
		[Token(Token = "0x6000889")]
		[Address(RVA = "0x1F72284", Offset = "0x1F71284", VA = "0x1F72284")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600088A")]
		[Address(RVA = "0x1F722DC", Offset = "0x1F712DC", VA = "0x1F722DC")]
		set
		{
		}
	}

	[Token(Token = "0x1700012F")]
	public static bool isAmazonAFTB
	{
		[Token(Token = "0x600088B")]
		[Address(RVA = "0x1F7239C", Offset = "0x1F7139C", VA = "0x1F7239C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000130")]
	public static bool isAndroidTV
	{
		[Token(Token = "0x600088C")]
		[Address(RVA = "0x1F723E8", Offset = "0x1F713E8", VA = "0x1F723E8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000131")]
	public static bool isForumAllowed
	{
		[Token(Token = "0x600088E")]
		[Address(RVA = "0x1F729AC", Offset = "0x1F719AC", VA = "0x1F729AC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000132")]
	public static bool isTV
	{
		[Token(Token = "0x600088F")]
		[Address(RVA = "0x1F72A2C", Offset = "0x1F71A2C", VA = "0x1F72A2C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000133")]
	public static bool isAppleTV
	{
		[Token(Token = "0x6000890")]
		[Address(RVA = "0x1F72AD0", Offset = "0x1F71AD0", VA = "0x1F72AD0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000134")]
	public static bool IsChromebook
	{
		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x1F73A54", Offset = "0x1F72A54", VA = "0x1F73A54")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000135")]
	public static bool useCustomKeyboard
	{
		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x1F75064", Offset = "0x1F74064", VA = "0x1F75064")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000136")]
	public static bool isNotChatting
	{
		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x1F75128", Offset = "0x1F74128", VA = "0x1F75128")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x1F75180", Offset = "0x1F74180", VA = "0x1F75180")]
		set
		{
		}
	}

	[Token(Token = "0x17000137")]
	public static MyInputManager Instance
	{
		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x1F768EC", Offset = "0x1F758EC", VA = "0x1F768EC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000001")]
	public static event Action OnVideoLoadingWatched
	{
		[Token(Token = "0x600085A")]
		[Address(RVA = "0x1F6FABC", Offset = "0x1F6EABC", VA = "0x1F6FABC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600085B")]
		[Address(RVA = "0x1F6FB98", Offset = "0x1F6EB98", VA = "0x1F6FB98")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public static event Action OnVideoWatched
	{
		[Token(Token = "0x600085D")]
		[Address(RVA = "0x1F6FD08", Offset = "0x1F6ED08", VA = "0x1F6FD08")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600085E")]
		[Address(RVA = "0x1F6FDE4", Offset = "0x1F6EDE4", VA = "0x1F6FDE4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public static event Action OnFacebookRequestLogin
	{
		[Token(Token = "0x6000860")]
		[Address(RVA = "0x1F6FF54", Offset = "0x1F6EF54", VA = "0x1F6FF54")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000861")]
		[Address(RVA = "0x1F70030", Offset = "0x1F6F030", VA = "0x1F70030")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public static event Action OnFacebookLoginSuccess
	{
		[Token(Token = "0x6000863")]
		[Address(RVA = "0x1F701A0", Offset = "0x1F6F1A0", VA = "0x1F701A0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000864")]
		[Address(RVA = "0x1F7027C", Offset = "0x1F6F27C", VA = "0x1F7027C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public static event Action<string> OnFacebookLoginError
	{
		[Token(Token = "0x6000866")]
		[Address(RVA = "0x1F703EC", Offset = "0x1F6F3EC", VA = "0x1F703EC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000867")]
		[Address(RVA = "0x1F704E0", Offset = "0x1F6F4E0", VA = "0x1F704E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public static event Action OnFacebookGetInfo
	{
		[Token(Token = "0x6000869")]
		[Address(RVA = "0x1F70670", Offset = "0x1F6F670", VA = "0x1F70670")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600086A")]
		[Address(RVA = "0x1F7074C", Offset = "0x1F6F74C", VA = "0x1F7074C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000007")]
	public static event Action<string, string, string, string> OnGotMyInfo
	{
		[Token(Token = "0x600086C")]
		[Address(RVA = "0x1F708BC", Offset = "0x1F6F8BC", VA = "0x1F708BC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600086D")]
		[Address(RVA = "0x1F709B0", Offset = "0x1F6F9B0", VA = "0x1F709B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public static event Action<string> OnSubtitle
	{
		[Token(Token = "0x600086F")]
		[Address(RVA = "0x1F70B70", Offset = "0x1F6FB70", VA = "0x1F70B70")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000870")]
		[Address(RVA = "0x1F70C64", Offset = "0x1F6FC64", VA = "0x1F70C64")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public static event Action<string> OnPlayVideo
	{
		[Token(Token = "0x6000871")]
		[Address(RVA = "0x1F70D58", Offset = "0x1F6FD58", VA = "0x1F70D58")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000872")]
		[Address(RVA = "0x1F70E4C", Offset = "0x1F6FE4C", VA = "0x1F70E4C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public static event Action OnStopVideo
	{
		[Token(Token = "0x6000873")]
		[Address(RVA = "0x1F70F40", Offset = "0x1F6FF40", VA = "0x1F70F40")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x1F7101C", Offset = "0x1F7001C", VA = "0x1F7101C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public static event Action OnVideoEnded
	{
		[Token(Token = "0x6000875")]
		[Address(RVA = "0x1F710F8", Offset = "0x1F700F8", VA = "0x1F710F8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000876")]
		[Address(RVA = "0x1F711D4", Offset = "0x1F701D4", VA = "0x1F711D4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000C")]
	public static event Action OnAskForPicture
	{
		[Token(Token = "0x6000877")]
		[Address(RVA = "0x1F712B0", Offset = "0x1F702B0", VA = "0x1F712B0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000878")]
		[Address(RVA = "0x1F7138C", Offset = "0x1F7038C", VA = "0x1F7138C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public static event Action<string, byte[]> OnTexturePicked
	{
		[Token(Token = "0x6000879")]
		[Address(RVA = "0x1F71468", Offset = "0x1F70468", VA = "0x1F71468")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600087A")]
		[Address(RVA = "0x1F7155C", Offset = "0x1F7055C", VA = "0x1F7155C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000E")]
	public static event Action OnCheckVideoAvailable
	{
		[Token(Token = "0x600087F")]
		[Address(RVA = "0x1F718B0", Offset = "0x1F708B0", VA = "0x1F718B0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000880")]
		[Address(RVA = "0x1F7198C", Offset = "0x1F7098C", VA = "0x1F7198C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000F")]
	public static event Action OnDisplayVideoLoading
	{
		[Token(Token = "0x6000882")]
		[Address(RVA = "0x1F71AFC", Offset = "0x1F70AFC", VA = "0x1F71AFC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000883")]
		[Address(RVA = "0x1F71BD8", Offset = "0x1F70BD8", VA = "0x1F71BD8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000010")]
	public static event Action OnDisplayVideoAd
	{
		[Token(Token = "0x6000885")]
		[Address(RVA = "0x1F71D90", Offset = "0x1F70D90", VA = "0x1F71D90")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000886")]
		[Address(RVA = "0x1F71E6C", Offset = "0x1F70E6C", VA = "0x1F71E6C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000011")]
	public static event Action<string> OnPing
	{
		[Token(Token = "0x6000891")]
		[Address(RVA = "0x1F72AD8", Offset = "0x1F71AD8", VA = "0x1F72AD8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000892")]
		[Address(RVA = "0x1F72BCC", Offset = "0x1F71BCC", VA = "0x1F72BCC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000012")]
	public static event Action OnDisplayReview
	{
		[Token(Token = "0x6000894")]
		[Address(RVA = "0x1F72D5C", Offset = "0x1F71D5C", VA = "0x1F72D5C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000895")]
		[Address(RVA = "0x1F72E38", Offset = "0x1F71E38", VA = "0x1F72E38")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000013")]
	public static event Action OnDisplayKeyboard
	{
		[Token(Token = "0x6000897")]
		[Address(RVA = "0x1F72FA8", Offset = "0x1F71FA8", VA = "0x1F72FA8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000898")]
		[Address(RVA = "0x1F73084", Offset = "0x1F72084", VA = "0x1F73084")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000014")]
	public static event Action OnBackButtonPressed
	{
		[Token(Token = "0x600089A")]
		[Address(RVA = "0x1F731F4", Offset = "0x1F721F4", VA = "0x1F731F4")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600089B")]
		[Address(RVA = "0x1F732D0", Offset = "0x1F722D0", VA = "0x1F732D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000015")]
	public static event Action OnQuitPressed
	{
		[Token(Token = "0x600089D")]
		[Address(RVA = "0x1F73440", Offset = "0x1F72440", VA = "0x1F73440")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600089E")]
		[Address(RVA = "0x1F7351C", Offset = "0x1F7251C", VA = "0x1F7351C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000857")]
	[Address(RVA = "0x1F6FA50", Offset = "0x1F6EA50", VA = "0x1F6FA50")]
	private static bool GetOVRButtonPress(InputActionReference actionReference)
	{
		return default(bool);
	}

	[Token(Token = "0x6000858")]
	[Address(RVA = "0x1F6FA74", Offset = "0x1F6EA74", VA = "0x1F6FA74")]
	private static bool GetOVRButtonUp(InputActionReference actionReference)
	{
		return default(bool);
	}

	[Token(Token = "0x6000859")]
	[Address(RVA = "0x1F6FA98", Offset = "0x1F6EA98", VA = "0x1F6FA98")]
	private static bool GetOVRButtonDown(InputActionReference actionReference)
	{
		return default(bool);
	}

	[Token(Token = "0x600085C")]
	[Address(RVA = "0x1F6FC74", Offset = "0x1F6EC74", VA = "0x1F6FC74")]
	public static void videoLoadingWatched()
	{
	}

	[Token(Token = "0x600085F")]
	[Address(RVA = "0x1F6FEC0", Offset = "0x1F6EEC0", VA = "0x1F6FEC0")]
	public static void videoWatched()
	{
	}

	[Token(Token = "0x6000862")]
	[Address(RVA = "0x1F7010C", Offset = "0x1F6F10C", VA = "0x1F7010C")]
	public static void FacebookLoginRequest()
	{
	}

	[Token(Token = "0x6000865")]
	[Address(RVA = "0x1F70358", Offset = "0x1F6F358", VA = "0x1F70358")]
	public static void FacebookLoginSuccess()
	{
	}

	[Token(Token = "0x6000868")]
	[Address(RVA = "0x1F705D4", Offset = "0x1F6F5D4", VA = "0x1F705D4")]
	public static void FacebookLoginError(string error)
	{
	}

	[Token(Token = "0x600086B")]
	[Address(RVA = "0x1F70828", Offset = "0x1F6F828", VA = "0x1F70828")]
	public static void FacebookGetInfo()
	{
	}

	[Token(Token = "0x600086E")]
	[Address(RVA = "0x1F70AA4", Offset = "0x1F6FAA4", VA = "0x1F70AA4")]
	public static void GotMyInfo(string error, string facebookID, string name, string email)
	{
	}

	[Token(Token = "0x600087B")]
	[Address(RVA = "0x1F71650", Offset = "0x1F70650", VA = "0x1F71650")]
	public static void Subtitle(string subtitle)
	{
	}

	[Token(Token = "0x600087C")]
	[Address(RVA = "0x1F716EC", Offset = "0x1F706EC", VA = "0x1F716EC")]
	public static void PlayVideo(string path)
	{
	}

	[Token(Token = "0x600087D")]
	[Address(RVA = "0x1F71788", Offset = "0x1F70788", VA = "0x1F71788")]
	public static void StopVideo()
	{
	}

	[Token(Token = "0x600087E")]
	[Address(RVA = "0x1F7181C", Offset = "0x1F7081C", VA = "0x1F7181C")]
	public static void VideoEnded()
	{
	}

	[Token(Token = "0x6000881")]
	[Address(RVA = "0x1F71A68", Offset = "0x1F70A68", VA = "0x1F71A68")]
	public static void CheckVideoAvailable()
	{
	}

	[Token(Token = "0x6000884")]
	[Address(RVA = "0x1F71CB4", Offset = "0x1F70CB4", VA = "0x1F71CB4")]
	public static void displayVideoLoading()
	{
	}

	[Token(Token = "0x6000887")]
	[Address(RVA = "0x1F71F48", Offset = "0x1F70F48", VA = "0x1F71F48")]
	public static void displayVideoAd()
	{
	}

	[Token(Token = "0x6000888")]
	[Address(RVA = "0x1F72024", Offset = "0x1F71024", VA = "0x1F72024")]
	public static string GetArchitecture()
	{
		return null;
	}

	[Token(Token = "0x600088D")]
	[Address(RVA = "0x1F72434", Offset = "0x1F71434", VA = "0x1F72434")]
	private static bool detectTv()
	{
		return default(bool);
	}

	[Token(Token = "0x6000893")]
	[Address(RVA = "0x1F72CC0", Offset = "0x1F71CC0", VA = "0x1F72CC0")]
	public static void Ping(string ip)
	{
	}

	[Token(Token = "0x6000896")]
	[Address(RVA = "0x1F72F14", Offset = "0x1F71F14", VA = "0x1F72F14")]
	public static void DisplayReview()
	{
	}

	[Token(Token = "0x6000899")]
	[Address(RVA = "0x1F73160", Offset = "0x1F72160", VA = "0x1F73160")]
	public static void DisplayKeyboard()
	{
	}

	[Token(Token = "0x600089C")]
	[Address(RVA = "0x1F733AC", Offset = "0x1F723AC", VA = "0x1F733AC")]
	public static void NativePress()
	{
	}

	[Token(Token = "0x600089F")]
	[Address(RVA = "0x1F735F8", Offset = "0x1F725F8", VA = "0x1F735F8")]
	public static void QuitPressed()
	{
	}

	[Token(Token = "0x60008A0")]
	[Address(RVA = "0x1F7368C", Offset = "0x1F7268C", VA = "0x1F7368C")]
	public void PickPicture()
	{
	}

	[Token(Token = "0x60008A1")]
	[Address(RVA = "0x1F73690", Offset = "0x1F72690", VA = "0x1F73690")]
	public static void HideCursor()
	{
	}

	[Token(Token = "0x60008A2")]
	[Address(RVA = "0x1F736F4", Offset = "0x1F726F4", VA = "0x1F736F4")]
	public static void DisplayCursor()
	{
	}

	[Token(Token = "0x60008A3")]
	[Address(RVA = "0x1F7375C", Offset = "0x1F7275C", VA = "0x1F7375C")]
	private static bool isVRPresent()
	{
		return default(bool);
	}

	[Token(Token = "0x60008A4")]
	[Address(RVA = "0x1F7394C", Offset = "0x1F7294C", VA = "0x1F7394C")]
	public static AndroidJavaObject GetUnityActivity()
	{
		return null;
	}

	[Token(Token = "0x60008A6")]
	[Address(RVA = "0x1F740C4", Offset = "0x1F730C4", VA = "0x1F740C4")]
	private void callbackMethod(Message msg)
	{
	}

	[Token(Token = "0x60008A7")]
	[Address(RVA = "0x1F74274", Offset = "0x1F73274", VA = "0x1F74274")]
	private void GetLoggedInUserCallback(Message<User> msg)
	{
	}

	[Token(Token = "0x60008A8")]
	[Address(RVA = "0x1F74428", Offset = "0x1F73428", VA = "0x1F74428")]
	private MyInputManager()
	{
	}

	[Token(Token = "0x60008AA")]
	[Address(RVA = "0x1F750BC", Offset = "0x1F740BC", VA = "0x1F750BC")]
	public bool supportsAccelerometer()
	{
		return default(bool);
	}

	[Token(Token = "0x60008AB")]
	[Address(RVA = "0x1F750C4", Offset = "0x1F740C4", VA = "0x1F750C4")]
	public bool supportsTouchScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x60008AC")]
	[Address(RVA = "0x1F750CC", Offset = "0x1F740CC", VA = "0x1F750CC")]
	private static void ListenBackButton()
	{
	}

	[Token(Token = "0x60008AD")]
	[Address(RVA = "0x1F74224", Offset = "0x1F73224", VA = "0x1F74224")]
	private static void Quit()
	{
	}

	[Token(Token = "0x60008B0")]
	[Address(RVA = "0x1F75200", Offset = "0x1F74200", VA = "0x1F75200")]
	public static bool IsBombPressed()
	{
		return default(bool);
	}

	[Token(Token = "0x60008B1")]
	[Address(RVA = "0x1F75300", Offset = "0x1F74300", VA = "0x1F75300")]
	public static bool IsBombHold()
	{
		return default(bool);
	}

	[Token(Token = "0x60008B2")]
	[Address(RVA = "0x1F75404", Offset = "0x1F74404", VA = "0x1F75404")]
	public static bool IsBombReleased()
	{
		return default(bool);
	}

	[Token(Token = "0x60008B3")]
	[Address(RVA = "0x1F75508", Offset = "0x1F74508", VA = "0x1F75508")]
	public static bool IsMenuPressed()
	{
		return default(bool);
	}

	[Token(Token = "0x60008B4")]
	[Address(RVA = "0x1F755B0", Offset = "0x1F745B0", VA = "0x1F755B0")]
	public static bool IsBackPressed()
	{
		return default(bool);
	}

	[Token(Token = "0x60008B5")]
	[Address(RVA = "0x1F756D0", Offset = "0x1F746D0", VA = "0x1F756D0")]
	public static void ActivateKeyboard(bool activate)
	{
	}

	[Token(Token = "0x60008B6")]
	[Address(RVA = "0x1F75774", Offset = "0x1F74774", VA = "0x1F75774")]
	public static bool isGrenadePressed()
	{
		return default(bool);
	}

	[Token(Token = "0x60008B7")]
	[Address(RVA = "0x1F75874", Offset = "0x1F74874", VA = "0x1F75874")]
	public static bool isGearPressed()
	{
		return default(bool);
	}

	[Token(Token = "0x60008B8")]
	[Address(RVA = "0x1F75974", Offset = "0x1F74974", VA = "0x1F75974")]
	public static bool isCameraPressed()
	{
		return default(bool);
	}

	[Token(Token = "0x60008B9")]
	[Address(RVA = "0x1F75A74", Offset = "0x1F74A74", VA = "0x1F75A74")]
	public static bool isMenuPressed()
	{
		return default(bool);
	}

	[Token(Token = "0x60008BA")]
	[Address(RVA = "0x1F75B38", Offset = "0x1F74B38", VA = "0x1F75B38")]
	public static bool isChatDisplayPressed()
	{
		return default(bool);
	}

	[Token(Token = "0x60008BB")]
	[Address(RVA = "0x1F75B40", Offset = "0x1F74B40", VA = "0x1F75B40")]
	public static bool isVoicePressed()
	{
		return default(bool);
	}

	[Token(Token = "0x60008BC")]
	[Address(RVA = "0x1F75C70", Offset = "0x1F74C70", VA = "0x1F75C70")]
	public static bool isParachutePressed()
	{
		return default(bool);
	}

	[Token(Token = "0x60008BD")]
	[Address(RVA = "0x1F75D18", Offset = "0x1F74D18", VA = "0x1F75D18")]
	public static bool isBrakePressed()
	{
		return default(bool);
	}

	[Token(Token = "0x60008BE")]
	[Address(RVA = "0x1F75DF8", Offset = "0x1F74DF8", VA = "0x1F75DF8")]
	public static bool nextPressed()
	{
		return default(bool);
	}

	[Token(Token = "0x60008BF")]
	[Address(RVA = "0x1F75F78", Offset = "0x1F74F78", VA = "0x1F75F78")]
	public static bool prevPressed()
	{
		return default(bool);
	}

	[Token(Token = "0x60008C0")]
	[Address(RVA = "0x1F760F8", Offset = "0x1F750F8", VA = "0x1F760F8")]
	public static bool rightAirplaneMenuPressed()
	{
		return default(bool);
	}

	[Token(Token = "0x60008C1")]
	[Address(RVA = "0x1F76258", Offset = "0x1F75258", VA = "0x1F76258")]
	public static bool leftAirplaneMenuPressed()
	{
		return default(bool);
	}

	[Token(Token = "0x60008C2")]
	[Address(RVA = "0x1F763B8", Offset = "0x1F753B8", VA = "0x1F763B8")]
	public static bool rightPressed()
	{
		return default(bool);
	}

	[Token(Token = "0x60008C3")]
	[Address(RVA = "0x1F764B8", Offset = "0x1F754B8", VA = "0x1F764B8")]
	public static bool leftPressed()
	{
		return default(bool);
	}

	[Token(Token = "0x60008C4")]
	[Address(RVA = "0x1F765B8", Offset = "0x1F755B8", VA = "0x1F765B8")]
	public static bool selectPressed()
	{
		return default(bool);
	}

	[Token(Token = "0x60008C5")]
	[Address(RVA = "0x1F7679C", Offset = "0x1F7579C", VA = "0x1F7679C")]
	public static bool isMouseButtonDown()
	{
		return default(bool);
	}

	[Token(Token = "0x60008C6")]
	[Address(RVA = "0x1F76844", Offset = "0x1F75844", VA = "0x1F76844")]
	public static bool isMouseButtonUp()
	{
		return default(bool);
	}

	[Token(Token = "0x60008C7")]
	[Address(RVA = "0x1F766E0", Offset = "0x1F756E0", VA = "0x1F766E0")]
	public static bool isFirePressed()
	{
		return default(bool);
	}

	[Token(Token = "0x60008C9")]
	[Address(RVA = "0x1F76988", Offset = "0x1F75988", VA = "0x1F76988")]
	public static float GetHorizontal()
	{
		return default(float);
	}

	[Token(Token = "0x60008CA")]
	[Address(RVA = "0x1F76AA0", Offset = "0x1F75AA0", VA = "0x1F76AA0")]
	public static float GetVertical()
	{
		return default(float);
	}

	[Token(Token = "0x60008CB")]
	[Address(RVA = "0x1F76BB8", Offset = "0x1F75BB8", VA = "0x1F76BB8")]
	private static int CalcHeight(float height)
	{
		return default(int);
	}

	[Token(Token = "0x60008CC")]
	[Address(RVA = "0x1F76C9C", Offset = "0x1F75C9C", VA = "0x1F76C9C")]
	public static void GetTouchDelta(ref float x, ref float y, float scaleWidth, float scaleHeight)
	{
	}

	[Token(Token = "0x60008CD")]
	[Address(RVA = "0x1F76FEC", Offset = "0x1F75FEC", VA = "0x1F76FEC")]
	public static float GetFPSHorizontalRotation(float keyWidth, float mouseScaleWidth, bool useLeftJoystick, float keyWidthForJoystick)
	{
		return default(float);
	}

	[Token(Token = "0x60008CE")]
	[Address(RVA = "0x1F77220", Offset = "0x1F76220", VA = "0x1F77220")]
	private static bool hasMouse()
	{
		return default(bool);
	}

	[Token(Token = "0x60008CF")]
	[Address(RVA = "0x1F77228", Offset = "0x1F76228", VA = "0x1F77228")]
	public static float GetFPSVerticalRotation(float keyHeight, float scaleHeight, bool useLeftJoystick, float keyWidthForJoystick)
	{
		return default(float);
	}

	[Token(Token = "0x60008D0")]
	[Address(RVA = "0x1F77458", Offset = "0x1F76458", VA = "0x1F77458")]
	public static float GetTankTorretHorizontal(float keyWidth, float scaleWidth, bool ignoreMouse = false)
	{
		return default(float);
	}

	[Token(Token = "0x60008D1")]
	[Address(RVA = "0x1F775EC", Offset = "0x1F765EC", VA = "0x1F775EC")]
	public static float GetTankTorretVertical(float keyHeight, float scaleHeight, bool ignoreMouse = false)
	{
		return default(float);
	}

	[Token(Token = "0x60008D2")]
	[Address(RVA = "0x1F77780", Offset = "0x1F76780", VA = "0x1F77780")]
	public float getSpeed(float currentSpeed)
	{
		return default(float);
	}

	[Token(Token = "0x60008D3")]
	[Address(RVA = "0x1F77C40", Offset = "0x1F76C40", VA = "0x1F77C40")]
	public float GetRudder()
	{
		return default(float);
	}

	[Token(Token = "0x60008D4")]
	[Address(RVA = "0x1F77EA8", Offset = "0x1F76EA8", VA = "0x1F77EA8")]
	public Vector3 getAxis()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60008D5")]
	[Address(RVA = "0x1F7821C", Offset = "0x1F7721C", VA = "0x1F7821C")]
	public Vector3 getUnmodifiedAxis()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60008D6")]
	[Address(RVA = "0x1F7810C", Offset = "0x1F7710C", VA = "0x1F7810C")]
	public Vector3 getAccelerometer()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60008D7")]
	[Address(RVA = "0x1F74F48", Offset = "0x1F73F48", VA = "0x1F74F48")]
	public void calibrateAccelerometer()
	{
	}

	[Token(Token = "0x60008D8")]
	[Address(RVA = "0x1F78064", Offset = "0x1F77064", VA = "0x1F78064")]
	public static bool usingHardwareJoystick()
	{
		return default(bool);
	}

	[Token(Token = "0x60008D9")]
	[Address(RVA = "0x1F78320", Offset = "0x1F77320", VA = "0x1F78320")]
	public void Vibrate()
	{
	}

	[Token(Token = "0x60008DA")]
	[Address(RVA = "0x1F78324", Offset = "0x1F77324", VA = "0x1F78324")]
	public static void OpenURL(string url)
	{
	}

	[Token(Token = "0x60008DB")]
	[Address(RVA = "0x1F7837C", Offset = "0x1F7737C", VA = "0x1F7837C")]
	public static void ResetInputAxes()
	{
	}
}
[Token(Token = "0x2000082")]
public class MyPlayerPrefs : MonoBehaviour
{
	[Token(Token = "0x400049F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool m_fullyLoaded;

	[Token(Token = "0x40004A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static GameObject instance;

	[Token(Token = "0x40004A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static DateTime lastUpdate;

	[Token(Token = "0x40004A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static Dictionary<string, int> tempInt;

	[Token(Token = "0x40004A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static Dictionary<string, float> tempFloat;

	[Token(Token = "0x40004A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static Dictionary<string, string> tempString;

	[Token(Token = "0x17000138")]
	public static bool fullyLoaded
	{
		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x1F7858C", Offset = "0x1F7758C", VA = "0x1F7858C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x1F78770", Offset = "0x1F77770", VA = "0x1F78770")]
		set
		{
		}
	}

	[Token(Token = "0x60008DF")]
	[Address(RVA = "0x1F787D0", Offset = "0x1F777D0", VA = "0x1F787D0")]
	private void Update()
	{
	}

	[Token(Token = "0x60008E0")]
	[Address(RVA = "0x1F787D4", Offset = "0x1F777D4", VA = "0x1F787D4")]
	private static void createSingleton()
	{
	}

	[Token(Token = "0x60008E1")]
	[Address(RVA = "0x1F786E4", Offset = "0x1F776E4", VA = "0x1F786E4")]
	public static void Init()
	{
	}

	[Token(Token = "0x60008E2")]
	[Address(RVA = "0x1F789C0", Offset = "0x1F779C0", VA = "0x1F789C0")]
	public static void DestroyMe()
	{
	}

	[Token(Token = "0x60008E3")]
	[Address(RVA = "0x1F789C4", Offset = "0x1F779C4", VA = "0x1F789C4")]
	public static bool HasKey(string _key)
	{
		return default(bool);
	}

	[Token(Token = "0x60008E4")]
	[Address(RVA = "0x1F789CC", Offset = "0x1F779CC", VA = "0x1F789CC")]
	public static void DeleteAll()
	{
	}

	[Token(Token = "0x60008E5")]
	[Address(RVA = "0x1F789D4", Offset = "0x1F779D4", VA = "0x1F789D4")]
	public static void DeleteKey(string _key)
	{
	}

	[Token(Token = "0x60008E6")]
	[Address(RVA = "0x1F789DC", Offset = "0x1F779DC", VA = "0x1F789DC")]
	public static void Save()
	{
	}

	[Token(Token = "0x60008E7")]
	[Address(RVA = "0x1F72394", Offset = "0x1F71394", VA = "0x1F72394")]
	public static void SetInt(string _key, int _value)
	{
	}

	[Token(Token = "0x60008E8")]
	[Address(RVA = "0x1F789E4", Offset = "0x1F779E4", VA = "0x1F789E4")]
	public static void SetFloat(string _key, float _value)
	{
	}

	[Token(Token = "0x60008E9")]
	[Address(RVA = "0x1F789EC", Offset = "0x1F779EC", VA = "0x1F789EC")]
	public static void SetString(string _key, string _value)
	{
	}

	[Token(Token = "0x60008EA")]
	[Address(RVA = "0x1F789F4", Offset = "0x1F779F4", VA = "0x1F789F4")]
	public static int GetInt(string _key)
	{
		return default(int);
	}

	[Token(Token = "0x60008EB")]
	[Address(RVA = "0x1F789FC", Offset = "0x1F779FC", VA = "0x1F789FC")]
	public static int GetInt(string _key, int _defaultValue)
	{
		return default(int);
	}

	[Token(Token = "0x60008EC")]
	[Address(RVA = "0x1F78A04", Offset = "0x1F77A04", VA = "0x1F78A04")]
	public static float GetFloat(string _key)
	{
		return default(float);
	}

	[Token(Token = "0x60008ED")]
	[Address(RVA = "0x1F78A0C", Offset = "0x1F77A0C", VA = "0x1F78A0C")]
	public static float GetFloat(string _key, float _defaultValue)
	{
		return default(float);
	}

	[Token(Token = "0x60008EE")]
	[Address(RVA = "0x1F78A14", Offset = "0x1F77A14", VA = "0x1F78A14")]
	public static string GetString(string _key)
	{
		return null;
	}

	[Token(Token = "0x60008EF")]
	[Address(RVA = "0x1F78A1C", Offset = "0x1F77A1C", VA = "0x1F78A1C")]
	public static string GetString(string _key, string _defaultValue)
	{
		return null;
	}

	[Token(Token = "0x60008F0")]
	[Address(RVA = "0x1F78A24", Offset = "0x1F77A24", VA = "0x1F78A24")]
	public static void SetIntTemp(string _key, int _value)
	{
	}

	[Token(Token = "0x60008F1")]
	[Address(RVA = "0x1F78B30", Offset = "0x1F77B30", VA = "0x1F78B30")]
	public static void SetFloatTemp(string _key, float _value)
	{
	}

	[Token(Token = "0x60008F2")]
	[Address(RVA = "0x1F78C3C", Offset = "0x1F77C3C", VA = "0x1F78C3C")]
	public static void SetStringTemp(string _key, string _value)
	{
	}

	[Token(Token = "0x60008F3")]
	[Address(RVA = "0x1F78D48", Offset = "0x1F77D48", VA = "0x1F78D48")]
	public static bool HasKeyTemp(string _key)
	{
		return default(bool);
	}

	[Token(Token = "0x60008F4")]
	[Address(RVA = "0x1F78E60", Offset = "0x1F77E60", VA = "0x1F78E60")]
	public static void DeleteKeyTemp(string _key)
	{
	}

	[Token(Token = "0x60008F5")]
	[Address(RVA = "0x1F79038", Offset = "0x1F78038", VA = "0x1F79038")]
	public static int GetIntTemp(string _key)
	{
		return default(int);
	}

	[Token(Token = "0x60008F6")]
	[Address(RVA = "0x1F79090", Offset = "0x1F78090", VA = "0x1F79090")]
	public static int GetIntTemp(string _key, int _default)
	{
		return default(int);
	}

	[Token(Token = "0x60008F7")]
	[Address(RVA = "0x1F79174", Offset = "0x1F78174", VA = "0x1F79174")]
	public static float GetFloatTemp(string _key)
	{
		return default(float);
	}

	[Token(Token = "0x60008F8")]
	[Address(RVA = "0x1F791CC", Offset = "0x1F781CC", VA = "0x1F791CC")]
	public static float GetFloatTemp(string _key, float _default)
	{
		return default(float);
	}

	[Token(Token = "0x60008F9")]
	[Address(RVA = "0x1F792B0", Offset = "0x1F782B0", VA = "0x1F792B0")]
	public static string GetStringTemp(string _key)
	{
		return null;
	}

	[Token(Token = "0x60008FA")]
	[Address(RVA = "0x1F79330", Offset = "0x1F78330", VA = "0x1F79330")]
	public static string GetStringTemp(string _key, string _default)
	{
		return null;
	}

	[Token(Token = "0x60008FB")]
	[Address(RVA = "0x1F79414", Offset = "0x1F78414", VA = "0x1F79414")]
	private static byte[] serialize(object _data)
	{
		return null;
	}

	[Token(Token = "0x60008FC")]
	[Address(RVA = "0x1F79698", Offset = "0x1F78698", VA = "0x1F79698")]
	private static int deserializeInt(byte[] _byteArray)
	{
		return default(int);
	}

	[Token(Token = "0x60008FD")]
	[Address(RVA = "0x1F796A4", Offset = "0x1F786A4", VA = "0x1F796A4")]
	private static float deserializeFloat(byte[] _byteArray)
	{
		return default(float);
	}

	[Token(Token = "0x60008FE")]
	[Address(RVA = "0x1F796B0", Offset = "0x1F786B0", VA = "0x1F796B0")]
	private static string deserializeString(byte[] _byteArray)
	{
		return null;
	}

	[Token(Token = "0x60008FF")]
	[Address(RVA = "0x1F7973C", Offset = "0x1F7873C", VA = "0x1F7973C")]
	private static bool sameUser()
	{
		return default(bool);
	}

	[Token(Token = "0x6000900")]
	[Address(RVA = "0x1F79744", Offset = "0x1F78744", VA = "0x1F79744")]
	private static void updateCache(bool _fromSingleton)
	{
	}

	[Token(Token = "0x6000901")]
	[Address(RVA = "0x1F79748", Offset = "0x1F78748", VA = "0x1F79748")]
	public MyPlayerPrefs()
	{
	}
}
[Token(Token = "0x2000083")]
public class MyTouchScreenKeyboard
{
	[Token(Token = "0x40004A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private TouchScreenKeyboard iKeyboard;

	[Token(Token = "0x40004A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool isActive;

	[Token(Token = "0x40004A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool pHideInput;

	[Token(Token = "0x40004A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static MyTouchScreenKeyboard keyboard;

	[Token(Token = "0x40004A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static AndroidJavaObject activityContext;

	[Token(Token = "0x40004AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static AndroidJavaObject androidKeyboard;

	[Token(Token = "0x17000139")]
	public string text
	{
		[Token(Token = "0x6000904")]
		[Address(RVA = "0x1F798BC", Offset = "0x1F788BC", VA = "0x1F798BC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000905")]
		[Address(RVA = "0x1F79A0C", Offset = "0x1F78A0C", VA = "0x1F79A0C")]
		set
		{
		}
	}

	[Token(Token = "0x1700013A")]
	public bool isCustom
	{
		[Token(Token = "0x6000906")]
		[Address(RVA = "0x1F798EC", Offset = "0x1F788EC", VA = "0x1F798EC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700013B")]
	public bool active
	{
		[Token(Token = "0x6000907")]
		[Address(RVA = "0x1F79A4C", Offset = "0x1F78A4C", VA = "0x1F79A4C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000908")]
		[Address(RVA = "0x1F79A7C", Offset = "0x1F78A7C", VA = "0x1F79A7C")]
		set
		{
		}
	}

	[Token(Token = "0x1700013C")]
	public bool done
	{
		[Token(Token = "0x6000909")]
		[Address(RVA = "0x1F79CF0", Offset = "0x1F78CF0", VA = "0x1F79CF0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700013D")]
	public bool wasCanceled
	{
		[Token(Token = "0x600090A")]
		[Address(RVA = "0x1F79D20", Offset = "0x1F78D20", VA = "0x1F79D20")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700013E")]
	public static bool hideInput
	{
		[Token(Token = "0x600090B")]
		[Address(RVA = "0x1F79D50", Offset = "0x1F78D50", VA = "0x1F79D50")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600090C")]
		[Address(RVA = "0x1F79D98", Offset = "0x1F78D98", VA = "0x1F79D98")]
		set
		{
		}
	}

	[Token(Token = "0x6000903")]
	[Address(RVA = "0x1F798B4", Offset = "0x1F788B4", VA = "0x1F798B4")]
	public MyTouchScreenKeyboard()
	{
	}

	[Token(Token = "0x600090D")]
	[Address(RVA = "0x1F79DF4", Offset = "0x1F78DF4", VA = "0x1F79DF4")]
	public static MyTouchScreenKeyboard Open(string controlText)
	{
		return null;
	}

	[Token(Token = "0x600090E")]
	[Address(RVA = "0x1F7A0F0", Offset = "0x1F790F0", VA = "0x1F7A0F0")]
	public static MyTouchScreenKeyboard Open(string controlText, TouchScreenKeyboardType type, bool autoCorrect, bool multiline, bool secure, bool alert, string placeholderText)
	{
		return null;
	}

	[Token(Token = "0x600090F")]
	[Address(RVA = "0x1F79EDC", Offset = "0x1F78EDC", VA = "0x1F79EDC")]
	private void OpenKeyboard(string controlText)
	{
	}

	[Token(Token = "0x6000910")]
	[Address(RVA = "0x1F79AD8", Offset = "0x1F78AD8", VA = "0x1F79AD8")]
	private void CloseKeyboard()
	{
	}

	[Token(Token = "0x6000911")]
	[Address(RVA = "0x1F7A220", Offset = "0x1F79220", VA = "0x1F7A220")]
	private void InitContext()
	{
	}
}
[Token(Token = "0x2000085")]
public class iTween : MonoBehaviour
{
	[Token(Token = "0x2000086")]
	private delegate float EasingFunction(float start, float end, float Value);

	[Token(Token = "0x2000087")]
	private delegate void ApplyTween();

	[Token(Token = "0x2000088")]
	public enum EaseType
	{
		[Token(Token = "0x40004D4")]
		easeInQuad,
		[Token(Token = "0x40004D5")]
		easeOutQuad,
		[Token(Token = "0x40004D6")]
		easeInOutQuad,
		[Token(Token = "0x40004D7")]
		easeInCubic,
		[Token(Token = "0x40004D8")]
		easeOutCubic,
		[Token(Token = "0x40004D9")]
		easeInOutCubic,
		[Token(Token = "0x40004DA")]
		easeInQuart,
		[Token(Token = "0x40004DB")]
		easeOutQuart,
		[Token(Token = "0x40004DC")]
		easeInOutQuart,
		[Token(Token = "0x40004DD")]
		easeInQuint,
		[Token(Token = "0x40004DE")]
		easeOutQuint,
		[Token(Token = "0x40004DF")]
		easeInOutQuint,
		[Token(Token = "0x40004E0")]
		easeInSine,
		[Token(Token = "0x40004E1")]
		easeOutSine,
		[Token(Token = "0x40004E2")]
		easeInOutSine,
		[Token(Token = "0x40004E3")]
		easeInExpo,
		[Token(Token = "0x40004E4")]
		easeOutExpo,
		[Token(Token = "0x40004E5")]
		easeInOutExpo,
		[Token(Token = "0x40004E6")]
		easeInCirc,
		[Token(Token = "0x40004E7")]
		easeOutCirc,
		[Token(Token = "0x40004E8")]
		easeInOutCirc,
		[Token(Token = "0x40004E9")]
		linear,
		[Token(Token = "0x40004EA")]
		spring,
		[Token(Token = "0x40004EB")]
		easeInBounce,
		[Token(Token = "0x40004EC")]
		easeOutBounce,
		[Token(Token = "0x40004ED")]
		easeInOutBounce,
		[Token(Token = "0x40004EE")]
		easeInBack,
		[Token(Token = "0x40004EF")]
		easeOutBack,
		[Token(Token = "0x40004F0")]
		easeInOutBack,
		[Token(Token = "0x40004F1")]
		easeInElastic,
		[Token(Token = "0x40004F2")]
		easeOutElastic,
		[Token(Token = "0x40004F3")]
		easeInOutElastic,
		[Token(Token = "0x40004F4")]
		punch
	}

	[Token(Token = "0x2000089")]
	public enum LoopType
	{
		[Token(Token = "0x40004F6")]
		none,
		[Token(Token = "0x40004F7")]
		loop,
		[Token(Token = "0x40004F8")]
		pingPong
	}

	[Token(Token = "0x200008A")]
	public enum NamedValueColor
	{
		[Token(Token = "0x40004FA")]
		_Color,
		[Token(Token = "0x40004FB")]
		_SpecColor,
		[Token(Token = "0x40004FC")]
		_Emission,
		[Token(Token = "0x40004FD")]
		_ReflectColor
	}

	[Token(Token = "0x200008B")]
	public static class Defaults
	{
		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float time;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float delay;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static NamedValueColor namedColorValue;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static LoopType loopType;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static EaseType easeType;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static float lookSpeed;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static bool isLocal;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static Space space;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static bool orientToPath;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static Color color;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static float updateTimePercentage;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static float updateTime;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static float lookAhead;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static bool useRealTime;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static Vector3 up;
	}

	[Token(Token = "0x200008C")]
	private class CRSpline
	{
		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3[] pts;

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x1F7ACC0", Offset = "0x1F79CC0", VA = "0x1F7ACC0")]
		public CRSpline(params Vector3[] pts)
		{
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x1F7AD38", Offset = "0x1F79D38", VA = "0x1F7AD38")]
		public Vector3 Interp(float t)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class <Start>d__230 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x1700013F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A18")]
			[Address(RVA = "0x1F7B008", Offset = "0x1F7A008", VA = "0x1F7B008", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000140")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0x1F7B048", Offset = "0x1F7A048", VA = "0x1F7B048", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x1F7AF38", Offset = "0x1F79F38", VA = "0x1F7AF38")]
		[DebuggerHidden]
		public <Start>d__230(int <>1__state)
		{
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x1F7AF60", Offset = "0x1F79F60", VA = "0x1F7AF60", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x1F7AF64", Offset = "0x1F79F64", VA = "0x1F7AF64", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x1F7B010", Offset = "0x1F7A010", VA = "0x1F7B010", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class <TweenDelay>d__145 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x17000141")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0x1F7B148", Offset = "0x1F7A148", VA = "0x1F7B148", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000142")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x1F7B188", Offset = "0x1F7A188", VA = "0x1F7B188", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x1F7B050", Offset = "0x1F7A050", VA = "0x1F7B050")]
		[DebuggerHidden]
		public <TweenDelay>d__145(int <>1__state)
		{
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x1F7B078", Offset = "0x1F7A078", VA = "0x1F7B078", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x1F7B07C", Offset = "0x1F7A07C", VA = "0x1F7B07C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x1F7B150", Offset = "0x1F7A150", VA = "0x1F7B150", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class <TweenRestart>d__147 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x17000143")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x1F7B290", Offset = "0x1F7A290", VA = "0x1F7B290", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000144")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A26")]
			[Address(RVA = "0x1F7B2D0", Offset = "0x1F7A2D0", VA = "0x1F7B2D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x1F7B190", Offset = "0x1F7A190", VA = "0x1F7B190")]
		[DebuggerHidden]
		public <TweenRestart>d__147(int <>1__state)
		{
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x1F7B1B8", Offset = "0x1F7A1B8", VA = "0x1F7B1B8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x1F7B1BC", Offset = "0x1F7A1BC", VA = "0x1F7B1BC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x1F7B298", Offset = "0x1F7A298", VA = "0x1F7B298", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<Hashtable> tweens;

	[Token(Token = "0x40004AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string id;

	[Token(Token = "0x40004B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string type;

	[Token(Token = "0x40004B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string method;

	[Token(Token = "0x40004B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public EaseType easeType;

	[Token(Token = "0x40004B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float time;

	[Token(Token = "0x40004B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float delay;

	[Token(Token = "0x40004B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public LoopType loopType;

	[Token(Token = "0x40004B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool isRunning;

	[Token(Token = "0x40004B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool isPaused;

	[Token(Token = "0x40004B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string _name;

	[Token(Token = "0x40004B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float runningTime;

	[Token(Token = "0x40004BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float percentage;

	[Token(Token = "0x40004BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float delayStarted;

	[Token(Token = "0x40004BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool kinematic;

	[Token(Token = "0x40004BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	private bool isLocal;

	[Token(Token = "0x40004BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
	private bool loop;

	[Token(Token = "0x40004BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
	private bool reverse;

	[Token(Token = "0x40004C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool wasPaused;

	[Token(Token = "0x40004C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	private bool physics;

	[Token(Token = "0x40004C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Hashtable tweenArguments;

	[Token(Token = "0x40004C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Space space;

	[Token(Token = "0x40004C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private EasingFunction ease;

	[Token(Token = "0x40004C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private ApplyTween apply;

	[Token(Token = "0x40004C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private AudioSource audioSource;

	[Token(Token = "0x40004C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Vector3[] vector3s;

	[Token(Token = "0x40004C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Vector2[] vector2s;

	[Token(Token = "0x40004C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Color[,] colors;

	[Token(Token = "0x40004CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float[] floats;

	[Token(Token = "0x40004CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Rect[] rects;

	[Token(Token = "0x40004CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private CRSpline path;

	[Token(Token = "0x40004CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Vector3 preUpdate;

	[Token(Token = "0x40004CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private Vector3 postUpdate;

	[Token(Token = "0x40004CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private NamedValueColor namedcolorvalue;

	[Token(Token = "0x40004D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private float lastRealTime;

	[Token(Token = "0x40004D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private bool useRealTime;

	[Token(Token = "0x40004D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private Transform thisTransform;

	[Token(Token = "0x6000916")]
	[Address(RVA = "0x1F4AEF8", Offset = "0x1F49EF8", VA = "0x1F4AEF8")]
	public static void Init(GameObject target)
	{
	}

	[Token(Token = "0x6000917")]
	[Address(RVA = "0x1F4B194", Offset = "0x1F4A194", VA = "0x1F4B194")]
	public static void ValueTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000918")]
	[Address(RVA = "0x1F4C35C", Offset = "0x1F4B35C", VA = "0x1F4C35C")]
	public static void FadeFrom(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6000919")]
	[Address(RVA = "0x1F4C64C", Offset = "0x1F4B64C", VA = "0x1F4C64C")]
	public static void FadeFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600091A")]
	[Address(RVA = "0x1F4D1EC", Offset = "0x1F4C1EC", VA = "0x1F4D1EC")]
	public static void FadeTo(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x600091B")]
	[Address(RVA = "0x1F4D3B4", Offset = "0x1F4C3B4", VA = "0x1F4D3B4")]
	public static void FadeTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600091C")]
	[Address(RVA = "0x1F4DA08", Offset = "0x1F4CA08", VA = "0x1F4DA08")]
	public static void ColorFrom(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x600091D")]
	[Address(RVA = "0x1F4C6B0", Offset = "0x1F4B6B0", VA = "0x1F4C6B0")]
	public static void ColorFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600091E")]
	[Address(RVA = "0x1F4DC04", Offset = "0x1F4CC04", VA = "0x1F4DC04")]
	public static void ColorTo(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x600091F")]
	[Address(RVA = "0x1F4D418", Offset = "0x1F4C418", VA = "0x1F4D418")]
	public static void ColorTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000920")]
	[Address(RVA = "0x1F4DE00", Offset = "0x1F4CE00", VA = "0x1F4DE00")]
	public static void AudioFrom(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x6000921")]
	[Address(RVA = "0x1F4E050", Offset = "0x1F4D050", VA = "0x1F4E050")]
	public static void AudioFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000922")]
	[Address(RVA = "0x1F4E4F4", Offset = "0x1F4D4F4", VA = "0x1F4E4F4")]
	public static void AudioTo(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x6000923")]
	[Address(RVA = "0x1F4E744", Offset = "0x1F4D744", VA = "0x1F4E744")]
	public static void AudioTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000924")]
	[Address(RVA = "0x1F4E8D8", Offset = "0x1F4D8D8", VA = "0x1F4E8D8")]
	public static void Stab(GameObject target, AudioClip audioclip, float delay)
	{
	}

	[Token(Token = "0x6000925")]
	[Address(RVA = "0x1F4EA8C", Offset = "0x1F4DA8C", VA = "0x1F4EA8C")]
	public static void Stab(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000926")]
	[Address(RVA = "0x1F4EB44", Offset = "0x1F4DB44", VA = "0x1F4EB44")]
	public static void LookFrom(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6000927")]
	[Address(RVA = "0x1F4ED34", Offset = "0x1F4DD34", VA = "0x1F4ED34")]
	public static void LookFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000928")]
	[Address(RVA = "0x1F4F424", Offset = "0x1F4E424", VA = "0x1F4F424")]
	public static void LookTo(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6000929")]
	[Address(RVA = "0x1F4F614", Offset = "0x1F4E614", VA = "0x1F4F614")]
	public static void LookTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600092A")]
	[Address(RVA = "0x1F4F950", Offset = "0x1F4E950", VA = "0x1F4F950")]
	public static void MoveTo(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x600092B")]
	[Address(RVA = "0x1F4FB40", Offset = "0x1F4EB40", VA = "0x1F4FB40")]
	public static void MoveTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600092C")]
	[Address(RVA = "0x1F4FED8", Offset = "0x1F4EED8", VA = "0x1F4FED8")]
	public static void MoveFrom(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x600092D")]
	[Address(RVA = "0x1F500C8", Offset = "0x1F4F0C8", VA = "0x1F500C8")]
	public static void MoveFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600092E")]
	[Address(RVA = "0x1F50A58", Offset = "0x1F4FA58", VA = "0x1F50A58")]
	public static void MoveAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600092F")]
	[Address(RVA = "0x1F50C48", Offset = "0x1F4FC48", VA = "0x1F50C48")]
	public static void MoveAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000930")]
	[Address(RVA = "0x1F4AFA4", Offset = "0x1F49FA4", VA = "0x1F4AFA4")]
	public static void MoveBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000931")]
	[Address(RVA = "0x1F50D44", Offset = "0x1F4FD44", VA = "0x1F50D44")]
	public static void MoveBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000932")]
	[Address(RVA = "0x1F50E40", Offset = "0x1F4FE40", VA = "0x1F50E40")]
	public static void ScaleTo(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000933")]
	[Address(RVA = "0x1F51030", Offset = "0x1F50030", VA = "0x1F51030")]
	public static void ScaleTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000934")]
	[Address(RVA = "0x1F513B4", Offset = "0x1F503B4", VA = "0x1F513B4")]
	public static void ScaleFrom(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000935")]
	[Address(RVA = "0x1F515A4", Offset = "0x1F505A4", VA = "0x1F515A4")]
	public static void ScaleFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000936")]
	[Address(RVA = "0x1F51ABC", Offset = "0x1F50ABC", VA = "0x1F51ABC")]
	public static void ScaleAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000937")]
	[Address(RVA = "0x1F51CAC", Offset = "0x1F50CAC", VA = "0x1F51CAC")]
	public static void ScaleAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000938")]
	[Address(RVA = "0x1F51DA8", Offset = "0x1F50DA8", VA = "0x1F51DA8")]
	public static void ScaleBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000939")]
	[Address(RVA = "0x1F51F98", Offset = "0x1F50F98", VA = "0x1F51F98")]
	public static void ScaleBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600093A")]
	[Address(RVA = "0x1F52094", Offset = "0x1F51094", VA = "0x1F52094")]
	public static void RotateTo(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x600093B")]
	[Address(RVA = "0x1F52284", Offset = "0x1F51284", VA = "0x1F52284")]
	public static void RotateTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600093C")]
	[Address(RVA = "0x1F5261C", Offset = "0x1F5161C", VA = "0x1F5261C")]
	public static void RotateFrom(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x600093D")]
	[Address(RVA = "0x1F5280C", Offset = "0x1F5180C", VA = "0x1F5280C")]
	public static void RotateFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600093E")]
	[Address(RVA = "0x1F52E08", Offset = "0x1F51E08", VA = "0x1F52E08")]
	public static void RotateAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600093F")]
	[Address(RVA = "0x1F52FF8", Offset = "0x1F51FF8", VA = "0x1F52FF8")]
	public static void RotateAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000940")]
	[Address(RVA = "0x1F530F4", Offset = "0x1F520F4", VA = "0x1F530F4")]
	public static void RotateBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000941")]
	[Address(RVA = "0x1F532E4", Offset = "0x1F522E4", VA = "0x1F532E4")]
	public static void RotateBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000942")]
	[Address(RVA = "0x1F533E0", Offset = "0x1F523E0", VA = "0x1F533E0")]
	public static void ShakePosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000943")]
	[Address(RVA = "0x1F535D0", Offset = "0x1F525D0", VA = "0x1F535D0")]
	public static void ShakePosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000944")]
	[Address(RVA = "0x1F536CC", Offset = "0x1F526CC", VA = "0x1F536CC")]
	public static void ShakeScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000945")]
	[Address(RVA = "0x1F538BC", Offset = "0x1F528BC", VA = "0x1F538BC")]
	public static void ShakeScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000946")]
	[Address(RVA = "0x1F539B8", Offset = "0x1F529B8", VA = "0x1F539B8")]
	public static void ShakeRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000947")]
	[Address(RVA = "0x1F53BA8", Offset = "0x1F52BA8", VA = "0x1F53BA8")]
	public static void ShakeRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000948")]
	[Address(RVA = "0x1F53CA4", Offset = "0x1F52CA4", VA = "0x1F53CA4")]
	public static void PunchPosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000949")]
	[Address(RVA = "0x1F53E94", Offset = "0x1F52E94", VA = "0x1F53E94")]
	public static void PunchPosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600094A")]
	[Address(RVA = "0x1F53FF4", Offset = "0x1F52FF4", VA = "0x1F53FF4")]
	public static void PunchRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600094B")]
	[Address(RVA = "0x1F541E4", Offset = "0x1F531E4", VA = "0x1F541E4")]
	public static void PunchRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600094C")]
	[Address(RVA = "0x1F54344", Offset = "0x1F53344", VA = "0x1F54344")]
	public static void PunchScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600094D")]
	[Address(RVA = "0x1F54534", Offset = "0x1F53534", VA = "0x1F54534")]
	public static void PunchScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600094E")]
	[Address(RVA = "0x1F54694", Offset = "0x1F53694", VA = "0x1F54694")]
	private void GenerateTargets()
	{
	}

	[Token(Token = "0x600094F")]
	[Address(RVA = "0x1F5595C", Offset = "0x1F5495C", VA = "0x1F5595C")]
	private void GenerateRectTargets()
	{
	}

	[Token(Token = "0x6000950")]
	[Address(RVA = "0x1F557E4", Offset = "0x1F547E4", VA = "0x1F557E4")]
	private void GenerateColorTargets()
	{
	}

	[Token(Token = "0x6000951")]
	[Address(RVA = "0x1F5553C", Offset = "0x1F5453C", VA = "0x1F5553C")]
	private void GenerateVector3Targets()
	{
	}

	[Token(Token = "0x6000952")]
	[Address(RVA = "0x1F552B4", Offset = "0x1F542B4", VA = "0x1F552B4")]
	private void GenerateVector2Targets()
	{
	}

	[Token(Token = "0x6000953")]
	[Address(RVA = "0x1F550A4", Offset = "0x1F540A4", VA = "0x1F550A4")]
	private void GenerateFloatTargets()
	{
	}

	[Token(Token = "0x6000954")]
	[Address(RVA = "0x1F55AA4", Offset = "0x1F54AA4", VA = "0x1F55AA4")]
	private void GenerateColorToTargets()
	{
	}

	[Token(Token = "0x6000955")]
	[Address(RVA = "0x1F56438", Offset = "0x1F55438", VA = "0x1F56438")]
	private void GenerateAudioToTargets()
	{
	}

	[Token(Token = "0x6000956")]
	[Address(RVA = "0x1F5B6A0", Offset = "0x1F5A6A0", VA = "0x1F5B6A0")]
	private void GenerateStabTargets()
	{
	}

	[Token(Token = "0x6000957")]
	[Address(RVA = "0x1F5AD88", Offset = "0x1F59D88", VA = "0x1F5AD88")]
	private void GenerateLookToTargets()
	{
	}

	[Token(Token = "0x6000958")]
	[Address(RVA = "0x1F56760", Offset = "0x1F55760", VA = "0x1F56760")]
	private void GenerateMoveToPathTargets()
	{
	}

	[Token(Token = "0x6000959")]
	[Address(RVA = "0x1F56E28", Offset = "0x1F55E28", VA = "0x1F56E28")]
	private void GenerateMoveToTargets()
	{
	}

	[Token(Token = "0x600095A")]
	[Address(RVA = "0x1F57510", Offset = "0x1F56510", VA = "0x1F57510")]
	private void GenerateMoveByTargets()
	{
	}

	[Token(Token = "0x600095B")]
	[Address(RVA = "0x1F57B58", Offset = "0x1F56B58", VA = "0x1F57B58")]
	private void GenerateScaleToTargets()
	{
	}

	[Token(Token = "0x600095C")]
	[Address(RVA = "0x1F58120", Offset = "0x1F57120", VA = "0x1F58120")]
	private void GenerateScaleByTargets()
	{
	}

	[Token(Token = "0x600095D")]
	[Address(RVA = "0x1F58598", Offset = "0x1F57598", VA = "0x1F58598")]
	private void GenerateScaleAddTargets()
	{
	}

	[Token(Token = "0x600095E")]
	[Address(RVA = "0x1F58A08", Offset = "0x1F57A08", VA = "0x1F58A08")]
	private void GenerateRotateToTargets()
	{
	}

	[Token(Token = "0x600095F")]
	[Address(RVA = "0x1F5912C", Offset = "0x1F5812C", VA = "0x1F5912C")]
	private void GenerateRotateAddTargets()
	{
	}

	[Token(Token = "0x6000960")]
	[Address(RVA = "0x1F595A4", Offset = "0x1F585A4", VA = "0x1F595A4")]
	private void GenerateRotateByTargets()
	{
	}

	[Token(Token = "0x6000961")]
	[Address(RVA = "0x1F59A54", Offset = "0x1F58A54", VA = "0x1F59A54")]
	private void GenerateShakePositionTargets()
	{
	}

	[Token(Token = "0x6000962")]
	[Address(RVA = "0x1F59D78", Offset = "0x1F58D78", VA = "0x1F59D78")]
	private void GenerateShakeScaleTargets()
	{
	}

	[Token(Token = "0x6000963")]
	[Address(RVA = "0x1F5A070", Offset = "0x1F59070", VA = "0x1F5A070")]
	private void GenerateShakeRotationTargets()
	{
	}

	[Token(Token = "0x6000964")]
	[Address(RVA = "0x1F5A368", Offset = "0x1F59368", VA = "0x1F5A368")]
	private void GeneratePunchPositionTargets()
	{
	}

	[Token(Token = "0x6000965")]
	[Address(RVA = "0x1F5A6E8", Offset = "0x1F596E8", VA = "0x1F5A6E8")]
	private void GeneratePunchRotationTargets()
	{
	}

	[Token(Token = "0x6000966")]
	[Address(RVA = "0x1F5AA3C", Offset = "0x1F59A3C", VA = "0x1F5AA3C")]
	private void GeneratePunchScaleTargets()
	{
	}

	[Token(Token = "0x6000967")]
	[Address(RVA = "0x1F5BDA8", Offset = "0x1F5ADA8", VA = "0x1F5BDA8")]
	private void ApplyRectTargets()
	{
	}

	[Token(Token = "0x6000968")]
	[Address(RVA = "0x1F5BFEC", Offset = "0x1F5AFEC", VA = "0x1F5BFEC")]
	private void ApplyColorTargets()
	{
	}

	[Token(Token = "0x6000969")]
	[Address(RVA = "0x1F5C238", Offset = "0x1F5B238", VA = "0x1F5C238")]
	private void ApplyVector3Targets()
	{
	}

	[Token(Token = "0x600096A")]
	[Address(RVA = "0x1F5C440", Offset = "0x1F5B440", VA = "0x1F5C440")]
	private void ApplyVector2Targets()
	{
	}

	[Token(Token = "0x600096B")]
	[Address(RVA = "0x1F5C5E4", Offset = "0x1F5B5E4", VA = "0x1F5C5E4")]
	private void ApplyFloatTargets()
	{
	}

	[Token(Token = "0x600096C")]
	[Address(RVA = "0x1F5C738", Offset = "0x1F5B738", VA = "0x1F5C738")]
	private void ApplyColorToTargets()
	{
	}

	[Token(Token = "0x600096D")]
	[Address(RVA = "0x1F5CC64", Offset = "0x1F5BC64", VA = "0x1F5CC64")]
	private void ApplyAudioToTargets()
	{
	}

	[Token(Token = "0x600096E")]
	[Address(RVA = "0x1F5CDD4", Offset = "0x1F5BDD4", VA = "0x1F5CDD4")]
	private void ApplyStabTargets()
	{
	}

	[Token(Token = "0x600096F")]
	[Address(RVA = "0x1F5CDD8", Offset = "0x1F5BDD8", VA = "0x1F5CDD8")]
	private void ApplyMoveToPathTargets()
	{
	}

	[Token(Token = "0x6000970")]
	[Address(RVA = "0x1F5D0EC", Offset = "0x1F5C0EC", VA = "0x1F5D0EC")]
	private void ApplyMoveToTargets()
	{
	}

	[Token(Token = "0x6000971")]
	[Address(RVA = "0x1F5D300", Offset = "0x1F5C300", VA = "0x1F5D300")]
	private void ApplyMoveByTargets()
	{
	}

	[Token(Token = "0x6000972")]
	[Address(RVA = "0x1F5D5E0", Offset = "0x1F5C5E0", VA = "0x1F5D5E0")]
	private void ApplyScaleToTargets()
	{
	}

	[Token(Token = "0x6000973")]
	[Address(RVA = "0x1F5D754", Offset = "0x1F5C754", VA = "0x1F5D754")]
	private void ApplyLookToTargets()
	{
	}

	[Token(Token = "0x6000974")]
	[Address(RVA = "0x1F5D8B4", Offset = "0x1F5C8B4", VA = "0x1F5D8B4")]
	private void ApplyRotateToTargets()
	{
	}

	[Token(Token = "0x6000975")]
	[Address(RVA = "0x1F5DB28", Offset = "0x1F5CB28", VA = "0x1F5DB28")]
	private void ApplyRotateAddTargets()
	{
	}

	[Token(Token = "0x6000976")]
	[Address(RVA = "0x1F5DD50", Offset = "0x1F5CD50", VA = "0x1F5DD50")]
	private void ApplyShakePositionTargets()
	{
	}

	[Token(Token = "0x6000977")]
	[Address(RVA = "0x1F5E0B0", Offset = "0x1F5D0B0", VA = "0x1F5E0B0")]
	private void ApplyShakeScaleTargets()
	{
	}

	[Token(Token = "0x6000978")]
	[Address(RVA = "0x1F5E23C", Offset = "0x1F5D23C", VA = "0x1F5E23C")]
	private void ApplyShakeRotationTargets()
	{
	}

	[Token(Token = "0x6000979")]
	[Address(RVA = "0x1F5E468", Offset = "0x1F5D468", VA = "0x1F5E468")]
	private void ApplyPunchPositionTargets()
	{
	}

	[Token(Token = "0x600097A")]
	[Address(RVA = "0x1F5E968", Offset = "0x1F5D968", VA = "0x1F5E968")]
	private void ApplyPunchRotationTargets()
	{
	}

	[Token(Token = "0x600097B")]
	[Address(RVA = "0x1F5ED40", Offset = "0x1F5DD40", VA = "0x1F5ED40")]
	private void ApplyPunchScaleTargets()
	{
	}

	[Token(Token = "0x600097C")]
	[Address(RVA = "0x1F5F028", Offset = "0x1F5E028", VA = "0x1F5F028")]
	[IteratorStateMachine(typeof(<TweenDelay>d__145))]
	private IEnumerator TweenDelay()
	{
		return null;
	}

	[Token(Token = "0x600097D")]
	[Address(RVA = "0x1F5F090", Offset = "0x1F5E090", VA = "0x1F5F090")]
	private void TweenStart()
	{
	}

	[Token(Token = "0x600097E")]
	[Address(RVA = "0x1F5FB2C", Offset = "0x1F5EB2C", VA = "0x1F5FB2C")]
	[IteratorStateMachine(typeof(<TweenRestart>d__147))]
	private IEnumerator TweenRestart()
	{
		return null;
	}

	[Token(Token = "0x600097F")]
	[Address(RVA = "0x1F5FB94", Offset = "0x1F5EB94", VA = "0x1F5FB94")]
	private void TweenUpdate()
	{
	}

	[Token(Token = "0x6000980")]
	[Address(RVA = "0x1F5FC6C", Offset = "0x1F5EC6C", VA = "0x1F5FC6C")]
	private void TweenComplete()
	{
	}

	[Token(Token = "0x6000981")]
	[Address(RVA = "0x1F5FD50", Offset = "0x1F5ED50", VA = "0x1F5FD50")]
	private void TweenLoop()
	{
	}

	[Token(Token = "0x6000982")]
	[Address(RVA = "0x1F5FDF4", Offset = "0x1F5EDF4", VA = "0x1F5FDF4")]
	public static Rect RectUpdate(Rect currentValue, Rect targetValue, float speed)
	{
		return default(Rect);
	}

	[Token(Token = "0x6000983")]
	[Address(RVA = "0x1F5FF30", Offset = "0x1F5EF30", VA = "0x1F5FF30")]
	public static Vector3 Vector3Update(Vector3 currentValue, Vector3 targetValue, float speed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000984")]
	[Address(RVA = "0x1F5FF98", Offset = "0x1F5EF98", VA = "0x1F5FF98")]
	public static Vector2 Vector2Update(Vector2 currentValue, Vector2 targetValue, float speed)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000985")]
	[Address(RVA = "0x1F5FEF4", Offset = "0x1F5EEF4", VA = "0x1F5FEF4")]
	public static float FloatUpdate(float currentValue, float targetValue, float speed)
	{
		return default(float);
	}

	[Token(Token = "0x6000986")]
	[Address(RVA = "0x1F5FFE4", Offset = "0x1F5EFE4", VA = "0x1F5FFE4")]
	public static void FadeUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000987")]
	[Address(RVA = "0x1F60BA8", Offset = "0x1F5FBA8", VA = "0x1F60BA8")]
	public static void FadeUpdate(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6000988")]
	[Address(RVA = "0x1F600AC", Offset = "0x1F5F0AC", VA = "0x1F600AC")]
	public static void ColorUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000989")]
	[Address(RVA = "0x1F60D70", Offset = "0x1F5FD70", VA = "0x1F60D70")]
	public static void ColorUpdate(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x600098A")]
	[Address(RVA = "0x1F60F6C", Offset = "0x1F5FF6C", VA = "0x1F60F6C")]
	public static void AudioUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600098B")]
	[Address(RVA = "0x1F614DC", Offset = "0x1F604DC", VA = "0x1F614DC")]
	public static void AudioUpdate(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x600098C")]
	[Address(RVA = "0x1F6172C", Offset = "0x1F6072C", VA = "0x1F6172C")]
	public static void RotateUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600098D")]
	[Address(RVA = "0x1F61E98", Offset = "0x1F60E98", VA = "0x1F61E98")]
	public static void RotateUpdate(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x600098E")]
	[Address(RVA = "0x1F62088", Offset = "0x1F61088", VA = "0x1F62088")]
	public static void ScaleUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600098F")]
	[Address(RVA = "0x1F626F4", Offset = "0x1F616F4", VA = "0x1F626F4")]
	public static void ScaleUpdate(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000990")]
	[Address(RVA = "0x1F628E4", Offset = "0x1F618E4", VA = "0x1F628E4")]
	public static void MoveUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000991")]
	[Address(RVA = "0x1F63C6C", Offset = "0x1F62C6C", VA = "0x1F63C6C")]
	public static void MoveUpdate(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x6000992")]
	[Address(RVA = "0x1F631F8", Offset = "0x1F621F8", VA = "0x1F631F8")]
	public static void LookUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000993")]
	[Address(RVA = "0x1F63E5C", Offset = "0x1F62E5C", VA = "0x1F63E5C")]
	public static void LookUpdate(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6000994")]
	[Address(RVA = "0x1F6404C", Offset = "0x1F6304C", VA = "0x1F6404C")]
	public static float PathLength(Transform[] path)
	{
		return default(float);
	}

	[Token(Token = "0x6000995")]
	[Address(RVA = "0x1F5BC28", Offset = "0x1F5AC28", VA = "0x1F5BC28")]
	public static float PathLength(Vector3[] path)
	{
		return default(float);
	}

	[Token(Token = "0x6000996")]
	[Address(RVA = "0x1F6464C", Offset = "0x1F6364C", VA = "0x1F6464C")]
	public static void PutOnPath(GameObject target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x6000997")]
	[Address(RVA = "0x1F646E4", Offset = "0x1F636E4", VA = "0x1F646E4")]
	public static void PutOnPath(Transform target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x6000998")]
	[Address(RVA = "0x1F6476C", Offset = "0x1F6376C", VA = "0x1F6476C")]
	public static void PutOnPath(GameObject target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x6000999")]
	[Address(RVA = "0x1F64898", Offset = "0x1F63898", VA = "0x1F64898")]
	public static void PutOnPath(Transform target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x600099A")]
	[Address(RVA = "0x1F649AC", Offset = "0x1F639AC", VA = "0x1F649AC")]
	public static Vector3 PointOnPath(Transform[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600099B")]
	[Address(RVA = "0x1F64AA4", Offset = "0x1F63AA4", VA = "0x1F64AA4")]
	public static void DrawLine(Vector3[] line)
	{
	}

	[Token(Token = "0x600099C")]
	[Address(RVA = "0x1F64D30", Offset = "0x1F63D30", VA = "0x1F64D30")]
	public static void DrawLine(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x600099D")]
	[Address(RVA = "0x1F64DF0", Offset = "0x1F63DF0", VA = "0x1F64DF0")]
	public static void DrawLine(Transform[] line)
	{
	}

	[Token(Token = "0x600099E")]
	[Address(RVA = "0x1F64F5C", Offset = "0x1F63F5C", VA = "0x1F64F5C")]
	public static void DrawLine(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x600099F")]
	[Address(RVA = "0x1F650A4", Offset = "0x1F640A4", VA = "0x1F650A4")]
	public static void DrawLineGizmos(Vector3[] line)
	{
	}

	[Token(Token = "0x60009A0")]
	[Address(RVA = "0x1F65188", Offset = "0x1F64188", VA = "0x1F65188")]
	public static void DrawLineGizmos(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x60009A1")]
	[Address(RVA = "0x1F65248", Offset = "0x1F64248", VA = "0x1F65248")]
	public static void DrawLineGizmos(Transform[] line)
	{
	}

	[Token(Token = "0x60009A2")]
	[Address(RVA = "0x1F653B4", Offset = "0x1F643B4", VA = "0x1F653B4")]
	public static void DrawLineGizmos(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x60009A3")]
	[Address(RVA = "0x1F654FC", Offset = "0x1F644FC", VA = "0x1F654FC")]
	public static void DrawLineHandles(Vector3[] line)
	{
	}

	[Token(Token = "0x60009A4")]
	[Address(RVA = "0x1F655E0", Offset = "0x1F645E0", VA = "0x1F655E0")]
	public static void DrawLineHandles(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x60009A5")]
	[Address(RVA = "0x1F656A0", Offset = "0x1F646A0", VA = "0x1F656A0")]
	public static void DrawLineHandles(Transform[] line)
	{
	}

	[Token(Token = "0x60009A6")]
	[Address(RVA = "0x1F6580C", Offset = "0x1F6480C", VA = "0x1F6580C")]
	public static void DrawLineHandles(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x60009A7")]
	[Address(RVA = "0x1F65954", Offset = "0x1F64954", VA = "0x1F65954")]
	public static Vector3[] GetPathControlPointGenerator(Vector3[] path)
	{
		return null;
	}

	[Token(Token = "0x60009A8")]
	[Address(RVA = "0x1F659A8", Offset = "0x1F649A8", VA = "0x1F659A8")]
	public static Vector3 PointOnPath(Vector3[] path, float percent, bool generatedPath = false)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60009A9")]
	[Address(RVA = "0x1F65A30", Offset = "0x1F64A30", VA = "0x1F65A30")]
	public static void DrawPath(Vector3[] path)
	{
	}

	[Token(Token = "0x60009AA")]
	[Address(RVA = "0x1F65D18", Offset = "0x1F64D18", VA = "0x1F65D18")]
	public static void DrawPath(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x60009AB")]
	[Address(RVA = "0x1F65DD8", Offset = "0x1F64DD8", VA = "0x1F65DD8")]
	public static void DrawPath(Transform[] path)
	{
	}

	[Token(Token = "0x60009AC")]
	[Address(RVA = "0x1F65F44", Offset = "0x1F64F44", VA = "0x1F65F44")]
	public static void DrawPath(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x60009AD")]
	[Address(RVA = "0x1F6608C", Offset = "0x1F6508C", VA = "0x1F6608C")]
	public static void DrawPathGizmos(Vector3[] path)
	{
	}

	[Token(Token = "0x60009AE")]
	[Address(RVA = "0x1F66170", Offset = "0x1F65170", VA = "0x1F66170")]
	public static void DrawPathGizmos(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x60009AF")]
	[Address(RVA = "0x1F66230", Offset = "0x1F65230", VA = "0x1F66230")]
	public static void DrawPathGizmos(Transform[] path)
	{
	}

	[Token(Token = "0x60009B0")]
	[Address(RVA = "0x1F6639C", Offset = "0x1F6539C", VA = "0x1F6639C")]
	public static void DrawPathGizmos(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x60009B1")]
	[Address(RVA = "0x1F664E4", Offset = "0x1F654E4", VA = "0x1F664E4")]
	public static void DrawPathHandles(Vector3[] path)
	{
	}

	[Token(Token = "0x60009B2")]
	[Address(RVA = "0x1F665C8", Offset = "0x1F655C8", VA = "0x1F665C8")]
	public static void DrawPathHandles(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x60009B3")]
	[Address(RVA = "0x1F66688", Offset = "0x1F65688", VA = "0x1F66688")]
	public static void DrawPathHandles(Transform[] path)
	{
	}

	[Token(Token = "0x60009B4")]
	[Address(RVA = "0x1F667F4", Offset = "0x1F657F4", VA = "0x1F667F4")]
	public static void DrawPathHandles(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x60009B5")]
	[Address(RVA = "0x1F6693C", Offset = "0x1F6593C", VA = "0x1F6693C")]
	public static void Resume(GameObject target)
	{
	}

	[Token(Token = "0x60009B6")]
	[Address(RVA = "0x1F66A20", Offset = "0x1F65A20", VA = "0x1F66A20")]
	public static void Resume(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60009B7")]
	[Address(RVA = "0x1F66D54", Offset = "0x1F65D54", VA = "0x1F66D54")]
	public static void Resume(GameObject target, string type)
	{
	}

	[Token(Token = "0x60009B8")]
	[Address(RVA = "0x1F66EA8", Offset = "0x1F65EA8", VA = "0x1F66EA8")]
	public static void Resume(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60009B9")]
	[Address(RVA = "0x1F672D4", Offset = "0x1F662D4", VA = "0x1F672D4")]
	public static void Resume()
	{
	}

	[Token(Token = "0x60009BA")]
	[Address(RVA = "0x1F673FC", Offset = "0x1F663FC", VA = "0x1F673FC")]
	public static void Resume(string type)
	{
	}

	[Token(Token = "0x60009BB")]
	[Address(RVA = "0x1F67634", Offset = "0x1F66634", VA = "0x1F67634")]
	public static void Pause(GameObject target)
	{
	}

	[Token(Token = "0x60009BC")]
	[Address(RVA = "0x1F67788", Offset = "0x1F66788", VA = "0x1F67788")]
	public static void Pause(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60009BD")]
	[Address(RVA = "0x1F67ABC", Offset = "0x1F66ABC", VA = "0x1F67ABC")]
	public static void Pause(GameObject target, string type)
	{
	}

	[Token(Token = "0x60009BE")]
	[Address(RVA = "0x1F67C70", Offset = "0x1F66C70", VA = "0x1F67C70")]
	public static void Pause(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60009BF")]
	[Address(RVA = "0x1F680FC", Offset = "0x1F670FC", VA = "0x1F680FC")]
	public static void Pause()
	{
	}

	[Token(Token = "0x60009C0")]
	[Address(RVA = "0x1F68224", Offset = "0x1F67224", VA = "0x1F68224")]
	public static void Pause(string type)
	{
	}

	[Token(Token = "0x60009C1")]
	[Address(RVA = "0x1F6845C", Offset = "0x1F6745C", VA = "0x1F6845C")]
	public static int Count()
	{
		return default(int);
	}

	[Token(Token = "0x60009C2")]
	[Address(RVA = "0x1F684CC", Offset = "0x1F674CC", VA = "0x1F684CC")]
	public static int Count(string type)
	{
		return default(int);
	}

	[Token(Token = "0x60009C3")]
	[Address(RVA = "0x1F686C4", Offset = "0x1F676C4", VA = "0x1F686C4")]
	public static int Count(GameObject target)
	{
		return default(int);
	}

	[Token(Token = "0x60009C4")]
	[Address(RVA = "0x1F68720", Offset = "0x1F67720", VA = "0x1F68720")]
	public static int Count(GameObject target, string type)
	{
		return default(int);
	}

	[Token(Token = "0x60009C5")]
	[Address(RVA = "0x1F68878", Offset = "0x1F67878", VA = "0x1F68878")]
	public static void Stop()
	{
	}

	[Token(Token = "0x60009C6")]
	[Address(RVA = "0x1F68AC8", Offset = "0x1F67AC8", VA = "0x1F68AC8")]
	public static void Stop(string type)
	{
	}

	[Token(Token = "0x60009C7")]
	[Address(RVA = "0x1F68E4C", Offset = "0x1F67E4C", VA = "0x1F68E4C")]
	public static void StopByName(string name)
	{
	}

	[Token(Token = "0x60009C8")]
	[Address(RVA = "0x1F689EC", Offset = "0x1F679EC", VA = "0x1F689EC")]
	public static void Stop(GameObject target)
	{
	}

	[Token(Token = "0x60009C9")]
	[Address(RVA = "0x1F69188", Offset = "0x1F68188", VA = "0x1F69188")]
	public static void Stop(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60009CA")]
	[Address(RVA = "0x1F68D00", Offset = "0x1F67D00", VA = "0x1F68D00")]
	public static void Stop(GameObject target, string type)
	{
	}

	[Token(Token = "0x60009CB")]
	[Address(RVA = "0x1F69084", Offset = "0x1F68084", VA = "0x1F69084")]
	public static void StopByName(GameObject target, string name)
	{
	}

	[Token(Token = "0x60009CC")]
	[Address(RVA = "0x1F694BC", Offset = "0x1F684BC", VA = "0x1F694BC")]
	public static void Stop(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60009CD")]
	[Address(RVA = "0x1F698E0", Offset = "0x1F688E0", VA = "0x1F698E0")]
	public static void StopByName(GameObject target, string name, bool includechildren)
	{
	}

	[Token(Token = "0x60009CE")]
	[Address(RVA = "0x1F4C524", Offset = "0x1F4B524", VA = "0x1F4C524")]
	public static Hashtable Hash(params object[] args)
	{
		return null;
	}

	[Token(Token = "0x60009CF")]
	[Address(RVA = "0x1F69CB8", Offset = "0x1F68CB8", VA = "0x1F69CB8")]
	private iTween(Hashtable h)
	{
	}

	[Token(Token = "0x60009D0")]
	[Address(RVA = "0x1F69CE0", Offset = "0x1F68CE0", VA = "0x1F69CE0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60009D1")]
	[Address(RVA = "0x1F6AF9C", Offset = "0x1F69F9C", VA = "0x1F6AF9C")]
	[IteratorStateMachine(typeof(<Start>d__230))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60009D2")]
	[Address(RVA = "0x1F6B004", Offset = "0x1F6A004", VA = "0x1F6B004")]
	private void Update()
	{
	}

	[Token(Token = "0x60009D3")]
	[Address(RVA = "0x1F6B040", Offset = "0x1F6A040", VA = "0x1F6B040")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60009D4")]
	[Address(RVA = "0x1F6B07C", Offset = "0x1F6A07C", VA = "0x1F6B07C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60009D5")]
	[Address(RVA = "0x1F6B1B0", Offset = "0x1F6A1B0", VA = "0x1F6B1B0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60009D6")]
	[Address(RVA = "0x1F6B224", Offset = "0x1F6A224", VA = "0x1F6B224")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60009D7")]
	[Address(RVA = "0x1F64B88", Offset = "0x1F63B88", VA = "0x1F64B88")]
	private static void DrawLineHelper(Vector3[] line, Color color, string method)
	{
	}

	[Token(Token = "0x60009D8")]
	[Address(RVA = "0x1F65B14", Offset = "0x1F64B14", VA = "0x1F65B14")]
	private static void DrawPathHelper(Vector3[] path, Color color, string method)
	{
	}

	[Token(Token = "0x60009D9")]
	[Address(RVA = "0x1F6424C", Offset = "0x1F6324C", VA = "0x1F6424C")]
	private static Vector3[] PathControlPointGenerator(Vector3[] path)
	{
		return null;
	}

	[Token(Token = "0x60009DA")]
	[Address(RVA = "0x1F64458", Offset = "0x1F63458", VA = "0x1F64458")]
	private static Vector3 Interp(Vector3[] pts, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60009DB")]
	[Address(RVA = "0x1F4C1D8", Offset = "0x1F4B1D8", VA = "0x1F4C1D8")]
	private static void Launch(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60009DC")]
	[Address(RVA = "0x1F4B724", Offset = "0x1F4A724", VA = "0x1F4B724")]
	private static Hashtable CleanArgs(Hashtable args)
	{
		return null;
	}

	[Token(Token = "0x60009DD")]
	[Address(RVA = "0x1F6B228", Offset = "0x1F6A228", VA = "0x1F6B228")]
	private static string GenerateID()
	{
		return null;
	}

	[Token(Token = "0x60009DE")]
	[Address(RVA = "0x1F69D10", Offset = "0x1F68D10", VA = "0x1F69D10")]
	private void RetrieveArgs()
	{
	}

	[Token(Token = "0x60009DF")]
	[Address(RVA = "0x1F6B254", Offset = "0x1F6A254", VA = "0x1F6B254")]
	private void GetEasingFunction()
	{
	}

	[Token(Token = "0x60009E0")]
	[Address(RVA = "0x1F5FC00", Offset = "0x1F5EC00", VA = "0x1F5FC00")]
	private void UpdatePercentage()
	{
	}

	[Token(Token = "0x60009E1")]
	[Address(RVA = "0x1F5F260", Offset = "0x1F5E260", VA = "0x1F5F260")]
	private void CallBack(string callbackType)
	{
	}

	[Token(Token = "0x60009E2")]
	[Address(RVA = "0x1F5BA14", Offset = "0x1F5AA14", VA = "0x1F5BA14")]
	private void Dispose()
	{
	}

	[Token(Token = "0x60009E3")]
	[Address(RVA = "0x1F5F574", Offset = "0x1F5E574", VA = "0x1F5F574")]
	private void ConflictCheck()
	{
	}

	[Token(Token = "0x60009E4")]
	[Address(RVA = "0x1F5FB28", Offset = "0x1F5EB28", VA = "0x1F5FB28")]
	private void EnableKinematic()
	{
	}

	[Token(Token = "0x60009E5")]
	[Address(RVA = "0x1F5FDF0", Offset = "0x1F5EDF0", VA = "0x1F5FDF0")]
	private void DisableKinematic()
	{
	}

	[Token(Token = "0x60009E6")]
	[Address(RVA = "0x1F6B1D8", Offset = "0x1F6A1D8", VA = "0x1F6B1D8")]
	private void ResumeDelay()
	{
	}

	[Token(Token = "0x60009E7")]
	[Address(RVA = "0x1F6B5D0", Offset = "0x1F6A5D0", VA = "0x1F6B5D0")]
	private float linear(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60009E8")]
	[Address(RVA = "0x1F5BBC4", Offset = "0x1F5ABC4", VA = "0x1F5BBC4")]
	private float clerp(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60009E9")]
	[Address(RVA = "0x1F6B5F4", Offset = "0x1F6A5F4", VA = "0x1F6B5F4")]
	private float spring(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60009EA")]
	[Address(RVA = "0x1F6B6A4", Offset = "0x1F6A6A4", VA = "0x1F6B6A4")]
	private float easeInQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60009EB")]
	[Address(RVA = "0x1F6B6B8", Offset = "0x1F6A6B8", VA = "0x1F6B6B8")]
	private float easeOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60009EC")]
	[Address(RVA = "0x1F6B6D4", Offset = "0x1F6A6D4", VA = "0x1F6B6D4")]
	private float easeInOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60009ED")]
	[Address(RVA = "0x1F6B728", Offset = "0x1F6A728", VA = "0x1F6B728")]
	private float easeInCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60009EE")]
	[Address(RVA = "0x1F6B740", Offset = "0x1F6A740", VA = "0x1F6B740")]
	private float easeOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60009EF")]
	[Address(RVA = "0x1F6B768", Offset = "0x1F6A768", VA = "0x1F6B768")]
	private float easeInOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60009F0")]
	[Address(RVA = "0x1F6B7C0", Offset = "0x1F6A7C0", VA = "0x1F6B7C0")]
	private float easeInQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60009F1")]
	[Address(RVA = "0x1F6B7DC", Offset = "0x1F6A7DC", VA = "0x1F6B7DC")]
	private float easeOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60009F2")]
	[Address(RVA = "0x1F6B804", Offset = "0x1F6A804", VA = "0x1F6B804")]
	private float easeInOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60009F3")]
	[Address(RVA = "0x1F6B860", Offset = "0x1F6A860", VA = "0x1F6B860")]
	private float easeInQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60009F4")]
	[Address(RVA = "0x1F6B880", Offset = "0x1F6A880", VA = "0x1F6B880")]
	private float easeOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60009F5")]
	[Address(RVA = "0x1F6B8B0", Offset = "0x1F6A8B0", VA = "0x1F6B8B0")]
	private float easeInOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60009F6")]
	[Address(RVA = "0x1F6B918", Offset = "0x1F6A918", VA = "0x1F6B918")]
	private float easeInSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60009F7")]
	[Address(RVA = "0x1F6B950", Offset = "0x1F6A950", VA = "0x1F6B950")]
	private float easeOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60009F8")]
	[Address(RVA = "0x1F6B984", Offset = "0x1F6A984", VA = "0x1F6B984")]
	private float easeInOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60009F9")]
	[Address(RVA = "0x1F6B9C8", Offset = "0x1F6A9C8", VA = "0x1F6B9C8")]
	private float easeInExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60009FA")]
	[Address(RVA = "0x1F6BA00", Offset = "0x1F6AA00", VA = "0x1F6BA00")]
	private float easeOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60009FB")]
	[Address(RVA = "0x1F6BA38", Offset = "0x1F6AA38", VA = "0x1F6BA38")]
	private float easeInOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60009FC")]
	[Address(RVA = "0x1F6BAA8", Offset = "0x1F6AAA8", VA = "0x1F6BAA8")]
	private float easeInCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60009FD")]
	[Address(RVA = "0x1F6BAD0", Offset = "0x1F6AAD0", VA = "0x1F6BAD0")]
	private float easeOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60009FE")]
	[Address(RVA = "0x1F6BAF8", Offset = "0x1F6AAF8", VA = "0x1F6BAF8")]
	private float easeInOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60009FF")]
	[Address(RVA = "0x1F6BB4C", Offset = "0x1F6AB4C", VA = "0x1F6BB4C")]
	private float easeInBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000A00")]
	[Address(RVA = "0x1F6BB84", Offset = "0x1F6AB84", VA = "0x1F6BB84")]
	private float easeOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000A01")]
	[Address(RVA = "0x1F6BC4C", Offset = "0x1F6AC4C", VA = "0x1F6BC4C")]
	private float easeInOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000A02")]
	[Address(RVA = "0x1F6BCCC", Offset = "0x1F6ACCC", VA = "0x1F6BCCC")]
	private float easeInBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000A03")]
	[Address(RVA = "0x1F6BCFC", Offset = "0x1F6ACFC", VA = "0x1F6BCFC")]
	private float easeOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000A04")]
	[Address(RVA = "0x1F6BD3C", Offset = "0x1F6AD3C", VA = "0x1F6BD3C")]
	private float easeInOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000A05")]
	[Address(RVA = "0x1F5E8F8", Offset = "0x1F5D8F8", VA = "0x1F5E8F8")]
	private float punch(float amplitude, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000A06")]
	[Address(RVA = "0x1F6BDC0", Offset = "0x1F6ADC0", VA = "0x1F6BDC0")]
	private float easeInElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000A07")]
	[Address(RVA = "0x1F6BE50", Offset = "0x1F6AE50", VA = "0x1F6BE50")]
	private float easeOutElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000A08")]
	[Address(RVA = "0x1F6BEE0", Offset = "0x1F6AEE0", VA = "0x1F6BEE0")]
	private float easeInOutElastic(float start, float end, float value)
	{
		return default(float);
	}
}
[Token(Token = "0x2000090")]
public class ResultLogger : UnityEngine.Object
{
	[Token(Token = "0x6000A27")]
	[Address(RVA = "0x1F7B2D8", Offset = "0x1F7A2D8", VA = "0x1F7B2D8")]
	public static void logObject(object result)
	{
	}

	[Token(Token = "0x6000A28")]
	[Address(RVA = "0x1F7B4D0", Offset = "0x1F7A4D0", VA = "0x1F7B4D0")]
	public static void logArraylist(ArrayList result)
	{
	}

	[Token(Token = "0x6000A29")]
	[Address(RVA = "0x1F7B850", Offset = "0x1F7A850", VA = "0x1F7B850")]
	public static void logHashtable(Hashtable result)
	{
	}

	[Token(Token = "0x6000A2A")]
	[Address(RVA = "0x1F7B8FC", Offset = "0x1F7A8FC", VA = "0x1F7B8FC")]
	public static void addHashtableToString(StringBuilder builder, Hashtable item)
	{
	}

	[Token(Token = "0x6000A2B")]
	[Address(RVA = "0x1F7BD70", Offset = "0x1F7AD70", VA = "0x1F7BD70")]
	public static void addArraylistToString(StringBuilder builder, ArrayList result)
	{
	}

	[Token(Token = "0x6000A2C")]
	[Address(RVA = "0x1F7C12C", Offset = "0x1F7B12C", VA = "0x1F7C12C")]
	public ResultLogger()
	{
	}
}
[Token(Token = "0x2000091")]
[ExecuteInEditMode]
[AddComponentMenu("SpriteManager 2/Sprite")]
public class EZSprite : SpriteBase
{
	[Token(Token = "0x4000517")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	public Vector2 lowerLeftPixel;

	[Token(Token = "0x4000518")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	public Vector2 pixelDimensions;

	[Token(Token = "0x4000519")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	public UVAnimation_Multi[] animations;

	[Token(Token = "0x400051A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	protected UVAnimation_Multi curAnim;

	[Token(Token = "0x6000A2D")]
	[Address(RVA = "0x1F7C184", Offset = "0x1F7B184", VA = "0x1F7C184", Slot = "45")]
	public override Vector2 GetDefaultPixelSize(PathFromGUIDDelegate guid2Path, AssetLoaderDelegate loader)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000A2E")]
	[Address(RVA = "0x1F7C190", Offset = "0x1F7B190", VA = "0x1F7C190", Slot = "12")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000A2F")]
	[Address(RVA = "0x1F7C254", Offset = "0x1F7B254", VA = "0x1F7C254", Slot = "14")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000A30")]
	[Address(RVA = "0x1F7C25C", Offset = "0x1F7B25C", VA = "0x1F7C25C", Slot = "13")]
	public override void Start()
	{
	}

	[Token(Token = "0x6000A31")]
	[Address(RVA = "0x1F7C310", Offset = "0x1F7B310", VA = "0x1F7C310", Slot = "15")]
	public override void Clear()
	{
	}

	[Token(Token = "0x6000A32")]
	[Address(RVA = "0x1F7C340", Offset = "0x1F7B340", VA = "0x1F7C340")]
	public void Setup(float w, float h, Vector2 lowerleftPixel, Vector2 pixeldimensions)
	{
	}

	[Token(Token = "0x6000A33")]
	[Address(RVA = "0x1F7C438", Offset = "0x1F7B438", VA = "0x1F7C438")]
	public void Setup(float w, float h, Vector2 lowerleftPixel, Vector2 pixeldimensions, Material material)
	{
	}

	[Token(Token = "0x6000A34")]
	[Address(RVA = "0x1F7C578", Offset = "0x1F7B578", VA = "0x1F7C578", Slot = "16")]
	public override void Copy(SpriteRoot s)
	{
	}

	[Token(Token = "0x6000A35")]
	[Address(RVA = "0x1F7C77C", Offset = "0x1F7B77C", VA = "0x1F7C77C", Slot = "17")]
	public override void InitUVs()
	{
	}

	[Token(Token = "0x6000A36")]
	[Address(RVA = "0x1F7C7E8", Offset = "0x1F7B7E8", VA = "0x1F7C7E8")]
	public void AddAnimation(UVAnimation_Multi anim)
	{
	}

	[Token(Token = "0x6000A37")]
	[Address(RVA = "0x1F7C8B0", Offset = "0x1F7B8B0", VA = "0x1F7C8B0", Slot = "56")]
	public override bool StepAnim(float time)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A38")]
	[Address(RVA = "0x1F7CD1C", Offset = "0x1F7BD1C", VA = "0x1F7CD1C")]
	protected void CallAnimCompleteDelegate()
	{
	}

	[Token(Token = "0x6000A39")]
	[Address(RVA = "0x1F7CD3C", Offset = "0x1F7BD3C", VA = "0x1F7CD3C")]
	public void PlayAnim(UVAnimation_Multi anim)
	{
	}

	[Token(Token = "0x6000A3A")]
	[Address(RVA = "0x1F7CED0", Offset = "0x1F7BED0", VA = "0x1F7CED0", Slot = "57")]
	public override void PlayAnim(int index)
	{
	}

	[Token(Token = "0x6000A3B")]
	[Address(RVA = "0x1F7CFCC", Offset = "0x1F7BFCC", VA = "0x1F7CFCC", Slot = "58")]
	public override void PlayAnim(string name)
	{
	}

	[Token(Token = "0x6000A3C")]
	[Address(RVA = "0x1F7D100", Offset = "0x1F7C100", VA = "0x1F7D100")]
	public void PlayAnimInReverse(UVAnimation_Multi anim)
	{
	}

	[Token(Token = "0x6000A3D")]
	[Address(RVA = "0x1F7D248", Offset = "0x1F7C248", VA = "0x1F7D248", Slot = "59")]
	public override void PlayAnimInReverse(int index)
	{
	}

	[Token(Token = "0x6000A3E")]
	[Address(RVA = "0x1F7D344", Offset = "0x1F7C344", VA = "0x1F7D344", Slot = "60")]
	public override void PlayAnimInReverse(string name)
	{
	}

	[Token(Token = "0x6000A3F")]
	[Address(RVA = "0x1F7D49C", Offset = "0x1F7C49C", VA = "0x1F7D49C")]
	public void DoAnim(int index)
	{
	}

	[Token(Token = "0x6000A40")]
	[Address(RVA = "0x1F7D4F8", Offset = "0x1F7C4F8", VA = "0x1F7D4F8")]
	public void DoAnim(string name)
	{
	}

	[Token(Token = "0x6000A41")]
	[Address(RVA = "0x1F7D558", Offset = "0x1F7C558", VA = "0x1F7D558")]
	public void DoAnim(UVAnimation_Multi anim)
	{
	}

	[Token(Token = "0x6000A42")]
	[Address(RVA = "0x1F7D574", Offset = "0x1F7C574", VA = "0x1F7D574", Slot = "61")]
	public override void StopAnim()
	{
	}

	[Token(Token = "0x6000A43")]
	[Address(RVA = "0x1F7D5AC", Offset = "0x1F7C5AC", VA = "0x1F7D5AC")]
	public void UnpauseAnim()
	{
	}

	[Token(Token = "0x6000A44")]
	[Address(RVA = "0x1F7D5C8", Offset = "0x1F7C5C8", VA = "0x1F7D5C8", Slot = "62")]
	protected override void AddToAnimatedList()
	{
	}

	[Token(Token = "0x6000A45")]
	[Address(RVA = "0x1F7D68C", Offset = "0x1F7C68C", VA = "0x1F7D68C", Slot = "63")]
	protected override void RemoveFromAnimatedList()
	{
	}

	[Token(Token = "0x6000A46")]
	[Address(RVA = "0x1F7D6EC", Offset = "0x1F7C6EC", VA = "0x1F7D6EC")]
	public UVAnimation_Multi GetCurAnim()
	{
		return null;
	}

	[Token(Token = "0x6000A47")]
	[Address(RVA = "0x1F7D6F4", Offset = "0x1F7C6F4", VA = "0x1F7D6F4")]
	public UVAnimation_Multi GetAnim(string name)
	{
		return null;
	}

	[Token(Token = "0x6000A48")]
	[Address(RVA = "0x1F7D78C", Offset = "0x1F7C78C", VA = "0x1F7D78C", Slot = "46")]
	public override int GetStateIndex(string stateName)
	{
		return default(int);
	}

	[Token(Token = "0x6000A49")]
	[Address(RVA = "0x1F7D808", Offset = "0x1F7C808", VA = "0x1F7D808", Slot = "47")]
	public override void SetState(int index)
	{
	}

	[Token(Token = "0x6000A4A")]
	[Address(RVA = "0x1F7D818", Offset = "0x1F7C818", VA = "0x1F7D818")]
	public void SetLowerLeftPixel(Vector2 lowerLeft)
	{
	}

	[Token(Token = "0x6000A4B")]
	[Address(RVA = "0x1F7D8B8", Offset = "0x1F7C8B8", VA = "0x1F7D8B8")]
	public void SetLowerLeftPixel(int x, int y)
	{
	}

	[Token(Token = "0x6000A4C")]
	[Address(RVA = "0x1F7D8C4", Offset = "0x1F7C8C4", VA = "0x1F7D8C4")]
	public void SetPixelDimensions(Vector2 size)
	{
	}

	[Token(Token = "0x6000A4D")]
	[Address(RVA = "0x1F7D93C", Offset = "0x1F7C93C", VA = "0x1F7D93C")]
	public void SetPixelDimensions(int x, int y)
	{
	}

	[Token(Token = "0x6000A4E")]
	[Address(RVA = "0x1F7D948", Offset = "0x1F7C948", VA = "0x1F7D948", Slot = "48")]
	public override void DoMirror()
	{
	}

	[Token(Token = "0x6000A4F")]
	[Address(RVA = "0x1F7DA88", Offset = "0x1F7CA88", VA = "0x1F7DA88")]
	public static EZSprite Create(string name, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000A50")]
	[Address(RVA = "0x1F7DBC8", Offset = "0x1F7CBC8", VA = "0x1F7DBC8")]
	public static EZSprite Create(string name, Vector3 pos, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x6000A51")]
	[Address(RVA = "0x1F7DD50", Offset = "0x1F7CD50", VA = "0x1F7DD50")]
	public EZSprite()
	{
	}
}
[Token(Token = "0x2000092")]
public class SpriteMirror : SpriteRootMirror
{
	[Token(Token = "0x400051B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Vector2 lowerLeftPixel;

	[Token(Token = "0x400051C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public Vector2 pixelDimensions;

	[Token(Token = "0x6000A52")]
	[Address(RVA = "0x1F7DD58", Offset = "0x1F7CD58", VA = "0x1F7DD58", Slot = "4")]
	public override void Mirror(SpriteRoot s)
	{
	}

	[Token(Token = "0x6000A53")]
	[Address(RVA = "0x1F7DE20", Offset = "0x1F7CE20", VA = "0x1F7DE20", Slot = "6")]
	public override bool DidChange(SpriteRoot s)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A54")]
	[Address(RVA = "0x1F7DA80", Offset = "0x1F7CA80", VA = "0x1F7DA80")]
	public SpriteMirror()
	{
	}
}
[Token(Token = "0x2000093")]
[AddComponentMenu("SpriteManager 2/PackedSprite")]
public class PackedSprite : AutoSpriteBase
{
	[Token(Token = "0x400051D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	[HideInInspector]
	public string staticTexPath;

	[Token(Token = "0x400051E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	[HideInInspector]
	public string staticTexGUID;

	[Token(Token = "0x400051F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	[HideInInspector]
	public CSpriteFrame _ser_stat_frame_info;

	[Token(Token = "0x4000520")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	[HideInInspector]
	public SPRITE_FRAME staticFrameInfo;

	[Token(Token = "0x4000521")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
	public TextureAnim[] textureAnimations;

	[Token(Token = "0x17000145")]
	public override TextureAnim[] States
	{
		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x1F7DF04", Offset = "0x1F7CF04", VA = "0x1F7DF04", Slot = "79")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x1F7DF5C", Offset = "0x1F7CF5C", VA = "0x1F7DF5C", Slot = "80")]
		set
		{
		}
	}

	[Token(Token = "0x17000146")]
	public override CSpriteFrame DefaultFrame
	{
		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x1F7DF64", Offset = "0x1F7CF64", VA = "0x1F7DF64", Slot = "81")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000147")]
	public override TextureAnim DefaultState
	{
		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x1F7DF6C", Offset = "0x1F7CF6C", VA = "0x1F7DF6C", Slot = "82")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000148")]
	public override bool SupportsArbitraryAnimations
	{
		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x1F7E170", Offset = "0x1F7D170", VA = "0x1F7E170", Slot = "84")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000A59")]
	[Address(RVA = "0x1F7DFB0", Offset = "0x1F7CFB0", VA = "0x1F7DFB0", Slot = "45")]
	public override Vector2 GetDefaultPixelSize(PathFromGUIDDelegate guid2Path, AssetLoaderDelegate loader)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000A5B")]
	[Address(RVA = "0x1F7E178", Offset = "0x1F7D178", VA = "0x1F7E178", Slot = "12")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000A5C")]
	[Address(RVA = "0x1F7E22C", Offset = "0x1F7D22C", VA = "0x1F7E22C", Slot = "13")]
	public override void Start()
	{
	}

	[Token(Token = "0x6000A5D")]
	[Address(RVA = "0x1F7E2E0", Offset = "0x1F7D2E0", VA = "0x1F7E2E0", Slot = "14")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000A5E")]
	[Address(RVA = "0x1F7E2E8", Offset = "0x1F7D2E8", VA = "0x1F7E2E8", Slot = "16")]
	public override void Copy(SpriteRoot s)
	{
	}

	[Token(Token = "0x6000A5F")]
	[Address(RVA = "0x1F7E458", Offset = "0x1F7D458", VA = "0x1F7E458", Slot = "17")]
	public override void InitUVs()
	{
	}

	[Token(Token = "0x6000A60")]
	[Address(RVA = "0x1F7E474", Offset = "0x1F7D474", VA = "0x1F7E474")]
	public void AddAnimation(UVAnimation anim)
	{
	}

	[Token(Token = "0x6000A61")]
	[Address(RVA = "0x1F7E534", Offset = "0x1F7D534", VA = "0x1F7E534", Slot = "88")]
	public override void Aggregate(PathFromGUIDDelegate guid2Path, LoadAssetDelegate load, GUIDFromPathDelegate path2Guid)
	{
	}

	[Token(Token = "0x6000A62")]
	[Address(RVA = "0x1F7EDFC", Offset = "0x1F7DDFC", VA = "0x1F7EDFC")]
	public static PackedSprite Create(string name, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000A63")]
	[Address(RVA = "0x1F7EF3C", Offset = "0x1F7DF3C", VA = "0x1F7EF3C")]
	public static PackedSprite Create(string name, Vector3 pos, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x6000A64")]
	[Address(RVA = "0x1F7F0C4", Offset = "0x1F7E0C4", VA = "0x1F7F0C4")]
	public PackedSprite()
	{
	}
}
[Token(Token = "0x2000094")]
[ExecuteInEditMode]
public class SimpleSprite : SpriteRoot
{
	[Token(Token = "0x4000522")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	public Vector2 lowerLeftPixel;

	[Token(Token = "0x4000523")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public Vector2 pixelDimensions;

	[Token(Token = "0x4000524")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	protected bool nullCamera;

	[Token(Token = "0x6000A65")]
	[Address(RVA = "0x1F7F14C", Offset = "0x1F7E14C", VA = "0x1F7F14C", Slot = "45")]
	public override Vector2 GetDefaultPixelSize(PathFromGUIDDelegate guid2Path, AssetLoaderDelegate loader)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000A66")]
	[Address(RVA = "0x1F7F158", Offset = "0x1F7E158", VA = "0x1F7F158", Slot = "12")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000A67")]
	[Address(RVA = "0x1F7F180", Offset = "0x1F7E180", VA = "0x1F7F180", Slot = "14")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000A68")]
	[Address(RVA = "0x1F7F1F4", Offset = "0x1F7E1F4", VA = "0x1F7F1F4", Slot = "13")]
	public override void Start()
	{
	}

	[Token(Token = "0x6000A69")]
	[Address(RVA = "0x1F7F284", Offset = "0x1F7E284", VA = "0x1F7F284", Slot = "15")]
	public override void Clear()
	{
	}

	[Token(Token = "0x6000A6A")]
	[Address(RVA = "0x1F7F28C", Offset = "0x1F7E28C", VA = "0x1F7F28C")]
	public void Setup(float w, float h, Vector2 lowerleftPixel, Vector2 pixeldimensions)
	{
	}

	[Token(Token = "0x6000A6B")]
	[Address(RVA = "0x1F7F384", Offset = "0x1F7E384", VA = "0x1F7F384")]
	public void Setup(float w, float h, Vector2 lowerleftPixel, Vector2 pixeldimensions, Material material)
	{
	}

	[Token(Token = "0x6000A6C")]
	[Address(RVA = "0x1F7F474", Offset = "0x1F7E474", VA = "0x1F7F474", Slot = "16")]
	public override void Copy(SpriteRoot s)
	{
	}

	[Token(Token = "0x6000A6D")]
	[Address(RVA = "0x1F7F5A0", Offset = "0x1F7E5A0", VA = "0x1F7F5A0", Slot = "17")]
	public override void InitUVs()
	{
	}

	[Token(Token = "0x6000A6E")]
	[Address(RVA = "0x1F7F614", Offset = "0x1F7E614", VA = "0x1F7F614")]
	public void SetLowerLeftPixel(Vector2 lowerLeft)
	{
	}

	[Token(Token = "0x6000A6F")]
	[Address(RVA = "0x1F7F6B4", Offset = "0x1F7E6B4", VA = "0x1F7F6B4")]
	public void SetLowerLeftPixel(int x, int y)
	{
	}

	[Token(Token = "0x6000A70")]
	[Address(RVA = "0x1F7F6C0", Offset = "0x1F7E6C0", VA = "0x1F7F6C0")]
	public void SetPixelDimensions(Vector2 size)
	{
	}

	[Token(Token = "0x6000A71")]
	[Address(RVA = "0x1F7F724", Offset = "0x1F7E724", VA = "0x1F7F724")]
	public void SetPixelDimensions(int x, int y)
	{
	}

	[Token(Token = "0x6000A72")]
	[Address(RVA = "0x1F7F730", Offset = "0x1F7E730", VA = "0x1F7F730", Slot = "46")]
	public override int GetStateIndex(string stateName)
	{
		return default(int);
	}

	[Token(Token = "0x6000A73")]
	[Address(RVA = "0x1F7F738", Offset = "0x1F7E738", VA = "0x1F7F738", Slot = "47")]
	public override void SetState(int index)
	{
	}

	[Token(Token = "0x6000A74")]
	[Address(RVA = "0x1F7F73C", Offset = "0x1F7E73C", VA = "0x1F7F73C")]
	public static SimpleSprite Create(string name, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000A75")]
	[Address(RVA = "0x1F7F87C", Offset = "0x1F7E87C", VA = "0x1F7F87C")]
	public static SimpleSprite Create(string name, Vector3 pos, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x6000A76")]
	[Address(RVA = "0x1F7FA04", Offset = "0x1F7EA04", VA = "0x1F7FA04", Slot = "48")]
	public override void DoMirror()
	{
	}

	[Token(Token = "0x6000A77")]
	[Address(RVA = "0x1F7FB44", Offset = "0x1F7EB44", VA = "0x1F7FB44")]
	public SimpleSprite()
	{
	}
}
[Token(Token = "0x2000095")]
public class SimpleSpriteMirror : SpriteRootMirror
{
	[Token(Token = "0x4000525")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Vector2 lowerLeftPixel;

	[Token(Token = "0x4000526")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public Vector2 pixelDimensions;

	[Token(Token = "0x6000A78")]
	[Address(RVA = "0x1F7FB4C", Offset = "0x1F7EB4C", VA = "0x1F7FB4C", Slot = "4")]
	public override void Mirror(SpriteRoot s)
	{
	}

	[Token(Token = "0x6000A79")]
	[Address(RVA = "0x1F7FC14", Offset = "0x1F7EC14", VA = "0x1F7FC14", Slot = "6")]
	public override bool DidChange(SpriteRoot s)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A7A")]
	[Address(RVA = "0x1F7FB3C", Offset = "0x1F7EB3C", VA = "0x1F7FB3C")]
	public SimpleSpriteMirror()
	{
	}
}
[Token(Token = "0x2000096")]
[ExecuteInEditMode]
[RequireComponent(typeof(SkinnedMeshRenderer))]
public class SpriteManager : MonoBehaviour
{
	[Token(Token = "0x4000527")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SpriteRoot.WINDING_ORDER winding;

	[Token(Token = "0x4000528")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int allocBlockSize;

	[Token(Token = "0x4000529")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool autoUpdateBounds;

	[Token(Token = "0x400052A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool drawBoundingBox;

	[Token(Token = "0x400052B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool persistent;

	[Token(Token = "0x400052C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	protected bool initialized;

	[Token(Token = "0x400052D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected EZLinkedList<SpriteMesh_Managed> availableBlocks;

	[Token(Token = "0x400052E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected bool vertsChanged;

	[Token(Token = "0x400052F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	protected bool uvsChanged;

	[Token(Token = "0x4000530")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	protected bool colorsChanged;

	[Token(Token = "0x4000531")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
	protected bool vertCountChanged;

	[Token(Token = "0x4000532")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	protected bool updateBounds;

	[Token(Token = "0x4000533")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected SpriteMesh_Managed[] sprites;

	[Token(Token = "0x4000534")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected EZLinkedList<SpriteMesh_Managed> activeBlocks;

	[Token(Token = "0x4000535")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected List<SpriteMesh_Managed> spriteDrawOrder;

	[Token(Token = "0x4000536")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected SpriteDrawLayerComparer drawOrderComparer;

	[Token(Token = "0x4000537")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected float boundUpdateInterval;

	[Token(Token = "0x4000538")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected List<SpriteRoot> spriteAddQueue;

	[Token(Token = "0x4000539")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected SkinnedMeshRenderer meshRenderer;

	[Token(Token = "0x400053A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected Mesh mesh;

	[Token(Token = "0x400053B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected Texture texture;

	[Token(Token = "0x400053C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected Transform[] bones;

	[Token(Token = "0x400053D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected BoneWeight[] boneWeights;

	[Token(Token = "0x400053E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected Matrix4x4[] bindPoses;

	[Token(Token = "0x400053F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected Vector3[] vertices;

	[Token(Token = "0x4000540")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected int[] triIndices;

	[Token(Token = "0x4000541")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected Vector2[] UVs;

	[Token(Token = "0x4000542")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	protected Vector2[] UVs2;

	[Token(Token = "0x4000543")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	protected Color[] colors;

	[Token(Token = "0x4000544")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	protected SpriteMesh_Managed tempSprite;

	[Token(Token = "0x17000149")]
	public bool IsInitialized
	{
		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x1F82C94", Offset = "0x1F81C94", VA = "0x1F82C94")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000A7B")]
	[Address(RVA = "0x1F7FCF8", Offset = "0x1F7ECF8", VA = "0x1F7FCF8")]
	public Vector2 PixelSpaceToUVSpace(Vector2 xy)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000A7C")]
	[Address(RVA = "0x1F7FDEC", Offset = "0x1F7EDEC", VA = "0x1F7FDEC")]
	public Vector2 PixelSpaceToUVSpace(int x, int y)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000A7D")]
	[Address(RVA = "0x1F7FDF8", Offset = "0x1F7EDF8", VA = "0x1F7FDF8")]
	public Vector2 PixelCoordToUVCoord(Vector2 xy)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000A7E")]
	[Address(RVA = "0x1F7FF00", Offset = "0x1F7EF00", VA = "0x1F7FF00")]
	public Vector2 PixelCoordToUVCoord(int x, int y)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000A7F")]
	[Address(RVA = "0x1F7FF0C", Offset = "0x1F7EF0C", VA = "0x1F7FF0C")]
	protected void SetupBoneWeights(SpriteMesh_Managed s)
	{
	}

	[Token(Token = "0x6000A80")]
	[Address(RVA = "0x1F80090", Offset = "0x1F7F090", VA = "0x1F80090")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000A81")]
	[Address(RVA = "0x1F80EC0", Offset = "0x1F7FEC0", VA = "0x1F80EC0")]
	protected void InitArrays()
	{
	}

	[Token(Token = "0x6000A82")]
	[Address(RVA = "0x1F80424", Offset = "0x1F7F424", VA = "0x1F80424")]
	protected int EnlargeArrays(int count)
	{
		return default(int);
	}

	[Token(Token = "0x6000A83")]
	[Address(RVA = "0x1F810E4", Offset = "0x1F800E4", VA = "0x1F810E4")]
	public bool AlreadyAdded(SpriteRoot sprite)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A84")]
	[Address(RVA = "0x1F811EC", Offset = "0x1F801EC", VA = "0x1F811EC")]
	public SpriteMesh_Managed AddSprite(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x6000A85")]
	[Address(RVA = "0x1F80AD4", Offset = "0x1F7FAD4", VA = "0x1F80AD4")]
	public SpriteMesh_Managed AddSprite(SpriteRoot sprite)
	{
		return null;
	}

	[Token(Token = "0x6000A86")]
	[Address(RVA = "0x1F81564", Offset = "0x1F80564", VA = "0x1F81564")]
	public SpriteRoot CreateSprite(GameObject prefab)
	{
		return null;
	}

	[Token(Token = "0x6000A87")]
	[Address(RVA = "0x1F81614", Offset = "0x1F80614", VA = "0x1F81614")]
	public SpriteRoot CreateSprite(GameObject prefab, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x6000A88")]
	[Address(RVA = "0x1F817B0", Offset = "0x1F807B0", VA = "0x1F817B0")]
	public void RemoveSprite(SpriteRoot sprite)
	{
	}

	[Token(Token = "0x6000A89")]
	[Address(RVA = "0x1F818D0", Offset = "0x1F808D0", VA = "0x1F818D0")]
	public void RemoveSprite(SpriteMesh_Managed sprite)
	{
	}

	[Token(Token = "0x6000A8A")]
	[Address(RVA = "0x1F81B5C", Offset = "0x1F80B5C", VA = "0x1F81B5C")]
	public void MoveToFront(SpriteMesh_Managed s)
	{
	}

	[Token(Token = "0x6000A8B")]
	[Address(RVA = "0x1F81F58", Offset = "0x1F80F58", VA = "0x1F81F58")]
	public void MoveToBack(SpriteMesh_Managed s)
	{
	}

	[Token(Token = "0x6000A8C")]
	[Address(RVA = "0x1F82328", Offset = "0x1F81328", VA = "0x1F82328")]
	public void MoveInfrontOf(SpriteMesh_Managed toMove, SpriteMesh_Managed reference)
	{
	}

	[Token(Token = "0x6000A8D")]
	[Address(RVA = "0x1F82750", Offset = "0x1F81750", VA = "0x1F82750")]
	public void MoveBehind(SpriteMesh_Managed toMove, SpriteMesh_Managed reference)
	{
	}

	[Token(Token = "0x6000A8E")]
	[Address(RVA = "0x1F81328", Offset = "0x1F80328", VA = "0x1F81328")]
	public void SortDrawingOrder()
	{
	}

	[Token(Token = "0x6000A8F")]
	[Address(RVA = "0x1F82B78", Offset = "0x1F81B78", VA = "0x1F82B78")]
	public SpriteMesh_Managed GetSprite(int i)
	{
		return null;
	}

	[Token(Token = "0x6000A90")]
	[Address(RVA = "0x1F82BB4", Offset = "0x1F81BB4", VA = "0x1F82BB4")]
	public void UpdatePositions()
	{
	}

	[Token(Token = "0x6000A91")]
	[Address(RVA = "0x1F82BC0", Offset = "0x1F81BC0", VA = "0x1F82BC0")]
	public void UpdateUVs()
	{
	}

	[Token(Token = "0x6000A92")]
	[Address(RVA = "0x1F82BCC", Offset = "0x1F81BCC", VA = "0x1F82BCC")]
	public void UpdateColors()
	{
	}

	[Token(Token = "0x6000A93")]
	[Address(RVA = "0x1F82BD8", Offset = "0x1F81BD8", VA = "0x1F82BD8")]
	public void UpdateBounds()
	{
	}

	[Token(Token = "0x6000A94")]
	[Address(RVA = "0x1F82BE4", Offset = "0x1F81BE4", VA = "0x1F82BE4")]
	public void ScheduleBoundsUpdate(float seconds)
	{
	}

	[Token(Token = "0x6000A95")]
	[Address(RVA = "0x1F82C48", Offset = "0x1F81C48", VA = "0x1F82C48")]
	public void CancelBoundsUpdate()
	{
	}

	[Token(Token = "0x6000A97")]
	[Address(RVA = "0x1F82C9C", Offset = "0x1F81C9C", VA = "0x1F82C9C", Slot = "4")]
	public virtual void LateUpdate()
	{
	}

	[Token(Token = "0x6000A98")]
	[Address(RVA = "0x1F82E1C", Offset = "0x1F81E1C", VA = "0x1F82E1C", Slot = "5")]
	public virtual void DoMirror()
	{
	}

	[Token(Token = "0x6000A99")]
	[Address(RVA = "0x1F82FC0", Offset = "0x1F81FC0", VA = "0x1F82FC0", Slot = "6")]
	public virtual void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000A9A")]
	[Address(RVA = "0x1F833A8", Offset = "0x1F823A8", VA = "0x1F833A8")]
	public void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000A9B")]
	[Address(RVA = "0x1F83074", Offset = "0x1F82074", VA = "0x1F83074")]
	protected void DrawCenter()
	{
	}

	[Token(Token = "0x6000A9C")]
	[Address(RVA = "0x1F83454", Offset = "0x1F82454", VA = "0x1F83454")]
	public SpriteManager()
	{
	}
}
[Token(Token = "0x2000097")]
public class SpriteDrawLayerComparer : IComparer<SpriteMesh_Managed>
{
	[Token(Token = "0x6000A9D")]
	[Address(RVA = "0x1F83570", Offset = "0x1F82570", VA = "0x1F83570", Slot = "4")]
	public int Compare(SpriteMesh_Managed a, SpriteMesh_Managed b)
	{
		return default(int);
	}

	[Token(Token = "0x6000A9E")]
	[Address(RVA = "0x1F835A4", Offset = "0x1F825A4", VA = "0x1F835A4")]
	public SpriteDrawLayerComparer()
	{
	}
}
[Serializable]
[Token(Token = "0x2000098")]
[ExecuteInEditMode]
[RequireComponent(typeof(MeshFilter))]
[AddComponentMenu("EZ GUI/Controls/Label")]
[RequireComponent(typeof(MeshRenderer))]
public class SpriteText : MonoBehaviour, IUseCamera
{
	[Token(Token = "0x2000099")]
	public enum Anchor_Pos
	{
		[Token(Token = "0x4000590")]
		Upper_Left,
		[Token(Token = "0x4000591")]
		Upper_Center,
		[Token(Token = "0x4000592")]
		Upper_Right,
		[Token(Token = "0x4000593")]
		Middle_Left,
		[Token(Token = "0x4000594")]
		Middle_Center,
		[Token(Token = "0x4000595")]
		Middle_Right,
		[Token(Token = "0x4000596")]
		Lower_Left,
		[Token(Token = "0x4000597")]
		Lower_Center,
		[Token(Token = "0x4000598")]
		Lower_Right
	}

	[Token(Token = "0x200009A")]
	public enum Alignment_Type
	{
		[Token(Token = "0x400059A")]
		Left,
		[Token(Token = "0x400059B")]
		Center,
		[Token(Token = "0x400059C")]
		Right
	}

	[Token(Token = "0x200009B")]
	protected struct NewlineInsertInfo
	{
		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int index;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int charDelta;

		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x1F85FE4", Offset = "0x1F84FE4", VA = "0x1F85FE4")]
		public NewlineInsertInfo(int idx, int delta)
		{
		}
	}

	[Token(Token = "0x4000545")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[TextArea]
	public string text;

	[Token(Token = "0x4000546")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float offsetZ;

	[Token(Token = "0x4000547")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float characterSize;

	[Token(Token = "0x4000548")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float characterSpacing;

	[Token(Token = "0x4000549")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float lineSpacing;

	[Token(Token = "0x400054A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected float lineSpaceSize;

	[Token(Token = "0x400054B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Anchor_Pos anchor;

	[Token(Token = "0x400054C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Alignment_Type alignment;

	[Token(Token = "0x400054D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int tabSize;

	[Token(Token = "0x400054E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected string tabSpaces;

	[Token(Token = "0x400054F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextAsset font;

	[Token(Token = "0x4000550")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Color color;

	[Token(Token = "0x4000551")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool pixelPerfect;

	[Token(Token = "0x4000552")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float maxWidth;

	[Token(Token = "0x4000553")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool maxWidthInPixels;

	[Token(Token = "0x4000554")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
	public bool multiline;

	[Token(Token = "0x4000555")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
	public bool dynamicLength;

	[Token(Token = "0x4000556")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x73")]
	public bool removeUnsupportedCharacters;

	[Token(Token = "0x4000557")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public bool parseColorTags;

	[Token(Token = "0x4000558")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
	public bool password;

	[Token(Token = "0x4000559")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public string maskingCharacter;

	[Token(Token = "0x400055A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected EZScreenPlacement screenPlacer;

	[Token(Token = "0x400055B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private IControl parentControl;

	[Token(Token = "0x400055C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected bool clipped;

	[Token(Token = "0x400055D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	protected bool updateClipping;

	[Token(Token = "0x400055E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	protected Rect3D clippingRect;

	[Token(Token = "0x400055F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	protected Rect localClipRect;

	[Token(Token = "0x4000560")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	protected Vector3 topLeft;

	[Token(Token = "0x4000561")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	protected Vector3 bottomRight;

	[Token(Token = "0x4000562")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	protected Vector3 unclippedTL;

	[Token(Token = "0x4000563")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	protected Vector3 unclippedBR;

	[Token(Token = "0x4000564")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	protected Color[] colors;

	[Token(Token = "0x4000565")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	protected bool updateColors;

	[Token(Token = "0x4000566")]
	[HideInInspector]
	public const string colorTag = "[#";

	[Token(Token = "0x4000567")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static string[] colDel;

	[Token(Token = "0x4000568")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	protected static char[] newLineDelimiter;

	[Token(Token = "0x4000569")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected static char[] commaDelimiter;

	[Token(Token = "0x400056A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x119")]
	[HideInInspector]
	public bool isClone;

	[Token(Token = "0x400056B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11A")]
	protected bool m_awake;

	[Token(Token = "0x400056C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11B")]
	protected bool m_started;

	[Token(Token = "0x400056D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	protected bool stringContentChanged;

	[Token(Token = "0x400056E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	protected Vector2 screenSize;

	[Token(Token = "0x400056F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public Camera renderCamera;

	[Token(Token = "0x4000570")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	[HideInInspector]
	public Vector2 pixelsPerUV;

	[Token(Token = "0x4000571")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	protected float worldUnitsPerScreenPixel;

	[Token(Token = "0x4000572")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	protected float worldUnitsPerTexel;

	[Token(Token = "0x4000573")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	protected Vector2 worldUnitsPerUV;

	[Token(Token = "0x4000574")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public bool hideAtStart;

	[Token(Token = "0x4000575")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x149")]
	protected bool m_hidden;

	[Token(Token = "0x4000576")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14A")]
	public bool persistent;

	[Token(Token = "0x4000577")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14B")]
	public bool ignoreClipping;

	[Token(Token = "0x4000578")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	protected int capacity;

	[Token(Token = "0x4000579")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	protected string meshString;

	[Token(Token = "0x400057A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	protected string plainText;

	[Token(Token = "0x400057B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	protected string displayString;

	[Token(Token = "0x400057C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	protected List<NewlineInsertInfo> newLineInserts;

	[Token(Token = "0x400057D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	protected float totalWidth;

	[Token(Token = "0x400057E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	protected SpriteFont spriteFont;

	[Token(Token = "0x400057F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	protected SpriteTextMirror mirror;

	[Token(Token = "0x4000580")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	protected Mesh oldMesh;

	[Token(Token = "0x4000581")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	protected Mesh mesh;

	[Token(Token = "0x4000582")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	protected MeshRenderer meshRenderer;

	[Token(Token = "0x4000583")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	protected MeshFilter meshFilter;

	[Token(Token = "0x4000584")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	protected Texture texture;

	[Token(Token = "0x4000585")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	protected Vector3[] vertices;

	[Token(Token = "0x4000586")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	protected int[] faces;

	[Token(Token = "0x4000587")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	protected Vector2[] UVs;

	[Token(Token = "0x4000588")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	protected Color[] meshColors;

	[Token(Token = "0x4000589")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private StringBuilder displaySB;

	[Token(Token = "0x400058A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private StringBuilder plainSB;

	[Token(Token = "0x400058B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private List<int> colorInserts;

	[Token(Token = "0x400058C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private List<int> colorTags;

	[Token(Token = "0x400058D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private List<Color> cols;

	[Token(Token = "0x400058E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private string[] lines;

	[Token(Token = "0x1700014A")]
	public Color Color
	{
		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x1F884FC", Offset = "0x1F874FC", VA = "0x1F884FC")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x1F88508", Offset = "0x1F87508", VA = "0x1F88508")]
		set
		{
		}
	}

	[Token(Token = "0x1700014B")]
	public Camera RenderCamera
	{
		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x1F88730", Offset = "0x1F87730", VA = "0x1F88730", Slot = "6")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x1F88738", Offset = "0x1F87738", VA = "0x1F88738", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x1700014C")]
	public bool Persistent
	{
		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x1F888B8", Offset = "0x1F878B8", VA = "0x1F888B8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x1F85E94", Offset = "0x1F84E94", VA = "0x1F85E94")]
		set
		{
		}
	}

	[Token(Token = "0x1700014D")]
	public string Text
	{
		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x1F888C0", Offset = "0x1F878C0", VA = "0x1F888C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x1F88294", Offset = "0x1F87294", VA = "0x1F88294")]
		set
		{
		}
	}

	[Token(Token = "0x1700014E")]
	public string PlainText
	{
		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x1F888C8", Offset = "0x1F878C8", VA = "0x1F888C8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700014F")]
	public string DisplayString
	{
		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x1F888D0", Offset = "0x1F878D0", VA = "0x1F888D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000150")]
	public Rect3D ClippingRect
	{
		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x1F888D8", Offset = "0x1F878D8", VA = "0x1F888D8")]
		get
		{
			return default(Rect3D);
		}
		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x1F888F8", Offset = "0x1F878F8", VA = "0x1F888F8")]
		set
		{
		}
	}

	[Token(Token = "0x17000151")]
	public bool Clipped
	{
		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x1F8892C", Offset = "0x1F8792C", VA = "0x1F8892C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x1F88934", Offset = "0x1F87934", VA = "0x1F88934")]
		set
		{
		}
	}

	[Token(Token = "0x17000152")]
	public float BaseHeight
	{
		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x1F88F24", Offset = "0x1F87F24", VA = "0x1F88F24")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000153")]
	public float LineSpan
	{
		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x1F88F48", Offset = "0x1F87F48", VA = "0x1F88F48")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000154")]
	public Vector3 TopLeft
	{
		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x1F88F98", Offset = "0x1F87F98", VA = "0x1F88F98")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000155")]
	public Vector3 BottomRight
	{
		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x1F88FA4", Offset = "0x1F87FA4", VA = "0x1F88FA4")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000156")]
	public Vector3 UnclippedTopLeft
	{
		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x1F88FB0", Offset = "0x1F87FB0", VA = "0x1F88FB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000157")]
	public Vector3 UnclippedBottomRight
	{
		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x1F88FE0", Offset = "0x1F87FE0", VA = "0x1F88FE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000158")]
	public float TotalWidth
	{
		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x1F89014", Offset = "0x1F88014", VA = "0x1F89014")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000159")]
	public float TotalScreenWidth
	{
		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x1F8901C", Offset = "0x1F8801C", VA = "0x1F8901C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700015A")]
	public Vector2 PixelSize
	{
		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x1F895D8", Offset = "0x1F885D8", VA = "0x1F895D8")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x1700015B")]
	public bool Password
	{
		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x1F895F8", Offset = "0x1F885F8", VA = "0x1F895F8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x1F89600", Offset = "0x1F88600", VA = "0x1F89600")]
		set
		{
		}
	}

	[Token(Token = "0x1700015C")]
	public Anchor_Pos Anchor
	{
		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x1F89640", Offset = "0x1F88640", VA = "0x1F89640")]
		get
		{
			return default(Anchor_Pos);
		}
		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x1F89648", Offset = "0x1F88648", VA = "0x1F89648")]
		set
		{
		}
	}

	[Token(Token = "0x1700015D")]
	public float CharacterSpacing
	{
		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x1F896A0", Offset = "0x1F886A0", VA = "0x1F896A0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x1F896A8", Offset = "0x1F886A8", VA = "0x1F896A8")]
		set
		{
		}
	}

	[Token(Token = "0x1700015E")]
	public IControl Parent
	{
		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x1F896D0", Offset = "0x1F886D0", VA = "0x1F896D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x1F896D8", Offset = "0x1F886D8", VA = "0x1F896D8")]
		set
		{
		}
	}

	[Token(Token = "0x6000A9F")]
	[Address(RVA = "0x1F835AC", Offset = "0x1F825AC", VA = "0x1F835AC", Slot = "8")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6000AA0")]
	[Address(RVA = "0x1F837AC", Offset = "0x1F827AC", VA = "0x1F837AC", Slot = "9")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x6000AA1")]
	[Address(RVA = "0x1F85778", Offset = "0x1F84778", VA = "0x1F85778", Slot = "10")]
	protected virtual void Init()
	{
	}

	[Token(Token = "0x6000AA2")]
	[Address(RVA = "0x1F85D7C", Offset = "0x1F84D7C", VA = "0x1F85D7C")]
	protected void CreateMesh()
	{
	}

	[Token(Token = "0x6000AA3")]
	[Address(RVA = "0x1F83DFC", Offset = "0x1F82DFC", VA = "0x1F83DFC")]
	protected void ProcessString(string str)
	{
	}

	[Token(Token = "0x6000AA4")]
	[Address(RVA = "0x1F85FEC", Offset = "0x1F84FEC", VA = "0x1F85FEC")]
	protected void DoSingleLineTruncation()
	{
	}

	[Token(Token = "0x6000AA5")]
	[Address(RVA = "0x1F86240", Offset = "0x1F85240", VA = "0x1F86240")]
	protected Color ParseColor(string str)
	{
		return default(Color);
	}

	[Token(Token = "0x6000AA6")]
	[Address(RVA = "0x1F863E0", Offset = "0x1F853E0", VA = "0x1F863E0")]
	protected Color ParseHexColor(string str)
	{
		return default(Color);
	}

	[Token(Token = "0x6000AA7")]
	[Address(RVA = "0x1F8658C", Offset = "0x1F8558C", VA = "0x1F8658C")]
	protected void EnlargeMesh()
	{
	}

	[Token(Token = "0x6000AA8")]
	[Address(RVA = "0x1F85224", Offset = "0x1F84224", VA = "0x1F85224")]
	public void UpdateMesh()
	{
	}

	[Token(Token = "0x6000AA9")]
	[Address(RVA = "0x1F870D8", Offset = "0x1F860D8", VA = "0x1F870D8")]
	protected Vector3 GetStartPos_SingleLine(float baseHeight, float width)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000AAA")]
	[Address(RVA = "0x1F87174", Offset = "0x1F86174", VA = "0x1F87174")]
	public int GetDisplayLineCount(int charIndex, out int charLine, out int lineStart, out int lineEnd)
	{
		return default(int);
	}

	[Token(Token = "0x6000AAB")]
	[Address(RVA = "0x1F85714", Offset = "0x1F84714", VA = "0x1F85714")]
	public int GetDisplayLineCount()
	{
		return default(int);
	}

	[Token(Token = "0x6000AAC")]
	[Address(RVA = "0x1F8727C", Offset = "0x1F8627C", VA = "0x1F8727C")]
	public int PlainIndexToDisplayIndex(int plainCharIndex)
	{
		return default(int);
	}

	[Token(Token = "0x6000AAD")]
	[Address(RVA = "0x1F87338", Offset = "0x1F86338", VA = "0x1F87338")]
	public int DisplayIndexToPlainIndex(int dispCharIndex)
	{
		return default(int);
	}

	[Token(Token = "0x6000AAE")]
	[Address(RVA = "0x1F873F4", Offset = "0x1F863F4", VA = "0x1F873F4")]
	protected float GetLineBaseline(int numLines, int lineNum)
	{
		return default(float);
	}

	[Token(Token = "0x6000AAF")]
	[Address(RVA = "0x1F86894", Offset = "0x1F85894", VA = "0x1F86894")]
	protected void Layout_Single_Line()
	{
	}

	[Token(Token = "0x6000AB0")]
	[Address(RVA = "0x1F86A98", Offset = "0x1F85A98", VA = "0x1F86A98")]
	protected void Layout_Multiline(string[] lines)
	{
	}

	[Token(Token = "0x6000AB1")]
	[Address(RVA = "0x1F8764C", Offset = "0x1F8664C", VA = "0x1F8764C")]
	protected void ZeroQuad(int i)
	{
	}

	[Token(Token = "0x6000AB2")]
	[Address(RVA = "0x1F8773C", Offset = "0x1F8673C", VA = "0x1F8773C")]
	protected void BuildCharacter(int vertNum, int charNum, Vector3 upperLeft, ref SpriteChar ch)
	{
	}

	[Token(Token = "0x6000AB3")]
	[Address(RVA = "0x1F874A4", Offset = "0x1F864A4", VA = "0x1F874A4")]
	protected void Layout_Line(Vector3 startPos, string txt, int charIdx)
	{
	}

	[Token(Token = "0x6000AB4")]
	[Address(RVA = "0x1F86748", Offset = "0x1F85748", VA = "0x1F86748")]
	protected void ClearMesh()
	{
	}

	[Token(Token = "0x6000AB5")]
	[Address(RVA = "0x1F87CA4", Offset = "0x1F86CA4", VA = "0x1F87CA4")]
	public void Unclip()
	{
	}

	[Token(Token = "0x6000AB6")]
	[Address(RVA = "0x1F87CBC", Offset = "0x1F86CBC", VA = "0x1F87CBC")]
	public void Delete()
	{
	}

	[Token(Token = "0x6000AB7")]
	[Address(RVA = "0x1F87D50", Offset = "0x1F86D50", VA = "0x1F87D50")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000AB8")]
	[Address(RVA = "0x1F87DE4", Offset = "0x1F86DE4", VA = "0x1F87DE4", Slot = "11")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000AB9")]
	[Address(RVA = "0x1F88134", Offset = "0x1F87134", VA = "0x1F88134", Slot = "12")]
	public virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000ABA")]
	[Address(RVA = "0x1F88138", Offset = "0x1F87138", VA = "0x1F88138", Slot = "13")]
	public virtual void Copy(SpriteText s)
	{
	}

	[Token(Token = "0x6000ABB")]
	[Address(RVA = "0x1F883B8", Offset = "0x1F873B8", VA = "0x1F883B8")]
	public void CalcSize()
	{
	}

	[Token(Token = "0x6000ABC")]
	[Address(RVA = "0x1F884C0", Offset = "0x1F874C0", VA = "0x1F884C0")]
	protected void LayoutText()
	{
	}

	[Token(Token = "0x6000ABD")]
	[Address(RVA = "0x1F884E4", Offset = "0x1F874E4", VA = "0x1F884E4")]
	public void SetColor(Color c)
	{
	}

	[Token(Token = "0x6000AC0")]
	[Address(RVA = "0x1F856A4", Offset = "0x1F846A4", VA = "0x1F856A4")]
	public void SetCharacterSize(float size)
	{
	}

	[Token(Token = "0x6000AC1")]
	[Address(RVA = "0x1F88520", Offset = "0x1F87520", VA = "0x1F88520")]
	public void SetLineSpacing(float spacing)
	{
	}

	[Token(Token = "0x6000AC2")]
	[Address(RVA = "0x1F8856C", Offset = "0x1F8756C", VA = "0x1F8856C")]
	public void SetMaxWidth(float width)
	{
	}

	[Token(Token = "0x6000AC3")]
	[Address(RVA = "0x1F88578", Offset = "0x1F87578", VA = "0x1F88578")]
	public void SetFont(TextAsset newFont, Material fontMaterial)
	{
	}

	[Token(Token = "0x6000AC4")]
	[Address(RVA = "0x1F885F4", Offset = "0x1F875F4", VA = "0x1F885F4")]
	public void SetFont(SpriteFont newFont, Material fontMaterial)
	{
	}

	[Token(Token = "0x6000AC5")]
	[Address(RVA = "0x1F886F0", Offset = "0x1F876F0", VA = "0x1F886F0")]
	public void SetPixelToUV(int texWidth, int texHeight)
	{
	}

	[Token(Token = "0x6000AC6")]
	[Address(RVA = "0x1F85F0C", Offset = "0x1F84F0C", VA = "0x1F85F0C")]
	public void SetPixelToUV(Texture tex)
	{
	}

	[Token(Token = "0x6000AC9")]
	[Address(RVA = "0x1F88740", Offset = "0x1F87740", VA = "0x1F88740")]
	public void UpdateCamera()
	{
	}

	[Token(Token = "0x6000ACA")]
	[Address(RVA = "0x1F88748", Offset = "0x1F87748", VA = "0x1F88748", Slot = "4")]
	public void SetCamera()
	{
	}

	[Token(Token = "0x6000ACB")]
	[Address(RVA = "0x1F839A4", Offset = "0x1F829A4", VA = "0x1F839A4", Slot = "5")]
	public void SetCamera(Camera c)
	{
	}

	[Token(Token = "0x6000ACC")]
	[Address(RVA = "0x1F88750", Offset = "0x1F87750", VA = "0x1F88750", Slot = "14")]
	public virtual void Hide(bool tf)
	{
	}

	[Token(Token = "0x6000ACD")]
	[Address(RVA = "0x1F888B0", Offset = "0x1F878B0", VA = "0x1F888B0")]
	public bool IsHidden()
	{
		return default(bool);
	}

	[Token(Token = "0x6000AD8")]
	[Address(RVA = "0x1F88964", Offset = "0x1F87964", VA = "0x1F88964")]
	public Vector3 GetInsertionPointPos(int charIndex)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000AD9")]
	[Address(RVA = "0x1F88CAC", Offset = "0x1F87CAC", VA = "0x1F88CAC")]
	public Vector3 GetNearestInsertionPointPos(Vector3 point, ref int insertionPt)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000ADA")]
	[Address(RVA = "0x1F88CD8", Offset = "0x1F87CD8", VA = "0x1F88CD8")]
	public int GetNearestInsertionPoint(Vector3 point)
	{
		return default(int);
	}

	[Token(Token = "0x6000ADD")]
	[Address(RVA = "0x1F88F50", Offset = "0x1F87F50", VA = "0x1F88F50")]
	public Vector3[] GetVertices()
	{
		return null;
	}

	[Token(Token = "0x6000ADE")]
	[Address(RVA = "0x1F88F6C", Offset = "0x1F87F6C", VA = "0x1F88F6C")]
	public Vector3 GetCenterPoint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000AE5")]
	[Address(RVA = "0x1F892C4", Offset = "0x1F882C4", VA = "0x1F892C4")]
	public float GetWidth(string s)
	{
		return default(float);
	}

	[Token(Token = "0x6000AE6")]
	[Address(RVA = "0x1F892F4", Offset = "0x1F882F4", VA = "0x1F892F4")]
	public float GetScreenWidth(string s)
	{
		return default(float);
	}

	[Token(Token = "0x6000AEA")]
	[Address(RVA = "0x1F89614", Offset = "0x1F88614", VA = "0x1F89614")]
	public void SetAnchor(Anchor_Pos a)
	{
	}

	[Token(Token = "0x6000AED")]
	[Address(RVA = "0x1F89674", Offset = "0x1F88674", VA = "0x1F89674")]
	public void SetAlignment(Alignment_Type a)
	{
	}

	[Token(Token = "0x6000AF2")]
	[Address(RVA = "0x1F896E0", Offset = "0x1F886E0", VA = "0x1F896E0")]
	public Vector2 PixelSpaceToUVSpace(Vector2 xy)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000AF3")]
	[Address(RVA = "0x1F89744", Offset = "0x1F88744", VA = "0x1F89744")]
	public Vector2 PixelSpaceToUVSpace(int x, int y)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000AF4")]
	[Address(RVA = "0x1F89750", Offset = "0x1F88750", VA = "0x1F89750")]
	public Vector2 PixelCoordToUVCoord(Vector2 xy)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000AF5")]
	[Address(RVA = "0x1F897C8", Offset = "0x1F887C8", VA = "0x1F897C8")]
	public Vector2 PixelCoordToUVCoord(int x, int y)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000AF6")]
	[Address(RVA = "0x1F897D4", Offset = "0x1F887D4", VA = "0x1F897D4", Slot = "15")]
	public virtual void DoMirror()
	{
	}

	[Token(Token = "0x6000AF7")]
	[Address(RVA = "0x1F8994C", Offset = "0x1F8894C", VA = "0x1F8994C", Slot = "16")]
	public virtual void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000AF8")]
	[Address(RVA = "0x1F8995C", Offset = "0x1F8895C", VA = "0x1F8995C", Slot = "17")]
	public virtual void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000AF9")]
	[Address(RVA = "0x1F8996C", Offset = "0x1F8896C", VA = "0x1F8996C")]
	public SpriteText()
	{
	}
}
[Token(Token = "0x200009C")]
public class SpriteTextMirror
{
	[Token(Token = "0x400059F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string text;

	[Token(Token = "0x40005A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextAsset font;

	[Token(Token = "0x40005A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float offsetZ;

	[Token(Token = "0x40005A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float characterSize;

	[Token(Token = "0x40005A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float characterSpacing;

	[Token(Token = "0x40005A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float lineSpacing;

	[Token(Token = "0x40005A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public SpriteText.Anchor_Pos anchor;

	[Token(Token = "0x40005A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public SpriteText.Alignment_Type alignment;

	[Token(Token = "0x40005A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int tabSize;

	[Token(Token = "0x40005A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Color color;

	[Token(Token = "0x40005A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float maxWidth;

	[Token(Token = "0x40005AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool maxWidthInPixels;

	[Token(Token = "0x40005AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool pixelPerfect;

	[Token(Token = "0x40005AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Camera renderCamera;

	[Token(Token = "0x40005AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool hideAtStart;

	[Token(Token = "0x6000AFC")]
	[Address(RVA = "0x1F89D1C", Offset = "0x1F88D1C", VA = "0x1F89D1C", Slot = "4")]
	public virtual void Mirror(SpriteText s)
	{
	}

	[Token(Token = "0x6000AFD")]
	[Address(RVA = "0x1F89D88", Offset = "0x1F88D88", VA = "0x1F89D88", Slot = "5")]
	public virtual bool Validate(SpriteText s)
	{
		return default(bool);
	}

	[Token(Token = "0x6000AFE")]
	[Address(RVA = "0x1F89D90", Offset = "0x1F88D90", VA = "0x1F89D90", Slot = "6")]
	public virtual bool DidChange(SpriteText s)
	{
		return default(bool);
	}

	[Token(Token = "0x6000AFF")]
	[Address(RVA = "0x1F89944", Offset = "0x1F88944", VA = "0x1F89944")]
	public SpriteTextMirror()
	{
	}
}
[Serializable]
[Token(Token = "0x200009D")]
public class SuperSpriteAnimElement
{
	[Token(Token = "0x40005AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public AutoSpriteBase sprite;

	[Token(Token = "0x40005AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string animName;

	[Token(Token = "0x40005B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public UVAnimation anim;

	[Token(Token = "0x6000B00")]
	[Address(RVA = "0x1F89F78", Offset = "0x1F88F78", VA = "0x1F89F78")]
	public void Init()
	{
	}

	[Token(Token = "0x6000B01")]
	[Address(RVA = "0x1F8A214", Offset = "0x1F89214", VA = "0x1F8A214")]
	public void Play()
	{
	}

	[Token(Token = "0x6000B02")]
	[Address(RVA = "0x1F8A240", Offset = "0x1F89240", VA = "0x1F8A240")]
	public void PlayInReverse()
	{
	}

	[Token(Token = "0x6000B03")]
	[Address(RVA = "0x1F8A38C", Offset = "0x1F8938C", VA = "0x1F8A38C")]
	public SuperSpriteAnimElement()
	{
	}
}
[Serializable]
[Token(Token = "0x200009E")]
public class SuperSpriteAnim
{
	[Token(Token = "0x200009F")]
	public enum ANIM_END_ACTION
	{
		[Token(Token = "0x40005BF")]
		Do_Nothing,
		[Token(Token = "0x40005C0")]
		Play_Default_Anim,
		[Token(Token = "0x40005C1")]
		Deactivate,
		[Token(Token = "0x40005C2")]
		Destroy
	}

	[Token(Token = "0x20000A0")]
	public delegate void AnimCompletedDelegate(SuperSpriteAnim anim);

	[Token(Token = "0x40005B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[HideInInspector]
	public int index;

	[Token(Token = "0x40005B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string name;

	[Token(Token = "0x40005B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SuperSpriteAnimElement[] spriteAnims;

	[Token(Token = "0x40005B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int loopCycles;

	[Token(Token = "0x40005B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool pingPong;

	[Token(Token = "0x40005B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ANIM_END_ACTION onAnimEnd;

	[Token(Token = "0x40005B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool deactivateNonPlaying;

	[Token(Token = "0x40005B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	public bool deactivateRecursively;

	[Token(Token = "0x40005B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected int curAnim;

	[Token(Token = "0x40005BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	protected int stepDir;

	[Token(Token = "0x40005BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected int numLoops;

	[Token(Token = "0x40005BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	protected bool isRunning;

	[Token(Token = "0x40005BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private AnimCompletedDelegate endDelegate;

	[Token(Token = "0x1700015F")]
	public bool IsRunning
	{
		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x1F8AF98", Offset = "0x1F89F98", VA = "0x1F8AF98")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000160")]
	public SpriteBase CurrentSprite
	{
		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x1F8AFA0", Offset = "0x1F89FA0", VA = "0x1F8AFA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000B04")]
	[Address(RVA = "0x1F8A394", Offset = "0x1F89394", VA = "0x1F8A394")]
	public void Init(int idx, AnimCompletedDelegate del, SpriteBase.AnimFrameDelegate frameDel)
	{
	}

	[Token(Token = "0x6000B05")]
	[Address(RVA = "0x1F8A624", Offset = "0x1F89624", VA = "0x1F8A624")]
	public void SetAnimFrameDelegate(SpriteBase.AnimFrameDelegate frameDel)
	{
	}

	[Token(Token = "0x6000B06")]
	[Address(RVA = "0x1F8A704", Offset = "0x1F89704", VA = "0x1F8A704")]
	private void AnimFinished(SpriteBase sp)
	{
	}

	[Token(Token = "0x6000B07")]
	[Address(RVA = "0x1F8ACC4", Offset = "0x1F89CC4", VA = "0x1F8ACC4")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000B08")]
	[Address(RVA = "0x1F8ADC8", Offset = "0x1F89DC8", VA = "0x1F8ADC8")]
	public void Play()
	{
	}

	[Token(Token = "0x6000B09")]
	[Address(RVA = "0x1F8AD40", Offset = "0x1F89D40", VA = "0x1F8AD40")]
	public void Stop()
	{
	}

	[Token(Token = "0x6000B0A")]
	[Address(RVA = "0x1F8AED0", Offset = "0x1F89ED0", VA = "0x1F8AED0")]
	public void Pause()
	{
	}

	[Token(Token = "0x6000B0B")]
	[Address(RVA = "0x1F8AF18", Offset = "0x1F89F18", VA = "0x1F8AF18")]
	public void Unpause()
	{
	}

	[Token(Token = "0x6000B0E")]
	[Address(RVA = "0x1F8AFF0", Offset = "0x1F89FF0", VA = "0x1F8AFF0")]
	public void Hide(bool tf)
	{
	}

	[Token(Token = "0x6000B0F")]
	[Address(RVA = "0x1F8B048", Offset = "0x1F8A048", VA = "0x1F8B048")]
	public bool IsHidden()
	{
		return default(bool);
	}

	[Token(Token = "0x6000B10")]
	[Address(RVA = "0x1F8A5C8", Offset = "0x1F895C8", VA = "0x1F8A5C8")]
	protected void HideSprite(SpriteBase sp, bool tf)
	{
	}

	[Token(Token = "0x6000B11")]
	[Address(RVA = "0x1F8B0A8", Offset = "0x1F8A0A8", VA = "0x1F8B0A8")]
	public void Delete()
	{
	}

	[Token(Token = "0x6000B12")]
	[Address(RVA = "0x1F8B1C8", Offset = "0x1F8A1C8", VA = "0x1F8B1C8")]
	public SuperSpriteAnim()
	{
	}
}
[Serializable]
[Token(Token = "0x20000A1")]
public class SuperSprite : MonoBehaviour
{
	[Token(Token = "0x20000A2")]
	public delegate void AnimCompleteDelegate(SuperSprite sprite);

	[Token(Token = "0x40005C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool playDefaultAnimOnStart;

	[Token(Token = "0x40005C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int defaultAnim;

	[Token(Token = "0x40005C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SuperSpriteAnim[] animations;

	[Token(Token = "0x40005C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected SuperSpriteAnim curAnim;

	[Token(Token = "0x40005C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected bool animating;

	[Token(Token = "0x40005C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected AnimCompleteDelegate animCompleteDelegate;

	[Token(Token = "0x40005C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected SpriteBase.AnimFrameDelegate animFrameDelegate;

	[Token(Token = "0x40005CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected bool m_started;

	[Token(Token = "0x17000161")]
	public SpriteRoot CurrentSprite
	{
		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x1F8B748", Offset = "0x1F8A748", VA = "0x1F8B748")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000B17")]
	[Address(RVA = "0x1F8B368", Offset = "0x1F8A368", VA = "0x1F8B368")]
	public void Start()
	{
	}

	[Token(Token = "0x6000B18")]
	[Address(RVA = "0x1F8B47C", Offset = "0x1F8A47C", VA = "0x1F8B47C")]
	public void PlayAnim(SuperSpriteAnim anim)
	{
	}

	[Token(Token = "0x6000B19")]
	[Address(RVA = "0x1F8B4E4", Offset = "0x1F8A4E4", VA = "0x1F8B4E4")]
	public void PlayAnim(int index)
	{
	}

	[Token(Token = "0x6000B1A")]
	[Address(RVA = "0x1F8B524", Offset = "0x1F8A524", VA = "0x1F8B524")]
	public void PlayAnim(string anim)
	{
	}

	[Token(Token = "0x6000B1B")]
	[Address(RVA = "0x1F8B5C8", Offset = "0x1F8A5C8", VA = "0x1F8B5C8")]
	public void DoAnim(SuperSpriteAnim anim)
	{
	}

	[Token(Token = "0x6000B1C")]
	[Address(RVA = "0x1F8B5EC", Offset = "0x1F8A5EC", VA = "0x1F8B5EC")]
	public void DoAnim(int index)
	{
	}

	[Token(Token = "0x6000B1D")]
	[Address(RVA = "0x1F8B610", Offset = "0x1F8A610", VA = "0x1F8B610")]
	public void DoAnim(string name)
	{
	}

	[Token(Token = "0x6000B1E")]
	[Address(RVA = "0x1F8B664", Offset = "0x1F8A664", VA = "0x1F8B664")]
	public void StopAnim()
	{
	}

	[Token(Token = "0x6000B1F")]
	[Address(RVA = "0x1F8B684", Offset = "0x1F8A684", VA = "0x1F8B684")]
	public void PauseAnim()
	{
	}

	[Token(Token = "0x6000B20")]
	[Address(RVA = "0x1F8B6A4", Offset = "0x1F8A6A4", VA = "0x1F8B6A4")]
	public void UnpauseAnim()
	{
	}

	[Token(Token = "0x6000B21")]
	[Address(RVA = "0x1F8B6C8", Offset = "0x1F8A6C8", VA = "0x1F8B6C8")]
	public void Hide(bool tf)
	{
	}

	[Token(Token = "0x6000B22")]
	[Address(RVA = "0x1F8B730", Offset = "0x1F8A730", VA = "0x1F8B730")]
	public bool IsHidden()
	{
		return default(bool);
	}

	[Token(Token = "0x6000B23")]
	[Address(RVA = "0x1F8B740", Offset = "0x1F8A740", VA = "0x1F8B740")]
	public SuperSpriteAnim GetCurAnim()
	{
		return null;
	}

	[Token(Token = "0x6000B25")]
	[Address(RVA = "0x1F8B758", Offset = "0x1F8A758", VA = "0x1F8B758")]
	public SuperSpriteAnim GetAnim(int index)
	{
		return null;
	}

	[Token(Token = "0x6000B26")]
	[Address(RVA = "0x1F8B798", Offset = "0x1F8A798", VA = "0x1F8B798")]
	public SuperSpriteAnim GetAnim(string name)
	{
		return null;
	}

	[Token(Token = "0x6000B27")]
	[Address(RVA = "0x1F8B830", Offset = "0x1F8A830", VA = "0x1F8B830")]
	public bool IsAnimating()
	{
		return default(bool);
	}

	[Token(Token = "0x6000B28")]
	[Address(RVA = "0x1F8B838", Offset = "0x1F8A838", VA = "0x1F8B838")]
	protected void AnimFinished(SuperSpriteAnim anim)
	{
	}

	[Token(Token = "0x6000B29")]
	[Address(RVA = "0x1F8B970", Offset = "0x1F8A970", VA = "0x1F8B970")]
	public void SetAnimCompleteDelegate(AnimCompleteDelegate del)
	{
	}

	[Token(Token = "0x6000B2A")]
	[Address(RVA = "0x1F8B978", Offset = "0x1F8A978", VA = "0x1F8B978")]
	public void SetAnimFrameDelegate(SpriteBase.AnimFrameDelegate del)
	{
	}

	[Token(Token = "0x6000B2B")]
	[Address(RVA = "0x1F8B9DC", Offset = "0x1F8A9DC", VA = "0x1F8B9DC")]
	public SuperSprite()
	{
	}
}
[Token(Token = "0x20000A3")]
public class AutoSprite : AutoSpriteBase
{
	[Token(Token = "0x40005CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	public TextureAnim[] textureAnimations;

	[Token(Token = "0x17000162")]
	public override TextureAnim[] States
	{
		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x1F8BB74", Offset = "0x1F8AB74", VA = "0x1F8BB74", Slot = "79")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x1F8BB7C", Offset = "0x1F8AB7C", VA = "0x1F8BB7C", Slot = "80")]
		set
		{
		}
	}

	[Token(Token = "0x6000B32")]
	[Address(RVA = "0x1F8BB84", Offset = "0x1F8AB84", VA = "0x1F8BB84", Slot = "12")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000B33")]
	[Address(RVA = "0x1F8BD84", Offset = "0x1F8AD84", VA = "0x1F8BD84", Slot = "14")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000B34")]
	[Address(RVA = "0x1F8BD8C", Offset = "0x1F8AD8C", VA = "0x1F8BD8C")]
	public AutoSprite()
	{
	}
}
[Serializable]
[Token(Token = "0x20000A4")]
public class TextureAnim
{
	[Token(Token = "0x40005CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x40005CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int loopCycles;

	[Token(Token = "0x40005CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool loopReverse;

	[Token(Token = "0x40005CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float framerate;

	[Token(Token = "0x40005D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public UVAnimation.ANIM_END_ACTION onAnimEnd;

	[Token(Token = "0x40005D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public string[] framePaths;

	[Token(Token = "0x40005D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public string[] frameGUIDs;

	[Token(Token = "0x40005D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public CSpriteFrame[] spriteFrames;

	[Token(Token = "0x6000B35")]
	[Address(RVA = "0x1F8BD9C", Offset = "0x1F8AD9C", VA = "0x1F8BD9C")]
	public void Allocate()
	{
	}

	[Token(Token = "0x6000B36")]
	[Address(RVA = "0x1F8BF00", Offset = "0x1F8AF00", VA = "0x1F8BF00")]
	public TextureAnim()
	{
	}

	[Token(Token = "0x6000B37")]
	[Address(RVA = "0x1F8BF24", Offset = "0x1F8AF24", VA = "0x1F8BF24")]
	public TextureAnim(string n)
	{
	}

	[Token(Token = "0x6000B38")]
	[Address(RVA = "0x1F8BF58", Offset = "0x1F8AF58", VA = "0x1F8BF58")]
	public void Copy(TextureAnim a)
	{
	}
}
[Token(Token = "0x20000A5")]
public abstract class AutoSpriteBase : SpriteBase, ISpriteAggregator, ISpritePackable
{
	[Token(Token = "0x40005D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	protected Texture2D[] sourceTextures;

	[Token(Token = "0x40005D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	protected CSpriteFrame[] spriteFrames;

	[Token(Token = "0x40005D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	public bool doNotTrimImages;

	[Token(Token = "0x40005D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	[HideInInspector]
	public UVAnimation[] animations;

	[Token(Token = "0x40005D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	protected UVAnimation curAnim;

	[Token(Token = "0x17000163")]
	public abstract TextureAnim[] States
	{
		[Token(Token = "0x6000B39")]
		get;
		[Token(Token = "0x6000B3A")]
		set;
	}

	[Token(Token = "0x17000164")]
	public virtual CSpriteFrame DefaultFrame
	{
		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x1F8C114", Offset = "0x1F8B114", VA = "0x1F8C114", Slot = "81")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000165")]
	public virtual TextureAnim DefaultState
	{
		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0x1F8C1A4", Offset = "0x1F8B1A4", VA = "0x1F8C1A4", Slot = "82")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000166")]
	public virtual bool SupportsArbitraryAnimations
	{
		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x1F8DE50", Offset = "0x1F8CE50", VA = "0x1F8DE50", Slot = "84")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000167")]
	public virtual bool DoNotTrimImages
	{
		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x1F8E03C", Offset = "0x1F8D03C", VA = "0x1F8E03C", Slot = "86")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000B64")]
		[Address(RVA = "0x1F8E044", Offset = "0x1F8D044", VA = "0x1F8E044", Slot = "87")]
		set
		{
		}
	}

	[Token(Token = "0x17000168")]
	public Texture2D[] SourceTextures
	{
		[Token(Token = "0x6000B66")]
		[Address(RVA = "0x1F8E9E4", Offset = "0x1F8D9E4", VA = "0x1F8E9E4", Slot = "65")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000169")]
	public CSpriteFrame[] SpriteFrames
	{
		[Token(Token = "0x6000B67")]
		[Address(RVA = "0x1F8E9EC", Offset = "0x1F8D9EC", VA = "0x1F8E9EC", Slot = "66")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000B3D")]
	[Address(RVA = "0x1F8C21C", Offset = "0x1F8B21C", VA = "0x1F8C21C", Slot = "45")]
	public override Vector2 GetDefaultPixelSize(PathFromGUIDDelegate guid2Path, AssetLoaderDelegate loader)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000B3E")]
	[Address(RVA = "0x1F8BBF4", Offset = "0x1F8ABF4", VA = "0x1F8BBF4", Slot = "12")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000B3F")]
	[Address(RVA = "0x1F8C624", Offset = "0x1F8B624", VA = "0x1F8C624", Slot = "15")]
	public override void Clear()
	{
	}

	[Token(Token = "0x6000B40")]
	[Address(RVA = "0x1F8C654", Offset = "0x1F8B654", VA = "0x1F8C654")]
	public void Setup(float w, float h)
	{
	}

	[Token(Token = "0x6000B41")]
	[Address(RVA = "0x1F8C71C", Offset = "0x1F8B71C", VA = "0x1F8C71C")]
	public void Setup(float w, float h, Material material)
	{
	}

	[Token(Token = "0x6000B42")]
	[Address(RVA = "0x1F8C7D8", Offset = "0x1F8B7D8", VA = "0x1F8C7D8", Slot = "16")]
	public override void Copy(SpriteRoot s)
	{
	}

	[Token(Token = "0x6000B43")]
	[Address(RVA = "0x1F8CA74", Offset = "0x1F8BA74", VA = "0x1F8CA74", Slot = "83")]
	public virtual void CopyAll(SpriteRoot s)
	{
	}

	[Token(Token = "0x6000B44")]
	[Address(RVA = "0x1F8CDB8", Offset = "0x1F8BDB8", VA = "0x1F8CDB8", Slot = "56")]
	public override bool StepAnim(float time)
	{
		return default(bool);
	}

	[Token(Token = "0x6000B45")]
	[Address(RVA = "0x1F8D224", Offset = "0x1F8C224", VA = "0x1F8D224")]
	protected void CallAnimCompleteDelegate()
	{
	}

	[Token(Token = "0x6000B46")]
	[Address(RVA = "0x1F8AB08", Offset = "0x1F89B08", VA = "0x1F8AB08")]
	public void PlayAnim(UVAnimation anim, int frame)
	{
	}

	[Token(Token = "0x6000B47")]
	[Address(RVA = "0x1F8A238", Offset = "0x1F89238", VA = "0x1F8A238")]
	public void PlayAnim(UVAnimation anim)
	{
	}

	[Token(Token = "0x6000B48")]
	[Address(RVA = "0x1F8D244", Offset = "0x1F8C244", VA = "0x1F8D244")]
	public void PlayAnim(int index, int frame)
	{
	}

	[Token(Token = "0x6000B49")]
	[Address(RVA = "0x1F8D348", Offset = "0x1F8C348", VA = "0x1F8D348", Slot = "57")]
	public override void PlayAnim(int index)
	{
	}

	[Token(Token = "0x6000B4A")]
	[Address(RVA = "0x1F8D448", Offset = "0x1F8C448", VA = "0x1F8D448")]
	public void PlayAnim(string name, int frame)
	{
	}

	[Token(Token = "0x6000B4B")]
	[Address(RVA = "0x1F8D590", Offset = "0x1F8C590", VA = "0x1F8D590", Slot = "58")]
	public override void PlayAnim(string name)
	{
	}

	[Token(Token = "0x6000B4C")]
	[Address(RVA = "0x1F8A260", Offset = "0x1F89260", VA = "0x1F8A260")]
	public void PlayAnimInReverse(UVAnimation anim)
	{
	}

	[Token(Token = "0x6000B4D")]
	[Address(RVA = "0x1F8A9C0", Offset = "0x1F899C0", VA = "0x1F8A9C0")]
	public void PlayAnimInReverse(UVAnimation anim, int frame)
	{
	}

	[Token(Token = "0x6000B4E")]
	[Address(RVA = "0x1F8D598", Offset = "0x1F8C598", VA = "0x1F8D598", Slot = "59")]
	public override void PlayAnimInReverse(int index)
	{
	}

	[Token(Token = "0x6000B4F")]
	[Address(RVA = "0x1F8D694", Offset = "0x1F8C694", VA = "0x1F8D694")]
	public void PlayAnimInReverse(int index, int frame)
	{
	}

	[Token(Token = "0x6000B50")]
	[Address(RVA = "0x1F8D798", Offset = "0x1F8C798", VA = "0x1F8D798", Slot = "60")]
	public override void PlayAnimInReverse(string name)
	{
	}

	[Token(Token = "0x6000B51")]
	[Address(RVA = "0x1F8D8F0", Offset = "0x1F8C8F0", VA = "0x1F8D8F0")]
	public void PlayAnimInReverse(string name, int frame)
	{
	}

	[Token(Token = "0x6000B52")]
	[Address(RVA = "0x1F8DA5C", Offset = "0x1F8CA5C", VA = "0x1F8DA5C")]
	public void DoAnim(int index)
	{
	}

	[Token(Token = "0x6000B53")]
	[Address(RVA = "0x1F8DA8C", Offset = "0x1F8CA8C", VA = "0x1F8DA8C")]
	public void DoAnim(string name)
	{
	}

	[Token(Token = "0x6000B54")]
	[Address(RVA = "0x1F8DAEC", Offset = "0x1F8CAEC", VA = "0x1F8DAEC")]
	public void DoAnim(UVAnimation anim)
	{
	}

	[Token(Token = "0x6000B55")]
	[Address(RVA = "0x1F8DB0C", Offset = "0x1F8CB0C", VA = "0x1F8DB0C")]
	public void SetCurFrame(int index)
	{
	}

	[Token(Token = "0x6000B56")]
	[Address(RVA = "0x1F8DB90", Offset = "0x1F8CB90", VA = "0x1F8DB90")]
	public void SetFrame(UVAnimation anim, int frameNum)
	{
	}

	[Token(Token = "0x6000B57")]
	[Address(RVA = "0x1F8DBD0", Offset = "0x1F8CBD0", VA = "0x1F8DBD0")]
	public void SetFrame(string anim, int frameNum)
	{
	}

	[Token(Token = "0x6000B58")]
	[Address(RVA = "0x1F8DC18", Offset = "0x1F8CC18", VA = "0x1F8DC18")]
	public void SetFrame(int anim, int frameNum)
	{
	}

	[Token(Token = "0x6000B59")]
	[Address(RVA = "0x1F8DC60", Offset = "0x1F8CC60", VA = "0x1F8DC60", Slot = "61")]
	public override void StopAnim()
	{
	}

	[Token(Token = "0x6000B5A")]
	[Address(RVA = "0x1F8AF7C", Offset = "0x1F89F7C", VA = "0x1F8AF7C")]
	public void UnpauseAnim()
	{
	}

	[Token(Token = "0x6000B5B")]
	[Address(RVA = "0x1F8DC98", Offset = "0x1F8CC98", VA = "0x1F8DC98", Slot = "62")]
	protected override void AddToAnimatedList()
	{
	}

	[Token(Token = "0x6000B5C")]
	[Address(RVA = "0x1F8DD5C", Offset = "0x1F8CD5C", VA = "0x1F8DD5C", Slot = "63")]
	protected override void RemoveFromAnimatedList()
	{
	}

	[Token(Token = "0x6000B5D")]
	[Address(RVA = "0x1F8DDBC", Offset = "0x1F8CDBC", VA = "0x1F8DDBC")]
	public UVAnimation GetCurAnim()
	{
		return null;
	}

	[Token(Token = "0x6000B5E")]
	[Address(RVA = "0x1F8A17C", Offset = "0x1F8917C", VA = "0x1F8A17C")]
	public UVAnimation GetAnim(string name)
	{
		return null;
	}

	[Token(Token = "0x6000B5F")]
	[Address(RVA = "0x1F8DDC4", Offset = "0x1F8CDC4", VA = "0x1F8DDC4", Slot = "46")]
	public override int GetStateIndex(string stateName)
	{
		return default(int);
	}

	[Token(Token = "0x6000B60")]
	[Address(RVA = "0x1F8DE40", Offset = "0x1F8CE40", VA = "0x1F8DE40", Slot = "47")]
	public override void SetState(int index)
	{
	}

	[Token(Token = "0x6000B62")]
	[Address(RVA = "0x1F8DE58", Offset = "0x1F8CE58", VA = "0x1F8DE58", Slot = "85")]
	public virtual Material GetPackedMaterial(out string errString)
	{
		return null;
	}

	[Token(Token = "0x6000B65")]
	[Address(RVA = "0x1F8E050", Offset = "0x1F8D050", VA = "0x1F8E050", Slot = "88")]
	public virtual void Aggregate(PathFromGUIDDelegate guid2Path, LoadAssetDelegate load, GUIDFromPathDelegate path2Guid)
	{
	}

	[Token(Token = "0x6000B68")]
	[Address(RVA = "0x1F8BD94", Offset = "0x1F8AD94", VA = "0x1F8BD94")]
	protected AutoSpriteBase()
	{
	}

	[Token(Token = "0x6000B69")]
	[Address(RVA = "0x1F8E9F4", Offset = "0x1F8D9F4", VA = "0x1F8E9F4", Slot = "70")]
	private GameObject ISpriteAggregator.get_gameObject()
	{
		return null;
	}

	[Token(Token = "0x6000B6A")]
	[Address(RVA = "0x1F8E9FC", Offset = "0x1F8D9FC", VA = "0x1F8E9FC", Slot = "72")]
	private GameObject ISpritePackable.get_gameObject()
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x20000A6")]
public class EZTransitionList
{
	[Token(Token = "0x40005D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public EZTransition[] list;

	[Token(Token = "0x6000B6B")]
	[Address(RVA = "0x1F8EA04", Offset = "0x1F8DA04", VA = "0x1F8EA04")]
	public EZTransitionList(EZTransition[] l)
	{
	}

	[Token(Token = "0x6000B6C")]
	[Address(RVA = "0x1F8EA70", Offset = "0x1F8DA70", VA = "0x1F8EA70")]
	public EZTransitionList()
	{
	}

	[Token(Token = "0x6000B6D")]
	[Address(RVA = "0x1F8EADC", Offset = "0x1F8DADC", VA = "0x1F8EADC")]
	public void Clone(int source, bool force)
	{
	}

	[Token(Token = "0x6000B6E")]
	[Address(RVA = "0x1F8ED3C", Offset = "0x1F8DD3C", VA = "0x1F8ED3C")]
	public void CloneAsNeeded(int source)
	{
	}

	[Token(Token = "0x6000B6F")]
	[Address(RVA = "0x1F8ED44", Offset = "0x1F8DD44", VA = "0x1F8ED44")]
	public void CloneAll(int source)
	{
	}

	[Token(Token = "0x6000B70")]
	[Address(RVA = "0x1F8ED4C", Offset = "0x1F8DD4C", VA = "0x1F8ED4C")]
	public void MarkAllInitialized()
	{
	}

	[Token(Token = "0x6000B71")]
	[Address(RVA = "0x1F8EDA0", Offset = "0x1F8DDA0", VA = "0x1F8EDA0")]
	public string[] GetTransitionNames()
	{
		return null;
	}

	[Token(Token = "0x6000B72")]
	[Address(RVA = "0x1F8EE50", Offset = "0x1F8DE50", VA = "0x1F8EE50")]
	public void CopyTo(EZTransitionList target)
	{
	}

	[Token(Token = "0x6000B73")]
	[Address(RVA = "0x1F8EE58", Offset = "0x1F8DE58", VA = "0x1F8EE58")]
	public void CopyTo(EZTransitionList target, bool copyInit)
	{
	}

	[Token(Token = "0x6000B74")]
	[Address(RVA = "0x1F8EF38", Offset = "0x1F8DF38", VA = "0x1F8EF38")]
	public void CopyToNew(EZTransitionList target)
	{
	}

	[Token(Token = "0x6000B75")]
	[Address(RVA = "0x1F8EF40", Offset = "0x1F8DF40", VA = "0x1F8EF40")]
	public void CopyToNew(EZTransitionList target, bool copyInit)
	{
	}
}
[Serializable]
[Token(Token = "0x20000A7")]
public class EZTransition
{
	[Token(Token = "0x20000A8")]
	public delegate void OnTransitionEndDelegate(EZTransition transition);

	[Token(Token = "0x20000A9")]
	public delegate void OnTransitionStartDelegate(EZTransition transition);

	[Token(Token = "0x40005DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x40005DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public EZAnimation.ANIM_TYPE[] animationTypes;

	[Token(Token = "0x40005DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AnimParams[] animParams;

	[NonSerialized]
	[Token(Token = "0x40005DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected EZLinkedList<EZLinkedListNode<EZAnimation>> runningAnims;

	[Token(Token = "0x40005DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected EZLinkedList<EZLinkedListNode<EZAnimation>> idleAnims;

	[NonSerialized]
	[Token(Token = "0x40005DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected GameObject mainSubject;

	[NonSerialized]
	[Token(Token = "0x40005E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected EZLinkedList<EZLinkedListNode<GameObject>> subSubjects;

	[NonSerialized]
	[Token(Token = "0x40005E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected OnTransitionEndDelegate onEndDelegates;

	[NonSerialized]
	[Token(Token = "0x40005E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected OnTransitionStartDelegate onStartDelegates;

	[Token(Token = "0x40005E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool initialized;

	[Token(Token = "0x40005E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	protected bool forcedStop;

	[Token(Token = "0x1700016A")]
	public EZLinkedList<EZLinkedListNode<GameObject>> SubSubjects
	{
		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x1F8F3D0", Offset = "0x1F8E3D0", VA = "0x1F8F3D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700016B")]
	public GameObject MainSubject
	{
		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x1F8F3D8", Offset = "0x1F8E3D8", VA = "0x1F8F3D8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x1F8F3E0", Offset = "0x1F8E3E0", VA = "0x1F8F3E0")]
		set
		{
		}
	}

	[Token(Token = "0x6000B76")]
	[Address(RVA = "0x1F8F094", Offset = "0x1F8E094", VA = "0x1F8F094")]
	public EZTransition(string n)
	{
	}

	[Token(Token = "0x6000B77")]
	[Address(RVA = "0x1F8F1D0", Offset = "0x1F8E1D0", VA = "0x1F8F1D0")]
	public void AddTransitionStartDelegate(OnTransitionStartDelegate del)
	{
	}

	[Token(Token = "0x6000B78")]
	[Address(RVA = "0x1F8F250", Offset = "0x1F8E250", VA = "0x1F8F250")]
	public void RemoveTransitionStartDelegate(OnTransitionStartDelegate del)
	{
	}

	[Token(Token = "0x6000B79")]
	[Address(RVA = "0x1F8F2D0", Offset = "0x1F8E2D0", VA = "0x1F8F2D0")]
	public void AddTransitionEndDelegate(OnTransitionEndDelegate del)
	{
	}

	[Token(Token = "0x6000B7A")]
	[Address(RVA = "0x1F8F350", Offset = "0x1F8E350", VA = "0x1F8F350")]
	public void RemoveTransitionEndDelegate(OnTransitionEndDelegate del)
	{
	}

	[Token(Token = "0x6000B7B")]
	[Address(RVA = "0x1F8EBB8", Offset = "0x1F8DBB8", VA = "0x1F8EBB8")]
	public void Copy(EZTransition src)
	{
	}

	[Token(Token = "0x6000B7F")]
	[Address(RVA = "0x1F8F3E8", Offset = "0x1F8E3E8", VA = "0x1F8F3E8")]
	public void AddSubSubject(GameObject go)
	{
	}

	[Token(Token = "0x6000B80")]
	[Address(RVA = "0x1F8F4D0", Offset = "0x1F8E4D0", VA = "0x1F8F4D0")]
	public void RemoveSubSubject(GameObject go)
	{
	}

	[Token(Token = "0x6000B81")]
	[Address(RVA = "0x1F8F604", Offset = "0x1F8E604", VA = "0x1F8F604")]
	public void OnAnimEnd(EZAnimation anim)
	{
	}

	[Token(Token = "0x6000B82")]
	[Address(RVA = "0x1F8F7D8", Offset = "0x1F8E7D8", VA = "0x1F8F7D8")]
	public EZLinkedListNode<EZAnimation> AddRunningAnim()
	{
		return null;
	}

	[Token(Token = "0x6000B83")]
	[Address(RVA = "0x1F8F944", Offset = "0x1F8E944", VA = "0x1F8F944")]
	public void Start()
	{
	}

	[Token(Token = "0x6000B84")]
	[Address(RVA = "0x1F8FE7C", Offset = "0x1F8EE7C", VA = "0x1F8FE7C")]
	public void End()
	{
	}

	[Token(Token = "0x6000B85")]
	[Address(RVA = "0x1F8FA74", Offset = "0x1F8EA74", VA = "0x1F8FA74")]
	public void StopSafe()
	{
	}

	[Token(Token = "0x6000B86")]
	[Address(RVA = "0x1F90100", Offset = "0x1F8F100", VA = "0x1F90100")]
	public void Pause()
	{
	}

	[Token(Token = "0x6000B87")]
	[Address(RVA = "0x1F901F0", Offset = "0x1F8F1F0", VA = "0x1F901F0")]
	public void Unpause()
	{
	}

	[Token(Token = "0x6000B88")]
	[Address(RVA = "0x1F902E0", Offset = "0x1F8F2E0", VA = "0x1F902E0")]
	public bool IsRunning()
	{
		return default(bool);
	}

	[Token(Token = "0x6000B89")]
	[Address(RVA = "0x1F903F4", Offset = "0x1F8F3F4", VA = "0x1F903F4")]
	public bool IsRunningAtAll()
	{
		return default(bool);
	}

	[Token(Token = "0x6000B8A")]
	[Address(RVA = "0x1F8F7B0", Offset = "0x1F8E7B0", VA = "0x1F8F7B0")]
	protected void CallEndDelegates()
	{
	}

	[Token(Token = "0x6000B8B")]
	[Address(RVA = "0x1F90448", Offset = "0x1F8F448", VA = "0x1F90448")]
	public int Add()
	{
		return default(int);
	}

	[Token(Token = "0x6000B8C")]
	[Address(RVA = "0x1F906CC", Offset = "0x1F8F6CC", VA = "0x1F906CC")]
	public AnimParams AddElement(EZAnimation.ANIM_TYPE type)
	{
		return null;
	}

	[Token(Token = "0x6000B8D")]
	[Address(RVA = "0x1F90730", Offset = "0x1F8F730", VA = "0x1F90730")]
	public void Remove(int index)
	{
	}

	[Token(Token = "0x6000B8E")]
	[Address(RVA = "0x1F908FC", Offset = "0x1F8F8FC", VA = "0x1F908FC")]
	public void SetElementType(int index, EZAnimation.ANIM_TYPE type)
	{
	}

	[Token(Token = "0x6000B8F")]
	[Address(RVA = "0x1F90944", Offset = "0x1F8F944", VA = "0x1F90944")]
	public string[] GetNames()
	{
		return null;
	}
}
[Token(Token = "0x20000AA")]
public interface IGUIHelper
{
	[Token(Token = "0x6000B98")]
	Enum EnumField(string label, Enum selected);

	[Token(Token = "0x6000B99")]
	Color ColorField(string label, Color color);

	[Token(Token = "0x6000B9A")]
	Vector3 Vector3Field(string label, Vector3 val);

	[Token(Token = "0x6000B9B")]
	float FloatField(string label, float val);

	[Token(Token = "0x6000B9C")]
	string TextField(string label, string val);

	[Token(Token = "0x6000B9D")]
	UnityEngine.Object ObjectField(string label, Type type, UnityEngine.Object obj);
}
[Token(Token = "0x20000AB")]
public class EZAnimator : MonoBehaviour
{
	[Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class <AnimPump>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private EZLinkedListIterator<EZAnimation> <i>5__2;

		[Token(Token = "0x1700016E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000BC0")]
			[Address(RVA = "0x1F92858", Offset = "0x1F91858", VA = "0x1F92858", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000BC2")]
			[Address(RVA = "0x1F92898", Offset = "0x1F91898", VA = "0x1F92898", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0x1F92578", Offset = "0x1F91578", VA = "0x1F92578")]
		[DebuggerHidden]
		public <AnimPump>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x6000BBE")]
		[Address(RVA = "0x1F925A0", Offset = "0x1F915A0", VA = "0x1F925A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000BBF")]
		[Address(RVA = "0x1F925A4", Offset = "0x1F915A4", VA = "0x1F925A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0x1F92860", Offset = "0x1F91860", VA = "0x1F92860", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class <PumpStarter>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EZAnimator <>4__this;

		[Token(Token = "0x17000170")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000BC6")]
			[Address(RVA = "0x1F92984", Offset = "0x1F91984", VA = "0x1F92984", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000171")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000BC8")]
			[Address(RVA = "0x1F929C4", Offset = "0x1F919C4", VA = "0x1F929C4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BC3")]
		[Address(RVA = "0x1F928A0", Offset = "0x1F918A0", VA = "0x1F928A0")]
		[DebuggerHidden]
		public <PumpStarter>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x6000BC4")]
		[Address(RVA = "0x1F928C8", Offset = "0x1F918C8", VA = "0x1F928C8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000BC5")]
		[Address(RVA = "0x1F928CC", Offset = "0x1F918CC", VA = "0x1F928CC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0x1F9298C", Offset = "0x1F9198C", VA = "0x1F9298C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40005E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static EZAnimator s_Instance;

	[Token(Token = "0x40005E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	protected static Dictionary<EZAnimation.ANIM_TYPE, EZLinkedList<EZAnimation>> freeAnimPool;

	[Token(Token = "0x40005E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected static EZLinkedList<EZAnimation> animations;

	[Token(Token = "0x40005E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected static bool pumpIsRunning;

	[Token(Token = "0x40005E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	protected static bool pumpIsDone;

	[Token(Token = "0x40005EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	protected static float _timeScale;

	[Token(Token = "0x40005EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected static float startTime;

	[Token(Token = "0x40005EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	protected static float time;

	[Token(Token = "0x40005ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected static float elapsed;

	[Token(Token = "0x40005EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected static EZAnimation anim;

	[Token(Token = "0x40005EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected static float timePaused;

	[Token(Token = "0x40005F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int i;

	[Token(Token = "0x1700016C")]
	public static EZAnimator instance
	{
		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x1F87F4C", Offset = "0x1F86F4C", VA = "0x1F87F4C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700016D")]
	public static float timeScale
	{
		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x1F90E30", Offset = "0x1F8FE30", VA = "0x1F90E30")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x1F90E88", Offset = "0x1F8FE88", VA = "0x1F90E88")]
		set
		{
		}
	}

	[Token(Token = "0x6000B9F")]
	[Address(RVA = "0x1F87EC0", Offset = "0x1F86EC0", VA = "0x1F87EC0")]
	public static bool Exists()
	{
		return default(bool);
	}

	[Token(Token = "0x6000BA0")]
	[Address(RVA = "0x1F90DD0", Offset = "0x1F8FDD0", VA = "0x1F90DD0")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6000BA3")]
	[Address(RVA = "0x1F90EF4", Offset = "0x1F8FEF4", VA = "0x1F90EF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000BA4")]
	[Address(RVA = "0x1F91068", Offset = "0x1F90068", VA = "0x1F91068")]
	private void SceneManager_sceneLoaded(Scene arg0, LoadSceneMode arg1)
	{
	}

	[Token(Token = "0x6000BA5")]
	[Address(RVA = "0x1F91338", Offset = "0x1F90338", VA = "0x1F91338")]
	private void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x6000BA6")]
	[Address(RVA = "0x1F913C4", Offset = "0x1F903C4", VA = "0x1F913C4")]
	[IteratorStateMachine(typeof(<AnimPump>d__22))]
	protected static IEnumerator AnimPump()
	{
		return null;
	}

	[Token(Token = "0x6000BA7")]
	[Address(RVA = "0x1F9141C", Offset = "0x1F9041C", VA = "0x1F9141C")]
	public void StartAnimationPump()
	{
	}

	[Token(Token = "0x6000BA8")]
	[Address(RVA = "0x1F914DC", Offset = "0x1F904DC", VA = "0x1F914DC")]
	[IteratorStateMachine(typeof(<PumpStarter>d__24))]
	protected IEnumerator PumpStarter()
	{
		return null;
	}

	[Token(Token = "0x6000BA9")]
	[Address(RVA = "0x1F91544", Offset = "0x1F90544", VA = "0x1F91544")]
	public static void StopAnimationPump()
	{
	}

	[Token(Token = "0x6000BAA")]
	[Address(RVA = "0x1F91548", Offset = "0x1F90548", VA = "0x1F91548")]
	protected EZAnimation CreateNewAnimation(EZAnimation.ANIM_TYPE type)
	{
		return null;
	}

	[Token(Token = "0x6000BAB")]
	[Address(RVA = "0x1F9193C", Offset = "0x1F9093C", VA = "0x1F9193C")]
	public EZAnimation GetAnimation(EZAnimation.ANIM_TYPE type)
	{
		return null;
	}

	[Token(Token = "0x6000BAC")]
	[Address(RVA = "0x1F911D8", Offset = "0x1F901D8", VA = "0x1F911D8")]
	protected static void ReturnAnimToPool(EZAnimation anim)
	{
	}

	[Token(Token = "0x6000BAD")]
	[Address(RVA = "0x1F91A48", Offset = "0x1F90A48", VA = "0x1F91A48")]
	public void AddAnimation(EZAnimation a)
	{
	}

	[Token(Token = "0x6000BAE")]
	[Address(RVA = "0x1F8FC0C", Offset = "0x1F8EC0C", VA = "0x1F8FC0C")]
	public void AddTransition(EZTransition t)
	{
	}

	[Token(Token = "0x6000BAF")]
	[Address(RVA = "0x1F91AE8", Offset = "0x1F90AE8", VA = "0x1F91AE8")]
	public void Cancel(object obj)
	{
	}

	[Token(Token = "0x6000BB0")]
	[Address(RVA = "0x1F91C80", Offset = "0x1F90C80", VA = "0x1F91C80")]
	public void StopAnimation(EZAnimation a)
	{
	}

	[Token(Token = "0x6000BB1")]
	[Address(RVA = "0x1F8FFF8", Offset = "0x1F8EFF8", VA = "0x1F8FFF8")]
	public void StopAnimation(EZAnimation a, bool end)
	{
	}

	[Token(Token = "0x6000BB2")]
	[Address(RVA = "0x1F8812C", Offset = "0x1F8712C", VA = "0x1F8812C")]
	public void Stop(object obj)
	{
	}

	[Token(Token = "0x6000BB3")]
	[Address(RVA = "0x1F91C88", Offset = "0x1F90C88", VA = "0x1F91C88")]
	public void Stop(object obj, bool end)
	{
	}

	[Token(Token = "0x6000BB4")]
	[Address(RVA = "0x1F91E44", Offset = "0x1F90E44", VA = "0x1F91E44")]
	public void Stop(object obj, EZAnimation.ANIM_TYPE type, bool end)
	{
	}

	[Token(Token = "0x6000BB5")]
	[Address(RVA = "0x1F92014", Offset = "0x1F91014", VA = "0x1F92014")]
	public void End(object obj)
	{
	}

	[Token(Token = "0x6000BB6")]
	[Address(RVA = "0x1F9201C", Offset = "0x1F9101C", VA = "0x1F9201C")]
	public void EndAll()
	{
	}

	[Token(Token = "0x6000BB7")]
	[Address(RVA = "0x1F92100", Offset = "0x1F91100", VA = "0x1F92100")]
	public void StopAll()
	{
	}

	[Token(Token = "0x6000BB8")]
	[Address(RVA = "0x1F921E8", Offset = "0x1F911E8", VA = "0x1F921E8")]
	public void PauseAll()
	{
	}

	[Token(Token = "0x6000BB9")]
	[Address(RVA = "0x1F922F8", Offset = "0x1F912F8", VA = "0x1F922F8")]
	public void UnpauseAll()
	{
	}

	[Token(Token = "0x6000BBA")]
	[Address(RVA = "0x1F92408", Offset = "0x1F91408", VA = "0x1F92408")]
	public static int GetNumAnimations()
	{
		return default(int);
	}

	[Token(Token = "0x6000BBB")]
	[Address(RVA = "0x1F92478", Offset = "0x1F91478", VA = "0x1F92478")]
	public EZAnimator()
	{
	}
}
[Token(Token = "0x20000AE")]
public abstract class EZAnimation : IEZLinkedListItem<EZAnimation>
{
	[Token(Token = "0x20000AF")]
	public enum ANIM_TYPE
	{
		[Token(Token = "0x400060B")]
		AnimClip,
		[Token(Token = "0x400060C")]
		FadeSprite,
		[Token(Token = "0x400060D")]
		FadeMaterial,
		[Token(Token = "0x400060E")]
		FadeText,
		[Token(Token = "0x400060F")]
		Translate,
		[Token(Token = "0x4000610")]
		PunchPosition,
		[Token(Token = "0x4000611")]
		Crash,
		[Token(Token = "0x4000612")]
		SmoothCrash,
		[Token(Token = "0x4000613")]
		Shake,
		[Token(Token = "0x4000614")]
		Scale,
		[Token(Token = "0x4000615")]
		PunchScale,
		[Token(Token = "0x4000616")]
		Rotate,
		[Token(Token = "0x4000617")]
		PunchRotation,
		[Token(Token = "0x4000618")]
		ShakeRotation,
		[Token(Token = "0x4000619")]
		CrashRotation,
		[Token(Token = "0x400061A")]
		FadeAudio,
		[Token(Token = "0x400061B")]
		TuneAudio,
		[Token(Token = "0x400061C")]
		TranslateScreen,
		[Token(Token = "0x400061D")]
		FadeSpriteAlpha,
		[Token(Token = "0x400061E")]
		FadeTextAlpha,
		[Token(Token = "0x400061F")]
		RotateEuler
	}

	[Token(Token = "0x20000B0")]
	public enum ANIM_MODE
	{
		[Token(Token = "0x4000621")]
		By,
		[Token(Token = "0x4000622")]
		To,
		[Token(Token = "0x4000623")]
		FromTo
	}

	[Token(Token = "0x20000B1")]
	public delegate void CompletionDelegate(EZAnimation anim);

	[Token(Token = "0x20000B2")]
	public delegate float Interpolator(float time, float start, float delta, float duration);

	[Token(Token = "0x20000B3")]
	public enum EASING_TYPE
	{
		[Token(Token = "0x4000625")]
		Default = -1,
		[Token(Token = "0x4000626")]
		Linear,
		[Token(Token = "0x4000627")]
		BackIn,
		[Token(Token = "0x4000628")]
		BackOut,
		[Token(Token = "0x4000629")]
		BackInOut,
		[Token(Token = "0x400062A")]
		BackOutIn,
		[Token(Token = "0x400062B")]
		BounceIn,
		[Token(Token = "0x400062C")]
		BounceOut,
		[Token(Token = "0x400062D")]
		BounceInOut,
		[Token(Token = "0x400062E")]
		BounceOutIn,
		[Token(Token = "0x400062F")]
		CircularIn,
		[Token(Token = "0x4000630")]
		CircularOut,
		[Token(Token = "0x4000631")]
		CircularInOut,
		[Token(Token = "0x4000632")]
		CircularOutIn,
		[Token(Token = "0x4000633")]
		CubicIn,
		[Token(Token = "0x4000634")]
		CubicOut,
		[Token(Token = "0x4000635")]
		CubicInOut,
		[Token(Token = "0x4000636")]
		CubicOutIn,
		[Token(Token = "0x4000637")]
		ElasticIn,
		[Token(Token = "0x4000638")]
		ElasticOut,
		[Token(Token = "0x4000639")]
		ElasticInOut,
		[Token(Token = "0x400063A")]
		ElasticOutIn,
		[Token(Token = "0x400063B")]
		ExponentialIn,
		[Token(Token = "0x400063C")]
		ExponentialOut,
		[Token(Token = "0x400063D")]
		ExponentialInOut,
		[Token(Token = "0x400063E")]
		ExponentialOutIn,
		[Token(Token = "0x400063F")]
		QuadraticIn,
		[Token(Token = "0x4000640")]
		QuadraticOut,
		[Token(Token = "0x4000641")]
		QuadraticInOut,
		[Token(Token = "0x4000642")]
		QuadraticOutIn,
		[Token(Token = "0x4000643")]
		QuarticIn,
		[Token(Token = "0x4000644")]
		QuarticOut,
		[Token(Token = "0x4000645")]
		QuarticInOut,
		[Token(Token = "0x4000646")]
		QuarticOutIn,
		[Token(Token = "0x4000647")]
		QuinticIn,
		[Token(Token = "0x4000648")]
		QuinticOut,
		[Token(Token = "0x4000649")]
		QuinticInOut,
		[Token(Token = "0x400064A")]
		QuinticOutIn,
		[Token(Token = "0x400064B")]
		SinusoidalIn,
		[Token(Token = "0x400064C")]
		SinusoidalOut,
		[Token(Token = "0x400064D")]
		SinusoidalInOut,
		[Token(Token = "0x400064E")]
		SinusoidalOutIn,
		[Token(Token = "0x400064F")]
		Spring
	}

	[Token(Token = "0x40005F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ANIM_TYPE type;

	[Token(Token = "0x40005F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public bool pingPong;

	[Token(Token = "0x40005F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
	public bool repeatDelay;

	[Token(Token = "0x40005FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
	public bool restartOnRepeat;

	[Token(Token = "0x40005FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
	public bool running;

	[Token(Token = "0x40005FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected bool m_paused;

	[Token(Token = "0x40005FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected object data;

	[Token(Token = "0x40005FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected ANIM_MODE m_mode;

	[Token(Token = "0x40005FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	protected float direction;

	[Token(Token = "0x4000600")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected float timeElapsed;

	[Token(Token = "0x4000601")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	protected float wait;

	[Token(Token = "0x4000602")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected float m_wait;

	[Token(Token = "0x4000603")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	protected float duration;

	[Token(Token = "0x4000604")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected float interval;

	[Token(Token = "0x4000605")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected CompletionDelegate completedDelegate;

	[Token(Token = "0x4000606")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected CompletionDelegate startDelegate;

	[Token(Token = "0x4000607")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected Interpolator interpolator;

	[Token(Token = "0x4000608")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected EZAnimation m_prev;

	[Token(Token = "0x4000609")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected EZAnimation m_next;

	[Token(Token = "0x17000172")]
	public object Data
	{
		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0x1F929CC", Offset = "0x1F919CC", VA = "0x1F929CC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0x1F929D4", Offset = "0x1F919D4", VA = "0x1F929D4")]
		set
		{
		}
	}

	[Token(Token = "0x17000173")]
	public float Duration
	{
		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0x1F929DC", Offset = "0x1F919DC", VA = "0x1F929DC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000174")]
	public float Wait
	{
		[Token(Token = "0x6000BCC")]
		[Address(RVA = "0x1F929E4", Offset = "0x1F919E4", VA = "0x1F929E4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000175")]
	public bool Paused
	{
		[Token(Token = "0x6000BCD")]
		[Address(RVA = "0x1F929EC", Offset = "0x1F919EC", VA = "0x1F929EC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000BCE")]
		[Address(RVA = "0x1F929F4", Offset = "0x1F919F4", VA = "0x1F929F4")]
		set
		{
		}
	}

	[Token(Token = "0x17000176")]
	public ANIM_MODE Mode
	{
		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0x1F92A04", Offset = "0x1F91A04", VA = "0x1F92A04")]
		get
		{
			return default(ANIM_MODE);
		}
	}

	[Token(Token = "0x17000177")]
	public CompletionDelegate CompletedDelegate
	{
		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0x1F92A0C", Offset = "0x1F91A0C", VA = "0x1F92A0C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x1F92A14", Offset = "0x1F91A14", VA = "0x1F92A14")]
		set
		{
		}
	}

	[Token(Token = "0x17000178")]
	public CompletionDelegate StartDelegate
	{
		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x1F92A1C", Offset = "0x1F91A1C", VA = "0x1F92A1C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0x1F92A24", Offset = "0x1F91A24", VA = "0x1F92A24")]
		set
		{
		}
	}

	[Token(Token = "0x17000179")]
	public EZAnimation prev
	{
		[Token(Token = "0x6000C16")]
		[Address(RVA = "0x1F942EC", Offset = "0x1F932EC", VA = "0x1F942EC", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000C17")]
		[Address(RVA = "0x1F942F4", Offset = "0x1F932F4", VA = "0x1F942F4", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x1700017A")]
	public EZAnimation next
	{
		[Token(Token = "0x6000C18")]
		[Address(RVA = "0x1F942FC", Offset = "0x1F932FC", VA = "0x1F942FC", Slot = "6")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000C19")]
		[Address(RVA = "0x1F94304", Offset = "0x1F93304", VA = "0x1F94304", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x6000BD4")]
	[Address(RVA = "0x1F92A2C", Offset = "0x1F91A2C", VA = "0x1F92A2C")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000BD5")]
	public abstract bool Start(GameObject sub, AnimParams parms);

	[Token(Token = "0x6000BD6")]
	protected abstract void DoAnim();

	[Token(Token = "0x6000BD7")]
	[Address(RVA = "0x1F92A38", Offset = "0x1F91A38", VA = "0x1F92A38", Slot = "10")]
	public virtual bool Step(float timeDelta)
	{
		return default(bool);
	}

	[Token(Token = "0x6000BD8")]
	[Address(RVA = "0x1F92BD8", Offset = "0x1F91BD8", VA = "0x1F92BD8", Slot = "11")]
	public virtual void Stop()
	{
	}

	[Token(Token = "0x6000BD9")]
	[Address(RVA = "0x1F92C40", Offset = "0x1F91C40", VA = "0x1F92C40")]
	public void _stop()
	{
	}

	[Token(Token = "0x6000BDA")]
	[Address(RVA = "0x1F92C64", Offset = "0x1F91C64", VA = "0x1F92C64")]
	public void End()
	{
	}

	[Token(Token = "0x6000BDB")]
	[Address(RVA = "0x1F92CD0", Offset = "0x1F91CD0", VA = "0x1F92CD0")]
	public void _cancel()
	{
	}

	[Token(Token = "0x6000BDC")]
	[Address(RVA = "0x1F92CE0", Offset = "0x1F91CE0", VA = "0x1F92CE0", Slot = "12")]
	public virtual void _end()
	{
	}

	[Token(Token = "0x6000BDD")]
	[Address(RVA = "0x1F92D04", Offset = "0x1F91D04", VA = "0x1F92D04", Slot = "13")]
	protected virtual void LoopReset()
	{
	}

	[Token(Token = "0x6000BDE")]
	public abstract object GetSubject();

	[Token(Token = "0x6000BDF")]
	[Address(RVA = "0x1F92D08", Offset = "0x1F91D08", VA = "0x1F92D08", Slot = "15")]
	protected virtual void WaitDone()
	{
	}

	[Token(Token = "0x6000BE0")]
	[Address(RVA = "0x1F92D0C", Offset = "0x1F91D0C", VA = "0x1F92D0C")]
	protected void StartCommon()
	{
	}

	[Token(Token = "0x6000BE1")]
	[Address(RVA = "0x1F92D64", Offset = "0x1F91D64", VA = "0x1F92D64")]
	public void ResetDefaults()
	{
	}

	[Token(Token = "0x6000BE2")]
	[Address(RVA = "0x1F92D7C", Offset = "0x1F91D7C", VA = "0x1F92D7C")]
	public static float linear(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000BE3")]
	[Address(RVA = "0x1F92D8C", Offset = "0x1F91D8C", VA = "0x1F92D8C")]
	public static float quadraticIn(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000BE4")]
	[Address(RVA = "0x1F92DA0", Offset = "0x1F91DA0", VA = "0x1F92DA0")]
	public static float quadraticOut(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000BE5")]
	[Address(RVA = "0x1F92DBC", Offset = "0x1F91DBC", VA = "0x1F92DBC")]
	public static float quadraticInOut(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000BE6")]
	[Address(RVA = "0x1F92E0C", Offset = "0x1F91E0C", VA = "0x1F92E0C")]
	public static float quadraticOutIn(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000BE7")]
	[Address(RVA = "0x1F92E60", Offset = "0x1F91E60", VA = "0x1F92E60")]
	public static float cubicIn(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000BE8")]
	[Address(RVA = "0x1F92E78", Offset = "0x1F91E78", VA = "0x1F92E78")]
	public static float cubicOut(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000BE9")]
	[Address(RVA = "0x1F92EA0", Offset = "0x1F91EA0", VA = "0x1F92EA0")]
	public static float cubicInOut(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000BEA")]
	[Address(RVA = "0x1F92EF4", Offset = "0x1F91EF4", VA = "0x1F92EF4")]
	public static float cubicOutIn(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000BEB")]
	[Address(RVA = "0x1F92F54", Offset = "0x1F91F54", VA = "0x1F92F54")]
	public static float quarticIn(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000BEC")]
	[Address(RVA = "0x1F92F70", Offset = "0x1F91F70", VA = "0x1F92F70")]
	public static float quarticOut(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000BED")]
	[Address(RVA = "0x1F92F98", Offset = "0x1F91F98", VA = "0x1F92F98")]
	public static float quarticInOut(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000BEE")]
	[Address(RVA = "0x1F92FF4", Offset = "0x1F91FF4", VA = "0x1F92FF4")]
	public static float quarticOutIn(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000BEF")]
	[Address(RVA = "0x1F9305C", Offset = "0x1F9205C", VA = "0x1F9305C")]
	public static float quinticIn(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000BF0")]
	[Address(RVA = "0x1F9307C", Offset = "0x1F9207C", VA = "0x1F9307C")]
	public static float quinticOut(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000BF1")]
	[Address(RVA = "0x1F930AC", Offset = "0x1F920AC", VA = "0x1F930AC")]
	public static float quinticInOut(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000BF2")]
	[Address(RVA = "0x1F93110", Offset = "0x1F92110", VA = "0x1F93110")]
	public static float quinticOutIn(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000BF3")]
	[Address(RVA = "0x1F93180", Offset = "0x1F92180", VA = "0x1F93180")]
	public static float sinusIn(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000BF4")]
	[Address(RVA = "0x1F931BC", Offset = "0x1F921BC", VA = "0x1F931BC")]
	public static float sinusOut(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000BF5")]
	[Address(RVA = "0x1F931F4", Offset = "0x1F921F4", VA = "0x1F931F4")]
	public static float sinusInOut(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000BF6")]
	[Address(RVA = "0x1F9323C", Offset = "0x1F9223C", VA = "0x1F9323C")]
	public static float sinusOutIn(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000BF7")]
	[Address(RVA = "0x1F932B8", Offset = "0x1F922B8", VA = "0x1F932B8")]
	public static float expIn(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000BF8")]
	[Address(RVA = "0x1F932F4", Offset = "0x1F922F4", VA = "0x1F932F4")]
	public static float expOut(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000BF9")]
	[Address(RVA = "0x1F93330", Offset = "0x1F92330", VA = "0x1F93330")]
	public static float expInOut(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000BFA")]
	[Address(RVA = "0x1F933A8", Offset = "0x1F923A8", VA = "0x1F933A8")]
	public static float expOutIn(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000BFB")]
	[Address(RVA = "0x1F9342C", Offset = "0x1F9242C", VA = "0x1F9342C")]
	public static float circIn(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000BFC")]
	[Address(RVA = "0x1F93454", Offset = "0x1F92454", VA = "0x1F93454")]
	public static float circOut(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000BFD")]
	[Address(RVA = "0x1F9347C", Offset = "0x1F9247C", VA = "0x1F9347C")]
	public static float circInOut(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000BFE")]
	[Address(RVA = "0x1F934D0", Offset = "0x1F924D0", VA = "0x1F934D0")]
	public static float circOutIn(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000BFF")]
	[Address(RVA = "0x1F93544", Offset = "0x1F92544", VA = "0x1F93544")]
	public static float punch(float amplitude, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000C00")]
	[Address(RVA = "0x1F935B4", Offset = "0x1F925B4", VA = "0x1F935B4")]
	public static float spring(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000C01")]
	[Address(RVA = "0x1F93664", Offset = "0x1F92664", VA = "0x1F93664")]
	public static float elasticIn(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000C02")]
	[Address(RVA = "0x1F93678", Offset = "0x1F92678", VA = "0x1F93678")]
	public static float elasticIn(float time, float start, float delta, float duration, float amplitude, float period)
	{
		return default(float);
	}

	[Token(Token = "0x6000C03")]
	[Address(RVA = "0x1F93758", Offset = "0x1F92758", VA = "0x1F93758")]
	public static float elasticOut(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000C04")]
	[Address(RVA = "0x1F9376C", Offset = "0x1F9276C", VA = "0x1F9376C")]
	public static float elasticOut(float time, float start, float delta, float duration, float amplitude, float period)
	{
		return default(float);
	}

	[Token(Token = "0x6000C05")]
	[Address(RVA = "0x1F93844", Offset = "0x1F92844", VA = "0x1F93844")]
	public static float elasticInOut(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000C06")]
	[Address(RVA = "0x1F93860", Offset = "0x1F92860", VA = "0x1F93860")]
	public static float elasticInOut(float time, float start, float delta, float duration, float amplitude, float period)
	{
		return default(float);
	}

	[Token(Token = "0x6000C07")]
	[Address(RVA = "0x1F939A0", Offset = "0x1F929A0", VA = "0x1F939A0")]
	public static float elasticOutIn(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000C08")]
	[Address(RVA = "0x1F939B4", Offset = "0x1F929B4", VA = "0x1F939B4")]
	public static float elasticOutIn(float time, float start, float delta, float duration, float amplitude, float period)
	{
		return default(float);
	}

	[Token(Token = "0x6000C09")]
	[Address(RVA = "0x1F939E0", Offset = "0x1F929E0", VA = "0x1F939E0")]
	public static float backIn(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000C0A")]
	[Address(RVA = "0x1F93A10", Offset = "0x1F92A10", VA = "0x1F93A10")]
	public static float backIn(float time, float start, float delta, float duration, float overshootAmt)
	{
		return default(float);
	}

	[Token(Token = "0x6000C0B")]
	[Address(RVA = "0x1F93A38", Offset = "0x1F92A38", VA = "0x1F93A38")]
	public static float backOut(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000C0C")]
	[Address(RVA = "0x1F93A78", Offset = "0x1F92A78", VA = "0x1F93A78")]
	public static float backOut(float time, float start, float delta, float duration, float overshootAmt)
	{
		return default(float);
	}

	[Token(Token = "0x6000C0D")]
	[Address(RVA = "0x1F93AAC", Offset = "0x1F92AAC", VA = "0x1F93AAC")]
	public static float backInOut(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000C0E")]
	[Address(RVA = "0x1F93B2C", Offset = "0x1F92B2C", VA = "0x1F93B2C")]
	public static float backInOut(float time, float start, float delta, float duration, float overshootAmt)
	{
		return default(float);
	}

	[Token(Token = "0x6000C0F")]
	[Address(RVA = "0x1F93BAC", Offset = "0x1F92BAC", VA = "0x1F93BAC")]
	public static float backOutIn(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000C10")]
	[Address(RVA = "0x1F93BB8", Offset = "0x1F92BB8", VA = "0x1F93BB8")]
	public static float backOutIn(float time, float start, float delta, float duration, float overshootAmt)
	{
		return default(float);
	}

	[Token(Token = "0x6000C11")]
	[Address(RVA = "0x1F93C34", Offset = "0x1F92C34", VA = "0x1F93C34")]
	public static float bounceIn(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000C12")]
	[Address(RVA = "0x1F93C64", Offset = "0x1F92C64", VA = "0x1F93C64")]
	public static float bounceOut(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000C13")]
	[Address(RVA = "0x1F93D28", Offset = "0x1F92D28", VA = "0x1F93D28")]
	public static float bounceInOut(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000C14")]
	[Address(RVA = "0x1F93DA4", Offset = "0x1F92DA4", VA = "0x1F93DA4")]
	public static float bounceOutIn(float time, float start, float delta, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000C15")]
	[Address(RVA = "0x1F93DF8", Offset = "0x1F92DF8", VA = "0x1F93DF8")]
	public static Interpolator GetInterpolator(EASING_TYPE type)
	{
		return null;
	}

	[Token(Token = "0x6000C1A")]
	[Address(RVA = "0x1F9430C", Offset = "0x1F9330C", VA = "0x1F9430C")]
	protected EZAnimation()
	{
	}
}
[Token(Token = "0x20000B4")]
public class FadeSprite : EZAnimation
{
	[Token(Token = "0x4000650")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected Color start;

	[Token(Token = "0x4000651")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected Color delta;

	[Token(Token = "0x4000652")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected Color end;

	[Token(Token = "0x4000653")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected SpriteRoot sprite;

	[Token(Token = "0x4000654")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected Color temp;

	[Token(Token = "0x6000C23")]
	[Address(RVA = "0x1F9456C", Offset = "0x1F9356C", VA = "0x1F9456C", Slot = "14")]
	public override object GetSubject()
	{
		return null;
	}

	[Token(Token = "0x6000C24")]
	[Address(RVA = "0x1F94574", Offset = "0x1F93574", VA = "0x1F94574", Slot = "12")]
	public override void _end()
	{
	}

	[Token(Token = "0x6000C25")]
	[Address(RVA = "0x1F94628", Offset = "0x1F93628", VA = "0x1F94628", Slot = "13")]
	protected override void LoopReset()
	{
	}

	[Token(Token = "0x6000C26")]
	[Address(RVA = "0x1F94654", Offset = "0x1F93654", VA = "0x1F94654", Slot = "15")]
	protected override void WaitDone()
	{
	}

	[Token(Token = "0x6000C27")]
	[Address(RVA = "0x1F946EC", Offset = "0x1F936EC", VA = "0x1F946EC", Slot = "9")]
	protected override void DoAnim()
	{
	}

	[Token(Token = "0x6000C28")]
	[Address(RVA = "0x1F9485C", Offset = "0x1F9385C", VA = "0x1F9485C")]
	public static FadeSprite Do(SpriteRoot sprt, ANIM_MODE mode, Color begin, Color dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000C29")]
	[Address(RVA = "0x1F94B44", Offset = "0x1F93B44", VA = "0x1F94B44")]
	public static FadeSprite Do(SpriteRoot sprt, ANIM_MODE mode, Color dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000C2A")]
	[Address(RVA = "0x1F94CD8", Offset = "0x1F93CD8", VA = "0x1F94CD8", Slot = "8")]
	public override bool Start(GameObject sub, AnimParams parms)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C2B")]
	[Address(RVA = "0x1F94C88", Offset = "0x1F93C88", VA = "0x1F94C88")]
	public void Start(SpriteRoot sprt, ANIM_MODE mode, Color dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000C2C")]
	[Address(RVA = "0x1F949D0", Offset = "0x1F939D0", VA = "0x1F949D0")]
	public void Start(SpriteRoot sprt, ANIM_MODE mode, Color begin, Color dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000C2D")]
	[Address(RVA = "0x1F95004", Offset = "0x1F94004", VA = "0x1F95004")]
	public void Start()
	{
	}

	[Token(Token = "0x6000C2E")]
	[Address(RVA = "0x1F950F0", Offset = "0x1F940F0", VA = "0x1F950F0")]
	public FadeSprite()
	{
	}
}
[Token(Token = "0x20000B5")]
public class FadeSpriteAlpha : EZAnimation
{
	[Token(Token = "0x4000655")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected Color start;

	[Token(Token = "0x4000656")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected Color delta;

	[Token(Token = "0x4000657")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected Color end;

	[Token(Token = "0x4000658")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected SpriteRoot sprite;

	[Token(Token = "0x4000659")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected Color temp;

	[Token(Token = "0x6000C2F")]
	[Address(RVA = "0x1F95124", Offset = "0x1F94124", VA = "0x1F95124", Slot = "14")]
	public override object GetSubject()
	{
		return null;
	}

	[Token(Token = "0x6000C30")]
	[Address(RVA = "0x1F9512C", Offset = "0x1F9412C", VA = "0x1F9512C", Slot = "12")]
	public override void _end()
	{
	}

	[Token(Token = "0x6000C31")]
	[Address(RVA = "0x1F951E0", Offset = "0x1F941E0", VA = "0x1F951E0", Slot = "13")]
	protected override void LoopReset()
	{
	}

	[Token(Token = "0x6000C32")]
	[Address(RVA = "0x1F9520C", Offset = "0x1F9420C", VA = "0x1F9520C", Slot = "15")]
	protected override void WaitDone()
	{
	}

	[Token(Token = "0x6000C33")]
	[Address(RVA = "0x1F952AC", Offset = "0x1F942AC", VA = "0x1F952AC", Slot = "9")]
	protected override void DoAnim()
	{
	}

	[Token(Token = "0x6000C34")]
	[Address(RVA = "0x1F95398", Offset = "0x1F94398", VA = "0x1F95398")]
	public static FadeSpriteAlpha Do(SpriteRoot sprt, ANIM_MODE mode, Color begin, Color dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000C35")]
	[Address(RVA = "0x1F95658", Offset = "0x1F94658", VA = "0x1F95658")]
	public static FadeSpriteAlpha Do(SpriteRoot sprt, ANIM_MODE mode, Color dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000C36")]
	[Address(RVA = "0x1F957EC", Offset = "0x1F947EC", VA = "0x1F957EC", Slot = "8")]
	public override bool Start(GameObject sub, AnimParams parms)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C37")]
	[Address(RVA = "0x1F9579C", Offset = "0x1F9479C", VA = "0x1F9579C")]
	public void Start(SpriteRoot sprt, ANIM_MODE mode, Color dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000C38")]
	[Address(RVA = "0x1F9550C", Offset = "0x1F9450C", VA = "0x1F9550C")]
	public void Start(SpriteRoot sprt, ANIM_MODE mode, Color begin, Color dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000C39")]
	[Address(RVA = "0x1F95B18", Offset = "0x1F94B18", VA = "0x1F95B18")]
	public void Start()
	{
	}

	[Token(Token = "0x6000C3A")]
	[Address(RVA = "0x1F95C04", Offset = "0x1F94C04", VA = "0x1F95C04")]
	public FadeSpriteAlpha()
	{
	}
}
[Token(Token = "0x20000B6")]
public class FadeMaterial : EZAnimation
{
	[Token(Token = "0x400065A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected Color start;

	[Token(Token = "0x400065B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected Color delta;

	[Token(Token = "0x400065C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected Color end;

	[Token(Token = "0x400065D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected Material mat;

	[Token(Token = "0x400065E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected Color temp;

	[Token(Token = "0x6000C3B")]
	[Address(RVA = "0x1F95C34", Offset = "0x1F94C34", VA = "0x1F95C34", Slot = "14")]
	public override object GetSubject()
	{
		return null;
	}

	[Token(Token = "0x6000C3C")]
	[Address(RVA = "0x1F95C3C", Offset = "0x1F94C3C", VA = "0x1F95C3C", Slot = "12")]
	public override void _end()
	{
	}

	[Token(Token = "0x6000C3D")]
	[Address(RVA = "0x1F95CE8", Offset = "0x1F94CE8", VA = "0x1F95CE8", Slot = "13")]
	protected override void LoopReset()
	{
	}

	[Token(Token = "0x6000C3E")]
	[Address(RVA = "0x1F95D14", Offset = "0x1F94D14", VA = "0x1F95D14", Slot = "15")]
	protected override void WaitDone()
	{
	}

	[Token(Token = "0x6000C3F")]
	[Address(RVA = "0x1F95DBC", Offset = "0x1F94DBC", VA = "0x1F95DBC", Slot = "9")]
	protected override void DoAnim()
	{
	}

	[Token(Token = "0x6000C40")]
	[Address(RVA = "0x1F95F24", Offset = "0x1F94F24", VA = "0x1F95F24")]
	public static FadeMaterial Do(Material material, ANIM_MODE mode, Color begin, Color dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000C41")]
	[Address(RVA = "0x1F96204", Offset = "0x1F95204", VA = "0x1F96204")]
	public static FadeMaterial Do(Material material, ANIM_MODE mode, Color dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000C42")]
	[Address(RVA = "0x1F96404", Offset = "0x1F95404", VA = "0x1F96404", Slot = "8")]
	public override bool Start(GameObject sub, AnimParams parms)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C43")]
	[Address(RVA = "0x1F96348", Offset = "0x1F95348", VA = "0x1F96348")]
	public void Start(Material material, ANIM_MODE mode, Color dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000C44")]
	[Address(RVA = "0x1F96098", Offset = "0x1F95098", VA = "0x1F96098")]
	public void Start(Material material, ANIM_MODE mode, Color begin, Color dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000C45")]
	[Address(RVA = "0x1F966F0", Offset = "0x1F956F0", VA = "0x1F966F0")]
	public void Start()
	{
	}

	[Token(Token = "0x6000C46")]
	[Address(RVA = "0x1F967EC", Offset = "0x1F957EC", VA = "0x1F967EC")]
	public FadeMaterial()
	{
	}
}
[Token(Token = "0x20000B7")]
public class FadeText : EZAnimation
{
	[Token(Token = "0x400065F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected Color start;

	[Token(Token = "0x4000660")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected Color delta;

	[Token(Token = "0x4000661")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected Color end;

	[Token(Token = "0x4000662")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected SpriteText text;

	[Token(Token = "0x4000663")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected Color temp;

	[Token(Token = "0x6000C47")]
	[Address(RVA = "0x1F9681C", Offset = "0x1F9581C", VA = "0x1F9681C", Slot = "14")]
	public override object GetSubject()
	{
		return null;
	}

	[Token(Token = "0x6000C48")]
	[Address(RVA = "0x1F96824", Offset = "0x1F95824", VA = "0x1F96824", Slot = "12")]
	public override void _end()
	{
	}

	[Token(Token = "0x6000C49")]
	[Address(RVA = "0x1F968D0", Offset = "0x1F958D0", VA = "0x1F968D0", Slot = "13")]
	protected override void LoopReset()
	{
	}

	[Token(Token = "0x6000C4A")]
	[Address(RVA = "0x1F968FC", Offset = "0x1F958FC", VA = "0x1F968FC", Slot = "15")]
	protected override void WaitDone()
	{
	}

	[Token(Token = "0x6000C4B")]
	[Address(RVA = "0x1F96990", Offset = "0x1F95990", VA = "0x1F96990", Slot = "9")]
	protected override void DoAnim()
	{
	}

	[Token(Token = "0x6000C4C")]
	[Address(RVA = "0x1F96AF8", Offset = "0x1F95AF8", VA = "0x1F96AF8")]
	public static FadeText Do(SpriteText txt, ANIM_MODE mode, Color begin, Color dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000C4D")]
	[Address(RVA = "0x1F96DD8", Offset = "0x1F95DD8", VA = "0x1F96DD8")]
	public static FadeText Do(SpriteText txt, ANIM_MODE mode, Color dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000C4E")]
	[Address(RVA = "0x1F96F64", Offset = "0x1F95F64", VA = "0x1F96F64", Slot = "8")]
	public override bool Start(GameObject sub, AnimParams parms)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C4F")]
	[Address(RVA = "0x1F96F1C", Offset = "0x1F95F1C", VA = "0x1F96F1C")]
	public void Start(SpriteText txt, ANIM_MODE mode, Color dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000C50")]
	[Address(RVA = "0x1F96C6C", Offset = "0x1F95C6C", VA = "0x1F96C6C")]
	public void Start(SpriteText txt, ANIM_MODE mode, Color begin, Color dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000C51")]
	[Address(RVA = "0x1F9728C", Offset = "0x1F9628C", VA = "0x1F9728C")]
	public FadeText()
	{
	}
}
[Token(Token = "0x20000B8")]
public class FadeTextAlpha : EZAnimation
{
	[Token(Token = "0x4000664")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected Color start;

	[Token(Token = "0x4000665")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected Color delta;

	[Token(Token = "0x4000666")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected Color end;

	[Token(Token = "0x4000667")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected SpriteText text;

	[Token(Token = "0x4000668")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected Color temp;

	[Token(Token = "0x6000C52")]
	[Address(RVA = "0x1F972BC", Offset = "0x1F962BC", VA = "0x1F972BC", Slot = "14")]
	public override object GetSubject()
	{
		return null;
	}

	[Token(Token = "0x6000C53")]
	[Address(RVA = "0x1F972C4", Offset = "0x1F962C4", VA = "0x1F972C4", Slot = "12")]
	public override void _end()
	{
	}

	[Token(Token = "0x6000C54")]
	[Address(RVA = "0x1F97370", Offset = "0x1F96370", VA = "0x1F97370", Slot = "13")]
	protected override void LoopReset()
	{
	}

	[Token(Token = "0x6000C55")]
	[Address(RVA = "0x1F9739C", Offset = "0x1F9639C", VA = "0x1F9739C", Slot = "15")]
	protected override void WaitDone()
	{
	}

	[Token(Token = "0x6000C56")]
	[Address(RVA = "0x1F97438", Offset = "0x1F96438", VA = "0x1F97438", Slot = "9")]
	protected override void DoAnim()
	{
	}

	[Token(Token = "0x6000C57")]
	[Address(RVA = "0x1F9751C", Offset = "0x1F9651C", VA = "0x1F9751C")]
	public static FadeTextAlpha Do(SpriteText txt, ANIM_MODE mode, Color begin, Color dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000C58")]
	[Address(RVA = "0x1F977D0", Offset = "0x1F967D0", VA = "0x1F977D0")]
	public static FadeTextAlpha Do(SpriteText txt, ANIM_MODE mode, Color dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000C59")]
	[Address(RVA = "0x1F9795C", Offset = "0x1F9695C", VA = "0x1F9795C", Slot = "8")]
	public override bool Start(GameObject sub, AnimParams parms)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C5A")]
	[Address(RVA = "0x1F97914", Offset = "0x1F96914", VA = "0x1F97914")]
	public void Start(SpriteText txt, ANIM_MODE mode, Color dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000C5B")]
	[Address(RVA = "0x1F97690", Offset = "0x1F96690", VA = "0x1F97690")]
	public void Start(SpriteText txt, ANIM_MODE mode, Color begin, Color dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000C5C")]
	[Address(RVA = "0x1F97C84", Offset = "0x1F96C84", VA = "0x1F97C84")]
	public FadeTextAlpha()
	{
	}
}
[Token(Token = "0x20000B9")]
public class AnimateRotation : EZAnimation
{
	[Token(Token = "0x4000669")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected GameObject subject;

	[Token(Token = "0x400066A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected Transform subTrans;

	[Token(Token = "0x400066B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected Quaternion temp;

	[Token(Token = "0x400066C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected Quaternion delta;

	[Token(Token = "0x400066D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected Quaternion start;

	[Token(Token = "0x400066E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected Quaternion end;

	[Token(Token = "0x6000C5D")]
	[Address(RVA = "0x1F97CB4", Offset = "0x1F96CB4", VA = "0x1F97CB4", Slot = "14")]
	public override object GetSubject()
	{
		return null;
	}

	[Token(Token = "0x6000C5E")]
	[Address(RVA = "0x1F97CBC", Offset = "0x1F96CBC", VA = "0x1F97CBC", Slot = "12")]
	public override void _end()
	{
	}

	[Token(Token = "0x6000C5F")]
	[Address(RVA = "0x1F97D94", Offset = "0x1F96D94", VA = "0x1F97D94", Slot = "13")]
	protected override void LoopReset()
	{
	}

	[Token(Token = "0x6000C60")]
	[Address(RVA = "0x1F97DC0", Offset = "0x1F96DC0", VA = "0x1F97DC0", Slot = "15")]
	protected override void WaitDone()
	{
	}

	[Token(Token = "0x6000C61")]
	[Address(RVA = "0x1F97E68", Offset = "0x1F96E68", VA = "0x1F97E68", Slot = "9")]
	protected override void DoAnim()
	{
	}

	[Token(Token = "0x6000C62")]
	[Address(RVA = "0x1F97FFC", Offset = "0x1F96FFC", VA = "0x1F97FFC")]
	public static AnimateRotation Do(GameObject sub, ANIM_MODE mode, Vector3 begin, Vector3 dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000C63")]
	[Address(RVA = "0x1F98318", Offset = "0x1F97318", VA = "0x1F98318")]
	public static AnimateRotation Do(GameObject sub, ANIM_MODE mode, Vector3 dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000C64")]
	[Address(RVA = "0x1F98580", Offset = "0x1F97580", VA = "0x1F98580", Slot = "8")]
	public override bool Start(GameObject sub, AnimParams parms)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C65")]
	[Address(RVA = "0x1F98454", Offset = "0x1F97454", VA = "0x1F98454")]
	public void Start(GameObject sub, ANIM_MODE mode, Vector3 dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000C66")]
	[Address(RVA = "0x1F98158", Offset = "0x1F97158", VA = "0x1F98158")]
	public void Start(GameObject sub, ANIM_MODE mode, Vector3 begin, Vector3 dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000C67")]
	[Address(RVA = "0x1F987A0", Offset = "0x1F977A0", VA = "0x1F987A0")]
	public void Start()
	{
	}

	[Token(Token = "0x6000C68")]
	[Address(RVA = "0x1F988A8", Offset = "0x1F978A8", VA = "0x1F988A8")]
	public AnimateRotation()
	{
	}
}
[Token(Token = "0x20000BA")]
public class AnimateRotationEuler : EZAnimation
{
	[Token(Token = "0x400066F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected GameObject subject;

	[Token(Token = "0x4000670")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected Transform subTrans;

	[Token(Token = "0x4000671")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected Vector3 start;

	[Token(Token = "0x4000672")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	protected Vector3 delta;

	[Token(Token = "0x4000673")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected Vector3 end;

	[Token(Token = "0x4000674")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	protected Vector3 temp;

	[Token(Token = "0x6000C69")]
	[Address(RVA = "0x1F988D8", Offset = "0x1F978D8", VA = "0x1F988D8", Slot = "14")]
	public override object GetSubject()
	{
		return null;
	}

	[Token(Token = "0x6000C6A")]
	[Address(RVA = "0x1F988E0", Offset = "0x1F978E0", VA = "0x1F988E0", Slot = "12")]
	public override void _end()
	{
	}

	[Token(Token = "0x6000C6B")]
	[Address(RVA = "0x1F989B8", Offset = "0x1F979B8", VA = "0x1F989B8", Slot = "13")]
	protected override void LoopReset()
	{
	}

	[Token(Token = "0x6000C6C")]
	[Address(RVA = "0x1F98A00", Offset = "0x1F97A00", VA = "0x1F98A00", Slot = "15")]
	protected override void WaitDone()
	{
	}

	[Token(Token = "0x6000C6D")]
	[Address(RVA = "0x1F98AAC", Offset = "0x1F97AAC", VA = "0x1F98AAC", Slot = "9")]
	protected override void DoAnim()
	{
	}

	[Token(Token = "0x6000C6E")]
	[Address(RVA = "0x1F98C10", Offset = "0x1F97C10", VA = "0x1F98C10")]
	public static AnimateRotationEuler Do(GameObject sub, ANIM_MODE mode, Vector3 begin, Vector3 dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000C6F")]
	[Address(RVA = "0x1F98ECC", Offset = "0x1F97ECC", VA = "0x1F98ECC")]
	public static AnimateRotationEuler Do(GameObject sub, ANIM_MODE mode, Vector3 dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000C70")]
	[Address(RVA = "0x1F99134", Offset = "0x1F98134", VA = "0x1F99134", Slot = "8")]
	public override bool Start(GameObject sub, AnimParams parms)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C71")]
	[Address(RVA = "0x1F99008", Offset = "0x1F98008", VA = "0x1F99008")]
	public void Start(GameObject sub, ANIM_MODE mode, Vector3 dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000C72")]
	[Address(RVA = "0x1F98D6C", Offset = "0x1F97D6C", VA = "0x1F98D6C")]
	public void Start(GameObject sub, ANIM_MODE mode, Vector3 begin, Vector3 dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000C73")]
	[Address(RVA = "0x1F99354", Offset = "0x1F98354", VA = "0x1F99354")]
	public void Start()
	{
	}

	[Token(Token = "0x6000C74")]
	[Address(RVA = "0x1F99460", Offset = "0x1F98460", VA = "0x1F99460")]
	public AnimateRotationEuler()
	{
	}
}
[Token(Token = "0x20000BB")]
public class AnimatePosition : EZAnimation
{
	[Token(Token = "0x4000675")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected Vector3 start;

	[Token(Token = "0x4000676")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	protected Vector3 delta;

	[Token(Token = "0x4000677")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected Vector3 end;

	[Token(Token = "0x4000678")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected GameObject subject;

	[Token(Token = "0x4000679")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected Transform subTrans;

	[Token(Token = "0x400067A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected Vector3 temp;

	[Token(Token = "0x6000C75")]
	[Address(RVA = "0x1F99490", Offset = "0x1F98490", VA = "0x1F99490", Slot = "14")]
	public override object GetSubject()
	{
		return null;
	}

	[Token(Token = "0x6000C76")]
	[Address(RVA = "0x1F99498", Offset = "0x1F98498", VA = "0x1F99498", Slot = "12")]
	public override void _end()
	{
	}

	[Token(Token = "0x6000C77")]
	[Address(RVA = "0x1F99570", Offset = "0x1F98570", VA = "0x1F99570", Slot = "13")]
	protected override void LoopReset()
	{
	}

	[Token(Token = "0x6000C78")]
	[Address(RVA = "0x1F995B8", Offset = "0x1F985B8", VA = "0x1F995B8", Slot = "15")]
	protected override void WaitDone()
	{
	}

	[Token(Token = "0x6000C79")]
	[Address(RVA = "0x1F99664", Offset = "0x1F98664", VA = "0x1F99664", Slot = "9")]
	protected override void DoAnim()
	{
	}

	[Token(Token = "0x6000C7A")]
	[Address(RVA = "0x1F997C8", Offset = "0x1F987C8", VA = "0x1F997C8")]
	public static AnimatePosition Do(GameObject sub, ANIM_MODE mode, Vector3 begin, Vector3 dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000C7B")]
	[Address(RVA = "0x1F99A84", Offset = "0x1F98A84", VA = "0x1F99A84")]
	public static AnimatePosition Do(GameObject sub, ANIM_MODE mode, Vector3 dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000C7C")]
	[Address(RVA = "0x1F99CEC", Offset = "0x1F98CEC", VA = "0x1F99CEC", Slot = "8")]
	public override bool Start(GameObject sub, AnimParams parms)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C7D")]
	[Address(RVA = "0x1F99BC0", Offset = "0x1F98BC0", VA = "0x1F99BC0")]
	public void Start(GameObject sub, ANIM_MODE mode, Vector3 dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000C7E")]
	[Address(RVA = "0x1F99924", Offset = "0x1F98924", VA = "0x1F99924")]
	public void Start(GameObject sub, ANIM_MODE mode, Vector3 begin, Vector3 dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000C7F")]
	[Address(RVA = "0x1F99F0C", Offset = "0x1F98F0C", VA = "0x1F99F0C")]
	public void Start()
	{
	}

	[Token(Token = "0x6000C80")]
	[Address(RVA = "0x1F9A018", Offset = "0x1F99018", VA = "0x1F9A018")]
	public AnimatePosition()
	{
	}
}
[Token(Token = "0x20000BC")]
public class AnimateScreenPosition : EZAnimation
{
	[Token(Token = "0x400067B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected Vector3 start;

	[Token(Token = "0x400067C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	protected Vector3 delta;

	[Token(Token = "0x400067D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected Vector3 end;

	[Token(Token = "0x400067E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected GameObject subject;

	[Token(Token = "0x400067F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected EZScreenPlacement subSP;

	[Token(Token = "0x4000680")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected Vector3 temp;

	[Token(Token = "0x6000C81")]
	[Address(RVA = "0x1F9A048", Offset = "0x1F99048", VA = "0x1F9A048", Slot = "14")]
	public override object GetSubject()
	{
		return null;
	}

	[Token(Token = "0x6000C82")]
	[Address(RVA = "0x1F9A050", Offset = "0x1F99050", VA = "0x1F9A050", Slot = "12")]
	public override void _end()
	{
	}

	[Token(Token = "0x6000C83")]
	[Address(RVA = "0x1F9A164", Offset = "0x1F99164", VA = "0x1F9A164", Slot = "13")]
	protected override void LoopReset()
	{
	}

	[Token(Token = "0x6000C84")]
	[Address(RVA = "0x1F9A1AC", Offset = "0x1F991AC", VA = "0x1F9A1AC", Slot = "15")]
	protected override void WaitDone()
	{
	}

	[Token(Token = "0x6000C85")]
	[Address(RVA = "0x1F9A25C", Offset = "0x1F9925C", VA = "0x1F9A25C", Slot = "9")]
	protected override void DoAnim()
	{
	}

	[Token(Token = "0x6000C86")]
	[Address(RVA = "0x1F9A3E8", Offset = "0x1F993E8", VA = "0x1F9A3E8")]
	public static AnimateScreenPosition Do(GameObject sub, ANIM_MODE mode, Vector3 begin, Vector3 dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000C87")]
	[Address(RVA = "0x1F9A878", Offset = "0x1F99878", VA = "0x1F9A878")]
	public static AnimateScreenPosition Do(GameObject sub, ANIM_MODE mode, Vector3 dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000C88")]
	[Address(RVA = "0x1F9AC2C", Offset = "0x1F99C2C", VA = "0x1F9AC2C", Slot = "8")]
	public override bool Start(GameObject sub, AnimParams parms)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C89")]
	[Address(RVA = "0x1F9A9B4", Offset = "0x1F999B4", VA = "0x1F9A9B4")]
	public void Start(GameObject sub, ANIM_MODE mode, Vector3 dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000C8A")]
	[Address(RVA = "0x1F9A544", Offset = "0x1F99544", VA = "0x1F9A544")]
	public void Start(GameObject sub, ANIM_MODE mode, Vector3 begin, Vector3 dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000C8B")]
	[Address(RVA = "0x1F9AF6C", Offset = "0x1F99F6C", VA = "0x1F9AF6C")]
	public void Start()
	{
	}

	[Token(Token = "0x6000C8C")]
	[Address(RVA = "0x1F9B078", Offset = "0x1F9A078", VA = "0x1F9B078")]
	public AnimateScreenPosition()
	{
	}
}
[Token(Token = "0x20000BD")]
public class AnimateScale : EZAnimation
{
	[Token(Token = "0x4000681")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected Vector3 start;

	[Token(Token = "0x4000682")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	protected Vector3 delta;

	[Token(Token = "0x4000683")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected Vector3 end;

	[Token(Token = "0x4000684")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected GameObject subject;

	[Token(Token = "0x4000685")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected Transform subTrans;

	[Token(Token = "0x4000686")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected Vector3 temp;

	[Token(Token = "0x6000C8D")]
	[Address(RVA = "0x1F9B0A8", Offset = "0x1F9A0A8", VA = "0x1F9B0A8", Slot = "14")]
	public override object GetSubject()
	{
		return null;
	}

	[Token(Token = "0x6000C8E")]
	[Address(RVA = "0x1F9B0B0", Offset = "0x1F9A0B0", VA = "0x1F9B0B0", Slot = "12")]
	public override void _end()
	{
	}

	[Token(Token = "0x6000C8F")]
	[Address(RVA = "0x1F9B188", Offset = "0x1F9A188", VA = "0x1F9B188", Slot = "13")]
	protected override void LoopReset()
	{
	}

	[Token(Token = "0x6000C90")]
	[Address(RVA = "0x1F9B1D0", Offset = "0x1F9A1D0", VA = "0x1F9B1D0", Slot = "15")]
	protected override void WaitDone()
	{
	}

	[Token(Token = "0x6000C91")]
	[Address(RVA = "0x1F9B27C", Offset = "0x1F9A27C", VA = "0x1F9B27C", Slot = "9")]
	protected override void DoAnim()
	{
	}

	[Token(Token = "0x6000C92")]
	[Address(RVA = "0x1F9B3E0", Offset = "0x1F9A3E0", VA = "0x1F9B3E0")]
	public static AnimateScale Do(GameObject sub, ANIM_MODE mode, Vector3 begin, Vector3 dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000C93")]
	[Address(RVA = "0x1F9B6A8", Offset = "0x1F9A6A8", VA = "0x1F9B6A8")]
	public static AnimateScale Do(GameObject sub, ANIM_MODE mode, Vector3 dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000C94")]
	[Address(RVA = "0x1F9B910", Offset = "0x1F9A910", VA = "0x1F9B910", Slot = "8")]
	public override bool Start(GameObject sub, AnimParams parms)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C95")]
	[Address(RVA = "0x1F9B7E4", Offset = "0x1F9A7E4", VA = "0x1F9B7E4")]
	public void Start(GameObject sub, ANIM_MODE mode, Vector3 dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000C96")]
	[Address(RVA = "0x1F9B53C", Offset = "0x1F9A53C", VA = "0x1F9B53C")]
	public void Start(GameObject sub, ANIM_MODE mode, Vector3 begin, Vector3 dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000C97")]
	[Address(RVA = "0x1F9BB30", Offset = "0x1F9AB30", VA = "0x1F9BB30")]
	public void Start()
	{
	}

	[Token(Token = "0x6000C98")]
	[Address(RVA = "0x1F9BC3C", Offset = "0x1F9AC3C", VA = "0x1F9BC3C")]
	public AnimateScale()
	{
	}
}
[Token(Token = "0x20000BE")]
public class PunchPosition : EZAnimation
{
	[Token(Token = "0x4000687")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected Vector3 start;

	[Token(Token = "0x4000688")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	protected Vector3 magnitude;

	[Token(Token = "0x4000689")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected GameObject subject;

	[Token(Token = "0x400068A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected Transform subTrans;

	[Token(Token = "0x400068B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected Vector3 temp;

	[Token(Token = "0x400068C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	protected float factor;

	[Token(Token = "0x6000C99")]
	[Address(RVA = "0x1F9BC6C", Offset = "0x1F9AC6C", VA = "0x1F9BC6C", Slot = "14")]
	public override object GetSubject()
	{
		return null;
	}

	[Token(Token = "0x6000C9A")]
	[Address(RVA = "0x1F9BC74", Offset = "0x1F9AC74", VA = "0x1F9BC74", Slot = "12")]
	public override void _end()
	{
	}

	[Token(Token = "0x6000C9B")]
	[Address(RVA = "0x1F9BD4C", Offset = "0x1F9AD4C", VA = "0x1F9BD4C", Slot = "15")]
	protected override void WaitDone()
	{
	}

	[Token(Token = "0x6000C9C")]
	[Address(RVA = "0x1F9BDD0", Offset = "0x1F9ADD0", VA = "0x1F9BDD0", Slot = "9")]
	protected override void DoAnim()
	{
	}

	[Token(Token = "0x6000C9D")]
	[Address(RVA = "0x1F9BF70", Offset = "0x1F9AF70", VA = "0x1F9BF70")]
	public static PunchPosition Do(GameObject sub, Vector3 mag, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000C9E")]
	[Address(RVA = "0x1F9C1A4", Offset = "0x1F9B1A4", VA = "0x1F9C1A4", Slot = "8")]
	public override bool Start(GameObject sub, AnimParams parms)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C9F")]
	[Address(RVA = "0x1F9C094", Offset = "0x1F9B094", VA = "0x1F9C094")]
	public void Start(GameObject sub, Vector3 mag, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000CA0")]
	[Address(RVA = "0x1F9C310", Offset = "0x1F9B310", VA = "0x1F9C310")]
	public void Start(GameObject sub, Vector3 begin, Vector3 mag, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000CA1")]
	[Address(RVA = "0x1F9C494", Offset = "0x1F9B494", VA = "0x1F9C494")]
	public PunchPosition()
	{
	}
}
[Token(Token = "0x20000BF")]
public class PunchScale : EZAnimation
{
	[Token(Token = "0x400068D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected Vector3 start;

	[Token(Token = "0x400068E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	protected Vector3 magnitude;

	[Token(Token = "0x400068F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected GameObject subject;

	[Token(Token = "0x4000690")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected Transform subTrans;

	[Token(Token = "0x4000691")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected Vector3 temp;

	[Token(Token = "0x4000692")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	protected float factor;

	[Token(Token = "0x6000CA2")]
	[Address(RVA = "0x1F9C4C4", Offset = "0x1F9B4C4", VA = "0x1F9C4C4", Slot = "14")]
	public override object GetSubject()
	{
		return null;
	}

	[Token(Token = "0x6000CA3")]
	[Address(RVA = "0x1F9C4CC", Offset = "0x1F9B4CC", VA = "0x1F9C4CC", Slot = "12")]
	public override void _end()
	{
	}

	[Token(Token = "0x6000CA4")]
	[Address(RVA = "0x1F9C5A4", Offset = "0x1F9B5A4", VA = "0x1F9C5A4", Slot = "15")]
	protected override void WaitDone()
	{
	}

	[Token(Token = "0x6000CA5")]
	[Address(RVA = "0x1F9C628", Offset = "0x1F9B628", VA = "0x1F9C628", Slot = "9")]
	protected override void DoAnim()
	{
	}

	[Token(Token = "0x6000CA6")]
	[Address(RVA = "0x1F9C7C8", Offset = "0x1F9B7C8", VA = "0x1F9C7C8")]
	public static PunchScale Do(GameObject sub, Vector3 mag, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000CA7")]
	[Address(RVA = "0x1F9C9FC", Offset = "0x1F9B9FC", VA = "0x1F9C9FC", Slot = "8")]
	public override bool Start(GameObject sub, AnimParams parms)
	{
		return default(bool);
	}

	[Token(Token = "0x6000CA8")]
	[Address(RVA = "0x1F9C8EC", Offset = "0x1F9B8EC", VA = "0x1F9C8EC")]
	public void Start(GameObject sub, Vector3 mag, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000CA9")]
	[Address(RVA = "0x1F9CB68", Offset = "0x1F9BB68", VA = "0x1F9CB68")]
	public void Start(GameObject sub, Vector3 begin, Vector3 mag, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000CAA")]
	[Address(RVA = "0x1F9CCEC", Offset = "0x1F9BCEC", VA = "0x1F9CCEC")]
	public PunchScale()
	{
	}
}
[Token(Token = "0x20000C0")]
public class PunchRotation : EZAnimation
{
	[Token(Token = "0x4000693")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected Vector3 start;

	[Token(Token = "0x4000694")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	protected Vector3 magnitude;

	[Token(Token = "0x4000695")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected GameObject subject;

	[Token(Token = "0x4000696")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected Transform subTrans;

	[Token(Token = "0x4000697")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected Vector3 temp;

	[Token(Token = "0x4000698")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	protected float factor;

	[Token(Token = "0x6000CAB")]
	[Address(RVA = "0x1F9CD1C", Offset = "0x1F9BD1C", VA = "0x1F9CD1C", Slot = "14")]
	public override object GetSubject()
	{
		return null;
	}

	[Token(Token = "0x6000CAC")]
	[Address(RVA = "0x1F9CD24", Offset = "0x1F9BD24", VA = "0x1F9CD24", Slot = "12")]
	public override void _end()
	{
	}

	[Token(Token = "0x6000CAD")]
	[Address(RVA = "0x1F9CDFC", Offset = "0x1F9BDFC", VA = "0x1F9CDFC", Slot = "15")]
	protected override void WaitDone()
	{
	}

	[Token(Token = "0x6000CAE")]
	[Address(RVA = "0x1F9CE80", Offset = "0x1F9BE80", VA = "0x1F9CE80", Slot = "9")]
	protected override void DoAnim()
	{
	}

	[Token(Token = "0x6000CAF")]
	[Address(RVA = "0x1F9D03C", Offset = "0x1F9C03C", VA = "0x1F9D03C")]
	public static PunchRotation Do(GameObject sub, Vector3 mag, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000CB0")]
	[Address(RVA = "0x1F9D270", Offset = "0x1F9C270", VA = "0x1F9D270", Slot = "8")]
	public override bool Start(GameObject sub, AnimParams parms)
	{
		return default(bool);
	}

	[Token(Token = "0x6000CB1")]
	[Address(RVA = "0x1F9D160", Offset = "0x1F9C160", VA = "0x1F9D160")]
	public void Start(GameObject sub, Vector3 mag, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000CB2")]
	[Address(RVA = "0x1F9D3DC", Offset = "0x1F9C3DC", VA = "0x1F9D3DC")]
	public void Start(GameObject sub, Vector3 begin, Vector3 mag, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000CB3")]
	[Address(RVA = "0x1F9D560", Offset = "0x1F9C560", VA = "0x1F9D560")]
	public PunchRotation()
	{
	}
}
[Token(Token = "0x20000C1")]
public class Crash : EZAnimation
{
	[Token(Token = "0x4000699")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected Vector3 start;

	[Token(Token = "0x400069A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	protected Vector3 magnitude;

	[Token(Token = "0x400069B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected GameObject subject;

	[Token(Token = "0x400069C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected Transform subTrans;

	[Token(Token = "0x400069D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected Vector3 tempMag;

	[Token(Token = "0x400069E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	protected Vector3 temp;

	[Token(Token = "0x400069F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected float factor;

	[Token(Token = "0x6000CB4")]
	[Address(RVA = "0x1F9D590", Offset = "0x1F9C590", VA = "0x1F9D590", Slot = "14")]
	public override object GetSubject()
	{
		return null;
	}

	[Token(Token = "0x6000CB5")]
	[Address(RVA = "0x1F9D598", Offset = "0x1F9C598", VA = "0x1F9D598", Slot = "12")]
	public override void _end()
	{
	}

	[Token(Token = "0x6000CB6")]
	[Address(RVA = "0x1F9D670", Offset = "0x1F9C670", VA = "0x1F9D670", Slot = "15")]
	protected override void WaitDone()
	{
	}

	[Token(Token = "0x6000CB7")]
	[Address(RVA = "0x1F9D6F4", Offset = "0x1F9C6F4", VA = "0x1F9D6F4", Slot = "9")]
	protected override void DoAnim()
	{
	}

	[Token(Token = "0x6000CB8")]
	[Address(RVA = "0x1F9D860", Offset = "0x1F9C860", VA = "0x1F9D860")]
	public static Crash Do(GameObject sub, Vector3 mag, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000CB9")]
	[Address(RVA = "0x1F9DA94", Offset = "0x1F9CA94", VA = "0x1F9DA94", Slot = "8")]
	public override bool Start(GameObject sub, AnimParams parms)
	{
		return default(bool);
	}

	[Token(Token = "0x6000CBA")]
	[Address(RVA = "0x1F9D984", Offset = "0x1F9C984", VA = "0x1F9D984")]
	public void Start(GameObject sub, Vector3 mag, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000CBB")]
	[Address(RVA = "0x1F9DC00", Offset = "0x1F9CC00", VA = "0x1F9DC00")]
	public void Start(GameObject sub, Vector3 begin, Vector3 mag, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000CBC")]
	[Address(RVA = "0x1F9DD84", Offset = "0x1F9CD84", VA = "0x1F9DD84")]
	public Crash()
	{
	}
}
[Token(Token = "0x20000C2")]
public class SmoothCrash : EZAnimation
{
	[Token(Token = "0x40006A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected Vector3 start;

	[Token(Token = "0x40006A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	protected Vector3 magnitude;

	[Token(Token = "0x40006A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected Vector3 oscillations;

	[Token(Token = "0x40006A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected GameObject subject;

	[Token(Token = "0x40006A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected Transform subTrans;

	[Token(Token = "0x40006A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected Vector3 temp;

	[Token(Token = "0x40006A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	protected float factor;

	[Token(Token = "0x40006A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	protected float invFactor;

	[Token(Token = "0x40006A8")]
	protected const float PIx2 = (float)Math.PI * 2f;

	[Token(Token = "0x6000CBD")]
	[Address(RVA = "0x1F9DDB8", Offset = "0x1F9CDB8", VA = "0x1F9DDB8", Slot = "14")]
	public override object GetSubject()
	{
		return null;
	}

	[Token(Token = "0x6000CBE")]
	[Address(RVA = "0x1F9DDC0", Offset = "0x1F9CDC0", VA = "0x1F9DDC0", Slot = "12")]
	public override void _end()
	{
	}

	[Token(Token = "0x6000CBF")]
	[Address(RVA = "0x1F9DE98", Offset = "0x1F9CE98", VA = "0x1F9DE98", Slot = "15")]
	protected override void WaitDone()
	{
	}

	[Token(Token = "0x6000CC0")]
	[Address(RVA = "0x1F9DF1C", Offset = "0x1F9CF1C", VA = "0x1F9DF1C", Slot = "9")]
	protected override void DoAnim()
	{
	}

	[Token(Token = "0x6000CC1")]
	[Address(RVA = "0x1F9E0B8", Offset = "0x1F9D0B8", VA = "0x1F9E0B8")]
	public static SmoothCrash Do(GameObject sub, Vector3 mag, Vector3 oscill, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000CC2")]
	[Address(RVA = "0x1F9E314", Offset = "0x1F9D314", VA = "0x1F9E314", Slot = "8")]
	public override bool Start(GameObject sub, AnimParams parms)
	{
		return default(bool);
	}

	[Token(Token = "0x6000CC3")]
	[Address(RVA = "0x1F9E1FC", Offset = "0x1F9D1FC", VA = "0x1F9E1FC")]
	public void Start(GameObject sub, Vector3 mag, Vector3 oscill, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000CC4")]
	[Address(RVA = "0x1F9E4A0", Offset = "0x1F9D4A0", VA = "0x1F9E4A0")]
	public void Start(GameObject sub, Vector3 begin, Vector3 mag, Vector3 oscill, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000CC5")]
	[Address(RVA = "0x1F9E6A4", Offset = "0x1F9D6A4", VA = "0x1F9E6A4")]
	public SmoothCrash()
	{
	}
}
[Token(Token = "0x20000C3")]
public class Shake : EZAnimation
{
	[Token(Token = "0x40006A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected Vector3 start;

	[Token(Token = "0x40006AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	protected Vector3 magnitude;

	[Token(Token = "0x40006AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected float oscillations;

	[Token(Token = "0x40006AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected GameObject subject;

	[Token(Token = "0x40006AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected Transform subTrans;

	[Token(Token = "0x40006AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected Vector3 temp;

	[Token(Token = "0x40006AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	protected float factor;

	[Token(Token = "0x40006B0")]
	protected const float PIx2 = (float)Math.PI * 2f;

	[Token(Token = "0x6000CC6")]
	[Address(RVA = "0x1F9E6D8", Offset = "0x1F9D6D8", VA = "0x1F9E6D8", Slot = "14")]
	public override object GetSubject()
	{
		return null;
	}

	[Token(Token = "0x6000CC7")]
	[Address(RVA = "0x1F9E6E0", Offset = "0x1F9D6E0", VA = "0x1F9E6E0", Slot = "12")]
	public override void _end()
	{
	}

	[Token(Token = "0x6000CC8")]
	[Address(RVA = "0x1F9E7B8", Offset = "0x1F9D7B8", VA = "0x1F9E7B8", Slot = "15")]
	protected override void WaitDone()
	{
	}

	[Token(Token = "0x6000CC9")]
	[Address(RVA = "0x1F9E83C", Offset = "0x1F9D83C", VA = "0x1F9E83C", Slot = "9")]
	protected override void DoAnim()
	{
	}

	[Token(Token = "0x6000CCA")]
	[Address(RVA = "0x1F9E968", Offset = "0x1F9D968", VA = "0x1F9E968")]
	public static Shake Do(GameObject sub, Vector3 mag, float oscill, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000CCB")]
	[Address(RVA = "0x1F9EB98", Offset = "0x1F9DB98", VA = "0x1F9EB98", Slot = "8")]
	public override bool Start(GameObject sub, AnimParams parms)
	{
		return default(bool);
	}

	[Token(Token = "0x6000CCC")]
	[Address(RVA = "0x1F9EA94", Offset = "0x1F9DA94", VA = "0x1F9EA94")]
	public void Start(GameObject sub, Vector3 mag, float oscill, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000CCD")]
	[Address(RVA = "0x1F9ED14", Offset = "0x1F9DD14", VA = "0x1F9ED14")]
	public void Start(GameObject sub, Vector3 begin, Vector3 mag, float oscill, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000CCE")]
	[Address(RVA = "0x1F9EEC4", Offset = "0x1F9DEC4", VA = "0x1F9EEC4")]
	public Shake()
	{
	}
}
[Token(Token = "0x20000C4")]
public class CrashRotation : EZAnimation
{
	[Token(Token = "0x40006B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected Vector3 start;

	[Token(Token = "0x40006B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	protected Vector3 magnitude;

	[Token(Token = "0x40006B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected Vector3 oscillations;

	[Token(Token = "0x40006B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected GameObject subject;

	[Token(Token = "0x40006B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected Transform subTrans;

	[Token(Token = "0x40006B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected Vector3 temp;

	[Token(Token = "0x40006B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	protected float factor;

	[Token(Token = "0x40006B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	protected float invFactor;

	[Token(Token = "0x40006B9")]
	protected const float PIx2 = (float)Math.PI * 2f;

	[Token(Token = "0x6000CCF")]
	[Address(RVA = "0x1F9EEF8", Offset = "0x1F9DEF8", VA = "0x1F9EEF8", Slot = "14")]
	public override object GetSubject()
	{
		return null;
	}

	[Token(Token = "0x6000CD0")]
	[Address(RVA = "0x1F9EF00", Offset = "0x1F9DF00", VA = "0x1F9EF00", Slot = "12")]
	public override void _end()
	{
	}

	[Token(Token = "0x6000CD1")]
	[Address(RVA = "0x1F9EFD8", Offset = "0x1F9DFD8", VA = "0x1F9EFD8", Slot = "15")]
	protected override void WaitDone()
	{
	}

	[Token(Token = "0x6000CD2")]
	[Address(RVA = "0x1F9F05C", Offset = "0x1F9E05C", VA = "0x1F9F05C", Slot = "9")]
	protected override void DoAnim()
	{
	}

	[Token(Token = "0x6000CD3")]
	[Address(RVA = "0x1F9F21C", Offset = "0x1F9E21C", VA = "0x1F9F21C")]
	public static CrashRotation Do(GameObject sub, Vector3 mag, Vector3 oscill, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000CD4")]
	[Address(RVA = "0x1F9F478", Offset = "0x1F9E478", VA = "0x1F9F478", Slot = "8")]
	public override bool Start(GameObject sub, AnimParams parms)
	{
		return default(bool);
	}

	[Token(Token = "0x6000CD5")]
	[Address(RVA = "0x1F9F360", Offset = "0x1F9E360", VA = "0x1F9F360")]
	public void Start(GameObject sub, Vector3 mag, Vector3 oscill, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000CD6")]
	[Address(RVA = "0x1F9F604", Offset = "0x1F9E604", VA = "0x1F9F604")]
	public void Start(GameObject sub, Vector3 begin, Vector3 mag, Vector3 oscill, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000CD7")]
	[Address(RVA = "0x1F9F800", Offset = "0x1F9E800", VA = "0x1F9F800")]
	public CrashRotation()
	{
	}
}
[Token(Token = "0x20000C5")]
public class ShakeRotation : EZAnimation
{
	[Token(Token = "0x40006BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected Vector3 start;

	[Token(Token = "0x40006BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	protected Vector3 magnitude;

	[Token(Token = "0x40006BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected float oscillations;

	[Token(Token = "0x40006BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected GameObject subject;

	[Token(Token = "0x40006BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected Transform subTrans;

	[Token(Token = "0x40006BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected Vector3 temp;

	[Token(Token = "0x40006C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	protected float factor;

	[Token(Token = "0x40006C1")]
	protected const float PIx2 = (float)Math.PI * 2f;

	[Token(Token = "0x6000CD8")]
	[Address(RVA = "0x1F9F834", Offset = "0x1F9E834", VA = "0x1F9F834", Slot = "14")]
	public override object GetSubject()
	{
		return null;
	}

	[Token(Token = "0x6000CD9")]
	[Address(RVA = "0x1F9F83C", Offset = "0x1F9E83C", VA = "0x1F9F83C", Slot = "12")]
	public override void _end()
	{
	}

	[Token(Token = "0x6000CDA")]
	[Address(RVA = "0x1F9F914", Offset = "0x1F9E914", VA = "0x1F9F914", Slot = "15")]
	protected override void WaitDone()
	{
	}

	[Token(Token = "0x6000CDB")]
	[Address(RVA = "0x1F9F998", Offset = "0x1F9E998", VA = "0x1F9F998", Slot = "9")]
	protected override void DoAnim()
	{
	}

	[Token(Token = "0x6000CDC")]
	[Address(RVA = "0x1F9FAE8", Offset = "0x1F9EAE8", VA = "0x1F9FAE8")]
	public static ShakeRotation Do(GameObject sub, Vector3 mag, float oscill, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000CDD")]
	[Address(RVA = "0x1F9FD18", Offset = "0x1F9ED18", VA = "0x1F9FD18", Slot = "8")]
	public override bool Start(GameObject sub, AnimParams parms)
	{
		return default(bool);
	}

	[Token(Token = "0x6000CDE")]
	[Address(RVA = "0x1F9FC14", Offset = "0x1F9EC14", VA = "0x1F9FC14")]
	public void Start(GameObject sub, Vector3 mag, float oscill, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000CDF")]
	[Address(RVA = "0x1F9FE94", Offset = "0x1F9EE94", VA = "0x1F9FE94")]
	public void Start(GameObject sub, Vector3 begin, Vector3 mag, float oscill, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000CE0")]
	[Address(RVA = "0x1F9FFD4", Offset = "0x1F9EFD4", VA = "0x1F9FFD4")]
	public ShakeRotation()
	{
	}
}
[Token(Token = "0x20000C6")]
public class RunAnimClip : EZAnimation
{
	[Token(Token = "0x40006C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected GameObject subject;

	[Token(Token = "0x40006C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected string m_clip;

	[Token(Token = "0x40006C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected bool waitForClip;

	[Token(Token = "0x40006C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
	protected bool playedYet;

	[Token(Token = "0x40006C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	protected float blending;

	[Token(Token = "0x6000CE1")]
	[Address(RVA = "0x1FA0008", Offset = "0x1F9F008", VA = "0x1FA0008", Slot = "14")]
	public override object GetSubject()
	{
		return null;
	}

	[Token(Token = "0x6000CE2")]
	[Address(RVA = "0x1FA0010", Offset = "0x1F9F010", VA = "0x1FA0010", Slot = "10")]
	public override bool Step(float timeDelta)
	{
		return default(bool);
	}

	[Token(Token = "0x6000CE3")]
	[Address(RVA = "0x1FA0144", Offset = "0x1F9F144", VA = "0x1FA0144", Slot = "9")]
	protected override void DoAnim()
	{
	}

	[Token(Token = "0x6000CE4")]
	[Address(RVA = "0x1FA0148", Offset = "0x1F9F148", VA = "0x1FA0148")]
	public static RunAnimClip Do(GameObject sub, string clip, float blend, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000CE5")]
	[Address(RVA = "0x1FA03C8", Offset = "0x1F9F3C8", VA = "0x1FA03C8", Slot = "8")]
	public override bool Start(GameObject sub, AnimParams parms)
	{
		return default(bool);
	}

	[Token(Token = "0x6000CE6")]
	[Address(RVA = "0x1FA0264", Offset = "0x1F9F264", VA = "0x1FA0264")]
	public void Start(GameObject sub, string clip, float blend, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000CE7")]
	[Address(RVA = "0x1FA053C", Offset = "0x1F9F53C", VA = "0x1FA053C")]
	public RunAnimClip()
	{
	}
}
[Token(Token = "0x20000C7")]
public class FadeAudio : EZAnimation
{
	[Token(Token = "0x40006C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected float start;

	[Token(Token = "0x40006C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected AudioSource subject;

	[Token(Token = "0x40006C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected float delta;

	[Token(Token = "0x40006CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	protected float end;

	[Token(Token = "0x6000CE8")]
	[Address(RVA = "0x1FA0570", Offset = "0x1F9F570", VA = "0x1FA0570", Slot = "14")]
	public override object GetSubject()
	{
		return null;
	}

	[Token(Token = "0x6000CE9")]
	[Address(RVA = "0x1FA0578", Offset = "0x1F9F578", VA = "0x1FA0578", Slot = "12")]
	public override void _end()
	{
	}

	[Token(Token = "0x6000CEA")]
	[Address(RVA = "0x1FA0620", Offset = "0x1F9F620", VA = "0x1FA0620", Slot = "13")]
	protected override void LoopReset()
	{
	}

	[Token(Token = "0x6000CEB")]
	[Address(RVA = "0x1FA0648", Offset = "0x1F9F648", VA = "0x1FA0648", Slot = "15")]
	protected override void WaitDone()
	{
	}

	[Token(Token = "0x6000CEC")]
	[Address(RVA = "0x1FA06E0", Offset = "0x1F9F6E0", VA = "0x1FA06E0", Slot = "9")]
	protected override void DoAnim()
	{
	}

	[Token(Token = "0x6000CED")]
	[Address(RVA = "0x1FA07B8", Offset = "0x1F9F7B8", VA = "0x1FA07B8")]
	public static FadeAudio Do(AudioSource audio, ANIM_MODE mode, float begin, float dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000CEE")]
	[Address(RVA = "0x1FA09E8", Offset = "0x1F9F9E8", VA = "0x1FA09E8")]
	public static FadeAudio Do(AudioSource audio, ANIM_MODE mode, float dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000CEF")]
	[Address(RVA = "0x1FA0B9C", Offset = "0x1F9FB9C", VA = "0x1FA0B9C", Slot = "8")]
	public override bool Start(GameObject sub, AnimParams parms)
	{
		return default(bool);
	}

	[Token(Token = "0x6000CF0")]
	[Address(RVA = "0x1FA0B0C", Offset = "0x1F9FB0C", VA = "0x1FA0B0C")]
	public void Start(AudioSource audio, ANIM_MODE mode, float dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000CF1")]
	[Address(RVA = "0x1FA08E4", Offset = "0x1F9F8E4", VA = "0x1FA08E4")]
	public void Start(AudioSource sub, ANIM_MODE mode, float begin, float dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000CF2")]
	[Address(RVA = "0x1FA0E3C", Offset = "0x1F9FE3C", VA = "0x1FA0E3C")]
	public FadeAudio()
	{
	}
}
[Token(Token = "0x20000C8")]
public class TuneAudio : EZAnimation
{
	[Token(Token = "0x40006CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected float start;

	[Token(Token = "0x40006CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected AudioSource subject;

	[Token(Token = "0x40006CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected float delta;

	[Token(Token = "0x40006CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	protected float end;

	[Token(Token = "0x6000CF3")]
	[Address(RVA = "0x1FA0E70", Offset = "0x1F9FE70", VA = "0x1FA0E70", Slot = "14")]
	public override object GetSubject()
	{
		return null;
	}

	[Token(Token = "0x6000CF4")]
	[Address(RVA = "0x1FA0E78", Offset = "0x1F9FE78", VA = "0x1FA0E78", Slot = "12")]
	public override void _end()
	{
	}

	[Token(Token = "0x6000CF5")]
	[Address(RVA = "0x1FA0F20", Offset = "0x1F9FF20", VA = "0x1FA0F20", Slot = "13")]
	protected override void LoopReset()
	{
	}

	[Token(Token = "0x6000CF6")]
	[Address(RVA = "0x1FA0F48", Offset = "0x1F9FF48", VA = "0x1FA0F48", Slot = "15")]
	protected override void WaitDone()
	{
	}

	[Token(Token = "0x6000CF7")]
	[Address(RVA = "0x1FA0FE0", Offset = "0x1F9FFE0", VA = "0x1FA0FE0", Slot = "9")]
	protected override void DoAnim()
	{
	}

	[Token(Token = "0x6000CF8")]
	[Address(RVA = "0x1FA10B8", Offset = "0x1FA00B8", VA = "0x1FA10B8")]
	public static TuneAudio Do(AudioSource audio, ANIM_MODE mode, float begin, float dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000CF9")]
	[Address(RVA = "0x1FA12E8", Offset = "0x1FA02E8", VA = "0x1FA12E8")]
	public static TuneAudio Do(AudioSource audio, ANIM_MODE mode, float dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
		return null;
	}

	[Token(Token = "0x6000CFA")]
	[Address(RVA = "0x1FA149C", Offset = "0x1FA049C", VA = "0x1FA149C", Slot = "8")]
	public override bool Start(GameObject sub, AnimParams parms)
	{
		return default(bool);
	}

	[Token(Token = "0x6000CFB")]
	[Address(RVA = "0x1FA140C", Offset = "0x1FA040C", VA = "0x1FA140C")]
	public void Start(AudioSource audio, ANIM_MODE mode, float dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000CFC")]
	[Address(RVA = "0x1FA11E4", Offset = "0x1FA01E4", VA = "0x1FA11E4")]
	public void Start(AudioSource sub, ANIM_MODE mode, float begin, float dest, Interpolator interp, float dur, float delay, CompletionDelegate startDel, CompletionDelegate del)
	{
	}

	[Token(Token = "0x6000CFD")]
	[Address(RVA = "0x1FA173C", Offset = "0x1FA073C", VA = "0x1FA173C")]
	public TuneAudio()
	{
	}
}
[Serializable]
[Token(Token = "0x20000C9")]
public class AnimParams
{
	[Token(Token = "0x40006CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public EZAnimation.ANIM_MODE mode;

	[Token(Token = "0x40006D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float delay;

	[Token(Token = "0x40006D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float duration;

	[Token(Token = "0x40006D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool pingPong;

	[Token(Token = "0x40006D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool restartOnRepeat;

	[Token(Token = "0x40006D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	public bool repeatDelay;

	[Token(Token = "0x40006D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public EZAnimation.EASING_TYPE easing;

	[NonSerialized]
	[Token(Token = "0x40006D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected EZTransition m_transition;

	[Token(Token = "0x40006D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Color color;

	[Token(Token = "0x40006D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Color color2;

	[Token(Token = "0x40006D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector3 vec;

	[Token(Token = "0x40006DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public Vector3 vec2;

	[Token(Token = "0x40006DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Vector3 axis;

	[Token(Token = "0x40006DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float floatVal;

	[Token(Token = "0x40006DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float floatVal2;

	[Token(Token = "0x40006DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public string strVal;

	[Token(Token = "0x1700017B")]
	public EZTransition transition
	{
		[Token(Token = "0x6000D00")]
		[Address(RVA = "0x1FA1880", Offset = "0x1FA0880", VA = "0x1FA1880")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D01")]
		[Address(RVA = "0x1FA1888", Offset = "0x1FA0888", VA = "0x1FA1888")]
		set
		{
		}
	}

	[Token(Token = "0x6000CFE")]
	[Address(RVA = "0x1FA1770", Offset = "0x1FA0770", VA = "0x1FA1770")]
	public AnimParams(EZTransition trans)
	{
	}

	[Token(Token = "0x6000CFF")]
	[Address(RVA = "0x1FA17E4", Offset = "0x1FA07E4", VA = "0x1FA17E4")]
	public void Copy(AnimParams src)
	{
	}

	[Token(Token = "0x6000D02")]
	[Address(RVA = "0x1FA1890", Offset = "0x1FA0890", VA = "0x1FA1890", Slot = "4")]
	public virtual void DrawGUI(EZAnimation.ANIM_TYPE type, GameObject go, IGUIHelper gui, bool inspector)
	{
	}
}
[Serializable]
[Token(Token = "0x20000CA")]
[AddComponentMenu("EZ GUI/Utility/EZ Screen Placement")]
[ExecuteInEditMode]
public class EZScreenPlacement : MonoBehaviour, IUseCamera
{
	[Token(Token = "0x20000CB")]
	public enum HORIZONTAL_ALIGN
	{
		[Token(Token = "0x40006ED")]
		NONE,
		[Token(Token = "0x40006EE")]
		SCREEN_LEFT,
		[Token(Token = "0x40006EF")]
		SCREEN_RIGHT,
		[Token(Token = "0x40006F0")]
		SCREEN_CENTER,
		[Token(Token = "0x40006F1")]
		OBJECT
	}

	[Token(Token = "0x20000CC")]
	public enum VERTICAL_ALIGN
	{
		[Token(Token = "0x40006F3")]
		NONE,
		[Token(Token = "0x40006F4")]
		SCREEN_TOP,
		[Token(Token = "0x40006F5")]
		SCREEN_BOTTOM,
		[Token(Token = "0x40006F6")]
		SCREEN_CENTER,
		[Token(Token = "0x40006F7")]
		OBJECT
	}

	[Serializable]
	[Token(Token = "0x20000CD")]
	public class RelativeTo
	{
		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public HORIZONTAL_ALIGN horizontal;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public VERTICAL_ALIGN vertical;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected EZScreenPlacement script;

		[Token(Token = "0x1700017E")]
		public EZScreenPlacement Script
		{
			[Token(Token = "0x6000D18")]
			[Address(RVA = "0x1FA5DD0", Offset = "0x1FA4DD0", VA = "0x1FA5DD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D19")]
			[Address(RVA = "0x1FA5DD8", Offset = "0x1FA4DD8", VA = "0x1FA5DD8")]
			set
			{
			}
		}

		[Token(Token = "0x6000D1A")]
		[Address(RVA = "0x1FA5DDC", Offset = "0x1FA4DDC", VA = "0x1FA5DDC")]
		public bool Equals(RelativeTo rt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D1B")]
		[Address(RVA = "0x1FA5E0C", Offset = "0x1FA4E0C", VA = "0x1FA5E0C")]
		public void Copy(RelativeTo rt)
		{
		}

		[Token(Token = "0x6000D1C")]
		[Address(RVA = "0x1FA4B94", Offset = "0x1FA3B94", VA = "0x1FA4B94")]
		public RelativeTo(EZScreenPlacement sp, RelativeTo rt)
		{
		}

		[Token(Token = "0x6000D1D")]
		[Address(RVA = "0x1FA4B64", Offset = "0x1FA3B64", VA = "0x1FA4B64")]
		public RelativeTo(EZScreenPlacement sp)
		{
		}
	}

	[Token(Token = "0x40006DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Camera renderCamera;

	[Token(Token = "0x40006E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 screenPos;

	[Token(Token = "0x40006E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool ignoreZ;

	[Token(Token = "0x40006E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RelativeTo relativeTo;

	[Token(Token = "0x40006E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform relativeObject;

	[Token(Token = "0x40006E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool alwaysRecursive;

	[Token(Token = "0x40006E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool allowTransformDrag;

	[Token(Token = "0x40006E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	protected Vector2 screenSize;

	[NonSerialized]
	[Token(Token = "0x40006E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	protected bool justEnabled;

	[NonSerialized]
	[Token(Token = "0x40006E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected EZScreenPlacementMirror mirror;

	[Token(Token = "0x40006E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected bool m_awake;

	[Token(Token = "0x40006EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	protected bool m_started;

	[Token(Token = "0x40006EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public EZScreenPlacement[] dependents;

	[Token(Token = "0x1700017C")]
	public Camera RenderCamera
	{
		[Token(Token = "0x6000D0C")]
		[Address(RVA = "0x1FA5430", Offset = "0x1FA4430", VA = "0x1FA5430", Slot = "6")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D0D")]
		[Address(RVA = "0x1FA5438", Offset = "0x1FA4438", VA = "0x1FA5438", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x1700017D")]
	public Vector3 ScreenCoord
	{
		[Token(Token = "0x6000D12")]
		[Address(RVA = "0x1FA5810", Offset = "0x1FA4810", VA = "0x1FA5810")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x6000D03")]
	[Address(RVA = "0x1FA496C", Offset = "0x1FA396C", VA = "0x1FA496C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000D04")]
	[Address(RVA = "0x1FA4BD4", Offset = "0x1FA3BD4", VA = "0x1FA4BD4")]
	public void Start()
	{
	}

	[Token(Token = "0x6000D05")]
	[Address(RVA = "0x1FA4C94", Offset = "0x1FA3C94", VA = "0x1FA4C94")]
	public void PositionOnScreenRecursively()
	{
	}

	[Token(Token = "0x6000D06")]
	[Address(RVA = "0x1FA5070", Offset = "0x1FA4070", VA = "0x1FA5070")]
	public Vector3 ScreenPosToLocalPos(Vector3 screenPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000D07")]
	[Address(RVA = "0x1FA53B8", Offset = "0x1FA43B8", VA = "0x1FA53B8")]
	public Vector3 ScreenPosToParentPos(Vector3 screenPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000D08")]
	[Address(RVA = "0x1FA50D4", Offset = "0x1FA40D4", VA = "0x1FA50D4")]
	public Vector3 ScreenPosToWorldPos(Vector3 screenPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000D09")]
	[Address(RVA = "0x1FA4DF8", Offset = "0x1FA3DF8", VA = "0x1FA4DF8")]
	public void PositionOnScreen()
	{
	}

	[Token(Token = "0x6000D0A")]
	[Address(RVA = "0x1FA5410", Offset = "0x1FA4410", VA = "0x1FA5410")]
	public void PositionOnScreen(int x, int y, float depth)
	{
	}

	[Token(Token = "0x6000D0B")]
	[Address(RVA = "0x1FA5424", Offset = "0x1FA4424", VA = "0x1FA5424")]
	public void PositionOnScreen(Vector3 pos)
	{
	}

	[Token(Token = "0x6000D0E")]
	[Address(RVA = "0x1FA5574", Offset = "0x1FA4574", VA = "0x1FA5574")]
	public void UpdateCamera()
	{
	}

	[Token(Token = "0x6000D0F")]
	[Address(RVA = "0x1FA557C", Offset = "0x1FA457C", VA = "0x1FA557C", Slot = "4")]
	public void SetCamera()
	{
	}

	[Token(Token = "0x6000D10")]
	[Address(RVA = "0x1FA543C", Offset = "0x1FA443C", VA = "0x1FA543C", Slot = "5")]
	public void SetCamera(Camera c)
	{
	}

	[Token(Token = "0x6000D11")]
	[Address(RVA = "0x1FA5584", Offset = "0x1FA4584", VA = "0x1FA5584")]
	public void WorldToScreenPos(Vector3 worldPos)
	{
	}

	[Token(Token = "0x6000D13")]
	[Address(RVA = "0x1FA5844", Offset = "0x1FA4844", VA = "0x1FA5844")]
	public static bool TestDepenency(EZScreenPlacement sp)
	{
		return default(bool);
	}

	[Token(Token = "0x6000D14")]
	[Address(RVA = "0x1FA5B6C", Offset = "0x1FA4B6C", VA = "0x1FA5B6C", Slot = "8")]
	public virtual void DoMirror()
	{
	}

	[Token(Token = "0x6000D15")]
	[Address(RVA = "0x1FA5CE4", Offset = "0x1FA4CE4", VA = "0x1FA5CE4", Slot = "9")]
	public virtual void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000D16")]
	[Address(RVA = "0x1FA5CF0", Offset = "0x1FA4CF0", VA = "0x1FA5CF0", Slot = "10")]
	public virtual void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000D17")]
	[Address(RVA = "0x1FA5CFC", Offset = "0x1FA4CFC", VA = "0x1FA5CFC")]
	public EZScreenPlacement()
	{
	}
}
[Token(Token = "0x20000CE")]
public class EZScreenPlacementMirror
{
	[Token(Token = "0x40006FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3 worldPos;

	[Token(Token = "0x40006FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 screenPos;

	[Token(Token = "0x40006FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public EZScreenPlacement.RelativeTo relativeTo;

	[Token(Token = "0x40006FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform relativeObject;

	[Token(Token = "0x40006FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Camera renderCamera;

	[Token(Token = "0x4000700")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector2 screenSize;

	[Token(Token = "0x6000D1E")]
	[Address(RVA = "0x1FA5C74", Offset = "0x1FA4C74", VA = "0x1FA5C74")]
	public EZScreenPlacementMirror()
	{
	}

	[Token(Token = "0x6000D1F")]
	[Address(RVA = "0x1FA5E1C", Offset = "0x1FA4E1C", VA = "0x1FA5E1C", Slot = "4")]
	public virtual void Mirror(EZScreenPlacement sp)
	{
	}

	[Token(Token = "0x6000D20")]
	[Address(RVA = "0x1FA5EC8", Offset = "0x1FA4EC8", VA = "0x1FA5EC8", Slot = "5")]
	public virtual bool Validate(EZScreenPlacement sp)
	{
		return default(bool);
	}

	[Token(Token = "0x6000D21")]
	[Address(RVA = "0x1FA6088", Offset = "0x1FA5088", VA = "0x1FA6088", Slot = "6")]
	public virtual bool DidChange(EZScreenPlacement sp)
	{
		return default(bool);
	}
}
[Token(Token = "0x20000CF")]
public static class FontStore
{
	[Token(Token = "0x4000701")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static SpriteFont[] fonts;

	[Token(Token = "0x6000D22")]
	[Address(RVA = "0x1FA62A8", Offset = "0x1FA52A8", VA = "0x1FA62A8")]
	public static SpriteFont GetFont(TextAsset fontDef)
	{
		return null;
	}

	[Token(Token = "0x6000D23")]
	[Address(RVA = "0x1FA6588", Offset = "0x1FA5588", VA = "0x1FA6588")]
	private static void AddFont(SpriteFont f)
	{
	}
}
[Token(Token = "0x20000D0")]
public delegate UnityEngine.Object LoadAssetDelegate(string path, Type type);
[Token(Token = "0x20000D1")]
public delegate string PathFromGUIDDelegate(string path);
[Token(Token = "0x20000D2")]
public delegate string GUIDFromPathDelegate(string guid);
[Token(Token = "0x20000D3")]
public delegate string GetAssetPathDelegate(UnityEngine.Object asset);
[Token(Token = "0x20000D4")]
public interface ISpriteAggregator
{
	[Token(Token = "0x1700017F")]
	Texture2D[] SourceTextures
	{
		[Token(Token = "0x6000D36")]
		get;
	}

	[Token(Token = "0x17000180")]
	CSpriteFrame[] SpriteFrames
	{
		[Token(Token = "0x6000D37")]
		get;
	}

	[Token(Token = "0x17000181")]
	CSpriteFrame DefaultFrame
	{
		[Token(Token = "0x6000D39")]
		get;
	}

	[Token(Token = "0x17000182")]
	GameObject gameObject
	{
		[Token(Token = "0x6000D3B")]
		get;
	}

	[Token(Token = "0x17000183")]
	bool DoNotTrimImages
	{
		[Token(Token = "0x6000D3C")]
		get;
	}

	[Token(Token = "0x6000D35")]
	void Aggregate(PathFromGUIDDelegate guid2Path, LoadAssetDelegate load, GUIDFromPathDelegate path2Guid);

	[Token(Token = "0x6000D38")]
	Material GetPackedMaterial(out string errString);

	[Token(Token = "0x6000D3A")]
	void SetUVs(Rect uvs);
}
[Token(Token = "0x20000D5")]
public interface ISpriteAnimatable
{
	[Token(Token = "0x17000184")]
	ISpriteAnimatable prev
	{
		[Token(Token = "0x6000D3E")]
		get;
		[Token(Token = "0x6000D3F")]
		set;
	}

	[Token(Token = "0x17000185")]
	ISpriteAnimatable next
	{
		[Token(Token = "0x6000D40")]
		get;
		[Token(Token = "0x6000D41")]
		set;
	}

	[Token(Token = "0x6000D3D")]
	bool StepAnim(float time);
}
[Token(Token = "0x20000D6")]
public interface ISpriteMesh
{
	[Token(Token = "0x17000186")]
	SpriteRoot sprite
	{
		[Token(Token = "0x6000D42")]
		get;
		[Token(Token = "0x6000D43")]
		set;
	}

	[Token(Token = "0x17000187")]
	Texture texture
	{
		[Token(Token = "0x6000D44")]
		get;
	}

	[Token(Token = "0x17000188")]
	Material material
	{
		[Token(Token = "0x6000D45")]
		get;
	}

	[Token(Token = "0x17000189")]
	Vector3[] vertices
	{
		[Token(Token = "0x6000D46")]
		get;
	}

	[Token(Token = "0x1700018A")]
	Vector2[] uvs
	{
		[Token(Token = "0x6000D47")]
		get;
	}

	[Token(Token = "0x1700018B")]
	Vector2[] uvs2
	{
		[Token(Token = "0x6000D48")]
		get;
	}

	[Token(Token = "0x1700018C")]
	bool UseUV2
	{
		[Token(Token = "0x6000D49")]
		get;
		[Token(Token = "0x6000D4A")]
		set;
	}

	[Token(Token = "0x6000D4B")]
	void Init();

	[Token(Token = "0x6000D4C")]
	void UpdateVerts();

	[Token(Token = "0x6000D4D")]
	void UpdateUVs();

	[Token(Token = "0x6000D4E")]
	void UpdateColors(Color color);

	[Token(Token = "0x6000D4F")]
	void Hide(bool tf);

	[Token(Token = "0x6000D50")]
	bool IsHidden();
}
[Token(Token = "0x20000D7")]
public interface ISpritePackable
{
	[Token(Token = "0x1700018D")]
	GameObject gameObject
	{
		[Token(Token = "0x6000D51")]
		get;
	}

	[Token(Token = "0x1700018E")]
	TextureAnim[] States
	{
		[Token(Token = "0x6000D52")]
		get;
		[Token(Token = "0x6000D53")]
		set;
	}

	[Token(Token = "0x1700018F")]
	SpriteRoot.ANCHOR_METHOD Anchor
	{
		[Token(Token = "0x6000D54")]
		get;
	}

	[Token(Token = "0x17000190")]
	Color Color
	{
		[Token(Token = "0x6000D55")]
		get;
		[Token(Token = "0x6000D56")]
		set;
	}

	[Token(Token = "0x17000191")]
	bool SupportsArbitraryAnimations
	{
		[Token(Token = "0x6000D57")]
		get;
	}
}
[Token(Token = "0x20000D8")]
public interface IUseCamera
{
	[Token(Token = "0x17000192")]
	Camera RenderCamera
	{
		[Token(Token = "0x6000D5A")]
		get;
		[Token(Token = "0x6000D5B")]
		set;
	}

	[Token(Token = "0x6000D58")]
	void SetCamera();

	[Token(Token = "0x6000D59")]
	void SetCamera(Camera c);
}
[Token(Token = "0x20000D9")]
public abstract class PackableStub : MonoBehaviour
{
	[Token(Token = "0x17000193")]
	public abstract Texture2D[] SourceTextures
	{
		[Token(Token = "0x6000D5D")]
		get;
	}

	[Token(Token = "0x17000194")]
	public abstract CSpriteFrame[] SpriteFrames
	{
		[Token(Token = "0x6000D5E")]
		get;
	}

	[Token(Token = "0x17000195")]
	public abstract CSpriteFrame DefaultFrame
	{
		[Token(Token = "0x6000D60")]
		get;
	}

	[Token(Token = "0x17000196")]
	public abstract bool DoNotTrimImages
	{
		[Token(Token = "0x6000D62")]
		get;
		[Token(Token = "0x6000D63")]
		set;
	}

	[Token(Token = "0x6000D5C")]
	public abstract void Aggregate(PathFromGUIDDelegate guid2Path, LoadAssetDelegate load, GUIDFromPathDelegate path2Guid);

	[Token(Token = "0x6000D5F")]
	public abstract Material GetPackedMaterial(out string errString);

	[Token(Token = "0x6000D61")]
	public abstract void SetUVs(Rect uvs);

	[Token(Token = "0x6000D64")]
	[Address(RVA = "0x1FA6AEC", Offset = "0x1FA5AEC", VA = "0x1FA6AEC")]
	protected PackableStub()
	{
	}
}
[Token(Token = "0x20000DA")]
public class SpriteAnimationPump : MonoBehaviour
{
	[Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private sealed class <AnimationPump>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x1700019A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000D77")]
			[Address(RVA = "0x1FA7BF8", Offset = "0x1FA6BF8", VA = "0x1FA7BF8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000D79")]
			[Address(RVA = "0x1FA7C38", Offset = "0x1FA6C38", VA = "0x1FA7C38", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000D74")]
		[Address(RVA = "0x1FA6F04", Offset = "0x1FA5F04", VA = "0x1FA6F04")]
		[DebuggerHidden]
		public <AnimationPump>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x6000D75")]
		[Address(RVA = "0x1FA78D0", Offset = "0x1FA68D0", VA = "0x1FA78D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000D76")]
		[Address(RVA = "0x1FA78D4", Offset = "0x1FA68D4", VA = "0x1FA78D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000D78")]
		[Address(RVA = "0x1FA7C00", Offset = "0x1FA6C00", VA = "0x1FA7C00", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private sealed class <PumpStarter>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpriteAnimationPump <>4__this;

		[Token(Token = "0x1700019C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000D7D")]
			[Address(RVA = "0x1FA7CF8", Offset = "0x1FA6CF8", VA = "0x1FA7CF8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000D7F")]
			[Address(RVA = "0x1FA7D38", Offset = "0x1FA6D38", VA = "0x1FA7D38", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000D7A")]
		[Address(RVA = "0x1FA6E80", Offset = "0x1FA5E80", VA = "0x1FA6E80")]
		[DebuggerHidden]
		public <PumpStarter>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x6000D7B")]
		[Address(RVA = "0x1FA7C40", Offset = "0x1FA6C40", VA = "0x1FA7C40", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000D7C")]
		[Address(RVA = "0x1FA7C44", Offset = "0x1FA6C44", VA = "0x1FA7C44", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000D7E")]
		[Address(RVA = "0x1FA7D00", Offset = "0x1FA6D00", VA = "0x1FA7D00", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000702")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static SpriteAnimationPump instance;

	[Token(Token = "0x4000703")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	protected static ISpriteAnimatable head;

	[Token(Token = "0x4000704")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected static ISpriteAnimatable cur;

	[Token(Token = "0x4000705")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static float _timeScale;

	[Token(Token = "0x4000706")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private static float startTime;

	[Token(Token = "0x4000707")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static float time;

	[Token(Token = "0x4000708")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static float elapsed;

	[Token(Token = "0x4000709")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static float timePaused;

	[Token(Token = "0x400070A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private static bool isPaused;

	[Token(Token = "0x400070B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static ISpriteAnimatable next;

	[Token(Token = "0x400070C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected static bool pumpIsRunning;

	[Token(Token = "0x400070D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	protected static bool pumpIsDone;

	[Token(Token = "0x400070E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public static float animationPumpInterval;

	[Token(Token = "0x17000197")]
	public bool IsRunning
	{
		[Token(Token = "0x6000D65")]
		[Address(RVA = "0x1FA6AF4", Offset = "0x1FA5AF4", VA = "0x1FA6AF4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000198")]
	public static float timeScale
	{
		[Token(Token = "0x6000D66")]
		[Address(RVA = "0x1FA6B4C", Offset = "0x1FA5B4C", VA = "0x1FA6B4C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000D67")]
		[Address(RVA = "0x1FA6BA4", Offset = "0x1FA5BA4", VA = "0x1FA6BA4")]
		set
		{
		}
	}

	[Token(Token = "0x17000199")]
	public static SpriteAnimationPump Instance
	{
		[Token(Token = "0x6000D6E")]
		[Address(RVA = "0x1FA6F2C", Offset = "0x1FA5F2C", VA = "0x1FA6F2C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000D68")]
	[Address(RVA = "0x1FA6C10", Offset = "0x1FA5C10", VA = "0x1FA6C10")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000D69")]
	[Address(RVA = "0x1FA6C80", Offset = "0x1FA5C80", VA = "0x1FA6C80")]
	private void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x6000D6A")]
	[Address(RVA = "0x1FA6D84", Offset = "0x1FA5D84", VA = "0x1FA6D84")]
	public void StartAnimationPump()
	{
	}

	[Token(Token = "0x6000D6B")]
	[Address(RVA = "0x1FA6E20", Offset = "0x1FA5E20", VA = "0x1FA6E20")]
	[IteratorStateMachine(typeof(<PumpStarter>d__21))]
	protected IEnumerator PumpStarter()
	{
		return null;
	}

	[Token(Token = "0x6000D6C")]
	[Address(RVA = "0x1FA6EA8", Offset = "0x1FA5EA8", VA = "0x1FA6EA8")]
	public static void StopAnimationPump()
	{
	}

	[Token(Token = "0x6000D6D")]
	[Address(RVA = "0x1FA6EAC", Offset = "0x1FA5EAC", VA = "0x1FA6EAC")]
	[IteratorStateMachine(typeof(<AnimationPump>d__23))]
	protected static IEnumerator AnimationPump()
	{
		return null;
	}

	[Token(Token = "0x6000D6F")]
	[Address(RVA = "0x1FA710C", Offset = "0x1FA610C", VA = "0x1FA710C")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6000D70")]
	[Address(RVA = "0x1FA716C", Offset = "0x1FA616C", VA = "0x1FA716C")]
	public static void Add(ISpriteAnimatable s)
	{
	}

	[Token(Token = "0x6000D71")]
	[Address(RVA = "0x1FA7310", Offset = "0x1FA6310", VA = "0x1FA7310")]
	public static void Remove(ISpriteAnimatable s)
	{
	}

	[Token(Token = "0x6000D72")]
	[Address(RVA = "0x1FA7858", Offset = "0x1FA6858", VA = "0x1FA7858")]
	public SpriteAnimationPump()
	{
	}
}
[Serializable]
[Token(Token = "0x20000DD")]
public class UVAnimation
{
	[Token(Token = "0x20000DE")]
	public enum ANIM_END_ACTION
	{
		[Token(Token = "0x4000721")]
		Do_Nothing,
		[Token(Token = "0x4000722")]
		Revert_To_Static,
		[Token(Token = "0x4000723")]
		Play_Default_Anim,
		[Token(Token = "0x4000724")]
		Hide,
		[Token(Token = "0x4000725")]
		Deactivate,
		[Token(Token = "0x4000726")]
		Destroy
	}

	[Token(Token = "0x4000714")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected SPRITE_FRAME[] frames;

	[Token(Token = "0x4000715")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected int curFrame;

	[Token(Token = "0x4000716")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	protected int stepDir;

	[Token(Token = "0x4000717")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected int numLoops;

	[Token(Token = "0x4000718")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	protected bool playInReverse;

	[Token(Token = "0x4000719")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected float length;

	[Token(Token = "0x400071A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string name;

	[Token(Token = "0x400071B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int loopCycles;

	[Token(Token = "0x400071C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool loopReverse;

	[Token(Token = "0x400071D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public float framerate;

	[Token(Token = "0x400071E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[HideInInspector]
	public int index;

	[Token(Token = "0x400071F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public ANIM_END_ACTION onAnimEnd;

	[Token(Token = "0x1700019E")]
	public int StepDirection
	{
		[Token(Token = "0x6000D80")]
		[Address(RVA = "0x1FA7D40", Offset = "0x1FA6D40", VA = "0x1FA7D40")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000D81")]
		[Address(RVA = "0x1FA7D48", Offset = "0x1FA6D48", VA = "0x1FA7D48")]
		set
		{
		}
	}

	[Token(Token = "0x6000D82")]
	[Address(RVA = "0x1FA7D90", Offset = "0x1FA6D90", VA = "0x1FA7D90")]
	public UVAnimation(UVAnimation anim)
	{
	}

	[Token(Token = "0x6000D83")]
	[Address(RVA = "0x1FA7ECC", Offset = "0x1FA6ECC", VA = "0x1FA7ECC")]
	public UVAnimation Clone()
	{
		return null;
	}

	[Token(Token = "0x6000D84")]
	[Address(RVA = "0x1FA7F24", Offset = "0x1FA6F24", VA = "0x1FA7F24")]
	public UVAnimation()
	{
	}

	[Token(Token = "0x6000D85")]
	[Address(RVA = "0x1FA7F98", Offset = "0x1FA6F98", VA = "0x1FA7F98")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000D86")]
	[Address(RVA = "0x1FA7FB0", Offset = "0x1FA6FB0", VA = "0x1FA7FB0")]
	public void PlayInReverse()
	{
	}

	[Token(Token = "0x6000D87")]
	[Address(RVA = "0x1FA7D6C", Offset = "0x1FA6D6C", VA = "0x1FA7D6C")]
	public void SetStepDir(int dir)
	{
	}

	[Token(Token = "0x6000D88")]
	[Address(RVA = "0x1FA7FE4", Offset = "0x1FA6FE4", VA = "0x1FA7FE4")]
	public bool GetNextFrame(ref SPRITE_FRAME nextFrame)
	{
		return default(bool);
	}

	[Token(Token = "0x6000D89")]
	[Address(RVA = "0x1FA80FC", Offset = "0x1FA70FC", VA = "0x1FA80FC")]
	public SPRITE_FRAME GetCurrentFrame()
	{
		return default(SPRITE_FRAME);
	}

	[Token(Token = "0x6000D8A")]
	[Address(RVA = "0x1FA8144", Offset = "0x1FA7144", VA = "0x1FA8144")]
	public SPRITE_FRAME GetFrame(int frame)
	{
		return default(SPRITE_FRAME);
	}

	[Token(Token = "0x6000D8B")]
	[Address(RVA = "0x1FA8184", Offset = "0x1FA7184", VA = "0x1FA8184")]
	public SPRITE_FRAME[] BuildUVAnim(Vector2 start, Vector2 cellSize, int cols, int rows, int totalCells)
	{
		return null;
	}

	[Token(Token = "0x6000D8C")]
	[Address(RVA = "0x1FA8380", Offset = "0x1FA7380", VA = "0x1FA8380")]
	public SPRITE_FRAME[] BuildWrappedUVAnim(Vector2 start, Vector2 cellSize, int cols, int rows, int totalCells)
	{
		return null;
	}

	[Token(Token = "0x6000D8D")]
	[Address(RVA = "0x1FA8388", Offset = "0x1FA7388", VA = "0x1FA8388")]
	public SPRITE_FRAME[] BuildWrappedUVAnim(Vector2 start, Vector2 cellSize, int totalCells)
	{
		return null;
	}

	[Token(Token = "0x6000D8E")]
	[Address(RVA = "0x1FA84EC", Offset = "0x1FA74EC", VA = "0x1FA84EC")]
	public void SetAnim(SPRITE_FRAME[] anim)
	{
	}

	[Token(Token = "0x6000D8F")]
	[Address(RVA = "0x1FA8520", Offset = "0x1FA7520", VA = "0x1FA8520")]
	public void SetAnim(TextureAnim anim, int idx)
	{
	}

	[Token(Token = "0x6000D90")]
	[Address(RVA = "0x1FA8760", Offset = "0x1FA7760", VA = "0x1FA8760")]
	public void AppendAnim(SPRITE_FRAME[] anim)
	{
	}

	[Token(Token = "0x6000D91")]
	[Address(RVA = "0x1FA8818", Offset = "0x1FA7818", VA = "0x1FA8818")]
	public void SetCurrentFrame(int f)
	{
	}

	[Token(Token = "0x6000D92")]
	[Address(RVA = "0x1FA884C", Offset = "0x1FA784C", VA = "0x1FA884C")]
	public void SetPosition(float pos)
	{
	}

	[Token(Token = "0x6000D93")]
	[Address(RVA = "0x1FA8A04", Offset = "0x1FA7A04", VA = "0x1FA8A04")]
	public void SetClipPosition(float pos)
	{
	}

	[Token(Token = "0x6000D94")]
	[Address(RVA = "0x1FA7E98", Offset = "0x1FA6E98", VA = "0x1FA7E98")]
	protected void CalcLength()
	{
	}

	[Token(Token = "0x6000D95")]
	[Address(RVA = "0x1FA8A4C", Offset = "0x1FA7A4C", VA = "0x1FA8A4C")]
	public float GetLength()
	{
		return default(float);
	}

	[Token(Token = "0x6000D96")]
	[Address(RVA = "0x1FA8A54", Offset = "0x1FA7A54", VA = "0x1FA8A54")]
	public float GetDuration()
	{
		return default(float);
	}

	[Token(Token = "0x6000D97")]
	[Address(RVA = "0x1FA8A88", Offset = "0x1FA7A88", VA = "0x1FA8A88")]
	public int GetFrameCount()
	{
		return default(int);
	}

	[Token(Token = "0x6000D98")]
	[Address(RVA = "0x1FA8AA4", Offset = "0x1FA7AA4", VA = "0x1FA8AA4")]
	public int GetFramesDisplayed()
	{
		return default(int);
	}

	[Token(Token = "0x6000D99")]
	[Address(RVA = "0x1FA8AE0", Offset = "0x1FA7AE0", VA = "0x1FA8AE0")]
	public int GetCurPosition()
	{
		return default(int);
	}
}
[Serializable]
[Token(Token = "0x20000DF")]
public class UVAnimation_Auto : UVAnimation
{
	[Token(Token = "0x4000727")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public Vector2 start;

	[Token(Token = "0x4000728")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Vector2 pixelsToNextColumnAndRow;

	[Token(Token = "0x4000729")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int cols;

	[Token(Token = "0x400072A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int rows;

	[Token(Token = "0x400072B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int totalCells;

	[Token(Token = "0x6000D9A")]
	[Address(RVA = "0x1FA8AE8", Offset = "0x1FA7AE8", VA = "0x1FA8AE8")]
	public UVAnimation_Auto()
	{
	}

	[Token(Token = "0x6000D9B")]
	[Address(RVA = "0x1FA8AEC", Offset = "0x1FA7AEC", VA = "0x1FA8AEC")]
	public UVAnimation_Auto(UVAnimation_Auto anim)
	{
	}

	[Token(Token = "0x6000D9C")]
	[Address(RVA = "0x1FA8B34", Offset = "0x1FA7B34", VA = "0x1FA8B34")]
	public new UVAnimation_Auto Clone()
	{
		return null;
	}

	[Token(Token = "0x6000D9D")]
	[Address(RVA = "0x1FA8B8C", Offset = "0x1FA7B8C", VA = "0x1FA8B8C")]
	public SPRITE_FRAME[] BuildUVAnim(SpriteRoot s)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x20000E0")]
public class UVAnimation_Multi
{
	[Token(Token = "0x400072C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x400072D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int loopCycles;

	[Token(Token = "0x400072E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool loopReverse;

	[Token(Token = "0x400072F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float framerate;

	[Token(Token = "0x4000730")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public UVAnimation.ANIM_END_ACTION onAnimEnd;

	[Token(Token = "0x4000731")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UVAnimation_Auto[] clips;

	[Token(Token = "0x4000732")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public int index;

	[Token(Token = "0x4000733")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	protected int curClip;

	[Token(Token = "0x4000734")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected int stepDir;

	[Token(Token = "0x4000735")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	protected int numLoops;

	[Token(Token = "0x4000736")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected float duration;

	[Token(Token = "0x4000737")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	protected bool ret;

	[Token(Token = "0x4000738")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected int i;

	[Token(Token = "0x4000739")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	protected int framePos;

	[Token(Token = "0x1700019F")]
	public int StepDirection
	{
		[Token(Token = "0x6000DA2")]
		[Address(RVA = "0x1FA9018", Offset = "0x1FA8018", VA = "0x1FA9018")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000DA3")]
		[Address(RVA = "0x1FA9020", Offset = "0x1FA8020", VA = "0x1FA9020")]
		set
		{
		}
	}

	[Token(Token = "0x6000D9E")]
	[Address(RVA = "0x1FA8CEC", Offset = "0x1FA7CEC", VA = "0x1FA8CEC")]
	public UVAnimation_Multi()
	{
	}

	[Token(Token = "0x6000D9F")]
	[Address(RVA = "0x1FA8D68", Offset = "0x1FA7D68", VA = "0x1FA8D68")]
	public UVAnimation_Multi(UVAnimation_Multi anim)
	{
	}

	[Token(Token = "0x6000DA0")]
	[Address(RVA = "0x1FA8F8C", Offset = "0x1FA7F8C", VA = "0x1FA8F8C")]
	public UVAnimation_Multi Clone()
	{
		return null;
	}

	[Token(Token = "0x6000DA1")]
	[Address(RVA = "0x1FA8FE4", Offset = "0x1FA7FE4", VA = "0x1FA8FE4")]
	public UVAnimation_Auto GetCurrentClip()
	{
		return null;
	}

	[Token(Token = "0x6000DA4")]
	[Address(RVA = "0x1FA9028", Offset = "0x1FA8028", VA = "0x1FA9028")]
	public UVAnimation_Auto[] BuildUVAnim(SpriteRoot s)
	{
		return null;
	}

	[Token(Token = "0x6000DA5")]
	[Address(RVA = "0x1FA90A0", Offset = "0x1FA80A0", VA = "0x1FA90A0")]
	public bool GetNextFrame(ref SPRITE_FRAME nextFrame)
	{
		return default(bool);
	}

	[Token(Token = "0x6000DA6")]
	[Address(RVA = "0x1FA92DC", Offset = "0x1FA82DC", VA = "0x1FA92DC")]
	public SPRITE_FRAME GetCurrentFrame()
	{
		return default(SPRITE_FRAME);
	}

	[Token(Token = "0x6000DA7")]
	[Address(RVA = "0x1FA9340", Offset = "0x1FA8340", VA = "0x1FA9340")]
	public void AppendAnim(int index, SPRITE_FRAME[] anim)
	{
	}

	[Token(Token = "0x6000DA8")]
	[Address(RVA = "0x1FA9390", Offset = "0x1FA8390", VA = "0x1FA9390")]
	public void AppendClip(UVAnimation clip)
	{
	}

	[Token(Token = "0x6000DA9")]
	[Address(RVA = "0x1FA94D0", Offset = "0x1FA84D0", VA = "0x1FA94D0")]
	public void PlayInReverse()
	{
	}

	[Token(Token = "0x6000DAA")]
	[Address(RVA = "0x1FA95E0", Offset = "0x1FA85E0", VA = "0x1FA95E0")]
	public void SetAnim(int index, SPRITE_FRAME[] frames)
	{
	}

	[Token(Token = "0x6000DAB")]
	[Address(RVA = "0x1FA9644", Offset = "0x1FA8644", VA = "0x1FA9644")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000DAC")]
	[Address(RVA = "0x1FA96C0", Offset = "0x1FA86C0", VA = "0x1FA96C0")]
	public void SetPosition(float pos)
	{
	}

	[Token(Token = "0x6000DAD")]
	[Address(RVA = "0x1FA9788", Offset = "0x1FA8788", VA = "0x1FA9788")]
	public void SetAnimPosition(float pos)
	{
	}

	[Token(Token = "0x6000DAE")]
	[Address(RVA = "0x1FA8EC8", Offset = "0x1FA7EC8", VA = "0x1FA8EC8")]
	protected void CalcDuration()
	{
	}

	[Token(Token = "0x6000DAF")]
	[Address(RVA = "0x1FA99E8", Offset = "0x1FA89E8", VA = "0x1FA99E8")]
	public float GetDuration()
	{
		return default(float);
	}

	[Token(Token = "0x6000DB0")]
	[Address(RVA = "0x1FA9578", Offset = "0x1FA8578", VA = "0x1FA9578")]
	public int GetFrameCount()
	{
		return default(int);
	}

	[Token(Token = "0x6000DB1")]
	[Address(RVA = "0x1FA99F0", Offset = "0x1FA89F0", VA = "0x1FA99F0")]
	public int GetCurPosition()
	{
		return default(int);
	}

	[Token(Token = "0x6000DB2")]
	[Address(RVA = "0x1FA99F8", Offset = "0x1FA89F8", VA = "0x1FA99F8")]
	public int GetCurClipNum()
	{
		return default(int);
	}

	[Token(Token = "0x6000DB3")]
	[Address(RVA = "0x1FA9A00", Offset = "0x1FA8A00", VA = "0x1FA9A00")]
	public void SetCurClipNum(int index)
	{
	}
}
[Token(Token = "0x20000E1")]
[ExecuteInEditMode]
public abstract class SpriteBase : SpriteRoot, ISpriteAnimatable
{
	[Token(Token = "0x20000E2")]
	public delegate void AnimCompleteDelegate(SpriteBase sprite);

	[Token(Token = "0x20000E3")]
	public delegate void AnimFrameDelegate(SpriteBase sprite, int frame);

	[Token(Token = "0x400073A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	public bool playAnimOnStart;

	[Token(Token = "0x400073B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F9")]
	[HideInInspector]
	public bool crossfadeFrames;

	[Token(Token = "0x400073C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
	public int defaultAnim;

	[Token(Token = "0x400073D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	protected int curAnimIndex;

	[Token(Token = "0x400073E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	protected AnimCompleteDelegate animCompleteDelegate;

	[Token(Token = "0x400073F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	protected AnimFrameDelegate animFrameDelegate;

	[Token(Token = "0x4000740")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	protected float timeSinceLastFrame;

	[Token(Token = "0x4000741")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
	protected float timeBetweenAnimFrames;

	[Token(Token = "0x4000742")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	protected float framesToAdvance;

	[Token(Token = "0x4000743")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
	protected bool animating;

	[Token(Token = "0x4000744")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x225")]
	protected bool currentlyAnimating;

	[Token(Token = "0x4000745")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	protected SPRITE_FRAME nextFrameInfo;

	[Token(Token = "0x170001A0")]
	public bool Animating
	{
		[Token(Token = "0x6000DCD")]
		[Address(RVA = "0x1FAACF0", Offset = "0x1FA9CF0", VA = "0x1FAACF0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000DCE")]
		[Address(RVA = "0x1FAACF8", Offset = "0x1FA9CF8", VA = "0x1FAACF8")]
		set
		{
		}
	}

	[Token(Token = "0x170001A1")]
	public int CurAnimIndex
	{
		[Token(Token = "0x6000DCF")]
		[Address(RVA = "0x1FAAD14", Offset = "0x1FA9D14", VA = "0x1FAAD14")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000DD0")]
		[Address(RVA = "0x1FAAD1C", Offset = "0x1FA9D1C", VA = "0x1FAAD1C")]
		set
		{
		}
	}

	[Token(Token = "0x6000DB4")]
	[Address(RVA = "0x1FA9A08", Offset = "0x1FA8A08", VA = "0x1FA9A08", Slot = "12")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000DB5")]
	[Address(RVA = "0x1FA9C40", Offset = "0x1FA8C40", VA = "0x1FA9C40", Slot = "13")]
	public override void Start()
	{
	}

	[Token(Token = "0x6000DB6")]
	[Address(RVA = "0x1FAA018", Offset = "0x1FA9018", VA = "0x1FAA018", Slot = "15")]
	public override void Clear()
	{
	}

	[Token(Token = "0x6000DB7")]
	[Address(RVA = "0x1FAA0AC", Offset = "0x1FA90AC", VA = "0x1FAA0AC", Slot = "18")]
	public override void Delete()
	{
	}

	[Token(Token = "0x6000DB8")]
	[Address(RVA = "0x1FAA228", Offset = "0x1FA9228", VA = "0x1FAA228", Slot = "20")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000DB9")]
	[Address(RVA = "0x1FAA2F4", Offset = "0x1FA92F4", VA = "0x1FAA2F4", Slot = "19")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000DBA")]
	[Address(RVA = "0x1FAA494", Offset = "0x1FA9494", VA = "0x1FAA494", Slot = "16")]
	public override void Copy(SpriteRoot s)
	{
	}

	[Token(Token = "0x6000DBB")]
	[Address(RVA = "0x1FAA984", Offset = "0x1FA9984", VA = "0x1FAA984", Slot = "37")]
	public override void Hide(bool tf)
	{
	}

	[Token(Token = "0x6000DBC")]
	[Address(RVA = "0x1FAAAA0", Offset = "0x1FA9AA0", VA = "0x1FAAAA0")]
	public void SetAnimCompleteDelegate(AnimCompleteDelegate del)
	{
	}

	[Token(Token = "0x6000DBD")]
	[Address(RVA = "0x1FAAAA8", Offset = "0x1FA9AA8", VA = "0x1FAAAA8")]
	public void SetAnimFrameDelegate(AnimFrameDelegate del)
	{
	}

	[Token(Token = "0x6000DBE")]
	[Address(RVA = "0x1FAAAB0", Offset = "0x1FA9AB0", VA = "0x1FAAAB0")]
	public void SetSpriteResizedDelegate(SpriteResizedDelegate del)
	{
	}

	[Token(Token = "0x6000DBF")]
	[Address(RVA = "0x1FAAAB8", Offset = "0x1FA9AB8", VA = "0x1FAAAB8")]
	public void AddSpriteResizedDelegate(SpriteResizedDelegate del)
	{
	}

	[Token(Token = "0x6000DC0")]
	[Address(RVA = "0x1FAAB38", Offset = "0x1FA9B38", VA = "0x1FAAB38")]
	public void RemoveSpriteresizedDelegate(SpriteResizedDelegate del)
	{
	}

	[Token(Token = "0x6000DC1")]
	[Address(RVA = "0x1FAABB8", Offset = "0x1FA9BB8", VA = "0x1FAABB8", Slot = "56")]
	public virtual bool StepAnim(float time)
	{
		return default(bool);
	}

	[Token(Token = "0x6000DC2")]
	[Address(RVA = "0x1FAABC0", Offset = "0x1FA9BC0", VA = "0x1FAABC0", Slot = "57")]
	public virtual void PlayAnim(int index)
	{
	}

	[Token(Token = "0x6000DC3")]
	[Address(RVA = "0x1FAABC4", Offset = "0x1FA9BC4", VA = "0x1FAABC4", Slot = "58")]
	public virtual void PlayAnim(string name)
	{
	}

	[Token(Token = "0x6000DC4")]
	[Address(RVA = "0x1FAABC8", Offset = "0x1FA9BC8", VA = "0x1FAABC8", Slot = "59")]
	public virtual void PlayAnimInReverse(int index)
	{
	}

	[Token(Token = "0x6000DC5")]
	[Address(RVA = "0x1FAABCC", Offset = "0x1FA9BCC", VA = "0x1FAABCC", Slot = "60")]
	public virtual void PlayAnimInReverse(string name)
	{
	}

	[Token(Token = "0x6000DC6")]
	[Address(RVA = "0x1FAABD0", Offset = "0x1FA9BD0", VA = "0x1FAABD0")]
	public void SetFramerate(float fps)
	{
	}

	[Token(Token = "0x6000DC7")]
	[Address(RVA = "0x1FAAA84", Offset = "0x1FA9A84", VA = "0x1FAAA84")]
	public void PauseAnim()
	{
	}

	[Token(Token = "0x6000DC8")]
	[Address(RVA = "0x1FAABE0", Offset = "0x1FA9BE0", VA = "0x1FAABE0", Slot = "61")]
	public virtual void StopAnim()
	{
	}

	[Token(Token = "0x6000DC9")]
	[Address(RVA = "0x1FAABE4", Offset = "0x1FA9BE4", VA = "0x1FAABE4")]
	public void RevertToStatic()
	{
	}

	[Token(Token = "0x6000DCA")]
	protected abstract void AddToAnimatedList();

	[Token(Token = "0x6000DCB")]
	protected abstract void RemoveFromAnimatedList();

	[Token(Token = "0x6000DCC")]
	[Address(RVA = "0x1FAACE8", Offset = "0x1FA9CE8", VA = "0x1FAACE8")]
	public bool IsAnimating()
	{
		return default(bool);
	}

	[Token(Token = "0x6000DD1")]
	[Address(RVA = "0x1FAAD24", Offset = "0x1FA9D24", VA = "0x1FAAD24")]
	protected SpriteBase()
	{
	}
}
[Token(Token = "0x20000E4")]
public class SpriteChar
{
	[Token(Token = "0x4000746")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x4000747")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Rect UVs;

	[Token(Token = "0x4000748")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float xOffset;

	[Token(Token = "0x4000749")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float yOffset;

	[Token(Token = "0x400074A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float xAdvance;

	[Token(Token = "0x400074B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Dictionary<int, float> kernings;

	[Token(Token = "0x400074C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Dictionary<int, float> origKernings;

	[Token(Token = "0x6000DDA")]
	[Address(RVA = "0x1FAB090", Offset = "0x1FAA090", VA = "0x1FAB090")]
	public float GetKerning(int prevChar)
	{
		return default(float);
	}

	[Token(Token = "0x6000DDB")]
	[Address(RVA = "0x1FAB104", Offset = "0x1FAA104", VA = "0x1FAB104")]
	public SpriteChar()
	{
	}
}
[Token(Token = "0x20000E5")]
public class SpriteFont
{
	[Token(Token = "0x20000E6")]
	protected delegate void ParserDel(string line);

	[Token(Token = "0x400074D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public TextAsset fontDef;

	[Token(Token = "0x400074E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected Dictionary<int, int> charMap;

	[Token(Token = "0x400074F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected SpriteChar[] chars;

	[Token(Token = "0x4000750")]
	protected const float bleedCompensation = 0f;

	[Token(Token = "0x4000751")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected Vector2 bleedCompUV;

	[Token(Token = "0x4000752")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected Vector2 bleedCompUVMax;

	[Token(Token = "0x4000753")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected int lineHeight;

	[Token(Token = "0x4000754")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	protected int baseHeight;

	[Token(Token = "0x4000755")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected int texWidth;

	[Token(Token = "0x4000756")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	protected int texHeight;

	[Token(Token = "0x4000757")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected string face;

	[Token(Token = "0x4000758")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected int pxSize;

	[Token(Token = "0x4000759")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	protected float charSpacing;

	[Token(Token = "0x400075A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int kerningsCount;

	[Token(Token = "0x170001A2")]
	public int LineHeight
	{
		[Token(Token = "0x6000DDC")]
		[Address(RVA = "0x1FAB10C", Offset = "0x1FAA10C", VA = "0x1FAB10C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000DDD")]
		[Address(RVA = "0x1FAB114", Offset = "0x1FAA114", VA = "0x1FAB114")]
		set
		{
		}
	}

	[Token(Token = "0x170001A3")]
	public int BaseHeight
	{
		[Token(Token = "0x6000DDE")]
		[Address(RVA = "0x1FAB11C", Offset = "0x1FAA11C", VA = "0x1FAB11C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170001A4")]
	public int PixelSize
	{
		[Token(Token = "0x6000DDF")]
		[Address(RVA = "0x1FAB124", Offset = "0x1FAA124", VA = "0x1FAB124")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170001A5")]
	public float CharacterSpacing
	{
		[Token(Token = "0x6000DE0")]
		[Address(RVA = "0x1FAB12C", Offset = "0x1FAA12C", VA = "0x1FAB12C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000DE1")]
		[Address(RVA = "0x1FAB134", Offset = "0x1FAA134", VA = "0x1FAB134")]
		set
		{
		}
	}

	[Token(Token = "0x6000DE2")]
	[Address(RVA = "0x1FA64F4", Offset = "0x1FA54F4", VA = "0x1FA64F4")]
	public SpriteFont(TextAsset def)
	{
	}

	[Token(Token = "0x6000DE3")]
	[Address(RVA = "0x1FAB364", Offset = "0x1FAA364", VA = "0x1FAB364")]
	public void Load(TextAsset def)
	{
	}

	[Token(Token = "0x6000DE4")]
	[Address(RVA = "0x1FAB788", Offset = "0x1FAA788", VA = "0x1FAB788")]
	private int ParseSection(string tag, string[] lines, ParserDel parser, int pos)
	{
		return default(int);
	}

	[Token(Token = "0x6000DE5")]
	[Address(RVA = "0x1FAC0D4", Offset = "0x1FAB0D4", VA = "0x1FAC0D4")]
	private int FindField(string label, string[] fields, int pos, bool logError)
	{
		return default(int);
	}

	[Token(Token = "0x6000DE6")]
	[Address(RVA = "0x1FAC28C", Offset = "0x1FAB28C", VA = "0x1FAC28C")]
	private int FindField(string label, string[] fields, int pos)
	{
		return default(int);
	}

	[Token(Token = "0x6000DE7")]
	[Address(RVA = "0x1FAC294", Offset = "0x1FAB294", VA = "0x1FAC294")]
	private int FindFieldOptional(string label, string[] fields, int pos)
	{
		return default(int);
	}

	[Token(Token = "0x6000DE8")]
	[Address(RVA = "0x1FAC29C", Offset = "0x1FAB29C", VA = "0x1FAC29C")]
	private void HeaderParser(string line)
	{
	}

	[Token(Token = "0x6000DE9")]
	[Address(RVA = "0x1FAC4B0", Offset = "0x1FAB4B0", VA = "0x1FAC4B0")]
	private void CommonParser(string line)
	{
	}

	[Token(Token = "0x6000DEA")]
	[Address(RVA = "0x1FAC774", Offset = "0x1FAB774", VA = "0x1FAC774")]
	private void CharCountParser(string line)
	{
	}

	[Token(Token = "0x6000DEB")]
	[Address(RVA = "0x1FAB844", Offset = "0x1FAA844", VA = "0x1FAB844")]
	private bool CharParser(string line, int charNum)
	{
		return default(bool);
	}

	[Token(Token = "0x6000DEC")]
	[Address(RVA = "0x1FAC8D4", Offset = "0x1FAB8D4", VA = "0x1FAC8D4")]
	private void KerningCountParser(string line)
	{
	}

	[Token(Token = "0x6000DED")]
	[Address(RVA = "0x1FABDD8", Offset = "0x1FAADD8", VA = "0x1FABDD8")]
	private bool KerningParser(string line)
	{
		return default(bool);
	}

	[Token(Token = "0x6000DEE")]
	[Address(RVA = "0x1FAC97C", Offset = "0x1FAB97C", VA = "0x1FAC97C")]
	public SpriteChar GetSpriteChar(char ch)
	{
		return null;
	}

	[Token(Token = "0x6000DEF")]
	[Address(RVA = "0x1FACA18", Offset = "0x1FABA18", VA = "0x1FACA18")]
	public bool ContainsCharacter(char ch)
	{
		return default(bool);
	}

	[Token(Token = "0x6000DF0")]
	[Address(RVA = "0x1FACA70", Offset = "0x1FABA70", VA = "0x1FACA70")]
	public float GetWidth(string str)
	{
		return default(float);
	}

	[Token(Token = "0x6000DF1")]
	[Address(RVA = "0x1FACA78", Offset = "0x1FABA78", VA = "0x1FACA78")]
	public float GetWidth(string str, float spacingCoef)
	{
		return default(float);
	}

	[Token(Token = "0x6000DF2")]
	[Address(RVA = "0x1FACB78", Offset = "0x1FABB78", VA = "0x1FACB78")]
	public float GetWidth(string str, int start, int end)
	{
		return default(float);
	}

	[Token(Token = "0x6000DF3")]
	[Address(RVA = "0x1FACB80", Offset = "0x1FABB80", VA = "0x1FACB80")]
	public float GetWidth(string str, int start, int end, float spacingCoef)
	{
		return default(float);
	}

	[Token(Token = "0x6000DF4")]
	[Address(RVA = "0x1FACCA0", Offset = "0x1FABCA0", VA = "0x1FACCA0")]
	public float GetWidth(StringBuilder sb, int start, int end)
	{
		return default(float);
	}

	[Token(Token = "0x6000DF5")]
	[Address(RVA = "0x1FACCA8", Offset = "0x1FABCA8", VA = "0x1FACCA8")]
	public float GetWidth(StringBuilder sb, int start, int end, float spacingCoef)
	{
		return default(float);
	}

	[Token(Token = "0x6000DF6")]
	[Address(RVA = "0x1FACDE0", Offset = "0x1FABDE0", VA = "0x1FACDE0")]
	public float GetWidth(char prevChar, char c)
	{
		return default(float);
	}

	[Token(Token = "0x6000DF7")]
	[Address(RVA = "0x1FACE1C", Offset = "0x1FABE1C", VA = "0x1FACE1C")]
	public float GetAdvance(char c)
	{
		return default(float);
	}

	[Token(Token = "0x6000DF8")]
	[Address(RVA = "0x1FACE3C", Offset = "0x1FABE3C", VA = "0x1FACE3C")]
	public string RemoveUnsupportedCharacters(string str)
	{
		return null;
	}
}
[Token(Token = "0x20000E7")]
public class SpriteMesh : ISpriteMesh
{
	[Token(Token = "0x400075B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected SpriteRoot m_sprite;

	[Token(Token = "0x400075C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected MeshFilter meshFilter;

	[Token(Token = "0x400075D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected MeshRenderer meshRenderer;

	[Token(Token = "0x400075E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected Mesh m_mesh;

	[Token(Token = "0x400075F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected Texture m_texture;

	[Token(Token = "0x4000760")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected Vector3[] m_vertices;

	[Token(Token = "0x4000761")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected Color[] m_colors;

	[Token(Token = "0x4000762")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected Vector2[] m_uvs;

	[Token(Token = "0x4000763")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected Vector2[] m_uvs2;

	[Token(Token = "0x4000764")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected int[] m_faces;

	[Token(Token = "0x4000765")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected bool m_useUV2;

	[Token(Token = "0x170001A6")]
	public virtual SpriteRoot sprite
	{
		[Token(Token = "0x6000DFD")]
		[Address(RVA = "0x1FAD088", Offset = "0x1FAC088", VA = "0x1FAD088", Slot = "19")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000DFE")]
		[Address(RVA = "0x1FAD090", Offset = "0x1FAC090", VA = "0x1FAD090", Slot = "20")]
		set
		{
		}
	}

	[Token(Token = "0x170001A7")]
	public virtual Texture texture
	{
		[Token(Token = "0x6000DFF")]
		[Address(RVA = "0x1FAD678", Offset = "0x1FAC678", VA = "0x1FAD678", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001A8")]
	public virtual Material material
	{
		[Token(Token = "0x6000E00")]
		[Address(RVA = "0x1FAD680", Offset = "0x1FAC680", VA = "0x1FAD680", Slot = "22")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000E01")]
		[Address(RVA = "0x1FAD69C", Offset = "0x1FAC69C", VA = "0x1FAD69C", Slot = "23")]
		set
		{
		}
	}

	[Token(Token = "0x170001A9")]
	public virtual Vector3[] vertices
	{
		[Token(Token = "0x6000E02")]
		[Address(RVA = "0x1FAD838", Offset = "0x1FAC838", VA = "0x1FAD838", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001AA")]
	public virtual Vector2[] uvs
	{
		[Token(Token = "0x6000E03")]
		[Address(RVA = "0x1FAD840", Offset = "0x1FAC840", VA = "0x1FAD840", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001AB")]
	public virtual Vector2[] uvs2
	{
		[Token(Token = "0x6000E04")]
		[Address(RVA = "0x1FAD848", Offset = "0x1FAC848", VA = "0x1FAD848", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001AC")]
	public virtual bool UseUV2
	{
		[Token(Token = "0x6000E05")]
		[Address(RVA = "0x1FAD850", Offset = "0x1FAC850", VA = "0x1FAD850", Slot = "27")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000E06")]
		[Address(RVA = "0x1FAD858", Offset = "0x1FAC858", VA = "0x1FAD858", Slot = "28")]
		set
		{
		}
	}

	[Token(Token = "0x170001AD")]
	public virtual Mesh mesh
	{
		[Token(Token = "0x6000E07")]
		[Address(RVA = "0x1FAD864", Offset = "0x1FAC864", VA = "0x1FAD864", Slot = "29")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000E08")]
		[Address(RVA = "0x1FAD9B4", Offset = "0x1FAC9B4", VA = "0x1FAD9B4", Slot = "30")]
		set
		{
		}
	}

	[Token(Token = "0x6000E09")]
	[Address(RVA = "0x1FAD9BC", Offset = "0x1FAC9BC", VA = "0x1FAD9BC", Slot = "31")]
	public virtual void Init()
	{
	}

	[Token(Token = "0x6000E0A")]
	[Address(RVA = "0x1FAD8D8", Offset = "0x1FAC8D8", VA = "0x1FAD8D8")]
	protected void CreateMesh()
	{
	}

	[Token(Token = "0x6000E0B")]
	[Address(RVA = "0x1FADDBC", Offset = "0x1FACDBC", VA = "0x1FADDBC", Slot = "32")]
	public virtual void UpdateVerts()
	{
	}

	[Token(Token = "0x6000E0C")]
	[Address(RVA = "0x1FADE50", Offset = "0x1FACE50", VA = "0x1FADE50", Slot = "33")]
	public virtual void UpdateUVs()
	{
	}

	[Token(Token = "0x6000E0D")]
	[Address(RVA = "0x1FADEF4", Offset = "0x1FACEF4", VA = "0x1FADEF4", Slot = "34")]
	public virtual void UpdateColors(Color color)
	{
	}

	[Token(Token = "0x6000E0E")]
	[Address(RVA = "0x1FAE014", Offset = "0x1FAD014", VA = "0x1FAE014", Slot = "35")]
	public virtual void Hide(bool tf)
	{
	}

	[Token(Token = "0x6000E0F")]
	[Address(RVA = "0x1FAE0B0", Offset = "0x1FAD0B0", VA = "0x1FAE0B0", Slot = "36")]
	public virtual bool IsHidden()
	{
		return default(bool);
	}

	[Token(Token = "0x6000E10")]
	[Address(RVA = "0x1FAE13C", Offset = "0x1FAD13C", VA = "0x1FAE13C")]
	public void SetPersistent()
	{
	}

	[Token(Token = "0x6000E11")]
	[Address(RVA = "0x1FAE1CC", Offset = "0x1FAD1CC", VA = "0x1FAE1CC", Slot = "37")]
	public virtual void SetWindingOrder(SpriteRoot.WINDING_ORDER winding)
	{
	}

	[Token(Token = "0x6000E12")]
	[Address(RVA = "0x1FAE2BC", Offset = "0x1FAD2BC", VA = "0x1FAE2BC")]
	public SpriteMesh()
	{
	}
}
[Token(Token = "0x20000E8")]
public class SpriteMesh_Managed : ISpriteMesh, IEZLinkedListItem<SpriteMesh_Managed>
{
	[Token(Token = "0x4000766")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected SpriteRoot m_sprite;

	[Token(Token = "0x4000767")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected bool hidden;

	[Token(Token = "0x4000768")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int index;

	[Token(Token = "0x4000769")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int drawLayer;

	[Token(Token = "0x400076A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SpriteManager m_manager;

	[Token(Token = "0x400076B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public SpriteMesh_Managed m_next;

	[Token(Token = "0x400076C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public SpriteMesh_Managed m_prev;

	[Token(Token = "0x400076D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected Vector3[] m_vertices;

	[Token(Token = "0x400076E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected Vector2[] m_uvs;

	[Token(Token = "0x400076F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected Vector2[] m_uvs2;

	[Token(Token = "0x4000770")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected bool m_useUV2;

	[Token(Token = "0x4000771")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected Material m_material;

	[Token(Token = "0x4000772")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected Texture m_texture;

	[Token(Token = "0x4000773")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected Vector3[] meshVerts;

	[Token(Token = "0x4000774")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected Vector2[] meshUVs;

	[Token(Token = "0x4000775")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected Vector2[] meshUVs2;

	[Token(Token = "0x4000776")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected Color[] meshColors;

	[Token(Token = "0x4000777")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public int mv1;

	[Token(Token = "0x4000778")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public int mv2;

	[Token(Token = "0x4000779")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public int mv3;

	[Token(Token = "0x400077A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public int mv4;

	[Token(Token = "0x400077B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public int uv1;

	[Token(Token = "0x400077C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public int uv2;

	[Token(Token = "0x400077D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public int uv3;

	[Token(Token = "0x400077E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public int uv4;

	[Token(Token = "0x400077F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public int cv1;

	[Token(Token = "0x4000780")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public int cv2;

	[Token(Token = "0x4000781")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public int cv3;

	[Token(Token = "0x4000782")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public int cv4;

	[Token(Token = "0x170001AE")]
	public SpriteManager manager
	{
		[Token(Token = "0x6000E15")]
		[Address(RVA = "0x1FAE3B4", Offset = "0x1FAD3B4", VA = "0x1FAE3B4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000E16")]
		[Address(RVA = "0x1FAE3BC", Offset = "0x1FAD3BC", VA = "0x1FAE3BC")]
		set
		{
		}
	}

	[Token(Token = "0x170001AF")]
	public virtual SpriteRoot sprite
	{
		[Token(Token = "0x6000E17")]
		[Address(RVA = "0x1FAE490", Offset = "0x1FAD490", VA = "0x1FAE490", Slot = "23")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000E18")]
		[Address(RVA = "0x1FAE498", Offset = "0x1FAD498", VA = "0x1FAE498", Slot = "24")]
		set
		{
		}
	}

	[Token(Token = "0x170001B0")]
	public virtual Texture texture
	{
		[Token(Token = "0x6000E19")]
		[Address(RVA = "0x1FAE548", Offset = "0x1FAD548", VA = "0x1FAE548", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001B1")]
	public virtual Material material
	{
		[Token(Token = "0x6000E1A")]
		[Address(RVA = "0x1FAE550", Offset = "0x1FAD550", VA = "0x1FAE550", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001B2")]
	public virtual Vector3[] vertices
	{
		[Token(Token = "0x6000E1B")]
		[Address(RVA = "0x1FAE558", Offset = "0x1FAD558", VA = "0x1FAE558", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001B3")]
	public virtual Vector2[] uvs
	{
		[Token(Token = "0x6000E1C")]
		[Address(RVA = "0x1FAE560", Offset = "0x1FAD560", VA = "0x1FAE560", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001B4")]
	public virtual Vector2[] uvs2
	{
		[Token(Token = "0x6000E1D")]
		[Address(RVA = "0x1FAE568", Offset = "0x1FAD568", VA = "0x1FAE568", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001B5")]
	public virtual bool UseUV2
	{
		[Token(Token = "0x6000E1E")]
		[Address(RVA = "0x1FAE570", Offset = "0x1FAD570", VA = "0x1FAE570", Slot = "30")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000E1F")]
		[Address(RVA = "0x1FAE578", Offset = "0x1FAD578", VA = "0x1FAE578", Slot = "31")]
		set
		{
		}
	}

	[Token(Token = "0x170001B6")]
	public SpriteMesh_Managed prev
	{
		[Token(Token = "0x6000E26")]
		[Address(RVA = "0x1FAECD0", Offset = "0x1FADCD0", VA = "0x1FAECD0", Slot = "19")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000E27")]
		[Address(RVA = "0x1FAECD8", Offset = "0x1FADCD8", VA = "0x1FAECD8", Slot = "20")]
		set
		{
		}
	}

	[Token(Token = "0x170001B7")]
	public SpriteMesh_Managed next
	{
		[Token(Token = "0x6000E28")]
		[Address(RVA = "0x1FAECE0", Offset = "0x1FADCE0", VA = "0x1FAECE0", Slot = "21")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000E29")]
		[Address(RVA = "0x1FAECE8", Offset = "0x1FADCE8", VA = "0x1FAECE8", Slot = "22")]
		set
		{
		}
	}

	[Token(Token = "0x6000E13")]
	[Address(RVA = "0x1FAE3A0", Offset = "0x1FAD3A0", VA = "0x1FAE3A0")]
	public void SetBuffers(Vector3[] verts, Vector2[] uvs, Vector2[] uvs2, Color[] cols)
	{
	}

	[Token(Token = "0x6000E14")]
	[Address(RVA = "0x1FAE3AC", Offset = "0x1FAD3AC", VA = "0x1FAE3AC")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000E20")]
	[Address(RVA = "0x1FAE584", Offset = "0x1FAD584", VA = "0x1FAE584", Slot = "32")]
	public virtual void Init()
	{
	}

	[Token(Token = "0x6000E21")]
	[Address(RVA = "0x1FAE714", Offset = "0x1FAD714", VA = "0x1FAE714", Slot = "33")]
	public virtual void UpdateVerts()
	{
	}

	[Token(Token = "0x6000E22")]
	[Address(RVA = "0x1FAE850", Offset = "0x1FAD850", VA = "0x1FAE850", Slot = "34")]
	public virtual void UpdateUVs()
	{
	}

	[Token(Token = "0x6000E23")]
	[Address(RVA = "0x1FAEAB8", Offset = "0x1FADAB8", VA = "0x1FAEAB8", Slot = "35")]
	public virtual void UpdateColors(Color color)
	{
	}

	[Token(Token = "0x6000E24")]
	[Address(RVA = "0x1FAEB68", Offset = "0x1FADB68", VA = "0x1FAEB68", Slot = "36")]
	public virtual void Hide(bool tf)
	{
	}

	[Token(Token = "0x6000E25")]
	[Address(RVA = "0x1FAECC8", Offset = "0x1FADCC8", VA = "0x1FAECC8", Slot = "37")]
	public virtual bool IsHidden()
	{
		return default(bool);
	}

	[Token(Token = "0x6000E2A")]
	[Address(RVA = "0x1FAECF0", Offset = "0x1FADCF0", VA = "0x1FAECF0")]
	public SpriteMesh_Managed()
	{
	}
}
[Token(Token = "0x20000E9")]
public delegate UnityEngine.Object AssetLoaderDelegate(string path, Type type);
[Serializable]
[Token(Token = "0x20000EA")]
public struct SPRITE_FRAME
{
	[Token(Token = "0x4000783")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Rect uvs;

	[Token(Token = "0x4000784")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector2 scaleFactor;

	[Token(Token = "0x4000785")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector2 topLeftOffset;

	[Token(Token = "0x4000786")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector2 bottomRightOffset;

	[Token(Token = "0x6000E2F")]
	[Address(RVA = "0x1FA8360", Offset = "0x1FA7360", VA = "0x1FA8360")]
	public SPRITE_FRAME(float dummy)
	{
	}

	[Token(Token = "0x6000E30")]
	[Address(RVA = "0x1FAEE6C", Offset = "0x1FADE6C", VA = "0x1FAEE6C")]
	public void Copy(CSpriteFrame f)
	{
	}
}
[Serializable]
[Token(Token = "0x20000EB")]
public class SpriteState
{
	[Token(Token = "0x4000787")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x4000788")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public string imgPath;

	[Token(Token = "0x4000789")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public CSpriteFrame frameInfo;

	[Token(Token = "0x6000E31")]
	[Address(RVA = "0x1FAEEA0", Offset = "0x1FADEA0", VA = "0x1FAEEA0")]
	public SpriteState(string n, string p)
	{
	}
}
[Serializable]
[Token(Token = "0x20000EC")]
public class CSpriteFrame
{
	[Token(Token = "0x400078A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Rect uvs;

	[Token(Token = "0x400078B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector2 scaleFactor;

	[Token(Token = "0x400078C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 topLeftOffset;

	[Token(Token = "0x400078D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector2 bottomRightOffset;

	[Token(Token = "0x6000E32")]
	[Address(RVA = "0x1FAEECC", Offset = "0x1FADECC", VA = "0x1FAEECC")]
	public void Copy(SPRITE_FRAME f)
	{
	}

	[Token(Token = "0x6000E33")]
	[Address(RVA = "0x1FAEEF0", Offset = "0x1FADEF0", VA = "0x1FAEEF0")]
	public void Copy(CSpriteFrame f)
	{
	}

	[Token(Token = "0x6000E34")]
	[Address(RVA = "0x1FA874C", Offset = "0x1FA774C", VA = "0x1FA874C")]
	public SPRITE_FRAME ToStruct()
	{
		return default(SPRITE_FRAME);
	}

	[Token(Token = "0x6000E35")]
	[Address(RVA = "0x1FAEF24", Offset = "0x1FADF24", VA = "0x1FAEF24")]
	public CSpriteFrame()
	{
	}

	[Token(Token = "0x6000E36")]
	[Address(RVA = "0x1FAEF48", Offset = "0x1FADF48", VA = "0x1FAEF48")]
	public CSpriteFrame(CSpriteFrame f)
	{
	}

	[Token(Token = "0x6000E37")]
	[Address(RVA = "0x1FAEFB0", Offset = "0x1FADFB0", VA = "0x1FAEFB0")]
	public CSpriteFrame(SPRITE_FRAME f)
	{
	}
}
[Token(Token = "0x20000ED")]
public interface IEZLinkedListItem<T>
{
	[Token(Token = "0x170001B8")]
	T prev
	{
		[Token(Token = "0x6000E38")]
		get;
		[Token(Token = "0x6000E39")]
		set;
	}

	[Token(Token = "0x170001B9")]
	T next
	{
		[Token(Token = "0x6000E3A")]
		get;
		[Token(Token = "0x6000E3B")]
		set;
	}
}
[Token(Token = "0x20000EE")]
public class EZLinkedListIterator<T> where T : IEZLinkedListItem<T>
{
	[Token(Token = "0x400078E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected T cur;

	[Token(Token = "0x400078F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected EZLinkedList<T> list;

	[Token(Token = "0x170001BA")]
	public T Current
	{
		[Token(Token = "0x6000E3C")]
		get
		{
			return (T)null;
		}
		[Token(Token = "0x6000E3D")]
		set
		{
		}
	}

	[Token(Token = "0x170001BB")]
	public bool Done
	{
		[Token(Token = "0x6000E40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000E3E")]
	public bool Begin(EZLinkedList<T> l)
	{
		return default(bool);
	}

	[Token(Token = "0x6000E3F")]
	public void End()
	{
	}

	[Token(Token = "0x6000E41")]
	public bool Next()
	{
		return default(bool);
	}

	[Token(Token = "0x6000E42")]
	public bool NextNoRemove()
	{
		return default(bool);
	}

	[Token(Token = "0x6000E43")]
	public EZLinkedListIterator()
	{
	}
}
[Token(Token = "0x20000EF")]
public class EZLinkedListNode<T> : IEZLinkedListItem<EZLinkedListNode<T>>
{
	[Token(Token = "0x4000790")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public T val;

	[Token(Token = "0x4000791")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private EZLinkedListNode<T> m_prev;

	[Token(Token = "0x4000792")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private EZLinkedListNode<T> m_next;

	[Token(Token = "0x170001BC")]
	public EZLinkedListNode<T> prev
	{
		[Token(Token = "0x6000E45")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000E46")]
		set
		{
		}
	}

	[Token(Token = "0x170001BD")]
	public EZLinkedListNode<T> next
	{
		[Token(Token = "0x6000E47")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000E48")]
		set
		{
		}
	}

	[Token(Token = "0x6000E44")]
	public EZLinkedListNode(T v)
	{
	}
}
[Token(Token = "0x20000F0")]
public class EZLinkedList<T> where T : IEZLinkedListItem<T>
{
	[Token(Token = "0x4000793")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private List<EZLinkedListIterator<T>> iters;

	[Token(Token = "0x4000794")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private List<EZLinkedListIterator<T>> freeIters;

	[Token(Token = "0x4000795")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected T head;

	[Token(Token = "0x4000796")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected T cur;

	[Token(Token = "0x4000797")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected T nextItem;

	[Token(Token = "0x4000798")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected int count;

	[Token(Token = "0x170001BE")]
	public int Count
	{
		[Token(Token = "0x6000E49")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170001BF")]
	public bool Empty
	{
		[Token(Token = "0x6000E4A")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001C0")]
	public T Head
	{
		[Token(Token = "0x6000E4B")]
		get
		{
			return (T)null;
		}
	}

	[Token(Token = "0x170001C1")]
	public T Current
	{
		[Token(Token = "0x6000E4C")]
		get
		{
			return (T)null;
		}
		[Token(Token = "0x6000E4D")]
		set
		{
		}
	}

	[Token(Token = "0x6000E4E")]
	public EZLinkedListIterator<T> Begin()
	{
		return null;
	}

	[Token(Token = "0x6000E4F")]
	public void End(EZLinkedListIterator<T> it)
	{
	}

	[Token(Token = "0x6000E50")]
	public bool Rewind()
	{
		return default(bool);
	}

	[Token(Token = "0x6000E51")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Token(Token = "0x6000E52")]
	public void Add(T item)
	{
	}

	[Token(Token = "0x6000E53")]
	public void Remove(T item)
	{
	}

	[Token(Token = "0x6000E54")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000E55")]
	public EZLinkedList()
	{
	}
}
[Token(Token = "0x20000F1")]
public struct Rect3D
{
	[Token(Token = "0x4000799")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Vector3 m_tl;

	[Token(Token = "0x400079A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private Vector3 m_tr;

	[Token(Token = "0x400079B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 m_bl;

	[Token(Token = "0x400079C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 m_br;

	[Token(Token = "0x400079D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float m_width;

	[Token(Token = "0x400079E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float m_height;

	[Token(Token = "0x170001C2")]
	public Vector3 topLeft
	{
		[Token(Token = "0x6000E56")]
		[Address(RVA = "0x1FAF000", Offset = "0x1FAE000", VA = "0x1FAF000")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x170001C3")]
	public Vector3 topRight
	{
		[Token(Token = "0x6000E57")]
		[Address(RVA = "0x1FAF00C", Offset = "0x1FAE00C", VA = "0x1FAF00C")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x170001C4")]
	public Vector3 bottomLeft
	{
		[Token(Token = "0x6000E58")]
		[Address(RVA = "0x1FAF018", Offset = "0x1FAE018", VA = "0x1FAF018")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x170001C5")]
	public Vector3 bottomRight
	{
		[Token(Token = "0x6000E59")]
		[Address(RVA = "0x1FAF024", Offset = "0x1FAE024", VA = "0x1FAF024")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x170001C6")]
	public float width
	{
		[Token(Token = "0x6000E5A")]
		[Address(RVA = "0x1FAF030", Offset = "0x1FAE030", VA = "0x1FAF030")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170001C7")]
	public float height
	{
		[Token(Token = "0x6000E5B")]
		[Address(RVA = "0x1FAF0E4", Offset = "0x1FAE0E4", VA = "0x1FAF0E4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000E5C")]
	[Address(RVA = "0x1FAF198", Offset = "0x1FAE198", VA = "0x1FAF198")]
	public void FromPoints(Vector3 tl, Vector3 tr, Vector3 bl)
	{
	}

	[Token(Token = "0x6000E5D")]
	[Address(RVA = "0x1FAF1E0", Offset = "0x1FAE1E0", VA = "0x1FAF1E0")]
	public Rect3D(Vector3 tl, Vector3 tr, Vector3 bl)
	{
	}

	[Token(Token = "0x6000E5E")]
	[Address(RVA = "0x1FAF2E8", Offset = "0x1FAE2E8", VA = "0x1FAF2E8")]
	public Rect3D(Rect r)
	{
	}

	[Token(Token = "0x6000E5F")]
	[Address(RVA = "0x1FAF3EC", Offset = "0x1FAE3EC", VA = "0x1FAF3EC")]
	public Rect GetRect()
	{
		return default(Rect);
	}

	[Token(Token = "0x6000E60")]
	[Address(RVA = "0x1FAF3B8", Offset = "0x1FAE3B8", VA = "0x1FAF3B8")]
	public void FromRect(Rect r)
	{
	}

	[Token(Token = "0x6000E61")]
	[Address(RVA = "0x1FAF404", Offset = "0x1FAE404", VA = "0x1FAF404")]
	public void MultFast(Matrix4x4 matrix)
	{
	}

	[Token(Token = "0x6000E62")]
	[Address(RVA = "0x1FAF4C0", Offset = "0x1FAE4C0", VA = "0x1FAF4C0")]
	public static Rect3D MultFast(Rect3D rect, Matrix4x4 matrix)
	{
		return default(Rect3D);
	}
}
[Token(Token = "0x20000F2")]
[ExecuteInEditMode]
public abstract class SpriteRoot : MonoBehaviour, IEZLinkedListItem<ISpriteAnimatable>, IUseCamera
{
	[Token(Token = "0x20000F3")]
	public enum SPRITE_PLANE
	{
		[Token(Token = "0x40007DA")]
		XY,
		[Token(Token = "0x40007DB")]
		XZ,
		[Token(Token = "0x40007DC")]
		YZ
	}

	[Token(Token = "0x20000F4")]
	public enum ANCHOR_METHOD
	{
		[Token(Token = "0x40007DE")]
		UPPER_LEFT,
		[Token(Token = "0x40007DF")]
		UPPER_CENTER,
		[Token(Token = "0x40007E0")]
		UPPER_RIGHT,
		[Token(Token = "0x40007E1")]
		MIDDLE_LEFT,
		[Token(Token = "0x40007E2")]
		MIDDLE_CENTER,
		[Token(Token = "0x40007E3")]
		MIDDLE_RIGHT,
		[Token(Token = "0x40007E4")]
		BOTTOM_LEFT,
		[Token(Token = "0x40007E5")]
		BOTTOM_CENTER,
		[Token(Token = "0x40007E6")]
		BOTTOM_RIGHT,
		[Token(Token = "0x40007E7")]
		TEXTURE_OFFSET
	}

	[Token(Token = "0x20000F5")]
	public enum WINDING_ORDER
	{
		[Token(Token = "0x40007E9")]
		CCW,
		[Token(Token = "0x40007EA")]
		CW
	}

	[Token(Token = "0x20000F6")]
	public delegate void SpriteResizedDelegate(float newWidth, float newHeight, SpriteRoot sprite);

	[Token(Token = "0x400079F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool managed;

	[Token(Token = "0x40007A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SpriteManager manager;

	[Token(Token = "0x40007A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected bool addedToManager;

	[Token(Token = "0x40007A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int drawLayer;

	[Token(Token = "0x40007A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool persistent;

	[Token(Token = "0x40007A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public SPRITE_PLANE plane;

	[Token(Token = "0x40007A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public WINDING_ORDER winding;

	[Token(Token = "0x40007A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float width;

	[Token(Token = "0x40007A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float height;

	[Token(Token = "0x40007A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public Vector2 bleedCompensation;

	[Token(Token = "0x40007A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public ANCHOR_METHOD anchor;

	[Token(Token = "0x40007AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool pixelPerfect;

	[Token(Token = "0x40007AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool autoResize;

	[Token(Token = "0x40007AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	protected Vector2 bleedCompensationUV;

	[Token(Token = "0x40007AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	protected Vector2 bleedCompensationUVMax;

	[Token(Token = "0x40007AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	protected SPRITE_FRAME frameInfo;

	[Token(Token = "0x40007AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	protected Rect uvRect;

	[Token(Token = "0x40007B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	protected Vector2 scaleFactor;

	[Token(Token = "0x40007B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	protected Vector2 topLeftOffset;

	[Token(Token = "0x40007B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	protected Vector2 bottomRightOffset;

	[Token(Token = "0x40007B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	protected Vector3 topLeft;

	[Token(Token = "0x40007B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	protected Vector3 bottomRight;

	[Token(Token = "0x40007B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	protected Vector3 unclippedTopLeft;

	[Token(Token = "0x40007B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	protected Vector3 unclippedBottomRight;

	[Token(Token = "0x40007B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	protected Vector2 tlTruncate;

	[Token(Token = "0x40007B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	protected Vector2 brTruncate;

	[Token(Token = "0x40007B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	protected bool truncated;

	[Token(Token = "0x40007BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	protected Rect3D clippingRect;

	[Token(Token = "0x40007BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	protected Rect localClipRect;

	[Token(Token = "0x40007BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	protected float leftClipPct;

	[Token(Token = "0x40007BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	protected float rightClipPct;

	[Token(Token = "0x40007BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	protected float topClipPct;

	[Token(Token = "0x40007BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	protected float bottomClipPct;

	[Token(Token = "0x40007C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	protected bool clipped;

	[Token(Token = "0x40007C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x159")]
	[HideInInspector]
	public bool billboarded;

	[NonSerialized]
	[Token(Token = "0x40007C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15A")]
	public bool isClone;

	[NonSerialized]
	[Token(Token = "0x40007C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15B")]
	public bool uvsInitialized;

	[Token(Token = "0x40007C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	protected bool m_started;

	[Token(Token = "0x40007C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15D")]
	protected bool deleted;

	[Token(Token = "0x40007C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public Vector3 offset;

	[Token(Token = "0x40007C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
	public Color color;

	[Token(Token = "0x40007C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	protected ISpriteMesh m_spriteMesh;

	[Token(Token = "0x40007C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	protected ISpriteAnimatable m_prev;

	[Token(Token = "0x40007CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	protected ISpriteAnimatable m_next;

	[Token(Token = "0x40007CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	protected Vector2 screenSize;

	[Token(Token = "0x40007CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public Camera renderCamera;

	[Token(Token = "0x40007CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	protected Vector2 sizeUnitsPerUV;

	[Token(Token = "0x40007CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	[HideInInspector]
	public Vector2 pixelsPerUV;

	[Token(Token = "0x40007CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	protected float worldUnitsPerScreenPixel;

	[Token(Token = "0x40007D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	protected SpriteResizedDelegate resizedDelegate;

	[Token(Token = "0x40007D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	protected EZScreenPlacement screenPlacer;

	[Token(Token = "0x40007D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	public bool hideAtStart;

	[Token(Token = "0x40007D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D1")]
	protected bool m_hidden;

	[Token(Token = "0x40007D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D2")]
	public bool ignoreClipping;

	[Token(Token = "0x40007D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	protected SpriteRootMirror mirror;

	[Token(Token = "0x40007D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	protected Vector2 tempUV;

	[Token(Token = "0x40007D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	protected Mesh oldMesh;

	[Token(Token = "0x40007D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	protected SpriteManager savedManager;

	[Token(Token = "0x170001C8")]
	public Color Color
	{
		[Token(Token = "0x6000E7F")]
		[Address(RVA = "0x1FB0B50", Offset = "0x1FAFB50", VA = "0x1FB0B50", Slot = "31")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000E80")]
		[Address(RVA = "0x1FB0B64", Offset = "0x1FAFB64", VA = "0x1FB0B64", Slot = "32")]
		set
		{
		}
	}

	[Token(Token = "0x170001C9")]
	public virtual Camera RenderCamera
	{
		[Token(Token = "0x6000E86")]
		[Address(RVA = "0x1FB1110", Offset = "0x1FB0110", VA = "0x1FB1110", Slot = "33")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000E87")]
		[Address(RVA = "0x1FB1118", Offset = "0x1FB0118", VA = "0x1FB1118", Slot = "34")]
		set
		{
		}
	}

	[Token(Token = "0x170001CA")]
	public Vector2 PixelSize
	{
		[Token(Token = "0x6000E8D")]
		[Address(RVA = "0x1FB15BC", Offset = "0x1FB05BC", VA = "0x1FB15BC")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000E8E")]
		[Address(RVA = "0x1FB15D0", Offset = "0x1FB05D0", VA = "0x1FB15D0")]
		set
		{
		}
	}

	[Token(Token = "0x170001CB")]
	public Vector2 ImageSize
	{
		[Token(Token = "0x6000E8F")]
		[Address(RVA = "0x1FB15EC", Offset = "0x1FB05EC", VA = "0x1FB15EC")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x170001CC")]
	public bool Managed
	{
		[Token(Token = "0x6000E90")]
		[Address(RVA = "0x1FB1600", Offset = "0x1FB0600", VA = "0x1FB1600", Slot = "38")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000E91")]
		[Address(RVA = "0x1FB1608", Offset = "0x1FB0608", VA = "0x1FB1608")]
		set
		{
		}
	}

	[Token(Token = "0x170001CD")]
	public bool Started
	{
		[Token(Token = "0x6000E92")]
		[Address(RVA = "0x1FB19AC", Offset = "0x1FB09AC", VA = "0x1FB19AC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001CE")]
	public virtual Rect3D ClippingRect
	{
		[Token(Token = "0x6000EA1")]
		[Address(RVA = "0x1FB205C", Offset = "0x1FB105C", VA = "0x1FB205C", Slot = "40")]
		get
		{
			return default(Rect3D);
		}
		[Token(Token = "0x6000EA2")]
		[Address(RVA = "0x1FB2078", Offset = "0x1FB1078", VA = "0x1FB2078", Slot = "41")]
		set
		{
		}
	}

	[Token(Token = "0x170001CF")]
	public virtual bool Clipped
	{
		[Token(Token = "0x6000EA3")]
		[Address(RVA = "0x1FB21A8", Offset = "0x1FB11A8", VA = "0x1FB21A8", Slot = "42")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000EA4")]
		[Address(RVA = "0x1FB21B0", Offset = "0x1FB11B0", VA = "0x1FB21B0", Slot = "43")]
		set
		{
		}
	}

	[Token(Token = "0x170001D0")]
	public ANCHOR_METHOD Anchor
	{
		[Token(Token = "0x6000EA6")]
		[Address(RVA = "0x1FB2200", Offset = "0x1FB1200", VA = "0x1FB2200", Slot = "44")]
		get
		{
			return default(ANCHOR_METHOD);
		}
		[Token(Token = "0x6000EA7")]
		[Address(RVA = "0x1FB2208", Offset = "0x1FB1208", VA = "0x1FB2208")]
		set
		{
		}
	}

	[Token(Token = "0x170001D1")]
	public Vector3 UnclippedTopLeft
	{
		[Token(Token = "0x6000EA9")]
		[Address(RVA = "0x1FB2240", Offset = "0x1FB1240", VA = "0x1FB2240")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x170001D2")]
	public Vector3 UnclippedBottomRight
	{
		[Token(Token = "0x6000EAA")]
		[Address(RVA = "0x1FB2274", Offset = "0x1FB1274", VA = "0x1FB2274")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x170001D3")]
	public Vector3 TopLeft
	{
		[Token(Token = "0x6000EAB")]
		[Address(RVA = "0x1FB22A8", Offset = "0x1FB12A8", VA = "0x1FB22A8")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x170001D4")]
	public Vector3 BottomRight
	{
		[Token(Token = "0x6000EAC")]
		[Address(RVA = "0x1FB23B4", Offset = "0x1FB13B4", VA = "0x1FB23B4")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x170001D5")]
	public ISpriteMesh spriteMesh
	{
		[Token(Token = "0x6000EAD")]
		[Address(RVA = "0x1FB24C4", Offset = "0x1FB14C4", VA = "0x1FB24C4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000EAE")]
		[Address(RVA = "0x1FAD4C4", Offset = "0x1FAC4C4", VA = "0x1FAD4C4")]
		set
		{
		}
	}

	[Token(Token = "0x170001D6")]
	public bool AddedToManager
	{
		[Token(Token = "0x6000EAF")]
		[Address(RVA = "0x1FB24CC", Offset = "0x1FB14CC", VA = "0x1FB24CC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000EB0")]
		[Address(RVA = "0x1FB24D4", Offset = "0x1FB14D4", VA = "0x1FB24D4")]
		set
		{
		}
	}

	[Token(Token = "0x170001D7")]
	public ISpriteAnimatable prev
	{
		[Token(Token = "0x6000EB8")]
		[Address(RVA = "0x1FB24EC", Offset = "0x1FB14EC", VA = "0x1FB24EC", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000EB9")]
		[Address(RVA = "0x1FB24F4", Offset = "0x1FB14F4", VA = "0x1FB24F4", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x170001D8")]
	public ISpriteAnimatable next
	{
		[Token(Token = "0x6000EBA")]
		[Address(RVA = "0x1FB24FC", Offset = "0x1FB14FC", VA = "0x1FB24FC", Slot = "6")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000EBB")]
		[Address(RVA = "0x1FB2504", Offset = "0x1FB1504", VA = "0x1FB2504", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x6000E63")]
	[Address(RVA = "0x1FA9A0C", Offset = "0x1FA8A0C", VA = "0x1FA9A0C", Slot = "12")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6000E64")]
	[Address(RVA = "0x1FA9D00", Offset = "0x1FA8D00", VA = "0x1FA9D00", Slot = "13")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x6000E65")]
	[Address(RVA = "0x1FADCE0", Offset = "0x1FACCE0", VA = "0x1FADCE0")]
	public Camera findCamera()
	{
		return null;
	}

	[Token(Token = "0x6000E66")]
	[Address(RVA = "0x1FAF688", Offset = "0x1FAE688", VA = "0x1FAF688")]
	protected void CalcSizeUnitsPerUV()
	{
	}

	[Token(Token = "0x6000E67")]
	[Address(RVA = "0x1FAF724", Offset = "0x1FAE724", VA = "0x1FAF724")]
	public EZScreenPlacement GetScreenPlacer()
	{
		return null;
	}

	[Token(Token = "0x6000E68")]
	[Address(RVA = "0x1FAF72C", Offset = "0x1FAE72C", VA = "0x1FAF72C", Slot = "14")]
	protected virtual void Init()
	{
	}

	[Token(Token = "0x6000E69")]
	[Address(RVA = "0x1FAA030", Offset = "0x1FA9030", VA = "0x1FAA030", Slot = "15")]
	public virtual void Clear()
	{
	}

	[Token(Token = "0x6000E6A")]
	[Address(RVA = "0x1FAA524", Offset = "0x1FA9524", VA = "0x1FAA524", Slot = "16")]
	public virtual void Copy(SpriteRoot s)
	{
	}

	[Token(Token = "0x6000E6B")]
	[Address(RVA = "0x1FAFAD4", Offset = "0x1FAEAD4", VA = "0x1FAFAD4", Slot = "17")]
	public virtual void InitUVs()
	{
	}

	[Token(Token = "0x6000E6C")]
	[Address(RVA = "0x1FAA0DC", Offset = "0x1FA90DC", VA = "0x1FAA0DC", Slot = "18")]
	public virtual void Delete()
	{
	}

	[Token(Token = "0x6000E6D")]
	[Address(RVA = "0x1FAA380", Offset = "0x1FA9380", VA = "0x1FAA380", Slot = "19")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000E6E")]
	[Address(RVA = "0x1FAA260", Offset = "0x1FA9260", VA = "0x1FAA260", Slot = "20")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000E6F")]
	[Address(RVA = "0x1FAFAE0", Offset = "0x1FAEAE0", VA = "0x1FAFAE0", Slot = "21")]
	public virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000E70")]
	[Address(RVA = "0x1FAFAF0", Offset = "0x1FAEAF0", VA = "0x1FAFAF0")]
	public void CalcEdges()
	{
	}

	[Token(Token = "0x6000E71")]
	[Address(RVA = "0x1FAAC54", Offset = "0x1FA9C54", VA = "0x1FAAC54")]
	public void CalcSize()
	{
	}

	[Token(Token = "0x6000E72")]
	[Address(RVA = "0x1FAFEBC", Offset = "0x1FAEEBC", VA = "0x1FAFEBC", Slot = "22")]
	public virtual void SetSize(float w, float h)
	{
	}

	[Token(Token = "0x6000E73")]
	[Address(RVA = "0x1FAFF38", Offset = "0x1FAEF38", VA = "0x1FAFF38")]
	protected void SetSizeXY(float w, float h)
	{
	}

	[Token(Token = "0x6000E74")]
	[Address(RVA = "0x1FB00F0", Offset = "0x1FAF0F0", VA = "0x1FB00F0")]
	protected void SetSizeXZ(float w, float h)
	{
	}

	[Token(Token = "0x6000E75")]
	[Address(RVA = "0x1FB02C8", Offset = "0x1FAF2C8", VA = "0x1FB02C8")]
	protected void SetSizeYZ(float w, float h)
	{
	}

	[Token(Token = "0x6000E76")]
	[Address(RVA = "0x1FB048C", Offset = "0x1FAF48C", VA = "0x1FB048C", Slot = "23")]
	public virtual void TruncateRight(float pct)
	{
	}

	[Token(Token = "0x6000E77")]
	[Address(RVA = "0x1FB0528", Offset = "0x1FAF528", VA = "0x1FB0528", Slot = "24")]
	public virtual void TruncateLeft(float pct)
	{
	}

	[Token(Token = "0x6000E78")]
	[Address(RVA = "0x1FB05D4", Offset = "0x1FAF5D4", VA = "0x1FB05D4", Slot = "25")]
	public virtual void TruncateTop(float pct)
	{
	}

	[Token(Token = "0x6000E79")]
	[Address(RVA = "0x1FB0680", Offset = "0x1FAF680", VA = "0x1FB0680", Slot = "26")]
	public virtual void TruncateBottom(float pct)
	{
	}

	[Token(Token = "0x6000E7A")]
	[Address(RVA = "0x1FB071C", Offset = "0x1FAF71C", VA = "0x1FB071C", Slot = "27")]
	public virtual void Untruncate()
	{
	}

	[Token(Token = "0x6000E7B")]
	[Address(RVA = "0x1FB074C", Offset = "0x1FAF74C", VA = "0x1FB074C", Slot = "28")]
	public virtual void Unclip()
	{
	}

	[Token(Token = "0x6000E7C")]
	[Address(RVA = "0x1FB0790", Offset = "0x1FAF790", VA = "0x1FB0790", Slot = "29")]
	public virtual void UpdateUVs()
	{
	}

	[Token(Token = "0x6000E7D")]
	[Address(RVA = "0x1FB0A58", Offset = "0x1FAFA58", VA = "0x1FB0A58")]
	public void TransformBillboarded(Transform t)
	{
	}

	[Token(Token = "0x6000E7E")]
	[Address(RVA = "0x1FB0A5C", Offset = "0x1FAFA5C", VA = "0x1FB0A5C", Slot = "30")]
	public virtual void SetColor(Color c)
	{
	}

	[Token(Token = "0x6000E81")]
	[Address(RVA = "0x1FB0B74", Offset = "0x1FAFB74", VA = "0x1FB0B74")]
	public void SetPixelToUV(int texWidth, int texHeight)
	{
	}

	[Token(Token = "0x6000E82")]
	[Address(RVA = "0x1FAD780", Offset = "0x1FAC780", VA = "0x1FAD780")]
	public void SetPixelToUV(Texture tex)
	{
	}

	[Token(Token = "0x6000E83")]
	[Address(RVA = "0x1FB0BDC", Offset = "0x1FAFBDC", VA = "0x1FB0BDC")]
	public void CalcPixelToUV()
	{
	}

	[Token(Token = "0x6000E84")]
	[Address(RVA = "0x1FB0F00", Offset = "0x1FAFF00", VA = "0x1FB0F00")]
	public void SetTexture(Texture2D tex)
	{
	}

	[Token(Token = "0x6000E85")]
	[Address(RVA = "0x1FB1010", Offset = "0x1FB0010", VA = "0x1FB1010")]
	public void SetMaterial(Material mat)
	{
	}

	[Token(Token = "0x6000E88")]
	[Address(RVA = "0x1FB112C", Offset = "0x1FB012C", VA = "0x1FB112C", Slot = "35")]
	public void UpdateCamera()
	{
	}

	[Token(Token = "0x6000E89")]
	[Address(RVA = "0x1FB0FFC", Offset = "0x1FAFFFC", VA = "0x1FB0FFC", Slot = "8")]
	public void SetCamera()
	{
	}

	[Token(Token = "0x6000E8A")]
	[Address(RVA = "0x1FB1140", Offset = "0x1FB0140", VA = "0x1FB1140", Slot = "36")]
	public virtual void SetCamera(Camera c)
	{
	}

	[Token(Token = "0x6000E8B")]
	[Address(RVA = "0x1FAA9D0", Offset = "0x1FA99D0", VA = "0x1FAA9D0", Slot = "37")]
	public virtual void Hide(bool tf)
	{
	}

	[Token(Token = "0x6000E8C")]
	[Address(RVA = "0x1FB15B4", Offset = "0x1FB05B4", VA = "0x1FB15B4")]
	public bool IsHidden()
	{
		return default(bool);
	}

	[Token(Token = "0x6000E93")]
	[Address(RVA = "0x1FB1718", Offset = "0x1FB0718", VA = "0x1FB1718")]
	protected void DestroyMesh()
	{
	}

	[Token(Token = "0x6000E94")]
	[Address(RVA = "0x1FAF5BC", Offset = "0x1FAE5BC", VA = "0x1FAF5BC")]
	protected void AddMesh()
	{
	}

	[Token(Token = "0x6000E95")]
	[Address(RVA = "0x1FAAC4C", Offset = "0x1FA9C4C", VA = "0x1FAAC4C")]
	public void SetBleedCompensation()
	{
	}

	[Token(Token = "0x6000E96")]
	[Address(RVA = "0x1FB19B4", Offset = "0x1FB09B4", VA = "0x1FB19B4")]
	public void SetBleedCompensation(float x, float y)
	{
	}

	[Token(Token = "0x6000E97")]
	[Address(RVA = "0x1FADC84", Offset = "0x1FACC84", VA = "0x1FADC84")]
	public void SetBleedCompensation(Vector2 xy)
	{
	}

	[Token(Token = "0x6000E98")]
	[Address(RVA = "0x1FB19B8", Offset = "0x1FB09B8", VA = "0x1FB19B8")]
	public void SetPlane(SPRITE_PLANE p)
	{
	}

	[Token(Token = "0x6000E99")]
	[Address(RVA = "0x1FB19D0", Offset = "0x1FB09D0", VA = "0x1FB19D0")]
	public void SetWindingOrder(WINDING_ORDER order)
	{
	}

	[Token(Token = "0x6000E9A")]
	[Address(RVA = "0x1FB1A70", Offset = "0x1FB0A70", VA = "0x1FB1A70")]
	public void SetDrawLayer(int layer)
	{
	}

	[Token(Token = "0x6000E9B")]
	[Address(RVA = "0x1FB1B54", Offset = "0x1FB0B54", VA = "0x1FB1B54")]
	public void SetFrameInfo(SPRITE_FRAME fInfo)
	{
	}

	[Token(Token = "0x6000E9C")]
	[Address(RVA = "0x1FB1BA4", Offset = "0x1FB0BA4", VA = "0x1FB1BA4", Slot = "39")]
	public void SetUVs(Rect uv)
	{
	}

	[Token(Token = "0x6000E9D")]
	[Address(RVA = "0x1FB1C6C", Offset = "0x1FB0C6C", VA = "0x1FB1C6C")]
	public void SetUVsFromPixelCoords(Rect pxCoords)
	{
	}

	[Token(Token = "0x6000E9E")]
	[Address(RVA = "0x1FB1D74", Offset = "0x1FB0D74", VA = "0x1FB1D74")]
	public Rect GetUVs()
	{
		return default(Rect);
	}

	[Token(Token = "0x6000E9F")]
	[Address(RVA = "0x1FB1D80", Offset = "0x1FB0D80", VA = "0x1FB1D80")]
	public Vector3[] GetVertices()
	{
		return null;
	}

	[Token(Token = "0x6000EA0")]
	[Address(RVA = "0x1FB1E9C", Offset = "0x1FB0E9C", VA = "0x1FB1E9C")]
	public Vector3 GetCenterPoint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000EA5")]
	[Address(RVA = "0x1FB21E8", Offset = "0x1FB11E8", VA = "0x1FB21E8")]
	public void SetAnchor(ANCHOR_METHOD a)
	{
	}

	[Token(Token = "0x6000EA8")]
	[Address(RVA = "0x1FB2220", Offset = "0x1FB1220", VA = "0x1FB2220")]
	public void SetOffset(Vector3 o)
	{
	}

	[Token(Token = "0x6000EB1")]
	public abstract Vector2 GetDefaultPixelSize(PathFromGUIDDelegate guid2Path, AssetLoaderDelegate loader);

	[Token(Token = "0x6000EB2")]
	[Address(RVA = "0x1FA8C88", Offset = "0x1FA7C88", VA = "0x1FA8C88")]
	public Vector2 PixelSpaceToUVSpace(Vector2 xy)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000EB3")]
	[Address(RVA = "0x1FB24E0", Offset = "0x1FB14E0", VA = "0x1FB24E0")]
	public Vector2 PixelSpaceToUVSpace(int x, int y)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000EB4")]
	[Address(RVA = "0x1FA8C18", Offset = "0x1FA7C18", VA = "0x1FA8C18")]
	public Vector2 PixelCoordToUVCoord(Vector2 xy)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000EB5")]
	[Address(RVA = "0x1FB1D68", Offset = "0x1FB0D68", VA = "0x1FB1D68")]
	public Vector2 PixelCoordToUVCoord(int x, int y)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000EB6")]
	public abstract int GetStateIndex(string stateName);

	[Token(Token = "0x6000EB7")]
	public abstract void SetState(int index);

	[Token(Token = "0x6000EBC")]
	[Address(RVA = "0x1FB250C", Offset = "0x1FB150C", VA = "0x1FB250C", Slot = "48")]
	public virtual void DoMirror()
	{
	}

	[Token(Token = "0x6000EBD")]
	[Address(RVA = "0x1FB264C", Offset = "0x1FB164C", VA = "0x1FB264C", Slot = "49")]
	public virtual void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000EBE")]
	[Address(RVA = "0x1FB265C", Offset = "0x1FB165C", VA = "0x1FB265C", Slot = "50")]
	public virtual void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000EBF")]
	[Address(RVA = "0x1FAAD48", Offset = "0x1FA9D48", VA = "0x1FAAD48")]
	protected SpriteRoot()
	{
	}
}
[Token(Token = "0x20000F7")]
public class SpriteRootMirror
{
	[Token(Token = "0x40007EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool managed;

	[Token(Token = "0x40007EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SpriteManager manager;

	[Token(Token = "0x40007ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int drawLayer;

	[Token(Token = "0x40007EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public SpriteRoot.SPRITE_PLANE plane;

	[Token(Token = "0x40007EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SpriteRoot.WINDING_ORDER winding;

	[Token(Token = "0x40007F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float width;

	[Token(Token = "0x40007F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float height;

	[Token(Token = "0x40007F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Vector2 bleedCompensation;

	[Token(Token = "0x40007F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public SpriteRoot.ANCHOR_METHOD anchor;

	[Token(Token = "0x40007F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector3 offset;

	[Token(Token = "0x40007F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public Color color;

	[Token(Token = "0x40007F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public bool pixelPerfect;

	[Token(Token = "0x40007F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	public bool autoResize;

	[Token(Token = "0x40007F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Camera renderCamera;

	[Token(Token = "0x40007F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool hideAtStart;

	[Token(Token = "0x6000EC4")]
	[Address(RVA = "0x1EFD004", Offset = "0x1EFC004", VA = "0x1EFD004", Slot = "4")]
	public virtual void Mirror(SpriteRoot s)
	{
	}

	[Token(Token = "0x6000EC5")]
	[Address(RVA = "0x1EFD08C", Offset = "0x1EFC08C", VA = "0x1EFD08C", Slot = "5")]
	public virtual bool Validate(SpriteRoot s)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EC6")]
	[Address(RVA = "0x1EFD0B4", Offset = "0x1EFC0B4", VA = "0x1EFD0B4", Slot = "6")]
	public virtual bool DidChange(SpriteRoot s)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EC7")]
	[Address(RVA = "0x1EFD2F4", Offset = "0x1EFC2F4", VA = "0x1EFD2F4", Slot = "7")]
	protected virtual void HandleManageState(SpriteRoot s)
	{
	}

	[Token(Token = "0x6000EC8")]
	[Address(RVA = "0x1EFD324", Offset = "0x1EFC324", VA = "0x1EFD324", Slot = "8")]
	public virtual void UpdateManager(SpriteRoot s)
	{
	}

	[Token(Token = "0x6000EC9")]
	[Address(RVA = "0x1EFD408", Offset = "0x1EFC408", VA = "0x1EFD408", Slot = "9")]
	protected virtual void HandleDrawLayerChange(SpriteRoot s)
	{
	}

	[Token(Token = "0x6000ECA")]
	[Address(RVA = "0x1EFD440", Offset = "0x1EFC440", VA = "0x1EFD440")]
	public SpriteRootMirror()
	{
	}
}
[Token(Token = "0x20000F8")]
public delegate void MyTask();
[Token(Token = "0x20000F9")]
public class UnityThreadHelper : MonoBehaviour
{
	[Token(Token = "0x40007FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static UnityThreadHelper Dispatcher;

	[Token(Token = "0x40007FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject cameraRig;

	[Token(Token = "0x40007FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Queue<MyTask> TaskQueue;

	[Token(Token = "0x40007FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Queue<MyTask> FixedTaskQueue;

	[Token(Token = "0x40007FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private object _queueLock;

	[Token(Token = "0x40007FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private object _fixedqueueLock;

	[Token(Token = "0x6000ECF")]
	[Address(RVA = "0x1EFD510", Offset = "0x1EFC510", VA = "0x1EFD510")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000ED0")]
	[Address(RVA = "0x1EFD640", Offset = "0x1EFC640", VA = "0x1EFD640")]
	private void Update()
	{
	}

	[Token(Token = "0x6000ED1")]
	[Address(RVA = "0x1EFD7B0", Offset = "0x1EFC7B0", VA = "0x1EFD7B0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000ED2")]
	[Address(RVA = "0x1EFD920", Offset = "0x1EFC920", VA = "0x1EFD920")]
	public void Dispatch(MyTask newTask)
	{
	}

	[Token(Token = "0x6000ED3")]
	[Address(RVA = "0x1EFDA1C", Offset = "0x1EFCA1C", VA = "0x1EFDA1C")]
	public void FixedDispatch(MyTask newTask)
	{
	}

	[Token(Token = "0x6000ED4")]
	[Address(RVA = "0x1EFDB18", Offset = "0x1EFCB18", VA = "0x1EFDB18")]
	public UnityThreadHelper()
	{
	}
}
[Token(Token = "0x20000FA")]
public class UserManager : MonoBehaviour
{
	[Token(Token = "0x20000FB")]
	public delegate void userChangedEvent();

	[Token(Token = "0x4000800")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool loggedIn;

	[Token(Token = "0x4000802")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static bool initialized;

	[Token(Token = "0x14000016")]
	public static event userChangedEvent userChanged
	{
		[Token(Token = "0x6000ED5")]
		[Address(RVA = "0x1EFDBF0", Offset = "0x1EFCBF0", VA = "0x1EFDBF0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000ED6")]
		[Address(RVA = "0x1EFDCAC", Offset = "0x1EFCCAC", VA = "0x1EFDCAC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000ED7")]
	[Address(RVA = "0x1EFDD68", Offset = "0x1EFCD68", VA = "0x1EFDD68")]
	public static void Init()
	{
	}

	[Token(Token = "0x6000ED8")]
	[Address(RVA = "0x1EFDDBC", Offset = "0x1EFCDBC", VA = "0x1EFDDBC")]
	public static void login()
	{
	}

	[Token(Token = "0x6000ED9")]
	[Address(RVA = "0x1EFDE64", Offset = "0x1EFCE64", VA = "0x1EFDE64")]
	public static void openAccountSelector(ulong _controllerID = ulong.MaxValue)
	{
	}

	[Token(Token = "0x6000EDA")]
	[Address(RVA = "0x1EFDE68", Offset = "0x1EFCE68", VA = "0x1EFDE68")]
	public static void triggerChangedEvent()
	{
	}

	[Token(Token = "0x6000EDB")]
	[Address(RVA = "0x1EFDECC", Offset = "0x1EFCECC", VA = "0x1EFDECC")]
	public UserManager()
	{
	}
}
[Token(Token = "0x20000FC")]
public class AlphaButtonClickMask : MonoBehaviour, ICanvasRaycastFilter
{
	[Token(Token = "0x4000803")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected Image _image;

	[Token(Token = "0x6000EE0")]
	[Address(RVA = "0x1EFDF9C", Offset = "0x1EFCF9C", VA = "0x1EFDF9C")]
	public void Start()
	{
	}

	[Token(Token = "0x6000EE1")]
	[Address(RVA = "0x1EFE154", Offset = "0x1EFD154", VA = "0x1EFE154", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EE2")]
	[Address(RVA = "0x1EFE3C0", Offset = "0x1EFD3C0", VA = "0x1EFE3C0")]
	public AlphaButtonClickMask()
	{
	}
}
[Token(Token = "0x20000FD")]
public class EventSystemChecker : MonoBehaviour
{
	[Token(Token = "0x6000EE3")]
	[Address(RVA = "0x1EFE3C8", Offset = "0x1EFD3C8", VA = "0x1EFE3C8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000EE4")]
	[Address(RVA = "0x1EFE4D0", Offset = "0x1EFD4D0", VA = "0x1EFE4D0")]
	public EventSystemChecker()
	{
	}
}
[Token(Token = "0x20000FE")]
[ExecuteInEditMode]
public class Water : MonoBehaviour
{
	[Token(Token = "0x20000FF")]
	public enum WaterMode
	{
		[Token(Token = "0x4000813")]
		Simple,
		[Token(Token = "0x4000814")]
		Reflective,
		[Token(Token = "0x4000815")]
		Refractive
	}

	[Token(Token = "0x4000804")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private WaterMode m_WaterMode;

	[Token(Token = "0x4000805")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool m_DisablePixelLights;

	[Token(Token = "0x4000806")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int m_TextureSize;

	[Token(Token = "0x4000807")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float m_ClipPlaneOffset;

	[Token(Token = "0x4000808")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public LayerMask m_ReflectLayers;

	[Token(Token = "0x4000809")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public LayerMask m_RefractLayers;

	[Token(Token = "0x400080A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<Camera, Camera> m_ReflectionCameras;

	[Token(Token = "0x400080B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Dictionary<Camera, Camera> m_RefractionCameras;

	[Token(Token = "0x400080C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private RenderTexture m_ReflectionTexture;

	[Token(Token = "0x400080D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private RenderTexture m_RefractionTexture;

	[Token(Token = "0x400080E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private WaterMode m_HardwareWaterSupport;

	[Token(Token = "0x400080F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int m_OldReflectionTextureSize;

	[Token(Token = "0x4000810")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int m_OldRefractionTextureSize;

	[Token(Token = "0x4000811")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool s_InsideWater;

	[Token(Token = "0x6000EE5")]
	[Address(RVA = "0x1EFE4D8", Offset = "0x1EFD4D8", VA = "0x1EFE4D8")]
	public void OnWillRenderObject()
	{
	}

	[Token(Token = "0x6000EE6")]
	[Address(RVA = "0x1EFFDD4", Offset = "0x1EFEDD4", VA = "0x1EFFDD4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000EE7")]
	[Address(RVA = "0x1F00120", Offset = "0x1EFF120", VA = "0x1F00120")]
	private void Update()
	{
	}

	[Token(Token = "0x6000EE8")]
	[Address(RVA = "0x1EFF75C", Offset = "0x1EFE75C", VA = "0x1EFF75C")]
	private void UpdateCameraModes(Camera src, Camera dest)
	{
	}

	[Token(Token = "0x6000EE9")]
	[Address(RVA = "0x1EFEEA4", Offset = "0x1EFDEA4", VA = "0x1EFEEA4")]
	private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
	{
	}

	[Token(Token = "0x6000EEA")]
	[Address(RVA = "0x1EFEE90", Offset = "0x1EFDE90", VA = "0x1EFEE90")]
	private WaterMode GetWaterMode()
	{
		return default(WaterMode);
	}

	[Token(Token = "0x6000EEB")]
	[Address(RVA = "0x1EFED24", Offset = "0x1EFDD24", VA = "0x1EFED24")]
	private WaterMode FindHardwareWaterSupport()
	{
		return default(WaterMode);
	}

	[Token(Token = "0x6000EEC")]
	[Address(RVA = "0x1F00524", Offset = "0x1EFF524", VA = "0x1F00524")]
	private static float sgn(float a)
	{
		return default(float);
	}

	[Token(Token = "0x6000EED")]
	[Address(RVA = "0x1EFFAC0", Offset = "0x1EFEAC0", VA = "0x1EFFAC0")]
	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6000EEE")]
	[Address(RVA = "0x1EFFC68", Offset = "0x1EFEC68", VA = "0x1EFFC68")]
	private static void CalculateObliqueMatrix(ref Matrix4x4 projection, Vector4 clipPlane)
	{
	}

	[Token(Token = "0x6000EEF")]
	[Address(RVA = "0x1EFFA28", Offset = "0x1EFEA28", VA = "0x1EFFA28")]
	private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
	{
	}

	[Token(Token = "0x6000EF0")]
	[Address(RVA = "0x1F00540", Offset = "0x1EFF540", VA = "0x1F00540")]
	public Water()
	{
	}
}
[Token(Token = "0x2000100")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	[Token(Token = "0x2000101")]
	private struct MonoScriptData
	{
		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte[] FilePathsData;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte[] TypesData;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int TotalTypes;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int TotalFiles;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsEditorOnly;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Token(Token = "0x6000EF1")]
	[Address(RVA = "0x1F00614", Offset = "0x1EFF614", VA = "0x1F00614")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Token(Token = "0x6000EF2")]
	[Address(RVA = "0x1F006D8", Offset = "0x1EFF6D8", VA = "0x1F006D8")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
	}
}
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000102")]
	public class ActivateTrigger : MonoBehaviour
	{
		[Token(Token = "0x2000103")]
		public enum Mode
		{
			[Token(Token = "0x4000821")]
			Trigger,
			[Token(Token = "0x4000822")]
			Replace,
			[Token(Token = "0x4000823")]
			Activate,
			[Token(Token = "0x4000824")]
			Enable,
			[Token(Token = "0x4000825")]
			Animate,
			[Token(Token = "0x4000826")]
			Deactivate
		}

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Mode action;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEngine.Object target;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject source;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int triggerCount;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool repeatTrigger;

		[Token(Token = "0x6000EF3")]
		[Address(RVA = "0x1F006E0", Offset = "0x1EFF6E0", VA = "0x1F006E0")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x6000EF4")]
		[Address(RVA = "0x1F00B1C", Offset = "0x1EFFB1C", VA = "0x1F00B1C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000EF5")]
		[Address(RVA = "0x1F00B20", Offset = "0x1EFFB20", VA = "0x1F00B20")]
		public ActivateTrigger()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000105")]
		public class ReplacementDefinition
		{
			[Token(Token = "0x4000828")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Shader original;

			[Token(Token = "0x4000829")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Shader replacement;

			[Token(Token = "0x6000EF8")]
			[Address(RVA = "0x1F0139C", Offset = "0x1F0039C", VA = "0x1F0139C")]
			public ReplacementDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000106")]
		public class ReplacementList
		{
			[Token(Token = "0x400082A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ReplacementDefinition[] items;

			[Token(Token = "0x6000EF9")]
			[Address(RVA = "0x1F013A4", Offset = "0x1F003A4", VA = "0x1F013A4")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x6000EF6")]
		[Address(RVA = "0x1F00B38", Offset = "0x1EFFB38", VA = "0x1F00B38")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000EF7")]
		[Address(RVA = "0x1F01394", Offset = "0x1F00394", VA = "0x1F01394")]
		public AutoMobileShaderSwitch()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000108")]
		public class Vector3andSpace
		{
			[Token(Token = "0x400082F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 value;

			[Token(Token = "0x4000830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Space space;

			[Token(Token = "0x6000EFD")]
			[Address(RVA = "0x1F014E4", Offset = "0x1F004E4", VA = "0x1F014E4")]
			public Vector3andSpace()
			{
			}
		}

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3andSpace moveUnitsPerSecond;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3andSpace rotateDegreesPerSecond;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool ignoreTimescale;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float m_LastRealTime;

		[Token(Token = "0x6000EFA")]
		[Address(RVA = "0x1F013FC", Offset = "0x1F003FC", VA = "0x1F013FC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000EFB")]
		[Address(RVA = "0x1F01418", Offset = "0x1F00418", VA = "0x1F01418")]
		private void Update()
		{
		}

		[Token(Token = "0x6000EFC")]
		[Address(RVA = "0x1F014DC", Offset = "0x1F004DC", VA = "0x1F014DC")]
		public AutoMoveAndRotate()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class CameraRefocus
	{
		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Lookatpoint;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Parent;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OrigCameraPos;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_Refocus;

		[Token(Token = "0x6000EFE")]
		[Address(RVA = "0x1F014F4", Offset = "0x1F004F4", VA = "0x1F014F4")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x6000EFF")]
		[Address(RVA = "0x1F01548", Offset = "0x1F00548", VA = "0x1F01548")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000F00")]
		[Address(RVA = "0x1F01550", Offset = "0x1F00550", VA = "0x1F01550")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x6000F01")]
		[Address(RVA = "0x1F01558", Offset = "0x1F00558", VA = "0x1F01558")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x6000F02")]
		[Address(RVA = "0x1F01690", Offset = "0x1F00690", VA = "0x1F01690")]
		public void SetFocusPoint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200010A")]
	public class CurveControlledBob
	{
		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float HorizontalBobRange;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float VerticalBobRange;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve Bobcurve;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float VerticaltoHorizontalRatio;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_CyclePositionX;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_CyclePositionY;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_BobBaseInterval;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_Time;

		[Token(Token = "0x6000F03")]
		[Address(RVA = "0x1F016D4", Offset = "0x1F006D4", VA = "0x1F016D4")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x6000F04")]
		[Address(RVA = "0x1F01774", Offset = "0x1F00774", VA = "0x1F01774")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000F05")]
		[Address(RVA = "0x1F01878", Offset = "0x1F00878", VA = "0x1F01878")]
		public CurveControlledBob()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x200010C")]
		[CompilerGenerated]
		private sealed class <DragObject>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000846")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000847")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000848")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DragRigidbody <>4__this;

			[Token(Token = "0x4000849")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x400084A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <oldDrag>5__2;

			[Token(Token = "0x400084B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <oldAngularDrag>5__3;

			[Token(Token = "0x400084C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Camera <mainCamera>5__4;

			[Token(Token = "0x170001D9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000F0D")]
				[Address(RVA = "0x1F021A4", Offset = "0x1F011A4", VA = "0x1F021A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001DA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000F0F")]
				[Address(RVA = "0x1F021E4", Offset = "0x1F011E4", VA = "0x1F021E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000F0A")]
			[Address(RVA = "0x1F01F48", Offset = "0x1F00F48", VA = "0x1F01F48")]
			[DebuggerHidden]
			public <DragObject>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000F0B")]
			[Address(RVA = "0x1F01F78", Offset = "0x1F00F78", VA = "0x1F01F78", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000F0C")]
			[Address(RVA = "0x1F01F7C", Offset = "0x1F00F7C", VA = "0x1F01F7C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000F0E")]
			[Address(RVA = "0x1F021AC", Offset = "0x1F011AC", VA = "0x1F021AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400083F")]
		private const float k_Spring = 50f;

		[Token(Token = "0x4000840")]
		private const float k_Damper = 5f;

		[Token(Token = "0x4000841")]
		private const float k_Drag = 10f;

		[Token(Token = "0x4000842")]
		private const float k_AngularDrag = 5f;

		[Token(Token = "0x4000843")]
		private const float k_Distance = 0.2f;

		[Token(Token = "0x4000844")]
		private const bool k_AttachToCenterOfMass = false;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SpringJoint m_SpringJoint;

		[Token(Token = "0x6000F06")]
		[Address(RVA = "0x1F01AB4", Offset = "0x1F00AB4", VA = "0x1F01AB4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000F07")]
		[Address(RVA = "0x1F01ED8", Offset = "0x1F00ED8", VA = "0x1F01ED8")]
		[IteratorStateMachine(typeof(<DragObject>d__8))]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x6000F08")]
		[Address(RVA = "0x1F01E2C", Offset = "0x1F00E2C", VA = "0x1F01E2C")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x6000F09")]
		[Address(RVA = "0x1F01F70", Offset = "0x1F00F70", VA = "0x1F01F70")]
		public DragRigidbody()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class DynamicShadowSettings : MonoBehaviour
	{
		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Light sunLight;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float minHeight;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float minShadowDistance;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float minShadowBias;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float maxHeight;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxShadowDistance;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float maxShadowBias;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float adaptTime;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_SmoothHeight;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_ChangeSpeed;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_OriginalStrength;

		[Token(Token = "0x6000F10")]
		[Address(RVA = "0x1F021EC", Offset = "0x1F011EC", VA = "0x1F021EC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000F11")]
		[Address(RVA = "0x1F02214", Offset = "0x1F01214", VA = "0x1F02214")]
		private void Update()
		{
		}

		[Token(Token = "0x6000F12")]
		[Address(RVA = "0x1F024F8", Offset = "0x1F014F8", VA = "0x1F024F8")]
		public DynamicShadowSettings()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class FollowTarget : MonoBehaviour
	{
		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform target;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x6000F13")]
		[Address(RVA = "0x1F02524", Offset = "0x1F01524", VA = "0x1F02524")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000F14")]
		[Address(RVA = "0x1F02580", Offset = "0x1F01580", VA = "0x1F02580")]
		public FollowTarget()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200010F")]
	public class FOVKick
	{
		[Token(Token = "0x2000110")]
		[CompilerGenerated]
		private sealed class <FOVKickDown>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000860")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000861")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000862")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x4000863")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x170001DB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000F1E")]
				[Address(RVA = "0x1F02924", Offset = "0x1F01924", VA = "0x1F02924", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001DC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000F20")]
				[Address(RVA = "0x1F02964", Offset = "0x1F01964", VA = "0x1F02964", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000F1B")]
			[Address(RVA = "0x1F027A4", Offset = "0x1F017A4", VA = "0x1F027A4")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000F1C")]
			[Address(RVA = "0x1F027E8", Offset = "0x1F017E8", VA = "0x1F027E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000F1D")]
			[Address(RVA = "0x1F027EC", Offset = "0x1F017EC", VA = "0x1F027EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000F1F")]
			[Address(RVA = "0x1F0292C", Offset = "0x1F0192C", VA = "0x1F0292C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000111")]
		[CompilerGenerated]
		private sealed class <FOVKickUp>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000864")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000865")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000866")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x4000867")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x170001DD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000F24")]
				[Address(RVA = "0x1F02A94", Offset = "0x1F01A94", VA = "0x1F02A94", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001DE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000F26")]
				[Address(RVA = "0x1F02AD4", Offset = "0x1F01AD4", VA = "0x1F02AD4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000F21")]
			[Address(RVA = "0x1F0271C", Offset = "0x1F0171C", VA = "0x1F0271C")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000F22")]
			[Address(RVA = "0x1F0296C", Offset = "0x1F0196C", VA = "0x1F0296C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000F23")]
			[Address(RVA = "0x1F02970", Offset = "0x1F01970", VA = "0x1F02970", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000F25")]
			[Address(RVA = "0x1F02A9C", Offset = "0x1F01A9C", VA = "0x1F02A9C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public float originalFov;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float FOVIncrease;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float TimeToIncrease;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TimeToDecrease;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve IncreaseCurve;

		[Token(Token = "0x6000F15")]
		[Address(RVA = "0x1F02598", Offset = "0x1F01598", VA = "0x1F02598")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x6000F16")]
		[Address(RVA = "0x1F025D4", Offset = "0x1F015D4", VA = "0x1F025D4")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x6000F17")]
		[Address(RVA = "0x1F026B4", Offset = "0x1F016B4", VA = "0x1F026B4")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000F18")]
		[Address(RVA = "0x1F026BC", Offset = "0x1F016BC", VA = "0x1F026BC")]
		[IteratorStateMachine(typeof(<FOVKickUp>d__9))]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x6000F19")]
		[Address(RVA = "0x1F02744", Offset = "0x1F01744", VA = "0x1F02744")]
		[IteratorStateMachine(typeof(<FOVKickDown>d__10))]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x6000F1A")]
		[Address(RVA = "0x1F027CC", Offset = "0x1F017CC", VA = "0x1F027CC")]
		public FOVKick()
		{
		}
	}
	[Token(Token = "0x2000112")]
	[RequireComponent(typeof(Text))]
	public class FPSCounter : MonoBehaviour
	{
		[Token(Token = "0x4000868")]
		private const float fpsMeasurePeriod = 0.5f;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_FpsAccumulator;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_FpsNextPeriod;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int m_CurrentFps;

		[Token(Token = "0x400086C")]
		private const string display = "{0} FPS";

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Text m_Text;

		[Token(Token = "0x6000F27")]
		[Address(RVA = "0x1F02ADC", Offset = "0x1F01ADC", VA = "0x1F02ADC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000F28")]
		[Address(RVA = "0x1F02B40", Offset = "0x1F01B40", VA = "0x1F02B40")]
		private void Update()
		{
		}

		[Token(Token = "0x6000F29")]
		[Address(RVA = "0x1F02C34", Offset = "0x1F01C34", VA = "0x1F02C34")]
		public FPSCounter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000113")]
	public class LerpControlledBob
	{
		[Token(Token = "0x2000114")]
		[CompilerGenerated]
		private sealed class <DoBobCycle>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000871")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000872")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000873")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LerpControlledBob <>4__this;

			[Token(Token = "0x4000874")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x170001DF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000F30")]
				[Address(RVA = "0x1F02E70", Offset = "0x1F01E70", VA = "0x1F02E70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001E0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000F32")]
				[Address(RVA = "0x1F02EB0", Offset = "0x1F01EB0", VA = "0x1F02EB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000F2D")]
			[Address(RVA = "0x1F02CA4", Offset = "0x1F01CA4", VA = "0x1F02CA4")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000F2E")]
			[Address(RVA = "0x1F02CD4", Offset = "0x1F01CD4", VA = "0x1F02CD4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000F2F")]
			[Address(RVA = "0x1F02CD8", Offset = "0x1F01CD8", VA = "0x1F02CD8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000F31")]
			[Address(RVA = "0x1F02E78", Offset = "0x1F01E78", VA = "0x1F02E78", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float BobDuration;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float BobAmount;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Offset;

		[Token(Token = "0x6000F2A")]
		[Address(RVA = "0x1F02C3C", Offset = "0x1F01C3C", VA = "0x1F02C3C")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x6000F2B")]
		[Address(RVA = "0x1F02C44", Offset = "0x1F01C44", VA = "0x1F02C44")]
		[IteratorStateMachine(typeof(<DoBobCycle>d__4))]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x6000F2C")]
		[Address(RVA = "0x1F02CCC", Offset = "0x1F01CCC", VA = "0x1F02CCC")]
		public LerpControlledBob()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x2000116")]
		[CompilerGenerated]
		private sealed class <ResetCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000879")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400087A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400087B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x400087C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ObjectResetter <>4__this;

			[Token(Token = "0x170001E1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000F3A")]
				[Address(RVA = "0x1F03300", Offset = "0x1F02300", VA = "0x1F03300", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001E2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000F3C")]
				[Address(RVA = "0x1F03340", Offset = "0x1F02340", VA = "0x1F03340", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000F37")]
			[Address(RVA = "0x1F03050", Offset = "0x1F02050", VA = "0x1F03050")]
			[DebuggerHidden]
			public <ResetCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000F38")]
			[Address(RVA = "0x1F03080", Offset = "0x1F02080", VA = "0x1F03080", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000F39")]
			[Address(RVA = "0x1F03084", Offset = "0x1F02084", VA = "0x1F03084", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000F3B")]
			[Address(RVA = "0x1F03308", Offset = "0x1F02308", VA = "0x1F03308", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 originalPosition;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion originalRotation;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Transform> originalStructure;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Rigidbody Rigidbody;

		[Token(Token = "0x6000F33")]
		[Address(RVA = "0x1F02EB8", Offset = "0x1F01EB8", VA = "0x1F02EB8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000F34")]
		[Address(RVA = "0x1F02FC0", Offset = "0x1F01FC0", VA = "0x1F02FC0")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x6000F35")]
		[Address(RVA = "0x1F02FE0", Offset = "0x1F01FE0", VA = "0x1F02FE0")]
		[IteratorStateMachine(typeof(<ResetCoroutine>d__6))]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x6000F36")]
		[Address(RVA = "0x1F03078", Offset = "0x1F02078", VA = "0x1F03078")]
		public ObjectResetter()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x2000118")]
		[CompilerGenerated]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000881")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000882")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000883")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ParticleSystemDestroyer <>4__this;

			[Token(Token = "0x4000884")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ParticleSystem[] <systems>5__2;

			[Token(Token = "0x4000885")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <stopTime>5__3;

			[Token(Token = "0x170001E3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000F43")]
				[Address(RVA = "0x1F03704", Offset = "0x1F02704", VA = "0x1F03704", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001E4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000F45")]
				[Address(RVA = "0x1F03744", Offset = "0x1F02744", VA = "0x1F03744", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000F40")]
			[Address(RVA = "0x1F033A8", Offset = "0x1F023A8", VA = "0x1F033A8")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000F41")]
			[Address(RVA = "0x1F033F0", Offset = "0x1F023F0", VA = "0x1F033F0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000F42")]
			[Address(RVA = "0x1F033F4", Offset = "0x1F023F4", VA = "0x1F033F4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000F44")]
			[Address(RVA = "0x1F0370C", Offset = "0x1F0270C", VA = "0x1F0370C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minDuration;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float maxDuration;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_MaxLifetime;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool m_EarlyStop;

		[Token(Token = "0x6000F3D")]
		[Address(RVA = "0x1F03348", Offset = "0x1F02348", VA = "0x1F03348")]
		[IteratorStateMachine(typeof(<Start>d__4))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000F3E")]
		[Address(RVA = "0x1F033D0", Offset = "0x1F023D0", VA = "0x1F033D0")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000F3F")]
		[Address(RVA = "0x1F033DC", Offset = "0x1F023DC", VA = "0x1F033DC")]
		public ParticleSystemDestroyer()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class PlatformSpecificContent : MonoBehaviour
	{
		[Token(Token = "0x200011A")]
		private enum BuildTargetGroup
		{
			[Token(Token = "0x400088B")]
			Standalone,
			[Token(Token = "0x400088C")]
			Mobile
		}

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] m_Content;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_ChildrenOfThisObject;

		[Token(Token = "0x6000F46")]
		[Address(RVA = "0x1F0374C", Offset = "0x1F0274C", VA = "0x1F0374C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000F47")]
		[Address(RVA = "0x1F03750", Offset = "0x1F02750", VA = "0x1F03750")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x6000F48")]
		[Address(RVA = "0x1F03760", Offset = "0x1F02760", VA = "0x1F03760")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x6000F49")]
		[Address(RVA = "0x1F03B48", Offset = "0x1F02B48", VA = "0x1F03B48")]
		public PlatformSpecificContent()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class SimpleMouseRotator : MonoBehaviour
	{
		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2 rotationRange;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rotationSpeed;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float dampingTime;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool autoZeroVerticalOnMobile;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool autoZeroHorizontalOnMobile;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool relative;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 m_TargetAngles;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_FollowVelocity;

		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x6000F4A")]
		[Address(RVA = "0x1F03BCC", Offset = "0x1F02BCC", VA = "0x1F03BCC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000F4B")]
		[Address(RVA = "0x1F03BFC", Offset = "0x1F02BFC", VA = "0x1F03BFC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000F4C")]
		[Address(RVA = "0x1F0407C", Offset = "0x1F0307C", VA = "0x1F0407C")]
		public SimpleMouseRotator()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float height;

		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x6000F4D")]
		[Address(RVA = "0x1F0409C", Offset = "0x1F0309C", VA = "0x1F0409C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000F4E")]
		[Address(RVA = "0x1F040A0", Offset = "0x1F030A0", VA = "0x1F040A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000F4F")]
		[Address(RVA = "0x1F043D4", Offset = "0x1F033D4", VA = "0x1F043D4")]
		public SmoothFollow()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class TimedObjectActivator : MonoBehaviour
	{
		[Token(Token = "0x200011E")]
		public enum Action
		{
			[Token(Token = "0x400089E")]
			Activate,
			[Token(Token = "0x400089F")]
			Deactivate,
			[Token(Token = "0x40008A0")]
			Destroy,
			[Token(Token = "0x40008A1")]
			ReloadLevel,
			[Token(Token = "0x40008A2")]
			Call
		}

		[Serializable]
		[Token(Token = "0x200011F")]
		public class Entry
		{
			[Token(Token = "0x40008A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject target;

			[Token(Token = "0x40008A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action action;

			[Token(Token = "0x40008A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float delay;

			[Token(Token = "0x6000F55")]
			[Address(RVA = "0x1F04700", Offset = "0x1F03700", VA = "0x1F04700")]
			public Entry()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000120")]
		public class Entries
		{
			[Token(Token = "0x40008A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Entry[] entries;

			[Token(Token = "0x6000F56")]
			[Address(RVA = "0x1F046F8", Offset = "0x1F036F8", VA = "0x1F046F8")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x2000121")]
		[CompilerGenerated]
		private sealed class <Activate>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x170001E5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000F5A")]
				[Address(RVA = "0x1F047CC", Offset = "0x1F037CC", VA = "0x1F047CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001E6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000F5C")]
				[Address(RVA = "0x1F0480C", Offset = "0x1F0380C", VA = "0x1F0480C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000F57")]
			[Address(RVA = "0x1F04620", Offset = "0x1F03620", VA = "0x1F04620")]
			[DebuggerHidden]
			public <Activate>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000F58")]
			[Address(RVA = "0x1F04708", Offset = "0x1F03708", VA = "0x1F04708", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000F59")]
			[Address(RVA = "0x1F0470C", Offset = "0x1F0370C", VA = "0x1F0470C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000F5B")]
			[Address(RVA = "0x1F047D4", Offset = "0x1F037D4", VA = "0x1F047D4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000122")]
		[CompilerGenerated]
		private sealed class <Deactivate>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x170001E7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000F60")]
				[Address(RVA = "0x1F048D8", Offset = "0x1F038D8", VA = "0x1F048D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001E8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000F62")]
				[Address(RVA = "0x1F04918", Offset = "0x1F03918", VA = "0x1F04918", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000F5D")]
			[Address(RVA = "0x1F04648", Offset = "0x1F03648", VA = "0x1F04648")]
			[DebuggerHidden]
			public <Deactivate>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000F5E")]
			[Address(RVA = "0x1F04814", Offset = "0x1F03814", VA = "0x1F04814", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000F5F")]
			[Address(RVA = "0x1F04818", Offset = "0x1F03818", VA = "0x1F04818", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000F61")]
			[Address(RVA = "0x1F048E0", Offset = "0x1F038E0", VA = "0x1F048E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000123")]
		[CompilerGenerated]
		private sealed class <ReloadLevel>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x170001E9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000F66")]
				[Address(RVA = "0x1F04A18", Offset = "0x1F03A18", VA = "0x1F04A18", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001EA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000F68")]
				[Address(RVA = "0x1F04A58", Offset = "0x1F03A58", VA = "0x1F04A58", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000F63")]
			[Address(RVA = "0x1F04670", Offset = "0x1F03670", VA = "0x1F04670")]
			[DebuggerHidden]
			public <ReloadLevel>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000F64")]
			[Address(RVA = "0x1F04920", Offset = "0x1F03920", VA = "0x1F04920", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000F65")]
			[Address(RVA = "0x1F04924", Offset = "0x1F03924", VA = "0x1F04924", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000F67")]
			[Address(RVA = "0x1F04A20", Offset = "0x1F03A20", VA = "0x1F04A20", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Entries entries;

		[Token(Token = "0x6000F50")]
		[Address(RVA = "0x1F043E8", Offset = "0x1F033E8", VA = "0x1F043E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000F51")]
		[Address(RVA = "0x1F04500", Offset = "0x1F03500", VA = "0x1F04500")]
		[IteratorStateMachine(typeof(<Activate>d__5))]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000F52")]
		[Address(RVA = "0x1F04560", Offset = "0x1F03560", VA = "0x1F04560")]
		[IteratorStateMachine(typeof(<Deactivate>d__6))]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000F53")]
		[Address(RVA = "0x1F045C0", Offset = "0x1F035C0", VA = "0x1F045C0")]
		[IteratorStateMachine(typeof(<ReloadLevel>d__7))]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000F54")]
		[Address(RVA = "0x1F04698", Offset = "0x1F03698", VA = "0x1F04698")]
		public TimedObjectActivator()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class TimedObjectDestructor : MonoBehaviour
	{
		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_TimeOut;

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool m_DetachChildren;

		[Token(Token = "0x6000F69")]
		[Address(RVA = "0x1F04A60", Offset = "0x1F03A60", VA = "0x1F04A60")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000F6A")]
		[Address(RVA = "0x1F04AB0", Offset = "0x1F03AB0", VA = "0x1F04AB0")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x6000F6B")]
		[Address(RVA = "0x1F04B40", Offset = "0x1F03B40", VA = "0x1F04B40")]
		public TimedObjectDestructor()
		{
		}
	}
	[Token(Token = "0x2000125")]
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000126")]
		public class WaypointList
		{
			[Token(Token = "0x40008C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public WaypointCircuit circuit;

			[Token(Token = "0x40008C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform[] items;

			[Token(Token = "0x6000F78")]
			[Address(RVA = "0x1F05618", Offset = "0x1F04618", VA = "0x1F05618")]
			public WaypointList()
			{
			}
		}

		[Token(Token = "0x2000127")]
		public struct RoutePoint
		{
			[Token(Token = "0x40008C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x40008C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 direction;

			[Token(Token = "0x6000F79")]
			[Address(RVA = "0x1F05218", Offset = "0x1F04218", VA = "0x1F05218")]
			public RoutePoint(Vector3 position, Vector3 direction)
			{
			}
		}

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaypointList waypointList;

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool smoothRoute;

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int numPoints;

		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3[] points;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float[] distances;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float editorVisualisationSubsteps;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int p0n;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int p1n;

		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int p2n;

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int p3n;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float i;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 P0;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 P1;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 P2;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 P3;

		[Token(Token = "0x170001EB")]
		public float Length
		{
			[Token(Token = "0x6000F6C")]
			[Address(RVA = "0x1F04B50", Offset = "0x1F03B50", VA = "0x1F04B50")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000F6D")]
			[Address(RVA = "0x1F04B58", Offset = "0x1F03B58", VA = "0x1F04B58")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170001EC")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x6000F6E")]
			[Address(RVA = "0x1F04B60", Offset = "0x1F03B60", VA = "0x1F04B60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000F6F")]
		[Address(RVA = "0x1F04B7C", Offset = "0x1F03B7C", VA = "0x1F04B7C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000F70")]
		[Address(RVA = "0x1F04E8C", Offset = "0x1F03E8C", VA = "0x1F04E8C")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x6000F71")]
		[Address(RVA = "0x1F04FBC", Offset = "0x1F03FBC", VA = "0x1F04FBC")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000F72")]
		[Address(RVA = "0x1F05228", Offset = "0x1F04228", VA = "0x1F05228")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000F73")]
		[Address(RVA = "0x1F04BCC", Offset = "0x1F03BCC", VA = "0x1F04BCC")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x6000F74")]
		[Address(RVA = "0x1F05334", Offset = "0x1F04334", VA = "0x1F05334")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000F75")]
		[Address(RVA = "0x1F055A4", Offset = "0x1F045A4", VA = "0x1F055A4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000F76")]
		[Address(RVA = "0x1F0533C", Offset = "0x1F0433C", VA = "0x1F0533C")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x6000F77")]
		[Address(RVA = "0x1F055AC", Offset = "0x1F045AC", VA = "0x1F055AC")]
		public WaypointCircuit()
		{
		}
	}
	[Token(Token = "0x2000128")]
	public class WaypointProgressTracker : MonoBehaviour
	{
		[Token(Token = "0x2000129")]
		public enum ProgressStyle
		{
			[Token(Token = "0x40008D6")]
			SmoothAlongRoute,
			[Token(Token = "0x40008D7")]
			PointToPoint
		}

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WaypointCircuit circuit;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float lookAheadForTargetOffset;

		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float lookAheadForTargetFactor;

		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float lookAheadForSpeedOffset;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float lookAheadForSpeedFactor;

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ProgressStyle progressStyle;

		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float pointToPointThreshold;

		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform target;

		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float progressDistance;

		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int progressNum;

		[Token(Token = "0x40008D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 lastPosition;

		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float speed;

		[Token(Token = "0x170001ED")]
		public WaypointCircuit.RoutePoint targetPoint
		{
			[Token(Token = "0x6000F7A")]
			[Address(RVA = "0x1F05670", Offset = "0x1F04670", VA = "0x1F05670")]
			[CompilerGenerated]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000F7B")]
			[Address(RVA = "0x1F05684", Offset = "0x1F04684", VA = "0x1F05684")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170001EE")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x6000F7C")]
			[Address(RVA = "0x1F05698", Offset = "0x1F04698", VA = "0x1F05698")]
			[CompilerGenerated]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000F7D")]
			[Address(RVA = "0x1F056AC", Offset = "0x1F046AC", VA = "0x1F056AC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170001EF")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x6000F7E")]
			[Address(RVA = "0x1F056C0", Offset = "0x1F046C0", VA = "0x1F056C0")]
			[CompilerGenerated]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000F7F")]
			[Address(RVA = "0x1F056D4", Offset = "0x1F046D4", VA = "0x1F056D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000F80")]
		[Address(RVA = "0x1F056E8", Offset = "0x1F046E8", VA = "0x1F056E8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000F81")]
		[Address(RVA = "0x1F057CC", Offset = "0x1F047CC", VA = "0x1F057CC")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000F82")]
		[Address(RVA = "0x1F05898", Offset = "0x1F04898", VA = "0x1F05898")]
		private void Update()
		{
		}

		[Token(Token = "0x6000F83")]
		[Address(RVA = "0x1F05D88", Offset = "0x1F04D88", VA = "0x1F05D88")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000F84")]
		[Address(RVA = "0x1F05F24", Offset = "0x1F04F24", VA = "0x1F05F24")]
		public WaypointProgressTracker()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x200012A")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string axisName;

		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float axisValue;

		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float responseSpeed;

		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float returnToCentreSpeed;

		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x6000F85")]
		[Address(RVA = "0x1F05F40", Offset = "0x1F04F40", VA = "0x1F05F40")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000F86")]
		[Address(RVA = "0x1F06188", Offset = "0x1F05188", VA = "0x1F06188")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x6000F87")]
		[Address(RVA = "0x1F06300", Offset = "0x1F05300", VA = "0x1F06300")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000F88")]
		[Address(RVA = "0x1F06370", Offset = "0x1F05370", VA = "0x1F06370", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000F89")]
		[Address(RVA = "0x1F06434", Offset = "0x1F05434", VA = "0x1F06434", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000F8A")]
		[Address(RVA = "0x1F06490", Offset = "0x1F05490", VA = "0x1F06490")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Name;

		[Token(Token = "0x6000F8B")]
		[Address(RVA = "0x1F064F4", Offset = "0x1F054F4", VA = "0x1F064F4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000F8C")]
		[Address(RVA = "0x1F064F8", Offset = "0x1F054F8", VA = "0x1F064F8")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x6000F8D")]
		[Address(RVA = "0x1F065C0", Offset = "0x1F055C0", VA = "0x1F065C0")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x6000F8E")]
		[Address(RVA = "0x1F06688", Offset = "0x1F05688", VA = "0x1F06688")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x6000F8F")]
		[Address(RVA = "0x1F06750", Offset = "0x1F05750", VA = "0x1F06750")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x6000F90")]
		[Address(RVA = "0x1F06818", Offset = "0x1F05818", VA = "0x1F06818")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x6000F91")]
		[Address(RVA = "0x1F068E0", Offset = "0x1F058E0", VA = "0x1F068E0")]
		public void Update()
		{
		}

		[Token(Token = "0x6000F92")]
		[Address(RVA = "0x1F068E4", Offset = "0x1F058E4", VA = "0x1F068E4")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x200012C")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x200012D")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x40008E3")]
			Hardware,
			[Token(Token = "0x40008E4")]
			Touch
		}

		[Token(Token = "0x200012E")]
		public class VirtualAxis
		{
			[Token(Token = "0x40008E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x170001F1")]
			public string name
			{
				[Token(Token = "0x6000FAC")]
				[Address(RVA = "0x1F07610", Offset = "0x1F06610", VA = "0x1F07610")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000FAD")]
				[Address(RVA = "0x1F07618", Offset = "0x1F06618", VA = "0x1F07618")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170001F2")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000FAE")]
				[Address(RVA = "0x1F07620", Offset = "0x1F06620", VA = "0x1F07620")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000FAF")]
				[Address(RVA = "0x1F07628", Offset = "0x1F06628", VA = "0x1F07628")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170001F3")]
			public float GetValue
			{
				[Token(Token = "0x6000FB4")]
				[Address(RVA = "0x1F07670", Offset = "0x1F06670", VA = "0x1F07670")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170001F4")]
			public float GetValueRaw
			{
				[Token(Token = "0x6000FB5")]
				[Address(RVA = "0x1F07678", Offset = "0x1F06678", VA = "0x1F07678")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000FB0")]
			[Address(RVA = "0x1F06088", Offset = "0x1F05088", VA = "0x1F06088")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x6000FB1")]
			[Address(RVA = "0x1F07634", Offset = "0x1F06634", VA = "0x1F07634")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000FB2")]
			[Address(RVA = "0x1F06318", Offset = "0x1F05318", VA = "0x1F06318")]
			public void Remove()
			{
			}

			[Token(Token = "0x6000FB3")]
			[Address(RVA = "0x1F07668", Offset = "0x1F06668", VA = "0x1F07668")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x200012F")]
		public class VirtualButton
		{
			[Token(Token = "0x40008EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x40008EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x40008EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x170001F5")]
			public string name
			{
				[Token(Token = "0x6000FB6")]
				[Address(RVA = "0x1F07680", Offset = "0x1F06680", VA = "0x1F07680")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000FB7")]
				[Address(RVA = "0x1F07688", Offset = "0x1F06688", VA = "0x1F07688")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170001F6")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000FB8")]
				[Address(RVA = "0x1F07690", Offset = "0x1F06690", VA = "0x1F07690")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000FB9")]
				[Address(RVA = "0x1F07698", Offset = "0x1F06698", VA = "0x1F07698")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170001F7")]
			public bool GetButton
			{
				[Token(Token = "0x6000FBF")]
				[Address(RVA = "0x1F077BC", Offset = "0x1F067BC", VA = "0x1F077BC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170001F8")]
			public bool GetButtonDown
			{
				[Token(Token = "0x6000FC0")]
				[Address(RVA = "0x1F077C4", Offset = "0x1F067C4", VA = "0x1F077C4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170001F9")]
			public bool GetButtonUp
			{
				[Token(Token = "0x6000FC1")]
				[Address(RVA = "0x1F077E8", Offset = "0x1F067E8", VA = "0x1F077E8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000FBA")]
			[Address(RVA = "0x1F076A4", Offset = "0x1F066A4", VA = "0x1F076A4")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x6000FBB")]
			[Address(RVA = "0x1F076DC", Offset = "0x1F066DC", VA = "0x1F076DC")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000FBC")]
			[Address(RVA = "0x1F07718", Offset = "0x1F06718", VA = "0x1F07718")]
			public void Pressed()
			{
			}

			[Token(Token = "0x6000FBD")]
			[Address(RVA = "0x1F07744", Offset = "0x1F06744", VA = "0x1F07744")]
			public void Released()
			{
			}

			[Token(Token = "0x6000FBE")]
			[Address(RVA = "0x1F07764", Offset = "0x1F06764", VA = "0x1F07764")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x170001F0")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x6000FA8")]
			[Address(RVA = "0x1F0743C", Offset = "0x1F0643C", VA = "0x1F0743C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000F93")]
		[Address(RVA = "0x1F068EC", Offset = "0x1F058EC", VA = "0x1F068EC")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x6000F94")]
		[Address(RVA = "0x1F069A0", Offset = "0x1F059A0", VA = "0x1F069A0")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x6000F95")]
		[Address(RVA = "0x1F06020", Offset = "0x1F05020", VA = "0x1F06020")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000F96")]
		[Address(RVA = "0x1F06A90", Offset = "0x1F05A90", VA = "0x1F06A90")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000F97")]
		[Address(RVA = "0x1F060B8", Offset = "0x1F050B8", VA = "0x1F060B8")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x6000F98")]
		[Address(RVA = "0x1F06CD4", Offset = "0x1F05CD4", VA = "0x1F06CD4")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x6000F99")]
		[Address(RVA = "0x1F06EC0", Offset = "0x1F05EC0", VA = "0x1F06EC0")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x6000F9A")]
		[Address(RVA = "0x1F07004", Offset = "0x1F06004", VA = "0x1F07004")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x6000F9B")]
		[Address(RVA = "0x1F06120", Offset = "0x1F05120", VA = "0x1F06120")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x6000F9C")]
		[Address(RVA = "0x1F04024", Offset = "0x1F03024", VA = "0x1F04024")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x6000F9D")]
		[Address(RVA = "0x1F07210", Offset = "0x1F06210", VA = "0x1F07210")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x6000F9E")]
		[Address(RVA = "0x1F07190", Offset = "0x1F06190", VA = "0x1F07190")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000F9F")]
		[Address(RVA = "0x1F07268", Offset = "0x1F06268", VA = "0x1F07268")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000FA0")]
		[Address(RVA = "0x1F072D8", Offset = "0x1F062D8", VA = "0x1F072D8")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000FA1")]
		[Address(RVA = "0x1F07348", Offset = "0x1F06348", VA = "0x1F07348")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000FA2")]
		[Address(RVA = "0x1F06550", Offset = "0x1F05550", VA = "0x1F06550")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000FA3")]
		[Address(RVA = "0x1F06618", Offset = "0x1F05618", VA = "0x1F06618")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000FA4")]
		[Address(RVA = "0x1F066E0", Offset = "0x1F056E0", VA = "0x1F066E0")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000FA5")]
		[Address(RVA = "0x1F06870", Offset = "0x1F05870", VA = "0x1F06870")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000FA6")]
		[Address(RVA = "0x1F067A8", Offset = "0x1F057A8", VA = "0x1F067A8")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000FA7")]
		[Address(RVA = "0x1F073B8", Offset = "0x1F063B8", VA = "0x1F073B8")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000FA9")]
		[Address(RVA = "0x1F074A8", Offset = "0x1F064A8", VA = "0x1F074A8")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x6000FAA")]
		[Address(RVA = "0x1F07520", Offset = "0x1F06520", VA = "0x1F07520")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x6000FAB")]
		[Address(RVA = "0x1F07598", Offset = "0x1F06598", VA = "0x1F07598")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x2000130")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string axis;

		[Token(Token = "0x6000FC2")]
		[Address(RVA = "0x1F0780C", Offset = "0x1F0680C", VA = "0x1F0780C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000FC3")]
		[Address(RVA = "0x1F07810", Offset = "0x1F06810", VA = "0x1F07810")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x6000FC4")]
		[Address(RVA = "0x1F07880", Offset = "0x1F06880", VA = "0x1F07880")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x2000131")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x2000132")]
		public enum AxisOption
		{
			[Token(Token = "0x40008F8")]
			Both,
			[Token(Token = "0x40008F9")]
			OnlyHorizontal,
			[Token(Token = "0x40008FA")]
			OnlyVertical
		}

		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int MovementRange;

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public AxisOption axesToUse;

		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string horizontalAxisName;

		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string verticalAxisName;

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool m_UseX;

		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		private bool m_UseY;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x6000FC5")]
		[Address(RVA = "0x1F07888", Offset = "0x1F06888", VA = "0x1F07888")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000FC6")]
		[Address(RVA = "0x1F079C8", Offset = "0x1F069C8", VA = "0x1F079C8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000FC7")]
		[Address(RVA = "0x1F079F8", Offset = "0x1F069F8", VA = "0x1F079F8")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x6000FC8")]
		[Address(RVA = "0x1F0788C", Offset = "0x1F0688C", VA = "0x1F0788C")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x6000FC9")]
		[Address(RVA = "0x1F07A58", Offset = "0x1F06A58", VA = "0x1F07A58", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000FCA")]
		[Address(RVA = "0x1F07BA4", Offset = "0x1F06BA4", VA = "0x1F07BA4", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000FCB")]
		[Address(RVA = "0x1F07BE0", Offset = "0x1F06BE0", VA = "0x1F07BE0", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000FCC")]
		[Address(RVA = "0x1F07BE4", Offset = "0x1F06BE4", VA = "0x1F07BE4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000FCD")]
		[Address(RVA = "0x1F07C24", Offset = "0x1F06C24", VA = "0x1F07C24")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x2000133")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x6000FCE")]
		[Address(RVA = "0x1F07C9C", Offset = "0x1F06C9C", VA = "0x1F07C9C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000FCF")]
		[Address(RVA = "0x1F07CAC", Offset = "0x1F06CAC", VA = "0x1F07CAC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000FD0")]
		[Address(RVA = "0x1F07CA4", Offset = "0x1F06CA4", VA = "0x1F07CA4")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x6000FD1")]
		[Address(RVA = "0x1F07DB4", Offset = "0x1F06DB4", VA = "0x1F07DB4")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x6000FD2")]
		[Address(RVA = "0x1F080AC", Offset = "0x1F070AC", VA = "0x1F080AC")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x2000134")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x2000135")]
		public enum AxisOptions
		{
			[Token(Token = "0x4000901")]
			ForwardAxis,
			[Token(Token = "0x4000902")]
			SidewaysAxis
		}

		[Serializable]
		[Token(Token = "0x2000136")]
		public class AxisMapping
		{
			[Token(Token = "0x2000137")]
			public enum MappingType
			{
				[Token(Token = "0x4000906")]
				NamedAxis,
				[Token(Token = "0x4000907")]
				MousePositionX,
				[Token(Token = "0x4000908")]
				MousePositionY,
				[Token(Token = "0x4000909")]
				MousePositionZ
			}

			[Token(Token = "0x4000903")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MappingType type;

			[Token(Token = "0x4000904")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string axisName;

			[Token(Token = "0x6000FD7")]
			[Address(RVA = "0x1F083EC", Offset = "0x1F073EC", VA = "0x1F083EC")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x40008FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AxisMapping mapping;

		[Token(Token = "0x40008FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float fullTiltAngle;

		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float centreAngleOffset;

		[Token(Token = "0x40008FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x6000FD3")]
		[Address(RVA = "0x1F080B4", Offset = "0x1F070B4", VA = "0x1F080B4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000FD4")]
		[Address(RVA = "0x1F08164", Offset = "0x1F07164", VA = "0x1F08164")]
		private void Update()
		{
		}

		[Token(Token = "0x6000FD5")]
		[Address(RVA = "0x1F083C4", Offset = "0x1F073C4", VA = "0x1F083C4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000FD6")]
		[Address(RVA = "0x1F083DC", Offset = "0x1F073DC", VA = "0x1F083DC")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x2000138")]
	[RequireComponent(typeof(Image))]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x2000139")]
		public enum AxisOption
		{
			[Token(Token = "0x400091D")]
			Both,
			[Token(Token = "0x400091E")]
			OnlyHorizontal,
			[Token(Token = "0x400091F")]
			OnlyVertical
		}

		[Token(Token = "0x200013A")]
		public enum ControlStyle
		{
			[Token(Token = "0x4000921")]
			Absolute,
			[Token(Token = "0x4000922")]
			Relative,
			[Token(Token = "0x4000923")]
			Swipe
		}

		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AxisOption axesToUse;

		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public ControlStyle controlStyle;

		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string horizontalAxisName;

		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string verticalAxisName;

		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float Xsensitivity;

		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float Ysensitivity;

		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 m_StartPos;

		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_UseX;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool m_UseY;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool m_Dragging;

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int m_Id;

		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 m_Center;

		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Image m_Image;

		[Token(Token = "0x6000FD8")]
		[Address(RVA = "0x1F083F4", Offset = "0x1F073F4", VA = "0x1F083F4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000FD9")]
		[Address(RVA = "0x1F08534", Offset = "0x1F07534", VA = "0x1F08534")]
		private void Start()
		{
		}

		[Token(Token = "0x6000FDA")]
		[Address(RVA = "0x1F083F8", Offset = "0x1F073F8", VA = "0x1F083F8")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x6000FDB")]
		[Address(RVA = "0x1F085A8", Offset = "0x1F075A8", VA = "0x1F085A8")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x6000FDC")]
		[Address(RVA = "0x1F086A8", Offset = "0x1F076A8", VA = "0x1F086A8", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000FDD")]
		[Address(RVA = "0x1F086E0", Offset = "0x1F076E0", VA = "0x1F086E0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000FDE")]
		[Address(RVA = "0x1F088B8", Offset = "0x1F078B8", VA = "0x1F088B8", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000FDF")]
		[Address(RVA = "0x1F08918", Offset = "0x1F07918", VA = "0x1F08918")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000FE0")]
		[Address(RVA = "0x1F089D8", Offset = "0x1F079D8", VA = "0x1F089D8")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x200013B")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x170001FA")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x6000FE1")]
			[Address(RVA = "0x1F08A58", Offset = "0x1F07A58", VA = "0x1F08A58")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000FE2")]
			[Address(RVA = "0x1F08A64", Offset = "0x1F07A64", VA = "0x1F08A64")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000FE3")]
		[Address(RVA = "0x1F06A38", Offset = "0x1F05A38", VA = "0x1F06A38")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000FE4")]
		[Address(RVA = "0x1F06AF8", Offset = "0x1F05AF8", VA = "0x1F06AF8")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000FE5")]
		[Address(RVA = "0x1F06B50", Offset = "0x1F05B50", VA = "0x1F06B50")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x6000FE6")]
		[Address(RVA = "0x1F06D3C", Offset = "0x1F05D3C", VA = "0x1F06D3C")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x6000FE7")]
		[Address(RVA = "0x1F06F74", Offset = "0x1F05F74", VA = "0x1F06F74")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x6000FE8")]
		[Address(RVA = "0x1F0706C", Offset = "0x1F0606C", VA = "0x1F0706C")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x6000FE9")]
		[Address(RVA = "0x1F070FC", Offset = "0x1F060FC", VA = "0x1F070FC")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x6000FEA")]
		[Address(RVA = "0x1F07518", Offset = "0x1F06518", VA = "0x1F07518")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x6000FEB")]
		[Address(RVA = "0x1F07590", Offset = "0x1F06590", VA = "0x1F07590")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x6000FEC")]
		[Address(RVA = "0x1F07608", Offset = "0x1F06608", VA = "0x1F07608")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x6000FED")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x6000FEE")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x6000FEF")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x6000FF0")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x6000FF1")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x6000FF2")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x6000FF3")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x6000FF4")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x6000FF5")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x6000FF6")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x6000FF7")]
		public abstract Vector3 MousePosition();

		[Token(Token = "0x6000FF8")]
		[Address(RVA = "0x1F08A70", Offset = "0x1F07A70", VA = "0x1F08A70")]
		protected VirtualInput()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x200013C")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x6000FF9")]
		[Address(RVA = "0x1F08B7C", Offset = "0x1F07B7C", VA = "0x1F08B7C")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x6000FFA")]
		[Address(RVA = "0x1F08C14", Offset = "0x1F07C14", VA = "0x1F08C14")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x6000FFB")]
		[Address(RVA = "0x1F08CA4", Offset = "0x1F07CA4", VA = "0x1F08CA4", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000FFC")]
		[Address(RVA = "0x1F08D3C", Offset = "0x1F07D3C", VA = "0x1F08D3C", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000FFD")]
		[Address(RVA = "0x1F08DF0", Offset = "0x1F07DF0", VA = "0x1F08DF0", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000FFE")]
		[Address(RVA = "0x1F08E98", Offset = "0x1F07E98", VA = "0x1F08E98", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000FFF")]
		[Address(RVA = "0x1F08F34", Offset = "0x1F07F34", VA = "0x1F08F34", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6001000")]
		[Address(RVA = "0x1F08FD0", Offset = "0x1F07FD0", VA = "0x1F08FD0", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6001001")]
		[Address(RVA = "0x1F09068", Offset = "0x1F08068", VA = "0x1F09068", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6001002")]
		[Address(RVA = "0x1F0910C", Offset = "0x1F0810C", VA = "0x1F0910C", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6001003")]
		[Address(RVA = "0x1F091B8", Offset = "0x1F081B8", VA = "0x1F091B8", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6001004")]
		[Address(RVA = "0x1F09264", Offset = "0x1F08264", VA = "0x1F09264", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6001005")]
		[Address(RVA = "0x1F092FC", Offset = "0x1F082FC", VA = "0x1F092FC", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6001006")]
		[Address(RVA = "0x1F06998", Offset = "0x1F05998", VA = "0x1F06998")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x200013D")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x6001007")]
		[Address(RVA = "0x1F09308", Offset = "0x1F08308", VA = "0x1F09308", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6001008")]
		[Address(RVA = "0x1F0931C", Offset = "0x1F0831C", VA = "0x1F0931C", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6001009")]
		[Address(RVA = "0x1F09328", Offset = "0x1F08328", VA = "0x1F09328", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600100A")]
		[Address(RVA = "0x1F09334", Offset = "0x1F08334", VA = "0x1F09334", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600100B")]
		[Address(RVA = "0x1F09340", Offset = "0x1F08340", VA = "0x1F09340", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600100C")]
		[Address(RVA = "0x1F0938C", Offset = "0x1F0838C", VA = "0x1F0938C", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600100D")]
		[Address(RVA = "0x1F093D8", Offset = "0x1F083D8", VA = "0x1F093D8", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600100E")]
		[Address(RVA = "0x1F09424", Offset = "0x1F08424", VA = "0x1F09424", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600100F")]
		[Address(RVA = "0x1F09470", Offset = "0x1F08470", VA = "0x1F09470", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6001010")]
		[Address(RVA = "0x1F094BC", Offset = "0x1F084BC", VA = "0x1F094BC", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6001011")]
		[Address(RVA = "0x1F09508", Offset = "0x1F08508", VA = "0x1F09508", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6001012")]
		[Address(RVA = "0x1F0699C", Offset = "0x1F0599C", VA = "0x1F0699C")]
		public StandaloneInput()
		{
		}
	}
}
namespace UnityStandardAssets.Cameras
{
	[Token(Token = "0x200013E")]
	public abstract class AbstractTargetFollower : MonoBehaviour
	{
		[Token(Token = "0x200013F")]
		public enum UpdateType
		{
			[Token(Token = "0x400092D")]
			FixedUpdate,
			[Token(Token = "0x400092E")]
			LateUpdate,
			[Token(Token = "0x400092F")]
			ManualUpdate
		}

		[Token(Token = "0x4000928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Transform m_Target;

		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool m_AutoTargetPlayer;

		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private UpdateType m_UpdateType;

		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Rigidbody targetRigidbody;

		[Token(Token = "0x170001FB")]
		public Transform Target
		{
			[Token(Token = "0x600101A")]
			[Address(RVA = "0x1F098D4", Offset = "0x1F088D4", VA = "0x1F098D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001013")]
		[Address(RVA = "0x1F09510", Offset = "0x1F08510", VA = "0x1F09510", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6001014")]
		[Address(RVA = "0x1F09678", Offset = "0x1F08678", VA = "0x1F09678")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6001015")]
		[Address(RVA = "0x1F0973C", Offset = "0x1F0873C", VA = "0x1F0973C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6001016")]
		[Address(RVA = "0x1F09804", Offset = "0x1F08804", VA = "0x1F09804")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x6001017")]
		protected abstract void FollowTarget(float deltaTime);

		[Token(Token = "0x6001018")]
		[Address(RVA = "0x1F095B4", Offset = "0x1F085B4", VA = "0x1F095B4")]
		public void FindAndTargetPlayer()
		{
		}

		[Token(Token = "0x6001019")]
		[Address(RVA = "0x1F098CC", Offset = "0x1F088CC", VA = "0x1F098CC", Slot = "6")]
		public virtual void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x600101B")]
		[Address(RVA = "0x1F098DC", Offset = "0x1F088DC", VA = "0x1F098DC")]
		protected AbstractTargetFollower()
		{
		}
	}
	[Token(Token = "0x2000140")]
	[ExecuteInEditMode]
	public class AutoCam : PivotBasedCameraRig
	{
		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_TurnSpeed;

		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_RollSpeed;

		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool m_FollowVelocity;

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[SerializeField]
		private bool m_FollowTilt;

		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_SpinTurnLimit;

		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_TargetVelocityLowerLimit;

		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float m_SmoothTurnTime;

		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_LastFlatAngle;

		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float m_CurrentTurnAmount;

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float m_TurnSpeedVelocityChange;

		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 m_RollUp;

		[Token(Token = "0x600101C")]
		[Address(RVA = "0x1F098EC", Offset = "0x1F088EC", VA = "0x1F098EC", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x600101D")]
		[Address(RVA = "0x1F09EF0", Offset = "0x1F08EF0", VA = "0x1F09EF0")]
		public AutoCam()
		{
		}
	}
	[Token(Token = "0x2000141")]
	public class HandHeldCam : LookatTarget
	{
		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float m_SwaySpeed;

		[Token(Token = "0x400093D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float m_BaseSwayAmount;

		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float m_TrackingSwayAmount;

		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Range(-1f, 1f)]
		private float m_TrackingBias;

		[Token(Token = "0x600101E")]
		[Address(RVA = "0x1F09F90", Offset = "0x1F08F90", VA = "0x1F09F90", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x600101F")]
		[Address(RVA = "0x1F0A430", Offset = "0x1F09430", VA = "0x1F0A430")]
		public HandHeldCam()
		{
		}
	}
	[Token(Token = "0x2000142")]
	public class LookatTarget : AbstractTargetFollower
	{
		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector2 m_RotationRange;

		[Token(Token = "0x4000941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_FollowSpeed;

		[Token(Token = "0x4000942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected Vector3 m_FollowVelocity;

		[Token(Token = "0x6001020")]
		[Address(RVA = "0x1F0A470", Offset = "0x1F09470", VA = "0x1F0A470", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6001021")]
		[Address(RVA = "0x1F0A0C8", Offset = "0x1F090C8", VA = "0x1F0A0C8", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x6001022")]
		[Address(RVA = "0x1F0A458", Offset = "0x1F09458", VA = "0x1F0A458")]
		public LookatTarget()
		{
		}
	}
	[Token(Token = "0x2000143")]
	public abstract class PivotBasedCameraRig : AbstractTargetFollower
	{
		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Transform m_Cam;

		[Token(Token = "0x4000946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform m_Pivot;

		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Vector3 m_LastTargetPosition;

		[Token(Token = "0x6001023")]
		[Address(RVA = "0x1F0A4A8", Offset = "0x1F094A8", VA = "0x1F0A4A8", Slot = "7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6001024")]
		[Address(RVA = "0x1F09F80", Offset = "0x1F08F80", VA = "0x1F09F80")]
		protected PivotBasedCameraRig()
		{
		}
	}
	[Token(Token = "0x2000144")]
	public class ProtectCameraFromWallClip : MonoBehaviour
	{
		[Token(Token = "0x2000145")]
		public class RayHitComparer : IComparer
		{
			[Token(Token = "0x600102A")]
			[Address(RVA = "0x1F0ACB4", Offset = "0x1F09CB4", VA = "0x1F0ACB4", Slot = "4")]
			public int Compare(object x, object y)
			{
				return default(int);
			}

			[Token(Token = "0x600102B")]
			[Address(RVA = "0x1F0A650", Offset = "0x1F09650", VA = "0x1F0A650")]
			public RayHitComparer()
			{
			}
		}

		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float clipMoveTime;

		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float returnTime;

		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float sphereCastRadius;

		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool visualiseInEditor;

		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float closestDistance;

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string dontClipTag;

		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform m_Cam;

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform m_Pivot;

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_OriginalDist;

		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float m_MoveVelocity;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float m_CurrentDist;

		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Ray m_Ray;

		[Token(Token = "0x4000955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RaycastHit[] m_Hits;

		[Token(Token = "0x4000956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RayHitComparer m_RayHitComparer;

		[Token(Token = "0x170001FC")]
		public bool protecting
		{
			[Token(Token = "0x6001025")]
			[Address(RVA = "0x1F0A518", Offset = "0x1F09518", VA = "0x1F0A518")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001026")]
			[Address(RVA = "0x1F0A520", Offset = "0x1F09520", VA = "0x1F0A520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6001027")]
		[Address(RVA = "0x1F0A52C", Offset = "0x1F0952C", VA = "0x1F0A52C")]
		private void Start()
		{
		}

		[Token(Token = "0x6001028")]
		[Address(RVA = "0x1F0A658", Offset = "0x1F09658", VA = "0x1F0A658")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6001029")]
		[Address(RVA = "0x1F0AC44", Offset = "0x1F09C44", VA = "0x1F0AC44")]
		public ProtectCameraFromWallClip()
		{
		}
	}
	[Token(Token = "0x2000146")]
	public class TargetFieldOfView : AbstractTargetFollower
	{
		[Token(Token = "0x4000957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_FovAdjustTime;

		[Token(Token = "0x4000958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_ZoomAmountMultiplier;

		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_IncludeEffectsInSize;

		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_BoundSize;

		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_FovAdjustVelocity;

		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Camera m_Cam;

		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform m_LastTarget;

		[Token(Token = "0x600102C")]
		[Address(RVA = "0x1F0ADA8", Offset = "0x1F09DA8", VA = "0x1F0ADA8", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600102D")]
		[Address(RVA = "0x1F0B0F0", Offset = "0x1F0A0F0", VA = "0x1F0B0F0", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x600102E")]
		[Address(RVA = "0x1F0B230", Offset = "0x1F0A230", VA = "0x1F0B230", Slot = "6")]
		public override void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x600102F")]
		[Address(RVA = "0x1F0AE10", Offset = "0x1F09E10", VA = "0x1F0AE10")]
		public static float MaxBoundsExtent(Transform obj, bool includeEffects)
		{
			return default(float);
		}

		[Token(Token = "0x6001030")]
		[Address(RVA = "0x1F0B254", Offset = "0x1F0A254", VA = "0x1F0B254")]
		public TargetFieldOfView()
		{
		}
	}
}
namespace TOZ
{
	[Token(Token = "0x2000147")]
	public static class Texture2DEx
	{
		[Token(Token = "0x6001031")]
		[Address(RVA = "0x1F0B270", Offset = "0x1F0A270", VA = "0x1F0B270")]
		public static void Fill(this Texture2D self, Color color)
		{
		}

		[Token(Token = "0x6001032")]
		[Address(RVA = "0x1F0B368", Offset = "0x1F0A368", VA = "0x1F0B368")]
		public static Texture2D Resample(this Texture2D self, int width, int height, TextureFormat format, bool mipmaps)
		{
			return null;
		}
	}
}
namespace DentedPixel
{
	[Token(Token = "0x2000148")]
	public class LeanDummy
	{
		[Token(Token = "0x6001033")]
		[Address(RVA = "0x1F0B548", Offset = "0x1F0A548", VA = "0x1F0B548")]
		public LeanDummy()
		{
		}
	}
}
