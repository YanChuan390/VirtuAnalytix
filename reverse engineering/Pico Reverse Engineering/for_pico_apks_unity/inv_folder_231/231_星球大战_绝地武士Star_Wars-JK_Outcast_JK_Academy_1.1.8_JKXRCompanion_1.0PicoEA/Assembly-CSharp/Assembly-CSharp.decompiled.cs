using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using CurvedUI;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class CUI_MoveAlong : MonoBehaviour
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x77A548", Offset = "0x77A548", VA = "0x77A548")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x77A54C", Offset = "0x77A54C", VA = "0x77A54C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x77A774", Offset = "0x77A774", VA = "0x77A774")]
	public CUI_MoveAlong()
	{
	}
}
[Token(Token = "0x2000003")]
public class CUI_MoveHeartbeat : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool wrapAroundParent;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform rectie;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform parentRectie;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x77A77C", Offset = "0x77A77C", VA = "0x77A77C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x77A830", Offset = "0x77A830", VA = "0x77A830")]
	private void Update()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x77A954", Offset = "0x77A954", VA = "0x77A954")]
	public CUI_MoveHeartbeat()
	{
	}
}
[Token(Token = "0x2000004")]
public class CUI_ShowParentCoordinates : MonoBehaviour
{
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x77B504", Offset = "0x77B504", VA = "0x77B504")]
	private void Start()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x77B5D8", Offset = "0x77B5D8", VA = "0x77B5D8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x77B5DC", Offset = "0x77B5DC", VA = "0x77B5DC")]
	public CUI_ShowParentCoordinates()
	{
	}
}
[Token(Token = "0x2000005")]
public class CUI_rotation_anim : MonoBehaviour
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 Rotation;

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x77C398", Offset = "0x77C398", VA = "0x77C398")]
	private void Start()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x77C39C", Offset = "0x77C39C", VA = "0x77C39C")]
	private void Update()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x77C584", Offset = "0x77C584", VA = "0x77C584")]
	public CUI_rotation_anim()
	{
	}
}
[Token(Token = "0x2000006")]
public class CUI_touchpad : MonoBehaviour
{
	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform container;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform dot;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x77C58C", Offset = "0x77C58C", VA = "0x77C58C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x77C5FC", Offset = "0x77C5FC", VA = "0x77C5FC")]
	private void MoveDotOnTouchpadAxisChanged(object o, ViveInputArgs args)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x77C6BC", Offset = "0x77C6BC", VA = "0x77C6BC")]
	public CUI_touchpad()
	{
	}
}
[Token(Token = "0x2000007")]
[ExecuteInEditMode]
public class CurvedUIInputModule : BaseInputModule
{
	[Token(Token = "0x2000008")]
	public enum CUIControlMethod
	{
		[Token(Token = "0x4000027")]
		MOUSE = 0,
		[Token(Token = "0x4000028")]
		GAZE = 1,
		[Token(Token = "0x4000029")]
		WORLD_MOUSE = 2,
		[Token(Token = "0x400002A")]
		CUSTOM_RAY = 3,
		[Token(Token = "0x400002B")]
		STEAMVR_LEGACY = 4,
		[Token(Token = "0x400002C")]
		OCULUSVR = 5,
		[Token(Token = "0x400002D")]
		STEAMVR_2 = 8,
		[Token(Token = "0x400002E")]
		UNITY_XR = 9
	}

	[Token(Token = "0x2000009")]
	public enum Hand
	{
		[Token(Token = "0x4000030")]
		Both,
		[Token(Token = "0x4000031")]
		Right,
		[Token(Token = "0x4000032")]
		Left
	}

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private CUIControlMethod controlMethod;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private string submitButtonName;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Camera mainEventCamera;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private LayerMask raycastLayerMask;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	private bool gazeUseTimedClick;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float gazeClickTimer;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private float gazeClickTimerDelay;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Image gazeTimedClickProgressImage;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private float worldSpaceMouseSensitivity;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[SerializeField]
	private Hand usedHand;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Transform pointerTransformOverride;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool disableOtherInputModulesOnStart;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static CurvedUIInputModule instance;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private GameObject currentDragging;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private GameObject currentPointedAt;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private GameObject m_rightController;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private GameObject m_leftController;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float gazeTimerProgress;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private Ray customControllerRay;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private float dragThreshold;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private bool pressedDown;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
	private bool pressedLastFrame;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private Vector2 lastEventDataPosition;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private PointerInputModule.MouseButtonEventData storedData;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Vector3 lastMouseOnScreenPos;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private Vector2 worldSpaceMouseInCanvasSpace;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private Vector2 lastWorldSpaceMouseOnCanvas;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private Vector2 worldSpaceMouseOnCanvasDelta;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[SerializeField]
	private XRBaseController rightXRController;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[SerializeField]
	private XRBaseController leftXRController;

	[Token(Token = "0x17000001")]
	public static CurvedUIInputModule Instance
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x77B80C", Offset = "0x77B80C", VA = "0x77B80C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x780CCC", Offset = "0x780CCC", VA = "0x780CCC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public static bool CanInstanceBeAccessed
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x780D34", Offset = "0x780D34", VA = "0x780D34")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000003")]
	public static CUIControlMethod ControlMethod
	{
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x779AAC", Offset = "0x779AAC", VA = "0x779AAC")]
		get
		{
			return default(CUIControlMethod);
		}
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x780DD0", Offset = "0x780DD0", VA = "0x780DD0")]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public LayerMask RaycastLayerMask
	{
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x780E68", Offset = "0x780E68", VA = "0x780E68")]
		get
		{
			return default(LayerMask);
		}
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x780E70", Offset = "0x780E70", VA = "0x780E70")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public Hand UsedHand
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x780E78", Offset = "0x780E78", VA = "0x780E78")]
		get
		{
			return default(Hand);
		}
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x780E80", Offset = "0x780E80", VA = "0x780E80")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public Transform ControllerTransform
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x77E1CC", Offset = "0x77E1CC", VA = "0x77E1CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000007")]
	public Vector3 ControllerPointingDirection
	{
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x77E2EC", Offset = "0x77E2EC", VA = "0x77E2EC")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000008")]
	public Vector3 ControllerPointingOrigin
	{
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x780EF8", Offset = "0x780EF8", VA = "0x780EF8")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000009")]
	public Transform PointerTransformOverride
	{
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x780E88", Offset = "0x780E88", VA = "0x780E88")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x77E278", Offset = "0x77E278", VA = "0x77E278")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public GameObject CurrentPointedAt
	{
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x780F18", Offset = "0x780F18", VA = "0x780F18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000B")]
	public Camera EventCamera
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x780F20", Offset = "0x780F20", VA = "0x780F20")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x77EF1C", Offset = "0x77EF1C", VA = "0x77EF1C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public static Vector2 MousePosition
	{
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x778EF8", Offset = "0x778EF8", VA = "0x778EF8")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x1700000D")]
	public static bool LeftMouseButton
	{
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x77A454", Offset = "0x77A454", VA = "0x77A454")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000E")]
	public static Ray CustomControllerRay
	{
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x7811A4", Offset = "0x7811A4", VA = "0x7811A4")]
		get
		{
			return default(Ray);
		}
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x77A160", Offset = "0x77A160", VA = "0x77A160")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public static bool CustomControllerButtonState
	{
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x78121C", Offset = "0x78121C", VA = "0x78121C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x77A4C4", Offset = "0x77A4C4", VA = "0x77A4C4")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x50610C", Offset = "0x50610C")]
	public static bool CustomControllerButtonDown
	{
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x781284", Offset = "0x781284", VA = "0x781284")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x7812DC", Offset = "0x7812DC", VA = "0x7812DC")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public Vector2 WorldSpaceMouseInCanvasSpace
	{
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x78133C", Offset = "0x78133C", VA = "0x78133C")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x77B91C", Offset = "0x77B91C", VA = "0x77B91C")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public Vector2 WorldSpaceMouseInCanvasSpaceDelta
	{
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x781344", Offset = "0x781344", VA = "0x781344")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17000013")]
	public float WorldSpaceMouseSensitivity
	{
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x781358", Offset = "0x781358", VA = "0x781358")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x781360", Offset = "0x781360", VA = "0x781360")]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public bool GazeUseTimedClick
	{
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x781368", Offset = "0x781368", VA = "0x781368")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x781370", Offset = "0x781370", VA = "0x781370")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public float GazeClickTimer
	{
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x78137C", Offset = "0x78137C", VA = "0x78137C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x781384", Offset = "0x781384", VA = "0x781384")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public float GazeClickTimerDelay
	{
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x7813B0", Offset = "0x7813B0", VA = "0x7813B0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x7813B8", Offset = "0x7813B8", VA = "0x7813B8")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public float GazeTimerProgress
	{
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x7813E4", Offset = "0x7813E4", VA = "0x7813E4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000018")]
	public Image GazeTimedClickProgressImage
	{
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x7813EC", Offset = "0x7813EC", VA = "0x7813EC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x7813F4", Offset = "0x7813F4", VA = "0x7813F4")]
		set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public XRBaseController RightXRController
	{
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x7813FC", Offset = "0x7813FC", VA = "0x7813FC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x781404", Offset = "0x781404", VA = "0x781404")]
		set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public XRBaseController LeftXRController
	{
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x78140C", Offset = "0x78140C", VA = "0x78140C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x781414", Offset = "0x781414", VA = "0x781414")]
		set
		{
		}
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x77ED7C", Offset = "0x77ED7C", VA = "0x77ED7C", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x77F18C", Offset = "0x77F18C", VA = "0x77F18C", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x77F1C8", Offset = "0x77F1C8", VA = "0x77F1C8", Slot = "26")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x77EFC8", Offset = "0x77EFC8", VA = "0x77EFC8")]
	private void SetupUnityXrControllers()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x77F400", Offset = "0x77F400", VA = "0x77F400", Slot = "17")]
	public override void Process()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x77F584", Offset = "0x77F584", VA = "0x77F584")]
	protected PointerInputModule.MouseButtonEventData GetEventData()
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x77F7F8", Offset = "0x77F7F8", VA = "0x77F7F8")]
	private void ProcessMove(PointerEventData eventData, GameObject currentRaycastTarget)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x77FE18", Offset = "0x77FE18", VA = "0x77FE18")]
	private void ProcessButton(PointerInputModule.MouseButtonEventData button, PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x780510", Offset = "0x780510", VA = "0x780510")]
	private void ProcessDrag(PointerInputModule.MouseButtonEventData button, PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x780810", Offset = "0x780810", VA = "0x780810")]
	private static void ProcessScroll(PointerInputModule.MouseButtonEventData button, PointerEventData eventData)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x78093C", Offset = "0x78093C", VA = "0x78093C")]
	private void ProcessUnityXrController()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x780AA8", Offset = "0x780AA8", VA = "0x780AA8", Slot = "27")]
	protected virtual void ProcessMouseController()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x780BFC", Offset = "0x780BFC", VA = "0x780BFC", Slot = "28")]
	protected virtual void ProcessCustomRayController()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x780C00", Offset = "0x780C00", VA = "0x780C00", Slot = "29")]
	protected virtual void ProcessGaze()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x77DFFC", Offset = "0x77DFFC", VA = "0x77DFFC")]
	public void GetXrControllerButtonState(ref bool pressed, Hand checkHand)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x780A7C", Offset = "0x780A7C", VA = "0x780A7C")]
	private PointerEventData.FramePressState CustomRayFramePressedState()
	{
		return default(PointerEventData.FramePressState);
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x780CC0", Offset = "0x780CC0", VA = "0x780CC0", Slot = "30")]
	protected virtual void ProcessViveControllers()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x780CC4", Offset = "0x780CC4", VA = "0x780CC4", Slot = "31")]
	protected virtual void ProcessOculusVRController()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x780CC8", Offset = "0x780CC8", VA = "0x780CC8")]
	private void ProcessSteamVR2Controllers()
	{
	}

	[Token(Token = "0x6000023")]
	private static T EnableInputModule<T>() where T : BaseInputModule
	{
		return null;
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x780F28", Offset = "0x780F28", VA = "0x780F28")]
	public Ray GetEventRay([Optional] Camera eventCam)
	{
		return default(Ray);
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x78141C", Offset = "0x78141C", VA = "0x78141C")]
	public CurvedUIInputModule()
	{
	}
}
[Token(Token = "0x200000A")]
public class GlobalObjects : MonoBehaviour
{
	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static GameObject goHoverButton;

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xE7F12C", Offset = "0xE7F12C", VA = "0xE7F12C")]
	public GlobalObjects()
	{
	}
}
[Token(Token = "0x200000B")]
public class JKQuestCompanion : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200000C")]
	public class CoreFile
	{
		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int intID;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int intJointDownload;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool blnSharesDownload;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string strTitle;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string strLogo;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string strInfo;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string strDownloadLocation;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string strDownloadAction;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string strDownloadFile;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string strTextFile;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string strFolderInstall;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string strCommandLine;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool blnMapPack;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool blnAddon;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		public bool blnFullGameNotRequired;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<string> lstRequired;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<string> lstIncompatible;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool blnLocalFileExists;

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xE96214", Offset = "0xE96214", VA = "0xE96214")]
		public CoreFile()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200000D")]
	public class ListCoreFiles
	{
		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<CoreFile> list;

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xE9623C", Offset = "0xE9623C", VA = "0xE9623C")]
		public ListCoreFiles()
		{
		}
	}

	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503D98", Offset = "0x503D98")]
	private sealed class <LoadTextLineByLine>d__91 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public JKQuestCompanion <>4__this;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public StreamReader file;

		[Token(Token = "0x1700001B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0xE94F9C", Offset = "0xE94F9C", VA = "0xE94F9C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0xE94FE4", Offset = "0xE94FE4", VA = "0xE94FE4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xE94E2C", Offset = "0xE94E2C", VA = "0xE94E2C")]
		[DebuggerHidden]
		public <LoadTextLineByLine>d__91(int <>1__state)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xE94E58", Offset = "0xE94E58", VA = "0xE94E58", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xE94E5C", Offset = "0xE94E5C", VA = "0xE94E5C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xE94FA4", Offset = "0xE94FA4", VA = "0xE94FA4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503DA8", Offset = "0x503DA8")]
	private sealed class <QuitApplicationAfterSound>d__98 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public JKQuestCompanion <>4__this;

		[Token(Token = "0x1700001D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0xE95BE0", Offset = "0xE95BE0", VA = "0xE95BE0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0xE95C28", Offset = "0xE95C28", VA = "0xE95C28", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xE95AB4", Offset = "0xE95AB4", VA = "0xE95AB4")]
		[DebuggerHidden]
		public <QuitApplicationAfterSound>d__98(int <>1__state)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xE95AE0", Offset = "0xE95AE0", VA = "0xE95AE0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xE95AE4", Offset = "0xE95AE4", VA = "0xE95AE4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xE95BE8", Offset = "0xE95BE8", VA = "0xE95BE8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503DB8", Offset = "0x503DB8")]
	private sealed class <PostInitialLoad>d__100 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public JKQuestCompanion <>4__this;

		[Token(Token = "0x1700001F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0xE95370", Offset = "0xE95370", VA = "0xE95370", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0xE953B8", Offset = "0xE953B8", VA = "0xE953B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xE95104", Offset = "0xE95104", VA = "0xE95104")]
		[DebuggerHidden]
		public <PostInitialLoad>d__100(int <>1__state)
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xE95130", Offset = "0xE95130", VA = "0xE95130", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xE95134", Offset = "0xE95134", VA = "0xE95134", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xE95378", Offset = "0xE95378", VA = "0xE95378", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000011")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503DC8", Offset = "0x503DC8")]
	private sealed class <NextFrameReload>d__102 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public JKQuestCompanion <>4__this;

		[Token(Token = "0x17000021")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0xE950B4", Offset = "0xE950B4", VA = "0xE950B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0xE950FC", Offset = "0xE950FC", VA = "0xE950FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xE94FEC", Offset = "0xE94FEC", VA = "0xE94FEC")]
		[DebuggerHidden]
		public <NextFrameReload>d__102(int <>1__state)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xE95018", Offset = "0xE95018", VA = "0xE95018", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xE9501C", Offset = "0xE9501C", VA = "0xE9501C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xE950BC", Offset = "0xE950BC", VA = "0xE950BC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000012")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503DD8", Offset = "0x503DD8")]
	private sealed class <PostReloadActions>d__104 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public JKQuestCompanion <>4__this;

		[Token(Token = "0x17000023")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0xE95498", Offset = "0xE95498", VA = "0xE95498", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0xE954E0", Offset = "0xE954E0", VA = "0xE954E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xE953C0", Offset = "0xE953C0", VA = "0xE953C0")]
		[DebuggerHidden]
		public <PostReloadActions>d__104(int <>1__state)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xE953EC", Offset = "0xE953EC", VA = "0xE953EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xE953F0", Offset = "0xE953F0", VA = "0xE953F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xE954A0", Offset = "0xE954A0", VA = "0xE954A0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000013")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503DE8", Offset = "0x503DE8")]
	private sealed class <>c__DisplayClass110_0
	{
		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xE94358", Offset = "0xE94358", VA = "0xE94358")]
		public <>c__DisplayClass110_0()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xE94360", Offset = "0xE94360", VA = "0xE94360")]
		internal bool <FindCoreGamebyID>b__0(CoreFile x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000014")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503DF8", Offset = "0x503DF8")]
	private sealed class <>c__DisplayClass116_0
	{
		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public JKQuestCompanion <>4__this;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CoreFile game;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject _button;

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xE94384", Offset = "0xE94384", VA = "0xE94384")]
		public <>c__DisplayClass116_0()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xE9438C", Offset = "0xE9438C", VA = "0xE9438C")]
		internal void <AddDownloadButton>b__0()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xE943B0", Offset = "0xE943B0", VA = "0xE943B0")]
		internal void <AddDownloadButton>b__1()
		{
		}
	}

	[Token(Token = "0x2000015")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503E08", Offset = "0x503E08")]
	private sealed class <>c__DisplayClass117_0
	{
		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public JKQuestCompanion <>4__this;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CoreFile game;

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xE943CC", Offset = "0xE943CC", VA = "0xE943CC")]
		public <>c__DisplayClass117_0()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xE943D4", Offset = "0xE943D4", VA = "0xE943D4")]
		internal void <ShowDownloadDetails>b__0()
		{
		}
	}

	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503E18", Offset = "0x503E18")]
	private sealed class <DownloadFile>d__120 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CoreFile linked_game;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public JKQuestCompanion <>4__this;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public CoreFile game;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UnityWebRequest <www>5__2;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IEnumerator <coroutine>5__3;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string <dir>5__4;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string <filename>5__5;

		[Token(Token = "0x17000025")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0xE94DDC", Offset = "0xE94DDC", VA = "0xE94DDC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0xE94E24", Offset = "0xE94E24", VA = "0xE94E24", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xE945A4", Offset = "0xE945A4", VA = "0xE945A4")]
		[DebuggerHidden]
		public <DownloadFile>d__120(int <>1__state)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xE945D0", Offset = "0xE945D0", VA = "0xE945D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xE945D4", Offset = "0xE945D4", VA = "0xE945D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xE94DE4", Offset = "0xE94DE4", VA = "0xE94DE4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503E28", Offset = "0x503E28")]
	private sealed class <progress>d__124 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public JKQuestCompanion <>4__this;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityWebRequest buffer;

		[Token(Token = "0x17000027")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0xE961C4", Offset = "0xE961C4", VA = "0xE961C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0xE9620C", Offset = "0xE9620C", VA = "0xE9620C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xE96044", Offset = "0xE96044", VA = "0xE96044")]
		[DebuggerHidden]
		public <progress>d__124(int <>1__state)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xE96070", Offset = "0xE96070", VA = "0xE96070", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xE96074", Offset = "0xE96074", VA = "0xE96074", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xE961CC", Offset = "0xE961CC", VA = "0xE961CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503E38", Offset = "0x503E38")]
	private sealed class <progress2>d__125 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public JKQuestCompanion <>4__this;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityWebRequest buffer;

		[Token(Token = "0x17000029")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0xE95FF4", Offset = "0xE95FF4", VA = "0xE95FF4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0xE9603C", Offset = "0xE9603C", VA = "0xE9603C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xE95E74", Offset = "0xE95E74", VA = "0xE95E74")]
		[DebuggerHidden]
		public <progress2>d__125(int <>1__state)
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xE95EA0", Offset = "0xE95EA0", VA = "0xE95EA0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xE95EA4", Offset = "0xE95EA4", VA = "0xE95EA4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xE95FFC", Offset = "0xE95FFC", VA = "0xE95FFC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503E48", Offset = "0x503E48")]
	private sealed class <>c__DisplayClass127_0
	{
		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public JKQuestCompanion <>4__this;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject _button;

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xE943F8", Offset = "0xE943F8", VA = "0xE943F8")]
		public <>c__DisplayClass127_0()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xE94400", Offset = "0xE94400", VA = "0xE94400")]
		internal void <AddJK2Button>b__0()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xE94460", Offset = "0xE94460", VA = "0xE94460")]
		internal void <AddJK2Button>b__1()
		{
		}
	}

	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503E58", Offset = "0x503E58")]
	private sealed class <>c__DisplayClass128_0
	{
		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public JKQuestCompanion <>4__this;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject _button;

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xE9447C", Offset = "0xE9447C", VA = "0xE9447C")]
		public <>c__DisplayClass128_0()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xE94484", Offset = "0xE94484", VA = "0xE94484")]
		internal void <AddJK3Button>b__0()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xE944E4", Offset = "0xE944E4", VA = "0xE944E4")]
		internal void <AddJK3Button>b__1()
		{
		}
	}

	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503E68", Offset = "0x503E68")]
	private sealed class <>c__DisplayClass129_0
	{
		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public JKQuestCompanion <>4__this;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject _button;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CoreFile corefile;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xE94500", Offset = "0xE94500", VA = "0xE94500")]
		public <>c__DisplayClass129_0()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xE94508", Offset = "0xE94508", VA = "0xE94508")]
		internal void <AddModButton>b__3()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xE94524", Offset = "0xE94524", VA = "0xE94524")]
		internal void <AddModButton>b__0()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xE94548", Offset = "0xE94548", VA = "0xE94548")]
		internal void <AddModButton>b__1()
		{
		}
	}

	[Token(Token = "0x200001C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503E78", Offset = "0x503E78")]
	private sealed class <>c__DisplayClass129_1
	{
		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string cmdLine;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool showFullGameWarning;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public <>c__DisplayClass129_0 CS$<>8__locals1;

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xE94564", Offset = "0xE94564", VA = "0xE94564")]
		public <>c__DisplayClass129_1()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xE9456C", Offset = "0xE9456C", VA = "0xE9456C")]
		internal void <AddModButton>b__2()
		{
		}
	}

	[Token(Token = "0x200001D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503E88", Offset = "0x503E88")]
	private sealed class <PreLoadMods>d__133 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public JKQuestCompanion <>4__this;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string[] <>7__wrap1;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <>7__wrap2;

		[Token(Token = "0x1700002B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0xE95A64", Offset = "0xE95A64", VA = "0xE95A64", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0xE95AAC", Offset = "0xE95AAC", VA = "0xE95AAC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xE954E8", Offset = "0xE954E8", VA = "0xE954E8")]
		[DebuggerHidden]
		public <PreLoadMods>d__133(int <>1__state)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xE95514", Offset = "0xE95514", VA = "0xE95514", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xE95518", Offset = "0xE95518", VA = "0xE95518", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xE95A6C", Offset = "0xE95A6C", VA = "0xE95A6C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503E98", Offset = "0x503E98")]
	private sealed class <UpdateLatestNews>d__136 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public JKQuestCompanion <>4__this;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <waitTime>5__3;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string[] <texts>5__4;

		[Token(Token = "0x1700002D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0xE95E24", Offset = "0xE95E24", VA = "0xE95E24", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0xE95E6C", Offset = "0xE95E6C", VA = "0xE95E6C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xE95C30", Offset = "0xE95C30", VA = "0xE95C30")]
		[DebuggerHidden]
		public <UpdateLatestNews>d__136(int <>1__state)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xE95C5C", Offset = "0xE95C5C", VA = "0xE95C5C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xE95C60", Offset = "0xE95C60", VA = "0xE95C60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xE95E2C", Offset = "0xE95E2C", VA = "0xE95E2C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ListCoreFiles lstCoreFiles;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x50425C", Offset = "0x50425C")]
	public bool publicVersion;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool fullGamePresentJK2;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	private bool coreGameMessageNeeded;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x504294", Offset = "0x504294")]
	public Canvas canvasMain;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Canvas canvasNoGame;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Canvas canvasKeyboard;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Canvas canvasMessage;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5042CC", Offset = "0x5042CC")]
	public AudioSource gun_sound_1;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AudioSource monster_sound;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public AudioSource fart_sound;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public AudioSource background_music;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public AudioClip[] music_tracks;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public AudioSource exit_sound;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool blnMute;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Toggle toggleMute;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x504304", Offset = "0x504304")]
	public GameObject MapPackScroll;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject AddonScroll;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject GameScroll;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x50433C", Offset = "0x50433C")]
	public TMP_Text txtCommandLine;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TMP_InputField txtManualEntry;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Color coreColor;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Color selectColor;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Toggle toggleRefresh;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Toggle toggleExpertMode;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Button btnLaunchGame;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public TMP_Text txtLatestNews;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x504374", Offset = "0x504374")]
	public TMP_Text txtMessage;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public TMP_Text txtTitle;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Button btnViewText;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public Button btnViewNotes;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Button btnDeleteMod;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private string backupText;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private int intDeleteGameID;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private string strDeleteFile;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private bool blnTextFileExists;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5043AC", Offset = "0x5043AC")]
	public Canvas canvasDownload;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public GameObject DownloadScroll;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public Button btnDownload;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public TMP_Text txtDownloadInfo;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public TMP_Text txtDownloadProgress;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public Button btnDownloadClose;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5043E4", Offset = "0x5043E4")]
	public GameObject buttonCoreGameButton;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private string strBaseDirectory;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private string strGameFilterDirectory;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private string strJK2Directory;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private string strJK3Directory;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private string strBasePlusGameDirectory;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private string strCoreGameDirectory;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private string strModDirectory;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private string strTempDirectory;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private string strSpriteDirectory;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private string[] coreGameExtensions;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private string[] modExtensions;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private string strOnlineNews;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private string[] jk2GameFiles;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private string[] jk3GameFiles;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private List<GameObject> buttonsMaps;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private List<GameObject> buttonsAddons;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private string strLog;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private string strPlayerName;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private bool blnSuppressCommandUpdate;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x201")]
	private bool isDownload;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x202")]
	private bool isDownload2;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private string strMessageTextFile;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private string strCommandLine;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private List<GameObject> buttonsCoreGame;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private bool boolGameLaunched;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x221")]
	private bool blnDeleteConfirm;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x222")]
	private bool blnInPreload;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x223")]
	private bool trigger_pressed;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private string strCompatGuidance;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private string strDisclaimer;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private string strCredits;

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xE7F474", Offset = "0xE7F474", VA = "0xE7F474")]
	private void Start()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xE7F944", Offset = "0xE7F944", VA = "0xE7F944")]
	private void Update()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xE7F838", Offset = "0xE7F838", VA = "0xE7F838")]
	public void RandomiseMusic(int previous = -1)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xE7F994", Offset = "0xE7F994", VA = "0xE7F994")]
	public void PlayButtonSound()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xE7F8BC", Offset = "0xE7F8BC", VA = "0xE7F8BC")]
	private void Mute()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xE7FA00", Offset = "0xE7FA00", VA = "0xE7FA00")]
	private void Unmute()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xE7FA1C", Offset = "0xE7FA1C", VA = "0xE7FA1C")]
	public void UpdateMuteSetting()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xE7FAC8", Offset = "0xE7FAC8", VA = "0xE7FAC8")]
	private void CheckMainAppVersion()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xE80524", Offset = "0xE80524", VA = "0xE80524")]
	private List<string> DirSearch(List<string> files, string sDir)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xE7F6FC", Offset = "0xE7F6FC", VA = "0xE7F6FC")]
	private void CheckExistCreateDirectory(string dir)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xE806B0", Offset = "0xE806B0", VA = "0xE806B0")]
	private void OnApplicationFocus(bool hasFocus)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xE8025C", Offset = "0xE8025C", VA = "0xE8025C")]
	public void DisplayMessage(string title, string msg, [Optional] CoreFile _game)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xE806C4", Offset = "0xE806C4", VA = "0xE806C4")]
	public void DeleteMod()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xE806CC", Offset = "0xE806CC", VA = "0xE806CC")]
	public void DeleteMod(bool blnFromJoint)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xE80D6C", Offset = "0xE80D6C", VA = "0xE80D6C")]
	public void DisplayExtraFile()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xE80F3C", Offset = "0xE80F3C", VA = "0xE80F3C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5049CC", Offset = "0x5049CC")]
	private IEnumerator LoadTextLineByLine(StreamReader file)
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xE80FB4", Offset = "0xE80FB4", VA = "0xE80FB4")]
	public void DisplayNotes()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xE8106C", Offset = "0xE8106C", VA = "0xE8106C")]
	public void DisplayDisclaimer()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xE810C0", Offset = "0xE810C0", VA = "0xE810C0")]
	public void DisplayLog()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xE81114", Offset = "0xE81114", VA = "0xE81114")]
	public void DisplayLaunchLog()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xE8123C", Offset = "0xE8123C", VA = "0xE8123C")]
	public void DisplayCredits()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xE81290", Offset = "0xE81290", VA = "0xE81290")]
	public void QuitApplication()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xE812BC", Offset = "0xE812BC", VA = "0xE812BC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x504A2C", Offset = "0x504A2C")]
	private IEnumerator QuitApplicationAfterSound()
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xE7F73C", Offset = "0xE7F73C", VA = "0xE7F73C")]
	private void LoadInitialSettings()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xE817A0", Offset = "0xE817A0", VA = "0xE817A0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x504A8C", Offset = "0x504A8C")]
	private IEnumerator PostInitialLoad()
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xE80CDC", Offset = "0xE80CDC", VA = "0xE80CDC")]
	public void Rescan()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xE81C58", Offset = "0xE81C58", VA = "0xE81C58")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x504AEC", Offset = "0x504AEC")]
	private IEnumerator NextFrameReload()
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xE8180C", Offset = "0xE8180C", VA = "0xE8180C")]
	private void ReloadAll()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xE81CC4", Offset = "0xE81CC4", VA = "0xE81CC4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x504B4C", Offset = "0x504B4C")]
	private IEnumerator PostReloadActions()
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xE81D30", Offset = "0xE81D30", VA = "0xE81D30")]
	private string CheckRequired(GameObject oButton, List<int> selectedIDs)
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xE82540", Offset = "0xE82540", VA = "0xE82540")]
	private string CheckIncompatible(GameObject oButton, List<int> selectedIDs)
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xE82A20", Offset = "0xE82A20", VA = "0xE82A20")]
	public void LaunchGame()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xE801C0", Offset = "0xE801C0", VA = "0xE801C0")]
	public void AddToLog(string message)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xE82FAC", Offset = "0xE82FAC", VA = "0xE82FAC")]
	public static string BytesToString(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xE80B6C", Offset = "0xE80B6C", VA = "0xE80B6C")]
	private CoreFile FindCoreGamebyID(int id)
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xE83090", Offset = "0xE83090", VA = "0xE83090")]
	public void clearManualField()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xE830E8", Offset = "0xE830E8", VA = "0xE830E8")]
	public void OpenKeyboard()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xE83118", Offset = "0xE83118", VA = "0xE83118")]
	public void CloseDownloadWindow()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xE80D10", Offset = "0xE80D10", VA = "0xE80D10")]
	public void CloseMessageWindow()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xE83174", Offset = "0xE83174", VA = "0xE83174")]
	public void LoadCoreGameDownload(string category)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xE836EC", Offset = "0xE836EC", VA = "0xE836EC")]
	private void AddDownloadButton(CoreFile game)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xE83B74", Offset = "0xE83B74", VA = "0xE83B74")]
	private void ShowDownloadDetails(CoreFile game, GameObject go)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xE840C4", Offset = "0xE840C4", VA = "0xE840C4")]
	public void DownloadMod(CoreFile game)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xE844B8", Offset = "0xE844B8", VA = "0xE844B8")]
	private void ActivateDownloadButtons(bool enableDownload = true)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xE84438", Offset = "0xE84438", VA = "0xE84438")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x504BAC", Offset = "0x504BAC")]
	private IEnumerator DownloadFile(CoreFile game, CoreFile linked_game)
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xE847B8", Offset = "0xE847B8", VA = "0xE847B8")]
	private void ProcessDownload(CoreFile game, string dir, string filename, CoreFile linked_game)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xE80C98", Offset = "0xE80C98", VA = "0xE80C98")]
	private void SafeDeleteDirectory(string path)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xE84F5C", Offset = "0xE84F5C", VA = "0xE84F5C")]
	private void ProcessZippedFiles(CoreFile game, string dir)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xE857F8", Offset = "0xE857F8", VA = "0xE857F8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x504C0C", Offset = "0x504C0C")]
	private IEnumerator progress(UnityWebRequest buffer)
	{
		return null;
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xE85870", Offset = "0xE85870", VA = "0xE85870")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x504C6C", Offset = "0x504C6C")]
	private IEnumerator progress2(UnityWebRequest buffer)
	{
		return null;
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xE81414", Offset = "0xE81414", VA = "0xE81414")]
	private void AddCoreGames(bool supressMessage = false)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xE85DB4", Offset = "0xE85DB4", VA = "0xE85DB4")]
	private void AddJK2Button()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xE858E8", Offset = "0xE858E8", VA = "0xE858E8")]
	private void AddJK3Button()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xE8629C", Offset = "0xE8629C", VA = "0xE8629C")]
	private void AddModButton(CoreFile corefile, bool blnLaunch = false)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xE86CB8", Offset = "0xE86CB8", VA = "0xE86CB8")]
	private void SelectGameStart(GameObject go_button, string _strCommandLine, bool fullGameMissing = false)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xE86F28", Offset = "0xE86F28", VA = "0xE86F28")]
	public void RegenerateCommandLine()
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xE8701C", Offset = "0xE8701C", VA = "0xE8701C")]
	private void LoadExistingCommandLine()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xE81734", Offset = "0xE81734", VA = "0xE81734")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x504CCC", Offset = "0x504CCC")]
	private IEnumerator PreLoadMods()
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xE871C0", Offset = "0xE871C0", VA = "0xE871C0")]
	private void ShowModDetails(CoreFile cf)
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xE81328", Offset = "0xE81328", VA = "0xE81328")]
	private void LoadGameHashes()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xE7F8D8", Offset = "0xE7F8D8", VA = "0xE7F8D8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x504D2C", Offset = "0x504D2C")]
	private IEnumerator UpdateLatestNews()
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xE871F0", Offset = "0xE871F0", VA = "0xE871F0")]
	public void DisplayPatreonInformation()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xE87258", Offset = "0xE87258", VA = "0xE87258")]
	public JKQuestCompanion()
	{
	}
}
[Token(Token = "0x200001F")]
public class LoadScene : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000020")]
	public class SpriteList
	{
		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<string> list;

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xE98974", Offset = "0xE98974", VA = "0xE98974")]
		public SpriteList()
		{
		}
	}

	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503EA8", Offset = "0x503EA8")]
	private sealed class <GetOnlineFiles>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LoadScene <>4__this;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UnityWebRequest <www>5__2;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<string>.Enumerator <>7__wrap2;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string <_sprite>5__4;

		[Token(Token = "0x1700002F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0xE97D48", Offset = "0xE97D48", VA = "0xE97D48", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0xE97D90", Offset = "0xE97D90", VA = "0xE97D90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xE962B4", Offset = "0xE962B4", VA = "0xE962B4")]
		[DebuggerHidden]
		public <GetOnlineFiles>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xE962E0", Offset = "0xE962E0", VA = "0xE962E0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xE96990", Offset = "0xE96990", VA = "0xE96990", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xE964D4", Offset = "0xE964D4", VA = "0xE964D4")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xE96590", Offset = "0xE96590", VA = "0xE96590")]
		private void <>m__Finally2()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xE9664C", Offset = "0xE9664C", VA = "0xE9664C")]
		private void <>m__Finally3()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xE96708", Offset = "0xE96708", VA = "0xE96708")]
		private void <>m__Finally4()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xE967C4", Offset = "0xE967C4", VA = "0xE967C4")]
		private void <>m__Finally5()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xE9693C", Offset = "0xE9693C", VA = "0xE9693C")]
		private void <>m__Finally6()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xE96880", Offset = "0xE96880", VA = "0xE96880")]
		private void <>m__Finally7()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xE97D50", Offset = "0xE97D50", VA = "0xE97D50", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503EB8", Offset = "0x503EB8")]
	private sealed class <UpdateLatestNews>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LoadScene <>4__this;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <waitTime>5__3;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string[] <texts>5__4;

		[Token(Token = "0x17000031")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0xE980E0", Offset = "0xE980E0", VA = "0xE980E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0xE98128", Offset = "0xE98128", VA = "0xE98128", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xE97EEC", Offset = "0xE97EEC", VA = "0xE97EEC")]
		[DebuggerHidden]
		public <UpdateLatestNews>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xE97F18", Offset = "0xE97F18", VA = "0xE97F18", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xE97F1C", Offset = "0xE97F1C", VA = "0xE97F1C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xE980E8", Offset = "0xE980E8", VA = "0xE980E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503EC8", Offset = "0x503EC8")]
	private sealed class <UpdateLoadingText>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LoadScene <>4__this;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <waitTime>5__3;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string[] <texts>5__4;

		[Token(Token = "0x17000033")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0xE98924", Offset = "0xE98924", VA = "0xE98924", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0xE9896C", Offset = "0xE9896C", VA = "0xE9896C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xE98130", Offset = "0xE98130", VA = "0xE98130")]
		[DebuggerHidden]
		public <UpdateLoadingText>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xE9815C", Offset = "0xE9815C", VA = "0xE9815C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xE98160", Offset = "0xE98160", VA = "0xE98160", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xE9892C", Offset = "0xE9892C", VA = "0xE9892C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503ED8", Offset = "0x503ED8")]
	private sealed class <LoadYourAsyncScene>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AsyncOperation <asyncLoad>5__2;

		[Token(Token = "0x17000035")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0xE97E9C", Offset = "0xE97E9C", VA = "0xE97E9C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0xE97EE4", Offset = "0xE97EE4", VA = "0xE97EE4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xE97D98", Offset = "0xE97D98", VA = "0xE97D98")]
		[DebuggerHidden]
		public <LoadYourAsyncScene>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xE97DC4", Offset = "0xE97DC4", VA = "0xE97DC4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xE97DC8", Offset = "0xE97DC8", VA = "0xE97DC8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xE97EA4", Offset = "0xE97EA4", VA = "0xE97EA4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TMP_Text txtLog;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TMP_Text txtLatestNews;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string strBaseDirectory;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string strCoreGameDirectory;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string strModDirectory;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string strTempDirectory;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string strSpriteDirectory;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string strOnlineCoreGame;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string strOnlineSprites;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string strOnlineNews;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private string strOnlineVersion;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private string strOnlineVersionPublic;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private string strOnlineSpriteDir;

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xE87988", Offset = "0xE87988", VA = "0xE87988")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xE87F20", Offset = "0xE87F20", VA = "0xE87F20")]
	private void Update()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xE87AD0", Offset = "0xE87AD0", VA = "0xE87AD0")]
	private bool CheckAppFileSystemExists()
	{
		return default(bool);
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xE87F6C", Offset = "0xE87F6C", VA = "0xE87F6C")]
	private void CheckExistCreateDirectory(string dir)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xE87EB4", Offset = "0xE87EB4", VA = "0xE87EB4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5050AC", Offset = "0x5050AC")]
	private IEnumerator GetOnlineFiles()
	{
		return null;
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xE87FAC", Offset = "0xE87FAC", VA = "0xE87FAC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x50510C", Offset = "0x50510C")]
	private IEnumerator UpdateLatestNews()
	{
		return null;
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xE88018", Offset = "0xE88018", VA = "0xE88018")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x50516C", Offset = "0x50516C")]
	private IEnumerator UpdateLoadingText()
	{
		return null;
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xE87F24", Offset = "0xE87F24", VA = "0xE87F24")]
	public void UpdateProgressText(string message)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xE88084", Offset = "0xE88084", VA = "0xE88084")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5051CC", Offset = "0x5051CC")]
	private IEnumerator LoadYourAsyncScene()
	{
		return null;
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xE880E0", Offset = "0xE880E0", VA = "0xE880E0")]
	public LoadScene()
	{
	}
}
[Token(Token = "0x2000025")]
public class Hover : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[Token(Token = "0x600010E")]
	[Address(RVA = "0xE7F138", Offset = "0xE7F138", VA = "0xE7F138", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xE7F1B4", Offset = "0xE7F1B4", VA = "0xE7F1B4", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xE7F218", Offset = "0xE7F218", VA = "0xE7F218")]
	public Hover()
	{
	}
}
[Token(Token = "0x2000026")]
public class IMG2Sprite : MonoBehaviour
{
	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static IMG2Sprite _instance;

	[Token(Token = "0x17000037")]
	public static IMG2Sprite instance
	{
		[Token(Token = "0x6000111")]
		[Address(RVA = "0xE7F220", Offset = "0xE7F220", VA = "0xE7F220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xE7F300", Offset = "0xE7F300", VA = "0xE7F300")]
	public Sprite LoadNewSprite(string FilePath, float PixelsPerUnit = 100f)
	{
		return null;
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xE7F3CC", Offset = "0xE7F3CC", VA = "0xE7F3CC")]
	public Texture2D LoadTexture(string FilePath)
	{
		return null;
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xE7F46C", Offset = "0xE7F46C", VA = "0xE7F46C")]
	public IMG2Sprite()
	{
	}
}
[Token(Token = "0x2000027")]
public class ScrollScript : MonoBehaviour
{
	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float marginAdjust;

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xE88468", Offset = "0xE88468", VA = "0xE88468")]
	private void Start()
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xE8846C", Offset = "0xE8846C", VA = "0xE8846C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xE88528", Offset = "0xE88528", VA = "0xE88528")]
	public ScrollScript()
	{
	}
}
[Token(Token = "0x2000028")]
public class skyboxspace_demo_v1 : MonoBehaviour
{
	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material[] skyBoxMaterial;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3[] sunPosition;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int skyBoxLength;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int currentSkyBoxIndex;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string topText;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float counter;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int frames;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float fps;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GUIStyle whiteStyle;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static GUIStyle blackStyle;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject sun;

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xE9203C", Offset = "0xE9203C", VA = "0xE9203C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xE920F0", Offset = "0xE920F0", VA = "0xE920F0")]
	private void Update()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xE92248", Offset = "0xE92248", VA = "0xE92248", Slot = "4")]
	protected virtual void OnGUI()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xE92484", Offset = "0xE92484", VA = "0xE92484")]
	private static void DrawText(string text, TextAnchor anchor, int offsetX = 15, int offsetY = 15)
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xE92990", Offset = "0xE92990", VA = "0xE92990")]
	public skyboxspace_demo_v1()
	{
	}
}
[Token(Token = "0x2000029")]
public class skyboxspace_mouselook_v1 : MonoBehaviour
{
	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector2 _mouseAbsolute;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector2 _smoothMouse;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 clampInDegrees;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector2 sensitivity;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector2 smoothing;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector2 targetDirection;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector2 targetCharacterDirection;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject characterBody;

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xE92998", Offset = "0xE92998", VA = "0xE92998")]
	private void Start()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xE92A7C", Offset = "0xE92A7C", VA = "0xE92A7C")]
	private void Update()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xE92E78", Offset = "0xE92E78", VA = "0xE92E78")]
	public skyboxspace_mouselook_v1()
	{
	}
}
[Token(Token = "0x200002A")]
public class ChatController : MonoBehaviour
{
	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TMP_InputField ChatInputField;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TMP_Text ChatDisplayOutput;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Scrollbar ChatScrollbar;

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x77D33C", Offset = "0x77D33C", VA = "0x77D33C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x77D400", Offset = "0x77D400", VA = "0x77D400")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x77D4C4", Offset = "0x77D4C4", VA = "0x77D4C4")]
	private void AddToChatOutput(string newText)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x77D8F0", Offset = "0x77D8F0", VA = "0x77D8F0")]
	public ChatController()
	{
	}
}
[Token(Token = "0x200002B")]
public class DropdownSample : MonoBehaviour
{
	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMeshProUGUI text;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TMP_Dropdown dropdownWithoutPlaceholder;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TMP_Dropdown dropdownWithPlaceholder;

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xE7EF34", Offset = "0xE7EF34", VA = "0xE7EF34")]
	public void OnButtonClick()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xE7F040", Offset = "0xE7F040", VA = "0xE7F040")]
	public DropdownSample()
	{
	}
}
[Token(Token = "0x200002C")]
public class EnvMapAnimator : MonoBehaviour
{
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503EE8", Offset = "0x503EE8")]
	private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EnvMapAnimator <>4__this;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Matrix4x4 <matrix>5__2;

		[Token(Token = "0x17000038")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0xE94308", Offset = "0xE94308", VA = "0xE94308", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0xE94350", Offset = "0xE94350", VA = "0xE94350", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xE9412C", Offset = "0xE9412C", VA = "0xE9412C")]
		[DebuggerHidden]
		public <Start>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xE94158", Offset = "0xE94158", VA = "0xE94158", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xE9415C", Offset = "0xE9415C", VA = "0xE9415C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xE94310", Offset = "0xE94310", VA = "0xE94310", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 RotationSpeeds;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private TMP_Text m_textMeshPro;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Material m_material;

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xE7F048", Offset = "0xE7F048", VA = "0xE7F048")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xE7F0B8", Offset = "0xE7F0B8", VA = "0xE7F0B8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x50536C", Offset = "0x50536C")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xE7F124", Offset = "0xE7F124", VA = "0xE7F124")]
	public EnvMapAnimator()
	{
	}
}
[Token(Token = "0x200002E")]
public class Tooltip : MonoBehaviour
{
	[Token(Token = "0x600012F")]
	[Address(RVA = "0xE90424", Offset = "0xE90424", VA = "0xE90424")]
	private void Start()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0xE90428", Offset = "0xE90428", VA = "0xE90428")]
	private void Update()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xE9042C", Offset = "0xE9042C", VA = "0xE9042C")]
	public Tooltip()
	{
	}
}
namespace TMPro
{
	[Serializable]
	[Token(Token = "0x200002F")]
	public class TMP_DigitValidator : TMP_InputValidator
	{
		[Token(Token = "0x6000132")]
		[Address(RVA = "0xE88B48", Offset = "0xE88B48", VA = "0xE88B48", Slot = "4")]
		public override char Validate(ref string text, ref int pos, char ch)
		{
			return default(char);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xE88BC0", Offset = "0xE88BC0", VA = "0xE88BC0")]
		public TMP_DigitValidator()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000030")]
	public class TMP_PhoneNumberValidator : TMP_InputValidator
	{
		[Token(Token = "0x6000134")]
		[Address(RVA = "0xE8942C", Offset = "0xE8942C", VA = "0xE8942C", Slot = "4")]
		public override char Validate(ref string text, ref int pos, char ch)
		{
			return default(char);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xE89834", Offset = "0xE89834", VA = "0xE89834")]
		public TMP_PhoneNumberValidator()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class TMP_TextEventHandler : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Serializable]
		[Token(Token = "0x2000032")]
		public class CharacterSelectionEvent : UnityEvent<char, int>
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0xE99498", Offset = "0xE99498", VA = "0xE99498")]
			public CharacterSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000033")]
		public class SpriteSelectionEvent : UnityEvent<char, int>
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0xE9957C", Offset = "0xE9957C", VA = "0xE9957C")]
			public SpriteSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000034")]
		public class WordSelectionEvent : UnityEvent<string, int, int>
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0xE995C8", Offset = "0xE995C8", VA = "0xE995C8")]
			public WordSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000035")]
		public class LineSelectionEvent : UnityEvent<string, int, int>
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0xE994E4", Offset = "0xE994E4", VA = "0xE994E4")]
			public LineSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000036")]
		public class LinkSelectionEvent : UnityEvent<string, string, int>
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0xE99530", Offset = "0xE99530", VA = "0xE99530")]
			public LinkSelectionEvent()
			{
			}
		}

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CharacterSelectionEvent m_OnCharacterSelection;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SpriteSelectionEvent m_OnSpriteSelection;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private WordSelectionEvent m_OnWordSelection;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LineSelectionEvent m_OnLineSelection;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LinkSelectionEvent m_OnLinkSelection;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera m_Camera;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Canvas m_Canvas;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_selectedLink;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_lastCharIndex;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int m_lastWordIndex;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int m_lastLineIndex;

		[Token(Token = "0x1700003A")]
		public CharacterSelectionEvent onCharacterSelection
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0xE8A990", Offset = "0xE8A990", VA = "0xE8A990")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000137")]
			[Address(RVA = "0xE8A998", Offset = "0xE8A998", VA = "0xE8A998")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public SpriteSelectionEvent onSpriteSelection
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0xE8A9A0", Offset = "0xE8A9A0", VA = "0xE8A9A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000139")]
			[Address(RVA = "0xE8A9A8", Offset = "0xE8A9A8", VA = "0xE8A9A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public WordSelectionEvent onWordSelection
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0xE8A9B0", Offset = "0xE8A9B0", VA = "0xE8A9B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013B")]
			[Address(RVA = "0xE8A9B8", Offset = "0xE8A9B8", VA = "0xE8A9B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public LineSelectionEvent onLineSelection
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0xE8A9C0", Offset = "0xE8A9C0", VA = "0xE8A9C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013D")]
			[Address(RVA = "0xE8A9C8", Offset = "0xE8A9C8", VA = "0xE8A9C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public LinkSelectionEvent onLinkSelection
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0xE8A9D0", Offset = "0xE8A9D0", VA = "0xE8A9D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013F")]
			[Address(RVA = "0xE8A9D8", Offset = "0xE8A9D8", VA = "0xE8A9D8")]
			set
			{
			}
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xE8A9E0", Offset = "0xE8A9E0", VA = "0xE8A9E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xE8AB74", Offset = "0xE8AB74", VA = "0xE8AB74")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xE8B2C0", Offset = "0xE8B2C0", VA = "0xE8B2C0", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xE8B2C4", Offset = "0xE8B2C4", VA = "0xE8B2C4", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xE8B02C", Offset = "0xE8B02C", VA = "0xE8B02C")]
		private void SendOnCharacterSelection(char character, int characterIndex)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xE8B0A4", Offset = "0xE8B0A4", VA = "0xE8B0A4")]
		private void SendOnSpriteSelection(char character, int characterIndex)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xE8B11C", Offset = "0xE8B11C", VA = "0xE8B11C")]
		private void SendOnWordSelection(string word, int charIndex, int length)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xE8B1A8", Offset = "0xE8B1A8", VA = "0xE8B1A8")]
		private void SendOnLineSelection(string line, int charIndex, int length)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xE8B234", Offset = "0xE8B234", VA = "0xE8B234")]
		private void SendOnLinkSelection(string linkID, string linkText, int linkIndex)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xE8B2C8", Offset = "0xE8B2C8", VA = "0xE8B2C8")]
		public TMP_TextEventHandler()
		{
		}
	}
}
namespace TMPro.Examples
{
	[Token(Token = "0x2000037")]
	public class Benchmark01 : MonoBehaviour
	{
		[Token(Token = "0x2000038")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503EF8", Offset = "0x503EF8")]
		private sealed class <Start>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000128")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000129")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400012A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Benchmark01 <>4__this;

			[Token(Token = "0x400012B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x1700003F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000154")]
				[Address(RVA = "0xE93440", Offset = "0xE93440", VA = "0xE93440", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000040")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000156")]
				[Address(RVA = "0xE93488", Offset = "0xE93488", VA = "0xE93488", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000151")]
			[Address(RVA = "0xE92E98", Offset = "0xE92E98", VA = "0xE92E98")]
			[DebuggerHidden]
			public <Start>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000152")]
			[Address(RVA = "0xE92EC4", Offset = "0xE92EC4", VA = "0xE92EC4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000153")]
			[Address(RVA = "0xE92EC8", Offset = "0xE92EC8", VA = "0xE92EC8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000155")]
			[Address(RVA = "0xE93448", Offset = "0xE93448", VA = "0xE93448", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int BenchmarkType;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TMP_FontAsset TMProFont;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Font TextMeshFont;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TextContainer m_textContainer;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMesh m_textMesh;

		[Token(Token = "0x4000124")]
		private const string label01 = "The <#0050FF>count is: </color>{0}";

		[Token(Token = "0x4000125")]
		private const string label02 = "The <color=#0050FF>count is: </color>";

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material m_material01;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_material02;

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x777D40", Offset = "0x777D40", VA = "0x777D40")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x50541C", Offset = "0x50541C")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x777DAC", Offset = "0x777DAC", VA = "0x777DAC")]
		public Benchmark01()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class Benchmark01_UGUI : MonoBehaviour
	{
		[Token(Token = "0x200003A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503F08", Offset = "0x503F08")]
		private sealed class <Start>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000138")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Benchmark01_UGUI <>4__this;

			[Token(Token = "0x4000139")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x17000041")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600015C")]
				[Address(RVA = "0xE93934", Offset = "0xE93934", VA = "0xE93934", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000042")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600015E")]
				[Address(RVA = "0xE9397C", Offset = "0xE9397C", VA = "0xE9397C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000159")]
			[Address(RVA = "0xE93490", Offset = "0xE93490", VA = "0xE93490")]
			[DebuggerHidden]
			public <Start>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600015A")]
			[Address(RVA = "0xE934BC", Offset = "0xE934BC", VA = "0xE934BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600015B")]
			[Address(RVA = "0xE934C0", Offset = "0xE934C0", VA = "0xE934C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600015D")]
			[Address(RVA = "0xE9393C", Offset = "0xE9393C", VA = "0xE9393C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int BenchmarkType;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Canvas canvas;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TMP_FontAsset TMProFont;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Font TextMeshFont;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TextMeshProUGUI m_textMeshPro;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Text m_textMesh;

		[Token(Token = "0x4000132")]
		private const string label01 = "The <#0050FF>count is: </color>";

		[Token(Token = "0x4000133")]
		private const string label02 = "The <color=#0050FF>count is: </color>";

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material m_material01;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_material02;

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x777DB4", Offset = "0x777DB4", VA = "0x777DB4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5054CC", Offset = "0x5054CC")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x777E20", Offset = "0x777E20", VA = "0x777E20")]
		public Benchmark01_UGUI()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class Benchmark02 : MonoBehaviour
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int SpawnType;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int NumberOfNPC;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool IsTextObjectScaleStatic;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshProFloatingText floatingText_Script;

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x777E28", Offset = "0x777E28", VA = "0x777E28")]
		private void Start()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x778448", Offset = "0x778448", VA = "0x778448")]
		public Benchmark02()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class Benchmark03 : MonoBehaviour
	{
		[Token(Token = "0x200003D")]
		public enum BenchmarkType
		{
			[Token(Token = "0x4000142")]
			TMP_SDF_MOBILE,
			[Token(Token = "0x4000143")]
			TMP_SDF__MOBILE_SSD,
			[Token(Token = "0x4000144")]
			TMP_SDF,
			[Token(Token = "0x4000145")]
			TMP_BITMAP_MOBILE,
			[Token(Token = "0x4000146")]
			TEXTMESH_BITMAP
		}

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int NumberOfSamples;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public BenchmarkType Benchmark;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Font SourceFont;

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x778458", Offset = "0x778458", VA = "0x778458")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x77845C", Offset = "0x77845C", VA = "0x77845C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x778918", Offset = "0x778918", VA = "0x778918")]
		public Benchmark03()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class Benchmark04 : MonoBehaviour
	{
		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int SpawnType;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int MinPointSize;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int MaxPointSize;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int Steps;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform m_Transform;

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x778928", Offset = "0x778928", VA = "0x778928")]
		private void Start()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x778C3C", Offset = "0x778C3C", VA = "0x778C3C")]
		public Benchmark04()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class CameraController : MonoBehaviour
	{
		[Token(Token = "0x2000040")]
		public enum CameraModes
		{
			[Token(Token = "0x4000166")]
			Follow,
			[Token(Token = "0x4000167")]
			Isometric,
			[Token(Token = "0x4000168")]
			Free
		}

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform cameraTransform;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform dummyTarget;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform CameraTarget;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float FollowDistance;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float MaxFollowDistance;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float MinFollowDistance;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float ElevationAngle;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float MaxElevationAngle;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float MinElevationAngle;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float OrbitalAngle;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public CameraModes CameraMode;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool MovementSmoothing;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool RotationSmoothing;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		private bool previousSmoothing;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float MovementSmoothingValue;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float RotationSmoothingValue;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float MoveSensitivity;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 currentVelocity;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 desiredPosition;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float mouseX;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float mouseY;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 moveVector;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float mouseWheel;

		[Token(Token = "0x4000163")]
		private const string event_SmoothingValue = "Slider - Smoothing Value";

		[Token(Token = "0x4000164")]
		private const string event_FollowDistance = "Slider - Camera Zoom";

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x77C6C4", Offset = "0x77C6C4", VA = "0x77C6C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x77C748", Offset = "0x77C748", VA = "0x77C748")]
		private void Start()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x77C814", Offset = "0x77C814", VA = "0x77C814")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x77CB2C", Offset = "0x77CB2C", VA = "0x77CB2C")]
		private void GetPlayerInput()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x77D2D8", Offset = "0x77D2D8", VA = "0x77D2D8")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class ObjectSpin : MonoBehaviour
	{
		[Token(Token = "0x2000042")]
		public enum MotionType
		{
			[Token(Token = "0x4000174")]
			Rotation,
			[Token(Token = "0x4000175")]
			BackAndForth,
			[Token(Token = "0x4000176")]
			Translation
		}

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float SpinSpeed;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int RotationRange;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_transform;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_time;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 m_prevPOS;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_initial_Rotation;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_initial_Position;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Color32 m_lightColor;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int frames;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MotionType Motion;

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xE881C0", Offset = "0xE881C0", VA = "0xE881C0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xE882E0", Offset = "0xE882E0", VA = "0xE882E0")]
		private void Update()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xE8841C", Offset = "0xE8841C", VA = "0xE8841C")]
		public ObjectSpin()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class ShaderPropAnimator : MonoBehaviour
	{
		[Token(Token = "0x2000044")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503F18", Offset = "0x503F18")]
		private sealed class <AnimateProperties>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400017B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400017C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400017D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ShaderPropAnimator <>4__this;

			[Token(Token = "0x17000043")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000175")]
				[Address(RVA = "0xE98B7C", Offset = "0xE98B7C", VA = "0xE98B7C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000044")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000177")]
				[Address(RVA = "0xE98BC4", Offset = "0xE98BC4", VA = "0xE98BC4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000172")]
			[Address(RVA = "0xE989EC", Offset = "0xE989EC", VA = "0xE989EC")]
			[DebuggerHidden]
			public <AnimateProperties>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000173")]
			[Address(RVA = "0xE98A18", Offset = "0xE98A18", VA = "0xE98A18", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000174")]
			[Address(RVA = "0xE98A1C", Offset = "0xE98A1C", VA = "0xE98A1C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000176")]
			[Address(RVA = "0xE98B84", Offset = "0xE98B84", VA = "0xE98B84", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Renderer m_Renderer;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve GlowCurve;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m_frame;

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xE88530", Offset = "0xE88530", VA = "0xE88530")]
		private void Awake()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xE88598", Offset = "0xE88598", VA = "0xE88598")]
		private void Start()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xE885C4", Offset = "0xE885C4", VA = "0xE885C4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x50557C", Offset = "0x50557C")]
		private IEnumerator AnimateProperties()
		{
			return null;
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xE88630", Offset = "0xE88630", VA = "0xE88630")]
		public ShaderPropAnimator()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class SimpleScript : MonoBehaviour
	{
		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x400017F")]
		private const string label = "The <#0050FF>count is: </color>{0:2}";

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_frame;

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xE88638", Offset = "0xE88638", VA = "0xE88638")]
		private void Start()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xE886F0", Offset = "0xE886F0", VA = "0xE886F0")]
		private void Update()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xE88788", Offset = "0xE88788", VA = "0xE88788")]
		public SimpleScript()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class SkewTextExample : MonoBehaviour
	{
		[Token(Token = "0x2000047")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503F28", Offset = "0x503F28")]
		private sealed class <WarpText>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000185")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000186")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000187")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SkewTextExample <>4__this;

			[Token(Token = "0x4000188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <old_CurveScale>5__2;

			[Token(Token = "0x4000189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <old_ShearValue>5__3;

			[Token(Token = "0x400018A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private AnimationCurve <old_curve>5__4;

			[Token(Token = "0x17000045")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000183")]
				[Address(RVA = "0xE99448", Offset = "0xE99448", VA = "0xE99448", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000046")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000185")]
				[Address(RVA = "0xE99490", Offset = "0xE99490", VA = "0xE99490", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000180")]
			[Address(RVA = "0xE98BCC", Offset = "0xE98BCC", VA = "0xE98BCC")]
			[DebuggerHidden]
			public <WarpText>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000181")]
			[Address(RVA = "0xE98BF8", Offset = "0xE98BF8", VA = "0xE98BF8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000182")]
			[Address(RVA = "0xE98BFC", Offset = "0xE98BFC", VA = "0xE98BFC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000184")]
			[Address(RVA = "0xE99450", Offset = "0xE99450", VA = "0xE99450", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve VertexCurve;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float CurveScale;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float ShearAmount;

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xE88790", Offset = "0xE88790", VA = "0xE88790")]
		private void Awake()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xE887F4", Offset = "0xE887F4", VA = "0xE887F4")]
		private void Start()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xE8888C", Offset = "0xE8888C", VA = "0xE8888C")]
		private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			return null;
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xE88820", Offset = "0xE88820", VA = "0xE88820")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x50562C", Offset = "0x50562C")]
		private IEnumerator WarpText()
		{
			return null;
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xE88910", Offset = "0xE88910", VA = "0xE88910")]
		public SkewTextExample()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class TMP_ExampleScript_01 : MonoBehaviour
	{
		[Token(Token = "0x2000049")]
		public enum objectType
		{
			[Token(Token = "0x4000191")]
			TextMeshPro,
			[Token(Token = "0x4000192")]
			TextMeshProUGUI
		}

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public objectType ObjectType;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool isStatic;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TMP_Text m_text;

		[Token(Token = "0x400018E")]
		private const string k_label = "The count is <#0080ff>{0}</color>";

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int count;

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xE88BC8", Offset = "0xE88BC8", VA = "0xE88BC8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xE88DE0", Offset = "0xE88DE0", VA = "0xE88DE0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xE88E78", Offset = "0xE88E78", VA = "0xE88E78")]
		public TMP_ExampleScript_01()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class TMP_FrameRateCounter : MonoBehaviour
	{
		[Token(Token = "0x200004B")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x400019E")]
			TopLeft,
			[Token(Token = "0x400019F")]
			BottomLeft,
			[Token(Token = "0x40001A0")]
			TopRight,
			[Token(Token = "0x40001A1")]
			BottomRight
		}

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float UpdateInterval;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_LastInterval;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_Frames;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string htmlColorTag;

		[Token(Token = "0x4000198")]
		private const string fpsLabel = "{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS";

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_frameCounter_transform;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Camera m_camera;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private FpsCounterAnchorPositions last_AnchorPosition;

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xE88E80", Offset = "0xE88E80", VA = "0xE88E80")]
		private void Awake()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xE89288", Offset = "0xE89288", VA = "0xE89288")]
		private void Start()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xE892B4", Offset = "0xE892B4", VA = "0xE892B4")]
		private void Update()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xE89080", Offset = "0xE89080", VA = "0xE89080")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xE89414", Offset = "0xE89414", VA = "0xE89414")]
		public TMP_FrameRateCounter()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class TMP_TextEventCheck : MonoBehaviour
	{
		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TMP_TextEventHandler TextEventHandler;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xE8983C", Offset = "0xE8983C", VA = "0xE8983C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xE89B40", Offset = "0xE89B40", VA = "0xE89B40")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xE89E1C", Offset = "0xE89E1C", VA = "0xE89E1C")]
		private void OnCharacterSelection(char c, int index)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xE8A014", Offset = "0xE8A014", VA = "0xE8A014")]
		private void OnSpriteSelection(char c, int index)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xE8A20C", Offset = "0xE8A20C", VA = "0xE8A20C")]
		private void OnWordSelection(string word, int firstCharacterIndex, int length)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xE8A46C", Offset = "0xE8A46C", VA = "0xE8A46C")]
		private void OnLineSelection(string lineText, int firstCharacterIndex, int length)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xE8A6CC", Offset = "0xE8A6CC", VA = "0xE8A6CC")]
		private void OnLinkSelection(string linkID, string linkText, int linkIndex)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xE8A988", Offset = "0xE8A988", VA = "0xE8A988")]
		public TMP_TextEventCheck()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class TMP_TextInfoDebugTool : MonoBehaviour
	{
		[Token(Token = "0x6000196")]
		[Address(RVA = "0xE8B3E4", Offset = "0xE8B3E4", VA = "0xE8B3E4")]
		public TMP_TextInfoDebugTool()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class TMP_TextSelector_A : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Camera m_Camera;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_isHoveringObject;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int m_selectedLink;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_lastCharIndex;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int m_lastWordIndex;

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xE8B3EC", Offset = "0xE8B3EC", VA = "0xE8B3EC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xE8B47C", Offset = "0xE8B47C", VA = "0xE8B47C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xE8BB9C", Offset = "0xE8BB9C", VA = "0xE8BB9C", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xE8BC20", Offset = "0xE8BC20", VA = "0xE8BC20", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xE8BCA0", Offset = "0xE8BCA0", VA = "0xE8BCA0")]
		public TMP_TextSelector_A()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class TMP_TextSelector_B : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler, IPointerUpHandler
	{
		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RectTransform TextPopup_Prefab_01;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform m_TextPopup_RectTransform;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshProUGUI m_TextPopup_TMPComponent;

		[Token(Token = "0x40001AD")]
		private const string k_LinkText = "You have selected link <#ffff00>";

		[Token(Token = "0x40001AE")]
		private const string k_WordText = "Word Index: <#ffff00>";

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshProUGUI m_TextMeshPro;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Canvas m_Canvas;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Camera m_Camera;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool isHoveringObject;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int m_selectedWord;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_selectedLink;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_lastIndex;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Matrix4x4 m_matrix;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TMP_MeshInfo[] m_cachedMeshInfoVertexData;

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xE8BCB8", Offset = "0xE8BCB8", VA = "0xE8BCB8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xE8BE44", Offset = "0xE8BE44", VA = "0xE8BE44")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xE8BF34", Offset = "0xE8BF34", VA = "0xE8BF34")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xE8C024", Offset = "0xE8C024", VA = "0xE8C024")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xE8C0C4", Offset = "0xE8C0C4", VA = "0xE8C0C4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xE8D5BC", Offset = "0xE8D5BC", VA = "0xE8D5BC", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xE8D5C8", Offset = "0xE8D5C8", VA = "0xE8D5C8", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xE8D5D0", Offset = "0xE8D5D0", VA = "0xE8D5D0", Slot = "6")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xE8D5D4", Offset = "0xE8D5D4", VA = "0xE8D5D4", Slot = "7")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xE8CD2C", Offset = "0xE8CD2C", VA = "0xE8CD2C")]
		private void RestoreCachedVertexAttributes(int index)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xE8D5D8", Offset = "0xE8D5D8", VA = "0xE8D5D8")]
		public TMP_TextSelector_B()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class TMP_UiFrameRateCounter : MonoBehaviour
	{
		[Token(Token = "0x2000051")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x40001C2")]
			TopLeft,
			[Token(Token = "0x40001C3")]
			BottomLeft,
			[Token(Token = "0x40001C4")]
			TopRight,
			[Token(Token = "0x40001C5")]
			BottomRight
		}

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float UpdateInterval;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_LastInterval;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_Frames;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string htmlColorTag;

		[Token(Token = "0x40001BD")]
		private const string fpsLabel = "{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS";

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshProUGUI m_TextMeshPro;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RectTransform m_frameCounter_transform;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private FpsCounterAnchorPositions last_AnchorPosition;

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xE8E5F0", Offset = "0xE8E5F0", VA = "0xE8E5F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xE8EA34", Offset = "0xE8EA34", VA = "0xE8EA34")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xE8EA60", Offset = "0xE8EA60", VA = "0xE8EA60")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xE8E7F0", Offset = "0xE8E7F0", VA = "0xE8E7F0")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xE8EBC0", Offset = "0xE8EBC0", VA = "0xE8EBC0")]
		public TMP_UiFrameRateCounter()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class TMPro_InstructionOverlay : MonoBehaviour
	{
		[Token(Token = "0x2000053")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x40001CD")]
			TopLeft,
			[Token(Token = "0x40001CE")]
			BottomLeft,
			[Token(Token = "0x40001CF")]
			TopRight,
			[Token(Token = "0x40001D0")]
			BottomRight
		}

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x40001C7")]
		private const string instructions = "Camera Control - <#ffff00>Shift + RMB\n</color>Zoom - <#ffff00>Mouse wheel.";

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextContainer m_textContainer;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform m_frameCounter_transform;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Camera m_camera;

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xE8EBD8", Offset = "0xE8EBD8", VA = "0xE8EBD8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xE8EE24", Offset = "0xE8EE24", VA = "0xE8EE24")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xE8EF4C", Offset = "0xE8EF4C", VA = "0xE8EF4C")]
		public TMPro_InstructionOverlay()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class TeleType : MonoBehaviour
	{
		[Token(Token = "0x2000055")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503F38", Offset = "0x503F38")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TeleType <>4__this;

			[Token(Token = "0x40001D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <totalVisibleCharacters>5__2;

			[Token(Token = "0x40001D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <counter>5__3;

			[Token(Token = "0x17000047")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001B5")]
				[Address(RVA = "0xE99848", Offset = "0xE99848", VA = "0xE99848", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000048")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001B7")]
				[Address(RVA = "0xE99890", Offset = "0xE99890", VA = "0xE99890", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001B2")]
			[Address(RVA = "0xE8F05C", Offset = "0xE8F05C", VA = "0xE8F05C")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60001B3")]
			[Address(RVA = "0xE99614", Offset = "0xE99614", VA = "0xE99614", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001B4")]
			[Address(RVA = "0xE99618", Offset = "0xE99618", VA = "0xE99618", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001B6")]
			[Address(RVA = "0xE99850", Offset = "0xE99850", VA = "0xE99850", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string label01;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string label02;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_textMeshPro;

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xE8EF5C", Offset = "0xE8EF5C", VA = "0xE8EF5C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xE8EFF0", Offset = "0xE8EFF0", VA = "0xE8EFF0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5056DC", Offset = "0x5056DC")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xE8F088", Offset = "0xE8F088", VA = "0xE8F088")]
		public TeleType()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class TextConsoleSimulator : MonoBehaviour
	{
		[Token(Token = "0x2000057")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503F48", Offset = "0x503F48")]
		private sealed class <RevealCharacters>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TMP_Text textComponent;

			[Token(Token = "0x40001DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TextConsoleSimulator <>4__this;

			[Token(Token = "0x40001DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x40001E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <totalVisibleCharacters>5__3;

			[Token(Token = "0x40001E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int <visibleCount>5__4;

			[Token(Token = "0x17000049")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001C3")]
				[Address(RVA = "0xE99A00", Offset = "0xE99A00", VA = "0xE99A00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001C5")]
				[Address(RVA = "0xE99A48", Offset = "0xE99A48", VA = "0xE99A48", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001C0")]
			[Address(RVA = "0xE8F3F0", Offset = "0xE8F3F0", VA = "0xE8F3F0")]
			[DebuggerHidden]
			public <RevealCharacters>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60001C1")]
			[Address(RVA = "0xE99898", Offset = "0xE99898", VA = "0xE99898", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001C2")]
			[Address(RVA = "0xE9989C", Offset = "0xE9989C", VA = "0xE9989C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001C4")]
			[Address(RVA = "0xE99A08", Offset = "0xE99A08", VA = "0xE99A08", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000058")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503F58", Offset = "0x503F58")]
		private sealed class <RevealWords>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TMP_Text textComponent;

			[Token(Token = "0x40001E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <totalWordCount>5__2;

			[Token(Token = "0x40001E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <totalVisibleCharacters>5__3;

			[Token(Token = "0x40001E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <counter>5__4;

			[Token(Token = "0x40001E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <visibleCount>5__5;

			[Token(Token = "0x1700004B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001C9")]
				[Address(RVA = "0xE99C3C", Offset = "0xE99C3C", VA = "0xE99C3C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001CB")]
				[Address(RVA = "0xE99C84", Offset = "0xE99C84", VA = "0xE99C84", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001C6")]
			[Address(RVA = "0xE8F488", Offset = "0xE8F488", VA = "0xE8F488")]
			[DebuggerHidden]
			public <RevealWords>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60001C7")]
			[Address(RVA = "0xE99A50", Offset = "0xE99A50", VA = "0xE99A50", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001C8")]
			[Address(RVA = "0xE99A54", Offset = "0xE99A54", VA = "0xE99A54", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001CA")]
			[Address(RVA = "0xE99C44", Offset = "0xE99C44", VA = "0xE99C44", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool hasTextChanged;

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xE8F0F8", Offset = "0xE8F0F8", VA = "0xE8F0F8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xE8F15C", Offset = "0xE8F15C", VA = "0xE8F15C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xE8F204", Offset = "0xE8F204", VA = "0xE8F204")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xE8F2F4", Offset = "0xE8F2F4", VA = "0xE8F2F4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xE8F3E4", Offset = "0xE8F3E4", VA = "0xE8F3E4")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xE8F18C", Offset = "0xE8F18C", VA = "0xE8F18C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x50578C", Offset = "0x50578C")]
		private IEnumerator RevealCharacters(TMP_Text textComponent)
		{
			return null;
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xE8F41C", Offset = "0xE8F41C", VA = "0xE8F41C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5057EC", Offset = "0x5057EC")]
		private IEnumerator RevealWords(TMP_Text textComponent)
		{
			return null;
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xE8F4B4", Offset = "0xE8F4B4", VA = "0xE8F4B4")]
		public TextConsoleSimulator()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public class TextMeshProFloatingText : MonoBehaviour
	{
		[Token(Token = "0x200005A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503F68", Offset = "0x503F68")]
		private sealed class <DisplayTextMeshProFloatingText>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TextMeshProFloatingText <>4__this;

			[Token(Token = "0x40001F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <CountDuration>5__2;

			[Token(Token = "0x40001FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <starting_Count>5__3;

			[Token(Token = "0x40001FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <current_Count>5__4;

			[Token(Token = "0x40001FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 <start_pos>5__5;

			[Token(Token = "0x40001FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Color32 <start_color>5__6;

			[Token(Token = "0x40001FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float <alpha>5__7;

			[Token(Token = "0x40001FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <fadeDuration>5__8;

			[Token(Token = "0x1700004D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001D5")]
				[Address(RVA = "0xE9A574", Offset = "0xE9A574", VA = "0xE9A574", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001D7")]
				[Address(RVA = "0xE9A5BC", Offset = "0xE9A5BC", VA = "0xE9A5BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001D2")]
			[Address(RVA = "0xE8FA34", Offset = "0xE8FA34", VA = "0xE8FA34")]
			[DebuggerHidden]
			public <DisplayTextMeshProFloatingText>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x60001D3")]
			[Address(RVA = "0xE9A11C", Offset = "0xE9A11C", VA = "0xE9A11C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001D4")]
			[Address(RVA = "0xE9A120", Offset = "0xE9A120", VA = "0xE9A120", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001D6")]
			[Address(RVA = "0xE9A57C", Offset = "0xE9A57C", VA = "0xE9A57C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200005B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503F78", Offset = "0x503F78")]
		private sealed class <DisplayTextMeshFloatingText>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000200")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000201")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000202")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TextMeshProFloatingText <>4__this;

			[Token(Token = "0x4000203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <CountDuration>5__2;

			[Token(Token = "0x4000204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <starting_Count>5__3;

			[Token(Token = "0x4000205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <current_Count>5__4;

			[Token(Token = "0x4000206")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 <start_pos>5__5;

			[Token(Token = "0x4000207")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Color32 <start_color>5__6;

			[Token(Token = "0x4000208")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float <alpha>5__7;

			[Token(Token = "0x4000209")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <fadeDuration>5__8;

			[Token(Token = "0x1700004F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001DB")]
				[Address(RVA = "0xE9A0CC", Offset = "0xE9A0CC", VA = "0xE9A0CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000050")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001DD")]
				[Address(RVA = "0xE9A114", Offset = "0xE9A114", VA = "0xE9A114", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001D8")]
			[Address(RVA = "0xE8FA60", Offset = "0xE8FA60", VA = "0xE8FA60")]
			[DebuggerHidden]
			public <DisplayTextMeshFloatingText>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x60001D9")]
			[Address(RVA = "0xE99C8C", Offset = "0xE99C8C", VA = "0xE99C8C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001DA")]
			[Address(RVA = "0xE99C90", Offset = "0xE99C90", VA = "0xE99C90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001DC")]
			[Address(RVA = "0xE9A0D4", Offset = "0xE9A0D4", VA = "0xE9A0D4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Font TheFont;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject m_floatingText;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMesh m_textMesh;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_transform;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform m_floatingText_Transform;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform m_cameraTransform;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 lastPOS;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion lastRotation;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int SpawnType;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool IsTextObjectScaleStatic;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static WaitForEndOfFrame k_WaitForEndOfFrame;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static WaitForSeconds[] k_WaitForSecondsRandom;

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xE8F4BC", Offset = "0xE8F4BC", VA = "0xE8F4BC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xE8F584", Offset = "0xE8F584", VA = "0xE8F584")]
		private void Start()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xE8F95C", Offset = "0xE8F95C", VA = "0xE8F95C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5058EC", Offset = "0x5058EC")]
		public IEnumerator DisplayTextMeshProFloatingText()
		{
			return null;
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xE8F9C8", Offset = "0xE8F9C8", VA = "0xE8F9C8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x50594C", Offset = "0x50594C")]
		public IEnumerator DisplayTextMeshFloatingText()
		{
			return null;
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xE8FA8C", Offset = "0xE8FA8C", VA = "0xE8FA8C")]
		public TextMeshProFloatingText()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class TextMeshSpawner : MonoBehaviour
	{
		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int SpawnType;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int NumberOfNPC;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Font TheFont;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshProFloatingText floatingText_Script;

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xE900F0", Offset = "0xE900F0", VA = "0xE900F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xE900F4", Offset = "0xE900F4", VA = "0xE900F4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xE90414", Offset = "0xE90414", VA = "0xE90414")]
		public TextMeshSpawner()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class VertexColorCycler : MonoBehaviour
	{
		[Token(Token = "0x200005E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503F88", Offset = "0x503F88")]
		private sealed class <AnimateVertexColors>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400020F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000210")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000211")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexColorCycler <>4__this;

			[Token(Token = "0x4000212")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x4000213")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <currentCharacter>5__3;

			[Token(Token = "0x17000051")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001E8")]
				[Address(RVA = "0xE9A880", Offset = "0xE9A880", VA = "0xE9A880", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000052")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001EA")]
				[Address(RVA = "0xE9A8C8", Offset = "0xE9A8C8", VA = "0xE9A8C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001E5")]
			[Address(RVA = "0xE90520", Offset = "0xE90520", VA = "0xE90520")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60001E6")]
			[Address(RVA = "0xE9A5C4", Offset = "0xE9A5C4", VA = "0xE9A5C4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001E7")]
			[Address(RVA = "0xE9A5C8", Offset = "0xE9A5C8", VA = "0xE9A5C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001E9")]
			[Address(RVA = "0xE9A888", Offset = "0xE9A888", VA = "0xE9A888", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xE90434", Offset = "0xE90434", VA = "0xE90434")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xE90488", Offset = "0xE90488", VA = "0xE90488")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xE904B4", Offset = "0xE904B4", VA = "0xE904B4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x505A4C", Offset = "0x505A4C")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xE9054C", Offset = "0xE9054C", VA = "0xE9054C")]
		public VertexColorCycler()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class VertexJitter : MonoBehaviour
	{
		[Token(Token = "0x2000060")]
		private struct VertexAnim
		{
			[Token(Token = "0x4000219")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float angleRange;

			[Token(Token = "0x400021A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float angle;

			[Token(Token = "0x400021B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float speed;
		}

		[Token(Token = "0x2000061")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503F98", Offset = "0x503F98")]
		private sealed class <AnimateVertexColors>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400021C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400021D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400021E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexJitter <>4__this;

			[Token(Token = "0x400021F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x4000220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <loopCount>5__3;

			[Token(Token = "0x4000221")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private VertexAnim[] <vertexAnim>5__4;

			[Token(Token = "0x4000222")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TMP_MeshInfo[] <cachedMeshInfo>5__5;

			[Token(Token = "0x17000053")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001F5")]
				[Address(RVA = "0xE9B10C", Offset = "0xE9B10C", VA = "0xE9B10C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000054")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001F7")]
				[Address(RVA = "0xE9B154", Offset = "0xE9B154", VA = "0xE9B154", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001F2")]
			[Address(RVA = "0xE908A8", Offset = "0xE908A8", VA = "0xE908A8")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60001F3")]
			[Address(RVA = "0xE9A8D0", Offset = "0xE9A8D0", VA = "0xE9A8D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001F4")]
			[Address(RVA = "0xE9A8D4", Offset = "0xE9A8D4", VA = "0xE9A8D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001F6")]
			[Address(RVA = "0xE9B114", Offset = "0xE9B114", VA = "0xE9B114", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CurveScale;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xE90554", Offset = "0xE90554", VA = "0xE90554")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xE905A8", Offset = "0xE905A8", VA = "0xE905A8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xE90698", Offset = "0xE90698", VA = "0xE90698")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xE90788", Offset = "0xE90788", VA = "0xE90788")]
		private void Start()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xE90820", Offset = "0xE90820", VA = "0xE90820")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xE907B4", Offset = "0xE907B4", VA = "0xE907B4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x505AFC", Offset = "0x505AFC")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xE908D4", Offset = "0xE908D4", VA = "0xE908D4")]
		public VertexJitter()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class VertexShakeA : MonoBehaviour
	{
		[Token(Token = "0x2000063")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503FA8", Offset = "0x503FA8")]
		private sealed class <AnimateVertexColors>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000229")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400022A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400022B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexShakeA <>4__this;

			[Token(Token = "0x400022C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x400022D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3[][] <copyOfVertices>5__3;

			[Token(Token = "0x17000055")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000202")]
				[Address(RVA = "0xE9BB30", Offset = "0xE9BB30", VA = "0xE9BB30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000056")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000204")]
				[Address(RVA = "0xE9BB78", Offset = "0xE9BB78", VA = "0xE9BB78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001FF")]
			[Address(RVA = "0xE90C30", Offset = "0xE90C30", VA = "0xE90C30")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000200")]
			[Address(RVA = "0xE9B15C", Offset = "0xE9B15C", VA = "0xE9B15C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000201")]
			[Address(RVA = "0xE9B160", Offset = "0xE9B160", VA = "0xE9B160", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000203")]
			[Address(RVA = "0xE9BB38", Offset = "0xE9BB38", VA = "0xE9BB38", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float ScaleMultiplier;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float RotationMultiplier;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xE908EC", Offset = "0xE908EC", VA = "0xE908EC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xE90940", Offset = "0xE90940", VA = "0xE90940")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xE90A30", Offset = "0xE90A30", VA = "0xE90A30")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xE90B20", Offset = "0xE90B20", VA = "0xE90B20")]
		private void Start()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xE90BB8", Offset = "0xE90BB8", VA = "0xE90BB8")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xE90B4C", Offset = "0xE90B4C", VA = "0xE90B4C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x505BAC", Offset = "0x505BAC")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xE90C5C", Offset = "0xE90C5C", VA = "0xE90C5C")]
		public VertexShakeA()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class VertexShakeB : MonoBehaviour
	{
		[Token(Token = "0x2000065")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503FB8", Offset = "0x503FB8")]
		private sealed class <AnimateVertexColors>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000233")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000234")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000235")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexShakeB <>4__this;

			[Token(Token = "0x4000236")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x4000237")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3[][] <copyOfVertices>5__3;

			[Token(Token = "0x17000057")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600020F")]
				[Address(RVA = "0xE9C9E8", Offset = "0xE9C9E8", VA = "0xE9C9E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000058")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000211")]
				[Address(RVA = "0xE9CA30", Offset = "0xE9CA30", VA = "0xE9CA30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600020C")]
			[Address(RVA = "0xE90FB0", Offset = "0xE90FB0", VA = "0xE90FB0")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600020D")]
			[Address(RVA = "0xE9BB80", Offset = "0xE9BB80", VA = "0xE9BB80", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600020E")]
			[Address(RVA = "0xE9BB84", Offset = "0xE9BB84", VA = "0xE9BB84", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000210")]
			[Address(RVA = "0xE9C9F0", Offset = "0xE9C9F0", VA = "0xE9C9F0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CurveScale;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xE90C6C", Offset = "0xE90C6C", VA = "0xE90C6C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xE90CC0", Offset = "0xE90CC0", VA = "0xE90CC0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xE90DB0", Offset = "0xE90DB0", VA = "0xE90DB0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xE90EA0", Offset = "0xE90EA0", VA = "0xE90EA0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xE90F38", Offset = "0xE90F38", VA = "0xE90F38")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xE90ECC", Offset = "0xE90ECC", VA = "0xE90ECC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x505C5C", Offset = "0x505C5C")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xE90FDC", Offset = "0xE90FDC", VA = "0xE90FDC")]
		public VertexShakeB()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class VertexZoom : MonoBehaviour
	{
		[Token(Token = "0x2000067")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503FC8", Offset = "0x503FC8")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x400023D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<float> modifiedCharScale;

			[Token(Token = "0x400023E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Comparison<int> <>9__0;

			[Token(Token = "0x6000219")]
			[Address(RVA = "0xE9CA38", Offset = "0xE9CA38", VA = "0xE9CA38")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x600021A")]
			[Address(RVA = "0xE9CA40", Offset = "0xE9CA40", VA = "0xE9CA40")]
			internal int <AnimateVertexColors>b__0(int a, int b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000068")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503FD8", Offset = "0x503FD8")]
		private sealed class <AnimateVertexColors>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400023F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000240")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexZoom <>4__this;

			[Token(Token = "0x4000242")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private <>c__DisplayClass10_0 <>8__1;

			[Token(Token = "0x4000243")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x4000244")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TMP_MeshInfo[] <cachedMeshInfoVertexData>5__3;

			[Token(Token = "0x4000245")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private List<int> <scaleSortingOrder>5__4;

			[Token(Token = "0x17000059")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600021E")]
				[Address(RVA = "0xE9D648", Offset = "0xE9D648", VA = "0xE9D648", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000220")]
				[Address(RVA = "0xE9D690", Offset = "0xE9D690", VA = "0xE9D690", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600021B")]
			[Address(RVA = "0xE91348", Offset = "0xE91348", VA = "0xE91348")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600021C")]
			[Address(RVA = "0xE9CB00", Offset = "0xE9CB00", VA = "0xE9CB00", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600021D")]
			[Address(RVA = "0xE9CB04", Offset = "0xE9CB04", VA = "0xE9CB04", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600021F")]
			[Address(RVA = "0xE9D650", Offset = "0xE9D650", VA = "0xE9D650", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CurveScale;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xE90FF4", Offset = "0xE90FF4", VA = "0xE90FF4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xE91048", Offset = "0xE91048", VA = "0xE91048")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xE91138", Offset = "0xE91138", VA = "0xE91138")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xE91228", Offset = "0xE91228", VA = "0xE91228")]
		private void Start()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xE912C0", Offset = "0xE912C0", VA = "0xE912C0")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xE91254", Offset = "0xE91254", VA = "0xE91254")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x505D0C", Offset = "0x505D0C")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xE91374", Offset = "0xE91374", VA = "0xE91374")]
		public VertexZoom()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class WarpTextExample : MonoBehaviour
	{
		[Token(Token = "0x200006A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503FE8", Offset = "0x503FE8")]
		private sealed class <WarpText>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400024B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400024C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400024D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WarpTextExample <>4__this;

			[Token(Token = "0x400024E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <old_CurveScale>5__2;

			[Token(Token = "0x400024F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private AnimationCurve <old_curve>5__3;

			[Token(Token = "0x1700005B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000229")]
				[Address(RVA = "0xE9DE40", Offset = "0xE9DE40", VA = "0xE9DE40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600022B")]
				[Address(RVA = "0xE9DE88", Offset = "0xE9DE88", VA = "0xE9DE88", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000226")]
			[Address(RVA = "0xE91DD0", Offset = "0xE91DD0", VA = "0xE91DD0")]
			[DebuggerHidden]
			public <WarpText>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000227")]
			[Address(RVA = "0xE9D698", Offset = "0xE9D698", VA = "0xE9D698", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000228")]
			[Address(RVA = "0xE9D69C", Offset = "0xE9D69C", VA = "0xE9D69C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600022A")]
			[Address(RVA = "0xE9DE48", Offset = "0xE9DE48", VA = "0xE9DE48", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve VertexCurve;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float AngleMultiplier;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float SpeedMultiplier;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float CurveScale;

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xE91C50", Offset = "0xE91C50", VA = "0xE91C50")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xE91CB4", Offset = "0xE91CB4", VA = "0xE91CB4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xE91D4C", Offset = "0xE91D4C", VA = "0xE91D4C")]
		private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			return null;
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xE91CE0", Offset = "0xE91CE0", VA = "0xE91CE0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x505DBC", Offset = "0x505DBC")]
		private IEnumerator WarpText()
		{
			return null;
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xE91DFC", Offset = "0xE91DFC", VA = "0xE91DFC")]
		public WarpTextExample()
		{
		}
	}
}
namespace CurvedUI
{
	[Token(Token = "0x200006B")]
	public class CUI_AnimateCurvedFillOnStart : MonoBehaviour
	{
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x778C58", Offset = "0x778C58", VA = "0x778C58")]
		private void Update()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x778E24", Offset = "0x778E24", VA = "0x778E24")]
		public CUI_AnimateCurvedFillOnStart()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class CUI_CameraController : MonoBehaviour
	{
		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform CameraObject;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float rotationMargin;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool runInEditorOnly;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static CUI_CameraController Instance;

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x778E2C", Offset = "0x778E2C", VA = "0x778E2C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x778E7C", Offset = "0x778E7C", VA = "0x778E7C")]
		public CUI_CameraController()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class CUI_CameraRotationOnButtonHeld : MonoBehaviour
	{
		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float Sensitivity;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector2 _oldMousePos;

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x778E94", Offset = "0x778E94", VA = "0x778E94")]
		private void Start()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x778F90", Offset = "0x778F90", VA = "0x778F90")]
		public CUI_CameraRotationOnButtonHeld()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class CUI_ChangeColor : MonoBehaviour
	{
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x778FA0", Offset = "0x778FA0", VA = "0x778FA0")]
		public void ChangeColorToBlue()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x779018", Offset = "0x779018", VA = "0x779018")]
		public void ChangeColorToCyan()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x779090", Offset = "0x779090", VA = "0x779090")]
		public void ChangeColorToWhite()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x779108", Offset = "0x779108", VA = "0x779108")]
		public CUI_ChangeColor()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class CUI_ChangeValueOnHold : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool pressed;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool selected;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image bg;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color SelectedColor;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color NormalColor;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup IntroCG;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup MenuCG;

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x779110", Offset = "0x779110", VA = "0x779110")]
		private void Update()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x779190", Offset = "0x779190", VA = "0x779190")]
		private void ChangeVal()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x7792F4", Offset = "0x7792F4", VA = "0x7792F4", Slot = "4")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x779384", Offset = "0x779384", VA = "0x779384", Slot = "5")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x779410", Offset = "0x779410", VA = "0x779410")]
		public CUI_ChangeValueOnHold()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class CUI_DragBetweenCanvases : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
	{
		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector2 dragPoint;

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x779418", Offset = "0x779418", VA = "0x779418", Slot = "4")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x7796F8", Offset = "0x7796F8", VA = "0x7796F8", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x779CF8", Offset = "0x779CF8", VA = "0x779CF8", Slot = "5")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x779538", Offset = "0x779538", VA = "0x779538")]
		private void RaycastPosition(out Vector2 newPos)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x779D6C", Offset = "0x779D6C", VA = "0x779D6C")]
		public CUI_DragBetweenCanvases()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class CUI_GunController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000072")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503FF8", Offset = "0x503FF8")]
		private sealed class <>c
		{
			[Token(Token = "0x4000260")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000261")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<GameObject> <>9__2_0;

			[Token(Token = "0x6000243")]
			[Address(RVA = "0xE939E4", Offset = "0xE939E4", VA = "0xE939E4")]
			public <>c()
			{
			}

			[Token(Token = "0x6000244")]
			[Address(RVA = "0xE939EC", Offset = "0xE939EC", VA = "0xE939EC")]
			internal bool <Update>b__2_0(GameObject x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CurvedUISettings ControlledCanvas;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform LaserBeamTransform;

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x779D74", Offset = "0x779D74", VA = "0x779D74")]
		private void Update()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x77A284", Offset = "0x77A284", VA = "0x77A284")]
		public CUI_GunController()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class CUI_GunMovement : MonoBehaviour
	{
		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CurvedUISettings mySettings;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform pivot;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float sensitivity;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector2 lastMouse;

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x77A28C", Offset = "0x77A28C", VA = "0x77A28C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x77A2F0", Offset = "0x77A2F0", VA = "0x77A2F0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x77A534", Offset = "0x77A534", VA = "0x77A534")]
		public CUI_GunMovement()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class CUI_OrientOnCurvedSpace : MonoBehaviour
	{
		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvedUISettings mySettings;

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x77A964", Offset = "0x77A964", VA = "0x77A964")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x77A9B8", Offset = "0x77A9B8", VA = "0x77A9B8")]
		private void Update()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x77ADE4", Offset = "0x77ADE4", VA = "0x77ADE4")]
		public CUI_OrientOnCurvedSpace()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class CUI_PerlinNoisePosition : MonoBehaviour
	{
		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float samplingSpeed;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2 Range;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RectTransform rectie;

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x77ADEC", Offset = "0x77ADEC", VA = "0x77ADEC")]
		private void Start()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x77AE5C", Offset = "0x77AE5C", VA = "0x77AE5C")]
		private void Update()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x77AF50", Offset = "0x77AF50", VA = "0x77AF50")]
		public CUI_PerlinNoisePosition()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class CUI_PerlinNoiseRotation : MonoBehaviour
	{
		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float samplingSpeed;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxrotation;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform rectie;

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x77AF60", Offset = "0x77AF60", VA = "0x77AF60")]
		private void Start()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x77AFD0", Offset = "0x77AFD0", VA = "0x77AFD0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x77B054", Offset = "0x77B054", VA = "0x77B054")]
		public CUI_PerlinNoiseRotation()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class CUI_PickImageFromSet : MonoBehaviour
	{
		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CUI_PickImageFromSet picked;

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x77B068", Offset = "0x77B068", VA = "0x77B068")]
		public void PickThis()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x77B258", Offset = "0x77B258", VA = "0x77B258")]
		public CUI_PickImageFromSet()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class CUI_RaycastToCanvas : MonoBehaviour
	{
		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x77B264", Offset = "0x77B264", VA = "0x77B264")]
		private void Start()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x77B2B8", Offset = "0x77B2B8", VA = "0x77B2B8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x77B374", Offset = "0x77B374", VA = "0x77B374")]
		public CUI_RaycastToCanvas()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class CUI_RiseChildrenOverTime : MonoBehaviour
	{
		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float current;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float Speed;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float RiseBy;

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x77B37C", Offset = "0x77B37C", VA = "0x77B37C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x77B380", Offset = "0x77B380", VA = "0x77B380")]
		private void Update()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x77B4F0", Offset = "0x77B4F0", VA = "0x77B4F0")]
		public CUI_RiseChildrenOverTime()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class CUI_TMPChecker : MonoBehaviour
	{
		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject testMsg;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject enabledMsg;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject disabledMsg;

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x77B5E4", Offset = "0x77B5E4", VA = "0x77B5E4")]
		private void Start()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x77B660", Offset = "0x77B660", VA = "0x77B660")]
		public CUI_TMPChecker()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class CUI_ViveButtonState : MonoBehaviour
	{
		[Token(Token = "0x200007C")]
		private enum ViveButton
		{
			[Token(Token = "0x4000279")]
			Trigger,
			[Token(Token = "0x400027A")]
			TouchpadTouch,
			[Token(Token = "0x400027B")]
			TouchpadPress,
			[Token(Token = "0x400027C")]
			Grip,
			[Token(Token = "0x400027D")]
			Menu
		}

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color ActiveColor;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color InActiveColor;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ViveButton ShowStateFor;

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x77B668", Offset = "0x77B668", VA = "0x77B668")]
		public CUI_ViveButtonState()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class CUI_ViveHapticPulse : MonoBehaviour
	{
		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float PulseStrength;

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x77B6AC", Offset = "0x77B6AC", VA = "0x77B6AC")]
		private void Start()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x77B6B8", Offset = "0x77B6B8", VA = "0x77B6B8")]
		public void SetPulseStrength(float newStr)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x77B6E8", Offset = "0x77B6E8", VA = "0x77B6E8")]
		public void TriggerPulse()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x77B6EC", Offset = "0x77B6EC", VA = "0x77B6EC")]
		public CUI_ViveHapticPulse()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class CUI_WorldSpaceCursorFollow : MonoBehaviour
	{
		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x77B6F4", Offset = "0x77B6F4", VA = "0x77B6F4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x77B928", Offset = "0x77B928", VA = "0x77B928")]
		private void Update()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x77B9B8", Offset = "0x77B9B8", VA = "0x77B9B8")]
		public CUI_WorldSpaceCursorFollow()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class CUI_WorldSpaceMouseMultipleCanvases : MonoBehaviour
	{
		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<CurvedUISettings> ControlledCanvases;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform WorldSpaceMouse;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CurvedUISettings MouseCanvas;

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x77B9C0", Offset = "0x77B9C0", VA = "0x77B9C0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x77BCBC", Offset = "0x77BCBC", VA = "0x77BCBC")]
		public CUI_WorldSpaceMouseMultipleCanvases()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class CUI_draggable : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
	{
		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector2 savedVector;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isDragged;

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x77BCC4", Offset = "0x77BCC4", VA = "0x77BCC4", Slot = "4")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x77BFAC", Offset = "0x77BFAC", VA = "0x77BFAC", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x77BFB0", Offset = "0x77BFB0", VA = "0x77BFB0", Slot = "5")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x77C030", Offset = "0x77C030", VA = "0x77C030")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x77BDEC", Offset = "0x77BDEC", VA = "0x77BDEC")]
		private void RaycastPosition(out Vector2 newPos)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x77C12C", Offset = "0x77C12C", VA = "0x77C12C")]
		public CUI_draggable()
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class CUI_inventory_paralax : MonoBehaviour
	{
		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform front;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform back;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 initFG;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 initBG;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float change;

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x77C134", Offset = "0x77C134", VA = "0x77C134")]
		private void Start()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x77C184", Offset = "0x77C184", VA = "0x77C184")]
		private void Update()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x77C388", Offset = "0x77C388", VA = "0x77C388")]
		public CUI_inventory_paralax()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class CurvedUIEventSystem : EventSystem
	{
		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static CurvedUIEventSystem instance;

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x77D8F8", Offset = "0x77D8F8", VA = "0x77D8F8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x77D954", Offset = "0x77D954", VA = "0x77D954")]
		public CurvedUIEventSystem()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public static class CurvedUIExtensionMethods
	{
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x77D9B8", Offset = "0x77D9B8", VA = "0x77D9B8")]
		public static bool AlmostEqual(this Vector3 a, Vector3 b, double accuracy = 0.01)
		{
			return default(bool);
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x77AF34", Offset = "0x77AF34", VA = "0x77AF34")]
		public static float Remap(this float value, float from1, float to1, float from2, float to2)
		{
			return default(float);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x77D9E8", Offset = "0x77D9E8", VA = "0x77D9E8")]
		public static float RemapAndClamp(this float value, float from1, float to1, float from2, float to2)
		{
			return default(float);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x77DA18", Offset = "0x77DA18", VA = "0x77DA18")]
		public static float Remap(this int value, float from1, float to1, float from2, float to2)
		{
			return default(float);
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x77DA38", Offset = "0x77DA38", VA = "0x77DA38")]
		public static double Remap(this double value, double from1, double to1, double from2, double to2)
		{
			return default(double);
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x77DA10", Offset = "0x77DA10", VA = "0x77DA10")]
		public static float Clamp(this float value, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x77DA54", Offset = "0x77DA54", VA = "0x77DA54")]
		public static float Clamp(this int value, int min, int max)
		{
			return default(float);
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x77DA70", Offset = "0x77DA70", VA = "0x77DA70")]
		public static int Abs(this int value)
		{
			return default(int);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x77DA78", Offset = "0x77DA78", VA = "0x77DA78")]
		public static float Abs(this float value)
		{
			return default(float);
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x77DA80", Offset = "0x77DA80", VA = "0x77DA80")]
		public static int ToInt(this float value)
		{
			return default(int);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x77DA88", Offset = "0x77DA88", VA = "0x77DA88")]
		public static int FloorToInt(this float value)
		{
			return default(int);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x77DA90", Offset = "0x77DA90", VA = "0x77DA90")]
		public static int CeilToInt(this float value)
		{
			return default(int);
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x77A274", Offset = "0x77A274", VA = "0x77A274")]
		public static Vector3 ModifyX(this Vector3 trans, float newVal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x77A27C", Offset = "0x77A27C", VA = "0x77A27C")]
		public static Vector3 ModifyY(this Vector3 trans, float newVal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x77A26C", Offset = "0x77A26C", VA = "0x77A26C")]
		public static Vector3 ModifyZ(this Vector3 trans, float newVal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x77DA98", Offset = "0x77DA98", VA = "0x77DA98")]
		public static Vector2 ModifyVectorX(this Vector2 trans, float newVal)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x77DAA0", Offset = "0x77DAA0", VA = "0x77DAA0")]
		public static Vector2 ModifyVectorY(this Vector2 trans, float newVal)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x779B14", Offset = "0x779B14", VA = "0x779B14")]
		public static void ResetTransform(this Transform trans)
		{
		}

		[Token(Token = "0x6000283")]
		public static T AddComponentIfMissing<T>(this GameObject go) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000284")]
		public static T AddComponentIfMissing<T>(this Component go) where T : Component
		{
			return null;
		}
	}
	[Token(Token = "0x2000084")]
	public class CurvedUIHandSwitcher : MonoBehaviour
	{
		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject LaserBeam;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x50463C", Offset = "0x50463C")]
		[SerializeField]
		private bool autoSwitchHands;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x504688", Offset = "0x504688")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x504688", Offset = "0x504688")]
		[SerializeField]
		private Transform leftHandOverride;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5046F8", Offset = "0x5046F8")]
		private Transform rightHandOverride;

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x77DAA8", Offset = "0x77DAA8", VA = "0x77DAA8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x77DDDC", Offset = "0x77DDDC", VA = "0x77DDDC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x77DB18", Offset = "0x77DB18", VA = "0x77DB18")]
		private void SwitchHandTo(CurvedUIInputModule.Hand newHand)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x77E30C", Offset = "0x77E30C", VA = "0x77E30C")]
		public CurvedUIHandSwitcher()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class CurvedUIInputFieldCaret : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
	{
		[Token(Token = "0x2000086")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x504018", Offset = "0x504018")]
		private sealed class <CaretBlinker>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000296")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000297")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000298")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CurvedUIInputFieldCaret <>4__this;

			[Token(Token = "0x17000060")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600029B")]
				[Address(RVA = "0xE93C00", Offset = "0xE93C00", VA = "0xE93C00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000061")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600029D")]
				[Address(RVA = "0xE93C48", Offset = "0xE93C48", VA = "0xE93C48", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000298")]
			[Address(RVA = "0xE93ABC", Offset = "0xE93ABC", VA = "0xE93ABC")]
			[DebuggerHidden]
			public <CaretBlinker>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000299")]
			[Address(RVA = "0xE93AE8", Offset = "0xE93AE8", VA = "0xE93AE8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600029A")]
			[Address(RVA = "0xE93AEC", Offset = "0xE93AEC", VA = "0xE93AEC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600029C")]
			[Address(RVA = "0xE93C08", Offset = "0xE93C08", VA = "0xE93C08", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private InputField myField;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform myCaret;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color origCaretColor;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color origSelectionColor;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool selected;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool selectingText;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int lastCharDist;

		[Token(Token = "0x1700005D")]
		public Color CaretColor
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x77ED04", Offset = "0x77ED04", VA = "0x77ED04")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x77ED10", Offset = "0x77ED10", VA = "0x77ED10")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public Color SelectionColor
		{
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x77ED1C", Offset = "0x77ED1C", VA = "0x77ED1C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x77ED28", Offset = "0x77ED28", VA = "0x77ED28")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public float CaretBlinkRate
		{
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x77ED34", Offset = "0x77ED34", VA = "0x77ED34")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000296")]
			[Address(RVA = "0x77ED50", Offset = "0x77ED50", VA = "0x77ED50")]
			set
			{
			}
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x77E31C", Offset = "0x77E31C", VA = "0x77E31C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x77E370", Offset = "0x77E370", VA = "0x77E370")]
		private void Update()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x77E648", Offset = "0x77E648", VA = "0x77E648", Slot = "4")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x77EA8C", Offset = "0x77EA8C", VA = "0x77EA8C", Slot = "5")]
		public void OnDeselect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x77EA20", Offset = "0x77EA20", VA = "0x77EA20")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x505FAC", Offset = "0x505FAC")]
		private IEnumerator CaretBlinker()
		{
			return null;
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x77E704", Offset = "0x77E704", VA = "0x77E704")]
		private void CreateCaret()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x77E380", Offset = "0x77E380", VA = "0x77E380")]
		private void UpdateCaret()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x77EAC4", Offset = "0x77EAC4", VA = "0x77EAC4")]
		private Vector2 GetLocalPositionInText(int charNo)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x77ED6C", Offset = "0x77ED6C", VA = "0x77ED6C")]
		public CurvedUIInputFieldCaret()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class CurvedUILaserBeam : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000088")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x504028", Offset = "0x504028")]
		private sealed class <>c
		{
			[Token(Token = "0x400029C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400029D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<GameObject> <>9__3_0;

			[Token(Token = "0x60002A1")]
			[Address(RVA = "0xE93CB0", Offset = "0xE93CB0", VA = "0xE93CB0")]
			public <>c()
			{
			}

			[Token(Token = "0x60002A2")]
			[Address(RVA = "0xE93CB8", Offset = "0xE93CB8", VA = "0xE93CB8")]
			internal bool <Update>b__3_0(GameObject x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform LaserBeamTransform;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform LaserBeamDot;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool hideWhenNotAimingAtCanvas;

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x781524", Offset = "0x781524", VA = "0x781524")]
		protected void Update()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x781AA4", Offset = "0x781AA4", VA = "0x781AA4")]
		public CurvedUILaserBeam()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class CurvedUIPhysicsRaycaster : BaseRaycaster
	{
		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected int sortOrder;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private RaycastHit hitInfo;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RaycastResult result;

		[Token(Token = "0x17000062")]
		public int CompoundEventMask
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x781DBC", Offset = "0x781DBC", VA = "0x781DBC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000063")]
		public override Camera eventCamera
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x781EC0", Offset = "0x781EC0", VA = "0x781EC0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		public virtual int Depth
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x781F90", Offset = "0x781F90", VA = "0x781F90", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000065")]
		public override int sortOrderPriority
		{
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x782064", Offset = "0x782064", VA = "0x782064", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x781AAC", Offset = "0x781AAC", VA = "0x781AAC")]
		protected CurvedUIPhysicsRaycaster()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x781ABC", Offset = "0x781ABC", VA = "0x781ABC", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class CurvedUIPointerEventData : PointerEventData
	{
		[Token(Token = "0x200008B")]
		public enum ControllerType
		{
			[Token(Token = "0x40002A4")]
			NONE = -1,
			[Token(Token = "0x40002A5")]
			VIVE
		}

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public GameObject Controller;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public Vector2 TouchPadAxis;

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x78206C", Offset = "0x78206C", VA = "0x78206C")]
		public CurvedUIPointerEventData(EventSystem eventSystem)
		{
		}
	}
	[Token(Token = "0x200008C")]
	public class CurvedUIRaycaster : GraphicRaycaster
	{
		[Serializable]
		[Token(Token = "0x200008D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x504038", Offset = "0x504038")]
		private sealed class <>c
		{
			[Token(Token = "0x40002BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40002BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<GameObject> <>9__21_0;

			[Token(Token = "0x40002BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Comparison<Graphic> <>9__32_0;

			[Token(Token = "0x40002BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Comparison<Graphic> <>9__55_0;

			[Token(Token = "0x60002D1")]
			[Address(RVA = "0xE93E14", Offset = "0xE93E14", VA = "0xE93E14")]
			public <>c()
			{
			}

			[Token(Token = "0x60002D2")]
			[Address(RVA = "0xE93E1C", Offset = "0xE93E1C", VA = "0xE93E1C")]
			internal bool <Update>b__21_0(GameObject obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60002D3")]
			[Address(RVA = "0xE93EE8", Offset = "0xE93EE8", VA = "0xE93EE8")]
			internal int <FlatRaycastAndSort>b__32_0(Graphic g1, Graphic g2)
			{
				return default(int);
			}

			[Token(Token = "0x60002D4")]
			[Address(RVA = "0xE93F40", Offset = "0xE93F40", VA = "0xE93F40")]
			internal int <GetObjectsHitByRay>b__55_0(Graphic g1, Graphic g2)
			{
				return default(int);
			}
		}

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool showDebug;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool overrideEventData;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Canvas myCanvas;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 cyllinderMidPoint;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<GameObject> objectsUnderPointer;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector2 lastCanvasPos;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject colliderContainer;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private PointerEventData lastFrameEventData;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private PointerEventData curEventData;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private PointerEventData eventDataToUse;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Ray cachedRay;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Graphic gph;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<GameObject> selectablesUnderGaze;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<GameObject> selectablesUnderGazeLastFrame;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float objectsUnderGazeLastChangeTime;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private bool gazeClickExecuted;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		private bool pointingAtCanvas;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCE")]
		private bool pointingAtCanvasLastFrame;

		[NonSerialized]
		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private List<Graphic> m_RaycastResults;

		[NonSerialized]
		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<Graphic> s_SortedGraphics;

		[Token(Token = "0x17000066")]
		private Image GazeProgressImage
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x78308C", Offset = "0x78308C", VA = "0x78308C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		public bool PointingAtCanvas
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x789598", Offset = "0x789598", VA = "0x789598")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x7820A8", Offset = "0x7820A8", VA = "0x7820A8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x7822D0", Offset = "0x7822D0", VA = "0x7822D0", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x782AC8", Offset = "0x782AC8", VA = "0x782AC8", Slot = "22")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x782EC8", Offset = "0x782EC8", VA = "0x782EC8")]
		private void ProcessGazeTimedClick()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x782E9C", Offset = "0x782E9C", VA = "0x782E9C")]
		private void ResetGazeTimedClick()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x783688", Offset = "0x783688", VA = "0x783688", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x784918", Offset = "0x784918", VA = "0x784918", Slot = "23")]
		public virtual bool RaycastToCyllinderCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x785028", Offset = "0x785028", VA = "0x785028", Slot = "24")]
		public virtual bool RaycastToCyllinderVerticalCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x785630", Offset = "0x785630", VA = "0x785630", Slot = "25")]
		public virtual bool RaycastToRingCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x785B44", Offset = "0x785B44", VA = "0x785B44", Slot = "26")]
		public virtual bool RaycastToSphereCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x784374", Offset = "0x784374", VA = "0x784374")]
		private void FlatRaycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x78644C", Offset = "0x78644C", VA = "0x78644C")]
		private static void FlatRaycastAndSort(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x782564", Offset = "0x782564", VA = "0x782564")]
		protected void CreateCollider()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x787F0C", Offset = "0x787F0C", VA = "0x787F0C")]
		private void SetupMeshColliderUsingMesh(Mesh meshie)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x78699C", Offset = "0x78699C", VA = "0x78699C")]
		private GameObject CreateConvexCyllinderCollider(bool vertical = false)
		{
			return null;
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x787564", Offset = "0x787564", VA = "0x787564")]
		private Mesh CreateCyllinderColliderMesh(bool vertical = false)
		{
			return null;
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x787FC4", Offset = "0x787FC4", VA = "0x787FC4")]
		private Mesh CreateSphereColliderMesh()
		{
			return null;
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x788BA0", Offset = "0x788BA0", VA = "0x788BA0")]
		private bool IsInLayerMask(int layer, LayerMask layermask)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x784F1C", Offset = "0x784F1C", VA = "0x784F1C")]
		private LayerMask GetRaycastLayerMask()
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x784F84", Offset = "0x784F84", VA = "0x784F84")]
		private float AngleSigned(Vector3 v1, Vector3 v2, Vector3 n)
		{
			return default(float);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x788BF8", Offset = "0x788BF8", VA = "0x788BF8")]
		private bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x788C48", Offset = "0x788C48", VA = "0x788C48", Slot = "27")]
		protected virtual void ProcessMove(PointerEventData pointerEvent)
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x783DD0", Offset = "0x783DD0", VA = "0x783DD0")]
		protected void UpdateSelectedObjects(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x788C60", Offset = "0x788C60", VA = "0x788C60")]
		protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x7892C0", Offset = "0x7892C0", VA = "0x7892C0")]
		protected static GameObject FindCommonRoot(GameObject g1, GameObject g2)
		{
			return null;
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x789464", Offset = "0x789464", VA = "0x789464")]
		private bool GetScreenSpacePointByRay(Ray ray, out Vector2 o_positionOnCanvas)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x78235C", Offset = "0x78235C", VA = "0x78235C")]
		private bool CheckEventCamera()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x7895A0", Offset = "0x7895A0", VA = "0x7895A0")]
		public void RebuildCollider()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x77A1F0", Offset = "0x77A1F0", VA = "0x77A1F0")]
		public List<GameObject> GetObjectsUnderPointer()
		{
			return null;
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x7895DC", Offset = "0x7895DC", VA = "0x7895DC")]
		public List<GameObject> GetObjectsUnderScreenPos(Vector2 screenPos, [Optional] Camera eventCamera)
		{
			return null;
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x7896C4", Offset = "0x7896C4", VA = "0x7896C4")]
		public List<GameObject> GetObjectsHitByRay(Ray ray)
		{
			return null;
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x7830F4", Offset = "0x7830F4", VA = "0x7830F4")]
		public void Click()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x788874", Offset = "0x788874", VA = "0x788874")]
		private void ModifyQuad(List<Vector3> verts, int vertexIndex, Vector2 requiredSize)
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x789BB0", Offset = "0x789BB0", VA = "0x789BB0")]
		private Vector3 TesselateQuad(List<Vector3> quad, float x, float y)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x789D64", Offset = "0x789D64", VA = "0x789D64")]
		public CurvedUIRaycaster()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x504048", Offset = "0x504048")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x504048", Offset = "0x504048")]
	public class CurvedUISettings : MonoBehaviour
	{
		[Token(Token = "0x200008F")]
		public enum CurvedUIShape
		{
			[Token(Token = "0x40002D1")]
			CYLINDER,
			[Token(Token = "0x40002D2")]
			RING,
			[Token(Token = "0x40002D3")]
			SPHERE,
			[Token(Token = "0x40002D4")]
			CYLINDER_VERTICAL
		}

		[Token(Token = "0x40002BF")]
		public const string Version = "3.3";

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CurvedUIShape shape;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float quality;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool interactable;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool blocksRaycasts;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		[SerializeField]
		private bool forceUseBoxCollider;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int angle;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool preserveAspect;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int vertAngle;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float ringFill;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int ringExternalDiamater;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool ringFlipVertical;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int baseCircleSegments;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector2 savedRectSize;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float savedRadius;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Canvas myCanvas;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform m_rectTransform;

		[Token(Token = "0x17000068")]
		private RectTransform RectTransform
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x789FA8", Offset = "0x789FA8", VA = "0x789FA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		public int BaseCircleSegments
		{
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x78B178", Offset = "0x78B178", VA = "0x78B178")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700006A")]
		public int Angle
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x78B180", Offset = "0x78B180", VA = "0x78B180")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x78B188", Offset = "0x78B188", VA = "0x78B188")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public float Quality
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x78B19C", Offset = "0x78B19C", VA = "0x78B19C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x78B1A4", Offset = "0x78B1A4", VA = "0x78B1A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public CurvedUIShape Shape
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x78B1C0", Offset = "0x78B1C0", VA = "0x78B1C0")]
			get
			{
				return default(CurvedUIShape);
			}
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x78B1C8", Offset = "0x78B1C8", VA = "0x78B1C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public int VerticalAngle
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x78B1E8", Offset = "0x78B1E8", VA = "0x78B1E8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x78B1F0", Offset = "0x78B1F0", VA = "0x78B1F0")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public float RingFill
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x78B210", Offset = "0x78B210", VA = "0x78B210")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x778E08", Offset = "0x778E08", VA = "0x778E08")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public float SavedRadius
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x78A990", Offset = "0x78A990", VA = "0x78A990")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000070")]
		public int RingExternalDiameter
		{
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x78B218", Offset = "0x78B218", VA = "0x78B218")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x78B220", Offset = "0x78B220", VA = "0x78B220")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public bool RingFlipVertical
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x78B240", Offset = "0x78B240", VA = "0x78B240")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x78B248", Offset = "0x78B248", VA = "0x78B248")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public bool PreserveAspect
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x78B274", Offset = "0x78B274", VA = "0x78B274")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x78B27C", Offset = "0x78B27C", VA = "0x78B27C")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public bool Interactable
		{
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x78B2A8", Offset = "0x78B2A8", VA = "0x78B2A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x78B2B0", Offset = "0x78B2B0", VA = "0x78B2B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public bool ForceUseBoxCollider
		{
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x78B2BC", Offset = "0x78B2BC", VA = "0x78B2BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x78B2C4", Offset = "0x78B2C4", VA = "0x78B2C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public bool BlocksRaycasts
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x78B2D0", Offset = "0x78B2D0", VA = "0x78B2D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x78B2D8", Offset = "0x78B2D8", VA = "0x78B2D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x506144", Offset = "0x506144")]
		public bool RaycastMyLayerOnly
		{
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x78B3C8", Offset = "0x78B3C8", VA = "0x78B3C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000301")]
			[Address(RVA = "0x78B3D0", Offset = "0x78B3D0", VA = "0x78B3D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public bool PointingAtCanvas
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x78B494", Offset = "0x78B494", VA = "0x78B494")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000078")]
		public CurvedUIInputModule.CUIControlMethod ControlMethod
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x789268", Offset = "0x789268", VA = "0x789268")]
			get
			{
				return default(CurvedUIInputModule.CUIControlMethod);
			}
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x78B66C", Offset = "0x78B66C", VA = "0x78B66C")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public bool GazeUseTimedClick
		{
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x78B964", Offset = "0x78B964", VA = "0x78B964")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600030B")]
			[Address(RVA = "0x78B9CC", Offset = "0x78B9CC", VA = "0x78B9CC")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public float GazeClickTimer
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0x78BA3C", Offset = "0x78BA3C", VA = "0x78BA3C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x78BAA4", Offset = "0x78BAA4", VA = "0x78BAA4")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public float GazeClickTimerDelay
		{
			[Token(Token = "0x600030E")]
			[Address(RVA = "0x78BB2C", Offset = "0x78BB2C", VA = "0x78BB2C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600030F")]
			[Address(RVA = "0x78BB94", Offset = "0x78BB94", VA = "0x78BB94")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public float GazeTimerProgress
		{
			[Token(Token = "0x6000310")]
			[Address(RVA = "0x78BC1C", Offset = "0x78BC1C", VA = "0x78BC1C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x789F1C", Offset = "0x789F1C", VA = "0x789F1C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x78A05C", Offset = "0x78A05C", VA = "0x78A05C")]
		private void Start()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x78A408", Offset = "0x78A408", VA = "0x78A408")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x78A4B4", Offset = "0x78A4B4", VA = "0x78A4B4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x78A560", Offset = "0x78A560", VA = "0x78A560")]
		private void Update()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x78A68C", Offset = "0x78A68C", VA = "0x78A68C")]
		private void SetUIAngle(int newAngle)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x78A8A8", Offset = "0x78A8A8", VA = "0x78A8A8")]
		private Vector3 CanvasToCyllinder(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x78A9C0", Offset = "0x78A9C0", VA = "0x78A9C0")]
		private Vector3 CanvasToCyllinderVertical(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x78AAA8", Offset = "0x78AAA8", VA = "0x78AAA8")]
		private Vector3 CanvasToRing(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x78AB88", Offset = "0x78AB88", VA = "0x78AB88")]
		private Vector3 CanvasToSphere(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x78AD10", Offset = "0x78AD10", VA = "0x78AD10")]
		public void AddEffectToChildren()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x78B0D0", Offset = "0x78B0D0", VA = "0x78B0D0")]
		public Vector3 VertexPositionToCurvedCanvas(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x77AB50", Offset = "0x77AB50", VA = "0x77AB50")]
		public Vector3 CanvasToCurvedCanvas(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x77AC10", Offset = "0x77AC10", VA = "0x77AC10")]
		public Vector3 CanvasToCurvedCanvasNormal(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x779B70", Offset = "0x779B70", VA = "0x779B70")]
		public bool RaycastToCanvasSpace(Ray ray, out Vector2 o_positionOnCanvas)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x782198", Offset = "0x782198", VA = "0x782198")]
		public float GetCyllinderRadiusInCanvasSpace()
		{
			return default(float);
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x7885DC", Offset = "0x7885DC", VA = "0x7885DC")]
		public Vector2 GetTesslationSize(bool modifiedByQuality = true)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x78B108", Offset = "0x78B108", VA = "0x78B108")]
		private float GetSegmentsByAngle(float angle)
		{
			return default(float);
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x78B3D4", Offset = "0x78B3D4", VA = "0x78B3D4")]
		public void SetAllChildrenDirty(bool recalculateCurveOnly = false)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x78B5A8", Offset = "0x78B5A8", VA = "0x78B5A8")]
		public void Click()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x7819A0", Offset = "0x7819A0", VA = "0x7819A0")]
		public List<GameObject> GetObjectsUnderPointer()
		{
			return null;
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x78B6CC", Offset = "0x78B6CC", VA = "0x78B6CC")]
		public List<GameObject> GetObjectsUnderScreenPos(Vector2 pos, [Optional] Camera eventCamera)
		{
			return null;
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x78B834", Offset = "0x78B834", VA = "0x78B834")]
		public List<GameObject> GetObjectsHitByRay(Ray ray)
		{
			return null;
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x78BC84", Offset = "0x78BC84", VA = "0x78BC84")]
		public CurvedUISettings()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class CurvedUIVertexEffect : BaseMeshEffect
	{
		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x504844", Offset = "0x504844")]
		public bool DoNotTesselate;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Canvas myCanvas;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Graphic myGraphic;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Text myText;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI myTMP;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CurvedUITMPSubmesh myTMPSubMesh;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_tesselationRequired;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool curvingRequired;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool TransformMisaligned;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Matrix4x4 CanvasToWorld;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Matrix4x4 CanvasToLocal;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Matrix4x4 MyToWorld;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Matrix4x4 MyToLocal;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private List<UIVertex> m_tesselatedVerts;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private List<UIVertex> m_curvedVerts;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private List<UIVertex> m_vertsInQuads;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private UIVertex m_ret;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private UIVertex[] m_quad;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private float[] m_weights;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		[HideInInspector]
		private Vector3 savedPos;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		[SerializeField]
		[HideInInspector]
		private Vector3 savedUp;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		[SerializeField]
		[HideInInspector]
		private Vector2 savedRectSize;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		[SerializeField]
		[HideInInspector]
		private Color savedColor;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		[SerializeField]
		[HideInInspector]
		private Vector4 savedTextUV0;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		[HideInInspector]
		[SerializeField]
		private float savedFill;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
		private Vector4 _uv0;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24C")]
		private Vector4 _uv1;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
		private Vector3 _pos;

		[Token(Token = "0x1700007D")]
		private bool tesselationRequired
		{
			[Token(Token = "0x6000312")]
			[Address(RVA = "0xE7C210", Offset = "0xE7C210", VA = "0xE7C210")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000313")]
			[Address(RVA = "0xE7C218", Offset = "0xE7C218", VA = "0xE7C218")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public bool TesselationRequired
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0xE7EE10", Offset = "0xE7EE10", VA = "0xE7EE10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000327")]
			[Address(RVA = "0xE7EE04", Offset = "0xE7EE04", VA = "0xE7EE04")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public bool CurvingRequired
		{
			[Token(Token = "0x6000328")]
			[Address(RVA = "0xE7EE18", Offset = "0xE7EE18", VA = "0xE7EE18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000329")]
			[Address(RVA = "0xE7EE20", Offset = "0xE7EE20", VA = "0xE7EE20")]
			set
			{
			}
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xE7C224", Offset = "0xE7C224", VA = "0xE7C224", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xE7C2F0", Offset = "0xE7C2F0", VA = "0xE7C2F0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xE7C5DC", Offset = "0xE7C5DC", VA = "0xE7C5DC", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xE7CBD8", Offset = "0xE7CBD8", VA = "0xE7CBD8", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xE7CD90", Offset = "0xE7CD90", VA = "0xE7CD90")]
		private void TesselationRequiredCallback()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xE7CD9C", Offset = "0xE7CD9C", VA = "0xE7CD9C")]
		private void FontTextureRebuiltCallback(Font fontie)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xE7CE3C", Offset = "0xE7CE3C", VA = "0xE7CE3C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xE7D39C", Offset = "0xE7D39C", VA = "0xE7D39C", Slot = "20")]
		public override void ModifyMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xE7AAF8", Offset = "0xE7AAF8", VA = "0xE7AAF8")]
		public void ModifyTMPMesh(ref List<UIVertex> vertexList)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xE7DA84", Offset = "0xE7DA84", VA = "0xE7DA84")]
		private bool ShouldModify()
		{
			return default(bool);
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xE7DB84", Offset = "0xE7DB84", VA = "0xE7DB84")]
		private void CheckTextFontMaterial()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xE7C4CC", Offset = "0xE7C4CC", VA = "0xE7C4CC")]
		public CurvedUISettings FindParentSettings(bool forceNew = false)
		{
			return null;
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xE7DFFC", Offset = "0xE7DFFC", VA = "0xE7DFFC")]
		private UIVertex CurveVertex(UIVertex input, float cylinder_angle, float radius, Vector2 canvasSize)
		{
			return default(UIVertex);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xE7DE28", Offset = "0xE7DE28", VA = "0xE7DE28")]
		private void TesselateGeometry(List<UIVertex> verts)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xE7E5BC", Offset = "0xE7E5BC", VA = "0xE7E5BC")]
		private void ModifyQuad(List<UIVertex> verts, int vertexIndex, Vector2 requiredSize)
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xE7E324", Offset = "0xE7E324", VA = "0xE7E324")]
		private void TrisToQuads(List<UIVertex> verts)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xE7EA94", Offset = "0xE7EA94", VA = "0xE7EA94")]
		private UIVertex TesselateQuad(float x, float y)
		{
			return default(UIVertex);
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xE7EDF8", Offset = "0xE7EDF8", VA = "0xE7EDF8")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xE7EE2C", Offset = "0xE7EE2C", VA = "0xE7EE2C")]
		public CurvedUIVertexEffect()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class CurvedUIViveController : MonoBehaviour
	{
		[Token(Token = "0x600032B")]
		[Address(RVA = "0xE7EF2C", Offset = "0xE7EF2C", VA = "0xE7EF2C")]
		public CurvedUIViveController()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public struct ViveInputArgs
	{
		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint controllerIndex;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float buttonPressure;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector2 touchpadAxis;
	}
	[Token(Token = "0x2000093")]
	public delegate void ViveInputEvent(object sender, ViveInputArgs e);
	[Token(Token = "0x2000094")]
	public delegate void ViveEvent(object sender);
	[Token(Token = "0x2000095")]
	[ExecuteInEditMode]
	public class CurvedUITMP : MonoBehaviour
	{
		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CurvedUIVertexEffect crvdVE;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextMeshProUGUI tmpText;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<UIVertex> m_UIVerts;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UIVertex m_tempVertex;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private CurvedUITMPSubmesh m_tempSubMsh;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector2 savedSize;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 savedUp;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Vector3 savedPos;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 savedLocalScale;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 savedGlobalScale;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private List<CurvedUITMPSubmesh> subMeshes;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public bool Dirty;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		private bool curvingRequired;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF2")]
		private bool tesselationRequired;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF3")]
		private bool quitting;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Vector3[] vertices;

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xE79B74", Offset = "0xE79B74", VA = "0xE79B74")]
		private void Start()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xE79C0C", Offset = "0xE79C0C", VA = "0xE79C0C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xE79F2C", Offset = "0xE79F2C", VA = "0xE79F2C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xE7A0C8", Offset = "0xE7A0C8", VA = "0xE7A0C8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xE7A0D4", Offset = "0xE7A0D4", VA = "0xE7A0D4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xE7A8AC", Offset = "0xE7A8AC", VA = "0xE7A8AC")]
		private void CreateUIVertexList(Mesh mesh)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xE7B45C", Offset = "0xE7B45C", VA = "0xE7B45C")]
		private void GetUIVertexFromMesh(ref UIVertex vert, int i)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xE7AE10", Offset = "0xE7AE10", VA = "0xE7AE10")]
		private void FillMeshWithUIVertexList(Mesh mesh, List<UIVertex> list)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xE79DE0", Offset = "0xE79DE0", VA = "0xE79DE0")]
		private void FindTMP()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xE7AF84", Offset = "0xE7AF84", VA = "0xE7AF84")]
		private void FindSubmeshes()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xE7A5D8", Offset = "0xE7A5D8", VA = "0xE7A5D8")]
		private bool ShouldTesselate()
		{
			return default(bool);
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xE7B4AC", Offset = "0xE7B4AC", VA = "0xE7B4AC")]
		private void TMPTextChangedCallback(object obj)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xE7B4C8", Offset = "0xE7B4C8", VA = "0xE7B4C8")]
		private void TesselationRequiredCallback()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xE7B4D4", Offset = "0xE7B4D4", VA = "0xE7B4D4")]
		public CurvedUITMP()
		{
		}
	}
	[Token(Token = "0x2000096")]
	[ExecuteInEditMode]
	public class CurvedUITMPInputFieldCaret : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
	{
		[Token(Token = "0x2000097")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5040EC", Offset = "0x5040EC")]
		private sealed class <CaretBlinker>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400030C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400030D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400030E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CurvedUITMPInputFieldCaret <>4__this;

			[Token(Token = "0x17000083")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000355")]
				[Address(RVA = "0xE940DC", Offset = "0xE940DC", VA = "0xE940DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000084")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000357")]
				[Address(RVA = "0xE94124", Offset = "0xE94124", VA = "0xE94124", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000352")]
			[Address(RVA = "0xE93F98", Offset = "0xE93F98", VA = "0xE93F98")]
			[DebuggerHidden]
			public <CaretBlinker>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000353")]
			[Address(RVA = "0xE93FC4", Offset = "0xE93FC4", VA = "0xE93FC4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000354")]
			[Address(RVA = "0xE93FC8", Offset = "0xE93FC8", VA = "0xE93FC8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000356")]
			[Address(RVA = "0xE940E4", Offset = "0xE940E4", VA = "0xE940E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_InputField myField;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform myCaret;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color origCaretColor;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color origSelectionColor;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool selected;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool selectingText;

		[Token(Token = "0x17000080")]
		public Color CaretColor
		{
			[Token(Token = "0x600034B")]
			[Address(RVA = "0xE7C198", Offset = "0xE7C198", VA = "0xE7C198")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600034C")]
			[Address(RVA = "0xE7C1A4", Offset = "0xE7C1A4", VA = "0xE7C1A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public Color SelectionColor
		{
			[Token(Token = "0x600034D")]
			[Address(RVA = "0xE7C1B0", Offset = "0xE7C1B0", VA = "0xE7C1B0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600034E")]
			[Address(RVA = "0xE7C1BC", Offset = "0xE7C1BC", VA = "0xE7C1BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public float CaretBlinkRate
		{
			[Token(Token = "0x600034F")]
			[Address(RVA = "0xE7C1C8", Offset = "0xE7C1C8", VA = "0xE7C1C8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000350")]
			[Address(RVA = "0xE7C1E4", Offset = "0xE7C1E4", VA = "0xE7C1E4")]
			set
			{
			}
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xE7B58C", Offset = "0xE7B58C", VA = "0xE7B58C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xE7B9C4", Offset = "0xE7B9C4", VA = "0xE7B9C4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xE7BC7C", Offset = "0xE7BC7C", VA = "0xE7BC7C", Slot = "4")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xE7C0E0", Offset = "0xE7C0E0", VA = "0xE7C0E0", Slot = "5")]
		public void OnDeselect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xE7C074", Offset = "0xE7C074", VA = "0xE7C074")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x50605C", Offset = "0x50605C")]
		private IEnumerator CaretBlinker()
		{
			return null;
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xE7BD38", Offset = "0xE7BD38", VA = "0xE7BD38")]
		private void CreateCaret()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xE7B9D4", Offset = "0xE7B9D4", VA = "0xE7B9D4")]
		private void UpdateCaret()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xE7C118", Offset = "0xE7C118", VA = "0xE7C118")]
		private Vector2 GetLocalPositionInText(int charNo)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xE7B630", Offset = "0xE7B630", VA = "0xE7B630")]
		private void CheckAndConvertMask()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xE7C200", Offset = "0xE7C200", VA = "0xE7C200")]
		public CurvedUITMPInputFieldCaret()
		{
		}
	}
	[Token(Token = "0x2000098")]
	[ExecuteInEditMode]
	public class CurvedUITMPSubmesh : MonoBehaviour
	{
		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private VertexHelper vh;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Mesh straightMesh;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Mesh curvedMesh;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CurvedUIVertexEffect crvdVE;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TMP_SubMeshUI TMPsub;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMeshProUGUI TMPtext;

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xE7B0B0", Offset = "0xE7B0B0", VA = "0xE7B0B0")]
		public void UpdateSubmesh(bool tesselate, bool curve)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xE7C208", Offset = "0xE7C208", VA = "0xE7C208")]
		public CurvedUITMPSubmesh()
		{
		}
	}
	[Token(Token = "0x2000099")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x50410C", Offset = "0x50410C")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x50410C", Offset = "0x50410C")]
	public class OptionalDependencyAttribute : Attribute
	{
		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string dependentClass;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string define;

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xE88430", Offset = "0xE88430", VA = "0xE88430")]
		public OptionalDependencyAttribute(string dependentClass, string define)
		{
		}
	}
}
