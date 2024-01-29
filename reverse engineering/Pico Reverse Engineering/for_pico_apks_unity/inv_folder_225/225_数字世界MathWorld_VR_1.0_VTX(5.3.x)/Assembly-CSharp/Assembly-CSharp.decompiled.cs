using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Autohand;
using Autohand.Demo;
using BasketballMinigame;
using Il2CppDummyDll;
using MirzaBeig.Scripting.Effects;
using NaughtyAttributes;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityStandardAssets.Utility;

[assembly: AssemblyVersion("0.0.0.0")]
[Serializable]
[Token(Token = "0x2000002")]
public struct DeviceData
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string[] deviceNames;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public Vector3 position;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Vector3 rotation;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x8E0980", Offset = "0x8E0980", VA = "0x8E0980")]
	public DeviceData(string name, Vector3 pos, Vector3 rot)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x8E0A70", Offset = "0x8E0A70", VA = "0x8E0A70")]
	public DeviceData(string[] names, Vector3 pos, Vector3 rot)
	{
	}
}
[Token(Token = "0x2000003")]
public class XRHandOffset : MonoBehaviour
{
	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("DO NOT CHANGE THIS UNLESS YOU ARE REDOING THE RELATIVE POSITIONS. This is the device that you are using to setup the innital proper orientation of the hand, all offsets are relative to this device")]
	public string defaultDevice;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public Transform[] rightOffsets;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public Transform[] leftOffsets;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public DeviceData[] devices;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool offsetDone;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool hasProvider;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x8E0AC4", Offset = "0x8E0AC4", VA = "0x8E0AC4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x8E0F0C", Offset = "0x8E0F0C", VA = "0x8E0F0C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x8E0FA0", Offset = "0x8E0FA0", VA = "0x8E0FA0")]
	internal void AdjustPositions(XRHandOffset otherOffset)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x8E0CA0", Offset = "0x8E0CA0", VA = "0x8E0CA0")]
	private void DeviceConnected(InputDevice inputDevice)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x8E139C", Offset = "0x8E139C", VA = "0x8E139C")]
	private Vector3 GetPositionOffset(string from, string to)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x8E1564", Offset = "0x8E1564", VA = "0x8E1564")]
	private Vector3 GetRotationOffset(string from, string to)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x8E1154", Offset = "0x8E1154", VA = "0x8E1154")]
	protected Vector3 GetDefaultPositionOffset()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x8E1278", Offset = "0x8E1278", VA = "0x8E1278")]
	protected Vector3 GetDefaultRotationOffset()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x8E172C", Offset = "0x8E172C", VA = "0x8E172C")]
	public XRHandOffset()
	{
	}
}
[Token(Token = "0x2000004")]
public class BowlingManager : MonoBehaviour
{
	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Bowling Ball Settings")]
	public GameObject bowlingBall;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("Bowling Pin Settings")]
	public Vector3 pinCenter;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float pinSpaceX;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float pinSpaceZ;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<GameObject> pins;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector3 ballPosition;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x8E1AFC", Offset = "0x8E1AFC", VA = "0x8E1AFC")]
	private void Start()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x8E1D34", Offset = "0x8E1D34", VA = "0x8E1D34")]
	public void ResetBall()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x8E1B38", Offset = "0x8E1B38", VA = "0x8E1B38")]
	public void ResetPins()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x8E1DD8", Offset = "0x8E1DD8", VA = "0x8E1DD8")]
	public BowlingManager()
	{
	}
}
[Token(Token = "0x2000005")]
public class DemoExitCondition : MonoBehaviour
{
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x8E1E60", Offset = "0x8E1E60", VA = "0x8E1E60")]
	private void Update()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x8E1EF8", Offset = "0x8E1EF8", VA = "0x8E1EF8")]
	public DemoExitCondition()
	{
	}
}
[Token(Token = "0x2000006")]
public class OpenLink : MonoBehaviour
{
	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string URL;

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x8E1F00", Offset = "0x8E1F00", VA = "0x8E1F00")]
	public void OpenLinkURL()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x8E1F0C", Offset = "0x8E1F0C", VA = "0x8E1F0C")]
	public OpenLink()
	{
	}
}
[Token(Token = "0x2000007")]
public class PlatformMover : MonoBehaviour
{
	[Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class <Move>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlatformMover <>4__this;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timePassed>5__2;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x8E2270", Offset = "0x8E2270", VA = "0x8E2270", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x8E22B8", Offset = "0x8E22B8", VA = "0x8E22B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x8E1FCC", Offset = "0x8E1FCC", VA = "0x8E1FCC")]
		[DebuggerHidden]
		public <Move>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x8E2004", Offset = "0x8E2004", VA = "0x8E2004", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x8E2008", Offset = "0x8E2008", VA = "0x8E2008", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x8E2278", Offset = "0x8E2278", VA = "0x8E2278", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 toRange;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float time;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 startPos;

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x8E1F14", Offset = "0x8E1F14", VA = "0x8E1F14")]
	private void Start()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x8E1F58", Offset = "0x8E1F58", VA = "0x8E1F58")]
	[IteratorStateMachine(typeof(<Move>d__4))]
	private IEnumerator Move()
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x8E1FF4", Offset = "0x8E1FF4", VA = "0x8E1FF4")]
	public PlatformMover()
	{
	}
}
[Token(Token = "0x2000009")]
public class UnlockChest : MonoBehaviour
{
	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public HingeJoint joint;

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x8E22C0", Offset = "0x8E22C0", VA = "0x8E22C0")]
	public void Unlock()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x8E2418", Offset = "0x8E2418", VA = "0x8E2418")]
	public void Lock()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x8E254C", Offset = "0x8E254C", VA = "0x8E254C")]
	public UnlockChest()
	{
	}
}
[Token(Token = "0x200000A")]
public class TextFieldInspector : MonoBehaviour
{
	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[TextArea]
	public string text;

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x8E2554", Offset = "0x8E2554", VA = "0x8E2554")]
	public TextFieldInspector()
	{
	}
}
[Token(Token = "0x200000B")]
public class TextInformation : MonoBehaviour
{
	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject activateImage;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject deactivateImage;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject[] texts;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool active;

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x8E255C", Offset = "0x8E255C", VA = "0x8E255C")]
	public void ActivateText()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x8E25F0", Offset = "0x8E25F0", VA = "0x8E25F0")]
	public void DeactivateText()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x8E2680", Offset = "0x8E2680", VA = "0x8E2680")]
	public void ToggleText()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x8E2690", Offset = "0x8E2690", VA = "0x8E2690")]
	public TextInformation()
	{
	}
}
[Token(Token = "0x200000C")]
public class TMPSizeProtector : MonoBehaviour
{
	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float size;

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x8E2698", Offset = "0x8E2698", VA = "0x8E2698")]
	private void Start()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x8E2758", Offset = "0x8E2758", VA = "0x8E2758")]
	public TMPSizeProtector()
	{
	}
}
[Token(Token = "0x200000D")]
public static class JointExtensions
{
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x8E2760", Offset = "0x8E2760", VA = "0x8E2760")]
	public static Vector3 Angles(this ConfigurableJoint joint)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x200000E")]
[DefaultExecutionOrder(-100000)]
public class IgnoreHandLayer : MonoBehaviour
{
	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool includeChildren;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int startLayer;

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x8E2B7C", Offset = "0x8E2B7C", VA = "0x8E2B7C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x8E2BF0", Offset = "0x8E2BF0", VA = "0x8E2BF0")]
	private void LateStart()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x8E2C50", Offset = "0x8E2C50", VA = "0x8E2C50")]
	internal void SetLayerRecursive(Transform obj, int newLayer)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x8E2CEC", Offset = "0x8E2CEC", VA = "0x8E2CEC")]
	public IgnoreHandLayer()
	{
	}
}
[Token(Token = "0x200000F")]
public class HeadCameraSmoothing : MonoBehaviour
{
	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 lastPos;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Quaternion lastRot;

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x8E2CFC", Offset = "0x8E2CFC", VA = "0x8E2CFC")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x8E2D4C", Offset = "0x8E2D4C", VA = "0x8E2D4C")]
	public HeadCameraSmoothing()
	{
	}
}
[Token(Token = "0x2000010")]
public class HandEventTemplate : MonoBehaviour
{
	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Autohand.Hand hand;

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x8E2D54", Offset = "0x8E2D54", VA = "0x8E2D54")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x8E3270", Offset = "0x8E3270", VA = "0x8E3270")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x8E378C", Offset = "0x8E378C", VA = "0x8E378C")]
	private void OnBeforeGrabbed(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x8E3790", Offset = "0x8E3790", VA = "0x8E3790")]
	private void OnGrabbed(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x8E3794", Offset = "0x8E3794", VA = "0x8E3794")]
	private void OnBeforeReleased(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x8E3798", Offset = "0x8E3798", VA = "0x8E3798")]
	private void OnReleased(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x8E379C", Offset = "0x8E379C", VA = "0x8E379C")]
	private void OnForcedRelease(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x8E37A0", Offset = "0x8E37A0", VA = "0x8E37A0")]
	private void OnGrabJointBreak(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x8E37A4", Offset = "0x8E37A4", VA = "0x8E37A4")]
	private void OnHighlight(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x8E37A8", Offset = "0x8E37A8", VA = "0x8E37A8")]
	private void OnStopHighlight(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x8E37AC", Offset = "0x8E37AC", VA = "0x8E37AC")]
	private void OnSqueezed(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x8E37B0", Offset = "0x8E37B0", VA = "0x8E37B0")]
	private void OnUnsqueezed(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x8E37B4", Offset = "0x8E37B4", VA = "0x8E37B4")]
	private void OnTriggerGrab(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x8E37B8", Offset = "0x8E37B8", VA = "0x8E37B8")]
	private void OnTriggerRelease(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x8E37BC", Offset = "0x8E37BC", VA = "0x8E37BC")]
	private void OnHandCollisionStart(Autohand.Hand hand, GameObject other)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x8E37C0", Offset = "0x8E37C0", VA = "0x8E37C0")]
	private void OnHandCollisionStop(Autohand.Hand hand, GameObject other)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x8E37C4", Offset = "0x8E37C4", VA = "0x8E37C4")]
	private void OnHandTriggerStart(Autohand.Hand hand, GameObject other)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x8E37C8", Offset = "0x8E37C8", VA = "0x8E37C8")]
	private void OnHandTriggerStop(Autohand.Hand hand, GameObject other)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x8E37CC", Offset = "0x8E37CC", VA = "0x8E37CC")]
	public HandEventTemplate()
	{
	}
}
[Token(Token = "0x2000011")]
[RequireComponent(typeof(PlacePoint))]
public class PlacePointEventDebugger : MonoBehaviour
{
	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private PlacePoint placePoint;

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x8E37D4", Offset = "0x8E37D4", VA = "0x8E37D4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x8E3BCC", Offset = "0x8E3BCC", VA = "0x8E3BCC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x8E3FC4", Offset = "0x8E3FC4", VA = "0x8E3FC4")]
	public PlacePointEventDebugger()
	{
	}
}
[Token(Token = "0x2000013")]
public class PlacePointEventTemplate : MonoBehaviour
{
	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PlacePoint placePoint;

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x8E4384", Offset = "0x8E4384", VA = "0x8E4384")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x8E45F4", Offset = "0x8E45F4", VA = "0x8E45F4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x8E4864", Offset = "0x8E4864", VA = "0x8E4864")]
	public void OnPlace(PlacePoint point, Grabbable grab)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x8E4868", Offset = "0x8E4868", VA = "0x8E4868")]
	public void OnRemove(PlacePoint point, Grabbable grab)
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x8E486C", Offset = "0x8E486C", VA = "0x8E486C")]
	public void OnHighlight(PlacePoint point, Grabbable grab)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x8E4870", Offset = "0x8E4870", VA = "0x8E4870")]
	public void OnStopHighlight(PlacePoint point, Grabbable grab)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x8E4874", Offset = "0x8E4874", VA = "0x8E4874")]
	public PlacePointEventTemplate()
	{
	}
}
[Token(Token = "0x2000014")]
public class AutoHandSettings : ScriptableObject
{
	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Whether the popup should be ignored on launch or not")]
	public bool ignoreSetup;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Tooltip("-1 is custom, 0 is low, 1 is medium, 2 is high")]
	public float quality;

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x8E487C", Offset = "0x8E487C", VA = "0x8E487C")]
	public static void ClearSettings()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x8E48EC", Offset = "0x8E48EC", VA = "0x8E48EC")]
	public AutoHandSettings()
	{
	}
}
[Token(Token = "0x2000015")]
public class CollisionIgnores : MonoBehaviour
{
	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool disableOnStart;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Collider[] cols1;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Collider[] cols2;

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x8E48FC", Offset = "0x8E48FC", VA = "0x8E48FC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x8E49A4", Offset = "0x8E49A4", VA = "0x8E49A4")]
	public void EnableCollisions()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x8E4900", Offset = "0x8E4900", VA = "0x8E4900")]
	public void DisableCollisions()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x8E4A48", Offset = "0x8E4A48", VA = "0x8E4A48")]
	public CollisionIgnores()
	{
	}
}
[Token(Token = "0x2000016")]
[RequireComponent(typeof(Rigidbody))]
public class CollisionSound : MonoBehaviour
{
	[Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class <SoundPlayBuffer>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CollisionSound <>4__this;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x8E50A0", Offset = "0x8E50A0", VA = "0x8E50A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x8E50E8", Offset = "0x8E50E8", VA = "0x8E50E8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x8E4F0C", Offset = "0x8E4F0C", VA = "0x8E4F0C")]
		[DebuggerHidden]
		public <SoundPlayBuffer>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x8E4FCC", Offset = "0x8E4FCC", VA = "0x8E4FCC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x8E4FD0", Offset = "0x8E4FD0", VA = "0x8E4FD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x8E50A8", Offset = "0x8E50A8", VA = "0x8E50A8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class <SoundPlayBuffer>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CollisionSound <>4__this;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float time;

		[Token(Token = "0x17000005")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x8E51C4", Offset = "0x8E51C4", VA = "0x8E51C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x8E520C", Offset = "0x8E520C", VA = "0x8E520C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x8E4F34", Offset = "0x8E4F34", VA = "0x8E4F34")]
		[DebuggerHidden]
		public <SoundPlayBuffer>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x8E50F0", Offset = "0x8E50F0", VA = "0x8E50F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x8E50F4", Offset = "0x8E50F4", VA = "0x8E50F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x8E51CC", Offset = "0x8E51CC", VA = "0x8E51CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("The layers that cause the sound to play")]
	public LayerMask collisionTriggers;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("Source to play sound from")]
	public AudioSource source;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("Source to play sound from")]
	public AudioClip clip;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Source to play sound from")]
	[Space]
	public AnimationCurve velocityVolumeCurve;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float volumeAmp;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float velocityAmp;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float soundRepeatDelay;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Rigidbody body;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool canPlaySound;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Coroutine playSoundRoutine;

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x8E4A58", Offset = "0x8E4A58", VA = "0x8E4A58")]
	private void Start()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x8E4B50", Offset = "0x8E4B50", VA = "0x8E4B50")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x8E4B64", Offset = "0x8E4B64", VA = "0x8E4B64")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x8E4E98", Offset = "0x8E4E98", VA = "0x8E4E98")]
	[IteratorStateMachine(typeof(<SoundPlayBuffer>d__13))]
	private IEnumerator SoundPlayBuffer()
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x8E4ACC", Offset = "0x8E4ACC", VA = "0x8E4ACC")]
	[IteratorStateMachine(typeof(<SoundPlayBuffer>d__14))]
	private IEnumerator SoundPlayBuffer(float time)
	{
		return null;
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x8E4F5C", Offset = "0x8E4F5C", VA = "0x8E4F5C")]
	public CollisionSound()
	{
	}
}
[Token(Token = "0x2000019")]
public class ETFXProjectileScript : MonoBehaviour
{
	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject impactParticle;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject projectileParticle;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject muzzleParticle;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Header("Adjust if not using Sphere Collider")]
	public float colliderRadius;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Range(0f, 1f)]
	public float collideOffset;

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x8E5214", Offset = "0x8E5214", VA = "0x8E5214")]
	private void Start()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x8E543C", Offset = "0x8E543C", VA = "0x8E543C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x8E5A84", Offset = "0x8E5A84", VA = "0x8E5A84")]
	public ETFXProjectileScript()
	{
	}
}
[Token(Token = "0x200001A")]
public class ETFXSceneManager : MonoBehaviour
{
	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool GUIHide;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool GUIHide2;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool GUIHide3;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool GUIHide4;

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x8E5A98", Offset = "0x8E5A98", VA = "0x8E5A98")]
	public void LoadScene2DDemo()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x8E5B00", Offset = "0x8E5B00", VA = "0x8E5B00")]
	public void LoadSceneCards()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x8E5B68", Offset = "0x8E5B68", VA = "0x8E5B68")]
	public void LoadSceneCombat()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x8E5BD0", Offset = "0x8E5BD0", VA = "0x8E5BD0")]
	public void LoadSceneDecals()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x8E5C38", Offset = "0x8E5C38", VA = "0x8E5C38")]
	public void LoadSceneDecals2()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x8E5CA0", Offset = "0x8E5CA0", VA = "0x8E5CA0")]
	public void LoadSceneEmojis()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x8E5D08", Offset = "0x8E5D08", VA = "0x8E5D08")]
	public void LoadSceneEmojis2()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x8E5D70", Offset = "0x8E5D70", VA = "0x8E5D70")]
	public void LoadSceneExplosions()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x8E5DD8", Offset = "0x8E5DD8", VA = "0x8E5DD8")]
	public void LoadSceneExplosions2()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x8E5E40", Offset = "0x8E5E40", VA = "0x8E5E40")]
	public void LoadSceneFire()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x8E5EA8", Offset = "0x8E5EA8", VA = "0x8E5EA8")]
	public void LoadSceneFire2()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x8E5F10", Offset = "0x8E5F10", VA = "0x8E5F10")]
	public void LoadSceneFire3()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x8E5F78", Offset = "0x8E5F78", VA = "0x8E5F78")]
	public void LoadSceneFireworks()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x8E5FE0", Offset = "0x8E5FE0", VA = "0x8E5FE0")]
	public void LoadSceneFlares()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x8E6048", Offset = "0x8E6048", VA = "0x8E6048")]
	public void LoadSceneMagic()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x8E60B0", Offset = "0x8E60B0", VA = "0x8E60B0")]
	public void LoadSceneMagic2()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x8E6118", Offset = "0x8E6118", VA = "0x8E6118")]
	public void LoadSceneMagic3()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x8E6180", Offset = "0x8E6180", VA = "0x8E6180")]
	public void LoadSceneMainDemo()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x8E61E8", Offset = "0x8E61E8", VA = "0x8E61E8")]
	public void LoadSceneMissiles()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x8E6250", Offset = "0x8E6250", VA = "0x8E6250")]
	public void LoadScenePortals()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x8E62B8", Offset = "0x8E62B8", VA = "0x8E62B8")]
	public void LoadScenePortals2()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x8E6320", Offset = "0x8E6320", VA = "0x8E6320")]
	public void LoadScenePowerups()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x8E6388", Offset = "0x8E6388", VA = "0x8E6388")]
	public void LoadScenePowerups2()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x8E63F0", Offset = "0x8E63F0", VA = "0x8E63F0")]
	public void LoadSceneSparkles()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x8E6458", Offset = "0x8E6458", VA = "0x8E6458")]
	public void LoadSceneSwordCombat()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x8E64C0", Offset = "0x8E64C0", VA = "0x8E64C0")]
	public void LoadSceneSwordCombat2()
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x8E6528", Offset = "0x8E6528", VA = "0x8E6528")]
	public void LoadSceneMoney()
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x8E6590", Offset = "0x8E6590", VA = "0x8E6590")]
	public void LoadSceneHealing()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x8E65F8", Offset = "0x8E65F8", VA = "0x8E65F8")]
	public void LoadSceneWind()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x8E6660", Offset = "0x8E6660", VA = "0x8E6660")]
	private void Update()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x8E6820", Offset = "0x8E6820", VA = "0x8E6820")]
	public ETFXSceneManager()
	{
	}
}
[Token(Token = "0x200001B")]
public class ParticleEffectsLibrary : MonoBehaviour
{
	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ParticleEffectsLibrary GlobalAccess;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int TotalEffects;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int CurrentParticleEffectIndex;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int CurrentParticleEffectNum;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3[] ParticleEffectSpawnOffsets;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float[] ParticleEffectLifetimes;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject[] ParticleEffectPrefabs;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string effectNameString;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<Transform> currentActivePEList;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 spawnPosition;

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x8E6828", Offset = "0x8E6828", VA = "0x8E6828")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x8E6BF8", Offset = "0x8E6BF8", VA = "0x8E6BF8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x8E6BFC", Offset = "0x8E6BFC", VA = "0x8E6BFC")]
	public string GetCurrentPENameString()
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x8E6E70", Offset = "0x8E6E70", VA = "0x8E6E70")]
	public void PreviousParticleEffect()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x8E724C", Offset = "0x8E724C", VA = "0x8E724C")]
	public void NextParticleEffect()
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x8E7638", Offset = "0x8E7638", VA = "0x8E7638")]
	public void SpawnParticleEffect(Vector3 positionInWorldToSpawn)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x8E797C", Offset = "0x8E797C", VA = "0x8E797C")]
	public ParticleEffectsLibrary()
	{
	}
}
[Token(Token = "0x200001C")]
public enum ButtonTypes
{
	[Token(Token = "0x4000059")]
	NotDefined,
	[Token(Token = "0x400005A")]
	Previous,
	[Token(Token = "0x400005B")]
	Next
}
[Token(Token = "0x200001D")]
public class PEButtonScript : MonoBehaviour, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
{
	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Button myButton;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ButtonTypes ButtonType;

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x8E7A14", Offset = "0x8E7A14", VA = "0x8E7A14")]
	private void Start()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x8E7A7C", Offset = "0x8E7A7C", VA = "0x8E7A7C", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x8E7BC4", Offset = "0x8E7BC4", VA = "0x8E7BC4", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x8E7CBC", Offset = "0x8E7CBC", VA = "0x8E7CBC")]
	public void OnButtonClicked()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x8E7D30", Offset = "0x8E7D30", VA = "0x8E7D30")]
	public PEButtonScript()
	{
	}
}
[Token(Token = "0x200001E")]
public class UICanvasManager : MonoBehaviour
{
	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static UICanvasManager GlobalAccess;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool MouseOverButton;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text PENameText;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text ToolTipText;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RaycastHit rayHit;

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x8E7D38", Offset = "0x8E7D38", VA = "0x8E7D38")]
	private void Awake()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x8E7D90", Offset = "0x8E7D90", VA = "0x8E7D90")]
	private void Start()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x8E7E4C", Offset = "0x8E7E4C", VA = "0x8E7E4C")]
	private void Update()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x8E7ADC", Offset = "0x8E7ADC", VA = "0x8E7ADC")]
	public void UpdateToolTip(ButtonTypes toolTipType)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x8E7C18", Offset = "0x8E7C18", VA = "0x8E7C18")]
	public void ClearToolTip()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x8E7F70", Offset = "0x8E7F70", VA = "0x8E7F70")]
	private void SelectPreviousPE()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x8E8040", Offset = "0x8E8040", VA = "0x8E8040")]
	private void SelectNextPE()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x8E7EB0", Offset = "0x8E7EB0", VA = "0x8E7EB0")]
	private void SpawnCurrentParticleEffect()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x8E7D14", Offset = "0x8E7D14", VA = "0x8E7D14")]
	public void UIButtonClick(ButtonTypes buttonTypeClicked)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x8E8110", Offset = "0x8E8110", VA = "0x8E8110")]
	public UICanvasManager()
	{
	}
}
[Token(Token = "0x200001F")]
[HelpURL("https://makaka.org/unity-assets")]
public class BasketballAudioControl : MonoBehaviour
{
	[Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class <PlayGoalNormalCoroutine>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BasketballAudioControl <>4__this;

		[Token(Token = "0x17000007")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x8E86E8", Offset = "0x8E86E8", VA = "0x8E86E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x8E8730", Offset = "0x8E8730", VA = "0x8E8730", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x8E8204", Offset = "0x8E8204", VA = "0x8E8204")]
		[DebuggerHidden]
		public <PlayGoalNormalCoroutine>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x8E8618", Offset = "0x8E8618", VA = "0x8E8618", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x8E861C", Offset = "0x8E861C", VA = "0x8E861C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x8E86F0", Offset = "0x8E86F0", VA = "0x8E86F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class <PlayGoalClearCoroutine>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BasketballAudioControl <>4__this;

		[Token(Token = "0x17000009")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x8E8808", Offset = "0x8E8808", VA = "0x8E8808", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x8E8850", Offset = "0x8E8850", VA = "0x8E8850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x8E82C0", Offset = "0x8E82C0", VA = "0x8E82C0")]
		[DebuggerHidden]
		public <PlayGoalClearCoroutine>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x8E8738", Offset = "0x8E8738", VA = "0x8E8738", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x8E873C", Offset = "0x8E873C", VA = "0x8E873C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x8E8810", Offset = "0x8E8810", VA = "0x8E8810", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class <PlayGoalSetBigRingCoroutine>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BasketballAudioControl <>4__this;

		[Token(Token = "0x1700000B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x8E8928", Offset = "0x8E8928", VA = "0x8E8928", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x8E8970", Offset = "0x8E8970", VA = "0x8E8970", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x8E837C", Offset = "0x8E837C", VA = "0x8E837C")]
		[DebuggerHidden]
		public <PlayGoalSetBigRingCoroutine>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x8E8858", Offset = "0x8E8858", VA = "0x8E8858", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x8E885C", Offset = "0x8E885C", VA = "0x8E885C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x8E8930", Offset = "0x8E8930", VA = "0x8E8930", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class <PlayGoalHoopMovementCoroutine>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BasketballAudioControl <>4__this;

		[Token(Token = "0x1700000D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x8E8A48", Offset = "0x8E8A48", VA = "0x8E8A48", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x8E8A90", Offset = "0x8E8A90", VA = "0x8E8A90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x8E8438", Offset = "0x8E8438", VA = "0x8E8438")]
		[DebuggerHidden]
		public <PlayGoalHoopMovementCoroutine>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x8E8978", Offset = "0x8E8978", VA = "0x8E8978", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x8E897C", Offset = "0x8E897C", VA = "0x8E897C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x8E8A50", Offset = "0x8E8A50", VA = "0x8E8A50", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static BasketballAudioControl Instance;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Header("Goal: Normal")]
	private AudioSource goalNormalAudioSource;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip goalNormal;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float goalNormalDelay;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Header("Goal: Clear")]
	[SerializeField]
	private AudioSource goalClearAudioSource;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AudioClip goalClear;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float goalClearDelay;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Header("Goal: Set Big Ring")]
	[SerializeField]
	private AudioSource goalSetBigRingAudioSource;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AudioClip goalSetBigRing;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float goalSetBigRingDelay;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Header("Goal: Hoop Movement")]
	[SerializeField]
	private AudioSource goalHoopMovementAudioSource;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private AudioClip goalHoopMovement;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private float goalHoopMovementDelay;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[Header("Fail")]
	[SerializeField]
	private AudioSource failAudioSource;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private AudioClip[] failCollisions;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[Header("Pole")]
	public AudioSource poleAudioSource;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public ThrowingObject.AudioData poleCollisions;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[Header("Backboard")]
	public AudioSource backboardAudioSource;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public ThrowingObject.AudioData backboardCollisions;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[Header("Ring")]
	public AudioSource ringAudioSource;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public ThrowingObject.AudioData ringCollisions;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[Header("Net")]
	public AudioSource netAudioSource;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public ThrowingObject.AudioData netCollisions;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[Header("Floor")]
	public AudioSource floorAudioSource;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public ThrowingObject.AudioData floorCollisions;

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x8E8118", Offset = "0x8E8118", VA = "0x8E8118")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x8E8170", Offset = "0x8E8170", VA = "0x8E8170")]
	public void PlayGoalNormal()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x8E8190", Offset = "0x8E8190", VA = "0x8E8190")]
	[IteratorStateMachine(typeof(<PlayGoalNormalCoroutine>d__27))]
	public IEnumerator PlayGoalNormalCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x8E822C", Offset = "0x8E822C", VA = "0x8E822C")]
	public void PlayGoalClear()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x8E824C", Offset = "0x8E824C", VA = "0x8E824C")]
	[IteratorStateMachine(typeof(<PlayGoalClearCoroutine>d__29))]
	public IEnumerator PlayGoalClearCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x8E82E8", Offset = "0x8E82E8", VA = "0x8E82E8")]
	public void PlayGoalSetBigRing()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x8E8308", Offset = "0x8E8308", VA = "0x8E8308")]
	[IteratorStateMachine(typeof(<PlayGoalSetBigRingCoroutine>d__31))]
	public IEnumerator PlayGoalSetBigRingCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x8E83A4", Offset = "0x8E83A4", VA = "0x8E83A4")]
	public void PlayGoalHoopMovement()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x8E83C4", Offset = "0x8E83C4", VA = "0x8E83C4")]
	[IteratorStateMachine(typeof(<PlayGoalHoopMovementCoroutine>d__33))]
	public IEnumerator PlayGoalHoopMovementCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x8E8460", Offset = "0x8E8460", VA = "0x8E8460")]
	public void PlayFail()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x8E84B8", Offset = "0x8E84B8", VA = "0x8E84B8")]
	public BasketballAudioControl()
	{
	}
}
[Token(Token = "0x2000024")]
[HelpURL("https://makaka.org/unity-assets")]
public class BasketballBallControl : MonoBehaviour
{
	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ThrowingObject throwingObject;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SphereCollider sphereCollider;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Material failMaterial;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isFloored;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool isRingTriggerPassed;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	private bool isNetTriggerPassed;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	private bool isFail;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool isGoaled;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	private bool isClear;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Action OnFail;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Action<bool> OnGoal;

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x8E8A98", Offset = "0x8E8A98", VA = "0x8E8A98")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x8E8BBC", Offset = "0x8E8BBC", VA = "0x8E8BBC")]
	public static BasketballBallControl GetComponent(ThrowingObject throwingObject)
	{
		return null;
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x8E8C88", Offset = "0x8E8C88", VA = "0x8E8C88")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x8E8D98", Offset = "0x8E8D98", VA = "0x8E8D98")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x8E90E4", Offset = "0x8E90E4", VA = "0x8E90E4")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x8E92D8", Offset = "0x8E92D8", VA = "0x8E92D8")]
	private void ResetBall()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x8E8D14", Offset = "0x8E8D14", VA = "0x8E8D14")]
	private void SetGoaled()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x8E9050", Offset = "0x8E9050", VA = "0x8E9050")]
	private void SetFailed()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x8E9384", Offset = "0x8E9384", VA = "0x8E9384")]
	public BasketballBallControl()
	{
	}
}
[Token(Token = "0x2000025")]
[HelpURL("https://makaka.org/unity-assets")]
public class BasketballGameControl : MonoBehaviour
{
	[Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class <AnnulSphereCollidersOfCurrentBallForNetCoroutine>d__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ThrowingObject throwingObject;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BasketballGameControl <>4__this;

		[Token(Token = "0x1700000F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x8EA528", Offset = "0x8EA528", VA = "0x8EA528", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x8EA570", Offset = "0x8EA570", VA = "0x8EA570", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x8E9C68", Offset = "0x8E9C68", VA = "0x8E9C68")]
		[DebuggerHidden]
		public <AnnulSphereCollidersOfCurrentBallForNetCoroutine>d__36(int <>1__state)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x8EA3FC", Offset = "0x8EA3FC", VA = "0x8EA3FC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x8EA400", Offset = "0x8EA400", VA = "0x8EA400", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x8EA530", Offset = "0x8EA530", VA = "0x8EA530", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class <SetBigRingCoroutine>d__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BasketballGameControl <>4__this;

		[Token(Token = "0x17000011")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x8EA68C", Offset = "0x8EA68C", VA = "0x8EA68C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x8EA6D4", Offset = "0x8EA6D4", VA = "0x8EA6D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x8EA308", Offset = "0x8EA308", VA = "0x8EA308")]
		[DebuggerHidden]
		public <SetBigRingCoroutine>d__44(int <>1__state)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x8EA578", Offset = "0x8EA578", VA = "0x8EA578", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x8EA57C", Offset = "0x8EA57C", VA = "0x8EA57C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x8EA694", Offset = "0x8EA694", VA = "0x8EA694", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class <SetNormalRingCoroutine>d__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BasketballGameControl <>4__this;

		[Token(Token = "0x17000013")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x8EA7B4", Offset = "0x8EA7B4", VA = "0x8EA7B4", Slot = "4")]
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
			[Address(RVA = "0x8EA7FC", Offset = "0x8EA7FC", VA = "0x8EA7FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x8EA330", Offset = "0x8EA330", VA = "0x8EA330")]
		[DebuggerHidden]
		public <SetNormalRingCoroutine>d__45(int <>1__state)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x8EA6DC", Offset = "0x8EA6DC", VA = "0x8EA6DC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x8EA6E0", Offset = "0x8EA6E0", VA = "0x8EA6E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x8EA7BC", Offset = "0x8EA7BC", VA = "0x8EA7BC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ThrowControl throwControl;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject canvasArrowDirectional;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float timeScale;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int pointsCombo;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Header("Score Controls")]
	private ScoreBestControl scoreBestControl;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private ScoreCurrentControl scoreCurrentControl;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Header("Points")]
	[SerializeField]
	private float pointsGoalNormal;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float pointsGoalClear;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool isPointsComboOn;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	[Header("Points - Distance To Basket")]
	[SerializeField]
	private bool isPointsDistanceToBasketOn;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float pointsDistanceToBasketFactor;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float distanceToBasket;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Header("Clear Ball = Big Ring")]
	private int bigRingComboAimOfGoalsClear;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Tooltip("Must be bigger than Combo Aim")]
	[SerializeField]
	private int bigRingLimitOfGoalsAny;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int bigRingCurrentGoalsAnyCount;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int bigRingComboOfCurrentGoalsClear;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool isBigRing;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Header("Hoop Movement (if Normal Goal & Normal Ring)")]
	[SerializeField]
	private BasketballHoopControl basketballHoopControl;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Transform hoopMovementPivot;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private int hoopMovementComboAimOfGoals;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int hoopMovementComboOfCurrentGoals;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[Header("Popup Texts")]
	[SerializeField]
	private PopupTextControl textPopupScore;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private PopupTextControl textPopupScoreClear;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[Header("Events")]
	[SerializeField]
	private UnityEvent OnUnityStart;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private UnityEvent OnInitialized;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Transform cameraMain;

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x8E938C", Offset = "0x8E938C", VA = "0x8E938C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x8E9398", Offset = "0x8E9398", VA = "0x8E9398")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x8E9568", Offset = "0x8E9568", VA = "0x8E9568")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x8E9738", Offset = "0x8E9738", VA = "0x8E9738")]
	private void Start()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x8E9810", Offset = "0x8E9810", VA = "0x8E9810")]
	private void InitGame()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x8E9960", Offset = "0x8E9960", VA = "0x8E9960")]
	public void StartGame()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x8E985C", Offset = "0x8E985C", VA = "0x8E985C")]
	private void InitNetAndDistanceToBasket()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x8E99EC", Offset = "0x8E99EC", VA = "0x8E99EC")]
	private void CalculateDistanceToBasket(ThrowingObject throwingObject)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x8E9AE8", Offset = "0x8E9AE8", VA = "0x8E9AE8")]
	private void RegisterSphereCollidersOfCurrentBallForNet(ThrowingObject throwingObject)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x8E9BA8", Offset = "0x8E9BA8", VA = "0x8E9BA8")]
	private void AnnulSphereCollidersOfCurrentBallForNet(ThrowingObject throwingObject, float delay)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x8E9BC8", Offset = "0x8E9BC8", VA = "0x8E9BC8")]
	[IteratorStateMachine(typeof(<AnnulSphereCollidersOfCurrentBallForNetCoroutine>d__36))]
	private IEnumerator AnnulSphereCollidersOfCurrentBallForNetCoroutine(ThrowingObject throwingObject, float delay)
	{
		return null;
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x8E9C90", Offset = "0x8E9C90", VA = "0x8E9C90")]
	private void Goal(bool isClearBall)
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x8E9F68", Offset = "0x8E9F68", VA = "0x8E9F68")]
	private void Fail()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x8E9F20", Offset = "0x8E9F20", VA = "0x8E9F20")]
	private void AddScore(int value)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x8E9FFC", Offset = "0x8E9FFC", VA = "0x8E9FFC")]
	private void SetHoopMovement(bool value)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x8E9ED0", Offset = "0x8E9ED0", VA = "0x8E9ED0")]
	private void CheckBigRingReset()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x8E9E14", Offset = "0x8E9E14", VA = "0x8E9E14")]
	private void CheckBigRingBonus()
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x8EA0C4", Offset = "0x8EA0C4", VA = "0x8EA0C4")]
	private void ResetBigRing()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x8EA220", Offset = "0x8EA220", VA = "0x8EA220")]
	[IteratorStateMachine(typeof(<SetBigRingCoroutine>d__44))]
	private IEnumerator SetBigRingCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x8EA294", Offset = "0x8EA294", VA = "0x8EA294")]
	[IteratorStateMachine(typeof(<SetNormalRingCoroutine>d__45))]
	private IEnumerator SetNormalRingCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x8EA358", Offset = "0x8EA358", VA = "0x8EA358")]
	public BasketballGameControl()
	{
	}
}
[Token(Token = "0x2000029")]
[HelpURL("https://makaka.org/unity-assets")]
public class BasketballHoopControl : MonoBehaviour
{
	[Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class <RotateAroundCoroutine>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BasketballHoopControl <>4__this;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 rotationalPivot;

		[Token(Token = "0x17000015")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x8EB5C0", Offset = "0x8EB5C0", VA = "0x8EB5C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x8EB608", Offset = "0x8EB608", VA = "0x8EB608", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x8EA89C", Offset = "0x8EA89C", VA = "0x8EA89C")]
		[DebuggerHidden]
		public <RotateAroundCoroutine>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x8EAF50", Offset = "0x8EAF50", VA = "0x8EAF50", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x8EAF54", Offset = "0x8EAF54", VA = "0x8EAF54", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x8EB5C8", Offset = "0x8EB5C8", VA = "0x8EB5C8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private BasketballRingControl basketballRingControl;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private BasketballNetControl basketballNetControl;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject hoop;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject hoopPivot;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Header("Movement")]
	private float movementDelay;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Header("Rotation Around Camera")]
	private float rotationalAngleMin;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float rotationalAngleMax;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Header("Z Changing (Local)")]
	[SerializeField]
	private float positionZStepMin;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float positionZStepMax;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float positionZInit;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float positionZCurrent;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private bool isFirstSetPositionZ;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float rotationalAngleRandom;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool isFirstRotation;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	private bool isRotationAroundCoroutine;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3 vectorDiffHoopAndRotationalPivotInit;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 vectorDiffHoopAndRotationalPivotCurrent;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float angleHoopAndRotationalPivotAbs;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private float angleHoopAndRotationalPivot;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[Header("Testing (Step By Step)")]
	[SerializeField]
	private bool isDelayBeforeZSettingOn;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[SerializeField]
	private float delayBeforeZSetting;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Header("Fading")]
	private MaterialControl backBoardFadingControl;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private MaterialControl poleFadingControl;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private MaterialControl netFadingControl;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private MaterialControl ringHolderFadingControl;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private MaterialControl ringFadingControl;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[Header("Explosion On Fading")]
	[SerializeField]
	private ExplosionControl explosionControlOnFadeOut;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private ExplosionControl explosionControlOnFadeIn;

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x8EA200", Offset = "0x8EA200", VA = "0x8EA200")]
	public void RotateAround(Vector3 rotationalPivot)
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x8EA804", Offset = "0x8EA804", VA = "0x8EA804")]
	[IteratorStateMachine(typeof(<RotateAroundCoroutine>d__29))]
	private IEnumerator RotateAroundCoroutine(Vector3 rotationalPivot)
	{
		return null;
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x8EA8C4", Offset = "0x8EA8C4", VA = "0x8EA8C4")]
	private void SetPositionZ(bool isCancel)
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x8EA934", Offset = "0x8EA934", VA = "0x8EA934")]
	private void RotateAroundBase(Vector3 rotationPivot)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x8E9AC0", Offset = "0x8E9AC0", VA = "0x8E9AC0")]
	public Vector3 GetRingPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x8E9B90", Offset = "0x8E9B90", VA = "0x8E9B90")]
	public void RegisterSphereColliderForNet(SphereCollider sphereCollider)
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x8EA510", Offset = "0x8EA510", VA = "0x8EA510")]
	public void AnnulSphereColliderForNet(SphereCollider sphereCollider)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x8EA674", Offset = "0x8EA674", VA = "0x8EA674")]
	public void SetBigRing()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x8EA79C", Offset = "0x8EA79C", VA = "0x8EA79C")]
	public void SetNormalRing()
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x8EAF20", Offset = "0x8EAF20", VA = "0x8EAF20")]
	public BasketballHoopControl()
	{
	}
}
[Token(Token = "0x200002B")]
[HelpURL("https://makaka.org/unity-assets")]
public class BasketballNetControl : MonoBehaviour
{
	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Cloth cloth;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ClothSphereColliderPair[] clothSphereColliderPairs;

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x8EABA4", Offset = "0x8EABA4", VA = "0x8EABA4")]
	public void RegisterSphereCollider(SphereCollider collider)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x8EACD8", Offset = "0x8EACD8", VA = "0x8EACD8")]
	public void AnnulSphereCollider(SphereCollider collider)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x8EB610", Offset = "0x8EB610", VA = "0x8EB610")]
	public BasketballNetControl()
	{
	}
}
[Token(Token = "0x200002C")]
[HelpURL("https://makaka.org/unity-assets")]
public class BasketballRingControl : MonoBehaviour
{
	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Vector3 localScaleOnBigSize;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 localPositionAtStart;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Vector3 localPositionOnBigSize;

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x8EB674", Offset = "0x8EB674", VA = "0x8EB674")]
	private void Awake()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x8EADD8", Offset = "0x8EADD8", VA = "0x8EADD8")]
	public void SetBigSize()
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x8EAE5C", Offset = "0x8EAE5C", VA = "0x8EAE5C")]
	public void SetNormalSize()
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x8EB6A4", Offset = "0x8EB6A4", VA = "0x8EB6A4")]
	public BasketballRingControl()
	{
	}
}
[Token(Token = "0x200002D")]
public static class BasketballTagControl
{
	[Token(Token = "0x40000DD")]
	public const string Pole = "Pole";

	[Token(Token = "0x40000DE")]
	public const string Backboard = "Backboard";

	[Token(Token = "0x40000DF")]
	public const string Ring = "Ring";

	[Token(Token = "0x40000E0")]
	public const string RingTrigger = "RingTrigger";

	[Token(Token = "0x40000E1")]
	public const string Net = "Net";

	[Token(Token = "0x40000E2")]
	public const string NetTrigger = "NetTrigger";

	[Token(Token = "0x40000E3")]
	public const string FailZone = "FailZone";

	[Token(Token = "0x40000E4")]
	public const string Floor = "Ground";
}
[Token(Token = "0x200002E")]
[HelpURL("https://makaka.org/unity-assets")]
public class ArrowDirectionalControl : MonoBehaviour
{
	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform cameraMain;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform pivot;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Image image;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform target;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 direction;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 directionLocalEulerAngles;

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x8EB6D4", Offset = "0x8EB6D4", VA = "0x8EB6D4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x8EB6F4", Offset = "0x8EB6F4", VA = "0x8EB6F4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x8EB6F8", Offset = "0x8EB6F8", VA = "0x8EB6F8")]
	private void SetArrowDirection()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x8EB838", Offset = "0x8EB838", VA = "0x8EB838")]
	public ArrowDirectionalControl()
	{
	}
}
[Token(Token = "0x200002F")]
public static class DebugPrinter
{
	[Token(Token = "0x6000116")]
	[Address(RVA = "0x8EB850", Offset = "0x8EB850", VA = "0x8EB850")]
	public static void Print(object message)
	{
	}
}
[Token(Token = "0x2000030")]
[HelpURL("https://makaka.org/unity-assets")]
public class MaterialCounter : MonoBehaviour
{
	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string messageByDefault;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private KeyCode keyPrint;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private bool isPrintedOnDestroy;

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x8EB8D0", Offset = "0x8EB8D0", VA = "0x8EB8D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x8EB9C4", Offset = "0x8EB9C4", VA = "0x8EB9C4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x8EBA28", Offset = "0x8EBA28", VA = "0x8EBA28")]
	public static void Print(string messagge)
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x8EB93C", Offset = "0x8EB93C", VA = "0x8EB93C")]
	public static void Print()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x8EBAB0", Offset = "0x8EBAB0", VA = "0x8EBAB0")]
	public static int Count()
	{
		return default(int);
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x8EBB34", Offset = "0x8EBB34", VA = "0x8EBB34")]
	public MaterialCounter()
	{
	}
}
[Token(Token = "0x2000031")]
[HelpURL("https://makaka.org/unity-assets")]
public class NumberDebugger
{
	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private float valuePreviousForDebugFloatAbsChanging;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private int counterForDebugFloatAbsChanging;

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x8EBBB8", Offset = "0x8EBBB8", VA = "0x8EBBB8")]
	public void DebugFloatAbsChanging(float delta, float valueCurrent)
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x8EBE40", Offset = "0x8EBE40", VA = "0x8EBE40")]
	public NumberDebugger()
	{
	}
}
[Token(Token = "0x2000032")]
[HelpURL("https://makaka.org/unity-assets")]
public class OneTimeEventControl : MonoBehaviour
{
	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public KeyCode oneTimeFunctionKey;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UnityEvent OnPressOneTimeFunctionKey;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool isOneTimeFunctionCalled;

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x8EBE48", Offset = "0x8EBE48", VA = "0x8EBE48")]
	private void Update()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x8EBE90", Offset = "0x8EBE90", VA = "0x8EBE90")]
	public OneTimeEventControl()
	{
	}
}
[Token(Token = "0x2000033")]
[HelpURL("https://makaka.org/unity-assets")]
public class ExplosionControl : MonoBehaviour
{
	[Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class <ShowCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ExplosionControl <>4__this;

		[Token(Token = "0x17000017")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x8EC11C", Offset = "0x8EC11C", VA = "0x8EC11C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x8EC164", Offset = "0x8EC164", VA = "0x8EC164", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x8EBF34", Offset = "0x8EBF34", VA = "0x8EBF34")]
		[DebuggerHidden]
		public <ShowCoroutine>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x8EBF6C", Offset = "0x8EBF6C", VA = "0x8EBF6C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x8EBF70", Offset = "0x8EBF70", VA = "0x8EBF70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x8EC124", Offset = "0x8EC124", VA = "0x8EC124", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject explosion;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform pivot;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Header("Delays")]
	private float delayBeforeShowing;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float delayBeforeDisabling;

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x8EBEA0", Offset = "0x8EBEA0", VA = "0x8EBEA0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x8EB4D4", Offset = "0x8EB4D4", VA = "0x8EB4D4")]
	public void Show()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x8EBEC0", Offset = "0x8EBEC0", VA = "0x8EBEC0")]
	[IteratorStateMachine(typeof(<ShowCoroutine>d__6))]
	private IEnumerator ShowCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x8EBF5C", Offset = "0x8EBF5C", VA = "0x8EBF5C")]
	public ExplosionControl()
	{
	}
}
[Token(Token = "0x2000035")]
[HelpURL("https://makaka.org/unity-assets")]
public class BreathControl : MonoBehaviour
{
	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 period;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 amplitude;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 distanceCurrent;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 positionOnStart;

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x8EC16C", Offset = "0x8EC16C", VA = "0x8EC16C")]
	protected void Start()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x8EC19C", Offset = "0x8EC19C", VA = "0x8EC19C")]
	protected void Update()
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x8EC274", Offset = "0x8EC274", VA = "0x8EC274")]
	public BreathControl()
	{
	}
}
[Token(Token = "0x2000036")]
[HelpURL("https://makaka.org/unity-assets")]
public class RotationByKeysControl : MonoBehaviour
{
	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Object for Horizontal Rotation")]
	[Header("Horizontal")]
	public Transform horizontal;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string horizontalAxis;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speedHorizontal;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Object for Vertical Rotation")]
	[Header("Vertical")]
	public Transform vertical;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string verticalAxis;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float speedVertical;

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x8EC294", Offset = "0x8EC294", VA = "0x8EC294")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x8EC32C", Offset = "0x8EC32C", VA = "0x8EC32C")]
	public RotationByKeysControl()
	{
	}
}
[Token(Token = "0x2000037")]
[HelpURL("https://makaka.org/unity-assets")]
public class RotationByMouseControl : MonoBehaviour
{
	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Button")]
	public bool isRotationWithButton;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int button;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("Horizontal")]
	[Tooltip("Object for Horizontal Rotation")]
	public Transform horizontal;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string horizontalAxis;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float speedHorizontal;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("Object for Vertical Rotation")]
	[Header("Vertical")]
	public Transform vertical;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string verticalAxis;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float speedVertical;

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x8EC3C0", Offset = "0x8EC3C0", VA = "0x8EC3C0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x8EC3F4", Offset = "0x8EC3F4", VA = "0x8EC3F4")]
	private void Rotate()
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x8EC48C", Offset = "0x8EC48C", VA = "0x8EC48C")]
	public RotationByMouseControl()
	{
	}
}
[Token(Token = "0x2000038")]
[HelpURL("https://makaka.org/unity-assets")]
public class TranslationByKeysControl : MonoBehaviour
{
	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("X")]
	public Transform xAxis;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string xAxisName;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float xAxisSpeed;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Header("Y (Q & E keys)")]
	public Transform yAxis;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float yAxisSpeed;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Header("Z")]
	public Transform zAxis;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string zAxisName;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float zAxisSpeed;

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x8EC52C", Offset = "0x8EC52C", VA = "0x8EC52C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x8EC54C", Offset = "0x8EC54C", VA = "0x8EC54C")]
	private void TranslateXUpdate()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x8EC654", Offset = "0x8EC654", VA = "0x8EC654")]
	private void TranslateZUpdate()
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x8EC604", Offset = "0x8EC604", VA = "0x8EC604")]
	private void TranslateYUpdate()
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x8EC710", Offset = "0x8EC710", VA = "0x8EC710")]
	private void TranslateYAxis(float speed)
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x8EC7B8", Offset = "0x8EC7B8", VA = "0x8EC7B8")]
	public TranslationByKeysControl()
	{
	}
}
[Token(Token = "0x2000039")]
[HelpURL("https://makaka.org/unity-assets")]
public class PlayerPrefsControl : MonoBehaviour
{
	[Token(Token = "0x600013A")]
	[Address(RVA = "0x8EC850", Offset = "0x8EC850", VA = "0x8EC850")]
	public void DeleteAll()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x8EC858", Offset = "0x8EC858", VA = "0x8EC858")]
	public PlayerPrefsControl()
	{
	}
}
[Token(Token = "0x200003A")]
[HelpURL("https://makaka.org/unity-assets")]
[AddComponentMenu("Makaka Games/Everyday Tools/Random Object Pooler")]
public class RandomObjectPooler : MonoBehaviour
{
	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Range(1f, 30f)]
	public int initPooledAmount;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform poolParent;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Space]
	[SerializeField]
	private bool isDebugLogging;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Space]
	public Transform positionAtInit;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform rotationAtInit;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Header("Single (actual for Testing target prefab; None => Multiple)")]
	public GameObject prefab;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Header("Multiple")]
	public bool areRandomizedObjects;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject[] prefabs;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Header("Events")]
	[Space]
	public UnityEvent OnInitialized;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[HideInInspector]
	public List<GameObject> pooledObjects;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GameObject currentInstantiated;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public List<MonoBehaviour> controlScripts;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private MonoBehaviour controlScriptTempForRegistration;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Type controlScriptType;

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x8EC860", Offset = "0x8EC860", VA = "0x8EC860")]
	private void Start()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x8EC864", Offset = "0x8EC864", VA = "0x8EC864")]
	private void InitAndPopulatePool()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x8ECC24", Offset = "0x8ECC24", VA = "0x8ECC24")]
	public void InitControlScripts(Type type)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x8EC9B0", Offset = "0x8EC9B0", VA = "0x8EC9B0")]
	private GameObject InstantiateObject(int index)
	{
		return null;
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x8ECCBC", Offset = "0x8ECCBC", VA = "0x8ECCBC")]
	public GameObject GetPooledObject()
	{
		return null;
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x8ECE38", Offset = "0x8ECE38", VA = "0x8ECE38")]
	public MonoBehaviour RegisterControlScript(GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x8ED11C", Offset = "0x8ED11C", VA = "0x8ED11C")]
	public RandomObjectPooler()
	{
	}
}
[Token(Token = "0x200003B")]
[AddComponentMenu("Scripts/Makaka Games/Everyday Tools/Scene Control/Loading Animation Control")]
[HelpURL("https://makaka.org/unity-assets")]
public class LoadingAnimationControl : MonoBehaviour
{
	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RectTransform fillAreaTransform;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image fillArea;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Header("Speed")]
	public float rotationSpeed;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float openSpeed;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float closeSpeed;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Header("Size")]
	public float sizeOnTop;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float sizeOnBottom;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float fillAreaCurrentSize;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool isFillAreaOnTop;

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x8ED12C", Offset = "0x8ED12C", VA = "0x8ED12C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x8ED180", Offset = "0x8ED180", VA = "0x8ED180")]
	private void ChangeFillAreaSize()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x8ED21C", Offset = "0x8ED21C", VA = "0x8ED21C")]
	public LoadingAnimationControl()
	{
	}
}
[Token(Token = "0x200003C")]
[AddComponentMenu("Scripts/Makaka Games/Everyday Tools/Scene Control/Load Screen Control")]
[HelpURL("https://makaka.org/unity-assets")]
public class LoadScreenControl : MonoBehaviour
{
	[Token(Token = "0x200003D")]
	public delegate void LoadEvent();

	[Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class <doLoadLevel>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LoadScreenControl <>4__this;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string customLoadScene;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string name;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool manualActivation;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AsyncOperation <async>5__2;

		[Token(Token = "0x1700001A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x8EDE1C", Offset = "0x8EDE1C", VA = "0x8EDE1C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x8EDE64", Offset = "0x8EDE64", VA = "0x8EDE64", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x8ED5E4", Offset = "0x8ED5E4", VA = "0x8ED5E4")]
		[DebuggerHidden]
		public <doLoadLevel>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x8EDA84", Offset = "0x8EDA84", VA = "0x8EDA84", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x8EDA88", Offset = "0x8EDA88", VA = "0x8EDA88", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x8EDE24", Offset = "0x8EDE24", VA = "0x8EDE24", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class <doLoadLevelAddictive>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LoadScreenControl <>4__this;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string name;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AsyncOperation <async>5__2;

		[Token(Token = "0x1700001C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x8EE0CC", Offset = "0x8EE0CC", VA = "0x8EE0CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x8EE114", Offset = "0x8EE114", VA = "0x8EE114", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x8ED948", Offset = "0x8ED948", VA = "0x8ED948")]
		[DebuggerHidden]
		public <doLoadLevelAddictive>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x8EDE6C", Offset = "0x8EDE6C", VA = "0x8EDE6C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x8EDE70", Offset = "0x8EDE70", VA = "0x8EDE70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x8EE0D4", Offset = "0x8EE0D4", VA = "0x8EE0D4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static LoadScreenControl instance;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int Progress;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private bool _activeScene;

	[Token(Token = "0x17000019")]
	public static LoadScreenControl Instance
	{
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x8ED244", Offset = "0x8ED244", VA = "0x8ED244")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000001")]
	public event LoadEvent OnStartWaitingEventToActivateScene
	{
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x8ED4AC", Offset = "0x8ED4AC", VA = "0x8ED4AC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x8ED548", Offset = "0x8ED548", VA = "0x8ED548")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event LoadEvent OnStartLoadEventAddictive
	{
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x8ED6D8", Offset = "0x8ED6D8", VA = "0x8ED6D8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x8ED774", Offset = "0x8ED774", VA = "0x8ED774")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event LoadEvent OnEndLoadEventAddictive
	{
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x8ED810", Offset = "0x8ED810", VA = "0x8ED810")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x8ED8AC", Offset = "0x8ED8AC", VA = "0x8ED8AC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x8ED388", Offset = "0x8ED388", VA = "0x8ED388")]
	public void LoadScene(string levelName, bool manualSceneActivation = false, string customLoadScene = "LoadScreen")
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x8ED494", Offset = "0x8ED494", VA = "0x8ED494")]
	public void LoadLevel(string levelName, string customLoadScene)
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x8ED4A0", Offset = "0x8ED4A0", VA = "0x8ED4A0")]
	public void ActivateScene()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x8ED3DC", Offset = "0x8ED3DC", VA = "0x8ED3DC")]
	[IteratorStateMachine(typeof(<doLoadLevel>d__12))]
	private IEnumerator doLoadLevel(string name, string customLoadScene, bool manualActivation)
	{
		return null;
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x8ED60C", Offset = "0x8ED60C", VA = "0x8ED60C")]
	public void LoadLevelAddictive(string name)
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x8ED648", Offset = "0x8ED648", VA = "0x8ED648")]
	[IteratorStateMachine(typeof(<doLoadLevelAddictive>d__20))]
	private IEnumerator doLoadLevelAddictive(string name)
	{
		return null;
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x8ED970", Offset = "0x8ED970", VA = "0x8ED970")]
	public LoadScreenControl()
	{
	}
}
[Token(Token = "0x2000040")]
[AddComponentMenu("Scripts/Makaka Games/Everyday Tools/Scene Control/Load Screen Progress Control")]
[HelpURL("https://makaka.org/unity-assets")]
public class LoadScreenProgressControl : MonoBehaviour
{
	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Slider slider;

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x8EE11C", Offset = "0x8EE11C", VA = "0x8EE11C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x8EE174", Offset = "0x8EE174", VA = "0x8EE174")]
	private void Update()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x8EE1AC", Offset = "0x8EE1AC", VA = "0x8EE1AC")]
	public LoadScreenProgressControl()
	{
	}
}
[Token(Token = "0x2000041")]
[AddComponentMenu("Scripts/Makaka Games/Everyday Tools/Scene Control/Menu Scene Control")]
[HelpURL("https://makaka.org/unity-assets")]
public class MenuSceneControl : MonoBehaviour
{
	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string nameOfSceneWithLoadScreen;

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x8EE1B4", Offset = "0x8EE1B4", VA = "0x8EE1B4")]
	public void LoadSceneWithScreenOrientationLandscapeLeft(string sceneName)
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x8EE218", Offset = "0x8EE218", VA = "0x8EE218")]
	public void LoadSceneWithScreenOrientationPortrait(string sceneName)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x8EE248", Offset = "0x8EE248", VA = "0x8EE248")]
	public void LoadSceneWithScreenOrientationAuto(string sceneName)
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x8EE1E4", Offset = "0x8EE1E4", VA = "0x8EE1E4")]
	private void LoadScene(string sceneName)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x8EE278", Offset = "0x8EE278", VA = "0x8EE278")]
	public void ReloadCurrentScene()
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x8EE314", Offset = "0x8EE314", VA = "0x8EE314")]
	public void QuitGame()
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x8EE31C", Offset = "0x8EE31C", VA = "0x8EE31C")]
	public void OpenLink(string link = "https://makaka.org/support")
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x8EE328", Offset = "0x8EE328", VA = "0x8EE328")]
	public MenuSceneControl()
	{
	}
}
[Token(Token = "0x2000042")]
public class DontDestroyOnLoadCustom : MonoBehaviour
{
	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool isLoaded;

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x8EE380", Offset = "0x8EE380", VA = "0x8EE380")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x8EE470", Offset = "0x8EE470", VA = "0x8EE470")]
	public DontDestroyOnLoadCustom()
	{
	}
}
[Token(Token = "0x2000043")]
[HelpURL("https://makaka.org/unity-assets")]
public class PopupTextControl : MonoBehaviour
{
	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMeshProUGUI text;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform pivot;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool isFirstEnable;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Color color;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Header("Movement")]
	private float speed;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Header("Rotation")]
	private float rotationSpeed;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private Vector3 rotationStart;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Vector3 rotationFinish;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Header("Fading")]
	private float fadingDelay;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float fadingSpeed;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float timer;

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x8EE478", Offset = "0x8EE478", VA = "0x8EE478")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x8EE538", Offset = "0x8EE538", VA = "0x8EE538")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x8EE57C", Offset = "0x8EE57C", VA = "0x8EE57C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x8E9E70", Offset = "0x8E9E70", VA = "0x8E9E70")]
	public void ResetText()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x8E9EFC", Offset = "0x8E9EFC", VA = "0x8E9EFC")]
	public void SetText(string text)
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x8EE74C", Offset = "0x8EE74C", VA = "0x8EE74C")]
	public PopupTextControl()
	{
	}
}
[Token(Token = "0x2000044")]
public class ScoreBaseControl
{
	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string thousandLiteral;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string millionLiteral;

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x8EE784", Offset = "0x8EE784", VA = "0x8EE784")]
	public static float Truncate(float value, int digits)
	{
		return default(float);
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x8EE80C", Offset = "0x8EE80C", VA = "0x8EE80C")]
	public static string Round(float value, int digits)
	{
		return null;
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x8EE8C0", Offset = "0x8EE8C0", VA = "0x8EE8C0")]
	public ScoreBaseControl()
	{
	}
}
[Token(Token = "0x2000045")]
[HelpURL("https://makaka.org/unity-assets")]
public class ScoreBestControl : MonoBehaviour
{
	[Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class <PlayBestScoreSoundCoroutine>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ScoreBestControl <>4__this;

		[Token(Token = "0x1700001E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x8EED14", Offset = "0x8EED14", VA = "0x8EED14", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x8EED5C", Offset = "0x8EED5C", VA = "0x8EED5C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x8EEB30", Offset = "0x8EEB30", VA = "0x8EEB30")]
		[DebuggerHidden]
		public <PlayBestScoreSoundCoroutine>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x8EEC18", Offset = "0x8EEC18", VA = "0x8EEC18", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x8EEC1C", Offset = "0x8EEC1C", VA = "0x8EEC1C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x8EED1C", Offset = "0x8EED1C", VA = "0x8EED1C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class <PlayBestScoreAnimationCoroutine>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ScoreBestControl <>4__this;

		[Token(Token = "0x17000020")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x8EEE30", Offset = "0x8EEE30", VA = "0x8EEE30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x8EEE78", Offset = "0x8EEE78", VA = "0x8EEE78", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x8EEB58", Offset = "0x8EEB58", VA = "0x8EEB58")]
		[DebuggerHidden]
		public <PlayBestScoreAnimationCoroutine>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x8EED64", Offset = "0x8EED64", VA = "0x8EED64", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x8EED68", Offset = "0x8EED68", VA = "0x8EED68", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x8EEE38", Offset = "0x8EEE38", VA = "0x8EEE38", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMeshProUGUI text;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int value;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string playerPrefsKey;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int valueAtFirstStart;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Header("Animation")]
	private Animator animator;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Range(0f, 20f)]
	private float animationDelay;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string animationTrigger;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Range(0f, 20f)]
	[SerializeField]
	[Header("Audio")]
	private float soundDelay;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private AudioSource audioSource;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private AudioClip[] sounds;

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x8EE964", Offset = "0x8EE964", VA = "0x8EE964")]
	private void Start()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x8EE9A0", Offset = "0x8EE9A0", VA = "0x8EE9A0")]
	private void SetValue(int value)
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x8EE9D8", Offset = "0x8EE9D8", VA = "0x8EE9D8")]
	public int GetValue()
	{
		return default(int);
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x8EE9E0", Offset = "0x8EE9E0", VA = "0x8EE9E0")]
	private void PlayBestScoreSound()
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x8EEA88", Offset = "0x8EEA88", VA = "0x8EEA88")]
	private void PlayBestScoreAnimation()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x8EEA04", Offset = "0x8EEA04", VA = "0x8EEA04")]
	[IteratorStateMachine(typeof(<PlayBestScoreSoundCoroutine>d__15))]
	private IEnumerator PlayBestScoreSoundCoroutine(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x8EEAAC", Offset = "0x8EEAAC", VA = "0x8EEAAC")]
	[IteratorStateMachine(typeof(<PlayBestScoreAnimationCoroutine>d__16))]
	private IEnumerator PlayBestScoreAnimationCoroutine(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x8EA198", Offset = "0x8EA198", VA = "0x8EA198")]
	public void SaveAndShow(int value)
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x8EEB80", Offset = "0x8EEB80", VA = "0x8EEB80")]
	public ScoreBestControl()
	{
	}
}
[Token(Token = "0x2000048")]
[HelpURL("https://makaka.org/unity-assets")]
public class ScoreCurrentControl : MonoBehaviour
{
	[Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class <PlayResetAnimationCoroutine>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ScoreCurrentControl <>4__this;

		[Token(Token = "0x17000022")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x8EF0BC", Offset = "0x8EF0BC", VA = "0x8EF0BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x8EF104", Offset = "0x8EF104", VA = "0x8EF104", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x8EEF70", Offset = "0x8EEF70", VA = "0x8EEF70")]
		[DebuggerHidden]
		public <PlayResetAnimationCoroutine>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x8EEFF0", Offset = "0x8EEFF0", VA = "0x8EEFF0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x8EEFF4", Offset = "0x8EEFF4", VA = "0x8EEFF4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x8EF0C4", Offset = "0x8EF0C4", VA = "0x8EF0C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMeshProUGUI text;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int value;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private int valueAtStart;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Header("Animation")]
	private Animator animator;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Range(0f, 20f)]
	private float resetAnimationDelay;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string resetAnimationTrigger;

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x8EEE80", Offset = "0x8EEE80", VA = "0x8EEE80")]
	private void Start()
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x8EEE88", Offset = "0x8EEE88", VA = "0x8EEE88")]
	private void SetValue(int score)
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x8EA158", Offset = "0x8EA158", VA = "0x8EA158")]
	public void Add(int value)
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x8EA0F8", Offset = "0x8EA0F8", VA = "0x8EA0F8")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x8EEEE4", Offset = "0x8EEEE4", VA = "0x8EEEE4")]
	public int GetValue()
	{
		return default(int);
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x8EEEC0", Offset = "0x8EEEC0", VA = "0x8EEEC0")]
	private void PlayResetAnimation()
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x8EEEEC", Offset = "0x8EEEEC", VA = "0x8EEEEC")]
	[IteratorStateMachine(typeof(<PlayResetAnimationCoroutine>d__12))]
	private IEnumerator PlayResetAnimationCoroutine(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x8EEF98", Offset = "0x8EEF98", VA = "0x8EEF98")]
	public ScoreCurrentControl()
	{
	}
}
[Token(Token = "0x200004A")]
[HelpURL("https://makaka.org/unity-assets")]
public class MaterialControl : MonoBehaviour
{
	[Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class <FadeCoroutine>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MaterialControl <>4__this;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isFadeIn;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool isResetColorToStandardInTheBeginning;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool isResetFadingInTheEnd;

		[Token(Token = "0x17000024")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x8EF728", Offset = "0x8EF728", VA = "0x8EF728", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x8EF770", Offset = "0x8EF770", VA = "0x8EF770", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x8EF2D8", Offset = "0x8EF2D8", VA = "0x8EF2D8")]
		[DebuggerHidden]
		public <FadeCoroutine>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x8EF4D0", Offset = "0x8EF4D0", VA = "0x8EF4D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x8EF4D4", Offset = "0x8EF4D4", VA = "0x8EF4D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x8EF730", Offset = "0x8EF730", VA = "0x8EF730", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Renderer renderer3D;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Material materialStandardShared;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Material materialStandardClone;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Header("Shader Parameter Changing")]
	private bool isParameterChangingOnAtStart;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private string parameter;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Tooltip("1 = Fading In On Start.")]
	private float parameterOnStart;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float parameterMax;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float parameterMin;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float parameterCurrent;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Header("Delays (Parameter Changing must be completed before Object's Deactivating)")]
	public float delayOut;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float delayIn;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Header("Speed (Parameter = Time)")]
	[SerializeField]
	private AnimationCurve speedOut;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private AnimationCurve speedIn;

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x8EF10C", Offset = "0x8EF10C", VA = "0x8EF10C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x8EF13C", Offset = "0x8EF13C", VA = "0x8EF13C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x8EF2AC", Offset = "0x8EF2AC", VA = "0x8EF2AC")]
	public void Fade(bool isFadeIn, bool isResetFadingInTheEnd, bool isResetColorToStandardInTheBeginning = false)
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x8EB518", Offset = "0x8EB518", VA = "0x8EB518")]
	[IteratorStateMachine(typeof(<FadeCoroutine>d__16))]
	public IEnumerator FadeCoroutine(bool isFadeIn, bool isResetFadingInTheEnd, bool isResetColorToStandardInTheBeginning = false)
	{
		return null;
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x8EF1D0", Offset = "0x8EF1D0", VA = "0x8EF1D0")]
	private void Step()
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x8EF31C", Offset = "0x8EF31C", VA = "0x8EF31C")]
	private void ResetFade()
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x8EF300", Offset = "0x8EF300", VA = "0x8EF300")]
	public void SetMaterial(Material material)
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x8EF334", Offset = "0x8EF334", VA = "0x8EF334")]
	private void SetMaterialStandard()
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x8EF358", Offset = "0x8EF358", VA = "0x8EF358")]
	public void SetRendererEnabled(bool enabled)
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x8EF408", Offset = "0x8EF408", VA = "0x8EF408")]
	public MaterialControl()
	{
	}
}
[Token(Token = "0x200004C")]
public class TagSelectorAttribute : PropertyAttribute
{
	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string Untagged;

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x8EF778", Offset = "0x8EF778", VA = "0x8EF778")]
	public TagSelectorAttribute()
	{
	}
}
[Token(Token = "0x200004D")]
public class PublisherReadme : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x200004E")]
	public class Section
	{
		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string heading;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string linkText;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string url;

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x8EF7F4", Offset = "0x8EF7F4", VA = "0x8EF7F4")]
		public Section()
		{
		}
	}

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D icon;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string title;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Section[] sections;

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x8EF7EC", Offset = "0x8EF7EC", VA = "0x8EF7EC")]
	public PublisherReadme()
	{
	}
}
[Token(Token = "0x200004F")]
[HelpURL("https://makaka.org/unity-assets")]
[AddComponentMenu("Scripts/Makaka Games/Throw Control/Throw Control")]
public class ThrowControl : MonoBehaviour
{
	[Token(Token = "0x2000050")]
	public enum Mode
	{
		[Token(Token = "0x40001B4")]
		Flick,
		[Token(Token = "0x40001B5")]
		ClickOrTap
	}

	[Serializable]
	[Token(Token = "0x2000051")]
	public class UnityEventWithThrowingObject : UnityEvent<ThrowingObject>
	{
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x8F084C", Offset = "0x8F084C", VA = "0x8F084C")]
		public UnityEventWithThrowingObject()
		{
		}
	}

	[Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class <InitThrowingObjectsCoroutine>d__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ThrowControl <>4__this;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x17000027")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x8F0D58", Offset = "0x8F0D58", VA = "0x8F0D58", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x8F0DA0", Offset = "0x8F0DA0", VA = "0x8F0DA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x8EF8A0", Offset = "0x8EF8A0", VA = "0x8EF8A0")]
		[DebuggerHidden]
		public <InitThrowingObjectsCoroutine>d__53(int <>1__state)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x8F0894", Offset = "0x8F0894", VA = "0x8F0894", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x8F0898", Offset = "0x8F0898", VA = "0x8F0898", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x8F0D60", Offset = "0x8F0D60", VA = "0x8F0D60", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class <OnTouchForFlickCoroutine>d__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ThrowControl <>4__this;

		[Token(Token = "0x17000029")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x8F0E7C", Offset = "0x8F0E7C", VA = "0x8F0E7C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x8F0EC4", Offset = "0x8F0EC4", VA = "0x8F0EC4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x8EFEC4", Offset = "0x8EFEC4", VA = "0x8EFEC4")]
		[DebuggerHidden]
		public <OnTouchForFlickCoroutine>d__57(int <>1__state)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x8F0DA8", Offset = "0x8F0DA8", VA = "0x8F0DA8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x8F0DAC", Offset = "0x8F0DAC", VA = "0x8F0DAC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x8F0E84", Offset = "0x8F0E84", VA = "0x8F0E84", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class <ThrowCoroutine>d__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ThrowingObject throwingObject;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ThrowControl <>4__this;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2 inputPositionFirst;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector2 inputPositionLast;

		[Token(Token = "0x1700002B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x8F15C4", Offset = "0x8F15C4", VA = "0x8F15C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x8F160C", Offset = "0x8F160C", VA = "0x8F160C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x8EFEEC", Offset = "0x8EFEEC", VA = "0x8EFEEC")]
		[DebuggerHidden]
		public <ThrowCoroutine>d__58(int <>1__state)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x8F0ECC", Offset = "0x8F0ECC", VA = "0x8F0ECC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x8F0ED0", Offset = "0x8F0ED0", VA = "0x8F0ED0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x8F15CC", Offset = "0x8F15CC", VA = "0x8F15CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class <FadeOutCoroutine>d__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ThrowControl <>4__this;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ThrowingObject throwingObject;

		[Token(Token = "0x1700002D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x8F16F4", Offset = "0x8F16F4", VA = "0x8F16F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x8F173C", Offset = "0x8F173C", VA = "0x8F173C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x8EFFB4", Offset = "0x8EFFB4", VA = "0x8EFFB4")]
		[DebuggerHidden]
		public <FadeOutCoroutine>d__59(int <>1__state)
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x8F1614", Offset = "0x8F1614", VA = "0x8F1614", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x8F1618", Offset = "0x8F1618", VA = "0x8F1618", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x8F16FC", Offset = "0x8F16FC", VA = "0x8F16FC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class <ResetCoroutine>d__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ThrowControl <>4__this;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ThrowingObject throwingObject;

		[Token(Token = "0x1700002F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x8F1AB8", Offset = "0x8F1AB8", VA = "0x8F1AB8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x8F1B00", Offset = "0x8F1B00", VA = "0x8F1B00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x8F007C", Offset = "0x8F007C", VA = "0x8F007C")]
		[DebuggerHidden]
		public <ResetCoroutine>d__60(int <>1__state)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x8F1744", Offset = "0x8F1744", VA = "0x8F1744", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x8F1748", Offset = "0x8F1748", VA = "0x8F1748", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x8F1AC0", Offset = "0x8F1AC0", VA = "0x8F1AC0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class <GetNextThrowCoroutine>d__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ThrowControl <>4__this;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float delay;

		[Token(Token = "0x17000031")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x8F1E40", Offset = "0x8F1E40", VA = "0x8F1E40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x8F1E88", Offset = "0x8F1E88", VA = "0x8F1E88", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x8F0128", Offset = "0x8F0128", VA = "0x8F0128")]
		[DebuggerHidden]
		public <GetNextThrowCoroutine>d__62(int <>1__state)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x8F1B08", Offset = "0x8F1B08", VA = "0x8F1B08", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x8F1B0C", Offset = "0x8F1B0C", VA = "0x8F1B0C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x8F1E48", Offset = "0x8F1E48", VA = "0x8F1E48", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class <ChangeLayerCoroutine>d__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ThrowControl <>4__this;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject to;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int layerIndex;

		[Token(Token = "0x17000033")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x8F1F5C", Offset = "0x8F1F5C", VA = "0x8F1F5C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x8F1FA4", Offset = "0x8F1FA4", VA = "0x8F1FA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x8F05D8", Offset = "0x8F05D8", VA = "0x8F05D8")]
		[DebuggerHidden]
		public <ChangeLayerCoroutine>d__66(int <>1__state)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x8F1E90", Offset = "0x8F1E90", VA = "0x8F1E90", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x8F1E94", Offset = "0x8F1E94", VA = "0x8F1E94", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x8F1F64", Offset = "0x8F1F64", VA = "0x8F1F64", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RandomObjectPooler randomObjectPooler;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UnityEvent OnInitialized;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ThrowingObject throwingObjectTempForRegistration;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Header("FPS (throw force takes into account the speed of the player's movement) ")]
	public CharacterController characterControllerFPS;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float characterControllerFPSSpeedCurrent;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Header("Camera")]
	public Camera cameraMain;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Header("Mode")]
	public Mode modeAtAwake;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private bool isTouchForFlick;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	[Tooltip("If it's false then it allows fast flicks only.\n\nPositions in the last and previous frames are taken into account.\n\nPlay with params: sensivity = new Vector2(100f, 100f); force = 45f.")]
	public bool isFullPathForFlick;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float lerpTimeFactorOnTouchForFlick;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[Header("Throw")]
	[Tooltip("Actual for FPS Controller")]
	public bool isInputPositionFixed;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Range(0.01f, 1f)]
	public float inputPositionFixedScreenFactorX;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[Range(0.01f, 1f)]
	public float inputPositionFixedScreenFactorY;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Vector2 inputSensitivity;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float forceFactorExtra;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float torqueFactorExtra;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float torqueAngleExtra;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Transform parentOnThrow;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public UnityEventWithThrowingObject OnThrow;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[Range(0.1f, 10f)]
	[Header("Next Throw")]
	public float nextThrowGettingDelay;

	[Token(Token = "0x4000199")]
	private const float nextCoroutineCallTryDelay = 0.1f;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private bool isNextThrowGetting;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private GameObject gameObjectTemp;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private ThrowingObject throwingObjectTemp;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public UnityEventWithThrowingObject OnNextThrowGetting;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[Header("Tag")]
	public bool isTagCustomSetOnInit;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[TagSelector]
	public string tagCustomOnInit;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[Header("Layer Changing (actual for quick Throwing to neutralize mutual collisions)")]
	public bool isLayerChangingOn;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	[Range(0f, 5f)]
	public float layerChangingOnThrowDelay;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public LayerMask layerMaskOnThrow;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public LayerMask layerMaskOnReset;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[Tooltip("May be useful in very rare cases. E.g., when you play with Time Scale and Layers can't be changed quickly.\n\nNote: If you are dealing with Cloth, then you must operate with it outside of this asset to avoid collisions when OnReset() Event is dispatched:\nnull Cloth Collider every dispatch of OnNextThrowGetting() Event & register Cloth Collider every dispatch of OnThrow() Event.")]
	[Range(0f, 1f)]
	public float delayAfterLayerChanging;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private int layerIndexOnThrow;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private int layerIndexOnReset;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	[Header("Reset (must be called after the end of Fading Out)")]
	[Range(0f, 10f)]
	public float resetDelay;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public UnityEventWithThrowingObject OnReset;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private GameObject gameObjectCurrent;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private ThrowingObject throwingObjectCurrent;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private RaycastHit raycastHit;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	private bool isInputBegan;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x125")]
	private bool isInputEnded;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x126")]
	private bool isInputHeldDown;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private Vector3 inputPositionCurrent;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private Vector3 inputPositionPivot;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	[Header("Fading")]
	public bool isFadingOn;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	[Header("Fading Out (must be completed before Reset)")]
	public UnityEventWithThrowingObject OnFadingOut;

	[Token(Token = "0x17000026")]
	public List<ThrowingObject> throwingObjectsRegistered
	{
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x8EF7FC", Offset = "0x8EF7FC", VA = "0x8EF7FC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x8EF804", Offset = "0x8EF804", VA = "0x8EF804")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x8EF80C", Offset = "0x8EF80C", VA = "0x8EF80C")]
	public void InitThrowingObjects()
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x8EF82C", Offset = "0x8EF82C", VA = "0x8EF82C")]
	[IteratorStateMachine(typeof(<InitThrowingObjectsCoroutine>d__53))]
	private IEnumerator InitThrowingObjectsCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x8E99BC", Offset = "0x8E99BC", VA = "0x8E99BC")]
	public void GetFirstThrow()
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x8EF8F0", Offset = "0x8EF8F0", VA = "0x8EF8F0")]
	private void Update()
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x8EFD48", Offset = "0x8EFD48", VA = "0x8EFD48")]
	private Vector3 GetInputPositionFixed()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x8EFD98", Offset = "0x8EFD98", VA = "0x8EFD98")]
	[IteratorStateMachine(typeof(<OnTouchForFlickCoroutine>d__57))]
	private IEnumerator OnTouchForFlickCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x8EFE0C", Offset = "0x8EFE0C", VA = "0x8EFE0C")]
	[IteratorStateMachine(typeof(<ThrowCoroutine>d__58))]
	private IEnumerator ThrowCoroutine(Vector2 inputPositionFirst, Vector2 inputPositionLast, ThrowingObject throwingObject)
	{
		return null;
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x8EFF14", Offset = "0x8EFF14", VA = "0x8EFF14")]
	[IteratorStateMachine(typeof(<FadeOutCoroutine>d__59))]
	private IEnumerator FadeOutCoroutine(float delay, ThrowingObject throwingObject)
	{
		return null;
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x8EFFDC", Offset = "0x8EFFDC", VA = "0x8EFFDC")]
	[IteratorStateMachine(typeof(<ResetCoroutine>d__60))]
	private IEnumerator ResetCoroutine(float delay, ThrowingObject throwingObject)
	{
		return null;
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x8EF8C8", Offset = "0x8EF8C8", VA = "0x8EF8C8")]
	private void GetNextThrow(float delay)
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x8F00A4", Offset = "0x8F00A4", VA = "0x8F00A4")]
	[IteratorStateMachine(typeof(<GetNextThrowCoroutine>d__62))]
	private IEnumerator GetNextThrowCoroutine(float delay)
	{
		return null;
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x8F0150", Offset = "0x8F0150", VA = "0x8F0150")]
	public ThrowingObject RegisterOrGetThrowingObject(GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x8F03C4", Offset = "0x8F03C4", VA = "0x8F03C4")]
	public void PlayRandomSoundDependingOnSpeed(ThrowingObject.AudioData audioData, GameObject to, bool isStoppedBeforePlay)
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x8F048C", Offset = "0x8F048C", VA = "0x8F048C")]
	public void SetMaterial(Material material, GameObject to)
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x8F0530", Offset = "0x8F0530", VA = "0x8F0530")]
	[IteratorStateMachine(typeof(<ChangeLayerCoroutine>d__66))]
	private IEnumerator ChangeLayerCoroutine(float delay, GameObject to, int layerIndex)
	{
		return null;
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x8F0600", Offset = "0x8F0600", VA = "0x8F0600")]
	private void ChangeLayer(GameObject to, int layerIndex)
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x8F061C", Offset = "0x8F061C", VA = "0x8F061C")]
	private int LayerMaskValueToIndex(int value)
	{
		return default(int);
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x8F0744", Offset = "0x8F0744", VA = "0x8F0744")]
	private void InitLayerIndexes()
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x8F0784", Offset = "0x8F0784", VA = "0x8F0784")]
	public ThrowControl()
	{
	}
}
[Token(Token = "0x2000059")]
[AddComponentMenu("Scripts/Makaka Games/Throw Control/Throwing Object")]
[HelpURL("https://makaka.org/unity-assets")]
public class ThrowingObject : MonoBehaviour
{
	[Token(Token = "0x200005A")]
	public enum CameraAxes
	{
		[Token(Token = "0x40001F7")]
		CameraMainTransformUp,
		[Token(Token = "0x40001F8")]
		CameraMainTransformForward,
		[Token(Token = "0x40001F9")]
		CameraMainTransformRight,
		[Token(Token = "0x40001FA")]
		CameraMainTransformUpRight,
		[Token(Token = "0x40001FB")]
		CameraMainTransformLeft,
		[Token(Token = "0x40001FC")]
		CameraMainTransformUpLeft
	}

	[Token(Token = "0x200005B")]
	public enum RotationsForNextThrow
	{
		[Token(Token = "0x40001FE")]
		Default,
		[Token(Token = "0x40001FF")]
		Random,
		[Token(Token = "0x4000200")]
		Custom
	}

	[Serializable]
	[Token(Token = "0x200005C")]
	public class AudioData
	{
		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioClip[] audioClips;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float speedClampMin;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float speedClampMax;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(-3f, 3f)]
		public float pitchMin;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float pitchFactor;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float volumeFactor;

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x8E8604", Offset = "0x8E8604", VA = "0x8E8604")]
		public AudioData()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x8F2580", Offset = "0x8F2580", VA = "0x8F2580")]
		public AudioData(AudioClip[] audioClips, float speedClampMin = 0f, float speedClampMax = 15f, float pitchMin = 0.8f, float pitchFactor = 0.02f, float volumeFactor = 0.125f)
		{
		}
	}

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Collider[] colliders3D;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MaterialControl materialControl;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("Custom Flag for Any User Logic")]
	[Header("Custom Data")]
	public bool flagCustom;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Convenient Access to Custom Control Script of this Throwing Object")]
	public MonoBehaviour monoBehaviourCustom;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Header("Force")]
	[SerializeField]
	private float forceFactor;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 forceDirection;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector2 strength;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector2 strengthFactor;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private CameraAxes forceDirectionExtra;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Vector3 forceDirectionExtraVector3;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Header("Torque")]
	public CameraAxes torqueAxis;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 torqueAxisVector3;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float torqueAngleBasic;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[SerializeField]
	private float torqueAngle;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private float torqueFactor;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Quaternion torqueRotation;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[Tooltip("It clamps Torque")]
	[SerializeField]
	private float maxAngularVelocityAtAwake;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[Header("Center Of Mass")]
	[Tooltip("Base point for selection of Custom Center Of Mass")]
	[SerializeField]
	private bool isCenterOfMassByDefaultLoggedAtAwake;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
	[SerializeField]
	private bool isCenterOfMassCustomUsedAtAwake;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	[SerializeField]
	private Vector3 centerOfMassCustomAtAwake;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Quaternion rotationByDefault;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[Header("Position")]
	[Tooltip("Middle is in the bottom of the screen: (0.5f, 0.1f)\nY must be less Y of Input Position Fixed.\n\nLinked with Input Sensitivity.")]
	public Vector2 positionInViewportOnReset;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[Tooltip("Used for Z coordinate in Reset() & OnTouchForFlick() ")]
	public float cameraNearClipPlaneFactorOnReset;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	[Header("Rotation")]
	[SerializeField]
	private bool isObjectRotatedInThrowDirection;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private RotationsForNextThrow rotationOnReset;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	[SerializeField]
	private Vector3 rotationOnResetCustom;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[Header("Audio — Whoosh")]
	[SerializeField]
	private AudioSource audioSourceWhoosh;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private AudioData audioDataWhoosh;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[HideInInspector]
	public bool isThrown;

	[Token(Token = "0x14000004")]
	public event Action OnThrow
	{
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x8F1FAC", Offset = "0x8F1FAC", VA = "0x8F1FAC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x8F2048", Offset = "0x8F2048", VA = "0x8F2048")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public event Action OnResetPhysicsBase
	{
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x8E8B20", Offset = "0x8E8B20", VA = "0x8E8B20")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x8F20E4", Offset = "0x8F20E4", VA = "0x8F20E4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x8F2180", Offset = "0x8F2180", VA = "0x8F2180")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x8F0CC8", Offset = "0x8F0CC8", VA = "0x8F0CC8")]
	public void SetRendererEnabled(bool enabled)
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x8E92E8", Offset = "0x8E92E8", VA = "0x8E92E8")]
	public void SetMaterial(Material material)
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x8F1304", Offset = "0x8F1304", VA = "0x8F1304")]
	public void ThrowBase(Vector2 inputPositionFirst, Vector2 inputPositionLast, Vector2 inputSensitivity, Transform cameraMain, int screenHight, float forceFactorExtra, float torqueFactorExtra, float torqueAngleExtra)
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x8F22A0", Offset = "0x8F22A0", VA = "0x8F22A0")]
	private Vector3 GetCameraAxis(Transform cameraMain, CameraAxes cameraAxis)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x8F1A34", Offset = "0x8F1A34", VA = "0x8F1A34")]
	public void ResetPhysicsBase()
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x8F0C4C", Offset = "0x8F0C4C", VA = "0x8F0C4C")]
	public void ResetPosition(Camera cameraMain)
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x8F0C50", Offset = "0x8F0C50", VA = "0x8F0C50")]
	public void ResetRotation(Transform parent)
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x8F244C", Offset = "0x8F244C", VA = "0x8F244C")]
	private Quaternion GetRandomRotation()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x8F15B8", Offset = "0x8F15B8", VA = "0x8F15B8")]
	public void PlayAudioWhoosh()
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x8F0480", Offset = "0x8F0480", VA = "0x8F0480")]
	public void PlayAudioRandomlyDependingOnSpeed(AudioData audioData, bool isStoppedBeforePlay)
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x8E8EE8", Offset = "0x8E8EE8", VA = "0x8E8EE8")]
	public void PlayAudioRandomlyDependingOnSpeed(AudioData audioData, bool isStoppedBeforePlay, AudioSource audioSource)
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x8F1A50", Offset = "0x8F1A50", VA = "0x8F1A50")]
	public void ActivateTriggersOnColliders(bool isTrigger)
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x8F129C", Offset = "0x8F129C", VA = "0x8F129C")]
	public void SetCollidersEnabled(bool enabled)
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x8F24C4", Offset = "0x8F24C4", VA = "0x8F24C4")]
	public ThrowingObject()
	{
	}
}
[Token(Token = "0x200005D")]
public class Hours_Mechanic : MonoBehaviour
{
	[Token(Token = "0x4000207")]
	private const float hoursrot = 30f;

	[Token(Token = "0x4000208")]
	private const float minutesrot = 6f;

	[Token(Token = "0x4000209")]
	private const float secondsrot = 6f;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform hours;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform minutes;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform seconds;

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x8F2600", Offset = "0x8F2600", VA = "0x8F2600")]
	private void Update()
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x8F2748", Offset = "0x8F2748", VA = "0x8F2748")]
	public Hours_Mechanic()
	{
	}
}
[Token(Token = "0x200005E")]
public class TimeW : MonoBehaviour
{
	[Token(Token = "0x6000209")]
	[Address(RVA = "0x8F2750", Offset = "0x8F2750", VA = "0x8F2750")]
	private void Start()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x8F27A4", Offset = "0x8F27A4", VA = "0x8F27A4")]
	private void LaunchTime()
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x8F2874", Offset = "0x8F2874", VA = "0x8F2874")]
	public TimeW()
	{
	}
}
[Token(Token = "0x200005F")]
public class StormVFXTerrainDemoCamera : MonoBehaviour
{
	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float moveSpeed;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float height;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Space]
	public float acceleration;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float deceleration;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 velocity;

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x8F287C", Offset = "0x8F287C", VA = "0x8F287C")]
	private void Start()
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x8F2880", Offset = "0x8F2880", VA = "0x8F2880")]
	private void Update()
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x8F2DD0", Offset = "0x8F2DD0", VA = "0x8F2DD0")]
	public StormVFXTerrainDemoCamera()
	{
	}
}
[Token(Token = "0x2000060")]
public class StormVFXTerrainDemoFollowTargetPosition : MonoBehaviour
{
	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x8F2DE4", Offset = "0x8F2DE4", VA = "0x8F2DE4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x8F2DE8", Offset = "0x8F2DE8", VA = "0x8F2DE8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x8F2DEC", Offset = "0x8F2DEC", VA = "0x8F2DEC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x8F2E2C", Offset = "0x8F2E2C", VA = "0x8F2E2C")]
	public StormVFXTerrainDemoFollowTargetPosition()
	{
	}
}
[Token(Token = "0x2000061")]
public class ParticleSystemTimeRemap : MonoBehaviour
{
	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem[] particleSystems;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float[] startTimes;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float[] simulationTimes;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float startTime;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float simulationSpeedScale;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool useFixedDeltaTime;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool gameObjectDeactivated;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	public bool reverseSimulation;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float elapsedTime;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AnimationCurve simulationSpeedOverTime;

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x8F2E34", Offset = "0x8F2E34", VA = "0x8F2E34")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x8F3034", Offset = "0x8F3034", VA = "0x8F3034")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x8F3094", Offset = "0x8F3094", VA = "0x8F3094")]
	private void Update()
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x8F3414", Offset = "0x8F3414", VA = "0x8F3414")]
	public ParticleSystemTimeRemap()
	{
	}
}
[Token(Token = "0x2000062")]
public class RewindParticleSystem : MonoBehaviour
{
	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem[] particleSystems;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float[] startTimes;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float[] simulationTimes;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float startTime;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float simulationSpeedScale;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool useFixedDeltaTime;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool gameObjectDeactivated;

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x8F3468", Offset = "0x8F3468", VA = "0x8F3468")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x8F3630", Offset = "0x8F3630", VA = "0x8F3630")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x8F3690", Offset = "0x8F3690", VA = "0x8F3690")]
	private void Update()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x8F3988", Offset = "0x8F3988", VA = "0x8F3988")]
	public RewindParticleSystem()
	{
	}
}
[Token(Token = "0x2000063")]
public class RewindParticleSystemSimple : MonoBehaviour
{
	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem[] particleSystems;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float simulationTime;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float startTime;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float internalStartTime;

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool gameObjectDeactivated;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float simulationSpeed;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool useFixedDeltaTime;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	public bool rewind;

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x8F39A4", Offset = "0x8F39A4", VA = "0x8F39A4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x8F3AB4", Offset = "0x8F3AB4", VA = "0x8F3AB4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x8F3B14", Offset = "0x8F3B14", VA = "0x8F3B14")]
	private void Update()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x8F3D18", Offset = "0x8F3D18", VA = "0x8F3D18")]
	public RewindParticleSystemSimple()
	{
	}
}
[Token(Token = "0x2000064")]
public class RewindParticleSystemSuperSimple : MonoBehaviour
{
	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem[] particleSystems;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float[] simulationTimes;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float startTime;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float simulationSpeedScale;

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x8F3D38", Offset = "0x8F3D38", VA = "0x8F3D38")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x8F3DD4", Offset = "0x8F3DD4", VA = "0x8F3DD4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x8F3E64", Offset = "0x8F3E64", VA = "0x8F3E64")]
	private void Update()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x8F4144", Offset = "0x8F4144", VA = "0x8F4144")]
	public RewindParticleSystemSuperSimple()
	{
	}
}
[Token(Token = "0x2000065")]
public class ParticleForceFieldsDemo : MonoBehaviour
{
	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Overview")]
	public Text FPSText;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text particleCountText;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Toggle postProcessingToggle;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public MonoBehaviour postProcessing;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Header("Particle System Settings")]
	public ParticleSystem particleSystem;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private ParticleSystem.MainModule particleSystemMainModule;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private ParticleSystem.EmissionModule particleSystemEmissionModule;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Text maxParticlesText;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Text particlesPerSecondText;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Slider maxParticlesSlider;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Slider particlesPerSecondSlider;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[Header("Attraction Particle Force Field Settings")]
	public AttractionParticleForceField attractionParticleForceField;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Text attractionParticleForceFieldRadiusText;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Text attractionParticleForceFieldMaxForceText;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Text attractionParticleForceFieldArrivalRadiusText;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Text attractionParticleForceFieldArrivedRadiusText;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Text attractionParticleForceFieldPositionTextX;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Text attractionParticleForceFieldPositionTextY;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Text attractionParticleForceFieldPositionTextZ;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Slider attractionParticleForceFieldRadiusSlider;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Slider attractionParticleForceFieldMaxForceSlider;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Slider attractionParticleForceFieldArrivalRadiusSlider;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Slider attractionParticleForceFieldArrivedRadiusSlider;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Slider attractionParticleForceFieldPositionSliderX;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Slider attractionParticleForceFieldPositionSliderY;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Slider attractionParticleForceFieldPositionSliderZ;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[Header("Vortex Particle Force Field Settings")]
	public VortexParticleForceField vortexParticleForceField;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public Text vortexParticleForceFieldRadiusText;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Text vortexParticleForceFieldMaxForceText;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Text vortexParticleForceFieldRotationTextX;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public Text vortexParticleForceFieldRotationTextY;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Text vortexParticleForceFieldRotationTextZ;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public Text vortexParticleForceFieldPositionTextX;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public Text vortexParticleForceFieldPositionTextY;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public Text vortexParticleForceFieldPositionTextZ;

	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public Slider vortexParticleForceFieldRadiusSlider;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public Slider vortexParticleForceFieldMaxForceSlider;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public Slider vortexParticleForceFieldRotationSliderX;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public Slider vortexParticleForceFieldRotationSliderY;

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public Slider vortexParticleForceFieldRotationSliderZ;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public Slider vortexParticleForceFieldPositionSliderX;

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public Slider vortexParticleForceFieldPositionSliderY;

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public Slider vortexParticleForceFieldPositionSliderZ;

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x8F4158", Offset = "0x8F4158", VA = "0x8F4158")]
	private void Start()
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x8F4C0C", Offset = "0x8F4C0C", VA = "0x8F4C0C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x8F4D18", Offset = "0x8F4D18", VA = "0x8F4D18")]
	public void ReloadScene()
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x8F4D88", Offset = "0x8F4D88", VA = "0x8F4D88")]
	public void SetMaxParticles(float value)
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x8F4E40", Offset = "0x8F4E40", VA = "0x8F4E40")]
	public void SetParticleEmissionPerSecond(float value)
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x8F4F08", Offset = "0x8F4F08", VA = "0x8F4F08")]
	public void SetAttractionParticleForceFieldRadius(float value)
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x8F4FB0", Offset = "0x8F4FB0", VA = "0x8F4FB0")]
	public void SetAttractionParticleForceFieldMaxForce(float value)
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x8F5058", Offset = "0x8F5058", VA = "0x8F5058")]
	public void SetAttractionParticleForceFieldArrivalRadius(float value)
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x8F5100", Offset = "0x8F5100", VA = "0x8F5100")]
	public void SetAttractionParticleForceFieldArrivedRadius(float value)
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x8F51A8", Offset = "0x8F51A8", VA = "0x8F51A8")]
	public void SetAttractionParticleForceFieldPositionX(float value)
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x8F5298", Offset = "0x8F5298", VA = "0x8F5298")]
	public void SetAttractionParticleForceFieldPositionY(float value)
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x8F5388", Offset = "0x8F5388", VA = "0x8F5388")]
	public void SetAttractionParticleForceFieldPositionZ(float value)
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x8F5478", Offset = "0x8F5478", VA = "0x8F5478")]
	public void SetVortexParticleForceFieldRadius(float value)
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x8F5520", Offset = "0x8F5520", VA = "0x8F5520")]
	public void SetVortexParticleForceFieldMaxForce(float value)
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x8F55C8", Offset = "0x8F55C8", VA = "0x8F55C8")]
	public void SetVortexParticleForceFieldRotationX(float value)
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x8F56B8", Offset = "0x8F56B8", VA = "0x8F56B8")]
	public void SetVortexParticleForceFieldRotationY(float value)
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x8F57A8", Offset = "0x8F57A8", VA = "0x8F57A8")]
	public void SetVortexParticleForceFieldRotationZ(float value)
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x8F5898", Offset = "0x8F5898", VA = "0x8F5898")]
	public void SetVortexParticleForceFieldPositionX(float value)
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x8F5988", Offset = "0x8F5988", VA = "0x8F5988")]
	public void SetVortexParticleForceFieldPositionY(float value)
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x8F5A78", Offset = "0x8F5A78", VA = "0x8F5A78")]
	public void SetVortexParticleForceFieldPositionZ(float value)
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x8F5B68", Offset = "0x8F5B68", VA = "0x8F5B68")]
	public ParticleForceFieldsDemo()
	{
	}
}
[Token(Token = "0x2000066")]
public class ParticleForceFieldsDemo_CameraRig : MonoBehaviour
{
	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform pivot;

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 targetRotation;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Range(0f, 90f)]
	public float rotationLimit;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float rotationSpeed;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float rotationLerpSpeed;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 startRotation;

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x8F5B70", Offset = "0x8F5B70", VA = "0x8F5B70")]
	private void Start()
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x8F5BAC", Offset = "0x8F5BAC", VA = "0x8F5BAC")]
	private void Update()
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x8F5DA8", Offset = "0x8F5DA8", VA = "0x8F5DA8")]
	public ParticleForceFieldsDemo_CameraRig()
	{
	}
}
[Token(Token = "0x2000067")]
public class ParticlePlexusDemo_CameraRig : MonoBehaviour
{
	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform pivot;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 targetRotation;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Range(0f, 90f)]
	public float rotationLimit;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float rotationSpeed;

	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float rotationLerpSpeed;

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 startRotation;

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x8F5DC4", Offset = "0x8F5DC4", VA = "0x8F5DC4")]
	private void Start()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x8F5E00", Offset = "0x8F5E00", VA = "0x8F5E00")]
	private void Update()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x8F5FFC", Offset = "0x8F5FFC", VA = "0x8F5FFC")]
	public ParticlePlexusDemo_CameraRig()
	{
	}
}
[Token(Token = "0x2000068")]
public class SceneAudioManager : Singleton<SceneAudioManager>
{
	[Serializable]
	[Token(Token = "0x2000069")]
	private class AudioSound
	{
		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip[] audioClips;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public AudioSource aSource;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Space]
		public float volume;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float pitchVariation;

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x8F639C", Offset = "0x8F639C", VA = "0x8F639C")]
		public void PlayRandom()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x8F64F8", Offset = "0x8F64F8", VA = "0x8F64F8")]
		public AudioSound()
		{
		}
	}

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<AudioSound> sounds;

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x8F6018", Offset = "0x8F6018", VA = "0x8F6018")]
	private void Start()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x8F601C", Offset = "0x8F601C", VA = "0x8F601C")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x8F61CC", Offset = "0x8F61CC", VA = "0x8F61CC")]
	public void PlaySound(string soundName)
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x8F64B0", Offset = "0x8F64B0", VA = "0x8F64B0")]
	public SceneAudioManager()
	{
	}
}
[Token(Token = "0x200006B")]
public class AxeBitPoint : MonoBehaviour
{
	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject ImpactParticlesPrefab;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Rigidbody rb;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AxeThrowingAxe axeComponent;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float dist;

	[Token(Token = "0x17000035")]
	private Ray ForwardRay
	{
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x8F6530", Offset = "0x8F6530", VA = "0x8F6530")]
		get
		{
			return default(Ray);
		}
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x8F65C0", Offset = "0x8F65C0", VA = "0x8F65C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x8F6650", Offset = "0x8F6650", VA = "0x8F6650")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x8F6A90", Offset = "0x8F6A90", VA = "0x8F6A90")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x8F6B8C", Offset = "0x8F6B8C", VA = "0x8F6B8C")]
	public AxeBitPoint()
	{
	}
}
[Token(Token = "0x200006C")]
public class AxeThrowingAxe : ResetableTransform
{
	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Grabbable g;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject axeTrail;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Transform axeSpawnPoint;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float yRot;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float xRot;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public bool touchingGround;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public Autohand.Hand heldBy;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool isThrown;

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x8F6BA0", Offset = "0x8F6BA0", VA = "0x8F6BA0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x8F6BF8", Offset = "0x8F6BF8", VA = "0x8F6BF8")]
	private new void Start()
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x8F6E2C", Offset = "0x8F6E2C", VA = "0x8F6E2C")]
	private void Update()
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x8F6F70", Offset = "0x8F6F70", VA = "0x8F6F70")]
	private void OnGrab(Autohand.Hand h, Grabbable g)
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x8F7044", Offset = "0x8F7044", VA = "0x8F7044")]
	private void OnRelease(Autohand.Hand h, Grabbable g)
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x8F73C0", Offset = "0x8F73C0", VA = "0x8F73C0", Slot = "5")]
	public override void ResetPos()
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x8F7620", Offset = "0x8F7620", VA = "0x8F7620")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x8F7704", Offset = "0x8F7704", VA = "0x8F7704")]
	public AxeThrowingAxe()
	{
	}
}
[Token(Token = "0x200006D")]
public class ArrowBow : MonoBehaviour
{
	[Token(Token = "0x6000253")]
	[Address(RVA = "0x8F7714", Offset = "0x8F7714", VA = "0x8F7714")]
	private void Start()
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x8F77D8", Offset = "0x8F77D8", VA = "0x8F77D8")]
	public ArrowBow()
	{
	}
}
[Token(Token = "0x200006E")]
public class ArrowGameManager : MonoBehaviour
{
	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float TimeTillEnd;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int Score;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Space]
	public TextMeshProUGUI EquationTxt;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI ScoreTxt;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI TimeLeft;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ArrowTarget[] targets;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string HSKey;

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x8F783C", Offset = "0x8F783C", VA = "0x8F783C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x8F7988", Offset = "0x8F7988", VA = "0x8F7988")]
	private void Start()
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x8F7A00", Offset = "0x8F7A00", VA = "0x8F7A00")]
	private void Update()
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x8F7E24", Offset = "0x8F7E24", VA = "0x8F7E24")]
	public void AddScore(int points)
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x8F7840", Offset = "0x8F7840", VA = "0x8F7840")]
	public void NewEquation()
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x8F8050", Offset = "0x8F8050", VA = "0x8F8050")]
	public Equation GetRandomEquation()
	{
		return null;
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x8F8830", Offset = "0x8F8830", VA = "0x8F8830")]
	public ArrowGameManager()
	{
	}
}
[Token(Token = "0x200006F")]
public class Equation
{
	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string EquationTxt;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int Answer;

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x8F87F4", Offset = "0x8F87F4", VA = "0x8F87F4")]
	public Equation(string txt, int ans)
	{
	}
}
[Token(Token = "0x2000070")]
public class ArrowManager : MonoBehaviour
{
	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject arrowTrail;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform tip;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private LayerMask raycastMask;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform arrowTrigger;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject hitParticles;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Vector3 defaultLinePoint;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public LineRenderer bowLine;

	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public Transform arrowPointRight;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[HideInInspector]
	public Transform arrowPointLeft;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public Transform WatchesPos;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public ParticleSystem lineParticles;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[HideInInspector]
	public Grabbable bow;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Transform ArrowPoint;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Rigidbody rb;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Grabbable grabbable;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private ArrowSpawner arrowSpawner;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private AudioSource bowDrawAudioSource;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private bool inBowArea;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
	private bool arrowChecked;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private float strength;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 dir;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Vector3 defWatchesPos;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Vector3 defWatchesRot;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private float endZ;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private float startZ;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private float yOffset;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private bool shot;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
	[HideInInspector]
	public bool isFlying;

	[Token(Token = "0x17000036")]
	public bool isAttachedToBow
	{
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x8F8C38", Offset = "0x8F8C38", VA = "0x8F8C38")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x8F8890", Offset = "0x8F8890", VA = "0x8F8890")]
	private void Start()
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x8F8CC0", Offset = "0x8F8CC0", VA = "0x8F8CC0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x8F9424", Offset = "0x8F9424", VA = "0x8F9424")]
	private void UpdateHeldPosition()
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x8F9590", Offset = "0x8F9590", VA = "0x8F9590")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x8F9544", Offset = "0x8F9544", VA = "0x8F9544")]
	private void DrawBowSoundEffect(float deltaY)
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x8F8B88", Offset = "0x8F8B88", VA = "0x8F8B88")]
	private void UpdateArrowPoint()
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x8F8FF8", Offset = "0x8F8FF8", VA = "0x8F8FF8")]
	private void UpdateWatchesPos()
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x8F93F8", Offset = "0x8F93F8", VA = "0x8F93F8")]
	private void ResetBowLine()
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x8F9A70", Offset = "0x8F9A70", VA = "0x8F9A70")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x8F9730", Offset = "0x8F9730", VA = "0x8F9730")]
	private void Hit(Collider col)
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x8F9ED8", Offset = "0x8F9ED8", VA = "0x8F9ED8")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x8F8F4C", Offset = "0x8F8F4C", VA = "0x8F8F4C")]
	public void RotateWithVelocity()
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x8F9FB8", Offset = "0x8F9FB8", VA = "0x8F9FB8")]
	public void OnArrowCheckStay()
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x8F9FC4", Offset = "0x8F9FC4", VA = "0x8F9FC4")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x8FA034", Offset = "0x8FA034", VA = "0x8FA034")]
	public void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x8FA0A0", Offset = "0x8FA0A0", VA = "0x8FA0A0")]
	public ArrowManager()
	{
	}
}
[Token(Token = "0x2000071")]
public class ArrowQuiver : MonoBehaviour
{
	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Grabbable bow;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject QuiverGO;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool isRight;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public GameObject CurrentArrow;

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x8FA52C", Offset = "0x8FA52C", VA = "0x8FA52C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x8FA620", Offset = "0x8FA620", VA = "0x8FA620")]
	public ArrowQuiver()
	{
	}
}
[Token(Token = "0x2000072")]
public class ArrowSpawner : MonoBehaviour
{
	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject ArrowPrefab;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform LeftSpawnerPos;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform LeftQuiver;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform RightQuiver;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private LineRenderer bowLine;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Transform arrowPointRight;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Transform arrowPointLeft;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Transform WatchesPos;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private ParticleSystem lineParticles;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Grabbable bow;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool spawnedFirst;

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x8FA628", Offset = "0x8FA628", VA = "0x8FA628")]
	private void Start()
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x8FA1AC", Offset = "0x8FA1AC", VA = "0x8FA1AC")]
	public void SpawnNextArrow(bool isRight)
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x8FA648", Offset = "0x8FA648", VA = "0x8FA648")]
	public ArrowSpawner()
	{
	}
}
[Token(Token = "0x2000073")]
public class ArrowTarget : MonoBehaviour
{
	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public bool isResult;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI txt;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject SuccessParticles;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float TimeSinceHide;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private ResetableTransform axeR;

	[Token(Token = "0x17000037")]
	[HideInInspector]
	public string txtValue
	{
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x8FA650", Offset = "0x8FA650", VA = "0x8FA650")]
		set
		{
		}
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x8F9AAC", Offset = "0x8F9AAC", VA = "0x8F9AAC")]
	public void OnHit()
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x8FA9E8", Offset = "0x8FA9E8", VA = "0x8FA9E8")]
	private void CheckAxe()
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x8F6A74", Offset = "0x8F6A74", VA = "0x8F6A74")]
	public void OnHitWithAxe(ResetableTransform axe)
	{
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x8FAAC8", Offset = "0x8FAAC8", VA = "0x8FAAC8")]
	public void Hide()
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x8F83B4", Offset = "0x8F83B4", VA = "0x8F83B4")]
	public void Show(int num, bool correct)
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x8FADC4", Offset = "0x8FADC4", VA = "0x8FADC4")]
	public void InvokeShow()
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x8FB0B4", Offset = "0x8FB0B4", VA = "0x8FB0B4")]
	public ArrowTarget()
	{
	}
}
[Token(Token = "0x2000074")]
public class ArrowTrigger : MonoBehaviour
{
	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ArrowManager arrowManager;

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x8FB0C4", Offset = "0x8FB0C4", VA = "0x8FB0C4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x8FB0DC", Offset = "0x8FB0DC", VA = "0x8FB0DC")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x8FB0F4", Offset = "0x8FB0F4", VA = "0x8FB0F4")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x8FB16C", Offset = "0x8FB16C", VA = "0x8FB16C")]
	public ArrowTrigger()
	{
	}
}
[Token(Token = "0x2000075")]
public class Bullet : MonoBehaviour
{
	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float speed;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject BulletSmoke;

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x8FB174", Offset = "0x8FB174", VA = "0x8FB174")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x8FB200", Offset = "0x8FB200", VA = "0x8FB200")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x8FB95C", Offset = "0x8FB95C", VA = "0x8FB95C")]
	public Bullet()
	{
	}
}
[Token(Token = "0x2000076")]
public class CameraFollowY : MonoBehaviour
{
	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float yOffset;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float minYPos;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float maxYPos;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Space]
	[SerializeField]
	private float distToReset;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform camT;

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x8FB96C", Offset = "0x8FB96C", VA = "0x8FB96C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x8FBA3C", Offset = "0x8FBA3C", VA = "0x8FBA3C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x8FBAA8", Offset = "0x8FBAA8", VA = "0x8FBAA8")]
	private void UpdateYPos()
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x8FBB4C", Offset = "0x8FBB4C", VA = "0x8FBB4C")]
	public CameraFollowY()
	{
	}
}
[Token(Token = "0x2000077")]
public class CoinsUI : MonoBehaviour
{
	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TextMeshProUGUI txt;

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x8FBB60", Offset = "0x8FBB60", VA = "0x8FBB60")]
	private void Awake()
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x8FBBB8", Offset = "0x8FBBB8", VA = "0x8FBBB8")]
	private void Update()
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x8FBC84", Offset = "0x8FBC84", VA = "0x8FBC84")]
	public CoinsUI()
	{
	}
}
[Token(Token = "0x2000078")]
public class ConeHolder : MonoBehaviour
{
	[Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class <EnableCone>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ConeHolder <>4__this;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float time;

		[Token(Token = "0x17000038")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x8FBF0C", Offset = "0x8FBF0C", VA = "0x8FBF0C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x8FBF54", Offset = "0x8FBF54", VA = "0x8FBF54", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x8FBDF4", Offset = "0x8FBDF4", VA = "0x8FBDF4")]
		[DebuggerHidden]
		public <EnableCone>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x8FBE24", Offset = "0x8FBE24", VA = "0x8FBE24", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x8FBE28", Offset = "0x8FBE28", VA = "0x8FBE28", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x8FBF14", Offset = "0x8FBF14", VA = "0x8FBF14", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject Cone;

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x8FBC8C", Offset = "0x8FBC8C", VA = "0x8FBC8C")]
	private void Start()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x8FBCAC", Offset = "0x8FBCAC", VA = "0x8FBCAC")]
	private void OnTriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x8FBD70", Offset = "0x8FBD70", VA = "0x8FBD70")]
	[IteratorStateMachine(typeof(<EnableCone>d__3))]
	private IEnumerator EnableCone(float time)
	{
		return null;
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x8FBE1C", Offset = "0x8FBE1C", VA = "0x8FBE1C")]
	public ConeHolder()
	{
	}
}
[Token(Token = "0x200007A")]
public class CrowdCharacter : MonoBehaviour
{
	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject[] caps;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject[] shirts;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject[] extras;

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x8FBF5C", Offset = "0x8FBF5C", VA = "0x8FBF5C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x8FC0B4", Offset = "0x8FC0B4", VA = "0x8FC0B4")]
	public CrowdCharacter()
	{
	}
}
[Token(Token = "0x200007B")]
public class CrowdController : MonoBehaviour
{
	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<GameObject> characterPrefabs;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip HappyCheers;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AudioClip DissapointedSound;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioSource aSource;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<Transform> spawnPoints;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Animator> spawnedCharacters;

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x8FC0BC", Offset = "0x8FC0BC", VA = "0x8FC0BC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x8FC290", Offset = "0x8FC290", VA = "0x8FC290")]
	private void Start()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x8FC2F0", Offset = "0x8FC2F0", VA = "0x8FC2F0")]
	public void SpawnNext()
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x8F7F44", Offset = "0x8F7F44", VA = "0x8F7F44")]
	public void HappyCrowd()
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x8F804C", Offset = "0x8F804C", VA = "0x8F804C")]
	public void DissapointedCrowd()
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x8FC58C", Offset = "0x8FC58C", VA = "0x8FC58C")]
	public CrowdController()
	{
	}
}
[Token(Token = "0x200007C")]
public class EnabledIf : MonoBehaviour
{
	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject objDependency;

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x8FC594", Offset = "0x8FC594", VA = "0x8FC594")]
	private void Update()
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x8FC634", Offset = "0x8FC634", VA = "0x8FC634")]
	public EnabledIf()
	{
	}
}
[Token(Token = "0x200007D")]
public class GameModeSelector : MonoBehaviour
{
	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Image GameModeShowcaseImg;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text GameModeNameTxt;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text HighScoreTxt;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject leftArrow;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject rightArrow;

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameModeInfo[] GameModes;

	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int current;

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public string SceneName;

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x8FC63C", Offset = "0x8FC63C", VA = "0x8FC63C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x8FC6C4", Offset = "0x8FC6C4", VA = "0x8FC6C4")]
	public void UpdateUI(int c, bool SetTrigger = true)
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x8FC894", Offset = "0x8FC894", VA = "0x8FC894")]
	public void LeftBtn()
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x8FC8A8", Offset = "0x8FC8A8", VA = "0x8FC8A8")]
	public void RightBtn()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x8FC8BC", Offset = "0x8FC8BC", VA = "0x8FC8BC")]
	public GameModeSelector()
	{
	}
}
[Serializable]
[Token(Token = "0x200007E")]
public class GameModeInfo
{
	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Sprite ShowcaseImg;

	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string GameModeName;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string HighScorePrefKey;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string SceneName;

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x8FC8C4", Offset = "0x8FC8C4", VA = "0x8FC8C4")]
	public GameModeInfo()
	{
	}
}
[Token(Token = "0x200007F")]
public class GameMusic : MonoBehaviour
{
	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static GameMusic instance;

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x8FC8CC", Offset = "0x8FC8CC", VA = "0x8FC8CC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x8FCA08", Offset = "0x8FCA08", VA = "0x8FCA08")]
	public GameMusic()
	{
	}
}
[Token(Token = "0x2000080")]
public class Gun : MonoBehaviour
{
	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x8FCA10", Offset = "0x8FCA10", VA = "0x8FCA10")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x8FCAD4", Offset = "0x8FCAD4", VA = "0x8FCAD4")]
	public Gun()
	{
	}
}
[Token(Token = "0x2000081")]
public class HandController : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000082")]
	public class HandInfo
	{
		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Autohand.Hand LeftHand;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Autohand.Hand RightHand;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform WatchTransform;

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x8FDC28", Offset = "0x8FDC28", VA = "0x8FDC28")]
		public HandInfo()
		{
		}
	}

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject Bullet;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<HandInfo> Hands;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int ActiveHandNumber;

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private HandInfo currentHand;

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject Watches;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool[] gripBtnPressed;

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool[] triggerBtnPressed;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool isGrippingRight;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	public static bool isGrippingLeft;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material[] Gloves;

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x8FCB38", Offset = "0x8FCB38", VA = "0x8FCB38")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x8FCC38", Offset = "0x8FCC38", VA = "0x8FCC38")]
	public void SetNewHand(int handNumber)
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x8FCDAC", Offset = "0x8FCDAC", VA = "0x8FCDAC")]
	public void SetNewGloves(int gloveNumber)
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x8FCEB8", Offset = "0x8FCEB8", VA = "0x8FCEB8")]
	public void VibrateHand(bool rightHand)
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x8FCF00", Offset = "0x8FCF00", VA = "0x8FCF00")]
	private void Update()
	{
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x8FD1B8", Offset = "0x8FD1B8", VA = "0x8FD1B8")]
	public void GetInputValues(Autohand.Hand hand)
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x8FDBA8", Offset = "0x8FDBA8", VA = "0x8FDBA8")]
	public HandController()
	{
	}
}
[Token(Token = "0x2000083")]
public static class Helper
{
	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x8FDAA8", Offset = "0x8FDAA8", VA = "0x8FDAA8")]
	public static void SetAllFingersGrip(this Autohand.Hand h, float bend)
	{
	}
}
[Token(Token = "0x2000084")]
public class HighScoreText : MonoBehaviour
{
	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string PlayerPrefsName;

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x8FDC30", Offset = "0x8FDC30", VA = "0x8FDC30")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x8FDCF0", Offset = "0x8FDCF0", VA = "0x8FDCF0")]
	public HighScoreText()
	{
	}
}
[Token(Token = "0x2000085")]
public class InGameTutorial : MonoBehaviour
{
	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Canvas EquationCanvas;

	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject Tutorial;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject BallSpawner;

	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject EndGameMenu;

	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Space]
	public TextMeshProUGUI ScoreUI;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI HighScoreUI;

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Image StarsFill;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool inTutorial;

	[Token(Token = "0x1700003A")]
	public bool TutorialGOEnabled
	{
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x8FD8BC", Offset = "0x8FD8BC", VA = "0x8FD8BC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x8FDCF8", Offset = "0x8FDCF8", VA = "0x8FDCF8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x8FDE14", Offset = "0x8FDE14", VA = "0x8FDE14")]
	private void Update()
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x8FD8D8", Offset = "0x8FD8D8", VA = "0x8FD8D8")]
	public void EnableTutorial(bool enable)
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x8F7B94", Offset = "0x8F7B94", VA = "0x8F7B94")]
	public void EndGame(int score, int highscore)
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x8FDF58", Offset = "0x8FDF58", VA = "0x8FDF58")]
	public InGameTutorial()
	{
	}
}
[Token(Token = "0x2000086")]
public class ItemsShop : MonoBehaviour
{
	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int[] prices;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI[] PricesUI;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string Key;

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Space]
	public AudioClip Success;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AudioClip Click;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AudioClip Fail;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Space]
	public Color UsingCol;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Color BoughtCol;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Color PriceCol;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private AudioSource aSource;

	[Token(Token = "0x1700003B")]
	public static int Coins
	{
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x8FBC3C", Offset = "0x8FBC3C", VA = "0x8FBC3C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x8FDF0C", Offset = "0x8FDF0C", VA = "0x8FDF0C")]
		set
		{
		}
	}

	[Token(Token = "0x1700003C")]
	public int Current
	{
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x8FE1A8", Offset = "0x8FE1A8", VA = "0x8FE1A8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x8FE354", Offset = "0x8FE354", VA = "0x8FE354")]
		set
		{
		}
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x8FDF60", Offset = "0x8FDF60", VA = "0x8FDF60")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x8FDFC0", Offset = "0x8FDFC0", VA = "0x8FDFC0")]
	public void UpdateUI()
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x8FE28C", Offset = "0x8FE28C", VA = "0x8FE28C")]
	public void OnClick(int id)
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x8FE3B8", Offset = "0x8FE3B8", VA = "0x8FE3B8")]
	private void Animate(int id)
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x8FE1FC", Offset = "0x8FE1FC", VA = "0x8FE1FC")]
	public bool isBought(int id)
	{
		return default(bool);
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x8FE47C", Offset = "0x8FE47C", VA = "0x8FE47C")]
	public void Buy(int id)
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x8FE54C", Offset = "0x8FE54C", VA = "0x8FE54C")]
	public ItemsShop()
	{
	}
}
[Token(Token = "0x2000087")]
public class KatanaAudioManager : MonoBehaviour
{
	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource aSource;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip[] breakSounds;

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x8FE5A4", Offset = "0x8FE5A4", VA = "0x8FE5A4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x8FE5FC", Offset = "0x8FE5FC", VA = "0x8FE5FC")]
	public void BreakSound()
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x8FE65C", Offset = "0x8FE65C", VA = "0x8FE65C")]
	public KatanaAudioManager()
	{
	}
}
[Token(Token = "0x2000088")]
public class KatanaManager : MonoBehaviour
{
	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI scoreTxt;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI timeTxt;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI oddEvenTxt;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool isEvenNums;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float TimeLeft;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int TotalScore;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool endGame;

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x8FE664", Offset = "0x8FE664", VA = "0x8FE664")]
	private void Start()
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x8FE88C", Offset = "0x8FE88C", VA = "0x8FE88C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x8FE9D0", Offset = "0x8FE9D0", VA = "0x8FE9D0")]
	public void OnNumSliced(int numValue, Vector3 objPosition)
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x8FE7B0", Offset = "0x8FE7B0", VA = "0x8FE7B0")]
	public void AddScore(int ScoreAmount)
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x8FE684", Offset = "0x8FE684", VA = "0x8FE684")]
	private void ResetIsEven(bool animate = true)
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x8FEB88", Offset = "0x8FEB88", VA = "0x8FEB88")]
	public KatanaManager()
	{
	}
}
[Token(Token = "0x2000089")]
public class KatanaSpawner : MonoBehaviour
{
	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] Katanas;

	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int current;

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x8FEB98", Offset = "0x8FEB98", VA = "0x8FEB98")]
	private void Start()
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x8FEC5C", Offset = "0x8FEC5C", VA = "0x8FEC5C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x8FEBEC", Offset = "0x8FEBEC", VA = "0x8FEBEC")]
	private void ShowKatana(int id)
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x8FECD4", Offset = "0x8FECD4", VA = "0x8FECD4")]
	public KatanaSpawner()
	{
	}
}
[Token(Token = "0x200008A")]
public class KatanaTrigger : MonoBehaviour
{
	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x8FECDC", Offset = "0x8FECDC", VA = "0x8FECDC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x8FED50", Offset = "0x8FED50", VA = "0x8FED50")]
	public KatanaTrigger()
	{
	}
}
[Token(Token = "0x200008B")]
public class LolTurnOn : MonoBehaviour
{
	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject TurnOn;

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x8FED58", Offset = "0x8FED58", VA = "0x8FED58")]
	private void Update()
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x8FEE8C", Offset = "0x8FEE8C", VA = "0x8FEE8C")]
	public LolTurnOn()
	{
	}
}
[Token(Token = "0x200008C")]
public class LookAt : MonoBehaviour
{
	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float offsetY;

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x8FEE94", Offset = "0x8FEE94", VA = "0x8FEE94")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x8FF004", Offset = "0x8FF004", VA = "0x8FF004")]
	public LookAt()
	{
	}
}
[Token(Token = "0x200008D")]
public class MainMenuManager : MonoBehaviour
{
	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x8FF014", Offset = "0x8FF014", VA = "0x8FF014")]
	public void LoadGame()
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x8FF110", Offset = "0x8FF110", VA = "0x8FF110")]
	public MainMenuManager()
	{
	}
}
[Token(Token = "0x200008E")]
public class NumberObject : MonoBehaviour
{
	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Rigidbody rb;

	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public Quaternion dir;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float gravity;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Color[] randomColors;

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x8FF118", Offset = "0x8FF118", VA = "0x8FF118")]
	private void Start()
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x8FF37C", Offset = "0x8FF37C", VA = "0x8FF37C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x8FF3BC", Offset = "0x8FF3BC", VA = "0x8FF3BC")]
	private void Update()
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x8FF4F8", Offset = "0x8FF4F8", VA = "0x8FF4F8")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x8FF5B0", Offset = "0x8FF5B0", VA = "0x8FF5B0")]
	public NumberObject()
	{
	}
}
[Token(Token = "0x200008F")]
public class NumberSpawner : MonoBehaviour
{
	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] NumberObjects;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject enabledIfDependency;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float minY;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float maxY;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float desiredOffset;

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x8FF5C4", Offset = "0x8FF5C4", VA = "0x8FF5C4")]
	private void Update()
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x8FF67C", Offset = "0x8FF67C", VA = "0x8FF67C")]
	public void SpawnNext()
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x8FF838", Offset = "0x8FF838", VA = "0x8FF838")]
	public NumberSpawner()
	{
	}
}
[Token(Token = "0x2000090")]
public class NumberSpawnersManager : MonoBehaviour
{
	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public NumberSpawner[] spawners;

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x8FF854", Offset = "0x8FF854", VA = "0x8FF854")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x8FF8B0", Offset = "0x8FF8B0", VA = "0x8FF8B0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x8FF8B8", Offset = "0x8FF8B8", VA = "0x8FF8B8")]
	private void SpawnNext()
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x8FF8FC", Offset = "0x8FF8FC", VA = "0x8FF8FC")]
	public NumberSpawnersManager()
	{
	}
}
[Token(Token = "0x2000091")]
public class PaintballAudioManager : MonoBehaviour
{
	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource aSource;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioSource TargetHit;

	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioSource OtherHit;

	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AudioSource ShootSound;

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x8FF904", Offset = "0x8FF904", VA = "0x8FF904")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x8FB60C", Offset = "0x8FB60C", VA = "0x8FB60C")]
	public void OnTargetHit()
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x8FB940", Offset = "0x8FB940", VA = "0x8FB940")]
	public void OnOtherHit()
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x8FDB8C", Offset = "0x8FDB8C", VA = "0x8FDB8C")]
	public void OnShootSound()
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x8FF95C", Offset = "0x8FF95C", VA = "0x8FF95C")]
	public PaintballAudioManager()
	{
	}
}
[Token(Token = "0x2000092")]
public class PaintballManager : MonoBehaviour
{
	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] Targets;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Animator[] Underlines;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI[] Numbers;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI Answer;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI ScoreTxt;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI TimeLeftTxt;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string HightScorePrefsKey;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public int Score;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float TimeLeft;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool gameEnded;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject CongratulationsUI;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TextMeshProUGUI CongratulationsPoints;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject WrongUI;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public TextMeshProUGUI WrongPoints;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private int CurrentNum;

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private int Sum;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private GameObject targetToReset;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int AnswersCount;

	[Token(Token = "0x1700003D")]
	public int HighScore
	{
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x8FF964", Offset = "0x8FF964", VA = "0x8FF964")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x8FF970", Offset = "0x8FF970", VA = "0x8FF970")]
		set
		{
		}
	}

	[Token(Token = "0x1700003E")]
	public bool isPunchPlatesMinigame
	{
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x8FF97C", Offset = "0x8FF97C", VA = "0x8FF97C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x8FFA08", Offset = "0x8FFA08", VA = "0x8FFA08")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x900374", Offset = "0x900374", VA = "0x900374")]
	private void Update()
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x900584", Offset = "0x900584", VA = "0x900584")]
	public void AddScore(int v)
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x8FB628", Offset = "0x8FB628", VA = "0x8FB628")]
	public bool OnTargetHit(string value, GameObject target)
	{
		return default(bool);
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x900760", Offset = "0x900760", VA = "0x900760")]
	public bool OnTargetHitPunch(GameObject target)
	{
		return default(bool);
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x90094C", Offset = "0x90094C", VA = "0x90094C")]
	private void ResetTarget()
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x90001C", Offset = "0x90001C", VA = "0x90001C")]
	public void NewEquation()
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x8FFAE0", Offset = "0x8FFAE0", VA = "0x8FFAE0")]
	public void NewEquationPunchPlates()
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x900984", Offset = "0x900984", VA = "0x900984")]
	public PaintballManager()
	{
	}
}
[Token(Token = "0x2000094")]
public class PaintGunSpawner : MonoBehaviour
{
	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<GameObject> Guns;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject activeGun;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int HandNumber;

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x900A84", Offset = "0x900A84", VA = "0x900A84")]
	private void Start()
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x900C00", Offset = "0x900C00", VA = "0x900C00")]
	private void Update()
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x900AD8", Offset = "0x900AD8", VA = "0x900AD8")]
	private void spawnGun()
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x900CAC", Offset = "0x900CAC", VA = "0x900CAC")]
	public PaintGunSpawner()
	{
	}
}
[Token(Token = "0x2000095")]
public class PlatePunchTargetChecker : MonoBehaviour
{
	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject BulletSmoke;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float lastTimeHit;

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x900CB4", Offset = "0x900CB4", VA = "0x900CB4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x900E98", Offset = "0x900E98", VA = "0x900E98")]
	public PlatePunchTargetChecker()
	{
	}
}
[Token(Token = "0x2000096")]
public class PreventForcedRelease : MonoBehaviour
{
	[Token(Token = "0x6000303")]
	[Address(RVA = "0x900EA8", Offset = "0x900EA8", VA = "0x900EA8")]
	public PreventForcedRelease()
	{
	}
}
[Token(Token = "0x2000097")]
public class PunchPlatesHand : MonoBehaviour
{
	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject Particles;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Autohand.Hand h;

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x900EB0", Offset = "0x900EB0", VA = "0x900EB0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x900F08", Offset = "0x900F08", VA = "0x900F08")]
	private void Update()
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x900FFC", Offset = "0x900FFC", VA = "0x900FFC")]
	public PunchPlatesHand()
	{
	}
}
[Token(Token = "0x2000098")]
public class PunchPlatesHolder : MonoBehaviour
{
	[Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class <IEnabled>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PunchPlatesHolder <>4__this;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <t>5__2;

		[Token(Token = "0x1700003F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600030F")]
			[Address(RVA = "0x9013B4", Offset = "0x9013B4", VA = "0x9013B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000311")]
			[Address(RVA = "0x9013FC", Offset = "0x9013FC", VA = "0x9013FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x901260", Offset = "0x901260", VA = "0x901260")]
		[DebuggerHidden]
		public <IEnabled>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x901290", Offset = "0x901290", VA = "0x901290", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x901294", Offset = "0x901294", VA = "0x901294", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x9013BC", Offset = "0x9013BC", VA = "0x9013BC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x901004", Offset = "0x901004", VA = "0x901004")]
	private void Start()
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x901098", Offset = "0x901098", VA = "0x901098")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x9010B8", Offset = "0x9010B8", VA = "0x9010B8")]
	private void Update()
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x901024", Offset = "0x901024", VA = "0x901024")]
	[IteratorStateMachine(typeof(<IEnabled>d__3))]
	private IEnumerator IEnabled()
	{
		return null;
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x901288", Offset = "0x901288", VA = "0x901288")]
	public PunchPlatesHolder()
	{
	}
}
[Token(Token = "0x200009A")]
public class ResetableTransform : MonoBehaviour
{
	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal Rigidbody rb;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal Vector3 defPos;

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	internal Quaternion defRot;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	internal Vector3 defScale;

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x8F6D6C", Offset = "0x8F6D6C", VA = "0x8F6D6C", Slot = "4")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x8F74FC", Offset = "0x8F74FC", VA = "0x8F74FC", Slot = "5")]
	public virtual void ResetPos()
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x8F770C", Offset = "0x8F770C", VA = "0x8F770C")]
	public ResetableTransform()
	{
	}
}
[Token(Token = "0x200009B")]
public class SceneLoader : MonoBehaviour
{
	[Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class <Start>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SceneLoader <>4__this;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <t>5__2;

		[Token(Token = "0x17000041")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x9018E0", Offset = "0x9018E0", VA = "0x9018E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x901928", Offset = "0x901928", VA = "0x901928", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x901478", Offset = "0x901478", VA = "0x901478")]
		[DebuggerHidden]
		public <Start>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x9017D0", Offset = "0x9017D0", VA = "0x9017D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x9017D4", Offset = "0x9017D4", VA = "0x9017D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x9018E8", Offset = "0x9018E8", VA = "0x9018E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class <ILoadScene>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SceneLoader <>4__this;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string name;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <t>5__2;

		[Token(Token = "0x17000043")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x901A48", Offset = "0x901A48", VA = "0x901A48", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x901A90", Offset = "0x901A90", VA = "0x901A90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x9015B4", Offset = "0x9015B4", VA = "0x9015B4")]
		[DebuggerHidden]
		public <ILoadScene>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x901930", Offset = "0x901930", VA = "0x901930", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x901934", Offset = "0x901934", VA = "0x901934", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x901A50", Offset = "0x901A50", VA = "0x901A50", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200009E")]
	[CompilerGenerated]
	private sealed class <ILoadScene>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SceneLoader <>4__this;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int index;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <t>5__2;

		[Token(Token = "0x17000045")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x901BB0", Offset = "0x901BB0", VA = "0x901BB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x901BF8", Offset = "0x901BF8", VA = "0x901BF8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x9015DC", Offset = "0x9015DC", VA = "0x9015DC")]
		[DebuggerHidden]
		public <ILoadScene>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x901A98", Offset = "0x901A98", VA = "0x901A98", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x901A9C", Offset = "0x901A9C", VA = "0x901A9C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x901BB8", Offset = "0x901BB8", VA = "0x901BB8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static SceneLoader instance;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material sceneLoaderMat;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool sceneLoading;

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x901404", Offset = "0x901404", VA = "0x901404")]
	[IteratorStateMachine(typeof(<Start>d__3))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x8FF088", Offset = "0x8FF088", VA = "0x8FF088")]
	public static void LoadScene(string name)
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x8FD834", Offset = "0x8FD834", VA = "0x8FD834")]
	public static void LoadScene(int index)
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x9014A0", Offset = "0x9014A0", VA = "0x9014A0")]
	[IteratorStateMachine(typeof(<ILoadScene>d__6))]
	private IEnumerator ILoadScene(string name)
	{
		return null;
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x901530", Offset = "0x901530", VA = "0x901530")]
	[IteratorStateMachine(typeof(<ILoadScene>d__7))]
	private IEnumerator ILoadScene(int index)
	{
		return null;
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x901604", Offset = "0x901604", VA = "0x901604")]
	private void SetOpacity(float opacity)
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x901668", Offset = "0x901668", VA = "0x901668")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x9017C8", Offset = "0x9017C8", VA = "0x9017C8")]
	public SceneLoader()
	{
	}
}
[Token(Token = "0x200009F")]
public class TargetScoreDisplay : MonoBehaviour
{
	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject ScoreToDisplayPrefab;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color SuccessCol;

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Color FailCol;

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x8FA674", Offset = "0x8FA674", VA = "0x8FA674")]
	public GameObject DisplayScore(int score, Vector3 pos, bool addPrefabPos = true)
	{
		return null;
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x901C00", Offset = "0x901C00", VA = "0x901C00")]
	public TargetScoreDisplay()
	{
	}
}
[Token(Token = "0x20000A0")]
public class TimeToLive : MonoBehaviour
{
	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float TimeTL;

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x901C08", Offset = "0x901C08", VA = "0x901C08")]
	private void Start()
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x901C84", Offset = "0x901C84", VA = "0x901C84")]
	public TimeToLive()
	{
	}
}
[Token(Token = "0x20000A1")]
public class IconPreview : MonoBehaviour
{
	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Sprite[] icons;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject icon;

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x901C94", Offset = "0x901C94", VA = "0x901C94")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0x901E70", Offset = "0x901E70", VA = "0x901E70")]
	private void Update()
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0x901E74", Offset = "0x901E74", VA = "0x901E74")]
	public IconPreview()
	{
	}
}
[Token(Token = "0x20000A2")]
public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
	[Token(Token = "0x17000047")]
	public static T Instance
	{
		[Token(Token = "0x6000336")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000048")]
	public static bool InstanceExists
	{
		[Token(Token = "0x6000337")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000338")]
	public Singleton()
	{
	}
}
[Token(Token = "0x20000A3")]
public class FlickerLight : MonoBehaviour
{
	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float MinLightIntensity;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float MaxLightIntensity;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float AccelerateTime;

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float _targetIntensity;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _lastIntensity;

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float _timePassed;

	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Light _lt;

	[Token(Token = "0x4000356")]
	private const double Tolerance = 0.0001;

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x901E7C", Offset = "0x901E7C", VA = "0x901E7C")]
	private void Start()
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x901EF8", Offset = "0x901EF8", VA = "0x901EF8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x901FBC", Offset = "0x901FBC", VA = "0x901FBC")]
	public FlickerLight()
	{
	}
}
[Token(Token = "0x20000A4")]
[RequireComponent(typeof(MeshRenderer))]
public class UVOffset : MonoBehaviour
{
	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float scrollSpeed;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool scrollY;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshRenderer renderer;

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x901FD8", Offset = "0x901FD8", VA = "0x901FD8")]
	private void Start()
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0x902030", Offset = "0x902030", VA = "0x902030")]
	private void Update()
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0x9020C0", Offset = "0x9020C0", VA = "0x9020C0")]
	public UVOffset()
	{
	}
}
namespace PinKnockdown
{
	[Token(Token = "0x20000A5")]
	public class PinBall : MonoBehaviour
	{
		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Grabbable grabbable;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BallSpawner ballSpawner;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public bool HitTarget;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float yOffset;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isThrown;

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x9020D8", Offset = "0x9020D8", VA = "0x9020D8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x902338", Offset = "0x902338", VA = "0x902338")]
		private void Update()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x9023F8", Offset = "0x9023F8", VA = "0x9023F8")]
		private void Destroy()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x902468", Offset = "0x902468", VA = "0x902468")]
		public PinBall()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class PinKnockdownAudio : MonoBehaviour
	{
		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AudioSource aSource;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip SuccessSound;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioClip FailSound;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioClip PopupSound;

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x902878", Offset = "0x902878", VA = "0x902878")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x9028D0", Offset = "0x9028D0", VA = "0x9028D0")]
		public void PlaySuccessSound()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x9028F4", Offset = "0x9028F4", VA = "0x9028F4")]
		public void PlayFailSound()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x902918", Offset = "0x902918", VA = "0x902918")]
		public void PlayPopupSound()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x90293C", Offset = "0x90293C", VA = "0x90293C")]
		public PinKnockdownAudio()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class PinKnockdownManager : MonoBehaviour
	{
		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI ScoreTxt;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI TimerTxt;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI EquationTxt;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TargetCollider[] targetColliders;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float TimeLeft;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int Score;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int AnswersCount;

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x902944", Offset = "0x902944", VA = "0x902944")]
		private void Start()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x902E7C", Offset = "0x902E7C", VA = "0x902E7C")]
		private void Update()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x9029C4", Offset = "0x9029C4", VA = "0x9029C4")]
		public void NewEquation()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x9033FC", Offset = "0x9033FC", VA = "0x9033FC")]
		public void AddScore(int sc)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x903504", Offset = "0x903504", VA = "0x903504")]
		public PinKnockdownManager()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class TargetCollider : MonoBehaviour
	{
		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject SuccessParticles;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI numTxt;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public bool isCorrect;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		public int Number;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float TimeSinceHide;

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x9035A0", Offset = "0x9035A0", VA = "0x9035A0")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x903830", Offset = "0x903830", VA = "0x903830")]
		public void Hide()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x90301C", Offset = "0x90301C", VA = "0x90301C")]
		public void Show(int num, bool correct)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x903B2C", Offset = "0x903B2C", VA = "0x903B2C")]
		public void InvokeShow()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x903E1C", Offset = "0x903E1C", VA = "0x903E1C")]
		public TargetCollider()
		{
		}
	}
}
namespace BzKovSoft.ObjectSlicer.Samples
{
	[Token(Token = "0x20000AA")]
	public class Katana : MonoBehaviour
	{
		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Grabbable grabbable;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Rigidbody rb;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform velocityPoint;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudioSource aSource;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject SlicerPlane;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioClip[] whooshSounds;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<int> slicedObjects;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 lastPos;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float velocity;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 deltaPos;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 whooshDir;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float whooshTime;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private bool changedDir;

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x903E2C", Offset = "0x903E2C", VA = "0x903E2C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x90407C", Offset = "0x90407C", VA = "0x90407C")]
		private void Update()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x9044E0", Offset = "0x9044E0", VA = "0x9044E0")]
		private void WhooshSound()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x9047E8", Offset = "0x9047E8", VA = "0x9047E8")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x904A18", Offset = "0x904A18", VA = "0x904A18")]
		public Katana()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class PlaneSlicer : MonoBehaviour
	{
		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool sliced;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[HideInInspector]
		public bool isRightHand;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 objPosition;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int objValue;

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x904B3C", Offset = "0x904B3C", VA = "0x904B3C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x904BAC", Offset = "0x904BAC", VA = "0x904BAC")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x904E54", Offset = "0x904E54", VA = "0x904E54")]
		private void SliceCallback(BzSliceTryResult r)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x905064", Offset = "0x905064", VA = "0x905064")]
		public PlaneSlicer()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class SlicedPart : MonoBehaviour
	{
		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Rigidbody rb;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float gravity;

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x90506C", Offset = "0x90506C", VA = "0x90506C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x90518C", Offset = "0x90518C", VA = "0x90518C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x9052C8", Offset = "0x9052C8", VA = "0x9052C8")]
		public SlicedPart()
		{
		}
	}
}
namespace BasketballMinigame
{
	[Token(Token = "0x20000AE")]
	public class BallSpawner : MonoBehaviour
	{
		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject BasketballPrefab;

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x9052DC", Offset = "0x9052DC", VA = "0x9052DC")]
		public void Start()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x90258C", Offset = "0x90258C", VA = "0x90258C")]
		public void SpawnBasketball()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x9053F4", Offset = "0x9053F4", VA = "0x9053F4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x905478", Offset = "0x905478", VA = "0x905478")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x9054FC", Offset = "0x9054FC", VA = "0x9054FC")]
		public BallSpawner()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class BasketballAidBox : MonoBehaviour
	{
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x905504", Offset = "0x905504", VA = "0x905504")]
		private void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x905660", Offset = "0x905660", VA = "0x905660")]
		public BasketballAidBox()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class BasketballBall : MonoBehaviour
	{
		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private BallSpawner ballSpawner;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Grabbable grabbable;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody rb;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float maxVel;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float yOffset;

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x905668", Offset = "0x905668", VA = "0x905668")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x9059E4", Offset = "0x9059E4", VA = "0x9059E4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x905AB4", Offset = "0x905AB4", VA = "0x905AB4")]
		private void OnRelease()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x905CBC", Offset = "0x905CBC", VA = "0x905CBC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x905DE0", Offset = "0x905DE0", VA = "0x905DE0")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x906008", Offset = "0x906008", VA = "0x906008")]
		public void SendHapticFeedback(float amp, float dur)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x90607C", Offset = "0x90607C", VA = "0x90607C")]
		public BasketballBall()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public class GameManager : MonoBehaviour
	{
		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float TimeTillEnd;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int Score;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Space]
		public TextMeshProUGUI EquationTxt;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI ScoreTxt;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI TimeLeft;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI[] Hoops;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GoalChecker[] GoalCheckers;

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x90628C", Offset = "0x90628C", VA = "0x90628C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x906480", Offset = "0x906480", VA = "0x906480")]
		private void Start()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x9064F8", Offset = "0x9064F8", VA = "0x9064F8")]
		private void Update()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x9066A0", Offset = "0x9066A0", VA = "0x9066A0")]
		public void AddScore(int points)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x906290", Offset = "0x906290", VA = "0x906290")]
		public void NewEquation()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x9067E0", Offset = "0x9067E0", VA = "0x9067E0")]
		public Equation GetRandomEquation()
		{
			return null;
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x906B80", Offset = "0x906B80", VA = "0x906B80")]
		public GameManager()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public class Equation
	{
		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string EquationTxt;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Answer;

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x906B44", Offset = "0x906B44", VA = "0x906B44")]
		public Equation(string txt, int ans)
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class GoalChecker : MonoBehaviour
	{
		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HoopCanvas hoopCan;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool IsResult;

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x906B90", Offset = "0x906B90", VA = "0x906B90")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x906E90", Offset = "0x906E90", VA = "0x906E90")]
		public GoalChecker()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	public class HoopCanvas : MonoBehaviour
	{
		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator PointsHolder;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI PointsAddedTxt;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color PositiveScoreColor;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color NegativeScoreColor;

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x906C98", Offset = "0x906C98", VA = "0x906C98")]
		public void AddPointsTxt(int points)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x906E98", Offset = "0x906E98", VA = "0x906E98")]
		public HoopCanvas()
		{
		}
	}
}
namespace BalloonMinigame
{
	[Token(Token = "0x20000B6")]
	public class AudioEffects : MonoBehaviour
	{
		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioSource BalloonPop;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource BalloonMiss;

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x906EA0", Offset = "0x906EA0", VA = "0x906EA0")]
		public void BalloonPopSound()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x906EBC", Offset = "0x906EBC", VA = "0x906EBC")]
		public void BalloonMissSound()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x906ED8", Offset = "0x906ED8", VA = "0x906ED8")]
		public AudioEffects()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class Balloon : MonoBehaviour
	{
		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MeshRenderer mRenderer;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject ParticleEffectPrefab;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject FailureParticleEffect;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Text numberTxt;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject toDisable;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public int RandomNum;

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x906EE0", Offset = "0x906EE0", VA = "0x906EE0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x906FB4", Offset = "0x906FB4", VA = "0x906FB4")]
		public void BalloonPop()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x906F48", Offset = "0x906F48", VA = "0x906F48")]
		private void ResetBalloon()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x907324", Offset = "0x907324", VA = "0x907324")]
		public Balloon()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public class BalloonDartsManager : MonoBehaviour
	{
		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text NumberType;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text Timer;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Text Score;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int TotalScore;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float TimePassed;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public bool IsOdd;

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x90732C", Offset = "0x90732C", VA = "0x90732C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x907470", Offset = "0x907470", VA = "0x907470")]
		private void Update()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x907390", Offset = "0x907390", VA = "0x907390")]
		public void Randomize()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x907194", Offset = "0x907194", VA = "0x907194")]
		public void AddScore(int ScoreAmount)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x9075C4", Offset = "0x9075C4", VA = "0x9075C4")]
		public BalloonDartsManager()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public class Dart : MonoBehaviour
	{
		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Grabbable grabbable;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Rigidbody rb;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private DartSpawner dartSpawner;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isFlying;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float Gravity;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject BoomParticle;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public LayerMask HandLayerMask;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform[] DartColors;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float yOffset;

		[Token(Token = "0x17000049")]
		private Autohand.Hand GetHand
		{
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x907874", Offset = "0x907874", VA = "0x907874")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x9075D4", Offset = "0x9075D4", VA = "0x9075D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x9078FC", Offset = "0x9078FC", VA = "0x9078FC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x907C14", Offset = "0x907C14", VA = "0x907C14")]
		private void OnGrab()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x907D30", Offset = "0x907D30", VA = "0x907D30")]
		private void OnRelease()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x907DD8", Offset = "0x907DD8", VA = "0x907DD8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x908090", Offset = "0x908090", VA = "0x908090")]
		public Dart()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public class DartSpawner : MonoBehaviour
	{
		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<GameObject> DartPrefabs;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int currentNumber;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem pSystem;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject SpawnedDart;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		private bool CanSpawn;

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x9080A8", Offset = "0x9080A8", VA = "0x9080A8")]
		private void Start()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x90820C", Offset = "0x90820C", VA = "0x90820C")]
		private void Update()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x9080AC", Offset = "0x9080AC", VA = "0x9080AC")]
		private void SpawnDart()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x907CD8", Offset = "0x907CD8", VA = "0x907CD8")]
		public void InvokeSpawn()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x9082C0", Offset = "0x9082C0", VA = "0x9082C0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x908344", Offset = "0x908344", VA = "0x908344")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x9083C8", Offset = "0x9083C8", VA = "0x9083C8")]
		public DartSpawner()
		{
		}
	}
}
namespace MirzaBeig.Shaders.ImageEffects
{
	[Serializable]
	[Token(Token = "0x20000BB")]
	[ExecuteInEditMode]
	public class Sharpen : IEBase
	{
		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(-2f, 2f)]
		public float strength;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 8f)]
		public float edgeMult;

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x9093D8", Offset = "0x9093D8", VA = "0x9093D8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x909430", Offset = "0x909430", VA = "0x909430")]
		private void Start()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x909434", Offset = "0x909434", VA = "0x909434")]
		private void Update()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x909438", Offset = "0x909438", VA = "0x909438")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x909634", Offset = "0x909634", VA = "0x909634")]
		public Sharpen()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BC")]
	[ExecuteInEditMode]
	public class IEBase : MonoBehaviour
	{
		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Material _material;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Camera _camera;

		[Token(Token = "0x1700004A")]
		protected Material material
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x9094E4", Offset = "0x9094E4", VA = "0x9094E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		protected Shader shader
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x909650", Offset = "0x909650", VA = "0x909650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x909658", Offset = "0x909658", VA = "0x909658")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		protected Camera camera
		{
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x909660", Offset = "0x909660", VA = "0x909660")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x909704", Offset = "0x909704", VA = "0x909704")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x909708", Offset = "0x909708", VA = "0x909708")]
		private void Start()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x90970C", Offset = "0x90970C", VA = "0x90970C")]
		private void Update()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x909710", Offset = "0x909710", VA = "0x909710")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x9095B4", Offset = "0x9095B4", VA = "0x9095B4")]
		protected void blit(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x909714", Offset = "0x909714", VA = "0x909714")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x909648", Offset = "0x909648", VA = "0x909648")]
		public IEBase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BD")]
	[ExecuteInEditMode]
	public class MirzaPostProcessing : MonoBehaviour
	{
		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material material;

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x9097A0", Offset = "0x9097A0", VA = "0x9097A0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x909814", Offset = "0x909814", VA = "0x909814")]
		public MirzaPostProcessing()
		{
		}
	}
}
namespace MirzaBeig.Scripting.Effects
{
	[Token(Token = "0x20000BE")]
	public class AttractionParticleAffector : ParticleAffector
	{
		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[Header("Affector Controls")]
		public float arrivalRadius;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float arrivedRadius;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float arrivalRadiusSqr;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float arrivedRadiusSqr;

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x90981C", Offset = "0x90981C", VA = "0x90981C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x909824", Offset = "0x909824", VA = "0x909824", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x909880", Offset = "0x909880", VA = "0x909880", Slot = "8")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x909888", Offset = "0x909888", VA = "0x909888", Slot = "9")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x90A688", Offset = "0x90A688", VA = "0x90A688", Slot = "7")]
		protected override Vector3 GetForce()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x90A850", Offset = "0x90A850", VA = "0x90A850", Slot = "10")]
		protected override void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x90A9E4", Offset = "0x90A9E4", VA = "0x90A9E4")]
		public AttractionParticleAffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BF")]
	public static class Noise
	{
		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float F3;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float G3;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static byte[] perm;

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x90ABDC", Offset = "0x90ABDC", VA = "0x90ABDC")]
		private static float smooth(float t)
		{
			return default(float);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x90ABF4", Offset = "0x90ABF4", VA = "0x90ABF4")]
		private static float fade(float t)
		{
			return default(float);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x90AC20", Offset = "0x90AC20", VA = "0x90AC20")]
		private static int floor(float x)
		{
			return default(int);
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x90AC48", Offset = "0x90AC48", VA = "0x90AC48")]
		private static float lerp(float from, float to, float t)
		{
			return default(float);
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x90AC58", Offset = "0x90AC58", VA = "0x90AC58")]
		private static float grad(int hash, float x, float y, float z)
		{
			return default(float);
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x90ACC0", Offset = "0x90ACC0", VA = "0x90ACC0")]
		public static float perlin(float x, float y, float z)
		{
			return default(float);
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x90B5B8", Offset = "0x90B5B8", VA = "0x90B5B8")]
		public static float simplex(float x, float y, float z)
		{
			return default(float);
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x90BD58", Offset = "0x90BD58", VA = "0x90BD58")]
		public static float octavePerlin(float x, float y, float z, float frequency, int octaves, float lacunarity, float persistence)
		{
			return default(float);
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x90BE64", Offset = "0x90BE64", VA = "0x90BE64")]
		public static float octaveSimplex(float x, float y, float z, float frequency, int octaves, float lacunarity, float persistence)
		{
			return default(float);
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x90BF70", Offset = "0x90BF70", VA = "0x90BF70")]
		public static float perlinUnoptimized(float x, float y, float z)
		{
			return default(float);
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x90C344", Offset = "0x90C344", VA = "0x90C344")]
		public static float simplexUnoptimized(float x, float y, float z)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000C0")]
	public abstract class ParticleAffector : MonoBehaviour
	{
		[Token(Token = "0x20000C1")]
		protected struct GetForceParameters
		{
			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float distanceToAffectorCenterSqr;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Vector3 scaledDirectionToAffectorCenter;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 particlePosition;
		}

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Common Controls")]
		public float radius;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float force;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _radius;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float radiusSqr;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float forceDeltaTime;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 transformPosition;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float[] particleSystemExternalForcesMultipliers;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve scaleForceByDistance;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<ParticleSystem> _particleSystems;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int particleSystemsCount;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<ParticleSystem> particleSystems;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ParticleSystem.Particle[][] particleSystemParticles;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ParticleSystem.MainModule[] particleSystemMainModules;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Renderer[] particleSystemRenderers;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected ParticleSystem currentParticleSystem;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected GetForceParameters parameters;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public bool alwaysUpdate;

		[Token(Token = "0x1700004D")]
		public float scaledRadius
		{
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x90C998", Offset = "0x90C998", VA = "0x90C998")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x909820", Offset = "0x909820", VA = "0x909820", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x909828", Offset = "0x909828", VA = "0x909828", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x90C9CC", Offset = "0x90C9CC", VA = "0x90C9CC", Slot = "6")]
		protected virtual void PerParticleSystemSetup()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x90C9D0", Offset = "0x90C9D0", VA = "0x90C9D0", Slot = "7")]
		protected virtual Vector3 GetForce()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x909884", Offset = "0x909884", VA = "0x909884", Slot = "8")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x90CA14", Offset = "0x90CA14", VA = "0x90CA14")]
		public void AddParticleSystem(ParticleSystem particleSystem)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x90CAC4", Offset = "0x90CAC4", VA = "0x90CAC4")]
		public void RemoveParticleSystem(ParticleSystem particleSystem)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x9098C4", Offset = "0x9098C4", VA = "0x9098C4", Slot = "9")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x90CB1C", Offset = "0x90CB1C", VA = "0x90CB1C")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x90A960", Offset = "0x90A960", VA = "0x90A960", Slot = "10")]
		protected virtual void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x90A9F4", Offset = "0x90A9F4", VA = "0x90A9F4")]
		protected ParticleAffector()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public class TurbulenceParticleAffector : ParticleAffector
	{
		[Token(Token = "0x20000C3")]
		public enum NoiseType
		{
			[Token(Token = "0x40003EA")]
			PseudoPerlin,
			[Token(Token = "0x40003EB")]
			Perlin,
			[Token(Token = "0x40003EC")]
			Simplex,
			[Token(Token = "0x40003ED")]
			OctavePerlin,
			[Token(Token = "0x40003EE")]
			OctaveSimplex
		}

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[Header("Affector Controls")]
		public float speed;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[Range(0f, 8f)]
		public float frequency;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public NoiseType noiseType;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[Header("Octave Variant-Only Controls")]
		[Range(1f, 8f)]
		public int octaves;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Range(0f, 4f)]
		public float lacunarity;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[Range(0f, 1f)]
		public float persistence;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float time;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float randomX;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float randomY;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private float randomZ;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float offsetX;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float offsetY;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float offsetZ;

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x90CB20", Offset = "0x90CB20", VA = "0x90CB20", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x90CB24", Offset = "0x90CB24", VA = "0x90CB24", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x90CB8C", Offset = "0x90CB8C", VA = "0x90CB8C", Slot = "8")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x90CBA8", Offset = "0x90CBA8", VA = "0x90CBA8", Slot = "9")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x90CBD4", Offset = "0x90CBD4", VA = "0x90CBD4", Slot = "7")]
		protected override Vector3 GetForce()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x90CFC4", Offset = "0x90CFC4", VA = "0x90CFC4", Slot = "10")]
		protected override void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x90CFEC", Offset = "0x90CFEC", VA = "0x90CFEC")]
		public TurbulenceParticleAffector()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public class VortexParticleAffector : ParticleAffector
	{
		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 axisOfRotation;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[Header("Affector Controls")]
		public Vector3 axisOfRotationOffset;

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x90D008", Offset = "0x90D008", VA = "0x90D008", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x90D00C", Offset = "0x90D00C", VA = "0x90D00C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x90D010", Offset = "0x90D010", VA = "0x90D010", Slot = "8")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x90D014", Offset = "0x90D014", VA = "0x90D014", Slot = "9")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x90D018", Offset = "0x90D018", VA = "0x90D018")]
		private void UpdateAxisOfRotation()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x90D0B4", Offset = "0x90D0B4", VA = "0x90D0B4", Slot = "6")]
		protected override void PerParticleSystemSetup()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x90D0B8", Offset = "0x90D0B8", VA = "0x90D0B8", Slot = "7")]
		protected override Vector3 GetForce()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x90D1C0", Offset = "0x90D1C0", VA = "0x90D1C0", Slot = "10")]
		protected override void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x90D388", Offset = "0x90D388", VA = "0x90D388")]
		public VortexParticleAffector()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	[RequireComponent(typeof(ParticleSystem))]
	public class ParticleFlocking : MonoBehaviour
	{
		[Token(Token = "0x20000C6")]
		public struct Voxel
		{
			[Token(Token = "0x4000402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Bounds bounds;

			[Token(Token = "0x4000403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int[] particles;

			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int particleCount;
		}

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("N^2 Mode Settings")]
		public float maxDistance;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Header("Forces")]
		public float cohesion;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float separation;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Header("Voxel Mode Settings")]
		public bool useVoxels;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool voxelLocalCenterFromBounds;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float voxelVolume;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int voxelsPerAxis;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int previousVoxelsPerAxisValue;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Voxel[] voxels;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ParticleSystem.Particle[] particles;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3[] particlePositions;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ParticleSystem.MainModule particleSystemMainModule;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("General Performance Settings")]
		[Range(0f, 1f)]
		public float delay;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float timer;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool alwaysUpdate;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool visible;

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x90D3E4", Offset = "0x90D3E4", VA = "0x90D3E4")]
		private void Start()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x90D464", Offset = "0x90D464", VA = "0x90D464")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x90D470", Offset = "0x90D470", VA = "0x90D470")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x90D478", Offset = "0x90D478", VA = "0x90D478")]
		private void buildVoxelGrid()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x90D6AC", Offset = "0x90D6AC", VA = "0x90D6AC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x90E078", Offset = "0x90E078", VA = "0x90E078")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x90E258", Offset = "0x90E258", VA = "0x90E258")]
		public ParticleFlocking()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	[AddComponentMenu("Effects/Particle Force Fields/Attraction Particle Force Field")]
	public class AttractionParticleForceField : ParticleForceField
	{
		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[Header("ForceField Controls")]
		[Tooltip("Tether force based on linear inverse particle distance to force field center.")]
		public float arrivalRadius;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Tooltip("Dead zone from force field center in which no additional force is applied.")]
		public float arrivedRadius;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float arrivalRadiusSqr;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float arrivedRadiusSqr;

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x90E284", Offset = "0x90E284", VA = "0x90E284", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x90E28C", Offset = "0x90E28C", VA = "0x90E28C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x90E2E8", Offset = "0x90E2E8", VA = "0x90E2E8", Slot = "8")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x90E2F0", Offset = "0x90E2F0", VA = "0x90E2F0", Slot = "9")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x90F120", Offset = "0x90F120", VA = "0x90F120", Slot = "7")]
		protected override Vector3 GetForce()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x90F2E8", Offset = "0x90F2E8", VA = "0x90F2E8", Slot = "10")]
		protected override void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x90F47C", Offset = "0x90F47C", VA = "0x90F47C")]
		public AttractionParticleForceField()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C8")]
	public static class Noise2
	{
		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float F3;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float G3;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static byte[] perm;

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x90F674", Offset = "0x90F674", VA = "0x90F674")]
		private static float smooth(float t)
		{
			return default(float);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x90F68C", Offset = "0x90F68C", VA = "0x90F68C")]
		private static float fade(float t)
		{
			return default(float);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x90F6B8", Offset = "0x90F6B8", VA = "0x90F6B8")]
		private static int floor(float x)
		{
			return default(int);
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x90F6E0", Offset = "0x90F6E0", VA = "0x90F6E0")]
		private static float lerp(float from, float to, float t)
		{
			return default(float);
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x90F6F0", Offset = "0x90F6F0", VA = "0x90F6F0")]
		private static float grad(int hash, float x, float y, float z)
		{
			return default(float);
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x90F758", Offset = "0x90F758", VA = "0x90F758")]
		public static float perlin(float x, float y, float z)
		{
			return default(float);
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x910050", Offset = "0x910050", VA = "0x910050")]
		public static float simplex(float x, float y, float z)
		{
			return default(float);
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x9107F0", Offset = "0x9107F0", VA = "0x9107F0")]
		public static float octavePerlin(float x, float y, float z, float frequency, int octaves, float lacunarity, float persistence)
		{
			return default(float);
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x9108FC", Offset = "0x9108FC", VA = "0x9108FC")]
		public static float octaveSimplex(float x, float y, float z, float frequency, int octaves, float lacunarity, float persistence)
		{
			return default(float);
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x910A08", Offset = "0x910A08", VA = "0x910A08")]
		public static float perlinUnoptimized(float x, float y, float z)
		{
			return default(float);
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x910DDC", Offset = "0x910DDC", VA = "0x910DDC")]
		public static float simplexUnoptimized(float x, float y, float z)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000C9")]
	public abstract class ParticleForceField : MonoBehaviour
	{
		[Token(Token = "0x20000CA")]
		protected struct GetForceParameters
		{
			[Token(Token = "0x400041E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float distanceToForceFieldCenterSqr;

			[Token(Token = "0x400041F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Vector3 scaledDirectionToForceFieldCenter;

			[Token(Token = "0x4000420")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 particlePosition;
		}

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Common Controls")]
		[Tooltip("Force field spherical range.")]
		public float radius;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Maximum baseline force.")]
		public float force;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Internal force field position offset.")]
		public Vector3 center;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _radius;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float radiusSqr;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 transformPosition;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float[] particleSystemExternalForcesMultipliers;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Force scale as determined by distance to individual particles.")]
		public AnimationCurve forceOverDistance;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("If nothing no particle systems are assigned, this force field will operate globally on ALL particle systems in the scene (NOT recommended).\n\nIf attached to a particle system, the force field will operate only on that system.\n\nIf specific particle systems are assigned, then the force field will operate on those systems only, even if attached to a particle system.")]
		public List<ParticleSystem> _particleSystems;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int particleSystemsCount;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<ParticleSystem> particleSystems;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ParticleSystem.Particle[][] particleSystemParticles;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ParticleSystem.MainModule[] particleSystemMainModules;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Renderer[] particleSystemRenderers;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected ParticleSystem currentParticleSystem;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected GetForceParameters parameters;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[Tooltip("If TRUE, update even if target particle system(s) are invisible/offscreen.\n\nIf FALSE, update only if particles of the target system(s) are visible/onscreen.")]
		public bool alwaysUpdate;

		[Token(Token = "0x1700004E")]
		public float scaledRadius
		{
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x911430", Offset = "0x911430", VA = "0x911430")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x90E288", Offset = "0x90E288", VA = "0x90E288", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x90E290", Offset = "0x90E290", VA = "0x90E290", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x911464", Offset = "0x911464", VA = "0x911464", Slot = "6")]
		protected virtual void PerParticleSystemSetup()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x911468", Offset = "0x911468", VA = "0x911468", Slot = "7")]
		protected virtual Vector3 GetForce()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x90E2EC", Offset = "0x90E2EC", VA = "0x90E2EC", Slot = "8")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x9114AC", Offset = "0x9114AC", VA = "0x9114AC")]
		public void AddParticleSystem(ParticleSystem particleSystem)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x91155C", Offset = "0x91155C", VA = "0x91155C")]
		public void RemoveParticleSystem(ParticleSystem particleSystem)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x90E32C", Offset = "0x90E32C", VA = "0x90E32C", Slot = "9")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x9115B4", Offset = "0x9115B4", VA = "0x9115B4")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x90F3F8", Offset = "0x90F3F8", VA = "0x90F3F8", Slot = "10")]
		protected virtual void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x90F48C", Offset = "0x90F48C", VA = "0x90F48C")]
		protected ParticleForceField()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	[AddComponentMenu("Effects/Particle Force Fields/Turbulence Particle Force Field")]
	public class TurbulenceParticleForceField : ParticleForceField
	{
		[Token(Token = "0x20000CC")]
		public enum NoiseType
		{
			[Token(Token = "0x400042F")]
			PseudoPerlin,
			[Token(Token = "0x4000430")]
			Perlin,
			[Token(Token = "0x4000431")]
			Simplex,
			[Token(Token = "0x4000432")]
			OctavePerlin,
			[Token(Token = "0x4000433")]
			OctaveSimplex
		}

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[Tooltip("Noise texture mutation speed.")]
		[Header("ForceField Controls")]
		public float scrollSpeed;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Tooltip("Noise texture detail amplifier.")]
		[Range(0f, 8f)]
		public float frequency;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public NoiseType noiseType;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[Header("Octave Variant-Only Controls")]
		[Tooltip("Overlapping noise iterations. 1 = no additional iterations.")]
		[Range(1f, 8f)]
		public int octaves;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Range(0f, 4f)]
		[Tooltip("Frequency scale per-octave. Can be used to change the overlap every iteration.")]
		public float octaveMultiplier;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[Tooltip("Amplitude scale per-octave. Can be used to change the overlap every iteration.")]
		[Range(0f, 1f)]
		public float octaveScale;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float time;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float randomX;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float randomY;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float randomZ;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float offsetX;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private float offsetY;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float offsetZ;

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x9115B8", Offset = "0x9115B8", VA = "0x9115B8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x9115BC", Offset = "0x9115BC", VA = "0x9115BC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x911624", Offset = "0x911624", VA = "0x911624", Slot = "8")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x911640", Offset = "0x911640", VA = "0x911640", Slot = "9")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x91166C", Offset = "0x91166C", VA = "0x91166C", Slot = "7")]
		protected override Vector3 GetForce()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x911A5C", Offset = "0x911A5C", VA = "0x911A5C", Slot = "10")]
		protected override void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x911A84", Offset = "0x911A84", VA = "0x911A84")]
		public TurbulenceParticleForceField()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	[AddComponentMenu("Effects/Particle Force Fields/Vortex Particle Force Field")]
	public class VortexParticleForceField : ParticleForceField
	{
		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 axisOfRotation;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[Tooltip("Internal offset for the axis of rotation.\n\nUseful if the force field and particle system are on the same game object, and you need a seperate rotation for the system, and the affector, but don't want to make the two different game objects.")]
		[Header("ForceField Controls")]
		public Vector3 axisOfRotationOffset;

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x911AA0", Offset = "0x911AA0", VA = "0x911AA0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x911AA4", Offset = "0x911AA4", VA = "0x911AA4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x911AA8", Offset = "0x911AA8", VA = "0x911AA8", Slot = "8")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x911AAC", Offset = "0x911AAC", VA = "0x911AAC", Slot = "9")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x911AB0", Offset = "0x911AB0", VA = "0x911AB0")]
		private void UpdateAxisOfRotation()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x911B4C", Offset = "0x911B4C", VA = "0x911B4C", Slot = "6")]
		protected override void PerParticleSystemSetup()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x911B50", Offset = "0x911B50", VA = "0x911B50", Slot = "7")]
		protected override Vector3 GetForce()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x911C58", Offset = "0x911C58", VA = "0x911C58", Slot = "10")]
		protected override void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x911DCC", Offset = "0x911DCC", VA = "0x911DCC")]
		public VortexParticleForceField()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CE")]
	[RequireComponent(typeof(ParticleSystem))]
	public class ParticleLights : MonoBehaviour
	{
		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ParticleSystem ps;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Light> lights;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float scale;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 8f)]
		public float intensity;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color colour;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float colourFromParticle;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public LightShadows shadows;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GameObject template;

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x911E28", Offset = "0x911E28", VA = "0x911E28")]
		private void Awake()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x911E2C", Offset = "0x911E2C", VA = "0x911E2C")]
		private void Start()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x911F2C", Offset = "0x911F2C", VA = "0x911F2C")]
		private void Update()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x911F30", Offset = "0x911F30", VA = "0x911F30")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x912418", Offset = "0x912418", VA = "0x912418")]
		public ParticleLights()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	[RequireComponent(typeof(ParticleSystem))]
	[AddComponentMenu("Effects/Particle Plexus")]
	public class ParticlePlexus : MonoBehaviour
	{
		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxDistance;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int maxConnections;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int maxLineRenderers;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		[Space]
		public float widthFromParticle;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Space]
		[Range(0f, 1f)]
		public float colourFromParticle;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float alphaFromParticle;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Space]
		public AnimationCurve alphaOverNormalizedDistance;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ParticleSystem particleSystem;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ParticleSystem.Particle[] particles;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] particlePositions;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Color[] particleColours;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float[] particleSizes;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ParticleSystem.MainModule particleSystemMainModule;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Space]
		public LineRenderer lineRendererTemplate;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<LineRenderer> lineRenderers;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Transform _transform;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Header("Triangle Mesh Settings")]
		public MeshFilter trianglesMeshFilter;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Mesh trianglesMesh;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<int[]> allConnectedParticles;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[Space]
		[Range(0f, 1f)]
		public float maxDistanceTriangleBias;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[Space]
		public bool trianglesDistanceCheck;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Range(0f, 1f)]
		[Space]
		public float triangleColourFromParticle;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[Range(0f, 1f)]
		public float triangleAlphaFromParticle;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[Range(0f, 1f)]
		[Header("General Performance Settings")]
		public float delay;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private float timer;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool alwaysUpdate;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		private bool visible;

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x9124BC", Offset = "0x9124BC", VA = "0x9124BC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x9125F4", Offset = "0x9125F4", VA = "0x9125F4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x912684", Offset = "0x912684", VA = "0x912684")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x912690", Offset = "0x912690", VA = "0x912690")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x912698", Offset = "0x912698", VA = "0x912698")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x914128", Offset = "0x914128", VA = "0x914128")]
		public ParticlePlexus()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public static class CreateLUT
	{
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x91425C", Offset = "0x91425C", VA = "0x91425C")]
		public static void fromGradient(int steps, Gradient gradient, ref Texture2D texture)
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x914400", Offset = "0x914400", VA = "0x914400")]
		public static void fromAnimationCurve(int steps, AnimationCurve curve, ref Texture2D texture)
		{
		}
	}
}
namespace MirzaBeig.ParticleSystems
{
	[Token(Token = "0x20000D1")]
	[RequireComponent(typeof(Light))]
	public class AnimatedLight : MonoBehaviour
	{
		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Light light;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float duration;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool evaluating;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Gradient colourOverLifetime;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve intensityOverLifetime;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool loop;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool autoDestruct;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color startColour;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float startIntensity;

		[Token(Token = "0x1700004F")]
		public float time
		{
			[Token(Token = "0x6000427")]
			[Address(RVA = "0x9145D4", Offset = "0x9145D4", VA = "0x9145D4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000428")]
			[Address(RVA = "0x9145DC", Offset = "0x9145DC", VA = "0x9145DC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x9145E4", Offset = "0x9145E4", VA = "0x9145E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x91463C", Offset = "0x91463C", VA = "0x91463C")]
		private void Start()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x914700", Offset = "0x914700", VA = "0x914700")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x914704", Offset = "0x914704", VA = "0x914704")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x9147D4", Offset = "0x9147D4", VA = "0x9147D4")]
		private void Update()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x914950", Offset = "0x914950", VA = "0x914950")]
		public AnimatedLight()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class Billboard : MonoBehaviour
	{
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x914AFC", Offset = "0x914AFC", VA = "0x914AFC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x914B44", Offset = "0x914B44", VA = "0x914B44")]
		public Billboard()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class DestroyAfterTime : MonoBehaviour
	{
		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float time;

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x914B4C", Offset = "0x914B4C", VA = "0x914B4C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x914BC8", Offset = "0x914BC8", VA = "0x914BC8")]
		public DestroyAfterTime()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class DestroyOnParticlesDead : ParticleSystems
	{
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x914BD8", Offset = "0x914BD8", VA = "0x914BD8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x914C34", Offset = "0x914C34", VA = "0x914C34", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x914C3C", Offset = "0x914C3C", VA = "0x914C3C")]
		private void onParticleSystemsDead()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x914CA8", Offset = "0x914CA8", VA = "0x914CA8", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x914CB0", Offset = "0x914CB0", VA = "0x914CB0", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x914CB8", Offset = "0x914CB8", VA = "0x914CB8")]
		public DestroyOnParticlesDead()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class DestroyOnTrailsDestroyed : TrailRenderers
	{
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x914CC8", Offset = "0x914CC8", VA = "0x914CC8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x914CD0", Offset = "0x914CD0", VA = "0x914CD0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x914D2C", Offset = "0x914D2C", VA = "0x914D2C", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x914E14", Offset = "0x914E14", VA = "0x914E14")]
		public DestroyOnTrailsDestroyed()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class ParticleSystems : MonoBehaviour
	{
		[Token(Token = "0x17000050")]
		public ParticleSystem[] particleSystems
		{
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x914E24", Offset = "0x914E24", VA = "0x914E24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600043E")]
			[Address(RVA = "0x914E2C", Offset = "0x914E2C", VA = "0x914E2C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x914BDC", Offset = "0x914BDC", VA = "0x914BDC", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x914C38", Offset = "0x914C38", VA = "0x914C38", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x914CAC", Offset = "0x914CAC", VA = "0x914CAC", Slot = "6")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x914CB4", Offset = "0x914CB4", VA = "0x914CB4", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x914E34", Offset = "0x914E34", VA = "0x914E34")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x914E98", Offset = "0x914E98", VA = "0x914E98")]
		public void Play()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x914EFC", Offset = "0x914EFC", VA = "0x914EFC")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x914F60", Offset = "0x914F60", VA = "0x914F60")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x914FC4", Offset = "0x914FC4", VA = "0x914FC4")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x915028", Offset = "0x915028", VA = "0x915028")]
		public void SetLoop(bool loop)
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x9150AC", Offset = "0x9150AC", VA = "0x9150AC")]
		public void SetPlaybackSpeed(float speed)
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x915138", Offset = "0x915138", VA = "0x915138")]
		public void Simulate(float time, bool reset = false)
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x9151B4", Offset = "0x9151B4", VA = "0x9151B4")]
		public bool IsAlive()
		{
			return default(bool);
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x91528C", Offset = "0x91528C", VA = "0x91528C")]
		public bool IsPlaying(bool checkAll = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x9152D4", Offset = "0x9152D4", VA = "0x9152D4")]
		public int GetParticleCount()
		{
			return default(int);
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x914CC0", Offset = "0x914CC0", VA = "0x914CC0")]
		public ParticleSystems()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D7")]
	public class PerlinNoise
	{
		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Vector2 offset;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float amplitude;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float frequency;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool unscaledTime;

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x9153B0", Offset = "0x9153B0", VA = "0x9153B0")]
		public void init()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x915400", Offset = "0x915400", VA = "0x915400")]
		public float GetValue(float time)
		{
			return default(float);
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x91543C", Offset = "0x91543C", VA = "0x91543C")]
		public PerlinNoise()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D8")]
	public class PerlinNoiseXYZ
	{
		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PerlinNoise x;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PerlinNoise y;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PerlinNoise z;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool unscaledTime;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float amplitudeScale;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float frequencyScale;

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x91544C", Offset = "0x91544C", VA = "0x91544C")]
		public void init()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x915530", Offset = "0x915530", VA = "0x915530")]
		public Vector3 GetXYZ(float time)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x91560C", Offset = "0x91560C", VA = "0x91560C")]
		public PerlinNoiseXYZ()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Renderer))]
	public class RendererSortingOrder : MonoBehaviour
	{
		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int sortingOrder;

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x91561C", Offset = "0x91561C", VA = "0x91561C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x915620", Offset = "0x915620", VA = "0x915620")]
		private void Start()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x91567C", Offset = "0x91567C", VA = "0x91567C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x915680", Offset = "0x915680", VA = "0x915680")]
		public RendererSortingOrder()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class Rotator : MonoBehaviour
	{
		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 localRotationSpeed;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 worldRotationSpeed;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool executeInEditMode;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool unscaledTime;

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x915688", Offset = "0x915688", VA = "0x915688")]
		private void Awake()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x91568C", Offset = "0x91568C", VA = "0x91568C")]
		private void Start()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x915690", Offset = "0x915690", VA = "0x915690")]
		private void OnRenderObject()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x915850", Offset = "0x915850", VA = "0x915850")]
		private void Update()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x9156C0", Offset = "0x9156C0", VA = "0x9156C0")]
		private void rotate()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x915878", Offset = "0x915878", VA = "0x915878")]
		public Rotator()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class TrailRenderers : MonoBehaviour
	{
		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public TrailRenderer[] trailRenderers;

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x914CCC", Offset = "0x914CCC", VA = "0x914CCC", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x914CD4", Offset = "0x914CD4", VA = "0x914CD4", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x914E10", Offset = "0x914E10", VA = "0x914E10", Slot = "6")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x915880", Offset = "0x915880", VA = "0x915880")]
		public void setAutoDestruct(bool value)
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x914E1C", Offset = "0x914E1C", VA = "0x914E1C")]
		public TrailRenderers()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class TransformNoise : MonoBehaviour
	{
		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PerlinNoiseXYZ positionNoise;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PerlinNoiseXYZ rotationNoise;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool unscaledTime;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float time;

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x9158E8", Offset = "0x9158E8", VA = "0x9158E8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x915910", Offset = "0x915910", VA = "0x915910")]
		private void Update()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x9159B0", Offset = "0x9159B0", VA = "0x9159B0")]
		public TransformNoise()
		{
		}
	}
}
namespace MirzaBeig.ParticleSystems.Demos
{
	[Serializable]
	[Token(Token = "0x20000DD")]
	public class DemoManager_XPTitles : MonoBehaviour
	{
		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private LoopingParticleSystemsManager list;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text particleCountText;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Text currentParticleSystemText;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rotator cameraRotator;

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x9159B8", Offset = "0x9159B8", VA = "0x9159B8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x915C30", Offset = "0x915C30", VA = "0x915C30")]
		private void Start()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x915D3C", Offset = "0x915D3C", VA = "0x915D3C")]
		public void ToggleRotation()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x915D70", Offset = "0x915D70", VA = "0x915D70")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x915DE0", Offset = "0x915DE0", VA = "0x915DE0")]
		private void Update()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x915EC0", Offset = "0x915EC0", VA = "0x915EC0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x915E68", Offset = "0x915E68", VA = "0x915E68")]
		public void Next()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x915E94", Offset = "0x915E94", VA = "0x915E94")]
		public void previous()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x915C9C", Offset = "0x915C9C", VA = "0x915C9C")]
		private void updateCurrentParticleSystemNameText()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x9163B8", Offset = "0x9163B8", VA = "0x9163B8")]
		public DemoManager_XPTitles()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public enum CameraShakeTarget
	{
		[Token(Token = "0x400047E")]
		Position,
		[Token(Token = "0x400047F")]
		Rotation
	}
	[Token(Token = "0x20000DF")]
	public enum CameraShakeAmplitudeCurve
	{
		[Token(Token = "0x4000481")]
		Constant,
		[Token(Token = "0x4000482")]
		FadeInOut25,
		[Token(Token = "0x4000483")]
		FadeInOut50,
		[Token(Token = "0x4000484")]
		FadeInOut75
	}
	[Token(Token = "0x20000E0")]
	public enum CameraShakeAmplitudeOverDistanceCurve
	{
		[Token(Token = "0x4000486")]
		Constant,
		[Token(Token = "0x4000487")]
		LinearFadeIn,
		[Token(Token = "0x4000488")]
		LinearFadeOut
	}
	[Token(Token = "0x20000E1")]
	public class CameraShake : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E2")]
		public class Shake
		{
			[Token(Token = "0x400048F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float amplitude;

			[Token(Token = "0x4000490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float frequency;

			[Token(Token = "0x4000491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float duration;

			[Token(Token = "0x4000492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[HideInInspector]
			public CameraShakeTarget target;

			[Token(Token = "0x4000493")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private float timeRemaining;

			[Token(Token = "0x4000494")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Vector2 perlinNoiseX;

			[Token(Token = "0x4000495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Vector2 perlinNoiseY;

			[Token(Token = "0x4000496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector2 perlinNoiseZ;

			[Token(Token = "0x4000497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[HideInInspector]
			public Vector3 noise;

			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public AnimationCurve amplitudeOverLifetimeCurve;

			[Token(Token = "0x6000476")]
			[Address(RVA = "0x917340", Offset = "0x917340", VA = "0x917340")]
			public void Init()
			{
			}

			[Token(Token = "0x6000477")]
			[Address(RVA = "0x9173EC", Offset = "0x9173EC", VA = "0x9173EC")]
			private void Init(float amplitude, float frequency, float duration, CameraShakeTarget target)
			{
			}

			[Token(Token = "0x6000478")]
			[Address(RVA = "0x91734C", Offset = "0x91734C", VA = "0x91734C")]
			public void ApplyRandomSeed()
			{
			}

			[Token(Token = "0x6000479")]
			[Address(RVA = "0x9164E4", Offset = "0x9164E4", VA = "0x9164E4")]
			public Shake(float amplitude, float frequency, float duration, CameraShakeTarget target, AnimationCurve amplitudeOverLifetimeCurve)
			{
			}

			[Token(Token = "0x600047A")]
			[Address(RVA = "0x9167A8", Offset = "0x9167A8", VA = "0x9167A8")]
			public Shake(float amplitude, float frequency, float duration, CameraShakeTarget target, CameraShakeAmplitudeCurve amplitudeOverLifetimeCurve)
			{
			}

			[Token(Token = "0x600047B")]
			[Address(RVA = "0x917400", Offset = "0x917400", VA = "0x917400")]
			public bool IsAlive()
			{
				return default(bool);
			}

			[Token(Token = "0x600047C")]
			[Address(RVA = "0x9171B4", Offset = "0x9171B4", VA = "0x9171B4")]
			public void Update()
			{
			}
		}

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float smoothDampTime;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 smoothDampPositionVelocity;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float smoothDampRotationVelocityX;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float smoothDampRotationVelocityY;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float smoothDampRotationVelocityZ;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Shake> shakes;

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x9163C0", Offset = "0x9163C0", VA = "0x9163C0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x9163C4", Offset = "0x9163C4", VA = "0x9163C4")]
		public void Add(float amplitude, float frequency, float duration, CameraShakeTarget target, AnimationCurve amplitudeOverLifetimeCurve)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x916688", Offset = "0x916688", VA = "0x916688")]
		public void Add(float amplitude, float frequency, float duration, CameraShakeTarget target, CameraShakeAmplitudeCurve amplitudeOverLifetimeCurve)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x916CF4", Offset = "0x916CF4", VA = "0x916CF4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x9172AC", Offset = "0x9172AC", VA = "0x9172AC")]
		public CameraShake()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class DemoManager : MonoBehaviour
	{
		[Token(Token = "0x20000E5")]
		public enum ParticleMode
		{
			[Token(Token = "0x40004C1")]
			looping,
			[Token(Token = "0x40004C2")]
			oneshot
		}

		[Token(Token = "0x20000E6")]
		public enum Level
		{
			[Token(Token = "0x40004C4")]
			none,
			[Token(Token = "0x40004C5")]
			basic
		}

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform cameraRotationTransform;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTranslationTransform;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 cameraLookAtPosition;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MouseFollow mouse;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 targetCameraPosition;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 targetCameraRotation;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 cameraPositionStart;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3 cameraRotationStart;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector2 input;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 cameraRotation;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float cameraMoveAmount;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float cameraRotateAmount;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float cameraMoveSpeed;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float cameraRotationSpeed;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public Vector2 cameraAngleLimits;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public GameObject[] levels;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Level currentLevel;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public ParticleMode particleMode;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool advancedRendering;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Toggle loopingParticleModeToggle;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Toggle oneshotParticleModeToggle;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Toggle advancedRenderingToggle;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Toggle mouseParticlesToggle;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Toggle[] levelToggles;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public ToggleGroup levelTogglesContainer;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private LoopingParticleSystemsManager loopingParticleSystems;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private OneshotParticleSystemsManager oneshotParticleSystems;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public GameObject ui;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Text particleCountText;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public Text currentParticleSystemText;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Text particleSpawnInstructionText;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public Slider timeScaleSlider;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public Text timeScaleSliderValueText;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public Camera mainCamera;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public MonoBehaviour[] mainCameraPostEffects;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Vector3 cameraPositionSmoothDampVelocity;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private Vector3 cameraRotationSmoothDampVelocity;

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x9174A8", Offset = "0x9174A8", VA = "0x9174A8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x91756C", Offset = "0x91756C", VA = "0x91756C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x917B1C", Offset = "0x917B1C", VA = "0x917B1C")]
		public void OnTimeScaleSliderValueChanged(float value)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x917898", Offset = "0x917898", VA = "0x917898")]
		public void SetToLoopingParticleMode(bool set)
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x91792C", Offset = "0x91792C", VA = "0x91792C")]
		public void SetToOneshotParticleMode(bool set)
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x917D10", Offset = "0x917D10", VA = "0x917D10")]
		public void SetLevel(Level level)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x917D80", Offset = "0x917D80", VA = "0x917D80")]
		public void SetLevelFromToggle(Toggle toggle)
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x9179C4", Offset = "0x9179C4", VA = "0x9179C4")]
		public void SetAdvancedRendering(bool value)
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x917DF8", Offset = "0x917DF8", VA = "0x917DF8")]
		public void SetMouseParticlesRendering(bool value)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x917E28", Offset = "0x917E28", VA = "0x917E28")]
		public static Vector3 DampVector3(Vector3 from, Vector3 to, float speed, float dt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x917EA8", Offset = "0x917EA8", VA = "0x917EA8")]
		private void Update()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x918780", Offset = "0x918780", VA = "0x918780")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x917874", Offset = "0x917874", VA = "0x917874")]
		private void ResetCameraTransformTargets()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x917AB8", Offset = "0x917AB8", VA = "0x917AB8")]
		private void UpdateCurrentParticleSystemNameText()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x91838C", Offset = "0x91838C", VA = "0x91838C")]
		public void Next()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x9183D0", Offset = "0x9183D0", VA = "0x9183D0")]
		public void Previous()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x91888C", Offset = "0x91888C", VA = "0x91888C")]
		public DemoManager()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class FPSDisplay : MonoBehaviour
	{
		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float timer;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float updateTime;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int frameCount;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float fpsAccum;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Text fpsText;

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x9188C8", Offset = "0x9188C8", VA = "0x9188C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x9188CC", Offset = "0x9188CC", VA = "0x9188CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x918924", Offset = "0x918924", VA = "0x918924")]
		private void Update()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x918AD8", Offset = "0x918AD8", VA = "0x918AD8")]
		public FPSDisplay()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class FPSTest : MonoBehaviour
	{
		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int targetFPS1;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int targetFPS2;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int previousVSyncCount;

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x918AE8", Offset = "0x918AE8", VA = "0x918AE8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x918AEC", Offset = "0x918AEC", VA = "0x918AEC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x918AF0", Offset = "0x918AF0", VA = "0x918AF0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x918B60", Offset = "0x918B60", VA = "0x918B60")]
		public FPSTest()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class LoopingParticleSystemsManager : ParticleManager
	{
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x918B74", Offset = "0x918B74", VA = "0x918B74", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x918B7C", Offset = "0x918B7C", VA = "0x918B7C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x918C20", Offset = "0x918C20", VA = "0x918C20", Slot = "6")]
		public override void Next()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x918D50", Offset = "0x918D50", VA = "0x918D50", Slot = "7")]
		public override void Previous()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x918E7C", Offset = "0x918E7C", VA = "0x918E7C", Slot = "9")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x918E84", Offset = "0x918E84", VA = "0x918E84", Slot = "8")]
		public override int GetParticleCount()
		{
			return default(int);
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x918F38", Offset = "0x918F38", VA = "0x918F38")]
		public LoopingParticleSystemsManager()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class MouseFollow : MonoBehaviour
	{
		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float speed;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float distanceFromCamera;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool ignoreTimeScale;

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x918F68", Offset = "0x918F68", VA = "0x918F68")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x918F6C", Offset = "0x918F6C", VA = "0x918F6C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x918F70", Offset = "0x918F70", VA = "0x918F70")]
		private void Update()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x919080", Offset = "0x919080", VA = "0x919080")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x919084", Offset = "0x919084", VA = "0x919084")]
		public MouseFollow()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class OneshotParticleSystemsManager : ParticleManager
	{
		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask mouseRaycastLayerMask;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<ParticleSystem[]> spawnedPrefabs;

		[Token(Token = "0x17000051")]
		public bool disableSpawn
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x919098", Offset = "0x919098", VA = "0x919098")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x9190A0", Offset = "0x9190A0", VA = "0x9190A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x9190AC", Offset = "0x9190AC", VA = "0x9190AC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x9190B0", Offset = "0x9190B0", VA = "0x9190B0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x919140", Offset = "0x919140", VA = "0x919140")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x917BAC", Offset = "0x917BAC", VA = "0x917BAC")]
		public void Clear()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x919144", Offset = "0x919144", VA = "0x919144", Slot = "9")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x918414", Offset = "0x918414", VA = "0x918414")]
		public void InstantiateParticlePrefab(Vector2 mousePosition, float maxDistance)
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x919148", Offset = "0x919148", VA = "0x919148")]
		public void Randomize()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x9191A0", Offset = "0x9191A0", VA = "0x9191A0", Slot = "8")]
		public override int GetParticleCount()
		{
			return default(int);
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x919328", Offset = "0x919328", VA = "0x919328")]
		public OneshotParticleSystemsManager()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class ParticleManager : MonoBehaviour
	{
		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected List<ParticleSystem[]> particlePrefabs;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int currentParticlePrefabIndex;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int prefabNameUnderscoreCountCutoff;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool disableChildrenAtStart;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool initialized;

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x915A24", Offset = "0x915A24", VA = "0x915A24")]
		public void Init()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x918B78", Offset = "0x918B78", VA = "0x918B78", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x918C10", Offset = "0x918C10", VA = "0x918C10", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x918CEC", Offset = "0x918CEC", VA = "0x918CEC", Slot = "6")]
		public virtual void Next()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x918E1C", Offset = "0x918E1C", VA = "0x918E1C", Slot = "7")]
		public virtual void Previous()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x915FD4", Offset = "0x915FD4", VA = "0x915FD4")]
		public string GetCurrentPrefabName(bool shorten = false)
		{
			return null;
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x919360", Offset = "0x919360", VA = "0x919360", Slot = "8")]
		public virtual int GetParticleCount()
		{
			return default(int);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x918E80", Offset = "0x918E80", VA = "0x918E80", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x918F50", Offset = "0x918F50", VA = "0x918F50")]
		public ParticleManager()
		{
		}
	}
}
namespace MirzaBeig.Demos
{
	[Token(Token = "0x20000ED")]
	public class MouseRotateCamera : MonoBehaviour
	{
		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxRotation;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float speed;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool unscaledTime;

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x919368", Offset = "0x919368", VA = "0x919368")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x91936C", Offset = "0x91936C", VA = "0x91936C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x919370", Offset = "0x919370", VA = "0x919370")]
		private void Update()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x919374", Offset = "0x919374", VA = "0x919374")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x919544", Offset = "0x919544", VA = "0x919544")]
		public MouseRotateCamera()
		{
		}
	}
}
namespace MirzaBeig.Demos.Wallpapers
{
	[Token(Token = "0x20000EE")]
	public class GravityClockInteractivityUVFX : MonoBehaviour
	{
		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject forceAffectors;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject forceAffectors2;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem gravityClockPrefab;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParticleSystem gravityClock;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool enableGravityClockVisualEffects;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool enableGravityClockAttractionForce;

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x919558", Offset = "0x919558", VA = "0x919558")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x91955C", Offset = "0x91955C", VA = "0x91955C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x919560", Offset = "0x919560", VA = "0x919560")]
		private void Update()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x919564", Offset = "0x919564", VA = "0x919564")]
		public void SetGravityClockVisualEffectsActive(bool value)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x9196E8", Offset = "0x9196E8", VA = "0x9196E8")]
		public void SetGravityClockAttractionForceActive(bool value)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x919788", Offset = "0x919788", VA = "0x919788")]
		public GravityClockInteractivityUVFX()
		{
		}
	}
}
namespace MirzaBeig.Demos.ParticlePlayground
{
	[Token(Token = "0x20000EF")]
	public class BillboardCameraPlaneUVFX : MonoBehaviour
	{
		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform cameraTransform;

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x919798", Offset = "0x919798", VA = "0x919798")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x91979C", Offset = "0x91979C", VA = "0x91979C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x9197D0", Offset = "0x9197D0", VA = "0x9197D0")]
		private void Update()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x9197D4", Offset = "0x9197D4", VA = "0x9197D4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x919820", Offset = "0x919820", VA = "0x919820")]
		public BillboardCameraPlaneUVFX()
		{
		}
	}
}
namespace UnityStandardAssets.Utility
{
	[Serializable]
	[Token(Token = "0x20000F0")]
	public class CurveControlledBob
	{
		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float HorizontalBobRange;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float VerticalBobRange;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve Bobcurve;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float VerticaltoHorizontalRatio;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_CyclePositionX;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_CyclePositionY;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_BobBaseInterval;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_Time;

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x919828", Offset = "0x919828", VA = "0x919828")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x9198C8", Offset = "0x9198C8", VA = "0x9198C8")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x9199B8", Offset = "0x9199B8", VA = "0x9199B8")]
		public CurveControlledBob()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F1")]
	public class FOVKick
	{
		[Token(Token = "0x20000F2")]
		[CompilerGenerated]
		private sealed class <FOVKickUp>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000052")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004D5")]
				[Address(RVA = "0x919FC8", Offset = "0x919FC8", VA = "0x919FC8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000053")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004D7")]
				[Address(RVA = "0x91A010", Offset = "0x91A010", VA = "0x91A010", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x919DB0", Offset = "0x919DB0", VA = "0x919DB0")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x919E90", Offset = "0x919E90", VA = "0x919E90", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x919E94", Offset = "0x919E94", VA = "0x919E94", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x919FD0", Offset = "0x919FD0", VA = "0x919FD0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000F3")]
		[CompilerGenerated]
		private sealed class <FOVKickDown>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x40004F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000054")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004DB")]
				[Address(RVA = "0x91A164", Offset = "0x91A164", VA = "0x91A164", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000055")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004DD")]
				[Address(RVA = "0x91A1AC", Offset = "0x91A1AC", VA = "0x91A1AC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x919E4C", Offset = "0x919E4C", VA = "0x919E4C")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x91A018", Offset = "0x91A018", VA = "0x91A018", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x91A01C", Offset = "0x91A01C", VA = "0x91A01C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x91A16C", Offset = "0x91A16C", VA = "0x91A16C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public float originalFov;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float FOVIncrease;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float TimeToIncrease;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TimeToDecrease;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve IncreaseCurve;

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x919C04", Offset = "0x919C04", VA = "0x919C04")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x919C4C", Offset = "0x919C4C", VA = "0x919C4C")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x919D34", Offset = "0x919D34", VA = "0x919D34")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x919D3C", Offset = "0x919D3C", VA = "0x919D3C")]
		[IteratorStateMachine(typeof(<FOVKickUp>d__9))]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x919DD8", Offset = "0x919DD8", VA = "0x919DD8")]
		[IteratorStateMachine(typeof(<FOVKickDown>d__10))]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x919E74", Offset = "0x919E74", VA = "0x919E74")]
		public FOVKick()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F4")]
	public class LerpControlledBob
	{
		[Token(Token = "0x20000F5")]
		[CompilerGenerated]
		private sealed class <DoBobCycle>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LerpControlledBob <>4__this;

			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000056")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004E4")]
				[Address(RVA = "0x91A418", Offset = "0x91A418", VA = "0x91A418", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000057")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004E6")]
				[Address(RVA = "0x91A460", Offset = "0x91A460", VA = "0x91A460", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x91A230", Offset = "0x91A230", VA = "0x91A230")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x91A260", Offset = "0x91A260", VA = "0x91A260", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x91A264", Offset = "0x91A264", VA = "0x91A264", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x91A420", Offset = "0x91A420", VA = "0x91A420", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float BobDuration;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float BobAmount;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Offset;

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x91A1B4", Offset = "0x91A1B4", VA = "0x91A1B4")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x91A1BC", Offset = "0x91A1BC", VA = "0x91A1BC")]
		[IteratorStateMachine(typeof(<DoBobCycle>d__4))]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x91A258", Offset = "0x91A258", VA = "0x91A258")]
		public LerpControlledBob()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.FirstPerson
{
	[Token(Token = "0x20000F6")]
	[HelpURL("https://makaka.org/unity-assets")]
	[RequireComponent(typeof(AudioSource))]
	[RequireComponent(typeof(CharacterController))]
	public class FirstPersonController : MonoBehaviour
	{
		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_IsWalking;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_WalkSpeed;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_RunSpeed;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_RunstepLenghten;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_JumpSpeed;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_StickToGroundForce;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_GravityMultiplier;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MouseLook m_MouseLook;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_UseFovKick;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FOVKick m_FovKick;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool m_UseHeadBob;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CurveControlledBob m_HeadBob;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LerpControlledBob m_JumpBob;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_StepInterval;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AudioClip[] m_FootstepSounds;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AudioClip m_JumpSound;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AudioClip m_LandSound;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Camera m_Camera;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool m_Jump;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float m_YRotation;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector2 m_Input;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 m_MoveDir;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private CharacterController m_CharacterController;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private CollisionFlags m_CollisionFlags;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float m_StepCycle;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float m_NextStep;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private bool m_Jumping;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x91A468", Offset = "0x91A468", VA = "0x91A468")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x91A5EC", Offset = "0x91A5EC", VA = "0x91A5EC")]
		private void Update()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x91A72C", Offset = "0x91A72C", VA = "0x91A72C")]
		private void PlayLandingSound()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x91A774", Offset = "0x91A774", VA = "0x91A774")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x91AD80", Offset = "0x91AD80", VA = "0x91AD80")]
		private void PlayJumpSound()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x91ADB4", Offset = "0x91ADB4", VA = "0x91ADB4")]
		private void ProgressStepCycle(float speed)
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x91B154", Offset = "0x91B154", VA = "0x91B154")]
		private void PlayFootStepAudio()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x91AF04", Offset = "0x91AF04", VA = "0x91AF04")]
		private void UpdateCameraPosition(float speed)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x91AB74", Offset = "0x91AB74", VA = "0x91AB74")]
		private void GetInput(out float speed)
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x91A6DC", Offset = "0x91A6DC", VA = "0x91A6DC")]
		private void RotateView()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x91B608", Offset = "0x91B608", VA = "0x91B608")]
		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x91B72C", Offset = "0x91B72C", VA = "0x91B72C")]
		public FirstPersonController()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F7")]
	public class MouseLook
	{
		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float XSensitivity;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float YSensitivity;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool clampVerticalRotation;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float MinimumX;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float MaximumX;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool smooth;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float smoothTime;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion m_CharacterTargetRot;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion m_CameraTargetRot;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_cursorIsLocked;

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x91A59C", Offset = "0x91A59C", VA = "0x91A59C")]
		public void Init(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x91B2AC", Offset = "0x91B2AC", VA = "0x91B2AC")]
		public void LookRotation(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x91B8CC", Offset = "0x91B8CC", VA = "0x91B8CC")]
		public void SetCursorLock(bool value)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x91B144", Offset = "0x91B144", VA = "0x91B144")]
		public void UpdateCursorLock()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x91B900", Offset = "0x91B900", VA = "0x91B900")]
		private void InternalLockUpdate()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x91B868", Offset = "0x91B868", VA = "0x91B868")]
		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x91B978", Offset = "0x91B978", VA = "0x91B978")]
		public MouseLook()
		{
		}
	}
}
namespace EpicToonFX
{
	[Token(Token = "0x20000F8")]
	public class ETFXButtonScript : MonoBehaviour
	{
		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject Button;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Text MyButtonText;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string projectileParticleName;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ETFXFireProjectile effectScript;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ETFXProjectileScript projectileScript;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float buttonsX;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float buttonsY;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float buttonsSizeX;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float buttonsSizeY;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float buttonsDistance;

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x91B9AC", Offset = "0x91B9AC", VA = "0x91B9AC")]
		private void Start()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x91BB68", Offset = "0x91BB68", VA = "0x91BB68")]
		private void Update()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x91BAB4", Offset = "0x91BAB4", VA = "0x91BAB4")]
		public void getProjectileNames()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x91BB94", Offset = "0x91BB94", VA = "0x91BB94")]
		public bool overButton()
		{
			return default(bool);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x91BC6C", Offset = "0x91BC6C", VA = "0x91BC6C")]
		public ETFXButtonScript()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class ETFXFireProjectile : MonoBehaviour
	{
		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public GameObject[] projectiles;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Missile spawns at attached game object")]
		public Transform spawnPosition;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public int currentProjectile;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float speed;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ETFXButtonScript selectedProjectileButton;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RaycastHit hit;

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x91BC74", Offset = "0x91BC74", VA = "0x91BC74")]
		private void Start()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x91BCF0", Offset = "0x91BCF0", VA = "0x91BCF0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x91C0C0", Offset = "0x91C0C0", VA = "0x91C0C0")]
		public void nextEffect()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x91C0FC", Offset = "0x91C0FC", VA = "0x91C0FC")]
		public void previousEffect()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x91C138", Offset = "0x91C138", VA = "0x91C138")]
		public void AdjustSpeed(float newSpeed)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x91C140", Offset = "0x91C140", VA = "0x91C140")]
		public ETFXFireProjectile()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class ETFXLoopScript : MonoBehaviour
	{
		[Token(Token = "0x20000FB")]
		[CompilerGenerated]
		private sealed class <EffectLoop>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ETFXLoopScript <>4__this;

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private GameObject <effectPlayer>5__2;

			[Token(Token = "0x17000058")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600050C")]
				[Address(RVA = "0x91C4E8", Offset = "0x91C4E8", VA = "0x91C4E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000059")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600050E")]
				[Address(RVA = "0x91C530", Offset = "0x91C530", VA = "0x91C530", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000509")]
			[Address(RVA = "0x91C214", Offset = "0x91C214", VA = "0x91C214")]
			[DebuggerHidden]
			public <EffectLoop>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x600050A")]
			[Address(RVA = "0x91C254", Offset = "0x91C254", VA = "0x91C254", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600050B")]
			[Address(RVA = "0x91C258", Offset = "0x91C258", VA = "0x91C258", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600050D")]
			[Address(RVA = "0x91C4F0", Offset = "0x91C4F0", VA = "0x91C4F0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject chosenEffect;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float loopTimeLimit;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Header("Spawn without")]
		public bool spawnWithoutLight;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool spawnWithoutSound;

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x91C150", Offset = "0x91C150", VA = "0x91C150")]
		private void Start()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x91C154", Offset = "0x91C154", VA = "0x91C154")]
		public void PlayEffect()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x91C1A0", Offset = "0x91C1A0", VA = "0x91C1A0")]
		[IteratorStateMachine(typeof(<EffectLoop>d__6))]
		private IEnumerator EffectLoop()
		{
			return null;
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x91C23C", Offset = "0x91C23C", VA = "0x91C23C")]
		public ETFXLoopScript()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class ETFXMouseOrbit : MonoBehaviour
	{
		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float distance;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float xSpeed;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float ySpeed;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float yMinLimit;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float yMaxLimit;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float distanceMin;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float distanceMax;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float smoothTime;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float rotationYAxis;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float rotationXAxis;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float velocityX;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float velocityY;

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x91C538", Offset = "0x91C538", VA = "0x91C538")]
		private void Start()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x91C604", Offset = "0x91C604", VA = "0x91C604")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x91C980", Offset = "0x91C980", VA = "0x91C980")]
		public static float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x91C9BC", Offset = "0x91C9BC", VA = "0x91C9BC")]
		public ETFXMouseOrbit()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class ETFXTarget : MonoBehaviour
	{
		[Token(Token = "0x20000FE")]
		[CompilerGenerated]
		private sealed class <Respawn>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ETFXTarget <>4__this;

			[Token(Token = "0x1700005A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600051B")]
				[Address(RVA = "0x91CEB8", Offset = "0x91CEB8", VA = "0x91CEB8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600051D")]
				[Address(RVA = "0x91CF00", Offset = "0x91CF00", VA = "0x91CF00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000518")]
			[Address(RVA = "0x91CDD8", Offset = "0x91CDD8", VA = "0x91CDD8")]
			[DebuggerHidden]
			public <Respawn>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000519")]
			[Address(RVA = "0x91CE08", Offset = "0x91CE08", VA = "0x91CE08", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600051A")]
			[Address(RVA = "0x91CE0C", Offset = "0x91CE0C", VA = "0x91CE0C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600051C")]
			[Address(RVA = "0x91CEC0", Offset = "0x91CEC0", VA = "0x91CEC0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Effect shown on target hit")]
		public GameObject hitParticle;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Effect shown on target respawn")]
		public GameObject respawnParticle;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Renderer targetRenderer;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Collider targetCollider;

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x91C9D8", Offset = "0x91C9D8", VA = "0x91C9D8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x91CA68", Offset = "0x91CA68", VA = "0x91CA68")]
		private void SpawnTarget()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x91CB98", Offset = "0x91CB98", VA = "0x91CB98")]
		private void OnTriggerEnter(Collider col)
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x91CD64", Offset = "0x91CD64", VA = "0x91CD64")]
		[IteratorStateMachine(typeof(<Respawn>d__7))]
		private IEnumerator Respawn()
		{
			return null;
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x91CE00", Offset = "0x91CE00", VA = "0x91CE00")]
		public ETFXTarget()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class ETFXLightFade : MonoBehaviour
	{
		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Seconds to dim the light")]
		public float life;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool killAfterLife;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Light li;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float initIntensity;

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x91CF08", Offset = "0x91CF08", VA = "0x91CF08")]
		private void Start()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x91D024", Offset = "0x91D024", VA = "0x91D024")]
		private void Update()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x91D178", Offset = "0x91D178", VA = "0x91D178")]
		public ETFXLightFade()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class ETFXPitchRandomizer : MonoBehaviour
	{
		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float randomPercent;

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x91D194", Offset = "0x91D194", VA = "0x91D194")]
		private void Start()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x91D244", Offset = "0x91D244", VA = "0x91D244")]
		public ETFXPitchRandomizer()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class ETFXRotation : MonoBehaviour
	{
		[Token(Token = "0x2000102")]
		public enum spaceEnum
		{
			[Token(Token = "0x400055E")]
			Local,
			[Token(Token = "0x400055F")]
			World
		}

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Rotate axises by degrees per second")]
		public Vector3 rotateVector;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public spaceEnum rotateSpace;

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x91D254", Offset = "0x91D254", VA = "0x91D254")]
		private void Start()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x91D258", Offset = "0x91D258", VA = "0x91D258")]
		private void Update()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x91D32C", Offset = "0x91D32C", VA = "0x91D32C")]
		public ETFXRotation()
		{
		}
	}
}
namespace AutoHand
{
	[Token(Token = "0x2000103")]
	public class HandTouchButton : MonoBehaviour
	{
		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideIf("startUnpress")]
		public bool startPress;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[HideIf("startPress")]
		public bool startUnpress;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HandTouchEvent touchEvent;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform button;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 pressOffset;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color unpressColor;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Color pressColor;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool toggle;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Space]
		public UnityHandEvent OnPressed;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public UnityHandEvent OnUnpressed;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool pressed;

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x91D38C", Offset = "0x91D38C", VA = "0x91D38C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x91D56C", Offset = "0x91D56C", VA = "0x91D56C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x91D6D0", Offset = "0x91D6D0", VA = "0x91D6D0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x91D834", Offset = "0x91D834", VA = "0x91D834")]
		private void OnTouch(Autohand.Hand hand)
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x91D854", Offset = "0x91D854", VA = "0x91D854")]
		private void OnUntouch(Autohand.Hand hand)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x91D3B0", Offset = "0x91D3B0", VA = "0x91D3B0")]
		private void PressButton(Autohand.Hand hand)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x91D490", Offset = "0x91D490", VA = "0x91D490")]
		private void ReleaseButton(Autohand.Hand hand)
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x91D86C", Offset = "0x91D86C", VA = "0x91D86C")]
		public HandTouchButton()
		{
		}
	}
}
namespace Autohand
{
	[Token(Token = "0x2000104")]
	public class XRMover : MonoBehaviour
	{
		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("TEMP DEMO SCRIPT - Advanced script coming soon")]
		[Header("Controllers")]
		public XRHandControllerLink moverController;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public XRHandControllerLink turningController;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Common2DAxis moverAxis;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Body")]
		public GameObject cam;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CharacterController controller;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CapsuleCollider collisionCapsule;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Settings")]
		public bool snapTurning;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float turnAngle;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float speed;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float gravity;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float currentGravity;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool axisReset;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 moveAxis;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector2 turningAxis;

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x91D888", Offset = "0x91D888", VA = "0x91D888")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x91DC64", Offset = "0x91DC64", VA = "0x91DC64")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x91D8E4", Offset = "0x91D8E4", VA = "0x91D8E4")]
		public void Move(float x, float y, float z)
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x91D9F0", Offset = "0x91D9F0", VA = "0x91D9F0")]
		private void Turning()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x91DD08", Offset = "0x91DD08", VA = "0x91DD08")]
		public XRMover()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class AutoHeaderAttribute : PropertyAttribute
	{
		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int count;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int depth;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string label;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string tooltip;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string toggleBool;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Type type;

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x91DD24", Offset = "0x91DD24", VA = "0x91DD24")]
		public AutoHeaderAttribute(string label, int count = 0, int depth = 0)
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x91DD68", Offset = "0x91DD68", VA = "0x91DD68")]
		public AutoHeaderAttribute(string label, string tooltip, string toggleName, Type classType, int count = 0, int depth = 0)
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class AutoLineAttribute : PropertyAttribute
	{
		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int count;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int depth;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string tooltip;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string toggleBool;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Type type;

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x91DDC0", Offset = "0x91DDC0", VA = "0x91DDC0")]
		public AutoLineAttribute(int count = 0, int depth = 0)
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x91DDEC", Offset = "0x91DDEC", VA = "0x91DDEC")]
		public AutoLineAttribute(string tooltip, string toggleName, Type classType, int count = 0, int depth = 0)
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class AutoToggleHeaderAttribute : PropertyAttribute
	{
		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int count;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int depth;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string label;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string tooltip;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string toggleBool;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Type type;

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x91DE30", Offset = "0x91DE30", VA = "0x91DE30")]
		public AutoToggleHeaderAttribute(string label, int count = 0, int depth = 0)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x91DE74", Offset = "0x91DE74", VA = "0x91DE74")]
		public AutoToggleHeaderAttribute(string label, string tooltip, string toggleName, Type classType, int count = 0, int depth = 0)
		{
		}
	}
	[Token(Token = "0x2000108")]
	public static class AutoHandExtensions
	{
		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Transform _transformRuler;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Transform _transformRulerChild;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Transform _transformParent;

		[Token(Token = "0x1700005C")]
		public static Transform transformRuler
		{
			[Token(Token = "0x6000539")]
			[Address(RVA = "0x91DECC", Offset = "0x91DECC", VA = "0x91DECC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		public static Transform transformRulerChild
		{
			[Token(Token = "0x600053A")]
			[Address(RVA = "0x91E220", Offset = "0x91E220", VA = "0x91E220")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		public static Transform transformParent
		{
			[Token(Token = "0x600053B")]
			[Address(RVA = "0x91E108", Offset = "0x91E108", VA = "0x91E108")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x91E470", Offset = "0x91E470", VA = "0x91E470")]
		public static void RotateAround(this Transform target, Transform center, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x91E688", Offset = "0x91E688", VA = "0x91E688")]
		public static float Round(this float value, int digits)
		{
			return default(float);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x91E72C", Offset = "0x91E72C", VA = "0x91E72C")]
		public static bool HasGrabbable(this Hand hand, GameObject obj, out Grabbable grabbable)
		{
			return default(bool);
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x91E738", Offset = "0x91E738", VA = "0x91E738")]
		public static bool HasGrabbable(this GameObject obj, out Grabbable grabbable)
		{
			return default(bool);
		}

		[Token(Token = "0x6000540")]
		public static T GetCopyOf<T>(this Component comp, T other) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000541")]
		public static bool CanGetComponent<T>(this Component componentClass, out T component)
		{
			return default(bool);
		}

		[Token(Token = "0x6000542")]
		public static bool CanGetComponent<T>(this GameObject componentClass, out T component)
		{
			return default(bool);
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x91E834", Offset = "0x91E834", VA = "0x91E834")]
		public static LayerMask GetPhysicsLayerMask(int currentLayer)
		{
			return default(LayerMask);
		}
	}
	[Token(Token = "0x2000109")]
	public class PhysicsGadgetButton : PhysicsGadgetConfigurableLimitReader
	{
		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool pressed;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The percentage (0-1) from the required value needed to call the event, if threshold is 0.1 OnPressed will be called at 0.9, and OnUnpressed at 0.1")]
		[Min(0.01f)]
		public float threshold;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool lockOnPressed;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Space]
		public UnityEvent OnPressed;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UnityEvent OnUnpressed;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 startPos;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pressedPos;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float pressedValue;

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x91E89C", Offset = "0x91E89C", VA = "0x91E89C")]
		protected new void Start()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x91E9E0", Offset = "0x91E9E0", VA = "0x91E9E0")]
		protected void FixedUpdate()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x91EC48", Offset = "0x91EC48", VA = "0x91EC48")]
		public void Pressed()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x91ECA0", Offset = "0x91ECA0", VA = "0x91ECA0")]
		public void Unpressed()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x91ECBC", Offset = "0x91ECBC", VA = "0x91ECBC")]
		public void Unlock()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x91ED18", Offset = "0x91ED18", VA = "0x91ED18")]
		public PhysicsGadgetButton()
		{
		}
	}
	[Token(Token = "0x200010A")]
	[RequireComponent(typeof(ConfigurableJoint))]
	public class PhysicsGadgetConfigurableLimitReader : MonoBehaviour
	{
		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool invertValue;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("For objects slightly off center. \nThe minimum abs value required to return a value nonzero value\n - if playRange is 0.1, you have to move the gadget 10% to get a result")]
		public float playRange;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ConfigurableJoint joint;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Vector3 axisPos;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float value;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 limitAxis;

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x91E8D4", Offset = "0x91E8D4", VA = "0x91E8D4")]
		protected void Start()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x91EAD0", Offset = "0x91EAD0", VA = "0x91EAD0")]
		public float GetValue()
		{
			return default(float);
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x91ED38", Offset = "0x91ED38", VA = "0x91ED38")]
		public PhysicsGadgetConfigurableLimitReader()
		{
		}
	}
	[Token(Token = "0x200010B")]
	[RequireComponent(typeof(HingeJoint))]
	public class PhysicsGadgetHingeAngleReader : MonoBehaviour
	{
		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool invertValue;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("For objects slightly off center. \nThe minimum abs value required to return a value nonzero value\n - if playRange is 0.1, you have to move the gadget 10% to get a result")]
		public float playRange;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HingeJoint joint;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float value;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion startRot;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion deltaParentRotation;

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x91ED4C", Offset = "0x91ED4C", VA = "0x91ED4C")]
		protected void Start()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x91EDCC", Offset = "0x91EDCC", VA = "0x91EDCC")]
		public float GetValue()
		{
			return default(float);
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x91EEC4", Offset = "0x91EEC4", VA = "0x91EEC4")]
		public PhysicsGadgetHingeAngleReader()
		{
		}
	}
	[Token(Token = "0x200010C")]
	[RequireComponent(typeof(ConfigurableJoint))]
	public class PhysicsGadgetJoystick : MonoBehaviour
	{
		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ConfigurableJoint joint;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool invertX;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool invertY;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("For objects slightly off center. \nThe minimum abs value required to return a value nonzero value\n - if playRange is 0.1, you have to move the gadget 10% to get a result")]
		public float playRange;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector2 xRange;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector2 zRange;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector2 value;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 jointRotation;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Rigidbody body;

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x91EED8", Offset = "0x91EED8", VA = "0x91EED8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x91EF68", Offset = "0x91EF68", VA = "0x91EF68")]
		public void FixedUpdate()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x91F070", Offset = "0x91F070", VA = "0x91F070")]
		public Vector2 GetValue()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x91F0EC", Offset = "0x91F0EC", VA = "0x91F0EC")]
		public PhysicsGadgetJoystick()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class PhysicsGadgetLever : PhysicsGadgetHingeAngleReader
	{
		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The percentage (0-1) from the required value needed to call the event, if threshold is 0.1 OnMax will be called at 0.9, OnMin at -0.9, and OnMiddle at -0.1 or 0.1")]
		[Min(0.01f)]
		public float threshold;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityEvent OnMax;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UnityEvent OnMid;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public UnityEvent OnMin;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool min;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool max;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool mid;

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x91F100", Offset = "0x91F100", VA = "0x91F100")]
		protected void FixedUpdate()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x91F220", Offset = "0x91F220", VA = "0x91F220")]
		private void Max()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x91F264", Offset = "0x91F264", VA = "0x91F264")]
		private void Mid()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x91F240", Offset = "0x91F240", VA = "0x91F240")]
		private void Min()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x91F288", Offset = "0x91F288", VA = "0x91F288")]
		public PhysicsGadgetLever()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class PhysicsGadgetSlider : PhysicsGadgetConfigurableLimitReader
	{
		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Min(0.01f)]
		[Tooltip("The percentage (0-1) from the required value needed to call the event, if threshold is 0.1 OnMax will be called at 0.9, OnMin at -0.9, and OnMiddle at -0.1 or 0.1")]
		public float threshold;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UnityEvent OnMax;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityEvent OnMid;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UnityEvent OnMin;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool min;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool max;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool mid;

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x91F2A8", Offset = "0x91F2A8", VA = "0x91F2A8")]
		protected void FixedUpdate()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x91F3C8", Offset = "0x91F3C8", VA = "0x91F3C8")]
		private void Max()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x91F40C", Offset = "0x91F40C", VA = "0x91F40C")]
		private void Mid()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x91F3E8", Offset = "0x91F3E8", VA = "0x91F3E8")]
		private void Min()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x91F430", Offset = "0x91F430", VA = "0x91F430")]
		public PhysicsGadgetSlider()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public enum DistanceGrabType
	{
		[Token(Token = "0x40005B9")]
		Velocity,
		[Token(Token = "0x40005BA")]
		Linear
	}
	[Token(Token = "0x2000110")]
	[HelpURL("https://earnestrobot.notion.site/Distance-Grabbing-19e4e8b14f00428295eca75fca752787")]
	[RequireComponent(typeof(Grabbable))]
	public class DistanceGrabbable : MonoBehaviour
	{
		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AutoHeader("Distance Grabbable", 0, 0)]
		public bool ignoreMe;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[Header("Pull")]
		public bool instantPull;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public DistanceGrabType grabType;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[ShowIf("grabType", DistanceGrabType.Velocity)]
		[Range(0.4f, 1.1f)]
		[Tooltip("Use this to adjust the angle of the arch that the gameobject follows while shooting towards your hand.")]
		public float archMultiplier;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[ShowIf("grabType", DistanceGrabType.Velocity)]
		[Tooltip("Slow down or speed up gravitation to your liking.")]
		public float gravitationVelocity;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Rotation")]
		[Tooltip("This enables rotation which makes the gameobject orient to the rotation of you hand as it moves through the air. All below rotation variables have no use when this is false.")]
		[ShowIf("grabType", DistanceGrabType.Velocity)]
		public bool rotate;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Speed that the object orients to the rotation of your hand.")]
		[ShowIf("grabType", DistanceGrabType.Velocity)]
		public float rotationSpeed;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AutoToggleHeader("Enable Highlighting", 0, 0)]
		[Tooltip("Whether or not to ignore all highlights including default highlights on HandPointGrab")]
		public bool ignoreHighlights;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[EnableIf("ignoreHighlights")]
		[Tooltip("Highlight targeted material to use - defaults to HandPointGrab materials if none")]
		public Material targetedMaterial;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[EnableIf("ignoreHighlights")]
		[Tooltip("Highlight selected material to use - defaults to HandPointGrab materials if none")]
		public Material selectedMaterial;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AutoToggleHeader("Show Events", 0, 0)]
		public bool showEvents;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[ShowIf("showEvents")]
		public UnityHandGrabEvent OnPull;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[ShowIf("showEvents")]
		[Space]
		[Tooltip("Called when the object has been targeted/aimed at by the pointer")]
		public UnityHandGrabEvent StartTargeting;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[ShowIf("showEvents")]
		public UnityHandGrabEvent StopTargeting;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Space]
		[Tooltip("Called when the object has been selected before being pulled or flicked")]
		[ShowIf("showEvents")]
		public UnityHandGrabEvent StartSelecting;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[ShowIf("showEvents")]
		public UnityHandGrabEvent StopSelecting;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public HandGrabEvent OnPullCanceled;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal Grabbable grabbable;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform target;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 calculatedNecessaryVelocity;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool gravitationEnabled;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
		private bool gravitationMethodBegun;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9E")]
		private bool pullStarted;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody body;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float timePassedSincePull;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 lastGravitationVelocity;

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x91F458", Offset = "0x91F458", VA = "0x91F458")]
		private void Start()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x91F588", Offset = "0x91F588", VA = "0x91F588")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x91F70C", Offset = "0x91F70C", VA = "0x91F70C")]
		private void FollowHandRotation()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x91F7EC", Offset = "0x91F7EC", VA = "0x91F7EC")]
		private void GravitateTowardsHand()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x91F644", Offset = "0x91F644", VA = "0x91F644")]
		private void InitialVelocityPushToHand()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x91FA24", Offset = "0x91FA24", VA = "0x91FA24")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x91F9B4", Offset = "0x91F9B4", VA = "0x91F9B4")]
		private Vector3 CalculateTrajectoryVelocity(Vector3 origin, Vector3 target, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x91FA88", Offset = "0x91FA88", VA = "0x91FA88")]
		public void SetTarget(Transform theObject)
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x91FA64", Offset = "0x91FA64", VA = "0x91FA64")]
		public void CancelTarget()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x91FAAC", Offset = "0x91FAAC", VA = "0x91FAAC")]
		public DistanceGrabbable()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public enum HandGrabType
	{
		[Token(Token = "0x40005D6")]
		Default,
		[Token(Token = "0x40005D7")]
		HandToGrabbable,
		[Token(Token = "0x40005D8")]
		GrabbableToHand
	}
	[Token(Token = "0x2000112")]
	[HelpURL("https://earnestrobot.notion.site/Grabbables-9308c564e60848a882eb23e9778ee2b6")]
	[DefaultExecutionOrder(-2)]
	public class Grabbable : GrabbableBase
	{
		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[Tooltip("This will copy the given grabbables settings to this grabbable when applied")]
		[OnValueChanged("EditorCopyGrabbable")]
		public Grabbable CopySettings;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Tooltip("Whether or not this can be grabbed with more than one hand")]
		[Header("Grab Settings")]
		public bool singleHandOnly;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		[ShowIf("singleHandOnly")]
		[Tooltip("if false single handed items cannot be passes back and forth on grab")]
		public bool allowHeldSwapping;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDA")]
		[Tooltip("Will the item automatically return the hand on grab - good for saved poses, bad for heavy things")]
		public bool instantGrab;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDB")]
		[Tooltip("Experimental - ignores weight of held object while held")]
		public bool ignoreWeight;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[Tooltip("Creates an offset an grab so the hand will not return to the hand on grab - Good for statically jointed grabbable objects")]
		public bool maintainGrabOffset;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDD")]
		[Tooltip("This will NOT parent the object under the hands on grab. This will parent the object to the parents of the hand, which allow you to move the hand parent object smoothly while holding an item, but will also allow you to move items that are very heavy - recommended for all objects that aren't very heavy or jointed to other rigidbodies")]
		public bool parentOnGrab;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[FormerlySerializedAs("throwMultiplyer")]
		[Header("Release Settings")]
		[Tooltip("How much to multiply throw by for this grabbable when releasing - 0-1 for no or reduced throw strength")]
		public float throwPower;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[Tooltip("The required force to break the fixedJoint\n Turn this to \"infinity\" to disable (Might cause jitter)\nIdeal value depends on hand mass and velocity settings")]
		public float jointBreakForce;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AutoToggleHeader("Show Advanced", 0, 0)]
		public bool showAdvancedSettings;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[ShowIf("showAdvancedSettings")]
		[Tooltip("Which hand this can be held by")]
		public HandType handType;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[ShowIf("showAdvancedSettings")]
		[Tooltip("Which hand this can be held by")]
		public HandGrabType grabType;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[ShowIf("showAdvancedSettings")]
		[Tooltip("If true (and using HandToGrabbable) the hand will only return to the follow while moving. Good for picking up objects without disrupting the things around them")]
		public bool useGentleGrab;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF5")]
		[ShowIf("showAdvancedSettings")]
		[Tooltip("Adds and links a GrabbableChild to each child with a collider on start - So the hand can grab them")]
		public bool makeChildrenGrabbable;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF6")]
		[ShowIf("showAdvancedSettings")]
		[Tooltip("Whether or not the break call made only when holding with multiple hands - if this is false the break event can be called by forcing an object into a static collider")]
		public bool pullApartBreakOnly;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[Tooltip("The joint that connects the hand and the grabbable. Defaults to the joint in AutoHand/Resources/DefaultJoint.prefab if empty")]
		[Min(0f)]
		[Space]
		[ShowIf("showAdvancedSettings")]
		public ConfigurableJoint customGrabJoint;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[ShowIf("showAdvancedSettings")]
		[Tooltip("The number of seconds that the hand collision should ignore the released object\n (Good for increased placement precision and resolves clipping errors)")]
		[Min(0f)]
		public float ignoreReleaseTime;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[ShowIf("showAdvancedSettings")]
		[Min(0f)]
		[Tooltip("I.E. Grab Prioirty - BIGGER IS BETTER - divides highlight distance by this when calculating which object to grab. Hands always grab closest object to palm")]
		public float grabPriorityWeight;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[ShowIf("showAdvancedSettings")]
		[Tooltip("Offsets the grabbable by this much when being held")]
		public Vector3 heldPositionOffset;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[ShowIf("showAdvancedSettings")]
		[Tooltip("Offsets the grabbable by this many degrees when being held")]
		public Vector3 heldRotationOffset;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[Space]
		[ShowIf("showAdvancedSettings")]
		[Tooltip("For the special use case of having grabbable objects with physics jointed peices move properly while being held")]
		public List<Rigidbody> jointedBodies;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[ShowIf("showAdvancedSettings")]
		[Tooltip("For the special use case of having things connected to the grabbable that the hand should ignore while being held (good for doors and drawers) -> for always active use the [GrabbableIgnoreHands] Component")]
		public List<Collider> heldIgnoreColliders;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AutoToggleHeader("Show Events", 0, 0)]
		public bool showEvents;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[Space]
		[ShowIf("showEvents")]
		public UnityHandGrabEvent onGrab;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[ShowIf("showEvents")]
		public UnityHandGrabEvent onRelease;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[AutoToggleHeader("Show Advanced Events", 0, 0)]
		public bool showAdvancedEvents;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[Space]
		[ShowIf("showAdvancedEvents")]
		[Space]
		public UnityHandGrabEvent onSqueeze;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[ShowIf("showAdvancedEvents")]
		public UnityHandGrabEvent onUnsqueeze;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[ShowIf("showAdvancedEvents")]
		[Space]
		[Space]
		public UnityHandGrabEvent onHighlight;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[ShowIf("showAdvancedEvents")]
		public UnityHandGrabEvent onUnhighlight;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[ShowIf("showAdvancedEvents")]
		[Space]
		[Space]
		public UnityHandGrabEvent OnJointBreak;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[ShowIf("showAdvancedSettings")]
		[Tooltip("Lock hand in place on grab (This is a legacy setting, set hand kinematic on grab/release instead)")]
		[HideInInspector]
		public bool lockHandOnGrab;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public HandGrabEvent OnBeforeGrabEvent;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public HandGrabEvent OnGrabEvent;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public HandGrabEvent OnReleaseEvent;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public HandGrabEvent OnJointBreakEvent;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public HandGrabEvent OnSqueezeEvent;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public HandGrabEvent OnUnsqueezeEvent;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public HandGrabEvent OnHighlightEvent;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public HandGrabEvent OnUnhighlightEvent;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private List<Grabbable> jointedGrabbables;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private float lastUpdateTime;

		[Token(Token = "0x1700005F")]
		public float throwMultiplyer
		{
			[Token(Token = "0x6000569")]
			[Address(RVA = "0x91FAE4", Offset = "0x91FAE4", VA = "0x91FAE4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600056A")]
			[Address(RVA = "0x91FAEC", Offset = "0x91FAEC", VA = "0x91FAEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public bool wasForceReleased
		{
			[Token(Token = "0x600056B")]
			[Address(RVA = "0x91FAF4", Offset = "0x91FAF4", VA = "0x91FAF4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600056C")]
			[Address(RVA = "0x91FAFC", Offset = "0x91FAFC", VA = "0x91FAFC")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public Hand lastHeldBy
		{
			[Token(Token = "0x600056D")]
			[Address(RVA = "0x91FB08", Offset = "0x91FB08", VA = "0x91FB08")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600056E")]
			[Address(RVA = "0x91FB10", Offset = "0x91FB10", VA = "0x91FB10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x91FB20", Offset = "0x91FB20", VA = "0x91FB20", Slot = "8")]
		protected new virtual void Awake()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x91FDB0", Offset = "0x91FDB0", VA = "0x91FDB0", Slot = "9")]
		protected new virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x91FE2C", Offset = "0x91FE2C", VA = "0x91FE2C", Slot = "10")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x9209A0", Offset = "0x9209A0", VA = "0x9209A0", Slot = "11")]
		public virtual void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x920A78", Offset = "0x920A78", VA = "0x920A78", Slot = "12")]
		public virtual void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x920BA8", Offset = "0x920BA8", VA = "0x920BA8")]
		internal void IgnoreColliders(Collider bodyCapsule, bool ignore = true)
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x920CF4", Offset = "0x920CF4", VA = "0x920CF4", Slot = "13")]
		internal virtual void Highlight(Hand hand, [Optional] Material customMat)
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x921148", Offset = "0x921148", VA = "0x921148", Slot = "14")]
		internal virtual void Unhighlight(Hand hand)
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x921234", Offset = "0x921234", VA = "0x921234", Slot = "15")]
		internal virtual void OnSqueeze(Hand hand)
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x9212B8", Offset = "0x9212B8", VA = "0x9212B8", Slot = "16")]
		internal virtual void OnUnsqueeze(Hand hand)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x92133C", Offset = "0x92133C", VA = "0x92133C", Slot = "17")]
		internal virtual void OnBeforeGrab(Hand hand)
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x9213F8", Offset = "0x9213F8", VA = "0x9213F8", Slot = "18")]
		internal virtual void OnGrab(Hand hand)
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x921820", Offset = "0x921820", VA = "0x921820", Slot = "19")]
		public virtual bool CanGrab(HandBase hand)
		{
			return default(bool);
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x921898", Offset = "0x921898", VA = "0x921898", Slot = "20")]
		internal virtual void OnRelease(Hand hand)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x921B88", Offset = "0x921B88", VA = "0x921B88", Slot = "21")]
		internal virtual void BreakHandConnection(Hand hand)
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x921F94", Offset = "0x921F94", VA = "0x921F94", Slot = "22")]
		public virtual void HandsRelease()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x922028", Offset = "0x922028", VA = "0x922028", Slot = "23")]
		public virtual void HandRelease(Hand hand)
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x9220A8", Offset = "0x9220A8", VA = "0x9220A8", Slot = "24")]
		public virtual void ForceHandsRelease()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x922154", Offset = "0x922154", VA = "0x922154", Slot = "25")]
		public virtual void ForceHandRelease(Hand hand)
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x92223C", Offset = "0x92223C", VA = "0x92223C", Slot = "26")]
		public virtual void OnHandJointBreak(Hand hand)
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x9224E4", Offset = "0x9224E4", VA = "0x9224E4")]
		public Vector3 GetVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x92252C", Offset = "0x92252C", VA = "0x92252C")]
		public Vector3 GetAngularVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x922664", Offset = "0x922664", VA = "0x922664")]
		public List<Hand> GetHeldBy()
		{
			return null;
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x9208E8", Offset = "0x9208E8", VA = "0x9208E8")]
		public int HeldCount(bool includedJointedCount = true)
		{
			return default(int);
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x92266C", Offset = "0x92266C", VA = "0x92266C")]
		public bool IsHeld()
		{
			return default(bool);
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x9226BC", Offset = "0x9226BC", VA = "0x9226BC")]
		public bool BeingGrabbed()
		{
			return default(bool);
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x9226C4", Offset = "0x9226C4", VA = "0x9226C4")]
		public void PlayHapticVibration()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x922810", Offset = "0x922810", VA = "0x922810")]
		public void PlayHapticVibration(float duration = 0.025f)
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x92296C", Offset = "0x92296C", VA = "0x92296C")]
		public void PlayHapticVibration(float duration, float amp = 0.5f)
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x922AD0", Offset = "0x922AD0", VA = "0x922AD0", Slot = "27")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x922C3C", Offset = "0x922C3C", VA = "0x922C3C")]
		public void SetParentOnGrab(bool parentOnGrab)
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x922C48", Offset = "0x922C48", VA = "0x922C48")]
		public void AddJointedBody(Rigidbody body)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x922F0C", Offset = "0x922F0C", VA = "0x922F0C")]
		public void RemoveJointedBody(Rigidbody body)
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x9230BC", Offset = "0x9230BC", VA = "0x9230BC")]
		public void DoDestroy()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x920890", Offset = "0x920890", VA = "0x920890")]
		public int CollisionCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x923128", Offset = "0x923128", VA = "0x923128")]
		public int JointedCollisionCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x91FD38", Offset = "0x91FD38", VA = "0x91FD38")]
		private void MakeChildrenGrabbable()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x922BC4", Offset = "0x922BC4", VA = "0x922BC4")]
		private void MakeChildrenUngrabbable()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x921DF4", Offset = "0x921DF4", VA = "0x921DF4")]
		internal void ResetGrabbableAfterRlease()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x92350C", Offset = "0x92350C", VA = "0x92350C")]
		public Grabbable()
		{
		}
	}
	[Token(Token = "0x2000113")]
	[DefaultExecutionOrder(1)]
	public class GrabbableChild : MonoBehaviour
	{
		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Grabbable grabParent;

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x923794", Offset = "0x923794", VA = "0x923794")]
		private void Start()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x9238CC", Offset = "0x9238CC", VA = "0x9238CC")]
		public GrabbableChild()
		{
		}
	}
	[Token(Token = "0x2000114")]
	[RequireComponent(typeof(Grabbable))]
	public class GrabbableCollisionHaptics : MonoBehaviour
	{
		[Token(Token = "0x2000115")]
		[CompilerGenerated]
		private sealed class <PlayBuffer>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GrabbableCollisionHaptics <>4__this;

			[Token(Token = "0x17000062")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005A4")]
				[Address(RVA = "0x923EC0", Offset = "0x923EC0", VA = "0x923EC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000063")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005A6")]
				[Address(RVA = "0x923F08", Offset = "0x923F08", VA = "0x923F08", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x923D04", Offset = "0x923D04", VA = "0x923D04")]
			[DebuggerHidden]
			public <PlayBuffer>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x923DEC", Offset = "0x923DEC", VA = "0x923DEC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x923DF0", Offset = "0x923DF0", VA = "0x923DF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x923EC8", Offset = "0x923EC8", VA = "0x923EC8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000116")]
		[CompilerGenerated]
		private sealed class <HapticPlayBuffer>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GrabbableCollisionHaptics <>4__this;

			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float time;

			[Token(Token = "0x17000064")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005AA")]
				[Address(RVA = "0x923FE4", Offset = "0x923FE4", VA = "0x923FE4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000065")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005AC")]
				[Address(RVA = "0x92402C", Offset = "0x92402C", VA = "0x92402C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x923D2C", Offset = "0x923D2C", VA = "0x923D2C")]
			[DebuggerHidden]
			public <HapticPlayBuffer>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x923F10", Offset = "0x923F10", VA = "0x923F10", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x923F14", Offset = "0x923F14", VA = "0x923F14", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x923FEC", Offset = "0x923FEC", VA = "0x923FEC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The layers that cause the sound to play")]
		public LayerMask collisionTriggers;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float hapticAmp;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float velocityAmp;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float repeatDelay;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float maxDuration;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Source to play sound from")]
		public AnimationCurve velocityAmpCurve;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Source to play sound from")]
		public AnimationCurve velocityDurationCurve;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Grabbable grab;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Rigidbody body;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool canPlay;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine playRoutine;

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x9238D4", Offset = "0x9238D4", VA = "0x9238D4")]
		private void Start()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x923A04", Offset = "0x923A04", VA = "0x923A04")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x923A18", Offset = "0x923A18", VA = "0x923A18")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x923C90", Offset = "0x923C90", VA = "0x923C90")]
		[IteratorStateMachine(typeof(<PlayBuffer>d__14))]
		private IEnumerator PlayBuffer()
		{
			return null;
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x923980", Offset = "0x923980", VA = "0x923980")]
		[IteratorStateMachine(typeof(<HapticPlayBuffer>d__15))]
		private IEnumerator HapticPlayBuffer(float time)
		{
			return null;
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x923D54", Offset = "0x923D54", VA = "0x923D54")]
		public GrabbableCollisionHaptics()
		{
		}
	}
	[Token(Token = "0x2000117")]
	[RequireComponent(typeof(Grabbable))]
	public class GrabbableExtraEvents : MonoBehaviour
	{
		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityHandGrabEvent OnFirstGrab;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityHandGrabEvent OnLastRelease;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityHandGrabEvent OnTwoHandedGrab;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityHandGrabEvent OnTwoHandedRelease;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Grabbable grab;

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x924034", Offset = "0x924034", VA = "0x924034")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x9241DC", Offset = "0x9241DC", VA = "0x9241DC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x92438C", Offset = "0x92438C", VA = "0x92438C")]
		public void Grab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x924448", Offset = "0x924448", VA = "0x924448")]
		public void Release(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x924500", Offset = "0x924500", VA = "0x924500")]
		public GrabbableExtraEvents()
		{
		}
	}
	[Token(Token = "0x2000118")]
	[RequireComponent(typeof(Grabbable))]
	public class GrabbableOnlyJoint : MonoBehaviour
	{
		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Grabbable jointedGrabbable;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool resetOnRelease;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Grabbable localGrabbable;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Joint freezeJoint;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 localStartPosition;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion localStartRotation;

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x924508", Offset = "0x924508", VA = "0x924508")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x924904", Offset = "0x924904", VA = "0x924904")]
		private void OnGrab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x9249A8", Offset = "0x9249A8", VA = "0x9249A8")]
		private void OnRelease(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x924BB4", Offset = "0x924BB4", VA = "0x924BB4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x924D28", Offset = "0x924D28", VA = "0x924D28")]
		private void CreateJoint()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x924E98", Offset = "0x924E98", VA = "0x924E98")]
		public GrabbableOnlyJoint()
		{
		}
	}
	[Token(Token = "0x2000119")]
	[HelpURL("https://earnestrobot.notion.site/Custom-Poses-868c1fa0590542a0b5b7937b5feb6b0d")]
	public class GrabbablePose : MonoBehaviour
	{
		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AutoHeader("Grabbable Pose", 0, 0)]
		public bool ignoreMe;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool poseEnabled;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Purely for organizational purposes in the editor")]
		public string poseName;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("This value must match the pose index of the a hand in order for the pose to work")]
		public int poseIndex;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Whether or not this pose can be used by both hands at once or only one hand at a time")]
		public bool singleHanded;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AutoToggleHeader("Advanced Settings", 0, 0)]
		public bool showAdvanced;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float positionWeight;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rotationWeight;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("These poses will only be enabled when this pose is active. Great for secondary poses like holding the front of a gun with your second hand, only while holding the trigger")]
		public GrabbablePose[] linkedPoses;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public bool showEditorTools;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Scriptable options NOT REQUIRED -> Create scriptable throught [Auto Hand/Custom Pose]")]
		[HideInInspector]
		public HandPoseScriptable poseScriptable;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Used to pose for the grabbable")]
		[HideInInspector]
		public Hand editorHand;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public HandPoseData rightPose;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[HideInInspector]
		public bool rightPoseSet;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public HandPoseData leftPose;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[HideInInspector]
		public bool leftPoseSet;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private List<Hand> posingHands;

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x924EA8", Offset = "0x924EA8", VA = "0x924EA8", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x924EF8", Offset = "0x924EF8", VA = "0x924EF8")]
		public bool CanSetPose(Hand hand)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x924FB8", Offset = "0x924FB8", VA = "0x924FB8", Slot = "5")]
		public virtual HandPoseData GetHandPoseData(Hand hand)
		{
			return default(HandPoseData);
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x925080", Offset = "0x925080", VA = "0x925080", Slot = "6")]
		public virtual void SetHandPose(Hand hand, bool isProjection = false)
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x92521C", Offset = "0x92521C", VA = "0x92521C", Slot = "7")]
		public virtual void CancelHandPose(Hand hand)
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x9252E4", Offset = "0x9252E4", VA = "0x9252E4")]
		public HandPoseData GetNewPoseData(Hand hand)
		{
			return default(HandPoseData);
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x92579C", Offset = "0x92579C", VA = "0x92579C")]
		public bool HasPose(bool left)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x925850", Offset = "0x925850", VA = "0x925850")]
		public GrabbablePose()
		{
		}
	}
	[Token(Token = "0x200011B")]
	[HelpURL("https://earnestrobot.notion.site/Custom-Poses-868c1fa0590542a0b5b7937b5feb6b0d")]
	public class GrabbablePoseAdvanced : GrabbablePose
	{
		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Tooltip("Usually this can be left empty, used to create a different center point if the objects transform isn't ceneterd for the prefered rotation/movement axis")]
		public Transform centerObject;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Space]
		[Tooltip("You want this set so the disc gizmo is around the axis you want the hand to rotate, or that the line is straight through the axis you want to move")]
		public Vector3 up;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[Space]
		[Tooltip("Whether or not to automatically allow for the opposite direction pose to be automatically applied (I.E. Should I be able to grab my hammer only with the head facing up, or in both directions?)")]
		public bool useInvertPose;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[Space]
		[Tooltip("The minimum angle rotation around the included directions")]
		public int minAngle;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[Tooltip("The maximum angle rotation around the included directions")]
		public int maxAngle;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Space]
		[Tooltip("The minimum distance allowed from the saved posed along the included directions")]
		public float maxRange;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[Tooltip("The maximum distance allowed from the saved posed along the included directions")]
		public float minRange;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[Header("Requires Gizmos Enabled")]
		[Tooltip("Helps test pose by setting the angle of the editor hand, REQUIRES GIZMOS ENABLED")]
		public int testAngle;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[Tooltip("Helps test pose by setting the range position of the editor hand, REQUIRES GIZMOS ENABLED")]
		public float testRange;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int lastAngle;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private float lastRange;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 pregrabPos;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Quaternion pregrabRot;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Transform tempContainer;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Transform handMatch;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Transform getTransform;

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x925AA0", Offset = "0x925AA0", VA = "0x925AA0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x925ADC", Offset = "0x925ADC", VA = "0x925ADC", Slot = "5")]
		public override HandPoseData GetHandPoseData(Hand hand)
		{
			return default(HandPoseData);
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x925EB0", Offset = "0x925EB0", VA = "0x925EB0")]
		public Quaternion GetClosestRotation(Hand hand, Vector3 up, bool addInverse)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x926B48", Offset = "0x926B48", VA = "0x926B48")]
		public Vector3 GetClosestPosition(Vector3 up)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x926F34", Offset = "0x926F34", VA = "0x926F34")]
		public HandPoseData GetHandPoseData(Hand hand, int angle, float range)
		{
			return default(HandPoseData);
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x925E30", Offset = "0x925E30", VA = "0x925E30")]
		private Transform GetTransform()
		{
			return null;
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x927284", Offset = "0x927284", VA = "0x927284")]
		public GrabbablePoseAdvanced()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class GrabbablePoseCombiner : MonoBehaviour
	{
		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<GrabbablePose> poses;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HandPoseData pose;

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x9272E8", Offset = "0x9272E8", VA = "0x9272E8")]
		public bool CanSetPose(Hand hand)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x9274A0", Offset = "0x9274A0", VA = "0x9274A0")]
		public void AddPose(GrabbablePose pose)
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x927588", Offset = "0x927588", VA = "0x927588")]
		public GrabbablePose GetClosestPose(Hand hand)
		{
			return null;
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x927C08", Offset = "0x927C08", VA = "0x927C08")]
		internal int PoseCount()
		{
			return default(int);
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x927C50", Offset = "0x927C50", VA = "0x927C50")]
		public GrabbablePoseCombiner()
		{
		}
	}
	[Token(Token = "0x200011D")]
	[RequireComponent(typeof(Grabbable))]
	public class GrabbableSubstitute : MonoBehaviour
	{
		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Whether or not to disable this gameobject on grab")]
		public bool disableOnGrab;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[Tooltip("If true, the substitute will return to the this local location and turn off and the local grabbable will turn back on")]
		public bool returnOnRelease;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Grabbable grabbableSubstitute;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Grabbable localGrabbable;

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x927CD8", Offset = "0x927CD8", VA = "0x927CD8")]
		private void Start()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x927E78", Offset = "0x927E78", VA = "0x927E78")]
		private void OnGrabOriginal(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x928018", Offset = "0x928018", VA = "0x928018")]
		private void OnReleaseSub(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x928180", Offset = "0x928180", VA = "0x928180")]
		public void LocalSubstitute(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x9282FC", Offset = "0x9282FC", VA = "0x9282FC")]
		public GrabbableSubstitute()
		{
		}
	}
	[Token(Token = "0x200011E")]
	[RequireComponent(typeof(Rigidbody), typeof(Grabbable))]
	public class GrabbableThrowEvent : MonoBehaviour
	{
		[Token(Token = "0x200011F")]
		[CompilerGenerated]
		private sealed class <ResetThrown>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GrabbableThrowEvent <>4__this;

			[Token(Token = "0x17000066")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005DE")]
				[Address(RVA = "0x928980", Offset = "0x928980", VA = "0x928980", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000067")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005E0")]
				[Address(RVA = "0x9289C8", Offset = "0x9289C8", VA = "0x9289C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x9286B0", Offset = "0x9286B0", VA = "0x9286B0")]
			[DebuggerHidden]
			public <ResetThrown>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x9288B4", Offset = "0x9288B4", VA = "0x9288B4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x9288B8", Offset = "0x9288B8", VA = "0x9288B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x928988", Offset = "0x928988", VA = "0x928988", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The velocity magnitude required on collision to cause the break event")]
		public float breakVelocity;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The layers that will cause this grabbale to break")]
		public LayerMask collisionLayers;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEvent OnBreak;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody rb;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Grabbable grab;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool thrown;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine resetThrowing;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float throwTime;

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x92830C", Offset = "0x92830C", VA = "0x92830C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x92839C", Offset = "0x92839C", VA = "0x92839C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x928478", Offset = "0x928478", VA = "0x928478")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x928554", Offset = "0x928554", VA = "0x928554")]
		private void OnReleased(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x92863C", Offset = "0x92863C", VA = "0x92863C")]
		[IteratorStateMachine(typeof(<ResetThrown>d__12))]
		private IEnumerator ResetThrown()
		{
			return null;
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x9286D8", Offset = "0x9286D8", VA = "0x9286D8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x928860", Offset = "0x928860", VA = "0x928860")]
		private void Break()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x92887C", Offset = "0x92887C", VA = "0x92887C")]
		public GrabbableThrowEvent()
		{
		}
	}
	[Token(Token = "0x2000120")]
	[RequireComponent(typeof(Grabbable))]
	public class GrabLock : MonoBehaviour
	{
		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Hand.Released() must be called elsewhere")]
		[Header("Use this script to prevent grabbable release")]
		public UnityEvent OnGrabPressed;

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x9289D0", Offset = "0x9289D0", VA = "0x9289D0")]
		public GrabLock()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public delegate void PlacePointEvent(PlacePoint point, Grabbable grabbable);
	[Token(Token = "0x2000122")]
	[RequireComponent(typeof(SphereCollider))]
	[HelpURL("https://earnestrobot.notion.site/Place-Points-e6361a414928450dbb53d76fd653cf9a")]
	public class PlacePoint : MonoBehaviour
	{
		[Token(Token = "0x2000123")]
		[CompilerGenerated]
		private sealed class <HighlightSafetyCheck>d__47 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlacePoint <>4__this;

			[Token(Token = "0x1700006B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000600")]
				[Address(RVA = "0x92A27C", Offset = "0x92A27C", VA = "0x92A27C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000602")]
				[Address(RVA = "0x92A2C4", Offset = "0x92A2C4", VA = "0x92A2C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x928D24", Offset = "0x928D24", VA = "0x928D24")]
			[DebuggerHidden]
			public <HighlightSafetyCheck>d__47(int <>1__state)
			{
			}

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x92A150", Offset = "0x92A150", VA = "0x92A150", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x92A154", Offset = "0x92A154", VA = "0x92A154", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0x92A284", Offset = "0x92A284", VA = "0x92A284", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AutoHeader("Place Point", 0, 0)]
		public bool ignoreMe;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If used, the place point will only accept this grabbable as a target")]
		public Grabbable matchTarget;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Will allow placement for any grabbable with a name containing this array of strings, leave blank for any grabbable allowed")]
		public string[] placeNames;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The radius of the place point")]
		public float placeRadius;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("This will make the point place the object as soon as it enters the radius, instead of on release")]
		public bool forcePlace;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		[ShowIf("forcePlace")]
		[Tooltip("If true and will force release on place")]
		public bool forceHandRelease;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		[Tooltip("Whether or not the grabbable should be disabled on placement, (Good for things like placed keys)")]
		public bool disableGrabOnPlace;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		[Tooltip("Whether or not the grabbable should be disabled on placement")]
		public bool disableObjectOnPlace;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Whether or not the grabbable should be destroyed on placement, (Good for things like loaded magazines, combined with enabling static magazine)")]
		public bool destroyObjectOnPlace;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[Tooltip("Makes the object being placedObject kinematic")]
		[AutoToggleHeader("Use Kinematic", 0, 0)]
		public bool makePlacedKinematic;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The rigidbody to attach the placed grabbable to - leave empty means no joint")]
		[Space]
		[HideIf("makePlacedKinematic")]
		public Rigidbody placedJointLink;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideIf("makePlacedKinematic")]
		[FormerlySerializedAs("placedJointBreakForce")]
		public float jointBreakForce;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AutoToggleHeader("Show Advanced", 0, 0)]
		public bool showAdvanced;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[ShowIf("showAdvanced")]
		[Tooltip("Snaps an object to the point at start, leave empty for no target")]
		public Grabbable startPlaced;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[ShowIf("showAdvanced")]
		[Tooltip("The object will snap to this point instead of the place point on place")]
		public Transform placedOffset;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("This will make the point place the object as soon as it enters the radius, instead of on release")]
		[ShowIf("showAdvanced")]
		public bool parentOnPlace;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[ShowIf("showAdvanced")]
		[Tooltip("Whether or not to only allow placement of an object while it's being held (or released)")]
		public bool heldPlaceOnly;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[ShowIf("showAdvanced")]
		[Tooltip("Will prevent placement for any name containing this array of strings")]
		public string[] blacklistNames;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AutoToggleHeader("Show Events", 0, 0)]
		public bool showEvents;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[ShowIf("showEvents")]
		public UnityEvent OnPlace;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[ShowIf("showEvents")]
		public UnityEvent OnRemove;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[ShowIf("showEvents")]
		public UnityEvent OnHighlight;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[ShowIf("showEvents")]
		public UnityEvent OnStopHighlight;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public PlacePointEvent OnPlaceEvent;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public PlacePointEvent OnRemoveEvent;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public PlacePointEvent OnHighlightEvent;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public PlacePointEvent OnStopHighlightEvent;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		protected FixedJoint joint;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected float removalDistance;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		protected Vector3 placePosition;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		protected SphereCollider col;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected Transform originParent;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected bool placingFrame;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		protected CollisionDetectionMode placedObjDetectionMode;

		[Token(Token = "0x17000068")]
		public Grabbable highlightingObj
		{
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x928B60", Offset = "0x928B60", VA = "0x928B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x928B68", Offset = "0x928B68", VA = "0x928B68")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public Grabbable placedObject
		{
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x928B70", Offset = "0x928B70", VA = "0x928B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x928B78", Offset = "0x928B78", VA = "0x928B78")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public Grabbable lastPlacedObject
		{
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x928B80", Offset = "0x928B80", VA = "0x928B80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x928B88", Offset = "0x928B88", VA = "0x928B88")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x928B90", Offset = "0x928B90", VA = "0x928B90", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x928CB0", Offset = "0x928CB0", VA = "0x928CB0")]
		[IteratorStateMachine(typeof(<HighlightSafetyCheck>d__47))]
		private IEnumerator HighlightSafetyCheck()
		{
			return null;
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x928D4C", Offset = "0x928D4C", VA = "0x928D4C", Slot = "5")]
		public virtual bool CanPlace(Grabbable placeObj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x928F34", Offset = "0x928F34", VA = "0x928F34", Slot = "6")]
		public virtual void Place(Grabbable placeObj)
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x929570", Offset = "0x929570", VA = "0x929570")]
		public void Remove()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x9295F4", Offset = "0x9295F4", VA = "0x9295F4", Slot = "7")]
		public virtual void Remove(Grabbable placeObj)
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x9298E8", Offset = "0x9298E8", VA = "0x9298E8", Slot = "8")]
		internal virtual void Highlight(Grabbable from)
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x929A08", Offset = "0x929A08", VA = "0x929A08", Slot = "9")]
		internal virtual void StopHighlight(Grabbable from)
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x929B40", Offset = "0x929B40", VA = "0x929B40")]
		protected bool IsOverlapping(Grabbable from)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x929CC8", Offset = "0x929CC8", VA = "0x929CC8", Slot = "10")]
		public virtual void SetStartPlaced()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x929D64", Offset = "0x929D64", VA = "0x929D64")]
		public Grabbable GetPlacedObject()
		{
			return null;
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x929D6C", Offset = "0x929D6C", VA = "0x929D6C")]
		internal float Distance(Transform from)
		{
			return default(float);
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x929E74", Offset = "0x929E74", VA = "0x929E74", Slot = "11")]
		protected virtual void OnPlacedObjectGrabbed(Hand pHand, Grabbable pGrabbable)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x929EA8", Offset = "0x929EA8", VA = "0x929EA8", Slot = "12")]
		protected virtual void OnPlacedObjectReleased(Hand pHand, Grabbable pGrabbable)
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x929EC8", Offset = "0x929EC8", VA = "0x929EC8", Slot = "13")]
		protected virtual void OnJointBreak(float breakForce)
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x929F4C", Offset = "0x929F4C", VA = "0x929F4C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x92A114", Offset = "0x92A114", VA = "0x92A114")]
		public PlacePoint()
		{
		}
	}
	[Token(Token = "0x2000124")]
	[DefaultExecutionOrder(1)]
	[RequireComponent(typeof(Rigidbody))]
	public class WeightlessFollower : MonoBehaviour
	{
		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public Transform follow;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public Transform follow1;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dictionary<Hand, Transform> heldMoveTo;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public float followPositionStrength;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[HideInInspector]
		public float followRotationStrength;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public float maxVelocity;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public Grabbable grab;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal Rigidbody body;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform moveTo;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float startMass;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float startDrag;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float startAngleDrag;

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x92A2CC", Offset = "0x92A2CC", VA = "0x92A2CC")]
		public void Start()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x92A3BC", Offset = "0x92A3BC", VA = "0x92A3BC", Slot = "4")]
		public virtual void Set(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x92AAB8", Offset = "0x92AAB8", VA = "0x92AAB8", Slot = "5")]
		public virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x92AB48", Offset = "0x92AB48", VA = "0x92AB48")]
		protected void SetMoveTo()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x92AD20", Offset = "0x92AD20", VA = "0x92AD20", Slot = "6")]
		protected virtual void MoveTo()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x92B0F4", Offset = "0x92B0F4", VA = "0x92B0F4", Slot = "7")]
		protected virtual void TorqueTo()
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x92B3B4", Offset = "0x92B3B4", VA = "0x92B3B4")]
		private int CollisionCount()
		{
			return default(int);
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x92B3D0", Offset = "0x92B3D0", VA = "0x92B3D0")]
		public void RemoveFollow(Hand hand, Transform follow)
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x92B6EC", Offset = "0x92B6EC", VA = "0x92B6EC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x92B8EC", Offset = "0x92B8EC", VA = "0x92B8EC")]
		public WeightlessFollower()
		{
		}
	}
	[Token(Token = "0x2000125")]
	[HelpURL("https://earnestrobot.notion.site/Fingers-63ae83cda0b14a35b5ae15beeb51dc03")]
	public class Finger : MonoBehaviour
	{
		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("This transfrom will represent the tip/stopper of the finger")]
		[Header("Tips")]
		public Transform tip;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("This determines the radius of the spherecast check when bending fingers")]
		public float tipRadius;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("This will offset the fingers bend (0 is no bend, 1 is full bend)")]
		[Range(0f, 1f)]
		public float bendOffset;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fingerSmoothSpeed;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		public float secondaryOffset;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float currBendOffset;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float bend;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private Quaternion[] minGripRotPose;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		private Vector3[] minGripPosPose;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		private Quaternion[] maxGripRotPose;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		private Vector3[] maxGripPosPose;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		[SerializeField]
		private Transform[] fingerJoints;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float lastHitBend;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Collider[] results;

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x92BA54", Offset = "0x92BA54", VA = "0x92BA54")]
		private void Update()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x92BAD0", Offset = "0x92BAD0", VA = "0x92BAD0")]
		public bool BendFingerUntilHit(int steps, int layermask)
		{
			return default(bool);
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x92C0D8", Offset = "0x92C0D8", VA = "0x92C0D8")]
		public bool UpdateFingerBend(float bend, int layermask)
		{
			return default(bool);
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x92C33C", Offset = "0x92C33C", VA = "0x92C33C")]
		public void UpdateFinger()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x92C4C4", Offset = "0x92C4C4", VA = "0x92C4C4")]
		public void UpdateFinger(float bend)
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x92C650", Offset = "0x92C650", VA = "0x92C650")]
		public void SetFingerBend(float bend)
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x92C7DC", Offset = "0x92C7DC", VA = "0x92C7DC")]
		public void SetCurrentFingerBend(float bend)
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x92BA58", Offset = "0x92BA58", VA = "0x92BA58")]
		private void SlowBend()
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x92BFF0", Offset = "0x92BFF0", VA = "0x92BFF0")]
		[ContextMenu("ResetBend")]
		public void ResetBend()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x92C968", Offset = "0x92C968", VA = "0x92C968")]
		[ContextMenu("Grip")]
		public void Grip()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x92CA50", Offset = "0x92CA50", VA = "0x92CA50")]
		public float GetLastHitBend()
		{
			return default(float);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x92CA58", Offset = "0x92CA58", VA = "0x92CA58")]
		[ContextMenu("Set Open Finger Pose")]
		public void SetMinPose()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x92CD98", Offset = "0x92CD98", VA = "0x92CD98")]
		[ContextMenu("Set Closed Finger Pose")]
		public void SetMaxPose()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x92D0D8", Offset = "0x92D0D8", VA = "0x92D0D8")]
		public bool IsMinPoseSaved()
		{
			return default(bool);
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x92D0FC", Offset = "0x92D0FC", VA = "0x92D0FC")]
		public bool IsMaxPoseSaved()
		{
			return default(bool);
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x92D120", Offset = "0x92D120", VA = "0x92D120")]
		public float GetCurrentBend()
		{
			return default(float);
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x92D12C", Offset = "0x92D12C", VA = "0x92D12C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x92D1E0", Offset = "0x92D1E0", VA = "0x92D1E0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x92D370", Offset = "0x92D370", VA = "0x92D370")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000126")]
	[DefaultExecutionOrder(-10)]
	[HelpURL("https://earnestrobot.notion.site/Hand-967e36c2ab2945b2b0f75cea84624b2f")]
	public class Hand : HandBase
	{
		[Token(Token = "0x2000128")]
		[CompilerGenerated]
		private sealed class <HighlightUpdate>d__125 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Hand <>4__this;

			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float timestep;

			[Token(Token = "0x1700006E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000696")]
				[Address(RVA = "0x934550", Offset = "0x934550", VA = "0x934550", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000698")]
				[Address(RVA = "0x934598", Offset = "0x934598", VA = "0x934598", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000693")]
			[Address(RVA = "0x9335AC", Offset = "0x9335AC", VA = "0x9335AC")]
			[DebuggerHidden]
			public <HighlightUpdate>d__125(int <>1__state)
			{
			}

			[Token(Token = "0x6000694")]
			[Address(RVA = "0x934438", Offset = "0x934438", VA = "0x934438", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000695")]
			[Address(RVA = "0x93443C", Offset = "0x93443C", VA = "0x93443C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000697")]
			[Address(RVA = "0x934558", Offset = "0x934558", VA = "0x934558", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000129")]
		[CompilerGenerated]
		private struct <>c__DisplayClass127_0
		{
			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Hand <>4__this;

			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Grabbable startHoldingObj;
		}

		[Token(Token = "0x200012A")]
		[CompilerGenerated]
		private sealed class <GrabObject>d__127 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Hand <>4__this;

			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Grabbable grab;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public RaycastHit hit;

			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public GrabType grabType;

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private <>c__DisplayClass127_0 <>8__1;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool <instantGrab>5__2;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private HandPoseData <startGrabPose>5__3;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Vector3 <startGrabbablePosition>5__4;

			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private Quaternion <startGrabbableRotation>5__5;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private float <adjustedGrabTime>5__6;

			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private Transform <grabTarget>5__7;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private HandPoseData <postGrabPose>5__8;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			private Vector3 <endGrabbablePosition>5__9;

			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			private Quaternion <endGrabbableRotation>5__10;

			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private float <i>5__11;

			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			private bool <useGravity>5__12;

			[Token(Token = "0x17000070")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600069C")]
				[Address(RVA = "0x9363B8", Offset = "0x9363B8", VA = "0x9363B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600069E")]
				[Address(RVA = "0x936400", Offset = "0x936400", VA = "0x936400", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000699")]
			[Address(RVA = "0x9335D4", Offset = "0x9335D4", VA = "0x9335D4")]
			[DebuggerHidden]
			public <GrabObject>d__127(int <>1__state)
			{
			}

			[Token(Token = "0x600069A")]
			[Address(RVA = "0x9345A0", Offset = "0x9345A0", VA = "0x9345A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600069B")]
			[Address(RVA = "0x9345A4", Offset = "0x9345A4", VA = "0x9345A4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600069D")]
			[Address(RVA = "0x9363C0", Offset = "0x9363C0", VA = "0x9363C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200012B")]
		[CompilerGenerated]
		private sealed class <LerpHandPose>d__129 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Hand <>4__this;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HandPoseData fromPose;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public HandPoseData toPose;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public float totalTime;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float <timePassed>5__2;

			[Token(Token = "0x17000072")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006A2")]
				[Address(RVA = "0x936648", Offset = "0x936648", VA = "0x936648", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000073")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006A4")]
				[Address(RVA = "0x936690", Offset = "0x936690", VA = "0x936690", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0x933728", Offset = "0x933728", VA = "0x933728")]
			[DebuggerHidden]
			public <LerpHandPose>d__129(int <>1__state)
			{
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x936408", Offset = "0x936408", VA = "0x936408", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x93640C", Offset = "0x93640C", VA = "0x93640C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x936650", Offset = "0x936650", VA = "0x936650", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		[AutoToggleHeader("Enable Highlight", 0, 0, tooltip = "Raycasting for grabbables to highlight is expensive, you can disable it here if you aren't using it")]
		public bool usingHighlight;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x244")]
		[EnableIf("usingHighlight")]
		[Tooltip("The layers to highlight and use look assist on --- Nothing will default on start")]
		public LayerMask highlightLayers;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		[Tooltip("Leave empty for none - used as a default option for all grabbables with empty highlight material")]
		[EnableIf("usingHighlight")]
		public Material defaultHighlight;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		[AutoToggleHeader("Show Advanced", 0, 0)]
		public bool showAdvanced;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x254")]
		[ShowIf("showAdvanced")]
		[Tooltip("Whether the hand should go to the object and come back on grab, or the object to float to the hand on grab. Will default to HandToGrabbable for objects that have \"parentOnGrab\" disabled")]
		public GrabType grabType;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		[ShowIf("showAdvanced")]
		[Tooltip("Makes grab smoother; also based on range and reach distance - a very near grab is instant and a max distance grab is [X] frames")]
		[Min(0f)]
		public float minGrabTime;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
		[ShowIf("showAdvanced")]
		[Tooltip("Makes grab smoother; also based on range and reach distance - a very near grab is instant and a max distance grab is [X] frames")]
		[Min(0f)]
		public float maxGrabTime;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		[ShowIf("showAdvanced")]
		[Tooltip("The animation curve based on the grab time 0-1")]
		[Min(0f)]
		public AnimationCurve grabCurve;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		[ShowIf("showAdvanced")]
		[Min(0f)]
		[Tooltip("Speed at which the gentle grab returns the grabbable")]
		public float smoothReturnSpeed;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
		[ShowIf("showAdvanced")]
		[Tooltip("This is used in conjunction with custom poses. For a custom pose to work it must has the same PoseIndex as the hand. Used for when your game has multiple hands")]
		public int poseIndex;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		[AutoLine(0, 0)]
		public bool ignoreMe1;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] grabbableLayers;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string grabbableLayerNameDefault;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string grabbingLayerName;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string rightHandLayerName;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string leftHandLayerName;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private List<HandTriggerAreaEvents> triggerEventAreas;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private Coroutine tryGrab;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private Coroutine highlightRoutine;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private float startGrabDist;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private HandPoseData openHandPose;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		private Grabbable lastHoldingObj;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		private Coroutine _grabRoutine;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		private Vector3 startHandGrabPosition;

		[Token(Token = "0x1700006D")]
		private Coroutine grabRoutine
		{
			[Token(Token = "0x600064B")]
			[Address(RVA = "0x92E958", Offset = "0x92E958", VA = "0x92E958")]
			get
			{
				return null;
			}
			[Token(Token = "0x600064C")]
			[Address(RVA = "0x92E960", Offset = "0x92E960", VA = "0x92E960")]
			set
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event HandGrabEvent OnTriggerGrab
		{
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x92D558", Offset = "0x92D558", VA = "0x92D558")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600062A")]
			[Address(RVA = "0x92D5F8", Offset = "0x92D5F8", VA = "0x92D5F8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event HandGrabEvent OnBeforeGrabbed
		{
			[Token(Token = "0x600062B")]
			[Address(RVA = "0x92D698", Offset = "0x92D698", VA = "0x92D698")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600062C")]
			[Address(RVA = "0x92D738", Offset = "0x92D738", VA = "0x92D738")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		public event HandGrabEvent OnGrabbed
		{
			[Token(Token = "0x600062D")]
			[Address(RVA = "0x92D7D8", Offset = "0x92D7D8", VA = "0x92D7D8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600062E")]
			[Address(RVA = "0x92D878", Offset = "0x92D878", VA = "0x92D878")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public event HandGrabEvent OnTriggerRelease
		{
			[Token(Token = "0x600062F")]
			[Address(RVA = "0x92D918", Offset = "0x92D918", VA = "0x92D918")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000630")]
			[Address(RVA = "0x92D9B8", Offset = "0x92D9B8", VA = "0x92D9B8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event HandGrabEvent OnBeforeReleased
		{
			[Token(Token = "0x6000631")]
			[Address(RVA = "0x92DA58", Offset = "0x92DA58", VA = "0x92DA58")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000632")]
			[Address(RVA = "0x92DAF8", Offset = "0x92DAF8", VA = "0x92DAF8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public event HandGrabEvent OnReleased
		{
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x92AA18", Offset = "0x92AA18", VA = "0x92AA18")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x92B64C", Offset = "0x92B64C", VA = "0x92B64C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000C")]
		public event HandGrabEvent OnSqueezed
		{
			[Token(Token = "0x6000635")]
			[Address(RVA = "0x92DB98", Offset = "0x92DB98", VA = "0x92DB98")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000636")]
			[Address(RVA = "0x92DC38", Offset = "0x92DC38", VA = "0x92DC38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000D")]
		public event HandGrabEvent OnUnsqueezed
		{
			[Token(Token = "0x6000637")]
			[Address(RVA = "0x92DCD8", Offset = "0x92DCD8", VA = "0x92DCD8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000638")]
			[Address(RVA = "0x92DD78", Offset = "0x92DD78", VA = "0x92DD78")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public event HandGrabEvent OnHighlight
		{
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x92DE18", Offset = "0x92DE18", VA = "0x92DE18")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600063A")]
			[Address(RVA = "0x92DEB8", Offset = "0x92DEB8", VA = "0x92DEB8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000F")]
		public event HandGrabEvent OnStopHighlight
		{
			[Token(Token = "0x600063B")]
			[Address(RVA = "0x92DF58", Offset = "0x92DF58", VA = "0x92DF58")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600063C")]
			[Address(RVA = "0x92DFF8", Offset = "0x92DFF8", VA = "0x92DFF8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000010")]
		public event HandGrabEvent OnForcedRelease
		{
			[Token(Token = "0x600063D")]
			[Address(RVA = "0x92E098", Offset = "0x92E098", VA = "0x92E098")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600063E")]
			[Address(RVA = "0x92E138", Offset = "0x92E138", VA = "0x92E138")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event HandGrabEvent OnGrabJointBreak
		{
			[Token(Token = "0x600063F")]
			[Address(RVA = "0x92E1D8", Offset = "0x92E1D8", VA = "0x92E1D8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x92E278", Offset = "0x92E278", VA = "0x92E278")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event HandGrabEvent OnHeldConnectionBreak
		{
			[Token(Token = "0x6000641")]
			[Address(RVA = "0x92E318", Offset = "0x92E318", VA = "0x92E318")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x92E3B8", Offset = "0x92E3B8", VA = "0x92E3B8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000013")]
		public event HandGameObjectEvent OnHandCollisionStart
		{
			[Token(Token = "0x6000643")]
			[Address(RVA = "0x92E458", Offset = "0x92E458", VA = "0x92E458")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000644")]
			[Address(RVA = "0x92E4F8", Offset = "0x92E4F8", VA = "0x92E4F8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000014")]
		public event HandGameObjectEvent OnHandCollisionStop
		{
			[Token(Token = "0x6000645")]
			[Address(RVA = "0x92E598", Offset = "0x92E598", VA = "0x92E598")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000646")]
			[Address(RVA = "0x92E638", Offset = "0x92E638", VA = "0x92E638")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000015")]
		public event HandGameObjectEvent OnHandTriggerStart
		{
			[Token(Token = "0x6000647")]
			[Address(RVA = "0x92E6D8", Offset = "0x92E6D8", VA = "0x92E6D8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000648")]
			[Address(RVA = "0x92E778", Offset = "0x92E778", VA = "0x92E778")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000016")]
		public event HandGameObjectEvent OnHandTriggerStop
		{
			[Token(Token = "0x6000649")]
			[Address(RVA = "0x92E818", Offset = "0x92E818", VA = "0x92E818")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600064A")]
			[Address(RVA = "0x92E8B8", Offset = "0x92E8B8", VA = "0x92E8B8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x92EAC0", Offset = "0x92EAC0", VA = "0x92EAC0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x92ECD0", Offset = "0x92ECD0", VA = "0x92ECD0", Slot = "20")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x92EDA0", Offset = "0x92EDA0", VA = "0x92EDA0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x92F098", Offset = "0x92F098", VA = "0x92F098", Slot = "6")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x92F4FC", Offset = "0x92F4FC", VA = "0x92F4FC", Slot = "9")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x92FB4C", Offset = "0x92FB4C", VA = "0x92FB4C")]
		private float GetGrabTime()
		{
			return default(float);
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x92FCB8", Offset = "0x92FCB8", VA = "0x92FCB8", Slot = "21")]
		public virtual void Grab()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x92FCCC", Offset = "0x92FCCC", VA = "0x92FCCC", Slot = "22")]
		public virtual void Grab(GrabType grabType)
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x93024C", Offset = "0x93024C", VA = "0x93024C", Slot = "23")]
		public virtual void Grab(RaycastHit hit, Grabbable grab, GrabType grabType = GrabType.InstantGrab)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x930394", Offset = "0x930394", VA = "0x930394", Slot = "24")]
		public virtual void TryGrab(Grabbable grab)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x930C28", Offset = "0x930C28", VA = "0x930C28", Slot = "25")]
		public virtual void Release()
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x930EE4", Offset = "0x930EE4", VA = "0x930EE4", Slot = "26")]
		public virtual void ForceReleaseGrab()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x930F90", Offset = "0x930F90", VA = "0x930F90", Slot = "27")]
		public virtual void ReleaseGrabLock()
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x930FA0", Offset = "0x930FA0", VA = "0x930FA0", Slot = "28")]
		public virtual void Squeeze()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x931138", Offset = "0x931138", VA = "0x931138", Slot = "29")]
		public virtual void Unsqueeze()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x9312CC", Offset = "0x9312CC", VA = "0x9312CC", Slot = "30")]
		public virtual void BreakGrabConnection(bool callEvent = true)
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x93163C", Offset = "0x93163C", VA = "0x93163C", Slot = "31")]
		public virtual void CreateGrabConnection(Grabbable grab, Vector3 handPos, Quaternion handRot, Vector3 grabPos, Quaternion grabRot, bool executeGrabEvents = false)
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x931B8C", Offset = "0x931B8C", VA = "0x931B8C", Slot = "32")]
		public virtual void OnJointBreak(float breakForce)
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x931D1C", Offset = "0x931D1C", VA = "0x931D1C", Slot = "33")]
		public virtual void UpdateHighlight()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x930118", Offset = "0x930118", VA = "0x930118")]
		public RaycastHit GetHighlightHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x932044", Offset = "0x932044", VA = "0x932044")]
		public void AutoPose(RaycastHit hit, Grabbable grabbable)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x93267C", Offset = "0x93267C", VA = "0x93267C")]
		public HandPoseData GetHandPose()
		{
			return default(HandPoseData);
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x93269C", Offset = "0x93269C", VA = "0x93269C")]
		public HandPoseData GetHeldPose()
		{
			return default(HandPoseData);
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x932758", Offset = "0x932758", VA = "0x932758", Slot = "34")]
		public virtual void SetHeldPose(HandPoseData pose, Grabbable grabbable, bool createJoint = true)
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x932A00", Offset = "0x932A00", VA = "0x932A00")]
		public void SetHandPose(HandPoseData pose)
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x932A18", Offset = "0x932A18", VA = "0x932A18")]
		public void SetHandPose(GrabbablePose pose)
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x932A90", Offset = "0x932A90", VA = "0x932A90")]
		public void UpdatePose(HandPoseData pose, float time)
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x932BC4", Offset = "0x932BC4", VA = "0x932BC4")]
		public GrabbablePose GetGrabPose(Transform from, Grabbable grabbable)
		{
			return null;
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x932C30", Offset = "0x932C30", VA = "0x932C30")]
		public bool GetCurrentHeldGrabPose(Transform from, Grabbable grabbable, out GrabbablePose grabPose, out Transform relativeTo)
		{
			return default(bool);
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x932D48", Offset = "0x932D48", VA = "0x932D48")]
		public Grabbable GetHeldGrabbable()
		{
			return null;
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x932D50", Offset = "0x932D50", VA = "0x932D50")]
		public Grabbable GetHeld()
		{
			return null;
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x932D58", Offset = "0x932D58", VA = "0x932D58")]
		public bool IsSqueezing()
		{
			return default(bool);
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x932D60", Offset = "0x932D60", VA = "0x932D60")]
		public void SetGrip(float grip)
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x932D68", Offset = "0x932D68", VA = "0x932D68")]
		[ContextMenu("Set Pose - Relax Hand")]
		public void RelaxHand()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x932DCC", Offset = "0x932DCC", VA = "0x932DCC")]
		[ContextMenu("Set Pose - Open Hand")]
		public void OpenHand()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x932E2C", Offset = "0x932E2C", VA = "0x932E2C")]
		[ContextMenu("Set Pose - Close Hand")]
		public void CloseHand()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x932E98", Offset = "0x932E98", VA = "0x932E98")]
		[ContextMenu("Bend Fingers Until Hit")]
		public void ProceduralFingerBend()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x932FC0", Offset = "0x932FC0", VA = "0x932FC0")]
		public void ProceduralFingerBend(int layermask)
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x933034", Offset = "0x933034", VA = "0x933034")]
		public void ProceduralFingerBend(RaycastHit hit)
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x9330DC", Offset = "0x9330DC", VA = "0x9330DC")]
		public void PlayHapticVibration()
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x933174", Offset = "0x933174", VA = "0x933174")]
		public void PlayHapticVibration(float duration)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x9330EC", Offset = "0x9330EC", VA = "0x9330EC")]
		public void PlayHapticVibration(float duration, float amp = 0.5f)
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x93317C", Offset = "0x93317C", VA = "0x93317C")]
		[Button("Save Open Pose", EButtonEnableMode.Always)]
		[ContextMenu("SAVE OPEN")]
		public void SaveOpenPose()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x933230", Offset = "0x933230", VA = "0x933230")]
		[Button("Save Closed Pose", EButtonEnableMode.Always)]
		[ContextMenu("SAVE CLOSED")]
		public void SaveClosedPose()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x9332E4", Offset = "0x9332E4", VA = "0x9332E4", Slot = "35")]
		protected virtual void OnCollisionFirstEnter(GameObject collision)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x933360", Offset = "0x933360", VA = "0x933360", Slot = "36")]
		protected virtual void OnCollisionLastExit(GameObject collision)
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x9333DC", Offset = "0x9333DC", VA = "0x9333DC", Slot = "37")]
		protected virtual void OnTriggerFirstEnter(GameObject other)
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x9334EC", Offset = "0x9334EC", VA = "0x9334EC", Slot = "38")]
		protected virtual void OnTriggerLastExit(GameObject other)
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x92ED1C", Offset = "0x92ED1C", VA = "0x92ED1C")]
		[IteratorStateMachine(typeof(<HighlightUpdate>d__125))]
		private IEnumerator HighlightUpdate(float timestep)
		{
			return null;
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x930190", Offset = "0x930190", VA = "0x930190")]
		[IteratorStateMachine(typeof(<GrabObject>d__127))]
		protected IEnumerator GrabObject(RaycastHit hit, Grabbable grab, GrabType grabType)
		{
			return null;
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x9335FC", Offset = "0x9335FC", VA = "0x9335FC")]
		protected void CancelPose()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x933648", Offset = "0x933648", VA = "0x933648", Slot = "39")]
		[IteratorStateMachine(typeof(<LerpHandPose>d__129))]
		protected virtual IEnumerator LerpHandPose(HandPoseData fromPose, HandPoseData toPose, float totalTime)
		{
			return null;
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x933750", Offset = "0x933750", VA = "0x933750", Slot = "40")]
		protected virtual void CheckEnterPoseArea(GameObject other)
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x933C38", Offset = "0x933C38", VA = "0x933C38", Slot = "41")]
		protected virtual void CheckExitPoseArea(GameObject other)
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x933A60", Offset = "0x933A60", VA = "0x933A60")]
		internal void TryRemoveHandPoseArea(HandPoseArea poseArea)
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x933CD4", Offset = "0x933CD4", VA = "0x933CD4")]
		private void ClearPoseArea()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x933D88", Offset = "0x933D88", VA = "0x933D88", Slot = "42")]
		internal virtual void RemoveHandTriggerArea(HandTriggerAreaEvents handTrigger)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x933DF8", Offset = "0x933DF8", VA = "0x933DF8")]
		public Hand()
		{
		}
	}
	[Token(Token = "0x200012C")]
	[RequireComponent(typeof(Hand))]
	[DefaultExecutionOrder(10000)]
	public class HandAdvancedOptions : MonoBehaviour
	{
		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Meant for things childed under the Hand. These transforms will not be set to the hand layer on start")]
		public List<Collider> ignoreHandCollider;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Hand hand;

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x936698", Offset = "0x936698", VA = "0x936698")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x9366F0", Offset = "0x9366F0", VA = "0x9366F0")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x936794", Offset = "0x936794", VA = "0x936794")]
		public HandAdvancedOptions()
		{
		}
	}
	[Token(Token = "0x200012D")]
	public class HandClippingGuard : MonoBehaviour
	{
		[Token(Token = "0x200012E")]
		[CompilerGenerated]
		private sealed class <Guard>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Hand hand;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HandClippingGuard <>4__this;

			[Token(Token = "0x17000074")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006B0")]
				[Address(RVA = "0x936DD4", Offset = "0x936DD4", VA = "0x936DD4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000075")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006B2")]
				[Address(RVA = "0x936E1C", Offset = "0x936E1C", VA = "0x936E1C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x936AFC", Offset = "0x936AFC", VA = "0x936AFC")]
			[DebuggerHidden]
			public <Guard>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x936B38", Offset = "0x936B38", VA = "0x936B38", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x936B3C", Offset = "0x936B3C", VA = "0x936B3C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x936DDC", Offset = "0x936DDC", VA = "0x936DDC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Hand hand;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("This should be a sphere collider that covers the hand (similar, but seperate from the recommended trigger sphere collider)")]
		public SphereCollider collisionGuard;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform body;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float guardTime;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 grabPoint;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool runProtection;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Coroutine guardRoutine;

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x93681C", Offset = "0x93681C", VA = "0x93681C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x936908", Offset = "0x936908", VA = "0x936908")]
		private void BeforeGrab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x936A2C", Offset = "0x936A2C", VA = "0x936A2C")]
		private void OnRelease(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x936A6C", Offset = "0x936A6C", VA = "0x936A6C")]
		[IteratorStateMachine(typeof(<Guard>d__10))]
		private IEnumerator Guard(Hand hand)
		{
			return null;
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x936B24", Offset = "0x936B24", VA = "0x936B24")]
		public HandClippingGuard()
		{
		}
	}
	[Token(Token = "0x200012F")]
	[RequireComponent(typeof(Hand))]
	public class HandCollisionHaptics : MonoBehaviour
	{
		[Token(Token = "0x2000130")]
		[CompilerGenerated]
		private sealed class <PlayBuffer>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandCollisionHaptics <>4__this;

			[Token(Token = "0x17000076")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006BC")]
				[Address(RVA = "0x937410", Offset = "0x937410", VA = "0x937410", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000077")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006BE")]
				[Address(RVA = "0x937458", Offset = "0x937458", VA = "0x937458", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x937254", Offset = "0x937254", VA = "0x937254")]
			[DebuggerHidden]
			public <PlayBuffer>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x93733C", Offset = "0x93733C", VA = "0x93733C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x937340", Offset = "0x937340", VA = "0x937340", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x937418", Offset = "0x937418", VA = "0x937418", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000131")]
		[CompilerGenerated]
		private sealed class <HapticPlayBuffer>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandCollisionHaptics <>4__this;

			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float time;

			[Token(Token = "0x17000078")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006C2")]
				[Address(RVA = "0x937534", Offset = "0x937534", VA = "0x937534", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000079")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006C4")]
				[Address(RVA = "0x93757C", Offset = "0x93757C", VA = "0x93757C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x93727C", Offset = "0x93727C", VA = "0x93727C")]
			[DebuggerHidden]
			public <HapticPlayBuffer>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x937460", Offset = "0x937460", VA = "0x937460", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x937464", Offset = "0x937464", VA = "0x937464", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x93753C", Offset = "0x93753C", VA = "0x93753C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The layers that cause the sound to play")]
		public LayerMask collisionTriggers;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float hapticAmp;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float velocityAmp;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float repeatDelay;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float maxDuration;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Source to play sound from")]
		public AnimationCurve velocityAmpCurve;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Source to play sound from")]
		public AnimationCurve velocityDurationCurve;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Hand hand;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Rigidbody body;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool canPlay;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine playRoutine;

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x936E24", Offset = "0x936E24", VA = "0x936E24")]
		private void Start()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x936F54", Offset = "0x936F54", VA = "0x936F54")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x936F68", Offset = "0x936F68", VA = "0x936F68")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x9371E0", Offset = "0x9371E0", VA = "0x9371E0")]
		[IteratorStateMachine(typeof(<PlayBuffer>d__14))]
		private IEnumerator PlayBuffer()
		{
			return null;
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x936ED0", Offset = "0x936ED0", VA = "0x936ED0")]
		[IteratorStateMachine(typeof(<HapticPlayBuffer>d__15))]
		private IEnumerator HapticPlayBuffer(float time)
		{
			return null;
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x9372A4", Offset = "0x9372A4", VA = "0x9372A4")]
		public HandCollisionHaptics()
		{
		}
	}
	[Token(Token = "0x2000132")]
	public class HandControllerLink : MonoBehaviour
	{
		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static HandControllerLink handLeft;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static HandControllerLink handRight;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Hand hand;

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x937584", Offset = "0x937584", VA = "0x937584", Slot = "4")]
		public virtual void TryHapticImpulse(float duration, float amp, float freq = 10f)
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x937588", Offset = "0x937588", VA = "0x937588")]
		public HandControllerLink()
		{
		}
	}
	[Token(Token = "0x2000133")]
	[DefaultExecutionOrder(2)]
	[HelpURL("https://earnestrobot.notion.site/Distance-Grabbing-19e4e8b14f00428295eca75fca752787")]
	public class HandDistanceGrabber : MonoBehaviour
	{
		[Token(Token = "0x2000134")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass62_0
		{
			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public HandDistanceGrabber <>4__this;

			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DistanceGrabbable grab;

			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float estimatedRadius;

			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x939A48", Offset = "0x939A48", VA = "0x939A48")]
			public <>c__DisplayClass62_0()
			{
			}

			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x939A50", Offset = "0x939A50", VA = "0x939A50")]
			internal void <StartCatchAssist>b__0(Hand hand, Grabbable grabbable)
			{
			}

			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x939AEC", Offset = "0x939AEC", VA = "0x939AEC")]
			internal void <StartCatchAssist>b__1(Hand hand, Grabbable grabbable)
			{
			}

			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x93A090", Offset = "0x93A090", VA = "0x93A090")]
			internal void <StartCatchAssist>b__5(Hand hand, Grabbable grabbable)
			{
			}

			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x93A12C", Offset = "0x93A12C", VA = "0x93A12C")]
			internal void <StartCatchAssist>b__6(Hand hand, Grabbable grabbable)
			{
			}
		}

		[Token(Token = "0x2000135")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass62_1
		{
			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool cancelInstantGrab;

			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x93A1C8", Offset = "0x93A1C8", VA = "0x93A1C8")]
			public <>c__DisplayClass62_1()
			{
			}

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x93A1D0", Offset = "0x93A1D0", VA = "0x93A1D0")]
			internal void <StartCatchAssist>b__2(Hand hand, Grabbable grabbable)
			{
			}

			[Token(Token = "0x60006EC")]
			[Address(RVA = "0x93A1DC", Offset = "0x93A1DC", VA = "0x93A1DC")]
			internal void <StartCatchAssist>b__4(Hand hand, Grabbable grabbable)
			{
			}
		}

		[Token(Token = "0x2000136")]
		[CompilerGenerated]
		private sealed class <StartCatchAssist>d__62 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandDistanceGrabber <>4__this;

			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DistanceGrabbable grab;

			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float estimatedRadius;

			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private <>c__DisplayClass62_0 <>8__1;

			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private <>c__DisplayClass62_1 <>8__2;

			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <time>5__2;

			[Token(Token = "0x1700007B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006F0")]
				[Address(RVA = "0x93A880", Offset = "0x93A880", VA = "0x93A880", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006F2")]
				[Address(RVA = "0x93A8C8", Offset = "0x93A8C8", VA = "0x93A8C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x939730", Offset = "0x939730", VA = "0x939730")]
			[DebuggerHidden]
			public <StartCatchAssist>d__62(int <>1__state)
			{
			}

			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x93A1E8", Offset = "0x93A1E8", VA = "0x93A1E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x93A1EC", Offset = "0x93A1EC", VA = "0x93A1EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x93A888", Offset = "0x93A888", VA = "0x93A888", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Hands")]
		[Tooltip("The primaryHand used to trigger pulling or flicking")]
		public Hand primaryHand;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("This is important for catch assistance")]
		public Hand secondaryHand;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Pointing Options")]
		public Transform forwardPointer;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LineRenderer line;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Space]
		public float maxRange;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Defaults to grabbable on start if none")]
		public LayerMask layers;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Space]
		public Material defaultTargetedMaterial;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The highlight material to use when pulling")]
		public Material defaultSelectedMaterial;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Pull Options")]
		public bool useInstantPull;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		[Tooltip("If false will default to distance pull, set pullGrabDistance to 0 for instant pull on select")]
		public bool useFlickPull;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[ShowIf("useFlickPull")]
		[Tooltip("The magnitude of your hands angular velocity for \"flick\" to start")]
		public float flickThreshold;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("The amount you need to move your hand from the select position to trigger the grab")]
		[HideIf("useFlickPull")]
		public float pullGrabDistance;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Space]
		[Tooltip("If this is true the object will be grabbed when entering the radius")]
		public bool instantGrabAssist;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("The radius around of thrown object")]
		public float catchAssistRadius;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AutoToggleHeader("Show Events", 0, 0)]
		public bool showEvents;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[ShowIf("showEvents")]
		public UnityHandGrabEvent OnPull;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[ShowIf("showEvents")]
		public UnityHandEvent StartPoint;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[ShowIf("showEvents")]
		public UnityHandEvent StopPoint;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("Targeting is started when object is highlighted")]
		[ShowIf("showEvents")]
		public UnityHandGrabEvent StartTarget;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[ShowIf("showEvents")]
		public UnityHandGrabEvent StopTarget;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[ShowIf("showEvents")]
		[Tooltip("Selecting is started when grab is selected on highlight object")]
		public UnityHandGrabEvent StartSelect;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[ShowIf("showEvents")]
		public UnityHandGrabEvent StopSelect;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<CatchAssistData> catchAssisted;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private DistanceGrabbable targetingDistanceGrabbable;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private DistanceGrabbable selectingDistanceGrabbable;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float catchAssistSeconds;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private bool pointing;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		private bool pulling;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3 startPullPosition;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private RaycastHit hit;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion lastRotation;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private RaycastHit selectionHit;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private float selectedEstimatedRadius;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float startLookAssist;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private bool lastInstantPull;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private GameObject _hitPoint;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Coroutine catchAssistRoutine;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private DistanceGrabbable catchAsistGrabbable;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private CatchAssistData catchAssistData;

		[Token(Token = "0x1700007A")]
		private GameObject hitPoint
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x937590", Offset = "0x937590", VA = "0x937590")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x93768C", Offset = "0x93768C", VA = "0x93768C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x9377F0", Offset = "0x9377F0", VA = "0x9377F0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x937940", Offset = "0x937940", VA = "0x937940")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x937BF4", Offset = "0x937BF4", VA = "0x937BF4")]
		private void Update()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x938004", Offset = "0x938004", VA = "0x938004")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x9377E4", Offset = "0x9377E4", VA = "0x9377E4")]
		public void SetInstantPull()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x93806C", Offset = "0x93806C", VA = "0x93806C")]
		public void SetPull(float distance)
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x938078", Offset = "0x938078", VA = "0x938078")]
		public void SetFlickPull(float threshold)
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x937C28", Offset = "0x937C28", VA = "0x937C28")]
		private void CheckDistanceGrabbable()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x938420", Offset = "0x938420", VA = "0x938420", Slot = "4")]
		public virtual void StartPointing()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x938484", Offset = "0x938484", VA = "0x938484", Slot = "5")]
		public virtual void StopPointing()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x938574", Offset = "0x938574", VA = "0x938574", Slot = "6")]
		public virtual void StartTargeting(DistanceGrabbable target)
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x93876C", Offset = "0x93876C", VA = "0x93876C", Slot = "7")]
		public virtual void StopTargeting()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x9388A4", Offset = "0x9388A4", VA = "0x9388A4", Slot = "8")]
		public virtual void SelectTarget()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x938C88", Offset = "0x938C88", VA = "0x938C88", Slot = "9")]
		public virtual void CancelSelect()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x938D98", Offset = "0x938D98", VA = "0x938D98", Slot = "10")]
		public virtual void ActivatePull()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x938330", Offset = "0x938330", VA = "0x938330")]
		private void TryDistancePull()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x938088", Offset = "0x938088", VA = "0x938088")]
		private void TryFlickPull()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x938BF8", Offset = "0x938BF8", VA = "0x938BF8")]
		private Material GetSelectedMaterial(DistanceGrabbable grabbable)
		{
			return null;
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x9386D8", Offset = "0x9386D8", VA = "0x9386D8")]
		private Material GetTargetedMaterial(DistanceGrabbable grabbable)
		{
			return null;
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x9391F4", Offset = "0x9391F4", VA = "0x9391F4")]
		private void TryCatchAssist(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x939154", Offset = "0x939154", VA = "0x939154")]
		[IteratorStateMachine(typeof(<StartCatchAssist>d__62))]
		private IEnumerator StartCatchAssist(DistanceGrabbable grab, float estimatedRadius)
		{
			return null;
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x939758", Offset = "0x939758", VA = "0x939758")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x9398A4", Offset = "0x9398A4", VA = "0x9398A4")]
		public HandDistanceGrabber()
		{
		}
	}
	[Token(Token = "0x2000137")]
	internal struct CatchAssistData
	{
		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Grabbable grab;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float estimatedRadius;

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x93A8D0", Offset = "0x93A8D0", VA = "0x93A8D0")]
		public CatchAssistData(Grabbable grab, float estimatedRadius)
		{
		}
	}
	[Token(Token = "0x2000138")]
	[HelpURL("https://www.notion.so/Pose-Areas-99b9af26d297442a91a9d73f65f13635")]
	public class HandPoseArea : MonoBehaviour
	{
		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string poseName;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int poseIndex;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float transitionTime;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Events")]
		public UnityHandEvent OnHandEnter;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityHandEvent OnHandExit;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		[Tooltip("Scriptable options NOT REQUIRED (will be saved locally instead if empty) -> Create scriptable throught [Auto Hand/Custom Pose]")]
		public HandPoseScriptable poseScriptable;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public HandPoseData rightPose;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public bool rightPoseSet;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public HandPoseData leftPose;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		public bool leftPoseSet;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		internal HandPoseArea[] poseAreas;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private List<Hand> posingHands;

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x93A8F8", Offset = "0x93A8F8", VA = "0x93A8F8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x93A950", Offset = "0x93A950", VA = "0x93A950")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x93AA44", Offset = "0x93AA44", VA = "0x93AA44")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x93ABA4", Offset = "0x93ABA4", VA = "0x93ABA4")]
		private void HandEnter(Hand hand)
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x93AC54", Offset = "0x93AC54", VA = "0x93AC54")]
		private void HandExit(Hand hand)
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x93ACAC", Offset = "0x93ACAC", VA = "0x93ACAC", Slot = "4")]
		public virtual HandPoseData GetHandPoseData(bool left)
		{
			return default(HandPoseData);
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x93AD6C", Offset = "0x93AD6C", VA = "0x93AD6C")]
		public void SetHandPose(Hand hand)
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x93B0B8", Offset = "0x93B0B8", VA = "0x93B0B8")]
		public bool HasPose(bool left)
		{
			return default(bool);
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x93B16C", Offset = "0x93B16C", VA = "0x93B16C")]
		public HandPoseArea()
		{
		}
	}
	[Token(Token = "0x2000139")]
	public class HandProjector : MonoBehaviour
	{
		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("References")]
		public Hand hand;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("This should be a copy of the hand with the desired visual setup for your projection hand")]
		public Hand handProjection;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The Object(s) under your Hand that contain the MeshRenderer Component(s)")]
		public Transform[] handProjectionVisuals;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Smoothing speed, turning too high could cause jitters")]
		public float speed;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("If true everything in the hand Vvisuals will be disabled/hidden when projection hand is showing")]
		public bool hideHand;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The Object(s) under your main hand (not the projection hand) that contain the MeshRenderer Component(s)")]
		[ShowIf("hideHand")]
		public Transform[] handVisuals;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Should the projection interpolate between the hand pose and the projected grab pose based on the grip input axis")]
		public bool useGrabTransition;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The Object(s) under your Hand that contain the MeshRenderer Component(s)")]
		[EnableIf("useGrabTransition")]
		public float grabTransitionOffset;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The Object(s) under your Hand that contain the MeshRenderer Component(s)")]
		[EnableIf("useGrabTransition")]
		public float grabDistanceMultiplyer;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[EnableIf("useGrabTransition")]
		[Tooltip("The Object(s) under your Hand that contain the MeshRenderer Component(s)")]
		public float grabTransitionMultiplyer;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[DisableIf("useGrabTransition")]
		[Tooltip("The Object(s) under your Hand that contain the MeshRenderer Component(s)")]
		public float grabPercent;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("Events")]
		public UnityHandGrabEvent OnStartProjection;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public UnityHandGrabEvent OnEndProjection;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private HandPoseData lastProjectionPose;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private HandPoseData newProjectionPose;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastProjectionPosition;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion lastProjectionRotation;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Grabbable target;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private float startMass;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private float minGrabTime;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private float currAmount;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool tryingGrab;

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x93B2A4", Offset = "0x93B2A4", VA = "0x93B2A4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x93B748", Offset = "0x93B748", VA = "0x93B748")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x93C5E8", Offset = "0x93C5E8", VA = "0x93C5E8")]
		private void OnTriggerGrab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x93C5F4", Offset = "0x93C5F4", VA = "0x93C5F4")]
		private void OnBeforeGrab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x93C7B0", Offset = "0x93C7B0", VA = "0x93C7B0")]
		private void OnGrab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x93C7D4", Offset = "0x93C7D4", VA = "0x93C7D4")]
		private void OnRelease(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x93C9EC", Offset = "0x93C9EC", VA = "0x93C9EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x93CDF8", Offset = "0x93CDF8", VA = "0x93CDF8")]
		private void OnProjectionStart(Hand projectionHand, Grabbable target)
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x93CE6C", Offset = "0x93CE6C", VA = "0x93CE6C")]
		private void OnProjectionEnd(Hand projectionHand, Grabbable target)
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x93B8BC", Offset = "0x93B8BC", VA = "0x93B8BC")]
		private void ShowProjection(bool show)
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x93CA4C", Offset = "0x93CA4C", VA = "0x93CA4C")]
		private void SetTarget(Grabbable newTarget)
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x93CD38", Offset = "0x93CD38", VA = "0x93CD38")]
		private bool IsProjectionActive()
		{
			return default(bool);
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x93D1E0", Offset = "0x93D1E0", VA = "0x93D1E0")]
		public HandProjector()
		{
		}
	}
	[Token(Token = "0x200013A")]
	public class HandPublicEvents : MonoBehaviour
	{
		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Hand hand;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityHandGrabEvent OnBeforeGrab;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityHandGrabEvent OnGrab;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityHandGrabEvent OnRelease;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UnityHandGrabEvent OnForceRelease;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityHandGrabEvent OnSqueeze;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UnityHandGrabEvent OnUnsqueeze;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityHandGrabEvent OnHighlight;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UnityHandGrabEvent OnStopHighlight;

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x93D200", Offset = "0x93D200", VA = "0x93D200")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x93D440", Offset = "0x93D440", VA = "0x93D440")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x93D680", Offset = "0x93D680", VA = "0x93D680")]
		public void OnBeforeGrabEvent(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x93D6F4", Offset = "0x93D6F4", VA = "0x93D6F4")]
		public void OnGrabEvent(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x93D768", Offset = "0x93D768", VA = "0x93D768")]
		public void OnReleaseEvent(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x93D7DC", Offset = "0x93D7DC", VA = "0x93D7DC")]
		public void OnSqueezeEvent(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x93D850", Offset = "0x93D850", VA = "0x93D850")]
		public void OnUnsqueezeEvent(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x93D8C4", Offset = "0x93D8C4", VA = "0x93D8C4")]
		public void OnHighlightEvent(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x93D938", Offset = "0x93D938", VA = "0x93D938")]
		public void OnStopHighlightEvent(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x93D9AC", Offset = "0x93D9AC", VA = "0x93D9AC")]
		public void OnForceReleaseEvent(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x93DA20", Offset = "0x93DA20", VA = "0x93DA20")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x93DB04", Offset = "0x93DB04", VA = "0x93DB04")]
		public HandPublicEvents()
		{
		}
	}
	[Token(Token = "0x200013B")]
	[DefaultExecutionOrder(1000)]
	public class HandTeleportGuard : MonoBehaviour
	{
		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Helps prevent hand from passing through static collision boundries")]
		public Hand hand;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Guard Settings")]
		[Tooltip("The mask of things the guarding will ignore, if left on default or empty, will default to ignoring recommended Auto Hand layers")]
		public LayerMask ignoreMask;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The amount of distance change required in one frame or fixed udpate to activate the teleport guard")]
		public float buffer;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Whether this should always run or only run when activated by the teleporter")]
		public bool alwaysRun;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[Tooltip("If true hands wont teleport return when past the max distance if something is in the way")]
		[FormerlySerializedAs("strict")]
		public bool ignoreMaxHandDistance;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 deltaHandPos;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 deltaHandFixedPos;

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x93DCB8", Offset = "0x93DCB8", VA = "0x93DCB8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x93E040", Offset = "0x93E040", VA = "0x93E040")]
		private void Update()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x93E560", Offset = "0x93E560", VA = "0x93E560")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x93E1FC", Offset = "0x93E1FC", VA = "0x93E1FC")]
		public void TeleportProtection(Vector3 fromPos, Vector3 toPos)
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x93E71C", Offset = "0x93E71C", VA = "0x93E71C")]
		public HandTeleportGuard()
		{
		}
	}
	[Token(Token = "0x200013C")]
	[HelpURL("https://www.notion.so/Touch-Events-1341b3e627dd443a99593ff7f0412aa6")]
	public class HandTouchEvent : MonoBehaviour
	{
		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Whether or not first hand to enter should take ownership and be the only one to call events")]
		[Header("For Solid Collision")]
		public bool oneHanded;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public HandType handType;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Events")]
		public UnityHandEvent HandStartTouch;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityHandEvent HandStopTouch;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HandEvent HandStartTouchEvent;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public HandEvent HandStopTouchEvent;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Hand> hands;

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x93E730", Offset = "0x93E730", VA = "0x93E730")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x93EA10", Offset = "0x93EA10", VA = "0x93EA10")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x93EB64", Offset = "0x93EB64", VA = "0x93EB64")]
		public void Touch(Hand hand)
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x93ECC4", Offset = "0x93ECC4", VA = "0x93ECC4")]
		public void Untouch(Hand hand)
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x93EE24", Offset = "0x93EE24", VA = "0x93EE24")]
		public HandTouchEvent()
		{
		}
	}
	[Token(Token = "0x200013D")]
	public delegate void HandEvent(Hand hand);
	[Token(Token = "0x200013E")]
	public class HandTriggerAreaEvents : MonoBehaviour
	{
		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Trigger Events Settings")]
		[Tooltip("Whether or not first hand to enter should take ownership and be the only one to call events")]
		public bool oneHanded;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public HandType handType;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Whether or not to call the release event if exiting while grab event activated")]
		public bool exitTriggerRelease;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[Tooltip("Whether or not to call the release event if exiting while grab event activated")]
		public bool exitTriggerUnsqueeze;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Events")]
		public UnityHandEvent HandEnter;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityHandEvent HandExit;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UnityHandEvent HandGrab;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityHandEvent HandRelease;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UnityHandEvent HandSqueeze;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityHandEvent HandUnsqueeze;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public HandEvent HandEnterEvent;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public HandEvent HandExitEvent;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public HandEvent HandGrabEvent;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public HandEvent HandReleaseEvent;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public HandEvent HandSqueezeEvent;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public HandEvent HandUnsqueezeEvent;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<Hand> hands;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool grabbing;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		private bool squeezing;

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x93EFF4", Offset = "0x93EFF4", VA = "0x93EFF4", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x93F3A8", Offset = "0x93F3A8", VA = "0x93F3A8", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x93F778", Offset = "0x93F778", VA = "0x93F778", Slot = "6")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x93F8F4", Offset = "0x93F8F4", VA = "0x93F8F4", Slot = "7")]
		public virtual void Enter(Hand hand)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x93FA54", Offset = "0x93FA54", VA = "0x93FA54", Slot = "8")]
		public virtual void Exit(Hand hand)
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x93FCF8", Offset = "0x93FCF8", VA = "0x93FCF8", Slot = "9")]
		public virtual void Grab(Hand hand)
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x93FE0C", Offset = "0x93FE0C", VA = "0x93FE0C", Slot = "10")]
		public virtual void Release(Hand hand)
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x93FF1C", Offset = "0x93FF1C", VA = "0x93FF1C", Slot = "11")]
		public virtual void Squeeze(Hand hand)
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x940060", Offset = "0x940060", VA = "0x940060", Slot = "12")]
		public virtual void Unsqueeze(Hand hand)
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x94019C", Offset = "0x94019C", VA = "0x94019C")]
		public HandTriggerAreaEvents()
		{
		}
	}
	[Token(Token = "0x200013F")]
	public class EditorHand : MonoBehaviour
	{
		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool useEditorGUI;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GrabbablePose grabbablePose;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HandPoseArea grabbablePoseArea;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Hand _hand;

		[Token(Token = "0x1700007D")]
		public Hand hand
		{
			[Token(Token = "0x600073E")]
			[Address(RVA = "0x940634", Offset = "0x940634", VA = "0x940634")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x9406DC", Offset = "0x9406DC", VA = "0x9406DC")]
		public EditorHand()
		{
		}
	}
	[Token(Token = "0x2000140")]
	[DefaultExecutionOrder(-2)]
	public class GrabbableBase : MonoBehaviour
	{
		[Token(Token = "0x2000142")]
		[CompilerGenerated]
		private sealed class <IgnoreHandCollision>d__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GrabbableBase <>4__this;

			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Hand hand;

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float time;

			[Token(Token = "0x17000080")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600075B")]
				[Address(RVA = "0x941914", Offset = "0x941914", VA = "0x941914", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000081")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600075D")]
				[Address(RVA = "0x94195C", Offset = "0x94195C", VA = "0x94195C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000758")]
			[Address(RVA = "0x9413AC", Offset = "0x9413AC", VA = "0x9413AC")]
			[DebuggerHidden]
			public <IgnoreHandCollision>d__40(int <>1__state)
			{
			}

			[Token(Token = "0x6000759")]
			[Address(RVA = "0x94181C", Offset = "0x94181C", VA = "0x94181C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600075A")]
			[Address(RVA = "0x941820", Offset = "0x941820", VA = "0x941820", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0x94191C", Offset = "0x94191C", VA = "0x94191C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AutoHeader("Grabbable", 0, 0)]
		public bool ignoreMe;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The physics body to connect this colliders grab to - if left empty will default to local body")]
		public Rigidbody body;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("A copy of the mesh will be created and slighly scaled and this material will be applied to create a highlight effect with options")]
		public Material hightlightMaterial;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public bool isGrabbable;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PlacePoint _placePoint;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal bool ignoreParent;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected List<Hand> heldBy;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected bool hightlighting;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected GameObject highlightObj;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected PlacePoint lastPlacePoint;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected Transform originalParent;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected Vector3 lastCenterOfMassPos;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		protected Quaternion lastCenterOfMassRot;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		protected CollisionDetectionMode detectionMode;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected RigidbodyInterpolation startInterpolation;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		protected internal bool beingGrabbed;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
		protected bool heldBodyJointed;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x96")]
		protected bool wasIsGrabbable;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x97")]
		protected bool beingDestroyed;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected int originalLayer;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		protected Coroutine resetLayerRoutine;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		protected List<GrabbableChild> grabChildren;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected List<Transform> jointedParents;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected GrabbablePoseCombiner poseCombiner;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private CollisionTracker _collisionTracker;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected List<Collider> grabColliders;

		[Token(Token = "0x1700007E")]
		public PlacePoint placePoint
		{
			[Token(Token = "0x6000740")]
			[Address(RVA = "0x9406EC", Offset = "0x9406EC", VA = "0x9406EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000741")]
			[Address(RVA = "0x9406F4", Offset = "0x9406F4", VA = "0x9406F4")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public CollisionTracker collisionTracker
		{
			[Token(Token = "0x6000742")]
			[Address(RVA = "0x9406FC", Offset = "0x9406FC", VA = "0x9406FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000743")]
			[Address(RVA = "0x9407C8", Offset = "0x9407C8", VA = "0x9407C8")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x940868", Offset = "0x940868", VA = "0x940868", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x940D24", Offset = "0x940D24", VA = "0x940D24", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x940F44", Offset = "0x940F44", VA = "0x940F44", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x940FDC", Offset = "0x940FDC", VA = "0x940FDC", Slot = "7")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x941020", Offset = "0x941020", VA = "0x941020")]
		internal void SetPlacePoint(PlacePoint point)
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x941028", Offset = "0x941028", VA = "0x941028")]
		internal void SetGrabbableChild(GrabbableChild child)
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x941110", Offset = "0x941110", VA = "0x941110")]
		protected int GetOriginalLayer()
		{
			return default(int);
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x941118", Offset = "0x941118", VA = "0x941118")]
		internal void SetLayerRecursive(Transform obj, int oldLayer, int newLayer)
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x9412BC", Offset = "0x9412BC", VA = "0x9412BC")]
		internal void SetLayerRecursive(Transform obj, int newLayer)
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x94130C", Offset = "0x94130C", VA = "0x94130C")]
		[IteratorStateMachine(typeof(<IgnoreHandCollision>d__40))]
		protected IEnumerator IgnoreHandCollision(float time, Hand hand)
		{
			return null;
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x9413D4", Offset = "0x9413D4", VA = "0x9413D4")]
		public bool GetSavedPose(out GrabbablePoseCombiner pose)
		{
			return default(bool);
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x941438", Offset = "0x941438", VA = "0x941438")]
		public bool HasCustomPose()
		{
			return default(bool);
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x941460", Offset = "0x941460", VA = "0x941460")]
		public void IgnoreHand(Hand hand, bool ignore)
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x940BBC", Offset = "0x940BBC", VA = "0x940BBC")]
		private void SetCollidersRecursive(Transform obj)
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x941658", Offset = "0x941658", VA = "0x941658")]
		protected void ResetRigidbody()
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x941690", Offset = "0x941690", VA = "0x941690")]
		public bool BeingDestroyed()
		{
			return default(bool);
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x941698", Offset = "0x941698", VA = "0x941698")]
		public void DebugBreak()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x94169C", Offset = "0x94169C", VA = "0x94169C")]
		public GrabbableBase()
		{
		}
	}
	[Token(Token = "0x2000143")]
	public enum HandMovementType
	{
		[Token(Token = "0x40007AF")]
		Legacy,
		[Token(Token = "0x40007B0")]
		Forces
	}
	[Token(Token = "0x2000144")]
	public enum HandType
	{
		[Token(Token = "0x40007B2")]
		both,
		[Token(Token = "0x40007B3")]
		right,
		[Token(Token = "0x40007B4")]
		left,
		[Token(Token = "0x40007B5")]
		none
	}
	[Token(Token = "0x2000145")]
	public enum GrabType
	{
		[Token(Token = "0x40007B7")]
		HandToGrabbable,
		[Token(Token = "0x40007B8")]
		GrabbableToHand,
		[Token(Token = "0x40007B9")]
		InstantGrab
	}
	[Serializable]
	[Token(Token = "0x2000146")]
	public struct VelocityTimePair
	{
		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float time;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Vector3 velocity;
	}
	[Token(Token = "0x2000147")]
	public delegate void HandGrabEvent(Hand hand, Grabbable grabbable);
	[Token(Token = "0x2000148")]
	public delegate void HandGameObjectEvent(Hand hand, GameObject other);
	[Serializable]
	[Token(Token = "0x2000149")]
	public class UnityHandGrabEvent : UnityEvent<Hand, Grabbable>
	{
		[Token(Token = "0x6000766")]
		[Address(RVA = "0x93DC70", Offset = "0x93DC70", VA = "0x93DC70")]
		public UnityHandGrabEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200014A")]
	public class UnityHandEvent : UnityEvent<Hand>
	{
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x93B25C", Offset = "0x93B25C", VA = "0x93B25C")]
		public UnityHandEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200014B")]
	[RequireComponent(typeof(Rigidbody))]
	[DefaultExecutionOrder(-10)]
	public class HandBase : MonoBehaviour
	{
		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AutoHeader("AUTO HAND", 0, 0)]
		public bool ignoreMe;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Finger[] fingers;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("An empty GameObject that should be placed on the surface of the center of the palm")]
		public Transform palmTransform;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Whether this is the left (on) or right (off) hand")]
		[FormerlySerializedAs("isLeft")]
		public bool left;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Min(0.01f)]
		[Tooltip("Maximum distance for pickup")]
		[Space]
		public float reachDistance;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AutoToggleHeader("Enable Movement", 0, 0, tooltip = "Whether or not to enable the hand's Rigidbody Physics movement")]
		public bool enableMovement;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[EnableIf("enableMovement")]
		[Tooltip("Follow target, the hand will always try to match this transforms position with rigidbody movements")]
		public Transform follow;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[EnableIf("enableMovement")]
		[Tooltip("Returns hand to the target after this distance [helps just in case it gets stuck]")]
		[Min(0f)]
		public float maxFollowDistance;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Min(0f)]
		[EnableIf("enableMovement")]
		[Tooltip("Amplifier for applied velocity on released object")]
		public float throwPower;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public bool advancedFollowSettings;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		[Tooltip("Turn this on when you want to animate the hand or use other IK Drivers")]
		[AutoToggleHeader("Enable Auto Posing", 0, 0, tooltip = "Auto Posing will override Unity Animations -- This will disable all the Auto Hand IK, including animations from: finger sway, pose areas, finger bender scripts (runtime Auto Posing will still work)")]
		public bool enableIK;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("How much the fingers sway from the velocity")]
		[EnableIf("enableIK")]
		public float swayStrength;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[EnableIf("enableIK")]
		[Tooltip("This will offset each fingers bend (0 is no bend, 1 is full bend)")]
		public float gripOffset;

		[NonSerialized]
		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("The maximum allowed velocity of the hand")]
		[Min(0f)]
		public float maxVelocity;

		[NonSerialized]
		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Follow target speed (Can cause jittering if turned too high - recommend increasing drag with speed)")]
		[Min(0f)]
		public float followPositionStrength;

		[NonSerialized]
		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[HideInInspector]
		[Min(0f)]
		[Tooltip("Follow target rotation speed (Can cause jittering if turned too high - recommend increasing angular drag with speed)")]
		public float followRotationStrength;

		[NonSerialized]
		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		[Tooltip("After this many seconds velocity data within a 'throw window' will be tossed out. (This allows you to get only use acceeleration data from the last 'x' seconds of the throw.)")]
		public float throwVelocityExpireTime;

		[NonSerialized]
		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[HideInInspector]
		[Tooltip("Increase for closer finger tip results / Decrease for less physics checks - The number of steps the fingers take when bending to grab something")]
		public int fingerBendSteps;

		[NonSerialized]
		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public float sphereCastRadius;

		[NonSerialized]
		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[HideInInspector]
		public float maxCollisionDistance;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public bool usingPoseAreas;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[HideInInspector]
		public QueryTriggerInteraction queryTriggerInteraction;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Grabbable HoldingObj;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Grabbable _lookingAtObj;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Transform _moveTo;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 _grabPositionOffset;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Quaternion _grabRotationOffset;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private CollisionTracker _collisionTracker;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected GrabbablePose _grabPose;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		protected Joint heldJoint;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected bool grabbing;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		protected bool squeezing;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDA")]
		protected bool grabbed;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		protected float triggerPoint;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		protected Coroutine handAnimateRoutine;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		protected HandPoseArea handPoseArea;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected HandPoseData preHandPoseAreaPose;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		protected List<Collider> handColliders;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Transform _grabPoint;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Transform _grabPosition;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		internal int handLayers;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		protected Collider palmCollider;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		protected RaycastHit highlightHit;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		protected HandVelocityTracker velocityTracker;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		protected Transform palmChild;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		protected Vector3 lastFrameFollowPos;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		protected Quaternion lastFrameFollowRot;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		protected Vector3 followVel;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		protected Vector3 followAngularVel;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		internal bool allowUpdateMovement;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Vector3[] handRays;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private RaycastHit[] rayHits;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private List<RaycastHit> closestHits;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private List<Grabbable> closestGrabs;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private int tryMaxDistanceCount;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
		private Vector3 lastFollowPosition;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Vector3 lastFollowRotation;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private bool prerendered;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private Vector3 preRenderPos;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
		private Quaternion preRenderRot;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		private float currGrip;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		protected Vector3 lastFixedPosition;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x234")]
		private float lastUpdateTime;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		protected bool ignoreMoveFrame;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
		private float fingerSwayVel;

		[Token(Token = "0x17000082")]
		public Grabbable holdingObj
		{
			[Token(Token = "0x6000768")]
			[Address(RVA = "0x941B34", Offset = "0x941B34", VA = "0x941B34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000769")]
			[Address(RVA = "0x941B3C", Offset = "0x941B3C", VA = "0x941B3C")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public Grabbable lookingAtObj
		{
			[Token(Token = "0x600076A")]
			[Address(RVA = "0x941B44", Offset = "0x941B44", VA = "0x941B44")]
			get
			{
				return null;
			}
			[Token(Token = "0x600076B")]
			[Address(RVA = "0x941B4C", Offset = "0x941B4C", VA = "0x941B4C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public Transform moveTo
		{
			[Token(Token = "0x600076C")]
			[Address(RVA = "0x941B54", Offset = "0x941B54", VA = "0x941B54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		public Rigidbody body
		{
			[Token(Token = "0x600076D")]
			[Address(RVA = "0x941C8C", Offset = "0x941C8C", VA = "0x941C8C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600076E")]
			[Address(RVA = "0x941C94", Offset = "0x941C94", VA = "0x941C94")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public Vector3 grabPositionOffset
		{
			[Token(Token = "0x600076F")]
			[Address(RVA = "0x941C9C", Offset = "0x941C9C", VA = "0x941C9C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000770")]
			[Address(RVA = "0x941CA8", Offset = "0x941CA8", VA = "0x941CA8")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public Quaternion grabRotationOffset
		{
			[Token(Token = "0x6000771")]
			[Address(RVA = "0x941CB4", Offset = "0x941CB4", VA = "0x941CB4")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000772")]
			[Address(RVA = "0x941CC0", Offset = "0x941CC0", VA = "0x941CC0")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public bool disableIK
		{
			[Token(Token = "0x6000773")]
			[Address(RVA = "0x941CCC", Offset = "0x941CCC", VA = "0x941CCC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000774")]
			[Address(RVA = "0x93B5F8", Offset = "0x93B5F8", VA = "0x93B5F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public CollisionTracker collisionTracker
		{
			[Token(Token = "0x6000775")]
			[Address(RVA = "0x941CDC", Offset = "0x941CDC", VA = "0x941CDC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000776")]
			[Address(RVA = "0x941D94", Offset = "0x941D94", VA = "0x941D94")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		protected GrabbablePose grabPose
		{
			[Token(Token = "0x6000777")]
			[Address(RVA = "0x941E34", Offset = "0x941E34", VA = "0x941E34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000778")]
			[Address(RVA = "0x941E3C", Offset = "0x941E3C", VA = "0x941E3C")]
			set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		internal Transform grabPoint
		{
			[Token(Token = "0x6000779")]
			[Address(RVA = "0x941F40", Offset = "0x941F40", VA = "0x941F40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		internal Transform grabPosition
		{
			[Token(Token = "0x600077A")]
			[Address(RVA = "0x94205C", Offset = "0x94205C", VA = "0x94205C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x942194", Offset = "0x942194", VA = "0x942194", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x94263C", Offset = "0x94263C", VA = "0x94263C", Slot = "5")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x9426D0", Offset = "0x9426D0", VA = "0x9426D0", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x942740", Offset = "0x942740", VA = "0x942740", Slot = "7")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x9428D0", Offset = "0x9428D0", VA = "0x9428D0", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x942EC4", Offset = "0x942EC4", VA = "0x942EC4", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x94388C", Offset = "0x94388C", VA = "0x94388C", Slot = "10")]
		public virtual void OnPreRender()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x9442AC", Offset = "0x9442AC", VA = "0x9442AC", Slot = "11")]
		public virtual void OnPostRender()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x9443A8", Offset = "0x9443A8", VA = "0x9443A8", Slot = "12")]
		protected virtual void CreateJoint(Grabbable grab, float breakForce, float breakTorque)
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x944688", Offset = "0x944688", VA = "0x944688", Slot = "13")]
		protected virtual void MoveTo()
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x945144", Offset = "0x945144", VA = "0x945144", Slot = "14")]
		protected virtual void TorqueTo()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x9453FC", Offset = "0x9453FC", VA = "0x9453FC", Slot = "15")]
		public virtual void SetHandLocation(Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x945C04", Offset = "0x945C04", VA = "0x945C04", Slot = "16")]
		public virtual void SetHandLocation(Vector3 pos)
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x945C94", Offset = "0x945C94", VA = "0x945C94")]
		public void ResetHandLocation()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x944C6C", Offset = "0x944C6C", VA = "0x944C6C")]
		protected void SetMoveTo()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x93CEE0", Offset = "0x93CEE0", VA = "0x93CEE0")]
		public bool CanGrab(Grabbable grab)
		{
			return default(bool);
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x945D24", Offset = "0x945D24", VA = "0x945D24")]
		public float GetTriggerAxis()
		{
			return default(float);
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x945D2C", Offset = "0x945D2C", VA = "0x945D2C", Slot = "17")]
		protected virtual Vector3 HandClosestHit(out RaycastHit closestHit, out Grabbable grabbable, float dist, int layerMask, [Optional] Grabbable target)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x9466F8", Offset = "0x9466F8", VA = "0x9466F8")]
		public bool IsPosing()
		{
			return default(bool);
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x9467B0", Offset = "0x9467B0", VA = "0x9467B0", Slot = "18")]
		protected virtual void UpdateFingers()
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x9437D4", Offset = "0x9437D4", VA = "0x9437D4")]
		public int CollisionCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x9415B4", Offset = "0x9415B4", VA = "0x9415B4")]
		public void HandIgnoreCollider(Collider collider, bool ignore)
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x9468A8", Offset = "0x9468A8", VA = "0x9468A8")]
		public void SetLayer()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x946948", Offset = "0x946948", VA = "0x946948")]
		internal void SetLayerRecursive(Transform obj, int newLayer)
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x94265C", Offset = "0x94265C", VA = "0x94265C")]
		protected void SetHandCollidersRecursive(Transform obj)
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x946B4C", Offset = "0x946B4C", VA = "0x946B4C")]
		public Vector3[] GetPalmRays()
		{
			return null;
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x946B70", Offset = "0x946B70", VA = "0x946B70", Slot = "19")]
		protected virtual void SetPalmRays()
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x946DFC", Offset = "0x946DFC", VA = "0x946DFC")]
		public Vector3 ThrowVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x947228", Offset = "0x947228", VA = "0x947228")]
		public Vector3 ThrowAngularVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x9474E0", Offset = "0x9474E0", VA = "0x9474E0")]
		public bool IsGrabbing()
		{
			return default(bool);
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x9474E8", Offset = "0x9474E8", VA = "0x9474E8")]
		public static int GetHandsLayerMask()
		{
			return default(int);
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x9475F8", Offset = "0x9475F8", VA = "0x9475F8")]
		public HandBase()
		{
		}
	}
	[Token(Token = "0x200014C")]
	[RequireComponent(typeof(Hand))]
	public class HandGizmos : MonoBehaviour
	{
		[Token(Token = "0x600079C")]
		[Address(RVA = "0x94786C", Offset = "0x94786C", VA = "0x94786C")]
		public HandGizmos()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200014D")]
	public struct HandPoseData
	{
		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 handOffset;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Quaternion localQuaternionOffset;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3[] posePositions;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Quaternion[] poseRotations;

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x947874", Offset = "0x947874", VA = "0x947874")]
		public HandPoseData(Hand hand, Grabbable grabbable)
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x947E24", Offset = "0x947E24", VA = "0x947E24")]
		public HandPoseData(Hand hand, Transform point)
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x947F54", Offset = "0x947F54", VA = "0x947F54")]
		public HandPoseData(Hand hand)
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x948078", Offset = "0x948078", VA = "0x948078")]
		public HandPoseData(HandPoseData data)
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x9479B8", Offset = "0x9479B8", VA = "0x9479B8")]
		public void SavePose(Hand hand, Transform relativeTo)
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x948280", Offset = "0x948280", VA = "0x948280")]
		public Quaternion GetRotationOffset()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x93ADF0", Offset = "0x93ADF0", VA = "0x93ADF0")]
		public void SetPose(Hand hand, [Optional] Transform relativeTo)
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x93C70C", Offset = "0x93C70C", VA = "0x93C70C")]
		public void SetFingerPose(Hand hand, [Optional] Transform relativeTo)
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x948564", Offset = "0x948564", VA = "0x948564")]
		public void SetPosition(Hand hand, [Optional] Transform relativeTo)
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x93CF60", Offset = "0x93CF60", VA = "0x93CF60")]
		public static HandPoseData LerpPose(HandPoseData from, HandPoseData to, float point)
		{
			return default(HandPoseData);
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x9487B0", Offset = "0x9487B0", VA = "0x9487B0")]
		public static void LerpPose(ref HandPoseData lerpPose, HandPoseData from, HandPoseData to, float point)
		{
		}
	}
	[Token(Token = "0x2000151")]
	[CreateAssetMenu(fileName = "AutoHand Pose", menuName = "Auto Hand/Custom Pose", order = 1)]
	public class HandPoseScriptable : ScriptableObject
	{
		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public bool rightSaved;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[HideInInspector]
		public bool leftSaved;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HandPoseData rightPose;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public HandPoseData leftPose;

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x948B90", Offset = "0x948B90", VA = "0x948B90")]
		public void SavePoses(HandPoseData right, HandPoseData left)
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x948C04", Offset = "0x948C04", VA = "0x948C04")]
		public void SaveRightPose(HandPoseData right)
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x948C40", Offset = "0x948C40", VA = "0x948C40")]
		public void SaveLeftPose(HandPoseData left)
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x948C80", Offset = "0x948C80", VA = "0x948C80")]
		public HandPoseScriptable()
		{
		}
	}
	[Token(Token = "0x2000152")]
	[DefaultExecutionOrder(-5)]
	public class HandStabilizer : MonoBehaviour
	{
		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HandBase hand;

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x948C88", Offset = "0x948C88", VA = "0x948C88")]
		private void Start()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x948D3C", Offset = "0x948D3C", VA = "0x948D3C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x948E80", Offset = "0x948E80", VA = "0x948E80")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x948FC4", Offset = "0x948FC4", VA = "0x948FC4")]
		private void Update()
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x949044", Offset = "0x949044", VA = "0x949044")]
		private void OnPreRender()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x949090", Offset = "0x949090", VA = "0x949090")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x9490DC", Offset = "0x9490DC", VA = "0x9490DC")]
		private void OnPreRender(ScriptableRenderContext src, Camera cam)
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x949128", Offset = "0x949128", VA = "0x949128")]
		private void OnPostRender(ScriptableRenderContext src, Camera cam)
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x949174", Offset = "0x949174", VA = "0x949174")]
		public HandStabilizer()
		{
		}
	}
	[Token(Token = "0x2000153")]
	public class HandVelocityTracker
	{
		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandBase hand;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float minThrowVelocity;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected List<VelocityTimePair> m_ThrowVelocityList;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected List<VelocityTimePair> m_ThrowFrameVelocityList;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected List<VelocityTimePair> m_ThrowAngleVelocityList;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float disableTime;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float disableSeconds;

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x945B8C", Offset = "0x945B8C", VA = "0x945B8C")]
		public void ClearThrow()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x94917C", Offset = "0x94917C", VA = "0x94917C")]
		public void Disable(float seconds)
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x942548", Offset = "0x942548", VA = "0x942548")]
		public HandVelocityTracker(HandBase hand)
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x942B74", Offset = "0x942B74", VA = "0x942B74")]
		public void UpdateThrowing()
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x946E14", Offset = "0x946E14", VA = "0x946E14")]
		public Vector3 ThrowVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x947240", Offset = "0x947240", VA = "0x947240")]
		public Vector3 ThrowAngularVelocity()
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000154")]
	public class KeyboardHand : MonoBehaviour
	{
		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Hand hand;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float speed;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float flySpeed;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool useLocal;

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x9491A8", Offset = "0x9491A8", VA = "0x9491A8")]
		private void Update()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x9494A8", Offset = "0x9494A8", VA = "0x9494A8")]
		public KeyboardHand()
		{
		}
	}
	[Token(Token = "0x2000155")]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(CapsuleCollider))]
	[HelpURL("https://earnestrobot.notion.site/Auto-Move-Player-02d91305a4294e039049bd45cacc5b90")]
	[DefaultExecutionOrder(-3)]
	public class AutoHandPlayer : MonoBehaviour
	{
		[Token(Token = "0x2000156")]
		[CompilerGenerated]
		private sealed class <CheckForTrackingStart>d__83 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000866")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000867")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000868")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AutoHandPlayer <>4__this;

			[Token(Token = "0x1700008F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007F6")]
				[Address(RVA = "0x950ADC", Offset = "0x950ADC", VA = "0x950ADC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000090")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007F8")]
				[Address(RVA = "0x950B24", Offset = "0x950B24", VA = "0x950B24", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x95089C", Offset = "0x95089C", VA = "0x95089C")]
			[DebuggerHidden]
			public <CheckForTrackingStart>d__83(int <>1__state)
			{
			}

			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x9508C4", Offset = "0x9508C4", VA = "0x9508C4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x9508C8", Offset = "0x9508C8", VA = "0x9508C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x950AE4", Offset = "0x950AE4", VA = "0x950AE4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000157")]
		[CompilerGenerated]
		private sealed class <DisableGroundingSecondsRoutine>d__111 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000869")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400086A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400086B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AutoHandPlayer <>4__this;

			[Token(Token = "0x400086C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float seconds;

			[Token(Token = "0x17000091")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007FC")]
				[Address(RVA = "0x950C24", Offset = "0x950C24", VA = "0x950C24", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000092")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007FE")]
				[Address(RVA = "0x950C6C", Offset = "0x950C6C", VA = "0x950C6C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x950B2C", Offset = "0x950B2C", VA = "0x950B2C")]
			[DebuggerHidden]
			public <DisableGroundingSecondsRoutine>d__111(int <>1__state)
			{
			}

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x950B54", Offset = "0x950B54", VA = "0x950B54", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x950B58", Offset = "0x950B58", VA = "0x950B58", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x950C2C", Offset = "0x950C2C", VA = "0x950C2C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool notFound;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static AutoHandPlayer _Instance;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AutoHeader("Auto Hand Player", 0, 0)]
		public bool ignoreMe;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The tracked headCamera object")]
		public Camera headCamera;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The object that represents the forward direction movement, usually should be set as the camera or a tracked controller")]
		public Transform forwardFollow;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("This should NOT be a child of this body. This should be a GameObject that contains all the tracked objects (head/controllers)")]
		public Transform trackingContainer;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Hand handRight;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Hand handLeft;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AutoToggleHeader("Movement", 0, 0)]
		public bool useMovement;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("Movement speed when isGrounded")]
		[FormerlySerializedAs("moveSpeed")]
		[EnableIf("useMovement")]
		public float maxMoveSpeed;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[EnableIf("useMovement")]
		[Tooltip("Movement acceleration when isGrounded")]
		public float moveAcceleration;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("Movement acceleration when isGrounded")]
		[EnableIf("useMovement")]
		public float groundedDrag;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[EnableIf("useMovement")]
		public float heightSmoothSpeed;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Min(0f)]
		[Tooltip("Whether or not to use snap turning or smooth turning")]
		[AutoToggleHeader("Snap Turning", 0, 0)]
		public bool snapTurning;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("turn speed when not using snap turning - if snap turning, represents angle per snap")]
		[ShowIf("snapTurning")]
		public float snapTurnAngle;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[HideIf("snapTurning")]
		public float smoothTurnSpeed;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AutoToggleHeader("Height", 0, 0)]
		public bool ignoreMe2;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[ShowIf("ignoreMe2")]
		public float heightOffset;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[ShowIf("ignoreMe2")]
		public bool crouching;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[ShowIf("ignoreMe2")]
		public float crouchHeight;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("Whether or not the capsule height should be adjusted to match the headCamera height")]
		[ShowIf("ignoreMe2")]
		public bool autoAdjustColliderHeight;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Tooltip("Minimum and maximum auto adjusted height, to adjust height without auto adjustment change capsule collider height instead")]
		[ShowIf("ignoreMe2")]
		public Vector2 minMaxHeight;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[ShowIf("ignoreMe2")]
		public bool useHeadCollision;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[ShowIf("ignoreMe2")]
		public float headRadius;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AutoToggleHeader("Use Grounding", 0, 0)]
		public bool useGrounding;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Tooltip("Maximum height that the body can step up onto")]
		[Min(0f)]
		[EnableIf("useGrounding")]
		public float maxStepHeight;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[Min(0f)]
		[Tooltip("Maximum angle the player can walk on")]
		[EnableIf("useGrounding")]
		public float maxStepAngle;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[Tooltip("The layers that count as ground")]
		[EnableIf("useGrounding")]
		public LayerMask groundLayerMask;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[AutoToggleHeader("Enable Climbing", 0, 0)]
		[Tooltip("Whether or not the player can use Climbable objects  (Objects with the Climbable component)")]
		public bool allowClimbing;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
		[Tooltip("Whether or not the player move while climbing")]
		[ShowIf("allowClimbing")]
		public bool allowClimbingMovement;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Tooltip("How quickly the player can climb")]
		[ShowIf("allowClimbing")]
		public Vector3 climbingStrength;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float climbingAcceleration;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float climbingDrag;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AutoToggleHeader("Enable Pushing", 0, 0)]
		[Tooltip("Whether or not the player can use Pushable objects (Objects with the Pushable component)")]
		public bool allowBodyPushing;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[Tooltip("How quickly the player can climb")]
		[EnableIf("allowBodyPushing")]
		public Vector3 pushingStrength;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float pushingAcceleration;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float pushingDrag;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AutoToggleHeader("Enable Platforming", 0, 0)]
		[Tooltip("Platforms will move the player with them. A platform is an object with the Transform component on it")]
		public bool allowPlatforms;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AutoToggleHeader("Use Input Deadzone", 0, 0)]
		private float movementDeadzone;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float turnDeadzone;

		[Token(Token = "0x400083F")]
		public const string HandPlayerLayer = "HandPlayer";

		[Token(Token = "0x4000840")]
		private const int groundRayCount = 21;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float turnResetzone;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float groundedOffset;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private HeadPhysicsFollower headPhysicsFollower;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private CapsuleCollider bodyCapsule;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Vector3 moveDirection;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private float turningAxis;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool isGrounded;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
		private bool axisReset;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private float playerHeight;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private bool lastCrouching;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private float lastCrouchingHeight;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion startRot;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 targetTrackedPos;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 lastUpdatePosition;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Hand lastRightHand;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Hand lastLeftHand;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3 climbAxis;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Dictionary<Hand, Climbable> climbing;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Dictionary<Pushable, Hand> pushRight;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Dictionary<Pushable, int> pushRightCount;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Dictionary<Pushable, Hand> pushLeft;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Dictionary<Pushable, int> pushLeftCount;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private Vector3 pushAxis;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		private Vector3 lastPlatformPosition;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private Quaternion lastPlatformRotation;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private RaycastHit closestHit;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		private float lastUpdateTime;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private bool ignoreIterpolationFrame;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private Vector3 targetPosOffset;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private int handPlayerMask;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
		private bool trackingStarted;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Vector3 lastHeadPos;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private Vector3 offset;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private RaycastHit newClosestHit;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
		private float highestPoint;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private Coroutine disableGroundingRoutine;

		[Token(Token = "0x1700008D")]
		public static AutoHandPlayer Instance
		{
			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x9494C0", Offset = "0x9494C0", VA = "0x9494C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		public Rigidbody body
		{
			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x9495D8", Offset = "0x9495D8", VA = "0x9495D8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x9495E0", Offset = "0x9495E0", VA = "0x9495E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x9495E8", Offset = "0x9495E8", VA = "0x9495E8", Slot = "4")]
		public virtual void Start()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x949B90", Offset = "0x949B90", VA = "0x949B90", Slot = "5")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x949DD4", Offset = "0x949DD4", VA = "0x949DD4", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x949B1C", Offset = "0x949B1C", VA = "0x949B1C")]
		[IteratorStateMachine(typeof(<CheckForTrackingStart>d__83))]
		private IEnumerator CheckForTrackingStart()
		{
			return null;
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x94A0D8", Offset = "0x94A0D8", VA = "0x94A0D8", Slot = "7")]
		protected virtual void OnHeadTrackingStarted()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x949840", Offset = "0x949840", VA = "0x949840")]
		private void CreateHeadFollower()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x94A110", Offset = "0x94A110", VA = "0x94A110")]
		private void CheckHands()
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x949BB0", Offset = "0x949BB0", VA = "0x949BB0")]
		private void EnableHand(Hand hand)
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x949DF4", Offset = "0x949DF4", VA = "0x949DF4")]
		private void DisableHand(Hand hand)
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x94A1FC", Offset = "0x94A1FC", VA = "0x94A1FC")]
		private void OnHandGrab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x94A2A8", Offset = "0x94A2A8", VA = "0x94A2A8")]
		private void OnHandRelease(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x94A400", Offset = "0x94A400", VA = "0x94A400", Slot = "8")]
		public virtual void Move(Vector2 axis, bool useDeadzone = true, bool useRelativeDirection = false)
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x94A480", Offset = "0x94A480", VA = "0x94A480", Slot = "9")]
		public virtual void Turn(float turnAxis)
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x94A49C", Offset = "0x94A49C", VA = "0x94A49C")]
		private void Update()
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x94A9DC", Offset = "0x94A9DC", VA = "0x94A9DC", Slot = "10")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x94AA8C", Offset = "0x94AA8C", VA = "0x94AA8C", Slot = "11")]
		protected virtual void UpdateRigidbody(Vector3 moveDir)
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x94B850", Offset = "0x94B850", VA = "0x94B850")]
		private void SyncBodyHead()
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x94C238", Offset = "0x94C238", VA = "0x94C238", Slot = "12")]
		protected virtual bool CanInputMove()
		{
			return default(bool);
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x94C260", Offset = "0x94C260", VA = "0x94C260", Slot = "13")]
		protected virtual void InterpolateMovement()
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x94D264", Offset = "0x94D264", VA = "0x94D264", Slot = "14")]
		protected virtual void UpdateTurn(float deltaTime)
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x94D6F4", Offset = "0x94D6F4", VA = "0x94D6F4", Slot = "15")]
		protected virtual void Ground()
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x94DDD0", Offset = "0x94DDD0", VA = "0x94DDD0")]
		public bool IsGrounded()
		{
			return default(bool);
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x94DDD8", Offset = "0x94DDD8", VA = "0x94DDD8")]
		public void ToggleFlying()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x94DE0C", Offset = "0x94DE0C", VA = "0x94DE0C", Slot = "16")]
		protected virtual void UpdatePlayerHeight()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x94A4F0", Offset = "0x94A4F0", VA = "0x94A4F0")]
		protected void UpdatePlatform(bool isFixedUpdate)
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x94DF38", Offset = "0x94DF38", VA = "0x94DF38")]
		public void Jump(float jumpPower = 1f)
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x94E008", Offset = "0x94E008", VA = "0x94E008")]
		public void DisableGrounding(float seconds)
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x94E06C", Offset = "0x94E06C", VA = "0x94E06C")]
		[IteratorStateMachine(typeof(<DisableGroundingSecondsRoutine>d__111))]
		private IEnumerator DisableGroundingSecondsRoutine(float seconds)
		{
			return null;
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x94E0F0", Offset = "0x94E0F0", VA = "0x94E0F0")]
		public void AddVelocity(Vector3 force, ForceMode mode = ForceMode.Acceleration)
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x94E10C", Offset = "0x94E10C", VA = "0x94E10C", Slot = "17")]
		protected virtual void StartPush(Hand hand, GameObject other)
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x94E340", Offset = "0x94E340", VA = "0x94E340", Slot = "18")]
		protected virtual void StopPush(Hand hand, GameObject other)
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x94E534", Offset = "0x94E534", VA = "0x94E534", Slot = "19")]
		protected virtual void StartGrabPush(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x94E6A4", Offset = "0x94E6A4", VA = "0x94E6A4", Slot = "20")]
		protected virtual void EndGrabPush(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x94E818", Offset = "0x94E818", VA = "0x94E818", Slot = "21")]
		protected virtual void ApplyPushingForce()
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x94F210", Offset = "0x94F210", VA = "0x94F210")]
		public bool IsPushing()
		{
			return default(bool);
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x94F450", Offset = "0x94F450", VA = "0x94F450", Slot = "22")]
		protected virtual void StartClimb(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x94F5F8", Offset = "0x94F5F8", VA = "0x94F5F8", Slot = "23")]
		protected virtual void EndClimb(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x94F690", Offset = "0x94F690", VA = "0x94F690", Slot = "24")]
		protected virtual void ApplyClimbingForce()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x94B6CC", Offset = "0x94B6CC", VA = "0x94B6CC")]
		public bool IsClimbing()
		{
			return default(bool);
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x94F988", Offset = "0x94F988", VA = "0x94F988", Slot = "25")]
		public virtual void SetPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x94FA10", Offset = "0x94FA10", VA = "0x94FA10", Slot = "26")]
		public virtual void SetPosition(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x94FE1C", Offset = "0x94FE1C", VA = "0x94FE1C", Slot = "27")]
		public virtual void SetRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x950194", Offset = "0x950194", VA = "0x950194", Slot = "28")]
		public virtual void AddRotation(Quaternion addRotation)
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x950468", Offset = "0x950468", VA = "0x950468", Slot = "29")]
		public virtual void Recenter()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x94B620", Offset = "0x94B620", VA = "0x94B620")]
		private Vector3 AlterDirection(Vector3 moveAxis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x950660", Offset = "0x950660", VA = "0x950660")]
		public AutoHandPlayer()
		{
		}
	}
	[Token(Token = "0x2000158")]
	[RequireComponent(typeof(Grabbable))]
	public class Climbable : MonoBehaviour
	{
		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Stabber stabber;

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x950C74", Offset = "0x950C74", VA = "0x950C74")]
		private void Start()
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x950F5C", Offset = "0x950F5C", VA = "0x950F5C")]
		public Climbable()
		{
		}
	}
	[Token(Token = "0x2000159")]
	[RequireComponent(typeof(Rigidbody))]
	public class HeadPhysicsFollower : MonoBehaviour
	{
		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("References")]
		public Camera headCamera;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingContainer;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform followBody;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Follow Settings")]
		public float followStrength;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The maximum allowed distance from the body for the headCamera to still move")]
		internal SphereCollider headCollider;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 startHeadPos;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool started;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _moveTo;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal Rigidbody body;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CollisionTracker collisionTracker;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float lastUpdateTime;

		[Token(Token = "0x17000093")]
		private Transform moveTo
		{
			[Token(Token = "0x6000803")]
			[Address(RVA = "0x950FD4", Offset = "0x950FD4", VA = "0x950FD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x951164", Offset = "0x951164", VA = "0x951164")]
		public void Start()
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x951378", Offset = "0x951378", VA = "0x951378")]
		internal void Init()
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x95155C", Offset = "0x95155C", VA = "0x95155C")]
		protected void FixedUpdate()
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x951644", Offset = "0x951644", VA = "0x951644")]
		public bool Started()
		{
			return default(bool);
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x95164C", Offset = "0x95164C", VA = "0x95164C", Slot = "4")]
		internal virtual void MoveTo()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x951870", Offset = "0x951870", VA = "0x951870", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x951CDC", Offset = "0x951CDC", VA = "0x951CDC")]
		public int CollisionCount()
		{
			return default(int);
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x951D3C", Offset = "0x951D3C", VA = "0x951D3C")]
		public HeadPhysicsFollower()
		{
		}
	}
	[Token(Token = "0x200015A")]
	[DefaultExecutionOrder(-50)]
	[RequireComponent(typeof(InterpolatedTransformUpdater))]
	public class InterpolatedTransform : MonoBehaviour
	{
		[Token(Token = "0x200015B")]
		private struct TransformData
		{
			[Token(Token = "0x400087E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x400087F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Quaternion rotation;

			[Token(Token = "0x4000880")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 scale;

			[Token(Token = "0x6000815")]
			[Address(RVA = "0x951E8C", Offset = "0x951E8C", VA = "0x951E8C")]
			public TransformData(Vector3 position, Quaternion rotation, Vector3 scale)
			{
			}
		}

		[Token(Token = "0x200015C")]
		[CompilerGenerated]
		private sealed class <Disable>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000881")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000882")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000883")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public InterpolatedTransform <>4__this;

			[Token(Token = "0x4000884")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float time;

			[Token(Token = "0x17000094")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000819")]
				[Address(RVA = "0x952564", Offset = "0x952564", VA = "0x952564", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000095")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600081B")]
				[Address(RVA = "0x9525AC", Offset = "0x9525AC", VA = "0x9525AC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000816")]
			[Address(RVA = "0x95245C", Offset = "0x95245C", VA = "0x95245C")]
			[DebuggerHidden]
			public <Disable>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000817")]
			[Address(RVA = "0x952494", Offset = "0x952494", VA = "0x952494", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000818")]
			[Address(RVA = "0x952498", Offset = "0x952498", VA = "0x952498", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600081A")]
			[Address(RVA = "0x95256C", Offset = "0x95256C", VA = "0x95256C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TransformData[] m_lastTransforms;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_newTransformIndex;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool run;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Coroutine disableForTime;

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x951D4C", Offset = "0x951D4C", VA = "0x951D4C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x951D50", Offset = "0x951D50", VA = "0x951D50")]
		public void ForgetPreviousTransforms()
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x951EB0", Offset = "0x951EB0", VA = "0x951EB0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x951FB8", Offset = "0x951FB8", VA = "0x951FB8")]
		public void LateFixedUpdate()
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x9520B8", Offset = "0x9520B8", VA = "0x9520B8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x952334", Offset = "0x952334", VA = "0x952334")]
		public void DisableForSeconds(float time)
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x9523D8", Offset = "0x9523D8", VA = "0x9523D8")]
		[IteratorStateMachine(typeof(<Disable>d__10))]
		private IEnumerator Disable(float time)
		{
			return null;
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x9520A8", Offset = "0x9520A8", VA = "0x9520A8")]
		private int OldTransformIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x952484", Offset = "0x952484", VA = "0x952484")]
		public InterpolatedTransform()
		{
		}
	}
	[Token(Token = "0x200015D")]
	[DefaultExecutionOrder(100)]
	public class InterpolatedTransformUpdater : MonoBehaviour
	{
		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private InterpolatedTransform _interpolatedTransform;

		[Token(Token = "0x17000096")]
		private InterpolatedTransform interpolatedTransform
		{
			[Token(Token = "0x600081C")]
			[Address(RVA = "0x9525B4", Offset = "0x9525B4", VA = "0x9525B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x95265C", Offset = "0x95265C", VA = "0x95265C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x952678", Offset = "0x952678", VA = "0x952678")]
		public InterpolatedTransformUpdater()
		{
		}
	}
	[Token(Token = "0x200015E")]
	[DefaultExecutionOrder(-100)]
	public class InterpolationController : MonoBehaviour
	{
		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float[] m_lastFixedUpdateTimes;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_newTimeIndex;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float m_interpolationFactor;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static InterpolationController _Instance;

		[Token(Token = "0x17000097")]
		public static float InterpolationFactor
		{
			[Token(Token = "0x600081F")]
			[Address(RVA = "0x952680", Offset = "0x952680", VA = "0x952680")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000098")]
		public static InterpolationController Instance
		{
			[Token(Token = "0x6000820")]
			[Address(RVA = "0x9526C8", Offset = "0x9526C8", VA = "0x9526C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x952858", Offset = "0x952858", VA = "0x952858")]
		public void Start()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x9528B8", Offset = "0x9528B8", VA = "0x9528B8")]
		public void FixedUpdate()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x952920", Offset = "0x952920", VA = "0x952920")]
		public void Update()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x952910", Offset = "0x952910", VA = "0x952910")]
		private int OldTimeIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x9529E0", Offset = "0x9529E0", VA = "0x9529E0")]
		public InterpolationController()
		{
		}
	}
	[Token(Token = "0x200015F")]
	public class PlayerPlatform : MonoBehaviour
	{
		[Token(Token = "0x6000826")]
		[Address(RVA = "0x9529E8", Offset = "0x9529E8", VA = "0x9529E8")]
		public PlayerPlatform()
		{
		}
	}
	[Token(Token = "0x2000160")]
	public class Pushable : MonoBehaviour
	{
		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 strengthScale;

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x9529F0", Offset = "0x9529F0", VA = "0x9529F0")]
		public Pushable()
		{
		}
	}
	[Token(Token = "0x2000161")]
	public class Teleporter : MonoBehaviour
	{
		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The object to teleport")]
		[Header("Teleport")]
		public GameObject teleportObject;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Can be left empty - Used for if there is a container that should be teleported in addition to the main teleport object")]
		public Transform[] additionalTeleports;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The Object to Shoot the Beam From")]
		[Header("Aim Settings")]
		public Transform aimer;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Layers You Can Teleport On")]
		public LayerMask layer;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("The Maximum Slope You Can Teleport On")]
		public float maxSurfaceAngle;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Min(0f)]
		public float distanceMultiplyer;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Min(0f)]
		public float curveStrength;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Use Worldspace Must be True")]
		public LineRenderer line;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Maximum Length of The Teleport Line")]
		public int lineSegments;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Line Settings")]
		public Gradient canTeleportColor;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Gradient cantTeleportColor;

		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("This gameobject will match the position of the teleport point when aiming")]
		public GameObject indicator;

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("Unity Events")]
		public UnityEvent OnStartTeleport;

		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UnityEvent OnStopTeleport;

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public UnityEvent OnTeleport;

		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3[] lineArr;

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool aiming;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool hitting;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private RaycastHit aimHit;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private HandTeleportGuard[] teleportGuards;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AutoHandPlayer playerBody;

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x952A50", Offset = "0x952A50", VA = "0x952A50")]
		private void Start()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x952BB8", Offset = "0x952BB8", VA = "0x952BB8")]
		private void Update()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x952BF8", Offset = "0x952BF8", VA = "0x952BF8")]
		private void CalculateTeleport()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x953180", Offset = "0x953180", VA = "0x953180")]
		private void DrawIndicator()
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x953294", Offset = "0x953294", VA = "0x953294")]
		public void StartTeleport()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x9532B4", Offset = "0x9532B4", VA = "0x9532B4")]
		public void CancelTeleport()
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x9532F4", Offset = "0x9532F4", VA = "0x9532F4")]
		public void Teleport()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x953640", Offset = "0x953640", VA = "0x953640")]
		public Teleporter()
		{
		}
	}
	[Token(Token = "0x2000162")]
	public class AutoInputModule : BaseInputModule
	{
		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<HandCanvasPointer> pointers;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PointerEventData[] eventDatas;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AutoInputModule _instance;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _isDestroyed;

		[Token(Token = "0x17000099")]
		public AutoInputModule Instance
		{
			[Token(Token = "0x6000830")]
			[Address(RVA = "0x953788", Offset = "0x953788", VA = "0x953788")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x9538E4", Offset = "0x9538E4", VA = "0x9538E4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x9538EC", Offset = "0x9538EC", VA = "0x9538EC", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x9538F8", Offset = "0x9538F8", VA = "0x9538F8")]
		public int AddPointer(HandCanvasPointer pointer)
		{
			return default(int);
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x953BAC", Offset = "0x953BAC", VA = "0x953BAC")]
		public void RemovePointer(HandCanvasPointer pointer)
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x953F28", Offset = "0x953F28", VA = "0x953F28", Slot = "17")]
		public override void Process()
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x9543C0", Offset = "0x9543C0", VA = "0x9543C0")]
		public void ProcessPress(int index)
		{
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x954648", Offset = "0x954648", VA = "0x954648")]
		public void ProcessRelease(int index)
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x9549F4", Offset = "0x9549F4", VA = "0x9549F4")]
		public PointerEventData GetData(int index)
		{
			return null;
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x954A24", Offset = "0x954A24", VA = "0x954A24")]
		public AutoInputModule()
		{
		}
	}
	[Token(Token = "0x2000163")]
	public delegate void CollisionEvent(GameObject from);
	[Token(Token = "0x2000164")]
	public class CollisionTracker : MonoBehaviour
	{
		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool disableCollisionTracking;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool disableTriggersTracking;

		[Token(Token = "0x1700009A")]
		public int collisionCount
		{
			[Token(Token = "0x6000846")]
			[Address(RVA = "0x951CF4", Offset = "0x951CF4", VA = "0x951CF4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700009B")]
		public int triggerCount
		{
			[Token(Token = "0x6000847")]
			[Address(RVA = "0x9550B0", Offset = "0x9550B0", VA = "0x9550B0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700009C")]
		public List<GameObject> triggerObjects
		{
			[Token(Token = "0x6000848")]
			[Address(RVA = "0x9550F8", Offset = "0x9550F8", VA = "0x9550F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000849")]
			[Address(RVA = "0x955100", Offset = "0x955100", VA = "0x955100")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public List<int> triggerObjectsCount
		{
			[Token(Token = "0x600084A")]
			[Address(RVA = "0x955108", Offset = "0x955108", VA = "0x955108")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600084B")]
			[Address(RVA = "0x955110", Offset = "0x955110", VA = "0x955110")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public List<GameObject> collisionObjects
		{
			[Token(Token = "0x600084C")]
			[Address(RVA = "0x955118", Offset = "0x955118", VA = "0x955118")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600084D")]
			[Address(RVA = "0x955120", Offset = "0x955120", VA = "0x955120")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public List<int> collisionObjectsCount
		{
			[Token(Token = "0x600084E")]
			[Address(RVA = "0x955128", Offset = "0x955128", VA = "0x955128")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600084F")]
			[Address(RVA = "0x955130", Offset = "0x955130", VA = "0x955130")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x14000017")]
		public event CollisionEvent OnCollisionFirstEnter
		{
			[Token(Token = "0x600083E")]
			[Address(RVA = "0x954BD0", Offset = "0x954BD0", VA = "0x954BD0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600083F")]
			[Address(RVA = "0x954C6C", Offset = "0x954C6C", VA = "0x954C6C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000018")]
		public event CollisionEvent OnCollisionLastExit
		{
			[Token(Token = "0x6000840")]
			[Address(RVA = "0x954D08", Offset = "0x954D08", VA = "0x954D08")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000841")]
			[Address(RVA = "0x954DA4", Offset = "0x954DA4", VA = "0x954DA4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000019")]
		public event CollisionEvent OnTriggerFirstEnter
		{
			[Token(Token = "0x6000842")]
			[Address(RVA = "0x954E40", Offset = "0x954E40", VA = "0x954E40")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000843")]
			[Address(RVA = "0x954EDC", Offset = "0x954EDC", VA = "0x954EDC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001A")]
		public event CollisionEvent OnTriggeLastExit
		{
			[Token(Token = "0x6000844")]
			[Address(RVA = "0x954F78", Offset = "0x954F78", VA = "0x954F78")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000845")]
			[Address(RVA = "0x955014", Offset = "0x955014", VA = "0x955014")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x955138", Offset = "0x955138", VA = "0x955138")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x955200", Offset = "0x955200", VA = "0x955200", Slot = "4")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x95544C", Offset = "0x95544C", VA = "0x95544C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x955450", Offset = "0x955450", VA = "0x955450")]
		private void CheckCollisions()
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x9556F8", Offset = "0x9556F8", VA = "0x9556F8", Slot = "5")]
		protected virtual void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x955964", Offset = "0x955964", VA = "0x955964", Slot = "6")]
		protected virtual void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x955B48", Offset = "0x955B48", VA = "0x955B48", Slot = "7")]
		protected virtual void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x955D84", Offset = "0x955D84", VA = "0x955D84", Slot = "8")]
		protected virtual void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x955F54", Offset = "0x955F54", VA = "0x955F54")]
		public CollisionTracker()
		{
		}
	}
	[Token(Token = "0x2000165")]
	public class HandCanvasPointer : MonoBehaviour
	{
		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("References")]
		public GameObject hitPointMarker;

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private LineRenderer lineRenderer;

		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Ray settings")]
		public float raycastLength;

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool autoShowTarget;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LayerMask UILayer;

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Events")]
		public UnityEvent StartSelect;

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityEvent StopSelect;

		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UnityEvent StartPoint;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityEvent StopPoint;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool hover;

		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AutoInputModule inputModule;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float lineSegements;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Camera cam;

		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int pointerIndex;

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x95608C", Offset = "0x95608C", VA = "0x95608C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x956418", Offset = "0x956418", VA = "0x956418")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x9564A0", Offset = "0x9564A0", VA = "0x9564A0")]
		public void SetIndex(int index)
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x9542F8", Offset = "0x9542F8", VA = "0x9542F8")]
		internal void Preprocess()
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x9564A8", Offset = "0x9564A8", VA = "0x9564A8")]
		public void Press()
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x956598", Offset = "0x956598", VA = "0x956598")]
		public void Release()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x956628", Offset = "0x956628", VA = "0x956628")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x9568B8", Offset = "0x9568B8", VA = "0x9568B8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x9568BC", Offset = "0x9568BC", VA = "0x9568BC")]
		private void UpdateLine()
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x956C50", Offset = "0x956C50", VA = "0x956C50")]
		private RaycastHit CreateRaycast(float dist)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x956554", Offset = "0x956554", VA = "0x956554")]
		private void ShowRay(bool show)
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x956D40", Offset = "0x956D40", VA = "0x956D40")]
		public HandCanvasPointer()
		{
		}
	}
	[Token(Token = "0x2000166")]
	[DefaultExecutionOrder(-1)]
	[RequireComponent(typeof(Rigidbody))]
	public class PhysicsFollower : MonoBehaviour
	{
		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Follow target, the hand will always try to match this transforms rotation and position with rigidbody movements")]
		[Space]
		[Header("Follow Settings")]
		public Transform follow;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Stops hand physics follow - to freeze from all forces change rigidbody to kinematic or change rigidbody constraints")]
		public bool freezePos;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[Tooltip("Stops hand physics follow - to freeze from all forces change rigidbody to kinematic or change rigidbody constraints")]
		public bool freezeRot;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("This will offset the position without offsetting the rotation pivot")]
		public Vector3 followPositionOffset;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 rotationOffset;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Follow target speed (This will cause jittering if turned too high)")]
		[Min(0f)]
		public float followPositionStrength;

		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Follow target rotation speed (This will cause jittering if turned too high)")]
		[Min(0f)]
		public float followRotationStrength;

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Min(0f)]
		[Tooltip("The maximum allowed velocity of the hand")]
		public float maxVelocity;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal Rigidbody body;

		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform moveTo;

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x956D60", Offset = "0x956D60", VA = "0x956D60")]
		public void Start()
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x956D6C", Offset = "0x956D6C", VA = "0x956D6C", Slot = "4")]
		public virtual void Set()
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x956F40", Offset = "0x956F40", VA = "0x956F40")]
		public void Update()
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x956F4C", Offset = "0x956F4C", VA = "0x956F4C", Slot = "5")]
		protected virtual void OnUpdate()
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x957104", Offset = "0x957104", VA = "0x957104")]
		public void FixedUpdate()
		{
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x957110", Offset = "0x957110", VA = "0x957110", Slot = "6")]
		protected virtual void OnFixedUpdate()
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x9572F8", Offset = "0x9572F8", VA = "0x9572F8", Slot = "7")]
		internal virtual void MoveTo()
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x957538", Offset = "0x957538", VA = "0x957538", Slot = "8")]
		internal virtual void TorqueTo()
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x957980", Offset = "0x957980", VA = "0x957980")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x9579F4", Offset = "0x9579F4", VA = "0x9579F4")]
		public PhysicsFollower()
		{
		}
	}
	[Token(Token = "0x2000167")]
	public class Stabbable : MonoBehaviour
	{
		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody body;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Grabbable grabbable;

		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The index that must match the stabbers index to allow stabbing")]
		public int stabIndex;

		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int maxStabbers;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float positionDamper;

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rotationDamper;

		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool parentOnStab;

		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Events")]
		public UnityEvent StartStab;

		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UnityEvent EndStab;

		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public StabEvent StartStabEvent;

		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public StabEvent EndStabEvent;

		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int currentStabs;

		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<Stabber> stabbing;

		[Token(Token = "0x40008D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform stabParent;

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x957A0C", Offset = "0x957A0C", VA = "0x957A0C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x957CA0", Offset = "0x957CA0", VA = "0x957CA0", Slot = "4")]
		public virtual void OnStab(Stabber stabber)
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x957DA4", Offset = "0x957DA4", VA = "0x957DA4", Slot = "5")]
		public virtual void OnEndStab(Stabber stabber)
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x957E34", Offset = "0x957E34", VA = "0x957E34", Slot = "6")]
		public virtual bool CanStab(Stabber stabber)
		{
			return default(bool);
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x957E70", Offset = "0x957E70", VA = "0x957E70")]
		public int StabbedCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x957EB8", Offset = "0x957EB8", VA = "0x957EB8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x957F98", Offset = "0x957F98", VA = "0x957F98")]
		public Stabbable()
		{
		}
	}
	[Token(Token = "0x2000168")]
	public delegate void StabEvent(Stabber stabber, Stabbable stab);
	[Token(Token = "0x2000169")]
	public class Stabber : MonoBehaviour
	{
		[Token(Token = "0x200016A")]
		[CompilerGenerated]
		private sealed class <StartWait>d__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Stabber <>4__this;

			[Token(Token = "0x40008F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x170000A0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600088C")]
				[Address(RVA = "0x959E18", Offset = "0x959E18", VA = "0x959E18", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600088E")]
				[Address(RVA = "0x959E60", Offset = "0x959E60", VA = "0x959E60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000889")]
			[Address(RVA = "0x958464", Offset = "0x958464", VA = "0x958464")]
			[DebuggerHidden]
			public <StartWait>d__31(int <>1__state)
			{
			}

			[Token(Token = "0x600088A")]
			[Address(RVA = "0x959D14", Offset = "0x959D14", VA = "0x959D14", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600088B")]
			[Address(RVA = "0x959D18", Offset = "0x959D18", VA = "0x959D18", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600088D")]
			[Address(RVA = "0x959E20", Offset = "0x959E20", VA = "0x959E20", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Can be left empty/null")]
		public Grabbable grabbable;

		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Stab Settings")]
		public CapsuleCollider stabCapsule;

		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If left empty, will default to grabbable layers")]
		public LayerMask stabbableLayers;

		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("The index that must match the stabbables index to allow stabbing")]
		public int stabIndex;

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int maxStabs;

		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Header("Joint Settings")]
		public Vector3 axis;

		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float limit;

		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public ConfigurableJointMotion xMotion;

		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ConfigurableJointMotion yMotion;

		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public ConfigurableJointMotion zMotion;

		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public ConfigurableJointMotion angularXMotion;

		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public ConfigurableJointMotion angularYMotion;

		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ConfigurableJointMotion angularZMotion;

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Space]
		public float positionDampeningMultiplyer;

		[Token(Token = "0x40008E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float rotationDampeningMultiplyer;

		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("Events")]
		public UnityEvent StartStab;

		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UnityEvent EndStab;

		[Token(Token = "0x40008E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public StabEvent StartStabEvent;

		[Token(Token = "0x40008E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public StabEvent EndStabEvent;

		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<Stabbable> stabbed;

		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<ConfigurableJoint> stabbedJoints;

		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Dictionary<Stabbable, int> stabbedFrames;

		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Collider[] resultsNonAlloc;

		[Token(Token = "0x40008EB")]
		private const int STABFRAMES = 3;

		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 startPos;

		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private Quaternion startRot;

		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Vector3 lastPos;

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion lastRot;

		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int frames;

		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Dictionary<Transform, Transform> originalParents;

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x9580A0", Offset = "0x9580A0", VA = "0x9580A0")]
		private void Start()
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x9583F0", Offset = "0x9583F0", VA = "0x9583F0")]
		[IteratorStateMachine(typeof(<StartWait>d__31))]
		private IEnumerator StartWait()
		{
			return null;
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x95848C", Offset = "0x95848C", VA = "0x95848C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x9585B4", Offset = "0x9585B4", VA = "0x9585B4", Slot = "4")]
		protected virtual void CheckStabArea()
		{
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x958F08", Offset = "0x958F08", VA = "0x958F08", Slot = "5")]
		protected virtual void OnStabbableEnter(Stabbable stab)
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x95958C", Offset = "0x95958C", VA = "0x95958C", Slot = "6")]
		protected virtual void OnStabbableExit(Stabbable stab)
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x959784", Offset = "0x959784", VA = "0x959784")]
		public List<Stabbable> GetStabbed()
		{
			return null;
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x95978C", Offset = "0x95978C", VA = "0x95978C")]
		public int GetStabbedCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x9597D4", Offset = "0x9597D4", VA = "0x9597D4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x959C4C", Offset = "0x959C4C", VA = "0x959C4C")]
		public Stabber()
		{
		}
	}
	[Token(Token = "0x200016B")]
	public class Stickable : MonoBehaviour
	{
		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Sticky Settings")]
		public Rigidbody body;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("How strong the joint is between the stickable and this")]
		public float stickStrength;

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Multiplyer for required stick speed to activate")]
		public float stickSpeedMultiplyer;

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("This index must match the sticky object to stick")]
		public int stickIndex;

		[Token(Token = "0x40008FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Event")]
		public UnityEvent OnStick;

		[Token(Token = "0x40008FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UnityEvent EndStick;

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x959E68", Offset = "0x959E68", VA = "0x959E68")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x959F48", Offset = "0x959F48", VA = "0x959F48")]
		public Stickable()
		{
		}
	}
	[Token(Token = "0x200016C")]
	[RequireComponent(typeof(Rigidbody))]
	public class Sticky : MonoBehaviour
	{
		[Token(Token = "0x200016D")]
		[CompilerGenerated]
		private sealed class <JointBreak>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000903")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000904")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000905")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Sticky <>4__this;

			[Token(Token = "0x170000A2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600089B")]
				[Address(RVA = "0x95A758", Offset = "0x95A758", VA = "0x95A758", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600089D")]
				[Address(RVA = "0x95A7A0", Offset = "0x95A7A0", VA = "0x95A7A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000898")]
			[Address(RVA = "0x95A454", Offset = "0x95A454", VA = "0x95A454")]
			[DebuggerHidden]
			public <JointBreak>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000899")]
			[Address(RVA = "0x95A56C", Offset = "0x95A56C", VA = "0x95A56C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600089A")]
			[Address(RVA = "0x95A570", Offset = "0x95A570", VA = "0x95A570", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600089C")]
			[Address(RVA = "0x95A760", Offset = "0x95A760", VA = "0x95A760", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("How strong the joint is between the stickable and this")]
		[Header("Sticky Settings")]
		public float stickStrength;

		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Multiplyer for required stick speed to activate")]
		public float requiredStickSpeed;

		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("This index must match the stickable object to stick")]
		public int stickIndex;

		[Token(Token = "0x40008FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Event")]
		public UnityEvent OnStick;

		[Token(Token = "0x4000900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody body;

		[Token(Token = "0x4000901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Stickable> stickers;

		[Token(Token = "0x4000902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Joint> joints;

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x959F58", Offset = "0x959F58", VA = "0x959F58")]
		private void Start()
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x95A09C", Offset = "0x95A09C", VA = "0x95A09C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x95A11C", Offset = "0x95A11C", VA = "0x95A11C")]
		private void CreateStick(Stickable sticker)
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x95A3C0", Offset = "0x95A3C0", VA = "0x95A3C0")]
		private void OnJointBreak(float breakForce)
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x95A3E0", Offset = "0x95A3E0", VA = "0x95A3E0")]
		[IteratorStateMachine(typeof(<JointBreak>d__11))]
		private IEnumerator JointBreak()
		{
			return null;
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x95A47C", Offset = "0x95A47C", VA = "0x95A47C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x95A55C", Offset = "0x95A55C", VA = "0x95A55C")]
		public Sticky()
		{
		}
	}
}
namespace Autohand.Demo
{
	[Token(Token = "0x200016E")]
	public class XRAutoHandAxisFingerBender : MonoBehaviour
	{
		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public XRHandControllerLink controller;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CommonAxis axis;

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public float[] bendOffsets;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float lastAxis;

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x95A7A8", Offset = "0x95A7A8", VA = "0x95A7A8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x95A8A8", Offset = "0x95A8A8", VA = "0x95A8A8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x95A9D8", Offset = "0x95A9D8", VA = "0x95A9D8")]
		public XRAutoHandAxisFingerBender()
		{
		}
	}
	[Token(Token = "0x200016F")]
	public class XRAutoHandFingerBender : MonoBehaviour
	{
		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public XRHandControllerLink controller;

		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CommonButton button;

		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public float[] bendOffsets;

		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool pressed;

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x95A9E0", Offset = "0x95A9E0", VA = "0x95A9E0")]
		private void Update()
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x95AB88", Offset = "0x95AB88", VA = "0x95AB88")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x95ACB8", Offset = "0x95ACB8", VA = "0x95ACB8")]
		public XRAutoHandFingerBender()
		{
		}
	}
	[Token(Token = "0x2000170")]
	public class XRControllerEvent : MonoBehaviour
	{
		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public XRHandControllerLink link;

		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CommonButton button;

		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEvent Pressed;

		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityEvent Released;

		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool pressed;

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x95ACC0", Offset = "0x95ACC0", VA = "0x95ACC0")]
		private void Update()
		{
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x95AD3C", Offset = "0x95AD3C", VA = "0x95AD3C")]
		public XRControllerEvent()
		{
		}
	}
	[Token(Token = "0x2000171")]
	public enum CommonButton
	{
		[Token(Token = "0x4000914")]
		gripButton,
		[Token(Token = "0x4000915")]
		menuButton,
		[Token(Token = "0x4000916")]
		primaryButton,
		[Token(Token = "0x4000917")]
		secondaryButton,
		[Token(Token = "0x4000918")]
		triggerButton,
		[Token(Token = "0x4000919")]
		primary2DAxisClick,
		[Token(Token = "0x400091A")]
		primary2DAxisTouch,
		[Token(Token = "0x400091B")]
		secondary2DAxisClick,
		[Token(Token = "0x400091C")]
		secondary2DAxisTouch,
		[Token(Token = "0x400091D")]
		primaryTouch,
		[Token(Token = "0x400091E")]
		secondaryTouch,
		[Token(Token = "0x400091F")]
		none
	}
	[Token(Token = "0x2000172")]
	public enum CommonAxis
	{
		[Token(Token = "0x4000921")]
		trigger,
		[Token(Token = "0x4000922")]
		grip,
		[Token(Token = "0x4000923")]
		none
	}
	[Token(Token = "0x2000173")]
	public enum Common2DAxis
	{
		[Token(Token = "0x4000925")]
		primaryAxis,
		[Token(Token = "0x4000926")]
		secondaryAxis,
		[Token(Token = "0x4000927")]
		none
	}
	[Token(Token = "0x2000174")]
	public class XRHandControllerLink : HandControllerLink
	{
		[Token(Token = "0x4000928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CommonButton grabButton;

		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("This axis will bend all the fingers on the hand -> replaced with finger bender scripts")]
		public CommonAxis grabAxis;

		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CommonButton squeezeButton;

		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private XRNode role;

		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool squeezing;

		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool grabbing;

		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InputDevice device;

		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<InputDevice> devices;

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x95AD44", Offset = "0x95AD44", VA = "0x95AD44")]
		private void Start()
		{
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x95AE20", Offset = "0x95AE20", VA = "0x95AE20")]
		private void Update()
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x95B18C", Offset = "0x95B18C", VA = "0x95B18C")]
		public List<InputDevice> Devices()
		{
			return null;
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x95AB28", Offset = "0x95AB28", VA = "0x95AB28")]
		public bool ButtonPressed(CommonButton button)
		{
			return default(bool);
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x95A854", Offset = "0x95A854", VA = "0x95A854")]
		public float GetAxis(CommonAxis axis)
		{
			return default(float);
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x95B200", Offset = "0x95B200", VA = "0x95B200")]
		public Vector2 GetAxis2D(Common2DAxis axis)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x95B2F8", Offset = "0x95B2F8", VA = "0x95B2F8", Slot = "4")]
		public override void TryHapticImpulse(float duration, float amp, float freq = 0f)
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x95AFD8", Offset = "0x95AFD8", VA = "0x95AFD8")]
		public static InputFeatureUsage<bool> GetCommonButton(CommonButton button)
		{
			return default(InputFeatureUsage<bool>);
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x95B194", Offset = "0x95B194", VA = "0x95B194")]
		public static InputFeatureUsage<float> GetCommonAxis(CommonAxis axis)
		{
			return default(InputFeatureUsage<float>);
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x95B28C", Offset = "0x95B28C", VA = "0x95B28C")]
		public static InputFeatureUsage<Vector2> GetCommon2DAxis(Common2DAxis axis)
		{
			return default(InputFeatureUsage<Vector2>);
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x95B4A0", Offset = "0x95B4A0", VA = "0x95B4A0")]
		public XRHandControllerLink()
		{
		}
	}
	[Token(Token = "0x2000175")]
	public class XRHandPlayerControllerLink : MonoBehaviour
	{
		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public XRHandControllerLink moveController;

		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public XRHandControllerLink turnController;

		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AutoHandPlayer player;

		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Input")]
		public Common2DAxis moveAxis;

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Common2DAxis turnAxis;

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x95B530", Offset = "0x95B530", VA = "0x95B530")]
		private void Update()
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x95B5A0", Offset = "0x95B5A0", VA = "0x95B5A0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x95B5E0", Offset = "0x95B5E0", VA = "0x95B5E0")]
		public XRHandPlayerControllerLink()
		{
		}
	}
	[Token(Token = "0x2000176")]
	public class XRHandPointGrabLink : MonoBehaviour
	{
		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HandDistanceGrabber pointGrab;

		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public XRHandControllerLink link;

		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Input")]
		public CommonButton pointInput;

		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public CommonButton selectInput;

		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool pointing;

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool selecting;

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x95B5E8", Offset = "0x95B5E8", VA = "0x95B5E8")]
		private void Update()
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x95B6D8", Offset = "0x95B6D8", VA = "0x95B6D8")]
		public XRHandPointGrabLink()
		{
		}
	}
	[Token(Token = "0x2000177")]
	public class XRHeadTracking : MonoBehaviour
	{
		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TrackingOriginModeFlags mode;

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x95B6E0", Offset = "0x95B6E0", VA = "0x95B6E0")]
		private void Start()
		{
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x95B7FC", Offset = "0x95B7FC", VA = "0x95B7FC")]
		public XRHeadTracking()
		{
		}
	}
	[Token(Token = "0x2000178")]
	public class XRTeleporterLink : MonoBehaviour
	{
		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Teleporter hand;

		[Token(Token = "0x400093D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public XRNode role;

		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public CommonButton button;

		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool teleporting;

		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private InputDevice device;

		[Token(Token = "0x4000941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<InputDevice> devices;

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x95B80C", Offset = "0x95B80C", VA = "0x95B80C")]
		private void Start()
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x95B888", Offset = "0x95B888", VA = "0x95B888")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x95B998", Offset = "0x95B998", VA = "0x95B998")]
		public XRTeleporterLink()
		{
		}
	}
	[Token(Token = "0x2000179")]
	public class BoxingGlove : MonoBehaviour
	{
		[Token(Token = "0x4000942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody body;

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float power;

		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float lastHitTime;

		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float delay;

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x95B9A0", Offset = "0x95B9A0", VA = "0x95B9A0")]
		public void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x95BA30", Offset = "0x95BA30", VA = "0x95BA30")]
		public BoxingGlove()
		{
		}
	}
	[Token(Token = "0x200017A")]
	public class CubeBreak : MonoBehaviour
	{
		[Token(Token = "0x4000946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float force;

		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3[] offsets;

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x95BA48", Offset = "0x95BA48", VA = "0x95BA48")]
		[ContextMenu("Break")]
		public void Break()
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x95C044", Offset = "0x95C044", VA = "0x95C044")]
		public CubeBreak()
		{
		}
	}
	[Token(Token = "0x200017B")]
	public class DemoFlyingToggle : MonoBehaviour
	{
		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x95C164", Offset = "0x95C164", VA = "0x95C164")]
		public void ToggleFlying()
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x95C184", Offset = "0x95C184", VA = "0x95C184")]
		public DemoFlyingToggle()
		{
		}
	}
	[Token(Token = "0x200017C")]
	public class Door : PhysicsGadgetHingeAngleReader
	{
		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Door should start closed")]
		public Rigidbody body;

		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 closedPosition;

		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Quaternion closedRotation;

		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("The door needs to reach this level of open before it can be reset")]
		public float minThreshold;

		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float midThreshold;

		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Tooltip("The door needs to reach this level of open before it can be reset")]
		public float maxThreshold;

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Space]
		public UnityEvent OnMax;

		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public UnityEvent OnMid;

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UnityEvent OnMin;

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool min;

		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		private bool max;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9A")]
		private bool mid;

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x95C18C", Offset = "0x95C18C", VA = "0x95C18C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x95C2A4", Offset = "0x95C2A4", VA = "0x95C2A4")]
		protected void FixedUpdate()
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x95C3E0", Offset = "0x95C3E0", VA = "0x95C3E0")]
		private void Max()
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x95C424", Offset = "0x95C424", VA = "0x95C424")]
		private void Mid()
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x95C400", Offset = "0x95C400", VA = "0x95C400")]
		private void Min()
		{
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x95C448", Offset = "0x95C448", VA = "0x95C448")]
		public void ClosedDoor()
		{
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x95C4A8", Offset = "0x95C4A8", VA = "0x95C4A8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x95C588", Offset = "0x95C588", VA = "0x95C588")]
		public Door()
		{
		}
	}
	[Token(Token = "0x200017D")]
	public class ExplosionSource : MonoBehaviour
	{
		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float radius;

		[Token(Token = "0x4000955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float force;

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x95C5AC", Offset = "0x95C5AC", VA = "0x95C5AC")]
		public void Explode(bool destroy)
		{
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x95C74C", Offset = "0x95C74C", VA = "0x95C74C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x95C798", Offset = "0x95C798", VA = "0x95C798")]
		public ExplosionSource()
		{
		}
	}
	[Token(Token = "0x200017E")]
	public class Grenade : MonoBehaviour
	{
		[Token(Token = "0x4000956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Grabbable grenade;

		[Token(Token = "0x4000957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Grabbable pin;

		[Token(Token = "0x4000958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ConfigurableJoint pinJoint;

		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float explosionDelay;

		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool startDelayOnRelease;

		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float explosionForce;

		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float explosionRadius;

		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pinJointStrength;

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject explosionEffect;

		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityEvent pinBreakEvent;

		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UnityEvent explosionEvent;

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x95C7AC", Offset = "0x95C7AC", VA = "0x95C7AC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x95CBBC", Offset = "0x95CBBC", VA = "0x95CBBC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x95CE48", Offset = "0x95CE48", VA = "0x95CE48")]
		private void OnGrenadeGrab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x95CEC4", Offset = "0x95CEC4", VA = "0x95CEC4")]
		private void OnGrenadeRelease(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x95CFBC", Offset = "0x95CFBC", VA = "0x95CFBC")]
		private void OnPinGrab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x95D044", Offset = "0x95D044", VA = "0x95D044")]
		private void OnPinRelease(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x95D0D0", Offset = "0x95D0D0", VA = "0x95D0D0")]
		private void OnJointBreak(float breakForce)
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x95D128", Offset = "0x95D128", VA = "0x95D128")]
		private void CheckJointBreak()
		{
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x95D208", Offset = "0x95D208", VA = "0x95D208")]
		private void Explode()
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x95D68C", Offset = "0x95D68C", VA = "0x95D68C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x95D6DC", Offset = "0x95D6DC", VA = "0x95D6DC")]
		public Grenade()
		{
		}
	}
	[Token(Token = "0x200017F")]
	public class HandSwapper : MonoBehaviour
	{
		[Token(Token = "0x4000961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AutoHandPlayer player;

		[Token(Token = "0x4000962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Hand fromHand;

		[Token(Token = "0x4000963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Hand toHand;

		[Token(Token = "0x4000964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject fromModel;

		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject toModel;

		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool swapped;

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x95D704", Offset = "0x95D704", VA = "0x95D704")]
		public void Swap()
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x95D898", Offset = "0x95D898", VA = "0x95D898")]
		public HandSwapper()
		{
		}
	}
	[Token(Token = "0x2000180")]
	public class JointBreakStopForce1 : MonoBehaviour
	{
		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x95D8A0", Offset = "0x95D8A0", VA = "0x95D8A0")]
		private void OnJointBreak(float breakForce)
		{
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x95D998", Offset = "0x95D998", VA = "0x95D998")]
		public JointBreakStopForce1()
		{
		}
	}
	[Token(Token = "0x2000181")]
	public class Pistol : MonoBehaviour
	{
		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody body;

		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform barrelTip;

		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float hitPower;

		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float recoilPower;

		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float range;

		[Token(Token = "0x400096C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask layer;

		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioClip shootSound;

		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float shootVolume;

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x95D9A0", Offset = "0x95D9A0", VA = "0x95D9A0")]
		private void Start()
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x95DA88", Offset = "0x95DA88", VA = "0x95DA88")]
		public void Shoot()
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x95DF14", Offset = "0x95DF14", VA = "0x95DF14")]
		public Pistol()
		{
		}
	}
	[Token(Token = "0x2000182")]
	public class PlayerFallCatcher : MonoBehaviour
	{
		[Token(Token = "0x400096F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 startPos;

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x95DF34", Offset = "0x95DF34", VA = "0x95DF34")]
		private void Start()
		{
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x95E060", Offset = "0x95E060", VA = "0x95E060")]
		private void Update()
		{
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x95E130", Offset = "0x95E130", VA = "0x95E130")]
		public PlayerFallCatcher()
		{
		}
	}
	[Token(Token = "0x2000183")]
	public class ScaleHighlight : MonoBehaviour
	{
		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 highlighScale;

		[Token(Token = "0x4000971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 normalScale;

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x95E138", Offset = "0x95E138", VA = "0x95E138")]
		public void Highlight()
		{
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x95E164", Offset = "0x95E164", VA = "0x95E164")]
		public void HighlightStop()
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x95E190", Offset = "0x95E190", VA = "0x95E190")]
		public ScaleHighlight()
		{
		}
	}
	[Token(Token = "0x2000184")]
	public class Spinner : MonoBehaviour
	{
		[Token(Token = "0x4000972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 rotationSpeed;

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x95E198", Offset = "0x95E198", VA = "0x95E198")]
		private void Update()
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x95E1F4", Offset = "0x95E1F4", VA = "0x95E1F4")]
		public Spinner()
		{
		}
	}
	[Token(Token = "0x2000185")]
	public class ToggleAutoMoveFlying : MonoBehaviour
	{
		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x95E1FC", Offset = "0x95E1FC", VA = "0x95E1FC")]
		public void ToggleFlying()
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x95E278", Offset = "0x95E278", VA = "0x95E278")]
		public ToggleAutoMoveFlying()
		{
		}
	}
	[Token(Token = "0x2000186")]
	public class ToggleHandProjection : MonoBehaviour
	{
		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x95E280", Offset = "0x95E280", VA = "0x95E280")]
		public void DisableGripProjection()
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x95E340", Offset = "0x95E340", VA = "0x95E340")]
		public void EnableGripProjection()
		{
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x95E400", Offset = "0x95E400", VA = "0x95E400")]
		public void DisableHighlightProjection()
		{
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x95E4C0", Offset = "0x95E4C0", VA = "0x95E4C0")]
		public void EnableHighlightProjection()
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x95E580", Offset = "0x95E580", VA = "0x95E580")]
		public ToggleHandProjection()
		{
		}
	}
	[Token(Token = "0x2000187")]
	public class TomatoSpawner : MonoBehaviour
	{
		[Token(Token = "0x4000973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] tomatoes;

		[Token(Token = "0x4000974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<GameObject> copies;

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x95E588", Offset = "0x95E588", VA = "0x95E588")]
		private void Start()
		{
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x95E7FC", Offset = "0x95E7FC", VA = "0x95E7FC")]
		public void SpawnTomato()
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x95E994", Offset = "0x95E994", VA = "0x95E994")]
		public TomatoSpawner()
		{
		}
	}
	[Token(Token = "0x2000188")]
	public class ButtonDemoRespawn : MonoBehaviour
	{
		[Token(Token = "0x4000975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform root;

		[Token(Token = "0x4000976")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Transform> respawns;

		[Token(Token = "0x4000977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Vector3> startPos;

		[Token(Token = "0x4000978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<Quaternion> startRot;

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x95E99C", Offset = "0x95E99C", VA = "0x95E99C")]
		private void Start()
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x95EE7C", Offset = "0x95EE7C", VA = "0x95EE7C")]
		public void Respawn()
		{
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x95F1B0", Offset = "0x95F1B0", VA = "0x95F1B0")]
		public void ReloadScene()
		{
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x95F220", Offset = "0x95F220", VA = "0x95F220")]
		public ButtonDemoRespawn()
		{
		}
	}
	[Token(Token = "0x2000189")]
	public class DialHandScaler : PhysicsGadgetHingeAngleReader
	{
		[Token(Token = "0x4000979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Hand hand;

		[Token(Token = "0x400097A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 minScale;

		[Token(Token = "0x400097B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector3 maxScale;

		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float startReach;

		[Token(Token = "0x400097D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 startScale;

		[Token(Token = "0x400097E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float[] fingersStartScale;

		[Token(Token = "0x400097F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 lastHandScale;

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x95F2A8", Offset = "0x95F2A8", VA = "0x95F2A8")]
		protected new void Start()
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x95F3DC", Offset = "0x95F3DC", VA = "0x95F3DC")]
		private void Update()
		{
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x95F6A0", Offset = "0x95F6A0", VA = "0x95F6A0")]
		public DialHandScaler()
		{
		}
	}
	[Token(Token = "0x200018A")]
	public class JoystickObjectMover : PhysicsGadgetJoystick
	{
		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform move;

		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float speed;

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x95F6A8", Offset = "0x95F6A8", VA = "0x95F6A8")]
		private void Update()
		{
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x95F74C", Offset = "0x95F74C", VA = "0x95F74C")]
		public JoystickObjectMover()
		{
		}
	}
	[Token(Token = "0x200018B")]
	public class MoverLever : PhysicsGadgetHingeAngleReader
	{
		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform move;

		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 axis;

		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float speed;

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x95F75C", Offset = "0x95F75C", VA = "0x95F75C")]
		private void Update()
		{
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x95F91C", Offset = "0x95F91C", VA = "0x95F91C")]
		public MoverLever()
		{
		}
	}
	[Token(Token = "0x200018C")]
	public class PhysicsSliderPositionMover : PhysicsGadgetConfigurableLimitReader
	{
		[Token(Token = "0x4000985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Movement")]
		public Transform move;

		[Token(Token = "0x4000986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Acts as speed")]
		public Vector3 axis;

		[Token(Token = "0x4000987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Header("Range")]
		public bool useRange;

		[Token(Token = "0x4000988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 minRange;

		[Token(Token = "0x4000989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 maxRange;

		[Token(Token = "0x400098A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 startPos;

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x95F92C", Offset = "0x95F92C", VA = "0x95F92C")]
		protected new void Start()
		{
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x95F960", Offset = "0x95F960", VA = "0x95F960")]
		public void FixedUpdate()
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x95FAB8", Offset = "0x95FAB8", VA = "0x95FAB8")]
		public PhysicsSliderPositionMover()
		{
		}
	}
	[Token(Token = "0x200018D")]
	public class WheelRotator : PhysicsGadgetHingeAngleReader
	{
		[Token(Token = "0x400098B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform move;

		[Token(Token = "0x400098C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 angle;

		[Token(Token = "0x400098D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool useLocal;

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x95FB48", Offset = "0x95FB48", VA = "0x95FB48")]
		private void Update()
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x95FD74", Offset = "0x95FD74", VA = "0x95FD74")]
		public WheelRotator()
		{
		}
	}
	[Token(Token = "0x200018E")]
	public class LeverTextChanger : MonoBehaviour
	{
		[Token(Token = "0x400098E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshPro text;

		[Token(Token = "0x400098F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PhysicsGadgetHingeAngleReader sliderReader;

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x95FD7C", Offset = "0x95FD7C", VA = "0x95FD7C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x95FE68", Offset = "0x95FE68", VA = "0x95FE68")]
		public LeverTextChanger()
		{
		}
	}
	[Token(Token = "0x200018F")]
	public class SliderTextChanger : MonoBehaviour
	{
		[Token(Token = "0x4000990")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshPro text;

		[Token(Token = "0x4000991")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PhysicsGadgetConfigurableLimitReader sliderReader;

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x95FE70", Offset = "0x95FE70", VA = "0x95FE70")]
		private void Update()
		{
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x95FF5C", Offset = "0x95FF5C", VA = "0x95FF5C")]
		public SliderTextChanger()
		{
		}
	}
	[Token(Token = "0x2000190")]
	public class TextChanger : MonoBehaviour
	{
		[Token(Token = "0x2000191")]
		[CompilerGenerated]
		private sealed class <ChangeText>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000995")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000996")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000997")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TextChanger <>4__this;

			[Token(Token = "0x170000A4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600090C")]
				[Address(RVA = "0x960144", Offset = "0x960144", VA = "0x960144", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600090E")]
				[Address(RVA = "0x96018C", Offset = "0x96018C", VA = "0x96018C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000909")]
			[Address(RVA = "0x95FFE0", Offset = "0x95FFE0", VA = "0x95FFE0")]
			[DebuggerHidden]
			public <ChangeText>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x600090A")]
			[Address(RVA = "0x96006C", Offset = "0x96006C", VA = "0x96006C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600090B")]
			[Address(RVA = "0x960070", Offset = "0x960070", VA = "0x960070", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600090D")]
			[Address(RVA = "0x96014C", Offset = "0x96014C", VA = "0x96014C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000992")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshPro text;

		[Token(Token = "0x4000993")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Coroutine changing;

		[Token(Token = "0x4000994")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Coroutine hide;

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x95FF64", Offset = "0x95FF64", VA = "0x95FF64")]
		public void UpdateText(string newText, float upTime)
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x95FF68", Offset = "0x95FF68", VA = "0x95FF68")]
		public void UpdateText(string newText)
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x95FF6C", Offset = "0x95FF6C", VA = "0x95FF6C")]
		[IteratorStateMachine(typeof(<ChangeText>d__5))]
		private IEnumerator ChangeText(float seconds, string newText)
		{
			return null;
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x960008", Offset = "0x960008", VA = "0x960008")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x960064", Offset = "0x960064", VA = "0x960064")]
		public TextChanger()
		{
		}
	}
	[Token(Token = "0x2000192")]
	public class TextGrabEvent : MonoBehaviour
	{
		[Token(Token = "0x4000998")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextChanger changer;

		[Token(Token = "0x4000999")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Grabbable grab;

		[Token(Token = "0x400099A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[TextArea]
		public string message;

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x960194", Offset = "0x960194", VA = "0x960194")]
		private void Start()
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x960384", Offset = "0x960384", VA = "0x960384")]
		private void OnGrab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x960388", Offset = "0x960388", VA = "0x960388")]
		public TextGrabEvent()
		{
		}
	}
	[Token(Token = "0x2000193")]
	public class TextPlacePointEvent : MonoBehaviour
	{
		[Token(Token = "0x400099B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextChanger changer;

		[Token(Token = "0x400099C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlacePoint point;

		[Token(Token = "0x400099D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x400099E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[TextArea]
		public string placeMessage;

		[Token(Token = "0x400099F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[TextArea]
		public string highlightMessage;

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x960390", Offset = "0x960390", VA = "0x960390")]
		private void Start()
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x9605A4", Offset = "0x9605A4", VA = "0x9605A4")]
		private void OnGrab(PlacePoint hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x9605BC", Offset = "0x9605BC", VA = "0x9605BC")]
		private void OnHighlight(PlacePoint hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x9605D4", Offset = "0x9605D4", VA = "0x9605D4")]
		public TextPlacePointEvent()
		{
		}
	}
	[Token(Token = "0x2000194")]
	public class WristLookEvent : MonoBehaviour
	{
		[Token(Token = "0x40009A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Hand hand;

		[Token(Token = "0x40009A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Camera head;

		[Token(Token = "0x40009A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The minimum head->wrist distance required to activate")]
		public float maxDistance;

		[Token(Token = "0x40009A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		[Tooltip("The angle precisness required to activate; 0 is any angle, 1 is exactly pointed at the face")]
		public float anglePreciseness;

		[Token(Token = "0x40009A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool disableWhileHolding;

		[Token(Token = "0x40009A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Events")]
		public UnityHandEvent OnShow;

		[Token(Token = "0x40009A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityHandEvent OnHide;

		[Token(Token = "0x40009A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool showing;

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x9605E4", Offset = "0x9605E4", VA = "0x9605E4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x9608F8", Offset = "0x9608F8", VA = "0x9608F8")]
		public WristLookEvent()
		{
		}
	}
	[Token(Token = "0x2000195")]
	[RequireComponent(typeof(Grabbable))]
	public class GrabbableEventDebugger : MonoBehaviour
	{
		[Token(Token = "0x6000918")]
		[Address(RVA = "0x960910", Offset = "0x960910", VA = "0x960910")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x961040", Offset = "0x961040", VA = "0x961040")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x961770", Offset = "0x961770", VA = "0x961770")]
		public GrabbableEventDebugger()
		{
		}
	}
	[Token(Token = "0x2000197")]
	[RequireComponent(typeof(Hand))]
	public class HandEventDebugger : MonoBehaviour
	{
		[Token(Token = "0x40009B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool showSqueezeEvents;

		[Token(Token = "0x40009BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool showHighlightEvents;

		[Token(Token = "0x600092D")]
		[Address(RVA = "0x962130", Offset = "0x962130", VA = "0x962130")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0x9623F4", Offset = "0x9623F4", VA = "0x9623F4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x9626B8", Offset = "0x9626B8", VA = "0x9626B8")]
		public HandEventDebugger()
		{
		}
	}
	[Token(Token = "0x2000198")]
	public class HandTouchEventDebugger : MonoBehaviour
	{
		[Token(Token = "0x40009BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HandTouchEvent touchEvent;

		[Token(Token = "0x6000940")]
		[Address(RVA = "0x963108", Offset = "0x963108", VA = "0x963108")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x96326C", Offset = "0x96326C", VA = "0x96326C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x9633D0", Offset = "0x9633D0", VA = "0x9633D0")]
		private void StartTouch(Hand hand)
		{
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x96346C", Offset = "0x96346C", VA = "0x96346C")]
		private void StopTouch(Hand hand)
		{
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x963508", Offset = "0x963508", VA = "0x963508")]
		public HandTouchEventDebugger()
		{
		}
	}
	[Token(Token = "0x2000199")]
	public class Smash : MonoBehaviour
	{
		[Token(Token = "0x40009BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Required velocity magnitude from Smasher to smash")]
		[Header("Smash Options")]
		public float smashForce;

		[Token(Token = "0x40009BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Whether or not to destroy this object on smash")]
		public bool destroyOnSmash;

		[Token(Token = "0x40009BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		[HideIf("destroyOnSmash")]
		[Tooltip("Whether or not to release this object on smash")]
		public bool releaseOnSmash;

		[Token(Token = "0x40009BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Particle Effect")]
		[Tooltip("Plays this effect on smash")]
		public ParticleSystem effect;

		[Token(Token = "0x40009C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Whether or not to instantiates a new a particle system on smash")]
		public bool createNewEffect;

		[Token(Token = "0x40009C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[Tooltip("Whether or not to apply rigidbody velocity to particle velocity on smash")]
		public bool applyVelocityOnSmash;

		[Token(Token = "0x40009C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Sound Options")]
		public AudioClip smashSound;

		[Token(Token = "0x40009C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float smashVolume;

		[Token(Token = "0x40009C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Event")]
		public UnityEvent OnSmash;

		[Token(Token = "0x40009C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public SmashEvent OnSmashEvent;

		[Token(Token = "0x40009C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal Grabbable grabbable;

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x963510", Offset = "0x963510", VA = "0x963510")]
		public void Start()
		{
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0x9637E8", Offset = "0x9637E8", VA = "0x9637E8")]
		public void DelayedSmash(float delay)
		{
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0x95DF0C", Offset = "0x95DF0C", VA = "0x95DF0C")]
		public void DoSmash()
		{
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x963844", Offset = "0x963844", VA = "0x963844")]
		public void DoSmash(Smasher smash)
		{
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x963BE4", Offset = "0x963BE4", VA = "0x963BE4")]
		public Smash()
		{
		}
	}
	[Token(Token = "0x200019A")]
	public delegate void SmashEvent(Smasher smasher, Smash smashable);
	[Token(Token = "0x200019B")]
	[RequireComponent(typeof(Rigidbody))]
	public class Smasher : MonoBehaviour
	{
		[Token(Token = "0x40009C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Rigidbody rb;

		[Token(Token = "0x40009C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Options")]
		public LayerMask smashableLayers;

		[Token(Token = "0x40009C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("How much to multiply the magnitude on smash")]
		public float forceMulti;

		[Token(Token = "0x40009CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Can be left empty - The center of mass point to calculate velocity magnitude - for example: the camera of the hammer is a better point vs the pivot center of the hammer object")]
		public Transform centerOfMassPoint;

		[Token(Token = "0x40009CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Event")]
		public UnityEvent OnSmash;

		[Token(Token = "0x40009CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SmashEvent OnSmashEvent;

		[Token(Token = "0x40009CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3[] velocityOverTime;

		[Token(Token = "0x40009CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 lastPos;

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x963C5C", Offset = "0x963C5C", VA = "0x963C5C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x963E24", Offset = "0x963E24", VA = "0x963E24")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x963F90", Offset = "0x963F90", VA = "0x963F90")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0x964048", Offset = "0x964048", VA = "0x964048")]
		private float GetMagnitude()
		{
			return default(float);
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0x964164", Offset = "0x964164", VA = "0x964164")]
		public Smasher()
		{
		}
	}
}
