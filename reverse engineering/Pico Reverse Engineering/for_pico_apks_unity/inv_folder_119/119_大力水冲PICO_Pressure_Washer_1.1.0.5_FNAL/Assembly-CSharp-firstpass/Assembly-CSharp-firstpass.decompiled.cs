using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Es.InkPainter.Effective;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.OpenXR.Features;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class DebugTool : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool Touched;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool isTouchLong;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float timer;

	[Token(Token = "0x4000004")]
	private const float touchLongTime = 0.5f;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject IngameDebugConsole;

	[Token(Token = "0x17000001")]
	public static DebugTool Instance
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0xE0E6A8", Offset = "0xE0E6A8", VA = "0xE0E6A8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000002")]
		[Address(RVA = "0xE0E6F0", Offset = "0xE0E6F0", VA = "0xE0E6F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xE0E73C", Offset = "0xE0E73C", VA = "0xE0E73C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xE0E91C", Offset = "0xE0E91C", VA = "0xE0E91C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xE0E9D4", Offset = "0xE0E9D4", VA = "0xE0E9D4")]
	private bool CheckGripPressed()
	{
		return default(bool);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xE0EBE4", Offset = "0xE0EBE4", VA = "0xE0EBE4")]
	public void ShowIngameDebugConsole()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xE0ED44", Offset = "0xE0ED44", VA = "0xE0ED44")]
	public DebugTool()
	{
	}
}
[Token(Token = "0x2000003")]
public class FPSTool : MonoBehaviour
{
	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text LoggerText;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text fpsText;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float fps;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float time;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int frameCount;

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xE0ED4C", Offset = "0xE0ED4C", VA = "0xE0ED4C")]
	public void RecordBtnClick()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xE0F03C", Offset = "0xE0F03C", VA = "0xE0F03C")]
	private void Update()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xE0F130", Offset = "0xE0F130", VA = "0xE0F130")]
	public FPSTool()
	{
	}
}
[Token(Token = "0x2000004")]
[DefaultExecutionOrder(10)]
[AddComponentMenu("XR/Action Based Controller Manager")]
public class ActionBasedControllerManager : MonoBehaviour
{
	[Token(Token = "0x2000005")]
	public enum StateId
	{
		[Token(Token = "0x4000020")]
		None,
		[Token(Token = "0x4000021")]
		Select,
		[Token(Token = "0x4000022")]
		Teleport,
		[Token(Token = "0x4000023")]
		Interact
	}

	[Serializable]
	[Token(Token = "0x2000006")]
	public class StateEnterEvent : UnityEvent<StateId>
	{
		[Token(Token = "0x6000035")]
		[Address(RVA = "0xE10B2C", Offset = "0xE10B2C", VA = "0xE10B2C")]
		public StateEnterEvent()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000007")]
	public class StateUpdateEvent : UnityEvent
	{
		[Token(Token = "0x6000036")]
		[Address(RVA = "0xE10B74", Offset = "0xE10B74", VA = "0xE10B74")]
		public StateUpdateEvent()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000008")]
	public class StateExitEvent : UnityEvent<StateId>
	{
		[Token(Token = "0x6000037")]
		[Address(RVA = "0xE10B7C", Offset = "0xE10B7C", VA = "0xE10B7C")]
		public StateExitEvent()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000009")]
	public class ControllerState
	{
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Sets the controller state to be active. For the default states, setting this value to true will automatically update their StateUpdateEvent.")]
		[SerializeField]
		private bool m_Enabled;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		[HideInInspector]
		private StateId m_Id;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private StateEnterEvent m_OnEnter;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StateUpdateEvent m_OnUpdate;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StateExitEvent m_OnExit;

		[Token(Token = "0x1700000D")]
		public bool enabled
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0xE10BC4", Offset = "0xE10BC4", VA = "0xE10BC4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000039")]
			[Address(RVA = "0xE10BCC", Offset = "0xE10BCC", VA = "0xE10BCC")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public StateId id
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0xE10BD8", Offset = "0xE10BD8", VA = "0xE10BD8")]
			get
			{
				return default(StateId);
			}
			[Token(Token = "0x600003B")]
			[Address(RVA = "0xE10BE0", Offset = "0xE10BE0", VA = "0xE10BE0")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public StateEnterEvent onEnter
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0xE10BE8", Offset = "0xE10BE8", VA = "0xE10BE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003D")]
			[Address(RVA = "0xE10BF0", Offset = "0xE10BF0", VA = "0xE10BF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public StateUpdateEvent onUpdate
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0xE10BF8", Offset = "0xE10BF8", VA = "0xE10BF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003F")]
			[Address(RVA = "0xE10C00", Offset = "0xE10C00", VA = "0xE10C00")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public StateExitEvent onExit
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0xE10C08", Offset = "0xE10C08", VA = "0xE10C08")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000041")]
			[Address(RVA = "0xE10C10", Offset = "0xE10C10", VA = "0xE10C10")]
			set
			{
			}
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xE10A58", Offset = "0xE10A58", VA = "0xE10A58")]
		public ControllerState(StateId defaultId = StateId.None)
		{
		}
	}

	[Token(Token = "0x400000C")]
	public const int kControllerManagerUpdateOrder = 10;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Space]
	[Header("Controller GameObjects")]
	[FormerlySerializedAs("m_BaseControllerGO")]
	[Tooltip("The base controller GameObject, used for changing default settings on its components during state transitions.")]
	private GameObject m_BaseControllerGameObject;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[FormerlySerializedAs("m_TeleportControllerGO")]
	[Tooltip("The teleport controller GameObject, used for changing default settings on its components during state transitions.")]
	private GameObject m_TeleportControllerGameObject;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("The reference to the action of activating the teleport mode for this controller.")]
	[Space]
	[Header("Controller Actions")]
	[SerializeField]
	private InputActionReference m_TeleportModeActivate;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Tooltip("The reference to the action of canceling the teleport mode for this controller.")]
	private InputActionReference m_TeleportModeCancel;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Tooltip("The reference to the action of turning the XR rig with this controller.")]
	private InputActionReference m_Turn;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Tooltip("The reference to the action of moving the XR rig with this controller.")]
	private InputActionReference m_Move;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	[FormerlySerializedAs("m_TranslateObject")]
	[Tooltip("The reference to the action of translating the selected object of this controller.")]
	private InputActionReference m_TranslateAnchor;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Tooltip("The reference to the action of rotating the selected object of this controller.")]
	[FormerlySerializedAs("m_RotateObject")]
	[SerializeField]
	private InputActionReference m_RotateAnchor;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Tooltip("The default Select state and events for the controller.")]
	[Space]
	[Header("Default States")]
	[SerializeField]
	private ControllerState m_SelectState;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Tooltip("The default Teleport state and events for the controller.")]
	private ControllerState m_TeleportState;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Tooltip("The default Interact state and events for the controller.")]
	[SerializeField]
	private ControllerState m_InteractState;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly List<ControllerState> m_DefaultStates;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private XRBaseController m_BaseController;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private IXRSelectInteractor m_BaseInteractor;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private XRInteractorLineVisual m_BaseLineVisual;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private XRBaseController m_TeleportController;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private IXRInteractor m_TeleportInteractor;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private XRInteractorLineVisual m_TeleportLineVisual;

	[Token(Token = "0x17000002")]
	public GameObject baseControllerGameObject
	{
		[Token(Token = "0x600000C")]
		[Address(RVA = "0xE0F164", Offset = "0xE0F164", VA = "0xE0F164")]
		get
		{
			return null;
		}
		[Token(Token = "0x600000D")]
		[Address(RVA = "0xE0F16C", Offset = "0xE0F16C", VA = "0xE0F16C")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public GameObject teleportControllerGameObject
	{
		[Token(Token = "0x600000E")]
		[Address(RVA = "0xE0F174", Offset = "0xE0F174", VA = "0xE0F174")]
		get
		{
			return null;
		}
		[Token(Token = "0x600000F")]
		[Address(RVA = "0xE0F17C", Offset = "0xE0F17C", VA = "0xE0F17C")]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public InputActionReference teleportModeActivate
	{
		[Token(Token = "0x6000010")]
		[Address(RVA = "0xE0F184", Offset = "0xE0F184", VA = "0xE0F184")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000011")]
		[Address(RVA = "0xE0F18C", Offset = "0xE0F18C", VA = "0xE0F18C")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public InputActionReference teleportModeCancel
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0xE0F194", Offset = "0xE0F194", VA = "0xE0F194")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000013")]
		[Address(RVA = "0xE0F19C", Offset = "0xE0F19C", VA = "0xE0F19C")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public InputActionReference turn
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0xE0F1A4", Offset = "0xE0F1A4", VA = "0xE0F1A4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000015")]
		[Address(RVA = "0xE0F1AC", Offset = "0xE0F1AC", VA = "0xE0F1AC")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public InputActionReference move
	{
		[Token(Token = "0x6000016")]
		[Address(RVA = "0xE0F1B4", Offset = "0xE0F1B4", VA = "0xE0F1B4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000017")]
		[Address(RVA = "0xE0F1BC", Offset = "0xE0F1BC", VA = "0xE0F1BC")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public InputActionReference translateAnchor
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0xE0F1C4", Offset = "0xE0F1C4", VA = "0xE0F1C4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000019")]
		[Address(RVA = "0xE0F1CC", Offset = "0xE0F1CC", VA = "0xE0F1CC")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public InputActionReference rotateAnchor
	{
		[Token(Token = "0x600001A")]
		[Address(RVA = "0xE0F1D4", Offset = "0xE0F1D4", VA = "0xE0F1D4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600001B")]
		[Address(RVA = "0xE0F1DC", Offset = "0xE0F1DC", VA = "0xE0F1DC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public ControllerState selectState
	{
		[Token(Token = "0x600001C")]
		[Address(RVA = "0xE0F1E4", Offset = "0xE0F1E4", VA = "0xE0F1E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000B")]
	public ControllerState teleportState
	{
		[Token(Token = "0x600001D")]
		[Address(RVA = "0xE0F1EC", Offset = "0xE0F1EC", VA = "0xE0F1EC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000C")]
	public ControllerState interactState
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0xE0F1F4", Offset = "0xE0F1F4", VA = "0xE0F1F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xE0F1FC", Offset = "0xE0F1FC", VA = "0xE0F1FC")]
	protected void OnEnable()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xE0FB5C", Offset = "0xE0FB5C", VA = "0xE0FB5C")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xE0FEC8", Offset = "0xE0FEC8", VA = "0xE0FEC8")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xE100C8", Offset = "0xE100C8", VA = "0xE100C8")]
	protected void Update()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xE10028", Offset = "0xE10028", VA = "0xE10028")]
	private void TransitionState(ControllerState fromState, ControllerState toState)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xE0F578", Offset = "0xE0F578", VA = "0xE0F578")]
	private void FindBaseControllerComponents()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xE0F8E4", Offset = "0xE0F8E4", VA = "0xE0F8E4")]
	private void FindTeleportControllerComponents()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xE10224", Offset = "0xE10224", VA = "0xE10224")]
	private void SetBaseController(bool enable)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xE103C0", Offset = "0xE103C0", VA = "0xE103C0")]
	private void SetTeleportController(bool enable)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xE1051C", Offset = "0xE1051C", VA = "0xE1051C")]
	private void OnEnterSelectState(StateId previousStateId)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xE105B8", Offset = "0xE105B8", VA = "0xE105B8")]
	private void OnExitSelectState(StateId nextStateId)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xE10640", Offset = "0xE10640", VA = "0xE10640")]
	private void OnEnterTeleportState(StateId previousStateId)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xE10648", Offset = "0xE10648", VA = "0xE10648")]
	private void OnExitTeleportState(StateId nextStateId)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xE10650", Offset = "0xE10650", VA = "0xE10650")]
	private void OnEnterInteractState(StateId previousStateId)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xE1066C", Offset = "0xE1066C", VA = "0xE1066C")]
	private void OnExitInteractState(StateId nextStateId)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xE10688", Offset = "0xE10688", VA = "0xE10688")]
	private void OnUpdateSelectState()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xE10834", Offset = "0xE10834", VA = "0xE10834")]
	private void OnUpdateTeleportState()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xE108B4", Offset = "0xE108B4", VA = "0xE108B4")]
	private void OnUpdateInteractState()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xE10584", Offset = "0xE10584", VA = "0xE10584")]
	private static void EnableAction(InputActionReference actionReference)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xE1060C", Offset = "0xE1060C", VA = "0xE1060C")]
	private static void DisableAction(InputActionReference actionReference)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xE107B0", Offset = "0xE107B0", VA = "0xE107B0")]
	private static InputAction GetInputAction(InputActionReference actionReference)
	{
		return null;
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xE10974", Offset = "0xE10974", VA = "0xE10974")]
	public ActionBasedControllerManager()
	{
	}
}
[Token(Token = "0x200000A")]
[RequireComponent(typeof(XRGrabInteractable))]
public class BubbleGun : MonoBehaviour
{
	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private XRGrabInteractable m_InteractableBase;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Animator m_Animator;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ParticleSystem m_BubbleParticleSystem;

	[Token(Token = "0x400002C")]
	private const string k_AnimTriggerDown = "TriggerDown";

	[Token(Token = "0x400002D")]
	private const string k_AnimTriggerUp = "TriggerUp";

	[Token(Token = "0x400002E")]
	private const float k_HeldThreshold = 0.1f;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float m_TriggerHeldTime;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool m_TriggerDown;

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xE10C18", Offset = "0xE10C18", VA = "0xE10C18")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xE10E08", Offset = "0xE10E08", VA = "0xE10E08")]
	protected void Update()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xE10E7C", Offset = "0xE10E7C", VA = "0xE10E7C")]
	private void TriggerReleased(DeactivateEventArgs args)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xE10EE8", Offset = "0xE10EE8", VA = "0xE10EE8")]
	private void TriggerPulled(ActivateEventArgs args)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xE10F48", Offset = "0xE10F48", VA = "0xE10F48")]
	private void DroppedGun(SelectExitEventArgs args)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xE10FB4", Offset = "0xE10FB4", VA = "0xE10FB4")]
	public void ShootEvent()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xE10FD4", Offset = "0xE10FD4", VA = "0xE10FD4")]
	public BubbleGun()
	{
	}
}
[Token(Token = "0x200000B")]
[RequireComponent(typeof(XRGrabInteractable), typeof(Renderer))]
public class ComplexCube : MonoBehaviour
{
	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private XRBaseInteractable m_Interactable;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Renderer m_Renderer;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Color s_HoveredColor;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Color s_SelectedColor;

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xE10FDC", Offset = "0xE10FDC", VA = "0xE10FDC")]
	protected void OnEnable()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xE11328", Offset = "0xE11328", VA = "0xE11328")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xE11504", Offset = "0xE11504", VA = "0xE11504", Slot = "4")]
	protected virtual void OnFirstHoverEntered(HoverEnterEventArgs args)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xE11508", Offset = "0xE11508", VA = "0xE11508", Slot = "5")]
	protected virtual void OnLastHoverExited(HoverExitEventArgs args)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xE1150C", Offset = "0xE1150C", VA = "0xE1150C", Slot = "6")]
	protected virtual void OnFirstSelectEntered(SelectEnterEventArgs args)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xE11510", Offset = "0xE11510", VA = "0xE11510", Slot = "7")]
	protected virtual void OnLastSelectExited(SelectExitEventArgs args)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xE11210", Offset = "0xE11210", VA = "0xE11210")]
	protected void UpdateColor()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xE11514", Offset = "0xE11514", VA = "0xE11514")]
	public ComplexCube()
	{
	}
}
[Token(Token = "0x200000C")]
[DefaultExecutionOrder(10)]
public class ControllerManager : MonoBehaviour
{
	[Token(Token = "0x200000D")]
	private struct InteractorController
	{
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GameObject m_GO;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public XRController m_XRController;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public XRInteractorLineVisual m_LineRenderer;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public XRBaseInteractor m_Interactor;

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xE1206C", Offset = "0xE1206C", VA = "0xE1206C")]
		public void Attach(GameObject gameObject)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xE12264", Offset = "0xE12264", VA = "0xE12264")]
		public void Enter()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xE12178", Offset = "0xE12178", VA = "0xE12178")]
		public void Leave()
		{
		}
	}

	[Token(Token = "0x200000E")]
	public enum ControllerStates
	{
		[Token(Token = "0x4000047")]
		Select,
		[Token(Token = "0x4000048")]
		Teleport,
		[Token(Token = "0x4000049")]
		MAX
	}

	[Token(Token = "0x200000F")]
	private struct ControllerState
	{
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ControllerStates m_State;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private InteractorController[] m_Interactors;

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xE11828", Offset = "0xE11828", VA = "0xE11828")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xE118C4", Offset = "0xE118C4", VA = "0xE118C4")]
		public void ClearAll()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xE11880", Offset = "0xE11880", VA = "0xE11880")]
		public void SetGameObject(ControllerStates state, GameObject parentGamObject)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xE11A24", Offset = "0xE11A24", VA = "0xE11A24")]
		public void SetState(ControllerStates nextState)
		{
		}
	}

	[Token(Token = "0x4000035")]
	public const int kControllerManagerUpdateOrder = 10;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("The buttons on the controller that will trigger a transition to the Teleport Controller.")]
	[SerializeField]
	private List<InputHelpers.Button> m_ActivationButtons;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Tooltip("The buttons on the controller that will force a deactivation of the teleport option.")]
	private List<InputHelpers.Button> m_DeactivationButtons;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("The Game Object which represents the left hand for normal interaction purposes.")]
	[SerializeField]
	private GameObject m_LeftBaseController;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Tooltip("The Game Object which represents the left hand when teleporting.")]
	private GameObject m_LeftTeleportController;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("The Game Object which represents the right hand for normal interaction purposes.")]
	[SerializeField]
	private GameObject m_RightBaseController;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Tooltip("The Game Object which represents the right hand when teleporting.")]
	private GameObject m_RightTeleportController;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private UnityEngine.XR.InputDevice m_RightController;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private UnityEngine.XR.InputDevice m_LeftController;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool m_LeftTeleportDeactivated;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	private bool m_RightTeleportDeactivated;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ControllerState m_RightControllerState;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private ControllerState m_LeftControllerState;

	[Token(Token = "0x17000012")]
	public List<InputHelpers.Button> activationButtons
	{
		[Token(Token = "0x6000053")]
		[Address(RVA = "0xE11580", Offset = "0xE11580", VA = "0xE11580")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000054")]
		[Address(RVA = "0xE11588", Offset = "0xE11588", VA = "0xE11588")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public List<InputHelpers.Button> deactivationButtons
	{
		[Token(Token = "0x6000055")]
		[Address(RVA = "0xE11590", Offset = "0xE11590", VA = "0xE11590")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000056")]
		[Address(RVA = "0xE11598", Offset = "0xE11598", VA = "0xE11598")]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public GameObject leftBaseController
	{
		[Token(Token = "0x6000057")]
		[Address(RVA = "0xE115A0", Offset = "0xE115A0", VA = "0xE115A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000058")]
		[Address(RVA = "0xE115A8", Offset = "0xE115A8", VA = "0xE115A8")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public GameObject leftTeleportController
	{
		[Token(Token = "0x6000059")]
		[Address(RVA = "0xE115B0", Offset = "0xE115B0", VA = "0xE115B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600005A")]
		[Address(RVA = "0xE115B8", Offset = "0xE115B8", VA = "0xE115B8")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public GameObject rightBaseController
	{
		[Token(Token = "0x600005B")]
		[Address(RVA = "0xE115C0", Offset = "0xE115C0", VA = "0xE115C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600005C")]
		[Address(RVA = "0xE115C8", Offset = "0xE115C8", VA = "0xE115C8")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public GameObject rightTeleportController
	{
		[Token(Token = "0x600005D")]
		[Address(RVA = "0xE115D0", Offset = "0xE115D0", VA = "0xE115D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600005E")]
		[Address(RVA = "0xE115D8", Offset = "0xE115D8", VA = "0xE115D8")]
		set
		{
		}
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xE115E0", Offset = "0xE115E0", VA = "0xE115E0")]
	protected void OnEnable()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xE119A4", Offset = "0xE119A4", VA = "0xE119A4")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xE11928", Offset = "0xE11928", VA = "0xE11928")]
	private void RegisterDevices(UnityEngine.XR.InputDevice connectedDevice)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xE11AB8", Offset = "0xE11AB8", VA = "0xE11AB8")]
	protected void Update()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xE11FCC", Offset = "0xE11FCC", VA = "0xE11FCC")]
	public ControllerManager()
	{
	}
}
[Token(Token = "0x2000010")]
public class CSeat : TeleportationAnchor
{
	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private bool m_bSetLocked;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public GameObject m_gSeatPoint;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public string m_nSeatId;

	[Token(Token = "0x17000018")]
	public bool SetLocked
	{
		[Token(Token = "0x600006C")]
		[Address(RVA = "0xE12360", Offset = "0xE12360", VA = "0xE12360")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600006B")]
		[Address(RVA = "0xE12354", Offset = "0xE12354", VA = "0xE12354")]
		set
		{
		}
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xE12368", Offset = "0xE12368", VA = "0xE12368", Slot = "88")]
	protected override bool GenerateTeleportRequest(IXRInteractor interactor, RaycastHit raycastHit, ref TeleportRequest teleportRequest)
	{
		return default(bool);
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xE1242C", Offset = "0xE1242C", VA = "0xE1242C")]
	public CSeat()
	{
	}
}
[Token(Token = "0x2000011")]
public class UpdateControlText : MonoBehaviour
{
	[Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class <StartTextMeshFade>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMesh textMesh;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <duration>5__2;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <t>5__3;

		[Token(Token = "0x17000019")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0xE12890", Offset = "0xE12890", VA = "0xE12890", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0xE128D8", Offset = "0xE128D8", VA = "0xE128D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xE1264C", Offset = "0xE1264C", VA = "0xE1264C")]
		[DebuggerHidden]
		public <StartTextMeshFade>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xE12760", Offset = "0xE12760", VA = "0xE12760", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xE12764", Offset = "0xE12764", VA = "0xE12764", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xE12898", Offset = "0xE12898", VA = "0xE12898", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMesh m_TextMesh;

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xE12434", Offset = "0xE12434", VA = "0xE12434")]
	public void OnSliderEvent(float value)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xE1250C", Offset = "0xE1250C", VA = "0xE1250C")]
	public void OnKnobEvent(float value)
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xE125E4", Offset = "0xE125E4", VA = "0xE125E4")]
	[IteratorStateMachine(typeof(<StartTextMeshFade>d__3))]
	private IEnumerator StartTextMeshFade(TextMesh textMesh)
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xE12674", Offset = "0xE12674", VA = "0xE12674")]
	public void OnButtonEvent()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xE126F8", Offset = "0xE126F8", VA = "0xE126F8")]
	public UpdateControlText()
	{
	}
}
[Token(Token = "0x2000013")]
public class XROffsetGrabbable : XRGrabInteractable
{
	[Token(Token = "0x2000014")]
	private class SavedTransform
	{
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 OriginalPosition;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion OriginalRotation;

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xE12CF0", Offset = "0xE12CF0", VA = "0xE12CF0")]
		public SavedTransform()
		{
		}
	}

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	private Dictionary<IXRSelectInteractor, SavedTransform> m_SavedTransforms;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	private Rigidbody m_Rb;

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xE128E0", Offset = "0xE128E0", VA = "0xE128E0", Slot = "47")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xE1293C", Offset = "0xE1293C", VA = "0xE1293C", Slot = "65")]
	protected override void OnSelectEntering(SelectEnterEventArgs args)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xE12CF8", Offset = "0xE12CF8", VA = "0xE12CF8", Slot = "67")]
	protected override void OnSelectExiting(SelectExitEventArgs args)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xE12EF0", Offset = "0xE12EF0", VA = "0xE12EF0")]
	public XROffsetGrabbable()
	{
	}
}
namespace UnityEngine.XR.Interaction.Toolkit.Examples
{
	[Token(Token = "0x2000015")]
	public class LocomotionConfigurationMenu : MonoBehaviour
	{
		[Token(Token = "0x2000016")]
		private class EnumDropdownCache<T> where T : Enum
		{
			[Token(Token = "0x400006B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly List<T> m_Values;

			[Token(Token = "0x17000028")]
			public List<Dropdown.OptionData> options
			{
				[Token(Token = "0x60000C4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000C5")]
			public EnumDropdownCache()
			{
			}

			[Token(Token = "0x60000C6")]
			public T GetValue(int index)
			{
				return (T)null;
			}

			[Token(Token = "0x60000C7")]
			public int FindIndex(T value)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("Stores the Toggle used to enable or disable continuous movement locomotion.")]
		private Toggle m_ContinuousMoveToggle;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Stores the Slider used to set the move speed of continuous movement.")]
		private Slider m_MoveSpeedSlider;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Stores the Text used to display the current move speed of continuous movement.")]
		private Text m_MoveSpeedValueText;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Tooltip("Stores the Toggle used to enable or disable strafing (sideways movement) of continuous movement.")]
		private Toggle m_EnableStrafeToggle;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Stores the Toggle used to enable or disable gravity on continuous movement.")]
		[SerializeField]
		private Toggle m_UseGravityToggle;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Stores the Dropdown used to select when gravity is applied with continuous movement.")]
		[SerializeField]
		private Dropdown m_GravityApplicationModeDropdown;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Tooltip("Stores the Dropdown used to select the source Transform to define the forward direction of continuous movement.")]
		private Dropdown m_ForwardSourceDropdown;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Stores the Toggle used to enable or disable continuous turn locomotion.")]
		[SerializeField]
		private Toggle m_ContinuousTurnToggle;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Stores the Slider used to set the turn speed of continuous turning.")]
		[SerializeField]
		private Slider m_TurnSpeedSlider;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Tooltip("Stores the Text used to display the current turn speed of continuous turning.")]
		private Text m_TurnSpeedValueText;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Tooltip("Stores the Dropdown used to select the number of degrees to rotate for snap turning.")]
		private Dropdown m_SnapTurnAmountDropdown;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Tooltip("Stores the Toggle used to enable or disable 180° snap turns.")]
		private Toggle m_EnableTurnAroundToggle;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Tooltip("Stores the behavior that will be used to configure locomotion control schemes and configuration preferences.")]
		private LocomotionSchemeManager m_Manager;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<float> k_SnapTurnAmounts;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly List<Dropdown.OptionData> k_SnapTurnAmountOptions;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static EnumDropdownCache<ContinuousMoveProviderBase.GravityApplicationMode> s_GravityApplicationModeDropdownCache;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static EnumDropdownCache<LocomotionSchemeManager.MoveForwardSource> s_ForwardSourceDropdownCache;

		[Token(Token = "0x1700001B")]
		public Toggle continuousMoveToggle
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0xE12F90", Offset = "0xE12F90", VA = "0xE12F90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000080")]
			[Address(RVA = "0xE12F98", Offset = "0xE12F98", VA = "0xE12F98")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public Slider moveSpeedSlider
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0xE131E8", Offset = "0xE131E8", VA = "0xE131E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000082")]
			[Address(RVA = "0xE131F0", Offset = "0xE131F0", VA = "0xE131F0")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public Text moveSpeedValueText
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0xE135F8", Offset = "0xE135F8", VA = "0xE135F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000084")]
			[Address(RVA = "0xE13600", Offset = "0xE13600", VA = "0xE13600")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public Toggle enableStrafeToggle
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0xE13638", Offset = "0xE13638", VA = "0xE13638")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000086")]
			[Address(RVA = "0xE13640", Offset = "0xE13640", VA = "0xE13640")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public Toggle useGravityToggle
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0xE13898", Offset = "0xE13898", VA = "0xE13898")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000088")]
			[Address(RVA = "0xE138A0", Offset = "0xE138A0", VA = "0xE138A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public Dropdown gravityApplicationModeDropdown
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0xE13AF8", Offset = "0xE13AF8", VA = "0xE13AF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008A")]
			[Address(RVA = "0xE13B00", Offset = "0xE13B00", VA = "0xE13B00")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public Dropdown forwardSourceDropdown
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0xE13DD8", Offset = "0xE13DD8", VA = "0xE13DD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008C")]
			[Address(RVA = "0xE13DE0", Offset = "0xE13DE0", VA = "0xE13DE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public Toggle continuousTurnToggle
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0xE140B0", Offset = "0xE140B0", VA = "0xE140B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008E")]
			[Address(RVA = "0xE140B8", Offset = "0xE140B8", VA = "0xE140B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public Slider turnSpeedSlider
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0xE14308", Offset = "0xE14308", VA = "0xE14308")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000090")]
			[Address(RVA = "0xE14310", Offset = "0xE14310", VA = "0xE14310")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public Text turnSpeedValueText
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0xE146EC", Offset = "0xE146EC", VA = "0xE146EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000092")]
			[Address(RVA = "0xE146F4", Offset = "0xE146F4", VA = "0xE146F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public Dropdown snapTurnAmountDropdown
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0xE1472C", Offset = "0xE1472C", VA = "0xE1472C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000094")]
			[Address(RVA = "0xE14734", Offset = "0xE14734", VA = "0xE14734")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public Toggle enableTurnAroundToggle
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0xE14BCC", Offset = "0xE14BCC", VA = "0xE14BCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000096")]
			[Address(RVA = "0xE14BD4", Offset = "0xE14BD4", VA = "0xE14BD4")]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public LocomotionSchemeManager manager
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0xE14E24", Offset = "0xE14E24", VA = "0xE14E24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000098")]
			[Address(RVA = "0xE14E2C", Offset = "0xE14E2C", VA = "0xE14E2C")]
			set
			{
			}
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xE14FF0", Offset = "0xE14FF0", VA = "0xE14FF0")]
		protected void Awake()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xE153E8", Offset = "0xE153E8", VA = "0xE153E8")]
		protected void OnEnable()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xE15618", Offset = "0xE15618", VA = "0xE15618")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xE14F44", Offset = "0xE14F44", VA = "0xE14F44")]
		private void SubscribeAll()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xE14EC4", Offset = "0xE14EC4", VA = "0xE14EC4")]
		private void UnsubscribeAll()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xE14FC4", Offset = "0xE14FC4", VA = "0xE14FC4")]
		private void RefreshInteractable()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xE135BC", Offset = "0xE135BC", VA = "0xE135BC")]
		private void RefreshMoveDependentInteractable()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xE1561C", Offset = "0xE1561C", VA = "0xE1561C")]
		private void RefreshMoveDependentInteractable(bool continuous)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xE146B0", Offset = "0xE146B0", VA = "0xE146B0")]
		private void RefreshTurnDependentInteractable()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xE157A4", Offset = "0xE157A4", VA = "0xE157A4")]
		private void RefreshTurnDependentInteractable(bool continuous)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xE15414", Offset = "0xE15414", VA = "0xE15414")]
		private bool ValidateManager()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xE130C4", Offset = "0xE130C4", VA = "0xE130C4")]
		private void SubscribeContinuousMove(Toggle toggle)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xE13328", Offset = "0xE13328", VA = "0xE13328")]
		private void SubscribeMoveSpeed(Slider slider, Text valueText)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xE13774", Offset = "0xE13774", VA = "0xE13774")]
		private void SubscribeEnableStrafe(Toggle toggle)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xE139D4", Offset = "0xE139D4", VA = "0xE139D4")]
		private void SubscribeUseGravity(Toggle toggle)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xE13C34", Offset = "0xE13C34", VA = "0xE13C34")]
		private void SubscribeGravityApplicationMode(Dropdown dropdown)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xE13F14", Offset = "0xE13F14", VA = "0xE13F14")]
		private void SubscribeForwardSource(Dropdown dropdown)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xE141E4", Offset = "0xE141E4", VA = "0xE141E4")]
		private void SubscribeContinuousTurn(Toggle toggle)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xE14448", Offset = "0xE14448", VA = "0xE14448")]
		private void SubscribeTurnSpeed(Slider slider, Text valueText)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xE14868", Offset = "0xE14868", VA = "0xE14868")]
		private void SubscribeSnapTurnAmount(Dropdown dropdown)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xE14D00", Offset = "0xE14D00", VA = "0xE14D00")]
		private void SubscribeEnableTurnAround(Toggle toggle)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xE12FCC", Offset = "0xE12FCC", VA = "0xE12FCC")]
		private void UnsubscribeContinuousMove(Toggle toggle)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xE13230", Offset = "0xE13230", VA = "0xE13230")]
		private void UnsubscribeMoveSpeed(Slider slider)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xE1367C", Offset = "0xE1367C", VA = "0xE1367C")]
		private void UnsubscribeEnableStrafe(Toggle toggle)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xE138DC", Offset = "0xE138DC", VA = "0xE138DC")]
		private void UnsubscribeUseGravity(Toggle toggle)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xE13B3C", Offset = "0xE13B3C", VA = "0xE13B3C")]
		private void UnsubscribeGravityApplicationMode(Dropdown dropdown)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xE13E1C", Offset = "0xE13E1C", VA = "0xE13E1C")]
		private void UnsubscribeForwardSource(Dropdown dropdown)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xE140EC", Offset = "0xE140EC", VA = "0xE140EC")]
		private void UnsubscribeContinuousTurn(Toggle toggle)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xE14350", Offset = "0xE14350", VA = "0xE14350")]
		private void UnsubscribeTurnSpeed(Slider slider)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xE14770", Offset = "0xE14770", VA = "0xE14770")]
		private void UnsubscribeSnapTurnAmount(Dropdown dropdown)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xE14C08", Offset = "0xE14C08", VA = "0xE14C08")]
		private void UnsubscribeEnableTurnAround(Toggle toggle)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xE1587C", Offset = "0xE1587C", VA = "0xE1587C")]
		private void OnContinuousMoveToggleValueChanged(bool value)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xE158E0", Offset = "0xE158E0", VA = "0xE158E0")]
		private void OnMoveSpeedSliderValueChanged(float value)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xE159A4", Offset = "0xE159A4", VA = "0xE159A4")]
		private void OnEnableStrafeToggleValueChanged(bool value)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xE159CC", Offset = "0xE159CC", VA = "0xE159CC")]
		private void OnUseGravityToggleValueChanged(bool value)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xE159F4", Offset = "0xE159F4", VA = "0xE159F4")]
		private void OnGravityApplicationModeDropdownValueChanged(int index)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xE15A90", Offset = "0xE15A90", VA = "0xE15A90")]
		private void OnForwardSourceDropdownValueChanged(int index)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xE15B60", Offset = "0xE15B60", VA = "0xE15B60")]
		private void OnContinuousTurnToggleValueChanged(bool value)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xE15BC4", Offset = "0xE15BC4", VA = "0xE15BC4")]
		private void OnTurnSpeedSliderValueChanged(float value)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xE15C20", Offset = "0xE15C20", VA = "0xE15C20")]
		private void OnSnapTurnAmountDropdownValueChanged(int index)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xE15CC4", Offset = "0xE15CC4", VA = "0xE15CC4")]
		private void OnEnableTurnAroundToggleValueChanged(bool value)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xE15CEC", Offset = "0xE15CEC", VA = "0xE15CEC")]
		public LocomotionConfigurationMenu()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class LocomotionSchemeManager : MonoBehaviour
	{
		[Token(Token = "0x2000018")]
		public enum MoveScheme
		{
			[Token(Token = "0x400007C")]
			Noncontinuous,
			[Token(Token = "0x400007D")]
			Continuous
		}

		[Token(Token = "0x2000019")]
		public enum TurnStyle
		{
			[Token(Token = "0x400007F")]
			Snap,
			[Token(Token = "0x4000080")]
			Continuous
		}

		[Token(Token = "0x200001A")]
		public enum MoveForwardSource
		{
			[Token(Token = "0x4000082")]
			Head,
			[Token(Token = "0x4000083")]
			LeftHand,
			[Token(Token = "0x4000084")]
			RightHand
		}

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Controls which movement control scheme to use.")]
		[SerializeField]
		private MoveScheme m_MoveScheme;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Tooltip("Controls which turn style of locomotion to use.")]
		private TurnStyle m_TurnStyle;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Controls which orientation the forward direction of continuous movement is relative to.")]
		[SerializeField]
		private MoveForwardSource m_MoveForwardSource;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Input action assets associated with locomotion to affect when the active movement control scheme is set. Can use this list by itself or together with the Action Maps list to set control scheme masks by Asset or Map.")]
		private List<InputActionAsset> m_ActionAssets;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Input action maps associated with locomotion to affect when the active movement control scheme is set. Can use this list together with the Action Assets list to set control scheme masks by Map instead of the whole Asset.")]
		[SerializeField]
		private List<string> m_ActionMaps;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Input actions associated with locomotion to affect when the active movement control scheme is set. Can use this list to select exactly the actions to affect instead of setting control scheme masks by Asset or Map.")]
		[SerializeField]
		private List<InputActionReference> m_Actions;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("Name of an input control scheme that defines the grouping of bindings that should remain enabled when applying any movement control scheme. Control schemes are created and named in the Input Actions window. The other movement control schemes are applied additively to this scheme. Can be an empty string, which means only bindings that match the specified movement control scheme will be enabled.")]
		private string m_BaseControlScheme;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Name of an input control scheme that defines the grouping of bindings that should remain enabled when applying the noncontinuous movement control scheme. Control schemes are created and named in the Input Actions window. Can be an empty string, which means only bindings that match the base control scheme will be enabled.")]
		[SerializeField]
		private string m_NoncontinuousControlScheme;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Tooltip("Name of an input control scheme that defines the grouping of bindings that should remain enabled when applying the continuous movement control scheme. Control schemes are created and named in the Input Actions window. Can be an empty string, which means only bindings that match the base control scheme will be enabled.")]
		private string m_ContinuousControlScheme;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Tooltip("Stores the locomotion provider for continuous movement.")]
		private ContinuousMoveProviderBase m_ContinuousMoveProvider;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Tooltip("Stores the locomotion provider for continuous turning.")]
		private ContinuousTurnProviderBase m_ContinuousTurnProvider;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Tooltip("Stores the locomotion provider for snap turning.")]
		private SnapTurnProviderBase m_SnapTurnProvider;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Tooltip("Stores the \"Head\" Transform used with continuous movement when inputs should be relative to head orientation (usually the main camera).")]
		private Transform m_HeadForwardSource;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("Stores the \"Left Hand\" Transform used with continuous movement when inputs should be relative to the left hand's orientation.")]
		[SerializeField]
		private Transform m_LeftHandForwardSource;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Tooltip("Stores the \"Right Hand\" Transform used with continuous movement when inputs should be relative to the right hand's orientation.")]
		private Transform m_RightHandForwardSource;

		[Token(Token = "0x17000029")]
		public MoveScheme moveScheme
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0xE16050", Offset = "0xE16050", VA = "0xE16050")]
			get
			{
				return default(MoveScheme);
			}
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0xE158BC", Offset = "0xE158BC", VA = "0xE158BC")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public TurnStyle turnStyle
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0xE161C4", Offset = "0xE161C4", VA = "0xE161C4")]
			get
			{
				return default(TurnStyle);
			}
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0xE15BA0", Offset = "0xE15BA0", VA = "0xE15BA0")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public MoveForwardSource moveForwardSource
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0xE163BC", Offset = "0xE163BC", VA = "0xE163BC")]
			get
			{
				return default(MoveForwardSource);
			}
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0xE15B3C", Offset = "0xE15B3C", VA = "0xE15B3C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public List<InputActionAsset> actionAssets
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0xE165B8", Offset = "0xE165B8", VA = "0xE165B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0xE165C0", Offset = "0xE165C0", VA = "0xE165C0")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public List<string> actionMaps
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0xE165C8", Offset = "0xE165C8", VA = "0xE165C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0xE165D0", Offset = "0xE165D0", VA = "0xE165D0")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public List<InputActionReference> actions
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0xE165D8", Offset = "0xE165D8", VA = "0xE165D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0xE165E0", Offset = "0xE165E0", VA = "0xE165E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public string baseControlScheme
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0xE165E8", Offset = "0xE165E8", VA = "0xE165E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0xE165F0", Offset = "0xE165F0", VA = "0xE165F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public string noncontinuousControlScheme
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0xE165F8", Offset = "0xE165F8", VA = "0xE165F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0xE16600", Offset = "0xE16600", VA = "0xE16600")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public string continuousControlScheme
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0xE16608", Offset = "0xE16608", VA = "0xE16608")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0xE16610", Offset = "0xE16610", VA = "0xE16610")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public ContinuousMoveProviderBase continuousMoveProvider
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0xE16618", Offset = "0xE16618", VA = "0xE16618")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0xE16620", Offset = "0xE16620", VA = "0xE16620")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public ContinuousTurnProviderBase continuousTurnProvider
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0xE16628", Offset = "0xE16628", VA = "0xE16628")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0xE16630", Offset = "0xE16630", VA = "0xE16630")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public SnapTurnProviderBase snapTurnProvider
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0xE16638", Offset = "0xE16638", VA = "0xE16638")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0xE16640", Offset = "0xE16640", VA = "0xE16640")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public Transform headForwardSource
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0xE16648", Offset = "0xE16648", VA = "0xE16648")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0xE16650", Offset = "0xE16650", VA = "0xE16650")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public Transform leftHandForwardSource
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0xE16658", Offset = "0xE16658", VA = "0xE16658")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0xE16660", Offset = "0xE16660", VA = "0xE16660")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public Transform rightHandForwardSource
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0xE16668", Offset = "0xE16668", VA = "0xE16668")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0xE16670", Offset = "0xE16670", VA = "0xE16670")]
			set
			{
			}
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xE16678", Offset = "0xE16678", VA = "0xE16678")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xE166A4", Offset = "0xE166A4", VA = "0xE166A4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xE16058", Offset = "0xE16058", VA = "0xE16058")]
		private void SetMoveScheme(MoveScheme scheme)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xE161CC", Offset = "0xE161CC", VA = "0xE161CC")]
		private void SetTurnStyle(TurnStyle style)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xE163C4", Offset = "0xE163C4", VA = "0xE163C4")]
		private void SetMoveForwardSource(MoveForwardSource forwardSource)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xE166F8", Offset = "0xE166F8", VA = "0xE166F8")]
		private void SetBindingMasks(string controlSchemeName)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xE166A8", Offset = "0xE166A8", VA = "0xE166A8")]
		private void ClearBindingMasks()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xE16E18", Offset = "0xE16E18", VA = "0xE16E18")]
		private InputControlScheme? FindControlScheme(string controlSchemeName, InputActionReference action)
		{
			return null;
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xE17210", Offset = "0xE17210", VA = "0xE17210")]
		private InputControlScheme? FindControlScheme(string controlSchemeName, InputActionAsset asset)
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xE16FD0", Offset = "0xE16FD0", VA = "0xE16FD0")]
		private static InputBinding? GetBindingMask(InputControlScheme? baseInputControlScheme, InputControlScheme? inputControlScheme)
		{
			return null;
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xE173E4", Offset = "0xE173E4", VA = "0xE173E4")]
		public LocomotionSchemeManager()
		{
		}
	}
}
namespace UnityEngine.XR.OpenXR.Samples.MeshingFeature
{
	[Token(Token = "0x200001B")]
	public class FallingSphere : MonoBehaviour
	{
		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 starting;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody rb;

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xE173EC", Offset = "0xE173EC", VA = "0xE173EC")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xE17460", Offset = "0xE17460", VA = "0xE17460")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xE17554", Offset = "0xE17554", VA = "0xE17554")]
		public FallingSphere()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class MeshingBehaviour : MonoBehaviour
	{
		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject emptyMeshPrefab;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMesh textMesh;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform target;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private XRMeshSubsystem s_MeshSubsystem;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<MeshInfo> s_MeshInfos;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<MeshId, GameObject> m_MeshIdToGo;

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xE1755C", Offset = "0xE1755C", VA = "0xE1755C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xE17738", Offset = "0xE17738", VA = "0xE17738")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xE17BC8", Offset = "0xE17BC8", VA = "0xE17BC8")]
		public MeshingBehaviour()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class MeshingTeapotFeature : OpenXRFeature
	{
		[Token(Token = "0x400008F")]
		public const string featureId = "com.unity.openxr.feature.example.meshing";

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<XRMeshSubsystemDescriptor> s_MeshDescriptors;

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xE17DC4", Offset = "0xE17DC4", VA = "0xE17DC4", Slot = "5")]
		protected override void OnSubsystemCreate()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xE17E5C", Offset = "0xE17E5C", VA = "0xE17E5C", Slot = "6")]
		protected override void OnSubsystemStart()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xE17EA4", Offset = "0xE17EA4", VA = "0xE17EA4", Slot = "7")]
		protected override void OnSubsystemStop()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xE17EEC", Offset = "0xE17EEC", VA = "0xE17EEC", Slot = "8")]
		protected override void OnSubsystemDestroy()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xE17F34", Offset = "0xE17F34", VA = "0xE17F34")]
		public MeshingTeapotFeature()
		{
		}
	}
}
namespace UnityEngine.XR.OpenXR.Samples.InterceptFeature
{
	[Token(Token = "0x200001F")]
	public class InterceptCreateSessionFeature : OpenXRFeature
	{
		[Token(Token = "0x2000020")]
		private delegate void OnMessageDelegate(string message);

		[Token(Token = "0x2000021")]
		internal delegate void ReceiveMessageDelegate(string message);

		[Token(Token = "0x4000091")]
		public const string featureId = "com.unity.openxr.feature.example.intercept";

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string message;

		[Token(Token = "0x4000094")]
		private const string ExtLib = "InterceptFeaturePlugin";

		[Token(Token = "0x17000038")]
		public string receivedMessage
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0xE1809C", Offset = "0xE1809C", VA = "0xE1809C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000101")]
			[Address(RVA = "0xE180A4", Offset = "0xE180A4", VA = "0xE180A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xE180AC", Offset = "0xE180AC", VA = "0xE180AC", Slot = "4")]
		protected override IntPtr HookGetInstanceProcAddr(IntPtr func)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xE1819C", Offset = "0xE1819C", VA = "0xE1819C", Slot = "9")]
		protected override bool OnInstanceCreate(ulong xrInstance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xE17FC8", Offset = "0xE17FC8", VA = "0xE17FC8")]
		[MonoPInvokeCallback(typeof(OnMessageDelegate))]
		private static void OnMessage(string message)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xE18494", Offset = "0xE18494", VA = "0xE18494", Slot = "11")]
		protected override void OnSessionCreate(ulong xrSession)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xE18554", Offset = "0xE18554", VA = "0xE18554", Slot = "14")]
		protected override void OnSessionBegin(ulong xrSession)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xE18614", Offset = "0xE18614", VA = "0xE18614", Slot = "15")]
		protected override void OnSessionEnd(ulong xrSession)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000108")]
		[Address(RVA = "0xE18120", Offset = "0xE18120", VA = "0xE18120")]
		private static extern IntPtr intercept_xrCreateSession_xrGetInstanceProcAddr(IntPtr func);

		[PreserveSig]
		[Token(Token = "0x6000109")]
		[Address(RVA = "0xE18410", Offset = "0xE18410", VA = "0xE18410")]
		private static extern void Internal_SetMessage(string printString);

		[PreserveSig]
		[Token(Token = "0x600010A")]
		[Address(RVA = "0xE18390", Offset = "0xE18390", VA = "0xE18390")]
		private static extern void Internal_SetCallback(ReceiveMessageDelegate callback);

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xE186D4", Offset = "0xE186D4", VA = "0xE186D4")]
		public InterceptCreateSessionFeature()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class InterceptMessageHandler : MonoBehaviour
	{
		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMesh textMesh;

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xE18878", Offset = "0xE18878", VA = "0xE18878")]
		private void Start()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xE18984", Offset = "0xE18984", VA = "0xE18984")]
		public InterceptMessageHandler()
		{
		}
	}
}
namespace Es.Utility
{
	[Token(Token = "0x2000023")]
	[RequireComponent(typeof(Camera))]
	public class SceneViewCamera : MonoBehaviour
	{
		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Range(0.1f, 100f)]
		private float wheelSpeed;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Range(0.1f, 100f)]
		private float moveSpeed;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Range(0.1f, 1f)]
		private float rotateSpeed;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 preMousePos;

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xE1898C", Offset = "0xE1898C", VA = "0xE1898C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xE18990", Offset = "0xE18990", VA = "0xE18990")]
		private void MouseUpdate()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xE18A38", Offset = "0xE18A38", VA = "0xE18A38")]
		private void MouseWheel(float delta)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xE18AD4", Offset = "0xE18AD4", VA = "0xE18AD4")]
		private void MouseDrag(Vector3 mousePos)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xE18C14", Offset = "0xE18C14", VA = "0xE18C14")]
		public void CameraRotate(Vector2 angle)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xE18D4C", Offset = "0xE18D4C", VA = "0xE18D4C")]
		public SceneViewCamera()
		{
		}
	}
}
namespace Es.InkPainter
{
	[Serializable]
	[Token(Token = "0x2000024")]
	public class Brush : ICloneable
	{
		[Token(Token = "0x2000025")]
		public enum ColorBlendType
		{
			[Token(Token = "0x40000AA")]
			UseColor,
			[Token(Token = "0x40000AB")]
			UseBrush,
			[Token(Token = "0x40000AC")]
			Neutral,
			[Token(Token = "0x40000AD")]
			AlphaOnly
		}

		[Token(Token = "0x2000026")]
		public enum NormalBlendType
		{
			[Token(Token = "0x40000AF")]
			UseBrush,
			[Token(Token = "0x40000B0")]
			Add,
			[Token(Token = "0x40000B1")]
			Sub,
			[Token(Token = "0x40000B2")]
			Min,
			[Token(Token = "0x40000B3")]
			Max
		}

		[Token(Token = "0x2000027")]
		public enum HeightBlendType
		{
			[Token(Token = "0x40000B5")]
			UseBrush,
			[Token(Token = "0x40000B6")]
			Add,
			[Token(Token = "0x40000B7")]
			Sub,
			[Token(Token = "0x40000B8")]
			Min,
			[Token(Token = "0x40000B9")]
			Max,
			[Token(Token = "0x40000BA")]
			ColorRGB_HeightA
		}

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Texture brushTexture;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Texture brushNormalTexture;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Texture brushHeightTexture;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Range(0f, 1f)]
		private float brushScale;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 360f)]
		[SerializeField]
		private float rotateAngle;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[SerializeField]
		private float brushNormalBlend;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		[SerializeField]
		private float brushHeightBlend;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Range(0f, 10f)]
		private float brushSpeed;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Range(0f, 10f)]
		private float vanishSpeed;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Range(0f, 100f)]
		private float brushStrength;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Vector4 brushChannel;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Color brushColor;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private ColorBlendType colorBlendType;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private NormalBlendType normalBlendType;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private HeightBlendType heightBlendType;

		[Token(Token = "0x17000039")]
		public Texture BrushTexture
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0xE18D6C", Offset = "0xE18D6C", VA = "0xE18D6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011D")]
			[Address(RVA = "0xE18D74", Offset = "0xE18D74", VA = "0xE18D74")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public Texture BrushNormalTexture
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0xE18D7C", Offset = "0xE18D7C", VA = "0xE18D7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011F")]
			[Address(RVA = "0xE18D84", Offset = "0xE18D84", VA = "0xE18D84")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public Texture BrushHeightTexture
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0xE18D8C", Offset = "0xE18D8C", VA = "0xE18D8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000121")]
			[Address(RVA = "0xE18D94", Offset = "0xE18D94", VA = "0xE18D94")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public float Scale
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0xE18D9C", Offset = "0xE18D9C", VA = "0xE18D9C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000123")]
			[Address(RVA = "0xE18DB8", Offset = "0xE18DB8", VA = "0xE18DB8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public float RotateAngle
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0xE18DD4", Offset = "0xE18DD4", VA = "0xE18DD4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000125")]
			[Address(RVA = "0xE18DDC", Offset = "0xE18DDC", VA = "0xE18DDC")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public float NormalBlend
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0xE18DE4", Offset = "0xE18DE4", VA = "0xE18DE4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000127")]
			[Address(RVA = "0xE18E00", Offset = "0xE18E00", VA = "0xE18E00")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public float HeightBlend
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0xE18E1C", Offset = "0xE18E1C", VA = "0xE18E1C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000129")]
			[Address(RVA = "0xE18E38", Offset = "0xE18E38", VA = "0xE18E38")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public Color Color
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0xE18E54", Offset = "0xE18E54", VA = "0xE18E54")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600012B")]
			[Address(RVA = "0xE18E60", Offset = "0xE18E60", VA = "0xE18E60")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public ColorBlendType ColorBlending
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0xE18E6C", Offset = "0xE18E6C", VA = "0xE18E6C")]
			get
			{
				return default(ColorBlendType);
			}
			[Token(Token = "0x600012D")]
			[Address(RVA = "0xE18E74", Offset = "0xE18E74", VA = "0xE18E74")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public NormalBlendType NormalBlending
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0xE18E7C", Offset = "0xE18E7C", VA = "0xE18E7C")]
			get
			{
				return default(NormalBlendType);
			}
			[Token(Token = "0x600012F")]
			[Address(RVA = "0xE18E84", Offset = "0xE18E84", VA = "0xE18E84")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public HeightBlendType HeightBlending
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0xE18E8C", Offset = "0xE18E8C", VA = "0xE18E8C")]
			get
			{
				return default(HeightBlendType);
			}
			[Token(Token = "0x6000131")]
			[Address(RVA = "0xE18E94", Offset = "0xE18E94", VA = "0xE18E94")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public Vector4 BrushChannel
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0xE18E9C", Offset = "0xE18E9C", VA = "0xE18E9C")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x6000133")]
			[Address(RVA = "0xE18EA8", Offset = "0xE18EA8", VA = "0xE18EA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public float BrushSpeed
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0xE18EB4", Offset = "0xE18EB4", VA = "0xE18EB4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0xE18EBC", Offset = "0xE18EBC", VA = "0xE18EBC")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public float VanishSpeed
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0xE18EC4", Offset = "0xE18EC4", VA = "0xE18EC4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000137")]
			[Address(RVA = "0xE18ECC", Offset = "0xE18ECC", VA = "0xE18ECC")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public float BrushStrength
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0xE18ED4", Offset = "0xE18ED4", VA = "0xE18ED4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000139")]
			[Address(RVA = "0xE18EDC", Offset = "0xE18EDC", VA = "0xE18EDC")]
			set
			{
			}
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xE18EE4", Offset = "0xE18EE4", VA = "0xE18EE4")]
		public Brush(Texture brushTex, float scale, Color color)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xE18F7C", Offset = "0xE18F7C", VA = "0xE18F7C")]
		public Brush(Texture brushTex, float scale, Color color, ColorBlendType colorBlending)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xE18FA0", Offset = "0xE18FA0", VA = "0xE18FA0")]
		public Brush(Texture brushTex, float scale, Color color, Texture normalTex, float normalBlend)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xE18FE8", Offset = "0xE18FE8", VA = "0xE18FE8")]
		public Brush(Texture brushTex, float scale, Color color, Texture normalTex, float normalBlend, ColorBlendType colorBlending, NormalBlendType normalBlending)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xE19044", Offset = "0xE19044", VA = "0xE19044")]
		public Brush(Texture brushTex, float scale, Color color, Texture normalTex, float normalBlend, Texture heightTex, float heightBlend, ColorBlendType colorBlending, NormalBlendType normalBlending, HeightBlendType heightBlending)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xE190C4", Offset = "0xE190C4", VA = "0xE190C4", Slot = "4")]
		public object Clone()
		{
			return null;
		}
	}
	[Token(Token = "0x2000028")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Renderer))]
	public class InkCanvas : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000029")]
		public class PaintSet
		{
			[NonSerialized]
			[Token(Token = "0x40000EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public Material material;

			[Token(Token = "0x40000F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			[Tooltip("The property name of the main texture.")]
			public string mainTextureName;

			[Token(Token = "0x40000F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Normal map texture property name.")]
			[SerializeField]
			public string normalTextureName;

			[Token(Token = "0x40000F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[SerializeField]
			[Tooltip("The property name of the heightmap texture.")]
			public string heightTextureName;

			[Token(Token = "0x40000F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Whether or not use main texture paint.")]
			[SerializeField]
			public bool useMainPaint;

			[Token(Token = "0x40000F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
			[Tooltip("Whether or not use normal map paint (you need material on normal maps).")]
			[SerializeField]
			public bool useNormalPaint;

			[Token(Token = "0x40000F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
			[Tooltip("Whether or not use heightmap painting (you need material on the heightmap).")]
			[SerializeField]
			public bool useHeightPaint;

			[NonSerialized]
			[Token(Token = "0x40000F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[HideInInspector]
			public Texture mainTexture;

			[NonSerialized]
			[Token(Token = "0x40000F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[HideInInspector]
			public RenderTexture paintMainTexture;

			[NonSerialized]
			[Token(Token = "0x40000F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[HideInInspector]
			public Texture normalTexture;

			[NonSerialized]
			[Token(Token = "0x40000F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[HideInInspector]
			public RenderTexture paintNormalTexture;

			[NonSerialized]
			[Token(Token = "0x40000FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[HideInInspector]
			public Texture heightTexture;

			[NonSerialized]
			[Token(Token = "0x40000FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public RenderTexture paintHeightTexture;

			[NonSerialized]
			[Token(Token = "0x40000FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public int mainTexturePropertyID;

			[NonSerialized]
			[Token(Token = "0x40000FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public int normalTexturePropertyID;

			[NonSerialized]
			[Token(Token = "0x40000FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[HideInInspector]
			public int heightTexturePropertyID;

			[Token(Token = "0x600017C")]
			[Address(RVA = "0xE1F5C8", Offset = "0xE1F5C8", VA = "0xE1F5C8")]
			public PaintSet()
			{
			}

			[Token(Token = "0x600017D")]
			[Address(RVA = "0xE1F660", Offset = "0xE1F660", VA = "0xE1F660")]
			public PaintSet(string mainTextureName, string normalTextureName, string heightTextureName, bool useMainPaint, bool useNormalPaint, bool useHeightPaint)
			{
			}

			[Token(Token = "0x600017E")]
			[Address(RVA = "0xE1F740", Offset = "0xE1F740", VA = "0xE1F740")]
			public PaintSet(string mainTextureName, string normalTextureName, string heightTextureName, bool useMainPaint, bool useNormalPaint, bool useHeightPaint, Material material)
			{
			}
		}

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DateTime UpDataTime;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material paintMainMaterial;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Material paintNormalMaterial;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Material paintHeightMaterial;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool eraseFlag;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RenderTexture debugEraserMainView;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RenderTexture debugEraserNormalView;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RenderTexture debugEraserHeightView;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_VanishBool;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Brush m_brushl;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool eraserDebug;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool drawStatus;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		private bool calculateProgressState;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		public List<PaintSet> paintSet;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int paintUVPropertyID;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int brushTexturePropertyID;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int brushScalePropertyID;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int brushRotatePropertyID;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int brushColorPropertyID;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int brushNormalTexturePropertyID;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int brushNormalBlendPropertyID;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int brushHeightTexturePropertyID;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int brushHeightBlendPropertyID;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int brushHeightColorPropertyID;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int brushChannelPropertyID;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private int brushSpeedPropertyID;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int brushStrengthPropertyID;

		[Token(Token = "0x40000DB")]
		private const string COLOR_BLEND_USE_CONTROL = "INK_PAINTER_COLOR_BLEND_USE_CONTROL";

		[Token(Token = "0x40000DC")]
		private const string COLOR_BLEND_USE_BRUSH = "INK_PAINTER_COLOR_BLEND_USE_BRUSH";

		[Token(Token = "0x40000DD")]
		private const string COLOR_BLEND_NEUTRAL = "INK_PAINTER_COLOR_BLEND_NEUTRAL";

		[Token(Token = "0x40000DE")]
		private const string COLOR_BLEND_ALPHA_ONLY = "INK_PAINTER_COLOR_BLEND_ALPHA_ONLY";

		[Token(Token = "0x40000DF")]
		private const string NORMAL_BLEND_USE_BRUSH = "INK_PAINTER_NORMAL_BLEND_USE_BRUSH";

		[Token(Token = "0x40000E0")]
		private const string NORMAL_BLEND_ADD = "INK_PAINTER_NORMAL_BLEND_ADD";

		[Token(Token = "0x40000E1")]
		private const string NORMAL_BLEND_SUB = "INK_PAINTER_NORMAL_BLEND_SUB";

		[Token(Token = "0x40000E2")]
		private const string NORMAL_BLEND_MIN = "INK_PAINTER_NORMAL_BLEND_MIN";

		[Token(Token = "0x40000E3")]
		private const string NORMAL_BLEND_MAX = "INK_PAINTER_NORMAL_BLEND_MAX";

		[Token(Token = "0x40000E4")]
		private const string DXT5NM_COMPRESS_USE = "DXT5NM_COMPRESS_USE";

		[Token(Token = "0x40000E5")]
		private const string DXT5NM_COMPRESS_UNUSE = "DXT5NM_COMPRESS_UNUSE";

		[Token(Token = "0x40000E6")]
		private const string HEIGHT_BLEND_USE_BRUSH = "INK_PAINTER_HEIGHT_BLEND_USE_BRUSH";

		[Token(Token = "0x40000E7")]
		private const string HEIGHT_BLEND_ADD = "INK_PAINTER_HEIGHT_BLEND_ADD";

		[Token(Token = "0x40000E8")]
		private const string HEIGHT_BLEND_SUB = "INK_PAINTER_HEIGHT_BLEND_SUB";

		[Token(Token = "0x40000E9")]
		private const string HEIGHT_BLEND_MIN = "INK_PAINTER_HEIGHT_BLEND_MIN";

		[Token(Token = "0x40000EA")]
		private const string HEIGHT_BLEND_MAX = "INK_PAINTER_HEIGHT_BLEND_MAX";

		[Token(Token = "0x40000EB")]
		private const string HEIGHT_BLEND_COLOR_RGB_HEIGHT_A = "INK_PAINTER_HEIGHT_BLEND_COLOR_RGB_HEIGHT_A";

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private MeshOperator meshOperator;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int index;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private DateTime NowTime;

		[Token(Token = "0x17000048")]
		public bool DrawStatus
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0xE190CC", Offset = "0xE190CC", VA = "0xE190CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000141")]
			[Address(RVA = "0xE190D4", Offset = "0xE190D4", VA = "0xE190D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public bool CalculateProgressState
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0xE190E0", Offset = "0xE190E0", VA = "0xE190E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000143")]
			[Address(RVA = "0xE190E8", Offset = "0xE190E8", VA = "0xE190E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public List<PaintSet> PaintDatas
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0xE190F4", Offset = "0xE190F4", VA = "0xE190F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000145")]
			[Address(RVA = "0xE190FC", Offset = "0xE190FC", VA = "0xE190FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public MeshOperator MeshOperator
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0xE197E4", Offset = "0xE197E4", VA = "0xE197E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000001")]
		public event Action<InkCanvas> OnCanvasAttached
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0xE19104", Offset = "0xE19104", VA = "0xE19104")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000147")]
			[Address(RVA = "0xE191B4", Offset = "0xE191B4", VA = "0xE191B4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event Action<InkCanvas> OnInitializedStart
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0xE19264", Offset = "0xE19264", VA = "0xE19264")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000149")]
			[Address(RVA = "0xE19314", Offset = "0xE19314", VA = "0xE19314")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event Action<InkCanvas> OnInitializedAfter
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0xE193C4", Offset = "0xE193C4", VA = "0xE193C4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0xE19474", Offset = "0xE19474", VA = "0xE19474")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event Action<InkCanvas, Brush> OnPaintStart
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0xE19524", Offset = "0xE19524", VA = "0xE19524")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0xE195D4", Offset = "0xE195D4", VA = "0xE195D4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event Action<InkCanvas> OnPaintEnd
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0xE19684", Offset = "0xE19684", VA = "0xE19684")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600014F")]
			[Address(RVA = "0xE19734", Offset = "0xE19734", VA = "0xE19734")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xE19860", Offset = "0xE19860", VA = "0xE19860")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xE19864", Offset = "0xE19864", VA = "0xE19864")]
		private void Start()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xE19868", Offset = "0xE19868", VA = "0xE19868")]
		public void Init(string path, string id)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xE1A8D0", Offset = "0xE1A8D0", VA = "0xE1A8D0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xE1AF58", Offset = "0xE1AF58", VA = "0xE1AF58")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xE1A438", Offset = "0xE1A438", VA = "0xE1A438")]
		private void MeshDataCache()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xE19914", Offset = "0xE19914", VA = "0xE19914")]
		private void InitPropertyID()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xE19C7C", Offset = "0xE19C7C", VA = "0xE19C7C")]
		private void SetMaterial()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xE1B3D4", Offset = "0xE1B3D4", VA = "0xE1B3D4")]
		private Texture2D LoadTextureByResources(string path)
		{
			return null;
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xE1B41C", Offset = "0xE1B41C", VA = "0xE1B41C")]
		public static Texture2D LoadTextureFromPNG(string fileName)
		{
			return null;
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xE1B5FC", Offset = "0xE1B5FC", VA = "0xE1B5FC")]
		private Texture2D LoadTextureByIO(string path)
		{
			return null;
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xE19F70", Offset = "0xE19F70", VA = "0xE19F70")]
		private void SetTexture(string path, string id)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xE1B8A8", Offset = "0xE1B8A8", VA = "0xE1B8A8")]
		private void SetTexture()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xE1BEA0", Offset = "0xE1BEA0", VA = "0xE1BEA0")]
		public void ReplaceTexture(int id)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xE1BF80", Offset = "0xE1BF80", VA = "0xE1BF80")]
		private RenderTexture SetupRenderTexture(Texture baseTex, int propertyID, Material material)
		{
			return null;
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xE1A5C4", Offset = "0xE1A5C4", VA = "0xE1A5C4")]
		private void SetRenderTexture()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xE1AF5C", Offset = "0xE1AF5C", VA = "0xE1AF5C")]
		private void ReleaseRenderTexture()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xE1C0A4", Offset = "0xE1C0A4", VA = "0xE1C0A4")]
		private void SetPaintMainData(Brush brush)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xE1C394", Offset = "0xE1C394", VA = "0xE1C394")]
		private void SetPaintMainData(Brush brush, Vector2 uv)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xE1C664", Offset = "0xE1C664", VA = "0xE1C664")]
		private void SetPaintNormalData(Brush brush, Vector2 uv, bool erase)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xE1C970", Offset = "0xE1C970", VA = "0xE1C970")]
		private void SetPaintHeightData(Brush brush, Vector2 uv)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xE1CC70", Offset = "0xE1CC70", VA = "0xE1CC70")]
		private Brush GetEraser(Brush brush, PaintSet paintSet, Vector2 uv, bool useMainPaint, bool useNormalPaint, bool useHeightpaint)
		{
			return null;
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xE1D308", Offset = "0xE1D308", VA = "0xE1D308")]
		private void ReleaseEraser(Brush brush, bool useMainPaint, bool useNormalPaint, bool useHeightpaint)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xE1A8E8", Offset = "0xE1A8E8", VA = "0xE1A8E8")]
		public bool Vanish(Brush brush, [Optional] Func<PaintSet, bool> materialSelector)
		{
			return default(bool);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xE1D444", Offset = "0xE1D444", VA = "0xE1D444")]
		public bool PaintUVDirect(Brush brush, Vector2 uv, [Optional] Func<PaintSet, bool> materialSelector)
		{
			return default(bool);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xE1DDF4", Offset = "0xE1DDF4", VA = "0xE1DDF4")]
		public bool PaintNearestTriangleSurface(Brush brush, Vector3 worldPos, [Optional] Func<PaintSet, bool> materialSelector, [Optional] Camera renderCamera)
		{
			return default(bool);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xE1E1C4", Offset = "0xE1E1C4", VA = "0xE1E1C4")]
		public bool Paint(Brush brush, Vector3 worldPos, [Optional] Func<PaintSet, bool> materialSelector, [Optional] Camera renderCamera)
		{
			return default(bool);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xE1E720", Offset = "0xE1E720", VA = "0xE1E720")]
		public bool Paint(Brush brush, RaycastHit hitInfo, [Optional] Func<PaintSet, bool> materialSelector)
		{
			return default(bool);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xE1E8A8", Offset = "0xE1E8A8", VA = "0xE1E8A8")]
		public bool EraseUVDirect(Brush brush, Vector2 uv, [Optional] Func<PaintSet, bool> materialSelector)
		{
			return default(bool);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xE1E8B4", Offset = "0xE1E8B4", VA = "0xE1E8B4")]
		public bool EraseNearestTriangleSurface(Brush brush, Vector3 worldPos, [Optional] Func<PaintSet, bool> materialSelector, [Optional] Camera renderCamera)
		{
			return default(bool);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xE1E8C0", Offset = "0xE1E8C0", VA = "0xE1E8C0")]
		public bool Erase(Brush brush, Vector3 worldPos, [Optional] Func<PaintSet, bool> materialSelector, [Optional] Camera renderCamera)
		{
			return default(bool);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xE1E8CC", Offset = "0xE1E8CC", VA = "0xE1E8CC")]
		public bool Erase(Brush brush, RaycastHit hitInfo, [Optional] Func<PaintSet, bool> materialSelector)
		{
			return default(bool);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xE1E904", Offset = "0xE1E904", VA = "0xE1E904")]
		public void ResetPaint()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xE1E940", Offset = "0xE1E940", VA = "0xE1E940")]
		public Texture GetMainTexture(string materialName)
		{
			return null;
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xE1EA70", Offset = "0xE1EA70", VA = "0xE1EA70")]
		public RenderTexture GetPaintMainTexture(string materialName)
		{
			return null;
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xE1EBA0", Offset = "0xE1EBA0", VA = "0xE1EBA0")]
		public void SetPaintMainTexture(string materialName, RenderTexture newTexture)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xE1ED48", Offset = "0xE1ED48", VA = "0xE1ED48")]
		public Texture GetNormalTexture(string materialName)
		{
			return null;
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xE1EE78", Offset = "0xE1EE78", VA = "0xE1EE78")]
		public RenderTexture GetPaintNormalTexture(string materialName)
		{
			return null;
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xE1EFA8", Offset = "0xE1EFA8", VA = "0xE1EFA8")]
		public void SetPaintNormalTexture(string materialName, RenderTexture newTexture)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xE1F150", Offset = "0xE1F150", VA = "0xE1F150")]
		public Texture GetHeightTexture(string materialName)
		{
			return null;
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xE1F280", Offset = "0xE1F280", VA = "0xE1F280")]
		public RenderTexture GetPaintHeightTexture(string materialName)
		{
			return null;
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xE1F3B0", Offset = "0xE1F3B0", VA = "0xE1F3B0")]
		public void SetPaintHeightTexture(string materialName, RenderTexture newTexture)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xE1F558", Offset = "0xE1F558", VA = "0xE1F558")]
		public InkCanvas()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public static class Math
	{
		[Token(Token = "0x4000108")]
		private const float TOLERANCE = 0.01f;

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xE1FC5C", Offset = "0xE1FC5C", VA = "0xE1FC5C")]
		public static bool ExistPointInPlane(Vector3 p, Vector3 t1, Vector3 t2, Vector3 t3)
		{
			return default(bool);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xE1FE80", Offset = "0xE1FE80", VA = "0xE1FE80")]
		public static bool ExistPointOnEdge(Vector3 p, Vector3 v1, Vector3 v2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xE20070", Offset = "0xE20070", VA = "0xE20070")]
		public static bool ExistPointOnTriangleEdge(Vector3 p, Vector3 t1, Vector3 t2, Vector3 t3)
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xE20160", Offset = "0xE20160", VA = "0xE20160")]
		public static bool ExistPointInTriangle(Vector3 p, Vector3 t1, Vector3 t2, Vector3 t3)
		{
			return default(bool);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xE20544", Offset = "0xE20544", VA = "0xE20544")]
		public static Vector2 TextureCoordinateCalculation(Vector3 p, Vector3 t1, Vector2 t1UV, Vector3 t2, Vector2 t2UV, Vector3 t3, Vector2 t3UV, Matrix4x4 transformMatrix)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xE2079C", Offset = "0xE2079C", VA = "0xE2079C")]
		public static Vector3[] GetNearestVerticesTriangle(Vector3 p, Vector3[] vertices, int[] triangles)
		{
			return null;
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xE20BF0", Offset = "0xE20BF0", VA = "0xE20BF0")]
		public static Vector3 TriangleSpaceProjection(Vector3 p, Vector3 t1, Vector3 t2, Vector3 t3)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000035")]
	public class MeshOperator
	{
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Mesh mesh;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int[] meshTriangles;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3[] meshVertices;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector2[] meshUV;

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xE1B2C0", Offset = "0xE1B2C0", VA = "0xE1B2C0")]
		public MeshOperator(Mesh mesh)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xE1E494", Offset = "0xE1E494", VA = "0xE1E494")]
		public bool LocalPointToUV(Vector3 localPoint, Matrix4x4 matrixMVP, out Vector2 uv)
		{
			return default(bool);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xE1DF34", Offset = "0xE1DF34", VA = "0xE1DF34")]
		public Vector3 NearestLocalSurfacePoint(Vector3 localPoint)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000037")]
	public static class GameObjectExtension
	{
		[Token(Token = "0x600019F")]
		[Address(RVA = "0xE21014", Offset = "0xE21014", VA = "0xE21014")]
		public static InkCanvas AddInkCanvas(this GameObject gameObject, List<InkCanvas.PaintSet> paintDatas)
		{
			return null;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xE21208", Offset = "0xE21208", VA = "0xE21208")]
		public static InkCanvas AddInkCanvas(this GameObject gameObject, InkCanvas.PaintSet paintData)
		{
			return null;
		}
	}
}
namespace Es.InkPainter.Effective
{
	[Token(Token = "0x2000039")]
	public static class GrabArea
	{
		[Token(Token = "0x200003A")]
		public enum GrabTextureWrapMode
		{
			[Token(Token = "0x400011D")]
			Clamp,
			[Token(Token = "0x400011E")]
			Repeat,
			[Token(Token = "0x400011F")]
			Clip
		}

		[Token(Token = "0x4000110")]
		private const string GRAB_AREA_MATERIAL = "Es.InkPainter.Effective.GrabArea";

		[Token(Token = "0x4000111")]
		private const string CLIP = "_ClipTex";

		[Token(Token = "0x4000112")]
		private const string TARGET = "_TargetTex";

		[Token(Token = "0x4000113")]
		private const string CLIP_SCALE = "_ClipScale";

		[Token(Token = "0x4000114")]
		private const string CLIP_UV = "_ClipUV";

		[Token(Token = "0x4000115")]
		private const string ROTATE = "_Rotate";

		[Token(Token = "0x4000116")]
		private const string WM_CLAMP = "WRAP_MODE_CLAMP";

		[Token(Token = "0x4000117")]
		private const string WM_REPEAT = "WRAP_MODE_REPEAT";

		[Token(Token = "0x4000118")]
		private const string WM_CLIP = "WRAP_MODE_CLIP";

		[Token(Token = "0x4000119")]
		private const string ALPHA_REPLACE = "ALPHA_REPLACE";

		[Token(Token = "0x400011A")]
		private const string ALPHA_NOT_REPLACE = "ALPHA_NOT_REPLACE";

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material grabAreaMaterial;

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xE1D170", Offset = "0xE1D170", VA = "0xE1D170")]
		public static void Clip(Texture clipTexture, float clipScale, Texture grabTargetTexture, Vector2 targetUV, float rotateAngle, GrabTextureWrapMode wrapMode, RenderTexture dst, bool replaceAlpha = true)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xE21370", Offset = "0xE21370", VA = "0xE21370")]
		private static void InitGrabAreaMaterial()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xE21430", Offset = "0xE21430", VA = "0xE21430")]
		private static void SetGrabAreaProperty(Texture clip, float clipScale, Texture grabTarget, Vector2 targetUV, float rotateAngle, GrabTextureWrapMode wrapMpde, bool replaceAlpha)
		{
		}
	}
	[Token(Token = "0x200003B")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(InkCanvas))]
	public class HeightFluid : MonoBehaviour
	{
		[Token(Token = "0x200003C")]
		private enum ColorSynthesis
		{
			[Token(Token = "0x400013A")]
			Add,
			[Token(Token = "0x400013B")]
			Overwrite
		}

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool useMainTextureFluid;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool useNormalMapFluid;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int createTextureSize;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ColorSynthesis colorSynthesis;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Range(0f, 1f)]
		private float alpha;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector2 flowDirection;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Range(0f, 1f)]
		private float flowingForce;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0.1f, 10f)]
		[SerializeField]
		private float easeOfDripping;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(1f, 0f)]
		[SerializeField]
		private float influenceOfNormal;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Range(0.01f, 1f)]
		private float horizontalSpread;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float normalScaleFactor;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		[Range(0.001f, 0.999f)]
		private float AdhesionBorder;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool performanceOptimize;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[Range(0.01f, 10f)]
		private float fluidProcessStopTime;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool enabledFluid;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float lastPaintedTime;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material heightFluid;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material height2Normal;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material height2Color;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material singleColorFill;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material invertAlpha;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private InkCanvas canvas;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Color lastPaintedColor;

		[Token(Token = "0x4000137")]
		private const string COLOR_SYNTHESIS_ADD = "COLOR_SYNTHESIS_ADD";

		[Token(Token = "0x4000138")]
		private const string COLOR_SYNTHESIS_OVERWRITE = "COLOR_SYNTHESIS_OVERWRITE";

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xE2170C", Offset = "0xE2170C", VA = "0xE2170C")]
		private void Init(InkCanvas canvas)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xE21990", Offset = "0xE21990", VA = "0xE21990")]
		private void SingleColorFill(RenderTexture texture, Color color)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xE21AC4", Offset = "0xE21AC4", VA = "0xE21AC4")]
		private void InvertAlpha(RenderTexture texture)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xE21BA0", Offset = "0xE21BA0", VA = "0xE21BA0")]
		private void EnabledFluid(InkCanvas canvas, Brush brush)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xE21BEC", Offset = "0xE21BEC", VA = "0xE21BEC")]
		private void StopFluid()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xE21DC4", Offset = "0xE21DC4", VA = "0xE21DC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xE2206C", Offset = "0xE2206C", VA = "0xE2206C")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xE22E20", Offset = "0xE22E20", VA = "0xE22E20")]
		public HeightFluid()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public static class ReverseUV
	{
		[Token(Token = "0x400013C")]
		private const string REVERSE_UV_MATERIAL = "Es.InkPainter.Effective.ReverseUV";

		[Token(Token = "0x400013D")]
		private const string REVERSE_X = "_ReverseX";

		[Token(Token = "0x400013E")]
		private const string REVERSE_Y = "_ReverseY";

		[Token(Token = "0x400013F")]
		private const float DEFAULT = 1f;

		[Token(Token = "0x4000140")]
		private const float REVERSE = 0f;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material reverseUVMaterial;

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xE22F30", Offset = "0xE22F30", VA = "0xE22F30")]
		public static void Horizontal(Texture src, RenderTexture dst)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xE2323C", Offset = "0xE2323C", VA = "0xE2323C")]
		public static void Vertical(Texture src, RenderTexture dst)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xE232E4", Offset = "0xE232E4", VA = "0xE232E4")]
		public static void HorizontalAndVertical(Texture src, RenderTexture dst)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xE22FD8", Offset = "0xE22FD8", VA = "0xE22FD8")]
		private static void InitReverseUVMaterial()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xE23098", Offset = "0xE23098", VA = "0xE23098")]
		private static void SetReverseUVProperty(float x, float y)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xE2314C", Offset = "0xE2314C", VA = "0xE2314C")]
		private static void Blit(Texture src, RenderTexture dst)
		{
		}
	}
	[Token(Token = "0x200003E")]
	public static class TextureMorphing
	{
		[Token(Token = "0x4000142")]
		private const string TEXTURE_MORPHING_MATERIAL = "Es.InkPainter.Effective.TextureMorphing";

		[Token(Token = "0x4000143")]
		private const string LERP_COEFFICIENT = "_LerpCoef";

		[Token(Token = "0x4000144")]
		private const string SRC_TEX = "_SrcTex";

		[Token(Token = "0x4000145")]
		private const string DST_TEX = "_DstTex";

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material morphingMaterial;

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xE2338C", Offset = "0xE2338C", VA = "0xE2338C")]
		public static void Lerp(Texture src, RenderTexture dst, float lerpCoef)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xE234DC", Offset = "0xE234DC", VA = "0xE234DC")]
		private static void InitMorphingMaterial()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xE2359C", Offset = "0xE2359C", VA = "0xE2359C")]
		private static void SetMorphingProperty(Texture src, RenderTexture dst, float lerpCoef)
		{
		}
	}
}
namespace Es.InkPainter.Sample
{
	[Token(Token = "0x200003F")]
	public class ClipPainter : MonoBehaviour
	{
		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool grab;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Brush brush;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GrabArea.GrabTextureWrapMode wrapMode;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RenderTexture t;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RaycastHit hitInfo;

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xE236C0", Offset = "0xE236C0", VA = "0xE236C0")]
		public void Awake()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xE23778", Offset = "0xE23778", VA = "0xE23778")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xE239A0", Offset = "0xE239A0", VA = "0xE239A0")]
		public ClipPainter()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[RequireComponent(typeof(Collider), typeof(MeshRenderer))]
	public class CollisionPainter : MonoBehaviour
	{
		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Brush brush;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int wait;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int waitCount;

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xE239B4", Offset = "0xE239B4", VA = "0xE239B4")]
		public void Awake()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xE23A28", Offset = "0xE23A28", VA = "0xE23A28")]
		public void FixedUpdate()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xE23A38", Offset = "0xE23A38", VA = "0xE23A38")]
		public void OnCollisionStay(Collision collision)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xE23B9C", Offset = "0xE23B9C", VA = "0xE23B9C")]
		public CollisionPainter()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[RequireComponent(typeof(Collider))]
	public class CollisionReflectionPainter : MonoBehaviour
	{
		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Brush brush;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Camera cam;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 offset;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool debugMode;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RenderTexture rt;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RenderTexture debug;

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xE23BAC", Offset = "0xE23BAC", VA = "0xE23BAC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xE23CA8", Offset = "0xE23CA8", VA = "0xE23CA8")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xE23CB4", Offset = "0xE23CB4", VA = "0xE23CB4")]
		public void OnCollisionStay(Collision collision)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xE240F8", Offset = "0xE240F8", VA = "0xE240F8")]
		public CollisionReflectionPainter()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class MousePainter : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000044")]
		private enum UseMethodType
		{
			[Token(Token = "0x4000167")]
			RaycastHitInfo,
			[Token(Token = "0x4000168")]
			WorldPoint,
			[Token(Token = "0x4000169")]
			NearestSurfacePoint,
			[Token(Token = "0x400016A")]
			DirectUV
		}

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Brush brush;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UseMethodType useMethodType;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool erase;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform InitialPoint;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InputActionReference m_ActiveReference;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InputActionReference m_PrimaryButtonReference;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_ShootMode;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool m_ShootingMode;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private ParticleSystem.Particle particle;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private ParticleSystem m_WaterParticleSystem;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ParticleSystem m_SprayParticleSystem;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float m_ParticleStartSize;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float HitDistance;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float MaximumRange;

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xE24294", Offset = "0xE24294", VA = "0xE24294")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xE24770", Offset = "0xE24770", VA = "0xE24770")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xE2477C", Offset = "0xE2477C", VA = "0xE2477C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xE2483C", Offset = "0xE2483C", VA = "0xE2483C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xE24D8C", Offset = "0xE24D8C", VA = "0xE24D8C")]
		private void ActionStarted(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xE24E08", Offset = "0xE24E08", VA = "0xE24E08")]
		private void CanceledStarted(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xE24F0C", Offset = "0xE24F0C", VA = "0xE24F0C")]
		private void Shooting(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xE24854", Offset = "0xE24854", VA = "0xE24854")]
		private void Shoot()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xE24F94", Offset = "0xE24F94", VA = "0xE24F94")]
		public void OnGUI()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xE250BC", Offset = "0xE250BC", VA = "0xE250BC")]
		public MousePainter()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class ReflectPainter : MonoBehaviour
	{
		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Brush brush;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject camPref;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RenderTexture rt;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Camera cam;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector2 uv;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private InkCanvas paintObject;

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xE250CC", Offset = "0xE250CC", VA = "0xE250CC")]
		public void Awake()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xE25170", Offset = "0xE25170", VA = "0xE25170")]
		private void Update()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xE25554", Offset = "0xE25554", VA = "0xE25554")]
		public ReflectPainter()
		{
		}
	}
	[Token(Token = "0x2000046")]
	[RequireComponent(typeof(InkCanvas))]
	public class TextureRecovery : MonoBehaviour
	{
		[Token(Token = "0x2000047")]
		[CompilerGenerated]
		private sealed class <TextureLerp>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400017C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400017D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400017E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TextureRecovery <>4__this;

			[Token(Token = "0x400017F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x1700004C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001DC")]
				[Address(RVA = "0xE25BE0", Offset = "0xE25BE0", VA = "0xE25BE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001DE")]
				[Address(RVA = "0xE25C28", Offset = "0xE25C28", VA = "0xE25C28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001D9")]
			[Address(RVA = "0xE25958", Offset = "0xE25958", VA = "0xE25958")]
			[DebuggerHidden]
			public <TextureLerp>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60001DA")]
			[Address(RVA = "0xE25998", Offset = "0xE25998", VA = "0xE25998", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001DB")]
			[Address(RVA = "0xE2599C", Offset = "0xE2599C", VA = "0xE2599C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001DD")]
			[Address(RVA = "0xE25BE8", Offset = "0xE25BE8", VA = "0xE25BE8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float lerpCoefficient;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float callTimer;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool @fixed;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material material;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private InkCanvas canvas;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Texture defaultMainTexture;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RenderTexture paintMainTexture;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Texture defaultNormalMap;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RenderTexture paintNormalMap;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Texture defaultHeightMap;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RenderTexture paintHeightMap;

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xE2555C", Offset = "0xE2555C", VA = "0xE2555C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xE25614", Offset = "0xE25614", VA = "0xE25614")]
		private void Init(InkCanvas canvas)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xE257E8", Offset = "0xE257E8", VA = "0xE257E8")]
		public void FixedUpdate()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xE25780", Offset = "0xE25780", VA = "0xE25780")]
		[IteratorStateMachine(typeof(<TextureLerp>d__14))]
		private IEnumerator TextureLerp()
		{
			return null;
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xE25980", Offset = "0xE25980", VA = "0xE25980")]
		public TextureRecovery()
		{
		}
	}
}
namespace QFSW.PL
{
	[Token(Token = "0x2000048")]
	public class PerformanceLogger : MonoBehaviour
	{
		[Token(Token = "0x2000049")]
		public enum LoggerState
		{
			[Token(Token = "0x400018A")]
			None,
			[Token(Token = "0x400018B")]
			Logging,
			[Token(Token = "0x400018C")]
			Dumping
		}

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool openLogFolder;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static PerformanceLogger currentLogger;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Dictionary<float, float> frameTimes;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly List<string> loggedCustomEvents;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly List<float> loggedCustomEventsTimestamps;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float startTime;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Action completionCallback;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string systemSpecs;

		[Token(Token = "0x1700004E")]
		public static bool IsLogging
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0xE25C30", Offset = "0xE25C30", VA = "0xE25C30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004F")]
		public static LoggerState CurrentState
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0xE25CBC", Offset = "0xE25CBC", VA = "0xE25CBC")]
			[CompilerGenerated]
			get
			{
				return default(LoggerState);
			}
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0xE25D14", Offset = "0xE25D14", VA = "0xE25D14")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xE25D70", Offset = "0xE25D70", VA = "0xE25D70")]
		public static void StartLogger()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xE25F14", Offset = "0xE25F14", VA = "0xE25F14")]
		public static void LogCustomEvent(string eventData)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xE26118", Offset = "0xE26118", VA = "0xE26118")]
		public static void EndLogger(string path, string extraInfo = "", bool async = true, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xE27964", Offset = "0xE27964", VA = "0xE27964")]
		private static void ShowLogFolder(string path)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xE279C4", Offset = "0xE279C4", VA = "0xE279C4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xE279E0", Offset = "0xE279E0", VA = "0xE279E0")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xE27BBC", Offset = "0xE27BBC", VA = "0xE27BBC")]
		private void LogFrameTime()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xE27C44", Offset = "0xE27C44", VA = "0xE27C44")]
		private string AnalyseFramesUnderFPS(float FPSCutoff)
		{
			return null;
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xE26B9C", Offset = "0xE26B9C", VA = "0xE26B9C")]
		private void DumpLog(string path, string extraInfo = "")
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xE26534", Offset = "0xE26534", VA = "0xE26534")]
		private string GetSystemSpecs()
		{
			return null;
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xE281CC", Offset = "0xE281CC", VA = "0xE281CC")]
		public PerformanceLogger()
		{
		}
	}
}
namespace QFSW.PL.Internal
{
	[Token(Token = "0x200004D")]
	public static class FloatExtension
	{
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xE2805C", Offset = "0xE2805C", VA = "0xE2805C")]
		public static float RoundToSigFigs(this float num, int n)
		{
			return default(float);
		}
	}
}
