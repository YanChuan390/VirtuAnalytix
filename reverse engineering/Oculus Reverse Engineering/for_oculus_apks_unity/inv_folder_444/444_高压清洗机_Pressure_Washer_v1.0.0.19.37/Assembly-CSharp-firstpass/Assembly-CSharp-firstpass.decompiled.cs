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
		[Address(RVA = "0xE1539C", Offset = "0xE1539C", VA = "0xE1539C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000002")]
		[Address(RVA = "0xE153E4", Offset = "0xE153E4", VA = "0xE153E4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xE15430", Offset = "0xE15430", VA = "0xE15430")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xE15610", Offset = "0xE15610", VA = "0xE15610")]
	private void Update()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xE156C8", Offset = "0xE156C8", VA = "0xE156C8")]
	private bool CheckGripPressed()
	{
		return default(bool);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xE158D8", Offset = "0xE158D8", VA = "0xE158D8")]
	public void ShowIngameDebugConsole()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xE15A38", Offset = "0xE15A38", VA = "0xE15A38")]
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
	[Address(RVA = "0xE15A40", Offset = "0xE15A40", VA = "0xE15A40")]
	public void RecordBtnClick()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xE15D30", Offset = "0xE15D30", VA = "0xE15D30")]
	private void Update()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xE15E24", Offset = "0xE15E24", VA = "0xE15E24")]
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
		[Address(RVA = "0xE17820", Offset = "0xE17820", VA = "0xE17820")]
		public StateEnterEvent()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000007")]
	public class StateUpdateEvent : UnityEvent
	{
		[Token(Token = "0x6000036")]
		[Address(RVA = "0xE17868", Offset = "0xE17868", VA = "0xE17868")]
		public StateUpdateEvent()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000008")]
	public class StateExitEvent : UnityEvent<StateId>
	{
		[Token(Token = "0x6000037")]
		[Address(RVA = "0xE17870", Offset = "0xE17870", VA = "0xE17870")]
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
			[Address(RVA = "0xE178B8", Offset = "0xE178B8", VA = "0xE178B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000039")]
			[Address(RVA = "0xE178C0", Offset = "0xE178C0", VA = "0xE178C0")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public StateId id
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0xE178CC", Offset = "0xE178CC", VA = "0xE178CC")]
			get
			{
				return default(StateId);
			}
			[Token(Token = "0x600003B")]
			[Address(RVA = "0xE178D4", Offset = "0xE178D4", VA = "0xE178D4")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public StateEnterEvent onEnter
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0xE178DC", Offset = "0xE178DC", VA = "0xE178DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003D")]
			[Address(RVA = "0xE178E4", Offset = "0xE178E4", VA = "0xE178E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public StateUpdateEvent onUpdate
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0xE178EC", Offset = "0xE178EC", VA = "0xE178EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003F")]
			[Address(RVA = "0xE178F4", Offset = "0xE178F4", VA = "0xE178F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public StateExitEvent onExit
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0xE178FC", Offset = "0xE178FC", VA = "0xE178FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000041")]
			[Address(RVA = "0xE17904", Offset = "0xE17904", VA = "0xE17904")]
			set
			{
			}
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xE1774C", Offset = "0xE1774C", VA = "0xE1774C")]
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
		[Address(RVA = "0xE15E58", Offset = "0xE15E58", VA = "0xE15E58")]
		get
		{
			return null;
		}
		[Token(Token = "0x600000D")]
		[Address(RVA = "0xE15E60", Offset = "0xE15E60", VA = "0xE15E60")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public GameObject teleportControllerGameObject
	{
		[Token(Token = "0x600000E")]
		[Address(RVA = "0xE15E68", Offset = "0xE15E68", VA = "0xE15E68")]
		get
		{
			return null;
		}
		[Token(Token = "0x600000F")]
		[Address(RVA = "0xE15E70", Offset = "0xE15E70", VA = "0xE15E70")]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public InputActionReference teleportModeActivate
	{
		[Token(Token = "0x6000010")]
		[Address(RVA = "0xE15E78", Offset = "0xE15E78", VA = "0xE15E78")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000011")]
		[Address(RVA = "0xE15E80", Offset = "0xE15E80", VA = "0xE15E80")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public InputActionReference teleportModeCancel
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0xE15E88", Offset = "0xE15E88", VA = "0xE15E88")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000013")]
		[Address(RVA = "0xE15E90", Offset = "0xE15E90", VA = "0xE15E90")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public InputActionReference turn
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0xE15E98", Offset = "0xE15E98", VA = "0xE15E98")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000015")]
		[Address(RVA = "0xE15EA0", Offset = "0xE15EA0", VA = "0xE15EA0")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public InputActionReference move
	{
		[Token(Token = "0x6000016")]
		[Address(RVA = "0xE15EA8", Offset = "0xE15EA8", VA = "0xE15EA8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000017")]
		[Address(RVA = "0xE15EB0", Offset = "0xE15EB0", VA = "0xE15EB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public InputActionReference translateAnchor
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0xE15EB8", Offset = "0xE15EB8", VA = "0xE15EB8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000019")]
		[Address(RVA = "0xE15EC0", Offset = "0xE15EC0", VA = "0xE15EC0")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public InputActionReference rotateAnchor
	{
		[Token(Token = "0x600001A")]
		[Address(RVA = "0xE15EC8", Offset = "0xE15EC8", VA = "0xE15EC8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600001B")]
		[Address(RVA = "0xE15ED0", Offset = "0xE15ED0", VA = "0xE15ED0")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public ControllerState selectState
	{
		[Token(Token = "0x600001C")]
		[Address(RVA = "0xE15ED8", Offset = "0xE15ED8", VA = "0xE15ED8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000B")]
	public ControllerState teleportState
	{
		[Token(Token = "0x600001D")]
		[Address(RVA = "0xE15EE0", Offset = "0xE15EE0", VA = "0xE15EE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000C")]
	public ControllerState interactState
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0xE15EE8", Offset = "0xE15EE8", VA = "0xE15EE8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xE15EF0", Offset = "0xE15EF0", VA = "0xE15EF0")]
	protected void OnEnable()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xE16850", Offset = "0xE16850", VA = "0xE16850")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xE16BBC", Offset = "0xE16BBC", VA = "0xE16BBC")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xE16DBC", Offset = "0xE16DBC", VA = "0xE16DBC")]
	protected void Update()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xE16D1C", Offset = "0xE16D1C", VA = "0xE16D1C")]
	private void TransitionState(ControllerState fromState, ControllerState toState)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xE1626C", Offset = "0xE1626C", VA = "0xE1626C")]
	private void FindBaseControllerComponents()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xE165D8", Offset = "0xE165D8", VA = "0xE165D8")]
	private void FindTeleportControllerComponents()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xE16F18", Offset = "0xE16F18", VA = "0xE16F18")]
	private void SetBaseController(bool enable)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xE170B4", Offset = "0xE170B4", VA = "0xE170B4")]
	private void SetTeleportController(bool enable)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xE17210", Offset = "0xE17210", VA = "0xE17210")]
	private void OnEnterSelectState(StateId previousStateId)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xE172AC", Offset = "0xE172AC", VA = "0xE172AC")]
	private void OnExitSelectState(StateId nextStateId)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xE17334", Offset = "0xE17334", VA = "0xE17334")]
	private void OnEnterTeleportState(StateId previousStateId)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xE1733C", Offset = "0xE1733C", VA = "0xE1733C")]
	private void OnExitTeleportState(StateId nextStateId)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xE17344", Offset = "0xE17344", VA = "0xE17344")]
	private void OnEnterInteractState(StateId previousStateId)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xE17360", Offset = "0xE17360", VA = "0xE17360")]
	private void OnExitInteractState(StateId nextStateId)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xE1737C", Offset = "0xE1737C", VA = "0xE1737C")]
	private void OnUpdateSelectState()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xE17528", Offset = "0xE17528", VA = "0xE17528")]
	private void OnUpdateTeleportState()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xE175A8", Offset = "0xE175A8", VA = "0xE175A8")]
	private void OnUpdateInteractState()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xE17278", Offset = "0xE17278", VA = "0xE17278")]
	private static void EnableAction(InputActionReference actionReference)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xE17300", Offset = "0xE17300", VA = "0xE17300")]
	private static void DisableAction(InputActionReference actionReference)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xE174A4", Offset = "0xE174A4", VA = "0xE174A4")]
	private static InputAction GetInputAction(InputActionReference actionReference)
	{
		return null;
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xE17668", Offset = "0xE17668", VA = "0xE17668")]
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
	[Address(RVA = "0xE1790C", Offset = "0xE1790C", VA = "0xE1790C")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xE17AFC", Offset = "0xE17AFC", VA = "0xE17AFC")]
	protected void Update()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xE17B70", Offset = "0xE17B70", VA = "0xE17B70")]
	private void TriggerReleased(DeactivateEventArgs args)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xE17BDC", Offset = "0xE17BDC", VA = "0xE17BDC")]
	private void TriggerPulled(ActivateEventArgs args)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xE17C3C", Offset = "0xE17C3C", VA = "0xE17C3C")]
	private void DroppedGun(SelectExitEventArgs args)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xE17CA8", Offset = "0xE17CA8", VA = "0xE17CA8")]
	public void ShootEvent()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xE17CC8", Offset = "0xE17CC8", VA = "0xE17CC8")]
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
	[Address(RVA = "0xE17CD0", Offset = "0xE17CD0", VA = "0xE17CD0")]
	protected void OnEnable()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xE1801C", Offset = "0xE1801C", VA = "0xE1801C")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xE181F8", Offset = "0xE181F8", VA = "0xE181F8", Slot = "4")]
	protected virtual void OnFirstHoverEntered(HoverEnterEventArgs args)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xE181FC", Offset = "0xE181FC", VA = "0xE181FC", Slot = "5")]
	protected virtual void OnLastHoverExited(HoverExitEventArgs args)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xE18200", Offset = "0xE18200", VA = "0xE18200", Slot = "6")]
	protected virtual void OnFirstSelectEntered(SelectEnterEventArgs args)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xE18204", Offset = "0xE18204", VA = "0xE18204", Slot = "7")]
	protected virtual void OnLastSelectExited(SelectExitEventArgs args)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xE17F04", Offset = "0xE17F04", VA = "0xE17F04")]
	protected void UpdateColor()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xE18208", Offset = "0xE18208", VA = "0xE18208")]
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
		[Address(RVA = "0xE18D60", Offset = "0xE18D60", VA = "0xE18D60")]
		public void Attach(GameObject gameObject)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xE18F58", Offset = "0xE18F58", VA = "0xE18F58")]
		public void Enter()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xE18E6C", Offset = "0xE18E6C", VA = "0xE18E6C")]
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
		[Address(RVA = "0xE1851C", Offset = "0xE1851C", VA = "0xE1851C")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xE185B8", Offset = "0xE185B8", VA = "0xE185B8")]
		public void ClearAll()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xE18574", Offset = "0xE18574", VA = "0xE18574")]
		public void SetGameObject(ControllerStates state, GameObject parentGamObject)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xE18718", Offset = "0xE18718", VA = "0xE18718")]
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
		[Address(RVA = "0xE18274", Offset = "0xE18274", VA = "0xE18274")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000054")]
		[Address(RVA = "0xE1827C", Offset = "0xE1827C", VA = "0xE1827C")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public List<InputHelpers.Button> deactivationButtons
	{
		[Token(Token = "0x6000055")]
		[Address(RVA = "0xE18284", Offset = "0xE18284", VA = "0xE18284")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000056")]
		[Address(RVA = "0xE1828C", Offset = "0xE1828C", VA = "0xE1828C")]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public GameObject leftBaseController
	{
		[Token(Token = "0x6000057")]
		[Address(RVA = "0xE18294", Offset = "0xE18294", VA = "0xE18294")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000058")]
		[Address(RVA = "0xE1829C", Offset = "0xE1829C", VA = "0xE1829C")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public GameObject leftTeleportController
	{
		[Token(Token = "0x6000059")]
		[Address(RVA = "0xE182A4", Offset = "0xE182A4", VA = "0xE182A4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600005A")]
		[Address(RVA = "0xE182AC", Offset = "0xE182AC", VA = "0xE182AC")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public GameObject rightBaseController
	{
		[Token(Token = "0x600005B")]
		[Address(RVA = "0xE182B4", Offset = "0xE182B4", VA = "0xE182B4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600005C")]
		[Address(RVA = "0xE182BC", Offset = "0xE182BC", VA = "0xE182BC")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public GameObject rightTeleportController
	{
		[Token(Token = "0x600005D")]
		[Address(RVA = "0xE182C4", Offset = "0xE182C4", VA = "0xE182C4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600005E")]
		[Address(RVA = "0xE182CC", Offset = "0xE182CC", VA = "0xE182CC")]
		set
		{
		}
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xE182D4", Offset = "0xE182D4", VA = "0xE182D4")]
	protected void OnEnable()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xE18698", Offset = "0xE18698", VA = "0xE18698")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xE1861C", Offset = "0xE1861C", VA = "0xE1861C")]
	private void RegisterDevices(UnityEngine.XR.InputDevice connectedDevice)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xE187AC", Offset = "0xE187AC", VA = "0xE187AC")]
	protected void Update()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xE18CC0", Offset = "0xE18CC0", VA = "0xE18CC0")]
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
		[Address(RVA = "0xE19054", Offset = "0xE19054", VA = "0xE19054")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600006B")]
		[Address(RVA = "0xE19048", Offset = "0xE19048", VA = "0xE19048")]
		set
		{
		}
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xE1905C", Offset = "0xE1905C", VA = "0xE1905C", Slot = "88")]
	protected override bool GenerateTeleportRequest(IXRInteractor interactor, RaycastHit raycastHit, ref TeleportRequest teleportRequest)
	{
		return default(bool);
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xE19120", Offset = "0xE19120", VA = "0xE19120")]
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
			[Address(RVA = "0xE19584", Offset = "0xE19584", VA = "0xE19584", Slot = "4")]
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
			[Address(RVA = "0xE195CC", Offset = "0xE195CC", VA = "0xE195CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xE19340", Offset = "0xE19340", VA = "0xE19340")]
		[DebuggerHidden]
		public <StartTextMeshFade>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xE19454", Offset = "0xE19454", VA = "0xE19454", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xE19458", Offset = "0xE19458", VA = "0xE19458", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xE1958C", Offset = "0xE1958C", VA = "0xE1958C", Slot = "8")]
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
	[Address(RVA = "0xE19128", Offset = "0xE19128", VA = "0xE19128")]
	public void OnSliderEvent(float value)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xE19200", Offset = "0xE19200", VA = "0xE19200")]
	public void OnKnobEvent(float value)
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xE192D8", Offset = "0xE192D8", VA = "0xE192D8")]
	[IteratorStateMachine(typeof(<StartTextMeshFade>d__3))]
	private IEnumerator StartTextMeshFade(TextMesh textMesh)
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xE19368", Offset = "0xE19368", VA = "0xE19368")]
	public void OnButtonEvent()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xE193EC", Offset = "0xE193EC", VA = "0xE193EC")]
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
		[Address(RVA = "0xE199E4", Offset = "0xE199E4", VA = "0xE199E4")]
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
	[Address(RVA = "0xE195D4", Offset = "0xE195D4", VA = "0xE195D4", Slot = "47")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xE19630", Offset = "0xE19630", VA = "0xE19630", Slot = "65")]
	protected override void OnSelectEntering(SelectEnterEventArgs args)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xE199EC", Offset = "0xE199EC", VA = "0xE199EC", Slot = "67")]
	protected override void OnSelectExiting(SelectExitEventArgs args)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xE19BE4", Offset = "0xE19BE4", VA = "0xE19BE4")]
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
			[Address(RVA = "0xE19C84", Offset = "0xE19C84", VA = "0xE19C84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000080")]
			[Address(RVA = "0xE19C8C", Offset = "0xE19C8C", VA = "0xE19C8C")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public Slider moveSpeedSlider
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0xE19EDC", Offset = "0xE19EDC", VA = "0xE19EDC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000082")]
			[Address(RVA = "0xE19EE4", Offset = "0xE19EE4", VA = "0xE19EE4")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public Text moveSpeedValueText
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0xE1A2EC", Offset = "0xE1A2EC", VA = "0xE1A2EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000084")]
			[Address(RVA = "0xE1A2F4", Offset = "0xE1A2F4", VA = "0xE1A2F4")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public Toggle enableStrafeToggle
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0xE1A32C", Offset = "0xE1A32C", VA = "0xE1A32C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000086")]
			[Address(RVA = "0xE1A334", Offset = "0xE1A334", VA = "0xE1A334")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public Toggle useGravityToggle
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0xE1A58C", Offset = "0xE1A58C", VA = "0xE1A58C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000088")]
			[Address(RVA = "0xE1A594", Offset = "0xE1A594", VA = "0xE1A594")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public Dropdown gravityApplicationModeDropdown
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0xE1A7EC", Offset = "0xE1A7EC", VA = "0xE1A7EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008A")]
			[Address(RVA = "0xE1A7F4", Offset = "0xE1A7F4", VA = "0xE1A7F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public Dropdown forwardSourceDropdown
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0xE1AACC", Offset = "0xE1AACC", VA = "0xE1AACC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008C")]
			[Address(RVA = "0xE1AAD4", Offset = "0xE1AAD4", VA = "0xE1AAD4")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public Toggle continuousTurnToggle
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0xE1ADA4", Offset = "0xE1ADA4", VA = "0xE1ADA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008E")]
			[Address(RVA = "0xE1ADAC", Offset = "0xE1ADAC", VA = "0xE1ADAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public Slider turnSpeedSlider
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0xE1AFFC", Offset = "0xE1AFFC", VA = "0xE1AFFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000090")]
			[Address(RVA = "0xE1B004", Offset = "0xE1B004", VA = "0xE1B004")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public Text turnSpeedValueText
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0xE1B3E0", Offset = "0xE1B3E0", VA = "0xE1B3E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000092")]
			[Address(RVA = "0xE1B3E8", Offset = "0xE1B3E8", VA = "0xE1B3E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public Dropdown snapTurnAmountDropdown
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0xE1B420", Offset = "0xE1B420", VA = "0xE1B420")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000094")]
			[Address(RVA = "0xE1B428", Offset = "0xE1B428", VA = "0xE1B428")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public Toggle enableTurnAroundToggle
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0xE1B8C0", Offset = "0xE1B8C0", VA = "0xE1B8C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000096")]
			[Address(RVA = "0xE1B8C8", Offset = "0xE1B8C8", VA = "0xE1B8C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public LocomotionSchemeManager manager
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0xE1BB18", Offset = "0xE1BB18", VA = "0xE1BB18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000098")]
			[Address(RVA = "0xE1BB20", Offset = "0xE1BB20", VA = "0xE1BB20")]
			set
			{
			}
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xE1BCE4", Offset = "0xE1BCE4", VA = "0xE1BCE4")]
		protected void Awake()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xE1C0DC", Offset = "0xE1C0DC", VA = "0xE1C0DC")]
		protected void OnEnable()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xE1C30C", Offset = "0xE1C30C", VA = "0xE1C30C")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xE1BC38", Offset = "0xE1BC38", VA = "0xE1BC38")]
		private void SubscribeAll()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xE1BBB8", Offset = "0xE1BBB8", VA = "0xE1BBB8")]
		private void UnsubscribeAll()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xE1BCB8", Offset = "0xE1BCB8", VA = "0xE1BCB8")]
		private void RefreshInteractable()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xE1A2B0", Offset = "0xE1A2B0", VA = "0xE1A2B0")]
		private void RefreshMoveDependentInteractable()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xE1C310", Offset = "0xE1C310", VA = "0xE1C310")]
		private void RefreshMoveDependentInteractable(bool continuous)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xE1B3A4", Offset = "0xE1B3A4", VA = "0xE1B3A4")]
		private void RefreshTurnDependentInteractable()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xE1C498", Offset = "0xE1C498", VA = "0xE1C498")]
		private void RefreshTurnDependentInteractable(bool continuous)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xE1C108", Offset = "0xE1C108", VA = "0xE1C108")]
		private bool ValidateManager()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xE19DB8", Offset = "0xE19DB8", VA = "0xE19DB8")]
		private void SubscribeContinuousMove(Toggle toggle)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xE1A01C", Offset = "0xE1A01C", VA = "0xE1A01C")]
		private void SubscribeMoveSpeed(Slider slider, Text valueText)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xE1A468", Offset = "0xE1A468", VA = "0xE1A468")]
		private void SubscribeEnableStrafe(Toggle toggle)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xE1A6C8", Offset = "0xE1A6C8", VA = "0xE1A6C8")]
		private void SubscribeUseGravity(Toggle toggle)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xE1A928", Offset = "0xE1A928", VA = "0xE1A928")]
		private void SubscribeGravityApplicationMode(Dropdown dropdown)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xE1AC08", Offset = "0xE1AC08", VA = "0xE1AC08")]
		private void SubscribeForwardSource(Dropdown dropdown)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xE1AED8", Offset = "0xE1AED8", VA = "0xE1AED8")]
		private void SubscribeContinuousTurn(Toggle toggle)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xE1B13C", Offset = "0xE1B13C", VA = "0xE1B13C")]
		private void SubscribeTurnSpeed(Slider slider, Text valueText)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xE1B55C", Offset = "0xE1B55C", VA = "0xE1B55C")]
		private void SubscribeSnapTurnAmount(Dropdown dropdown)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xE1B9F4", Offset = "0xE1B9F4", VA = "0xE1B9F4")]
		private void SubscribeEnableTurnAround(Toggle toggle)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xE19CC0", Offset = "0xE19CC0", VA = "0xE19CC0")]
		private void UnsubscribeContinuousMove(Toggle toggle)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xE19F24", Offset = "0xE19F24", VA = "0xE19F24")]
		private void UnsubscribeMoveSpeed(Slider slider)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xE1A370", Offset = "0xE1A370", VA = "0xE1A370")]
		private void UnsubscribeEnableStrafe(Toggle toggle)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xE1A5D0", Offset = "0xE1A5D0", VA = "0xE1A5D0")]
		private void UnsubscribeUseGravity(Toggle toggle)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xE1A830", Offset = "0xE1A830", VA = "0xE1A830")]
		private void UnsubscribeGravityApplicationMode(Dropdown dropdown)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xE1AB10", Offset = "0xE1AB10", VA = "0xE1AB10")]
		private void UnsubscribeForwardSource(Dropdown dropdown)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xE1ADE0", Offset = "0xE1ADE0", VA = "0xE1ADE0")]
		private void UnsubscribeContinuousTurn(Toggle toggle)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xE1B044", Offset = "0xE1B044", VA = "0xE1B044")]
		private void UnsubscribeTurnSpeed(Slider slider)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xE1B464", Offset = "0xE1B464", VA = "0xE1B464")]
		private void UnsubscribeSnapTurnAmount(Dropdown dropdown)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xE1B8FC", Offset = "0xE1B8FC", VA = "0xE1B8FC")]
		private void UnsubscribeEnableTurnAround(Toggle toggle)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xE1C570", Offset = "0xE1C570", VA = "0xE1C570")]
		private void OnContinuousMoveToggleValueChanged(bool value)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xE1C5D4", Offset = "0xE1C5D4", VA = "0xE1C5D4")]
		private void OnMoveSpeedSliderValueChanged(float value)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xE1C698", Offset = "0xE1C698", VA = "0xE1C698")]
		private void OnEnableStrafeToggleValueChanged(bool value)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xE1C6C0", Offset = "0xE1C6C0", VA = "0xE1C6C0")]
		private void OnUseGravityToggleValueChanged(bool value)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xE1C6E8", Offset = "0xE1C6E8", VA = "0xE1C6E8")]
		private void OnGravityApplicationModeDropdownValueChanged(int index)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xE1C784", Offset = "0xE1C784", VA = "0xE1C784")]
		private void OnForwardSourceDropdownValueChanged(int index)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xE1C854", Offset = "0xE1C854", VA = "0xE1C854")]
		private void OnContinuousTurnToggleValueChanged(bool value)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xE1C8B8", Offset = "0xE1C8B8", VA = "0xE1C8B8")]
		private void OnTurnSpeedSliderValueChanged(float value)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xE1C914", Offset = "0xE1C914", VA = "0xE1C914")]
		private void OnSnapTurnAmountDropdownValueChanged(int index)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xE1C9B8", Offset = "0xE1C9B8", VA = "0xE1C9B8")]
		private void OnEnableTurnAroundToggleValueChanged(bool value)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xE1C9E0", Offset = "0xE1C9E0", VA = "0xE1C9E0")]
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
			[Address(RVA = "0xE1CD44", Offset = "0xE1CD44", VA = "0xE1CD44")]
			get
			{
				return default(MoveScheme);
			}
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0xE1C5B0", Offset = "0xE1C5B0", VA = "0xE1C5B0")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public TurnStyle turnStyle
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0xE1CEB8", Offset = "0xE1CEB8", VA = "0xE1CEB8")]
			get
			{
				return default(TurnStyle);
			}
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0xE1C894", Offset = "0xE1C894", VA = "0xE1C894")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public MoveForwardSource moveForwardSource
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0xE1D0B0", Offset = "0xE1D0B0", VA = "0xE1D0B0")]
			get
			{
				return default(MoveForwardSource);
			}
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0xE1C830", Offset = "0xE1C830", VA = "0xE1C830")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public List<InputActionAsset> actionAssets
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0xE1D2AC", Offset = "0xE1D2AC", VA = "0xE1D2AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0xE1D2B4", Offset = "0xE1D2B4", VA = "0xE1D2B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public List<string> actionMaps
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0xE1D2BC", Offset = "0xE1D2BC", VA = "0xE1D2BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0xE1D2C4", Offset = "0xE1D2C4", VA = "0xE1D2C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public List<InputActionReference> actions
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0xE1D2CC", Offset = "0xE1D2CC", VA = "0xE1D2CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0xE1D2D4", Offset = "0xE1D2D4", VA = "0xE1D2D4")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public string baseControlScheme
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0xE1D2DC", Offset = "0xE1D2DC", VA = "0xE1D2DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0xE1D2E4", Offset = "0xE1D2E4", VA = "0xE1D2E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public string noncontinuousControlScheme
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0xE1D2EC", Offset = "0xE1D2EC", VA = "0xE1D2EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0xE1D2F4", Offset = "0xE1D2F4", VA = "0xE1D2F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public string continuousControlScheme
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0xE1D2FC", Offset = "0xE1D2FC", VA = "0xE1D2FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0xE1D304", Offset = "0xE1D304", VA = "0xE1D304")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public ContinuousMoveProviderBase continuousMoveProvider
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0xE1D30C", Offset = "0xE1D30C", VA = "0xE1D30C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0xE1D314", Offset = "0xE1D314", VA = "0xE1D314")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public ContinuousTurnProviderBase continuousTurnProvider
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0xE1D31C", Offset = "0xE1D31C", VA = "0xE1D31C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0xE1D324", Offset = "0xE1D324", VA = "0xE1D324")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public SnapTurnProviderBase snapTurnProvider
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0xE1D32C", Offset = "0xE1D32C", VA = "0xE1D32C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0xE1D334", Offset = "0xE1D334", VA = "0xE1D334")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public Transform headForwardSource
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0xE1D33C", Offset = "0xE1D33C", VA = "0xE1D33C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0xE1D344", Offset = "0xE1D344", VA = "0xE1D344")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public Transform leftHandForwardSource
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0xE1D34C", Offset = "0xE1D34C", VA = "0xE1D34C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0xE1D354", Offset = "0xE1D354", VA = "0xE1D354")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public Transform rightHandForwardSource
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0xE1D35C", Offset = "0xE1D35C", VA = "0xE1D35C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0xE1D364", Offset = "0xE1D364", VA = "0xE1D364")]
			set
			{
			}
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xE1D36C", Offset = "0xE1D36C", VA = "0xE1D36C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xE1D398", Offset = "0xE1D398", VA = "0xE1D398")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xE1CD4C", Offset = "0xE1CD4C", VA = "0xE1CD4C")]
		private void SetMoveScheme(MoveScheme scheme)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xE1CEC0", Offset = "0xE1CEC0", VA = "0xE1CEC0")]
		private void SetTurnStyle(TurnStyle style)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xE1D0B8", Offset = "0xE1D0B8", VA = "0xE1D0B8")]
		private void SetMoveForwardSource(MoveForwardSource forwardSource)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xE1D3EC", Offset = "0xE1D3EC", VA = "0xE1D3EC")]
		private void SetBindingMasks(string controlSchemeName)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xE1D39C", Offset = "0xE1D39C", VA = "0xE1D39C")]
		private void ClearBindingMasks()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xE1DB0C", Offset = "0xE1DB0C", VA = "0xE1DB0C")]
		private InputControlScheme? FindControlScheme(string controlSchemeName, InputActionReference action)
		{
			return null;
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xE1DF04", Offset = "0xE1DF04", VA = "0xE1DF04")]
		private InputControlScheme? FindControlScheme(string controlSchemeName, InputActionAsset asset)
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xE1DCC4", Offset = "0xE1DCC4", VA = "0xE1DCC4")]
		private static InputBinding? GetBindingMask(InputControlScheme? baseInputControlScheme, InputControlScheme? inputControlScheme)
		{
			return null;
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xE1E0D8", Offset = "0xE1E0D8", VA = "0xE1E0D8")]
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
		[Address(RVA = "0xE1E0E0", Offset = "0xE1E0E0", VA = "0xE1E0E0")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xE1E154", Offset = "0xE1E154", VA = "0xE1E154")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xE1E248", Offset = "0xE1E248", VA = "0xE1E248")]
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
		[Address(RVA = "0xE1E250", Offset = "0xE1E250", VA = "0xE1E250")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xE1E42C", Offset = "0xE1E42C", VA = "0xE1E42C")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xE1E8BC", Offset = "0xE1E8BC", VA = "0xE1E8BC")]
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
		[Address(RVA = "0xE1EAB8", Offset = "0xE1EAB8", VA = "0xE1EAB8", Slot = "5")]
		protected override void OnSubsystemCreate()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xE1EB50", Offset = "0xE1EB50", VA = "0xE1EB50", Slot = "6")]
		protected override void OnSubsystemStart()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xE1EB98", Offset = "0xE1EB98", VA = "0xE1EB98", Slot = "7")]
		protected override void OnSubsystemStop()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xE1EBE0", Offset = "0xE1EBE0", VA = "0xE1EBE0", Slot = "8")]
		protected override void OnSubsystemDestroy()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xE1EC28", Offset = "0xE1EC28", VA = "0xE1EC28")]
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
			[Address(RVA = "0xE1ED90", Offset = "0xE1ED90", VA = "0xE1ED90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000101")]
			[Address(RVA = "0xE1ED98", Offset = "0xE1ED98", VA = "0xE1ED98")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xE1EDA0", Offset = "0xE1EDA0", VA = "0xE1EDA0", Slot = "4")]
		protected override IntPtr HookGetInstanceProcAddr(IntPtr func)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xE1EE90", Offset = "0xE1EE90", VA = "0xE1EE90", Slot = "9")]
		protected override bool OnInstanceCreate(ulong xrInstance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xE1ECBC", Offset = "0xE1ECBC", VA = "0xE1ECBC")]
		[MonoPInvokeCallback(typeof(OnMessageDelegate))]
		private static void OnMessage(string message)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xE1F188", Offset = "0xE1F188", VA = "0xE1F188", Slot = "11")]
		protected override void OnSessionCreate(ulong xrSession)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xE1F248", Offset = "0xE1F248", VA = "0xE1F248", Slot = "14")]
		protected override void OnSessionBegin(ulong xrSession)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xE1F308", Offset = "0xE1F308", VA = "0xE1F308", Slot = "15")]
		protected override void OnSessionEnd(ulong xrSession)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000108")]
		[Address(RVA = "0xE1EE14", Offset = "0xE1EE14", VA = "0xE1EE14")]
		private static extern IntPtr intercept_xrCreateSession_xrGetInstanceProcAddr(IntPtr func);

		[PreserveSig]
		[Token(Token = "0x6000109")]
		[Address(RVA = "0xE1F104", Offset = "0xE1F104", VA = "0xE1F104")]
		private static extern void Internal_SetMessage(string printString);

		[PreserveSig]
		[Token(Token = "0x600010A")]
		[Address(RVA = "0xE1F084", Offset = "0xE1F084", VA = "0xE1F084")]
		private static extern void Internal_SetCallback(ReceiveMessageDelegate callback);

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xE1F3C8", Offset = "0xE1F3C8", VA = "0xE1F3C8")]
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
		[Address(RVA = "0xE1F56C", Offset = "0xE1F56C", VA = "0xE1F56C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xE1F678", Offset = "0xE1F678", VA = "0xE1F678")]
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
		[Address(RVA = "0xE1F680", Offset = "0xE1F680", VA = "0xE1F680")]
		private void Update()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xE1F684", Offset = "0xE1F684", VA = "0xE1F684")]
		private void MouseUpdate()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xE1F72C", Offset = "0xE1F72C", VA = "0xE1F72C")]
		private void MouseWheel(float delta)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xE1F7C8", Offset = "0xE1F7C8", VA = "0xE1F7C8")]
		private void MouseDrag(Vector3 mousePos)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xE1F908", Offset = "0xE1F908", VA = "0xE1F908")]
		public void CameraRotate(Vector2 angle)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xE1FA40", Offset = "0xE1FA40", VA = "0xE1FA40")]
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
			[Address(RVA = "0xE1FA60", Offset = "0xE1FA60", VA = "0xE1FA60")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011D")]
			[Address(RVA = "0xE1FA68", Offset = "0xE1FA68", VA = "0xE1FA68")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public Texture BrushNormalTexture
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0xE1FA70", Offset = "0xE1FA70", VA = "0xE1FA70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011F")]
			[Address(RVA = "0xE1FA78", Offset = "0xE1FA78", VA = "0xE1FA78")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public Texture BrushHeightTexture
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0xE1FA80", Offset = "0xE1FA80", VA = "0xE1FA80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000121")]
			[Address(RVA = "0xE1FA88", Offset = "0xE1FA88", VA = "0xE1FA88")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public float Scale
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0xE1FA90", Offset = "0xE1FA90", VA = "0xE1FA90")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000123")]
			[Address(RVA = "0xE1FAAC", Offset = "0xE1FAAC", VA = "0xE1FAAC")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public float RotateAngle
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0xE1FAC8", Offset = "0xE1FAC8", VA = "0xE1FAC8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000125")]
			[Address(RVA = "0xE1FAD0", Offset = "0xE1FAD0", VA = "0xE1FAD0")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public float NormalBlend
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0xE1FAD8", Offset = "0xE1FAD8", VA = "0xE1FAD8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000127")]
			[Address(RVA = "0xE1FAF4", Offset = "0xE1FAF4", VA = "0xE1FAF4")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public float HeightBlend
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0xE1FB10", Offset = "0xE1FB10", VA = "0xE1FB10")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000129")]
			[Address(RVA = "0xE1FB2C", Offset = "0xE1FB2C", VA = "0xE1FB2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public Color Color
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0xE1FB48", Offset = "0xE1FB48", VA = "0xE1FB48")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600012B")]
			[Address(RVA = "0xE1FB54", Offset = "0xE1FB54", VA = "0xE1FB54")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public ColorBlendType ColorBlending
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0xE1FB60", Offset = "0xE1FB60", VA = "0xE1FB60")]
			get
			{
				return default(ColorBlendType);
			}
			[Token(Token = "0x600012D")]
			[Address(RVA = "0xE1FB68", Offset = "0xE1FB68", VA = "0xE1FB68")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public NormalBlendType NormalBlending
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0xE1FB70", Offset = "0xE1FB70", VA = "0xE1FB70")]
			get
			{
				return default(NormalBlendType);
			}
			[Token(Token = "0x600012F")]
			[Address(RVA = "0xE1FB78", Offset = "0xE1FB78", VA = "0xE1FB78")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public HeightBlendType HeightBlending
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0xE1FB80", Offset = "0xE1FB80", VA = "0xE1FB80")]
			get
			{
				return default(HeightBlendType);
			}
			[Token(Token = "0x6000131")]
			[Address(RVA = "0xE1FB88", Offset = "0xE1FB88", VA = "0xE1FB88")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public Vector4 BrushChannel
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0xE1FB90", Offset = "0xE1FB90", VA = "0xE1FB90")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x6000133")]
			[Address(RVA = "0xE1FB9C", Offset = "0xE1FB9C", VA = "0xE1FB9C")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public float BrushSpeed
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0xE1FBA8", Offset = "0xE1FBA8", VA = "0xE1FBA8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0xE1FBB0", Offset = "0xE1FBB0", VA = "0xE1FBB0")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public float VanishSpeed
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0xE1FBB8", Offset = "0xE1FBB8", VA = "0xE1FBB8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000137")]
			[Address(RVA = "0xE1FBC0", Offset = "0xE1FBC0", VA = "0xE1FBC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public float BrushStrength
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0xE1FBC8", Offset = "0xE1FBC8", VA = "0xE1FBC8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000139")]
			[Address(RVA = "0xE1FBD0", Offset = "0xE1FBD0", VA = "0xE1FBD0")]
			set
			{
			}
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xE1FBD8", Offset = "0xE1FBD8", VA = "0xE1FBD8")]
		public Brush(Texture brushTex, float scale, Color color)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xE1FC70", Offset = "0xE1FC70", VA = "0xE1FC70")]
		public Brush(Texture brushTex, float scale, Color color, ColorBlendType colorBlending)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xE1FC94", Offset = "0xE1FC94", VA = "0xE1FC94")]
		public Brush(Texture brushTex, float scale, Color color, Texture normalTex, float normalBlend)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xE1FCDC", Offset = "0xE1FCDC", VA = "0xE1FCDC")]
		public Brush(Texture brushTex, float scale, Color color, Texture normalTex, float normalBlend, ColorBlendType colorBlending, NormalBlendType normalBlending)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xE1FD38", Offset = "0xE1FD38", VA = "0xE1FD38")]
		public Brush(Texture brushTex, float scale, Color color, Texture normalTex, float normalBlend, Texture heightTex, float heightBlend, ColorBlendType colorBlending, NormalBlendType normalBlending, HeightBlendType heightBlending)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xE1FDB8", Offset = "0xE1FDB8", VA = "0xE1FDB8", Slot = "4")]
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
			[Token(Token = "0x40000F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public Material material;

			[Token(Token = "0x40000F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			[Tooltip("The property name of the main texture.")]
			public string mainTextureName;

			[Token(Token = "0x40000F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Normal map texture property name.")]
			[SerializeField]
			public string normalTextureName;

			[Token(Token = "0x40000F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[SerializeField]
			[Tooltip("The property name of the heightmap texture.")]
			public string heightTextureName;

			[Token(Token = "0x40000F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Whether or not use main texture paint.")]
			[SerializeField]
			public bool useMainPaint;

			[Token(Token = "0x40000F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
			[Tooltip("Whether or not use normal map paint (you need material on normal maps).")]
			[SerializeField]
			public bool useNormalPaint;

			[Token(Token = "0x40000F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
			[Tooltip("Whether or not use heightmap painting (you need material on the heightmap).")]
			[SerializeField]
			public bool useHeightPaint;

			[NonSerialized]
			[Token(Token = "0x40000FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[HideInInspector]
			public Texture mainTexture;

			[NonSerialized]
			[Token(Token = "0x40000FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[HideInInspector]
			public RenderTexture paintMainTexture;

			[NonSerialized]
			[Token(Token = "0x40000FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[HideInInspector]
			public Texture normalTexture;

			[NonSerialized]
			[Token(Token = "0x40000FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[HideInInspector]
			public RenderTexture paintNormalTexture;

			[NonSerialized]
			[Token(Token = "0x40000FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[HideInInspector]
			public Texture heightTexture;

			[NonSerialized]
			[Token(Token = "0x40000FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public RenderTexture paintHeightTexture;

			[NonSerialized]
			[Token(Token = "0x4000100")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public int mainTexturePropertyID;

			[NonSerialized]
			[Token(Token = "0x4000101")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public int normalTexturePropertyID;

			[NonSerialized]
			[Token(Token = "0x4000102")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[HideInInspector]
			public int heightTexturePropertyID;

			[Token(Token = "0x600017D")]
			[Address(RVA = "0xE2681C", Offset = "0xE2681C", VA = "0xE2681C")]
			public PaintSet()
			{
			}

			[Token(Token = "0x600017E")]
			[Address(RVA = "0xE268B4", Offset = "0xE268B4", VA = "0xE268B4")]
			public PaintSet(string mainTextureName, string normalTextureName, string heightTextureName, bool useMainPaint, bool useNormalPaint, bool useHeightPaint)
			{
			}

			[Token(Token = "0x600017F")]
			[Address(RVA = "0xE26994", Offset = "0xE26994", VA = "0xE26994")]
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
		private ComputeShader computeAndCleanCS;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int kernelComputeAndClean;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int kernelInitComputeAndClean;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool computeShaderIsSupported;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private int index;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private DateTime NowTime;

		[Token(Token = "0x17000048")]
		public bool DrawStatus
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0xE1FDC0", Offset = "0xE1FDC0", VA = "0xE1FDC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000141")]
			[Address(RVA = "0xE1FDC8", Offset = "0xE1FDC8", VA = "0xE1FDC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public bool CalculateProgressState
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0xE1FDD4", Offset = "0xE1FDD4", VA = "0xE1FDD4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000143")]
			[Address(RVA = "0xE1FDDC", Offset = "0xE1FDDC", VA = "0xE1FDDC")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public List<PaintSet> PaintDatas
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0xE1FDE8", Offset = "0xE1FDE8", VA = "0xE1FDE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000145")]
			[Address(RVA = "0xE1FDF0", Offset = "0xE1FDF0", VA = "0xE1FDF0")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public MeshOperator MeshOperator
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0xE204D8", Offset = "0xE204D8", VA = "0xE204D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000001")]
		public event Action<InkCanvas> OnCanvasAttached
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0xE1FDF8", Offset = "0xE1FDF8", VA = "0xE1FDF8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000147")]
			[Address(RVA = "0xE1FEA8", Offset = "0xE1FEA8", VA = "0xE1FEA8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event Action<InkCanvas> OnInitializedStart
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0xE1FF58", Offset = "0xE1FF58", VA = "0xE1FF58")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000149")]
			[Address(RVA = "0xE20008", Offset = "0xE20008", VA = "0xE20008")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event Action<InkCanvas> OnInitializedAfter
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0xE200B8", Offset = "0xE200B8", VA = "0xE200B8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0xE20168", Offset = "0xE20168", VA = "0xE20168")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event Action<InkCanvas, Brush> OnPaintStart
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0xE20218", Offset = "0xE20218", VA = "0xE20218")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0xE202C8", Offset = "0xE202C8", VA = "0xE202C8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event Action<InkCanvas> OnPaintEnd
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0xE20378", Offset = "0xE20378", VA = "0xE20378")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600014F")]
			[Address(RVA = "0xE20428", Offset = "0xE20428", VA = "0xE20428")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xE20554", Offset = "0xE20554", VA = "0xE20554")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xE20558", Offset = "0xE20558", VA = "0xE20558")]
		private void Start()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xE2055C", Offset = "0xE2055C", VA = "0xE2055C")]
		public void Init(string path, string id)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xE215D8", Offset = "0xE215D8", VA = "0xE215D8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xE21C60", Offset = "0xE21C60", VA = "0xE21C60")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xE21140", Offset = "0xE21140", VA = "0xE21140")]
		private void MeshDataCache()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xE20608", Offset = "0xE20608", VA = "0xE20608")]
		private void InitPropertyID()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xE20970", Offset = "0xE20970", VA = "0xE20970")]
		private void SetMaterial()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xE220DC", Offset = "0xE220DC", VA = "0xE220DC")]
		private Texture2D LoadTextureByResources(string path)
		{
			return null;
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xE22124", Offset = "0xE22124", VA = "0xE22124")]
		public Texture2D LoadTextureFromPNG(string fileName)
		{
			return null;
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xE2277C", Offset = "0xE2277C", VA = "0xE2277C")]
		private void InitComputeShaderComputeAndClean()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xE22844", Offset = "0xE22844", VA = "0xE22844")]
		private Texture2D LoadTextureByIO(string path)
		{
			return null;
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xE20C64", Offset = "0xE20C64", VA = "0xE20C64")]
		private void SetTexture(string path, string id)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xE22AF0", Offset = "0xE22AF0", VA = "0xE22AF0")]
		private void SetTexture()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xE230F4", Offset = "0xE230F4", VA = "0xE230F4")]
		public void ReplaceTexture(int id)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xE231D4", Offset = "0xE231D4", VA = "0xE231D4")]
		private RenderTexture SetupRenderTexture(Texture baseTex, int propertyID, Material material)
		{
			return null;
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xE212CC", Offset = "0xE212CC", VA = "0xE212CC")]
		private void SetRenderTexture()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xE21C64", Offset = "0xE21C64", VA = "0xE21C64")]
		private void ReleaseRenderTexture()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xE232F8", Offset = "0xE232F8", VA = "0xE232F8")]
		private void SetPaintMainData(Brush brush)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xE235E8", Offset = "0xE235E8", VA = "0xE235E8")]
		private void SetPaintMainData(Brush brush, Vector2 uv)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xE238B8", Offset = "0xE238B8", VA = "0xE238B8")]
		private void SetPaintNormalData(Brush brush, Vector2 uv, bool erase)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xE23BC4", Offset = "0xE23BC4", VA = "0xE23BC4")]
		private void SetPaintHeightData(Brush brush, Vector2 uv)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xE23EC4", Offset = "0xE23EC4", VA = "0xE23EC4")]
		private Brush GetEraser(Brush brush, PaintSet paintSet, Vector2 uv, bool useMainPaint, bool useNormalPaint, bool useHeightpaint)
		{
			return null;
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xE2455C", Offset = "0xE2455C", VA = "0xE2455C")]
		private void ReleaseEraser(Brush brush, bool useMainPaint, bool useNormalPaint, bool useHeightpaint)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xE215F0", Offset = "0xE215F0", VA = "0xE215F0")]
		public bool Vanish(Brush brush, [Optional] Func<PaintSet, bool> materialSelector)
		{
			return default(bool);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xE24698", Offset = "0xE24698", VA = "0xE24698")]
		public bool PaintUVDirect(Brush brush, Vector2 uv, [Optional] Func<PaintSet, bool> materialSelector)
		{
			return default(bool);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xE25048", Offset = "0xE25048", VA = "0xE25048")]
		public bool PaintNearestTriangleSurface(Brush brush, Vector3 worldPos, [Optional] Func<PaintSet, bool> materialSelector, [Optional] Camera renderCamera)
		{
			return default(bool);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xE25418", Offset = "0xE25418", VA = "0xE25418")]
		public bool Paint(Brush brush, Vector3 worldPos, [Optional] Func<PaintSet, bool> materialSelector, [Optional] Camera renderCamera)
		{
			return default(bool);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xE25974", Offset = "0xE25974", VA = "0xE25974")]
		public bool Paint(Brush brush, RaycastHit hitInfo, [Optional] Func<PaintSet, bool> materialSelector)
		{
			return default(bool);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xE25AFC", Offset = "0xE25AFC", VA = "0xE25AFC")]
		public bool EraseUVDirect(Brush brush, Vector2 uv, [Optional] Func<PaintSet, bool> materialSelector)
		{
			return default(bool);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xE25B08", Offset = "0xE25B08", VA = "0xE25B08")]
		public bool EraseNearestTriangleSurface(Brush brush, Vector3 worldPos, [Optional] Func<PaintSet, bool> materialSelector, [Optional] Camera renderCamera)
		{
			return default(bool);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xE25B14", Offset = "0xE25B14", VA = "0xE25B14")]
		public bool Erase(Brush brush, Vector3 worldPos, [Optional] Func<PaintSet, bool> materialSelector, [Optional] Camera renderCamera)
		{
			return default(bool);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xE25B20", Offset = "0xE25B20", VA = "0xE25B20")]
		public bool Erase(Brush brush, RaycastHit hitInfo, [Optional] Func<PaintSet, bool> materialSelector)
		{
			return default(bool);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xE25B58", Offset = "0xE25B58", VA = "0xE25B58")]
		public void ResetPaint()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xE25B94", Offset = "0xE25B94", VA = "0xE25B94")]
		public Texture GetMainTexture(string materialName)
		{
			return null;
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xE25CC4", Offset = "0xE25CC4", VA = "0xE25CC4")]
		public RenderTexture GetPaintMainTexture(string materialName)
		{
			return null;
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xE25DF4", Offset = "0xE25DF4", VA = "0xE25DF4")]
		public void SetPaintMainTexture(string materialName, RenderTexture newTexture)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xE25F9C", Offset = "0xE25F9C", VA = "0xE25F9C")]
		public Texture GetNormalTexture(string materialName)
		{
			return null;
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xE260CC", Offset = "0xE260CC", VA = "0xE260CC")]
		public RenderTexture GetPaintNormalTexture(string materialName)
		{
			return null;
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xE261FC", Offset = "0xE261FC", VA = "0xE261FC")]
		public void SetPaintNormalTexture(string materialName, RenderTexture newTexture)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xE263A4", Offset = "0xE263A4", VA = "0xE263A4")]
		public Texture GetHeightTexture(string materialName)
		{
			return null;
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xE264D4", Offset = "0xE264D4", VA = "0xE264D4")]
		public RenderTexture GetPaintHeightTexture(string materialName)
		{
			return null;
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xE26604", Offset = "0xE26604", VA = "0xE26604")]
		public void SetPaintHeightTexture(string materialName, RenderTexture newTexture)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xE267AC", Offset = "0xE267AC", VA = "0xE267AC")]
		public InkCanvas()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public static class Math
	{
		[Token(Token = "0x400010C")]
		private const float TOLERANCE = 0.01f;

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xE26EB0", Offset = "0xE26EB0", VA = "0xE26EB0")]
		public static bool ExistPointInPlane(Vector3 p, Vector3 t1, Vector3 t2, Vector3 t3)
		{
			return default(bool);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xE270D4", Offset = "0xE270D4", VA = "0xE270D4")]
		public static bool ExistPointOnEdge(Vector3 p, Vector3 v1, Vector3 v2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xE272C4", Offset = "0xE272C4", VA = "0xE272C4")]
		public static bool ExistPointOnTriangleEdge(Vector3 p, Vector3 t1, Vector3 t2, Vector3 t3)
		{
			return default(bool);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xE273B4", Offset = "0xE273B4", VA = "0xE273B4")]
		public static bool ExistPointInTriangle(Vector3 p, Vector3 t1, Vector3 t2, Vector3 t3)
		{
			return default(bool);
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xE27798", Offset = "0xE27798", VA = "0xE27798")]
		public static Vector2 TextureCoordinateCalculation(Vector3 p, Vector3 t1, Vector2 t1UV, Vector3 t2, Vector2 t2UV, Vector3 t3, Vector2 t3UV, Matrix4x4 transformMatrix)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xE279F0", Offset = "0xE279F0", VA = "0xE279F0")]
		public static Vector3[] GetNearestVerticesTriangle(Vector3 p, Vector3[] vertices, int[] triangles)
		{
			return null;
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xE27E44", Offset = "0xE27E44", VA = "0xE27E44")]
		public static Vector3 TriangleSpaceProjection(Vector3 p, Vector3 t1, Vector3 t2, Vector3 t3)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000035")]
	public class MeshOperator
	{
		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Mesh mesh;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int[] meshTriangles;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3[] meshVertices;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector2[] meshUV;

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xE21FC8", Offset = "0xE21FC8", VA = "0xE21FC8")]
		public MeshOperator(Mesh mesh)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xE256E8", Offset = "0xE256E8", VA = "0xE256E8")]
		public bool LocalPointToUV(Vector3 localPoint, Matrix4x4 matrixMVP, out Vector2 uv)
		{
			return default(bool);
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xE25188", Offset = "0xE25188", VA = "0xE25188")]
		public Vector3 NearestLocalSurfacePoint(Vector3 localPoint)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000037")]
	public static class GameObjectExtension
	{
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xE28268", Offset = "0xE28268", VA = "0xE28268")]
		public static InkCanvas AddInkCanvas(this GameObject gameObject, List<InkCanvas.PaintSet> paintDatas)
		{
			return null;
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xE2845C", Offset = "0xE2845C", VA = "0xE2845C")]
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
			[Token(Token = "0x4000121")]
			Clamp,
			[Token(Token = "0x4000122")]
			Repeat,
			[Token(Token = "0x4000123")]
			Clip
		}

		[Token(Token = "0x4000114")]
		private const string GRAB_AREA_MATERIAL = "Es.InkPainter.Effective.GrabArea";

		[Token(Token = "0x4000115")]
		private const string CLIP = "_ClipTex";

		[Token(Token = "0x4000116")]
		private const string TARGET = "_TargetTex";

		[Token(Token = "0x4000117")]
		private const string CLIP_SCALE = "_ClipScale";

		[Token(Token = "0x4000118")]
		private const string CLIP_UV = "_ClipUV";

		[Token(Token = "0x4000119")]
		private const string ROTATE = "_Rotate";

		[Token(Token = "0x400011A")]
		private const string WM_CLAMP = "WRAP_MODE_CLAMP";

		[Token(Token = "0x400011B")]
		private const string WM_REPEAT = "WRAP_MODE_REPEAT";

		[Token(Token = "0x400011C")]
		private const string WM_CLIP = "WRAP_MODE_CLIP";

		[Token(Token = "0x400011D")]
		private const string ALPHA_REPLACE = "ALPHA_REPLACE";

		[Token(Token = "0x400011E")]
		private const string ALPHA_NOT_REPLACE = "ALPHA_NOT_REPLACE";

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material grabAreaMaterial;

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xE243C4", Offset = "0xE243C4", VA = "0xE243C4")]
		public static void Clip(Texture clipTexture, float clipScale, Texture grabTargetTexture, Vector2 targetUV, float rotateAngle, GrabTextureWrapMode wrapMode, RenderTexture dst, bool replaceAlpha = true)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xE285C4", Offset = "0xE285C4", VA = "0xE285C4")]
		private static void InitGrabAreaMaterial()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xE28684", Offset = "0xE28684", VA = "0xE28684")]
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
			[Token(Token = "0x400013E")]
			Add,
			[Token(Token = "0x400013F")]
			Overwrite
		}

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool useMainTextureFluid;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool useNormalMapFluid;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int createTextureSize;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ColorSynthesis colorSynthesis;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Range(0f, 1f)]
		private float alpha;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector2 flowDirection;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Range(0f, 1f)]
		private float flowingForce;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0.1f, 10f)]
		[SerializeField]
		private float easeOfDripping;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(1f, 0f)]
		[SerializeField]
		private float influenceOfNormal;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Range(0.01f, 1f)]
		private float horizontalSpread;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float normalScaleFactor;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		[Range(0.001f, 0.999f)]
		private float AdhesionBorder;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool performanceOptimize;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[Range(0.01f, 10f)]
		private float fluidProcessStopTime;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool enabledFluid;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float lastPaintedTime;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material heightFluid;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material height2Normal;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material height2Color;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material singleColorFill;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material invertAlpha;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private InkCanvas canvas;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Color lastPaintedColor;

		[Token(Token = "0x400013B")]
		private const string COLOR_SYNTHESIS_ADD = "COLOR_SYNTHESIS_ADD";

		[Token(Token = "0x400013C")]
		private const string COLOR_SYNTHESIS_OVERWRITE = "COLOR_SYNTHESIS_OVERWRITE";

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xE28960", Offset = "0xE28960", VA = "0xE28960")]
		private void Init(InkCanvas canvas)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xE28BE4", Offset = "0xE28BE4", VA = "0xE28BE4")]
		private void SingleColorFill(RenderTexture texture, Color color)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xE28D18", Offset = "0xE28D18", VA = "0xE28D18")]
		private void InvertAlpha(RenderTexture texture)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xE28DF4", Offset = "0xE28DF4", VA = "0xE28DF4")]
		private void EnabledFluid(InkCanvas canvas, Brush brush)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xE28E40", Offset = "0xE28E40", VA = "0xE28E40")]
		private void StopFluid()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xE29018", Offset = "0xE29018", VA = "0xE29018")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xE292C0", Offset = "0xE292C0", VA = "0xE292C0")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xE2A074", Offset = "0xE2A074", VA = "0xE2A074")]
		public HeightFluid()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public static class ReverseUV
	{
		[Token(Token = "0x4000140")]
		private const string REVERSE_UV_MATERIAL = "Es.InkPainter.Effective.ReverseUV";

		[Token(Token = "0x4000141")]
		private const string REVERSE_X = "_ReverseX";

		[Token(Token = "0x4000142")]
		private const string REVERSE_Y = "_ReverseY";

		[Token(Token = "0x4000143")]
		private const float DEFAULT = 1f;

		[Token(Token = "0x4000144")]
		private const float REVERSE = 0f;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material reverseUVMaterial;

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xE2A184", Offset = "0xE2A184", VA = "0xE2A184")]
		public static void Horizontal(Texture src, RenderTexture dst)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xE2A490", Offset = "0xE2A490", VA = "0xE2A490")]
		public static void Vertical(Texture src, RenderTexture dst)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xE2A538", Offset = "0xE2A538", VA = "0xE2A538")]
		public static void HorizontalAndVertical(Texture src, RenderTexture dst)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xE2A22C", Offset = "0xE2A22C", VA = "0xE2A22C")]
		private static void InitReverseUVMaterial()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xE2A2EC", Offset = "0xE2A2EC", VA = "0xE2A2EC")]
		private static void SetReverseUVProperty(float x, float y)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xE2A3A0", Offset = "0xE2A3A0", VA = "0xE2A3A0")]
		private static void Blit(Texture src, RenderTexture dst)
		{
		}
	}
	[Token(Token = "0x200003E")]
	public static class TextureMorphing
	{
		[Token(Token = "0x4000146")]
		private const string TEXTURE_MORPHING_MATERIAL = "Es.InkPainter.Effective.TextureMorphing";

		[Token(Token = "0x4000147")]
		private const string LERP_COEFFICIENT = "_LerpCoef";

		[Token(Token = "0x4000148")]
		private const string SRC_TEX = "_SrcTex";

		[Token(Token = "0x4000149")]
		private const string DST_TEX = "_DstTex";

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material morphingMaterial;

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xE2A5E0", Offset = "0xE2A5E0", VA = "0xE2A5E0")]
		public static void Lerp(Texture src, RenderTexture dst, float lerpCoef)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xE2A730", Offset = "0xE2A730", VA = "0xE2A730")]
		private static void InitMorphingMaterial()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xE2A7F0", Offset = "0xE2A7F0", VA = "0xE2A7F0")]
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
		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool grab;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Brush brush;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GrabArea.GrabTextureWrapMode wrapMode;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RenderTexture t;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RaycastHit hitInfo;

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xE2A914", Offset = "0xE2A914", VA = "0xE2A914")]
		public void Awake()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xE2A9CC", Offset = "0xE2A9CC", VA = "0xE2A9CC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xE2ABF4", Offset = "0xE2ABF4", VA = "0xE2ABF4")]
		public ClipPainter()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[RequireComponent(typeof(Collider), typeof(MeshRenderer))]
	public class CollisionPainter : MonoBehaviour
	{
		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Brush brush;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int wait;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int waitCount;

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xE2AC08", Offset = "0xE2AC08", VA = "0xE2AC08")]
		public void Awake()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xE2AC7C", Offset = "0xE2AC7C", VA = "0xE2AC7C")]
		public void FixedUpdate()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xE2AC8C", Offset = "0xE2AC8C", VA = "0xE2AC8C")]
		public void OnCollisionStay(Collision collision)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xE2ADF0", Offset = "0xE2ADF0", VA = "0xE2ADF0")]
		public CollisionPainter()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[RequireComponent(typeof(Collider))]
	public class CollisionReflectionPainter : MonoBehaviour
	{
		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Brush brush;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Camera cam;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 offset;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool debugMode;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RenderTexture rt;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RenderTexture debug;

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xE2AE00", Offset = "0xE2AE00", VA = "0xE2AE00")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xE2AEFC", Offset = "0xE2AEFC", VA = "0xE2AEFC")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xE2AF08", Offset = "0xE2AF08", VA = "0xE2AF08")]
		public void OnCollisionStay(Collision collision)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xE2B34C", Offset = "0xE2B34C", VA = "0xE2B34C")]
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
			[Token(Token = "0x400016B")]
			RaycastHitInfo,
			[Token(Token = "0x400016C")]
			WorldPoint,
			[Token(Token = "0x400016D")]
			NearestSurfacePoint,
			[Token(Token = "0x400016E")]
			DirectUV
		}

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Brush brush;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UseMethodType useMethodType;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool erase;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform InitialPoint;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InputActionReference m_ActiveReference;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InputActionReference m_PrimaryButtonReference;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_ShootMode;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool m_ShootingMode;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private ParticleSystem.Particle particle;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private ParticleSystem m_WaterParticleSystem;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ParticleSystem m_SprayParticleSystem;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float m_ParticleStartSize;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float HitDistance;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float MaximumRange;

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xE2B4E8", Offset = "0xE2B4E8", VA = "0xE2B4E8")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xE2B9C4", Offset = "0xE2B9C4", VA = "0xE2B9C4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xE2B9D0", Offset = "0xE2B9D0", VA = "0xE2B9D0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xE2BA90", Offset = "0xE2BA90", VA = "0xE2BA90")]
		private void Update()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xE2BFE0", Offset = "0xE2BFE0", VA = "0xE2BFE0")]
		private void ActionStarted(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xE2C05C", Offset = "0xE2C05C", VA = "0xE2C05C")]
		private void CanceledStarted(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xE2C160", Offset = "0xE2C160", VA = "0xE2C160")]
		private void Shooting(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xE2BAA8", Offset = "0xE2BAA8", VA = "0xE2BAA8")]
		private void Shoot()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xE2C1E8", Offset = "0xE2C1E8", VA = "0xE2C1E8")]
		public void OnGUI()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xE2C310", Offset = "0xE2C310", VA = "0xE2C310")]
		public MousePainter()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class ReflectPainter : MonoBehaviour
	{
		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Brush brush;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject camPref;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RenderTexture rt;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Camera cam;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector2 uv;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private InkCanvas paintObject;

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xE2C320", Offset = "0xE2C320", VA = "0xE2C320")]
		public void Awake()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xE2C3C4", Offset = "0xE2C3C4", VA = "0xE2C3C4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xE2C7A8", Offset = "0xE2C7A8", VA = "0xE2C7A8")]
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
			[Token(Token = "0x4000180")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000181")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000182")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TextureRecovery <>4__this;

			[Token(Token = "0x4000183")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x1700004C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001DD")]
				[Address(RVA = "0xE2CE34", Offset = "0xE2CE34", VA = "0xE2CE34", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001DF")]
				[Address(RVA = "0xE2CE7C", Offset = "0xE2CE7C", VA = "0xE2CE7C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001DA")]
			[Address(RVA = "0xE2CBAC", Offset = "0xE2CBAC", VA = "0xE2CBAC")]
			[DebuggerHidden]
			public <TextureLerp>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60001DB")]
			[Address(RVA = "0xE2CBEC", Offset = "0xE2CBEC", VA = "0xE2CBEC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001DC")]
			[Address(RVA = "0xE2CBF0", Offset = "0xE2CBF0", VA = "0xE2CBF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001DE")]
			[Address(RVA = "0xE2CE3C", Offset = "0xE2CE3C", VA = "0xE2CE3C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float lerpCoefficient;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float callTimer;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool @fixed;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material material;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private InkCanvas canvas;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Texture defaultMainTexture;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RenderTexture paintMainTexture;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Texture defaultNormalMap;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RenderTexture paintNormalMap;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Texture defaultHeightMap;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RenderTexture paintHeightMap;

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xE2C7B0", Offset = "0xE2C7B0", VA = "0xE2C7B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xE2C868", Offset = "0xE2C868", VA = "0xE2C868")]
		private void Init(InkCanvas canvas)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xE2CA3C", Offset = "0xE2CA3C", VA = "0xE2CA3C")]
		public void FixedUpdate()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xE2C9D4", Offset = "0xE2C9D4", VA = "0xE2C9D4")]
		[IteratorStateMachine(typeof(<TextureLerp>d__14))]
		private IEnumerator TextureLerp()
		{
			return null;
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xE2CBD4", Offset = "0xE2CBD4", VA = "0xE2CBD4")]
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
			[Token(Token = "0x400018E")]
			None,
			[Token(Token = "0x400018F")]
			Logging,
			[Token(Token = "0x4000190")]
			Dumping
		}

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool openLogFolder;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static PerformanceLogger currentLogger;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Dictionary<float, float> frameTimes;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly List<string> loggedCustomEvents;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly List<float> loggedCustomEventsTimestamps;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float startTime;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Action completionCallback;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string systemSpecs;

		[Token(Token = "0x1700004E")]
		public static bool IsLogging
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0xE2CE84", Offset = "0xE2CE84", VA = "0xE2CE84")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004F")]
		public static LoggerState CurrentState
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0xE2CF10", Offset = "0xE2CF10", VA = "0xE2CF10")]
			[CompilerGenerated]
			get
			{
				return default(LoggerState);
			}
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0xE2CF68", Offset = "0xE2CF68", VA = "0xE2CF68")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xE2CFC4", Offset = "0xE2CFC4", VA = "0xE2CFC4")]
		public static void StartLogger()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xE2D168", Offset = "0xE2D168", VA = "0xE2D168")]
		public static void LogCustomEvent(string eventData)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xE2D36C", Offset = "0xE2D36C", VA = "0xE2D36C")]
		public static void EndLogger(string path, string extraInfo = "", bool async = true, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xE2EBB8", Offset = "0xE2EBB8", VA = "0xE2EBB8")]
		private static void ShowLogFolder(string path)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xE2EC18", Offset = "0xE2EC18", VA = "0xE2EC18")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xE2EC34", Offset = "0xE2EC34", VA = "0xE2EC34")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xE2EE10", Offset = "0xE2EE10", VA = "0xE2EE10")]
		private void LogFrameTime()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xE2EE98", Offset = "0xE2EE98", VA = "0xE2EE98")]
		private string AnalyseFramesUnderFPS(float FPSCutoff)
		{
			return null;
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xE2DDF0", Offset = "0xE2DDF0", VA = "0xE2DDF0")]
		private void DumpLog(string path, string extraInfo = "")
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xE2D788", Offset = "0xE2D788", VA = "0xE2D788")]
		private string GetSystemSpecs()
		{
			return null;
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xE2F420", Offset = "0xE2F420", VA = "0xE2F420")]
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
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xE2F2B0", Offset = "0xE2F2B0", VA = "0xE2F2B0")]
		public static float RoundToSigFigs(this float num, int n)
		{
			return default(float);
		}
	}
}
