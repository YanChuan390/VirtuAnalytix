using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Byn.Awrtc;
using Dissonance.Datastructures;
using Dissonance.Integrations.PureP2P;
using Dissonance.Networking;
using Dissonance.Networking.Client;
using Dissonance.Networking.Server;
using Firebase.Auth;
using Firebase.Database;
using Il2CppDummyDll;
using JetBrains.Annotations;
using LitJson;
using NLayer;
using NLayer.Decoder;
using Oculus.Platform;
using Oculus.Platform.Models;
using Pvr_UnitySDKAPI;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class Pvr_Controller : MonoBehaviour
{
	[Token(Token = "0x200011D")]
	public enum UserHandNess
	{
		[Token(Token = "0x4000A89")]
		Right,
		[Token(Token = "0x4000A8A")]
		Left
	}

	[Token(Token = "0x200011E")]
	public enum GazeType
	{
		[Token(Token = "0x4000A8C")]
		Never,
		[Token(Token = "0x4000A8D")]
		DuringMotion,
		[Token(Token = "0x4000A8E")]
		Always
	}

	[Token(Token = "0x200011F")]
	public enum ControllerAxis
	{
		[Token(Token = "0x4000A90")]
		Controller,
		[Token(Token = "0x4000A91")]
		Wrist,
		[Token(Token = "0x4000A92")]
		Elbow,
		[Token(Token = "0x4000A93")]
		Shoulder
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject controller0;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject controller1;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static UserHandNess handness;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ControllerAxis Axis;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public GazeType Gazetype;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x800130", Offset = "0x800130")]
	public float ElbowHeight;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x80014C", Offset = "0x80014C")]
	public float ElbowDepth;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x800168", Offset = "0x800168")]
	public float PointerTiltAngle;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float mouseX;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float mouseY;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float mouseZ;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3[] inputDirection;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800180", Offset = "0x800180")]
	private static Vector3 <pointerPosition>k__BackingField;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800190", Offset = "0x800190")]
	private static Quaternion <pointerRotation>k__BackingField;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8001A0", Offset = "0x8001A0")]
	private static Vector3 <elbowPosition>k__BackingField;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8001B0", Offset = "0x8001B0")]
	private static Quaternion <elbowRotation>k__BackingField;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8001C0", Offset = "0x8001C0")]
	private static Vector3 <wristPosition>k__BackingField;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8001D0", Offset = "0x8001D0")]
	private static Quaternion <wristRotation>k__BackingField;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8001E0", Offset = "0x8001E0")]
	private static Vector3 <shoulderPosition>k__BackingField;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8001F0", Offset = "0x8001F0")]
	private static Quaternion <shoulderRotation>k__BackingField;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800200", Offset = "0x800200")]
	private static Vector3 <originOffsetL>k__BackingField;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800210", Offset = "0x800210")]
	private static Vector3 <originOffsetR>k__BackingField;

	[Token(Token = "0x17000001")]
	public static Vector3 pointerPosition
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0xE3B42C", Offset = "0xE3B42C", VA = "0xE3B42C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8013E8", Offset = "0x8013E8")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000015")]
		[Address(RVA = "0xE3B480", Offset = "0xE3B480", VA = "0xE3B480")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8013F8", Offset = "0x8013F8")]
		set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public static Quaternion pointerRotation
	{
		[Token(Token = "0x6000016")]
		[Address(RVA = "0xE3B4F0", Offset = "0xE3B4F0", VA = "0xE3B4F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801408", Offset = "0x801408")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000017")]
		[Address(RVA = "0xE3B544", Offset = "0xE3B544", VA = "0xE3B544")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801418", Offset = "0x801418")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public static Vector3 elbowPosition
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0xE3B5B8", Offset = "0xE3B5B8", VA = "0xE3B5B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801428", Offset = "0x801428")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000019")]
		[Address(RVA = "0xE3B60C", Offset = "0xE3B60C", VA = "0xE3B60C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801438", Offset = "0x801438")]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public static Quaternion elbowRotation
	{
		[Token(Token = "0x600001A")]
		[Address(RVA = "0xE3B67C", Offset = "0xE3B67C", VA = "0xE3B67C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801448", Offset = "0x801448")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x600001B")]
		[Address(RVA = "0xE3B6D0", Offset = "0xE3B6D0", VA = "0xE3B6D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801458", Offset = "0x801458")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public static Vector3 wristPosition
	{
		[Token(Token = "0x600001C")]
		[Address(RVA = "0xE3B744", Offset = "0xE3B744", VA = "0xE3B744")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801468", Offset = "0x801468")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600001D")]
		[Address(RVA = "0xE3B798", Offset = "0xE3B798", VA = "0xE3B798")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801478", Offset = "0x801478")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public static Quaternion wristRotation
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0xE3B808", Offset = "0xE3B808", VA = "0xE3B808")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801488", Offset = "0x801488")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x600001F")]
		[Address(RVA = "0xE3B85C", Offset = "0xE3B85C", VA = "0xE3B85C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801498", Offset = "0x801498")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public static Vector3 shoulderPosition
	{
		[Token(Token = "0x6000020")]
		[Address(RVA = "0xE3B8D0", Offset = "0xE3B8D0", VA = "0xE3B8D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8014A8", Offset = "0x8014A8")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000021")]
		[Address(RVA = "0xE3B924", Offset = "0xE3B924", VA = "0xE3B924")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8014B8", Offset = "0x8014B8")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public static Quaternion shoulderRotation
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0xE3B994", Offset = "0xE3B994", VA = "0xE3B994")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8014C8", Offset = "0x8014C8")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000023")]
		[Address(RVA = "0xE3B9E8", Offset = "0xE3B9E8", VA = "0xE3B9E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8014D8", Offset = "0x8014D8")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public static Vector3 originOffsetL
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0xE3BA5C", Offset = "0xE3BA5C", VA = "0xE3BA5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8014E8", Offset = "0x8014E8")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000025")]
		[Address(RVA = "0xE3BAB0", Offset = "0xE3BAB0", VA = "0xE3BAB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8014F8", Offset = "0x8014F8")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public static Vector3 originOffsetR
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0xE3BB20", Offset = "0xE3BB20", VA = "0xE3BB20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801508", Offset = "0x801508")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000027")]
		[Address(RVA = "0xE3BB74", Offset = "0xE3BB74", VA = "0xE3BB74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801518", Offset = "0x801518")]
		set
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xE39500", Offset = "0xE39500", VA = "0xE39500")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xE3963C", Offset = "0xE3963C", VA = "0xE3963C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xE396AC", Offset = "0xE396AC", VA = "0xE396AC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xE397E8", Offset = "0xE397E8", VA = "0xE397E8")]
	private void MainControllerChanged(string index)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xE39890", Offset = "0xE39890", VA = "0xE39890")]
	private void HandnessChanged(string index)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xE39894", Offset = "0xE39894", VA = "0xE39894")]
	private void ServiceStartSuccess()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xE397EC", Offset = "0xE397EC", VA = "0xE397EC")]
	private void RefreshHandness()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xE398F4", Offset = "0xE398F4", VA = "0xE398F4")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xE39A78", Offset = "0xE39A78", VA = "0xE39A78")]
	private void ShowController()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xE39BD8", Offset = "0xE39BD8", VA = "0xE39BD8")]
	private void CheckControllerState(string data)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xE39CAC", Offset = "0xE39CAC", VA = "0xE39CAC")]
	private void Update()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xE39898", Offset = "0xE39898", VA = "0xE39898")]
	public static void ChangeHandNess()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xE3A0C4", Offset = "0xE3A0C4", VA = "0xE3A0C4")]
	private void DoUpdateControler0()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xE3A140", Offset = "0xE3A140", VA = "0xE3A140")]
	private void DoUpdateControler1()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xE3A1C4", Offset = "0xE3A1C4", VA = "0xE3A1C4")]
	private void UpdateControlloerRay(bool update0 = true, bool update1 = true)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xE3B248", Offset = "0xE3B248", VA = "0xE3B248")]
	private Quaternion UpdateSimulatedFrameParams()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xE3A318", Offset = "0xE3A318", VA = "0xE3A318")]
	private void SetArmParaToSo(int hand, int gazeType, float elbowHeight, float elbowDepth, float pointerTiltAngle)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xE3A328", Offset = "0xE3A328", VA = "0xE3A328")]
	private void CalcArmModelfromSo(int hand)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xE3A804", Offset = "0xE3A804", VA = "0xE3A804")]
	public void UpdateControllerDataSO(int hand)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xE3BBE4", Offset = "0xE3BBE4", VA = "0xE3BBE4")]
	public Pvr_Controller()
	{
	}
}
[Token(Token = "0x2000003")]
public class Pvr_ControllerDemo : MonoBehaviour
{
	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject HeadSetController;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject controller0;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject controller1;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject cube;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Ray ray;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject currentController;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Transform lastHit;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Transform currentHit;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Material normat;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Material gazemat;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Material clickmat;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool noClick;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private GameObject referenceObj;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float rayDefaultLength;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private bool isHasController;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
	private bool headcontrolmode;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private RaycastHit hit;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private GameObject rayLine;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private GameObject dot;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private Transform dragObj;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private float disX;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private float disY;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private float disZ;

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xE3BC4C", Offset = "0xE3BC4C", VA = "0xE3BC4C")]
	private void Start()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xE3BDD8", Offset = "0xE3BDD8", VA = "0xE3BDD8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xE3BEF0", Offset = "0xE3BEF0", VA = "0xE3BEF0")]
	private void Update()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xE3D7D0", Offset = "0xE3D7D0", VA = "0xE3D7D0")]
	private void ServiceStartSuccess()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xE3D868", Offset = "0xE3D868", VA = "0xE3D868")]
	private void ControllerStateListener(string data)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xE3D900", Offset = "0xE3D900", VA = "0xE3D900")]
	private void CheckControllerStateForGoblin(string state)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xE3D998", Offset = "0xE3D998", VA = "0xE3D998")]
	public void SwitchControlMode()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xE3D99C", Offset = "0xE3D99C", VA = "0xE3D99C")]
	public Pvr_ControllerDemo()
	{
	}
}
[Token(Token = "0x2000004")]
public class Pvr_ControllerEventsExamples : MonoBehaviour
{
	[Token(Token = "0x6000031")]
	[Address(RVA = "0xE3D9AC", Offset = "0xE3D9AC", VA = "0xE3D9AC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xE3DBE4", Offset = "0xE3DBE4", VA = "0xE3DBE4")]
	private void UIPointerElementEnter(object sender, UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xE3DC80", Offset = "0xE3DC80", VA = "0xE3DC80")]
	private void UIPointerElementExit(object sender, UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xE3DD1C", Offset = "0xE3DD1C", VA = "0xE3DD1C")]
	private void UIPointerElementClick(object sender, UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xE3DDB8", Offset = "0xE3DDB8", VA = "0xE3DDB8")]
	private void UIPointerElementDragStart(object sender, UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xE3DE54", Offset = "0xE3DE54", VA = "0xE3DE54")]
	private void UIPointerElementDragEnd(object sender, UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xE3DEF0", Offset = "0xE3DEF0", VA = "0xE3DEF0")]
	public Pvr_ControllerEventsExamples()
	{
	}
}
[Token(Token = "0x2000005")]
public class Pvr_ControllerInit : MonoBehaviour
{
	[Token(Token = "0x2000120")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFCC8", Offset = "0x7FFCC8")]
	private sealed class <RefreshController>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000A96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int id;

		[Token(Token = "0x4000A97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Pvr_ControllerInit <>4__this;

		[Token(Token = "0x170000DD")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600094B")]
			[Address(RVA = "0x108803C", Offset = "0x108803C", VA = "0x108803C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DE")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600094D")]
			[Address(RVA = "0x10880A4", Offset = "0x10880A4", VA = "0x10880A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x1087038", Offset = "0x1087038", VA = "0x1087038")]
		[DebuggerHidden]
		public <RefreshController>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x1087CA8", Offset = "0x1087CA8", VA = "0x1087CA8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0x1087CAC", Offset = "0x1087CAC", VA = "0x1087CAC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0x1088044", Offset = "0x1088044", VA = "0x1088044", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ControllerVariety Variety;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private bool isCustomModel;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject goblin;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject g2;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject neo2L;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject neo2R;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject neo3L;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject neo3R;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Material standardMat;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Material unlitMat;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int controllerType;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[HideInInspector]
	public bool loadModelSuccess;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int systemOrUnity;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private JsonData curControllerData;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private string modelName;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private string texFormat;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private string prePath;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private string modelFilePath;

	[Token(Token = "0x4000040")]
	private const string goblinTexbasePath = "Controller/controller1/controller1";

	[Token(Token = "0x4000041")]
	private const string g2TexbasePath = "Controller/controller3/controller3";

	[Token(Token = "0x4000042")]
	private const string neo2TexbasePath = "Controller/controller4/controller4";

	[Token(Token = "0x4000043")]
	private const string neo3TexbasePath = "Controller/controller5/controller5";

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1085CA8", Offset = "0x1085CA8", VA = "0x1085CA8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1086104", Offset = "0x1086104", VA = "0x1086104")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x10864BC", Offset = "0x10864BC", VA = "0x10864BC")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x108674C", Offset = "0x108674C", VA = "0x108674C")]
	private void ServiceStartSuccess()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1086944", Offset = "0x1086944", VA = "0x1086944")]
	private void LoadResFromJson()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1086B30", Offset = "0x1086B30", VA = "0x1086B30")]
	private void CheckControllerStateForGoblin(string state)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x1086ED4", Offset = "0x1086ED4", VA = "0x1086ED4")]
	private void CheckControllerStateOfAbility(string data)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x10864C8", Offset = "0x10864C8", VA = "0x10864C8")]
	private void DestroyLocalController()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x1086C1C", Offset = "0x1086C1C", VA = "0x1086C1C")]
	private void DestroySysController()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1086AB0", Offset = "0x1086AB0", VA = "0x1086AB0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x801528", Offset = "0x801528")]
	private IEnumerator RefreshController(int id)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1087064", Offset = "0x1087064", VA = "0x1087064")]
	private void LoadControllerFromPrefab()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x1087608", Offset = "0x1087608", VA = "0x1087608")]
	private void LoadControllerFromSystem(int id)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1087314", Offset = "0x1087314", VA = "0x1087314")]
	private void LoadTexture(Pvr_ControllerVisual visual, string controllerName, bool fromRes)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1087A1C", Offset = "0x1087A1C", VA = "0x1087A1C")]
	private Texture2D LoadOneTexture(string filepath, bool fromRes)
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1087B28", Offset = "0x1087B28", VA = "0x1087B28")]
	private byte[] ReadPNG(string path)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x1087C34", Offset = "0x1087C34", VA = "0x1087C34")]
	public Pvr_ControllerInit()
	{
	}
}
[Token(Token = "0x2000006")]
public class Pvr_ControllerLink
{
	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public AndroidJavaClass javaHummingbirdClass;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AndroidJavaClass javaPico2ReceiverClass;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AndroidJavaClass javaserviceClass;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AndroidJavaClass javavractivityclass;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AndroidJavaClass javaCVClass;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AndroidJavaObject activity;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string gameobjname;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool picoDevice;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string hummingBirdMac;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int hummingBirdRSSI;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public bool goblinserviceStarted;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	public bool neoserviceStarted;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
	public bool controller0Connected;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
	public bool controller1Connected;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int mainHandID;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public Pvr_Controller.UserHandNess handness;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int controllerType;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ControllerHand Controller0;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ControllerHand Controller1;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int platFormType;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public int trackingmode;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public int systemProp;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public int enablehand6dofbyhead;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool switchHomeKey;

	[Token(Token = "0x400005C")]
	private const float SWITCH_METER = 1000f;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private int iPhoneHMDModeEnabled;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float[] hbPoseData;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float[] sensorData;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private int[] keyData;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private int[] neo3TouchValue;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private float[] fixedState;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float[] neoposeData;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private int[] goblinKeyArray;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private int[] neoKeyArray;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private int[] neotriggerV;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private float[] velocity;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private float[] angularVelocity;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private float[] acceData;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private float[] predictData;

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x10880AC", Offset = "0x10880AC", VA = "0x10880AC")]
	public Pvr_ControllerLink(string name)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1088440", Offset = "0x1088440", VA = "0x1088440")]
	private void StartHummingBirdService()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1088E40", Offset = "0x1088E40", VA = "0x1088E40")]
	public bool IsServiceExisted()
	{
		return default(bool);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1088BE4", Offset = "0x1088BE4", VA = "0x1088BE4")]
	public void SetGameObjectToJar(string name)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1088CF4", Offset = "0x1088CF4", VA = "0x1088CF4")]
	public void BindService()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1088FC8", Offset = "0x1088FC8", VA = "0x1088FC8")]
	public void UnBindService()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1089114", Offset = "0x1089114", VA = "0x1089114")]
	public void StopReceiver()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x108920C", Offset = "0x108920C", VA = "0x108920C")]
	public void StartReceiver()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1089330", Offset = "0x1089330", VA = "0x1089330")]
	public int getHandness()
	{
		return default(int);
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1089540", Offset = "0x1089540", VA = "0x1089540")]
	public void setHandness(int hand)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x1089698", Offset = "0x1089698", VA = "0x1089698")]
	public void StartScan()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x10897B0", Offset = "0x10897B0", VA = "0x10897B0")]
	public void StopScan()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1088A70", Offset = "0x1088A70", VA = "0x1088A70")]
	public int GetSysproc()
	{
		return default(int);
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x10898CC", Offset = "0x10898CC", VA = "0x10898CC")]
	public void ResetController(int num)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1089AD0", Offset = "0x1089AD0", VA = "0x1089AD0")]
	public void ConnectBLE()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1089C0C", Offset = "0x1089C0C", VA = "0x1089C0C")]
	public void DisConnectBLE()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1089D2C", Offset = "0x1089D2C", VA = "0x1089D2C")]
	public bool StartUpgrade()
	{
		return default(bool);
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1089E68", Offset = "0x1089E68", VA = "0x1089E68")]
	public void setBinPath(string path, bool isasset)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x1089FE0", Offset = "0x1089FE0", VA = "0x1089FE0")]
	public string GetBLEImageType()
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x108A144", Offset = "0x108A144", VA = "0x108A144")]
	public long GetBLEVersion()
	{
		return default(long);
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x108A2AC", Offset = "0x108A2AC", VA = "0x108A2AC")]
	public string GetFileImageType()
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x108A410", Offset = "0x108A410", VA = "0x108A410")]
	public long GetFileVersion()
	{
		return default(long);
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x108A578", Offset = "0x108A578", VA = "0x108A578")]
	public int GetControllerConnectionState(int num)
	{
		return default(int);
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x108A8B8", Offset = "0x108A8B8", VA = "0x108A8B8")]
	public void RebackToLauncher()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x108AAA0", Offset = "0x108AAA0", VA = "0x108AAA0")]
	public void TurnUpVolume()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x108AC1C", Offset = "0x108AC1C", VA = "0x108AC1C")]
	public void TurnDownVolume()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x108AD98", Offset = "0x108AD98", VA = "0x108AD98")]
	public float[] GetHBControllerPoseData()
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x108B160", Offset = "0x108B160", VA = "0x108B160")]
	public float[] GetControllerSensorData()
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x108B328", Offset = "0x108B328", VA = "0x108B328")]
	public int[] GetControllerKeyData()
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x108B42C", Offset = "0x108B42C", VA = "0x108B42C")]
	public int[] GetNeo3TouchData(int hand)
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x108BBA4", Offset = "0x108BBA4", VA = "0x108BBA4")]
	public int GetNeo3GripValue(int hand)
	{
		return default(int);
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x108BD34", Offset = "0x108BD34", VA = "0x108BD34")]
	public float[] GetControllerFixedSensorState(int hand)
	{
		return null;
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x108C2DC", Offset = "0x108C2DC", VA = "0x108C2DC")]
	public float[] GetCvControllerPoseData(int hand)
	{
		return null;
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x108C8AC", Offset = "0x108C8AC", VA = "0x108C8AC")]
	public int[] GetHBControllerKeyData()
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x108DBC0", Offset = "0x108DBC0", VA = "0x108DBC0")]
	public int GetHBKeyValue()
	{
		return default(int);
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x108DD60", Offset = "0x108DD60", VA = "0x108DD60")]
	public int[] GetCvControllerKeyData(int hand)
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x108F808", Offset = "0x108F808", VA = "0x108F808")]
	public int GetCVTriggerValue(int hand)
	{
		return default(int);
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x108F9C0", Offset = "0x108F9C0", VA = "0x108F9C0")]
	public void AutoConnectHbController(int scanTimeMs)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x108FB38", Offset = "0x108FB38", VA = "0x108FB38")]
	public void StartControllerThread(int headSensorState, int handSensorState)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x108FCFC", Offset = "0x108FCFC", VA = "0x108FCFC")]
	public void StopControllerThread(int headSensorState, int handSensorState)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x108FEC0", Offset = "0x108FEC0", VA = "0x108FEC0")]
	public void SetUnityVersionToJar(string version)
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x108FFE0", Offset = "0x108FFE0", VA = "0x108FFE0")]
	public Vector3 GetVelocity(int num)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x1090384", Offset = "0x1090384", VA = "0x1090384")]
	public Vector3 GetAngularVelocity(int num)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x1090834", Offset = "0x1090834", VA = "0x1090834")]
	public Vector3 GetAcceleration(int num)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x1090CBC", Offset = "0x1090CBC", VA = "0x1090CBC")]
	public string GetConnectedDeviceMac()
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x1090E20", Offset = "0x1090E20", VA = "0x1090E20")]
	public void VibrateNeo2Controller(float strength, int time, int hand)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x10910FC", Offset = "0x10910FC", VA = "0x10910FC")]
	public void VibrateController(float strength, int time, int hand)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x10913D8", Offset = "0x10913D8", VA = "0x10913D8")]
	public int GetMainControllerIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x1091550", Offset = "0x1091550", VA = "0x1091550")]
	public void SetMainController(int index)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x10916A4", Offset = "0x10916A4", VA = "0x10916A4")]
	public void ResetHeadSensorForController()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x10917CC", Offset = "0x10917CC", VA = "0x10917CC")]
	public void GetDeviceVersion(int deviceType)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x1091928", Offset = "0x1091928", VA = "0x1091928")]
	public void GetControllerSnCode(int controllerSerialNum)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x1091A84", Offset = "0x1091A84", VA = "0x1091A84")]
	public void SetControllerUnbind(int controllerSerialNum)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x1091BE0", Offset = "0x1091BE0", VA = "0x1091BE0")]
	public void SetStationRestart()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x1091D08", Offset = "0x1091D08", VA = "0x1091D08")]
	public void StartStationOtaUpdate()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x1091E30", Offset = "0x1091E30", VA = "0x1091E30")]
	public void StartControllerOtaUpdate(int mode, int controllerSerialNum)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x1091FEC", Offset = "0x1091FEC", VA = "0x1091FEC")]
	public void EnterPairMode(int controllerSerialNum)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1092148", Offset = "0x1092148", VA = "0x1092148")]
	public void SetControllerShutdown(int controllerSerialNum)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x10922A4", Offset = "0x10922A4", VA = "0x10922A4")]
	public int GetStationPairState()
	{
		return default(int);
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1092420", Offset = "0x1092420", VA = "0x1092420")]
	public int GetStationOtaUpdateProgress()
	{
		return default(int);
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x109259C", Offset = "0x109259C", VA = "0x109259C")]
	public int GetControllerOtaUpdateProgress()
	{
		return default(int);
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1092718", Offset = "0x1092718", VA = "0x1092718")]
	public void GetControllerVersionAndSN(int controllerSerialNum)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1092874", Offset = "0x1092874", VA = "0x1092874")]
	public void GetControllerUniqueID()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x109299C", Offset = "0x109299C", VA = "0x109299C")]
	public void InterruptStationPairMode()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1092AC4", Offset = "0x1092AC4", VA = "0x1092AC4")]
	public int GetControllerAbility(int controllerSerialNum)
	{
		return default(int);
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x1092C3C", Offset = "0x1092C3C", VA = "0x1092C3C")]
	public void SwitchHomeKey(bool state)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x1092CF0", Offset = "0x1092CF0", VA = "0x1092CF0")]
	public void SetBootReconnect()
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x1092E10", Offset = "0x1092E10", VA = "0x1092E10")]
	public int GetTemperature()
	{
		return default(int);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1092F84", Offset = "0x1092F84", VA = "0x1092F84")]
	public int GetDeviceType()
	{
		return default(int);
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x10930F8", Offset = "0x10930F8", VA = "0x10930F8")]
	public int GetControllerType()
	{
		return default(int);
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x1093200", Offset = "0x1093200", VA = "0x1093200")]
	public string GetHummingBird2SN()
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x109335C", Offset = "0x109335C", VA = "0x109335C")]
	public string GetControllerVersion()
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x10934B8", Offset = "0x10934B8", VA = "0x10934B8")]
	public bool IsEnbleTrigger()
	{
		return default(bool);
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x1093618", Offset = "0x1093618", VA = "0x1093618")]
	public void StartCV2PairingMode(int devicetype)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x1093774", Offset = "0x1093774", VA = "0x1093774")]
	public void StopCV2PairingMode(int devicetype)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x10938D0", Offset = "0x10938D0", VA = "0x10938D0")]
	public int GetControllerBindingState(int id)
	{
		return default(int);
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x1093A38", Offset = "0x1093A38", VA = "0x1093A38")]
	public void setIsEnbleHomeKey(bool state)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x1093B84", Offset = "0x1093B84", VA = "0x1093B84")]
	public int getControllerSensorStatus(int id)
	{
		return default(int);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x1093CEC", Offset = "0x1093CEC", VA = "0x1093CEC")]
	public float[] GetControllerPredictSensorData(int controllerID, float predictTime)
	{
		return null;
	}
}
[Token(Token = "0x2000007")]
public class Pvr_ControllerManager : MonoBehaviour
{
	[Token(Token = "0x2000121")]
	public delegate void PvrServiceStartSuccess();

	[Token(Token = "0x2000122")]
	public delegate void PvrControllerStateChanged(string data);

	[Token(Token = "0x2000123")]
	public delegate void ChangeMainControllerCallBack(string index);

	[Token(Token = "0x2000124")]
	public delegate void ChangeHandNessCallBack(string index);

	[Token(Token = "0x2000125")]
	public delegate void SetHbServiceBindState();

	[Token(Token = "0x2000126")]
	public delegate void ControllerThreadStartedCallback();

	[Token(Token = "0x2000127")]
	public delegate void SetControllerServiceBindState();

	[Token(Token = "0x2000128")]
	public delegate void ControllerStatusChange(string isconnect);

	[Token(Token = "0x2000129")]
	public delegate void SetControllerAbility(string data);

	[Token(Token = "0x200012A")]
	public delegate void SetControllerStateChanged(string data);

	[Token(Token = "0x200012B")]
	public delegate void SetHbControllerMac(string mac);

	[Token(Token = "0x200012C")]
	public delegate void ControllerDeviceVersionCallback(string data);

	[Token(Token = "0x200012D")]
	public delegate void ControllerSnCodeCallback(string data);

	[Token(Token = "0x200012E")]
	public delegate void ControllerUnbindCallback(string status);

	[Token(Token = "0x200012F")]
	public delegate void ControllerStationStatusCallback(string status);

	[Token(Token = "0x2000130")]
	public delegate void ControllerStationBusyCallback(string status);

	[Token(Token = "0x2000131")]
	public delegate void ControllerOtaStartCodeCallback(string data);

	[Token(Token = "0x2000132")]
	public delegate void ControllerDeviceVersionAndSNCallback(string data);

	[Token(Token = "0x2000133")]
	public delegate void ControllerUniqueIDCallback(string data);

	[Token(Token = "0x2000134")]
	public delegate void ControllerCombinedKeyUnbindCallback(string data);

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Pvr_ControllerManager instance;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Pvr_ControllerLink controllerlink;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float cTime;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private bool stopConnect;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text toast;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool controllerServicestate;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float disConnectTime;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool LengthAdaptiveRay;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float[] sensorData;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int[] keyData;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float[] g2SensorData;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int[] g2KeyData;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int keyOffset;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int rotControllerMode;

	[Token(Token = "0x1700000B")]
	public static Pvr_ControllerManager Instance
	{
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1093EC8", Offset = "0x1093EC8", VA = "0x1093EC8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000001")]
	public static event PvrServiceStartSuccess PvrServiceStartSuccessEvent
	{
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1085E14", Offset = "0x1085E14", VA = "0x1085E14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80158C", Offset = "0x80158C")]
		add
		{
		}
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x10861EC", Offset = "0x10861EC", VA = "0x10861EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80159C", Offset = "0x80159C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public static event PvrControllerStateChanged PvrControllerStateChangedEvent
	{
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x10940F8", Offset = "0x10940F8", VA = "0x10940F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8015AC", Offset = "0x8015AC")]
		add
		{
		}
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x10941E8", Offset = "0x10941E8", VA = "0x10941E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8015BC", Offset = "0x8015BC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public static event ChangeMainControllerCallBack ChangeMainControllerCallBackEvent
	{
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x10942D8", Offset = "0x10942D8", VA = "0x10942D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8015CC", Offset = "0x8015CC")]
		add
		{
		}
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x10943C8", Offset = "0x10943C8", VA = "0x10943C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8015DC", Offset = "0x8015DC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public static event ChangeHandNessCallBack ChangeHandNessCallBackEvent
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x10944B8", Offset = "0x10944B8", VA = "0x10944B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8015EC", Offset = "0x8015EC")]
		add
		{
		}
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x10945A8", Offset = "0x10945A8", VA = "0x10945A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8015FC", Offset = "0x8015FC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public static event SetHbServiceBindState SetHbServiceBindStateEvent
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1094698", Offset = "0x1094698", VA = "0x1094698")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80160C", Offset = "0x80160C")]
		add
		{
		}
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1094788", Offset = "0x1094788", VA = "0x1094788")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80161C", Offset = "0x80161C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public static event ControllerThreadStartedCallback ControllerThreadStartedCallbackEvent
	{
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1094878", Offset = "0x1094878", VA = "0x1094878")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80162C", Offset = "0x80162C")]
		add
		{
		}
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1094968", Offset = "0x1094968", VA = "0x1094968")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80163C", Offset = "0x80163C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000007")]
	public static event SetControllerServiceBindState SetControllerServiceBindStateEvent
	{
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1094A58", Offset = "0x1094A58", VA = "0x1094A58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80164C", Offset = "0x80164C")]
		add
		{
		}
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1094B48", Offset = "0x1094B48", VA = "0x1094B48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80165C", Offset = "0x80165C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public static event ControllerStatusChange ControllerStatusChangeEvent
	{
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1086014", Offset = "0x1086014", VA = "0x1086014")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80166C", Offset = "0x80166C")]
		add
		{
		}
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x10863CC", Offset = "0x10863CC", VA = "0x10863CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80167C", Offset = "0x80167C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public static event SetControllerAbility SetControllerAbilityEvent
	{
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1085F14", Offset = "0x1085F14", VA = "0x1085F14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80168C", Offset = "0x80168C")]
		add
		{
		}
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x10862DC", Offset = "0x10862DC", VA = "0x10862DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80169C", Offset = "0x80169C")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public static event SetControllerStateChanged SetControllerStateChangedEvent
	{
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1094C38", Offset = "0x1094C38", VA = "0x1094C38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8016AC", Offset = "0x8016AC")]
		add
		{
		}
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1094D28", Offset = "0x1094D28", VA = "0x1094D28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8016BC", Offset = "0x8016BC")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public static event SetHbControllerMac SetHbControllerMacEvent
	{
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1094E18", Offset = "0x1094E18", VA = "0x1094E18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8016CC", Offset = "0x8016CC")]
		add
		{
		}
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1094F08", Offset = "0x1094F08", VA = "0x1094F08")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8016DC", Offset = "0x8016DC")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000C")]
	public static event ControllerDeviceVersionCallback ControllerDeviceVersionCallbackEvent
	{
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1094FF8", Offset = "0x1094FF8", VA = "0x1094FF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8016EC", Offset = "0x8016EC")]
		add
		{
		}
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x10950E8", Offset = "0x10950E8", VA = "0x10950E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8016FC", Offset = "0x8016FC")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public static event ControllerSnCodeCallback ControllerSnCodeCallbackEvent
	{
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x10951D8", Offset = "0x10951D8", VA = "0x10951D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80170C", Offset = "0x80170C")]
		add
		{
		}
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x10952C8", Offset = "0x10952C8", VA = "0x10952C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80171C", Offset = "0x80171C")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000E")]
	public static event ControllerUnbindCallback ControllerUnbindCallbackEvent
	{
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x10953B8", Offset = "0x10953B8", VA = "0x10953B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80172C", Offset = "0x80172C")]
		add
		{
		}
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x10954A8", Offset = "0x10954A8", VA = "0x10954A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80173C", Offset = "0x80173C")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000F")]
	public static event ControllerStationStatusCallback ControllerStationStatusCallbackEvent
	{
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1095598", Offset = "0x1095598", VA = "0x1095598")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80174C", Offset = "0x80174C")]
		add
		{
		}
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1095688", Offset = "0x1095688", VA = "0x1095688")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80175C", Offset = "0x80175C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000010")]
	public static event ControllerStationBusyCallback ControllerStationBusyCallbackEvent
	{
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1095778", Offset = "0x1095778", VA = "0x1095778")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80176C", Offset = "0x80176C")]
		add
		{
		}
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1095868", Offset = "0x1095868", VA = "0x1095868")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80177C", Offset = "0x80177C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000011")]
	public static event ControllerOtaStartCodeCallback ControllerOtaStartCodeCallbackEvent
	{
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1095958", Offset = "0x1095958", VA = "0x1095958")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80178C", Offset = "0x80178C")]
		add
		{
		}
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1095A48", Offset = "0x1095A48", VA = "0x1095A48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80179C", Offset = "0x80179C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000012")]
	public static event ControllerDeviceVersionAndSNCallback ControllerDeviceVersionAndSNCallbackEvent
	{
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1095B38", Offset = "0x1095B38", VA = "0x1095B38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8017AC", Offset = "0x8017AC")]
		add
		{
		}
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1095C28", Offset = "0x1095C28", VA = "0x1095C28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8017BC", Offset = "0x8017BC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000013")]
	public static event ControllerUniqueIDCallback ControllerUniqueIDCallbackEvent
	{
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1095D18", Offset = "0x1095D18", VA = "0x1095D18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8017CC", Offset = "0x8017CC")]
		add
		{
		}
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1095E08", Offset = "0x1095E08", VA = "0x1095E08")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8017DC", Offset = "0x8017DC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000014")]
	public static event ControllerCombinedKeyUnbindCallback ControllerCombinedKeyUnbindCallbackEvent
	{
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1095EF8", Offset = "0x1095EF8", VA = "0x1095EF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8017EC", Offset = "0x8017EC")]
		add
		{
		}
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1095FE8", Offset = "0x1095FE8", VA = "0x1095FE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8017FC", Offset = "0x8017FC")]
		remove
		{
		}
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x10960D8", Offset = "0x10960D8", VA = "0x10960D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x10963C4", Offset = "0x10963C4", VA = "0x10963C4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x109646C", Offset = "0x109646C", VA = "0x109646C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x1097EE8", Offset = "0x1097EE8", VA = "0x1097EE8")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x1098540", Offset = "0x1098540", VA = "0x1098540")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x109861C", Offset = "0x109861C", VA = "0x109861C")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x109875C", Offset = "0x109875C", VA = "0x109875C")]
	public Vector3 GetAngularVelocity(int num)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x109883C", Offset = "0x109883C", VA = "0x109883C")]
	public Vector3 GetAcceleration(int num)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x1096320", Offset = "0x1096320", VA = "0x1096320")]
	public void BindService()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x109891C", Offset = "0x109891C", VA = "0x109891C")]
	public void StartScan()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x10989C0", Offset = "0x10989C0", VA = "0x10989C0")]
	public void StopScan()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x1098A64", Offset = "0x1098A64", VA = "0x1098A64")]
	public void ResetController(int num)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x10982BC", Offset = "0x10982BC", VA = "0x10982BC")]
	public static int GetControllerConnectionState(int num)
	{
		return default(int);
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x1098B10", Offset = "0x1098B10", VA = "0x1098B10")]
	public void ConnectBLE()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x1098BB4", Offset = "0x1098BB4", VA = "0x1098BB4")]
	public void DisConnectBLE()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x1098C58", Offset = "0x1098C58", VA = "0x1098C58")]
	public void SetBinPath(string path, bool isAsset)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x1098D18", Offset = "0x1098D18", VA = "0x1098D18")]
	public void StartUpgrade()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x1098DBC", Offset = "0x1098DBC", VA = "0x1098DBC")]
	public static string GetBLEImageType()
	{
		return null;
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x1098E2C", Offset = "0x1098E2C", VA = "0x1098E2C")]
	public static long GetBLEVersion()
	{
		return default(long);
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x1098E9C", Offset = "0x1098E9C", VA = "0x1098E9C")]
	public static string GetFileImageType()
	{
		return null;
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x1098F0C", Offset = "0x1098F0C", VA = "0x1098F0C")]
	public static long GetFileVersion()
	{
		return default(long);
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x1098F7C", Offset = "0x1098F7C", VA = "0x1098F7C")]
	public static void AutoConnectHbController(int scans)
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x1099028", Offset = "0x1099028", VA = "0x1099028")]
	public static string GetConnectedDeviceMac()
	{
		return null;
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x10990DC", Offset = "0x10990DC", VA = "0x10990DC")]
	public void setHbControllerMac(string mac)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x1099628", Offset = "0x1099628", VA = "0x1099628")]
	public int GetControllerRSSI()
	{
		return default(int);
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x109969C", Offset = "0x109969C", VA = "0x109969C")]
	public void setHbServiceBindState(string state)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x1099B2C", Offset = "0x1099B2C", VA = "0x1099B2C")]
	public void setControllerServiceBindState(string state)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x1099FBC", Offset = "0x1099FBC", VA = "0x1099FBC")]
	public void setHbControllerConnectState(string isconnect)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x109A974", Offset = "0x109A974", VA = "0x109A974")]
	public void setControllerStateChanged(string state)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x109B294", Offset = "0x109B294", VA = "0x109B294")]
	public void setControllerAbility(string data)
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x109B720", Offset = "0x109B720", VA = "0x109B720")]
	public void controllerThreadStartedCallback()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x109BD5C", Offset = "0x109BD5C", VA = "0x109BD5C")]
	public void controllerDeviceVersionCallback(string data)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x109C1E8", Offset = "0x109C1E8", VA = "0x109C1E8")]
	public void controllerSnCodeCallback(string data)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x109C674", Offset = "0x109C674", VA = "0x109C674")]
	public void controllerUnbindCallback(string status)
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x109CB00", Offset = "0x109CB00", VA = "0x109CB00")]
	public void controllerStationStatusCallback(string status)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x109CF8C", Offset = "0x109CF8C", VA = "0x109CF8C")]
	public void controllerStationBusyCallback(string status)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x109D418", Offset = "0x109D418", VA = "0x109D418")]
	public void controllerOTAStartCodeCallback(string data)
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x109D8A4", Offset = "0x109D8A4", VA = "0x109D8A4")]
	public void controllerDeviceVersionAndSNCallback(string data)
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x109DD30", Offset = "0x109DD30", VA = "0x109DD30")]
	public void controllerUniqueIDCallback(string data)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x109E1BC", Offset = "0x109E1BC", VA = "0x109E1BC")]
	public void controllerCombinedKeyUnbindCallback(string controllerSerialNum)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x109E5FC", Offset = "0x109E5FC", VA = "0x109E5FC")]
	public void setupdateFailed()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x109E600", Offset = "0x109E600", VA = "0x109E600")]
	public void setupdateSuccess()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x109E604", Offset = "0x109E604", VA = "0x109E604")]
	public void setupdateProgress(string progress)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x109E608", Offset = "0x109E608", VA = "0x109E608")]
	public void setHbAutoConnectState(string state)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x109E924", Offset = "0x109E924", VA = "0x109E924")]
	public void callbackControllerServiceState(string state)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x109EA80", Offset = "0x109EA80", VA = "0x109EA80")]
	public void changeMainControllerCallback(string index)
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x109EF60", Offset = "0x109EF60", VA = "0x109EF60")]
	public void changeHandnessCallback(string index)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x109E75C", Offset = "0x109E75C", VA = "0x109E75C")]
	private void ShowToast(int type)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x109F440", Offset = "0x109F440", VA = "0x109F440")]
	private void HideToast()
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x109F4E8", Offset = "0x109F4E8", VA = "0x109F4E8")]
	private void CheckControllerService()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x109B858", Offset = "0x109B858", VA = "0x109B858")]
	private void GetCVControllerState()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x10977E0", Offset = "0x10977E0", VA = "0x10977E0")]
	private void SetSystemKey()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x1097414", Offset = "0x1097414", VA = "0x1097414")]
	private void TransformData(ControllerHand hand, int handId, int[] data)
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x109F4FC", Offset = "0x109F4FC", VA = "0x109F4FC")]
	private void TransSingleKey(PvrControllerKey key, int beginIndex, int[] data)
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x109F64C", Offset = "0x109F64C", VA = "0x109F64C")]
	private void TransformTouchData(ControllerHand hand, int handId, int[] data)
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x109F6F0", Offset = "0x109F6F0", VA = "0x109F6F0")]
	private void TransSingleTouchValue(PvrControllerKey key, int beginIndex, int[] data)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x109F7F0", Offset = "0x109F7F0", VA = "0x109F7F0")]
	public Pvr_ControllerManager()
	{
	}
}
[Token(Token = "0x2000008")]
public class Pvr_ControllerModuleInit : MonoBehaviour
{
	[Token(Token = "0x2000135")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFCD8", Offset = "0x7FFCD8")]
	private sealed class <ShowOrHideRay>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000A9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pvr_ControllerModuleInit <>4__this;

		[Token(Token = "0x4000A9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int id;

		[Token(Token = "0x170000DF")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60009A1")]
			[Address(RVA = "0x10A0614", Offset = "0x10A0614", VA = "0x10A0614", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E0")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009A3")]
			[Address(RVA = "0x10A067C", Offset = "0x10A067C", VA = "0x10A067C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x10A0200", Offset = "0x10A0200", VA = "0x10A0200")]
		[DebuggerHidden]
		public <ShowOrHideRay>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x10A0544", Offset = "0x10A0544", VA = "0x10A0544", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x10A0548", Offset = "0x10A0548", VA = "0x10A0548", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x10A061C", Offset = "0x10A061C", VA = "0x10A061C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ControllerVariety Variety;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool IsCustomModel;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject dot;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject rayLine;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject controller;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool moduleState;

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x109FD94", Offset = "0x109FD94", VA = "0x109FD94")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x109FF1C", Offset = "0x109FF1C", VA = "0x109FF1C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x10A0004", Offset = "0x10A0004", VA = "0x10A0004")]
	private void ServiceStartSuccess()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x10A0078", Offset = "0x10A0078", VA = "0x10A0078")]
	private void ControllerStateChanged(string data)
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x10A017C", Offset = "0x10A017C", VA = "0x10A017C")]
	private void MainControllerIDChanged(string data)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x10A0008", Offset = "0x10A0008", VA = "0x10A0008")]
	private void RefreshRay()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x10A0180", Offset = "0x10A0180", VA = "0x10A0180")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x80180C", Offset = "0x80180C")]
	private IEnumerator ShowOrHideRay(int id)
	{
		return null;
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x10A022C", Offset = "0x10A022C", VA = "0x10A022C")]
	public void ForceHideOrShow(bool state)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x10A0328", Offset = "0x10A0328", VA = "0x10A0328")]
	public void UpdateRay()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x10A0534", Offset = "0x10A0534", VA = "0x10A0534")]
	public Pvr_ControllerModuleInit()
	{
	}
}
[Token(Token = "0x2000009")]
public class Pvr_ControllerPower : MonoBehaviour
{
	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Sprite power1;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Sprite power2;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Sprite power3;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Sprite power4;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Sprite power5;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public ControllerVariety variety;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[HideInInspector]
	public ControllerDevice currentDevice;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Image powerImage;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int powerValue;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float power;

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x10A0684", Offset = "0x10A0684", VA = "0x10A0684")]
	private void Start()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x10A074C", Offset = "0x10A074C", VA = "0x10A074C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x10A076C", Offset = "0x10A076C", VA = "0x10A076C")]
	private void RefreshPower(int hand)
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x10A088C", Offset = "0x10A088C", VA = "0x10A088C")]
	public Pvr_ControllerPower()
	{
	}
}
[Token(Token = "0x200000A")]
public class Pvr_ControllerVisual : MonoBehaviour
{
	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ControllerDevice currentDevice;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Texture2D m_idle;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Texture2D m_app;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Texture2D m_home;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Texture2D m_touchpad;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Texture2D m_volUp;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D m_volDn;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Texture2D m_trigger;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Texture2D m_a;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Texture2D m_b;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Texture2D m_x;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Texture2D m_y;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Texture2D m_grip;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Renderer controllerRenderMat;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public ControllerVariety variety;

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x10A0894", Offset = "0x10A0894", VA = "0x10A0894")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x10A08EC", Offset = "0x10A08EC", VA = "0x10A08EC")]
	private void Start()
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x10A095C", Offset = "0x10A095C", VA = "0x10A095C")]
	private void Update()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x10A097C", Offset = "0x10A097C", VA = "0x10A097C")]
	private void ChangeKeyEffects(int hand)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x10A0CA8", Offset = "0x10A0CA8", VA = "0x10A0CA8")]
	public Pvr_ControllerVisual()
	{
	}
}
[Token(Token = "0x200000B")]
public class Pvr_ToolTips : MonoBehaviour
{
	[Token(Token = "0x2000136")]
	public enum TipBtn
	{
		[Token(Token = "0x4000A9D")]
		app,
		[Token(Token = "0x4000A9E")]
		touchpad,
		[Token(Token = "0x4000A9F")]
		home,
		[Token(Token = "0x4000AA0")]
		volup,
		[Token(Token = "0x4000AA1")]
		voldown,
		[Token(Token = "0x4000AA2")]
		trigger,
		[Token(Token = "0x4000AA3")]
		grip
	}

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ControllerDevice currentDevice;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float tipsAlpha;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Pvr_ToolTips tooltips;

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xD46078", Offset = "0xD46078", VA = "0xD46078")]
	public void ChangeTipsText(TipBtn tip, string key)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xD461F0", Offset = "0xD461F0", VA = "0xD461F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xD46268", Offset = "0xD46268", VA = "0xD46268")]
	private void Update()
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xD4646C", Offset = "0xD4646C", VA = "0xD4646C")]
	private void LoadTextFromJson()
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xD46A88", Offset = "0xD46A88", VA = "0xD46A88")]
	public static void RefreshTips()
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xD46B2C", Offset = "0xD46B2C", VA = "0xD46B2C")]
	public Pvr_ToolTips()
	{
	}
}
[Token(Token = "0x200000C")]
public class Pvr_TouchPadScroll : MonoBehaviour
{
	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ScrollRect scrollRect;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool isHoving;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int mainHand;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private SwipeDirection direction;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector2 currPos;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector2 tarPos;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float lerpSpeed;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Transform tranViewport;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float ignoreDis;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Vector2 lastTouchDownPos;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Vector2 lastTouchUpPos;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool isTouching;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	private bool isClosed;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector2 vecOrigin;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector2 vecOriginNeo2;

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xD46B34", Offset = "0xD46B34", VA = "0xD46B34")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xD46BC4", Offset = "0xD46BC4", VA = "0xD46BC4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xD4705C", Offset = "0xD4705C", VA = "0xD4705C")]
	private bool IsControllerConnect()
	{
		return default(bool);
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xD46D0C", Offset = "0xD46D0C", VA = "0xD46D0C")]
	private void UpdateTargetPos()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xD47F70", Offset = "0xD47F70", VA = "0xD47F70")]
	private void ComputeTouchPos()
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xD482B4", Offset = "0xD482B4", VA = "0xD482B4")]
	private void ComputeRockerPos()
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xD48728", Offset = "0xD48728", VA = "0xD48728")]
	private bool VerifyNeo2TouchValid(Vector2 nowTouchPos)
	{
		return default(bool);
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xD46E58", Offset = "0xD46E58", VA = "0xD46E58")]
	private void UpdatePos()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xD47E94", Offset = "0xD47E94", VA = "0xD47E94")]
	private void ResetParameter()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xD46BF0", Offset = "0xD46BF0", VA = "0xD46BF0")]
	private void Process()
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xD48764", Offset = "0xD48764", VA = "0xD48764")]
	private bool IsHovering(Pvr_UIPointer pointer)
	{
		return default(bool);
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xD48950", Offset = "0xD48950", VA = "0xD48950")]
	private bool FindTree(Transform tran)
	{
		return default(bool);
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xD48A3C", Offset = "0xD48A3C", VA = "0xD48A3C")]
	public Pvr_TouchPadScroll()
	{
	}
}
[Token(Token = "0x200000D")]
public class Pvr_TouchVisual : MonoBehaviour
{
	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public ControllerDevice currentDevice;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[HideInInspector]
	public ControllerVariety variety;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshRenderer touchRenderer;

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xD48AF8", Offset = "0xD48AF8", VA = "0xD48AF8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xD48BA0", Offset = "0xD48BA0", VA = "0xD48BA0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xD48BC0", Offset = "0xD48BC0", VA = "0xD48BC0")]
	private void ChangeEffects(int hand)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xD48E90", Offset = "0xD48E90", VA = "0xD48E90")]
	public Pvr_TouchVisual()
	{
	}
}
[Token(Token = "0x200000E")]
public class DemoController : MonoBehaviour
{
	[Token(Token = "0x2000137")]
	public delegate void showLoadingEventHandler();

	[Token(Token = "0x2000138")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFCE8", Offset = "0x7FFCE8")]
	private sealed class <>c__DisplayClass12_0
	{
		[Token(Token = "0x4000AA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject btnObj;

		[Token(Token = "0x4000AA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DemoController <>4__this;

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0xBB6F58", Offset = "0xBB6F58", VA = "0xBB6F58")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0xBB7834", Offset = "0xBB7834", VA = "0xBB7834")]
		internal void <InitDelegate>b__0()
		{
		}
	}

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Callback callback;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject msg;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Pvr_UnitySDKManager picoVrManager;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string currentOrderID;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject loading;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject BG;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject InputPanel;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static showLoadingEventHandler showLoading;

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xBB67C4", Offset = "0xBB67C4", VA = "0xBB67C4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xBB6978", Offset = "0xBB6978", VA = "0xBB6978")]
	private void Start()
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xBB6DF4", Offset = "0xBB6DF4", VA = "0xBB6DF4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xBB6A3C", Offset = "0xBB6A3C", VA = "0xBB6A3C")]
	private void InitDelegate()
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xBB6F60", Offset = "0xBB6F60", VA = "0xBB6F60")]
	private void OnClick(GameObject btnObj)
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xBB72E8", Offset = "0xBB72E8", VA = "0xBB72E8")]
	public string getRamdomTestOrderID()
	{
		return null;
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0xBB7244", Offset = "0xBB7244", VA = "0xBB7244")]
	private void StartLoading()
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0xBB738C", Offset = "0xBB738C", VA = "0xBB738C")]
	public void StopLoading()
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0xBB749C", Offset = "0xBB749C", VA = "0xBB749C")]
	public void DoPayByCode()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0xBB775C", Offset = "0xBB775C", VA = "0xBB775C")]
	private bool VerifyLocalToken()
	{
		return default(bool);
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0xBB782C", Offset = "0xBB782C", VA = "0xBB782C")]
	public DemoController()
	{
	}
}
[Token(Token = "0x200000F")]
public class LoadingRatation : MonoBehaviour
{
	[Token(Token = "0x600012F")]
	[Address(RVA = "0xBBE838", Offset = "0xBBE838", VA = "0xBBE838")]
	private void Start()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0xBBE83C", Offset = "0xBBE83C", VA = "0xBBE83C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xBBE8B0", Offset = "0xBBE8B0", VA = "0xBBE8B0")]
	public LoadingRatation()
	{
	}
}
[Token(Token = "0x2000010")]
public class InputManager : MonoBehaviour
{
	[Token(Token = "0x2000139")]
	public delegate void doEnterEventHandler();

	[Token(Token = "0x200013A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFCF8", Offset = "0x7FFCF8")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000AA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject btnObj;

		[Token(Token = "0x4000AA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputManager <>4__this;

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0xBBDB98", Offset = "0xBBDB98", VA = "0xBBDB98")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0xBBE770", Offset = "0xBBE770", VA = "0xBBE770")]
		internal void <InitKeyBoard>b__0()
		{
		}
	}

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static doEnterEventHandler doEnter;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private StringBuilder sb;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ArrayList btnsName;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject enter;

	[Token(Token = "0x6000132")]
	[Address(RVA = "0xBBD2BC", Offset = "0xBBD2BC", VA = "0xBBD2BC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0xBBDB90", Offset = "0xBBDB90", VA = "0xBBDB90")]
	private void Start()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xBBDB94", Offset = "0xBBDB94", VA = "0xBBDB94")]
	private void Update()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xBBD2C0", Offset = "0xBBD2C0", VA = "0xBBD2C0")]
	private void InitKeyBoard()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xBBDBA0", Offset = "0xBBDBA0", VA = "0xBBDBA0")]
	private void OnClick(GameObject btnObj)
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xBBE5FC", Offset = "0xBBE5FC", VA = "0xBBE5FC")]
	private void EnterChar(string s)
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xBBDDD4", Offset = "0xBBDDD4", VA = "0xBBDDD4")]
	private void DoCapslock(bool IsUpper)
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0xBBE380", Offset = "0xBBE380", VA = "0xBBE380")]
	private void ClearBuffer()
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0xBBE6E8", Offset = "0xBBE6E8", VA = "0xBBE6E8")]
	public InputManager()
	{
	}
}
[Token(Token = "0x2000011")]
public class Callback : MonoBehaviour
{
	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string IS_SUCCESS;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static string MSG;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static string CODE;

	[Token(Token = "0x600013B")]
	[Address(RVA = "0xBB54C8", Offset = "0xBB54C8", VA = "0xBB54C8")]
	public void LoginCallback(string LoginInfo)
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0xBB5A6C", Offset = "0xBB5A6C", VA = "0xBB5A6C")]
	public void QueryOrPayCallback(string queryOrPayInfo)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0xBB5C7C", Offset = "0xBB5C7C", VA = "0xBB5C7C")]
	public void UserInfoCallback(string userInfo)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0xBB56D4", Offset = "0xBB56D4", VA = "0xBB56D4")]
	public void SetMassage(string massage)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xBB5D48", Offset = "0xBB5D48", VA = "0xBB5D48")]
	public GameObject GetCurrentGameObject()
	{
		return null;
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0xBB5D94", Offset = "0xBB5D94", VA = "0xBB5D94")]
	public void ActivityForResultCallback(string activity)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0xBB5EBC", Offset = "0xBB5EBC", VA = "0xBB5EBC")]
	public Callback()
	{
	}
}
[Token(Token = "0x2000012")]
public class CommonDic
{
	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static CommonDic dic;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Dictionary<string, string> mydic;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private string _app_ID;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string _app_Key;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string _user_token;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string _access_token;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string _open_id;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string _refresh_token;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string _expires_in;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string _user_info;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string _subject;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string _body;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string _order_id;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private string _total;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private string _goods_tag;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private string _notify_url;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private string _trade_type;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private string _pay_code;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private string _order_info;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private string _code;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private string _msg;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private string _merchant_ID;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private string _payKey;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private string _isSuucess;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private string _loginMsg;

	[Token(Token = "0x1700000C")]
	public string subject
	{
		[Token(Token = "0x6000147")]
		[Address(RVA = "0xBB6654", Offset = "0xBB6654", VA = "0xBB6654")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000148")]
		[Address(RVA = "0xBB665C", Offset = "0xBB665C", VA = "0xBB665C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public string body
	{
		[Token(Token = "0x6000149")]
		[Address(RVA = "0xBB6664", Offset = "0xBB6664", VA = "0xBB6664")]
		get
		{
			return null;
		}
		[Token(Token = "0x600014A")]
		[Address(RVA = "0xBB666C", Offset = "0xBB666C", VA = "0xBB666C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public string order_id
	{
		[Token(Token = "0x600014B")]
		[Address(RVA = "0xBB6674", Offset = "0xBB6674", VA = "0xBB6674")]
		get
		{
			return null;
		}
		[Token(Token = "0x600014C")]
		[Address(RVA = "0xBB667C", Offset = "0xBB667C", VA = "0xBB667C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public string total
	{
		[Token(Token = "0x600014D")]
		[Address(RVA = "0xBB6684", Offset = "0xBB6684", VA = "0xBB6684")]
		get
		{
			return null;
		}
		[Token(Token = "0x600014E")]
		[Address(RVA = "0xBB668C", Offset = "0xBB668C", VA = "0xBB668C")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public string goods_tag
	{
		[Token(Token = "0x600014F")]
		[Address(RVA = "0xBB6694", Offset = "0xBB6694", VA = "0xBB6694")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000150")]
		[Address(RVA = "0xBB669C", Offset = "0xBB669C", VA = "0xBB669C")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public string notify_url
	{
		[Token(Token = "0x6000151")]
		[Address(RVA = "0xBB66A4", Offset = "0xBB66A4", VA = "0xBB66A4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000152")]
		[Address(RVA = "0xBB66AC", Offset = "0xBB66AC", VA = "0xBB66AC")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public string pay_code
	{
		[Token(Token = "0x6000153")]
		[Address(RVA = "0xBB66B4", Offset = "0xBB66B4", VA = "0xBB66B4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000154")]
		[Address(RVA = "0xBB66BC", Offset = "0xBB66BC", VA = "0xBB66BC")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public string trade_type
	{
		[Token(Token = "0x6000155")]
		[Address(RVA = "0xBB66C4", Offset = "0xBB66C4", VA = "0xBB66C4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000156")]
		[Address(RVA = "0xBB66CC", Offset = "0xBB66CC", VA = "0xBB66CC")]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public string user_token
	{
		[Token(Token = "0x6000157")]
		[Address(RVA = "0xBB66D4", Offset = "0xBB66D4", VA = "0xBB66D4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000158")]
		[Address(RVA = "0xBB66DC", Offset = "0xBB66DC", VA = "0xBB66DC")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public string access_token
	{
		[Token(Token = "0x6000159")]
		[Address(RVA = "0xBB66E4", Offset = "0xBB66E4", VA = "0xBB66E4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600015A")]
		[Address(RVA = "0xBB66EC", Offset = "0xBB66EC", VA = "0xBB66EC")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public string open_id
	{
		[Token(Token = "0x600015B")]
		[Address(RVA = "0xBB66F4", Offset = "0xBB66F4", VA = "0xBB66F4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600015C")]
		[Address(RVA = "0xBB66FC", Offset = "0xBB66FC", VA = "0xBB66FC")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public string refresh_token
	{
		[Token(Token = "0x600015D")]
		[Address(RVA = "0xBB6704", Offset = "0xBB6704", VA = "0xBB6704")]
		get
		{
			return null;
		}
		[Token(Token = "0x600015E")]
		[Address(RVA = "0xBB670C", Offset = "0xBB670C", VA = "0xBB670C")]
		set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public string expires_in
	{
		[Token(Token = "0x600015F")]
		[Address(RVA = "0xBB6714", Offset = "0xBB6714", VA = "0xBB6714")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000160")]
		[Address(RVA = "0xBB671C", Offset = "0xBB671C", VA = "0xBB671C")]
		set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public string isSuccess
	{
		[Token(Token = "0x6000161")]
		[Address(RVA = "0xBB6724", Offset = "0xBB6724", VA = "0xBB6724")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000162")]
		[Address(RVA = "0xBB672C", Offset = "0xBB672C", VA = "0xBB672C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public string loginMsg
	{
		[Token(Token = "0x6000163")]
		[Address(RVA = "0xBB6734", Offset = "0xBB6734", VA = "0xBB6734")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000164")]
		[Address(RVA = "0xBB673C", Offset = "0xBB673C", VA = "0xBB673C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public string user_info
	{
		[Token(Token = "0x6000165")]
		[Address(RVA = "0xBB6744", Offset = "0xBB6744", VA = "0xBB6744")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000166")]
		[Address(RVA = "0xBB674C", Offset = "0xBB674C", VA = "0xBB674C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public string order_info
	{
		[Token(Token = "0x6000167")]
		[Address(RVA = "0xBB6754", Offset = "0xBB6754", VA = "0xBB6754")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000168")]
		[Address(RVA = "0xBB675C", Offset = "0xBB675C", VA = "0xBB675C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001D")]
	public string code
	{
		[Token(Token = "0x6000169")]
		[Address(RVA = "0xBB6764", Offset = "0xBB6764", VA = "0xBB6764")]
		get
		{
			return null;
		}
		[Token(Token = "0x600016A")]
		[Address(RVA = "0xBB676C", Offset = "0xBB676C", VA = "0xBB676C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001E")]
	public string msg
	{
		[Token(Token = "0x600016B")]
		[Address(RVA = "0xBB6774", Offset = "0xBB6774", VA = "0xBB6774")]
		get
		{
			return null;
		}
		[Token(Token = "0x600016C")]
		[Address(RVA = "0xBB677C", Offset = "0xBB677C", VA = "0xBB677C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001F")]
	public string app_ID
	{
		[Token(Token = "0x600016D")]
		[Address(RVA = "0xBB6784", Offset = "0xBB6784", VA = "0xBB6784")]
		get
		{
			return null;
		}
		[Token(Token = "0x600016E")]
		[Address(RVA = "0xBB678C", Offset = "0xBB678C", VA = "0xBB678C")]
		set
		{
		}
	}

	[Token(Token = "0x17000020")]
	public string app_Key
	{
		[Token(Token = "0x600016F")]
		[Address(RVA = "0xBB6794", Offset = "0xBB6794", VA = "0xBB6794")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000170")]
		[Address(RVA = "0xBB679C", Offset = "0xBB679C", VA = "0xBB679C")]
		set
		{
		}
	}

	[Token(Token = "0x17000021")]
	public string merchant_ID
	{
		[Token(Token = "0x6000171")]
		[Address(RVA = "0xBB67A4", Offset = "0xBB67A4", VA = "0xBB67A4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000172")]
		[Address(RVA = "0xBB67AC", Offset = "0xBB67AC", VA = "0xBB67AC")]
		set
		{
		}
	}

	[Token(Token = "0x17000022")]
	public string paykey
	{
		[Token(Token = "0x6000173")]
		[Address(RVA = "0xBB67B4", Offset = "0xBB67B4", VA = "0xBB67B4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000174")]
		[Address(RVA = "0xBB67BC", Offset = "0xBB67BC", VA = "0xBB67BC")]
		set
		{
		}
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0xBB59A8", Offset = "0xBB59A8", VA = "0xBB59A8")]
	public static CommonDic getInstance()
	{
		return null;
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xBB643C", Offset = "0xBB643C", VA = "0xBB643C")]
	public Dictionary<string, string> getDic()
	{
		return null;
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0xBB648C", Offset = "0xBB648C", VA = "0xBB648C")]
	public void setParameters(string name, string value)
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0xBB65E4", Offset = "0xBB65E4", VA = "0xBB65E4")]
	public string PayOrderString()
	{
		return null;
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0xBB5FB8", Offset = "0xBB5FB8", VA = "0xBB5FB8")]
	public static void InitDicData(Dictionary<string, string> mydic)
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0xBB5F4C", Offset = "0xBB5F4C", VA = "0xBB5F4C")]
	public CommonDic()
	{
	}
}
[Token(Token = "0x2000013")]
public class LoginSDK
{
	[Token(Token = "0x6000177")]
	[Address(RVA = "0xBB7288", Offset = "0xBB7288", VA = "0xBB7288")]
	public static void Login()
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0xBB732C", Offset = "0xBB732C", VA = "0xBB732C")]
	public static void GetUserAPI()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0xBBE8B8", Offset = "0xBBE8B8", VA = "0xBBE8B8")]
	public LoginSDK()
	{
	}
}
[Token(Token = "0x2000014")]
public class PicoPaymentSDK
{
	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static AndroidJavaObject _jo;

	[Token(Token = "0x17000023")]
	public static AndroidJavaObject jo
	{
		[Token(Token = "0x600017A")]
		[Address(RVA = "0xE3897C", Offset = "0xE3897C", VA = "0xE3897C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600017B")]
		[Address(RVA = "0xE389E4", Offset = "0xE389E4", VA = "0xE389E4")]
		set
		{
		}
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0xE38A50", Offset = "0xE38A50", VA = "0xE38A50")]
	public static void Login()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0xE38CBC", Offset = "0xE38CBC", VA = "0xE38CBC")]
	public static void Pay(string payOrderJson)
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0xE38EE4", Offset = "0xE38EE4", VA = "0xE38EE4")]
	public static void QueryOrder(string orderId)
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0xE3910C", Offset = "0xE3910C", VA = "0xE3910C")]
	public static void GetUserAPI()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0xE39378", Offset = "0xE39378", VA = "0xE39378")]
	public PicoPaymentSDK()
	{
	}
}
[Token(Token = "0x2000015")]
public class PLOG : MonoBehaviour
{
	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int logLevel;

	[Token(Token = "0x6000182")]
	[Address(RVA = "0xE38298", Offset = "0xE38298", VA = "0xE38298")]
	public static void getConfigTraceLevel()
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0xE38304", Offset = "0xE38304", VA = "0xE38304")]
	public static void D(string msg)
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0xE383AC", Offset = "0xE383AC", VA = "0xE383AC")]
	public static void I(string msg)
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0xE38454", Offset = "0xE38454", VA = "0xE38454")]
	public static void W(string msg)
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0xE384FC", Offset = "0xE384FC", VA = "0xE384FC")]
	public static void E(string msg)
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0xE38564", Offset = "0xE38564", VA = "0xE38564")]
	public PLOG()
	{
	}
}
[Token(Token = "0x2000016")]
public class PicoDevice : MonoBehaviour
{
	[Token(Token = "0x200013B")]
	public enum DeviceType
	{
		[Token(Token = "0x4000AA9")]
		HMD,
		[Token(Token = "0x4000AAA")]
		LeftController,
		[Token(Token = "0x4000AAB")]
		RightController
	}

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public DeviceType deviceType;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Vector3 devicePos;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Quaternion deviceRot;

	[Token(Token = "0x6000189")]
	[Address(RVA = "0xE38570", Offset = "0xE38570", VA = "0xE38570")]
	private void Awake()
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0xE38790", Offset = "0xE38790", VA = "0xE38790")]
	private void Update()
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0xE3896C", Offset = "0xE3896C", VA = "0xE3896C")]
	public PicoDevice()
	{
	}
}
[Token(Token = "0x2000017")]
public class CPicoSDKSettingAsset : ScriptableObject
{
	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool IgnoreSDKSetting;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool DontshowBuildWaring;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool AppIDChecked;

	[Token(Token = "0x600018C")]
	[Address(RVA = "0xBB54C0", Offset = "0xBB54C0", VA = "0xBB54C0")]
	public CPicoSDKSettingAsset()
	{
	}
}
[Serializable]
[Token(Token = "0x2000018")]
public class Pvr_UnitySDKProjectSetting : ScriptableObject
{
	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RenderTextureAntiAliasing rtAntiAlising;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public RenderTextureDepth rtBitDepth;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RenderTextureFormat rtFormat;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool usedefaultRenderTexture;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 customRTSize;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool usedefaultfps;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int customfps;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool usesinglepass;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool usecontentprotect;

	[Token(Token = "0x600018D")]
	[Address(RVA = "0xE79288", Offset = "0xE79288", VA = "0xE79288")]
	public static Pvr_UnitySDKProjectSetting GetProjectConfig()
	{
		return null;
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0xE80624", Offset = "0xE80624", VA = "0xE80624")]
	public Pvr_UnitySDKProjectSetting()
	{
	}
}
[Token(Token = "0x2000019")]
public sealed class Pvr_UnitySDKPlatformSetting : ScriptableObject
{
	[Token(Token = "0x200013C")]
	public enum simulationType
	{
		[Token(Token = "0x4000AAD")]
		Null,
		[Token(Token = "0x4000AAE")]
		Invalid,
		[Token(Token = "0x4000AAF")]
		Valid
	}

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool entitlementchecksimulation;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[SerializeField]
	private bool startTimeEntitlementCheck;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public string appID;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<string> deviceSN;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Pvr_UnitySDKPlatformSetting instance;

	[Token(Token = "0x17000024")]
	public static bool Entitlementchecksimulation
	{
		[Token(Token = "0x600018F")]
		[Address(RVA = "0xE7F998", Offset = "0xE7F998", VA = "0xE7F998")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000190")]
		[Address(RVA = "0xE7F9B8", Offset = "0xE7F9B8", VA = "0xE7F9B8")]
		set
		{
		}
	}

	[Token(Token = "0x17000025")]
	public static bool StartTimeEntitlementCheck
	{
		[Token(Token = "0x6000191")]
		[Address(RVA = "0xE7F600", Offset = "0xE7F600", VA = "0xE7F600")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000192")]
		[Address(RVA = "0xE7FA04", Offset = "0xE7FA04", VA = "0xE7FA04")]
		set
		{
		}
	}

	[Token(Token = "0x17000026")]
	public static Pvr_UnitySDKPlatformSetting Instance
	{
		[Token(Token = "0x6000193")]
		[Address(RVA = "0xE7F620", Offset = "0xE7F620", VA = "0xE7F620")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000194")]
		[Address(RVA = "0xE7FA50", Offset = "0xE7FA50", VA = "0xE7FA50")]
		set
		{
		}
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0xE7FAA4", Offset = "0xE7FAA4", VA = "0xE7FAA4")]
	public Pvr_UnitySDKPlatformSetting()
	{
	}
}
[Token(Token = "0x200001A")]
public class Pvr_UnitySDKManager : MonoBehaviour
{
	[Token(Token = "0x200013D")]
	public delegate void EntitlementCheckResult(int ReturnValue);

	[Token(Token = "0x200013E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFD08", Offset = "0x7FFD08")]
	private sealed class <ToastManager>d__97 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000AB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000AB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000AB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float time;

		[Token(Token = "0x4000AB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int type;

		[Token(Token = "0x4000AB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Pvr_UnitySDKManager <>4__this;

		[Token(Token = "0x4000AB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool state;

		[Token(Token = "0x170000E1")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60009B7")]
			[Address(RVA = "0xE7F880", Offset = "0xE7F880", VA = "0xE7F880", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E2")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009B9")]
			[Address(RVA = "0xE7F8E8", Offset = "0xE7F8E8", VA = "0xE7F8E8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0xE7A6AC", Offset = "0xE7A6AC", VA = "0xE7A6AC")]
		[DebuggerHidden]
		public <ToastManager>d__97(int <>1__state)
		{
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0xE7F748", Offset = "0xE7F748", VA = "0xE7F748", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0xE7F74C", Offset = "0xE7F74C", VA = "0xE7F74C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0xE7F888", Offset = "0xE7F888", VA = "0xE7F888", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200013F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFD18", Offset = "0x7FFD18")]
	private sealed class <>c__DisplayClass102_0
	{
		[Token(Token = "0x4000AB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Pvr_UnitySDKManager <>4__this;

		[Token(Token = "0x4000AB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform trans;

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0xE7BA8C", Offset = "0xE7BA8C", VA = "0xE7BA8C")]
		public <>c__DisplayClass102_0()
		{
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0xE7E764", Offset = "0xE7E764", VA = "0xE7E764")]
		internal void <SetProperty>b__0()
		{
		}
	}

	[Token(Token = "0x2000140")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFD28", Offset = "0x7FFD28")]
	private sealed class <G3TipsManager>d__106 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000AB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000AB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000ABA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float time;

		[Token(Token = "0x4000ABB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject tip;

		[Token(Token = "0x170000E3")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60009BF")]
			[Address(RVA = "0xE7E870", Offset = "0xE7E870", VA = "0xE7E870", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E4")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009C1")]
			[Address(RVA = "0xE7E8D8", Offset = "0xE7E8D8", VA = "0xE7E8D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0xE7BDC4", Offset = "0xE7BDC4", VA = "0xE7BDC4")]
		[DebuggerHidden]
		public <G3TipsManager>d__106(int <>1__state)
		{
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0xE7E7B4", Offset = "0xE7E7B4", VA = "0xE7E7B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0xE7E7B8", Offset = "0xE7E7B8", VA = "0xE7E7B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0xE7E878", Offset = "0xE7E878", VA = "0xE7E878", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000141")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFD38", Offset = "0x7FFD38")]
	private sealed class <Start>d__118 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000ABC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000ABD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000ABE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pvr_UnitySDKManager <>4__this;

		[Token(Token = "0x170000E5")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60009C5")]
			[Address(RVA = "0xE7F6D8", Offset = "0xE7F6D8", VA = "0xE7F6D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E6")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009C7")]
			[Address(RVA = "0xE7F740", Offset = "0xE7F740", VA = "0xE7F740", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0xE7DA38", Offset = "0xE7DA38", VA = "0xE7DA38")]
		[DebuggerHidden]
		public <Start>d__118(int <>1__state)
		{
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0xE7F3BC", Offset = "0xE7F3BC", VA = "0xE7F3BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0xE7F3C0", Offset = "0xE7F3C0", VA = "0xE7F3C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0xE7F6E0", Offset = "0xE7F6E0", VA = "0xE7F6E0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000142")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFD48", Offset = "0x7FFD48")]
	private sealed class <InitRenderThreadRoutine>d__119 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000ABF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000AC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000AC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int <i>5__2;

		[Token(Token = "0x170000E7")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60009CB")]
			[Address(RVA = "0xE7EBD8", Offset = "0xE7EBD8", VA = "0xE7EBD8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E8")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009CD")]
			[Address(RVA = "0xE7EC40", Offset = "0xE7EC40", VA = "0xE7EC40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0xE7DAC4", Offset = "0xE7DAC4", VA = "0xE7DAC4")]
		[DebuggerHidden]
		public <InitRenderThreadRoutine>d__119(int <>1__state)
		{
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0xE7E8E0", Offset = "0xE7E8E0", VA = "0xE7E8E0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0xE7E8E4", Offset = "0xE7E8E4", VA = "0xE7E8E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0xE7EBE0", Offset = "0xE7EBE0", VA = "0xE7EBE0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000143")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFD58", Offset = "0x7FFD58")]
	private sealed class <OnResume>d__132 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000AC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000AC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000AC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pvr_UnitySDKManager <>4__this;

		[Token(Token = "0x4000AC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <ability6dof>5__2;

		[Token(Token = "0x4000AC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int <waitNum>5__3;

		[Token(Token = "0x4000AC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <resetNum>5__4;

		[Token(Token = "0x4000AC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <i>5__5;

		[Token(Token = "0x170000E9")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60009D1")]
			[Address(RVA = "0xE7F34C", Offset = "0xE7F34C", VA = "0xE7F34C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EA")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009D3")]
			[Address(RVA = "0xE7F3B4", Offset = "0xE7F3B4", VA = "0xE7F3B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0xE7E654", Offset = "0xE7E654", VA = "0xE7E654")]
		[DebuggerHidden]
		public <OnResume>d__132(int <>1__state)
		{
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0xE7EC48", Offset = "0xE7EC48", VA = "0xE7EC48", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0xE7EC4C", Offset = "0xE7EC4C", VA = "0xE7EC4C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0xE7F354", Offset = "0xE7F354", VA = "0xE7F354", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static PlatForm platform;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Pvr_UnitySDKManager sdk;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public float EyesAspect;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[HideInInspector]
	public int posStatus;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public bool ismirroring;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[HideInInspector]
	public Vector3 resetBasePos;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public int trackingmode;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[HideInInspector]
	public int systemprop;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public bool systemFPS;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public float[] headData;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool rotfoldout;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	[SerializeField]
	private bool hmdOnlyrot;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	[SerializeField]
	private bool controllerOnlyrot;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private TrackingOrigin trackingOrigin;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool ResetTrackerOnLoad;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[HideInInspector]
	public Vector3 leftEyeOffset;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[HideInInspector]
	public Vector3 rightEyeOffset;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[HideInInspector]
	public Rect leftEyeRect;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[HideInInspector]
	public Rect rightEyeRect;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[HideInInspector]
	public Matrix4x4 leftEyeView;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	[HideInInspector]
	public Matrix4x4 rightEyeView;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[HideInInspector]
	public Pvr_UnitySDKEditor pvr_UnitySDKEditor;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[SerializeField]
	private bool vrModeEnabled;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	[HideInInspector]
	public Material Eyematerial;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	[HideInInspector]
	public Material Middlematerial;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800680", Offset = "0x800680")]
	private bool <picovrTriggered>k__BackingField;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x131")]
	[HideInInspector]
	public bool newPicovrTriggered;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x132")]
	[SerializeField]
	private bool showFPS;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	[HideInInspector]
	public Vector3 neckOffset;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	[SerializeField]
	private bool pVRNeck;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x141")]
	[HideInInspector]
	public bool UseCustomNeckPara;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x142")]
	[HideInInspector]
	public bool onResume;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x143")]
	[HideInInspector]
	public bool isEnterVRMode;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	public bool isHasController;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public Pvr_UnitySDKConfigProfile pvr_UnitySDKConfig;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private GameObject calltoast;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private GameObject msgtoast;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private GameObject lowhmdBatterytoast;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private GameObject lowphoneBatterytoast;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private GameObject LowPhoneHealthtoast;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private GameObject LowcontrollerBatterytoast;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private bool lowControllerpowerstate;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
	private float controllerpowershowtime;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private bool UseToast;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
	private int iPhoneHMDModeEnabled;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private GameObject G3LiteTips;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	[SerializeField]
	private bool monoscopic;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x199")]
	private bool mIsAndroid7;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static Func<bool> eventEnterVRMode;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19A")]
	[HideInInspector]
	public bool ShowVideoSeethrough;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
	public int SystemDebugFFRLevel;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public int SystemFFRLevel;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
	public int AppCheckResult;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public Action longPressHomeKeyAction;

	[Token(Token = "0x17000027")]
	public static Pvr_UnitySDKManager SDK
	{
		[Token(Token = "0x6000196")]
		[Address(RVA = "0xE70F70", Offset = "0xE70F70", VA = "0xE70F70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000028")]
	public bool Rotfoldout
	{
		[Token(Token = "0x6000197")]
		[Address(RVA = "0xE79190", Offset = "0xE79190", VA = "0xE79190")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000198")]
		[Address(RVA = "0xE79198", Offset = "0xE79198", VA = "0xE79198")]
		set
		{
		}
	}

	[Token(Token = "0x17000029")]
	public bool HmdOnlyrot
	{
		[Token(Token = "0x6000199")]
		[Address(RVA = "0xE791B8", Offset = "0xE791B8", VA = "0xE791B8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600019A")]
		[Address(RVA = "0xE791C0", Offset = "0xE791C0", VA = "0xE791C0")]
		set
		{
		}
	}

	[Token(Token = "0x1700002A")]
	public bool ControllerOnlyrot
	{
		[Token(Token = "0x600019B")]
		[Address(RVA = "0xE791E0", Offset = "0xE791E0", VA = "0xE791E0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600019C")]
		[Address(RVA = "0xE791E8", Offset = "0xE791E8", VA = "0xE791E8")]
		set
		{
		}
	}

	[Token(Token = "0x1700002B")]
	public TrackingOrigin TrackingOrigin
	{
		[Token(Token = "0x600019D")]
		[Address(RVA = "0xE79208", Offset = "0xE79208", VA = "0xE79208")]
		get
		{
			return default(TrackingOrigin);
		}
		[Token(Token = "0x600019E")]
		[Address(RVA = "0xE79210", Offset = "0xE79210", VA = "0xE79210")]
		set
		{
		}
	}

	[Token(Token = "0x1700002C")]
	[HideInInspector]
	public bool VRModeEnabled
	{
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xE79318", Offset = "0xE79318", VA = "0xE79318")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xE72080", Offset = "0xE72080", VA = "0xE72080")]
		set
		{
		}
	}

	[Token(Token = "0x1700002D")]
	[HideInInspector]
	public bool picovrTriggered
	{
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xE79320", Offset = "0xE79320", VA = "0xE79320")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801870", Offset = "0x801870")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xE79328", Offset = "0xE79328", VA = "0xE79328")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801880", Offset = "0x801880")]
		set
		{
		}
	}

	[Token(Token = "0x1700002E")]
	public bool ShowFPS
	{
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xE79334", Offset = "0xE79334", VA = "0xE79334")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xE7933C", Offset = "0xE7933C", VA = "0xE7933C")]
		set
		{
		}
	}

	[Token(Token = "0x1700002F")]
	public bool PVRNeck
	{
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xE7935C", Offset = "0xE7935C", VA = "0xE7935C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xE79364", Offset = "0xE79364", VA = "0xE79364")]
		set
		{
		}
	}

	[Token(Token = "0x17000030")]
	[HideInInspector]
	public bool Monoscopic
	{
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xE79384", Offset = "0xE79384", VA = "0xE79384")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xE7938C", Offset = "0xE7938C", VA = "0xE7938C")]
		set
		{
		}
	}

	[Token(Token = "0x14000015")]
	public static event EntitlementCheckResult EntitlementCheckResultEvent
	{
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xE793B8", Offset = "0xE793B8", VA = "0xE793B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801890", Offset = "0x801890")]
		add
		{
		}
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xE794A8", Offset = "0xE794A8", VA = "0xE794A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8018A0", Offset = "0x8018A0")]
		remove
		{
		}
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0xE79230", Offset = "0xE79230", VA = "0xE79230")]
	public void ChangeDefaultCustomRtSize(int w, int h)
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0xE7346C", Offset = "0xE7346C", VA = "0xE7346C")]
	public Vector3 EyeOffset(Eye eye)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0xE792DC", Offset = "0xE792DC", VA = "0xE792DC")]
	public Rect EyeRect(Eye eye)
	{
		return default(Rect);
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0xE79598", Offset = "0xE79598", VA = "0xE79598")]
	private bool SDKManagerInit()
	{
		return default(bool);
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0xE796E8", Offset = "0xE796E8", VA = "0xE796E8")]
	private bool SDKManagerInitCoreAbility()
	{
		return default(bool);
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0xE79820", Offset = "0xE79820", VA = "0xE79820")]
	public void smsReceivedCallback(string msg)
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0xE79F40", Offset = "0xE79F40", VA = "0xE79F40")]
	public void phoneStateCallback(string state)
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0xE7A2C0", Offset = "0xE7A2C0", VA = "0xE7A2C0")]
	public void phoneBatteryStateCallback(string state)
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0xE7A570", Offset = "0xE7A570", VA = "0xE7A570")]
	public void hmdLowBatteryCallback(string level)
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0xE79BA0", Offset = "0xE79BA0", VA = "0xE79BA0")]
	private string TransformNumber(string number)
	{
		return null;
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0xE7A6A8", Offset = "0xE7A6A8", VA = "0xE7A6A8")]
	public void onHmdOrientationReseted()
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0xE79EA4", Offset = "0xE79EA4", VA = "0xE79EA4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8018B0", Offset = "0x8018B0")]
	private IEnumerator ToastManager(int type, bool state, float time)
	{
		return null;
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0xE7A6D8", Offset = "0xE7A6D8", VA = "0xE7A6D8")]
	private void CheckControllerStateForG2(string state)
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0xE7A884", Offset = "0xE7A884", VA = "0xE7A884")]
	public void notificationCallback(string data)
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0xE7B7FC", Offset = "0xE7B7FC", VA = "0xE7B7FC")]
	private Sprite LoadSprite(Vector2 size, string filepath)
	{
		return null;
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0xE7B948", Offset = "0xE7B948", VA = "0xE7B948")]
	private byte[] ReadTex(string path)
	{
		return null;
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0xE7AC0C", Offset = "0xE7AC0C", VA = "0xE7AC0C")]
	private void SetProperty(int type, JsonData data, string value)
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0xE7B108", Offset = "0xE7B108", VA = "0xE7B108")]
	private void SetBaseProperty(Transform trans, JsonData data, string value)
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0xE7B4E4", Offset = "0xE7B4E4", VA = "0xE7B4E4")]
	private void SetImageProperty(Transform image, JsonData data, string value)
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0xE7BA94", Offset = "0xE7BA94", VA = "0xE7BA94")]
	private void SetTextProperty(Transform text, JsonData data, string value)
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0xE7B77C", Offset = "0xE7B77C", VA = "0xE7B77C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x801914", Offset = "0x801914")]
	private IEnumerator G3TipsManager(GameObject tip, float time)
	{
		return null;
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0xE7BD48", Offset = "0xE7BD48", VA = "0xE7BD48")]
	private float JsonToFloat(JsonData data)
	{
		return default(float);
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0xE7BDF0", Offset = "0xE7BDF0", VA = "0xE7BDF0")]
	private bool SDKManagerInitFPS()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0xE79674", Offset = "0xE79674", VA = "0xE79674")]
	private bool SDKManagerInitConfigProfile()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0xE7BFAC", Offset = "0xE7BFAC", VA = "0xE7BFAC")]
	private bool SDKManagerInitEditor()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0xE7C058", Offset = "0xE7C058", VA = "0xE7C058")]
	private bool SDKManagerInitPara()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0xE7C060", Offset = "0xE7C060", VA = "0xE7C060")]
	public void SDKManagerLongHomeKey()
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0xE7C15C", Offset = "0xE7C15C", VA = "0xE7C15C")]
	private void setLongHomeKey()
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0xE7C530", Offset = "0xE7C530", VA = "0xE7C530")]
	public void verifyAPPCallback(string code)
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0xE7C8C8", Offset = "0xE7C8C8", VA = "0xE7C8C8")]
	public void IpdRefreshCallBack(string ipd)
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0xE7C9F8", Offset = "0xE7C9F8", VA = "0xE7C9F8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0xE7D9C8", Offset = "0xE7D9C8", VA = "0xE7D9C8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x801978", Offset = "0x801978")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0xE7DA64", Offset = "0xE7DA64", VA = "0xE7DA64")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8019DC", Offset = "0x8019DC")]
	private IEnumerator InitRenderThreadRoutine()
	{
		return null;
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0xE7DAF0", Offset = "0xE7DAF0", VA = "0xE7DAF0")]
	private void Update()
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0xE7DDBC", Offset = "0xE7DDBC", VA = "0xE7DDBC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0xE7DF1C", Offset = "0xE7DF1C", VA = "0xE7DF1C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0xE7E04C", Offset = "0xE7E04C", VA = "0xE7E04C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0xE7E054", Offset = "0xE7E054", VA = "0xE7E054")]
	private void OnPause()
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0xE7E2B0", Offset = "0xE7E2B0", VA = "0xE7E2B0")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0xE7E55C", Offset = "0xE7E55C", VA = "0xE7E55C")]
	public void EnterVRMode()
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0xE7E0FC", Offset = "0xE7E0FC", VA = "0xE7E0FC")]
	public void LeaveVRMode()
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0xE7E64C", Offset = "0xE7E64C", VA = "0xE7E64C")]
	public void SixDofForceQuit()
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0xE7D404", Offset = "0xE7D404", VA = "0xE7D404")]
	private void InitUI()
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0xE7D600", Offset = "0xE7D600", VA = "0xE7D600")]
	private void RefreshTextByLanguage()
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0xE7D02C", Offset = "0xE7D02C", VA = "0xE7D02C")]
	private void LoadIsMirroringValue()
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0xE7E4EC", Offset = "0xE7E4EC", VA = "0xE7E4EC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x801A40", Offset = "0x801A40")]
	private IEnumerator OnResume()
	{
		return null;
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0xE7E680", Offset = "0xE7E680", VA = "0xE7E680")]
	public Pvr_UnitySDKManager()
	{
	}
}
[Token(Token = "0x200001B")]
public class QuitGame : MonoBehaviour
{
	[Token(Token = "0x60001DB")]
	[Address(RVA = "0xB1B360", Offset = "0xB1B360", VA = "0xB1B360")]
	private void Start()
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0xB1B364", Offset = "0xB1B364", VA = "0xB1B364")]
	private void Update()
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0xB1B390", Offset = "0xB1B390", VA = "0xB1B390")]
	public QuitGame()
	{
	}
}
[Token(Token = "0x200001C")]
public class Pvr_UnityEyeMask : MonoBehaviour
{
	[Token(Token = "0x2000144")]
	private class EyeMaskData
	{
		[Token(Token = "0x4000AC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Eye eyeSide;

		[Token(Token = "0x4000ACA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera camera;

		[Token(Token = "0x4000ACB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CommandBuffer cmdBuf;

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0xD4E0E4", Offset = "0xD4E0E4", VA = "0xD4E0E4")]
		public EyeMaskData()
		{
		}
	}

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Shader eyeMaskShader;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Material eyeMaskMaterial;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Mesh eyeMaskMeshLeft;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Mesh eyeMaskMeshRight;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Mesh eyeMaskMeshBoth;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float zDir;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Color eyeMaskColor;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<EyeMaskData> cameraDataList;

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0xD4C80C", Offset = "0xD4C80C", VA = "0xD4C80C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0xD4C8C4", Offset = "0xD4C8C4", VA = "0xD4C8C4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0xD4D41C", Offset = "0xD4D41C", VA = "0xD4D41C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0xD4CE58", Offset = "0xD4CE58", VA = "0xD4CE58")]
	private void CreateCommandBuffer()
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0xD4DF18", Offset = "0xD4DF18", VA = "0xD4DF18")]
	private void OnCustomPreRender(Camera cam)
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0xD4D790", Offset = "0xD4D790", VA = "0xD4D790")]
	private Mesh GetStencilMesh(Eye eyeSide)
	{
		return null;
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0xD4DAE4", Offset = "0xD4DAE4", VA = "0xD4DAE4")]
	private Mesh GetStencilMeshBoth(Mesh leftMesh, Mesh rightMesh)
	{
		return null;
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0xD4D680", Offset = "0xD4D680", VA = "0xD4D680")]
	private bool VerifyCommadBuffer()
	{
		return default(bool);
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0xD4CB18", Offset = "0xD4CB18", VA = "0xD4CB18")]
	private void PrepareCameras()
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0xD4E0B4", Offset = "0xD4E0B4", VA = "0xD4E0B4")]
	private void AddCameraCommandBuffer(EyeMaskData data)
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0xD4D5E8", Offset = "0xD4D5E8", VA = "0xD4D5E8")]
	private void RemoveCameraCommandBuffer(EyeMaskData data)
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0xD4D614", Offset = "0xD4D614", VA = "0xD4D614")]
	private void CleanEyeMask()
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0xD4E0EC", Offset = "0xD4E0EC", VA = "0xD4E0EC")]
	public Pvr_UnityEyeMask()
	{
	}
}
[Token(Token = "0x200001D")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7FFA08", Offset = "0x7FFA08")]
public class Pvr_UnitySDKEye : MonoBehaviour
{
	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<Pvr_UnitySDKEye> Instances;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Eye eyeSide;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800730", Offset = "0x800730")]
	private Camera <eyecamera>k__BackingField;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int eyeCameraOriginCullingMask;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private CameraClearFlags eyeCameraOriginClearFlag;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Color eyeCameraOriginBackgroundColor;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int lastBoundaryState;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Matrix4x4 realProj;

	[Token(Token = "0x4000146")]
	private const int bufferSize = 3;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private int IDIndex;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private RenderEventType eventType;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private int previousId;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static bool setLevel;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Material mat_Vignette;

	[Token(Token = "0x17000031")]
	public Camera eyecamera
	{
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xE7213C", Offset = "0xE7213C", VA = "0xE7213C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801AA4", Offset = "0x801AA4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xE72144", Offset = "0xE72144", VA = "0xE72144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801AB4", Offset = "0x801AB4")]
		private set
		{
		}
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0xE7214C", Offset = "0xE7214C", VA = "0xE7214C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0xE721EC", Offset = "0xE721EC", VA = "0xE721EC")]
	private void Start()
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0xE72740", Offset = "0xE72740", VA = "0xE72740")]
	private void Update()
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0xE72974", Offset = "0xE72974", VA = "0xE72974")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0xE72A9C", Offset = "0xE72A9C", VA = "0xE72A9C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0xE72BC4", Offset = "0xE72BC4", VA = "0xE72BC4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0xE72C48", Offset = "0xE72C48", VA = "0xE72C48")]
	public void MyPreRender(Camera camera)
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0xE72E30", Offset = "0xE72E30", VA = "0xE72E30")]
	public void MyPreRender(ScriptableRenderContext context, Camera camera)
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0xE72EF0", Offset = "0xE72EF0", VA = "0xE72EF0")]
	public void MyPostRender(ScriptableRenderContext context, Camera camera)
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0xE72D08", Offset = "0xE72D08", VA = "0xE72D08")]
	private void OnPreRender()
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0xE72FB0", Offset = "0xE72FB0", VA = "0xE72FB0")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0xE732FC", Offset = "0xE732FC", VA = "0xE732FC")]
	public void EyeRender()
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0xE722C4", Offset = "0xE722C4", VA = "0xE722C4")]
	private void Setup(Eye eyeSide)
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0xE724D0", Offset = "0xE724D0", VA = "0xE724D0")]
	private void SetupUpdate()
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0xE734A4", Offset = "0xE734A4", VA = "0xE734A4")]
	public void RefreshCameraPosition(float ipd)
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0xE73648", Offset = "0xE73648", VA = "0xE73648")]
	private void DrawVignetteLine()
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0xE73774", Offset = "0xE73774", VA = "0xE73774")]
	private void vignette()
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0xE73150", Offset = "0xE73150", VA = "0xE73150")]
	private void SetFFRParameter()
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0xE73AEC", Offset = "0xE73AEC", VA = "0xE73AEC")]
	public Pvr_UnitySDKEye()
	{
	}
}
[Token(Token = "0x200001E")]
public class Pvr_UnitySDKEyeManager : MonoBehaviour
{
	[Token(Token = "0x2000145")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFD68", Offset = "0x7FFD68")]
	private sealed class <EndOfFrame>d__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000ACC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000ACD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000ACE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pvr_UnitySDKEyeManager <>4__this;

		[Token(Token = "0x170000EB")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60009D8")]
			[Address(RVA = "0xE779C0", Offset = "0xE779C0", VA = "0xE779C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EC")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009DA")]
			[Address(RVA = "0xE77A28", Offset = "0xE77A28", VA = "0xE77A28", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0xE75B60", Offset = "0xE75B60", VA = "0xE75B60")]
		[DebuggerHidden]
		public <EndOfFrame>d__42(int <>1__state)
		{
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0xE768C8", Offset = "0xE768C8", VA = "0xE768C8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0xE768CC", Offset = "0xE768CC", VA = "0xE768CC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0xE779C8", Offset = "0xE779C8", VA = "0xE779C8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000146")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFD78", Offset = "0x7FFD78")]
	private sealed class <ScreenFade>d__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000ACF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000AD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000AD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pvr_UnitySDKEyeManager <>4__this;

		[Token(Token = "0x4000AD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float startAlpha;

		[Token(Token = "0x4000AD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float endAlpha;

		[Token(Token = "0x4000AD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x170000ED")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60009DE")]
			[Address(RVA = "0xE77B64", Offset = "0xE77B64", VA = "0xE77B64", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EE")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009E0")]
			[Address(RVA = "0xE77BCC", Offset = "0xE77BCC", VA = "0xE77BCC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0xE76814", Offset = "0xE76814", VA = "0xE76814")]
		[DebuggerHidden]
		public <ScreenFade>d__65(int <>1__state)
		{
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0xE77A30", Offset = "0xE77A30", VA = "0xE77A30", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0xE77A34", Offset = "0xE77A34", VA = "0xE77A34", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0xE77B6C", Offset = "0xE77B6C", VA = "0xE77B6C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Pvr_UnitySDKEyeManager instance;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Pvr_UnitySDKEye[] eyes;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public Camera LeftEyeCamera;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public Camera RightEyeCamera;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Camera MonoEyeCamera;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public Camera BothEyeCamera;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int MonoEyeTextureID;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private readonly int WaitSplashScreenFrames;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int frameNum;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[HideInInspector]
	private bool foveatedRendering;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	[HideInInspector]
	private EFoveationLevel foveationLevel;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private int eyeTextureId;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private RenderEventType eventType;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Pvr_UnitySDKEyeOverlay compositeLayer;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int overlayLayerDepth;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int underlayLayerDepth;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool isHeadLocked;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int layerFlags;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[HideInInspector]
	public bool EyeTracking;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[HideInInspector]
	public Vector3 eyePoint;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private EyeTrackingData eyePoseData;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[HideInInspector]
	public static bool supportEyeTracking;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x800820", Offset = "0x800820")]
	public bool screenFade;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x800858", Offset = "0x800858")]
	public float fadeTime;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x800890", Offset = "0x800890")]
	public Color fadeColor;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public int renderQueue;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private MeshRenderer fadeMeshRenderer;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private MeshFilter fadeMeshFilter;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private Material fadeMaterial;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private float elapsedTime;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	private bool isFading;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private float currentAlpha;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	private float nowFadeAlpha;

	[Token(Token = "0x17000032")]
	public static Pvr_UnitySDKEyeManager Instance
	{
		[Token(Token = "0x6000201")]
		[Address(RVA = "0xE739F4", Offset = "0xE739F4", VA = "0xE739F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000033")]
	public Pvr_UnitySDKEye[] Eyes
	{
		[Token(Token = "0x6000202")]
		[Address(RVA = "0xE73C04", Offset = "0xE73C04", VA = "0xE73C04")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000034")]
	[HideInInspector]
	public bool FoveatedRendering
	{
		[Token(Token = "0x6000203")]
		[Address(RVA = "0xE73C94", Offset = "0xE73C94", VA = "0xE73C94")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000204")]
		[Address(RVA = "0xE73C9C", Offset = "0xE73C9C", VA = "0xE73C9C")]
		set
		{
		}
	}

	[Token(Token = "0x17000035")]
	[HideInInspector]
	public EFoveationLevel FoveationLevel
	{
		[Token(Token = "0x6000205")]
		[Address(RVA = "0xE73D08", Offset = "0xE73D08", VA = "0xE73D08")]
		get
		{
			return default(EFoveationLevel);
		}
		[Token(Token = "0x6000206")]
		[Address(RVA = "0xE73D10", Offset = "0xE73D10", VA = "0xE73D10")]
		set
		{
		}
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0xE73D24", Offset = "0xE73D24", VA = "0xE73D24")]
	private void SetCameraEnableEditor()
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0xE73F34", Offset = "0xE73F34", VA = "0xE73F34")]
	private void SetCamerasEnableByStereoRendering()
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0xE73FF4", Offset = "0xE73FF4", VA = "0xE73FF4")]
	private void SetupMonoCamera()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0xE74108", Offset = "0xE74108", VA = "0xE74108")]
	private void SetupUpdate()
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0xE741DC", Offset = "0xE741DC", VA = "0xE741DC")]
	private void MonoEyeRender()
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0xE7434C", Offset = "0xE7434C", VA = "0xE7434C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0xE74AFC", Offset = "0xE74AFC", VA = "0xE74AFC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0xE75378", Offset = "0xE75378", VA = "0xE75378")]
	private void Start()
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0xE7539C", Offset = "0xE7539C", VA = "0xE7539C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0xE755F0", Offset = "0xE755F0", VA = "0xE755F0")]
	private void OnPause()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0xE756D4", Offset = "0xE756D4", VA = "0xE756D4")]
	public void MyPostRender(ScriptableRenderContext context, Camera camera)
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0xE75890", Offset = "0xE75890", VA = "0xE75890")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0xE75988", Offset = "0xE75988", VA = "0xE75988")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0xE75790", Offset = "0xE75790", VA = "0xE75790")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0xE75AF0", Offset = "0xE75AF0", VA = "0xE75AF0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x801AC4", Offset = "0x801AC4")]
	private IEnumerator EndOfFrame()
	{
		return null;
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0xE75B8C", Offset = "0xE75B8C", VA = "0xE75B8C")]
	private void CreateExternalSurface(Pvr_UnitySDKEyeOverlay overlayInstance, int layerDepth)
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0xE75F78", Offset = "0xE75F78", VA = "0xE75F78")]
	public bool SetEyeTrackingMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0xE76238", Offset = "0xE76238", VA = "0xE76238")]
	public Vector3 GetEyeTrackingPos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0xE76468", Offset = "0xE76468", VA = "0xE76468")]
	private EyeDeviceInfo GetDeviceInfo()
	{
		return default(EyeDeviceInfo);
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0xE74690", Offset = "0xE74690", VA = "0xE74690")]
	private void CreateFadeMesh()
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0xE7598C", Offset = "0xE7598C", VA = "0xE7598C")]
	private void DestoryFadeMesh()
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0xE74AF4", Offset = "0xE74AF4", VA = "0xE74AF4")]
	public void SetCurrentAlpha(float alpha)
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0xE752F4", Offset = "0xE752F4", VA = "0xE752F4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x801B28", Offset = "0x801B28")]
	private IEnumerator ScreenFade(float startAlpha, float endAlpha)
	{
		return null;
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0xE766BC", Offset = "0xE766BC", VA = "0xE766BC")]
	private void SetMaterialAlpha()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0xE751A4", Offset = "0xE751A4", VA = "0xE751A4")]
	public bool GfxDeviceAdvanceFrameGLES()
	{
		return default(bool);
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0xE76840", Offset = "0xE76840", VA = "0xE76840")]
	public Pvr_UnitySDKEyeManager()
	{
	}
}
[Token(Token = "0x200001F")]
public class Pvr_UnitySDKEyeOverlay : MonoBehaviour, IComparable<Pvr_UnitySDKEyeOverlay>
{
	[Token(Token = "0x2000147")]
	public delegate void ExternalAndroidSurfaceObjectCreated();

	[Token(Token = "0x2000148")]
	public enum OverlayShape
	{
		[Token(Token = "0x4000AD6")]
		Quad,
		[Token(Token = "0x4000AD7")]
		Cylinder,
		[Token(Token = "0x4000AD8")]
		Equirect
	}

	[Token(Token = "0x2000149")]
	public enum OverlayType
	{
		[Token(Token = "0x4000ADA")]
		Overlay,
		[Token(Token = "0x4000ADB")]
		Underlay
	}

	[Token(Token = "0x200014A")]
	public enum OverlayTexFilterMode
	{
		[Token(Token = "0x4000ADD")]
		NotCare,
		[Token(Token = "0x4000ADE")]
		Nearest,
		[Token(Token = "0x4000ADF")]
		Linear,
		[Token(Token = "0x4000AE0")]
		Nearest_Mipmap_Nearest,
		[Token(Token = "0x4000AE1")]
		Linear_Mipmap_Nearest,
		[Token(Token = "0x4000AE2")]
		Nearest_Mipmap_Linear,
		[Token(Token = "0x4000AE3")]
		Linear_Mipmap_Linear
	}

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<Pvr_UnitySDKEyeOverlay> Instances;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int layerIndex;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public OverlayType overlayType;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OverlayShape overlayShape;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform layerTransform;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Texture[] layerTextures;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int[] layerTextureIds;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Matrix4x4[] MVMatrixs;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3[] ModelScales;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Quaternion[] ModelRotations;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector3[] ModelTranslations;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Quaternion[] CameraRotations;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Vector3[] CameraTranslations;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Camera[] layerEyeCamera;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool overrideColorScaleAndOffset;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public Vector4 colorScale;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public Vector4 colorOffset;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private Vector4 overlayLayerColorScaleDefault;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private Vector4 overlayLayerColorOffsetDefault;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public bool isExternalAndroidSurface;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public IntPtr externalAndroidSurfaceObject;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public ExternalAndroidSurfaceObjectCreated externalAndroidSurfaceObjectCreated;

	[Token(Token = "0x6000222")]
	[Address(RVA = "0xE77BD4", Offset = "0xE77BD4", VA = "0xE77BD4", Slot = "4")]
	public int CompareTo(Pvr_UnitySDKEyeOverlay other)
	{
		return default(int);
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0xE77BF4", Offset = "0xE77BF4", VA = "0xE77BF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0xE780D4", Offset = "0xE780D4", VA = "0xE780D4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0xE78580", Offset = "0xE78580", VA = "0xE78580")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0xE74F70", Offset = "0xE74F70", VA = "0xE74F70")]
	public void RefreshCamera()
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0xE77F20", Offset = "0xE77F20", VA = "0xE77F20")]
	private void InitializeBuffer()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0xE780D8", Offset = "0xE780D8", VA = "0xE780D8")]
	private void UpdateCoords()
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0xE78810", Offset = "0xE78810", VA = "0xE78810")]
	public void SetTexture(Texture texture)
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0xE788A8", Offset = "0xE788A8", VA = "0xE788A8")]
	public void SetLayerColorScaleAndOffset(Vector4 scale, Vector4 offset)
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0xE77940", Offset = "0xE77940", VA = "0xE77940")]
	public Vector4 GetLayerColorScale()
	{
		return default(Vector4);
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0xE77980", Offset = "0xE77980", VA = "0xE77980")]
	public Vector4 GetLayerColorOffset()
	{
		return default(Vector4);
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0xE788BC", Offset = "0xE788BC", VA = "0xE788BC")]
	public Pvr_UnitySDKEyeOverlay()
	{
	}
}
[Token(Token = "0x2000020")]
public class Pvr_UnitySDKRender
{
	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Pvr_UnitySDKRender instance;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public AndroidJavaObject activity;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static AndroidJavaClass javaVrActivityClass;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static AndroidJavaClass javaSysActivityClass;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static AndroidJavaClass javaserviceClass;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static AndroidJavaClass javaVrActivityLongReceiver;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static AndroidJavaClass javaVrActivityClientClass;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool canConnecttoActivity;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool isInitrenderThread;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string model;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector2 prefinger1;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector2 prefinger2;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int eyeTextureCount;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RenderTexture[] eyeTextures;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int[] eyeTextureIds;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int currEyeTextureIdx;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int nextEyeTextureIdx;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int lastEyeTextureIdx;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public bool isSwitchSDK;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int RenderviewNumber;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public bool isFirstStartup;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	public bool isShellMode;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private StereoRenderingPathPico stereoRenderPath;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8008C8", Offset = "0x8008C8")]
	private SDKStereoRendering <StereoRendering>k__BackingField;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float rtScaleFactor;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private float eyeVFov;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float eyeHFov;

	[Token(Token = "0x17000036")]
	public static Pvr_UnitySDKRender Instance
	{
		[Token(Token = "0x600022F")]
		[Address(RVA = "0xE6EE1C", Offset = "0xE6EE1C", VA = "0xE6EE1C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000230")]
		[Address(RVA = "0xE8073C", Offset = "0xE8073C", VA = "0xE8073C")]
		set
		{
		}
	}

	[Token(Token = "0x17000037")]
	public StereoRenderingPathPico StereoRenderPath
	{
		[Token(Token = "0x6000232")]
		[Address(RVA = "0xE810CC", Offset = "0xE810CC", VA = "0xE810CC")]
		get
		{
			return default(StereoRenderingPathPico);
		}
	}

	[Token(Token = "0x17000038")]
	public SDKStereoRendering StereoRendering
	{
		[Token(Token = "0x6000233")]
		[Address(RVA = "0xE810D4", Offset = "0xE810D4", VA = "0xE810D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801B8C", Offset = "0x801B8C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000234")]
		[Address(RVA = "0xE810DC", Offset = "0xE810DC", VA = "0xE810DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801B9C", Offset = "0x801B9C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000039")]
	public float RtScaleFactor
	{
		[Token(Token = "0x6000235")]
		[Address(RVA = "0xE810E4", Offset = "0xE810E4", VA = "0xE810E4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000236")]
		[Address(RVA = "0xE810EC", Offset = "0xE810EC", VA = "0xE810EC")]
		set
		{
		}
	}

	[Token(Token = "0x1700003A")]
	public float EyeVFoV
	{
		[Token(Token = "0x6000237")]
		[Address(RVA = "0xE8124C", Offset = "0xE8124C", VA = "0xE8124C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000238")]
		[Address(RVA = "0xE71EF0", Offset = "0xE71EF0", VA = "0xE71EF0")]
		set
		{
		}
	}

	[Token(Token = "0x1700003B")]
	public float EyeHFoV
	{
		[Token(Token = "0x6000239")]
		[Address(RVA = "0xE81254", Offset = "0xE81254", VA = "0xE81254")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600023A")]
		[Address(RVA = "0xE8125C", Offset = "0xE8125C", VA = "0xE8125C")]
		set
		{
		}
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0xE8062C", Offset = "0xE8062C", VA = "0xE8062C")]
	public Pvr_UnitySDKRender()
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0xE807A8", Offset = "0xE807A8", VA = "0xE807A8")]
	public void ConnectToAndriod()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0xE8104C", Offset = "0xE8104C", VA = "0xE8104C")]
	public void Init()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0xE816B4", Offset = "0xE816B4", VA = "0xE816B4")]
	private bool InitRenderAbility()
	{
		return default(bool);
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0xE817C8", Offset = "0xE817C8", VA = "0xE817C8")]
	private bool UpdateRenderParaFrame()
	{
		return default(bool);
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0xE81870", Offset = "0xE81870", VA = "0xE81870")]
	private bool CreateEyeBuffer()
	{
		return default(bool);
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0xE8221C", Offset = "0xE8221C", VA = "0xE8221C")]
	private void InitSinglePass()
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0xE81BC4", Offset = "0xE81BC4", VA = "0xE81BC4")]
	public float GetEyeVFOV()
	{
		return default(float);
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0xE81D24", Offset = "0xE81D24", VA = "0xE81D24")]
	public float GetEyeHFOV()
	{
		return default(float);
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0xE8245C", Offset = "0xE8245C", VA = "0xE8245C")]
	private void ConfigureEyeBuffer(int eyeTextureIndex, Vector2 resolution)
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0xE81104", Offset = "0xE81104", VA = "0xE81104")]
	public bool ReCreateEyeBuffer()
	{
		return default(bool);
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0xE7F5E8", Offset = "0xE7F5E8", VA = "0xE7F5E8")]
	public void ReInit()
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0xE7EA88", Offset = "0xE7EA88", VA = "0xE7EA88")]
	public void IssueRenderThread()
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0xE829A0", Offset = "0xE829A0", VA = "0xE829A0")]
	private void AutoAdpatForPico1s()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0xE81E84", Offset = "0xE81E84", VA = "0xE81E84")]
	public Vector2 GetEyeBufferResolution()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0xE82BC8", Offset = "0xE82BC8", VA = "0xE82BC8")]
	public bool GetUsePredictedMatrix()
	{
		return default(bool);
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0xE81270", Offset = "0xE81270", VA = "0xE81270")]
	public bool GetIsShellMode()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000021")]
public class Pvr_UnitySDKSinglePass : SDKStereoRendering
{
	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Camera bothCamera;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Matrix4x4[] unity_StereoMatrixP;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Matrix4x4[] unity_StereoMatrixInvP;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Matrix4x4[] unity_StereoWorldToCamera;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Matrix4x4[] unity_StereoCameraToWorld;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Matrix4x4[] unity_StereoMatrixVP;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3[] eyesOffset;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Matrix4x4[] eyesOffsetMatrix;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private CommandBuffer commandBufferBeforeForwardOpaque;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private CommandBuffer commandBufferBeforeSkybox;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private CommandBuffer commandBufferAfterSkybox;

	[Token(Token = "0x600024C")]
	[Address(RVA = "0xE858C4", Offset = "0xE858C4", VA = "0xE858C4", Slot = "4")]
	public override void InitEye(Camera eye)
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0xE8613C", Offset = "0xE8613C", VA = "0xE8613C", Slot = "5")]
	public override void OnSDKRenderInited()
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0xE86264", Offset = "0xE86264", VA = "0xE86264", Slot = "6")]
	public override void OnSDKPreRender()
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0xE86A88", Offset = "0xE86A88", VA = "0xE86A88", Slot = "7")]
	public override void OnSDKPostRender()
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0xE86140", Offset = "0xE86140", VA = "0xE86140")]
	public void OnSDKRenderInited_SinglePass()
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0xE86B40", Offset = "0xE86B40", VA = "0xE86B40")]
	private void SetAntiAliasing()
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0xE85BE0", Offset = "0xE85BE0", VA = "0xE85BE0")]
	public void SetEyesPosition()
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0xE85FF4", Offset = "0xE85FF4", VA = "0xE85FF4")]
	public void SetEyeProjection()
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0xE86C48", Offset = "0xE86C48", VA = "0xE86C48")]
	private static Matrix4x4 GetProjection(float near, float far)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0xE86E60", Offset = "0xE86E60", VA = "0xE86E60")]
	public static Matrix4x4 MakeProjection(float n, float f)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0xE86D1C", Offset = "0xE86D1C", VA = "0xE86D1C")]
	public void SetStereoProjectionMatrix(Matrix4x4 left, Matrix4x4 right)
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0xE86A90", Offset = "0xE86A90", VA = "0xE86A90")]
	private void SwitchKeywordAndDeviceView(bool enable)
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0xE78604", Offset = "0xE78604", VA = "0xE78604")]
	public static Matrix4x4[] GetStereoWorldToCameraMat()
	{
		return null;
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0xE86268", Offset = "0xE86268", VA = "0xE86268")]
	public void SinglePassPreRender()
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0xE870DC", Offset = "0xE870DC", VA = "0xE870DC")]
	private void SetCommandBuffers()
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0xE8703C", Offset = "0xE8703C", VA = "0xE8703C")]
	private void SetRenderTextureWithDepth()
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0xE828F8", Offset = "0xE828F8", VA = "0xE828F8")]
	public Pvr_UnitySDKSinglePass()
	{
	}
}
[Token(Token = "0x2000022")]
public abstract class SDKStereoRendering
{
	[Token(Token = "0x600025E")]
	public abstract void InitEye(Camera eye);

	[Token(Token = "0x600025F")]
	public abstract void OnSDKRenderInited();

	[Token(Token = "0x6000260")]
	public abstract void OnSDKPreRender();

	[Token(Token = "0x6000261")]
	public abstract void OnSDKPostRender();

	[Token(Token = "0x6000262")]
	[Address(RVA = "0xB1B68C", Offset = "0xB1B68C", VA = "0xB1B68C")]
	protected SDKStereoRendering()
	{
	}
}
[Token(Token = "0x2000023")]
public class HighlightAtGaze : MonoBehaviour
{
	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color HighlightColor;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float AnimationTime;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Renderer myRenderer;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Color originalColor;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Color targetColor;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private EyeTrackingGazeRay gazeRay;

	[Token(Token = "0x6000263")]
	[Address(RVA = "0xBBD01C", Offset = "0xBBD01C", VA = "0xBBD01C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0xBBD0A0", Offset = "0xBBD0A0", VA = "0xBBD0A0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0xBBD27C", Offset = "0xBBD27C", VA = "0xBBD27C")]
	public HighlightAtGaze()
	{
	}
}
[Token(Token = "0x2000024")]
public class RayVisualizer : MonoBehaviour
{
	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LineRenderer _line;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private EyeTrackingGazeRay gazeRay;

	[Token(Token = "0x6000266")]
	[Address(RVA = "0xB1B398", Offset = "0xB1B398", VA = "0xB1B398")]
	private void Start()
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0xB1B430", Offset = "0xB1B430", VA = "0xB1B430")]
	private void Update()
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0xB1B5CC", Offset = "0xB1B5CC", VA = "0xB1B5CC")]
	public RayVisualizer()
	{
	}
}
[Token(Token = "0x2000025")]
public class GetSeeThroughImage : MonoBehaviour
{
	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RawImage viewImage_left;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RawImage viewImage_right;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int width;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int height;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RenderTexture cameraTex_left;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private RenderTexture cameraTex_right;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool cameraPreview;

	[Token(Token = "0x6000269")]
	[Address(RVA = "0xBBCE58", Offset = "0xBBCE58", VA = "0xBBCE58")]
	private void Start()
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0xBBCF70", Offset = "0xBBCF70", VA = "0xBBCF70")]
	private void Update()
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0xBBCFFC", Offset = "0xBBCFFC", VA = "0xBBCFFC")]
	private void OnDestory()
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0xBBCE5C", Offset = "0xBBCE5C", VA = "0xBBCE5C")]
	private void CreateTexture()
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0xBBCFAC", Offset = "0xBBCFAC", VA = "0xBBCFAC")]
	private void DrawTexture()
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0xBBD014", Offset = "0xBBD014", VA = "0xBBD014")]
	public GetSeeThroughImage()
	{
	}
}
[Token(Token = "0x2000026")]
public class OverlayExternalSurfaceDemo : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200014B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFD88", Offset = "0x7FFD88")]
	private sealed class <>c
	{
		[Token(Token = "0x4000AE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000AE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Pvr_UnitySDKEyeOverlay.ExternalAndroidSurfaceObjectCreated <>9__7_0;

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0xE38224", Offset = "0xE38224", VA = "0xE38224")]
		public <>c()
		{
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0xE3822C", Offset = "0xE3822C", VA = "0xE3822C")]
		internal void <StartPlay>b__7_0()
		{
		}
	}

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string movieName;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Pvr_UnitySDKEyeOverlay.OverlayType overlayType;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Pvr_UnitySDKEyeOverlay.OverlayShape overlayShape;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Pvr_UnitySDKEyeOverlay overlay;

	[Token(Token = "0x40001BC")]
	private const string TAG = "[ExternalSurface]>>>>>>";

	[Token(Token = "0x600026F")]
	[Address(RVA = "0xE37E20", Offset = "0xE37E20", VA = "0xE37E20")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0xE37F44", Offset = "0xE37F44", VA = "0xE37F44")]
	private void Start()
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0xE37FC8", Offset = "0xE37FC8", VA = "0xE37FC8")]
	private void StartPlay(string moviePath, string licenceUrl)
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0xE381B8", Offset = "0xE381B8", VA = "0xE381B8")]
	public OverlayExternalSurfaceDemo()
	{
	}
}
[Token(Token = "0x2000027")]
public class MoveCylinder : MonoBehaviour
{
	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 startingPosition;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Quaternion startingRotation;

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x127B134", Offset = "0x127B134", VA = "0x127B134")]
	private void Start()
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x127B190", Offset = "0x127B190", VA = "0x127B190")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x127B1E8", Offset = "0x127B1E8", VA = "0x127B1E8")]
	public MoveCylinder()
	{
	}
}
[Token(Token = "0x2000028")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7FFA6C", Offset = "0x7FFA6C")]
public class MoveSphere : MonoBehaviour
{
	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 startingPosition;

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x127B1F0", Offset = "0x127B1F0", VA = "0x127B1F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x127B364", Offset = "0x127B364", VA = "0x127B364")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x127B2CC", Offset = "0x127B2CC", VA = "0x127B2CC")]
	public void SetGazedAt(bool gazedAt)
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x127B368", Offset = "0x127B368", VA = "0x127B368")]
	public void Reset()
	{
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x127B468", Offset = "0x127B468", VA = "0x127B468")]
	public void TeleportRandomly()
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x127B574", Offset = "0x127B574", VA = "0x127B574")]
	public MoveSphere()
	{
	}
}
[Token(Token = "0x2000029")]
public class Resetbutton : MonoBehaviour
{
	[Token(Token = "0x600027C")]
	[Address(RVA = "0xB1B5E4", Offset = "0xB1B5E4", VA = "0xB1B5E4")]
	public void DemoResetTracking()
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0xB1B684", Offset = "0xB1B684", VA = "0xB1B684")]
	public Resetbutton()
	{
	}
}
[Token(Token = "0x200002A")]
public class UserEntitlementCheck : MonoBehaviour
{
	[Token(Token = "0x600027E")]
	[Address(RVA = "0xA6EB90", Offset = "0xA6EB90", VA = "0xA6EB90")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0xA6EC24", Offset = "0xA6EC24", VA = "0xA6EC24")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0xA6ECB8", Offset = "0xA6ECB8", VA = "0xA6ECB8")]
	private void HandelEntitlementCheckResult(int resultCode)
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0xA6EF84", Offset = "0xA6EF84", VA = "0xA6EF84")]
	public UserEntitlementCheck()
	{
	}
}
[Token(Token = "0x200002B")]
public class Pvr_SQPLoader : MonoBehaviour
{
	[Token(Token = "0x200014C")]
	private struct SceneInfo
	{
		[Token(Token = "0x4000AE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public List<string> scenes;

		[Token(Token = "0x4000AE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public long version;

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0xD46070", Offset = "0xD46070", VA = "0xD46070")]
		public SceneInfo(List<string> sceneList, long currentSceneEpochVersion)
		{
		}
	}

	[Token(Token = "0x200014D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFD98", Offset = "0x7FFD98")]
	private sealed class <onCheckNewSceneCoroutine>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000AE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000AE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000AEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pvr_SQPLoader <>4__this;

		[Token(Token = "0x170000EF")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60009EC")]
			[Address(RVA = "0xD46000", Offset = "0xD46000", VA = "0xD46000", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F0")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009EE")]
			[Address(RVA = "0xD46068", Offset = "0xD46068", VA = "0xD46068", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0xD45BE8", Offset = "0xD45BE8", VA = "0xD45BE8")]
		[DebuggerHidden]
		public <onCheckNewSceneCoroutine>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0xD45C94", Offset = "0xD45C94", VA = "0xD45C94", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0xD45C98", Offset = "0xD45C98", VA = "0xD45C98", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0xD46008", Offset = "0xD46008", VA = "0xD46008", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001C0")]
	public const string RESOURCE_BUNDLE_NAME = "asset_resources";

	[Token(Token = "0x40001C1")]
	public const string EXTERNAL_STORAGE_PATH = "/sdcard/Android/data";

	[Token(Token = "0x40001C2")]
	public const string SCENE_LOAD_DATA_NAME = "SceneLoadData.txt";

	[Token(Token = "0x40001C3")]
	private const string SQP_INDEX_NAME = "PvrSQPIndex";

	[Token(Token = "0x40001C4")]
	private const string CACHE_SCENES_PATH = "cache/scenes";

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AsyncOperation loadSceneOperation;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string scenePath;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string sceneLoadDataPath;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<AssetBundle> loadedAssetBundles;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SceneInfo currentSceneInfo;

	[Token(Token = "0x6000282")]
	[Address(RVA = "0xD45380", Offset = "0xD45380", VA = "0xD45380")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0xD453FC", Offset = "0xD453FC", VA = "0xD453FC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0xD45B48", Offset = "0xD45B48", VA = "0xD45B48")]
	public void Update()
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0xD45508", Offset = "0xD45508", VA = "0xD45508")]
	private SceneInfo GetSceneInfo()
	{
		return default(SceneInfo);
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0xD456CC", Offset = "0xD456CC", VA = "0xD456CC")]
	private void LoadScene(SceneInfo sceneInfo)
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0xD45B4C", Offset = "0xD45B4C", VA = "0xD45B4C")]
	private void LoadSceneOperation_completed(AsyncOperation obj)
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0xD45B78", Offset = "0xD45B78", VA = "0xD45B78")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x801BAC", Offset = "0x801BAC")]
	private IEnumerator onCheckNewSceneCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0xD45C14", Offset = "0xD45C14", VA = "0xD45C14")]
	public Pvr_SQPLoader()
	{
	}
}
[Token(Token = "0x200002C")]
public class Pvr_UnitySDKHeadTrack : MonoBehaviour
{
	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8008D8", Offset = "0x8008D8")]
	public bool trackRotation;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x800910", Offset = "0x800910")]
	public bool trackPosition;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform target;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool updated;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	private bool dataClock;

	[Token(Token = "0x1700003C")]
	public Ray Gaze
	{
		[Token(Token = "0x600028A")]
		[Address(RVA = "0xE78C8C", Offset = "0xE78C8C", VA = "0xE78C8C")]
		get
		{
			return default(Ray);
		}
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0xE79178", Offset = "0xE79178", VA = "0xE79178")]
	private void Update()
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0xE78D28", Offset = "0xE78D28", VA = "0xE78D28")]
	private void UpdateHead()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0xE79180", Offset = "0xE79180", VA = "0xE79180")]
	public Pvr_UnitySDKHeadTrack()
	{
	}
}
[Token(Token = "0x200002D")]
public class Pvr_UnitySDKPose
{
	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static readonly Matrix4x4 flipZ;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800948", Offset = "0x800948")]
	private Vector3 <Position>k__BackingField;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800958", Offset = "0x800958")]
	private Quaternion <Orientation>k__BackingField;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800968", Offset = "0x800968")]
	private Matrix4x4 <Matrix>k__BackingField;

	[Token(Token = "0x1700003D")]
	public Matrix4x4 RightHandedMatrix
	{
		[Token(Token = "0x600028E")]
		[Address(RVA = "0xE7FFA4", Offset = "0xE7FFA4", VA = "0xE7FFA4")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Token(Token = "0x1700003E")]
	public Vector3 Position
	{
		[Token(Token = "0x600028F")]
		[Address(RVA = "0xE800E8", Offset = "0xE800E8", VA = "0xE800E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801C10", Offset = "0x801C10")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000290")]
		[Address(RVA = "0xE800F4", Offset = "0xE800F4", VA = "0xE800F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801C20", Offset = "0x801C20")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700003F")]
	public Quaternion Orientation
	{
		[Token(Token = "0x6000291")]
		[Address(RVA = "0xE80100", Offset = "0xE80100", VA = "0xE80100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801C30", Offset = "0x801C30")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000292")]
		[Address(RVA = "0xE8010C", Offset = "0xE8010C", VA = "0xE8010C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801C40", Offset = "0x801C40")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000040")]
	public Matrix4x4 Matrix
	{
		[Token(Token = "0x6000293")]
		[Address(RVA = "0xE80118", Offset = "0xE80118", VA = "0xE80118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801C50", Offset = "0x801C50")]
		get
		{
			return default(Matrix4x4);
		}
		[Token(Token = "0x6000294")]
		[Address(RVA = "0xE80134", Offset = "0xE80134", VA = "0xE80134")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801C60", Offset = "0x801C60")]
		protected set
		{
		}
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0xE72034", Offset = "0xE72034", VA = "0xE72034")]
	public Pvr_UnitySDKPose(Matrix4x4 matrix)
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0xE802BC", Offset = "0xE802BC", VA = "0xE802BC")]
	public Pvr_UnitySDKPose(Vector3 position, Quaternion orientation)
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0xE8033C", Offset = "0xE8033C", VA = "0xE8033C")]
	public void Set(Vector3 position, Quaternion orientation)
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0xE80150", Offset = "0xE80150", VA = "0xE80150")]
	protected void Set(Matrix4x4 matrix)
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0xE8046C", Offset = "0xE8046C", VA = "0xE8046C")]
	private Quaternion NormalizeQuaternion(ref Quaternion q)
	{
		return default(Quaternion);
	}
}
[Token(Token = "0x200002E")]
public class Pvr_UnitySDKSensor
{
	[Token(Token = "0x200014E")]
	public delegate void Enter3DofModel();

	[Token(Token = "0x200014F")]
	public delegate void Exit3DofModel();

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Pvr_UnitySDKSensor instance;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool SensorStart;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	private bool SensorInit;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private Quaternion UnityQuaternion;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 UnityPosition;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Sensorindex sensorIndex;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool dofClock;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Action EyeFovChanged;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Pvr_UnitySDKPose HeadPose;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float vfov;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float hfov;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float w;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float x;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float y;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float z;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float px;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float py;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float pz;

	[Token(Token = "0x17000041")]
	public static Pvr_UnitySDKSensor Instance
	{
		[Token(Token = "0x600029B")]
		[Address(RVA = "0xE7169C", Offset = "0xE7169C", VA = "0xE7169C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600029C")]
		[Address(RVA = "0xE82C90", Offset = "0xE82C90", VA = "0xE82C90")]
		set
		{
		}
	}

	[Token(Token = "0x14000016")]
	public static event Enter3DofModel Enter3DofModelEvent
	{
		[Token(Token = "0x600029E")]
		[Address(RVA = "0xE82E30", Offset = "0xE82E30", VA = "0xE82E30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801C70", Offset = "0x801C70")]
		add
		{
		}
		[Token(Token = "0x600029F")]
		[Address(RVA = "0xE82F20", Offset = "0xE82F20", VA = "0xE82F20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801C80", Offset = "0x801C80")]
		remove
		{
		}
	}

	[Token(Token = "0x14000017")]
	public static event Exit3DofModel Exit3DofModelEvent
	{
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xE83010", Offset = "0xE83010", VA = "0xE83010")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801C90", Offset = "0x801C90")]
		add
		{
		}
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xE83100", Offset = "0xE83100", VA = "0xE83100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801CA0", Offset = "0x801CA0")]
		remove
		{
		}
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0xE82BD4", Offset = "0xE82BD4", VA = "0xE82BD4")]
	public Pvr_UnitySDKSensor()
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0xE82CFC", Offset = "0xE82CFC", VA = "0xE82CFC")]
	public void Init()
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0xE7DD70", Offset = "0xE7DD70", VA = "0xE7DD70")]
	public void SensorUpdate()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0xE83430", Offset = "0xE83430", VA = "0xE83430")]
	public bool InitUnitySDKSensor()
	{
		return default(bool);
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0xE831F0", Offset = "0xE831F0", VA = "0xE831F0")]
	public bool InitUnitySDK6DofSensor()
	{
		return default(bool);
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0xE7F210", Offset = "0xE7F210", VA = "0xE7F210")]
	public bool StartUnitySDKSensor()
	{
		return default(bool);
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0xE7E174", Offset = "0xE7E174", VA = "0xE7E174")]
	public bool StopUnitySDKSensor()
	{
		return default(bool);
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0xE7C3B4", Offset = "0xE7C3B4", VA = "0xE7C3B4")]
	public bool ResetUnitySDKSensor()
	{
		return default(bool);
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0xE77758", Offset = "0xE77758", VA = "0xE77758")]
	public bool OptionalResetUnitySDKSensor(int resetRot, int resetPos)
	{
		return default(bool);
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0xE8356C", Offset = "0xE8356C", VA = "0xE8356C")]
	public bool GetUnitySDKSensorState()
	{
		return default(bool);
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0xE84AE8", Offset = "0xE84AE8", VA = "0xE84AE8")]
	public bool GetUnitySDKPSensorState()
	{
		return default(bool);
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0xE84964", Offset = "0xE84964", VA = "0xE84964")]
	private void RefreshHeadData(float x, float y, float z, float w, float px, float py, float pz)
	{
	}
}
[Token(Token = "0x200002F")]
public class CLoadingAsset : ScriptableObject
{
	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int SplashScreenType;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Texture2D> splashImage;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Texture2D Inside_background;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool UseSplashText;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string DefaultText;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string ChineseText;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string EnglishText;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string JapaneseText;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string KoreanText;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string FontSize;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Color FontColor;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public string TextHeight;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool UseCarousel;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public int SplashTextAlignment;

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0xBB5450", Offset = "0xBB5450", VA = "0xBB5450")]
	public CLoadingAsset()
	{
	}
}
[Serializable]
[Token(Token = "0x2000030")]
public class Pvr_UnitySDKConfigProfile
{
	[Token(Token = "0x2000150")]
	public struct Lenses
	{
		[Token(Token = "0x4000AEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float separation;

		[Token(Token = "0x4000AEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float offset;

		[Token(Token = "0x4000AED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float distance;

		[Token(Token = "0x4000AEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int alignment;

		[Token(Token = "0x4000AEF")]
		public const int AlignTop = -1;

		[Token(Token = "0x4000AF0")]
		public const int AlignCenter = 0;

		[Token(Token = "0x4000AF1")]
		public const int AlignBottom = 1;
	}

	[Token(Token = "0x2000151")]
	public struct MaxFOV
	{
		[Token(Token = "0x4000AF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float upper;

		[Token(Token = "0x4000AF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float lower;

		[Token(Token = "0x4000AF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float inner;

		[Token(Token = "0x4000AF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float outer;
	}

	[Token(Token = "0x2000152")]
	public struct Distortion
	{
		[Token(Token = "0x4000AF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float k1;

		[Token(Token = "0x4000AF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float k2;

		[Token(Token = "0x4000AF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float k3;

		[Token(Token = "0x4000AF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float k4;

		[Token(Token = "0x4000AFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float k5;

		[Token(Token = "0x4000AFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float k6;

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0xE70BA0", Offset = "0xE70BA0", VA = "0xE70BA0")]
		public float distort(float r)
		{
			return default(float);
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0xE706CC", Offset = "0xE706CC", VA = "0xE706CC")]
		public float distort(float r, float dist)
		{
			return default(float);
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0xE70BA8", Offset = "0xE70BA8", VA = "0xE70BA8")]
		public float diatortInv(float radious)
		{
			return default(float);
		}
	}

	[Token(Token = "0x2000153")]
	public struct Device
	{
		[Token(Token = "0x4000AFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Lenses devLenses;

		[Token(Token = "0x4000AFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MaxFOV devMaxFov;

		[Token(Token = "0x4000AFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Distortion devDistortion;

		[Token(Token = "0x4000AFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Distortion devDistortionInv;
	}

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly Device SimulateDevice;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Device device;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static readonly Pvr_UnitySDKConfigProfile Default;

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0xE7034C", Offset = "0xE7034C", VA = "0xE7034C")]
	public Pvr_UnitySDKConfigProfile Clone()
	{
		return null;
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0xE703E4", Offset = "0xE703E4", VA = "0xE703E4")]
	public static Pvr_UnitySDKConfigProfile GetPicoProfile()
	{
		return null;
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0xE7048C", Offset = "0xE7048C", VA = "0xE7048C")]
	public float[] GetLeftEyeVisibleTanAngles(float width, float height)
	{
		return null;
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0xE707D8", Offset = "0xE707D8", VA = "0xE707D8")]
	public float[] GetLeftEyeNoLensTanAngles(float width, float height)
	{
		return null;
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0xE70A04", Offset = "0xE70A04", VA = "0xE70A04")]
	public Rect GetLeftEyeVisibleScreenRect(float[] undistortedFrustum, float width, float height)
	{
		return default(Rect);
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0xE703DC", Offset = "0xE703DC", VA = "0xE703DC")]
	public Pvr_UnitySDKConfigProfile()
	{
	}
}
[Token(Token = "0x2000031")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7FFAD0", Offset = "0x7FFAD0")]
public class Pvr_UnitySDKFPS : MonoBehaviour
{
	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text fpsText;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float updateInterval;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float accum;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int frames;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float timeLeft;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string strFps;

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0xE78AEC", Offset = "0xE78AEC", VA = "0xE78AEC")]
	private void Update()
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0xE78B74", Offset = "0xE78B74", VA = "0xE78B74")]
	private void ShowFps()
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0xE78C7C", Offset = "0xE78C7C", VA = "0xE78C7C")]
	public Pvr_UnitySDKFPS()
	{
	}
}
[Token(Token = "0x2000032")]
public class Pvr_GazeFuse : MonoBehaviour
{
	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject gazeGameObject;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Image image;

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x10A0CB8", Offset = "0x10A0CB8", VA = "0x10A0CB8")]
	private void Start()
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x10A0D10", Offset = "0x10A0D10", VA = "0x10A0D10")]
	private void Update()
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x10A0E44", Offset = "0x10A0E44", VA = "0x10A0E44")]
	private void FuseAmountChanged(float fuseAmount)
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x10A0EEC", Offset = "0x10A0EEC", VA = "0x10A0EEC")]
	public Pvr_GazeFuse()
	{
	}
}
[Token(Token = "0x2000033")]
public class Pvr_GazeInputModule : PointerInputModule
{
	[Token(Token = "0x2000154")]
	public enum Mode
	{
		[Token(Token = "0x4000B01")]
		Click,
		[Token(Token = "0x4000B02")]
		Gaze
	}

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Mode mode;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x800998", Offset = "0x800998")]
	public string ClickInputName;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8009D0", Offset = "0x8009D0")]
	public float GazeTimeInSeconds;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800A08", Offset = "0x800A08")]
	private static float <gazeFraction>k__BackingField;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800A18", Offset = "0x800A18")]
	private static GameObject <gazeGameObject>k__BackingField;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public RaycastResult CurrentRaycast;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private PointerEventData pointerEventData;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private GameObject currentLookAtHandler;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private float currentLookAtHandlerClickTime;

	[Token(Token = "0x17000042")]
	public static float gazeFraction
	{
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x10A0EF4", Offset = "0x10A0EF4", VA = "0x10A0EF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801CB0", Offset = "0x801CB0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x10A0F44", Offset = "0x10A0F44", VA = "0x10A0F44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801CC0", Offset = "0x801CC0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000043")]
	public static GameObject gazeGameObject
	{
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x10A0FA0", Offset = "0x10A0FA0", VA = "0x10A0FA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801CD0", Offset = "0x801CD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x10A0FF0", Offset = "0x10A0FF0", VA = "0x10A0FF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801CE0", Offset = "0x801CE0")]
		private set
		{
		}
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x10A1044", Offset = "0x10A1044", VA = "0x10A1044", Slot = "17")]
	public override void Process()
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x10A1068", Offset = "0x10A1068", VA = "0x10A1068")]
	private void HandleLook()
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x10A122C", Offset = "0x10A122C", VA = "0x10A122C")]
	private void HandleSelection()
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x10A16D8", Offset = "0x10A16D8", VA = "0x10A16D8")]
	public Pvr_GazeInputModule()
	{
	}
}
[Token(Token = "0x2000034")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7FFB34", Offset = "0x7FFB34")]
public class Pvr_GazeInputModuleCrosshair : MonoBehaviour
{
	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool DisplayCrosshair;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x800A28", Offset = "0x800A28")]
	public Transform Crosshair;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Pvr_GazeInputModule gazeInputModule;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 CrosshairOriginalScale;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float CrosshairOriginalDistance;

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x10A1738", Offset = "0x10A1738", VA = "0x10A1738")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x10A1790", Offset = "0x10A1790", VA = "0x10A1790")]
	private void Start()
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x10A17F8", Offset = "0x10A17F8", VA = "0x10A17F8")]
	private void Update()
	{
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x10A1908", Offset = "0x10A1908", VA = "0x10A1908")]
	private void SetCrossHairAtDistance(float dist)
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x10A1A00", Offset = "0x10A1A00", VA = "0x10A1A00")]
	public Pvr_GazeInputModuleCrosshair()
	{
	}
}
[Token(Token = "0x2000035")]
public enum RenderEventType
{
	[Token(Token = "0x400020F")]
	InitRenderThread = 1024,
	[Token(Token = "0x4000210")]
	Pause,
	[Token(Token = "0x4000211")]
	Resume,
	[Token(Token = "0x4000212")]
	LeftEyeEndFrame,
	[Token(Token = "0x4000213")]
	RightEyeEndFrame,
	[Token(Token = "0x4000214")]
	TimeWarp,
	[Token(Token = "0x4000215")]
	ResetVrModeParms,
	[Token(Token = "0x4000216")]
	ShutdownRenderThread,
	[Token(Token = "0x4000217")]
	BeginEye,
	[Token(Token = "0x4000218")]
	EndEye,
	[Token(Token = "0x4000219")]
	BoundaryRenderLeft,
	[Token(Token = "0x400021A")]
	BoundaryRenderRight,
	[Token(Token = "0x400021B")]
	BothEyeEndFrame,
	[Token(Token = "0x400021C")]
	CameraFrameLeft,
	[Token(Token = "0x400021D")]
	CameraFrameRight,
	[Token(Token = "0x400021E")]
	StartCameraFrame,
	[Token(Token = "0x400021F")]
	StopCameraFrame
}
[Token(Token = "0x2000036")]
public static class Pvr_UnitySDKPluginEvent
{
	[Token(Token = "0x2000155")]
	private delegate void RenderEventDelegate(int eventId);

	[Token(Token = "0x4000220")]
	private const uint IS_DATA_FLAG = 2147483648u;

	[Token(Token = "0x4000221")]
	private const uint DATA_POS_MASK = 1073741824u;

	[Token(Token = "0x4000222")]
	private const int DATA_POS_SHIFT = 30;

	[Token(Token = "0x4000223")]
	private const uint EVENT_TYPE_MASK = 1056899072u;

	[Token(Token = "0x4000224")]
	private const int EVENT_TYPE_SHIFT = 17;

	[Token(Token = "0x4000225")]
	private const uint PAYLOAD_MASK = 65535u;

	[Token(Token = "0x4000226")]
	private const int PAYLOAD_SHIFT = 16;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static RenderEventDelegate SetSinglePassBeforeForwardOpaqueHandle;

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static IntPtr SetSinglePassBeforeForwardOpaquePtr;

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0xE732D0", Offset = "0xE732D0", VA = "0xE732D0")]
	public static void Issue(RenderEventType eventType)
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0xE7FB1C", Offset = "0xE7FB1C", VA = "0xE7FB1C")]
	private static int EncodeType(int eventType)
	{
		return default(int);
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0xE7FB24", Offset = "0xE7FB24", VA = "0xE7FB24")]
	private static int EncodeData(int eventId, int eventData, int pos)
	{
		return default(int);
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0xE7FB44", Offset = "0xE7FB44", VA = "0xE7FB44")]
	private static int DecodeData(int eventData)
	{
		return default(int);
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0xE7FB14", Offset = "0xE7FB14", VA = "0xE7FB14")]
	[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x801CF0", Offset = "0x801CF0")]
	private static void SetSinglePassBeforeForwardOpaque(int eventId)
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0xE7FB58", Offset = "0xE7FB58", VA = "0xE7FB58")]
	public static void SetSinglePassBeforeForwardOpaque(CommandBuffer cmd)
	{
	}
}
[Token(Token = "0x2000037")]
public class Pvr_UnitySDKSightInputModule : BaseInputModule
{
	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x800A60", Offset = "0x800A60")]
	public GameObject cursor;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int trigger;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[HideInInspector]
	public float clickTime;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public Vector2 hotspot;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private PointerEventData pointerData;

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0xE84CB8", Offset = "0xE84CB8", VA = "0xE84CB8", Slot = "21")]
	public override bool ShouldActivateModule()
	{
		return default(bool);
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0xE84D48", Offset = "0xE84D48", VA = "0xE84D48", Slot = "22")]
	public override void DeactivateModule()
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0xE85030", Offset = "0xE85030", VA = "0xE85030", Slot = "20")]
	public override bool IsPointerOverGameObject(int pointerId)
	{
		return default(bool);
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0xE850B8", Offset = "0xE850B8", VA = "0xE850B8", Slot = "17")]
	public override void Process()
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0xE850F4", Offset = "0xE850F4", VA = "0xE850F4")]
	private void CastRayFromGaze()
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0xE85238", Offset = "0xE85238", VA = "0xE85238")]
	private void UpdateCurrentObject()
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0xE853D8", Offset = "0xE853D8", VA = "0xE853D8")]
	private void PlaceCursor()
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0xE84E44", Offset = "0xE84E44", VA = "0xE84E44")]
	private void HandlePendingClick()
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0xE85600", Offset = "0xE85600", VA = "0xE85600")]
	private void HandleTrigger()
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0xE85870", Offset = "0xE85870", VA = "0xE85870")]
	public Pvr_UnitySDKSightInputModule()
	{
	}
}
[Token(Token = "0x2000038")]
public class Pvr_ObjImporter
{
	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Pvr_ObjImporter _instance;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<int> triangles;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<Vector3> vertices;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<Vector2> uv;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<Vector3> normals;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<PvrVector3Int> faceData;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<int> intArray;

	[Token(Token = "0x4000235")]
	private const int MIN_POW_10 = -16;

	[Token(Token = "0x4000236")]
	private const int MAX_POW_10 = 16;

	[Token(Token = "0x4000237")]
	private const int NUM_POWS_10 = 33;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly float[] pow10;

	[Token(Token = "0x17000044")]
	public static Pvr_ObjImporter Instance
	{
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xD440E8", Offset = "0xD440E8", VA = "0xD440E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0xD44194", Offset = "0xD44194", VA = "0xD44194")]
	public Mesh ImportFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0xD445B8", Offset = "0xD445B8", VA = "0xD445B8")]
	private void LoadMeshData(string fileName)
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0xD44C8C", Offset = "0xD44C8C", VA = "0xD44C8C")]
	private float GetFloat(StringBuilder sb, ref int start, ref StringBuilder sbFloat)
	{
		return default(float);
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0xD44E04", Offset = "0xD44E04", VA = "0xD44E04")]
	private int GetInt(StringBuilder sb, ref int start, ref StringBuilder sbInt)
	{
		return default(int);
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0xD4520C", Offset = "0xD4520C", VA = "0xD4520C")]
	private static float[] GenerateLookupTable()
	{
		return null;
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0xD44F44", Offset = "0xD44F44", VA = "0xD44F44")]
	private float ParseFloat(StringBuilder value)
	{
		return default(float);
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0xD45180", Offset = "0xD45180", VA = "0xD45180")]
	private int IntParseFast(StringBuilder value)
	{
		return default(int);
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0xD4418C", Offset = "0xD4418C", VA = "0xD4418C")]
	public Pvr_ObjImporter()
	{
	}
}
[Token(Token = "0x2000039")]
public sealed class PvrVector3Int
{
	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800AB8", Offset = "0x800AB8")]
	private int <x>k__BackingField;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800AC8", Offset = "0x800AC8")]
	private int <y>k__BackingField;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800AD8", Offset = "0x800AD8")]
	private int <z>k__BackingField;

	[Token(Token = "0x17000045")]
	public int x
	{
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xE39488", Offset = "0xE39488", VA = "0xE39488")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801D54", Offset = "0x801D54")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xE39490", Offset = "0xE39490", VA = "0xE39490")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801D64", Offset = "0x801D64")]
		set
		{
		}
	}

	[Token(Token = "0x17000046")]
	public int y
	{
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xE39498", Offset = "0xE39498", VA = "0xE39498")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801D74", Offset = "0x801D74")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xE394A0", Offset = "0xE394A0", VA = "0xE394A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801D84", Offset = "0x801D84")]
		set
		{
		}
	}

	[Token(Token = "0x17000047")]
	public int z
	{
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xE394A8", Offset = "0xE394A8", VA = "0xE394A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801D94", Offset = "0x801D94")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xE394B0", Offset = "0xE394B0", VA = "0xE394B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801DA4", Offset = "0x801DA4")]
		set
		{
		}
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0xE394B8", Offset = "0xE394B8", VA = "0xE394B8")]
	public PvrVector3Int()
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0xE394C0", Offset = "0xE394C0", VA = "0xE394C0")]
	public PvrVector3Int(int x, int y, int z)
	{
	}
}
[Token(Token = "0x200003A")]
public class Pvr_EnumFlags : PropertyAttribute
{
	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x10A0CB0", Offset = "0x10A0CB0", VA = "0x10A0CB0")]
	public Pvr_EnumFlags()
	{
	}
}
[Token(Token = "0x200003B")]
public enum ConfirmBtn
{
	[Token(Token = "0x400023D")]
	App = 1,
	[Token(Token = "0x400023E")]
	TouchPad = 2,
	[Token(Token = "0x400023F")]
	Trigger = 4
}
[Token(Token = "0x200003C")]
public class Pvr_InputModule : PointerInputModule
{
	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<Pvr_UIPointer> pointers;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Pvr_EnumFlags]
	public ConfirmBtn confirmBtn;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<RaycastResult> rayCasts;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private RaycastResult rayCastResult;

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x10A1A5C", Offset = "0x10A1A5C", VA = "0x10A1A5C", Slot = "30")]
	public virtual void Initialise()
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x10A1AD8", Offset = "0x10A1AD8", VA = "0x10A1AD8")]
	public static void AddPoint(Pvr_UIPointer point)
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x10A1BA8", Offset = "0x10A1BA8", VA = "0x10A1BA8")]
	public static void RemovePoint(Pvr_UIPointer point)
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x10A1C78", Offset = "0x10A1C78", VA = "0x10A1C78", Slot = "17")]
	public override void Process()
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x10A1FEC", Offset = "0x10A1FEC", VA = "0x10A1FEC", Slot = "31")]
	protected virtual List<RaycastResult> CheckRaycasts(Pvr_UIPointer pointer)
	{
		return null;
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x10A209C", Offset = "0x10A209C", VA = "0x10A209C", Slot = "32")]
	protected virtual bool CheckTransformTree(Transform target, Transform source)
	{
		return default(bool);
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x10A218C", Offset = "0x10A218C", VA = "0x10A218C", Slot = "33")]
	protected virtual bool NoValidCollision(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
		return default(bool);
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x10A224C", Offset = "0x10A224C", VA = "0x10A224C", Slot = "34")]
	protected virtual bool IsHovering(Pvr_UIPointer pointer)
	{
		return default(bool);
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x10A2454", Offset = "0x10A2454", VA = "0x10A2454", Slot = "35")]
	protected virtual bool ValidElement(GameObject obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x10A2504", Offset = "0x10A2504", VA = "0x10A2504", Slot = "36")]
	protected virtual void CheckPointerHoverClick(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x10A25A0", Offset = "0x10A25A0", VA = "0x10A25A0", Slot = "37")]
	protected virtual void Hover(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x10A311C", Offset = "0x10A311C", VA = "0x10A311C", Slot = "38")]
	protected virtual void Click(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x10A3164", Offset = "0x10A3164", VA = "0x10A3164", Slot = "39")]
	protected virtual void ClickOnUp(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x10A3204", Offset = "0x10A3204", VA = "0x10A3204", Slot = "40")]
	protected virtual void ClickOnDown(Pvr_UIPointer pointer, List<RaycastResult> results, bool forceClick = false)
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x10A32C0", Offset = "0x10A32C0", VA = "0x10A32C0", Slot = "41")]
	protected virtual bool IsEligibleClick(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
		return default(bool);
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x10A3594", Offset = "0x10A3594", VA = "0x10A3594", Slot = "42")]
	protected virtual bool AttemptClick(Pvr_UIPointer pointer)
	{
		return default(bool);
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x10A3860", Offset = "0x10A3860", VA = "0x10A3860", Slot = "43")]
	protected virtual void Drag(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x10A3F34", Offset = "0x10A3F34", VA = "0x10A3F34")]
	public Pvr_InputModule()
	{
	}
}
[Token(Token = "0x200003D")]
public class Pvr_UICanvas : MonoBehaviour
{
	[Token(Token = "0x2000156")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFDA8", Offset = "0x7FFDA8")]
	private sealed class <CreateDraggablePanel>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000B04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000B05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Canvas canvas;

		[Token(Token = "0x4000B06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 canvasSize;

		[Token(Token = "0x170000F1")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A01")]
			[Address(RVA = "0xD49960", Offset = "0xD49960", VA = "0xD49960", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F2")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A03")]
			[Address(RVA = "0xD499C8", Offset = "0xD499C8", VA = "0xD499C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0xD492C8", Offset = "0xD492C8", VA = "0xD492C8")]
		[DebuggerHidden]
		public <CreateDraggablePanel>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0xD495DC", Offset = "0xD495DC", VA = "0xD495DC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0xD495E0", Offset = "0xD495E0", VA = "0xD495E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0xD49968", Offset = "0xD49968", VA = "0xD49968", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool clickOnPointerCollision;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float autoActivateWithinDistance;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected BoxCollider canvasBoxCollider;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected Rigidbody canvasRigidBody;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected Coroutine draggablePanelCreation;

	[Token(Token = "0x4000249")]
	protected const string CANVAS_DRAGGABLE_PANEL = "UICANVAS_DRAGGABLE_PANEL";

	[Token(Token = "0x6000302")]
	[Address(RVA = "0xD48E98", Offset = "0xD48E98", VA = "0xD48E98", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0xD48EA4", Offset = "0xD48EA4", VA = "0xD48EA4", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0xD48EB0", Offset = "0xD48EB0", VA = "0xD48EB0", Slot = "6")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0xD48EBC", Offset = "0xD48EBC", VA = "0xD48EBC", Slot = "7")]
	protected virtual void SetupCanvas()
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0xD49244", Offset = "0xD49244", VA = "0xD49244", Slot = "8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x801DB4", Offset = "0x801DB4")]
	protected virtual IEnumerator CreateDraggablePanel(Canvas canvas, Vector2 canvasSize)
	{
		return null;
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0xD492F4", Offset = "0xD492F4", VA = "0xD492F4", Slot = "9")]
	protected virtual void RemoveCanvas()
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0xD495D4", Offset = "0xD495D4", VA = "0xD495D4")]
	public Pvr_UICanvas()
	{
	}
}
[Token(Token = "0x200003E")]
public struct UIDraggableItemEventArgs
{
	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public GameObject target;
}
[Token(Token = "0x200003F")]
public delegate void UIDraggableItemEventHandler(object sender, UIDraggableItemEventArgs e);
[Token(Token = "0x2000040")]
public class Pvr_UIDraggableItem : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool restrictToDropZone;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool restrictToOriginalCanvas;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float moveOffset;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public GameObject validDropZone;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected RectTransform dragTransform;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected Vector3 startPosition;

	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	protected Quaternion startRotation;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected GameObject startDropZone;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected Transform startParent;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected Canvas startCanvas;

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected CanvasGroup canvasGroup;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected Pvr_InputModule currentInputmodule;

	[Token(Token = "0x14000018")]
	public event UIDraggableItemEventHandler DraggableItemDropped
	{
		[Token(Token = "0x600030D")]
		[Address(RVA = "0xD499D0", Offset = "0xD499D0", VA = "0xD499D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801E18", Offset = "0x801E18")]
		add
		{
		}
		[Token(Token = "0x600030E")]
		[Address(RVA = "0xD49A74", Offset = "0xD49A74", VA = "0xD49A74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801E28", Offset = "0x801E28")]
		remove
		{
		}
	}

	[Token(Token = "0x14000019")]
	public event UIDraggableItemEventHandler DraggableItemReset
	{
		[Token(Token = "0x600030F")]
		[Address(RVA = "0xD49B18", Offset = "0xD49B18", VA = "0xD49B18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801E38", Offset = "0x801E38")]
		add
		{
		}
		[Token(Token = "0x6000310")]
		[Address(RVA = "0xD49BBC", Offset = "0xD49BBC", VA = "0xD49BBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801E48", Offset = "0x801E48")]
		remove
		{
		}
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0xD49C60", Offset = "0xD49C60", VA = "0xD49C60", Slot = "7")]
	public virtual void OnDraggableItemDropped(UIDraggableItemEventArgs e)
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0xD49C80", Offset = "0xD49C80", VA = "0xD49C80", Slot = "8")]
	public virtual void OnDraggableItemReset(UIDraggableItemEventArgs e)
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0xD49CA0", Offset = "0xD49CA0", VA = "0xD49CA0", Slot = "4")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0xD49EB4", Offset = "0xD49EB4", VA = "0xD49EB4", Slot = "5")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0xD49EC0", Offset = "0xD49EC0", VA = "0xD49EC0", Slot = "6")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0xD4A300", Offset = "0xD4A300", VA = "0xD4A300", Slot = "9")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0xD4A3F4", Offset = "0xD4A3F4", VA = "0xD4A3F4", Slot = "10")]
	protected virtual Pvr_UIPointer GetPointer()
	{
		return null;
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0xD4A578", Offset = "0xD4A578", VA = "0xD4A578", Slot = "11")]
	protected virtual void SetDragPosition(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0xD4A83C", Offset = "0xD4A83C", VA = "0xD4A83C", Slot = "12")]
	protected virtual void ResetElement()
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0xD4A8EC", Offset = "0xD4A8EC", VA = "0xD4A8EC", Slot = "13")]
	protected virtual UIDraggableItemEventArgs SetEventPayload(GameObject target)
	{
		return default(UIDraggableItemEventArgs);
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0xD4A8F4", Offset = "0xD4A8F4", VA = "0xD4A8F4")]
	public Pvr_UIDraggableItem()
	{
	}
}
[Token(Token = "0x2000041")]
public class Pvr_UIDropZone : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected Pvr_UIDraggableItem droppableItem;

	[Token(Token = "0x600031C")]
	[Address(RVA = "0xD4A908", Offset = "0xD4A908", VA = "0xD4A908", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0xD4A9F8", Offset = "0xD4A9F8", VA = "0xD4A9F8", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0xD4AA80", Offset = "0xD4AA80", VA = "0xD4AA80")]
	public Pvr_UIDropZone()
	{
	}
}
[Token(Token = "0x2000042")]
public class Pvr_UIGraphicRaycaster : GraphicRaycaster
{
	[Serializable]
	[Token(Token = "0x2000157")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFDB8", Offset = "0x7FFDB8")]
	private sealed class <>c
	{
		[Token(Token = "0x4000B07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000B08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<RaycastResult> <>9__7_0;

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0xD4B990", Offset = "0xD4B990", VA = "0xD4B990")]
		public <>c()
		{
		}

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0xD4B998", Offset = "0xD4B998", VA = "0xD4B998")]
		internal int <Raycast>b__7_0(RaycastResult g1, RaycastResult g2)
		{
			return default(int);
		}
	}

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected Canvas currentCanvas;

	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected Vector2 lastKnownPosition;

	[Token(Token = "0x400025C")]
	protected const float UI_CONTROL_OFFSET = 1E-05f;

	[NonSerialized]
	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<RaycastResult> s_RaycastResults;

	[Token(Token = "0x17000048")]
	protected virtual Canvas canvas
	{
		[Token(Token = "0x6000323")]
		[Address(RVA = "0xD4B7A8", Offset = "0xD4B7A8", VA = "0xD4B7A8", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0xD4AA88", Offset = "0xD4AA88", VA = "0xD4AA88", Slot = "17")]
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0xD4AC38", Offset = "0xD4AC38", VA = "0xD4AC38", Slot = "22")]
	protected virtual void SetNearestRaycast(ref PointerEventData eventData, ref List<RaycastResult> resultAppendList, ref List<RaycastResult> raycastResults)
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0xD4AEBC", Offset = "0xD4AEBC", VA = "0xD4AEBC", Slot = "23")]
	protected virtual float GetHitDistance(Ray ray)
	{
		return default(float);
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0xD4B1DC", Offset = "0xD4B1DC", VA = "0xD4B1DC", Slot = "24")]
	protected virtual void Raycast(Canvas canvas, Camera eventCamera, Ray ray, ref List<RaycastResult> results)
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0xD4B850", Offset = "0xD4B850", VA = "0xD4B850")]
	public Pvr_UIGraphicRaycaster()
	{
	}
}
[Token(Token = "0x2000043")]
public struct UIPointerEventArgs
{
	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public bool isActive;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public GameObject currentTarget;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject previousTarget;

	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RaycastResult raycastResult;
}
[Token(Token = "0x2000044")]
public delegate void UIPointerEventHandler(object sender, UIPointerEventArgs e);
[Token(Token = "0x2000045")]
public class Pvr_UIPointer : MonoBehaviour
{
	[Token(Token = "0x2000158")]
	public enum ClickMethods
	{
		[Token(Token = "0x4000B0A")]
		ClickOnButtonUp,
		[Token(Token = "0x4000B0B")]
		ClickOnButtonDown
	}

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ClickMethods clickMethod;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[HideInInspector]
	public bool collisionClick;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	[HideInInspector]
	public bool pressToDrag;

	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public GameObject autoActivatingCanvas;

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public PointerEventData pointerEventData;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public GameObject hoveringElement;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public float hoverDurationTimer;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[HideInInspector]
	public bool canClickOnHover;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform pointerOriginTransform;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected bool pointerClicked;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	protected bool beamEnabledState;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	protected bool lastPointerPressState;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
	protected bool lastPointerClickState;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected GameObject currentTarget;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected EventSystem cachedEventSystem;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected Pvr_InputModule cachedVRInputModule;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected Transform originalPointerOriginTransform;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool TouchBtnValue;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	public static bool AppBtnValue;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
	public static bool TriggerBtnValue;

	[Token(Token = "0x1400001A")]
	public event UIPointerEventHandler UIPointerElementEnter
	{
		[Token(Token = "0x600032A")]
		[Address(RVA = "0xD4B9A8", Offset = "0xD4B9A8", VA = "0xD4B9A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801E58", Offset = "0x801E58")]
		add
		{
		}
		[Token(Token = "0x600032B")]
		[Address(RVA = "0xD4BA4C", Offset = "0xD4BA4C", VA = "0xD4BA4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801E68", Offset = "0x801E68")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001B")]
	public event UIPointerEventHandler UIPointerElementExit
	{
		[Token(Token = "0x600032C")]
		[Address(RVA = "0xD4BAF0", Offset = "0xD4BAF0", VA = "0xD4BAF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801E78", Offset = "0x801E78")]
		add
		{
		}
		[Token(Token = "0x600032D")]
		[Address(RVA = "0xD4BB94", Offset = "0xD4BB94", VA = "0xD4BB94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801E88", Offset = "0x801E88")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001C")]
	public event UIPointerEventHandler UIPointerElementClick
	{
		[Token(Token = "0x600032E")]
		[Address(RVA = "0xD4BC38", Offset = "0xD4BC38", VA = "0xD4BC38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801E98", Offset = "0x801E98")]
		add
		{
		}
		[Token(Token = "0x600032F")]
		[Address(RVA = "0xD4BCDC", Offset = "0xD4BCDC", VA = "0xD4BCDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801EA8", Offset = "0x801EA8")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001D")]
	public event UIPointerEventHandler UIPointerElementDragStart
	{
		[Token(Token = "0x6000330")]
		[Address(RVA = "0xD4BD80", Offset = "0xD4BD80", VA = "0xD4BD80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801EB8", Offset = "0x801EB8")]
		add
		{
		}
		[Token(Token = "0x6000331")]
		[Address(RVA = "0xD4BE24", Offset = "0xD4BE24", VA = "0xD4BE24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801EC8", Offset = "0x801EC8")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001E")]
	public event UIPointerEventHandler UIPointerElementDragEnd
	{
		[Token(Token = "0x6000332")]
		[Address(RVA = "0xD4BEC8", Offset = "0xD4BEC8", VA = "0xD4BEC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801ED8", Offset = "0x801ED8")]
		add
		{
		}
		[Token(Token = "0x6000333")]
		[Address(RVA = "0xD4BF6C", Offset = "0xD4BF6C", VA = "0xD4BF6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801EE8", Offset = "0x801EE8")]
		remove
		{
		}
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0xD4C010", Offset = "0xD4C010", VA = "0xD4C010", Slot = "4")]
	public virtual bool PointerActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0xD4C018", Offset = "0xD4C018", VA = "0xD4C018", Slot = "5")]
	public virtual bool IsSelectionButtonPressed()
	{
		return default(bool);
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0xD4C0F8", Offset = "0xD4C0F8", VA = "0xD4C0F8", Slot = "6")]
	public virtual Vector3 GetOriginPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0xD4C18C", Offset = "0xD4C18C", VA = "0xD4C18C", Slot = "7")]
	public virtual Vector3 GetOriginForward()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0xD4C220", Offset = "0xD4C220", VA = "0xD4C220", Slot = "8")]
	public virtual bool ValidClick(bool checkLastClick, bool lastClickState = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0xD4C23C", Offset = "0xD4C23C", VA = "0xD4C23C", Slot = "9")]
	protected virtual void ResetHoverTimer()
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0xD4C248", Offset = "0xD4C248", VA = "0xD4C248", Slot = "10")]
	public virtual void OnUIPointerElementEnter(UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0xD4C31C", Offset = "0xD4C31C", VA = "0xD4C31C", Slot = "11")]
	public virtual void OnUIPointerElementExit(UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0xD4C3E8", Offset = "0xD4C3E8", VA = "0xD4C3E8", Slot = "12")]
	public virtual void OnUIPointerElementClick(UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0xD4C4B4", Offset = "0xD4C4B4", VA = "0xD4C4B4", Slot = "13")]
	public virtual void OnUIPointerElementDragStart(UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0xD4C500", Offset = "0xD4C500", VA = "0xD4C500", Slot = "14")]
	public virtual void OnUIPointerElementDragEnd(UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0xD4C54C", Offset = "0xD4C54C", VA = "0xD4C54C", Slot = "15")]
	public virtual UIPointerEventArgs SetUIPointerEvent(RaycastResult currentRaycastResult, GameObject currentTarget, [Optional] GameObject lastTarget)
	{
		return default(UIPointerEventArgs);
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0xD4C5B0", Offset = "0xD4C5B0", VA = "0xD4C5B0", Slot = "16")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0xD4C5BC", Offset = "0xD4C5BC", VA = "0xD4C5BC", Slot = "17")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0xD4C5F4", Offset = "0xD4C5F4", VA = "0xD4C5F4", Slot = "18")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0xD4C65C", Offset = "0xD4C65C", VA = "0xD4C65C", Slot = "19")]
	protected virtual void ConfigureEventSystem()
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0xD4C800", Offset = "0xD4C800", VA = "0xD4C800")]
	public Pvr_UIPointer()
	{
	}
}
[Token(Token = "0x2000046")]
[ExecuteInEditMode]
public class Pvr_UnitySDKEditor : MonoBehaviour
{
	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool vrModeEnabled;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float mouseX;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float mouseY;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float mouseZ;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float neckModelScale;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool autoUntiltHead;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Vector3 neckOffset;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Matrix4x4 headView;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public Matrix4x4 leftEyeUndistortedProj;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[HideInInspector]
	public Matrix4x4 rightEyeUndistortedProj;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[HideInInspector]
	public Matrix4x4 leftEyeProj;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	[HideInInspector]
	public Matrix4x4 rightEyeProj;

	[Token(Token = "0x4000287")]
	private const float TOUCH_TIME_LIMIT = 0.2f;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private float touchStartTime;

	[Token(Token = "0x6000346")]
	[Address(RVA = "0xE70BB0", Offset = "0xE70BB0", VA = "0xE70BB0")]
	public Matrix4x4 UndistortedProjection(Eye eye)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0xE70BD4", Offset = "0xE70BD4", VA = "0xE70BD4")]
	public Matrix4x4 Projection(Eye eye)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0xE70BF8", Offset = "0xE70BF8", VA = "0xE70BF8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0xE70DD8", Offset = "0xE70DD8", VA = "0xE70DD8")]
	private void Update()
	{
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0xE70C0C", Offset = "0xE70C0C", VA = "0xE70C0C")]
	public void InitEyePara()
	{
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0xE70D50", Offset = "0xE70D50", VA = "0xE70D50")]
	private void InitEditorSensorPara()
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0xE71814", Offset = "0xE71814", VA = "0xE71814")]
	public static Matrix4x4 MakeProjection(float l, float t, float r, float b, float n, float f)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0xE719B8", Offset = "0xE719B8", VA = "0xE719B8")]
	public bool UpdateStatesensor()
	{
		return default(bool);
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0xE71098", Offset = "0xE71098", VA = "0xE71098")]
	public void ComputeEyesFromProfile()
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0xE71E40", Offset = "0xE71E40", VA = "0xE71E40")]
	public bool ResetUnitySDKSensor()
	{
		return default(bool);
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0xE70E6C", Offset = "0xE70E6C", VA = "0xE70E6C")]
	private void SimulateInput()
	{
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0xE7175C", Offset = "0xE7175C", VA = "0xE7175C")]
	private void FovAdjust()
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0xE71F04", Offset = "0xE71F04", VA = "0xE71F04")]
	private Rect RectAdjust(Rect eyeRect)
	{
		return default(Rect);
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0xE719D0", Offset = "0xE719D0", VA = "0xE719D0")]
	private void UpdateSimulatedSensor()
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0xE7152C", Offset = "0xE7152C", VA = "0xE7152C")]
	private void InitForEye(ref Material mat, ref Material mat1)
	{
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0xE71E54", Offset = "0xE71E54", VA = "0xE71E54")]
	private void EnableVEmodel()
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0xE720A0", Offset = "0xE720A0", VA = "0xE720A0")]
	public Pvr_UnitySDKEditor()
	{
	}
}
[Token(Token = "0x2000047")]
public class Pvr_VolumePowerBrightness : MonoBehaviour
{
	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool VolEnable;

	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool BattEnable;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text showResult;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text setVolumnum;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text setBrightnum;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string MusicPath;

	[Token(Token = "0x6000358")]
	[Address(RVA = "0xB1ABFC", Offset = "0xB1ABFC", VA = "0xB1ABFC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0xB1ACCC", Offset = "0xB1ACCC", VA = "0xB1ACCC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0xB1AD20", Offset = "0xB1AD20", VA = "0xB1AD20")]
	public void GetMaxVolumeNumber()
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0xB1ADC0", Offset = "0xB1ADC0", VA = "0xB1ADC0")]
	public void GetCurrentVolumeNumber()
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0xB1AE60", Offset = "0xB1AE60", VA = "0xB1AE60")]
	public void VolumeUp()
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0xB1AEE4", Offset = "0xB1AEE4", VA = "0xB1AEE4")]
	public void VolumeDown()
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0xB1AF68", Offset = "0xB1AF68", VA = "0xB1AF68")]
	public void SetVolumeNum()
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0xB1B080", Offset = "0xB1B080", VA = "0xB1B080")]
	public void SetBrightness()
	{
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0xB1B198", Offset = "0xB1B198", VA = "0xB1B198")]
	public void GetCurrentBrightness()
	{
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0xB1B238", Offset = "0xB1B238", VA = "0xB1B238")]
	public bool setAudio(string s)
	{
		return default(bool);
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0xB1B2C8", Offset = "0xB1B2C8", VA = "0xB1B2C8")]
	public bool setBattery(string s)
	{
		return default(bool);
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0xB1AC64", Offset = "0xB1AC64", VA = "0xB1AC64")]
	private bool InitBatteryVolClass()
	{
		return default(bool);
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0xB1AC6C", Offset = "0xB1AC6C", VA = "0xB1AC6C")]
	private bool StartBatteryReceiver(string startreceivre)
	{
		return default(bool);
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0xB1AD18", Offset = "0xB1AD18", VA = "0xB1AD18")]
	private bool StopBatteryReceiver()
	{
		return default(bool);
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0xB1AC9C", Offset = "0xB1AC9C", VA = "0xB1AC9C")]
	private bool StartAudioReceiver(string startreceivre)
	{
		return default(bool);
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0xB1AD10", Offset = "0xB1AD10", VA = "0xB1AD10")]
	private bool StopAudioReceiver()
	{
		return default(bool);
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0xB1B358", Offset = "0xB1B358", VA = "0xB1B358")]
	public Pvr_VolumePowerBrightness()
	{
	}
}
[Token(Token = "0x2000048")]
public class DepthNormalsFeature : ScriptableRendererFeature
{
	[Token(Token = "0x2000159")]
	private class DepthNormalsPass : ScriptableRenderPass
	{
		[Token(Token = "0x4000B0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int kDepthBufferBits;

		[Token(Token = "0x4000B0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801300", Offset = "0x801300")]
		private RenderTargetHandle <depthAttachmentHandle>k__BackingField;

		[Token(Token = "0x4000B0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801310", Offset = "0x801310")]
		private RenderTextureDescriptor <descriptor>k__BackingField;

		[Token(Token = "0x4000B0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Material depthNormalsMaterial;

		[Token(Token = "0x4000B10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private FilteringSettings m_FilteringSettings;

		[Token(Token = "0x4000B11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private string m_ProfilerTag;

		[Token(Token = "0x4000B12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private ShaderTagId m_ShaderTagId;

		[Token(Token = "0x170000F3")]
		private RenderTargetHandle depthAttachmentHandle
		{
			[Token(Token = "0x6000A07")]
			[Address(RVA = "0xBB7BE8", Offset = "0xBB7BE8", VA = "0xBB7BE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8045BC", Offset = "0x8045BC")]
			get
			{
				return default(RenderTargetHandle);
			}
			[Token(Token = "0x6000A08")]
			[Address(RVA = "0xBB7BF0", Offset = "0xBB7BF0", VA = "0xBB7BF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8045CC", Offset = "0x8045CC")]
			set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		internal RenderTextureDescriptor descriptor
		{
			[Token(Token = "0x6000A09")]
			[Address(RVA = "0xBB7BF8", Offset = "0xBB7BF8", VA = "0xBB7BF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8045DC", Offset = "0x8045DC")]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0xBB7C18", Offset = "0xBB7C18", VA = "0xBB7C18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8045EC", Offset = "0x8045EC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0xBB79A4", Offset = "0xBB79A4", VA = "0xBB79A4")]
		public DepthNormalsPass(RenderQueueRange renderQueueRange, LayerMask layerMask, Material material)
		{
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0xBB7B80", Offset = "0xBB7B80", VA = "0xBB7B80")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle depthAttachmentHandle)
		{
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0xBB7C38", Offset = "0xBB7C38", VA = "0xBB7C38", Slot = "4")]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0xBB7D0C", Offset = "0xBB7D0C", VA = "0xBB7D0C", Slot = "7")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0xBB7F40", Offset = "0xBB7F40", VA = "0xBB7F40", Slot = "5")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}
	}

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private DepthNormalsPass depthNormalsPass;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RenderTargetHandle depthNormalsTexture;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Material depthNormalsMaterial;

	[Token(Token = "0x6000369")]
	[Address(RVA = "0xBB788C", Offset = "0xBB788C", VA = "0xBB788C", Slot = "4")]
	public override void Create()
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0xBB7AB8", Offset = "0xBB7AB8", VA = "0xBB7AB8", Slot = "5")]
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0xBB7BE0", Offset = "0xBB7BE0", VA = "0xBB7BE0")]
	public DepthNormalsFeature()
	{
	}
}
[Token(Token = "0x2000049")]
public class OutlineFeature : ScriptableRendererFeature
{
	[Token(Token = "0x200015A")]
	private class OutlinePass : ScriptableRenderPass
	{
		[Token(Token = "0x4000B13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801320", Offset = "0x801320")]
		private RenderTargetIdentifier <source>k__BackingField;

		[Token(Token = "0x4000B14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801330", Offset = "0x801330")]
		private RenderTargetHandle <destination>k__BackingField;

		[Token(Token = "0x4000B15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Material outlineMaterial;

		[Token(Token = "0x4000B16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RenderTargetHandle temporaryColorTexture;

		[Token(Token = "0x170000F5")]
		private RenderTargetIdentifier source
		{
			[Token(Token = "0x6000A10")]
			[Address(RVA = "0xE37A6C", Offset = "0xE37A6C", VA = "0xE37A6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8045FC", Offset = "0x8045FC")]
			get
			{
				return default(RenderTargetIdentifier);
			}
			[Token(Token = "0x6000A11")]
			[Address(RVA = "0xE37A84", Offset = "0xE37A84", VA = "0xE37A84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80460C", Offset = "0x80460C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		private RenderTargetHandle destination
		{
			[Token(Token = "0x6000A12")]
			[Address(RVA = "0xE37A9C", Offset = "0xE37A9C", VA = "0xE37A9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80461C", Offset = "0x80461C")]
			get
			{
				return default(RenderTargetHandle);
			}
			[Token(Token = "0x6000A13")]
			[Address(RVA = "0xE37AA4", Offset = "0xE37AA4", VA = "0xE37AA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80462C", Offset = "0x80462C")]
			set
			{
			}
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0xE379E0", Offset = "0xE379E0", VA = "0xE379E0")]
		public void Setup(RenderTargetIdentifier source, RenderTargetHandle destination)
		{
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0xE377D4", Offset = "0xE377D4", VA = "0xE377D4")]
		public OutlinePass(Material outlineMaterial)
		{
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0xE37AAC", Offset = "0xE37AAC", VA = "0xE37AAC", Slot = "4")]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0xE37AB0", Offset = "0xE37AB0", VA = "0xE37AB0", Slot = "7")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0xE37D70", Offset = "0xE37D70", VA = "0xE37D70", Slot = "5")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200015B")]
	public class OutlineSettings
	{
		[Token(Token = "0x4000B17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material outlineMaterial;

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0xE37A64", Offset = "0xE37A64", VA = "0xE37A64")]
		public OutlineSettings()
		{
		}
	}

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OutlineSettings settings;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OutlinePass outlinePass;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RenderTargetHandle outlineTexture;

	[Token(Token = "0x600036C")]
	[Address(RVA = "0xE37738", Offset = "0xE37738", VA = "0xE37738", Slot = "4")]
	public override void Create()
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0xE37800", Offset = "0xE37800", VA = "0xE37800", Slot = "5")]
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0xE379FC", Offset = "0xE379FC", VA = "0xE379FC")]
	public OutlineFeature()
	{
	}
}
[Token(Token = "0x200004A")]
public class Readme : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x200015C")]
	public class Section
	{
		[Token(Token = "0x4000B18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string heading;

		[Token(Token = "0x4000B19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x4000B1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string linkText;

		[Token(Token = "0x4000B1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string url;

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0xB1B5DC", Offset = "0xB1B5DC", VA = "0xB1B5DC")]
		public Section()
		{
		}
	}

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D icon;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string title;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Section[] sections;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool loadedLayout;

	[Token(Token = "0x600036F")]
	[Address(RVA = "0xB1B5D4", Offset = "0xB1B5D4", VA = "0xB1B5D4")]
	public Readme()
	{
	}
}
[Token(Token = "0x200004B")]
public class mParent : MonoBehaviour
{
	[Token(Token = "0x200015D")]
	private enum Mode
	{
		[Token(Token = "0x4000B1D")]
		Idle,
		[Token(Token = "0x4000B1E")]
		Ground,
		[Token(Token = "0x4000B1F")]
		Hand,
		[Token(Token = "0x4000B20")]
		Back
	}

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject mParentCon;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Mode m_Mode;

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x181EBB8", Offset = "0x181EBB8", VA = "0x181EBB8")]
	public void Update()
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x181ECE8", Offset = "0x181ECE8", VA = "0x181ECE8")]
	public void Start()
	{
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x181ED60", Offset = "0x181ED60", VA = "0x181ED60")]
	public void hand()
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x181EDD8", Offset = "0x181EDD8", VA = "0x181EDD8")]
	public void back()
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0x181EE50", Offset = "0x181EE50", VA = "0x181EE50")]
	public mParent()
	{
	}
}
[Token(Token = "0x200004C")]
public class KeepAlive : MonoBehaviour
{
	[Token(Token = "0x6000375")]
	[Address(RVA = "0xBBE7C8", Offset = "0xBBE7C8", VA = "0xBBE7C8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0xBBE830", Offset = "0xBBE830", VA = "0xBBE830")]
	public KeepAlive()
	{
	}
}
[Token(Token = "0x200004D")]
public class OculusIntegration : UnityEngine.Object
{
	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string userName;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool userGotName;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool oculusConFailed;

	[Token(Token = "0x6000377")]
	[Address(RVA = "0xE37144", Offset = "0xE37144", VA = "0xE37144")]
	public void Init()
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0xE373A0", Offset = "0xE373A0", VA = "0xE373A0")]
	private void OnInitializationCallback(Message<PlatformInitialize> msg)
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0xE374B4", Offset = "0xE374B4", VA = "0xE374B4")]
	private void EntitlementCallback(Message msg)
	{
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0xE375D8", Offset = "0xE375D8", VA = "0xE375D8")]
	private void GetLoggedInOculusUserCallback(Message<User> msg)
	{
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0xE376D0", Offset = "0xE376D0", VA = "0xE376D0")]
	public OculusIntegration()
	{
	}
}
[Token(Token = "0x200004E")]
public class PicoIntegration : MonoBehaviour
{
	[Token(Token = "0x600037C")]
	[Address(RVA = "0xE38974", Offset = "0xE38974", VA = "0xE38974")]
	public PicoIntegration()
	{
	}
}
[Token(Token = "0x200004F")]
public class UIstateTemplate
{
	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject courseSelectMenu;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject settingsMenu;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject heightMenu;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject beginMenu;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject syncedRaceMenu;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject endMenu;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject pauseMenu;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject itemMenu;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject musicMenu;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject gameOverMenu;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject yesNoPromptSettings;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject yesNoPromptGear;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject yesNoPromptMap;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject difficulty;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject welcomeInfo;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject scoreBreakdown;

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject scoreBreakdownEnd;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject syncedRaceScore;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public RawImage easySelected;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public RawImage normalSelected;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public RawImage hardSelected;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public RawImage freeSelected;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public RectTransform loadingFade;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public RawImage loadingFadeImage;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public CanvasGroup whiteFade;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public bool fadeIn;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
	public bool fadeOut;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDA")]
	public bool useBlackFade;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDB")]
	public bool fadeReadyForLoad;

	[Token(Token = "0x600037D")]
	[Address(RVA = "0xB29668", Offset = "0xB29668", VA = "0xB29668")]
	public void HideAll()
	{
	}

	[Token(Token = "0x600037E")]
	[Address(RVA = "0xB2DED4", Offset = "0xB2DED4", VA = "0xB2DED4")]
	public UIstateTemplate()
	{
	}
}
[Token(Token = "0x2000050")]
public class ObjectStateTemplate
{
	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject stickRight;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject stickLeft;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject stickPointer;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject skiRight;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject skiLeft;

	[Token(Token = "0x600037F")]
	[Address(RVA = "0xE36DFC", Offset = "0xE36DFC", VA = "0xE36DFC")]
	public void HideAll()
	{
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0xE36F9C", Offset = "0xE36F9C", VA = "0xE36F9C")]
	public void ShowDefault()
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0xE3713C", Offset = "0xE3713C", VA = "0xE3713C")]
	public ObjectStateTemplate()
	{
	}
}
[Token(Token = "0x2000051")]
public class UIManager : MonoBehaviour
{
	[Token(Token = "0x200015E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFDC8", Offset = "0x7FFDC8")]
	private sealed class <SpawnBeginMenu>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000B22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000B23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UIManager <>4__this;

		[Token(Token = "0x4000B24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UIstateTemplate UIstate;

		[Token(Token = "0x170000F7")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0xB2E274", Offset = "0xB2E274", VA = "0xB2E274", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F8")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A20")]
			[Address(RVA = "0xB2E2DC", Offset = "0xB2E2DC", VA = "0xB2E2DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0xB27D0C", Offset = "0xB27D0C", VA = "0xB27D0C")]
		[DebuggerHidden]
		public <SpawnBeginMenu>d__52(int <>1__state)
		{
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0xB2DEDC", Offset = "0xB2DEDC", VA = "0xB2DEDC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0xB2DEE0", Offset = "0xB2DEE0", VA = "0xB2DEE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0xB2E27C", Offset = "0xB2E27C", VA = "0xB2E27C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200015F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFDD8", Offset = "0x7FFDD8")]
	private sealed class <SpawnEndMenu>d__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000B26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000B27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UIstateTemplate UIstate;

		[Token(Token = "0x4000B28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UIManager <>4__this;

		[Token(Token = "0x4000B29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ObjectStateTemplate ObjectState;

		[Token(Token = "0x4000B2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <timer>5__2;

		[Token(Token = "0x170000F9")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A24")]
			[Address(RVA = "0xB2ED08", Offset = "0xB2ED08", VA = "0xB2ED08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FA")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A26")]
			[Address(RVA = "0xB2ED70", Offset = "0xB2ED70", VA = "0xB2ED70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0xB27DBC", Offset = "0xB27DBC", VA = "0xB27DBC")]
		[DebuggerHidden]
		public <SpawnEndMenu>d__53(int <>1__state)
		{
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0xB2E2E4", Offset = "0xB2E2E4", VA = "0xB2E2E4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0xB2E2E8", Offset = "0xB2E2E8", VA = "0xB2E2E8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0xB2ED10", Offset = "0xB2ED10", VA = "0xB2ED10", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000160")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFDE8", Offset = "0x7FFDE8")]
	private sealed class <SpawnItemMenu>d__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000B2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000B2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ObjectStateTemplate ObjectState;

		[Token(Token = "0x4000B2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UIManager <>4__this;

		[Token(Token = "0x4000B2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UIstateTemplate UIstate;

		[Token(Token = "0x4000B30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <timer>5__2;

		[Token(Token = "0x170000FB")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A2A")]
			[Address(RVA = "0xB2F020", Offset = "0xB2F020", VA = "0xB2F020", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FC")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A2C")]
			[Address(RVA = "0xB2F088", Offset = "0xB2F088", VA = "0xB2F088", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0xB27E6C", Offset = "0xB27E6C", VA = "0xB27E6C")]
		[DebuggerHidden]
		public <SpawnItemMenu>d__54(int <>1__state)
		{
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0xB2ED78", Offset = "0xB2ED78", VA = "0xB2ED78", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0xB2ED7C", Offset = "0xB2ED7C", VA = "0xB2ED7C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0xB2F028", Offset = "0xB2F028", VA = "0xB2F028", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000161")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFDF8", Offset = "0x7FFDF8")]
	private struct <populateScoreBoard>d__60 : IAsyncStateMachine
	{
		[Token(Token = "0x4000B31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000B32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x4000B33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string sceneName;

		[Token(Token = "0x4000B34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UIstateTemplate UIstate;

		[Token(Token = "0x4000B35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UIManager <>4__this;

		[Token(Token = "0x4000B36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private scoreList <scoreData>5__2;

		[Token(Token = "0x4000B37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<scoreList> <>u__1;

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0xB2F090", Offset = "0xB2F090", VA = "0xB2F090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0xB2FD68", Offset = "0xB2FD68", VA = "0xB2FD68", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UIstateTemplate UIstate;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ObjectStateTemplate ObjectState;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public walletObject wallet;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public OVRInput.Controller pointerButton;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject selectedItem;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool click;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private AudioSource clickSoundEffect;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private AudioSource tagSoundEffect;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private calcBodyPosition body;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private calcBodyMovement move;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private dataManager data;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private connectionManager connection;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private particleEffects effect;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private stateManager state;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private courseRhythm cr;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private multiplayerManager multiplayer;

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private int layerMaskMainUI;

	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private bool triggerHeld;

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private string menuSelectedScene;

	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private List<GameObject> nestedMenus;

	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private List<GameObject> activeBackdrops;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Renderer pointerLoc;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private GameObject clickLoc;

	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private ParticleSystem clickLocEmit;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Vector3 pointerOrigin;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private Vector3 pointerDir;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private bool itemAccepted;

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private float loadingFadeTimer;

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private float clearHighLightTimer;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private float highLightTimer;

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private bool courseInit;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private GameObject currentLockIcon;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private GameObject currentUnLockIcon;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private Transform sfxBar;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private Transform musicBar;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private AudioMixer audioMixer;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private TextMeshProUGUI multiplayerRoomNameInput;

	[Token(Token = "0x6000382")]
	[Address(RVA = "0xB25950", Offset = "0xB25950", VA = "0xB25950")]
	public void TogglePuaseMenu(UIstateTemplate UIstate, ObjectStateTemplate ObjectState)
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0xB25E8C", Offset = "0xB25E8C", VA = "0xB25E8C")]
	public void ResumePuaseMenu(UIstateTemplate UIstate, ObjectStateTemplate ObjectState)
	{
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0xB25EE4", Offset = "0xB25EE4", VA = "0xB25EE4")]
	public void toggleHeightAdjustment(UIstateTemplate UIstate)
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0xB26034", Offset = "0xB26034", VA = "0xB26034")]
	public void toggleSetting(UIstateTemplate UIstate, string settingName, bool flip = true)
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0xB26300", Offset = "0xB26300", VA = "0xB26300")]
	private int checkGear(UIstateTemplate UIstate, string gearName)
	{
		return default(int);
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0xB26498", Offset = "0xB26498", VA = "0xB26498")]
	private void updateGear(UIstateTemplate UIstate, string gearName)
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0xB26640", Offset = "0xB26640", VA = "0xB26640")]
	public void toggleGear(UIstateTemplate UIstate, string gearName, bool flip = true)
	{
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0xB26BF4", Offset = "0xB26BF4", VA = "0xB26BF4")]
	public void toggleMusicMenu(UIstateTemplate UIstate)
	{
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0xB26F30", Offset = "0xB26F30", VA = "0xB26F30")]
	public void toggleSong(UIstateTemplate UIstate, string settingName)
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0xB27190", Offset = "0xB27190", VA = "0xB27190")]
	public void selectDifficulty(UIstateTemplate UIstate, string settingName)
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0xB2748C", Offset = "0xB2748C", VA = "0xB2748C")]
	public void setVolumeBars()
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0xB2787C", Offset = "0xB2787C", VA = "0xB2787C")]
	private void setMusicFreeRideIcon()
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0xB27930", Offset = "0xB27930", VA = "0xB27930")]
	private void setVoiPIcon()
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0xB27704", Offset = "0xB27704", VA = "0xB27704")]
	public void setVolume()
	{
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0xB279EC", Offset = "0xB279EC", VA = "0xB279EC")]
	public void toggleDifficultyMenu(UIstateTemplate UIstate)
	{
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0xB27C90", Offset = "0xB27C90", VA = "0xB27C90")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x801EF8", Offset = "0x801EF8")]
	public IEnumerator SpawnBeginMenu(UIstateTemplate UIstate, ObjectStateTemplate ObjectState)
	{
		return null;
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0xB27D38", Offset = "0xB27D38", VA = "0xB27D38")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x801F5C", Offset = "0x801F5C")]
	public IEnumerator SpawnEndMenu(UIstateTemplate UIstate, ObjectStateTemplate ObjectState)
	{
		return null;
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0xB27DE8", Offset = "0xB27DE8", VA = "0xB27DE8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x801FC0", Offset = "0x801FC0")]
	public IEnumerator SpawnItemMenu(UIstateTemplate UIstate, ObjectStateTemplate ObjectState)
	{
		return null;
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0xB27E98", Offset = "0xB27E98", VA = "0xB27E98")]
	public void AcceptBeginMenu(UIstateTemplate UIstate, ObjectStateTemplate ObjectState)
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0xB28024", Offset = "0xB28024", VA = "0xB28024")]
	public void AcceptGameOverMenu(UIstateTemplate UIstate)
	{
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0xB28078", Offset = "0xB28078", VA = "0xB28078")]
	public void LerpFade(UIstateTemplate UIstate, int fadeTarget, float fadeDelay)
	{
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0xB28724", Offset = "0xB28724", VA = "0xB28724")]
	public void displayDifficultySelection(UIstateTemplate UIstate)
	{
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0xB28984", Offset = "0xB28984", VA = "0xB28984")]
	public void initSettingsMenu()
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0xB28C60", Offset = "0xB28C60", VA = "0xB28C60")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x802024", Offset = "0x802024")]
	public void populateScoreBoard(UIstateTemplate UIstate, string sceneName)
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0xB28D30", Offset = "0xB28D30", VA = "0xB28D30")]
	public void HideBackdrop(GameObject selectObj)
	{
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0xB28E80", Offset = "0xB28E80", VA = "0xB28E80")]
	public void ShowBackdrop(GameObject selectObj)
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0xB28FF4", Offset = "0xB28FF4", VA = "0xB28FF4")]
	public void forceBegin()
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0xB290CC", Offset = "0xB290CC", VA = "0xB290CC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0xB29B48", Offset = "0xB29B48", VA = "0xB29B48")]
	private void Start()
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0xB29EF4", Offset = "0xB29EF4", VA = "0xB29EF4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0xB25B70", Offset = "0xB25B70", VA = "0xB25B70")]
	public Transform FindDeepChild(Transform parent, string name)
	{
		return null;
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0xB2D998", Offset = "0xB2D998", VA = "0xB2D998")]
	private static void OpenOculusStorePDPAndroid(string targetAppID)
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0xB2DDF4", Offset = "0xB2DDF4", VA = "0xB2DDF4")]
	public UIManager()
	{
	}
}
[Token(Token = "0x2000052")]
public class analyzeMusic : MonoBehaviour
{
	[Token(Token = "0x2000162")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFE08", Offset = "0x7FFE08")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000B38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<float> source;

		[Token(Token = "0x4000B39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int width;

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0xA6F774", Offset = "0xA6F774", VA = "0xA6F774")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0xA6F784", Offset = "0xA6F784", VA = "0xA6F784")]
		internal float <RollingAverage>b__0(int i)
		{
			return default(float);
		}
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0xA6EF8C", Offset = "0xA6EF8C", VA = "0xA6EF8C")]
	public List<float> generateBeatMap(AudioClip clip, int sampleOffset = 1024)
	{
		return null;
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0xA6F560", Offset = "0xA6F560", VA = "0xA6F560")]
	private static IList<int> FindPeaks(IList<float> values, int rangeOfPeaks)
	{
		return null;
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0xA6F468", Offset = "0xA6F468", VA = "0xA6F468")]
	private List<float> RollingAverage(List<float> source, int width)
	{
		return null;
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0xA6F77C", Offset = "0xA6F77C", VA = "0xA6F77C")]
	public analyzeMusic()
	{
	}
}
[Token(Token = "0x2000053")]
public class attentionTrigger : MonoBehaviour
{
	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject attentionTarget;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float attentionTimer;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private particleEffects effects;

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0xA6F800", Offset = "0xA6F800", VA = "0xA6F800")]
	private void Start()
	{
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0xA6F870", Offset = "0xA6F870", VA = "0xA6F870")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0xA6F8D4", Offset = "0xA6F8D4", VA = "0xA6F8D4")]
	public attentionTrigger()
	{
	}
}
[Token(Token = "0x2000054")]
public class avalancheManager : MonoBehaviour
{
	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject followTarget;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float avalancheSpeed;

	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private stateManager state;

	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private particleEffects effects;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject scriptHolder;

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private CharacterController charControl;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private ParticleSystem avalanche1;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private ParticleSystem avalanche2;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool init;

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0xA6F8E4", Offset = "0xA6F8E4", VA = "0xA6F8E4")]
	private void Start()
	{
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0xA6FA1C", Offset = "0xA6FA1C", VA = "0xA6FA1C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0xA6FE8C", Offset = "0xA6FE8C", VA = "0xA6FE8C")]
	public avalancheManager()
	{
	}
}
[Token(Token = "0x2000055")]
public class avalancheTrigger : MonoBehaviour
{
	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject avalanche;

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0xA6FE94", Offset = "0xA6FE94", VA = "0xA6FE94")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0xA6FF2C", Offset = "0xA6FF2C", VA = "0xA6FF2C")]
	public avalancheTrigger()
	{
	}
}
[Token(Token = "0x2000056")]
public class beginMenu : MonoBehaviour
{
	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D t1;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Texture2D t2;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Texture2D c2;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Texture2D c3;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Texture2D c4;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Texture2D c6;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D c7;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Texture2D c8;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Texture2D c9;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Texture2D c10;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Texture2D c11;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Texture2D c12;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Texture2D c13;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Texture2D c14;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Texture2D c15;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Texture2D c16;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Texture2D c17;

	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Texture2D c18;

	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Sprite race;

	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Sprite endless;

	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Sprite practice;

	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Sprite obstacle;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Sprite jump;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public RawImage header;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public RawImage musicFreeRide;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Image gamemode;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public GameObject freeRide;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public GameObject easy;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public GameObject normal;

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public GameObject hard;

	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public localizedText gameInfoTxt;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private stateManager state;

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0xA6FFA4", Offset = "0xA6FFA4", VA = "0xA6FFA4")]
	private void Start()
	{
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0xA7069C", Offset = "0xA7069C", VA = "0xA7069C")]
	public beginMenu()
	{
	}
}
[Token(Token = "0x2000057")]
public class birdsEscaping : MonoBehaviour
{
	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem birds;

	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float timer;

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0xA706A4", Offset = "0xA706A4", VA = "0xA706A4")]
	private void Start()
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0xA7070C", Offset = "0xA7070C", VA = "0xA7070C")]
	private void Update()
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0xA7078C", Offset = "0xA7078C", VA = "0xA7078C")]
	public birdsEscaping()
	{
	}
}
[Token(Token = "0x2000058")]
public class bodyColliderManager : MonoBehaviour
{
	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private calcBodyPosition body;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject bodyObj;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject rightHandObj;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject leftHandObj;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private BoxCollider bodyCol;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private BoxCollider rightHandCol;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private BoxCollider leftHandCol;

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0xA70794", Offset = "0xA70794", VA = "0xA70794")]
	private void Start()
	{
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0xA70A90", Offset = "0xA70A90", VA = "0xA70A90")]
	private void Update()
	{
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0xA70CB0", Offset = "0xA70CB0", VA = "0xA70CB0")]
	public bodyColliderManager()
	{
	}
}
[Token(Token = "0x2000059")]
public class calcBodyMovement : MonoBehaviour
{
	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800C38", Offset = "0x800C38")]
	private static calcBodyMovement <Instance>k__BackingField;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 velocityVector;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 direction;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float speed;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float speedGradient;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float turnAngle;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float jumpEnabler;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float jumpEnablerCap;

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float flowMultiplier;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool isGrounded;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float jumpTimer;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool punting;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float heightGained;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int artificalJumpFac;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int maxFallAngle;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool skiJumpMode;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float skiJumpLength;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool lowDeAcceleration;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Vector2 airControlFac;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float impuleTimer;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float impuleForce;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float tuneTurnSpeed;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float deltaSpeed;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float airAlignment;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public bool stickInContact;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
	public bool onSlipperySurface;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public Vector3 slipperyNormal;

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float slipperyTimer;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public bool inStopTurn;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Vector3 skiVector;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public GameObject player;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private calcBodyPosition body;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public CharacterController CharControl;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private puntLocomotion punt;

	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private slopeLocomotion slope;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private stateManager state;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private particleEffects effect;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private damageManager damage;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private float speedCap;

	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private float frameSpeedCap;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private float heightBoost;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private Vector3 jumpVector;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private Vector3 velocityAirVector;

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private Vector2 accelerationFactors;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	private float turnAngleFactor;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private float prevSpeed;

	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	private float heightSpeedBoost;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private List<float> slopeGradientBoostLst;

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private float slopeGradientBoost;

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private int halfPipeFac;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private List<Vector3> charPosLst;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private bool initOnGround;

	[Token(Token = "0x17000049")]
	public static calcBodyMovement Instance
	{
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xA70CB8", Offset = "0xA70CB8", VA = "0xA70CB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x802088", Offset = "0x802088")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xA70D08", Offset = "0xA70D08", VA = "0xA70D08")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x802098", Offset = "0x802098")]
		private set
		{
		}
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0xA70D5C", Offset = "0xA70D5C", VA = "0xA70D5C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0xA710E4", Offset = "0xA710E4", VA = "0xA710E4")]
	private void Start()
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0xA711E4", Offset = "0xA711E4", VA = "0xA711E4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0xA72F94", Offset = "0xA72F94", VA = "0xA72F94")]
	public calcBodyMovement()
	{
	}
}
[Token(Token = "0x200005A")]
public class calcBodyPosition : MonoBehaviour
{
	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800C48", Offset = "0x800C48")]
	private static calcBodyPosition <Instance>k__BackingField;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 forwardDirection;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 heading;

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 noHandsHeading;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 rightControllerPosition;

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3 leftControllerPosition;

	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Vector3 rightControllerDirection;

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector3 leftControllerDirection;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Vector3 eyeDirection;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Transform rightHandAnchor;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Transform leftHandAnchor;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject cameraAnchor;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Vector3 bodyPosition;

	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public float bodyHeight;

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float deltaBodyHeight;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<float> bodyHeightLst;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Quaternion rotationOffset;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Vector3 localBackPos;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public bool allowSkiControl;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
	public bool turnRebound;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCE")]
	public bool handsInView;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public float handsApartRatio;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public float handsApartRatioThreshold;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public float handsApartRatioBoost;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Transform startPos;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private stateManager state;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private dataManager data;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private slopeLocomotion slope;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private Transform myPlayer;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private GameObject myFeet;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private GameObject myBack;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private GameObject myBackAnchor;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private GameObject localCalcObj;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private Vector3 handsHeading;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private Vector3 bodyHeading;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private float leanAngle;

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	private float offAlignemtTimer;

	[Token(Token = "0x1700004A")]
	public static calcBodyPosition Instance
	{
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xA73194", Offset = "0xA73194", VA = "0xA73194")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8020A8", Offset = "0x8020A8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xA731E4", Offset = "0xA731E4", VA = "0xA731E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8020B8", Offset = "0x8020B8")]
		private set
		{
		}
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0xA73238", Offset = "0xA73238", VA = "0xA73238")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0xA73314", Offset = "0xA73314", VA = "0xA73314")]
	private void Start()
	{
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0xA739B8", Offset = "0xA739B8", VA = "0xA739B8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0xA73AA8", Offset = "0xA73AA8", VA = "0xA73AA8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0xA738E4", Offset = "0xA738E4", VA = "0xA738E4")]
	public void resetBackPos()
	{
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0xA73658", Offset = "0xA73658", VA = "0xA73658")]
	public void tuneBodyHeight()
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0xA74984", Offset = "0xA74984", VA = "0xA74984")]
	public calcBodyPosition()
	{
	}
}
[Token(Token = "0x200005B")]
public class cameraFollow : MonoBehaviour
{
	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float speed;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float keepAtDist;

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0xA74A40", Offset = "0xA74A40", VA = "0xA74A40")]
	private void Start()
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0xA74A44", Offset = "0xA74A44", VA = "0xA74A44")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0xA74CC0", Offset = "0xA74CC0", VA = "0xA74CC0")]
	public cameraFollow()
	{
	}
}
[Token(Token = "0x200005C")]
public class cloudManager : MonoBehaviour
{
	[Token(Token = "0x60003C9")]
	[Address(RVA = "0xA74CD0", Offset = "0xA74CD0", VA = "0xA74CD0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0xA74D70", Offset = "0xA74D70", VA = "0xA74D70")]
	public cloudManager()
	{
	}
}
[Token(Token = "0x200005D")]
public class AuthObject
{
	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string idToken;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string email;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string refreshToken;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string expiresIn;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string localId;

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0xBB241C", Offset = "0xBB241C", VA = "0xBB241C")]
	public AuthObject()
	{
	}
}
[Token(Token = "0x200005E")]
public class nameObject
{
	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string datetime;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int userType;

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool upgraded;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string playerID;

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0xB88EF0", Offset = "0xB88EF0", VA = "0xB88EF0")]
	public nameObject()
	{
	}
}
[Token(Token = "0x200005F")]
public class tuneParamObject
{
	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int tuneGateFreq;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int tuneGateSize;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tuneGateOffset;

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float tuneTurnSpeed;

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tuneSpeedFac;

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x147D1D4", Offset = "0x147D1D4", VA = "0x147D1D4")]
	public tuneParamObject()
	{
	}
}
[Token(Token = "0x2000060")]
public class connectionManager : MonoBehaviour
{
	[StructLayout(3)]
	[Token(Token = "0x2000163")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFE18", Offset = "0x7FFE18")]
	private struct <anonAuthRequest>d__9 : IAsyncStateMachine
	{
		[Token(Token = "0x4000B3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000B3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Token(Token = "0x4000B3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public connectionManager <>4__this;

		[Token(Token = "0x4000B3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter<HttpResponseMessage> <>u__1;

		[Token(Token = "0x4000B3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<string> <>u__2;

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0xA76028", Offset = "0xA76028", VA = "0xA76028", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0xA764A0", Offset = "0xA764A0", VA = "0xA764A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000164")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFE28", Offset = "0x7FFE28")]
	private struct <putScore>d__10 : IAsyncStateMachine
	{
		[Token(Token = "0x4000B3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000B40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Token(Token = "0x4000B41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string runId;

		[Token(Token = "0x4000B42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string dateTime;

		[Token(Token = "0x4000B43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string playerName;

		[Token(Token = "0x4000B44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string courseName;

		[Token(Token = "0x4000B45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int scoreValue;

		[Token(Token = "0x4000B46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int difficulty;

		[Token(Token = "0x4000B47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string authKey;

		[Token(Token = "0x4000B48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TaskAwaiter<HttpResponseMessage> <>u__1;

		[Token(Token = "0x4000B49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TaskAwaiter<string> <>u__2;

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0xA7AAD4", Offset = "0xA7AAD4", VA = "0xA7AAD4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0xA7AE74", Offset = "0xA7AE74", VA = "0xA7AE74", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000165")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFE38", Offset = "0x7FFE38")]
	private struct <putScoreWrap>d__11 : IAsyncStateMachine
	{
		[Token(Token = "0x4000B4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000B4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x4000B4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public connectionManager <>4__this;

		[Token(Token = "0x4000B4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string courseName;

		[Token(Token = "0x4000B4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string playerName;

		[Token(Token = "0x4000B4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int scoreValue;

		[Token(Token = "0x4000B50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string runId;

		[Token(Token = "0x4000B51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int difficulty;

		[Token(Token = "0x4000B52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string dateTime;

		[Token(Token = "0x4000B53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int <timeout>5__2;

		[Token(Token = "0x4000B54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Task<string> <authTask>5__3;

		[Token(Token = "0x4000B55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TaskAwaiter<Task> <>u__1;

		[Token(Token = "0x4000B56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Task<string> <scoreTask>5__4;

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0xA7AED4", Offset = "0xA7AED4", VA = "0xA7AED4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0xA7B45C", Offset = "0xA7B45C", VA = "0xA7B45C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000166")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFE48", Offset = "0x7FFE48")]
	private struct <loadScore>d__12 : IAsyncStateMachine
	{
		[Token(Token = "0x4000B57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000B58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<scoreList> <>t__builder;

		[Token(Token = "0x4000B59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string courseName;

		[Token(Token = "0x4000B5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int difficulty;

		[Token(Token = "0x4000B5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string authKey;

		[Token(Token = "0x4000B5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool minigame;

		[Token(Token = "0x4000B5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter<HttpResponseMessage> <>u__1;

		[Token(Token = "0x4000B5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<string> <>u__2;

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0xA77718", Offset = "0xA77718", VA = "0xA77718", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0xA77CCC", Offset = "0xA77CCC", VA = "0xA77CCC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000167")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFE58", Offset = "0x7FFE58")]
	private struct <loadScoreWrap>d__13 : IAsyncStateMachine
	{
		[Token(Token = "0x4000B5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000B60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<scoreList> <>t__builder;

		[Token(Token = "0x4000B61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public connectionManager <>4__this;

		[Token(Token = "0x4000B62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string courseName;

		[Token(Token = "0x4000B63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int difficulty;

		[Token(Token = "0x4000B64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool minigame;

		[Token(Token = "0x4000B65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <timeout>5__2;

		[Token(Token = "0x4000B66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private scoreList <scoreData>5__3;

		[Token(Token = "0x4000B67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Task<string> <authTask>5__4;

		[Token(Token = "0x4000B68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TaskAwaiter<Task> <>u__1;

		[Token(Token = "0x4000B69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Task<scoreList> <scoreTask>5__5;

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0xA7873C", Offset = "0xA7873C", VA = "0xA7873C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0xA78C90", Offset = "0xA78C90", VA = "0xA78C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000168")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFE68", Offset = "0x7FFE68")]
	private struct <loadScoreStats>d__14 : IAsyncStateMachine
	{
		[Token(Token = "0x4000B6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000B6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<scoreStatsObj> <>t__builder;

		[Token(Token = "0x4000B6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string courseName;

		[Token(Token = "0x4000B6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int difficulty;

		[Token(Token = "0x4000B6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string authKey;

		[Token(Token = "0x4000B6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter<HttpResponseMessage> <>u__1;

		[Token(Token = "0x4000B70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter<string> <>u__2;

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0xA77D2C", Offset = "0xA77D2C", VA = "0xA77D2C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0xA7812C", Offset = "0xA7812C", VA = "0xA7812C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000169")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFE78", Offset = "0x7FFE78")]
	private struct <loadScoreStatsWrap>d__15 : IAsyncStateMachine
	{
		[Token(Token = "0x4000B71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000B72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<scoreStatsObj> <>t__builder;

		[Token(Token = "0x4000B73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public connectionManager <>4__this;

		[Token(Token = "0x4000B74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string courseName;

		[Token(Token = "0x4000B75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int difficulty;

		[Token(Token = "0x4000B76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <timeout>5__2;

		[Token(Token = "0x4000B77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private scoreStatsObj <scoreStatsData>5__3;

		[Token(Token = "0x4000B78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Task<string> <authTask>5__4;

		[Token(Token = "0x4000B79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<Task> <>u__1;

		[Token(Token = "0x4000B7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Task<scoreStatsObj> <scoreStatsTask>5__5;

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0xA7818C", Offset = "0xA7818C", VA = "0xA7818C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0xA786DC", Offset = "0xA786DC", VA = "0xA786DC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200016A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFE88", Offset = "0x7FFE88")]
	private struct <putGhost>d__16 : IAsyncStateMachine
	{
		[Token(Token = "0x4000B7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000B7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Token(Token = "0x4000B7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public sharedRunObject runData;

		[Token(Token = "0x4000B7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string courseName;

		[Token(Token = "0x4000B7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int difficulty;

		[Token(Token = "0x4000B80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string authKey;

		[Token(Token = "0x4000B81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter<HttpResponseMessage> <>u__1;

		[Token(Token = "0x4000B82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<string> <>u__2;

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0xA79388", Offset = "0xA79388", VA = "0xA79388", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0xA7981C", Offset = "0xA7981C", VA = "0xA7981C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200016B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFE98", Offset = "0x7FFE98")]
	private struct <putGhostWrap>d__17 : IAsyncStateMachine
	{
		[Token(Token = "0x4000B83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000B84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x4000B85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public connectionManager <>4__this;

		[Token(Token = "0x4000B86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string courseName;

		[Token(Token = "0x4000B87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int difficulty;

		[Token(Token = "0x4000B88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public sharedRunObject runData;

		[Token(Token = "0x4000B89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int <timeout>5__2;

		[Token(Token = "0x4000B8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Task<string> <authTask>5__3;

		[Token(Token = "0x4000B8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TaskAwaiter<Task> <>u__1;

		[Token(Token = "0x4000B8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Task<string> <ghostTask>5__4;

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0xA7987C", Offset = "0xA7987C", VA = "0xA7987C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0xA79DFC", Offset = "0xA79DFC", VA = "0xA79DFC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200016C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFEA8", Offset = "0x7FFEA8")]
	private struct <loadGhost>d__18 : IAsyncStateMachine
	{
		[Token(Token = "0x4000B8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000B8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<sharedRunList> <>t__builder;

		[Token(Token = "0x4000B8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string courseName;

		[Token(Token = "0x4000B90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int difficulty;

		[Token(Token = "0x4000B91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string songTitle;

		[Token(Token = "0x4000B92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string authKey;

		[Token(Token = "0x4000B93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int num;

		[Token(Token = "0x4000B94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<HttpResponseMessage> <>u__1;

		[Token(Token = "0x4000B95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TaskAwaiter<string> <>u__2;

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0xA76500", Offset = "0xA76500", VA = "0xA76500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0xA76CD8", Offset = "0xA76CD8", VA = "0xA76CD8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200016D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFEB8", Offset = "0x7FFEB8")]
	private struct <loadGhostWrap>d__19 : IAsyncStateMachine
	{
		[Token(Token = "0x4000B96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000B97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<sharedRunList> <>t__builder;

		[Token(Token = "0x4000B98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public connectionManager <>4__this;

		[Token(Token = "0x4000B99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string courseName;

		[Token(Token = "0x4000B9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int difficulty;

		[Token(Token = "0x4000B9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string songTitle;

		[Token(Token = "0x4000B9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int num;

		[Token(Token = "0x4000B9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int <timeout>5__2;

		[Token(Token = "0x4000B9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private sharedRunList <ghostData>5__3;

		[Token(Token = "0x4000B9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Task<string> <authTask>5__4;

		[Token(Token = "0x4000BA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TaskAwaiter<Task> <>u__1;

		[Token(Token = "0x4000BA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Task<sharedRunList> <ghostTask>5__5;

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0xA76D38", Offset = "0xA76D38", VA = "0xA76D38", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0xA7728C", Offset = "0xA7728C", VA = "0xA7728C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200016E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFEC8", Offset = "0x7FFEC8")]
	private struct <loadName>d__20 : IAsyncStateMachine
	{
		[Token(Token = "0x4000BA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000BA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<nameObject> <>t__builder;

		[Token(Token = "0x4000BA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string playerName;

		[Token(Token = "0x4000BA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string authKey;

		[Token(Token = "0x4000BA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<HttpResponseMessage> <>u__1;

		[Token(Token = "0x4000BA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter<string> <>u__2;

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0xA772EC", Offset = "0xA772EC", VA = "0xA772EC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0xA776B8", Offset = "0xA776B8", VA = "0xA776B8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200016F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFED8", Offset = "0x7FFED8")]
	private struct <putName>d__21 : IAsyncStateMachine
	{
		[Token(Token = "0x4000BA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000BA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Token(Token = "0x4000BAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public connectionManager <>4__this;

		[Token(Token = "0x4000BAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string authKey;

		[Token(Token = "0x4000BAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string playerName;

		[Token(Token = "0x4000BAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private nameObject <data>5__2;

		[Token(Token = "0x4000BAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter<nameObject> <>u__1;

		[Token(Token = "0x4000BAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<HttpResponseMessage> <>u__2;

		[Token(Token = "0x4000BB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TaskAwaiter<string> <>u__3;

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0xA79E08", Offset = "0xA79E08", VA = "0xA79E08", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0xA7A3EC", Offset = "0xA7A3EC", VA = "0xA7A3EC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000170")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFEE8", Offset = "0x7FFEE8")]
	private struct <putNameWrap>d__22 : IAsyncStateMachine
	{
		[Token(Token = "0x4000BB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000BB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Token(Token = "0x4000BB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public connectionManager <>4__this;

		[Token(Token = "0x4000BB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string userName;

		[Token(Token = "0x4000BB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <timeout>5__2;

		[Token(Token = "0x4000BB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Task<string> <authTask>5__3;

		[Token(Token = "0x4000BB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter<Task> <>u__1;

		[Token(Token = "0x4000BB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Task<string> <nameTask>5__4;

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0xA7A44C", Offset = "0xA7A44C", VA = "0xA7A44C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0xA7AA74", Offset = "0xA7AA74", VA = "0xA7AA74", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000171")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFEF8", Offset = "0x7FFEF8")]
	private struct <loadTuneParams>d__23 : IAsyncStateMachine
	{
		[Token(Token = "0x4000BB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000BBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<tuneParamObject> <>t__builder;

		[Token(Token = "0x4000BBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TaskAwaiter<HttpResponseMessage> <>u__1;

		[Token(Token = "0x4000BBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter<string> <>u__2;

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0xA78CF0", Offset = "0xA78CF0", VA = "0xA78CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0xA78FC4", Offset = "0xA78FC4", VA = "0xA78FC4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000172")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFF08", Offset = "0x7FFF08")]
	private struct <loadTuneParamsWrap>d__24 : IAsyncStateMachine
	{
		[Token(Token = "0x4000BBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000BBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<tuneParamObject> <>t__builder;

		[Token(Token = "0x4000BBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public connectionManager <>4__this;

		[Token(Token = "0x4000BC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private tuneParamObject <tuneParams>5__2;

		[Token(Token = "0x4000BC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Task<tuneParamObject> <paramTask>5__3;

		[Token(Token = "0x4000BC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter<Task> <>u__1;

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0xA79024", Offset = "0xA79024", VA = "0xA79024", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0xA79328", Offset = "0xA79328", VA = "0xA79328", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly HttpClient client;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly string authURL;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly string dbScoreURL;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly string dbScoreStatsURL;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly string dbGhostURL;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static readonly string dbNameURL;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly string apiKey;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static readonly string tuningParamsURL;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string authKey;

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0xA74D78", Offset = "0xA74D78", VA = "0xA74D78")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x8020C8", Offset = "0x8020C8")]
	private Task<string> anonAuthRequest()
	{
		return null;
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0xA74E98", Offset = "0xA74E98", VA = "0xA74E98")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x80212C", Offset = "0x80212C")]
	private Task<string> putScore(string authKey, string courseName, string playerName, int scoreValue, string runId, int difficulty, string dateTime)
	{
		return null;
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0xA74FE4", Offset = "0xA74FE4", VA = "0xA74FE4")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x802190", Offset = "0x802190")]
	public void putScoreWrap(string courseName, string playerName, int scoreValue, string runId, int difficulty, string dateTime)
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0xA750E4", Offset = "0xA750E4", VA = "0xA750E4")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x8021F4", Offset = "0x8021F4")]
	private Task<scoreList> loadScore(string authKey, string courseName, int difficulty, bool minigame = false)
	{
		return null;
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0xA75214", Offset = "0xA75214", VA = "0xA75214")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x802258", Offset = "0x802258")]
	public Task<scoreList> loadScoreWrap(string courseName, int difficulty, bool minigame = false)
	{
		return null;
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0xA75340", Offset = "0xA75340", VA = "0xA75340")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x8022BC", Offset = "0x8022BC")]
	private Task<scoreStatsObj> loadScoreStats(string authKey, string courseName, int difficulty)
	{
		return null;
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0xA7545C", Offset = "0xA7545C", VA = "0xA7545C")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x802320", Offset = "0x802320")]
	public Task<scoreStatsObj> loadScoreStatsWrap(string courseName, int difficulty)
	{
		return null;
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0xA7557C", Offset = "0xA7557C", VA = "0xA7557C")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x802384", Offset = "0x802384")]
	private Task<string> putGhost(string authKey, string courseName, int difficulty, sharedRunObject runData)
	{
		return null;
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0xA756A4", Offset = "0xA756A4", VA = "0xA756A4")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x8023E8", Offset = "0x8023E8")]
	public void putGhostWrap(string courseName, int difficulty, sharedRunObject runData)
	{
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0xA7577C", Offset = "0xA7577C", VA = "0xA7577C")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x80244C", Offset = "0x80244C")]
	private Task<sharedRunList> loadGhost(string authKey, string courseName, int difficulty, string songTitle, int num)
	{
		return null;
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0xA758B8", Offset = "0xA758B8", VA = "0xA758B8")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x8024B0", Offset = "0x8024B0")]
	public Task<sharedRunList> loadGhostWrap(string courseName, int difficulty, string songTitle, int num)
	{
		return null;
	}

	[Token(Token = "0x60003D9")]
	[Address(RVA = "0xA759F0", Offset = "0xA759F0", VA = "0xA759F0")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x802514", Offset = "0x802514")]
	private Task<nameObject> loadName(string authKey, string playerName)
	{
		return null;
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0xA75AFC", Offset = "0xA75AFC", VA = "0xA75AFC")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x802578", Offset = "0x802578")]
	private Task<string> putName(string authKey, string playerName)
	{
		return null;
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0xA75C1C", Offset = "0xA75C1C", VA = "0xA75C1C")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x8025DC", Offset = "0x8025DC")]
	public Task<bool> putNameWrap(string userName, bool auth)
	{
		return null;
	}

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0xA75D2C", Offset = "0xA75D2C", VA = "0xA75D2C")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x802640", Offset = "0x802640")]
	private Task<tuneParamObject> loadTuneParams()
	{
		return null;
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0xA75E24", Offset = "0xA75E24", VA = "0xA75E24")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x8026A4", Offset = "0x8026A4")]
	public Task<tuneParamObject> loadTuneParamsWrap()
	{
		return null;
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0xA75F24", Offset = "0xA75F24", VA = "0xA75F24")]
	public connectionManager()
	{
	}
}
[Token(Token = "0x2000061")]
public class copyTransform : MonoBehaviour
{
	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform targetTransform;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float zOffset;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float yOffset;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool doLerp;

	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private calcBodyPosition body;

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Quaternion initalRot;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 initalPos;

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0xA7B468", Offset = "0xA7B468", VA = "0xA7B468")]
	private void Start()
	{
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0xA7B518", Offset = "0xA7B518", VA = "0xA7B518")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0xA7B824", Offset = "0xA7B824", VA = "0xA7B824")]
	public copyTransform()
	{
	}
}
[Token(Token = "0x2000062")]
public class courseBuilder : MonoBehaviour
{
	[Token(Token = "0x2000173")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFF18", Offset = "0x7FFF18")]
	private sealed class <generateCource>d__87 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000BC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000BC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000BC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public courseBuilder <>4__this;

		[Token(Token = "0x170000FD")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A54")]
			[Address(RVA = "0xA80780", Offset = "0xA80780", VA = "0xA80780", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FE")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A56")]
			[Address(RVA = "0xA807E8", Offset = "0xA807E8", VA = "0xA807E8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0xA7EA48", Offset = "0xA7EA48", VA = "0xA7EA48")]
		[DebuggerHidden]
		public <generateCource>d__87(int <>1__state)
		{
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0xA80690", Offset = "0xA80690", VA = "0xA80690", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0xA80694", Offset = "0xA80694", VA = "0xA80694", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0xA80788", Offset = "0xA80788", VA = "0xA80788", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000174")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFF28", Offset = "0x7FFF28")]
	private sealed class <cleanPath>d__88 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000BC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000BC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000BC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public courseBuilder <>4__this;

		[Token(Token = "0x4000BC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool smooth;

		[Token(Token = "0x4000BCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool reset;

		[Token(Token = "0x4000BCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int <i>5__2;

		[Token(Token = "0x170000FF")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A5A")]
			[Address(RVA = "0xA80620", Offset = "0xA80620", VA = "0xA80620", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000100")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A5C")]
			[Address(RVA = "0xA80688", Offset = "0xA80688", VA = "0xA80688", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0xA7EB04", Offset = "0xA7EB04", VA = "0xA7EB04")]
		[DebuggerHidden]
		public <cleanPath>d__88(int <>1__state)
		{
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0xA7FE28", Offset = "0xA7FE28", VA = "0xA7FE28", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0xA7FE2C", Offset = "0xA7FE2C", VA = "0xA7FE2C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0xA80628", Offset = "0xA80628", VA = "0xA80628", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000175")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFF38", Offset = "0x7FFF38")]
	private sealed class <checkPath>d__89 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000BCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000BCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000BCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public courseBuilder <>4__this;

		[Token(Token = "0x17000101")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A60")]
			[Address(RVA = "0xA7FDB8", Offset = "0xA7FDB8", VA = "0xA7FDB8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000102")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A62")]
			[Address(RVA = "0xA7FE20", Offset = "0xA7FE20", VA = "0xA7FE20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0xA7EBA0", Offset = "0xA7EBA0", VA = "0xA7EBA0")]
		[DebuggerHidden]
		public <checkPath>d__89(int <>1__state)
		{
		}

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0xA7F4A4", Offset = "0xA7F4A4", VA = "0xA7F4A4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0xA7F4A8", Offset = "0xA7F4A8", VA = "0xA7F4A8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0xA7FDC0", Offset = "0xA7FDC0", VA = "0xA7FDC0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000176")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFF48", Offset = "0x7FFF48")]
	private sealed class <searchPath>d__90 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000BCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000BD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000BD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public courseBuilder <>4__this;

		[Token(Token = "0x4000BD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 startSearchingFromPos;

		[Token(Token = "0x17000103")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A66")]
			[Address(RVA = "0xA81B74", Offset = "0xA81B74", VA = "0xA81B74", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000104")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A68")]
			[Address(RVA = "0xA81BDC", Offset = "0xA81BDC", VA = "0xA81BDC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0xA7EC60", Offset = "0xA7EC60", VA = "0xA7EC60")]
		[DebuggerHidden]
		public <searchPath>d__90(int <>1__state)
		{
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0xA807F0", Offset = "0xA807F0", VA = "0xA807F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0xA807F4", Offset = "0xA807F4", VA = "0xA807F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0xA81B7C", Offset = "0xA81B7C", VA = "0xA81B7C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800C58", Offset = "0x800C58")]
	private static courseBuilder <Instance>k__BackingField;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject powerUpPrefab;

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject powerDownPrefab;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject gatePairPrefabRed;

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject gatePairPrefabBlue;

	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject endFlagPrefab;

	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector3 currentPathPos;

	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<Vector3> path;

	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<bool> pathAllowDrop;

	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<Vector3> pathPosLst;

	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int currentSpawnIndex;

	[Token(Token = "0x40003A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float pathDist;

	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float avergePathDist;

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int averageSpawnSteps;

	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int powerUpSpawnCount;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public int powerDownSpawnCount;

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int gateHitCount;

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public int gateClearCount;

	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public int powerUpSpawnFreq;

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public int curveFactor;

	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float bounceAngle;

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public int maxSteepness;

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public bool gateDroped;

	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
	public bool gateCleared;

	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9A")]
	public bool lastStrech;

	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private int maxSearchSteps;

	[Token(Token = "0x40003AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Vector2 horSearchDirBounds;

	[Token(Token = "0x40003B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Vector2 endOfCourseLimits;

	[Token(Token = "0x40003B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public int totalPathIndex;

	[Token(Token = "0x40003B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public int pathIndex;

	[Token(Token = "0x40003B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public List<Vector3> ghostPath;

	[Token(Token = "0x40003B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public int shardSpawnCount;

	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public int shardCombo;

	[Token(Token = "0x40003B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public int pulseCombo;

	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public int pulseComboMax;

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public bool spawnPulse;

	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
	public bool spawnEndSection;

	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD2")]
	public bool generateCourse;

	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD3")]
	public bool dropGates;

	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public List<KeyValuePair<Transform, Vector3>> spawnedGatePosLst;

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public int gateSpawnIndexBoost;

	[Token(Token = "0x40003BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public bool lookingForPath;

	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public List<Vector2Int> gateIndexes;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public List<Vector3> syncedPath;

	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public bool syncedMode;

	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private courseRhythm cr;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private calcBodyPosition body;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private calcBodyMovement move;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private dataManager data;

	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private stateManager state;

	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private connectionManager connection;

	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private slopeLocomotion slope;

	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private tutorialManager tutorial;

	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private ghostManager ghost;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private UIManager UI;

	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private GameObject startPos;

	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private Vector3 currentPos;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private List<Vector3> posLst;

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private int gateSpawnDist;

	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private List<Vector3> deadEndLst;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private float strechLen;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
	public int sphereRad;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public int castDist;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private LineRenderer pathLine;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private List<Vector2> gateDifficultySettings;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private int gateDifficulty;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
	private int pathOffset;

	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private int totalPathCount;

	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
	private int highestSpawnIndex;

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private Vector3 lastSpawnPos;

	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private List<GameObject> spawnedObjects;

	[Token(Token = "0x40003DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private Vector3 currentGateSpawnPos;

	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
	private float distToEnd;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private int horLayerMask;

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
	private int verLayerMask;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private int nPathsGenerated;

	[Token(Token = "0x1700004B")]
	public static courseBuilder Instance
	{
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xA7B82C", Offset = "0xA7B82C", VA = "0xA7B82C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x802708", Offset = "0x802708")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xA7B87C", Offset = "0xA7B87C", VA = "0xA7B87C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x802718", Offset = "0x802718")]
		private set
		{
		}
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0xA7B8D0", Offset = "0xA7B8D0", VA = "0xA7B8D0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0xA7B9AC", Offset = "0xA7B9AC", VA = "0xA7B9AC")]
	private void Start()
	{
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0xA7BCCC", Offset = "0xA7BCCC", VA = "0xA7BCCC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0xA7C938", Offset = "0xA7C938", VA = "0xA7C938")]
	public void spawnGate(int nPathSections)
	{
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0xA7DF54", Offset = "0xA7DF54", VA = "0xA7DF54")]
	public Vector3 spawnGateTutorial(int nPathSections, int baseOffset)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0xA7DA38", Offset = "0xA7DA38", VA = "0xA7DA38")]
	public void spawnPowerUp(int nBeats)
	{
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0xA7DCCC", Offset = "0xA7DCCC", VA = "0xA7DCCC")]
	public void spawnPowerDown(int nBeats)
	{
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0xA7E68C", Offset = "0xA7E68C", VA = "0xA7E68C")]
	public List<Vector2Int> generateGateSpawnIndexes()
	{
		return null;
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0xA7BC5C", Offset = "0xA7BC5C", VA = "0xA7BC5C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x802728", Offset = "0x802728")]
	public IEnumerator generateCource()
	{
		return null;
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0xA7EA74", Offset = "0xA7EA74", VA = "0xA7EA74")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x80278C", Offset = "0x80278C")]
	public IEnumerator cleanPath(bool smooth = true, bool reset = false)
	{
		return null;
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0xA7EB30", Offset = "0xA7EB30", VA = "0xA7EB30")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8027F0", Offset = "0x8027F0")]
	public IEnumerator checkPath()
	{
		return null;
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0xA7EBCC", Offset = "0xA7EBCC", VA = "0xA7EBCC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x802854", Offset = "0x802854")]
	public IEnumerator searchPath(Vector3 startSearchingFromPos)
	{
		return null;
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0xA7EC8C", Offset = "0xA7EC8C", VA = "0xA7EC8C")]
	public static Vector3[] SmoothLine(Vector3[] inputPoints, float segmentSize)
	{
		return null;
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0xA7F19C", Offset = "0xA7F19C", VA = "0xA7F19C")]
	public courseBuilder()
	{
	}
}
[Token(Token = "0x2000063")]
public class courseRhythm : MonoBehaviour
{
	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioSource track;

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<float> beatMap;

	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<float> beatMapRaw;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static float trackTimer;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static float beatLenght;

	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static float beatMapCurrent;

	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool beatFrame;

	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool beatWindow;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool firstBeat;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	public bool rhythmFailed;

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public static int songIndex;

	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float beatTimer;

	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private stateManager state;

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private dataManager data;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private calcBodyMovement move;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private courseBuilder course;

	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private musicLib music;

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0xA81BE4", Offset = "0xA81BE4", VA = "0xA81BE4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0xA81C54", Offset = "0xA81C54", VA = "0xA81C54")]
	private void Start()
	{
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0xA82040", Offset = "0xA82040", VA = "0xA82040")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0xA826F0", Offset = "0xA826F0", VA = "0xA826F0")]
	private void selectSong()
	{
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0xA82A1C", Offset = "0xA82A1C", VA = "0xA82A1C")]
	public courseRhythm()
	{
	}
}
[Token(Token = "0x2000064")]
public class customCameraSettings : MonoBehaviour
{
	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CameraClearFlags clearFlags;

	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Camera cam;

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0xA82A24", Offset = "0xA82A24", VA = "0xA82A24")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003F9")]
	[Address(RVA = "0xA82AD4", Offset = "0xA82AD4", VA = "0xA82AD4")]
	public customCameraSettings()
	{
	}
}
[Token(Token = "0x2000065")]
public class damageManager : MonoBehaviour
{
	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool doDamage;

	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int damageCounter;

	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private stateManager state;

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private dataManager data;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform bloodFade;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float bloodFadeTimer;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private AudioSource hurt;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 defaultScale;

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0xA82ADC", Offset = "0xA82ADC", VA = "0xA82ADC")]
	public void damage()
	{
	}

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0xA82B74", Offset = "0xA82B74", VA = "0xA82B74")]
	private void Start()
	{
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0xA82C78", Offset = "0xA82C78", VA = "0xA82C78")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0xA82ED8", Offset = "0xA82ED8", VA = "0xA82ED8")]
	public damageManager()
	{
	}
}
[Token(Token = "0x2000066")]
public class scoreObject
{
	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string runId;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string playerName;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string courseName;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string dateTime;

	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int score;

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0xB92FA4", Offset = "0xB92FA4", VA = "0xB92FA4")]
	public scoreObject()
	{
	}
}
[Token(Token = "0x2000067")]
public class scoreList
{
	[Serializable]
	[Token(Token = "0x2000177")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFF58", Offset = "0x7FFF58")]
	private sealed class <>c
	{
		[Token(Token = "0x4000BD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000BD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<scoreObject, int> <>9__1_0;

		[Token(Token = "0x4000BD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<scoreObject, int> <>9__2_0;

		[Token(Token = "0x4000BD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<scoreObject, string> <>9__3_0;

		[Token(Token = "0x4000BD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Func<scoreObject, string> <>9__5_0;

		[Token(Token = "0x4000BD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Func<IGrouping<string, scoreObject>, scoreObject> <>9__5_1;

		[Token(Token = "0x4000BD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Func<scoreObject, string> <>9__6_0;

		[Token(Token = "0x4000BDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Func<IGrouping<string, scoreObject>, scoreObject> <>9__6_1;

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0xB93080", Offset = "0xB93080", VA = "0xB93080")]
		public <>c()
		{
		}

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0xB93088", Offset = "0xB93088", VA = "0xB93088")]
		internal int <sort>b__1_0(scoreObject o)
		{
			return default(int);
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0xB930A0", Offset = "0xB930A0", VA = "0xB930A0")]
		internal int <sortAscending>b__2_0(scoreObject o)
		{
			return default(int);
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0xB930B8", Offset = "0xB930B8", VA = "0xB930B8")]
		internal string <sortOnDate>b__3_0(scoreObject o)
		{
			return null;
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0xB930D0", Offset = "0xB930D0", VA = "0xB930D0")]
		internal string <uniqueID>b__5_0(scoreObject elem)
		{
			return null;
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0xB930E8", Offset = "0xB930E8", VA = "0xB930E8")]
		internal scoreObject <uniqueID>b__5_1(IGrouping<string, scoreObject> group)
		{
			return null;
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0xB93138", Offset = "0xB93138", VA = "0xB93138")]
		internal string <uniqueName>b__6_0(scoreObject elem)
		{
			return null;
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0xB93150", Offset = "0xB93150", VA = "0xB93150")]
		internal scoreObject <uniqueName>b__6_1(IGrouping<string, scoreObject> group)
		{
			return null;
		}
	}

	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<scoreObject> list;

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0xB92618", Offset = "0xB92618", VA = "0xB92618")]
	public void sort()
	{
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0xB92744", Offset = "0xB92744", VA = "0xB92744")]
	public void sortAscending()
	{
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0xB924F8", Offset = "0xB924F8", VA = "0xB924F8")]
	public void sortOnDate()
	{
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0xB92854", Offset = "0xB92854", VA = "0xB92854")]
	public void crop(int n)
	{
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0xB9233C", Offset = "0xB9233C", VA = "0xB9233C")]
	public void uniqueID()
	{
	}

	[Token(Token = "0x6000404")]
	[Address(RVA = "0xB928CC", Offset = "0xB928CC", VA = "0xB928CC")]
	public void uniqueName()
	{
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0xB92A88", Offset = "0xB92A88", VA = "0xB92A88")]
	public string serialize()
	{
		return null;
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0xB92D40", Offset = "0xB92D40", VA = "0xB92D40")]
	public void deserialize(string scoreLstStr)
	{
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0xB92FAC", Offset = "0xB92FAC", VA = "0xB92FAC")]
	public scoreList()
	{
	}
}
[Token(Token = "0x2000068")]
public class sharedRunObject
{
	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string runId;

	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string playerName;

	[Token(Token = "0x4000404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string courseName;

	[Token(Token = "0x4000405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string dateTime;

	[Token(Token = "0x4000406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string songTitle;

	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int score;

	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<Vector3> ghostPos;

	[Token(Token = "0x4000409")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<Vector3> coursePath;

	[Token(Token = "0x400040A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<int> gateSpawnSongIndex;

	[Token(Token = "0x400040B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<int> gateSpawnPathIndex;

	[Token(Token = "0x6000408")]
	[Address(RVA = "0xB940CC", Offset = "0xB940CC", VA = "0xB940CC")]
	public sharedRunObject()
	{
	}
}
[Token(Token = "0x2000069")]
public class sharedRunList
{
	[Token(Token = "0x400040C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<sharedRunObject> list;

	[Token(Token = "0x6000409")]
	[Address(RVA = "0xB9405C", Offset = "0xB9405C", VA = "0xB9405C")]
	public sharedRunList()
	{
	}
}
[Token(Token = "0x200006A")]
public class gameOverStateObject
{
	[Token(Token = "0x400040D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int gameOverState;

	[Token(Token = "0x600040A")]
	[Address(RVA = "0x18123B4", Offset = "0x18123B4", VA = "0x18123B4")]
	public gameOverStateObject()
	{
	}
}
[Token(Token = "0x200006B")]
public class settingsObject
{
	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool freeRide;

	[Token(Token = "0x400040F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool freeRideUnlocked;

	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
	public bool leftHand;

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
	public bool ghostMarker;

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int difficulty;

	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float bodyHeight;

	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int ski;

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int rocketBoots;

	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int hookShoot;

	[Token(Token = "0x4000417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int musicVol;

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int sfxVol;

	[Token(Token = "0x4000419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool muteVoiP;

	[Token(Token = "0x400041A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool musicInFreeRide;

	[Token(Token = "0x400041B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool highRefresh;

	[Token(Token = "0x400041C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	public bool smallHud;

	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<int> music;

	[Token(Token = "0x600040B")]
	[Address(RVA = "0xB933F0", Offset = "0xB933F0", VA = "0xB933F0")]
	public settingsObject()
	{
	}
}
[Token(Token = "0x200006C")]
public class walletObject
{
	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int balance;

	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int collectedInLastCourse;

	[Token(Token = "0x4000420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int ski0;

	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int ski1;

	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int ski2;

	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int ski3;

	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int ski4;

	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int ski5;

	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int rocketBoots;

	[Token(Token = "0x4000427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int hookShoot;

	[Token(Token = "0x600040C")]
	[Address(RVA = "0x14846FC", Offset = "0x14846FC", VA = "0x14846FC")]
	public walletObject()
	{
	}
}
[Token(Token = "0x200006D")]
public class scoreStatsObj
{
	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<float> normCounts;

	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<float> bins;

	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string lastUpdate;

	[Token(Token = "0x600040D")]
	[Address(RVA = "0xB931A0", Offset = "0xB931A0", VA = "0xB931A0")]
	public scoreStatsObj()
	{
	}
}
[Token(Token = "0x200006E")]
public class fallBackPath
{
	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<Vector3> path;

	[Token(Token = "0x600040E")]
	[Address(RVA = "0x1811208", Offset = "0x1811208", VA = "0x1811208")]
	public fallBackPath()
	{
	}
}
[Token(Token = "0x200006F")]
public class beatMapLst
{
	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<float> lst;

	[Token(Token = "0x600040F")]
	[Address(RVA = "0xA6FF34", Offset = "0xA6FF34", VA = "0xA6FF34")]
	public beatMapLst()
	{
	}
}
[Token(Token = "0x2000070")]
public class dataManager : MonoBehaviour
{
	[Token(Token = "0x2000178")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFF68", Offset = "0x7FFF68")]
	private sealed class <loadCustomMusic>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000BDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000BDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000BDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public dataManager <>4__this;

		[Token(Token = "0x4000BDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string <dirPath>5__2;

		[Token(Token = "0x4000BDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private analyzeMusic <am>5__3;

		[Token(Token = "0x4000BE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private musicLib <ml>5__4;

		[Token(Token = "0x4000BE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int <count>5__5;

		[Token(Token = "0x4000BE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<string> <loadedSongs>5__6;

		[Token(Token = "0x4000BE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private FileInfo[] <>7__wrap6;

		[Token(Token = "0x4000BE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int <>7__wrap7;

		[Token(Token = "0x4000BE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string <songName>5__9;

		[Token(Token = "0x4000BE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MpegFile <mpegFile>5__10;

		[Token(Token = "0x4000BE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private AudioClip <clip>5__11;

		[Token(Token = "0x4000BE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<float> <customSongBeatMap>5__12;

		[Token(Token = "0x17000105")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A75")]
			[Address(RVA = "0xA84D94", Offset = "0xA84D94", VA = "0xA84D94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000106")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A77")]
			[Address(RVA = "0xA84DFC", Offset = "0xA84DFC", VA = "0xA84DFC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0xA84464", Offset = "0xA84464", VA = "0xA84464")]
		[DebuggerHidden]
		public <loadCustomMusic>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0xA846D0", Offset = "0xA846D0", VA = "0xA846D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0xA846D4", Offset = "0xA846D4", VA = "0xA846D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0xA84D9C", Offset = "0xA84D9C", VA = "0xA84D9C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool routineRunning;

	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string currentSongProcessed;

	[Token(Token = "0x6000410")]
	[Address(RVA = "0xA82F3C", Offset = "0xA82F3C", VA = "0xA82F3C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0xA82FF4", Offset = "0xA82FF4", VA = "0xA82FF4")]
	public void writeRun(string playerName, sharedRunObject runData)
	{
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0xA830E8", Offset = "0xA830E8", VA = "0xA830E8")]
	public sharedRunObject readRun(string playerName)
	{
		return null;
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0xA831E4", Offset = "0xA831E4", VA = "0xA831E4")]
	public void writeScore(string playerName, string courseName, int score, string runId, int difficulty, string dateTime)
	{
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0xA834E4", Offset = "0xA834E4", VA = "0xA834E4")]
	public scoreList readScore(string playerName, string courseName, int difficulty, bool includeUnAuth = false)
	{
		return null;
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0xA825F0", Offset = "0xA825F0", VA = "0xA825F0")]
	public void writeGameOverState(string playerName, int gameOverState)
	{
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0xA83A9C", Offset = "0xA83A9C", VA = "0xA83A9C")]
	public int readGameOverState(string playerName)
	{
		return default(int);
	}

	[Token(Token = "0x6000417")]
	[Address(RVA = "0xA83BA8", Offset = "0xA83BA8", VA = "0xA83BA8")]
	public void writeSettings(string playerName, settingsObject settings)
	{
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0xA83C84", Offset = "0xA83C84", VA = "0xA83C84")]
	public settingsObject readSettings(string playerName)
	{
		return null;
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0xA83D84", Offset = "0xA83D84", VA = "0xA83D84")]
	public walletObject readWallet(string playerName)
	{
		return null;
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0xA83FB8", Offset = "0xA83FB8", VA = "0xA83FB8")]
	public void writeWallet(string playerName, walletObject wallet)
	{
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0xA7FBCC", Offset = "0xA7FBCC", VA = "0xA7FBCC")]
	public void writeFallBackPath(string cource, List<Vector3> path)
	{
	}

	[Token(Token = "0x600041C")]
	[Address(RVA = "0xA7FCCC", Offset = "0xA7FCCC", VA = "0xA7FCCC")]
	public List<Vector3> readFallBackPath(string cource)
	{
		return null;
	}

	[Token(Token = "0x600041D")]
	[Address(RVA = "0xA84094", Offset = "0xA84094", VA = "0xA84094")]
	public void writeBeatMapLst(string track, List<float> lst)
	{
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0xA84190", Offset = "0xA84190", VA = "0xA84190")]
	public List<float> readBeatMapLst(string track)
	{
		return null;
	}

	[Token(Token = "0x600041F")]
	[Address(RVA = "0xA84314", Offset = "0xA84314", VA = "0xA84314")]
	public string readPlayerID()
	{
		return null;
	}

	[Token(Token = "0x6000420")]
	[Address(RVA = "0xA83890", Offset = "0xA83890", VA = "0xA83890")]
	public string readPlayerName(bool getUnAuthUser = false)
	{
		return null;
	}

	[Token(Token = "0x6000421")]
	[Address(RVA = "0xA843F4", Offset = "0xA843F4", VA = "0xA843F4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8028B8", Offset = "0x8028B8")]
	public IEnumerator loadCustomMusic()
	{
		return null;
	}

	[Token(Token = "0x6000422")]
	[Address(RVA = "0xA84490", Offset = "0xA84490", VA = "0xA84490")]
	public void clearData(bool force = false)
	{
	}

	[Token(Token = "0x6000423")]
	[Address(RVA = "0xA84678", Offset = "0xA84678", VA = "0xA84678")]
	public dataManager()
	{
	}
}
[Token(Token = "0x2000071")]
public class demoManager : MonoBehaviour
{
	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<BoxCollider> muteInDemo;

	[Token(Token = "0x6000424")]
	[Address(RVA = "0x180F424", Offset = "0x180F424", VA = "0x180F424")]
	private void Start()
	{
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0x180F520", Offset = "0x180F520", VA = "0x180F520")]
	public demoManager()
	{
	}
}
[Token(Token = "0x2000072")]
public class dropShadow : MonoBehaviour
{
	[Token(Token = "0x4000430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private stateManager state;

	[Token(Token = "0x6000426")]
	[Address(RVA = "0x180F528", Offset = "0x180F528", VA = "0x180F528")]
	private void Start()
	{
	}

	[Token(Token = "0x6000427")]
	[Address(RVA = "0x180F600", Offset = "0x180F600", VA = "0x180F600")]
	private void Update()
	{
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0x180F8B0", Offset = "0x180F8B0", VA = "0x180F8B0")]
	public dropShadow()
	{
	}
}
[Token(Token = "0x2000073")]
public class endlessManager : MonoBehaviour
{
	[Token(Token = "0x4000431")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<GameObject> sectionLst;

	[Token(Token = "0x4000432")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject worldBackDrop;

	[Token(Token = "0x4000433")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool scrollWorld;

	[Token(Token = "0x4000434")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int sectionCount;

	[Token(Token = "0x4000435")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float sectionTimer;

	[Token(Token = "0x4000436")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Vector3 newSectionLocation;

	[Token(Token = "0x4000437")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector3 newSectionRotation;

	[Token(Token = "0x4000438")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Vector3 bodyPosDelta;

	[Token(Token = "0x4000439")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<int> multiplayerSpawnSeq;

	[Token(Token = "0x400043A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int multiplayerSpawnIndex;

	[Token(Token = "0x400043B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private calcBodyPosition body;

	[Token(Token = "0x6000429")]
	[Address(RVA = "0x180F8B8", Offset = "0x180F8B8", VA = "0x180F8B8")]
	private void Start()
	{
	}

	[Token(Token = "0x600042A")]
	[Address(RVA = "0x180F928", Offset = "0x180F928", VA = "0x180F928")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600042B")]
	[Address(RVA = "0x180FA9C", Offset = "0x180FA9C", VA = "0x180FA9C")]
	public GameObject getSectionPrefab()
	{
		return null;
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0x180FB94", Offset = "0x180FB94", VA = "0x180FB94")]
	public endlessManager()
	{
	}
}
[Token(Token = "0x2000074")]
public class endlessPowerUp : MonoBehaviour
{
	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private calcBodyPosition body;

	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private calcBodyMovement move;

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private stateManager state;

	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private endlessManager endless;

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private particleEffects effect;

	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool hit;

	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float aliveTimer;

	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject loop;

	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject infPart1;

	[Token(Token = "0x4000445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject infPart2;

	[Token(Token = "0x4000446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private GameObject infPart3;

	[Token(Token = "0x4000447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GameObject hitFlash;

	[Token(Token = "0x4000448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private AudioSource hitSound;

	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ParticleSystem effectCollected;

	[Token(Token = "0x600042D")]
	[Address(RVA = "0x180FD0C", Offset = "0x180FD0C", VA = "0x180FD0C")]
	private void Start()
	{
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0x180FF60", Offset = "0x180FF60", VA = "0x180FF60")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0x180FF8C", Offset = "0x180FF8C", VA = "0x180FF8C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0x181019C", Offset = "0x181019C", VA = "0x181019C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0x181053C", Offset = "0x181053C", VA = "0x181053C")]
	public endlessPowerUp()
	{
	}
}
[Token(Token = "0x2000075")]
public class enterNewSection : MonoBehaviour
{
	[Token(Token = "0x400044A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int sectionType;

	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private tutorialManager tutorial;

	[Token(Token = "0x400044C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private courseBuilder course;

	[Token(Token = "0x400044D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private stateManager state;

	[Token(Token = "0x400044E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool loaded;

	[Token(Token = "0x6000432")]
	[Address(RVA = "0x1810544", Offset = "0x1810544", VA = "0x1810544")]
	private void Start()
	{
	}

	[Token(Token = "0x6000433")]
	[Address(RVA = "0x18105FC", Offset = "0x18105FC", VA = "0x18105FC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0x181093C", Offset = "0x181093C", VA = "0x181093C")]
	public enterNewSection()
	{
	}
}
[Token(Token = "0x2000076")]
public class enterStationaryArea : MonoBehaviour
{
	[Token(Token = "0x400044F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private tutorialManager tutorial;

	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private stateManager state;

	[Token(Token = "0x4000451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private UIManager UI;

	[Token(Token = "0x4000452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private particleEffects effect;

	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private calcBodyMovement move;

	[Token(Token = "0x4000454")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private calcBodyPosition body;

	[Token(Token = "0x4000455")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool loaded;

	[Token(Token = "0x4000456")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float pulseTimer;

	[Token(Token = "0x4000457")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Transform moveableObjects;

	[Token(Token = "0x4000458")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Transform sprite1Trans;

	[Token(Token = "0x4000459")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private SpriteRenderer sprite1;

	[Token(Token = "0x400045A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Color sprite1Color;

	[Token(Token = "0x400045B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float sprite1Alpha;

	[Token(Token = "0x6000435")]
	[Address(RVA = "0x1810944", Offset = "0x1810944", VA = "0x1810944")]
	private void Start()
	{
	}

	[Token(Token = "0x6000436")]
	[Address(RVA = "0x1810B8C", Offset = "0x1810B8C", VA = "0x1810B8C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000437")]
	[Address(RVA = "0x1810BA8", Offset = "0x1810BA8", VA = "0x1810BA8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000438")]
	[Address(RVA = "0x1810F48", Offset = "0x1810F48", VA = "0x1810F48")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000439")]
	[Address(RVA = "0x1810FD0", Offset = "0x1810FD0", VA = "0x1810FD0")]
	public enterStationaryArea()
	{
	}
}
[Token(Token = "0x2000077")]
public class fadeRhythmDot : MonoBehaviour
{
	[Token(Token = "0x400045C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 startSize;

	[Token(Token = "0x400045D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float aliveTimer;

	[Token(Token = "0x600043A")]
	[Address(RVA = "0x1810FD8", Offset = "0x1810FD8", VA = "0x1810FD8")]
	private void Start()
	{
	}

	[Token(Token = "0x600043B")]
	[Address(RVA = "0x181109C", Offset = "0x181109C", VA = "0x181109C")]
	private void Update()
	{
	}

	[Token(Token = "0x600043C")]
	[Address(RVA = "0x18111F8", Offset = "0x18111F8", VA = "0x18111F8")]
	public fadeRhythmDot()
	{
	}
}
[Token(Token = "0x2000078")]
public class flagManager : MonoBehaviour
{
	[Token(Token = "0x400045E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private calcBodyMovement move;

	[Token(Token = "0x400045F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private particleEffects effect;

	[Token(Token = "0x4000460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private stateManager state;

	[Token(Token = "0x4000461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private courseRhythm cr;

	[Token(Token = "0x4000462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private courseBuilder course;

	[Token(Token = "0x4000463")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private ParticleSystem pulse1;

	[Token(Token = "0x4000464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private ParticleSystem pulse2;

	[Token(Token = "0x4000465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private AudioSource hitSound;

	[Token(Token = "0x4000466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject pole;

	[Token(Token = "0x4000467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private GameObject flag;

	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GameObject banner1;

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private GameObject banner2;

	[Token(Token = "0x400046A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool isHit;

	[Token(Token = "0x400046B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int moveDir;

	[Token(Token = "0x600043D")]
	[Address(RVA = "0x1811210", Offset = "0x1811210", VA = "0x1811210")]
	private void Start()
	{
	}

	[Token(Token = "0x600043E")]
	[Address(RVA = "0x1811560", Offset = "0x1811560", VA = "0x1811560")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0x1811698", Offset = "0x1811698", VA = "0x1811698")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0x1811A04", Offset = "0x1811A04", VA = "0x1811A04")]
	public flagManager()
	{
	}
}
[Token(Token = "0x2000079")]
public class flowMarker : MonoBehaviour
{
	[Token(Token = "0x400046C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private stateManager state;

	[Token(Token = "0x400046D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private calcBodyPosition body;

	[Token(Token = "0x400046E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private calcBodyMovement move;

	[Token(Token = "0x400046F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private courseRhythm cr;

	[Token(Token = "0x4000470")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject markerAnchor;

	[Token(Token = "0x4000471")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject marker;

	[Token(Token = "0x4000472")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject ring;

	[Token(Token = "0x4000473")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject dot;

	[Token(Token = "0x4000474")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Color sprite1Color;

	[Token(Token = "0x4000475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float sprite1Alpha;

	[Token(Token = "0x4000476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float dotScale;

	[Token(Token = "0x4000477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float hudScaleFac;

	[Token(Token = "0x4000478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float hudPosFac;

	[Token(Token = "0x6000441")]
	[Address(RVA = "0x1811A14", Offset = "0x1811A14", VA = "0x1811A14")]
	private void Start()
	{
	}

	[Token(Token = "0x6000442")]
	[Address(RVA = "0x1811BFC", Offset = "0x1811BFC", VA = "0x1811BFC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000443")]
	[Address(RVA = "0x1812088", Offset = "0x1812088", VA = "0x1812088")]
	public flowMarker()
	{
	}
}
[Token(Token = "0x200007A")]
public class freeRideEnd : MonoBehaviour
{
	[Token(Token = "0x4000479")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private stateManager state;

	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private dataManager data;

	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private UIManager UI;

	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private calcBodyMovement move;

	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool endOfCourse;

	[Token(Token = "0x6000444")]
	[Address(RVA = "0x18120A8", Offset = "0x18120A8", VA = "0x18120A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0x1812184", Offset = "0x1812184", VA = "0x1812184")]
	private void Update()
	{
	}

	[Token(Token = "0x6000446")]
	[Address(RVA = "0x1812268", Offset = "0x1812268", VA = "0x1812268")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000447")]
	[Address(RVA = "0x1812304", Offset = "0x1812304", VA = "0x1812304")]
	public freeRideEnd()
	{
	}
}
[Token(Token = "0x200007B")]
public class fullRoomSilulation : MonoBehaviour
{
	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject mpa;

	[Token(Token = "0x6000448")]
	[Address(RVA = "0x181230C", Offset = "0x181230C", VA = "0x181230C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000449")]
	[Address(RVA = "0x1812310", Offset = "0x1812310", VA = "0x1812310")]
	private void Update()
	{
	}

	[Token(Token = "0x600044A")]
	[Address(RVA = "0x18123AC", Offset = "0x18123AC", VA = "0x18123AC")]
	public fullRoomSilulation()
	{
	}
}
[Token(Token = "0x200007C")]
public class gateConnector : MonoBehaviour
{
	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform gateRed;

	[Token(Token = "0x4000480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform gateBlue;

	[Token(Token = "0x4000481")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool hit;

	[Token(Token = "0x4000482")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<bool> grounded;

	[Token(Token = "0x4000483")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int pathIndex;

	[Token(Token = "0x4000484")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 pathDir;

	[Token(Token = "0x4000485")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LineRenderer line;

	[Token(Token = "0x4000486")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private calcBodyPosition body;

	[Token(Token = "0x4000487")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private calcBodyMovement move;

	[Token(Token = "0x4000488")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private courseBuilder course;

	[Token(Token = "0x4000489")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private courseRhythm cr;

	[Token(Token = "0x400048A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private BoxCollider col;

	[Token(Token = "0x400048B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool landed;

	[Token(Token = "0x400048C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	private bool powerUpRoll;

	[Token(Token = "0x400048D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private Vector3 lineDir;

	[Token(Token = "0x400048E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float lineDist;

	[Token(Token = "0x400048F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<Vector3> linePosLst;

	[Token(Token = "0x4000490")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float limitBurstTimer;

	[Token(Token = "0x4000491")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private UnityEngine.Object pulseObj;

	[Token(Token = "0x4000492")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private List<Transform> hitFlashLst;

	[Token(Token = "0x4000493")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float beatDiff;

	[Token(Token = "0x4000494")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private int gateCount;

	[Token(Token = "0x4000495")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private float totalAdjustment;

	[Token(Token = "0x600044B")]
	[Address(RVA = "0x18123BC", Offset = "0x18123BC", VA = "0x18123BC")]
	private void Start()
	{
	}

	[Token(Token = "0x600044C")]
	[Address(RVA = "0x1812700", Offset = "0x1812700", VA = "0x1812700")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600044D")]
	[Address(RVA = "0x1812720", Offset = "0x1812720", VA = "0x1812720")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0x181418C", Offset = "0x181418C", VA = "0x181418C")]
	public gateConnector()
	{
	}
}
[Token(Token = "0x200007D")]
public class gateConnectorHit : MonoBehaviour
{
	[Token(Token = "0x4000496")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private courseBuilder course;

	[Token(Token = "0x4000497")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private particleEffects effect;

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x1814254", Offset = "0x1814254", VA = "0x1814254")]
	private void Start()
	{
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0x1814300", Offset = "0x1814300", VA = "0x1814300")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0x18143F4", Offset = "0x18143F4", VA = "0x18143F4")]
	public gateConnectorHit()
	{
	}
}
[Token(Token = "0x200007E")]
public class gateControl : MonoBehaviour
{
	[Token(Token = "0x4000498")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private calcBodyPosition body;

	[Token(Token = "0x4000499")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private calcBodyMovement move;

	[Token(Token = "0x400049A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private particleEffects effect;

	[Token(Token = "0x400049B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private stateManager state;

	[Token(Token = "0x400049C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private courseRhythm cr;

	[Token(Token = "0x400049D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private courseBuilder course;

	[Token(Token = "0x400049E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private mogulManager mogul;

	[Token(Token = "0x400049F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private CharacterController charControl;

	[Token(Token = "0x40004A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Transform hitFlash;

	[Token(Token = "0x40004A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private AudioSource swosh;

	[Token(Token = "0x40004A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private AudioSource hitSound;

	[Token(Token = "0x40004A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float aliveTimer;

	[Token(Token = "0x40004A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float verticalMotionFac;

	[Token(Token = "0x40004A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Quaternion targetRot;

	[Token(Token = "0x40004A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool hit;

	[Token(Token = "0x40004A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
	private bool close;

	[Token(Token = "0x40004A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private GameObject p1;

	[Token(Token = "0x40004A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private GameObject p2;

	[Token(Token = "0x40004AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private gateConnector parentConnector;

	[Token(Token = "0x6000452")]
	[Address(RVA = "0x18143FC", Offset = "0x18143FC", VA = "0x18143FC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0x1814914", Offset = "0x1814914", VA = "0x1814914")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0x18152B8", Offset = "0x18152B8", VA = "0x18152B8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000455")]
	[Address(RVA = "0x18155C8", Offset = "0x18155C8", VA = "0x18155C8")]
	public gateControl()
	{
	}
}
[Token(Token = "0x200007F")]
public class gateHit : MonoBehaviour
{
	[Token(Token = "0x40004AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private calcBodyMovement move;

	[Token(Token = "0x40004AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private calcBodyPosition body;

	[Token(Token = "0x6000456")]
	[Address(RVA = "0x18155D8", Offset = "0x18155D8", VA = "0x18155D8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0x181566C", Offset = "0x181566C", VA = "0x181566C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0x1815670", Offset = "0x1815670", VA = "0x1815670")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0x1815818", Offset = "0x1815818", VA = "0x1815818")]
	public gateHit()
	{
	}
}
[Token(Token = "0x2000080")]
public class gateKeeper : MonoBehaviour
{
	[Token(Token = "0x40004AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool firstGate;

	[Token(Token = "0x40004AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioSource cowbell;

	[Token(Token = "0x40004AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject scriptHolder;

	[Token(Token = "0x600045A")]
	[Address(RVA = "0x1815820", Offset = "0x1815820", VA = "0x1815820")]
	private void Start()
	{
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0x1815878", Offset = "0x1815878", VA = "0x1815878")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0x1815AA4", Offset = "0x1815AA4", VA = "0x1815AA4")]
	public gateKeeper()
	{
	}
}
[Token(Token = "0x2000081")]
[ExecuteInEditMode]
public class gatePlacementEditor : MonoBehaviour
{
	[Token(Token = "0x40004B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject gatePrefab;

	[Token(Token = "0x40004B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool placeGates;

	[Token(Token = "0x600045D")]
	[Address(RVA = "0x1815AAC", Offset = "0x1815AAC", VA = "0x1815AAC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0x18164D0", Offset = "0x18164D0", VA = "0x18164D0")]
	public gatePlacementEditor()
	{
	}
}
[Token(Token = "0x2000082")]
public class getSpectrum : MonoBehaviour
{
	[Token(Token = "0x2000179")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFF78", Offset = "0x7FFF78")]
	private sealed class <>c__DisplayClass13_0
	{
		[Token(Token = "0x4000BE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float avg1;

		[Token(Token = "0x4000BEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float avg2;

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x1816E74", Offset = "0x1816E74", VA = "0x1816E74")]
		public <>c__DisplayClass13_0()
		{
		}

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x1816F14", Offset = "0x1816F14", VA = "0x1816F14")]
		internal float <ComputeCoeff>b__0(float x1, float y1)
		{
			return default(float);
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x1816F28", Offset = "0x1816F28", VA = "0x1816F28")]
		internal float <ComputeCoeff>b__1(float x)
		{
			return default(float);
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x1816FA0", Offset = "0x1816FA0", VA = "0x1816FA0")]
		internal float <ComputeCoeff>b__2(float y)
		{
			return default(float);
		}
	}

	[Token(Token = "0x40004B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject rhythmDot1;

	[Token(Token = "0x40004B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject rhythmDot2;

	[Token(Token = "0x40004B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private courseRhythm cr;

	[Token(Token = "0x40004B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private playerRhythm pr;

	[Token(Token = "0x40004B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<float> waveForm;

	[Token(Token = "0x40004B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<float> motionDelta;

	[Token(Token = "0x40004B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float[] sampleArray;

	[Token(Token = "0x40004B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private AudioSource track;

	[Token(Token = "0x40004BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject marker;

	[Token(Token = "0x40004BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float markerScaleFac;

	[Token(Token = "0x40004BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float waveIndexLen;

	[Token(Token = "0x600045F")]
	[Address(RVA = "0x18164D8", Offset = "0x18164D8", VA = "0x18164D8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0x1816C9C", Offset = "0x1816C9C", VA = "0x1816C9C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000461")]
	[Address(RVA = "0x1816CA0", Offset = "0x1816CA0", VA = "0x1816CA0")]
	public float ComputeCoeff(float[] values1, float[] values2)
	{
		return default(float);
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0x1816A88", Offset = "0x1816A88", VA = "0x1816A88")]
	public static IList<int> FindPeaks(IList<float> values, int rangeOfPeaks)
	{
		return null;
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x1816E7C", Offset = "0x1816E7C", VA = "0x1816E7C")]
	public getSpectrum()
	{
	}
}
[Token(Token = "0x2000083")]
public class ghostController : MonoBehaviour
{
	[Token(Token = "0x40004BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x40004BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float keepAtDist;

	[Token(Token = "0x40004BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool punt;

	[Token(Token = "0x40004C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool instruct;

	[Token(Token = "0x40004C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	public bool hunch;

	[Token(Token = "0x40004C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
	public bool jump;

	[Token(Token = "0x40004C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float airTimer;

	[Token(Token = "0x40004C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool followMode;

	[Token(Token = "0x40004C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Vector3> wayPointPos;

	[Token(Token = "0x40004C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<float> wayPointTime;

	[Token(Token = "0x40004C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float speedFac;

	[Token(Token = "0x40004C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Color scarfColor;

	[Token(Token = "0x40004C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int delay;

	[Token(Token = "0x40004CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Transform rightFoot;

	[Token(Token = "0x40004CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Transform leftFoot;

	[Token(Token = "0x40004CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Transform rightHand;

	[Token(Token = "0x40004CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Transform leftHand;

	[Token(Token = "0x40004CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Transform bothFoots;

	[Token(Token = "0x40004CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Transform bothHands;

	[Token(Token = "0x40004D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Transform rightStick;

	[Token(Token = "0x40004D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Transform leftStick;

	[Token(Token = "0x40004D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Transform hips;

	[Token(Token = "0x40004D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Transform spine;

	[Token(Token = "0x40004D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Transform dropShadow;

	[Token(Token = "0x40004D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Transform recordAnchor;

	[Token(Token = "0x40004D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private RaycastHit hit;

	[Token(Token = "0x40004D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private ParticleSystem snowClotts;

	[Token(Token = "0x40004D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private Transform scarf;

	[Token(Token = "0x40004D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private LineRenderer scarfLine;

	[Token(Token = "0x40004DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private List<Vector3> scarfPos;

	[Token(Token = "0x40004DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private Vector3 defaultHipRot;

	[Token(Token = "0x40004DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private Vector3 defaultSpineRot;

	[Token(Token = "0x40004DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private Vector3 defaultStickPos;

	[Token(Token = "0x40004DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private Vector3 hunchHipRot;

	[Token(Token = "0x40004DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private Vector3 hunchHipPos;

	[Token(Token = "0x40004E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	private Vector3 hunchSpineRot;

	[Token(Token = "0x40004E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private Vector3 turnRightHand;

	[Token(Token = "0x40004E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	private Vector3 turnLeftHand;

	[Token(Token = "0x40004E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private Vector3 jumpRightFoot;

	[Token(Token = "0x40004E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
	private Vector3 jumpLeftFoot;

	[Token(Token = "0x40004E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private Vector3 jumpHipRot;

	[Token(Token = "0x40004E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
	private Vector3 jumpHipPos;

	[Token(Token = "0x40004E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private Vector3 jumpStickScale;

	[Token(Token = "0x40004E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
	private Vector3 puntAnchorHigh;

	[Token(Token = "0x40004E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private Vector3 puntAnchorLow;

	[Token(Token = "0x40004EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
	private float puntTimer;

	[Token(Token = "0x40004EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private bool init;

	[Token(Token = "0x40004EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
	private float slopeGrad;

	[Token(Token = "0x40004ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private stateManager state;

	[Token(Token = "0x40004EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private courseBuilder course;

	[Token(Token = "0x40004EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private calcBodyMovement move;

	[Token(Token = "0x40004F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private courseRhythm cr;

	[Token(Token = "0x40004F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private Vector3 currentDir;

	[Token(Token = "0x40004F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
	private float currentDist;

	[Token(Token = "0x40004F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private int overShotSign;

	[Token(Token = "0x40004F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
	private float overShotAmount;

	[Token(Token = "0x40004F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public float speed;

	[Token(Token = "0x40004F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private Renderer[] allRenderers;

	[Token(Token = "0x40004F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private float changeTargetTimer;

	[Token(Token = "0x6000464")]
	[Address(RVA = "0x1817018", Offset = "0x1817018", VA = "0x1817018")]
	private void Start()
	{
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0x1817470", Offset = "0x1817470", VA = "0x1817470")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0x181A450", Offset = "0x181A450", VA = "0x181A450")]
	public void jumpPos(Vector3 pos)
	{
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0x181A49C", Offset = "0x181A49C", VA = "0x181A49C")]
	public ghostController()
	{
	}
}
[Token(Token = "0x2000084")]
public class ghostManager : MonoBehaviour
{
	[StructLayout(3)]
	[Token(Token = "0x200017A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFF88", Offset = "0x7FFF88")]
	private struct <spawnGhost>d__11 : IAsyncStateMachine
	{
		[Token(Token = "0x4000BEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000BEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x4000BED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ghostManager <>4__this;

		[Token(Token = "0x4000BEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<sharedRunList> <>u__1;

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x181ACD4", Offset = "0x181ACD4", VA = "0x181ACD4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x181B2B4", Offset = "0x181B2B4", VA = "0x181B2B4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x40004F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject ghostSkierPrefab;

	[Token(Token = "0x40004F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public sharedRunObject runData;

	[Token(Token = "0x40004FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int maxNum;

	[Token(Token = "0x40004FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private calcBodyPosition body;

	[Token(Token = "0x40004FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private stateManager state;

	[Token(Token = "0x40004FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private dataManager data;

	[Token(Token = "0x40004FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private courseRhythm cr;

	[Token(Token = "0x40004FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private connectionManager connection;

	[Token(Token = "0x4000500")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool initGhosts;

	[Token(Token = "0x6000468")]
	[Address(RVA = "0x181A900", Offset = "0x181A900", VA = "0x181A900")]
	private void Start()
	{
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0x181AA20", Offset = "0x181AA20", VA = "0x181AA20")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0x181AC04", Offset = "0x181AC04", VA = "0x181AC04")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x80291C", Offset = "0x80291C")]
	private void spawnGhost()
	{
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0x181ACC4", Offset = "0x181ACC4", VA = "0x181ACC4")]
	public ghostManager()
	{
	}
}
[Token(Token = "0x2000085")]
public class ghostSkierJumpCol : MonoBehaviour
{
	[Token(Token = "0x4000501")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private tutorialManager tutorial;

	[Token(Token = "0x600046C")]
	[Address(RVA = "0x181B2C0", Offset = "0x181B2C0", VA = "0x181B2C0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0x181B324", Offset = "0x181B324", VA = "0x181B324")]
	public ghostSkierJumpCol()
	{
	}
}
[Token(Token = "0x2000086")]
public class gradualActivator : MonoBehaviour
{
	[Token(Token = "0x200017B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFF98", Offset = "0x7FFF98")]
	private sealed class <activationLoop>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000BEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000BF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000BF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public gradualActivator <>4__this;

		[Token(Token = "0x4000BF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <nsize>5__2;

		[Token(Token = "0x17000107")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A81")]
			[Address(RVA = "0x181B668", Offset = "0x181B668", VA = "0x181B668", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000108")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A83")]
			[Address(RVA = "0x181B6D0", Offset = "0x181B6D0", VA = "0x181B6D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x181B3C8", Offset = "0x181B3C8", VA = "0x181B3C8")]
		[DebuggerHidden]
		public <activationLoop>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x181B46C", Offset = "0x181B46C", VA = "0x181B46C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x181B470", Offset = "0x181B470", VA = "0x181B470", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x181B670", Offset = "0x181B670", VA = "0x181B670", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000502")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<GameObject> objectLst;

	[Token(Token = "0x4000503")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int iterations;

	[Token(Token = "0x600046E")]
	[Address(RVA = "0x181B32C", Offset = "0x181B32C", VA = "0x181B32C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0x181B358", Offset = "0x181B358", VA = "0x181B358")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x802980", Offset = "0x802980")]
	private IEnumerator activationLoop()
	{
		return null;
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0x181B3F4", Offset = "0x181B3F4", VA = "0x181B3F4")]
	public gradualActivator()
	{
	}
}
[Token(Token = "0x2000087")]
public class hideOnQ1 : MonoBehaviour
{
	[Token(Token = "0x6000471")]
	[Address(RVA = "0x181B6D8", Offset = "0x181B6D8", VA = "0x181B6D8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0x181B7AC", Offset = "0x181B7AC", VA = "0x181B7AC")]
	public hideOnQ1()
	{
	}
}
[Token(Token = "0x2000088")]
public class hudDisplay : MonoBehaviour
{
	[Token(Token = "0x4000504")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool showHud;

	[Token(Token = "0x4000505")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject fpsDisplay;

	[Token(Token = "0x4000506")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject speedDisplay;

	[Token(Token = "0x4000507")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private calcBodyMovement move;

	[Token(Token = "0x4000508")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float deltaTime;

	[Token(Token = "0x4000509")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float updateRate;

	[Token(Token = "0x400050A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float fps;

	[Token(Token = "0x400050B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int frameCount;

	[Token(Token = "0x6000473")]
	[Address(RVA = "0x181B7B4", Offset = "0x181B7B4", VA = "0x181B7B4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000474")]
	[Address(RVA = "0x181B854", Offset = "0x181B854", VA = "0x181B854")]
	private void Update()
	{
	}

	[Token(Token = "0x6000475")]
	[Address(RVA = "0x181B8D0", Offset = "0x181B8D0", VA = "0x181B8D0")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000476")]
	[Address(RVA = "0x181BA44", Offset = "0x181BA44", VA = "0x181BA44")]
	public hudDisplay()
	{
	}
}
[Token(Token = "0x2000089")]
public class initManager : MonoBehaviour
{
	[StructLayout(3)]
	[Token(Token = "0x200017C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFFA8", Offset = "0x7FFFA8")]
	private struct <waitForUserNameReg>d__15 : IAsyncStateMachine
	{
		[Token(Token = "0x4000BF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000BF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x4000BF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public initManager <>4__this;

		[Token(Token = "0x4000BF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string userName;

		[Token(Token = "0x4000BF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter<bool> <>u__1;

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x181C364", Offset = "0x181C364", VA = "0x181C364", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x181C534", Offset = "0x181C534", VA = "0x181C534", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x200017D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFFB8", Offset = "0x7FFFB8")]
	private sealed class <LoadYourAsyncScene>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000BF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000BF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000BFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string sceneName;

		[Token(Token = "0x4000BFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AsyncOperation <asyncLoad>5__2;

		[Token(Token = "0x17000109")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A89")]
			[Address(RVA = "0x181C2F4", Offset = "0x181C2F4", VA = "0x181C2F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A8B")]
			[Address(RVA = "0x181C35C", Offset = "0x181C35C", VA = "0x181C35C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x181C1EC", Offset = "0x181C1EC", VA = "0x181C1EC")]
		[DebuggerHidden]
		public <LoadYourAsyncScene>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x181C228", Offset = "0x181C228", VA = "0x181C228", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x181C22C", Offset = "0x181C22C", VA = "0x181C22C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x181C2FC", Offset = "0x181C2FC", VA = "0x181C2FC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400050C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private dataManager data;

	[Token(Token = "0x400050D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private connectionManager connection;

	[Token(Token = "0x400050E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool initDone;

	[Token(Token = "0x400050F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	private bool initWaiting;

	[Token(Token = "0x4000510")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	private bool loading;

	[Token(Token = "0x4000511")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private TextMeshProUGUI dots;

	[Token(Token = "0x4000512")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private localizedText info;

	[Token(Token = "0x4000513")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private TextMeshProUGUI version;

	[Token(Token = "0x4000514")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private TextMeshProUGUI infoTxt;

	[Token(Token = "0x4000515")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private OculusIntegration oculusCon;

	[Token(Token = "0x6000477")]
	[Address(RVA = "0x181BA54", Offset = "0x181BA54", VA = "0x181BA54")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0x181BBB8", Offset = "0x181BBB8", VA = "0x181BBB8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0x181BDC8", Offset = "0x181BDC8", VA = "0x181BDC8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0x181BDCC", Offset = "0x181BDCC", VA = "0x181BDCC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0x181BDD0", Offset = "0x181BDD0", VA = "0x181BDD0")]
	private void Update()
	{
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0x181C0B8", Offset = "0x181C0B8", VA = "0x181C0B8")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x8029E4", Offset = "0x8029E4")]
	private void waitForUserNameReg(string userName)
	{
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0x181C08C", Offset = "0x181C08C", VA = "0x181C08C")]
	private void LoadScene(string sceneName)
	{
	}

	[Token(Token = "0x600047E")]
	[Address(RVA = "0x181C17C", Offset = "0x181C17C", VA = "0x181C17C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x802A48", Offset = "0x802A48")]
	private IEnumerator LoadYourAsyncScene(string sceneName)
	{
		return null;
	}

	[Token(Token = "0x600047F")]
	[Address(RVA = "0x181C218", Offset = "0x181C218", VA = "0x181C218")]
	public initManager()
	{
	}
}
[Token(Token = "0x200008A")]
public class instructorBillboardControl : MonoBehaviour
{
	[Token(Token = "0x4000516")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform ghost;

	[Token(Token = "0x4000517")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform player;

	[Token(Token = "0x4000518")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool flip;

	[Token(Token = "0x4000519")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool fromInstructor;

	[Token(Token = "0x400051A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float timeLimit;

	[Token(Token = "0x400051B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float matchTimerLimit;

	[Token(Token = "0x400051C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int type;

	[Token(Token = "0x400051D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float timer;

	[Token(Token = "0x400051E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float fadeTimer;

	[Token(Token = "0x400051F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private SpriteRenderer infoRenderer;

	[Token(Token = "0x4000520")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private SpriteRenderer matchRenderer;

	[Token(Token = "0x4000521")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string spriteName;

	[Token(Token = "0x4000522")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string spriteNameMatch;

	[Token(Token = "0x4000523")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int currentIndex;

	[Token(Token = "0x4000524")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private stateManager state;

	[Token(Token = "0x4000525")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private calcBodyMovement move;

	[Token(Token = "0x4000526")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private tutorialManager tutorial;

	[Token(Token = "0x6000480")]
	[Address(RVA = "0x181C540", Offset = "0x181C540", VA = "0x181C540")]
	private void Start()
	{
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0x181CA24", Offset = "0x181CA24", VA = "0x181CA24")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x181CF04", Offset = "0x181CF04", VA = "0x181CF04")]
	public instructorBillboardControl()
	{
	}
}
[Token(Token = "0x200008B")]
public class instructorCol : MonoBehaviour
{
	[Token(Token = "0x4000527")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int type;

	[Token(Token = "0x4000528")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private tutorialManager tutorial;

	[Token(Token = "0x4000529")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float timer;

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x181CF24", Offset = "0x181CF24", VA = "0x181CF24")]
	private void Start()
	{
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0x181CF94", Offset = "0x181CF94", VA = "0x181CF94")]
	private void Update()
	{
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0x181D06C", Offset = "0x181D06C", VA = "0x181D06C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0x181D17C", Offset = "0x181D17C", VA = "0x181D17C")]
	public instructorCol()
	{
	}
}
[Token(Token = "0x200008C")]
public class loadNewEndlessSection : MonoBehaviour
{
	[Token(Token = "0x200017E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFFC8", Offset = "0x7FFFC8")]
	private sealed class <addEnlessSection>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000BFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000BFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000BFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public loadNewEndlessSection <>4__this;

		[Token(Token = "0x4000BFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 pos;

		[Token(Token = "0x1700010B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A8F")]
			[Address(RVA = "0x181DAFC", Offset = "0x181DAFC", VA = "0x181DAFC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A91")]
			[Address(RVA = "0x181DB64", Offset = "0x181DB64", VA = "0x181DB64", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x181D744", Offset = "0x181D744", VA = "0x181D744")]
		[DebuggerHidden]
		public <addEnlessSection>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x181D778", Offset = "0x181D778", VA = "0x181D778", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x181D77C", Offset = "0x181D77C", VA = "0x181D77C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A90")]
		[Address(RVA = "0x181DB04", Offset = "0x181DB04", VA = "0x181DB04", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400052A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private endlessManager endless;

	[Token(Token = "0x400052B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private courseBuilder course;

	[Token(Token = "0x400052C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private stateManager state;

	[Token(Token = "0x400052D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private courseRhythm cr;

	[Token(Token = "0x400052E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private rhythmManager rm;

	[Token(Token = "0x400052F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private dataManager data;

	[Token(Token = "0x4000530")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool loaded;

	[Token(Token = "0x4000531")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	private bool smooth;

	[Token(Token = "0x4000532")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform endlessPowerUp;

	[Token(Token = "0x6000487")]
	[Address(RVA = "0x181D18C", Offset = "0x181D18C", VA = "0x181D18C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000488")]
	[Address(RVA = "0x181D2B0", Offset = "0x181D2B0", VA = "0x181D2B0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0x181D6B0", Offset = "0x181D6B0", VA = "0x181D6B0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x802AAC", Offset = "0x802AAC")]
	private IEnumerator addEnlessSection(Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0x181D770", Offset = "0x181D770", VA = "0x181D770")]
	public loadNewEndlessSection()
	{
	}
}
[Token(Token = "0x200008D")]
public class loadNewSection : MonoBehaviour
{
	[Token(Token = "0x4000533")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private tutorialManager tutorial;

	[Token(Token = "0x4000534")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private courseBuilder course;

	[Token(Token = "0x4000535")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private stateManager state;

	[Token(Token = "0x4000536")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private courseRhythm cr;

	[Token(Token = "0x4000537")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private dataManager data;

	[Token(Token = "0x4000538")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 newSectionLocation;

	[Token(Token = "0x4000539")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool loaded;

	[Token(Token = "0x400053A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	private bool smooth;

	[Token(Token = "0x600048B")]
	[Address(RVA = "0x181DB6C", Offset = "0x181DB6C", VA = "0x181DB6C")]
	private void Start()
	{
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0x181DC6C", Offset = "0x181DC6C", VA = "0x181DC6C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0x181E4C4", Offset = "0x181E4C4", VA = "0x181E4C4")]
	public loadNewSection()
	{
	}
}
[Token(Token = "0x200008E")]
public class localizedManager : MonoBehaviour
{
	[Token(Token = "0x400053B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Dictionary<string, Dictionary<string, string>> data;

	[Token(Token = "0x400053C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string currentLocal;

	[Token(Token = "0x400053D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<string> header;

	[Token(Token = "0x600048E")]
	[Address(RVA = "0x181E52C", Offset = "0x181E52C", VA = "0x181E52C")]
	public void Awake()
	{
	}

	[Token(Token = "0x600048F")]
	[Address(RVA = "0x181E96C", Offset = "0x181E96C", VA = "0x181E96C")]
	private void setCurrentLocal()
	{
	}

	[Token(Token = "0x6000490")]
	[Address(RVA = "0x181E540", Offset = "0x181E540", VA = "0x181E540")]
	private void readFile()
	{
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0x181EAC0", Offset = "0x181EAC0", VA = "0x181EAC0")]
	public localizedManager()
	{
	}
}
[Token(Token = "0x200008F")]
public class localizedText : MonoBehaviour
{
	[Token(Token = "0x400053E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public string code;

	[Token(Token = "0x400053F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool gui;

	[Token(Token = "0x6000493")]
	[Address(RVA = "0x181EBA4", Offset = "0x181EBA4", VA = "0x181EBA4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000494")]
	[Address(RVA = "0x181BCA8", Offset = "0x181BCA8", VA = "0x181BCA8")]
	public void setText()
	{
	}

	[Token(Token = "0x6000495")]
	[Address(RVA = "0x181EBA8", Offset = "0x181EBA8", VA = "0x181EBA8")]
	public localizedText()
	{
	}
}
[Token(Token = "0x2000090")]
public class menuSkyDrop : MonoBehaviour
{
	[Token(Token = "0x4000540")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private calcBodyPosition body;

	[Token(Token = "0x4000541")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem groundSnowEffect;

	[Token(Token = "0x4000542")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioSource groundSoundEffect;

	[Token(Token = "0x4000543")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Rigidbody rb;

	[Token(Token = "0x4000544")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float downForce;

	[Token(Token = "0x4000545")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float downForceDamp;

	[Token(Token = "0x6000496")]
	[Address(RVA = "0x181EE58", Offset = "0x181EE58", VA = "0x181EE58")]
	private void Start()
	{
	}

	[Token(Token = "0x6000497")]
	[Address(RVA = "0x181F074", Offset = "0x181F074", VA = "0x181F074")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0x181F154", Offset = "0x181F154", VA = "0x181F154")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0x181F780", Offset = "0x181F780", VA = "0x181F780")]
	public menuSkyDrop()
	{
	}
}
[Token(Token = "0x2000091")]
public class mogulManager : MonoBehaviour
{
	[Token(Token = "0x4000546")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject mogul;

	[Token(Token = "0x4000547")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private courseBuilder course;

	[Token(Token = "0x4000548")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private calcBodyMovement move;

	[Token(Token = "0x4000549")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private calcBodyPosition body;

	[Token(Token = "0x400054A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int lastDropedAtIndex;

	[Token(Token = "0x600049A")]
	[Address(RVA = "0x181F794", Offset = "0x181F794", VA = "0x181F794")]
	private void Start()
	{
	}

	[Token(Token = "0x600049B")]
	[Address(RVA = "0x1814DFC", Offset = "0x1814DFC", VA = "0x1814DFC")]
	public void spawnMoguls(Vector3 pos, Transform owener)
	{
	}

	[Token(Token = "0x600049C")]
	[Address(RVA = "0x181FD28", Offset = "0x181FD28", VA = "0x181FD28")]
	public mogulManager()
	{
	}
}
[Token(Token = "0x2000092")]
public class multiplayerAvatar : MonoBehaviour
{
	[Token(Token = "0x400054B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string playerAvatarName;

	[Token(Token = "0x400054C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string currentRoom;

	[Token(Token = "0x400054D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public DatabaseReference dbRef;

	[Token(Token = "0x400054E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public LineRenderer line;

	[Token(Token = "0x400054F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI text;

	[Token(Token = "0x4000550")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private CharacterController CharControl;

	[Token(Token = "0x4000551")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Transform head;

	[Token(Token = "0x4000552")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Transform leftHand;

	[Token(Token = "0x4000553")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Transform rightHand;

	[Token(Token = "0x4000554")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Transform leftFoot;

	[Token(Token = "0x4000555")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Transform rightFoot;

	[Token(Token = "0x4000556")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Transform hip;

	[Token(Token = "0x4000557")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Transform spine;

	[Token(Token = "0x4000558")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Transform leftStick;

	[Token(Token = "0x4000559")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Transform rightStick;

	[Token(Token = "0x400055A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private string latestKownScene;

	[Token(Token = "0x400055B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Vector3 latestKownPosition;

	[Token(Token = "0x400055C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private Vector3 latestKownLeftPosition;

	[Token(Token = "0x400055D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 latestKownRightPosition;

	[Token(Token = "0x400055E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Vector3 latestKownSkiVector;

	[Token(Token = "0x400055F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Vector3 latestKownEyeDirection;

	[Token(Token = "0x4000560")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private Vector3 latestKownBodyDirection;

	[Token(Token = "0x4000561")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Vector3 prevKownPosition;

	[Token(Token = "0x4000562")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private Vector3 prevKownSkiVector;

	[Token(Token = "0x4000563")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private Vector3 currentSkiVector;

	[Token(Token = "0x4000564")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private float predictedRotation;

	[Token(Token = "0x4000565")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private float predictedAcceleration;

	[Token(Token = "0x4000566")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private Vector3 avatarFrameMove;

	[Token(Token = "0x4000567")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private Vector3 avatarDiffVector;

	[Token(Token = "0x4000568")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	private float avatarSpeed;

	[Token(Token = "0x4000569")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private Material mat;

	[Token(Token = "0x400056A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private Vector3 startPosDir;

	[Token(Token = "0x400056B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	private Quaternion startPosRot;

	[Token(Token = "0x400056C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	private RaycastHit hit;

	[Token(Token = "0x400056D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private float destroyTimer;

	[Token(Token = "0x400056E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
	private int destoryLimit;

	[Token(Token = "0x400056F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private bool scoreSet;

	[Token(Token = "0x4000570")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x181")]
	private bool scoreInfoSent;

	[Token(Token = "0x4000571")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x182")]
	private bool initPos;

	[Token(Token = "0x4000572")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
	private Vector3 r1;

	[Token(Token = "0x4000573")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private Vector3 r2;

	[Token(Token = "0x4000574")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
	private Vector3 r3;

	[Token(Token = "0x4000575")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private Vector3 r1t;

	[Token(Token = "0x4000576")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
	private Vector3 r2t;

	[Token(Token = "0x4000577")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private Vector3 r3t;

	[Token(Token = "0x4000578")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
	private Quaternion r4;

	[Token(Token = "0x4000579")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
	private Quaternion r4t;

	[Token(Token = "0x400057A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
	private float t1;

	[Token(Token = "0x400057B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private float t2;

	[Token(Token = "0x400057C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
	private float t3;

	[Token(Token = "0x400057D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private float rTimer;

	[Token(Token = "0x400057E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private GameObject avatarBody;

	[Token(Token = "0x400057F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private Renderer[] renders;

	[Token(Token = "0x4000580")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private ParticleSystem snow;

	[Token(Token = "0x4000581")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private ParticleSystem glow;

	[Token(Token = "0x4000582")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private DatabaseReference dbRefLocal;

	[Token(Token = "0x4000583")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private stateManager state;

	[Token(Token = "0x4000584")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private multiplayerManager multiplayer;

	[Token(Token = "0x4000585")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private UIManager UI;

	[Token(Token = "0x4000586")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	private walkieTalkieNotifyManager notify;

	[Token(Token = "0x600049D")]
	[Address(RVA = "0x181FD38", Offset = "0x181FD38", VA = "0x181FD38")]
	private void Start()
	{
	}

	[Token(Token = "0x600049E")]
	[Address(RVA = "0x1820094", Offset = "0x1820094", VA = "0x1820094")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600049F")]
	[Address(RVA = "0x1820208", Offset = "0x1820208", VA = "0x1820208")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0x182174C", Offset = "0x182174C", VA = "0x182174C")]
	private void updatePlayerAvatar(object sender, ChildChangedEventArgs args)
	{
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0x1822AB4", Offset = "0x1822AB4", VA = "0x1822AB4")]
	private void syncAvatarPosition()
	{
	}

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0x18221D0", Offset = "0x18221D0", VA = "0x18221D0")]
	private void readSignal(playerDataMeta playerMeta)
	{
	}

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0x1822CCC", Offset = "0x1822CCC", VA = "0x1822CCC")]
	public multiplayerAvatar()
	{
	}
}
[Token(Token = "0x2000093")]
public class playerDataRealTime
{
	[Token(Token = "0x4000587")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3Int w;

	[Token(Token = "0x4000588")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3Int l;

	[Token(Token = "0x4000589")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3Int r;

	[Token(Token = "0x400058A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Vector3Int s;

	[Token(Token = "0x400058B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int e;

	[Token(Token = "0x400058C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int b;

	[Token(Token = "0x60004A4")]
	[Address(RVA = "0xB8B1A4", Offset = "0xB8B1A4", VA = "0xB8B1A4")]
	public playerDataRealTime()
	{
	}
}
[Token(Token = "0x2000094")]
public class playerDataMeta
{
	[Token(Token = "0x400058D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string c;

	[Token(Token = "0x400058E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string s;

	[Token(Token = "0x400058F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string pn;

	[Token(Token = "0x4000590")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int i;

	[Token(Token = "0x4000591")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Color pc;

	[Token(Token = "0x60004A5")]
	[Address(RVA = "0xB8B19C", Offset = "0xB8B19C", VA = "0xB8B19C")]
	public playerDataMeta()
	{
	}
}
[Token(Token = "0x2000095")]
public class syncedRaceSetup
{
	[Token(Token = "0x4000592")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<Vector3> path;

	[Token(Token = "0x4000593")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Vector2Int> gateIndex;

	[Token(Token = "0x4000594")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int difficulty;

	[Token(Token = "0x60004A6")]
	[Address(RVA = "0x147CA10", Offset = "0x147CA10", VA = "0x147CA10")]
	public syncedRaceSetup()
	{
	}
}
[Token(Token = "0x2000096")]
public class multiplayerManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200017F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFFD8", Offset = "0x7FFFD8")]
	private sealed class <>c
	{
		[Token(Token = "0x4000C00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000C01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<Task<FirebaseUser>> <>9__39_0;

		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x1826B60", Offset = "0x1826B60", VA = "0x1826B60")]
		public <>c()
		{
		}

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x1826B68", Offset = "0x1826B68", VA = "0x1826B68")]
		internal void <Start>b__39_0(Task<FirebaseUser> task)
		{
		}
	}

	[Token(Token = "0x4000595")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject playerAvatarPrefab;

	[Token(Token = "0x4000596")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<TextMeshProUGUI> playerNamesTexts;

	[Token(Token = "0x4000597")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<LineRenderer> playerNamesLines;

	[Token(Token = "0x4000598")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private TextMeshProUGUI roomNameText;

	[Token(Token = "0x4000599")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject p2pVoicePrefab;

	[Token(Token = "0x400059A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string apiVersion;

	[Token(Token = "0x400059B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string currentRoom;

	[Token(Token = "0x400059C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string signal;

	[Token(Token = "0x400059D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float inProximityTimer;

	[Token(Token = "0x400059E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int syncedRaceStatus;

	[Token(Token = "0x400059F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string syncedRaceID;

	[Token(Token = "0x40005A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Dictionary<string, List<string>> playersInSyncedRace;

	[Token(Token = "0x40005A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int syncedRaceCount;

	[Token(Token = "0x40005A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int forcedLatency;

	[Token(Token = "0x40005A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int roomSizeLimit;

	[Token(Token = "0x40005A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int roomSizeCurrent;

	[Token(Token = "0x40005A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float timerRT;

	[Token(Token = "0x40005A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float timerMD;

	[Token(Token = "0x40005A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool inRoom;

	[Token(Token = "0x40005A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	private bool quickJoinMode;

	[Token(Token = "0x40005A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int quickJoinIndex;

	[Token(Token = "0x40005AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private string quickRoomPrefix;

	[Token(Token = "0x40005AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private DatabaseReference dbRef;

	[Token(Token = "0x40005AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private playerDataRealTime myRealTimeData;

	[Token(Token = "0x40005AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private playerDataMeta myMetaData;

	[Token(Token = "0x40005AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private List<string> playersWaitingToSpawn;

	[Token(Token = "0x40005AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private List<string> playersInRoom;

	[Token(Token = "0x40005B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private string roomJoined;

	[Token(Token = "0x40005B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private int joinRetryCount;

	[Token(Token = "0x40005B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static string playerDataBaseName;

	[Token(Token = "0x40005B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static Color playerColor;

	[Token(Token = "0x40005B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private PureP2PCommsNetwork p2pNetwork;

	[Token(Token = "0x40005B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private float voiceTimer;

	[Token(Token = "0x40005B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public float closestAvatar;

	[Token(Token = "0x40005B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private calcBodyPosition body;

	[Token(Token = "0x40005B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private calcBodyMovement move;

	[Token(Token = "0x40005B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private stateManager state;

	[Token(Token = "0x40005BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private courseBuilder course;

	[Token(Token = "0x40005BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private UIManager UI;

	[Token(Token = "0x60004A7")]
	[Address(RVA = "0x1822DE4", Offset = "0x1822DE4", VA = "0x1822DE4")]
	private void Start()
	{
	}

	[Token(Token = "0x60004A8")]
	[Address(RVA = "0x18232D4", Offset = "0x18232D4", VA = "0x18232D4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60004A9")]
	[Address(RVA = "0x18238B0", Offset = "0x18238B0", VA = "0x18238B0")]
	private void OnApplicationPause(bool isPaused)
	{
	}

	[Token(Token = "0x60004AA")]
	[Address(RVA = "0x18239B4", Offset = "0x18239B4", VA = "0x18239B4")]
	private void Update()
	{
	}

	[Token(Token = "0x60004AB")]
	[Address(RVA = "0x18258BC", Offset = "0x18258BC", VA = "0x18258BC")]
	private void joinRoom()
	{
	}

	[Token(Token = "0x60004AC")]
	[Address(RVA = "0x182335C", Offset = "0x182335C", VA = "0x182335C")]
	public void leaveRoom(bool light = false)
	{
	}

	[Token(Token = "0x60004AD")]
	[Address(RVA = "0x1825418", Offset = "0x1825418", VA = "0x1825418")]
	private void spawnAvatar(string avatarName, [Optional] LineRenderer line, [Optional] TextMeshProUGUI text)
	{
	}

	[Token(Token = "0x60004AE")]
	[Address(RVA = "0x1825798", Offset = "0x1825798", VA = "0x1825798")]
	public void investigateRoom()
	{
	}

	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x1825ABC", Offset = "0x1825ABC", VA = "0x1825ABC")]
	private void playerJoined(object sender, ChildChangedEventArgs args)
	{
	}

	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x1825B80", Offset = "0x1825B80", VA = "0x1825B80")]
	private void playerLeft(object sender, ChildChangedEventArgs args)
	{
	}

	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x1824EFC", Offset = "0x1824EFC", VA = "0x1824EFC")]
	private void sendRealTimeData()
	{
	}

	[Token(Token = "0x60004B2")]
	[Address(RVA = "0x1824D88", Offset = "0x1824D88", VA = "0x1824D88")]
	public void sendMetaData()
	{
	}

	[Token(Token = "0x60004B3")]
	[Address(RVA = "0x1825CD8", Offset = "0x1825CD8", VA = "0x1825CD8")]
	public void createSyncedRace()
	{
	}

	[Token(Token = "0x60004B4")]
	[Address(RVA = "0x1825F0C", Offset = "0x1825F0C", VA = "0x1825F0C")]
	public void acceptSyncedRace()
	{
	}

	[Token(Token = "0x60004B5")]
	[Address(RVA = "0x1825604", Offset = "0x1825604", VA = "0x1825604")]
	public void cancelSyncedRace()
	{
	}

	[Token(Token = "0x60004B6")]
	[Address(RVA = "0x1826058", Offset = "0x1826058", VA = "0x1826058")]
	public void startSyncedRace()
	{
	}

	[Token(Token = "0x60004B7")]
	[Address(RVA = "0x1826100", Offset = "0x1826100", VA = "0x1826100")]
	private void _forceBegin()
	{
	}

	[Token(Token = "0x60004B8")]
	[Address(RVA = "0x18256A4", Offset = "0x18256A4", VA = "0x18256A4")]
	public void clearLables()
	{
	}

	[Token(Token = "0x60004B9")]
	[Address(RVA = "0x1826184", Offset = "0x1826184", VA = "0x1826184")]
	public void quickJoin()
	{
	}

	[Token(Token = "0x60004BA")]
	[Address(RVA = "0x1826248", Offset = "0x1826248", VA = "0x1826248")]
	public multiplayerManager()
	{
	}

	[Token(Token = "0x60004BC")]
	[Address(RVA = "0x182641C", Offset = "0x182641C", VA = "0x182641C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x802B10", Offset = "0x802B10")]
	private void <investigateRoom>b__46_0(Task<DataSnapshot> task)
	{
	}

	[Token(Token = "0x60004BD")]
	[Address(RVA = "0x182695C", Offset = "0x182695C", VA = "0x182695C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x802B20", Offset = "0x802B20")]
	private void <acceptSyncedRace>b__52_0(Task<DataSnapshot> task)
	{
	}
}
[Token(Token = "0x2000097")]
public class multiplayerTestManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000180")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFFE8", Offset = "0x7FFFE8")]
	private sealed class <>c
	{
		[Token(Token = "0x4000C02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000C03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<Task<FirebaseUser>> <>9__38_0;

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0xB87FFC", Offset = "0xB87FFC", VA = "0xB87FFC")]
		public <>c()
		{
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0xB88004", Offset = "0xB88004", VA = "0xB88004")]
		internal void <Start>b__38_0(Task<FirebaseUser> task)
		{
		}
	}

	[Token(Token = "0x40005BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject playerAvatarPrefab;

	[Token(Token = "0x40005BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<TextMeshProUGUI> playerNamesTexts;

	[Token(Token = "0x40005BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<LineRenderer> playerNamesLines;

	[Token(Token = "0x40005BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private TextMeshProUGUI roomNameText;

	[Token(Token = "0x40005C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject p2pVoicePrefab;

	[Token(Token = "0x40005C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string apiVersion;

	[Token(Token = "0x40005C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string currentRoom;

	[Token(Token = "0x40005C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string signal;

	[Token(Token = "0x40005C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float inProximityTimer;

	[Token(Token = "0x40005C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int syncedRaceStatus;

	[Token(Token = "0x40005C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string syncedRaceID;

	[Token(Token = "0x40005C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Dictionary<string, List<string>> playersInSyncedRace;

	[Token(Token = "0x40005C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int syncedRaceCount;

	[Token(Token = "0x40005C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int forcedLatency;

	[Token(Token = "0x40005CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int roomSizeLimit;

	[Token(Token = "0x40005CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int roomSizeCurrent;

	[Token(Token = "0x40005CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float timerRT;

	[Token(Token = "0x40005CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private float timerMD;

	[Token(Token = "0x40005CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool inRoom;

	[Token(Token = "0x40005CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
	private bool quickJoinMode;

	[Token(Token = "0x40005D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private int quickJoinIndex;

	[Token(Token = "0x40005D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private string quickRoomPrefix;

	[Token(Token = "0x40005D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private DatabaseReference dbRef;

	[Token(Token = "0x40005D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private playerDataRealTime myRealTimeData;

	[Token(Token = "0x40005D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private playerDataMeta myMetaData;

	[Token(Token = "0x40005D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private List<string> playersWaitingToSpawn;

	[Token(Token = "0x40005D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private List<string> playersInRoom;

	[Token(Token = "0x40005D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private string roomJoined;

	[Token(Token = "0x40005D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private int joinRetryCount;

	[Token(Token = "0x40005D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public string playerDataBaseName;

	[Token(Token = "0x40005DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private Color playerColor;

	[Token(Token = "0x40005DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private PureP2PCommsNetwork p2pNetwork;

	[Token(Token = "0x40005DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private float voiceTimer;

	[Token(Token = "0x40005DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private calcBodyPosition body;

	[Token(Token = "0x40005DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private calcBodyMovement move;

	[Token(Token = "0x40005DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private stateManager state;

	[Token(Token = "0x40005E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private courseBuilder course;

	[Token(Token = "0x40005E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private UIManager UI;

	[Token(Token = "0x60004BE")]
	[Address(RVA = "0x1826D64", Offset = "0x1826D64", VA = "0x1826D64")]
	private void Start()
	{
	}

	[Token(Token = "0x60004BF")]
	[Address(RVA = "0x1827104", Offset = "0x1827104", VA = "0x1827104")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60004C0")]
	[Address(RVA = "0x18275F0", Offset = "0x18275F0", VA = "0x18275F0")]
	private void Update()
	{
	}

	[Token(Token = "0x60004C1")]
	[Address(RVA = "0x1828B28", Offset = "0x1828B28", VA = "0x1828B28")]
	private void joinRoom()
	{
	}

	[Token(Token = "0x60004C2")]
	[Address(RVA = "0x1827128", Offset = "0x1827128", VA = "0x1827128")]
	private void leaveRoom()
	{
	}

	[Token(Token = "0x60004C3")]
	[Address(RVA = "0x1828C8C", Offset = "0x1828C8C", VA = "0x1828C8C")]
	private void spawnAvatar(string avatarName, [Optional] LineRenderer line, [Optional] TextMeshProUGUI text)
	{
	}

	[Token(Token = "0x60004C4")]
	[Address(RVA = "0x1828A40", Offset = "0x1828A40", VA = "0x1828A40")]
	public void investigateRoom()
	{
	}

	[Token(Token = "0x60004C5")]
	[Address(RVA = "0x1828E3C", Offset = "0x1828E3C", VA = "0x1828E3C")]
	private void playerJoined(object sender, ChildChangedEventArgs args)
	{
	}

	[Token(Token = "0x60004C6")]
	[Address(RVA = "0x1828F00", Offset = "0x1828F00", VA = "0x1828F00")]
	private void playerLeft(object sender, ChildChangedEventArgs args)
	{
	}

	[Token(Token = "0x60004C7")]
	[Address(RVA = "0x1828494", Offset = "0x1828494", VA = "0x1828494")]
	private void sendRealTimeData()
	{
	}

	[Token(Token = "0x60004C8")]
	[Address(RVA = "0x1828368", Offset = "0x1828368", VA = "0x1828368")]
	public void sendMetaData()
	{
	}

	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x1829058", Offset = "0x1829058", VA = "0x1829058")]
	public void createSyncedRace()
	{
	}

	[Token(Token = "0x60004CA")]
	[Address(RVA = "0x1829248", Offset = "0x1829248", VA = "0x1829248")]
	public void acceptSyncedRace()
	{
	}

	[Token(Token = "0x60004CB")]
	[Address(RVA = "0x18288AC", Offset = "0x18288AC", VA = "0x18288AC")]
	public void cancelSyncedRace()
	{
	}

	[Token(Token = "0x60004CC")]
	[Address(RVA = "0x1829358", Offset = "0x1829358", VA = "0x1829358")]
	public void startSyncedRace()
	{
	}

	[Token(Token = "0x60004CD")]
	[Address(RVA = "0x1829400", Offset = "0x1829400", VA = "0x1829400")]
	private void _forceBegin()
	{
	}

	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x182894C", Offset = "0x182894C", VA = "0x182894C")]
	public void clearLables()
	{
	}

	[Token(Token = "0x60004CF")]
	[Address(RVA = "0x1829484", Offset = "0x1829484", VA = "0x1829484")]
	public void quickJoin()
	{
	}

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x1829518", Offset = "0x1829518", VA = "0x1829518")]
	public multiplayerTestManager()
	{
	}

	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x182968C", Offset = "0x182968C", VA = "0x182968C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x802B30", Offset = "0x802B30")]
	private void <investigateRoom>b__44_0(Task<DataSnapshot> task)
	{
	}

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x1829A48", Offset = "0x1829A48", VA = "0x1829A48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x802B40", Offset = "0x802B40")]
	private void <acceptSyncedRace>b__50_0(Task<DataSnapshot> task)
	{
	}
}
[Token(Token = "0x2000098")]
public class musicLib : MonoBehaviour
{
	[Token(Token = "0x40005E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<AudioClip> musicLst;

	[Token(Token = "0x40005E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<TextAsset> rawBeatMapLst;

	[Token(Token = "0x40005E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<List<float>> beatMapLst;

	[Token(Token = "0x40005E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool customMusic;

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0xB88200", Offset = "0xB88200", VA = "0xB88200")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004D4")]
	[Address(RVA = "0xB8838C", Offset = "0xB8838C", VA = "0xB8838C")]
	public musicLib()
	{
	}
}
[Token(Token = "0x2000099")]
public class musicPlayer : MonoBehaviour
{
	[Token(Token = "0x40005E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AudioSource player;

	[Token(Token = "0x40005E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform playIcon;

	[Token(Token = "0x40005E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<Transform> songPosLst;

	[Token(Token = "0x40005E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<TextMeshProUGUI> songTitleLst;

	[Token(Token = "0x40005EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RawImage zane;

	[Token(Token = "0x40005EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RawImage custom;

	[Token(Token = "0x40005EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<float> beatMap;

	[Token(Token = "0x40005ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float beatMapCurrent;

	[Token(Token = "0x40005EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float timer;

	[Token(Token = "0x40005EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3 playIconScale;

	[Token(Token = "0x40005F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int songIndex;

	[Token(Token = "0x40005F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private stateManager state;

	[Token(Token = "0x40005F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private UIManager UI;

	[Token(Token = "0x40005F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private musicLib music;

	[Token(Token = "0x60004D5")]
	[Address(RVA = "0xB883FC", Offset = "0xB883FC", VA = "0xB883FC")]
	private void Start()
	{
	}

	[Token(Token = "0x60004D6")]
	[Address(RVA = "0xB886C0", Offset = "0xB886C0", VA = "0xB886C0")]
	private void Update()
	{
	}

	[Token(Token = "0x60004D7")]
	[Address(RVA = "0xB88B84", Offset = "0xB88B84", VA = "0xB88B84")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60004D8")]
	[Address(RVA = "0xB88C74", Offset = "0xB88C74", VA = "0xB88C74")]
	public void playSong(int selectedSongIndex)
	{
	}

	[Token(Token = "0x60004D9")]
	[Address(RVA = "0xB88E58", Offset = "0xB88E58", VA = "0xB88E58")]
	public musicPlayer()
	{
	}
}
[Token(Token = "0x200009A")]
public class obstacleCourseBuilder : MonoBehaviour
{
	[Token(Token = "0x40005F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Transform> pulseSpawnPoints;

	[Token(Token = "0x40005F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private UnityEngine.Object pulseObj;

	[Token(Token = "0x40005F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private calcBodyPosition body;

	[Token(Token = "0x60004DA")]
	[Address(RVA = "0xB88EF8", Offset = "0xB88EF8", VA = "0xB88EF8")]
	private void Start()
	{
	}

	[Token(Token = "0x60004DB")]
	[Address(RVA = "0xB89278", Offset = "0xB89278", VA = "0xB89278")]
	public obstacleCourseBuilder()
	{
	}
}
[Token(Token = "0x200009B")]
public class obstacleHit : MonoBehaviour
{
	[Token(Token = "0x40005F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float hitPenalty;

	[Token(Token = "0x40005F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool causeDamage;

	[Token(Token = "0x40005F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool causeCrash;

	[Token(Token = "0x40005FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	public bool emitSnow;

	[Token(Token = "0x40005FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject emitParticle;

	[Token(Token = "0x40005FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private stateManager state;

	[Token(Token = "0x40005FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private dataManager data;

	[Token(Token = "0x40005FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private calcBodyMovement move;

	[Token(Token = "0x40005FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private damageManager damage;

	[Token(Token = "0x4000600")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private calcBodyPosition body;

	[Token(Token = "0x60004DC")]
	[Address(RVA = "0xB89280", Offset = "0xB89280", VA = "0xB89280")]
	private void Start()
	{
	}

	[Token(Token = "0x60004DD")]
	[Address(RVA = "0xB893D0", Offset = "0xB893D0", VA = "0xB893D0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60004DE")]
	[Address(RVA = "0xB89918", Offset = "0xB89918", VA = "0xB89918")]
	public obstacleHit()
	{
	}
}
[Token(Token = "0x200009C")]
public class particleEffects : MonoBehaviour
{
	[Token(Token = "0x4000601")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioSource skiAmbienceInit;

	[Token(Token = "0x4000602")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioSource skiAmbience1;

	[Token(Token = "0x4000603")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioSource skiAmbience2;

	[Token(Token = "0x4000604")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AudioSource skiAmbience3;

	[Token(Token = "0x4000605")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AudioSource skiTurn;

	[Token(Token = "0x4000606")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AudioSource skiTurnAlt;

	[Token(Token = "0x4000607")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AudioSource skiGrounding;

	[Token(Token = "0x4000608")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ParticleSystem cowbellEffect;

	[Token(Token = "0x4000609")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool showSnowEffects;

	[Token(Token = "0x400060A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int sideSnowAmount;

	[Token(Token = "0x400060B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float snowBallAmount;

	[Token(Token = "0x400060C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float rumbleStr;

	[Token(Token = "0x400060D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float rumbleFreq;

	[Token(Token = "0x400060E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float pulseTimer;

	[Token(Token = "0x400060F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int speedStripeAmount;

	[Token(Token = "0x4000610")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private calcBodyMovement move;

	[Token(Token = "0x4000611")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private calcBodyPosition body;

	[Token(Token = "0x4000612")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private stateManager state;

	[Token(Token = "0x4000613")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private slopeLocomotion slope;

	[Token(Token = "0x4000614")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private courseRhythm cr;

	[Token(Token = "0x4000615")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private rhythmManager rm;

	[Token(Token = "0x4000616")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private courseBuilder course;

	[Token(Token = "0x4000617")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private ParticleSystem sideSnowR;

	[Token(Token = "0x4000618")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private ParticleSystem sideSnowL;

	[Token(Token = "0x4000619")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private GameObject dropShadow;

	[Token(Token = "0x400061A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private SpriteRenderer dropShadowImage;

	[Token(Token = "0x400061B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private float dropShadowJumpPos;

	[Token(Token = "0x400061C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private AudioSource hearthSound;

	[Token(Token = "0x400061D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Transform skies;

	[Token(Token = "0x400061E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Transform sprite1Trans;

	[Token(Token = "0x400061F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private SpriteRenderer sprite1;

	[Token(Token = "0x4000620")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private Color sprite1Color;

	[Token(Token = "0x4000621")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private float sprite1Alpha;

	[Token(Token = "0x4000622")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private float snowBallAmountResetTimer;

	[Token(Token = "0x4000623")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private List<Transform> hitFlashLst;

	[Token(Token = "0x4000624")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private UnityEngine.Object whiteShard;

	[Token(Token = "0x4000625")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private float rumbleTime;

	[Token(Token = "0x60004DF")]
	[Address(RVA = "0xB89928", Offset = "0xB89928", VA = "0xB89928")]
	public void playCowbellEffect()
	{
	}

	[Token(Token = "0x60004E0")]
	[Address(RVA = "0xB8992C", Offset = "0xB8992C", VA = "0xB8992C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004E1")]
	[Address(RVA = "0xB89D74", Offset = "0xB89D74", VA = "0xB89D74")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60004E2")]
	[Address(RVA = "0xB8AF90", Offset = "0xB8AF90", VA = "0xB8AF90")]
	public void stopRumble()
	{
	}

	[Token(Token = "0x60004E3")]
	[Address(RVA = "0xB8AF98", Offset = "0xB8AF98", VA = "0xB8AF98")]
	public particleEffects()
	{
	}
}
[Token(Token = "0x200009D")]
[ExecuteInEditMode]
public class pineBillBoardInit : MonoBehaviour
{
	[Token(Token = "0x60004E4")]
	[Address(RVA = "0xB8B028", Offset = "0xB8B028", VA = "0xB8B028")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004E5")]
	[Address(RVA = "0xB8B194", Offset = "0xB8B194", VA = "0xB8B194")]
	public pineBillBoardInit()
	{
	}
}
[Token(Token = "0x200009E")]
public class playerRhythm : MonoBehaviour
{
	[Token(Token = "0x2000181")]
	public class stateObj
	{
		[Token(Token = "0x4000C04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isPaused;

		[Token(Token = "0x4000C05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool doRhythm;

		[Token(Token = "0x4000C06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool gameOver;

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0xB8B438", Offset = "0xB8B438", VA = "0xB8B438")]
		public stateObj()
		{
		}
	}

	[Token(Token = "0x4000626")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float frameMotion;

	[Token(Token = "0x4000627")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private calcBodyPosition body;

	[Token(Token = "0x4000628")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private stateManager state;

	[Token(Token = "0x4000629")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 lastHeading;

	[Token(Token = "0x400062A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 lastEyeDir;

	[Token(Token = "0x60004E6")]
	[Address(RVA = "0xB8B1AC", Offset = "0xB8B1AC", VA = "0xB8B1AC")]
	private void Start()
	{
	}

	[Token(Token = "0x60004E7")]
	[Address(RVA = "0xB8B240", Offset = "0xB8B240", VA = "0xB8B240")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60004E8")]
	[Address(RVA = "0xB8B3B0", Offset = "0xB8B3B0", VA = "0xB8B3B0")]
	public playerRhythm()
	{
	}
}
[Token(Token = "0x200009F")]
public class powerDownTrigger : MonoBehaviour
{
	[Token(Token = "0x400062B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float beatTargetTime;

	[Token(Token = "0x400062C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private calcBodyPosition body;

	[Token(Token = "0x400062D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private calcBodyMovement move;

	[Token(Token = "0x400062E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private stateManager state;

	[Token(Token = "0x400062F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private damageManager damage;

	[Token(Token = "0x4000630")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private courseRhythm cr;

	[Token(Token = "0x4000631")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private particleEffects effect;

	[Token(Token = "0x4000632")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private ParticleSystem effectRing;

	[Token(Token = "0x4000633")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private ParticleSystem effectTail;

	[Token(Token = "0x4000634")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float aliveTimer;

	[Token(Token = "0x4000635")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private CharacterController charControl;

	[Token(Token = "0x4000636")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float verMotionFac;

	[Token(Token = "0x4000637")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float horMotionFac;

	[Token(Token = "0x4000638")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 randomOffset;

	[Token(Token = "0x4000639")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Vector3 generalDirection;

	[Token(Token = "0x400063A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private bool hit;

	[Token(Token = "0x400063B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private GameObject star;

	[Token(Token = "0x400063C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private GameObject p1;

	[Token(Token = "0x400063D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private GameObject p2;

	[Token(Token = "0x60004E9")]
	[Address(RVA = "0xB8B448", Offset = "0xB8B448", VA = "0xB8B448")]
	private void Start()
	{
	}

	[Token(Token = "0x60004EA")]
	[Address(RVA = "0xB8B73C", Offset = "0xB8B73C", VA = "0xB8B73C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60004EB")]
	[Address(RVA = "0xB8BB2C", Offset = "0xB8BB2C", VA = "0xB8BB2C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60004EC")]
	[Address(RVA = "0xB8BEA4", Offset = "0xB8BEA4", VA = "0xB8BEA4")]
	public powerDownTrigger()
	{
	}
}
[Token(Token = "0x20000A0")]
public class powerUpTrigger : MonoBehaviour
{
	[Token(Token = "0x400063E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float beatTargetTime;

	[Token(Token = "0x400063F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<AudioClip> hitSounds;

	[Token(Token = "0x4000640")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private calcBodyPosition body;

	[Token(Token = "0x4000641")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private calcBodyMovement move;

	[Token(Token = "0x4000642")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private stateManager state;

	[Token(Token = "0x4000643")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private courseRhythm cr;

	[Token(Token = "0x4000644")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private courseBuilder cource;

	[Token(Token = "0x4000645")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private particleEffects effect;

	[Token(Token = "0x4000646")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private ParticleSystem effectRing;

	[Token(Token = "0x4000647")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private ParticleSystem effectTail;

	[Token(Token = "0x4000648")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private ParticleSystem effectCollected;

	[Token(Token = "0x4000649")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private GameObject hitFlash;

	[Token(Token = "0x400064A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private AudioSource hitSound;

	[Token(Token = "0x400064B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float aliveTimer;

	[Token(Token = "0x400064C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private CharacterController charControl;

	[Token(Token = "0x400064D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float verticalMotionFac;

	[Token(Token = "0x400064E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float verticalMotionFacTarget;

	[Token(Token = "0x400064F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Vector3 randomOffset;

	[Token(Token = "0x4000650")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private Vector3 generalDirection;

	[Token(Token = "0x4000651")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private bool hit;

	[Token(Token = "0x4000652")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private GameObject ring;

	[Token(Token = "0x4000653")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private GameObject ringHalf1;

	[Token(Token = "0x4000654")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private GameObject ringHalf2;

	[Token(Token = "0x60004ED")]
	[Address(RVA = "0xB8BF28", Offset = "0xB8BF28", VA = "0xB8BF28")]
	private void Start()
	{
	}

	[Token(Token = "0x60004EE")]
	[Address(RVA = "0xB8C39C", Offset = "0xB8C39C", VA = "0xB8C39C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60004EF")]
	[Address(RVA = "0xB8C86C", Offset = "0xB8C86C", VA = "0xB8C86C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60004F0")]
	[Address(RVA = "0xB8CBE4", Offset = "0xB8CBE4", VA = "0xB8CBE4")]
	public powerUpTrigger()
	{
	}
}
[Token(Token = "0x20000A1")]
public class progressManager : MonoBehaviour
{
	[Token(Token = "0x4000655")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject mainMenu;

	[Token(Token = "0x4000656")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private dataManager data;

	[Token(Token = "0x4000657")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private stateManager state;

	[Token(Token = "0x4000658")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private UIManager UI;

	[Token(Token = "0x4000659")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<int> tutorialCourseLst;

	[Token(Token = "0x400065A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<int> main1CourseLst;

	[Token(Token = "0x400065B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<int> main2CourseLst;

	[Token(Token = "0x400065C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<int> sideCourseLst;

	[Token(Token = "0x400065D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<int> miniCourseLst;

	[Token(Token = "0x400065E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool tutorialDone1;

	[Token(Token = "0x400065F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool tutorialDone2;

	[Token(Token = "0x4000660")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int gameProgressCount;

	[Token(Token = "0x4000661")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool unlockAll;

	[Token(Token = "0x4000662")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	private bool demoMod;

	[Token(Token = "0x60004F1")]
	[Address(RVA = "0xB8CC64", Offset = "0xB8CC64", VA = "0xB8CC64")]
	private void Start()
	{
	}

	[Token(Token = "0x60004F2")]
	[Address(RVA = "0xB8F968", Offset = "0xB8F968", VA = "0xB8F968")]
	public progressManager()
	{
	}
}
[Token(Token = "0x20000A2")]
public class pulseControl : MonoBehaviour
{
	[Token(Token = "0x4000663")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 endPos;

	[Token(Token = "0x4000664")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool showComboText;

	[Token(Token = "0x4000665")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speedBoost;

	[Token(Token = "0x4000666")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private courseRhythm cr;

	[Token(Token = "0x4000667")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private calcBodyPosition body;

	[Token(Token = "0x4000668")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private calcBodyMovement move;

	[Token(Token = "0x4000669")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private particleEffects effect;

	[Token(Token = "0x400066A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private courseBuilder course;

	[Token(Token = "0x400066B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private AudioSource hitSound;

	[Token(Token = "0x400066C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Transform sprite1Trans;

	[Token(Token = "0x400066D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Transform sprite2Trans;

	[Token(Token = "0x400066E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Color sprite1Color;

	[Token(Token = "0x400066F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float sprite1Alpha;

	[Token(Token = "0x4000670")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private SpriteRenderer sprite1;

	[Token(Token = "0x4000671")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 sprite2Scale;

	[Token(Token = "0x4000672")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private ParticleSystem dotEffect;

	[Token(Token = "0x4000673")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private TextMeshProUGUI comboText;

	[Token(Token = "0x4000674")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private BoxCollider col;

	[Token(Token = "0x4000675")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private bool arrived;

	[Token(Token = "0x60004F3")]
	[Address(RVA = "0xB8FB98", Offset = "0xB8FB98", VA = "0xB8FB98")]
	private void Start()
	{
	}

	[Token(Token = "0x60004F4")]
	[Address(RVA = "0xB9003C", Offset = "0xB9003C", VA = "0xB9003C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60004F5")]
	[Address(RVA = "0xB905AC", Offset = "0xB905AC", VA = "0xB905AC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0xB90800", Offset = "0xB90800", VA = "0xB90800")]
	public pulseControl()
	{
	}
}
[Token(Token = "0x20000A3")]
public class puntLocomotion : MonoBehaviour
{
	[Token(Token = "0x4000676")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 puntVector;

	[Token(Token = "0x4000677")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private calcBodyPosition body;

	[Token(Token = "0x4000678")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private stateManager state;

	[Token(Token = "0x4000679")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float leftAngVelocity;

	[Token(Token = "0x400067A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float rightAngVelocity;

	[Token(Token = "0x400067B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float scale;

	[Token(Token = "0x400067C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 samplePos;

	[Token(Token = "0x60004F7")]
	[Address(RVA = "0xB90818", Offset = "0xB90818", VA = "0xB90818")]
	private void Start()
	{
	}

	[Token(Token = "0x60004F8")]
	[Address(RVA = "0xB908AC", Offset = "0xB908AC", VA = "0xB908AC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60004F9")]
	[Address(RVA = "0xB90A48", Offset = "0xB90A48", VA = "0xB90A48")]
	public puntLocomotion()
	{
	}
}
[Token(Token = "0x20000A4")]
public class rhythmManager : MonoBehaviour
{
	[Token(Token = "0x400067D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool beatMatched;

	[Token(Token = "0x400067E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool carving;

	[Token(Token = "0x400067F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float matchFactor;

	[Token(Token = "0x4000680")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<float> waveForm;

	[Token(Token = "0x4000681")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<float> motionDelta;

	[Token(Token = "0x4000682")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float standardDeviation;

	[Token(Token = "0x4000683")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float corr;

	[Token(Token = "0x4000684")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<float> flowDeflateLimit;

	[Token(Token = "0x4000685")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private calcBodyMovement move;

	[Token(Token = "0x4000686")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private stateManager state;

	[Token(Token = "0x4000687")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private courseRhythm cr;

	[Token(Token = "0x4000688")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private UIManager ui;

	[Token(Token = "0x4000689")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private courseBuilder course;

	[Token(Token = "0x60004FA")]
	[Address(RVA = "0xB90ACC", Offset = "0xB90ACC", VA = "0xB90ACC")]
	private void Start()
	{
	}

	[Token(Token = "0x60004FB")]
	[Address(RVA = "0xB90BCC", Offset = "0xB90BCC", VA = "0xB90BCC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60004FC")]
	[Address(RVA = "0xB90E40", Offset = "0xB90E40", VA = "0xB90E40")]
	public rhythmManager()
	{
	}
}
[Token(Token = "0x20000A5")]
public class rhythmMarker : MonoBehaviour
{
	[Token(Token = "0x400068A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private stateManager state;

	[Token(Token = "0x400068B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private calcBodyMovement move;

	[Token(Token = "0x400068C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private courseRhythm cr;

	[Token(Token = "0x400068D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private rhythmManager rm;

	[Token(Token = "0x400068E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private courseBuilder cource;

	[Token(Token = "0x400068F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject beatMarker;

	[Token(Token = "0x4000690")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject beatMatch;

	[Token(Token = "0x4000691")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private ParticleSystem beatMatchEffect;

	[Token(Token = "0x4000692")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3 currentTaget;

	[Token(Token = "0x60004FD")]
	[Address(RVA = "0xB90F40", Offset = "0xB90F40", VA = "0xB90F40")]
	private void Start()
	{
	}

	[Token(Token = "0x60004FE")]
	[Address(RVA = "0xB910FC", Offset = "0xB910FC", VA = "0xB910FC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60004FF")]
	[Address(RVA = "0xB91328", Offset = "0xB91328", VA = "0xB91328")]
	public rhythmMarker()
	{
	}
}
[Token(Token = "0x20000A6")]
public class scoreBreakdownManager : MonoBehaviour
{
	[StructLayout(3)]
	[Token(Token = "0x2000182")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7FFFF8", Offset = "0x7FFFF8")]
	private struct <populateScoreBreakDown>d__13 : IAsyncStateMachine
	{
		[Token(Token = "0x4000C07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000C08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x4000C09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public scoreBreakdownManager <>4__this;

		[Token(Token = "0x4000C0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string playerName;

		[Token(Token = "0x4000C0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string course;

		[Token(Token = "0x4000C0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int difficulty;

		[Token(Token = "0x4000C0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int currentScore;

		[Token(Token = "0x4000C0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private scoreList <scoreData>5__2;

		[Token(Token = "0x4000C0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TaskAwaiter<scoreStatsObj> <>u__1;

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0xB91C5C", Offset = "0xB91C5C", VA = "0xB91C5C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0xB92738", Offset = "0xB92738", VA = "0xB92738", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000183")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800008", Offset = "0x800008")]
	private sealed class <animateData>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000C10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000C11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000C12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public scoreBreakdownManager <>4__this;

		[Token(Token = "0x4000C13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public scoreStatsObj scoreStatsData;

		[Token(Token = "0x4000C14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float scoreDelta;

		[Token(Token = "0x4000C15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float bestDelta;

		[Token(Token = "0x1700010D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A9E")]
			[Address(RVA = "0xB91BEC", Offset = "0xB91BEC", VA = "0xB91BEC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000AA0")]
			[Address(RVA = "0xB91C54", Offset = "0xB91C54", VA = "0xB91C54", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0xB9174C", Offset = "0xB9174C", VA = "0xB9174C")]
		[DebuggerHidden]
		public <animateData>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0xB917C8", Offset = "0xB917C8", VA = "0xB917C8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0xB917CC", Offset = "0xB917CC", VA = "0xB917CC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0xB91BF4", Offset = "0xB91BF4", VA = "0xB91BF4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000693")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Transform> barLst;

	[Token(Token = "0x4000694")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform scoreMark;

	[Token(Token = "0x4000695")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform bestMark;

	[Token(Token = "0x4000696")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI score;

	[Token(Token = "0x4000697")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI best;

	[Token(Token = "0x4000698")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI bin0;

	[Token(Token = "0x4000699")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI bin5;

	[Token(Token = "0x400069A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextMeshProUGUI bin9;

	[Token(Token = "0x400069B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject star;

	[Token(Token = "0x400069C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector2 scoreMarkerMaxMin;

	[Token(Token = "0x400069D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private dataManager data;

	[Token(Token = "0x400069E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private connectionManager connection;

	[Token(Token = "0x400069F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float aliveTime;

	[Token(Token = "0x6000500")]
	[Address(RVA = "0xB91330", Offset = "0xB91330", VA = "0xB91330")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x802B50", Offset = "0x802B50")]
	public void populateScoreBreakDown(string playerName, int currentScore, string course, int difficulty)
	{
	}

	[Token(Token = "0x6000501")]
	[Address(RVA = "0xB91410", Offset = "0xB91410", VA = "0xB91410")]
	public void resetGraph()
	{
	}

	[Token(Token = "0x6000502")]
	[Address(RVA = "0xB916BC", Offset = "0xB916BC", VA = "0xB916BC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x802BB4", Offset = "0x802BB4")]
	private IEnumerator animateData(scoreStatsObj scoreStatsData, float scoreDelta, float bestDelta)
	{
		return null;
	}

	[Token(Token = "0x6000503")]
	[Address(RVA = "0xB91778", Offset = "0xB91778", VA = "0xB91778")]
	public scoreBreakdownManager()
	{
	}
}
[Token(Token = "0x20000A7")]
public class shakeImage : MonoBehaviour
{
	[Token(Token = "0x40006A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 initScale;

	[Token(Token = "0x6000504")]
	[Address(RVA = "0xB9354C", Offset = "0xB9354C", VA = "0xB9354C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000505")]
	[Address(RVA = "0xB93588", Offset = "0xB93588", VA = "0xB93588")]
	private void Update()
	{
	}

	[Token(Token = "0x6000506")]
	[Address(RVA = "0xB93738", Offset = "0xB93738", VA = "0xB93738")]
	public shakeImage()
	{
	}
}
[Token(Token = "0x20000A8")]
public class shardControl : MonoBehaviour
{
	[Token(Token = "0x40006A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 endPos;

	[Token(Token = "0x40006A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float aliveTimer;

	[Token(Token = "0x40006A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float endDist;

	[Token(Token = "0x40006A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool hit;

	[Token(Token = "0x40006A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject shard;

	[Token(Token = "0x40006A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private AudioSource hitSound;

	[Token(Token = "0x40006A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private CapsuleCollider capsuleCol;

	[Token(Token = "0x40006A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject hitFlash;

	[Token(Token = "0x40006A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private calcBodyMovement move;

	[Token(Token = "0x40006AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private stateManager state;

	[Token(Token = "0x40006AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private particleEffects effect;

	[Token(Token = "0x40006AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private courseBuilder course;

	[Token(Token = "0x6000507")]
	[Address(RVA = "0xB93740", Offset = "0xB93740", VA = "0xB93740")]
	private void Start()
	{
	}

	[Token(Token = "0x6000508")]
	[Address(RVA = "0xB93904", Offset = "0xB93904", VA = "0xB93904")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000509")]
	[Address(RVA = "0xB93D54", Offset = "0xB93D54", VA = "0xB93D54")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600050A")]
	[Address(RVA = "0xB9404C", Offset = "0xB9404C", VA = "0xB9404C")]
	public shardControl()
	{
	}
}
[Token(Token = "0x20000A9")]
public class skiJumpManager : MonoBehaviour
{
	[Token(Token = "0x40006AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private stateManager state;

	[Token(Token = "0x40006AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private calcBodyMovement move;

	[Token(Token = "0x40006AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private TextMeshProUGUI jumpLen;

	[Token(Token = "0x40006B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private LineRenderer pathLine;

	[Token(Token = "0x40006B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool landingSet;

	[Token(Token = "0x600050B")]
	[Address(RVA = "0xB94A0C", Offset = "0xB94A0C", VA = "0xB94A0C")]
	private void Start()
	{
	}

	[Token(Token = "0x600050C")]
	[Address(RVA = "0xB94B04", Offset = "0xB94B04", VA = "0xB94B04")]
	private void Update()
	{
	}

	[Token(Token = "0x600050D")]
	[Address(RVA = "0xB94B3C", Offset = "0xB94B3C", VA = "0xB94B3C")]
	private void jumpLanding()
	{
	}

	[Token(Token = "0x600050E")]
	[Address(RVA = "0xB94C7C", Offset = "0xB94C7C", VA = "0xB94C7C")]
	public skiJumpManager()
	{
	}
}
[Token(Token = "0x20000AA")]
public class skiJumpTrigger : MonoBehaviour
{
	[Token(Token = "0x40006B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private calcBodyMovement move;

	[Token(Token = "0x40006B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource sfx;

	[Token(Token = "0x600050F")]
	[Address(RVA = "0xB94C84", Offset = "0xB94C84", VA = "0xB94C84")]
	private void Start()
	{
	}

	[Token(Token = "0x6000510")]
	[Address(RVA = "0xB94D0C", Offset = "0xB94D0C", VA = "0xB94D0C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000511")]
	[Address(RVA = "0xB94DE8", Offset = "0xB94DE8", VA = "0xB94DE8")]
	public skiJumpTrigger()
	{
	}
}
[Token(Token = "0x20000AB")]
public class skiManager : MonoBehaviour
{
	[Token(Token = "0x2000184")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800018", Offset = "0x800018")]
	private sealed class <poolSnowBall>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000C16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000C17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000C18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float timeLimit;

		[Token(Token = "0x4000C19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject snowball;

		[Token(Token = "0x4000C1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public skiManager <>4__this;

		[Token(Token = "0x4000C1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <timer>5__2;

		[Token(Token = "0x1700010F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0xB9B0A8", Offset = "0xB9B0A8", VA = "0xB9B0A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000110")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000AA6")]
			[Address(RVA = "0xB9B110", Offset = "0xB9B110", VA = "0xB9B110", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0xB9AE54", Offset = "0xB9AE54", VA = "0xB9AE54")]
		[DebuggerHidden]
		public <poolSnowBall>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0xB9AFC0", Offset = "0xB9AFC0", VA = "0xB9AFC0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0xB9AFC4", Offset = "0xB9AFC4", VA = "0xB9AFC4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0xB9B0B0", Offset = "0xB9B0B0", VA = "0xB9B0B0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40006B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject snowBall;

	[Token(Token = "0x40006B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool stationary;

	[Token(Token = "0x40006B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private calcBodyMovement move;

	[Token(Token = "0x40006B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private calcBodyPosition body;

	[Token(Token = "0x40006B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private slopeLocomotion slope;

	[Token(Token = "0x40006B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private stateManager state;

	[Token(Token = "0x40006BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private courseRhythm cr;

	[Token(Token = "0x40006BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private particleEffects effects;

	[Token(Token = "0x40006BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3 skiForward;

	[Token(Token = "0x40006BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector3 skiPosition;

	[Token(Token = "0x40006BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float skiSlopeDistance;

	[Token(Token = "0x40006BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float turnAngleLerp;

	[Token(Token = "0x40006C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float turnPushOut;

	[Token(Token = "0x40006C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private Quaternion vertRot;

	[Token(Token = "0x40006C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private Vector3 skiNormal;

	[Token(Token = "0x40006C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float separation;

	[Token(Token = "0x40006C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private float separationLastValue;

	[Token(Token = "0x40006C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float separationFac;

	[Token(Token = "0x40006C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private ParticleSystem sideSnowEffect;

	[Token(Token = "0x40006C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private ParticleSystem groundSnowEffect;

	[Token(Token = "0x40006C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private float rightSlopeDist;

	[Token(Token = "0x40006C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private float leftSlopeDist;

	[Token(Token = "0x40006CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private int maxSnowBallAmount;

	[Token(Token = "0x40006CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private float jumpPosStartTime;

	[Token(Token = "0x40006CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private float stopTurnFactor;

	[Token(Token = "0x40006CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float stopTurnLimit;

	[Token(Token = "0x40006CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private float eyeSkiDirectionAngle;

	[Token(Token = "0x40006CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private int vertAlignBoost;

	[Token(Token = "0x40006D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private float telemarkFac;

	[Token(Token = "0x40006D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private List<GameObject> snowBallPool;

	[Token(Token = "0x6000512")]
	[Address(RVA = "0xB95D44", Offset = "0xB95D44", VA = "0xB95D44")]
	private void Start()
	{
	}

	[Token(Token = "0x6000513")]
	[Address(RVA = "0xB96680", Offset = "0xB96680", VA = "0xB96680")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000514")]
	[Address(RVA = "0xB96784", Offset = "0xB96784", VA = "0xB96784")]
	private void Update()
	{
	}

	[Token(Token = "0x6000515")]
	[Address(RVA = "0xB9ADC8", Offset = "0xB9ADC8", VA = "0xB9ADC8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x802C18", Offset = "0x802C18")]
	private IEnumerator poolSnowBall(GameObject snowball, float timeLimit)
	{
		return null;
	}

	[Token(Token = "0x6000516")]
	[Address(RVA = "0xB9AE80", Offset = "0xB9AE80", VA = "0xB9AE80")]
	public skiManager()
	{
	}
}
[Token(Token = "0x20000AC")]
public class slipperySurface : MonoBehaviour
{
	[Token(Token = "0x40006D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private calcBodyMovement move;

	[Token(Token = "0x6000517")]
	[Address(RVA = "0xB9B118", Offset = "0xB9B118", VA = "0xB9B118")]
	private void Start()
	{
	}

	[Token(Token = "0x6000518")]
	[Address(RVA = "0xB9B188", Offset = "0xB9B188", VA = "0xB9B188")]
	private void OnControllerColliderHit(ControllerColliderHit hit)
	{
	}

	[Token(Token = "0x6000519")]
	[Address(RVA = "0xB9B2A8", Offset = "0xB9B2A8", VA = "0xB9B2A8")]
	public slipperySurface()
	{
	}
}
[Token(Token = "0x20000AD")]
public class slopeLocomotion : MonoBehaviour
{
	[Token(Token = "0x40006D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float slopeGradient;

	[Token(Token = "0x40006D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float hardSlopeGradient;

	[Token(Token = "0x40006D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float slopeGradientMulti;

	[Token(Token = "0x40006D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float slopeGradientDelta;

	[Token(Token = "0x40006D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float slopeDistance;

	[Token(Token = "0x40006D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float slopeVelcoity;

	[Token(Token = "0x40006D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float fallLineDist;

	[Token(Token = "0x40006DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float fallLineDistDelta;

	[Token(Token = "0x40006DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3 fallLine;

	[Token(Token = "0x40006DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector3 slopeNormal;

	[Token(Token = "0x40006DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool slopeContact;

	[Token(Token = "0x40006DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float slopeContactTimer;

	[Token(Token = "0x40006DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<float> slopeGradientLst;

	[Token(Token = "0x40006E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private calcBodyPosition body;

	[Token(Token = "0x40006E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private calcBodyMovement move;

	[Token(Token = "0x40006E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private stateManager state;

	[Token(Token = "0x40006E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private UIManager UI;

	[Token(Token = "0x40006E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private int layerMask;

	[Token(Token = "0x40006E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private float scale;

	[Token(Token = "0x40006E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float contactTimer;

	[Token(Token = "0x40006E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<float> fallLineDistLst;

	[Token(Token = "0x40006E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<float> slopeGradientMultiLst;

	[Token(Token = "0x40006E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float slopeGradientMultiTarget;

	[Token(Token = "0x600051A")]
	[Address(RVA = "0xB9B2B0", Offset = "0xB9B2B0", VA = "0xB9B2B0")]
	private void Start()
	{
	}

	[Token(Token = "0x600051B")]
	[Address(RVA = "0xB9B490", Offset = "0xB9B490", VA = "0xB9B490")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600051C")]
	[Address(RVA = "0xB9BCB0", Offset = "0xB9BCB0", VA = "0xB9BCB0")]
	public slopeLocomotion()
	{
	}
}
[Token(Token = "0x20000AE")]
public class speedPadHit : MonoBehaviour
{
	[Token(Token = "0x40006EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speedBoost;

	[Token(Token = "0x40006EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private calcBodyMovement move;

	[Token(Token = "0x40006EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private courseRhythm cr;

	[Token(Token = "0x40006ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ParticleSystem beatEffect;

	[Token(Token = "0x600051D")]
	[Address(RVA = "0xB9BE08", Offset = "0xB9BE08", VA = "0xB9BE08")]
	private void Start()
	{
	}

	[Token(Token = "0x600051E")]
	[Address(RVA = "0xB9BED8", Offset = "0xB9BED8", VA = "0xB9BED8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600051F")]
	[Address(RVA = "0xB9BF14", Offset = "0xB9BF14", VA = "0xB9BF14")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000520")]
	[Address(RVA = "0xB9C044", Offset = "0xB9C044", VA = "0xB9C044")]
	public speedPadHit()
	{
	}
}
[Token(Token = "0x20000AF")]
[ExecuteInEditMode]
public class speedPadPlacementEditor : MonoBehaviour
{
	[Token(Token = "0x40006EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject speedPadPrefab;

	[Token(Token = "0x40006EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool placeSpeedPad;

	[Token(Token = "0x6000521")]
	[Address(RVA = "0xB9C054", Offset = "0xB9C054", VA = "0xB9C054")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000522")]
	[Address(RVA = "0xB9C3BC", Offset = "0xB9C3BC", VA = "0xB9C3BC")]
	public speedPadPlacementEditor()
	{
	}
}
[Token(Token = "0x20000B0")]
public class stateManager : MonoBehaviour
{
	[Token(Token = "0x2000185")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800028", Offset = "0x800028")]
	private sealed class <LoadYourAsyncSceneWithFade>d__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000C1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000C1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000C1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public stateManager <>4__this;

		[Token(Token = "0x4000C1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string sceneName;

		[Token(Token = "0x17000111")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000AAA")]
			[Address(RVA = "0xB9E2EC", Offset = "0xB9E2EC", VA = "0xB9E2EC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000112")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0xB9E354", Offset = "0xB9E354", VA = "0xB9E354", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0xB9D210", Offset = "0xB9D210", VA = "0xB9D210")]
		[DebuggerHidden]
		public <LoadYourAsyncSceneWithFade>d__45(int <>1__state)
		{
		}

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0xB9E1FC", Offset = "0xB9E1FC", VA = "0xB9E1FC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0xB9E200", Offset = "0xB9E200", VA = "0xB9E200", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0xB9E2F4", Offset = "0xB9E2F4", VA = "0xB9E2F4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000186")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800038", Offset = "0x800038")]
	private sealed class <LoadYourAsyncScene>d__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000C20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000C21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000C22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string sceneName;

		[Token(Token = "0x4000C23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AsyncOperation <asyncLoad>5__2;

		[Token(Token = "0x17000113")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0xB9E18C", Offset = "0xB9E18C", VA = "0xB9E18C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000114")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0xB9E1F4", Offset = "0xB9E1F4", VA = "0xB9E1F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0xB9D2E4", Offset = "0xB9D2E4", VA = "0xB9D2E4")]
		[DebuggerHidden]
		public <LoadYourAsyncScene>d__47(int <>1__state)
		{
		}

		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0xB9E0C0", Offset = "0xB9E0C0", VA = "0xB9E0C0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0xB9E0C4", Offset = "0xB9E0C4", VA = "0xB9E0C4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0xB9E194", Offset = "0xB9E194", VA = "0xB9E194", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40006F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800E18", Offset = "0x800E18")]
	private static stateManager <Instance>k__BackingField;

	[Token(Token = "0x40006F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float raceTimer;

	[Token(Token = "0x40006F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float confinementDist;

	[Token(Token = "0x40006F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isPaused;

	[Token(Token = "0x40006F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool inFocus;

	[Token(Token = "0x40006F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	public bool loading;

	[Token(Token = "0x40006F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
	public bool gameOver;

	[Token(Token = "0x40006F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool stopingState;

	[Token(Token = "0x40006F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool courseCleared;

	[Token(Token = "0x40006F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	public bool inRace;

	[Token(Token = "0x40006FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
	public bool doRhythm;

	[Token(Token = "0x40006FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool generatingCourse;

	[Token(Token = "0x40006FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool canFail;

	[Token(Token = "0x40006FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool forceFreeRide;

	[Token(Token = "0x40006FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	public bool rewardItem;

	[Token(Token = "0x40006FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool levelIsActive;

	[Token(Token = "0x4000700")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string playerName;

	[Token(Token = "0x4000701")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string currentScene;

	[Token(Token = "0x4000702")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int powerUpCount;

	[Token(Token = "0x4000703")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int score;

	[Token(Token = "0x4000704")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string runId;

	[Token(Token = "0x4000705")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string dateTime;

	[Token(Token = "0x4000706")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float deviceTweakFactor1;

	[Token(Token = "0x4000707")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float deviceTweakFactor2;

	[Token(Token = "0x4000708")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string sceneLoading;

	[Token(Token = "0x4000709")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public settingsObject settings;

	[Token(Token = "0x400070A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int hmdType;

	[Token(Token = "0x400070B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private calcBodyPosition body;

	[Token(Token = "0x400070C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private calcBodyMovement move;

	[Token(Token = "0x400070D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private courseBuilder course;

	[Token(Token = "0x400070E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private damageManager damage;

	[Token(Token = "0x400070F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private UIManager UI;

	[Token(Token = "0x4000710")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private dataManager data;

	[Token(Token = "0x4000711")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private connectionManager connection;

	[Token(Token = "0x4000712")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private ghostManager ghost;

	[Token(Token = "0x4000713")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private slopeLocomotion slope;

	[Token(Token = "0x4000714")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private int layerMaskConfinement;

	[Token(Token = "0x4000715")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Renderer confinementRender;

	[Token(Token = "0x4000716")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private float edgeColTimer;

	[Token(Token = "0x1700004C")]
	public static stateManager Instance
	{
		[Token(Token = "0x6000523")]
		[Address(RVA = "0xB9C3C4", Offset = "0xB9C3C4", VA = "0xB9C3C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x802C7C", Offset = "0x802C7C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000524")]
		[Address(RVA = "0xB9C414", Offset = "0xB9C414", VA = "0xB9C414")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x802C8C", Offset = "0x802C8C")]
		private set
		{
		}
	}

	[Token(Token = "0x6000525")]
	[Address(RVA = "0xB9C468", Offset = "0xB9C468", VA = "0xB9C468")]
	public void updatePlayerData()
	{
	}

	[Token(Token = "0x6000526")]
	[Address(RVA = "0xB9C59C", Offset = "0xB9C59C", VA = "0xB9C59C")]
	public void populateEndMenu(int mode)
	{
	}

	[Token(Token = "0x6000527")]
	[Address(RVA = "0xB9D15C", Offset = "0xB9D15C", VA = "0xB9D15C")]
	public void LoadSceneWithFade(string sceneName)
	{
	}

	[Token(Token = "0x6000528")]
	[Address(RVA = "0xB9D194", Offset = "0xB9D194", VA = "0xB9D194")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x802C9C", Offset = "0x802C9C")]
	private IEnumerator LoadYourAsyncSceneWithFade(string sceneName)
	{
		return null;
	}

	[Token(Token = "0x6000529")]
	[Address(RVA = "0xB9D23C", Offset = "0xB9D23C", VA = "0xB9D23C")]
	public void LoadScene(string sceneName)
	{
	}

	[Token(Token = "0x600052A")]
	[Address(RVA = "0xB9D274", Offset = "0xB9D274", VA = "0xB9D274")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x802D00", Offset = "0x802D00")]
	private IEnumerator LoadYourAsyncScene(string sceneName)
	{
		return null;
	}

	[Token(Token = "0x600052B")]
	[Address(RVA = "0xB9D310", Offset = "0xB9D310", VA = "0xB9D310")]
	private void Awake()
	{
	}

	[Token(Token = "0x600052C")]
	[Address(RVA = "0xB9D7F8", Offset = "0xB9D7F8", VA = "0xB9D7F8")]
	private void Start()
	{
	}

	[Token(Token = "0x600052D")]
	[Address(RVA = "0xB9DAF4", Offset = "0xB9DAF4", VA = "0xB9DAF4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600052E")]
	[Address(RVA = "0xB9DC18", Offset = "0xB9DC18", VA = "0xB9DC18")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600052F")]
	[Address(RVA = "0xB9DD3C", Offset = "0xB9DD3C", VA = "0xB9DD3C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000530")]
	[Address(RVA = "0xB9DE4C", Offset = "0xB9DE4C", VA = "0xB9DE4C")]
	public void focusGained()
	{
	}

	[Token(Token = "0x6000531")]
	[Address(RVA = "0xB9DF88", Offset = "0xB9DF88", VA = "0xB9DF88")]
	public void focusLost()
	{
	}

	[Token(Token = "0x6000532")]
	[Address(RVA = "0xB9E028", Offset = "0xB9E028", VA = "0xB9E028")]
	public stateManager()
	{
	}
}
[Token(Token = "0x20000B1")]
public class stickManager : MonoBehaviour
{
	[Token(Token = "0x4000717")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject snowBall;

	[Token(Token = "0x4000718")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool setSticks;

	[Token(Token = "0x4000719")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private stateManager state;

	[Token(Token = "0x400071A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private calcBodyPosition body;

	[Token(Token = "0x400071B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private calcBodyMovement move;

	[Token(Token = "0x400071C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private particleEffects effect;

	[Token(Token = "0x400071D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Transform rightAnchor;

	[Token(Token = "0x400071E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Transform leftAnchor;

	[Token(Token = "0x400071F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Transform pointAnchor;

	[Token(Token = "0x4000720")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Transform rightStick;

	[Token(Token = "0x4000721")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Transform leftStick;

	[Token(Token = "0x4000722")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Transform pointStick;

	[Token(Token = "0x4000723")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 rightStuckPos;

	[Token(Token = "0x4000724")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Vector3 leftStuckPos;

	[Token(Token = "0x4000725")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 pointStuckPos;

	[Token(Token = "0x4000726")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private float stickLength;

	[Token(Token = "0x4000727")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float lerpSpeed;

	[Token(Token = "0x6000533")]
	[Address(RVA = "0xB9E35C", Offset = "0xB9E35C", VA = "0xB9E35C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000534")]
	[Address(RVA = "0xB9E4B0", Offset = "0xB9E4B0", VA = "0xB9E4B0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000535")]
	[Address(RVA = "0xB9F830", Offset = "0xB9F830", VA = "0xB9F830")]
	public stickManager()
	{
	}
}
[Token(Token = "0x20000B2")]
public class strapManager : MonoBehaviour
{
	[Token(Token = "0x4000728")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private calcBodyMovement move;

	[Token(Token = "0x4000729")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform pole;

	[Token(Token = "0x400072A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform bone;

	[Token(Token = "0x400072B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 polePos;

	[Token(Token = "0x400072C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 bonePos;

	[Token(Token = "0x6000536")]
	[Address(RVA = "0x147BC50", Offset = "0x147BC50", VA = "0x147BC50")]
	private void Start()
	{
	}

	[Token(Token = "0x6000537")]
	[Address(RVA = "0x147BD5C", Offset = "0x147BD5C", VA = "0x147BD5C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000538")]
	[Address(RVA = "0x147BF38", Offset = "0x147BF38", VA = "0x147BF38")]
	public strapManager()
	{
	}
}
[Token(Token = "0x20000B3")]
public class syncedRaceMenu : MonoBehaviour
{
	[Token(Token = "0x400072D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject createButton;

	[Token(Token = "0x400072E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image startButton;

	[Token(Token = "0x400072F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TextMeshProUGUI startText;

	[Token(Token = "0x4000730")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private BoxCollider startCol;

	[Token(Token = "0x4000731")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject acceptButton;

	[Token(Token = "0x4000732")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject cancelButton;

	[Token(Token = "0x4000733")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject bg1;

	[Token(Token = "0x4000734")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject bg2;

	[Token(Token = "0x4000735")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private TextMeshProUGUI raceInfoText;

	[Token(Token = "0x4000736")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color active;

	[Token(Token = "0x4000737")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Color inactive;

	[Token(Token = "0x4000738")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private multiplayerManager multiplayer;

	[Token(Token = "0x6000539")]
	[Address(RVA = "0x147BF40", Offset = "0x147BF40", VA = "0x147BF40")]
	private void Start()
	{
	}

	[Token(Token = "0x600053A")]
	[Address(RVA = "0x147BFD8", Offset = "0x147BFD8", VA = "0x147BFD8")]
	private void Update()
	{
	}

	[Token(Token = "0x600053B")]
	[Address(RVA = "0x147C32C", Offset = "0x147C32C", VA = "0x147C32C")]
	public syncedRaceMenu()
	{
	}
}
[Token(Token = "0x20000B4")]
public class syncedRaceScore : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000187")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800048", Offset = "0x800048")]
	private sealed class <>c
	{
		[Token(Token = "0x4000C24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000C25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<KeyValuePair<string, int>, int> <>9__4_0;

		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x147C9C4", Offset = "0x147C9C4", VA = "0x147C9C4")]
		public <>c()
		{
		}

		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x147C9CC", Offset = "0x147C9CC", VA = "0x147C9CC")]
		internal int <Update>b__4_0(KeyValuePair<string, int> entry)
		{
			return default(int);
		}
	}

	[Token(Token = "0x4000739")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Dictionary<string, int> scores;

	[Token(Token = "0x400073A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<TextMeshProUGUI> playerNamesTexts;

	[Token(Token = "0x400073B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private multiplayerManager multiplayer;

	[Token(Token = "0x600053C")]
	[Address(RVA = "0x147C334", Offset = "0x147C334", VA = "0x147C334")]
	private void Start()
	{
	}

	[Token(Token = "0x600053D")]
	[Address(RVA = "0x147C3A4", Offset = "0x147C3A4", VA = "0x147C3A4")]
	private void Update()
	{
	}

	[Token(Token = "0x600053E")]
	[Address(RVA = "0x147C8F0", Offset = "0x147C8F0", VA = "0x147C8F0")]
	public syncedRaceScore()
	{
	}
}
[Token(Token = "0x20000B5")]
public class toggleEffects : MonoBehaviour
{
	[Token(Token = "0x400073C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool toggleSnowEffects;

	[Token(Token = "0x400073D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool toggleFly;

	[Token(Token = "0x400073E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<ParticleSystem> emitEffects;

	[Token(Token = "0x400073F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<int> emitNumber;

	[Token(Token = "0x4000740")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Renderer> activateRenderLst;

	[Token(Token = "0x4000741")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<Renderer> deactivateRenderLst;

	[Token(Token = "0x4000742")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<GameObject> activateObjLst;

	[Token(Token = "0x4000743")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<GameObject> deactivateObjLst;

	[Token(Token = "0x4000744")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private particleEffects effects;

	[Token(Token = "0x4000745")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private calcBodyMovement move;

	[Token(Token = "0x4000746")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private stateManager state;

	[Token(Token = "0x600053F")]
	[Address(RVA = "0x147CA18", Offset = "0x147CA18", VA = "0x147CA18")]
	private void Start()
	{
	}

	[Token(Token = "0x6000540")]
	[Address(RVA = "0x147CC48", Offset = "0x147CC48", VA = "0x147CC48")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000541")]
	[Address(RVA = "0x147D0B4", Offset = "0x147D0B4", VA = "0x147D0B4")]
	public toggleEffects()
	{
	}
}
[Token(Token = "0x20000B6")]
public class tuneParamTrigger : MonoBehaviour
{
	[Token(Token = "0x4000747")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private courseRhythm cr;

	[Token(Token = "0x4000748")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private calcBodyPosition body;

	[Token(Token = "0x4000749")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private calcBodyMovement move;

	[Token(Token = "0x400074A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private dataManager data;

	[Token(Token = "0x400074B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private stateManager state;

	[Token(Token = "0x400074C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private connectionManager connection;

	[Token(Token = "0x400074D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private slopeLocomotion slope;

	[Token(Token = "0x6000542")]
	[Address(RVA = "0x147D1F4", Offset = "0x147D1F4", VA = "0x147D1F4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000543")]
	[Address(RVA = "0x147D33C", Offset = "0x147D33C", VA = "0x147D33C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000544")]
	[Address(RVA = "0x147D558", Offset = "0x147D558", VA = "0x147D558")]
	public tuneParamTrigger()
	{
	}
}
[Token(Token = "0x20000B7")]
public class tutorialJumpTrigger : MonoBehaviour
{
	[Token(Token = "0x400074E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int type;

	[Token(Token = "0x400074F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private tutorialManager tutorial;

	[Token(Token = "0x4000750")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private particleEffects effects;

	[Token(Token = "0x4000751")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioSource hurtSound;

	[Token(Token = "0x6000545")]
	[Address(RVA = "0x147D560", Offset = "0x147D560", VA = "0x147D560")]
	private void Start()
	{
	}

	[Token(Token = "0x6000546")]
	[Address(RVA = "0x147D62C", Offset = "0x147D62C", VA = "0x147D62C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000547")]
	[Address(RVA = "0x147D764", Offset = "0x147D764", VA = "0x147D764")]
	public tutorialJumpTrigger()
	{
	}
}
[Token(Token = "0x20000B8")]
public class tutorialManager : MonoBehaviour
{
	[Token(Token = "0x4000752")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<GameObject> sectionLst;

	[Token(Token = "0x4000753")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject worldBackDrop;

	[Token(Token = "0x4000754")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool scrollWorld;

	[Token(Token = "0x4000755")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int currentSection;

	[Token(Token = "0x4000756")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int currentSubSectionIndex;

	[Token(Token = "0x4000757")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int sectionCount;

	[Token(Token = "0x4000758")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int prevSectionCount;

	[Token(Token = "0x4000759")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int eventCount;

	[Token(Token = "0x400075A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float sectionTimer;

	[Token(Token = "0x400075B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AudioSource cowbell;

	[Token(Token = "0x400075C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AudioSource tagChime;

	[Token(Token = "0x400075D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<AudioClip> infoVoice1Lst;

	[Token(Token = "0x400075E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<AudioClip> infoVoice2Lst;

	[Token(Token = "0x400075F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Vector3 spawnVector;

	[Token(Token = "0x4000760")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject spawnSection;

	[Token(Token = "0x4000761")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float instructorAirFactor;

	[Token(Token = "0x4000762")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public ghostController ghost;

	[Token(Token = "0x4000763")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject instructorBillboard;

	[Token(Token = "0x4000764")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float matchTimer;

	[Token(Token = "0x4000765")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public bool spawnInstructorBillboardHunch;

	[Token(Token = "0x4000766")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
	public bool spawnInstructorBillboardJump;

	[Token(Token = "0x4000767")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Vector3 tutorialInstructorAnchorTarget;

	[Token(Token = "0x4000768")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public List<Vector3> tutorialGateLst;

	[Token(Token = "0x4000769")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public bool dropZigZagGates;

	[Token(Token = "0x400076A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
	public bool transitionToCourse;

	[Token(Token = "0x400076B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public AudioSource infoVoice1;

	[Token(Token = "0x400076C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public AudioSource infoVoice2;

	[Token(Token = "0x400076D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public AudioSource infoVoiceGreat;

	[Token(Token = "0x400076E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public AudioSource infoVoiceLetsGo;

	[Token(Token = "0x400076F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public bool infoVoice1Played;

	[Token(Token = "0x4000770")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
	public bool infoVoice2Played;

	[Token(Token = "0x4000771")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE2")]
	public bool matched;

	[Token(Token = "0x4000772")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private calcBodyMovement move;

	[Token(Token = "0x4000773")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private calcBodyPosition body;

	[Token(Token = "0x4000774")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private stateManager state;

	[Token(Token = "0x4000775")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private rhythmManager rm;

	[Token(Token = "0x4000776")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private courseRhythm cr;

	[Token(Token = "0x4000777")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private UIManager UI;

	[Token(Token = "0x4000778")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private dataManager data;

	[Token(Token = "0x4000779")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private slopeLocomotion slope;

	[Token(Token = "0x400077A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private particleEffects effects;

	[Token(Token = "0x400077B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private courseBuilder course;

	[Token(Token = "0x400077C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private puntLocomotion punt;

	[Token(Token = "0x400077D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private Vector3 bodyPosDelta;

	[Token(Token = "0x400077E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private GameObject tutorialInstructorAnchor;

	[Token(Token = "0x400077F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private GameObject tutorialInstructorAnchorLocal;

	[Token(Token = "0x4000780")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private GameObject instructorBillboardInstance;

	[Token(Token = "0x4000781")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private bool drawLine;

	[Token(Token = "0x4000782")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private LineRenderer pathLine;

	[Token(Token = "0x4000783")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private List<Vector3> pathLinePosLst;

	[Token(Token = "0x4000784")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private Gradient pathLineGradient;

	[Token(Token = "0x4000785")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private GradientColorKey[] colorKey;

	[Token(Token = "0x4000786")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private GradientAlphaKey[] alphaKey;

	[Token(Token = "0x4000787")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private List<Transform> arrowLst;

	[Token(Token = "0x4000788")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private List<Transform> arrowMatchLst;

	[Token(Token = "0x4000789")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private List<float> arrowOffset;

	[Token(Token = "0x400078A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private GameObject stationaryArea;

	[Token(Token = "0x400078B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private GameObject taskMenuUI;

	[Token(Token = "0x400078C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private float periodicTimer;

	[Token(Token = "0x400078D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
	private float generalTimer;

	[Token(Token = "0x400078E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private float pathTurnFactor;

	[Token(Token = "0x400078F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
	private int slalomFactor;

	[Token(Token = "0x4000790")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private int verticalMotionConst;

	[Token(Token = "0x4000791")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
	private int lastPlayedVoiceSection;

	[Token(Token = "0x6000548")]
	[Address(RVA = "0x147D76C", Offset = "0x147D76C", VA = "0x147D76C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000549")]
	[Address(RVA = "0x147DA10", Offset = "0x147DA10", VA = "0x147DA10")]
	private void Start()
	{
	}

	[Token(Token = "0x600054A")]
	[Address(RVA = "0x147DF4C", Offset = "0x147DF4C", VA = "0x147DF4C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600054B")]
	[Address(RVA = "0x1480C50", Offset = "0x1480C50", VA = "0x1480C50")]
	private void tutorialAdvanced()
	{
	}

	[Token(Token = "0x600054C")]
	[Address(RVA = "0x147E54C", Offset = "0x147E54C", VA = "0x147E54C")]
	private void tutorialBasicMotion()
	{
	}

	[Token(Token = "0x600054D")]
	[Address(RVA = "0x14824B8", Offset = "0x14824B8", VA = "0x14824B8")]
	public void nextSubSection(bool newSection = false)
	{
	}

	[Token(Token = "0x600054E")]
	[Address(RVA = "0x147DEDC", Offset = "0x147DEDC", VA = "0x147DEDC")]
	public GameObject getSectionPrefab()
	{
		return null;
	}

	[Token(Token = "0x600054F")]
	[Address(RVA = "0x1482350", Offset = "0x1482350", VA = "0x1482350")]
	private void playVoiceInfo()
	{
	}

	[Token(Token = "0x6000550")]
	[Address(RVA = "0x148251C", Offset = "0x148251C", VA = "0x148251C")]
	public tutorialManager()
	{
	}
}
[Token(Token = "0x20000B9")]
public class unParent : MonoBehaviour
{
	[Token(Token = "0x6000551")]
	[Address(RVA = "0x148276C", Offset = "0x148276C", VA = "0x148276C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000552")]
	[Address(RVA = "0x1482794", Offset = "0x1482794", VA = "0x1482794")]
	public unParent()
	{
	}
}
[Token(Token = "0x20000BA")]
public class unloadSection : MonoBehaviour
{
	[Token(Token = "0x4000792")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private tutorialManager tutorial;

	[Token(Token = "0x4000793")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool destory;

	[Token(Token = "0x4000794")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float timer;

	[Token(Token = "0x6000553")]
	[Address(RVA = "0x148279C", Offset = "0x148279C", VA = "0x148279C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000554")]
	[Address(RVA = "0x148280C", Offset = "0x148280C", VA = "0x148280C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000555")]
	[Address(RVA = "0x14828E4", Offset = "0x14828E4", VA = "0x14828E4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000556")]
	[Address(RVA = "0x14829AC", Offset = "0x14829AC", VA = "0x14829AC")]
	public unloadSection()
	{
	}
}
[Token(Token = "0x20000BB")]
public class videoCameraControl : MonoBehaviour
{
	[Token(Token = "0x4000795")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform lookAtTarget;

	[Token(Token = "0x4000796")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float speedUp;

	[Token(Token = "0x4000797")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float speedForward;

	[Token(Token = "0x4000798")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int delay;

	[Token(Token = "0x6000557")]
	[Address(RVA = "0x14829B4", Offset = "0x14829B4", VA = "0x14829B4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000558")]
	[Address(RVA = "0x14829E8", Offset = "0x14829E8", VA = "0x14829E8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000559")]
	[Address(RVA = "0x1482C04", Offset = "0x1482C04", VA = "0x1482C04")]
	public videoCameraControl()
	{
	}
}
[Token(Token = "0x20000BC")]
public class walkieTalkieManager : MonoBehaviour
{
	[Token(Token = "0x4000799")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private stateManager state;

	[Token(Token = "0x400079A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private calcBodyPosition body;

	[Token(Token = "0x400079B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private particleEffects effect;

	[Token(Token = "0x400079C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform markerAnchor;

	[Token(Token = "0x400079D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SpriteRenderer talkie;

	[Token(Token = "0x400079E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private localizedText subtitleTxt;

	[Token(Token = "0x400079F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AudioSource audioSource1;

	[Token(Token = "0x40007A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AudioSource audioSource2;

	[Token(Token = "0x40007A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float updateStep;

	[Token(Token = "0x40007A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int sampleDataLength;

	[Token(Token = "0x40007A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float currentUpdateTime;

	[Token(Token = "0x40007A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float timeSinceTalk;

	[Token(Token = "0x40007A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float clipLoudness;

	[Token(Token = "0x40007A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float[] clipSampleData;

	[Token(Token = "0x40007A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Dictionary<string, string> subtitles;

	[Token(Token = "0x600055A")]
	[Address(RVA = "0x1482C14", Offset = "0x1482C14", VA = "0x1482C14")]
	private void Start()
	{
	}

	[Token(Token = "0x600055B")]
	[Address(RVA = "0x1482DB0", Offset = "0x1482DB0", VA = "0x1482DB0")]
	private void Update()
	{
	}

	[Token(Token = "0x600055C")]
	[Address(RVA = "0x1483224", Offset = "0x1483224", VA = "0x1483224")]
	private void getLoudness()
	{
	}

	[Token(Token = "0x600055D")]
	[Address(RVA = "0x148359C", Offset = "0x148359C", VA = "0x148359C")]
	public walkieTalkieManager()
	{
	}
}
[Token(Token = "0x20000BD")]
public class walkieTalkieNotifyManager : MonoBehaviour
{
	[Token(Token = "0x40007A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private stateManager state;

	[Token(Token = "0x40007A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private calcBodyPosition body;

	[Token(Token = "0x40007AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private particleEffects effect;

	[Token(Token = "0x40007AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform markerAnchor;

	[Token(Token = "0x40007AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SpriteRenderer talkie;

	[Token(Token = "0x40007AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private SpriteRenderer bg;

	[Token(Token = "0x40007AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private TextMeshPro messageTxt;

	[Token(Token = "0x40007AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private ParticleSystem blip;

	[Token(Token = "0x40007B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public AudioSource audioSource1;

	[Token(Token = "0x40007B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float updateStep;

	[Token(Token = "0x40007B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int sampleDataLength;

	[Token(Token = "0x40007B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float currentUpdateTime;

	[Token(Token = "0x40007B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float timeSinceTalk;

	[Token(Token = "0x40007B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float clipLoudness;

	[Token(Token = "0x40007B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float[] clipSampleData;

	[Token(Token = "0x40007B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<string> messageQueue;

	[Token(Token = "0x40007B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<Color> messageColor;

	[Token(Token = "0x40007B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float showTimer;

	[Token(Token = "0x40007BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private int showLimit;

	[Token(Token = "0x40007BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Dictionary<string, string> courseNames;

	[Token(Token = "0x600055E")]
	[Address(RVA = "0x14838E0", Offset = "0x14838E0", VA = "0x14838E0")]
	private void Start()
	{
	}

	[Token(Token = "0x600055F")]
	[Address(RVA = "0x1483AAC", Offset = "0x1483AAC", VA = "0x1483AAC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000560")]
	[Address(RVA = "0x1483F88", Offset = "0x1483F88", VA = "0x1483F88")]
	private void getLoudness()
	{
	}

	[Token(Token = "0x6000561")]
	[Address(RVA = "0x1484130", Offset = "0x1484130", VA = "0x1484130")]
	public void notify(int kind, Color color, string name, string course, int score = 0)
	{
	}

	[Token(Token = "0x6000562")]
	[Address(RVA = "0x1484360", Offset = "0x1484360", VA = "0x1484360")]
	public walkieTalkieNotifyManager()
	{
	}
}
[Token(Token = "0x20000BE")]
public class skiLiftManager : MonoBehaviour
{
	[Token(Token = "0x40007BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<Vector3> pointsLeft;

	[Token(Token = "0x40007BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<Vector3> pointsRight;

	[Token(Token = "0x40007BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<List<Vector3>> posLst;

	[Token(Token = "0x40007BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<Transform> gondolas;

	[Token(Token = "0x40007C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<Vector3> gondolasCurrentTarget;

	[Token(Token = "0x40007C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Quaternion> gondolasPeriodicRot;

	[Token(Token = "0x6000563")]
	[Address(RVA = "0xB94DF0", Offset = "0xB94DF0", VA = "0xB94DF0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000564")]
	[Address(RVA = "0xB95548", Offset = "0xB95548", VA = "0xB95548")]
	private void Update()
	{
	}

	[Token(Token = "0x6000565")]
	[Address(RVA = "0xB95B78", Offset = "0xB95B78", VA = "0xB95B78")]
	public skiLiftManager()
	{
	}
}
namespace UnityTemplateProjects
{
	[Token(Token = "0x20000BF")]
	public class SimpleCameraController : MonoBehaviour
	{
		[Token(Token = "0x2000188")]
		private class CameraState
		{
			[Token(Token = "0x4000C26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yaw;

			[Token(Token = "0x4000C27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pitch;

			[Token(Token = "0x4000C28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float roll;

			[Token(Token = "0x4000C29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float x;

			[Token(Token = "0x4000C2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float y;

			[Token(Token = "0x4000C2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float z;

			[Token(Token = "0x6000AB6")]
			[Address(RVA = "0xA6E0DC", Offset = "0xA6E0DC", VA = "0xA6E0DC")]
			public void SetFromTransform(Transform t)
			{
			}

			[Token(Token = "0x6000AB7")]
			[Address(RVA = "0xA6E764", Offset = "0xA6E764", VA = "0xA6E764")]
			public void Translate(Vector3 translation)
			{
			}

			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0xA6E834", Offset = "0xA6E834", VA = "0xA6E834")]
			public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
			{
			}

			[Token(Token = "0x6000AB9")]
			[Address(RVA = "0xA6E958", Offset = "0xA6E958", VA = "0xA6E958")]
			public void UpdateTransform(Transform t)
			{
			}

			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0xA6EB88", Offset = "0xA6EB88", VA = "0xA6EB88")]
			public CameraState()
			{
			}
		}

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CameraState m_TargetCameraState;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CameraState m_InterpolatingCameraState;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x800EC8", Offset = "0x800EC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x800EC8", Offset = "0x800EC8")]
		public float boost;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x800F28", Offset = "0x800F28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x800F28", Offset = "0x800F28")]
		public float positionLerpTime;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x800F80", Offset = "0x800F80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x800F80", Offset = "0x800F80")]
		public AnimationCurve mouseSensitivityCurve;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x800FE0", Offset = "0x800FE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x800FE0", Offset = "0x800FE0")]
		public float rotationLerpTime;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x801038", Offset = "0x801038")]
		public bool invertY;

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xA6E084", Offset = "0xA6E084", VA = "0xA6E084")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xA6E164", Offset = "0xA6E164", VA = "0xA6E164")]
		private Vector3 GetInputTranslationDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xA6E420", Offset = "0xA6E420", VA = "0xA6E420")]
		private void Update()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xA6E9E8", Offset = "0xA6E9E8", VA = "0xA6E9E8")]
		public SimpleCameraController()
		{
		}
	}
}
namespace UnityEngine.Rendering.LWRP
{
	[Token(Token = "0x20000C0")]
	public class Blit : ScriptableRendererFeature
	{
		[Serializable]
		[Token(Token = "0x2000189")]
		public class BlitSettings
		{
			[Token(Token = "0x4000C2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RenderPassEvent Event;

			[Token(Token = "0x4000C2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Material blitMaterial;

			[Token(Token = "0x4000C2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int blitMaterialPassIndex;

			[Token(Token = "0x4000C2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Target destination;

			[Token(Token = "0x4000C30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string textureId;

			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0xA6DC5C", Offset = "0xA6DC5C", VA = "0xA6DC5C")]
			public BlitSettings()
			{
			}
		}

		[Token(Token = "0x200018A")]
		public enum Target
		{
			[Token(Token = "0x4000C32")]
			Color,
			[Token(Token = "0x4000C33")]
			Texture
		}

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BlitSettings settings;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RenderTargetHandle m_RenderTextureHandle;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private BlitPass blitPass;

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xA6D7EC", Offset = "0xA6D7EC", VA = "0xA6D7EC", Slot = "4")]
		public override void Create()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xA6D9E0", Offset = "0xA6D9E0", VA = "0xA6D9E0", Slot = "5")]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xA6DBF8", Offset = "0xA6DBF8", VA = "0xA6DBF8")]
		public Blit()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	internal class BlitPass : ScriptableRenderPass
	{
		[Token(Token = "0x200018B")]
		public enum RenderTarget
		{
			[Token(Token = "0x4000C35")]
			Color,
			[Token(Token = "0x4000C36")]
			RenderTexture
		}

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Material blitMaterial;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int blitShaderPassIndex;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801070", Offset = "0x801070")]
		private FilterMode <filterMode>k__BackingField;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801080", Offset = "0x801080")]
		private RenderTargetIdentifier <source>k__BackingField;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801090", Offset = "0x801090")]
		private RenderTargetHandle <destination>k__BackingField;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private RenderTargetHandle m_TemporaryColorTexture;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private string m_ProfilerTag;

		[Token(Token = "0x1700004D")]
		public FilterMode filterMode
		{
			[Token(Token = "0x600056D")]
			[Address(RVA = "0xA6DCC4", Offset = "0xA6DCC4", VA = "0xA6DCC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x802D64", Offset = "0x802D64")]
			get
			{
				return default(FilterMode);
			}
			[Token(Token = "0x600056E")]
			[Address(RVA = "0xA6DCCC", Offset = "0xA6DCCC", VA = "0xA6DCCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x802D74", Offset = "0x802D74")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		private RenderTargetIdentifier source
		{
			[Token(Token = "0x600056F")]
			[Address(RVA = "0xA6DCD4", Offset = "0xA6DCD4", VA = "0xA6DCD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x802D84", Offset = "0x802D84")]
			get
			{
				return default(RenderTargetIdentifier);
			}
			[Token(Token = "0x6000570")]
			[Address(RVA = "0xA6DCEC", Offset = "0xA6DCEC", VA = "0xA6DCEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x802D94", Offset = "0x802D94")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		private RenderTargetHandle destination
		{
			[Token(Token = "0x6000571")]
			[Address(RVA = "0xA6DD04", Offset = "0xA6DD04", VA = "0xA6DD04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x802DA4", Offset = "0x802DA4")]
			get
			{
				return default(RenderTargetHandle);
			}
			[Token(Token = "0x6000572")]
			[Address(RVA = "0xA6DD0C", Offset = "0xA6DD0C", VA = "0xA6DD0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x802DB4", Offset = "0x802DB4")]
			set
			{
			}
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xA6D950", Offset = "0xA6D950", VA = "0xA6D950")]
		public BlitPass(RenderPassEvent renderPassEvent, Material blitMaterial, int blitShaderPassIndex, string tag)
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xA6DBDC", Offset = "0xA6DBDC", VA = "0xA6DBDC")]
		public void Setup(RenderTargetIdentifier source, RenderTargetHandle destination)
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xA6DD14", Offset = "0xA6DD14", VA = "0xA6DD14", Slot = "7")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xA6DFD4", Offset = "0xA6DFD4", VA = "0xA6DFD4", Slot = "5")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}
	}
}
namespace SimpleJSON
{
	[Token(Token = "0x20000C2")]
	public enum JSONNodeType
	{
		[Token(Token = "0x40007D4")]
		Array = 1,
		[Token(Token = "0x40007D5")]
		Object = 2,
		[Token(Token = "0x40007D6")]
		String = 3,
		[Token(Token = "0x40007D7")]
		Number = 4,
		[Token(Token = "0x40007D8")]
		NullValue = 5,
		[Token(Token = "0x40007D9")]
		Boolean = 6,
		[Token(Token = "0x40007DA")]
		None = 7,
		[Token(Token = "0x40007DB")]
		Custom = 255
	}
	[Token(Token = "0x20000C3")]
	public enum JSONTextMode
	{
		[Token(Token = "0x40007DD")]
		Compact,
		[Token(Token = "0x40007DE")]
		Indent
	}
	[Token(Token = "0x20000C4")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x7FFBD8", Offset = "0x7FFBD8")]
	public abstract class JSONNode
	{
		[Token(Token = "0x200018C")]
		public struct Enumerator
		{
			[Token(Token = "0x20001D5")]
			private enum Type
			{
				[Token(Token = "0x4000CC7")]
				None,
				[Token(Token = "0x4000CC8")]
				Array,
				[Token(Token = "0x4000CC9")]
				Object
			}

			[Token(Token = "0x4000C37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Type type;

			[Token(Token = "0x4000C38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private Dictionary<string, JSONNode>.Enumerator m_Object;

			[Token(Token = "0x4000C39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator m_Array;

			[Token(Token = "0x17000115")]
			public bool IsValid
			{
				[Token(Token = "0x6000ABC")]
				[Address(RVA = "0xB22FB0", Offset = "0xB22FB0", VA = "0xB22FB0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000116")]
			public KeyValuePair<string, JSONNode> Current
			{
				[Token(Token = "0x6000ABF")]
				[Address(RVA = "0xB22FE4", Offset = "0xB22FE4", VA = "0xB22FE4")]
				get
				{
					return default(KeyValuePair<string, JSONNode>);
				}
			}

			[Token(Token = "0x6000ABD")]
			[Address(RVA = "0xB1BF20", Offset = "0xB1BF20", VA = "0xB1BF20")]
			public Enumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			[Token(Token = "0x6000ABE")]
			[Address(RVA = "0xB22FC0", Offset = "0xB22FC0", VA = "0xB22FC0")]
			public Enumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0xB23098", Offset = "0xB23098", VA = "0xB23098")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200018D")]
		public struct ValueEnumerator
		{
			[Token(Token = "0x4000C3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Enumerator m_Enumerator;

			[Token(Token = "0x17000117")]
			public JSONNode Current
			{
				[Token(Token = "0x6000AC4")]
				[Address(RVA = "0xB234E8", Offset = "0xB234E8", VA = "0xB234E8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0xB2343C", Offset = "0xB2343C", VA = "0xB2343C")]
			public ValueEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			[Token(Token = "0x6000AC2")]
			[Address(RVA = "0xB23484", Offset = "0xB23484", VA = "0xB23484")]
			public ValueEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			[Token(Token = "0x6000AC3")]
			[Address(RVA = "0xB234D0", Offset = "0xB234D0", VA = "0xB234D0")]
			public ValueEnumerator(Enumerator aEnumerator)
			{
			}

			[Token(Token = "0x6000AC5")]
			[Address(RVA = "0xB23534", Offset = "0xB23534", VA = "0xB23534")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0xB23538", Offset = "0xB23538", VA = "0xB23538")]
			public ValueEnumerator GetEnumerator()
			{
				return default(ValueEnumerator);
			}
		}

		[Token(Token = "0x200018E")]
		public struct KeyEnumerator
		{
			[Token(Token = "0x4000C3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Enumerator m_Enumerator;

			[Token(Token = "0x17000118")]
			public string Current
			{
				[Token(Token = "0x6000ACA")]
				[Address(RVA = "0xB231D4", Offset = "0xB231D4", VA = "0xB231D4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AC7")]
			[Address(RVA = "0xB23128", Offset = "0xB23128", VA = "0xB23128")]
			public KeyEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			[Token(Token = "0x6000AC8")]
			[Address(RVA = "0xB23170", Offset = "0xB23170", VA = "0xB23170")]
			public KeyEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			[Token(Token = "0x6000AC9")]
			[Address(RVA = "0xB231BC", Offset = "0xB231BC", VA = "0xB231BC")]
			public KeyEnumerator(Enumerator aEnumerator)
			{
			}

			[Token(Token = "0x6000ACB")]
			[Address(RVA = "0xB23218", Offset = "0xB23218", VA = "0xB23218")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000ACC")]
			[Address(RVA = "0xB2321C", Offset = "0xB2321C", VA = "0xB2321C")]
			public KeyEnumerator GetEnumerator()
			{
				return default(KeyEnumerator);
			}
		}

		[Token(Token = "0x200018F")]
		public class LinqEnumerator : IEnumerator<KeyValuePair<string, JSONNode>>, IEnumerator, IDisposable, IEnumerable<KeyValuePair<string, JSONNode>>, IEnumerable
		{
			[Token(Token = "0x4000C3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private JSONNode m_Node;

			[Token(Token = "0x4000C3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Enumerator m_Enumerator;

			[Token(Token = "0x17000119")]
			public KeyValuePair<string, JSONNode> Current
			{
				[Token(Token = "0x6000ACE")]
				[Address(RVA = "0xB2322C", Offset = "0xB2322C", VA = "0xB2322C", Slot = "4")]
				get
				{
					return default(KeyValuePair<string, JSONNode>);
				}
			}

			[Token(Token = "0x1700011A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000ACF")]
				[Address(RVA = "0xB23234", Offset = "0xB23234", VA = "0xB23234", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000ACD")]
			[Address(RVA = "0xB1E43C", Offset = "0xB1E43C", VA = "0xB1E43C")]
			internal LinqEnumerator(JSONNode aNode)
			{
			}

			[Token(Token = "0x6000AD0")]
			[Address(RVA = "0xB232A0", Offset = "0xB232A0", VA = "0xB232A0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AD1")]
			[Address(RVA = "0xB232A8", Offset = "0xB232A8", VA = "0xB232A8", Slot = "5")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000AD2")]
			[Address(RVA = "0xB232C8", Offset = "0xB232C8", VA = "0xB232C8", Slot = "9")]
			public IEnumerator<KeyValuePair<string, JSONNode>> GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000AD3")]
			[Address(RVA = "0xB2332C", Offset = "0xB2332C", VA = "0xB2332C", Slot = "8")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000AD4")]
			[Address(RVA = "0xB233D8", Offset = "0xB233D8", VA = "0xB233D8", Slot = "10")]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000190")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800058", Offset = "0x800058")]
		private sealed class <get_Children>d__42 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000C40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x1700011B")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000AD8")]
				[Address(RVA = "0xB22754", Offset = "0xB22754", VA = "0xB22754", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000ADA")]
				[Address(RVA = "0xB227BC", Offset = "0xB227BC", VA = "0xB227BC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AD5")]
			[Address(RVA = "0xB1E1A8", Offset = "0xB1E1A8", VA = "0xB1E1A8")]
			[DebuggerHidden]
			public <get_Children>d__42(int <>1__state)
			{
			}

			[Token(Token = "0x6000AD6")]
			[Address(RVA = "0xB22738", Offset = "0xB22738", VA = "0xB22738", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0xB2273C", Offset = "0xB2273C", VA = "0xB2273C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AD9")]
			[Address(RVA = "0xB2275C", Offset = "0xB2275C", VA = "0xB2275C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000ADB")]
			[Address(RVA = "0xB227C4", Offset = "0xB227C4", VA = "0xB227C4", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000ADC")]
			[Address(RVA = "0xB2285C", Offset = "0xB2285C", VA = "0xB2285C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000191")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800068", Offset = "0x800068")]
		private sealed class <get_DeepChildren>d__44 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000C43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000C44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONNode <>4__this;

			[Token(Token = "0x4000C45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IEnumerator<JSONNode> <>7__wrap1;

			[Token(Token = "0x4000C46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IEnumerator<JSONNode> <>7__wrap2;

			[Token(Token = "0x1700011D")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000AE2")]
				[Address(RVA = "0xB22E90", Offset = "0xB22E90", VA = "0xB22E90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AE4")]
				[Address(RVA = "0xB22EF8", Offset = "0xB22EF8", VA = "0xB22EF8", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000ADD")]
			[Address(RVA = "0xB1E260", Offset = "0xB1E260", VA = "0xB1E260")]
			[DebuggerHidden]
			public <get_DeepChildren>d__44(int <>1__state)
			{
			}

			[Token(Token = "0x6000ADE")]
			[Address(RVA = "0xB22860", Offset = "0xB22860", VA = "0xB22860", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000ADF")]
			[Address(RVA = "0xB22A70", Offset = "0xB22A70", VA = "0xB22A70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AE0")]
			[Address(RVA = "0xB229B0", Offset = "0xB229B0", VA = "0xB229B0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000AE1")]
			[Address(RVA = "0xB228F0", Offset = "0xB228F0", VA = "0xB228F0")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x6000AE3")]
			[Address(RVA = "0xB22E98", Offset = "0xB22E98", VA = "0xB22E98", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000AE5")]
			[Address(RVA = "0xB22F00", Offset = "0xB22F00", VA = "0xB22F00", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000AE6")]
			[Address(RVA = "0xB22FAC", Offset = "0xB22FAC", VA = "0xB22FAC", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool forceASCII;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public static bool longAsString;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public static bool allowLineComments;

		[Token(Token = "0x40007E2")]
		[ThreadStatic]
		private static StringBuilder m_EscapeBuilder;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static JSONContainerType VectorContainerType;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static JSONContainerType QuaternionContainerType;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static JSONContainerType RectContainerType;

		[Token(Token = "0x17000050")]
		public abstract JSONNodeType Tag
		{
			[Token(Token = "0x6000577")]
			get;
		}

		[Token(Token = "0x17000051")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0xB1E000", Offset = "0xB1E000", VA = "0xB1E000", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000579")]
			[Address(RVA = "0xB1E008", Offset = "0xB1E008", VA = "0xB1E008", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0xB1E00C", Offset = "0xB1E00C", VA = "0xB1E00C", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600057B")]
			[Address(RVA = "0xB1E014", Offset = "0xB1E014", VA = "0xB1E014", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public virtual string Value
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0xB1E018", Offset = "0xB1E018", VA = "0xB1E018", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600057D")]
			[Address(RVA = "0xB1E060", Offset = "0xB1E060", VA = "0xB1E060", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public virtual int Count
		{
			[Token(Token = "0x600057E")]
			[Address(RVA = "0xB1E064", Offset = "0xB1E064", VA = "0xB1E064", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000055")]
		public virtual bool IsNumber
		{
			[Token(Token = "0x600057F")]
			[Address(RVA = "0xB1E06C", Offset = "0xB1E06C", VA = "0xB1E06C", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		public virtual bool IsString
		{
			[Token(Token = "0x6000580")]
			[Address(RVA = "0xB1E074", Offset = "0xB1E074", VA = "0xB1E074", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		public virtual bool IsBoolean
		{
			[Token(Token = "0x6000581")]
			[Address(RVA = "0xB1E07C", Offset = "0xB1E07C", VA = "0xB1E07C", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000058")]
		public virtual bool IsNull
		{
			[Token(Token = "0x6000582")]
			[Address(RVA = "0xB1E084", Offset = "0xB1E084", VA = "0xB1E084", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000059")]
		public virtual bool IsArray
		{
			[Token(Token = "0x6000583")]
			[Address(RVA = "0xB1E08C", Offset = "0xB1E08C", VA = "0xB1E08C", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005A")]
		public virtual bool IsObject
		{
			[Token(Token = "0x6000584")]
			[Address(RVA = "0xB1E094", Offset = "0xB1E094", VA = "0xB1E094", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		public virtual bool Inline
		{
			[Token(Token = "0x6000585")]
			[Address(RVA = "0xB1E09C", Offset = "0xB1E09C", VA = "0xB1E09C", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000586")]
			[Address(RVA = "0xB1E0A4", Offset = "0xB1E0A4", VA = "0xB1E0A4", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public virtual IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x600058D")]
			[Address(RVA = "0xB1E138", Offset = "0xB1E138", VA = "0xB1E138", Slot = "26")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x802DC4", Offset = "0x802DC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		public IEnumerable<JSONNode> DeepChildren
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0xB1E1E0", Offset = "0xB1E1E0", VA = "0xB1E1E0")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x802E28", Offset = "0x802E28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		public IEnumerable<KeyValuePair<string, JSONNode>> Linq
		{
			[Token(Token = "0x6000595")]
			[Address(RVA = "0xB1E3DC", Offset = "0xB1E3DC", VA = "0xB1E3DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		public KeyEnumerator Keys
		{
			[Token(Token = "0x6000596")]
			[Address(RVA = "0xB1E500", Offset = "0xB1E500", VA = "0xB1E500")]
			get
			{
				return default(KeyEnumerator);
			}
		}

		[Token(Token = "0x17000060")]
		public ValueEnumerator Values
		{
			[Token(Token = "0x6000597")]
			[Address(RVA = "0xB1E548", Offset = "0xB1E548", VA = "0xB1E548")]
			get
			{
				return default(ValueEnumerator);
			}
		}

		[Token(Token = "0x17000061")]
		public virtual double AsDouble
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0xB1E590", Offset = "0xB1E590", VA = "0xB1E590", Slot = "32")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000599")]
			[Address(RVA = "0xB1E66C", Offset = "0xB1E66C", VA = "0xB1E66C", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public virtual int AsInt
		{
			[Token(Token = "0x600059A")]
			[Address(RVA = "0xB1E704", Offset = "0xB1E704", VA = "0xB1E704", Slot = "34")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600059B")]
			[Address(RVA = "0xB1E73C", Offset = "0xB1E73C", VA = "0xB1E73C", Slot = "35")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public virtual float AsFloat
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0xB1E754", Offset = "0xB1E754", VA = "0xB1E754", Slot = "36")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600059D")]
			[Address(RVA = "0xB1E778", Offset = "0xB1E778", VA = "0xB1E778", Slot = "37")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public virtual bool AsBool
		{
			[Token(Token = "0x600059E")]
			[Address(RVA = "0xB1E78C", Offset = "0xB1E78C", VA = "0xB1E78C", Slot = "38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600059F")]
			[Address(RVA = "0xB1E854", Offset = "0xB1E854", VA = "0xB1E854", Slot = "39")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public virtual long AsLong
		{
			[Token(Token = "0x60005A0")]
			[Address(RVA = "0xB1E8D0", Offset = "0xB1E8D0", VA = "0xB1E8D0", Slot = "40")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0xB1E910", Offset = "0xB1E910", VA = "0xB1E910", Slot = "41")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0xB1E950", Offset = "0xB1E950", VA = "0xB1E950", Slot = "42")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		public virtual JSONObject AsObject
		{
			[Token(Token = "0x60005A3")]
			[Address(RVA = "0xB1E9D0", Offset = "0xB1E9D0", VA = "0xB1E9D0", Slot = "43")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		internal static StringBuilder EscapeBuilder
		{
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0xB1F0F4", Offset = "0xB1F0F4", VA = "0xB1F0F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xB1E0A8", Offset = "0xB1E0A8", VA = "0xB1E0A8", Slot = "20")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xB1E0AC", Offset = "0xB1E0AC", VA = "0xB1E0AC", Slot = "21")]
		public virtual void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xB1E118", Offset = "0xB1E118", VA = "0xB1E118", Slot = "22")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xB1E120", Offset = "0xB1E120", VA = "0xB1E120", Slot = "23")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xB1E128", Offset = "0xB1E128", VA = "0xB1E128", Slot = "24")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xB1E130", Offset = "0xB1E130", VA = "0xB1E130", Slot = "25")]
		public virtual JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xB1E298", Offset = "0xB1E298", VA = "0xB1E298", Slot = "27")]
		public virtual bool HasKey(string aKey)
		{
			return default(bool);
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xB1E2A0", Offset = "0xB1E2A0", VA = "0xB1E2A0", Slot = "28")]
		public virtual JSONNode GetValueOrDefault(string aKey, JSONNode aDefault)
		{
			return null;
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xB1E2A8", Offset = "0xB1E2A8", VA = "0xB1E2A8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xB1E33C", Offset = "0xB1E33C", VA = "0xB1E33C", Slot = "29")]
		public virtual string ToString(int aIndent)
		{
			return null;
		}

		[Token(Token = "0x6000593")]
		internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);

		[Token(Token = "0x6000594")]
		public abstract Enumerator GetEnumerator();

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xB1EA50", Offset = "0xB1EA50", VA = "0xB1EA50")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xB1EAB0", Offset = "0xB1EAB0", VA = "0xB1EAB0")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xB1EB44", Offset = "0xB1EB44", VA = "0xB1EB44")]
		public static implicit operator JSONNode(double n)
		{
			return null;
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xB1EBAC", Offset = "0xB1EBAC", VA = "0xB1EBAC")]
		public static implicit operator double(JSONNode d)
		{
			return default(double);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xB1EC44", Offset = "0xB1EC44", VA = "0xB1EC44")]
		public static implicit operator JSONNode(float n)
		{
			return null;
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xB1ECAC", Offset = "0xB1ECAC", VA = "0xB1ECAC")]
		public static implicit operator float(JSONNode d)
		{
			return default(float);
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xB1ED44", Offset = "0xB1ED44", VA = "0xB1ED44")]
		public static implicit operator JSONNode(int n)
		{
			return null;
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xB1EDA4", Offset = "0xB1EDA4", VA = "0xB1EDA4")]
		public static implicit operator int(JSONNode d)
		{
			return default(int);
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xB1EE3C", Offset = "0xB1EE3C", VA = "0xB1EE3C")]
		public static implicit operator JSONNode(long n)
		{
			return null;
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xB1EF0C", Offset = "0xB1EF0C", VA = "0xB1EF0C")]
		public static implicit operator long(JSONNode d)
		{
			return default(long);
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xB1EFA4", Offset = "0xB1EFA4", VA = "0xB1EFA4")]
		public static implicit operator JSONNode(bool b)
		{
			return null;
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xB1F004", Offset = "0xB1F004", VA = "0xB1F004")]
		public static implicit operator bool(JSONNode d)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xB1F09C", Offset = "0xB1F09C", VA = "0xB1F09C")]
		public static implicit operator JSONNode(KeyValuePair<string, JSONNode> aKeyValue)
		{
			return null;
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xB1C164", Offset = "0xB1C164", VA = "0xB1C164")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xB1C944", Offset = "0xB1C944", VA = "0xB1C944")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xB1F0E0", Offset = "0xB1F0E0", VA = "0xB1F0E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xB1F0EC", Offset = "0xB1F0EC", VA = "0xB1F0EC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xB1F1C4", Offset = "0xB1F1C4", VA = "0xB1F1C4")]
		internal static string Escape(string aText)
		{
			return null;
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xB1F464", Offset = "0xB1F464", VA = "0xB1F464")]
		private static JSONNode ParseElement(string token, bool quoted)
		{
			return null;
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xB1B6F8", Offset = "0xB1B6F8", VA = "0xB1B6F8")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		[Token(Token = "0x60005B9")]
		public abstract void SerializeBinary(BinaryWriter aWriter);

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xB1F668", Offset = "0xB1F668", VA = "0xB1F668")]
		public void SaveToBinaryStream(Stream aData)
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xB1F6E8", Offset = "0xB1F6E8", VA = "0xB1F6E8")]
		public void SaveToCompressedStream(Stream aData)
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xB1F754", Offset = "0xB1F754", VA = "0xB1F754")]
		public void SaveToCompressedFile(string aFileName)
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xB1F7C0", Offset = "0xB1F7C0", VA = "0xB1F7C0")]
		public string SaveToCompressedBase64()
		{
			return null;
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xB1F82C", Offset = "0xB1F82C", VA = "0xB1F82C")]
		public void SaveToBinaryFile(string aFileName)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xB1F980", Offset = "0xB1F980", VA = "0xB1F980")]
		public string SaveToBinaryBase64()
		{
			return null;
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xB1FB04", Offset = "0xB1FB04", VA = "0xB1FB04")]
		public static JSONNode DeserializeBinary(BinaryReader aReader)
		{
			return null;
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xB1FE28", Offset = "0xB1FE28", VA = "0xB1FE28")]
		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xB1FE94", Offset = "0xB1FE94", VA = "0xB1FE94")]
		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xB1FF00", Offset = "0xB1FF00", VA = "0xB1FF00")]
		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xB1FF6C", Offset = "0xB1FF6C", VA = "0xB1FF6C")]
		public static JSONNode LoadFromBinaryStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xB200AC", Offset = "0xB200AC", VA = "0xB200AC")]
		public static JSONNode LoadFromBinaryFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xB201E0", Offset = "0xB201E0", VA = "0xB201E0")]
		public static JSONNode LoadFromBinaryBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xB202B4", Offset = "0xB202B4", VA = "0xB202B4")]
		private static JSONNode GetContainer(JSONContainerType aType)
		{
			return null;
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xB20330", Offset = "0xB20330", VA = "0xB20330")]
		public static implicit operator JSONNode(Vector2 aVec)
		{
			return null;
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xB20510", Offset = "0xB20510", VA = "0xB20510")]
		public static implicit operator JSONNode(Vector3 aVec)
		{
			return null;
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xB20774", Offset = "0xB20774", VA = "0xB20774")]
		public static implicit operator JSONNode(Vector4 aVec)
		{
			return null;
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xB20A4C", Offset = "0xB20A4C", VA = "0xB20A4C")]
		public static implicit operator JSONNode(Quaternion aRot)
		{
			return null;
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xB20D24", Offset = "0xB20D24", VA = "0xB20D24")]
		public static implicit operator JSONNode(Rect aRect)
		{
			return null;
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xB21058", Offset = "0xB21058", VA = "0xB21058")]
		public static implicit operator JSONNode(RectOffset aRect)
		{
			return null;
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xB21384", Offset = "0xB21384", VA = "0xB21384")]
		public static implicit operator Vector2(JSONNode aNode)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xB21404", Offset = "0xB21404", VA = "0xB21404")]
		public static implicit operator Vector3(JSONNode aNode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xB21484", Offset = "0xB21484", VA = "0xB21484")]
		public static implicit operator Vector4(JSONNode aNode)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xB21504", Offset = "0xB21504", VA = "0xB21504")]
		public static implicit operator Quaternion(JSONNode aNode)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xB21584", Offset = "0xB21584", VA = "0xB21584")]
		public static implicit operator Rect(JSONNode aNode)
		{
			return default(Rect);
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xB215BC", Offset = "0xB215BC", VA = "0xB215BC")]
		public static implicit operator RectOffset(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xB21634", Offset = "0xB21634", VA = "0xB21634")]
		public Vector2 ReadVector2(Vector2 aDefault)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xB21790", Offset = "0xB21790", VA = "0xB21790")]
		public Vector2 ReadVector2(string aXName, string aYName)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xB21398", Offset = "0xB21398", VA = "0xB21398")]
		public Vector2 ReadVector2()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xB203D4", Offset = "0xB203D4", VA = "0xB203D4")]
		public JSONNode WriteVector2(Vector2 aVec, string aXName = "x", string aYName = "y")
		{
			return null;
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xB218A4", Offset = "0xB218A4", VA = "0xB218A4")]
		public Vector3 ReadVector3(Vector3 aDefault)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xB21A7C", Offset = "0xB21A7C", VA = "0xB21A7C")]
		public Vector3 ReadVector3(string aXName, string aYName, string aZName)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xB21418", Offset = "0xB21418", VA = "0xB21418")]
		public Vector3 ReadVector3()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xB205D0", Offset = "0xB205D0", VA = "0xB205D0")]
		public JSONNode WriteVector3(Vector3 aVec, string aXName = "x", string aYName = "y", string aZName = "z")
		{
			return null;
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xB21BE0", Offset = "0xB21BE0", VA = "0xB21BE0")]
		public Vector4 ReadVector4(Vector4 aDefault)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xB21498", Offset = "0xB21498", VA = "0xB21498")]
		public Vector4 ReadVector4()
		{
			return default(Vector4);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xB20818", Offset = "0xB20818", VA = "0xB20818")]
		public JSONNode WriteVector4(Vector4 aVec)
		{
			return null;
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xB21E1C", Offset = "0xB21E1C", VA = "0xB21E1C")]
		public Quaternion ReadQuaternion(Quaternion aDefault)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xB21518", Offset = "0xB21518", VA = "0xB21518")]
		public Quaternion ReadQuaternion()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xB20AF0", Offset = "0xB20AF0", VA = "0xB20AF0")]
		public JSONNode WriteQuaternion(Quaternion aRot)
		{
			return null;
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xB22058", Offset = "0xB22058", VA = "0xB22058")]
		public Rect ReadRect(Rect aDefault)
		{
			return default(Rect);
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xB215A8", Offset = "0xB215A8", VA = "0xB215A8")]
		public Rect ReadRect()
		{
			return default(Rect);
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xB20DC8", Offset = "0xB20DC8", VA = "0xB20DC8")]
		public JSONNode WriteRect(Rect aRect)
		{
			return null;
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xB22294", Offset = "0xB22294", VA = "0xB22294")]
		public RectOffset ReadRectOffset(RectOffset aDefault)
		{
			return null;
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xB215D0", Offset = "0xB215D0", VA = "0xB215D0")]
		public RectOffset ReadRectOffset()
		{
			return null;
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xB210D4", Offset = "0xB210D4", VA = "0xB210D4")]
		public JSONNode WriteRectOffset(RectOffset aRect)
		{
			return null;
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xB224EC", Offset = "0xB224EC", VA = "0xB224EC")]
		public Matrix4x4 ReadMatrix()
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xB225FC", Offset = "0xB225FC", VA = "0xB225FC")]
		public JSONNode WriteMatrix(Matrix4x4 aMatrix)
		{
			return null;
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xB1CCD4", Offset = "0xB1CCD4", VA = "0xB1CCD4")]
		protected JSONNode()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x7FFC10", Offset = "0x7FFC10")]
	public class JSONArray : JSONNode
	{
		[Token(Token = "0x2000192")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800078", Offset = "0x800078")]
		private sealed class <get_Children>d__23 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000C49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000C4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONArray <>4__this;

			[Token(Token = "0x4000C4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x1700011F")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000AEB")]
				[Address(RVA = "0xB1CEA4", Offset = "0xB1CEA4", VA = "0xB1CEA4", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000120")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AED")]
				[Address(RVA = "0xB1CF0C", Offset = "0xB1CF0C", VA = "0xB1CF0C", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AE7")]
			[Address(RVA = "0xB1CA44", Offset = "0xB1CA44", VA = "0xB1CA44")]
			[DebuggerHidden]
			public <get_Children>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x6000AE8")]
			[Address(RVA = "0xB1CCDC", Offset = "0xB1CCDC", VA = "0xB1CCDC", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AE9")]
			[Address(RVA = "0xB1CD50", Offset = "0xB1CD50", VA = "0xB1CD50", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AEA")]
			[Address(RVA = "0xB1CCF8", Offset = "0xB1CCF8", VA = "0xB1CCF8")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000AEC")]
			[Address(RVA = "0xB1CEAC", Offset = "0xB1CEAC", VA = "0xB1CEAC", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000AEE")]
			[Address(RVA = "0xB1CF14", Offset = "0xB1CF14", VA = "0xB1CF14", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000AEF")]
			[Address(RVA = "0xB1CFC0", Offset = "0xB1CFC0", VA = "0xB1CFC0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<JSONNode> m_List;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inline;

		[Token(Token = "0x17000069")]
		public override bool Inline
		{
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0xB1BE68", Offset = "0xB1BE68", VA = "0xB1BE68", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0xB1BE70", Offset = "0xB1BE70", VA = "0xB1BE70", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0xB1BE7C", Offset = "0xB1BE7C", VA = "0xB1BE7C", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x1700006B")]
		public override bool IsArray
		{
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0xB1BE84", Offset = "0xB1BE84", VA = "0xB1BE84", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006C")]
		public override JSONNode Item
		{
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0xB1BF48", Offset = "0xB1BF48", VA = "0xB1BF48", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0xB1C068", Offset = "0xB1C068", VA = "0xB1C068", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public override JSONNode Item
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0xB1C394", Offset = "0xB1C394", VA = "0xB1C394", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0xB1C3F4", Offset = "0xB1C3F4", VA = "0xB1C3F4", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public override int Count
		{
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0xB1C4B4", Offset = "0xB1C4B4", VA = "0xB1C4B4", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700006F")]
		public override IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x60005FA")]
			[Address(RVA = "0xB1C9C4", Offset = "0xB1C9C4", VA = "0xB1C9C4", Slot = "26")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x802E8C", Offset = "0x802E8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xB1BE8C", Offset = "0xB1BE8C", VA = "0xB1BE8C", Slot = "31")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xB1C504", Offset = "0xB1C504", VA = "0xB1C504", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xB1C5C4", Offset = "0xB1C5C4", VA = "0xB1C5C4", Slot = "23")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xB1C670", Offset = "0xB1C670", VA = "0xB1C670", Slot = "24")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xB1C6E0", Offset = "0xB1C6E0", VA = "0xB1C6E0", Slot = "25")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xB1CA7C", Offset = "0xB1CA7C", VA = "0xB1CA7C", Slot = "30")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xB1CBF4", Offset = "0xB1CBF4", VA = "0xB1CBF4", Slot = "44")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xB1C8B4", Offset = "0xB1C8B4", VA = "0xB1C8B4")]
		public JSONArray()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x7FFC48", Offset = "0x7FFC48")]
	public class JSONObject : JSONNode
	{
		[Token(Token = "0x2000193")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800088", Offset = "0x800088")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x4000C4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public JSONNode aNode;

			[Token(Token = "0x6000AF0")]
			[Address(RVA = "0xB246BC", Offset = "0xB246BC", VA = "0xB246BC")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6000AF1")]
			[Address(RVA = "0xB24E4C", Offset = "0xB24E4C", VA = "0xB24E4C")]
			internal bool <Remove>b__0(KeyValuePair<string, JSONNode> k)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000194")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800098", Offset = "0x800098")]
		private sealed class <get_Children>d__26 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000C4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000C4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000C4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000C50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONObject <>4__this;

			[Token(Token = "0x4000C51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x17000121")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000AF6")]
				[Address(RVA = "0xB25094", Offset = "0xB25094", VA = "0xB25094", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000122")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AF8")]
				[Address(RVA = "0xB250FC", Offset = "0xB250FC", VA = "0xB250FC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AF2")]
			[Address(RVA = "0xB24990", Offset = "0xB24990", VA = "0xB24990")]
			[DebuggerHidden]
			public <get_Children>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000AF3")]
			[Address(RVA = "0xB24EC4", Offset = "0xB24EC4", VA = "0xB24EC4", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0xB24F38", Offset = "0xB24F38", VA = "0xB24F38", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AF5")]
			[Address(RVA = "0xB24EE0", Offset = "0xB24EE0", VA = "0xB24EE0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000AF7")]
			[Address(RVA = "0xB2509C", Offset = "0xB2509C", VA = "0xB2509C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000AF9")]
			[Address(RVA = "0xB25104", Offset = "0xB25104", VA = "0xB25104", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000AFA")]
			[Address(RVA = "0xB251B0", Offset = "0xB251B0", VA = "0xB251B0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, JSONNode> m_Dict;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inline;

		[Token(Token = "0x17000070")]
		public override bool Inline
		{
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0xB23DBC", Offset = "0xB23DBC", VA = "0xB23DBC", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0xB23DC4", Offset = "0xB23DC4", VA = "0xB23DC4", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x6000600")]
			[Address(RVA = "0xB23DD0", Offset = "0xB23DD0", VA = "0xB23DD0", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000072")]
		public override bool IsObject
		{
			[Token(Token = "0x6000601")]
			[Address(RVA = "0xB23DD8", Offset = "0xB23DD8", VA = "0xB23DD8", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000073")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000603")]
			[Address(RVA = "0xB23E78", Offset = "0xB23E78", VA = "0xB23E78", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000604")]
			[Address(RVA = "0xB23F34", Offset = "0xB23F34", VA = "0xB23F34", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000605")]
			[Address(RVA = "0xB24048", Offset = "0xB24048", VA = "0xB24048", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000606")]
			[Address(RVA = "0xB240E0", Offset = "0xB240E0", VA = "0xB240E0", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public override int Count
		{
			[Token(Token = "0x6000607")]
			[Address(RVA = "0xB241FC", Offset = "0xB241FC", VA = "0xB241FC", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000076")]
		public override IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x600060F")]
			[Address(RVA = "0xB24910", Offset = "0xB24910", VA = "0xB24910", Slot = "26")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x802EF0", Offset = "0x802EF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xB23DE0", Offset = "0xB23DE0", VA = "0xB23DE0", Slot = "31")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xB24254", Offset = "0xB24254", VA = "0xB24254", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xB243CC", Offset = "0xB243CC", VA = "0xB243CC", Slot = "22")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xB24488", Offset = "0xB24488", VA = "0xB24488", Slot = "23")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xB24544", Offset = "0xB24544", VA = "0xB24544", Slot = "24")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xB246C4", Offset = "0xB246C4", VA = "0xB246C4", Slot = "25")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xB2481C", Offset = "0xB2481C", VA = "0xB2481C", Slot = "27")]
		public override bool HasKey(string aKey)
		{
			return default(bool);
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xB24884", Offset = "0xB24884", VA = "0xB24884", Slot = "28")]
		public override JSONNode GetValueOrDefault(string aKey, JSONNode aDefault)
		{
			return null;
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xB249C8", Offset = "0xB249C8", VA = "0xB249C8", Slot = "30")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xB24C94", Offset = "0xB24C94", VA = "0xB24C94", Slot = "44")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xB1D610", Offset = "0xB1D610", VA = "0xB1D610")]
		public JSONObject()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public class JSONString : JSONNode
	{
		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_Data;

		[Token(Token = "0x17000077")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x6000613")]
			[Address(RVA = "0xB251B4", Offset = "0xB251B4", VA = "0xB251B4", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000078")]
		public override bool IsString
		{
			[Token(Token = "0x6000614")]
			[Address(RVA = "0xB251BC", Offset = "0xB251BC", VA = "0xB251BC", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000079")]
		public override string Value
		{
			[Token(Token = "0x6000616")]
			[Address(RVA = "0xB251E4", Offset = "0xB251E4", VA = "0xB251E4", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000617")]
			[Address(RVA = "0xB251EC", Offset = "0xB251EC", VA = "0xB251EC", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xB251C4", Offset = "0xB251C4", VA = "0xB251C4", Slot = "31")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xB1DC50", Offset = "0xB1DC50", VA = "0xB1DC50")]
		public JSONString(string aData)
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xB251F4", Offset = "0xB251F4", VA = "0xB251F4", Slot = "25")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xB25258", Offset = "0xB25258", VA = "0xB25258", Slot = "30")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xB25310", Offset = "0xB25310", VA = "0xB25310", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xB25424", Offset = "0xB25424", VA = "0xB25424", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xB25444", Offset = "0xB25444", VA = "0xB25444", Slot = "44")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public class JSONNumber : JSONNode
	{
		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private double m_Data;

		[Token(Token = "0x1700007A")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x600061E")]
			[Address(RVA = "0xB23828", Offset = "0xB23828", VA = "0xB23828", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x1700007B")]
		public override bool IsNumber
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0xB23830", Offset = "0xB23830", VA = "0xB23830", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007C")]
		public override string Value
		{
			[Token(Token = "0x6000621")]
			[Address(RVA = "0xB23858", Offset = "0xB23858", VA = "0xB23858", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000622")]
			[Address(RVA = "0xB238D0", Offset = "0xB238D0", VA = "0xB238D0", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public override double AsDouble
		{
			[Token(Token = "0x6000623")]
			[Address(RVA = "0xB23994", Offset = "0xB23994", VA = "0xB23994", Slot = "32")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000624")]
			[Address(RVA = "0xB2399C", Offset = "0xB2399C", VA = "0xB2399C", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public override long AsLong
		{
			[Token(Token = "0x6000625")]
			[Address(RVA = "0xB239A4", Offset = "0xB239A4", VA = "0xB239A4", Slot = "40")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000626")]
			[Address(RVA = "0xB239C4", Offset = "0xB239C4", VA = "0xB239C4", Slot = "41")]
			set
			{
			}
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xB23838", Offset = "0xB23838", VA = "0xB23838", Slot = "31")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xB1D898", Offset = "0xB1D898", VA = "0xB1D898")]
		public JSONNumber(double aData)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xB239D0", Offset = "0xB239D0", VA = "0xB239D0")]
		public JSONNumber(string aData)
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xB23A58", Offset = "0xB23A58", VA = "0xB23A58", Slot = "25")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xB23AC4", Offset = "0xB23AC4", VA = "0xB23AC4", Slot = "30")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xB23B04", Offset = "0xB23B04", VA = "0xB23B04")]
		private static bool IsNumeric(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xB23C34", Offset = "0xB23C34", VA = "0xB23C34", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xB23D60", Offset = "0xB23D60", VA = "0xB23D60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xB23D6C", Offset = "0xB23D6C", VA = "0xB23D6C", Slot = "44")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class JSONBool : JSONNode
	{
		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool m_Data;

		[Token(Token = "0x1700007F")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x600062F")]
			[Address(RVA = "0xB1CFC4", Offset = "0xB1CFC4", VA = "0xB1CFC4", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000080")]
		public override bool IsBoolean
		{
			[Token(Token = "0x6000630")]
			[Address(RVA = "0xB1CFCC", Offset = "0xB1CFCC", VA = "0xB1CFCC", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000081")]
		public override string Value
		{
			[Token(Token = "0x6000632")]
			[Address(RVA = "0xB1CFF4", Offset = "0xB1CFF4", VA = "0xB1CFF4", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000633")]
			[Address(RVA = "0xB1D000", Offset = "0xB1D000", VA = "0xB1D000", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public override bool AsBool
		{
			[Token(Token = "0x6000634")]
			[Address(RVA = "0xB1D08C", Offset = "0xB1D08C", VA = "0xB1D08C", Slot = "38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000635")]
			[Address(RVA = "0xB1D094", Offset = "0xB1D094", VA = "0xB1D094", Slot = "39")]
			set
			{
			}
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xB1CFD4", Offset = "0xB1CFD4", VA = "0xB1CFD4", Slot = "31")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xB1D0A0", Offset = "0xB1D0A0", VA = "0xB1D0A0")]
		public JSONBool(bool aData)
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xB1D120", Offset = "0xB1D120", VA = "0xB1D120")]
		public JSONBool(string aData)
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xB1D1A8", Offset = "0xB1D1A8", VA = "0xB1D1A8", Slot = "25")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xB1D20C", Offset = "0xB1D20C", VA = "0xB1D20C", Slot = "30")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xB1D288", Offset = "0xB1D288", VA = "0xB1D288", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xB1D310", Offset = "0xB1D310", VA = "0xB1D310", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xB1D31C", Offset = "0xB1D31C", VA = "0xB1D31C", Slot = "44")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class JSONNull : JSONNode
	{
		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static JSONNull m_StaticInstance;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static bool reuseSameInstance;

		[Token(Token = "0x17000083")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x600063F")]
			[Address(RVA = "0xB235B0", Offset = "0xB235B0", VA = "0xB235B0", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000084")]
		public override bool IsNull
		{
			[Token(Token = "0x6000640")]
			[Address(RVA = "0xB235B8", Offset = "0xB235B8", VA = "0xB235B8", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000085")]
		public override string Value
		{
			[Token(Token = "0x6000642")]
			[Address(RVA = "0xB235E0", Offset = "0xB235E0", VA = "0xB235E0", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000643")]
			[Address(RVA = "0xB23628", Offset = "0xB23628", VA = "0xB23628", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public override bool AsBool
		{
			[Token(Token = "0x6000644")]
			[Address(RVA = "0xB2362C", Offset = "0xB2362C", VA = "0xB2362C", Slot = "38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000645")]
			[Address(RVA = "0xB23634", Offset = "0xB23634", VA = "0xB23634", Slot = "39")]
			set
			{
			}
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xB1C2F4", Offset = "0xB1C2F4", VA = "0xB1C2F4")]
		public static JSONNull CreateOrGet()
		{
			return null;
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xB23548", Offset = "0xB23548", VA = "0xB23548")]
		private JSONNull()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xB235C0", Offset = "0xB235C0", VA = "0xB235C0", Slot = "31")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0xB23638", Offset = "0xB23638", VA = "0xB23638", Slot = "25")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xB23694", Offset = "0xB23694", VA = "0xB23694", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xB23730", Offset = "0xB23730", VA = "0xB23730", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xB23738", Offset = "0xB23738", VA = "0xB23738", Slot = "30")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xB23794", Offset = "0xB23794", VA = "0xB23794", Slot = "44")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x20000CB")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x7FFC80", Offset = "0x7FFC80")]
	internal class JSONLazyCreator : JSONNode
	{
		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private JSONNode m_Node;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_Key;

		[Token(Token = "0x17000087")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x600064C")]
			[Address(RVA = "0xB1D368", Offset = "0xB1D368", VA = "0xB1D368", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000088")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0xB1D410", Offset = "0xB1D410", VA = "0xB1D410", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000652")]
			[Address(RVA = "0xB1D470", Offset = "0xB1D470", VA = "0xB1D470", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000653")]
			[Address(RVA = "0xB1D504", Offset = "0xB1D504", VA = "0xB1D504", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000654")]
			[Address(RVA = "0xB1D574", Offset = "0xB1D574", VA = "0xB1D574", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public override int AsInt
		{
			[Token(Token = "0x600065B")]
			[Address(RVA = "0xB1D820", Offset = "0xB1D820", VA = "0xB1D820", Slot = "34")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600065C")]
			[Address(RVA = "0xB1D914", Offset = "0xB1D914", VA = "0xB1D914", Slot = "35")]
			set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public override float AsFloat
		{
			[Token(Token = "0x600065D")]
			[Address(RVA = "0xB1D990", Offset = "0xB1D990", VA = "0xB1D990", Slot = "36")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600065E")]
			[Address(RVA = "0xB1DA08", Offset = "0xB1DA08", VA = "0xB1DA08", Slot = "37")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public override double AsDouble
		{
			[Token(Token = "0x600065F")]
			[Address(RVA = "0xB1DA84", Offset = "0xB1DA84", VA = "0xB1DA84", Slot = "32")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000660")]
			[Address(RVA = "0xB1DAFC", Offset = "0xB1DAFC", VA = "0xB1DAFC", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public override long AsLong
		{
			[Token(Token = "0x6000661")]
			[Address(RVA = "0xB1DB78", Offset = "0xB1DB78", VA = "0xB1DB78", Slot = "40")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000662")]
			[Address(RVA = "0xB1DCCC", Offset = "0xB1DCCC", VA = "0xB1DCCC", Slot = "41")]
			set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public override bool AsBool
		{
			[Token(Token = "0x6000663")]
			[Address(RVA = "0xB1DDD4", Offset = "0xB1DDD4", VA = "0xB1DDD4", Slot = "38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000664")]
			[Address(RVA = "0xB1DE4C", Offset = "0xB1DE4C", VA = "0xB1DE4C", Slot = "39")]
			set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x6000665")]
			[Address(RVA = "0xB1DEC8", Offset = "0xB1DEC8", VA = "0xB1DEC8", Slot = "42")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000090")]
		public override JSONObject AsObject
		{
			[Token(Token = "0x6000666")]
			[Address(RVA = "0xB1DF34", Offset = "0xB1DF34", VA = "0xB1DF34", Slot = "43")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0xB1D370", Offset = "0xB1D370", VA = "0xB1D370", Slot = "31")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0xB1BFEC", Offset = "0xB1BFEC", VA = "0xB1BFEC")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xB1D390", Offset = "0xB1D390", VA = "0xB1D390")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		[Token(Token = "0x6000650")]
		private T Set<T>(T aVal) where T : JSONNode
		{
			return null;
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xB1D6A0", Offset = "0xB1D6A0", VA = "0xB1D6A0", Slot = "21")]
		public override void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xB1D734", Offset = "0xB1D734", VA = "0xB1D734", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xB1D7D0", Offset = "0xB1D7D0", VA = "0xB1D7D0")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xB1D7E8", Offset = "0xB1D7E8", VA = "0xB1D7E8")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xB1D800", Offset = "0xB1D800", VA = "0xB1D800", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0xB1D818", Offset = "0xB1D818", VA = "0xB1D818", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xB1DFA0", Offset = "0xB1DFA0", VA = "0xB1DFA0", Slot = "30")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xB1DFFC", Offset = "0xB1DFFC", VA = "0xB1DFFC", Slot = "44")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public static class JSON
	{
		[Token(Token = "0x6000669")]
		[Address(RVA = "0xB1B694", Offset = "0xB1B694", VA = "0xB1B694")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}
	}
	[Token(Token = "0x20000CD")]
	public enum JSONContainerType
	{
		[Token(Token = "0x40007F2")]
		Array,
		[Token(Token = "0x40007F3")]
		Object
	}
}
namespace shortid
{
	[Token(Token = "0x20000CE")]
	public static class ShortId
	{
		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static System.Random _random;

		[Token(Token = "0x40007F5")]
		private const string Bigs = "ABCDEFGHIJKLMNOPQRSTUVWXY";

		[Token(Token = "0x40007F6")]
		private const string Smalls = "abcdefghjlkmnopqrstuvwxyz";

		[Token(Token = "0x40007F7")]
		private const string Numbers = "0123456789";

		[Token(Token = "0x40007F8")]
		private const string Specials = "-_";

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string _pool;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly object ThreadLock;

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xB9419C", Offset = "0xB9419C", VA = "0xB9419C")]
		public static string Generate(bool useNumbers = false, bool useSpecial = true)
		{
			return null;
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xB94240", Offset = "0xB94240", VA = "0xB94240")]
		public static string Generate(bool useNumbers, bool useSpecial, int length)
		{
			return null;
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xB944E0", Offset = "0xB944E0", VA = "0xB944E0")]
		public static string Generate(int length)
		{
			return null;
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xB9454C", Offset = "0xB9454C", VA = "0xB9454C")]
		public static void SetCharacters(string characters)
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xB94710", Offset = "0xB94710", VA = "0xB94710")]
		public static void SetSeed(int seed)
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xB94830", Offset = "0xB94830", VA = "0xB94830")]
		public static void Reset()
		{
		}
	}
}
namespace Pvr_UnitySDKAPI
{
	[Token(Token = "0x20000CF")]
	public class PvrControllerKey
	{
		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool State;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool PressedDown;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool PressedUp;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		public bool LongPressed;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool Click;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		public bool Touch;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		public bool TouchDown;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
		public bool TouchUp;

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xD54914", Offset = "0xD54914", VA = "0xD54914")]
		public PvrControllerKey()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public class ControllerHand
	{
		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PvrControllerKey App;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PvrControllerKey Touch;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PvrControllerKey Home;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PvrControllerKey VolumeDown;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PvrControllerKey VolumeUp;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public PvrControllerKey Trigger;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public PvrControllerKey X;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public PvrControllerKey Y;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public PvrControllerKey A;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public PvrControllerKey B;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public PvrControllerKey Left;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public PvrControllerKey Right;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public PvrControllerKey Thumbrest;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector2 TouchPadPosition;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int TriggerNum;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public int GripValue;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Quaternion Rotation;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Vector3 Position;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public int Battery;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public ControllerState ConnectState;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public SwipeDirection SwipeDirection;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public TouchPadClick TouchPadClick;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public bool isShowBoundary;

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xD54730", Offset = "0xD54730", VA = "0xD54730")]
		public ControllerHand()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public enum ControllerState
	{
		[Token(Token = "0x400081B")]
		Error = -1,
		[Token(Token = "0x400081C")]
		DisConnected,
		[Token(Token = "0x400081D")]
		Connected
	}
	[Token(Token = "0x20000D2")]
	public enum Pvr_KeyCode
	{
		[Token(Token = "0x400081F")]
		None = 0,
		[Token(Token = "0x4000820")]
		APP = 1,
		[Token(Token = "0x4000821")]
		TOUCHPAD = 2,
		[Token(Token = "0x4000822")]
		HOME = 4,
		[Token(Token = "0x4000823")]
		VOLUMEUP = 8,
		[Token(Token = "0x4000824")]
		VOLUMEDOWN = 16,
		[Token(Token = "0x4000825")]
		TRIGGER = 32,
		[Token(Token = "0x4000826")]
		A = 64,
		[Token(Token = "0x4000827")]
		B = 128,
		[Token(Token = "0x4000828")]
		X = 256,
		[Token(Token = "0x4000829")]
		Y = 512,
		[Token(Token = "0x400082A")]
		Left = 1024,
		[Token(Token = "0x400082B")]
		Right = 2048,
		[Token(Token = "0x400082C")]
		Thumbrest = 4096,
		[Token(Token = "0x400082D")]
		Any = -1
	}
	[Token(Token = "0x20000D3")]
	public enum SwipeDirection
	{
		[Token(Token = "0x400082F")]
		No,
		[Token(Token = "0x4000830")]
		SwipeUp,
		[Token(Token = "0x4000831")]
		SwipeDown,
		[Token(Token = "0x4000832")]
		SwipeLeft,
		[Token(Token = "0x4000833")]
		SwipeRight
	}
	[Token(Token = "0x20000D4")]
	public enum TouchPadClick
	{
		[Token(Token = "0x4000835")]
		No,
		[Token(Token = "0x4000836")]
		ClickUp,
		[Token(Token = "0x4000837")]
		ClickDown,
		[Token(Token = "0x4000838")]
		ClickLeft,
		[Token(Token = "0x4000839")]
		ClickRight
	}
	[Token(Token = "0x20000D5")]
	public struct Controller
	{
		[Token(Token = "0x400083A")]
		private const float JOYSTICK_THRESHOLD = 0.4f;

		[Token(Token = "0x400083B")]
		public const string LibFileName = "Pvr_UnitySDK";

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xD4862C", Offset = "0xD4862C", VA = "0xD4862C")]
		public static Vector2 UPvr_GetTouchPadPosition(int hand)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xD4FAC8", Offset = "0xD4FAC8", VA = "0xD4FAC8")]
		public static float UPvr_GetAxis1D(int hand, Pvr_KeyCode key)
		{
			return default(float);
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xD4FC4C", Offset = "0xD4FC4C", VA = "0xD4FC4C")]
		public static Vector2 UPvr_GetAxis2D(int hand)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xD4FEE4", Offset = "0xD4FEE4", VA = "0xD4FEE4")]
		public static bool UPvr_GetJoystickUp(int hand)
		{
			return default(bool);
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xD5010C", Offset = "0xD5010C", VA = "0xD5010C")]
		public static bool UPvr_GetJoystickDown(int hand)
		{
			return default(bool);
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xD50338", Offset = "0xD50338", VA = "0xD50338")]
		public static bool UPvr_GetJoystickLeft(int hand)
		{
			return default(bool);
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xD50564", Offset = "0xD50564", VA = "0xD50564")]
		public static bool UPvr_GetJoystickRight(int hand)
		{
			return default(bool);
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xD5078C", Offset = "0xD5078C", VA = "0xD5078C")]
		public static ControllerState UPvr_GetControllerState(int hand)
		{
			return default(ControllerState);
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xD50890", Offset = "0xD50890", VA = "0xD50890")]
		public static Quaternion UPvr_GetControllerQUA(int hand)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xD509A8", Offset = "0xD509A8", VA = "0xD509A8")]
		public static Vector3 UPvr_GetControllerPOS(int hand)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xD50ABC", Offset = "0xD50ABC", VA = "0xD50ABC")]
		public static Quaternion UPvr_GetControllerPredictRotation(int hand, float predictTime)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xD50BA4", Offset = "0xD50BA4", VA = "0xD50BA4")]
		public static Vector3 UPvr_GetControllerPredictPosition(int hand, float predictTime)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xD50CA8", Offset = "0xD50CA8", VA = "0xD50CA8")]
		public static int UPvr_GetControllerTriggerValue(int hand)
		{
			return default(int);
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xD50D78", Offset = "0xD50D78", VA = "0xD50D78")]
		public static int UPvr_GetControllerPower(int hand)
		{
			return default(int);
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xD50E48", Offset = "0xD50E48", VA = "0xD50E48")]
		public static int UPvr_GetControllerPowerByPercent(int hand)
		{
			return default(int);
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xD50F20", Offset = "0xD50F20", VA = "0xD50F20")]
		public static SwipeDirection UPvr_GetSwipeDirection(int hand)
		{
			return default(SwipeDirection);
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xD50FF0", Offset = "0xD50FF0", VA = "0xD50FF0")]
		public static TouchPadClick UPvr_GetTouchPadClick(int hand)
		{
			return default(TouchPadClick);
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xD471AC", Offset = "0xD471AC", VA = "0xD471AC")]
		public static bool UPvr_GetKey(int hand, Pvr_KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xD47820", Offset = "0xD47820", VA = "0xD47820")]
		public static bool UPvr_GetKeyDown(int hand, Pvr_KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xD510C0", Offset = "0xD510C0", VA = "0xD510C0")]
		public static bool UPvr_GetKeyUp(int hand, Pvr_KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xD51734", Offset = "0xD51734", VA = "0xD51734")]
		public static bool UPvr_GetTouch(int hand, Pvr_KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xD51AF8", Offset = "0xD51AF8", VA = "0xD51AF8")]
		public static bool UPvr_GetTouchDown(int hand, Pvr_KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xD51EBC", Offset = "0xD51EBC", VA = "0xD51EBC")]
		public static bool UPvr_GetTouchUp(int hand, Pvr_KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xD52280", Offset = "0xD52280", VA = "0xD52280")]
		public static bool UPvr_GetKeyClick(int hand, Pvr_KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xD528F4", Offset = "0xD528F4", VA = "0xD528F4")]
		public static bool UPvr_GetKeyLongPressed(int hand, Pvr_KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xD48CC4", Offset = "0xD48CC4", VA = "0xD48CC4")]
		public static bool UPvr_IsTouching(int hand)
		{
			return default(bool);
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xD52F68", Offset = "0xD52F68", VA = "0xD52F68")]
		public static void UPvr_SetHandNess(Pvr_Controller.UserHandNess hand)
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xD53028", Offset = "0xD53028", VA = "0xD53028")]
		public static Pvr_Controller.UserHandNess UPvr_GetHandNess()
		{
			return default(Pvr_Controller.UserHandNess);
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xD5309C", Offset = "0xD5309C", VA = "0xD5309C")]
		public static int UPvr_GetPreferenceDevice()
		{
			return default(int);
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xD53158", Offset = "0xD53158", VA = "0xD53158")]
		public static bool UPvr_IsEnbleTrigger()
		{
			return default(bool);
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xD531CC", Offset = "0xD531CC", VA = "0xD531CC")]
		public static int UPvr_GetDeviceType()
		{
			return default(int);
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xD47138", Offset = "0xD47138", VA = "0xD47138")]
		public static int UPvr_GetMainHandNess()
		{
			return default(int);
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xD53240", Offset = "0xD53240", VA = "0xD53240")]
		public static void UPvr_SetMainHandNess(int hand)
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xD532BC", Offset = "0xD532BC", VA = "0xD532BC")]
		public static int UPvr_GetControllerAbility(int hand)
		{
			return default(int);
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xD53338", Offset = "0xD53338", VA = "0xD53338")]
		public static void UPvr_VibrateNeo2Controller(float strength, int time, int hand)
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xD533D4", Offset = "0xD533D4", VA = "0xD533D4")]
		public static void UPvr_VibrateController(float strength, int time, int hand)
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xD53470", Offset = "0xD53470", VA = "0xD53470")]
		public static int UPvr_GetControllerBindingState(int hand)
		{
			return default(int);
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xD534EC", Offset = "0xD534EC", VA = "0xD534EC")]
		public static Vector3 UPvr_GetVelocity(int hand)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xD53568", Offset = "0xD53568", VA = "0xD53568")]
		public static Vector3 UPvr_GetAngularVelocity(int hand)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xD535E4", Offset = "0xD535E4", VA = "0xD535E4")]
		public static Vector3 UPvr_GetAcceleration(int hand)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xD53660", Offset = "0xD53660", VA = "0xD53660")]
		public static void UPvr_ScanController()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xD536D4", Offset = "0xD536D4", VA = "0xD536D4")]
		public static void UPvr_StopScanController()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xD53748", Offset = "0xD53748", VA = "0xD53748")]
		public static void UPvr_ConnectController(string mac)
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xD5380C", Offset = "0xD5380C", VA = "0xD5380C")]
		public static void UPvr_DisConnectController()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xD53880", Offset = "0xD53880", VA = "0xD53880")]
		public static void UPvr_ResetController(int hand)
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xD538FC", Offset = "0xD538FC", VA = "0xD538FC")]
		public static string UPvr_GetControllerVersion()
		{
			return null;
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xD53970", Offset = "0xD53970", VA = "0xD53970")]
		public static void UPvr_GetDeviceVersion(int deviceType)
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xD539EC", Offset = "0xD539EC", VA = "0xD539EC")]
		public static void UPvr_GetControllerSnCode(int controllerSerialNum)
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xD53A68", Offset = "0xD53A68", VA = "0xD53A68")]
		public static void UPvr_SetControllerUnbind(int controllerSerialNum)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xD53AE4", Offset = "0xD53AE4", VA = "0xD53AE4")]
		public static void UPvr_SetStationRestart()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xD53B58", Offset = "0xD53B58", VA = "0xD53B58")]
		public static void UPvr_StartStationOtaUpdate()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xD53BCC", Offset = "0xD53BCC", VA = "0xD53BCC")]
		public static void UPvr_StartControllerOtaUpdate(int mode, int controllerSerialNum)
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xD53C58", Offset = "0xD53C58", VA = "0xD53C58")]
		public static void UPvr_EnterPairMode(int controllerSerialNum)
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xD53CD4", Offset = "0xD53CD4", VA = "0xD53CD4")]
		public static void UPvr_SetControllerShutdown(int controllerSerialNum)
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xD53D50", Offset = "0xD53D50", VA = "0xD53D50")]
		public static int UPvr_GetStationPairState()
		{
			return default(int);
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xD53DC4", Offset = "0xD53DC4", VA = "0xD53DC4")]
		public static int UPvr_GetStationOtaUpdateProgress()
		{
			return default(int);
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xD53E38", Offset = "0xD53E38", VA = "0xD53E38")]
		public static int UPvr_GetControllerOtaUpdateProgress()
		{
			return default(int);
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xD53EAC", Offset = "0xD53EAC", VA = "0xD53EAC")]
		public static void UPvr_GetControllerVersionAndSN(int controllerSerialNum)
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xD53F28", Offset = "0xD53F28", VA = "0xD53F28")]
		public static void UPvr_GetControllerUniqueID()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xD53F9C", Offset = "0xD53F9C", VA = "0xD53F9C")]
		public void UPvr_InterruptStationPairMode()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xD54010", Offset = "0xD54010", VA = "0xD54010")]
		public void UPvr_StartCV2PairingMode(int deviceType)
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xD5408C", Offset = "0xD5408C", VA = "0xD5408C")]
		public void UPvr_StopCV2PairingMode(int deviceType)
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xD54108", Offset = "0xD54108", VA = "0xD54108")]
		public static void UPvr_SetArmModelParameters(int hand, int gazeType, float elbowHeight, float elbowDepth, float pointerTiltAngle)
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xD541C4", Offset = "0xD541C4", VA = "0xD541C4")]
		public static void UPvr_CalcArmModelParameters(float[] headOrientation, float[] controllerOrientation, float[] controllerPrimary)
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xD54278", Offset = "0xD54278", VA = "0xD54278")]
		public static void UPvr_GetPointerPose(float[] rotation, float[] position)
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xD5431C", Offset = "0xD5431C", VA = "0xD5431C")]
		public static void UPvr_GetElbowPose(float[] rotation, float[] position)
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xD543BC", Offset = "0xD543BC", VA = "0xD543BC")]
		public static void UPvr_GetWristPose(float[] rotation, float[] position)
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xD5445C", Offset = "0xD5445C", VA = "0xD5445C")]
		public static void UPvr_GetShoulderPose(float[] rotation, float[] position)
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xD54500", Offset = "0xD54500", VA = "0xD54500")]
		public static void UPvr_IsEnbleHomeKey(bool state)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xD5457C", Offset = "0xD5457C", VA = "0xD5457C")]
		public static void UPvr_SwitchHomeKey(bool state)
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xD545F8", Offset = "0xD545F8", VA = "0xD545F8")]
		public static int UPvr_GetControllerSensorStatus(int id)
		{
			return default(int);
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xD54674", Offset = "0xD54674", VA = "0xD54674")]
		public static void UPvr_SetControllerOriginOffset(int hand, Vector3 offset)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xD541C8", Offset = "0xD541C8", VA = "0xD541C8")]
		private static extern void Pvr_CalcArmModelParameters(float[] headOrientation, float[] controllerOrientation, float[] gyro);

		[PreserveSig]
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xD5427C", Offset = "0xD5427C", VA = "0xD5427C")]
		private static extern void Pvr_GetPointerPose(float[] rotation, float[] position);

		[PreserveSig]
		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xD54320", Offset = "0xD54320", VA = "0xD54320")]
		private static extern void Pvr_GetElbowPose(float[] rotation, float[] position);

		[PreserveSig]
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xD543C0", Offset = "0xD543C0", VA = "0xD543C0")]
		private static extern void Pvr_GetWristPose(float[] rotation, float[] position);

		[PreserveSig]
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xD54460", Offset = "0xD54460", VA = "0xD54460")]
		private static extern void Pvr_GetShoulderPose(float[] rotation, float[] position);

		[PreserveSig]
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xD5410C", Offset = "0xD5410C", VA = "0xD5410C")]
		private static extern void Pvr_SetArmModelParameters(int hand, int gazeType, float elbowHeight, float elbowDepth, float pointerTiltAngle);
	}
	[Token(Token = "0x20000D6")]
	public enum ControllerVariety
	{
		[Token(Token = "0x400083D")]
		Controller0,
		[Token(Token = "0x400083E")]
		Controller1
	}
	[Token(Token = "0x20000D7")]
	public enum ControllerDevice
	{
		[Token(Token = "0x4000840")]
		Goblin,
		[Token(Token = "0x4000841")]
		Neo,
		[Token(Token = "0x4000842")]
		G2,
		[Token(Token = "0x4000843")]
		Neo2,
		[Token(Token = "0x4000844")]
		Neo3,
		[Token(Token = "0x4000845")]
		NewController
	}
	[Token(Token = "0x20000D8")]
	public enum GlobalIntConfigs
	{
		[Token(Token = "0x4000847")]
		EYE_TEXTURE_RESOLUTION0,
		[Token(Token = "0x4000848")]
		EYE_TEXTURE_RESOLUTION1,
		[Token(Token = "0x4000849")]
		SEENSOR_COUNT,
		[Token(Token = "0x400084A")]
		ABILITY6DOF,
		[Token(Token = "0x400084B")]
		PLATFORM_TYPE,
		[Token(Token = "0x400084C")]
		TRACKING_MODE,
		[Token(Token = "0x400084D")]
		LOG_LEVEL,
		[Token(Token = "0x400084E")]
		ENBLE_HAND6DOF_BY_HEAD,
		[Token(Token = "0x400084F")]
		ENBLE_6DOF_GLOBAL_TRACKING,
		[Token(Token = "0x4000850")]
		TARGET_FRAME_RATE,
		[Token(Token = "0x4000851")]
		iShowFPS,
		[Token(Token = "0x4000852")]
		SensorMode,
		[Token(Token = "0x4000853")]
		LOGICFLOW,
		[Token(Token = "0x4000854")]
		EYE_TEXTURE_RES_HIGH,
		[Token(Token = "0x4000855")]
		EYE_TEXTURE_RES_NORMAL,
		[Token(Token = "0x4000856")]
		iCtrlModelLoadingPri,
		[Token(Token = "0x4000857")]
		iPhoneHMDModeEnabled,
		[Token(Token = "0x4000858")]
		isEnableBoundary,
		[Token(Token = "0x4000859")]
		Enable_Activity_Rotation,
		[Token(Token = "0x400085A")]
		GetDisplay_Orientation,
		[Token(Token = "0x400085B")]
		GetWaitFrameNum,
		[Token(Token = "0x400085C")]
		GetResetFrameNum,
		[Token(Token = "0x400085D")]
		EnableFFRBYSYS,
		[Token(Token = "0x400085E")]
		RotControllerMode
	}
	[Token(Token = "0x20000D9")]
	public enum GlobalFloatConfigs
	{
		[Token(Token = "0x4000860")]
		IPD,
		[Token(Token = "0x4000861")]
		VFOV,
		[Token(Token = "0x4000862")]
		HFOV,
		[Token(Token = "0x4000863")]
		NECK_MODEL_X,
		[Token(Token = "0x4000864")]
		NECK_MODEL_Y,
		[Token(Token = "0x4000865")]
		NECK_MODEL_Z,
		[Token(Token = "0x4000866")]
		DISPLAY_REFRESH_RATE
	}
	[Token(Token = "0x20000DA")]
	public enum RenderTextureAntiAliasing
	{
		[Token(Token = "0x4000868")]
		X_1 = 1,
		[Token(Token = "0x4000869")]
		X_2 = 2,
		[Token(Token = "0x400086A")]
		X_4 = 4,
		[Token(Token = "0x400086B")]
		X_8 = 8
	}
	[Token(Token = "0x20000DB")]
	public enum PlatForm
	{
		[Token(Token = "0x400086D")]
		Android = 1,
		[Token(Token = "0x400086E")]
		IOS,
		[Token(Token = "0x400086F")]
		Win,
		[Token(Token = "0x4000870")]
		Notsupport
	}
	[Token(Token = "0x20000DC")]
	public enum RenderTextureDepth
	{
		[Token(Token = "0x4000872")]
		BD_0 = 0,
		[Token(Token = "0x4000873")]
		BD_16 = 16,
		[Token(Token = "0x4000874")]
		BD_24 = 24
	}
	[Token(Token = "0x20000DD")]
	public enum RenderTextureLevel
	{
		[Token(Token = "0x4000876")]
		Normal,
		[Token(Token = "0x4000877")]
		High
	}
	[Token(Token = "0x20000DE")]
	public enum Sensorindex
	{
		[Token(Token = "0x4000879")]
		Default,
		[Token(Token = "0x400087A")]
		FirstSensor,
		[Token(Token = "0x400087B")]
		SecondSensor
	}
	[Token(Token = "0x20000DF")]
	public enum Eye
	{
		[Token(Token = "0x400087D")]
		LeftEye,
		[Token(Token = "0x400087E")]
		RightEye,
		[Token(Token = "0x400087F")]
		BothEye
	}
	[Token(Token = "0x20000E0")]
	public enum ResUtilsType
	{
		[Token(Token = "0x4000881")]
		TYPE_TEXTSIZE,
		[Token(Token = "0x4000882")]
		TYPE_COLOR,
		[Token(Token = "0x4000883")]
		TYPE_TEXT,
		[Token(Token = "0x4000884")]
		TYPE_FONT,
		[Token(Token = "0x4000885")]
		TYPE_VALUE,
		[Token(Token = "0x4000886")]
		TYPE_DRAWABLE,
		[Token(Token = "0x4000887")]
		TYPE_OBJECT,
		[Token(Token = "0x4000888")]
		TYPR_OBJECTARRAY
	}
	[Token(Token = "0x20000E1")]
	public enum TrackingOrigin
	{
		[Token(Token = "0x400088A")]
		EyeLevel,
		[Token(Token = "0x400088B")]
		FloorLevel,
		[Token(Token = "0x400088C")]
		StageLevel
	}
	[Token(Token = "0x20000E2")]
	public enum EFoveationLevel
	{
		[Token(Token = "0x400088E")]
		Low,
		[Token(Token = "0x400088F")]
		Med,
		[Token(Token = "0x4000890")]
		High,
		[Token(Token = "0x4000891")]
		Top_High
	}
	[Token(Token = "0x20000E3")]
	public enum StereoRenderingPathPico
	{
		[Token(Token = "0x4000893")]
		MultiPass,
		[Token(Token = "0x4000894")]
		SinglePass
	}
	[Token(Token = "0x20000E4")]
	public enum ExtraLatencyMode
	{
		[Token(Token = "0x4000896")]
		ExtraLatencyModeOff,
		[Token(Token = "0x4000897")]
		ExtraLatencyModeOn,
		[Token(Token = "0x4000898")]
		ExtraLatencyModeDynamic
	}
	[Token(Token = "0x20000E5")]
	public enum pvrEyePoseStatus
	{
		[Token(Token = "0x400089A")]
		kGazePointValid = 1,
		[Token(Token = "0x400089B")]
		kGazeVectorValid = 2,
		[Token(Token = "0x400089C")]
		kEyeOpennessValid = 4,
		[Token(Token = "0x400089D")]
		kEyePupilDilationValid = 8,
		[Token(Token = "0x400089E")]
		kEyePositionGuideValid = 0x10
	}
	[Token(Token = "0x20000E6")]
	public enum TrackingMode
	{
		[Token(Token = "0x40008A0")]
		PVR_TRACKING_MODE_ROTATION = 1,
		[Token(Token = "0x40008A1")]
		PVR_TRACKING_MODE_POSITION = 2,
		[Token(Token = "0x40008A2")]
		PVR_TRACKING_MODE_EYE = 4
	}
	[Token(Token = "0x20000E7")]
	public struct EyeTrackingData
	{
		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int leftEyePoseStatus;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int rightEyePoseStatus;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int combinedEyePoseStatus;

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 leftEyeGazePoint;

		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 rightEyeGazePoint;

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 combinedEyeGazePoint;

		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 leftEyeGazeVector;

		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rightEyeGazeVector;

		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 combinedEyeGazeVector;

		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float leftEyeOpenness;

		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float rightEyeOpenness;

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float leftEyePupilDilation;

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float rightEyePupilDilation;

		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector3 leftEyePositionGuide;

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector3 rightEyePositionGuide;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public Vector3 foveatedGazeDirection;

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public int foveatedGazeTrackingState;

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public byte[] reserved;
	}
	[Token(Token = "0x20000E8")]
	public struct EyeTrackingGazeRay
	{
		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 Direction;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool IsValid;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Origin;
	}
	[Token(Token = "0x20000E9")]
	public struct EyeDeviceInfo
	{
		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ViewFrustum targetFrustumLeft;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ViewFrustum targetFrustumRight;
	}
	[Token(Token = "0x20000EA")]
	public struct ViewFrustum
	{
		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float left;

		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float right;

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float top;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float bottom;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float near;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float far;
	}
	[Token(Token = "0x20000EB")]
	public struct EyeSetting
	{
		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform eyelocalPosition;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Rect eyeRect;

		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float eyeFov;

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float eyeAspect;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Matrix4x4 eyeProjectionMatrix;

		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Shader eyeShader;
	}
	[Token(Token = "0x20000EC")]
	public struct Sensor
	{
		[Token(Token = "0x40008C6")]
		public const string LibFileName = "Pvr_UnitySDK";

		[PreserveSig]
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xD57144", Offset = "0xD57144", VA = "0xD57144")]
		private static extern int Pvr_Enable6DofModule(bool enable);

		[PreserveSig]
		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xD571C4", Offset = "0xD571C4", VA = "0xD571C4")]
		private static extern int Pvr_OptionalResetSensor(int index, int resetRot, int resetPos);

		[PreserveSig]
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xD57258", Offset = "0xD57258", VA = "0xD57258")]
		private static extern int Pvr_Init(int index);

		[PreserveSig]
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xD572D8", Offset = "0xD572D8", VA = "0xD572D8")]
		private static extern int Pvr_StartSensor(int index);

		[PreserveSig]
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xD57358", Offset = "0xD57358", VA = "0xD57358")]
		private static extern int Pvr_StopSensor(int index);

		[PreserveSig]
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xD573D8", Offset = "0xD573D8", VA = "0xD573D8")]
		private static extern int Pvr_ResetSensor(int index);

		[PreserveSig]
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xD57458", Offset = "0xD57458", VA = "0xD57458")]
		private static extern int Pvr_ResetSensorAll(int index);

		[PreserveSig]
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xD574D8", Offset = "0xD574D8", VA = "0xD574D8")]
		private static extern int Pvr_GetSensorState(int index, ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz);

		[PreserveSig]
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xD575B0", Offset = "0xD575B0", VA = "0xD575B0")]
		private static extern int Pvr_GetMainSensorState(ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz, ref float vfov, ref float hfov, ref int viewNumber);

		[PreserveSig]
		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xD57694", Offset = "0xD57694", VA = "0xD57694")]
		private static extern int Pvr_GetPsensorState();

		[PreserveSig]
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xD57708", Offset = "0xD57708", VA = "0xD57708")]
		private static extern int Pvr_GetHmdPSensorStatus();

		[PreserveSig]
		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xD5777C", Offset = "0xD5777C", VA = "0xD5777C")]
		private static extern int Pvr_GetSensorGyroscope(int index, ref float x, ref float y, ref float z);

		[PreserveSig]
		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xD57824", Offset = "0xD57824", VA = "0xD57824")]
		private static extern int Pvr_GetSensorMagnet(int index, ref float x, ref float y, ref float z);

		[PreserveSig]
		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xD578CC", Offset = "0xD578CC", VA = "0xD578CC")]
		private static extern int Pvr_Get6DofSensorQualityStatus();

		[PreserveSig]
		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xD57940", Offset = "0xD57940", VA = "0xD57940")]
		private static extern bool Pvr_Get6DofSafePanelFlag();

		[PreserveSig]
		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xD579BC", Offset = "0xD579BC", VA = "0xD579BC")]
		private static extern void Pvr_SetReinPosition(float x, float y, float z, float w, float px, float py, float pz, int hand, bool valid, int key);

		[PreserveSig]
		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xD57AAC", Offset = "0xD57AAC", VA = "0xD57AAC")]
		private static extern bool Pvr_SetTrackingOriginType(TrackingOrigin trackingOriginType);

		[PreserveSig]
		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xD57B34", Offset = "0xD57B34", VA = "0xD57B34")]
		private static extern bool Pvr_GetAcceleration(ref float x, ref float y, ref float z);

		[PreserveSig]
		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xD57BD4", Offset = "0xD57BD4", VA = "0xD57BD4")]
		private static extern bool Pvr_GetAngularVelocity(ref float x, ref float y, ref float z);

		[PreserveSig]
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xD57C74", Offset = "0xD57C74", VA = "0xD57C74")]
		private static extern bool Pvr_GetVelocity(ref float x, ref float y, ref float z);

		[PreserveSig]
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xD57D14", Offset = "0xD57D14", VA = "0xD57D14")]
		private static extern bool Pvr_GetAngularAcceleration(ref float x, ref float y, ref float z);

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xD57DB4", Offset = "0xD57DB4", VA = "0xD57DB4")]
		public static bool UPvr_Pvr_Get6DofSafePanelFlag()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xD57DB8", Offset = "0xD57DB8", VA = "0xD57DB8")]
		public static int UPvr_Init(int index)
		{
			return default(int);
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xD57DBC", Offset = "0xD57DBC", VA = "0xD57DBC")]
		public static void UPvr_InitPsensor()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xD57FA4", Offset = "0xD57FA4", VA = "0xD57FA4")]
		public static int UPvr_GetPsensorState()
		{
			return default(int);
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xD58200", Offset = "0xD58200", VA = "0xD58200")]
		public static int UPvr_GetPSensorStatus()
		{
			return default(int);
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xD58204", Offset = "0xD58204", VA = "0xD58204")]
		public static void UPvr_UnregisterPsensor()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xD583FC", Offset = "0xD583FC", VA = "0xD583FC")]
		public static int UPvr_StartSensor(int index)
		{
			return default(int);
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xD58400", Offset = "0xD58400", VA = "0xD58400")]
		public static int UPvr_StopSensor(int index)
		{
			return default(int);
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xD58404", Offset = "0xD58404", VA = "0xD58404")]
		public static int UPvr_ResetSensor(int index)
		{
			return default(int);
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xD58480", Offset = "0xD58480", VA = "0xD58480")]
		public static int UPvr_OptionalResetSensor(int index, int resetRot, int resetPos)
		{
			return default(int);
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xD58484", Offset = "0xD58484", VA = "0xD58484")]
		public static int UPvr_GetSensorState(int index, ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz)
		{
			return default(int);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xD58488", Offset = "0xD58488", VA = "0xD58488")]
		public static int UPvr_GetMainSensorState(ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz, ref float vfov, ref float hfov, ref int viewNumber)
		{
			return default(int);
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xD58494", Offset = "0xD58494", VA = "0xD58494")]
		public static int UPvr_GetSensorGyroscope(int index, ref float x, ref float y, ref float z)
		{
			return default(int);
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xD58498", Offset = "0xD58498", VA = "0xD58498")]
		public static int UPvr_GetSensorMagnet(int index, ref float x, ref float y, ref float z)
		{
			return default(int);
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xD5849C", Offset = "0xD5849C", VA = "0xD5849C")]
		public static int UPvr_Get6DofSensorQualityStatus()
		{
			return default(int);
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xD584A0", Offset = "0xD584A0", VA = "0xD584A0")]
		public static int UPvr_Enable6DofModule(bool enable)
		{
			return default(int);
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xD57DC0", Offset = "0xD57DC0", VA = "0xD57DC0")]
		public static void Pvr_InitPsensor()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xD586B8", Offset = "0xD586B8", VA = "0xD586B8")]
		public static bool Pvr_IsHead6dofReset()
		{
			return default(bool);
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xD57FF8", Offset = "0xD57FF8", VA = "0xD57FF8")]
		public static int Pvr_GetAndroidPsensorState()
		{
			return default(int);
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xD58208", Offset = "0xD58208", VA = "0xD58208")]
		public static void Pvr_UnregisterPsensor()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xD588D8", Offset = "0xD588D8", VA = "0xD588D8")]
		public static int UPvr_ResetSensorAll(int index)
		{
			return default(int);
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xD588DC", Offset = "0xD588DC", VA = "0xD588DC")]
		public static void UPvr_SetReinPosition(float x, float y, float z, float w, float px, float py, float pz, int hand, bool valid, int key)
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xD58CE8", Offset = "0xD58CE8", VA = "0xD58CE8")]
		public static bool UPvr_SetTrackingOriginType(TrackingOrigin trackingOriginType)
		{
			return default(bool);
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xD58CEC", Offset = "0xD58CEC", VA = "0xD58CEC")]
		public static Vector3 UPvr_GetAcceleration()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xD58D48", Offset = "0xD58D48", VA = "0xD58D48")]
		public static Vector3 UPvr_AngularVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xD58D9C", Offset = "0xD58D9C", VA = "0xD58D9C")]
		public static Vector3 UPvr_GetVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xD58DF8", Offset = "0xD58DF8", VA = "0xD58DF8")]
		public static Vector3 UPvr_GetAngularAcceleration()
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000ED")]
	public struct Render
	{
		[Token(Token = "0x40008C7")]
		public const string LibFileName = "Pvr_UnitySDK";

		[PreserveSig]
		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xD55900", Offset = "0xD55900", VA = "0xD55900")]
		private static extern void Pvr_ChangeScreenParameters(string model, int width, int height, double xppi, double yppi, double densityDpi);

		[PreserveSig]
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xD559D0", Offset = "0xD559D0", VA = "0xD559D0")]
		private static extern int Pvr_SetRatio(float midH, float midV);

		[PreserveSig]
		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xD55A5C", Offset = "0xD55A5C", VA = "0xD55A5C")]
		private static extern int Pvr_SetPupillaryPoint(bool enable);

		[PreserveSig]
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xD55ADC", Offset = "0xD55ADC", VA = "0xD55ADC")]
		private static extern IntPtr Pvr_GetSupportHMDTypes();

		[PreserveSig]
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xD55B50", Offset = "0xD55B50", VA = "0xD55B50")]
		private static extern void Pvr_SetCurrentHMDType(string type);

		[PreserveSig]
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xD55BE0", Offset = "0xD55BE0", VA = "0xD55BE0")]
		private static extern int Pvr_GetIntConfig(int configsenum, ref int res);

		[PreserveSig]
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xD55C6C", Offset = "0xD55C6C", VA = "0xD55C6C")]
		private static extern int Pvr_GetFloatConfig(int configsenum, ref float res);

		[PreserveSig]
		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xD55CF8", Offset = "0xD55CF8", VA = "0xD55CF8")]
		private static extern void Pvr_SetupLayerData(int layerIndex, int sideMask, int textureId, int textureType, int layerFlags, float[] colorScaleAndOffset);

		[PreserveSig]
		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xD55DC0", Offset = "0xD55DC0", VA = "0xD55DC0")]
		private static extern void Pvr_SetupLayerCoords(int layerIndex, int sideMask, float[] lowerLeft, float[] lowerRight, float[] upperLeft, float[] upperRight);

		[PreserveSig]
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xD55EA0", Offset = "0xD55EA0", VA = "0xD55EA0")]
		private static extern void Pvr_SetOverlayModelViewMatrix(int overlayType, int overlayShape, int texId, int eyeSide, int layerIndex, bool isHeadLocked, int layerFlags, float[] mvMatrix, float[] modelS, float[] modelR, float[] modelT, float[] cameraR, float[] cameraT, float[] colorScaleAndOffset);

		[PreserveSig]
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xD55FDC", Offset = "0xD55FDC", VA = "0xD55FDC")]
		private static extern bool Pvr_EnableFoveation(bool enable);

		[PreserveSig]
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xD56064", Offset = "0xD56064", VA = "0xD56064")]
		private static extern void Pvr_SetFoveationParameters(int textureId, int previousId, float focalPointX, float focalPointY, float foveationGainX, float foveationGainY, float foveationArea, float foveationMinimum);

		[PreserveSig]
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xD5613C", Offset = "0xD5613C", VA = "0xD5613C")]
		private static extern void Pvr_SetFoveationResource(int textureId, int previousId, float focalPointX, float focalPointY);

		[PreserveSig]
		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xD561E4", Offset = "0xD561E4", VA = "0xD561E4")]
		private static extern void Pvr_SetFoveationParameters2(float foveationGainX, float foveationGainY, float foveationArea, float foveationMinimum);

		[PreserveSig]
		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xD56288", Offset = "0xD56288", VA = "0xD56288")]
		private static extern void Pvr_SetFoveationLevel(EFoveationLevel level);

		[PreserveSig]
		[Token(Token = "0x6000700")]
		[Address(RVA = "0xD56308", Offset = "0xD56308", VA = "0xD56308")]
		private static extern EFoveationLevel Pvr_GetFoveationLevel();

		[PreserveSig]
		[Token(Token = "0x6000701")]
		[Address(RVA = "0xD5637C", Offset = "0xD5637C", VA = "0xD5637C")]
		private static extern bool Pvr_GetIntSysProc(string property, ref int res);

		[PreserveSig]
		[Token(Token = "0x6000702")]
		[Address(RVA = "0xD56428", Offset = "0xD56428", VA = "0xD56428")]
		private static extern void Pvr_SetColorspaceType(int colorspaceType);

		[PreserveSig]
		[Token(Token = "0x6000703")]
		[Address(RVA = "0xD564A8", Offset = "0xD564A8", VA = "0xD564A8")]
		private static extern void Pvr_SetCastingColorspaceType(int colorspaceType);

		[PreserveSig]
		[Token(Token = "0x6000704")]
		[Address(RVA = "0xD56528", Offset = "0xD56528", VA = "0xD56528")]
		private static extern IntPtr Pvr_CreateLayerAndroidSurface(int layerType, int layerIndex);

		[PreserveSig]
		[Token(Token = "0x6000705")]
		[Address(RVA = "0xD565B8", Offset = "0xD565B8", VA = "0xD565B8")]
		private static extern IntPtr Pvr_GetLayerAndroidSurface(int layerType, int layerIndex);

		[PreserveSig]
		[Token(Token = "0x6000706")]
		[Address(RVA = "0xD56648", Offset = "0xD56648", VA = "0xD56648")]
		private static extern void Pvr_SetMonoMode(bool openMono);

		[PreserveSig]
		[Token(Token = "0x6000707")]
		[Address(RVA = "0xD566C8", Offset = "0xD566C8", VA = "0xD566C8")]
		private static extern void Pvr_GetStencilMesh(int eye, ref int vertexCount, ref int triangleCount, ref IntPtr vertexData, ref IntPtr indexData);

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xD56778", Offset = "0xD56778", VA = "0xD56778")]
		public static void UPvr_ChangeScreenParameters(string model, int width, int height, double xppi, double yppi, double densityDpi)
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xD5677C", Offset = "0xD5677C", VA = "0xD5677C")]
		public static int UPvr_SetRatio(float midH, float midV)
		{
			return default(int);
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xD56780", Offset = "0xD56780", VA = "0xD56780")]
		public static void UPvr_EnableFoveation(bool enable)
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xD56834", Offset = "0xD56834", VA = "0xD56834")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x802F54", Offset = "0x802F54")]
		public static void UPvr_SetFoveationParameters(int textureId, int previousId, float focalPointX, float focalPointY, float foveationGainX, float foveationGainY, float foveationArea, float foveationMinimum)
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xD56838", Offset = "0xD56838", VA = "0xD56838")]
		public static void UPvr_SetFoveationResource(int textureId, int previousId, float focalPointX, float focalPointY)
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xD5683C", Offset = "0xD5683C", VA = "0xD5683C")]
		public static void SetFoveatedRenderingLevel(EFoveationLevel level)
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xD56940", Offset = "0xD56940", VA = "0xD56940")]
		public static EFoveationLevel GetFoveatedRenderingLevel()
		{
			return default(EFoveationLevel);
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xD56944", Offset = "0xD56944", VA = "0xD56944")]
		public static void SetFoveatedRenderingParameters(Vector2 ffrGainValue, float ffrAreaValue, float ffrMinimumValue)
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xD56A80", Offset = "0xD56A80", VA = "0xD56A80")]
		public static bool UPvr_GetIntSysProc(string property, ref int res)
		{
			return default(bool);
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xD56A84", Offset = "0xD56A84", VA = "0xD56A84")]
		public static int UPvr_GetIntConfig(int configsenum, ref int res)
		{
			return default(int);
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xD56A88", Offset = "0xD56A88", VA = "0xD56A88")]
		public static int UPvr_GetFloatConfig(int configsenum, ref float res)
		{
			return default(int);
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xD56A8C", Offset = "0xD56A8C", VA = "0xD56A8C")]
		public static string UPvr_GetSupportHMDTypes()
		{
			return null;
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xD56B18", Offset = "0xD56B18", VA = "0xD56B18")]
		public static void UPvr_SetCurrentHMDType(string type)
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xD56B1C", Offset = "0xD56B1C", VA = "0xD56B1C")]
		public static void UPvr_SetupLayerData(int layerIndex, int sideMask, int textureId, int textureType, int layerFlags, Vector4 colorScale, Vector4 colorOffset)
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xD56C5C", Offset = "0xD56C5C", VA = "0xD56C5C")]
		public static void UPvr_SetupLayerCoords(int layerIndex, int sideMask, float[] lowerLeft, float[] lowerRight, float[] upperLeft, float[] upperRight)
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xD56C60", Offset = "0xD56C60", VA = "0xD56C60")]
		public static void UPvr_SetOverlayModelViewMatrix(int overlayType, int overlayShape, int texId, int eyeSide, int layerIndex, bool isHeadLocked, int layerFlags, Matrix4x4 mvMatrix, Vector3 modelS, Quaternion modelR, Vector3 modelT, Quaternion cameraR, Vector3 cameraT, Vector4 colorScale, Vector4 colorOffset)
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xD5712C", Offset = "0xD5712C", VA = "0xD5712C")]
		public static void UPvr_SetColorspaceType(int colorspaceType)
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xD57130", Offset = "0xD57130", VA = "0xD57130")]
		public static void UPvr_SetCastingColorspaceType(int colorspaceType)
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xD57134", Offset = "0xD57134", VA = "0xD57134")]
		public static IntPtr UPvr_CreateLayerAndroidSurface(int layerType, int layerIndex)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xD57138", Offset = "0xD57138", VA = "0xD57138")]
		public static IntPtr UPvr_GetLayerAndroidSurface(int layerType, int layerIndex)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xD5713C", Offset = "0xD5713C", VA = "0xD5713C")]
		public static void UPvr_SetMonoMode(bool openMono)
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xD4E0E0", Offset = "0xD4E0E0", VA = "0xD4E0E0")]
		public static void UPvr_GetStencilMesh(int eye, ref int vertexCount, ref int triangleCount, ref IntPtr vertexDataPtr, ref IntPtr indexDataPtr)
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public struct System
	{
		[Token(Token = "0x40008C8")]
		public const string LibFileName = "Pvr_UnitySDK";

		[Token(Token = "0x40008C9")]
		public const string UnitySDKVersion = "2.8.10.4";

		[PreserveSig]
		[Token(Token = "0x600071E")]
		[Address(RVA = "0xD58E4C", Offset = "0xD58E4C", VA = "0xD58E4C")]
		public static extern void Pvr_SetInitActivity(IntPtr activity, IntPtr vrActivityClass);

		[PreserveSig]
		[Token(Token = "0x600071F")]
		[Address(RVA = "0xD58EDC", Offset = "0xD58EDC", VA = "0xD58EDC")]
		private static extern IntPtr Pvr_GetSDKVersion();

		[PreserveSig]
		[Token(Token = "0x6000720")]
		[Address(RVA = "0xD58F50", Offset = "0xD58F50", VA = "0xD58F50")]
		public static extern int Pvr_GetHmdHardwareVersion();

		[PreserveSig]
		[Token(Token = "0x6000721")]
		[Address(RVA = "0xD58FC4", Offset = "0xD58FC4", VA = "0xD58FC4")]
		public static extern IntPtr Pvr_GetHmdFirmwareVersion();

		[PreserveSig]
		[Token(Token = "0x6000722")]
		[Address(RVA = "0xD59038", Offset = "0xD59038", VA = "0xD59038")]
		public static extern IntPtr Pvr_GetHmdSerialNumber();

		[PreserveSig]
		[Token(Token = "0x6000723")]
		[Address(RVA = "0xD590AC", Offset = "0xD590AC", VA = "0xD590AC")]
		public static extern int PVR_GetHmdBatteryStatus();

		[PreserveSig]
		[Token(Token = "0x6000724")]
		[Address(RVA = "0xD59120", Offset = "0xD59120", VA = "0xD59120")]
		public static extern float PVR_GetHmdBatteryTemperature();

		[PreserveSig]
		[Token(Token = "0x6000725")]
		[Address(RVA = "0xD59190", Offset = "0xD59190", VA = "0xD59190")]
		public static extern int PVR_SetHmdAudioStatus(bool enable);

		[PreserveSig]
		[Token(Token = "0x6000726")]
		[Address(RVA = "0xD59210", Offset = "0xD59210", VA = "0xD59210")]
		public static extern bool Pvr_GetEyeTrackingData(ref int leftEyePoseStatus, ref int rightEyePoseStatus, ref int combinedEyePoseStatus, ref float leftEyeGazePointX, ref float leftEyeGazePointY, ref float leftEyeGazePointZ, ref float rightEyeGazePointX, ref float rightEyeGazePointY, ref float rightEyeGazePointZ, ref float combinedEyeGazePointX, ref float combinedEyeGazePointY, ref float combinedEyeGazePointZ, ref float leftEyeGazeVectorX, ref float leftEyeGazeVectorY, ref float leftEyeGazeVectorZ, ref float rightEyeGazeVectorX, ref float rightEyeGazeVectorY, ref float rightEyeGazeVectorZ, ref float combinedEyeGazeVectorX, ref float combinedEyeGazeVectorY, ref float combinedEyeGazeVectorZ, ref float leftEyeOpenness, ref float rightEyeOpenness, ref float leftEyePupilDilation, ref float rightEyePupilDilation, ref float leftEyePositionGuideX, ref float leftEyePositionGuideY, ref float leftEyePositionGuideZ, ref float rightEyePositionGuideX, ref float rightEyePositionGuideY, ref float rightEyePositionGuideZ, ref float foveatedGazeDirectionX, ref float foveatedGazeDirectionY, ref float foveatedGazeDirectionZ, ref int foveatedGazeTrackingState);

		[PreserveSig]
		[Token(Token = "0x6000727")]
		[Address(RVA = "0xD59400", Offset = "0xD59400", VA = "0xD59400")]
		public static extern bool Pvr_SetTrackingMode(int trackingMode);

		[PreserveSig]
		[Token(Token = "0x6000728")]
		[Address(RVA = "0xD59488", Offset = "0xD59488", VA = "0xD59488")]
		public static extern int Pvr_GetTrackingMode();

		[PreserveSig]
		[Token(Token = "0x6000729")]
		[Address(RVA = "0xD594FC", Offset = "0xD594FC", VA = "0xD594FC")]
		public static extern IntPtr GetRenderEventFunc();

		[PreserveSig]
		[Token(Token = "0x600072A")]
		[Address(RVA = "0xD59570", Offset = "0xD59570", VA = "0xD59570")]
		public static extern void UnityEventData(long data);

		[PreserveSig]
		[Token(Token = "0x600072B")]
		[Address(RVA = "0xD595F0", Offset = "0xD595F0", VA = "0xD595F0")]
		public static extern bool Pvr_EnableSinglePass(bool enable);

		[PreserveSig]
		[Token(Token = "0x600072C")]
		[Address(RVA = "0xD59678", Offset = "0xD59678", VA = "0xD59678")]
		public static extern void Pvr_SetAntiAliasing(int antiAliasing);

		[PreserveSig]
		[Token(Token = "0x600072D")]
		[Address(RVA = "0xD596F8", Offset = "0xD596F8", VA = "0xD596F8")]
		public static extern void Pvr_SinglePassBeforeForwardOpaque();

		[PreserveSig]
		[Token(Token = "0x600072E")]
		[Address(RVA = "0xD59768", Offset = "0xD59768", VA = "0xD59768")]
		public static extern void Pvr_SetCurrentRenderTexture(uint textureId);

		[PreserveSig]
		[Token(Token = "0x600072F")]
		[Address(RVA = "0xD597E8", Offset = "0xD597E8", VA = "0xD597E8")]
		public static extern bool Pvr_SetSinglePassDepthBufferWidthHeight(int width, int height);

		[PreserveSig]
		[Token(Token = "0x6000730")]
		[Address(RVA = "0xD59880", Offset = "0xD59880", VA = "0xD59880")]
		public static extern int PVR_setPerformanceLevels(int cpuLevel, int gpuLevel);

		[PreserveSig]
		[Token(Token = "0x6000731")]
		[Address(RVA = "0xD59910", Offset = "0xD59910", VA = "0xD59910")]
		public static extern bool Pvr_SetIPD(float distance);

		[PreserveSig]
		[Token(Token = "0x6000732")]
		[Address(RVA = "0xD599A0", Offset = "0xD599A0", VA = "0xD599A0")]
		public static extern float Pvr_GetIPD();

		[PreserveSig]
		[Token(Token = "0x6000733")]
		[Address(RVA = "0xD59A10", Offset = "0xD59A10", VA = "0xD59A10")]
		public static extern bool Pvr_SetTrackingIPDEnabled(bool enable);

		[PreserveSig]
		[Token(Token = "0x6000734")]
		[Address(RVA = "0xD59A98", Offset = "0xD59A98", VA = "0xD59A98")]
		public static extern bool Pvr_GetTrackingIPDEnabled();

		[PreserveSig]
		[Token(Token = "0x6000735")]
		[Address(RVA = "0xD59B14", Offset = "0xD59B14", VA = "0xD59B14")]
		public static extern bool Pvr_GetEyeTrackingAutoIPD(ref float autoIPD);

		[PreserveSig]
		[Token(Token = "0x6000736")]
		[Address(RVA = "0xD5588C", Offset = "0xD5588C", VA = "0xD5588C")]
		public static extern int PVR_GetHmdAudioStatus();

		[PreserveSig]
		[Token(Token = "0x6000737")]
		[Address(RVA = "0xD59B9C", Offset = "0xD59B9C", VA = "0xD59B9C")]
		private static extern float Pvr_GetPredictedDisplayTime();

		[PreserveSig]
		[Token(Token = "0x6000738")]
		[Address(RVA = "0xD59C0C", Offset = "0xD59C0C", VA = "0xD59C0C")]
		public static extern bool Pvr_SetExtraLatencyMode(int mode);

		[Token(Token = "0x6000739")]
		public static bool UPvr_CallStaticMethod<T>(ref T result, AndroidJavaClass jclass, string name, params object[] args)
		{
			return default(bool);
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0xD584A8", Offset = "0xD584A8", VA = "0xD584A8")]
		public static bool UPvr_CallStaticMethod(AndroidJavaObject jobj, string name, params object[] args)
		{
			return default(bool);
		}

		[Token(Token = "0x600073B")]
		public static bool UPvr_CallMethod<T>(ref T result, AndroidJavaObject jobj, string name, params object[] args)
		{
			return default(bool);
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0xD59C94", Offset = "0xD59C94", VA = "0xD59C94")]
		public static bool UPvr_CallMethod(AndroidJavaObject jobj, string name, params object[] args)
		{
			return default(bool);
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0xD59EA4", Offset = "0xD59EA4", VA = "0xD59EA4")]
		public static string UPvr_GetSDKVersion()
		{
			return null;
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xD59F38", Offset = "0xD59F38", VA = "0xD59F38")]
		public static string UPvr_GetUnitySDKVersion()
		{
			return null;
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xD59F80", Offset = "0xD59F80", VA = "0xD59F80")]
		public static string UPvr_GetDeviceMode()
		{
			return null;
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0xD59F88", Offset = "0xD59F88", VA = "0xD59F88")]
		public static string UPvr_GetDeviceModel()
		{
			return null;
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xD54B24", Offset = "0xD54B24", VA = "0xD54B24")]
		public static string UPvr_GetDeviceSN()
		{
			return null;
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0xD54F38", Offset = "0xD54F38", VA = "0xD54F38")]
		public static AndroidJavaObject UPvr_GetCurrentActivity()
		{
			return null;
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xD59F90", Offset = "0xD59F90", VA = "0xD59F90")]
		public static bool UPvr_SetMonoPresentation()
		{
			return default(bool);
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0xD5A078", Offset = "0xD5A078", VA = "0xD5A078")]
		public static bool UPvr_IsPresentationExisted()
		{
			return default(bool);
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xD5A184", Offset = "0xD5A184", VA = "0xD5A184")]
		public static bool UPvr_GetMainActivityPauseStatus()
		{
			return default(bool);
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xD5A290", Offset = "0xD5A290", VA = "0xD5A290")]
		public static void UPvr_Sleep()
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xD5A39C", Offset = "0xD5A39C", VA = "0xD5A39C")]
		public static bool UPvr_StartHomeKeyReceiver(string startreceivre)
		{
			return default(bool);
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0xD5A624", Offset = "0xD5A624", VA = "0xD5A624")]
		public static bool UPvr_StopHomeKeyReceiver()
		{
			return default(bool);
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xD5A864", Offset = "0xD5A864", VA = "0xD5A864")]
		public static void UPvr_StartVRModel()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xD5A970", Offset = "0xD5A970", VA = "0xD5A970")]
		public static void UPvr_RemovePlatformLogo()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xD5AA7C", Offset = "0xD5AA7C", VA = "0xD5AA7C")]
		public static void UPvr_ShowPlatformLogo()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xD5AB88", Offset = "0xD5AB88", VA = "0xD5AB88")]
		public static bool UPvr_IsPicoActivity()
		{
			return default(bool);
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0xD5AC94", Offset = "0xD5AC94", VA = "0xD5AC94")]
		public static void UPvr_StopVRModel()
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0xD5ADA0", Offset = "0xD5ADA0", VA = "0xD5ADA0")]
		public static string UPvr_GetCountryCode()
		{
			return null;
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0xD5AEB0", Offset = "0xD5AEB0", VA = "0xD5AEB0")]
		public static bool UPvr_SetIPD(float distance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xD5AFC8", Offset = "0xD5AFC8", VA = "0xD5AFC8")]
		public static float UPvr_GetIPD()
		{
			return default(float);
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xD5B088", Offset = "0xD5B088", VA = "0xD5B088")]
		public static bool UPvr_SetTrackingIPDEnabled(bool enable)
		{
			return default(bool);
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xD5B090", Offset = "0xD5B090", VA = "0xD5B090")]
		public static bool UPvr_GetTrackingIPDEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xD5B094", Offset = "0xD5B094", VA = "0xD5B094")]
		public static bool UPvr_GetEyeTrackingAutoIPD(ref float autoipd)
		{
			return default(bool);
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xD4F628", Offset = "0xD4F628", VA = "0xD4F628")]
		public static void UPvr_UnityEventData(long data)
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xD5B098", Offset = "0xD5B098", VA = "0xD5B098")]
		public static long UPvr_GetEyeBufferData(int id)
		{
			return default(long);
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0xD5B114", Offset = "0xD5B114", VA = "0xD5B114")]
		public static bool UPvr_checkDevice(string packagename)
		{
			return default(bool);
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xD5B244", Offset = "0xD5B244", VA = "0xD5B244")]
		public static int UPvr_GetHmdHardwareVersion()
		{
			return default(int);
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xD5B248", Offset = "0xD5B248", VA = "0xD5B248")]
		public static string UPvr_GetHmdFirmwareVersion()
		{
			return null;
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0xD5B2DC", Offset = "0xD5B2DC", VA = "0xD5B2DC")]
		public static string UPvr_GetHmdSerialNumber()
		{
			return null;
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0xD5B370", Offset = "0xD5B370", VA = "0xD5B370")]
		public static int UPvr_GetHmdBatteryStatus()
		{
			return default(int);
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0xD5B374", Offset = "0xD5B374", VA = "0xD5B374")]
		public static float UPvr_GetHmdBatteryTemperature()
		{
			return default(float);
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xD5B378", Offset = "0xD5B378", VA = "0xD5B378")]
		public static int UPvr_SetHmdAudioStatus(bool enable)
		{
			return default(int);
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0xD5B380", Offset = "0xD5B380", VA = "0xD5B380")]
		public static int UPvr_GetTrackingMode()
		{
			return default(int);
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0xD5B384", Offset = "0xD5B384", VA = "0xD5B384")]
		public static bool UPvr_setTrackingMode(int trackingMode)
		{
			return default(bool);
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0xD5B388", Offset = "0xD5B388", VA = "0xD5B388")]
		public static bool UPvr_getEyeTrackingData(ref EyeTrackingData trackingData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0xD5B5F4", Offset = "0xD5B5F4", VA = "0xD5B5F4")]
		public static bool UPvr_getEyeTrackingGazeRay(ref EyeTrackingGazeRay gazeRay)
		{
			return default(bool);
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xD5B824", Offset = "0xD5B824", VA = "0xD5B824")]
		public static bool UPvr_getEyeTrackingGazeRayWorld(ref EyeTrackingGazeRay gazeRay)
		{
			return default(bool);
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0xD5BAFC", Offset = "0xD5BAFC", VA = "0xD5BAFC")]
		public static Vector3 UPvr_getEyeTrackingPos()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0xD5BC4C", Offset = "0xD5BC4C", VA = "0xD5BC4C")]
		public static int UPvr_GetPhoneScreenBrightness()
		{
			return default(int);
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0xD5BD50", Offset = "0xD5BD50", VA = "0xD5BD50")]
		public static void UPvr_SetPhoneScreenBrightness(int level)
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0xD5BE8C", Offset = "0xD5BE8C", VA = "0xD5BE8C")]
		public static bool UPvr_IsPicoDefaultActivity()
		{
			return default(bool);
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0xD5C1AC", Offset = "0xD5C1AC", VA = "0xD5C1AC")]
		public static bool UPvr_EnableSinglePass(bool enable)
		{
			return default(bool);
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0xD5C1B4", Offset = "0xD5C1B4", VA = "0xD5C1B4")]
		public static void UPvr_SetAntiAliasing(int antiAliasing)
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0xD5C1B8", Offset = "0xD5C1B8", VA = "0xD5C1B8")]
		public static void UPvr_SinglePassBeforeForwardOpaque()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xD5C1BC", Offset = "0xD5C1BC", VA = "0xD5C1BC")]
		public static void UPvr_SetCurrentRenderTexture(uint textureId)
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0xD5C1C0", Offset = "0xD5C1C0", VA = "0xD5C1C0")]
		public static bool UPvr_SetSinglePassDepthBufferWidthHeight(int width, int height)
		{
			return default(bool);
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0xD5C1C4", Offset = "0xD5C1C4", VA = "0xD5C1C4")]
		public static int UPVR_setPerformanceLevels(int cpuLevel, int gpuLevel)
		{
			return default(int);
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0xD5C1C8", Offset = "0xD5C1C8", VA = "0xD5C1C8")]
		public static int UPvr_GetColorRes(string name)
		{
			return default(int);
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0xD5C3AC", Offset = "0xD5C3AC", VA = "0xD5C3AC")]
		public static int UPvr_GetConfigInt(string name)
		{
			return default(int);
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0xD5C590", Offset = "0xD5C590", VA = "0xD5C590")]
		public static string UPvr_GetConfigString(string name)
		{
			return null;
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0xD5C77C", Offset = "0xD5C77C", VA = "0xD5C77C")]
		public static string UPvr_GetDrawableLocation(string name)
		{
			return null;
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0xD5C968", Offset = "0xD5C968", VA = "0xD5C968")]
		public static int UPvr_GetTextSize(string name)
		{
			return default(int);
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xD4689C", Offset = "0xD4689C", VA = "0xD4689C")]
		public static string UPvr_GetLangString(string name)
		{
			return null;
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0xD5CB4C", Offset = "0xD5CB4C", VA = "0xD5CB4C")]
		public static string UPvr_GetStringValue(string id, int type)
		{
			return null;
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0xD5CDA4", Offset = "0xD5CDA4", VA = "0xD5CDA4")]
		public static int UPvr_GetIntValue(string id, int type)
		{
			return default(int);
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0xD5CFF4", Offset = "0xD5CFF4", VA = "0xD5CFF4")]
		public static float UPvr_GetFloatValue(string id)
		{
			return default(float);
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0xD5D1D8", Offset = "0xD5D1D8", VA = "0xD5D1D8")]
		public static string UPvr_GetObjectOrArray(string id, int type)
		{
			return null;
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xD5D430", Offset = "0xD5D430", VA = "0xD5D430")]
		public static int UPvr_GetCharSpace(string id)
		{
			return default(int);
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xD5D614", Offset = "0xD5D614", VA = "0xD5D614")]
		public static bool UPvr_SetExtraLatencyMode(ExtraLatencyMode mode)
		{
			return default(bool);
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xD5D618", Offset = "0xD5D618", VA = "0xD5D618")]
		public static float UPvr_GetPredictedDisplayTime()
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000EF")]
	public struct BoundarySystem
	{
		[Token(Token = "0x2000195")]
		public enum BoundaryType
		{
			[Token(Token = "0x4000C53")]
			OuterBoundary,
			[Token(Token = "0x4000C54")]
			PlayArea
		}

		[Token(Token = "0x2000196")]
		public struct BoundaryTestResult
		{
			[Token(Token = "0x4000C55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool IsTriggering;

			[Token(Token = "0x4000C56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float ClosestDistance;

			[Token(Token = "0x4000C57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3 ClosestPoint;

			[Token(Token = "0x4000C58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 ClosestPointNormal;
		}

		[Token(Token = "0x2000197")]
		public enum BoundaryTrackingNode
		{
			[Token(Token = "0x4000C5A")]
			HandLeft,
			[Token(Token = "0x4000C5B")]
			HandRight,
			[Token(Token = "0x4000C5C")]
			Head
		}

		[Token(Token = "0x2000198")]
		public enum BoundaryTrackingState
		{
			[Token(Token = "0x4000C5E")]
			LostNoReason = 3,
			[Token(Token = "0x4000C5F")]
			LostCamera,
			[Token(Token = "0x4000C60")]
			LostHighLight,
			[Token(Token = "0x4000C61")]
			LostLowLight,
			[Token(Token = "0x4000C62")]
			LostLowFeatureCount,
			[Token(Token = "0x4000C63")]
			LostReLocation,
			[Token(Token = "0x4000C64")]
			LostInitialization,
			[Token(Token = "0x4000C65")]
			LostNoCamera,
			[Token(Token = "0x4000C66")]
			LostNoIMU,
			[Token(Token = "0x4000C67")]
			LostIMUJitter,
			[Token(Token = "0x4000C68")]
			LostUnknown
		}

		[Token(Token = "0x40008CA")]
		public const string LibFileName = "Pvr_UnitySDK";

		[PreserveSig]
		[Token(Token = "0x6000779")]
		[Address(RVA = "0xD4E174", Offset = "0xD4E174", VA = "0xD4E174")]
		private static extern float Pvr_GetFloorHeight();

		[PreserveSig]
		[Token(Token = "0x600077A")]
		[Address(RVA = "0xD4E1E4", Offset = "0xD4E1E4", VA = "0xD4E1E4")]
		private static extern int Pvr_GetSeeThroughState();

		[PreserveSig]
		[Token(Token = "0x600077B")]
		[Address(RVA = "0xD4E258", Offset = "0xD4E258", VA = "0xD4E258")]
		private static extern void Pvr_BoundarySetSTBackground(bool value);

		[PreserveSig]
		[Token(Token = "0x600077C")]
		[Address(RVA = "0xD4E2D8", Offset = "0xD4E2D8", VA = "0xD4E2D8")]
		private static extern int Pvr_GetTrackingState();

		[PreserveSig]
		[Token(Token = "0x600077D")]
		[Address(RVA = "0xD4E34C", Offset = "0xD4E34C", VA = "0xD4E34C")]
		private static extern bool Pvr_GetFrameRateLimit();

		[PreserveSig]
		[Token(Token = "0x600077E")]
		[Address(RVA = "0xD4E3C8", Offset = "0xD4E3C8", VA = "0xD4E3C8")]
		private static extern bool Pvr_IsBoundaryEnable();

		[PreserveSig]
		[Token(Token = "0x600077F")]
		[Address(RVA = "0xD4E444", Offset = "0xD4E444", VA = "0xD4E444")]
		private static extern bool Pvr_BoundaryGetConfigured();

		[PreserveSig]
		[Token(Token = "0x6000780")]
		[Address(RVA = "0xD4E4C0", Offset = "0xD4E4C0", VA = "0xD4E4C0")]
		private static extern bool Pvr_BoundaryTestNode(int node, bool isPlayArea, ref bool isTriggering, ref float closestDistance, ref float px, ref float py, ref float pz, ref float nx, ref float ny, ref float nz);

		[PreserveSig]
		[Token(Token = "0x6000781")]
		[Address(RVA = "0xD4E5C4", Offset = "0xD4E5C4", VA = "0xD4E5C4")]
		private static extern bool Pvr_BoundaryTestPoint(float x, float y, float z, bool isPlayArea, ref bool isTriggering, ref float closestDistance, ref float px, ref float py, ref float pz, ref float nx, ref float ny, ref float nz);

		[PreserveSig]
		[Token(Token = "0x6000782")]
		[Address(RVA = "0xD4E6EC", Offset = "0xD4E6EC", VA = "0xD4E6EC")]
		private static extern int Pvr_BoundaryGetGeometry(out IntPtr handle, bool isPlayArea);

		[PreserveSig]
		[Token(Token = "0x6000783")]
		[Address(RVA = "0xD4E778", Offset = "0xD4E778", VA = "0xD4E778")]
		private static extern int Pvr_BoundaryGetDimensions(ref float x, ref float y, ref float z, bool isPlayArea);

		[PreserveSig]
		[Token(Token = "0x6000784")]
		[Address(RVA = "0xD4E820", Offset = "0xD4E820", VA = "0xD4E820")]
		private static extern bool Pvr_BoundaryGetEnabled();

		[PreserveSig]
		[Token(Token = "0x6000785")]
		[Address(RVA = "0xD4E89C", Offset = "0xD4E89C", VA = "0xD4E89C")]
		private static extern void Pvr_BoundarySetVisible(bool value);

		[PreserveSig]
		[Token(Token = "0x6000786")]
		[Address(RVA = "0xD4E91C", Offset = "0xD4E91C", VA = "0xD4E91C")]
		private static extern bool Pvr_BoundaryGetVisible();

		[PreserveSig]
		[Token(Token = "0x6000787")]
		[Address(RVA = "0xD4E998", Offset = "0xD4E998", VA = "0xD4E998")]
		private static extern bool Pvr_EnableLWRP(bool enable);

		[PreserveSig]
		[Token(Token = "0x6000788")]
		[Address(RVA = "0xD4EA20", Offset = "0xD4EA20", VA = "0xD4EA20")]
		private static extern bool Pvr_SetViewportSize(int w, int h);

		[PreserveSig]
		[Token(Token = "0x6000789")]
		[Address(RVA = "0xD4EAB8", Offset = "0xD4EAB8", VA = "0xD4EAB8")]
		private static extern void Pvr_BoundarySetSeeThroughVisible(bool value);

		[PreserveSig]
		[Token(Token = "0x600078A")]
		[Address(RVA = "0xD4EB38", Offset = "0xD4EB38", VA = "0xD4EB38")]
		private static extern void PVR_SetCameraImageRect(int width, int height);

		[PreserveSig]
		[Token(Token = "0x600078B")]
		[Address(RVA = "0xD4EBC8", Offset = "0xD4EBC8", VA = "0xD4EBC8")]
		private static extern void Pvr_SetGuardianSystemDisable(bool value);

		[PreserveSig]
		[Token(Token = "0x600078C")]
		[Address(RVA = "0xD4EC48", Offset = "0xD4EC48", VA = "0xD4EC48")]
		private static extern int Pvr_GetDialogState();

		[Token(Token = "0x600078D")]
		[Address(RVA = "0xD4ECBC", Offset = "0xD4ECBC", VA = "0xD4ECBC")]
		public static float UPvr_GetFloorHeight()
		{
			return default(float);
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0xD4ECC0", Offset = "0xD4ECC0", VA = "0xD4ECC0")]
		public static int UPvr_GetSeeThroughState()
		{
			return default(int);
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0xD4ECC4", Offset = "0xD4ECC4", VA = "0xD4ECC4")]
		public static void UPvr_EnableSeeThroughManual(bool enable)
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0xD4ECCC", Offset = "0xD4ECCC", VA = "0xD4ECCC")]
		public static BoundaryTrackingState UPvr_GetTrackingState()
		{
			return default(BoundaryTrackingState);
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0xD4ECD0", Offset = "0xD4ECD0", VA = "0xD4ECD0")]
		public static bool UPvr_GetFrameRateLimit()
		{
			return default(bool);
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0xD4ECD4", Offset = "0xD4ECD4", VA = "0xD4ECD4")]
		public static bool UPvr_IsBoundaryEnable()
		{
			return default(bool);
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0xD4ECD8", Offset = "0xD4ECD8", VA = "0xD4ECD8")]
		public static bool UPvr_BoundaryGetConfigured()
		{
			return default(bool);
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0xD4ECDC", Offset = "0xD4ECDC", VA = "0xD4ECDC")]
		public static BoundaryTestResult UPvr_BoundaryTestNode(BoundaryTrackingNode node, BoundaryType boundaryType)
		{
			return default(BoundaryTestResult);
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0xD4EE20", Offset = "0xD4EE20", VA = "0xD4EE20")]
		public static BoundaryTestResult UPvr_BoundaryTestPoint(Vector3 point, BoundaryType boundaryType)
		{
			return default(BoundaryTestResult);
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0xD4EF70", Offset = "0xD4EF70", VA = "0xD4EF70")]
		public static Vector3[] UPvr_BoundaryGetGeometry(BoundaryType boundaryType)
		{
			return null;
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0xD4F14C", Offset = "0xD4F14C", VA = "0xD4F14C")]
		public static Vector3 UPvr_BoundaryGetDimensions(BoundaryType boundaryType)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xD4F1A8", Offset = "0xD4F1A8", VA = "0xD4F1A8")]
		public static bool UPvr_BoundaryGetEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xD4F1AC", Offset = "0xD4F1AC", VA = "0xD4F1AC")]
		public static void UPvr_BoundarySetVisible(bool value)
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xD4F1B4", Offset = "0xD4F1B4", VA = "0xD4F1B4")]
		public static bool UPvr_BoundaryGetVisible()
		{
			return default(bool);
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0xD4F1B8", Offset = "0xD4F1B8", VA = "0xD4F1B8")]
		public static bool UPvr_EnableLWRP(bool enable)
		{
			return default(bool);
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0xD4F1C0", Offset = "0xD4F1C0", VA = "0xD4F1C0")]
		public static bool UPvr_SetViewportSize(int width, int height)
		{
			return default(bool);
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xD4F1C4", Offset = "0xD4F1C4", VA = "0xD4F1C4")]
		public static void UPvr_StartCameraFrame()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xD4F308", Offset = "0xD4F308", VA = "0xD4F308")]
		public static void UPvr_StopCameraFrame()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0xD4F44C", Offset = "0xD4F44C", VA = "0xD4F44C")]
		public static void UPvr_BoundaryGetSeeThroughData(int cameraIndex, RenderTexture renderTexture)
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xD4F62C", Offset = "0xD4F62C", VA = "0xD4F62C")]
		public static void UPvr_BoundarySetCameraImageRect(int width, int height)
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xD4F764", Offset = "0xD4F764", VA = "0xD4F764")]
		public static void UPvr_BoundarySetSeeThroughVisible(bool value)
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xD4F888", Offset = "0xD4F888", VA = "0xD4F888")]
		public static void UPvr_SetGuardianSystemDisable(bool value)
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xD4F9AC", Offset = "0xD4F9AC", VA = "0xD4F9AC")]
		public static int UPvr_GetDialogState()
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000F0")]
	public struct PlatformSettings
	{
		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xD5493C", Offset = "0xD5493C", VA = "0xD5493C")]
		public static Pvr_UnitySDKPlatformSetting.simulationType UPvr_IsCurrentDeviceValid()
		{
			return default(Pvr_UnitySDKPlatformSetting.simulationType);
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xD54C58", Offset = "0xD54C58", VA = "0xD54C58")]
		public static bool UPvr_AppEntitlementCheck(string appid)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xD54FC0", Offset = "0xD54FC0", VA = "0xD54FC0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x802F8C", Offset = "0x802F8C")]
		public static bool UPvr_KeyEntitlementCheck(string publicKey)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xD552A0", Offset = "0xD552A0", VA = "0xD552A0")]
		public static int UPvr_AppEntitlementCheckExtra(string appid)
		{
			return default(int);
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xD55594", Offset = "0xD55594", VA = "0xD55594")]
		public static int UPvr_KeyEntitlementCheckExtra(string publicKey)
		{
			return default(int);
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xD55888", Offset = "0xD55888", VA = "0xD55888")]
		public static int UPvr_GetHmdAudioStatus()
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000F1")]
	public enum DeviceCommand
	{
		[Token(Token = "0x40008CC")]
		SET_PICO_NEO_HMD_BRIGHTNESS = 12,
		[Token(Token = "0x40008CD")]
		SET_PICO_NEO_HMD_SLEEPDELAY
	}
	[Token(Token = "0x20000F2")]
	public enum BrightnessLevel
	{
		[Token(Token = "0x40008CF")]
		VR_BRIGHTNESS_LEVEL_MIN = 1,
		[Token(Token = "0x40008D0")]
		VR_BRIGHTNESS_LEVEL_MAX = 100,
		[Token(Token = "0x40008D1")]
		VR_BRIGHTNESS_LEVEL_DOWN = 1000,
		[Token(Token = "0x40008D2")]
		VR_BRIGHTNESS_LEVEL_UP = 1001,
		[Token(Token = "0x40008D3")]
		VR_BRIGHTNESS_LEVEL_SCREEN_OFF = -100
	}
	[Token(Token = "0x20000F3")]
	public struct VolumePowerBrightness
	{
		[Token(Token = "0x40008D4")]
		public const string LibFileName = "Pvr_UnitySDK";

		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AndroidJavaObject activity;

		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static AndroidJavaClass javaSysActivityClass;

		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static AndroidJavaClass batteryjavaVrActivityClass;

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static AndroidJavaClass volumejavaVrActivityClass;

		[PreserveSig]
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xE6DEB4", Offset = "0xE6DEB4", VA = "0xE6DEB4")]
		public static extern void Pvr_SetInitActivity(IntPtr activity, IntPtr vrActivityClass);

		[PreserveSig]
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xE6DF44", Offset = "0xE6DF44", VA = "0xE6DF44")]
		private static extern bool Pvr_IsHmdExist();

		[PreserveSig]
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xE6DFC0", Offset = "0xE6DFC0", VA = "0xE6DFC0")]
		private static extern int Pvr_GetHmdScreenBrightness();

		[PreserveSig]
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xE6E034", Offset = "0xE6E034", VA = "0xE6E034")]
		private static extern bool Pvr_SetHmdScreenBrightness(int brightness);

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xE6E0BC", Offset = "0xE6E0BC", VA = "0xE6E0BC")]
		public static bool UPvr_IsHmdExist()
		{
			return default(bool);
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xE6E0C0", Offset = "0xE6E0C0", VA = "0xE6E0C0")]
		public static int UPvr_GetHmdScreenBrightness()
		{
			return default(int);
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xE6E0C4", Offset = "0xE6E0C4", VA = "0xE6E0C4")]
		public static bool UPvr_SetHmdScreenBrightness(int brightness)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xE6E0C8", Offset = "0xE6E0C8", VA = "0xE6E0C8")]
		public static bool UPvr_SetCommonBrightness(int brightness)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0xE6E350", Offset = "0xE6E350", VA = "0xE6E350")]
		public static int UPvr_GetCommonBrightness()
		{
			return default(int);
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0xE6E568", Offset = "0xE6E568", VA = "0xE6E568")]
		public static int[] UPvr_GetScreenBrightnessLevel()
		{
			return null;
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0xE6E768", Offset = "0xE6E768", VA = "0xE6E768")]
		public static void UPvr_SetScreenBrightnessLevel(int vrBrightness, int level)
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xE6E99C", Offset = "0xE6E99C", VA = "0xE6E99C")]
		public static bool UPvr_SetDevicePropForUser(DeviceCommand deviceid, string number)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xE6EAF0", Offset = "0xE6EAF0", VA = "0xE6EAF0")]
		public static string UPvr_GetDevicePropForUser(DeviceCommand deviceid)
		{
			return null;
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xE6EC20", Offset = "0xE6EC20", VA = "0xE6EC20")]
		public static bool UPvr_InitBatteryClass()
		{
			return default(bool);
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xE6EEDC", Offset = "0xE6EEDC", VA = "0xE6EEDC")]
		public static bool UPvr_InitBatteryVolClass()
		{
			return default(bool);
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xE6F1A0", Offset = "0xE6F1A0", VA = "0xE6F1A0")]
		public static bool UPvr_StartBatteryReceiver(string startreceivre)
		{
			return default(bool);
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xE6F3D4", Offset = "0xE6F3D4", VA = "0xE6F3D4")]
		public static bool UPvr_StopBatteryReceiver()
		{
			return default(bool);
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xE6E100", Offset = "0xE6E100", VA = "0xE6E100")]
		public static bool UPvr_SetBrightness(int brightness)
		{
			return default(bool);
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xE6E370", Offset = "0xE6E370", VA = "0xE6E370")]
		public static int UPvr_GetCurrentBrightness()
		{
			return default(int);
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xE6E56C", Offset = "0xE6E56C", VA = "0xE6E56C")]
		public static int[] Pvr_GetScreenBrightnessLevel()
		{
			return null;
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xE6E76C", Offset = "0xE6E76C", VA = "0xE6E76C")]
		public static void Pvr_SetScreenBrightnessLevel(int vrBrightness, int level)
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xE6F5C0", Offset = "0xE6F5C0", VA = "0xE6F5C0")]
		public static bool UPvr_StartAudioReceiver(string startreceivre)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xE6F7F4", Offset = "0xE6F7F4", VA = "0xE6F7F4")]
		public static bool UPvr_StopAudioReceiver()
		{
			return default(bool);
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xE6F9E0", Offset = "0xE6F9E0", VA = "0xE6F9E0")]
		public static int UPvr_GetMaxVolumeNumber()
		{
			return default(int);
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xE6FBC8", Offset = "0xE6FBC8", VA = "0xE6FBC8")]
		public static int UPvr_GetCurrentVolumeNumber()
		{
			return default(int);
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xE6FDB0", Offset = "0xE6FDB0", VA = "0xE6FDB0")]
		public static bool UPvr_VolumeUp()
		{
			return default(bool);
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xE6FF8C", Offset = "0xE6FF8C", VA = "0xE6FF8C")]
		public static bool UPvr_VolumeDown()
		{
			return default(bool);
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xE70168", Offset = "0xE70168", VA = "0xE70168")]
		public static bool UPvr_SetVolumeNum(int volume)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xE7033C", Offset = "0xE7033C", VA = "0xE7033C")]
		public static bool UPvr_SetAudio(string s)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xE70344", Offset = "0xE70344", VA = "0xE70344")]
		public static bool UPvr_SetBattery(string s)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xE6EAF4", Offset = "0xE6EAF4", VA = "0xE6EAF4")]
		private static string getDevicePropForUser(DeviceCommand deviceid)
		{
			return null;
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xE6E9A0", Offset = "0xE6E9A0", VA = "0xE6E9A0")]
		private static bool setDevicePropForUser(DeviceCommand deviceid, string number)
		{
			return default(bool);
		}
	}
}
namespace BoundarySystem_Ext
{
	[Token(Token = "0x20000F4")]
	internal static class Pvr_BoundaryAPI
	{
		[Token(Token = "0x40008D9")]
		private const string LibFileName = "Pvr_UnitySDK";

		[PreserveSig]
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xBB2424", Offset = "0xBB2424", VA = "0xBB2424")]
		public static extern void Pvr_StartSDKBoundary();

		[PreserveSig]
		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xBB2494", Offset = "0xBB2494", VA = "0xBB2494")]
		public static extern void Pvr_ShutdownSDKBoundary();

		[PreserveSig]
		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xBB2504", Offset = "0xBB2504", VA = "0xBB2504")]
		private static extern int Pvr_GetMainSensorStateExt(ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz, ref float vfov, ref float hfov, ref int viewNumber);

		[PreserveSig]
		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xBB25E8", Offset = "0xBB25E8", VA = "0xBB25E8")]
		private static extern IntPtr Pvr_GetCameraData_Ext();

		[PreserveSig]
		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xBB265C", Offset = "0xBB265C", VA = "0xBB265C")]
		public static extern void Pvr_ResetVrModebyForce();

		[PreserveSig]
		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xBB26CC", Offset = "0xBB26CC", VA = "0xBB26CC")]
		private static extern bool Pvr_ResumeBoundaryForSTS();

		[PreserveSig]
		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xBB2748", Offset = "0xBB2748", VA = "0xBB2748")]
		private static extern void Pvr_PauseBoundaryForSTS();

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xBB27B8", Offset = "0xBB27B8", VA = "0xBB27B8")]
		public static int UPvr_GetMainSensorStateExt(ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz, ref float vfov, ref float hfov, ref int viewNumber)
		{
			return default(int);
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xBB27C4", Offset = "0xBB27C4", VA = "0xBB27C4")]
		public static IntPtr UPvr_GetCameraData_Ext()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xBB2800", Offset = "0xBB2800", VA = "0xBB2800")]
		public static bool UPvr_ResumeBoundaryForSTS()
		{
			return default(bool);
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xBB2804", Offset = "0xBB2804", VA = "0xBB2804")]
		public static void UPvr_PauseBoundaryForSTS()
		{
		}

		[Token(Token = "0x60007D5")]
		public static IntPtr StructToIntPtr<T>(T info)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60007D6")]
		public static T IntPtrToStruct<T>(IntPtr info)
		{
			return (T)null;
		}
	}
	[Token(Token = "0x20000F5")]
	internal static class Pvr_SafeAreaAlgoAPI
	{
		[Token(Token = "0x2000199")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x8000A8", Offset = "0x8000A8")]
		public delegate void SafeAreaCallback(IntPtr lineCollectionPtr, IntPtr safeAreaRectPtr);

		[Token(Token = "0x200019A")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x8000BC", Offset = "0x8000BC")]
		public delegate void SafeAreaCallbackShrink(IntPtr lineCollectionPtr, IntPtr safeAreaDetailRectPtr);

		[Token(Token = "0x200019B")]
		public struct GSAPoint3i
		{
			[Token(Token = "0x4000C69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int x;

			[Token(Token = "0x4000C6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int y;

			[Token(Token = "0x4000C6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int z;
		}

		[Token(Token = "0x200019C")]
		public struct GSALine
		{
			[Token(Token = "0x4000C6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IntPtr pointArray;

			[Token(Token = "0x4000C6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int pointCount;
		}

		[Token(Token = "0x200019D")]
		public struct GSALineCollection
		{
			[Token(Token = "0x4000C6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IntPtr lineArray;

			[Token(Token = "0x4000C6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int lineCount;
		}

		[Token(Token = "0x200019E")]
		public struct GSALegalData
		{
			[Token(Token = "0x4000C70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int overMaxRange;

			[Token(Token = "0x4000C71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int includeBigGrap;

			[Token(Token = "0x4000C72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int bigGapNum;

			[Token(Token = "0x4000C73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int centerOut;

			[Token(Token = "0x4000C74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int removeNarrow;

			[Token(Token = "0x4000C75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int overMaxRange_more;

			[Token(Token = "0x4000C76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int validShrinkArea;
		}

		[Token(Token = "0x200019F")]
		public struct GSARect
		{
			[Token(Token = "0x4000C77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GSAPoint3i leftup;

			[Token(Token = "0x4000C78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public GSAPoint3i leftdown;

			[Token(Token = "0x4000C79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GSAPoint3i rightup;

			[Token(Token = "0x4000C7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public GSAPoint3i rightdown;

			[Token(Token = "0x4000C7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GSAPoint3i center;

			[Token(Token = "0x4000C7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public uint width;

			[Token(Token = "0x4000C7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public uint height;

			[Token(Token = "0x4000C7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public int isLegal;

			[Token(Token = "0x4000C7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public GSALegalData legalData;
		}

		[Token(Token = "0x40008DA")]
		private const string LibFileName = "SafetyArea";

		[PreserveSig]
		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xBB2A9C", Offset = "0xBB2A9C", VA = "0xBB2A9C")]
		private static extern int GSAInit(int width, int height);

		[PreserveSig]
		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xBB2B2C", Offset = "0xBB2B2C", VA = "0xBB2B2C")]
		private static extern int GSAShutDown();

		[PreserveSig]
		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xBB2BA0", Offset = "0xBB2BA0", VA = "0xBB2BA0")]
		private static extern int GSASetCallback(SafeAreaCallback cb);

		[PreserveSig]
		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xBB2C24", Offset = "0xBB2C24", VA = "0xBB2C24")]
		private static extern int GSASetCallbackShrink(SafeAreaCallbackShrink cb);

		[PreserveSig]
		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xBB2CA8", Offset = "0xBB2CA8", VA = "0xBB2CA8")]
		private static extern int GSAUpDateData(IntPtr lineCollectionPtr);

		[PreserveSig]
		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xBB2D28", Offset = "0xBB2D28", VA = "0xBB2D28")]
		private static extern int GSASetConfigFilePath(IntPtr configPath);

		[PreserveSig]
		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xBB2DA8", Offset = "0xBB2DA8", VA = "0xBB2DA8")]
		private static extern bool GSAGetClosedAreaUpdateFlag();

		[PreserveSig]
		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xBB2E24", Offset = "0xBB2E24", VA = "0xBB2E24")]
		private static extern int GSALoadSafetyArea(IntPtr lineCollectionPtr);

		[PreserveSig]
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xBB2EA4", Offset = "0xBB2EA4", VA = "0xBB2EA4")]
		private static extern double GSABoundaryDetector(ref GSAPoint3i pointPtr);

		[PreserveSig]
		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xBB2F24", Offset = "0xBB2F24", VA = "0xBB2F24")]
		private static extern int GSALoadSafetyArea2(IntPtr lineCollectionPtr, bool isPlayArea);

		[PreserveSig]
		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xBB2FB4", Offset = "0xBB2FB4", VA = "0xBB2FB4")]
		private static extern double GSABoundaryDetector2(ref GSAPoint3i point, bool isPlayArea, ref GSAPoint3i closestPoint, ref GSAPoint3i normalDir);

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xBB305C", Offset = "0xBB305C", VA = "0xBB305C")]
		public static int Pvr_GSAInit(int width, int height)
		{
			return default(int);
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xBB3060", Offset = "0xBB3060", VA = "0xBB3060")]
		public static int Pvr_GSASetCallback(SafeAreaCallback cb)
		{
			return default(int);
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xBB3064", Offset = "0xBB3064", VA = "0xBB3064")]
		public static int Pvr_GSASetCallbackShrink(SafeAreaCallbackShrink cb)
		{
			return default(int);
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xBB3068", Offset = "0xBB3068", VA = "0xBB3068")]
		public static int Pvr_GSAUpDateData(IntPtr lineCollectionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xBB306C", Offset = "0xBB306C", VA = "0xBB306C")]
		public static bool Pvr_GSAGetClosedAreaUpdateFlag()
		{
			return default(bool);
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xBB3070", Offset = "0xBB3070", VA = "0xBB3070")]
		public static int Pvr_GSASetConfigFilePath(string configPath)
		{
			return default(int);
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xBB30F8", Offset = "0xBB30F8", VA = "0xBB30F8")]
		public static int Pvr_GSALoadSafetyArea(IntPtr lineCollectionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xBB30FC", Offset = "0xBB30FC", VA = "0xBB30FC")]
		public static double Pvr_GSABoundaryDetector(ref GSAPoint3i point)
		{
			return default(double);
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xBB3100", Offset = "0xBB3100", VA = "0xBB3100")]
		public static int Pvr_GSAShutDown()
		{
			return default(int);
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xBB3104", Offset = "0xBB3104", VA = "0xBB3104")]
		public static int Pvr_GSALoadSafetyArea2(IntPtr lineCollectionPtr, bool isPlayArea)
		{
			return default(int);
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xBB310C", Offset = "0xBB310C", VA = "0xBB310C")]
		public static double Pvr_GSABoundaryDetector2(ref GSAPoint3i point, bool isPlayArea, ref GSAPoint3i closestPoint, ref GSAPoint3i normalDir)
		{
			return default(double);
		}
	}
	[Token(Token = "0x20000F6")]
	public class Pvr_BoundarySystem
	{
		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Pvr_BoundarySystem instance;

		[Token(Token = "0x40008DC")]
		public const int CameraImageWidth = 1280;

		[Token(Token = "0x40008DD")]
		public const int CameraImageHeight = 400;

		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr CameraFramePtr;

		[Token(Token = "0x17000091")]
		public static Pvr_BoundarySystem Instance
		{
			[Token(Token = "0x60007ED")]
			[Address(RVA = "0xBB2808", Offset = "0xBB2808", VA = "0xBB2808")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xBB28D0", Offset = "0xBB28D0", VA = "0xBB28D0")]
		public void OpenBoundary()
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xBB28D4", Offset = "0xBB28D4", VA = "0xBB28D4")]
		public void CloseBoundary()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xBB28D8", Offset = "0xBB28D8", VA = "0xBB28D8")]
		public void Reset6Dof()
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xBB28DC", Offset = "0xBB28DC", VA = "0xBB28DC")]
		public float[] GetControllerFixedPoseData(int hand)
		{
			return null;
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xBB2884", Offset = "0xBB2884", VA = "0xBB2884")]
		public Pvr_BoundarySystem()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class Pvr_SafeAreaAlgoModule
	{
		[Token(Token = "0x20001A0")]
		public struct ExtraInfo
		{
			[Token(Token = "0x4000C80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool overMaxRange;

			[Token(Token = "0x4000C81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeBigGap;

			[Token(Token = "0x4000C82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int bigGapNum;

			[Token(Token = "0x4000C83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool centerOut;

			[Token(Token = "0x4000C84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
			public bool removeNarrow;

			[Token(Token = "0x4000C85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			public bool overMaxRange_more;

			[Token(Token = "0x4000C86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int validShrinkArea;
		}

		[Token(Token = "0x20001A1")]
		public struct BoundaryPlayerArea
		{
			[Token(Token = "0x4000C87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 lowerleft;

			[Token(Token = "0x4000C88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 upperleft;

			[Token(Token = "0x4000C89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 upperRight;

			[Token(Token = "0x4000C8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 lowerRight;

			[Token(Token = "0x4000C8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 center;

			[Token(Token = "0x4000C8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public uint width;

			[Token(Token = "0x4000C8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public uint height;

			[Token(Token = "0x4000C8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool isLegal;

			[Token(Token = "0x4000C8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public ExtraInfo extraInfo;
		}

		[Token(Token = "0x20001A2")]
		public delegate void BoundarySystemCallback(BoundaryPlayerArea playAreaInfo, List<Vector3> boundaryPoints, List<List<Vector3>> unusedLines);

		[Token(Token = "0x20001A3")]
		public delegate void BoundarySystemCallbackShrink(List<Vector3> rectPoints, List<Vector3> boundaryPoints, List<List<Vector3>> unusedLines);

		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Pvr_SafeAreaAlgoModule instance;

		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private BoundarySystemCallback boundarySystemCallback;

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private BoundarySystemCallbackShrink boundarySystemCallbackShrink;

		[Token(Token = "0x17000092")]
		public static Pvr_SafeAreaAlgoModule Instance
		{
			[Token(Token = "0x60007F3")]
			[Address(RVA = "0xBB4554", Offset = "0xBB4554", VA = "0xBB4554")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xBB45DC", Offset = "0xBB45DC", VA = "0xBB45DC")]
		public void RegisterCallBack(BoundarySystemCallback callback)
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xBB45E4", Offset = "0xBB45E4", VA = "0xBB45E4")]
		public void RegisterCallBackShrink(BoundarySystemCallbackShrink callback)
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xBB45EC", Offset = "0xBB45EC", VA = "0xBB45EC")]
		public bool Start()
		{
			return default(bool);
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xBB470C", Offset = "0xBB470C", VA = "0xBB470C")]
		public bool CommitNewLineData(bool isFistLine, Vector3[] points)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0xBB49C4", Offset = "0xBB49C4", VA = "0xBB49C4")]
		public bool Shutdown()
		{
			return default(bool);
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0xBB4A48", Offset = "0xBB4A48", VA = "0xBB4A48")]
		public double QueryDistanceOfPoint(Vector3 point)
		{
			return default(double);
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0xBB4AD8", Offset = "0xBB4AD8", VA = "0xBB4AD8")]
		public double QueryDistanceOfPoint(Vector3 point, bool isPlayArea, ref Vector3 closestPoint, ref Vector3 normalDir)
		{
			return default(double);
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0xBB3784", Offset = "0xBB3784", VA = "0xBB3784")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x802FC4", Offset = "0x802FC4")]
		private static void _SafeAreaCallback(IntPtr lineCollectionPtr, IntPtr safeAreaRectPtr)
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0xBB3E9C", Offset = "0xBB3E9C", VA = "0xBB3E9C")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x804028", Offset = "0x804028")]
		private static void _SafeAreaCallbackShrink(IntPtr lineCollectionPtr, IntPtr safeAreaDetailRectPtr)
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0xBB45D4", Offset = "0xBB45D4", VA = "0xBB45D4")]
		public Pvr_SafeAreaAlgoModule()
		{
		}
	}
}
namespace NLayer
{
	[Token(Token = "0x20000F8")]
	public enum MpegVersion
	{
		[Token(Token = "0x40008E3")]
		Unknown = 0,
		[Token(Token = "0x40008E4")]
		Version1 = 10,
		[Token(Token = "0x40008E5")]
		Version2 = 20,
		[Token(Token = "0x40008E6")]
		Version25 = 25
	}
	[Token(Token = "0x20000F9")]
	public enum MpegLayer
	{
		[Token(Token = "0x40008E8")]
		Unknown,
		[Token(Token = "0x40008E9")]
		LayerI,
		[Token(Token = "0x40008EA")]
		LayerII,
		[Token(Token = "0x40008EB")]
		LayerIII
	}
	[Token(Token = "0x20000FA")]
	public enum MpegChannelMode
	{
		[Token(Token = "0x40008ED")]
		Stereo,
		[Token(Token = "0x40008EE")]
		JointStereo,
		[Token(Token = "0x40008EF")]
		DualChannel,
		[Token(Token = "0x40008F0")]
		Mono
	}
	[Token(Token = "0x20000FB")]
	public enum StereoMode
	{
		[Token(Token = "0x40008F2")]
		Both,
		[Token(Token = "0x40008F3")]
		LeftOnly,
		[Token(Token = "0x40008F4")]
		RightOnly,
		[Token(Token = "0x40008F5")]
		DownmixToMono
	}
	[Token(Token = "0x20000FC")]
	public interface IMpegFrame
	{
		[Token(Token = "0x17000093")]
		int SampleRate
		{
			[Token(Token = "0x60007FE")]
			get;
		}

		[Token(Token = "0x17000094")]
		int SampleRateIndex
		{
			[Token(Token = "0x60007FF")]
			get;
		}

		[Token(Token = "0x17000095")]
		int FrameLength
		{
			[Token(Token = "0x6000800")]
			get;
		}

		[Token(Token = "0x17000096")]
		int BitRate
		{
			[Token(Token = "0x6000801")]
			get;
		}

		[Token(Token = "0x17000097")]
		MpegVersion Version
		{
			[Token(Token = "0x6000802")]
			get;
		}

		[Token(Token = "0x17000098")]
		MpegLayer Layer
		{
			[Token(Token = "0x6000803")]
			get;
		}

		[Token(Token = "0x17000099")]
		MpegChannelMode ChannelMode
		{
			[Token(Token = "0x6000804")]
			get;
		}

		[Token(Token = "0x1700009A")]
		int ChannelModeExtension
		{
			[Token(Token = "0x6000805")]
			get;
		}

		[Token(Token = "0x1700009B")]
		int SampleCount
		{
			[Token(Token = "0x6000806")]
			get;
		}

		[Token(Token = "0x1700009C")]
		int BitRateIndex
		{
			[Token(Token = "0x6000807")]
			get;
		}

		[Token(Token = "0x1700009D")]
		bool IsCopyrighted
		{
			[Token(Token = "0x6000808")]
			get;
		}

		[Token(Token = "0x1700009E")]
		bool HasCrc
		{
			[Token(Token = "0x6000809")]
			get;
		}

		[Token(Token = "0x1700009F")]
		bool IsCorrupted
		{
			[Token(Token = "0x600080A")]
			get;
		}

		[Token(Token = "0x600080B")]
		void Reset();

		[Token(Token = "0x600080C")]
		int ReadBits(int bitCount);
	}
	[Token(Token = "0x20000FD")]
	public class MpegFile : IDisposable
	{
		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Stream _stream;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _closeStream;

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool _eofFound;

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MpegStreamReader _reader;

		[Token(Token = "0x40008FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MpegFrameDecoder _decoder;

		[Token(Token = "0x40008FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private object _seekLock;

		[Token(Token = "0x40008FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private long _position;

		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float[] _readBuf;

		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _readBufLen;

		[Token(Token = "0x40008FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int _readBufOfs;

		[Token(Token = "0x170000A0")]
		public int SampleRate
		{
			[Token(Token = "0x6000811")]
			[Address(RVA = "0xE35994", Offset = "0xE35994", VA = "0xE35994")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A1")]
		public int Channels
		{
			[Token(Token = "0x6000812")]
			[Address(RVA = "0xE359AC", Offset = "0xE359AC", VA = "0xE359AC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A2")]
		public bool CanSeek
		{
			[Token(Token = "0x6000813")]
			[Address(RVA = "0xE359F4", Offset = "0xE359F4", VA = "0xE359F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A3")]
		public long Length
		{
			[Token(Token = "0x6000814")]
			[Address(RVA = "0xE35A10", Offset = "0xE35A10", VA = "0xE35A10")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170000A4")]
		public TimeSpan Duration
		{
			[Token(Token = "0x6000815")]
			[Address(RVA = "0xE35A7C", Offset = "0xE35A7C", VA = "0xE35A7C")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x170000A5")]
		public long Position
		{
			[Token(Token = "0x6000816")]
			[Address(RVA = "0xE35B54", Offset = "0xE35B54", VA = "0xE35B54")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000817")]
			[Address(RVA = "0xE35B5C", Offset = "0xE35B5C", VA = "0xE35B5C")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public TimeSpan Time
		{
			[Token(Token = "0x6000818")]
			[Address(RVA = "0xE36080", Offset = "0xE36080", VA = "0xE36080")]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6000819")]
			[Address(RVA = "0xE36150", Offset = "0xE36150", VA = "0xE36150")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public StereoMode StereoMode
		{
			[Token(Token = "0x600081B")]
			[Address(RVA = "0xE36358", Offset = "0xE36358", VA = "0xE36358")]
			get
			{
				return default(StereoMode);
			}
			[Token(Token = "0x600081C")]
			[Address(RVA = "0xE36374", Offset = "0xE36374", VA = "0xE36374")]
			set
			{
			}
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xE356FC", Offset = "0xE356FC", VA = "0xE356FC")]
		public MpegFile(string fileName)
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0xE35848", Offset = "0xE35848", VA = "0xE35848")]
		public MpegFile(Stream stream)
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xE357B0", Offset = "0xE357B0", VA = "0xE357B0")]
		private void Init(Stream stream, bool closeStream)
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0xE35958", Offset = "0xE35958", VA = "0xE35958", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xE36210", Offset = "0xE36210", VA = "0xE36210")]
		public void SetEQ(float[] eq)
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0xE36390", Offset = "0xE36390", VA = "0xE36390")]
		public int ReadSamples(byte[] buffer, int index, int count)
		{
			return default(int);
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0xE367CC", Offset = "0xE367CC", VA = "0xE367CC")]
		public int ReadSamples(float[] buffer, int index, int count)
		{
			return default(int);
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xE36460", Offset = "0xE36460", VA = "0xE36460")]
		private int ReadSamplesImpl(Array buffer, int index, int count)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000FE")]
	public class MpegFrameDecoder
	{
		[Token(Token = "0x4000900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private LayerIDecoder _layerIDecoder;

		[Token(Token = "0x4000901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private LayerIIDecoder _layerIIDecoder;

		[Token(Token = "0x4000902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private LayerIIIDecoder _layerIIIDecoder;

		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float[] _eqFactors;

		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] _ch0;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float[] _ch1;

		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8010B0", Offset = "0x8010B0")]
		private StereoMode <StereoMode>k__BackingField;

		[Token(Token = "0x170000A8")]
		public StereoMode StereoMode
		{
			[Token(Token = "0x6000822")]
			[Address(RVA = "0xE368A4", Offset = "0xE368A4", VA = "0xE368A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80408C", Offset = "0x80408C")]
			get
			{
				return default(StereoMode);
			}
			[Token(Token = "0x6000823")]
			[Address(RVA = "0xE368AC", Offset = "0xE368AC", VA = "0xE368AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80409C", Offset = "0x80409C")]
			set
			{
			}
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xE358E4", Offset = "0xE358E4", VA = "0xE358E4")]
		public MpegFrameDecoder()
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xE36228", Offset = "0xE36228", VA = "0xE36228")]
		public void SetEQ(float[] eq)
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xE368B4", Offset = "0xE368B4", VA = "0xE368B4")]
		public int DecodeFrame(IMpegFrame frame, byte[] dest, int destOffset)
		{
			return default(int);
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xE35E8C", Offset = "0xE35E8C", VA = "0xE35E8C")]
		public int DecodeFrame(IMpegFrame frame, float[] dest, int destOffset)
		{
			return default(int);
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xE36AF8", Offset = "0xE36AF8", VA = "0xE36AF8")]
		private int DecodeFrameImpl(IMpegFrame frame, Array dest, int destOffset)
		{
			return default(int);
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xE35E2C", Offset = "0xE35E2C", VA = "0xE35E2C")]
		public void Reset()
		{
		}
	}
}
namespace NLayer.Decoder
{
	[Token(Token = "0x20000FF")]
	internal class BitReservoir
	{
		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private byte[] _buf;

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _start;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int _end;

		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _bitsLeft;

		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private long _bitsRead;

		[Token(Token = "0x170000A9")]
		public int BitsAvailable
		{
			[Token(Token = "0x600082D")]
			[Address(RVA = "0x127BF20", Offset = "0x127BF20", VA = "0x127BF20")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000AA")]
		public long BitsRead
		{
			[Token(Token = "0x600082E")]
			[Address(RVA = "0x127BF68", Offset = "0x127BF68", VA = "0x127BF68")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x127B57C", Offset = "0x127B57C", VA = "0x127B57C")]
		private static int GetSlots(IMpegFrame frame)
		{
			return default(int);
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x127B87C", Offset = "0x127B87C", VA = "0x127B87C")]
		public bool AddBits(IMpegFrame frame, int overlap)
		{
			return default(bool);
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x127BA78", Offset = "0x127BA78", VA = "0x127BA78")]
		public int GetBits(int count)
		{
			return default(int);
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x127BE24", Offset = "0x127BE24", VA = "0x127BE24")]
		public int Get1Bit()
		{
			return default(int);
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x127BB34", Offset = "0x127BB34", VA = "0x127BB34")]
		public int TryPeekBits(int count, out int readCount)
		{
			return default(int);
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x127BD28", Offset = "0x127BD28", VA = "0x127BD28")]
		public void SkipBits(int count)
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x127BF70", Offset = "0x127BF70", VA = "0x127BF70")]
		public void RewindBits(int count)
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x127BFE0", Offset = "0x127BFE0", VA = "0x127BFE0")]
		public void FlushBits()
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x127BFF4", Offset = "0x127BFF4", VA = "0x127BFF4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x127C004", Offset = "0x127C004", VA = "0x127C004")]
		public BitReservoir()
		{
		}
	}
	[Token(Token = "0x2000100")]
	internal abstract class FrameBase
	{
		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _totalAllocation;

		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8010C0", Offset = "0x8010C0")]
		private long <Offset>k__BackingField;

		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8010D0", Offset = "0x8010D0")]
		private int <Length>k__BackingField;

		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MpegStreamReader _reader;

		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private byte[] _savedBuffer;

		[Token(Token = "0x170000AB")]
		internal static int TotalAllocation
		{
			[Token(Token = "0x6000834")]
			[Address(RVA = "0x127C06C", Offset = "0x127C06C", VA = "0x127C06C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000AC")]
		internal long Offset
		{
			[Token(Token = "0x6000835")]
			[Address(RVA = "0x127C0DC", Offset = "0x127C0DC", VA = "0x127C0DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8040AC", Offset = "0x8040AC")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000836")]
			[Address(RVA = "0x127C0E4", Offset = "0x127C0E4", VA = "0x127C0E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8040BC", Offset = "0x8040BC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		internal int Length
		{
			[Token(Token = "0x6000837")]
			[Address(RVA = "0x127C0EC", Offset = "0x127C0EC", VA = "0x127C0EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8040CC", Offset = "0x8040CC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000838")]
			[Address(RVA = "0x127C0F4", Offset = "0x127C0F4", VA = "0x127C0F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8040DC", Offset = "0x8040DC")]
			set
			{
			}
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x127C0FC", Offset = "0x127C0FC", VA = "0x127C0FC")]
		protected FrameBase()
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x127C104", Offset = "0x127C104", VA = "0x127C104")]
		internal bool Validate(long offset, MpegStreamReader reader)
		{
			return default(bool);
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x127C14C", Offset = "0x127C14C", VA = "0x127C14C")]
		protected int Read(int offset, byte[] buffer)
		{
			return default(int);
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x127C168", Offset = "0x127C168", VA = "0x127C168")]
		protected int Read(int offset, byte[] buffer, int index, int count)
		{
			return default(int);
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x127C204", Offset = "0x127C204", VA = "0x127C204")]
		protected int ReadByte(int offset)
		{
			return default(int);
		}

		[Token(Token = "0x600083E")]
		protected abstract int Validate();

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x127C2E0", Offset = "0x127C2E0", VA = "0x127C2E0")]
		internal void SaveBuffer()
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x127C390", Offset = "0x127C390", VA = "0x127C390")]
		internal void ClearBuffer()
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x127C40C", Offset = "0x127C40C", VA = "0x127C40C", Slot = "5")]
		internal virtual void Parse()
		{
		}
	}
	[Token(Token = "0x2000101")]
	internal class Huffman
	{
		[Token(Token = "0x20001A4")]
		private class HuffmanListNode
		{
			[Token(Token = "0x4000C90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal byte Value;

			[Token(Token = "0x4000C91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int Length;

			[Token(Token = "0x4000C92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int Bits;

			[Token(Token = "0x4000C93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal int Mask;

			[Token(Token = "0x4000C94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal HuffmanListNode Next;

			[Token(Token = "0x6000B0B")]
			[Address(RVA = "0x127DB2C", Offset = "0x127DB2C", VA = "0x127DB2C")]
			public HuffmanListNode()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001A5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8000D0", Offset = "0x8000D0")]
		private sealed class <>c
		{
			[Token(Token = "0x4000C95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000C96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Comparison<HuffmanListNode> <>9__12_0;

			[Token(Token = "0x6000B0D")]
			[Address(RVA = "0x127DBA0", Offset = "0x127DBA0", VA = "0x127DBA0")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B0E")]
			[Address(RVA = "0x127DBA8", Offset = "0x127DBA8", VA = "0x127DBA8")]
			internal int <BuildLinkedList>b__12_0(HuffmanListNode i1, HuffmanListNode i2)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly byte[][,] _codeTables;

		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly float[] _floatLookup;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static HuffmanListNode[] _llCache;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static int[] _llCacheMaxBits;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly int[] LIN_BITS;

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x127C414", Offset = "0x127C414", VA = "0x127C414")]
		static Huffman()
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x127CBC4", Offset = "0x127CBC4", VA = "0x127CBC4")]
		internal static void Decode(BitReservoir br, int table, out float x, out float y)
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x127CF38", Offset = "0x127CF38", VA = "0x127CF38")]
		internal static void Decode(BitReservoir br, int table, out float x, out float y, out float v, out float w)
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x127CE38", Offset = "0x127CE38", VA = "0x127CE38")]
		private static byte DecodeSymbol(BitReservoir br, int table)
		{
			return default(byte);
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x127D268", Offset = "0x127D268", VA = "0x127D268")]
		private static HuffmanListNode GetNode(int table, out int maxBits)
		{
			return null;
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x127D47C", Offset = "0x127D47C", VA = "0x127D47C")]
		private static HuffmanListNode InitTable(byte[,] tree, out int maxBits)
		{
			return null;
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x127D6C0", Offset = "0x127D6C0", VA = "0x127D6C0")]
		private static int FindPreviousNode(byte[,] tree, int idx, out int bit)
		{
			return default(int);
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x127D81C", Offset = "0x127D81C", VA = "0x127D81C")]
		private static HuffmanListNode BuildLinkedList(List<byte> values, List<int> lengthList, List<int> codeList, out int maxBits)
		{
			return null;
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x127DB34", Offset = "0x127DB34", VA = "0x127DB34")]
		public Huffman()
		{
		}
	}
	[Token(Token = "0x2000102")]
	internal class ID3Frame : FrameBase
	{
		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _version;

		[Token(Token = "0x170000AE")]
		internal int Version
		{
			[Token(Token = "0x6000853")]
			[Address(RVA = "0x127DE64", Offset = "0x127DE64", VA = "0x127DE64")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x127DBD0", Offset = "0x127DBD0", VA = "0x127DBD0")]
		internal static ID3Frame TrySync(uint syncMark)
		{
			return null;
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x127DCA0", Offset = "0x127DCA0", VA = "0x127DCA0")]
		private ID3Frame()
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x127DD08", Offset = "0x127DD08", VA = "0x127DD08", Slot = "4")]
		protected override int Validate()
		{
			return default(int);
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x127DE54", Offset = "0x127DE54", VA = "0x127DE54", Slot = "5")]
		internal override void Parse()
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x127DE60", Offset = "0x127DE60", VA = "0x127DE60")]
		private void ParseV1(int offset)
		{
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x127DE5C", Offset = "0x127DE5C", VA = "0x127DE5C")]
		private void ParseV1Enh()
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x127DE58", Offset = "0x127DE58", VA = "0x127DE58")]
		private void ParseV2()
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x127DE74", Offset = "0x127DE74", VA = "0x127DE74")]
		internal void Merge(ID3Frame newFrame)
		{
		}
	}
	[Token(Token = "0x2000103")]
	internal abstract class LayerDecoderBase
	{
		[Token(Token = "0x4000917")]
		protected const int SBLIMIT = 32;

		[Token(Token = "0x4000918")]
		private const float INV_SQRT_2 = 0.70710677f;

		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float[] DEWINDOW_TABLE;

		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static float[] SYNTH_COS64_TABLE;

		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<float[]> _synBuf;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<int> _bufOffset;

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float[] _eq;

		[Token(Token = "0x400091E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8010E0", Offset = "0x8010E0")]
		private StereoMode <StereoMode>k__BackingField;

		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] ippuv;

		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float[] ei32;

		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float[] eo32;

		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float[] oi32;

		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float[] oo32;

		[Token(Token = "0x4000924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float[] ei16;

		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float[] eo16;

		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float[] oi16;

		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] oo16;

		[Token(Token = "0x4000928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float[] ei8;

		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float[] tmp8;

		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float[] oi8;

		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float[] oo8;

		[Token(Token = "0x170000AF")]
		internal StereoMode StereoMode
		{
			[Token(Token = "0x6000858")]
			[Address(RVA = "0x127E010", Offset = "0x127E010", VA = "0x127E010")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8040EC", Offset = "0x8040EC")]
			get
			{
				return default(StereoMode);
			}
			[Token(Token = "0x6000859")]
			[Address(RVA = "0x127E018", Offset = "0x127E018", VA = "0x127E018")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8040FC", Offset = "0x8040FC")]
			set
			{
			}
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x127DE78", Offset = "0x127DE78", VA = "0x127DE78")]
		internal LayerDecoderBase()
		{
		}

		[Token(Token = "0x6000856")]
		internal abstract int DecodeFrame(IMpegFrame frame, float[] ch0, float[] ch1);

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x127DFF8", Offset = "0x127DFF8", VA = "0x127DFF8")]
		internal void SetEQ(float[] eq)
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x127E020", Offset = "0x127E020", VA = "0x127E020", Slot = "5")]
		internal virtual void ResetForSeek()
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x127E090", Offset = "0x127E090", VA = "0x127E090")]
		protected void InversePolyPhase(int channel, float[] data)
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x127E16C", Offset = "0x127E16C", VA = "0x127E16C")]
		private void GetBufAndOffset(int channel, out float[] synBuf, out int k)
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x127E2D0", Offset = "0x127E2D0", VA = "0x127E2D0")]
		private void DCT32(float[] _in, float[] _out, int k)
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x127E940", Offset = "0x127E940", VA = "0x127E940")]
		private void DCT16(float[] _in, float[] _out)
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x127F02C", Offset = "0x127F02C", VA = "0x127F02C")]
		private void DCT8(float[] _in, float[] _out)
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x127E548", Offset = "0x127E548", VA = "0x127E548")]
		private void BuildUVec(float[] u_vec, float[] cur_synbuf, int k)
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x127E6BC", Offset = "0x127E6BC", VA = "0x127E6BC")]
		private void DewindowOutput(float[] u_vec, float[] samples)
		{
		}
	}
	[Token(Token = "0x2000104")]
	internal class LayerIDecoder : LayerIIDecoderBase
	{
		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[] _rateTable;

		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int[][] _allocLookupTable;

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x127F90C", Offset = "0x127F90C", VA = "0x127F90C")]
		internal static bool GetCRC(MpegFrame frame, ref uint crc)
		{
			return default(bool);
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x127FCAC", Offset = "0x127FCAC", VA = "0x127FCAC")]
		internal LayerIDecoder()
		{
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x1280100", Offset = "0x1280100", VA = "0x1280100", Slot = "6")]
		protected override int[] GetRateTable(IMpegFrame frame)
		{
			return null;
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x1280168", Offset = "0x1280168", VA = "0x1280168", Slot = "7")]
		protected override void ReadScaleFactorSelection(IMpegFrame frame, int[][] scfsi, int channels)
		{
		}
	}
	[Token(Token = "0x2000105")]
	internal class LayerIIDecoder : LayerIIDecoderBase
	{
		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[][] _rateLookupTable;

		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int[][] _allocLookupTable;

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x1280268", Offset = "0x1280268", VA = "0x1280268")]
		internal static bool GetCRC(MpegFrame frame, ref uint crc)
		{
			return default(bool);
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x128032C", Offset = "0x128032C", VA = "0x128032C")]
		private static int[] SelectTable(IMpegFrame frame)
		{
			return null;
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x12807B0", Offset = "0x12807B0", VA = "0x12807B0")]
		internal LayerIIDecoder()
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x128084C", Offset = "0x128084C", VA = "0x128084C", Slot = "6")]
		protected override int[] GetRateTable(IMpegFrame frame)
		{
			return null;
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x12808B0", Offset = "0x12808B0", VA = "0x12808B0", Slot = "7")]
		protected override void ReadScaleFactorSelection(IMpegFrame frame, int[][] scfsi, int channels)
		{
		}
	}
	[Token(Token = "0x2000106")]
	internal abstract class LayerIIDecoderBase : LayerDecoderBase
	{
		[Token(Token = "0x4000930")]
		protected const int SSLIMIT = 12;

		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly float[] _groupedC;

		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly float[] _groupedD;

		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly float[] _C;

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly float[] _D;

		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly float[] _denormalMultiplier;

		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int _channels;

		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int _jsbound;

		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int _granuleCount;

		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int[][] _allocLookupTable;

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int[][] _scfsi;

		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int[][] _samples;

		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int[][][] _scalefac;

		[Token(Token = "0x400093D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float[] _polyPhaseBuf;

		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int[][] _allocation;

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x127F9C4", Offset = "0x127F9C4", VA = "0x127F9C4")]
		protected static bool GetCRC(MpegFrame frame, int[] rateTable, int[][] allocLookupTable, bool readScfsiBits, ref uint crc)
		{
			return default(bool);
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x127FD48", Offset = "0x127FD48", VA = "0x127FD48")]
		protected LayerIIDecoderBase(int[][] allocLookupTable, int granuleCount)
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x1280EA0", Offset = "0x1280EA0", VA = "0x1280EA0", Slot = "4")]
		internal override int DecodeFrame(IMpegFrame frame, float[] ch0, float[] ch1)
		{
			return default(int);
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x128101C", Offset = "0x128101C", VA = "0x128101C")]
		private void InitFrame(IMpegFrame frame)
		{
		}

		[Token(Token = "0x6000872")]
		protected abstract int[] GetRateTable(IMpegFrame frame);

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x128117C", Offset = "0x128117C", VA = "0x128117C")]
		private void ReadAllocation(IMpegFrame frame, int[] rateTable)
		{
		}

		[Token(Token = "0x6000874")]
		protected abstract void ReadScaleFactorSelection(IMpegFrame frame, int[][] scfsi, int channels);

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x12814D4", Offset = "0x12814D4", VA = "0x12814D4")]
		private void ReadScaleFactors(IMpegFrame frame)
		{
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x1281C34", Offset = "0x1281C34", VA = "0x1281C34")]
		private void ReadSamples(IMpegFrame frame)
		{
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x1282084", Offset = "0x1282084", VA = "0x1282084")]
		private int DecodeSamples(float[] ch0, float[] ch1)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000107")]
	internal sealed class LayerIIIDecoder : LayerDecoderBase
	{
		[Token(Token = "0x20001A6")]
		private class HybridMDCT
		{
			[Token(Token = "0x4000C97")]
			private const float PI = (float)Math.PI;

			[Token(Token = "0x4000C98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static float[][] _swin;

			[Token(Token = "0x4000C99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static float[] icos72_table;

			[Token(Token = "0x4000C9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private List<float[]> _prevBlock;

			[Token(Token = "0x4000C9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private List<float[]> _nextBlock;

			[Token(Token = "0x4000C9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private float[] _imdctTemp;

			[Token(Token = "0x4000C9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float[] _imdctResult;

			[Token(Token = "0x4000C9E")]
			private const float sqrt32 = 0.8660254f;

			[Token(Token = "0x6000B0F")]
			[Address(RVA = "0xE30810", Offset = "0xE30810", VA = "0xE30810")]
			static HybridMDCT()
			{
			}

			[Token(Token = "0x6000B10")]
			[Address(RVA = "0xE28570", Offset = "0xE28570", VA = "0xE28570")]
			internal HybridMDCT()
			{
			}

			[Token(Token = "0x6000B11")]
			[Address(RVA = "0xE2EC2C", Offset = "0xE2EC2C", VA = "0xE2EC2C")]
			internal void Reset()
			{
			}

			[Token(Token = "0x6000B12")]
			[Address(RVA = "0xE30E24", Offset = "0xE30E24", VA = "0xE30E24")]
			private void GetPrevBlock(int channel, out float[] prevBlock, out float[] nextBlock)
			{
			}

			[Token(Token = "0x6000B13")]
			[Address(RVA = "0xE2E968", Offset = "0xE2E968", VA = "0xE2E968")]
			internal void Apply(float[] fsIn, int channel, int blockType, bool doMixed)
			{
			}

			[Token(Token = "0x6000B14")]
			[Address(RVA = "0xE30F98", Offset = "0xE30F98", VA = "0xE30F98")]
			private void LongImpl(float[] fsIn, int sbStart, int sbLimit, float[] nextblck, int blockType)
			{
			}

			[Token(Token = "0x6000B15")]
			[Address(RVA = "0xE3148C", Offset = "0xE3148C", VA = "0xE3148C")]
			private static void LongIMDCT(float[] invec, float[] outvec)
			{
			}

			[Token(Token = "0x6000B16")]
			[Address(RVA = "0xE31FF0", Offset = "0xE31FF0", VA = "0xE31FF0")]
			private static float ICOS72_A(int i)
			{
				return default(float);
			}

			[Token(Token = "0x6000B17")]
			[Address(RVA = "0xE31F50", Offset = "0xE31F50", VA = "0xE31F50")]
			private static float ICOS36_A(int i)
			{
				return default(float);
			}

			[Token(Token = "0x6000B18")]
			[Address(RVA = "0xE31B20", Offset = "0xE31B20", VA = "0xE31B20")]
			private static void imdct_9pt(float[] invec, float[] outvec)
			{
			}

			[Token(Token = "0x6000B19")]
			[Address(RVA = "0xE311A0", Offset = "0xE311A0", VA = "0xE311A0")]
			private void ShortImpl(float[] fsIn, int sbStart, float[] nextblck)
			{
			}

			[Token(Token = "0x6000B1A")]
			[Address(RVA = "0xE32088", Offset = "0xE32088", VA = "0xE32088")]
			private static void ShortIMDCT(float[] invec, int inIdx, float[] outvec)
			{
			}
		}

		[Token(Token = "0x400093F")]
		private const int SSLIMIT = 18;

		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private HybridMDCT _hybrid;

		[Token(Token = "0x4000941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BitReservoir _bitRes;

		[Token(Token = "0x4000942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int _channels;

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int _privBits;

		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int _mainDataBegin;

		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int[][] _scfsi;

		[Token(Token = "0x4000946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int[][] _part23Length;

		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int[][] _bigValues;

		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float[][] _globalGain;

		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int[][] _scalefacCompress;

		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool[][] _blockSplitFlag;

		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool[][] _mixedBlockFlag;

		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int[][] _blockType;

		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int[][][] _tableSelect;

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private float[][][] _subblockGain;

		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int[][] _regionAddress1;

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int[][] _regionAddress2;

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private int[][] _preflag;

		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private float[][] _scalefacScale;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private int[][] _count1TableSelect;

		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float[] GAIN_TAB;

		[Token(Token = "0x4000955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private int[] _sfBandIndexL;

		[Token(Token = "0x4000956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private int[] _sfBandIndexS;

		[Token(Token = "0x4000957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private byte[] _cbLookupL;

		[Token(Token = "0x4000958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private byte[] _cbLookupS;

		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private byte[] _cbwLookupS;

		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private int _cbLookupSR;

		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int[][] _sfBandIndexLTable;

		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int[][] _sfBandIndexSTable;

		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int[][][] _scalefac;

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly int[][] _slen;

		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly int[][][] _sfbBlockCntTab;

		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float[][] _samples;

		[Token(Token = "0x4000961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly int[] PRETAB;

		[Token(Token = "0x4000962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly float[] POW2_TAB;

		[Token(Token = "0x4000963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly float[][] _isRatio;

		[Token(Token = "0x4000964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly float[][][] _lsfRatio;

		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float[] _reorderBuf;

		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static readonly float[] _scs;

		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static readonly float[] _sca;

		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float[] _polyPhase;

		[Token(Token = "0x6000879")]
		[Address(RVA = "0xE27464", Offset = "0xE27464", VA = "0xE27464")]
		internal static bool GetCRC(MpegFrame frame, ref uint crc)
		{
			return default(bool);
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0xE2776C", Offset = "0xE2776C", VA = "0xE2776C")]
		internal LayerIIIDecoder()
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0xE2862C", Offset = "0xE2862C", VA = "0xE2862C", Slot = "4")]
		internal override int DecodeFrame(IMpegFrame frame, float[] ch0, float[] ch1)
		{
			return default(int);
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0xE2EBEC", Offset = "0xE2EBEC", VA = "0xE2EBEC", Slot = "5")]
		internal override void ResetForSeek()
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0xE28CA4", Offset = "0xE28CA4", VA = "0xE28CA4")]
		private void ReadSideInfo(IMpegFrame frame)
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0xE2B288", Offset = "0xE2B288", VA = "0xE2B288")]
		private void PrepTables(IMpegFrame frame)
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0xE2B990", Offset = "0xE2B990", VA = "0xE2B990")]
		private int ReadScalefactors(int gr, int ch)
		{
			return default(int);
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0xE2C980", Offset = "0xE2C980", VA = "0xE2C980")]
		private int ReadLsfScalefactors(int gr, int ch, int chanModeExt)
		{
			return default(int);
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0xE2D3F0", Offset = "0xE2D3F0", VA = "0xE2D3F0")]
		private void ReadSamples(int sfBits, int gr, int ch)
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0xE2EC94", Offset = "0xE2EC94", VA = "0xE2EC94")]
		private float Dequantize(int idx, float val, int gr, int ch)
		{
			return default(float);
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0xE2DD48", Offset = "0xE2DD48", VA = "0xE2DD48")]
		private void Stereo(MpegChannelMode channelMode, int chanModeExt, int gr, bool lsf)
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0xE2F510", Offset = "0xE2F510", VA = "0xE2F510")]
		private void ApplyIStereo(int i, int sb, int isPos)
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0xE2F328", Offset = "0xE2F328", VA = "0xE2F328")]
		private void ApplyLsfIStereo(int i, int sb, int isPos, int scalefacCompress)
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0xE2F138", Offset = "0xE2F138", VA = "0xE2F138")]
		private void ApplyMidSide(int i, int sb)
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0xE2F27C", Offset = "0xE2F27C", VA = "0xE2F27C")]
		private void ApplyFullStereo(int i, int sb)
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0xE2E658", Offset = "0xE2E658", VA = "0xE2E658")]
		private void Reorder(float[] buf, bool mixedBlock)
		{
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0xE2E780", Offset = "0xE2E780", VA = "0xE2E780")]
		private void AntiAlias(float[] buf, bool mixedBlock)
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0xE2EA90", Offset = "0xE2EA90", VA = "0xE2EA90")]
		private void FrequencyInversion(float[] buf)
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0xE2EB00", Offset = "0xE2EB00", VA = "0xE2EB00")]
		private void InversePolyphase(float[] buf, int ch, int ofs, float[] outBuf)
		{
		}
	}
	[Token(Token = "0x2000108")]
	internal class MpegFrame : FrameBase, IMpegFrame
	{
		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[][][] _bitRateTable;

		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal MpegFrame Next;

		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal int Number;

		[Token(Token = "0x400096C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _syncBits;

		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _readOffset;

		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int _bitsRead;

		[Token(Token = "0x400096F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ulong _bitBucket;

		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private long _offset;

		[Token(Token = "0x4000971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _isMuted;

		[Token(Token = "0x170000B0")]
		public int FrameLength
		{
			[Token(Token = "0x6000896")]
			[Address(RVA = "0xE33660", Offset = "0xE33660", VA = "0xE33660", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B1")]
		public MpegVersion Version
		{
			[Token(Token = "0x6000897")]
			[Address(RVA = "0xE32ED8", Offset = "0xE32ED8", VA = "0xE32ED8", Slot = "10")]
			get
			{
				return default(MpegVersion);
			}
		}

		[Token(Token = "0x170000B2")]
		public MpegLayer Layer
		{
			[Token(Token = "0x6000898")]
			[Address(RVA = "0xE32B18", Offset = "0xE32B18", VA = "0xE32B18", Slot = "11")]
			get
			{
				return default(MpegLayer);
			}
		}

		[Token(Token = "0x170000B3")]
		public bool HasCrc
		{
			[Token(Token = "0x6000899")]
			[Address(RVA = "0xE32CD0", Offset = "0xE32CD0", VA = "0xE32CD0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B4")]
		public int BitRate
		{
			[Token(Token = "0x600089A")]
			[Address(RVA = "0xE32B28", Offset = "0xE32B28", VA = "0xE32B28", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B5")]
		public int BitRateIndex
		{
			[Token(Token = "0x600089B")]
			[Address(RVA = "0xE32C80", Offset = "0xE32C80", VA = "0xE32C80", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B6")]
		public int SampleRate
		{
			[Token(Token = "0x600089C")]
			[Address(RVA = "0xE32C8C", Offset = "0xE32C8C", VA = "0xE32C8C", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B7")]
		public int SampleRateIndex
		{
			[Token(Token = "0x600089D")]
			[Address(RVA = "0xE33668", Offset = "0xE33668", VA = "0xE33668", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B8")]
		private int Padding
		{
			[Token(Token = "0x600089E")]
			[Address(RVA = "0xE32CC4", Offset = "0xE32CC4", VA = "0xE32CC4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B9")]
		public MpegChannelMode ChannelMode
		{
			[Token(Token = "0x600089F")]
			[Address(RVA = "0xE32C74", Offset = "0xE32C74", VA = "0xE32C74", Slot = "12")]
			get
			{
				return default(MpegChannelMode);
			}
		}

		[Token(Token = "0x170000BA")]
		public int ChannelModeExtension
		{
			[Token(Token = "0x60008A0")]
			[Address(RVA = "0xE32ECC", Offset = "0xE32ECC", VA = "0xE32ECC", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000BB")]
		internal int Channels
		{
			[Token(Token = "0x60008A1")]
			[Address(RVA = "0xE33604", Offset = "0xE33604", VA = "0xE33604")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000BC")]
		public bool IsCopyrighted
		{
			[Token(Token = "0x60008A2")]
			[Address(RVA = "0xE33674", Offset = "0xE33674", VA = "0xE33674", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BD")]
		internal bool IsOriginal
		{
			[Token(Token = "0x60008A3")]
			[Address(RVA = "0xE33680", Offset = "0xE33680", VA = "0xE33680")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BE")]
		internal int EmphasisMode
		{
			[Token(Token = "0x60008A4")]
			[Address(RVA = "0xE3368C", Offset = "0xE3368C", VA = "0xE3368C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000BF")]
		public bool IsCorrupted
		{
			[Token(Token = "0x60008A5")]
			[Address(RVA = "0xE33698", Offset = "0xE33698", VA = "0xE33698", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C0")]
		public int SampleCount
		{
			[Token(Token = "0x60008A6")]
			[Address(RVA = "0xE3361C", Offset = "0xE3361C", VA = "0xE3361C", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000C1")]
		internal long SampleOffset
		{
			[Token(Token = "0x60008A7")]
			[Address(RVA = "0xE336A0", Offset = "0xE336A0", VA = "0xE336A0")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60008A8")]
			[Address(RVA = "0xE336A8", Offset = "0xE336A8", VA = "0xE336A8")]
			set
			{
			}
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0xE32830", Offset = "0xE32830", VA = "0xE32830")]
		internal static MpegFrame TrySync(uint syncMark)
		{
			return null;
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0xE328F4", Offset = "0xE328F4", VA = "0xE328F4")]
		private MpegFrame()
		{
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0xE3295C", Offset = "0xE3295C", VA = "0xE3295C", Slot = "4")]
		protected override int Validate()
		{
			return default(int);
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0xE27554", Offset = "0xE27554", VA = "0xE27554")]
		internal int GetSideDataSize()
		{
			return default(int);
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0xE32CE0", Offset = "0xE32CE0", VA = "0xE32CE0")]
		private bool ValidateCRC()
		{
			return default(bool);
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0xE27720", Offset = "0xE27720", VA = "0xE27720")]
		internal static void UpdateCRC(int data, int length, ref uint crc)
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0xE32EF4", Offset = "0xE32EF4", VA = "0xE32EF4")]
		internal VBRInfo ParseVBR()
		{
			return null;
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0xE330FC", Offset = "0xE330FC", VA = "0xE330FC")]
		private VBRInfo ParseXing(int offset)
		{
			return null;
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0xE333A4", Offset = "0xE333A4", VA = "0xE333A4")]
		private VBRInfo ParseVBRI()
		{
			return null;
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0xE32E90", Offset = "0xE32E90", VA = "0xE32E90", Slot = "19")]
		public void Reset()
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0xE275F0", Offset = "0xE275F0", VA = "0xE275F0", Slot = "20")]
		public int ReadBits(int bitCount)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000109")]
	internal class MpegStreamReader
	{
		[Token(Token = "0x20001A7")]
		private class ReadBuffer
		{
			[Token(Token = "0x4000C9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public byte[] Data;

			[Token(Token = "0x4000CA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public long BaseOffset;

			[Token(Token = "0x4000CA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int End;

			[Token(Token = "0x4000CA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int DiscardCount;

			[Token(Token = "0x4000CA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object _localLock;

			[Token(Token = "0x6000B1B")]
			[Address(RVA = "0xE33B30", Offset = "0xE33B30", VA = "0xE33B30")]
			public ReadBuffer(int initialSize)
			{
			}

			[Token(Token = "0x6000B1C")]
			[Address(RVA = "0xE3445C", Offset = "0xE3445C", VA = "0xE3445C")]
			public int Read(MpegStreamReader reader, long offset, byte[] buffer, int index, int count)
			{
				return default(int);
			}

			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0xE345DC", Offset = "0xE345DC", VA = "0xE345DC")]
			public int ReadByte(MpegStreamReader reader, long offset)
			{
				return default(int);
			}

			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0xE34D44", Offset = "0xE34D44", VA = "0xE34D44")]
			private int EnsureFilled(MpegStreamReader reader, long offset, ref int count)
			{
				return default(int);
			}

			[Token(Token = "0x6000B1F")]
			[Address(RVA = "0xE34718", Offset = "0xE34718", VA = "0xE34718")]
			public void DiscardThrough(long offset)
			{
			}

			[Token(Token = "0x6000B20")]
			[Address(RVA = "0xE35308", Offset = "0xE35308", VA = "0xE35308")]
			private void Truncate()
			{
			}

			[Token(Token = "0x6000B21")]
			[Address(RVA = "0xE35310", Offset = "0xE35310", VA = "0xE35310")]
			private void CommitDiscard()
			{
			}
		}

		[Token(Token = "0x4000972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ID3Frame _id3Frame;

		[Token(Token = "0x4000973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ID3Frame _id3v1Frame;

		[Token(Token = "0x4000974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RiffHeaderFrame _riffHeaderFrame;

		[Token(Token = "0x4000975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VBRInfo _vbrInfo;

		[Token(Token = "0x4000976")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MpegFrame _first;

		[Token(Token = "0x4000977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private MpegFrame _current;

		[Token(Token = "0x4000978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private MpegFrame _last;

		[Token(Token = "0x4000979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private MpegFrame _lastFree;

		[Token(Token = "0x400097A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private long _readOffset;

		[Token(Token = "0x400097B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private long _eofOffset;

		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Stream _source;

		[Token(Token = "0x400097D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _canSeek;

		[Token(Token = "0x400097E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool _endFound;

		[Token(Token = "0x400097F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool _mixedFrameSize;

		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private object _readLock;

		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private object _frameLock;

		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ReadBuffer _readBuf;

		[Token(Token = "0x170000C2")]
		internal bool CanSeek
		{
			[Token(Token = "0x60008B2")]
			[Address(RVA = "0xE349A8", Offset = "0xE349A8", VA = "0xE349A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C3")]
		internal long SampleCount
		{
			[Token(Token = "0x60008B3")]
			[Address(RVA = "0xE349B0", Offset = "0xE349B0", VA = "0xE349B0")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170000C4")]
		internal int SampleRate
		{
			[Token(Token = "0x60008B4")]
			[Address(RVA = "0xE34A30", Offset = "0xE34A30", VA = "0xE34A30")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000C5")]
		internal int Channels
		{
			[Token(Token = "0x60008B5")]
			[Address(RVA = "0xE34A58", Offset = "0xE34A58", VA = "0xE34A58")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000C6")]
		internal int FirstFrameSampleCount
		{
			[Token(Token = "0x60008B6")]
			[Address(RVA = "0xE34A94", Offset = "0xE34A94", VA = "0xE34A94")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0xE33988", Offset = "0xE33988", VA = "0xE33988")]
		internal MpegStreamReader(Stream source)
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0xE33C0C", Offset = "0xE33C0C", VA = "0xE33C0C")]
		private FrameBase FindNextFrame()
		{
			return null;
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0xE342DC", Offset = "0xE342DC", VA = "0xE342DC")]
		internal int Read(long offset, byte[] buffer, int index, int count)
		{
			return default(int);
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0xE3453C", Offset = "0xE3453C", VA = "0xE3453C")]
		internal int ReadByte(long offset)
		{
			return default(int);
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0xE343D0", Offset = "0xE343D0", VA = "0xE343D0")]
		internal void DiscardThrough(long offset, bool minimalRead)
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0xE34834", Offset = "0xE34834", VA = "0xE34834")]
		internal void ReadToEnd()
		{
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0xE34AA4", Offset = "0xE34AA4", VA = "0xE34AA4")]
		internal long SeekTo(long sampleNumber)
		{
			return default(long);
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xE34C28", Offset = "0xE34C28", VA = "0xE34C28")]
		internal MpegFrame NextFrame()
		{
			return null;
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0xE34D3C", Offset = "0xE34D3C", VA = "0xE34D3C")]
		internal MpegFrame GetCurrentFrame()
		{
			return null;
		}
	}
	[Token(Token = "0x200010A")]
	internal class RiffHeaderFrame : FrameBase
	{
		[Token(Token = "0x60008BA")]
		[Address(RVA = "0xE343E8", Offset = "0xE343E8", VA = "0xE343E8")]
		internal static RiffHeaderFrame TrySync(uint syncMark)
		{
			return null;
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0xE35398", Offset = "0xE35398", VA = "0xE35398")]
		private RiffHeaderFrame()
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0xE35400", Offset = "0xE35400", VA = "0xE35400", Slot = "4")]
		protected override int Validate()
		{
			return default(int);
		}
	}
	[Token(Token = "0x200010B")]
	internal class VBRInfo
	{
		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8010F0", Offset = "0x8010F0")]
		private int <SampleCount>k__BackingField;

		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801100", Offset = "0x801100")]
		private int <SampleRate>k__BackingField;

		[Token(Token = "0x4000985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801110", Offset = "0x801110")]
		private int <Channels>k__BackingField;

		[Token(Token = "0x4000986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801120", Offset = "0x801120")]
		private int <VBRFrames>k__BackingField;

		[Token(Token = "0x4000987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801130", Offset = "0x801130")]
		private int <VBRBytes>k__BackingField;

		[Token(Token = "0x4000988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801140", Offset = "0x801140")]
		private int <VBRQuality>k__BackingField;

		[Token(Token = "0x4000989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801150", Offset = "0x801150")]
		private int <VBRDelay>k__BackingField;

		[Token(Token = "0x170000C7")]
		internal int SampleCount
		{
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0xE35644", Offset = "0xE35644", VA = "0xE35644")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80410C", Offset = "0x80410C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0xE3564C", Offset = "0xE3564C", VA = "0xE3564C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80411C", Offset = "0x80411C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		internal int SampleRate
		{
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0xE35654", Offset = "0xE35654", VA = "0xE35654")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80412C", Offset = "0x80412C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008C1")]
			[Address(RVA = "0xE3565C", Offset = "0xE3565C", VA = "0xE3565C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80413C", Offset = "0x80413C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		internal int Channels
		{
			[Token(Token = "0x60008C2")]
			[Address(RVA = "0xE35664", Offset = "0xE35664", VA = "0xE35664")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80414C", Offset = "0x80414C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008C3")]
			[Address(RVA = "0xE3566C", Offset = "0xE3566C", VA = "0xE3566C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80415C", Offset = "0x80415C")]
			set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		internal int VBRFrames
		{
			[Token(Token = "0x60008C4")]
			[Address(RVA = "0xE35674", Offset = "0xE35674", VA = "0xE35674")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80416C", Offset = "0x80416C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008C5")]
			[Address(RVA = "0xE3567C", Offset = "0xE3567C", VA = "0xE3567C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80417C", Offset = "0x80417C")]
			set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		internal int VBRBytes
		{
			[Token(Token = "0x60008C6")]
			[Address(RVA = "0xE35684", Offset = "0xE35684", VA = "0xE35684")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80418C", Offset = "0x80418C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008C7")]
			[Address(RVA = "0xE3568C", Offset = "0xE3568C", VA = "0xE3568C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80419C", Offset = "0x80419C")]
			set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		internal int VBRQuality
		{
			[Token(Token = "0x60008C8")]
			[Address(RVA = "0xE35694", Offset = "0xE35694", VA = "0xE35694")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8041AC", Offset = "0x8041AC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008C9")]
			[Address(RVA = "0xE3569C", Offset = "0xE3569C", VA = "0xE3569C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8041BC", Offset = "0x8041BC")]
			set
			{
			}
		}

		[Token(Token = "0x170000CD")]
		internal int VBRDelay
		{
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0xE356A4", Offset = "0xE356A4", VA = "0xE356A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8041CC", Offset = "0x8041CC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008CB")]
			[Address(RVA = "0xE356AC", Offset = "0xE356AC", VA = "0xE356AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8041DC", Offset = "0x8041DC")]
			set
			{
			}
		}

		[Token(Token = "0x170000CE")]
		internal long VBRStreamSampleCount
		{
			[Token(Token = "0x60008CC")]
			[Address(RVA = "0xE34A1C", Offset = "0xE34A1C", VA = "0xE34A1C")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170000CF")]
		internal int VBRAverageBitrate
		{
			[Token(Token = "0x60008CD")]
			[Address(RVA = "0xE356B4", Offset = "0xE356B4", VA = "0xE356B4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0xE335FC", Offset = "0xE335FC", VA = "0xE335FC")]
		internal VBRInfo()
		{
		}
	}
}
namespace MeshBrush
{
	[Token(Token = "0x200010C")]
	public class MeshBrush : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8000E0", Offset = "0x8000E0")]
		private sealed class <>c
		{
			[Token(Token = "0x4000CA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000CA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Transform, MeshFilter> <>9__113_0;

			[Token(Token = "0x4000CA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Keyframe, XElement> <>9__126_0;

			[Token(Token = "0x4000CA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<bool, int, XElement> <>9__126_1;

			[Token(Token = "0x4000CA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<XElement, Keyframe> <>9__127_1;

			[Token(Token = "0x4000CA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<XElement, bool> <>9__127_0;

			[Token(Token = "0x6000B23")]
			[Address(RVA = "0x12778A4", Offset = "0x12778A4", VA = "0x12778A4")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B24")]
			[Address(RVA = "0x12778AC", Offset = "0x12778AC", VA = "0x12778AC")]
			internal MeshFilter <CombineMeshes>b__113_0(Transform mesh)
			{
				return null;
			}

			[Token(Token = "0x6000B25")]
			[Address(RVA = "0x1277904", Offset = "0x1277904", VA = "0x1277904")]
			internal XElement <SaveTemplate>b__126_0(Keyframe key)
			{
				return null;
			}

			[Token(Token = "0x6000B26")]
			[Address(RVA = "0x1277BE8", Offset = "0x1277BE8", VA = "0x1277BE8")]
			internal XElement <SaveTemplate>b__126_1(bool layer, int index)
			{
				return null;
			}

			[Token(Token = "0x6000B27")]
			[Address(RVA = "0x1277D8C", Offset = "0x1277D8C", VA = "0x1277D8C")]
			internal Keyframe <LoadTemplate>b__127_1(XElement key)
			{
				return default(Keyframe);
			}

			[Token(Token = "0x6000B28")]
			[Address(RVA = "0x1277F00", Offset = "0x1277F00", VA = "0x1277F00")]
			internal bool <LoadTemplate>b__127_0(XElement layerElement)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400098A")]
		public const float version = 2f;

		[Token(Token = "0x400098B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool active;

		[Token(Token = "0x400098C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string groupName;

		[Token(Token = "0x400098D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool showGlobalPaintingLayersInspector;

		[Token(Token = "0x400098E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool[] layerMask;

		[Token(Token = "0x400098F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float radius;

		[Token(Token = "0x4000990")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color color;

		[Token(Token = "0x4000991")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector2 quantityRange;

		[Token(Token = "0x4000992")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool useDensity;

		[Token(Token = "0x4000993")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector2 densityRange;

		[Token(Token = "0x4000994")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float delay;

		[Token(Token = "0x4000995")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector2 offsetRange;

		[Token(Token = "0x4000996")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector2 slopeInfluenceRange;

		[Token(Token = "0x4000997")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool useSlopeFilter;

		[Token(Token = "0x4000998")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector2 angleThresholdRange;

		[Token(Token = "0x4000999")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool inverseSlopeFilter;

		[Token(Token = "0x400099A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 slopeReferenceVector;

		[Token(Token = "0x400099B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 slopeReferenceVectorSampleLocation;

		[Token(Token = "0x400099C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool yAxisTangent;

		[Token(Token = "0x400099D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
		public bool strokeAlignment;

		[Token(Token = "0x400099E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9E")]
		public bool autoIgnoreRaycast;

		[Token(Token = "0x400099F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector2 scatteringRange;

		[Token(Token = "0x40009A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool useOverlapFilter;

		[Token(Token = "0x40009A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public Vector2 minimumAbsoluteDistanceRange;

		[Token(Token = "0x40009A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public bool uniformRandomScale;

		[Token(Token = "0x40009A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		public bool uniformAdditiveScale;

		[Token(Token = "0x40009A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Vector2 randomScaleRange;

		[Token(Token = "0x40009A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Vector2 randomScaleRangeX;

		[Token(Token = "0x40009A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Vector2 randomScaleRangeY;

		[Token(Token = "0x40009A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Vector2 randomScaleRangeZ;

		[Token(Token = "0x40009A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Vector2 additiveScaleRange;

		[Token(Token = "0x40009A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Vector3 additiveScaleNonUniform;

		[Token(Token = "0x40009AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public AnimationCurve randomScaleCurve;

		[Token(Token = "0x40009AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public float randomScaleCurveVariation;

		[Token(Token = "0x40009AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public Vector2 randomRotationRangeX;

		[Token(Token = "0x40009AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public Vector2 randomRotationRangeY;

		[Token(Token = "0x40009AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public Vector2 randomRotationRangeZ;

		[Token(Token = "0x40009AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public bool positionBrushRandomizer;

		[Token(Token = "0x40009B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x115")]
		public bool rotationBrushRandomizer;

		[Token(Token = "0x40009B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x116")]
		public bool scaleBrushRandomizer;

		[Token(Token = "0x40009B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public KeyCode paintKey;

		[Token(Token = "0x40009B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public KeyCode deleteKey;

		[Token(Token = "0x40009B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public KeyCode combineKey;

		[Token(Token = "0x40009B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public KeyCode randomizeKey;

		[Token(Token = "0x40009B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public KeyCode increaseRadiusKey;

		[Token(Token = "0x40009B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public KeyCode decreaseRadiusKey;

		[Token(Token = "0x40009B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		private int maxQuantityLimit;

		[Token(Token = "0x40009B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		[SerializeField]
		private float maxDelayLimit;

		[Token(Token = "0x40009BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		private float maxDensityLimit;

		[Token(Token = "0x40009BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[SerializeField]
		private float minOffsetLimit;

		[Token(Token = "0x40009BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		private float maxOffsetLimit;

		[Token(Token = "0x40009BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		[SerializeField]
		private float maxMinimumAbsoluteDistanceLimit;

		[Token(Token = "0x40009BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		private float maxAdditiveScaleLimit;

		[Token(Token = "0x40009BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		[SerializeField]
		private float maxRandomScaleLimit;

		[Token(Token = "0x40009C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public bool helpFoldout;

		[Token(Token = "0x40009C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x151")]
		public bool helpTemplatesFoldout;

		[Token(Token = "0x40009C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x152")]
		public bool helpGeneralUsageFoldout;

		[Token(Token = "0x40009C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x153")]
		public bool helpOptimizationFoldout;

		[Token(Token = "0x40009C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		public bool meshesFoldout;

		[Token(Token = "0x40009C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x155")]
		public bool templatesFoldout;

		[Token(Token = "0x40009C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x156")]
		public bool keyBindingsFoldout;

		[Token(Token = "0x40009C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x157")]
		public bool brushFoldout;

		[Token(Token = "0x40009C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public bool slopesFoldout;

		[Token(Token = "0x40009C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x159")]
		public bool randomizersFoldout;

		[Token(Token = "0x40009CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15A")]
		public bool overlapFilterFoldout;

		[Token(Token = "0x40009CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15B")]
		public bool additiveScaleFoldout;

		[Token(Token = "0x40009CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		public bool optimizationFoldout;

		[Token(Token = "0x40009CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15D")]
		[SerializeField]
		private bool globalPaintingMode;

		[Token(Token = "0x40009CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15E")]
		public bool collapsed;

		[Token(Token = "0x40009CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15F")]
		public bool stats;

		[Token(Token = "0x40009D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public bool lockSceneView;

		[Token(Token = "0x40009D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x161")]
		public bool classicUI;

		[Token(Token = "0x40009D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		public float previewIconSize;

		[Token(Token = "0x40009D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public bool manualReferenceVectorSampling;

		[Token(Token = "0x40009D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x169")]
		public bool showReferenceVectorInSceneView;

		[Token(Token = "0x40009D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16A")]
		public bool autoStatic;

		[Token(Token = "0x40009D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16B")]
		public bool autoSelectOnCombine;

		[Token(Token = "0x40009D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Transform cachedTransform;

		[Token(Token = "0x40009D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Collider cachedCollider;

		[Token(Token = "0x40009D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private GameObject brush;

		[Token(Token = "0x40009DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private Transform brushTransform;

		[Token(Token = "0x40009DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Transform holderObj;

		[Token(Token = "0x40009DC")]
		private const string minString = "min";

		[Token(Token = "0x40009DD")]
		private const string maxString = "max";

		[Token(Token = "0x40009DE")]
		private const string trueString = "true";

		[Token(Token = "0x40009DF")]
		private const string falseString = "false";

		[Token(Token = "0x40009E0")]
		private const string enabledString = "enabled";

		[Token(Token = "0x40009E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public Vector3 lastPaintLocation;

		[Token(Token = "0x40009E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		public Vector3 brushStrokeDirection;

		[Token(Token = "0x40009E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private List<GameObject> meshes;

		[Token(Token = "0x40009E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private List<GameObject> deactivatedMeshes;

		[Token(Token = "0x40009E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private List<Transform> paintedMeshes;

		[Token(Token = "0x40009E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private List<Transform> paintedMeshesInsideBrushArea;

		[Token(Token = "0x40009E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private float nextFeasibleStrokeTime;

		[Token(Token = "0x170000D0")]
		public Transform CachedTransform
		{
			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x126A684", Offset = "0x126A684", VA = "0x126A684")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D1")]
		public Collider CachedCollider
		{
			[Token(Token = "0x60008CF")]
			[Address(RVA = "0x126A714", Offset = "0x126A714", VA = "0x126A714")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D2")]
		public GameObject Brush
		{
			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x126A7AC", Offset = "0x126A7AC", VA = "0x126A7AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D3")]
		public Transform BrushTransform
		{
			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x126A8E4", Offset = "0x126A8E4", VA = "0x126A8E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D4")]
		public Transform HolderObj
		{
			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x126A968", Offset = "0x126A968", VA = "0x126A968")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x126AB80", Offset = "0x126AB80", VA = "0x126AB80")]
		public void OnValidate()
		{
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x126AF3C", Offset = "0x126AF3C", VA = "0x126AF3C")]
		private void ValidateRangeLimits()
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x126AED4", Offset = "0x126AED4", VA = "0x126AED4")]
		private void ValidateKeyBindings()
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x126B240", Offset = "0x126B240", VA = "0x126B240")]
		public void GatherPaintedMeshes()
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x126B2B4", Offset = "0x126B2B4", VA = "0x126B2B4")]
		public void CleanSetOfMeshesToPaint()
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x126B3DC", Offset = "0x126B3DC", VA = "0x126B3DC")]
		private void GatherMeshesInsideBrushArea(RaycastHit brushLocation)
		{
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x1268464", Offset = "0x1268464", VA = "0x1268464")]
		public void PaintMeshes(RaycastHit brushLocation)
		{
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x1269320", Offset = "0x1269320", VA = "0x1269320")]
		public void RandomizeMeshes(RaycastHit brushLocation)
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x1269140", Offset = "0x1269140", VA = "0x1269140")]
		public void DeleteMeshes(RaycastHit brushLocation)
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x126C190", Offset = "0x126C190", VA = "0x126C190")]
		public void CombineMeshes(RaycastHit brushLocation)
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x126CE30", Offset = "0x126CE30", VA = "0x126CE30")]
		public void SampleReferenceVector(Vector3 referenceVector, Vector3 sampleLocation)
		{
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x126B914", Offset = "0x126B914", VA = "0x126B914")]
		private void OrientPaintedMesh(Transform targetTransform, RaycastHit targetLocation)
		{
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x126B690", Offset = "0x126B690", VA = "0x126B690")]
		private bool CheckOverlap(Vector3 objPos)
		{
			return default(bool);
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x126A9EC", Offset = "0x126A9EC", VA = "0x126A9EC")]
		private void CheckHolder()
		{
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x126A830", Offset = "0x126A830", VA = "0x126A830")]
		private void CheckBrush()
		{
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x126CE40", Offset = "0x126CE40", VA = "0x126CE40")]
		private void CreateHolder()
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x126CF84", Offset = "0x126CF84", VA = "0x126CF84")]
		private void CreateBrush()
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x126D040", Offset = "0x126D040", VA = "0x126D040")]
		public void ResetKeyBindings()
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x126D060", Offset = "0x126D060", VA = "0x126D060")]
		public void ResetSlopeSettings()
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x126D0DC", Offset = "0x126D0DC", VA = "0x126D0DC")]
		public void ResetRandomizers()
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x126D1CC", Offset = "0x126D1CC", VA = "0x126D1CC")]
		public void ResetAdditiveScale()
		{
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x126D270", Offset = "0x126D270", VA = "0x126D270")]
		public void ResetOverlapFilterSettings()
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x126D2B0", Offset = "0x126D2B0", VA = "0x126D2B0")]
		public XDocument SaveTemplate(string filePath)
		{
			return null;
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x1271AA0", Offset = "0x1271AA0", VA = "0x1271AA0")]
		public bool LoadTemplate(string filePath)
		{
			return default(bool);
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x1277450", Offset = "0x1277450", VA = "0x1277450")]
		public MeshBrush()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class MeshBrushParent : MonoBehaviour
	{
		[Token(Token = "0x40009E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform[] paintedMeshes;

		[Token(Token = "0x40009E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MeshFilter[] meshFilters;

		[Token(Token = "0x40009EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Matrix4x4 localTransformationMatrix;

		[Token(Token = "0x40009EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Hashtable materialToMesh;

		[Token(Token = "0x40009EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private MeshFilter currentMeshFilter;

		[Token(Token = "0x40009ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Renderer currentRenderer;

		[Token(Token = "0x40009EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material[] materials;

		[Token(Token = "0x40009EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private CombineUtility.MeshInstance instance;

		[Token(Token = "0x40009F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private CombineUtility.MeshInstance[] instances;

		[Token(Token = "0x40009F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private ArrayList objects;

		[Token(Token = "0x40009F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private ArrayList elements;

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x1277F70", Offset = "0x1277F70", VA = "0x1277F70")]
		private void Initialize()
		{
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x1277FE0", Offset = "0x1277FE0", VA = "0x1277FE0")]
		public void FlagMeshesAsStatic()
		{
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x1278074", Offset = "0x1278074", VA = "0x1278074")]
		public void UnflagMeshesAsStatic()
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x1278108", Offset = "0x1278108", VA = "0x1278108")]
		public int GetMeshCount()
		{
			return default(int);
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x1278138", Offset = "0x1278138", VA = "0x1278138")]
		public int GetTrisCount()
		{
			return default(int);
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x12781FC", Offset = "0x12781FC", VA = "0x12781FC")]
		public void DeleteAllMeshes()
		{
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x126C348", Offset = "0x126C348", VA = "0x126C348")]
		public void CombinePaintedMeshes(bool autoSelect, MeshFilter[] meshFilters)
		{
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x1278278", Offset = "0x1278278", VA = "0x1278278")]
		public MeshBrushParent()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class SaveCombinedMesh : MonoBehaviour
	{
		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x1278344", Offset = "0x1278344", VA = "0x1278344")]
		private void Start()
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x12783AC", Offset = "0x12783AC", VA = "0x12783AC")]
		public SaveCombinedMesh()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public static class EditorIcons
	{
		[Token(Token = "0x40009F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Texture2D saveTemplateIcon;

		[Token(Token = "0x40009F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Texture2D loadTemplateIcon;

		[Token(Token = "0x40009F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Texture2D nullIcon;

		[Token(Token = "0x40009F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Texture2D addIcon;

		[Token(Token = "0x40009F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Texture2D saveMeshIcon;

		[Token(Token = "0x40009F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static byte[] saveTemplateIconBytes;

		[Token(Token = "0x40009F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static byte[] loadTemplateIconBytes;

		[Token(Token = "0x40009FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static byte[] nullIconBytes;

		[Token(Token = "0x40009FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static byte[] addIconBytes;

		[Token(Token = "0x40009FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static byte[] saveMeshIconBytes;

		[Token(Token = "0x170000D5")]
		public static Texture2D SaveTemplateIcon
		{
			[Token(Token = "0x60008F6")]
			[Address(RVA = "0xBBFF24", Offset = "0xBBFF24", VA = "0xBBFF24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D6")]
		public static Texture2D LoadTemplateIcon
		{
			[Token(Token = "0x60008F7")]
			[Address(RVA = "0xBC006C", Offset = "0xBC006C", VA = "0xBC006C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D7")]
		public static Texture2D NullIcon
		{
			[Token(Token = "0x60008F8")]
			[Address(RVA = "0xBC01B0", Offset = "0xBC01B0", VA = "0xBC01B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D8")]
		public static Texture2D AddIcon
		{
			[Token(Token = "0x60008F9")]
			[Address(RVA = "0xBC02F4", Offset = "0xBC02F4", VA = "0xBC02F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D9")]
		public static Texture2D SaveMeshIcon
		{
			[Token(Token = "0x60008FA")]
			[Address(RVA = "0xBC0438", Offset = "0xBC0438", VA = "0xBC0438")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x2000110")]
	public static class CombineUtility
	{
		[Token(Token = "0x20001A9")]
		public struct MeshInstance
		{
			[Token(Token = "0x4000CAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Mesh mesh;

			[Token(Token = "0x4000CAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int subMeshIndex;

			[Token(Token = "0x4000CAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Matrix4x4 transform;
		}

		[Token(Token = "0x40009FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int vertexCount;

		[Token(Token = "0x40009FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int triangleCount;

		[Token(Token = "0x40009FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int stripCount;

		[Token(Token = "0x4000A00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static int curStripCount;

		[Token(Token = "0x4000A01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Vector3[] vertices;

		[Token(Token = "0x4000A02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Vector3[] normals;

		[Token(Token = "0x4000A03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Vector4[] tangents;

		[Token(Token = "0x4000A04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Vector2[] uv;

		[Token(Token = "0x4000A05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Vector2[] uv1;

		[Token(Token = "0x4000A06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static Color[] colors;

		[Token(Token = "0x4000A07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static int[] triangles;

		[Token(Token = "0x4000A08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static int[] strip;

		[Token(Token = "0x4000A09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static int offset;

		[Token(Token = "0x4000A0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private static int triangleOffset;

		[Token(Token = "0x4000A0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static int stripOffset;

		[Token(Token = "0x4000A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private static int vertexOffset;

		[Token(Token = "0x4000A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static Matrix4x4 invTranspose;

		[Token(Token = "0x4000A0E")]
		public const string combinedMeshName = "Combined Mesh";

		[Token(Token = "0x4000A0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static Vector4 p4;

		[Token(Token = "0x4000A10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static Vector3 p;

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0xBBE8C0", Offset = "0xBBE8C0", VA = "0xBBE8C0")]
		public static Mesh Combine(MeshInstance[] combines, bool generateStrips)
		{
			return null;
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0xBBFA78", Offset = "0xBBFA78", VA = "0xBBFA78")]
		private static void Copy(int vertexcount, Vector3[] src, Vector3[] dst, ref int offset, Matrix4x4 transform)
		{
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0xBBFB58", Offset = "0xBBFB58", VA = "0xBBFB58")]
		private static void CopyNormal(int vertexcount, Vector3[] src, Vector3[] dst, ref int offset, Matrix4x4 transform)
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0xBBFE18", Offset = "0xBBFE18", VA = "0xBBFE18")]
		private static void Copy(int vertexcount, Vector2[] src, Vector2[] dst, ref int offset)
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0xBBFE9C", Offset = "0xBBFE9C", VA = "0xBBFE9C")]
		private static void CopyColors(int vertexcount, Color[] src, Color[] dst, ref int offset)
		{
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0xBBFC5C", Offset = "0xBBFC5C", VA = "0xBBFC5C")]
		private static void CopyTangents(int vertexcount, Vector4[] src, Vector4[] dst, ref int offset, Matrix4x4 transform)
		{
		}
	}
	[Token(Token = "0x2000111")]
	public static class FavouriteTemplatesUtility
	{
		[Serializable]
		[Token(Token = "0x20001AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8000F0", Offset = "0x8000F0")]
		private sealed class <>c
		{
			[Token(Token = "0x4000CAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000CAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, XElement> <>9__0_0;

			[Token(Token = "0x4000CAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<XElement, string> <>9__1_0;

			[Token(Token = "0x6000B2A")]
			[Address(RVA = "0x126A594", Offset = "0x126A594", VA = "0x126A594")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B2B")]
			[Address(RVA = "0x126A59C", Offset = "0x126A59C", VA = "0x126A59C")]
			internal XElement <SaveFavouriteTemplates>b__0_0(string template)
			{
				return null;
			}

			[Token(Token = "0x6000B2C")]
			[Address(RVA = "0x126A668", Offset = "0x126A668", VA = "0x126A668")]
			internal string <LoadFavouriteTemplates>b__1_0(XElement path)
			{
				return null;
			}
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x1269C10", Offset = "0x1269C10", VA = "0x1269C10")]
		public static XDocument SaveFavouriteTemplates(List<string> favouriteTemplates, string filePath)
		{
			return null;
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x1269EE0", Offset = "0x1269EE0", VA = "0x1269EE0")]
		public static List<string> LoadFavouriteTemplates(string filePath)
		{
			return null;
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x126A0B8", Offset = "0x126A0B8", VA = "0x126A0B8")]
		public static bool LoadFavouriteTemplates(string filePath, List<string> targetList)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000112")]
	public static class MeshTransformationUtility
	{
		[Token(Token = "0x6000906")]
		[Address(RVA = "0x126BD00", Offset = "0x126BD00", VA = "0x126BD00")]
		public static void ApplyRandomScale(Transform targetTransform, Vector2 range)
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x1278280", Offset = "0x1278280", VA = "0x1278280")]
		public static void ApplyRandomScale(Transform targetTransform, Vector4 scaleRanges)
		{
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x126BDC8", Offset = "0x126BDC8", VA = "0x126BDC8")]
		public static void ApplyRandomScale(Transform targetTransform, Vector2 rangeX, Vector2 rangeY, Vector2 rangeZ)
		{
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x126BEAC", Offset = "0x126BEAC", VA = "0x126BEAC")]
		public static void AddConstantScale(Transform targetTransform, Vector2 range)
		{
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x126BFE0", Offset = "0x126BFE0", VA = "0x126BFE0")]
		public static void AddConstantScale(Transform targetTransform, float x, float y, float z)
		{
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x126C0D8", Offset = "0x126C0D8", VA = "0x126C0D8")]
		public static void ApplyRandomRotation(Transform targetTransform, float randomRotationIntensityPercentageX, float randomRotationIntensityPercentageY, float randomRotationIntensityPercentageZ)
		{
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x126BC24", Offset = "0x126BC24", VA = "0x126BC24")]
		public static void ApplyMeshOffset(Transform targetTransform, float offset, Vector3 direction)
		{
		}
	}
	[Token(Token = "0x2000113")]
	public static class TemplateMigrationUtility
	{
		[Token(Token = "0x600090D")]
		[Address(RVA = "0x12783B4", Offset = "0x12783B4", VA = "0x12783B4")]
		public static bool TryMigrate(string filePath)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000114")]
	public static class VectorClampingUtility
	{
		[Token(Token = "0x600090E")]
		[Address(RVA = "0x126B094", Offset = "0x126B094", VA = "0x126B094")]
		public static void ClampVector(ref Vector2 vector, float minX, float maxX, float minY, float maxY)
		{
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x126B154", Offset = "0x126B154", VA = "0x126B154")]
		public static void ClampVector(ref Vector3 vector, float minX, float maxX, float minY, float maxY, float minZ, float maxZ)
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x127B01C", Offset = "0x127B01C", VA = "0x127B01C")]
		public static void ClampVector(ref Vector4 vector, float minX, float maxX, float minY, float maxY, float minZ, float maxZ, float minW, float maxW)
		{
		}
	}
	[Token(Token = "0x2000115")]
	public enum BrushMode
	{
		[Token(Token = "0x4000A12")]
		Paint,
		[Token(Token = "0x4000A13")]
		PrecisionPlacement,
		[Token(Token = "0x4000A14")]
		SampleReferenceVector
	}
}
namespace MeshBrush.Examples
{
	[Token(Token = "0x2000116")]
	public class RuntimeExample : MonoBehaviour
	{
		[Token(Token = "0x4000A15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshBrush meshbrushInstance;

		[Token(Token = "0x4000A16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform circleBrush;

		[Token(Token = "0x4000A17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Slider radiusSlider;

		[Token(Token = "0x4000A18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Slider scatteringSlider;

		[Token(Token = "0x4000A19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Slider densitySlider;

		[Token(Token = "0x4000A1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform mainCamera;

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x12680F0", Offset = "0x12680F0", VA = "0x12680F0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x1268128", Offset = "0x1268128", VA = "0x1268128")]
		private void Update()
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x1269C08", Offset = "0x1269C08", VA = "0x1269C08")]
		public RuntimeExample()
		{
		}
	}
}
namespace Dissonance.Integrations.PureP2P
{
	[Token(Token = "0x2000117")]
	public class PureP2PClient : BaseClient<PureP2PServer, PureP2PClient, PureP2PPeer>
	{
		[Serializable]
		[Token(Token = "0x20001AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800100", Offset = "0x800100")]
		private sealed class <>c
		{
			[Token(Token = "0x4000CB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000CB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<PureP2PCommsNetwork.IceServer, IceServer> <>9__6_0;

			[Token(Token = "0x6000B2E")]
			[Address(RVA = "0xBBB54C", Offset = "0xBBB54C", VA = "0xBBB54C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B2F")]
			[Address(RVA = "0xBBB554", Offset = "0xBBB554", VA = "0xBBB554")]
			internal IceServer <Connect>b__6_0(PureP2PCommsNetwork.IceServer a)
			{
				return null;
			}
		}

		[Token(Token = "0x4000A1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[NotNull]
		private readonly PureP2PCommsNetwork _network;

		[Token(Token = "0x4000A1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[NotNull]
		private readonly string _sessionId;

		[Token(Token = "0x4000A1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private IBasicNetwork _webrtcNetwork;

		[Token(Token = "0x4000A1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private ConnectionId _serverConnectionId;

		[Token(Token = "0x4000A1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private byte[] _peerHandshake;

		[Token(Token = "0x6000914")]
		[Address(RVA = "0xBBA0AC", Offset = "0xBBA0AC", VA = "0xBBA0AC")]
		public PureP2PClient([NotNull] PureP2PCommsNetwork network, [NotNull] string sessionId)
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0xBBA1D0", Offset = "0xBBA1D0", VA = "0xBBA1D0", Slot = "8")]
		public override void Connect()
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0xBBA524", Offset = "0xBBA524", VA = "0xBBA524")]
		[NotNull]
		private string UniquePlayerSessionId(string playerName)
		{
			return null;
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0xBBA588", Offset = "0xBBA588", VA = "0xBBA588", Slot = "9")]
		public override void Disconnect()
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0xBBA64C", Offset = "0xBBA64C", VA = "0xBBA64C")]
		private void Send(ConnectionId connection, ArraySegment<byte> packet, bool reliable)
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0xBBA784", Offset = "0xBBA784", VA = "0xBBA784")]
		private void SendP2P([NotNull] IList<ClientInfo<PureP2PPeer?>> destinations, ArraySegment<byte> packet, bool reliable)
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0xBBA9AC", Offset = "0xBBA9AC", VA = "0xBBA9AC", Slot = "12")]
		protected override void SendReliable(ArraySegment<byte> packet)
		{
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0xBBAB34", Offset = "0xBBAB34", VA = "0xBBAB34", Slot = "14")]
		protected override void SendReliableP2P(List<ClientInfo<PureP2PPeer?>> destinations, ArraySegment<byte> packet)
		{
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0xBBABC4", Offset = "0xBBABC4", VA = "0xBBABC4", Slot = "13")]
		protected override void SendUnreliable(ArraySegment<byte> packet)
		{
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0xBBAC28", Offset = "0xBBAC28", VA = "0xBBAC28", Slot = "15")]
		protected override void SendUnreliableP2P(List<ClientInfo<PureP2PPeer?>> destinations, ArraySegment<byte> packet)
		{
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0xBBACB8", Offset = "0xBBACB8", VA = "0xBBACB8", Slot = "10")]
		public override ClientStatus Update()
		{
			return default(ClientStatus);
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0xBBAD7C", Offset = "0xBBAD7C", VA = "0xBBAD7C", Slot = "11")]
		protected override void ReadMessages()
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0xBBB334", Offset = "0xBBB334", VA = "0xBBB334")]
		private void OnPlayerJoined(string name, CodecSettings _)
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0xBBB2AC", Offset = "0xBBB2AC", VA = "0xBBB2AC")]
		private void SendHandshakeP2P(ConnectionId connectionId)
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0xBBB460", Offset = "0xBBB460", VA = "0xBBB460", Slot = "16")]
		protected override void OnServerAssignedSessionId(uint session, ushort id)
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class PureP2PCommsNetwork : BaseCommsNetwork<PureP2PServer, PureP2PClient, PureP2PPeer, string, string>
	{
		[Serializable]
		[Token(Token = "0x20001AC")]
		public class IceServer
		{
			[Token(Token = "0x4000CB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "UsedImplicitlyAttribute", RVA = "0x801340", Offset = "0x801340")]
			[SerializeField]
			private string _url;

			[Token(Token = "0x4000CB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "UsedImplicitlyAttribute", RVA = "0x801378", Offset = "0x801378")]
			[SerializeField]
			private string _username;

			[Token(Token = "0x4000CB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "UsedImplicitlyAttribute", RVA = "0x8013B0", Offset = "0x8013B0")]
			[SerializeField]
			private string _password;

			[Token(Token = "0x4000CB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Byn.Awrtc.IceServer _byn;

			[Token(Token = "0x17000123")]
			public string URL
			{
				[Token(Token = "0x6000B30")]
				[Address(RVA = "0xBBC1F0", Offset = "0xBBC1F0", VA = "0xBBC1F0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000124")]
			public string Username
			{
				[Token(Token = "0x6000B31")]
				[Address(RVA = "0xBBC1F8", Offset = "0xBBC1F8", VA = "0xBBC1F8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000125")]
			public string Password
			{
				[Token(Token = "0x6000B32")]
				[Address(RVA = "0xBBC200", Offset = "0xBBC200", VA = "0xBBC200")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000126")]
			[NotNull]
			internal Byn.Awrtc.IceServer BynIce
			{
				[Token(Token = "0x6000B33")]
				[Address(RVA = "0xBBB56C", Offset = "0xBBB56C", VA = "0xBBB56C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B34")]
			[Address(RVA = "0xBBC0F8", Offset = "0xBBC0F8", VA = "0xBBC0F8")]
			public IceServer(string url, string username = "", string password = "")
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800110", Offset = "0x800110")]
		private sealed class <>c
		{
			[Token(Token = "0x4000CB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000CB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<byte[]> <>9__26_0;

			[Token(Token = "0x6000B36")]
			[Address(RVA = "0xBBC19C", Offset = "0xBBC19C", VA = "0xBBC19C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B37")]
			[Address(RVA = "0xBBC1A4", Offset = "0xBBC1A4", VA = "0xBBC1A4")]
			internal byte[] <.ctor>b__26_0()
			{
				return null;
			}
		}

		[Token(Token = "0x4000A20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x801280", Offset = "0x801280")]
		private string <SessionId>k__BackingField;

		[Token(Token = "0x4000A21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[AttributeAttribute(Name = "UsedImplicitlyAttribute", RVA = "0x801290", Offset = "0x801290")]
		public string SignallingServer;

		[Token(Token = "0x4000A22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[AttributeAttribute(Name = "UsedImplicitlyAttribute", RVA = "0x8012C8", Offset = "0x8012C8")]
		private List<IceServer> _iceServersList;

		[Token(Token = "0x4000A23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private readonly ConcurrentPool<byte[]> _loopbackBuffers;

		[Token(Token = "0x4000A24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private readonly List<KeyValuePair<PureP2PPeer, ArraySegment<byte>>> _loopbackToServer;

		[Token(Token = "0x4000A25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private readonly List<ArraySegment<byte>> _loopbackToClient;

		[Token(Token = "0x170000DA")]
		public string SessionId
		{
			[Token(Token = "0x6000923")]
			[Address(RVA = "0xBBB5FC", Offset = "0xBBB5FC", VA = "0xBBB5FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8041FC", Offset = "0x8041FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000924")]
			[Address(RVA = "0xBBB604", Offset = "0xBBB604", VA = "0xBBB604")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80420C", Offset = "0x80420C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		public IEnumerable<IceServer> IceServers
		{
			[Token(Token = "0x6000925")]
			[Address(RVA = "0xBBB60C", Offset = "0xBBB60C", VA = "0xBBB60C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DC")]
		internal bool IsServer
		{
			[Token(Token = "0x600092E")]
			[Address(RVA = "0xBBA4D8", Offset = "0xBBA4D8", VA = "0xBBA4D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0xBBB614", Offset = "0xBBB614", VA = "0xBBB614", Slot = "32")]
		protected override PureP2PServer CreateServer(string sessionId)
		{
			return null;
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0xBBB72C", Offset = "0xBBB72C", VA = "0xBBB72C", Slot = "33")]
		protected override PureP2PClient CreateClient(string sessionId)
		{
			return null;
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0xBBB7DC", Offset = "0xBBB7DC", VA = "0xBBB7DC", Slot = "34")]
		protected override void Initialize()
		{
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0xBBB91C", Offset = "0xBBB91C", VA = "0xBBB91C")]
		private void OnLog(object msg, [NotNull] string[] tags)
		{
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0xBBBB20", Offset = "0xBBBB20", VA = "0xBBBB20")]
		private void OnModeChanged(NetworkMode mode)
		{
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0xBB9694", Offset = "0xBB9694", VA = "0xBB9694")]
		public void InitializeAsServer([NotNull] string sessionId)
		{
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0xBB8450", Offset = "0xBB8450", VA = "0xBB8450")]
		public void InitializeAsClient([NotNull] string sessionId)
		{
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0xBBBB30", Offset = "0xBBBB30", VA = "0xBBBB30", Slot = "35")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0xBBAA10", Offset = "0xBBAA10", VA = "0xBBAA10")]
		internal bool TryLoopbackToServer(ArraySegment<byte> packet)
		{
			return default(bool);
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0xBBBD14", Offset = "0xBBBD14", VA = "0xBBBD14")]
		internal void LoopbackToClient(ArraySegment<byte> packet)
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0xBBBDE0", Offset = "0xBBBDE0", VA = "0xBBBDE0")]
		public void AddIceServer(IceServer server)
		{
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0xBBBE48", Offset = "0xBBBE48", VA = "0xBBBE48")]
		public void RemoveIceServer(IceServer server)
		{
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0xBBBEB0", Offset = "0xBBBEB0", VA = "0xBBBEB0")]
		public PureP2PCommsNetwork()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public struct PureP2PPeer : IEquatable<PureP2PPeer>
	{
		[Token(Token = "0x4000A26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly ConnectionId ConnectionId;

		[Token(Token = "0x4000A27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public readonly bool IsLocalLoopback;

		[Token(Token = "0x6000934")]
		[Address(RVA = "0xBBB2A0", Offset = "0xBBB2A0", VA = "0xBBB2A0")]
		public PureP2PPeer(ConnectionId connectionId)
		{
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0xBBBD04", Offset = "0xBBBD04", VA = "0xBBBD04")]
		public PureP2PPeer(bool localLoopback)
		{
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0xBBC208", Offset = "0xBBC208", VA = "0xBBC208", Slot = "4")]
		public bool Equals(PureP2PPeer other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0xBBC2B4", Offset = "0xBBC2B4", VA = "0xBBC2B4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0xBBC340", Offset = "0xBBC340", VA = "0xBBC340", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0xBBC39C", Offset = "0xBBC39C", VA = "0xBBC39C")]
		public static bool operator ==(PureP2PPeer left, PureP2PPeer right)
		{
			return default(bool);
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0xBBC3C8", Offset = "0xBBC3C8", VA = "0xBBC3C8")]
		public static bool operator !=(PureP2PPeer left, PureP2PPeer right)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200011A")]
	public class PureP2PServer : BaseServer<PureP2PServer, PureP2PClient, PureP2PPeer>
	{
		[Serializable]
		[Token(Token = "0x20001AE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x800120", Offset = "0x800120")]
		private sealed class <>c
		{
			[Token(Token = "0x4000CB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000CB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<PureP2PCommsNetwork.IceServer, IceServer> <>9__4_0;

			[Token(Token = "0x6000B39")]
			[Address(RVA = "0xBBCE38", Offset = "0xBBCE38", VA = "0xBBCE38")]
			public <>c()
			{
			}

			[Token(Token = "0x6000B3A")]
			[Address(RVA = "0xBBCE40", Offset = "0xBBCE40", VA = "0xBBCE40")]
			internal IceServer <Connect>b__4_0(PureP2PCommsNetwork.IceServer a)
			{
				return null;
			}
		}

		[Token(Token = "0x4000A28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly string _sessionId;

		[Token(Token = "0x4000A29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly PureP2PCommsNetwork _network;

		[Token(Token = "0x4000A2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IBasicNetwork _webrtcNetwork;

		[Token(Token = "0x600093B")]
		[Address(RVA = "0xBBB6C4", Offset = "0xBBB6C4", VA = "0xBBB6C4")]
		public PureP2PServer(PureP2PCommsNetwork network, string sessionId)
		{
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0xBBC3F8", Offset = "0xBBC3F8", VA = "0xBBC3F8", Slot = "9")]
		public override void Connect()
		{
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0xBBC5E8", Offset = "0xBBC5E8", VA = "0xBBC5E8", Slot = "10")]
		public override void Disconnect()
		{
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0xBBC6AC", Offset = "0xBBC6AC", VA = "0xBBC6AC", Slot = "12")]
		protected override void SendReliable(PureP2PPeer connection, ArraySegment<byte> packet)
		{
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0xBBC7C4", Offset = "0xBBC7C4", VA = "0xBBC7C4", Slot = "13")]
		protected override void SendUnreliable(PureP2PPeer connection, ArraySegment<byte> packet)
		{
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0xBBC8DC", Offset = "0xBBC8DC", VA = "0xBBC8DC", Slot = "11")]
		public override ServerState Update()
		{
			return default(ServerState);
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0xBBC9A0", Offset = "0xBBC9A0", VA = "0xBBC9A0", Slot = "16")]
		protected override void ReadMessages()
		{
		}
	}
}
namespace Dissonance.Integrations.PureP2P.Demo
{
	[Token(Token = "0x200011B")]
	public class StateManager : MonoBehaviour
	{
		[Token(Token = "0x20001AF")]
		private interface IState
		{
			[Token(Token = "0x6000B3B")]
			void Awake();

			[Token(Token = "0x6000B3C")]
			[NotNull]
			IState Update();
		}

		[Token(Token = "0x20001B0")]
		private class LoadWorld : IState
		{
			[Token(Token = "0x4000CBA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly IState _nextState;

			[Token(Token = "0x6000B3D")]
			[Address(RVA = "0xBB955C", Offset = "0xBB955C", VA = "0xBB955C")]
			public LoadWorld(IState nextState)
			{
			}

			[Token(Token = "0x6000B3E")]
			[Address(RVA = "0xBB9588", Offset = "0xBB9588", VA = "0xBB9588", Slot = "4")]
			public void Awake()
			{
			}

			[Token(Token = "0x6000B3F")]
			[Address(RVA = "0xBB95F4", Offset = "0xBB95F4", VA = "0xBB95F4", Slot = "5")]
			public IState Update()
			{
				return null;
			}
		}

		[Token(Token = "0x20001B1")]
		private class UnloadWorld : IState
		{
			[Token(Token = "0x4000CBB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly IState _nextState;

			[Token(Token = "0x6000B40")]
			[Address(RVA = "0xBB8E58", Offset = "0xBB8E58", VA = "0xBB8E58")]
			public UnloadWorld(IState nextState)
			{
			}

			[Token(Token = "0x6000B41")]
			[Address(RVA = "0xBBA038", Offset = "0xBBA038", VA = "0xBBA038", Slot = "4")]
			public void Awake()
			{
			}

			[Token(Token = "0x6000B42")]
			[Address(RVA = "0xBBA0A4", Offset = "0xBBA0A4", VA = "0xBBA0A4", Slot = "5")]
			public IState Update()
			{
				return null;
			}
		}

		[Token(Token = "0x20001B2")]
		private class InMenu : IState
		{
			[Token(Token = "0x4000CBC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Camera _camera;

			[Token(Token = "0x4000CBD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private string _sessionId;

			[Token(Token = "0x6000B43")]
			[Address(RVA = "0xBB814C", Offset = "0xBB814C", VA = "0xBB814C")]
			public InMenu(Camera camera)
			{
			}

			[Token(Token = "0x6000B44")]
			[Address(RVA = "0xBB8E84", Offset = "0xBB8E84", VA = "0xBB8E84", Slot = "4")]
			public void Awake()
			{
			}

			[Token(Token = "0x6000B45")]
			[Address(RVA = "0xBB8EA4", Offset = "0xBB8EA4", VA = "0xBB8EA4", Slot = "5")]
			public IState Update()
			{
				return null;
			}
		}

		[Token(Token = "0x20001B3")]
		private class Server : IState
		{
			[Token(Token = "0x4000CBE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly string _sessionId;

			[Token(Token = "0x4000CBF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private PureP2PCommsNetwork _net;

			[Token(Token = "0x4000CC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private DissonanceComms _comms;

			[Token(Token = "0x4000CC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private readonly Camera _camera;

			[Token(Token = "0x6000B46")]
			[Address(RVA = "0xBB9520", Offset = "0xBB9520", VA = "0xBB9520")]
			public Server(string sessionId, Camera camera)
			{
			}

			[Token(Token = "0x6000B47")]
			[Address(RVA = "0xBB95FC", Offset = "0xBB95FC", VA = "0xBB95FC", Slot = "4")]
			public void Awake()
			{
			}

			[Token(Token = "0x6000B48")]
			[Address(RVA = "0xBB97B8", Offset = "0xBB97B8", VA = "0xBB97B8", Slot = "5")]
			public IState Update()
			{
				return null;
			}
		}

		[Token(Token = "0x20001B4")]
		private class Client : IState
		{
			[Token(Token = "0x4000CC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly string _sessionId;

			[Token(Token = "0x4000CC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private PureP2PCommsNetwork _net;

			[Token(Token = "0x4000CC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private DissonanceComms _comms;

			[Token(Token = "0x4000CC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private readonly Camera _camera;

			[Token(Token = "0x6000B49")]
			[Address(RVA = "0xBB837C", Offset = "0xBB837C", VA = "0xBB837C")]
			public Client(string sessionId, Camera camera)
			{
			}

			[Token(Token = "0x6000B4A")]
			[Address(RVA = "0xBB83B8", Offset = "0xBB83B8", VA = "0xBB83B8", Slot = "4")]
			public void Awake()
			{
			}

			[Token(Token = "0x6000B4B")]
			[Address(RVA = "0xBB8570", Offset = "0xBB8570", VA = "0xBB8570", Slot = "5")]
			public IState Update()
			{
				return null;
			}
		}

		[Token(Token = "0x4000A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IState _state;

		[Token(Token = "0x4000A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IState _nextState;

		[Token(Token = "0x4000A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _destroy;

		[Token(Token = "0x6000942")]
		[Address(RVA = "0xBB800C", Offset = "0xBB800C", VA = "0xBB800C")]
		[AttributeAttribute(Name = "UsedImplicitlyAttribute", RVA = "0x80421C", Offset = "0x80421C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0xBB81F0", Offset = "0xBB81F0", VA = "0xBB81F0")]
		[AttributeAttribute(Name = "UsedImplicitlyAttribute", RVA = "0x80422C", Offset = "0x80422C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0xBB82AC", Offset = "0xBB82AC", VA = "0xBB82AC")]
		[AttributeAttribute(Name = "UsedImplicitlyAttribute", RVA = "0x80423C", Offset = "0x80423C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0xBB8370", Offset = "0xBB8370", VA = "0xBB8370")]
		public StateManager()
		{
		}
	}
}
