using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CMF;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using MyShadow;
using Pathfinding;
using RootMotion.FinalIK;
using TMPro;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using Valve.VR;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class LookCamera : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speedNormal;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float speedFast;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float mouseSensitivityX;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float mouseSensitivityY;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float rotY;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x760118", Offset = "0x760118", VA = "0x760118")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x7601D4", Offset = "0x7601D4", VA = "0x7601D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x760338", Offset = "0x760338", VA = "0x760338")]
	public LookCamera()
	{
	}
}
[Token(Token = "0x2000003")]
[RequireComponent(typeof(CharacterController))]
public class FPSWalkerEnhanced : MonoBehaviour
{
	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float walkSpeed;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float runSpeed;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool limitDiagonalSpeed;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool toggleRun;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float jumpSpeed;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float gravity;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float fallingDamageThreshold;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool slideWhenOverSlopeLimit;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool slideOnTaggedObjects;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float slideSpeed;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool airControl;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float antiBumpFactor;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int antiBunnyHopFactor;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 moveDirection;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool grounded;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private CharacterController controller;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Transform myTransform;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float speed;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private RaycastHit hit;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float fallStartLevel;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private bool falling;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float slideLimit;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private float rayDistance;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Vector3 contactPoint;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private bool playerControl;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private int jumpTimer;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x76034C", Offset = "0x76034C", VA = "0x76034C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x76043C", Offset = "0x76043C", VA = "0x76043C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x760A54", Offset = "0x760A54", VA = "0x760A54")]
	private void Update()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x760AD0", Offset = "0x760AD0", VA = "0x760AD0")]
	private void OnControllerColliderHit(ControllerColliderHit hit)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x7609CC", Offset = "0x7609CC", VA = "0x7609CC")]
	private void FallingDamageAlert(float fallDistance)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x760AFC", Offset = "0x760AFC", VA = "0x760AFC")]
	public FPSWalkerEnhanced()
	{
	}
}
[Token(Token = "0x2000004")]
[AddComponentMenu("Camera-Control/Smooth Mouse Look")]
public class SmoothMouseLook : MonoBehaviour
{
	[Token(Token = "0x2000005")]
	public enum RotationAxes
	{
		[Token(Token = "0x4000031")]
		MouseXAndY,
		[Token(Token = "0x4000032")]
		MouseX,
		[Token(Token = "0x4000033")]
		MouseY
	}

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RotationAxes axes;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float sensitivityX;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float sensitivityY;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float minimumX;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float maximumX;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float minimumY;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float maximumY;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float rotationX;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float rotationY;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<float> rotArrayX;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float rotAverageX;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<float> rotArrayY;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float rotAverageY;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float frameCounter;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Quaternion originalRotation;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Quaternion parentOriginalRotation;

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x760B94", Offset = "0x760B94", VA = "0x760B94")]
	private void Update()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x761554", Offset = "0x761554", VA = "0x761554")]
	private void Start()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x7614D4", Offset = "0x7614D4", VA = "0x7614D4")]
	public static float ClampAngle(float angle, float min, float max)
	{
		return default(float);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x761648", Offset = "0x761648", VA = "0x761648")]
	public SmoothMouseLook()
	{
	}
}
[Token(Token = "0x2000006")]
public class SkyboxRotator : MonoBehaviour
{
	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float RotationPerSecond;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private bool _rotate;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x761720", Offset = "0x761720", VA = "0x761720")]
	protected void Update()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x7617A4", Offset = "0x7617A4", VA = "0x7617A4")]
	public void ToggleSkyboxRotation()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x7617B4", Offset = "0x7617B4", VA = "0x7617B4")]
	public SkyboxRotator()
	{
	}
}
[Token(Token = "0x2000007")]
public class SkyboxChanger : MonoBehaviour
{
	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material[] Skyboxes;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dropdown _dropdown;

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x7617C4", Offset = "0x7617C4", VA = "0x7617C4")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x76181C", Offset = "0x76181C", VA = "0x76181C")]
	public void ChangeSkybox()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x7618AC", Offset = "0x7618AC", VA = "0x7618AC")]
	public SkyboxChanger()
	{
	}
}
[Token(Token = "0x2000008")]
public class CeilingDetector : MonoBehaviour
{
	[Token(Token = "0x2000009")]
	public enum CeilingDetectionMethod
	{
		[Token(Token = "0x400003F")]
		OnlyCheckFirstContact,
		[Token(Token = "0x4000040")]
		CheckAllContacts,
		[Token(Token = "0x4000041")]
		CheckAverageOfAllContacts
	}

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool ceilingWasHit;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ceilingAngleLimit;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CeilingDetectionMethod ceilingDetectionMethod;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool isInDebugMode;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float debugDrawDuration;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform tr;

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x7618B4", Offset = "0x7618B4", VA = "0x7618B4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x7618D8", Offset = "0x7618D8", VA = "0x7618D8")]
	private void OnCollisionEnter(Collision _collision)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x761FF8", Offset = "0x761FF8", VA = "0x761FF8")]
	private void OnCollisionStay(Collision _collision)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x7618DC", Offset = "0x7618DC", VA = "0x7618DC")]
	private void CheckCollisionAngles(Collision _collision)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x761FFC", Offset = "0x761FFC", VA = "0x761FFC")]
	public bool HitCeiling()
	{
		return default(bool);
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x762004", Offset = "0x762004", VA = "0x762004")]
	public void ResetFlags()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x76200C", Offset = "0x76200C", VA = "0x76200C")]
	public CeilingDetector()
	{
	}
}
[Token(Token = "0x200000A")]
[ExecuteInEditMode]
public class CurvedUIInputModule : StandaloneInputModule
{
	[Token(Token = "0x200000B")]
	public enum CUIControlMethod
	{
		[Token(Token = "0x400005C")]
		MOUSE = 0,
		[Token(Token = "0x400005D")]
		GAZE = 1,
		[Token(Token = "0x400005E")]
		WORLD_MOUSE = 2,
		[Token(Token = "0x400005F")]
		CUSTOM_RAY = 3,
		[Token(Token = "0x4000060")]
		STEAMVR_LEGACY = 4,
		[Token(Token = "0x4000061")]
		OCULUSVR = 5,
		[Token(Token = "0x4000062")]
		GOOGLEVR = 7,
		[Token(Token = "0x4000063")]
		STEAMVR_2 = 8,
		[Token(Token = "0x4000064")]
		UNITY_XR = 9
	}

	[Token(Token = "0x200000C")]
	public enum Hand
	{
		[Token(Token = "0x4000066")]
		Both,
		[Token(Token = "0x4000067")]
		Right,
		[Token(Token = "0x4000068")]
		Left
	}

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	[SerializeField]
	private CUIControlMethod controlMethod;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private string submitButtonName;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private Camera mainEventCamera;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private bool gazeUseTimedClick;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	[SerializeField]
	private float gazeClickTimer;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private float gazeClickTimerDelay;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private Image gazeTimedClickProgressImage;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private float worldSpaceMouseSensitivity;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	[SerializeField]
	private Hand usedHand;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private Transform controllerTransformOverride;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool disableOtherInputModulesOnStart;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static CurvedUIInputModule instance;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private GameObject currentDragging;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private GameObject currentPointedAt;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private GameObject m_rightController;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private GameObject m_leftController;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private float gazeTimerProgress;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	private Ray customControllerRay;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private float dragThreshold;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private bool pressedDown;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x139")]
	private bool pressedLastFrame;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	private Vector3 lastMouseOnScreenPos;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private Vector2 worldSpaceMouseInCanvasSpace;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private Vector2 lastWorldSpaceMouseOnCanvas;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private Vector2 worldSpaceMouseOnCanvasDelta;

	[Token(Token = "0x17000001")]
	public static CurvedUIInputModule Instance
	{
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x7627D8", Offset = "0x7627D8", VA = "0x7627D8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x7628CC", Offset = "0x7628CC", VA = "0x7628CC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public static CUIControlMethod ControlMethod
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x762744", Offset = "0x762744", VA = "0x762744")]
		get
		{
			return default(CUIControlMethod);
		}
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x76292C", Offset = "0x76292C", VA = "0x76292C")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public Hand UsedHand
	{
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x7629B0", Offset = "0x7629B0", VA = "0x7629B0")]
		get
		{
			return default(Hand);
		}
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x7629B8", Offset = "0x7629B8", VA = "0x7629B8")]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public Transform ControllerTransform
	{
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x7629C0", Offset = "0x7629C0", VA = "0x7629C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000005")]
	public Vector3 ControllerPointingDirection
	{
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x762AE4", Offset = "0x762AE4", VA = "0x762AE4")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000006")]
	public Vector3 ControllerPointingOrigin
	{
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x762B88", Offset = "0x762B88", VA = "0x762B88")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000007")]
	public Transform ControllerTransformOverride
	{
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x762A80", Offset = "0x762A80", VA = "0x762A80")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x762C2C", Offset = "0x762C2C", VA = "0x762C2C")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public GameObject CurrentPointedAt
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x762C98", Offset = "0x762C98", VA = "0x762C98")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000009")]
	public Camera EventCamera
	{
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x762CA0", Offset = "0x762CA0", VA = "0x762CA0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x762170", Offset = "0x762170", VA = "0x762170")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public static Ray CustomControllerRay
	{
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x762E6C", Offset = "0x762E6C", VA = "0x762E6C")]
		get
		{
			return default(Ray);
		}
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x762EDC", Offset = "0x762EDC", VA = "0x762EDC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public static bool CustomControllerButtonState
	{
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x762F64", Offset = "0x762F64", VA = "0x762F64")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x762FC0", Offset = "0x762FC0", VA = "0x762FC0")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	[Obsolete("Use CustomControllerButtonState instead.")]
	public static bool CustomControllerButtonDown
	{
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x763024", Offset = "0x763024", VA = "0x763024")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x763080", Offset = "0x763080", VA = "0x763080")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public Vector2 WorldSpaceMouseInCanvasSpace
	{
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x7630E4", Offset = "0x7630E4", VA = "0x7630E4")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x7630F0", Offset = "0x7630F0", VA = "0x7630F0")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public Vector2 WorldSpaceMouseInCanvasSpaceDelta
	{
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x763104", Offset = "0x763104", VA = "0x763104")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x1700000F")]
	public float WorldSpaceMouseSensitivity
	{
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x763114", Offset = "0x763114", VA = "0x763114")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x76311C", Offset = "0x76311C", VA = "0x76311C")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public bool GazeUseTimedClick
	{
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x763124", Offset = "0x763124", VA = "0x763124")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x76312C", Offset = "0x76312C", VA = "0x76312C")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public float GazeClickTimer
	{
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x763138", Offset = "0x763138", VA = "0x763138")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x763140", Offset = "0x763140", VA = "0x763140")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public float GazeClickTimerDelay
	{
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x763150", Offset = "0x763150", VA = "0x763150")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x763158", Offset = "0x763158", VA = "0x763158")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public float GazeTimerProgress
	{
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x763168", Offset = "0x763168", VA = "0x763168")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000014")]
	public Image GazeTimedClickProgressImage
	{
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x763170", Offset = "0x763170", VA = "0x763170")]
		get
		{
			return null;
		}
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x763178", Offset = "0x763178", VA = "0x763178")]
		set
		{
		}
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x762024", Offset = "0x762024", VA = "0x762024", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x762220", Offset = "0x762220", VA = "0x762220", Slot = "32")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x76241C", Offset = "0x76241C", VA = "0x76241C", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x762448", Offset = "0x762448", VA = "0x762448", Slot = "17")]
	public override void Process()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x7625D8", Offset = "0x7625D8", VA = "0x7625D8", Slot = "33")]
	protected virtual void ProcessGaze()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x762634", Offset = "0x762634", VA = "0x762634", Slot = "34")]
	protected virtual void ProcessCustomRayController()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x76263C", Offset = "0x76263C", VA = "0x76263C", Slot = "28")]
	protected override MouseState GetMousePointerEventData(int id)
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x7627A0", Offset = "0x7627A0", VA = "0x7627A0")]
	private PointerEventData.FramePressState CustomRayFramePressedState()
	{
		return default(PointerEventData.FramePressState);
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x7627CC", Offset = "0x7627CC", VA = "0x7627CC", Slot = "35")]
	protected virtual void ProcessViveControllers()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x7627D0", Offset = "0x7627D0", VA = "0x7627D0", Slot = "36")]
	protected virtual void ProcessOculusVRController()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x7625D4", Offset = "0x7625D4", VA = "0x7625D4")]
	private void ProcessSteamVR2Controllers()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x7627D4", Offset = "0x7627D4", VA = "0x7627D4", Slot = "37")]
	protected virtual void ProcessUnityXRController()
	{
	}

	[Token(Token = "0x6000027")]
	private static T EnableInputModule<T>() where T : BaseInputModule
	{
		return null;
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x762CA8", Offset = "0x762CA8", VA = "0x762CA8")]
	public Ray GetEventRay([Optional] Camera eventCam)
	{
		return default(Ray);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x763180", Offset = "0x763180", VA = "0x763180")]
	public CurvedUIInputModule()
	{
	}
}
[Token(Token = "0x200000D")]
public class SeekerControls : IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
{
	[Token(Token = "0x200000E")]
	public struct GameplayActions
	{
		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private SeekerControls m_Wrapper;

		[Token(Token = "0x1700001B")]
		public InputAction Move
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x7636A0", Offset = "0x7636A0", VA = "0x7636A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public InputAction MoveCamera
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x7636BC", Offset = "0x7636BC", VA = "0x7636BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public bool enabled
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x76373C", Offset = "0x76373C", VA = "0x76373C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x763698", Offset = "0x763698", VA = "0x763698")]
		public GameplayActions(SeekerControls wrapper)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x7636D8", Offset = "0x7636D8", VA = "0x7636D8")]
		public InputActionMap Get()
		{
			return null;
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x7636F4", Offset = "0x7636F4", VA = "0x7636F4")]
		public void Enable()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x763718", Offset = "0x763718", VA = "0x763718")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x763760", Offset = "0x763760", VA = "0x763760")]
		public static implicit operator InputActionMap(GameplayActions set)
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x763778", Offset = "0x763778", VA = "0x763778")]
		public void SetCallbacks(IGameplayActions instance)
		{
		}
	}

	[Token(Token = "0x200000F")]
	public interface IGameplayActions
	{
		[Token(Token = "0x6000067")]
		void OnMove(InputAction.CallbackContext context);

		[Token(Token = "0x6000068")]
		void OnMoveCamera(InputAction.CallbackContext context);
	}

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly InputActionMap m_Gameplay;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private IGameplayActions m_GameplayActionsCallbackInterface;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly InputAction m_Gameplay_Move;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly InputAction m_Gameplay_MoveCamera;

	[Token(Token = "0x17000015")]
	public InputActionAsset asset
	{
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x7632AC", Offset = "0x7632AC", VA = "0x7632AC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000016")]
	public InputBinding? bindingMask
	{
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x763438", Offset = "0x763438", VA = "0x763438", Slot = "7")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x763460", Offset = "0x763460", VA = "0x763460", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public ReadOnlyArray<UnityEngine.InputSystem.InputDevice>? devices
	{
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x7634AC", Offset = "0x7634AC", VA = "0x7634AC", Slot = "9")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x7634EC", Offset = "0x7634EC", VA = "0x7634EC", Slot = "10")]
		set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public ReadOnlyArray<InputControlScheme> controlSchemes
	{
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x763538", Offset = "0x763538", VA = "0x763538", Slot = "11")]
		get
		{
			return default(ReadOnlyArray<InputControlScheme>);
		}
	}

	[Token(Token = "0x17000019")]
	public IEnumerable<InputBinding> bindings
	{
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x7635E0", Offset = "0x7635E0", VA = "0x7635E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001A")]
	public GameplayActions Gameplay
	{
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x763678", Offset = "0x763678", VA = "0x763678")]
		get
		{
			return default(GameplayActions);
		}
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x7632B4", Offset = "0x7632B4", VA = "0x7632B4")]
	public SeekerControls()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x7633DC", Offset = "0x7633DC", VA = "0x7633DC", Slot = "17")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x763554", Offset = "0x763554", VA = "0x763554", Slot = "12")]
	public bool Contains(InputAction action)
	{
		return default(bool);
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x763570", Offset = "0x763570", VA = "0x763570", Slot = "15")]
	public IEnumerator<InputAction> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x76358C", Offset = "0x76358C", VA = "0x76358C", Slot = "16")]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x7635A8", Offset = "0x7635A8", VA = "0x7635A8", Slot = "13")]
	public void Enable()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x7635C4", Offset = "0x7635C4", VA = "0x7635C4", Slot = "14")]
	public void Disable()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x7635FC", Offset = "0x7635FC", VA = "0x7635FC", Slot = "5")]
	public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x76361C", Offset = "0x76361C", VA = "0x76361C", Slot = "6")]
	public int FindBinding(InputBinding bindingMask, out InputAction action)
	{
		return default(int);
	}
}
[Token(Token = "0x2000010")]
public class CanvasCentralizer : MonoBehaviour
{
	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("All automated - visible for debugging")]
	[SerializeField]
	private GameObject centerPoint;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector3 centerPos;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Header("World Space Canvases")]
	private Canvas[] allCanvases;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<Canvas> wsCanvases;

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x763F0C", Offset = "0x763F0C", VA = "0x763F0C")]
	private void Start()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x7640B8", Offset = "0x7640B8", VA = "0x7640B8")]
	public void MoveCanvasesToCenter()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x764224", Offset = "0x764224", VA = "0x764224")]
	public CanvasCentralizer()
	{
	}
}
[Token(Token = "0x2000011")]
public class DialogueCharacters : MonoBehaviour
{
	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public GameObject[] dialogueCharacters;

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x7642AC", Offset = "0x7642AC", VA = "0x7642AC")]
	private void Start()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x764394", Offset = "0x764394", VA = "0x764394")]
	public DialogueCharacters()
	{
	}
}
[Token(Token = "0x2000012")]
public class DTTMovement : MonoBehaviour
{
	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("DevTestTool Config")]
	[SerializeField]
	private float moveSpeed;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float mouseSensitivity;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float defaultMoveSpeed;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Header("Drag DTT child camera here")]
	[SerializeField]
	private Camera cam;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float moveForward;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float moveSideways;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float moveUp;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[HideInInspector]
	public bool holdSeeker;

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x76439C", Offset = "0x76439C", VA = "0x76439C")]
	private void Start()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x7643A8", Offset = "0x7643A8", VA = "0x7643A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x7643AC", Offset = "0x7643AC", VA = "0x7643AC")]
	private void FPSMovement()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x764858", Offset = "0x764858", VA = "0x764858")]
	public DTTMovement()
	{
	}
}
[Token(Token = "0x2000013")]
public class DoorOpenerAtStart : MonoBehaviour
{
	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Animator m_Animator;

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x764860", Offset = "0x764860", VA = "0x764860")]
	private void Start()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x7648F0", Offset = "0x7648F0", VA = "0x7648F0")]
	public DoorOpenerAtStart()
	{
	}
}
[Token(Token = "0x2000014")]
public class DrillActivationDelay : MonoBehaviour
{
	[Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class <ResetButtonAndDrill>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float time;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DrillActivationDelay <>4__this;

		[Token(Token = "0x1700001E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x764B54", Offset = "0x764B54", VA = "0x764B54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x764B9C", Offset = "0x764B9C", VA = "0x764B9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x764A4C", Offset = "0x764A4C", VA = "0x764A4C")]
		[DebuggerHidden]
		public <ResetButtonAndDrill>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x764A84", Offset = "0x764A84", VA = "0x764A84", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x764A88", Offset = "0x764A88", VA = "0x764A88", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x764B5C", Offset = "0x764B5C", VA = "0x764B5C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool ButtonReady;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Animator DrillLoweringAnimator;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float activationDelay;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public UnityEvent DrillHasReseted;

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x7648F8", Offset = "0x7648F8", VA = "0x7648F8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x764904", Offset = "0x764904", VA = "0x764904")]
	public void DrillButtonPressed()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x7649C8", Offset = "0x7649C8", VA = "0x7649C8")]
	[IteratorStateMachine(typeof(<ResetButtonAndDrill>d__6))]
	private IEnumerator ResetButtonAndDrill(float time)
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x764A74", Offset = "0x764A74", VA = "0x764A74")]
	public DrillActivationDelay()
	{
	}
}
[Token(Token = "0x2000016")]
public class FreezeRigidBody : MonoBehaviour
{
	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Rigidbody m_Rigidbody;

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x764BA4", Offset = "0x764BA4", VA = "0x764BA4")]
	private void Start()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x764BFC", Offset = "0x764BFC", VA = "0x764BFC")]
	public void ResetZ()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x764C34", Offset = "0x764C34", VA = "0x764C34")]
	public void ResetX()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x764C6C", Offset = "0x764C6C", VA = "0x764C6C")]
	public void ResetY()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x764CA4", Offset = "0x764CA4", VA = "0x764CA4")]
	public void ResetAll()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x764CC4", Offset = "0x764CC4", VA = "0x764CC4")]
	public FreezeRigidBody()
	{
	}
}
[Token(Token = "0x2000017")]
public class FeedbackButton : MonoBehaviour
{
	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("FeedbackForm button")]
	[SerializeField]
	private GameObject feedbackButton;

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x764CCC", Offset = "0x764CCC", VA = "0x764CCC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x764DB8", Offset = "0x764DB8", VA = "0x764DB8")]
	public FeedbackButton()
	{
	}
}
[Token(Token = "0x2000018")]
public class FeedbackForm : MonoBehaviour
{
	[Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class <Post>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string s1;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public FeedbackForm <>4__this;

		[Token(Token = "0x17000020")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x76525C", Offset = "0x76525C", VA = "0x76525C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x7652A4", Offset = "0x7652A4", VA = "0x7652A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x765058", Offset = "0x765058", VA = "0x765058")]
		[DebuggerHidden]
		public <Post>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x7650D8", Offset = "0x7650D8", VA = "0x7650D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x7650DC", Offset = "0x7650DC", VA = "0x7650DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x765264", Offset = "0x765264", VA = "0x765264", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject inputField1;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Camera cam;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string feedback;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string URL;

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x764DC0", Offset = "0x764DC0", VA = "0x764DC0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x764E48", Offset = "0x764E48", VA = "0x764E48")]
	public void Send()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x764FF0", Offset = "0x764FF0", VA = "0x764FF0")]
	public void TestButton()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x764F60", Offset = "0x764F60", VA = "0x764F60")]
	[IteratorStateMachine(typeof(<Post>d__7))]
	private IEnumerator Post(string s1)
	{
		return null;
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x765080", Offset = "0x765080", VA = "0x765080")]
	public FeedbackForm()
	{
	}
}
[Token(Token = "0x200001A")]
public class FeedbackFormPanel : MonoBehaviour
{
	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("UI Panel with the form fields goes here ")]
	[SerializeField]
	private GameObject panel;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Header("Settings")]
	private bool pauseGame;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float defaultTime;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool feedbackPanelOpen;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject eventSystem;

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x7652AC", Offset = "0x7652AC", VA = "0x7652AC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x765304", Offset = "0x765304", VA = "0x765304")]
	private void Start()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x765320", Offset = "0x765320", VA = "0x765320")]
	private void Update()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x76542C", Offset = "0x76542C", VA = "0x76542C")]
	public void OpenFeedbackPanel()
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x765438", Offset = "0x765438", VA = "0x765438")]
	public void CloseFeedbackPanel()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x765440", Offset = "0x765440", VA = "0x765440")]
	public FeedbackFormPanel()
	{
	}
}
[Token(Token = "0x200001B")]
public class FollowTransform : MonoBehaviour
{
	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform transToFollow;

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x765448", Offset = "0x765448", VA = "0x765448")]
	private void Update()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x7654C4", Offset = "0x7654C4", VA = "0x7654C4")]
	public FollowTransform()
	{
	}
}
[Token(Token = "0x200001C")]
public class FPSCounter : MonoBehaviour
{
	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool startEnabled;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int maxFPS;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string _FPStext;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int _currentFPS;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string[] _fpsStrings;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float _previousFlushTime;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int _previousFrameCount;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private TextMeshProUGUI _fpsText;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Canvas _canvas;

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x7654CC", Offset = "0x7654CC", VA = "0x7654CC")]
	private void Start()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x7656C0", Offset = "0x7656C0", VA = "0x7656C0")]
	private void Update()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x765674", Offset = "0x765674", VA = "0x765674")]
	private void SetActive(bool status)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x7658D4", Offset = "0x7658D4", VA = "0x7658D4")]
	private void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x76598C", Offset = "0x76598C", VA = "0x76598C")]
	public FPSCounter()
	{
	}
}
[Token(Token = "0x200001D")]
public class AndroidManager : MonoBehaviour
{
	[Token(Token = "0x600009E")]
	[Address(RVA = "0x76599C", Offset = "0x76599C", VA = "0x76599C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x765E28", Offset = "0x765E28", VA = "0x765E28")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x765E78", Offset = "0x765E78", VA = "0x765E78")]
	private void SceneLoaded(Scene arg0, LoadSceneMode arg1)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x765B84", Offset = "0x765B84", VA = "0x765B84")]
	private void SetOnlyOneDirectional()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x765A78", Offset = "0x765A78", VA = "0x765A78")]
	private void ApplySettings()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x765E88", Offset = "0x765E88", VA = "0x765E88")]
	public AndroidManager()
	{
	}
}
[Token(Token = "0x200001E")]
public static class LevelLoadingData
{
	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string levelToLoad;
}
[Token(Token = "0x200001F")]
public class LevelLoadingScene : MonoBehaviour
{
	[Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class <LoadScene>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LevelLoadingScene <>4__this;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AsyncOperation <loadOperation>5__2;

		[Token(Token = "0x17000022")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x766270", Offset = "0x766270", VA = "0x766270", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x7662B8", Offset = "0x7662B8", VA = "0x7662B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x765FF0", Offset = "0x765FF0", VA = "0x765FF0")]
		[DebuggerHidden]
		public <LoadScene>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x766028", Offset = "0x766028", VA = "0x766028", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x76602C", Offset = "0x76602C", VA = "0x76602C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x766278", Offset = "0x766278", VA = "0x766278", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject levelNameTxt;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float loadingSceneMinDuration;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string nextLevelName;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string nextLevelNameLocalized;

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x765E90", Offset = "0x765E90", VA = "0x765E90")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x765F5C", Offset = "0x765F5C", VA = "0x765F5C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x765F7C", Offset = "0x765F7C", VA = "0x765F7C")]
	[IteratorStateMachine(typeof(<LoadScene>d__6))]
	private IEnumerator LoadScene()
	{
		return null;
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x766018", Offset = "0x766018", VA = "0x766018")]
	public LevelLoadingScene()
	{
	}
}
[Token(Token = "0x2000021")]
public class ParticleQualityManager : MonoBehaviour
{
	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x7662C0", Offset = "0x7662C0", VA = "0x7662C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x766418", Offset = "0x766418", VA = "0x766418")]
	public ParticleQualityManager()
	{
	}
}
[Token(Token = "0x2000022")]
public class PS5Manager : MonoBehaviour
{
	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x766420", Offset = "0x766420", VA = "0x766420")]
	public PS5Manager()
	{
	}
}
[Token(Token = "0x2000023")]
[ExecuteInEditMode]
public class helpscript : MonoBehaviour
{
	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform t;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float fixedRotation;

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x766428", Offset = "0x766428", VA = "0x766428")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x76644C", Offset = "0x76644C", VA = "0x76644C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x766498", Offset = "0x766498", VA = "0x766498")]
	public helpscript()
	{
	}
}
[Token(Token = "0x2000024")]
public class InputSystemOriginPlacer : MonoBehaviour
{
	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x7664A8", Offset = "0x7664A8", VA = "0x7664A8")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x766564", Offset = "0x766564", VA = "0x766564")]
	public InputSystemOriginPlacer()
	{
	}
}
[Token(Token = "0x2000025")]
public class IronBallMover : MonoBehaviour
{
	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Rigidbody ballRB;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float movementForce;

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x76656C", Offset = "0x76656C", VA = "0x76656C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x7665C4", Offset = "0x7665C4", VA = "0x7665C4")]
	public void MoveBall()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x76663C", Offset = "0x76663C", VA = "0x76663C")]
	public IronBallMover()
	{
	}
}
[Token(Token = "0x2000026")]
public class ItemSpawner : MonoBehaviour
{
	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject itemToSpawn;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 spawnPosition;

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x76664C", Offset = "0x76664C", VA = "0x76664C")]
	public void SpawnItem()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x766760", Offset = "0x766760", VA = "0x766760")]
	public ItemSpawner()
	{
	}
}
[Token(Token = "0x2000027")]
public class CSVLoader : ScriptableObject
{
	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TextAsset csvFile;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private char lineSeparator;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	private char wrapper;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string[] fieldSeparator;

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x766768", Offset = "0x766768", VA = "0x766768")]
	public void LoadCSV()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x7667DC", Offset = "0x7667DC", VA = "0x7667DC")]
	public Dictionary<string, string> GetDictionaryValues(string languageId)
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x766B8C", Offset = "0x766B8C", VA = "0x766B8C")]
	public CSVLoader()
	{
	}
}
[Token(Token = "0x2000028")]
public class LocalizationSystem : MonoBehaviour
{
	[Token(Token = "0x2000029")]
	public enum Language
	{
		[Token(Token = "0x40000C5")]
		English,
		[Token(Token = "0x40000C6")]
		Finnish,
		[Token(Token = "0x40000C7")]
		German,
		[Token(Token = "0x40000C8")]
		French,
		[Token(Token = "0x40000C9")]
		Spanish,
		[Token(Token = "0x40000CA")]
		Russian,
		[Token(Token = "0x40000CB")]
		Italian,
		[Token(Token = "0x40000CC")]
		Japan,
		[Token(Token = "0x40000CD")]
		Korean,
		[Token(Token = "0x40000CE")]
		BrazilianPortuguese,
		[Token(Token = "0x40000CF")]
		Thai,
		[Token(Token = "0x40000D0")]
		TraditionalChinese,
		[Token(Token = "0x40000D1")]
		SimplifiedChinese
	}

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static LocalizationSystem localizer;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static CSVLoader csvLoader;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TMP_FontAsset fontCyrillic;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Font txtFontCyrillic;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static Language language;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static Dictionary<string, string> textsEN;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static Dictionary<string, string> textsFI;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static Dictionary<string, string> textsDE;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static Dictionary<string, string> textsFR;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static Dictionary<string, string> textsES;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static Dictionary<string, string> textsRU;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static Dictionary<string, string> textsIT;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static Dictionary<string, string> textsJA;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static Dictionary<string, string> textsKO;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public static Dictionary<string, string> textsPT_BR;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public static Dictionary<string, string> textsTH;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static Dictionary<string, string> textsZH_CN;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static Dictionary<string, string> textsZH_TW;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public static bool isInitialized;

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x766C70", Offset = "0x766C70", VA = "0x766C70")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x766E4C", Offset = "0x766E4C", VA = "0x766E4C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x7670FC", Offset = "0x7670FC", VA = "0x7670FC")]
	private void SetUnityDefaultLanguage()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x767420", Offset = "0x767420", VA = "0x767420")]
	private void SetToPS5SystemLanguage()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x767424", Offset = "0x767424", VA = "0x767424")]
	public static void ChooseLanguageAndReload(Language newLanguage)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x767344", Offset = "0x767344", VA = "0x767344")]
	public static void ChooseLanguage(Language newLanguage)
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x7674A8", Offset = "0x7674A8", VA = "0x7674A8")]
	[Obsolete("Old Choose language. Use enums.")]
	public static void ChooseLanguage(string languageName)
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x766DB0", Offset = "0x766DB0", VA = "0x766DB0")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x767700", Offset = "0x767700", VA = "0x767700")]
	public static void UpdateDictionaries()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x767AB0", Offset = "0x767AB0", VA = "0x767AB0")]
	public static Dictionary<string, string> GetDictionaryForEditor()
	{
		return null;
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x767B0C", Offset = "0x767B0C", VA = "0x767B0C")]
	public static string GetLocalizedValue(string key)
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x766C80", Offset = "0x766C80", VA = "0x766C80")]
	private void CreateSingleton()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x767C5C", Offset = "0x767C5C", VA = "0x767C5C")]
	public LocalizationSystem()
	{
	}
}
[Serializable]
[Token(Token = "0x200002A")]
public struct LocalizedString
{
	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string key;

	[Token(Token = "0x17000024")]
	public string value
	{
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x767C6C", Offset = "0x767C6C", VA = "0x767C6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x767C64", Offset = "0x767C64", VA = "0x767C64")]
	public LocalizedString(string key)
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x767C74", Offset = "0x767C74", VA = "0x767C74")]
	public static implicit operator LocalizedString(string key)
	{
		return default(LocalizedString);
	}
}
[Token(Token = "0x200002B")]
public class TxtLocalizer : MonoBehaviour
{
	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TextMeshProUGUI textTMP;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private TextMeshPro textMeshPro;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Text textUI;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool changeFont;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TMP_FontAsset fontCyrillic;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Font txtFontCyrillic;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LocalizedString localizedString;

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x767C94", Offset = "0x767C94", VA = "0x767C94")]
	private void Start()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x767FF8", Offset = "0x767FF8", VA = "0x767FF8")]
	public TxtLocalizer(string key)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x767F9C", Offset = "0x767F9C", VA = "0x767F9C")]
	public void SetRussianFont()
	{
	}
}
[Token(Token = "0x200002C")]
public class LockerAudioPlayer : MonoBehaviour
{
	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource audioSource;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip openSound;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AudioClip closedSound;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float openSoundDelayTime;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float closedSoundDelayTime;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool openSoundIsplayed;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool closedSoundIsplayed;

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x768028", Offset = "0x768028", VA = "0x768028")]
	private void Start()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x768080", Offset = "0x768080", VA = "0x768080")]
	public void PlayOpenSound()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x7680CC", Offset = "0x7680CC", VA = "0x7680CC")]
	public void PlayClosedSound()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x768118", Offset = "0x768118", VA = "0x768118")]
	public LockerAudioPlayer()
	{
	}
}
[Token(Token = "0x200002D")]
public class MultiTool : MonoBehaviour
{
	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Header("Insert Trigger Object(s)")]
	private GameObject[] triggerObjects;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("Insert Target Object")]
	[SerializeField]
	private GameObject targetObject;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static MultiTool current;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int multiToolID;

	[Token(Token = "0x14000001")]
	public event Action<int> ForwardAction
	{
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x768390", Offset = "0x768390", VA = "0x768390")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x768440", Offset = "0x768440", VA = "0x768440")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x768120", Offset = "0x768120", VA = "0x768120")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x768188", Offset = "0x768188", VA = "0x768188")]
	private void Start()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x7684F0", Offset = "0x7684F0", VA = "0x7684F0")]
	public void Action(int multiToolID)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x768214", Offset = "0x768214", VA = "0x768214")]
	private void LinkTriggerToTarget()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x76850C", Offset = "0x76850C", VA = "0x76850C")]
	public MultiTool()
	{
	}
}
[Token(Token = "0x200002E")]
public class MultiToolTarget : MonoBehaviour
{
	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Event activated by MultiTool")]
	public UnityEvent TargetAction;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool eventIsResettable;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Header("Set up reset state for event")]
	public UnityEvent ResetTargetAction;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Header("Serialized for debugging. Do not touch.")]
	public int multiToolID;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	public GameObject[] triggerObjects;

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x768560", Offset = "0x768560", VA = "0x768560")]
	private void Start()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x768614", Offset = "0x768614", VA = "0x768614")]
	private void Action(int id)
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x768718", Offset = "0x768718", VA = "0x768718")]
	public MultiToolTarget()
	{
	}
}
[Token(Token = "0x200002F")]
public class MultiToolTrigger : MonoBehaviour
{
	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Header("MultiToolTriggerObject")]
	private GameObject triggerObject;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("Select Tag(s) to activate trigger")]
	[SerializeField]
	private bool player;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	[SerializeField]
	private bool projectile;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	[SerializeField]
	private bool moveableObject;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
	[SerializeField]
	private bool activateByAnything;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Header("Trigger settings")]
	private bool isPressurePlate;

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x768720", Offset = "0x768720", VA = "0x768720")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x7688E8", Offset = "0x7688E8", VA = "0x7688E8")]
	public void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x768818", Offset = "0x768818", VA = "0x768818")]
	private void ActivateTrigger()
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x7689E8", Offset = "0x7689E8", VA = "0x7689E8")]
	private void DeActivateTrigger()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x768AB4", Offset = "0x768AB4", VA = "0x768AB4")]
	public MultiToolTrigger()
	{
	}
}
[Token(Token = "0x2000030")]
public class MultiToolTriggerObject : MonoBehaviour
{
	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Header("Serialized for debugging. Do not touch.")]
	public int multiToolID;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public int triggerID;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public bool triggerActivated;

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x768ABC", Offset = "0x768ABC", VA = "0x768ABC")]
	public MultiToolTriggerObject()
	{
	}
}
[Token(Token = "0x2000031")]
public class NPCAnimationController : MonoBehaviour
{
	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private NPCMovementSettings movementSettings;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private NPCNavPointController navPointController;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Header("Drag NPC GO with animator here")]
	[SerializeField]
	public Animator animator;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AIPath aiPath;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Header("Animation Speed Sync Settings")]
	[SerializeField]
	private float switchToIdleSpeed;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float slowDownATSpeed;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float slowDownTOSpeed;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float speedUpATSpeed;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float speedUpTOSpeed;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Header("View NPC speed in Playmode")]
	private float npcSpeed;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float defaultAnimationSpeed;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string animationState;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool holdIdle;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	[SerializeField]
	private bool isSeeker;

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x768AC4", Offset = "0x768AC4", VA = "0x768AC4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x768BE4", Offset = "0x768BE4", VA = "0x768BE4")]
	private void Update()
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x768D9C", Offset = "0x768D9C", VA = "0x768D9C")]
	public void UpdateAnimationState()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x769070", Offset = "0x769070", VA = "0x769070")]
	public void ReleaseIdle()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x769078", Offset = "0x769078", VA = "0x769078")]
	public void SetIdle()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x769130", Offset = "0x769130", VA = "0x769130")]
	public void SetTalking()
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x768BE8", Offset = "0x768BE8", VA = "0x768BE8")]
	private void SyncAnimSpeed()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x7691E0", Offset = "0x7691E0", VA = "0x7691E0")]
	public NPCAnimationController()
	{
	}
}
[Token(Token = "0x2000032")]
public class NPCIdleAnimations : MonoBehaviour
{
	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Animator anim;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float minIdleTime;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float maxIdleTime;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float currentIdleTime;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float currentIdleTarget;

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x7691FC", Offset = "0x7691FC", VA = "0x7691FC")]
	private void Start()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x769284", Offset = "0x769284", VA = "0x769284")]
	private void Update()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x7693A0", Offset = "0x7693A0", VA = "0x7693A0")]
	private void ResetIdleTime()
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x7693C4", Offset = "0x7693C4", VA = "0x7693C4")]
	public NPCIdleAnimations()
	{
	}
}
[Token(Token = "0x2000033")]
public class NPCMovementSettings : MonoBehaviour
{
	[Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class <UpdateTarget>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NPCMovementSettings <>4__this;

		[Token(Token = "0x17000025")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x769AC8", Offset = "0x769AC8", VA = "0x769AC8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x769B10", Offset = "0x769B10", VA = "0x769B10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x7695CC", Offset = "0x7695CC", VA = "0x7695CC")]
		[DebuggerHidden]
		public <UpdateTarget>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x769A04", Offset = "0x769A04", VA = "0x769A04", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x769A08", Offset = "0x769A08", VA = "0x769A08", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x769AD0", Offset = "0x769AD0", VA = "0x769AD0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class <DelayedUnStop>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NPCMovementSettings <>4__this;

		[Token(Token = "0x17000027")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x769BC8", Offset = "0x769BC8", VA = "0x769BC8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x769C10", Offset = "0x769C10", VA = "0x769C10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x76995C", Offset = "0x76995C", VA = "0x76995C")]
		[DebuggerHidden]
		public <DelayedUnStop>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x769B18", Offset = "0x769B18", VA = "0x769B18", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x769B1C", Offset = "0x769B1C", VA = "0x769B1C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x769BD0", Offset = "0x769BD0", VA = "0x769BD0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private NPCNavPointController navPointController;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AIPath aiPath;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string speedIsSetTo;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Header("Settings")]
	private float walkingSpeed;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float runningSpeed;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float lastUsedSpeed;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private bool startInIdle;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	[HideInInspector]
	public bool npcIsStopped;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Transform seekerNose;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float turningSpeed;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool WantsToLookAtPlayer;

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x7693D8", Offset = "0x7693D8", VA = "0x7693D8")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x769558", Offset = "0x769558", VA = "0x769558")]
	[IteratorStateMachine(typeof(<UpdateTarget>d__12))]
	private IEnumerator UpdateTarget()
	{
		return null;
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x7695F4", Offset = "0x7695F4", VA = "0x7695F4")]
	private void Update()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x768F98", Offset = "0x768F98", VA = "0x768F98")]
	public void Walk()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x769004", Offset = "0x769004", VA = "0x769004")]
	public void Run()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x769774", Offset = "0x769774", VA = "0x769774")]
	private void InitializeMovementSpeed()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x76949C", Offset = "0x76949C", VA = "0x76949C")]
	public void StopNPC()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x769828", Offset = "0x769828", VA = "0x769828")]
	public void MoveNPC()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x7698C8", Offset = "0x7698C8", VA = "0x7698C8")]
	public void TestEventDelayedUnStop()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x7698E8", Offset = "0x7698E8", VA = "0x7698E8")]
	[IteratorStateMachine(typeof(<DelayedUnStop>d__20))]
	private IEnumerator DelayedUnStop()
	{
		return null;
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x769984", Offset = "0x769984", VA = "0x769984")]
	public void LookAtPlayer()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x769990", Offset = "0x769990", VA = "0x769990")]
	public void StopLookingAtPlayer()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x769998", Offset = "0x769998", VA = "0x769998")]
	public NPCMovementSettings()
	{
	}
}
[Token(Token = "0x2000036")]
public class NPCNavPoint : MonoBehaviour
{
	[Token(Token = "0x2000037")]
	[SerializeField]
	private enum movementSpeed
	{
		[Token(Token = "0x400011F")]
		walk,
		[Token(Token = "0x4000120")]
		run
	}

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private movementSpeed selectSpeed;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public string selectedSpeed;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public bool stopNPC;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	[SerializeField]
	public bool useTheseValues;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Header("Launch an event when NPC is at NavPoint")]
	[SerializeField]
	private UnityEvent navPointEvent;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Header("Debugging")]
	private bool showCubeInPlayMode;

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x769C18", Offset = "0x769C18", VA = "0x769C18")]
	private void Start()
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x769CD8", Offset = "0x769CD8", VA = "0x769CD8")]
	public void RunNavPointEvent()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x769CEC", Offset = "0x769CEC", VA = "0x769CEC")]
	public void NavPointTestEvent()
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x769D90", Offset = "0x769D90", VA = "0x769D90")]
	public void ShowCube()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x769D9C", Offset = "0x769D9C", VA = "0x769D9C")]
	public NPCNavPoint()
	{
	}
}
[Token(Token = "0x2000038")]
public class NPCNavPointController : MonoBehaviour
{
	[Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class <CheckDistanceToTargetNavPoint>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NPCNavPointController <>4__this;

		[Token(Token = "0x17000029")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x76A5B0", Offset = "0x76A5B0", VA = "0x76A5B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x76A5F8", Offset = "0x76A5F8", VA = "0x76A5F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x76A064", Offset = "0x76A064", VA = "0x76A064")]
		[DebuggerHidden]
		public <CheckDistanceToTargetNavPoint>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x76A394", Offset = "0x76A394", VA = "0x76A394", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x76A398", Offset = "0x76A398", VA = "0x76A398", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x76A5B8", Offset = "0x76A5B8", VA = "0x76A5B8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class <LaunchPathCompletedEvent>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NPCNavPointController <>4__this;

		[Token(Token = "0x1700002B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x76A6CC", Offset = "0x76A6CC", VA = "0x76A6CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x76A714", Offset = "0x76A714", VA = "0x76A714", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x76A2E8", Offset = "0x76A2E8", VA = "0x76A2E8")]
		[DebuggerHidden]
		public <LaunchPathCompletedEvent>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x76A600", Offset = "0x76A600", VA = "0x76A600", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x76A604", Offset = "0x76A604", VA = "0x76A604", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x76A6D4", Offset = "0x76A6D4", VA = "0x76A6D4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Header("Drag NPC Movement Path here")]
	private GameObject npcPath;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Header("Event to launch when path is completed")]
	private float delayBeforeEvent;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public UnityEvent pathCompletedEvent;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool loopRoute;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float navPointChangeDistance;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Header("NPC movement. Visible for debugging")]
	[SerializeField]
	public GameObject npc;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	public GameObject targetNavPoint;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private AIDestinationSetter destinationSetter;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Header("Last NavPoint Values. Visible for debugging")]
	[SerializeField]
	public string movementSpeed;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Header("NavPoint gameobjects. Visible for debugging.")]
	public bool destinationReached;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private GameObject[] navPointGameObjects;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int targetNavPointIndex;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Transform testing;

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x769DA4", Offset = "0x769DA4", VA = "0x769DA4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x769FF0", Offset = "0x769FF0", VA = "0x769FF0")]
	[IteratorStateMachine(typeof(<CheckDistanceToTargetNavPoint>d__14))]
	private IEnumerator CheckDistanceToTargetNavPoint()
	{
		return null;
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x76A08C", Offset = "0x76A08C", VA = "0x76A08C")]
	private void GetNavPointValues()
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x76A190", Offset = "0x76A190", VA = "0x76A190")]
	private void FindNextNavPoint()
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x76A1FC", Offset = "0x76A1FC", VA = "0x76A1FC")]
	private void LoopRoute()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x76A274", Offset = "0x76A274", VA = "0x76A274")]
	[IteratorStateMachine(typeof(<LaunchPathCompletedEvent>d__18))]
	private IEnumerator LaunchPathCompletedEvent()
	{
		return null;
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x76A310", Offset = "0x76A310", VA = "0x76A310")]
	public void TestEvent()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x76A378", Offset = "0x76A378", VA = "0x76A378")]
	public NPCNavPointController()
	{
	}
}
[Token(Token = "0x200003B")]
public class NPCPath : MonoBehaviour
{
	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public GameObject[] navPointGameObjects;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public NPCNavPoint[] navPoints;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Header("Show NavPoint Cubes in playmode")]
	public bool showCubes;

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x76A71C", Offset = "0x76A71C", VA = "0x76A71C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x76A720", Offset = "0x76A720", VA = "0x76A720")]
	private void FillnavPointGameObjectsArray()
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x76A8E4", Offset = "0x76A8E4", VA = "0x76A8E4")]
	public NPCPath()
	{
	}
}
[Token(Token = "0x200003C")]
public class NPCSeekerIdleAnimations : MonoBehaviour
{
	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Animator anim;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float minIdleTime;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float maxIdleTime;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float currentIdleTime;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float currentIdleTarget;

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x76A8EC", Offset = "0x76A8EC", VA = "0x76A8EC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x76A974", Offset = "0x76A974", VA = "0x76A974")]
	private void Update()
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x76AA90", Offset = "0x76AA90", VA = "0x76AA90")]
	private void ResetIdleTime()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x76AAB4", Offset = "0x76AAB4", VA = "0x76AAB4")]
	public NPCSeekerIdleAnimations()
	{
	}
}
[Token(Token = "0x200003D")]
public class RotateOtherSeeker : MonoBehaviour
{
	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform lookAtThisObject;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool rotating;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float turningSpeed;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Quaternion rotation;

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x76AAC8", Offset = "0x76AAC8", VA = "0x76AAC8")]
	private void Start()
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x76AACC", Offset = "0x76AACC", VA = "0x76AACC")]
	private void Update()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x76ABBC", Offset = "0x76ABBC", VA = "0x76ABBC")]
	public void LookAtTarget()
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x76AC40", Offset = "0x76AC40", VA = "0x76AC40")]
	public RotateOtherSeeker()
	{
	}
}
[Token(Token = "0x200003E")]
public class RunningJesterianSpawner : MonoBehaviour
{
	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject runningJesterian;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float minSpawnFrequency;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float maxSpawnFrequency;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float spawnTimer;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float spawnTimeNext;

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x76AC50", Offset = "0x76AC50", VA = "0x76AC50")]
	private void Start()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x76AD90", Offset = "0x76AD90", VA = "0x76AD90")]
	private void Update()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x76AC54", Offset = "0x76AC54", VA = "0x76AC54")]
	private void SpawnNPC()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x76ADD8", Offset = "0x76ADD8", VA = "0x76ADD8")]
	public RunningJesterianSpawner()
	{
	}
}
[Token(Token = "0x200003F")]
public class Elevator : MonoBehaviour
{
	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Properties")]
	[SerializeField]
	private bool isReversible;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float speed;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Animator animator;

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x76ADE0", Offset = "0x76ADE0", VA = "0x76ADE0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x76AE54", Offset = "0x76AE54", VA = "0x76AE54")]
	public void MoveDown()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x76AEBC", Offset = "0x76AEBC", VA = "0x76AEBC")]
	public void PauseAnimation()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x76AF00", Offset = "0x76AF00", VA = "0x76AF00")]
	public void ContinueAnimation()
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x76AF48", Offset = "0x76AF48", VA = "0x76AF48")]
	public Elevator()
	{
	}
}
[Token(Token = "0x2000040")]
public class HatchingListener : MonoBehaviour
{
	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityEvent hatchingCompletedEvent;

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x76AF58", Offset = "0x76AF58", VA = "0x76AF58")]
	public void HatchingCompleted()
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x76AF6C", Offset = "0x76AF6C", VA = "0x76AF6C")]
	public HatchingListener()
	{
	}
}
[Token(Token = "0x2000041")]
public class PhysicsPlatform : MonoBehaviour
{
	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TriggerArea m_TriggerArea;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 m_LastPosition;

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x76AF74", Offset = "0x76AF74", VA = "0x76AF74")]
	private void Awake()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x76AFCC", Offset = "0x76AFCC", VA = "0x76AFCC")]
	private void Start()
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x76AFFC", Offset = "0x76AFFC", VA = "0x76AFFC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x76B000", Offset = "0x76B000", VA = "0x76B000")]
	private void MovePlatform()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x76B174", Offset = "0x76B174", VA = "0x76B174")]
	public PhysicsPlatform()
	{
	}
}
[Token(Token = "0x2000042")]
public class StonePilePuzzle : MonoBehaviour
{
	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityEvent onPuzzleSolved;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Header("Triggering tag")]
	private string triggerTag;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Header("Debug")]
	private int amountOfStones;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private int stonesLeft;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<GameObject> allStones;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<GameObject> stonesInTriggerArea;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool puzzleSolved;

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x76B17C", Offset = "0x76B17C", VA = "0x76B17C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x76B1B4", Offset = "0x76B1B4", VA = "0x76B1B4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x76B374", Offset = "0x76B374", VA = "0x76B374")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x76B42C", Offset = "0x76B42C", VA = "0x76B42C")]
	public void StoneRemoved(GameObject stone)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x76B26C", Offset = "0x76B26C", VA = "0x76B26C")]
	public void StoneAdded(GameObject stone)
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x76B528", Offset = "0x76B528", VA = "0x76B528")]
	public StonePilePuzzle()
	{
	}
}
[Token(Token = "0x2000043")]
[DisallowMultipleComponent]
public class PlayerHeightAdjuster : MonoBehaviour
{
	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float currentHeight;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float velocity;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static float targetHeight;

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x76B5E0", Offset = "0x76B5E0", VA = "0x76B5E0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x76B73C", Offset = "0x76B73C", VA = "0x76B73C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x76B7E4", Offset = "0x76B7E4", VA = "0x76B7E4")]
	private void XRHeightAdjust()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x76B660", Offset = "0x76B660", VA = "0x76B660")]
	public void ApplyHeightValue()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x76B9F8", Offset = "0x76B9F8", VA = "0x76B9F8")]
	public PlayerHeightAdjuster()
	{
	}
}
[Token(Token = "0x2000044")]
public class ChangeImageOnPlatform : MonoBehaviour
{
	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SpriteRenderer spriteToChange;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image imageToChange;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Space]
	[SerializeField]
	private Sprite androidTexture;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Space]
	private Sprite ps5Texture;

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x76BA00", Offset = "0x76BA00", VA = "0x76BA00")]
	private void Awake()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x76BB04", Offset = "0x76BB04", VA = "0x76BB04")]
	public ChangeImageOnPlatform()
	{
	}
}
[Token(Token = "0x2000045")]
public class DisableObjectOnPlatform : MonoBehaviour
{
	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool disableOnAndroid;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[SerializeField]
	private bool disableOnPS5;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[SerializeField]
	private bool disableOnReleaseBuild;

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x76BB0C", Offset = "0x76BB0C", VA = "0x76BB0C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x76BBBC", Offset = "0x76BBBC", VA = "0x76BBBC")]
	public DisableObjectOnPlatform()
	{
	}
}
[Token(Token = "0x2000046")]
public class HandIKPlatformSettings : MonoBehaviour
{
	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 picoRotation;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool resetPicoPosition;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool resetPicoRotation;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	public bool picoHideOutOfFocus;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Renderer _renderer;

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x76BBC4", Offset = "0x76BBC4", VA = "0x76BBC4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x76BCCC", Offset = "0x76BCCC", VA = "0x76BCCC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x76BE6C", Offset = "0x76BE6C", VA = "0x76BE6C")]
	private void FocusLost()
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x76BEF8", Offset = "0x76BEF8", VA = "0x76BEF8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x76C098", Offset = "0x76C098", VA = "0x76C098")]
	private void FocusGained()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x76C124", Offset = "0x76C124", VA = "0x76C124")]
	public HandIKPlatformSettings()
	{
	}
}
[Token(Token = "0x2000047")]
public class GamePad : MonoBehaviour
{
	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static GamePad activeGamePad;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int playerId;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private bool hasSetupGamepad;

	[Token(Token = "0x1700002D")]
	public bool IsConnected
	{
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x76C12C", Offset = "0x76C12C", VA = "0x76C12C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x76C134", Offset = "0x76C134", VA = "0x76C134")]
	private void Update()
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x76C138", Offset = "0x76C138", VA = "0x76C138")]
	public GamePad()
	{
	}
}
[Token(Token = "0x2000048")]
public class NpManager : MonoBehaviour
{
	[Token(Token = "0x2000049")]
	public enum ActivityEndState
	{
		[Token(Token = "0x4000169")]
		Unknown,
		[Token(Token = "0x400016A")]
		Completed,
		[Token(Token = "0x400016B")]
		Failed,
		[Token(Token = "0x400016C")]
		Abandoned
	}

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static NpManager Instance;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private UDSManager m_uds;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool m_callActivitySetup;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool m_progressActivityComplete;

	[Token(Token = "0x1700002E")]
	public UDSManager UDS
	{
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x76C148", Offset = "0x76C148", VA = "0x76C148")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x76C150", Offset = "0x76C150", VA = "0x76C150")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x76C2EC", Offset = "0x76C2EC", VA = "0x76C2EC")]
	private void Start()
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x76C2F0", Offset = "0x76C2F0", VA = "0x76C2F0")]
	private void Update()
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x76C2F8", Offset = "0x76C2F8", VA = "0x76C2F8")]
	public NpManager()
	{
	}
}
[Token(Token = "0x200004A")]
public class UDSManager
{
	[Token(Token = "0x600015C")]
	[Address(RVA = "0x76C2E4", Offset = "0x76C2E4", VA = "0x76C2E4")]
	public UDSManager()
	{
	}
}
[Token(Token = "0x200004B")]
internal class User
{
	[Token(Token = "0x600015D")]
	[Address(RVA = "0x76C308", Offset = "0x76C308", VA = "0x76C308")]
	public User()
	{
	}
}
[Token(Token = "0x200004C")]
public class RotateWorld : MonoBehaviour
{
	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform leftHand;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform rightHand;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform root;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform centerPoint;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float distanceFromCenter;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool m_IsActive;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 m_LastFrameProjected;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Transform m_DummyRoot;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool snapRotateWithLeftHand;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	private bool useLeftHand;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Vector3 originalRigPosition;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private VRHand vrHandLeft;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private VRHand vrHandRight;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Transform handTransform;

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x76C310", Offset = "0x76C310", VA = "0x76C310")]
	private void Awake()
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x76C554", Offset = "0x76C554", VA = "0x76C554")]
	public void SetupRigPosition()
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x76C59C", Offset = "0x76C59C", VA = "0x76C59C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x76C754", Offset = "0x76C754", VA = "0x76C754")]
	private void RotateAction(InputAction.CallbackContext obj)
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x76C878", Offset = "0x76C878", VA = "0x76C878")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x76CA9C", Offset = "0x76CA9C", VA = "0x76CA9C")]
	private void StickMoved(InputAction.CallbackContext obj)
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x76C7CC", Offset = "0x76C7CC", VA = "0x76C7CC")]
	private void Rotate(float dir)
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x76CAA0", Offset = "0x76CAA0", VA = "0x76CAA0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x76CBD8", Offset = "0x76CBD8", VA = "0x76CBD8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x76D3B4", Offset = "0x76D3B4", VA = "0x76D3B4")]
	public RotateWorld()
	{
	}
}
[Token(Token = "0x200004D")]
public class SeekerIdleAnimations : MonoBehaviour
{
	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float minIdleTime;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float maxIdleTime;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Animator m_Anim;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float m_CurrentIdleTime;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float m_CurrentIdleTarget;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool dontIdle;

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x76D3BC", Offset = "0x76D3BC", VA = "0x76D3BC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x76D414", Offset = "0x76D414", VA = "0x76D414")]
	private void Start()
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x76D438", Offset = "0x76D438", VA = "0x76D438")]
	public void ResetIdleTime()
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x76D45C", Offset = "0x76D45C", VA = "0x76D45C")]
	private void Update()
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x76D580", Offset = "0x76D580", VA = "0x76D580")]
	public SeekerIdleAnimations()
	{
	}
}
[Token(Token = "0x200004E")]
public class SpiritLegPos : MonoBehaviour
{
	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private VRIK m_VRIK;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform m_Target;

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x76D594", Offset = "0x76D594", VA = "0x76D594")]
	private void Start()
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x76D624", Offset = "0x76D624", VA = "0x76D624")]
	private void FindMissingTargets()
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x76D824", Offset = "0x76D824", VA = "0x76D824")]
	private void Update()
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x76D8FC", Offset = "0x76D8FC", VA = "0x76D8FC")]
	public SpiritLegPos()
	{
	}
}
[Token(Token = "0x200004F")]
[DisallowMultipleComponent]
public class SteamManager : MonoBehaviour
{
	[Token(Token = "0x1700002F")]
	public static bool Initialized
	{
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x76D904", Offset = "0x76D904", VA = "0x76D904")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x76D90C", Offset = "0x76D90C", VA = "0x76D90C")]
	public SteamManager()
	{
	}
}
[Token(Token = "0x2000050")]
public class Temp : MonoBehaviour
{
	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject go;

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x76D914", Offset = "0x76D914", VA = "0x76D914")]
	private void Update()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x76D918", Offset = "0x76D918", VA = "0x76D918")]
	public Temp()
	{
	}
}
[Token(Token = "0x2000051")]
public class TempTrackVRTrigger : MonoBehaviour
{
	[Token(Token = "0x6000175")]
	[Address(RVA = "0x76D920", Offset = "0x76D920", VA = "0x76D920")]
	private void Start()
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x76D924", Offset = "0x76D924", VA = "0x76D924")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x76D928", Offset = "0x76D928", VA = "0x76D928")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x76D92C", Offset = "0x76D92C", VA = "0x76D92C")]
	public TempTrackVRTrigger()
	{
	}
}
[Token(Token = "0x2000052")]
public class ToggleSwitchPlayer : MonoBehaviour
{
	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityEvent OnPCPlayerActivated;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UnityEvent OnVRPlayerActivated;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_IsPCPlayerActive;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Gamepad gamepad;

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x76D934", Offset = "0x76D934", VA = "0x76D934")]
	private void Start()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x76DA50", Offset = "0x76DA50", VA = "0x76DA50")]
	private void Update()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x76DAD4", Offset = "0x76DAD4", VA = "0x76DAD4")]
	private void SwitchPlayer()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x76DCD8", Offset = "0x76DCD8", VA = "0x76DCD8")]
	public ToggleSwitchPlayer()
	{
	}
}
[Token(Token = "0x2000053")]
public class CameraAssigner : MonoBehaviour
{
	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Camera m_Camera;

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x76DCE0", Offset = "0x76DCE0", VA = "0x76DCE0")]
	private void Start()
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x76DD90", Offset = "0x76DD90", VA = "0x76DD90")]
	public CameraAssigner()
	{
	}
}
[Token(Token = "0x2000054")]
public class CottageFader : MonoBehaviour
{
	[Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class <FadeIn>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CottageFader <>4__this;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <targetAlpha>5__2;

		[Token(Token = "0x17000030")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x76E1AC", Offset = "0x76E1AC", VA = "0x76E1AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x76E1F4", Offset = "0x76E1F4", VA = "0x76E1F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x76DE38", Offset = "0x76DE38", VA = "0x76DE38")]
		[DebuggerHidden]
		public <FadeIn>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x76E08C", Offset = "0x76E08C", VA = "0x76E08C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x76E090", Offset = "0x76E090", VA = "0x76E090", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x76E1B4", Offset = "0x76E1B4", VA = "0x76E1B4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class <FadeToBlack>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CottageFader <>4__this;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <targetAlpha>5__2;

		[Token(Token = "0x17000032")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x76E34C", Offset = "0x76E34C", VA = "0x76E34C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x76E394", Offset = "0x76E394", VA = "0x76E394", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x76DED4", Offset = "0x76DED4", VA = "0x76DED4")]
		[DebuggerHidden]
		public <FadeToBlack>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x76E1FC", Offset = "0x76E1FC", VA = "0x76E1FC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x76E200", Offset = "0x76E200", VA = "0x76E200", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x76E354", Offset = "0x76E354", VA = "0x76E354", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RawImage fadeOutImage;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Header("Fade settings")]
	private float waitBeforeFade;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float fadeOutSpeed;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float alpha;

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x76DD98", Offset = "0x76DD98", VA = "0x76DD98")]
	private void Start()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x76DE34", Offset = "0x76DE34", VA = "0x76DE34")]
	private void Update()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x76DDC0", Offset = "0x76DDC0", VA = "0x76DDC0")]
	[IteratorStateMachine(typeof(<FadeIn>d__6))]
	public IEnumerator FadeIn()
	{
		return null;
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x76DE60", Offset = "0x76DE60", VA = "0x76DE60")]
	[IteratorStateMachine(typeof(<FadeToBlack>d__7))]
	public IEnumerator FadeToBlack()
	{
		return null;
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x76DEFC", Offset = "0x76DEFC", VA = "0x76DEFC")]
	public void StartFadeToBlack()
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x76DF1C", Offset = "0x76DF1C", VA = "0x76DF1C")]
	private void ChangeImageColorFadeIn()
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x76DFD0", Offset = "0x76DFD0", VA = "0x76DFD0")]
	private void ChangeImageColorToBlack()
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x76E084", Offset = "0x76E084", VA = "0x76E084")]
	public CottageFader()
	{
	}
}
[Token(Token = "0x2000057")]
public class FollowVRCamera : MonoBehaviour
{
	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Header("Camera to follow")]
	private Camera m_Camera;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool lookSideWays;

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x76E39C", Offset = "0x76E39C", VA = "0x76E39C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x76E460", Offset = "0x76E460", VA = "0x76E460")]
	private void Update()
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x76E610", Offset = "0x76E610", VA = "0x76E610")]
	public FollowVRCamera()
	{
	}
}
[Token(Token = "0x2000058")]
public class HeightTipController : MonoBehaviour
{
	[Token(Token = "0x6000196")]
	[Address(RVA = "0x76E618", Offset = "0x76E618", VA = "0x76E618")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x76E758", Offset = "0x76E758", VA = "0x76E758")]
	private void XRMenuPressed(InputAction.CallbackContext obj)
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x76E7D4", Offset = "0x76E7D4", VA = "0x76E7D4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x76E914", Offset = "0x76E914", VA = "0x76E914")]
	public HeightTipController()
	{
	}
}
[Token(Token = "0x2000059")]
public class IntroFader : MonoBehaviour
{
	[Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class <FadeInLevelName>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IntroFader <>4__this;

		[Token(Token = "0x17000034")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x76EF94", Offset = "0x76EF94", VA = "0x76EF94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x76EFDC", Offset = "0x76EFDC", VA = "0x76EFDC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x76ECD4", Offset = "0x76ECD4", VA = "0x76ECD4")]
		[DebuggerHidden]
		public <FadeInLevelName>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x76EDE0", Offset = "0x76EDE0", VA = "0x76EDE0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x76EDE4", Offset = "0x76EDE4", VA = "0x76EDE4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x76EF9C", Offset = "0x76EF9C", VA = "0x76EF9C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class <Fade>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IntroFader <>4__this;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <targetAlpha>5__2;

		[Token(Token = "0x17000036")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x76F1E8", Offset = "0x76F1E8", VA = "0x76F1E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x76F230", Offset = "0x76F230", VA = "0x76F230", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x76ECFC", Offset = "0x76ECFC", VA = "0x76ECFC")]
		[DebuggerHidden]
		public <Fade>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x76EFE4", Offset = "0x76EFE4", VA = "0x76EFE4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x76EFE8", Offset = "0x76EFE8", VA = "0x76EFE8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x76F1F0", Offset = "0x76F1F0", VA = "0x76F1F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Header("Objects")]
	private RawImage fadeOutImage;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject levelName;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private TextMeshProUGUI nameText;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private SkinnedMeshRenderer spiritBody;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private SkinnedMeshRenderer spiritHead;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Header("Fade settings")]
	[SerializeField]
	private float waitBeforeFade;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float waitBeforeName;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float textFadeSpeed;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float fadeOutSpeed;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float alpha;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Canvas canvas;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Coroutine handleFade;

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x76E91C", Offset = "0x76E91C", VA = "0x76E91C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x76EC4C", Offset = "0x76EC4C", VA = "0x76EC4C")]
	public void Stop()
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x76EC60", Offset = "0x76EC60", VA = "0x76EC60")]
	[IteratorStateMachine(typeof(<FadeInLevelName>d__14))]
	public IEnumerator FadeInLevelName()
	{
		return null;
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x76EBD8", Offset = "0x76EBD8", VA = "0x76EBD8")]
	[IteratorStateMachine(typeof(<Fade>d__15))]
	public IEnumerator Fade()
	{
		return null;
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x76ED24", Offset = "0x76ED24", VA = "0x76ED24")]
	private void ChangeImageColor()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x76EDD8", Offset = "0x76EDD8", VA = "0x76EDD8")]
	public IntroFader()
	{
	}
}
[Token(Token = "0x200005C")]
public class IntroFaderAwakening : MonoBehaviour
{
	[Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class <FadeInLevelName>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IntroFaderAwakening <>4__this;

		[Token(Token = "0x17000038")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x76F6F8", Offset = "0x76F6F8", VA = "0x76F6F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x76F740", Offset = "0x76F740", VA = "0x76F740", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x76F438", Offset = "0x76F438", VA = "0x76F438")]
		[DebuggerHidden]
		public <FadeInLevelName>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x76F544", Offset = "0x76F544", VA = "0x76F544", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x76F548", Offset = "0x76F548", VA = "0x76F548", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x76F700", Offset = "0x76F700", VA = "0x76F700", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class <Fade>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IntroFaderAwakening <>4__this;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <targetAlpha>5__2;

		[Token(Token = "0x1700003A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x76F880", Offset = "0x76F880", VA = "0x76F880", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x76F8C8", Offset = "0x76F8C8", VA = "0x76F8C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x76F460", Offset = "0x76F460", VA = "0x76F460")]
		[DebuggerHidden]
		public <Fade>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x76F748", Offset = "0x76F748", VA = "0x76F748", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x76F74C", Offset = "0x76F74C", VA = "0x76F74C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x76F888", Offset = "0x76F888", VA = "0x76F888", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Objects")]
	[SerializeField]
	private RawImage fadeOutImage;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject levelName;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private TextMeshProUGUI nameText;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Header("Fade settings")]
	[SerializeField]
	private float waitBeforeFade;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float waitBeforeName;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float textFadeSpeed;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float fadeOutSpeed;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float alpha;

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x76F238", Offset = "0x76F238", VA = "0x76F238")]
	private void Start()
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x76F350", Offset = "0x76F350", VA = "0x76F350")]
	[IteratorStateMachine(typeof(<FadeInLevelName>d__9))]
	public IEnumerator FadeInLevelName()
	{
		return null;
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x76F3C4", Offset = "0x76F3C4", VA = "0x76F3C4")]
	[IteratorStateMachine(typeof(<Fade>d__10))]
	public IEnumerator Fade()
	{
		return null;
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x76F488", Offset = "0x76F488", VA = "0x76F488")]
	private void ChangeImageColor()
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x76F53C", Offset = "0x76F53C", VA = "0x76F53C")]
	public IntroFaderAwakening()
	{
	}
}
[Token(Token = "0x200005F")]
public class LevelFader : MonoBehaviour
{
	[Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class <FadeInLevelName>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LevelFader <>4__this;

		[Token(Token = "0x1700003C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x76FE48", Offset = "0x76FE48", VA = "0x76FE48", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x76FE90", Offset = "0x76FE90", VA = "0x76FE90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x76FB88", Offset = "0x76FB88", VA = "0x76FB88")]
		[DebuggerHidden]
		public <FadeInLevelName>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x76FC94", Offset = "0x76FC94", VA = "0x76FC94", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x76FC98", Offset = "0x76FC98", VA = "0x76FC98", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x76FE50", Offset = "0x76FE50", VA = "0x76FE50", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class <Fade>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LevelFader <>4__this;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <targetAlpha>5__2;

		[Token(Token = "0x1700003E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x76FFF8", Offset = "0x76FFF8", VA = "0x76FFF8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x770040", Offset = "0x770040", VA = "0x770040", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x76FBB0", Offset = "0x76FBB0", VA = "0x76FBB0")]
		[DebuggerHidden]
		public <Fade>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x76FE98", Offset = "0x76FE98", VA = "0x76FE98", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x76FE9C", Offset = "0x76FE9C", VA = "0x76FE9C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x770000", Offset = "0x770000", VA = "0x770000", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Objects")]
	[SerializeField]
	private Image fadeOutImage;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject levelName;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private TextMeshProUGUI nameText;

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private SkinnedMeshRenderer spiritBody;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private SkinnedMeshRenderer spiritHead;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Header("Fade settings")]
	[SerializeField]
	private float waitBeforeFade;

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float waitBeforeName;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float textFadeSpeed;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float fadeOutSpeed;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float alpha;

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x76F8D0", Offset = "0x76F8D0", VA = "0x76F8D0")]
	private void Start()
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x76FAA0", Offset = "0x76FAA0", VA = "0x76FAA0")]
	[IteratorStateMachine(typeof(<FadeInLevelName>d__11))]
	public IEnumerator FadeInLevelName()
	{
		return null;
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x76FB14", Offset = "0x76FB14", VA = "0x76FB14")]
	[IteratorStateMachine(typeof(<Fade>d__12))]
	public IEnumerator Fade()
	{
		return null;
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x76FBD8", Offset = "0x76FBD8", VA = "0x76FBD8")]
	private void ChangeImageColor()
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x76FC8C", Offset = "0x76FC8C", VA = "0x76FC8C")]
	public LevelFader()
	{
	}
}
[Token(Token = "0x2000062")]
public class MenuTutorialSpriteController : MonoBehaviour
{
	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject tutorialSprite;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Canvas menuCanvas;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool hidden;

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x770048", Offset = "0x770048", VA = "0x770048")]
	private void Start()
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x7700C0", Offset = "0x7700C0", VA = "0x7700C0")]
	private void Update()
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x770094", Offset = "0x770094", VA = "0x770094")]
	public void ShowSprite()
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x7700FC", Offset = "0x7700FC", VA = "0x7700FC")]
	public void HideSprite()
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x77012C", Offset = "0x77012C", VA = "0x77012C")]
	public MenuTutorialSpriteController()
	{
	}
}
[Token(Token = "0x2000063")]
public class OpenWishList : MonoBehaviour
{
	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string steamPageUrl;

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x770134", Offset = "0x770134", VA = "0x770134")]
	private void Update()
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x770138", Offset = "0x770138", VA = "0x770138")]
	public void OpenWishListLink()
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x770144", Offset = "0x770144", VA = "0x770144")]
	public OpenWishList()
	{
	}
}
[Token(Token = "0x2000064")]
public class OutroFaderCredits : MonoBehaviour
{
	[Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class <FadeToBlack>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OutroFaderCredits <>4__this;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <targetAlpha>5__2;

		[Token(Token = "0x17000040")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x77051C", Offset = "0x77051C", VA = "0x77051C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x770564", Offset = "0x770564", VA = "0x770564", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x7702D0", Offset = "0x7702D0", VA = "0x7702D0")]
		[DebuggerHidden]
		public <FadeToBlack>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x7703B4", Offset = "0x7703B4", VA = "0x7703B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x7703B8", Offset = "0x7703B8", VA = "0x7703B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x770524", Offset = "0x770524", VA = "0x770524", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool fadeStarted;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool fadeComplete;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Header("Objects")]
	private RawImage fadeOutImage;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Header("Fade settings")]
	private float waitBeforeFade;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float fadeOutSpeed;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float alpha;

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x77019C", Offset = "0x77019C", VA = "0x77019C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x770258", Offset = "0x770258", VA = "0x770258")]
	private void Update()
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x770228", Offset = "0x770228", VA = "0x770228")]
	public void StartOutroFade()
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x77025C", Offset = "0x77025C", VA = "0x77025C")]
	[IteratorStateMachine(typeof(<FadeToBlack>d__9))]
	public IEnumerator FadeToBlack()
	{
		return null;
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x7702F8", Offset = "0x7702F8", VA = "0x7702F8")]
	private void ChangeImageColor()
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x7703AC", Offset = "0x7703AC", VA = "0x7703AC")]
	public OutroFaderCredits()
	{
	}
}
[Token(Token = "0x2000066")]
public class OutroTextWriter : MonoBehaviour
{
	[Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class <WriteText>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OutroTextWriter <>4__this;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int textIndex;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string <displayedText>5__2;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private char[] <characters>5__3;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int <ii>5__4;

		[Token(Token = "0x17000042")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x770A94", Offset = "0x770A94", VA = "0x770A94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x770ADC", Offset = "0x770ADC", VA = "0x770ADC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x7707A0", Offset = "0x7707A0", VA = "0x7707A0")]
		[DebuggerHidden]
		public <WriteText>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x77086C", Offset = "0x77086C", VA = "0x77086C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x770870", Offset = "0x770870", VA = "0x770870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x770A9C", Offset = "0x770A9C", VA = "0x770A9C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class <FadeOutText>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OutroTextWriter <>4__this;

		[Token(Token = "0x17000044")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x770D98", Offset = "0x770D98", VA = "0x770D98", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x770DE0", Offset = "0x770DE0", VA = "0x770DE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x77083C", Offset = "0x77083C", VA = "0x77083C")]
		[DebuggerHidden]
		public <FadeOutText>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x770AE4", Offset = "0x770AE4", VA = "0x770AE4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x770AE8", Offset = "0x770AE8", VA = "0x770AE8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x770DA0", Offset = "0x770DA0", VA = "0x770DA0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<TextMeshProUGUI> texts;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string currentStringLocalized;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float characterDelay;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float sentenceDisappearDelay;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float pauseBetweenSentences;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float textFadeSpeed;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int currentTextIndex;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public UnityEvent OnTextsCompleted;

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x77056C", Offset = "0x77056C", VA = "0x77056C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x770718", Offset = "0x770718", VA = "0x770718")]
	private void Update()
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x77071C", Offset = "0x77071C", VA = "0x77071C")]
	[IteratorStateMachine(typeof(<WriteText>d__10))]
	private IEnumerator WriteText(int textIndex)
	{
		return null;
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x7707C8", Offset = "0x7707C8", VA = "0x7707C8")]
	[IteratorStateMachine(typeof(<FadeOutText>d__11))]
	public IEnumerator FadeOutText()
	{
		return null;
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x770574", Offset = "0x770574", VA = "0x770574")]
	private void NextText()
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x770864", Offset = "0x770864", VA = "0x770864")]
	public OutroTextWriter()
	{
	}
}
[Token(Token = "0x2000069")]
public class PauseAudio : MonoBehaviour
{
	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool isPaused;

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x770DE8", Offset = "0x770DE8", VA = "0x770DE8")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x770DEC", Offset = "0x770DEC", VA = "0x770DEC")]
	private void Update()
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x770E5C", Offset = "0x770E5C", VA = "0x770E5C")]
	public void PauseAllAudio()
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x770E68", Offset = "0x770E68", VA = "0x770E68")]
	public void ContinueAllAudio()
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x770E74", Offset = "0x770E74", VA = "0x770E74")]
	public PauseAudio()
	{
	}
}
[Token(Token = "0x200006A")]
public class TutorialSpriteController : MonoBehaviour
{
	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject tutorialSprite;

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x770E7C", Offset = "0x770E7C", VA = "0x770E7C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x770EC0", Offset = "0x770EC0", VA = "0x770EC0")]
	public void ShowSprite()
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x770EE0", Offset = "0x770EE0", VA = "0x770EE0")]
	public void HideSprite()
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x770F00", Offset = "0x770F00", VA = "0x770F00")]
	public TutorialSpriteController()
	{
	}
}
[Token(Token = "0x200006B")]
public class UIButtonPlayerHeight : MonoBehaviour
{
	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI text;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Slider m_Slider;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float m_HeightVal;

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x770F08", Offset = "0x770F08", VA = "0x770F08")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x770F60", Offset = "0x770F60", VA = "0x770F60")]
	private void Start()
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x7714E8", Offset = "0x7714E8", VA = "0x7714E8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x771590", Offset = "0x771590", VA = "0x771590")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x771638", Offset = "0x771638", VA = "0x771638")]
	private void HandleValueChanged(float val)
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x7716A4", Offset = "0x7716A4", VA = "0x7716A4")]
	public void HeightUp()
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x7716FC", Offset = "0x7716FC", VA = "0x7716FC")]
	public void HeightDown()
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x771754", Offset = "0x771754", VA = "0x771754")]
	private void Update()
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x770FAC", Offset = "0x770FAC", VA = "0x770FAC")]
	private void UpdateText(float val)
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x7717E8", Offset = "0x7717E8", VA = "0x7717E8")]
	public void ApplyHeight()
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x7718AC", Offset = "0x7718AC", VA = "0x7718AC")]
	public UIButtonPlayerHeight()
	{
	}
}
[Token(Token = "0x200006C")]
public class UIButtonQuitGame : MonoBehaviour
{
	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private UnityEngine.UI.Button m_Button;

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x7718B4", Offset = "0x7718B4", VA = "0x7718B4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x77190C", Offset = "0x77190C", VA = "0x77190C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x7719A0", Offset = "0x7719A0", VA = "0x7719A0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x771A34", Offset = "0x771A34", VA = "0x771A34")]
	private void HandleButtonClick()
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x771A3C", Offset = "0x771A3C", VA = "0x771A3C")]
	public UIButtonQuitGame()
	{
	}
}
[Token(Token = "0x200006D")]
public class UIButtonSendFeedback : MonoBehaviour
{
	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private UnityEngine.UI.Button m_Button;

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x771A44", Offset = "0x771A44", VA = "0x771A44")]
	private void Awake()
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x771A9C", Offset = "0x771A9C", VA = "0x771A9C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x771B30", Offset = "0x771B30", VA = "0x771B30")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x771BC4", Offset = "0x771BC4", VA = "0x771BC4")]
	private void HandleButtonClick()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x771C2C", Offset = "0x771C2C", VA = "0x771C2C")]
	public UIButtonSendFeedback()
	{
	}
}
[Token(Token = "0x200006E")]
public class UIButtonVolume : MonoBehaviour
{
	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI text;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Slider m_Slider;

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x771C34", Offset = "0x771C34", VA = "0x771C34")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x771C8C", Offset = "0x771C8C", VA = "0x771C8C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x771F0C", Offset = "0x771F0C", VA = "0x771F0C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x771FB4", Offset = "0x771FB4", VA = "0x771FB4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x77205C", Offset = "0x77205C", VA = "0x77205C")]
	private void HandleValueChanged(float val)
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x771D38", Offset = "0x771D38", VA = "0x771D38")]
	private void UpdateText(float val)
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x7720CC", Offset = "0x7720CC", VA = "0x7720CC")]
	public UIButtonVolume()
	{
	}
}
[Token(Token = "0x200006F")]
public class UIVRFollow : MonoBehaviour
{
	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Camera to follow")]
	[SerializeField]
	private Camera m_Camera;

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x7720D4", Offset = "0x7720D4", VA = "0x7720D4")]
	private void Start()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x772150", Offset = "0x772150", VA = "0x772150")]
	private void Update()
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x7722A4", Offset = "0x7722A4", VA = "0x7722A4")]
	public UIVRFollow()
	{
	}
}
[Token(Token = "0x2000070")]
public class VolumeFader : MonoBehaviour
{
	[Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class <FadeVolume>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float startVol;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float targetVol;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public VolumeFader <>4__this;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <timeElapsed>5__2;

		[Token(Token = "0x17000046")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x77258C", Offset = "0x77258C", VA = "0x77258C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x7725D4", Offset = "0x7725D4", VA = "0x7725D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x7723E8", Offset = "0x7723E8", VA = "0x7723E8")]
		[DebuggerHidden]
		public <FadeVolume>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x772420", Offset = "0x772420", VA = "0x772420", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x772424", Offset = "0x772424", VA = "0x772424", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x772594", Offset = "0x772594", VA = "0x772594", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float fadeInDuration;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float settingsVolume;

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x7722AC", Offset = "0x7722AC", VA = "0x7722AC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x772300", Offset = "0x772300", VA = "0x772300")]
	public void StartVolumeFadeIn()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x7723C0", Offset = "0x7723C0", VA = "0x7723C0")]
	public void StartVolumeFadeOut()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x772338", Offset = "0x772338", VA = "0x772338")]
	[IteratorStateMachine(typeof(<FadeVolume>d__5))]
	public IEnumerator FadeVolume(float startVol, float targetVol)
	{
		return null;
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x772410", Offset = "0x772410", VA = "0x772410")]
	public VolumeFader()
	{
	}
}
[Token(Token = "0x2000072")]
public enum Axis
{
	[Token(Token = "0x40001FD")]
	XAxis,
	[Token(Token = "0x40001FE")]
	YAxis,
	[Token(Token = "0x40001FF")]
	ZAxis
}
[Token(Token = "0x2000073")]
public class VRPlayer : MonoBehaviour
{
	[Token(Token = "0x6000227")]
	[Address(RVA = "0x7725DC", Offset = "0x7725DC", VA = "0x7725DC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x7725E0", Offset = "0x7725E0", VA = "0x7725E0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x7725E4", Offset = "0x7725E4", VA = "0x7725E4")]
	public VRPlayer()
	{
	}
}
[Token(Token = "0x2000074")]
public class VRButtonDelay : MonoBehaviour
{
	[Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class <ResetAfterDelay>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float time;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public VRButtonDelay <>4__this;

		[Token(Token = "0x17000048")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x772880", Offset = "0x772880", VA = "0x772880", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x7728C8", Offset = "0x7728C8", VA = "0x7728C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x772750", Offset = "0x772750", VA = "0x772750")]
		[DebuggerHidden]
		public <ResetAfterDelay>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x772788", Offset = "0x772788", VA = "0x772788", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x77278C", Offset = "0x77278C", VA = "0x77278C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x772888", Offset = "0x772888", VA = "0x772888", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool ButtonReady;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Animator VRButtonAnimator;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float delayInSeconds;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public UnityEvent ButtonPressed;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public UnityEvent ButtonHasReseted;

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x7725EC", Offset = "0x7725EC", VA = "0x7725EC")]
	private void Start()
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x7725F8", Offset = "0x7725F8", VA = "0x7725F8")]
	public void VRButtonPressed()
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x7726CC", Offset = "0x7726CC", VA = "0x7726CC")]
	[IteratorStateMachine(typeof(<ResetAfterDelay>d__7))]
	private IEnumerator ResetAfterDelay(float time)
	{
		return null;
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x772778", Offset = "0x772778", VA = "0x772778")]
	public VRButtonDelay()
	{
	}
}
[Token(Token = "0x2000076")]
[RequireComponent(typeof(XROrigin))]
public class PicoHelper : MonoBehaviour
{
	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 originalRigPosition;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Quaternion originalRigRotation;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private UnityEngine.XR.InputDevice m_HmdDevice;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool wasPresent;

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x7728D0", Offset = "0x7728D0", VA = "0x7728D0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x7728D4", Offset = "0x7728D4", VA = "0x7728D4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x772A28", Offset = "0x772A28", VA = "0x772A28")]
	private void Recenter()
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x772D70", Offset = "0x772D70", VA = "0x772D70")]
	private void Update()
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x772E2C", Offset = "0x772E2C", VA = "0x772E2C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x772F38", Offset = "0x772F38", VA = "0x772F38")]
	public PicoHelper()
	{
	}
}
[Token(Token = "0x2000077")]
public class XRInputHelper : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000078")]
	public class ControllerInputs
	{
		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InputActionReference grip;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputActionReference trigger;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InputActionReference menu;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InputActionReference button1;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InputActionReference button2;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InputActionReference thumbstick;

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x7730D4", Offset = "0x7730D4", VA = "0x7730D4")]
		public ControllerInputs()
		{
		}
	}

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static XRInputHelper Instance;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public InputActionAsset inputActionAsset;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ControllerInputs leftInputs;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ControllerInputs rightInputs;

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x76B9E0", Offset = "0x76B9E0", VA = "0x76B9E0")]
	public ControllerInputs GetHandInputs(bool isLeft)
	{
		return null;
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x772F40", Offset = "0x772F40", VA = "0x772F40")]
	private void Awake()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x773018", Offset = "0x773018", VA = "0x773018")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x7730CC", Offset = "0x7730CC", VA = "0x7730CC")]
	public XRInputHelper()
	{
	}
}
[Token(Token = "0x2000079")]
public class XRIDefaultInputActions : IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
{
	[Token(Token = "0x200007A")]
	public struct XRIHeadActions
	{
		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private XRIDefaultInputActions m_Wrapper;

		[Token(Token = "0x17000057")]
		public InputAction Position
		{
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x774F68", Offset = "0x774F68", VA = "0x774F68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		public InputAction Rotation
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x774F84", Offset = "0x774F84", VA = "0x774F84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		public bool enabled
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x775004", Offset = "0x775004", VA = "0x775004")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x774F60", Offset = "0x774F60", VA = "0x774F60")]
		public XRIHeadActions(XRIDefaultInputActions wrapper)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x774FA0", Offset = "0x774FA0", VA = "0x774FA0")]
		public InputActionMap Get()
		{
			return null;
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x774FBC", Offset = "0x774FBC", VA = "0x774FBC")]
		public void Enable()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x774FE0", Offset = "0x774FE0", VA = "0x774FE0")]
		public void Disable()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x775028", Offset = "0x775028", VA = "0x775028")]
		public static implicit operator InputActionMap(XRIHeadActions set)
		{
			return null;
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x775040", Offset = "0x775040", VA = "0x775040")]
		public void SetCallbacks(IXRIHeadActions instance)
		{
		}
	}

	[Token(Token = "0x200007B")]
	public struct XRILeftHandActions
	{
		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private XRIDefaultInputActions m_Wrapper;

		[Token(Token = "0x1700005A")]
		public InputAction Position
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x7757DC", Offset = "0x7757DC", VA = "0x7757DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public InputAction Rotation
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x7757F8", Offset = "0x7757F8", VA = "0x7757F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public InputAction TrackingState
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x775814", Offset = "0x775814", VA = "0x775814")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		public InputAction HapticDevice
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x775830", Offset = "0x775830", VA = "0x775830")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		public bool enabled
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x7758B0", Offset = "0x7758B0", VA = "0x7758B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x7757D4", Offset = "0x7757D4", VA = "0x7757D4")]
		public XRILeftHandActions(XRIDefaultInputActions wrapper)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x77584C", Offset = "0x77584C", VA = "0x77584C")]
		public InputActionMap Get()
		{
			return null;
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x775868", Offset = "0x775868", VA = "0x775868")]
		public void Enable()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x77588C", Offset = "0x77588C", VA = "0x77588C")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x7758D4", Offset = "0x7758D4", VA = "0x7758D4")]
		public static implicit operator InputActionMap(XRILeftHandActions set)
		{
			return null;
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x7758EC", Offset = "0x7758EC", VA = "0x7758EC")]
		public void SetCallbacks(IXRILeftHandActions instance)
		{
		}
	}

	[Token(Token = "0x200007C")]
	public struct XRILeftHandInteractionActions
	{
		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private XRIDefaultInputActions m_Wrapper;

		[Token(Token = "0x1700005F")]
		public InputAction Select
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x7767A8", Offset = "0x7767A8", VA = "0x7767A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		public InputAction SelectValue
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x7767C4", Offset = "0x7767C4", VA = "0x7767C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		public InputAction Activate
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x7767E0", Offset = "0x7767E0", VA = "0x7767E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		public InputAction ActivateValue
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x7767FC", Offset = "0x7767FC", VA = "0x7767FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		public InputAction UIPress
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x776818", Offset = "0x776818", VA = "0x776818")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		public InputAction UIPressValue
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x776834", Offset = "0x776834", VA = "0x776834")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000065")]
		public InputAction RotateAnchor
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x776850", Offset = "0x776850", VA = "0x776850")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000066")]
		public InputAction TranslateAnchor
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x77686C", Offset = "0x77686C", VA = "0x77686C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		public InputAction PrimaryButton
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x776888", Offset = "0x776888", VA = "0x776888")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		public InputAction SecondaryButton
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x7768A4", Offset = "0x7768A4", VA = "0x7768A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		public InputAction MenuButton
		{
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x7768C0", Offset = "0x7768C0", VA = "0x7768C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		public InputAction Thumbstick
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x7768DC", Offset = "0x7768DC", VA = "0x7768DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		public bool enabled
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x77695C", Offset = "0x77695C", VA = "0x77695C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x7767A0", Offset = "0x7767A0", VA = "0x7767A0")]
		public XRILeftHandInteractionActions(XRIDefaultInputActions wrapper)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x7768F8", Offset = "0x7768F8", VA = "0x7768F8")]
		public InputActionMap Get()
		{
			return null;
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x776914", Offset = "0x776914", VA = "0x776914")]
		public void Enable()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x776938", Offset = "0x776938", VA = "0x776938")]
		public void Disable()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x776980", Offset = "0x776980", VA = "0x776980")]
		public static implicit operator InputActionMap(XRILeftHandInteractionActions set)
		{
			return null;
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x776998", Offset = "0x776998", VA = "0x776998")]
		public void SetCallbacks(IXRILeftHandInteractionActions instance)
		{
		}
	}

	[Token(Token = "0x200007D")]
	public struct XRIRightHandActions
	{
		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private XRIDefaultInputActions m_Wrapper;

		[Token(Token = "0x1700006C")]
		public InputAction Position
		{
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x7794D4", Offset = "0x7794D4", VA = "0x7794D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		public InputAction Rotation
		{
			[Token(Token = "0x6000280")]
			[Address(RVA = "0x7794F0", Offset = "0x7794F0", VA = "0x7794F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		public InputAction TrackingState
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0x77950C", Offset = "0x77950C", VA = "0x77950C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		public InputAction HapticDevice
		{
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x779528", Offset = "0x779528", VA = "0x779528")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		public bool enabled
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x7795A8", Offset = "0x7795A8", VA = "0x7795A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x7794CC", Offset = "0x7794CC", VA = "0x7794CC")]
		public XRIRightHandActions(XRIDefaultInputActions wrapper)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x779544", Offset = "0x779544", VA = "0x779544")]
		public InputActionMap Get()
		{
			return null;
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x779560", Offset = "0x779560", VA = "0x779560")]
		public void Enable()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x779584", Offset = "0x779584", VA = "0x779584")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x7795CC", Offset = "0x7795CC", VA = "0x7795CC")]
		public static implicit operator InputActionMap(XRIRightHandActions set)
		{
			return null;
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x7795E4", Offset = "0x7795E4", VA = "0x7795E4")]
		public void SetCallbacks(IXRIRightHandActions instance)
		{
		}
	}

	[Token(Token = "0x200007E")]
	public struct XRIRightHandInteractionActions
	{
		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private XRIDefaultInputActions m_Wrapper;

		[Token(Token = "0x17000071")]
		public InputAction Select
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x77A4A0", Offset = "0x77A4A0", VA = "0x77A4A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		public InputAction SelectValue
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x77A4BC", Offset = "0x77A4BC", VA = "0x77A4BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		public InputAction Activate
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x77A4D8", Offset = "0x77A4D8", VA = "0x77A4D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		public InputAction ActivateValue
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x77A4F4", Offset = "0x77A4F4", VA = "0x77A4F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		public InputAction UIPress
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x77A510", Offset = "0x77A510", VA = "0x77A510")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		public InputAction UIPressValue
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x77A52C", Offset = "0x77A52C", VA = "0x77A52C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		public InputAction RotateAnchor
		{
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x77A548", Offset = "0x77A548", VA = "0x77A548")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		public InputAction TranslateAnchor
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x77A564", Offset = "0x77A564", VA = "0x77A564")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		public InputAction PrimaryButton
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x77A580", Offset = "0x77A580", VA = "0x77A580")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		public InputAction SecondaryButton
		{
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x77A59C", Offset = "0x77A59C", VA = "0x77A59C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007B")]
		public InputAction MenuButton
		{
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x77A5B8", Offset = "0x77A5B8", VA = "0x77A5B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		public InputAction Thumbstick
		{
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x77A5D4", Offset = "0x77A5D4", VA = "0x77A5D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		public bool enabled
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x77A654", Offset = "0x77A654", VA = "0x77A654")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x77A498", Offset = "0x77A498", VA = "0x77A498")]
		public XRIRightHandInteractionActions(XRIDefaultInputActions wrapper)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x77A5F0", Offset = "0x77A5F0", VA = "0x77A5F0")]
		public InputActionMap Get()
		{
			return null;
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x77A60C", Offset = "0x77A60C", VA = "0x77A60C")]
		public void Enable()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x77A630", Offset = "0x77A630", VA = "0x77A630")]
		public void Disable()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x77A678", Offset = "0x77A678", VA = "0x77A678")]
		public static implicit operator InputActionMap(XRIRightHandInteractionActions set)
		{
			return null;
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x77A690", Offset = "0x77A690", VA = "0x77A690")]
		public void SetCallbacks(IXRIRightHandInteractionActions instance)
		{
		}
	}

	[Token(Token = "0x200007F")]
	public interface IXRIHeadActions
	{
		[Token(Token = "0x600029C")]
		void OnPosition(InputAction.CallbackContext context);

		[Token(Token = "0x600029D")]
		void OnRotation(InputAction.CallbackContext context);
	}

	[Token(Token = "0x2000080")]
	public interface IXRILeftHandActions
	{
		[Token(Token = "0x600029E")]
		void OnPosition(InputAction.CallbackContext context);

		[Token(Token = "0x600029F")]
		void OnRotation(InputAction.CallbackContext context);

		[Token(Token = "0x60002A0")]
		void OnTrackingState(InputAction.CallbackContext context);

		[Token(Token = "0x60002A1")]
		void OnHapticDevice(InputAction.CallbackContext context);
	}

	[Token(Token = "0x2000081")]
	public interface IXRILeftHandInteractionActions
	{
		[Token(Token = "0x60002A2")]
		void OnSelect(InputAction.CallbackContext context);

		[Token(Token = "0x60002A3")]
		void OnSelectValue(InputAction.CallbackContext context);

		[Token(Token = "0x60002A4")]
		void OnActivate(InputAction.CallbackContext context);

		[Token(Token = "0x60002A5")]
		void OnActivateValue(InputAction.CallbackContext context);

		[Token(Token = "0x60002A6")]
		void OnUIPress(InputAction.CallbackContext context);

		[Token(Token = "0x60002A7")]
		void OnUIPressValue(InputAction.CallbackContext context);

		[Token(Token = "0x60002A8")]
		void OnRotateAnchor(InputAction.CallbackContext context);

		[Token(Token = "0x60002A9")]
		void OnTranslateAnchor(InputAction.CallbackContext context);

		[Token(Token = "0x60002AA")]
		void OnPrimaryButton(InputAction.CallbackContext context);

		[Token(Token = "0x60002AB")]
		void OnSecondaryButton(InputAction.CallbackContext context);

		[Token(Token = "0x60002AC")]
		void OnMenuButton(InputAction.CallbackContext context);

		[Token(Token = "0x60002AD")]
		void OnThumbstick(InputAction.CallbackContext context);
	}

	[Token(Token = "0x2000082")]
	public interface IXRIRightHandActions
	{
		[Token(Token = "0x60002AE")]
		void OnPosition(InputAction.CallbackContext context);

		[Token(Token = "0x60002AF")]
		void OnRotation(InputAction.CallbackContext context);

		[Token(Token = "0x60002B0")]
		void OnTrackingState(InputAction.CallbackContext context);

		[Token(Token = "0x60002B1")]
		void OnHapticDevice(InputAction.CallbackContext context);
	}

	[Token(Token = "0x2000083")]
	public interface IXRIRightHandInteractionActions
	{
		[Token(Token = "0x60002B2")]
		void OnSelect(InputAction.CallbackContext context);

		[Token(Token = "0x60002B3")]
		void OnSelectValue(InputAction.CallbackContext context);

		[Token(Token = "0x60002B4")]
		void OnActivate(InputAction.CallbackContext context);

		[Token(Token = "0x60002B5")]
		void OnActivateValue(InputAction.CallbackContext context);

		[Token(Token = "0x60002B6")]
		void OnUIPress(InputAction.CallbackContext context);

		[Token(Token = "0x60002B7")]
		void OnUIPressValue(InputAction.CallbackContext context);

		[Token(Token = "0x60002B8")]
		void OnRotateAnchor(InputAction.CallbackContext context);

		[Token(Token = "0x60002B9")]
		void OnTranslateAnchor(InputAction.CallbackContext context);

		[Token(Token = "0x60002BA")]
		void OnPrimaryButton(InputAction.CallbackContext context);

		[Token(Token = "0x60002BB")]
		void OnSecondaryButton(InputAction.CallbackContext context);

		[Token(Token = "0x60002BC")]
		void OnMenuButton(InputAction.CallbackContext context);

		[Token(Token = "0x60002BD")]
		void OnThumbstick(InputAction.CallbackContext context);
	}

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly InputActionMap m_XRIHead;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private IXRIHeadActions m_XRIHeadActionsCallbackInterface;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly InputAction m_XRIHead_Position;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly InputAction m_XRIHead_Rotation;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly InputActionMap m_XRILeftHand;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private IXRILeftHandActions m_XRILeftHandActionsCallbackInterface;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly InputAction m_XRILeftHand_Position;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly InputAction m_XRILeftHand_Rotation;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly InputAction m_XRILeftHand_TrackingState;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly InputAction m_XRILeftHand_HapticDevice;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly InputActionMap m_XRILeftHandInteraction;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private IXRILeftHandInteractionActions m_XRILeftHandInteractionActionsCallbackInterface;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly InputAction m_XRILeftHandInteraction_Select;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly InputAction m_XRILeftHandInteraction_SelectValue;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly InputAction m_XRILeftHandInteraction_Activate;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly InputAction m_XRILeftHandInteraction_ActivateValue;

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly InputAction m_XRILeftHandInteraction_UIPress;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly InputAction m_XRILeftHandInteraction_UIPressValue;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private readonly InputAction m_XRILeftHandInteraction_RotateAnchor;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private readonly InputAction m_XRILeftHandInteraction_TranslateAnchor;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private readonly InputAction m_XRILeftHandInteraction_PrimaryButton;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private readonly InputAction m_XRILeftHandInteraction_SecondaryButton;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private readonly InputAction m_XRILeftHandInteraction_MenuButton;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly InputAction m_XRILeftHandInteraction_Thumbstick;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly InputActionMap m_XRIRightHand;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private IXRIRightHandActions m_XRIRightHandActionsCallbackInterface;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly InputAction m_XRIRightHand_Position;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly InputAction m_XRIRightHand_Rotation;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly InputAction m_XRIRightHand_TrackingState;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly InputAction m_XRIRightHand_HapticDevice;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly InputActionMap m_XRIRightHandInteraction;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private IXRIRightHandInteractionActions m_XRIRightHandInteractionActionsCallbackInterface;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly InputAction m_XRIRightHandInteraction_Select;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private readonly InputAction m_XRIRightHandInteraction_SelectValue;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private readonly InputAction m_XRIRightHandInteraction_Activate;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private readonly InputAction m_XRIRightHandInteraction_ActivateValue;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private readonly InputAction m_XRIRightHandInteraction_UIPress;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private readonly InputAction m_XRIRightHandInteraction_UIPressValue;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private readonly InputAction m_XRIRightHandInteraction_RotateAnchor;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private readonly InputAction m_XRIRightHandInteraction_TranslateAnchor;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private readonly InputAction m_XRIRightHandInteraction_PrimaryButton;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private readonly InputAction m_XRIRightHandInteraction_SecondaryButton;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private readonly InputAction m_XRIRightHandInteraction_MenuButton;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private readonly InputAction m_XRIRightHandInteraction_Thumbstick;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private int m_GenericXRControllerSchemeIndex;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
	private int m_ContinuousMoveSchemeIndex;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private int m_NoncontinuousMoveSchemeIndex;

	[Token(Token = "0x1700004A")]
	public InputActionAsset asset
	{
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x7740DC", Offset = "0x7740DC", VA = "0x7740DC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700004B")]
	public InputBinding? bindingMask
	{
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x774A34", Offset = "0x774A34", VA = "0x774A34", Slot = "7")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x774A5C", Offset = "0x774A5C", VA = "0x774A5C", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x1700004C")]
	public ReadOnlyArray<UnityEngine.InputSystem.InputDevice>? devices
	{
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x774AA8", Offset = "0x774AA8", VA = "0x774AA8", Slot = "9")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x774AE8", Offset = "0x774AE8", VA = "0x774AE8", Slot = "10")]
		set
		{
		}
	}

	[Token(Token = "0x1700004D")]
	public ReadOnlyArray<InputControlScheme> controlSchemes
	{
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x774B34", Offset = "0x774B34", VA = "0x774B34", Slot = "11")]
		get
		{
			return default(ReadOnlyArray<InputControlScheme>);
		}
	}

	[Token(Token = "0x1700004E")]
	public IEnumerable<InputBinding> bindings
	{
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x774BDC", Offset = "0x774BDC", VA = "0x774BDC", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700004F")]
	public XRIHeadActions XRIHead
	{
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x774C74", Offset = "0x774C74", VA = "0x774C74")]
		get
		{
			return default(XRIHeadActions);
		}
	}

	[Token(Token = "0x17000050")]
	public XRILeftHandActions XRILeftHand
	{
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x774C94", Offset = "0x774C94", VA = "0x774C94")]
		get
		{
			return default(XRILeftHandActions);
		}
	}

	[Token(Token = "0x17000051")]
	public XRILeftHandInteractionActions XRILeftHandInteraction
	{
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x774CB4", Offset = "0x774CB4", VA = "0x774CB4")]
		get
		{
			return default(XRILeftHandInteractionActions);
		}
	}

	[Token(Token = "0x17000052")]
	public XRIRightHandActions XRIRightHand
	{
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x774CD4", Offset = "0x774CD4", VA = "0x774CD4")]
		get
		{
			return default(XRIRightHandActions);
		}
	}

	[Token(Token = "0x17000053")]
	public XRIRightHandInteractionActions XRIRightHandInteraction
	{
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x774CF4", Offset = "0x774CF4", VA = "0x774CF4")]
		get
		{
			return default(XRIRightHandInteractionActions);
		}
	}

	[Token(Token = "0x17000054")]
	public InputControlScheme GenericXRControllerScheme
	{
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x774D14", Offset = "0x774D14", VA = "0x774D14")]
		get
		{
			return default(InputControlScheme);
		}
	}

	[Token(Token = "0x17000055")]
	public InputControlScheme ContinuousMoveScheme
	{
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x774DD8", Offset = "0x774DD8", VA = "0x774DD8")]
		get
		{
			return default(InputControlScheme);
		}
	}

	[Token(Token = "0x17000056")]
	public InputControlScheme NoncontinuousMoveScheme
	{
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x774E9C", Offset = "0x774E9C", VA = "0x774E9C")]
		get
		{
			return default(InputControlScheme);
		}
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x7740E4", Offset = "0x7740E4", VA = "0x7740E4")]
	public XRIDefaultInputActions()
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x7749D8", Offset = "0x7749D8", VA = "0x7749D8", Slot = "17")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x774B50", Offset = "0x774B50", VA = "0x774B50", Slot = "12")]
	public bool Contains(InputAction action)
	{
		return default(bool);
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x774B6C", Offset = "0x774B6C", VA = "0x774B6C", Slot = "15")]
	public IEnumerator<InputAction> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x774B88", Offset = "0x774B88", VA = "0x774B88", Slot = "16")]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x774BA4", Offset = "0x774BA4", VA = "0x774BA4", Slot = "13")]
	public void Enable()
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x774BC0", Offset = "0x774BC0", VA = "0x774BC0", Slot = "14")]
	public void Disable()
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x774BF8", Offset = "0x774BF8", VA = "0x774BF8", Slot = "5")]
	public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
	{
		return null;
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x774C18", Offset = "0x774C18", VA = "0x774C18", Slot = "6")]
	public int FindBinding(InputBinding bindingMask, out InputAction action)
	{
		return default(int);
	}
}
namespace UnityTemplateProjects
{
	[Token(Token = "0x2000084")]
	public class SimpleCameraController : MonoBehaviour
	{
		[Token(Token = "0x2000085")]
		private class CameraState
		{
			[Token(Token = "0x4000253")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yaw;

			[Token(Token = "0x4000254")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pitch;

			[Token(Token = "0x4000255")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float roll;

			[Token(Token = "0x4000256")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float x;

			[Token(Token = "0x4000257")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float y;

			[Token(Token = "0x4000258")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float z;

			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x77D21C", Offset = "0x77D21C", VA = "0x77D21C")]
			public void SetFromTransform(Transform t)
			{
			}

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x77D774", Offset = "0x77D774", VA = "0x77D774")]
			public void Translate(Vector3 translation)
			{
			}

			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x77D7F4", Offset = "0x77D7F4", VA = "0x77D7F4")]
			public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
			{
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x77D87C", Offset = "0x77D87C", VA = "0x77D87C")]
			public void UpdateTransform(Transform t)
			{
			}

			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x77DAA0", Offset = "0x77DAA0", VA = "0x77DAA0")]
			public CameraState()
			{
			}
		}

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CameraState m_TargetCameraState;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CameraState m_InterpolatingCameraState;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Movement Settings")]
		[Tooltip("Exponential boost factor on translation, controllable by mouse wheel.")]
		public float boost;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Time it takes to interpolate camera position 99% of the way to the target.")]
		[Range(0.001f, 1f)]
		public float positionLerpTime;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Rotation Settings")]
		[Tooltip("X = Change in mouse position.\nY = Multiplicative factor for camera rotation.")]
		public AnimationCurve mouseSensitivityCurve;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Time it takes to interpolate camera rotation 99% of the way to the target.")]
		[Range(0.001f, 1f)]
		public float rotationLerpTime;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Whether or not to invert our Y axis for mouse input to rotation.")]
		public bool invertY;

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x77D1C8", Offset = "0x77D1C8", VA = "0x77D1C8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x77D2A0", Offset = "0x77D2A0", VA = "0x77D2A0")]
		private Vector3 GetInputTranslationDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x77D4D0", Offset = "0x77D4D0", VA = "0x77D4D0")]
		private void Update()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x77D8C4", Offset = "0x77D8C4", VA = "0x77D8C4")]
		public SimpleCameraController()
		{
		}
	}
}
namespace Valve.VR
{
	[Token(Token = "0x2000086")]
	public class SteamVR_LoadLevel : MonoBehaviour
	{
		[Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class <LoadLevel>d__43 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000279")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400027A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400027B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SteamVR_LoadLevel <>4__this;

			[Token(Token = "0x17000081")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002D4")]
				[Address(RVA = "0x77E900", Offset = "0x77E900", VA = "0x77E900", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000082")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002D6")]
				[Address(RVA = "0x77E948", Offset = "0x77E948", VA = "0x77E948", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x77E278", Offset = "0x77E278", VA = "0x77E278")]
			[DebuggerHidden]
			public <LoadLevel>d__43(int <>1__state)
			{
			}

			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x77E2E4", Offset = "0x77E2E4", VA = "0x77E2E4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x77E2E8", Offset = "0x77E2E8", VA = "0x77E2E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x77E908", Offset = "0x77E908", VA = "0x77E908", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static SteamVR_LoadLevel _active;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string levelName;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string internalProcessPath;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string internalProcessArgs;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool loadAdditive;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool loadAsync;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture loadingScreen;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture progressBarEmpty;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Texture progressBarFull;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float loadingScreenWidthInMeters;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float progressBarWidthInMeters;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float loadingScreenDistance;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform loadingScreenTransform;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform progressBarTransform;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Texture front;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Texture back;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Texture left;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Texture right;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Texture top;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Texture bottom;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Color backgroundColor;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool showGrid;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float fadeOutTime;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float fadeInTime;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float postLoadSettleTime;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float loadingScreenFadeInTime;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float loadingScreenFadeOutTime;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float fadeRate;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float alpha;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private AsyncOperation async;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private RenderTexture renderTexture;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public bool autoTriggerOnEnable;

		[Token(Token = "0x1700007E")]
		public static bool loading
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x77DAA8", Offset = "0x77DAA8", VA = "0x77DAA8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007F")]
		public static float progress
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x77DB20", Offset = "0x77DB20", VA = "0x77DB20")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000080")]
		public static Texture progressTexture
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x77DBD0", Offset = "0x77DBD0", VA = "0x77DBD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x77DC70", Offset = "0x77DC70", VA = "0x77DC70")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x77DC80", Offset = "0x77DC80", VA = "0x77DC80")]
		public void Trigger()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x77DD38", Offset = "0x77DD38", VA = "0x77DD38")]
		public static void Begin(string levelName, bool showGrid = false, float fadeOutTime = 0.5f, float r = 0f, float g = 0f, float b = 0f, float a = 1f)
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x77DE30", Offset = "0x77DE30", VA = "0x77DE30")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x77E1B8", Offset = "0x77E1B8", VA = "0x77E1B8")]
		private void Update()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x77DCC4", Offset = "0x77DCC4", VA = "0x77DCC4")]
		[IteratorStateMachine(typeof(<LoadLevel>d__43))]
		private IEnumerator LoadLevel()
		{
			return null;
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x77E2A0", Offset = "0x77E2A0", VA = "0x77E2A0")]
		public SteamVR_LoadLevel()
		{
		}
	}
}
namespace EpicToonFX
{
	[Token(Token = "0x2000088")]
	public class ETFXLightFade : MonoBehaviour
	{
		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Seconds to dim the light")]
		public float life;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool killAfterLife;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Light li;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float initIntensity;

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x77E950", Offset = "0x77E950", VA = "0x77E950")]
		private void Start()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x77EA6C", Offset = "0x77EA6C", VA = "0x77EA6C")]
		private void Update()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x77EBC0", Offset = "0x77EBC0", VA = "0x77EBC0")]
		public ETFXLightFade()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class ETFXPitchRandomizer : MonoBehaviour
	{
		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float randomPercent;

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x77EBDC", Offset = "0x77EBDC", VA = "0x77EBDC")]
		private void Start()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x77EC8C", Offset = "0x77EC8C", VA = "0x77EC8C")]
		public ETFXPitchRandomizer()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class ETFXRotation : MonoBehaviour
	{
		[Token(Token = "0x200008B")]
		public enum spaceEnum
		{
			[Token(Token = "0x4000284")]
			Local,
			[Token(Token = "0x4000285")]
			World
		}

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Rotate axises by degrees per second")]
		public Vector3 rotateVector;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public spaceEnum rotateSpace;

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x77EC9C", Offset = "0x77EC9C", VA = "0x77EC9C")]
		private void Start()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x77ECA0", Offset = "0x77ECA0", VA = "0x77ECA0")]
		private void Update()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x77ED74", Offset = "0x77ED74", VA = "0x77ED74")]
		public ETFXRotation()
		{
		}
	}
}
namespace FAE
{
	[Token(Token = "0x200008C")]
	[ExecuteInEditMode]
	public class CliffAppearance : MonoBehaviour
	{
		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Shader cliffShader;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Shader cliffCoverageShader;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Material[] targetMaterials;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color objectColor;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float roughness;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Texture detailNormalMap;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		public float detailNormalStrength;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Texture globalColorMap;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Color globalColor;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Range(0f, 5f)]
		public float globalTiling;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool useCoverageShader;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Texture coverageColorMap;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Texture coverageNormalMap;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Range(0f, 2f)]
		public float coverageAmount;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[Range(0f, 5f)]
		public float coverageTiling;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Texture coverageMap;

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x77EDD4", Offset = "0x77EDD4", VA = "0x77EDD4")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x77F1E0", Offset = "0x77F1E0", VA = "0x77F1E0")]
		private void GetSettings()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x77EF00", Offset = "0x77EF00", VA = "0x77EF00")]
		public void Apply()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x77F500", Offset = "0x77F500", VA = "0x77F500")]
		public CliffAppearance()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class FoliageBender : MonoBehaviour
	{
		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 100f)]
		public float strength;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 5f)]
		public float radius;

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x77F59C", Offset = "0x77F59C", VA = "0x77F59C")]
		private void Update()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x77F654", Offset = "0x77F654", VA = "0x77F654")]
		public FoliageBender()
		{
		}
	}
	[Token(Token = "0x200008E")]
	public class PigmentMapGenerator : MonoBehaviour
	{
		[Token(Token = "0x200008F")]
		public enum TextureRotation
		{
			[Token(Token = "0x40002C2")]
			None,
			[Token(Token = "0x40002C3")]
			Quarter,
			[Token(Token = "0x40002C4")]
			Half,
			[Token(Token = "0x40002C5")]
			ThreeQuarters
		}

		[Token(Token = "0x2000090")]
		public enum HeightmapChannel
		{
			[Token(Token = "0x40002C7")]
			None,
			[Token(Token = "0x40002C8")]
			Texture1,
			[Token(Token = "0x40002C9")]
			Texture2,
			[Token(Token = "0x40002CA")]
			Texture3,
			[Token(Token = "0x40002CB")]
			Texture4,
			[Token(Token = "0x40002CC")]
			Texture5,
			[Token(Token = "0x40002CD")]
			Texture6,
			[Token(Token = "0x40002CE")]
			Texture7,
			[Token(Token = "0x40002CF")]
			Texture8
		}

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool debug;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool performCleanup;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool manualInput;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject[] terrainObjects;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TerrainUVUtil util;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TerrainUVUtil.Workflow workflow;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int pigmentmapSize;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 targetSize;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 targetOriginPosition;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 targetCenterPosition;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		public Vector4 terrainScaleOffset;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Terrain[] terrains;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private MeshRenderer[] meshes;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material material;

		[Token(Token = "0x40002A6")]
		private const int HEIGHTOFFSET = 1000;

		[Token(Token = "0x40002A7")]
		private const int CLIP_PADDING = 100;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public LayerMask layerMask;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float renderLightBrightness;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool useAlternativeRenderer;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Camera renderCam;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Light renderLight;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Light[] lights;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Texture2D inputHeightmap;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Texture2D customPigmentMap;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool useCustomPigmentMap;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		public bool flipVertically;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC2")]
		public bool flipHortizontally;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public TextureRotation textureRotation;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Texture2D pigmentMap;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public bool isMultiTerrain;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public string savePath;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float originalTargetYPos;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public bool hasTerrainData;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE5")]
		public bool isMegaSplat;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private AmbientMode ambientMode;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private Color ambientColor;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private bool enableFog;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Material skyboxMat;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public HeightmapChannel heightmapChannel;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public string HeightmapChannelName;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public string[] terrainTextureNames;

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x77F668", Offset = "0x77F668", VA = "0x77F668")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x77F670", Offset = "0x77F670", VA = "0x77F670")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x77F6B8", Offset = "0x77F6B8", VA = "0x77F6B8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x77F66C", Offset = "0x77F66C", VA = "0x77F66C")]
		public void Init()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x77FA94", Offset = "0x77FA94", VA = "0x77FA94")]
		private void CheckMegaSplat()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x77FA9C", Offset = "0x77FA9C", VA = "0x77FA9C")]
		public void GetChildTerrainObjects(Transform parent)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x77FD34", Offset = "0x77FD34", VA = "0x77FD34")]
		public void GetTargetInfo()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x77F9C4", Offset = "0x77F9C4", VA = "0x77F9C4")]
		public void SetPigmentMap()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x7800B4", Offset = "0x7800B4", VA = "0x7800B4")]
		public PigmentMapGenerator()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class TerrainUVUtil : ScriptableObject
	{
		[Token(Token = "0x2000092")]
		public enum Workflow
		{
			[Token(Token = "0x40002DE")]
			None,
			[Token(Token = "0x40002DF")]
			Terrain,
			[Token(Token = "0x40002E0")]
			Mesh
		}

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly bool debug;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Workflow workflow;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Bounds meshBounds;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 pivotPos;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float height;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float bottom;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 size;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 centerPostion;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 originPosition;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int pigmentMapSize;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Terrain[] terrains;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public MeshRenderer[] meshes;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector4 terrainScaleOffset;

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x77FF08", Offset = "0x77FF08", VA = "0x77FF08")]
		public void GetObjectPlanarUV(GameObject[] gameObjects)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x78061C", Offset = "0x78061C", VA = "0x78061C")]
		private void GetMeshInfo(GameObject[] meshObjects)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x7800FC", Offset = "0x7800FC", VA = "0x7800FC")]
		private void GetTerrainInfo(GameObject[] terrainObjects)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x780AF4", Offset = "0x780AF4", VA = "0x780AF4")]
		private bool IsApproximatelyEqual(float a, float b)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x780B0C", Offset = "0x780B0C", VA = "0x780B0C")]
		public TerrainUVUtil()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class WindController : MonoBehaviour
	{
		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D windVectors;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool visualizeVectors;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool _visualizeVectors;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool listenToWindZone;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public WindZone windZone;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float windSpeed;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 3f)]
		public float windStrength;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 5f)]
		public float windAmplitude;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 150f)]
		public float trunkWindSpeed;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 30f)]
		public float trunkWindWeight;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 0.99f)]
		public float trunkWindSwinging;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float _windStrength;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static float _windAmplitude;

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x780B1C", Offset = "0x780B1C", VA = "0x780B1C")]
		public void SetStrength(float value)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x780B70", Offset = "0x780B70", VA = "0x780B70")]
		public void SetTrunkWeight(float value)
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x780BC4", Offset = "0x780BC4", VA = "0x780BC4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x780E38", Offset = "0x780E38", VA = "0x780E38")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x780F58", Offset = "0x780F58", VA = "0x780F58")]
		private void Update()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x7810A8", Offset = "0x7810A8", VA = "0x7810A8")]
		public void Apply()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x780C2C", Offset = "0x780C2C", VA = "0x780C2C")]
		private void SetShaderParameters()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x7810AC", Offset = "0x7810AC", VA = "0x7810AC")]
		public static void VisualizeVectors(bool state)
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x781130", Offset = "0x781130", VA = "0x781130")]
		public WindController()
		{
		}
	}
}
namespace MyShadow
{
	[Token(Token = "0x2000094")]
	public class CameraRotator : MonoBehaviour
	{
		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationDuration;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Ease easing;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_IsRotating;

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x781150", Offset = "0x781150", VA = "0x781150")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x781154", Offset = "0x781154", VA = "0x781154")]
		private void Update()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x7811A8", Offset = "0x7811A8", VA = "0x7811A8")]
		private void RotateBy(float angle)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x7812E8", Offset = "0x7812E8", VA = "0x7812E8")]
		public CameraRotator()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class Challenge : MonoBehaviour
	{
		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityEvent OnChallengeCompleted;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEvent OnChallengeFailed;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string challengeID;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool canCompleteMultipleTimes;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool m_ChallengeActive;

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x781304", Offset = "0x781304", VA = "0x781304")]
		public void StartChallenge()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x78134C", Offset = "0x78134C", VA = "0x78134C")]
		public bool IsChallengeCompleted()
		{
			return default(bool);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x7813B0", Offset = "0x7813B0", VA = "0x7813B0")]
		public void TryCompleteChallenge()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x781448", Offset = "0x781448", VA = "0x781448")]
		public void TriggerFailure()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x781464", Offset = "0x781464", VA = "0x781464", Slot = "4")]
		protected virtual void DoStartChallenge()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x781468", Offset = "0x781468", VA = "0x781468", Slot = "5")]
		protected virtual void DoCompleteChallenge()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x78146C", Offset = "0x78146C", VA = "0x78146C")]
		public Challenge()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class ChallengeValidator : MonoBehaviour
	{
		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string challengeID;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEvent challengeIsCompleted;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEvent challengeIsNotCompleted;

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x781474", Offset = "0x781474", VA = "0x781474")]
		public bool IsChallengeCompleted()
		{
			return default(bool);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x7814D8", Offset = "0x7814D8", VA = "0x7814D8")]
		private void Start()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x78150C", Offset = "0x78150C", VA = "0x78150C")]
		public ChallengeValidator()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class TimerChallenge : Challenge
	{
		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float timeToBeat;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool manualStartTimer;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_StartTime;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_CompleteTime;

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x781514", Offset = "0x781514", VA = "0x781514")]
		private void Start()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x781524", Offset = "0x781524", VA = "0x781524", Slot = "4")]
		protected override void DoStartChallenge()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x781540", Offset = "0x781540", VA = "0x781540", Slot = "5")]
		protected override void DoCompleteChallenge()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x781584", Offset = "0x781584", VA = "0x781584")]
		public TimerChallenge()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class TriggerChallenge : Challenge
	{
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x78158C", Offset = "0x78158C", VA = "0x78158C")]
		public TriggerChallenge()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class Dialogue : MonoBehaviour
	{
		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CanvasGroup canvasGroup;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform canvasTransform;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DialogueCanvas dialogueCanvas;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool CanBeTriggeredMultipleTimes;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool m_Triggered;

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x781594", Offset = "0x781594", VA = "0x781594")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x78160C", Offset = "0x78160C", VA = "0x78160C")]
		public void Show()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x78176C", Offset = "0x78176C", VA = "0x78176C")]
		public void Hide()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x781860", Offset = "0x781860", VA = "0x781860")]
		public Dialogue()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class DialogueCanvas : MonoBehaviour
	{
		[Token(Token = "0x200009B")]
		[CompilerGenerated]
		private sealed class <DoPlayDialogue>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000307")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000308")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000309")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DialogueCanvas <>4__this;

			[Token(Token = "0x400030A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x400030B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string <displayedText>5__3;

			[Token(Token = "0x400030C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private char[] <characters>5__4;

			[Token(Token = "0x400030D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private bool <inputPressed>5__5;

			[Token(Token = "0x400030E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private int <ii>5__6;

			[Token(Token = "0x17000083")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600031D")]
				[Address(RVA = "0x781CE4", Offset = "0x781CE4", VA = "0x781CE4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000084")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600031F")]
				[Address(RVA = "0x781D2C", Offset = "0x781D2C", VA = "0x781D2C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600031A")]
			[Address(RVA = "0x7819B0", Offset = "0x7819B0", VA = "0x7819B0")]
			[DebuggerHidden]
			public <DoPlayDialogue>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600031B")]
			[Address(RVA = "0x7819EC", Offset = "0x7819EC", VA = "0x7819EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600031C")]
			[Address(RVA = "0x7819F0", Offset = "0x7819F0", VA = "0x7819F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600031E")]
			[Address(RVA = "0x781CEC", Offset = "0x781CEC", VA = "0x781CEC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DialogueScriptableObject dialogueToPlay;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI dialogueText;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Image dialogueImage;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float characterDelay;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Coroutine m_DialogueRoutine;

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x781880", Offset = "0x781880", VA = "0x781880")]
		public void ShowDialogue()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x781958", Offset = "0x781958", VA = "0x781958")]
		public void ShowDoubleBubbleDialogue(Sprite image, string line)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x7818E4", Offset = "0x7818E4", VA = "0x7818E4")]
		[IteratorStateMachine(typeof(<DoPlayDialogue>d__7))]
		private IEnumerator DoPlayDialogue()
		{
			return null;
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x7819D8", Offset = "0x7819D8", VA = "0x7819D8")]
		public DialogueCanvas()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class DialogueCanvasV2 : MonoBehaviour
	{
		[Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class <DoPlayDialogue>d__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400032D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400032E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400032F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DialogueCanvasV2 <>4__this;

			[Token(Token = "0x4000330")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <counterForMore>5__2;

			[Token(Token = "0x4000331")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <i>5__3;

			[Token(Token = "0x4000332")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string <localizedText>5__4;

			[Token(Token = "0x4000333")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private string <displayedText>5__5;

			[Token(Token = "0x4000334")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private char[] <characters>5__6;

			[Token(Token = "0x4000335")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private bool <inputPressed>5__7;

			[Token(Token = "0x4000336")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private int <ii>5__8;

			[Token(Token = "0x17000085")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600032F")]
				[Address(RVA = "0x783BBC", Offset = "0x783BBC", VA = "0x783BBC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000086")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000331")]
				[Address(RVA = "0x783C04", Offset = "0x783C04", VA = "0x783C04", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600032C")]
			[Address(RVA = "0x7826EC", Offset = "0x7826EC", VA = "0x7826EC")]
			[DebuggerHidden]
			public <DoPlayDialogue>d__40(int <>1__state)
			{
			}

			[Token(Token = "0x600032D")]
			[Address(RVA = "0x782728", Offset = "0x782728", VA = "0x782728", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600032E")]
			[Address(RVA = "0x78272C", Offset = "0x78272C", VA = "0x78272C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000330")]
			[Address(RVA = "0x783BC4", Offset = "0x783BC4", VA = "0x783BC4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Dialogue goes here")]
		public DialogueScriptableObjectV2 dialogueToPlay;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("DoubleBubbleDialogue GO goes here")]
		private GameObject doubleBubbleDialogueGO;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string customSpeakerName;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject speakerImage;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("UI objects")]
		public TextMeshProUGUI speakerNameLeft;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform speakerImageLeft;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI speakerNameRight;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform speakerImageRight;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI dialogueText;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public TextMeshProUGUI more;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float characterDelay;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Coroutine m_DialogueRoutine;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private DoubleBubbleAudioPlayer audioPlayer;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool speakingStarted;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Header("Set at both canvases")]
		private GameObject pCDialogueCanvas;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Header("Set at PC Canvas")]
		[SerializeField]
		private GameObject pcControllerTutorialSprite;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject pcKeyboardTutorialSprite;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Header("Set at VR Canvas")]
		[SerializeField]
		private bool isVRCanvas;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public UnityEvent endDialogue;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject tutorialSprite;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public bool useLeftHand;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Header("Visible for debuggin. Do not set manually.")]
		public Animator animator;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Header("Visible for debugging. Click in playmode to test dialogue.")]
		public bool vrInputPressed;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		public bool pcInputPressed;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCA")]
		public bool skipTypewriterEffect;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCB")]
		public bool vrDialogueFinished;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public bool pcDialogueFinished;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject centerPoint;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 canvasPosition;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private bool setupDone;

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x781D34", Offset = "0x781D34", VA = "0x781D34")]
		private void Start()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x781D38", Offset = "0x781D38", VA = "0x781D38")]
		public void Setup()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x782234", Offset = "0x782234", VA = "0x782234")]
		public void SetVRCanvasPosition()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x782270", Offset = "0x782270", VA = "0x782270")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x7823E4", Offset = "0x7823E4", VA = "0x7823E4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x782588", Offset = "0x782588", VA = "0x782588")]
		private void InputPressed(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x782184", Offset = "0x782184", VA = "0x782184")]
		public void ResetDialogue()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x78259C", Offset = "0x78259C", VA = "0x78259C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x782598", Offset = "0x782598", VA = "0x782598")]
		private void DisableOtherImages(string allButThis)
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x78261C", Offset = "0x78261C", VA = "0x78261C")]
		public void ShowDialogue()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x782678", Offset = "0x782678", VA = "0x782678")]
		[IteratorStateMachine(typeof(<DoPlayDialogue>d__40))]
		private IEnumerator DoPlayDialogue()
		{
			return null;
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x782714", Offset = "0x782714", VA = "0x782714")]
		public DialogueCanvasV2()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[CreateAssetMenu(fileName = "dialogue", menuName = "MyShadow/Dialogue", order = 1)]
	public class DialogueScriptableObject : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x200009F")]
		public struct DialogueLineContent
		{
			[Token(Token = "0x4000338")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Sprite image;

			[Token(Token = "0x4000339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string line;
		}

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<DialogueLineContent> dialogueLines;

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x783C0C", Offset = "0x783C0C", VA = "0x783C0C")]
		public DialogueScriptableObject()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[CreateAssetMenu(fileName = "dialogueV2", menuName = "MyShadow/DialogueV2", order = 2)]
	public class DialogueScriptableObjectV2 : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x20000A1")]
		public struct DialogueLineContent
		{
			[Token(Token = "0x20000A2")]
			public enum speakerName
			{
				[Token(Token = "0x4000341")]
				Viktor,
				[Token(Token = "0x4000342")]
				BusinessMan,
				[Token(Token = "0x4000343")]
				BusinessWoman,
				[Token(Token = "0x4000344")]
				MrFarmer,
				[Token(Token = "0x4000345")]
				MissFarmer,
				[Token(Token = "0x4000346")]
				Fisherman,
				[Token(Token = "0x4000347")]
				FisherWoman,
				[Token(Token = "0x4000348")]
				MrMechanic,
				[Token(Token = "0x4000349")]
				MissMechanic,
				[Token(Token = "0x400034A")]
				MrTrainer,
				[Token(Token = "0x400034B")]
				MissTrainer,
				[Token(Token = "0x400034C")]
				Cultist,
				[Token(Token = "0x400034D")]
				Balle,
				[Token(Token = "0x400034E")]
				noname
			}

			[Token(Token = "0x20000A3")]
			public enum speakerMood
			{
				[Token(Token = "0x4000350")]
				Neutral,
				[Token(Token = "0x4000351")]
				Happy,
				[Token(Token = "0x4000352")]
				Angry
			}

			[Token(Token = "0x20000A4")]
			public enum imagePositions
			{
				[Token(Token = "0x4000354")]
				Left,
				[Token(Token = "0x4000355")]
				Right
			}

			[Token(Token = "0x400033B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public speakerName speaker;

			[Token(Token = "0x400033C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public speakerMood mood;

			[Token(Token = "0x400033D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[HideInInspector]
			public Sprite speakerImage;

			[Token(Token = "0x400033E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public imagePositions imagePosition;

			[Token(Token = "0x400033F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[TextArea(5, 4)]
			public string line;
		}

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<DialogueLineContent> dialogueLines;

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x783C14", Offset = "0x783C14", VA = "0x783C14")]
		public DialogueScriptableObjectV2()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class DoubleBubbleAudioPlayer : MonoBehaviour
	{
		[Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private sealed class <LoopSpeaking>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400035F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000360")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DoubleBubbleAudioPlayer <>4__this;

			[Token(Token = "0x17000087")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600033E")]
				[Address(RVA = "0x783E74", Offset = "0x783E74", VA = "0x783E74", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000088")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000340")]
				[Address(RVA = "0x783EBC", Offset = "0x783EBC", VA = "0x783EBC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600033B")]
			[Address(RVA = "0x783C94", Offset = "0x783C94", VA = "0x783C94")]
			[DebuggerHidden]
			public <LoopSpeaking>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x600033C")]
			[Address(RVA = "0x783CCC", Offset = "0x783CCC", VA = "0x783CCC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600033D")]
			[Address(RVA = "0x783CD0", Offset = "0x783CD0", VA = "0x783CD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600033F")]
			[Address(RVA = "0x783E7C", Offset = "0x783E7C", VA = "0x783E7C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Audio sources")]
		[SerializeField]
		private AudioSource audioSourceSpeaking;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioSource audioSourcePageTurn;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Header("Sounds")]
		private AudioClip[] speakingSound;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip turningPageWritingSound;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Header("Clip play settings")]
		private bool playOneClip;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[SerializeField]
		private bool dontCutClip;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Header("Speaking delay settings")]
		private float startDelayOnNewBubble;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float delayBetweenClips;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool stopSpeaking;

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x783C1C", Offset = "0x783C1C", VA = "0x783C1C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x783814", Offset = "0x783814", VA = "0x783814")]
		public void PlaySpeakingSound()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x783C20", Offset = "0x783C20", VA = "0x783C20")]
		[IteratorStateMachine(typeof(<LoopSpeaking>d__11))]
		private IEnumerator LoopSpeaking()
		{
			return null;
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x7838A0", Offset = "0x7838A0", VA = "0x7838A0")]
		public void MoreClicked()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x783838", Offset = "0x783838", VA = "0x783838")]
		public void StopSpeakingSound()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x78386C", Offset = "0x78386C", VA = "0x78386C")]
		public void PlayTurningPageWritingSound()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x783CBC", Offset = "0x783CBC", VA = "0x783CBC")]
		public DoubleBubbleAudioPlayer()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class DoubleBubbleDialogue : MonoBehaviour
	{
		[Token(Token = "0x20000A8")]
		[CompilerGenerated]
		private sealed class <ShowAfter>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4000379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DoubleBubbleDialogue <>4__this;

			[Token(Token = "0x17000089")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000351")]
				[Address(RVA = "0x784AC0", Offset = "0x784AC0", VA = "0x784AC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000353")]
				[Address(RVA = "0x784B08", Offset = "0x784B08", VA = "0x784B08", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600034E")]
			[Address(RVA = "0x7845B0", Offset = "0x7845B0", VA = "0x7845B0")]
			[DebuggerHidden]
			public <ShowAfter>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x600034F")]
			[Address(RVA = "0x784A04", Offset = "0x784A04", VA = "0x784A04", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000350")]
			[Address(RVA = "0x784A08", Offset = "0x784A08", VA = "0x784A08", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000352")]
			[Address(RVA = "0x784AC8", Offset = "0x784AC8", VA = "0x784AC8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Dialogue goes here")]
		[SerializeField]
		private DialogueScriptableObjectV2 dialogueToPlay;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Dialogue settings")]
		[SerializeField]
		private bool setDialogueIndividually;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool CanBeTriggeredMultipleTimes;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEvent afterDialogueEvent;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string customSpeakerName;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Header("PC Player Canvas")]
		private CanvasGroup canvasGroupPC;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform canvasTransformPC;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private DialogueCanvasV2 dialogueCanvasPC;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("VR Player Canvas")]
		public CanvasGroup canvasGroupVR;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform canvasTransformVR;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public DialogueCanvasV2 dialogueCanvasVR;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Header("MyShadowCanvas in scene")]
		private GameObject myShadowCanvas;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool dialogueOpen;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Header("Visible for debugging. Do not touch.")]
		private GameObject seeker;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float seekerDefaultSpeed;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private bool m_Triggered;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
		public bool pcPlayerActive;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
		public bool hidden;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Header("MovableNPC with Animator, talks with this dialogue")]
		public Animator TalkingNPCAnim;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool setupDone;

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x783EC4", Offset = "0x783EC4", VA = "0x783EC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x783FE8", Offset = "0x783FE8", VA = "0x783FE8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x7841C8", Offset = "0x7841C8", VA = "0x7841C8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x7841CC", Offset = "0x7841CC", VA = "0x7841CC")]
		public void Setup()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x784498", Offset = "0x784498", VA = "0x784498")]
		public bool DialogueIsOpen()
		{
			return default(bool);
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x78450C", Offset = "0x78450C", VA = "0x78450C")]
		public void ShowDelayed(float delay)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x78452C", Offset = "0x78452C", VA = "0x78452C")]
		[IteratorStateMachine(typeof(<ShowAfter>d__26))]
		private IEnumerator ShowAfter(float delay)
		{
			return null;
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x7845D8", Offset = "0x7845D8", VA = "0x7845D8")]
		public void Show()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x7838C4", Offset = "0x7838C4", VA = "0x7838C4")]
		public void Hide()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x784950", Offset = "0x784950", VA = "0x784950")]
		public void TestEvent()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x7849B8", Offset = "0x7849B8", VA = "0x7849B8")]
		public DoubleBubbleDialogue()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class UISettingsCanvasDoubleBubble : MonoBehaviour
	{
		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool lookAtPlayer;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Canvas m_Canvas;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Camera to follow")]
		[SerializeField]
		private Camera m_Camera;

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x784B10", Offset = "0x784B10", VA = "0x784B10")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x784B68", Offset = "0x784B68", VA = "0x784B68")]
		private void Start()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x784BE4", Offset = "0x784BE4", VA = "0x784BE4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x784D40", Offset = "0x784D40", VA = "0x784D40")]
		public UISettingsCanvasDoubleBubble()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public class DevTestTool : MonoBehaviour
	{
		[Token(Token = "0x20000AB")]
		[CompilerGenerated]
		private sealed class <SetIsPCPlayer>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DevTestTool <>4__this;

			[Token(Token = "0x1700008B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600035E")]
				[Address(RVA = "0x785048", Offset = "0x785048", VA = "0x785048", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000360")]
				[Address(RVA = "0x785090", Offset = "0x785090", VA = "0x785090", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600035B")]
			[Address(RVA = "0x784E94", Offset = "0x784E94", VA = "0x784E94")]
			[DebuggerHidden]
			public <SetIsPCPlayer>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x600035C")]
			[Address(RVA = "0x784ECC", Offset = "0x784ECC", VA = "0x784ECC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600035D")]
			[Address(RVA = "0x784ED0", Offset = "0x784ED0", VA = "0x784ED0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600035F")]
			[Address(RVA = "0x785050", Offset = "0x785050", VA = "0x785050", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("DevTestTool settings")]
		[SerializeField]
		public bool hideMouseCursor;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		[Header("Visible for debugging. Do not change.")]
		public bool holdMouse;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject cameraRig;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject player;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isPCPlayer;

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x784D50", Offset = "0x784D50", VA = "0x784D50")]
		private void Start()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x784E20", Offset = "0x784E20", VA = "0x784E20")]
		[IteratorStateMachine(typeof(<SetIsPCPlayer>d__6))]
		private IEnumerator SetIsPCPlayer()
		{
			return null;
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x784EBC", Offset = "0x784EBC", VA = "0x784EBC")]
		public DevTestTool()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class DTTMouseLook : MonoBehaviour
	{
		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float mouseSensitivity;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform devToolBody;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool holdMouse;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float xRotation;

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x785098", Offset = "0x785098", VA = "0x785098")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x7851A4", Offset = "0x7851A4", VA = "0x7851A4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x785238", Offset = "0x785238", VA = "0x785238")]
		private void Update()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x7853D0", Offset = "0x7853D0", VA = "0x7853D0")]
		public DTTMouseLook()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class DTTSeekerAndCameraControls : MonoBehaviour
	{
		[Token(Token = "0x20000AE")]
		[CompilerGenerated]
		private sealed class <LookForCameras>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DTTSeekerAndCameraControls <>4__this;

			[Token(Token = "0x1700008D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600036E")]
				[Address(RVA = "0x7859BC", Offset = "0x7859BC", VA = "0x7859BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000370")]
				[Address(RVA = "0x785A04", Offset = "0x785A04", VA = "0x785A04", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600036B")]
			[Address(RVA = "0x785638", Offset = "0x785638", VA = "0x785638")]
			[DebuggerHidden]
			public <LookForCameras>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x600036C")]
			[Address(RVA = "0x785770", Offset = "0x785770", VA = "0x785770", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600036D")]
			[Address(RVA = "0x785774", Offset = "0x785774", VA = "0x785774", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600036F")]
			[Address(RVA = "0x7859C4", Offset = "0x7859C4", VA = "0x7859C4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Header("Do not set manually")]
		private Camera playerCamera;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Camera devTestToolCamera;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject playerCamObj;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject dttCamObj;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool playerCamSet;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool devTestToolCamSet;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		private bool cameraSelected;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject player;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float playerDefaultSpeed;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GUIStyle myStyle;

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x7853D8", Offset = "0x7853D8", VA = "0x7853D8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x78546C", Offset = "0x78546C", VA = "0x78546C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x7853F8", Offset = "0x7853F8", VA = "0x7853F8")]
		[IteratorStateMachine(typeof(<LookForCameras>d__12))]
		private IEnumerator LookForCameras()
		{
			return null;
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x785470", Offset = "0x785470", VA = "0x785470")]
		private void ChangeCamera()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x785660", Offset = "0x785660", VA = "0x785660")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x785768", Offset = "0x785768", VA = "0x785768")]
		public DTTSeekerAndCameraControls()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class EventTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool condition1;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool condition2;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEvent EventToTrigger;

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x785A0C", Offset = "0x785A0C", VA = "0x785A0C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x785A30", Offset = "0x785A30", VA = "0x785A30")]
		public void TryToTriggerEvent()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x785A54", Offset = "0x785A54", VA = "0x785A54")]
		public void SetTrue(int condition)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x785A9C", Offset = "0x785A9C", VA = "0x785A9C")]
		public EventTrigger()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class ActivateLevelComplete : MonoBehaviour
	{
		[Token(Token = "0x20000B1")]
		[CompilerGenerated]
		private sealed class <LevelCompleteAfter>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ActivateLevelComplete <>4__this;

			[Token(Token = "0x1700008F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600037B")]
				[Address(RVA = "0x785DF0", Offset = "0x785DF0", VA = "0x785DF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000090")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600037D")]
				[Address(RVA = "0x785E38", Offset = "0x785E38", VA = "0x785E38", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000378")]
			[Address(RVA = "0x785B38", Offset = "0x785B38", VA = "0x785B38")]
			[DebuggerHidden]
			public <LevelCompleteAfter>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000379")]
			[Address(RVA = "0x785B68", Offset = "0x785B68", VA = "0x785B68", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600037A")]
			[Address(RVA = "0x785B6C", Offset = "0x785B6C", VA = "0x785B6C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600037C")]
			[Address(RVA = "0x785DF8", Offset = "0x785DF8", VA = "0x785DF8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float activateLevelCompleteAfter;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEvent OnLevelComplete;

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x785AA4", Offset = "0x785AA4", VA = "0x785AA4")]
		public void StartLevelCompleteCountDown()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x785AC4", Offset = "0x785AC4", VA = "0x785AC4")]
		[IteratorStateMachine(typeof(<LevelCompleteAfter>d__3))]
		private IEnumerator LevelCompleteAfter()
		{
			return null;
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x785B60", Offset = "0x785B60", VA = "0x785B60")]
		public ActivateLevelComplete()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public class AwardAchievement : MonoBehaviour
	{
		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string achievementKey;

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x785E40", Offset = "0x785E40", VA = "0x785E40")]
		public void Award()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x785E98", Offset = "0x785E98", VA = "0x785E98")]
		public AwardAchievement()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public class CutsceneManager : MonoBehaviour
	{
		[Token(Token = "0x20000B4")]
		[CompilerGenerated]
		private sealed class <BackToLevel>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CutsceneManager <>4__this;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private AsyncOperation <loadOperation>5__2;

			[Token(Token = "0x17000091")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000386")]
				[Address(RVA = "0x7860FC", Offset = "0x7860FC", VA = "0x7860FC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000092")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000388")]
				[Address(RVA = "0x786144", Offset = "0x786144", VA = "0x786144", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000383")]
			[Address(RVA = "0x785F34", Offset = "0x785F34", VA = "0x785F34")]
			[DebuggerHidden]
			public <BackToLevel>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000384")]
			[Address(RVA = "0x785F64", Offset = "0x785F64", VA = "0x785F64", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000385")]
			[Address(RVA = "0x785F68", Offset = "0x785F68", VA = "0x785F68", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000387")]
			[Address(RVA = "0x786104", Offset = "0x786104", VA = "0x786104", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float cutsceneLength;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string sceneToLoad;

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x785EA0", Offset = "0x785EA0", VA = "0x785EA0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x785EC0", Offset = "0x785EC0", VA = "0x785EC0")]
		[IteratorStateMachine(typeof(<BackToLevel>d__3))]
		private IEnumerator BackToLevel()
		{
			return null;
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x785F5C", Offset = "0x785F5C", VA = "0x785F5C")]
		public CutsceneManager()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	public class EggNote : MonoBehaviour
	{
		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int eggAmount;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Text eggAmountText;

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x78614C", Offset = "0x78614C", VA = "0x78614C")]
		private void Start()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x7863DC", Offset = "0x7863DC", VA = "0x7863DC")]
		private void Update()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x7863E0", Offset = "0x7863E0", VA = "0x7863E0")]
		public EggNote()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public class GameManager : MonoBehaviour
	{
		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static GameManager manager;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Demo build - limited levels")]
		public bool demoBuild;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Collected")]
		[SerializeField]
		private List<string> collectedItems;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Levels")]
		public int amountOfLevels;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int indexOfFirstLevel;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int indexOfLastLevel;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int indexOfLastLevelInDemo;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<int> unlockedLevels;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<int> levelsWithEggLock;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private int currentLevel;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Seeker Card Materials - add here")]
		[SerializeField]
		private List<Material> seekerCards;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Material cardBacksideMaterial;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("Options for development")]
		[SerializeField]
		private bool unlockAllLevels;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[SerializeField]
		private bool resetCollectablesOnStart;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		[SerializeField]
		private bool resetUnlockedLevelsOnStart;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		[Header("Preferences")]
		public bool moveWithRightHand;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool lastInputFromGamepad;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("DON'T CHANGE")]
		[SerializeField]
		private string saveFilePath;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string previousLanguage;

		[Token(Token = "0x17000093")]
		public int CurrentLevel
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x7872CC", Offset = "0x7872CC", VA = "0x7872CC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x7872D4", Offset = "0x7872D4", VA = "0x7872D4")]
			set
			{
			}
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x7863E8", Offset = "0x7863E8", VA = "0x7863E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x786AD8", Offset = "0x786AD8", VA = "0x786AD8")]
		private void Start()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x786BB8", Offset = "0x786BB8", VA = "0x786BB8")]
		public bool LevelIsUnlocked(int sceneNumber)
		{
			return default(bool);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x786C10", Offset = "0x786C10", VA = "0x786C10")]
		public bool LevelHasEggLock(int sceneNumber)
		{
			return default(bool);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x786C68", Offset = "0x786C68", VA = "0x786C68")]
		public void UnlockLevel(int sceneNumber)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x786D68", Offset = "0x786D68", VA = "0x786D68")]
		public void RemoveEggLockAndUnlockLevel(int sceneNumber)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x7869C8", Offset = "0x7869C8", VA = "0x7869C8")]
		public void UnlockAllLevels()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x786DF8", Offset = "0x786DF8", VA = "0x786DF8")]
		public bool ItemIsCollected(string collectableID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x786E50", Offset = "0x786E50", VA = "0x786E50")]
		public void CollectItem(string collectableID)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x786204", Offset = "0x786204", VA = "0x786204")]
		public int GetAmountOfEggs()
		{
			return default(int);
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x786F38", Offset = "0x786F38", VA = "0x786F38")]
		public int GetAmountOfCards()
		{
			return default(int);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x786888", Offset = "0x786888", VA = "0x786888")]
		public void ResetCollectables()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x786930", Offset = "0x786930", VA = "0x786930")]
		public void ResetUnlockedLevels()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x7870B4", Offset = "0x7870B4", VA = "0x7870B4")]
		public void EraseGameData()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x78714C", Offset = "0x78714C", VA = "0x78714C")]
		public Material GetMaterial(string sceneName)
		{
			return null;
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x7865E0", Offset = "0x7865E0", VA = "0x7865E0")]
		private void CreateSingleton()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x7872DC", Offset = "0x7872DC", VA = "0x7872DC")]
		public void SaveGame()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x786700", Offset = "0x786700", VA = "0x786700")]
		public void LoadGame()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x7874F0", Offset = "0x7874F0", VA = "0x7874F0")]
		public GameManager()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B7")]
	internal class GameData
	{
		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int currentLevel;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> unlockedLevels;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<int> levelsWithEggLock;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<string> collectedItems;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveWithRightHand;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string previousLanguage;

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x7873E8", Offset = "0x7873E8", VA = "0x7873E8")]
		public GameData()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public class KeyboardTests : MonoBehaviour
	{
		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[TextArea]
		[Header("Keyboard Tests")]
		[Tooltip("DISABLE FOR BUILDS")]
		public string Notes;

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x787654", Offset = "0x787654", VA = "0x787654")]
		private void Start()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x7876C0", Offset = "0x7876C0", VA = "0x7876C0")]
		private void Update()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x7876C4", Offset = "0x7876C4", VA = "0x7876C4")]
		public void KeyBoardControlsForTesting()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x787C4C", Offset = "0x787C4C", VA = "0x787C4C")]
		public KeyboardTests()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public class LevelComplete : MonoBehaviour
	{
		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("All variables automated")]
		[SerializeField]
		private int levelIndex;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private OutroFader outroFader;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool levelComplete;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool nextLevelEggLocked;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string nextLevelName;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SteamVR_LoadLevel loadLevel;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject endStar;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool lastLevel;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool loadStarted;

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x787CA4", Offset = "0x787CA4", VA = "0x787CA4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x787E78", Offset = "0x787E78", VA = "0x787E78")]
		private void Update()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x785C5C", Offset = "0x785C5C", VA = "0x785C5C")]
		public void LevelCompleted()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x787F14", Offset = "0x787F14", VA = "0x787F14")]
		public LevelComplete()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public class LevelLock : MonoBehaviour
	{
		[Token(Token = "0x20000BB")]
		[CompilerGenerated]
		private sealed class <UnlockLock>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LevelLock <>4__this;

			[Token(Token = "0x17000094")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003B4")]
				[Address(RVA = "0x7886BC", Offset = "0x7886BC", VA = "0x7886BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000095")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003B6")]
				[Address(RVA = "0x788704", Offset = "0x788704", VA = "0x788704", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x788418", Offset = "0x788418", VA = "0x788418")]
			[DebuggerHidden]
			public <UnlockLock>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x78849C", Offset = "0x78849C", VA = "0x78849C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x7884A0", Offset = "0x7884A0", VA = "0x7884A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x7886C4", Offset = "0x7886C4", VA = "0x7886C4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Settings")]
		public bool hasEggLock;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int eggsNeededToUnlock;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text eggAmountText;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject lockObject;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MenuBook menuBook;

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x787F1C", Offset = "0x787F1C", VA = "0x787F1C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x788048", Offset = "0x788048", VA = "0x788048")]
		public void CheckLock()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x78828C", Offset = "0x78828C", VA = "0x78828C")]
		public void ShowLock()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x7883A4", Offset = "0x7883A4", VA = "0x7883A4")]
		[IteratorStateMachine(typeof(<UnlockLock>d__9))]
		public IEnumerator UnlockLock()
		{
			return null;
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x787FA0", Offset = "0x787FA0", VA = "0x787FA0")]
		public void DisableLock()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x788440", Offset = "0x788440", VA = "0x788440")]
		public void ShakeLock()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x788494", Offset = "0x788494", VA = "0x788494")]
		public LevelLock()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class LoadCutscene : MonoBehaviour
	{
		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string cutSceneName;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool cutscenePlayed;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool cutsceneIsPlayed;

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x78870C", Offset = "0x78870C", VA = "0x78870C")]
		private void Start()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x7887A4", Offset = "0x7887A4", VA = "0x7887A4")]
		private void Update()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x7887A8", Offset = "0x7887A8", VA = "0x7887A8")]
		public void SetCutScenePlayed(bool isPlayed)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x7887F4", Offset = "0x7887F4", VA = "0x7887F4")]
		public LoadCutscene()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public class NextLevel : MonoBehaviour
	{
		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int nextLevel;

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x7887FC", Offset = "0x7887FC", VA = "0x7887FC")]
		private void Start()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x7888AC", Offset = "0x7888AC", VA = "0x7888AC")]
		private void Update()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x7888B0", Offset = "0x7888B0", VA = "0x7888B0")]
		public NextLevel()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	public class SteamAchievements : MonoBehaviour
	{
		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static SteamAchievements achievementManager;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int amountOfEggs;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int amountOfCards;

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x7888B8", Offset = "0x7888B8", VA = "0x7888B8")]
		private void Start()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x7888BC", Offset = "0x7888BC", VA = "0x7888BC")]
		private void CreateSingleton()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x785E90", Offset = "0x785E90", VA = "0x785E90")]
		public void AwardAchievement(string key)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x785E94", Offset = "0x785E94", VA = "0x785E94")]
		public void AwardPS5Trophy(int trophyID)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x7889A4", Offset = "0x7889A4", VA = "0x7889A4")]
		public SteamAchievements()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class SteamCheck : MonoBehaviour
	{
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x7889AC", Offset = "0x7889AC", VA = "0x7889AC")]
		private void Start()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x7889B0", Offset = "0x7889B0", VA = "0x7889B0")]
		private void Update()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x7889B4", Offset = "0x7889B4", VA = "0x7889B4")]
		public SteamCheck()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public class ItemPlatformParenter : MonoBehaviour
	{
		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Header("Trigger object tags")]
		private string objectTag;

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x7889BC", Offset = "0x7889BC", VA = "0x7889BC")]
		private void OnTriggerEnter(Collider col)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x788A8C", Offset = "0x788A8C", VA = "0x788A8C")]
		private void OnTriggerExit(Collider col)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x788B48", Offset = "0x788B48", VA = "0x788B48")]
		public ItemPlatformParenter()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	public static class MyShadowEvents
	{
		[Token(Token = "0x20000C2")]
		public abstract class Action
		{
			[Token(Token = "0x17000096")]
			public bool enabled
			{
				[Token(Token = "0x60003CC")]
				[Address(RVA = "0x788C94", Offset = "0x788C94", VA = "0x788C94")]
				set
				{
				}
			}

			[Token(Token = "0x60003CB")]
			public abstract void Enable(bool enabled);

			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x788CA4", Offset = "0x788CA4", VA = "0x788CA4")]
			protected Action()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C3")]
		public class ActionNoArgs : Action
		{
			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Event _event;

			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UnityAction action;

			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x788CAC", Offset = "0x788CAC", VA = "0x788CAC")]
			public ActionNoArgs(Event _event, UnityAction action)
			{
			}

			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x788CF0", Offset = "0x788CF0", VA = "0x788CF0", Slot = "4")]
			public override void Enable(bool enabled)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C4")]
		public class Action<T> : Action
		{
			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Event<T> _event;

			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private UnityAction<T> action;

			[Token(Token = "0x60003D0")]
			public Action(Event<T> _event, UnityAction<T> action)
			{
			}

			[Token(Token = "0x60003D1")]
			public override void Enable(bool enabled)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C5")]
		public class Action<T0, T1> : Action
		{
			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Event<T0, T1> _event;

			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private UnityAction<T0, T1> action;

			[Token(Token = "0x60003D2")]
			public Action(Event<T0, T1> _event, UnityAction<T0, T1> action)
			{
			}

			[Token(Token = "0x60003D3")]
			public override void Enable(bool enabled)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C6")]
		public class Action<T0, T1, T2> : Action
		{
			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Event<T0, T1, T2> _event;

			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private UnityAction<T0, T1, T2> action;

			[Token(Token = "0x60003D4")]
			public Action(Event<T0, T1, T2> _event, UnityAction<T0, T1, T2> action)
			{
			}

			[Token(Token = "0x60003D5")]
			public override void Enable(bool enabled)
			{
			}
		}

		[Token(Token = "0x20000C7")]
		public class Event : UnityEvent
		{
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x788D24", Offset = "0x788D24", VA = "0x788D24")]
			public void Listen(UnityAction action)
			{
			}

			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x788D2C", Offset = "0x788D2C", VA = "0x788D2C")]
			public void Remove(UnityAction action)
			{
			}

			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x788D34", Offset = "0x788D34", VA = "0x788D34")]
			public void Send()
			{
			}

			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x788D3C", Offset = "0x788D3C", VA = "0x788D3C")]
			public Event()
			{
			}
		}

		[Token(Token = "0x20000C8")]
		public class Event<T> : UnityEvent<T>
		{
			[Token(Token = "0x60003DA")]
			public void Listen(UnityAction<T> action)
			{
			}

			[Token(Token = "0x60003DB")]
			public void Remove(UnityAction<T> action)
			{
			}

			[Token(Token = "0x60003DC")]
			public void Send(T arg0)
			{
			}

			[Token(Token = "0x60003DD")]
			public Event()
			{
			}
		}

		[Token(Token = "0x20000C9")]
		public class Event<T0, T1> : UnityEvent<T0, T1>
		{
			[Token(Token = "0x60003DE")]
			public void Listen(UnityAction<T0, T1> action)
			{
			}

			[Token(Token = "0x60003DF")]
			public void Remove(UnityAction<T0, T1> action)
			{
			}

			[Token(Token = "0x60003E0")]
			public void Send(T0 arg0, T1 arg1)
			{
			}

			[Token(Token = "0x60003E1")]
			public Event()
			{
			}
		}

		[Token(Token = "0x20000CA")]
		public class Event<T0, T1, T2> : UnityEvent<T0, T1, T2>
		{
			[Token(Token = "0x60003E2")]
			public void Listen(UnityAction<T0, T1, T2> action)
			{
			}

			[Token(Token = "0x60003E3")]
			public void Remove(UnityAction<T0, T1, T2> action)
			{
			}

			[Token(Token = "0x60003E4")]
			public void Send(T0 arg0, T1 arg1, T2 arg2)
			{
			}

			[Token(Token = "0x60003E5")]
			public Event()
			{
			}
		}

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Event<string, string> UIMessage;

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x788B50", Offset = "0x788B50", VA = "0x788B50")]
		public static Action UIMessageAction(UnityAction<string, string> action)
		{
			return null;
		}
	}
	[Token(Token = "0x20000CB")]
	public class FirstDialogueLauncher : MonoBehaviour
	{
		[Token(Token = "0x20000CC")]
		[CompilerGenerated]
		private sealed class <LaunchDialogue>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FirstDialogueLauncher <>4__this;

			[Token(Token = "0x17000097")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003EC")]
				[Address(RVA = "0x788ED0", Offset = "0x788ED0", VA = "0x788ED0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000098")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003EE")]
				[Address(RVA = "0x788F18", Offset = "0x788F18", VA = "0x788F18", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x788DD8", Offset = "0x788DD8", VA = "0x788DD8")]
			[DebuggerHidden]
			public <LaunchDialogue>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x788E08", Offset = "0x788E08", VA = "0x788E08", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x788E0C", Offset = "0x788E0C", VA = "0x788E0C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x788ED8", Offset = "0x788ED8", VA = "0x788ED8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DoubleBubbleDialogue firstDialogue;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float waitTimeBeforeDialogue;

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x788D44", Offset = "0x788D44", VA = "0x788D44")]
		public void StartDialogueAfter()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x788D64", Offset = "0x788D64", VA = "0x788D64")]
		[IteratorStateMachine(typeof(<LaunchDialogue>d__3))]
		private IEnumerator LaunchDialogue()
		{
			return null;
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x788E00", Offset = "0x788E00", VA = "0x788E00")]
		public FirstDialogueLauncher()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class FreezingSeeker : MonoBehaviour
	{
		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Header("Settings")]
		private float freezingSpeed;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float meltingSpeed;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float animSlowingFactor;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEvent OnMelted;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Header("Debug")]
		private float freezeAmount;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool isNextToFire;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject iceCube;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Animator animator;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float cubeX;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float cubeY;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float cubeZ;

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x788F20", Offset = "0x788F20", VA = "0x788F20")]
		private void Start()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x78903C", Offset = "0x78903C", VA = "0x78903C")]
		private void Update()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x789130", Offset = "0x789130", VA = "0x789130")]
		public void StartMelting()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x78913C", Offset = "0x78913C", VA = "0x78913C")]
		public void StopMelting()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x789150", Offset = "0x789150", VA = "0x789150")]
		public void StartFreezing()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x7890BC", Offset = "0x7890BC", VA = "0x7890BC")]
		public void Melt()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x78917C", Offset = "0x78917C", VA = "0x78917C")]
		public void Freeze()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x7891BC", Offset = "0x7891BC", VA = "0x7891BC")]
		public FreezingSeeker()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class NPCInteractIcon : MonoBehaviour
	{
		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GameObject interactIcon;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool iconVisible;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool iconActive;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		private bool dialogueStarted;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Header("Settings")]
		[SerializeField]
		private float visibleRadius;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float talkingRadius;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float turningSpeed;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Automated")]
		[SerializeField]
		private DoubleBubbleDialogue npcDialogue;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject player;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform seekerNose;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SeekerInteract seekerInteract;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("Debug")]
		public float playerDistance;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool isWalking;

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x78A1CC", Offset = "0x78A1CC", VA = "0x78A1CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x78A280", Offset = "0x78A280", VA = "0x78A280")]
		private void Start()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x78A44C", Offset = "0x78A44C", VA = "0x78A44C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x78A654", Offset = "0x78A654", VA = "0x78A654")]
		private void Update()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x78ACB0", Offset = "0x78ACB0", VA = "0x78ACB0")]
		public void ShowIcon()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x78A3B0", Offset = "0x78A3B0", VA = "0x78A3B0")]
		public void HideIcon()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x78AD10", Offset = "0x78AD10", VA = "0x78AD10")]
		public void TryStartDialogue()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x78A4BC", Offset = "0x78A4BC", VA = "0x78A4BC")]
		public void AssignPlayer()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x78AC48", Offset = "0x78AC48", VA = "0x78AC48")]
		public void InteractIconActive(bool isActive)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x78AF24", Offset = "0x78AF24", VA = "0x78AF24")]
		private void DialogueDone()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x78AF48", Offset = "0x78AF48", VA = "0x78AF48")]
		public void ChangeDialogue(DoubleBubbleDialogue newDialogue)
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x78AF50", Offset = "0x78AF50", VA = "0x78AF50")]
		public NPCInteractIcon()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class ThrowingCrystape : MonoBehaviour
	{
		[Token(Token = "0x20000D0")]
		[CompilerGenerated]
		private sealed class <Throw>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ThrowingCrystape <>4__this;

			[Token(Token = "0x17000099")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600040B")]
				[Address(RVA = "0x78B564", Offset = "0x78B564", VA = "0x78B564", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600040D")]
				[Address(RVA = "0x78B5AC", Offset = "0x78B5AC", VA = "0x78B5AC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000408")]
			[Address(RVA = "0x78B180", Offset = "0x78B180", VA = "0x78B180")]
			[DebuggerHidden]
			public <Throw>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000409")]
			[Address(RVA = "0x78B1B0", Offset = "0x78B1B0", VA = "0x78B1B0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600040A")]
			[Address(RVA = "0x78B1B4", Offset = "0x78B1B4", VA = "0x78B1B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600040C")]
			[Address(RVA = "0x78B56C", Offset = "0x78B56C", VA = "0x78B56C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Objects")]
		[SerializeField]
		private GameObject objectToThrow;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform throwPos;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject player;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private FireStarter fireStarter;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject interactObject;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool interactObjVisible;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Header("Settings")]
		[SerializeField]
		private float minForce;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float maxForce;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float interactDistance;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float throwFrequency;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float throwFrequencyCounter;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Animator anim;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float throwDelayForAnim;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public UnityEvent OnThrow;

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x78AF58", Offset = "0x78AF58", VA = "0x78AF58")]
		private void Start()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x78AFBC", Offset = "0x78AFBC", VA = "0x78AFBC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x78AFF0", Offset = "0x78AFF0", VA = "0x78AFF0")]
		public void ThrowItem()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x78B10C", Offset = "0x78B10C", VA = "0x78B10C")]
		[IteratorStateMachine(typeof(<Throw>d__17))]
		private IEnumerator Throw()
		{
			return null;
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x78B1A8", Offset = "0x78B1A8", VA = "0x78B1A8")]
		public ThrowingCrystape()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class Button : MonoBehaviour
	{
		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityEvent OnButtonPressed;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_Pressed;

		[Token(Token = "0x14000002")]
		public event Action<Button> ButtonPressedEvent
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0x78B5B4", Offset = "0x78B5B4", VA = "0x78B5B4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600040F")]
			[Address(RVA = "0x78B664", Offset = "0x78B664", VA = "0x78B664")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x78B714", Offset = "0x78B714", VA = "0x78B714")]
		public void Press()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x78B764", Offset = "0x78B764", VA = "0x78B764")]
		public void ResetButton()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x78B76C", Offset = "0x78B76C", VA = "0x78B76C")]
		public Button()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class ButtonCodePuzzle : MonoBehaviour
	{
		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] buttonsInOrder;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject nextButton;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int nextButtonIndex;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityEvent OnCorrectCodeEntered;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UnityEvent OnWrongButtonPressed;

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x78B774", Offset = "0x78B774", VA = "0x78B774")]
		private void Start()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x78B7B0", Offset = "0x78B7B0", VA = "0x78B7B0")]
		public void ButtonPressed(GameObject button)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x78B8FC", Offset = "0x78B8FC", VA = "0x78B8FC")]
		public void PuzzleComplete()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x78B978", Offset = "0x78B978", VA = "0x78B978")]
		public void ResetPuzzle()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x78BA88", Offset = "0x78BA88", VA = "0x78BA88")]
		public ButtonCodePuzzle()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class ButtonCombinator : MonoBehaviour
	{
		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Button[] correctOrder;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Button[] allButtons;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEvent OnSuccess;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityEvent OnFailure;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Button> m_PressedButtons;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int m_CurrentIndex;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool m_Enabled;

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x78BA90", Offset = "0x78BA90", VA = "0x78BA90")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x78BB60", Offset = "0x78BB60", VA = "0x78BB60")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x78BC30", Offset = "0x78BC30", VA = "0x78BC30")]
		private void Awake()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x78BCAC", Offset = "0x78BCAC", VA = "0x78BCAC")]
		private void HandleButtonPressed(Button button)
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x78BE44", Offset = "0x78BE44", VA = "0x78BE44")]
		private void Success()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x78BF74", Offset = "0x78BF74", VA = "0x78BF74")]
		private void Fail()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x78C11C", Offset = "0x78C11C", VA = "0x78C11C")]
		public ButtonCombinator()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class ButtonTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Properties")]
		[SerializeField]
		private bool useableBySeeker;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool useableByOther;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[SerializeField]
		private bool isToggle;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Material colorUseableBySeeker;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Material colorUseableByOther;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Material colorUseableByBoth;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string tagTrigger1;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string tagTrigger2;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Events")]
		public UnityEvent TriggerEnter;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityEvent TriggerExit;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Header("Debug - don't touch")]
		private bool isTriggeredBy1;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		[SerializeField]
		private bool isTriggeredBy2;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		[SerializeField]
		private bool isPressed;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject buttonPlatform;

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x78C12C", Offset = "0x78C12C", VA = "0x78C12C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x78C21C", Offset = "0x78C21C", VA = "0x78C21C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x78C368", Offset = "0x78C368", VA = "0x78C368")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x78C47C", Offset = "0x78C47C", VA = "0x78C47C")]
		public ButtonTrigger()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class CampFire : MonoBehaviour
	{
		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int amountOfWoodSpots;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int amountOfEmptyWoodSpots;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] woodObjects;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Material filledWoodSpotMat;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material defaultMat;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string triggerTag;

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x78C500", Offset = "0x78C500", VA = "0x78C500")]
		private void Start()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x78C584", Offset = "0x78C584", VA = "0x78C584")]
		public void AddWoodToFirePlace()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x78C690", Offset = "0x78C690", VA = "0x78C690")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x78C62C", Offset = "0x78C62C", VA = "0x78C62C")]
		public void UpdateBurningTime()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x78C804", Offset = "0x78C804", VA = "0x78C804")]
		public void ResetWood()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x78C8A4", Offset = "0x78C8A4", VA = "0x78C8A4")]
		public CampFire()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class Collectable : MonoBehaviour
	{
		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Properties")]
		public string collectableID;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool isInCollection;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool collectedThisRound;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEvent OnFirstCollect;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityEvent OnLaterCollect;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UnityEvent OnCollectedThisRound;

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x78C8FC", Offset = "0x78C8FC", VA = "0x78C8FC")]
		private void Start()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x78C900", Offset = "0x78C900", VA = "0x78C900")]
		public void CheckEggStatus()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x78C984", Offset = "0x78C984", VA = "0x78C984")]
		public void FirstCollect()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x78CA0C", Offset = "0x78CA0C", VA = "0x78CA0C")]
		public void Collected()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x78CA94", Offset = "0x78CA94", VA = "0x78CA94")]
		public void ResetCollectable()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x78CAE8", Offset = "0x78CAE8", VA = "0x78CAE8")]
		public Collectable()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class CollectableEggLevel : MonoBehaviour
	{
		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Properties - filled automatically")]
		[SerializeField]
		private string collectableID;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool isInCollection;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool collectedThisRound;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Header("Variations")]
		private GameObject eggGlow;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject eggNew;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject eggFound;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityEvent OnFirstCollect;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UnityEvent OnLaterCollect;

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x78CAF0", Offset = "0x78CAF0", VA = "0x78CAF0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x78CBB0", Offset = "0x78CBB0", VA = "0x78CBB0")]
		public void CheckEggStatus()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x78CCDC", Offset = "0x78CCDC", VA = "0x78CCDC")]
		public void TryCollect()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x78CCFC", Offset = "0x78CCFC", VA = "0x78CCFC")]
		public void FirstCollect()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x78CE7C", Offset = "0x78CE7C", VA = "0x78CE7C")]
		public void LaterCollect()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x78CEB8", Offset = "0x78CEB8", VA = "0x78CEB8")]
		public void ResetCollectable()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x78CC18", Offset = "0x78CC18", VA = "0x78CC18")]
		public void ShowCorrectEggAfter()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x78CF0C", Offset = "0x78CF0C", VA = "0x78CF0C")]
		public CollectableEggLevel()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class CollectableSymbolLevel : MonoBehaviour
	{
		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Properties - filled automatically")]
		[SerializeField]
		private string collectableID;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool isInCollection;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool collectedThisRound;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject spiritCard;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityEvent OnFirstCollect;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UnityEvent OnLaterCollect;

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x78CF14", Offset = "0x78CF14", VA = "0x78CF14")]
		private void Start()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x78D060", Offset = "0x78D060", VA = "0x78D060")]
		public void CheckCardStatus()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x78D0C8", Offset = "0x78D0C8", VA = "0x78D0C8")]
		public void TryCollect()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x78D100", Offset = "0x78D100", VA = "0x78D100")]
		public void FirstCollect()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x78D278", Offset = "0x78D278", VA = "0x78D278")]
		public void LaterCollect()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x78D2A0", Offset = "0x78D2A0", VA = "0x78D2A0")]
		public void ResetCollectable()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x78D2F4", Offset = "0x78D2F4", VA = "0x78D2F4")]
		public CollectableSymbolLevel()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class CottageCollectable : MonoBehaviour
	{
		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Properties")]
		public string collectableID;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool isInCollection;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool collectedThisRound;

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x78D2FC", Offset = "0x78D2FC", VA = "0x78D2FC")]
		private void Start()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x78D300", Offset = "0x78D300", VA = "0x78D300")]
		public void SetID(string id)
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x78D308", Offset = "0x78D308", VA = "0x78D308")]
		public void CheckCollectableStatus()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x78D370", Offset = "0x78D370", VA = "0x78D370")]
		public void ResetCollectable()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x78D3C4", Offset = "0x78D3C4", VA = "0x78D3C4")]
		public CottageCollectable()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class DesertWind : MonoBehaviour
	{
		[Token(Token = "0x20000DB")]
		public enum WindDirection
		{
			[Token(Token = "0x4000456")]
			North,
			[Token(Token = "0x4000457")]
			East,
			[Token(Token = "0x4000458")]
			South,
			[Token(Token = "0x4000459")]
			West
		}

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityEvent OnDirectionChanged;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private WindVane windVane;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float waitTimeBeforeChanging;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float waitTimeCounter;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private WindButtons buttons;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Debug")]
		public WindDirection currentWindDirection;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool canBeChanged;

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x78D3CC", Offset = "0x78D3CC", VA = "0x78D3CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x78D454", Offset = "0x78D454", VA = "0x78D454")]
		private void Update()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x78D504", Offset = "0x78D504", VA = "0x78D504")]
		public void BlowFrom(WindDirection windFrom)
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x78D550", Offset = "0x78D550", VA = "0x78D550")]
		public DesertWind()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class DirtyPipe : MonoBehaviour
	{
		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Header("Settings")]
		private float totalHP;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float hpReducePerTouch;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Actions when pipe is empty")]
		public UnityEvent pipeEmpty;

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x78D558", Offset = "0x78D558", VA = "0x78D558")]
		private void Start()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x78D55C", Offset = "0x78D55C", VA = "0x78D55C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x78D560", Offset = "0x78D560", VA = "0x78D560")]
		public void ReduceHP()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x78D588", Offset = "0x78D588", VA = "0x78D588")]
		public DirtyPipe()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class DisableKey : MonoBehaviour
	{
		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private VRGrabbable_Rotator vRGrabbableRotator;

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x78D590", Offset = "0x78D590", VA = "0x78D590")]
		private void Start()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x78D5F8", Offset = "0x78D5F8", VA = "0x78D5F8")]
		public void Disable()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x78D64C", Offset = "0x78D64C", VA = "0x78D64C")]
		public DisableKey()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class DoubleTrigger : MonoBehaviour
	{
		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Trigger object tags")]
		[SerializeField]
		private string tagTrigger1;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string tagTrigger2;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Events")]
		public UnityEvent TriggerEnter;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityEvent TriggerExit;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Header("Debug")]
		private bool isTriggeredBy1;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[SerializeField]
		private bool isTriggeredBy2;

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x78D654", Offset = "0x78D654", VA = "0x78D654")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x78D7B8", Offset = "0x78D7B8", VA = "0x78D7B8")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x78D880", Offset = "0x78D880", VA = "0x78D880")]
		public DoubleTrigger()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class DrillableBlock : MonoBehaviour
	{
		[Token(Token = "0x20000E0")]
		[CompilerGenerated]
		private sealed class <FallAfter>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float duration;

			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DrillableBlock <>4__this;

			[Token(Token = "0x1700009C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600045E")]
				[Address(RVA = "0x78DD9C", Offset = "0x78DD9C", VA = "0x78DD9C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000460")]
				[Address(RVA = "0x78DDE4", Offset = "0x78DDE4", VA = "0x78DDE4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600045B")]
			[Address(RVA = "0x78DB4C", Offset = "0x78DB4C", VA = "0x78DB4C")]
			[DebuggerHidden]
			public <FallAfter>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x600045C")]
			[Address(RVA = "0x78DC60", Offset = "0x78DC60", VA = "0x78DC60", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600045D")]
			[Address(RVA = "0x78DC64", Offset = "0x78DC64", VA = "0x78DC64", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0x78DDA4", Offset = "0x78DDA4", VA = "0x78DDA4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000E1")]
		[CompilerGenerated]
		private sealed class <DrillBreaksIce>d__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DrillableBlock <>4__this;

			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private GameObject <effect>5__2;

			[Token(Token = "0x1700009E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000464")]
				[Address(RVA = "0x78DFC0", Offset = "0x78DFC0", VA = "0x78DFC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000466")]
				[Address(RVA = "0x78E008", Offset = "0x78E008", VA = "0x78E008", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0x78DB74", Offset = "0x78DB74", VA = "0x78DB74")]
			[DebuggerHidden]
			public <DrillBreaksIce>d__22(int <>1__state)
			{
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0x78DDEC", Offset = "0x78DDEC", VA = "0x78DDEC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0x78DDF0", Offset = "0x78DDF0", VA = "0x78DDF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000465")]
			[Address(RVA = "0x78DFC8", Offset = "0x78DFC8", VA = "0x78DFC8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private sealed class <ResetBreakable>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400047A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float duration;

			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DrillableBlock <>4__this;

			[Token(Token = "0x170000A0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600046A")]
				[Address(RVA = "0x78E114", Offset = "0x78E114", VA = "0x78E114", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600046C")]
				[Address(RVA = "0x78E15C", Offset = "0x78E15C", VA = "0x78E15C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000467")]
			[Address(RVA = "0x78DC20", Offset = "0x78DC20", VA = "0x78DC20")]
			[DebuggerHidden]
			public <ResetBreakable>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x6000468")]
			[Address(RVA = "0x78E010", Offset = "0x78E010", VA = "0x78E010", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0x78E014", Offset = "0x78E014", VA = "0x78E014", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600046B")]
			[Address(RVA = "0x78E11C", Offset = "0x78E11C", VA = "0x78E11C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool willFall;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float drillingTime;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float breakableResetDelay;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody rb;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject block;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject seeker;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Animator animator;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UnityEvent AfterDrillingEvent;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject DrillingEffect;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float DrillingEffectLifeTime;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private bool HasSylvanOre;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject TriggerArea;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject WrongPlaceTrigger;

		[Token(Token = "0x1700009B")]
		public bool IsBeingDrilled
		{
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x78D888", Offset = "0x78D888", VA = "0x78D888")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x78D890", Offset = "0x78D890", VA = "0x78D890")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x78D89C", Offset = "0x78D89C", VA = "0x78D89C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x78D960", Offset = "0x78D960", VA = "0x78D960")]
		private void Start()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x78D9B0", Offset = "0x78D9B0", VA = "0x78D9B0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x78D9B4", Offset = "0x78D9B4", VA = "0x78D9B4")]
		public void Break()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x78DAC8", Offset = "0x78DAC8", VA = "0x78DAC8")]
		[IteratorStateMachine(typeof(<FallAfter>d__21))]
		private IEnumerator FallAfter(float duration)
		{
			return null;
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x78DA54", Offset = "0x78DA54", VA = "0x78DA54")]
		[IteratorStateMachine(typeof(<DrillBreaksIce>d__22))]
		private IEnumerator DrillBreaksIce()
		{
			return null;
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x78DB9C", Offset = "0x78DB9C", VA = "0x78DB9C")]
		[IteratorStateMachine(typeof(<ResetBreakable>d__23))]
		private IEnumerator ResetBreakable(float duration)
		{
			return null;
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x78DC48", Offset = "0x78DC48", VA = "0x78DC48")]
		public DrillableBlock()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public class DuneHiddenTrigger : MonoBehaviour
	{
		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityEvent TriggerEnter;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEvent TriggerExit;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEvent TriggerStay;

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x78E164", Offset = "0x78E164", VA = "0x78E164")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x78E1E4", Offset = "0x78E1E4", VA = "0x78E1E4")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x78E264", Offset = "0x78E264", VA = "0x78E264")]
		private void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x78E2E4", Offset = "0x78E2E4", VA = "0x78E2E4")]
		public DuneHiddenTrigger()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class FallingBlock : MonoBehaviour
	{
		[Token(Token = "0x20000E5")]
		[CompilerGenerated]
		private sealed class <FallAfter>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000487")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000488")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000489")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float duration;

			[Token(Token = "0x400048A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FallingBlock <>4__this;

			[Token(Token = "0x170000A2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600047C")]
				[Address(RVA = "0x78E938", Offset = "0x78E938", VA = "0x78E938", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600047E")]
				[Address(RVA = "0x78E980", Offset = "0x78E980", VA = "0x78E980", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000479")]
			[Address(RVA = "0x78E688", Offset = "0x78E688", VA = "0x78E688")]
			[DebuggerHidden]
			public <FallAfter>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600047A")]
			[Address(RVA = "0x78E82C", Offset = "0x78E82C", VA = "0x78E82C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600047B")]
			[Address(RVA = "0x78E830", Offset = "0x78E830", VA = "0x78E830", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0x78E940", Offset = "0x78E940", VA = "0x78E940", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000E6")]
		[CompilerGenerated]
		private sealed class <ResetPlatformAfter>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400048B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400048C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400048D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x400048E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FallingBlock <>4__this;

			[Token(Token = "0x170000A4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000482")]
				[Address(RVA = "0x78EC9C", Offset = "0x78EC9C", VA = "0x78EC9C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000484")]
				[Address(RVA = "0x78ECE4", Offset = "0x78ECE4", VA = "0x78ECE4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600047F")]
			[Address(RVA = "0x78E734", Offset = "0x78E734", VA = "0x78E734")]
			[DebuggerHidden]
			public <ResetPlatformAfter>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000480")]
			[Address(RVA = "0x78E988", Offset = "0x78E988", VA = "0x78E988", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000481")]
			[Address(RVA = "0x78E98C", Offset = "0x78E98C", VA = "0x78E98C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000483")]
			[Address(RVA = "0x78ECA4", Offset = "0x78ECA4", VA = "0x78ECA4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Should the block fall when player steps on it?")]
		[SerializeField]
		private bool willFall;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Shaking time before the block falls down")]
		[SerializeField]
		private float shakingTime;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Rigidbody rb;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject block;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject seeker;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Animator animator;

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x78E2EC", Offset = "0x78E2EC", VA = "0x78E2EC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x78E3B0", Offset = "0x78E3B0", VA = "0x78E3B0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x78E3E0", Offset = "0x78E3E0", VA = "0x78E3E0")]
		public void FreezeSeeker()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x78E57C", Offset = "0x78E57C", VA = "0x78E57C")]
		public void ShakeAndFall()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x78E604", Offset = "0x78E604", VA = "0x78E604")]
		[IteratorStateMachine(typeof(<FallAfter>d__10))]
		private IEnumerator FallAfter(float duration)
		{
			return null;
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x78E6B0", Offset = "0x78E6B0", VA = "0x78E6B0")]
		[IteratorStateMachine(typeof(<ResetPlatformAfter>d__11))]
		private IEnumerator ResetPlatformAfter(float time)
		{
			return null;
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x78E75C", Offset = "0x78E75C", VA = "0x78E75C")]
		private void ResetPlatform()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x78E824", Offset = "0x78E824", VA = "0x78E824")]
		public FallingBlock()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class FallingBlocks : MonoBehaviour
	{
		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 respawnLocation;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject seeker;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float respawnIfLower;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool respawned;

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x78ECEC", Offset = "0x78ECEC", VA = "0x78ECEC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x78EE14", Offset = "0x78EE14", VA = "0x78EE14")]
		private void Update()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x78F008", Offset = "0x78F008", VA = "0x78F008")]
		public void ResetSeeker()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x78F208", Offset = "0x78F208", VA = "0x78F208")]
		public void FindSeeker()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x78F260", Offset = "0x78F260", VA = "0x78F260")]
		public void RespawnComplete(bool complete)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x78F26C", Offset = "0x78F26C", VA = "0x78F26C")]
		public FallingBlocks()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class Fire : MonoBehaviour
	{
		[Token(Token = "0x20000E9")]
		[CompilerGenerated]
		private sealed class <ResetPosition>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Fire <>4__this;

			[Token(Token = "0x170000A6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000495")]
				[Address(RVA = "0x78FAD0", Offset = "0x78FAD0", VA = "0x78FAD0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000497")]
				[Address(RVA = "0x78FB18", Offset = "0x78FB18", VA = "0x78FB18", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0x78F974", Offset = "0x78F974", VA = "0x78F974")]
			[DebuggerHidden]
			public <ResetPosition>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x6000493")]
			[Address(RVA = "0x78F9B4", Offset = "0x78F9B4", VA = "0x78F9B4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0x78F9B8", Offset = "0x78F9B8", VA = "0x78F9B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000496")]
			[Address(RVA = "0x78FAD8", Offset = "0x78FAD8", VA = "0x78FAD8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Tinder or not? Tinderts will catch fire from flints, non-tinders from tinders.")]
		[Header("Settings")]
		public bool isTinder;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canBurnMultipleTimes;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float burningTime;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float startSpreadingFireAfter;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float timeBurned;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Burn automatically at start?")]
		[SerializeField]
		private bool burnAtStart;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float resetTime;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject flameObject;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject fireStarter;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Events")]
		public UnityEvent OnStartBurning;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UnityEvent OnStopBurning;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Debug")]
		public bool isBurning;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 originalPos;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Animator animator;

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x78F274", Offset = "0x78F274", VA = "0x78F274")]
		private void Start()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x78F408", Offset = "0x78F408", VA = "0x78F408")]
		private void Update()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x78F3B0", Offset = "0x78F3B0", VA = "0x78F3B0")]
		public void StartBurning()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x78F850", Offset = "0x78F850", VA = "0x78F850")]
		public void StopBurning()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x78F8F0", Offset = "0x78F8F0", VA = "0x78F8F0")]
		public void ReTriggerBurning()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x78F900", Offset = "0x78F900", VA = "0x78F900")]
		[IteratorStateMachine(typeof(<ResetPosition>d__19))]
		public IEnumerator ResetPosition()
		{
			return null;
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x78F99C", Offset = "0x78F99C", VA = "0x78F99C")]
		public Fire()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class FireStarter : MonoBehaviour
	{
		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("All lists automated - do not setup manually")]
		public Fire[] fireObjects;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<Fire> tinders;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<Fire> burningObjects;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		[Tooltip("Distance to light up tinders")]
		[SerializeField]
		private float effectRadius;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Distance to spread fire")]
		[SerializeField]
		private float spreadRadius;

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x78FB20", Offset = "0x78FB20", VA = "0x78FB20")]
		private void Start()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x78FB24", Offset = "0x78FB24", VA = "0x78FB24")]
		public void UpdateFireObjects()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x78B49C", Offset = "0x78B49C", VA = "0x78B49C")]
		public void AddFireObject(Fire objectToAdd)
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x78C798", Offset = "0x78C798", VA = "0x78C798")]
		public void RemoveFireObject(Fire objectToRemove)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x78FC74", Offset = "0x78FC74", VA = "0x78FC74")]
		public void TryStartFire()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x78F4D4", Offset = "0x78F4D4", VA = "0x78F4D4")]
		public void TrySpreadFire(Vector3 burningPos)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x78FEB8", Offset = "0x78FEB8", VA = "0x78FEB8")]
		public FireStarter()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class FloatingObject : MonoBehaviour
	{
		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform rightHand;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftHand;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform lookAtObject;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform tr;

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x78FF78", Offset = "0x78FF78", VA = "0x78FF78")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x78FF9C", Offset = "0x78FF9C", VA = "0x78FF9C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x790070", Offset = "0x790070", VA = "0x790070")]
		public FloatingObject()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class FloatingSwitchPlatform : MonoBehaviour
	{
		[Token(Token = "0x20000ED")]
		[CompilerGenerated]
		private sealed class <TurnOff>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FloatingSwitchPlatform <>4__this;

			[Token(Token = "0x170000A8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004AB")]
				[Address(RVA = "0x790CB0", Offset = "0x790CB0", VA = "0x790CB0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004AD")]
				[Address(RVA = "0x790CF8", Offset = "0x790CF8", VA = "0x790CF8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x79084C", Offset = "0x79084C", VA = "0x79084C")]
			[DebuggerHidden]
			public <TurnOff>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x79087C", Offset = "0x79087C", VA = "0x79087C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x790880", Offset = "0x790880", VA = "0x790880", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x790CB8", Offset = "0x790CB8", VA = "0x790CB8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Settings")]
		[SerializeField]
		private float transitionTime;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject transitionEffectOn;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject transitionEffectOff;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Objects to turn on/off")]
		[SerializeField]
		private List<GameObject> objectsActiveWhenOn;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<GameObject> objectsActiveWhenOff;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("State")]
		[SerializeField]
		private bool isOn;

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x790078", Offset = "0x790078", VA = "0x790078")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x7903FC", Offset = "0x7903FC", VA = "0x7903FC")]
		private void Update()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x790400", Offset = "0x790400", VA = "0x790400")]
		public void SwitchState(bool turnOn)
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x79044C", Offset = "0x79044C", VA = "0x79044C")]
		private void TurnOn()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x7907D8", Offset = "0x7907D8", VA = "0x7907D8")]
		[IteratorStateMachine(typeof(<TurnOff>d__10))]
		private IEnumerator TurnOff()
		{
			return null;
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x790874", Offset = "0x790874", VA = "0x790874")]
		public FloatingSwitchPlatform()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class HamsterWheel : MonoBehaviour
	{
		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Properties")]
		[SerializeField]
		private Axis rotationAxis;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float spinningSpeed;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float smoothTime;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject spinningWheel;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Events")]
		public UnityEvent OnSpin;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UnityEvent OnReverseSpin;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityEvent OnSpinEnd;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Header("Debug")]
		private bool frontIsActive;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[SerializeField]
		private bool backIsActive;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		[SerializeField]
		private bool soundIsPlaying;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("Can be used to control linear animations etc.")]
		public float wheelRotation;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 targetAngle;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 currentAngle;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject player;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private AudioSource audioSource;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float inputHorizontal;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float inputVertical;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float inputToSpin;

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x790D00", Offset = "0x790D00", VA = "0x790D00")]
		private void Start()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x790E64", Offset = "0x790E64", VA = "0x790E64")]
		private void Update()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x7913A0", Offset = "0x7913A0", VA = "0x7913A0")]
		public void ActivateWheel(bool isFront)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x791514", Offset = "0x791514", VA = "0x791514")]
		public void DeactivateWheel()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x790E80", Offset = "0x790E80", VA = "0x790E80")]
		public void SpinForward()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x791114", Offset = "0x791114", VA = "0x791114")]
		public void SpinBackwards()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x7915DC", Offset = "0x7915DC", VA = "0x7915DC")]
		public void GetInput()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x79167C", Offset = "0x79167C", VA = "0x79167C")]
		public HamsterWheel()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class Key : MonoBehaviour
	{
		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Header("Enter a matching ID for key and lock")]
		public int keyID;

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x791698", Offset = "0x791698", VA = "0x791698")]
		public Key()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class KeyTrigger : MonoBehaviour
	{
		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int keyID;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform keyHolder;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEvent OnValidKeyAssigned;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool lockUsed;

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x7916A8", Offset = "0x7916A8", VA = "0x7916A8")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x7917E0", Offset = "0x7917E0", VA = "0x7917E0")]
		private void TryOpen(Key key)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x791A14", Offset = "0x791A14", VA = "0x791A14")]
		public KeyTrigger()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class LinearController : MonoBehaviour
	{
		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float linearValue;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LinearReceiver receiver;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LinearReceiver receiver_2;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_LastUpdateValue;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool movedAfterLastUpdate;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		[Header("Event to launch on max value")]
		[SerializeField]
		private bool useOnMaxEvent;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UnityEvent onMaxEvent;

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x791A24", Offset = "0x791A24", VA = "0x791A24")]
		public void AdjustValue(float amount)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x791A48", Offset = "0x791A48", VA = "0x791A48")]
		public void SetValue(float val)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x791A64", Offset = "0x791A64", VA = "0x791A64")]
		private void Update()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x791BAC", Offset = "0x791BAC", VA = "0x791BAC")]
		public LinearController()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public interface ILinearReceiver
	{
		[Token(Token = "0x60004BE")]
		void UpdateLinearValue(float linear);
	}
	[Token(Token = "0x20000F3")]
	[RequireComponent(typeof(LinearController))]
	public class LinearListener : MonoBehaviour
	{
		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRGrabbable_Linear linear;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private LinearController m_LinearController;

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x791BB4", Offset = "0x791BB4", VA = "0x791BB4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x791C0C", Offset = "0x791C0C", VA = "0x791C0C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x791C98", Offset = "0x791C98", VA = "0x791C98")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x791D24", Offset = "0x791D24", VA = "0x791D24")]
		private void HandleMove(float amount)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x791D54", Offset = "0x791D54", VA = "0x791D54")]
		public LinearListener()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	[RequireComponent(typeof(LinearController))]
	public class LinearListenerRotator : MonoBehaviour
	{
		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRGrabbable_Rotator rotator;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float rotateMultiplier;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private LinearController m_LinearController;

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x791D5C", Offset = "0x791D5C", VA = "0x791D5C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x791DB4", Offset = "0x791DB4", VA = "0x791DB4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x791E40", Offset = "0x791E40", VA = "0x791E40")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x791ECC", Offset = "0x791ECC", VA = "0x791ECC")]
		private void HandleRotate(float amount)
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x791F0C", Offset = "0x791F0C", VA = "0x791F0C")]
		public LinearListenerRotator()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public abstract class LinearReceiver : MonoBehaviour, ILinearReceiver
	{
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x791B84", Offset = "0x791B84", VA = "0x791B84", Slot = "4")]
		public void UpdateLinearValue(float linear)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x791F20", Offset = "0x791F20", VA = "0x791F20", Slot = "5")]
		protected virtual void DoUpdateLinearValue(float linear)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x791F24", Offset = "0x791F24", VA = "0x791F24")]
		protected LinearReceiver()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class LinearReceiverAdditive : MonoBehaviour
	{
		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator anim;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float m_Target;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float m_Current;

		[Token(Token = "0x14000003")]
		public event Action animationPlayedEvent
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x791F2C", Offset = "0x791F2C", VA = "0x791F2C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x791FC8", Offset = "0x791FC8", VA = "0x791FC8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x792064", Offset = "0x792064", VA = "0x792064")]
		public void AddToLinearValue(float linear)
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x792074", Offset = "0x792074", VA = "0x792074")]
		private void Update()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x792114", Offset = "0x792114", VA = "0x792114")]
		public LinearReceiverAdditive()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class LinearReceiverAnimation : LinearReceiver
	{
		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator anim;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_Target;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_Current;

		[Token(Token = "0x14000004")]
		public event Action animationPlayedEvent
		{
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x79211C", Offset = "0x79211C", VA = "0x79211C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x7921B8", Offset = "0x7921B8", VA = "0x7921B8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x792254", Offset = "0x792254", VA = "0x792254", Slot = "5")]
		protected override void DoUpdateLinearValue(float linear)
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x79225C", Offset = "0x79225C", VA = "0x79225C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x7922FC", Offset = "0x7922FC", VA = "0x7922FC")]
		public LinearReceiverAnimation()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class LinearReceiverAnimator : LinearReceiver
	{
		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string minValueAnim;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string lerpValueAnim;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string maxValueAnim;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator m_Anim;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_TargetLinearValue;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_CurrentLinearValue;

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x792304", Offset = "0x792304", VA = "0x792304")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x792364", Offset = "0x792364", VA = "0x792364", Slot = "5")]
		protected override void DoUpdateLinearValue(float linear)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x79236C", Offset = "0x79236C", VA = "0x79236C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x792434", Offset = "0x792434", VA = "0x792434")]
		public LinearReceiverAnimator()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class LockTrigger : MonoBehaviour
	{
		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Enter a matching ID for key and lock")]
		[SerializeField]
		public int keyID;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Event to launch when right key is used")]
		[SerializeField]
		private UnityEvent OnValidKeyAssigned;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int usedKey;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("KeyInLockVR prefab")]
		[SerializeField]
		private GameObject keyInLock;

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x79243C", Offset = "0x79243C", VA = "0x79243C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x7924E8", Offset = "0x7924E8", VA = "0x7924E8")]
		private void OpenLock(Key key)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x792614", Offset = "0x792614", VA = "0x792614")]
		public void KeyUsedOnLock()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x79269C", Offset = "0x79269C", VA = "0x79269C")]
		public LockTrigger()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class MoveableObject : MonoBehaviour
	{
		[Token(Token = "0x20000FB")]
		[CompilerGenerated]
		private sealed class <Respawn>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MoveableObject <>4__this;

			[Token(Token = "0x170000AA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004EA")]
				[Address(RVA = "0x792C90", Offset = "0x792C90", VA = "0x792C90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004EC")]
				[Address(RVA = "0x792CD8", Offset = "0x792CD8", VA = "0x792CD8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x792B5C", Offset = "0x792B5C", VA = "0x792B5C")]
			[DebuggerHidden]
			public <Respawn>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x792B98", Offset = "0x792B98", VA = "0x792B98", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x792B9C", Offset = "0x792B9C", VA = "0x792B9C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x792C98", Offset = "0x792C98", VA = "0x792C98", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Who can move this")]
		[SerializeField]
		private bool moveableBySeeker;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool moveableByOther;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[SerializeField]
		[Header("Properties")]
		private bool isHeavy;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		[SerializeField]
		private bool isDestructible;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool respawnIfDestroyed;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		[SerializeField]
		private bool yRotationAllowed;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		[SerializeField]
		private bool allowGravity;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
		[SerializeField]
		private bool useAllPhysics;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float waitTimeBeforeDestroy;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float waitTimeBeforeRespawn;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 startLocation;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Events")]
		public UnityEvent OnStartMoving;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityEvent OnStopMoving;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UnityEvent OnDestroy;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityEvent OnRespawn;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody moveableRb;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RigidbodyConstraints defaultConstaints;

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x7926AC", Offset = "0x7926AC", VA = "0x7926AC")]
		private void Start()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x792830", Offset = "0x792830", VA = "0x792830")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x792934", Offset = "0x792934", VA = "0x792934")]
		private void OnCollisionExit(Collision other)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x7929FC", Offset = "0x7929FC", VA = "0x7929FC")]
		public void EnableMoving()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x7927E0", Offset = "0x7927E0", VA = "0x7927E0")]
		public void DisableMoving()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x792A20", Offset = "0x792A20", VA = "0x792A20")]
		public void DestroyThis()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x792AE8", Offset = "0x792AE8", VA = "0x792AE8")]
		[IteratorStateMachine(typeof(<Respawn>d__23))]
		public IEnumerator Respawn()
		{
			return null;
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x792B84", Offset = "0x792B84", VA = "0x792B84")]
		private void Update()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x792B88", Offset = "0x792B88", VA = "0x792B88")]
		public MoveableObject()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class MoveableObjectAudioPlayer : MonoBehaviour
	{
		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Rigidbody rb;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AudioSource audioSource;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Sounds")]
		[SerializeField]
		private AudioClip pushingSound;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip stopMovingSound;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AudioClip fallingSound;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool stopSoundPlayed;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Header("Sounds")]
		[SerializeField]
		private float velocityThreshold;

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x792CE0", Offset = "0x792CE0", VA = "0x792CE0")]
		private void Start()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x792D70", Offset = "0x792D70", VA = "0x792D70")]
		private void Update()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x792D88", Offset = "0x792D88", VA = "0x792D88")]
		private void PlayPushingSound()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x792E78", Offset = "0x792E78", VA = "0x792E78")]
		private void PlayStopSound()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x792F70", Offset = "0x792F70", VA = "0x792F70")]
		public MoveableObjectAudioPlayer()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class MultiTriggerTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int triggerCount;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEvent OnTriggersTriggered;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int m_CurrentTriggerCount;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool m_Triggered;

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x792F78", Offset = "0x792F78", VA = "0x792F78")]
		public void AdvanceTrigger()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x792FB8", Offset = "0x792FB8", VA = "0x792FB8")]
		public MultiTriggerTrigger()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class ObjectDestroyer : MonoBehaviour
	{
		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float destroyAfter;

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x792FC0", Offset = "0x792FC0", VA = "0x792FC0")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x792FC4", Offset = "0x792FC4", VA = "0x792FC4")]
		public void DestroyThis()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x793040", Offset = "0x793040", VA = "0x793040")]
		public ObjectDestroyer()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class ObjectRotator : MonoBehaviour
	{
		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform tr;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool rotate;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotateMultiplier;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject wheel;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HamsterWheel hamsterWheel;

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x793048", Offset = "0x793048", VA = "0x793048")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x7930C8", Offset = "0x7930C8", VA = "0x7930C8")]
		private void Update()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x79312C", Offset = "0x79312C", VA = "0x79312C")]
		public void RotateObject(bool rotateNow)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x793138", Offset = "0x793138", VA = "0x793138")]
		public ObjectRotator()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class ObjectTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Header("Triggering tag")]
		private string triggerTag;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Events")]
		public UnityEvent TriggerEnter;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEvent TriggerExit;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityEvent TriggerStay;

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x793140", Offset = "0x793140", VA = "0x793140")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x793184", Offset = "0x793184", VA = "0x793184")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x7931C8", Offset = "0x7931C8", VA = "0x7931C8")]
		private void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x79320C", Offset = "0x79320C", VA = "0x79320C")]
		public ObjectTrigger()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class PatternPuzzle : MonoBehaviour
	{
		[Token(Token = "0x2000102")]
		[CompilerGenerated]
		private sealed class <ShowPatternHints>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PatternPuzzle <>4__this;

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x170000AC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600050C")]
				[Address(RVA = "0x793B90", Offset = "0x793B90", VA = "0x793B90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600050E")]
				[Address(RVA = "0x793BD8", Offset = "0x793BD8", VA = "0x793BD8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000509")]
			[Address(RVA = "0x7933FC", Offset = "0x7933FC", VA = "0x7933FC")]
			[DebuggerHidden]
			public <ShowPatternHints>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x600050A")]
			[Address(RVA = "0x7939E8", Offset = "0x7939E8", VA = "0x7939E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600050B")]
			[Address(RVA = "0x7939EC", Offset = "0x7939EC", VA = "0x7939EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600050D")]
			[Address(RVA = "0x793B98", Offset = "0x793B98", VA = "0x793B98", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000103")]
		[CompilerGenerated]
		private sealed class <PuzzleCompleteAfter>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000526")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PatternPuzzle <>4__this;

			[Token(Token = "0x170000AE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000512")]
				[Address(RVA = "0x793D6C", Offset = "0x793D6C", VA = "0x793D6C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000514")]
				[Address(RVA = "0x793DB4", Offset = "0x793DB4", VA = "0x793DB4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600050F")]
			[Address(RVA = "0x7939B8", Offset = "0x7939B8", VA = "0x7939B8")]
			[DebuggerHidden]
			public <PuzzleCompleteAfter>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000510")]
			[Address(RVA = "0x793BE0", Offset = "0x793BE0", VA = "0x793BE0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000511")]
			[Address(RVA = "0x793BE4", Offset = "0x793BE4", VA = "0x793BE4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000513")]
			[Address(RVA = "0x793D74", Offset = "0x793D74", VA = "0x793D74", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Delay between indication anims on individual buttons")]
		public float patternIndicateDelay;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float puzzleCompleteDelay;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Delay before showing pattern hints after a failure")]
		public float afterFailureDelay;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Setup buttons in the correct order")]
		public GameObject[] buttonsInOrder;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Drag all button roots here")]
		public GameObject[] allButtonRoots;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public VRInteractable[] allInteractables;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Setup chain effects in the correct order")]
		public GameObject[] chainEffectsInOrder;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Debug")]
		public GameObject nextButton;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int nextButtonIndex;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UnityEvent OnCorrectPatternEntered;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public UnityEvent OnWrongButtonPressed;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject failButtonEffect;

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x793214", Offset = "0x793214", VA = "0x793214")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x793388", Offset = "0x793388", VA = "0x793388")]
		[IteratorStateMachine(typeof(<ShowPatternHints>d__13))]
		private IEnumerator ShowPatternHints()
		{
			return null;
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x793424", Offset = "0x793424", VA = "0x793424")]
		public void ButtonPressed(GameObject button)
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x7938D0", Offset = "0x7938D0", VA = "0x7938D0")]
		public void ShowOrderIndications()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x7936B8", Offset = "0x7936B8", VA = "0x7936B8")]
		public void PuzzleComplete()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x793944", Offset = "0x793944", VA = "0x793944")]
		[IteratorStateMachine(typeof(<PuzzleCompleteAfter>d__17))]
		private IEnumerator PuzzleCompleteAfter()
		{
			return null;
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x793748", Offset = "0x793748", VA = "0x793748")]
		public void ResetPuzzle()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x7938F0", Offset = "0x7938F0", VA = "0x7938F0")]
		private void SetInteractableStateForAllButtons(bool isInteractable)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x793268", Offset = "0x793268", VA = "0x793268")]
		private void InitializeInteractables()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x7939E0", Offset = "0x7939E0", VA = "0x7939E0")]
		public PatternPuzzle()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class PinCodePuzzle : MonoBehaviour
	{
		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Set PIN code")]
		[SerializeField]
		private List<int> pinCode;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<int> enteredCode;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isSolved;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityEvent OnCorrectCodeEntered;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UnityEvent OnWrongCodeEntered;

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x793DBC", Offset = "0x793DBC", VA = "0x793DBC")]
		public void SubmitCode()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x793F6C", Offset = "0x793F6C", VA = "0x793F6C")]
		public void ResetCode()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x793FBC", Offset = "0x793FBC", VA = "0x793FBC")]
		public void ButtonPressed(int buttonValue)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x794064", Offset = "0x794064", VA = "0x794064")]
		public PinCodePuzzle()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class FrozenGround : MonoBehaviour
	{
		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Walls")]
		[SerializeField]
		private GameObject wallNorth;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject wallEast;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject wallSouth;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject wallWest;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Debug")]
		public bool touchingWall;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool waitingForInput;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject facingWall;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GameObject seeker;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float inputVertical;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float inputHorizontal;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string inputToUse;

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x7940EC", Offset = "0x7940EC", VA = "0x7940EC")]
		private void Start()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x7941C8", Offset = "0x7941C8", VA = "0x7941C8")]
		private void Update()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x794460", Offset = "0x794460", VA = "0x794460")]
		public void FreezeSeeker()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x794500", Offset = "0x794500", VA = "0x794500")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x79459C", Offset = "0x79459C", VA = "0x79459C")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x794638", Offset = "0x794638", VA = "0x794638")]
		public void GetDirection()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x794258", Offset = "0x794258", VA = "0x794258")]
		public void GetInput()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x794368", Offset = "0x794368", VA = "0x794368")]
		public void SlideSeeker()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x794744", Offset = "0x794744", VA = "0x794744")]
		public void FindSeeker()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x79479C", Offset = "0x79479C", VA = "0x79479C")]
		public FrozenGround()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class FrozenObstacle : MonoBehaviour
	{
		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FrozenGround ground;

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x7947A4", Offset = "0x7947A4", VA = "0x7947A4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x79481C", Offset = "0x79481C", VA = "0x79481C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x794820", Offset = "0x794820", VA = "0x794820")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x79491C", Offset = "0x79491C", VA = "0x79491C")]
		public FrozenObstacle()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class FrozenPlatform : MonoBehaviour
	{
		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GameObject seeker;

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x794924", Offset = "0x794924", VA = "0x794924")]
		private void Start()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x7949F4", Offset = "0x7949F4", VA = "0x7949F4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x7949F8", Offset = "0x7949F8", VA = "0x7949F8")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x794B3C", Offset = "0x794B3C", VA = "0x794B3C")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x794C98", Offset = "0x794C98", VA = "0x794C98")]
		public void FindSeeker()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x794CF0", Offset = "0x794CF0", VA = "0x794CF0")]
		public FrozenPlatform()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class PlatformArea : MonoBehaviour
	{
		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Rigidbody> rigidbodiesInTriggerArea;

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x794CF8", Offset = "0x794CF8", VA = "0x794CF8")]
		private void OnTriggerEnter(Collider col)
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x794E88", Offset = "0x794E88", VA = "0x794E88")]
		private void OnTriggerExit(Collider col)
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x794FC4", Offset = "0x794FC4", VA = "0x794FC4")]
		public PlatformArea()
		{
		}
	}
	[Token(Token = "0x2000109")]
	[RequireComponent(typeof(Rigidbody))]
	public class PlatformMover : LinearReceiver
	{
		[Token(Token = "0x200010A")]
		[CompilerGenerated]
		private sealed class <LateFixedRoutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformMover <>4__this;

			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private WaitForFixedUpdate <waitForFixed>5__2;

			[Token(Token = "0x170000B0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000539")]
				[Address(RVA = "0x795690", Offset = "0x795690", VA = "0x795690", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600053B")]
				[Address(RVA = "0x7956D8", Offset = "0x7956D8", VA = "0x7956D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000536")]
			[Address(RVA = "0x7951AC", Offset = "0x7951AC", VA = "0x7951AC")]
			[DebuggerHidden]
			public <LateFixedRoutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000537")]
			[Address(RVA = "0x7955D0", Offset = "0x7955D0", VA = "0x7955D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000538")]
			[Address(RVA = "0x7955D4", Offset = "0x7955D4", VA = "0x7955D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600053A")]
			[Address(RVA = "0x795698", Offset = "0x795698", VA = "0x795698", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float movementSpeed;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform platformStartPos;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platformEndPos;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody m_MyRigid;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PlatformArea m_PlatformArea;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_CurrentLinearTarget;

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x79504C", Offset = "0x79504C", VA = "0x79504C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x795138", Offset = "0x795138", VA = "0x795138")]
		[IteratorStateMachine(typeof(<LateFixedRoutine>d__6))]
		private IEnumerator LateFixedRoutine()
		{
			return null;
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x7951D4", Offset = "0x7951D4", VA = "0x7951D4")]
		private Vector3 GetTargetPos()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x795260", Offset = "0x795260", VA = "0x795260")]
		private void MovePlatform()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x7955B8", Offset = "0x7955B8", VA = "0x7955B8", Slot = "5")]
		protected override void DoUpdateLinearValue(float linear)
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x7955C0", Offset = "0x7955C0", VA = "0x7955C0")]
		public PlatformMover()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class PlatformParenter : MonoBehaviour
	{
		[Token(Token = "0x600053C")]
		[Address(RVA = "0x7956E0", Offset = "0x7956E0", VA = "0x7956E0")]
		private void OnTriggerEnter(Collider col)
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x7957F4", Offset = "0x7957F4", VA = "0x7957F4")]
		private void OnTriggerExit(Collider col)
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x7958E4", Offset = "0x7958E4", VA = "0x7958E4")]
		public PlatformParenter()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class PlayerTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityEvent TriggerEnter;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEvent TriggerExit;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEvent TriggerStay;

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x7958EC", Offset = "0x7958EC", VA = "0x7958EC")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x79596C", Offset = "0x79596C", VA = "0x79596C")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x7959EC", Offset = "0x7959EC", VA = "0x7959EC")]
		private void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x795A6C", Offset = "0x795A6C", VA = "0x795A6C")]
		public PlayerTrigger()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class PositionalMoveAudio : MonoBehaviour
	{
		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float deltaMove;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float stopDelay;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_LastPlayTime;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 m_LastPos;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x795A74", Offset = "0x795A74", VA = "0x795A74")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x795AF4", Offset = "0x795AF4", VA = "0x795AF4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x795C80", Offset = "0x795C80", VA = "0x795C80")]
		public PositionalMoveAudio()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class PressurePlate : MonoBehaviour
	{
		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string boolToSet;

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x795C94", Offset = "0x795C94", VA = "0x795C94")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x795CEC", Offset = "0x795CEC", VA = "0x795CEC")]
		public void SetAnimationBool(bool value)
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x795D18", Offset = "0x795D18", VA = "0x795D18")]
		public PressurePlate()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class RandomTrigger : MonoBehaviour
	{
		[Token(Token = "0x2000110")]
		[CompilerGenerated]
		private sealed class <Start>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RandomTrigger <>4__this;

			[Token(Token = "0x170000B2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600054E")]
				[Address(RVA = "0x795F0C", Offset = "0x795F0C", VA = "0x795F0C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000550")]
				[Address(RVA = "0x795F54", Offset = "0x795F54", VA = "0x795F54", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600054B")]
			[Address(RVA = "0x795DE4", Offset = "0x795DE4", VA = "0x795DE4")]
			[DebuggerHidden]
			public <Start>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x600054C")]
			[Address(RVA = "0x795E20", Offset = "0x795E20", VA = "0x795E20", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600054D")]
			[Address(RVA = "0x795E24", Offset = "0x795E24", VA = "0x795E24", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600054F")]
			[Address(RVA = "0x795F14", Offset = "0x795F14", VA = "0x795F14", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityEvent OnRandomEvent;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minRandomTime;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float maxRandomTime;

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x795D70", Offset = "0x795D70", VA = "0x795D70")]
		[IteratorStateMachine(typeof(<Start>d__3))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x795E0C", Offset = "0x795E0C", VA = "0x795E0C")]
		public RandomTrigger()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class ResettableObject : MonoBehaviour
	{
		[Token(Token = "0x2000112")]
		[CompilerGenerated]
		private sealed class <SpawnResetEffect>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ResettableObject <>4__this;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private GameObject <effect>5__2;

			[Token(Token = "0x170000B4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000558")]
				[Address(RVA = "0x79624C", Offset = "0x79624C", VA = "0x79624C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600055A")]
				[Address(RVA = "0x796294", Offset = "0x796294", VA = "0x796294", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000555")]
			[Address(RVA = "0x796040", Offset = "0x796040", VA = "0x796040")]
			[DebuggerHidden]
			public <SpawnResetEffect>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000556")]
			[Address(RVA = "0x796078", Offset = "0x796078", VA = "0x796078", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000557")]
			[Address(RVA = "0x79607C", Offset = "0x79607C", VA = "0x79607C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000559")]
			[Address(RVA = "0x796254", Offset = "0x796254", VA = "0x796254", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityEvent OnReset;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool resetPosition;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool resetRotation;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool resetScale;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool isKinematic;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool resetVelocity;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float effectLifeTime;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject ResetEffect;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_OriginalPos;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion m_OriginalRot;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 m_OriginalScale;

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x795F5C", Offset = "0x795F5C", VA = "0x795F5C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x78EA70", Offset = "0x78EA70", VA = "0x78EA70")]
		public void ResetObject()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x795FCC", Offset = "0x795FCC", VA = "0x795FCC")]
		[IteratorStateMachine(typeof(<SpawnResetEffect>d__13))]
		private IEnumerator SpawnResetEffect()
		{
			return null;
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x796068", Offset = "0x796068", VA = "0x796068")]
		public ResettableObject()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public class ResetTrigger : MonoBehaviour
	{
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x79629C", Offset = "0x79629C", VA = "0x79629C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x796394", Offset = "0x796394", VA = "0x796394")]
		public ResetTrigger()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class RisingPlatform : MonoBehaviour
	{
		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private LinearController contoller;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float droppingSpeed;

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x79639C", Offset = "0x79639C", VA = "0x79639C")]
		private void Start()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x7963F4", Offset = "0x7963F4", VA = "0x7963F4")]
		private void Update()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x796438", Offset = "0x796438", VA = "0x796438")]
		public RisingPlatform()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class RotatingWheelAudio : MonoBehaviour
	{
		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRGrabbable_Rotator rotator;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float stopDelay;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_RotateTime;

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x79644C", Offset = "0x79644C", VA = "0x79644C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x7964A4", Offset = "0x7964A4", VA = "0x7964A4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x796530", Offset = "0x796530", VA = "0x796530")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x7965BC", Offset = "0x7965BC", VA = "0x7965BC")]
		private void HandleRotate(float angle)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x796630", Offset = "0x796630", VA = "0x796630")]
		private void Update()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x7966D4", Offset = "0x7966D4", VA = "0x7966D4")]
		public RotatingWheelAudio()
		{
		}
	}
	[Token(Token = "0x2000116")]
	public class RotatingWheelExtra : MonoBehaviour
	{
		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRGrabbable_Rotator rotator;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Axis axisOfRotation;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeedMultiplier;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool inverse;

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x7966E4", Offset = "0x7966E4", VA = "0x7966E4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x796770", Offset = "0x796770", VA = "0x796770")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x7967FC", Offset = "0x7967FC", VA = "0x7967FC")]
		private void HandleRotationChange(float angle)
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x796954", Offset = "0x796954", VA = "0x796954")]
		public RotatingWheelExtra()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class SandDune : MonoBehaviour
	{
		[Token(Token = "0x2000118")]
		[CompilerGenerated]
		private sealed class <MoveDune>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SandDune <>4__this;

			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 direction;

			[Token(Token = "0x170000B6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000575")]
				[Address(RVA = "0x796F60", Offset = "0x796F60", VA = "0x796F60", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000577")]
				[Address(RVA = "0x796FA8", Offset = "0x796FA8", VA = "0x796FA8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000572")]
			[Address(RVA = "0x796BBC", Offset = "0x796BBC", VA = "0x796BBC")]
			[DebuggerHidden]
			public <MoveDune>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000573")]
			[Address(RVA = "0x796D9C", Offset = "0x796D9C", VA = "0x796D9C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000574")]
			[Address(RVA = "0x796DA0", Offset = "0x796DA0", VA = "0x796DA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000576")]
			[Address(RVA = "0x796F68", Offset = "0x796F68", VA = "0x796F68", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000119")]
		[CompilerGenerated]
		private sealed class <SnowCollision>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SandDune <>4__this;

			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private GameObject <effect>5__2;

			[Token(Token = "0x170000B8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600057B")]
				[Address(RVA = "0x797184", Offset = "0x797184", VA = "0x797184", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600057D")]
				[Address(RVA = "0x7971CC", Offset = "0x7971CC", VA = "0x7971CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000578")]
			[Address(RVA = "0x796D60", Offset = "0x796D60", VA = "0x796D60")]
			[DebuggerHidden]
			public <SnowCollision>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000579")]
			[Address(RVA = "0x796FB0", Offset = "0x796FB0", VA = "0x796FB0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600057A")]
			[Address(RVA = "0x796FB4", Offset = "0x796FB4", VA = "0x796FB4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600057C")]
			[Address(RVA = "0x79718C", Offset = "0x79718C", VA = "0x79718C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Rigidbody rb;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Header("Settings")]
		private float movementSpeed;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float effectLifeTime;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Debug")]
		public bool isMoving;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool DebugShowVelocity;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject SnowCollisionEffect;

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x796964", Offset = "0x796964", VA = "0x796964")]
		private void Start()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x7969F4", Offset = "0x7969F4", VA = "0x7969F4")]
		private void Update()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x7969F8", Offset = "0x7969F8", VA = "0x7969F8")]
		public void StartMovingDune(Vector3 direction)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x796AB0", Offset = "0x796AB0", VA = "0x796AB0")]
		[IteratorStateMachine(typeof(<MoveDune>d__10))]
		public IEnumerator MoveDune(Vector3 direction)
		{
			return null;
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x796BE4", Offset = "0x796BE4", VA = "0x796BE4")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x796CB8", Offset = "0x796CB8", VA = "0x796CB8")]
		public void StopDune()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x796B48", Offset = "0x796B48", VA = "0x796B48")]
		[IteratorStateMachine(typeof(<SnowCollision>d__13))]
		private IEnumerator SnowCollision()
		{
			return null;
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x796D88", Offset = "0x796D88", VA = "0x796D88")]
		public SandDune()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class SawFirewood : MonoBehaviour
	{
		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool isChoppingWood;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float rotationToSpawnWood;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform spawnPosition;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HamsterWheel hamsterWheel;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject fireWood;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UnityEvent OnSpawn;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private FireStarter fireStarter;

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x7971D4", Offset = "0x7971D4", VA = "0x7971D4")]
		private void Start()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x7971D8", Offset = "0x7971D8", VA = "0x7971D8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x7973CC", Offset = "0x7973CC", VA = "0x7973CC")]
		public void StartChopping()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x7973D8", Offset = "0x7973D8", VA = "0x7973D8")]
		public void StopChopping()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x797218", Offset = "0x797218", VA = "0x797218")]
		public void SpawnWood()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x7973F8", Offset = "0x7973F8", VA = "0x7973F8")]
		public SawFirewood()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class VRStone : MonoBehaviour
	{
		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityEvent OnStonesHit;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject sparkEffect;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 collisionPos;

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x797400", Offset = "0x797400", VA = "0x797400")]
		private void Start()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x797404", Offset = "0x797404", VA = "0x797404")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x7974EC", Offset = "0x7974EC", VA = "0x7974EC")]
		public VRStone()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class WindVane : MonoBehaviour
	{
		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Objects")]
		[SerializeField]
		private DesertWind desertWind;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform back;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform front;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Animator animator;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string previousDirection;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Debug")]
		[SerializeField]
		private string windDirection;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Directions - assign")]
		[SerializeField]
		private Transform north;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform east;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform south;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform west;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string buttonWindDir;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool turnTowards;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float yRot;

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x7974F4", Offset = "0x7974F4", VA = "0x7974F4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x7975D0", Offset = "0x7975D0", VA = "0x7975D0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x7975EC", Offset = "0x7975EC", VA = "0x7975EC")]
		private void Update()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x797734", Offset = "0x797734", VA = "0x797734")]
		public void TryChangeWindDirection()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x7978CC", Offset = "0x7978CC", VA = "0x7978CC")]
		public void SetDirection(string dir)
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x797928", Offset = "0x797928", VA = "0x797928")]
		public WindVane()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class FreezeSeekerTrigger : MonoBehaviour
	{
		[Token(Token = "0x200011E")]
		[CompilerGenerated]
		private sealed class <FreezeSeeker>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GameObject seeker;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float duration;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public FreezeSeekerTrigger <>4__this;

			[Token(Token = "0x170000BA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000595")]
				[Address(RVA = "0x797BDC", Offset = "0x797BDC", VA = "0x797BDC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000597")]
				[Address(RVA = "0x797C24", Offset = "0x797C24", VA = "0x797C24", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000592")]
			[Address(RVA = "0x797AA0", Offset = "0x797AA0", VA = "0x797AA0")]
			[DebuggerHidden]
			public <FreezeSeeker>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000593")]
			[Address(RVA = "0x797AD0", Offset = "0x797AD0", VA = "0x797AD0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000594")]
			[Address(RVA = "0x797AD4", Offset = "0x797AD4", VA = "0x797AD4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000596")]
			[Address(RVA = "0x797BE4", Offset = "0x797BE4", VA = "0x797BE4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool willFreeze;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float freezeDuration;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float defaultSpeed;

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x797930", Offset = "0x797930", VA = "0x797930")]
		private void Start()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x797934", Offset = "0x797934", VA = "0x797934")]
		private void Update()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x797938", Offset = "0x797938", VA = "0x797938")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x797A00", Offset = "0x797A00", VA = "0x797A00")]
		[IteratorStateMachine(typeof(<FreezeSeeker>d__6))]
		private IEnumerator FreezeSeeker(GameObject seeker, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x797AC8", Offset = "0x797AC8", VA = "0x797AC8")]
		public FreezeSeekerTrigger()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class PlayerController : MonoBehaviour
	{
		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera mainCamera;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private NavMeshAgent m_Agent;

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x797C2C", Offset = "0x797C2C", VA = "0x797C2C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x797CE4", Offset = "0x797CE4", VA = "0x797CE4")]
		private void Update()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x797F58", Offset = "0x797F58", VA = "0x797F58")]
		public PlayerController()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public class SeekerEffects : MonoBehaviour
	{
		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject deathEffect;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject respawnEffect;

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x797F60", Offset = "0x797F60", VA = "0x797F60")]
		private void Update()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x78EEF0", Offset = "0x78EEF0", VA = "0x78EEF0")]
		public void PlayDeathEffect()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x78F0F0", Offset = "0x78F0F0", VA = "0x78F0F0")]
		public void PlayRespawnEffect()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x797F64", Offset = "0x797F64", VA = "0x797F64")]
		public SeekerEffects()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class SeekerInteract : MonoBehaviour
	{
		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Header("Automated")]
		private bool nextToNPC;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool readyToInteract;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[SerializeField]
		private bool isPcPlayer;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Gamepad gamepad;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject interactNPC;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Header("Seeker Howl Sounds and settings")]
		private AudioClip[] seekerHowls;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AudioSource seekerAudio;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float[] seekerHowlDelays;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float seekerHowlFrequency;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float seekerHowlTimer;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool canHowl;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Header("Wait time before restarting dialog")]
		[SerializeField]
		private float waitTime;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float waitTimeCounter;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Header("Spirit roaring frequency")]
		[SerializeField]
		private float roarWaitTime;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float roarWaitTimeCounter;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool canRoar;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		[Header("Set up VR controller input")]
		private bool useLeftHand;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Animator spiritAnimator;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AudioSource spiritAudio;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool vrInteractInputPressed;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Animator animator;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private SeekerIdleAnimations seekerIdleanims;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Header("MyShadow Canvas")]
		private Canvas menuCanvas;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UnityEvent OnEmote;

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x797F6C", Offset = "0x797F6C", VA = "0x797F6C")]
		private void Start()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x798280", Offset = "0x798280", VA = "0x798280")]
		private void Update()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x798574", Offset = "0x798574", VA = "0x798574")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x7986C4", Offset = "0x7986C4", VA = "0x7986C4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x79886C", Offset = "0x79886C", VA = "0x79886C")]
		private void EmoteActionPressed(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x7984C4", Offset = "0x7984C4", VA = "0x7984C4")]
		public void Emote()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x798960", Offset = "0x798960", VA = "0x798960")]
		private void PlayHowlSound()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x78ABE8", Offset = "0x78ABE8", VA = "0x78ABE8")]
		public void NextToNPC(bool isNext)
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x798410", Offset = "0x798410", VA = "0x798410")]
		public void TryTalkingToNPC()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x79802C", Offset = "0x79802C", VA = "0x79802C")]
		public void SetPCPlayer(bool isPCPlayer)
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x798A10", Offset = "0x798A10", VA = "0x798A10")]
		public SeekerInteract()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class SlipperyGroundMovementController : MonoBehaviour
	{
		[Token(Token = "0x2000123")]
		[CompilerGenerated]
		private sealed class <Slide>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SlipperyGroundMovementController <>4__this;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <slideTime>5__2;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <rotationSpeed>5__3;

			[Token(Token = "0x170000BC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005B5")]
				[Address(RVA = "0x799608", Offset = "0x799608", VA = "0x799608", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005B7")]
				[Address(RVA = "0x799650", Offset = "0x799650", VA = "0x799650", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x799428", Offset = "0x799428", VA = "0x799428")]
			[DebuggerHidden]
			public <Slide>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x799458", Offset = "0x799458", VA = "0x799458", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x79945C", Offset = "0x79945C", VA = "0x79945C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x799610", Offset = "0x799610", VA = "0x799610", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform vrCameraTrans;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pcCameraTrans;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Optional camera transform used for calculating movement direction. If assigned, character movement will take camera view into account.")]
		public Transform cameraTransform;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Transform tr;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected CharacterInput characterInput;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody rb;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator anim;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Header("Settings")]
		private float movementSpeed;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float maxSlideTime;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Header("Debug")]
		private bool canStartSliding;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool keepSliding;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private Vector3 direction;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Vector3 previousDir;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject lastCollided;

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x798A18", Offset = "0x798A18", VA = "0x798A18")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x798AFC", Offset = "0x798AFC", VA = "0x798AFC")]
		public void SetPCCamera(bool pcCamera)
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x798B28", Offset = "0x798B28", VA = "0x798B28")]
		private void Update()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x798CCC", Offset = "0x798CCC", VA = "0x798CCC", Slot = "4")]
		protected virtual Vector3 CalculateMovementDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x798B38", Offset = "0x798B38", VA = "0x798B38")]
		private void SlideTo()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x7992C8", Offset = "0x7992C8", VA = "0x7992C8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x799254", Offset = "0x799254", VA = "0x799254")]
		[IteratorStateMachine(typeof(<Slide>d__20))]
		public IEnumerator Slide()
		{
			return null;
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x799450", Offset = "0x799450", VA = "0x799450")]
		public SlipperyGroundMovementController()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class SeekerTeleport : MonoBehaviour
	{
		[Token(Token = "0x2000125")]
		[CompilerGenerated]
		private sealed class <TeleportSeekerAfter>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SeekerTeleport <>4__this;

			[Token(Token = "0x170000BE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005C0")]
				[Address(RVA = "0x799B88", Offset = "0x799B88", VA = "0x799B88", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005C2")]
				[Address(RVA = "0x799BD0", Offset = "0x799BD0", VA = "0x799BD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x7997C8", Offset = "0x7997C8", VA = "0x7997C8")]
			[DebuggerHidden]
			public <TeleportSeekerAfter>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x79991C", Offset = "0x79991C", VA = "0x79991C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x799920", Offset = "0x799920", VA = "0x799920", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005C1")]
			[Address(RVA = "0x799B90", Offset = "0x799B90", VA = "0x799B90", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GameObject exitPoint;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject entryTrigger;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject seeker;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool justTeleported;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Header("Settings")]
		private float waitTimeBeforeTeleport;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float teleportingTime;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Effects")]
		[SerializeField]
		private ParticleSystem startTeleportEffect;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ParticleSystem afterTeleportEffect;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float startEffectDuration;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float afterEffectDuration;

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x799658", Offset = "0x799658", VA = "0x799658")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x799734", Offset = "0x799734", VA = "0x799734")]
		public void TeleportSeeker()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x799754", Offset = "0x799754", VA = "0x799754")]
		[IteratorStateMachine(typeof(<TeleportSeekerAfter>d__12))]
		public IEnumerator TeleportSeekerAfter()
		{
			return null;
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x7997F0", Offset = "0x7997F0", VA = "0x7997F0")]
		public void TeleportComplete()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x799914", Offset = "0x799914", VA = "0x799914")]
		public SeekerTeleport()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class ShiftingDunes : MonoBehaviour
	{
		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SandDune[] dunes;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DesertWind desertWind;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 direction;

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x799BD8", Offset = "0x799BD8", VA = "0x799BD8")]
		private void Start()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x799C84", Offset = "0x799C84", VA = "0x799C84")]
		public void MoveDunes()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x799DA0", Offset = "0x799DA0", VA = "0x799DA0")]
		public ShiftingDunes()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class ControllerTxt : MonoBehaviour
	{
		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GameObject textOriginal;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject textInverted;

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x799DA8", Offset = "0x799DA8", VA = "0x799DA8")]
		private void Start()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x799E74", Offset = "0x799E74", VA = "0x799E74")]
		public void ShowCorrectText()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x799F10", Offset = "0x799F10", VA = "0x799F10")]
		public ControllerTxt()
		{
		}
	}
	[Token(Token = "0x2000128")]
	public class GribUITutorialSprite : MonoBehaviour
	{
		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GameObject tutorialSprite;

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x799F18", Offset = "0x799F18", VA = "0x799F18")]
		private void Start()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x79A024", Offset = "0x79A024", VA = "0x79A024")]
		public void ShowSprite()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x799F64", Offset = "0x799F64", VA = "0x799F64")]
		public void HideSprite()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x79A0E4", Offset = "0x79A0E4", VA = "0x79A0E4")]
		public GribUITutorialSprite()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class LevelSelector : MonoBehaviour
	{
		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Header("Level names")]
		private string[] allLevels;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int activeLevel;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int amountOfLevels;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Pages on the book")]
		[SerializeField]
		private GameObject[] levelPages;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Objects")]
		[SerializeField]
		private GameObject ArrowPrevious;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject ArrowNext;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject LevelLoadTrigger;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ParticleSystem pageTurnEffect;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float pageTurnWaitTime;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float pageTurnTimer;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Header("Loading Screens in the build order")]
		private Texture[] loadingScreens;

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x79A0EC", Offset = "0x79A0EC", VA = "0x79A0EC")]
		private void Start()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x79A260", Offset = "0x79A260", VA = "0x79A260")]
		private void Update()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x79A294", Offset = "0x79A294", VA = "0x79A294")]
		public void KeyboardTests()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x79A5EC", Offset = "0x79A5EC", VA = "0x79A5EC")]
		public void FillLevelNames()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x79A344", Offset = "0x79A344", VA = "0x79A344")]
		public void NextLevel()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x79A4A0", Offset = "0x79A4A0", VA = "0x79A4A0")]
		public void PreviousLevel()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x79A25C", Offset = "0x79A25C", VA = "0x79A25C")]
		public void UpdateLevelInfo()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x79A63C", Offset = "0x79A63C", VA = "0x79A63C")]
		public void PlayPageTurnEffect()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x79A200", Offset = "0x79A200", VA = "0x79A200")]
		public void GetActiveLevel()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x79A658", Offset = "0x79A658", VA = "0x79A658")]
		public void SaveGame()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x79A6AC", Offset = "0x79A6AC", VA = "0x79A6AC")]
		public LevelSelector()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public class MenuBook : MonoBehaviour
	{
		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Demo levels or all levels?")]
		[SerializeField]
		private bool isDemoBook;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		[SerializeField]
		private Material dimmedMaterial;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material[] originalMaterials;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Level names - filled automatically")]
		[SerializeField]
		private string[] allLevels;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int activeLevel;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private int amountOfLevels;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int firstLevel;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int lastLevel;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Header("Pages on the book - add here")]
		private GameObject[] levelPages;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Objects")]
		[SerializeField]
		private GameObject ArrowPrevious;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject ArrowNext;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ParticleSystem pageTurnEffect;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject LevelLoadTrigger;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private SteamVR_LoadLevel loadLevel;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public LevelLock levelLock;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject levelPreviewGlitter;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject vrInteractable;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float pageTurnWaitTime;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		private float pageTurnTimer;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[Header("Loading Screens in the build order")]
		[SerializeField]
		private Texture[] loadingScreens;

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x79A6B4", Offset = "0x79A6B4", VA = "0x79A6B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x79AA04", Offset = "0x79AA04", VA = "0x79AA04")]
		private void Start()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x79B380", Offset = "0x79B380", VA = "0x79B380")]
		private void Update()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x79B124", Offset = "0x79B124", VA = "0x79B124")]
		public List<int> InitializeEggLockedLevels()
		{
			return null;
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x79ACF8", Offset = "0x79ACF8", VA = "0x79ACF8")]
		public void FillLevelNames()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x79B3B4", Offset = "0x79B3B4", VA = "0x79B3B4")]
		public string SceneNameByBuildIndex(int index)
		{
			return null;
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x79AF90", Offset = "0x79AF90", VA = "0x79AF90")]
		public int BookPageForLevel(int levelIndex)
		{
			return default(int);
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x79B420", Offset = "0x79B420", VA = "0x79B420")]
		public GameObject GetPageForLevel(int levelIndex)
		{
			return null;
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x79B458", Offset = "0x79B458", VA = "0x79B458")]
		public void NextLevel()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x79B6A8", Offset = "0x79B6A8", VA = "0x79B6A8")]
		public void DimDisableBook()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x79B7E4", Offset = "0x79B7E4", VA = "0x79B7E4")]
		public void UnDimEnableBook()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x79B888", Offset = "0x79B888", VA = "0x79B888")]
		public void PreviousLevel()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x79AE50", Offset = "0x79AE50", VA = "0x79AE50")]
		public void UpdateLevelInfo()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x79B68C", Offset = "0x79B68C", VA = "0x79B68C")]
		public void PlayPageTurnEffect()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x79ADE0", Offset = "0x79ADE0", VA = "0x79ADE0")]
		public void GetActiveLevel()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x79B324", Offset = "0x79B324", VA = "0x79B324")]
		public void SaveGame()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x79BAB0", Offset = "0x79BAB0", VA = "0x79BAB0")]
		public MenuBook()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public class MenuBookController : MonoBehaviour
	{
		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject demoBook;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject fullBook;

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x79BAB8", Offset = "0x79BAB8", VA = "0x79BAB8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x79BB54", Offset = "0x79BB54", VA = "0x79BB54")]
		public MenuBookController()
		{
		}
	}
	[Token(Token = "0x200012C")]
	public class MenuBookPage : MonoBehaviour
	{
		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Debug - automated")]
		public int pageLevelNumber;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string levelName;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image levelImage;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Header("Collectables")]
		private GameObject seekerCard;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject checkMark;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject blueEgg;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject pinkEgg;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject redEgg;

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x79BB5C", Offset = "0x79BB5C", VA = "0x79BB5C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x79BC64", Offset = "0x79BC64", VA = "0x79BC64")]
		public void DimImage()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x79BCA0", Offset = "0x79BCA0", VA = "0x79BCA0")]
		public void UnDimImage()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x79A7D8", Offset = "0x79A7D8", VA = "0x79A7D8")]
		public void SetCollectableIDs()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x79AF9C", Offset = "0x79AF9C", VA = "0x79AF9C")]
		public void ShowCollectedItems()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x79BCD4", Offset = "0x79BCD4", VA = "0x79BCD4")]
		private void ActivateEgg(GameObject egg)
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x79BD68", Offset = "0x79BD68", VA = "0x79BD68")]
		private void HideEgg(GameObject egg)
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x79BDFC", Offset = "0x79BDFC", VA = "0x79BDFC")]
		public MenuBookPage()
		{
		}
	}
	[Token(Token = "0x200012D")]
	public class Notification : MonoBehaviour
	{
		[Token(Token = "0x200012E")]
		[CompilerGenerated]
		private sealed class <HideNotificationAfter>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Notification <>4__this;

			[Token(Token = "0x170000C0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005FD")]
				[Address(RVA = "0x79C180", Offset = "0x79C180", VA = "0x79C180", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005FF")]
				[Address(RVA = "0x79C1C8", Offset = "0x79C1C8", VA = "0x79C1C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x79C094", Offset = "0x79C094", VA = "0x79C094")]
			[DebuggerHidden]
			public <HideNotificationAfter>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x79C0C4", Offset = "0x79C0C4", VA = "0x79C0C4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x79C0C8", Offset = "0x79C0C8", VA = "0x79C0C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x79C188", Offset = "0x79C188", VA = "0x79C188", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject notificationText;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject notificationImage;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshProUGUI textMesh;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Sprite image;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float notificationTime;

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x79BE04", Offset = "0x79BE04", VA = "0x79BE04")]
		private void Start()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x79BF18", Offset = "0x79BF18", VA = "0x79BF18")]
		private void Update()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x79BF1C", Offset = "0x79BF1C", VA = "0x79BF1C")]
		public void ShowNotification(string notification)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x79C054", Offset = "0x79C054", VA = "0x79C054")]
		public void ShowNotificationImage(Sprite imageToShow)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x79BEA8", Offset = "0x79BEA8", VA = "0x79BEA8")]
		public void HideNotification()
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x79BFD0", Offset = "0x79BFD0", VA = "0x79BFD0")]
		[IteratorStateMachine(typeof(<HideNotificationAfter>d__10))]
		public IEnumerator HideNotificationAfter(float time)
		{
			return null;
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x79C0BC", Offset = "0x79C0BC", VA = "0x79C0BC")]
		public Notification()
		{
		}
	}
	[Token(Token = "0x200012F")]
	public class NotificationManager : MonoBehaviour
	{
		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Notification pcNotification;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Notification vrNotification;

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x79C1D0", Offset = "0x79C1D0", VA = "0x79C1D0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x79C280", Offset = "0x79C280", VA = "0x79C280")]
		public void NotifyBothPlayers(string notification)
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x79C2B8", Offset = "0x79C2B8", VA = "0x79C2B8")]
		public void ShowImageToBoth(Sprite image)
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x79C2F0", Offset = "0x79C2F0", VA = "0x79C2F0")]
		public void ClearAllNotifications()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x79C318", Offset = "0x79C318", VA = "0x79C318")]
		public NotificationManager()
		{
		}
	}
	[Token(Token = "0x2000130")]
	public class OutroFader : MonoBehaviour
	{
		[Token(Token = "0x2000131")]
		[CompilerGenerated]
		private sealed class <FadeToBlack>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OutroFader <>4__this;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <targetAlpha>5__2;

			[Token(Token = "0x170000C2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600060E")]
				[Address(RVA = "0x79C9C4", Offset = "0x79C9C4", VA = "0x79C9C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000610")]
				[Address(RVA = "0x79CA0C", Offset = "0x79CA0C", VA = "0x79CA0C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x79C5B4", Offset = "0x79C5B4", VA = "0x79C5B4")]
			[DebuggerHidden]
			public <FadeToBlack>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x79C698", Offset = "0x79C698", VA = "0x79C698", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x79C69C", Offset = "0x79C69C", VA = "0x79C69C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600060F")]
			[Address(RVA = "0x79C9CC", Offset = "0x79C9CC", VA = "0x79C9CC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GameObject seeker;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool fadeStarted;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool fadeComplete;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Header("Objects")]
		private RawImage fadeOutImage;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SkinnedMeshRenderer spiritBody;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SkinnedMeshRenderer spiritHead;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Fade settings")]
		[SerializeField]
		private float waitBeforeFade;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float fadeOutSpeed;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float alpha;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Canvas canvas;

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x79C320", Offset = "0x79C320", VA = "0x79C320")]
		private void Start()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x79C3D0", Offset = "0x79C3D0", VA = "0x79C3D0")]
		public void StartOutroFade()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x79C540", Offset = "0x79C540", VA = "0x79C540")]
		[IteratorStateMachine(typeof(<FadeToBlack>d__12))]
		public IEnumerator FadeToBlack()
		{
			return null;
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x79C5DC", Offset = "0x79C5DC", VA = "0x79C5DC")]
		private void ChangeImageColor()
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x79C470", Offset = "0x79C470", VA = "0x79C470")]
		private void FreezeSeeker()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x79C690", Offset = "0x79C690", VA = "0x79C690")]
		public OutroFader()
		{
		}
	}
	[Token(Token = "0x2000132")]
	public class SeekerCardCottageLerp : MonoBehaviour
	{
		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector3 positionUp;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Vector3 positionDown;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float movingSpeedMin;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float movingSpeedMax;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float movingSpeed;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float fraction;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool movingUp;

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x79CA14", Offset = "0x79CA14", VA = "0x79CA14")]
		private void Start()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x79CB08", Offset = "0x79CB08", VA = "0x79CB08")]
		private void Update()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x79CC58", Offset = "0x79CC58", VA = "0x79CC58")]
		public SeekerCardCottageLerp()
		{
		}
	}
	[Token(Token = "0x2000133")]
	public class SpiritCardCottage : MonoBehaviour
	{
		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Materials")]
		[SerializeField]
		private Material cardNotFoundMaterial;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool isCollected;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MeshRenderer mesh;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CottageCollectable collectable;

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x79CC60", Offset = "0x79CC60", VA = "0x79CC60")]
		private void Start()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x79CDE8", Offset = "0x79CDE8", VA = "0x79CDE8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x79CD40", Offset = "0x79CD40", VA = "0x79CD40")]
		public void UpdateCardImage()
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x79CDEC", Offset = "0x79CDEC", VA = "0x79CDEC")]
		public SpiritCardCottage()
		{
		}
	}
	[Token(Token = "0x2000134")]
	public class UIButtonLanguage : MonoBehaviour
	{
		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Use short code from localization csv - fi, en, de, etc")]
		[SerializeField]
		private string language;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private UnityEngine.UI.Button m_Button;

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x79CDF4", Offset = "0x79CDF4", VA = "0x79CDF4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x79CE4C", Offset = "0x79CE4C", VA = "0x79CE4C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x79CEE0", Offset = "0x79CEE0", VA = "0x79CEE0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x79CF74", Offset = "0x79CF74", VA = "0x79CF74")]
		private void HandleButtonClick()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x79CF80", Offset = "0x79CF80", VA = "0x79CF80")]
		public UIButtonLanguage()
		{
		}
	}
	[Token(Token = "0x2000135")]
	public class UIButtonResetCollectables : MonoBehaviour
	{
		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private UnityEngine.UI.Button m_Button;

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x79DF88", Offset = "0x79DF88", VA = "0x79DF88")]
		private void Awake()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x79DFE0", Offset = "0x79DFE0", VA = "0x79DFE0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x79E074", Offset = "0x79E074", VA = "0x79E074")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x79E108", Offset = "0x79E108", VA = "0x79E108")]
		private void HandleButtonClick()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x79E1A0", Offset = "0x79E1A0", VA = "0x79E1A0")]
		public UIButtonResetCollectables()
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class UIButtonResetLevels : MonoBehaviour
	{
		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private UnityEngine.UI.Button m_Button;

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x79E1A8", Offset = "0x79E1A8", VA = "0x79E1A8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x79E200", Offset = "0x79E200", VA = "0x79E200")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x79E294", Offset = "0x79E294", VA = "0x79E294")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x79E328", Offset = "0x79E328", VA = "0x79E328")]
		private void HandleButtonClick()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x79E37C", Offset = "0x79E37C", VA = "0x79E37C")]
		public UIButtonResetLevels()
		{
		}
	}
	[Token(Token = "0x2000137")]
	public class UIButtonRestartLevel : MonoBehaviour
	{
		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private UnityEngine.UI.Button m_Button;

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x79E384", Offset = "0x79E384", VA = "0x79E384")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x79E46C", Offset = "0x79E46C", VA = "0x79E46C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x79E500", Offset = "0x79E500", VA = "0x79E500")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x79E594", Offset = "0x79E594", VA = "0x79E594")]
		private void HandleButtonClick()
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x79E604", Offset = "0x79E604", VA = "0x79E604")]
		public UIButtonRestartLevel()
		{
		}
	}
	[Token(Token = "0x2000138")]
	public class UIButtonReturnHome : MonoBehaviour
	{
		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private UnityEngine.UI.Button m_Button;

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x79E60C", Offset = "0x79E60C", VA = "0x79E60C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x79E6F4", Offset = "0x79E6F4", VA = "0x79E6F4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x79E788", Offset = "0x79E788", VA = "0x79E788")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x79E81C", Offset = "0x79E81C", VA = "0x79E81C")]
		private void HandleButtonClick()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x79E884", Offset = "0x79E884", VA = "0x79E884")]
		public UIButtonReturnHome()
		{
		}
	}
	[Token(Token = "0x2000139")]
	public class UIButtonUnlockLevels : MonoBehaviour
	{
		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private UnityEngine.UI.Button m_Button;

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x79E88C", Offset = "0x79E88C", VA = "0x79E88C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x79E8E4", Offset = "0x79E8E4", VA = "0x79E8E4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x79E978", Offset = "0x79E978", VA = "0x79E978")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x79EA0C", Offset = "0x79EA0C", VA = "0x79EA0C")]
		private void HandleButtonClick()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x79EAA4", Offset = "0x79EAA4", VA = "0x79EAA4")]
		public UIButtonUnlockLevels()
		{
		}
	}
	[Token(Token = "0x200013A")]
	public class UIControlToggle : MonoBehaviour
	{
		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ControllerTxt[] texts;

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x79EAAC", Offset = "0x79EAAC", VA = "0x79EAAC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x79EC0C", Offset = "0x79EC0C", VA = "0x79EC0C")]
		public void ChangeControls()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x79ECB0", Offset = "0x79ECB0", VA = "0x79ECB0")]
		public UIControlToggle()
		{
		}
	}
	[Token(Token = "0x200013B")]
	public class UIDropdownLanguage : MonoBehaviour
	{
		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LocalizationSystem.Language[] languages;

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x79ECB8", Offset = "0x79ECB8", VA = "0x79ECB8")]
		private void Start()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x79EDF0", Offset = "0x79EDF0", VA = "0x79EDF0")]
		public void SubmitLanguage(int index)
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x79EFB4", Offset = "0x79EFB4", VA = "0x79EFB4")]
		public UIDropdownLanguage()
		{
		}
	}
	[Token(Token = "0x200013C")]
	public class UIMessageAction<T1, T2>
	{
		[Token(Token = "0x600063C")]
		public UIMessageAction()
		{
		}
	}
	[Token(Token = "0x200013D")]
	public class UISettingsCanvas : MonoBehaviour
	{
		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isActiveOnStart;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool lookAtPlayer;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Canvas m_Canvas;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject languages;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Camera to follow")]
		[SerializeField]
		private Camera m_Camera;

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x79EFBC", Offset = "0x79EFBC", VA = "0x79EFBC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x79F014", Offset = "0x79F014", VA = "0x79F014")]
		private void Start()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x79F140", Offset = "0x79F140", VA = "0x79F140")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x79F280", Offset = "0x79F280", VA = "0x79F280")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x79F418", Offset = "0x79F418", VA = "0x79F418")]
		private void MenuPressed(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x79F52C", Offset = "0x79F52C", VA = "0x79F52C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x79F688", Offset = "0x79F688", VA = "0x79F688")]
		public UISettingsCanvas()
		{
		}
	}
	[Token(Token = "0x200013E")]
	public class UITextMessages : MonoBehaviour
	{
		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string messageID;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI textMesh;

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x79F690", Offset = "0x79F690", VA = "0x79F690")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x79F7B8", Offset = "0x79F7B8", VA = "0x79F7B8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x79F884", Offset = "0x79F884", VA = "0x79F884")]
		private void HandleEvent(string id, string message)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x79F8E0", Offset = "0x79F8E0", VA = "0x79F8E0")]
		public UITextMessages()
		{
		}
	}
	[Token(Token = "0x200013F")]
	public class VRCanvasPositioner : MonoBehaviour
	{
		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Camera vrCamera;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int VRPlayerUILayer;

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x79F8E8", Offset = "0x79F8E8", VA = "0x79F8E8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x79FA08", Offset = "0x79FA08", VA = "0x79FA08")]
		private void Update()
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x79FA0C", Offset = "0x79FA0C", VA = "0x79FA0C")]
		public VRCanvasPositioner()
		{
		}
	}
	[Token(Token = "0x2000140")]
	public class VRButton : MonoBehaviour
	{
		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Header("Properties")]
		private bool triggerByHover;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool triggerByInteract;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent handHoverBegin;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent handHoverEnd;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent handInteractEvent;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform interactableRoot;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool isInteractable;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform m_HoverTransform;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Animator animator;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private VRGrabbable m_Grabbable;

		[Token(Token = "0x170000C4")]
		public bool IsGrabbable
		{
			[Token(Token = "0x600064F")]
			[Address(RVA = "0x79FCD4", Offset = "0x79FCD4", VA = "0x79FCD4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C5")]
		public VRGrabbable Grabbable
		{
			[Token(Token = "0x6000650")]
			[Address(RVA = "0x79FD34", Offset = "0x79FD34", VA = "0x79FD34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000005")]
		public event Action<VRHand> handHoverBeginEvent
		{
			[Token(Token = "0x600064B")]
			[Address(RVA = "0x79FA14", Offset = "0x79FA14", VA = "0x79FA14")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600064C")]
			[Address(RVA = "0x79FAC4", Offset = "0x79FAC4", VA = "0x79FAC4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event Action<VRHand> handHoverEndEvent
		{
			[Token(Token = "0x600064D")]
			[Address(RVA = "0x79FB74", Offset = "0x79FB74", VA = "0x79FB74")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600064E")]
			[Address(RVA = "0x79FC24", Offset = "0x79FC24", VA = "0x79FC24")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x79FD3C", Offset = "0x79FD3C", VA = "0x79FD3C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x79FFCC", Offset = "0x79FFCC", VA = "0x79FFCC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x7A00D8", Offset = "0x7A00D8", VA = "0x7A00D8")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x7A00DC", Offset = "0x7A00DC", VA = "0x7A00DC")]
		public void SetInteractableState(bool isInteractable)
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x79FD9C", Offset = "0x79FD9C", VA = "0x79FD9C")]
		private void Initialize()
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x7A00E8", Offset = "0x7A00E8", VA = "0x7A00E8")]
		public void OnHandHoverBegin(VRHand hand)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x7A01D4", Offset = "0x7A01D4", VA = "0x7A01D4")]
		public void OnHandHoverEnd(VRHand hand)
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x7A0270", Offset = "0x7A0270", VA = "0x7A0270")]
		public void OnHandInteract(VRHand hand)
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x7A0330", Offset = "0x7A0330", VA = "0x7A0330")]
		public VRButton()
		{
		}
	}
	[Token(Token = "0x2000141")]
	public class VRGrabbable : MonoBehaviour
	{
		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isGrabbable;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected VRHand m_Grabber;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Rigidbody m_MyRigidbody;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Transform m_Target;

		[Token(Token = "0x170000C6")]
		public bool IsGrabbed
		{
			[Token(Token = "0x600065A")]
			[Address(RVA = "0x7A0340", Offset = "0x7A0340", VA = "0x7A0340")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x7A03A0", Offset = "0x7A03A0", VA = "0x7A03A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x7A03F8", Offset = "0x7A03F8", VA = "0x7A03F8")]
		public bool Grab(VRHand hand)
		{
			return default(bool);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x7A0454", Offset = "0x7A0454", VA = "0x7A0454", Slot = "4")]
		protected virtual bool DoGrab(VRHand hand)
		{
			return default(bool);
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x7A07C0", Offset = "0x7A07C0", VA = "0x7A07C0")]
		public void ForceRelease()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x7A0900", Offset = "0x7A0900", VA = "0x7A0900")]
		public bool Release(VRHand hand)
		{
			return default(bool);
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x7A0938", Offset = "0x7A0938", VA = "0x7A0938", Slot = "5")]
		protected virtual bool DoRelease(VRHand hand)
		{
			return default(bool);
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x7A0AE8", Offset = "0x7A0AE8", VA = "0x7A0AE8", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x7A0D98", Offset = "0x7A0D98", VA = "0x7A0D98")]
		private Vector3 OffsetToAngular(Quaternion a, Quaternion b, float timestep)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x7A0FB8", Offset = "0x7A0FB8", VA = "0x7A0FB8")]
		public VRGrabbable()
		{
		}
	}
	[Token(Token = "0x2000142")]
	public class VRGrabbable_Linear : VRGrabbable
	{
		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Axis normalAxis;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Axis axisOfMovement;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool invertNormal;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool isLocked;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		public bool limited;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float minLimit;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float maxLimit;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_LocalPlaneNormal;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 m_PreviousProjection;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform debugTransform;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 m_TargetPos;

		[Token(Token = "0x14000007")]
		public event Action<float> OnMove
		{
			[Token(Token = "0x6000664")]
			[Address(RVA = "0x7A0FC8", Offset = "0x7A0FC8", VA = "0x7A0FC8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000665")]
			[Address(RVA = "0x7A1078", Offset = "0x7A1078", VA = "0x7A1078")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x7A1128", Offset = "0x7A1128", VA = "0x7A1128")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x7A1250", Offset = "0x7A1250", VA = "0x7A1250")]
		public void SetLockedState(bool isLocked)
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x7A125C", Offset = "0x7A125C", VA = "0x7A125C", Slot = "4")]
		protected override bool DoGrab(VRHand hand)
		{
			return default(bool);
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x7A150C", Offset = "0x7A150C", VA = "0x7A150C", Slot = "5")]
		protected override bool DoRelease(VRHand hand)
		{
			return default(bool);
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x7A1514", Offset = "0x7A1514", VA = "0x7A1514")]
		private void Update()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x7A13E0", Offset = "0x7A13E0", VA = "0x7A13E0")]
		private Vector3 ComputeTransformProjected(Transform xForm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x7A1820", Offset = "0x7A1820", VA = "0x7A1820")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x7A192C", Offset = "0x7A192C", VA = "0x7A192C")]
		public VRGrabbable_Linear()
		{
		}
	}
	[Token(Token = "0x2000143")]
	public class VRGrabbable_Rotator : VRGrabbable
	{
		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Axis axisOfRotation;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool invertRotation;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		public bool isLocked;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
		public bool limited;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float minLimit;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float maxLimit;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 m_LocalPlaneNormal;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 m_PreviousProjection;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform debugTransform;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_PreviousAngle;

		[Token(Token = "0x14000008")]
		public event Action<float> OnRotate
		{
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x7A1940", Offset = "0x7A1940", VA = "0x7A1940")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600066F")]
			[Address(RVA = "0x7A19F0", Offset = "0x7A19F0", VA = "0x7A19F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x7A1AA0", Offset = "0x7A1AA0", VA = "0x7A1AA0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x7A1BC8", Offset = "0x7A1BC8", VA = "0x7A1BC8")]
		public void SetLockedState(bool isLocked)
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x7A1BD4", Offset = "0x7A1BD4", VA = "0x7A1BD4", Slot = "4")]
		protected override bool DoGrab(VRHand hand)
		{
			return default(bool);
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x7A1EB8", Offset = "0x7A1EB8", VA = "0x7A1EB8", Slot = "5")]
		protected override bool DoRelease(VRHand hand)
		{
			return default(bool);
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x7A1EC0", Offset = "0x7A1EC0", VA = "0x7A1EC0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x7A1CF4", Offset = "0x7A1CF4", VA = "0x7A1CF4")]
		private Vector3 ComputeTransformProjected(Transform xForm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x7A2344", Offset = "0x7A2344", VA = "0x7A2344")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x7A2450", Offset = "0x7A2450", VA = "0x7A2450")]
		public VRGrabbable_Rotator()
		{
		}
	}
	[Token(Token = "0x2000144")]
	public class VRHand : MonoBehaviour
	{
		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask handHoverMask;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform handHoverTransform;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float handHoverRadius;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform root;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("XR Input")]
		public bool isLeftHand;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static XRController leftController;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static XRController rightController;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Rigidbody handAttachRigidbody;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Header("DevTestTool settings")]
		public bool isDTTHand;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Collider[] m_HoveringColliders;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private VRInteractable m_ClosestHoverInteractable;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float m_ClosestHoverDistance;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private VRInteractable m_HoveringInteractable;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private VRGrabbable m_CurrentlyGrabbedObject;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private VRInteractable m_InteractingButExitedInteractable;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Animator animator;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool InteractHeldDown;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Transform uiOffsetTransform;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Transform CurrentUISelectorHand;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float hapticAmplitude;

		[Token(Token = "0x170000C7")]
		public bool HasObjectInHand
		{
			[Token(Token = "0x6000678")]
			[Address(RVA = "0x7A2464", Offset = "0x7A2464", VA = "0x7A2464")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x7A246C", Offset = "0x7A246C", VA = "0x7A246C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x7A2690", Offset = "0x7A2690", VA = "0x7A2690")]
		private void Update()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x7A315C", Offset = "0x7A315C", VA = "0x7A315C")]
		public bool IsGrabbingSomething()
		{
			return default(bool);
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x7A2F2C", Offset = "0x7A2F2C", VA = "0x7A2F2C")]
		private void TryReleaseGrabbedObject()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x7A0840", Offset = "0x7A0840", VA = "0x7A0840")]
		public void ForceReleaseGrabbed()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x7A2E2C", Offset = "0x7A2E2C", VA = "0x7A2E2C")]
		private bool TryGrabClosestObject()
		{
			return default(bool);
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x7A2B44", Offset = "0x7A2B44", VA = "0x7A2B44")]
		private void UpdateClosestHandInteractable()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x7A0A60", Offset = "0x7A0A60", VA = "0x7A0A60")]
		public Vector3 GetHandVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x7A0AA4", Offset = "0x7A0AA4", VA = "0x7A0AA4")]
		public Vector3 GetHandAngularVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x7A0740", Offset = "0x7A0740", VA = "0x7A0740")]
		public void GrabAnimation(bool setTrue)
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x7A06C0", Offset = "0x7A06C0", VA = "0x7A06C0")]
		public void PointAnimation(bool setTrue)
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x7A2FF0", Offset = "0x7A2FF0", VA = "0x7A2FF0")]
		public void PressAnimation(bool setTrue)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x7A0640", Offset = "0x7A0640", VA = "0x7A0640")]
		public void HoverAnimation(bool setTrue)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x7A3280", Offset = "0x7A3280", VA = "0x7A3280")]
		public bool IsLeftHand()
		{
			return default(bool);
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x7A3288", Offset = "0x7A3288", VA = "0x7A3288")]
		public bool IsRightHand()
		{
			return default(bool);
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x7A2DFC", Offset = "0x7A2DFC", VA = "0x7A2DFC")]
		private void BuzzLeft()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x7A2E14", Offset = "0x7A2E14", VA = "0x7A2E14")]
		private void BuzzRight()
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x7A3298", Offset = "0x7A3298", VA = "0x7A3298")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x7A32E8", Offset = "0x7A32E8", VA = "0x7A32E8")]
		public VRHand()
		{
		}
	}
	[Token(Token = "0x2000145")]
	public class VRInteractable : MonoBehaviour
	{
		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityEvent handHoverBegin;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEvent handHoverEnd;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEvent handInteractEvent;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform interactableRoot;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool isInteractable;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool isPressable;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		public bool allowHold;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private VRGrabbable m_Grabbable;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform m_HoverTransform;

		[Token(Token = "0x170000C8")]
		public bool IsGrabbable
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x7A3220", Offset = "0x7A3220", VA = "0x7A3220")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C9")]
		public VRGrabbable Grabbable
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x7A35C0", Offset = "0x7A35C0", VA = "0x7A35C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000009")]
		public event Action<VRHand> handHoverBeginEvent
		{
			[Token(Token = "0x600068C")]
			[Address(RVA = "0x7A3300", Offset = "0x7A3300", VA = "0x7A3300")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600068D")]
			[Address(RVA = "0x7A33B0", Offset = "0x7A33B0", VA = "0x7A33B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event Action<VRHand> handHoverEndEvent
		{
			[Token(Token = "0x600068E")]
			[Address(RVA = "0x7A3460", Offset = "0x7A3460", VA = "0x7A3460")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x7A3510", Offset = "0x7A3510", VA = "0x7A3510")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x7A35C8", Offset = "0x7A35C8", VA = "0x7A35C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x7A37FC", Offset = "0x7A37FC", VA = "0x7A37FC")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x7A3800", Offset = "0x7A3800", VA = "0x7A3800")]
		public void SetInteractableState(bool isInteractable)
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x7A35CC", Offset = "0x7A35CC", VA = "0x7A35CC")]
		private void Initialize()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x7A3070", Offset = "0x7A3070", VA = "0x7A3070")]
		public void OnHandHoverBegin(VRHand hand)
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x7A30F4", Offset = "0x7A30F4", VA = "0x7A30F4")]
		public void OnHandHoverEnd(VRHand hand)
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x7A2EE8", Offset = "0x7A2EE8", VA = "0x7A2EE8")]
		public void OnHandInteract(VRHand hand)
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x7A3914", Offset = "0x7A3914", VA = "0x7A3914")]
		public void RunInitialize()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x7A3844", Offset = "0x7A3844", VA = "0x7A3844")]
		public void ShowHandInteractAnimation(VRHand hand)
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x7A380C", Offset = "0x7A380C", VA = "0x7A380C")]
		public void StopInteractionAnimations(VRHand hand)
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x7A3918", Offset = "0x7A3918", VA = "0x7A3918")]
		public VRInteractable()
		{
		}
	}
	[Token(Token = "0x2000146")]
	public class VROutline : MonoBehaviour
	{
		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_OutlineTransform;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MeshRenderer m_OutlineMeshRenderer;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool HasIdleOutline;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Material idleMat;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Material hoverMat;

		[Token(Token = "0x170000CA")]
		public MeshRenderer OutlineMeshRenderer
		{
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x7A392C", Offset = "0x7A392C", VA = "0x7A392C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x7A39E0", Offset = "0x7A39E0", VA = "0x7A39E0")]
		private void Start()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x7A3B78", Offset = "0x7A3B78", VA = "0x7A3B78")]
		private void Update()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x7A3C3C", Offset = "0x7A3C3C", VA = "0x7A3C3C")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x7A3D00", Offset = "0x7A3D00", VA = "0x7A3D00")]
		public void ShowOutline()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x7A3DB8", Offset = "0x7A3DB8", VA = "0x7A3DB8")]
		public void HideOutline()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x7A3E70", Offset = "0x7A3E70", VA = "0x7A3E70")]
		public void Initialize()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x7A42A0", Offset = "0x7A42A0", VA = "0x7A42A0")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x7A4310", Offset = "0x7A4310", VA = "0x7A4310")]
		public VROutline()
		{
		}
	}
	[Token(Token = "0x2000147")]
	public class VRPlayerRotator : MonoBehaviour
	{
		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform centerTransform;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float rotateSpeed;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool m_RotateLeft;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		private bool m_RotateRight;

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x7A4320", Offset = "0x7A4320", VA = "0x7A4320")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x7A4324", Offset = "0x7A4324", VA = "0x7A4324")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x7A4328", Offset = "0x7A4328", VA = "0x7A4328")]
		private void Update()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x7A434C", Offset = "0x7A434C", VA = "0x7A434C")]
		public void RotatePlayer(float dir)
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x7A4428", Offset = "0x7A4428", VA = "0x7A4428")]
		public VRPlayerRotator()
		{
		}
	}
	[Token(Token = "0x2000148")]
	public class WindButtons : MonoBehaviour
	{
		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject[] vrButtons;

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x7A4438", Offset = "0x7A4438", VA = "0x7A4438")]
		public void SetAvailable(bool available)
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x7A44D8", Offset = "0x7A44D8", VA = "0x7A44D8")]
		public WindButtons()
		{
		}
	}
}
namespace QFX.MFX
{
	[Token(Token = "0x2000149")]
	[RequireComponent(typeof(MfxController))]
	internal class MfxActivator : MonoBehaviour
	{
		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private MfxController _mfxController;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _isAlreadyActivated;

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x7A44E0", Offset = "0x7A44E0", VA = "0x7A44E0")]
		public void Activate(Vector3 hitWorldPos)
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x7A4638", Offset = "0x7A4638", VA = "0x7A4638")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x7A4690", Offset = "0x7A4690", VA = "0x7A4690")]
		public MfxActivator()
		{
		}
	}
	[Token(Token = "0x200014A")]
	internal class RayCastShoot : MonoBehaviour
	{
		[Token(Token = "0x200014B")]
		[CompilerGenerated]
		private sealed class <Shoot>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RayCastShoot <>4__this;

			[Token(Token = "0x170000CB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006B7")]
				[Address(RVA = "0x7A4BAC", Offset = "0x7A4BAC", VA = "0x7A4BAC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006B9")]
				[Address(RVA = "0x7A4BF4", Offset = "0x7A4BF4", VA = "0x7A4BF4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x7A4A5C", Offset = "0x7A4A5C", VA = "0x7A4A5C")]
			[DebuggerHidden]
			public <Shoot>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x7A4B14", Offset = "0x7A4B14", VA = "0x7A4B14", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x7A4B18", Offset = "0x7A4B18", VA = "0x7A4B18", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x7A4BB4", Offset = "0x7A4BB4", VA = "0x7A4BB4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float FireRate;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float WeaponRange;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float HitForce;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform GunEnd;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Camera _fpsCam;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly WaitForSeconds _duration;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private LineRenderer _laserLine;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _nextFire;

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x7A4698", Offset = "0x7A4698", VA = "0x7A4698")]
		private void Start()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x7A4728", Offset = "0x7A4728", VA = "0x7A4728")]
		private void Update()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x7A49E8", Offset = "0x7A49E8", VA = "0x7A49E8")]
		[IteratorStateMachine(typeof(<Shoot>d__10))]
		private IEnumerator Shoot()
		{
			return null;
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x7A4A84", Offset = "0x7A4A84", VA = "0x7A4A84")]
		public RayCastShoot()
		{
		}
	}
	[Token(Token = "0x200014C")]
	public enum MaskOffsetDirection
	{
		[Token(Token = "0x400069B")]
		Forward,
		[Token(Token = "0x400069C")]
		Backward
	}
	[Token(Token = "0x200014D")]
	public sealed class MfxController : MonoBehaviour
	{
		[Token(Token = "0x400069D")]
		private const string MfxMaskOffsetProperty = "_MaskOffset";

		[Token(Token = "0x400069E")]
		private const string MfxMaskPositionProperty = "_MaskWorldPosition";

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MaskOffsetDirection MaskOffsetDirection;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve MaskOffsetCurve;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float ScaleTimeFactor;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float ScaleOffsetFactor;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool ModifyChildren;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject TargetObject;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool ByDistance;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject DistanceBasedObject;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool ReplaceMaterial;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool ReplaceMaterialMode;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Material MfxMaterial;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public MfxShaderType MfxShaderType;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool DetermineWorkflowAutomatically;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		public bool AutoDestroy;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		public bool AutoReplace;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		public bool AutoAnimate;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool AutoStop;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float _startTime;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool _isRunning;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private MfxObjectMaterialUpdater _mfxObjectMaterialUpdater;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform _targetTransform;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool _wasEventGenerated;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Action MfxAnimationFinished;

		[Token(Token = "0x170000CD")]
		public GameObject Target
		{
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x7A4BFC", Offset = "0x7A4BFC", VA = "0x7A4BFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x7A455C", Offset = "0x7A455C", VA = "0x7A455C")]
		public void ReplaceMaterials()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x7A4E20", Offset = "0x7A4E20", VA = "0x7A4E20")]
		public void RevertMaterials()
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x7A50C0", Offset = "0x7A50C0", VA = "0x7A50C0")]
		public void Reset()
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x7A458C", Offset = "0x7A458C", VA = "0x7A458C")]
		public void Activate()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x7A50DC", Offset = "0x7A50DC", VA = "0x7A50DC")]
		public void ActivateForward()
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x7A50E4", Offset = "0x7A50E4", VA = "0x7A50E4")]
		public void ActivateBackward()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x7A45C0", Offset = "0x7A45C0", VA = "0x7A45C0")]
		public void SetHitPosition(Vector3 hitPositionWorldPos)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x7A5270", Offset = "0x7A5270", VA = "0x7A5270")]
		private void Start()
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x7A5368", Offset = "0x7A5368", VA = "0x7A5368")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x7A561C", Offset = "0x7A561C", VA = "0x7A561C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x7A5274", Offset = "0x7A5274", VA = "0x7A5274")]
		private void Init()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x7A58BC", Offset = "0x7A58BC", VA = "0x7A58BC")]
		private void Update()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x7A55F8", Offset = "0x7A55F8", VA = "0x7A55F8")]
		private void AnimateIfNeeded()
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x7A5C3C", Offset = "0x7A5C3C", VA = "0x7A5C3C")]
		public MfxController()
		{
		}
	}
	[Token(Token = "0x200014E")]
	internal static class MfxExtensions
	{
		[Token(Token = "0x40006B6")]
		private const string MfxStandardShaderName = "QFX/MFX/Standard";

		[Token(Token = "0x40006B7")]
		private const string MfxStandardSpecularShaderName = "QFX/MFX/Standard Specular";

		[Token(Token = "0x40006B8")]
		private const string MfxStandardTransparentShaderName = "QFX/MFX/Standard Transparent";

		[Token(Token = "0x40006B9")]
		private const string MfxUnlitShaderName = "QFX/MFX/Unlit";

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x7A5C8C", Offset = "0x7A5C8C", VA = "0x7A5C8C")]
		public static string GetShaderName(this MfxShaderType mfxShaderType)
		{
			return null;
		}
	}
	[Token(Token = "0x200014F")]
	internal static class MfxMaterialUtil
	{
		[Token(Token = "0x40006BA")]
		private const string Color2PropName = "_Color2";

		[Token(Token = "0x40006BB")]
		private const string MainTex2PropName = "_MainTex2";

		[Token(Token = "0x40006BC")]
		private const string BumpMap2PropName = "_BumpMap2";

		[Token(Token = "0x40006BD")]
		private const string EmissionColor2PropName = "_Emission2Color";

		[Token(Token = "0x40006BE")]
		private const string EmissionMap2PropName = "_EmissionMap2";

		[Token(Token = "0x40006BF")]
		private const string EmissionMap2ScrollPropName = "_EmissionMap2_Scroll";

		[Token(Token = "0x40006C0")]
		private const string EmissionOffset2PropName = "_Emission2Offset";

		[Token(Token = "0x40006C1")]
		private const string EmissionSmoothPropName = "_Emission2Smooth";

		[Token(Token = "0x40006C2")]
		private const string EmissionInvertPropName = "_Emission2Invert";

		[Token(Token = "0x40006C3")]
		private const string EdgeColorPropName = "_EdgeColor";

		[Token(Token = "0x40006C4")]
		private const string EdgeSizePropName = "_EdgeSize";

		[Token(Token = "0x40006C5")]
		private const string _EdgeOffset = "_EdgeOffset";

		[Token(Token = "0x40006C6")]
		private const string EdgeStrengthPropName = "_EdgeStrength";

		[Token(Token = "0x40006C7")]
		private const string EdgeRampMap1PropName = "_EdgeMap1";

		[Token(Token = "0x40006C8")]
		private const string EdgeRampMap1ScrollPropName = "_EdgeMap1_Scroll";

		[Token(Token = "0x40006C9")]
		private const string DissolveMap1PropName = "_DissolveMap1";

		[Token(Token = "0x40006CA")]
		private const string DissolveMap1ScrollPropName = "_DissolveMap1_Scroll";

		[Token(Token = "0x40006CB")]
		private const string MaskPropName = "_MaskType";

		[Token(Token = "0x40006CC")]
		private const string CutoffAxisPropName = "_CutoffAxis";

		[Token(Token = "0x40006CD")]
		private const string MaskOffsetPropName = "_MaskOffset";

		[Token(Token = "0x40006CE")]
		private const string DissolveSizePropName = "_DissolveSize";

		[Token(Token = "0x40006CF")]
		private const string DissolveEdgeColorPropName = "_DissolveEdgeColor";

		[Token(Token = "0x40006D0")]
		private const string DissolveEdgeSizePropName = "_DissolveEdgeSize";

		[Token(Token = "0x40006D1")]
		private const string InvertPropName = "_Invert";

		[Token(Token = "0x40006D2")]
		private const string _CutoffAxis = "_CutoffAxis";

		[Token(Token = "0x40006D3")]
		private const string _UseEmission2 = "_UseEmission2";

		[Token(Token = "0x40006D4")]
		private const string _EmissionInvert2 = "_EmissionInvert2";

		[Token(Token = "0x40006D5")]
		private const string _FlowMap = "_FlowMap";

		[Token(Token = "0x40006D6")]
		private const string _FlowMap_Scroll = "_FlowMap_Scroll";

		[Token(Token = "0x40006D7")]
		private const string _DistortionStrength = "_DistortionStrength";

		[Token(Token = "0x40006D8")]
		private const string _UseObjectWorldPosition = "_UseObjectWorldPosition";

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x7A5D0C", Offset = "0x7A5D0C", VA = "0x7A5D0C")]
		public static void ReplaceRenderersMaterials(Material mfxTemplateMaterial, GameObject targetObject, bool determineWorkflowAutomatically, MfxShaderType mfxShaderType, bool editorMode)
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x7A5E14", Offset = "0x7A5E14", VA = "0x7A5E14")]
		public static List<Material> ReplaceMaterialsToMfx(Material mfxTemplateMaterial, Material[] targetRendererMaterials, bool determineWorkflowAutomatically, MfxShaderType mfxShaderType, bool editorMode)
		{
			return null;
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x7A6BC8", Offset = "0x7A6BC8", VA = "0x7A6BC8")]
		public static int GetMaterialsCount(GameObject targetObject)
		{
			return default(int);
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x7A6238", Offset = "0x7A6238", VA = "0x7A6238")]
		private static void CopyMfxProperties(Material mfxTemplateMaterial, Material targetMfxMaterial, Material originalMaterial, bool determineWorkflow)
		{
		}

		[Token(Token = "0x60006CE")]
		private static void CopyPropertyToMaterial<T>(Material fromMaterial, Material toMaterial, string fromProperty, string toProperty)
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x7A6A04", Offset = "0x7A6A04", VA = "0x7A6A04")]
		private static void ReplaceMetallicSpecularKeywords(Material fromMaterial, Material toMaterial)
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x7A6C80", Offset = "0x7A6C80", VA = "0x7A6C80")]
		private static void SetKeyword(Material m, string keyword, bool state)
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x7A6124", Offset = "0x7A6124", VA = "0x7A6124")]
		private static string GetShaderByWorkflow(Material targetMaterial)
		{
			return null;
		}
	}
	[Token(Token = "0x2000150")]
	internal sealed class MfxObjectMaterialUpdater
	{
		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly bool _determineWorkflow;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private readonly MfxShaderType _mfxShaderType;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Renderer[] _renderers;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Dictionary<Renderer, Material[]> _rendererToOriginalMaterialsMap;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly List<Material> _mfxMaterials;

		[Token(Token = "0x170000CE")]
		public bool IsMaterialsReplaced
		{
			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x7A6CA0", Offset = "0x7A6CA0", VA = "0x7A6CA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x7A6CA8", Offset = "0x7A6CA8", VA = "0x7A6CA8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x7A5624", Offset = "0x7A5624", VA = "0x7A5624")]
		public MfxObjectMaterialUpdater(GameObject targetObject, bool modifyChildren, bool replaceMaterialsAtStart, Material mfxTemplateMaterial, bool determineWorkflow, MfxShaderType mfxShaderType)
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x7A5494", Offset = "0x7A5494", VA = "0x7A5494")]
		public void SetFloat(string propertyName, float value)
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x7A6CB4", Offset = "0x7A6CB4", VA = "0x7A6CB4")]
		public void SetInt(string propertyName, int value)
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x7A50F0", Offset = "0x7A50F0", VA = "0x7A50F0")]
		public void SetVector(string propertyName, Vector3 value)
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x7A4C7C", Offset = "0x7A4C7C", VA = "0x7A4C7C")]
		public void Replace(Material mfxMaterialTemplate)
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x7A4E38", Offset = "0x7A4E38", VA = "0x7A4E38")]
		public void Revert()
		{
		}
	}
	[Token(Token = "0x2000151")]
	public enum MfxShaderType
	{
		[Token(Token = "0x40006E0")]
		Standard,
		[Token(Token = "0x40006E1")]
		StandardSpecular,
		[Token(Token = "0x40006E2")]
		StandardTransparent,
		[Token(Token = "0x40006E3")]
		Unlit
	}
	[Token(Token = "0x2000152")]
	public class SpiritMaterializer : MonoBehaviour
	{
		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject spirit;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject initialSpirit;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 spiritStartPos;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private MfxActivator activator;

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x7A6E08", Offset = "0x7A6E08", VA = "0x7A6E08")]
		private void Start()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x7A6E68", Offset = "0x7A6E68", VA = "0x7A6E68")]
		private void Update()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x7A6E6C", Offset = "0x7A6E6C", VA = "0x7A6E6C")]
		public void StartMaterialization()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x7A6F88", Offset = "0x7A6F88", VA = "0x7A6F88")]
		public SpiritMaterializer()
		{
		}
	}
}
namespace Assets.MaterializeFX
{
	[Token(Token = "0x2000153")]
	public class SimpleFpsController : MonoBehaviour
	{
		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly float lookSensitivity;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly float _lookSmoothnes;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float _yRotation;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float _xRotation;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _currentXRotation;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _currentYRotation;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _yRotationV;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _xRotationV;

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x7A6F90", Offset = "0x7A6F90", VA = "0x7A6F90")]
		private void Update()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x7A710C", Offset = "0x7A710C", VA = "0x7A710C")]
		public SimpleFpsController()
		{
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x2000154")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x7A7120", Offset = "0x7A7120", VA = "0x7A7120")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x7A72D4", Offset = "0x7A72D4", VA = "0x7A72D4")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x7A7460", Offset = "0x7A7460", VA = "0x7A7460")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x7A7600", Offset = "0x7A7600", VA = "0x7A7600")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x7A7668", Offset = "0x7A7668", VA = "0x7A7668")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x7A76D0", Offset = "0x7A76D0", VA = "0x7A76D0")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x7A7728", Offset = "0x7A7728", VA = "0x7A7728")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x7A77A0", Offset = "0x7A77A0", VA = "0x7A77A0")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x7A77F8", Offset = "0x7A77F8", VA = "0x7A77F8")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x7A7850", Offset = "0x7A7850", VA = "0x7A7850")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x7A78A8", Offset = "0x7A78A8", VA = "0x7A78A8")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x7A7900", Offset = "0x7A7900", VA = "0x7A7900")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x7A7960", Offset = "0x7A7960", VA = "0x7A7960")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x7A79BC", Offset = "0x7A79BC", VA = "0x7A79BC")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x7A7A14", Offset = "0x7A7A14", VA = "0x7A7A14")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000158")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x7A7B34", Offset = "0x7A7B34", VA = "0x7A7B34")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x7A7CEC", Offset = "0x7A7CEC", VA = "0x7A7CEC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x7A7E98", Offset = "0x7A7E98", VA = "0x7A7E98")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x7A8044", Offset = "0x7A8044", VA = "0x7A8044")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x7A81F0", Offset = "0x7A81F0", VA = "0x7A81F0")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x7A83A4", Offset = "0x7A83A4", VA = "0x7A83A4")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x7A860C", Offset = "0x7A860C", VA = "0x7A860C")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x7A8B18", Offset = "0x7A8B18", VA = "0x7A8B18")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x7A8D8C", Offset = "0x7A8D8C", VA = "0x7A8D8C")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x7A9020", Offset = "0x7A9020", VA = "0x7A9020")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x7A91F4", Offset = "0x7A91F4", VA = "0x7A91F4")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x2000164")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x7A9808", Offset = "0x7A9808", VA = "0x7A9808")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x7A99B8", Offset = "0x7A99B8", VA = "0x7A99B8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x7A9B60", Offset = "0x7A9B60", VA = "0x7A9B60")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x7A9D08", Offset = "0x7A9D08", VA = "0x7A9D08")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x7A9E98", Offset = "0x7A9E98", VA = "0x7A9E98")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}
	}
	[Token(Token = "0x200016A")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x6000733")]
		[Address(RVA = "0x7AA480", Offset = "0x7AA480", VA = "0x7AA480")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x7AA634", Offset = "0x7AA634", VA = "0x7AA634")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x7AA7C0", Offset = "0x7AA7C0", VA = "0x7AA7C0")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x7AA99C", Offset = "0x7AA99C", VA = "0x7AA99C")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x200016E")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x200016F")]
		public static class Utils
		{
			[Token(Token = "0x6000768")]
			[Address(RVA = "0x7AF364", Offset = "0x7AF364", VA = "0x7AF364")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x7AAC94", Offset = "0x7AAC94", VA = "0x7AAC94")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x7AAE20", Offset = "0x7AAE20", VA = "0x7AAE20")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x7AAFD4", Offset = "0x7AAFD4", VA = "0x7AAFD4")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x7AB160", Offset = "0x7AB160", VA = "0x7AB160")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x7AB314", Offset = "0x7AB314", VA = "0x7AB314")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x7AB4A0", Offset = "0x7AB4A0", VA = "0x7AB4A0")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x7AB650", Offset = "0x7AB650", VA = "0x7AB650")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x7AB834", Offset = "0x7AB834", VA = "0x7AB834")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x7AB9E0", Offset = "0x7AB9E0", VA = "0x7AB9E0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x7ABB8C", Offset = "0x7ABB8C", VA = "0x7ABB8C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x7ABD38", Offset = "0x7ABD38", VA = "0x7ABD38")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x7ABEEC", Offset = "0x7ABEEC", VA = "0x7ABEEC")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x7AC078", Offset = "0x7AC078", VA = "0x7AC078")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x7AC214", Offset = "0x7AC214", VA = "0x7AC214")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x7AC3C0", Offset = "0x7AC3C0", VA = "0x7AC3C0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x7AC564", Offset = "0x7AC564", VA = "0x7AC564")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x7AC708", Offset = "0x7AC708", VA = "0x7AC708")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x7AC8BC", Offset = "0x7AC8BC", VA = "0x7AC8BC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x7ACA64", Offset = "0x7ACA64", VA = "0x7ACA64")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x7ACC0C", Offset = "0x7ACC0C", VA = "0x7ACC0C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x7ACDB4", Offset = "0x7ACDB4", VA = "0x7ACDB4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x7ACF60", Offset = "0x7ACF60", VA = "0x7ACF60")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x7AD10C", Offset = "0x7AD10C", VA = "0x7AD10C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x7AD2A8", Offset = "0x7AD2A8", VA = "0x7AD2A8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x7AD448", Offset = "0x7AD448", VA = "0x7AD448")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x7AD5E8", Offset = "0x7AD5E8", VA = "0x7AD5E8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x7AD794", Offset = "0x7AD794", VA = "0x7AD794")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x7AD950", Offset = "0x7AD950", VA = "0x7AD950")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x7ADB34", Offset = "0x7ADB34", VA = "0x7ADB34")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x7ADD20", Offset = "0x7ADD20", VA = "0x7ADD20")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x7AE148", Offset = "0x7AE148", VA = "0x7AE148")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x7AE2E8", Offset = "0x7AE2E8", VA = "0x7AE2E8")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x7AE478", Offset = "0x7AE478", VA = "0x7AE478")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x7AE608", Offset = "0x7AE608", VA = "0x7AE608")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x7AE7A4", Offset = "0x7AE7A4", VA = "0x7AE7A4")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x7AE958", Offset = "0x7AE958", VA = "0x7AE958")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x7AEAE4", Offset = "0x7AEAE4", VA = "0x7AEAE4")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x7AED1C", Offset = "0x7AED1C", VA = "0x7AED1C")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x7AEF34", Offset = "0x7AEF34", VA = "0x7AEF34")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x7AF14C", Offset = "0x7AF14C", VA = "0x7AF14C")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000197")]
	public static class DOTweenModuleUnityVersion
	{
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x7B0254", Offset = "0x7B0254", VA = "0x7B0254")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x7B0434", Offset = "0x7B0434", VA = "0x7B0434")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x7B0620", Offset = "0x7B0620", VA = "0x7B0620")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x7B071C", Offset = "0x7B071C", VA = "0x7B071C")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x7B0818", Offset = "0x7B0818", VA = "0x7B0818")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x7B0914", Offset = "0x7B0914", VA = "0x7B0914")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x7B0A24", Offset = "0x7B0A24", VA = "0x7B0A24")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x7B0B44", Offset = "0x7B0B44", VA = "0x7B0B44")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x7B0C40", Offset = "0x7B0C40", VA = "0x7B0C40")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x7B0E4C", Offset = "0x7B0E4C", VA = "0x7B0E4C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x200019A")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x200019B")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000CF")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60007F2")]
				[Address(RVA = "0x7B10E8", Offset = "0x7B10E8", VA = "0x7B10E8", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x7B06EC", Offset = "0x7B06EC", VA = "0x7B06EC")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x200019C")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000D0")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60007F4")]
				[Address(RVA = "0x7B1118", Offset = "0x7B1118", VA = "0x7B1118", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x7B07E8", Offset = "0x7B07E8", VA = "0x7B07E8")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x200019D")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000D1")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60007F6")]
				[Address(RVA = "0x7B1178", Offset = "0x7B1178", VA = "0x7B1178", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x7B08E4", Offset = "0x7B08E4", VA = "0x7B08E4")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x200019E")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x170000D2")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60007F8")]
				[Address(RVA = "0x7B1194", Offset = "0x7B1194", VA = "0x7B1194", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x7B09E8", Offset = "0x7B09E8", VA = "0x7B09E8")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x200019F")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x170000D3")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60007FA")]
				[Address(RVA = "0x7B11D4", Offset = "0x7B11D4", VA = "0x7B11D4", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x7B0B00", Offset = "0x7B0B00", VA = "0x7B0B00")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x20001A0")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000D4")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60007FC")]
				[Address(RVA = "0x7B122C", Offset = "0x7B122C", VA = "0x7B122C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x7B0C10", Offset = "0x7B0C10", VA = "0x7B0C10")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x20001A1")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x20001A2")]
		public static class Physics
		{
			[Token(Token = "0x6000800")]
			[Address(RVA = "0x7B13BC", Offset = "0x7B13BC", VA = "0x7B13BC")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x6000801")]
			[Address(RVA = "0x7B14BC", Offset = "0x7B14BC", VA = "0x7B14BC")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000802")]
			[Address(RVA = "0x7B1548", Offset = "0x7B1548", VA = "0x7B1548")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000803")]
			[Address(RVA = "0x7B15D4", Offset = "0x7B15D4", VA = "0x7B15D4")]
			[Preserve]
			public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x7B1260", Offset = "0x7B1260", VA = "0x7B1260")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x7B1314", Offset = "0x7B1314", VA = "0x7B1314")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
}
namespace CurvedUI
{
	[Token(Token = "0x20001A3")]
	public class CurvedUIEventSystem : EventSystem
	{
		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static CurvedUIEventSystem instance;

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x7B1718", Offset = "0x7B1718", VA = "0x7B1718", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x7B177C", Offset = "0x7B177C", VA = "0x7B177C", Slot = "17")]
		protected override void OnApplicationFocus(bool hasFocus)
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x7B1788", Offset = "0x7B1788", VA = "0x7B1788")]
		public CurvedUIEventSystem()
		{
		}
	}
	[Token(Token = "0x20001A4")]
	public static class CurvedUIExtensionMethods
	{
		[Token(Token = "0x6000807")]
		[Address(RVA = "0x7B17E0", Offset = "0x7B17E0", VA = "0x7B17E0")]
		public static bool AlmostEqual(this Vector3 a, Vector3 b, double accuracy = 0.01)
		{
			return default(bool);
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x7B1810", Offset = "0x7B1810", VA = "0x7B1810")]
		public static float Remap(this float value, float from1, float to1, float from2, float to2)
		{
			return default(float);
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x7B182C", Offset = "0x7B182C", VA = "0x7B182C")]
		public static float RemapAndClamp(this float value, float from1, float to1, float from2, float to2)
		{
			return default(float);
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x7B186C", Offset = "0x7B186C", VA = "0x7B186C")]
		public static float Remap(this int value, float from1, float to1, float from2, float to2)
		{
			return default(float);
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x7B188C", Offset = "0x7B188C", VA = "0x7B188C")]
		public static double Remap(this double value, double from1, double to1, double from2, double to2)
		{
			return default(double);
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x7B1858", Offset = "0x7B1858", VA = "0x7B1858")]
		public static float Clamp(this float value, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x7B18A8", Offset = "0x7B18A8", VA = "0x7B18A8")]
		public static float Clamp(this int value, int min, int max)
		{
			return default(float);
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x7B18C0", Offset = "0x7B18C0", VA = "0x7B18C0")]
		public static int Abs(this int value)
		{
			return default(int);
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x7B1918", Offset = "0x7B1918", VA = "0x7B1918")]
		public static float Abs(this float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x7B1920", Offset = "0x7B1920", VA = "0x7B1920")]
		public static int ToInt(this float value)
		{
			return default(int);
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x7B19FC", Offset = "0x7B19FC", VA = "0x7B19FC")]
		public static int FloorToInt(this float value)
		{
			return default(int);
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x7B1A68", Offset = "0x7B1A68", VA = "0x7B1A68")]
		public static int CeilToInt(this float value)
		{
			return default(int);
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x7B1AD4", Offset = "0x7B1AD4", VA = "0x7B1AD4")]
		public static Vector3 ModifyX(this Vector3 trans, float newVal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x7B1ADC", Offset = "0x7B1ADC", VA = "0x7B1ADC")]
		public static Vector3 ModifyY(this Vector3 trans, float newVal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x7B1AE4", Offset = "0x7B1AE4", VA = "0x7B1AE4")]
		public static Vector3 ModifyZ(this Vector3 trans, float newVal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x7B1AEC", Offset = "0x7B1AEC", VA = "0x7B1AEC")]
		public static Vector2 ModifyVectorX(this Vector2 trans, float newVal)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x7B1AF4", Offset = "0x7B1AF4", VA = "0x7B1AF4")]
		public static Vector2 ModifyVectorY(this Vector2 trans, float newVal)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x7B1AFC", Offset = "0x7B1AFC", VA = "0x7B1AFC")]
		public static void ResetTransform(this Transform trans)
		{
		}

		[Token(Token = "0x6000819")]
		public static T AddComponentIfMissing<T>(this GameObject go) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600081A")]
		public static T AddComponentIfMissing<T>(this Component go) where T : Component
		{
			return null;
		}
	}
	[Token(Token = "0x20001A5")]
	public class CurvedUIHandSwitcher : MonoBehaviour
	{
		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject LaserBeam;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("If true, when player clicks the trigger on the other hand, we'll instantly set it as UI controlling hand and move the pointer to it.")]
		private bool autoSwitchHands;

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x7B1BDC", Offset = "0x7B1BDC", VA = "0x7B1BDC")]
		private void SwitchHandTo(CurvedUIInputModule.Hand newHand)
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x7B1DD4", Offset = "0x7B1DD4", VA = "0x7B1DD4")]
		public CurvedUIHandSwitcher()
		{
		}
	}
	[Token(Token = "0x20001A6")]
	public class CurvedUIInputFieldCaret : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
	{
		[Token(Token = "0x20001A7")]
		[CompilerGenerated]
		private sealed class <CaretBlinker>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CurvedUIInputFieldCaret <>4__this;

			[Token(Token = "0x170000D8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600082F")]
				[Address(RVA = "0x7B29B4", Offset = "0x7B29B4", VA = "0x7B29B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000831")]
				[Address(RVA = "0x7B29FC", Offset = "0x7B29FC", VA = "0x7B29FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600082C")]
			[Address(RVA = "0x7B25A4", Offset = "0x7B25A4", VA = "0x7B25A4")]
			[DebuggerHidden]
			public <CaretBlinker>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x600082D")]
			[Address(RVA = "0x7B2898", Offset = "0x7B2898", VA = "0x7B2898", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600082E")]
			[Address(RVA = "0x7B289C", Offset = "0x7B289C", VA = "0x7B289C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000830")]
			[Address(RVA = "0x7B29BC", Offset = "0x7B29BC", VA = "0x7B29BC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private InputField myField;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform myCaret;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color origCaretColor;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color origSelectionColor;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool selected;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool selectingText;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int lastCharDist;

		[Token(Token = "0x170000D5")]
		public Color CaretColor
		{
			[Token(Token = "0x6000825")]
			[Address(RVA = "0x7B2820", Offset = "0x7B2820", VA = "0x7B2820")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000826")]
			[Address(RVA = "0x7B282C", Offset = "0x7B282C", VA = "0x7B282C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D6")]
		public Color SelectionColor
		{
			[Token(Token = "0x6000827")]
			[Address(RVA = "0x7B2838", Offset = "0x7B2838", VA = "0x7B2838")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000828")]
			[Address(RVA = "0x7B2844", Offset = "0x7B2844", VA = "0x7B2844")]
			set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public float CaretBlinkRate
		{
			[Token(Token = "0x6000829")]
			[Address(RVA = "0x7B2850", Offset = "0x7B2850", VA = "0x7B2850")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600082A")]
			[Address(RVA = "0x7B286C", Offset = "0x7B286C", VA = "0x7B286C")]
			set
			{
			}
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x7B1DE4", Offset = "0x7B1DE4", VA = "0x7B1DE4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x7B1E3C", Offset = "0x7B1E3C", VA = "0x7B1E3C")]
		private void Update()
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x7B2100", Offset = "0x7B2100", VA = "0x7B2100", Slot = "4")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x7B2570", Offset = "0x7B2570", VA = "0x7B2570", Slot = "5")]
		public void OnDeselect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x7B24FC", Offset = "0x7B24FC", VA = "0x7B24FC")]
		[IteratorStateMachine(typeof(<CaretBlinker>d__11))]
		private IEnumerator CaretBlinker()
		{
			return null;
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x7B21B0", Offset = "0x7B21B0", VA = "0x7B21B0")]
		private void CreateCaret()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x7B1E4C", Offset = "0x7B1E4C", VA = "0x7B1E4C")]
		private void UpdateCaret()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x7B25CC", Offset = "0x7B25CC", VA = "0x7B25CC")]
		private Vector2 GetLocalPositionInText(int charNo)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x7B2888", Offset = "0x7B2888", VA = "0x7B2888")]
		public CurvedUIInputFieldCaret()
		{
		}
	}
	[Token(Token = "0x20001A8")]
	public class CurvedUILaserBeam : MonoBehaviour
	{
		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform LaserBeamTransform;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform LaserBeamDot;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool CollideWithMyLayerOnly;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool hideWhenNotAimingAtCanvas;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MeshRenderer m_BeamDotRenderer;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MeshRenderer m_BeamRenderer;

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x7B2A04", Offset = "0x7B2A04", VA = "0x7B2A04")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x7B2A64", Offset = "0x7B2A64", VA = "0x7B2A64")]
		protected void Update()
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x7B2F38", Offset = "0x7B2F38", VA = "0x7B2F38")]
		public CurvedUILaserBeam()
		{
		}
	}
	[Token(Token = "0x20001AA")]
	public class CurvedUIPhysicsRaycaster : BaseRaycaster
	{
		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected LayerMask eventMask;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected int sortOrder;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RaycastHit hitInfo;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RaycastResult result;

		[Token(Token = "0x170000DA")]
		public int CompoundEventMask
		{
			[Token(Token = "0x600083A")]
			[Address(RVA = "0x7B3410", Offset = "0x7B3410", VA = "0x7B3410")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000DB")]
		public LayerMask EventMask
		{
			[Token(Token = "0x600083B")]
			[Address(RVA = "0x7B34D4", Offset = "0x7B34D4", VA = "0x7B34D4")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x600083C")]
			[Address(RVA = "0x7B34DC", Offset = "0x7B34DC", VA = "0x7B34DC")]
			set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public override Camera eventCamera
		{
			[Token(Token = "0x600083D")]
			[Address(RVA = "0x7B34E4", Offset = "0x7B34E4", VA = "0x7B34E4", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DD")]
		public virtual int Depth
		{
			[Token(Token = "0x600083E")]
			[Address(RVA = "0x7B35A0", Offset = "0x7B35A0", VA = "0x7B35A0", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000DE")]
		public override int sortOrderPriority
		{
			[Token(Token = "0x600083F")]
			[Address(RVA = "0x7B3664", Offset = "0x7B3664", VA = "0x7B3664", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x7B3098", Offset = "0x7B3098", VA = "0x7B3098")]
		protected CurvedUIPhysicsRaycaster()
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x7B30C4", Offset = "0x7B30C4", VA = "0x7B30C4", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}
	}
	[Token(Token = "0x20001AB")]
	public class CurvedUIPointerEventData : PointerEventData
	{
		[Token(Token = "0x20001AC")]
		public enum ControllerType
		{
			[Token(Token = "0x400076E")]
			NONE = -1,
			[Token(Token = "0x400076F")]
			VIVE
		}

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public GameObject Controller;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public Vector2 TouchPadAxis;

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x7B366C", Offset = "0x7B366C", VA = "0x7B366C")]
		public CurvedUIPointerEventData(EventSystem eventSystem)
		{
		}
	}
	[Token(Token = "0x20001AD")]
	public class CurvedUIRaycaster : GraphicRaycaster
	{
		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool showDebug;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool overrideEventData;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Canvas myCanvas;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 cyllinderMidPoint;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<GameObject> objectsUnderPointer;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector2 lastCanvasPos;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject colliderContainer;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private PointerEventData lastFrameEventData;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private PointerEventData curEventData;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private PointerEventData eventDataToUse;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Ray cachedRay;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Graphic gph;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<GameObject> selectablesUnderGaze;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<GameObject> selectablesUnderGazeLastFrame;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float objectsUnderGazeLastChangeTime;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private bool gazeClickExecuted;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		private bool pointingAtCanvas;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCE")]
		private bool pointingAtCanvasLastFrame;

		[NonSerialized]
		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private List<Graphic> m_RaycastResults;

		[NonSerialized]
		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<Graphic> s_SortedGraphics;

		[Token(Token = "0x170000DF")]
		private Image GazeProgressImage
		{
			[Token(Token = "0x6000854")]
			[Address(RVA = "0x7B448C", Offset = "0x7B448C", VA = "0x7B448C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E0")]
		public bool PointingAtCanvas
		{
			[Token(Token = "0x600085D")]
			[Address(RVA = "0x7BB364", Offset = "0x7BB364", VA = "0x7BB364")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x7B36CC", Offset = "0x7B36CC", VA = "0x7B36CC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x7B37D8", Offset = "0x7B37D8", VA = "0x7B37D8", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x7B3F0C", Offset = "0x7B3F0C", VA = "0x7B3F0C", Slot = "22")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x7B42F0", Offset = "0x7B42F0", VA = "0x7B42F0")]
		private void ProcessGazeTimedClick()
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x7B42D0", Offset = "0x7B42D0", VA = "0x7B42D0")]
		private void ResetGazeTimedClick()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x7B49F4", Offset = "0x7B49F4", VA = "0x7B49F4", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x7B5C90", Offset = "0x7B5C90", VA = "0x7B5C90", Slot = "23")]
		public virtual bool RaycastToCyllinderCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x7B642C", Offset = "0x7B642C", VA = "0x7B642C", Slot = "24")]
		public virtual bool RaycastToCyllinderVerticalCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x7B6B04", Offset = "0x7B6B04", VA = "0x7B6B04", Slot = "25")]
		public virtual bool RaycastToRingCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x7B7104", Offset = "0x7B7104", VA = "0x7B7104", Slot = "26")]
		public virtual bool RaycastToSphereCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x7B567C", Offset = "0x7B567C", VA = "0x7B567C")]
		private void FlatRaycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x7B7C98", Offset = "0x7B7C98", VA = "0x7B7C98")]
		private static void FlatRaycastAndSort(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results)
		{
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x7B3A28", Offset = "0x7B3A28", VA = "0x7B3A28")]
		protected void CreateCollider()
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x7B9C94", Offset = "0x7B9C94", VA = "0x7B9C94")]
		private void SetupMeshColliderUsingMesh(Mesh meshie)
		{
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x7B820C", Offset = "0x7B820C", VA = "0x7B820C")]
		private GameObject CreateConvexCyllinderCollider(bool vertical = false)
		{
			return null;
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x7B8EA4", Offset = "0x7B8EA4", VA = "0x7B8EA4")]
		private Mesh CreateCyllinderColliderMesh(bool vertical = false)
		{
			return null;
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x7B9D48", Offset = "0x7B9D48", VA = "0x7B9D48")]
		private Mesh CreateSphereColliderMesh()
		{
			return null;
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x7BAA48", Offset = "0x7BAA48", VA = "0x7BAA48")]
		private bool IsInLayerMask(int layer, LayerMask layermask)
		{
			return default(bool);
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x7B636C", Offset = "0x7B636C", VA = "0x7B636C")]
		private LayerMask GetLayerMaskForMyLayer()
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x7B63BC", Offset = "0x7B63BC", VA = "0x7B63BC")]
		private float AngleSigned(Vector3 v1, Vector3 v2, Vector3 n)
		{
			return default(float);
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x7BAA94", Offset = "0x7BAA94", VA = "0x7BAA94")]
		private bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			return default(bool);
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x7BAAC4", Offset = "0x7BAAC4", VA = "0x7BAAC4", Slot = "27")]
		protected virtual void ProcessMove(PointerEventData pointerEvent)
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x7B513C", Offset = "0x7B513C", VA = "0x7B513C")]
		protected void UpdateSelectedObjects(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x7BAADC", Offset = "0x7BAADC", VA = "0x7BAADC")]
		protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget)
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x7BB0B0", Offset = "0x7BB0B0", VA = "0x7BB0B0")]
		protected static GameObject FindCommonRoot(GameObject g1, GameObject g2)
		{
			return null;
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x7BB224", Offset = "0x7BB224", VA = "0x7BB224")]
		private bool GetScreenSpacePointByRay(Ray ray, out Vector2 o_positionOnCanvas)
		{
			return default(bool);
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x7B3858", Offset = "0x7B3858", VA = "0x7B3858")]
		private bool CheckEventCamera()
		{
			return default(bool);
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x7BB36C", Offset = "0x7BB36C", VA = "0x7BB36C")]
		public void RebuildCollider()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x7BB3A0", Offset = "0x7BB3A0", VA = "0x7BB3A0")]
		public List<GameObject> GetObjectsUnderPointer()
		{
			return null;
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x7BB42C", Offset = "0x7BB42C", VA = "0x7BB42C")]
		public List<GameObject> GetObjectsUnderScreenPos(Vector2 screenPos, [Optional] Camera eventCamera)
		{
			return null;
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x7BB508", Offset = "0x7BB508", VA = "0x7BB508")]
		public List<GameObject> GetObjectsHitByRay(Ray ray)
		{
			return null;
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x7B44EC", Offset = "0x7B44EC", VA = "0x7B44EC")]
		public void Click()
		{
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x7BA504", Offset = "0x7BA504", VA = "0x7BA504")]
		private void ModifyQuad(List<Vector3> verts, int vertexIndex, Vector2 requiredSize)
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x7BBA6C", Offset = "0x7BBA6C", VA = "0x7BBA6C")]
		private Vector3 TesselateQuad(List<Vector3> quad, float x, float y)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x7BBD60", Offset = "0x7BBD60", VA = "0x7BBD60")]
		public CurvedUIRaycaster()
		{
		}
	}
	[Token(Token = "0x20001AF")]
	[AddComponentMenu("CurvedUI/CurvedUISettings")]
	[RequireComponent(typeof(Canvas))]
	public class CurvedUISettings : MonoBehaviour
	{
		[Token(Token = "0x20001B0")]
		public enum CurvedUIShape
		{
			[Token(Token = "0x400079C")]
			CYLINDER,
			[Token(Token = "0x400079D")]
			RING,
			[Token(Token = "0x400079E")]
			SPHERE,
			[Token(Token = "0x400079F")]
			CYLINDER_VERTICAL
		}

		[Token(Token = "0x4000789")]
		public const string Version = "3.0";

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CurvedUIShape shape;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float quality;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool interactable;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool blocksRaycasts;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		[SerializeField]
		private bool raycastMyLayerOnly;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		[SerializeField]
		private bool forceUseBoxCollider;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int angle;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool preserveAspect;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int vertAngle;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float ringFill;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int ringExternalDiamater;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool ringFlipVertical;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int baseCircleSegments;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector2 savedRectSize;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float savedRadius;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Canvas myCanvas;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform m_rectTransform;

		[Token(Token = "0x170000E1")]
		private RectTransform RectTransform
		{
			[Token(Token = "0x6000876")]
			[Address(RVA = "0x7BC1F0", Offset = "0x7BC1F0", VA = "0x7BC1F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E2")]
		public int BaseCircleSegments
		{
			[Token(Token = "0x600087F")]
			[Address(RVA = "0x7BDC3C", Offset = "0x7BDC3C", VA = "0x7BDC3C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E3")]
		public int Angle
		{
			[Token(Token = "0x6000880")]
			[Address(RVA = "0x7BDC44", Offset = "0x7BDC44", VA = "0x7BDC44")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000881")]
			[Address(RVA = "0x7BDC4C", Offset = "0x7BDC4C", VA = "0x7BDC4C")]
			set
			{
			}
		}

		[Token(Token = "0x170000E4")]
		public float Quality
		{
			[Token(Token = "0x6000882")]
			[Address(RVA = "0x7BDC60", Offset = "0x7BDC60", VA = "0x7BDC60")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000883")]
			[Address(RVA = "0x7BDC68", Offset = "0x7BDC68", VA = "0x7BDC68")]
			set
			{
			}
		}

		[Token(Token = "0x170000E5")]
		public CurvedUIShape Shape
		{
			[Token(Token = "0x6000884")]
			[Address(RVA = "0x7BDC84", Offset = "0x7BDC84", VA = "0x7BDC84")]
			get
			{
				return default(CurvedUIShape);
			}
			[Token(Token = "0x6000885")]
			[Address(RVA = "0x7BDC8C", Offset = "0x7BDC8C", VA = "0x7BDC8C")]
			set
			{
			}
		}

		[Token(Token = "0x170000E6")]
		public int VerticalAngle
		{
			[Token(Token = "0x6000886")]
			[Address(RVA = "0x7BDCAC", Offset = "0x7BDCAC", VA = "0x7BDCAC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000887")]
			[Address(RVA = "0x7BDCB4", Offset = "0x7BDCB4", VA = "0x7BDCB4")]
			set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public float RingFill
		{
			[Token(Token = "0x6000888")]
			[Address(RVA = "0x7BDCD4", Offset = "0x7BDCD4", VA = "0x7BDCD4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000889")]
			[Address(RVA = "0x7BDCDC", Offset = "0x7BDCDC", VA = "0x7BDCDC")]
			set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		public float SavedRadius
		{
			[Token(Token = "0x600088A")]
			[Address(RVA = "0x7BCCD4", Offset = "0x7BCCD4", VA = "0x7BCCD4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000E9")]
		public int RingExternalDiameter
		{
			[Token(Token = "0x600088B")]
			[Address(RVA = "0x7BDCF8", Offset = "0x7BDCF8", VA = "0x7BDCF8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600088C")]
			[Address(RVA = "0x7BDD00", Offset = "0x7BDD00", VA = "0x7BDD00")]
			set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		public bool RingFlipVertical
		{
			[Token(Token = "0x600088D")]
			[Address(RVA = "0x7BDD20", Offset = "0x7BDD20", VA = "0x7BDD20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600088E")]
			[Address(RVA = "0x7BDD28", Offset = "0x7BDD28", VA = "0x7BDD28")]
			set
			{
			}
		}

		[Token(Token = "0x170000EB")]
		public bool PreserveAspect
		{
			[Token(Token = "0x600088F")]
			[Address(RVA = "0x7BDD48", Offset = "0x7BDD48", VA = "0x7BDD48")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000890")]
			[Address(RVA = "0x7BDD50", Offset = "0x7BDD50", VA = "0x7BDD50")]
			set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public bool Interactable
		{
			[Token(Token = "0x6000891")]
			[Address(RVA = "0x7BDD70", Offset = "0x7BDD70", VA = "0x7BDD70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000892")]
			[Address(RVA = "0x7BDD78", Offset = "0x7BDD78", VA = "0x7BDD78")]
			set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		public bool ForceUseBoxCollider
		{
			[Token(Token = "0x6000893")]
			[Address(RVA = "0x7BDD84", Offset = "0x7BDD84", VA = "0x7BDD84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000894")]
			[Address(RVA = "0x7BDD8C", Offset = "0x7BDD8C", VA = "0x7BDD8C")]
			set
			{
			}
		}

		[Token(Token = "0x170000EE")]
		public bool BlocksRaycasts
		{
			[Token(Token = "0x6000895")]
			[Address(RVA = "0x7BDD98", Offset = "0x7BDD98", VA = "0x7BDD98")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000896")]
			[Address(RVA = "0x7BDDA0", Offset = "0x7BDDA0", VA = "0x7BDDA0")]
			set
			{
			}
		}

		[Token(Token = "0x170000EF")]
		public bool RaycastMyLayerOnly
		{
			[Token(Token = "0x6000897")]
			[Address(RVA = "0x7BDE70", Offset = "0x7BDE70", VA = "0x7BDE70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000898")]
			[Address(RVA = "0x7BDE78", Offset = "0x7BDE78", VA = "0x7BDE78")]
			set
			{
			}
		}

		[Token(Token = "0x170000F0")]
		public bool PointingAtCanvas
		{
			[Token(Token = "0x600089A")]
			[Address(RVA = "0x7BDF20", Offset = "0x7BDF20", VA = "0x7BDF20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F1")]
		public CurvedUIInputModule.CUIControlMethod ControlMethod
		{
			[Token(Token = "0x600089C")]
			[Address(RVA = "0x7BE0DC", Offset = "0x7BE0DC", VA = "0x7BE0DC")]
			get
			{
				return default(CurvedUIInputModule.CUIControlMethod);
			}
			[Token(Token = "0x600089D")]
			[Address(RVA = "0x7BE12C", Offset = "0x7BE12C", VA = "0x7BE12C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public bool GazeUseTimedClick
		{
			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x7BE50C", Offset = "0x7BE50C", VA = "0x7BE50C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x7BE56C", Offset = "0x7BE56C", VA = "0x7BE56C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		public float GazeClickTimer
		{
			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x7BE5D4", Offset = "0x7BE5D4", VA = "0x7BE5D4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x7BE634", Offset = "0x7BE634", VA = "0x7BE634")]
			set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		public float GazeClickTimerDelay
		{
			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x7BE6A4", Offset = "0x7BE6A4", VA = "0x7BE6A4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x7BE704", Offset = "0x7BE704", VA = "0x7BE704")]
			set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public float GazeTimerProgress
		{
			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x7BE774", Offset = "0x7BE774", VA = "0x7BE774")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x7BC164", Offset = "0x7BC164", VA = "0x7BC164")]
		private void Awake()
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x7BC2C0", Offset = "0x7BC2C0", VA = "0x7BC2C0")]
		private void Start()
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x7BC780", Offset = "0x7BC780", VA = "0x7BC780")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x7BC820", Offset = "0x7BC820", VA = "0x7BC820")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x7BC8C0", Offset = "0x7BC8C0", VA = "0x7BC8C0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x7BC9E0", Offset = "0x7BC9E0", VA = "0x7BC9E0")]
		private void SetUIAngle(int newAngle)
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x7BCBFC", Offset = "0x7BCBFC", VA = "0x7BCBFC")]
		private Vector3 CanvasToCyllinder(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x7BCCF8", Offset = "0x7BCCF8", VA = "0x7BCCF8")]
		private Vector3 CanvasToCyllinderVertical(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x7BCDD0", Offset = "0x7BCDD0", VA = "0x7BCDD0")]
		private Vector3 CanvasToRing(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x7BCEB0", Offset = "0x7BCEB0", VA = "0x7BCEB0")]
		private Vector3 CanvasToSphere(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x7BD060", Offset = "0x7BD060", VA = "0x7BD060")]
		public void AddEffectToChildren()
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x7BD3EC", Offset = "0x7BD3EC", VA = "0x7BD3EC")]
		public Vector3 VertexPositionToCurvedCanvas(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x7BD474", Offset = "0x7BD474", VA = "0x7BD474")]
		public Vector3 CanvasToCurvedCanvas(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x7BD5DC", Offset = "0x7BD5DC", VA = "0x7BD5DC")]
		public Vector3 CanvasToCurvedCanvasNormal(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x7BD884", Offset = "0x7BD884", VA = "0x7BD884")]
		public bool RaycastToCanvasSpace(Ray ray, out Vector2 o_positionOnCanvas)
		{
			return default(bool);
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x7BC648", Offset = "0x7BC648", VA = "0x7BC648")]
		public float GetCyllinderRadiusInCanvasSpace()
		{
			return default(float);
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x7BDA38", Offset = "0x7BDA38", VA = "0x7BDA38")]
		public Vector2 GetTesslationSize(bool modifiedByQuality = true)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x7BDBA0", Offset = "0x7BDBA0", VA = "0x7BDBA0")]
		private float GetSegmentsByAngle(float angle)
		{
			return default(float);
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x7BDE84", Offset = "0x7BDE84", VA = "0x7BDE84")]
		public void SetAllChildrenDirty(bool recalculateCurveOnly = false)
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x7BE020", Offset = "0x7BE020", VA = "0x7BE020")]
		public void Click()
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x7BE184", Offset = "0x7BE184", VA = "0x7BE184")]
		public List<GameObject> GetObjectsUnderPointer()
		{
			return null;
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x7BE284", Offset = "0x7BE284", VA = "0x7BE284")]
		public List<GameObject> GetObjectsUnderScreenPos(Vector2 pos, [Optional] Camera eventCamera)
		{
			return null;
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x7BE3E0", Offset = "0x7BE3E0", VA = "0x7BE3E0")]
		public List<GameObject> GetObjectsHitByRay(Ray ray)
		{
			return null;
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x7BE7D4", Offset = "0x7BE7D4", VA = "0x7BE7D4")]
		public CurvedUISettings()
		{
		}
	}
	[Token(Token = "0x20001B1")]
	public class CurvedUIVertexEffect : BaseMeshEffect
	{
		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Check to skip tesselation pass on this object. CurvedUI will not create additional vertices to make this object have a smoother curve. Checking this can solve some issues if you create your own procedural mesh for this object. Default false.")]
		public bool DoNotTesselate;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Canvas myCanvas;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Graphic myGraphic;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Text myText;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI myTMP;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CurvedUITMPSubmesh myTMPSubMesh;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_tesselationRequired;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool curvingRequired;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool TransformMisaligned;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Matrix4x4 CanvasToWorld;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Matrix4x4 CanvasToLocal;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Matrix4x4 MyToWorld;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Matrix4x4 MyToLocal;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private List<UIVertex> m_tesselatedVerts;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private List<UIVertex> m_curvedVerts;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private List<UIVertex> m_vertsInQuads;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private UIVertex m_ret;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private UIVertex[] m_quad;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private float[] m_weights;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		[HideInInspector]
		private Vector3 savedPos;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		[HideInInspector]
		[SerializeField]
		private Vector3 savedUp;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		[SerializeField]
		[HideInInspector]
		private Vector2 savedRectSize;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		[HideInInspector]
		[SerializeField]
		private Color savedColor;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		[HideInInspector]
		[SerializeField]
		private Vector4 savedTextUV0;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		[HideInInspector]
		[SerializeField]
		private float savedFill;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
		private Vector4 _uv0;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24C")]
		private Vector4 _uv1;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
		private Vector3 _pos;

		[Token(Token = "0x170000F6")]
		private bool tesselationRequired
		{
			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x7BE81C", Offset = "0x7BE81C", VA = "0x7BE81C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x7BE824", Offset = "0x7BE824", VA = "0x7BE824")]
			set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public bool TesselationRequired
		{
			[Token(Token = "0x60008BD")]
			[Address(RVA = "0x7C1C78", Offset = "0x7C1C78", VA = "0x7C1C78")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x7C1C6C", Offset = "0x7C1C6C", VA = "0x7C1C6C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public bool CurvingRequired
		{
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x7C1C80", Offset = "0x7C1C80", VA = "0x7C1C80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x7C1C88", Offset = "0x7C1C88", VA = "0x7C1C88")]
			set
			{
			}
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x7BE830", Offset = "0x7BE830", VA = "0x7BE830", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x7BE934", Offset = "0x7BE934", VA = "0x7BE934", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x7BEC08", Offset = "0x7BEC08", VA = "0x7BEC08", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x7BF2B0", Offset = "0x7BF2B0", VA = "0x7BF2B0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x7BF448", Offset = "0x7BF448", VA = "0x7BF448")]
		private void TesselationRequiredCallback()
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x7BF454", Offset = "0x7BF454", VA = "0x7BF454")]
		private void FontTextureRebuiltCallback(Font fontie)
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x7BF4E0", Offset = "0x7BF4E0", VA = "0x7BF4E0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x7BFC08", Offset = "0x7BFC08", VA = "0x7BFC08", Slot = "20")]
		public override void ModifyMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x7C0BEC", Offset = "0x7C0BEC", VA = "0x7C0BEC")]
		public void ModifyTMPMesh(ref List<UIVertex> vertexList)
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x7C02E4", Offset = "0x7C02E4", VA = "0x7C02E4")]
		private bool ShouldModify()
		{
			return default(bool);
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x7C03C8", Offset = "0x7C03C8", VA = "0x7C03C8")]
		private void CheckTextFontMaterial()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x7BEAF0", Offset = "0x7BEAF0", VA = "0x7BEAF0")]
		public CurvedUISettings FindParentSettings(bool forceNew = false)
		{
			return null;
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x7C08DC", Offset = "0x7C08DC", VA = "0x7C08DC")]
		private UIVertex CurveVertex(UIVertex input, float cylinder_angle, float radius, Vector2 canvasSize)
		{
			return default(UIVertex);
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x7C065C", Offset = "0x7C065C", VA = "0x7C065C")]
		private void TesselateGeometry(List<UIVertex> verts)
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x7C12E0", Offset = "0x7C12E0", VA = "0x7C12E0")]
		private void ModifyQuad(List<UIVertex> verts, int vertexIndex, Vector2 requiredSize)
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x7C0EC8", Offset = "0x7C0EC8", VA = "0x7C0EC8")]
		private void TrisToQuads(List<UIVertex> verts)
		{
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x7C19EC", Offset = "0x7C19EC", VA = "0x7C19EC")]
		private UIVertex TesselateQuad(float x, float y)
		{
			return default(UIVertex);
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x7BCBF0", Offset = "0x7BCBF0", VA = "0x7BCBF0")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x7C1C94", Offset = "0x7C1C94", VA = "0x7C1C94")]
		public CurvedUIVertexEffect()
		{
		}
	}
	[Token(Token = "0x20001B2")]
	public class CurvedUIViveController : MonoBehaviour
	{
		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x7C1DDC", Offset = "0x7C1DDC", VA = "0x7C1DDC")]
		public CurvedUIViveController()
		{
		}
	}
	[Token(Token = "0x20001B3")]
	public struct ViveInputArgs
	{
		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint controllerIndex;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float buttonPressure;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector2 touchpadAxis;
	}
	[Token(Token = "0x20001B4")]
	public delegate void ViveInputEvent(object sender, ViveInputArgs e);
	[Token(Token = "0x20001B5")]
	public delegate void ViveEvent(object sender);
	[Token(Token = "0x20001B6")]
	[ExecuteInEditMode]
	public class CurvedUITMP : MonoBehaviour
	{
		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CurvedUIVertexEffect crvdVE;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextMeshProUGUI tmpText;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<UIVertex> m_UIVerts;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UIVertex m_tempVertex;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private CurvedUITMPSubmesh m_tempSubMsh;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector2 savedSize;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 savedUp;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Vector3 savedPos;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 savedLocalScale;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 savedGlobalScale;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private List<CurvedUITMPSubmesh> subMeshes;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public bool Dirty;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		private bool curvingRequired;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF2")]
		private bool tesselationRequired;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF3")]
		private bool quitting;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Vector3[] vertices;

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x7C2154", Offset = "0x7C2154", VA = "0x7C2154")]
		private void Start()
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x7C2204", Offset = "0x7C2204", VA = "0x7C2204")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x7C2528", Offset = "0x7C2528", VA = "0x7C2528")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x7C26A4", Offset = "0x7C26A4", VA = "0x7C26A4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x7C26B0", Offset = "0x7C26B0", VA = "0x7C26B0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x7C2E74", Offset = "0x7C2E74", VA = "0x7C2E74")]
		private void CreateUIVertexList(Mesh mesh)
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x7C3800", Offset = "0x7C3800", VA = "0x7C3800")]
		private void GetUIVertexFromMesh(ref UIVertex vert, int i)
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x7C313C", Offset = "0x7C313C", VA = "0x7C313C")]
		private void FillMeshWithUIVertexList(Mesh mesh, List<UIVertex> list)
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x7C23B8", Offset = "0x7C23B8", VA = "0x7C23B8")]
		private void FindTMP()
		{
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x7C329C", Offset = "0x7C329C", VA = "0x7C329C")]
		private void FindSubmeshes()
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x7C2B8C", Offset = "0x7C2B8C", VA = "0x7C2B8C")]
		private bool ShouldTesselate()
		{
			return default(bool);
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x7C3844", Offset = "0x7C3844", VA = "0x7C3844")]
		private void TMPTextChangedCallback(object obj)
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x7C3860", Offset = "0x7C3860", VA = "0x7C3860")]
		private void TesselationRequiredCallback()
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x7C386C", Offset = "0x7C386C", VA = "0x7C386C")]
		public CurvedUITMP()
		{
		}
	}
	[Token(Token = "0x20001B7")]
	[ExecuteInEditMode]
	public class CurvedUITMPInputFieldCaret : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
	{
		[Token(Token = "0x20001B8")]
		[CompilerGenerated]
		private sealed class <CaretBlinker>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CurvedUITMPInputFieldCaret <>4__this;

			[Token(Token = "0x170000FC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008EC")]
				[Address(RVA = "0x7C477C", Offset = "0x7C477C", VA = "0x7C477C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008EE")]
				[Address(RVA = "0x7C47C4", Offset = "0x7C47C4", VA = "0x7C47C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008E9")]
			[Address(RVA = "0x7C4520", Offset = "0x7C4520", VA = "0x7C4520")]
			[DebuggerHidden]
			public <CaretBlinker>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60008EA")]
			[Address(RVA = "0x7C4660", Offset = "0x7C4660", VA = "0x7C4660", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008EB")]
			[Address(RVA = "0x7C4664", Offset = "0x7C4664", VA = "0x7C4664", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008ED")]
			[Address(RVA = "0x7C4784", Offset = "0x7C4784", VA = "0x7C4784", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_InputField myField;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform myCaret;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color origCaretColor;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color origSelectionColor;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool selected;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool selectingText;

		[Token(Token = "0x170000F9")]
		public Color CaretColor
		{
			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x7C45F0", Offset = "0x7C45F0", VA = "0x7C45F0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60008E3")]
			[Address(RVA = "0x7C45FC", Offset = "0x7C45FC", VA = "0x7C45FC")]
			set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public Color SelectionColor
		{
			[Token(Token = "0x60008E4")]
			[Address(RVA = "0x7C4608", Offset = "0x7C4608", VA = "0x7C4608")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60008E5")]
			[Address(RVA = "0x7C4614", Offset = "0x7C4614", VA = "0x7C4614")]
			set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public float CaretBlinkRate
		{
			[Token(Token = "0x60008E6")]
			[Address(RVA = "0x7C4620", Offset = "0x7C4620", VA = "0x7C4620")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x7C463C", Offset = "0x7C463C", VA = "0x7C463C")]
			set
			{
			}
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x7C3944", Offset = "0x7C3944", VA = "0x7C3944")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x7C3DB8", Offset = "0x7C3DB8", VA = "0x7C3DB8")]
		private void Update()
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x7C405C", Offset = "0x7C405C", VA = "0x7C405C", Slot = "4")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x7C44EC", Offset = "0x7C44EC", VA = "0x7C44EC", Slot = "5")]
		public void OnDeselect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x7C4478", Offset = "0x7C4478", VA = "0x7C4478")]
		[IteratorStateMachine(typeof(<CaretBlinker>d__10))]
		private IEnumerator CaretBlinker()
		{
			return null;
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x7C410C", Offset = "0x7C410C", VA = "0x7C410C")]
		private void CreateCaret()
		{
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x7C3DC8", Offset = "0x7C3DC8", VA = "0x7C3DC8")]
		private void UpdateCaret()
		{
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x7C4548", Offset = "0x7C4548", VA = "0x7C4548")]
		private Vector2 GetLocalPositionInText(int charNo)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x7C39F8", Offset = "0x7C39F8", VA = "0x7C39F8")]
		private void CheckAndConvertMask()
		{
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x7C4658", Offset = "0x7C4658", VA = "0x7C4658")]
		public CurvedUITMPInputFieldCaret()
		{
		}
	}
	[Token(Token = "0x20001B9")]
	[ExecuteInEditMode]
	public class CurvedUITMPSubmesh : MonoBehaviour
	{
		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private VertexHelper vh;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Mesh straightMesh;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Mesh curvedMesh;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CurvedUIVertexEffect crvdVE;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TMP_SubMeshUI TMPsub;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMeshProUGUI TMPtext;

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x7C3418", Offset = "0x7C3418", VA = "0x7C3418")]
		public void UpdateSubmesh(bool tesselate, bool curve)
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x7C47CC", Offset = "0x7C47CC", VA = "0x7C47CC")]
		public CurvedUITMPSubmesh()
		{
		}
	}
	[Token(Token = "0x20001BA")]
	[Conditional("UNITY_CCU")]
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public class OptionalDependencyAttribute : Attribute
	{
		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string dependentClass;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string define;

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x7C47D4", Offset = "0x7C47D4", VA = "0x7C47D4")]
		public OptionalDependencyAttribute(string dependentClass, string define)
		{
		}
	}
}
namespace CMF
{
	[Token(Token = "0x20001BB")]
	public class AnimationControl : MonoBehaviour
	{
		[Token(Token = "0x20001BC")]
		[CompilerGenerated]
		private sealed class <StumbleRecover>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AnimationControl <>4__this;

			[Token(Token = "0x170000FE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008FE")]
				[Address(RVA = "0x7C55EC", Offset = "0x7C55EC", VA = "0x7C55EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000900")]
				[Address(RVA = "0x7C5634", Offset = "0x7C5634", VA = "0x7C5634", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x7C5400", Offset = "0x7C5400", VA = "0x7C5400")]
			[DebuggerHidden]
			public <StumbleRecover>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x60008FC")]
			[Address(RVA = "0x7C5494", Offset = "0x7C5494", VA = "0x7C5494", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008FD")]
			[Address(RVA = "0x7C5498", Offset = "0x7C5498", VA = "0x7C5498", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008FF")]
			[Address(RVA = "0x7C55F4", Offset = "0x7C55F4", VA = "0x7C55F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Controller controller;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform animatorTransform;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform tr;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SeekerIdleAnimations idleAnimations;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useStrafeAnimations;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float smoothingFactor;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 oldMovementVelocity;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stumbleRecoverDelay;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool stayFrozen;

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x7C4818", Offset = "0x7C4818", VA = "0x7C4818")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x7C48EC", Offset = "0x7C48EC", VA = "0x7C48EC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x7C4B1C", Offset = "0x7C4B1C", VA = "0x7C4B1C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x7C4C78", Offset = "0x7C4C78", VA = "0x7C4C78")]
		private void Update()
		{
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x7C5248", Offset = "0x7C5248", VA = "0x7C5248")]
		private void OnLand(Vector3 _v)
		{
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x7C529C", Offset = "0x7C529C", VA = "0x7C529C")]
		private void OnJump(Vector3 _v)
		{
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x7C52A0", Offset = "0x7C52A0", VA = "0x7C52A0")]
		public void PlayStumbleAndFreeze(bool freeze)
		{
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x7C538C", Offset = "0x7C538C", VA = "0x7C538C")]
		[IteratorStateMachine(typeof(<StumbleRecover>d__17))]
		private IEnumerator StumbleRecover()
		{
			return null;
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x7C5428", Offset = "0x7C5428", VA = "0x7C5428")]
		public AnimationControl()
		{
		}
	}
	[Token(Token = "0x20001BD")]
	public class AudioControl : MonoBehaviour
	{
		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Controller controller;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Mover mover;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform tr;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioSource audioSource;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useAnimationBasedFootsteps;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float footstepDistance;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float currentFootstepDistance;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float currentFootStepValue;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		public float audioClipVolume;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float RelativeRandomizedVolumeRange;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioClip[] footStepClips;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AudioClip jumpClip;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioClip landClip;

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x7C563C", Offset = "0x7C563C", VA = "0x7C563C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x7C5894", Offset = "0x7C5894", VA = "0x7C5894")]
		private void Update()
		{
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x7C596C", Offset = "0x7C596C", VA = "0x7C596C")]
		private void FootStepUpdate(float _movementSpeed)
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x7C5A80", Offset = "0x7C5A80", VA = "0x7C5A80")]
		private void PlayFootstepSound(float _movementSpeed)
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x7C5B08", Offset = "0x7C5B08", VA = "0x7C5B08")]
		private void OnLand(Vector3 _v)
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x7C5B30", Offset = "0x7C5B30", VA = "0x7C5B30")]
		private void OnJump(Vector3 _v)
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x7C5B58", Offset = "0x7C5B58", VA = "0x7C5B58")]
		public AudioControl()
		{
		}
	}
	[Token(Token = "0x20001BE")]
	public class TurnTowardCameraDirection : MonoBehaviour
	{
		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CameraController cameraController;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform tr;

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x7C5B80", Offset = "0x7C5B80", VA = "0x7C5B80")]
		private void Start()
		{
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x7C5C58", Offset = "0x7C5C58", VA = "0x7C5C58")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x7C5CF8", Offset = "0x7C5CF8", VA = "0x7C5CF8")]
		public TurnTowardCameraDirection()
		{
		}
	}
	[Token(Token = "0x20001BF")]
	public class TurnTowardControllerVelocity : MonoBehaviour
	{
		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Controller controller;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float turnSpeed;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform parentTransform;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform tr;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float currentYRotation;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fallOffAngle;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool ignoreControllerMomentum;

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x7C5D00", Offset = "0x7C5D00", VA = "0x7C5D00")]
		private void Start()
		{
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x7C5E10", Offset = "0x7C5E10", VA = "0x7C5E10")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x7C62C8", Offset = "0x7C62C8", VA = "0x7C62C8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x7C62CC", Offset = "0x7C62CC", VA = "0x7C62CC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x7C62F8", Offset = "0x7C62F8", VA = "0x7C62F8")]
		public TurnTowardControllerVelocity()
		{
		}
	}
	[Token(Token = "0x20001C0")]
	public class TurnTowardTransformDirection : MonoBehaviour
	{
		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform targetTransform;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform tr;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform parentTransform;

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x7C6310", Offset = "0x7C6310", VA = "0x7C6310")]
		private void Start()
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x7C6414", Offset = "0x7C6414", VA = "0x7C6414")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x7C6654", Offset = "0x7C6654", VA = "0x7C6654")]
		public TurnTowardTransformDirection()
		{
		}
	}
	[Token(Token = "0x20001C1")]
	public class CameraController : MonoBehaviour
	{
		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float currentXAngle;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float currentYAngle;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 90f)]
		public float upperVerticalLimit;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 90f)]
		public float lowerVerticalLimit;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float oldHorizontalInput;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float oldVerticalInput;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cameraSpeed;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool useMouseInput;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		public bool smoothCameraRotation;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(50f, 1f)]
		public float cameraSmoothingFactor;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 facingDirection;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 upwardsDirection;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected Transform tr;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected Camera cam;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected CameraInput cameraInput;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected CameraInput cameraJoystickInput;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Gamepad gamepad;

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x7C665C", Offset = "0x7C665C", VA = "0x7C665C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x7C6A38", Offset = "0x7C6A38", VA = "0x7C6A38", Slot = "4")]
		protected virtual void Setup()
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x7C6A3C", Offset = "0x7C6A3C", VA = "0x7C6A3C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x7C6A48", Offset = "0x7C6A48", VA = "0x7C6A48", Slot = "5")]
		protected virtual void HandleCameraRotation()
		{
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x7C693C", Offset = "0x7C693C", VA = "0x7C693C")]
		protected void RotateCamera(float _newHorizontalInput, float _newVerticalInput)
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x7C6BCC", Offset = "0x7C6BCC", VA = "0x7C6BCC")]
		protected void UpdateRotation()
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x7C6C7C", Offset = "0x7C6C7C", VA = "0x7C6C7C")]
		public void SetFOV(float _fov)
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x7C6D10", Offset = "0x7C6D10", VA = "0x7C6D10")]
		public void SetRotationAngles(float _xAngle, float _yAngle)
		{
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x7C6D18", Offset = "0x7C6D18", VA = "0x7C6D18")]
		public void RotateTowardPosition(Vector3 _position, float _lookSpeed)
		{
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x7C6D70", Offset = "0x7C6D70", VA = "0x7C6D70")]
		public void RotateTowardDirection(Vector3 _direction, float _lookSpeed)
		{
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x7C709C", Offset = "0x7C709C", VA = "0x7C709C")]
		public float GetCurrentXAngle()
		{
			return default(float);
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x7C70A4", Offset = "0x7C70A4", VA = "0x7C70A4")]
		public float GetCurrentYAngle()
		{
			return default(float);
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x7C70AC", Offset = "0x7C70AC", VA = "0x7C70AC")]
		public Vector3 GetFacingDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x7C7080", Offset = "0x7C7080", VA = "0x7C7080")]
		public Vector3 GetAimingDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x7C70B8", Offset = "0x7C70B8", VA = "0x7C70B8")]
		public Vector3 GetStrafeDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x7C70D4", Offset = "0x7C70D4", VA = "0x7C70D4")]
		public Vector3 GetUpDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x7C70E0", Offset = "0x7C70E0", VA = "0x7C70E0")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x20001C2")]
	public class CameraDistanceRaycaster : MonoBehaviour
	{
		[Token(Token = "0x20001C3")]
		public enum CastType
		{
			[Token(Token = "0x4000829")]
			Raycast,
			[Token(Token = "0x400082A")]
			Spherecast
		}

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform cameraTransform;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform tr;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CastType castType;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask layerMask;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int ignoreRaycastLayer;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Collider[] ignoreList;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int[] ignoreListLayers;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float preferredDistance;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float currentDistance;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 localCastDirection;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float minimumDistanceFromObstacles;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float minimumDistanceFromPlayer;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float smoothingFactor;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float spherecastRadius;

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x7C710C", Offset = "0x7C710C", VA = "0x7C710C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x7C7448", Offset = "0x7C7448", VA = "0x7C7448")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x7C76DC", Offset = "0x7C76DC", VA = "0x7C76DC")]
		private float GetCameraDistance()
		{
			return default(float);
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x7C7898", Offset = "0x7C7898", VA = "0x7C7898")]
		public CameraDistanceRaycaster()
		{
		}
	}
	[Token(Token = "0x20001C4")]
	public class ThirdPersonCameraController : CameraController
	{
		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool turnCameraTowardMovementDirection;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Controller controller;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float maximumMovementSpeed;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float cameraTurnSpeed;

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x7C78D8", Offset = "0x7C78D8", VA = "0x7C78D8", Slot = "4")]
		protected override void Setup()
		{
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x7C79A4", Offset = "0x7C79A4", VA = "0x7C79A4", Slot = "5")]
		protected override void HandleCameraRotation()
		{
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x7C7A70", Offset = "0x7C7A70", VA = "0x7C7A70")]
		public void RotateTowardsVelocity(Vector3 _velocity, float _speed)
		{
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0x7C7BF0", Offset = "0x7C7BF0", VA = "0x7C7BF0")]
		public ThirdPersonCameraController()
		{
		}
	}
	[Token(Token = "0x20001C5")]
	public class AdvancedWalkerController : Controller
	{
		[Token(Token = "0x20001C6")]
		public enum ControllerState
		{
			[Token(Token = "0x400084D")]
			Grounded,
			[Token(Token = "0x400084E")]
			Sliding,
			[Token(Token = "0x400084F")]
			Falling,
			[Token(Token = "0x4000850")]
			Rising,
			[Token(Token = "0x4000851")]
			Jumping
		}

		[Token(Token = "0x20001C7")]
		[CompilerGenerated]
		private sealed class <Stumble>d__45 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000852")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000853")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000854")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AdvancedWalkerController <>4__this;

			[Token(Token = "0x4000855")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private GameObject <effect>5__2;

			[Token(Token = "0x17000100")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000949")]
				[Address(RVA = "0x7C9E8C", Offset = "0x7C9E8C", VA = "0x7C9E8C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000101")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600094B")]
				[Address(RVA = "0x7C9ED4", Offset = "0x7C9ED4", VA = "0x7C9ED4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000946")]
			[Address(RVA = "0x7C9A44", Offset = "0x7C9A44", VA = "0x7C9A44")]
			[DebuggerHidden]
			public <Stumble>d__45(int <>1__state)
			{
			}

			[Token(Token = "0x6000947")]
			[Address(RVA = "0x7C9C74", Offset = "0x7C9C74", VA = "0x7C9C74", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000948")]
			[Address(RVA = "0x7C9C78", Offset = "0x7C9C78", VA = "0x7C9C78", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600094A")]
			[Address(RVA = "0x7C9E94", Offset = "0x7C9E94", VA = "0x7C9E94", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform vrCameraTrans;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pcCameraTrans;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Transform tr;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Mover mover;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected CharacterInput characterInput;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected CeilingDetector ceilingDetector;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool jumpKeyWasPressed;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool jumpKeyWasLetGo;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool jumpKeyIsPressed;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float movementSpeed;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		public float airControl;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float jumpSpeed;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float jumpDuration;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float currentJumpStartTime;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float airFriction;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float groundFriction;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 momentum;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 savedVelocity;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 savedMovementVelocity;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float gravity;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Tooltip("How fast the character will slide down steep slopes.")]
		public float slideGravity;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float slopeLimit;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[Tooltip("Whether to calculate and apply momentum relative to the controller's transform.")]
		public bool useLocalMomentum;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public GameObject fallStumbleEffect;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float startFallingPosY;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float minFallToStumble;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float stumbleStunnedTime;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private ControllerState currentControllerState;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Tooltip("Optional camera transform used for calculating movement direction. If assigned, character movement will take camera view into account.")]
		public Transform cameraTransform;

		[Token(Token = "0x600092C")]
		[Address(RVA = "0x7C7C2C", Offset = "0x7C7C2C", VA = "0x7C7C2C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0x7C7DBC", Offset = "0x7C7DBC", VA = "0x7C7DBC", Slot = "7")]
		protected virtual void Setup()
		{
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0x7C7DC0", Offset = "0x7C7DC0", VA = "0x7C7DC0")]
		public void SetPCCamera(bool pcCamera)
		{
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x7C7DEC", Offset = "0x7C7DEC", VA = "0x7C7DEC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x7C7E34", Offset = "0x7C7E34", VA = "0x7C7E34")]
		private void HandleJumpKeyInput()
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x7C7E7C", Offset = "0x7C7E7C", VA = "0x7C7E7C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x7C8920", Offset = "0x7C8920", VA = "0x7C8920", Slot = "8")]
		protected virtual Vector3 CalculateMovementDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0x7C88A8", Offset = "0x7C88A8", VA = "0x7C88A8")]
		protected Vector3 CalculateMovementVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x7C8EA8", Offset = "0x7C8EA8", VA = "0x7C8EA8", Slot = "9")]
		protected virtual bool IsJumpKeyPressed()
		{
			return default(bool);
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0x7C8060", Offset = "0x7C8060", VA = "0x7C8060")]
		private ControllerState DetermineControllerState()
		{
			return default(ControllerState);
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0x7C8868", Offset = "0x7C8868", VA = "0x7C8868")]
		private void HandleJumping()
		{
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0x7C82D0", Offset = "0x7C82D0", VA = "0x7C82D0")]
		private void HandleMomentum()
		{
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x7C96A8", Offset = "0x7C96A8", VA = "0x7C96A8")]
		private void OnJumpStart()
		{
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x7C91D0", Offset = "0x7C91D0", VA = "0x7C91D0")]
		private void OnGroundContactLost()
		{
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x7C94F8", Offset = "0x7C94F8", VA = "0x7C94F8")]
		private void OnGroundContactRegained(Vector3 _collisionVelocity)
		{
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0x7C99D0", Offset = "0x7C99D0", VA = "0x7C99D0")]
		[IteratorStateMachine(typeof(<Stumble>d__45))]
		private IEnumerator Stumble()
		{
			return null;
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x7C9598", Offset = "0x7C9598", VA = "0x7C9598")]
		private void OnCeilingContact()
		{
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x7C8F34", Offset = "0x7C8F34", VA = "0x7C8F34")]
		private bool IsRisingOrFalling()
		{
			return default(bool);
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x7C9074", Offset = "0x7C9074", VA = "0x7C9074")]
		private bool IsGroundTooSteep()
		{
			return default(bool);
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x7C9A6C", Offset = "0x7C9A6C", VA = "0x7C9A6C", Slot = "4")]
		public override Vector3 GetVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0x7C9A78", Offset = "0x7C9A78", VA = "0x7C9A78", Slot = "5")]
		public override Vector3 GetMovementVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x7C9000", Offset = "0x7C9000", VA = "0x7C9000")]
		public Vector3 GetMomentum()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x7C9A84", Offset = "0x7C9A84", VA = "0x7C9A84", Slot = "6")]
		public override bool IsGrounded()
		{
			return default(bool);
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x7C9A94", Offset = "0x7C9A94", VA = "0x7C9A94")]
		public bool IsSliding()
		{
			return default(bool);
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x7C9AA4", Offset = "0x7C9AA4", VA = "0x7C9AA4")]
		public void AddMomentum(Vector3 _momentum)
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x7C9BB0", Offset = "0x7C9BB0", VA = "0x7C9BB0")]
		public AdvancedWalkerController()
		{
		}
	}
	[Token(Token = "0x20001C8")]
	public abstract class Controller : MonoBehaviour
	{
		[Token(Token = "0x20001C9")]
		public delegate void VectorEvent(Vector3 v);

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VectorEvent OnJump;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VectorEvent OnLand;

		[Token(Token = "0x600094C")]
		public abstract Vector3 GetVelocity();

		[Token(Token = "0x600094D")]
		public abstract Vector3 GetMovementVelocity();

		[Token(Token = "0x600094E")]
		public abstract bool IsGrounded();

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x7C9C6C", Offset = "0x7C9C6C", VA = "0x7C9C6C")]
		protected Controller()
		{
		}
	}
	[Token(Token = "0x20001CA")]
	public class SidescrollerController : AdvancedWalkerController
	{
		[Token(Token = "0x6000954")]
		[Address(RVA = "0x7C9F84", Offset = "0x7C9F84", VA = "0x7C9F84", Slot = "8")]
		protected override Vector3 CalculateMovementDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0x7CA250", Offset = "0x7CA250", VA = "0x7CA250")]
		public SidescrollerController()
		{
		}
	}
	[Token(Token = "0x20001CB")]
	public class SimpleWalkerController : Controller
	{
		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Mover mover;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float currentVerticalSpeed;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool isGrounded;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float movementSpeed;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float jumpSpeed;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float gravity;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 lastVelocity;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform cameraTransform;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterInput characterInput;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform tr;

		[Token(Token = "0x6000956")]
		[Address(RVA = "0x7CA254", Offset = "0x7CA254", VA = "0x7CA254")]
		private void Start()
		{
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0x7CA300", Offset = "0x7CA300", VA = "0x7CA300")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0x7CA55C", Offset = "0x7CA55C", VA = "0x7CA55C")]
		private Vector3 CalculateMovementDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x7CA540", Offset = "0x7CA540", VA = "0x7CA540")]
		private void OnGroundContactRegained(Vector3 _collisionVelocity)
		{
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x7CAAE4", Offset = "0x7CAAE4", VA = "0x7CAAE4")]
		private void OnJumpStart()
		{
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x7CAB08", Offset = "0x7CAB08", VA = "0x7CAB08", Slot = "4")]
		public override Vector3 GetVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x7CAB14", Offset = "0x7CAB14", VA = "0x7CAB14", Slot = "5")]
		public override Vector3 GetMovementVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x7CAB20", Offset = "0x7CAB20", VA = "0x7CAB20", Slot = "6")]
		public override bool IsGrounded()
		{
			return default(bool);
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x7CAB28", Offset = "0x7CAB28", VA = "0x7CAB28")]
		public SimpleWalkerController()
		{
		}
	}
	[Token(Token = "0x20001CC")]
	public class Mover : MonoBehaviour
	{
		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Mover Options :")]
		[Range(0f, 1f)]
		public float stepHeightRatio;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Header("Collider Options :")]
		[SerializeField]
		public float colliderHeight;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public float colliderThickness;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		public Vector3 colliderOffset;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private BoxCollider boxCollider;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SphereCollider sphereCollider;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CapsuleCollider capsuleCollider;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Sensor Options :")]
		[SerializeField]
		public Sensor.CastType sensorType;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float sensorRadiusModifier;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int currentLayer;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		public bool isInDebugMode;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("Sensor Array Options :")]
		[SerializeField]
		[Range(1f, 5f)]
		public int sensorArrayRows;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[Range(3f, 10f)]
		public int sensorArrayRayCount;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		public bool sensorArrayRowsAreOffset;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public Vector3[] raycastArrayPreviewPositions;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool isGrounded;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool IsUsingExtendedSensorRange;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float baseSensorRange;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 currentGroundAdjustmentVelocity;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Collider col;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Rigidbody rig;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Transform tr;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Sensor sensor;

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x7CAB9C", Offset = "0x7CAB9C", VA = "0x7CAB9C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x7CB868", Offset = "0x7CB868", VA = "0x7CB868")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x7CB86C", Offset = "0x7CB86C", VA = "0x7CB86C")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x7CAC30", Offset = "0x7CAC30", VA = "0x7CAC30")]
		private void Setup()
		{
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x7CBB70", Offset = "0x7CBB70", VA = "0x7CBB70")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x7CB1B0", Offset = "0x7CB1B0", VA = "0x7CB1B0")]
		public void RecalculateColliderDimensions()
		{
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x7CB64C", Offset = "0x7CB64C", VA = "0x7CB64C")]
		private void RecalibrateSensor()
		{
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x7CC03C", Offset = "0x7CC03C", VA = "0x7CC03C")]
		private void RecalculateSensorLayerMask()
		{
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x7CBE64", Offset = "0x7CBE64", VA = "0x7CBE64")]
		private Vector3 GetColliderCenter()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x7CC160", Offset = "0x7CC160", VA = "0x7CC160")]
		private void Check()
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x7C8018", Offset = "0x7C8018", VA = "0x7C8018")]
		public void CheckForGround()
		{
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x7C88EC", Offset = "0x7C88EC", VA = "0x7C88EC")]
		public void SetVelocity(Vector3 _velocity)
		{
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x7CC500", Offset = "0x7CC500", VA = "0x7CC500")]
		public bool IsGrounded()
		{
			return default(bool);
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x7CC508", Offset = "0x7CC508", VA = "0x7CC508")]
		public void SetExtendSensorRange(bool _isExtended)
		{
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x7CC514", Offset = "0x7CC514", VA = "0x7CC514")]
		public void SetColliderHeight(float _newColliderHeight)
		{
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0x7CC52C", Offset = "0x7CC52C", VA = "0x7CC52C")]
		public void SetStepHeightRatio(float _newStepHeightRatio)
		{
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x7C99B0", Offset = "0x7C99B0", VA = "0x7C99B0")]
		public Vector3 GetGroundNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x7CC548", Offset = "0x7CC548", VA = "0x7CC548")]
		public Vector3 GetGroundPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x7CC568", Offset = "0x7CC568", VA = "0x7CC568")]
		public Collider GetGroundCollider()
		{
			return null;
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x7CC5D4", Offset = "0x7CC5D4", VA = "0x7CC5D4")]
		public Mover()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001CD")]
	public class Sensor
	{
		[Token(Token = "0x20001CE")]
		public enum CastDirection
		{
			[Token(Token = "0x4000895")]
			Forward,
			[Token(Token = "0x4000896")]
			Right,
			[Token(Token = "0x4000897")]
			Up,
			[Token(Token = "0x4000898")]
			Backward,
			[Token(Token = "0x4000899")]
			Left,
			[Token(Token = "0x400089A")]
			Down
		}

		[Token(Token = "0x20001CF")]
		[SerializeField]
		public enum CastType
		{
			[Token(Token = "0x400089C")]
			Raycast,
			[Token(Token = "0x400089D")]
			RaycastArray,
			[Token(Token = "0x400089E")]
			Spherecast
		}

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float castLength;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float sphereCastRadius;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 origin;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private CastDirection castDirection;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool hasDetectedHit;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 hitPosition;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 hitNormal;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float hitDistance;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Collider> hitColliders;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Transform> hitTransforms;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 backupNormal;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform tr;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Collider col;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CastType castType;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public LayerMask layermask;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int ignoreRaycastLayer;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool calculateRealSurfaceNormal;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		public bool calculateRealDistance;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public int arrayRayCount;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public int ArrayRows;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool offsetArrayRows;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] raycastArrayStartPositions;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Collider[] ignoreList;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int[] ignoreListLayers;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool isInDebugMode;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<Vector3> arrayNormals;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<Vector3> arrayPoints;

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x7CAEA8", Offset = "0x7CAEA8", VA = "0x7CAEA8")]
		public Sensor(Transform _transform, Collider _collider)
		{
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x7CC67C", Offset = "0x7CC67C", VA = "0x7CC67C")]
		private void ResetFlags()
		{
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x7CB8D0", Offset = "0x7CB8D0", VA = "0x7CB8D0")]
		public static Vector3[] GetRaycastStartPositions(int sensorRows, int sensorRayCount, bool offsetRows, float sensorRadius)
		{
			return null;
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x7CC288", Offset = "0x7CC288", VA = "0x7CC288")]
		public void Cast()
		{
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x7CCEFC", Offset = "0x7CCEFC", VA = "0x7CCEFC")]
		private void CastRayArray(Vector3 _origin, Vector3 _direction)
		{
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x7CC898", Offset = "0x7CC898", VA = "0x7CC898")]
		private void CastRay(Vector3 _origin, Vector3 _direction)
		{
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x7CCAA0", Offset = "0x7CCAA0", VA = "0x7CCAA0")]
		private void CastSphere(Vector3 _origin, Vector3 _direction)
		{
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x7CC7A8", Offset = "0x7CC7A8", VA = "0x7CC7A8")]
		private Vector3 GetCastDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0x7CBB98", Offset = "0x7CBB98", VA = "0x7CBB98")]
		public void DrawDebug()
		{
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x7CD5B0", Offset = "0x7CD5B0", VA = "0x7CD5B0")]
		public bool HasDetectedHit()
		{
			return default(bool);
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x7CD5B8", Offset = "0x7CD5B8", VA = "0x7CD5B8")]
		public float GetDistance()
		{
			return default(float);
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x7CD5C0", Offset = "0x7CD5C0", VA = "0x7CD5C0")]
		public Vector3 GetNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x7CD5CC", Offset = "0x7CD5CC", VA = "0x7CD5CC")]
		public Vector3 GetPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x7CC580", Offset = "0x7CC580", VA = "0x7CC580")]
		public Collider GetCollider()
		{
			return null;
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x7CD5D8", Offset = "0x7CD5D8", VA = "0x7CD5D8")]
		public Transform GetTransform()
		{
			return null;
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x7CBF18", Offset = "0x7CBF18", VA = "0x7CBF18")]
		public void SetCastOrigin(Vector3 _origin)
		{
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x7CBFC4", Offset = "0x7CBFC4", VA = "0x7CBFC4")]
		public void SetCastDirection(CastDirection _direction)
		{
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x7CC134", Offset = "0x7CC134", VA = "0x7CC134")]
		public void RecalibrateRaycastArrayPositions()
		{
		}
	}
	[Token(Token = "0x20001D0")]
	public class FlipAtRightAngle : MonoBehaviour
	{
		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AudioSource audioSource;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform tr;

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x7CD62C", Offset = "0x7CD62C", VA = "0x7CD62C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x7CD6A0", Offset = "0x7CD6A0", VA = "0x7CD6A0")]
		private void OnTriggerEnter(Collider col)
		{
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0x7CD7A4", Offset = "0x7CD7A4", VA = "0x7CD7A4")]
		private void SwitchDirection(Vector3 _newUpDirection, Controller _controller)
		{
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x7CD9E4", Offset = "0x7CD9E4", VA = "0x7CD9E4")]
		public FlipAtRightAngle()
		{
		}
	}
	[Token(Token = "0x20001D1")]
	public class GravityTunnel : MonoBehaviour
	{
		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<Rigidbody> rigidbodies;

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x7CD9EC", Offset = "0x7CD9EC", VA = "0x7CD9EC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x7CDF50", Offset = "0x7CDF50", VA = "0x7CDF50")]
		private void OnTriggerEnter(Collider col)
		{
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x7CE0C8", Offset = "0x7CE0C8", VA = "0x7CE0C8")]
		private void OnTriggerExit(Collider col)
		{
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x7CDD70", Offset = "0x7CDD70", VA = "0x7CDD70")]
		private void RotateRigidbody(Transform _transform, Vector3 _targetDirection)
		{
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x7CE290", Offset = "0x7CE290", VA = "0x7CE290")]
		private Quaternion GetCounterRotation(Quaternion _rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x7CE394", Offset = "0x7CE394", VA = "0x7CE394")]
		public GravityTunnel()
		{
		}
	}
	[Token(Token = "0x20001D2")]
	public class MovingPlatform : MonoBehaviour
	{
		[Token(Token = "0x20001D3")]
		[CompilerGenerated]
		private sealed class <LateFixedUpdate>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MovingPlatform <>4__this;

			[Token(Token = "0x40008AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private WaitForFixedUpdate <_instruction>5__2;

			[Token(Token = "0x17000102")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000998")]
				[Address(RVA = "0x7CEC98", Offset = "0x7CEC98", VA = "0x7CEC98", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000103")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600099A")]
				[Address(RVA = "0x7CECE0", Offset = "0x7CECE0", VA = "0x7CECE0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000995")]
			[Address(RVA = "0x7CE6A0", Offset = "0x7CE6A0", VA = "0x7CE6A0")]
			[DebuggerHidden]
			public <LateFixedUpdate>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000996")]
			[Address(RVA = "0x7CEBD8", Offset = "0x7CEBD8", VA = "0x7CEBD8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000997")]
			[Address(RVA = "0x7CEBDC", Offset = "0x7CEBDC", VA = "0x7CEBDC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000999")]
			[Address(RVA = "0x7CECA0", Offset = "0x7CECA0", VA = "0x7CECA0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20001D4")]
		[CompilerGenerated]
		private sealed class <WaitRoutine>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MovingPlatform <>4__this;

			[Token(Token = "0x40008B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private WaitForSeconds <_waitInstruction>5__2;

			[Token(Token = "0x17000104")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600099E")]
				[Address(RVA = "0x7CEDF8", Offset = "0x7CEDF8", VA = "0x7CEDF8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000105")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009A0")]
				[Address(RVA = "0x7CEE40", Offset = "0x7CEE40", VA = "0x7CEE40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600099B")]
			[Address(RVA = "0x7CEB18", Offset = "0x7CEB18", VA = "0x7CEB18")]
			[DebuggerHidden]
			public <WaitRoutine>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x600099C")]
			[Address(RVA = "0x7CECE8", Offset = "0x7CECE8", VA = "0x7CECE8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600099D")]
			[Address(RVA = "0x7CECEC", Offset = "0x7CECEC", VA = "0x7CECEC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600099F")]
			[Address(RVA = "0x7CEE00", Offset = "0x7CEE00", VA = "0x7CEE00", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float movementSpeed;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool reverseDirection;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float waitTime;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool isWaiting;

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody r;

		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TriggerArea triggerArea;

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<Transform> waypoints;

		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int currentWaypointIndex;

		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform currentWaypoint;

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x7CE41C", Offset = "0x7CE41C", VA = "0x7CE41C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x7CE62C", Offset = "0x7CE62C", VA = "0x7CE62C")]
		[IteratorStateMachine(typeof(<LateFixedUpdate>d__10))]
		private IEnumerator LateFixedUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x7CE6C8", Offset = "0x7CE6C8", VA = "0x7CE6C8")]
		private void MovePlatform()
		{
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x7CEA64", Offset = "0x7CEA64", VA = "0x7CEA64")]
		private void UpdateWaypoint()
		{
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x7CE5B8", Offset = "0x7CE5B8", VA = "0x7CE5B8")]
		[IteratorStateMachine(typeof(<WaitRoutine>d__13))]
		private IEnumerator WaitRoutine()
		{
			return null;
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x7CEB40", Offset = "0x7CEB40", VA = "0x7CEB40")]
		public MovingPlatform()
		{
		}
	}
	[Token(Token = "0x20001D5")]
	public class TriggerArea : MonoBehaviour
	{
		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Rigidbody> rigidbodiesInTriggerArea;

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x7CEE48", Offset = "0x7CEE48", VA = "0x7CEE48")]
		private void OnTriggerEnter(Collider col)
		{
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x7CEFB8", Offset = "0x7CEFB8", VA = "0x7CEFB8")]
		private void OnTriggerExit(Collider col)
		{
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x7CF0D4", Offset = "0x7CF0D4", VA = "0x7CF0D4")]
		public TriggerArea()
		{
		}
	}
	[Token(Token = "0x20001D6")]
	public static class VectorMath
	{
		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x7C6148", Offset = "0x7C6148", VA = "0x7C6148")]
		public static float GetAngle(Vector3 _vector1, Vector3 _vector2, Vector3 _planeNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x7C513C", Offset = "0x7C513C", VA = "0x7C513C")]
		public static float GetDotProduct(Vector3 _vector, Vector3 _direction)
		{
			return default(float);
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x7C5018", Offset = "0x7C5018", VA = "0x7C5018")]
		public static Vector3 RemoveDotVector(Vector3 _vector, Vector3 _direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x7C97D8", Offset = "0x7C97D8", VA = "0x7C97D8")]
		public static Vector3 ExtractDotVector(Vector3 _vector, Vector3 _direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x7CF15C", Offset = "0x7CF15C", VA = "0x7CF15C")]
		public static Vector3 RotateVectorOntoPlane(Vector3 _vector, Vector3 _planeNormal, Vector3 _upDirection)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x7CF1A8", Offset = "0x7CF1A8", VA = "0x7CF1A8")]
		public static Vector3 ProjectPointOntoLine(Vector3 _lineStartPosition, Vector3 _lineDirection, Vector3 _point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x7CF1EC", Offset = "0x7CF1EC", VA = "0x7CF1EC")]
		public static float IncrementValueTowardTarget(float _currentValue, float _speed, float _deltaTime, float _targetValue)
		{
			return default(float);
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x7C98F0", Offset = "0x7C98F0", VA = "0x7C98F0")]
		public static Vector3 IncrementVectorLengthTowardTargetLength(Vector3 _currentVector, float _speed, float _deltaTime, float _targetLength)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20001D7")]
	public abstract class CameraInput : MonoBehaviour
	{
		[Token(Token = "0x60009AC")]
		public abstract float GetHorizontalCameraInput();

		[Token(Token = "0x60009AD")]
		public abstract float GetVerticalCameraInput();

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x7CF278", Offset = "0x7CF278", VA = "0x7CF278")]
		protected CameraInput()
		{
		}
	}
	[Token(Token = "0x20001D8")]
	public class CameraJoystickInput : CameraInput
	{
		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string joystickHorizontalAxis;

		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string joystickVerticalAxis;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool invertHorizontalInput;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool invertVerticalInput;

		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float deadZoneThreshold;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float controllerSensitivity;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Gamepad gamepad;

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x7CF280", Offset = "0x7CF280", VA = "0x7CF280")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x7CF2D4", Offset = "0x7CF2D4", VA = "0x7CF2D4", Slot = "4")]
		public override float GetHorizontalCameraInput()
		{
			return default(float);
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x7CF358", Offset = "0x7CF358", VA = "0x7CF358", Slot = "5")]
		public override float GetVerticalCameraInput()
		{
			return default(float);
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x7CF3DC", Offset = "0x7CF3DC", VA = "0x7CF3DC")]
		public CameraJoystickInput()
		{
		}
	}
	[Token(Token = "0x20001D9")]
	public class CameraMouseInput : CameraInput
	{
		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string mouseHorizontalAxis;

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string mouseVerticalAxis;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool invertHorizontalInput;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool invertVerticalInput;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float mouseSensitivity;

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x7CF46C", Offset = "0x7CF46C", VA = "0x7CF46C", Slot = "4")]
		public override float GetHorizontalCameraInput()
		{
			return default(float);
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x7CF4A8", Offset = "0x7CF4A8", VA = "0x7CF4A8", Slot = "5")]
		public override float GetVerticalCameraInput()
		{
			return default(float);
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x7CF4E4", Offset = "0x7CF4E4", VA = "0x7CF4E4")]
		public CameraMouseInput()
		{
		}
	}
	[Token(Token = "0x20001DA")]
	public abstract class CharacterInput : MonoBehaviour
	{
		[Token(Token = "0x60009B6")]
		public abstract float GetHorizontalMovementInput();

		[Token(Token = "0x60009B7")]
		public abstract float GetVerticalMovementInput();

		[Token(Token = "0x60009B8")]
		public abstract bool IsJumpKeyPressed();

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x7CF570", Offset = "0x7CF570", VA = "0x7CF570")]
		protected CharacterInput()
		{
		}
	}
	[Token(Token = "0x20001DB")]
	public class CharacterJoystickInput : CharacterInput
	{
		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string horizontalInputAxis;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string verticalInputAxis;

		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public KeyCode jumpKey;

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool useRawInput;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float deadZoneThreshold;

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x7CF578", Offset = "0x7CF578", VA = "0x7CF578", Slot = "4")]
		public override float GetHorizontalMovementInput()
		{
			return default(float);
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x7CF5B8", Offset = "0x7CF5B8", VA = "0x7CF5B8", Slot = "5")]
		public override float GetVerticalMovementInput()
		{
			return default(float);
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x7CF5F8", Offset = "0x7CF5F8", VA = "0x7CF5F8", Slot = "6")]
		public override bool IsJumpKeyPressed()
		{
			return default(bool);
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x7CF604", Offset = "0x7CF604", VA = "0x7CF604")]
		public CharacterJoystickInput()
		{
		}
	}
	[Token(Token = "0x20001DC")]
	public class CharacterKeyboardInput : CharacterInput
	{
		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string horizontalInputAxis;

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string verticalInputAxis;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public KeyCode jumpKey;

		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool useRawInput;

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x7CF6A4", Offset = "0x7CF6A4", VA = "0x7CF6A4", Slot = "4")]
		public override float GetHorizontalMovementInput()
		{
			return default(float);
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x7CF6BC", Offset = "0x7CF6BC", VA = "0x7CF6BC", Slot = "5")]
		public override float GetVerticalMovementInput()
		{
			return default(float);
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x7CF6D4", Offset = "0x7CF6D4", VA = "0x7CF6D4", Slot = "6")]
		public override bool IsJumpKeyPressed()
		{
			return default(bool);
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x7CF6E0", Offset = "0x7CF6E0", VA = "0x7CF6E0")]
		public CharacterKeyboardInput()
		{
		}
	}
	[Token(Token = "0x20001DD")]
	public class CharacterVRInput : CharacterInput
	{
		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isPCPlayer;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool walkWithRightHand;

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Gamepad gamepad;

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x7CF774", Offset = "0x7CF774", VA = "0x7CF774")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x7CF80C", Offset = "0x7CF80C", VA = "0x7CF80C", Slot = "4")]
		public override float GetHorizontalMovementInput()
		{
			return default(float);
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x7CF9A4", Offset = "0x7CF9A4", VA = "0x7CF9A4", Slot = "5")]
		public override float GetVerticalMovementInput()
		{
			return default(float);
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x7CFB40", Offset = "0x7CFB40", VA = "0x7CFB40", Slot = "6")]
		public override bool IsJumpKeyPressed()
		{
			return default(bool);
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x7CFB48", Offset = "0x7CFB48", VA = "0x7CFB48")]
		public void ActivatePCPlayerInput(bool activate)
		{
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x7CFB54", Offset = "0x7CFB54", VA = "0x7CFB54")]
		public CharacterVRInput()
		{
		}
	}
	[Token(Token = "0x20001DE")]
	public class DemoMenu : MonoBehaviour
	{
		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode menuKey;

		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DisableShadows disableShadows;

		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSCounter fpsCounter;

		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject demoMenuObject;

		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<GameObject> controllers;

		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<UnityEngine.UI.Button> buttons;

		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Toggle shadowToggle;

		[Token(Token = "0x40008D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject regularArea;

		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject topDownArea;

		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Color activeButtonColor;

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x7CFB5C", Offset = "0x7CFB5C", VA = "0x7CFB5C")]
		private void Start()
		{
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x7CFE84", Offset = "0x7CFE84", VA = "0x7CFE84")]
		private void Update()
		{
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x7CFEFC", Offset = "0x7CFEFC", VA = "0x7CFEFC")]
		public void RestartScene()
		{
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x7CFF6C", Offset = "0x7CFF6C", VA = "0x7CFF6C")]
		public void QuitGame()
		{
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x7CFF74", Offset = "0x7CFF74", VA = "0x7CFF74")]
		public void OnControllerPresetChosen(int _presetIndex)
		{
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x7CFE28", Offset = "0x7CFE28", VA = "0x7CFE28")]
		public void SetMenuEnabled(bool _isEnabled)
		{
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x7CFFD0", Offset = "0x7CFFD0", VA = "0x7CFFD0")]
		public void SetShadowsEnabled(bool _isEnabled)
		{
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x7D0048", Offset = "0x7D0048", VA = "0x7D0048")]
		public void SetFrameRateEnabled(bool _isEnabled)
		{
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x7D0068", Offset = "0x7D0068", VA = "0x7D0068")]
		public DemoMenu()
		{
		}
	}
	[Token(Token = "0x20001DF")]
	public class DisableShadows : MonoBehaviour
	{
		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool shadowsAreActive;

		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Light sceneLight;

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x7D0154", Offset = "0x7D0154", VA = "0x7D0154")]
		private void Start()
		{
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x7CFE5C", Offset = "0x7CFE5C", VA = "0x7CFE5C")]
		public void SetShadows(bool _isActivated)
		{
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x7D01AC", Offset = "0x7D01AC", VA = "0x7D01AC")]
		public DisableShadows()
		{
		}
	}
	[Token(Token = "0x20001E0")]
	public class FPSCounter : MonoBehaviour
	{
		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float checkInterval;

		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int currentPassedFrames;

		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float currentPassedTime;

		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float currentFrameRate;

		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string currentFrameRateString;

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x7D01BC", Offset = "0x7D01BC", VA = "0x7D01BC")]
		private void Update()
		{
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x7D0268", Offset = "0x7D0268", VA = "0x7D0268")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x7D039C", Offset = "0x7D039C", VA = "0x7D039C")]
		public FPSCounter()
		{
		}
	}
	[Token(Token = "0x20001E1")]
	public class MouseCursorLock : MonoBehaviour
	{
		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool lockCursorAtGameStart;

		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public KeyCode unlockKeyCode;

		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public KeyCode lockKeyCode;

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x7D03FC", Offset = "0x7D03FC", VA = "0x7D03FC")]
		private void Start()
		{
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x7D0414", Offset = "0x7D0414", VA = "0x7D0414")]
		private void Update()
		{
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x7D0460", Offset = "0x7D0460", VA = "0x7D0460")]
		public MouseCursorLock()
		{
		}
	}
	[Token(Token = "0x20001E2")]
	public static class PlayerData
	{
		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int controllerIndex;

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static bool enableShadows;
	}
	[Token(Token = "0x20001E3")]
	public class RotateObject : MonoBehaviour
	{
		[Token(Token = "0x40008E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform tr;

		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float rotationSpeed;

		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 rotationAxis;

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x7D04CC", Offset = "0x7D04CC", VA = "0x7D04CC")]
		private void Start()
		{
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x7D04F0", Offset = "0x7D04F0", VA = "0x7D04F0")]
		private void Update()
		{
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x7D054C", Offset = "0x7D054C", VA = "0x7D054C")]
		public RotateObject()
		{
		}
	}
	[Token(Token = "0x20001E4")]
	public class SmoothPosition : MonoBehaviour
	{
		[Token(Token = "0x20001E5")]
		public enum UpdateType
		{
			[Token(Token = "0x40008F0")]
			Update,
			[Token(Token = "0x40008F1")]
			LateUpdate
		}

		[Token(Token = "0x20001E6")]
		public enum SmoothType
		{
			[Token(Token = "0x40008F3")]
			Lerp,
			[Token(Token = "0x40008F4")]
			SmoothDamp
		}

		[Token(Token = "0x40008E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40008E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform tr;

		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 currentPosition;

		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float lerpSpeed;

		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float smoothDampTime;

		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool extrapolatePosition;

		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateType updateType;

		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public SmoothType smoothType;

		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 localPositionOffset;

		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 refVelocity;

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x7D0560", Offset = "0x7D0560", VA = "0x7D0560")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x7D0654", Offset = "0x7D0654", VA = "0x7D0654")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x7D06F8", Offset = "0x7D06F8", VA = "0x7D06F8")]
		private void Update()
		{
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x7D0780", Offset = "0x7D0780", VA = "0x7D0780")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x7D070C", Offset = "0x7D070C", VA = "0x7D070C")]
		private void SmoothUpdate()
		{
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x7D0790", Offset = "0x7D0790", VA = "0x7D0790")]
		private Vector3 Smooth(Vector3 _start, Vector3 _target, float _smoothTime)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x7D0658", Offset = "0x7D0658", VA = "0x7D0658")]
		public void ResetCurrentPosition()
		{
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x7D093C", Offset = "0x7D093C", VA = "0x7D093C")]
		public SmoothPosition()
		{
		}
	}
	[Token(Token = "0x20001E7")]
	public class SmoothRotation : MonoBehaviour
	{
		[Token(Token = "0x20001E8")]
		public enum UpdateType
		{
			[Token(Token = "0x40008FC")]
			Update,
			[Token(Token = "0x40008FD")]
			LateUpdate
		}

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform tr;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion currentRotation;

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float smoothSpeed;

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool extrapolateRotation;

		[Token(Token = "0x40008FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateType updateType;

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x7D0950", Offset = "0x7D0950", VA = "0x7D0950")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x7D0A2C", Offset = "0x7D0A2C", VA = "0x7D0A2C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x7D0A5C", Offset = "0x7D0A5C", VA = "0x7D0A5C")]
		private void Update()
		{
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x7D0AF8", Offset = "0x7D0AF8", VA = "0x7D0AF8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x7D0A70", Offset = "0x7D0A70", VA = "0x7D0A70")]
		private void SmoothUpdate()
		{
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x7D0B08", Offset = "0x7D0B08", VA = "0x7D0B08")]
		private Quaternion Smooth(Quaternion _currentRotation, Quaternion _targetRotation, float _smoothSpeed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x7D0A30", Offset = "0x7D0A30", VA = "0x7D0A30")]
		public void ResetCurrentRotation()
		{
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x7D0CF0", Offset = "0x7D0CF0", VA = "0x7D0CF0")]
		public SmoothRotation()
		{
		}
	}
}
