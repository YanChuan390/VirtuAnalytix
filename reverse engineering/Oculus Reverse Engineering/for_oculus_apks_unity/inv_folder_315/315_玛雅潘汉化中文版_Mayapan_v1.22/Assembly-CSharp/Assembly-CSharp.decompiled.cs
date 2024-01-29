using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using Oculus.Platform;
using Oculus.Platform.Models;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.Scripting;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.XR.Interaction.Toolkit;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class Portal : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject destination;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x84B9B0", Offset = "0x84B9B0", VA = "0x84B9B0")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x84BA74", Offset = "0x84BA74", VA = "0x84BA74")]
	public Portal()
	{
	}
}
[Token(Token = "0x2000003")]
public class Rotator : MonoBehaviour
{
	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float x;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float y;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float z;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x850FA4", Offset = "0x850FA4", VA = "0x850FA4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x850FDC", Offset = "0x850FDC", VA = "0x850FDC")]
	public Rotator()
	{
	}
}
[Token(Token = "0x2000004")]
public class Loader : MonoBehaviour
{
	[Token(Token = "0x6000005")]
	[Address(RVA = "0xB5605C", Offset = "0xB5605C", VA = "0xB5605C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xB560D0", Offset = "0xB560D0", VA = "0xB560D0")]
	public Loader()
	{
	}
}
[Token(Token = "0x2000005")]
public class ControllerButtonsReader : MonoBehaviour
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ActionBasedController controller;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private XRControllerState state;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float buttonPressPoint;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public InputActionProperty triggerActionXR;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private InteractionState triggerInteraction;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public UnityEvent triggerPressed;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public UnityEvent triggerReleased;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public InputActionProperty gripActionXR;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private InteractionState gripInteraction;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public UnityEvent gripPressed;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public UnityEvent gripReleased;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public InputActionProperty AbuttonActionXR;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private InteractionState AbuttonInteraction;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public UnityEvent abuttonPressed;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public InputActionProperty BbuttonActionXR;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private InteractionState BbuttonInteraction;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public UnityEvent bbuttonPressed;

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x8630CC", Offset = "0x8630CC", VA = "0x8630CC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x863128", Offset = "0x863128", VA = "0x863128")]
	private void Update()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x86347C", Offset = "0x86347C", VA = "0x86347C")]
	private bool IsPressed(InputActionProperty property)
	{
		return default(bool);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x863520", Offset = "0x863520", VA = "0x863520")]
	private static void ComputeInteractionActionStates(bool pressed, ref InteractionState interactionState)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x863558", Offset = "0x863558", VA = "0x863558")]
	public ControllerButtonsReader()
	{
	}
}
[Token(Token = "0x2000006")]
public class XRRayInteractorCustom : XRRayInteractor
{
	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	private IXRInteractable closestInterctable;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xB1064C", Offset = "0xB1064C", VA = "0xB1064C", Slot = "47")]
	public override void GetValidTargets(List<IXRInteractable> validTargets)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xB106E4", Offset = "0xB106E4", VA = "0xB106E4", Slot = "50")]
	public override bool CanHover(IXRHoverInteractable interactable)
	{
		return default(bool);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xB106F4", Offset = "0xB106F4", VA = "0xB106F4")]
	public XRRayInteractorCustom()
	{
	}
}
[Token(Token = "0x2000007")]
public class Car : MonoBehaviour
{
	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float turnspeed;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float destination;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float direction;

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x85F920", Offset = "0x85F920", VA = "0x85F920")]
	private void Update()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x85FBF8", Offset = "0x85FBF8", VA = "0x85FBF8")]
	private void FindDestination(Vector3 tPos)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x85FC74", Offset = "0x85FC74", VA = "0x85FC74")]
	private float mod(float a)
	{
		return default(float);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x85FC84", Offset = "0x85FC84", VA = "0x85FC84")]
	public Car()
	{
	}
}
[Token(Token = "0x2000008")]
public class Move : MonoBehaviour
{
	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Vector3 forward;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<GameObject> Tiles;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float zPos;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int starTiles;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int prevRand;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int num;

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xFCAF94", Offset = "0xFCAF94", VA = "0xFCAF94")]
	private void Start()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xFCB1B0", Offset = "0xFCB1B0", VA = "0xFCB1B0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xFCB3A8", Offset = "0xFCB3A8", VA = "0xFCB3A8")]
	public Move()
	{
	}
}
[Token(Token = "0x2000009")]
public class PoolManager : MonoBehaviour
{
	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E624", Offset = "0x58E624")]
	private static PoolManager <Instance>k__BackingField;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<int, Queue<GameObject>> pool;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Camera cam;

	[Token(Token = "0x17000001")]
	public static PoolManager Instance
	{
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x84A688", Offset = "0x84A688", VA = "0x84A688")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x590EB0", Offset = "0x590EB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x84A6D4", Offset = "0x84A6D4", VA = "0x84A6D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x590EC0", Offset = "0x590EC0")]
		set
		{
		}
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x84A728", Offset = "0x84A728", VA = "0x84A728")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x84A77C", Offset = "0x84A77C", VA = "0x84A77C")]
	private void Start()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x84A7FC", Offset = "0x84A7FC", VA = "0x84A7FC")]
	public void CreatePool(GameObject gameObj, int numberOfObj)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x84A9CC", Offset = "0x84A9CC", VA = "0x84A9CC")]
	public void Reuse(int gameObjKey, Vector3 position, Quaternion orientation)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x84AB24", Offset = "0x84AB24", VA = "0x84AB24")]
	public void Reuse(int gameObjKey)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x84ABF4", Offset = "0x84ABF4", VA = "0x84ABF4")]
	private void Update()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x84AF5C", Offset = "0x84AF5C", VA = "0x84AF5C")]
	public PoolManager()
	{
	}
}
[Token(Token = "0x200000A")]
[ExecuteInEditMode]
public class MobileBloom : MonoBehaviour
{
	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58E634", Offset = "0x58E634")]
	public float BloomDiffusion;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Color BloomColor;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58E64C", Offset = "0x58E64C")]
	public float BloomAmount;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58E664", Offset = "0x58E664")]
	public float BloomThreshold;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58E67C", Offset = "0x58E67C")]
	public float BloomSoftness;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int blurAmountString;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static readonly int bloomColorString;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly int blDataString;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static readonly int bloomTexString;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Material material;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int numberOfPasses;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float knee;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private RenderTextureDescriptor half;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private RenderTextureDescriptor quarter;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private RenderTextureDescriptor eighths;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private RenderTextureDescriptor sixths;

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xFC9070", Offset = "0xFC9070", VA = "0xFC9070")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xFC9AA4", Offset = "0xFC9AA4", VA = "0xFC9AA4")]
	public MobileBloom()
	{
	}
}
[Token(Token = "0x200000B")]
public class Move1 : MonoBehaviour
{
	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3[] points;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3[] orients;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float accuracy;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 currentPosiition;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 targetPos;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 targetOr;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int indexp;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private int indexo;

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xFCB444", Offset = "0xFCB444", VA = "0xFCB444")]
	private void Start()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xFCB4A8", Offset = "0xFCB4A8", VA = "0xFCB4A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xFCB6DC", Offset = "0xFCB6DC", VA = "0xFCB6DC")]
	public bool V3Equal(Vector3 a, Vector3 b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xFCB70C", Offset = "0xFCB70C", VA = "0xFCB70C")]
	public Move1()
	{
	}
}
[Token(Token = "0x200000C")]
public class OvrAvatarTestDriver : OvrAvatarDriver
{
	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 headPos;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Quaternion headRot;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float voiceAmplitude;

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x844804", Offset = "0x844804", VA = "0x844804")]
	private ControllerPose GetMalibuControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x844968", Offset = "0x844968", VA = "0x844968")]
	private ControllerPose GetControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x844D04", Offset = "0x844D04", VA = "0x844D04")]
	private void CalculateCurrentPose()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x844EA8", Offset = "0x844EA8", VA = "0x844EA8", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x844ED8", Offset = "0x844ED8", VA = "0x844ED8")]
	public OvrAvatarTestDriver()
	{
	}
}
[Token(Token = "0x200000D")]
public class PoseEditHelper : MonoBehaviour
{
	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform poseRoot;

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x84BAC0", Offset = "0x84BAC0", VA = "0x84BAC0")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x84BB48", Offset = "0x84BB48", VA = "0x84BB48")]
	private void DrawJoints(Transform joint)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x84BCBC", Offset = "0x84BCBC", VA = "0x84BCBC")]
	public PoseEditHelper()
	{
	}
}
[Token(Token = "0x200000E")]
public class GazeTargetSpawner : MonoBehaviour
{
	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject GazeTargetPrefab;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int NumberOfDummyTargets;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int RadiusMultiplier;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool isVisible;

	[Token(Token = "0x17000002")]
	public bool IsVisible
	{
		[Token(Token = "0x600002E")]
		[Address(RVA = "0xB44C94", Offset = "0xB44C94", VA = "0xB44C94")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600002F")]
		[Address(RVA = "0xB44C9C", Offset = "0xB44C9C", VA = "0xB44C9C")]
		set
		{
		}
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xB44DD8", Offset = "0xB44DD8", VA = "0xB44DD8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xB44FA0", Offset = "0xB44FA0", VA = "0xB44FA0")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xB44FA8", Offset = "0xB44FA8", VA = "0xB44FA8")]
	public GazeTargetSpawner()
	{
	}
}
[Token(Token = "0x200000F")]
public class RemoteLoopbackManager : MonoBehaviour
{
	[Token(Token = "0x2000010")]
	private class PacketLatencyPair
	{
		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte[] PacketData;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float FakeLatency;

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xF3E654", Offset = "0xF3E654", VA = "0xF3E654")]
		public PacketLatencyPair()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000011")]
	public class SimulatedLatencySettings
	{
		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58E6A4", Offset = "0x58E6A4")]
		public float FakeLatencyMax;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58E6BC", Offset = "0x58E6BC")]
		public float FakeLatencyMin;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58E6D4", Offset = "0x58E6D4")]
		public float LatencyWeight;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58E6EC", Offset = "0x58E6EC")]
		public int MaxSamples;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal float AverageWindow;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal float LatencySum;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal LinkedList<float> LatencyValues;

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xF3E65C", Offset = "0xF3E65C", VA = "0xF3E65C")]
		public float NextValue()
		{
			return default(float);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xF3E794", Offset = "0xF3E794", VA = "0xF3E794")]
		public SimulatedLatencySettings()
		{
		}
	}

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OvrAvatar LocalAvatar;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OvrAvatar LoopbackAvatar;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimulatedLatencySettings LatencySettings;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int PacketSequence;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LinkedList<PacketLatencyPair> packetQueue;

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x84DAE4", Offset = "0x84DAE4", VA = "0x84DAE4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x84DC3C", Offset = "0x84DC3C", VA = "0x84DC3C")]
	private void OnLocalAvatarPacketRecorded(object sender, OvrAvatar.PacketEventArgs args)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x84E01C", Offset = "0x84E01C", VA = "0x84E01C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x84DF68", Offset = "0x84DF68", VA = "0x84DF68")]
	private void SendPacketData(byte[] data)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x84E34C", Offset = "0x84E34C", VA = "0x84E34C")]
	private void ReceivePacketData(byte[] data)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x84E620", Offset = "0x84E620", VA = "0x84E620")]
	public RemoteLoopbackManager()
	{
	}
}
[Token(Token = "0x2000012")]
public class P2PManager
{
	[Token(Token = "0x2000013")]
	private enum MessageType : byte
	{
		[Token(Token = "0x4000053")]
		Update = 1
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x845EA4", Offset = "0x845EA4", VA = "0x845EA4")]
	public P2PManager()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x845F84", Offset = "0x845F84", VA = "0x845F84")]
	public void ConnectTo(ulong userID)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x846200", Offset = "0x846200", VA = "0x846200")]
	public void Disconnect(ulong userID)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x846358", Offset = "0x846358", VA = "0x846358")]
	private void PeerConnectRequestCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x8464BC", Offset = "0x8464BC", VA = "0x8464BC")]
	private void ConnectionStateChangedCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x8466EC", Offset = "0x8466EC", VA = "0x8466EC")]
	public void SendAvatarUpdate(ulong userID, Transform rootTransform, uint sequence, byte[] avatarPacket)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x846AD8", Offset = "0x846AD8", VA = "0x846AD8")]
	public void GetRemotePackets()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x846D8C", Offset = "0x846D8C", VA = "0x846D8C")]
	public void processAvatarPacket(RemotePlayer remote, ref byte[] packet, ref int offset)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x8468B4", Offset = "0x8468B4", VA = "0x8468B4")]
	private void PackByte(byte b, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x846CC0", Offset = "0x846CC0", VA = "0x846CC0")]
	private byte ReadByte(byte[] buf, ref int offset)
	{
		return default(byte);
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x846998", Offset = "0x846998", VA = "0x846998")]
	private void PackFloat(float f, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x846FC4", Offset = "0x846FC4", VA = "0x846FC4")]
	private float ReadFloat(byte[] buf, ref int offset)
	{
		return default(float);
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x8468FC", Offset = "0x8468FC", VA = "0x8468FC")]
	private void PackULong(ulong u, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x846D04", Offset = "0x846D04", VA = "0x846D04")]
	private ulong ReadULong(byte[] buf, ref int offset)
	{
		return default(ulong);
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x846A3C", Offset = "0x846A3C", VA = "0x846A3C")]
	private void PackUInt32(uint u, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x84704C", Offset = "0x84704C", VA = "0x84704C")]
	private uint ReadUInt32(byte[] buf, ref int offset)
	{
		return default(uint);
	}
}
[Token(Token = "0x2000014")]
public class PlayerController : SocialPlatformManager
{
	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Camera spyCamera;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private GameObject cameraRig;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private bool showUI;

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x8492E4", Offset = "0x8492E4", VA = "0x8492E4", Slot = "5")]
	public override void Awake()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x849718", Offset = "0x849718", VA = "0x849718", Slot = "6")]
	public override void Start()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x84973C", Offset = "0x84973C", VA = "0x84973C", Slot = "4")]
	public override void Update()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x849B00", Offset = "0x849B00", VA = "0x849B00")]
	private void checkInput()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x849C9C", Offset = "0x849C9C", VA = "0x849C9C")]
	private void ToggleCamera()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x849D1C", Offset = "0x849D1C", VA = "0x849D1C")]
	private void ToggleUI()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x849D70", Offset = "0x849D70", VA = "0x849D70")]
	public PlayerController()
	{
	}
}
[Token(Token = "0x2000015")]
public class RemotePlayer
{
	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong remoteUserID;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool stillInRoom;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public PeerConnectionState p2pConnectionState;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PeerConnectionState voipConnectionState;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatar RemoteAvatar;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 receivedRootPosition;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 receivedRootPositionPrior;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Quaternion receivedRootRotation;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Quaternion receivedRootRotationPrior;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public VoipAudioSourceHiLevel voipSource;

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x84E6DC", Offset = "0x84E6DC", VA = "0x84E6DC")]
	public RemotePlayer()
	{
	}
}
[Token(Token = "0x2000016")]
public class RoomManager
{
	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong roomID;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ulong invitedRoomID;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool amIServer;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool startupDone;

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x84E6E4", Offset = "0x84E6E4", VA = "0x84E6E4")]
	public RoomManager()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x84E7E8", Offset = "0x84E7E8", VA = "0x84E7E8")]
	private void AcceptingInviteCallback(Message<string> msg)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x84EA14", Offset = "0x84EA14", VA = "0x84EA14")]
	public bool CheckForInvite()
	{
		return default(bool);
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x84EB4C", Offset = "0x84EB4C", VA = "0x84EB4C")]
	public void CreateRoom()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x84EC20", Offset = "0x84EC20", VA = "0x84EC20")]
	private void CreateAndJoinPrivateRoomCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x84EA44", Offset = "0x84EA44", VA = "0x84EA44")]
	public void JoinExistingRoom(ulong roomID)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x84F0F0", Offset = "0x84F0F0", VA = "0x84F0F0")]
	private void JoinRoomCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x84F874", Offset = "0x84F874", VA = "0x84F874")]
	private void RoomUpdateCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x84FBC0", Offset = "0x84FBC0", VA = "0x84FBC0")]
	public void LeaveCurrentRoom()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x84F420", Offset = "0x84F420", VA = "0x84F420")]
	private void ProcessRoomData(Message<Room> msg)
	{
	}
}
[Token(Token = "0x2000017")]
public class SocialPlatformManager : MonoBehaviour
{
	[Token(Token = "0x2000018")]
	public enum State
	{
		[Token(Token = "0x400008B")]
		INITIALIZING,
		[Token(Token = "0x400008C")]
		CHECKING_LAUNCH_STATE,
		[Token(Token = "0x400008D")]
		CREATING_A_ROOM,
		[Token(Token = "0x400008E")]
		WAITING_IN_A_ROOM,
		[Token(Token = "0x400008F")]
		JOINING_A_ROOM,
		[Token(Token = "0x4000090")]
		CONNECTED_IN_A_ROOM,
		[Token(Token = "0x4000091")]
		LEAVING_A_ROOM,
		[Token(Token = "0x4000092")]
		SHUTDOWN
	}

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Vector3 START_ROTATION_ONE;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static readonly Vector3 START_POSITION_ONE;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly Vector3 START_ROTATION_TWO;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static readonly Vector3 START_POSITION_TWO;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly Vector3 START_ROTATION_THREE;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static readonly Vector3 START_POSITION_THREE;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static readonly Vector3 START_ROTATION_FOUR;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static readonly Vector3 START_POSITION_FOUR;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static readonly Color BLACK;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static readonly Color WHITE;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static readonly Color CYAN;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static readonly Color BLUE;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static readonly Color GREEN;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float voiceCurrent;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private uint packetSequence;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OvrAvatar localAvatarPrefab;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatar remoteAvatarPrefab;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject helpPanel;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected MeshRenderer helpMesh;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material riftMaterial;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material gearMaterial;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected OvrAvatar localAvatar;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected GameObject localTrackingSpace;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected GameObject localPlayerHead;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected Dictionary<ulong, RemotePlayer> remoteUsers;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject roomSphere;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected MeshRenderer sphereMesh;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject roomFloor;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected MeshRenderer floorMesh;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected State currentState;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected static SocialPlatformManager s_instance;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected RoomManager roomManager;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected P2PManager p2pManager;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected VoipManager voipManager;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected ulong myID;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	protected string myOculusID;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public static readonly float VOIP_SCALE;

	[Token(Token = "0x17000003")]
	public static State CurrentState
	{
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x8547A4", Offset = "0x8547A4", VA = "0x8547A4")]
		get
		{
			return default(State);
		}
	}

	[Token(Token = "0x17000004")]
	public static ulong MyID
	{
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x846060", Offset = "0x846060", VA = "0x846060")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x17000005")]
	public static string MyOculusID
	{
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x854814", Offset = "0x854814", VA = "0x854814")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x849760", Offset = "0x849760", VA = "0x849760", Slot = "4")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x849324", Offset = "0x849324", VA = "0x849324", Slot = "5")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x853598", Offset = "0x853598", VA = "0x853598")]
	private void InitCallback(Message<PlatformInitialize> msg)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x849738", Offset = "0x849738", VA = "0x849738", Slot = "6")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x853740", Offset = "0x853740", VA = "0x853740")]
	private void IsEntitledCallback(Message msg)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x853860", Offset = "0x853860", VA = "0x853860")]
	private void GetLoggedInUserCallback(Message<User> msg)
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x853FC0", Offset = "0x853FC0", VA = "0x853FC0")]
	private void GetLoggedInUserFriendsAndRoomsCallback(Message<UserAndRoomList> msg)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x8543AC", Offset = "0x8543AC", VA = "0x8543AC")]
	public void OnLocalAvatarPacketRecorded(object sender, OvrAvatar.PacketEventArgs args)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x8545B8", Offset = "0x8545B8", VA = "0x8545B8")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x854738", Offset = "0x854738", VA = "0x854738")]
	public void AddUser(ulong userID, ref RemotePlayer remoteUser)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x8534E4", Offset = "0x8534E4", VA = "0x8534E4")]
	public void LogOutputLine(string line)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x84E95C", Offset = "0x84E95C", VA = "0x84E95C")]
	public static void TerminateWithError(Message msg)
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x84ED4C", Offset = "0x84ED4C", VA = "0x84ED4C")]
	public static void TransitionToState(State newState)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x85493C", Offset = "0x85493C", VA = "0x85493C")]
	private static void SetSphereColorForState()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x84F00C", Offset = "0x84F00C", VA = "0x84F00C")]
	public static void SetFloorColorForState(bool host)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x84FC34", Offset = "0x84FC34", VA = "0x84FC34")]
	public static void MarkAllRemoteUsersAsNotInRoom()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x85002C", Offset = "0x85002C", VA = "0x85002C")]
	public static void MarkRemoteUserInRoom(ulong userID)
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x850110", Offset = "0x850110", VA = "0x850110")]
	public static void ForgetRemoteUsersNotInRoom()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x846140", Offset = "0x846140", VA = "0x846140")]
	public static void LogOutput(string line)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x84FD90", Offset = "0x84FD90", VA = "0x84FD90")]
	public static bool IsUserInRoom(ulong userID)
	{
		return default(bool);
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x84FE24", Offset = "0x84FE24", VA = "0x84FE24")]
	public static void AddRemoteUser(ulong userID)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x854AB8", Offset = "0x854AB8", VA = "0x854AB8")]
	public static void RemoveRemoteUser(ulong userID)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x854CCC", Offset = "0x854CCC", VA = "0x854CCC")]
	public void UpdateVoiceData(short[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x853460", Offset = "0x853460", VA = "0x853460")]
	[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x590ED0", Offset = "0x590ED0")]
	public static void MicFilter(short[] pcmData, UIntPtr pcmDataLength, int frequency, int numChannels)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x84627C", Offset = "0x84627C", VA = "0x84627C")]
	public static RemotePlayer GetRemoteUser(ulong userID)
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x849DD8", Offset = "0x849DD8", VA = "0x849DD8")]
	public SocialPlatformManager()
	{
	}
}
[Token(Token = "0x2000019")]
public class VoipManager
{
	[Token(Token = "0x600007C")]
	[Address(RVA = "0xB0F8B0", Offset = "0xB0F8B0", VA = "0xB0F8B0")]
	public VoipManager()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xB0F990", Offset = "0xB0F990", VA = "0xB0F990")]
	public void ConnectTo(ulong userID)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xB0FA74", Offset = "0xB0FA74", VA = "0xB0FA74")]
	public void Disconnect(ulong userID)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xB0FAF4", Offset = "0xB0FAF4", VA = "0xB0FAF4")]
	private void VoipConnectRequestCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xB0FC64", Offset = "0xB0FC64", VA = "0xB0FC64")]
	private void VoipStateChangedCallback(Message<NetworkingPeer> msg)
	{
	}
}
[Token(Token = "0x200001A")]
public class GazeTarget : MonoBehaviour
{
	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ovrAvatarGazeTargetType Type;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ovrAvatarGazeTargets RuntimeTargetList;

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xB44950", Offset = "0xB44950", VA = "0xB44950")]
	static GazeTarget()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xB449D8", Offset = "0xB449D8", VA = "0xB449D8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xB44B4C", Offset = "0xB44B4C", VA = "0xB44B4C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xB44BB0", Offset = "0xB44BB0", VA = "0xB44BB0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xB44A14", Offset = "0xB44A14", VA = "0xB44A14")]
	private void UpdateGazeTarget()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xB44C74", Offset = "0xB44C74", VA = "0xB44C74")]
	private ovrAvatarGazeTarget CreateOvrGazeTarget(uint targetId, Vector3 targetPosition, ovrAvatarGazeTargetType targetType)
	{
		return default(ovrAvatarGazeTarget);
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xB44C8C", Offset = "0xB44C8C", VA = "0xB44C8C")]
	public GazeTarget()
	{
	}
}
[Serializable]
[Token(Token = "0x200001B")]
public class AvatarLayer
{
	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int layerIndex;

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x140AAF4", Offset = "0x140AAF4", VA = "0x140AAF4")]
	public AvatarLayer()
	{
	}
}
[Serializable]
[Token(Token = "0x200001C")]
public class PacketRecordSettings
{
	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal bool RecordingFrames;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float UpdateRate;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal float AccumulatedTime;

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x8470D4", Offset = "0x8470D4", VA = "0x8470D4")]
	public PacketRecordSettings()
	{
	}
}
[Token(Token = "0x200001D")]
public class OvrAvatar : MonoBehaviour
{
	[Token(Token = "0x200001E")]
	public class PacketEventArgs : EventArgs
	{
		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly OvrAvatarPacket Packet;

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xF3CAF8", Offset = "0xF3CAF8", VA = "0xF3CAF8")]
		public PacketEventArgs(OvrAvatarPacket packet)
		{
		}
	}

	[Token(Token = "0x200001F")]
	public enum HandType
	{
		[Token(Token = "0x40000F4")]
		Right,
		[Token(Token = "0x40000F5")]
		Left,
		[Token(Token = "0x40000F6")]
		Max
	}

	[Token(Token = "0x2000020")]
	public enum HandJoint
	{
		[Token(Token = "0x40000F8")]
		HandBase,
		[Token(Token = "0x40000F9")]
		IndexBase,
		[Token(Token = "0x40000FA")]
		IndexTip,
		[Token(Token = "0x40000FB")]
		ThumbBase,
		[Token(Token = "0x40000FC")]
		ThumbTip,
		[Token(Token = "0x40000FD")]
		Max
	}

	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C9A0", Offset = "0x58C9A0")]
	private sealed class <WaitForMouthAudioSource>d__137 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OvrAvatar <>4__this;

		[Token(Token = "0x17000006")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0xF3CAA8", Offset = "0xF3CAA8", VA = "0xF3CAA8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0xF3CAF0", Offset = "0xF3CAF0", VA = "0xF3CAF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xF3C8CC", Offset = "0xF3C8CC", VA = "0xF3C8CC")]
		[DebuggerHidden]
		public <WaitForMouthAudioSource>d__137(int <>1__state)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xF3C8F8", Offset = "0xF3C8F8", VA = "0xF3C8F8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xF3C8FC", Offset = "0xF3C8FC", VA = "0xF3C8FC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xF3CAB0", Offset = "0xF3CAB0", VA = "0xF3CAB0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x58E704", Offset = "0x58E704")]
	public IntPtr sdkAvatar;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string oculusUserID;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatarDriver Driver;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x58E73C", Offset = "0x58E73C")]
	public bool EnableBody;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool EnableHands;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool EnableBase;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	public bool EnableExpressive;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x58E774", Offset = "0x58E774")]
	public bool RecordPackets;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	public bool UseSDKPackets;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public PacketRecordSettings PacketSettings;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x58E7AC", Offset = "0x58E7AC")]
	public bool StartWithControllers;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AvatarLayer FirstPersonLayer;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AvatarLayer ThirdPersonLayer;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool ShowFirstPerson;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool ShowThirdPerson;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	internal ovrAvatarCapabilities Capabilities;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x58E7E4", Offset = "0x58E7E4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58E7E4", Offset = "0x58E7E4")]
	internal ovrAvatarAssetLevelOfDetail LevelOfDetail;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58E854", Offset = "0x58E854")]
	private bool CombineMeshes;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58E88C", Offset = "0x58E88C")]
	public bool UseTransparentRenderQueue;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x58E8C4", Offset = "0x58E8C4")]
	public Shader Monochrome_SurfaceShader;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Shader Monochrome_SurfaceShader_SelfOccluding;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Shader Monochrome_SurfaceShader_PBS;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Shader Skinshaded_SurfaceShader_SingleComponent;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Shader Skinshaded_VertFrag_SingleComponent;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Shader Skinshaded_VertFrag_CombinedMesh;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Shader Skinshaded_Expressive_SurfaceShader_SingleComponent;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Shader Skinshaded_Expressive_VertFrag_SingleComponent;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Shader Skinshaded_Expressive_VertFrag_CombinedMesh;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Shader Loader_VertFrag_CombinedMesh;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Shader EyeLens;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Shader ControllerShader;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x58E8FC", Offset = "0x58E8FC")]
	public bool CanOwnMicrophone;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58E934", Offset = "0x58E934")]
	public bool EnableLaughter;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public GameObject MouthAnchor;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Transform LeftHandCustomPose;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Transform RightHandCustomPose;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private HashSet<ulong> assetLoadingIds;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private bool assetsFinishedLoading;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private OvrAvatarMaterialManager materialManager;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private bool waitingForCombinedMesh;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool doneExpressiveGlobalInit;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private Vector4 clothingAlphaOffset;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private ulong clothingAlphaTexture;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private OVRLipSyncMicInput micInput;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private OVRLipSyncContext lipsyncContext;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private OVRLipSync.Frame currentFrame;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private float[] visemes;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private AudioSource audioSource;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private ONSPAudioSource spatializedSource;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private List<float[]> voiceUpdates;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ovrAvatarVisemes RuntimeVisemes;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private Transform cachedLeftHandCustomPose;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private Transform[] cachedCustomLeftHandJoints;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private ovrAvatarTransform[] cachedLeftHandTransforms;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private Transform cachedRightHandCustomPose;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private Transform[] cachedCustomRightHandJoints;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private ovrAvatarTransform[] cachedRightHandTransforms;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private bool showLeftController;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x189")]
	private bool showRightController;

	[Token(Token = "0x40000D4")]
	private const bool USE_MOBILE_TEXTURE_FORMAT = true;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly Vector3 MOUTH_HEAD_OFFSET;

	[Token(Token = "0x40000D6")]
	private const string MOUTH_HELPER_NAME = "MouthAnchor";

	[Token(Token = "0x40000D7")]
	private const int VISEME_COUNT = 16;

	[Token(Token = "0x40000D8")]
	private const float ACTION_UNIT_ONSET_SPEED = 30f;

	[Token(Token = "0x40000D9")]
	private const float ACTION_UNIT_FALLOFF_SPEED = 20f;

	[Token(Token = "0x40000DA")]
	private const float VISEME_LEVEL_MULTIPLIER = 1.5f;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	internal ulong oculusUserIDInternal;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	internal OvrAvatarBase Base;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	internal OvrAvatarTouchController ControllerLeft;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	internal OvrAvatarTouchController ControllerRight;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	internal OvrAvatarBody Body;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	internal OvrAvatarHand HandLeft;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	internal OvrAvatarHand HandRight;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	internal ovrAvatarLookAndFeelVersion LookAndFeelVersion;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
	internal ovrAvatarLookAndFeelVersion FallbackLookAndFeelVersion;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private OvrAvatarPacket CurrentUnityPacket;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public EventHandler<PacketEventArgs> PacketRecorded;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static string[,] HandJoints;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static Vector3 MOUTH_POSITION_OFFSET;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static string VOICE_PROPERTY;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static string MOUTH_POSITION_PROPERTY;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static string MOUTH_DIRECTION_PROPERTY;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static string MOUTH_SCALE_PROPERTY;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static float MOUTH_SCALE_GLOBAL;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private static float MOUTH_MAX_GLOBAL;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static string NECK_JONT;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public float VoiceAmplitude;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
	public bool EnableMouthVertexAnimation;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static ovrAvatarLights ovrLights;

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xD8B664", Offset = "0xD8B664", VA = "0xD8B664")]
	static OvrAvatar()
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xD8BB04", Offset = "0xD8BB04", VA = "0xD8BB04")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xD8BB98", Offset = "0xD8BB98", VA = "0xD8BB98")]
	public void AssetLoadedCallback(OvrAvatarAsset asset)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xD8BC00", Offset = "0xD8BC00", VA = "0xD8BC00")]
	public void CombinedMeshLoadedCallback(IntPtr assetPtr)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xD8BD30", Offset = "0xD8BD30", VA = "0xD8BD30")]
	private OvrAvatarSkinnedMeshRenderComponent AddSkinnedMeshRenderComponent(GameObject gameObject, ovrAvatarRenderPart_SkinnedMeshRender skinnedMeshRender)
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xD8BE10", Offset = "0xD8BE10", VA = "0xD8BE10")]
	private OvrAvatarSkinnedMeshRenderPBSComponent AddSkinnedMeshRenderPBSComponent(GameObject gameObject, ovrAvatarRenderPart_SkinnedMeshRenderPBS skinnedMeshRenderPBS)
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xD8BEEC", Offset = "0xD8BEEC", VA = "0xD8BEEC")]
	private OvrAvatarSkinnedMeshPBSV2RenderComponent AddSkinnedMeshRenderPBSV2Component(IntPtr renderPart, GameObject go, ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 skinnedMeshRenderPBSV2, bool isBodyPartZero, bool isControllerModel)
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xD8C0D0", Offset = "0xD8C0D0", VA = "0xD8C0D0")]
	public static IntPtr GetRenderPart(ovrAvatarComponent component, uint renderPartIndex)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xD8C1AC", Offset = "0xD8C1AC", VA = "0xD8C1AC")]
	private static string GetRenderPartName(ovrAvatarComponent component, uint renderPartIndex)
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xD8C224", Offset = "0xD8C224", VA = "0xD8C224")]
	internal static void ConvertTransform(float[] transform, ref ovrAvatarTransform target)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xD8C30C", Offset = "0xD8C30C", VA = "0xD8C30C")]
	internal static void ConvertTransform(ovrAvatarTransform transform, Transform target)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xD8C398", Offset = "0xD8C398", VA = "0xD8C398")]
	public static ovrAvatarTransform CreateOvrAvatarTransform(Vector3 position, Quaternion orientation)
	{
		return default(ovrAvatarTransform);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xD8C420", Offset = "0xD8C420", VA = "0xD8C420")]
	private static ovrAvatarGazeTarget CreateOvrGazeTarget(uint targetId, Vector3 targetPosition, ovrAvatarGazeTargetType targetType)
	{
		return default(ovrAvatarGazeTarget);
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xD8C438", Offset = "0xD8C438", VA = "0xD8C438")]
	private void BuildRenderComponents()
	{
	}

	[Token(Token = "0x6000098")]
	private void AddAvatarComponent<T>(ref T root, ovrAvatarComponent nativeComponent) where T : OvrAvatarComponent
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xD8C8E8", Offset = "0xD8C8E8", VA = "0xD8C8E8")]
	private void UpdateCustomPoses()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xD8CC68", Offset = "0xD8CC68", VA = "0xD8CC68")]
	private static bool UpdatePoseRoot(Transform poseRoot, ref Transform cachedPoseRoot, ref Transform[] cachedPoseJoints, ref ovrAvatarTransform[] transforms)
	{
		return default(bool);
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xD8CE54", Offset = "0xD8CE54", VA = "0xD8CE54")]
	private static bool UpdateTransforms(Transform[] joints, ovrAvatarTransform[] transforms)
	{
		return default(bool);
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xD8D0A0", Offset = "0xD8D0A0", VA = "0xD8D0A0")]
	private static void OrderJoints(Transform transform, List<Transform> joints)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xD8D194", Offset = "0xD8D194", VA = "0xD8D194")]
	private void AvatarSpecificationCallback(IntPtr avatarSpecification)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xD8D800", Offset = "0xD8D800", VA = "0xD8D800")]
	private void Start()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xD8DB38", Offset = "0xD8DB38", VA = "0xD8DB38")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xD8E570", Offset = "0xD8E570", VA = "0xD8E570")]
	public static ovrAvatarHandInputState CreateInputState(ovrAvatarTransform transform, OvrAvatarDriver.ControllerPose pose)
	{
		return default(ovrAvatarHandInputState);
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xD8E5C4", Offset = "0xD8E5C4", VA = "0xD8E5C4")]
	public void ShowControllers(bool show)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xD8D450", Offset = "0xD8D450", VA = "0xD8D450")]
	public void ShowLeftController(bool show)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xD8D4F4", Offset = "0xD8D4F4", VA = "0xD8D4F4")]
	public void ShowRightController(bool show)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xD8E5F4", Offset = "0xD8E5F4", VA = "0xD8E5F4")]
	public void UpdateVoiceVisualization(float[] voiceSamples)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xD8DF10", Offset = "0xD8DF10", VA = "0xD8DF10")]
	private void RecordFrame()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xD8E868", Offset = "0xD8E868", VA = "0xD8E868")]
	private void RecordUnityFrame()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xD8E658", Offset = "0xD8E658", VA = "0xD8E658")]
	private void RecordSDKFrame()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xD8EB3C", Offset = "0xD8EB3C", VA = "0xD8EB3C")]
	private void AddRenderParts(OvrAvatarComponent ovrComponent, ovrAvatarComponent component, Transform parent)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xD8EFB8", Offset = "0xD8EFB8", VA = "0xD8EFB8")]
	public void RefreshBodyParts()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xD8F3BC", Offset = "0xD8F3BC", VA = "0xD8F3BC")]
	public ovrAvatarBodyComponent? GetBodyComponent()
	{
		return null;
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xD8F510", Offset = "0xD8F510", VA = "0xD8F510")]
	public Transform GetHandTransform(HandType hand, HandJoint joint)
	{
		return null;
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xD8F6F4", Offset = "0xD8F6F4", VA = "0xD8F6F4")]
	public void GetPointingDirection(HandType hand, ref Vector3 forward, ref Vector3 up)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xD8E0F0", Offset = "0xD8E0F0", VA = "0xD8E0F0")]
	private void UpdateVoiceBehavior()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xD8F7C8", Offset = "0xD8F7C8", VA = "0xD8F7C8")]
	private bool IsValidMic()
	{
		return default(bool);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xD8DF20", Offset = "0xD8DF20", VA = "0xD8DF20")]
	private void InitPostLoad()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xD8F8B8", Offset = "0xD8F8B8", VA = "0xD8F8B8")]
	private static void ExpressiveGlobalInit()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xD8FF6C", Offset = "0xD8FF6C", VA = "0xD8FF6C")]
	private static void InitializeLights()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xD90450", Offset = "0xD90450", VA = "0xD90450")]
	private static ovrAvatarLight CreateLightDirectional(uint id, Vector3 direction, float intensity, ref ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xD90478", Offset = "0xD90478", VA = "0xD90478")]
	private static ovrAvatarLight CreateLightPoint(uint id, Vector3 position, float range, float intensity, ref ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xD904A0", Offset = "0xD904A0", VA = "0xD904A0")]
	private static ovrAvatarLight CreateLightSpot(uint id, Vector3 position, Vector3 direction, float spotAngleDeg, float range, float intensity, ref ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xD8E3FC", Offset = "0xD8E3FC", VA = "0xD8E3FC")]
	private void UpdateExpressive()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xD8F988", Offset = "0xD8F988", VA = "0xD8F988")]
	private void ConfigureHelpers()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xD908D0", Offset = "0xD908D0", VA = "0xD908D0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x590F30", Offset = "0x590F30")]
	private IEnumerator WaitForMouthAudioSource()
	{
		return null;
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xD90948", Offset = "0xD90948", VA = "0xD90948")]
	public void DestroyHelperObjects()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xD90790", Offset = "0xD90790", VA = "0xD90790")]
	public GameObject CreateHelperObject(Transform parent, Vector3 localPositionOffset, string helperName, string helperTag = "")
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xD90A0C", Offset = "0xD90A0C", VA = "0xD90A0C")]
	public void UpdateVoiceData(short[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xD90AF4", Offset = "0xD90AF4", VA = "0xD90AF4")]
	public void UpdateVoiceData(float[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xD904DC", Offset = "0xD904DC", VA = "0xD904DC")]
	private void UpdateFacewave()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xD90BDC", Offset = "0xD90BDC", VA = "0xD90BDC")]
	public OvrAvatar()
	{
	}
}
[Token(Token = "0x2000022")]
public class OvrAvatarAsset
{
	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong assetID;

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xD90DD8", Offset = "0xD90DD8", VA = "0xD90DD8")]
	public OvrAvatarAsset()
	{
	}
}
[Token(Token = "0x2000023")]
public class OvrAvatarAssetMesh : OvrAvatarAsset
{
	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Mesh mesh;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ovrAvatarSkinnedMeshPose skinnedBindPose;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string[] jointNames;

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xD90EA8", Offset = "0xD90EA8", VA = "0xD90EA8")]
	public OvrAvatarAssetMesh(ulong _assetId, IntPtr asset, ovrAvatarAssetType meshType)
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xD92160", Offset = "0xD92160", VA = "0xD92160")]
	private void LoadSubmeshes(IntPtr asset, IntPtr indexBufferPtr, ulong indexCount)
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xD91D34", Offset = "0xD91D34", VA = "0xD91D34")]
	private void LoadBlendShapes(IntPtr asset, long vertexCount)
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xD91AB8", Offset = "0xD91AB8", VA = "0xD91AB8")]
	private void SetSkinnedBindPose(IntPtr asset, ovrAvatarAssetType meshType)
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xD91BA0", Offset = "0xD91BA0", VA = "0xD91BA0")]
	private void GetVertexAndIndexData(IntPtr asset, ovrAvatarAssetType meshType, out long vertexCount, out IntPtr vertexBuffer, out uint indexCount, out IntPtr indexBuffer)
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xD923F0", Offset = "0xD923F0", VA = "0xD923F0")]
	public SkinnedMeshRenderer CreateSkinnedMeshRendererOnObject(GameObject target)
	{
		return null;
	}
}
[Token(Token = "0x2000024")]
public class OvrAvatarAssetTexture : OvrAvatarAsset
{
	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D texture;

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xD929B8", Offset = "0xD929B8", VA = "0xD929B8")]
	public OvrAvatarAssetTexture(ulong _assetId, IntPtr asset)
	{
	}
}
[Token(Token = "0x2000025")]
public class OvrAvatarBase : OvrAvatarComponent
{
	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ovrAvatarBaseComponent component;

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xD92C34", Offset = "0xD92C34", VA = "0xD92C34")]
	private void Update()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xD93094", Offset = "0xD93094", VA = "0xD93094")]
	public OvrAvatarBase()
	{
	}
}
[Token(Token = "0x2000026")]
public class OvrAvatarBody : OvrAvatarComponent
{
	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ovrAvatarBodyComponent component;

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xD8F24C", Offset = "0xD8F24C", VA = "0xD8F24C")]
	public ovrAvatarComponent? GetNativeAvatarComponent()
	{
		return null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xD931C4", Offset = "0xD931C4", VA = "0xD931C4")]
	private void Update()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xD932F4", Offset = "0xD932F4", VA = "0xD932F4")]
	public OvrAvatarBody()
	{
	}
}
[Token(Token = "0x2000027")]
public class OvrAvatarComponent : MonoBehaviour
{
	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string[] LayerKeywords;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly string[] LayerSampleModeParameters;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly string[] LayerBlendModeParameters;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static readonly string[] LayerMaskTypeParameters;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static readonly string[] LayerColorParameters;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static readonly string[] LayerSurfaceParameters;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static readonly string[] LayerSampleParametersParameters;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static readonly string[] LayerMaskParametersParameters;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static readonly string[] LayerMaskAxisParameters;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<Material, ovrAvatarMaterialState> materialStates;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<OvrAvatarRenderComponent> RenderParts;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected OvrAvatar owner;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected ovrAvatarComponent nativeAvatarComponent;

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xD93354", Offset = "0xD93354", VA = "0xD93354")]
	public void SetOvrAvatarOwner(OvrAvatar ovrAvatarOwner)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xD92D64", Offset = "0xD92D64", VA = "0xD92D64")]
	public void UpdateAvatar(IntPtr nativeComponent)
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xD9335C", Offset = "0xD9335C", VA = "0xD9335C")]
	protected void UpdateActive(OvrAvatar avatar, ovrAvatarVisibilityFlags mask)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xD933BC", Offset = "0xD933BC", VA = "0xD933BC")]
	public void UpdateAvatarMaterial(Material mat, ovrAvatarMaterialState matState)
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xD93B70", Offset = "0xD93B70", VA = "0xD93B70")]
	public static Texture2D GetLoadedTexture(ulong assetId)
	{
		return null;
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xD930F4", Offset = "0xD930F4", VA = "0xD930F4")]
	public OvrAvatarComponent()
	{
	}
}
[Token(Token = "0x2000028")]
public abstract class OvrAvatarDriver : MonoBehaviour
{
	[Token(Token = "0x2000029")]
	public enum PacketMode
	{
		[Token(Token = "0x4000119")]
		SDK,
		[Token(Token = "0x400011A")]
		Unity
	}

	[Token(Token = "0x200002A")]
	public struct ControllerPose
	{
		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ovrAvatarButton buttons;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ovrAvatarTouch touches;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector2 joystickPosition;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float indexTrigger;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float handTrigger;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isActive;

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xF3CB78", Offset = "0xF3CB78", VA = "0xF3CB78")]
		public static ControllerPose Interpolate(ControllerPose a, ControllerPose b, float t)
		{
			return default(ControllerPose);
		}
	}

	[Token(Token = "0x200002B")]
	public struct PoseFrame
	{
		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 headPosition;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Quaternion headRotation;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 handLeftPosition;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Quaternion handLeftRotation;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 handRightPosition;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Quaternion handRightRotation;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float voiceAmplitude;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ControllerPose controllerLeftPose;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public ControllerPose controllerRightPose;

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xF3CC54", Offset = "0xF3CC54", VA = "0xF3CC54")]
		public static PoseFrame Interpolate(PoseFrame a, PoseFrame b, float t)
		{
			return default(PoseFrame);
		}
	}

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PacketMode Mode;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	protected PoseFrame CurrentPose;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private ovrAvatarControllerType ControllerType;

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xD954A8", Offset = "0xD954A8", VA = "0xD954A8")]
	public PoseFrame GetCurrentPose()
	{
		return default(PoseFrame);
	}

	[Token(Token = "0x60000DA")]
	public abstract void UpdateTransforms(IntPtr sdkAvatar);

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xD954B8", Offset = "0xD954B8", VA = "0xD954B8")]
	private void Start()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xD8D598", Offset = "0xD8D598", VA = "0xD8D598")]
	public void UpdateTransformsFromPose(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xD95540", Offset = "0xD95540", VA = "0xD95540")]
	public static bool GetIsTrackedRemote()
	{
		return default(bool);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xD95548", Offset = "0xD95548", VA = "0xD95548")]
	protected OvrAvatarDriver()
	{
	}
}
[Token(Token = "0x200002C")]
public class OvrAvatarHand : OvrAvatarComponent
{
	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool isLeftHand;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ovrAvatarHandComponent component;

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xD95558", Offset = "0xD95558", VA = "0xD95558")]
	private void Update()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xD956C8", Offset = "0xD956C8", VA = "0xD956C8")]
	public OvrAvatarHand()
	{
	}
}
[Token(Token = "0x200002D")]
public class OvrAvatarLocalDriver : OvrAvatarDriver
{
	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 centerEyePosition;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Quaternion centerEyeRotation;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float voiceAmplitude;

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xD95730", Offset = "0xD95730", VA = "0xD95730")]
	private ControllerPose GetMalibuControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xD95894", Offset = "0xD95894", VA = "0xD95894")]
	private ControllerPose GetControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xD95C30", Offset = "0xD95C30", VA = "0xD95C30")]
	private void CalculateCurrentPose()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xD95E54", Offset = "0xD95E54", VA = "0xD95E54", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xD95E80", Offset = "0xD95E80", VA = "0xD95E80")]
	public OvrAvatarLocalDriver()
	{
	}
}
[Token(Token = "0x200002E")]
public class OvrAvatarMaterialManager : MonoBehaviour
{
	[Token(Token = "0x200002F")]
	public enum TextureType
	{
		[Token(Token = "0x4000150")]
		DiffuseTextures,
		[Token(Token = "0x4000151")]
		NormalMaps,
		[Token(Token = "0x4000152")]
		RoughnessMaps,
		[Token(Token = "0x4000153")]
		Count
	}

	[Token(Token = "0x2000030")]
	public struct AvatarComponentMaterialProperties
	{
		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ovrAvatarBodyPartType TypeIndex;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Color Color;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D[] Textures;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float DiffuseIntensity;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float RimIntensity;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float ReflectionIntensity;
	}

	[Token(Token = "0x2000031")]
	public struct AvatarTextureArrayProperties
	{
		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Texture2D[] Textures;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture2DArray TextureArray;
	}

	[Token(Token = "0x2000032")]
	public struct AvatarMaterialPropertyBlock
	{
		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector4[] Colors;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float[] DiffuseIntensities;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] RimIntensities;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float[] ReflectionIntensities;
	}

	[Serializable]
	[Token(Token = "0x2000033")]
	public class AvatarMaterialConfig
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AvatarComponentMaterialProperties[] ComponentMaterialProperties;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AvatarMaterialPropertyBlock MaterialPropertyBlock;

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xF3D698", Offset = "0xF3D698", VA = "0xF3D698")]
		public AvatarMaterialConfig()
		{
		}
	}

	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C9B0", Offset = "0x58C9B0")]
	private sealed class <RunLoadingAnimation>d__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OvrAvatarMaterialManager <>4__this;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action callBack;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <srcBlend>5__2;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <dstBlend>5__3;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string <lightModeTag>5__4;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string <renderTypeTag>5__5;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string <renderQueueTag>5__6;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string <ignoreProjectorTag>5__7;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int <renderQueue>5__8;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool <transparentQueue>5__9;

		[Token(Token = "0x17000008")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0xF3D648", Offset = "0xF3D648", VA = "0xF3D648", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0xF3D690", Offset = "0xF3D690", VA = "0xF3D690", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xF3CF58", Offset = "0xF3CF58", VA = "0xF3CF58")]
		[DebuggerHidden]
		public <RunLoadingAnimation>d__49(int <>1__state)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xF3CF84", Offset = "0xF3CF84", VA = "0xF3CF84", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xF3CF88", Offset = "0xF3CF88", VA = "0xF3CF88", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xF3D650", Offset = "0xF3D650", VA = "0xF3D650", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Renderer TargetRenderer;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AvatarTextureArrayProperties[] TextureArrays;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly string[] TextureTypeToShaderProperties;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AvatarMaterialConfig LocalAvatarConfig;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<ReflectionProbeBlendInfo> ReflectionProbes;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Shader CombinedShader;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string AVATAR_SHADER_LOADER;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string AVATAR_SHADER_MAINTEX;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static string AVATAR_SHADER_NORMALMAP;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static string AVATAR_SHADER_ROUGHNESSMAP;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static string AVATAR_SHADER_COLOR;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static string AVATAR_SHADER_DIFFUSEINTENSITY;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static string AVATAR_SHADER_RIMINTENSITY;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static string AVATAR_SHADER_REFLECTIONINTENSITY;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static string AVATAR_SHADER_CUBEMAP;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static string AVATAR_SHADER_ALPHA;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static string AVATAR_SHADER_LOADING_DIMMER;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static string AVATAR_SHADER_IRIS_COLOR;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public static string AVATAR_SHADER_LIP_COLOR;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public static string AVATAR_SHADER_BROW_COLOR;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static string AVATAR_SHADER_LASH_COLOR;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static string AVATAR_SHADER_SCLERA_COLOR;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public static string AVATAR_SHADER_GUM_COLOR;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public static string AVATAR_SHADER_TEETH_COLOR;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public static string AVATAR_SHADER_LIP_SMOOTHNESS;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public static float[] DiffuseIntensities;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public static float[] RimIntensities;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public static float[] ReflectionIntensities;

	[Token(Token = "0x400014B")]
	private const float LOADING_ANIMATION_AMPLITUDE = 0.5f;

	[Token(Token = "0x400014C")]
	private const float LOADING_ANIMATION_PERIOD = 0.35f;

	[Token(Token = "0x400014D")]
	private const float LOADING_ANIMATION_CURVE_SCALE = 0.25f;

	[Token(Token = "0x400014E")]
	private const float LOADING_ANIMATION_DIMMER_MIN = 0.3f;

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xD95ECC", Offset = "0xD95ECC", VA = "0xD95ECC")]
	public void CreateTextureArrays()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xD960AC", Offset = "0xD960AC", VA = "0xD960AC")]
	public void SetRenderer(Renderer renderer)
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xD960EC", Offset = "0xD960EC", VA = "0xD960EC")]
	public void OnCombinedMeshReady()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xD96880", Offset = "0xD96880", VA = "0xD96880")]
	public void AddTextureIDToTextureManager(ulong assetID, bool isSingleComponent)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xD968EC", Offset = "0xD968EC", VA = "0xD968EC")]
	private void DeleteTextureSet()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xD96188", Offset = "0xD96188", VA = "0xD96188")]
	public void InitTextureArrays()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xD96940", Offset = "0xD96940", VA = "0xD96940")]
	private void ProcessTexturesWithMips(Texture2D[] textures, int texArrayResolution, Texture2DArray texArray)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xD965DC", Offset = "0xD965DC", VA = "0xD965DC")]
	private void SetMaterialPropertyBlock()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xD96A30", Offset = "0xD96A30", VA = "0xD96A30")]
	private void ApplyMaterialPropertyBlock()
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xD96CD4", Offset = "0xD96CD4", VA = "0xD96CD4")]
	public static ovrAvatarBodyPartType GetComponentType(string objectName)
	{
		return default(ovrAvatarBodyPartType);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xD96DFC", Offset = "0xD96DFC", VA = "0xD96DFC")]
	private ulong GetTextureIDForType(ovrAvatarPBSMaterialState materialState, TextureType type)
	{
		return default(ulong);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xD96E34", Offset = "0xD96E34", VA = "0xD96E34")]
	public void ValidateTextures(ovrAvatarPBSMaterialState[] materialStates)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xD967EC", Offset = "0xD967EC", VA = "0xD967EC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x590FE0", Offset = "0x590FE0")]
	private IEnumerator RunLoadingAnimation(Action callBack)
	{
		return null;
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xD97D9C", Offset = "0xD97D9C", VA = "0xD97D9C")]
	public OvrAvatarMaterialManager()
	{
	}
}
[Token(Token = "0x2000035")]
public class OvrAvatarPacket
{
	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public IntPtr ovrNativePacket;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<float> frameTimes;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<OvrAvatarDriver.PoseFrame> frames;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<byte[]> encodedAudioPackets;

	[Token(Token = "0x1700000A")]
	public float Duration
	{
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x83F1E4", Offset = "0x83F1E4", VA = "0x83F1E4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700000B")]
	public OvrAvatarDriver.PoseFrame FinalFrame
	{
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x83F258", Offset = "0x83F258", VA = "0x83F258")]
		get
		{
			return default(OvrAvatarDriver.PoseFrame);
		}
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x83F2E8", Offset = "0x83F2E8", VA = "0x83F2E8")]
	public OvrAvatarPacket()
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x83F414", Offset = "0x83F414", VA = "0x83F414")]
	public OvrAvatarPacket(OvrAvatarDriver.PoseFrame initialPose)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x83F5E0", Offset = "0x83F5E0", VA = "0x83F5E0")]
	private OvrAvatarPacket(List<float> frameTimes, List<OvrAvatarDriver.PoseFrame> frames, List<byte[]> audioPackets)
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x83F74C", Offset = "0x83F74C", VA = "0x83F74C")]
	public void AddFrame(OvrAvatarDriver.PoseFrame frame, float deltaSeconds)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x83F824", Offset = "0x83F824", VA = "0x83F824")]
	public OvrAvatarDriver.PoseFrame GetPoseFrame(float seconds)
	{
		return default(OvrAvatarDriver.PoseFrame);
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x83FA54", Offset = "0x83FA54", VA = "0x83FA54")]
	public static OvrAvatarPacket Read(Stream stream)
	{
		return null;
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x83FD24", Offset = "0x83FD24", VA = "0x83FD24")]
	public void Write(Stream stream)
	{
	}
}
[Token(Token = "0x2000036")]
internal static class BinaryWriterExtensions
{
	[Token(Token = "0x6000107")]
	[Address(RVA = "0x1416614", Offset = "0x1416614", VA = "0x1416614")]
	public static void Write(this BinaryWriter writer, OvrAvatarDriver.PoseFrame frame)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x1416728", Offset = "0x1416728", VA = "0x1416728")]
	public static void Write(this BinaryWriter writer, Vector3 vec3)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x14168D4", Offset = "0x14168D4", VA = "0x14168D4")]
	public static void Write(this BinaryWriter writer, Vector2 vec2)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x1416798", Offset = "0x1416798", VA = "0x1416798")]
	public static void Write(this BinaryWriter writer, Quaternion quat)
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x141682C", Offset = "0x141682C", VA = "0x141682C")]
	public static void Write(this BinaryWriter writer, OvrAvatarDriver.ControllerPose pose)
	{
	}
}
[Token(Token = "0x2000037")]
internal static class BinaryReaderExtensions
{
	[Token(Token = "0x600010C")]
	[Address(RVA = "0x1416214", Offset = "0x1416214", VA = "0x1416214")]
	public static OvrAvatarDriver.PoseFrame ReadPoseFrame(this BinaryReader reader)
	{
		return default(OvrAvatarDriver.PoseFrame);
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x14165B8", Offset = "0x14165B8", VA = "0x14165B8")]
	public static Vector2 ReadVector2(this BinaryReader reader)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x14163B4", Offset = "0x14163B4", VA = "0x14163B4")]
	public static Vector3 ReadVector3(this BinaryReader reader)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x141642C", Offset = "0x141642C", VA = "0x141642C")]
	public static Quaternion ReadQuaternion(this BinaryReader reader)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x14164C8", Offset = "0x14164C8", VA = "0x14164C8")]
	public static OvrAvatarDriver.ControllerPose ReadControllerPose(this BinaryReader reader)
	{
		return default(OvrAvatarDriver.ControllerPose);
	}
}
[Token(Token = "0x2000038")]
public class OvrAvatarRemoteDriver : OvrAvatarDriver
{
	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Queue<OvrAvatarPacket> packetQueue;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private IntPtr CurrentSDKPacket;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float CurrentPacketTime;

	[Token(Token = "0x4000175")]
	private const int MinPacketQueue = 1;

	[Token(Token = "0x4000176")]
	private const int MaxPacketQueue = 4;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private int CurrentSequence;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private bool isStreaming;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private OvrAvatarPacket currentPacket;

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x83FF4C", Offset = "0x83FF4C", VA = "0x83FF4C")]
	public void QueuePacket(int sequence, OvrAvatarPacket packet)
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x83FFD4", Offset = "0x83FFD4", VA = "0x83FFD4", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x83FFF0", Offset = "0x83FFF0", VA = "0x83FFF0")]
	private void UpdateFromSDKPacket(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x840194", Offset = "0x840194", VA = "0x840194")]
	private void UpdateFromUnityPacket(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x840384", Offset = "0x840384", VA = "0x840384")]
	public OvrAvatarRemoteDriver()
	{
	}
}
[Token(Token = "0x2000039")]
public class OvrAvatarRenderComponent : MonoBehaviour
{
	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool firstSkinnedUpdate;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SkinnedMeshRenderer mesh;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform[] bones;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isBodyComponent;

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x840420", Offset = "0x840420", VA = "0x840420")]
	protected void UpdateActive(OvrAvatar avatar, ovrAvatarVisibilityFlags mask)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x840504", Offset = "0x840504", VA = "0x840504")]
	protected SkinnedMeshRenderer CreateSkinnedMesh(ulong assetID, ovrAvatarVisibilityFlags visibilityMask, int thirdPersonLayer, int firstPersonLayer)
	{
		return null;
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x840970", Offset = "0x840970", VA = "0x840970")]
	protected void UpdateSkinnedMesh(OvrAvatar avatar, Transform[] bones, ovrAvatarTransform localTransform, ovrAvatarVisibilityFlags visibilityMask, IntPtr renderPart)
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x840D30", Offset = "0x840D30", VA = "0x840D30")]
	protected Material CreateAvatarMaterial(string name, Shader shader)
	{
		return null;
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x840E3C", Offset = "0x840E3C", VA = "0x840E3C")]
	public OvrAvatarRenderComponent()
	{
	}
}
[Token(Token = "0x200003A")]
[Flags]
public enum ovrAvatarCapabilities
{
	[Token(Token = "0x400017F")]
	Body = 1,
	[Token(Token = "0x4000180")]
	Hands = 2,
	[Token(Token = "0x4000181")]
	Base = 4,
	[Token(Token = "0x4000182")]
	BodyTilt = 0x10,
	[Token(Token = "0x4000183")]
	Expressive = 0x20,
	[Token(Token = "0x4000184")]
	All = -1
}
[Token(Token = "0x200003B")]
public enum ovrAvatarMessageType
{
	[Token(Token = "0x4000186")]
	AvatarSpecification,
	[Token(Token = "0x4000187")]
	AssetLoaded,
	[Token(Token = "0x4000188")]
	Count
}
[Token(Token = "0x200003C")]
public struct ovrAvatarMessage_AvatarSpecification
{
	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public IntPtr avatarSpec;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ulong oculusUserID;
}
[Token(Token = "0x200003D")]
public struct ovrAvatarMessage_AssetLoaded
{
	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ulong assetID;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr asset;
}
[Token(Token = "0x200003E")]
public enum ovrAvatarAssetType
{
	[Token(Token = "0x400018E")]
	Mesh,
	[Token(Token = "0x400018F")]
	Texture,
	[Token(Token = "0x4000190")]
	Pose,
	[Token(Token = "0x4000191")]
	Material,
	[Token(Token = "0x4000192")]
	CombinedMesh,
	[Token(Token = "0x4000193")]
	PBSMaterial,
	[Token(Token = "0x4000194")]
	FailedLoad,
	[Token(Token = "0x4000195")]
	Count
}
[Token(Token = "0x200003F")]
public struct ovrAvatarMeshVertex
{
	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float nx;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float ny;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nz;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tx;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ty;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tz;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float tw;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float u;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float v;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public byte[] blendIndices;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float[] blendWeights;
}
[Token(Token = "0x2000040")]
public struct ovrAvatarMeshVertexV2
{
	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float nx;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float ny;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nz;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tx;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ty;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tz;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float tw;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float u;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float v;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float r;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float g;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float b;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float a;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public byte[] blendIndices;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float[] blendWeights;
}
[Token(Token = "0x2000041")]
public struct ovrAvatarBlendVertex
{
	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float nx;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float ny;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nz;

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tx;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ty;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tz;
}
[Token(Token = "0x2000042")]
public struct ovrAvatarMeshAssetData
{
	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint vertexCount;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr vertexBuffer;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public uint indexCount;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr indexBuffer;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ovrAvatarSkinnedMeshPose skinnedBindPose;
}
[Token(Token = "0x2000043")]
public struct ovrAvatarMeshAssetDataV2
{
	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint vertexCount;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr vertexBuffer;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public uint indexCount;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr indexBuffer;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ovrAvatarSkinnedMeshPose skinnedBindPose;
}
[Token(Token = "0x2000044")]
public enum ovrAvatarTextureFormat
{
	[Token(Token = "0x40001CA")]
	RGB24,
	[Token(Token = "0x40001CB")]
	DXT1,
	[Token(Token = "0x40001CC")]
	DXT5,
	[Token(Token = "0x40001CD")]
	ASTC_RGB_6x6,
	[Token(Token = "0x40001CE")]
	ASTC_RGB_6x6_MIPMAPS,
	[Token(Token = "0x40001CF")]
	Count
}
[Token(Token = "0x2000045")]
public struct ovrAvatarTextureAssetData
{
	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTextureFormat format;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public uint sizeX;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public uint sizeY;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public uint mipCount;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong textureDataSize;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr textureData;
}
[Token(Token = "0x2000046")]
public enum ovrAvatarRenderPartType
{
	[Token(Token = "0x40001D7")]
	SkinnedMeshRender,
	[Token(Token = "0x40001D8")]
	SkinnedMeshRenderPBS,
	[Token(Token = "0x40001D9")]
	ProjectorRender,
	[Token(Token = "0x40001DA")]
	SkinnedMeshRenderPBS_V2,
	[Token(Token = "0x40001DB")]
	Count
}
[Token(Token = "0x2000047")]
public enum ovrAvatarLogLevel
{
	[Token(Token = "0x40001DD")]
	Unknown,
	[Token(Token = "0x40001DE")]
	Default,
	[Token(Token = "0x40001DF")]
	Verbose,
	[Token(Token = "0x40001E0")]
	Debug,
	[Token(Token = "0x40001E1")]
	Info,
	[Token(Token = "0x40001E2")]
	Warn,
	[Token(Token = "0x40001E3")]
	Error,
	[Token(Token = "0x40001E4")]
	Fatal,
	[Token(Token = "0x40001E5")]
	Silent
}
[Token(Token = "0x2000048")]
public struct ovrAvatarTransform
{
	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 position;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Quaternion orientation;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 scale;
}
[Token(Token = "0x2000049")]
[Flags]
public enum ovrAvatarButton
{
	[Token(Token = "0x40001EA")]
	One = 1,
	[Token(Token = "0x40001EB")]
	Two = 2,
	[Token(Token = "0x40001EC")]
	Three = 4,
	[Token(Token = "0x40001ED")]
	Joystick = 8
}
[Token(Token = "0x200004A")]
[Flags]
public enum ovrAvatarTouch
{
	[Token(Token = "0x40001EF")]
	One = 1,
	[Token(Token = "0x40001F0")]
	Two = 2,
	[Token(Token = "0x40001F1")]
	Joystick = 4,
	[Token(Token = "0x40001F2")]
	ThumbRest = 8,
	[Token(Token = "0x40001F3")]
	Index = 0x10,
	[Token(Token = "0x40001F4")]
	Pointing = 0x40,
	[Token(Token = "0x40001F5")]
	ThumbUp = 0x80
}
[Token(Token = "0x200004B")]
public struct ovrAvatarHandInputState
{
	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform transform;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarButton buttonMask;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public ovrAvatarTouch touchMask;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float joystickX;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float joystickY;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float indexTrigger;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float handTrigger;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool isActive;
}
[Token(Token = "0x200004C")]
public struct ovrAvatarComponent
{
	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform transform;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public uint renderPartCount;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public IntPtr renderParts;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string name;
}
[Token(Token = "0x200004D")]
internal struct ovrAvatarComponent_Offsets
{
	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long transform;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int renderPartCount;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static int renderParts;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static int name;
}
[Token(Token = "0x200004E")]
public struct ovrAvatarBaseComponent
{
	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 basePosition;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public IntPtr renderComponent;
}
[Token(Token = "0x200004F")]
public struct ovrAvatarBodyComponent
{
	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform leftEyeTransform;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarTransform rightEyeTransform;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ovrAvatarTransform centerEyeTransform;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public IntPtr renderComponent;
}
[Token(Token = "0x2000050")]
public struct ovrAvatarBodyComponent_Offsets
{
	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long leftEyeTransform;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long rightEyeTransform;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static long centerEyeTransform;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static long renderComponent;
}
[Token(Token = "0x2000051")]
public struct ovrAvatarControllerComponent
{
	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarHandInputState inputState;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public IntPtr renderComponent;
}
[Token(Token = "0x2000052")]
public struct ovrAvatarHandComponent
{
	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarHandInputState inputState;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public IntPtr renderComponent;
}
[Token(Token = "0x2000053")]
public enum ovrAvatarMaterialLayerBlendMode
{
	[Token(Token = "0x4000215")]
	Add,
	[Token(Token = "0x4000216")]
	Multiply,
	[Token(Token = "0x4000217")]
	Count
}
[Token(Token = "0x2000054")]
public enum ovrAvatarMaterialLayerSampleMode
{
	[Token(Token = "0x4000219")]
	Color,
	[Token(Token = "0x400021A")]
	Texture,
	[Token(Token = "0x400021B")]
	TextureSingleChannel,
	[Token(Token = "0x400021C")]
	Parallax,
	[Token(Token = "0x400021D")]
	Count
}
[Token(Token = "0x2000055")]
public enum ovrAvatarMaterialMaskType
{
	[Token(Token = "0x400021F")]
	None,
	[Token(Token = "0x4000220")]
	Positional,
	[Token(Token = "0x4000221")]
	ViewReflection,
	[Token(Token = "0x4000222")]
	Fresnel,
	[Token(Token = "0x4000223")]
	Pulse,
	[Token(Token = "0x4000224")]
	Count
}
[Token(Token = "0x2000056")]
public enum ovrAvatarControllerType
{
	[Token(Token = "0x4000226")]
	Touch,
	[Token(Token = "0x4000227")]
	Malibu,
	[Token(Token = "0x4000228")]
	Go,
	[Token(Token = "0x4000229")]
	Quest,
	[Token(Token = "0x400022A")]
	Count
}
[Token(Token = "0x2000057")]
public enum ovrAvatarAssetLevelOfDetail
{
	[Token(Token = "0x400022C")]
	Lowest = 1,
	[Token(Token = "0x400022D")]
	Medium = 3,
	[Token(Token = "0x400022E")]
	Highest = 5
}
[Token(Token = "0x2000058")]
public enum ovrAvatarLookAndFeelVersion
{
	[Token(Token = "0x4000230")]
	Unknown = -1,
	[Token(Token = "0x4000231")]
	One,
	[Token(Token = "0x4000232")]
	Two
}
[Token(Token = "0x2000059")]
public struct ovrAvatarMaterialLayerState
{
	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarMaterialLayerBlendMode blendMode;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public ovrAvatarMaterialLayerSampleMode sampleMode;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarMaterialMaskType maskType;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector4 layerColor;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector4 sampleParameters;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong sampleTexture;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector4 sampleScaleOffset;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector4 maskParameters;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 maskAxis;

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xB11904", Offset = "0xB11904", VA = "0xB11904")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xB11934", Offset = "0xB11934", VA = "0xB11934", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xB11B50", Offset = "0xB11B50", VA = "0xB11B50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x200005A")]
public struct ovrAvatarMaterialState
{
	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 baseColor;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ovrAvatarMaterialMaskType baseMaskType;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Vector4 baseMaskParameters;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector4 baseMaskAxis;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public ovrAvatarMaterialLayerSampleMode sampleMode;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong alphaMaskTextureID;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector4 alphaMaskScaleOffset;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ulong normalMapTextureID;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 normalMapScaleOffset;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ulong parallaxMapTextureID;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Vector4 parallaxMapScaleOffset;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ulong roughnessMapTextureID;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Vector4 roughnessMapScaleOffset;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public uint layerCount;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public ovrAvatarMaterialLayerState[] layers;

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xB11C34", Offset = "0xB11C34", VA = "0xB11C34")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xB11C64", Offset = "0xB11C64", VA = "0xB11C64", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xB12000", Offset = "0xB12000", VA = "0xB12000", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x200005B")]
public struct ovrAvatarExpressiveParameters
{
	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 irisColor;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector4 scleraColor;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector4 lashColor;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector4 browColor;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector4 lipColor;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector4 teethColor;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector4 gumColor;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float browLashIntensity;

	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float lipSmoothness;

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xB112F4", Offset = "0xB112F4", VA = "0xB112F4")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xB11324", Offset = "0xB11324", VA = "0xB11324", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xB115B4", Offset = "0xB115B4", VA = "0xB115B4", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x200005C")]
public struct ovrAvatarPBSMaterialState
{
	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 baseColor;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong albedoTextureID;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector4 albedoMultiplier;

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ulong metallicnessTextureID;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float glossinessScale;

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong normalTextureID;

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ulong heightTextureID;

	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ulong occlusionTextureID;

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ulong emissionTextureID;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 emissionMultiplier;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ulong detailMaskTextureID;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ulong detailAlbedoTextureID;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ulong detailNormalTextureID;

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xB12168", Offset = "0xB12168", VA = "0xB12168")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xB12198", Offset = "0xB12198", VA = "0xB12198", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xB12388", Offset = "0xB12388", VA = "0xB12388", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x200005D")]
public class OvrAvatarAssetMaterial : OvrAvatarAsset
{
	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ovrAvatarMaterialState material;

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xD90DE0", Offset = "0xD90DE0", VA = "0xD90DE0")]
	public OvrAvatarAssetMaterial(ulong id, IntPtr mat)
	{
	}
}
[Token(Token = "0x200005E")]
public struct ovrAvatarSkinnedMeshPose
{
	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint jointCount;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarTransform[] jointTransform;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int[] jointParents;

	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr[] jointNames;
}
[Token(Token = "0x200005F")]
[Flags]
public enum ovrAvatarVisibilityFlags
{
	[Token(Token = "0x4000267")]
	FirstPerson = 1,
	[Token(Token = "0x4000268")]
	ThirdPerson = 2,
	[Token(Token = "0x4000269")]
	SelfOccluding = 4
}
[Token(Token = "0x2000060")]
public struct ovrAvatarRenderPart_SkinnedMeshRender
{
	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ovrAvatarMaterialState materialState;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x2000061")]
public struct ovrAvatarRenderPart_SkinnedMeshRenderPBS
{
	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong albedoTextureAssetID;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ulong surfaceTextureAssetID;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x2000062")]
public struct ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2
{
	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ovrAvatarPBSMaterialState materialState;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x2000063")]
public enum ovrAvatarHandGesture
{
	[Token(Token = "0x400027B")]
	Default,
	[Token(Token = "0x400027C")]
	GripSphere,
	[Token(Token = "0x400027D")]
	GripCube,
	[Token(Token = "0x400027E")]
	Count
}
[Token(Token = "0x2000064")]
public enum ovrAvatarBodyPartType
{
	[Token(Token = "0x4000280")]
	Body,
	[Token(Token = "0x4000281")]
	Clothing,
	[Token(Token = "0x4000282")]
	Eyewear,
	[Token(Token = "0x4000283")]
	Hair,
	[Token(Token = "0x4000284")]
	Beard,
	[Token(Token = "0x4000285")]
	Count
}
[Token(Token = "0x2000065")]
public struct ovrAvatarBlendShapeParams
{
	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint blendShapeParamCount;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float[] blendShapeParams;
}
[Token(Token = "0x2000066")]
internal struct ovrAvatarBlendShapeParams_Offsets
{
	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int blendShapeParamCount;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long blendShapeParams;
}
[Token(Token = "0x2000067")]
public struct ovrAvatarVisemes
{
	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint visemeParamCount;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float[] visemeParams;
}
[Token(Token = "0x2000068")]
internal struct ovrAvatarVisemes_Offsets
{
	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int visemeParamCount;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long visemeParams;
}
[Token(Token = "0x2000069")]
public enum ovrAvatarGazeTargetType
{
	[Token(Token = "0x400028F")]
	AvatarHead,
	[Token(Token = "0x4000290")]
	AvatarHand,
	[Token(Token = "0x4000291")]
	Object,
	[Token(Token = "0x4000292")]
	ObjectStatic,
	[Token(Token = "0x4000293")]
	Count
}
[Token(Token = "0x200006A")]
public struct ovrAvatarGazeTarget
{
	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint id;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public Vector3 worldPosition;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ovrAvatarGazeTargetType type;
}
[Token(Token = "0x200006B")]
internal struct ovrAvatarGazeTarget_Offsets
{
	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int id;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int worldPosition;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int type;
}
[Token(Token = "0x200006C")]
public struct ovrAvatarGazeTargets
{
	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint targetCount;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarGazeTarget[] targets;
}
[Token(Token = "0x200006D")]
internal struct ovrAvatarGazeTargets_Offsets
{
	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int targetCount;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long targets;
}
[Token(Token = "0x200006E")]
public enum ovrAvatarLightType
{
	[Token(Token = "0x400029F")]
	Point,
	[Token(Token = "0x40002A0")]
	Direction,
	[Token(Token = "0x40002A1")]
	Spot,
	[Token(Token = "0x40002A2")]
	Count
}
[Token(Token = "0x200006F")]
public struct ovrAvatarLight
{
	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint id;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public ovrAvatarLightType type;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float intensity;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector3 worldDirection;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 worldPosition;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float range;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float spotAngleDeg;
}
[Token(Token = "0x2000070")]
public struct ovrAvatarLights
{
	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float ambientIntensity;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public uint lightCount;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarLight[] lights;
}
[Token(Token = "0x2000071")]
public delegate void specificationCallback(IntPtr specification);
[Token(Token = "0x2000072")]
public delegate void assetLoadedCallback(OvrAvatarAsset asset);
[Token(Token = "0x2000073")]
public delegate void combinedMeshLoadedCallback(IntPtr asset);
[Token(Token = "0x2000074")]
public class OvrAvatarSDKManager : MonoBehaviour
{
	[Token(Token = "0x2000075")]
	public struct AvatarSpecRequestParams
	{
		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong _userId;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public specificationCallback _callback;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool _useCombinedMesh;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public ovrAvatarAssetLevelOfDetail _lod;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool _forceMobileTextureFormat;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ovrAvatarLookAndFeelVersion _lookVersion;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ovrAvatarLookAndFeelVersion _fallbackVersion;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool _enableExpressive;

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xF3D6A0", Offset = "0xF3D6A0", VA = "0xF3D6A0")]
		public AvatarSpecRequestParams(ulong userId, specificationCallback callback, bool useCombinedMesh, ovrAvatarAssetLevelOfDetail lod, bool forceMobileTextureFormat, ovrAvatarLookAndFeelVersion lookVersion, ovrAvatarLookAndFeelVersion fallbackVersion, bool enableExpressive)
		{
		}
	}

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static OvrAvatarSDKManager _instance;

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool initialized;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<ulong, HashSet<specificationCallback>> specificationCallbacks;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<ulong, HashSet<assetLoadedCallback>> assetLoadedCallbacks;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<IntPtr, combinedMeshLoadedCallback> combinedMeshLoadedCallbacks;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<ulong, OvrAvatarAsset> assetCache;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private OvrAvatarTextureCopyManager textureCopyManager;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ovrAvatarLogLevel LoggingLevel;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Queue<AvatarSpecRequestParams> avatarSpecificationQueue;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<int> loadingAvatars;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool avatarSpecRequestAvailable;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float lastDispatchedAvatarSpecRequestTime;

	[Token(Token = "0x40002B9")]
	private const float AVATAR_SPEC_REQUEST_TIMEOUT = 5f;

	[Token(Token = "0x1700000C")]
	public static OvrAvatarSDKManager Instance
	{
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x8406FC", Offset = "0x8406FC", VA = "0x8406FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x840E4C", Offset = "0x840E4C", VA = "0x840E4C")]
	private bool Initialize()
	{
		return default(bool);
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x84119C", Offset = "0x84119C", VA = "0x84119C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x84120C", Offset = "0x84120C", VA = "0x84120C")]
	private void Update()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x841BEC", Offset = "0x841BEC", VA = "0x841BEC")]
	public bool IsAvatarSpecWaiting()
	{
		return default(bool);
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x841C40", Offset = "0x841C40", VA = "0x841C40")]
	public bool IsAvatarLoading()
	{
		return default(bool);
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x841C94", Offset = "0x841C94", VA = "0x841C94")]
	public void AddLoadingAvatar(int gameobjectID)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x841CF8", Offset = "0x841CF8", VA = "0x841CF8")]
	public void RemoveLoadingAvatar(int gameobjectID)
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x841D5C", Offset = "0x841D5C", VA = "0x841D5C")]
	public void RequestAvatarSpecification(AvatarSpecRequestParams avatarSpecRequest)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x8419EC", Offset = "0x8419EC", VA = "0x8419EC")]
	private void DispatchAvatarSpecificationRequest(AvatarSpecRequestParams avatarSpecRequest)
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x841E38", Offset = "0x841E38", VA = "0x841E38")]
	public void BeginLoadingAsset(ulong assetId, ovrAvatarAssetLevelOfDetail lod, assetLoadedCallback callback)
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x841F8C", Offset = "0x841F8C", VA = "0x841F8C")]
	public void RegisterCombinedMeshCallback(IntPtr sdkAvatar, combinedMeshLoadedCallback callback)
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x8408F4", Offset = "0x8408F4", VA = "0x8408F4")]
	public OvrAvatarAsset GetAsset(ulong assetId)
	{
		return null;
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x842080", Offset = "0x842080", VA = "0x842080")]
	public void DeleteAssetFromCache(ulong assetId)
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x841150", Offset = "0x841150", VA = "0x841150")]
	public string GetAppId()
	{
		return null;
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x842160", Offset = "0x842160", VA = "0x842160")]
	public OvrAvatarTextureCopyManager GetTextureCopyManager()
	{
		return null;
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x8421E0", Offset = "0x8421E0", VA = "0x8421E0")]
	public OvrAvatarSDKManager()
	{
	}
}
[Token(Token = "0x2000076")]
public sealed class OvrAvatarSettings : ScriptableObject
{
	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static OvrAvatarSettings instance;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string ovrAppID;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string ovrGearAppID;

	[Token(Token = "0x1700000D")]
	public static string AppID
	{
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x842120", Offset = "0x842120", VA = "0x842120")]
		get
		{
			return null;
		}
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x842350", Offset = "0x842350", VA = "0x842350")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public static string MobileAppID
	{
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x842140", Offset = "0x842140", VA = "0x842140")]
		get
		{
			return null;
		}
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x842380", Offset = "0x842380", VA = "0x842380")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public static OvrAvatarSettings Instance
	{
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x8421F8", Offset = "0x8421F8", VA = "0x8421F8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x8423B0", Offset = "0x8423B0", VA = "0x8423B0")]
		set
		{
		}
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x842404", Offset = "0x842404", VA = "0x842404")]
	public OvrAvatarSettings()
	{
	}
}
[Token(Token = "0x2000077")]
public class OvrAvatarSkinnedMeshRenderComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Shader surface;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Shader surfaceSelfOccluding;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool previouslyActive;

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x843F7C", Offset = "0x843F7C", VA = "0x843F7C")]
	internal void Initialize(ovrAvatarRenderPart_SkinnedMeshRender skinnedMeshRender, Shader surface, Shader surfaceSelfOccluding, int thirdPersonLayer, int firstPersonLayer)
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x844270", Offset = "0x844270", VA = "0x844270")]
	public void UpdateSkinnedMeshRender(OvrAvatarComponent component, OvrAvatar avatar, IntPtr renderPart)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x844108", Offset = "0x844108", VA = "0x844108")]
	private void UpdateMeshMaterial(ovrAvatarVisibilityFlags visibilityMask, SkinnedMeshRenderer rootMesh)
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x8444B0", Offset = "0x8444B0", VA = "0x8444B0")]
	public OvrAvatarSkinnedMeshRenderComponent()
	{
	}
}
[Token(Token = "0x2000078")]
public class OvrAvatarSkinnedMeshRenderPBSComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool isMaterialInitilized;

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x8444C0", Offset = "0x8444C0", VA = "0x8444C0")]
	internal void Initialize(ovrAvatarRenderPart_SkinnedMeshRenderPBS skinnedMeshRenderPBS, Shader shader, int thirdPersonLayer, int firstPersonLayer)
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x84461C", Offset = "0x84461C", VA = "0x84461C")]
	internal void UpdateSkinnedMeshRenderPBS(OvrAvatar avatar, IntPtr renderPart, Material mat)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x8447F4", Offset = "0x8447F4", VA = "0x8447F4")]
	public OvrAvatarSkinnedMeshRenderPBSComponent()
	{
	}
}
[Token(Token = "0x2000079")]
public class OvrAvatarSkinnedMeshPBSV2RenderComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private OvrAvatarMaterialManager avatarMaterialManager;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool previouslyActive;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private bool isCombinedMaterial;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private ovrAvatarExpressiveParameters ExpressiveParameters;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private bool EnableExpressive;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private int blendShapeCount;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private ovrAvatarBlendShapeParams blendShapeParams;

	[Token(Token = "0x40002D0")]
	private const string MAIN_MATERIAL_NAME = "main_material";

	[Token(Token = "0x40002D1")]
	private const string EYE_MATERIAL_NAME = "eye_material";

	[Token(Token = "0x40002D2")]
	private const string DEFAULT_MATERIAL_NAME = "_material";

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x842470", Offset = "0x842470", VA = "0x842470")]
	internal void Initialize(IntPtr renderPart, ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 skinnedMeshRender, OvrAvatarMaterialManager materialManager, int thirdPersonLayer, int firstPersonLayer, bool combinedMesh, ovrAvatarAssetLevelOfDetail lod, bool assignExpressiveParams, OvrAvatar avatar, bool isControllerModel)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x8434A8", Offset = "0x8434A8", VA = "0x8434A8")]
	public void UpdateSkinnedMeshRender(OvrAvatarComponent component, OvrAvatar avatar, IntPtr renderPart)
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x8436E4", Offset = "0x8436E4", VA = "0x8436E4")]
	private void InitializeSingleComponentMaterial(IntPtr renderPart, int lodIndex)
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x842BA8", Offset = "0x842BA8", VA = "0x842BA8")]
	private void InitializeCombinedMaterial(IntPtr renderPart, int lodIndex)
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x8428CC", Offset = "0x8428CC", VA = "0x8428CC")]
	private void SetMaterialTransparent(Material mat)
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x842A30", Offset = "0x842A30", VA = "0x842A30")]
	private void SetMaterialOpaque(Material mat)
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x843F6C", Offset = "0x843F6C", VA = "0x843F6C")]
	public OvrAvatarSkinnedMeshPBSV2RenderComponent()
	{
	}
}
[Token(Token = "0x200007A")]
public class OvrAvatarTextureCopyManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200007B")]
	public struct FallbackTextureSet
	{
		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool Initialized;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture2D DiffuseRoughness;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Texture2D Normal;
	}

	[Token(Token = "0x200007C")]
	private struct CopyTextureParams
	{
		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Texture Src;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture Dst;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Mip;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int SrcSize;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int DstElement;

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xF3DD9C", Offset = "0xF3DD9C", VA = "0xF3DD9C")]
		public CopyTextureParams(Texture src, Texture dst, int mip, int srcSize, int dstElement)
		{
		}
	}

	[Token(Token = "0x200007D")]
	public struct TextureSet
	{
		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Dictionary<ulong, bool> TextureIDSingleMeshPair;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool IsProcessed;

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xF3DDF8", Offset = "0xF3DDF8", VA = "0xF3DDF8")]
		public TextureSet(Dictionary<ulong, bool> textureIDSingleMeshPair, bool isProcessed)
		{
		}
	}

	[Token(Token = "0x200007E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CA20", Offset = "0x58CA20")]
	private sealed class <DeleteTextureSetCoroutine>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextureSet textureSetToDelete;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public OvrAvatarTextureCopyManager <>4__this;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int gameobjectID;

		[Token(Token = "0x17000010")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0xF3DD4C", Offset = "0xF3DD4C", VA = "0xF3DD4C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0xF3DD94", Offset = "0xF3DD94", VA = "0xF3DD94", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xF3D71C", Offset = "0xF3D71C", VA = "0xF3D71C")]
		[DebuggerHidden]
		public <DeleteTextureSetCoroutine>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xF3D748", Offset = "0xF3D748", VA = "0xF3D748", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xF3D74C", Offset = "0xF3D74C", VA = "0xF3D74C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xF3DD54", Offset = "0xF3DD54", VA = "0xF3DD54", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FallbackTextureSet[] FallbackTextureSets;

	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Queue<CopyTextureParams> texturesToCopy;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<int, TextureSet> textureSets;

	[Token(Token = "0x40002D6")]
	private const int TEXTURES_TO_COPY_QUEUE_CAPACITY = 256;

	[Token(Token = "0x40002D7")]
	private const int COPIES_PER_FRAME = 8;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly string[] FALLBACK_TEXTURE_PATHS_DIFFUSE_ROUGHNESS;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly string[] FALLBACK_TEXTURE_PATHS_NORMAL;

	[Token(Token = "0x40002DA")]
	private const string PATH_HIGHEST_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_2048";

	[Token(Token = "0x40002DB")]
	private const string PATH_MEDIUM_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_1024";

	[Token(Token = "0x40002DC")]
	private const string PATH_LOWEST_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_256";

	[Token(Token = "0x40002DD")]
	private const string PATH_HIGHEST_NORMAL = "FallbackTextures/fallback_normal_2048";

	[Token(Token = "0x40002DE")]
	private const string PATH_MEDIUM_NORMAL = "FallbackTextures/fallback_normal_1024";

	[Token(Token = "0x40002DF")]
	private const string PATH_LOWEST_NORMAL = "FallbackTextures/fallback_normal_256";

	[Token(Token = "0x40002E0")]
	private const int GPU_TEXTURE_COPY_WAIT_TIME = 10;

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x844F1C", Offset = "0x844F1C", VA = "0x844F1C")]
	public OvrAvatarTextureCopyManager()
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x8453FC", Offset = "0x8453FC", VA = "0x8453FC")]
	public void Update()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x8455FC", Offset = "0x8455FC", VA = "0x8455FC")]
	public int GetTextureCount()
	{
		return default(int);
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x845648", Offset = "0x845648", VA = "0x845648")]
	public void CopyTexture(Texture src, Texture dst, int mipLevel, int mipSize, int dstElement, bool useQueue = true)
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x845570", Offset = "0x845570", VA = "0x845570")]
	private void CopyTexture(CopyTextureParams copyTextureParams)
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x8457F4", Offset = "0x8457F4", VA = "0x8457F4")]
	public void AddTextureIDToTextureSet(int gameobjectID, ulong textureID, bool isSingleMesh)
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x8459FC", Offset = "0x8459FC", VA = "0x8459FC")]
	public void DeleteTextureSet(int gameobjectID)
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x845AA0", Offset = "0x845AA0", VA = "0x845AA0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x591130", Offset = "0x591130")]
	private IEnumerator DeleteTextureSetCoroutine(TextureSet textureSetToDelete, int gameobjectID)
	{
		return null;
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x841DEC", Offset = "0x841DEC", VA = "0x841DEC")]
	public void CheckFallbackTextureSet(ovrAvatarAssetLevelOfDetail lod)
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x845B4C", Offset = "0x845B4C", VA = "0x845B4C")]
	private void InitFallbackTextureSet(ovrAvatarAssetLevelOfDetail lod)
	{
	}
}
[Token(Token = "0x200007F")]
public class OvrAvatarTouchController : OvrAvatarComponent
{
	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool isLeftHand;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ovrAvatarControllerComponent component;

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x845CC4", Offset = "0x845CC4", VA = "0x845CC4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x845E38", Offset = "0x845E38", VA = "0x845E38")]
	public OvrAvatarTouchController()
	{
	}
}
[Token(Token = "0x2000080")]
public class DebugUIBuilder : MonoBehaviour
{
	[Token(Token = "0x2000081")]
	public delegate void OnClick();

	[Token(Token = "0x2000082")]
	public delegate void OnToggleValueChange(Toggle t);

	[Token(Token = "0x2000083")]
	public delegate void OnSlider(float f);

	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CA30", Offset = "0x58CA30")]
	private sealed class <>c__DisplayClass41_0
	{
		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnClick handler;

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xF3770C", Offset = "0xF3770C", VA = "0xF3770C")]
		public <>c__DisplayClass41_0()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xF37714", Offset = "0xF37714", VA = "0xF37714")]
		internal void <AddButton>b__0()
		{
		}
	}

	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CA40", Offset = "0x58CA40")]
	private sealed class <>c__DisplayClass43_0
	{
		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnSlider onValueChanged;

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xF37938", Offset = "0xF37938", VA = "0xF37938")]
		public <>c__DisplayClass43_0()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xF37940", Offset = "0xF37940", VA = "0xF37940")]
		internal void <AddSlider>b__0(float f)
		{
		}
	}

	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CA50", Offset = "0x58CA50")]
	private sealed class <>c__DisplayClass45_0
	{
		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange onValueChanged;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle t;

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xF37B8C", Offset = "0xF37B8C", VA = "0xF37B8C")]
		public <>c__DisplayClass45_0()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xF37B94", Offset = "0xF37B94", VA = "0xF37B94")]
		internal void <AddToggle>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CA60", Offset = "0x58CA60")]
	private sealed class <>c__DisplayClass46_0
	{
		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange onValueChanged;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle t;

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xF37F28", Offset = "0xF37F28", VA = "0xF37F28")]
		public <>c__DisplayClass46_0()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xF37F30", Offset = "0xF37F30", VA = "0xF37F30")]
		internal void <AddToggle>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CA70", Offset = "0x58CA70")]
	private sealed class <>c__DisplayClass47_0
	{
		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange handler;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle tb;

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xF37F50", Offset = "0xF37F50", VA = "0xF37F50")]
		public <>c__DisplayClass47_0()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xF37F58", Offset = "0xF37F58", VA = "0xF37F58")]
		internal void <AddRadio>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x40002F2")]
	public const int DEBUG_PANE_CENTER = 0;

	[Token(Token = "0x40002F3")]
	public const int DEBUG_PANE_RIGHT = 1;

	[Token(Token = "0x40002F4")]
	public const int DEBUG_PANE_LEFT = 2;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform buttonPrefab;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform[] additionalButtonPrefab;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform labelPrefab;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectTransform sliderPrefab;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform dividerPrefab;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RectTransform togglePrefab;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private RectTransform radioPrefab;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject uiHelpersToInstantiate;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Transform[] targetContentPanels;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool[] reEnable;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private List<GameObject> toEnable;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private List<GameObject> toDisable;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static DebugUIBuilder instance;

	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float elementSpacing;

	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float marginH;

	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float marginV;

	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector2[] insertPositions;

	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<RectTransform>[] insertedElements;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Vector3 menuOffset;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private OVRCameraRig rig;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Dictionary<string, ToggleGroup> radioGroups;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private LaserPointer lp;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private LineRenderer lr;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public LaserPointer.LaserBeamBehavior laserBeamBehavior;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public bool isHorizontal;

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD5")]
	public bool usePanelCentricRelayout;

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x865FD4", Offset = "0x865FD4", VA = "0x865FD4")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x866508", Offset = "0x866508", VA = "0x866508")]
	public void Show()
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x8668D0", Offset = "0x8668D0", VA = "0x8668D0")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x866A8C", Offset = "0x866A8C", VA = "0x866A8C")]
	private void StackedRelayout()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x866CCC", Offset = "0x866CCC", VA = "0x866CCC")]
	private void PanelCentricRelayout()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x8668C0", Offset = "0x8668C0", VA = "0x8668C0")]
	private void Relayout()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x866FFC", Offset = "0x866FFC", VA = "0x866FFC")]
	private void AddRect(RectTransform r, int targetCanvas)
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x86731C", Offset = "0x86731C", VA = "0x86731C")]
	public RectTransform AddButton(string label, [Optional] OnClick handler, int buttonIndex = -1, int targetCanvas = 0, bool highResolutionText = false)
	{
		return null;
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x8676E4", Offset = "0x8676E4", VA = "0x8676E4")]
	public RectTransform AddLabel(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x8677E8", Offset = "0x8677E8", VA = "0x8677E8")]
	public RectTransform AddSlider(string label, float min, float max, OnSlider onValueChanged, bool wholeNumbersOnly = false, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x8679CC", Offset = "0x8679CC", VA = "0x8679CC")]
	public RectTransform AddDivider(int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x867A70", Offset = "0x867A70", VA = "0x867A70")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x867C60", Offset = "0x867C60", VA = "0x867C60")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, bool defaultValue, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x867E68", Offset = "0x867E68", VA = "0x867E68")]
	public RectTransform AddRadio(string label, string group, OnToggleValueChange handler, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x86816C", Offset = "0x86816C", VA = "0x86816C")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x868268", Offset = "0x868268", VA = "0x868268")]
	public void ToggleLaserPointer(bool isOn)
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x868314", Offset = "0x868314", VA = "0x868314")]
	public DebugUIBuilder()
	{
	}
}
[Token(Token = "0x2000089")]
public class HandedInputSelector : MonoBehaviour
{
	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRCameraRig m_CameraRig;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRInputModule m_InputModule;

	[Token(Token = "0x600019C")]
	[Address(RVA = "0xB4D628", Offset = "0xB4D628", VA = "0xB4D628")]
	private void Start()
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0xB4D6D8", Offset = "0xB4D6D8", VA = "0xB4D6D8")]
	private void Update()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0xB4D798", Offset = "0xB4D798", VA = "0xB4D798")]
	private void SetActiveController(OVRInput.Controller c)
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0xB4D7D4", Offset = "0xB4D7D4", VA = "0xB4D7D4")]
	public HandedInputSelector()
	{
	}
}
[Token(Token = "0x200008A")]
public class LaserPointer : OVRCursor
{
	[Token(Token = "0x200008B")]
	public enum LaserBeamBehavior
	{
		[Token(Token = "0x4000324")]
		On,
		[Token(Token = "0x4000325")]
		Off,
		[Token(Token = "0x4000326")]
		OnWhenHitTarget
	}

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject cursorVisual;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float maxLength;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private LaserBeamBehavior _laserBeamBehavior;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_restoreOnInputAcquired;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 _startPoint;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 _forward;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 _endPoint;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _hitTarget;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x17000012")]
	public LaserBeamBehavior laserBeamBehavior
	{
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xB52A84", Offset = "0xB52A84", VA = "0xB52A84")]
		get
		{
			return default(LaserBeamBehavior);
		}
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xB52A40", Offset = "0xB52A40", VA = "0xB52A40")]
		set
		{
		}
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0xB52A8C", Offset = "0xB52A8C", VA = "0xB52A8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0xB52AE8", Offset = "0xB52AE8", VA = "0xB52AE8")]
	private void Start()
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0xB52C2C", Offset = "0xB52C2C", VA = "0xB52C2C", Slot = "5")]
	public override void SetCursorStartDest(Vector3 start, Vector3 dest, Vector3 normal)
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0xB52C48", Offset = "0xB52C48", VA = "0xB52C48", Slot = "4")]
	public override void SetCursorRay(Transform t)
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0xB52C9C", Offset = "0xB52C9C", VA = "0xB52C9C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0xB52E58", Offset = "0xB52E58", VA = "0xB52E58")]
	private void UpdateLaserBeam(Vector3 start, Vector3 end)
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0xB52F6C", Offset = "0xB52F6C", VA = "0xB52F6C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0xB52FFC", Offset = "0xB52FFC", VA = "0xB52FFC")]
	public void OnInputFocusLost()
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0xB530C8", Offset = "0xB530C8", VA = "0xB530C8")]
	public void OnInputFocusAcquired()
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0xB5317C", Offset = "0xB5317C", VA = "0xB5317C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0xB53268", Offset = "0xB53268", VA = "0xB53268")]
	public LaserPointer()
	{
	}
}
[Token(Token = "0x200008C")]
public class CharacterCameraConstraint : MonoBehaviour
{
	[Token(Token = "0x4000327")]
	private const float FADE_RAY_LENGTH = 0.25f;

	[Token(Token = "0x4000328")]
	private const float FADE_OVERLAP_MAXIMUM = 0.1f;

	[Token(Token = "0x4000329")]
	private const float FADE_AMOUNT_MAXIMUM = 1f;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58EA4C", Offset = "0x58EA4C")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58EA84", Offset = "0x58EA84")]
	public LayerMask CollideLayers;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58EABC", Offset = "0x58EABC")]
	public float HeightOffset;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58EAF4", Offset = "0x58EAF4")]
	public float MinimumHeight;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58EB2C", Offset = "0x58EB2C")]
	public float MaximumHeight;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CapsuleCollider _character;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SimpleCapsuleWithStickMovement _simplePlayerController;

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x85FC98", Offset = "0x85FC98", VA = "0x85FC98")]
	private CharacterCameraConstraint()
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x85FCA0", Offset = "0x85FCA0", VA = "0x85FCA0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x85FD2C", Offset = "0x85FD2C", VA = "0x85FD2C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x85FDC0", Offset = "0x85FDC0", VA = "0x85FDC0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x85FE54", Offset = "0x85FE54", VA = "0x85FE54")]
	private void CameraUpdate()
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x860180", Offset = "0x860180", VA = "0x860180")]
	private bool CheckCameraOverlapped()
	{
		return default(bool);
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x8603B0", Offset = "0x8603B0", VA = "0x8603B0")]
	private bool CheckCameraNearClipping(out float result)
	{
		return default(bool);
	}
}
[Token(Token = "0x200008D")]
public class LocomotionController : MonoBehaviour
{
	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CapsuleCollider CharacterController;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimpleCapsuleWithStickMovement PlayerController;

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0xFBD5FC", Offset = "0xFBD5FC", VA = "0xFBD5FC")]
	private void Start()
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0xFBD6C8", Offset = "0xFBD6C8", VA = "0xFBD6C8")]
	public LocomotionController()
	{
	}
}
[Token(Token = "0x200008E")]
public class LocomotionTeleport : MonoBehaviour
{
	[Token(Token = "0x200008F")]
	public enum States
	{
		[Token(Token = "0x4000357")]
		Ready,
		[Token(Token = "0x4000358")]
		Aim,
		[Token(Token = "0x4000359")]
		CancelAim,
		[Token(Token = "0x400035A")]
		PreTeleport,
		[Token(Token = "0x400035B")]
		CancelTeleport,
		[Token(Token = "0x400035C")]
		Teleporting,
		[Token(Token = "0x400035D")]
		PostTeleport
	}

	[Token(Token = "0x2000090")]
	public enum TeleportIntentions
	{
		[Token(Token = "0x400035F")]
		None,
		[Token(Token = "0x4000360")]
		Aim,
		[Token(Token = "0x4000361")]
		PreTeleport,
		[Token(Token = "0x4000362")]
		Teleport
	}

	[Token(Token = "0x2000091")]
	public enum AimCollisionTypes
	{
		[Token(Token = "0x4000364")]
		Point,
		[Token(Token = "0x4000365")]
		Sphere,
		[Token(Token = "0x4000366")]
		Capsule
	}

	[Token(Token = "0x2000092")]
	public class AimData
	{
		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RaycastHit TargetHitInfo;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool TargetValid;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3? Destination;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float Radius;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58EF44", Offset = "0x58EF44")]
		private List<Vector3> <Points>k__BackingField;

		[Token(Token = "0x17000016")]
		public List<Vector3> Points
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0xF3BE24", Offset = "0xF3BE24", VA = "0xF3BE24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591658", Offset = "0x591658")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0xF3BE2C", Offset = "0xF3BE2C", VA = "0xF3BE2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591668", Offset = "0x591668")]
			private set
			{
			}
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xF3BDA0", Offset = "0xF3BDA0", VA = "0xF3BDA0")]
		public AimData()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xF3BE34", Offset = "0xF3BE34", VA = "0xF3BE34")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000093")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CA80", Offset = "0x58CA80")]
	private sealed class <ReadyStateCoroutine>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000017")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0xF3BBEC", Offset = "0xF3BBEC", VA = "0xF3BBEC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0xF3BC34", Offset = "0xF3BC34", VA = "0xF3BC34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xF3BAB0", Offset = "0xF3BAB0", VA = "0xF3BAB0")]
		[DebuggerHidden]
		public <ReadyStateCoroutine>d__52(int <>1__state)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xF3BADC", Offset = "0xF3BADC", VA = "0xF3BADC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xF3BAE0", Offset = "0xF3BAE0", VA = "0xF3BAE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xF3BBF4", Offset = "0xF3BBF4", VA = "0xF3BBF4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CA90", Offset = "0x58CA90")]
	private sealed class <AimStateCoroutine>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000019")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0xF3B51C", Offset = "0xF3B51C", VA = "0xF3B51C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0xF3B564", Offset = "0xF3B564", VA = "0xF3B564", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xF3B394", Offset = "0xF3B394", VA = "0xF3B394")]
		[DebuggerHidden]
		public <AimStateCoroutine>d__64(int <>1__state)
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xF3B3C0", Offset = "0xF3B3C0", VA = "0xF3B3C0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xF3B3C4", Offset = "0xF3B3C4", VA = "0xF3B3C4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xF3B524", Offset = "0xF3B524", VA = "0xF3B524", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000095")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CAA0", Offset = "0x58CAA0")]
	private sealed class <CancelAimStateCoroutine>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700001B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0xF3B648", Offset = "0xF3B648", VA = "0xF3B648", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0xF3B690", Offset = "0xF3B690", VA = "0xF3B690", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xF3B56C", Offset = "0xF3B56C", VA = "0xF3B56C")]
		[DebuggerHidden]
		public <CancelAimStateCoroutine>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xF3B598", Offset = "0xF3B598", VA = "0xF3B598", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xF3B59C", Offset = "0xF3B59C", VA = "0xF3B59C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xF3B650", Offset = "0xF3B650", VA = "0xF3B650", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CAB0", Offset = "0x58CAB0")]
	private sealed class <PreTeleportStateCoroutine>d__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700001D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0xF3BA60", Offset = "0xF3BA60", VA = "0xF3BA60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000205")]
			[Address(RVA = "0xF3BAA8", Offset = "0xF3BAA8", VA = "0xF3BAA8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xF3B944", Offset = "0xF3B944", VA = "0xF3B944")]
		[DebuggerHidden]
		public <PreTeleportStateCoroutine>d__72(int <>1__state)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xF3B970", Offset = "0xF3B970", VA = "0xF3B970", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xF3B974", Offset = "0xF3B974", VA = "0xF3B974", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xF3BA68", Offset = "0xF3BA68", VA = "0xF3BA68", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CAC0", Offset = "0x58CAC0")]
	private sealed class <CancelTeleportStateCoroutine>d__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700001F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000209")]
			[Address(RVA = "0xF3B774", Offset = "0xF3B774", VA = "0xF3B774", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600020B")]
			[Address(RVA = "0xF3B7BC", Offset = "0xF3B7BC", VA = "0xF3B7BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xF3B698", Offset = "0xF3B698", VA = "0xF3B698")]
		[DebuggerHidden]
		public <CancelTeleportStateCoroutine>d__76(int <>1__state)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xF3B6C4", Offset = "0xF3B6C4", VA = "0xF3B6C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xF3B6C8", Offset = "0xF3B6C8", VA = "0xF3B6C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xF3B77C", Offset = "0xF3B77C", VA = "0xF3B77C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CAD0", Offset = "0x58CAD0")]
	private sealed class <TeleportingStateCoroutine>d__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000021")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600020F")]
			[Address(RVA = "0xF3BD50", Offset = "0xF3BD50", VA = "0xF3BD50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000211")]
			[Address(RVA = "0xF3BD98", Offset = "0xF3BD98", VA = "0xF3BD98", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xF3BC3C", Offset = "0xF3BC3C", VA = "0xF3BC3C")]
		[DebuggerHidden]
		public <TeleportingStateCoroutine>d__80(int <>1__state)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xF3BC68", Offset = "0xF3BC68", VA = "0xF3BC68", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xF3BC6C", Offset = "0xF3BC6C", VA = "0xF3BC6C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xF3BD58", Offset = "0xF3BD58", VA = "0xF3BD58", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000099")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CAE0", Offset = "0x58CAE0")]
	private sealed class <PostTeleportStateCoroutine>d__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000023")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000215")]
			[Address(RVA = "0xF3B8F4", Offset = "0xF3B8F4", VA = "0xF3B8F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000217")]
			[Address(RVA = "0xF3B93C", Offset = "0xF3B93C", VA = "0xF3B93C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xF3B7C4", Offset = "0xF3B7C4", VA = "0xF3B7C4")]
		[DebuggerHidden]
		public <PostTeleportStateCoroutine>d__84(int <>1__state)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xF3B7F0", Offset = "0xF3B7F0", VA = "0xF3B7F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xF3B7F4", Offset = "0xF3B7F4", VA = "0xF3B7F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xF3B8FC", Offset = "0xF3B8FC", VA = "0xF3B8FC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58EB64", Offset = "0x58EB64")]
	public bool EnableMovementDuringReady;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58EB9C", Offset = "0x58EB9C")]
	public bool EnableMovementDuringAim;

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58EBD4", Offset = "0x58EBD4")]
	public bool EnableMovementDuringPreTeleport;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58EC0C", Offset = "0x58EC0C")]
	public bool EnableMovementDuringPostTeleport;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58EC44", Offset = "0x58EC44")]
	public bool EnableRotationDuringReady;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58EC7C", Offset = "0x58EC7C")]
	public bool EnableRotationDuringAim;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58ECB4", Offset = "0x58ECB4")]
	public bool EnableRotationDuringPreTeleport;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58ECEC", Offset = "0x58ECEC")]
	public bool EnableRotationDuringPostTeleport;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58ED24", Offset = "0x58ED24")]
	private States <CurrentState>k__BackingField;

	[NonSerialized]
	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TeleportAimHandler AimHandler;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58ED34", Offset = "0x58ED34")]
	public TeleportDestination TeleportDestinationPrefab;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58ED6C", Offset = "0x58ED6C")]
	public int TeleportDestinationLayer;

	[NonSerialized]
	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TeleportInputHandler InputHandler;

	[NonSerialized]
	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TeleportIntentions CurrentIntention;

	[NonSerialized]
	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool IsPreTeleportRequested;

	[NonSerialized]
	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool IsTransitioning;

	[NonSerialized]
	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
	public bool IsPostTeleportRequested;

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private TeleportDestination _teleportDestination;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58EDB4", Offset = "0x58EDB4")]
	private LocomotionController <LocomotionController>k__BackingField;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58EDC4", Offset = "0x58EDC4")]
	public AimCollisionTypes AimCollisionType;

	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58EDFC", Offset = "0x58EDFC")]
	public bool UseCharacterCollisionData;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58EE34", Offset = "0x58EE34")]
	public float AimCollisionRadius;

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58EE6C", Offset = "0x58EE6C")]
	public float AimCollisionHeight;

	[Token(Token = "0x17000013")]
	public States CurrentState
	{
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xFBE1C4", Offset = "0xFBE1C4", VA = "0xFBE1C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5911E0", Offset = "0x5911E0")]
		get
		{
			return default(States);
		}
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xFBE1CC", Offset = "0xFBE1CC", VA = "0xFBE1CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5911F0", Offset = "0x5911F0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public Quaternion DestinationRotation
	{
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xFBE3F0", Offset = "0xFBE3F0", VA = "0xFBE3F0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x17000015")]
	public LocomotionController LocomotionController
	{
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xFBE418", Offset = "0xFBE418", VA = "0xFBE418")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591220", Offset = "0x591220")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xFBE420", Offset = "0xFBE420", VA = "0xFBE420")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591230", Offset = "0x591230")]
		private set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public event Action<bool, Vector3?, Quaternion?, Quaternion?> UpdateTeleportDestination
	{
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xFBE1D4", Offset = "0xFBE1D4", VA = "0xFBE1D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591200", Offset = "0x591200")]
		add
		{
		}
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xFBE274", Offset = "0xFBE274", VA = "0xFBE274")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591210", Offset = "0x591210")]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event Action EnterStateReady
	{
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xFBEA60", Offset = "0xFBEA60", VA = "0xFBEA60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591278", Offset = "0x591278")]
		add
		{
		}
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xFBEB00", Offset = "0xFBEB00", VA = "0xFBEB00")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591288", Offset = "0x591288")]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event Action EnterStateAim
	{
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xFBEBA0", Offset = "0xFBEBA0", VA = "0xFBEBA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5912F8", Offset = "0x5912F8")]
		add
		{
		}
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xFBEC40", Offset = "0xFBEC40", VA = "0xFBEC40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591308", Offset = "0x591308")]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public event Action<AimData> UpdateAimData
	{
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xFBECE0", Offset = "0xFBECE0", VA = "0xFBECE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591318", Offset = "0x591318")]
		add
		{
		}
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xFBED80", Offset = "0xFBED80", VA = "0xFBED80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591328", Offset = "0x591328")]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public event Action ExitStateAim
	{
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xFBEE90", Offset = "0xFBEE90", VA = "0xFBEE90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591338", Offset = "0x591338")]
		add
		{
		}
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xFBEF30", Offset = "0xFBEF30", VA = "0xFBEF30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591348", Offset = "0x591348")]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public event Action EnterStateCancelAim
	{
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xFBF048", Offset = "0xFBF048", VA = "0xFBF048")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5913B8", Offset = "0x5913B8")]
		add
		{
		}
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xFBF0E8", Offset = "0xFBF0E8", VA = "0xFBF0E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5913C8", Offset = "0x5913C8")]
		remove
		{
		}
	}

	[Token(Token = "0x14000007")]
	public event Action EnterStatePreTeleport
	{
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xFBF200", Offset = "0xFBF200", VA = "0xFBF200")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591438", Offset = "0x591438")]
		add
		{
		}
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xFBF2A0", Offset = "0xFBF2A0", VA = "0xFBF2A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591448", Offset = "0x591448")]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public event Action EnterStateCancelTeleport
	{
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xFBF3B8", Offset = "0xFBF3B8", VA = "0xFBF3B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5914B8", Offset = "0x5914B8")]
		add
		{
		}
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xFBF458", Offset = "0xFBF458", VA = "0xFBF458")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5914C8", Offset = "0x5914C8")]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public event Action EnterStateTeleporting
	{
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xFBF570", Offset = "0xFBF570", VA = "0xFBF570")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591538", Offset = "0x591538")]
		add
		{
		}
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xFBF610", Offset = "0xFBF610", VA = "0xFBF610")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591548", Offset = "0x591548")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public event Action EnterStatePostTeleport
	{
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xFBF728", Offset = "0xFBF728", VA = "0xFBF728")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5915B8", Offset = "0x5915B8")]
		add
		{
		}
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xFBF7C8", Offset = "0xFBF7C8", VA = "0xFBF7C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5915C8", Offset = "0x5915C8")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public event Action<Transform, Vector3, Quaternion> Teleported
	{
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xFBF8E0", Offset = "0xFBF8E0", VA = "0xFBF8E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591638", Offset = "0x591638")]
		add
		{
		}
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xFBF980", Offset = "0xFBF980", VA = "0xFBF980")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591648", Offset = "0x591648")]
		remove
		{
		}
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0xFBDE70", Offset = "0xFBDE70", VA = "0xFBDE70")]
	public void EnableMovement(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0xFBDE94", Offset = "0xFBDE94", VA = "0xFBDE94")]
	public void EnableRotation(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0xFBE314", Offset = "0xFBE314", VA = "0xFBE314")]
	public void OnUpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0xFBE428", Offset = "0xFBE428", VA = "0xFBE428")]
	public bool AimCollisionTest(Vector3 start, Vector3 end, LayerMask aimCollisionLayerMask, out RaycastHit hitInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0xFBE674", Offset = "0xFBE674", VA = "0xFBE674")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x591240", Offset = "0x591240")]
	protected void LogState(string msg)
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0xFBE728", Offset = "0xFBE728", VA = "0xFBE728")]
	protected void CreateNewTeleportDestination()
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0xFBE828", Offset = "0xFBE828", VA = "0xFBE828")]
	private void DeactivateDestination()
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0xFBE844", Offset = "0xFBE844", VA = "0xFBE844")]
	public void RecycleTeleportDestination(TeleportDestination oldDestination)
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0xFBE908", Offset = "0xFBE908", VA = "0xFBE908")]
	private void EnableMotion(bool enableLinear, bool enableRotation)
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0xFBE94C", Offset = "0xFBE94C", VA = "0xFBE94C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0xFBE9B0", Offset = "0xFBE9B0", VA = "0xFBE9B0", Slot = "4")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0xFBEA58", Offset = "0xFBEA58", VA = "0xFBEA58", Slot = "5")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0xFBE9E0", Offset = "0xFBE9E0", VA = "0xFBE9E0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x591298", Offset = "0x591298")]
	protected IEnumerator ReadyStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0xFBEE20", Offset = "0xFBEE20", VA = "0xFBEE20")]
	public void OnUpdateAimData(AimData aimData)
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0xFBEFD0", Offset = "0xFBEFD0", VA = "0xFBEFD0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x591358", Offset = "0x591358")]
	protected IEnumerator AimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0xFBF188", Offset = "0xFBF188", VA = "0xFBF188")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5913D8", Offset = "0x5913D8")]
	protected IEnumerator CancelAimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0xFBF340", Offset = "0xFBF340", VA = "0xFBF340")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x591458", Offset = "0x591458")]
	protected IEnumerator PreTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0xFBF4F8", Offset = "0xFBF4F8", VA = "0xFBF4F8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5914D8", Offset = "0x5914D8")]
	protected IEnumerator CancelTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0xFBF6B0", Offset = "0xFBF6B0", VA = "0xFBF6B0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x591558", Offset = "0x591558")]
	protected IEnumerator TeleportingStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0xFBF868", Offset = "0xFBF868", VA = "0xFBF868")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5915D8", Offset = "0x5915D8")]
	protected IEnumerator PostTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0xFBFA20", Offset = "0xFBFA20", VA = "0xFBFA20")]
	public void DoTeleport()
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0xFBFB60", Offset = "0xFBFB60", VA = "0xFBFB60")]
	public Vector3 GetCharacterPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0xFBFB94", Offset = "0xFBFB94", VA = "0xFBFB94")]
	public Quaternion GetHeadRotationY()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0xFBFC5C", Offset = "0xFBFC5C", VA = "0xFBFC5C")]
	public void DoWarp(Vector3 startPos, float positionPercent)
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0xFBFD54", Offset = "0xFBFD54", VA = "0xFBFD54")]
	public LocomotionTeleport()
	{
	}
}
[Token(Token = "0x200009A")]
public class SimpleCapsuleWithStickMovement : MonoBehaviour
{
	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool EnableLinearMovement;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool EnableRotation;

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool HMDRotatesPlayer;

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool RotationEitherThumbstick;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float RotationAngle;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Speed;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool ReadyToSnapTurn;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Rigidbody _rigidbody;

	[Token(Token = "0x1400000C")]
	public event Action CameraUpdated
	{
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x85278C", Offset = "0x85278C", VA = "0x85278C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5918A8", Offset = "0x5918A8")]
		add
		{
		}
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x85282C", Offset = "0x85282C", VA = "0x85282C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5918B8", Offset = "0x5918B8")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public event Action PreCharacterMove
	{
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x8528CC", Offset = "0x8528CC", VA = "0x8528CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5918C8", Offset = "0x5918C8")]
		add
		{
		}
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x85296C", Offset = "0x85296C", VA = "0x85296C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5918D8", Offset = "0x5918D8")]
		remove
		{
		}
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x852A0C", Offset = "0x852A0C", VA = "0x852A0C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x852AF8", Offset = "0x852AF8", VA = "0x852AF8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x852B6C", Offset = "0x852B6C", VA = "0x852B6C")]
	private void RotatePlayerToHMD()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x852C90", Offset = "0x852C90", VA = "0x852C90")]
	private void StickMovement()
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x852E78", Offset = "0x852E78", VA = "0x852E78")]
	private void SnapTurn()
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x853080", Offset = "0x853080", VA = "0x853080")]
	public SimpleCapsuleWithStickMovement()
	{
	}
}
[Token(Token = "0x200009B")]
public abstract class TeleportAimHandler : TeleportSupport
{
	[Token(Token = "0x6000222")]
	[Address(RVA = "0xB08B20", Offset = "0xB08B20", VA = "0xB08B20", Slot = "4")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0xB08BC0", Offset = "0xB08BC0", VA = "0xB08BC0", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000224")]
	public abstract void GetPoints(List<Vector3> points);

	[Token(Token = "0x6000225")]
	[Address(RVA = "0xB08CB0", Offset = "0xB08CB0", VA = "0xB08CB0")]
	protected TeleportAimHandler()
	{
	}
}
[Token(Token = "0x200009C")]
public class TeleportAimHandlerLaser : TeleportAimHandler
{
	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58EF74", Offset = "0x58EF74")]
	public float Range;

	[Token(Token = "0x6000226")]
	[Address(RVA = "0xB08CC0", Offset = "0xB08CC0", VA = "0xB08CC0", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0xB08DBC", Offset = "0xB08DBC", VA = "0xB08DBC")]
	public TeleportAimHandlerLaser()
	{
	}
}
[Token(Token = "0x200009D")]
public class TeleportAimHandlerParabolic : TeleportAimHandler
{
	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58EFAC", Offset = "0x58EFAC")]
	public float Range;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58EFE4", Offset = "0x58EFE4")]
	public float MinimumElevation;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F01C", Offset = "0x58F01C")]
	public float Gravity;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F054", Offset = "0x58F054")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58F054", Offset = "0x58F054")]
	public float AimVelocity;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58F0B0", Offset = "0x58F0B0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F0B0", Offset = "0x58F0B0")]
	public float AimStep;

	[Token(Token = "0x6000228")]
	[Address(RVA = "0xB08DCC", Offset = "0xB08DCC", VA = "0xB08DCC", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0xB08F5C", Offset = "0xB08F5C", VA = "0xB08F5C")]
	public TeleportAimHandlerParabolic()
	{
	}
}
[Token(Token = "0x200009E")]
public class TeleportAimVisualLaser : TeleportSupport
{
	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F108", Offset = "0x58F108")]
	public LineRenderer LaserPrefab;

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _enterAimStateAction;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly Action _exitAimStateAction;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] _linePoints;

	[Token(Token = "0x600022A")]
	[Address(RVA = "0xB08F70", Offset = "0xB08F70", VA = "0xB08F70")]
	public TeleportAimVisualLaser()
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0xB090AC", Offset = "0xB090AC", VA = "0xB090AC")]
	private void EnterAimState()
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0xB090DC", Offset = "0xB090DC", VA = "0xB090DC")]
	private void ExitAimState()
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0xB0910C", Offset = "0xB0910C", VA = "0xB0910C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0xB091BC", Offset = "0xB091BC", VA = "0xB091BC", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0xB09228", Offset = "0xB09228", VA = "0xB09228", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0xB09290", Offset = "0xB09290", VA = "0xB09290")]
	private void UpdateAimData(LocomotionTeleport.AimData obj)
	{
	}
}
[Token(Token = "0x200009F")]
public class TeleportDestination : MonoBehaviour
{
	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58F140", Offset = "0x58F140")]
	private bool <IsValidDestination>k__BackingField;

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F150", Offset = "0x58F150")]
	public Transform PositionIndicator;

	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F188", Offset = "0x58F188")]
	public Transform OrientationIndicator;

	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F1C0", Offset = "0x58F1C0")]
	public Quaternion LandingRotation;

	[NonSerialized]
	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LocomotionTeleport LocomotionTeleport;

	[NonSerialized]
	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LocomotionTeleport.States TeleportState;

	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Action<bool, Vector3?, Quaternion?, Quaternion?> _updateTeleportDestinationAction;

	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool _eventsActive;

	[Token(Token = "0x17000025")]
	public bool IsValidDestination
	{
		[Token(Token = "0x6000231")]
		[Address(RVA = "0xB093B4", Offset = "0xB093B4", VA = "0xB093B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5918E8", Offset = "0x5918E8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000232")]
		[Address(RVA = "0xB093BC", Offset = "0xB093BC", VA = "0xB093BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5918F8", Offset = "0x5918F8")]
		private set
		{
		}
	}

	[Token(Token = "0x1400000E")]
	public event Action<TeleportDestination> Deactivated
	{
		[Token(Token = "0x6000237")]
		[Address(RVA = "0xB09578", Offset = "0xB09578", VA = "0xB09578")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591908", Offset = "0x591908")]
		add
		{
		}
		[Token(Token = "0x6000238")]
		[Address(RVA = "0xB09618", Offset = "0xB09618", VA = "0xB09618")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591918", Offset = "0x591918")]
		remove
		{
		}
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0xB093C8", Offset = "0xB093C8", VA = "0xB093C8")]
	private TeleportDestination()
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0xB09460", Offset = "0xB09460", VA = "0xB09460")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0xB09534", Offset = "0xB09534", VA = "0xB09534")]
	private void TryDisableEventHandlers()
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0xB09574", Offset = "0xB09574", VA = "0xB09574")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0xB096B8", Offset = "0xB096B8", VA = "0xB096B8")]
	public void OnDeactivated()
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0xB0971C", Offset = "0xB0971C", VA = "0xB0971C")]
	public void Recycle()
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0xB0973C", Offset = "0xB0973C", VA = "0xB0973C", Slot = "4")]
	public virtual void UpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}
}
[Token(Token = "0x20000A0")]
public abstract class TeleportInputHandler : TeleportSupport
{
	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CAF0", Offset = "0x58CAF0")]
	private sealed class <TeleportReadyCoroutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x17000026")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0xF3F72C", Offset = "0xF3F72C", VA = "0xF3F72C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0xF3F774", Offset = "0xF3F774", VA = "0xF3F774", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xF3F664", Offset = "0xF3F664", VA = "0xF3F664")]
		[DebuggerHidden]
		public <TeleportReadyCoroutine>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xF3F690", Offset = "0xF3F690", VA = "0xF3F690", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xF3F694", Offset = "0xF3F694", VA = "0xF3F694", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xF3F734", Offset = "0xF3F734", VA = "0xF3F734", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000A2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CB00", Offset = "0x58CB00")]
	private sealed class <TeleportAimCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x17000028")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600024E")]
			[Address(RVA = "0xF3F614", Offset = "0xF3F614", VA = "0xF3F614", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0xF3F65C", Offset = "0xF3F65C", VA = "0xF3F65C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xF3F548", Offset = "0xF3F548", VA = "0xF3F548")]
		[DebuggerHidden]
		public <TeleportAimCoroutine>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xF3F574", Offset = "0xF3F574", VA = "0xF3F574", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xF3F578", Offset = "0xF3F578", VA = "0xF3F578", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xF3F61C", Offset = "0xF3F61C", VA = "0xF3F61C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _startReadyAction;

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x600023C")]
	[Address(RVA = "0xB09948", Offset = "0xB09948", VA = "0xB09948")]
	protected TeleportInputHandler()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0xB09A1C", Offset = "0xB09A1C", VA = "0xB09A1C", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0xB09A7C", Offset = "0xB09A7C", VA = "0xB09A7C", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0xB09B3C", Offset = "0xB09B3C", VA = "0xB09B3C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x591928", Offset = "0x591928")]
	private IEnumerator TeleportReadyCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0xB09BB4", Offset = "0xB09BB4", VA = "0xB09BB4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x591988", Offset = "0x591988")]
	private IEnumerator TeleportAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000241")]
	public abstract LocomotionTeleport.TeleportIntentions GetIntention();

	[Token(Token = "0x6000242")]
	public abstract void GetAimData(out Ray aimRay);

	[Token(Token = "0x6000243")]
	[Address(RVA = "0xB09C2C", Offset = "0xB09C2C", VA = "0xB09C2C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5919E8", Offset = "0x5919E8")]
	private void <.ctor>b__2_0()
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0xB09C58", Offset = "0xB09C58", VA = "0xB09C58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5919F8", Offset = "0x5919F8")]
	private void <.ctor>b__2_1()
	{
	}
}
[Token(Token = "0x20000A3")]
public class TeleportInputHandlerHMD : TeleportInputHandler
{
	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58F208", Offset = "0x58F208")]
	private Transform <Pointer>k__BackingField;

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F218", Offset = "0x58F218")]
	public OVRInput.RawButton AimButton;

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F250", Offset = "0x58F250")]
	public OVRInput.RawButton TeleportButton;

	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F288", Offset = "0x58F288")]
	public bool FastTeleport;

	[Token(Token = "0x1700002A")]
	public Transform Pointer
	{
		[Token(Token = "0x6000251")]
		[Address(RVA = "0xB09C84", Offset = "0xB09C84", VA = "0xB09C84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591AA8", Offset = "0x591AA8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000252")]
		[Address(RVA = "0xB09C8C", Offset = "0xB09C8C", VA = "0xB09C8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591AB8", Offset = "0x591AB8")]
		private set
		{
		}
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0xB09C94", Offset = "0xB09C94", VA = "0xB09C94", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0xB09DEC", Offset = "0xB09DEC", VA = "0xB09DEC", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0xB09EA4", Offset = "0xB09EA4", VA = "0xB09EA4")]
	public TeleportInputHandlerHMD()
	{
	}
}
[Token(Token = "0x20000A4")]
public class TeleportInputHandlerTouch : TeleportInputHandlerHMD
{
	[Token(Token = "0x20000A5")]
	public enum InputModes
	{
		[Token(Token = "0x40003B7")]
		CapacitiveButtonForAimAndTeleport,
		[Token(Token = "0x40003B8")]
		SeparateButtonsForAimAndTeleport,
		[Token(Token = "0x40003B9")]
		ThumbstickTeleport,
		[Token(Token = "0x40003BA")]
		ThumbstickTeleportForwardBackOnly
	}

	[Token(Token = "0x20000A6")]
	public enum AimCapTouchButtons
	{
		[Token(Token = "0x40003BC")]
		A,
		[Token(Token = "0x40003BD")]
		B,
		[Token(Token = "0x40003BE")]
		LeftTrigger,
		[Token(Token = "0x40003BF")]
		LeftThumbstick,
		[Token(Token = "0x40003C0")]
		RightTrigger,
		[Token(Token = "0x40003C1")]
		RightThumbstick,
		[Token(Token = "0x40003C2")]
		X,
		[Token(Token = "0x40003C3")]
		Y
	}

	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform LeftHand;

	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform RightHand;

	[Token(Token = "0x40003AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F2C0", Offset = "0x58F2C0")]
	public InputModes InputMode;

	[Token(Token = "0x40003B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly OVRInput.RawButton[] _rawButtons;

	[Token(Token = "0x40003B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly OVRInput.RawTouch[] _rawTouch;

	[Token(Token = "0x40003B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F2F8", Offset = "0x58F2F8")]
	public OVRInput.Controller AimingController;

	[Token(Token = "0x40003B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private OVRInput.Controller InitiatingController;

	[Token(Token = "0x40003B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F330", Offset = "0x58F330")]
	public AimCapTouchButtons CapacitiveAimAndTeleportButton;

	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F368", Offset = "0x58F368")]
	public float ThumbstickTeleportThreshold;

	[Token(Token = "0x6000256")]
	[Address(RVA = "0xB09EA8", Offset = "0xB09EA8", VA = "0xB09EA8", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0xB0A290", Offset = "0xB0A290", VA = "0xB0A290", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0xB0A350", Offset = "0xB0A350", VA = "0xB0A350")]
	public TeleportInputHandlerTouch()
	{
	}
}
[Token(Token = "0x20000A7")]
public abstract class TeleportOrientationHandler : TeleportSupport
{
	[Token(Token = "0x20000A8")]
	public enum OrientationModes
	{
		[Token(Token = "0x40003C8")]
		HeadRelative,
		[Token(Token = "0x40003C9")]
		ForwardFacing
	}

	[Token(Token = "0x20000A9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CB10", Offset = "0x58CB10")]
	private sealed class <UpdateOrientationCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportOrientationHandler <>4__this;

		[Token(Token = "0x1700002B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0xF3F85C", Offset = "0xF3F85C", VA = "0xF3F85C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0xF3F8A4", Offset = "0xF3F8A4", VA = "0xF3F8A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xF3F77C", Offset = "0xF3F77C", VA = "0xF3F77C")]
		[DebuggerHidden]
		public <UpdateOrientationCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xF3F7A8", Offset = "0xF3F7A8", VA = "0xF3F7A8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xF3F7AC", Offset = "0xF3F7AC", VA = "0xF3F7AC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xF3F864", Offset = "0xF3F864", VA = "0xF3F864", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _updateOrientationAction;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected LocomotionTeleport.AimData AimData;

	[Token(Token = "0x6000259")]
	[Address(RVA = "0xB0A434", Offset = "0xB0A434", VA = "0xB0A434")]
	protected TeleportOrientationHandler()
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0xB0A528", Offset = "0xB0A528", VA = "0xB0A528")]
	private void UpdateAimData(LocomotionTeleport.AimData aimData)
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0xB0A530", Offset = "0xB0A530", VA = "0xB0A530", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0xB0A57C", Offset = "0xB0A57C", VA = "0xB0A57C", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0xB0A5C4", Offset = "0xB0A5C4", VA = "0xB0A5C4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x591AC8", Offset = "0x591AC8")]
	private IEnumerator UpdateOrientationCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600025E")]
	protected abstract void InitializeTeleportDestination();

	[Token(Token = "0x600025F")]
	protected abstract void UpdateTeleportDestination();

	[Token(Token = "0x6000260")]
	[Address(RVA = "0xB0A63C", Offset = "0xB0A63C", VA = "0xB0A63C")]
	protected Quaternion GetLandingOrientation(OrientationModes mode, Quaternion rotation)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0xB0A6F8", Offset = "0xB0A6F8", VA = "0xB0A6F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591B28", Offset = "0x591B28")]
	private void <.ctor>b__3_0()
	{
	}
}
[Token(Token = "0x20000AA")]
public class TeleportOrientationHandler360 : TeleportOrientationHandler
{
	[Token(Token = "0x6000268")]
	[Address(RVA = "0xB0A724", Offset = "0xB0A724", VA = "0xB0A724", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0xB0A728", Offset = "0xB0A728", VA = "0xB0A728", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0xB0A7A4", Offset = "0xB0A7A4", VA = "0xB0A7A4")]
	public TeleportOrientationHandler360()
	{
	}
}
[Token(Token = "0x20000AB")]
public class TeleportOrientationHandlerHMD : TeleportOrientationHandler
{
	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F3A0", Offset = "0x58F3A0")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F3D8", Offset = "0x58F3D8")]
	public bool UpdateOrientationDuringAim;

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F410", Offset = "0x58F410")]
	public float AimDistanceThreshold;

	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F448", Offset = "0x58F448")]
	public float AimDistanceMaxRange;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Quaternion _initialRotation;

	[Token(Token = "0x600026B")]
	[Address(RVA = "0xB0A7A8", Offset = "0xB0A7A8", VA = "0xB0A7A8", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0xB0A7D4", Offset = "0xB0A7D4", VA = "0xB0A7D4", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0xB0AB84", Offset = "0xB0AB84", VA = "0xB0AB84")]
	public TeleportOrientationHandlerHMD()
	{
	}
}
[Token(Token = "0x20000AC")]
public class TeleportOrientationHandlerThumbstick : TeleportOrientationHandler
{
	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F480", Offset = "0x58F480")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F4B8", Offset = "0x58F4B8")]
	public OVRInput.Controller Thumbstick;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F4F0", Offset = "0x58F4F0")]
	public float RotateStickThreshold;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Quaternion _initialRotation;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion _currentRotation;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector2 _lastValidDirection;

	[Token(Token = "0x600026E")]
	[Address(RVA = "0xB0AB88", Offset = "0xB0AB88", VA = "0xB0AB88", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0xB0ABCC", Offset = "0xB0ABCC", VA = "0xB0ABCC", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0xB0AF74", Offset = "0xB0AF74", VA = "0xB0AF74")]
	public TeleportOrientationHandlerThumbstick()
	{
	}
}
[Token(Token = "0x20000AD")]
public class TeleportPoint : MonoBehaviour
{
	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float dimmingSpeed;

	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float fullIntensity;

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float lowIntensity;

	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform destTransform;

	[Token(Token = "0x40003DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float lastLookAtTime;

	[Token(Token = "0x6000271")]
	[Address(RVA = "0xB0AF84", Offset = "0xB0AF84", VA = "0xB0AF84")]
	public Transform GetDestTransform()
	{
		return null;
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0xB0AF8C", Offset = "0xB0AF8C", VA = "0xB0AF8C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0xB0B048", Offset = "0xB0B048", VA = "0xB0B048")]
	public void OnLookAt()
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0xB0B070", Offset = "0xB0B070", VA = "0xB0B070")]
	public TeleportPoint()
	{
	}
}
[Token(Token = "0x20000AE")]
public abstract class TeleportSupport : MonoBehaviour
{
	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58F528", Offset = "0x58F528")]
	private LocomotionTeleport <LocomotionTeleport>k__BackingField;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool _eventsActive;

	[Token(Token = "0x1700002D")]
	protected LocomotionTeleport LocomotionTeleport
	{
		[Token(Token = "0x6000275")]
		[Address(RVA = "0xB0B088", Offset = "0xB0B088", VA = "0xB0B088")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591B88", Offset = "0x591B88")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000276")]
		[Address(RVA = "0xB0B090", Offset = "0xB0B090", VA = "0xB0B090")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591B98", Offset = "0x591B98")]
		private set
		{
		}
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0xB08B54", Offset = "0xB08B54", VA = "0xB08B54", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0xB08C7C", Offset = "0xB08C7C", VA = "0xB08C7C", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0xB0B098", Offset = "0xB0B098", VA = "0xB0B098")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x591BA8", Offset = "0x591BA8")]
	private void LogEventHandler(string msg)
	{
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0xB0921C", Offset = "0xB0921C", VA = "0xB0921C", Slot = "6")]
	protected virtual void AddEventHandlers()
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0xB09288", Offset = "0xB09288", VA = "0xB09288", Slot = "7")]
	protected virtual void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0xB08CB8", Offset = "0xB08CB8", VA = "0xB08CB8")]
	protected TeleportSupport()
	{
	}
}
[Token(Token = "0x20000AF")]
public abstract class TeleportTargetHandler : TeleportSupport
{
	[Token(Token = "0x20000B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CB20", Offset = "0x58CB20")]
	private sealed class <TargetAimCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTargetHandler <>4__this;

		[Token(Token = "0x1700002E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0xF3FB7C", Offset = "0xF3FB7C", VA = "0xF3FB7C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0xF3FBC4", Offset = "0xF3FBC4", VA = "0xF3FBC4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xF3F8AC", Offset = "0xF3F8AC", VA = "0xF3F8AC")]
		[DebuggerHidden]
		public <TargetAimCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xF3F8D8", Offset = "0xF3F8D8", VA = "0xF3F8D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xF3F8DC", Offset = "0xF3F8DC", VA = "0xF3F8DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xF3FB84", Offset = "0xF3FB84", VA = "0xF3FB84", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F538", Offset = "0x58F538")]
	public LayerMask AimCollisionLayerMask;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected readonly LocomotionTeleport.AimData AimData;

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly List<Vector3> _aimPoints;

	[Token(Token = "0x40003E3")]
	private const float ERROR_MARGIN = 0.1f;

	[Token(Token = "0x600027D")]
	[Address(RVA = "0xB0B174", Offset = "0xB0B174", VA = "0xB0B174")]
	protected TeleportTargetHandler()
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0xB0B284", Offset = "0xB0B284", VA = "0xB0B284", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0xB0B2B0", Offset = "0xB0B2B0", VA = "0xB0B2B0", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0xB0B2D8", Offset = "0xB0B2D8", VA = "0xB0B2D8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x591BE0", Offset = "0x591BE0")]
	private IEnumerator TargetAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0xB0B350", Offset = "0xB0B350", VA = "0xB0B350", Slot = "8")]
	protected virtual void ResetAimData()
	{
	}

	[Token(Token = "0x6000282")]
	protected abstract bool ConsiderTeleport(Vector3 start, ref Vector3 end);

	[Token(Token = "0x6000283")]
	[Address(RVA = "0xB0B36C", Offset = "0xB0B36C", VA = "0xB0B36C", Slot = "10")]
	public virtual Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0xB0B48C", Offset = "0xB0B48C", VA = "0xB0B48C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591C40", Offset = "0x591C40")]
	private void <.ctor>b__3_0()
	{
	}
}
[Token(Token = "0x20000B1")]
public class TeleportTargetHandlerNavMesh : TeleportTargetHandler
{
	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int NavMeshAreaMask;

	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private NavMeshPath _path;

	[Token(Token = "0x600028B")]
	[Address(RVA = "0xB0B4B8", Offset = "0xB0B4B8", VA = "0xB0B4B8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0xB0B51C", Offset = "0xB0B51C", VA = "0xB0B51C", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0xB0B614", Offset = "0xB0B614", VA = "0xB0B614", Slot = "10")]
	public override Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0xB0B70C", Offset = "0xB0B70C", VA = "0xB0B70C")]
	public TeleportTargetHandlerNavMesh()
	{
	}
}
[Token(Token = "0x20000B2")]
public class TeleportTargetHandlerNode : TeleportTargetHandler
{
	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F570", Offset = "0x58F570")]
	public float LOSOffset;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F5A8", Offset = "0x58F5A8")]
	public LayerMask TeleportLayerMask;

	[Token(Token = "0x600028F")]
	[Address(RVA = "0xB0B718", Offset = "0xB0B718", VA = "0xB0B718", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0xB0B924", Offset = "0xB0B924", VA = "0xB0B924")]
	public TeleportTargetHandlerNode()
	{
	}
}
[Token(Token = "0x20000B3")]
public class TeleportTargetHandlerPhysical : TeleportTargetHandler
{
	[Token(Token = "0x6000291")]
	[Address(RVA = "0xB0B930", Offset = "0xB0B930", VA = "0xB0B930", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0xB0BA28", Offset = "0xB0BA28", VA = "0xB0BA28")]
	public TeleportTargetHandlerPhysical()
	{
	}
}
[Token(Token = "0x20000B4")]
public abstract class TeleportTransition : TeleportSupport
{
	[Token(Token = "0x6000293")]
	[Address(RVA = "0xB0BA2C", Offset = "0xB0BA2C", VA = "0xB0BA2C", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0xB0BAC0", Offset = "0xB0BAC0", VA = "0xB0BAC0", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000295")]
	protected abstract void LocomotionTeleportOnEnterStateTeleporting();

	[Token(Token = "0x6000296")]
	[Address(RVA = "0xB0BB50", Offset = "0xB0BB50", VA = "0xB0BB50")]
	protected TeleportTransition()
	{
	}
}
[Token(Token = "0x20000B5")]
public class TeleportTransitionBlink : TeleportTransition
{
	[Token(Token = "0x20000B6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CB30", Offset = "0x58CB30")]
	private sealed class <BlinkCoroutine>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionBlink <>4__this;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <teleportTime>5__3;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <teleported>5__4;

		[Token(Token = "0x17000030")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600029D")]
			[Address(RVA = "0xF3FD04", Offset = "0xF3FD04", VA = "0xF3FD04", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0xF3FD4C", Offset = "0xF3FD4C", VA = "0xF3FD4C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xF3FBCC", Offset = "0xF3FBCC", VA = "0xF3FBCC")]
		[DebuggerHidden]
		public <BlinkCoroutine>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xF3FBF8", Offset = "0xF3FBF8", VA = "0xF3FBF8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xF3FBFC", Offset = "0xF3FBFC", VA = "0xF3FBFC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xF3FD0C", Offset = "0xF3FD0C", VA = "0xF3FD0C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F5E0", Offset = "0x58F5E0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58F5E0", Offset = "0x58F5E0")]
	public float TransitionDuration;

	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58F638", Offset = "0x58F638")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F638", Offset = "0x58F638")]
	public float TeleportDelay;

	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F68C", Offset = "0x58F68C")]
	public AnimationCurve FadeLevels;

	[Token(Token = "0x6000297")]
	[Address(RVA = "0xB0BB58", Offset = "0xB0BB58", VA = "0xB0BB58", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0xB0BB84", Offset = "0xB0BB84", VA = "0xB0BB84")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x591CA0", Offset = "0x591CA0")]
	protected IEnumerator BlinkCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0xB0BBFC", Offset = "0xB0BBFC", VA = "0xB0BBFC")]
	public TeleportTransitionBlink()
	{
	}
}
[Token(Token = "0x20000B7")]
public class TeleportTransitionInstant : TeleportTransition
{
	[Token(Token = "0x60002A0")]
	[Address(RVA = "0xB0BDA8", Offset = "0xB0BDA8", VA = "0xB0BDA8", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0xB0BDC4", Offset = "0xB0BDC4", VA = "0xB0BDC4")]
	public TeleportTransitionInstant()
	{
	}
}
[Token(Token = "0x20000B8")]
public class TeleportTransitionWarp : TeleportTransition
{
	[Token(Token = "0x20000B9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CB40", Offset = "0x58CB40")]
	private sealed class <DoWarp>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionWarp <>4__this;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <startPosition>5__2;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <elapsedTime>5__3;

		[Token(Token = "0x17000032")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0xF3FEC0", Offset = "0xF3FEC0", VA = "0xF3FEC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0xF3FF08", Offset = "0xF3FF08", VA = "0xF3FF08", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xF3FD54", Offset = "0xF3FD54", VA = "0xF3FD54")]
		[DebuggerHidden]
		public <DoWarp>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xF3FD80", Offset = "0xF3FD80", VA = "0xF3FD80", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xF3FD84", Offset = "0xF3FD84", VA = "0xF3FD84", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xF3FEC8", Offset = "0xF3FEC8", VA = "0xF3FEC8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F6C4", Offset = "0x58F6C4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58F6C4", Offset = "0x58F6C4")]
	public float TransitionDuration;

	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public AnimationCurve PositionLerp;

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0xB0BDCC", Offset = "0xB0BDCC", VA = "0xB0BDCC", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0xB0BDF8", Offset = "0xB0BDF8", VA = "0xB0BDF8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x591D50", Offset = "0x591D50")]
	private IEnumerator DoWarp()
	{
		return null;
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0xB0BE70", Offset = "0xB0BE70", VA = "0xB0BE70")]
	public TeleportTransitionWarp()
	{
	}
}
[Token(Token = "0x20000BA")]
public static class NativeVideoPlayer
{
	[Token(Token = "0x20000BB")]
	public enum StereoMode
	{
		[Token(Token = "0x4000412")]
		Unknown = -1,
		[Token(Token = "0x4000413")]
		Mono,
		[Token(Token = "0x4000414")]
		TopBottom,
		[Token(Token = "0x4000415")]
		LeftRight,
		[Token(Token = "0x4000416")]
		Mesh
	}

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static IntPtr? _Activity;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static IntPtr? _VideoPlayerClass;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly jvalue[] EmptyParams;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static IntPtr getIsPlayingMethodId;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static IntPtr getDurationMethodId;

	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static IntPtr getStereoModeMethodId;

	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static IntPtr getWidthMethodId;

	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static IntPtr getHeightMethodId;

	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static IntPtr getPlaybackPositionMethodId;

	[Token(Token = "0x4000404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static IntPtr setPlaybackPositionMethodId;

	[Token(Token = "0x4000405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static jvalue[] setPlaybackPositionParams;

	[Token(Token = "0x4000406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static IntPtr playVideoMethodId;

	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static jvalue[] playVideoParams;

	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static IntPtr stopMethodId;

	[Token(Token = "0x4000409")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static IntPtr resumeMethodId;

	[Token(Token = "0x400040A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static IntPtr pauseMethodId;

	[Token(Token = "0x400040B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static IntPtr setPlaybackSpeedMethodId;

	[Token(Token = "0x400040C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static jvalue[] setPlaybackSpeedParams;

	[Token(Token = "0x400040D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static IntPtr setLoopingMethodId;

	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private static jvalue[] setLoopingParams;

	[Token(Token = "0x400040F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private static IntPtr setListenerRotationQuaternionMethodId;

	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private static jvalue[] setListenerRotationQuaternionParams;

	[Token(Token = "0x17000034")]
	private static IntPtr VideoPlayerClass
	{
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xD84B08", Offset = "0xD84B08", VA = "0xD84B08")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x17000035")]
	private static IntPtr Activity
	{
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xD84E38", Offset = "0xD84E38", VA = "0xD84E38")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x17000036")]
	public static bool IsAvailable
	{
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xD85108", Offset = "0xD85108", VA = "0xD85108")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000037")]
	public static bool IsPlaying
	{
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xD85178", Offset = "0xD85178", VA = "0xD85178")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000038")]
	public static long Duration
	{
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xD85288", Offset = "0xD85288", VA = "0xD85288")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17000039")]
	public static StereoMode VideoStereoMode
	{
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xD8539C", Offset = "0xD8539C", VA = "0xD8539C")]
		get
		{
			return default(StereoMode);
		}
	}

	[Token(Token = "0x1700003A")]
	public static int VideoWidth
	{
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xD854B0", Offset = "0xD854B0", VA = "0xD854B0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700003B")]
	public static int VideoHeight
	{
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xD855C4", Offset = "0xD855C4", VA = "0xD855C4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700003C")]
	public static long PlaybackPosition
	{
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xD856D8", Offset = "0xD856D8", VA = "0xD856D8")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xD857EC", Offset = "0xD857EC", VA = "0xD857EC")]
		set
		{
		}
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0xD85960", Offset = "0xD85960", VA = "0xD85960")]
	public static void PlayVideo(string path, string drmLicenseUrl, IntPtr surfaceObj)
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0xD85B8C", Offset = "0xD85B8C", VA = "0xD85B8C")]
	public static void Stop()
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0xD85CA0", Offset = "0xD85CA0", VA = "0xD85CA0")]
	public static void Play()
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0xD85DB4", Offset = "0xD85DB4", VA = "0xD85DB4")]
	public static void Pause()
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0xD85EC8", Offset = "0xD85EC8", VA = "0xD85EC8")]
	public static void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0xD86044", Offset = "0xD86044", VA = "0xD86044")]
	public static void SetLooping(bool looping)
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0xD861BC", Offset = "0xD861BC", VA = "0xD861BC")]
	public static void SetListenerRotation(Quaternion rotation)
	{
	}
}
[Token(Token = "0x20000BC")]
public class ButtonDownListener : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[Token(Token = "0x1400000F")]
	public event Action onButtonDown
	{
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x859144", Offset = "0x859144", VA = "0x859144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591E00", Offset = "0x591E00")]
		add
		{
		}
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x8591E4", Offset = "0x8591E4", VA = "0x8591E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591E10", Offset = "0x591E10")]
		remove
		{
		}
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x859284", Offset = "0x859284", VA = "0x859284", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x859298", Offset = "0x859298", VA = "0x859298")]
	public ButtonDownListener()
	{
	}
}
[Token(Token = "0x20000BD")]
public class MediaPlayerImage : Image
{
	[Token(Token = "0x20000BE")]
	public enum ButtonType
	{
		[Token(Token = "0x400041A")]
		Play,
		[Token(Token = "0x400041B")]
		Pause,
		[Token(Token = "0x400041C")]
		FastForward,
		[Token(Token = "0x400041D")]
		Rewind,
		[Token(Token = "0x400041E")]
		SkipForward,
		[Token(Token = "0x400041F")]
		SkipBack,
		[Token(Token = "0x4000420")]
		Stop
	}

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[SerializeField]
	private ButtonType m_ButtonType;

	[Token(Token = "0x1700003D")]
	public ButtonType buttonType
	{
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xFBFE8C", Offset = "0xFBFE8C", VA = "0xFBFE8C")]
		get
		{
			return default(ButtonType);
		}
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xFBFE94", Offset = "0xFBFE94", VA = "0xFBFE94")]
		set
		{
		}
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0xFBFEB8", Offset = "0xFBFEB8", VA = "0xFBFEB8", Slot = "43")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0xFC1350", Offset = "0xFC1350", VA = "0xFC1350")]
	public MediaPlayerImage()
	{
	}
}
[Token(Token = "0x20000BF")]
public class MoviePlayerSample : MonoBehaviour
{
	[Token(Token = "0x20000C0")]
	public enum VideoShape
	{
		[Token(Token = "0x4000435")]
		_360,
		[Token(Token = "0x4000436")]
		_180,
		[Token(Token = "0x4000437")]
		Quad
	}

	[Token(Token = "0x20000C1")]
	public enum VideoStereo
	{
		[Token(Token = "0x4000439")]
		Mono,
		[Token(Token = "0x400043A")]
		TopBottom,
		[Token(Token = "0x400043B")]
		LeftRight,
		[Token(Token = "0x400043C")]
		BottomTop
	}

	[Token(Token = "0x20000C2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CB50", Offset = "0x58CB50")]
	private sealed class <Start>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x17000041")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0xF3C2DC", Offset = "0xF3C2DC", VA = "0xF3C2DC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0xF3C324", Offset = "0xF3C324", VA = "0xF3C324", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xF3C0E8", Offset = "0xF3C0E8", VA = "0xF3C0E8")]
		[DebuggerHidden]
		public <Start>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xF3C114", Offset = "0xF3C114", VA = "0xF3C114", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xF3C118", Offset = "0xF3C118", VA = "0xF3C118", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xF3C2E4", Offset = "0xF3C2E4", VA = "0xF3C2E4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000C3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CB60", Offset = "0x58CB60")]
	private sealed class <>c__DisplayClass34_0
	{
		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string moviePath;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string drmLicencesUrl;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xF3BFF0", Offset = "0xF3BFF0", VA = "0xF3BFF0")]
		public <>c__DisplayClass34_0()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xF3BFF8", Offset = "0xF3BFF8", VA = "0xF3BFF8")]
		internal void <Play>b__0()
		{
		}
	}

	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool videoPausedBeforeAppPause;

	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VideoPlayer videoPlayer;

	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVROverlay overlay;

	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Renderer mediaRenderer;

	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58F74C", Offset = "0x58F74C")]
	private bool <IsPlaying>k__BackingField;

	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58F75C", Offset = "0x58F75C")]
	private long <Duration>k__BackingField;

	[Token(Token = "0x4000427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58F76C", Offset = "0x58F76C")]
	private long <PlaybackPosition>k__BackingField;

	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private RenderTexture copyTexture;

	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material externalTex2DMaterial;

	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string MovieName;

	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string DrmLicenseUrl;

	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool LoopVideo;

	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public VideoShape Shape;

	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public VideoStereo Stereo;

	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool AutoDetectStereoLayout;

	[Token(Token = "0x4000430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	public bool DisplayMono;

	[Token(Token = "0x4000431")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private VideoShape _LastShape;

	[Token(Token = "0x4000432")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private VideoStereo _LastStereo;

	[Token(Token = "0x4000433")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool _LastDisplayMono;

	[Token(Token = "0x1700003E")]
	public bool IsPlaying
	{
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xFCB714", Offset = "0xFCB714", VA = "0xFCB714")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591E20", Offset = "0x591E20")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xFCB71C", Offset = "0xFCB71C", VA = "0xFCB71C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591E30", Offset = "0x591E30")]
		private set
		{
		}
	}

	[Token(Token = "0x1700003F")]
	public long Duration
	{
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xFCB728", Offset = "0xFCB728", VA = "0xFCB728")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591E40", Offset = "0x591E40")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xFCB730", Offset = "0xFCB730", VA = "0xFCB730")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591E50", Offset = "0x591E50")]
		private set
		{
		}
	}

	[Token(Token = "0x17000040")]
	public long PlaybackPosition
	{
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xFCB738", Offset = "0xFCB738", VA = "0xFCB738")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591E60", Offset = "0x591E60")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xFCB740", Offset = "0xFCB740", VA = "0xFCB740")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591E70", Offset = "0x591E70")]
		private set
		{
		}
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0xFCB748", Offset = "0xFCB748", VA = "0xFCB748")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0xFCB9F4", Offset = "0xFCB9F4", VA = "0xFCB9F4")]
	private bool IsLocalVideo(string movieName)
	{
		return default(bool);
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0xFCBA58", Offset = "0xFCBA58", VA = "0xFCBA58")]
	private void UpdateShapeAndStereo()
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0xFCBD90", Offset = "0xFCBD90", VA = "0xFCBD90")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x591E80", Offset = "0x591E80")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0xFCBE08", Offset = "0xFCBE08", VA = "0xFCBE08")]
	public void Play(string moviePath, string drmLicencesUrl)
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0xFCC0F0", Offset = "0xFCC0F0", VA = "0xFCC0F0")]
	public void Play()
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0xFCC184", Offset = "0xFCC184", VA = "0xFCC184")]
	public void Pause()
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0xFCC214", Offset = "0xFCC214", VA = "0xFCC214")]
	public void SeekTo(long position)
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0xFCC318", Offset = "0xFCC318", VA = "0xFCC318")]
	private void Update()
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0xFCC890", Offset = "0xFCC890", VA = "0xFCC890")]
	public void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0xFCC948", Offset = "0xFCC948", VA = "0xFCC948")]
	public void Stop()
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0xFCC9D8", Offset = "0xFCC9D8", VA = "0xFCC9D8")]
	private void OnApplicationPause(bool appWasPaused)
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0xFCCAC4", Offset = "0xFCCAC4", VA = "0xFCCAC4")]
	public MoviePlayerSample()
	{
	}
}
[Token(Token = "0x20000C4")]
public class MoviePlayerSampleControls : MonoBehaviour
{
	[Token(Token = "0x20000C5")]
	private enum PlaybackState
	{
		[Token(Token = "0x4000459")]
		Playing,
		[Token(Token = "0x400045A")]
		Paused,
		[Token(Token = "0x400045B")]
		Rewinding,
		[Token(Token = "0x400045C")]
		FastForwarding
	}

	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MoviePlayerSample Player;

	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRInputModule InputModule;

	[Token(Token = "0x4000445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRGazePointer GazePointer;

	[Token(Token = "0x4000446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject LeftHand;

	[Token(Token = "0x4000447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject RightHand;

	[Token(Token = "0x4000448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Canvas Canvas;

	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ButtonDownListener PlayPause;

	[Token(Token = "0x400044A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public MediaPlayerImage PlayPauseImage;

	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Slider ProgressBar;

	[Token(Token = "0x400044C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ButtonDownListener FastForward;

	[Token(Token = "0x400044D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public MediaPlayerImage FastForwardImage;

	[Token(Token = "0x400044E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ButtonDownListener Rewind;

	[Token(Token = "0x400044F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public MediaPlayerImage RewindImage;

	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float TimeoutTime;

	[Token(Token = "0x4000451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool _isVisible;

	[Token(Token = "0x4000452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float _lastButtonTime;

	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private bool _didSeek;

	[Token(Token = "0x4000454")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private long _seekPreviousPosition;

	[Token(Token = "0x4000455")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private long _rewindStartPosition;

	[Token(Token = "0x4000456")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float _rewindStartTime;

	[Token(Token = "0x4000457")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private PlaybackState _state;

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0xD835B8", Offset = "0xD835B8", VA = "0xD835B8")]
	private void Start()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0xD838C4", Offset = "0xD838C4", VA = "0xD838C4")]
	private void OnPlayPauseClicked()
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0xD83A00", Offset = "0xD83A00", VA = "0xD83A00")]
	private void OnFastForwardClicked()
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0xD83B20", Offset = "0xD83B20", VA = "0xD83B20")]
	private void OnRewindClicked()
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0xD83C0C", Offset = "0xD83C0C", VA = "0xD83C0C")]
	private void OnSeekBarMoved(float value)
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0xD83AF0", Offset = "0xD83AF0", VA = "0xD83AF0")]
	private void Seek(long pos)
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0xD83C54", Offset = "0xD83C54", VA = "0xD83C54")]
	private void Update()
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0xD837B0", Offset = "0xD837B0", VA = "0xD837B0")]
	private void SetVisible(bool visible)
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0xD83FB8", Offset = "0xD83FB8", VA = "0xD83FB8")]
	public MoviePlayerSampleControls()
	{
	}
}
[Token(Token = "0x20000C6")]
public static class VectorUtil
{
	[Token(Token = "0x60002E9")]
	[Address(RVA = "0xB0F81C", Offset = "0xB0F81C", VA = "0xB0F81C")]
	public static Vector4 ToVector(this Rect rect)
	{
		return default(Vector4);
	}
}
[Token(Token = "0x20000C7")]
public class AppDeeplinkUI : MonoBehaviour
{
	[Token(Token = "0x400045D")]
	private const ulong UNITY_COMPANION_APP_ID = 3535750239844224uL;

	[Token(Token = "0x400045E")]
	private const ulong UNREAL_COMPANION_APP_ID = 4055411724486843uL;

	[Token(Token = "0x400045F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform deeplinkAppId;

	[Token(Token = "0x4000460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform deeplinkMessage;

	[Token(Token = "0x4000461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform uiLaunchType;

	[Token(Token = "0x4000462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RectTransform uiLaunchSource;

	[Token(Token = "0x4000463")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private RectTransform uiDeepLinkMessage;

	[Token(Token = "0x4000464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool inMenu;

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x1409A7C", Offset = "0x1409A7C", VA = "0x1409A7C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x1409E90", Offset = "0x1409E90", VA = "0x1409E90")]
	private void Update()
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x140A11C", Offset = "0x140A11C", VA = "0x140A11C")]
	private void LaunchUnrealDeeplinkSample()
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x140A284", Offset = "0x140A284", VA = "0x140A284")]
	private void LaunchSelf()
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x140A3F0", Offset = "0x140A3F0", VA = "0x140A3F0")]
	private void LaunchOtherApp()
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x140A580", Offset = "0x140A580", VA = "0x140A580")]
	public AppDeeplinkUI()
	{
	}
}
[Token(Token = "0x20000C8")]
public class CustomDebugUI : MonoBehaviour
{
	[Token(Token = "0x4000465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x4000466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CustomDebugUI instance;

	[Token(Token = "0x4000467")]
	private const BindingFlags privateFlags = BindingFlags.Instance | BindingFlags.NonPublic;

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x8654E8", Offset = "0x8654E8", VA = "0x8654E8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x86553C", Offset = "0x86553C", VA = "0x86553C")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x8657B0", Offset = "0x8657B0", VA = "0x8657B0")]
	public void RemoveFromCanvas(RectTransform element, int targetCanvas = 0)
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x8659E0", Offset = "0x8659E0", VA = "0x8659E0")]
	public CustomDebugUI()
	{
	}
}
[Token(Token = "0x20000C9")]
public class DebugUISample : MonoBehaviour
{
	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool inMenu;

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Text sliderText;

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x8683A8", Offset = "0x8683A8", VA = "0x8683A8")]
	private void Start()
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x8688C4", Offset = "0x8688C4", VA = "0x8688C4")]
	public void TogglePressed(Toggle t)
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x868984", Offset = "0x868984", VA = "0x868984")]
	public void RadioPressed(string radioLabel, string group, Toggle t)
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x868C04", Offset = "0x868C04", VA = "0x868C04")]
	public void SliderPressed(float f)
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x868CE4", Offset = "0x868CE4", VA = "0x868CE4")]
	private void Update()
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x868DC8", Offset = "0x868DC8", VA = "0x868DC8")]
	private void LogButtonPressed()
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x868E3C", Offset = "0x868E3C", VA = "0x868E3C")]
	public DebugUISample()
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x868E44", Offset = "0x868E44", VA = "0x868E44")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591F40", Offset = "0x591F40")]
	private void <Start>b__2_0(Toggle t)
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x868EA8", Offset = "0x868EA8", VA = "0x868EA8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591F50", Offset = "0x591F50")]
	private void <Start>b__2_1(Toggle t)
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x868F0C", Offset = "0x868F0C", VA = "0x868F0C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591F60", Offset = "0x591F60")]
	private void <Start>b__2_2(Toggle t)
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x868F70", Offset = "0x868F70", VA = "0x868F70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591F70", Offset = "0x591F70")]
	private void <Start>b__2_3(Toggle t)
	{
	}
}
[Token(Token = "0x20000CA")]
public class AnalyticsUI : MonoBehaviour
{
	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x14079B0", Offset = "0x14079B0", VA = "0x14079B0")]
	public AnalyticsUI()
	{
	}
}
[Token(Token = "0x20000CB")]
public class SampleUI : MonoBehaviour
{
	[Token(Token = "0x400046A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform collectionButton;

	[Token(Token = "0x400046B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform inputText;

	[Token(Token = "0x400046C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform valueText;

	[Token(Token = "0x400046D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool inMenu;

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x8512D4", Offset = "0x8512D4", VA = "0x8512D4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x851378", Offset = "0x851378", VA = "0x851378")]
	private void Update()
	{
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x851464", Offset = "0x851464", VA = "0x851464")]
	private string GetText()
	{
		return null;
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x8514C4", Offset = "0x8514C4", VA = "0x8514C4")]
	public SampleUI()
	{
	}
}
[Token(Token = "0x20000CC")]
public class StartCrashlytics : MonoBehaviour
{
	[Token(Token = "0x6000304")]
	[Address(RVA = "0xB05D70", Offset = "0xB05D70", VA = "0xB05D70")]
	public StartCrashlytics()
	{
	}
}
[Token(Token = "0x20000CD")]
public class HandsActiveChecker : MonoBehaviour
{
	[Token(Token = "0x20000CE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CB80", Offset = "0x58CB80")]
	private sealed class <GetCenterEye>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HandsActiveChecker <>4__this;

		[Token(Token = "0x17000043")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0xF3984C", Offset = "0xF3984C", VA = "0xF3984C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600030E")]
			[Address(RVA = "0xF39894", Offset = "0xF39894", VA = "0xF39894", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xF396D0", Offset = "0xF396D0", VA = "0xF396D0")]
		[DebuggerHidden]
		public <GetCenterEye>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xF396FC", Offset = "0xF396FC", VA = "0xF396FC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xF39700", Offset = "0xF39700", VA = "0xF39700", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xF39854", Offset = "0xF39854", VA = "0xF39854", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400046E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _notificationPrefab;

	[Token(Token = "0x400046F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _notification;

	[Token(Token = "0x4000470")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRCameraRig _cameraRig;

	[Token(Token = "0x4000471")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _centerEye;

	[Token(Token = "0x6000305")]
	[Address(RVA = "0xB4D7DC", Offset = "0xB4D7DC", VA = "0xB4D7DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0xB4D8F8", Offset = "0xB4D8F8", VA = "0xB4D8F8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0xB4D880", Offset = "0xB4D880", VA = "0xB4D880")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x591F80", Offset = "0x591F80")]
	private IEnumerator GetCenterEye()
	{
		return null;
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0xB4DAA4", Offset = "0xB4DAA4", VA = "0xB4DAA4")]
	public HandsActiveChecker()
	{
	}
}
[Token(Token = "0x20000CF")]
[ExecuteInEditMode]
public class CharacterCapsule : MonoBehaviour
{
	[Token(Token = "0x4000475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CharacterController _character;

	[Token(Token = "0x4000476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshFilter _meshFilter;

	[Token(Token = "0x4000477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _height;

	[Token(Token = "0x4000478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float _radius;

	[Token(Token = "0x4000479")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58F79C", Offset = "0x58F79C")]
	public int SubdivisionsU;

	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58F7B8", Offset = "0x58F7B8")]
	public int SubdivisionsV;

	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _subdivisionU;

	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int _subdivisionV;

	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3[] _vertices;

	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int[] _triangles;

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x86087C", Offset = "0x86087C", VA = "0x86087C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x8612C4", Offset = "0x8612C4", VA = "0x8612C4")]
	public CharacterCapsule()
	{
	}
}
[Token(Token = "0x20000D0")]
public class LocomotionSampleSupport : MonoBehaviour
{
	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LocomotionController lc;

	[Token(Token = "0x4000480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool inMenu;

	[Token(Token = "0x17000045")]
	private LocomotionTeleport TeleportController
	{
		[Token(Token = "0x6000311")]
		[Address(RVA = "0xFBD6D0", Offset = "0xFBD6D0", VA = "0xFBD6D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0xFBD724", Offset = "0xFBD724", VA = "0xFBD724")]
	public void Start()
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0xFBDB4C", Offset = "0xFBDB4C", VA = "0xFBDB4C")]
	public void Update()
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0xFBDC38", Offset = "0xFBDC38", VA = "0xFBDC38")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x592030", Offset = "0x592030")]
	private static void Log(string msg)
	{
	}

	[Token(Token = "0x6000315")]
	public static TActivate ActivateCategory<TCategory, TActivate>(GameObject target) where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x6000316")]
	protected void ActivateHandlers<TInput, TAim, TTarget, TOrientation, TTransition>() where TInput : TeleportInputHandler where TAim : TeleportAimHandler where TTarget : TeleportTargetHandler where TOrientation : TeleportOrientationHandler where TTransition : TeleportTransition
	{
	}

	[Token(Token = "0x6000317")]
	protected void ActivateInput<TActivate>() where TActivate : TeleportInputHandler
	{
	}

	[Token(Token = "0x6000318")]
	protected void ActivateAim<TActivate>() where TActivate : TeleportAimHandler
	{
	}

	[Token(Token = "0x6000319")]
	protected void ActivateTarget<TActivate>() where TActivate : TeleportTargetHandler
	{
	}

	[Token(Token = "0x600031A")]
	protected void ActivateOrientation<TActivate>() where TActivate : TeleportOrientationHandler
	{
	}

	[Token(Token = "0x600031B")]
	protected void ActivateTransition<TActivate>() where TActivate : TeleportTransition
	{
	}

	[Token(Token = "0x600031C")]
	protected TActivate ActivateCategory<TCategory, TActivate>() where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0xFBDC9C", Offset = "0xFBDC9C", VA = "0xFBDC9C")]
	protected void UpdateToggle(Toggle toggle, bool enabled)
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0xFBDCD8", Offset = "0xFBDCD8", VA = "0xFBDCD8")]
	private void SetupNonCap()
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0xFBDD48", Offset = "0xFBDD48", VA = "0xFBDD48")]
	private void SetupTeleportDefaults()
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0xFBDEB8", Offset = "0xFBDEB8", VA = "0xFBDEB8")]
	protected GameObject AddInstance(GameObject template, string label)
	{
		return null;
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0xFBDF94", Offset = "0xFBDF94", VA = "0xFBDF94")]
	private void SetupNodeTeleport()
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0xFBDA44", Offset = "0xFBDA44", VA = "0xFBDA44")]
	private void SetupTwoStickTeleport()
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0xFBE05C", Offset = "0xFBE05C", VA = "0xFBE05C")]
	private void SetupWalkOnly()
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0xFBE0C4", Offset = "0xFBE0C4", VA = "0xFBE0C4")]
	private void SetupLeftStrafeRightTeleport()
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0xFBE1BC", Offset = "0xFBE1BC", VA = "0xFBE1BC")]
	public LocomotionSampleSupport()
	{
	}
}
[Token(Token = "0x20000D1")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x58CBA0", Offset = "0x58CBA0")]
public class OVROverlayCanvas : MonoBehaviour
{
	[Token(Token = "0x20000D2")]
	public enum DrawMode
	{
		[Token(Token = "0x4000496")]
		Opaque,
		[Token(Token = "0x4000497")]
		OpaqueWithClip,
		[Token(Token = "0x4000498")]
		TransparentDefaultAlpha,
		[Token(Token = "0x4000499")]
		TransparentCorrectAlpha
	}

	[Token(Token = "0x4000481")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[HideInInspector]
	private Shader _transparentShader;

	[Token(Token = "0x4000482")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[SerializeField]
	private Shader _opaqueShader;

	[Token(Token = "0x4000483")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform _rectTransform;

	[Token(Token = "0x4000484")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Canvas _canvas;

	[Token(Token = "0x4000485")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Camera _camera;

	[Token(Token = "0x4000486")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private OVROverlay _overlay;

	[Token(Token = "0x4000487")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private RenderTexture _renderTexture;

	[Token(Token = "0x4000488")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private MeshRenderer _meshRenderer;

	[Token(Token = "0x4000489")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Mesh _quad;

	[Token(Token = "0x400048A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material _defaultMat;

	[Token(Token = "0x400048B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int MaxTextureSize;

	[Token(Token = "0x400048C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int MinTextureSize;

	[Token(Token = "0x400048D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float PixelsPerUnit;

	[Token(Token = "0x400048E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int DrawRate;

	[Token(Token = "0x400048F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int DrawFrameOffset;

	[Token(Token = "0x4000490")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool Expensive;

	[Token(Token = "0x4000491")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int Layer;

	[Token(Token = "0x4000492")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public DrawMode Opacity;

	[Token(Token = "0x4000493")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool ScaleViewport;

	[Token(Token = "0x4000494")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Plane[] _FrustumPlanes;

	[Token(Token = "0x17000046")]
	public bool overlayEnabled
	{
		[Token(Token = "0x600032C")]
		[Address(RVA = "0xD879A4", Offset = "0xD879A4", VA = "0xD879A4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600032D")]
		[Address(RVA = "0xD87A34", Offset = "0xD87A34", VA = "0xD87A34")]
		set
		{
		}
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0xD86420", Offset = "0xD86420", VA = "0xD86420")]
	private void Start()
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0xD87010", Offset = "0xD87010", VA = "0xD87010")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0xD87090", Offset = "0xD87090", VA = "0xD87090")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0xD87180", Offset = "0xD87180", VA = "0xD87180")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0xD87270", Offset = "0xD87270", VA = "0xD87270", Slot = "4")]
	protected virtual bool ShouldRender()
	{
		return default(bool);
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0xD8747C", Offset = "0xD8747C", VA = "0xD8747C")]
	private void Update()
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0xD87B00", Offset = "0xD87B00", VA = "0xD87B00")]
	public OVROverlayCanvas()
	{
	}
}
[Token(Token = "0x20000D3")]
public class AugmentedObject : MonoBehaviour
{
	[Token(Token = "0x400049A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x400049B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform shadow;

	[Token(Token = "0x400049C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool groundShadow;

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x140A5F8", Offset = "0x140A5F8", VA = "0x140A5F8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x140A7E0", Offset = "0x140A7E0", VA = "0x140A7E0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x140A968", Offset = "0x140A968", VA = "0x140A968")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x140A970", Offset = "0x140A970", VA = "0x140A970")]
	public void Release()
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0x140A958", Offset = "0x140A958", VA = "0x140A958")]
	private void ToggleShadowType()
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0x140A978", Offset = "0x140A978", VA = "0x140A978")]
	public AugmentedObject()
	{
	}
}
[Token(Token = "0x20000D4")]
public class BrushController : MonoBehaviour
{
	[Token(Token = "0x20000D5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CC00", Offset = "0x58CC00")]
	private sealed class <FadeCameraClearColor>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float fadeTime;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Color newColor;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <timer>5__2;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <currentColor>5__3;

		[Token(Token = "0x17000047")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000340")]
			[Address(RVA = "0xF36B00", Offset = "0xF36B00", VA = "0xF36B00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0xF36B48", Offset = "0xF36B48", VA = "0xF36B48", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xF369D0", Offset = "0xF369D0", VA = "0xF369D0")]
		[DebuggerHidden]
		public <FadeCameraClearColor>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xF369FC", Offset = "0xF369FC", VA = "0xF369FC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xF36A00", Offset = "0xF36A00", VA = "0xF36A00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xF36B08", Offset = "0xF36B08", VA = "0xF36B08", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000D6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CC10", Offset = "0x58CC10")]
	private sealed class <FadeSphere>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BrushController <>4__this;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool disableOnFinish;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x17000049")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000346")]
			[Address(RVA = "0xF36D08", Offset = "0xF36D08", VA = "0xF36D08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000348")]
			[Address(RVA = "0xF36D50", Offset = "0xF36D50", VA = "0xF36D50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xF36B50", Offset = "0xF36B50", VA = "0xF36B50")]
		[DebuggerHidden]
		public <FadeSphere>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xF36B7C", Offset = "0xF36B7C", VA = "0xF36B7C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xF36B80", Offset = "0xF36B80", VA = "0xF36B80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xF36D10", Offset = "0xF36D10", VA = "0xF36D10", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400049D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PassthroughBrush brush;

	[Token(Token = "0x400049E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer backgroundSphere;

	[Token(Token = "0x400049F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerator grabRoutine;

	[Token(Token = "0x40004A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator releaseRoutine;

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x1419204", Offset = "0x1419204", VA = "0x1419204")]
	private void Start()
	{
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x14194D8", Offset = "0x14194D8", VA = "0x14194D8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x1419534", Offset = "0x1419534", VA = "0x1419534")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x14196B4", Offset = "0x14196B4", VA = "0x14196B4")]
	public void Release()
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x1419788", Offset = "0x1419788", VA = "0x1419788")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x592068", Offset = "0x592068")]
	private IEnumerator FadeCameraClearColor(Color newColor, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x14195F0", Offset = "0x14195F0", VA = "0x14195F0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5920C8", Offset = "0x5920C8")]
	private IEnumerator FadeSphere(Color newColor, float fadeTime, bool disableOnFinish = false)
	{
		return null;
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x1419824", Offset = "0x1419824", VA = "0x1419824")]
	public BrushController()
	{
	}
}
[Token(Token = "0x20000D7")]
public class EnableUnpremultipliedAlpha : MonoBehaviour
{
	[Token(Token = "0x6000349")]
	[Address(RVA = "0x86AF84", Offset = "0x86AF84", VA = "0x86AF84")]
	private void Start()
	{
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0x86AFE4", Offset = "0x86AFE4", VA = "0x86AFE4")]
	public EnableUnpremultipliedAlpha()
	{
	}
}
[Token(Token = "0x20000D8")]
public class Flashlight : MonoBehaviour
{
	[Token(Token = "0x40004AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject lightVolume;

	[Token(Token = "0x40004B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Light spotlight;

	[Token(Token = "0x40004B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject bulbGlow;

	[Token(Token = "0x600034B")]
	[Address(RVA = "0xB43690", Offset = "0xB43690", VA = "0xB43690")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0xB437C4", Offset = "0xB437C4", VA = "0xB437C4")]
	public void ToggleFlashlight()
	{
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0xB43858", Offset = "0xB43858", VA = "0xB43858")]
	public void EnableFlashlight(bool doEnable)
	{
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0xB438C0", Offset = "0xB438C0", VA = "0xB438C0")]
	public Flashlight()
	{
	}
}
[Token(Token = "0x20000D9")]
public class FlashlightController : MonoBehaviour
{
	[Token(Token = "0x20000DA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CC20", Offset = "0x58CC20")]
	private sealed class <FadeLighting>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FlashlightController <>4__this;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float sceneLightIntensity;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float <currentLight>5__4;

		[Token(Token = "0x1700004B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0xF38B60", Offset = "0xF38B60", VA = "0xF38B60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600035D")]
			[Address(RVA = "0xF38BA8", Offset = "0xF38BA8", VA = "0xF38BA8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xF38954", Offset = "0xF38954", VA = "0xF38954")]
		[DebuggerHidden]
		public <FadeLighting>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xF38980", Offset = "0xF38980", VA = "0xF38980", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xF38984", Offset = "0xF38984", VA = "0xF38984", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xF38B68", Offset = "0xF38B68", VA = "0xF38B68", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Light sceneLight;

	[Token(Token = "0x40004B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform flashlightRoot;

	[Token(Token = "0x40004B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 localPosition;

	[Token(Token = "0x40004B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Quaternion localRotation;

	[Token(Token = "0x40004B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMesh infoText;

	[Token(Token = "0x40004B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GrabObject externalController;

	[Token(Token = "0x40004B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private OVRSkeleton[] skeletons;

	[Token(Token = "0x40004B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private OVRHand[] hands;

	[Token(Token = "0x40004BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int handIndex;

	[Token(Token = "0x40004BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool pinching;

	[Token(Token = "0x600034F")]
	[Address(RVA = "0xB438C8", Offset = "0xB438C8", VA = "0xB438C8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0xB43BAC", Offset = "0xB43BAC", VA = "0xB43BAC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0xB43EFC", Offset = "0xB43EFC", VA = "0xB43EFC")]
	private void FindHands()
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0xB44258", Offset = "0xB44258", VA = "0xB44258")]
	private void AlignWithHand(OVRHand hand, OVRSkeleton skeleton)
	{
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0xB4455C", Offset = "0xB4455C", VA = "0xB4455C")]
	private void AlignWithController(OVRInput.Controller controller)
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0xB44650", Offset = "0xB44650", VA = "0xB44650")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0xB4481C", Offset = "0xB4481C", VA = "0xB4481C")]
	public void Release()
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0xB44768", Offset = "0xB44768", VA = "0xB44768")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5921C8", Offset = "0x5921C8")]
	private IEnumerator FadeLighting(Color newColor, float sceneLightIntensity, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0xB44904", Offset = "0xB44904", VA = "0xB44904")]
	public FlashlightController()
	{
	}
}
[Token(Token = "0x20000DB")]
public class GrabObject : MonoBehaviour
{
	[Token(Token = "0x20000DC")]
	public enum ManipulationType
	{
		[Token(Token = "0x40004CE")]
		Default,
		[Token(Token = "0x40004CF")]
		ForcedHand,
		[Token(Token = "0x40004D0")]
		DollyHand,
		[Token(Token = "0x40004D1")]
		DollyAttached,
		[Token(Token = "0x40004D2")]
		HorizontalScaled,
		[Token(Token = "0x40004D3")]
		VerticalScaled,
		[Token(Token = "0x40004D4")]
		Menu
	}

	[Token(Token = "0x20000DD")]
	public delegate void GrabbedObject(OVRInput.Controller grabHand);

	[Token(Token = "0x20000DE")]
	public delegate void ReleasedObject();

	[Token(Token = "0x20000DF")]
	public delegate void SetCursorPosition(Vector3 cursorPosition);

	[Token(Token = "0x40004C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0x58F844", Offset = "0x58F844")]
	public string ObjectName;

	[Token(Token = "0x40004C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0x58F854", Offset = "0x58F854")]
	public string ObjectInstructions;

	[Token(Token = "0x40004C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ManipulationType objectManipulationType;

	[Token(Token = "0x40004C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool showLaserWhileGrabbed;

	[Token(Token = "0x40004C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Quaternion grabbedRotation;

	[Token(Token = "0x40004CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GrabbedObject GrabbedObjectDelegate;

	[Token(Token = "0x40004CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ReleasedObject ReleasedObjectDelegate;

	[Token(Token = "0x40004CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public SetCursorPosition CursorPositionDelegate;

	[Token(Token = "0x600035E")]
	[Address(RVA = "0xB481D8", Offset = "0xB481D8", VA = "0xB481D8")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0xB48234", Offset = "0xB48234", VA = "0xB48234")]
	public void Release()
	{
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0xB48248", Offset = "0xB48248", VA = "0xB48248")]
	public void CursorPos(Vector3 cursorPos)
	{
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0xB4825C", Offset = "0xB4825C", VA = "0xB4825C")]
	public GrabObject()
	{
	}
}
[Token(Token = "0x20000E0")]
public class HandMeshMask : MonoBehaviour
{
	[Token(Token = "0x40004D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRSkeleton referenceHand;

	[Token(Token = "0x40004D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material maskMaterial;

	[Token(Token = "0x40004D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F874", Offset = "0x58F874")]
	public int radialDivisions;

	[Token(Token = "0x40004D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F8AC", Offset = "0x58F8AC")]
	public float borderSize;

	[Token(Token = "0x40004D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F8E4", Offset = "0x58F8E4")]
	public float fingerTaper;

	[Token(Token = "0x40004DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F91C", Offset = "0x58F91C")]
	public float fingerTipLength;

	[Token(Token = "0x40004DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58F954", Offset = "0x58F954")]
	public float webOffset;

	[Token(Token = "0x40004DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float handScale;

	[Token(Token = "0x40004DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject maskMeshObject;

	[Token(Token = "0x40004DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Mesh maskMesh;

	[Token(Token = "0x40004DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] handVertices;

	[Token(Token = "0x40004E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector2[] handUVs;

	[Token(Token = "0x40004E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color32[] handColors;

	[Token(Token = "0x40004E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int[] handTriangles;

	[Token(Token = "0x40004E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int vertCounter;

	[Token(Token = "0x40004E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int triCounter;

	[Token(Token = "0x600036E")]
	[Address(RVA = "0xB491DC", Offset = "0xB491DC", VA = "0xB491DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0xB493DC", Offset = "0xB493DC", VA = "0xB493DC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0xB495E8", Offset = "0xB495E8", VA = "0xB495E8")]
	private void CreateHandMesh()
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0xB49C6C", Offset = "0xB49C6C", VA = "0xB49C6C")]
	private void AddKnuckleMesh(int knuckleVerts, float point1scale, float point2scale, Vector3 point1, Vector3 point2)
	{
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0xB4A29C", Offset = "0xB4A29C", VA = "0xB4A29C")]
	private void AddPalmMesh(int knuckleVerts)
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0xB4C918", Offset = "0xB4C918", VA = "0xB4C918")]
	private void AddVertex(Vector3 position, Vector2 uv, Color color)
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0xB4C9D4", Offset = "0xB4C9D4", VA = "0xB4C9D4")]
	public HandMeshMask()
	{
	}
}
[Token(Token = "0x20000E1")]
public class HandMeshUI : MonoBehaviour
{
	[Token(Token = "0x40004E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SphereCollider[] knobs;

	[Token(Token = "0x40004E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMesh[] readouts;

	[Token(Token = "0x40004E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int rightHeldKnob;

	[Token(Token = "0x40004E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int leftHeldKnob;

	[Token(Token = "0x40004E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public OVRSkeleton leftHand;

	[Token(Token = "0x40004EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public OVRSkeleton rightHand;

	[Token(Token = "0x40004EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public HandMeshMask leftMask;

	[Token(Token = "0x40004EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public HandMeshMask rightMask;

	[Token(Token = "0x6000375")]
	[Address(RVA = "0xB4C9F8", Offset = "0xB4C9F8", VA = "0xB4C9F8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0xB4CD18", Offset = "0xB4CD18", VA = "0xB4CD18")]
	private void Update()
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0xB4CAA0", Offset = "0xB4CAA0", VA = "0xB4CAA0")]
	private void SetSliderValue(int sliderID, float value, bool isNormalized)
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0xB4D108", Offset = "0xB4D108", VA = "0xB4D108")]
	private void CheckForHands()
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0xB4D5F8", Offset = "0xB4D5F8", VA = "0xB4D5F8")]
	public HandMeshUI()
	{
	}
}
[Token(Token = "0x20000E2")]
public class ObjectManipulator : MonoBehaviour
{
	[Token(Token = "0x20000E3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CC30", Offset = "0x58CC30")]
	private sealed class <StartDemo>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ObjectManipulator <>4__this;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <fadeTime>5__3;

		[Token(Token = "0x1700004D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000389")]
			[Address(RVA = "0xF3C87C", Offset = "0xF3C87C", VA = "0xF3C87C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600038B")]
			[Address(RVA = "0xF3C8C4", Offset = "0xF3C8C4", VA = "0xF3C8C4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xF3C5AC", Offset = "0xF3C5AC", VA = "0xF3C5AC")]
		[DebuggerHidden]
		public <StartDemo>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xF3C5D8", Offset = "0xF3C5D8", VA = "0xF3C5D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xF3C5DC", Offset = "0xF3C5DC", VA = "0xF3C5DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xF3C884", Offset = "0xF3C884", VA = "0xF3C884", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRInput.Controller controller;

	[Token(Token = "0x40004EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject hoverObject;

	[Token(Token = "0x40004EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject grabObject;

	[Token(Token = "0x40004F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float grabTime;

	[Token(Token = "0x40004F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 localGrabOffset;

	[Token(Token = "0x40004F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Quaternion localGrabRotation;

	[Token(Token = "0x40004F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 camGrabPosition;

	[Token(Token = "0x40004F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion camGrabRotation;

	[Token(Token = "0x40004F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 handGrabPosition;

	[Token(Token = "0x40004F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Quaternion handGrabRotation;

	[Token(Token = "0x40004F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector3 cursorPosition;

	[Token(Token = "0x40004F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float rotationOffset;

	[Token(Token = "0x40004F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public LineRenderer laser;

	[Token(Token = "0x40004FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Transform objectInfo;

	[Token(Token = "0x40004FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TextMesh objectNameLabel;

	[Token(Token = "0x40004FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public TextMesh objectInstructionsLabel;

	[Token(Token = "0x40004FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Image objectInfoBG;

	[Token(Token = "0x40004FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject demoObjects;

	[Token(Token = "0x40004FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public OVRPassthroughLayer passthrough;

	[Token(Token = "0x600037A")]
	[Address(RVA = "0xD893D0", Offset = "0xD893D0", VA = "0xD893D0")]
	private void Start()
	{
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0xD89608", Offset = "0xD89608", VA = "0xD89608")]
	private void Update()
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0xD8A258", Offset = "0xD8A258", VA = "0xD8A258")]
	private void GrabHoverObject(GameObject grbObj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0xD8AE60", Offset = "0xD8AE60", VA = "0xD8AE60")]
	private void ReleaseObject()
	{
	}

	[Token(Token = "0x600037E")]
	[Address(RVA = "0xD89590", Offset = "0xD89590", VA = "0xD89590")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x592278", Offset = "0x592278")]
	private IEnumerator StartDemo()
	{
		return null;
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0xD89874", Offset = "0xD89874", VA = "0xD89874")]
	private void FindHoverObject(Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0xD8A51C", Offset = "0xD8A51C", VA = "0xD8A51C")]
	private void ManipulateObject(GameObject obj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0xD8B124", Offset = "0xD8B124", VA = "0xD8B124")]
	private void ClampGrabOffset(ref Vector3 localOffset, float thumbY)
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0xD8B1B0", Offset = "0xD8B1B0", VA = "0xD8B1B0")]
	private Vector3 ClampScale(Vector3 localScale, Vector2 thumb)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0xD8B1E0", Offset = "0xD8B1E0", VA = "0xD8B1E0")]
	private void CheckForDominantHand()
	{
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0xD8AFEC", Offset = "0xD8AFEC", VA = "0xD8AFEC")]
	private void AssignInstructions(GrabObject targetObject)
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0xD8B304", Offset = "0xD8B304", VA = "0xD8B304")]
	public ObjectManipulator()
	{
	}
}
[Token(Token = "0x20000E4")]
public class OverlayPassthrough : MonoBehaviour
{
	[Token(Token = "0x4000505")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x600038C")]
	[Address(RVA = "0xD8B3FC", Offset = "0xD8B3FC", VA = "0xD8B3FC")]
	private void Start()
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0xD8B594", Offset = "0xD8B594", VA = "0xD8B594")]
	private void Update()
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0xD8B65C", Offset = "0xD8B65C", VA = "0xD8B65C")]
	public OverlayPassthrough()
	{
	}
}
[Token(Token = "0x20000E5")]
public class PassthroughBrush : MonoBehaviour
{
	[Token(Token = "0x20000E6")]
	public enum BrushState
	{
		[Token(Token = "0x4000511")]
		Idle,
		[Token(Token = "0x4000512")]
		Inking
	}

	[Token(Token = "0x4000506")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x4000507")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject lineSegmentPrefab;

	[Token(Token = "0x4000508")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject lineContainer;

	[Token(Token = "0x4000509")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool forceActive;

	[Token(Token = "0x400050A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LineRenderer currentLineSegment;

	[Token(Token = "0x400050B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Vector3> inkPositions;

	[Token(Token = "0x400050C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float minInkDist;

	[Token(Token = "0x400050D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float strokeWidth;

	[Token(Token = "0x400050E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float strokeLength;

	[Token(Token = "0x400050F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private BrushState brushStatus;

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x84749C", Offset = "0x84749C", VA = "0x84749C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0x8474A4", Offset = "0x8474A4", VA = "0x8474A4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0x84778C", Offset = "0x84778C", VA = "0x84778C")]
	private void StartLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0x847984", Offset = "0x847984", VA = "0x847984")]
	private void UpdateLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0x847B2C", Offset = "0x847B2C", VA = "0x847B2C")]
	public void ClearLines()
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0x847698", Offset = "0x847698", VA = "0x847698")]
	public void UndoInkLine()
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0x847C08", Offset = "0x847C08", VA = "0x847C08")]
	public PassthroughBrush()
	{
	}
}
[Token(Token = "0x20000E7")]
public class PassthroughController : MonoBehaviour
{
	[Token(Token = "0x4000513")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x6000396")]
	[Address(RVA = "0x847CA0", Offset = "0x847CA0", VA = "0x847CA0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0x847E38", Offset = "0x847E38", VA = "0x847E38")]
	private void Update()
	{
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0x847F9C", Offset = "0x847F9C", VA = "0x847F9C")]
	public PassthroughController()
	{
	}
}
[Token(Token = "0x20000E8")]
public class PassthroughProjectionSurface : MonoBehaviour
{
	[Token(Token = "0x4000514")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000515")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x4000516")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MeshRenderer quadOutline;

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x847FA4", Offset = "0x847FA4", VA = "0x847FA4")]
	private void Start()
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x8481B8", Offset = "0x8481B8", VA = "0x8481B8")]
	private void Update()
	{
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x848388", Offset = "0x848388", VA = "0x848388")]
	public PassthroughProjectionSurface()
	{
	}
}
[Token(Token = "0x20000E9")]
public class PassthroughStyler : MonoBehaviour
{
	[Token(Token = "0x20000EA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CC40", Offset = "0x58CC40")]
	private sealed class <FadeToCurrentStyle>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timer>5__2;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <brightness>5__3;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <contrast>5__4;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <posterize>5__5;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Color <edgeCol>5__6;

		[Token(Token = "0x1700004F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0xF3E248", Offset = "0xF3E248", VA = "0xF3E248", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0xF3E290", Offset = "0xF3E290", VA = "0xF3E290", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xF3E064", Offset = "0xF3E064", VA = "0xF3E064")]
		[DebuggerHidden]
		public <FadeToCurrentStyle>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xF3E090", Offset = "0xF3E090", VA = "0xF3E090", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xF3E094", Offset = "0xF3E094", VA = "0xF3E094", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xF3E250", Offset = "0xF3E250", VA = "0xF3E250", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000EB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CC50", Offset = "0x58CC50")]
	private sealed class <FadeToDefaultPassthrough>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timer>5__2;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <brightness>5__3;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <contrast>5__4;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <posterize>5__5;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Color <edgeCol>5__6;

		[Token(Token = "0x17000051")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0xF3E4BC", Offset = "0xF3E4BC", VA = "0xF3E4BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0xF3E504", Offset = "0xF3E504", VA = "0xF3E504", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xF3E298", Offset = "0xF3E298", VA = "0xF3E298")]
		[DebuggerHidden]
		public <FadeToDefaultPassthrough>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xF3E2C4", Offset = "0xF3E2C4", VA = "0xF3E2C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xF3E2C8", Offset = "0xF3E2C8", VA = "0xF3E2C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xF3E4C4", Offset = "0xF3E4C4", VA = "0xF3E4C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000517")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x4000518")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000519")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerator fadeIn;

	[Token(Token = "0x400051A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator fadeOut;

	[Token(Token = "0x400051B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RectTransform[] menuOptions;

	[Token(Token = "0x400051C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RectTransform colorWheel;

	[Token(Token = "0x400051D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D colorTexture;

	[Token(Token = "0x400051E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 cursorPosition;

	[Token(Token = "0x400051F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool settingColor;

	[Token(Token = "0x4000520")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color savedColor;

	[Token(Token = "0x4000521")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float savedBrightness;

	[Token(Token = "0x4000522")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float savedContrast;

	[Token(Token = "0x4000523")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float savedPosterize;

	[Token(Token = "0x4000524")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public CanvasGroup mainCanvas;

	[Token(Token = "0x4000525")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject[] compactObjects;

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x848390", Offset = "0x848390", VA = "0x848390")]
	private void Start()
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0x8486C8", Offset = "0x8486C8", VA = "0x8486C8")]
	private void Update()
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x848920", Offset = "0x848920", VA = "0x848920")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x848AA4", Offset = "0x848AA4", VA = "0x848AA4")]
	public void Release()
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x848A1C", Offset = "0x848A1C", VA = "0x848A1C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x592328", Offset = "0x592328")]
	private IEnumerator FadeToCurrentStyle(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x848B94", Offset = "0x848B94", VA = "0x848B94")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x592388", Offset = "0x592388")]
	private IEnumerator FadeToDefaultPassthrough(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x848C1C", Offset = "0x848C1C", VA = "0x848C1C")]
	public void OnBrightnessChanged(float newValue)
	{
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x848C3C", Offset = "0x848C3C", VA = "0x848C3C")]
	public void OnContrastChanged(float newValue)
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x848C5C", Offset = "0x848C5C", VA = "0x848C5C")]
	public void OnPosterizeChanged(float newValue)
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x848C7C", Offset = "0x848C7C", VA = "0x848C7C")]
	public void OnAlphaChanged(float newValue)
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x84864C", Offset = "0x84864C", VA = "0x84864C")]
	private void ShowFullMenu(bool doShow)
	{
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x848CE0", Offset = "0x848CE0", VA = "0x848CE0")]
	public void Cursor(Vector3 cP)
	{
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x848CEC", Offset = "0x848CEC", VA = "0x848CEC")]
	public void DoColorDrag(bool doDrag)
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x8486E0", Offset = "0x8486E0", VA = "0x8486E0")]
	public void GetColorFromWheel()
	{
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x848CF8", Offset = "0x848CF8", VA = "0x848CF8")]
	public PassthroughStyler()
	{
	}
}
[Token(Token = "0x20000EC")]
public class PassthroughSurface : MonoBehaviour
{
	[Token(Token = "0x4000538")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000539")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x848D3C", Offset = "0x848D3C", VA = "0x848D3C")]
	private void Start()
	{
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x848DFC", Offset = "0x848DFC", VA = "0x848DFC")]
	public PassthroughSurface()
	{
	}
}
[Token(Token = "0x20000ED")]
public class SPPquad : MonoBehaviour
{
	[Token(Token = "0x400053A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x400053B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x400053C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRInput.Controller controllerHand;

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x850FE4", Offset = "0x850FE4", VA = "0x850FE4")]
	private void Start()
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x851228", Offset = "0x851228", VA = "0x851228")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x851280", Offset = "0x851280", VA = "0x851280")]
	public void Release()
	{
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x8512CC", Offset = "0x8512CC", VA = "0x8512CC")]
	public SPPquad()
	{
	}
}
[Token(Token = "0x20000EE")]
public class SceneSampler : MonoBehaviour
{
	[Token(Token = "0x400053D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int currentSceneIndex;

	[Token(Token = "0x400053E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject displayText;

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x8516C0", Offset = "0x8516C0", VA = "0x8516C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x851738", Offset = "0x851738", VA = "0x851738")]
	private void Update()
	{
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x851A5C", Offset = "0x851A5C", VA = "0x851A5C")]
	public SceneSampler()
	{
	}
}
[Token(Token = "0x20000EF")]
public class SelectivePassthroughExperience : MonoBehaviour
{
	[Token(Token = "0x400053F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject leftMaskObject;

	[Token(Token = "0x4000540")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject rightMaskObject;

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x851F5C", Offset = "0x851F5C", VA = "0x851F5C")]
	private void Update()
	{
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x8523E4", Offset = "0x8523E4", VA = "0x8523E4")]
	public SelectivePassthroughExperience()
	{
	}
}
[Token(Token = "0x20000F0")]
public class Anchor : MonoBehaviour
{
	[Token(Token = "0x4000541")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ulong anchorHandle_;

	[Token(Token = "0x4000542")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Canvas canvas_;

	[Token(Token = "0x4000543")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform pivot_;

	[Token(Token = "0x4000544")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject anchorMenu_;

	[Token(Token = "0x4000545")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool isSelected_;

	[Token(Token = "0x4000546")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool isHovered_;

	[Token(Token = "0x4000547")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private TextMeshProUGUI anchorName_;

	[Token(Token = "0x4000548")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject saveIcon_;

	[Token(Token = "0x4000549")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Image labelImage_;

	[Token(Token = "0x400054A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Color labelBaseColor_;

	[Token(Token = "0x400054B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Color labelHighlightColor_;

	[Token(Token = "0x400054C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Color labelSelectedColor_;

	[Token(Token = "0x400054D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private AnchorUIManager uiManager_;

	[Token(Token = "0x400054E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private MeshRenderer[] renderers_;

	[Token(Token = "0x400054F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private int menuIndex_;

	[Token(Token = "0x4000550")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private List<Button> buttonList_;

	[Token(Token = "0x4000551")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Button selectedButton_;

	[Token(Token = "0x17000053")]
	public ulong anchorHandle
	{
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x14079B8", Offset = "0x14079B8", VA = "0x14079B8")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x14079C0", Offset = "0x14079C0", VA = "0x14079C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x1407AA8", Offset = "0x1407AA8", VA = "0x1407AA8")]
	private void Update()
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x1407D10", Offset = "0x1407D10", VA = "0x1407D10")]
	public void OnSaveLocalButtonPressed()
	{
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x1407D78", Offset = "0x1407D78", VA = "0x1407D78")]
	public void OnHideButtonPressed()
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x1407DDC", Offset = "0x1407DDC", VA = "0x1407DDC")]
	public void OnEraseButtonPressed()
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x1407E40", Offset = "0x1407E40", VA = "0x1407E40")]
	public void OnHoverStart()
	{
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x1407F48", Offset = "0x1407F48", VA = "0x1407F48")]
	public void OnHoverEnd()
	{
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x1408068", Offset = "0x1408068", VA = "0x1408068")]
	public void OnSelect()
	{
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x140819C", Offset = "0x140819C", VA = "0x140819C")]
	public void SetAnchorHandle(ulong handle)
	{
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x1408230", Offset = "0x1408230", VA = "0x1408230")]
	public void ShowSaveIcon()
	{
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x1407AEC", Offset = "0x1407AEC", VA = "0x1407AEC")]
	private void BillboardPanel(Transform panel)
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x1407C00", Offset = "0x1407C00", VA = "0x1407C00")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x1408250", Offset = "0x1408250", VA = "0x1408250")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x1408368", Offset = "0x1408368", VA = "0x1408368")]
	public Anchor()
	{
	}
}
[Token(Token = "0x20000F1")]
public class AnchorHelpers
{
	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x1408370", Offset = "0x1408370", VA = "0x1408370")]
	public static string UuidToString(byte[] encodedMessage)
	{
		return null;
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x1408614", Offset = "0x1408614", VA = "0x1408614")]
	public static byte[] StringToUuid(string str)
	{
		return null;
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x140878C", Offset = "0x140878C", VA = "0x140878C")]
	private static int GetHexVal(char hex)
	{
		return default(int);
	}
}
[Token(Token = "0x20000F2")]
public abstract class AnchorSession : MonoBehaviour
{
	[Token(Token = "0x20000F3")]
	public enum StorageLocation
	{
		[Token(Token = "0x4000559")]
		LOCAL
	}

	[Token(Token = "0x4000552")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AnchorSession Instance;

	[Token(Token = "0x4000553")]
	public const ulong kInvalidHandle = ulong.MaxValue;

	[Token(Token = "0x4000554")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Dictionary<ulong, Anchor> handleToAnchor;

	[Token(Token = "0x4000555")]
	protected const int maxEvents = 5;

	[Token(Token = "0x4000556")]
	protected const float eventPollingRate = 0.1f;

	[Token(Token = "0x4000557")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected GameObject anchorPrefab_;

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x1408850", Offset = "0x1408850", VA = "0x1408850", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x1408584", Offset = "0x1408584", VA = "0x1408584")]
	public static void Log(string message)
	{
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x1408958", Offset = "0x1408958", VA = "0x1408958")]
	protected static bool isFlagSet(uint bitset, uint flag)
	{
		return default(bool);
	}

	[Token(Token = "0x60003D7")]
	public abstract ulong CreateSpatialAnchor(Transform T_UnityWorld_Anchor);

	[Token(Token = "0x60003D8")]
	public abstract void DestroyAnchor(ulong anchorHandle);

	[Token(Token = "0x60003D9")]
	public abstract void SaveAnchor(ulong anchorHandle, StorageLocation location);

	[Token(Token = "0x60003DA")]
	public abstract void EraseAnchor(ulong anchorHandle);

	[Token(Token = "0x60003DB")]
	public abstract void QueryAllLocalAnchors();

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x1408964", Offset = "0x1408964", VA = "0x1408964")]
	protected AnchorSession()
	{
	}
}
[Token(Token = "0x20000F4")]
public class AnchorSpawner : MonoBehaviour
{
	[Token(Token = "0x400055A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AnchorSpawner Instance;

	[Token(Token = "0x400055B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject anchorPrefab_;

	[Token(Token = "0x17000054")]
	public GameObject AnchorPrefab
	{
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x14089E8", Offset = "0x14089E8", VA = "0x14089E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x14089F0", Offset = "0x14089F0", VA = "0x14089F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x1408AF0", Offset = "0x1408AF0", VA = "0x1408AF0")]
	public void PlaceAnchorAtTransform(Transform transform)
	{
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x1408D24", Offset = "0x1408D24", VA = "0x1408D24")]
	public AnchorSpawner()
	{
	}
}
[Token(Token = "0x20000F5")]
public class AnchorUIManager : MonoBehaviour
{
	[Token(Token = "0x20000F6")]
	public enum AnchorMode
	{
		[Token(Token = "0x400056E")]
		Create,
		[Token(Token = "0x400056F")]
		Select
	}

	[Token(Token = "0x20000F7")]
	private delegate void PrimaryPressDelegate();

	[Token(Token = "0x400055C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AnchorUIManager Instance;

	[Token(Token = "0x400055D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject createModeButton_;

	[Token(Token = "0x400055E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject selectModeButton_;

	[Token(Token = "0x400055F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform trackedDevice_;

	[Token(Token = "0x4000560")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform raycastOrigin_;

	[Token(Token = "0x4000561")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool drawRaycast_;

	[Token(Token = "0x4000562")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private LineRenderer lineRenderer_;

	[Token(Token = "0x4000563")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Anchor hoveredAnchor_;

	[Token(Token = "0x4000564")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Anchor selectedAnchor_;

	[Token(Token = "0x4000565")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private AnchorMode mode_;

	[Token(Token = "0x4000566")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private List<Button> buttonList_;

	[Token(Token = "0x4000567")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int menuIndex_;

	[Token(Token = "0x4000568")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Button selectedButton_;

	[Token(Token = "0x4000569")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GameObject placementPreview_;

	[Token(Token = "0x400056A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Transform anchorPlacementTransform_;

	[Token(Token = "0x400056B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private PrimaryPressDelegate primaryPressDelegate_;

	[Token(Token = "0x400056C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private bool isFocused_;

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x1408D2C", Offset = "0x1408D2C", VA = "0x1408D2C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x1408E04", Offset = "0x1408E04", VA = "0x1408E04")]
	private void Start()
	{
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x1408F70", Offset = "0x1408F70", VA = "0x1408F70")]
	private void Update()
	{
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x14093C4", Offset = "0x14093C4", VA = "0x14093C4")]
	public void OnCreateModeButtonPressed()
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x1409434", Offset = "0x1409434", VA = "0x1409434")]
	public void OnLoadAnchorsButtonPressed()
	{
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x1408EF8", Offset = "0x1408EF8", VA = "0x1408EF8")]
	private void ToggleCreateMode()
	{
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x14094BC", Offset = "0x14094BC", VA = "0x14094BC")]
	private void StartPlacementMode()
	{
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x1409544", Offset = "0x1409544", VA = "0x1409544")]
	private void EndPlacementMode()
	{
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x1409570", Offset = "0x1409570", VA = "0x1409570")]
	private void StartSelectMode()
	{
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x1409490", Offset = "0x1409490", VA = "0x1409490")]
	private void EndSelectMode()
	{
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x14092B4", Offset = "0x14092B4", VA = "0x14092B4")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x14096AC", Offset = "0x14096AC", VA = "0x14096AC")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x14095F8", Offset = "0x14095F8", VA = "0x14095F8")]
	private void ShowAnchorPreview()
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x1409618", Offset = "0x1409618", VA = "0x1409618")]
	private void HideAnchorPreview()
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x14097C4", Offset = "0x14097C4", VA = "0x14097C4")]
	private void PlaceAnchor()
	{
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x1409638", Offset = "0x1409638", VA = "0x1409638")]
	private void ShowRaycastLine()
	{
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x1409674", Offset = "0x1409674", VA = "0x1409674")]
	private void HideRaycastLine()
	{
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x140907C", Offset = "0x140907C", VA = "0x140907C")]
	private void ControllerRaycast()
	{
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x1409820", Offset = "0x1409820", VA = "0x1409820")]
	private void HoverAnchor(Anchor anchor)
	{
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x1409854", Offset = "0x1409854", VA = "0x1409854")]
	private void UnhoverAnchor()
	{
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x14098F0", Offset = "0x14098F0", VA = "0x14098F0")]
	private void SelectAnchor()
	{
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x1409A6C", Offset = "0x1409A6C", VA = "0x1409A6C")]
	public AnchorUIManager()
	{
	}
}
[Token(Token = "0x20000F8")]
public class SpatialAnchorSession : AnchorSession
{
	[Token(Token = "0x4000570")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Dictionary<ulong, ulong> locateAnchorRequest;

	[Token(Token = "0x4000571")]
	private const string numUuids = "numUuids";

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0x855B50", Offset = "0x855B50", VA = "0x855B50")]
	private void Start()
	{
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x855D9C", Offset = "0x855D9C", VA = "0x855D9C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0x855FE8", Offset = "0x855FE8", VA = "0x855FE8")]
	private void SpatialEntitySetComponentEnabled(ulong requestId, bool result, OVRPlugin.SpatialEntityComponentType componentType, ulong space)
	{
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0x8561F8", Offset = "0x8561F8", VA = "0x8561F8")]
	private void SpatialAnchorSaved(ulong requestId, ulong space, bool result, OVRPlugin.SpatialEntityUuid uuid)
	{
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x8566E8", Offset = "0x8566E8", VA = "0x8566E8")]
	private void SpatialEntityStorageErase(ulong requestId, bool result, OVRPlugin.SpatialEntityUuid uuid, OVRPlugin.SpatialEntityStorageLocation location)
	{
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0x856A18", Offset = "0x856A18", VA = "0x856A18")]
	private void SpatialEntityQueryResults(ulong requestId, int numResults, OVRPlugin.SpatialEntityQueryResult[] results)
	{
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0x85713C", Offset = "0x85713C", VA = "0x85713C")]
	private void SpatialEntityQueryComplete(ulong requestId, bool result, int numFound)
	{
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0x85660C", Offset = "0x85660C", VA = "0x85660C")]
	private string GetUuidString(OVRPlugin.SpatialEntityUuid uuid)
	{
		return null;
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0x856D00", Offset = "0x856D00", VA = "0x856D00")]
	private void tryEnableComponent(ulong anchorHandle, OVRPlugin.SpatialEntityComponentType type)
	{
	}

	[Token(Token = "0x6000404")]
	[Address(RVA = "0x8560D8", Offset = "0x8560D8", VA = "0x8560D8")]
	private void CreateAnchorGameobject(ulong anchorHandle)
	{
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0x857390", Offset = "0x857390", VA = "0x857390")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0x857640", Offset = "0x857640", VA = "0x857640", Slot = "5")]
	public override ulong CreateSpatialAnchor(Transform T_UnityWorld_Anchor)
	{
		return default(ulong);
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0x8577E0", Offset = "0x8577E0", VA = "0x8577E0", Slot = "6")]
	public override void DestroyAnchor(ulong anchorHandle)
	{
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0x85799C", Offset = "0x85799C", VA = "0x85799C", Slot = "8")]
	public override void EraseAnchor(ulong anchorHandle)
	{
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0x857B68", Offset = "0x857B68", VA = "0x857B68")]
	public void QueryAnchorByUuid()
	{
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0x857E60", Offset = "0x857E60", VA = "0x857E60", Slot = "9")]
	public override void QueryAllLocalAnchors()
	{
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0x857F50", Offset = "0x857F50", VA = "0x857F50", Slot = "7")]
	public override void SaveAnchor(ulong anchorHandle, StorageLocation location)
	{
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0x8580C0", Offset = "0x8580C0", VA = "0x8580C0")]
	public SpatialAnchorSession()
	{
	}
}
[Token(Token = "0x20000F9")]
public class StartMenu : MonoBehaviour
{
	[Token(Token = "0x20000FA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CC60", Offset = "0x58CC60")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int sceneIndex;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StartMenu <>4__this;

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xF3EC74", Offset = "0xF3EC74", VA = "0xF3EC74")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xF3EC7C", Offset = "0xF3EC7C", VA = "0xF3EC7C")]
		internal void <Start>b__0()
		{
		}
	}

	[Token(Token = "0x4000572")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVROverlay overlay;

	[Token(Token = "0x4000573")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVROverlay text;

	[Token(Token = "0x4000574")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig vrRig;

	[Token(Token = "0x600040D")]
	[Address(RVA = "0xB05D78", Offset = "0xB05D78", VA = "0xB05D78")]
	private void Start()
	{
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0xB05F94", Offset = "0xB05F94", VA = "0xB05F94")]
	private void LoadScene(int idx)
	{
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0xB060A4", Offset = "0xB060A4", VA = "0xB060A4")]
	public StartMenu()
	{
	}
}
namespace SplineMesh
{
	[Serializable]
	[Token(Token = "0x20000FB")]
	public class CubicBezierCurve
	{
		[Token(Token = "0x4000577")]
		private const int STEP_COUNT = 30;

		[Token(Token = "0x4000578")]
		private const float T_STEP = 1f / 30f;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<CurveSample> samples;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SplineNode n1;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SplineNode n2;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58FACC", Offset = "0x58FACC")]
		private float <Length>k__BackingField;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityEvent Changed;

		[Token(Token = "0x17000055")]
		public float Length
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x8635B0", Offset = "0x8635B0", VA = "0x8635B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592488", Offset = "0x592488")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x8635B8", Offset = "0x8635B8", VA = "0x8635B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592498", Offset = "0x592498")]
			private set
			{
			}
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x8635C0", Offset = "0x8635C0", VA = "0x8635C0")]
		public CubicBezierCurve(SplineNode n1, SplineNode n2)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x863944", Offset = "0x863944", VA = "0x863944")]
		public void ConnectEnd(SplineNode n2)
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x863A38", Offset = "0x863A38", VA = "0x863A38")]
		public Vector3 GetInverseDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x863A74", Offset = "0x863A74", VA = "0x863A74")]
		private Vector3 GetLocation(float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x863B48", Offset = "0x863B48", VA = "0x863B48")]
		private Vector3 GetTangent(float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x863C40", Offset = "0x863C40", VA = "0x863C40")]
		private Vector3 GetUp(float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x863CA8", Offset = "0x863CA8", VA = "0x863CA8")]
		private Vector2 GetScale(float t)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x863CF4", Offset = "0x863CF4", VA = "0x863CF4")]
		private float GetRoll(float t)
		{
			return default(float);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x86374C", Offset = "0x86374C", VA = "0x86374C")]
		private void ComputeSamples(object sender, EventArgs e)
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x863D28", Offset = "0x863D28", VA = "0x863D28")]
		private CurveSample CreateSample(float distance, float time)
		{
			return default(CurveSample);
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x863E80", Offset = "0x863E80", VA = "0x863E80")]
		public CurveSample GetSample(float time)
		{
			return default(CurveSample);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x8644F0", Offset = "0x8644F0", VA = "0x8644F0")]
		public CurveSample GetSampleAtDistance(float d)
		{
			return default(CurveSample);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x8641E8", Offset = "0x8641E8", VA = "0x8641E8")]
		private static void AssertTimeInBounds(float time)
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x86492C", Offset = "0x86492C", VA = "0x86492C")]
		public CurveSample GetProjectionSample(Vector3 pointToProject)
		{
			return default(CurveSample);
		}
	}
	[Token(Token = "0x20000FC")]
	public struct CurveSample
	{
		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly Vector3 location;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public readonly Vector3 tangent;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly Vector3 up;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public readonly Vector2 scale;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public readonly float roll;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly float distanceInCurve;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public readonly float timeInCurve;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Quaternion rotation;

		[Token(Token = "0x17000056")]
		public Quaternion Rotation
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x864EFC", Offset = "0x864EFC", VA = "0x864EFC")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x863E1C", Offset = "0x863E1C", VA = "0x863E1C")]
		public CurveSample(Vector3 location, Vector3 tangent, Vector3 up, Vector2 scale, float roll, float distanceInCurve, float timeInCurve)
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x865038", Offset = "0x865038", VA = "0x865038", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x865234", Offset = "0x865234", VA = "0x865234", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x86429C", Offset = "0x86429C", VA = "0x86429C")]
		public static bool operator ==(CurveSample cs1, CurveSample cs2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x864320", Offset = "0x864320", VA = "0x864320")]
		public static CurveSample Lerp(CurveSample a, CurveSample b, float t)
		{
			return default(CurveSample);
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x8652AC", Offset = "0x8652AC", VA = "0x8652AC")]
		public MeshVertex GetBent(MeshVertex vert)
		{
			return null;
		}
	}
	[Token(Token = "0x20000FD")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class Spline : MonoBehaviour
	{
		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<SplineNode> nodes;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public List<CubicBezierCurve> curves;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float Length;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool isLoop;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public UnityEvent CurveChanged;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SplineNode start;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SplineNode end;

		[Token(Token = "0x17000057")]
		public bool IsLoop
		{
			[Token(Token = "0x6000429")]
			[Address(RVA = "0xB01070", Offset = "0xB01070", VA = "0xB01070")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600042A")]
			[Address(RVA = "0xB01078", Offset = "0xB01078", VA = "0xB01078")]
			set
			{
			}
		}

		[Token(Token = "0x14000010")]
		public event ListChangeHandler<SplineNode> NodeListChanged
		{
			[Token(Token = "0x600042B")]
			[Address(RVA = "0xB012A0", Offset = "0xB012A0", VA = "0xB012A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5924A8", Offset = "0x5924A8")]
			add
			{
			}
			[Token(Token = "0x600042C")]
			[Address(RVA = "0xB01340", Offset = "0xB01340", VA = "0xB01340")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5924B8", Offset = "0x5924B8")]
			remove
			{
			}
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xB013E0", Offset = "0xB013E0", VA = "0xB013E0")]
		private void Reset()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xB019CC", Offset = "0xB019CC", VA = "0xB019CC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xB01BF0", Offset = "0xB01BF0", VA = "0xB01BF0")]
		public ReadOnlyCollection<CubicBezierCurve> GetCurves()
		{
			return null;
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xB01828", Offset = "0xB01828", VA = "0xB01828")]
		private void RaiseNodeListChanged(ListChangedEventArgs<SplineNode> args)
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xB0189C", Offset = "0xB0189C", VA = "0xB0189C")]
		private void UpdateAfterCurveChanged()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xB01C44", Offset = "0xB01C44", VA = "0xB01C44")]
		public CurveSample GetSample(float t)
		{
			return default(CurveSample);
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xB01E4C", Offset = "0xB01E4C", VA = "0xB01E4C")]
		public CubicBezierCurve GetCurve(float t)
		{
			return null;
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xB01D04", Offset = "0xB01D04", VA = "0xB01D04")]
		private int GetNodeIndexForTime(float t)
		{
			return default(int);
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xB019D0", Offset = "0xB019D0", VA = "0xB019D0")]
		public void RefreshCurves()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xB01ED0", Offset = "0xB01ED0", VA = "0xB01ED0")]
		public CurveSample GetSampleAtDistance(float d)
		{
			return default(CurveSample);
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xB015D0", Offset = "0xB015D0", VA = "0xB015D0")]
		public void AddNode(SplineNode node)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xB02174", Offset = "0xB02174", VA = "0xB02174")]
		public void InsertNode(int index, SplineNode node)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xB02480", Offset = "0xB02480", VA = "0xB02480")]
		public void RemoveNode(SplineNode node)
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xB01084", Offset = "0xB01084", VA = "0xB01084")]
		private void updateLoopBinding()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xB02914", Offset = "0xB02914", VA = "0xB02914")]
		private void StartNodeChanged(object sender, EventArgs e)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xB02E6C", Offset = "0xB02E6C", VA = "0xB02E6C")]
		private void EndNodeChanged(object sender, EventArgs e)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xB02FB8", Offset = "0xB02FB8", VA = "0xB02FB8")]
		public CurveSample GetProjectionSample(Vector3 pointToProject)
		{
			return default(CurveSample);
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xB032C0", Offset = "0xB032C0", VA = "0xB032C0")]
		public Spline()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public enum ListChangeType
	{
		[Token(Token = "0x400058F")]
		Add,
		[Token(Token = "0x4000590")]
		Insert,
		[Token(Token = "0x4000591")]
		Remove,
		[Token(Token = "0x4000592")]
		clear
	}
	[Token(Token = "0x20000FF")]
	public class ListChangedEventArgs<T> : EventArgs
	{
		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ListChangeType type;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public List<T> newItems;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public List<T> removedItems;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int insertIndex;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int removeIndex;

		[Token(Token = "0x600043F")]
		public ListChangedEventArgs()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public delegate void ListChangeHandler<T2>(object sender, ListChangedEventArgs<T2> args);
	[Serializable]
	[Token(Token = "0x2000101")]
	public class SplineNode
	{
		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Vector3 position;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Vector3 direction;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 up;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Vector2 scale;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float roll;

		[Token(Token = "0x17000058")]
		public Vector3 Position
		{
			[Token(Token = "0x6000444")]
			[Address(RVA = "0xB05080", Offset = "0xB05080", VA = "0xB05080")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000445")]
			[Address(RVA = "0xB02A60", Offset = "0xB02A60", VA = "0xB02A60")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public Vector3 Direction
		{
			[Token(Token = "0x6000446")]
			[Address(RVA = "0xB0508C", Offset = "0xB0508C", VA = "0xB0508C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000447")]
			[Address(RVA = "0xB02B3C", Offset = "0xB02B3C", VA = "0xB02B3C")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public Vector3 Up
		{
			[Token(Token = "0x6000448")]
			[Address(RVA = "0xB05098", Offset = "0xB05098", VA = "0xB05098")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000449")]
			[Address(RVA = "0xB02D90", Offset = "0xB02D90", VA = "0xB02D90")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public Vector2 Scale
		{
			[Token(Token = "0x600044A")]
			[Address(RVA = "0xB050A4", Offset = "0xB050A4", VA = "0xB050A4")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600044B")]
			[Address(RVA = "0xB02CCC", Offset = "0xB02CCC", VA = "0xB02CCC")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public float Roll
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0xB050AC", Offset = "0xB050AC", VA = "0xB050AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600044D")]
			[Address(RVA = "0xB02C18", Offset = "0xB02C18", VA = "0xB02C18")]
			set
			{
			}
		}

		[Token(Token = "0x14000011")]
		[HideInInspector]
		public event EventHandler Changed
		{
			[Token(Token = "0x600044F")]
			[Address(RVA = "0xB02874", Offset = "0xB02874", VA = "0xB02874")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5924C8", Offset = "0x5924C8")]
			add
			{
			}
			[Token(Token = "0x6000450")]
			[Address(RVA = "0xB027D4", Offset = "0xB027D4", VA = "0xB027D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5924D8", Offset = "0x5924D8")]
			remove
			{
			}
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xB01538", Offset = "0xB01538", VA = "0xB01538")]
		public SplineNode(Vector3 position, Vector3 direction)
		{
		}
	}
	[Token(Token = "0x2000102")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x58CCA8", Offset = "0x58CCA8")]
	public class SplineSmoother : MonoBehaviour
	{
		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Spline spline;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x58FB7C", Offset = "0x58FB7C")]
		public float curvature;

		[Token(Token = "0x1700005D")]
		private Spline Spline
		{
			[Token(Token = "0x6000451")]
			[Address(RVA = "0xB050B4", Offset = "0xB050B4", VA = "0xB050B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xB05168", Offset = "0xB05168", VA = "0xB05168")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xB05284", Offset = "0xB05284", VA = "0xB05284")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xB05480", Offset = "0xB05480", VA = "0xB05480")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xB05674", Offset = "0xB05674", VA = "0xB05674")]
		private void Spline_NodeListChanged(object sender, ListChangedEventArgs<SplineNode> args)
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xB0592C", Offset = "0xB0592C", VA = "0xB0592C")]
		private void OnNodeChanged(object sender, EventArgs e)
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xB05AC8", Offset = "0xB05AC8", VA = "0xB05AC8")]
		private void SmoothNode(SplineNode node)
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xB0516C", Offset = "0xB0516C", VA = "0xB0516C")]
		private void SmoothAll()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xB05D5C", Offset = "0xB05D5C", VA = "0xB05D5C")]
		public SplineSmoother()
		{
		}
	}
	[Token(Token = "0x2000103")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x58CD28", Offset = "0x58CD28")]
	public class ExampleContortAlong : MonoBehaviour
	{
		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Spline spline;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float rate;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MeshBender meshBender;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public GameObject generated;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Mesh mesh;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Material material;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 scale;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float DurationInSecond;

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x86B61C", Offset = "0x86B61C", VA = "0x86B61C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x86BA68", Offset = "0x86BA68", VA = "0x86BA68")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x86BA6C", Offset = "0x86BA6C", VA = "0x86BA6C")]
		private void EditorUpdate()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x86BAC4", Offset = "0x86BAC4", VA = "0x86BAC4")]
		private void Contort()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x86B624", Offset = "0x86B624", VA = "0x86B624")]
		private void Init()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x86BB7C", Offset = "0x86BB7C", VA = "0x86BB7C")]
		public ExampleContortAlong()
		{
		}
	}
	[Token(Token = "0x2000104")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x58CD98", Offset = "0x58CD98")]
	[ExecuteInEditMode]
	public class ExampleFollowSpline : MonoBehaviour
	{
		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GameObject generated;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Spline spline;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float rate;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject Follower;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float DurationInSecond;

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x86BB84", Offset = "0x86BB84", VA = "0x86BB84")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x86BD38", Offset = "0x86BD38", VA = "0x86BD38")]
		private void EditorUpdate()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x86BDCC", Offset = "0x86BDCC", VA = "0x86BDCC")]
		private void PlaceFollower()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x86BED4", Offset = "0x86BED4", VA = "0x86BED4")]
		public ExampleFollowSpline()
		{
		}
	}
	[Token(Token = "0x2000105")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x58CE08", Offset = "0x58CE08")]
	[ExecuteInEditMode]
	public class ExampleGrowingRoot : MonoBehaviour
	{
		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GameObject generated;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Spline spline;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float rate;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MeshBender meshBender;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Mesh mesh;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Material material;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 scale;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float startScale;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float DurationInSecond;

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x86BEDC", Offset = "0x86BEDC", VA = "0x86BEDC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x86C32C", Offset = "0x86C32C", VA = "0x86C32C")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x86C330", Offset = "0x86C330", VA = "0x86C330")]
		private void EditorUpdate()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x86C388", Offset = "0x86C388", VA = "0x86C388")]
		private void Contort()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x86BEE4", Offset = "0x86BEE4", VA = "0x86BEE4")]
		private void Init()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x86C5F4", Offset = "0x86C5F4", VA = "0x86C5F4")]
		public ExampleGrowingRoot()
		{
		}
	}
	[Token(Token = "0x2000106")]
	[ExecuteInEditMode]
	[SelectionBase]
	[DisallowMultipleComponent]
	public class ExampleSower : MonoBehaviour
	{
		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GameObject generated;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Spline spline;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool toUpdate;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject prefab;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float scale;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float scaleRange;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float spacing;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float spacingRange;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float offset;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float offsetRange;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool isRandomYaw;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int randomSeed;

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x86C604", Offset = "0x86C604", VA = "0x86C604")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x86CB10", Offset = "0x86CB10", VA = "0x86CB10")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x86CB1C", Offset = "0x86CB1C", VA = "0x86CB1C")]
		private void Update()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x86CB48", Offset = "0x86CB48", VA = "0x86CB48")]
		public void Sow()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x86CF34", Offset = "0x86CF34", VA = "0x86CF34")]
		public ExampleSower()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x86CF50", Offset = "0x86CF50", VA = "0x86CF50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5924E8", Offset = "0x5924E8")]
		private void <OnEnable>b__12_0(object s, ListChangedEventArgs<SplineNode> e)
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x86D234", Offset = "0x86D234", VA = "0x86D234")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5924F8", Offset = "0x5924F8")]
		private void <OnEnable>b__12_1()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x86D240", Offset = "0x86D240", VA = "0x86D240")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592508", Offset = "0x592508")]
		private void <OnEnable>b__12_2()
		{
		}
	}
	[Token(Token = "0x2000107")]
	[DisallowMultipleComponent]
	public class ExampleTentacle : MonoBehaviour
	{
		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Spline spline;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float startScale;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float endScale;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float startRoll;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float endRoll;

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x86D24C", Offset = "0x86D24C", VA = "0x86D24C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x86D2A8", Offset = "0x86D2A8", VA = "0x86D2A8")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x86D674", Offset = "0x86D674", VA = "0x86D674")]
		public ExampleTentacle()
		{
		}
	}
	[Token(Token = "0x2000108")]
	[ExecuteInEditMode]
	[SelectionBase]
	[DisallowMultipleComponent]
	public class ExampleTrack : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000109")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58CF18", Offset = "0x58CF18")]
		private sealed class <>c
		{
			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Transform, GameObject> <>9__8_0;

			[Token(Token = "0x600047C")]
			[Address(RVA = "0xF38114", Offset = "0xF38114", VA = "0xF38114")]
			public <>c()
			{
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0xF3811C", Offset = "0xF3811C", VA = "0xF3811C")]
			internal GameObject <CreateMeshes>b__8_0(Transform child)
			{
				return null;
			}
		}

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GameObject generated;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Spline spline;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool toUpdate;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<TrackSegment> segments;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool updateInPlayMode;

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x86D684", Offset = "0x86D684", VA = "0x86D684")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x86D9DC", Offset = "0x86D9DC", VA = "0x86D9DC")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x86DA58", Offset = "0x86DA58", VA = "0x86DA58")]
		private void Update()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x86DAA4", Offset = "0x86DAA4", VA = "0x86DAA4")]
		public void CreateMeshes()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x86E7B0", Offset = "0x86E7B0", VA = "0x86E7B0")]
		public ExampleTrack()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x86E834", Offset = "0x86E834", VA = "0x86E834")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592518", Offset = "0x592518")]
		private void <OnEnable>b__5_0(object s, ListChangedEventArgs<SplineNode> e)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200010A")]
	public class TrackSegment
	{
		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<TransformedMesh> transformedMeshes;

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xB0D324", Offset = "0xB0D324", VA = "0xB0D324")]
		public TrackSegment()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200010B")]
	public class TransformedMesh
	{
		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mesh mesh;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material material;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PhysicMaterial physicMaterial;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 translation;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 rotation;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 scale;

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xB0F460", Offset = "0xB0F460", VA = "0xB0F460")]
		public TransformedMesh()
		{
		}
	}
	[Token(Token = "0x200010C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x58CF28", Offset = "0x58CF28")]
	public class RopeBuilder : MonoBehaviour
	{
		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool toUpdate;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject generated;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Spline spline;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject firstSegment;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		public List<GameObject> wayPoints;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject segmentPrefab;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int segmentCount;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float segmentSpacing;

		[Token(Token = "0x1700005E")]
		private GameObject Generated
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x850444", Offset = "0x850444", VA = "0x850444")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x850648", Offset = "0x850648", VA = "0x850648")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x8506B0", Offset = "0x8506B0", VA = "0x8506B0")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x8506BC", Offset = "0x8506BC", VA = "0x8506BC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x850C4C", Offset = "0x850C4C", VA = "0x850C4C")]
		private void UpdateNodes()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x850968", Offset = "0x850968", VA = "0x850968")]
		private void UpdateSpline()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x850754", Offset = "0x850754", VA = "0x850754")]
		private void Generate()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x850F20", Offset = "0x850F20", VA = "0x850F20")]
		public RopeBuilder()
		{
		}
	}
	[Token(Token = "0x200010D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x58CF98", Offset = "0x58CF98")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x58CF98", Offset = "0x58CF98")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class ExtrusionSegment : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200010E")]
		public class Vertex
		{
			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector2 point;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector2 normal;

			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float uCoord;

			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float uCoord2;

			[Token(Token = "0x6000499")]
			[Address(RVA = "0xF3820C", Offset = "0xF3820C", VA = "0xF3820C")]
			public Vertex(Vector2 point, Vector2 normal, float uCoord)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200010F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E04C", Offset = "0x58E04C")]
		private sealed class <>c
		{
			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<MeshVertex, Vector3> <>9__31_0;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<MeshVertex, Vector3> <>9__31_1;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<MeshVertex, Vector2> <>9__31_2;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<MeshVertex, Vector2> <>9__31_3;

			[Token(Token = "0x600049B")]
			[Address(RVA = "0xF3819C", Offset = "0xF3819C", VA = "0xF3819C")]
			public <>c()
			{
			}

			[Token(Token = "0x600049C")]
			[Address(RVA = "0xF381A4", Offset = "0xF381A4", VA = "0xF381A4")]
			internal Vector3 <Compute>b__31_0(MeshVertex b)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600049D")]
			[Address(RVA = "0xF381C0", Offset = "0xF381C0", VA = "0xF381C0")]
			internal Vector3 <Compute>b__31_1(MeshVertex b)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600049E")]
			[Address(RVA = "0xF381DC", Offset = "0xF381DC", VA = "0xF381DC")]
			internal Vector2 <Compute>b__31_2(MeshVertex b)
			{
				return default(Vector2);
			}

			[Token(Token = "0x600049F")]
			[Address(RVA = "0xF381F4", Offset = "0xF381F4", VA = "0xF381F4")]
			internal Vector2 <Compute>b__31_3(MeshVertex b)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool isDirty;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MeshFilter mf;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Mesh result;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool useSpline;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CubicBezierCurve curve;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Spline spline;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float intervalStart;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float intervalEnd;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Vertex> shapeVertices;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float textureScale;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float textureOffset;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float sampleSpacing;

		[Token(Token = "0x1700005F")]
		public List<Vertex> ShapeVertices
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x86E96C", Offset = "0x86E96C", VA = "0x86E96C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x86E974", Offset = "0x86E974", VA = "0x86E974")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public float TextureScale
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x86E9A8", Offset = "0x86E9A8", VA = "0x86E9A8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x86E9B0", Offset = "0x86E9B0", VA = "0x86E9B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public float TextureOffset
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x86E9D0", Offset = "0x86E9D0", VA = "0x86E9D0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600048D")]
			[Address(RVA = "0x86E9D8", Offset = "0x86E9D8", VA = "0x86E9D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public float SampleSpacing
		{
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x86E9F8", Offset = "0x86E9F8", VA = "0x86E9F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600048F")]
			[Address(RVA = "0x86EA00", Offset = "0x86EA00", VA = "0x86EA00")]
			set
			{
			}
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x86EA90", Offset = "0x86EA90", VA = "0x86EA90")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x86EB98", Offset = "0x86EB98", VA = "0x86EB98")]
		public void SetInterval(CubicBezierCurve curve)
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x86ED0C", Offset = "0x86ED0C", VA = "0x86ED0C")]
		public void SetInterval(Spline spline, float intervalStart, float intervalEnd = 0f)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x86E99C", Offset = "0x86E99C", VA = "0x86E99C")]
		private void SetDirty()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x86F014", Offset = "0x86F014", VA = "0x86F014")]
		private void Update()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x86F040", Offset = "0x86F040", VA = "0x86F040")]
		public void ComputeIfNeeded()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x86FA28", Offset = "0x86FA28", VA = "0x86FA28")]
		private List<CurveSample> GetPath()
		{
			return null;
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x86F06C", Offset = "0x86F06C", VA = "0x86F06C")]
		public void Compute()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x86FC1C", Offset = "0x86FC1C", VA = "0x86FC1C")]
		public ExtrusionSegment()
		{
		}
	}
	[Token(Token = "0x2000110")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x58E05C", Offset = "0x58E05C")]
	public class MeshBender : MonoBehaviour
	{
		[Token(Token = "0x2000111")]
		public enum FillingMode
		{
			[Token(Token = "0x40005FF")]
			Once,
			[Token(Token = "0x4000600")]
			Repeat,
			[Token(Token = "0x4000601")]
			StretchToInterval
		}

		[Serializable]
		[Token(Token = "0x2000112")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E0DC", Offset = "0x58E0DC")]
		private sealed class <>c
		{
			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<MeshVertex, Vector3> <>9__25_0;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<MeshVertex, Vector3> <>9__25_1;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<MeshVertex, Vector3> <>9__26_0;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<MeshVertex, Vector3> <>9__26_1;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<MeshVertex, Vector3> <>9__27_0;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Func<MeshVertex, Vector3> <>9__27_1;

			[Token(Token = "0x60004B1")]
			[Address(RVA = "0xF3BEF8", Offset = "0xF3BEF8", VA = "0xF3BEF8")]
			public <>c()
			{
			}

			[Token(Token = "0x60004B2")]
			[Address(RVA = "0xF3BF00", Offset = "0xF3BF00", VA = "0xF3BF00")]
			internal Vector3 <FillOnce>b__25_0(MeshVertex b)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004B3")]
			[Address(RVA = "0xF3BF1C", Offset = "0xF3BF1C", VA = "0xF3BF1C")]
			internal Vector3 <FillOnce>b__25_1(MeshVertex b)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004B4")]
			[Address(RVA = "0xF3BF38", Offset = "0xF3BF38", VA = "0xF3BF38")]
			internal Vector3 <FillRepeat>b__26_0(MeshVertex b)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004B5")]
			[Address(RVA = "0xF3BF54", Offset = "0xF3BF54", VA = "0xF3BF54")]
			internal Vector3 <FillRepeat>b__26_1(MeshVertex b)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004B6")]
			[Address(RVA = "0xF3BF70", Offset = "0xF3BF70", VA = "0xF3BF70")]
			internal Vector3 <FillStretch>b__27_0(MeshVertex b)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004B7")]
			[Address(RVA = "0xF3BF8C", Offset = "0xF3BF8C", VA = "0xF3BF8C")]
			internal Vector3 <FillStretch>b__27_1(MeshVertex b)
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool isDirty;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Mesh result;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool useSpline;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Spline spline;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float intervalStart;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float intervalEnd;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CubicBezierCurve curve;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<float, CurveSample> sampleCache;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SourceMesh source;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FillingMode mode;

		[Token(Token = "0x17000063")]
		public SourceMesh Source
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0xFC13B4", Offset = "0xFC13B4", VA = "0xFC13B4")]
			get
			{
				return default(SourceMesh);
			}
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0xFC13C4", Offset = "0xFC13C4", VA = "0xFC13C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public FillingMode Mode
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0xFC1458", Offset = "0xFC1458", VA = "0xFC1458")]
			get
			{
				return default(FillingMode);
			}
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0xFC1460", Offset = "0xFC1460", VA = "0xFC1460")]
			set
			{
			}
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xFC147C", Offset = "0xFC147C", VA = "0xFC147C")]
		public void SetInterval(CubicBezierCurve curve)
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xFC15F0", Offset = "0xFC15F0", VA = "0xFC15F0")]
		public void SetInterval(Spline spline, float intervalStart, float intervalEnd = 0f)
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xFC18F8", Offset = "0xFC18F8", VA = "0xFC18F8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xFC1A8C", Offset = "0xFC1A8C", VA = "0xFC1A8C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xFC1A9C", Offset = "0xFC1A9C", VA = "0xFC1A9C")]
		public void ComputeIfNeeded()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xFC144C", Offset = "0xFC144C", VA = "0xFC144C")]
		private void SetDirty()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xFC1AAC", Offset = "0xFC1AAC", VA = "0xFC1AAC")]
		private void Compute()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xFC32FC", Offset = "0xFC32FC", VA = "0xFC32FC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xFC1AD8", Offset = "0xFC1AD8", VA = "0xFC1AD8")]
		private void FillOnce()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xFC2050", Offset = "0xFC2050", VA = "0xFC2050")]
		private void FillRepeat()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xFC29C8", Offset = "0xFC29C8", VA = "0xFC29C8")]
		private void FillStretch()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xFC3760", Offset = "0xFC3760", VA = "0xFC3760")]
		public MeshBender()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000113")]
	public class MeshVertex
	{
		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 position;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 normal;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 uv;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2 uv2;

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xFC8F80", Offset = "0xFC8F80", VA = "0xFC8F80")]
		public MeshVertex(Vector3 position, Vector3 normal, Vector2 uv)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xFC8FF8", Offset = "0xFC8FF8", VA = "0xFC8FF8")]
		public MeshVertex(Vector3 position, Vector3 normal)
		{
		}
	}
	[Token(Token = "0x2000114")]
	public struct SourceMesh
	{
		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 translation;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private Quaternion rotation;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 scale;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58FBB4", Offset = "0x58FBB4")]
		private readonly Mesh <Mesh>k__BackingField;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<MeshVertex> vertices;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int[] triangles;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float minX;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float length;

		[Token(Token = "0x17000065")]
		internal readonly Mesh Mesh
		{
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x855000", Offset = "0x855000", VA = "0x855000")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592528", Offset = "0x592528")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000066")]
		internal List<MeshVertex> Vertices
		{
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x855008", Offset = "0x855008", VA = "0x855008")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		internal int[] Triangles
		{
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x855528", Offset = "0x855528", VA = "0x855528")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		internal float MinX
		{
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x855558", Offset = "0x855558", VA = "0x855558")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000069")]
		internal float Length
		{
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x855588", Offset = "0x855588", VA = "0x855588")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x8555B8", Offset = "0x8555B8", VA = "0x8555B8")]
		private SourceMesh(Mesh mesh)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x85560C", Offset = "0x85560C", VA = "0x85560C")]
		private SourceMesh(SourceMesh other)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x855684", Offset = "0x855684", VA = "0x855684")]
		public static SourceMesh Build(Mesh mesh)
		{
			return default(SourceMesh);
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x8556BC", Offset = "0x8556BC", VA = "0x8556BC")]
		public SourceMesh Translate(Vector3 translation)
		{
			return default(SourceMesh);
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x855744", Offset = "0x855744", VA = "0x855744")]
		public SourceMesh Rotate(Quaternion rotation)
		{
			return default(SourceMesh);
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x8557D0", Offset = "0x8557D0", VA = "0x8557D0")]
		public SourceMesh Scale(Vector3 scale)
		{
			return default(SourceMesh);
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x855038", Offset = "0x855038", VA = "0x855038")]
		private void BuildData()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x855858", Offset = "0x855858", VA = "0x855858", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x855A54", Offset = "0x855A54", VA = "0x855A54", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x855ACC", Offset = "0x855ACC", VA = "0x855ACC")]
		public static bool operator ==(SourceMesh sm1, SourceMesh sm2)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000115")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x58E0EC", Offset = "0x58E0EC")]
	[ExecuteInEditMode]
	public class SplineExtrusion : MonoBehaviour
	{
		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Spline spline;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool toUpdate;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject generated;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<ExtrusionSegment.Vertex> shapeVertices;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Material material;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float textureScale;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float sampleSpacing;

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xB033C8", Offset = "0xB033C8", VA = "0xB033C8")]
		private void Reset()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xB03790", Offset = "0xB03790", VA = "0xB03790")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xB0352C", Offset = "0xB0352C", VA = "0xB0352C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xB038C4", Offset = "0xB038C4", VA = "0xB038C4")]
		private void Update()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xB038F0", Offset = "0xB038F0", VA = "0xB038F0")]
		private void GenerateMesh()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xB04074", Offset = "0xB04074", VA = "0xB04074")]
		public void SetToUpdate()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xB04080", Offset = "0xB04080", VA = "0xB04080")]
		public SplineExtrusion()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xB04118", Offset = "0xB04118", VA = "0xB04118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592560", Offset = "0x592560")]
		private void <OnEnable>b__9_0(object s, ListChangedEventArgs<SplineNode> e)
		{
		}
	}
	[Token(Token = "0x2000116")]
	[DisallowMultipleComponent]
	[SelectionBase]
	[ExecuteInEditMode]
	public class SplineMeshTiling : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000117")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E1A4", Offset = "0x58E1A4")]
		private sealed class <>c
		{
			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Transform, GameObject> <>9__16_0;

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0xF3EC50", Offset = "0xF3EC50", VA = "0xF3EC50")]
			public <>c()
			{
			}

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0xF3EC58", Offset = "0xF3EC58", VA = "0xF3EC58")]
			internal GameObject <CreateMeshes>b__16_0(Transform child)
			{
				return null;
			}
		}

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GameObject generated;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Spline spline;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool toUpdate;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58FBC4", Offset = "0x58FBC4")]
		public Mesh mesh;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58FBFC", Offset = "0x58FBFC")]
		public Material material;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58FC34", Offset = "0x58FC34")]
		public PhysicMaterial physicMaterial;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58FC6C", Offset = "0x58FC6C")]
		public Vector3 translation;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58FCA4", Offset = "0x58FCA4")]
		public Vector3 rotation;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58FCDC", Offset = "0x58FCDC")]
		public Vector3 scale;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58FD14", Offset = "0x58FD14")]
		public bool generateCollider;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58FD4C", Offset = "0x58FD4C")]
		public bool updateInPlayMode;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58FD84", Offset = "0x58FD84")]
		public bool curveSpace;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x58FDBC", Offset = "0x58FDBC")]
		public MeshBender.FillingMode mode;

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xB04124", Offset = "0xB04124", VA = "0xB04124")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xB04394", Offset = "0xB04394", VA = "0xB04394")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xB04410", Offset = "0xB04410", VA = "0xB04410")]
		private void Update()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xB0445C", Offset = "0xB0445C", VA = "0xB0445C")]
		public void CreateMeshes()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xB04B58", Offset = "0xB04B58", VA = "0xB04B58")]
		private GameObject FindOrCreate(string name)
		{
			return null;
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xB05030", Offset = "0xB05030", VA = "0xB05030")]
		public SplineMeshTiling()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xB05074", Offset = "0xB05074", VA = "0xB05074")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592570", Offset = "0x592570")]
		private void <OnEnable>b__13_0(object s, ListChangedEventArgs<SplineNode> e)
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class MeshUtility
	{
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xFC8E84", Offset = "0xFC8E84", VA = "0xFC8E84")]
		public static int[] GetReversedTriangles(Mesh mesh)
		{
			return null;
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xFC33A8", Offset = "0xFC33A8", VA = "0xFC33A8")]
		public static void Update(Mesh mesh, Mesh source, [Optional] IEnumerable<int> triangles, [Optional] IEnumerable<Vector3> vertices, [Optional] IEnumerable<Vector3> normals, [Optional] IEnumerable<Vector2> uv, [Optional] IEnumerable<Vector2> uv2, [Optional] IEnumerable<Vector2> uv3, [Optional] IEnumerable<Vector2> uv4, [Optional] IEnumerable<Vector2> uv5, [Optional] IEnumerable<Vector2> uv6, [Optional] IEnumerable<Vector2> uv7, [Optional] IEnumerable<Vector2> uv8)
		{
		}
	}
	[Token(Token = "0x2000119")]
	public static class UOUtility
	{
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xB0379C", Offset = "0xB0379C", VA = "0xB0379C")]
		public static GameObject Create(string name, GameObject parent, params Type[] components)
		{
			return null;
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xB0F670", Offset = "0xB0F670", VA = "0xB0F670")]
		public static GameObject Instantiate(GameObject prefab, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xB04F94", Offset = "0xB04F94", VA = "0xB04F94")]
		public static void Destroy(GameObject go)
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xB0F780", Offset = "0xB0F780", VA = "0xB0F780")]
		public static void Destroy(Component comp)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xB03F14", Offset = "0xB03F14", VA = "0xB03F14")]
		public static void DestroyChildren(GameObject go)
		{
		}
	}
}
namespace OculusSampleFramework
{
	[Token(Token = "0x200011A")]
	public class ColorGrabbable : OVRGrabbable
	{
		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Color COLOR_GRAB;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Color COLOR_HIGHLIGHT;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Color m_color;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshRenderer[] m_meshRenderers;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_highlight;

		[Token(Token = "0x1700006A")]
		public bool Highlight
		{
			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x861384", Offset = "0x861384", VA = "0x861384")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x86138C", Offset = "0x86138C", VA = "0x86138C")]
			set
			{
			}
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x861398", Offset = "0x861398", VA = "0x861398")]
		protected void UpdateColor()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x861560", Offset = "0x861560", VA = "0x861560", Slot = "4")]
		public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x861588", Offset = "0x861588", VA = "0x861588", Slot = "5")]
		public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x8615B0", Offset = "0x8615B0", VA = "0x8615B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x861460", Offset = "0x861460", VA = "0x861460")]
		private void SetColor(Color color)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x861884", Offset = "0x861884", VA = "0x861884")]
		public ColorGrabbable()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class DistanceGrabbable : OVRGrabbable
	{
		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string m_materialColorField;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GrabbableCrosshair m_crosshair;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GrabManager m_crosshairManager;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Renderer m_renderer;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MaterialPropertyBlock m_mpb;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_inRange;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool m_targeted;

		[Token(Token = "0x1700006B")]
		public bool InRange
		{
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x86903C", Offset = "0x86903C", VA = "0x86903C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004EC")]
			[Address(RVA = "0x869044", Offset = "0x869044", VA = "0x869044")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public bool Targeted
		{
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x8691C0", Offset = "0x8691C0", VA = "0x8691C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x8691C8", Offset = "0x8691C8", VA = "0x8691C8")]
			set
			{
			}
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x8691D4", Offset = "0x8691D4", VA = "0x8691D4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x869050", Offset = "0x869050", VA = "0x869050")]
		private void RefreshCrosshair()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x869340", Offset = "0x869340", VA = "0x869340")]
		public DistanceGrabbable()
		{
		}
	}
	[Token(Token = "0x200011C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x58E1B4", Offset = "0x58E1B4")]
	public class DistanceGrabber : OVRGrabber
	{
		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float m_spherecastRadius;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float m_noSnapThreshhold;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private bool m_useSpherecast;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		[SerializeField]
		public bool m_preventGrabThroughWalls;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float m_objectPullVelocity;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float m_objectPullMaxRotationRate;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool m_movingObjectToHand;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private float m_maxGrabDistance;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private int m_grabObjectsInLayer;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private int m_obstructionLayer;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private DistanceGrabber m_otherHand;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected DistanceGrabbable m_target;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected Collider m_targetCollider;

		[Token(Token = "0x1700006D")]
		public bool UseSpherecast
		{
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x869348", Offset = "0x869348", VA = "0x869348")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x869350", Offset = "0x869350", VA = "0x869350")]
			set
			{
			}
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x86936C", Offset = "0x86936C", VA = "0x86936C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x8695AC", Offset = "0x8695AC", VA = "0x8695AC", Slot = "6")]
		public override void Update()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x869EC4", Offset = "0x869EC4", VA = "0x869EC4", Slot = "7")]
		protected override void GrabBegin()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x86A358", Offset = "0x86A358", VA = "0x86A358", Slot = "8")]
		protected override void MoveGrabbedObject(Vector3 pos, Quaternion rot, bool forceTeleport = false)
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x86A618", Offset = "0x86A618", VA = "0x86A618")]
		private static DistanceGrabbable HitInfoToGrabbable(RaycastHit hitInfo)
		{
			return null;
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x869820", Offset = "0x869820", VA = "0x869820")]
		protected bool FindTarget(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x86A708", Offset = "0x86A708", VA = "0x86A708")]
		protected bool FindTargetWithSpherecast(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x86AB64", Offset = "0x86AB64", VA = "0x86AB64", Slot = "9")]
		protected override void GrabVolumeEnable(bool enabled)
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x86AB7C", Offset = "0x86AB7C", VA = "0x86AB7C", Slot = "10")]
		protected override void OffhandGrabbed(OVRGrabbable grabbable)
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x86AB84", Offset = "0x86AB84", VA = "0x86AB84")]
		public DistanceGrabber()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class GrabManager : MonoBehaviour
	{
		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Collider m_grabVolume;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color OutlineColorInRange;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color OutlineColorHighlighted;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Color OutlineColorOutOfRange;

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xB48060", Offset = "0xB48060", VA = "0xB48060")]
		private void OnTriggerEnter(Collider otherCollider)
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xB48118", Offset = "0xB48118", VA = "0xB48118")]
		private void OnTriggerExit(Collider otherCollider)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xB481D0", Offset = "0xB481D0", VA = "0xB481D0")]
		public GrabManager()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class GrabbableCrosshair : MonoBehaviour
	{
		[Token(Token = "0x200011F")]
		public enum CrosshairState
		{
			[Token(Token = "0x400064D")]
			Disabled,
			[Token(Token = "0x400064E")]
			Enabled,
			[Token(Token = "0x400064F")]
			Targeted
		}

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CrosshairState m_state;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_centerEyeAnchor;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_targetedCrosshair;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_enabledCrosshair;

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xB48290", Offset = "0xB48290", VA = "0xB48290")]
		private void Start()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xB482FC", Offset = "0xB482FC", VA = "0xB482FC")]
		public void SetState(CrosshairState cs)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xB48398", Offset = "0xB48398", VA = "0xB48398")]
		private void Update()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xB483E0", Offset = "0xB483E0", VA = "0xB483E0")]
		public GrabbableCrosshair()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public class PauseOnInputLoss : MonoBehaviour
	{
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x848E04", Offset = "0x848E04", VA = "0x848E04")]
		private void Start()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x848EF0", Offset = "0x848EF0", VA = "0x848EF0")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x848EFC", Offset = "0x848EFC", VA = "0x848EFC")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x848F08", Offset = "0x848F08", VA = "0x848F08")]
		public PauseOnInputLoss()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class BoneCapsuleTriggerLogic : MonoBehaviour
	{
		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableToolTags ToolTags;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HashSet<ColliderZone> CollidersTouchingUs;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<ColliderZone> _elementsToCleanUp;

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1416928", Offset = "0x1416928", VA = "0x1416928")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x141697C", Offset = "0x141697C", VA = "0x141697C")]
		private void Update()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x1416CE8", Offset = "0x1416CE8", VA = "0x1416CE8")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1416DEC", Offset = "0x1416DEC", VA = "0x1416DEC")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1416980", Offset = "0x1416980", VA = "0x1416980")]
		private void CleanUpDeadColliders()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1416EF0", Offset = "0x1416EF0", VA = "0x1416EF0")]
		public BoneCapsuleTriggerLogic()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class ButtonController : Interactable
	{
		[Token(Token = "0x2000123")]
		public enum ContactTest
		{
			[Token(Token = "0x4000662")]
			PerpenTest,
			[Token(Token = "0x4000663")]
			BackwardsPress
		}

		[Token(Token = "0x4000653")]
		private const float ENTRY_DOT_THRESHOLD = 0.8f;

		[Token(Token = "0x4000654")]
		private const float PERP_DOT_THRESHOLD = 0.5f;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _proximityZone;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _contactZone;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _actionZone;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ContactTest[] _contactTests;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _buttonPlaneCenter;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _makeSureToolIsOnPositiveSide;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Vector3 _localButtonDirection;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private InteractableToolTags[] _allValidToolsTags;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _toolTagsMask;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		private bool _allowMultipleNearFieldInteraction;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58FF24", Offset = "0x58FF24")]
		private InteractableState <CurrentButtonState>k__BackingField;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Dictionary<InteractableTool, InteractableState> _toolToState;

		[Token(Token = "0x1700006E")]
		public override int ValidToolTagsMask
		{
			[Token(Token = "0x600050F")]
			[Address(RVA = "0x141982C", Offset = "0x141982C", VA = "0x141982C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700006F")]
		public Vector3 LocalButtonDirection
		{
			[Token(Token = "0x6000510")]
			[Address(RVA = "0x1419834", Offset = "0x1419834", VA = "0x1419834")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000070")]
		public InteractableState CurrentButtonState
		{
			[Token(Token = "0x6000511")]
			[Address(RVA = "0x1419840", Offset = "0x1419840", VA = "0x1419840")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592580", Offset = "0x592580")]
			get
			{
				return default(InteractableState);
			}
			[Token(Token = "0x6000512")]
			[Address(RVA = "0x1419848", Offset = "0x1419848", VA = "0x1419848")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592590", Offset = "0x592590")]
			private set
			{
			}
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x1419850", Offset = "0x1419850", VA = "0x1419850", Slot = "9")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x1419964", Offset = "0x1419964", VA = "0x1419964")]
		private void FireInteractionEventsOnDepth(InteractableCollisionDepth oldDepth, InteractableTool collidingTool, InteractionType interactionType)
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x1419AD0", Offset = "0x1419AD0", VA = "0x1419AD0", Slot = "8")]
		public override void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth)
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x141A088", Offset = "0x141A088", VA = "0x141A088")]
		private InteractableState GetUpcomingStateNearField(InteractableState oldState, InteractableCollisionDepth newCollisionDepth, bool toolIsInActionZone, bool toolIsInContactZone, bool toolIsInProximity, bool validContact, bool onPositiveSideOfInteractable)
		{
			return default(InteractableState);
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x141A134", Offset = "0x141A134", VA = "0x141A134")]
		public void ForceResetButton()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x1419FA0", Offset = "0x1419FA0", VA = "0x1419FA0")]
		private bool IsValidContact(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x141A240", Offset = "0x141A240", VA = "0x141A240")]
		private bool PassEntryTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x141A2C4", Offset = "0x141A2C4", VA = "0x141A2C4")]
		private bool PassPerpTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x141A350", Offset = "0x141A350", VA = "0x141A350")]
		public ButtonController()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class ButtonTriggerZone : MonoBehaviour, ColliderZone
	{
		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _parentInteractableObj;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58FF44", Offset = "0x58FF44")]
		private Collider <Collider>k__BackingField;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58FF54", Offset = "0x58FF54")]
		private Interactable <ParentInteractable>k__BackingField;

		[Token(Token = "0x17000071")]
		public Collider Collider
		{
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x8592A0", Offset = "0x8592A0", VA = "0x8592A0", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5925A0", Offset = "0x5925A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600051D")]
			[Address(RVA = "0x8592A8", Offset = "0x8592A8", VA = "0x8592A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5925B0", Offset = "0x5925B0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public Interactable ParentInteractable
		{
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x8592B0", Offset = "0x8592B0", VA = "0x8592B0", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5925C0", Offset = "0x5925C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x8592B8", Offset = "0x8592B8", VA = "0x8592B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5925D0", Offset = "0x5925D0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x6000520")]
			[Address(RVA = "0x8592C0", Offset = "0x8592C0", VA = "0x8592C0", Slot = "6")]
			get
			{
				return default(InteractableCollisionDepth);
			}
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x859310", Offset = "0x859310", VA = "0x859310")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x8593A4", Offset = "0x8593A4", VA = "0x8593A4")]
		public ButtonTriggerZone()
		{
		}
	}
	[Token(Token = "0x2000125")]
	public interface ColliderZone
	{
		[Token(Token = "0x17000074")]
		Collider Collider
		{
			[Token(Token = "0x6000523")]
			get;
		}

		[Token(Token = "0x17000075")]
		Interactable ParentInteractable
		{
			[Token(Token = "0x6000524")]
			get;
		}

		[Token(Token = "0x17000076")]
		InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x6000525")]
			get;
		}
	}
	[Token(Token = "0x2000126")]
	public class ColliderZoneArgs : EventArgs
	{
		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ColliderZone Collider;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly float FrameTime;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableTool CollidingTool;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly InteractionType InteractionT;

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x8612CC", Offset = "0x8612CC", VA = "0x8612CC")]
		public ColliderZoneArgs(ColliderZone collider, float frameTime, InteractableTool collidingTool, InteractionType interactionType)
		{
		}
	}
	[Token(Token = "0x2000127")]
	public enum InteractionType
	{
		[Token(Token = "0x400066C")]
		Enter,
		[Token(Token = "0x400066D")]
		Stay,
		[Token(Token = "0x400066E")]
		Exit
	}
	[Token(Token = "0x2000128")]
	public class HandsManager : MonoBehaviour
	{
		[Token(Token = "0x2000129")]
		public enum HandsVisualMode
		{
			[Token(Token = "0x4000680")]
			Mesh,
			[Token(Token = "0x4000681")]
			Skeleton,
			[Token(Token = "0x4000682")]
			Both
		}

		[Token(Token = "0x200012A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E214", Offset = "0x58E214")]
		private sealed class <FindSkeletonVisualGameObjects>d__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandsManager <>4__this;

			[Token(Token = "0x17000082")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000548")]
				[Address(RVA = "0xF39B30", Offset = "0xF39B30", VA = "0xF39B30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000083")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600054A")]
				[Address(RVA = "0xF39B78", Offset = "0xF39B78", VA = "0xF39B78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000545")]
			[Address(RVA = "0xF3989C", Offset = "0xF3989C", VA = "0xF3989C")]
			[DebuggerHidden]
			public <FindSkeletonVisualGameObjects>d__52(int <>1__state)
			{
			}

			[Token(Token = "0x6000546")]
			[Address(RVA = "0xF398C8", Offset = "0xF398C8", VA = "0xF398C8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000547")]
			[Address(RVA = "0xF398CC", Offset = "0xF398CC", VA = "0xF398CC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000549")]
			[Address(RVA = "0xF39B38", Offset = "0xF39B38", VA = "0xF39B38", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400066F")]
		private const string SKELETON_VISUALIZER_NAME = "SkeletonRenderer";

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _leftHand;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _rightHand;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HandsVisualMode VisualMode;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private OVRHand[] _hand;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private OVRSkeleton[] _handSkeleton;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRSkeletonRenderer[] _handSkeletonRenderer;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private OVRMesh[] _handMesh;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private OVRMeshRenderer[] _handMeshRenderer;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SkinnedMeshRenderer _leftMeshRenderer;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SkinnedMeshRenderer _rightMeshRenderer;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject _leftSkeletonVisual;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject _rightSkeletonVisual;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _currentHandAlpha;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int HandAlphaId;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58FF84", Offset = "0x58FF84")]
		private static HandsManager <Instance>k__BackingField;

		[Token(Token = "0x17000077")]
		public OVRHand RightHand
		{
			[Token(Token = "0x6000527")]
			[Address(RVA = "0xB4DAAC", Offset = "0xB4DAAC", VA = "0xB4DAAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000528")]
			[Address(RVA = "0xB4DAE4", Offset = "0xB4DAE4", VA = "0xB4DAE4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public OVRSkeleton RightHandSkeleton
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0xB4DB54", Offset = "0xB4DB54", VA = "0xB4DB54")]
			get
			{
				return null;
			}
			[Token(Token = "0x600052A")]
			[Address(RVA = "0xB4DB8C", Offset = "0xB4DB8C", VA = "0xB4DB8C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public OVRSkeletonRenderer RightHandSkeletonRenderer
		{
			[Token(Token = "0x600052B")]
			[Address(RVA = "0xB4DBFC", Offset = "0xB4DBFC", VA = "0xB4DBFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600052C")]
			[Address(RVA = "0xB4DC34", Offset = "0xB4DC34", VA = "0xB4DC34")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public OVRMesh RightHandMesh
		{
			[Token(Token = "0x600052D")]
			[Address(RVA = "0xB4DCA4", Offset = "0xB4DCA4", VA = "0xB4DCA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600052E")]
			[Address(RVA = "0xB4DCDC", Offset = "0xB4DCDC", VA = "0xB4DCDC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public OVRMeshRenderer RightHandMeshRenderer
		{
			[Token(Token = "0x600052F")]
			[Address(RVA = "0xB4DD4C", Offset = "0xB4DD4C", VA = "0xB4DD4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000530")]
			[Address(RVA = "0xB4DD84", Offset = "0xB4DD84", VA = "0xB4DD84")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public OVRHand LeftHand
		{
			[Token(Token = "0x6000531")]
			[Address(RVA = "0xB4DDF4", Offset = "0xB4DDF4", VA = "0xB4DDF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000532")]
			[Address(RVA = "0xB4DE28", Offset = "0xB4DE28", VA = "0xB4DE28")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public OVRSkeleton LeftHandSkeleton
		{
			[Token(Token = "0x6000533")]
			[Address(RVA = "0xB4DE94", Offset = "0xB4DE94", VA = "0xB4DE94")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000534")]
			[Address(RVA = "0xB4DEC8", Offset = "0xB4DEC8", VA = "0xB4DEC8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public OVRSkeletonRenderer LeftHandSkeletonRenderer
		{
			[Token(Token = "0x6000535")]
			[Address(RVA = "0xB4DF34", Offset = "0xB4DF34", VA = "0xB4DF34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000536")]
			[Address(RVA = "0xB4DF68", Offset = "0xB4DF68", VA = "0xB4DF68")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public OVRMesh LeftHandMesh
		{
			[Token(Token = "0x6000537")]
			[Address(RVA = "0xB4DFD4", Offset = "0xB4DFD4", VA = "0xB4DFD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000538")]
			[Address(RVA = "0xB4E008", Offset = "0xB4E008", VA = "0xB4E008")]
			private set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public OVRMeshRenderer LeftHandMeshRenderer
		{
			[Token(Token = "0x6000539")]
			[Address(RVA = "0xB4E074", Offset = "0xB4E074", VA = "0xB4E074")]
			get
			{
				return null;
			}
			[Token(Token = "0x600053A")]
			[Address(RVA = "0xB4E0A8", Offset = "0xB4E0A8", VA = "0xB4E0A8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public static HandsManager Instance
		{
			[Token(Token = "0x600053B")]
			[Address(RVA = "0xB4E114", Offset = "0xB4E114", VA = "0xB4E114")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5925E0", Offset = "0x5925E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600053C")]
			[Address(RVA = "0xB4E160", Offset = "0xB4E160", VA = "0xB4E160")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5925F0", Offset = "0x5925F0")]
			private set
			{
			}
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xB4E1B4", Offset = "0xB4E1B4", VA = "0xB4E1B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xB4E588", Offset = "0xB4E588", VA = "0xB4E588")]
		private void Update()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xB4E510", Offset = "0xB4E510", VA = "0xB4E510")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x592600", Offset = "0x592600")]
		private IEnumerator FindSkeletonVisualGameObjects()
		{
			return null;
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xB4E610", Offset = "0xB4E610", VA = "0xB4E610")]
		public void SwitchVisualization()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xB4E6F4", Offset = "0xB4E6F4", VA = "0xB4E6F4")]
		private void SetToCurrentVisualMode()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xB4E8D4", Offset = "0xB4E8D4", VA = "0xB4E8D4")]
		public static List<OVRBoneCapsule> GetCapsulesPerBone(OVRSkeleton skeleton, OVRSkeleton.BoneId boneId)
		{
			return null;
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xB4EB10", Offset = "0xB4EB10", VA = "0xB4EB10")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xB4EC9C", Offset = "0xB4EC9C", VA = "0xB4EC9C")]
		public HandsManager()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public abstract class Interactable : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200012C")]
		public class InteractableStateArgsEvent : UnityEvent<InteractableStateArgs>
		{
			[Token(Token = "0x600055C")]
			[Address(RVA = "0xF39E18", Offset = "0xF39E18", VA = "0xF39E18")]
			public InteractableStateArgsEvent()
			{
			}
		}

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected ColliderZone _proximityZoneCollider;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ColliderZone _contactZoneCollider;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected ColliderZone _actionZoneCollider;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractableStateArgsEvent InteractableStateChanged;

		[Token(Token = "0x17000084")]
		public ColliderZone ProximityCollider
		{
			[Token(Token = "0x600054B")]
			[Address(RVA = "0xB50718", Offset = "0xB50718", VA = "0xB50718")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		public ColliderZone ContactCollider
		{
			[Token(Token = "0x600054C")]
			[Address(RVA = "0xB50720", Offset = "0xB50720", VA = "0xB50720")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		public ColliderZone ActionCollider
		{
			[Token(Token = "0x600054D")]
			[Address(RVA = "0xB50728", Offset = "0xB50728", VA = "0xB50728")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		public virtual int ValidToolTagsMask
		{
			[Token(Token = "0x600054E")]
			[Address(RVA = "0xB50730", Offset = "0xB50730", VA = "0xB50730", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000012")]
		public event Action<ColliderZoneArgs> ProximityZoneEvent
		{
			[Token(Token = "0x600054F")]
			[Address(RVA = "0xB50738", Offset = "0xB50738", VA = "0xB50738")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5926B0", Offset = "0x5926B0")]
			add
			{
			}
			[Token(Token = "0x6000550")]
			[Address(RVA = "0xB507D8", Offset = "0xB507D8", VA = "0xB507D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5926C0", Offset = "0x5926C0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000013")]
		public event Action<ColliderZoneArgs> ContactZoneEvent
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0xB508E8", Offset = "0xB508E8", VA = "0xB508E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5926D0", Offset = "0x5926D0")]
			add
			{
			}
			[Token(Token = "0x6000553")]
			[Address(RVA = "0xB50988", Offset = "0xB50988", VA = "0xB50988")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5926E0", Offset = "0x5926E0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000014")]
		public event Action<ColliderZoneArgs> ActionZoneEvent
		{
			[Token(Token = "0x6000555")]
			[Address(RVA = "0xB50A98", Offset = "0xB50A98", VA = "0xB50A98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5926F0", Offset = "0x5926F0")]
			add
			{
			}
			[Token(Token = "0x6000556")]
			[Address(RVA = "0xB50B38", Offset = "0xB50B38", VA = "0xB50B38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592700", Offset = "0x592700")]
			remove
			{
			}
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xB50878", Offset = "0xB50878", VA = "0xB50878", Slot = "5")]
		protected virtual void OnProximityZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xB50A28", Offset = "0xB50A28", VA = "0xB50A28", Slot = "6")]
		protected virtual void OnContactZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xB50BD8", Offset = "0xB50BD8", VA = "0xB50BD8", Slot = "7")]
		protected virtual void OnActionZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x6000558")]
		public abstract void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth);

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xB50C48", Offset = "0xB50C48", VA = "0xB50C48", Slot = "9")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xB50D74", Offset = "0xB50D74", VA = "0xB50D74", Slot = "10")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xB50EA0", Offset = "0xB50EA0", VA = "0xB50EA0")]
		protected Interactable()
		{
		}
	}
	[Token(Token = "0x200012D")]
	public enum InteractableCollisionDepth
	{
		[Token(Token = "0x400068E")]
		None,
		[Token(Token = "0x400068F")]
		Proximity,
		[Token(Token = "0x4000690")]
		Contact,
		[Token(Token = "0x4000691")]
		Action
	}
	[Token(Token = "0x200012E")]
	public enum InteractableState
	{
		[Token(Token = "0x4000693")]
		Default,
		[Token(Token = "0x4000694")]
		ProximityState,
		[Token(Token = "0x4000695")]
		ContactState,
		[Token(Token = "0x4000696")]
		ActionState
	}
	[Token(Token = "0x200012F")]
	public class InteractableStateArgs : EventArgs
	{
		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Interactable Interactable;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly InteractableTool Tool;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableState OldInteractableState;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public readonly InteractableState NewInteractableState;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ColliderZoneArgs ColliderArgs;

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xB50FF8", Offset = "0xB50FF8", VA = "0xB50FF8")]
		public InteractableStateArgs(Interactable interactable, InteractableTool tool, InteractableState newInteractableState, InteractableState oldState, ColliderZoneArgs colliderArgs)
		{
		}
	}
	[Token(Token = "0x2000130")]
	public class InteractableRegistry : MonoBehaviour
	{
		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static HashSet<Interactable> _interactables;

		[Token(Token = "0x17000088")]
		public static HashSet<Interactable> Interactables
		{
			[Token(Token = "0x600055E")]
			[Address(RVA = "0xB50F00", Offset = "0xB50F00", VA = "0xB50F00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xB50CA8", Offset = "0xB50CA8", VA = "0xB50CA8")]
		public static void RegisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xB50DD4", Offset = "0xB50DD4", VA = "0xB50DD4")]
		public static void UnregisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xB50F64", Offset = "0xB50F64", VA = "0xB50F64")]
		public InteractableRegistry()
		{
		}
	}
	[Token(Token = "0x2000131")]
	public class InteractableToolsCreator : MonoBehaviour
	{
		[Token(Token = "0x2000132")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E224", Offset = "0x58E224")]
		private sealed class <AttachToolsToHands>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform[] toolObjects;

			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isRightHand;

			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public InteractableToolsCreator <>4__this;

			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private HandsManager <handsManagerObj>5__2;

			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private HashSet<Transform>.Enumerator <>7__wrap2;

			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Transform <toolObject>5__4;

			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private OVRSkeleton <handSkeletonToAttachTo>5__5;

			[Token(Token = "0x17000089")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600056B")]
				[Address(RVA = "0xF3A37C", Offset = "0xF3A37C", VA = "0xF3A37C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600056D")]
				[Address(RVA = "0xF3A3C4", Offset = "0xF3A3C4", VA = "0xF3A3C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000567")]
			[Address(RVA = "0xF39E64", Offset = "0xF39E64", VA = "0xF39E64")]
			[DebuggerHidden]
			public <AttachToolsToHands>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000568")]
			[Address(RVA = "0xF39E90", Offset = "0xF39E90", VA = "0xF39E90", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000569")]
			[Address(RVA = "0xF39F00", Offset = "0xF39F00", VA = "0xF39F00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600056A")]
			[Address(RVA = "0xF39EAC", Offset = "0xF39EAC", VA = "0xF39EAC")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600056C")]
			[Address(RVA = "0xF3A384", Offset = "0xF3A384", VA = "0xF3A384", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform[] LeftHandTools;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] RightHandTools;

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xB51D7C", Offset = "0xB51D7C", VA = "0xB51D7C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xB51DF8", Offset = "0xB51DF8", VA = "0xB51DF8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x592710", Offset = "0x592710")]
		private IEnumerator AttachToolsToHands(Transform[] toolObjects, bool isRightHand)
		{
			return null;
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xB51E98", Offset = "0xB51E98", VA = "0xB51E98")]
		private void AttachToolToHandTransform(Transform tool, bool isRightHanded)
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xB51F80", Offset = "0xB51F80", VA = "0xB51F80")]
		public InteractableToolsCreator()
		{
		}
	}
	[Token(Token = "0x2000133")]
	public class InteractableToolsInputRouter : MonoBehaviour
	{
		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static InteractableToolsInputRouter _instance;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _leftPinch;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool _rightPinch;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HashSet<InteractableTool> _leftHandNearTools;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HashSet<InteractableTool> _leftHandFarTools;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HashSet<InteractableTool> _rightHandNearTools;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HashSet<InteractableTool> _rightHandFarTools;

		[Token(Token = "0x1700008B")]
		public static InteractableToolsInputRouter Instance
		{
			[Token(Token = "0x600056E")]
			[Address(RVA = "0xB51F88", Offset = "0xB51F88", VA = "0xB51F88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xB52108", Offset = "0xB52108", VA = "0xB52108")]
		public void RegisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xB521B0", Offset = "0xB521B0", VA = "0xB521B0")]
		public void UnregisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xB52258", Offset = "0xB52258", VA = "0xB52258")]
		private void Update()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xB52504", Offset = "0xB52504", VA = "0xB52504")]
		private bool UpdateToolsAndEnableState(HashSet<InteractableTool> tools, bool toolsAreEnabledThisFrame)
		{
			return default(bool);
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xB5254C", Offset = "0xB5254C", VA = "0xB5254C")]
		private bool UpdateTools(HashSet<InteractableTool> tools, bool resetCollisionData = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xB527FC", Offset = "0xB527FC", VA = "0xB527FC")]
		private void ToggleToolsEnableState(HashSet<InteractableTool> tools, bool enableState)
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xB52948", Offset = "0xB52948", VA = "0xB52948")]
		public InteractableToolsInputRouter()
		{
		}
	}
	[Token(Token = "0x2000134")]
	public class FingerTipPokeTool : InteractableTool
	{
		[Token(Token = "0x2000135")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E234", Offset = "0x58E234")]
		private sealed class <AttachTriggerLogic>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FingerTipPokeTool <>4__this;

			[Token(Token = "0x17000090")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000587")]
				[Address(RVA = "0xF38904", Offset = "0xF38904", VA = "0xF38904", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000091")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000589")]
				[Address(RVA = "0xF3894C", Offset = "0xF3894C", VA = "0xF3894C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000584")]
			[Address(RVA = "0xF384D0", Offset = "0xF384D0", VA = "0xF384D0")]
			[DebuggerHidden]
			public <AttachTriggerLogic>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000585")]
			[Address(RVA = "0xF384FC", Offset = "0xF384FC", VA = "0xF384FC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000586")]
			[Address(RVA = "0xF38500", Offset = "0xF38500", VA = "0xF38500", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000588")]
			[Address(RVA = "0xF3890C", Offset = "0xF3890C", VA = "0xF3890C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006AF")]
		private const int NUM_VELOCITY_FRAMES = 10;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private FingerTipPokeToolView _fingerTipPokeToolView;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private OVRPlugin.HandFinger _fingerToFollow;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] _velocityFrames;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _currVelocityFrame;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool _sampledMaxFramesAlready;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 _position;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BoneCapsuleTriggerLogic[] _boneCapsuleTriggerLogic;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _lastScale;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool _isInitialized;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private OVRBoneCapsule _capsuleToTrack;

		[Token(Token = "0x1700008C")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x6000576")]
			[Address(RVA = "0x870964", Offset = "0x870964", VA = "0x870964", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x1700008D")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x6000577")]
			[Address(RVA = "0x87096C", Offset = "0x87096C", VA = "0x87096C", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x1700008E")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x870974", Offset = "0x870974", VA = "0x870974", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008F")]
		public override bool EnableState
		{
			[Token(Token = "0x6000579")]
			[Address(RVA = "0x87097C", Offset = "0x87097C", VA = "0x87097C", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x8709A8", Offset = "0x8709A8", VA = "0x8709A8", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x8709E4", Offset = "0x8709E4", VA = "0x8709E4", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x870A9C", Offset = "0x870A9C", VA = "0x870A9C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5927C0", Offset = "0x5927C0")]
		private IEnumerator AttachTriggerLogic()
		{
			return null;
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x870B14", Offset = "0x870B14", VA = "0x870B14")]
		private void Update()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x870DB4", Offset = "0x870DB4", VA = "0x870DB4")]
		private void UpdateAverageVelocity()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x870F40", Offset = "0x870F40", VA = "0x870F40")]
		private void CheckAndUpdateScale()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x871038", Offset = "0x871038", VA = "0x871038", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x871330", Offset = "0x871330", VA = "0x871330", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x871334", Offset = "0x871334", VA = "0x871334", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x871338", Offset = "0x871338", VA = "0x871338")]
		public FingerTipPokeTool()
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class FingerTipPokeToolView : MonoBehaviour
	{
		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _sphereMeshRenderer;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x590014", Offset = "0x590014")]
		private InteractableTool <InteractableTool>k__BackingField;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x590024", Offset = "0x590024")]
		private bool <ToolActivateState>k__BackingField;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x590034", Offset = "0x590034")]
		private float <SphereRadius>k__BackingField;

		[Token(Token = "0x17000092")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x600058A")]
			[Address(RVA = "0x871350", Offset = "0x871350", VA = "0x871350", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592870", Offset = "0x592870")]
			get
			{
				return null;
			}
			[Token(Token = "0x600058B")]
			[Address(RVA = "0x871358", Offset = "0x871358", VA = "0x871358")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592880", Offset = "0x592880")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public bool EnableState
		{
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x871360", Offset = "0x871360", VA = "0x871360", Slot = "5")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600058D")]
			[Address(RVA = "0x87137C", Offset = "0x87137C", VA = "0x87137C", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public bool ToolActivateState
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0x87139C", Offset = "0x87139C", VA = "0x87139C", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592890", Offset = "0x592890")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600058F")]
			[Address(RVA = "0x8713A4", Offset = "0x8713A4", VA = "0x8713A4", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5928A0", Offset = "0x5928A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public float SphereRadius
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x8713B0", Offset = "0x8713B0", VA = "0x8713B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5928B0", Offset = "0x5928B0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x8713B8", Offset = "0x8713B8", VA = "0x8713B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5928C0", Offset = "0x5928C0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x8713C0", Offset = "0x8713C0", VA = "0x8713C0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x871408", Offset = "0x871408", VA = "0x871408")]
		public FingerTipPokeToolView()
		{
		}
	}
	[Token(Token = "0x2000137")]
	[Flags]
	public enum InteractableToolTags
	{
		[Token(Token = "0x40006C2")]
		None = 0,
		[Token(Token = "0x40006C3")]
		Ray = 1,
		[Token(Token = "0x40006C4")]
		Poke = 4,
		[Token(Token = "0x40006C5")]
		All = -1
	}
	[Token(Token = "0x2000138")]
	public enum ToolInputState
	{
		[Token(Token = "0x40006C7")]
		Inactive,
		[Token(Token = "0x40006C8")]
		PrimaryInputDown,
		[Token(Token = "0x40006C9")]
		PrimaryInputDownStay,
		[Token(Token = "0x40006CA")]
		PrimaryInputUp
	}
	[Token(Token = "0x2000139")]
	public class InteractableCollisionInfo
	{
		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ColliderZone InteractableCollider;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableCollisionDepth CollisionDepth;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractableTool CollidingTool;

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xB50EA8", Offset = "0xB50EA8", VA = "0xB50EA8")]
		public InteractableCollisionInfo(ColliderZone collider, InteractableCollisionDepth collisionDepth, InteractableTool collidingTool)
		{
		}
	}
	[Token(Token = "0x200013A")]
	public abstract class InteractableTool : MonoBehaviour
	{
		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x590044", Offset = "0x590044")]
		private bool <IsRightHandedTool>k__BackingField;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x590054", Offset = "0x590054")]
		private Vector3 <Velocity>k__BackingField;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x590064", Offset = "0x590064")]
		private Vector3 <InteractionPosition>k__BackingField;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<InteractableCollisionInfo> _currentIntersectingObjects;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Interactable> _addedInteractables;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Interactable> _removedInteractables;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Interactable> _remainingInteractables;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Interactable, InteractableCollisionInfo> _currInteractableToCollisionInfos;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<Interactable, InteractableCollisionInfo> _prevInteractableToCollisionInfos;

		[Token(Token = "0x17000096")]
		public Transform ToolTransform
		{
			[Token(Token = "0x6000595")]
			[Address(RVA = "0xB510BC", Offset = "0xB510BC", VA = "0xB510BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		public bool IsRightHandedTool
		{
			[Token(Token = "0x6000596")]
			[Address(RVA = "0xB510C4", Offset = "0xB510C4", VA = "0xB510C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5928D0", Offset = "0x5928D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000597")]
			[Address(RVA = "0xB510CC", Offset = "0xB510CC", VA = "0xB510CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5928E0", Offset = "0x5928E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public abstract InteractableToolTags ToolTags
		{
			[Token(Token = "0x6000598")]
			get;
		}

		[Token(Token = "0x17000099")]
		public abstract ToolInputState ToolInputState
		{
			[Token(Token = "0x6000599")]
			get;
		}

		[Token(Token = "0x1700009A")]
		public abstract bool IsFarFieldTool
		{
			[Token(Token = "0x600059A")]
			get;
		}

		[Token(Token = "0x1700009B")]
		public Vector3 Velocity
		{
			[Token(Token = "0x600059B")]
			[Address(RVA = "0xB510D8", Offset = "0xB510D8", VA = "0xB510D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5928F0", Offset = "0x5928F0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600059C")]
			[Address(RVA = "0xB510E4", Offset = "0xB510E4", VA = "0xB510E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592900", Offset = "0x592900")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public Vector3 InteractionPosition
		{
			[Token(Token = "0x600059D")]
			[Address(RVA = "0xB510F0", Offset = "0xB510F0", VA = "0xB510F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592910", Offset = "0x592910")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600059E")]
			[Address(RVA = "0xB510FC", Offset = "0xB510FC", VA = "0xB510FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592920", Offset = "0x592920")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public abstract bool EnableState
		{
			[Token(Token = "0x60005A3")]
			get;
			[Token(Token = "0x60005A4")]
			set;
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xB51108", Offset = "0xB51108", VA = "0xB51108")]
		public List<InteractableCollisionInfo> GetCurrentIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x60005A0")]
		public abstract List<InteractableCollisionInfo> GetNextIntersectingObjects();

		[Token(Token = "0x60005A1")]
		public abstract void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone);

		[Token(Token = "0x60005A2")]
		public abstract void DeFocus();

		[Token(Token = "0x60005A5")]
		public abstract void Initialize();

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xB51110", Offset = "0xB51110", VA = "0xB51110")]
		public KeyValuePair<Interactable, InteractableCollisionInfo> GetFirstCurrentCollisionInfo()
		{
			return default(KeyValuePair<Interactable, InteractableCollisionInfo>);
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xB5115C", Offset = "0xB5115C", VA = "0xB5115C")]
		public void ClearAllCurrentCollisionInfos()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xB511B0", Offset = "0xB511B0", VA = "0xB511B0", Slot = "13")]
		public virtual void UpdateCurrentCollisionsBasedOnDepth()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xB51460", Offset = "0xB51460", VA = "0xB51460", Slot = "14")]
		public virtual void UpdateLatestCollisionData()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xB51BEC", Offset = "0xB51BEC", VA = "0xB51BEC")]
		protected InteractableTool()
		{
		}
	}
	[Token(Token = "0x200013B")]
	public class PinchStateModule
	{
		[Token(Token = "0x200013C")]
		private enum PinchState
		{
			[Token(Token = "0x40006DB")]
			None,
			[Token(Token = "0x40006DC")]
			PinchDown,
			[Token(Token = "0x40006DD")]
			PinchStay,
			[Token(Token = "0x40006DE")]
			PinchUp
		}

		[Token(Token = "0x40006D7")]
		private const float PINCH_STRENGTH_THRESHOLD = 1f;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PinchState _currPinchState;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Interactable _firstFocusedInteractable;

		[Token(Token = "0x1700009E")]
		public bool PinchUpAndDownOnFocusedObject
		{
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x848F10", Offset = "0x848F10", VA = "0x848F10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009F")]
		public bool PinchSteadyOnFocusedObject
		{
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x848F98", Offset = "0x848F98", VA = "0x848F98")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A0")]
		public bool PinchDownOnFocusedObject
		{
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x849020", Offset = "0x849020", VA = "0x849020")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x8490A8", Offset = "0x8490A8", VA = "0x8490A8")]
		public PinchStateModule()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x8490DC", Offset = "0x8490DC", VA = "0x8490DC")]
		public void UpdateState(OVRHand hand, Interactable currFocusedInteractable)
		{
		}
	}
	[Token(Token = "0x200013D")]
	public class RayTool : InteractableTool
	{
		[Token(Token = "0x40006DF")]
		private const float MINIMUM_RAY_CAST_DISTANCE = 0.8f;

		[Token(Token = "0x40006E0")]
		private const float COLLIDER_RADIUS = 0.01f;

		[Token(Token = "0x40006E1")]
		private const int NUM_MAX_PRIMARY_HITS = 10;

		[Token(Token = "0x40006E2")]
		private const int NUM_MAX_SECONDARY_HITS = 25;

		[Token(Token = "0x40006E3")]
		private const int NUM_COLLIDERS_TO_TEST = 20;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RayToolView _rayToolView;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x590084", Offset = "0x590084")]
		private float _coneAngleDegrees;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _farFieldMaxDistance;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PinchStateModule _pinchStateModule;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Interactable _focusedInteractable;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Collider[] _collidersOverlapped;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Interactable _currInteractableCastedAgainst;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _coneAngleReleaseDegrees;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RaycastHit[] _primaryHits;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Collider[] _secondaryOverlapResults;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool _initialized;

		[Token(Token = "0x170000A1")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x84C060", Offset = "0x84C060", VA = "0x84C060", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x170000A2")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x84C068", Offset = "0x84C068", VA = "0x84C068", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x170000A3")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x84C0D0", Offset = "0x84C0D0", VA = "0x84C0D0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A4")]
		public override bool EnableState
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x84C0D8", Offset = "0x84C0D8", VA = "0x84C0D8", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x84C11C", Offset = "0x84C11C", VA = "0x84C11C", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x84C190", Offset = "0x84C190", VA = "0x84C190", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x84C1F8", Offset = "0x84C1F8", VA = "0x84C1F8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x84C29C", Offset = "0x84C29C", VA = "0x84C29C")]
		private void Update()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x84C554", Offset = "0x84C554", VA = "0x84C554")]
		private Vector3 GetRayCastOrigin()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x84C5DC", Offset = "0x84C5DC", VA = "0x84C5DC", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x84C9AC", Offset = "0x84C9AC", VA = "0x84C9AC")]
		private bool HasRayReleasedInteractable(Interactable focusedInteractable)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x84CABC", Offset = "0x84CABC", VA = "0x84CABC")]
		private Interactable FindTargetInteractable()
		{
			return null;
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x84CBE0", Offset = "0x84CBE0", VA = "0x84CBE0")]
		private Interactable FindPrimaryRaycastHit(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x84CEE4", Offset = "0x84CEE4", VA = "0x84CEE4")]
		private Interactable FindInteractableViaConeTest(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x84D278", Offset = "0x84D278", VA = "0x84D278", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x84D360", Offset = "0x84D360", VA = "0x84D360", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x84D39C", Offset = "0x84D39C", VA = "0x84D39C")]
		public RayTool()
		{
		}
	}
	[Token(Token = "0x200013E")]
	public class RayToolView : MonoBehaviour
	{
		[Token(Token = "0x40006EF")]
		private const int NUM_RAY_LINE_POSITIONS = 25;

		[Token(Token = "0x40006F0")]
		private const float DEFAULT_RAY_CAST_DISTANCE = 3f;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _targetTransform;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LineRenderer _lineRenderer;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _toolActivateState;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _focusedTransform;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3[] linePositions;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Gradient _oldColorGradient;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Gradient _highLightColorGradient;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5900F8", Offset = "0x5900F8")]
		private InteractableTool <InteractableTool>k__BackingField;

		[Token(Token = "0x170000A5")]
		public bool EnableState
		{
			[Token(Token = "0x60005C1")]
			[Address(RVA = "0x84C100", Offset = "0x84C100", VA = "0x84C100", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x84C138", Offset = "0x84C138", VA = "0x84C138", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public bool ToolActivateState
		{
			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x84D4A8", Offset = "0x84D4A8", VA = "0x84D4A8", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x84C518", Offset = "0x84C518", VA = "0x84C518", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x84D708", Offset = "0x84D708", VA = "0x84D708", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592930", Offset = "0x592930")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x84D710", Offset = "0x84D710", VA = "0x84D710")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592940", Offset = "0x592940")]
			set
			{
			}
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x84D4B0", Offset = "0x84D4B0", VA = "0x84D4B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x84D2B4", Offset = "0x84D2B4", VA = "0x84D2B4", Slot = "9")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x84D718", Offset = "0x84D718", VA = "0x84D718")]
		private void Update()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x84D98C", Offset = "0x84D98C", VA = "0x84D98C")]
		public static Vector3 GetPointOnBezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x84DA7C", Offset = "0x84DA7C", VA = "0x84DA7C")]
		public RayToolView()
		{
		}
	}
	[Token(Token = "0x200013F")]
	public class DistanceGrabberSample : MonoBehaviour
	{
		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool useSpherecast;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool allowGrabThroughWalls;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DistanceGrabber[] m_grabbers;

		[Token(Token = "0x170000A8")]
		public bool UseSpherecast
		{
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x86ABA4", Offset = "0x86ABA4", VA = "0x86ABA4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x86ABAC", Offset = "0x86ABAC", VA = "0x86ABAC")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public bool AllowGrabThroughWalls
		{
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x86AC34", Offset = "0x86AC34", VA = "0x86AC34")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x86AC3C", Offset = "0x86AC3C", VA = "0x86AC3C")]
			set
			{
			}
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x86ACA8", Offset = "0x86ACA8", VA = "0x86ACA8")]
		private void Start()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x86AF5C", Offset = "0x86AF5C", VA = "0x86AF5C")]
		public void ToggleSphereCasting(Toggle t)
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x86AF6C", Offset = "0x86AF6C", VA = "0x86AF6C")]
		public void ToggleGrabThroughWalls(Toggle t)
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x86AF7C", Offset = "0x86AF7C", VA = "0x86AF7C")]
		public DistanceGrabberSample()
		{
		}
	}
	[Token(Token = "0x2000140")]
	public class ControllerBoxController : MonoBehaviour
	{
		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TrainLocomotive _locomotive;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CowController _cowController;

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x862E90", Offset = "0x862E90", VA = "0x862E90")]
		public void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x862EC8", Offset = "0x862EC8", VA = "0x862EC8")]
		public void DecreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x862F00", Offset = "0x862F00", VA = "0x862F00")]
		public void IncreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x862F38", Offset = "0x862F38", VA = "0x862F38")]
		public void SmokeButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x862F70", Offset = "0x862F70", VA = "0x862F70")]
		public void WhistleButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x862FA8", Offset = "0x862FA8", VA = "0x862FA8")]
		public void ReverseButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x862FE0", Offset = "0x862FE0", VA = "0x862FE0")]
		public void SwitchVisualization(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x863054", Offset = "0x863054", VA = "0x863054")]
		public void GoMoo(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x8630C4", Offset = "0x8630C4", VA = "0x8630C4")]
		public ControllerBoxController()
		{
		}
	}
	[Token(Token = "0x2000141")]
	public class CowController : MonoBehaviour
	{
		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animation _cowAnimation;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioSource _mooCowAudioSource;

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x863568", Offset = "0x863568", VA = "0x863568")]
		public void PlayMooSound()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x863088", Offset = "0x863088", VA = "0x863088")]
		public void GoMooCowGo()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x8635A8", Offset = "0x8635A8", VA = "0x8635A8")]
		public CowController()
		{
		}
	}
	[Token(Token = "0x2000142")]
	public class PanelHMDFollower : MonoBehaviour
	{
		[Token(Token = "0x2000143")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E254", Offset = "0x58E254")]
		private sealed class <LerpToHMD>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PanelHMDFollower <>4__this;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 <newPanelPosition>5__2;

			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <startTime>5__3;

			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <endTime>5__4;

			[Token(Token = "0x170000AA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005E8")]
				[Address(RVA = "0xF3E014", Offset = "0xF3E014", VA = "0xF3E014", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005EA")]
				[Address(RVA = "0xF3E05C", Offset = "0xF3E05C", VA = "0xF3E05C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0xF3DE28", Offset = "0xF3DE28", VA = "0xF3DE28")]
			[DebuggerHidden]
			public <LerpToHMD>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x60005E6")]
			[Address(RVA = "0xF3DE54", Offset = "0xF3DE54", VA = "0xF3DE54", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005E7")]
			[Address(RVA = "0xF3DE58", Offset = "0xF3DE58", VA = "0xF3DE58", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005E9")]
			[Address(RVA = "0xF3E01C", Offset = "0xF3E01C", VA = "0xF3E01C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000700")]
		private const float TOTAL_DURATION = 3f;

		[Token(Token = "0x4000701")]
		private const float HMD_MOVEMENT_THRESHOLD = 0.3f;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _maxDistance;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _minDistance;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _minZDistance;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private OVRCameraRig _cameraRig;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 _panelInitialPosition;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _coroutine;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _prevPos;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _lastMovedToPos;

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x8470E8", Offset = "0x8470E8", VA = "0x8470E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x847194", Offset = "0x847194", VA = "0x847194")]
		private void Update()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x8473E4", Offset = "0x8473E4", VA = "0x8473E4")]
		private Vector3 CalculateIdealAnchorPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x84736C", Offset = "0x84736C", VA = "0x84736C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x592950", Offset = "0x592950")]
		private IEnumerator LerpToHMD()
		{
			return null;
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x847430", Offset = "0x847430", VA = "0x847430")]
		public PanelHMDFollower()
		{
		}
	}
	[Token(Token = "0x2000144")]
	public class SelectionCylinder : MonoBehaviour
	{
		[Token(Token = "0x2000145")]
		public enum SelectionState
		{
			[Token(Token = "0x4000717")]
			Off,
			[Token(Token = "0x4000718")]
			Selected,
			[Token(Token = "0x4000719")]
			Highlighted
		}

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _selectionMeshRenderer;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _colorId;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material[] _selectionMaterials;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color[] _defaultSelectionColors;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color[] _highlightColors;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SelectionState _currSelectionState;

		[Token(Token = "0x170000AC")]
		public SelectionState CurrSelectionState
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x851A6C", Offset = "0x851A6C", VA = "0x851A6C")]
			get
			{
				return default(SelectionState);
			}
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x851A74", Offset = "0x851A74", VA = "0x851A74")]
			set
			{
			}
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x851BF8", Offset = "0x851BF8", VA = "0x851BF8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x851DFC", Offset = "0x851DFC", VA = "0x851DFC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x851AFC", Offset = "0x851AFC", VA = "0x851AFC")]
		private void AffectSelectionColor(Color[] newColors)
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x851EE8", Offset = "0x851EE8", VA = "0x851EE8")]
		public SelectionCylinder()
		{
		}
	}
	[Token(Token = "0x2000146")]
	public class TrackSegment : MonoBehaviour
	{
		[Token(Token = "0x2000147")]
		public enum SegmentType
		{
			[Token(Token = "0x4000728")]
			Straight,
			[Token(Token = "0x4000729")]
			LeftTurn,
			[Token(Token = "0x400072A")]
			RightTurn,
			[Token(Token = "0x400072B")]
			Switch
		}

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SegmentType _segmentType;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshFilter _straight;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshFilter _leftTurn;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshFilter _rightTurn;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _gridSize;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _subDivCount;

		[Token(Token = "0x4000720")]
		private const float _originalGridSize = 0.8f;

		[Token(Token = "0x4000721")]
		private const float _trackWidth = 0.15f;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject _mesh;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5901D8", Offset = "0x5901D8")]
		private float <StartDistance>k__BackingField;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Pose _p1;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Pose _p2;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Pose _endPose;

		[Token(Token = "0x170000AD")]
		public float StartDistance
		{
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0xB0C2BC", Offset = "0xB0C2BC", VA = "0xB0C2BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592A00", Offset = "0x592A00")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0xB0C2C4", Offset = "0xB0C2C4", VA = "0xB0C2C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592A10", Offset = "0x592A10")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public float GridSize
		{
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0xB0C2CC", Offset = "0xB0C2CC", VA = "0xB0C2CC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0xB0C2D4", Offset = "0xB0C2D4", VA = "0xB0C2D4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public int SubDivCount
		{
			[Token(Token = "0x60005F6")]
			[Address(RVA = "0xB0C2DC", Offset = "0xB0C2DC", VA = "0xB0C2DC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0xB0C2E4", Offset = "0xB0C2E4", VA = "0xB0C2E4")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public SegmentType Type
		{
			[Token(Token = "0x60005F8")]
			[Address(RVA = "0xB0C2EC", Offset = "0xB0C2EC", VA = "0xB0C2EC")]
			get
			{
				return default(SegmentType);
			}
		}

		[Token(Token = "0x170000B1")]
		public Pose EndPose
		{
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0xB0C2F4", Offset = "0xB0C2F4", VA = "0xB0C2F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B2")]
		public float Radius
		{
			[Token(Token = "0x60005FA")]
			[Address(RVA = "0xB0C650", Offset = "0xB0C650", VA = "0xB0C650")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B3")]
		public float SegmentLength
		{
			[Token(Token = "0x60005FC")]
			[Address(RVA = "0xB0C35C", Offset = "0xB0C35C", VA = "0xB0C35C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xB0C660", Offset = "0xB0C660", VA = "0xB0C660")]
		public float setGridSize(float size)
		{
			return default(float);
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xB0C39C", Offset = "0xB0C39C", VA = "0xB0C39C")]
		public void UpdatePose(float distanceIntoSegment, Pose pose)
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xB0C678", Offset = "0xB0C678", VA = "0xB0C678")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xB0C6E0", Offset = "0xB0C6E0", VA = "0xB0C6E0")]
		private void DrawDebugLines()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xB0CFA8", Offset = "0xB0CFA8", VA = "0xB0CFA8")]
		public void RegenerateTrackAndMesh()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xB0D254", Offset = "0xB0D254", VA = "0xB0D254")]
		public TrackSegment()
		{
		}
	}
	[Token(Token = "0x2000148")]
	public class TrainButtonVisualController : MonoBehaviour
	{
		[Token(Token = "0x2000149")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E264", Offset = "0x58E264")]
		private sealed class <ResetPosition>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400073D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400073E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainButtonVisualController <>4__this;

			[Token(Token = "0x4000740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <startTime>5__2;

			[Token(Token = "0x4000741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <endTime>5__3;

			[Token(Token = "0x170000B4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000610")]
				[Address(RVA = "0xF400B4", Offset = "0xF400B4", VA = "0xF400B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000612")]
				[Address(RVA = "0xF400FC", Offset = "0xF400FC", VA = "0xF400FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0xF3FF10", Offset = "0xF3FF10", VA = "0xF3FF10")]
			[DebuggerHidden]
			public <ResetPosition>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x600060E")]
			[Address(RVA = "0xF3FF3C", Offset = "0xF3FF3C", VA = "0xF3FF3C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600060F")]
			[Address(RVA = "0xF3FF40", Offset = "0xF3FF40", VA = "0xF3FF40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000611")]
			[Address(RVA = "0xF400BC", Offset = "0xF400BC", VA = "0xF400BC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400072C")]
		private const float LERP_TO_OLD_POS_DURATION = 1f;

		[Token(Token = "0x400072D")]
		private const float LOCAL_SIZE_HALVED = 0.5f;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _meshRenderer;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshRenderer _glowRenderer;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ButtonController _buttonController;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _buttonContactColor;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _buttonActionColor;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AudioClip _actionSoundEffect;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _buttonContactTransform;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _contactMaxDisplacementDistance;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material _buttonMaterial;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Color _buttonDefaultColor;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _materialColorId;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool _buttonInContactOrActionStates;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Coroutine _lerpToOldPositionCr;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 _oldPosition;

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xB0D3A8", Offset = "0xB0D3A8", VA = "0xB0D3A8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xB0D464", Offset = "0xB0D464", VA = "0xB0D464")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xB0D514", Offset = "0xB0D514", VA = "0xB0D514")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xB0D68C", Offset = "0xB0D68C", VA = "0xB0D68C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0xB0D854", Offset = "0xB0D854", VA = "0xB0D854")]
		private void ActionOrInContactZoneStayEvent(ColliderZoneArgs collisionArgs)
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xB0D93C", Offset = "0xB0D93C", VA = "0xB0D93C")]
		private void InteractableStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xB0DB50", Offset = "0xB0DB50", VA = "0xB0DB50")]
		private void PlaySound(AudioClip clip)
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xB0DA50", Offset = "0xB0DA50", VA = "0xB0DA50")]
		private void StopResetLerping()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xB0DA64", Offset = "0xB0DA64", VA = "0xB0DA64")]
		private void LerpToOldPosition()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xB0DBA8", Offset = "0xB0DBA8", VA = "0xB0DBA8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x592A20", Offset = "0x592A20")]
		private IEnumerator ResetPosition()
		{
			return null;
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xB0DC20", Offset = "0xB0DC20", VA = "0xB0DC20")]
		public TrainButtonVisualController()
		{
		}
	}
	[Token(Token = "0x200014A")]
	public class TrainCar : TrainCarBase
	{
		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TrainCarBase _parentLocomotive;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected float _distanceBehindParent;

		[Token(Token = "0x170000B6")]
		public float DistanceBehindParentScaled
		{
			[Token(Token = "0x6000613")]
			[Address(RVA = "0xB0DCD0", Offset = "0xB0DCD0", VA = "0xB0DCD0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xB0DCE0", Offset = "0xB0DCE0", VA = "0xB0DCE0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xB0DCE8", Offset = "0xB0DCE8", VA = "0xB0DCE8", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xB0E02C", Offset = "0xB0E02C", VA = "0xB0E02C")]
		public TrainCar()
		{
		}
	}
	[Token(Token = "0x200014B")]
	public abstract class TrainCarBase : MonoBehaviour
	{
		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3 OFFSET;

		[Token(Token = "0x4000745")]
		private const float WHEEL_RADIUS = 0.027f;

		[Token(Token = "0x4000746")]
		private const float TWO_PI = (float)Math.PI * 2f;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform _frontWheels;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Transform _rearWheels;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected TrainTrack _trainTrack;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Transform[] _individualWheels;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5902D8", Offset = "0x5902D8")]
		private float <Distance>k__BackingField;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected float scale;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Pose _frontPose;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Pose _rearPose;

		[Token(Token = "0x170000B7")]
		public float Distance
		{
			[Token(Token = "0x6000617")]
			[Address(RVA = "0xB0E13C", Offset = "0xB0E13C", VA = "0xB0E13C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592AD0", Offset = "0x592AD0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000618")]
			[Address(RVA = "0xB0E144", Offset = "0xB0E144", VA = "0xB0E144")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592AE0", Offset = "0x592AE0")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		public float Scale
		{
			[Token(Token = "0x6000619")]
			[Address(RVA = "0xB0E14C", Offset = "0xB0E14C", VA = "0xB0E14C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600061A")]
			[Address(RVA = "0xB0E154", Offset = "0xB0E154", VA = "0xB0E154")]
			set
			{
			}
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xB0DCE4", Offset = "0xB0DCE4", VA = "0xB0DCE4", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xB0E15C", Offset = "0xB0E15C", VA = "0xB0E15C")]
		public void UpdatePose(float distance, TrainCarBase train, Pose pose)
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xB0DD30", Offset = "0xB0DD30", VA = "0xB0DD30")]
		protected void UpdateCarPosition()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xB0DF54", Offset = "0xB0DF54", VA = "0xB0DF54")]
		protected void RotateCarWheels()
		{
		}

		[Token(Token = "0x600061F")]
		public abstract void UpdatePosition();

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xB0E098", Offset = "0xB0E098", VA = "0xB0E098")]
		protected TrainCarBase()
		{
		}
	}
	[Token(Token = "0x200014C")]
	public class TrainCrossingController : MonoBehaviour
	{
		[Token(Token = "0x200014D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E274", Offset = "0x58E274")]
		private sealed class <AnimateCrossing>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainCrossingController <>4__this;

			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float animationLength;

			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <animationEndTime>5__2;

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <lightBlinkDuration>5__3;

			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <lightBlinkStartTime>5__4;

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <lightBlinkEndTime>5__5;

			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Material <lightToBlinkOn>5__6;

			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Material <lightToBlinkOff>5__7;

			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Color <onColor>5__8;

			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Color <offColor>5__9;

			[Token(Token = "0x170000B9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600062E")]
				[Address(RVA = "0xF4039C", Offset = "0xF4039C", VA = "0xF4039C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000630")]
				[Address(RVA = "0xF403E4", Offset = "0xF403E4", VA = "0xF403E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0xF40104", Offset = "0xF40104", VA = "0xF40104")]
			[DebuggerHidden]
			public <AnimateCrossing>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x600062C")]
			[Address(RVA = "0xF40130", Offset = "0xF40130", VA = "0xF40130", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600062D")]
			[Address(RVA = "0xF40134", Offset = "0xF40134", VA = "0xF40134", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600062F")]
			[Address(RVA = "0xF403A4", Offset = "0xF403A4", VA = "0xF403A4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip[] _crossingSounds;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshRenderer _lightSide1Renderer;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshRenderer _lightSide2Renderer;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material _lightsSide1Mat;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material _lightsSide2Mat;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _colorId;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine _xingAnimationCr;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xB0E2FC", Offset = "0xB0E2FC", VA = "0xB0E2FC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xB0E35C", Offset = "0xB0E35C", VA = "0xB0E35C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xB0E464", Offset = "0xB0E464", VA = "0xB0E464")]
		public void CrossingButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xB0E5BC", Offset = "0xB0E5BC", VA = "0xB0E5BC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xB0E4C4", Offset = "0xB0E4C4", VA = "0xB0E4C4")]
		private void ActivateTrainCrossing()
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xB0E698", Offset = "0xB0E698", VA = "0xB0E698")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x592AF0", Offset = "0x592AF0")]
		private IEnumerator AnimateCrossing(float animationLength)
		{
			return null;
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xB0E720", Offset = "0xB0E720", VA = "0xB0E720")]
		private void AffectMaterials(Material[] materials, Color newColor)
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xB0E7CC", Offset = "0xB0E7CC", VA = "0xB0E7CC")]
		private void ToggleLightObjects(bool enableState)
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xB0E82C", Offset = "0xB0E82C", VA = "0xB0E82C")]
		public TrainCrossingController()
		{
		}
	}
	[Token(Token = "0x200014E")]
	public class TrainLocomotive : TrainCarBase
	{
		[Token(Token = "0x200014F")]
		private enum EngineSoundState
		{
			[Token(Token = "0x4000783")]
			Start,
			[Token(Token = "0x4000784")]
			AccelerateOrSetProperSpeed,
			[Token(Token = "0x4000785")]
			Stop
		}

		[Token(Token = "0x2000150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E284", Offset = "0x58E284")]
		private sealed class <StartStopTrain>d__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool startTrain;

			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TrainLocomotive <>4__this;

			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <endSpeed>5__2;

			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <timePeriodForSpeedChange>5__3;

			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <startTime>5__4;

			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <endTime>5__5;

			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float <startSpeed>5__6;

			[Token(Token = "0x170000BB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000643")]
				[Address(RVA = "0xF40660", Offset = "0xF40660", VA = "0xF40660", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000645")]
				[Address(RVA = "0xF406A8", Offset = "0xF406A8", VA = "0xF406A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000640")]
			[Address(RVA = "0xF403EC", Offset = "0xF403EC", VA = "0xF403EC")]
			[DebuggerHidden]
			public <StartStopTrain>d__34(int <>1__state)
			{
			}

			[Token(Token = "0x6000641")]
			[Address(RVA = "0xF40418", Offset = "0xF40418", VA = "0xF40418", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0xF4041C", Offset = "0xF4041C", VA = "0xF4041C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000644")]
			[Address(RVA = "0xF40668", Offset = "0xF40668", VA = "0xF40668", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000765")]
		private const float MIN_SPEED = 0.2f;

		[Token(Token = "0x4000766")]
		private const float MAX_SPEED = 2.7f;

		[Token(Token = "0x4000767")]
		private const float SMOKE_SPEED_MULTIPLIER = 8f;

		[Token(Token = "0x4000768")]
		private const int MAX_PARTICLES_MULTIPLIER = 3;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x590338", Offset = "0x590338")]
		[SerializeField]
		protected float _initialSpeed;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _decreaseSpeedButton;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _increaseSpeedButton;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _smokeButton;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _whistleButton;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _reverseButton;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AudioSource _whistleAudioSource;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AudioClip _whistleSound;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AudioSource _engineAudioSource;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AudioClip[] _accelerationSounds;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AudioClip[] _decelerationSounds;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AudioClip _startUpSound;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private AudioSource _smokeStackAudioSource;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AudioClip _smokeSound;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private ParticleSystem _smoke1;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ParticleSystem _smoke2;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private TrainCarBase[] _childCars;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool _isMoving;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		private bool _reverse;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float _currentSpeed;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _speedDiv;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _standardRateOverTimeMultiplier;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int _standardMaxParticles;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Coroutine _startStopTrainCr;

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xB0E888", Offset = "0xB0E888", VA = "0xB0E888")]
		private void Start()
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xB0E9F4", Offset = "0xB0E9F4", VA = "0xB0E9F4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xB0EA00", Offset = "0xB0EA00", VA = "0xB0EA00", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xB0EB50", Offset = "0xB0EB50", VA = "0xB0EB50")]
		public void StartStopStateChanged()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xB0E968", Offset = "0xB0E968", VA = "0xB0E968")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x592BA0", Offset = "0x592BA0")]
		private IEnumerator StartStopTrain(bool startTrain)
		{
			return null;
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xB0EBB0", Offset = "0xB0EBB0", VA = "0xB0EBB0")]
		private float PlayEngineSound(EngineSoundState engineSoundState)
		{
			return default(float);
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xB0EAEC", Offset = "0xB0EAEC", VA = "0xB0EAEC")]
		private void UpdateDistance()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xB0EDB4", Offset = "0xB0EDB4", VA = "0xB0EDB4")]
		public void DecreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xB0EED8", Offset = "0xB0EED8", VA = "0xB0EED8")]
		public void IncreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xB0EE20", Offset = "0xB0EE20", VA = "0xB0EE20")]
		private void UpdateSmokeEmissionBasedOnSpeed()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xB0EF44", Offset = "0xB0EF44", VA = "0xB0EF44")]
		private float GetCurrentSmokeEmission()
		{
			return default(float);
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xB0EF64", Offset = "0xB0EF64", VA = "0xB0EF64")]
		public void SmokeButtonStateChanged()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xB0EFF0", Offset = "0xB0EFF0", VA = "0xB0EFF0")]
		public void WhistleButtonStateChanged()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xB0F0A8", Offset = "0xB0F0A8", VA = "0xB0F0A8")]
		public void ReverseButtonStateChanged()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xB0F0B8", Offset = "0xB0F0B8", VA = "0xB0F0B8")]
		public TrainLocomotive()
		{
		}
	}
	[Token(Token = "0x2000151")]
	public class TrainTrack : MonoBehaviour
	{
		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _gridSize;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _subDivCount;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _segmentParent;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _trainParent;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _regnerateTrackMeshOnAwake;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _trainLength;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TrackSegment[] _trackSegments;

		[Token(Token = "0x170000BD")]
		public float TrackLength
		{
			[Token(Token = "0x6000646")]
			[Address(RVA = "0xB0F120", Offset = "0xB0F120", VA = "0xB0F120")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000647")]
			[Address(RVA = "0xB0F128", Offset = "0xB0F128", VA = "0xB0F128")]
			private set
			{
			}
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xB0F130", Offset = "0xB0F130", VA = "0xB0F130")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xB0E1DC", Offset = "0xB0E1DC", VA = "0xB0E1DC")]
		public TrackSegment GetSegment(float distance)
		{
			return null;
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xB0F134", Offset = "0xB0F134", VA = "0xB0F134")]
		public void Regenerate()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0xB0F348", Offset = "0xB0F348", VA = "0xB0F348")]
		private void SetScale(float ratio)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0xB0F444", Offset = "0xB0F444", VA = "0xB0F444")]
		public TrainTrack()
		{
		}
	}
	[Token(Token = "0x2000152")]
	public class Pose
	{
		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion Rotation;

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x84BA7C", Offset = "0x84BA7C", VA = "0x84BA7C")]
		public Pose()
		{
		}
	}
	[Token(Token = "0x2000153")]
	public class WindmillBladesController : MonoBehaviour
	{
		[Token(Token = "0x2000154")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E294", Offset = "0x58E294")]
		private sealed class <LerpToSpeed>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x40007A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float goalSpeed;

			[Token(Token = "0x40007A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <totalTime>5__2;

			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <startSpeed>5__3;

			[Token(Token = "0x170000BF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600065A")]
				[Address(RVA = "0xF40880", Offset = "0xF40880", VA = "0xF40880", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600065C")]
				[Address(RVA = "0xF408C8", Offset = "0xF408C8", VA = "0xF408C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0xF406B0", Offset = "0xF406B0", VA = "0xF406B0")]
			[DebuggerHidden]
			public <LerpToSpeed>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000658")]
			[Address(RVA = "0xF406DC", Offset = "0xF406DC", VA = "0xF406DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000659")]
			[Address(RVA = "0xF406E0", Offset = "0xF406E0", VA = "0xF406E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0xF40888", Offset = "0xF40888", VA = "0xF40888", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000155")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E2A4", Offset = "0x58E2A4")]
		private sealed class <PlaySoundDelayed>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AudioClip initial;

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float timeDelayAfterInitial;

			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public AudioClip clip;

			[Token(Token = "0x170000C1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000660")]
				[Address(RVA = "0xF409D8", Offset = "0xF409D8", VA = "0xF409D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000662")]
				[Address(RVA = "0xF40A20", Offset = "0xF40A20", VA = "0xF40A20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0xF408D0", Offset = "0xF408D0", VA = "0xF408D0")]
			[DebuggerHidden]
			public <PlaySoundDelayed>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x600065E")]
			[Address(RVA = "0xF408FC", Offset = "0xF408FC", VA = "0xF408FC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600065F")]
			[Address(RVA = "0xF40900", Offset = "0xF40900", VA = "0xF40900", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0xF409E0", Offset = "0xF409E0", VA = "0xF409E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000798")]
		private const float MAX_TIME = 1f;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip _windMillRotationSound;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClip _windMillStartSound;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip _windMillStopSound;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x590520", Offset = "0x590520")]
		private bool <IsMoving>k__BackingField;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _currentSpeed;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _lerpSpeedCoroutine;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Coroutine _audioChangeCr;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion _originalRotation;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _rotAngle;

		[Token(Token = "0x170000BE")]
		public bool IsMoving
		{
			[Token(Token = "0x600064E")]
			[Address(RVA = "0xB0FEA4", Offset = "0xB0FEA4", VA = "0xB0FEA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592C50", Offset = "0x592C50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600064F")]
			[Address(RVA = "0xB0FEAC", Offset = "0xB0FEAC", VA = "0xB0FEAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592C60", Offset = "0x592C60")]
			private set
			{
			}
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xB0FEB8", Offset = "0xB0FEB8", VA = "0xB0FEB8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xB0FEF4", Offset = "0xB0FEF4", VA = "0xB0FEF4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xB0FFD8", Offset = "0xB0FFD8", VA = "0xB0FFD8")]
		public void SetMoveState(bool newMoveState, float goalSpeed)
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xB1004C", Offset = "0xB1004C", VA = "0xB1004C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x592C70", Offset = "0x592C70")]
		private IEnumerator LerpToSpeed(float goalSpeed)
		{
			return null;
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xB100D4", Offset = "0xB100D4", VA = "0xB100D4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x592CD0", Offset = "0x592CD0")]
		private IEnumerator PlaySoundDelayed(AudioClip initial, AudioClip clip, float timeDelayAfterInitial)
		{
			return null;
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xB1018C", Offset = "0xB1018C", VA = "0xB1018C")]
		private void PlaySound(AudioClip clip, bool loop = false)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xB101F8", Offset = "0xB101F8", VA = "0xB101F8")]
		public WindmillBladesController()
		{
		}
	}
	[Token(Token = "0x2000156")]
	public class WindmillController : MonoBehaviour
	{
		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _maxSpeed;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WindmillBladesController _bladesRotation;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xB10200", Offset = "0xB10200", VA = "0xB10200")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xB10274", Offset = "0xB10274", VA = "0xB10274")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xB10358", Offset = "0xB10358", VA = "0xB10358")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xB10490", Offset = "0xB10490", VA = "0xB10490")]
		private void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xB10510", Offset = "0xB10510", VA = "0xB10510")]
		private void Update()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xB105EC", Offset = "0xB105EC", VA = "0xB105EC")]
		public WindmillController()
		{
		}
	}
	[Token(Token = "0x2000157")]
	public class OVROverlaySample : MonoBehaviour
	{
		[Token(Token = "0x2000158")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E2B4", Offset = "0x58E2B4")]
		private sealed class <WaitforOVROverlay>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OVROverlaySample <>4__this;

			[Token(Token = "0x170000C3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600067C")]
				[Address(RVA = "0xF3C55C", Offset = "0xF3C55C", VA = "0xF3C55C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600067E")]
				[Address(RVA = "0xF3C5A4", Offset = "0xF3C5A4", VA = "0xF3C5A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000679")]
			[Address(RVA = "0xF3C32C", Offset = "0xF3C32C", VA = "0xF3C32C")]
			[DebuggerHidden]
			public <WaitforOVROverlay>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0xF3C358", Offset = "0xF3C358", VA = "0xF3C358", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600067B")]
			[Address(RVA = "0xF3C35C", Offset = "0xF3C35C", VA = "0xF3C35C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600067D")]
			[Address(RVA = "0xF3C564", Offset = "0xF3C564", VA = "0xF3C564", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inMenu;

		[Token(Token = "0x40007B5")]
		private const string ovrOverlayID = "OVROverlayID";

		[Token(Token = "0x40007B6")]
		private const string applicationID = "ApplicationID";

		[Token(Token = "0x40007B7")]
		private const string noneID = "NoneID";

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Toggle applicationRadioButton;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Toggle noneRadioButton;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x590560", Offset = "0x590560")]
		public GameObject mainCamera;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject uiCamera;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject uiGeoParent;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject worldspaceGeoParent;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public OVROverlay cameraRenderOverlay;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public OVROverlay renderingLabelOverlay;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Texture applicationLabelTexture;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture compositorLabelTexture;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x590598", Offset = "0x590598")]
		public GameObject prefabForLevelLoadSim;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public OVROverlay cubemapOverlay;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public OVROverlay loadingTextQuadOverlay;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float distanceFromCamToLoadText;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float cubeSpawnRadius;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float heightBetweenItems;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int numObjectsPerLevel;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int numLevels;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int numLoopsTrigger;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<GameObject> spawnedCubes;

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xD87BC8", Offset = "0xD87BC8", VA = "0xD87BC8")]
		private void Start()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xD883FC", Offset = "0xD883FC", VA = "0xD883FC")]
		private void Update()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xD88544", Offset = "0xD88544", VA = "0xD88544")]
		private void ActivateWorldGeo()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xD88680", Offset = "0xD88680", VA = "0xD88680")]
		private void ActivateOVROverlay()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xD887BC", Offset = "0xD887BC", VA = "0xD887BC")]
		private void ActivateNone()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xD88518", Offset = "0xD88518", VA = "0xD88518")]
		private void TriggerLoad()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xD8889C", Offset = "0xD8889C", VA = "0xD8889C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x592DD0", Offset = "0x592DD0")]
		private IEnumerator WaitforOVROverlay()
		{
			return null;
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xD88914", Offset = "0xD88914", VA = "0xD88914")]
		private void TriggerUnload()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xD88030", Offset = "0xD88030", VA = "0xD88030")]
		private void CameraAndRenderTargetSetup()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xD88A68", Offset = "0xD88A68", VA = "0xD88A68")]
		private void SimulateLevelLoad()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xD88948", Offset = "0xD88948", VA = "0xD88948")]
		private void ClearObjects()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xD88D80", Offset = "0xD88D80", VA = "0xD88D80")]
		public void RadioPressed(string radioLabel, string group, Toggle t)
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xD88E70", Offset = "0xD88E70", VA = "0xD88E70")]
		public OVROverlaySample()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xD88F00", Offset = "0xD88F00", VA = "0xD88F00")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592E30", Offset = "0x592E30")]
		private void <Start>b__24_0(Toggle t)
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xD88F58", Offset = "0xD88F58", VA = "0xD88F58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592E40", Offset = "0x592E40")]
		private void <Start>b__24_1(Toggle t)
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xD88FB0", Offset = "0xD88FB0", VA = "0xD88FB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592E50", Offset = "0x592E50")]
		private void <Start>b__24_2(Toggle t)
		{
		}
	}
}
namespace OVRTouchSample
{
	[Token(Token = "0x2000159")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x58E2C4", Offset = "0x58E2C4")]
	public class Hand : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200015A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E324", Offset = "0x58E324")]
		private sealed class <>c
		{
			[Token(Token = "0x40007EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40007EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Collider, bool> <>9__28_0;

			[Token(Token = "0x600068C")]
			[Address(RVA = "0xF3969C", Offset = "0xF3969C", VA = "0xF3969C")]
			public <>c()
			{
			}

			[Token(Token = "0x600068D")]
			[Address(RVA = "0xF396A4", Offset = "0xF396A4", VA = "0xF396A4")]
			internal bool <Start>b__28_0(Collider childCollider)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40007CF")]
		public const string ANIM_LAYER_NAME_POINT = "Point Layer";

		[Token(Token = "0x40007D0")]
		public const string ANIM_LAYER_NAME_THUMB = "Thumb Layer";

		[Token(Token = "0x40007D1")]
		public const string ANIM_PARAM_NAME_FLEX = "Flex";

		[Token(Token = "0x40007D2")]
		public const string ANIM_PARAM_NAME_POSE = "Pose";

		[Token(Token = "0x40007D3")]
		public const float THRESH_COLLISION_FLEX = 0.9f;

		[Token(Token = "0x40007D4")]
		public const float INPUT_RATE_CHANGE = 20f;

		[Token(Token = "0x40007D5")]
		public const float COLLIDER_SCALE_MIN = 0.01f;

		[Token(Token = "0x40007D6")]
		public const float COLLIDER_SCALE_MAX = 1f;

		[Token(Token = "0x40007D7")]
		public const float COLLIDER_SCALE_PER_SECOND = 1f;

		[Token(Token = "0x40007D8")]
		public const float TRIGGER_DEBOUNCE_TIME = 0.05f;

		[Token(Token = "0x40007D9")]
		public const float THUMB_DEBOUNCE_TIME = 0.15f;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HandPose m_defaultGrabPose;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Collider[] m_colliders;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_collisionEnabled;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRGrabber m_grabber;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Renderer> m_showAfterInputFocusAcquired;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_animLayerIndexThumb;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_animLayerIndexPoint;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_animParamIndexFlex;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_animParamIndexPose;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_isPointing;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool m_isGivingThumbsUp;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_pointBlend;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_thumbsUpBlend;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_collisionScaleCurrent;

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xB483E8", Offset = "0xB483E8", VA = "0xB483E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xB48444", Offset = "0xB48444", VA = "0xB48444")]
		private void Start()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xB488D8", Offset = "0xB488D8", VA = "0xB488D8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xB489C4", Offset = "0xB489C4", VA = "0xB489C4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xB48B28", Offset = "0xB48B28", VA = "0xB48B28")]
		private void UpdateCapTouchStates()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xB48E30", Offset = "0xB48E30", VA = "0xB48E30")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xB48F28", Offset = "0xB48F28", VA = "0xB48F28")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xB49088", Offset = "0xB49088", VA = "0xB49088")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xB48BC0", Offset = "0xB48BC0", VA = "0xB48BC0")]
		private float InputValueRateChange(bool isDown, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xB48C14", Offset = "0xB48C14", VA = "0xB48C14")]
		private void UpdateAnimStates()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xB4877C", Offset = "0xB4877C", VA = "0xB4877C")]
		private void CollisionEnable(bool enabled)
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xB491C4", Offset = "0xB491C4", VA = "0xB491C4")]
		public Hand()
		{
		}
	}
	[Token(Token = "0x200015B")]
	public enum HandPoseId
	{
		[Token(Token = "0x40007EE")]
		Default,
		[Token(Token = "0x40007EF")]
		Generic,
		[Token(Token = "0x40007F0")]
		PingPongBall,
		[Token(Token = "0x40007F1")]
		Controller
	}
	[Token(Token = "0x200015C")]
	public class HandPose : MonoBehaviour
	{
		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_allowPointing;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool m_allowThumbsUp;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private HandPoseId m_poseId;

		[Token(Token = "0x170000C5")]
		public bool AllowPointing
		{
			[Token(Token = "0x600068E")]
			[Address(RVA = "0xB4D608", Offset = "0xB4D608", VA = "0xB4D608")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C6")]
		public bool AllowThumbsUp
		{
			[Token(Token = "0x600068F")]
			[Address(RVA = "0xB4D610", Offset = "0xB4D610", VA = "0xB4D610")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C7")]
		public HandPoseId PoseId
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0xB4D618", Offset = "0xB4D618", VA = "0xB4D618")]
			get
			{
				return default(HandPoseId);
			}
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xB4D620", Offset = "0xB4D620", VA = "0xB4D620")]
		public HandPose()
		{
		}
	}
	[Token(Token = "0x200015D")]
	public class TouchController : MonoBehaviour
	{
		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xB0BF2C", Offset = "0xB0BF2C", VA = "0xB0BF2C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xB0C214", Offset = "0xB0C214", VA = "0xB0C214")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xB0C270", Offset = "0xB0C270", VA = "0xB0C270")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xB0C2B4", Offset = "0xB0C2B4", VA = "0xB0C2B4")]
		public TouchController()
		{
		}
	}
}
namespace Oculus.Avatar
{
	[Token(Token = "0x200015E")]
	public class CAPI
	{
		[Token(Token = "0x200015F")]
		public delegate void LoggingDelegate(IntPtr str);

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IntPtr nativeVisemeData;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static IntPtr nativeGazeTargetsData;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static IntPtr nativeAvatarLightsData;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static IntPtr DebugLineCountData;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static float[] scratchBufferFloat;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static GameObject debugLineGo;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static string SDKRuntimePrefix;

		[PreserveSig]
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x859410", Offset = "0x859410", VA = "0x859410")]
		public static extern void ovrAvatar_InitializeAndroidUnity(string appID);

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x8594A0", Offset = "0x8594A0", VA = "0x8594A0")]
		public static void Initialize()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x8596C4", Offset = "0x8596C4", VA = "0x8596C4")]
		public static void Shutdown()
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000699")]
		[Address(RVA = "0x8597B0", Offset = "0x8597B0", VA = "0x8597B0")]
		public static extern void ovrAvatar_Shutdown();

		[PreserveSig]
		[Token(Token = "0x600069A")]
		[Address(RVA = "0x859820", Offset = "0x859820", VA = "0x859820")]
		public static extern IntPtr ovrAvatarMessage_Pop();

		[PreserveSig]
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x859894", Offset = "0x859894", VA = "0x859894")]
		public static extern ovrAvatarMessageType ovrAvatarMessage_GetType(IntPtr msg);

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x859914", Offset = "0x859914", VA = "0x859914")]
		public static ovrAvatarMessage_AvatarSpecification ovrAvatarMessage_GetAvatarSpecification(IntPtr msg)
		{
			return default(ovrAvatarMessage_AvatarSpecification);
		}

		[PreserveSig]
		[Token(Token = "0x600069D")]
		[Address(RVA = "0x859A58", Offset = "0x859A58", VA = "0x859A58")]
		private static extern IntPtr ovrAvatarMessage_GetAvatarSpecification_Native(IntPtr msg);

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x859AD8", Offset = "0x859AD8", VA = "0x859AD8")]
		public static ovrAvatarMessage_AssetLoaded ovrAvatarMessage_GetAssetLoaded(IntPtr msg)
		{
			return default(ovrAvatarMessage_AssetLoaded);
		}

		[PreserveSig]
		[Token(Token = "0x600069F")]
		[Address(RVA = "0x859C1C", Offset = "0x859C1C", VA = "0x859C1C")]
		private static extern IntPtr ovrAvatarMessage_GetAssetLoaded_Native(IntPtr msg);

		[PreserveSig]
		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x859C9C", Offset = "0x859C9C", VA = "0x859C9C")]
		public static extern void ovrAvatarMessage_Free(IntPtr msg);

		[PreserveSig]
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x859D1C", Offset = "0x859D1C", VA = "0x859D1C")]
		public static extern IntPtr ovrAvatarSpecificationRequest_Create(ulong userID);

		[PreserveSig]
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x859D9C", Offset = "0x859D9C", VA = "0x859D9C")]
		public static extern void ovrAvatarSpecificationRequest_Destroy(IntPtr specificationRequest);

		[PreserveSig]
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x859E1C", Offset = "0x859E1C", VA = "0x859E1C")]
		public static extern void ovrAvatarSpecificationRequest_SetCombineMeshes(IntPtr specificationRequest, bool useCombinedMesh);

		[PreserveSig]
		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x859EAC", Offset = "0x859EAC", VA = "0x859EAC")]
		public static extern void ovrAvatarSpecificationRequest_SetLookAndFeelVersion(IntPtr specificationRequest, ovrAvatarLookAndFeelVersion version);

		[PreserveSig]
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x859F3C", Offset = "0x859F3C", VA = "0x859F3C")]
		public static extern void ovrAvatarSpecificationRequest_SetLevelOfDetail(IntPtr specificationRequest, ovrAvatarAssetLevelOfDetail lod);

		[PreserveSig]
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x859FCC", Offset = "0x859FCC", VA = "0x859FCC")]
		public static extern void ovrAvatar_RequestAvatarSpecificationFromSpecRequest(IntPtr specificationRequest);

		[PreserveSig]
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x85A04C", Offset = "0x85A04C", VA = "0x85A04C")]
		public static extern void ovrAvatarSpecificationRequest_SetFallbackLookAndFeelVersion(IntPtr specificationRequest, ovrAvatarLookAndFeelVersion version);

		[PreserveSig]
		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x85A0DC", Offset = "0x85A0DC", VA = "0x85A0DC")]
		public static extern void ovrAvatarSpecificationRequest_SetExpressiveFlag(IntPtr specificationRequest, bool enable);

		[PreserveSig]
		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x85A16C", Offset = "0x85A16C", VA = "0x85A16C")]
		public static extern IntPtr ovrAvatar_Create(IntPtr avatarSpecification, ovrAvatarCapabilities capabilities);

		[PreserveSig]
		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x85A1FC", Offset = "0x85A1FC", VA = "0x85A1FC")]
		public static extern void ovrAvatar_Destroy(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x85A27C", Offset = "0x85A27C", VA = "0x85A27C")]
		public static extern void ovrAvatarPose_UpdateBody(IntPtr avatar, ovrAvatarTransform headPose);

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x85A31C", Offset = "0x85A31C", VA = "0x85A31C")]
		public static void ovrAvatarPose_UpdateVoiceVisualization(IntPtr avatar, float[] pcmData)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x85A398", Offset = "0x85A398", VA = "0x85A398")]
		private static extern void ovrAvatarPose_UpdateVoiceVisualization_Native(IntPtr avatar, uint pcmDataSize, [In] float[] pcmData);

		[PreserveSig]
		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x85A438", Offset = "0x85A438", VA = "0x85A438")]
		public static extern void ovrAvatarPose_UpdateHandsWithType(IntPtr avatar, ovrAvatarHandInputState inputStateLeft, ovrAvatarHandInputState inputStateRight, ovrAvatarControllerType type);

		[PreserveSig]
		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x85A508", Offset = "0x85A508", VA = "0x85A508")]
		public static extern void ovrAvatarPose_Finalize(IntPtr avatar, float elapsedSeconds);

		[PreserveSig]
		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x85A598", Offset = "0x85A598", VA = "0x85A598")]
		public static extern void ovrAvatar_SetLeftControllerVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x85A628", Offset = "0x85A628", VA = "0x85A628")]
		public static extern void ovrAvatar_SetRightControllerVisibility(IntPtr avatar, bool show);

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x85A6B8", Offset = "0x85A6B8", VA = "0x85A6B8")]
		public static void ovrAvatarComponent_Get(IntPtr componentPtr, bool includeName, ref ovrAvatarComponent component)
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x85A8D8", Offset = "0x85A8D8", VA = "0x85A8D8")]
		public static bool ovrAvatarPose_GetBaseComponent(IntPtr avatar, ref ovrAvatarBaseComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x85AA48", Offset = "0x85AA48", VA = "0x85AA48")]
		private static extern IntPtr ovrAvatarPose_GetBaseComponent_Native(IntPtr avatar);

		[Token(Token = "0x60006B5")]
		public static IntPtr MarshalRenderComponent<T>(IntPtr ptr) where T : struct
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x85AAC8", Offset = "0x85AAC8", VA = "0x85AAC8")]
		public static bool ovrAvatarPose_GetBodyComponent(IntPtr avatar, ref ovrAvatarBodyComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x85AD70", Offset = "0x85AD70", VA = "0x85AD70")]
		private static extern IntPtr ovrAvatarPose_GetBodyComponent_Native(IntPtr avatar);

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x85ADF0", Offset = "0x85ADF0", VA = "0x85ADF0")]
		public static bool ovrAvatarPose_GetLeftControllerComponent(IntPtr avatar, ref ovrAvatarControllerComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x85AF60", Offset = "0x85AF60", VA = "0x85AF60")]
		private static extern IntPtr ovrAvatarPose_GetLeftControllerComponent_Native(IntPtr avatar);

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x85AFE0", Offset = "0x85AFE0", VA = "0x85AFE0")]
		public static bool ovrAvatarPose_GetRightControllerComponent(IntPtr avatar, ref ovrAvatarControllerComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x85B150", Offset = "0x85B150", VA = "0x85B150")]
		private static extern IntPtr ovrAvatarPose_GetRightControllerComponent_Native(IntPtr avatar);

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x85B1D0", Offset = "0x85B1D0", VA = "0x85B1D0")]
		public static bool ovrAvatarPose_GetLeftHandComponent(IntPtr avatar, ref ovrAvatarHandComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x85B340", Offset = "0x85B340", VA = "0x85B340")]
		private static extern IntPtr ovrAvatarPose_GetLeftHandComponent_Native(IntPtr avatar);

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x85B3C0", Offset = "0x85B3C0", VA = "0x85B3C0")]
		public static bool ovrAvatarPose_GetRightHandComponent(IntPtr avatar, ref ovrAvatarHandComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x85B530", Offset = "0x85B530", VA = "0x85B530")]
		private static extern IntPtr ovrAvatarPose_GetRightHandComponent_Native(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x85B5B0", Offset = "0x85B5B0", VA = "0x85B5B0")]
		public static extern bool ovrAvatarAsset_BeginLoadingLOD(ulong assetId, ovrAvatarAssetLevelOfDetail lod);

		[PreserveSig]
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x85B648", Offset = "0x85B648", VA = "0x85B648")]
		public static extern ovrAvatarAssetType ovrAvatarAsset_GetType(IntPtr assetHandle);

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x85B6C8", Offset = "0x85B6C8", VA = "0x85B6C8")]
		public static ovrAvatarMeshAssetData ovrAvatarAsset_GetMeshData(IntPtr assetPtr)
		{
			return default(ovrAvatarMeshAssetData);
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x85B8A0", Offset = "0x85B8A0", VA = "0x85B8A0")]
		public static ovrAvatarMeshAssetDataV2 ovrAvatarAsset_GetCombinedMeshData(IntPtr assetPtr)
		{
			return default(ovrAvatarMeshAssetDataV2);
		}

		[PreserveSig]
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x85B9F8", Offset = "0x85B9F8", VA = "0x85B9F8")]
		private static extern IntPtr ovrAvatarAsset_GetCombinedMeshData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x85B820", Offset = "0x85B820", VA = "0x85B820")]
		private static extern IntPtr ovrAvatarAsset_GetMeshData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x85BA78", Offset = "0x85BA78", VA = "0x85BA78")]
		public static extern uint ovrAvatarAsset_GetMeshBlendShapeCount(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x85BAF8", Offset = "0x85BAF8", VA = "0x85BAF8")]
		public static extern IntPtr ovrAvatarAsset_GetMeshBlendShapeName(IntPtr assetPtr, uint index);

		[PreserveSig]
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x85BB88", Offset = "0x85BB88", VA = "0x85BB88")]
		public static extern uint ovrAvatarAsset_GetSubmeshCount(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x85BC08", Offset = "0x85BC08", VA = "0x85BC08")]
		public static extern uint ovrAvatarAsset_GetSubmeshLastIndex(IntPtr assetPtr, uint index);

		[PreserveSig]
		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x85BC98", Offset = "0x85BC98", VA = "0x85BC98")]
		public static extern IntPtr ovrAvatarAsset_GetMeshBlendShapeVertices(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x85BD18", Offset = "0x85BD18", VA = "0x85BD18")]
		public static extern IntPtr ovrAvatarAsset_GetAvatar(IntPtr assetHandle);

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x85BD98", Offset = "0x85BD98", VA = "0x85BD98")]
		public static ulong[] ovrAvatarAsset_GetCombinedMeshIDs(IntPtr assetHandle)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x85C024", Offset = "0x85C024", VA = "0x85C024")]
		public static extern IntPtr ovrAvatarAsset_GetCombinedMeshIDs_Native(IntPtr assetHandle, IntPtr count);

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x85C0B4", Offset = "0x85C0B4", VA = "0x85C0B4")]
		public static void ovrAvatar_GetCombinedMeshAlphaData(IntPtr avatar, ref ulong textureID, ref Vector4 offset)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x85C2E4", Offset = "0x85C2E4", VA = "0x85C2E4")]
		public static extern IntPtr ovrAvatar_GetCombinedMeshAlphaData_Native(IntPtr avatar, IntPtr textureIDPtr, IntPtr offsetPtr);

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x85C37C", Offset = "0x85C37C", VA = "0x85C37C")]
		public static ovrAvatarTextureAssetData ovrAvatarAsset_GetTextureData(IntPtr assetPtr)
		{
			return default(ovrAvatarTextureAssetData);
		}

		[PreserveSig]
		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x85C4CC", Offset = "0x85C4CC", VA = "0x85C4CC")]
		private static extern IntPtr ovrAvatarAsset_GetTextureData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x85C54C", Offset = "0x85C54C", VA = "0x85C54C")]
		private static extern IntPtr ovrAvatarAsset_GetMaterialData_Native(IntPtr assetPtr);

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x85C5CC", Offset = "0x85C5CC", VA = "0x85C5CC")]
		public static ovrAvatarMaterialState ovrAvatarAsset_GetMaterialState(IntPtr assetPtr)
		{
			return default(ovrAvatarMaterialState);
		}

		[PreserveSig]
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x85C720", Offset = "0x85C720", VA = "0x85C720")]
		public static extern ovrAvatarRenderPartType ovrAvatarRenderPart_GetType(IntPtr renderPart);

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x85C7A0", Offset = "0x85C7A0", VA = "0x85C7A0")]
		public static ovrAvatarRenderPart_SkinnedMeshRender ovrAvatarRenderPart_GetSkinnedMeshRender(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRender);
		}

		[PreserveSig]
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x85C8F4", Offset = "0x85C8F4", VA = "0x85C8F4")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRender_Native(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x85C974", Offset = "0x85C974", VA = "0x85C974")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRender_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x85CA04", Offset = "0x85CA04", VA = "0x85CA04")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBS_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x85CA94", Offset = "0x85CA94", VA = "0x85CA94")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBSV2_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x85CB24", Offset = "0x85CB24", VA = "0x85CB24")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRender_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x85CBA4", Offset = "0x85CBA4", VA = "0x85CBA4")]
		public static extern bool ovrAvatarSkinnedMeshRender_MaterialStateChanged(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x85CC2C", Offset = "0x85CC2C", VA = "0x85CC2C")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRenderPBS_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x85CCAC", Offset = "0x85CCAC", VA = "0x85CCAC")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRenderPBSV2_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x85CD2C", Offset = "0x85CD2C", VA = "0x85CD2C")]
		public static extern ovrAvatarMaterialState ovrAvatarSkinnedMeshRender_GetMaterialState(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x85CDE0", Offset = "0x85CDE0", VA = "0x85CDE0")]
		public static extern ovrAvatarPBSMaterialState ovrAvatarSkinnedMeshRenderPBSV2_GetPBSMaterialState(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x85CE70", Offset = "0x85CE70", VA = "0x85CE70")]
		public static extern ovrAvatarExpressiveParameters ovrAvatar_GetExpressiveParameters(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x85CF00", Offset = "0x85CF00", VA = "0x85CF00")]
		public static extern ulong ovrAvatarSkinnedMeshRender_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x85CF80", Offset = "0x85CF80", VA = "0x85CF80")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x85D000", Offset = "0x85D000", VA = "0x85D000")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBSV2_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x85D080", Offset = "0x85D080", VA = "0x85D080")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRender_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x85D118", Offset = "0x85D118", VA = "0x85D118")]
		public static extern void ovrAvatar_SetActionUnitOnsetSpeed(IntPtr avatar, float onsetSpeed);

		[PreserveSig]
		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x85D1A8", Offset = "0x85D1A8", VA = "0x85D1A8")]
		public static extern void ovrAvatar_SetActionUnitFalloffSpeed(IntPtr avatar, float falloffSpeed);

		[PreserveSig]
		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x85D238", Offset = "0x85D238", VA = "0x85D238")]
		public static extern void ovrAvatar_SetVisemeMultiplier(IntPtr avatar, float visemeMultiplier);

		[PreserveSig]
		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x85D2C8", Offset = "0x85D2C8", VA = "0x85D2C8")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBS_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x85D360", Offset = "0x85D360", VA = "0x85D360")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBSV2_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x85D3F8", Offset = "0x85D3F8", VA = "0x85D3F8")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetAlbedoTextureAssetID(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x85D478", Offset = "0x85D478", VA = "0x85D478")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetSurfaceTextureAssetID(IntPtr renderPart);

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x85D4F8", Offset = "0x85D4F8", VA = "0x85D4F8")]
		public static ovrAvatarRenderPart_SkinnedMeshRenderPBS ovrAvatarRenderPart_GetSkinnedMeshRenderPBS(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRenderPBS);
		}

		[PreserveSig]
		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x85D64C", Offset = "0x85D64C", VA = "0x85D64C")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRenderPBS_Native(IntPtr renderPart);

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x85D6CC", Offset = "0x85D6CC", VA = "0x85D6CC")]
		public static ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 ovrAvatarRenderPart_GetSkinnedMeshRenderPBSV2(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2);
		}

		[PreserveSig]
		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x85D820", Offset = "0x85D820", VA = "0x85D820")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRenderPBSV2_Native(IntPtr renderPart);

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x85D8A0", Offset = "0x85D8A0", VA = "0x85D8A0")]
		public static void ovrAvatarSkinnedMeshRender_GetBlendShapeParams(IntPtr renderPart, ref ovrAvatarBlendShapeParams blendParams)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x85D9DC", Offset = "0x85D9DC", VA = "0x85D9DC")]
		private static extern IntPtr ovrAvatarSkinnedMeshRender_GetBlendShapeParams_Native(IntPtr renderPart);

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x85DA5C", Offset = "0x85DA5C", VA = "0x85DA5C")]
		public static ovrAvatarPBSMaterialState[] ovrAvatar_GetBodyPBSMaterialStates(IntPtr renderPart)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x85DD3C", Offset = "0x85DD3C", VA = "0x85DD3C")]
		private static extern IntPtr ovrAvatar_GetBodyPBSMaterialStates_Native(IntPtr avatar, IntPtr count);

		[PreserveSig]
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x85DDCC", Offset = "0x85DDCC", VA = "0x85DDCC")]
		public static extern uint ovrAvatar_GetReferencedAssetCount(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x85DE4C", Offset = "0x85DE4C", VA = "0x85DE4C")]
		public static extern ulong ovrAvatar_GetReferencedAsset(IntPtr avatar, uint index);

		[PreserveSig]
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x85DEDC", Offset = "0x85DEDC", VA = "0x85DEDC")]
		public static extern void ovrAvatar_SetLeftHandGesture(IntPtr avatar, ovrAvatarHandGesture gesture);

		[PreserveSig]
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x85DF6C", Offset = "0x85DF6C", VA = "0x85DF6C")]
		public static extern void ovrAvatar_SetRightHandGesture(IntPtr avatar, ovrAvatarHandGesture gesture);

		[PreserveSig]
		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x85DFFC", Offset = "0x85DFFC", VA = "0x85DFFC")]
		public static extern void ovrAvatar_SetLeftHandCustomGesture(IntPtr avatar, uint jointCount, [In] ovrAvatarTransform[] customJointTransforms);

		[PreserveSig]
		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x85E09C", Offset = "0x85E09C", VA = "0x85E09C")]
		public static extern void ovrAvatar_SetRightHandCustomGesture(IntPtr avatar, uint jointCount, [In] ovrAvatarTransform[] customJointTransforms);

		[PreserveSig]
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x85E13C", Offset = "0x85E13C", VA = "0x85E13C")]
		public static extern void ovrAvatar_UpdatePoseFromPacket(IntPtr avatar, IntPtr packet, float secondsFromStart);

		[PreserveSig]
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x85E1DC", Offset = "0x85E1DC", VA = "0x85E1DC")]
		public static extern void ovrAvatarPacket_BeginRecording(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x85E25C", Offset = "0x85E25C", VA = "0x85E25C")]
		public static extern IntPtr ovrAvatarPacket_EndRecording(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x85E2DC", Offset = "0x85E2DC", VA = "0x85E2DC")]
		public static extern uint ovrAvatarPacket_GetSize(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x85E35C", Offset = "0x85E35C", VA = "0x85E35C")]
		public static extern float ovrAvatarPacket_GetDurationSeconds(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x85E3DC", Offset = "0x85E3DC", VA = "0x85E3DC")]
		public static extern void ovrAvatarPacket_Free(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x6000700")]
		[Address(RVA = "0x85E45C", Offset = "0x85E45C", VA = "0x85E45C")]
		public static extern bool ovrAvatarPacket_Write(IntPtr packet, uint bufferSize, [Out] byte[] buffer);

		[PreserveSig]
		[Token(Token = "0x6000701")]
		[Address(RVA = "0x85E584", Offset = "0x85E584", VA = "0x85E584")]
		public static extern IntPtr ovrAvatarPacket_Read(uint bufferSize, [In] byte[] buffer);

		[PreserveSig]
		[Token(Token = "0x6000702")]
		[Address(RVA = "0x85E61C", Offset = "0x85E61C", VA = "0x85E61C")]
		private static extern void ovrAvatar_SetInternalForceASTCTextures(bool value);

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x85E69C", Offset = "0x85E69C", VA = "0x85E69C")]
		public static void ovrAvatar_SetForceASTCTextures(bool value)
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x85E6FC", Offset = "0x85E6FC", VA = "0x85E6FC")]
		public static void ovrAvatar_SetVisemes(IntPtr avatar, ovrAvatarVisemes visemes)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000705")]
		[Address(RVA = "0x85E854", Offset = "0x85E854", VA = "0x85E854")]
		private static extern void ovrAvatar_SetVisemes_Native(IntPtr avatar, IntPtr visemes);

		[PreserveSig]
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x85E8E4", Offset = "0x85E8E4", VA = "0x85E8E4")]
		public static extern void ovrAvatar_UpdateWorldTransform(IntPtr avatar, ovrAvatarTransform transform);

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x85E984", Offset = "0x85E984", VA = "0x85E984")]
		public static void ovrAvatar_UpdateGazeTargets(ovrAvatarGazeTargets targets)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x85ED54", Offset = "0x85ED54", VA = "0x85ED54")]
		private static extern void ovrAvatar_UpdateGazeTargets_Native(IntPtr targets);

		[PreserveSig]
		[Token(Token = "0x6000709")]
		[Address(RVA = "0x85EDD4", Offset = "0x85EDD4", VA = "0x85EDD4")]
		public static extern void ovrAvatar_RemoveGazeTargets(uint targetCount, uint[] ids);

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x85EE6C", Offset = "0x85EE6C", VA = "0x85EE6C")]
		public static void ovrAvatar_UpdateLights(ovrAvatarLights lights)
		{
		}

		[PreserveSig]
		[Token(Token = "0x600070B")]
		[Address(RVA = "0x85F6CC", Offset = "0x85F6CC", VA = "0x85F6CC")]
		private static extern void ovrAvatar_UpdateLights_Native(IntPtr lights);

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x8593AC", Offset = "0x8593AC", VA = "0x8593AC")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x592EB0", Offset = "0x592EB0")]
		public static void LoggingCallback(IntPtr str)
		{
		}

		[PreserveSig]
		[Token(Token = "0x600070D")]
		[Address(RVA = "0x85F74C", Offset = "0x85F74C", VA = "0x85F74C")]
		public static extern void ovrAvatar_RegisterLoggingCallback(LoggingDelegate callback);

		[PreserveSig]
		[Token(Token = "0x600070E")]
		[Address(RVA = "0x85F7D0", Offset = "0x85F7D0", VA = "0x85F7D0")]
		public static extern void ovrAvatar_SetLoggingLevel(ovrAvatarLogLevel level);
	}
}
namespace UnityEngine.Rendering.Universal
{
	[Token(Token = "0x2000160")]
	public class MobileBloomUrp : ScriptableRendererFeature
	{
		[Serializable]
		[Token(Token = "0x2000161")]
		public class MobileBloomSettings
		{
			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RenderPassEvent Event;

			[Token(Token = "0x4000802")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Material blitMaterial;

			[Token(Token = "0x4000803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x590650", Offset = "0x590650")]
			public float BloomDiffusion;

			[Token(Token = "0x4000804")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Color BloomColor;

			[Token(Token = "0x4000805")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x590668", Offset = "0x590668")]
			public float BloomAmount;

			[Token(Token = "0x4000806")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x590680", Offset = "0x590680")]
			public float BloomThreshold;

			[Token(Token = "0x4000807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x590698", Offset = "0x590698")]
			public float BloomSoftness;

			[Token(Token = "0x6000717")]
			[Address(RVA = "0xF3BFA8", Offset = "0xF3BFA8", VA = "0xF3BFA8")]
			public MobileBloomSettings()
			{
			}
		}

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MobileBloomSettings settings;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MobileBloomUrpPass mobileBloomUrpPass;

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xFC9BD8", Offset = "0xFC9BD8", VA = "0xFC9BD8", Slot = "5")]
		public override void Create()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xFC9EC8", Offset = "0xFC9EC8", VA = "0xFC9EC8", Slot = "6")]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xFC9F50", Offset = "0xFC9F50", VA = "0xFC9F50")]
		public MobileBloomUrp()
		{
		}
	}
	[Token(Token = "0x2000162")]
	internal class MobileBloomUrpPass : ScriptableRenderPass
	{
		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Material material;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RenderTargetIdentifier source;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RenderTargetIdentifier bloomTemp;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private RenderTargetIdentifier bloomTemp1;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RenderTargetIdentifier bloomTex;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private RenderTargetIdentifier tempCopy;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private readonly string tag;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private readonly float bloomDiffusion;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private readonly Color bloomColor;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private readonly float bloomAmount;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private readonly float bloomThreshold;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private readonly float bloomSoftness;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int numberOfPasses;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float knee;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int blurAmountString;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int bloomColorString;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int blDataString;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int bloomTempString;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int bloomTemp1String;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static readonly int bloomTexString;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly int tempCopyString;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private RenderTextureDescriptor opaqueDesc;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private RenderTextureDescriptor half;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private RenderTextureDescriptor quarter;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		private RenderTextureDescriptor eighths;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private RenderTextureDescriptor sixths;

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xFC9CCC", Offset = "0xFC9CCC", VA = "0xFC9CCC")]
		public MobileBloomUrpPass(RenderPassEvent renderPassEvent, Material material, float bloomDiffusion, Color bloomColor, float bloomAmount, float bloomThreshold, float bloomSoftness, string tag)
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xFC9FC0", Offset = "0xFC9FC0", VA = "0xFC9FC0")]
		public void Setup(RenderTargetIdentifier source)
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xFC9FD8", Offset = "0xFC9FD8", VA = "0xFC9FD8", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xFCAD60", Offset = "0xFCAD60", VA = "0xFCAD60", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}
	}
}
namespace Qusasar.Marbles
{
	[Token(Token = "0x2000163")]
	public enum BallState
	{
		[Token(Token = "0x4000823")]
		NONE,
		[Token(Token = "0x4000824")]
		GUN,
		[Token(Token = "0x4000825")]
		BOUNCING,
		[Token(Token = "0x4000826")]
		INSERTING,
		[Token(Token = "0x4000827")]
		PATH
	}
	[Token(Token = "0x2000164")]
	public class Ball : MonoBehaviour
	{
		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5906B0", Offset = "0x5906B0")]
		private BallState <State>k__BackingField;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5906C0", Offset = "0x5906C0")]
		public ObjectType type;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5906F8", Offset = "0x5906F8")]
		public ObjectType DestroyEffectType;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x590730", Offset = "0x590730")]
		public ObjectType VanishEffectType;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x590768", Offset = "0x590768")]
		public ObjectType DestroySoundType;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5907A0", Offset = "0x5907A0")]
		public bool InsertsIntoPath;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color shootLineColor;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BallPath path;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BallManager ballManager;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SphereCollider solidCollider;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public BonusItem BonusItem;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float Radius;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float RejoinSpeed;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool Rejoining;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float ThrowSpeed;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool wasShotFromRightGun;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float CurrPathPos;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public bool Remove;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		[HideInInspector]
		public bool ConsumeAtRemove;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ObjectAutoDestroy autoDestroy;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Rigidbody rigidBody;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private BallRotateMove rotateMove;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float defaultColliderRadius;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Ball hitBallBeforeInserting;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		protected Action preReset;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Action postReset;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float ghostScale;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private bool isGhost;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float ghostScaleTimer;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float GHOST_SCALE_TIME;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Ball ghostBallTarget;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 insertStartPos;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public bool REMOVE_BALL;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float FireBallActionRadius;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private int FireBallMaxDestroyBallsCount;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int FireBallDestroyedBallsCount;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private List<Ball> FireBallReachedBalls;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[HideInInspector]
		public Vector3 moveVector;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private float prevGhostTimerNorm;

		[Token(Token = "0x170000C8")]
		public BallState State
		{
			[Token(Token = "0x600071D")]
			[Address(RVA = "0x140AAFC", Offset = "0x140AAFC", VA = "0x140AAFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592F10", Offset = "0x592F10")]
			get
			{
				return default(BallState);
			}
			[Token(Token = "0x600071E")]
			[Address(RVA = "0x140AB04", Offset = "0x140AB04", VA = "0x140AB04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592F20", Offset = "0x592F20")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		public bool IsGhost
		{
			[Token(Token = "0x600071F")]
			[Address(RVA = "0x140AB0C", Offset = "0x140AB0C", VA = "0x140AB0C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000720")]
			[Address(RVA = "0x140AB14", Offset = "0x140AB14", VA = "0x140AB14")]
			private set
			{
			}
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x140AB20", Offset = "0x140AB20", VA = "0x140AB20")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x140AE98", Offset = "0x140AE98", VA = "0x140AE98")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x140AF98", Offset = "0x140AF98", VA = "0x140AF98")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x140B098", Offset = "0x140B098", VA = "0x140B098")]
		private void OnPlayerLostEvent()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x140B140", Offset = "0x140B140", VA = "0x140B140")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x140B42C", Offset = "0x140B42C", VA = "0x140B42C")]
		public void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x140AC1C", Offset = "0x140AC1C", VA = "0x140AC1C")]
		private void GetComponents()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x140B548", Offset = "0x140B548", VA = "0x140B548")]
		public void SpawnDestroyEffect()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x140B754", Offset = "0x140B754", VA = "0x140B754")]
		public void SpawnVanishEffect()
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x140B8D0", Offset = "0x140B8D0", VA = "0x140B8D0")]
		public void SetState(BallState newState)
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x140B2D0", Offset = "0x140B2D0", VA = "0x140B2D0")]
		public void SetGhost(bool on)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x140BA78", Offset = "0x140BA78", VA = "0x140BA78")]
		public void CopyPropertiesFromGhost()
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x140BB18", Offset = "0x140BB18", VA = "0x140BB18")]
		private void UpdateGhost()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x140BBE8", Offset = "0x140BBE8", VA = "0x140BBE8")]
		public void Update()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x140BA3C", Offset = "0x140BA3C", VA = "0x140BA3C")]
		public float GetGhostScaleTimerNorm()
		{
			return default(float);
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x140B3F0", Offset = "0x140B3F0", VA = "0x140B3F0")]
		private void SetScale(float sc)
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x140ACD8", Offset = "0x140ACD8", VA = "0x140ACD8")]
		private void UpdateRadius()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x140BA50", Offset = "0x140BA50", VA = "0x140BA50")]
		private void UpdateGhostSize()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x140C3B8", Offset = "0x140C3B8", VA = "0x140C3B8")]
		public void Advance(float dist)
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x140C458", Offset = "0x140C458", VA = "0x140C458")]
		public void AdvanceAndPush(float speed, bool advanceAtRejoin = false)
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x140C980", Offset = "0x140C980", VA = "0x140C980")]
		public void AdvanceForBackwardMove(float speed)
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x140AD34", Offset = "0x140AD34", VA = "0x140AD34")]
		public void UpdatePos()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x140CB08", Offset = "0x140CB08", VA = "0x140CB08")]
		public void InstantiateSoundEffect(Transform holder, ObjectType type)
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x140CC44", Offset = "0x140CC44", VA = "0x140CC44")]
		public void PlayDestroySound(Transform holder)
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x140CC4C", Offset = "0x140CC4C", VA = "0x140CC4C")]
		public void Shoot(Vector3 moveVector, bool fastGun)
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x140CD3C", Offset = "0x140CD3C", VA = "0x140CD3C")]
		public void ResetGhostLink()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x140CD48", Offset = "0x140CD48", VA = "0x140CD48")]
		private void HitBallOnPath(BallManager hitBallManager, Ball hitBall)
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x140D2C4", Offset = "0x140D2C4", VA = "0x140D2C4")]
		public void FireBallCheckForClosestBalls()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x140D400", Offset = "0x140D400", VA = "0x140D400")]
		private void FireBallInteraction(BallManager hitBallManager, Ball hitBall)
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x140D5D8", Offset = "0x140D5D8", VA = "0x140D5D8")]
		private bool FireBallHasAlreadyRegisteredThiBall(Ball newBall)
		{
			return default(bool);
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x140D750", Offset = "0x140D750", VA = "0x140D750")]
		public void GivePoints()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x140DA64", Offset = "0x140DA64", VA = "0x140DA64")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x140DE04", Offset = "0x140DE04", VA = "0x140DE04")]
		public Ball()
		{
		}
	}
	[Token(Token = "0x2000165")]
	public class BallDestroyEffect : MonoBehaviour
	{
		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ParticleSystem particleSystem;

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x140B6C4", Offset = "0x140B6C4", VA = "0x140B6C4")]
		public void ResetEffect()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x140DE38", Offset = "0x140DE38", VA = "0x140DE38")]
		public BallDestroyEffect()
		{
		}
	}
	[Token(Token = "0x2000166")]
	public class BallGun : MonoBehaviour
	{
		[Token(Token = "0x2000167")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E334", Offset = "0x58E334")]
		private sealed class <ShootLoop>d__92 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000899")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400089A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400089B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BallGun <>4__this;

			[Token(Token = "0x400089C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x170000CA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600077D")]
				[Address(RVA = "0xF36980", Offset = "0xF36980", VA = "0xF36980", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600077F")]
				[Address(RVA = "0xF369C8", Offset = "0xF369C8", VA = "0xF369C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600077A")]
			[Address(RVA = "0xF367C4", Offset = "0xF367C4", VA = "0xF367C4")]
			[DebuggerHidden]
			public <ShootLoop>d__92(int <>1__state)
			{
			}

			[Token(Token = "0x600077B")]
			[Address(RVA = "0xF367F0", Offset = "0xF367F0", VA = "0xF367F0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600077C")]
			[Address(RVA = "0xF367F4", Offset = "0xF367F4", VA = "0xF367F4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600077E")]
			[Address(RVA = "0xF36988", Offset = "0xF36988", VA = "0xF36988", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000168")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E344", Offset = "0x58E344")]
		private sealed class <>c__DisplayClass115_0
		{
			[Token(Token = "0x400089D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float maxWidth;

			[Token(Token = "0x400089E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BallGun <>4__this;

			[Token(Token = "0x400089F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float finalWidth;

			[Token(Token = "0x6000780")]
			[Address(RVA = "0xB12D40", Offset = "0xB12D40", VA = "0xB12D40")]
			public <>c__DisplayClass115_0()
			{
			}

			[Token(Token = "0x6000781")]
			[Address(RVA = "0xB12D48", Offset = "0xB12D48", VA = "0xB12D48")]
			internal float <RunFastGunLineEffect>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000782")]
			[Address(RVA = "0xB12D50", Offset = "0xB12D50", VA = "0xB12D50")]
			internal void <RunFastGunLineEffect>b__1(float x)
			{
			}

			[Token(Token = "0x6000783")]
			[Address(RVA = "0xB12D78", Offset = "0xB12D78", VA = "0xB12D78")]
			internal void <RunFastGunLineEffect>b__2()
			{
			}
		}

		[Token(Token = "0x2000169")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E354", Offset = "0x58E354")]
		private sealed class <>c__DisplayClass116_0
		{
			[Token(Token = "0x40008A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float lastX;

			[Token(Token = "0x40008A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BallGun <>4__this;

			[Token(Token = "0x6000784")]
			[Address(RVA = "0xB12E44", Offset = "0xB12E44", VA = "0xB12E44")]
			public <>c__DisplayClass116_0()
			{
			}

			[Token(Token = "0x6000785")]
			[Address(RVA = "0xB12E4C", Offset = "0xB12E4C", VA = "0xB12E4C")]
			internal float <StartShootShurikenRotation>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000786")]
			[Address(RVA = "0xB12E54", Offset = "0xB12E54", VA = "0xB12E54")]
			internal void <StartShootShurikenRotation>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200016A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E364", Offset = "0x58E364")]
		private sealed class <>c__DisplayClass117_0
		{
			[Token(Token = "0x40008A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float lastX;

			[Token(Token = "0x40008A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BallGun <>4__this;

			[Token(Token = "0x6000787")]
			[Address(RVA = "0xF3622C", Offset = "0xF3622C", VA = "0xF3622C")]
			public <>c__DisplayClass117_0()
			{
			}

			[Token(Token = "0x6000788")]
			[Address(RVA = "0xF36234", Offset = "0xF36234", VA = "0xF36234")]
			internal float <StartReloadShurikenRotation>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000789")]
			[Address(RVA = "0xF3623C", Offset = "0xF3623C", VA = "0xF3623C")]
			internal void <StartReloadShurikenRotation>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200016B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E374", Offset = "0x58E374")]
		private sealed class <ShootBallCo>d__119 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BallGun <>4__this;

			[Token(Token = "0x170000CC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600078D")]
				[Address(RVA = "0xF36774", Offset = "0xF36774", VA = "0xF36774", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600078F")]
				[Address(RVA = "0xF367BC", Offset = "0xF367BC", VA = "0xF367BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600078A")]
			[Address(RVA = "0xF36410", Offset = "0xF36410", VA = "0xF36410")]
			[DebuggerHidden]
			public <ShootBallCo>d__119(int <>1__state)
			{
			}

			[Token(Token = "0x600078B")]
			[Address(RVA = "0xF3643C", Offset = "0xF3643C", VA = "0xF3643C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600078C")]
			[Address(RVA = "0xF36440", Offset = "0xF36440", VA = "0xF36440", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600078E")]
			[Address(RVA = "0xF3677C", Offset = "0xF3677C", VA = "0xF3677C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200016C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E384", Offset = "0x58E384")]
		private sealed class <ReloadDelayedCo>d__120 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BallGun <>4__this;

			[Token(Token = "0x170000CE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000793")]
				[Address(RVA = "0xF363C0", Offset = "0xF363C0", VA = "0xF363C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000795")]
				[Address(RVA = "0xF36408", Offset = "0xF36408", VA = "0xF36408", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000790")]
			[Address(RVA = "0xF362D0", Offset = "0xF362D0", VA = "0xF362D0")]
			[DebuggerHidden]
			public <ReloadDelayedCo>d__120(int <>1__state)
			{
			}

			[Token(Token = "0x6000791")]
			[Address(RVA = "0xF362FC", Offset = "0xF362FC", VA = "0xF362FC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0xF36300", Offset = "0xF36300", VA = "0xF36300", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000794")]
			[Address(RVA = "0xF363C8", Offset = "0xF363C8", VA = "0xF363C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator GunAnimator;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Animator CrossbowAnimator;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform[] MagazineBalls;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform LeftShuriken;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform RightShuriken;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Ball ball;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool IsRight;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool loaded;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float reloadTimeSec;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float timeToScaleUpAtShoot;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string reloadOpenGunTrigger;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string reloadCloseGunTrigger;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string reloadCloseRotateGunTrigger;

		[Token(Token = "0x400085D")]
		private const int RELOAD_STOPPED = 0;

		[Token(Token = "0x400085E")]
		private const int RELOAD_OPEN_GUN = 1;

		[Token(Token = "0x400085F")]
		private const int RELOAD_CLOSE_GUN = 2;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int reloadState;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float shurikenAngle;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float flashLifeTextTimer;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[HideInInspector]
		public bool DestroyBallBonusActive;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public int DestroyBallBonusCount;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 prevReloadPos;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x590828", Offset = "0x590828")]
		public TextMeshPro scoresText;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int gunScore;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int visualGunScore;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float animateVisualScoreTimer;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float SCORE_ANIM_TIME_SEC;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int animateScoreStart;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int animateScoreDiff;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x590860", Offset = "0x590860")]
		public GameObject[] lifeHearts;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x590898", Offset = "0x590898")]
		public GameObject extraMagazineBar1;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public GameObject extraMagazineBar2;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public GameObject extraMagazineMsg;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool extraMagazineEnabled;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int extraMagazineSize;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int normalMagazineSize;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5908D0", Offset = "0x5908D0")]
		public LineRenderer fastGunLine;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Transform fastGunShootDir;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool fastGun;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly float FAST_GUN_SPEED_MULT;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x590908", Offset = "0x590908")]
		public GameObject mainBallSupport;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public ParticleSystem shootDebrisPsys;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x590940", Offset = "0x590940")]
		public Transform reloadButton1Tr;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Transform reloadButton2Tr;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public Transform shootButtonTr;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x590978", Offset = "0x590978")]
		public GameObject reloadHighlight1;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public GameObject reloadHighlight2;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private bool showReloadHighlight;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public Transform reloadArrow1;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public Transform reloadArrow2;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public GameObject reloadPanel1Obj;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public GameObject reloadPanel2Obj;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public GameObject fireHelpObj;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 shootButtonDefaultPos;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Vector3 reload1ButtonDefaultPos;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Vector3 reload2ButtonDefaultPos;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		private float buttonsMoveDist;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private Vector3 reload1ArrowDefaultPos;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		private Vector3 reload2ArrowDefaultPos;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5909B0", Offset = "0x5909B0")]
		public AudioSource bowWireReloadSound;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public AudioSource shootBallGeneralSound;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public AudioSource shootFastBallSound;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public AudioSource shootFireBallSound;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public AudioSource reloadOpenGun;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public AudioSource reloadCloseGun;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public AudioSource reloadCRotateGun;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public AudioSource fireEmptyGun;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public AudioSource gunShootDebris;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		public AudioSource disableExtraGunSound;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private bool isLobby;

		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F1")]
		private bool isVrFocus;

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
		private float timeSinceShowReloadHighlight;

		[Token(Token = "0x4000898")]
		private const float SHOW_RELOAD_ARROW_DELAY_SEC = 3f;

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x140DE40", Offset = "0x140DE40", VA = "0x140DE40")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x140E42C", Offset = "0x140E42C", VA = "0x140E42C")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x140E918", Offset = "0x140E918", VA = "0x140E918")]
		private void OnVrInputFocus(bool on)
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x140EA24", Offset = "0x140EA24", VA = "0x140EA24")]
		private void OnBonusActivated(ObjectType itemType, bool enabled, BonusItem item)
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x140E404", Offset = "0x140E404", VA = "0x140E404")]
		private void SetScore(int val)
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x140ED68", Offset = "0x140ED68", VA = "0x140ED68")]
		private void UpdateScore()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x140EEE4", Offset = "0x140EEE4", VA = "0x140EEE4")]
		private void OnPlayerScorePerGunChanged(int newScore, bool isRightGun)
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x140EA90", Offset = "0x140EA90", VA = "0x140EA90")]
		private void EnableExtraMagazine(bool on)
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x140EA48", Offset = "0x140EA48", VA = "0x140EA48")]
		private void EnableFastGun(bool on)
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x140E358", Offset = "0x140E358", VA = "0x140E358")]
		private void InitVisualButtons()
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x140F054", Offset = "0x140F054", VA = "0x140F054")]
		public void OnLobbyEnteredEvent(bool on)
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x140E98C", Offset = "0x140E98C", VA = "0x140E98C")]
		private void DisableLobbyHelpers()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x140F22C", Offset = "0x140F22C", VA = "0x140F22C")]
		private void UpdateLobbyHelpers()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x140F420", Offset = "0x140F420", VA = "0x140F420")]
		public void OnLevelStartedEvent()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x140F464", Offset = "0x140F464", VA = "0x140F464")]
		private void UpdateLifeHearts(int livesNo)
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x140F4F0", Offset = "0x140F4F0", VA = "0x140F4F0")]
		private void OnStoryLevelCompleted()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x140F558", Offset = "0x140F558", VA = "0x140F558")]
		private void OnPlayerLostEvent()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x140F55C", Offset = "0x140F55C", VA = "0x140F55C")]
		private void OnGameOverEvent()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x140F4F4", Offset = "0x140F4F4", VA = "0x140F4F4")]
		private void ResetGunAtLevelEnd()
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x140F600", Offset = "0x140F600", VA = "0x140F600")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x592F30", Offset = "0x592F30")]
		private IEnumerator ShootLoop()
		{
			return null;
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x140F678", Offset = "0x140F678", VA = "0x140F678")]
		private ObjectType CheckDestroyBallsBonus(ObjectType nextBallType)
		{
			return default(ObjectType);
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x140F734", Offset = "0x140F734", VA = "0x140F734")]
		private void SpawnNewBallIntoHolder(Transform holder, bool checkIfLevelStarted)
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x140F9C4", Offset = "0x140F9C4", VA = "0x140F9C4")]
		public void FinishReloadAnimation()
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x140F9CC", Offset = "0x140F9CC", VA = "0x140F9CC")]
		private void FlashLivesIndicator()
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x140FAEC", Offset = "0x140FAEC", VA = "0x140FAEC")]
		public void Update()
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x140FDEC", Offset = "0x140FDEC", VA = "0x140FDEC")]
		private void UpdateReloadHighlight()
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x140FF68", Offset = "0x140FF68", VA = "0x140FF68")]
		public void ReleaseReloadButton()
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x1410074", Offset = "0x1410074", VA = "0x1410074")]
		public void ReloadCrossbow()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x14101B0", Offset = "0x14101B0", VA = "0x14101B0")]
		private int GetMagazineBallsCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x1410238", Offset = "0x1410238", VA = "0x1410238")]
		private bool LoadNextBall()
		{
			return default(bool);
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x140F560", Offset = "0x140F560", VA = "0x140F560")]
		private void StopShowingReloadHightlight()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x140EF20", Offset = "0x140EF20", VA = "0x140EF20")]
		public void ReloadMagazine(bool checkIfLevelStarted = true)
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x140F0B8", Offset = "0x140F0B8", VA = "0x140F0B8")]
		private void Unload()
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x14106E0", Offset = "0x14106E0", VA = "0x14106E0")]
		public void ButtonPressedA()
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x141073C", Offset = "0x141073C", VA = "0x141073C")]
		public void ButtonPressedB()
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x1410798", Offset = "0x1410798", VA = "0x1410798")]
		public void ButtonPressedTrigger()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x1410990", Offset = "0x1410990", VA = "0x1410990")]
		public void ButtonReleasedTrigger()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x14109A0", Offset = "0x14109A0", VA = "0x14109A0")]
		public void ButtonPressedGrip()
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x1410A1C", Offset = "0x1410A1C", VA = "0x1410A1C")]
		public void ButtonReleasedGrip()
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x1410998", Offset = "0x1410998", VA = "0x1410998")]
		public void ReleaseShoot()
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x1410AF4", Offset = "0x1410AF4", VA = "0x1410AF4")]
		private void TakeScreenshot()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x141079C", Offset = "0x141079C", VA = "0x141079C")]
		public void Shoot()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x1410AFC", Offset = "0x1410AFC", VA = "0x1410AFC")]
		private void RunFastGunLineEffect(Ball shootBall)
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x1410D80", Offset = "0x1410D80", VA = "0x1410D80")]
		private void StartShootShurikenRotation()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x140FC10", Offset = "0x140FC10", VA = "0x140FC10")]
		private void StartReloadShurikenRotation()
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x1411074", Offset = "0x1411074", VA = "0x1411074")]
		private void ShowDebrisEffect()
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x1410F84", Offset = "0x1410F84", VA = "0x1410F84")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x592F90", Offset = "0x592F90")]
		private IEnumerator ShootBallCo()
		{
			return null;
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x1410FFC", Offset = "0x1410FFC", VA = "0x1410FFC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x592FF0", Offset = "0x592FF0")]
		private IEnumerator ReloadDelayedCo()
		{
			return null;
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x140FF70", Offset = "0x140FF70", VA = "0x140FF70")]
		private void SetReloadVisualButtonState(bool on)
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x1410A24", Offset = "0x1410A24", VA = "0x1410A24")]
		private void SetShootVisualButtonState(bool on)
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x14110DC", Offset = "0x14110DC", VA = "0x14110DC")]
		public BallGun()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x1411208", Offset = "0x1411208", VA = "0x1411208")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593050", Offset = "0x593050")]
		private void <EnableExtraMagazine>b__80_0()
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x1411228", Offset = "0x1411228", VA = "0x1411228")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593060", Offset = "0x593060")]
		private void <LoadNextBall>b__102_0()
		{
		}
	}
	[Token(Token = "0x200016D")]
	public class BallGunAnimReload : MonoBehaviour
	{
		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BallGun Gun;

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x1411280", Offset = "0x1411280", VA = "0x1411280")]
		public void ReloadMagazine()
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x141129C", Offset = "0x141129C", VA = "0x141129C")]
		public void ReloadCompleted()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x14112B8", Offset = "0x14112B8", VA = "0x14112B8")]
		public BallGunAnimReload()
		{
		}
	}
	[Token(Token = "0x200016E")]
	public class BallManager : MonoBehaviour
	{
		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BallPath path;

		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public BallMover BallMover;

		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5909F8", Offset = "0x5909F8")]
		public int LevelBallsToSpawn;

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int StartupBallsCount;

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int AutoSpawnedBallsCount;

		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[HideInInspector]
		public float BallsSpeed;

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public float CurrBallsSpeed;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<Ball> balls;

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Ball> ballsToRemove;

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Ball insertBall_ClosestBall;

		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int insertBall_ClosestBallIndex;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int insertBall_InsertOffset;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool InitialBallsSpawned;

		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool levelStarted;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool playerLost;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int nextBallID;

		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<int> ballIndexToCheckForColours;

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x14112C0", Offset = "0x14112C0", VA = "0x14112C0")]
		public void Awake()
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x14114F0", Offset = "0x14114F0", VA = "0x14114F0")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x14116F0", Offset = "0x14116F0", VA = "0x14116F0")]
		public void Update()
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x1411E3C", Offset = "0x1411E3C", VA = "0x1411E3C")]
		private void OnGameOverEvent()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x1411E68", Offset = "0x1411E68", VA = "0x1411E68")]
		private void CleanupAllBalls()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x1412160", Offset = "0x1412160", VA = "0x1412160")]
		private void OnLevelStartedEvent()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x141217C", Offset = "0x141217C", VA = "0x141217C")]
		private void OnPlayerLostEvent()
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x1412188", Offset = "0x1412188", VA = "0x1412188")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x141209C", Offset = "0x141209C", VA = "0x141209C")]
		public void Reset()
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x1411720", Offset = "0x1411720", VA = "0x1411720")]
		private void CheckForBallsToRemove()
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x1411D3C", Offset = "0x1411D3C", VA = "0x1411D3C")]
		private void CheckForNewBallToSpawn()
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x14125E0", Offset = "0x14125E0", VA = "0x14125E0")]
		public void RemoveBall(Ball ball)
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x140D060", Offset = "0x140D060", VA = "0x140D060")]
		public Ball AddNewGhostBall(Vector3 bouncingBallPos, ObjectType ghostType)
		{
			return null;
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x1412198", Offset = "0x1412198", VA = "0x1412198")]
		private void RefreshAllBallPositions()
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x1412944", Offset = "0x1412944", VA = "0x1412944")]
		public void CheckCollisionsWithPathBalls(Ball checkBall, Action<BallManager, Ball> collisionCallback)
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x1412B54", Offset = "0x1412B54", VA = "0x1412B54")]
		public void CheckCollisionsWithAllPathBalls(Ball checkBall, Action<BallManager, Ball> collisionCallback, float addRadius)
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x140CF28", Offset = "0x140CF28", VA = "0x140CF28")]
		public void DestroyType(ObjectType typeToDestroy)
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x140BEB4", Offset = "0x140BEB4", VA = "0x140BEB4")]
		public void CheckPositionAgainstPathBalls(Ball otherBall, [Optional] Ball exceptBall)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x140C168", Offset = "0x140C168", VA = "0x140C168")]
		public void ReplaceGhostWithActualBall(Ball ghostBall, Ball newBall)
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x1412D7C", Offset = "0x1412D7C", VA = "0x1412D7C")]
		public void CheckForBallsWithSameColor(int index, bool checkAtRejoin = false)
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x1413210", Offset = "0x1413210", VA = "0x1413210")]
		private void MarkBallToDestroyForColorMatch(Ball ball)
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x1413240", Offset = "0x1413240", VA = "0x1413240")]
		public void TestDestroyFirstBall()
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x14130A4", Offset = "0x14130A4", VA = "0x14130A4")]
		private int GetNeighbourBallsWithType(int startIndex, ObjectType type, int dir)
		{
			return default(int);
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x14132DC", Offset = "0x14132DC", VA = "0x14132DC")]
		public Ball GetMostAdvancedBall()
		{
			return null;
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x141237C", Offset = "0x141237C", VA = "0x141237C")]
		public void AddNewAutoBall()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x140C538", Offset = "0x140C538", VA = "0x140C538")]
		public void BallHasMoved(Ball movedBall, int dir, bool movedAtRejoin = false)
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x1413350", Offset = "0x1413350", VA = "0x1413350")]
		public void StopPushingBallForIndex(int idx)
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x1412644", Offset = "0x1412644", VA = "0x1412644")]
		public void ComputeNewBallInsertPosition(Vector3 ballPos)
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x1413424", Offset = "0x1413424", VA = "0x1413424")]
		public void AddNewItem(BonusItem item)
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x14138E0", Offset = "0x14138E0", VA = "0x14138E0")]
		public BallManager()
		{
		}
	}
	[Token(Token = "0x200016F")]
	public enum BallMoveState
	{
		[Token(Token = "0x40008BD")]
		NORMAL_SPEED,
		[Token(Token = "0x40008BE")]
		SLOW_SPEED,
		[Token(Token = "0x40008BF")]
		ZERO_SPEED,
		[Token(Token = "0x40008C0")]
		BACKWARDS,
		[Token(Token = "0x40008C1")]
		FAST_SPEED,
		[Token(Token = "0x40008C2")]
		PLAYER_LOST
	}
	[Token(Token = "0x2000170")]
	public class BallMover : MonoBehaviour
	{
		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BallMoveState State;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource moveBallsSound;

		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioSource lifeLostSound;

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float startupSpeed;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float normalSpeed;

		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float slowSpeed;

		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fastSpeed;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float backwardSpeed;

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float playerLostSpeed;

		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BallManager ballManager;

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x14139E8", Offset = "0x14139E8", VA = "0x14139E8")]
		public void Awake()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x1413A44", Offset = "0x1413A44", VA = "0x1413A44")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x1413EBC", Offset = "0x1413EBC", VA = "0x1413EBC")]
		private void UpdateBallRollSound()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x1413AC4", Offset = "0x1413AC4", VA = "0x1413AC4")]
		private void UpdateBallManager(BallManager ballManager)
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x141414C", Offset = "0x141414C", VA = "0x141414C")]
		private void CheckForGameEnd(List<Ball> balls)
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x1413F8C", Offset = "0x1413F8C", VA = "0x1413F8C")]
		private void CheckForBallsThatNeedToRejoin(BallManager ballManager)
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x1414298", Offset = "0x1414298", VA = "0x1414298")]
		private void PushBallToRejoin(BallManager ballManager, Ball pushingBall, List<Ball> balls, int startGapBallIndex)
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x141443C", Offset = "0x141443C", VA = "0x141443C")]
		public void SetState(BallManager ballManager, BallMoveState newState)
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x14144D0", Offset = "0x14144D0", VA = "0x14144D0")]
		public BallMover()
		{
		}
	}
	[Token(Token = "0x2000171")]
	public class BallRotateMove : MonoBehaviour
	{
		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 pos;

		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 moveDir;

		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float lastMoveDist;

		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 rotateDir;

		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody _rigidbody;

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x141572C", Offset = "0x141572C", VA = "0x141572C")]
		public void Start()
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x14157BC", Offset = "0x14157BC", VA = "0x14157BC")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x141591C", Offset = "0x141591C", VA = "0x141591C")]
		private void UpdateRotation()
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x14159D0", Offset = "0x14159D0", VA = "0x14159D0")]
		public BallRotateMove()
		{
		}
	}
	[Token(Token = "0x2000172")]
	public class BallScoreText : MonoBehaviour
	{
		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshPro text;

		[Token(Token = "0x40008D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 speedDir;

		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float moveSpeed;

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x140D810", Offset = "0x140D810", VA = "0x140D810")]
		public void Setup(Ball ball)
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x14159D8", Offset = "0x14159D8", VA = "0x14159D8")]
		private void Update()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x1415A84", Offset = "0x1415A84", VA = "0x1415A84")]
		public BallScoreText()
		{
		}
	}
	[Token(Token = "0x2000173")]
	public class ShootBallsContainer : MonoBehaviour
	{
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x8523EC", Offset = "0x8523EC", VA = "0x8523EC")]
		public void Awake()
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x852514", Offset = "0x852514", VA = "0x852514")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x852614", Offset = "0x852614", VA = "0x852614")]
		private void OnGameOverEvent()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x852618", Offset = "0x852618", VA = "0x852618")]
		private void CleanupAllBalls()
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x852784", Offset = "0x852784", VA = "0x852784")]
		public ShootBallsContainer()
		{
		}
	}
	[Token(Token = "0x2000174")]
	internal class FireBallRay
	{
		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool enabled;

		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LineRenderer ray;

		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Ball ball;

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float destroyTimerSec;

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xB43680", Offset = "0xB43680", VA = "0xB43680")]
		public FireBallRay()
		{
		}
	}
	[Token(Token = "0x2000175")]
	public class FireBall : Ball
	{
		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x590A50", Offset = "0x590A50")]
		public float ActionRadius;

		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public int MaxDestroyBallsCount;

		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x590A88", Offset = "0x590A88")]
		public List<LineRenderer> RayLines;

		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private List<FireBallRay> rays;

		[Token(Token = "0x40008DD")]
		private const float RAY_DESTROY_TIME_SEC = 0.5f;

		[Token(Token = "0x40008DE")]
		private const float RAY_LINE_WIDTH = 1f;

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x871410", Offset = "0x871410", VA = "0x871410")]
		public new void Awake()
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x871554", Offset = "0x871554", VA = "0x871554")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x87168C", Offset = "0x87168C", VA = "0x87168C")]
		public new void Update()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x8719D0", Offset = "0x8719D0", VA = "0x8719D0")]
		public new void OnEnable()
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x871AF0", Offset = "0x871AF0", VA = "0x871AF0")]
		public new void OnDisable()
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x871C10", Offset = "0x871C10", VA = "0x871C10")]
		private void PreReset()
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x871ED8", Offset = "0x871ED8", VA = "0x871ED8")]
		private void PostReset()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x8716BC", Offset = "0x8716BC", VA = "0x8716BC")]
		private void CheckForNewRays()
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x87202C", Offset = "0x87202C", VA = "0x87202C")]
		private void DisableRay(int index)
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x872174", Offset = "0x872174", VA = "0x872174")]
		private void OnBallDestroyedEvent(Ball destroyedBall)
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x8717D4", Offset = "0x8717D4", VA = "0x8717D4")]
		private void UpdateExistingRays()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x871CB4", Offset = "0x871CB4", VA = "0x871CB4")]
		private void DestroyBallAndRay(FireBallRay ray, int index)
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x872284", Offset = "0x872284", VA = "0x872284")]
		private bool BallAlreadyRegistered(Ball newBall)
		{
			return default(bool);
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x87240C", Offset = "0x87240C", VA = "0x87240C")]
		private void HitBallOnPath(BallManager hitBallManager, Ball hitBall)
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x8724B0", Offset = "0x8724B0", VA = "0x8724B0")]
		private void AddReachedBall(Ball newBall)
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x872574", Offset = "0x872574", VA = "0x872574")]
		private LineRenderer ActivateNewRay(Ball newBall)
		{
			return null;
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x872700", Offset = "0x872700", VA = "0x872700")]
		public FireBall()
		{
		}
	}
	[Token(Token = "0x2000176")]
	public class BonusItem : MonoBehaviour
	{
		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ObjectType Type;

		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Ball ball;

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 objectOffset;

		[Token(Token = "0x40008E2")]
		private const float WOBBLE_HEIGHT = 0.2f;

		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 originalPos;

		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float wobbleAngle;

		[Token(Token = "0x40008E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int LifetimeSec;

		[Token(Token = "0x40008E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float ActionTime;

		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float lifeTimer;

		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool Enabled;

		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioSource enableSound;

		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AudioSource activateSound;

		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject bonusPsys;

		[Token(Token = "0x40008EC")]
		private const float FLYBONUS_DISABLE_ANIM_TIME = 0.5f;

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x1413588", Offset = "0x1413588", VA = "0x1413588")]
		public void LinkBall(Ball targetBall)
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x1416FC0", Offset = "0x1416FC0", VA = "0x1416FC0")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x1417320", Offset = "0x1417320", VA = "0x1417320")]
		private void UpdateRotation()
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x14171B4", Offset = "0x14171B4", VA = "0x14171B4")]
		private void UpdatePos()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x14175AC", Offset = "0x14175AC", VA = "0x14175AC")]
		public void Reset()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x14136CC", Offset = "0x14136CC", VA = "0x14136CC")]
		public void Enable()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x14170C8", Offset = "0x14170C8", VA = "0x14170C8")]
		private void PlayDisableAnimation()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x14120AC", Offset = "0x14120AC", VA = "0x14120AC")]
		public void Disable()
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x140DD40", Offset = "0x140DD40", VA = "0x140DD40")]
		public void Activate()
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x14175C0", Offset = "0x14175C0", VA = "0x14175C0")]
		public BonusItem()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x14175E8", Offset = "0x14175E8", VA = "0x14175E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593160", Offset = "0x593160")]
		private void <Enable>b__19_0()
		{
		}
	}
	[Token(Token = "0x2000177")]
	public class BonusSystem : MonoBehaviour
	{
		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float nextBonusPopupTimer;

		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float nextFlyBonusPopupTimer;

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x590AC0", Offset = "0x590AC0")]
		public AudioSource bonusSpeedSound;

		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioSource bonusClockSound;

		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioSource bonusBackwardSound;

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioSource bonusSlowSound;

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioSource flyBonusFastGunSound;

		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioSource flyBonusPointsSound;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public ParticleSystem bonusStopPsysEffect;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float playClockSoundTimer;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<ObjectType> activeBonusesType;

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<float> activeBonusesActiveTime;

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<int> itemsToRemove;

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x141767C", Offset = "0x141767C", VA = "0x141767C")]
		public void Awake()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x14176E8", Offset = "0x14176E8", VA = "0x14176E8")]
		public void Start()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x1417A08", Offset = "0x1417A08", VA = "0x1417A08")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x1417D28", Offset = "0x1417D28", VA = "0x1417D28")]
		public void OnLevelStartedEvent()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x1417D90", Offset = "0x1417D90", VA = "0x1417D90")]
		private void OnGameOverEvent()
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x1417DBC", Offset = "0x1417DBC", VA = "0x1417DBC")]
		public void OnPlayerLostEvent()
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x1417DE8", Offset = "0x1417DE8", VA = "0x1417DE8")]
		private void OnStoryLevelCompletedEvent()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x1417E14", Offset = "0x1417E14", VA = "0x1417E14")]
		private void DestroyAllCreatedButNotActiveBonuses()
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x1417D4C", Offset = "0x1417D4C", VA = "0x1417D4C")]
		private void EnableBonuses(bool on)
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x1418114", Offset = "0x1418114", VA = "0x1418114")]
		public void Update()
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x1417EC0", Offset = "0x1417EC0", VA = "0x1417EC0")]
		private void SetNextBonusTimer()
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x1417F3C", Offset = "0x1417F3C", VA = "0x1417F3C")]
		private void SetNextFlyBonusTimer()
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x1418288", Offset = "0x1418288", VA = "0x1418288")]
		private void SpawnNewFlyBonus()
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x14185A4", Offset = "0x14185A4", VA = "0x14185A4")]
		private Vector3 GetRandomPointInsideCollider(BoxCollider boxCollider)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x1418678", Offset = "0x1418678", VA = "0x1418678")]
		private void SpawnNewBonus()
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x1417FB8", Offset = "0x1417FB8", VA = "0x1417FB8")]
		private void DisableAllActiveBonuses()
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x14181B0", Offset = "0x14181B0", VA = "0x14181B0")]
		private void UpdateBonuses()
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x141878C", Offset = "0x141878C", VA = "0x141878C")]
		private void UpdateActiveBonuses()
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x1418AF4", Offset = "0x1418AF4", VA = "0x1418AF4")]
		private void DisableActiveItem(ObjectType itemType)
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x1417478", Offset = "0x1417478", VA = "0x1417478")]
		public bool IsActiveBonus(ObjectType bonusType)
		{
			return default(bool);
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x1418DC0", Offset = "0x1418DC0", VA = "0x1418DC0")]
		private void CheckIfPreviousItemsNeedToBeDisabled(ObjectType newItemType)
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x1418E2C", Offset = "0x1418E2C", VA = "0x1418E2C")]
		public void BonusWasActivated(BonusItem item)
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x1418F3C", Offset = "0x1418F3C", VA = "0x1418F3C")]
		private void OnBonusActivatedEvent(ObjectType itemType, bool enabled, BonusItem item)
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x1419084", Offset = "0x1419084", VA = "0x1419084")]
		public BonusSystem()
		{
		}
	}
	[Token(Token = "0x2000178")]
	public enum GameStage
	{
		[Token(Token = "0x40008FB")]
		LOBBY,
		[Token(Token = "0x40008FC")]
		GAME,
		[Token(Token = "0x40008FD")]
		GAME_PAUSED
	}
	[Token(Token = "0x2000179")]
	public enum GameDifficulty
	{
		[Token(Token = "0x40008FF")]
		CASUAL,
		[Token(Token = "0x4000900")]
		MASTER
	}
	[Token(Token = "0x200017A")]
	public class GlobalGame
	{
		[Serializable]
		[Token(Token = "0x200017B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E394", Offset = "0x58E394")]
		private sealed class <>c
		{
			[Token(Token = "0x4000936")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000937")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action <>9__74_0;

			[Token(Token = "0x600081E")]
			[Address(RVA = "0xF38D40", Offset = "0xF38D40", VA = "0xF38D40")]
			public <>c()
			{
			}

			[Token(Token = "0x600081F")]
			[Address(RVA = "0xF38D48", Offset = "0xF38D48", VA = "0xF38D48")]
			internal void <GoToLobby>b__74_0()
			{
			}
		}

		[Token(Token = "0x4000901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Transform PlayerHeadset;

		[Token(Token = "0x4000902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static PlayerPlayArea PlayerPlayArea;

		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static GameStage GameStage;

		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly string OCULUS_RIFT_APPID;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly string OCULUS_QUEST_APPID;

		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static User oculusLocalUser;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static bool liveScoresEnabled;

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string SURVIVAL_LEVEL_NAME;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static int PlayerLifes;

		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static float ballDiameter;

		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static int playerScore;

		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public static int playerScoreRight;

		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static int playerScoreLeft;

		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public static int ballScoreMultiplier;

		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static int ballSetsDestroyedInARow;

		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public static readonly int BALL_SCORE;

		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static float _distToAngleFactor;

		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public static GameDifficulty GameDifficulty;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static float GameDifficultyFactor;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public static int CurrentStoryLevelIndex;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static bool InGamePaused;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public static Vector3 DefaultBallScale;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static Transform ShootBallsContainer;

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static Level GameLevel;

		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static BonusSystem BonusSystem;

		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public static MusicSystem MusicSystem;

		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public static ProgressManager ProgressSystem;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public static PoolSystem PoolSystem;

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public static Lobby Lobby;

		[Token(Token = "0x400091E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public static UIManager UIManager;

		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public static SceneManager SceneManager;

		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public static FadeView FadeView;

		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public static Action<bool> OnVrInputFocus;

		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public static Action<bool> OnLobbyEntered;

		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public static Action OnLevelLoadedEvent;

		[Token(Token = "0x4000924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public static Action OnLevelStartedEvent;

		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public static Action OnPlayerLostEvent;

		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public static Action OnStoryLevelCompleted;

		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public static Action OnPlayerLostBallClearedEvent;

		[Token(Token = "0x4000928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public static Action OnGameOverEvent;

		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public static Action<ObjectType, bool, BonusItem> OnBonusActivatedEvent;

		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public static Action<Ball> OnBallDestroyedEvent;

		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public static Action<float> OnMostAdvancedBallUpdateEvent;

		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public static Action<int> OnPlayerScoreAdded;

		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public static Action<int> OnPlayerScoreChanged;

		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public static Action<int, bool> OnPlayerScorePerGunChanged;

		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public static Action<int> OnPointsMultiplierIncreased;

		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public static Action OnDifficultyChanged;

		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public static Action<bool> OnPauseGameButtonEvent;

		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public static bool IsLobby;

		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x159")]
		public static bool IsLobbySelectLevel;

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15A")]
		public static bool IsInSceneTransition;

		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		public static float LevelStartTime;

		[Token(Token = "0x170000D0")]
		public static float DistToAngleFactor
		{
			[Token(Token = "0x6000801")]
			[Address(RVA = "0xB464A0", Offset = "0xB464A0", VA = "0xB464A0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xB46568", Offset = "0xB46568", VA = "0xB46568")]
		public static void BallsHaveReachedEndOfPath()
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xB46654", Offset = "0xB46654", VA = "0xB46654")]
		public static void SetDifficultyToCasual()
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0xB466E0", Offset = "0xB466E0", VA = "0xB466E0")]
		public static void SetDifficultyToMaster()
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0xB46774", Offset = "0xB46774", VA = "0xB46774")]
		public static void StartLobby(bool on)
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0xB46810", Offset = "0xB46810", VA = "0xB46810")]
		public static void StartCurrentLevel()
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xB4689C", Offset = "0xB4689C", VA = "0xB4689C")]
		public static void LevelLoadCompleted()
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xB46914", Offset = "0xB46914", VA = "0xB46914")]
		public static void PlayerLostAndBallsHaveBeenCleared()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xB46A38", Offset = "0xB46A38", VA = "0xB46A38")]
		public static void BallsWithSameColourWereDestroyed(Vector3 midPosition)
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xB465E4", Offset = "0xB465E4", VA = "0xB465E4")]
		public static void ResetGlobalPointsMultiplier()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xB46D54", Offset = "0xB46D54", VA = "0xB46D54")]
		public static void GameOver()
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xB46DD0", Offset = "0xB46DD0", VA = "0xB46DD0")]
		public static bool BallsAreTight(Ball ball1, Ball ball2)
		{
			return default(bool);
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xB46E18", Offset = "0xB46E18", VA = "0xB46E18")]
		public static void NewBonusSpawned(BonusItem item)
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0xB46F40", Offset = "0xB46F40", VA = "0xB46F40")]
		public static void ActivateBonus(BonusItem item)
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xB46FB8", Offset = "0xB46FB8", VA = "0xB46FB8")]
		public static void BallWasDestroyed(Ball ball)
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0xB4704C", Offset = "0xB4704C", VA = "0xB4704C")]
		public static void InGameMenu_TogglePause()
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xB472C8", Offset = "0xB472C8", VA = "0xB472C8")]
		public static void InGameMenu_PressResume()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xB47360", Offset = "0xB47360", VA = "0xB47360")]
		public static void InGameMenu_PressLobby()
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xB47404", Offset = "0xB47404", VA = "0xB47404")]
		public static void GoToLobby()
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0xB475F0", Offset = "0xB475F0", VA = "0xB475F0")]
		public static void StoryLevelCompleted()
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xB47668", Offset = "0xB47668", VA = "0xB47668")]
		public static void GoToLobbyAfterScorePanel()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xB476C4", Offset = "0xB476C4", VA = "0xB476C4")]
		public static void ProcessEndOfStoryLevelAfterScorePanel(bool playerLost)
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0xB47578", Offset = "0xB47578", VA = "0xB47578")]
		public static void FadeInBeforeSceneChange(Action onComplete)
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0xB478CC", Offset = "0xB478CC", VA = "0xB478CC")]
		public static void GiveBonusPoints(int points, bool fromRightGun)
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0xB47B00", Offset = "0xB47B00", VA = "0xB47B00")]
		public static void GivePointsAtBallDestroy(bool fromRightGun)
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xB4696C", Offset = "0xB4696C", VA = "0xB4696C")]
		private static void ResetScore()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xB471B8", Offset = "0xB471B8", VA = "0xB471B8")]
		public static bool IsCompleteLevelPanelOpened()
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x200017C")]
	public class HighscoresContainer
	{
		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<LevelHighscores> levels;

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xB4EEEC", Offset = "0xB4EEEC", VA = "0xB4EEEC")]
		public HighscoresContainer()
		{
		}
	}
	[Token(Token = "0x200017D")]
	public class HighscoresSystem : MonoBehaviour
	{
		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static HighscoresSystem Instance;

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private HighscoresContainer scores;

		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string scoresStorageKey;

		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string lastUsernameStorageKey;

		[Token(Token = "0x400093D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int lastInsertedIndex;

		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string lastUsername;

		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly string DEFAULT_USERNAME;

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xB4EF70", Offset = "0xB4EF70", VA = "0xB4EF70")]
		private void Start()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xB4F1D4", Offset = "0xB4F1D4", VA = "0xB4F1D4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xB4F350", Offset = "0xB4F350", VA = "0xB4F350")]
		public void SaveScores()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xB4F11C", Offset = "0xB4F11C", VA = "0xB4F11C")]
		private void LoadScores()
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xB4F388", Offset = "0xB4F388", VA = "0xB4F388")]
		public void SetLastUserName(string name)
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xB4F3BC", Offset = "0xB4F3BC", VA = "0xB4F3BC")]
		private void OnPlayerLost()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xB4F4AC", Offset = "0xB4F4AC", VA = "0xB4F4AC")]
		private void OnLevelCompleted()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xB4F3C0", Offset = "0xB4F3C0", VA = "0xB4F3C0")]
		private void CheckScoreForLevel()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xB4F858", Offset = "0xB4F858", VA = "0xB4F858")]
		private LevelHighscores AddLevel(string levelName)
		{
			return null;
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xB4F614", Offset = "0xB4F614", VA = "0xB4F614")]
		public LevelHighscores GetLevel(string levelName)
		{
			return null;
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xB4F4B0", Offset = "0xB4F4B0", VA = "0xB4F4B0")]
		private void SubmitScoreOnline(int score, string levelName)
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xB4FC7C", Offset = "0xB4FC7C", VA = "0xB4FC7C")]
		public HighscoresSystem()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200017E")]
	public class ScoreEntry
	{
		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string username;

		[Token(Token = "0x4000941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int score;

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x851A64", Offset = "0x851A64", VA = "0x851A64")]
		public ScoreEntry()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200017F")]
	public class LevelHighscores
	{
		[Token(Token = "0x4000942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int SCORES_ENTRIES_NUM;

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string levelName;

		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<ScoreEntry> scores;

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xB5569C", Offset = "0xB5569C", VA = "0xB5569C")]
		public bool IsEligible(int newScore)
		{
			return default(bool);
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xB4F9E0", Offset = "0xB4F9E0", VA = "0xB4F9E0")]
		public int AddScore(int newScore, string playerName)
		{
			return default(int);
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xB55760", Offset = "0xB55760", VA = "0xB55760")]
		private void InsertScoreAtIndex(int index, int newScore, string playerName)
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xB4FADC", Offset = "0xB4FADC", VA = "0xB4FADC")]
		public void InitDefaultScores()
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0xB4FAD4", Offset = "0xB4FAD4", VA = "0xB4FAD4")]
		public LevelHighscores()
		{
		}
	}
	[Token(Token = "0x2000180")]
	public class Level : MonoBehaviour
	{
		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x4000946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject LevelRootObj;

		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x590AF8", Offset = "0x590AF8")]
		public List<ObjectType> PathBallTypes;

		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<ObjectType> GunBallTypes;

		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<ObjectType> SpecialGunBallTypes;

		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x590B30", Offset = "0x590B30")]
		public int SpecialBallsProbability;

		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x590B68", Offset = "0x590B68")]
		public int DestroyBallsCount;

		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x590BA0", Offset = "0x590BA0")]
		public float SpeedMultiplier;

		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x590BD8", Offset = "0x590BD8")]
		public List<ObjectType> BonusTypes;

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int SpawnTimeRangeMin;

		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int SpawnTimeRangeMax;

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x590C10", Offset = "0x590C10")]
		public List<ObjectType> FlyBonusTypes;

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public BoxCollider[] flyBonusZones;

		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int flyBonusSpawnTimeRangeMin;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public int flyBonusSpawnTimeRangeMax;

		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x590C48", Offset = "0x590C48")]
		public List<BallManager> BallManagers;

		[Token(Token = "0x4000955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x590C80", Offset = "0x590C80")]
		public LevelPathTrail[] PathTrails;

		[Token(Token = "0x4000956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x590CB8", Offset = "0x590CB8")]
		public AudioSource MainLoop;

		[Token(Token = "0x4000957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public AudioSource TensionLoop;

		[Token(Token = "0x4000958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AudioSource AmbientLoop;

		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x590CF0", Offset = "0x590CF0")]
		public GameObject CompleteLevelEffect;

		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		public float levelPlayTime;

		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool levelCompleted;

		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool levelStarted;

		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAE")]
		private bool playerLost;

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float ignoreLevelCompleteCheckTimer;

		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float triggerStoryLevelCompletedTimer;

		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ObjectType prevBonusType;

		[Token(Token = "0x4000961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private ObjectType prevFlyBonusType;

		[Token(Token = "0x4000962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float fireBallTime;

		[Token(Token = "0x6000834")]
		[Address(RVA = "0xB53278", Offset = "0xB53278", VA = "0xB53278", Slot = "4")]
		protected virtual void UpdateLevel()
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0xB5327C", Offset = "0xB5327C", VA = "0xB5327C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xB53304", Offset = "0xB53304", VA = "0xB53304")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xB5368C", Offset = "0xB5368C", VA = "0xB5368C")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xB539A4", Offset = "0xB539A4", VA = "0xB539A4")]
		public void Update()
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xB53E90", Offset = "0xB53E90", VA = "0xB53E90")]
		public void TestDestroyFirstBallOnPaths()
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xB53C40", Offset = "0xB53C40", VA = "0xB53C40")]
		public void CheckIfLevelCompleted()
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xB472B8", Offset = "0xB472B8", VA = "0xB472B8")]
		public bool IsDuringLevelCompletedEffect()
		{
			return default(bool);
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xB53FA8", Offset = "0xB53FA8", VA = "0xB53FA8")]
		public bool IsLevelStarted()
		{
			return default(bool);
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xB53FB0", Offset = "0xB53FB0", VA = "0xB53FB0")]
		public bool IsTrailHightlightMoving()
		{
			return default(bool);
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0xB539D8", Offset = "0xB539D8", VA = "0xB539D8")]
		private void CheckMostAdvancedBalls()
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0xB54000", Offset = "0xB54000", VA = "0xB54000")]
		public void PlayThemeMusic(bool on)
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0xB540C8", Offset = "0xB540C8", VA = "0xB540C8")]
		public void EnableLevel(bool on)
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0xB53624", Offset = "0xB53624", VA = "0xB53624")]
		public void StartPathTrails()
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0xB541AC", Offset = "0xB541AC", VA = "0xB541AC")]
		public void PathTrailCompleted()
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0xB54204", Offset = "0xB54204", VA = "0xB54204", Slot = "5")]
		public virtual void OnLevelStartedEvent()
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xB54358", Offset = "0xB54358", VA = "0xB54358")]
		public void OnPlayerLostEvent()
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0xB54368", Offset = "0xB54368", VA = "0xB54368")]
		public void OnPlayerLostBallClearedEvent()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xB544DC", Offset = "0xB544DC", VA = "0xB544DC")]
		public void OnGameOverEvent()
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xB46E98", Offset = "0xB46E98", VA = "0xB46E98")]
		public BallManager GetRandomBallManager()
		{
			return null;
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0xB544E4", Offset = "0xB544E4", VA = "0xB544E4")]
		public void CheckCollisionsWithPathBalls(Ball ball, Action<BallManager, Ball> onHit)
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xB54614", Offset = "0xB54614", VA = "0xB54614")]
		public void CheckCollisionsWithAllPathBalls(Ball ball, Action<BallManager, Ball> onHit, float addRadius)
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xB54220", Offset = "0xB54220", VA = "0xB54220")]
		private void SetBallManagersState(BallMoveState state)
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xB54754", Offset = "0xB54754", VA = "0xB54754")]
		private bool HasFewBallsLeftOnPaths()
		{
			return default(bool);
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0xB54894", Offset = "0xB54894", VA = "0xB54894")]
		private ObjectType GetBallTypeFromPath()
		{
			return default(ObjectType);
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xB54A6C", Offset = "0xB54A6C", VA = "0xB54A6C")]
		public ObjectType GetNextBallTypeForGun()
		{
			return default(ObjectType);
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xB54BF4", Offset = "0xB54BF4", VA = "0xB54BF4")]
		public ObjectType GetNextBallTypeForPath()
		{
			return default(ObjectType);
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xB54C7C", Offset = "0xB54C7C", VA = "0xB54C7C")]
		public ObjectType GetNextFlyBonusType()
		{
			return default(ObjectType);
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0xB54D40", Offset = "0xB54D40", VA = "0xB54D40")]
		public BoxCollider GetZoneForFlyBonus()
		{
			return null;
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0xB54DAC", Offset = "0xB54DAC", VA = "0xB54DAC")]
		public ObjectType GetNextBonusType()
		{
			return default(ObjectType);
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xB54E70", Offset = "0xB54E70", VA = "0xB54E70")]
		public float GetNextBonusSpawnTime()
		{
			return default(float);
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xB54E94", Offset = "0xB54E94", VA = "0xB54E94")]
		public float GetNextFlyBonusSpawnTime()
		{
			return default(float);
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xB54EB8", Offset = "0xB54EB8", VA = "0xB54EB8")]
		public void OnBonusActivatedEvent(ObjectType itemType, bool enabled, BonusItem item)
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xB54F14", Offset = "0xB54F14", VA = "0xB54F14")]
		public Level()
		{
		}
	}
	[Token(Token = "0x2000181")]
	public class LevelSelector : MonoBehaviour
	{
		[Token(Token = "0x4000963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] LevelButtons;

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xB55BD0", Offset = "0xB55BD0", VA = "0xB55BD0")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xB55D98", Offset = "0xB55D98", VA = "0xB55D98")]
		public LevelSelector()
		{
		}
	}
	[Token(Token = "0x2000182")]
	public class Lobby : MonoBehaviour
	{
		[Token(Token = "0x2000183")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E3A4", Offset = "0x58E3A4")]
		private sealed class <Start>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400096E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400096F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000970")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Lobby <>4__this;

			[Token(Token = "0x170000D1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000878")]
				[Address(RVA = "0xF3AB78", Offset = "0xF3AB78", VA = "0xF3AB78", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600087A")]
				[Address(RVA = "0xF3ABC0", Offset = "0xF3ABC0", VA = "0xF3ABC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000875")]
			[Address(RVA = "0xF3AA4C", Offset = "0xF3AA4C", VA = "0xF3AA4C")]
			[DebuggerHidden]
			public <Start>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000876")]
			[Address(RVA = "0xF3AA78", Offset = "0xF3AA78", VA = "0xF3AA78", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000877")]
			[Address(RVA = "0xF3AA7C", Offset = "0xF3AA7C", VA = "0xF3AA7C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000879")]
			[Address(RVA = "0xF3AB80", Offset = "0xF3AB80", VA = "0xF3AB80", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000184")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E3B4", Offset = "0x58E3B4")]
		private sealed class <>c
		{
			[Token(Token = "0x4000971")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000972")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Message<User>.Callback <>9__12_0;

			[Token(Token = "0x600087C")]
			[Address(RVA = "0xF3A748", Offset = "0xF3A748", VA = "0xF3A748")]
			public <>c()
			{
			}

			[Token(Token = "0x600087D")]
			[Address(RVA = "0xF3A750", Offset = "0xF3A750", VA = "0xF3A750")]
			internal void <EntitlementCallback>b__12_0(Message<User> message)
			{
			}
		}

		[Token(Token = "0x2000185")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E3C4", Offset = "0x58E3C4")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x4000973")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string currLevelName;

			[Token(Token = "0x4000974")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Lobby <>4__this;

			[Token(Token = "0x4000975")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<string> <>9__1;

			[Token(Token = "0x600087E")]
			[Address(RVA = "0xF3A7D4", Offset = "0xF3A7D4", VA = "0xF3A7D4")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x600087F")]
			[Address(RVA = "0xF3A7DC", Offset = "0xF3A7DC", VA = "0xF3A7DC")]
			internal void <ReenterCurrentLevel>b__0()
			{
			}

			[Token(Token = "0x6000880")]
			[Address(RVA = "0xF3A8E4", Offset = "0xF3A8E4", VA = "0xF3A8E4")]
			internal void <ReenterCurrentLevel>b__1(string sceneName)
			{
			}
		}

		[Token(Token = "0x2000186")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E3D4", Offset = "0x58E3D4")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x4000976")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Lobby <>4__this;

			[Token(Token = "0x4000977")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool on;

			[Token(Token = "0x6000881")]
			[Address(RVA = "0xF3A9C8", Offset = "0xF3A9C8", VA = "0xF3A9C8")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x6000882")]
			[Address(RVA = "0xF3A9D0", Offset = "0xF3A9D0", VA = "0xF3A9D0")]
			internal void <EnableLobby>b__0(string sceneName)
			{
			}
		}

		[Token(Token = "0x4000964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject LobbyRootObj;

		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject SelectorRootObj;

		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string survivalSceneName;

		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<string> storyLevelScenes;

		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Level currentLevel;

		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 selectLevelDisabledPos;

		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioSource LobbyTheme;

		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioSource SelectLevelTheme;

		[Token(Token = "0x400096C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public GameObject policyPanelObj;

		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string CREDITS_SHOWN_AT_START_KEY;

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xB560D8", Offset = "0xB560D8", VA = "0xB560D8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x593170", Offset = "0x593170")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0xB56150", Offset = "0xB56150", VA = "0xB56150")]
		private void PerformOculusEntitlementCheck()
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xB562B8", Offset = "0xB562B8", VA = "0xB562B8")]
		private void EntitlementCallback(Message msg)
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0xB477CC", Offset = "0xB477CC", VA = "0xB477CC")]
		public int GetMaxLevelIndex()
		{
			return default(int);
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0xB56410", Offset = "0xB56410", VA = "0xB56410")]
		private void InitGame()
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0xB5664C", Offset = "0xB5664C", VA = "0xB5664C")]
		public void PlayLobbyTheme(bool on)
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xB566AC", Offset = "0xB566AC", VA = "0xB566AC")]
		public void PlaySelectLevelTheme(bool on)
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xB5670C", Offset = "0xB5670C", VA = "0xB5670C")]
		public void ReenterCurrentLevel()
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xB56498", Offset = "0xB56498", VA = "0xB56498")]
		public void EnableLobby(bool on)
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xB56820", Offset = "0xB56820", VA = "0xB56820")]
		private void ActivateLobby(bool on)
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0xB5692C", Offset = "0xB5692C", VA = "0xB5692C")]
		private void ShowPolicyFirstTimeOnly()
		{
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0xB56980", Offset = "0xB56980", VA = "0xB56980")]
		public void AcceptGamePolicy()
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0xB56990", Offset = "0xB56990", VA = "0xB56990")]
		public void StartNewSurvivalGame()
		{
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0xB56A6C", Offset = "0xB56A6C", VA = "0xB56A6C")]
		public void StartNewStoryGame(int levelIndex)
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xB56B5C", Offset = "0xB56B5C", VA = "0xB56B5C")]
		private void SwitchStatesFromSelectorBackToLobby()
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0xB56C38", Offset = "0xB56C38", VA = "0xB56C38")]
		private void SwitchStatesFromLobbyToSelectLevel()
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0xB56D58", Offset = "0xB56D58", VA = "0xB56D58")]
		public void GoBackFromSelectorRoom()
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0xB56DFC", Offset = "0xB56DFC", VA = "0xB56DFC")]
		public void EnterSelectorRoom()
		{
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0xB47818", Offset = "0xB47818", VA = "0xB47818")]
		public void GoFromGameToLevelSelector()
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0xB56EA0", Offset = "0xB56EA0", VA = "0xB56EA0")]
		private string GetCurrentLevelSceneName()
		{
			return null;
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0xB56F40", Offset = "0xB56F40", VA = "0xB56F40")]
		private void LevelLoadComplete(string sceneName)
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xB570F0", Offset = "0xB570F0", VA = "0xB570F0")]
		private void SetCurrentLevelAndStartGame(Level level)
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xB57198", Offset = "0xB57198", VA = "0xB57198")]
		public Lobby()
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0xB57200", Offset = "0xB57200", VA = "0xB57200")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5931D0", Offset = "0x5931D0")]
		private void <StartNewSurvivalGame>b__23_0()
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xB57310", Offset = "0xB57310", VA = "0xB57310")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5931E0", Offset = "0x5931E0")]
		private void <StartNewStoryGame>b__24_0()
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0xB57414", Offset = "0xB57414", VA = "0xB57414")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5931F0", Offset = "0x5931F0")]
		private void <GoBackFromSelectorRoom>b__27_0()
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0xB57490", Offset = "0xB57490", VA = "0xB57490")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593200", Offset = "0x593200")]
		private void <EnterSelectorRoom>b__28_0()
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0xB5750C", Offset = "0xB5750C", VA = "0xB5750C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593210", Offset = "0x593210")]
		private void <GoFromGameToLevelSelector>b__29_0()
		{
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0xB575F8", Offset = "0xB575F8", VA = "0xB575F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593220", Offset = "0x593220")]
		private void <GoFromGameToLevelSelector>b__29_1(string sceneName)
		{
		}
	}
	[Token(Token = "0x2000187")]
	public class MusicSystem : MonoBehaviour
	{
		[Token(Token = "0x4000978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioMixer MainAudioMixer;

		[Token(Token = "0x4000979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource playerLostEnterNameTheme;

		[Token(Token = "0x6000883")]
		[Address(RVA = "0xD83FC8", Offset = "0xD83FC8", VA = "0xD83FC8")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0xD843A8", Offset = "0xD843A8", VA = "0xD843A8")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0xD84774", Offset = "0xD84774", VA = "0xD84774")]
		private void OnVrInputFocus(bool on)
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0xD847EC", Offset = "0xD847EC", VA = "0xD847EC")]
		public void PlayGameOverEnterNameTheme()
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0xD84808", Offset = "0xD84808", VA = "0xD84808")]
		private void OnLobbyEntered(bool on)
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0xD84854", Offset = "0xD84854", VA = "0xD84854")]
		private void OnLevelLoaded()
		{
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0xD84990", Offset = "0xD84990", VA = "0xD84990")]
		private void OnPlayerLost()
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0xD84A04", Offset = "0xD84A04", VA = "0xD84A04")]
		private void OnGameOver()
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0xD84A78", Offset = "0xD84A78", VA = "0xD84A78")]
		private void OnMostAdvancedBallUpdate(float ballNormPos)
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0xD848DC", Offset = "0xD848DC", VA = "0xD848DC")]
		private void SetGameAudioMixersVolume(float mainNormVolume, float tensionNormVolume)
		{
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0xD84B00", Offset = "0xD84B00", VA = "0xD84B00")]
		public MusicSystem()
		{
		}
	}
	[Token(Token = "0x2000188")]
	public class LevelBallsGateOpener : MonoBehaviour
	{
		[Token(Token = "0x400097A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x590D38", Offset = "0x590D38")]
		public int ballsNeededToOpen;

		[Token(Token = "0x400097B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int destroyedBallsCount;

		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool doorOpened;

		[Token(Token = "0x400097D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x590D70", Offset = "0x590D70")]
		public float minFillValue;

		[Token(Token = "0x400097E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float maxFillValue;

		[Token(Token = "0x400097F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Renderer fillObjectRenderer;

		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x590DA8", Offset = "0x590DA8")]
		public Transform leftDoorTr;

		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 leftClosedPos;

		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 leftOpenedPos;

		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x590DE0", Offset = "0x590DE0")]
		public Transform rightDoorTr;

		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightClosedPos;

		[Token(Token = "0x4000985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 rightOpenedPos;

		[Token(Token = "0x4000986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x590E18", Offset = "0x590E18")]
		public AudioSource openGateSound;

		[Token(Token = "0x4000987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AudioSource victorySound;

		[Token(Token = "0x600088E")]
		[Address(RVA = "0xB550A8", Offset = "0xB550A8", VA = "0xB550A8")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0xB5521C", Offset = "0xB5521C", VA = "0xB5521C")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0xB551C4", Offset = "0xB551C4", VA = "0xB551C4")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0xB55518", Offset = "0xB55518", VA = "0xB55518")]
		private void OnBallDestroyedEvent(Ball ball)
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0xB55330", Offset = "0xB55330", VA = "0xB55330")]
		private void UpdateFillLevel()
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0xB553B4", Offset = "0xB553B4", VA = "0xB553B4")]
		private void OpenDoor(Transform doorTr, Vector3 openPos, Vector3 closePos, bool on)
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0xB5568C", Offset = "0xB5568C", VA = "0xB5568C")]
		public LevelBallsGateOpener()
		{
		}
	}
	[Token(Token = "0x2000189")]
	public class LevelPathTrail : MonoBehaviour
	{
		[Token(Token = "0x200018A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E3E4", Offset = "0x58E3E4")]
		private sealed class <HideObjectCo>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400098F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000990")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000991")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LevelPathTrail <>4__this;

			[Token(Token = "0x170000D3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008A1")]
				[Address(RVA = "0xF3A4D4", Offset = "0xF3A4D4", VA = "0xF3A4D4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008A3")]
				[Address(RVA = "0xF3A51C", Offset = "0xF3A51C", VA = "0xF3A51C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600089E")]
			[Address(RVA = "0xF3A3CC", Offset = "0xF3A3CC", VA = "0xF3A3CC")]
			[DebuggerHidden]
			public <HideObjectCo>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x600089F")]
			[Address(RVA = "0xF3A3F8", Offset = "0xF3A3F8", VA = "0xF3A3F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008A0")]
			[Address(RVA = "0xF3A3FC", Offset = "0xF3A3FC", VA = "0xF3A3FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008A2")]
			[Address(RVA = "0xF3A4DC", Offset = "0xF3A4DC", VA = "0xF3A4DC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BallPath path;

		[Token(Token = "0x4000989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level GameLevel;

		[Token(Token = "0x400098A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform MoveObject;

		[Token(Token = "0x400098B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float Speed;

		[Token(Token = "0x400098C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float currPathPos;

		[Token(Token = "0x400098D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool moving;

		[Token(Token = "0x400098E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool notifyTrailComplete;

		[Token(Token = "0x6000895")]
		[Address(RVA = "0xB558A0", Offset = "0xB558A0", VA = "0xB558A0")]
		public void Start()
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0xB558E0", Offset = "0xB558E0", VA = "0xB558E0")]
		public bool IsMoving()
		{
			return default(bool);
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0xB5416C", Offset = "0xB5416C", VA = "0xB5416C")]
		public void StartMove()
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0xB558E8", Offset = "0xB558E8", VA = "0xB558E8")]
		public void Update()
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0xB559E4", Offset = "0xB559E4", VA = "0xB559E4")]
		private void CheckForEnd()
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0xB55B24", Offset = "0xB55B24", VA = "0xB55B24")]
		private void NotifyTheCompleteTrail()
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0xB55AAC", Offset = "0xB55AAC", VA = "0xB55AAC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x593280", Offset = "0x593280")]
		private IEnumerator HideObjectCo()
		{
			return null;
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0xB5593C", Offset = "0xB5593C", VA = "0xB5593C")]
		private void UpdateMoveObjectPos()
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0xB55BB8", Offset = "0xB55BB8", VA = "0xB55BB8")]
		public LevelPathTrail()
		{
		}
	}
	[Token(Token = "0x200018B")]
	public class SurvivalLevelDeathMove : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200018C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E3F4", Offset = "0x58E3F4")]
		private sealed class <>c
		{
			[Token(Token = "0x4000994")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000995")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static TweenCallback <>9__6_0;

			[Token(Token = "0x60008AA")]
			[Address(RVA = "0xF3ED04", Offset = "0xF3ED04", VA = "0xF3ED04")]
			public <>c()
			{
			}

			[Token(Token = "0x60008AB")]
			[Address(RVA = "0xF3ED0C", Offset = "0xF3ED0C", VA = "0xF3ED0C")]
			internal void <MakeDeathTrapMove>b__6_0()
			{
			}
		}

		[Token(Token = "0x200018D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E404", Offset = "0x58E404")]
		private sealed class <MakeDeathTrapMove>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000996")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000997")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000998")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SurvivalLevelDeathMove <>4__this;

			[Token(Token = "0x4000999")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x170000D5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008AF")]
				[Address(RVA = "0xF3F0C0", Offset = "0xF3F0C0", VA = "0xF3F0C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008B1")]
				[Address(RVA = "0xF3F108", Offset = "0xF3F108", VA = "0xF3F108", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008AC")]
			[Address(RVA = "0xF3ED68", Offset = "0xF3ED68", VA = "0xF3ED68")]
			[DebuggerHidden]
			public <MakeDeathTrapMove>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60008AD")]
			[Address(RVA = "0xF3ED94", Offset = "0xF3ED94", VA = "0xF3ED94", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008AE")]
			[Address(RVA = "0xF3ED98", Offset = "0xF3ED98", VA = "0xF3ED98", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008B0")]
			[Address(RVA = "0xF3F0C8", Offset = "0xF3F0C8", VA = "0xF3F0C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000992")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform floorBars;

		[Token(Token = "0x4000993")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource barsMoveSound;

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0xB0619C", Offset = "0xB0619C", VA = "0xB0619C")]
		public void Start()
		{
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0xB06314", Offset = "0xB06314", VA = "0xB06314")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0xB06524", Offset = "0xB06524", VA = "0xB06524")]
		private void OnPlayerLost()
		{
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0xB06550", Offset = "0xB06550", VA = "0xB06550")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x593330", Offset = "0x593330")]
		private IEnumerator MakeDeathTrapMove()
		{
			return null;
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0xB065C8", Offset = "0xB065C8", VA = "0xB065C8")]
		public SurvivalLevelDeathMove()
		{
		}
	}
	[Token(Token = "0x200018E")]
	[ExecuteInEditMode]
	public class BallPath : MonoBehaviour
	{
		[Token(Token = "0x400099A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float pathInsideFishDist;

		[Token(Token = "0x400099B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BezierCurve4[] segments;

		[Token(Token = "0x400099C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float length;

		[Token(Token = "0x400099D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float segmentLength;

		[Token(Token = "0x400099E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool drawEditorBalls;

		[Token(Token = "0x400099F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool ADD_NEW_POINT;

		[Token(Token = "0x40009A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool EQUALIZE_SEGMENTS;

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x14144F0", Offset = "0x14144F0", VA = "0x14144F0")]
		public void Awake()
		{
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x14144F4", Offset = "0x14144F4", VA = "0x14144F4")]
		public void UpdateLength()
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x1414834", Offset = "0x1414834", VA = "0x1414834")]
		public void Update()
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x14151BC", Offset = "0x14151BC", VA = "0x14151BC")]
		public void SegmentHasChanged(BezierCurve4 seg)
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x140CA2C", Offset = "0x140CA2C", VA = "0x140CA2C")]
		public Vector3 GetPosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x1414888", Offset = "0x1414888", VA = "0x1414888")]
		private void AddNewPointInEditor()
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x1414EB8", Offset = "0x1414EB8", VA = "0x1414EB8")]
		public void EqualizeSegments()
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x14154FC", Offset = "0x14154FC", VA = "0x14154FC")]
		public void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x14155C0", Offset = "0x14155C0", VA = "0x14155C0")]
		public BallPath()
		{
		}
	}
	[Token(Token = "0x200018F")]
	public class BallPathNodeHandler : MonoBehaviour
	{
		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x14155D8", Offset = "0x14155D8", VA = "0x14155D8")]
		public void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x1415724", Offset = "0x1415724", VA = "0x1415724")]
		public BallPathNodeHandler()
		{
		}
	}
	[Token(Token = "0x2000190")]
	[ExecuteInEditMode]
	public class BezierCurve4 : MonoBehaviour
	{
		[Token(Token = "0x40009A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform p0;

		[Token(Token = "0x40009A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform p0cp;

		[Token(Token = "0x40009A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform p1cp;

		[Token(Token = "0x40009A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform p1;

		[Token(Token = "0x40009A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BallPath path;

		[Token(Token = "0x40009A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool drawTangents;

		[Token(Token = "0x40009A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool drawCurve;

		[Token(Token = "0x40009A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int segmentsCount;

		[Token(Token = "0x40009A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float Length;

		[Token(Token = "0x40009AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float segmentMultiplierCP;

		[Token(Token = "0x40009AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float segmentMultiplierP1;

		[Token(Token = "0x40009AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool RECOMPUTE_CURVE;

		[Token(Token = "0x40009AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		public bool TOGGLE_EDITOR_BALLS;

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x1415A8C", Offset = "0x1415A8C", VA = "0x1415A8C")]
		public void Update()
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x1414580", Offset = "0x1414580", VA = "0x1414580")]
		public float ComputeLength()
		{
			return default(float);
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x1415310", Offset = "0x1415310", VA = "0x1415310")]
		public void UpdateControlPoints(Transform leftCP, Transform rightCP)
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x14154CC", Offset = "0x14154CC", VA = "0x14154CC")]
		public Vector3 GetPointFromAbsDist(float absDist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x1415C4C", Offset = "0x1415C4C", VA = "0x1415C4C")]
		public Vector3 GetPointFromNormDist(float fTime)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x1415D6C", Offset = "0x1415D6C", VA = "0x1415D6C")]
		public void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x141607C", Offset = "0x141607C", VA = "0x141607C")]
		private void DrawThickLine(Vector3 p1, Vector3 p2, int steps = 3)
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x14161FC", Offset = "0x14161FC", VA = "0x14161FC")]
		public BezierCurve4()
		{
		}
	}
	[Token(Token = "0x2000191")]
	public enum ObjectType
	{
		[Token(Token = "0x40009AF")]
		NONE,
		[Token(Token = "0x40009B0")]
		BALL_BLUE,
		[Token(Token = "0x40009B1")]
		BALL_YELLOW,
		[Token(Token = "0x40009B2")]
		BALL_RED,
		[Token(Token = "0x40009B3")]
		BALL_GREEN,
		[Token(Token = "0x40009B4")]
		BALL_BLACK,
		[Token(Token = "0x40009B5")]
		BALL_SPECIAL_FIRE,
		[Token(Token = "0x40009B6")]
		BALL_SPECIAL_JOKER,
		[Token(Token = "0x40009B7")]
		BALL_SPECIAL_DESTROYCOLOR,
		[Token(Token = "0x40009B8")]
		BALL_SPECIAL_DESTROYBALL,
		[Token(Token = "0x40009B9")]
		BALL_EMPTY1,
		[Token(Token = "0x40009BA")]
		BALL_EMPTY2,
		[Token(Token = "0x40009BB")]
		BALL_EMPTY3,
		[Token(Token = "0x40009BC")]
		BALL_EMPTY4,
		[Token(Token = "0x40009BD")]
		BALL_EMPTY5,
		[Token(Token = "0x40009BE")]
		BONUS_SLOW,
		[Token(Token = "0x40009BF")]
		BONUS_STOP,
		[Token(Token = "0x40009C0")]
		BONUS_BACKWARDS,
		[Token(Token = "0x40009C1")]
		BONUS_SPEED,
		[Token(Token = "0x40009C2")]
		BONUS_FASTGUN,
		[Token(Token = "0x40009C3")]
		BONUS_1000P,
		[Token(Token = "0x40009C4")]
		BONUS_2000P,
		[Token(Token = "0x40009C5")]
		BONUS_EXTRA_MAGAZINE,
		[Token(Token = "0x40009C6")]
		BONUS_EMPTY5,
		[Token(Token = "0x40009C7")]
		EFFECT_BALL_BLUE_DESTROY,
		[Token(Token = "0x40009C8")]
		EFFECT_BALL_YELLOW_DESTROY,
		[Token(Token = "0x40009C9")]
		EFFECT_BALL_RED_DESTROY,
		[Token(Token = "0x40009CA")]
		EFFECT_BALL_GREEN_DESTROY,
		[Token(Token = "0x40009CB")]
		EFFECT_BALL_BLACK_DESTROY,
		[Token(Token = "0x40009CC")]
		EFFECT_BALL_FIRE_DESTROY,
		[Token(Token = "0x40009CD")]
		EFFECT_BALL_BLUEJOKER_DESTROY,
		[Token(Token = "0x40009CE")]
		EFFECT_BALL_YELLOWJOKER_DESTROY,
		[Token(Token = "0x40009CF")]
		EFFECT_BALL_REDJOKER_DESTROY,
		[Token(Token = "0x40009D0")]
		EFFECT_BALL_GREENJOKER_DESTROY,
		[Token(Token = "0x40009D1")]
		EFFECT_BALL_BLACKJOKER_DESTROY,
		[Token(Token = "0x40009D2")]
		SOUND_BALL_ROCK_BREAKING,
		[Token(Token = "0x40009D3")]
		SOUND_BALL_BOMB_EXPLOSION,
		[Token(Token = "0x40009D4")]
		SOUND_BALL_JOKER_COLOR,
		[Token(Token = "0x40009D5")]
		SOUND_BALL_COLLISION,
		[Token(Token = "0x40009D6")]
		SOUND_BALL_ROCK_BREAKING_SMALL,
		[Token(Token = "0x40009D7")]
		SOUND_BALL_DESTROY_1,
		[Token(Token = "0x40009D8")]
		SOUND_BALL_DESTROY_2,
		[Token(Token = "0x40009D9")]
		SOUND_BALL_DESTROY_3,
		[Token(Token = "0x40009DA")]
		SOUND_BALL_DESTROY_4,
		[Token(Token = "0x40009DB")]
		SOUND_BALL_DESTROY_5,
		[Token(Token = "0x40009DC")]
		SOUND_BALL_DESTROY_6,
		[Token(Token = "0x40009DD")]
		EFFECT_BALL_BONUSSTOP_TIME,
		[Token(Token = "0x40009DE")]
		EFFECT_BALL_BLUE_VANISH,
		[Token(Token = "0x40009DF")]
		EFFECT_BALL_YELLOW_VANISH,
		[Token(Token = "0x40009E0")]
		EFFECT_BALL_RED_VANISH,
		[Token(Token = "0x40009E1")]
		EFFECT_BALL_GREEN_VANISH,
		[Token(Token = "0x40009E2")]
		EFFECT_BALL_BLACK_VANISH,
		[Token(Token = "0x40009E3")]
		EFFECT_BALL_FIRE_VANISH,
		[Token(Token = "0x40009E4")]
		EFFECT_BALL_JOKER_VANISH,
		[Token(Token = "0x40009E5")]
		EFFECT_BALL_DESTROYBALL_VANISH,
		[Token(Token = "0x40009E6")]
		BALL_SCORE_TEXT,
		[Token(Token = "0x40009E7")]
		GLOBAL_MULTIPLIER_EFFECT
	}
	[Token(Token = "0x2000192")]
	public class PoolObject : MonoBehaviour
	{
		[Token(Token = "0x40009E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ObjectType Type;

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x84AFE0", Offset = "0x84AFE0", VA = "0x84AFE0")]
		public PoolObject()
		{
		}
	}
	[Token(Token = "0x2000193")]
	public class PoolSystem : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000194")]
		public class PoolPrefab
		{
			[Token(Token = "0x40009ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ObjectType type;

			[Token(Token = "0x40009EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject prefab;

			[Token(Token = "0x40009EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int count;

			[Token(Token = "0x60008CE")]
			[Address(RVA = "0xF3E64C", Offset = "0xF3E64C", VA = "0xF3E64C")]
			public PoolPrefab()
			{
			}
		}

		[Token(Token = "0x40009E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int DefaultAllocSize;

		[Token(Token = "0x40009EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<PoolPrefab> objects;

		[Token(Token = "0x40009EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<PoolObject> pooledObjects;

		[Token(Token = "0x40009EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int instancesCount;

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x84AFE8", Offset = "0x84AFE8", VA = "0x84AFE8")]
		public void Awake()
		{
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x84B064", Offset = "0x84B064", VA = "0x84B064")]
		public void Init()
		{
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x84B088", Offset = "0x84B088", VA = "0x84B088")]
		private void PreAlloc()
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x84B2A0", Offset = "0x84B2A0", VA = "0x84B2A0")]
		public void CollectExistingObjects()
		{
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x84B3DC", Offset = "0x84B3DC", VA = "0x84B3DC")]
		public PoolObject GetObject(ObjectType type)
		{
			return null;
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x84B78C", Offset = "0x84B78C", VA = "0x84B78C")]
		public void ReturnObject(GameObject obj)
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x84B640", Offset = "0x84B640", VA = "0x84B640")]
		private GameObject GetPrefab(ObjectType type)
		{
			return null;
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x84B8D8", Offset = "0x84B8D8", VA = "0x84B8D8")]
		public PoolSystem()
		{
		}
	}
	[Token(Token = "0x2000195")]
	public class SurvivalLevel : Level
	{
		[Token(Token = "0x40009F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool started;

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0xB060AC", Offset = "0xB060AC", VA = "0xB060AC", Slot = "4")]
		protected override void UpdateLevel()
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0xB06168", Offset = "0xB06168", VA = "0xB06168", Slot = "5")]
		public override void OnLevelStartedEvent()
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0xB06194", Offset = "0xB06194", VA = "0xB06194")]
		public SurvivalLevel()
		{
		}
	}
	[Token(Token = "0x2000196")]
	public class InGamePauseLobbyButton : MonoBehaviour
	{
		[Token(Token = "0x2000197")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E434", Offset = "0x58E434")]
		private sealed class <PressAction>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x170000D7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008D9")]
				[Address(RVA = "0xF39C7C", Offset = "0xF39C7C", VA = "0xF39C7C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008DB")]
				[Address(RVA = "0xF39CC4", Offset = "0xF39CC4", VA = "0xF39CC4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008D6")]
			[Address(RVA = "0xF39B80", Offset = "0xF39B80", VA = "0xF39B80")]
			[DebuggerHidden]
			public <PressAction>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60008D7")]
			[Address(RVA = "0xF39BAC", Offset = "0xF39BAC", VA = "0xF39BAC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008D8")]
			[Address(RVA = "0xF39BB0", Offset = "0xF39BB0", VA = "0xF39BB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008DA")]
			[Address(RVA = "0xF39C84", Offset = "0xF39C84", VA = "0xF39C84", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40009F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform buttonTr;

		[Token(Token = "0x40009F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool hoverOn;

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0xB4FD5C", Offset = "0xB4FD5C", VA = "0xB4FD5C")]
		public void HoverChanged(bool on)
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0xB4FDE0", Offset = "0xB4FDE0", VA = "0xB4FDE0")]
		public void Press()
		{
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0xB4FE0C", Offset = "0xB4FE0C", VA = "0xB4FE0C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5933E0", Offset = "0x5933E0")]
		private IEnumerator PressAction()
		{
			return null;
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0xB4FE68", Offset = "0xB4FE68", VA = "0xB4FE68")]
		public InGamePauseLobbyButton()
		{
		}
	}
	[Token(Token = "0x2000198")]
	public class InGamePauseMenu : MonoBehaviour
	{
		[Token(Token = "0x40009F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject RootObj;

		[Token(Token = "0x40009F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isLobby;

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0xB4FE70", Offset = "0xB4FE70", VA = "0xB4FE70")]
		public void Awake()
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0xB5011C", Offset = "0xB5011C", VA = "0xB5011C")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0xB503C8", Offset = "0xB503C8", VA = "0xB503C8")]
		private void OnVrInputFocus(bool on)
		{
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0xB50480", Offset = "0xB50480", VA = "0xB50480")]
		public void OnApplicationPause(bool on)
		{
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0xB503D4", Offset = "0xB503D4", VA = "0xB503D4")]
		private void CheckIfGameNeedsToBePaused()
		{
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0xB5048C", Offset = "0xB5048C", VA = "0xB5048C")]
		private void OnLobbyEntered(bool on)
		{
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0xB50498", Offset = "0xB50498", VA = "0xB50498")]
		private void OnLevelStarted()
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0xB5049C", Offset = "0xB5049C", VA = "0xB5049C")]
		private void OnPauseEvent(bool on)
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0xB505FC", Offset = "0xB505FC", VA = "0xB505FC")]
		public InGamePauseMenu()
		{
		}
	}
	[Token(Token = "0x2000199")]
	public class InGamePauseResumeButton : MonoBehaviour
	{
		[Token(Token = "0x200019A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E444", Offset = "0x58E444")]
		private sealed class <PressAction>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x170000D9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008EC")]
				[Address(RVA = "0xF39DC8", Offset = "0xF39DC8", VA = "0xF39DC8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008EE")]
				[Address(RVA = "0xF39E10", Offset = "0xF39E10", VA = "0xF39E10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008E9")]
			[Address(RVA = "0xF39CCC", Offset = "0xF39CCC", VA = "0xF39CCC")]
			[DebuggerHidden]
			public <PressAction>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60008EA")]
			[Address(RVA = "0xF39CF8", Offset = "0xF39CF8", VA = "0xF39CF8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008EB")]
			[Address(RVA = "0xF39CFC", Offset = "0xF39CFC", VA = "0xF39CFC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008ED")]
			[Address(RVA = "0xF39DD0", Offset = "0xF39DD0", VA = "0xF39DD0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40009F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform buttonTr;

		[Token(Token = "0x40009F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool hoverOn;

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0xB50604", Offset = "0xB50604", VA = "0xB50604")]
		public void HoverChanged(bool on)
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0xB50688", Offset = "0xB50688", VA = "0xB50688")]
		public void Press()
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0xB506B4", Offset = "0xB506B4", VA = "0xB506B4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x593490", Offset = "0x593490")]
		private IEnumerator PressAction()
		{
			return null;
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0xB50710", Offset = "0xB50710", VA = "0xB50710")]
		public InGamePauseResumeButton()
		{
		}
	}
	[Token(Token = "0x200019B")]
	public class CompleteLevelPanel : MonoBehaviour
	{
		[Token(Token = "0x200019C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E454", Offset = "0x58E454")]
		private sealed class <SetPanelScoresCo>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CompleteLevelPanel <>4__this;

			[Token(Token = "0x170000DB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000903")]
				[Address(RVA = "0xF37284", Offset = "0xF37284", VA = "0xF37284", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000905")]
				[Address(RVA = "0xF372CC", Offset = "0xF372CC", VA = "0xF372CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000900")]
			[Address(RVA = "0xF3702C", Offset = "0xF3702C", VA = "0xF3702C")]
			[DebuggerHidden]
			public <SetPanelScoresCo>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000901")]
			[Address(RVA = "0xF37058", Offset = "0xF37058", VA = "0xF37058", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000902")]
			[Address(RVA = "0xF3705C", Offset = "0xF3705C", VA = "0xF3705C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000904")]
			[Address(RVA = "0xF3728C", Offset = "0xF3728C", VA = "0xF3728C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40009FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static CompleteLevelPanel Instance;

		[Token(Token = "0x40009FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject RootObj;

		[Token(Token = "0x40009FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI leftGunScore;

		[Token(Token = "0x40009FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI rightGunScore;

		[Token(Token = "0x40009FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI totalScore;

		[Token(Token = "0x4000A00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public HighScoreLine[] highscores;

		[Token(Token = "0x4000A01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public EnterNamePanel enterNamePanel;

		[Token(Token = "0x4000A02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject highscoresPanel;

		[Token(Token = "0x4000A03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject continueButton;

		[Token(Token = "0x4000A04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject menuButton;

		[Token(Token = "0x4000A05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public GameObject changeNameButton;

		[Token(Token = "0x4000A06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject casualLabel;

		[Token(Token = "0x4000A07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject masterLabel;

		[Token(Token = "0x4000A08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public GameObject survivalLabel;

		[Token(Token = "0x4000A09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public GameObject levelCompleteTitle;

		[Token(Token = "0x4000A0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public GameObject levelFailedTitle;

		[Token(Token = "0x4000A0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public GameObject survivalTitle;

		[Token(Token = "0x4000A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool playerLost;

		[Token(Token = "0x4000A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float ignoreUIActionsTimer;

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x86196C", Offset = "0x86196C", VA = "0x86196C")]
		private void Start()
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x861B10", Offset = "0x861B10", VA = "0x861B10")]
		private void Update()
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x861B5C", Offset = "0x861B5C", VA = "0x861B5C")]
		public bool IsOpened()
		{
			return default(bool);
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x861B78", Offset = "0x861B78", VA = "0x861B78")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x861CF4", Offset = "0x861CF4", VA = "0x861CF4")]
		private void OnLevelCompleted()
		{
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x861D9C", Offset = "0x861D9C", VA = "0x861D9C")]
		private void Show(bool on)
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x8623E8", Offset = "0x8623E8", VA = "0x8623E8")]
		private void OnPlayerLost()
		{
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x861D24", Offset = "0x861D24", VA = "0x861D24")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x593540", Offset = "0x593540")]
		private IEnumerator SetPanelScoresCo()
		{
			return null;
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x86241C", Offset = "0x86241C", VA = "0x86241C")]
		private void SetDifficultyLabel()
		{
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x861FE8", Offset = "0x861FE8", VA = "0x861FE8")]
		private void SetPanelScores()
		{
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x86255C", Offset = "0x86255C", VA = "0x86255C")]
		private void SaveEnteredName()
		{
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x862880", Offset = "0x862880", VA = "0x862880")]
		public void OnMenuButtonPressed()
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x86294C", Offset = "0x86294C", VA = "0x86294C")]
		public void OnContinueButtonPressed()
		{
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x862A4C", Offset = "0x862A4C", VA = "0x862A4C")]
		public void OnChangeNameButtonPressed()
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x862C68", Offset = "0x862C68", VA = "0x862C68")]
		public void SetEnteredName(string newName)
		{
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x86235C", Offset = "0x86235C", VA = "0x86235C")]
		public void ShowEnterNamePanel(bool on)
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x862E10", Offset = "0x862E10", VA = "0x862E10")]
		public CompleteLevelPanel()
		{
		}
	}
	[Token(Token = "0x200019D")]
	public class EnterNameLetterSelector : MonoBehaviour
	{
		[Token(Token = "0x4000A11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI letterText;

		[Token(Token = "0x4000A12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string lettersDic;

		[Token(Token = "0x4000A13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private char[] lettersDicChars;

		[Token(Token = "0x4000A14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int index;

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x86AFEC", Offset = "0x86AFEC", VA = "0x86AFEC")]
		public void SetLetter(string str)
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x86B170", Offset = "0x86B170", VA = "0x86B170")]
		public void OnUpButtonPressed()
		{
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x86B1A4", Offset = "0x86B1A4", VA = "0x86B1A4")]
		public void OnDownButtonPressed()
		{
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x86B024", Offset = "0x86B024", VA = "0x86B024")]
		private void UpdateText()
		{
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x86B1DC", Offset = "0x86B1DC", VA = "0x86B1DC")]
		public EnterNameLetterSelector()
		{
		}
	}
	[Token(Token = "0x200019E")]
	public class EnterNamePanel : MonoBehaviour
	{
		[Token(Token = "0x4000A15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] prevButtons;

		[Token(Token = "0x4000A16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI[] prevButtonLabels;

		[Token(Token = "0x4000A17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EnterNameLetterSelector[] letterSelectors;

		[Token(Token = "0x4000A18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public CompleteLevelPanel completeLevelPanel;

		[Token(Token = "0x4000A19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string lastNamesKey;

		[Token(Token = "0x4000A1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string enteredName;

		[Token(Token = "0x4000A1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool previousNamesSetup;

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x86B238", Offset = "0x86B238", VA = "0x86B238")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x86B23C", Offset = "0x86B23C", VA = "0x86B23C")]
		private void SetupPreviousNames()
		{
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x862B20", Offset = "0x862B20", VA = "0x862B20")]
		public void SetName(string name)
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x862624", Offset = "0x862624", VA = "0x862624")]
		public void RecordEnteredName(string newName)
		{
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x86B418", Offset = "0x86B418", VA = "0x86B418")]
		public void OnChangeNamePressed()
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x86B524", Offset = "0x86B524", VA = "0x86B524")]
		public void OnUsePreviousNameButtonPressed(int index)
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x86B59C", Offset = "0x86B59C", VA = "0x86B59C")]
		public EnterNamePanel()
		{
		}
	}
	[Token(Token = "0x200019F")]
	public class HighScoreLine : MonoBehaviour
	{
		[Token(Token = "0x4000A1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI username;

		[Token(Token = "0x4000A1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI score;

		[Token(Token = "0x4000A1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Image lineBack;

		[Token(Token = "0x4000A1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool flashBG;

		[Token(Token = "0x6000912")]
		[Address(RVA = "0xB4EDF0", Offset = "0xB4EDF0", VA = "0xB4EDF0")]
		public void IsPlayer(bool on)
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0xB4EE18", Offset = "0xB4EE18", VA = "0xB4EE18")]
		private void Update()
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0xB4EEE4", Offset = "0xB4EEE4", VA = "0xB4EEE4")]
		public HighScoreLine()
		{
		}
	}
	[Token(Token = "0x20001A0")]
	public class LobbyCreditsPanel : MonoBehaviour
	{
		[Token(Token = "0x6000915")]
		[Address(RVA = "0xB5768C", Offset = "0xB5768C", VA = "0xB5768C")]
		public void ClosePanel()
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0xB576B4", Offset = "0xB576B4", VA = "0xB576B4")]
		public void ClosePolicyPanel()
		{
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0xB57738", Offset = "0xB57738", VA = "0xB57738")]
		private void ShowPanel()
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0xB5780C", Offset = "0xB5780C", VA = "0xB5780C")]
		public void TogglePanelVisibility()
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0xB57858", Offset = "0xB57858", VA = "0xB57858")]
		public LobbyCreditsPanel()
		{
		}
	}
	[Token(Token = "0x20001A1")]
	public class LobbyDifficultyButton : MonoBehaviour
	{
		[Token(Token = "0x4000A20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isCasual;

		[Token(Token = "0x4000A21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LobbyDifficultyButton otherButton;

		[Token(Token = "0x4000A22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject labelSelectOn;

		[Token(Token = "0x4000A23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject labelSelectOff;

		[Token(Token = "0x4000A24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject selectPsys;

		[Token(Token = "0x4000A25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ParticleSystem globalRoomPsys;

		[Token(Token = "0x4000A26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioSource globalPsysSound;

		[Token(Token = "0x600091A")]
		[Address(RVA = "0xB57860", Offset = "0xB57860", VA = "0xB57860")]
		public void Press()
		{
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0xB5798C", Offset = "0xB5798C", VA = "0xB5798C")]
		public void Deselect()
		{
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0xB578FC", Offset = "0xB578FC", VA = "0xB578FC")]
		private void ShowSelectionEffects(bool on)
		{
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0xB57994", Offset = "0xB57994", VA = "0xB57994")]
		public LobbyDifficultyButton()
		{
		}
	}
	[Token(Token = "0x20001A2")]
	public class LobbyLevButtonLiveScoresButton : MonoBehaviour
	{
		[Token(Token = "0x4000A27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject scoresPanelObj;

		[Token(Token = "0x4000A28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LobbyLevelButton levelButton;

		[Token(Token = "0x4000A29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject casualLabel;

		[Token(Token = "0x4000A2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject masterLabel;

		[Token(Token = "0x4000A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject connectionIconObj;

		[Token(Token = "0x4000A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool hoverOn;

		[Token(Token = "0x4000A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public TextMeshPro[] ranks;

		[Token(Token = "0x4000A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TextMeshPro[] usernames;

		[Token(Token = "0x4000A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public TextMeshPro[] scores;

		[Token(Token = "0x4000A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool requestInProgress;

		[Token(Token = "0x4000A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float lastRequestTime;

		[Token(Token = "0x4000A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameDifficulty lastDifficulty;

		[Token(Token = "0x4000A33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private readonly float MIN_TIME_BETWEEN_REQUESTS_SEC;

		[Token(Token = "0x4000A34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string leaderboardTableID;

		[Token(Token = "0x4000A35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool localUserFound;

		[Token(Token = "0x4000A36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int BOARD_SCORES_COUNT;

		[Token(Token = "0x600091E")]
		[Address(RVA = "0xB579A4", Offset = "0xB579A4", VA = "0xB579A4")]
		public void HoverChanged(bool on)
		{
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0xB579C8", Offset = "0xB579C8", VA = "0xB579C8")]
		private void ShowPanel(bool on)
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0xB57BB8", Offset = "0xB57BB8", VA = "0xB57BB8")]
		private void ResetPanelToDefault()
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0xB57D04", Offset = "0xB57D04", VA = "0xB57D04")]
		private void GetLiveScoresData()
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0xB581BC", Offset = "0xB581BC", VA = "0xB581BC")]
		private void LiveScoresRequestComplete(Message<LeaderboardEntryList> msg)
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0xB587E4", Offset = "0xB587E4", VA = "0xB587E4")]
		public LobbyLevButtonLiveScoresButton()
		{
		}
	}
	[Token(Token = "0x20001A3")]
	public class LobbyLevButtonScoresButton : MonoBehaviour
	{
		[Token(Token = "0x20001A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E464", Offset = "0x58E464")]
		private sealed class <PressAction>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x170000DD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600092D")]
				[Address(RVA = "0xF3ACC4", Offset = "0xF3ACC4", VA = "0xF3ACC4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600092F")]
				[Address(RVA = "0xF3AD0C", Offset = "0xF3AD0C", VA = "0xF3AD0C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600092A")]
			[Address(RVA = "0xF3ABC8", Offset = "0xF3ABC8", VA = "0xF3ABC8")]
			[DebuggerHidden]
			public <PressAction>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x600092B")]
			[Address(RVA = "0xF3ABF4", Offset = "0xF3ABF4", VA = "0xF3ABF4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600092C")]
			[Address(RVA = "0xF3ABF8", Offset = "0xF3ABF8", VA = "0xF3ABF8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600092E")]
			[Address(RVA = "0xF3ACCC", Offset = "0xF3ACCC", VA = "0xF3ACCC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000A37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject scoresPanelObj;

		[Token(Token = "0x4000A38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LobbyLevelButton levelButton;

		[Token(Token = "0x4000A39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject casualLabel;

		[Token(Token = "0x4000A3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject masterLabel;

		[Token(Token = "0x4000A3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool hoverOn;

		[Token(Token = "0x4000A3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TextMeshPro[] usernames;

		[Token(Token = "0x4000A3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public TextMeshPro[] scores;

		[Token(Token = "0x6000924")]
		[Address(RVA = "0xB587FC", Offset = "0xB587FC", VA = "0xB587FC")]
		public void HoverChanged(bool on)
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0xB58978", Offset = "0xB58978", VA = "0xB58978")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5935F0", Offset = "0x5935F0")]
		private IEnumerator PressAction()
		{
			return null;
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0xB58820", Offset = "0xB58820", VA = "0xB58820")]
		private void ShowPanel(bool on)
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0xB58E30", Offset = "0xB58E30", VA = "0xB58E30")]
		private void ResetPanelToDefault()
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0xB589D4", Offset = "0xB589D4", VA = "0xB589D4")]
		private void UpdatePanelInformation()
		{
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0xB58F90", Offset = "0xB58F90", VA = "0xB58F90")]
		public LobbyLevButtonScoresButton()
		{
		}
	}
	[Token(Token = "0x20001A5")]
	public class LobbyLevelButton : MonoBehaviour
	{
		[Token(Token = "0x20001A6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E474", Offset = "0x58E474")]
		private sealed class <PressAction>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LobbyLevelButton <>4__this;

			[Token(Token = "0x170000DF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600093A")]
				[Address(RVA = "0xF3AE30", Offset = "0xF3AE30", VA = "0xF3AE30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600093C")]
				[Address(RVA = "0xF3AE78", Offset = "0xF3AE78", VA = "0xF3AE78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000937")]
			[Address(RVA = "0xF3AD14", Offset = "0xF3AD14", VA = "0xF3AD14")]
			[DebuggerHidden]
			public <PressAction>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x6000938")]
			[Address(RVA = "0xF3AD40", Offset = "0xF3AD40", VA = "0xF3AD40", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000939")]
			[Address(RVA = "0xF3AD44", Offset = "0xF3AD44", VA = "0xF3AD44", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600093B")]
			[Address(RVA = "0xF3AE38", Offset = "0xF3AE38", VA = "0xF3AE38", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000A40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int LevelIndex;

		[Token(Token = "0x4000A41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[HideInInspector]
		public bool HighestLevel;

		[Token(Token = "0x4000A42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject Sparks;

		[Token(Token = "0x4000A43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject Rays;

		[Token(Token = "0x4000A44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform ButtonTr;

		[Token(Token = "0x4000A45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AutoRotate ButtonRotation;

		[Token(Token = "0x4000A46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioSource levelRevealSound;

		[Token(Token = "0x4000A47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject activeHelpBubble;

		[Token(Token = "0x4000A48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool hoverOn;

		[Token(Token = "0x4000A49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float lowPosY;

		[Token(Token = "0x4000A4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 normalPos;

		[Token(Token = "0x4000A4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool firstTime;

		[Token(Token = "0x6000930")]
		[Address(RVA = "0xFBC9F4", Offset = "0xFBC9F4", VA = "0xFBC9F4")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0xFBCBD0", Offset = "0xFBCBD0", VA = "0xFBCBD0")]
		public void ShowActiveHelp(bool on)
		{
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0xFBCC74", Offset = "0xFBCC74", VA = "0xFBCC74")]
		public void HoverChanged(bool on)
		{
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0xFBCD18", Offset = "0xFBCD18", VA = "0xFBCD18")]
		public void Press()
		{
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0xFBCD44", Offset = "0xFBCD44", VA = "0xFBCD44")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5936A0", Offset = "0x5936A0")]
		private IEnumerator PressAction()
		{
			return null;
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0xFBCDBC", Offset = "0xFBCDBC", VA = "0xFBCDBC")]
		public LobbyLevelButton()
		{
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0xFBCE04", Offset = "0xFBCE04", VA = "0xFBCE04")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593700", Offset = "0x593700")]
		private void <OnEnable>b__12_0()
		{
		}
	}
	[Token(Token = "0x20001A7")]
	public class LobbyPlayStoryButton : MonoBehaviour
	{
		[Token(Token = "0x20001A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E484", Offset = "0x58E484")]
		private sealed class <PressAction>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x170000E1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000944")]
				[Address(RVA = "0xF3AF90", Offset = "0xF3AF90", VA = "0xF3AF90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000946")]
				[Address(RVA = "0xF3AFD8", Offset = "0xF3AFD8", VA = "0xF3AFD8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000941")]
			[Address(RVA = "0xF3AE80", Offset = "0xF3AE80", VA = "0xF3AE80")]
			[DebuggerHidden]
			public <PressAction>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000942")]
			[Address(RVA = "0xF3AEAC", Offset = "0xF3AEAC", VA = "0xF3AEAC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000943")]
			[Address(RVA = "0xF3AEB0", Offset = "0xF3AEB0", VA = "0xF3AEB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000945")]
			[Address(RVA = "0xF3AF98", Offset = "0xF3AF98", VA = "0xF3AF98", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000A4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform doorTr;

		[Token(Token = "0x4000A50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource doorUpSound;

		[Token(Token = "0x4000A51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioSource doorDownSound;

		[Token(Token = "0x4000A52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hoverOn;

		[Token(Token = "0x4000A53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float doorUpPosY;

		[Token(Token = "0x4000A54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float doorDownPosY;

		[Token(Token = "0x600093D")]
		[Address(RVA = "0xFBCE20", Offset = "0xFBCE20", VA = "0xFBCE20")]
		public void HoverChanged(bool on)
		{
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0xFBCF50", Offset = "0xFBCF50", VA = "0xFBCF50")]
		public void Press()
		{
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0xFBCF7C", Offset = "0xFBCF7C", VA = "0xFBCF7C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x593760", Offset = "0x593760")]
		private IEnumerator PressAction()
		{
			return null;
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0xFBCFD8", Offset = "0xFBCFD8", VA = "0xFBCFD8")]
		public LobbyPlayStoryButton()
		{
		}
	}
	[Token(Token = "0x20001A9")]
	public class LobbyPlaySurvivalButton : MonoBehaviour
	{
		[Token(Token = "0x20001AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E494", Offset = "0x58E494")]
		private sealed class <PressAction>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x170000E3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600094E")]
				[Address(RVA = "0xF3B0F0", Offset = "0xF3B0F0", VA = "0xF3B0F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000950")]
				[Address(RVA = "0xF3B138", Offset = "0xF3B138", VA = "0xF3B138", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600094B")]
			[Address(RVA = "0xF3AFE0", Offset = "0xF3AFE0", VA = "0xF3AFE0")]
			[DebuggerHidden]
			public <PressAction>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600094C")]
			[Address(RVA = "0xF3B00C", Offset = "0xF3B00C", VA = "0xF3B00C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600094D")]
			[Address(RVA = "0xF3B010", Offset = "0xF3B010", VA = "0xF3B010", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600094F")]
			[Address(RVA = "0xF3B0F8", Offset = "0xF3B0F8", VA = "0xF3B0F8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000A57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform doorTr;

		[Token(Token = "0x4000A58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource doorUpSound;

		[Token(Token = "0x4000A59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioSource doorDownSound;

		[Token(Token = "0x4000A5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hoverOn;

		[Token(Token = "0x4000A5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float doorUpPosY;

		[Token(Token = "0x4000A5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float doorDownPosY;

		[Token(Token = "0x6000947")]
		[Address(RVA = "0xFBCFEC", Offset = "0xFBCFEC", VA = "0xFBCFEC")]
		public void HoverChanged(bool on)
		{
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0xFBD11C", Offset = "0xFBD11C", VA = "0xFBD11C")]
		public void Press()
		{
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0xFBD148", Offset = "0xFBD148", VA = "0xFBD148")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x593810", Offset = "0x593810")]
		private IEnumerator PressAction()
		{
			return null;
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0xFBD1A4", Offset = "0xFBD1A4", VA = "0xFBD1A4")]
		public LobbyPlaySurvivalButton()
		{
		}
	}
	[Token(Token = "0x20001AB")]
	public class LobbyQuitButton : MonoBehaviour
	{
		[Token(Token = "0x20001AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E4A4", Offset = "0x58E4A4")]
		private sealed class <PressAction>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x170000E5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000958")]
				[Address(RVA = "0xF3B210", Offset = "0xF3B210", VA = "0xF3B210", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600095A")]
				[Address(RVA = "0xF3B258", Offset = "0xF3B258", VA = "0xF3B258", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000955")]
			[Address(RVA = "0xF3B140", Offset = "0xF3B140", VA = "0xF3B140")]
			[DebuggerHidden]
			public <PressAction>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000956")]
			[Address(RVA = "0xF3B16C", Offset = "0xF3B16C", VA = "0xF3B16C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000957")]
			[Address(RVA = "0xF3B170", Offset = "0xF3B170", VA = "0xF3B170", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000959")]
			[Address(RVA = "0xF3B218", Offset = "0xF3B218", VA = "0xF3B218", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000A5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform doorTr;

		[Token(Token = "0x4000A60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource doorUpSound;

		[Token(Token = "0x4000A61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioSource doorDownSound;

		[Token(Token = "0x4000A62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hoverOn;

		[Token(Token = "0x4000A63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float doorUpPosY;

		[Token(Token = "0x4000A64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float doorDownPosY;

		[Token(Token = "0x6000951")]
		[Address(RVA = "0xFBD1B8", Offset = "0xFBD1B8", VA = "0xFBD1B8")]
		public void HoverChanged(bool on)
		{
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0xFBD2A0", Offset = "0xFBD2A0", VA = "0xFBD2A0")]
		public void Press()
		{
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0xFBD30C", Offset = "0xFBD30C", VA = "0xFBD30C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5938C0", Offset = "0x5938C0")]
		private IEnumerator PressAction()
		{
			return null;
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0xFBD368", Offset = "0xFBD368", VA = "0xFBD368")]
		public LobbyQuitButton()
		{
		}
	}
	[Token(Token = "0x20001AD")]
	public class LobbySelectLevelBackButton : MonoBehaviour
	{
		[Token(Token = "0x4000A67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform doorTr;

		[Token(Token = "0x4000A68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource doorUpSound;

		[Token(Token = "0x4000A69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioSource doorDownSound;

		[Token(Token = "0x4000A6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hoverOn;

		[Token(Token = "0x4000A6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float doorUpPosY;

		[Token(Token = "0x4000A6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float doorDownPosY;

		[Token(Token = "0x600095B")]
		[Address(RVA = "0xFBD37C", Offset = "0xFBD37C", VA = "0xFBD37C")]
		public void HoverChanged(bool on)
		{
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0xFBD4AC", Offset = "0xFBD4AC", VA = "0xFBD4AC")]
		public void Press()
		{
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0xFBD51C", Offset = "0xFBD51C", VA = "0xFBD51C")]
		public LobbySelectLevelBackButton()
		{
		}
	}
	[Token(Token = "0x20001AE")]
	public class LobbyShowCreditsButton : MonoBehaviour
	{
		[Token(Token = "0x20001AF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E4B4", Offset = "0x58E4B4")]
		private sealed class <PressAction>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LobbyShowCreditsButton <>4__this;

			[Token(Token = "0x170000E7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000965")]
				[Address(RVA = "0xF3B344", Offset = "0xF3B344", VA = "0xF3B344", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000967")]
				[Address(RVA = "0xF3B38C", Offset = "0xF3B38C", VA = "0xF3B38C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000962")]
			[Address(RVA = "0xF3B260", Offset = "0xF3B260", VA = "0xF3B260")]
			[DebuggerHidden]
			public <PressAction>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000963")]
			[Address(RVA = "0xF3B28C", Offset = "0xF3B28C", VA = "0xF3B28C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000964")]
			[Address(RVA = "0xF3B290", Offset = "0xF3B290", VA = "0xF3B290", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000966")]
			[Address(RVA = "0xF3B34C", Offset = "0xF3B34C", VA = "0xF3B34C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000A6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool hoverOn;

		[Token(Token = "0x4000A6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LobbyCreditsPanel creditsPanel;

		[Token(Token = "0x600095E")]
		[Address(RVA = "0xFBD530", Offset = "0xFBD530", VA = "0xFBD530")]
		public void HoverChanged(bool on)
		{
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0xFBD550", Offset = "0xFBD550", VA = "0xFBD550")]
		public void Press()
		{
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0xFBD57C", Offset = "0xFBD57C", VA = "0xFBD57C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x593970", Offset = "0x593970")]
		private IEnumerator PressAction()
		{
			return null;
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0xFBD5F4", Offset = "0xFBD5F4", VA = "0xFBD5F4")]
		public LobbyShowCreditsButton()
		{
		}
	}
	[Token(Token = "0x20001B0")]
	public class UIManager : MonoBehaviour
	{
		[Token(Token = "0x4000A72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Active;

		[Token(Token = "0x4000A73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool rightEnabled;

		[Token(Token = "0x4000A74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public XRRayInteractor leftRayInteractor;

		[Token(Token = "0x4000A75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public XRRayInteractor rightRayInteractor;

		[Token(Token = "0x6000968")]
		[Address(RVA = "0xB0F514", Offset = "0xB0F514", VA = "0xB0F514")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0xB0F580", Offset = "0xB0F580", VA = "0xB0F580")]
		public void Activate(bool on)
		{
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0xB0F5F8", Offset = "0xB0F5F8", VA = "0xB0F5F8")]
		public void EnablePointer(bool isRight)
		{
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0xB0F668", Offset = "0xB0F668", VA = "0xB0F668")]
		public UIManager()
		{
		}
	}
	[Token(Token = "0x20001B1")]
	public class ActiveHelpBubble : MonoBehaviour
	{
		[Token(Token = "0x4000A76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject text;

		[Token(Token = "0x4000A77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 originalPos;

		[Token(Token = "0x4000A78")]
		private const float WOBBLE_HEIGHT = 0.2f;

		[Token(Token = "0x4000A79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float wobbleAngle;

		[Token(Token = "0x4000A7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion textRot;

		[Token(Token = "0x4000A7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float textRotAngle;

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x1407238", Offset = "0x1407238", VA = "0x1407238")]
		private void Start()
		{
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x14072D0", Offset = "0x14072D0", VA = "0x14072D0")]
		private void Update()
		{
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0x1407404", Offset = "0x1407404", VA = "0x1407404")]
		private void UpdateText()
		{
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x14072F4", Offset = "0x14072F4", VA = "0x14072F4")]
		private void UpdatePos()
		{
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x14074D8", Offset = "0x14074D8", VA = "0x14074D8")]
		public ActiveHelpBubble()
		{
		}
	}
	[Token(Token = "0x20001B2")]
	public class ActiveHelpLobby : MonoBehaviour
	{
		[Token(Token = "0x20001B3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E4C4", Offset = "0x58E4C4")]
		private sealed class <Start>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ActiveHelpLobby <>4__this;

			[Token(Token = "0x170000E9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600097C")]
				[Address(RVA = "0xB12A98", Offset = "0xB12A98", VA = "0xB12A98", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600097E")]
				[Address(RVA = "0xB12AE0", Offset = "0xB12AE0", VA = "0xB12AE0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000979")]
			[Address(RVA = "0xB128E0", Offset = "0xB128E0", VA = "0xB128E0")]
			[DebuggerHidden]
			public <Start>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x600097A")]
			[Address(RVA = "0xB1290C", Offset = "0xB1290C", VA = "0xB1290C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600097B")]
			[Address(RVA = "0xB12910", Offset = "0xB12910", VA = "0xB12910", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600097D")]
			[Address(RVA = "0xB12AA0", Offset = "0xB12AA0", VA = "0xB12AA0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000A7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ActiveHelpLobby Instance;

		[Token(Token = "0x4000A7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject campaigHelpBubble;

		[Token(Token = "0x4000A7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject survivalHelpBubble;

		[Token(Token = "0x4000A7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject exitHelpBubble;

		[Token(Token = "0x4000A80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string AH_KEY_CAMPAIGN;

		[Token(Token = "0x4000A81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string AH_KEY_SURVIVAL;

		[Token(Token = "0x4000A82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string AH_KEY_EXIT;

		[Token(Token = "0x4000A83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int ahCampaignEntered;

		[Token(Token = "0x4000A84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int ahSurvivalEntered;

		[Token(Token = "0x4000A85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int ahExitedGame;

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x14074E0", Offset = "0x14074E0", VA = "0x14074E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x1407534", Offset = "0x1407534", VA = "0x1407534")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x593A20", Offset = "0x593A20")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x14075AC", Offset = "0x14075AC", VA = "0x14075AC")]
		private void ReadFromStorage()
		{
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x140760C", Offset = "0x140760C", VA = "0x140760C")]
		private void UpdateActiveHelpVisibility()
		{
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x140767C", Offset = "0x140767C", VA = "0x140767C")]
		public void EnterCampaign()
		{
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x14076B4", Offset = "0x14076B4", VA = "0x14076B4")]
		public void EnterSurvival()
		{
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x14076EC", Offset = "0x14076EC", VA = "0x14076EC")]
		public void GameExited()
		{
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x1407724", Offset = "0x1407724", VA = "0x1407724")]
		public ActiveHelpLobby()
		{
		}
	}
	[Token(Token = "0x20001B4")]
	public class AmbientSounds : MonoBehaviour
	{
		[Token(Token = "0x4000A89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float nextSoundTimer;

		[Token(Token = "0x4000A8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float nextSoundTimeMinSec;

		[Token(Token = "0x4000A8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float nextSoundTImeMaxSec;

		[Token(Token = "0x4000A8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<AudioSource> sounds;

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x14077C8", Offset = "0x14077C8", VA = "0x14077C8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x14077F4", Offset = "0x14077F4", VA = "0x14077F4")]
		private void SetNextSoundTimer()
		{
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x1407820", Offset = "0x1407820", VA = "0x1407820")]
		private void Update()
		{
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x1407880", Offset = "0x1407880", VA = "0x1407880")]
		private void PlayAmbientRandomSound()
		{
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x140799C", Offset = "0x140799C", VA = "0x140799C")]
		public AmbientSounds()
		{
		}
	}
	[Token(Token = "0x20001B5")]
	public class AutoRotate : MonoBehaviour
	{
		[Token(Token = "0x4000A8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Speed;

		[Token(Token = "0x4000A8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool useGlobalSpace;

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x140A980", Offset = "0x140A980", VA = "0x140A980")]
		public void Update()
		{
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x140AA00", Offset = "0x140AA00", VA = "0x140AA00")]
		public AutoRotate()
		{
		}
	}
	[Token(Token = "0x20001B6")]
	public class AutoTranslate : MonoBehaviour
	{
		[Token(Token = "0x4000A8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Speed;

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x140AA34", Offset = "0x140AA34", VA = "0x140AA34")]
		public void Update()
		{
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0x140AAC0", Offset = "0x140AAC0", VA = "0x140AAC0")]
		public AutoTranslate()
		{
		}
	}
	[Token(Token = "0x20001B7")]
	public class FPS : MonoBehaviour
	{
		[Token(Token = "0x4000A90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int frameCounter;

		[Token(Token = "0x4000A91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int frameCountLimit;

		[Token(Token = "0x4000A92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float dtAccum;

		[Token(Token = "0x4000A93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshPro text;

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x86FCB4", Offset = "0x86FCB4", VA = "0x86FCB4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x86FD10", Offset = "0x86FD10", VA = "0x86FD10")]
		private void Update()
		{
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x86FDF4", Offset = "0x86FDF4", VA = "0x86FDF4")]
		public FPS()
		{
		}
	}
	[Token(Token = "0x20001B8")]
	public class FadeView : MonoBehaviour
	{
		[Token(Token = "0x20001B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E4D4", Offset = "0x58E4D4")]
		private sealed class <WaitForSurvivalCompleteLevelPanelToClose>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FadeView <>4__this;

			[Token(Token = "0x170000EB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600099C")]
				[Address(RVA = "0xF38480", Offset = "0xF38480", VA = "0xF38480", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600099E")]
				[Address(RVA = "0xF384C8", Offset = "0xF384C8", VA = "0xF384C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000999")]
			[Address(RVA = "0xF3828C", Offset = "0xF3828C", VA = "0xF3828C")]
			[DebuggerHidden]
			public <WaitForSurvivalCompleteLevelPanelToClose>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x600099A")]
			[Address(RVA = "0xF382B8", Offset = "0xF382B8", VA = "0xF382B8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600099B")]
			[Address(RVA = "0xF382BC", Offset = "0xF382BC", VA = "0xF382BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600099D")]
			[Address(RVA = "0xF38488", Offset = "0xF38488", VA = "0xF38488", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20001BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E4E4", Offset = "0x58E4E4")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x4000A9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action onComplete;

			[Token(Token = "0x600099F")]
			[Address(RVA = "0xF38268", Offset = "0xF38268", VA = "0xF38268")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x60009A0")]
			[Address(RVA = "0xF38270", Offset = "0xF38270", VA = "0xF38270")]
			internal void <FadeIn>b__0()
			{
			}
		}

		[Token(Token = "0x4000A94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MeshRenderer mesh;

		[Token(Token = "0x4000A95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool needsToFadeOut;

		[Token(Token = "0x4000A96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool smoothFps;

		[Token(Token = "0x4000A97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int smoothFpsCount;

		[Token(Token = "0x4000A98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int fadeOutFpsCount;

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x86FE04", Offset = "0x86FE04", VA = "0x86FE04")]
		public void Awake()
		{
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x86FE70", Offset = "0x86FE70", VA = "0x86FE70")]
		public void Start()
		{
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x870090", Offset = "0x870090", VA = "0x870090")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x8702B0", Offset = "0x8702B0", VA = "0x8702B0")]
		public void Update()
		{
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x8704B0", Offset = "0x8704B0", VA = "0x8704B0")]
		private void OnLevelLoaded()
		{
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x8704C0", Offset = "0x8704C0", VA = "0x8704C0")]
		private void OnLobbyEntered(bool on)
		{
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x8704D4", Offset = "0x8704D4", VA = "0x8704D4")]
		public void FadeOut()
		{
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x870344", Offset = "0x870344", VA = "0x870344")]
		private void FadeOutAfterFPSIsSmooth()
		{
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x8704E4", Offset = "0x8704E4", VA = "0x8704E4")]
		private void OnPlayerLost()
		{
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x870594", Offset = "0x870594", VA = "0x870594")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x593AD0", Offset = "0x593AD0")]
		private IEnumerator WaitForSurvivalCompleteLevelPanelToClose()
		{
			return null;
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x87060C", Offset = "0x87060C", VA = "0x87060C")]
		private void FadeInRed()
		{
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0x87072C", Offset = "0x87072C", VA = "0x87072C")]
		public void FadeIn(Action onComplete)
		{
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0x87093C", Offset = "0x87093C", VA = "0x87093C")]
		public FadeView()
		{
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0x870944", Offset = "0x870944", VA = "0x870944")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593B30", Offset = "0x593B30")]
		private void <FadeOutAfterFPSIsSmooth>b__12_0()
		{
		}
	}
	[Token(Token = "0x20001BB")]
	public class GlobalMultiplier : MonoBehaviour
	{
		[Token(Token = "0x4000A9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshPro text;

		[Token(Token = "0x4000A9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ParticleSystem particles;

		[Token(Token = "0x4000A9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 speedDir;

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0xB46BE8", Offset = "0xB46BE8", VA = "0xB46BE8")]
		public void Setup()
		{
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0xB47F94", Offset = "0xB47F94", VA = "0xB47F94")]
		public void Update()
		{
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0xB48048", Offset = "0xB48048", VA = "0xB48048")]
		public GlobalMultiplier()
		{
		}
	}
	[Token(Token = "0x20001BC")]
	public class LightRays : MonoBehaviour
	{
		[Token(Token = "0x20001BD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E4F4", Offset = "0x58E4F4")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000AA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MeshRenderer mesh;

			[Token(Token = "0x4000AA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float time;

			[Token(Token = "0x4000AA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LightRays <>4__this;

			[Token(Token = "0x4000AA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int index;

			[Token(Token = "0x4000AAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public TweenCallback <>9__1;

			[Token(Token = "0x60009A8")]
			[Address(RVA = "0xF3A524", Offset = "0xF3A524", VA = "0xF3A524")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60009A9")]
			[Address(RVA = "0xF3A52C", Offset = "0xF3A52C", VA = "0xF3A52C")]
			internal void <StartNewFade>b__0()
			{
			}

			[Token(Token = "0x60009AA")]
			[Address(RVA = "0xF3A69C", Offset = "0xF3A69C", VA = "0xF3A69C")]
			internal void <StartNewFade>b__1()
			{
			}
		}

		[Token(Token = "0x4000AA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MeshRenderer[] rayMeshes;

		[Token(Token = "0x4000AA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool[] tweenRunning;

		[Token(Token = "0x4000AA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float timeRangeMin;

		[Token(Token = "0x4000AA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float timeRangeMax;

		[Token(Token = "0x4000AA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float minAlpha;

		[Token(Token = "0x4000AA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float maxAlpha;

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0xB55DA0", Offset = "0xB55DA0", VA = "0xB55DA0")]
		public void Start()
		{
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0xB55E18", Offset = "0xB55E18", VA = "0xB55E18")]
		public void Update()
		{
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0xB55EA4", Offset = "0xB55EA4", VA = "0xB55EA4")]
		private void StartNewFade(int index, MeshRenderer mesh)
		{
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0xB56048", Offset = "0xB56048", VA = "0xB56048")]
		public LightRays()
		{
		}
	}
	[Token(Token = "0x20001BE")]
	public class LookAtPlayerHeadset : MonoBehaviour
	{
		[Token(Token = "0x60009AB")]
		[Address(RVA = "0xFBFD64", Offset = "0xFBFD64", VA = "0xFBFD64")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0xFBFE84", Offset = "0xFBFE84", VA = "0xFBFE84")]
		public LookAtPlayerHeadset()
		{
		}
	}
	[Token(Token = "0x20001BF")]
	public class ObjectAutoDestroy : MonoBehaviour
	{
		[Token(Token = "0x4000AAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float lifeTime;

		[Token(Token = "0x4000AAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float timer;

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0xD89008", Offset = "0xD89008", VA = "0xD89008")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0xD89020", Offset = "0xD89020", VA = "0xD89020")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0xD89028", Offset = "0xD89028", VA = "0xD89028")]
		public void SetLifeTime()
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0xD89034", Offset = "0xD89034", VA = "0xD89034")]
		public void ActivateWithTime(float time)
		{
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0xD89044", Offset = "0xD89044", VA = "0xD89044")]
		public void Update()
		{
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0xD890A0", Offset = "0xD890A0", VA = "0xD890A0")]
		private void DestroyObject()
		{
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0xD891C8", Offset = "0xD891C8", VA = "0xD891C8")]
		private void ReturnToPoolOrDestroy()
		{
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0xD89304", Offset = "0xD89304", VA = "0xD89304")]
		public void DestroyWhenCollidingWithFlyBonus()
		{
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0xD893C0", Offset = "0xD893C0", VA = "0xD893C0")]
		public ObjectAutoDestroy()
		{
		}
	}
	[Token(Token = "0x20001C0")]
	public class PlayerHeadset : MonoBehaviour
	{
		[Token(Token = "0x20001C1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E504", Offset = "0x58E504")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000AAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PlayerHeadset <>4__this;

			[Token(Token = "0x4000AAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float step2MoveUpTime;

			[Token(Token = "0x4000AB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TweenCallback <>9__1;

			[Token(Token = "0x60009B9")]
			[Address(RVA = "0xF3E50C", Offset = "0xF3E50C", VA = "0xF3E50C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60009BA")]
			[Address(RVA = "0xF3E514", Offset = "0xF3E514", VA = "0xF3E514")]
			internal void <ShowFloatingBonusMessage>b__0()
			{
			}

			[Token(Token = "0x60009BB")]
			[Address(RVA = "0xF3E620", Offset = "0xF3E620", VA = "0xF3E620")]
			internal void <ShowFloatingBonusMessage>b__1()
			{
			}
		}

		[Token(Token = "0x4000AAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject floatingBonusMessage;

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x849E5C", Offset = "0x849E5C", VA = "0x849E5C")]
		public void Awake()
		{
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x849EDC", Offset = "0x849EDC", VA = "0x849EDC")]
		public void ShowFloatingBonusMessage()
		{
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x84A094", Offset = "0x84A094", VA = "0x84A094")]
		public PlayerHeadset()
		{
		}
	}
	[Token(Token = "0x20001C2")]
	public class PlayerPlayArea : MonoBehaviour
	{
		[Token(Token = "0x4000AB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float shakeRadius;

		[Token(Token = "0x4000AB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float shakeStepTime;

		[Token(Token = "0x4000AB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int shakesCount;

		[Token(Token = "0x4000AB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool vrInputFocus;

		[Token(Token = "0x4000AB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int uiManagerActiveBeforeLosingFocus;

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x84A09C", Offset = "0x84A09C", VA = "0x84A09C")]
		public void Awake()
		{
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x84A148", Offset = "0x84A148", VA = "0x84A148")]
		public void Update()
		{
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x84A3C0", Offset = "0x84A3C0", VA = "0x84A3C0")]
		public void BombShake()
		{
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x84A460", Offset = "0x84A460", VA = "0x84A460")]
		private void MakeShakeMove(float radius, Action onComplete)
		{
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x84A5A4", Offset = "0x84A5A4", VA = "0x84A5A4")]
		private void ShakeComplete()
		{
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x84A54C", Offset = "0x84A54C", VA = "0x84A54C")]
		private Vector3 GetNextMovePos(float radius)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x84A674", Offset = "0x84A674", VA = "0x84A674")]
		public PlayerPlayArea()
		{
		}
	}
	[Token(Token = "0x20001C3")]
	public class ProgressManager : MonoBehaviour
	{
		[Token(Token = "0x4000AB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int maxReachedLevel;

		[Token(Token = "0x4000AB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string maxReachedLevelKey;

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x84BD74", Offset = "0x84BD74", VA = "0x84BD74")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x84BE28", Offset = "0x84BE28", VA = "0x84BE28")]
		private void Reset()
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x84BE54", Offset = "0x84BE54", VA = "0x84BE54")]
		public void DebugIncreaseMaxLevel()
		{
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x84BDF8", Offset = "0x84BDF8", VA = "0x84BDF8")]
		private void LoadSavedData()
		{
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x84BE6C", Offset = "0x84BE6C", VA = "0x84BE6C")]
		public void SetCurrentStoryLevel(int level)
		{
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x84BE40", Offset = "0x84BE40", VA = "0x84BE40")]
		private void SaveMaxReachedLevelToStorage()
		{
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x84BE90", Offset = "0x84BE90", VA = "0x84BE90")]
		public int GetStoryMaxReachedLevel()
		{
			return default(int);
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x84BE98", Offset = "0x84BE98", VA = "0x84BE98")]
		public ProgressManager()
		{
		}
	}
	[Token(Token = "0x20001C4")]
	public class PulseTextAlpha : MonoBehaviour
	{
		[Token(Token = "0x4000AB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextMeshProUGUI textElem;

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x84BEF4", Offset = "0x84BEF4", VA = "0x84BEF4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x84BF50", Offset = "0x84BF50", VA = "0x84BF50")]
		private void Update()
		{
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x84BFF8", Offset = "0x84BFF8", VA = "0x84BFF8")]
		public PulseTextAlpha()
		{
		}
	}
	[Token(Token = "0x20001C5")]
	public class SceneManager : MonoBehaviour
	{
		[Token(Token = "0x20001C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E514", Offset = "0x58E514")]
		private sealed class <LoadYourAsyncScene>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000ABA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000ABB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string name;

			[Token(Token = "0x4000ABC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<string> onComplete;

			[Token(Token = "0x4000ABD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private AsyncOperation <asyncLoad>5__2;

			[Token(Token = "0x170000ED")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009D7")]
				[Address(RVA = "0xF3E9C0", Offset = "0xF3E9C0", VA = "0xF3E9C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009D9")]
				[Address(RVA = "0xF3EA08", Offset = "0xF3EA08", VA = "0xF3EA08", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009D4")]
			[Address(RVA = "0xF3E830", Offset = "0xF3E830", VA = "0xF3E830")]
			[DebuggerHidden]
			public <LoadYourAsyncScene>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60009D5")]
			[Address(RVA = "0xF3E85C", Offset = "0xF3E85C", VA = "0xF3E85C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009D6")]
			[Address(RVA = "0xF3E860", Offset = "0xF3E860", VA = "0xF3E860", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009D8")]
			[Address(RVA = "0xF3E9C8", Offset = "0xF3E9C8", VA = "0xF3E9C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20001C7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E524", Offset = "0x58E524")]
		private sealed class <UnLoadYourAsyncScene>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000ABE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000ABF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string name;

			[Token(Token = "0x4000AC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<string> onComplete;

			[Token(Token = "0x4000AC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private AsyncOperation <asyncLoad>5__2;

			[Token(Token = "0x170000EF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009DD")]
				[Address(RVA = "0xF3EB9C", Offset = "0xF3EB9C", VA = "0xF3EB9C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009DF")]
				[Address(RVA = "0xF3EBE4", Offset = "0xF3EBE4", VA = "0xF3EBE4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009DA")]
			[Address(RVA = "0xF3EA10", Offset = "0xF3EA10", VA = "0xF3EA10")]
			[DebuggerHidden]
			public <UnLoadYourAsyncScene>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60009DB")]
			[Address(RVA = "0xF3EA3C", Offset = "0xF3EA3C", VA = "0xF3EA3C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009DC")]
			[Address(RVA = "0xF3EA40", Offset = "0xF3EA40", VA = "0xF3EA40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009DE")]
			[Address(RVA = "0xF3EBA4", Offset = "0xF3EBA4", VA = "0xF3EBA4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x8514CC", Offset = "0x8514CC", VA = "0x8514CC")]
		public void Awake()
		{
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x851538", Offset = "0x851538", VA = "0x851538")]
		public void LoadScene(string name, Action<string> onComplete)
		{
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x8515F8", Offset = "0x8515F8", VA = "0x8515F8")]
		public void UnLoadScene(string name, Action<string> onComplete)
		{
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x851564", Offset = "0x851564", VA = "0x851564")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x593B90", Offset = "0x593B90")]
		private IEnumerator LoadYourAsyncScene(string name, Action<string> onComplete)
		{
			return null;
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x851624", Offset = "0x851624", VA = "0x851624")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x593BF0", Offset = "0x593BF0")]
		private IEnumerator UnLoadYourAsyncScene(string name, Action<string> onComplete)
		{
			return null;
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x8516B8", Offset = "0x8516B8", VA = "0x8516B8")]
		public SceneManager()
		{
		}
	}
	[Token(Token = "0x20001C8")]
	public class SkySelector : MonoBehaviour
	{
		[Token(Token = "0x4000AC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject casualSky;

		[Token(Token = "0x4000AC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject masterSky;

		[Token(Token = "0x4000AC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject[] casualRays;

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x8530A0", Offset = "0x8530A0", VA = "0x8530A0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x853354", Offset = "0x853354", VA = "0x853354")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x853454", Offset = "0x853454", VA = "0x853454")]
		private void DifficultyChanged()
		{
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x8531A8", Offset = "0x8531A8", VA = "0x8531A8")]
		private void Setup()
		{
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x853458", Offset = "0x853458", VA = "0x853458")]
		public SkySelector()
		{
		}
	}
	[Token(Token = "0x20001C9")]
	public class SurvivalScores : MonoBehaviour
	{
		[Token(Token = "0x4000AC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshPro lastScoreLabel;

		[Token(Token = "0x4000AC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshPro bestScoreLabel;

		[Token(Token = "0x4000AC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static SurvivalScores Instance;

		[Token(Token = "0x4000AC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string bestScoreLevelKey;

		[Token(Token = "0x4000ACA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string lastScoreLevelKey;

		[Token(Token = "0x4000ACB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float bestScore;

		[Token(Token = "0x4000ACC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float lastScore;

		[Token(Token = "0x4000ACD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float flashLastScoreTimer;

		[Token(Token = "0x4000ACE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float flashBestScoreTimer;

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0xB065D0", Offset = "0xB065D0", VA = "0xB065D0")]
		public void Awake()
		{
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0xB068C4", Offset = "0xB068C4", VA = "0xB068C4")]
		public void Update()
		{
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0xB069D0", Offset = "0xB069D0", VA = "0xB069D0")]
		public void CheckNewScore(float newScore)
		{
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0xB06654", Offset = "0xB06654", VA = "0xB06654")]
		private void LoadSavedData()
		{
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0xB06A38", Offset = "0xB06A38", VA = "0xB06A38")]
		private void SaveData()
		{
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0xB06698", Offset = "0xB06698", VA = "0xB06698")]
		private void UpdateLabels()
		{
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0xB06A70", Offset = "0xB06A70", VA = "0xB06A70")]
		private int GetMinute(float timeSec)
		{
			return default(int);
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0xB06A84", Offset = "0xB06A84", VA = "0xB06A84")]
		private int GetSeconds(float timeSec)
		{
			return default(int);
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0xB06AAC", Offset = "0xB06AAC", VA = "0xB06AAC")]
		public SurvivalScores()
		{
		}
	}
}
namespace Dest.Modeling
{
	[Token(Token = "0x20001CA")]
	public class GeoSphereGenerator
	{
		[Token(Token = "0x20001CB")]
		private struct UndirectedEdge : IEquatable<UndirectedEdge>
		{
			[Token(Token = "0x4000AD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly int Item1;

			[Token(Token = "0x4000AD9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public readonly int Item2;

			[Token(Token = "0x60009F4")]
			[Address(RVA = "0xF38BB0", Offset = "0xF38BB0", VA = "0xF38BB0")]
			public UndirectedEdge(int item1, int item2)
			{
			}

			[Token(Token = "0x60009F5")]
			[Address(RVA = "0xF38BC4", Offset = "0xF38BC4", VA = "0xF38BC4", Slot = "4")]
			public bool Equals(UndirectedEdge other)
			{
				return default(bool);
			}

			[Token(Token = "0x60009F6")]
			[Address(RVA = "0xF38BEC", Offset = "0xF38BEC", VA = "0xF38BEC", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60009F7")]
			[Address(RVA = "0xF38C80", Offset = "0xF38C80", VA = "0xF38C80", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000ACF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector3[] OctahedronVertices;

		[Token(Token = "0x4000AD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int[] OctahedronIndices;

		[Token(Token = "0x4000AD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<Vector3> vertexPositions;

		[Token(Token = "0x4000AD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<int> indexList;

		[Token(Token = "0x4000AD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Vector3> vertices;

		[Token(Token = "0x4000AD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Vector3> normals;

		[Token(Token = "0x4000AD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<Vector2> uvs;

		[Token(Token = "0x4000AD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int[] indices;

		[Token(Token = "0x4000AD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<UndirectedEdge, int> subdividedEdges;

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0xB451A4", Offset = "0xB451A4", VA = "0xB451A4")]
		private GeoSphereGenerator()
		{
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0xB450E8", Offset = "0xB450E8", VA = "0xB450E8")]
		public static Mesh CreateGeoSphere(float radius, int tessellation, bool generateNormals, bool generateUVs, bool invert)
		{
			return null;
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0xB451AC", Offset = "0xB451AC", VA = "0xB451AC")]
		private Mesh Create(float radius, int tessellation, bool generateNormals, bool generateUVs, bool invert)
		{
			return null;
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0xB45F88", Offset = "0xB45F88", VA = "0xB45F88")]
		private void FixPole(int poleIndex)
		{
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0xB45D98", Offset = "0xB45D98", VA = "0xB45D98")]
		private void DivideEdge(int i0, int i1, out Vector3 outVertex, out int outIndex)
		{
		}
	}
	[Token(Token = "0x20001CC")]
	public static class MeshGenerator
	{
		[Token(Token = "0x20001CD")]
		public enum Directions
		{
			[Token(Token = "0x4000ADB")]
			Right,
			[Token(Token = "0x4000ADC")]
			Left,
			[Token(Token = "0x4000ADD")]
			Up,
			[Token(Token = "0x4000ADE")]
			Down,
			[Token(Token = "0x4000ADF")]
			Forward,
			[Token(Token = "0x4000AE0")]
			Back
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0xFC37EC", Offset = "0xFC37EC", VA = "0xFC37EC")]
		public static void Invert(Mesh m)
		{
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0xFC3934", Offset = "0xFC3934", VA = "0xFC3934")]
		public static Mesh CreatePlane(Directions direction, float width, float height, int widthSegments, int heightSegments, bool generateNormals, bool generateUVs)
		{
			return null;
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0xFC3FDC", Offset = "0xFC3FDC", VA = "0xFC3FDC")]
		public static Mesh CreateQuad(Directions direction, float width, float height, bool generateNormals, bool generateUVs)
		{
			return null;
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0xFC450C", Offset = "0xFC450C", VA = "0xFC450C")]
		public static Mesh CreateDisk(Directions direction, float radius, int sides, bool generateNormals, bool generateUVs)
		{
			return null;
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0xFC4B34", Offset = "0xFC4B34", VA = "0xFC4B34")]
		public static Mesh CreateBox(float sizeX, float sizeY, float sizeZ, bool generateNormals, bool generateUVs, bool invert)
		{
			return null;
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0xFC529C", Offset = "0xFC529C", VA = "0xFC529C")]
		public static Mesh CreateWireBox(float sizeX, float sizeY, float sizeZ)
		{
			return null;
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0xFC5478", Offset = "0xFC5478", VA = "0xFC5478")]
		public static Mesh CreateOutlinedBox(float sizeX, float sizeY, float sizeZ, float outline, bool generateNormals, bool generateUVs)
		{
			return null;
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0xFC6304", Offset = "0xFC6304", VA = "0xFC6304")]
		public static Mesh CreateArrow(Directions direction, float lineLength, float lineThickness, float capLength, float capThickness, float capOverhang, bool generateNormals)
		{
			return null;
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0xFC67AC", Offset = "0xFC67AC", VA = "0xFC67AC")]
		public static Mesh CreateCylinder(float radius, float height, int sides, bool generateCaps, bool generateNormals, bool generateUVs, bool invert)
		{
			return null;
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0xFC6ED0", Offset = "0xFC6ED0", VA = "0xFC6ED0")]
		public static Mesh CreateTube(float outerRadius, float innerRadius, float height, int sides, bool generateNormals, bool generateUVs)
		{
			return null;
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0xFC7680", Offset = "0xFC7680", VA = "0xFC7680")]
		public static Mesh CreateGengon(float radius, float height, int sides, bool generateCaps, bool generateNormals, bool generateUVs, bool invert)
		{
			return null;
		}

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0xFC7DA4", Offset = "0xFC7DA4", VA = "0xFC7DA4")]
		public static Mesh CreateCone(float radius1, float radius2, float height, int sides, bool generateCaps, bool generateNormals, bool generateUVs, bool invert)
		{
			return null;
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0xFC8458", Offset = "0xFC8458", VA = "0xFC8458")]
		public static Mesh CreateSphere(float radius, int slices, int stacks, float slicesMaxAngle, float stacksMaxAngle, bool generateNormals, bool generateUVs, bool invert)
		{
			return null;
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0xFC8948", Offset = "0xFC8948", VA = "0xFC8948")]
		public static Mesh CreateTorus(float radius, float thickness, int slices, int sliceTessellation, bool generateNormals, bool generateUVs)
		{
			return null;
		}
	}
	[Token(Token = "0x20001CE")]
	public static class TeapotGenerator
	{
		[Token(Token = "0x20001CF")]
		private struct TeapotPatch
		{
			[Token(Token = "0x4000AE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool MirrorZ;

			[Token(Token = "0x4000AE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int[] Indices;

			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0xF3F534", Offset = "0xF3F534", VA = "0xF3F534")]
			public TeapotPatch(bool mirrorZ, params int[] indices)
			{
			}
		}

		[Token(Token = "0x20001D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E534", Offset = "0x58E534")]
		private sealed class <CreatePatchIndices>d__8 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int <>2__current;

			[Token(Token = "0x4000AE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000AE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int tessellation;

			[Token(Token = "0x4000AE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int <>3__tessellation;

			[Token(Token = "0x4000AEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int baseIndex;

			[Token(Token = "0x4000AEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int <>3__baseIndex;

			[Token(Token = "0x4000AEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private bool isMirrored;

			[Token(Token = "0x4000AED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
			public bool <>3__isMirrored;

			[Token(Token = "0x4000AEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <stride>5__2;

			[Token(Token = "0x4000AEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int[] <indices>5__3;

			[Token(Token = "0x4000AF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int <i>5__4;

			[Token(Token = "0x4000AF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private int <j>5__5;

			[Token(Token = "0x4000AF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int[] <>7__wrap5;

			[Token(Token = "0x4000AF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private int <>7__wrap6;

			[Token(Token = "0x170000F1")]
			private int System.Collections.Generic.IEnumerator<System.Int32>.Current
			{
				[Token(Token = "0x6000A11")]
				[Address(RVA = "0xF3F3D0", Offset = "0xF3F3D0", VA = "0xF3F3D0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x170000F2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A13")]
				[Address(RVA = "0xF3F418", Offset = "0xF3F418", VA = "0xF3F418", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0xF3F110", Offset = "0xF3F110", VA = "0xF3F110")]
			[DebuggerHidden]
			public <CreatePatchIndices>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0xF3F148", Offset = "0xF3F148", VA = "0xF3F148", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A10")]
			[Address(RVA = "0xF3F14C", Offset = "0xF3F14C", VA = "0xF3F14C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A12")]
			[Address(RVA = "0xF3F3D8", Offset = "0xF3F3D8", VA = "0xF3F3D8", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000A14")]
			[Address(RVA = "0xF3F478", Offset = "0xF3F478", VA = "0xF3F478", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<int> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000A15")]
			[Address(RVA = "0xF3F530", Offset = "0xF3F530", VA = "0xF3F530", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000AE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly TeapotPatch[] TeapotPatches;

		[Token(Token = "0x4000AE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Vector3[] TeapotControlPoints;

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0xB06C14", Offset = "0xB06C14", VA = "0xB06C14")]
		public static Mesh CreateTeapot(float size, int tessellation, bool spoute, bool handle, bool lid, bool generateNormals, bool generateUVs)
		{
			return null;
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0xB07070", Offset = "0xB07070", VA = "0xB07070")]
		private static void TessellatePatch(List<Vector3> positions, List<Vector3> normals, List<Vector2> uvs, List<int> indices, ref TeapotPatch patch, int tessellation, Vector3 scale, bool isMirrored)
		{
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0xB077DC", Offset = "0xB077DC", VA = "0xB077DC")]
		private static Vector3 CubicInterpolate(ref Vector3 p1, ref Vector3 p2, ref Vector3 p3, ref Vector3 p4, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0xB07884", Offset = "0xB07884", VA = "0xB07884")]
		private static Vector3 CubicTangent(ref Vector3 p1, ref Vector3 p2, ref Vector3 p3, ref Vector3 p4, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0xB072EC", Offset = "0xB072EC", VA = "0xB072EC")]
		private static void CreatePatchVertices(Vector3[] patch, int tessellation, bool isMirrored, List<Vector3> positions, List<Vector3> normals, List<Vector2> uvs)
		{
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0xB07264", Offset = "0xB07264", VA = "0xB07264")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x593CF0", Offset = "0x593CF0")]
		private static IEnumerable<int> CreatePatchIndices(int tessellation, bool isMirrored, int baseIndex)
		{
			return null;
		}
	}
	[Token(Token = "0x20001D1")]
	public class Arrow : PrimitiveBase
	{
		[Token(Token = "0x4000AF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MeshGenerator.Directions Direction;

		[Token(Token = "0x4000AF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float LineLength;

		[Token(Token = "0x4000AF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float LineThickness;

		[Token(Token = "0x4000AF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float CapLength;

		[Token(Token = "0x4000AF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float CapThickness;

		[Token(Token = "0x4000AF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float CapOverhang;

		[Token(Token = "0x4000AFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool GenerateNormals;

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x140A590", Offset = "0x140A590", VA = "0x140A590", Slot = "4")]
		public override void CreateMesh()
		{
		}

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x140A5D4", Offset = "0x140A5D4", VA = "0x140A5D4")]
		public Arrow()
		{
		}
	}
	[Token(Token = "0x20001D2")]
	public class Box : PrimitiveBase
	{
		[Token(Token = "0x4000AFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float SizeX;

		[Token(Token = "0x4000AFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float SizeY;

		[Token(Token = "0x4000AFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float SizeZ;

		[Token(Token = "0x4000AFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool GenerateNormals;

		[Token(Token = "0x4000AFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool GenerateUVs;

		[Token(Token = "0x4000B00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
		public bool Invert;

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x14191A0", Offset = "0x14191A0", VA = "0x14191A0", Slot = "4")]
		public override void CreateMesh()
		{
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x14191E4", Offset = "0x14191E4", VA = "0x14191E4")]
		public Box()
		{
		}
	}
	[Token(Token = "0x20001D3")]
	public class Cone : PrimitiveBase
	{
		[Token(Token = "0x4000B01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Radius1;

		[Token(Token = "0x4000B02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float Radius2;

		[Token(Token = "0x4000B03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float Height;

		[Token(Token = "0x4000B04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int Sides;

		[Token(Token = "0x4000B05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool GenerateCaps;

		[Token(Token = "0x4000B06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool GenerateNormals;

		[Token(Token = "0x4000B07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool GenerateUVs;

		[Token(Token = "0x4000B08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		public bool Invert;

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x862E18", Offset = "0x862E18", VA = "0x862E18", Slot = "4")]
		public override void CreateMesh()
		{
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x862E64", Offset = "0x862E64", VA = "0x862E64")]
		public Cone()
		{
		}
	}
	[Token(Token = "0x20001D4")]
	public class Cylinder : PrimitiveBase
	{
		[Token(Token = "0x4000B09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Radius;

		[Token(Token = "0x4000B0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float Height;

		[Token(Token = "0x4000B0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int Sides;

		[Token(Token = "0x4000B0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool GenerateCaps;

		[Token(Token = "0x4000B0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool GenerateNormals;

		[Token(Token = "0x4000B0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
		public bool GenerateUVs;

		[Token(Token = "0x4000B0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F")]
		public bool Invert;

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x8659E8", Offset = "0x8659E8", VA = "0x8659E8", Slot = "4")]
		public override void CreateMesh()
		{
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x865A30", Offset = "0x865A30", VA = "0x865A30")]
		public Cylinder()
		{
		}
	}
	[Token(Token = "0x20001D5")]
	public class Disk : PrimitiveBase
	{
		[Token(Token = "0x4000B10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MeshGenerator.Directions Direction;

		[Token(Token = "0x4000B11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float Radius;

		[Token(Token = "0x4000B12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int Sides;

		[Token(Token = "0x4000B13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool GenerateNormals;

		[Token(Token = "0x4000B14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool GenerateUVs;

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x868FD4", Offset = "0x868FD4", VA = "0x868FD4", Slot = "4")]
		public override void CreateMesh()
		{
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x869018", Offset = "0x869018", VA = "0x869018")]
		public Disk()
		{
		}
	}
	[Token(Token = "0x20001D6")]
	public class Gengon : PrimitiveBase
	{
		[Token(Token = "0x4000B15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Radius;

		[Token(Token = "0x4000B16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float Height;

		[Token(Token = "0x4000B17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int Sides;

		[Token(Token = "0x4000B18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool GenerateCaps;

		[Token(Token = "0x4000B19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool GenerateNormals;

		[Token(Token = "0x4000B1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
		public bool GenerateUVs;

		[Token(Token = "0x4000B1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F")]
		public bool Invert;

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0xB44FBC", Offset = "0xB44FBC", VA = "0xB44FBC", Slot = "4")]
		public override void CreateMesh()
		{
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0xB45004", Offset = "0xB45004", VA = "0xB45004")]
		public Gengon()
		{
		}
	}
	[Token(Token = "0x20001D7")]
	public class GeoSphere : PrimitiveBase
	{
		[Token(Token = "0x4000B1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Radius;

		[Token(Token = "0x4000B1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x590E60", Offset = "0x590E60")]
		public int Tesselation;

		[Token(Token = "0x4000B1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool GenerateNormals;

		[Token(Token = "0x4000B1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool GenerateUVs;

		[Token(Token = "0x4000B20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool Invert;

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0xB45030", Offset = "0xB45030", VA = "0xB45030", Slot = "4")]
		public override void CreateMesh()
		{
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0xB45188", Offset = "0xB45188", VA = "0xB45188")]
		public GeoSphere()
		{
		}
	}
	[Token(Token = "0x20001D8")]
	public class OutlinedBox : PrimitiveBase
	{
		[Token(Token = "0x4000B21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float SizeX;

		[Token(Token = "0x4000B22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float SizeY;

		[Token(Token = "0x4000B23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float SizeZ;

		[Token(Token = "0x4000B24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float Outline;

		[Token(Token = "0x4000B25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool GenerateNormals;

		[Token(Token = "0x4000B26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool GenerateUVs;

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0xD8B3A0", Offset = "0xD8B3A0", VA = "0xD8B3A0", Slot = "4")]
		public override void CreateMesh()
		{
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0xD8B3E0", Offset = "0xD8B3E0", VA = "0xD8B3E0")]
		public OutlinedBox()
		{
		}
	}
	[Token(Token = "0x20001D9")]
	public class Plane : PrimitiveBase
	{
		[Token(Token = "0x4000B27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MeshGenerator.Directions Direction;

		[Token(Token = "0x4000B28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float Width;

		[Token(Token = "0x4000B29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float Height;

		[Token(Token = "0x4000B2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int WidthSegments;

		[Token(Token = "0x4000B2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int HeightSegments;

		[Token(Token = "0x4000B2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool GenerateNormals;

		[Token(Token = "0x4000B2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		public bool GenerateUVs;

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x849270", Offset = "0x849270", VA = "0x849270", Slot = "4")]
		public override void CreateMesh()
		{
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x8492B4", Offset = "0x8492B4", VA = "0x8492B4")]
		public Plane()
		{
		}
	}
	[Token(Token = "0x20001DA")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x58E544", Offset = "0x58E544")]
	[ExecuteInEditMode]
	public abstract class PrimitiveBase : MonoBehaviour
	{
		[Token(Token = "0x4000B2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mesh GeneratedMesh;

		[Token(Token = "0x6000A28")]
		public abstract void CreateMesh();

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x84BCC4", Offset = "0x84BCC4", VA = "0x84BCC4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x8492DC", Offset = "0x8492DC", VA = "0x8492DC")]
		protected PrimitiveBase()
		{
		}
	}
	[Token(Token = "0x20001DB")]
	public class Quad : PrimitiveBase
	{
		[Token(Token = "0x4000B2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MeshGenerator.Directions Direction;

		[Token(Token = "0x4000B30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float Width;

		[Token(Token = "0x4000B31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float Height;

		[Token(Token = "0x4000B32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool GenerateNormals;

		[Token(Token = "0x4000B33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool GenerateUVs;

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x84C000", Offset = "0x84C000", VA = "0x84C000", Slot = "4")]
		public override void CreateMesh()
		{
		}

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x84C040", Offset = "0x84C040", VA = "0x84C040")]
		public Quad()
		{
		}
	}
	[Token(Token = "0x20001DC")]
	public class Sphere : PrimitiveBase
	{
		[Token(Token = "0x4000B34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Radius;

		[Token(Token = "0x4000B35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int Tesselation;

		[Token(Token = "0x4000B36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x590E78", Offset = "0x590E78")]
		public float SlicesMaxAngle;

		[Token(Token = "0x4000B37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x590E94", Offset = "0x590E94")]
		public float StacksMaxAngle;

		[Token(Token = "0x4000B38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool GenerateNormals;

		[Token(Token = "0x4000B39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool GenerateUVs;

		[Token(Token = "0x4000B3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool Invert;

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0xB00FFC", Offset = "0xB00FFC", VA = "0xB00FFC", Slot = "4")]
		public override void CreateMesh()
		{
		}

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0xB01048", Offset = "0xB01048", VA = "0xB01048")]
		public Sphere()
		{
		}
	}
	[Token(Token = "0x20001DD")]
	public class Teapot : PrimitiveBase
	{
		[Token(Token = "0x4000B3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Size;

		[Token(Token = "0x4000B3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int Tesselation;

		[Token(Token = "0x4000B3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool Spoute;

		[Token(Token = "0x4000B3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool Handle;

		[Token(Token = "0x4000B3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool Lid;

		[Token(Token = "0x4000B40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		public bool GenerateNormals;

		[Token(Token = "0x4000B41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool GenerateUVs;

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0xB06B3C", Offset = "0xB06B3C", VA = "0xB06B3C", Slot = "4")]
		public override void CreateMesh()
		{
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0xB0704C", Offset = "0xB0704C", VA = "0xB0704C")]
		public Teapot()
		{
		}
	}
	[Token(Token = "0x20001DE")]
	public class Torus : PrimitiveBase
	{
		[Token(Token = "0x4000B42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Radius;

		[Token(Token = "0x4000B43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float Thickness;

		[Token(Token = "0x4000B44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int Tessellation;

		[Token(Token = "0x4000B45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool GenerateNormals;

		[Token(Token = "0x4000B46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool GenerateUVs;

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0xB0BEC4", Offset = "0xB0BEC4", VA = "0xB0BEC4", Slot = "4")]
		public override void CreateMesh()
		{
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0xB0BF08", Offset = "0xB0BF08", VA = "0xB0BF08")]
		public Torus()
		{
		}
	}
	[Token(Token = "0x20001DF")]
	public class Tube : PrimitiveBase
	{
		[Token(Token = "0x4000B47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float OuterRadius;

		[Token(Token = "0x4000B48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float InnerRadius;

		[Token(Token = "0x4000B49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float Height;

		[Token(Token = "0x4000B4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int Sides;

		[Token(Token = "0x4000B4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool GenerateNormals;

		[Token(Token = "0x4000B4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool GenerateUVs;

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0xB0F4A8", Offset = "0xB0F4A8", VA = "0xB0F4A8", Slot = "4")]
		public override void CreateMesh()
		{
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0xB0F4EC", Offset = "0xB0F4EC", VA = "0xB0F4EC")]
		public Tube()
		{
		}
	}
	[Token(Token = "0x20001E0")]
	public class WireBox : PrimitiveBase
	{
		[Token(Token = "0x4000B4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float SizeX;

		[Token(Token = "0x4000B4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float SizeY;

		[Token(Token = "0x4000B4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float SizeZ;

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0xB105FC", Offset = "0xB105FC", VA = "0xB105FC", Slot = "4")]
		public override void CreateMesh()
		{
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0xB10634", Offset = "0xB10634", VA = "0xB10634")]
		public WireBox()
		{
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x20001E1")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x20001E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E5F4", Offset = "0x58E5F4")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000B50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000A39")]
			[Address(RVA = "0xF373F8", Offset = "0xF373F8", VA = "0xF373F8")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0xF37400", Offset = "0xF37400", VA = "0xF37400")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20001E3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58E604", Offset = "0x58E604")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000B51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000B52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0xF372D4", Offset = "0xF372D4", VA = "0xF372D4")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0xF372DC", Offset = "0xF372DC", VA = "0xF372DC")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0xF372F8", Offset = "0xF372F8", VA = "0xF372F8")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x865A5C", Offset = "0x865A5C", VA = "0x865A5C")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x865C4C", Offset = "0x865C4C", VA = "0x865C4C")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x20001E4")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x20001E5")]
		public static class Physics
		{
			[Token(Token = "0x6000A40")]
			[Address(RVA = "0xF3741C", Offset = "0xF3741C", VA = "0xF3741C")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x6000A41")]
			[Address(RVA = "0xF37520", Offset = "0xF37520", VA = "0xF37520")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A42")]
			[Address(RVA = "0xF375B8", Offset = "0xF375B8", VA = "0xF375B8")]
			[Preserve]
			public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x4000B53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x865E5C", Offset = "0x865E5C", VA = "0x865E5C")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x865F20", Offset = "0x865F20", VA = "0x865F20")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
}
