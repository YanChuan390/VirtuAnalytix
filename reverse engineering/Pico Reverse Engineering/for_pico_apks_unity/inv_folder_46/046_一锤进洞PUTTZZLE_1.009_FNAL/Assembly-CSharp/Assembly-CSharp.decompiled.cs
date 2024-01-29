using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Autohand;
using Autohand.Demo;
using Il2CppDummyDll;
using NaughtyAttributes;
using Pixelplacement;
using Pixelplacement.TweenSystem;
using TMPro;
using UmbraEvolution.PerLayerCameraCulling;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.XR;

[assembly: AssemblyVersion("0.0.0.0")]
[Serializable]
[Token(Token = "0x2000002")]
internal struct DeviceData
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
	[Address(RVA = "0xACE71C", Offset = "0xACE71C", VA = "0xACE71C")]
	public DeviceData(string name, Vector3 pos, Vector3 rot)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xACE80C", Offset = "0xACE80C", VA = "0xACE80C")]
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
	private Transform[] rightOffsets;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform[] leftOffsets;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private DeviceData[] devices;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3[] m_vecDevicePostion_R;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3[] m_vecDevicePostion_L;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3[] m_vecDeviceRotiion_R;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] m_vecDeviceRotiion_L;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool offsetDone;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xACE860", Offset = "0xACE860", VA = "0xACE860")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xACF598", Offset = "0xACF598", VA = "0xACF598")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xACECA8", Offset = "0xACECA8", VA = "0xACECA8")]
	private void DeviceConnected(InputDevice inputDevice)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xACF638", Offset = "0xACF638", VA = "0xACF638")]
	private Vector3 GetPositionOffset(string from, string to)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xACF800", Offset = "0xACF800", VA = "0xACF800")]
	private Vector3 GetRotationOffset(string from, string to)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xACF618", Offset = "0xACF618", VA = "0xACF618")]
	public static bool IsPNX()
	{
		return default(bool);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xACF9C8", Offset = "0xACF9C8", VA = "0xACF9C8")]
	public XRHandOffset()
	{
	}
}
[Token(Token = "0x2000004")]
public class BowlingManager : MonoBehaviour
{
	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Bowling Ball Settings")]
	public GameObject bowlingBall;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("Bowling Pin Settings")]
	public Vector3 pinCenter;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float pinSpaceX;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float pinSpaceZ;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<GameObject> pins;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector3 ballPosition;

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xACFFE8", Offset = "0xACFFE8", VA = "0xACFFE8")]
	private void Start()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xAD0220", Offset = "0xAD0220", VA = "0xAD0220")]
	public void ResetBall()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xAD0024", Offset = "0xAD0024", VA = "0xAD0024")]
	public void ResetPins()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xAD02C4", Offset = "0xAD02C4", VA = "0xAD02C4")]
	public BowlingManager()
	{
	}
}
[Token(Token = "0x2000005")]
public class DemoExitCondition : MonoBehaviour
{
	[Token(Token = "0x600000E")]
	[Address(RVA = "0xAD034C", Offset = "0xAD034C", VA = "0xAD034C")]
	private void Update()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xAD03E4", Offset = "0xAD03E4", VA = "0xAD03E4")]
	public DemoExitCondition()
	{
	}
}
[Token(Token = "0x2000006")]
public class OpenLink : MonoBehaviour
{
	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string URL;

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xAD03EC", Offset = "0xAD03EC", VA = "0xAD03EC")]
	public void OpenLinkURL()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xAD03F8", Offset = "0xAD03F8", VA = "0xAD03F8")]
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
		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlatformMover <>4__this;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timePassed>5__2;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0xAD075C", Offset = "0xAD075C", VA = "0xAD075C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0xAD07A4", Offset = "0xAD07A4", VA = "0xAD07A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0xAD04B8", Offset = "0xAD04B8", VA = "0xAD04B8")]
		[DebuggerHidden]
		public <Move>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xAD04F0", Offset = "0xAD04F0", VA = "0xAD04F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xAD04F4", Offset = "0xAD04F4", VA = "0xAD04F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xAD0764", Offset = "0xAD0764", VA = "0xAD0764", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 toRange;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float time;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 startPos;

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xAD0400", Offset = "0xAD0400", VA = "0xAD0400")]
	private void Start()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xAD0444", Offset = "0xAD0444", VA = "0xAD0444")]
	[IteratorStateMachine(typeof(<Move>d__4))]
	private IEnumerator Move()
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xAD04E0", Offset = "0xAD04E0", VA = "0xAD04E0")]
	public PlatformMover()
	{
	}
}
[Token(Token = "0x2000009")]
public class UnlockChest : MonoBehaviour
{
	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public HingeJoint joint;

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xAD07AC", Offset = "0xAD07AC", VA = "0xAD07AC")]
	public void Unlock()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xAD0904", Offset = "0xAD0904", VA = "0xAD0904")]
	public void Lock()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xAD0A38", Offset = "0xAD0A38", VA = "0xAD0A38")]
	public UnlockChest()
	{
	}
}
[Token(Token = "0x200000A")]
public class TextFieldInspector : MonoBehaviour
{
	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[TextArea]
	public string text;

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xAD0A40", Offset = "0xAD0A40", VA = "0xAD0A40")]
	public TextFieldInspector()
	{
	}
}
[Token(Token = "0x200000B")]
public class TextInformation : MonoBehaviour
{
	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject activateImage;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject deactivateImage;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject[] texts;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool active;

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xAD0A48", Offset = "0xAD0A48", VA = "0xAD0A48")]
	public void ActivateText()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xAD0ADC", Offset = "0xAD0ADC", VA = "0xAD0ADC")]
	public void DeactivateText()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xAD0B6C", Offset = "0xAD0B6C", VA = "0xAD0B6C")]
	public void ToggleText()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xAD0B7C", Offset = "0xAD0B7C", VA = "0xAD0B7C")]
	public TextInformation()
	{
	}
}
[Token(Token = "0x200000C")]
public class TMPSizeProtector : MonoBehaviour
{
	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float size;

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xAD0B84", Offset = "0xAD0B84", VA = "0xAD0B84")]
	private void Start()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xAD0C44", Offset = "0xAD0C44", VA = "0xAD0C44")]
	public TMPSizeProtector()
	{
	}
}
[Token(Token = "0x200000D")]
public static class JointExtensions
{
	[Token(Token = "0x6000025")]
	[Address(RVA = "0xAD0C4C", Offset = "0xAD0C4C", VA = "0xAD0C4C")]
	public static Vector3 Angles(this ConfigurableJoint joint)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x200000E")]
[DefaultExecutionOrder(-100000)]
public class IgnoreHandLayer : MonoBehaviour
{
	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool includeChildren;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int startLayer;

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xAD1068", Offset = "0xAD1068", VA = "0xAD1068")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xAD10DC", Offset = "0xAD10DC", VA = "0xAD10DC")]
	private void LateStart()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xAD113C", Offset = "0xAD113C", VA = "0xAD113C")]
	internal void SetLayerRecursive(Transform obj, int newLayer)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xAD11D8", Offset = "0xAD11D8", VA = "0xAD11D8")]
	public IgnoreHandLayer()
	{
	}
}
[Token(Token = "0x200000F")]
public class HeadCameraSmoothing : MonoBehaviour
{
	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 lastPos;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Quaternion lastRot;

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xAD11E8", Offset = "0xAD11E8", VA = "0xAD11E8")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xAD1238", Offset = "0xAD1238", VA = "0xAD1238")]
	public HeadCameraSmoothing()
	{
	}
}
[Token(Token = "0x2000010")]
public class HandEventTemplate : MonoBehaviour
{
	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Autohand.Hand hand;

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xAD1240", Offset = "0xAD1240", VA = "0xAD1240")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xAD175C", Offset = "0xAD175C", VA = "0xAD175C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xAD1C78", Offset = "0xAD1C78", VA = "0xAD1C78")]
	private void OnBeforeGrabbed(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xAD1C7C", Offset = "0xAD1C7C", VA = "0xAD1C7C")]
	private void OnGrabbed(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xAD1C80", Offset = "0xAD1C80", VA = "0xAD1C80")]
	private void OnBeforeReleased(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xAD1C84", Offset = "0xAD1C84", VA = "0xAD1C84")]
	private void OnReleased(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xAD1C88", Offset = "0xAD1C88", VA = "0xAD1C88")]
	private void OnForcedRelease(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xAD1C8C", Offset = "0xAD1C8C", VA = "0xAD1C8C")]
	private void OnGrabJointBreak(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xAD1C90", Offset = "0xAD1C90", VA = "0xAD1C90")]
	private void OnHighlight(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xAD1C94", Offset = "0xAD1C94", VA = "0xAD1C94")]
	private void OnStopHighlight(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xAD1C98", Offset = "0xAD1C98", VA = "0xAD1C98")]
	private void OnSqueezed(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xAD1C9C", Offset = "0xAD1C9C", VA = "0xAD1C9C")]
	private void OnUnsqueezed(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xAD1CA0", Offset = "0xAD1CA0", VA = "0xAD1CA0")]
	private void OnTriggerGrab(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xAD1CA4", Offset = "0xAD1CA4", VA = "0xAD1CA4")]
	private void OnTriggerRelease(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xAD1CA8", Offset = "0xAD1CA8", VA = "0xAD1CA8")]
	private void OnHandCollisionStart(Autohand.Hand hand, GameObject other)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xAD1CAC", Offset = "0xAD1CAC", VA = "0xAD1CAC")]
	private void OnHandCollisionStop(Autohand.Hand hand, GameObject other)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xAD1CB0", Offset = "0xAD1CB0", VA = "0xAD1CB0")]
	private void OnHandTriggerStart(Autohand.Hand hand, GameObject other)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xAD1CB4", Offset = "0xAD1CB4", VA = "0xAD1CB4")]
	private void OnHandTriggerStop(Autohand.Hand hand, GameObject other)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xAD1CB8", Offset = "0xAD1CB8", VA = "0xAD1CB8")]
	public HandEventTemplate()
	{
	}
}
[Token(Token = "0x2000011")]
[RequireComponent(typeof(PlacePoint))]
public class PlacePointEventDebugger : MonoBehaviour
{
	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private PlacePoint placePoint;

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xAD1CC0", Offset = "0xAD1CC0", VA = "0xAD1CC0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xAD20B8", Offset = "0xAD20B8", VA = "0xAD20B8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xAD24B0", Offset = "0xAD24B0", VA = "0xAD24B0")]
	public PlacePointEventDebugger()
	{
	}
}
[Token(Token = "0x2000013")]
public class PlacePointEventTemplate : MonoBehaviour
{
	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PlacePoint placePoint;

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xAD2870", Offset = "0xAD2870", VA = "0xAD2870")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xAD2AE0", Offset = "0xAD2AE0", VA = "0xAD2AE0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xAD2D50", Offset = "0xAD2D50", VA = "0xAD2D50")]
	public void OnPlace(PlacePoint point, Grabbable grab)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xAD2D54", Offset = "0xAD2D54", VA = "0xAD2D54")]
	public void OnRemove(PlacePoint point, Grabbable grab)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xAD2D58", Offset = "0xAD2D58", VA = "0xAD2D58")]
	public void OnHighlight(PlacePoint point, Grabbable grab)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xAD2D5C", Offset = "0xAD2D5C", VA = "0xAD2D5C")]
	public void OnStopHighlight(PlacePoint point, Grabbable grab)
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xAD2D60", Offset = "0xAD2D60", VA = "0xAD2D60")]
	public PlacePointEventTemplate()
	{
	}
}
[Token(Token = "0x2000014")]
public class AutoHandSettings : ScriptableObject
{
	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Whether the popup should be ignored on launch or not")]
	public bool ignoreSetup;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Tooltip("-1 is custom, 0 is low, 1 is medium, 2 is high")]
	public float quality;

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xAD2D68", Offset = "0xAD2D68", VA = "0xAD2D68")]
	public static void ClearSettings()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xAD2DD8", Offset = "0xAD2DD8", VA = "0xAD2DD8")]
	public AutoHandSettings()
	{
	}
}
[Token(Token = "0x2000015")]
public class CollisionIgnores : MonoBehaviour
{
	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool disableOnStart;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Collider[] cols1;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Collider[] cols2;

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xAD2DE8", Offset = "0xAD2DE8", VA = "0xAD2DE8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xAD2E90", Offset = "0xAD2E90", VA = "0xAD2E90")]
	public void EnableCollisions()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xAD2DEC", Offset = "0xAD2DEC", VA = "0xAD2DEC")]
	public void DisableCollisions()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xAD2F34", Offset = "0xAD2F34", VA = "0xAD2F34")]
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
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CollisionSound <>4__this;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0xAD358C", Offset = "0xAD358C", VA = "0xAD358C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0xAD35D4", Offset = "0xAD35D4", VA = "0xAD35D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xAD33F8", Offset = "0xAD33F8", VA = "0xAD33F8")]
		[DebuggerHidden]
		public <SoundPlayBuffer>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xAD34B8", Offset = "0xAD34B8", VA = "0xAD34B8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xAD34BC", Offset = "0xAD34BC", VA = "0xAD34BC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xAD3594", Offset = "0xAD3594", VA = "0xAD3594", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class <SoundPlayBuffer>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CollisionSound <>4__this;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float time;

		[Token(Token = "0x17000005")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000069")]
			[Address(RVA = "0xAD36B0", Offset = "0xAD36B0", VA = "0xAD36B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0xAD36F8", Offset = "0xAD36F8", VA = "0xAD36F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xAD3420", Offset = "0xAD3420", VA = "0xAD3420")]
		[DebuggerHidden]
		public <SoundPlayBuffer>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xAD35DC", Offset = "0xAD35DC", VA = "0xAD35DC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xAD35E0", Offset = "0xAD35E0", VA = "0xAD35E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xAD36B8", Offset = "0xAD36B8", VA = "0xAD36B8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("The layers that cause the sound to play")]
	public LayerMask collisionTriggers;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("Source to play sound from")]
	public AudioSource source;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("Source to play sound from")]
	public AudioClip clip;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Source to play sound from")]
	[Space]
	public AnimationCurve velocityVolumeCurve;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float volumeAmp;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float velocityAmp;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float soundRepeatDelay;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Rigidbody body;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool canPlaySound;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Coroutine playSoundRoutine;

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xAD2F44", Offset = "0xAD2F44", VA = "0xAD2F44")]
	private void Start()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xAD303C", Offset = "0xAD303C", VA = "0xAD303C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xAD3050", Offset = "0xAD3050", VA = "0xAD3050")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xAD3384", Offset = "0xAD3384", VA = "0xAD3384")]
	[IteratorStateMachine(typeof(<SoundPlayBuffer>d__13))]
	private IEnumerator SoundPlayBuffer()
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xAD2FB8", Offset = "0xAD2FB8", VA = "0xAD2FB8")]
	[IteratorStateMachine(typeof(<SoundPlayBuffer>d__14))]
	private IEnumerator SoundPlayBuffer(float time)
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xAD3448", Offset = "0xAD3448", VA = "0xAD3448")]
	public CollisionSound()
	{
	}
}
[Token(Token = "0x2000019")]
[RequireComponent(typeof(Collider))]
public class ColliderButtonInteraction : MonoBehaviour
{
	[Token(Token = "0x600006C")]
	[Address(RVA = "0xAD3700", Offset = "0xAD3700", VA = "0xAD3700")]
	private void Reset()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xAD375C", Offset = "0xAD375C", VA = "0xAD375C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xAD37B8", Offset = "0xAD37B8", VA = "0xAD37B8")]
	public ColliderButtonInteraction()
	{
	}
}
[Token(Token = "0x200001A")]
public class ColliderButtonSelector : MonoBehaviour
{
	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Chooser chooser;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool loopAround;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public KeyCode previousKey;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public KeyCode nextKey;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ColliderButton[] colliderButtons;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _index;

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xAD37C0", Offset = "0xAD37C0", VA = "0xAD37C0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xAD3870", Offset = "0xAD3870", VA = "0xAD3870")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xAD38C8", Offset = "0xAD38C8", VA = "0xAD38C8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xAD37CC", Offset = "0xAD37CC", VA = "0xAD37CC")]
	public void Next()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xAD390C", Offset = "0xAD390C", VA = "0xAD390C")]
	public void Previous()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xAD39A8", Offset = "0xAD39A8", VA = "0xAD39A8")]
	public ColliderButtonSelector()
	{
	}
}
[Token(Token = "0x200001B")]
[ExecuteInEditMode]
[RequireComponent(typeof(Spline))]
public class SplineControlledParticleSystem : MonoBehaviour
{
	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float startRadius;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float endRadius;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ParticleSystem _particleSystem;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Spline _spline;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ParticleSystem.Particle[] _particles;

	[Token(Token = "0x4000053")]
	private const float _previousDiff = 0.01f;

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xAD39BC", Offset = "0xAD39BC", VA = "0xAD39BC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xAD3A14", Offset = "0xAD3A14", VA = "0xAD3A14")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xAD404C", Offset = "0xAD404C", VA = "0xAD404C")]
	public SplineControlledParticleSystem()
	{
	}
}
[Token(Token = "0x200001C")]
public class BombInterAction : MonoBehaviour
{
	[Token(Token = "0x6000078")]
	[Address(RVA = "0xAD4054", Offset = "0xAD4054", VA = "0xAD4054")]
	public void BombCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xAD40BC", Offset = "0xAD40BC", VA = "0xAD40BC")]
	public BombInterAction()
	{
	}
}
[Token(Token = "0x200001D")]
public class FanInterAction
{
	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private string FanObjSoundName;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string FanEffectSoundName;

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xAD40C4", Offset = "0xAD40C4", VA = "0xAD40C4")]
	public void FanSoundCheck()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xAD43E4", Offset = "0xAD43E4", VA = "0xAD43E4")]
	public void FanTriggerStay(Collider collider)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xAD4564", Offset = "0xAD4564", VA = "0xAD4564")]
	public void FanTriggerExit()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xAD4624", Offset = "0xAD4624", VA = "0xAD4624")]
	public FanInterAction()
	{
	}
}
[Token(Token = "0x200001E")]
public class FenceInteraction
{
	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private FieldManager.StageTileInfo m_curStageTileInfo;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TableTileInfo.TableTileData CurTileData;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float CurTileXpos;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float CurTileYpos;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float CurTileZpos;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool reject;

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xAD462C", Offset = "0xAD462C", VA = "0xAD462C")]
	public void FenceInterActionProcess(Collision collision)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xAD5B8C", Offset = "0xAD5B8C", VA = "0xAD5B8C")]
	private void Revise(Transform BallPosition, Vector3 ContactPoint, Vector3 ObjPosition)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xAD55F8", Offset = "0xAD55F8", VA = "0xAD55F8")]
	private bool NormalVecCheckForFence(Vector3 normal)
	{
		return default(bool);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xAD5D3C", Offset = "0xAD5D3C", VA = "0xAD5D3C")]
	private bool NormalVecCheckForUnderTile(Vector3 normal, Vector3 ObjPosition)
	{
		return default(bool);
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xAD6260", Offset = "0xAD6260", VA = "0xAD6260")]
	private bool EdgeCheck(Vector3 normal, Vector3 ObjPosition)
	{
		return default(bool);
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xAD62AC", Offset = "0xAD62AC", VA = "0xAD62AC")]
	private int NullCountChecker(float XposChecker, float ZposChecker, Vector3 ObjPosition)
	{
		return default(int);
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xAD6424", Offset = "0xAD6424", VA = "0xAD6424")]
	public FenceInteraction()
	{
	}
}
[Token(Token = "0x200001F")]
public class InterActionManager : MonoBehaviour
{
	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private FenceInteraction m_Fence;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private TileInterAction m_Tile;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MagnetInterAction m_Magnet;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private JumpInterAction m_Jump;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private BombInterAction m_Bomb;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private PortalInterAction m_Portal;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private MovingTileInterAction m_MovingTile;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private SwitchInterAction m_Switch;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private FanInterAction m_Fan;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RaiseInterAction m_Raise;

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xAD642C", Offset = "0xAD642C", VA = "0xAD642C")]
	public void onUpdate()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xAD771C", Offset = "0xAD771C", VA = "0xAD771C")]
	public void onFixedUpdate()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xAD7F90", Offset = "0xAD7F90", VA = "0xAD7F90")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xADA138", Offset = "0xADA138", VA = "0xADA138")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xADAE28", Offset = "0xADAE28", VA = "0xADAE28")]
	private void OnCollisionExit(Collision collision)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xADAF1C", Offset = "0xADAF1C", VA = "0xADAF1C")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xADB060", Offset = "0xADB060", VA = "0xADB060")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xADB224", Offset = "0xADB224", VA = "0xADB224")]
	public InterActionManager()
	{
	}
}
[Token(Token = "0x2000020")]
public class JumpInterAction
{
	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Vector3 m_previousJump;

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xAD6B4C", Offset = "0xAD6B4C", VA = "0xAD6B4C")]
	public void ReUseJump()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xAD649C", Offset = "0xAD649C", VA = "0xAD649C")]
	public void JumpProcess()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xADB52C", Offset = "0xADB52C", VA = "0xADB52C")]
	public JumpInterAction()
	{
	}
}
[Token(Token = "0x2000021")]
public class MagnetInterAction
{
	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Transform ballTransform;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 m_v3PushDirection;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 m_v3PullDirection;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string m_strMagnetPushSoundName;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string m_strMagnetPullSoundName;

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xADB554", Offset = "0xADB554", VA = "0xADB554")]
	public void init(Transform balltf)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xAD96F8", Offset = "0xAD96F8", VA = "0xAD96F8")]
	public void MagnetInterActionProcess(Collision collision)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xAD7790", Offset = "0xAD7790", VA = "0xAD7790")]
	public bool MagnetCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xAD74AC", Offset = "0xAD74AC", VA = "0xAD74AC")]
	public void MagnetReUseProcess()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xADB920", Offset = "0xADB920", VA = "0xADB920")]
	private bool ReuseDistanceCheck(float Range, Transform MagnetTransform)
	{
		return default(bool);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xADB55C", Offset = "0xADB55C", VA = "0xADB55C")]
	private bool DistanceCheck(float Range, Transform MagnetTransform)
	{
		return default(bool);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xADB4B8", Offset = "0xADB4B8", VA = "0xADB4B8")]
	public MagnetInterAction()
	{
	}
}
[Token(Token = "0x2000022")]
public class MovingTileInterAction
{
	[Token(Token = "0x6000097")]
	[Address(RVA = "0xAD6C9C", Offset = "0xAD6C9C", VA = "0xAD6C9C")]
	public void onUpdateMovingTile()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xADB53C", Offset = "0xADB53C", VA = "0xADB53C")]
	public MovingTileInterAction()
	{
	}
}
[Token(Token = "0x2000023")]
public class PortalInterAction
{
	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private string PortalObjSound;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool m_bPortalStart;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform m_trRedPortal;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float m_fSavedBallSpeed;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float m_fPortalTimer;

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xAD6DA0", Offset = "0xAD6DA0", VA = "0xAD6DA0")]
	public void PortalSoundCheck()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xAD720C", Offset = "0xAD720C", VA = "0xAD720C")]
	public void UpdatePortalProcess()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xADA31C", Offset = "0xADA31C", VA = "0xADA31C")]
	public void GreenPortalTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xADA624", Offset = "0xADA624", VA = "0xADA624")]
	public void PortalEffectProcess(Collider other, string EffectName, bool isGreen = true)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xADB534", Offset = "0xADB534", VA = "0xADB534")]
	public PortalInterAction()
	{
	}
}
[Token(Token = "0x2000024")]
public class RaiseInterAction
{
	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Raise m_curRaise;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float BallVelocityX;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float BallVelocityZ;

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xADA914", Offset = "0xADA914", VA = "0xADA914")]
	public void RaiseTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xADAFF0", Offset = "0xADAFF0", VA = "0xADAFF0")]
	public void RaiseTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xADB110", Offset = "0xADB110", VA = "0xADB110")]
	public void RaiseTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xADBA3C", Offset = "0xADBA3C", VA = "0xADBA3C")]
	public void Accelerate(float acc, float maxSpeed)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xADB54C", Offset = "0xADB54C", VA = "0xADB54C")]
	public RaiseInterAction()
	{
	}
}
[Token(Token = "0x2000025")]
public class SwitchInterAction
{
	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Switch m_curSwitch;

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xAD986C", Offset = "0xAD986C", VA = "0xAD986C")]
	public void SwitchCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xADAEAC", Offset = "0xADAEAC", VA = "0xADAEAC")]
	public void SwitchCollisionExit(Collision collision)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xADA9C8", Offset = "0xADA9C8", VA = "0xADA9C8")]
	public void SwitchTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xAD7374", Offset = "0xAD7374", VA = "0xAD7374")]
	public void ReuseSwitchTrigger()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xADB544", Offset = "0xADB544", VA = "0xADB544")]
	public SwitchInterAction()
	{
	}
}
[Token(Token = "0x2000026")]
public class TileInterAction
{
	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private FieldManager.StageTileInfo m_curStageTileInfo;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TableTileInfo.TableTileData CurTileData;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float CurTileXpos;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float CurTileYpos;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float CurTileZpos;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool reject;

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xAD8F8C", Offset = "0xAD8F8C", VA = "0xAD8F8C")]
	public void TileSideInterAction(Collision collision)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xAD8730", Offset = "0xAD8730", VA = "0xAD8730")]
	public void TileInterActionProcess(Collision collision)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xAD84F4", Offset = "0xAD84F4", VA = "0xAD84F4")]
	public void SlopeSandCheck(Collision collision)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xADC66C", Offset = "0xADC66C", VA = "0xADC66C")]
	private bool CheckTileData(Vector3 ContactPoint, Transform BallPosition)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xADC888", Offset = "0xADC888", VA = "0xADC888")]
	private GameObject GetCorrectTile(Transform BallPosition, Vector3 ContactPoint)
	{
		return null;
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xADC248", Offset = "0xADC248", VA = "0xADC248")]
	private void TilePhysicsProcess(TableTileInfo.TableTileData TileInfo, GameObject Tile, bool isSide = false)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xADBB34", Offset = "0xADBB34", VA = "0xADBB34")]
	private GameObject GetCorrectSideTile(Transform BallPosition, Vector3 ContactPoint, Vector3 ContactObjPosition)
	{
		return null;
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xADBD24", Offset = "0xADBD24", VA = "0xADBD24")]
	private bool NormalVecCheckForSIde(Vector3 normal, Vector3 objPositon)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xADCA00", Offset = "0xADCA00", VA = "0xADCA00")]
	private bool EdgeCheck(Vector3 normal, Vector3 objPosition)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xADCA4C", Offset = "0xADCA4C", VA = "0xADCA4C")]
	private int NullCountChecker(float XposChecker, float ZposChecker, Vector3 ObjPosition)
	{
		return default(int);
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xADB4B0", Offset = "0xADB4B0", VA = "0xADB4B0")]
	public TileInterAction()
	{
	}
}
[Token(Token = "0x2000027")]
[RequireComponent(typeof(ParticleSystem))]
public class FireworksSoundSystem : MonoBehaviour
{
	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem m_psFireworks;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int m_nCurNumberofParticles;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string m_strSoundName;

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xADCBE0", Offset = "0xADCBE0", VA = "0xADCBE0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xADCC38", Offset = "0xADCC38", VA = "0xADCC38")]
	private void Update()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xADCCF0", Offset = "0xADCCF0", VA = "0xADCCF0")]
	public FireworksSoundSystem()
	{
	}
}
[Token(Token = "0x2000028")]
public class FlyGoalEffect : SlowEffect
{
	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float m_fSlowLength;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float m_fLuckyDot;

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xADCCF8", Offset = "0xADCCF8", VA = "0xADCCF8", Slot = "4")]
	public override void onUpdate()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xADCD54", Offset = "0xADCD54", VA = "0xADCD54")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xADD458", Offset = "0xADD458", VA = "0xADD458")]
	public FlyGoalEffect()
	{
	}
}
[Token(Token = "0x2000029")]
public class GoalEffectControl : MonoBehaviour
{
	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform m_trEffectPosition;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string m_strGoalEffectName;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_bGoalEffectStart;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float m_fTimer;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float m_fDelayedTime;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool m_bSkyboxChangeStart;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float m_fExpValue;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float m_fSkyBoxExpChanger;

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xADD4C8", Offset = "0xADD4C8", VA = "0xADD4C8")]
	private void Start()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xADD4D4", Offset = "0xADD4D4", VA = "0xADD4D4")]
	public void Update()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xADDCA8", Offset = "0xADDCA8", VA = "0xADDCA8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xADE220", Offset = "0xADE220", VA = "0xADE220")]
	private string PuttGoalEffect()
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xADD528", Offset = "0xADD528", VA = "0xADD528")]
	private void GoalVibeAndSound(string Goal)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xADDBB0", Offset = "0xADDBB0", VA = "0xADDBB0")]
	private void SkyboxExpChange()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xADE4C4", Offset = "0xADE4C4", VA = "0xADE4C4")]
	public GoalEffectControl()
	{
	}
}
[Token(Token = "0x200002A")]
public class PuttGoalEffect : SlowEffect
{
	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public FlyGoalEffect flyGoal;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float m_fEnableCheckDistance;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float m_fSlowLength;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float m_fSlowScale;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float m_fNaturalDot;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float m_fLuckyDot;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float m_fRotationSpeed;

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xADE4D4", Offset = "0xADE4D4", VA = "0xADE4D4", Slot = "4")]
	public override void onUpdate()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xADE878", Offset = "0xADE878", VA = "0xADE878")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xADEFE4", Offset = "0xADEFE4", VA = "0xADEFE4")]
	private void SlowProcess(bool isNatural = true)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xADEDB0", Offset = "0xADEDB0", VA = "0xADEDB0")]
	private void LuckyShotProcess(float dot, float speed)
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xADF334", Offset = "0xADF334", VA = "0xADF334")]
	public PuttGoalEffect()
	{
	}
}
[Token(Token = "0x200002B")]
public class SlowEffect : MonoBehaviour
{
	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform m_tCamPosition;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public bool m_bStartSlow;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[HideInInspector]
	public float m_fTimeChecker;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public bool m_bLuckyShotStart;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[HideInInspector]
	public Vector3 m_v3GoalVector;

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xADF350", Offset = "0xADF350", VA = "0xADF350", Slot = "4")]
	public virtual void onUpdate()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xADD468", Offset = "0xADD468", VA = "0xADD468")]
	public SlowEffect()
	{
	}
}
[Token(Token = "0x200002C")]
public class TableLoader : Singleton<TableLoader>
{
	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<Dictionary<string, string>> m_table;

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xADF354", Offset = "0xADF354", VA = "0xADF354")]
	public string GetData(string key, int index)
	{
		return null;
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xADF3DC", Offset = "0xADF3DC", VA = "0xADF3DC")]
	public string GetString(string key, int index)
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	public T GetEnum<T>(string key, int index)
	{
		return (T)null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xADF3E0", Offset = "0xADF3E0", VA = "0xADF3E0")]
	public byte GetByte(string key, int index)
	{
		return default(byte);
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xADF3F4", Offset = "0xADF3F4", VA = "0xADF3F4")]
	public int GetInt(string key, int index)
	{
		return default(int);
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xADF480", Offset = "0xADF480", VA = "0xADF480")]
	public float GetFloat(string key, int index)
	{
		return default(float);
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xADF50C", Offset = "0xADF50C", VA = "0xADF50C")]
	public short GetShort(string key, int index)
	{
		return default(short);
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xADF598", Offset = "0xADF598", VA = "0xADF598")]
	public long GetLong(string key, int index)
	{
		return default(long);
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xADF624", Offset = "0xADF624", VA = "0xADF624")]
	public int GetLength()
	{
		return default(int);
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xADF66C", Offset = "0xADF66C", VA = "0xADF66C")]
	public void LoadTable(byte[] buff, bool isEncryptData = true)
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xADFAB8", Offset = "0xADFAB8", VA = "0xADFAB8")]
	public void Clear()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xADFB28", Offset = "0xADFB28", VA = "0xADFB28")]
	public TableLoader()
	{
	}
}
[Token(Token = "0x200002D")]
public class TableObjectInfo : Singleton<TableObjectInfo>
{
	[Token(Token = "0x200002E")]
	public class TableObjectData
	{
		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_nObjectUnique;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string m_strName;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string m_strObjPath;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float m_fObjectOffset_X;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float m_fObjectOffset_Y;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m_fObjectOffset_Z;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Dictionary<string, FunctionData> m_dicFunction;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string m_strObjSound;

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xAE012C", Offset = "0xAE012C", VA = "0xAE012C")]
		public TableObjectData()
		{
		}
	}

	[Token(Token = "0x200002F")]
	public class FunctionData
	{
		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float m_fFunction_Value1;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float m_fFunction_Value2;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float m_fFunction_Value3;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string m_strFunction_EffectSound;

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xAE01B4", Offset = "0xAE01B4", VA = "0xAE01B4")]
		public FunctionData()
		{
		}
	}

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Dictionary<int, TableObjectData> m_dicData;

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xADFBC4", Offset = "0xADFBC4", VA = "0xADFBC4")]
	public void Load()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xAE00DC", Offset = "0xAE00DC", VA = "0xAE00DC")]
	public void Unload()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xAE01BC", Offset = "0xAE01BC", VA = "0xAE01BC")]
	public string GetObjectPath(int unique)
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xAE0268", Offset = "0xAE0268", VA = "0xAE0268")]
	public TableObjectData GetObjectData(int objectUnique)
	{
		return null;
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xAE02FC", Offset = "0xAE02FC", VA = "0xAE02FC")]
	public float GetObjectOffset_X(int unique)
	{
		return default(float);
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xAE0390", Offset = "0xAE0390", VA = "0xAE0390")]
	public float GetObjectOffset_Y(int unique)
	{
		return default(float);
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xAE0424", Offset = "0xAE0424", VA = "0xAE0424")]
	public float GetObjectOffset_Z(int unique)
	{
		return default(float);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xAE04B8", Offset = "0xAE04B8", VA = "0xAE04B8")]
	public TableObjectInfo()
	{
	}
}
[Token(Token = "0x2000030")]
public class TableSoundInfo : Singleton<TableSoundInfo>
{
	[Token(Token = "0x2000031")]
	public class SoundData
	{
		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string m_strSoundUnique;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string m_strSoundPath;

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xAE0794", Offset = "0xAE0794", VA = "0xAE0794")]
		public SoundData()
		{
		}
	}

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Dictionary<string, SoundData> m_dicData;

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xAE0554", Offset = "0xAE0554", VA = "0xAE0554")]
	public void Load()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xAE0744", Offset = "0xAE0744", VA = "0xAE0744")]
	public void Unload()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xAE079C", Offset = "0xAE079C", VA = "0xAE079C")]
	public string GetSoundInfo(string Unique)
	{
		return null;
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xAE0834", Offset = "0xAE0834", VA = "0xAE0834")]
	public TableSoundInfo()
	{
	}
}
[Token(Token = "0x2000032")]
public class TableStageInfo : Singleton<TableStageInfo>
{
	[Token(Token = "0x2000033")]
	public class StageData
	{
		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_nStageUnique;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int m_nChapter;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int m_nStageChance;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int m_nResultB;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int m_nResultA;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string m_strTextKey;

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xAE0D84", Offset = "0xAE0D84", VA = "0xAE0D84")]
		public StageData()
		{
		}
	}

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Dictionary<int, StageData> m_dicData;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Dictionary<int, List<int>> m_dicStageList;

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xAE08D0", Offset = "0xAE08D0", VA = "0xAE08D0")]
	public void Load()
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xAE0D34", Offset = "0xAE0D34", VA = "0xAE0D34")]
	public void Unload()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xAE0D8C", Offset = "0xAE0D8C", VA = "0xAE0D8C")]
	public StageData GetStageData(int stageUnique)
	{
		return null;
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xAE0E20", Offset = "0xAE0E20", VA = "0xAE0E20")]
	public List<int> GetChapterList(int StageChapter)
	{
		return null;
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xAE0EB4", Offset = "0xAE0EB4", VA = "0xAE0EB4")]
	public int GetStageUnique(int Chapter, int Number)
	{
		return default(int);
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xAE0F80", Offset = "0xAE0F80", VA = "0xAE0F80")]
	public void ChangeStage(ref int Chapter, ref int StageNumber)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xAE1064", Offset = "0xAE1064", VA = "0xAE1064")]
	public bool StagePossibleCheck(int Chapter, int StageNumber)
	{
		return default(bool);
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xAE135C", Offset = "0xAE135C", VA = "0xAE135C")]
	public bool isChapterOpen(int Chapter)
	{
		return default(bool);
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xAE1510", Offset = "0xAE1510", VA = "0xAE1510")]
	public TableStageInfo()
	{
	}
}
[Token(Token = "0x2000034")]
public class TableStageObject : Singleton<TableStageObject>
{
	[Token(Token = "0x2000035")]
	public class TableStageObjectDatas
	{
		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_nStageUnique;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int m_nStageColumn;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string> m_listStageRow;

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xAE4C8C", Offset = "0xAE4C8C", VA = "0xAE4C8C")]
		public TableStageObjectDatas()
		{
		}
	}

	[Token(Token = "0x2000036")]
	public class StageObjectsDetails
	{
		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_nObjectUnique;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int m_nObjectRotate;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int m_nObjectHeight;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int m_nPortaltPairing;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int m_nSwitchPairing;

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xAE4D14", Offset = "0xAE4D14", VA = "0xAE4D14")]
		public StageObjectsDetails()
		{
		}
	}

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Dictionary<int, List<TableStageObjectDatas>> m_dicStageObjData;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int key;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int index;

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xAE15FC", Offset = "0xAE15FC", VA = "0xAE15FC")]
	public void Load()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xAE3468", Offset = "0xAE3468", VA = "0xAE3468")]
	public void Unload()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xAE34B8", Offset = "0xAE34B8", VA = "0xAE34B8")]
	public void StageObjectLoad(int StageUnique)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xAE3620", Offset = "0xAE3620", VA = "0xAE3620")]
	public void SendTileData(string ObjectData)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xAE3BF0", Offset = "0xAE3BF0", VA = "0xAE3BF0")]
	public TableStageObject()
	{
	}
}
[Token(Token = "0x2000037")]
public class TableStageTile : Singleton<TableStageTile>
{
	[Token(Token = "0x2000038")]
	public class TableStageTileData
	{
		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_nStageUnique;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int m_nStageColumn;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string> m_listStageRowData;

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xAE6CB4", Offset = "0xAE6CB4", VA = "0xAE6CB4")]
		public TableStageTileData()
		{
		}
	}

	[Token(Token = "0x2000039")]
	public class DetailedEachTileData
	{
		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_nTileUnique;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int m_nTileHeight;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int m_nTileRotate;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int m_nUnderTileSize;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject m_gTile;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TableTileInfo.TableTileData m_curTileData;

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xAE7874", Offset = "0xAE7874", VA = "0xAE7874")]
		public DetailedEachTileData()
		{
		}
	}

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Dictionary<int, List<TableStageTileData>> m_dicStageData;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Vector3 offset;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int index;

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xAE4D1C", Offset = "0xAE4D1C", VA = "0xAE4D1C")]
	public void Load()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xAE6C64", Offset = "0xAE6C64", VA = "0xAE6C64")]
	public void Unload()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xAE6D3C", Offset = "0xAE6D3C", VA = "0xAE6D3C")]
	public void StageTileLoad(int StageUnique)
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xAE6EA4", Offset = "0xAE6EA4", VA = "0xAE6EA4")]
	public void TileSet(string Tile)
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xAE7D38", Offset = "0xAE7D38", VA = "0xAE7D38")]
	public TableStageTile()
	{
	}
}
[Token(Token = "0x200003A")]
public class TableTextManager : Singleton<TableTextManager>
{
	[Token(Token = "0x200003B")]
	public class TextData
	{
		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string m_strTextKey;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string m_strText;

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xAE8108", Offset = "0xAE8108", VA = "0xAE8108")]
		public TextData()
		{
		}
	}

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Dictionary<string, TextData> m_dicData;

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xAE7E58", Offset = "0xAE7E58", VA = "0xAE7E58")]
	public void Load()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xAE80B8", Offset = "0xAE80B8", VA = "0xAE80B8")]
	private void Unload()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xAE8110", Offset = "0xAE8110", VA = "0xAE8110")]
	public string GetText(string TextKey)
	{
		return null;
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xAE81A8", Offset = "0xAE81A8", VA = "0xAE81A8")]
	public TableTextManager()
	{
	}
}
[Token(Token = "0x200003C")]
public class TableTileInfo : Singleton<TableTileInfo>
{
	[Token(Token = "0x200003D")]
	public class TableTileData
	{
		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_nTileUnique;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string m_strName;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string m_strTilePath;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string m_strUnderTilePath;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int m_nResistant;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float m_fBounce;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string m_strEffect;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float m_fEffect_Value;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string m_strEffect_Sound;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string m_strOnTile;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string m_strDropTile;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public GameObject m_objTile;

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xAE866C", Offset = "0xAE866C", VA = "0xAE866C")]
		public TableTileData()
		{
		}
	}

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Dictionary<int, TableTileData> m_dicData;

	[Token(Token = "0x6000100")]
	[Address(RVA = "0xAE8244", Offset = "0xAE8244", VA = "0xAE8244")]
	public void Load()
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0xAE861C", Offset = "0xAE861C", VA = "0xAE861C")]
	public void Unload()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0xAE8674", Offset = "0xAE8674", VA = "0xAE8674")]
	public TableTileData GetTileData(int TileUnique)
	{
		return null;
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0xAE8708", Offset = "0xAE8708", VA = "0xAE8708")]
	public int GetTileResistant(int TileUnique)
	{
		return default(int);
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0xAE87A0", Offset = "0xAE87A0", VA = "0xAE87A0")]
	public string GetTilePath(int TileUnique)
	{
		return null;
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0xAE884C", Offset = "0xAE884C", VA = "0xAE884C")]
	public string GetUnderTilePath(int TileUnique)
	{
		return null;
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xAE88F8", Offset = "0xAE88F8", VA = "0xAE88F8")]
	public TableTileInfo()
	{
	}
}
[Token(Token = "0x200003E")]
public class CameraFadeEffect : MonoBehaviour
{
	[Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class <DoFade>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color startColor;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public CameraFadeEffect <>4__this;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float startAlpha;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float targetAlpha;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float startDelay;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float duration;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Action onDone;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float <time>5__2;

		[Token(Token = "0x17000007")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0xAE9638", Offset = "0xAE9638", VA = "0xAE9638", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0xAE9680", Offset = "0xAE9680", VA = "0xAE9680", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xAE9218", Offset = "0xAE9218", VA = "0xAE9218")]
		[DebuggerHidden]
		public <DoFade>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xAE93DC", Offset = "0xAE93DC", VA = "0xAE93DC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xAE93E0", Offset = "0xAE93E0", VA = "0xAE93E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xAE9640", Offset = "0xAE9640", VA = "0xAE9640", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool isFading;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static CameraFadeEffect _instance;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Material fadeMaterial;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Coroutine m_beforeCoroutine;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Action m_beforeOnDone;

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xAE8994", Offset = "0xAE8994", VA = "0xAE8994")]
	public static CameraFadeEffect GetFadeEffect([Optional] Camera cam)
	{
		return null;
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0xAE8AB4", Offset = "0xAE8AB4", VA = "0xAE8AB4")]
	private static CameraFadeEffect AddFadeEffect([Optional] Camera cam)
	{
		return null;
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xAE8C28", Offset = "0xAE8C28", VA = "0xAE8C28")]
	private void Awake()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xAE8B68", Offset = "0xAE8B68", VA = "0xAE8B68")]
	private void Init()
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xAE8CFC", Offset = "0xAE8CFC", VA = "0xAE8CFC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xAE8DB0", Offset = "0xAE8DB0", VA = "0xAE8DB0")]
	public static bool IsFading()
	{
		return default(bool);
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xAE8E58", Offset = "0xAE8E58", VA = "0xAE8E58")]
	public static void TriggerFade(Color startColor, float startAlpha, float targetAlpha, float startDelay, float duration, [Optional] Action onDone)
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xAE8FB4", Offset = "0xAE8FB4", VA = "0xAE8FB4")]
	public void Fade(Color startColor, float startAlpha, float targetAlpha, float startDelay, float duration, [Optional] Action onDone)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xAE9138", Offset = "0xAE9138", VA = "0xAE9138")]
	[IteratorStateMachine(typeof(<DoFade>d__13))]
	private IEnumerator DoFade(Color startColor, float startAlpha, float targetAlpha, float startDelay, float duration, [Optional] Action onDone)
	{
		return null;
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xAE9240", Offset = "0xAE9240", VA = "0xAE9240")]
	private void OnRenderImage(RenderTexture src, RenderTexture dst)
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xAE9310", Offset = "0xAE9310", VA = "0xAE9310")]
	public static void SetFadeEnable(bool isEnable)
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xAE93C8", Offset = "0xAE93C8", VA = "0xAE93C8")]
	public void _SetFadeEnable(bool isEnable)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xAE93D4", Offset = "0xAE93D4", VA = "0xAE93D4")]
	public CameraFadeEffect()
	{
	}
}
[Token(Token = "0x2000040")]
public class ScreenFade : MonoBehaviour
{
	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int sceneToLoad;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UniversalRendererData rendererData;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(0f, 1f)]
	public float alpha;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Range(0f, 5f)]
	public float duration;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private TweenBase tween;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Material fadeMaterial;

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xAE9688", Offset = "0xAE9688", VA = "0xAE9688")]
	private void Start()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xAE968C", Offset = "0xAE968C", VA = "0xAE968C")]
	private void SetupFadeFeature()
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xAE986C", Offset = "0xAE986C", VA = "0xAE986C")]
	public void SetPossible(bool _Active)
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xAE9A5C", Offset = "0xAE9A5C", VA = "0xAE9A5C")]
	public void FadeOut(float _Time, [Optional] CanvasGroup _Canvas)
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xAE9BB8", Offset = "0xAE9BB8", VA = "0xAE9BB8")]
	public void CancelFade()
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xAE9C38", Offset = "0xAE9C38", VA = "0xAE9C38")]
	public void FadeIn(float _Time, [Optional] CanvasGroup _Canvas)
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xAE9D6C", Offset = "0xAE9D6C", VA = "0xAE9D6C")]
	public ScreenFade()
	{
	}
}
[Token(Token = "0x2000042")]
public class ScreenFadeFeature : ScriptableRendererFeature
{
	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public FadeSettings settings;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ScreenFadePass renderPass;

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xAE9EE4", Offset = "0xAE9EE4", VA = "0xAE9EE4", Slot = "5")]
	public override void Create()
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xAE9F94", Offset = "0xAE9F94", VA = "0xAE9F94", Slot = "7")]
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xAEA05C", Offset = "0xAEA05C", VA = "0xAEA05C")]
	public ScreenFadeFeature()
	{
	}
}
[Serializable]
[Token(Token = "0x2000043")]
public class FadeSettings
{
	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool isEnabled;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string profilerTag;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RenderPassEvent renderPassEvent;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material material;

	[NonSerialized]
	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material runTimeMaterial;

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xAE9FE0", Offset = "0xAE9FE0", VA = "0xAE9FE0")]
	public bool AreValid()
	{
		return default(bool);
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0xAEA064", Offset = "0xAEA064", VA = "0xAEA064")]
	public FadeSettings()
	{
	}
}
[Token(Token = "0x2000044")]
public class ScreenFadeManager : DontDestroy<ScreenFadeManager>
{
	[Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class <FadeSequence>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float _StartDelay;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ScreenFadeManager <>4__this;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float _FadeOutTime;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public CanvasGroup canvasGroup;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float _FadeInDelay;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float _FadeInTime;

		[Token(Token = "0x17000009")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0xAEA8D0", Offset = "0xAEA8D0", VA = "0xAEA8D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0xAEA918", Offset = "0xAEA918", VA = "0xAEA918", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xAEA268", Offset = "0xAEA268", VA = "0xAEA268")]
		[DebuggerHidden]
		public <FadeSequence>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xAEA68C", Offset = "0xAEA68C", VA = "0xAEA68C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xAEA690", Offset = "0xAEA690", VA = "0xAEA690", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xAEA8D8", Offset = "0xAEA8D8", VA = "0xAEA8D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class <FadeOutSequence>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float _StartDelay;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ScreenFadeManager <>4__this;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float _fadeOutTime;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public CanvasGroup canvasGroup;

		[Token(Token = "0x1700000B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0xAEAAA8", Offset = "0xAEAAA8", VA = "0xAEAAA8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0xAEAAF0", Offset = "0xAEAAF0", VA = "0xAEAAF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xAEA3C8", Offset = "0xAEA3C8", VA = "0xAEA3C8")]
		[DebuggerHidden]
		public <FadeOutSequence>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xAEA920", Offset = "0xAEA920", VA = "0xAEA920", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xAEA924", Offset = "0xAEA924", VA = "0xAEA924", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xAEAAB0", Offset = "0xAEAAB0", VA = "0xAEAAB0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class <FadeInSequence>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float _StartDelay;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ScreenFadeManager <>4__this;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float _fadeInTime;

		[Token(Token = "0x1700000D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0xAEAC24", Offset = "0xAEAC24", VA = "0xAEAC24", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0xAEAC6C", Offset = "0xAEAC6C", VA = "0xAEAC6C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xAEA4FC", Offset = "0xAEA4FC", VA = "0xAEA4FC")]
		[DebuggerHidden]
		public <FadeInSequence>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xAEAAF8", Offset = "0xAEAAF8", VA = "0xAEAAF8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xAEAAFC", Offset = "0xAEAAFC", VA = "0xAEAAFC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xAEAC2C", Offset = "0xAEAC2C", VA = "0xAEAC2C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ScreenFade screenFade;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Action m_AfterFadeOut;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Action m_AfterFadeIn;

	[Token(Token = "0x600012B")]
	[Address(RVA = "0xAEA0CC", Offset = "0xAEA0CC", VA = "0xAEA0CC")]
	private void Start()
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0xAEA0D0", Offset = "0xAEA0D0", VA = "0xAEA0D0")]
	private void Update()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0xAEA0D4", Offset = "0xAEA0D4", VA = "0xAEA0D4")]
	public void Fade(float _FadeOutTime, float _FadeInTime = 1f, float _FadeinDelay = 0f, [Optional] Action onFadeOutDone, [Optional] Action onFadeInDone, float _StartDelay = 0f, [Optional] CanvasGroup canvasGroup)
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0xAEA1AC", Offset = "0xAEA1AC", VA = "0xAEA1AC")]
	[IteratorStateMachine(typeof(<FadeSequence>d__6))]
	private IEnumerator FadeSequence(float _FadeOutTime, float _FadeInTime, float _FadeInDelay, [Optional] CanvasGroup canvasGroup, float _StartDelay = 0f)
	{
		return null;
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0xAEA290", Offset = "0xAEA290", VA = "0xAEA290")]
	public void FadeOut(float _FadeOutTime, [Optional] Action onFadeOutDone, float _StartDelay = 0f, [Optional] CanvasGroup canvasGroup)
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0xAEA320", Offset = "0xAEA320", VA = "0xAEA320")]
	[IteratorStateMachine(typeof(<FadeOutSequence>d__8))]
	private IEnumerator FadeOutSequence(float _fadeOutTime, [Optional] CanvasGroup canvasGroup, float _StartDelay = 0f)
	{
		return null;
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xAEA3F0", Offset = "0xAEA3F0", VA = "0xAEA3F0")]
	public void FadeIn(float _FadeInTime, [Optional] Action onFadeInDone, float _StartDelay = 0f)
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0xAEA470", Offset = "0xAEA470", VA = "0xAEA470")]
	[IteratorStateMachine(typeof(<FadeInSequence>d__10))]
	private IEnumerator FadeInSequence(float _fadeInTime, float _StartDelay = 0f)
	{
		return null;
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0xAEA524", Offset = "0xAEA524", VA = "0xAEA524")]
	private void OnFadeOutDone()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xAEA560", Offset = "0xAEA560", VA = "0xAEA560")]
	private void OnFadeInDone()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xAEA59C", Offset = "0xAEA59C", VA = "0xAEA59C")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xAEA644", Offset = "0xAEA644", VA = "0xAEA644")]
	public ScreenFadeManager()
	{
	}
}
[Token(Token = "0x2000048")]
public class ScreenFadePass : ScriptableRenderPass
{
	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private FadeSettings settings;

	[Token(Token = "0x6000149")]
	[Address(RVA = "0xAE9F50", Offset = "0xAE9F50", VA = "0xAE9F50")]
	public ScreenFadePass(FadeSettings newSettings)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0xAEAC74", Offset = "0xAEAC74", VA = "0xAEAC74", Slot = "9")]
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}
}
[Token(Token = "0x2000049")]
public class TileFader : MonoBehaviour
{
	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshRenderer m_MeshRenderer;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Material m_savedMaterial;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Material m_transParentMaterial;

	[Token(Token = "0x600014B")]
	[Address(RVA = "0xAEADBC", Offset = "0xAEADBC", VA = "0xAEADBC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0xAEAE80", Offset = "0xAEAE80", VA = "0xAEAE80")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0xAEAEFC", Offset = "0xAEAEFC", VA = "0xAEAEFC")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0xAEAF78", Offset = "0xAEAF78", VA = "0xAEAF78")]
	public TileFader()
	{
	}
}
[Token(Token = "0x200004A")]
public class AllSharedStageDatas
{
	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Transform m_trCenterOfBall;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<DummyBall> m_listDummyBalls;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject m_gBallTrailEffect;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform m_trCircumferenceBall;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public LineRenderer m_ballVectorLine;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TrailRenderer m_fxTrail;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector3 m_v3BallTargetVector;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool m_b202TutoOn;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	public bool m_bCameraChangeStart;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
	public bool m_bCameraApproach;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
	public bool m_bIsAlreadyUndo;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool m_bWallPushing;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<MeshCombineManager> m_listAllMeshCombine;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<GameObject> m_list_BrokenRe_Objects;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Stack<List<GameObject>> m_Stack_Broken_Objects;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public MeshCombineManager m_CurTileMeshCombine;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public List<MeshCombineManager> m_LIstAllAffectedMeshCombine;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<MeshCombineManager> m_ListAllAffectedBrokenMeshCombine;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Stack<List<MeshCombineManager>> m_Stack_Broken_MeshCombine;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<MeshCombineManager> m_ListBombTileMeshCombine;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public bool m_bStageStart;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<StageObjects> m_ListThisTurnSwitchOnObjects;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Stack<List<StageObjects>> m_Stack_SwitchOn_Objects;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public List<GameObject> m_list_Broken_Objects;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Stack<Vector3> m_Stack_BallPosition;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public List<Magnet> m_ListAllStagePushMagnets;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public List<Magnet> m_ListAllStagePullMagnets;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public List<Jump> m_listAllStageJump;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public List<Bomb> m_ListAllStageBombs;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Dictionary<int, Transform> m_dicAllStageRedPortal;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public List<Portal> m_ListAllStageBluePortals;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public List<Portal> m_ListAllStageRedPortals;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public List<MovingTile> m_ListAllStageMovingTiles;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public List<Fan> m_ListAllStageFans;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public List<Switch> m_ListAllStageSwitch;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public List<StageObjects> m_ListAllStageObjects;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public GameObject m_gCurDisabledMagnet;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public Stack<GameObject> m_StackDisabledPullMagnets;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public Material m_matSwitchOn;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public Material m_matSwitchOff;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public int m_nCurMapTileCount;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public SlowEffect m_clCurSlowEffect;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public Transform m_tCurGoalCamera;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public bool m_bThisTurnSlowOn;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x151")]
	public bool m_bisFlyGoal;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x152")]
	public bool m_bisSlowNatural;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x153")]
	public bool m_bisLuckyGoal;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	public bool m_bEndEffectOn;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public float m_fStageStartTime;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	public float m_fStageEndTime;

	[Token(Token = "0x600014F")]
	[Address(RVA = "0xAEAF80", Offset = "0xAEAF80", VA = "0xAEAF80")]
	public void SettingAllStageObjectsList()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0xAEB04C", Offset = "0xAEB04C", VA = "0xAEB04C")]
	public AllSharedStageDatas()
	{
	}
}
[Token(Token = "0x200004B")]
public class ControllerManager : DontDestroy<ControllerManager>
{
	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject MainController;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject TrackedController_Right;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject TrackedController_Left;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject TrackerOffset;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public HandCanvasPointer HandCanvasPointer;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Camera m_camMain;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool m_bStartUpdate;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private int m_nCount;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AutoHandPlayer m_playerMain;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public PerLayerCulling m_Culling;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ControllerMapping controller;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject DronFrame;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private EnumClient.eHandPose m_eHandPose;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public ConstClient.ePlatfomType m_CurlatfomType;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Transform UI_Pointer;

	[Token(Token = "0x6000151")]
	[Address(RVA = "0xAEB6FC", Offset = "0xAEB6FC", VA = "0xAEB6FC", Slot = "4")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0xAEB744", Offset = "0xAEB744", VA = "0xAEB744")]
	private void Start()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0xAEBEEC", Offset = "0xAEBEEC", VA = "0xAEBEEC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0xAEBF60", Offset = "0xAEBF60", VA = "0xAEBF60")]
	public void SetePlayerPosition(Vector3 v3Pos)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0xAEBF84", Offset = "0xAEBF84", VA = "0xAEBF84")]
	public void SetePlayerRotation(Quaternion quRotate)
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0xAEBFA8", Offset = "0xAEBFA8", VA = "0xAEBFA8")]
	public void SetPositionRotate(Transform tBase)
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0xAEC018", Offset = "0xAEC018", VA = "0xAEC018")]
	public EnumClient.eHandPose GetCurrentHandPose()
	{
		return default(EnumClient.eHandPose);
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0xAEC020", Offset = "0xAEC020", VA = "0xAEC020")]
	public void SetCurrentHandPose(EnumClient.eHandPose ePose)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0xAEC028", Offset = "0xAEC028", VA = "0xAEC028")]
	public Camera GetMainCamera()
	{
		return null;
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0xAEC030", Offset = "0xAEC030", VA = "0xAEC030")]
	public void UIPointerSizeChange()
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0xAEC068", Offset = "0xAEC068", VA = "0xAEC068")]
	public void UIPointerSizeReset()
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0xAEC0A0", Offset = "0xAEC0A0", VA = "0xAEC0A0")]
	public void ChangeCulling414()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0xAEC120", Offset = "0xAEC120", VA = "0xAEC120")]
	public void CullingReset()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0xAEC198", Offset = "0xAEC198", VA = "0xAEC198")]
	public void FreeCameraCulling()
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0xAEC20C", Offset = "0xAEC20C", VA = "0xAEC20C")]
	public bool isAngularFasterThanController(out float velocity)
	{
		return default(bool);
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0xAEC560", Offset = "0xAEC560", VA = "0xAEC560")]
	public ControllerManager()
	{
	}
}
[Token(Token = "0x200004C")]
public class ControllerMapping
{
	[Token(Token = "0x200004D")]
	private enum ePicoControllerHand
	{
		[Token(Token = "0x4000165")]
		Left,
		[Token(Token = "0x4000166")]
		Right
	}

	[Token(Token = "0x200004E")]
	public enum eControllerButton
	{
		[Token(Token = "0x4000168")]
		ButtonA,
		[Token(Token = "0x4000169")]
		ButtonB,
		[Token(Token = "0x400016A")]
		ButtonX,
		[Token(Token = "0x400016B")]
		ButtonY,
		[Token(Token = "0x400016C")]
		LeftGrip,
		[Token(Token = "0x400016D")]
		RightGrip,
		[Token(Token = "0x400016E")]
		LeftTrigger,
		[Token(Token = "0x400016F")]
		RightTrigger,
		[Token(Token = "0x4000170")]
		Menu,
		[Token(Token = "0x4000171")]
		MAX
	}

	[Token(Token = "0x400014E")]
	private const float CLICK_HARD = 0.5f;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private EnumClient.eTouchDirection m_eCurrentThumbStick_Right;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private EnumClient.eTouchDirection m_eCurrentThumbStick_Left;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private EnumClient.eTouchDirection m_eCurrentThumbStickDown_Right;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private EnumClient.eTouchDirection m_eCurrentThumbStickDown_Left;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Quaternion m_quCalcChar_Right;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Quaternion m_quCalcChar_Left;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool m_bClickDownThumbStick_Right;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private bool m_bClickDownThumbStick_Left;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	private bool m_bThumbSitckClickOn_Left;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x43")]
	private bool m_bThumbSitckClickOn_Right;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float m_fThumbStickClick;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public InputDevice m_deviceRight;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public InputDevice m_deviceLeft;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private XRNode xRNode_Left;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private XRNode xRNode_Right;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool[] m_listButtonDown;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool[] m_listButtonStay;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool[] m_listButtonUp;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool ClickDownLeft;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
	private bool ClickDownRight;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private Vector2 primary2DAxisValue;

	[Token(Token = "0x6000161")]
	[Address(RVA = "0xAEBBD8", Offset = "0xAEBBD8", VA = "0xAEBBD8")]
	public ControllerMapping()
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0xAEC5A8", Offset = "0xAEC5A8", VA = "0xAEC5A8")]
	public bool AppButtonDown()
	{
		return default(bool);
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0xAEC5D4", Offset = "0xAEC5D4", VA = "0xAEC5D4")]
	public EnumClient.eTouchDirection StickDirection(EnumClient.eHandPose ePose = EnumClient.eHandPose.Right)
	{
		return default(EnumClient.eTouchDirection);
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0xAEC5EC", Offset = "0xAEC5EC", VA = "0xAEC5EC")]
	public EnumClient.eTouchDirection StickDirectionDown(EnumClient.eHandPose ePose = EnumClient.eHandPose.Right)
	{
		return default(EnumClient.eTouchDirection);
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0xAEC604", Offset = "0xAEC604", VA = "0xAEC604")]
	private EnumClient.eTouchDirection GetThumbDirectionDownLeft(EnumClient.eHandPose ePose = EnumClient.eHandPose.Right)
	{
		return default(EnumClient.eTouchDirection);
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0xAEC8DC", Offset = "0xAEC8DC", VA = "0xAEC8DC")]
	private EnumClient.eTouchDirection GetThumbDirectionDownRight(EnumClient.eHandPose ePose = EnumClient.eHandPose.Right)
	{
		return default(EnumClient.eTouchDirection);
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0xAECA98", Offset = "0xAECA98", VA = "0xAECA98")]
	private EnumClient.eTouchDirection GetThumbDirection(EnumClient.eHandPose ePose = EnumClient.eHandPose.Right)
	{
		return default(EnumClient.eTouchDirection);
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0xAECCA4", Offset = "0xAECCA4", VA = "0xAECCA4")]
	public bool ClickTelePortButton()
	{
		return default(bool);
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0xAECCC4", Offset = "0xAECCC4", VA = "0xAECCC4")]
	public bool ClickTrigger(EnumClient.eHandPose ePose = EnumClient.eHandPose.Right)
	{
		return default(bool);
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0xAECD08", Offset = "0xAECD08", VA = "0xAECD08")]
	public bool ClickTriggerDown(EnumClient.eHandPose ePose = EnumClient.eHandPose.Right)
	{
		return default(bool);
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0xAECD4C", Offset = "0xAECD4C", VA = "0xAECD4C")]
	public bool ClickTriggerUp(EnumClient.eHandPose ePose = EnumClient.eHandPose.Right)
	{
		return default(bool);
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0xAECD90", Offset = "0xAECD90", VA = "0xAECD90")]
	public Vector3 GetControllerPosition(EnumClient.eHandPose ePose = EnumClient.eHandPose.Right)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0xAECE30", Offset = "0xAECE30", VA = "0xAECE30")]
	public Vector3 GetControllerWorldPosition(EnumClient.eHandPose ePose = EnumClient.eHandPose.Right)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0xAECED0", Offset = "0xAECED0", VA = "0xAECED0")]
	public Quaternion GetControllerRotation(EnumClient.eHandPose ePose = EnumClient.eHandPose.Right)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0xAECF70", Offset = "0xAECF70", VA = "0xAECF70")]
	public Quaternion GetControllerWorldRotation(EnumClient.eHandPose ePose = EnumClient.eHandPose.Right)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0xAED010", Offset = "0xAED010", VA = "0xAED010")]
	public Quaternion GetControllerWorldRotation_RotateForChar(EnumClient.eHandPose ePose = EnumClient.eHandPose.Right)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0xAED15C", Offset = "0xAED15C", VA = "0xAED15C")]
	public EnumClient.eTouchDirection GetTouchDirection_Updown(Vector2 v2TouchPos)
	{
		return default(EnumClient.eTouchDirection);
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0xAED238", Offset = "0xAED238", VA = "0xAED238")]
	public EnumClient.eTouchDirection GetTouchDirection_LeftRight(Vector2 v2TouchPos)
	{
		return default(EnumClient.eTouchDirection);
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0xAEC7C0", Offset = "0xAEC7C0", VA = "0xAEC7C0")]
	public Vector2 GetTouchPos(EnumClient.eHandPose ePose = EnumClient.eHandPose.Right)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0xAED330", Offset = "0xAED330", VA = "0xAED330")]
	public bool IsControllerConnected()
	{
		return default(bool);
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0xAED230", Offset = "0xAED230", VA = "0xAED230")]
	public bool IsTouching()
	{
		return default(bool);
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0xAED338", Offset = "0xAED338", VA = "0xAED338")]
	public void RestoreController()
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0xAEBDF4", Offset = "0xAEBDF4", VA = "0xAEBDF4")]
	public void Start()
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0xAED430", Offset = "0xAED430", VA = "0xAED430")]
	private void SetDevice()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0xAED560", Offset = "0xAED560", VA = "0xAED560")]
	private void Update_CheckThumbStick()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0xAED5AC", Offset = "0xAED5AC", VA = "0xAED5AC")]
	public bool ClickButtonDown(EnumClient.eHandPose ePose)
	{
		return default(bool);
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0xAEBF44", Offset = "0xAEBF44", VA = "0xAEBF44")]
	public void Update()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0xAED72C", Offset = "0xAED72C", VA = "0xAED72C")]
	public EnumClient.eTouchDirection GetTouchDirection_Updown()
	{
		return default(EnumClient.eTouchDirection);
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0xAED748", Offset = "0xAED748", VA = "0xAED748")]
	public EnumClient.eTouchDirection GetTouchDirection_LeftRight()
	{
		return default(EnumClient.eTouchDirection);
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0xAED75C", Offset = "0xAED75C", VA = "0xAED75C")]
	public float GetVelocityManitude(EnumClient.eHandPose ePose)
	{
		return default(float);
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0xAED858", Offset = "0xAED858", VA = "0xAED858")]
	public bool GetHandTrigger(EnumClient.eHandPose ePose = EnumClient.eHandPose.Right)
	{
		return default(bool);
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0xAED89C", Offset = "0xAED89C", VA = "0xAED89C")]
	public bool GetHandTriggerUp(EnumClient.eHandPose ePose = EnumClient.eHandPose.Right)
	{
		return default(bool);
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0xAED8E0", Offset = "0xAED8E0", VA = "0xAED8E0")]
	public bool GetHandTriggerDown(EnumClient.eHandPose ePose = EnumClient.eHandPose.Right)
	{
		return default(bool);
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0xAED924", Offset = "0xAED924", VA = "0xAED924")]
	public bool IsUIClickDown(EnumClient.eHandPose ePose)
	{
		return default(bool);
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0xAED990", Offset = "0xAED990", VA = "0xAED990")]
	public bool GetClickButtonA()
	{
		return default(bool);
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0xAED9B8", Offset = "0xAED9B8", VA = "0xAED9B8")]
	public bool GetClickButtonDownA()
	{
		return default(bool);
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0xAED9E0", Offset = "0xAED9E0", VA = "0xAED9E0")]
	public bool GetClickButtonDownY()
	{
		return default(bool);
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0xAEDA0C", Offset = "0xAEDA0C", VA = "0xAEDA0C")]
	public bool IsUIClickUp(EnumClient.eHandPose ePose)
	{
		return default(bool);
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0xAEDA78", Offset = "0xAEDA78", VA = "0xAEDA78")]
	public bool ClickAnyKeyDown()
	{
		return default(bool);
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0xAEDAEC", Offset = "0xAEDAEC", VA = "0xAEDAEC")]
	public Vector3 GetControllerVelocity(EnumClient.eHandPose ePose)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0xAEDBC8", Offset = "0xAEDBC8", VA = "0xAEDBC8")]
	public bool IsClickDown(eControllerButton button)
	{
		return default(bool);
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0xAEDBF8", Offset = "0xAEDBF8", VA = "0xAEDBF8")]
	public bool IsClickUp(eControllerButton button)
	{
		return default(bool);
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0xAED5C0", Offset = "0xAED5C0", VA = "0xAED5C0")]
	public void UpdateInput()
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0xAEDC28", Offset = "0xAEDC28", VA = "0xAEDC28")]
	public InputFeatureUsage<bool> GetUsage(eControllerButton button, out bool bRight)
	{
		return default(InputFeatureUsage<bool>);
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0xAEC484", Offset = "0xAEC484", VA = "0xAEC484")]
	public Vector3 GetLocalControllerVelocity(EnumClient.eHandPose ePose = EnumClient.eHandPose.Right)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0xAEDDB0", Offset = "0xAEDDB0", VA = "0xAEDDB0")]
	public Quaternion GetLocalControllerRotation(EnumClient.eHandPose ePose = EnumClient.eHandPose.Right)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0xAEC3A8", Offset = "0xAEC3A8", VA = "0xAEC3A8")]
	public Vector3 GetLocalControllerAngularVelocity(EnumClient.eHandPose ePose = EnumClient.eHandPose.Right)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x200004F")]
public class EffectManager : DontDestroy<EffectManager>
{
	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject MagnetEffect;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject GoalEffect;

	[Token(Token = "0x6000190")]
	[Address(RVA = "0xAEDDBC", Offset = "0xAEDDBC", VA = "0xAEDDBC")]
	public void OnEffect(string skillname, Vector3 target, Quaternion rotation, float despawnTime, bool isparents = false)
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0xAEE1B4", Offset = "0xAEE1B4", VA = "0xAEE1B4")]
	public void OnMagnetEffect(string EffectName, Transform ballTransform, Quaternion rotation)
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0xAEE308", Offset = "0xAEE308", VA = "0xAEE308")]
	public void MagnetOff()
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0xAEE3F4", Offset = "0xAEE3F4", VA = "0xAEE3F4")]
	public void OnGoalEffect(string skillname, Vector3 target, Quaternion rotation)
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0xAEE4E4", Offset = "0xAEE4E4", VA = "0xAEE4E4")]
	public void OffGoalEffect()
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0xAEE5D0", Offset = "0xAEE5D0", VA = "0xAEE5D0")]
	public EffectManager()
	{
	}
}
[Token(Token = "0x2000050")]
public class FieldManager : Singleton<FieldManager>
{
	[Token(Token = "0x2000051")]
	public class StageTileInfo
	{
		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<TableStageTile.DetailedEachTileData> m_listTileInfo;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<TableStageObject.StageObjectsDetails> m_listObjectInfo;

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xAEEDBC", Offset = "0xAEEDBC", VA = "0xAEEDBC")]
		public StageTileInfo()
		{
		}
	}

	[Token(Token = "0x2000052")]
	public class StageTileObj_Info3D
	{
		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject m_gTile;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TableTileInfo.TableTileData m_curTileData;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<StageObjectData> m_listStageObject;

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xAF0180", Offset = "0xAF0180", VA = "0xAF0180")]
		public StageTileObj_Info3D()
		{
		}
	}

	[Token(Token = "0x2000053")]
	public class StageObjectData
	{
		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject m_gStageObject;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TableObjectInfo.TableObjectData m_ObjectInfo;

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xAF0F98", Offset = "0xAF0F98", VA = "0xAF0F98")]
		public StageObjectData()
		{
		}
	}

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<List<Dictionary<int, StageTileObj_Info3D>>> m_3D_StageInfo;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<List<StageTileInfo>> m_dicStageTile;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 offset;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Vector3 m_v3StartPosition;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject Map;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject m_gPlayerBall;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private MeshCombineManager m_FinishHoleMeshCombine;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int m_nSlopeCount;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject m_gSlopeMap;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string m_strSlopeMapCount;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GameObject m_tempTileMap;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private string m_strTileMapCount;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int m_nTileGroupingCount;

	[Token(Token = "0x6000196")]
	[Address(RVA = "0xAEE618", Offset = "0xAEE618", VA = "0xAEE618")]
	public TableStageTile.DetailedEachTileData GetCurTileData(StageTileInfo stageTile, Vector3 ballPosition)
	{
		return null;
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0xAEE934", Offset = "0xAEE934", VA = "0xAEE934")]
	public TableStageTile.DetailedEachTileData GetCurTileDataForUnderTile(StageTileInfo stageTile, Vector3 ballPosition)
	{
		return null;
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0xAEEC8C", Offset = "0xAEEC8C", VA = "0xAEEC8C")]
	public StageTileInfo GetCurrectStageTileInfo(float BallXpos, float BallZpos)
	{
		return null;
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0xAE787C", Offset = "0xAE787C", VA = "0xAE787C")]
	public void Set_dicSTageTile(int index, List<TableStageTile.DetailedEachTileData> tileInfo)
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0xAE73CC", Offset = "0xAE73CC", VA = "0xAE73CC")]
	public void AddDummyInfo(int index)
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0xAEEE44", Offset = "0xAEEE44", VA = "0xAEEE44")]
	public void AddStageObjectInfo(int key, int index, List<TableStageObject.StageObjectsDetails> ListObjInfo)
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0xAEEEE0", Offset = "0xAEEEE0", VA = "0xAEEEE0")]
	public void ClearDictionary()
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0xAEEF88", Offset = "0xAEEF88", VA = "0xAEEF88")]
	public void Load_Field()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0xAF003C", Offset = "0xAF003C", VA = "0xAF003C")]
	private void ResetTileMapData()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0xAEF1FC", Offset = "0xAEF1FC", VA = "0xAEF1FC")]
	public void Setting_Field(StageTileInfo tileInfo)
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0xAF0F40", Offset = "0xAF0F40", VA = "0xAF0F40")]
	public void ResetOffset()
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0xAF0188", Offset = "0xAF0188", VA = "0xAF0188")]
	public void ObjectSetting(StageTileInfo tileInfo)
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0xAF1118", Offset = "0xAF1118", VA = "0xAF1118")]
	private void ObjectFunctionSetting(TableObjectInfo.TableObjectData TableObjectInfo, GameObject StageObject, TableStageObject.StageObjectsDetails StageObjectInfo)
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0xAF12A4", Offset = "0xAF12A4", VA = "0xAF12A4")]
	private void ObjectFunction(string function, TableObjectInfo.FunctionData ObjFunctionInfo, GameObject StageObject, TableObjectInfo.TableObjectData TableObjectInfo, TableStageObject.StageObjectsDetails StageObjectInfo)
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0xAF00C0", Offset = "0xAF00C0", VA = "0xAF00C0")]
	private void TileRotationSetting(int rotate, GameObject Tile)
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0xAF0FA0", Offset = "0xAF0FA0", VA = "0xAF0FA0")]
	public StageTileObj_Info3D GetStageObjectTileInfoFromHT(int x, int z, int HT)
	{
		return null;
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0xAF1F58", Offset = "0xAF1F58", VA = "0xAF1F58")]
	public FieldManager()
	{
	}
}
[Token(Token = "0x2000054")]
public class HapticHelper : DontDestroy<HapticHelper>
{
	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float _Hit_Ball_F;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float _Hit_Ball_A;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float _Hit_Ball_T;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float _Hit_WoodFence_F;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float _Hit_WoodFence_A;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float _Hit_WoodFence_T;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float _Goalin_F;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float _Goalin_A;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float _Goalin_T;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float Goalin_S_A;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float Goalin_S_T;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float Goalin_A_A;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float Goalin_A_T;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float Goalin_B_A;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float Goalin_B_T;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float Goalin_C_A;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float Goalin_C_T;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float Goalin_D_A;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float Goalin_D_T;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float Star_Low_A;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float Star_Low_T;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float Star_High_A;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float Star_High_T;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float Grab_A;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float Grab_T;

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0xAF20C0", Offset = "0xAF20C0", VA = "0xAF20C0")]
	public HapticHelper()
	{
	}
}
[Token(Token = "0x2000055")]
public class LogPacketManager : DontDestroy<LogPacketManager>
{
	[Token(Token = "0x2000056")]
	public class LogKey
	{
		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string DateTime;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string AuthKey;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int Stage;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int ClearTime;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int StarCount;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int Hit;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string Chapter1;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string Chapter2;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string Chapter3;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string Chapter4;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int PlayTime;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string Store;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string HMD;

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xAF234C", Offset = "0xAF234C", VA = "0xAF234C")]
		public LogKey()
		{
		}
	}

	[Token(Token = "0x2000057")]
	public class PuttzleLog
	{
		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<LogKey> PuttzzleLog;

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xAF2F58", Offset = "0xAF2F58", VA = "0xAF2F58")]
		public PuttzleLog()
		{
		}
	}

	[Token(Token = "0x2000058")]
	public class VersionCheck
	{
		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float version;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int platform;

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xAF2E3C", Offset = "0xAF2E3C", VA = "0xAF2E3C")]
		public VersionCheck()
		{
		}
	}

	[Token(Token = "0x2000059")]
	public enum ePlatform
	{
		[Token(Token = "0x40001B4")]
		Steam,
		[Token(Token = "0x40001B5")]
		Pico,
		[Token(Token = "0x40001B6")]
		Oculus,
		[Token(Token = "0x40001B7")]
		Vive
	}

	[Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public HttpWebRequest webRequest;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string responseText;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isDone;

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xAF2FE0", Offset = "0xAF2FE0", VA = "0xAF2FE0")]
		public <>c__DisplayClass13_0()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xAF2FE8", Offset = "0xAF2FE8", VA = "0xAF2FE8")]
		internal void <SendRequest>b__0(IAsyncResult iarres)
		{
		}
	}

	[Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class <SendRequest>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string strUrl;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string strPost;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private <>c__DisplayClass13_0 <>8__1;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<string> actionResponse;

		[Token(Token = "0x1700000F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0xAF3754", Offset = "0xAF3754", VA = "0xAF3754", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0xAF379C", Offset = "0xAF379C", VA = "0xAF379C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xAF29E0", Offset = "0xAF29E0", VA = "0xAF29E0")]
		[DebuggerHidden]
		public <SendRequest>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xAF33EC", Offset = "0xAF33EC", VA = "0xAF33EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xAF33F0", Offset = "0xAF33F0", VA = "0xAF33F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xAF375C", Offset = "0xAF375C", VA = "0xAF375C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private PuttzleLog puttzzleLog;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private LogKey m_RecycleLog;

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0xAF2148", Offset = "0xAF2148", VA = "0xAF2148")]
	private void Update()
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0xAF214C", Offset = "0xAF214C", VA = "0xAF214C")]
	public void Set_Data(int stageNumber)
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0xAF2414", Offset = "0xAF2414", VA = "0xAF2414")]
	public void Set_Data()
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0xAF2738", Offset = "0xAF2738", VA = "0xAF2738")]
	public void Save_Data_ToList(int StarCount)
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0xAF26A8", Offset = "0xAF26A8", VA = "0xAF26A8")]
	private string GetMedalStr(int star)
	{
		return null;
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0xAF27F4", Offset = "0xAF27F4", VA = "0xAF27F4")]
	public void SendLog()
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0xAF2988", Offset = "0xAF2988", VA = "0xAF2988")]
	private void ResponseSendLog(string strResponse)
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0xAF28E4", Offset = "0xAF28E4", VA = "0xAF28E4")]
	[IteratorStateMachine(typeof(<SendRequest>d__13))]
	public IEnumerator SendRequest(string strUrl, string strPost, Action<string> actionResponse)
	{
		return null;
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0xAF2A08", Offset = "0xAF2A08", VA = "0xAF2A08")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0xAF2B5C", Offset = "0xAF2B5C", VA = "0xAF2B5C")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0xAF2CC0", Offset = "0xAF2CC0", VA = "0xAF2CC0")]
	public void SendVersionCheck()
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0xAF2E44", Offset = "0xAF2E44", VA = "0xAF2E44")]
	public void ResponseVersionCheck(string responseText)
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0xAF2ED4", Offset = "0xAF2ED4", VA = "0xAF2ED4")]
	public LogPacketManager()
	{
	}
}
[Token(Token = "0x200005C")]
[AddComponentMenu("Simple MeshCollider Combine")]
public class MeshCombineManager : MonoBehaviour
{
	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public GameObject[] combinedGameOjects;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public string meshName;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public GameObject boxMeshHolder;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Header("Combine Settings")]
	[Tooltip("GameObjects in this list will not be combined.")]
	public List<MeshCollider> IgnoreMeshColliders;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Header("Optimize Settings")]
	[Tooltip("Distance between vertices to merge.")]
	[Range(0.01f, 2f)]
	public float mergeVerticesThreshold;

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0xAF37A4", Offset = "0xAF37A4", VA = "0xAF37A4")]
	public void ToggleMeshCollider(bool e)
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0xAF38D4", Offset = "0xAF38D4", VA = "0xAF38D4")]
	public bool checkIgnoreList(MeshCollider go)
	{
		return default(bool);
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0xAF3A50", Offset = "0xAF3A50", VA = "0xAF3A50")]
	public MeshCollider[] FindEnabledMeshes()
	{
		return null;
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0xAF3AA8", Offset = "0xAF3AA8", VA = "0xAF3AA8")]
	public BoxCollider[] FindBoxColliders()
	{
		return null;
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0xAF3B00", Offset = "0xAF3B00", VA = "0xAF3B00")]
	public Mesh CreateBoxMesh()
	{
		return null;
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0xAF3E08", Offset = "0xAF3E08", VA = "0xAF3E08")]
	public void UndoConvertBoxColliders()
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0xAF3EBC", Offset = "0xAF3EBC", VA = "0xAF3EBC")]
	public void ConvertBoxColliders()
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0xAF4254", Offset = "0xAF4254", VA = "0xAF4254")]
	public void CombineMeshes()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0xAF4AB4", Offset = "0xAF4AB4", VA = "0xAF4AB4")]
	private void MergeVertices(Mesh mesh, float threshold)
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0xAF4FA0", Offset = "0xAF4FA0", VA = "0xAF4FA0")]
	public int Contains(ArrayList l, Material n)
	{
		return default(int);
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0xAF50D8", Offset = "0xAF50D8", VA = "0xAF50D8")]
	public MeshCombineManager()
	{
	}
}
[Serializable]
[Token(Token = "0x200005D")]
public class ObjectPool
{
	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject prefab;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int size;

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0xAF5198", Offset = "0xAF5198", VA = "0xAF5198")]
	public ObjectPool()
	{
	}
}
[Token(Token = "0x200005E")]
public class ObjectPoolingManager : DontDestroy<ObjectPoolingManager>
{
	[Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class <_despawn>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float timer;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject poolObject;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ObjectPoolingManager <>4__this;

		[Token(Token = "0x17000011")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0xAF59AC", Offset = "0xAF59AC", VA = "0xAF59AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0xAF59F4", Offset = "0xAF59F4", VA = "0xAF59F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xAF567C", Offset = "0xAF567C", VA = "0xAF567C")]
		[DebuggerHidden]
		public <_despawn>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xAF56EC", Offset = "0xAF56EC", VA = "0xAF56EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xAF56F0", Offset = "0xAF56F0", VA = "0xAF56F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xAF59B4", Offset = "0xAF59B4", VA = "0xAF59B4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<ObjectPool> ObjectPoolList;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<string, Queue<GameObject>> objectPoolDictionary;

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0xAF51A0", Offset = "0xAF51A0", VA = "0xAF51A0", Slot = "4")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0xAF54F0", Offset = "0xAF54F0", VA = "0xAF54F0")]
	private GameObject CreateGameObject(GameObject prefab)
	{
		return null;
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0xAF51A4", Offset = "0xAF51A4", VA = "0xAF51A4")]
	private void Init()
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0xAEDF44", Offset = "0xAEDF44", VA = "0xAEDF44")]
	public GameObject Spawn(string poolName, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0xAF55DC", Offset = "0xAF55DC", VA = "0xAF55DC")]
	[IteratorStateMachine(typeof(<_despawn>d__6))]
	private IEnumerator _despawn(GameObject poolObject, float timer)
	{
		return null;
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0xAEE194", Offset = "0xAEE194", VA = "0xAEE194")]
	public void Despawn(GameObject poolObject, float timer = 0f)
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0xAF56A4", Offset = "0xAF56A4", VA = "0xAF56A4")]
	public ObjectPoolingManager()
	{
	}
}
[Token(Token = "0x2000060")]
public static class PlayerDataBase
{
	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool FxValue;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	public static bool BgmValue;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
	public static bool VibeValue;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
	public static bool isClearQuest202;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static bool Chapter2_Open;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
	public static bool Chapter2_Effect;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
	public static bool Chapter3_Open;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
	public static bool Chapter3_Effect;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static bool Chapter4_Open;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
	public static bool Chapter4_Effect;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static Dictionary<int, List<PlayerStageData>> m_dicPlayerStageDatas;

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0xAF59FC", Offset = "0xAF59FC", VA = "0xAF59FC")]
	public static void SaveStageData()
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0xAF5B10", Offset = "0xAF5B10", VA = "0xAF5B10")]
	public static void LoadStageData()
	{
	}
}
[Serializable]
[Token(Token = "0x2000061")]
public class PlayerStageData
{
	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int m_nStageUnique;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int m_nStarCount;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool m_bisUndo;

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0xAF5DA8", Offset = "0xAF5DA8", VA = "0xAF5DA8")]
	public PlayerStageData()
	{
	}
}
[Token(Token = "0x2000062")]
public class PuttzzleGameData : Singleton<PuttzzleGameData>
{
	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int m_nCurStageUnique;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int m_nCurRemainChance;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int m_nCurChapter;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int m_nCurStageNumber;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int m_nCurStarCount;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int m_nCurChapterStarCount;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int m_nCurStarCount_Log;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float m_fSavedCurSkyBoxExp;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float m_fStartRotate;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool m_bPreventEffect;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	public bool m_bUndoUseCheck;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
	public bool m_bDarkness;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TableStageInfo.StageData m_CurrentStageData;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Dictionary<int, Material> m_dicSkyBoxs;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Dictionary<int, string> m_dicBGMs;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Dictionary<int, int> m_dicChapterMedal;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Sprite m_spBronzeMedal;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Sprite m_spSilverMedal;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Sprite m_spGoldMedal;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Sprite m_spDiaMedal;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Sprite m_spLogoCN;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float m_fPuttzzleStartTime;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float m_fPuttzzleEndTime;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public TMP_FontAsset m_fontA;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public TMP_FontAsset m_fontB_China;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public TMP_FontAsset m_fontB_Japan;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public EnumClient.eLANGUAGE_TYPE m_CurLanguageType;

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0xAF5DB0", Offset = "0xAF5DB0", VA = "0xAF5DB0")]
	public void init()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0xAF6000", Offset = "0xAF6000", VA = "0xAF6000")]
	public void ResetData()
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0xAF6030", Offset = "0xAF6030", VA = "0xAF6030")]
	public void SetSkyboxs()
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0xAF6250", Offset = "0xAF6250", VA = "0xAF6250")]
	public void SetBGMs()
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0xAF5EF4", Offset = "0xAF5EF4", VA = "0xAF5EF4")]
	public void SetMedalSprite()
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0xAF6340", Offset = "0xAF6340", VA = "0xAF6340")]
	public void SetChapterMedalDic()
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0xAF63E0", Offset = "0xAF63E0", VA = "0xAF63E0")]
	public void SkyBoxLightSetting(int Chapter)
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0xAF653C", Offset = "0xAF653C", VA = "0xAF653C")]
	public int GetPlayerAllStar()
	{
		return default(int);
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0xAF66A4", Offset = "0xAF66A4", VA = "0xAF66A4")]
	public PuttzzleGameData()
	{
	}
}
[Token(Token = "0x2000063")]
public class QuestManager : Singleton<QuestManager>
{
	[Token(Token = "0x60001E9")]
	[Address(RVA = "0xAF67EC", Offset = "0xAF67EC", VA = "0xAF67EC")]
	public QuestManager()
	{
	}
}
[Token(Token = "0x2000064")]
public class SceneHelper : DontDestroy<SceneHelper>
{
	[Token(Token = "0x2000065")]
	public enum eScene
	{
		[Token(Token = "0x40001FD")]
		Start,
		[Token(Token = "0x40001FE")]
		Logo,
		[Token(Token = "0x40001FF")]
		Title,
		[Token(Token = "0x4000200")]
		Field,
		[Token(Token = "0x4000201")]
		GameResult
	}

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private eScene m_currentScene;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private eScene m_priorScene;

	[Token(Token = "0x40001FA")]
	private const eScene FIRST_SCENE = eScene.Start;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool m_bLoadingScene;

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0xAF6834", Offset = "0xAF6834", VA = "0xAF6834", Slot = "5")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0xAF6984", Offset = "0xAF6984", VA = "0xAF6984")]
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0xAF6C28", Offset = "0xAF6C28", VA = "0xAF6C28")]
	public void LoadLevel(eScene state)
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0xAF70DC", Offset = "0xAF70DC", VA = "0xAF70DC")]
	private void MoveScene()
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0xAF7248", Offset = "0xAF7248", VA = "0xAF7248")]
	public void LoadControllerScene()
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0xAF71B0", Offset = "0xAF71B0", VA = "0xAF71B0")]
	private string GetSceneName(eScene eState)
	{
		return null;
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0xAF68E4", Offset = "0xAF68E4", VA = "0xAF68E4")]
	public void SetState(eScene state)
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0xAF72B4", Offset = "0xAF72B4", VA = "0xAF72B4")]
	public eScene GetCurrentScene()
	{
		return default(eScene);
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0xAF6DA8", Offset = "0xAF6DA8", VA = "0xAF6DA8")]
	private void DestroyObjBeforeChange(eScene priorScene)
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0xAF79E8", Offset = "0xAF79E8", VA = "0xAF79E8")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0xAF7A34", Offset = "0xAF7A34", VA = "0xAF7A34")]
	public SceneHelper()
	{
	}
}
[Token(Token = "0x2000066")]
public class SoundBGMManager : DontDestroy<SoundBGMManager>
{
	[Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class <Coroutine_FadeOut>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SoundBGMManager <>4__this;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string nextBGM;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <volume>5__2;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <count>5__3;

		[Token(Token = "0x17000014")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0xAF82B8", Offset = "0xAF82B8", VA = "0xAF82B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0xAF8300", Offset = "0xAF8300", VA = "0xAF8300", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xAF7FB0", Offset = "0xAF7FB0", VA = "0xAF7FB0")]
		[DebuggerHidden]
		public <Coroutine_FadeOut>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xAF8104", Offset = "0xAF8104", VA = "0xAF8104", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xAF8108", Offset = "0xAF8108", VA = "0xAF8108", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xAF82C0", Offset = "0xAF82C0", VA = "0xAF82C0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioSource m_AudioSource;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string m_playName;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool isFading;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	private bool m_bSoundPlay;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	private bool m_bSoundQuiet;

	[Token(Token = "0x4000207")]
	private const float SOUND_QUIET = 0.2f;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<string, AudioClip> m_dicPool;

	[Token(Token = "0x17000013")]
	public bool SoundPlay
	{
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xAF7A7C", Offset = "0xAF7A7C", VA = "0xAF7A7C")]
		set
		{
		}
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0xAF7ACC", Offset = "0xAF7ACC", VA = "0xAF7ACC", Slot = "4")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0xAF7AD8", Offset = "0xAF7AD8", VA = "0xAF7AD8")]
	public void FieldBGMSetting()
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0xAF7BFC", Offset = "0xAF7BFC", VA = "0xAF7BFC")]
	public void Play(string name)
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0xAF7F94", Offset = "0xAF7F94", VA = "0xAF7F94")]
	public bool BGMisPlaying()
	{
		return default(bool);
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0xAF7EC8", Offset = "0xAF7EC8", VA = "0xAF7EC8")]
	public void Stop()
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0xAF7F04", Offset = "0xAF7F04", VA = "0xAF7F04")]
	[IteratorStateMachine(typeof(<Coroutine_FadeOut>d__14))]
	private IEnumerator Coroutine_FadeOut([Optional] string nextBGM)
	{
		return null;
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0xAF7FD8", Offset = "0xAF7FD8", VA = "0xAF7FD8")]
	public void SetSoundQuiet(bool bSet)
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0xAF8020", Offset = "0xAF8020", VA = "0xAF8020")]
	public void SetSoundVolume(float _fVolume)
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0xAF8060", Offset = "0xAF8060", VA = "0xAF8060")]
	public SoundBGMManager()
	{
	}
}
[Token(Token = "0x2000068")]
public class SoundFXManager : DontDestroy<SoundFXManager>
{
	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioSource m_AudioSource;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool m_bSoundPlay;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool m_bSoundQuiet;

	[Token(Token = "0x4000212")]
	private const float SOUND_DEFAULT = 0.38f;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioSource[] m_listAudiosSource;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AudioSource[] m_listLoopFxAudio;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private AudioSource m_AudioSource_ForStop;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Dictionary<string, AudioClip> m_dicPool;

	[Token(Token = "0x17000016")]
	public bool SoundPlay
	{
		[Token(Token = "0x6000205")]
		[Address(RVA = "0xAF8308", Offset = "0xAF8308", VA = "0xAF8308")]
		set
		{
		}
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0xAF83A0", Offset = "0xAF83A0", VA = "0xAF83A0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0xAF8414", Offset = "0xAF8414", VA = "0xAF8414")]
	private void Update()
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0xAF750C", Offset = "0xAF750C", VA = "0xAF750C")]
	public void Play(string strUnique, float SoundSize = 2f)
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0xAF72BC", Offset = "0xAF72BC", VA = "0xAF72BC")]
	public void Stop(string strUnique)
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0xAF8418", Offset = "0xAF8418", VA = "0xAF8418")]
	public void LoopFxSoundPlay(string strUnique, float SoundSize = 2f)
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0xAF87B0", Offset = "0xAF87B0", VA = "0xAF87B0")]
	public void LoopFxSoundStop(string strUnique)
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0xAF78E0", Offset = "0xAF78E0", VA = "0xAF78E0")]
	public void AllLoopFxSoundStop()
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0xAF892C", Offset = "0xAF892C", VA = "0xAF892C")]
	public SoundFXManager()
	{
	}
}
[Token(Token = "0x2000069")]
public class TableManager : DontDestroy<TableManager>
{
	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool isLoaded;

	[Token(Token = "0x17000017")]
	public bool DataLoaded
	{
		[Token(Token = "0x600020E")]
		[Address(RVA = "0xAF89D0", Offset = "0xAF89D0", VA = "0xAF89D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0xAF89D8", Offset = "0xAF89D8", VA = "0xAF89D8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0xAF89DC", Offset = "0xAF89DC", VA = "0xAF89DC")]
	public void Load()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0xAF8B28", Offset = "0xAF8B28", VA = "0xAF8B28")]
	public TableManager()
	{
	}
}
[Token(Token = "0x200006A")]
public class ViberationManager : DontDestroy<ViberationManager>
{
	[Token(Token = "0x4000218")]
	private const float MAX_LIMIT_TIME = 60f;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool m_bMaxHaptic_Left;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool m_bMaxHaptic_True;

	[Token(Token = "0x6000212")]
	[Address(RVA = "0xAF8B70", Offset = "0xAF8B70", VA = "0xAF8B70")]
	public void TriggerVibration(float duration, float amplitued, EnumClient.eHandPose eHandPose)
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0xAF8C5C", Offset = "0xAF8C5C", VA = "0xAF8C5C")]
	public void TriggerVibrationMaxDuration(float amplitued, EnumClient.eHandPose eHandPose)
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0xAF8CA0", Offset = "0xAF8CA0", VA = "0xAF8CA0")]
	public void TriggerVibrationStop()
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0xAF8CA4", Offset = "0xAF8CA4", VA = "0xAF8CA4")]
	public void TriggerAllVibration(float waitTime, float amplitued)
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0xAF8C10", Offset = "0xAF8C10", VA = "0xAF8C10")]
	protected void VibrateController(float duration, float amplitude, EnumClient.eHandPose eHandPose)
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0xAF8D30", Offset = "0xAF8D30", VA = "0xAF8D30")]
	protected void VibrateAllController(float duration, float amplitude)
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0xAF8DA8", Offset = "0xAF8DA8", VA = "0xAF8DA8")]
	private InputDevice GetInputDevicePosition(EnumClient.eHandPose eHandPose = EnumClient.eHandPose.Right)
	{
		return default(InputDevice);
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0xAF8E98", Offset = "0xAF8E98", VA = "0xAF8E98")]
	public ViberationManager()
	{
	}
}
[Token(Token = "0x200006B")]
public class Bomb : StageObjects
{
	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int m_nBombRangeXZ;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int m_nBombRangeHT;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<GameObject> m_ListTarget_BrokenRe_Objects;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<GameObject> m_ListTarget_Broken_Objects;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int m_nThisX;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private int m_nThisZ;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int m_nThisHT;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float m_fBombPower;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string m_strBombEffectSound;

	[Token(Token = "0x600021A")]
	[Address(RVA = "0xAF1E18", Offset = "0xAF1E18", VA = "0xAF1E18")]
	public void init(int thisX, int thisZ, int thisHT, int RangeXZ, int RangeHT, float Power, string SoundName)
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0xAF8EE0", Offset = "0xAF8EE0", VA = "0xAF8EE0")]
	public void BombObjectSetting()
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0xAF8F84", Offset = "0xAF8F84", VA = "0xAF8F84")]
	private List<FieldManager.StageTileObj_Info3D> GetStageTileAndObj()
	{
		return null;
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0xAF9140", Offset = "0xAF9140", VA = "0xAF9140")]
	private void BrokeObjectCheck(FieldManager.StageTileObj_Info3D objInfo)
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0xAF93FC", Offset = "0xAF93FC", VA = "0xAF93FC")]
	public void BombProcess()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0xAF9E28", Offset = "0xAF9E28", VA = "0xAF9E28", Slot = "4")]
	public override void SwitchOn(bool isUndo = false)
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0xAF9C94", Offset = "0xAF9C94", VA = "0xAF9C94")]
	private void BombMeshCombineProcess()
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0xAF9E48", Offset = "0xAF9E48", VA = "0xAF9E48")]
	public Bomb()
	{
	}
}
[Token(Token = "0x200006C")]
public class DummyBall : MonoBehaviour
{
	[Token(Token = "0x200006D")]
	public enum BallLocation
	{
		[Token(Token = "0x4000230")]
		None,
		[Token(Token = "0x4000231")]
		OnGround,
		[Token(Token = "0x4000232")]
		OnSlope,
		[Token(Token = "0x4000233")]
		OnFly
	}

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private BallLocation m_eBallLocation;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Rigidbody m_BallRig;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 m_v3DummyBallVelocity;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float m_fConst_RESISTANCE;

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float m_fAirResistance;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float m_fGravity;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float m_fSlopeGravity;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool m_bBallHit;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Stack<Vector3> m_StackDummyPosition;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float m_ftemptemp;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool isJump;

	[Token(Token = "0x6000222")]
	[Address(RVA = "0xAF9F00", Offset = "0xAF9F00", VA = "0xAF9F00")]
	public void init()
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0xAF9FD8", Offset = "0xAF9FD8", VA = "0xAF9FD8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0xAFA030", Offset = "0xAFA030", VA = "0xAFA030")]
	private void Update()
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0xAFA584", Offset = "0xAFA584", VA = "0xAFA584")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0xAFA250", Offset = "0xAFA250", VA = "0xAFA250")]
	private void GroundCheck()
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0xAFA728", Offset = "0xAFA728", VA = "0xAFA728")]
	private void FlyCheck()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0xAFA398", Offset = "0xAFA398", VA = "0xAFA398")]
	private void FallingCheck()
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0xAFA430", Offset = "0xAFA430", VA = "0xAFA430")]
	private void GravityProcess()
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0xAFA68C", Offset = "0xAFA68C", VA = "0xAFA68C")]
	private void ReduceVelocity()
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0xAFA3F8", Offset = "0xAFA3F8", VA = "0xAFA3F8")]
	private void JumpCheck()
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0xAFA86C", Offset = "0xAFA86C", VA = "0xAFA86C")]
	public void JumpBall(float ForceY, float ForceZ, Vector3 JumpForward, bool isAim)
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0xAFA9AC", Offset = "0xAFA9AC", VA = "0xAFA9AC")]
	private (Vector2, Vector2) calculateBall2BallCollision(Vector2 v1, Vector2 v2, Vector2 c1, Vector2 c2, float e = 1f)
	{
		return default((Vector2, Vector2));
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0xAFAFD4", Offset = "0xAFAFD4", VA = "0xAFAFD4")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0xAFB84C", Offset = "0xAFB84C", VA = "0xAFB84C")]
	public DummyBall()
	{
	}
}
[Token(Token = "0x200006E")]
public class Fan : StageObjects
{
	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private BoxCollider FanRangeCollider;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float m_fRange;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float m_fPower;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float m_fSoundRange;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string m_strObjSoundName;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string m_strEffectSoundName;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject m_gFanEffect;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Animator m_aniFan;

	[Token(Token = "0x6000230")]
	[Address(RVA = "0xAFB920", Offset = "0xAFB920", VA = "0xAFB920")]
	public void init(float Range, float Power, float SoundRange, string EffectSound, string ObjSound)
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0xAFBB60", Offset = "0xAFBB60", VA = "0xAFBB60", Slot = "4")]
	public override void SwitchOn(bool isUndo = false)
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0xAFBC90", Offset = "0xAFBC90", VA = "0xAFBC90", Slot = "5")]
	public override void SwitchOff(bool isUndo = false)
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0xAFBDBC", Offset = "0xAFBDBC", VA = "0xAFBDBC")]
	public Fan()
	{
	}
}
[Token(Token = "0x200006F")]
public class Fence : StageObjects
{
	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float FenceBounce;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string WallSoundName;

	[Token(Token = "0x6000234")]
	[Address(RVA = "0xAFBDCC", Offset = "0xAFBDCC", VA = "0xAFBDCC")]
	public void initFenceBounce(float resist, string SoundName)
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0xAFBDD8", Offset = "0xAFBDD8", VA = "0xAFBDD8")]
	public Fence()
	{
	}
}
[Token(Token = "0x2000070")]
public class Jump : StageObjects
{
	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float m_fForceY;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float m_fForceZ;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string m_strSoundName;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string m_strobjSoundName;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool m_bisAim;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool isJump;

	[Token(Token = "0x6000236")]
	[Address(RVA = "0xAFBDE0", Offset = "0xAFBDE0", VA = "0xAFBDE0")]
	public void init(int isAim, float ForceZ, float ForceY, string SoundName, string objsoundname)
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0xAFBE2C", Offset = "0xAFBE2C", VA = "0xAFBE2C")]
	public Jump()
	{
	}
}
[Token(Token = "0x2000071")]
public class Magnet : StageObjects
{
	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float m_fMagnetForce;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float m_fMagnetRange;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string m_strSoundName;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string m_strObjSoundName;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector3 m_v3Direction;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public bool m_bIsPush;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	public bool m_bDontUseMagnet;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Animator m_Animator;

	[Token(Token = "0x6000238")]
	[Address(RVA = "0xAFBE34", Offset = "0xAFBE34", VA = "0xAFBE34")]
	public void init(float Range, float magnetPower, string soundName, bool isPush, string objsoundname)
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0xAFBEE0", Offset = "0xAFBEE0", VA = "0xAFBEE0", Slot = "4")]
	public override void SwitchOn(bool isUndo = false)
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0xAFBF0C", Offset = "0xAFBF0C", VA = "0xAFBF0C", Slot = "5")]
	public override void SwitchOff(bool isUndo = false)
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0xAFBF38", Offset = "0xAFBF38", VA = "0xAFBF38")]
	public Magnet()
	{
	}
}
[Token(Token = "0x2000072")]
public class MovingTile : StageObjects
{
	[Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class <MovingObjectOnce>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MovingTile <>4__this;

		[Token(Token = "0x17000018")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0xAFC620", Offset = "0xAFC620", VA = "0xAFC620", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000247")]
			[Address(RVA = "0xAFC668", Offset = "0xAFC668", VA = "0xAFC668", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xAFC30C", Offset = "0xAFC30C", VA = "0xAFC30C")]
		[DebuggerHidden]
		public <MovingObjectOnce>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xAFC3EC", Offset = "0xAFC3EC", VA = "0xAFC3EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xAFC3F0", Offset = "0xAFC3F0", VA = "0xAFC3F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xAFC628", Offset = "0xAFC628", VA = "0xAFC628", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	private bool m_bisMovingV;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
	private bool m_bisLoop;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float m_fDistance;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float m_fSpeed;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 m_v3StartPosition;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Vector3 m_v3DepartPosition;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool m_bAlreadyMoving;

	[Token(Token = "0x600023C")]
	[Address(RVA = "0xAFBF98", Offset = "0xAFBF98", VA = "0xAFBF98")]
	public void init(bool isMovingV, int isLoop, float distance, float speed)
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0xAFC098", Offset = "0xAFC098", VA = "0xAFC098")]
	public void MovingObjectLoop()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0xAFC298", Offset = "0xAFC298", VA = "0xAFC298")]
	[IteratorStateMachine(typeof(<MovingObjectOnce>d__9))]
	public IEnumerator MovingObjectOnce()
	{
		return null;
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0xAFC334", Offset = "0xAFC334", VA = "0xAFC334")]
	public bool GetisLoop()
	{
		return default(bool);
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0xAFC33C", Offset = "0xAFC33C", VA = "0xAFC33C", Slot = "4")]
	public override void SwitchOn(bool isUndo = false)
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0xAFC378", Offset = "0xAFC378", VA = "0xAFC378")]
	public MovingTile()
	{
	}
}
[Token(Token = "0x2000074")]
public class Portal : StageObjects
{
	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int m_nPairingNumber;

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string m_strPortalSound;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string m_strEffectSound;

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float m_fSoundRange;

	[Token(Token = "0x6000248")]
	[Address(RVA = "0xAFC670", Offset = "0xAFC670", VA = "0xAFC670")]
	public void init(int Number, float Range, string PtSound, string EffectSound)
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0xAFC6E4", Offset = "0xAFC6E4", VA = "0xAFC6E4", Slot = "4")]
	public override void SwitchOn(bool isUndo = false)
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0xAFC718", Offset = "0xAFC718", VA = "0xAFC718", Slot = "5")]
	public override void SwitchOff(bool isUndo = false)
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0xAFC74C", Offset = "0xAFC74C", VA = "0xAFC74C")]
	public Portal()
	{
	}
}
[Token(Token = "0x2000075")]
public class Raise : StageObjects
{
	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float m_fAcceleration;

	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float m_fMaxSpeed;

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float m_fReducePercent;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string m_strEffectSound;

	[Token(Token = "0x600024C")]
	[Address(RVA = "0xAFC754", Offset = "0xAFC754", VA = "0xAFC754")]
	public void init(float acc, float speed, float reduce, string sound)
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0xAFC764", Offset = "0xAFC764", VA = "0xAFC764")]
	public Raise()
	{
	}
}
[Token(Token = "0x2000076")]
public class StageObjects : MonoBehaviour
{
	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isBroken;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool isBrokenRe;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float BrokenValue;

	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float BrokenDecreaseSpeed;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string BrokenSoundName;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int m_nSwitchPairing;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool m_bSwitchOn;

	[Token(Token = "0x600024E")]
	[Address(RVA = "0xAFC76C", Offset = "0xAFC76C", VA = "0xAFC76C")]
	public void initBrokenValue(float PowerValue, float DecreaseValue, string SoundName)
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0xAFBBA0", Offset = "0xAFBBA0", VA = "0xAFBBA0", Slot = "4")]
	public virtual void SwitchOn(bool isUndo = false)
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0xAFBCD0", Offset = "0xAFBCD0", VA = "0xAFBCD0", Slot = "5")]
	public virtual void SwitchOff(bool isUndo = false)
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0xAFBDC4", Offset = "0xAFBDC4", VA = "0xAFBDC4")]
	public StageObjects()
	{
	}
}
[Token(Token = "0x2000077")]
public class Switch : StageObjects
{
	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	public bool m_bAlreadyOn;

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
	public bool m_bAlreadyOnTrigger;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
	public bool m_bisLoop;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string m_strSwitchSound;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<StageObjects> m_PairingObjects;

	[Token(Token = "0x6000252")]
	[Address(RVA = "0xAFC778", Offset = "0xAFC778", VA = "0xAFC778")]
	public void init(int isLoop, string Sound)
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0xAFC7A0", Offset = "0xAFC7A0", VA = "0xAFC7A0")]
	public void SettingPairingObject()
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0xAFC92C", Offset = "0xAFC92C", VA = "0xAFC92C")]
	public List<StageObjects> GetSwitchPairingObjects()
	{
		return null;
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0xAFC934", Offset = "0xAFC934", VA = "0xAFC934", Slot = "4")]
	public override void SwitchOn(bool isUndo = false)
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0xAFC9E0", Offset = "0xAFC9E0", VA = "0xAFC9E0", Slot = "5")]
	public override void SwitchOff(bool isUndo = false)
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0xAFCA8C", Offset = "0xAFCA8C", VA = "0xAFCA8C")]
	public Switch()
	{
	}
}
[Token(Token = "0x2000078")]
public class BallMoveCheck : MonoBehaviour
{
	[Token(Token = "0x2000079")]
	public enum BallLocation
	{
		[Token(Token = "0x4000292")]
		None,
		[Token(Token = "0x4000293")]
		OnGround,
		[Token(Token = "0x4000294")]
		OnSlope,
		[Token(Token = "0x4000295")]
		OnFly
	}

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private FieldManager.StageTileInfo m_CurrentStageTileInfo;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private TableTileInfo.TableTileData m_CurrentTileData;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private TableStageTile.DetailedEachTileData m_curDetailedTileData;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float m_fReinforce;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float m_fGravity;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float m_fBallReviseResistance;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float m_fSlopeGravity;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public BallLocation m_eBallLocation;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool m_bSlopeFlying;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
	private bool m_bReduceStart;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float m_fReduceTime;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float m_fReviseResistTime;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 m_v3PriorSoundPosition;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool m_bOnGroundSound;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	[HideInInspector]
	public bool PreventFromUnexpectedHit;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
	[HideInInspector]
	public bool m_bIsOnMagnet;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
	[HideInInspector]
	public bool m_bIsOnFan;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool isJump;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector3 m_v3NormalVec;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool m_bDummyBallHit;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
	private bool m_bBallHit;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
	private bool m_bStartPlayerChange;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float m_fPlayerPositionChangeDelay;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private GameObject m_SavedGlassTile;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float m_fBallForceStopCheckTimer;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Vector3 m_v3BallForceStopCheckVector;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[HideInInspector]
	public MeshCombineManager m_curMeshCombine;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[HideInInspector]
	public float m_fResist;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	[HideInInspector]
	public bool StartFlying;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	public float m_fFallingDistance;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[HideInInspector]
	public Rigidbody m_BallRig;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[HideInInspector]
	public Vector3 m_v3CurrentVelocity;

	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	[HideInInspector]
	public Vector3 m_v3DepartPosition;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[HideInInspector]
	public bool m_bBallFalling;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
	[HideInInspector]
	public bool m_bisRaised;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCA")]
	private bool m_bFirstHit;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCB")]
	private bool m_bUndoTextOn;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private bool BallChecker;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
	private bool m_bForcedCamera;

	[Token(Token = "0x6000258")]
	[Address(RVA = "0xAFCB14", Offset = "0xAFCB14", VA = "0xAFCB14")]
	private void Start()
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0xAFCB80", Offset = "0xAFCB80", VA = "0xAFCB80")]
	public void onUpdate()
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0xAFDA70", Offset = "0xAFDA70", VA = "0xAFDA70")]
	public void onFixedUpdate()
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0xAFE154", Offset = "0xAFE154", VA = "0xAFE154")]
	public void Hit()
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0xAFD074", Offset = "0xAFD074", VA = "0xAFD074")]
	private void FallingCheck()
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0xAFCCB4", Offset = "0xAFCCB4", VA = "0xAFCCB4")]
	private void GroundCheck()
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0xAFE838", Offset = "0xAFE838", VA = "0xAFE838")]
	private void FlyCheck()
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0xAFDEDC", Offset = "0xAFDEDC", VA = "0xAFDEDC")]
	private void ReduceVelocity()
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0xAFDB78", Offset = "0xAFDB78", VA = "0xAFDB78")]
	private void GravityProcess()
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0xAFD66C", Offset = "0xAFD66C", VA = "0xAFD66C")]
	private void BallForceStopCheck()
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0xAFEC98", Offset = "0xAFEC98", VA = "0xAFEC98")]
	public bool isBallHit()
	{
		return default(bool);
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0xAFD2DC", Offset = "0xAFD2DC", VA = "0xAFD2DC")]
	private void GroundSoundProcess()
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0xAFECA0", Offset = "0xAFECA0", VA = "0xAFECA0")]
	public void MagnetForce(float Power, Vector3 direction)
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0xAFD468", Offset = "0xAFD468", VA = "0xAFD468")]
	private void FallingOnGround()
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0xAFD950", Offset = "0xAFD950", VA = "0xAFD950")]
	private void StopCheck()
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0xAFEC2C", Offset = "0xAFEC2C", VA = "0xAFEC2C")]
	private void BallForceStop()
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0xAFEF7C", Offset = "0xAFEF7C", VA = "0xAFEF7C")]
	private void PostProcessingBrokenItems()
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0xAFD500", Offset = "0xAFD500", VA = "0xAFD500")]
	private void PlayerPositionChanges()
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0xAFF924", Offset = "0xAFF924", VA = "0xAFF924")]
	public void DummyBallHit()
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0xAFF930", Offset = "0xAFF930", VA = "0xAFF930")]
	public void StopMagnet()
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0xAFFA30", Offset = "0xAFFA30", VA = "0xAFFA30")]
	public void JumpBall(float ForceY, float ForceZ, Vector3 JumpForward, bool isAim)
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0xAFFC68", Offset = "0xAFFC68", VA = "0xAFFC68")]
	public Vector3 GetCurrentVelocity()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0xAFFC74", Offset = "0xAFFC74", VA = "0xAFFC74")]
	public void ResetResist()
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0xAFEDA0", Offset = "0xAFEDA0", VA = "0xAFEDA0")]
	public void StopBall()
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0xAFE5B4", Offset = "0xAFE5B4", VA = "0xAFE5B4")]
	private float CalcHammerSpeed()
	{
		return default(float);
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0xAFE6A4", Offset = "0xAFE6A4", VA = "0xAFE6A4")]
	private void ValueChangeProcessByHit()
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0xAFE714", Offset = "0xAFE714", VA = "0xAFE714")]
	private float CalcImpactPower(float HammerSpeed)
	{
		return default(float);
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0xAFEB64", Offset = "0xAFEB64", VA = "0xAFEB64")]
	private Vector3 AdjustVelocityToSlope(Vector3 velocity)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0xAFFDD0", Offset = "0xAFFDD0", VA = "0xAFFDD0")]
	public bool ReadyToHit()
	{
		return default(bool);
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0xAFEB3C", Offset = "0xAFEB3C", VA = "0xAFEB3C")]
	private float GetCurTileResistance(int CurTileLevel)
	{
		return default(float);
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0xAFEC04", Offset = "0xAFEC04", VA = "0xAFEC04")]
	private float GetCurTileSlopeResitance(int CurTileLevel)
	{
		return default(float);
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0xAFFDF0", Offset = "0xAFFDF0", VA = "0xAFFDF0")]
	public TableTileInfo.TableTileData GetCurTileData()
	{
		return null;
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0xAFD7B4", Offset = "0xAFD7B4", VA = "0xAFD7B4")]
	private void PlayerViewCheck()
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0xAFFEA4", Offset = "0xAFFEA4", VA = "0xAFFEA4")]
	public bool BallRayCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0xB00360", Offset = "0xB00360", VA = "0xB00360")]
	public bool BallCloseField()
	{
		return default(bool);
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0xB00550", Offset = "0xB00550", VA = "0xB00550")]
	public BallMoveCheck()
	{
	}
}
[Token(Token = "0x200007A")]
public class GoalChecker : MonoBehaviour
{
	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool Goalin;

	[Token(Token = "0x600027C")]
	[Address(RVA = "0xB0060C", Offset = "0xB0060C", VA = "0xB0060C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0xB00814", Offset = "0xB00814", VA = "0xB00814")]
	public GoalChecker()
	{
	}
}
[Token(Token = "0x200007B")]
public class HammerImpactChecker : MonoBehaviour
{
	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 m_v3FixedLastPosition;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Rigidbody rb;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float Timer;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float time_;

	[Token(Token = "0x600027E")]
	[Address(RVA = "0xB0081C", Offset = "0xB0081C", VA = "0xB0081C")]
	private void Start()
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0xB00874", Offset = "0xB00874", VA = "0xB00874")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0xB0087C", Offset = "0xB0087C", VA = "0xB0087C")]
	private void raycastCheck(Rigidbody rb)
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0xB00B78", Offset = "0xB00B78", VA = "0xB00B78")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0xB00C2C", Offset = "0xB00C2C", VA = "0xB00C2C")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0xB00CC4", Offset = "0xB00CC4", VA = "0xB00CC4")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0xB00D54", Offset = "0xB00D54", VA = "0xB00D54")]
	public HammerImpactChecker()
	{
	}
}
[Token(Token = "0x200007C")]
public class PlayerCtrl
{
	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private float radian;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private float m_fDegree;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 CheckPoint;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject m_gFlyingCamera;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool m_bOnFlyingCamera;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Material m_matHammerHandle;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Material m_matHammerTop;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Color m_colHammerTopColor;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Color m_colHammerHandleColor;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool m_bIsTriggerOn;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Transform m_tPlayer;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private BoxCollider m_tpCollider;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool m_bTurnEnd;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
	private bool m_bBallOverlap;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
	private bool m_bUI_Trigger_Reset;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x83")]
	private bool m_bUI_End;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool m_bTriggerDown;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector3 m_v3SizeOffset;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private Vector3 m_v3CenterOffset;

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private bool m_bSetFlyingCamera;

	[Token(Token = "0x6000285")]
	[Address(RVA = "0xB00D68", Offset = "0xB00D68", VA = "0xB00D68")]
	public void init(Transform PlayerCtrl)
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0xB01160", Offset = "0xB01160", VA = "0xB01160")]
	public void onUpdate()
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0xB01CD4", Offset = "0xB01CD4", VA = "0xB01CD4")]
	private void TriggerCheck()
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0xB0232C", Offset = "0xB0232C", VA = "0xB0232C")]
	private void TriggerOn()
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0xB01208", Offset = "0xB01208", VA = "0xB01208")]
	private void TriggerOff()
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0xB01AFC", Offset = "0xB01AFC", VA = "0xB01AFC")]
	public void MoveinputCheck()
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0xB02388", Offset = "0xB02388", VA = "0xB02388")]
	public void MoveForwardBack(EnumClient.eTouchDirection eDirection)
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0xB02500", Offset = "0xB02500", VA = "0xB02500")]
	public void MoveRotation(EnumClient.eTouchDirection eDirection)
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0xB02778", Offset = "0xB02778", VA = "0xB02778")]
	public bool isLimitDistance(Vector3 position)
	{
		return default(bool);
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0xAFF2B0", Offset = "0xAFF2B0", VA = "0xAFF2B0")]
	public void PlayerPositionChange()
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0xB01268", Offset = "0xB01268", VA = "0xB01268")]
	private void FlyingCameraPositionUpdate()
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0xB013CC", Offset = "0xB013CC", VA = "0xB013CC")]
	private void FlyingCameraMoveInput()
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0xB029F0", Offset = "0xB029F0", VA = "0xB029F0")]
	private void SetPlayerFlyingCamera()
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0xB02D84", Offset = "0xB02D84", VA = "0xB02D84")]
	private void SetBackPlayerFromFlyingCamera()
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0xB02F68", Offset = "0xB02F68", VA = "0xB02F68")]
	private void ToFlyingCameraEnd()
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0xB02F70", Offset = "0xB02F70", VA = "0xB02F70")]
	private void ToPlayerCameraEnd()
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0xB02F84", Offset = "0xB02F84", VA = "0xB02F84")]
	public bool isTriggerOn()
	{
		return default(bool);
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0xB02F8C", Offset = "0xB02F8C", VA = "0xB02F8C")]
	public bool isUIOn()
	{
		return default(bool);
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0xB02F94", Offset = "0xB02F94", VA = "0xB02F94")]
	public Transform GetPlayerTransform()
	{
		return null;
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0xB028C4", Offset = "0xB028C4", VA = "0xB028C4")]
	public void ColliderSizeChange()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0xB02F9C", Offset = "0xB02F9C", VA = "0xB02F9C")]
	public void ColliderSizeChangeForGoal()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0xB0311C", Offset = "0xB0311C", VA = "0xB0311C")]
	public bool isOnFlyingCamera()
	{
		return default(bool);
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0xAFF3E0", Offset = "0xAFF3E0", VA = "0xAFF3E0")]
	public void TurnEnd()
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0xB03124", Offset = "0xB03124", VA = "0xB03124")]
	public void UI_End_Trigger_Reset()
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0xB03130", Offset = "0xB03130", VA = "0xB03130")]
	public void UI_End()
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0xB00CB8", Offset = "0xB00CB8", VA = "0xB00CB8")]
	public void BallOverlap()
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0xB00D4C", Offset = "0xB00D4C", VA = "0xB00D4C")]
	public void BallOverlapEnd()
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0xB0313C", Offset = "0xB0313C", VA = "0xB0313C")]
	public PlayerCtrl()
	{
	}
}
[Token(Token = "0x200007D")]
public class PlayerHammer
{
	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Transform m_tRealTopPosition;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform m_tHammerTop;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform m_tHammerHandle;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform m_tPlayerHammer;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float m_fHammerSpeed;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 m_v3HammerDirection;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 m_v3LastPosition;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Vector3 m_v3FixedLastPosition;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Rigidbody m_rbFrontHammer;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Rigidbody m_rbBackHammer;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Rigidbody m_rbLeftHammer;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Rigidbody m_rbRightHammer;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private GameObject m_gplayerHammer;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Vector3 SavedRotation;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private ParticleSystem.MainModule m_ColorChanger;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Color m_cMinColor;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Color m_cMaxColor;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Color m_cMiddleColor;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Dictionary<int, Vector3> m_dicLindex;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private LineRenderer m_EffectLine;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private Material m_matline;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private int Savedindex;

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0xB031C8", Offset = "0xB031C8", VA = "0xB031C8")]
	public void init(GameObject playerHammer)
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0xB034FC", Offset = "0xB034FC", VA = "0xB034FC")]
	public void onUpdate()
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0xB03D98", Offset = "0xB03D98", VA = "0xB03D98")]
	public GameObject GetPlayerHammerObj()
	{
		return null;
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0xB036A4", Offset = "0xB036A4", VA = "0xB036A4")]
	private void MonkeyKingBar()
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0xB03878", Offset = "0xB03878", VA = "0xB03878")]
	private void HammerTopPositionCheck()
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0xB03BDC", Offset = "0xB03BDC", VA = "0xB03BDC")]
	private float GetSpeed()
	{
		return default(float);
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0xB03DA0", Offset = "0xB03DA0", VA = "0xB03DA0")]
	public Vector3 GetHammerDirection()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0xB03DAC", Offset = "0xB03DAC", VA = "0xB03DAC")]
	public float GetHammerSpeed()
	{
		return default(float);
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0xB038AC", Offset = "0xB038AC", VA = "0xB038AC")]
	private void ColorInterPolation()
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0xB03DB4", Offset = "0xB03DB4", VA = "0xB03DB4")]
	public Transform GetHammerTop()
	{
		return null;
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0xB03DBC", Offset = "0xB03DBC", VA = "0xB03DBC")]
	public PlayerHammer()
	{
	}
}
[Token(Token = "0x200007E")]
public class State_Field : SingletonMonoBehaviour<State_Field>
{
	[Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class <ResetTrail>d__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TrailRenderer trail;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <trailTime>5__2;

		[Token(Token = "0x1700001A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0xB0763C", Offset = "0xB0763C", VA = "0xB0763C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0xB07684", Offset = "0xB07684", VA = "0xB07684", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xB06E74", Offset = "0xB06E74", VA = "0xB06E74")]
		[DebuggerHidden]
		public <ResetTrail>d__54(int <>1__state)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xB07560", Offset = "0xB07560", VA = "0xB07560", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xB07564", Offset = "0xB07564", VA = "0xB07564", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xB07644", Offset = "0xB07644", VA = "0xB07644", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private PlayerCtrl m_PlayerCtrl;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject m_gPlayer;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private PlayerHammer m_clPlayerHammer;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private BallMoveCheck m_clBall;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private EnumClient.eHandPose m_eHammerPose;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private UI_ScorePanel m_uiScorePanel;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private InterActionManager m_interActionManager;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject m_gHammerField;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Transform m_trBallVectorEffect;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool m_bIsGameEnd;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public AllSharedStageDatas m_clSharedStageData;

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Camera m_camBall;

	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float m_fEndTimer;

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private bool m_bStartEndEffect;

	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Vector3 m_v3SavedVeloForSlow;

	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private Vector3 m_v3SavedAngVeloForSlow;

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0xB03E68", Offset = "0xB03E68", VA = "0xB03E68")]
	private void Start()
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0xB04E08", Offset = "0xB04E08", VA = "0xB04E08")]
	private void Update()
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0xB0571C", Offset = "0xB0571C", VA = "0xB0571C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0xB0447C", Offset = "0xB0447C", VA = "0xB0447C")]
	private void PlayerSetting()
	{
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0xB04040", Offset = "0xB04040", VA = "0xB04040")]
	private void StageInfoSetting()
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0xB057D8", Offset = "0xB057D8", VA = "0xB057D8")]
	public PlayerCtrl GetPlayerCtrl()
	{
		return null;
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0xAFF1D8", Offset = "0xAFF1D8", VA = "0xAFF1D8")]
	public void DeleteMesh(MeshCombineManager meshCombine)
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0xB02884", Offset = "0xB02884", VA = "0xB02884")]
	public void MatchPlayerPosition()
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0xB01144", Offset = "0xB01144", VA = "0xB01144")]
	public GameObject GetHammerGameObject()
	{
		return null;
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0xB057E0", Offset = "0xB057E0", VA = "0xB057E0")]
	public PlayerHammer GetHammerController()
	{
		return null;
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0xB053A4", Offset = "0xB053A4", VA = "0xB053A4")]
	public void LookAtBall()
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0xB02B94", Offset = "0xB02B94", VA = "0xB02B94")]
	public void SetPlayerHeight()
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0xB057E8", Offset = "0xB057E8", VA = "0xB057E8")]
	public void HammerChange()
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0xB05A70", Offset = "0xB05A70", VA = "0xB05A70")]
	public EnumClient.eHandPose getCurrentHandPose()
	{
		return default(EnumClient.eHandPose);
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0xB00714", Offset = "0xB00714", VA = "0xB00714")]
	public void StartEndPhase()
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0xB05068", Offset = "0xB05068", VA = "0xB05068")]
	public void EndPhaseProcess()
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0xAFFC7C", Offset = "0xAFFC7C", VA = "0xAFFC7C")]
	public void HitProcess()
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0xAFF3EC", Offset = "0xAFF3EC", VA = "0xAFF3EC")]
	public void StopProcess()
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0xB06008", Offset = "0xB06008", VA = "0xB06008")]
	public bool isStarA()
	{
		return default(bool);
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0xB06048", Offset = "0xB06048", VA = "0xB06048")]
	public void ResetGame()
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0xB05F98", Offset = "0xB05F98", VA = "0xB05F98")]
	public void GameLoseCheck()
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0xB06050", Offset = "0xB06050", VA = "0xB06050")]
	public BallMoveCheck GetBall()
	{
		return null;
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0xB06058", Offset = "0xB06058", VA = "0xB06058")]
	public bool isGameEnd()
	{
		return default(bool);
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0xB05AD8", Offset = "0xB05AD8", VA = "0xB05AD8")]
	public void GameEndQuit(SceneHelper.eScene Scene)
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0xB04A84", Offset = "0xB04A84", VA = "0xB04A84")]
	private void PlayBGM()
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0xB05418", Offset = "0xB05418", VA = "0xB05418")]
	private void InputCheck()
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0xB06460", Offset = "0xB06460", VA = "0xB06460")]
	public void QuestUndo()
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0xB05BE4", Offset = "0xB05BE4", VA = "0xB05BE4")]
	public void SaveUndoData()
	{
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0xB065B4", Offset = "0xB065B4", VA = "0xB065B4")]
	private void Undo()
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0xB0694C", Offset = "0xB0694C", VA = "0xB0694C")]
	private void UndoEnd()
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0xB05768", Offset = "0xB05768", VA = "0xB05768")]
	public void SetStageChance()
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0xB06A18", Offset = "0xB06A18", VA = "0xB06A18")]
	public void SettingAffectedBombMeshCombineList(GameObject Tile)
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0xB06B50", Offset = "0xB06B50", VA = "0xB06B50")]
	public void SetAllAffectedMeshCombineList(GameObject obj)
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0xB06C88", Offset = "0xB06C88", VA = "0xB06C88")]
	public void SetAllAffectedBrokenMeshCombineList(GameObject obj)
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0xB02298", Offset = "0xB02298", VA = "0xB02298")]
	public void BallTargetVectorChange()
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0xB06DC0", Offset = "0xB06DC0", VA = "0xB06DC0")]
	public InterActionManager getInterActionManager()
	{
		return null;
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0xB011EC", Offset = "0xB011EC", VA = "0xB011EC")]
	public bool isGamePaused()
	{
		return default(bool);
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0xB06DC8", Offset = "0xB06DC8", VA = "0xB06DC8")]
	public UI_ScorePanel GetUIScorePanel()
	{
		return null;
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0xAFFE88", Offset = "0xAFFE88", VA = "0xAFFE88")]
	public Transform GetPlayerTransform()
	{
		return null;
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0xB06DD0", Offset = "0xB06DD0", VA = "0xB06DD0")]
	public void ResetTrail()
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0xB06E00", Offset = "0xB06E00", VA = "0xB06E00")]
	[IteratorStateMachine(typeof(<ResetTrail>d__54))]
	private IEnumerator ResetTrail(TrailRenderer trail)
	{
		return null;
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0xB05184", Offset = "0xB05184", VA = "0xB05184")]
	public void ChangeCameraWithFade()
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0xB06E9C", Offset = "0xB06E9C", VA = "0xB06E9C")]
	public void ChangeCamrea()
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0xB06F88", Offset = "0xB06F88", VA = "0xB06F88")]
	private void SetPlayerFinishCamera()
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0xAFF6CC", Offset = "0xAFF6CC", VA = "0xAFF6CC")]
	public void SetBackPlayerFromFinishCamera()
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0xB07148", Offset = "0xB07148", VA = "0xB07148")]
	public void CameraProcessEnd()
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0xAFFDF8", Offset = "0xAFFDF8", VA = "0xAFFDF8")]
	public bool isPinBallMap()
	{
		return default(bool);
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0xB074D8", Offset = "0xB074D8", VA = "0xB074D8")]
	public State_Field()
	{
	}
}
[Token(Token = "0x2000080")]
public class State_Logo : SingletonMonoBehaviour<State_Logo>
{
	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float m_fLogoTimer;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float m_fSoundStartTimer;

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float m_fSoundStartTime;

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private bool m_bLogoTimerStart;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	private bool m_bSoundStart;

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	private bool m_bVersionSuccess;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private TextMeshProUGUI m_txtSystemMessage;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private TextMeshProUGUI m_txtVersion;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Image m_imageLogo;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string m_strVersion;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public bool m_bControllerLoaded;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject m_gSystemMessage;

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0xB0768C", Offset = "0xB0768C", VA = "0xB0768C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0xB077BC", Offset = "0xB077BC", VA = "0xB077BC")]
	private void Start()
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0xB07BAC", Offset = "0xB07BAC", VA = "0xB07BAC")]
	private void Update()
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0xB07D54", Offset = "0xB07D54", VA = "0xB07D54")]
	private void SoundSequence()
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0xB07E38", Offset = "0xB07E38", VA = "0xB07E38")]
	private void LogoTimerStart()
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0xB07A4C", Offset = "0xB07A4C", VA = "0xB07A4C")]
	private void CheckInternet()
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0xB07E44", Offset = "0xB07E44", VA = "0xB07E44")]
	public void VersionCheck(bool passVersion)
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0xB0804C", Offset = "0xB0804C", VA = "0xB0804C")]
	public State_Logo()
	{
	}
}
[Token(Token = "0x2000081")]
public class State_Result : SingletonMonoBehaviour<State_Result>
{
	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private UI_Result m_uiResult;

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0xB080C8", Offset = "0xB080C8", VA = "0xB080C8")]
	private void Start()
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0xB0832C", Offset = "0xB0832C", VA = "0xB0832C")]
	public void ResultEffectEnd()
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0xB0834C", Offset = "0xB0834C", VA = "0xB0834C")]
	public State_Result()
	{
	}
}
[Token(Token = "0x2000082")]
public class State_Start : MonoBehaviour
{
	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool m_bTitleLoad;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool m_bChapterEffectReset;

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0xB08394", Offset = "0xB08394", VA = "0xB08394")]
	private void Start()
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0xB08768", Offset = "0xB08768", VA = "0xB08768")]
	private void Update()
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0xB0884C", Offset = "0xB0884C", VA = "0xB0884C")]
	private void EditorChapterEffectReset()
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0xB08470", Offset = "0xB08470", VA = "0xB08470")]
	private void OptionSetting()
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0xB089E0", Offset = "0xB089E0", VA = "0xB089E0")]
	public State_Start()
	{
	}
}
[Token(Token = "0x2000083")]
public class State_Title : MonoBehaviour
{
	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private UI_SelectStage m_uiSelectStage;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform m_trFarPosition;

	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform m_trNearPosition;

	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform m_trCreditPosition;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float m_fNear;

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float m_fFar;

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0xB089E8", Offset = "0xB089E8", VA = "0xB089E8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0xB08AF8", Offset = "0xB08AF8", VA = "0xB08AF8")]
	private void Start()
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0xB08DF8", Offset = "0xB08DF8", VA = "0xB08DF8")]
	private void CreditSetting()
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0xB08CFC", Offset = "0xB08CFC", VA = "0xB08CFC")]
	private void ChapterMedalSetting()
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0xB08EB0", Offset = "0xB08EB0", VA = "0xB08EB0")]
	private int MedalRatingCheck(int ChapterNumber)
	{
		return default(int);
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0xB090CC", Offset = "0xB090CC", VA = "0xB090CC")]
	public State_Title()
	{
	}
}
[Token(Token = "0x2000084")]
public class GlassDisable : MonoBehaviour
{
	[Token(Token = "0x60002F8")]
	[Address(RVA = "0xB090D4", Offset = "0xB090D4", VA = "0xB090D4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0xB0927C", Offset = "0xB0927C", VA = "0xB0927C")]
	public GlassDisable()
	{
	}
}
[Token(Token = "0x2000085")]
public class WallPushing : MonoBehaviour
{
	[Token(Token = "0x60002FA")]
	[Address(RVA = "0xB09284", Offset = "0xB09284", VA = "0xB09284")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0xB093CC", Offset = "0xB093CC", VA = "0xB093CC")]
	public WallPushing()
	{
	}
}
[Token(Token = "0x2000086")]
public class ButtonTouchHandler : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ScrollRect m_targetSR;

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0xB093D4", Offset = "0xB093D4", VA = "0xB093D4", Slot = "4")]
	public void OnBeginDrag(PointerEventData e)
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0xB093F8", Offset = "0xB093F8", VA = "0xB093F8", Slot = "5")]
	public void OnDrag(PointerEventData e)
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0xB0941C", Offset = "0xB0941C", VA = "0xB0941C", Slot = "6")]
	public void OnEndDrag(PointerEventData e)
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0xB09440", Offset = "0xB09440", VA = "0xB09440")]
	public ButtonTouchHandler()
	{
	}
}
[Token(Token = "0x2000087")]
public class CameraFollowXpos : MonoBehaviour
{
	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float m_fRotateSpeed;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject m_gObjCamera;

	[Token(Token = "0x6000300")]
	[Address(RVA = "0xB09448", Offset = "0xB09448", VA = "0xB09448")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0xB096B4", Offset = "0xB096B4", VA = "0xB096B4")]
	public CameraFollowXpos()
	{
	}
}
[Token(Token = "0x2000088")]
public class UIFontChanger : MonoBehaviour
{
	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TextMeshProUGUI m_TMP;

	[Token(Token = "0x6000302")]
	[Address(RVA = "0xB096C8", Offset = "0xB096C8", VA = "0xB096C8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0xB098B0", Offset = "0xB098B0", VA = "0xB098B0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0xB09728", Offset = "0xB09728", VA = "0xB09728")]
	private void FontChange()
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0xB098B4", Offset = "0xB098B4", VA = "0xB098B4")]
	public UIFontChanger()
	{
	}
}
[Token(Token = "0x2000089")]
public class UIForm
{
	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public UIManger.eUIType m_eUIType;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected string UIPath;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected GameObject m_gbase;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool bUpdateForm;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	protected bool isCloseAniOn;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	protected bool isObjSelected;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	protected int DelayCount;

	[Token(Token = "0x6000306")]
	[Address(RVA = "0xB098BC", Offset = "0xB098BC", VA = "0xB098BC")]
	public void Load(bool bShow)
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0xB099B4", Offset = "0xB099B4", VA = "0xB099B4", Slot = "4")]
	public virtual void Show()
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0xB099D4", Offset = "0xB099D4", VA = "0xB099D4", Slot = "5")]
	public virtual void Hide()
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0xB099F4", Offset = "0xB099F4", VA = "0xB099F4")]
	public bool IsShow()
	{
		return default(bool);
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0xB09A7C", Offset = "0xB09A7C", VA = "0xB09A7C", Slot = "6")]
	protected virtual void BindUI()
	{
	}

	[Token(Token = "0x600030B")]
	protected T FindControll<T>(string strPath) where T : Component
	{
		return null;
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0xB09A80", Offset = "0xB09A80", VA = "0xB09A80")]
	protected Transform FindTransform(string strPath)
	{
		return null;
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0xB09AB0", Offset = "0xB09AB0", VA = "0xB09AB0")]
	protected Transform FindTransform_Child(Transform _tParent, string _strName)
	{
		return null;
	}

	[Token(Token = "0x600030E")]
	protected T FindChild<T>(Transform _tParent, string _strName) where T : Component
	{
		return null;
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0xB09B48", Offset = "0xB09B48", VA = "0xB09B48", Slot = "7")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0xB09B4C", Offset = "0xB09B4C", VA = "0xB09B4C", Slot = "8")]
	public virtual void LateUpdate()
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0xB09B50", Offset = "0xB09B50", VA = "0xB09B50", Slot = "9")]
	public virtual void FixedUpdate()
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0xB09B54", Offset = "0xB09B54", VA = "0xB09B54")]
	protected void ResetSelectedObject()
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0xB09C54", Offset = "0xB09C54", VA = "0xB09C54", Slot = "10")]
	public virtual void Close()
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0xB09CE4", Offset = "0xB09CE4", VA = "0xB09CE4")]
	public void CloseAniStart()
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0xB09CF0", Offset = "0xB09CF0", VA = "0xB09CF0")]
	public void CloseAniEnd()
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0xB09CF8", Offset = "0xB09CF8", VA = "0xB09CF8", Slot = "11")]
	public virtual void OnPointerEnter(string _strUIName)
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0xB09CFC", Offset = "0xB09CFC", VA = "0xB09CFC", Slot = "12")]
	public virtual void OnPointerExit(string _strUIName)
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0xB09D00", Offset = "0xB09D00", VA = "0xB09D00")]
	public GameObject GetGameObject()
	{
		return null;
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0xB09D08", Offset = "0xB09D08", VA = "0xB09D08")]
	protected void OnPointerEnter(Button btn)
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0xB09F24", Offset = "0xB09F24", VA = "0xB09F24")]
	protected void OnPointerEnter(Toggle toggle)
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0xB0A140", Offset = "0xB0A140", VA = "0xB0A140")]
	private void OnPointerEnterSound()
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0xB0A1D4", Offset = "0xB0A1D4", VA = "0xB0A1D4")]
	public UIForm()
	{
	}
}
[Token(Token = "0x200008A")]
public class UIManger : SingletonMonoBehaviour<UIManger>
{
	[Token(Token = "0x200008B")]
	public enum eUIType
	{
		[Token(Token = "0x4000302")]
		None = -1,
		[Token(Token = "0x4000303")]
		UI_StageInfo,
		[Token(Token = "0x4000304")]
		UI_PauseMenu,
		[Token(Token = "0x4000305")]
		UI_PausePopup,
		[Token(Token = "0x4000306")]
		UI_Option,
		[Token(Token = "0x4000307")]
		UI_TextBar,
		[Token(Token = "0x4000308")]
		UI_SelectStage,
		[Token(Token = "0x4000309")]
		UI_ScorePanel,
		[Token(Token = "0x400030A")]
		UI_Result,
		[Token(Token = "0x400030B")]
		MAX
	}

	[Token(Token = "0x200008C")]
	public enum eUILoadPosition
	{
		[Token(Token = "0x400030D")]
		InCamera,
		[Token(Token = "0x400030E")]
		World,
		[Token(Token = "0x400030F")]
		Custom
	}

	[Token(Token = "0x200008D")]
	public enum eUISOUND_TYPE
	{
		[Token(Token = "0x4000311")]
		CLICK
	}

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<eUIType, UIForm> UIList;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<eUIType> m_lstTriggerLockUI;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<eUIType> m_lstReserveUI;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject m_gBaseParent;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject m_gCameraFollowerParent;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject m_gWorldIngameUI;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool m_bUpdate;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public Color MAX_PROGRESSBAR_COLOR;

	[Token(Token = "0x600031F")]
	[Address(RVA = "0xB0A23C", Offset = "0xB0A23C", VA = "0xB0A23C", Slot = "5")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0xB0A38C", Offset = "0xB0A38C", VA = "0xB0A38C", Slot = "6")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0xB0A390", Offset = "0xB0A390", VA = "0xB0A390", Slot = "4")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0xB0A4BC", Offset = "0xB0A4BC", VA = "0xB0A4BC", Slot = "7")]
	protected override void OnLateUpdate()
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0xB04C30", Offset = "0xB04C30", VA = "0xB04C30")]
	public UIForm LoadUI(eUIType eType, bool bShow)
	{
		return null;
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0xB0A5E8", Offset = "0xB0A5E8", VA = "0xB0A5E8")]
	public void Add_ReserveUI(eUIType _eType)
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0xB0A76C", Offset = "0xB0A76C", VA = "0xB0A76C")]
	public UIForm FindUI(eUIType eType)
	{
		return null;
	}

	[Token(Token = "0x6000326")]
	public T FindUI<T>(eUIType eType) where T : UIForm
	{
		return null;
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0xAFF7F0", Offset = "0xAFF7F0", VA = "0xAFF7F0")]
	public void ShowUI(eUIType eType)
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0xB0A6CC", Offset = "0xB0A6CC", VA = "0xB0A6CC")]
	public void HideUI(eUIType eType)
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0xB0A800", Offset = "0xB0A800", VA = "0xB0A800")]
	public void Show_ReserveUIList()
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0xB0A928", Offset = "0xB0A928", VA = "0xB0A928")]
	public void HideAllUI_Reserve(params eUIType[] _eHideExceptUIType)
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0xB0AB70", Offset = "0xB0AB70", VA = "0xB0AB70")]
	public bool IsLoad(eUIType eType)
	{
		return default(bool);
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0xB0AAD4", Offset = "0xB0AAD4", VA = "0xB0AAD4")]
	public bool IsShow(eUIType eType)
	{
		return default(bool);
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0xB0ABC8", Offset = "0xB0ABC8", VA = "0xB0ABC8")]
	public void CloseUI(eUIType eType)
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0xB0AC94", Offset = "0xB0AC94", VA = "0xB0AC94")]
	public void CloseAllUI(params eUIType[] _eExceptUIType)
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0xB0AE70", Offset = "0xB0AE70", VA = "0xB0AE70")]
	public Transform GetBaseTransform()
	{
		return null;
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0xB0AE8C", Offset = "0xB0AE8C", VA = "0xB0AE8C")]
	public Transform GetWorldUI()
	{
		return null;
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0xB0A348", Offset = "0xB0A348", VA = "0xB0A348")]
	private GameObject FindWorldUI()
	{
		return null;
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0xB0AF18", Offset = "0xB0AF18", VA = "0xB0AF18")]
	public void SetWorldUIPosition(Vector3 vecPos)
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0xB0AFE4", Offset = "0xB0AFE4", VA = "0xB0AFE4")]
	public void SetWorldUIRotation(Quaternion _Rotation)
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0xB0B0B8", Offset = "0xB0B0B8", VA = "0xB0B0B8")]
	public bool IsShowOptionUI()
	{
		return default(bool);
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0xB0B0E8", Offset = "0xB0B0E8", VA = "0xB0B0E8")]
	public UIManger()
	{
	}
}
[Token(Token = "0x200008E")]
public class UIResultEvent : MonoBehaviour
{
	[Token(Token = "0x6000336")]
	[Address(RVA = "0xB0B218", Offset = "0xB0B218", VA = "0xB0B218")]
	public void Star1()
	{
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0xB0B398", Offset = "0xB0B398", VA = "0xB0B398")]
	public void Star2()
	{
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0xB0B518", Offset = "0xB0B518", VA = "0xB0B518")]
	public void Star3()
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0xB0B698", Offset = "0xB0B698", VA = "0xB0B698")]
	public void StarLow()
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0xB0B818", Offset = "0xB0B818", VA = "0xB0B818")]
	public void StarHigh()
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0xB0B998", Offset = "0xB0B998", VA = "0xB0B998")]
	public void ResultSound()
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0xB0BBB8", Offset = "0xB0BBB8", VA = "0xB0BBB8")]
	public UIResultEvent()
	{
	}
}
[Token(Token = "0x200008F")]
public class UISelectEvent : MonoBehaviour
{
	[Token(Token = "0x600033D")]
	[Address(RVA = "0xB0BBC0", Offset = "0xB0BBC0", VA = "0xB0BBC0")]
	public void BreakSoundStart()
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0xB0BC54", Offset = "0xB0BC54", VA = "0xB0BC54")]
	public UISelectEvent()
	{
	}
}
[Token(Token = "0x2000090")]
public class UITextChanger : MonoBehaviour
{
	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string TextKey;

	[Token(Token = "0x600033F")]
	[Address(RVA = "0xB0BC5C", Offset = "0xB0BC5C", VA = "0xB0BC5C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0xB0BD5C", Offset = "0xB0BD5C", VA = "0xB0BD5C")]
	public UITextChanger()
	{
	}
}
[Token(Token = "0x2000091")]
public class UI_Result : UIForm
{
	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RectTransform m_rTransform;

	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Button m_btnRetry;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Button m_btnNext;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Button m_btnHome;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Image m_imgStar01;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Image m_imgStar02;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Image m_imgStar03;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private TextMeshProUGUI m_txtResult;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private TextMeshProUGUI m_txtTip;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private GameObject m_gRibbon;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private GameObject m_gEffect;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Sprite m_sStarGold;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Sprite m_sStarRainbow;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool m_bAlreadyClick;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Animator m_Animator;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public bool m_bButtonActivation;

	[Token(Token = "0x6000341")]
	[Address(RVA = "0xB0BD64", Offset = "0xB0BD64", VA = "0xB0BD64")]
	public UI_Result()
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0xB0BDC0", Offset = "0xB0BDC0", VA = "0xB0BDC0", Slot = "6")]
	protected override void BindUI()
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0xB0CE08", Offset = "0xB0CE08", VA = "0xB0CE08", Slot = "4")]
	public override void Show()
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0xB0C6E8", Offset = "0xB0C6E8", VA = "0xB0C6E8")]
	private void SaveStarCount()
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0xB0C880", Offset = "0xB0C880", VA = "0xB0C880")]
	private void ClearCheck()
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0xB0CF50", Offset = "0xB0CF50", VA = "0xB0CF50")]
	private void SaveCurStageClearData(int Chapter)
	{
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0xB0D460", Offset = "0xB0D460", VA = "0xB0D460")]
	private void OnClickRetry()
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0xB0D570", Offset = "0xB0D570", VA = "0xB0D570")]
	private void OnClickNext()
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0xB0D754", Offset = "0xB0D754", VA = "0xB0D754")]
	private void OnClickHome()
	{
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0xB0C914", Offset = "0xB0C914", VA = "0xB0C914")]
	private void ChapterOpneCheck()
	{
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0xB0CB1C", Offset = "0xB0CB1C", VA = "0xB0CB1C")]
	private void TipSetting(int CurChapter)
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0xB0CE68", Offset = "0xB0CE68", VA = "0xB0CE68")]
	private void AnimationPlay(int StarCount)
	{
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0xB0830C", Offset = "0xB0830C", VA = "0xB0830C")]
	public void AEffectOn()
	{
	}
}
[Token(Token = "0x2000092")]
public class UI_ScorePanel : UIForm
{
	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RectTransform m_rTransform;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private TextMeshProUGUI m_txtStageTip;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private TextMeshProUGUI m_txtStageChance;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private TextMeshProUGUI m_txtRemainChance;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private TextMeshProUGUI m_txtSmallinfoChance;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private TextMeshProUGUI m_txtStageNum;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private TextMeshProUGUI m_txtMessage;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private TextMeshProUGUI m_txtStageNum_Message;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Image m_imgStar01;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Image m_imgStar02;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Image m_imgStar03;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Image m_imgSmallinfoStar01;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Image m_imgSmallinfoStar02;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Image m_imgSmallinfoStar03;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Button m_btnRetry;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Button m_btnContinue;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Button m_btnHome;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private GameObject m_gPage_Deco;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private GameObject m_gPage_Ingame;

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private GameObject m_gPage_Pause;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private GameObject m_gText_Goal;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private GameObject m_gPage_Message;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private GameObject m_gTrigger_Message;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private GameObject m_gHelp;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private GameObject m_gOculus;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private GameObject m_gIndex;

	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private GameObject m_gWindowMR;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private GameObject m_gPico3;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private GameObject m_gPico4;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private GameObject m_gCosmos;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private Toggle m_tgVib;

	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private Toggle m_tgBgm;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private Toggle m_tgFx;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private bool m_bIsGamePaused;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private Animator m_aniTgVib;

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private Animator m_aniTgBgm;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private Animator m_aniTgFx;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private Vector3 m_v3ToggleOn;

	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	private Vector3 m_v3ToggleOff;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private Vector3 m_v3FrontPosition;

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
	private Vector3 m_v3BackPosition;

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private Quaternion m_qBackRotation;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private Transform m_trDrone;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private RectTransform m_rtParent;

	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private GameObject[] m_arrHelpImageSet;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private bool m_bForcedMiniCamera;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B1")]
	private bool m_bSaveDroneActiveSelf;

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B2")]
	private bool m_bMessageMode;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B3")]
	private bool m_bUndoQuestEnd;

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
	private bool m_bIsFlyingMode;

	[Token(Token = "0x6000351")]
	[Address(RVA = "0xB0D870", Offset = "0xB0D870", VA = "0xB0D870")]
	public UI_ScorePanel()
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0xB0D928", Offset = "0xB0D928", VA = "0xB0D928", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0xB0DC9C", Offset = "0xB0DC9C", VA = "0xB0DC9C", Slot = "6")]
	protected override void BindUI()
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0xB0F1F0", Offset = "0xB0F1F0", VA = "0xB0F1F0", Slot = "10")]
	public override void Close()
	{
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0xB0F240", Offset = "0xB0F240", VA = "0xB0F240", Slot = "4")]
	public override void Show()
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0xB0F2BC", Offset = "0xB0F2BC", VA = "0xB0F2BC", Slot = "5")]
	public override void Hide()
	{
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0xB05D44", Offset = "0xB05D44", VA = "0xB05D44")]
	public void UpdateIngameInfo()
	{
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0xB06130", Offset = "0xB06130", VA = "0xB06130")]
	public void PauseOn()
	{
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0xB062F0", Offset = "0xB062F0", VA = "0xB062F0")]
	public void PauseOff()
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0xB0F32C", Offset = "0xB0F32C", VA = "0xB0F32C")]
	public bool isPaused()
	{
		return default(bool);
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0xB06060", Offset = "0xB06060", VA = "0xB06060")]
	public void ScorePanelOnOff()
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0xB070F0", Offset = "0xB070F0", VA = "0xB070F0")]
	public void ScorePanelOff()
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0xB0711C", Offset = "0xB0711C", VA = "0xB0711C")]
	public void ScorePanelOn()
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0xB002B8", Offset = "0xB002B8", VA = "0xB002B8")]
	public void ForcedMiniCamera()
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0xB0F334", Offset = "0xB0F334", VA = "0xB0F334")]
	public bool isPanelUIon()
	{
		return default(bool);
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0xB06020", Offset = "0xB06020", VA = "0xB06020")]
	public bool isStarA()
	{
		return default(bool);
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0xB0F030", Offset = "0xB0F030", VA = "0xB0F030")]
	public void MessageOn(string TextKey)
	{
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0xB0DB04", Offset = "0xB0DB04", VA = "0xB0DB04")]
	public void MessageOff()
	{
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0xB0F35C", Offset = "0xB0F35C", VA = "0xB0F35C")]
	private void OnClickContinue()
	{
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0xB0F3FC", Offset = "0xB0F3FC", VA = "0xB0F3FC")]
	private void OnClickRetry()
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0xB0F4B8", Offset = "0xB0F4B8", VA = "0xB0F4B8")]
	private void OnClickHome()
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0xAFF890", Offset = "0xAFF890", VA = "0xAFF890")]
	public void UndoQuestOn()
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0xB06980", Offset = "0xB06980", VA = "0xB06980")]
	public void UndoQuestEnd()
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0xB0F600", Offset = "0xB0F600", VA = "0xB0F600")]
	private void OnClickFxToggle(bool value)
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0xB0F708", Offset = "0xB0F708", VA = "0xB0F708")]
	private void OnClickBgmToggle(bool value)
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0xB0F8E0", Offset = "0xB0F8E0", VA = "0xB0F8E0")]
	private void OnClickVibToggle(bool value)
	{
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0xB05A78", Offset = "0xB05A78", VA = "0xB05A78")]
	public void StageClear()
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0xB0F9E8", Offset = "0xB0F9E8", VA = "0xB0F9E8")]
	public bool isDroneOn()
	{
		return default(bool);
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0xB0F9F0", Offset = "0xB0F9F0", VA = "0xB0F9F0")]
	public bool isMessageOn()
	{
		return default(bool);
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0xB0EF78", Offset = "0xB0EF78", VA = "0xB0EF78")]
	private void ToggleSetting(Toggle toggle)
	{
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0xB02C2C", Offset = "0xB02C2C", VA = "0xB02C2C")]
	public void FlyingModeOn()
	{
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0xB02F40", Offset = "0xB02F40", VA = "0xB02F40")]
	public void FlyingModeOff()
	{
	}
}
[Token(Token = "0x2000093")]
public class UI_SelectStage : UIForm
{
	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Button[] m_arrStageBtns;

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Button[] m_arrChapterBtns;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Button m_btnStart;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Button m_btnScrollDown;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Button m_btnScrollUP;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Button m_btnHelp;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Button m_btnHelpExit;

	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private RectTransform m_rTransform;

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Image m_imgStageSnapShot;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Image m_imgStar01;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Image m_imgStar02;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Image m_imgStar03;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private TextMeshProUGUI m_txtStageTip;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private TextMeshProUGUI m_txtOpportunityNum;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private TextMeshProUGUI m_txtMoreStarNum;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private GameObject m_gScoreStar;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private GameObject m_gScoreNone;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private GameObject m_gBlindLock;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private GameObject m_gLayOutInfo;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private GameObject m_gHelp;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private GameObject m_gOculus;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private GameObject m_gWindowMr;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private GameObject m_gIndex;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private GameObject m_gPico3;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private GameObject m_gPico4;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private GameObject m_gCosmos;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private Scrollbar m_ScrollBar;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private float m_fScrollbarSpeed;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private bool m_bScrollUP;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10D")]
	private bool m_bScrollDown;

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private GameObject[] m_arrSelectedStage;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private GameObject[] m_arrSelectedChapter;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private GameObject[] m_arrHelpImageSet;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private Sprite m_sStarGold;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private Sprite m_sStarRainbow;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private Dictionary<int, List<Sprite>> m_dicSnapShot;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private bool m_bDontStartThisChapter;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private Animator m_Animator;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private int m_nCurAniChapter;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	private float m_fTimer;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private float m_fChangeDelay;

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	private bool m_bAniStart;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15D")]
	private bool m_bisAlredayStart;

	[Token(Token = "0x6000374")]
	[Address(RVA = "0xB10A04", Offset = "0xB10A04", VA = "0xB10A04")]
	public UI_SelectStage()
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0xB10B78", Offset = "0xB10B78", VA = "0xB10B78", Slot = "6")]
	protected override void BindUI()
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0xB12874", Offset = "0xB12874", VA = "0xB12874", Slot = "4")]
	public override void Show()
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0xB12B60", Offset = "0xB12B60", VA = "0xB12B60", Slot = "7")]
	public override void Update()
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0xB12E7C", Offset = "0xB12E7C", VA = "0xB12E7C")]
	private void OnClickStage()
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0xB1264C", Offset = "0xB1264C", VA = "0xB1264C")]
	private void StageSetting()
	{
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0xB13B74", Offset = "0xB13B74", VA = "0xB13B74")]
	private void onClickHelp()
	{
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0xB13D38", Offset = "0xB13D38", VA = "0xB13D38")]
	private void onClickHelpExit()
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0xB13DF8", Offset = "0xB13DF8", VA = "0xB13DF8")]
	private void onClickChapter()
	{
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0xB14254", Offset = "0xB14254", VA = "0xB14254")]
	private void EditiorChapterChangeUp()
	{
	}

	[Token(Token = "0x600037E")]
	[Address(RVA = "0xB14340", Offset = "0xB14340", VA = "0xB14340")]
	private void EditiorChapterChangeDown()
	{
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0xB12544", Offset = "0xB12544", VA = "0xB12544")]
	private void StageSelectEffect(int index)
	{
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0xB125C8", Offset = "0xB125C8", VA = "0xB125C8")]
	private void ChapterSelectEffect(int index)
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0xB141F0", Offset = "0xB141F0", VA = "0xB141F0")]
	private void ButtonSelectEffectOff()
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0xB1442C", Offset = "0xB1442C", VA = "0xB1442C")]
	private void EditorStageSelecting()
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0xB135C8", Offset = "0xB135C8", VA = "0xB135C8")]
	private void ButtonActivateCheck(Button btn, bool Activate, int StageNumber)
	{
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0xB130FC", Offset = "0xB130FC", VA = "0xB130FC")]
	private void SetUIMain()
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0xB14B74", Offset = "0xB14B74", VA = "0xB14B74")]
	private void SetMainUIStar(int starCount, bool isUndoCheck)
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0xB148CC", Offset = "0xB148CC", VA = "0xB148CC")]
	private void SetStageButtonUIStar(Button btn, int StarCount, bool isUndoCheck)
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0xB119FC", Offset = "0xB119FC", VA = "0xB119FC")]
	private void SetSnapShotImage()
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0xB11D14", Offset = "0xB11D14", VA = "0xB11D14")]
	private void SetChapterBtn(int index)
	{
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0xB14D38", Offset = "0xB14D38", VA = "0xB14D38")]
	private void onClickStart()
	{
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0xB12C5C", Offset = "0xB12C5C", VA = "0xB12C5C")]
	private void AniSequence()
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0xB12CB4", Offset = "0xB12CB4", VA = "0xB12CB4")]
	private void AniEndCheck()
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0xB12890", Offset = "0xB12890", VA = "0xB12890")]
	private void ChapterOpenAniCheck()
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0xB14E74", Offset = "0xB14E74", VA = "0xB14E74")]
	private void ForcedChapterChange(int Number)
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0xB12E10", Offset = "0xB12E10", VA = "0xB12E10")]
	private void ScrollbarDown()
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0xB12DA4", Offset = "0xB12DA4", VA = "0xB12DA4")]
	private void ScrollbarUp()
	{
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0xB1203C", Offset = "0xB1203C", VA = "0xB1203C")]
	private void SettingScrollbarBtns()
	{
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0xB15094", Offset = "0xB15094", VA = "0xB15094")]
	private void ScrollUPbtnDown()
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0xB150A0", Offset = "0xB150A0", VA = "0xB150A0")]
	private void ScrollUPbtnUp()
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0xB150AC", Offset = "0xB150AC", VA = "0xB150AC")]
	private void ScrollDownbtnDown()
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0xB150B8", Offset = "0xB150B8", VA = "0xB150B8")]
	private void ScrollDownbtnUP()
	{
	}
}
[Token(Token = "0x2000094")]
public class ConstClient
{
	[Token(Token = "0x2000095")]
	public enum ePlatfomType
	{
		[Token(Token = "0x40003A8")]
		Oculus,
		[Token(Token = "0x40003A9")]
		Index,
		[Token(Token = "0x40003AA")]
		G2,
		[Token(Token = "0x40003AB")]
		PICO3,
		[Token(Token = "0x40003AC")]
		PICO4,
		[Token(Token = "0x40003AD")]
		COSMOS
	}

	[Token(Token = "0x4000380")]
	public const int MAX_VALUE = 10;

	[Token(Token = "0x4000381")]
	public const int MIN_VALUE = 0;

	[Token(Token = "0x4000382")]
	public const float TOUCH_BASE_1 = 45f;

	[Token(Token = "0x4000383")]
	public const float TOUCH_BASE_2 = 135f;

	[Token(Token = "0x4000384")]
	public const float TOUCH_MIDDLE = 0f;

	[Token(Token = "0x4000385")]
	public const float RAYSPEED = 30f;

	[Token(Token = "0x4000386")]
	public const string USER_STAGE_DATA = "UserStageClearData";

	[Token(Token = "0x4000387")]
	public const string USER_BGM = "User_BGM_Size";

	[Token(Token = "0x4000388")]
	public const string USER_FX = "User_FX_Size";

	[Token(Token = "0x4000389")]
	public const string USER_VIBE = "User_VIBE_Size";

	[Token(Token = "0x400038A")]
	public const float PLAYER_POSITION_CHANGE_DELAY = 0.5f;

	[Token(Token = "0x400038B")]
	public const string BGM_VALUE = "USER_BGM";

	[Token(Token = "0x400038C")]
	public const string FX_VALUE = "USER_FX";

	[Token(Token = "0x400038D")]
	public const string VIBE_VALUE = "USER_VIBE";

	[Token(Token = "0x400038E")]
	public const string CHAPTER2_OPEN = "Chapter2open";

	[Token(Token = "0x400038F")]
	public const string CHAPTER2_EFFECT = "Chapter2effect";

	[Token(Token = "0x4000390")]
	public const string CHAPTER3_OPEN = "Chapter3open";

	[Token(Token = "0x4000391")]
	public const string CHAPTER3_EFFECT = "Chapter3effect";

	[Token(Token = "0x4000392")]
	public const string CHAPTER4_OPEN = "Chapter4open";

	[Token(Token = "0x4000393")]
	public const string CHAPTER4_EFFECT = "Chapter4effect";

	[Token(Token = "0x4000394")]
	public const float FORCE_STOP_TIME = 3f;

	[Token(Token = "0x4000395")]
	public const float LIMIT_MIN_PLAYER_DISTANCE = 0.4f;

	[Token(Token = "0x4000396")]
	public const float LIMIT_MAX_PLAYER_DISTANCE = 1.6f;

	[Token(Token = "0x4000397")]
	public const float MONKEYKINGBAR_DISTANCE = 2.5f;

	[Token(Token = "0x4000398")]
	public const float PORTAL_DELAY = 1f;

	[Token(Token = "0x4000399")]
	public const int RESET_SELECTED_DELAY = 200;

	[Token(Token = "0x400039A")]
	public const int REQUIRE_STAR_FOR_CHAPTER = 25;

	[Token(Token = "0x400039B")]
	public const float LOGO_TIME = 2f;

	[Token(Token = "0x400039C")]
	public const float SLOW_DISTANCE_HOLE = 10f;

	[Token(Token = "0x400039D")]
	public const float GOAL_EFFECT_DISTANCE = 5f;

	[Token(Token = "0x400039E")]
	public const float SLOW_SPEED_MIN = 2f;

	[Token(Token = "0x400039F")]
	public const float SLOW_SPEED_MAX = 4.5f;

	[Token(Token = "0x40003A0")]
	public const float SKYBOX_CHANGE_TIME = 3f;

	[Token(Token = "0x40003A1")]
	public const float DARKNESS_EXIT_DELAY = 7f;

	[Token(Token = "0x40003A2")]
	public const float NORMAL_EXIT_DELAY = 3f;

	[Token(Token = "0x40003A3")]
	public const string QUEST_202 = "QUEST_202";

	[Token(Token = "0x40003A4")]
	public const string DEFAULT_TIP_TEXTS = "Tips. ";

	[Token(Token = "0x40003A5")]
	public const float SLOW_SCALE = 0.05f;

	[Token(Token = "0x40003A6")]
	public const float FLY_SLOW_SCALE = 0.05f;

	[Token(Token = "0x600039E")]
	[Address(RVA = "0xB15108", Offset = "0xB15108", VA = "0xB15108")]
	public ConstClient()
	{
	}
}
[Token(Token = "0x2000096")]
public class DontDestroy<T> : MonoBehaviour where T : DontDestroy<T>
{
	[Token(Token = "0x1700001C")]
	public static T Instance
	{
		[Token(Token = "0x600039F")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60003A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60003A1")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003A2")]
	private void Start()
	{
	}

	[Token(Token = "0x60003A3")]
	protected virtual void OnAwake()
	{
	}

	[Token(Token = "0x60003A4")]
	protected virtual void OnStart()
	{
	}

	[Token(Token = "0x60003A5")]
	public DontDestroy()
	{
	}
}
[Token(Token = "0x2000097")]
public class EaseCurve
{
	[Token(Token = "0x2000098")]
	public enum EaseType
	{
		[Token(Token = "0x40003B0")]
		easeInQuad,
		[Token(Token = "0x40003B1")]
		easeOutQuad,
		[Token(Token = "0x40003B2")]
		easeInOutQuad,
		[Token(Token = "0x40003B3")]
		easeInCubic,
		[Token(Token = "0x40003B4")]
		easeOutCubic,
		[Token(Token = "0x40003B5")]
		easeInOutCubic,
		[Token(Token = "0x40003B6")]
		easeInQuart,
		[Token(Token = "0x40003B7")]
		easeOutQuart,
		[Token(Token = "0x40003B8")]
		easeInOutQuart,
		[Token(Token = "0x40003B9")]
		easeInQuint,
		[Token(Token = "0x40003BA")]
		easeOutQuint,
		[Token(Token = "0x40003BB")]
		easeInOutQuint,
		[Token(Token = "0x40003BC")]
		easeInSine,
		[Token(Token = "0x40003BD")]
		easeOutSine,
		[Token(Token = "0x40003BE")]
		easeInOutSine,
		[Token(Token = "0x40003BF")]
		easeInExpo,
		[Token(Token = "0x40003C0")]
		easeOutExpo,
		[Token(Token = "0x40003C1")]
		easeInOutExpo,
		[Token(Token = "0x40003C2")]
		easeInCirc,
		[Token(Token = "0x40003C3")]
		easeOutCirc,
		[Token(Token = "0x40003C4")]
		easeInOutCirc,
		[Token(Token = "0x40003C5")]
		linear,
		[Token(Token = "0x40003C6")]
		spring,
		[Token(Token = "0x40003C7")]
		easeInBounce,
		[Token(Token = "0x40003C8")]
		easeOutBounce,
		[Token(Token = "0x40003C9")]
		easeInOutBounce,
		[Token(Token = "0x40003CA")]
		easeInBack,
		[Token(Token = "0x40003CB")]
		easeOutBack,
		[Token(Token = "0x40003CC")]
		easeInOutBack,
		[Token(Token = "0x40003CD")]
		easeInElastic,
		[Token(Token = "0x40003CE")]
		easeOutElastic,
		[Token(Token = "0x40003CF")]
		easeInOutElastic
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0xB15110", Offset = "0xB15110", VA = "0xB15110")]
	public static float EasingFunction(float start, float end, float value, EaseType easeType)
	{
		return default(float);
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0xB16180", Offset = "0xB16180", VA = "0xB16180")]
	public static Vector3 EasingFunction(Vector3 start, Vector3 end, float value, EaseType easeType)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0xB16204", Offset = "0xB16204", VA = "0xB16204")]
	public static float EasingAnimationCurve(AnimationCurve animationCurve, float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0xB16240", Offset = "0xB16240", VA = "0xB16240")]
	public static Vector3 EasingAnimationCurve(AnimationCurve animationCurve, Vector3 start, Vector3 end, float value)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0xB15C1C", Offset = "0xB15C1C", VA = "0xB15C1C")]
	private static float Linear(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0xB162EC", Offset = "0xB162EC", VA = "0xB162EC")]
	private static float Clerp(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0xB15C40", Offset = "0xB15C40", VA = "0xB15C40")]
	private static float Spring(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0xB15774", Offset = "0xB15774", VA = "0xB15774")]
	private static float EaseInQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0xB15788", Offset = "0xB15788", VA = "0xB15788")]
	private static float EaseOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0xB157A4", Offset = "0xB157A4", VA = "0xB157A4")]
	private static float EaseInOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0xB157F8", Offset = "0xB157F8", VA = "0xB157F8")]
	private static float EaseInCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0xB15810", Offset = "0xB15810", VA = "0xB15810")]
	private static float EaseOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0xB15838", Offset = "0xB15838", VA = "0xB15838")]
	private static float EaseInOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0xB15890", Offset = "0xB15890", VA = "0xB15890")]
	private static float EaseInQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0xB158AC", Offset = "0xB158AC", VA = "0xB158AC")]
	private static float EaseOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0xB158D4", Offset = "0xB158D4", VA = "0xB158D4")]
	private static float EaseInOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0xB15930", Offset = "0xB15930", VA = "0xB15930")]
	private static float EaseInQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0xB15950", Offset = "0xB15950", VA = "0xB15950")]
	private static float EaseOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0xB15980", Offset = "0xB15980", VA = "0xB15980")]
	private static float EaseInOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0xB159E8", Offset = "0xB159E8", VA = "0xB159E8")]
	private static float EaseInSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0xB15A20", Offset = "0xB15A20", VA = "0xB15A20")]
	private static float EaseOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0xB15A54", Offset = "0xB15A54", VA = "0xB15A54")]
	private static float EaseInOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0xB15A98", Offset = "0xB15A98", VA = "0xB15A98")]
	private static float EaseInExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0xB15AD0", Offset = "0xB15AD0", VA = "0xB15AD0")]
	private static float EaseOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0xB15B08", Offset = "0xB15B08", VA = "0xB15B08")]
	private static float EaseInOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0xB15B78", Offset = "0xB15B78", VA = "0xB15B78")]
	private static float EaseInCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0xB15BA0", Offset = "0xB15BA0", VA = "0xB15BA0")]
	private static float EaseOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0xB15BC8", Offset = "0xB15BC8", VA = "0xB15BC8")]
	private static float EaseInOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0xB15CF0", Offset = "0xB15CF0", VA = "0xB15CF0")]
	private static float EaseInBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0xB15D28", Offset = "0xB15D28", VA = "0xB15D28")]
	private static float EaseOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0xB15DF0", Offset = "0xB15DF0", VA = "0xB15DF0")]
	private static float EaseInOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0xB15E70", Offset = "0xB15E70", VA = "0xB15E70")]
	private static float EaseInBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0xB15EA0", Offset = "0xB15EA0", VA = "0xB15EA0")]
	private static float EaseOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0xB15EE0", Offset = "0xB15EE0", VA = "0xB15EE0")]
	private static float EaseInOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0xB15F64", Offset = "0xB15F64", VA = "0xB15F64")]
	private static float EaseInElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0xB15FF4", Offset = "0xB15FF4", VA = "0xB15FF4")]
	private static float EaseOutElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0xB16084", Offset = "0xB16084", VA = "0xB16084")]
	private static float EaseInOutElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0xB16350", Offset = "0xB16350", VA = "0xB16350")]
	public EaseCurve()
	{
	}
}
[Token(Token = "0x2000099")]
public class EnumClient
{
	[Token(Token = "0x200009A")]
	public enum eTouchDirection
	{
		[Token(Token = "0x40003D1")]
		eTouchDirection_None = -1,
		[Token(Token = "0x40003D2")]
		eTouchDirection_Middle,
		[Token(Token = "0x40003D3")]
		eTouchDirection_Up,
		[Token(Token = "0x40003D4")]
		eTouchDirection_Down,
		[Token(Token = "0x40003D5")]
		eTouchDirection_Left,
		[Token(Token = "0x40003D6")]
		eTouchDirection_Right,
		[Token(Token = "0x40003D7")]
		eTouchDirection_AppButtonClick,
		[Token(Token = "0x40003D8")]
		eTouchDirection_AppButton
	}

	[Token(Token = "0x200009B")]
	public enum eHandPose
	{
		[Token(Token = "0x40003DA")]
		Right,
		[Token(Token = "0x40003DB")]
		Left
	}

	[Token(Token = "0x200009C")]
	public enum eLANGUAGE_TYPE
	{
		[Token(Token = "0x40003DD")]
		eng,
		[Token(Token = "0x40003DE")]
		kor,
		[Token(Token = "0x40003DF")]
		jpn,
		[Token(Token = "0x40003E0")]
		chn
	}

	[Token(Token = "0x200009D")]
	public enum eSoundList
	{
		[Token(Token = "0x40003E2")]
		SFX_M_Title,
		[Token(Token = "0x40003E3")]
		SFX_M_MenuScroll,
		[Token(Token = "0x40003E4")]
		SFX_M_Overlap,
		[Token(Token = "0x40003E5")]
		SFX_M_Click,
		[Token(Token = "0x40003E6")]
		SFX_G_AttackA,
		[Token(Token = "0x40003E7")]
		SFX_G_AttackB,
		[Token(Token = "0x40003E8")]
		SFX_G_AttackC,
		[Token(Token = "0x40003E9")]
		SFX_G_HoleLine,
		[Token(Token = "0x40003EA")]
		SFX_G_HoleGoal,
		[Token(Token = "0x40003EB")]
		SFX_G_Reset,
		[Token(Token = "0x40003EC")]
		SFX_G_BoardDrop,
		[Token(Token = "0x40003ED")]
		SFX_G_BoardOn,
		[Token(Token = "0x40003EE")]
		SFX_G_GrassDrop,
		[Token(Token = "0x40003EF")]
		SFX_G_GrassOn,
		[Token(Token = "0x40003F0")]
		SFX_G_Impact,
		[Token(Token = "0x40003F1")]
		SFX_G_Steeldrop,
		[Token(Token = "0x40003F2")]
		SFX_G_SteelOn,
		[Token(Token = "0x40003F3")]
		SFX_G_WoodFenceHit,
		[Token(Token = "0x40003F4")]
		SFX_M_Success,
		[Token(Token = "0x40003F5")]
		SFX_M_Fail,
		[Token(Token = "0x40003F6")]
		BGM_M_Title1
	}

	[Token(Token = "0x200009E")]
	public enum TipSetOne
	{
		[Token(Token = "0x40003F8")]
		Tips_1_1,
		[Token(Token = "0x40003F9")]
		Tips_1_2,
		[Token(Token = "0x40003FA")]
		Tips_1_3,
		[Token(Token = "0x40003FB")]
		Tips_1_4,
		[Token(Token = "0x40003FC")]
		Tips_1_5,
		[Token(Token = "0x40003FD")]
		Tips_1_6,
		[Token(Token = "0x40003FE")]
		Tips_1_7,
		[Token(Token = "0x40003FF")]
		Tips_1_8,
		[Token(Token = "0x4000400")]
		Tips_1_9,
		[Token(Token = "0x4000401")]
		Tips_1_10,
		[Token(Token = "0x4000402")]
		Tips_1_11
	}

	[Token(Token = "0x200009F")]
	public enum TipSetTwo
	{
		[Token(Token = "0x4000404")]
		Tips_2_1,
		[Token(Token = "0x4000405")]
		Tips_2_2,
		[Token(Token = "0x4000406")]
		Tips_2_3,
		[Token(Token = "0x4000407")]
		Tips_2_4,
		[Token(Token = "0x4000408")]
		Tips_2_5,
		[Token(Token = "0x4000409")]
		Tips_2_6,
		[Token(Token = "0x400040A")]
		Tips_2_7,
		[Token(Token = "0x400040B")]
		Tips_2_8,
		[Token(Token = "0x400040C")]
		Tips_2_9,
		[Token(Token = "0x400040D")]
		Tips_2_10,
		[Token(Token = "0x400040E")]
		Tips_2_11
	}

	[Token(Token = "0x20000A0")]
	public enum TipSetThree
	{
		[Token(Token = "0x4000410")]
		Tips_3_1,
		[Token(Token = "0x4000411")]
		Tips_3_2,
		[Token(Token = "0x4000412")]
		Tips_3_3,
		[Token(Token = "0x4000413")]
		Tips_3_4,
		[Token(Token = "0x4000414")]
		Tips_3_5,
		[Token(Token = "0x4000415")]
		Tips_3_6,
		[Token(Token = "0x4000416")]
		Tips_3_7,
		[Token(Token = "0x4000417")]
		Tips_3_8
	}

	[Token(Token = "0x20000A1")]
	public enum TipSetFour
	{
		[Token(Token = "0x4000419")]
		Tips_4_1,
		[Token(Token = "0x400041A")]
		Tips_4_2,
		[Token(Token = "0x400041B")]
		Tips_4_3,
		[Token(Token = "0x400041C")]
		Tips_4_4,
		[Token(Token = "0x400041D")]
		Tips_4_5,
		[Token(Token = "0x400041E")]
		Tips_4_6,
		[Token(Token = "0x400041F")]
		Tips_4_7,
		[Token(Token = "0x4000420")]
		Tips_4_8,
		[Token(Token = "0x4000421")]
		Tips_4_9,
		[Token(Token = "0x4000422")]
		Tips_4_10,
		[Token(Token = "0x4000423")]
		Tips_4_11
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0xB16358", Offset = "0xB16358", VA = "0xB16358")]
	public EnumClient()
	{
	}
}
[Token(Token = "0x20000A2")]
internal class SecurityManager
{
	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static SecurityManager m_instance;

	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private RijndaelManaged m_Aes;

	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MD5 m_Md5Hash;

	[Token(Token = "0x4000427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool m_bSecurityInit;

	[Token(Token = "0x1700001D")]
	public bool SecurityInit
	{
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xB16360", Offset = "0xB16360", VA = "0xB16360")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001E")]
	public static SecurityManager Instance
	{
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xB16368", Offset = "0xB16368", VA = "0xB16368")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0xB163F4", Offset = "0xB163F4", VA = "0xB163F4")]
	private SecurityManager()
	{
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0xB1651C", Offset = "0xB1651C", VA = "0xB1651C")]
	public void Init(string _strKey, byte[] _iV)
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0xB165A4", Offset = "0xB165A4", VA = "0xB165A4")]
	public string GetMd5Hash(byte[] input)
	{
		return null;
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0xB166A0", Offset = "0xB166A0", VA = "0xB166A0")]
	public string GetMd5Hash(string input)
	{
		return null;
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0xB166E8", Offset = "0xB166E8", VA = "0xB166E8")]
	public bool VerifyMd5Hash(byte[] input, string hash)
	{
		return default(bool);
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0xB167BC", Offset = "0xB167BC", VA = "0xB167BC")]
	public bool VerifyMd5Hash(string input, string hash)
	{
		return default(bool);
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0xB1680C", Offset = "0xB1680C", VA = "0xB1680C")]
	public string AES_encrypt(string Input)
	{
		return null;
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0xB16C0C", Offset = "0xB16C0C", VA = "0xB16C0C")]
	public string AES_decrypt(string Input)
	{
		return null;
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0xB16FCC", Offset = "0xB16FCC", VA = "0xB16FCC")]
	public string EncryptString(string str)
	{
		return null;
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0xB17000", Offset = "0xB17000", VA = "0xB17000")]
	public string DecryptString(string str)
	{
		return null;
	}
}
[Token(Token = "0x20000A3")]
public class Singleton<T> where T : class, new()
{
	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static T _instance;

	[Token(Token = "0x1700001F")]
	public static T Instance
	{
		[Token(Token = "0x60003D9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60003DA")]
	protected Singleton()
	{
	}

	[Token(Token = "0x60003DB")]
	public static bool IsNull()
	{
		return default(bool);
	}
}
[Token(Token = "0x20000A4")]
public class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static T _instance;

	[Token(Token = "0x17000020")]
	public static T Instance
	{
		[Token(Token = "0x60003DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60003DD")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003DE")]
	private void Start()
	{
	}

	[Token(Token = "0x60003DF")]
	private void Update()
	{
	}

	[Token(Token = "0x60003E0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60003E1")]
	protected virtual void OnUpdate()
	{
	}

	[Token(Token = "0x60003E2")]
	protected virtual void OnAwake()
	{
	}

	[Token(Token = "0x60003E3")]
	protected virtual void OnStart()
	{
	}

	[Token(Token = "0x60003E4")]
	protected virtual void OnLateUpdate()
	{
	}

	[Token(Token = "0x60003E5")]
	public static bool IsInstance()
	{
		return default(bool);
	}

	[Token(Token = "0x60003E6")]
	public SingletonMonoBehaviour()
	{
	}
}
[Token(Token = "0x20000A5")]
public class Util
{
	[Token(Token = "0x60003E7")]
	[Address(RVA = "0xB17198", Offset = "0xB17198", VA = "0xB17198")]
	public static void InitTransform(Transform trans)
	{
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0xB17278", Offset = "0xB17278", VA = "0xB17278")]
	public static float Distance(GameObject a, GameObject b)
	{
		return default(float);
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0xB17350", Offset = "0xB17350", VA = "0xB17350")]
	public static float Distance(Transform a, Transform b)
	{
		return default(float);
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0xB17410", Offset = "0xB17410", VA = "0xB17410")]
	public static float Distance(Vector3 a, Vector3 b)
	{
		return default(float);
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0xB174A8", Offset = "0xB174A8", VA = "0xB174A8")]
	public static float Distance(Vector2 a, Vector2 b)
	{
		return default(float);
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0xB17528", Offset = "0xB17528", VA = "0xB17528")]
	public static bool FloatEqual(float x, float y, float d)
	{
		return default(bool);
	}

	[Token(Token = "0x60003ED")]
	public static T ToEnum<T>(string str)
	{
		return (T)null;
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0xB17548", Offset = "0xB17548", VA = "0xB17548")]
	public static double GetAngle(float x1, float y1, float x2, float y2)
	{
		return default(double);
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0xB175E0", Offset = "0xB175E0", VA = "0xB175E0")]
	public static Camera GetMainCamera()
	{
		return null;
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0xB17718", Offset = "0xB17718", VA = "0xB17718")]
	public static string GetSoundUnique(EnumClient.eSoundList SoundName)
	{
		return null;
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0xB1777C", Offset = "0xB1777C", VA = "0xB1777C")]
	public static EnumClient.eLANGUAGE_TYPE Get_LanguageType()
	{
		return default(EnumClient.eLANGUAGE_TYPE);
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0xB177D0", Offset = "0xB177D0", VA = "0xB177D0")]
	public Util()
	{
	}
}
[Token(Token = "0x20000A6")]
public class SkyboxCamera : MonoBehaviour
{
	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Camera m_MainCamera;

	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float m_SkyboxScale;

	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 mainCamStartPos;

	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 skyboxCamStartPos;

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0xB177D8", Offset = "0xB177D8", VA = "0xB177D8")]
	private void Start()
	{
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0xB178AC", Offset = "0xB178AC", VA = "0xB178AC")]
	private void Update()
	{
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0xB1798C", Offset = "0xB1798C", VA = "0xB1798C")]
	public SkyboxCamera()
	{
	}
}
[Token(Token = "0x20000A7")]
[ExecuteAlways]
public class ScreenSpacePlacement : MonoBehaviour
{
	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Camera m_Cam;

	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform m_FlareObject;

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0xB1799C", Offset = "0xB1799C", VA = "0xB1799C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0xB17AF0", Offset = "0xB17AF0", VA = "0xB17AF0")]
	public ScreenSpacePlacement()
	{
	}
}
[Token(Token = "0x20000A8")]
public class KeepFrameFeature : ScriptableRendererFeature
{
	[Token(Token = "0x20000A9")]
	private class CopyFramePass : ScriptableRenderPass
	{
		[Token(Token = "0x17000021")]
		private RenderTargetIdentifier source
		{
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0xB17EB8", Offset = "0xB17EB8", VA = "0xB17EB8")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetIdentifier);
			}
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0xB17ED0", Offset = "0xB17ED0", VA = "0xB17ED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		private RenderTargetHandle destination
		{
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0xB17EE8", Offset = "0xB17EE8", VA = "0xB17EE8")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0xB17EFC", Offset = "0xB17EFC", VA = "0xB17EFC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xB17DC8", Offset = "0xB17DC8", VA = "0xB17DC8")]
		public void Setup(RenderTargetIdentifier source, RenderTargetHandle destination)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xB17F10", Offset = "0xB17F10", VA = "0xB17F10", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xB18054", Offset = "0xB18054", VA = "0xB18054", Slot = "7")]
		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xB17BC4", Offset = "0xB17BC4", VA = "0xB17BC4")]
		public CopyFramePass()
		{
		}
	}

	[Token(Token = "0x20000AA")]
	private class DrawOldFramePass : ScriptableRenderPass
	{
		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material m_DrawOldFrameMaterial;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RenderTargetHandle m_handle;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private string m_textureName;

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xB17DF0", Offset = "0xB17DF0", VA = "0xB17DF0")]
		public void Setup(Material drawOldFrameMaterial, RenderTargetHandle handle, string textureName)
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xB18154", Offset = "0xB18154", VA = "0xB18154", Slot = "6")]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescripor)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xB181F8", Offset = "0xB181F8", VA = "0xB181F8", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xB17BCC", Offset = "0xB17BCC", VA = "0xB17BCC")]
		public DrawOldFramePass()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20000AB")]
	public class Settings
	{
		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("The material that is used when the old frame is redrawn at the start of the new frame (before opaques).")]
		public Material displayMaterial;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The name of the texture used for referencing the copied frame. (Defaults to _FrameCopyTex if empty)")]
		public string textureName;

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xB17EB0", Offset = "0xB17EB0", VA = "0xB17EB0")]
		public Settings()
		{
		}
	}

	[Token(Token = "0x4000430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private CopyFramePass m_CopyFrame;

	[Token(Token = "0x4000431")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private DrawOldFramePass m_DrawOldFame;

	[Token(Token = "0x4000432")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RenderTargetHandle m_OldFrameHandle;

	[Token(Token = "0x4000433")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Settings settings;

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0xB17AF8", Offset = "0xB17AF8", VA = "0xB17AF8", Slot = "5")]
	public override void Create()
	{
	}

	[Token(Token = "0x60003F9")]
	[Address(RVA = "0xB17BD4", Offset = "0xB17BD4", VA = "0xB17BD4", Slot = "7")]
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0xB17E3C", Offset = "0xB17E3C", VA = "0xB17E3C")]
	public KeepFrameFeature()
	{
	}
}
[Token(Token = "0x20000AC")]
[ExecuteAlways]
public class AutoLoadPipelineAsset : MonoBehaviour
{
	[Token(Token = "0x400043B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UniversalRenderPipelineAsset m_PipelineAsset;

	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RenderPipelineAsset m_PreviousPipelineAsset;

	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_overrodeQualitySettings;

	[Token(Token = "0x6000408")]
	[Address(RVA = "0xB184B0", Offset = "0xB184B0", VA = "0xB184B0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0xB1861C", Offset = "0xB1861C", VA = "0xB1861C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0xB184B4", Offset = "0xB184B4", VA = "0xB184B4")]
	private void UpdatePipeline()
	{
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0xB18620", Offset = "0xB18620", VA = "0xB18620")]
	private void ResetPipeline()
	{
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0xB186AC", Offset = "0xB186AC", VA = "0xB186AC")]
	public AutoLoadPipelineAsset()
	{
	}
}
[Token(Token = "0x20000AD")]
[RequireComponent(typeof(CharacterController))]
public class FirstPersonController : MonoBehaviour
{
	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float m_MouseSensitivity;

	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float m_MovementSpeed;

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform m_PlayerCamera;

	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool m_MoveWithMouse;

	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CharacterController m_CharacterController;

	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float m_XRotation;

	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private byte m_ButtonMovementFlags;

	[Token(Token = "0x600040D")]
	[Address(RVA = "0xB186B4", Offset = "0xB186B4", VA = "0xB186B4")]
	private void Start()
	{
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0xB18754", Offset = "0xB18754", VA = "0xB18754")]
	private void Update()
	{
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0xB1876C", Offset = "0xB1876C", VA = "0xB1876C")]
	private void Look()
	{
	}

	[Token(Token = "0x6000410")]
	[Address(RVA = "0xB18854", Offset = "0xB18854", VA = "0xB18854")]
	private void Move()
	{
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0xB18944", Offset = "0xB18944", VA = "0xB18944")]
	private Vector2 GetLookInput()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0xB18A08", Offset = "0xB18A08", VA = "0xB18A08")]
	private Vector3 GetMovementInput()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0xB18AA0", Offset = "0xB18AA0", VA = "0xB18AA0")]
	public FirstPersonController()
	{
	}
}
[Token(Token = "0x20000AE")]
public class VoxelBeamStatic : MonoBehaviour
{
	[Token(Token = "0x4000445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Prefabs")]
	public GameObject beamLineRendererPrefab;

	[Token(Token = "0x4000446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject beamStartPrefab;

	[Token(Token = "0x4000447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject beamEndPrefab;

	[Token(Token = "0x4000448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject beamStart;

	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject beamEnd;

	[Token(Token = "0x400044A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject beam;

	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private LineRenderer line;

	[Token(Token = "0x400044C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Header("Beam Options")]
	public bool alwaysOn;

	[Token(Token = "0x400044D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool beamCollides;

	[Token(Token = "0x400044E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float beamLength;

	[Token(Token = "0x400044F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float beamEndOffset;

	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float textureScrollSpeed;

	[Token(Token = "0x4000451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float textureLengthScale;

	[Token(Token = "0x6000414")]
	[Address(RVA = "0xB18ABC", Offset = "0xB18ABC", VA = "0xB18ABC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0xB18AC0", Offset = "0xB18AC0", VA = "0xB18AC0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0xB18DA0", Offset = "0xB18DA0", VA = "0xB18DA0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000417")]
	[Address(RVA = "0xB18EB8", Offset = "0xB18EB8", VA = "0xB18EB8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0xB18AD0", Offset = "0xB18AD0", VA = "0xB18AD0")]
	public void SpawnBeam()
	{
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0xB18DA4", Offset = "0xB18DA4", VA = "0xB18DA4")]
	public void RemoveBeam()
	{
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0xB192BC", Offset = "0xB192BC", VA = "0xB192BC")]
	public VoxelBeamStatic()
	{
	}
}
namespace VoxelArsenal
{
	[Token(Token = "0x20000AF")]
	public class VoxelBeamScript : MonoBehaviour
	{
		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Prefabs")]
		public GameObject[] beamLineRendererPrefab;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject[] beamStartPrefab;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject[] beamEndPrefab;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int currentBeam;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject beamStart;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject beamEnd;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GameObject beam;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private LineRenderer line;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("Adjustable Variables")]
		public float beamEndOffset;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float textureScrollSpeed;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float textureLengthScale;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("Put Sliders here (Optional)")]
		public Slider endOffSetSlider;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Slider scrollSpeedSlider;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Header("Put UI Text object here to show beam name")]
		public Text textBeamName;

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xB192DC", Offset = "0xB192DC", VA = "0xB192DC")]
		private void Start()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xB1941C", Offset = "0xB1941C", VA = "0xB1941C")]
		private void Update()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xB19C78", Offset = "0xB19C78", VA = "0xB19C78")]
		public void nextBeam()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xB19D58", Offset = "0xB19D58", VA = "0xB19D58")]
		public void previousBeam()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xB19E38", Offset = "0xB19E38", VA = "0xB19E38")]
		public void UpdateEndOffset()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xB19E68", Offset = "0xB19E68", VA = "0xB19E68")]
		public void UpdateScrollSpeed()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xB19854", Offset = "0xB19854", VA = "0xB19854")]
		private void ShootBeamInDir(Vector3 start, Vector3 dir)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xB19E98", Offset = "0xB19E98", VA = "0xB19E98")]
		public VoxelBeamScript()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class VoxelButtonScript : MonoBehaviour
	{
		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject Button;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Text MyButtonText;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string projectileParticleName;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private VoxelFireProjectile effectScript;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private VoxelProjectileScript projectileScript;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float buttonsX;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float buttonsY;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float buttonsSizeX;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float buttonsSizeY;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float buttonsDistance;

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xB19EB4", Offset = "0xB19EB4", VA = "0xB19EB4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xB1A070", Offset = "0xB1A070", VA = "0xB1A070")]
		private void Update()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xB19FBC", Offset = "0xB19FBC", VA = "0xB19FBC")]
		public void getProjectileNames()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xB1A09C", Offset = "0xB1A09C", VA = "0xB1A09C")]
		public bool overButton()
		{
			return default(bool);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xB1A174", Offset = "0xB1A174", VA = "0xB1A174")]
		public VoxelButtonScript()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public class VoxelFireProjectile : MonoBehaviour
	{
		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public GameObject[] projectiles;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Missile spawns at attached game object")]
		public Transform spawnPosition;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public int currentProjectile;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float speed;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private VoxelButtonScript selectedProjectileButton;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RaycastHit hit;

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xB1A17C", Offset = "0xB1A17C", VA = "0xB1A17C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xB1A1F8", Offset = "0xB1A1F8", VA = "0xB1A1F8")]
		private void Update()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xB1A5C8", Offset = "0xB1A5C8", VA = "0xB1A5C8")]
		public void nextEffect()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xB1A604", Offset = "0xB1A604", VA = "0xB1A604")]
		public void previousEffect()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xB1A640", Offset = "0xB1A640", VA = "0xB1A640")]
		public void AdjustSpeed(float newSpeed)
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xB1A648", Offset = "0xB1A648", VA = "0xB1A648")]
		public VoxelFireProjectile()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public class VoxelLoopScript : MonoBehaviour
	{
		[Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class <EffectLoop>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VoxelLoopScript <>4__this;

			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private GameObject <effectPlayer>5__2;

			[Token(Token = "0x17000023")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000435")]
				[Address(RVA = "0xB1A8D8", Offset = "0xB1A8D8", VA = "0xB1A8D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000024")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000437")]
				[Address(RVA = "0xB1A920", Offset = "0xB1A920", VA = "0xB1A920", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000432")]
			[Address(RVA = "0xB1A71C", Offset = "0xB1A71C", VA = "0xB1A71C")]
			[DebuggerHidden]
			public <EffectLoop>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000433")]
			[Address(RVA = "0xB1A754", Offset = "0xB1A754", VA = "0xB1A754", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000434")]
			[Address(RVA = "0xB1A758", Offset = "0xB1A758", VA = "0xB1A758", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000436")]
			[Address(RVA = "0xB1A8E0", Offset = "0xB1A8E0", VA = "0xB1A8E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Attach effect here")]
		public GameObject chosenEffect;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float loopDuration;

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xB1A658", Offset = "0xB1A658", VA = "0xB1A658")]
		private void Start()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xB1A65C", Offset = "0xB1A65C", VA = "0xB1A65C")]
		public void PlayEffect()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xB1A6A8", Offset = "0xB1A6A8", VA = "0xB1A6A8")]
		[IteratorStateMachine(typeof(<EffectLoop>d__4))]
		private IEnumerator EffectLoop()
		{
			return null;
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xB1A744", Offset = "0xB1A744", VA = "0xB1A744")]
		public VoxelLoopScript()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class VoxelOrbit : MonoBehaviour
	{
		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float distance;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float xSpeed;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float ySpeed;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float yMinLimit;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float yMaxLimit;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float distanceMin;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float distanceMax;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float smoothTime;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float rotationYAxis;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float rotationXAxis;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float velocityX;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float velocityY;

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xB1A928", Offset = "0xB1A928", VA = "0xB1A928")]
		private void Start()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xB1A9F4", Offset = "0xB1A9F4", VA = "0xB1A9F4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xB1AD70", Offset = "0xB1AD70", VA = "0xB1AD70")]
		public static float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xB1ADAC", Offset = "0xB1ADAC", VA = "0xB1ADAC")]
		public VoxelOrbit()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	public class VoxelProjectileScript : MonoBehaviour
	{
		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject impactParticle;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject projectileParticle;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject muzzleParticle;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Adjust if not using Sphere Collider")]
		public float colliderRadius;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float collideOffset;

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xB1ADC8", Offset = "0xB1ADC8", VA = "0xB1ADC8")]
		private void Start()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xB1AFF0", Offset = "0xB1AFF0", VA = "0xB1AFF0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xB1B638", Offset = "0xB1B638", VA = "0xB1B638")]
		public VoxelProjectileScript()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public class VoxelSceneSelect : MonoBehaviour
	{
		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool GUIHide;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool GUIHide2;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool GUIHide3;

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xB1B64C", Offset = "0xB1B64C", VA = "0xB1B64C")]
		public void LoadSceneDemoMissiles()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xB1B6B4", Offset = "0xB1B6B4", VA = "0xB1B6B4")]
		public void LoadSceneDemoBeams()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xB1B71C", Offset = "0xB1B71C", VA = "0xB1B71C")]
		public void LoadSceneDemo01()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xB1B784", Offset = "0xB1B784", VA = "0xB1B784")]
		public void LoadSceneDemo02()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xB1B7EC", Offset = "0xB1B7EC", VA = "0xB1B7EC")]
		public void LoadSceneDemo03()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xB1B854", Offset = "0xB1B854", VA = "0xB1B854")]
		public void LoadSceneDemo04()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xB1B8BC", Offset = "0xB1B8BC", VA = "0xB1B8BC")]
		public void LoadSceneDemo05()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xB1B924", Offset = "0xB1B924", VA = "0xB1B924")]
		public void LoadSceneDemo06()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xB1B98C", Offset = "0xB1B98C", VA = "0xB1B98C")]
		public void LoadSceneDemo07()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xB1B9F4", Offset = "0xB1B9F4", VA = "0xB1B9F4")]
		public void LoadSceneDemo08()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xB1BA5C", Offset = "0xB1BA5C", VA = "0xB1BA5C")]
		public void LoadSceneDemo09()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xB1BAC4", Offset = "0xB1BAC4", VA = "0xB1BAC4")]
		public void LoadSceneDemo10()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xB1BB2C", Offset = "0xB1BB2C", VA = "0xB1BB2C")]
		public void LoadSceneDemo11()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xB1BB94", Offset = "0xB1BB94", VA = "0xB1BB94")]
		public void LoadSceneDemo12()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xB1BBFC", Offset = "0xB1BBFC", VA = "0xB1BBFC")]
		public void LoadSceneDemo13()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xB1BC64", Offset = "0xB1BC64", VA = "0xB1BC64")]
		public void LoadSceneDemo14()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xB1BCCC", Offset = "0xB1BCCC", VA = "0xB1BCCC")]
		public void LoadSceneDemo15()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xB1BD34", Offset = "0xB1BD34", VA = "0xB1BD34")]
		public void LoadSceneDemo16()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xB1BD9C", Offset = "0xB1BD9C", VA = "0xB1BD9C")]
		public void LoadSceneDemo17()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xB1BE04", Offset = "0xB1BE04", VA = "0xB1BE04")]
		public void LoadSceneDemo18()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xB1BE6C", Offset = "0xB1BE6C", VA = "0xB1BE6C")]
		public void LoadSceneDemo19()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xB1BED4", Offset = "0xB1BED4", VA = "0xB1BED4")]
		public void LoadSceneDemo20()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xB1BF3C", Offset = "0xB1BF3C", VA = "0xB1BF3C")]
		public void LoadSceneDemo21()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xB1BFA4", Offset = "0xB1BFA4", VA = "0xB1BFA4")]
		public void LoadSceneDemo22()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xB1C00C", Offset = "0xB1C00C", VA = "0xB1C00C")]
		public void LoadSceneDemo23()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xB1C074", Offset = "0xB1C074", VA = "0xB1C074")]
		private void Update()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xB1C1D4", Offset = "0xB1C1D4", VA = "0xB1C1D4")]
		public VoxelSceneSelect()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class VoxelTarget : MonoBehaviour
	{
		[Token(Token = "0x20000B8")]
		[CompilerGenerated]
		private sealed class <Respawn>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400048F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VoxelTarget <>4__this;

			[Token(Token = "0x17000025")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000462")]
				[Address(RVA = "0xB1C6BC", Offset = "0xB1C6BC", VA = "0xB1C6BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000026")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000464")]
				[Address(RVA = "0xB1C704", Offset = "0xB1C704", VA = "0xB1C704", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0xB1C5DC", Offset = "0xB1C5DC", VA = "0xB1C5DC")]
			[DebuggerHidden]
			public <Respawn>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0xB1C60C", Offset = "0xB1C60C", VA = "0xB1C60C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0xB1C610", Offset = "0xB1C610", VA = "0xB1C610", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0xB1C6C4", Offset = "0xB1C6C4", VA = "0xB1C6C4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Effect shown on target hit")]
		public GameObject hitParticle;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Effect shown on target respawn")]
		public GameObject respawnParticle;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Renderer targetRenderer;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Collider targetCollider;

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xB1C1DC", Offset = "0xB1C1DC", VA = "0xB1C1DC")]
		private void Start()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xB1C26C", Offset = "0xB1C26C", VA = "0xB1C26C")]
		private void SpawnTarget()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xB1C39C", Offset = "0xB1C39C", VA = "0xB1C39C")]
		private void OnTriggerEnter(Collider col)
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xB1C568", Offset = "0xB1C568", VA = "0xB1C568")]
		[IteratorStateMachine(typeof(<Respawn>d__7))]
		private IEnumerator Respawn()
		{
			return null;
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xB1C604", Offset = "0xB1C604", VA = "0xB1C604")]
		public VoxelTarget()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public class VoxelLightFade : MonoBehaviour
	{
		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Seconds to dim the light")]
		public float life;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool killAfterLife;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Light li;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float initIntensity;

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xB1C70C", Offset = "0xB1C70C", VA = "0xB1C70C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xB1C828", Offset = "0xB1C828", VA = "0xB1C828")]
		private void Update()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xB1C964", Offset = "0xB1C964", VA = "0xB1C964")]
		public VoxelLightFade()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public class VoxelRotation : MonoBehaviour
	{
		[Token(Token = "0x20000BB")]
		public enum spaceEnum
		{
			[Token(Token = "0x4000499")]
			Local,
			[Token(Token = "0x400049A")]
			World
		}

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Rotate axises by degrees per second")]
		public Vector3 rotateVector;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public spaceEnum rotateSpace;

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xB1C980", Offset = "0xB1C980", VA = "0xB1C980")]
		private void Start()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xB1C984", Offset = "0xB1C984", VA = "0xB1C984")]
		private void Update()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xB1CA58", Offset = "0xB1CA58", VA = "0xB1CA58")]
		public VoxelRotation()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class VoxelSoundSpawn : MonoBehaviour
	{
		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject prefabSound;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool destroyWhenDone;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool soundPrefabIsChild;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0.01f, 10f)]
		public float pitchRandomMultiplier;

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xB1CAB8", Offset = "0xB1CAB8", VA = "0xB1CAB8")]
		private void Start()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xB1CD0C", Offset = "0xB1CD0C", VA = "0xB1CD0C")]
		public VoxelSoundSpawn()
		{
		}
	}
}
namespace Pixelplacement
{
	[Token(Token = "0x20000BD")]
	public class Chooser : MonoBehaviour
	{
		[Token(Token = "0x20000BE")]
		public enum Method
		{
			[Token(Token = "0x40004C1")]
			Raycast,
			[Token(Token = "0x40004C2")]
			RaycastAll
		}

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObjectEvent OnSelected;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObjectEvent OnDeselected;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObjectEvent OnPressed;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObjectEvent OnReleased;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool _cursorPropertiesFolded;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool _unityEventsFolded;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform source;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastDistance;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public LayerMask layermask;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public KeyCode[] pressedInput;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform cursor;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float surfaceOffset;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float idleDistance;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float stabilityDelta;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float snapDelta;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float stableSpeed;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float unstableSpeed;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool flipForward;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		public bool matchSurfaceNormal;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
		public bool autoHide;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7B")]
		public bool cursorHidden;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool flipCastDirection;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public LineRenderer lineRenderer;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private Method _method;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool _debugView;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Transform _previousCursor;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<Transform> _current;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private List<Transform> _previous;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform _currentRaycast;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Transform _previousRaycast;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3 _targetPosition;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private bool _hidden;

		[Token(Token = "0x17000027")]
		public Transform[] Current
		{
			[Token(Token = "0x600046D")]
			[Address(RVA = "0xB1CD24", Offset = "0xB1CD24", VA = "0xB1CD24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		public bool IsHitting
		{
			[Token(Token = "0x600046E")]
			[Address(RVA = "0xB1CD74", Offset = "0xB1CD74", VA = "0xB1CD74")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600046F")]
			[Address(RVA = "0xB1CD7C", Offset = "0xB1CD7C", VA = "0xB1CD7C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xB1CD88", Offset = "0xB1CD88", VA = "0xB1CD88")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xB1CE18", Offset = "0xB1CE18", VA = "0xB1CE18")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xB1CF74", Offset = "0xB1CF74", VA = "0xB1CF74")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xB1D044", Offset = "0xB1D044", VA = "0xB1D044")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xB1D1B8", Offset = "0xB1D1B8", VA = "0xB1D1B8")]
		public void Pressed()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xB1D408", Offset = "0xB1D408", VA = "0xB1D408")]
		public void Released()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xB1D658", Offset = "0xB1D658", VA = "0xB1D658")]
		private void Update()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xB1E928", Offset = "0xB1E928", VA = "0xB1E928")]
		public Chooser()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	internal interface IChooser
	{
		[Token(Token = "0x6000478")]
		void Selected();

		[Token(Token = "0x6000479")]
		void Deselected();

		[Token(Token = "0x600047A")]
		void Pressed();

		[Token(Token = "0x600047B")]
		void Released();
	}
	[Token(Token = "0x20000C0")]
	[RequireComponent(typeof(Collider))]
	[RequireComponent(typeof(Rigidbody))]
	[ExecuteInEditMode]
	public sealed class ColliderButton : MonoBehaviour
	{
		[Token(Token = "0x20000C1")]
		public enum EaseType
		{
			[Token(Token = "0x40004FA")]
			EaseOut,
			[Token(Token = "0x40004FB")]
			EaseOutBack
		}

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ColliderButtonEvent OnSelected;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ColliderButtonEvent OnDeselected;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ColliderButtonEvent OnClick;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ColliderButtonEvent OnPressed;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ColliderButtonEvent OnReleased;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public KeyCode[] keyInput;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool _unityEventsFolded;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool _scaleResponseFolded;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		public bool _colorResponseFolded;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
		public bool applyColor;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool applyScale;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public LayerMask collisionLayerMask;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Renderer colorRendererTarget;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Image colorImageTarget;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Color selectedColor;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Color pressedColor;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Color disabledColor;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float colorDuration;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Transform scaleTarget;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Vector3 normalScale;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public Vector3 selectedScale;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Vector3 pressedScale;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float scaleDuration;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public EaseType scaleEaseType;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public bool resizeGUIBoxCollider;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDD")]
		public bool centerGUIBoxCollider;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Vector2 guiBoxColliderPadding;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public bool interactable;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
		private bool _clicking;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private int _selectedCount;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool _colliderSelected;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		private bool _pressed;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF2")]
		private bool _released;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF3")]
		private bool _vrRunning;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private RectTransform _rectTransform;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private EventTrigger _eventTrigger;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private EventTrigger.Entry _pressedEventTrigger;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private EventTrigger.Entry _releasedEventTrigger;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private EventTrigger.Entry _enterEventTrigger;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private EventTrigger.Entry _exitEventTrigger;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private int _colliderCount;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private BoxCollider _boxCollider;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private TweenBase _colorTweenImage;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private TweenBase _colorTweenMaterial;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private TweenBase _scaleTween;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Color _normalColorRenderer;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Color _normalColorImage;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private bool _interactableStatus;

		[Token(Token = "0x17000029")]
		public bool IsSelected
		{
			[Token(Token = "0x6000486")]
			[Address(RVA = "0xB1F22C", Offset = "0xB1F22C", VA = "0xB1F22C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000487")]
			[Address(RVA = "0xB1F234", Offset = "0xB1F234", VA = "0xB1F234")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public static event Action<ColliderButton> OnSelectedGlobal
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0xB1EA14", Offset = "0xB1EA14", VA = "0xB1EA14")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600047D")]
			[Address(RVA = "0xB1EAE0", Offset = "0xB1EAE0", VA = "0xB1EAE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public static event Action<ColliderButton> OnDeselectedGlobal
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0xB1EBAC", Offset = "0xB1EBAC", VA = "0xB1EBAC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600047F")]
			[Address(RVA = "0xB1EC7C", Offset = "0xB1EC7C", VA = "0xB1EC7C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public static event Action<ColliderButton> OnClickGlobal
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0xB1ED4C", Offset = "0xB1ED4C", VA = "0xB1ED4C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000481")]
			[Address(RVA = "0xB1EE1C", Offset = "0xB1EE1C", VA = "0xB1EE1C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public static event Action<ColliderButton> OnPressedGlobal
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0xB1EEEC", Offset = "0xB1EEEC", VA = "0xB1EEEC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000483")]
			[Address(RVA = "0xB1EFBC", Offset = "0xB1EFBC", VA = "0xB1EFBC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public static event Action<ColliderButton> OnReleasedGlobal
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0xB1F08C", Offset = "0xB1F08C", VA = "0xB1F08C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000485")]
			[Address(RVA = "0xB1F15C", Offset = "0xB1F15C", VA = "0xB1F15C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xB1F240", Offset = "0xB1F240", VA = "0xB1F240")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xB1F3D8", Offset = "0xB1F3D8", VA = "0xB1F3D8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xB1FD4C", Offset = "0xB1FD4C", VA = "0xB1FD4C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xB1FEC4", Offset = "0xB1FEC4", VA = "0xB1FEC4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xB1FF3C", Offset = "0xB1FF3C", VA = "0xB1FF3C")]
		private void Update()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xB208AC", Offset = "0xB208AC", VA = "0xB208AC")]
		private void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xB208C4", Offset = "0xB208C4", VA = "0xB208C4")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xB208D4", Offset = "0xB208D4", VA = "0xB208D4")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xB208E4", Offset = "0xB208E4", VA = "0xB208E4")]
		private void OnPointerDownDelegate(PointerEventData data)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xB2094C", Offset = "0xB2094C", VA = "0xB2094C")]
		private void OnPointerUpDelegate(PointerEventData data)
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xB209B4", Offset = "0xB209B4", VA = "0xB209B4")]
		private void OnPointerEnterDelegate(PointerEventData data)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xB209B8", Offset = "0xB209B8", VA = "0xB209B8")]
		private void OnPointerExitDelegate(PointerEventData data)
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xB209BC", Offset = "0xB209BC", VA = "0xB209BC")]
		private void OnMouseDown()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xB20A2C", Offset = "0xB20A2C", VA = "0xB20A2C")]
		private void OnMouseUp()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xB20AB0", Offset = "0xB20AB0", VA = "0xB20AB0")]
		private void OnMouseEnter()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xB20AE0", Offset = "0xB20AE0", VA = "0xB20AE0")]
		private void OnMouseExit()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xB205F8", Offset = "0xB205F8", VA = "0xB205F8")]
		public void Deselected()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xB20534", Offset = "0xB20534", VA = "0xB20534")]
		public void Selected()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xB206C8", Offset = "0xB206C8", VA = "0xB206C8")]
		public void Pressed()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xB207A4", Offset = "0xB207A4", VA = "0xB207A4")]
		public void Released()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xB1FBFC", Offset = "0xB1FBFC", VA = "0xB1FBFC")]
		private void ResizeGUIBoxCollider(BoxCollider boxCollider)
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xB1FD74", Offset = "0xB1FD74", VA = "0xB1FD74")]
		private void ColorReset()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xB20164", Offset = "0xB20164", VA = "0xB20164")]
		private void ColorNormal()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xB20C18", Offset = "0xB20C18", VA = "0xB20C18")]
		private void ColorSelected()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xB20F20", Offset = "0xB20F20", VA = "0xB20F20")]
		private void ColorPressed()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xB20354", Offset = "0xB20354", VA = "0xB20354")]
		private void ColorDisabled()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xB1FF04", Offset = "0xB1FF04", VA = "0xB1FF04")]
		private void ScaleReset()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xB20AF0", Offset = "0xB20AF0", VA = "0xB20AF0")]
		private void ScaleNormal()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xB20DF8", Offset = "0xB20DF8", VA = "0xB20DF8")]
		private void ScaleSelected()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xB21100", Offset = "0xB21100", VA = "0xB21100")]
		private void ScalePressed()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xB21218", Offset = "0xB21218", VA = "0xB21218")]
		public ColliderButton()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	[RequireComponent(typeof(Initialization))]
	public class DisplayObject : MonoBehaviour
	{
		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _activated;

		[Token(Token = "0x1700002A")]
		public bool ActiveSelf
		{
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0xB21480", Offset = "0xB21480", VA = "0xB21480")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0xB214A0", Offset = "0xB214A0", VA = "0xB214A0")]
			set
			{
			}
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xB214D8", Offset = "0xB214D8", VA = "0xB214D8")]
		public void Register()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xB214A8", Offset = "0xB214A8", VA = "0xB214A8")]
		public void SetActive(bool value)
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xB21514", Offset = "0xB21514", VA = "0xB21514")]
		public void Solo()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xB21A1C", Offset = "0xB21A1C", VA = "0xB21A1C")]
		public void HideAll()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xB21EA0", Offset = "0xB21EA0", VA = "0xB21EA0")]
		public DisplayObject()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C3")]
	public class GameObjectEvent : UnityEvent<GameObject>
	{
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xB21EA8", Offset = "0xB21EA8", VA = "0xB21EA8")]
		public GameObjectEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C4")]
	public class ColliderButtonEvent : UnityEvent<ColliderButton>
	{
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xB21EF0", Offset = "0xB21EF0", VA = "0xB21EF0")]
		public ColliderButtonEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C5")]
	public class BoolEvent : UnityEvent<bool>
	{
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xB21F38", Offset = "0xB21F38", VA = "0xB21F38")]
		public BoolEvent()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	[RequireComponent(typeof(Initialization))]
	public abstract class Singleton<T> : MonoBehaviour
	{
		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool _dontDestroyOnLoad;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T _instance;

		[Token(Token = "0x1700002B")]
		public static T Instance
		{
			[Token(Token = "0x60004B5")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x60004B6")]
		protected virtual void OnRegistration()
		{
		}

		[Token(Token = "0x60004B7")]
		public void RegisterSingleton(T instance)
		{
		}

		[Token(Token = "0x60004B8")]
		protected void Initialize(T instance)
		{
		}

		[Token(Token = "0x60004B9")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public static class BezierCurves
	{
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xB21F80", Offset = "0xB21F80", VA = "0xB21F80")]
		public static Vector3 GetPoint(Vector3 startPosition, Vector3 controlPoint, Vector3 endPosition, float percentage)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xB21FF4", Offset = "0xB21FF4", VA = "0xB21FF4")]
		public static Vector3 GetFirstDerivative(Vector3 startPoint, Vector3 controlPoint, Vector3 endPosition, float percentage)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xB22060", Offset = "0xB22060", VA = "0xB22060")]
		public static Vector3 GetPoint(Vector3 startPosition, Vector3 endPosition, Vector3 startTangent, Vector3 endTangent, float percentage, bool evenDistribution, int distributionSteps)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xB2247C", Offset = "0xB2247C", VA = "0xB2247C")]
		public static Vector3 GetFirstDerivative(Vector3 startPosition, Vector3 endPosition, Vector3 startTangent, Vector3 endTangent, float percentage)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xB223D0", Offset = "0xB223D0", VA = "0xB223D0")]
		private static Vector3 Locate(Vector3 startPosition, Vector3 endPosition, Vector3 startTangent, Vector3 endTangent, float percentage)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000C8")]
	public struct CurveDetail
	{
		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int currentCurve;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float currentCurvePercentage;

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xB2252C", Offset = "0xB2252C", VA = "0xB2252C")]
		public CurveDetail(int currentCurve, float currentCurvePercentage)
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public enum SplineDirection
	{
		[Token(Token = "0x4000502")]
		Forward,
		[Token(Token = "0x4000503")]
		Backwards
	}
	[Token(Token = "0x20000CA")]
	[ExecuteInEditMode]
	public class Spline : MonoBehaviour
	{
		[Token(Token = "0x20000CB")]
		private class SplineReparam
		{
			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float length;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float percentage;

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0xB240C4", Offset = "0xB240C4", VA = "0xB240C4")]
			public SplineReparam(float length, float percentage)
			{
			}
		}

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float toolScale;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public TangentMode defaultTangentMode;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SplineDirection direction;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool loop;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SplineFollower[] followers;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SplineAnchor[] _anchors;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _curveCount;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int _previousAnchorCount;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _previousChildCount;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool _wasLooping;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool _previousLoopChoice;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		private bool _anchorsChanged;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SplineDirection _previousDirection;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float _curvePercentage;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int _operatingCurve;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float _currentCurve;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int _previousLength;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int _slicesPerCurve;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<SplineReparam> _splineReparams;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool _lengthDirty;

		[Token(Token = "0x1700002C")]
		public float Length
		{
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0xB22670", Offset = "0xB22670", VA = "0xB22670")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0xB22678", Offset = "0xB22678", VA = "0xB22678")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public SplineAnchor[] Anchors
		{
			[Token(Token = "0x60004C4")]
			[Address(RVA = "0xB22680", Offset = "0xB22680", VA = "0xB22680")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public Color SecondaryColor
		{
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0xB2282C", Offset = "0xB2282C", VA = "0xB2282C")]
			get
			{
				return default(Color);
			}
		}

		[Token(Token = "0x14000006")]
		public event Action OnSplineChanged
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0xB22538", Offset = "0xB22538", VA = "0xB22538")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0xB225D4", Offset = "0xB225D4", VA = "0xB225D4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xB22860", Offset = "0xB22860", VA = "0xB22860")]
		private void Reset()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xB22F70", Offset = "0xB22F70", VA = "0xB22F70")]
		private void Update()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xB23260", Offset = "0xB23260", VA = "0xB23260")]
		private void HangleLengthChange()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xB23284", Offset = "0xB23284", VA = "0xB23284")]
		private float Reparam(float percent)
		{
			return default(float);
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xB23408", Offset = "0xB23408", VA = "0xB23408")]
		public void CalculateLength()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xB2388C", Offset = "0xB2388C", VA = "0xB2388C")]
		public Vector3 Up(float percentage, bool normalized = true)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xB23B38", Offset = "0xB23B38", VA = "0xB23B38")]
		public Vector3 Right(float percentage, bool normalized = true)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xB23BC0", Offset = "0xB23BC0", VA = "0xB23BC0")]
		public Vector3 Forward(float percentage, bool normalized = true)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xB23914", Offset = "0xB23914", VA = "0xB23914")]
		public Vector3 GetDirection(float percentage, bool normalized = true)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xB236D8", Offset = "0xB236D8", VA = "0xB236D8")]
		public Vector3 GetPosition(float percentage, bool normalized = true)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xB23D1C", Offset = "0xB23D1C", VA = "0xB23D1C")]
		public Vector3 GetPosition(float percentage, Vector3 relativeOffset, bool normalized = true)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xB23F14", Offset = "0xB23F14", VA = "0xB23F14")]
		public float ClosestPoint(Vector3 point, int divisions = 100)
		{
			return default(float);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xB228AC", Offset = "0xB228AC", VA = "0xB228AC")]
		public GameObject[] AddAnchors(int count)
		{
			return null;
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xB23BC8", Offset = "0xB23BC8", VA = "0xB23BC8")]
		public CurveDetail GetCurve(float percentage)
		{
			return default(CurveDetail);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xB24014", Offset = "0xB24014", VA = "0xB24014")]
		public Spline()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public enum TangentMode
	{
		[Token(Token = "0x400051E")]
		Mirrored,
		[Token(Token = "0x400051F")]
		Aligned,
		[Token(Token = "0x4000520")]
		Free
	}
	[Token(Token = "0x20000CD")]
	[ExecuteInEditMode]
	public class SplineAnchor : MonoBehaviour
	{
		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TangentMode tangentMode;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		private bool _initialized;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		private Transform _masterTangent;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HideInInspector]
		private Transform _slaveTangent;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TangentMode _previousTangentMode;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 _previousInPosition;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 _previousOutPosition;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 _previousAnchorPosition;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Bounds _skinnedBounds;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _anchor;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Transform _inTangent;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform _outTangent;

		[Token(Token = "0x1700002F")]
		public bool RenderingChange
		{
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0xB240F0", Offset = "0xB240F0", VA = "0xB240F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0xB240F8", Offset = "0xB240F8", VA = "0xB240F8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public bool Changed
		{
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0xB24104", Offset = "0xB24104", VA = "0xB24104")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0xB2410C", Offset = "0xB2410C", VA = "0xB2410C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public Transform Anchor
		{
			[Token(Token = "0x60004DA")]
			[Address(RVA = "0xB24118", Offset = "0xB24118", VA = "0xB24118")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0xB24574", Offset = "0xB24574", VA = "0xB24574")]
			private set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public Transform InTangent
		{
			[Token(Token = "0x60004DC")]
			[Address(RVA = "0xB2457C", Offset = "0xB2457C", VA = "0xB2457C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0xB245A0", Offset = "0xB245A0", VA = "0xB245A0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public Transform OutTangent
		{
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0xB245A8", Offset = "0xB245A8", VA = "0xB245A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0xB245CC", Offset = "0xB245CC", VA = "0xB245CC")]
			private set
			{
			}
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xB245D4", Offset = "0xB245D4", VA = "0xB245D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xB245D8", Offset = "0xB245D8", VA = "0xB245D8")]
		private void Update()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xB24900", Offset = "0xB24900", VA = "0xB24900")]
		private void TangentChanged()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xB2413C", Offset = "0xB2413C", VA = "0xB2413C")]
		private void Initialize()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xB24BF8", Offset = "0xB24BF8", VA = "0xB24BF8")]
		public void SetTangentStatus(bool inStatus, bool outStatus)
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xB24C78", Offset = "0xB24C78", VA = "0xB24C78")]
		public void Tilt(Vector3 angles)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xB24D94", Offset = "0xB24D94", VA = "0xB24D94")]
		public SplineAnchor()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CE")]
	public class SplineFollower
	{
		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform target;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float percentage;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool faceDirection;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float _previousPercentage;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool _previousFaceDirection;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		private bool _detached;

		[Token(Token = "0x17000034")]
		public bool WasMoved
		{
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0xB24D9C", Offset = "0xB24D9C", VA = "0xB24D9C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xB24DD4", Offset = "0xB24DD4", VA = "0xB24DD4")]
		public void UpdateOrientation(Spline spline)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xB24F2C", Offset = "0xB24F2C", VA = "0xB24F2C")]
		public SplineFollower()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	[SelectionBase]
	public class SplineTangent : MonoBehaviour
	{
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xB24F3C", Offset = "0xB24F3C", VA = "0xB24F3C")]
		public SplineTangent()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	[RequireComponent(typeof(Spline))]
	[ExecuteInEditMode]
	[RequireComponent(typeof(LineRenderer))]
	public class SplineRenderer : MonoBehaviour
	{
		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int segmentsPerCurve;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float startPercentage;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float endPercentage;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private LineRenderer _lineRenderer;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Spline _spline;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _initialized;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _previousAnchorsLength;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _previousSegmentsPerCurve;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int _vertexCount;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _previousStart;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float _previousEnd;

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xB24F44", Offset = "0xB24F44", VA = "0xB24F44")]
		private void Reset()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xB250A4", Offset = "0xB250A4", VA = "0xB250A4")]
		private void Update()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xB252F0", Offset = "0xB252F0", VA = "0xB252F0")]
		private void UpdateLineRenderer()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xB25268", Offset = "0xB25268", VA = "0xB25268")]
		private void ConfigureLineRenderer()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xB253B4", Offset = "0xB253B4", VA = "0xB253B4")]
		public SplineRenderer()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class State : MonoBehaviour
	{
		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private StateMachine _stateMachine;

		[Token(Token = "0x17000035")]
		public bool IsFirst
		{
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0xB253CC", Offset = "0xB253CC", VA = "0xB253CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000036")]
		public bool IsLast
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0xB253F8", Offset = "0xB253F8", VA = "0xB253F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000037")]
		public StateMachine StateMachine
		{
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0xB2545C", Offset = "0xB2545C", VA = "0xB2545C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xB25594", Offset = "0xB25594", VA = "0xB25594")]
		public void ChangeState(int childIndex)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xB256AC", Offset = "0xB256AC", VA = "0xB256AC")]
		public void ChangeState(GameObject state)
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xB25984", Offset = "0xB25984", VA = "0xB25984")]
		public void ChangeState(string state)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xB25A28", Offset = "0xB25A28", VA = "0xB25A28")]
		public GameObject Next()
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xB25B14", Offset = "0xB25B14", VA = "0xB25B14")]
		public GameObject Previous()
		{
			return null;
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xB25BDC", Offset = "0xB25BDC", VA = "0xB25BDC")]
		public void Exit()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xB25D98", Offset = "0xB25D98", VA = "0xB25D98")]
		public State()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	[RequireComponent(typeof(Initialization))]
	public class StateMachine : MonoBehaviour
	{
		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject defaultState;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject currentState;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool _unityEventsFolded;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[Tooltip("Should log messages be thrown during usage?")]
		public bool verbose;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		[Tooltip("Can States within this StateMachine be reentered?")]
		public bool allowReentry;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		[Tooltip("Return to default state on disable?")]
		public bool returnToDefaultOnDisable;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObjectEvent OnStateExited;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObjectEvent OnStateEntered;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityEvent OnFirstStateEntered;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UnityEvent OnFirstStateExited;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityEvent OnLastStateEntered;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UnityEvent OnLastStateExited;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool _initialized;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool _atFirst;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool _atLast;

		[Token(Token = "0x17000038")]
		public bool CleanSetup
		{
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0xB25DA0", Offset = "0xB25DA0", VA = "0xB25DA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0xB25DA8", Offset = "0xB25DA8", VA = "0xB25DA8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public bool AtFirst
		{
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0xB25DB4", Offset = "0xB25DB4", VA = "0xB25DB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0xB25DBC", Offset = "0xB25DBC", VA = "0xB25DBC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public bool AtLast
		{
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0xB25DF0", Offset = "0xB25DF0", VA = "0xB25DF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0xB25DF8", Offset = "0xB25DF8", VA = "0xB25DF8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xB25A40", Offset = "0xB25A40", VA = "0xB25A40")]
		public GameObject Next()
		{
			return null;
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xB25B2C", Offset = "0xB25B2C", VA = "0xB25B2C")]
		public GameObject Previous()
		{
			return null;
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xB25BF4", Offset = "0xB25BF4", VA = "0xB25BF4")]
		public void Exit()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xB255B4", Offset = "0xB255B4", VA = "0xB255B4")]
		public GameObject ChangeState(int childIndex)
		{
			return null;
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xB25EB4", Offset = "0xB25EB4", VA = "0xB25EB4")]
		public GameObject ChangeState(GameObject state)
		{
			return null;
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xB256EC", Offset = "0xB256EC", VA = "0xB256EC")]
		public GameObject ChangeState(string state)
		{
			return null;
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xB26478", Offset = "0xB26478", VA = "0xB26478")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0xB26500", Offset = "0xB26500", VA = "0xB26500")]
		public void StartMachine()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xB26318", Offset = "0xB26318", VA = "0xB26318")]
		private void Enter(GameObject state)
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xB25E2C", Offset = "0xB25E2C", VA = "0xB25E2C")]
		private void Log(string message)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xB2659C", Offset = "0xB2659C", VA = "0xB2659C")]
		public StateMachine()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class Tween
	{
		[Token(Token = "0x20000D4")]
		public enum TweenType
		{
			[Token(Token = "0x4000560")]
			Position,
			[Token(Token = "0x4000561")]
			Rotation,
			[Token(Token = "0x4000562")]
			LocalScale,
			[Token(Token = "0x4000563")]
			LightColor,
			[Token(Token = "0x4000564")]
			LightIntensity,
			[Token(Token = "0x4000565")]
			LightRange,
			[Token(Token = "0x4000566")]
			FieldOfView,
			[Token(Token = "0x4000567")]
			SpriteRendererColor,
			[Token(Token = "0x4000568")]
			RawImageColor,
			[Token(Token = "0x4000569")]
			ImageColor,
			[Token(Token = "0x400056A")]
			AnchoredPosition,
			[Token(Token = "0x400056B")]
			Size,
			[Token(Token = "0x400056C")]
			Volume,
			[Token(Token = "0x400056D")]
			Pitch,
			[Token(Token = "0x400056E")]
			PanStereo,
			[Token(Token = "0x400056F")]
			ShaderFloat,
			[Token(Token = "0x4000570")]
			ShaderColor,
			[Token(Token = "0x4000571")]
			ShaderInt,
			[Token(Token = "0x4000572")]
			ShaderVector,
			[Token(Token = "0x4000573")]
			Value,
			[Token(Token = "0x4000574")]
			TextMeshColor,
			[Token(Token = "0x4000575")]
			GUITextColor,
			[Token(Token = "0x4000576")]
			TextColor,
			[Token(Token = "0x4000577")]
			CanvasGroupAlpha,
			[Token(Token = "0x4000578")]
			Spline
		}

		[Token(Token = "0x20000D5")]
		public enum LoopType
		{
			[Token(Token = "0x400057A")]
			None,
			[Token(Token = "0x400057B")]
			Loop,
			[Token(Token = "0x400057C")]
			PingPong
		}

		[Token(Token = "0x20000D6")]
		public enum TweenStatus
		{
			[Token(Token = "0x400057E")]
			Delayed,
			[Token(Token = "0x400057F")]
			Running,
			[Token(Token = "0x4000580")]
			Canceled,
			[Token(Token = "0x4000581")]
			Stopped,
			[Token(Token = "0x4000582")]
			Finished
		}

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<TweenBase> activeTweens;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static TweenEngine _instance;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static AnimationCurve _easeIn;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static AnimationCurve _easeInStrong;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static AnimationCurve _easeOut;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static AnimationCurve _easeOutStrong;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static AnimationCurve _easeInOut;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static AnimationCurve _easeInOutStrong;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static AnimationCurve _easeInBack;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static AnimationCurve _easeOutBack;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static AnimationCurve _easeInOutBack;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static AnimationCurve _easeSpring;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static AnimationCurve _easeBounce;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static AnimationCurve _easeWobble;

		[Token(Token = "0x1700003B")]
		public static TweenEngine Instance
		{
			[Token(Token = "0x600050B")]
			[Address(RVA = "0xB265B0", Offset = "0xB265B0", VA = "0xB265B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public static AnimationCurve EaseLinear
		{
			[Token(Token = "0x6000559")]
			[Address(RVA = "0xB26918", Offset = "0xB26918", VA = "0xB26918")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public static AnimationCurve EaseIn
		{
			[Token(Token = "0x600055A")]
			[Address(RVA = "0xB2DB3C", Offset = "0xB2DB3C", VA = "0xB2DB3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public static AnimationCurve EaseInStrong
		{
			[Token(Token = "0x600055B")]
			[Address(RVA = "0xB2DCE4", Offset = "0xB2DCE4", VA = "0xB2DCE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public static AnimationCurve EaseOut
		{
			[Token(Token = "0x600055C")]
			[Address(RVA = "0xB2E028", Offset = "0xB2E028", VA = "0xB2E028")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public static AnimationCurve EaseOutStrong
		{
			[Token(Token = "0x600055D")]
			[Address(RVA = "0xB2E1D0", Offset = "0xB2E1D0", VA = "0xB2E1D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public static AnimationCurve EaseInOut
		{
			[Token(Token = "0x600055E")]
			[Address(RVA = "0xB2E50C", Offset = "0xB2E50C", VA = "0xB2E50C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public static AnimationCurve EaseInOutStrong
		{
			[Token(Token = "0x600055F")]
			[Address(RVA = "0xB2E5C8", Offset = "0xB2E5C8", VA = "0xB2E5C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public static AnimationCurve EaseInBack
		{
			[Token(Token = "0x6000560")]
			[Address(RVA = "0xB2E7DC", Offset = "0xB2E7DC", VA = "0xB2E7DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public static AnimationCurve EaseOutBack
		{
			[Token(Token = "0x6000561")]
			[Address(RVA = "0xB2E988", Offset = "0xB2E988", VA = "0xB2E988")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public static AnimationCurve EaseInOutBack
		{
			[Token(Token = "0x6000562")]
			[Address(RVA = "0xB2EB34", Offset = "0xB2EB34", VA = "0xB2EB34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public static AnimationCurve EaseSpring
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0xB2ECEC", Offset = "0xB2ECEC", VA = "0xB2ECEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public static AnimationCurve EaseBounce
		{
			[Token(Token = "0x6000564")]
			[Address(RVA = "0xB2EFC0", Offset = "0xB2EFC0", VA = "0xB2EFC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public static AnimationCurve EaseWobble
		{
			[Token(Token = "0x6000565")]
			[Address(RVA = "0xB2F418", Offset = "0xB2F418", VA = "0xB2F418")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xB267F4", Offset = "0xB267F4", VA = "0xB267F4")]
		public static TweenBase Shake(Transform target, Vector3 initialPosition, Vector3 intensity, float duration, float delay, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xB26AC8", Offset = "0xB26AC8", VA = "0xB26AC8")]
		public static TweenBase Spline(Spline spline, Transform target, float startPercentage, float endPercentage, bool faceDirection, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xB26D14", Offset = "0xB26D14", VA = "0xB26D14")]
		public static TweenBase CanvasGroupAlpha(CanvasGroup target, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xB26ECC", Offset = "0xB26ECC", VA = "0xB26ECC")]
		public static TweenBase CanvasGroupAlpha(CanvasGroup target, float startValue, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xB26F9C", Offset = "0xB26F9C", VA = "0xB26F9C")]
		public static TweenBase Value(Rect startValue, Rect endValue, Action<Rect> valueUpdatedCallback, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xB271D0", Offset = "0xB271D0", VA = "0xB271D0")]
		public static TweenBase Value(Vector4 startValue, Vector4 endValue, Action<Vector4> valueUpdatedCallback, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xB27404", Offset = "0xB27404", VA = "0xB27404")]
		public static TweenBase Value(Vector3 startValue, Vector3 endValue, Action<Vector3> valueUpdatedCallback, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xB27610", Offset = "0xB27610", VA = "0xB27610")]
		public static TweenBase Value(Vector2 startValue, Vector2 endValue, Action<Vector2> valueUpdatedCallback, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xB277EC", Offset = "0xB277EC", VA = "0xB277EC")]
		public static TweenBase Value(Color startValue, Color endValue, Action<Color> valueUpdatedCallback, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xB27A20", Offset = "0xB27A20", VA = "0xB27A20")]
		public static TweenBase Value(int startValue, int endValue, Action<int> valueUpdatedCallback, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xB27BE4", Offset = "0xB27BE4", VA = "0xB27BE4")]
		public static TweenBase Value(float startValue, float endValue, Action<float> valueUpdatedCallback, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xB27D98", Offset = "0xB27D98", VA = "0xB27D98")]
		public static TweenBase ShaderVector(Material target, string propertyName, Vector4 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xB27FB4", Offset = "0xB27FB4", VA = "0xB27FB4")]
		public static TweenBase ShaderVector(Material target, string propertyName, Vector4 startValue, Vector4 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xB280D0", Offset = "0xB280D0", VA = "0xB280D0")]
		public static TweenBase ShaderInt(Material target, string propertyName, int endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xB282AC", Offset = "0xB282AC", VA = "0xB282AC")]
		public static TweenBase ShaderInt(Material target, string propertyName, int startValue, int endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xB28390", Offset = "0xB28390", VA = "0xB28390")]
		public static TweenBase ShaderColor(Material target, string propertyName, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xB285AC", Offset = "0xB285AC", VA = "0xB285AC")]
		public static TweenBase ShaderColor(Material target, string propertyName, Color startValue, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xB286C8", Offset = "0xB286C8", VA = "0xB286C8")]
		public static TweenBase ShaderFloat(Material target, string propertyName, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xB288AC", Offset = "0xB288AC", VA = "0xB288AC")]
		public static TweenBase ShaderFloat(Material target, string propertyName, float startValue, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xB28990", Offset = "0xB28990", VA = "0xB28990")]
		public static TweenBase Pitch(AudioSource target, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xB28B48", Offset = "0xB28B48", VA = "0xB28B48")]
		public static TweenBase Pitch(AudioSource target, float startValue, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xB28C18", Offset = "0xB28C18", VA = "0xB28C18")]
		public static TweenBase PanStereo(AudioSource target, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xB28DD0", Offset = "0xB28DD0", VA = "0xB28DD0")]
		public static TweenBase PanStereo(AudioSource target, float startValue, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xB28EA0", Offset = "0xB28EA0", VA = "0xB28EA0")]
		public static TweenBase Volume(AudioSource target, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xB29058", Offset = "0xB29058", VA = "0xB29058")]
		public static TweenBase Volume(AudioSource target, float startValue, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xB29128", Offset = "0xB29128", VA = "0xB29128")]
		public static TweenBase Size(RectTransform target, Vector2 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xB292EC", Offset = "0xB292EC", VA = "0xB292EC")]
		public static TweenBase Size(RectTransform target, Vector2 startValue, Vector2 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xB293D4", Offset = "0xB293D4", VA = "0xB293D4")]
		public static TweenBase FieldOfView(Camera target, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xB2958C", Offset = "0xB2958C", VA = "0xB2958C")]
		public static TweenBase FieldOfView(Camera target, float startValue, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xB2965C", Offset = "0xB2965C", VA = "0xB2965C")]
		public static TweenBase LightRange(Light target, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xB29814", Offset = "0xB29814", VA = "0xB29814")]
		public static TweenBase LightRange(Light target, float startValue, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xB298E4", Offset = "0xB298E4", VA = "0xB298E4")]
		public static TweenBase LightIntensity(Light target, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xB29A9C", Offset = "0xB29A9C", VA = "0xB29A9C")]
		public static TweenBase LightIntensity(Light target, float startValue, float endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xB29B6C", Offset = "0xB29B6C", VA = "0xB29B6C")]
		public static TweenBase LocalScale(Transform target, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xB29D50", Offset = "0xB29D50", VA = "0xB29D50")]
		public static TweenBase LocalScale(Transform target, Vector3 startValue, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xB29E50", Offset = "0xB29E50", VA = "0xB29E50")]
		public static TweenBase Color(RawImage target, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xB2A040", Offset = "0xB2A040", VA = "0xB2A040")]
		public static TweenBase Color(RawImage target, Color startValue, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xB2A158", Offset = "0xB2A158", VA = "0xB2A158")]
		public static TweenBase Color(Image target, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xB2A348", Offset = "0xB2A348", VA = "0xB2A348")]
		public static TweenBase Color(Image target, Color startValue, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xB2A460", Offset = "0xB2A460", VA = "0xB2A460")]
		public static TweenBase Color(Text target, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xB2A650", Offset = "0xB2A650", VA = "0xB2A650")]
		public static TweenBase Color(Text target, Color startValue, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xB2A768", Offset = "0xB2A768", VA = "0xB2A768")]
		public static TweenBase Color(Light target, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xB2A958", Offset = "0xB2A958", VA = "0xB2A958")]
		public static TweenBase Color(Light target, Color startValue, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xB2AA68", Offset = "0xB2AA68", VA = "0xB2AA68")]
		public static TweenBase Color(TextMesh target, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xB2AC58", Offset = "0xB2AC58", VA = "0xB2AC58")]
		public static TweenBase Color(TextMesh target, Color startValue, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xB2AD68", Offset = "0xB2AD68", VA = "0xB2AD68")]
		public static TweenBase Color(Material target, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xB2AEA0", Offset = "0xB2AEA0", VA = "0xB2AEA0")]
		public static TweenBase Color(Material target, Color startColor, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xB2AFB0", Offset = "0xB2AFB0", VA = "0xB2AFB0")]
		public static TweenBase Color(Renderer target, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xB2B0A0", Offset = "0xB2B0A0", VA = "0xB2B0A0")]
		public static TweenBase Color(Renderer target, Color startColor, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xB2B1B8", Offset = "0xB2B1B8", VA = "0xB2B1B8")]
		public static TweenBase Color(SpriteRenderer target, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xB2B3A8", Offset = "0xB2B3A8", VA = "0xB2B3A8")]
		public static TweenBase Color(SpriteRenderer target, Color startColor, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xB2B4B8", Offset = "0xB2B4B8", VA = "0xB2B4B8")]
		public static TweenBase Color(Camera target, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xB2B6A8", Offset = "0xB2B6A8", VA = "0xB2B6A8")]
		public static TweenBase Color(Camera target, Color startColor, Color endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xB2B7B8", Offset = "0xB2B7B8", VA = "0xB2B7B8")]
		public static TweenBase Position(Transform target, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xB2B99C", Offset = "0xB2B99C", VA = "0xB2B99C")]
		public static TweenBase Position(Transform target, Vector3 startValue, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xB2BA9C", Offset = "0xB2BA9C", VA = "0xB2BA9C")]
		public static TweenBase AnchoredPosition(RectTransform target, Vector2 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xB2BC60", Offset = "0xB2BC60", VA = "0xB2BC60")]
		public static TweenBase AnchoredPosition(RectTransform target, Vector2 startValue, Vector2 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xB2BD48", Offset = "0xB2BD48", VA = "0xB2BD48")]
		public static TweenBase LocalPosition(Transform target, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xB2BF2C", Offset = "0xB2BF2C", VA = "0xB2BF2C")]
		public static TweenBase LocalPosition(Transform target, Vector3 startValue, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xB2C02C", Offset = "0xB2C02C", VA = "0xB2C02C")]
		public static TweenBase Rotate(Transform target, Vector3 amount, Space space, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xB2C230", Offset = "0xB2C230", VA = "0xB2C230")]
		public static TweenBase Rotation(Transform target, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xB2C460", Offset = "0xB2C460", VA = "0xB2C460")]
		public static TweenBase Rotation(Transform target, Vector3 startValue, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xB2C5F0", Offset = "0xB2C5F0", VA = "0xB2C5F0")]
		public static TweenBase Rotation(Transform target, Quaternion endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xB2C744", Offset = "0xB2C744", VA = "0xB2C744")]
		public static TweenBase Rotation(Transform target, Quaternion startValue, Quaternion endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xB2C854", Offset = "0xB2C854", VA = "0xB2C854")]
		public static TweenBase LocalRotation(Transform target, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xB2CA84", Offset = "0xB2CA84", VA = "0xB2CA84")]
		public static TweenBase LocalRotation(Transform target, Vector3 startValue, Vector3 endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xB2CC14", Offset = "0xB2CC14", VA = "0xB2CC14")]
		public static TweenBase LocalRotation(Transform target, Quaternion endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xB2CD68", Offset = "0xB2CD68", VA = "0xB2CD68")]
		public static TweenBase LocalRotation(Transform target, Quaternion startValue, Quaternion endValue, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xB2CE78", Offset = "0xB2CE78", VA = "0xB2CE78")]
		public static TweenBase LookAt(Transform target, Transform targetToLookAt, Vector3 up, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xB2CFBC", Offset = "0xB2CFBC", VA = "0xB2CFBC")]
		public static TweenBase LookAt(Transform target, Vector3 positionToLookAt, Vector3 up, float duration, float delay, [Optional] AnimationCurve easeCurve, LoopType loop = LoopType.None, [Optional] Action startCallback, [Optional] Action completeCallback, bool obeyTimescale = true)
		{
			return null;
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xB2D0E4", Offset = "0xB2D0E4", VA = "0xB2D0E4")]
		public static void Stop(int targetInstanceID, TweenType tweenType)
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xB2D290", Offset = "0xB2D290", VA = "0xB2D290")]
		public static void Stop(int targetInstanceID)
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xB2D3FC", Offset = "0xB2D3FC", VA = "0xB2D3FC")]
		public static void StopAll()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xB2D56C", Offset = "0xB2D56C", VA = "0xB2D56C")]
		public static void FinishAll()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xB2D6E8", Offset = "0xB2D6E8", VA = "0xB2D6E8")]
		public static void Finish(int targetInstanceID)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xB2D854", Offset = "0xB2D854", VA = "0xB2D854")]
		public static void Cancel(int targetInstanceID)
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xB2D9C0", Offset = "0xB2D9C0", VA = "0xB2D9C0")]
		public static void CancelAll()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xB2D2E4", Offset = "0xB2D2E4", VA = "0xB2D2E4")]
		private static void StopInstanceTarget(int id)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xB2F798", Offset = "0xB2F798", VA = "0xB2F798")]
		private static void StopInstanceTargetType(int id, TweenType type)
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xB2D73C", Offset = "0xB2D73C", VA = "0xB2D73C")]
		private static void FinishInstanceTarget(int id)
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xB2D8A8", Offset = "0xB2D8A8", VA = "0xB2D8A8")]
		private static void CancelInstanceTarget(int id)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xB26A0C", Offset = "0xB26A0C", VA = "0xB26A0C")]
		private static void SendTweenForProcessing(TweenBase tween, bool interrupt = false)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xB2F9D0", Offset = "0xB2F9D0", VA = "0xB2F9D0")]
		public Tween()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class Initialization : MonoBehaviour
	{
		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private StateMachine _stateMachine;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DisplayObject _displayObject;

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xB2FA70", Offset = "0xB2FA70", VA = "0xB2FA70")]
		private void Awake()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xB2FD94", Offset = "0xB2FD94", VA = "0xB2FD94")]
		private void Start()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xB2FE14", Offset = "0xB2FE14", VA = "0xB2FE14")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xB2FBA0", Offset = "0xB2FBA0", VA = "0xB2FBA0")]
		private void InitializeSingleton()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xB2FF3C", Offset = "0xB2FF3C", VA = "0xB2FF3C")]
		public Initialization()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class LayerMaskHelper
	{
		[Token(Token = "0x6000572")]
		[Address(RVA = "0xB2FF44", Offset = "0xB2FF44", VA = "0xB2FF44")]
		public static int OnlyIncluding(params int[] layers)
		{
			return default(int);
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xB2FFB0", Offset = "0xB2FFB0", VA = "0xB2FFB0")]
		public static int Everything()
		{
			return default(int);
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xB2FFB8", Offset = "0xB2FFB8", VA = "0xB2FFB8")]
		public static int Default()
		{
			return default(int);
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xB2FFC0", Offset = "0xB2FFC0", VA = "0xB2FFC0")]
		public static int Nothing()
		{
			return default(int);
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xB2FFC8", Offset = "0xB2FFC8", VA = "0xB2FFC8")]
		public static int EverythingBut(params int[] layers)
		{
			return default(int);
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xB2FFDC", Offset = "0xB2FFDC", VA = "0xB2FFDC")]
		public static bool ContainsLayer(LayerMask layerMask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0xB2FF48", Offset = "0xB2FF48", VA = "0xB2FF48")]
		private static int MakeMask(params int[] layers)
		{
			return default(int);
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xB30014", Offset = "0xB30014", VA = "0xB30014")]
		public LayerMaskHelper()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public static class CoreMath
	{
		[Token(Token = "0x600057A")]
		[Address(RVA = "0xB3001C", Offset = "0xB3001C", VA = "0xB3001C")]
		public static float LinearInterpolate(float from, float to, float percentage)
		{
			return default(float);
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xB3002C", Offset = "0xB3002C", VA = "0xB3002C")]
		public static Vector2 LinearInterpolate(Vector2 from, Vector2 to, float percentage)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xB30048", Offset = "0xB30048", VA = "0xB30048")]
		public static Vector3 LinearInterpolate(Vector3 from, Vector3 to, float percentage)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xB30070", Offset = "0xB30070", VA = "0xB30070")]
		public static Vector4 LinearInterpolate(Vector4 from, Vector4 to, float percentage)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xB300A8", Offset = "0xB300A8", VA = "0xB300A8")]
		public static Rect LinearInterpolate(Rect from, Rect to, float percentage)
		{
			return default(Rect);
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xB301AC", Offset = "0xB301AC", VA = "0xB301AC")]
		public static Color LinearInterpolate(Color from, Color to, float percentage)
		{
			return default(Color);
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xB301E4", Offset = "0xB301E4", VA = "0xB301E4")]
		public static float EvaluateCurve(AnimationCurve curve, float percentage)
		{
			return default(float);
		}
	}
}
namespace Pixelplacement.TweenSystem
{
	[Token(Token = "0x20000DA")]
	public abstract class TweenBase
	{
		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int targetInstanceID;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Tween.TweenType tweenType;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected float elapsedTime;

		[Token(Token = "0x17000049")]
		public Tween.TweenStatus Status
		{
			[Token(Token = "0x6000581")]
			[Address(RVA = "0xB30264", Offset = "0xB30264", VA = "0xB30264")]
			[CompilerGenerated]
			get
			{
				return default(Tween.TweenStatus);
			}
			[Token(Token = "0x6000582")]
			[Address(RVA = "0xB3026C", Offset = "0xB3026C", VA = "0xB3026C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public float Duration
		{
			[Token(Token = "0x6000583")]
			[Address(RVA = "0xB30274", Offset = "0xB30274", VA = "0xB30274")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000584")]
			[Address(RVA = "0xB3027C", Offset = "0xB3027C", VA = "0xB3027C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public AnimationCurve Curve
		{
			[Token(Token = "0x6000585")]
			[Address(RVA = "0xB30284", Offset = "0xB30284", VA = "0xB30284")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000586")]
			[Address(RVA = "0xB3028C", Offset = "0xB3028C", VA = "0xB3028C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public Keyframe[] CurveKeys
		{
			[Token(Token = "0x6000587")]
			[Address(RVA = "0xB30294", Offset = "0xB30294", VA = "0xB30294")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000588")]
			[Address(RVA = "0xB3029C", Offset = "0xB3029C", VA = "0xB3029C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public bool ObeyTimescale
		{
			[Token(Token = "0x6000589")]
			[Address(RVA = "0xB302A4", Offset = "0xB302A4", VA = "0xB302A4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600058A")]
			[Address(RVA = "0xB302AC", Offset = "0xB302AC", VA = "0xB302AC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public Action StartCallback
		{
			[Token(Token = "0x600058B")]
			[Address(RVA = "0xB302B8", Offset = "0xB302B8", VA = "0xB302B8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600058C")]
			[Address(RVA = "0xB302C0", Offset = "0xB302C0", VA = "0xB302C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public Action CompleteCallback
		{
			[Token(Token = "0x600058D")]
			[Address(RVA = "0xB302C8", Offset = "0xB302C8", VA = "0xB302C8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600058E")]
			[Address(RVA = "0xB302D0", Offset = "0xB302D0", VA = "0xB302D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public float Delay
		{
			[Token(Token = "0x600058F")]
			[Address(RVA = "0xB302D8", Offset = "0xB302D8", VA = "0xB302D8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000590")]
			[Address(RVA = "0xB302E0", Offset = "0xB302E0", VA = "0xB302E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public Tween.LoopType LoopType
		{
			[Token(Token = "0x6000591")]
			[Address(RVA = "0xB302E8", Offset = "0xB302E8", VA = "0xB302E8")]
			[CompilerGenerated]
			get
			{
				return default(Tween.LoopType);
			}
			[Token(Token = "0x6000592")]
			[Address(RVA = "0xB302F0", Offset = "0xB302F0", VA = "0xB302F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public float Percentage
		{
			[Token(Token = "0x6000593")]
			[Address(RVA = "0xB302F8", Offset = "0xB302F8", VA = "0xB302F8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000594")]
			[Address(RVA = "0xB30300", Offset = "0xB30300", VA = "0xB30300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xB2D284", Offset = "0xB2D284", VA = "0xB2D284")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xB30308", Offset = "0xB30308", VA = "0xB30308")]
		public void Start()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xB303A4", Offset = "0xB303A4", VA = "0xB303A4")]
		public void Resume()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xB30424", Offset = "0xB30424", VA = "0xB30424")]
		public void Rewind()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xB2DB30", Offset = "0xB2DB30", VA = "0xB2DB30")]
		public void Cancel()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xB2D6DC", Offset = "0xB2D6DC", VA = "0xB2D6DC")]
		public void Finish()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xB3043C", Offset = "0xB3043C", VA = "0xB3043C")]
		public bool Tick()
		{
			return default(bool);
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xB3078C", Offset = "0xB3078C", VA = "0xB3078C")]
		protected void ResetStartTime()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xB3079C", Offset = "0xB3079C", VA = "0xB3079C")]
		protected void SetEssentials(Tween.TweenType tweenType, int targetInstanceID, float duration, float delay, bool obeyTimeScale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x600059E")]
		protected abstract bool SetStartValue();

		[Token(Token = "0x600059F")]
		protected abstract void Operation(float percentage);

		[Token(Token = "0x60005A0")]
		public abstract void Loop();

		[Token(Token = "0x60005A1")]
		public abstract void PingPong();

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xB30860", Offset = "0xB30860", VA = "0xB30860")]
		protected TweenBase()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class TweenEngine : MonoBehaviour
	{
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xB2F8F8", Offset = "0xB2F8F8", VA = "0xB2F8F8")]
		public void ExecuteTween(TweenBase tween)
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xB30868", Offset = "0xB30868", VA = "0xB30868")]
		private void Update()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xB30988", Offset = "0xB30988", VA = "0xB30988")]
		public TweenEngine()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class TweenUtilities : MonoBehaviour
	{
		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xB30990", Offset = "0xB30990", VA = "0xB30990")]
		public static void GenerateAnimationCurvePropertyCode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xB30E9C", Offset = "0xB30E9C", VA = "0xB30E9C")]
		public static float LinearInterpolate(float from, float to, float percentage)
		{
			return default(float);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xB30EAC", Offset = "0xB30EAC", VA = "0xB30EAC")]
		public static Vector2 LinearInterpolate(Vector2 from, Vector2 to, float percentage)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xB30EC8", Offset = "0xB30EC8", VA = "0xB30EC8")]
		public static Vector3 LinearInterpolate(Vector3 from, Vector3 to, float percentage)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xB30EF0", Offset = "0xB30EF0", VA = "0xB30EF0")]
		public static Vector3 LinearInterpolateRotational(Vector3 from, Vector3 to, float percentage)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xB31070", Offset = "0xB31070", VA = "0xB31070")]
		public static Vector4 LinearInterpolate(Vector4 from, Vector4 to, float percentage)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xB310A8", Offset = "0xB310A8", VA = "0xB310A8")]
		public static Rect LinearInterpolate(Rect from, Rect to, float percentage)
		{
			return default(Rect);
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xB311AC", Offset = "0xB311AC", VA = "0xB311AC")]
		public static Color LinearInterpolate(Color from, Color to, float percentage)
		{
			return default(Color);
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xB3070C", Offset = "0xB3070C", VA = "0xB3070C")]
		public static float EvaluateCurve(AnimationCurve curve, float percentage)
		{
			return default(float);
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xB3100C", Offset = "0xB3100C", VA = "0xB3100C")]
		private static float CylindricalLerp(float from, float to, float percentage)
		{
			return default(float);
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xB311E4", Offset = "0xB311E4", VA = "0xB311E4")]
		public TweenUtilities()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	internal class AnchoredPosition : TweenBase
	{
		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _target;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector2 _start;

		[Token(Token = "0x17000053")]
		public Vector2 EndValue
		{
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0xB311EC", Offset = "0xB311EC", VA = "0xB311EC")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60005B2")]
			[Address(RVA = "0xB311F4", Offset = "0xB311F4", VA = "0xB311F4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xB2BB9C", Offset = "0xB2BB9C", VA = "0xB2BB9C")]
		public AnchoredPosition(RectTransform target, Vector2 endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xB311FC", Offset = "0xB311FC", VA = "0xB311FC", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xB31288", Offset = "0xB31288", VA = "0xB31288", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xB312C0", Offset = "0xB312C0", VA = "0xB312C0", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xB312F0", Offset = "0xB312F0", VA = "0xB312F0", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	internal class CameraBackgroundColor : TweenBase
	{
		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Camera _target;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Color _start;

		[Token(Token = "0x17000054")]
		public Color EndValue
		{
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0xB3133C", Offset = "0xB3133C", VA = "0xB3133C")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60005B9")]
			[Address(RVA = "0xB31348", Offset = "0xB31348", VA = "0xB31348")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xB2B5D0", Offset = "0xB2B5D0", VA = "0xB2B5D0")]
		public CameraBackgroundColor(Camera target, Color endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xB31354", Offset = "0xB31354", VA = "0xB31354", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xB313E4", Offset = "0xB313E4", VA = "0xB313E4", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xB31424", Offset = "0xB31424", VA = "0xB31424", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xB31458", Offset = "0xB31458", VA = "0xB31458", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	internal class CanvasGroupAlpha : TweenBase
	{
		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CanvasGroup _target;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _start;

		[Token(Token = "0x17000055")]
		public float EndValue
		{
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0xB314B0", Offset = "0xB314B0", VA = "0xB314B0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005C0")]
			[Address(RVA = "0xB314B8", Offset = "0xB314B8", VA = "0xB314B8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xB26E0C", Offset = "0xB26E0C", VA = "0xB26E0C")]
		public CanvasGroupAlpha(CanvasGroup target, float endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xB314C0", Offset = "0xB314C0", VA = "0xB314C0", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xB3154C", Offset = "0xB3154C", VA = "0xB3154C", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xB31580", Offset = "0xB31580", VA = "0xB31580", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xB315B0", Offset = "0xB315B0", VA = "0xB315B0", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	internal class FieldOfView : TweenBase
	{
		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Camera _target;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _start;

		[Token(Token = "0x17000056")]
		public float EndValue
		{
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0xB31600", Offset = "0xB31600", VA = "0xB31600")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0xB31608", Offset = "0xB31608", VA = "0xB31608")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xB294CC", Offset = "0xB294CC", VA = "0xB294CC")]
		public FieldOfView(Camera target, float endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xB31610", Offset = "0xB31610", VA = "0xB31610", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xB3169C", Offset = "0xB3169C", VA = "0xB3169C", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xB316D0", Offset = "0xB316D0", VA = "0xB316D0", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xB31700", Offset = "0xB31700", VA = "0xB31700", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	internal class ImageColor : TweenBase
	{
		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image _target;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Color _start;

		[Token(Token = "0x17000057")]
		public Color EndValue
		{
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0xB31750", Offset = "0xB31750", VA = "0xB31750")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0xB3175C", Offset = "0xB3175C", VA = "0xB3175C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xB2A270", Offset = "0xB2A270", VA = "0xB2A270")]
		public ImageColor(Image target, Color endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xB31768", Offset = "0xB31768", VA = "0xB31768", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xB31800", Offset = "0xB31800", VA = "0xB31800", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xB31848", Offset = "0xB31848", VA = "0xB31848", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xB31884", Offset = "0xB31884", VA = "0xB31884", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	internal class LightColor : TweenBase
	{
		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Light _target;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Color _start;

		[Token(Token = "0x17000058")]
		public Color EndValue
		{
			[Token(Token = "0x60005D4")]
			[Address(RVA = "0xB318EC", Offset = "0xB318EC", VA = "0xB318EC")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60005D5")]
			[Address(RVA = "0xB318F8", Offset = "0xB318F8", VA = "0xB318F8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xB2A880", Offset = "0xB2A880", VA = "0xB2A880")]
		public LightColor(Light target, Color endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xB31904", Offset = "0xB31904", VA = "0xB31904", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xB31994", Offset = "0xB31994", VA = "0xB31994", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xB319D4", Offset = "0xB319D4", VA = "0xB319D4", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xB31A08", Offset = "0xB31A08", VA = "0xB31A08", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	internal class LightIntensity : TweenBase
	{
		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Light _target;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _start;

		[Token(Token = "0x17000059")]
		public float EndValue
		{
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0xB31A60", Offset = "0xB31A60", VA = "0xB31A60")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0xB31A68", Offset = "0xB31A68", VA = "0xB31A68")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xB299DC", Offset = "0xB299DC", VA = "0xB299DC")]
		public LightIntensity(Light target, float endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xB31A70", Offset = "0xB31A70", VA = "0xB31A70", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xB31AFC", Offset = "0xB31AFC", VA = "0xB31AFC", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xB31B30", Offset = "0xB31B30", VA = "0xB31B30", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xB31B60", Offset = "0xB31B60", VA = "0xB31B60", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	internal class LightRange : TweenBase
	{
		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Light _target;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _start;

		[Token(Token = "0x1700005A")]
		public float EndValue
		{
			[Token(Token = "0x60005E2")]
			[Address(RVA = "0xB31BB0", Offset = "0xB31BB0", VA = "0xB31BB0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0xB31BB8", Offset = "0xB31BB8", VA = "0xB31BB8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xB29754", Offset = "0xB29754", VA = "0xB29754")]
		public LightRange(Light target, float endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xB31BC0", Offset = "0xB31BC0", VA = "0xB31BC0", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xB31C4C", Offset = "0xB31C4C", VA = "0xB31C4C", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xB31C80", Offset = "0xB31C80", VA = "0xB31C80", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xB31CB0", Offset = "0xB31CB0", VA = "0xB31CB0", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	internal class LocalPosition : TweenBase
	{
		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform _target;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 _start;

		[Token(Token = "0x1700005B")]
		public Vector3 EndValue
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0xB31D00", Offset = "0xB31D00", VA = "0xB31D00")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0xB31D0C", Offset = "0xB31D0C", VA = "0xB31D0C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xB2BE58", Offset = "0xB2BE58", VA = "0xB2BE58")]
		public LocalPosition(Transform target, Vector3 endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xB31D18", Offset = "0xB31D18", VA = "0xB31D18", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xB31DA8", Offset = "0xB31DA8", VA = "0xB31DA8", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xB31DF4", Offset = "0xB31DF4", VA = "0xB31DF4", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xB31E28", Offset = "0xB31E28", VA = "0xB31E28", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	internal class LocalRotation : TweenBase
	{
		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform _target;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 _start;

		[Token(Token = "0x1700005C")]
		public Vector3 EndValue
		{
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0xB31E84", Offset = "0xB31E84", VA = "0xB31E84")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0xB31E90", Offset = "0xB31E90", VA = "0xB31E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xB2C9B0", Offset = "0xB2C9B0", VA = "0xB2C9B0")]
		public LocalRotation(Transform target, Vector3 endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xB31E9C", Offset = "0xB31E9C", VA = "0xB31E9C", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xB31F2C", Offset = "0xB31F2C", VA = "0xB31F2C", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xB31F88", Offset = "0xB31F88", VA = "0xB31F88", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xB31FBC", Offset = "0xB31FBC", VA = "0xB31FBC", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	internal class LocalScale : TweenBase
	{
		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform _target;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 _start;

		[Token(Token = "0x1700005D")]
		public Vector3 EndValue
		{
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0xB32018", Offset = "0xB32018", VA = "0xB32018")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60005F8")]
			[Address(RVA = "0xB32024", Offset = "0xB32024", VA = "0xB32024")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xB29C7C", Offset = "0xB29C7C", VA = "0xB29C7C")]
		public LocalScale(Transform target, Vector3 endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xB32030", Offset = "0xB32030", VA = "0xB32030", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xB320C0", Offset = "0xB320C0", VA = "0xB320C0", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xB3210C", Offset = "0xB3210C", VA = "0xB3210C", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xB32140", Offset = "0xB32140", VA = "0xB32140", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	internal class PanStereo : TweenBase
	{
		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource _target;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _start;

		[Token(Token = "0x1700005E")]
		public float EndValue
		{
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0xB3219C", Offset = "0xB3219C", VA = "0xB3219C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0xB321A4", Offset = "0xB321A4", VA = "0xB321A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xB28D10", Offset = "0xB28D10", VA = "0xB28D10")]
		public PanStereo(AudioSource target, float endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xB321AC", Offset = "0xB321AC", VA = "0xB321AC", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xB32238", Offset = "0xB32238", VA = "0xB32238", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xB3226C", Offset = "0xB3226C", VA = "0xB3226C", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xB3229C", Offset = "0xB3229C", VA = "0xB3229C", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	internal class Pitch : TweenBase
	{
		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource _target;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _start;

		[Token(Token = "0x1700005F")]
		public float EndValue
		{
			[Token(Token = "0x6000605")]
			[Address(RVA = "0xB322EC", Offset = "0xB322EC", VA = "0xB322EC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000606")]
			[Address(RVA = "0xB322F4", Offset = "0xB322F4", VA = "0xB322F4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xB28A88", Offset = "0xB28A88", VA = "0xB28A88")]
		public Pitch(AudioSource target, float endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xB322FC", Offset = "0xB322FC", VA = "0xB322FC", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xB32388", Offset = "0xB32388", VA = "0xB32388", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xB323BC", Offset = "0xB323BC", VA = "0xB323BC", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xB323EC", Offset = "0xB323EC", VA = "0xB323EC", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	internal class Position : TweenBase
	{
		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform _target;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 _start;

		[Token(Token = "0x17000060")]
		public Vector3 EndValue
		{
			[Token(Token = "0x600060C")]
			[Address(RVA = "0xB3243C", Offset = "0xB3243C", VA = "0xB3243C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600060D")]
			[Address(RVA = "0xB32448", Offset = "0xB32448", VA = "0xB32448")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xB2B8C8", Offset = "0xB2B8C8", VA = "0xB2B8C8")]
		public Position(Transform target, Vector3 endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xB32454", Offset = "0xB32454", VA = "0xB32454", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xB324E4", Offset = "0xB324E4", VA = "0xB324E4", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xB32530", Offset = "0xB32530", VA = "0xB32530", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xB32564", Offset = "0xB32564", VA = "0xB32564", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	internal class RawImageColor : TweenBase
	{
		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RawImage _target;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Color _start;

		[Token(Token = "0x17000061")]
		public Color EndValue
		{
			[Token(Token = "0x6000613")]
			[Address(RVA = "0xB325C0", Offset = "0xB325C0", VA = "0xB325C0")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000614")]
			[Address(RVA = "0xB325CC", Offset = "0xB325CC", VA = "0xB325CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xB29F68", Offset = "0xB29F68", VA = "0xB29F68")]
		public RawImageColor(RawImage target, Color endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xB325D8", Offset = "0xB325D8", VA = "0xB325D8", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xB32670", Offset = "0xB32670", VA = "0xB32670", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xB326B8", Offset = "0xB326B8", VA = "0xB326B8", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xB326F4", Offset = "0xB326F4", VA = "0xB326F4", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	internal class Rotate : TweenBase
	{
		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform _target;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 _start;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Space _space;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 _previous;

		[Token(Token = "0x17000062")]
		public Vector3 EndValue
		{
			[Token(Token = "0x600061A")]
			[Address(RVA = "0xB3275C", Offset = "0xB3275C", VA = "0xB3275C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600061B")]
			[Address(RVA = "0xB32768", Offset = "0xB32768", VA = "0xB32768")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xB2C14C", Offset = "0xB2C14C", VA = "0xB2C14C")]
		public Rotate(Transform target, Vector3 endValue, Space space, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xB32774", Offset = "0xB32774", VA = "0xB32774", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xB32804", Offset = "0xB32804", VA = "0xB32804", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xB328E0", Offset = "0xB328E0", VA = "0xB328E0", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xB32944", Offset = "0xB32944", VA = "0xB32944", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	internal class Rotation : TweenBase
	{
		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform _target;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 _start;

		[Token(Token = "0x17000063")]
		public Vector3 EndValue
		{
			[Token(Token = "0x6000621")]
			[Address(RVA = "0xB329C0", Offset = "0xB329C0", VA = "0xB329C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000622")]
			[Address(RVA = "0xB329CC", Offset = "0xB329CC", VA = "0xB329CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xB2C38C", Offset = "0xB2C38C", VA = "0xB2C38C")]
		public Rotation(Transform target, Vector3 endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xB329D8", Offset = "0xB329D8", VA = "0xB329D8", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xB32A68", Offset = "0xB32A68", VA = "0xB32A68", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xB32AC4", Offset = "0xB32AC4", VA = "0xB32AC4", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xB32AF8", Offset = "0xB32AF8", VA = "0xB32AF8", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	internal class ShaderColor : TweenBase
	{
		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material _target;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Color _start;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string _propertyName;

		[Token(Token = "0x17000064")]
		public Color EndValue
		{
			[Token(Token = "0x6000628")]
			[Address(RVA = "0xB32B54", Offset = "0xB32B54", VA = "0xB32B54")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000629")]
			[Address(RVA = "0xB32B60", Offset = "0xB32B60", VA = "0xB32B60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xB284B8", Offset = "0xB284B8", VA = "0xB284B8")]
		public ShaderColor(Material target, string propertyName, Color endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xB32B6C", Offset = "0xB32B6C", VA = "0xB32B6C", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xB32BF8", Offset = "0xB32BF8", VA = "0xB32BF8", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xB32C3C", Offset = "0xB32C3C", VA = "0xB32C3C", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xB32C74", Offset = "0xB32C74", VA = "0xB32C74", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	internal class ShaderFloat : TweenBase
	{
		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material _target;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _start;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string _propertyName;

		[Token(Token = "0x17000065")]
		public float EndValue
		{
			[Token(Token = "0x600062F")]
			[Address(RVA = "0xB32CD4", Offset = "0xB32CD4", VA = "0xB32CD4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000630")]
			[Address(RVA = "0xB32CDC", Offset = "0xB32CDC", VA = "0xB32CDC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xB287D0", Offset = "0xB287D0", VA = "0xB287D0")]
		public ShaderFloat(Material target, string propertyName, float endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xB32CE4", Offset = "0xB32CE4", VA = "0xB32CE4", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xB32D6C", Offset = "0xB32D6C", VA = "0xB32D6C", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xB32DA4", Offset = "0xB32DA4", VA = "0xB32DA4", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xB32DD8", Offset = "0xB32DD8", VA = "0xB32DD8", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	internal class ShaderInt : TweenBase
	{
		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material _target;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int _start;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string _propertyName;

		[Token(Token = "0x17000066")]
		public int EndValue
		{
			[Token(Token = "0x6000636")]
			[Address(RVA = "0xB32E30", Offset = "0xB32E30", VA = "0xB32E30")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000637")]
			[Address(RVA = "0xB32E38", Offset = "0xB32E38", VA = "0xB32E38")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xB281D8", Offset = "0xB281D8", VA = "0xB281D8")]
		public ShaderInt(Material target, string propertyName, int endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xB32E40", Offset = "0xB32E40", VA = "0xB32E40", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xB32EC8", Offset = "0xB32EC8", VA = "0xB32EC8", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xB32F20", Offset = "0xB32F20", VA = "0xB32F20", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xB32F54", Offset = "0xB32F54", VA = "0xB32F54", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	internal class ShaderVector : TweenBase
	{
		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material _target;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector4 _start;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string _propertyName;

		[Token(Token = "0x17000067")]
		public Vector4 EndValue
		{
			[Token(Token = "0x600063D")]
			[Address(RVA = "0xB32FAC", Offset = "0xB32FAC", VA = "0xB32FAC")]
			[CompilerGenerated]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x600063E")]
			[Address(RVA = "0xB32FB8", Offset = "0xB32FB8", VA = "0xB32FB8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xB27EC0", Offset = "0xB27EC0", VA = "0xB27EC0")]
		public ShaderVector(Material target, string propertyName, Vector4 endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xB32FC4", Offset = "0xB32FC4", VA = "0xB32FC4", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xB33058", Offset = "0xB33058", VA = "0xB33058", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xB3309C", Offset = "0xB3309C", VA = "0xB3309C", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xB330D4", Offset = "0xB330D4", VA = "0xB330D4", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	internal class ShakePosition : TweenBase
	{
		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform _target;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 _initialPosition;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 _intensity;

		[Token(Token = "0x17000068")]
		public Vector3 EndValue
		{
			[Token(Token = "0x6000644")]
			[Address(RVA = "0xB33134", Offset = "0xB33134", VA = "0xB33134")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000645")]
			[Address(RVA = "0xB33140", Offset = "0xB33140", VA = "0xB33140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0xB26920", Offset = "0xB26920", VA = "0xB26920")]
		public ShakePosition(Transform target, Vector3 initialPosition, Vector3 intensity, float duration, float delay, AnimationCurve curve, Action startCallback, Action completeCallback, Tween.LoopType loop, bool obeyTimescale)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xB3314C", Offset = "0xB3314C", VA = "0xB3314C", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xB331B8", Offset = "0xB331B8", VA = "0xB331B8", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xB3327C", Offset = "0xB3327C", VA = "0xB3327C", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xB332B0", Offset = "0xB332B0", VA = "0xB332B0", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	internal class Size : TweenBase
	{
		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _target;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector2 _start;

		[Token(Token = "0x17000069")]
		public Vector2 EndValue
		{
			[Token(Token = "0x600064B")]
			[Address(RVA = "0xB332B4", Offset = "0xB332B4", VA = "0xB332B4")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600064C")]
			[Address(RVA = "0xB332BC", Offset = "0xB332BC", VA = "0xB332BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0xB29228", Offset = "0xB29228", VA = "0xB29228")]
		public Size(RectTransform target, Vector2 endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0xB332C4", Offset = "0xB332C4", VA = "0xB332C4", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xB33350", Offset = "0xB33350", VA = "0xB33350", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xB33388", Offset = "0xB33388", VA = "0xB33388", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xB333B8", Offset = "0xB333B8", VA = "0xB333B8", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	internal class SplinePercentage : TweenBase
	{
		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform _target;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Spline _spline;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _startPercentage;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool _faceDirection;

		[Token(Token = "0x1700006A")]
		public float EndValue
		{
			[Token(Token = "0x6000652")]
			[Address(RVA = "0xB33404", Offset = "0xB33404", VA = "0xB33404")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000653")]
			[Address(RVA = "0xB3340C", Offset = "0xB3340C", VA = "0xB3340C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xB26BE8", Offset = "0xB26BE8", VA = "0xB26BE8")]
		public SplinePercentage(Spline spline, Transform target, float startPercentage, float endPercentage, bool faceDirection, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xB33414", Offset = "0xB33414", VA = "0xB33414", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xB33480", Offset = "0xB33480", VA = "0xB33480", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xB33574", Offset = "0xB33574", VA = "0xB33574", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xB335BC", Offset = "0xB335BC", VA = "0xB335BC", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	internal class SpriteRendererColor : TweenBase
	{
		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private SpriteRenderer _target;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Color _start;

		[Token(Token = "0x1700006B")]
		public Color EndValue
		{
			[Token(Token = "0x6000659")]
			[Address(RVA = "0xB335DC", Offset = "0xB335DC", VA = "0xB335DC")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600065A")]
			[Address(RVA = "0xB335E8", Offset = "0xB335E8", VA = "0xB335E8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xB2B2D0", Offset = "0xB2B2D0", VA = "0xB2B2D0")]
		public SpriteRendererColor(SpriteRenderer target, Color endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xB335F4", Offset = "0xB335F4", VA = "0xB335F4", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xB33684", Offset = "0xB33684", VA = "0xB33684", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xB336C4", Offset = "0xB336C4", VA = "0xB336C4", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xB336F8", Offset = "0xB336F8", VA = "0xB336F8", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	internal class TextColor : TweenBase
	{
		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Text _target;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Color _start;

		[Token(Token = "0x1700006C")]
		public Color EndValue
		{
			[Token(Token = "0x6000660")]
			[Address(RVA = "0xB33750", Offset = "0xB33750", VA = "0xB33750")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000661")]
			[Address(RVA = "0xB3375C", Offset = "0xB3375C", VA = "0xB3375C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xB2A578", Offset = "0xB2A578", VA = "0xB2A578")]
		public TextColor(Text target, Color endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xB33768", Offset = "0xB33768", VA = "0xB33768", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xB33800", Offset = "0xB33800", VA = "0xB33800", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xB33848", Offset = "0xB33848", VA = "0xB33848", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xB33884", Offset = "0xB33884", VA = "0xB33884", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	internal class TextMeshColor : TweenBase
	{
		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMesh _target;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Color _start;

		[Token(Token = "0x1700006D")]
		public Color EndValue
		{
			[Token(Token = "0x6000667")]
			[Address(RVA = "0xB338EC", Offset = "0xB338EC", VA = "0xB338EC")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000668")]
			[Address(RVA = "0xB338F8", Offset = "0xB338F8", VA = "0xB338F8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xB2AB80", Offset = "0xB2AB80", VA = "0xB2AB80")]
		public TextMeshColor(TextMesh target, Color endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xB33904", Offset = "0xB33904", VA = "0xB33904", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xB33994", Offset = "0xB33994", VA = "0xB33994", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xB339D4", Offset = "0xB339D4", VA = "0xB339D4", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xB33A08", Offset = "0xB33A08", VA = "0xB33A08", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	internal class ValueColor : TweenBase
	{
		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Action<Color> _valueUpdatedCallback;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Color _start;

		[Token(Token = "0x1700006E")]
		public Color EndValue
		{
			[Token(Token = "0x600066E")]
			[Address(RVA = "0xB33A60", Offset = "0xB33A60", VA = "0xB33A60")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600066F")]
			[Address(RVA = "0xB33A6C", Offset = "0xB33A6C", VA = "0xB33A6C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xB27934", Offset = "0xB27934", VA = "0xB27934")]
		public ValueColor(Color startValue, Color endValue, Action<Color> valueUpdatedCallback, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xB33A78", Offset = "0xB33A78", VA = "0xB33A78", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xB33A80", Offset = "0xB33A80", VA = "0xB33A80", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xB33AC4", Offset = "0xB33AC4", VA = "0xB33AC4", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xB33AD4", Offset = "0xB33AD4", VA = "0xB33AD4", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	internal class ValueFloat : TweenBase
	{
		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Action<float> _valueUpdatedCallback;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _start;

		[Token(Token = "0x1700006F")]
		public float EndValue
		{
			[Token(Token = "0x6000675")]
			[Address(RVA = "0xB33AF4", Offset = "0xB33AF4", VA = "0xB33AF4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000676")]
			[Address(RVA = "0xB33AFC", Offset = "0xB33AFC", VA = "0xB33AFC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xB27CE4", Offset = "0xB27CE4", VA = "0xB27CE4")]
		public ValueFloat(float startValue, float endValue, Action<float> valueUpdatedCallback, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xB33B04", Offset = "0xB33B04", VA = "0xB33B04", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xB33B0C", Offset = "0xB33B0C", VA = "0xB33B0C", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xB33B44", Offset = "0xB33B44", VA = "0xB33B44", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xB33B54", Offset = "0xB33B54", VA = "0xB33B54", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	internal class ValueInt : TweenBase
	{
		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Action<int> _valueUpdatedCallback;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _start;

		[Token(Token = "0x17000070")]
		public float EndValue
		{
			[Token(Token = "0x600067C")]
			[Address(RVA = "0xB33B74", Offset = "0xB33B74", VA = "0xB33B74")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600067D")]
			[Address(RVA = "0xB33B7C", Offset = "0xB33B7C", VA = "0xB33B7C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xB27B28", Offset = "0xB27B28", VA = "0xB27B28")]
		public ValueInt(int startValue, int endValue, Action<int> valueUpdatedCallback, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xB33B84", Offset = "0xB33B84", VA = "0xB33B84", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xB33B8C", Offset = "0xB33B8C", VA = "0xB33B8C", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xB33BDC", Offset = "0xB33BDC", VA = "0xB33BDC", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xB33BEC", Offset = "0xB33BEC", VA = "0xB33BEC", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	internal class ValueRect : TweenBase
	{
		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Action<Rect> _valueUpdatedCallback;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rect _start;

		[Token(Token = "0x17000071")]
		public Rect EndValue
		{
			[Token(Token = "0x6000683")]
			[Address(RVA = "0xB33C0C", Offset = "0xB33C0C", VA = "0xB33C0C")]
			[CompilerGenerated]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x6000684")]
			[Address(RVA = "0xB33C18", Offset = "0xB33C18", VA = "0xB33C18")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xB270E4", Offset = "0xB270E4", VA = "0xB270E4")]
		public ValueRect(Rect startValue, Rect endValue, Action<Rect> valueUpdatedCallback, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xB33C24", Offset = "0xB33C24", VA = "0xB33C24", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xB33C2C", Offset = "0xB33C2C", VA = "0xB33C2C", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xB33C78", Offset = "0xB33C78", VA = "0xB33C78", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xB33C88", Offset = "0xB33C88", VA = "0xB33C88", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	internal class ValueVector2 : TweenBase
	{
		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Action<Vector2> _valueUpdatedCallback;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector2 _start;

		[Token(Token = "0x17000072")]
		public Vector2 EndValue
		{
			[Token(Token = "0x600068A")]
			[Address(RVA = "0xB33CA8", Offset = "0xB33CA8", VA = "0xB33CA8")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600068B")]
			[Address(RVA = "0xB33CB0", Offset = "0xB33CB0", VA = "0xB33CB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xB27728", Offset = "0xB27728", VA = "0xB27728")]
		public ValueVector2(Vector2 startValue, Vector2 endValue, Action<Vector2> valueUpdatedCallback, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xB33CB8", Offset = "0xB33CB8", VA = "0xB33CB8", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xB33CC0", Offset = "0xB33CC0", VA = "0xB33CC0", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xB33CFC", Offset = "0xB33CFC", VA = "0xB33CFC", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xB33D0C", Offset = "0xB33D0C", VA = "0xB33D0C", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	internal class ValueVector3 : TweenBase
	{
		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Action<Vector3> _valueUpdatedCallback;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 _start;

		[Token(Token = "0x17000073")]
		public Vector3 EndValue
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0xB33D2C", Offset = "0xB33D2C", VA = "0xB33D2C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000692")]
			[Address(RVA = "0xB33D38", Offset = "0xB33D38", VA = "0xB33D38")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xB27534", Offset = "0xB27534", VA = "0xB27534")]
		public ValueVector3(Vector3 startValue, Vector3 endValue, Action<Vector3> valueUpdatedCallback, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xB33D44", Offset = "0xB33D44", VA = "0xB33D44", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xB33D4C", Offset = "0xB33D4C", VA = "0xB33D4C", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xB33D9C", Offset = "0xB33D9C", VA = "0xB33D9C", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xB33DAC", Offset = "0xB33DAC", VA = "0xB33DAC", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	internal class ValueVector4 : TweenBase
	{
		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Action<Vector4> _valueUpdatedCallback;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector4 _start;

		[Token(Token = "0x17000074")]
		public Vector4 EndValue
		{
			[Token(Token = "0x6000698")]
			[Address(RVA = "0xB33DDC", Offset = "0xB33DDC", VA = "0xB33DDC")]
			[CompilerGenerated]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x6000699")]
			[Address(RVA = "0xB33DE8", Offset = "0xB33DE8", VA = "0xB33DE8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xB27318", Offset = "0xB27318", VA = "0xB27318")]
		public ValueVector4(Vector4 startValue, Vector4 endValue, Action<Vector4> valueUpdatedCallback, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xB33DF4", Offset = "0xB33DF4", VA = "0xB33DF4", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xB33DFC", Offset = "0xB33DFC", VA = "0xB33DFC", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xB33E40", Offset = "0xB33E40", VA = "0xB33E40", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xB33E50", Offset = "0xB33E50", VA = "0xB33E50", Slot = "7")]
		public override void PingPong()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	internal class Volume : TweenBase
	{
		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource _target;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _start;

		[Token(Token = "0x17000075")]
		public float EndValue
		{
			[Token(Token = "0x600069F")]
			[Address(RVA = "0xB33E70", Offset = "0xB33E70", VA = "0xB33E70")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0xB33E78", Offset = "0xB33E78", VA = "0xB33E78")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xB28F98", Offset = "0xB28F98", VA = "0xB28F98")]
		public Volume(AudioSource target, float endValue, float duration, float delay, bool obeyTimescale, AnimationCurve curve, Tween.LoopType loop, Action startCallback, Action completeCallback)
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xB33E80", Offset = "0xB33E80", VA = "0xB33E80", Slot = "4")]
		protected override bool SetStartValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xB33F0C", Offset = "0xB33F0C", VA = "0xB33F0C", Slot = "5")]
		protected override void Operation(float percentage)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xB33F40", Offset = "0xB33F40", VA = "0xB33F40", Slot = "6")]
		public override void Loop()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xB33F70", Offset = "0xB33F70", VA = "0xB33F70", Slot = "7")]
		public override void PingPong()
		{
		}
	}
}
namespace AutoHand
{
	[Token(Token = "0x2000100")]
	public class HandTouchButton : MonoBehaviour
	{
		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideIf("startUnpress")]
		public bool startPress;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[HideIf("startPress")]
		public bool startUnpress;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HandTouchEvent touchEvent;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform button;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 pressOffset;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color unpressColor;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Color pressColor;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool toggle;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Space]
		public UnityHandEvent OnPressed;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public UnityHandEvent OnUnpressed;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool pressed;

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xB33FC0", Offset = "0xB33FC0", VA = "0xB33FC0")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xB341A0", Offset = "0xB341A0", VA = "0xB341A0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xB34304", Offset = "0xB34304", VA = "0xB34304")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xB34468", Offset = "0xB34468", VA = "0xB34468")]
		private void OnTouch(Autohand.Hand hand)
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xB34488", Offset = "0xB34488", VA = "0xB34488")]
		private void OnUntouch(Autohand.Hand hand)
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xB33FE4", Offset = "0xB33FE4", VA = "0xB33FE4")]
		private void PressButton(Autohand.Hand hand)
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xB340C4", Offset = "0xB340C4", VA = "0xB340C4")]
		private void ReleaseButton(Autohand.Hand hand)
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xB344A0", Offset = "0xB344A0", VA = "0xB344A0")]
		public HandTouchButton()
		{
		}
	}
}
namespace Autohand
{
	[Token(Token = "0x2000101")]
	public class XRMover : MonoBehaviour
	{
		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Controllers")]
		[Header("TEMP DEMO SCRIPT - Advanced script coming soon")]
		public XRHandControllerLink moverController;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public XRHandControllerLink turningController;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Common2DAxis moverAxis;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Body")]
		public GameObject cam;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CharacterController controller;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CapsuleCollider collisionCapsule;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Settings")]
		public bool snapTurning;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float turnAngle;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float speed;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float gravity;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float currentGravity;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool axisReset;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 moveAxis;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector2 turningAxis;

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xB344BC", Offset = "0xB344BC", VA = "0xB344BC")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xB34898", Offset = "0xB34898", VA = "0xB34898")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xB34518", Offset = "0xB34518", VA = "0xB34518")]
		public void Move(float x, float y, float z)
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xB34624", Offset = "0xB34624", VA = "0xB34624")]
		private void Turning()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xB3493C", Offset = "0xB3493C", VA = "0xB3493C")]
		public XRMover()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class AutoHeaderAttribute : PropertyAttribute
	{
		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int count;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int depth;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string label;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string tooltip;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string toggleBool;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Type type;

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xB34958", Offset = "0xB34958", VA = "0xB34958")]
		public AutoHeaderAttribute(string label, int count = 0, int depth = 0)
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xB3499C", Offset = "0xB3499C", VA = "0xB3499C")]
		public AutoHeaderAttribute(string label, string tooltip, string toggleName, Type classType, int count = 0, int depth = 0)
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class AutoLineAttribute : PropertyAttribute
	{
		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int count;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int depth;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string tooltip;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string toggleBool;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Type type;

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xB349F4", Offset = "0xB349F4", VA = "0xB349F4")]
		public AutoLineAttribute(int count = 0, int depth = 0)
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xB34A20", Offset = "0xB34A20", VA = "0xB34A20")]
		public AutoLineAttribute(string tooltip, string toggleName, Type classType, int count = 0, int depth = 0)
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class AutoToggleHeaderAttribute : PropertyAttribute
	{
		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int count;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int depth;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string label;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string tooltip;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string toggleBool;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Type type;

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xB34A64", Offset = "0xB34A64", VA = "0xB34A64")]
		public AutoToggleHeaderAttribute(string label, int count = 0, int depth = 0)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xB34AA8", Offset = "0xB34AA8", VA = "0xB34AA8")]
		public AutoToggleHeaderAttribute(string label, string tooltip, string toggleName, Type classType, int count = 0, int depth = 0)
		{
		}
	}
	[Token(Token = "0x2000105")]
	public static class AutoHandExtensions
	{
		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Transform _transformRuler;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Transform _transformRulerChild;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Transform _transformParent;

		[Token(Token = "0x17000076")]
		public static Transform transformRuler
		{
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0xB34B00", Offset = "0xB34B00", VA = "0xB34B00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		public static Transform transformRulerChild
		{
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0xB34E84", Offset = "0xB34E84", VA = "0xB34E84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		public static Transform transformParent
		{
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0xB34D3C", Offset = "0xB34D3C", VA = "0xB34D3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xB350D4", Offset = "0xB350D4", VA = "0xB350D4")]
		public static void RotateAround(this Transform target, Transform center, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xB352EC", Offset = "0xB352EC", VA = "0xB352EC")]
		public static float Round(this float value, int digits)
		{
			return default(float);
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xB35390", Offset = "0xB35390", VA = "0xB35390")]
		public static bool HasGrabbable(this Hand hand, GameObject obj, out Grabbable grabbable)
		{
			return default(bool);
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xB3539C", Offset = "0xB3539C", VA = "0xB3539C")]
		public static bool HasGrabbable(this GameObject obj, out Grabbable grabbable)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C0")]
		public static T GetCopyOf<T>(this Component comp, T other) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60006C1")]
		public static bool CanGetComponent<T>(this Component componentClass, out T component)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C2")]
		public static bool CanGetComponent<T>(this GameObject componentClass, out T component)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xB35498", Offset = "0xB35498", VA = "0xB35498")]
		public static LayerMask GetPhysicsLayerMask(int currentLayer)
		{
			return default(LayerMask);
		}
	}
	[Token(Token = "0x2000106")]
	public class PhysicsGadgetButton : PhysicsGadgetConfigurableLimitReader
	{
		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool pressed;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Min(0.01f)]
		[Tooltip("The percentage (0-1) from the required value needed to call the event, if threshold is 0.1 OnPressed will be called at 0.9, and OnUnpressed at 0.1")]
		public float threshold;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool lockOnPressed;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Space]
		public UnityEvent OnPressed;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UnityEvent OnUnpressed;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 startPos;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pressedPos;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float pressedValue;

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xB35500", Offset = "0xB35500", VA = "0xB35500")]
		protected new void Start()
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xB35644", Offset = "0xB35644", VA = "0xB35644")]
		protected void FixedUpdate()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xB358AC", Offset = "0xB358AC", VA = "0xB358AC")]
		public void Pressed()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xB35904", Offset = "0xB35904", VA = "0xB35904")]
		public void Unpressed()
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xB35920", Offset = "0xB35920", VA = "0xB35920")]
		public void Unlock()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xB3597C", Offset = "0xB3597C", VA = "0xB3597C")]
		public PhysicsGadgetButton()
		{
		}
	}
	[Token(Token = "0x2000107")]
	[RequireComponent(typeof(ConfigurableJoint))]
	public class PhysicsGadgetConfigurableLimitReader : MonoBehaviour
	{
		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool invertValue;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("For objects slightly off center. \nThe minimum abs value required to return a value nonzero value\n - if playRange is 0.1, you have to move the gadget 10% to get a result")]
		public float playRange;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ConfigurableJoint joint;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Vector3 axisPos;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float value;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 limitAxis;

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xB35538", Offset = "0xB35538", VA = "0xB35538")]
		protected void Start()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xB35734", Offset = "0xB35734", VA = "0xB35734")]
		public float GetValue()
		{
			return default(float);
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xB3599C", Offset = "0xB3599C", VA = "0xB3599C")]
		public PhysicsGadgetConfigurableLimitReader()
		{
		}
	}
	[Token(Token = "0x2000108")]
	[RequireComponent(typeof(HingeJoint))]
	public class PhysicsGadgetHingeAngleReader : MonoBehaviour
	{
		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool invertValue;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("For objects slightly off center. \nThe minimum abs value required to return a value nonzero value\n - if playRange is 0.1, you have to move the gadget 10% to get a result")]
		public float playRange;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HingeJoint joint;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float value;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion startRot;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion deltaParentRotation;

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xB359B0", Offset = "0xB359B0", VA = "0xB359B0")]
		protected void Start()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xB35A30", Offset = "0xB35A30", VA = "0xB35A30")]
		public float GetValue()
		{
			return default(float);
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xB35B28", Offset = "0xB35B28", VA = "0xB35B28")]
		public PhysicsGadgetHingeAngleReader()
		{
		}
	}
	[Token(Token = "0x2000109")]
	[RequireComponent(typeof(ConfigurableJoint))]
	public class PhysicsGadgetJoystick : MonoBehaviour
	{
		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ConfigurableJoint joint;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool invertX;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool invertY;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("For objects slightly off center. \nThe minimum abs value required to return a value nonzero value\n - if playRange is 0.1, you have to move the gadget 10% to get a result")]
		public float playRange;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector2 xRange;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector2 zRange;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector2 value;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 jointRotation;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Rigidbody body;

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xB35B3C", Offset = "0xB35B3C", VA = "0xB35B3C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xB35BCC", Offset = "0xB35BCC", VA = "0xB35BCC")]
		public void FixedUpdate()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xB35CD4", Offset = "0xB35CD4", VA = "0xB35CD4")]
		public Vector2 GetValue()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xB35D50", Offset = "0xB35D50", VA = "0xB35D50")]
		public PhysicsGadgetJoystick()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class PhysicsGadgetLever : PhysicsGadgetHingeAngleReader
	{
		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Min(0.01f)]
		[Tooltip("The percentage (0-1) from the required value needed to call the event, if threshold is 0.1 OnMax will be called at 0.9, OnMin at -0.9, and OnMiddle at -0.1 or 0.1")]
		public float threshold;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityEvent OnMax;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UnityEvent OnMid;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public UnityEvent OnMin;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool min;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool max;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool mid;

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xB35D64", Offset = "0xB35D64", VA = "0xB35D64")]
		protected void FixedUpdate()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xB35E84", Offset = "0xB35E84", VA = "0xB35E84")]
		private void Max()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xB35EC8", Offset = "0xB35EC8", VA = "0xB35EC8")]
		private void Mid()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xB35EA4", Offset = "0xB35EA4", VA = "0xB35EA4")]
		private void Min()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xB35EEC", Offset = "0xB35EEC", VA = "0xB35EEC")]
		public PhysicsGadgetLever()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class PhysicsGadgetSlider : PhysicsGadgetConfigurableLimitReader
	{
		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Min(0.01f)]
		[Tooltip("The percentage (0-1) from the required value needed to call the event, if threshold is 0.1 OnMax will be called at 0.9, OnMin at -0.9, and OnMiddle at -0.1 or 0.1")]
		public float threshold;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UnityEvent OnMax;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityEvent OnMid;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UnityEvent OnMin;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool min;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool max;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool mid;

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xB35F0C", Offset = "0xB35F0C", VA = "0xB35F0C")]
		protected void FixedUpdate()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xB3602C", Offset = "0xB3602C", VA = "0xB3602C")]
		private void Max()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xB36070", Offset = "0xB36070", VA = "0xB36070")]
		private void Mid()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xB3604C", Offset = "0xB3604C", VA = "0xB3604C")]
		private void Min()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xB36094", Offset = "0xB36094", VA = "0xB36094")]
		public PhysicsGadgetSlider()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public enum DistanceGrabType
	{
		[Token(Token = "0x400065D")]
		Velocity,
		[Token(Token = "0x400065E")]
		Linear
	}
	[Token(Token = "0x200010D")]
	[HelpURL("https://earnestrobot.notion.site/Distance-Grabbing-19e4e8b14f00428295eca75fca752787")]
	[RequireComponent(typeof(Grabbable))]
	public class DistanceGrabbable : MonoBehaviour
	{
		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AutoHeader("Distance Grabbable", 0, 0)]
		public bool ignoreMe;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[Header("Pull")]
		public bool instantPull;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public DistanceGrabType grabType;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Use this to adjust the angle of the arch that the gameobject follows while shooting towards your hand.")]
		[Range(0.4f, 1.1f)]
		[ShowIf("grabType", DistanceGrabType.Velocity)]
		public float archMultiplier;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Slow down or speed up gravitation to your liking.")]
		[ShowIf("grabType", DistanceGrabType.Velocity)]
		public float gravitationVelocity;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Rotation")]
		[Tooltip("This enables rotation which makes the gameobject orient to the rotation of you hand as it moves through the air. All below rotation variables have no use when this is false.")]
		[ShowIf("grabType", DistanceGrabType.Velocity)]
		public bool rotate;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Speed that the object orients to the rotation of your hand.")]
		[ShowIf("grabType", DistanceGrabType.Velocity)]
		public float rotationSpeed;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AutoToggleHeader("Enable Highlighting", 0, 0)]
		[Tooltip("Whether or not to ignore all highlights including default highlights on HandPointGrab")]
		public bool ignoreHighlights;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[EnableIf("ignoreHighlights")]
		[Tooltip("Highlight targeted material to use - defaults to HandPointGrab materials if none")]
		public Material targetedMaterial;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Highlight selected material to use - defaults to HandPointGrab materials if none")]
		[EnableIf("ignoreHighlights")]
		public Material selectedMaterial;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AutoToggleHeader("Show Events", 0, 0)]
		public bool showEvents;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[ShowIf("showEvents")]
		public UnityHandGrabEvent OnPull;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[ShowIf("showEvents")]
		[Tooltip("Called when the object has been targeted/aimed at by the pointer")]
		[Space]
		public UnityHandGrabEvent StartTargeting;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[ShowIf("showEvents")]
		public UnityHandGrabEvent StopTargeting;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Space]
		[Tooltip("Called when the object has been selected before being pulled or flicked")]
		[ShowIf("showEvents")]
		public UnityHandGrabEvent StartSelecting;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[ShowIf("showEvents")]
		public UnityHandGrabEvent StopSelecting;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public HandGrabEvent OnPullCanceled;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal Grabbable grabbable;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform target;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 calculatedNecessaryVelocity;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool gravitationEnabled;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
		private bool gravitationMethodBegun;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9E")]
		private bool pullStarted;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody body;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float timePassedSincePull;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 lastGravitationVelocity;

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xB360BC", Offset = "0xB360BC", VA = "0xB360BC")]
		private void Start()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xB361EC", Offset = "0xB361EC", VA = "0xB361EC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xB36370", Offset = "0xB36370", VA = "0xB36370")]
		private void FollowHandRotation()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xB36450", Offset = "0xB36450", VA = "0xB36450")]
		private void GravitateTowardsHand()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xB362A8", Offset = "0xB362A8", VA = "0xB362A8")]
		private void InitialVelocityPushToHand()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xB36688", Offset = "0xB36688", VA = "0xB36688")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xB36618", Offset = "0xB36618", VA = "0xB36618")]
		private Vector3 CalculateTrajectoryVelocity(Vector3 origin, Vector3 target, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xB366EC", Offset = "0xB366EC", VA = "0xB366EC")]
		public void SetTarget(Transform theObject)
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xB366C8", Offset = "0xB366C8", VA = "0xB366C8")]
		public void CancelTarget()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xB36710", Offset = "0xB36710", VA = "0xB36710")]
		public DistanceGrabbable()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public enum HandGrabType
	{
		[Token(Token = "0x400067A")]
		Default,
		[Token(Token = "0x400067B")]
		HandToGrabbable,
		[Token(Token = "0x400067C")]
		GrabbableToHand
	}
	[Token(Token = "0x200010F")]
	[DefaultExecutionOrder(-2)]
	[HelpURL("https://earnestrobot.notion.site/Grabbables-9308c564e60848a882eb23e9778ee2b6")]
	public class Grabbable : GrabbableBase
	{
		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[Tooltip("This will copy the given grabbables settings to this grabbable when applied")]
		[OnValueChanged("EditorCopyGrabbable")]
		public Grabbable CopySettings;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Header("Grab Settings")]
		[Tooltip("Whether or not this can be grabbed with more than one hand")]
		public bool singleHandOnly;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		[ShowIf("singleHandOnly")]
		[Tooltip("if false single handed items cannot be passes back and forth on grab")]
		public bool allowHeldSwapping;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDA")]
		[Tooltip("Will the item automatically return the hand on grab - good for saved poses, bad for heavy things")]
		public bool instantGrab;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDB")]
		[Tooltip("Experimental - ignores weight of held object while held")]
		public bool ignoreWeight;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[Tooltip("Creates an offset an grab so the hand will not return to the hand on grab - Good for statically jointed grabbable objects")]
		public bool maintainGrabOffset;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDD")]
		[Tooltip("This will NOT parent the object under the hands on grab. This will parent the object to the parents of the hand, which allow you to move the hand parent object smoothly while holding an item, but will also allow you to move items that are very heavy - recommended for all objects that aren't very heavy or jointed to other rigidbodies")]
		public bool parentOnGrab;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Header("Release Settings")]
		[Tooltip("How much to multiply throw by for this grabbable when releasing - 0-1 for no or reduced throw strength")]
		[FormerlySerializedAs("throwMultiplyer")]
		public float throwPower;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[Tooltip("The required force to break the fixedJoint\n Turn this to \"infinity\" to disable (Might cause jitter)\nIdeal value depends on hand mass and velocity settings")]
		public float jointBreakForce;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AutoToggleHeader("Show Advanced", 0, 0)]
		public bool showAdvancedSettings;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[Tooltip("Which hand this can be held by")]
		[ShowIf("showAdvancedSettings")]
		public HandType handType;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[Tooltip("Which hand this can be held by")]
		[ShowIf("showAdvancedSettings")]
		public HandGrabType grabType;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[Tooltip("If true (and using HandToGrabbable) the hand will only return to the follow while moving. Good for picking up objects without disrupting the things around them")]
		[ShowIf("showAdvancedSettings")]
		public bool useGentleGrab;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF5")]
		[Tooltip("Adds and links a GrabbableChild to each child with a collider on start - So the hand can grab them")]
		[ShowIf("showAdvancedSettings")]
		public bool makeChildrenGrabbable;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF6")]
		[Tooltip("Whether or not the break call made only when holding with multiple hands - if this is false the break event can be called by forcing an object into a static collider")]
		[ShowIf("showAdvancedSettings")]
		public bool pullApartBreakOnly;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[Tooltip("The joint that connects the hand and the grabbable. Defaults to the joint in AutoHand/Resources/DefaultJoint.prefab if empty")]
		[Min(0f)]
		[ShowIf("showAdvancedSettings")]
		[Space]
		public ConfigurableJoint customGrabJoint;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Min(0f)]
		[ShowIf("showAdvancedSettings")]
		[Tooltip("The number of seconds that the hand collision should ignore the released object\n (Good for increased placement precision and resolves clipping errors)")]
		public float ignoreReleaseTime;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[Min(0f)]
		[Tooltip("I.E. Grab Prioirty - BIGGER IS BETTER - divides highlight distance by this when calculating which object to grab. Hands always grab closest object to palm")]
		[ShowIf("showAdvancedSettings")]
		public float grabPriorityWeight;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[Tooltip("Offsets the grabbable by this much when being held")]
		[ShowIf("showAdvancedSettings")]
		public Vector3 heldPositionOffset;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[ShowIf("showAdvancedSettings")]
		[Tooltip("Offsets the grabbable by this many degrees when being held")]
		public Vector3 heldRotationOffset;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[ShowIf("showAdvancedSettings")]
		[Tooltip("For the special use case of having grabbable objects with physics jointed peices move properly while being held")]
		[Space]
		public List<Rigidbody> jointedBodies;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[Tooltip("For the special use case of having things connected to the grabbable that the hand should ignore while being held (good for doors and drawers) -> for always active use the [GrabbableIgnoreHands] Component")]
		[ShowIf("showAdvancedSettings")]
		public List<Collider> heldIgnoreColliders;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AutoToggleHeader("Show Events", 0, 0)]
		public bool showEvents;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[ShowIf("showEvents")]
		[Space]
		public UnityHandGrabEvent onGrab;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[ShowIf("showEvents")]
		public UnityHandGrabEvent onRelease;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[AutoToggleHeader("Show Advanced Events", 0, 0)]
		public bool showAdvancedEvents;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[Space]
		[Space]
		[ShowIf("showAdvancedEvents")]
		public UnityHandGrabEvent onSqueeze;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[ShowIf("showAdvancedEvents")]
		public UnityHandGrabEvent onUnsqueeze;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[Space]
		[Space]
		[ShowIf("showAdvancedEvents")]
		public UnityHandGrabEvent onHighlight;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[ShowIf("showAdvancedEvents")]
		public UnityHandGrabEvent onUnhighlight;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[Space]
		[ShowIf("showAdvancedEvents")]
		[Space]
		public UnityHandGrabEvent OnJointBreak;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[Tooltip("Lock hand in place on grab (This is a legacy setting, set hand kinematic on grab/release instead)")]
		[ShowIf("showAdvancedSettings")]
		[HideInInspector]
		public bool lockHandOnGrab;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public HandGrabEvent OnBeforeGrabEvent;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public HandGrabEvent OnGrabEvent;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public HandGrabEvent OnReleaseEvent;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public HandGrabEvent OnJointBreakEvent;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public HandGrabEvent OnSqueezeEvent;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public HandGrabEvent OnUnsqueezeEvent;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public HandGrabEvent OnHighlightEvent;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public HandGrabEvent OnUnhighlightEvent;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private List<Grabbable> jointedGrabbables;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private float lastUpdateTime;

		[Token(Token = "0x17000079")]
		public float throwMultiplyer
		{
			[Token(Token = "0x60006E9")]
			[Address(RVA = "0xB36748", Offset = "0xB36748", VA = "0xB36748")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006EA")]
			[Address(RVA = "0xB36750", Offset = "0xB36750", VA = "0xB36750")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public bool wasForceReleased
		{
			[Token(Token = "0x60006EB")]
			[Address(RVA = "0xB36758", Offset = "0xB36758", VA = "0xB36758")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006EC")]
			[Address(RVA = "0xB36760", Offset = "0xB36760", VA = "0xB36760")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public Hand lastHeldBy
		{
			[Token(Token = "0x60006ED")]
			[Address(RVA = "0xB3676C", Offset = "0xB3676C", VA = "0xB3676C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006EE")]
			[Address(RVA = "0xB36774", Offset = "0xB36774", VA = "0xB36774")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xB36784", Offset = "0xB36784", VA = "0xB36784", Slot = "8")]
		protected new virtual void Awake()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xB36A14", Offset = "0xB36A14", VA = "0xB36A14", Slot = "9")]
		protected new virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xB36A90", Offset = "0xB36A90", VA = "0xB36A90", Slot = "10")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xB37604", Offset = "0xB37604", VA = "0xB37604", Slot = "11")]
		public virtual void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xB376DC", Offset = "0xB376DC", VA = "0xB376DC", Slot = "12")]
		public virtual void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xB3780C", Offset = "0xB3780C", VA = "0xB3780C")]
		internal void IgnoreColliders(Collider bodyCapsule, bool ignore = true)
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xB37958", Offset = "0xB37958", VA = "0xB37958", Slot = "13")]
		internal virtual void Highlight(Hand hand, [Optional] Material customMat)
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xB37DAC", Offset = "0xB37DAC", VA = "0xB37DAC", Slot = "14")]
		internal virtual void Unhighlight(Hand hand)
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xB37E98", Offset = "0xB37E98", VA = "0xB37E98", Slot = "15")]
		internal virtual void OnSqueeze(Hand hand)
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xB37F1C", Offset = "0xB37F1C", VA = "0xB37F1C", Slot = "16")]
		internal virtual void OnUnsqueeze(Hand hand)
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xB37FA0", Offset = "0xB37FA0", VA = "0xB37FA0", Slot = "17")]
		internal virtual void OnBeforeGrab(Hand hand)
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xB3805C", Offset = "0xB3805C", VA = "0xB3805C", Slot = "18")]
		internal virtual void OnGrab(Hand hand)
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xB38484", Offset = "0xB38484", VA = "0xB38484", Slot = "19")]
		public virtual bool CanGrab(HandBase hand)
		{
			return default(bool);
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xB384FC", Offset = "0xB384FC", VA = "0xB384FC", Slot = "20")]
		internal virtual void OnRelease(Hand hand)
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xB387EC", Offset = "0xB387EC", VA = "0xB387EC", Slot = "21")]
		internal virtual void BreakHandConnection(Hand hand)
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xB38BF8", Offset = "0xB38BF8", VA = "0xB38BF8", Slot = "22")]
		public virtual void HandsRelease()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xB38C8C", Offset = "0xB38C8C", VA = "0xB38C8C", Slot = "23")]
		public virtual void HandRelease(Hand hand)
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xB38D0C", Offset = "0xB38D0C", VA = "0xB38D0C", Slot = "24")]
		public virtual void ForceHandsRelease()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xB38DB8", Offset = "0xB38DB8", VA = "0xB38DB8", Slot = "25")]
		public virtual void ForceHandRelease(Hand hand)
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xB38E44", Offset = "0xB38E44", VA = "0xB38E44", Slot = "26")]
		public virtual void OnHandJointBreak(Hand hand)
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xB390EC", Offset = "0xB390EC", VA = "0xB390EC")]
		public Vector3 GetVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xB39134", Offset = "0xB39134", VA = "0xB39134")]
		public Vector3 GetAngularVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xB3926C", Offset = "0xB3926C", VA = "0xB3926C")]
		public List<Hand> GetHeldBy()
		{
			return null;
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xB3754C", Offset = "0xB3754C", VA = "0xB3754C")]
		public int HeldCount(bool includedJointedCount = true)
		{
			return default(int);
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xB39274", Offset = "0xB39274", VA = "0xB39274")]
		public bool IsHeld()
		{
			return default(bool);
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xB392C4", Offset = "0xB392C4", VA = "0xB392C4")]
		public bool BeingGrabbed()
		{
			return default(bool);
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xB392CC", Offset = "0xB392CC", VA = "0xB392CC")]
		public void PlayHapticVibration()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xB39418", Offset = "0xB39418", VA = "0xB39418")]
		public void PlayHapticVibration(float duration = 0.025f)
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xB39574", Offset = "0xB39574", VA = "0xB39574")]
		public void PlayHapticVibration(float duration, float amp = 0.5f)
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xB396D8", Offset = "0xB396D8", VA = "0xB396D8", Slot = "27")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xB39844", Offset = "0xB39844", VA = "0xB39844")]
		public void SetParentOnGrab(bool parentOnGrab)
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xB39850", Offset = "0xB39850", VA = "0xB39850")]
		public void AddJointedBody(Rigidbody body)
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xB39B14", Offset = "0xB39B14", VA = "0xB39B14")]
		public void RemoveJointedBody(Rigidbody body)
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xB39CC4", Offset = "0xB39CC4", VA = "0xB39CC4")]
		public void DoDestroy()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xB374F4", Offset = "0xB374F4", VA = "0xB374F4")]
		public int CollisionCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xB39D30", Offset = "0xB39D30", VA = "0xB39D30")]
		public int JointedCollisionCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xB3699C", Offset = "0xB3699C", VA = "0xB3699C")]
		private void MakeChildrenGrabbable()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xB397CC", Offset = "0xB397CC", VA = "0xB397CC")]
		private void MakeChildrenUngrabbable()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xB38A58", Offset = "0xB38A58", VA = "0xB38A58")]
		internal void ResetGrabbableAfterRlease()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xB3A114", Offset = "0xB3A114", VA = "0xB3A114")]
		public Grabbable()
		{
		}
	}
	[Token(Token = "0x2000110")]
	[DefaultExecutionOrder(1)]
	public class GrabbableChild : MonoBehaviour
	{
		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Grabbable grabParent;

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xB3B39C", Offset = "0xB3B39C", VA = "0xB3B39C")]
		private void Start()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xB3B4D4", Offset = "0xB3B4D4", VA = "0xB3B4D4")]
		public GrabbableChild()
		{
		}
	}
	[Token(Token = "0x2000111")]
	[RequireComponent(typeof(Grabbable))]
	public class GrabbableCollisionHaptics : MonoBehaviour
	{
		[Token(Token = "0x2000112")]
		[CompilerGenerated]
		private sealed class <PlayBuffer>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GrabbableCollisionHaptics <>4__this;

			[Token(Token = "0x1700007C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000724")]
				[Address(RVA = "0xB3BACC", Offset = "0xB3BACC", VA = "0xB3BACC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000726")]
				[Address(RVA = "0xB3BB14", Offset = "0xB3BB14", VA = "0xB3BB14", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000721")]
			[Address(RVA = "0xB3B910", Offset = "0xB3B910", VA = "0xB3B910")]
			[DebuggerHidden]
			public <PlayBuffer>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000722")]
			[Address(RVA = "0xB3B9F8", Offset = "0xB3B9F8", VA = "0xB3B9F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000723")]
			[Address(RVA = "0xB3B9FC", Offset = "0xB3B9FC", VA = "0xB3B9FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000725")]
			[Address(RVA = "0xB3BAD4", Offset = "0xB3BAD4", VA = "0xB3BAD4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000113")]
		[CompilerGenerated]
		private sealed class <HapticPlayBuffer>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GrabbableCollisionHaptics <>4__this;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float time;

			[Token(Token = "0x1700007E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600072A")]
				[Address(RVA = "0xB3BBF0", Offset = "0xB3BBF0", VA = "0xB3BBF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600072C")]
				[Address(RVA = "0xB3BC38", Offset = "0xB3BC38", VA = "0xB3BC38", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000727")]
			[Address(RVA = "0xB3B938", Offset = "0xB3B938", VA = "0xB3B938")]
			[DebuggerHidden]
			public <HapticPlayBuffer>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000728")]
			[Address(RVA = "0xB3BB1C", Offset = "0xB3BB1C", VA = "0xB3BB1C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000729")]
			[Address(RVA = "0xB3BB20", Offset = "0xB3BB20", VA = "0xB3BB20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0xB3BBF8", Offset = "0xB3BBF8", VA = "0xB3BBF8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The layers that cause the sound to play")]
		public LayerMask collisionTriggers;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float hapticAmp;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float velocityAmp;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float repeatDelay;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float maxDuration;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Source to play sound from")]
		public AnimationCurve velocityAmpCurve;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Source to play sound from")]
		public AnimationCurve velocityDurationCurve;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Grabbable grab;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Rigidbody body;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool canPlay;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine playRoutine;

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xB3B4DC", Offset = "0xB3B4DC", VA = "0xB3B4DC")]
		private void Start()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xB3B60C", Offset = "0xB3B60C", VA = "0xB3B60C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xB3B620", Offset = "0xB3B620", VA = "0xB3B620")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xB3B89C", Offset = "0xB3B89C", VA = "0xB3B89C")]
		[IteratorStateMachine(typeof(<PlayBuffer>d__14))]
		private IEnumerator PlayBuffer()
		{
			return null;
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xB3B588", Offset = "0xB3B588", VA = "0xB3B588")]
		[IteratorStateMachine(typeof(<HapticPlayBuffer>d__15))]
		private IEnumerator HapticPlayBuffer(float time)
		{
			return null;
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xB3B960", Offset = "0xB3B960", VA = "0xB3B960")]
		public GrabbableCollisionHaptics()
		{
		}
	}
	[Token(Token = "0x2000114")]
	[RequireComponent(typeof(Grabbable))]
	public class GrabbableExtraEvents : MonoBehaviour
	{
		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityHandGrabEvent OnFirstGrab;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityHandGrabEvent OnLastRelease;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityHandGrabEvent OnTwoHandedGrab;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityHandGrabEvent OnTwoHandedRelease;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Grabbable grab;

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xB3BC40", Offset = "0xB3BC40", VA = "0xB3BC40")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0xB3BDE8", Offset = "0xB3BDE8", VA = "0xB3BDE8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xB3BF98", Offset = "0xB3BF98", VA = "0xB3BF98")]
		public void Grab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xB3C05C", Offset = "0xB3C05C", VA = "0xB3C05C")]
		public void Release(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xB3C11C", Offset = "0xB3C11C", VA = "0xB3C11C")]
		public GrabbableExtraEvents()
		{
		}
	}
	[Token(Token = "0x2000115")]
	[RequireComponent(typeof(Grabbable))]
	public class GrabbableOnlyJoint : MonoBehaviour
	{
		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Grabbable jointedGrabbable;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool resetOnRelease;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Grabbable localGrabbable;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Joint freezeJoint;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 localStartPosition;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion localStartRotation;

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xB3C124", Offset = "0xB3C124", VA = "0xB3C124")]
		private void Start()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xB3C520", Offset = "0xB3C520", VA = "0xB3C520")]
		private void OnGrab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xB3C5C4", Offset = "0xB3C5C4", VA = "0xB3C5C4")]
		private void OnRelease(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xB3C7D0", Offset = "0xB3C7D0", VA = "0xB3C7D0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0xB3C944", Offset = "0xB3C944", VA = "0xB3C944")]
		private void CreateJoint()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0xB3CAB4", Offset = "0xB3CAB4", VA = "0xB3CAB4")]
		public GrabbableOnlyJoint()
		{
		}
	}
	[Token(Token = "0x2000116")]
	[HelpURL("https://earnestrobot.notion.site/Custom-Poses-868c1fa0590542a0b5b7937b5feb6b0d")]
	public class GrabbablePose : MonoBehaviour
	{
		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AutoHeader("Grabbable Pose", 0, 0)]
		public bool ignoreMe;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool poseEnabled;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Purely for organizational purposes in the editor")]
		public string poseName;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("This value must match the pose index of the a hand in order for the pose to work")]
		public int poseIndex;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Whether or not this pose can be used by both hands at once or only one hand at a time")]
		public bool singleHanded;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AutoToggleHeader("Advanced Settings", 0, 0)]
		public bool showAdvanced;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float positionWeight;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rotationWeight;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("These poses will only be enabled when this pose is active. Great for secondary poses like holding the front of a gun with your second hand, only while holding the trigger")]
		public GrabbablePose[] linkedPoses;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public bool showEditorTools;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Scriptable options NOT REQUIRED -> Create scriptable throught [Auto Hand/Custom Pose]")]
		[HideInInspector]
		public HandPoseScriptable poseScriptable;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Used to pose for the grabbable")]
		[HideInInspector]
		public Hand editorHand;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public HandPoseData rightPose;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[HideInInspector]
		public bool rightPoseSet;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public HandPoseData leftPose;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[HideInInspector]
		public bool leftPoseSet;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private List<Hand> posingHands;

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xB3CAC4", Offset = "0xB3CAC4", VA = "0xB3CAC4", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xB3CB14", Offset = "0xB3CB14", VA = "0xB3CB14")]
		public bool CanSetPose(Hand hand)
		{
			return default(bool);
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0xB3CBD4", Offset = "0xB3CBD4", VA = "0xB3CBD4", Slot = "5")]
		public virtual HandPoseData GetHandPoseData(Hand hand)
		{
			return default(HandPoseData);
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0xB3CC9C", Offset = "0xB3CC9C", VA = "0xB3CC9C", Slot = "6")]
		public virtual void SetHandPose(Hand hand, bool isProjection = false)
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0xB3CE38", Offset = "0xB3CE38", VA = "0xB3CE38", Slot = "7")]
		public virtual void CancelHandPose(Hand hand)
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0xB3CF00", Offset = "0xB3CF00", VA = "0xB3CF00")]
		public HandPoseData GetNewPoseData(Hand hand)
		{
			return default(HandPoseData);
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xB3D3C0", Offset = "0xB3D3C0", VA = "0xB3D3C0")]
		public bool HasPose(bool left)
		{
			return default(bool);
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xB3D474", Offset = "0xB3D474", VA = "0xB3D474")]
		public GrabbablePose()
		{
		}
	}
	[Token(Token = "0x2000118")]
	[HelpURL("https://earnestrobot.notion.site/Custom-Poses-868c1fa0590542a0b5b7937b5feb6b0d")]
	public class GrabbablePoseAdvanced : GrabbablePose
	{
		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Tooltip("Usually this can be left empty, used to create a different center point if the objects transform isn't ceneterd for the prefered rotation/movement axis")]
		public Transform centerObject;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Space]
		[Tooltip("You want this set so the disc gizmo is around the axis you want the hand to rotate, or that the line is straight through the axis you want to move")]
		public Vector3 up;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[Tooltip("Whether or not to automatically allow for the opposite direction pose to be automatically applied (I.E. Should I be able to grab my hammer only with the head facing up, or in both directions?)")]
		[Space]
		public bool useInvertPose;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[Tooltip("The minimum angle rotation around the included directions")]
		[Space]
		public int minAngle;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[Tooltip("The maximum angle rotation around the included directions")]
		public int maxAngle;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Tooltip("The minimum distance allowed from the saved posed along the included directions")]
		[Space]
		public float maxRange;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[Tooltip("The maximum distance allowed from the saved posed along the included directions")]
		public float minRange;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[Header("Requires Gizmos Enabled")]
		[Tooltip("Helps test pose by setting the angle of the editor hand, REQUIRES GIZMOS ENABLED")]
		public int testAngle;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[Tooltip("Helps test pose by setting the range position of the editor hand, REQUIRES GIZMOS ENABLED")]
		public float testRange;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int lastAngle;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private float lastRange;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 pregrabPos;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Quaternion pregrabRot;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Transform tempContainer;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Transform handMatch;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Transform getTransform;

		[Token(Token = "0x6000742")]
		[Address(RVA = "0xB3D6C4", Offset = "0xB3D6C4", VA = "0xB3D6C4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xB3D700", Offset = "0xB3D700", VA = "0xB3D700", Slot = "5")]
		public override HandPoseData GetHandPoseData(Hand hand)
		{
			return default(HandPoseData);
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0xB3DADC", Offset = "0xB3DADC", VA = "0xB3DADC")]
		public Quaternion GetClosestRotation(Hand hand, Vector3 up, bool addInverse)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xB3E77C", Offset = "0xB3E77C", VA = "0xB3E77C")]
		public Vector3 GetClosestPosition(Vector3 up)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xB3EB68", Offset = "0xB3EB68", VA = "0xB3EB68")]
		public HandPoseData GetHandPoseData(Hand hand, int angle, float range)
		{
			return default(HandPoseData);
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xB3DA5C", Offset = "0xB3DA5C", VA = "0xB3DA5C")]
		private Transform GetTransform()
		{
			return null;
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0xB3EEC0", Offset = "0xB3EEC0", VA = "0xB3EEC0")]
		public GrabbablePoseAdvanced()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class GrabbablePoseCombiner : MonoBehaviour
	{
		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<GrabbablePose> poses;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HandPoseData pose;

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xB3EF24", Offset = "0xB3EF24", VA = "0xB3EF24")]
		public bool CanSetPose(Hand hand)
		{
			return default(bool);
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xB3F0D8", Offset = "0xB3F0D8", VA = "0xB3F0D8")]
		public void AddPose(GrabbablePose pose)
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xB3F1C0", Offset = "0xB3F1C0", VA = "0xB3F1C0")]
		public GrabbablePose GetClosestPose(Hand hand)
		{
			return null;
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xB3F83C", Offset = "0xB3F83C", VA = "0xB3F83C")]
		internal int PoseCount()
		{
			return default(int);
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0xB3F884", Offset = "0xB3F884", VA = "0xB3F884")]
		public GrabbablePoseCombiner()
		{
		}
	}
	[Token(Token = "0x200011A")]
	[RequireComponent(typeof(Grabbable))]
	public class GrabbableSubstitute : MonoBehaviour
	{
		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Whether or not to disable this gameobject on grab")]
		public bool disableOnGrab;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[Tooltip("If true, the substitute will return to the this local location and turn off and the local grabbable will turn back on")]
		public bool returnOnRelease;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Grabbable grabbableSubstitute;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Grabbable localGrabbable;

		[Token(Token = "0x600074E")]
		[Address(RVA = "0xB3F90C", Offset = "0xB3F90C", VA = "0xB3F90C")]
		private void Start()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0xB3FAAC", Offset = "0xB3FAAC", VA = "0xB3FAAC")]
		private void OnGrabOriginal(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xB3FC4C", Offset = "0xB3FC4C", VA = "0xB3FC4C")]
		private void OnReleaseSub(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xB3FDB4", Offset = "0xB3FDB4", VA = "0xB3FDB4")]
		public void LocalSubstitute(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xB3FF30", Offset = "0xB3FF30", VA = "0xB3FF30")]
		public GrabbableSubstitute()
		{
		}
	}
	[Token(Token = "0x200011B")]
	[RequireComponent(typeof(Rigidbody), typeof(Grabbable))]
	public class GrabbableThrowEvent : MonoBehaviour
	{
		[Token(Token = "0x200011C")]
		[CompilerGenerated]
		private sealed class <ResetThrown>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GrabbableThrowEvent <>4__this;

			[Token(Token = "0x17000080")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600075E")]
				[Address(RVA = "0xB405B4", Offset = "0xB405B4", VA = "0xB405B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000081")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000760")]
				[Address(RVA = "0xB405FC", Offset = "0xB405FC", VA = "0xB405FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600075B")]
			[Address(RVA = "0xB402E4", Offset = "0xB402E4", VA = "0xB402E4")]
			[DebuggerHidden]
			public <ResetThrown>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0xB404E8", Offset = "0xB404E8", VA = "0xB404E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600075D")]
			[Address(RVA = "0xB404EC", Offset = "0xB404EC", VA = "0xB404EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600075F")]
			[Address(RVA = "0xB405BC", Offset = "0xB405BC", VA = "0xB405BC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The velocity magnitude required on collision to cause the break event")]
		public float breakVelocity;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The layers that will cause this grabbale to break")]
		public LayerMask collisionLayers;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEvent OnBreak;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody rb;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Grabbable grab;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool thrown;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine resetThrowing;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float throwTime;

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xB3FF40", Offset = "0xB3FF40", VA = "0xB3FF40")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xB3FFD0", Offset = "0xB3FFD0", VA = "0xB3FFD0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xB400AC", Offset = "0xB400AC", VA = "0xB400AC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0xB40188", Offset = "0xB40188", VA = "0xB40188")]
		private void OnReleased(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xB40270", Offset = "0xB40270", VA = "0xB40270")]
		[IteratorStateMachine(typeof(<ResetThrown>d__12))]
		private IEnumerator ResetThrown()
		{
			return null;
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xB4030C", Offset = "0xB4030C", VA = "0xB4030C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0xB40494", Offset = "0xB40494", VA = "0xB40494")]
		private void Break()
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0xB404B0", Offset = "0xB404B0", VA = "0xB404B0")]
		public GrabbableThrowEvent()
		{
		}
	}
	[Token(Token = "0x200011D")]
	[RequireComponent(typeof(Grabbable))]
	public class GrabLock : MonoBehaviour
	{
		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Hand.Released() must be called elsewhere")]
		[Header("Use this script to prevent grabbable release")]
		public UnityEvent OnGrabPressed;

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xB40604", Offset = "0xB40604", VA = "0xB40604")]
		public GrabLock()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public delegate void PlacePointEvent(PlacePoint point, Grabbable grabbable);
	[Token(Token = "0x200011F")]
	[RequireComponent(typeof(SphereCollider))]
	[HelpURL("https://earnestrobot.notion.site/Place-Points-e6361a414928450dbb53d76fd653cf9a")]
	public class PlacePoint : MonoBehaviour
	{
		[Token(Token = "0x2000120")]
		[CompilerGenerated]
		private sealed class <HighlightSafetyCheck>d__47 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlacePoint <>4__this;

			[Token(Token = "0x17000085")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000780")]
				[Address(RVA = "0xB41E84", Offset = "0xB41E84", VA = "0xB41E84", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000086")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000782")]
				[Address(RVA = "0xB41ECC", Offset = "0xB41ECC", VA = "0xB41ECC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600077D")]
			[Address(RVA = "0xB4092C", Offset = "0xB4092C", VA = "0xB4092C")]
			[DebuggerHidden]
			public <HighlightSafetyCheck>d__47(int <>1__state)
			{
			}

			[Token(Token = "0x600077E")]
			[Address(RVA = "0xB41D58", Offset = "0xB41D58", VA = "0xB41D58", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600077F")]
			[Address(RVA = "0xB41D5C", Offset = "0xB41D5C", VA = "0xB41D5C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000781")]
			[Address(RVA = "0xB41E8C", Offset = "0xB41E8C", VA = "0xB41E8C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AutoHeader("Place Point", 0, 0)]
		public bool ignoreMe;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If used, the place point will only accept this grabbable as a target")]
		public Grabbable matchTarget;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Will allow placement for any grabbable with a name containing this array of strings, leave blank for any grabbable allowed")]
		public string[] placeNames;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The radius of the place point")]
		public float placeRadius;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("This will make the point place the object as soon as it enters the radius, instead of on release")]
		public bool forcePlace;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		[Tooltip("If true and will force release on place")]
		[ShowIf("forcePlace")]
		public bool forceHandRelease;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		[Tooltip("Whether or not the grabbable should be disabled on placement, (Good for things like placed keys)")]
		public bool disableGrabOnPlace;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		[Tooltip("Whether or not the grabbable should be disabled on placement")]
		public bool disableObjectOnPlace;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Whether or not the grabbable should be destroyed on placement, (Good for things like loaded magazines, combined with enabling static magazine)")]
		public bool destroyObjectOnPlace;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[Tooltip("Makes the object being placedObject kinematic")]
		[AutoToggleHeader("Use Kinematic", 0, 0)]
		public bool makePlacedKinematic;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Space]
		[Tooltip("The rigidbody to attach the placed grabbable to - leave empty means no joint")]
		[HideIf("makePlacedKinematic")]
		public Rigidbody placedJointLink;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideIf("makePlacedKinematic")]
		[FormerlySerializedAs("placedJointBreakForce")]
		public float jointBreakForce;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AutoToggleHeader("Show Advanced", 0, 0)]
		public bool showAdvanced;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Snaps an object to the point at start, leave empty for no target")]
		[ShowIf("showAdvanced")]
		public Grabbable startPlaced;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[ShowIf("showAdvanced")]
		[Tooltip("The object will snap to this point instead of the place point on place")]
		public Transform placedOffset;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[ShowIf("showAdvanced")]
		[Tooltip("This will make the point place the object as soon as it enters the radius, instead of on release")]
		public bool parentOnPlace;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[ShowIf("showAdvanced")]
		[Tooltip("Whether or not to only allow placement of an object while it's being held (or released)")]
		public bool heldPlaceOnly;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[ShowIf("showAdvanced")]
		[Tooltip("Will prevent placement for any name containing this array of strings")]
		public string[] blacklistNames;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AutoToggleHeader("Show Events", 0, 0)]
		public bool showEvents;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[ShowIf("showEvents")]
		public UnityEvent OnPlace;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[ShowIf("showEvents")]
		public UnityEvent OnRemove;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[ShowIf("showEvents")]
		public UnityEvent OnHighlight;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[ShowIf("showEvents")]
		public UnityEvent OnStopHighlight;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public PlacePointEvent OnPlaceEvent;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public PlacePointEvent OnRemoveEvent;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public PlacePointEvent OnHighlightEvent;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public PlacePointEvent OnStopHighlightEvent;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		protected FixedJoint joint;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected float removalDistance;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		protected Vector3 placePosition;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		protected SphereCollider col;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected Transform originParent;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected bool placingFrame;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		protected CollisionDetectionMode placedObjDetectionMode;

		[Token(Token = "0x17000082")]
		public Grabbable highlightingObj
		{
			[Token(Token = "0x6000766")]
			[Address(RVA = "0xB40768", Offset = "0xB40768", VA = "0xB40768")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000767")]
			[Address(RVA = "0xB40770", Offset = "0xB40770", VA = "0xB40770")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public Grabbable placedObject
		{
			[Token(Token = "0x6000768")]
			[Address(RVA = "0xB40778", Offset = "0xB40778", VA = "0xB40778")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000769")]
			[Address(RVA = "0xB40780", Offset = "0xB40780", VA = "0xB40780")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public Grabbable lastPlacedObject
		{
			[Token(Token = "0x600076A")]
			[Address(RVA = "0xB40788", Offset = "0xB40788", VA = "0xB40788")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600076B")]
			[Address(RVA = "0xB40790", Offset = "0xB40790", VA = "0xB40790")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0xB40798", Offset = "0xB40798", VA = "0xB40798", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0xB408B8", Offset = "0xB408B8", VA = "0xB408B8")]
		[IteratorStateMachine(typeof(<HighlightSafetyCheck>d__47))]
		private IEnumerator HighlightSafetyCheck()
		{
			return null;
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0xB40954", Offset = "0xB40954", VA = "0xB40954", Slot = "5")]
		public virtual bool CanPlace(Grabbable placeObj)
		{
			return default(bool);
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0xB40B3C", Offset = "0xB40B3C", VA = "0xB40B3C", Slot = "6")]
		public virtual void Place(Grabbable placeObj)
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0xB41178", Offset = "0xB41178", VA = "0xB41178")]
		public void Remove()
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xB411FC", Offset = "0xB411FC", VA = "0xB411FC", Slot = "7")]
		public virtual void Remove(Grabbable placeObj)
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0xB414F0", Offset = "0xB414F0", VA = "0xB414F0", Slot = "8")]
		internal virtual void Highlight(Grabbable from)
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0xB41610", Offset = "0xB41610", VA = "0xB41610", Slot = "9")]
		internal virtual void StopHighlight(Grabbable from)
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0xB41748", Offset = "0xB41748", VA = "0xB41748")]
		protected bool IsOverlapping(Grabbable from)
		{
			return default(bool);
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0xB418D0", Offset = "0xB418D0", VA = "0xB418D0", Slot = "10")]
		public virtual void SetStartPlaced()
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xB4196C", Offset = "0xB4196C", VA = "0xB4196C")]
		public Grabbable GetPlacedObject()
		{
			return null;
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xB41974", Offset = "0xB41974", VA = "0xB41974")]
		internal float Distance(Transform from)
		{
			return default(float);
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xB41A7C", Offset = "0xB41A7C", VA = "0xB41A7C", Slot = "11")]
		protected virtual void OnPlacedObjectGrabbed(Hand pHand, Grabbable pGrabbable)
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0xB41AB0", Offset = "0xB41AB0", VA = "0xB41AB0", Slot = "12")]
		protected virtual void OnPlacedObjectReleased(Hand pHand, Grabbable pGrabbable)
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0xB41AD0", Offset = "0xB41AD0", VA = "0xB41AD0", Slot = "13")]
		protected virtual void OnJointBreak(float breakForce)
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0xB41B54", Offset = "0xB41B54", VA = "0xB41B54")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0xB41D1C", Offset = "0xB41D1C", VA = "0xB41D1C")]
		public PlacePoint()
		{
		}
	}
	[Token(Token = "0x2000121")]
	[RequireComponent(typeof(Rigidbody))]
	[DefaultExecutionOrder(1)]
	public class WeightlessFollower : MonoBehaviour
	{
		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public Transform follow;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public Transform follow1;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dictionary<Hand, Transform> heldMoveTo;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public float followPositionStrength;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[HideInInspector]
		public float followRotationStrength;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public float maxVelocity;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public Grabbable grab;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal Rigidbody body;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform moveTo;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float startMass;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float startDrag;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float startAngleDrag;

		[Token(Token = "0x6000783")]
		[Address(RVA = "0xB41ED4", Offset = "0xB41ED4", VA = "0xB41ED4")]
		public void Start()
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0xB41FC4", Offset = "0xB41FC4", VA = "0xB41FC4", Slot = "4")]
		public virtual void Set(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0xB426C0", Offset = "0xB426C0", VA = "0xB426C0", Slot = "5")]
		public virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0xB42750", Offset = "0xB42750", VA = "0xB42750")]
		protected void SetMoveTo()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0xB42928", Offset = "0xB42928", VA = "0xB42928", Slot = "6")]
		protected virtual void MoveTo()
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0xB42CFC", Offset = "0xB42CFC", VA = "0xB42CFC", Slot = "7")]
		protected virtual void TorqueTo()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0xB42FBC", Offset = "0xB42FBC", VA = "0xB42FBC")]
		private int CollisionCount()
		{
			return default(int);
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0xB42FD8", Offset = "0xB42FD8", VA = "0xB42FD8")]
		public void RemoveFollow(Hand hand, Transform follow)
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0xB432F4", Offset = "0xB432F4", VA = "0xB432F4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0xB434F4", Offset = "0xB434F4", VA = "0xB434F4")]
		public WeightlessFollower()
		{
		}
	}
	[Token(Token = "0x2000122")]
	[HelpURL("https://earnestrobot.notion.site/Fingers-63ae83cda0b14a35b5ae15beeb51dc03")]
	public class Finger : MonoBehaviour
	{
		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Tips")]
		[Tooltip("This transfrom will represent the tip/stopper of the finger")]
		public Transform tip;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("This determines the radius of the spherecast check when bending fingers")]
		public float tipRadius;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("This will offset the fingers bend (0 is no bend, 1 is full bend)")]
		[Range(0f, 1f)]
		public float bendOffset;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fingerSmoothSpeed;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		public float secondaryOffset;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float currBendOffset;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float bend;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private Quaternion[] minGripRotPose;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		private Vector3[] minGripPosPose;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		private Quaternion[] maxGripRotPose;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		private Vector3[] maxGripPosPose;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		[SerializeField]
		private Transform[] fingerJoints;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float lastHitBend;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Collider[] results;

		[Token(Token = "0x600078F")]
		[Address(RVA = "0xB4365C", Offset = "0xB4365C", VA = "0xB4365C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0xB436D8", Offset = "0xB436D8", VA = "0xB436D8")]
		public bool BendFingerUntilHit(int steps, int layermask)
		{
			return default(bool);
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0xB43CE0", Offset = "0xB43CE0", VA = "0xB43CE0")]
		public bool UpdateFingerBend(float bend, int layermask)
		{
			return default(bool);
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0xB43F44", Offset = "0xB43F44", VA = "0xB43F44")]
		public void UpdateFinger()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0xB440CC", Offset = "0xB440CC", VA = "0xB440CC")]
		public void UpdateFinger(float bend)
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0xB44258", Offset = "0xB44258", VA = "0xB44258")]
		public void SetFingerBend(float bend)
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0xB443E4", Offset = "0xB443E4", VA = "0xB443E4")]
		public void SetCurrentFingerBend(float bend)
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0xB43660", Offset = "0xB43660", VA = "0xB43660")]
		private void SlowBend()
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0xB43BF8", Offset = "0xB43BF8", VA = "0xB43BF8")]
		[ContextMenu("ResetBend")]
		public void ResetBend()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xB44570", Offset = "0xB44570", VA = "0xB44570")]
		[ContextMenu("Grip")]
		public void Grip()
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xB44658", Offset = "0xB44658", VA = "0xB44658")]
		public float GetLastHitBend()
		{
			return default(float);
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xB44660", Offset = "0xB44660", VA = "0xB44660")]
		[ContextMenu("Set Open Finger Pose")]
		public void SetMinPose()
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0xB449A0", Offset = "0xB449A0", VA = "0xB449A0")]
		[ContextMenu("Set Closed Finger Pose")]
		public void SetMaxPose()
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0xB44CE0", Offset = "0xB44CE0", VA = "0xB44CE0")]
		public bool IsMinPoseSaved()
		{
			return default(bool);
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xB44D04", Offset = "0xB44D04", VA = "0xB44D04")]
		public bool IsMaxPoseSaved()
		{
			return default(bool);
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xB44D28", Offset = "0xB44D28", VA = "0xB44D28")]
		public float GetCurrentBend()
		{
			return default(float);
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0xB44D34", Offset = "0xB44D34", VA = "0xB44D34")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xB44DE8", Offset = "0xB44DE8", VA = "0xB44DE8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xB44F78", Offset = "0xB44F78", VA = "0xB44F78")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000123")]
	[DefaultExecutionOrder(-10)]
	[HelpURL("https://earnestrobot.notion.site/Hand-967e36c2ab2945b2b0f75cea84624b2f")]
	public class Hand : HandBase
	{
		[Token(Token = "0x2000125")]
		[CompilerGenerated]
		private sealed class <HighlightUpdate>d__125 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Hand <>4__this;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float timestep;

			[Token(Token = "0x17000088")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000816")]
				[Address(RVA = "0xB4C158", Offset = "0xB4C158", VA = "0xB4C158", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000089")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000818")]
				[Address(RVA = "0xB4C1A0", Offset = "0xB4C1A0", VA = "0xB4C1A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000813")]
			[Address(RVA = "0xB4B1B4", Offset = "0xB4B1B4", VA = "0xB4B1B4")]
			[DebuggerHidden]
			public <HighlightUpdate>d__125(int <>1__state)
			{
			}

			[Token(Token = "0x6000814")]
			[Address(RVA = "0xB4C040", Offset = "0xB4C040", VA = "0xB4C040", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000815")]
			[Address(RVA = "0xB4C044", Offset = "0xB4C044", VA = "0xB4C044", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000817")]
			[Address(RVA = "0xB4C160", Offset = "0xB4C160", VA = "0xB4C160", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000126")]
		[CompilerGenerated]
		private struct <>c__DisplayClass127_0
		{
			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Hand <>4__this;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Grabbable startHoldingObj;
		}

		[Token(Token = "0x2000127")]
		[CompilerGenerated]
		private sealed class <GrabObject>d__127 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Hand <>4__this;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Grabbable grab;

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public RaycastHit hit;

			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public GrabType grabType;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private <>c__DisplayClass127_0 <>8__1;

			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool <instantGrab>5__2;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private HandPoseData <startGrabPose>5__3;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Vector3 <startGrabbablePosition>5__4;

			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private Quaternion <startGrabbableRotation>5__5;

			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private float <adjustedGrabTime>5__6;

			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private Transform <grabTarget>5__7;

			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private HandPoseData <postGrabPose>5__8;

			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			private Vector3 <endGrabbablePosition>5__9;

			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			private Quaternion <endGrabbableRotation>5__10;

			[Token(Token = "0x4000781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private float <i>5__11;

			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			private bool <useGravity>5__12;

			[Token(Token = "0x1700008A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600081C")]
				[Address(RVA = "0xB4DFC0", Offset = "0xB4DFC0", VA = "0xB4DFC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600081E")]
				[Address(RVA = "0xB4E008", Offset = "0xB4E008", VA = "0xB4E008", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000819")]
			[Address(RVA = "0xB4B1DC", Offset = "0xB4B1DC", VA = "0xB4B1DC")]
			[DebuggerHidden]
			public <GrabObject>d__127(int <>1__state)
			{
			}

			[Token(Token = "0x600081A")]
			[Address(RVA = "0xB4C1A8", Offset = "0xB4C1A8", VA = "0xB4C1A8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600081B")]
			[Address(RVA = "0xB4C1AC", Offset = "0xB4C1AC", VA = "0xB4C1AC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600081D")]
			[Address(RVA = "0xB4DFC8", Offset = "0xB4DFC8", VA = "0xB4DFC8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000128")]
		[CompilerGenerated]
		private sealed class <LerpHandPose>d__129 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Hand <>4__this;

			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HandPoseData fromPose;

			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public HandPoseData toPose;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public float totalTime;

			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float <timePassed>5__2;

			[Token(Token = "0x1700008C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000822")]
				[Address(RVA = "0xB4E250", Offset = "0xB4E250", VA = "0xB4E250", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000824")]
				[Address(RVA = "0xB4E298", Offset = "0xB4E298", VA = "0xB4E298", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600081F")]
			[Address(RVA = "0xB4B330", Offset = "0xB4B330", VA = "0xB4B330")]
			[DebuggerHidden]
			public <LerpHandPose>d__129(int <>1__state)
			{
			}

			[Token(Token = "0x6000820")]
			[Address(RVA = "0xB4E010", Offset = "0xB4E010", VA = "0xB4E010", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000821")]
			[Address(RVA = "0xB4E014", Offset = "0xB4E014", VA = "0xB4E014", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000823")]
			[Address(RVA = "0xB4E258", Offset = "0xB4E258", VA = "0xB4E258", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		[AutoToggleHeader("Enable Highlight", 0, 0, tooltip = "Raycasting for grabbables to highlight is expensive, you can disable it here if you aren't using it")]
		public bool usingHighlight;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x244")]
		[Tooltip("The layers to highlight and use look assist on --- Nothing will default on start")]
		[EnableIf("usingHighlight")]
		public LayerMask highlightLayers;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		[EnableIf("usingHighlight")]
		[Tooltip("Leave empty for none - used as a default option for all grabbables with empty highlight material")]
		public Material defaultHighlight;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		[AutoToggleHeader("Show Advanced", 0, 0)]
		public bool showAdvanced;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x254")]
		[Tooltip("Whether the hand should go to the object and come back on grab, or the object to float to the hand on grab. Will default to HandToGrabbable for objects that have \"parentOnGrab\" disabled")]
		[ShowIf("showAdvanced")]
		public GrabType grabType;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		[ShowIf("showAdvanced")]
		[Tooltip("Makes grab smoother; also based on range and reach distance - a very near grab is instant and a max distance grab is [X] frames")]
		[Min(0f)]
		public float minGrabTime;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
		[Min(0f)]
		[ShowIf("showAdvanced")]
		[Tooltip("Makes grab smoother; also based on range and reach distance - a very near grab is instant and a max distance grab is [X] frames")]
		public float maxGrabTime;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		[Min(0f)]
		[ShowIf("showAdvanced")]
		[Tooltip("The animation curve based on the grab time 0-1")]
		public AnimationCurve grabCurve;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		[ShowIf("showAdvanced")]
		[Tooltip("Speed at which the gentle grab returns the grabbable")]
		[Min(0f)]
		public float smoothReturnSpeed;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
		[ShowIf("showAdvanced")]
		[Tooltip("This is used in conjunction with custom poses. For a custom pose to work it must has the same PoseIndex as the hand. Used for when your game has multiple hands")]
		public int poseIndex;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		[AutoLine(0, 0)]
		public bool ignoreMe1;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] grabbableLayers;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string grabbableLayerNameDefault;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string grabbingLayerName;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string rightHandLayerName;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string leftHandLayerName;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private List<HandTriggerAreaEvents> triggerEventAreas;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private Coroutine tryGrab;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private Coroutine highlightRoutine;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private float startGrabDist;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private HandPoseData openHandPose;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		private Grabbable lastHoldingObj;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		private Coroutine _grabRoutine;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		private Vector3 startHandGrabPosition;

		[Token(Token = "0x17000087")]
		private Coroutine grabRoutine
		{
			[Token(Token = "0x60007CB")]
			[Address(RVA = "0xB46560", Offset = "0xB46560", VA = "0xB46560")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007CC")]
			[Address(RVA = "0xB46568", Offset = "0xB46568", VA = "0xB46568")]
			set
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event HandGrabEvent OnTriggerGrab
		{
			[Token(Token = "0x60007A9")]
			[Address(RVA = "0xB45160", Offset = "0xB45160", VA = "0xB45160")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007AA")]
			[Address(RVA = "0xB45200", Offset = "0xB45200", VA = "0xB45200")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		public event HandGrabEvent OnBeforeGrabbed
		{
			[Token(Token = "0x60007AB")]
			[Address(RVA = "0xB452A0", Offset = "0xB452A0", VA = "0xB452A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007AC")]
			[Address(RVA = "0xB45340", Offset = "0xB45340", VA = "0xB45340")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public event HandGrabEvent OnGrabbed
		{
			[Token(Token = "0x60007AD")]
			[Address(RVA = "0xB453E0", Offset = "0xB453E0", VA = "0xB453E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007AE")]
			[Address(RVA = "0xB45480", Offset = "0xB45480", VA = "0xB45480")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event HandGrabEvent OnTriggerRelease
		{
			[Token(Token = "0x60007AF")]
			[Address(RVA = "0xB45520", Offset = "0xB45520", VA = "0xB45520")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007B0")]
			[Address(RVA = "0xB455C0", Offset = "0xB455C0", VA = "0xB455C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public event HandGrabEvent OnBeforeReleased
		{
			[Token(Token = "0x60007B1")]
			[Address(RVA = "0xB45660", Offset = "0xB45660", VA = "0xB45660")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007B2")]
			[Address(RVA = "0xB45700", Offset = "0xB45700", VA = "0xB45700")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000C")]
		public event HandGrabEvent OnReleased
		{
			[Token(Token = "0x60007B3")]
			[Address(RVA = "0xB42620", Offset = "0xB42620", VA = "0xB42620")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007B4")]
			[Address(RVA = "0xB43254", Offset = "0xB43254", VA = "0xB43254")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000D")]
		public event HandGrabEvent OnSqueezed
		{
			[Token(Token = "0x60007B5")]
			[Address(RVA = "0xB457A0", Offset = "0xB457A0", VA = "0xB457A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007B6")]
			[Address(RVA = "0xB45840", Offset = "0xB45840", VA = "0xB45840")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public event HandGrabEvent OnUnsqueezed
		{
			[Token(Token = "0x60007B7")]
			[Address(RVA = "0xB458E0", Offset = "0xB458E0", VA = "0xB458E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007B8")]
			[Address(RVA = "0xB45980", Offset = "0xB45980", VA = "0xB45980")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000F")]
		public event HandGrabEvent OnHighlight
		{
			[Token(Token = "0x60007B9")]
			[Address(RVA = "0xB45A20", Offset = "0xB45A20", VA = "0xB45A20")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007BA")]
			[Address(RVA = "0xB45AC0", Offset = "0xB45AC0", VA = "0xB45AC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000010")]
		public event HandGrabEvent OnStopHighlight
		{
			[Token(Token = "0x60007BB")]
			[Address(RVA = "0xB45B60", Offset = "0xB45B60", VA = "0xB45B60")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007BC")]
			[Address(RVA = "0xB45C00", Offset = "0xB45C00", VA = "0xB45C00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event HandGrabEvent OnForcedRelease
		{
			[Token(Token = "0x60007BD")]
			[Address(RVA = "0xB45CA0", Offset = "0xB45CA0", VA = "0xB45CA0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007BE")]
			[Address(RVA = "0xB45D40", Offset = "0xB45D40", VA = "0xB45D40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event HandGrabEvent OnGrabJointBreak
		{
			[Token(Token = "0x60007BF")]
			[Address(RVA = "0xB45DE0", Offset = "0xB45DE0", VA = "0xB45DE0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007C0")]
			[Address(RVA = "0xB45E80", Offset = "0xB45E80", VA = "0xB45E80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000013")]
		public event HandGrabEvent OnHeldConnectionBreak
		{
			[Token(Token = "0x60007C1")]
			[Address(RVA = "0xB45F20", Offset = "0xB45F20", VA = "0xB45F20")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007C2")]
			[Address(RVA = "0xB45FC0", Offset = "0xB45FC0", VA = "0xB45FC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000014")]
		public event HandGameObjectEvent OnHandCollisionStart
		{
			[Token(Token = "0x60007C3")]
			[Address(RVA = "0xB46060", Offset = "0xB46060", VA = "0xB46060")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007C4")]
			[Address(RVA = "0xB46100", Offset = "0xB46100", VA = "0xB46100")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000015")]
		public event HandGameObjectEvent OnHandCollisionStop
		{
			[Token(Token = "0x60007C5")]
			[Address(RVA = "0xB461A0", Offset = "0xB461A0", VA = "0xB461A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007C6")]
			[Address(RVA = "0xB46240", Offset = "0xB46240", VA = "0xB46240")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000016")]
		public event HandGameObjectEvent OnHandTriggerStart
		{
			[Token(Token = "0x60007C7")]
			[Address(RVA = "0xB462E0", Offset = "0xB462E0", VA = "0xB462E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007C8")]
			[Address(RVA = "0xB46380", Offset = "0xB46380", VA = "0xB46380")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000017")]
		public event HandGameObjectEvent OnHandTriggerStop
		{
			[Token(Token = "0x60007C9")]
			[Address(RVA = "0xB46420", Offset = "0xB46420", VA = "0xB46420")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007CA")]
			[Address(RVA = "0xB464C0", Offset = "0xB464C0", VA = "0xB464C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xB466C8", Offset = "0xB466C8", VA = "0xB466C8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xB468D8", Offset = "0xB468D8", VA = "0xB468D8", Slot = "20")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xB469A8", Offset = "0xB469A8", VA = "0xB469A8", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xB46CA0", Offset = "0xB46CA0", VA = "0xB46CA0", Slot = "6")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xB47104", Offset = "0xB47104", VA = "0xB47104", Slot = "9")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xB47754", Offset = "0xB47754", VA = "0xB47754")]
		private float GetGrabTime()
		{
			return default(float);
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xB478C0", Offset = "0xB478C0", VA = "0xB478C0", Slot = "21")]
		public virtual void Grab()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xB478D4", Offset = "0xB478D4", VA = "0xB478D4", Slot = "22")]
		public virtual void Grab(GrabType grabType)
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xB47E54", Offset = "0xB47E54", VA = "0xB47E54", Slot = "23")]
		public virtual void Grab(RaycastHit hit, Grabbable grab, GrabType grabType = GrabType.InstantGrab)
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xB47F9C", Offset = "0xB47F9C", VA = "0xB47F9C", Slot = "24")]
		public virtual void TryGrab(Grabbable grab)
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xB48830", Offset = "0xB48830", VA = "0xB48830", Slot = "25")]
		public virtual void Release()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xB48AEC", Offset = "0xB48AEC", VA = "0xB48AEC", Slot = "26")]
		public virtual void ForceReleaseGrab()
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xB48B98", Offset = "0xB48B98", VA = "0xB48B98", Slot = "27")]
		public virtual void ReleaseGrabLock()
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xB48BA8", Offset = "0xB48BA8", VA = "0xB48BA8", Slot = "28")]
		public virtual void Squeeze()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xB48D40", Offset = "0xB48D40", VA = "0xB48D40", Slot = "29")]
		public virtual void Unsqueeze()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xB48ED4", Offset = "0xB48ED4", VA = "0xB48ED4", Slot = "30")]
		public virtual void BreakGrabConnection(bool callEvent = true)
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xB49244", Offset = "0xB49244", VA = "0xB49244", Slot = "31")]
		public virtual void CreateGrabConnection(Grabbable grab, Vector3 handPos, Quaternion handRot, Vector3 grabPos, Quaternion grabRot, bool executeGrabEvents = false)
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xB49794", Offset = "0xB49794", VA = "0xB49794", Slot = "32")]
		public virtual void OnJointBreak(float breakForce)
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xB49924", Offset = "0xB49924", VA = "0xB49924", Slot = "33")]
		public virtual void UpdateHighlight()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xB47D20", Offset = "0xB47D20", VA = "0xB47D20")]
		public RaycastHit GetHighlightHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xB49C4C", Offset = "0xB49C4C", VA = "0xB49C4C")]
		public void AutoPose(RaycastHit hit, Grabbable grabbable)
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xB4A284", Offset = "0xB4A284", VA = "0xB4A284")]
		public HandPoseData GetHandPose()
		{
			return default(HandPoseData);
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xB4A2A4", Offset = "0xB4A2A4", VA = "0xB4A2A4")]
		public HandPoseData GetHeldPose()
		{
			return default(HandPoseData);
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xB4A360", Offset = "0xB4A360", VA = "0xB4A360", Slot = "34")]
		public virtual void SetHeldPose(HandPoseData pose, Grabbable grabbable, bool createJoint = true)
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xB4A608", Offset = "0xB4A608", VA = "0xB4A608")]
		public void SetHandPose(HandPoseData pose)
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xB4A620", Offset = "0xB4A620", VA = "0xB4A620")]
		public void SetHandPose(GrabbablePose pose)
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xB4A698", Offset = "0xB4A698", VA = "0xB4A698")]
		public void UpdatePose(HandPoseData pose, float time)
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xB4A7CC", Offset = "0xB4A7CC", VA = "0xB4A7CC")]
		public GrabbablePose GetGrabPose(Transform from, Grabbable grabbable)
		{
			return null;
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xB4A838", Offset = "0xB4A838", VA = "0xB4A838")]
		public bool GetCurrentHeldGrabPose(Transform from, Grabbable grabbable, out GrabbablePose grabPose, out Transform relativeTo)
		{
			return default(bool);
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xB4A950", Offset = "0xB4A950", VA = "0xB4A950")]
		public Grabbable GetHeldGrabbable()
		{
			return null;
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xB4A958", Offset = "0xB4A958", VA = "0xB4A958")]
		public Grabbable GetHeld()
		{
			return null;
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xB4A960", Offset = "0xB4A960", VA = "0xB4A960")]
		public bool IsSqueezing()
		{
			return default(bool);
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xB4A968", Offset = "0xB4A968", VA = "0xB4A968")]
		public void SetGrip(float grip)
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xB4A970", Offset = "0xB4A970", VA = "0xB4A970")]
		[ContextMenu("Set Pose - Relax Hand")]
		public void RelaxHand()
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xB4A9D4", Offset = "0xB4A9D4", VA = "0xB4A9D4")]
		[ContextMenu("Set Pose - Open Hand")]
		public void OpenHand()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xB4AA34", Offset = "0xB4AA34", VA = "0xB4AA34")]
		[ContextMenu("Set Pose - Close Hand")]
		public void CloseHand()
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xB4AAA0", Offset = "0xB4AAA0", VA = "0xB4AAA0")]
		[ContextMenu("Bend Fingers Until Hit")]
		public void ProceduralFingerBend()
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xB4ABC8", Offset = "0xB4ABC8", VA = "0xB4ABC8")]
		public void ProceduralFingerBend(int layermask)
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xB4AC3C", Offset = "0xB4AC3C", VA = "0xB4AC3C")]
		public void ProceduralFingerBend(RaycastHit hit)
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xB4ACE4", Offset = "0xB4ACE4", VA = "0xB4ACE4")]
		public void PlayHapticVibration()
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xB4AD7C", Offset = "0xB4AD7C", VA = "0xB4AD7C")]
		public void PlayHapticVibration(float duration)
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xB4ACF4", Offset = "0xB4ACF4", VA = "0xB4ACF4")]
		public void PlayHapticVibration(float duration, float amp = 0.5f)
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xB4AD84", Offset = "0xB4AD84", VA = "0xB4AD84")]
		[ContextMenu("SAVE OPEN")]
		[Button("Save Open Pose", EButtonEnableMode.Always)]
		public void SaveOpenPose()
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0xB4AE38", Offset = "0xB4AE38", VA = "0xB4AE38")]
		[Button("Save Closed Pose", EButtonEnableMode.Always)]
		[ContextMenu("SAVE CLOSED")]
		public void SaveClosedPose()
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0xB4AEEC", Offset = "0xB4AEEC", VA = "0xB4AEEC", Slot = "35")]
		protected virtual void OnCollisionFirstEnter(GameObject collision)
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0xB4AF68", Offset = "0xB4AF68", VA = "0xB4AF68", Slot = "36")]
		protected virtual void OnCollisionLastExit(GameObject collision)
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0xB4AFE4", Offset = "0xB4AFE4", VA = "0xB4AFE4", Slot = "37")]
		protected virtual void OnTriggerFirstEnter(GameObject other)
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0xB4B0F4", Offset = "0xB4B0F4", VA = "0xB4B0F4", Slot = "38")]
		protected virtual void OnTriggerLastExit(GameObject other)
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0xB46924", Offset = "0xB46924", VA = "0xB46924")]
		[IteratorStateMachine(typeof(<HighlightUpdate>d__125))]
		private IEnumerator HighlightUpdate(float timestep)
		{
			return null;
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xB47D98", Offset = "0xB47D98", VA = "0xB47D98")]
		[IteratorStateMachine(typeof(<GrabObject>d__127))]
		protected IEnumerator GrabObject(RaycastHit hit, Grabbable grab, GrabType grabType)
		{
			return null;
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xB4B204", Offset = "0xB4B204", VA = "0xB4B204")]
		protected void CancelPose()
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xB4B250", Offset = "0xB4B250", VA = "0xB4B250", Slot = "39")]
		[IteratorStateMachine(typeof(<LerpHandPose>d__129))]
		protected virtual IEnumerator LerpHandPose(HandPoseData fromPose, HandPoseData toPose, float totalTime)
		{
			return null;
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xB4B358", Offset = "0xB4B358", VA = "0xB4B358", Slot = "40")]
		protected virtual void CheckEnterPoseArea(GameObject other)
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xB4B840", Offset = "0xB4B840", VA = "0xB4B840", Slot = "41")]
		protected virtual void CheckExitPoseArea(GameObject other)
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xB4B668", Offset = "0xB4B668", VA = "0xB4B668")]
		internal void TryRemoveHandPoseArea(HandPoseArea poseArea)
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0xB4B8DC", Offset = "0xB4B8DC", VA = "0xB4B8DC")]
		private void ClearPoseArea()
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0xB4B990", Offset = "0xB4B990", VA = "0xB4B990", Slot = "42")]
		internal virtual void RemoveHandTriggerArea(HandTriggerAreaEvents handTrigger)
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0xB4BA00", Offset = "0xB4BA00", VA = "0xB4BA00")]
		public Hand()
		{
		}
	}
	[Token(Token = "0x2000129")]
	[DefaultExecutionOrder(10000)]
	[RequireComponent(typeof(Hand))]
	public class HandAdvancedOptions : MonoBehaviour
	{
		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Meant for things childed under the Hand. These transforms will not be set to the hand layer on start")]
		public List<Collider> ignoreHandCollider;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Hand hand;

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xB4E2A0", Offset = "0xB4E2A0", VA = "0xB4E2A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xB4E2F8", Offset = "0xB4E2F8", VA = "0xB4E2F8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xB4E39C", Offset = "0xB4E39C", VA = "0xB4E39C")]
		public HandAdvancedOptions()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public class HandClippingGuard : MonoBehaviour
	{
		[Token(Token = "0x200012B")]
		[CompilerGenerated]
		private sealed class <Guard>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Hand hand;

			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HandClippingGuard <>4__this;

			[Token(Token = "0x1700008E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000830")]
				[Address(RVA = "0xB4E9DC", Offset = "0xB4E9DC", VA = "0xB4E9DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000832")]
				[Address(RVA = "0xB4EA24", Offset = "0xB4EA24", VA = "0xB4EA24", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600082D")]
			[Address(RVA = "0xB4E704", Offset = "0xB4E704", VA = "0xB4E704")]
			[DebuggerHidden]
			public <Guard>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600082E")]
			[Address(RVA = "0xB4E740", Offset = "0xB4E740", VA = "0xB4E740", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600082F")]
			[Address(RVA = "0xB4E744", Offset = "0xB4E744", VA = "0xB4E744", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000831")]
			[Address(RVA = "0xB4E9E4", Offset = "0xB4E9E4", VA = "0xB4E9E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Hand hand;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("This should be a sphere collider that covers the hand (similar, but seperate from the recommended trigger sphere collider)")]
		public SphereCollider collisionGuard;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform body;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float guardTime;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 grabPoint;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool runProtection;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Coroutine guardRoutine;

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xB4E424", Offset = "0xB4E424", VA = "0xB4E424")]
		private void Start()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xB4E510", Offset = "0xB4E510", VA = "0xB4E510")]
		private void BeforeGrab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xB4E634", Offset = "0xB4E634", VA = "0xB4E634")]
		private void OnRelease(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xB4E674", Offset = "0xB4E674", VA = "0xB4E674")]
		[IteratorStateMachine(typeof(<Guard>d__10))]
		private IEnumerator Guard(Hand hand)
		{
			return null;
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xB4E72C", Offset = "0xB4E72C", VA = "0xB4E72C")]
		public HandClippingGuard()
		{
		}
	}
	[Token(Token = "0x200012C")]
	[RequireComponent(typeof(Hand))]
	public class HandCollisionHaptics : MonoBehaviour
	{
		[Token(Token = "0x200012D")]
		[CompilerGenerated]
		private sealed class <PlayBuffer>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandCollisionHaptics <>4__this;

			[Token(Token = "0x17000090")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600083C")]
				[Address(RVA = "0xB4EFF0", Offset = "0xB4EFF0", VA = "0xB4EFF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000091")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600083E")]
				[Address(RVA = "0xB4F038", Offset = "0xB4F038", VA = "0xB4F038", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000839")]
			[Address(RVA = "0xB4EEF4", Offset = "0xB4EEF4", VA = "0xB4EEF4")]
			[DebuggerHidden]
			public <PlayBuffer>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x600083A")]
			[Address(RVA = "0xB4EF1C", Offset = "0xB4EF1C", VA = "0xB4EF1C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600083B")]
			[Address(RVA = "0xB4EF20", Offset = "0xB4EF20", VA = "0xB4EF20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600083D")]
			[Address(RVA = "0xB4EFF8", Offset = "0xB4EFF8", VA = "0xB4EFF8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200012E")]
		[CompilerGenerated]
		private sealed class <HapticPlayBuffer>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandCollisionHaptics <>4__this;

			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float time;

			[Token(Token = "0x17000092")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000842")]
				[Address(RVA = "0xB4F13C", Offset = "0xB4F13C", VA = "0xB4F13C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000093")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000844")]
				[Address(RVA = "0xB4F184", Offset = "0xB4F184", VA = "0xB4F184", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600083F")]
			[Address(RVA = "0xB4F040", Offset = "0xB4F040", VA = "0xB4F040")]
			[DebuggerHidden]
			public <HapticPlayBuffer>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000840")]
			[Address(RVA = "0xB4F068", Offset = "0xB4F068", VA = "0xB4F068", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000841")]
			[Address(RVA = "0xB4F06C", Offset = "0xB4F06C", VA = "0xB4F06C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000843")]
			[Address(RVA = "0xB4F144", Offset = "0xB4F144", VA = "0xB4F144", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The layers that cause the sound to play")]
		public LayerMask collisionTriggers;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float hapticAmp;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float velocityAmp;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float repeatDelay;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float maxDuration;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Source to play sound from")]
		public AnimationCurve velocityAmpCurve;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Source to play sound from")]
		public AnimationCurve velocityDurationCurve;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Hand hand;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Rigidbody body;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool canPlay;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine playRoutine;

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xB4EA2C", Offset = "0xB4EA2C", VA = "0xB4EA2C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0xB4EB5C", Offset = "0xB4EB5C", VA = "0xB4EB5C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0xB4EB70", Offset = "0xB4EB70", VA = "0xB4EB70")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xB4EDE8", Offset = "0xB4EDE8", VA = "0xB4EDE8")]
		[IteratorStateMachine(typeof(<PlayBuffer>d__14))]
		private IEnumerator PlayBuffer()
		{
			return null;
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xB4EAD8", Offset = "0xB4EAD8", VA = "0xB4EAD8")]
		[IteratorStateMachine(typeof(<HapticPlayBuffer>d__15))]
		private IEnumerator HapticPlayBuffer(float time)
		{
			return null;
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xB4EE5C", Offset = "0xB4EE5C", VA = "0xB4EE5C")]
		public HandCollisionHaptics()
		{
		}
	}
	[Token(Token = "0x200012F")]
	public class HandControllerLink : MonoBehaviour
	{
		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static HandControllerLink handLeft;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static HandControllerLink handRight;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Hand hand;

		[Token(Token = "0x6000845")]
		[Address(RVA = "0xB4F18C", Offset = "0xB4F18C", VA = "0xB4F18C", Slot = "4")]
		public virtual void TryHapticImpulse(float duration, float amp, float freq = 10f)
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xB4F190", Offset = "0xB4F190", VA = "0xB4F190")]
		public HandControllerLink()
		{
		}
	}
	[Token(Token = "0x2000130")]
	[DefaultExecutionOrder(2)]
	[HelpURL("https://earnestrobot.notion.site/Distance-Grabbing-19e4e8b14f00428295eca75fca752787")]
	public class HandDistanceGrabber : MonoBehaviour
	{
		[Token(Token = "0x2000131")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass62_0
		{
			[Token(Token = "0x40007D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public HandDistanceGrabber <>4__this;

			[Token(Token = "0x40007D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DistanceGrabbable grab;

			[Token(Token = "0x40007D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float estimatedRadius;

			[Token(Token = "0x6000864")]
			[Address(RVA = "0xB517D8", Offset = "0xB517D8", VA = "0xB517D8")]
			public <>c__DisplayClass62_0()
			{
			}

			[Token(Token = "0x6000865")]
			[Address(RVA = "0xB517E0", Offset = "0xB517E0", VA = "0xB517E0")]
			internal void <StartCatchAssist>b__0(Hand hand, Grabbable grabbable)
			{
			}

			[Token(Token = "0x6000866")]
			[Address(RVA = "0xB5187C", Offset = "0xB5187C", VA = "0xB5187C")]
			internal void <StartCatchAssist>b__1(Hand hand, Grabbable grabbable)
			{
			}

			[Token(Token = "0x6000868")]
			[Address(RVA = "0xB51E20", Offset = "0xB51E20", VA = "0xB51E20")]
			internal void <StartCatchAssist>b__5(Hand hand, Grabbable grabbable)
			{
			}

			[Token(Token = "0x6000869")]
			[Address(RVA = "0xB51EBC", Offset = "0xB51EBC", VA = "0xB51EBC")]
			internal void <StartCatchAssist>b__6(Hand hand, Grabbable grabbable)
			{
			}
		}

		[Token(Token = "0x2000132")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass62_1
		{
			[Token(Token = "0x40007D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool cancelInstantGrab;

			[Token(Token = "0x600086A")]
			[Address(RVA = "0xB51F58", Offset = "0xB51F58", VA = "0xB51F58")]
			public <>c__DisplayClass62_1()
			{
			}

			[Token(Token = "0x600086B")]
			[Address(RVA = "0xB51F60", Offset = "0xB51F60", VA = "0xB51F60")]
			internal void <StartCatchAssist>b__2(Hand hand, Grabbable grabbable)
			{
			}

			[Token(Token = "0x600086C")]
			[Address(RVA = "0xB51F6C", Offset = "0xB51F6C", VA = "0xB51F6C")]
			internal void <StartCatchAssist>b__4(Hand hand, Grabbable grabbable)
			{
			}
		}

		[Token(Token = "0x2000133")]
		[CompilerGenerated]
		private sealed class <StartCatchAssist>d__62 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandDistanceGrabber <>4__this;

			[Token(Token = "0x40007DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DistanceGrabbable grab;

			[Token(Token = "0x40007DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float estimatedRadius;

			[Token(Token = "0x40007DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private <>c__DisplayClass62_0 <>8__1;

			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private <>c__DisplayClass62_1 <>8__2;

			[Token(Token = "0x40007DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <time>5__2;

			[Token(Token = "0x17000095")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000870")]
				[Address(RVA = "0xB52628", Offset = "0xB52628", VA = "0xB52628", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000096")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000872")]
				[Address(RVA = "0xB52670", Offset = "0xB52670", VA = "0xB52670", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600086D")]
			[Address(RVA = "0xB514C0", Offset = "0xB514C0", VA = "0xB514C0")]
			[DebuggerHidden]
			public <StartCatchAssist>d__62(int <>1__state)
			{
			}

			[Token(Token = "0x600086E")]
			[Address(RVA = "0xB51F78", Offset = "0xB51F78", VA = "0xB51F78", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600086F")]
			[Address(RVA = "0xB51F7C", Offset = "0xB51F7C", VA = "0xB51F7C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000871")]
			[Address(RVA = "0xB52630", Offset = "0xB52630", VA = "0xB52630", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The primaryHand used to trigger pulling or flicking")]
		[Header("Hands")]
		public Hand primaryHand;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("This is important for catch assistance")]
		public Hand secondaryHand;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Pointing Options")]
		public Transform forwardPointer;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LineRenderer line;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Space]
		public float maxRange;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Defaults to grabbable on start if none")]
		public LayerMask layers;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Space]
		public Material defaultTargetedMaterial;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The highlight material to use when pulling")]
		public Material defaultSelectedMaterial;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Pull Options")]
		public bool useInstantPull;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		[Tooltip("If false will default to distance pull, set pullGrabDistance to 0 for instant pull on select")]
		public bool useFlickPull;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[ShowIf("useFlickPull")]
		[Tooltip("The magnitude of your hands angular velocity for \"flick\" to start")]
		public float flickThreshold;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("The amount you need to move your hand from the select position to trigger the grab")]
		[HideIf("useFlickPull")]
		public float pullGrabDistance;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Space]
		[Tooltip("If this is true the object will be grabbed when entering the radius")]
		public bool instantGrabAssist;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("The radius around of thrown object")]
		public float catchAssistRadius;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AutoToggleHeader("Show Events", 0, 0)]
		public bool showEvents;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[ShowIf("showEvents")]
		public UnityHandGrabEvent OnPull;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[ShowIf("showEvents")]
		public UnityHandEvent StartPoint;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[ShowIf("showEvents")]
		public UnityHandEvent StopPoint;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("Targeting is started when object is highlighted")]
		[ShowIf("showEvents")]
		public UnityHandGrabEvent StartTarget;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[ShowIf("showEvents")]
		public UnityHandGrabEvent StopTarget;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[ShowIf("showEvents")]
		[Tooltip("Selecting is started when grab is selected on highlight object")]
		public UnityHandGrabEvent StartSelect;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[ShowIf("showEvents")]
		public UnityHandGrabEvent StopSelect;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<CatchAssistData> catchAssisted;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private DistanceGrabbable targetingDistanceGrabbable;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private DistanceGrabbable selectingDistanceGrabbable;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float catchAssistSeconds;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private bool pointing;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		private bool pulling;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3 startPullPosition;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private RaycastHit hit;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion lastRotation;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private RaycastHit selectionHit;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private float selectedEstimatedRadius;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float startLookAssist;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private bool lastInstantPull;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private GameObject _hitPoint;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Coroutine catchAssistRoutine;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private DistanceGrabbable catchAsistGrabbable;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private CatchAssistData catchAssistData;

		[Token(Token = "0x17000094")]
		private GameObject hitPoint
		{
			[Token(Token = "0x6000847")]
			[Address(RVA = "0xB4F198", Offset = "0xB4F198", VA = "0xB4F198")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0xB4F294", Offset = "0xB4F294", VA = "0xB4F294")]
		private void Start()
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xB4F3F8", Offset = "0xB4F3F8", VA = "0xB4F3F8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xB4F65C", Offset = "0xB4F65C", VA = "0xB4F65C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xB4F908", Offset = "0xB4F908", VA = "0xB4F908")]
		private void Update()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0xB4FD18", Offset = "0xB4FD18", VA = "0xB4FD18")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xB4F3EC", Offset = "0xB4F3EC", VA = "0xB4F3EC")]
		public void SetInstantPull()
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xB4FD80", Offset = "0xB4FD80", VA = "0xB4FD80")]
		public void SetPull(float distance)
		{
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xB4FD8C", Offset = "0xB4FD8C", VA = "0xB4FD8C")]
		public void SetFlickPull(float threshold)
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0xB4F93C", Offset = "0xB4F93C", VA = "0xB4F93C")]
		private void CheckDistanceGrabbable()
		{
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0xB50134", Offset = "0xB50134", VA = "0xB50134", Slot = "4")]
		public virtual void StartPointing()
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xB50198", Offset = "0xB50198", VA = "0xB50198", Slot = "5")]
		public virtual void StopPointing()
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xB50288", Offset = "0xB50288", VA = "0xB50288", Slot = "6")]
		public virtual void StartTargeting(DistanceGrabbable target)
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xB504FC", Offset = "0xB504FC", VA = "0xB504FC", Slot = "7")]
		public virtual void StopTargeting()
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xB50634", Offset = "0xB50634", VA = "0xB50634", Slot = "8")]
		public virtual void SelectTarget()
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xB50A18", Offset = "0xB50A18", VA = "0xB50A18", Slot = "9")]
		public virtual void CancelSelect()
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xB50B28", Offset = "0xB50B28", VA = "0xB50B28", Slot = "10")]
		public virtual void ActivatePull()
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xB50044", Offset = "0xB50044", VA = "0xB50044")]
		private void TryDistancePull()
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0xB4FD9C", Offset = "0xB4FD9C", VA = "0xB4FD9C")]
		private void TryFlickPull()
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xB50988", Offset = "0xB50988", VA = "0xB50988")]
		private Material GetSelectedMaterial(DistanceGrabbable grabbable)
		{
			return null;
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0xB50468", Offset = "0xB50468", VA = "0xB50468")]
		private Material GetTargetedMaterial(DistanceGrabbable grabbable)
		{
			return null;
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0xB50F84", Offset = "0xB50F84", VA = "0xB50F84")]
		private void TryCatchAssist(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0xB50EE4", Offset = "0xB50EE4", VA = "0xB50EE4")]
		[IteratorStateMachine(typeof(<StartCatchAssist>d__62))]
		private IEnumerator StartCatchAssist(DistanceGrabbable grab, float estimatedRadius)
		{
			return null;
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xB514E8", Offset = "0xB514E8", VA = "0xB514E8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xB51634", Offset = "0xB51634", VA = "0xB51634")]
		public HandDistanceGrabber()
		{
		}
	}
	[Token(Token = "0x2000134")]
	internal struct CatchAssistData
	{
		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Grabbable grab;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float estimatedRadius;

		[Token(Token = "0x6000873")]
		[Address(RVA = "0xB52600", Offset = "0xB52600", VA = "0xB52600")]
		public CatchAssistData(Grabbable grab, float estimatedRadius)
		{
		}
	}
	[Token(Token = "0x2000135")]
	[HelpURL("https://www.notion.so/Pose-Areas-99b9af26d297442a91a9d73f65f13635")]
	public class HandPoseArea : MonoBehaviour
	{
		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string poseName;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int poseIndex;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float transitionTime;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Events")]
		public UnityHandEvent OnHandEnter;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityHandEvent OnHandExit;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		[Tooltip("Scriptable options NOT REQUIRED (will be saved locally instead if empty) -> Create scriptable throught [Auto Hand/Custom Pose]")]
		public HandPoseScriptable poseScriptable;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public HandPoseData rightPose;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public bool rightPoseSet;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public HandPoseData leftPose;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		public bool leftPoseSet;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		internal HandPoseArea[] poseAreas;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private List<Hand> posingHands;

		[Token(Token = "0x6000874")]
		[Address(RVA = "0xB52678", Offset = "0xB52678", VA = "0xB52678")]
		private void Start()
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0xB526D0", Offset = "0xB526D0", VA = "0xB526D0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0xB527C4", Offset = "0xB527C4", VA = "0xB527C4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0xB52924", Offset = "0xB52924", VA = "0xB52924")]
		private void HandEnter(Hand hand)
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0xB529D4", Offset = "0xB529D4", VA = "0xB529D4")]
		private void HandExit(Hand hand)
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0xB52A2C", Offset = "0xB52A2C", VA = "0xB52A2C", Slot = "4")]
		public virtual HandPoseData GetHandPoseData(bool left)
		{
			return default(HandPoseData);
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0xB52AEC", Offset = "0xB52AEC", VA = "0xB52AEC")]
		public void SetHandPose(Hand hand)
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0xB52E38", Offset = "0xB52E38", VA = "0xB52E38")]
		public bool HasPose(bool left)
		{
			return default(bool);
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0xB52EEC", Offset = "0xB52EEC", VA = "0xB52EEC")]
		public HandPoseArea()
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class HandProjector : MonoBehaviour
	{
		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("References")]
		public Hand hand;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("This should be a copy of the hand with the desired visual setup for your projection hand")]
		public Hand handProjection;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The Object(s) under your Hand that contain the MeshRenderer Component(s)")]
		public Transform[] handProjectionVisuals;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Smoothing speed, turning too high could cause jitters")]
		public float speed;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("If true everything in the hand Vvisuals will be disabled/hidden when projection hand is showing")]
		public bool hideHand;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[ShowIf("hideHand")]
		[Tooltip("The Object(s) under your main hand (not the projection hand) that contain the MeshRenderer Component(s)")]
		public Transform[] handVisuals;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Should the projection interpolate between the hand pose and the projected grab pose based on the grip input axis")]
		public bool useGrabTransition;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The Object(s) under your Hand that contain the MeshRenderer Component(s)")]
		[EnableIf("useGrabTransition")]
		public float grabTransitionOffset;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The Object(s) under your Hand that contain the MeshRenderer Component(s)")]
		[EnableIf("useGrabTransition")]
		public float grabDistanceMultiplyer;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[EnableIf("useGrabTransition")]
		[Tooltip("The Object(s) under your Hand that contain the MeshRenderer Component(s)")]
		public float grabTransitionMultiplyer;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The Object(s) under your Hand that contain the MeshRenderer Component(s)")]
		[DisableIf("useGrabTransition")]
		public float grabPercent;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("Events")]
		public UnityHandGrabEvent OnStartProjection;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public UnityHandGrabEvent OnEndProjection;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private HandPoseData lastProjectionPose;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private HandPoseData newProjectionPose;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastProjectionPosition;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion lastProjectionRotation;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Grabbable target;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private float startMass;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private float minGrabTime;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private float currAmount;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool tryingGrab;

		[Token(Token = "0x600087D")]
		[Address(RVA = "0xB53024", Offset = "0xB53024", VA = "0xB53024")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0xB53388", Offset = "0xB53388", VA = "0xB53388")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0xB54228", Offset = "0xB54228", VA = "0xB54228")]
		private void OnTriggerGrab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0xB54234", Offset = "0xB54234", VA = "0xB54234")]
		private void OnBeforeGrab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0xB543F0", Offset = "0xB543F0", VA = "0xB543F0")]
		private void OnGrab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0xB54414", Offset = "0xB54414", VA = "0xB54414")]
		private void OnRelease(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0xB5462C", Offset = "0xB5462C", VA = "0xB5462C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0xB54A38", Offset = "0xB54A38", VA = "0xB54A38")]
		private void OnProjectionStart(Hand projectionHand, Grabbable target)
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0xB54AAC", Offset = "0xB54AAC", VA = "0xB54AAC")]
		private void OnProjectionEnd(Hand projectionHand, Grabbable target)
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0xB534FC", Offset = "0xB534FC", VA = "0xB534FC")]
		private void ShowProjection(bool show)
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0xB5468C", Offset = "0xB5468C", VA = "0xB5468C")]
		private void SetTarget(Grabbable newTarget)
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0xB54978", Offset = "0xB54978", VA = "0xB54978")]
		private bool IsProjectionActive()
		{
			return default(bool);
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0xB54DA0", Offset = "0xB54DA0", VA = "0xB54DA0")]
		public HandProjector()
		{
		}
	}
	[Token(Token = "0x2000137")]
	public class HandPublicEvents : MonoBehaviour
	{
		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Hand hand;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityHandGrabEvent OnBeforeGrab;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityHandGrabEvent OnGrab;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityHandGrabEvent OnRelease;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UnityHandGrabEvent OnForceRelease;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityHandGrabEvent OnSqueeze;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UnityHandGrabEvent OnUnsqueeze;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityHandGrabEvent OnHighlight;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UnityHandGrabEvent OnStopHighlight;

		[Token(Token = "0x600088A")]
		[Address(RVA = "0xB54DC0", Offset = "0xB54DC0", VA = "0xB54DC0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0xB55000", Offset = "0xB55000", VA = "0xB55000")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0xB55240", Offset = "0xB55240", VA = "0xB55240")]
		public void OnBeforeGrabEvent(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0xB552B4", Offset = "0xB552B4", VA = "0xB552B4")]
		public void OnGrabEvent(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0xB55328", Offset = "0xB55328", VA = "0xB55328")]
		public void OnReleaseEvent(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0xB5539C", Offset = "0xB5539C", VA = "0xB5539C")]
		public void OnSqueezeEvent(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0xB55410", Offset = "0xB55410", VA = "0xB55410")]
		public void OnUnsqueezeEvent(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0xB55484", Offset = "0xB55484", VA = "0xB55484")]
		public void OnHighlightEvent(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0xB554F8", Offset = "0xB554F8", VA = "0xB554F8")]
		public void OnStopHighlightEvent(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0xB5556C", Offset = "0xB5556C", VA = "0xB5556C")]
		public void OnForceReleaseEvent(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0xB555E0", Offset = "0xB555E0", VA = "0xB555E0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0xB556C4", Offset = "0xB556C4", VA = "0xB556C4")]
		public HandPublicEvents()
		{
		}
	}
	[Token(Token = "0x2000138")]
	[DefaultExecutionOrder(1000)]
	public class HandTeleportGuard : MonoBehaviour
	{
		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Helps prevent hand from passing through static collision boundries")]
		public Hand hand;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Guard Settings")]
		[Tooltip("The mask of things the guarding will ignore, if left on default or empty, will default to ignoring recommended Auto Hand layers")]
		public LayerMask ignoreMask;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The amount of distance change required in one frame or fixed udpate to activate the teleport guard")]
		public float buffer;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Whether this should always run or only run when activated by the teleporter")]
		public bool alwaysRun;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[Tooltip("If true hands wont teleport return when past the max distance if something is in the way")]
		[FormerlySerializedAs("strict")]
		public bool ignoreMaxHandDistance;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 deltaHandPos;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 deltaHandFixedPos;

		[Token(Token = "0x6000896")]
		[Address(RVA = "0xB55878", Offset = "0xB55878", VA = "0xB55878")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0xB55C00", Offset = "0xB55C00", VA = "0xB55C00")]
		private void Update()
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0xB56120", Offset = "0xB56120", VA = "0xB56120")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0xB55DBC", Offset = "0xB55DBC", VA = "0xB55DBC")]
		public void TeleportProtection(Vector3 fromPos, Vector3 toPos)
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0xB562DC", Offset = "0xB562DC", VA = "0xB562DC")]
		public HandTeleportGuard()
		{
		}
	}
	[Token(Token = "0x2000139")]
	[HelpURL("https://www.notion.so/Touch-Events-1341b3e627dd443a99593ff7f0412aa6")]
	public class HandTouchEvent : MonoBehaviour
	{
		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Whether or not first hand to enter should take ownership and be the only one to call events")]
		[Header("For Solid Collision")]
		public bool oneHanded;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public HandType handType;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Events")]
		public UnityHandEvent HandStartTouch;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityHandEvent HandStopTouch;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HandEvent HandStartTouchEvent;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public HandEvent HandStopTouchEvent;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Hand> hands;

		[Token(Token = "0x600089B")]
		[Address(RVA = "0xB562F0", Offset = "0xB562F0", VA = "0xB562F0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0xB565A4", Offset = "0xB565A4", VA = "0xB565A4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0xB566F8", Offset = "0xB566F8", VA = "0xB566F8")]
		public void Touch(Hand hand)
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0xB56858", Offset = "0xB56858", VA = "0xB56858")]
		public void Untouch(Hand hand)
		{
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0xB569B8", Offset = "0xB569B8", VA = "0xB569B8")]
		public HandTouchEvent()
		{
		}
	}
	[Token(Token = "0x200013A")]
	public delegate void HandEvent(Hand hand);
	[Token(Token = "0x200013B")]
	public class HandTriggerAreaEvents : MonoBehaviour
	{
		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Trigger Events Settings")]
		[Tooltip("Whether or not first hand to enter should take ownership and be the only one to call events")]
		public bool oneHanded;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public HandType handType;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Whether or not to call the release event if exiting while grab event activated")]
		public bool exitTriggerRelease;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[Tooltip("Whether or not to call the release event if exiting while grab event activated")]
		public bool exitTriggerUnsqueeze;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Events")]
		public UnityHandEvent HandEnter;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityHandEvent HandExit;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UnityHandEvent HandGrab;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityHandEvent HandRelease;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UnityHandEvent HandSqueeze;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityHandEvent HandUnsqueeze;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public HandEvent HandEnterEvent;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public HandEvent HandExitEvent;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public HandEvent HandGrabEvent;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public HandEvent HandReleaseEvent;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public HandEvent HandSqueezeEvent;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public HandEvent HandUnsqueezeEvent;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<Hand> hands;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool grabbing;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		private bool squeezing;

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0xB56B88", Offset = "0xB56B88", VA = "0xB56B88", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0xB56F3C", Offset = "0xB56F3C", VA = "0xB56F3C", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0xB5730C", Offset = "0xB5730C", VA = "0xB5730C", Slot = "6")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0xB57488", Offset = "0xB57488", VA = "0xB57488", Slot = "7")]
		public virtual void Enter(Hand hand)
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0xB575E8", Offset = "0xB575E8", VA = "0xB575E8", Slot = "8")]
		public virtual void Exit(Hand hand)
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0xB5788C", Offset = "0xB5788C", VA = "0xB5788C", Slot = "9")]
		public virtual void Grab(Hand hand)
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0xB579A0", Offset = "0xB579A0", VA = "0xB579A0", Slot = "10")]
		public virtual void Release(Hand hand)
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0xB57AB0", Offset = "0xB57AB0", VA = "0xB57AB0", Slot = "11")]
		public virtual void Squeeze(Hand hand)
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0xB57BF4", Offset = "0xB57BF4", VA = "0xB57BF4", Slot = "12")]
		public virtual void Unsqueeze(Hand hand)
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0xB57D30", Offset = "0xB57D30", VA = "0xB57D30")]
		public HandTriggerAreaEvents()
		{
		}
	}
	[Token(Token = "0x200013C")]
	public class EditorHand : MonoBehaviour
	{
		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool useEditorGUI;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GrabbablePose grabbablePose;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HandPoseArea grabbablePoseArea;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Hand _hand;

		[Token(Token = "0x17000097")]
		public Hand hand
		{
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0xB581C8", Offset = "0xB581C8", VA = "0xB581C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0xB58270", Offset = "0xB58270", VA = "0xB58270")]
		public EditorHand()
		{
		}
	}
	[Token(Token = "0x200013D")]
	[DefaultExecutionOrder(-2)]
	public class GrabbableBase : MonoBehaviour
	{
		[Token(Token = "0x200013F")]
		[CompilerGenerated]
		private sealed class <IgnoreHandCollision>d__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400084D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400084E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400084F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GrabbableBase <>4__this;

			[Token(Token = "0x4000850")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Hand hand;

			[Token(Token = "0x4000851")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float time;

			[Token(Token = "0x1700009A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008DB")]
				[Address(RVA = "0xB594A8", Offset = "0xB594A8", VA = "0xB594A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008DD")]
				[Address(RVA = "0xB594F0", Offset = "0xB594F0", VA = "0xB594F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008D8")]
			[Address(RVA = "0xB58F40", Offset = "0xB58F40", VA = "0xB58F40")]
			[DebuggerHidden]
			public <IgnoreHandCollision>d__40(int <>1__state)
			{
			}

			[Token(Token = "0x60008D9")]
			[Address(RVA = "0xB593B0", Offset = "0xB593B0", VA = "0xB593B0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008DA")]
			[Address(RVA = "0xB593B4", Offset = "0xB593B4", VA = "0xB593B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008DC")]
			[Address(RVA = "0xB594B0", Offset = "0xB594B0", VA = "0xB594B0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AutoHeader("Grabbable", 0, 0)]
		public bool ignoreMe;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The physics body to connect this colliders grab to - if left empty will default to local body")]
		public Rigidbody body;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("A copy of the mesh will be created and slighly scaled and this material will be applied to create a highlight effect with options")]
		public Material hightlightMaterial;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public bool isGrabbable;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PlacePoint _placePoint;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal bool ignoreParent;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected List<Hand> heldBy;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected bool hightlighting;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected GameObject highlightObj;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected PlacePoint lastPlacePoint;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected Transform originalParent;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected Vector3 lastCenterOfMassPos;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		protected Quaternion lastCenterOfMassRot;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		protected CollisionDetectionMode detectionMode;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected RigidbodyInterpolation startInterpolation;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		protected internal bool beingGrabbed;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
		protected bool heldBodyJointed;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x96")]
		protected bool wasIsGrabbable;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x97")]
		protected bool beingDestroyed;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected int originalLayer;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		protected Coroutine resetLayerRoutine;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		protected List<GrabbableChild> grabChildren;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected List<Transform> jointedParents;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected GrabbablePoseCombiner poseCombiner;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private CollisionTracker _collisionTracker;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected List<Collider> grabColliders;

		[Token(Token = "0x17000098")]
		public PlacePoint placePoint
		{
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0xB58280", Offset = "0xB58280", VA = "0xB58280")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C1")]
			[Address(RVA = "0xB58288", Offset = "0xB58288", VA = "0xB58288")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public CollisionTracker collisionTracker
		{
			[Token(Token = "0x60008C2")]
			[Address(RVA = "0xB58290", Offset = "0xB58290", VA = "0xB58290")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C3")]
			[Address(RVA = "0xB5835C", Offset = "0xB5835C", VA = "0xB5835C")]
			protected set
			{
			}
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0xB583FC", Offset = "0xB583FC", VA = "0xB583FC", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0xB588B8", Offset = "0xB588B8", VA = "0xB588B8", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0xB58AD8", Offset = "0xB58AD8", VA = "0xB58AD8", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0xB58B70", Offset = "0xB58B70", VA = "0xB58B70", Slot = "7")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0xB58BB4", Offset = "0xB58BB4", VA = "0xB58BB4")]
		internal void SetPlacePoint(PlacePoint point)
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0xB58BBC", Offset = "0xB58BBC", VA = "0xB58BBC")]
		internal void SetGrabbableChild(GrabbableChild child)
		{
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0xB58CA4", Offset = "0xB58CA4", VA = "0xB58CA4")]
		protected int GetOriginalLayer()
		{
			return default(int);
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0xB58CAC", Offset = "0xB58CAC", VA = "0xB58CAC")]
		internal void SetLayerRecursive(Transform obj, int oldLayer, int newLayer)
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0xB58E50", Offset = "0xB58E50", VA = "0xB58E50")]
		internal void SetLayerRecursive(Transform obj, int newLayer)
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0xB58EA0", Offset = "0xB58EA0", VA = "0xB58EA0")]
		[IteratorStateMachine(typeof(<IgnoreHandCollision>d__40))]
		protected IEnumerator IgnoreHandCollision(float time, Hand hand)
		{
			return null;
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0xB58F68", Offset = "0xB58F68", VA = "0xB58F68")]
		public bool GetSavedPose(out GrabbablePoseCombiner pose)
		{
			return default(bool);
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0xB58FCC", Offset = "0xB58FCC", VA = "0xB58FCC")]
		public bool HasCustomPose()
		{
			return default(bool);
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0xB58FF4", Offset = "0xB58FF4", VA = "0xB58FF4")]
		public void IgnoreHand(Hand hand, bool ignore)
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0xB58750", Offset = "0xB58750", VA = "0xB58750")]
		private void SetCollidersRecursive(Transform obj)
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0xB591EC", Offset = "0xB591EC", VA = "0xB591EC")]
		protected void ResetRigidbody()
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0xB59224", Offset = "0xB59224", VA = "0xB59224")]
		public bool BeingDestroyed()
		{
			return default(bool);
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0xB5922C", Offset = "0xB5922C", VA = "0xB5922C")]
		public void DebugBreak()
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0xB59230", Offset = "0xB59230", VA = "0xB59230")]
		public GrabbableBase()
		{
		}
	}
	[Token(Token = "0x2000140")]
	public enum HandMovementType
	{
		[Token(Token = "0x4000853")]
		Legacy,
		[Token(Token = "0x4000854")]
		Forces
	}
	[Token(Token = "0x2000141")]
	public enum HandType
	{
		[Token(Token = "0x4000856")]
		both,
		[Token(Token = "0x4000857")]
		right,
		[Token(Token = "0x4000858")]
		left,
		[Token(Token = "0x4000859")]
		none
	}
	[Token(Token = "0x2000142")]
	public enum GrabType
	{
		[Token(Token = "0x400085B")]
		HandToGrabbable,
		[Token(Token = "0x400085C")]
		GrabbableToHand,
		[Token(Token = "0x400085D")]
		InstantGrab
	}
	[Serializable]
	[Token(Token = "0x2000143")]
	public struct VelocityTimePair
	{
		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float time;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Vector3 velocity;
	}
	[Token(Token = "0x2000144")]
	public delegate void HandGrabEvent(Hand hand, Grabbable grabbable);
	[Token(Token = "0x2000145")]
	public delegate void HandGameObjectEvent(Hand hand, GameObject other);
	[Serializable]
	[Token(Token = "0x2000146")]
	public class UnityHandGrabEvent : UnityEvent<Hand, Grabbable>
	{
		[Token(Token = "0x60008E6")]
		[Address(RVA = "0xB55830", Offset = "0xB55830", VA = "0xB55830")]
		public UnityHandGrabEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000147")]
	public class UnityHandEvent : UnityEvent<Hand>
	{
		[Token(Token = "0x60008E7")]
		[Address(RVA = "0xB52FDC", Offset = "0xB52FDC", VA = "0xB52FDC")]
		public UnityHandEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000148")]
	[DefaultExecutionOrder(-10)]
	[RequireComponent(typeof(Rigidbody))]
	public class HandBase : MonoBehaviour
	{
		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AutoHeader("AUTO HAND", 0, 0)]
		public bool ignoreMe;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Finger[] fingers;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("An empty GameObject that should be placed on the surface of the center of the palm")]
		public Transform palmTransform;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Whether this is the left (on) or right (off) hand")]
		[FormerlySerializedAs("isLeft")]
		public bool left;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Space]
		[Min(0.01f)]
		[Tooltip("Maximum distance for pickup")]
		public float reachDistance;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AutoToggleHeader("Enable Movement", 0, 0, tooltip = "Whether or not to enable the hand's Rigidbody Physics movement")]
		public bool enableMovement;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[EnableIf("enableMovement")]
		[Tooltip("Follow target, the hand will always try to match this transforms position with rigidbody movements")]
		public Transform follow;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Min(0f)]
		[Tooltip("Returns hand to the target after this distance [helps just in case it gets stuck]")]
		[EnableIf("enableMovement")]
		public float maxFollowDistance;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Min(0f)]
		[EnableIf("enableMovement")]
		[Tooltip("Amplifier for applied velocity on released object")]
		public float throwPower;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public bool advancedFollowSettings;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		[AutoToggleHeader("Enable Auto Posing", 0, 0, tooltip = "Auto Posing will override Unity Animations -- This will disable all the Auto Hand IK, including animations from: finger sway, pose areas, finger bender scripts (runtime Auto Posing will still work)")]
		[Tooltip("Turn this on when you want to animate the hand or use other IK Drivers")]
		public bool enableIK;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[EnableIf("enableIK")]
		[Tooltip("How much the fingers sway from the velocity")]
		public float swayStrength;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[EnableIf("enableIK")]
		[Tooltip("This will offset each fingers bend (0 is no bend, 1 is full bend)")]
		public float gripOffset;

		[NonSerialized]
		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Min(0f)]
		[Tooltip("The maximum allowed velocity of the hand")]
		public float maxVelocity;

		[NonSerialized]
		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Min(0f)]
		[Tooltip("Follow target speed (Can cause jittering if turned too high - recommend increasing drag with speed)")]
		public float followPositionStrength;

		[NonSerialized]
		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Min(0f)]
		[Tooltip("Follow target rotation speed (Can cause jittering if turned too high - recommend increasing angular drag with speed)")]
		[HideInInspector]
		public float followRotationStrength;

		[NonSerialized]
		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("After this many seconds velocity data within a 'throw window' will be tossed out. (This allows you to get only use acceeleration data from the last 'x' seconds of the throw.)")]
		[HideInInspector]
		public float throwVelocityExpireTime;

		[NonSerialized]
		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[HideInInspector]
		[Tooltip("Increase for closer finger tip results / Decrease for less physics checks - The number of steps the fingers take when bending to grab something")]
		public int fingerBendSteps;

		[NonSerialized]
		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public float sphereCastRadius;

		[NonSerialized]
		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[HideInInspector]
		public float maxCollisionDistance;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public bool usingPoseAreas;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[HideInInspector]
		public QueryTriggerInteraction queryTriggerInteraction;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Grabbable HoldingObj;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Grabbable _lookingAtObj;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Transform _moveTo;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 _grabPositionOffset;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Quaternion _grabRotationOffset;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private CollisionTracker _collisionTracker;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected GrabbablePose _grabPose;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		protected Joint heldJoint;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected bool grabbing;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		protected bool squeezing;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDA")]
		protected bool grabbed;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		protected float triggerPoint;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		protected Coroutine handAnimateRoutine;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		protected HandPoseArea handPoseArea;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected HandPoseData preHandPoseAreaPose;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		protected List<Collider> handColliders;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Transform _grabPoint;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Transform _grabPosition;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		internal int handLayers;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		protected Collider palmCollider;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		protected RaycastHit highlightHit;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		protected HandVelocityTracker velocityTracker;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		protected Transform palmChild;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		protected Vector3 lastFrameFollowPos;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		protected Quaternion lastFrameFollowRot;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		protected Vector3 followVel;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		protected Vector3 followAngularVel;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		internal bool allowUpdateMovement;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Vector3[] handRays;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private RaycastHit[] rayHits;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private List<RaycastHit> closestHits;

		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private List<Grabbable> closestGrabs;

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private int tryMaxDistanceCount;

		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
		private Vector3 lastFollowPosition;

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Vector3 lastFollowRotation;

		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private bool prerendered;

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private Vector3 preRenderPos;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
		private Quaternion preRenderRot;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		private float currGrip;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		protected Vector3 lastFixedPosition;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x234")]
		private float lastUpdateTime;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		protected bool ignoreMoveFrame;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
		private float fingerSwayVel;

		[Token(Token = "0x1700009C")]
		public Grabbable holdingObj
		{
			[Token(Token = "0x60008E8")]
			[Address(RVA = "0xB5969C", Offset = "0xB5969C", VA = "0xB5969C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008E9")]
			[Address(RVA = "0xB596A4", Offset = "0xB596A4", VA = "0xB596A4")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public Grabbable lookingAtObj
		{
			[Token(Token = "0x60008EA")]
			[Address(RVA = "0xB596AC", Offset = "0xB596AC", VA = "0xB596AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008EB")]
			[Address(RVA = "0xB596B4", Offset = "0xB596B4", VA = "0xB596B4")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public Transform moveTo
		{
			[Token(Token = "0x60008EC")]
			[Address(RVA = "0xB596BC", Offset = "0xB596BC", VA = "0xB596BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009F")]
		public Rigidbody body
		{
			[Token(Token = "0x60008ED")]
			[Address(RVA = "0xB597F4", Offset = "0xB597F4", VA = "0xB597F4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008EE")]
			[Address(RVA = "0xB597FC", Offset = "0xB597FC", VA = "0xB597FC")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public Vector3 grabPositionOffset
		{
			[Token(Token = "0x60008EF")]
			[Address(RVA = "0xB59804", Offset = "0xB59804", VA = "0xB59804")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60008F0")]
			[Address(RVA = "0xB59810", Offset = "0xB59810", VA = "0xB59810")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public Quaternion grabRotationOffset
		{
			[Token(Token = "0x60008F1")]
			[Address(RVA = "0xB5981C", Offset = "0xB5981C", VA = "0xB5981C")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60008F2")]
			[Address(RVA = "0xB59828", Offset = "0xB59828", VA = "0xB59828")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public bool disableIK
		{
			[Token(Token = "0x60008F3")]
			[Address(RVA = "0xB59834", Offset = "0xB59834", VA = "0xB59834")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008F4")]
			[Address(RVA = "0xB53378", Offset = "0xB53378", VA = "0xB53378")]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public CollisionTracker collisionTracker
		{
			[Token(Token = "0x60008F5")]
			[Address(RVA = "0xB59844", Offset = "0xB59844", VA = "0xB59844")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008F6")]
			[Address(RVA = "0xB598FC", Offset = "0xB598FC", VA = "0xB598FC")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		protected GrabbablePose grabPose
		{
			[Token(Token = "0x60008F7")]
			[Address(RVA = "0xB5999C", Offset = "0xB5999C", VA = "0xB5999C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008F8")]
			[Address(RVA = "0xB599A4", Offset = "0xB599A4", VA = "0xB599A4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		internal Transform grabPoint
		{
			[Token(Token = "0x60008F9")]
			[Address(RVA = "0xB59AA8", Offset = "0xB59AA8", VA = "0xB59AA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A6")]
		internal Transform grabPosition
		{
			[Token(Token = "0x60008FA")]
			[Address(RVA = "0xB59BC4", Offset = "0xB59BC4", VA = "0xB59BC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0xB59CFC", Offset = "0xB59CFC", VA = "0xB59CFC", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0xB5A1A8", Offset = "0xB5A1A8", VA = "0xB5A1A8", Slot = "5")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0xB5A23C", Offset = "0xB5A23C", VA = "0xB5A23C", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0xB5A2AC", Offset = "0xB5A2AC", VA = "0xB5A2AC", Slot = "7")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0xB5A43C", Offset = "0xB5A43C", VA = "0xB5A43C", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0xB5AA30", Offset = "0xB5AA30", VA = "0xB5AA30", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0xB5B3F8", Offset = "0xB5B3F8", VA = "0xB5B3F8", Slot = "10")]
		public virtual void OnPreRender()
		{
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0xB5BE18", Offset = "0xB5BE18", VA = "0xB5BE18", Slot = "11")]
		public virtual void OnPostRender()
		{
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0xB5BF14", Offset = "0xB5BF14", VA = "0xB5BF14", Slot = "12")]
		protected virtual void CreateJoint(Grabbable grab, float breakForce, float breakTorque)
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0xB5C1F4", Offset = "0xB5C1F4", VA = "0xB5C1F4", Slot = "13")]
		protected virtual void MoveTo()
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0xB5CCB0", Offset = "0xB5CCB0", VA = "0xB5CCB0", Slot = "14")]
		protected virtual void TorqueTo()
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0xB5CF68", Offset = "0xB5CF68", VA = "0xB5CF68", Slot = "15")]
		public virtual void SetHandLocation(Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0xB5D770", Offset = "0xB5D770", VA = "0xB5D770", Slot = "16")]
		public virtual void SetHandLocation(Vector3 pos)
		{
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0xB5D800", Offset = "0xB5D800", VA = "0xB5D800")]
		public void ResetHandLocation()
		{
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0xB5C7D8", Offset = "0xB5C7D8", VA = "0xB5C7D8")]
		protected void SetMoveTo()
		{
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0xB503E8", Offset = "0xB503E8", VA = "0xB503E8")]
		public bool CanGrab(Grabbable grab)
		{
			return default(bool);
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0xB5D890", Offset = "0xB5D890", VA = "0xB5D890")]
		public float GetTriggerAxis()
		{
			return default(float);
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0xB5D898", Offset = "0xB5D898", VA = "0xB5D898", Slot = "17")]
		protected virtual Vector3 HandClosestHit(out RaycastHit closestHit, out Grabbable grabbable, float dist, int layerMask, [Optional] Grabbable target)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0xB5E264", Offset = "0xB5E264", VA = "0xB5E264")]
		public bool IsPosing()
		{
			return default(bool);
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0xB5E31C", Offset = "0xB5E31C", VA = "0xB5E31C", Slot = "18")]
		protected virtual void UpdateFingers()
		{
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0xB5B340", Offset = "0xB5B340", VA = "0xB5B340")]
		public int CollisionCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0xB59148", Offset = "0xB59148", VA = "0xB59148")]
		public void HandIgnoreCollider(Collider collider, bool ignore)
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0xB5E414", Offset = "0xB5E414", VA = "0xB5E414")]
		public void SetLayer()
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0xB5E4B4", Offset = "0xB5E4B4", VA = "0xB5E4B4")]
		internal void SetLayerRecursive(Transform obj, int newLayer)
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0xB5A1C8", Offset = "0xB5A1C8", VA = "0xB5A1C8")]
		protected void SetHandCollidersRecursive(Transform obj)
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0xB5E6B8", Offset = "0xB5E6B8", VA = "0xB5E6B8")]
		public Vector3[] GetPalmRays()
		{
			return null;
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0xB5E6DC", Offset = "0xB5E6DC", VA = "0xB5E6DC", Slot = "19")]
		protected virtual void SetPalmRays()
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0xB5E968", Offset = "0xB5E968", VA = "0xB5E968")]
		public Vector3 ThrowVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0xB5ED94", Offset = "0xB5ED94", VA = "0xB5ED94")]
		public Vector3 ThrowAngularVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0xB5F04C", Offset = "0xB5F04C", VA = "0xB5F04C")]
		public bool IsGrabbing()
		{
			return default(bool);
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0xB5F054", Offset = "0xB5F054", VA = "0xB5F054")]
		public static int GetHandsLayerMask()
		{
			return default(int);
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0xB5F164", Offset = "0xB5F164", VA = "0xB5F164")]
		public HandBase()
		{
		}
	}
	[Token(Token = "0x2000149")]
	[RequireComponent(typeof(Hand))]
	public class HandGizmos : MonoBehaviour
	{
		[Token(Token = "0x600091C")]
		[Address(RVA = "0xB5F3D8", Offset = "0xB5F3D8", VA = "0xB5F3D8")]
		public HandGizmos()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200014A")]
	public struct HandPoseData
	{
		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 handOffset;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 rotationOffset;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Quaternion localQuaternionOffset;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3[] posePositions;

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Quaternion[] poseRotations;

		[Token(Token = "0x600091D")]
		[Address(RVA = "0xB5F3E0", Offset = "0xB5F3E0", VA = "0xB5F3E0")]
		public HandPoseData(Hand hand, Grabbable grabbable)
		{
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0xB5F990", Offset = "0xB5F990", VA = "0xB5F990")]
		public HandPoseData(Hand hand, Transform point)
		{
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0xB5FAC0", Offset = "0xB5FAC0", VA = "0xB5FAC0")]
		public HandPoseData(Hand hand)
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0xB5FBE4", Offset = "0xB5FBE4", VA = "0xB5FBE4")]
		public HandPoseData(HandPoseData data)
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0xB5F524", Offset = "0xB5F524", VA = "0xB5F524")]
		public void SavePose(Hand hand, Transform relativeTo)
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0xB5FDEC", Offset = "0xB5FDEC", VA = "0xB5FDEC")]
		public Quaternion GetRotationOffset()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0xB52B70", Offset = "0xB52B70", VA = "0xB52B70")]
		public void SetPose(Hand hand, [Optional] Transform relativeTo)
		{
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0xB5434C", Offset = "0xB5434C", VA = "0xB5434C")]
		public void SetFingerPose(Hand hand, [Optional] Transform relativeTo)
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0xB600D0", Offset = "0xB600D0", VA = "0xB600D0")]
		public void SetPosition(Hand hand, [Optional] Transform relativeTo)
		{
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0xB54B20", Offset = "0xB54B20", VA = "0xB54B20")]
		public static HandPoseData LerpPose(HandPoseData from, HandPoseData to, float point)
		{
			return default(HandPoseData);
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0xB6031C", Offset = "0xB6031C", VA = "0xB6031C")]
		public static void LerpPose(ref HandPoseData lerpPose, HandPoseData from, HandPoseData to, float point)
		{
		}
	}
	[Token(Token = "0x200014E")]
	[CreateAssetMenu(fileName = "AutoHand Pose", menuName = "Auto Hand/Custom Pose", order = 1)]
	public class HandPoseScriptable : ScriptableObject
	{
		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public bool rightSaved;

		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[HideInInspector]
		public bool leftSaved;

		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HandPoseData rightPose;

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public HandPoseData leftPose;

		[Token(Token = "0x600092C")]
		[Address(RVA = "0xB606FC", Offset = "0xB606FC", VA = "0xB606FC")]
		public void SavePoses(HandPoseData right, HandPoseData left)
		{
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0xB60770", Offset = "0xB60770", VA = "0xB60770")]
		public void SaveRightPose(HandPoseData right)
		{
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0xB607AC", Offset = "0xB607AC", VA = "0xB607AC")]
		public void SaveLeftPose(HandPoseData left)
		{
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0xB607EC", Offset = "0xB607EC", VA = "0xB607EC")]
		public HandPoseScriptable()
		{
		}
	}
	[Token(Token = "0x200014F")]
	[DefaultExecutionOrder(-5)]
	public class HandStabilizer : MonoBehaviour
	{
		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HandBase hand;

		[Token(Token = "0x6000930")]
		[Address(RVA = "0xB607F4", Offset = "0xB607F4", VA = "0xB607F4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0xB608A8", Offset = "0xB608A8", VA = "0xB608A8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0xB609EC", Offset = "0xB609EC", VA = "0xB609EC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0xB60B30", Offset = "0xB60B30", VA = "0xB60B30")]
		private void Update()
		{
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0xB60BB0", Offset = "0xB60BB0", VA = "0xB60BB0")]
		private void OnPreRender()
		{
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0xB60BFC", Offset = "0xB60BFC", VA = "0xB60BFC")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0xB60C48", Offset = "0xB60C48", VA = "0xB60C48")]
		private void OnPreRender(ScriptableRenderContext src, Camera cam)
		{
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0xB60C94", Offset = "0xB60C94", VA = "0xB60C94")]
		private void OnPostRender(ScriptableRenderContext src, Camera cam)
		{
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0xB60CE0", Offset = "0xB60CE0", VA = "0xB60CE0")]
		public HandStabilizer()
		{
		}
	}
	[Token(Token = "0x2000150")]
	public class HandVelocityTracker
	{
		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandBase hand;

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float minThrowVelocity;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected List<VelocityTimePair> m_ThrowVelocityList;

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected List<VelocityTimePair> m_ThrowFrameVelocityList;

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected List<VelocityTimePair> m_ThrowAngleVelocityList;

		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float disableTime;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float disableSeconds;

		[Token(Token = "0x6000939")]
		[Address(RVA = "0xB5D6F8", Offset = "0xB5D6F8", VA = "0xB5D6F8")]
		public void ClearThrow()
		{
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0xB60CE8", Offset = "0xB60CE8", VA = "0xB60CE8")]
		public void Disable(float seconds)
		{
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0xB5A0B4", Offset = "0xB5A0B4", VA = "0xB5A0B4")]
		public HandVelocityTracker(HandBase hand)
		{
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0xB5A6E0", Offset = "0xB5A6E0", VA = "0xB5A6E0")]
		public void UpdateThrowing()
		{
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0xB5E980", Offset = "0xB5E980", VA = "0xB5E980")]
		public Vector3 ThrowVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0xB5EDAC", Offset = "0xB5EDAC", VA = "0xB5EDAC")]
		public Vector3 ThrowAngularVelocity()
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000151")]
	public class KeyboardHand : MonoBehaviour
	{
		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Hand hand;

		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float speed;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float flySpeed;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool useLocal;

		[Token(Token = "0x600093F")]
		[Address(RVA = "0xB60D14", Offset = "0xB60D14", VA = "0xB60D14")]
		private void Update()
		{
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0xB61014", Offset = "0xB61014", VA = "0xB61014")]
		public KeyboardHand()
		{
		}
	}
	[Token(Token = "0x2000152")]
	[RequireComponent(typeof(CapsuleCollider))]
	[RequireComponent(typeof(Rigidbody))]
	[HelpURL("https://earnestrobot.notion.site/Auto-Move-Player-02d91305a4294e039049bd45cacc5b90")]
	[DefaultExecutionOrder(-3)]
	public class AutoHandPlayer : MonoBehaviour
	{
		[Token(Token = "0x2000153")]
		[CompilerGenerated]
		private sealed class <CheckForTrackingStart>d__83 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400090A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400090B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400090C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AutoHandPlayer <>4__this;

			[Token(Token = "0x170000A9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000977")]
				[Address(RVA = "0xB68624", Offset = "0xB68624", VA = "0xB68624", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000979")]
				[Address(RVA = "0xB6866C", Offset = "0xB6866C", VA = "0xB6866C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000974")]
			[Address(RVA = "0xB683E4", Offset = "0xB683E4", VA = "0xB683E4")]
			[DebuggerHidden]
			public <CheckForTrackingStart>d__83(int <>1__state)
			{
			}

			[Token(Token = "0x6000975")]
			[Address(RVA = "0xB6840C", Offset = "0xB6840C", VA = "0xB6840C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000976")]
			[Address(RVA = "0xB68410", Offset = "0xB68410", VA = "0xB68410", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000978")]
			[Address(RVA = "0xB6862C", Offset = "0xB6862C", VA = "0xB6862C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000154")]
		[CompilerGenerated]
		private sealed class <DisableGroundingSecondsRoutine>d__111 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400090D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400090E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400090F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AutoHandPlayer <>4__this;

			[Token(Token = "0x4000910")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float seconds;

			[Token(Token = "0x170000AB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600097D")]
				[Address(RVA = "0xB6876C", Offset = "0xB6876C", VA = "0xB6876C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600097F")]
				[Address(RVA = "0xB687B4", Offset = "0xB687B4", VA = "0xB687B4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600097A")]
			[Address(RVA = "0xB68674", Offset = "0xB68674", VA = "0xB68674")]
			[DebuggerHidden]
			public <DisableGroundingSecondsRoutine>d__111(int <>1__state)
			{
			}

			[Token(Token = "0x600097B")]
			[Address(RVA = "0xB6869C", Offset = "0xB6869C", VA = "0xB6869C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600097C")]
			[Address(RVA = "0xB686A0", Offset = "0xB686A0", VA = "0xB686A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600097E")]
			[Address(RVA = "0xB68774", Offset = "0xB68774", VA = "0xB68774", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool notFound;

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static AutoHandPlayer _Instance;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AutoHeader("Auto Hand Player", 0, 0)]
		public bool ignoreMe;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The tracked headCamera object")]
		public Camera headCamera;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The object that represents the forward direction movement, usually should be set as the camera or a tracked controller")]
		public Transform forwardFollow;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("This should NOT be a child of this body. This should be a GameObject that contains all the tracked objects (head/controllers)")]
		public Transform trackingContainer;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Hand handRight;

		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Hand handLeft;

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AutoToggleHeader("Movement", 0, 0)]
		public bool useMovement;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[EnableIf("useMovement")]
		[FormerlySerializedAs("moveSpeed")]
		[Tooltip("Movement speed when isGrounded")]
		public float maxMoveSpeed;

		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[EnableIf("useMovement")]
		[Tooltip("Movement acceleration when isGrounded")]
		public float moveAcceleration;

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[EnableIf("useMovement")]
		[Tooltip("Movement acceleration when isGrounded")]
		public float groundedDrag;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[EnableIf("useMovement")]
		public float heightSmoothSpeed;

		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Min(0f)]
		[AutoToggleHeader("Snap Turning", 0, 0)]
		[Tooltip("Whether or not to use snap turning or smooth turning")]
		public bool snapTurning;

		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("turn speed when not using snap turning - if snap turning, represents angle per snap")]
		[ShowIf("snapTurning")]
		public float snapTurnAngle;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[HideIf("snapTurning")]
		public float smoothTurnSpeed;

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AutoToggleHeader("Height", 0, 0)]
		public bool ignoreMe2;

		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[ShowIf("ignoreMe2")]
		public float heightOffset;

		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[ShowIf("ignoreMe2")]
		public bool crouching;

		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[ShowIf("ignoreMe2")]
		public float crouchHeight;

		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("Whether or not the capsule height should be adjusted to match the headCamera height")]
		[ShowIf("ignoreMe2")]
		public bool autoAdjustColliderHeight;

		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Tooltip("Minimum and maximum auto adjusted height, to adjust height without auto adjustment change capsule collider height instead")]
		[ShowIf("ignoreMe2")]
		public Vector2 minMaxHeight;

		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[ShowIf("ignoreMe2")]
		public bool useHeadCollision;

		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[ShowIf("ignoreMe2")]
		public float headRadius;

		[Token(Token = "0x40008D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AutoToggleHeader("Use Grounding", 0, 0)]
		public bool useGrounding;

		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[EnableIf("useGrounding")]
		[Tooltip("Maximum height that the body can step up onto")]
		[Min(0f)]
		public float maxStepHeight;

		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[EnableIf("useGrounding")]
		[Tooltip("Maximum angle the player can walk on")]
		[Min(0f)]
		public float maxStepAngle;

		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[EnableIf("useGrounding")]
		[Tooltip("The layers that count as ground")]
		public LayerMask groundLayerMask;

		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[Tooltip("Whether or not the player can use Climbable objects  (Objects with the Climbable component)")]
		[AutoToggleHeader("Enable Climbing", 0, 0)]
		public bool allowClimbing;

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
		[ShowIf("allowClimbing")]
		[Tooltip("Whether or not the player move while climbing")]
		public bool allowClimbingMovement;

		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[ShowIf("allowClimbing")]
		[Tooltip("How quickly the player can climb")]
		public Vector3 climbingStrength;

		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float climbingAcceleration;

		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float climbingDrag;

		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AutoToggleHeader("Enable Pushing", 0, 0)]
		[Tooltip("Whether or not the player can use Pushable objects (Objects with the Pushable component)")]
		public bool allowBodyPushing;

		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[EnableIf("allowBodyPushing")]
		[Tooltip("How quickly the player can climb")]
		public Vector3 pushingStrength;

		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float pushingAcceleration;

		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float pushingDrag;

		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[Tooltip("Platforms will move the player with them. A platform is an object with the Transform component on it")]
		[AutoToggleHeader("Enable Platforming", 0, 0)]
		public bool allowPlatforms;

		[Token(Token = "0x40008E1")]
		public const string HandPlayerLayer = "HandPlayer";

		[Token(Token = "0x40008E2")]
		private const int groundRayCount = 21;

		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float movementDeadzone;

		[Token(Token = "0x40008E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private float turnDeadzone;

		[Token(Token = "0x40008E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float turnResetzone;

		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float groundedOffset;

		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private HeadPhysicsFollower headPhysicsFollower;

		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private CapsuleCollider bodyCapsule;

		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Vector3 moveDirection;

		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private float turningAxis;

		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool isGrounded;

		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
		private bool axisReset;

		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private float playerHeight;

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private bool lastCrouching;

		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private float lastCrouchingHeight;

		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion startRot;

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 targetTrackedPos;

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 lastUpdatePosition;

		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Hand lastRightHand;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Hand lastLeftHand;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3 climbAxis;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Dictionary<Hand, Climbable> climbing;

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Dictionary<Pushable, Hand> pushRight;

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Dictionary<Pushable, int> pushRightCount;

		[Token(Token = "0x40008FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Dictionary<Pushable, Hand> pushLeft;

		[Token(Token = "0x40008FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Dictionary<Pushable, int> pushLeftCount;

		[Token(Token = "0x40008FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private Vector3 pushAxis;

		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		private Vector3 lastPlatformPosition;

		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private Quaternion lastPlatformRotation;

		[Token(Token = "0x40008FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private RaycastHit closestHit;

		[Token(Token = "0x4000900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		private float lastUpdateTime;

		[Token(Token = "0x4000901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private bool ignoreIterpolationFrame;

		[Token(Token = "0x4000902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private Vector3 targetPosOffset;

		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private int handPlayerMask;

		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
		private bool trackingStarted;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Vector3 lastHeadPos;

		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private Vector3 offset;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private RaycastHit newClosestHit;

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
		private float highestPoint;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private Coroutine disableGroundingRoutine;

		[Token(Token = "0x170000A7")]
		public static AutoHandPlayer Instance
		{
			[Token(Token = "0x6000941")]
			[Address(RVA = "0xB6102C", Offset = "0xB6102C", VA = "0xB6102C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A8")]
		public Rigidbody body
		{
			[Token(Token = "0x6000942")]
			[Address(RVA = "0xB61144", Offset = "0xB61144", VA = "0xB61144")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000943")]
			[Address(RVA = "0xB6114C", Offset = "0xB6114C", VA = "0xB6114C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0xB61154", Offset = "0xB61154", VA = "0xB61154", Slot = "4")]
		public virtual void Start()
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0xB61724", Offset = "0xB61724", VA = "0xB61724", Slot = "5")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0xB61968", Offset = "0xB61968", VA = "0xB61968", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0xB616B0", Offset = "0xB616B0", VA = "0xB616B0")]
		[IteratorStateMachine(typeof(<CheckForTrackingStart>d__83))]
		private IEnumerator CheckForTrackingStart()
		{
			return null;
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0xB61C6C", Offset = "0xB61C6C", VA = "0xB61C6C", Slot = "7")]
		protected virtual void OnHeadTrackingStarted()
		{
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0xB613AC", Offset = "0xB613AC", VA = "0xB613AC")]
		private void CreateHeadFollower()
		{
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0xB61CA4", Offset = "0xB61CA4", VA = "0xB61CA4")]
		private void CheckHands()
		{
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0xB61744", Offset = "0xB61744", VA = "0xB61744")]
		private void EnableHand(Hand hand)
		{
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0xB61988", Offset = "0xB61988", VA = "0xB61988")]
		private void DisableHand(Hand hand)
		{
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0xB61D90", Offset = "0xB61D90", VA = "0xB61D90")]
		private void OnHandGrab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0xB61E3C", Offset = "0xB61E3C", VA = "0xB61E3C")]
		private void OnHandRelease(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0xB61F94", Offset = "0xB61F94", VA = "0xB61F94", Slot = "8")]
		public virtual void Move(Vector2 axis, bool useDeadzone = false, bool useRelativeDirection = false)
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0xB62014", Offset = "0xB62014", VA = "0xB62014", Slot = "9")]
		public virtual void Turn(float turnAxis)
		{
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0xB6201C", Offset = "0xB6201C", VA = "0xB6201C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0xB62704", Offset = "0xB62704", VA = "0xB62704", Slot = "10")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0xB627B4", Offset = "0xB627B4", VA = "0xB627B4", Slot = "11")]
		protected virtual void UpdateRigidbody(Vector3 moveDir)
		{
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0xB63578", Offset = "0xB63578", VA = "0xB63578")]
		private void SyncBodyHead()
		{
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0xB63F60", Offset = "0xB63F60", VA = "0xB63F60", Slot = "12")]
		protected virtual bool CanInputMove()
		{
			return default(bool);
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0xB63F88", Offset = "0xB63F88", VA = "0xB63F88", Slot = "13")]
		protected virtual void InterpolateMovement()
		{
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0xB64F8C", Offset = "0xB64F8C", VA = "0xB64F8C", Slot = "14")]
		protected virtual void UpdateTurn(float deltaTime)
		{
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0xB654F0", Offset = "0xB654F0", VA = "0xB654F0", Slot = "15")]
		protected virtual void Ground()
		{
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0xB65BCC", Offset = "0xB65BCC", VA = "0xB65BCC")]
		public bool IsGrounded()
		{
			return default(bool);
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0xB65BD4", Offset = "0xB65BD4", VA = "0xB65BD4")]
		public void ToggleFlying()
		{
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0xB65C08", Offset = "0xB65C08", VA = "0xB65C08", Slot = "16")]
		protected virtual void UpdatePlayerHeight()
		{
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0xB62070", Offset = "0xB62070", VA = "0xB62070")]
		protected void UpdatePlatform(bool isFixedUpdate)
		{
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0xB65D34", Offset = "0xB65D34", VA = "0xB65D34")]
		public void Jump(float jumpPower = 1f)
		{
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0xB65E04", Offset = "0xB65E04", VA = "0xB65E04")]
		public void DisableGrounding(float seconds)
		{
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0xB65E68", Offset = "0xB65E68", VA = "0xB65E68")]
		[IteratorStateMachine(typeof(<DisableGroundingSecondsRoutine>d__111))]
		private IEnumerator DisableGroundingSecondsRoutine(float seconds)
		{
			return null;
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0xB65EEC", Offset = "0xB65EEC", VA = "0xB65EEC")]
		public void AddVelocity(Vector3 force, ForceMode mode = ForceMode.Acceleration)
		{
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0xB65F08", Offset = "0xB65F08", VA = "0xB65F08", Slot = "17")]
		protected virtual void StartPush(Hand hand, GameObject other)
		{
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0xB6613C", Offset = "0xB6613C", VA = "0xB6613C", Slot = "18")]
		protected virtual void StopPush(Hand hand, GameObject other)
		{
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0xB66330", Offset = "0xB66330", VA = "0xB66330", Slot = "19")]
		protected virtual void StartGrabPush(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0xB664A0", Offset = "0xB664A0", VA = "0xB664A0", Slot = "20")]
		protected virtual void EndGrabPush(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0xB66614", Offset = "0xB66614", VA = "0xB66614", Slot = "21")]
		protected virtual void ApplyPushingForce()
		{
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0xB6700C", Offset = "0xB6700C", VA = "0xB6700C")]
		public bool IsPushing()
		{
			return default(bool);
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0xB6724C", Offset = "0xB6724C", VA = "0xB6724C", Slot = "22")]
		protected virtual void StartClimb(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0xB673F4", Offset = "0xB673F4", VA = "0xB673F4", Slot = "23")]
		protected virtual void EndClimb(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0xB6748C", Offset = "0xB6748C", VA = "0xB6748C", Slot = "24")]
		protected virtual void ApplyClimbingForce()
		{
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0xB633F4", Offset = "0xB633F4", VA = "0xB633F4")]
		public bool IsClimbing()
		{
			return default(bool);
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0xB652F8", Offset = "0xB652F8", VA = "0xB652F8")]
		public void ResetHeadBodyOffset()
		{
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0xB67784", Offset = "0xB67784", VA = "0xB67784", Slot = "25")]
		public virtual void SetPosition(Vector3 position)
		{
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0xB6780C", Offset = "0xB6780C", VA = "0xB6780C", Slot = "26")]
		public virtual void SetPosition(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0xB67C08", Offset = "0xB67C08", VA = "0xB67C08", Slot = "27")]
		public virtual void SetRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0xB67F34", Offset = "0xB67F34", VA = "0xB67F34", Slot = "28")]
		public virtual void AddRotation(Quaternion addRotation)
		{
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0xB681B0", Offset = "0xB681B0", VA = "0xB681B0", Slot = "29")]
		public virtual void Recenter()
		{
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0xB63348", Offset = "0xB63348", VA = "0xB63348")]
		private Vector3 AlterDirection(Vector3 moveAxis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0xB681B4", Offset = "0xB681B4", VA = "0xB681B4")]
		public AutoHandPlayer()
		{
		}
	}
	[Token(Token = "0x2000155")]
	[RequireComponent(typeof(Grabbable))]
	public class Climbable : MonoBehaviour
	{
		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Stabber stabber;

		[Token(Token = "0x6000980")]
		[Address(RVA = "0xB687BC", Offset = "0xB687BC", VA = "0xB687BC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0xB68A78", Offset = "0xB68A78", VA = "0xB68A78")]
		public Climbable()
		{
		}
	}
	[Token(Token = "0x2000156")]
	[RequireComponent(typeof(Rigidbody))]
	public class HeadPhysicsFollower : MonoBehaviour
	{
		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("References")]
		public Camera headCamera;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingContainer;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform followBody;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Follow Settings")]
		public float followStrength;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The maximum allowed distance from the body for the headCamera to still move")]
		internal SphereCollider headCollider;

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 startHeadPos;

		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool started;

		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _moveTo;

		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal Rigidbody body;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CollisionTracker collisionTracker;

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float lastUpdateTime;

		[Token(Token = "0x170000AD")]
		private Transform moveTo
		{
			[Token(Token = "0x6000984")]
			[Address(RVA = "0xB68AF0", Offset = "0xB68AF0", VA = "0xB68AF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0xB68C80", Offset = "0xB68C80", VA = "0xB68C80")]
		public void Start()
		{
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0xB68E94", Offset = "0xB68E94", VA = "0xB68E94")]
		internal void Init()
		{
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0xB69078", Offset = "0xB69078", VA = "0xB69078")]
		protected void FixedUpdate()
		{
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0xB69160", Offset = "0xB69160", VA = "0xB69160")]
		public bool Started()
		{
			return default(bool);
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0xB69168", Offset = "0xB69168", VA = "0xB69168", Slot = "4")]
		internal virtual void MoveTo()
		{
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0xB6938C", Offset = "0xB6938C", VA = "0xB6938C", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0xB697F8", Offset = "0xB697F8", VA = "0xB697F8")]
		public int CollisionCount()
		{
			return default(int);
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0xB69858", Offset = "0xB69858", VA = "0xB69858")]
		public HeadPhysicsFollower()
		{
		}
	}
	[Token(Token = "0x2000157")]
	[RequireComponent(typeof(InterpolatedTransformUpdater))]
	[DefaultExecutionOrder(-50)]
	public class InterpolatedTransform : MonoBehaviour
	{
		[Token(Token = "0x2000158")]
		private struct TransformData
		{
			[Token(Token = "0x4000922")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x4000923")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Quaternion rotation;

			[Token(Token = "0x4000924")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 scale;

			[Token(Token = "0x6000996")]
			[Address(RVA = "0xB699A8", Offset = "0xB699A8", VA = "0xB699A8")]
			public TransformData(Vector3 position, Quaternion rotation, Vector3 scale)
			{
			}
		}

		[Token(Token = "0x2000159")]
		[CompilerGenerated]
		private sealed class <Disable>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000925")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000926")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000927")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public InterpolatedTransform <>4__this;

			[Token(Token = "0x4000928")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float time;

			[Token(Token = "0x170000AE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600099A")]
				[Address(RVA = "0xB6A080", Offset = "0xB6A080", VA = "0xB6A080", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600099C")]
				[Address(RVA = "0xB6A0C8", Offset = "0xB6A0C8", VA = "0xB6A0C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000997")]
			[Address(RVA = "0xB69F78", Offset = "0xB69F78", VA = "0xB69F78")]
			[DebuggerHidden]
			public <Disable>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000998")]
			[Address(RVA = "0xB69FB0", Offset = "0xB69FB0", VA = "0xB69FB0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000999")]
			[Address(RVA = "0xB69FB4", Offset = "0xB69FB4", VA = "0xB69FB4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600099B")]
			[Address(RVA = "0xB6A088", Offset = "0xB6A088", VA = "0xB6A088", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400091E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TransformData[] m_lastTransforms;

		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_newTransformIndex;

		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool run;

		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Coroutine disableForTime;

		[Token(Token = "0x600098D")]
		[Address(RVA = "0xB69868", Offset = "0xB69868", VA = "0xB69868")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0xB6986C", Offset = "0xB6986C", VA = "0xB6986C")]
		public void ForgetPreviousTransforms()
		{
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0xB699CC", Offset = "0xB699CC", VA = "0xB699CC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0xB69AD4", Offset = "0xB69AD4", VA = "0xB69AD4")]
		public void LateFixedUpdate()
		{
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0xB69BD4", Offset = "0xB69BD4", VA = "0xB69BD4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0xB69E50", Offset = "0xB69E50", VA = "0xB69E50")]
		public void DisableForSeconds(float time)
		{
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0xB69EF4", Offset = "0xB69EF4", VA = "0xB69EF4")]
		[IteratorStateMachine(typeof(<Disable>d__10))]
		private IEnumerator Disable(float time)
		{
			return null;
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0xB69BC4", Offset = "0xB69BC4", VA = "0xB69BC4")]
		private int OldTransformIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0xB69FA0", Offset = "0xB69FA0", VA = "0xB69FA0")]
		public InterpolatedTransform()
		{
		}
	}
	[Token(Token = "0x200015A")]
	[DefaultExecutionOrder(100)]
	public class InterpolatedTransformUpdater : MonoBehaviour
	{
		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private InterpolatedTransform _interpolatedTransform;

		[Token(Token = "0x170000B0")]
		private InterpolatedTransform interpolatedTransform
		{
			[Token(Token = "0x600099D")]
			[Address(RVA = "0xB6A0D0", Offset = "0xB6A0D0", VA = "0xB6A0D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0xB6A178", Offset = "0xB6A178", VA = "0xB6A178")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0xB6A194", Offset = "0xB6A194", VA = "0xB6A194")]
		public InterpolatedTransformUpdater()
		{
		}
	}
	[Token(Token = "0x200015B")]
	[DefaultExecutionOrder(-100)]
	public class InterpolationController : MonoBehaviour
	{
		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float[] m_lastFixedUpdateTimes;

		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_newTimeIndex;

		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float m_interpolationFactor;

		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static InterpolationController _Instance;

		[Token(Token = "0x170000B1")]
		public static float InterpolationFactor
		{
			[Token(Token = "0x60009A0")]
			[Address(RVA = "0xB6A19C", Offset = "0xB6A19C", VA = "0xB6A19C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B2")]
		public static InterpolationController Instance
		{
			[Token(Token = "0x60009A1")]
			[Address(RVA = "0xB6A1E4", Offset = "0xB6A1E4", VA = "0xB6A1E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0xB6A374", Offset = "0xB6A374", VA = "0xB6A374")]
		public void Start()
		{
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0xB6A3D4", Offset = "0xB6A3D4", VA = "0xB6A3D4")]
		public void FixedUpdate()
		{
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0xB6A43C", Offset = "0xB6A43C", VA = "0xB6A43C")]
		public void Update()
		{
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0xB6A42C", Offset = "0xB6A42C", VA = "0xB6A42C")]
		private int OldTimeIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0xB6A4FC", Offset = "0xB6A4FC", VA = "0xB6A4FC")]
		public InterpolationController()
		{
		}
	}
	[Token(Token = "0x200015C")]
	public class PlayerPlatform : MonoBehaviour
	{
		[Token(Token = "0x60009A7")]
		[Address(RVA = "0xB6A504", Offset = "0xB6A504", VA = "0xB6A504")]
		public PlayerPlatform()
		{
		}
	}
	[Token(Token = "0x200015D")]
	public class Pushable : MonoBehaviour
	{
		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 strengthScale;

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0xB6A50C", Offset = "0xB6A50C", VA = "0xB6A50C")]
		public Pushable()
		{
		}
	}
	[Token(Token = "0x200015E")]
	public class Teleporter : MonoBehaviour
	{
		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The object to teleport")]
		[Header("Teleport")]
		public GameObject teleportObject;

		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Can be left empty - Used for if there is a container that should be teleported in addition to the main teleport object")]
		public Transform[] additionalTeleports;

		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The Object to Shoot the Beam From")]
		[Header("Aim Settings")]
		public Transform aimer;

		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Layers You Can Teleport On")]
		public LayerMask layer;

		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("The Maximum Slope You Can Teleport On")]
		public float maxSurfaceAngle;

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Min(0f)]
		public float distanceMultiplyer;

		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Min(0f)]
		public float curveStrength;

		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Use Worldspace Must be True")]
		public LineRenderer line;

		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Maximum Length of The Teleport Line")]
		public int lineSegments;

		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Line Settings")]
		public Gradient canTeleportColor;

		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Gradient cantTeleportColor;

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("This gameobject will match the position of the teleport point when aiming")]
		public GameObject indicator;

		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("Unity Events")]
		public UnityEvent OnStartTeleport;

		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UnityEvent OnStopTeleport;

		[Token(Token = "0x400093D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public UnityEvent OnTeleport;

		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3[] lineArr;

		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool aiming;

		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool hitting;

		[Token(Token = "0x4000941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private RaycastHit aimHit;

		[Token(Token = "0x4000942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private HandTeleportGuard[] teleportGuards;

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AutoHandPlayer playerBody;

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0xB6A56C", Offset = "0xB6A56C", VA = "0xB6A56C")]
		private void Start()
		{
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0xB6A6D4", Offset = "0xB6A6D4", VA = "0xB6A6D4")]
		private void Update()
		{
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0xB6A714", Offset = "0xB6A714", VA = "0xB6A714")]
		private void CalculateTeleport()
		{
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0xB6AC98", Offset = "0xB6AC98", VA = "0xB6AC98")]
		private void DrawIndicator()
		{
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0xB6ADAC", Offset = "0xB6ADAC", VA = "0xB6ADAC")]
		public void StartTeleport()
		{
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0xB6ADCC", Offset = "0xB6ADCC", VA = "0xB6ADCC")]
		public void CancelTeleport()
		{
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0xB6AE0C", Offset = "0xB6AE0C", VA = "0xB6AE0C")]
		public void Teleport()
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0xB6B158", Offset = "0xB6B158", VA = "0xB6B158")]
		public Teleporter()
		{
		}
	}
	[Token(Token = "0x200015F")]
	public class AutoInputModule : BaseInputModule
	{
		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<HandCanvasPointer> pointers;

		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private PointerEventData[] eventDatas;

		[Token(Token = "0x4000946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AutoInputModule _instance;

		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool _isDestroyed;

		[Token(Token = "0x170000B3")]
		public AutoInputModule Instance
		{
			[Token(Token = "0x60009B1")]
			[Address(RVA = "0xB6B2A0", Offset = "0xB6B2A0", VA = "0xB6B2A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0xB6B3FC", Offset = "0xB6B3FC", VA = "0xB6B3FC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0xB6B404", Offset = "0xB6B404", VA = "0xB6B404", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0xB6B410", Offset = "0xB6B410", VA = "0xB6B410")]
		public int AddPointer(HandCanvasPointer pointer)
		{
			return default(int);
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0xB6B6C4", Offset = "0xB6B6C4", VA = "0xB6B6C4")]
		public void RemovePointer(HandCanvasPointer pointer)
		{
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0xB6BA40", Offset = "0xB6BA40", VA = "0xB6BA40", Slot = "17")]
		public override void Process()
		{
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0xB6BEA0", Offset = "0xB6BEA0", VA = "0xB6BEA0")]
		public void ProcessPress(int index)
		{
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0xB6C128", Offset = "0xB6C128", VA = "0xB6C128")]
		public void ProcessRelease(int index)
		{
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0xB6C4D4", Offset = "0xB6C4D4", VA = "0xB6C4D4")]
		public PointerEventData GetData(int index)
		{
			return null;
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0xB6C504", Offset = "0xB6C504", VA = "0xB6C504")]
		public AutoInputModule()
		{
		}
	}
	[Token(Token = "0x2000160")]
	public delegate void CollisionEvent(GameObject from);
	[Token(Token = "0x2000161")]
	public class CollisionTracker : MonoBehaviour
	{
		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool disableCollisionTracking;

		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool disableTriggersTracking;

		[Token(Token = "0x170000B4")]
		public int collisionCount
		{
			[Token(Token = "0x60009C7")]
			[Address(RVA = "0xB69810", Offset = "0xB69810", VA = "0xB69810")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B5")]
		public int triggerCount
		{
			[Token(Token = "0x60009C8")]
			[Address(RVA = "0xB6CB60", Offset = "0xB6CB60", VA = "0xB6CB60")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B6")]
		public List<GameObject> triggerObjects
		{
			[Token(Token = "0x60009C9")]
			[Address(RVA = "0xB6CBA8", Offset = "0xB6CBA8", VA = "0xB6CBA8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009CA")]
			[Address(RVA = "0xB6CBB0", Offset = "0xB6CBB0", VA = "0xB6CBB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000B7")]
		public List<int> triggerObjectsCount
		{
			[Token(Token = "0x60009CB")]
			[Address(RVA = "0xB6CBB8", Offset = "0xB6CBB8", VA = "0xB6CBB8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009CC")]
			[Address(RVA = "0xB6CBC0", Offset = "0xB6CBC0", VA = "0xB6CBC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		public List<GameObject> collisionObjects
		{
			[Token(Token = "0x60009CD")]
			[Address(RVA = "0xB6CBC8", Offset = "0xB6CBC8", VA = "0xB6CBC8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009CE")]
			[Address(RVA = "0xB6CBD0", Offset = "0xB6CBD0", VA = "0xB6CBD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public List<int> collisionObjectsCount
		{
			[Token(Token = "0x60009CF")]
			[Address(RVA = "0xB6CBD8", Offset = "0xB6CBD8", VA = "0xB6CBD8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009D0")]
			[Address(RVA = "0xB6CBE0", Offset = "0xB6CBE0", VA = "0xB6CBE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x14000018")]
		public event CollisionEvent OnCollisionFirstEnter
		{
			[Token(Token = "0x60009BF")]
			[Address(RVA = "0xB6C680", Offset = "0xB6C680", VA = "0xB6C680")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60009C0")]
			[Address(RVA = "0xB6C71C", Offset = "0xB6C71C", VA = "0xB6C71C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000019")]
		public event CollisionEvent OnCollisionLastExit
		{
			[Token(Token = "0x60009C1")]
			[Address(RVA = "0xB6C7B8", Offset = "0xB6C7B8", VA = "0xB6C7B8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60009C2")]
			[Address(RVA = "0xB6C854", Offset = "0xB6C854", VA = "0xB6C854")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001A")]
		public event CollisionEvent OnTriggerFirstEnter
		{
			[Token(Token = "0x60009C3")]
			[Address(RVA = "0xB6C8F0", Offset = "0xB6C8F0", VA = "0xB6C8F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60009C4")]
			[Address(RVA = "0xB6C98C", Offset = "0xB6C98C", VA = "0xB6C98C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001B")]
		public event CollisionEvent OnTriggeLastExit
		{
			[Token(Token = "0x60009C5")]
			[Address(RVA = "0xB6CA28", Offset = "0xB6CA28", VA = "0xB6CA28")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60009C6")]
			[Address(RVA = "0xB6CAC4", Offset = "0xB6CAC4", VA = "0xB6CAC4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0xB6CBE8", Offset = "0xB6CBE8", VA = "0xB6CBE8")]
		public void Clear()
		{
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0xB6CCB0", Offset = "0xB6CCB0", VA = "0xB6CCB0", Slot = "4")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0xB6CEFC", Offset = "0xB6CEFC", VA = "0xB6CEFC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0xB6CF00", Offset = "0xB6CF00", VA = "0xB6CF00")]
		private void CheckCollisions()
		{
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0xB6D1A8", Offset = "0xB6D1A8", VA = "0xB6D1A8", Slot = "5")]
		protected virtual void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0xB6D414", Offset = "0xB6D414", VA = "0xB6D414", Slot = "6")]
		protected virtual void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0xB6D5F8", Offset = "0xB6D5F8", VA = "0xB6D5F8", Slot = "7")]
		protected virtual void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0xB6D834", Offset = "0xB6D834", VA = "0xB6D834", Slot = "8")]
		protected virtual void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0xB6DA04", Offset = "0xB6DA04", VA = "0xB6DA04")]
		public CollisionTracker()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000162")]
	public class UnityCanvasPointerEvent : UnityEvent<Vector3, GameObject>
	{
		[Token(Token = "0x60009DA")]
		[Address(RVA = "0xB6DB3C", Offset = "0xB6DB3C", VA = "0xB6DB3C")]
		public UnityCanvasPointerEvent()
		{
		}
	}
	[Token(Token = "0x2000163")]
	public class HandCanvasPointer : MonoBehaviour
	{
		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("References")]
		public GameObject hitPointMarker;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private LineRenderer lineRenderer;

		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Ray settings")]
		public float raycastLength;

		[Token(Token = "0x4000955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool autoShowTarget;

		[Token(Token = "0x4000956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LayerMask UILayer;

		[Token(Token = "0x4000957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Events")]
		public UnityCanvasPointerEvent StartSelect;

		[Token(Token = "0x4000958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityCanvasPointerEvent StopSelect;

		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UnityCanvasPointerEvent StartPoint;

		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityCanvasPointerEvent StopPoint;

		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject _currTarget;

		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool hover;

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AutoInputModule inputModule;

		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lineSegements;

		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Camera cam;

		[Token(Token = "0x4000961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int pointerIndex;

		[Token(Token = "0x170000BA")]
		public GameObject currTarget
		{
			[Token(Token = "0x60009DB")]
			[Address(RVA = "0xB6DB84", Offset = "0xB6DB84", VA = "0xB6DB84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BB")]
		public RaycastHit lastHit
		{
			[Token(Token = "0x60009DC")]
			[Address(RVA = "0xB6DB8C", Offset = "0xB6DB8C", VA = "0xB6DB8C")]
			[CompilerGenerated]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60009DD")]
			[Address(RVA = "0xB6DBA0", Offset = "0xB6DBA0", VA = "0xB6DBA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		public static Camera UICamera
		{
			[Token(Token = "0x60009DE")]
			[Address(RVA = "0xB6DBBC", Offset = "0xB6DBBC", VA = "0xB6DBBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0xB6DECC", Offset = "0xB6DECC", VA = "0xB6DECC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0xB6E0E8", Offset = "0xB6E0E8", VA = "0xB6E0E8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0xB6E178", Offset = "0xB6E178", VA = "0xB6E178")]
		public void SetIndex(int index)
		{
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0xB6BE10", Offset = "0xB6BE10", VA = "0xB6BE10")]
		internal void Preprocess()
		{
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0xB6E180", Offset = "0xB6E180", VA = "0xB6E180")]
		public void Press()
		{
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0xB6E380", Offset = "0xB6E380", VA = "0xB6E380")]
		public void Release()
		{
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0xB6E580", Offset = "0xB6E580", VA = "0xB6E580")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0xB6E830", Offset = "0xB6E830", VA = "0xB6E830")]
		private void Update()
		{
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0xB6E834", Offset = "0xB6E834", VA = "0xB6E834")]
		private void UpdateLine()
		{
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0xB6DFC8", Offset = "0xB6DFC8", VA = "0xB6DFC8")]
		private void SetLineRendererBasePos()
		{
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0xB6F004", Offset = "0xB6F004", VA = "0xB6F004")]
		private RaycastHit CreateRaycast(float dist)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0xB6DFA8", Offset = "0xB6DFA8", VA = "0xB6DFA8")]
		public void ShowRay(bool show)
		{
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0xB6F0F4", Offset = "0xB6F0F4", VA = "0xB6F0F4")]
		private void ShowIcon(bool bShow)
		{
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0xB6F114", Offset = "0xB6F114", VA = "0xB6F114")]
		public HandCanvasPointer()
		{
		}
	}
	[Token(Token = "0x2000164")]
	[RequireComponent(typeof(Rigidbody))]
	[DefaultExecutionOrder(-1)]
	public class PhysicsFollower : MonoBehaviour
	{
		[Token(Token = "0x4000962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Follow Settings")]
		[Space]
		[Tooltip("Follow target, the hand will always try to match this transforms rotation and position with rigidbody movements")]
		public Transform follow;

		[Token(Token = "0x4000963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Stops hand physics follow - to freeze from all forces change rigidbody to kinematic or change rigidbody constraints")]
		public bool freezePos;

		[Token(Token = "0x4000964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[Tooltip("Stops hand physics follow - to freeze from all forces change rigidbody to kinematic or change rigidbody constraints")]
		public bool freezeRot;

		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("This will offset the position without offsetting the rotation pivot")]
		public Vector3 followPositionOffset;

		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Min(0f)]
		[Tooltip("Follow target speed (This will cause jittering if turned too high)")]
		public float followPositionStrength;

		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Follow target rotation speed (This will cause jittering if turned too high)")]
		[Min(0f)]
		public float followRotationStrength;

		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The maximum allowed velocity of the hand")]
		[Min(0f)]
		public float maxVelocity;

		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal Rigidbody body;

		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform moveTo;

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0xB6F134", Offset = "0xB6F134", VA = "0xB6F134")]
		public void Start()
		{
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0xB6F140", Offset = "0xB6F140", VA = "0xB6F140", Slot = "4")]
		public virtual void Set()
		{
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0xB6F314", Offset = "0xB6F314", VA = "0xB6F314")]
		public void Update()
		{
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0xB6F320", Offset = "0xB6F320", VA = "0xB6F320", Slot = "5")]
		protected virtual void OnUpdate()
		{
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0xB6F4D8", Offset = "0xB6F4D8", VA = "0xB6F4D8")]
		public void FixedUpdate()
		{
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0xB6F4E4", Offset = "0xB6F4E4", VA = "0xB6F4E4", Slot = "6")]
		protected virtual void OnFixedUpdate()
		{
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0xB6F6CC", Offset = "0xB6F6CC", VA = "0xB6F6CC", Slot = "7")]
		internal virtual void MoveTo()
		{
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0xB6F90C", Offset = "0xB6F90C", VA = "0xB6F90C", Slot = "8")]
		internal virtual void TorqueTo()
		{
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0xB6FD54", Offset = "0xB6FD54", VA = "0xB6FD54")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0xB6FDC8", Offset = "0xB6FDC8", VA = "0xB6FDC8")]
		public PhysicsFollower()
		{
		}
	}
	[Token(Token = "0x2000165")]
	public class Stabbable : MonoBehaviour
	{
		[Token(Token = "0x400096C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody body;

		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Grabbable grabbable;

		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The index that must match the stabbers index to allow stabbing")]
		public int stabIndex;

		[Token(Token = "0x400096F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int maxStabbers;

		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float positionDamper;

		[Token(Token = "0x4000971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rotationDamper;

		[Token(Token = "0x4000972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool parentOnStab;

		[Token(Token = "0x4000973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Events")]
		public UnityEvent StartStab;

		[Token(Token = "0x4000974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UnityEvent EndStab;

		[Token(Token = "0x4000975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public StabEvent StartStabEvent;

		[Token(Token = "0x4000976")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public StabEvent EndStabEvent;

		[Token(Token = "0x4000977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int currentStabs;

		[Token(Token = "0x4000978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<Stabber> stabbing;

		[Token(Token = "0x4000979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform stabParent;

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0xB6FDE0", Offset = "0xB6FDE0", VA = "0xB6FDE0")]
		public void Start()
		{
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0xB70074", Offset = "0xB70074", VA = "0xB70074", Slot = "4")]
		public virtual void OnStab(Stabber stabber)
		{
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0xB70178", Offset = "0xB70178", VA = "0xB70178", Slot = "5")]
		public virtual void OnEndStab(Stabber stabber)
		{
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0xB70208", Offset = "0xB70208", VA = "0xB70208", Slot = "6")]
		public virtual bool CanStab(Stabber stabber)
		{
			return default(bool);
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0xB70244", Offset = "0xB70244", VA = "0xB70244")]
		public int StabbedCount()
		{
			return default(int);
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0xB7028C", Offset = "0xB7028C", VA = "0xB7028C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0xB7036C", Offset = "0xB7036C", VA = "0xB7036C")]
		public Stabbable()
		{
		}
	}
	[Token(Token = "0x2000166")]
	public delegate void StabEvent(Stabber stabber, Stabbable stab);
	[Token(Token = "0x2000167")]
	public class Stabber : MonoBehaviour
	{
		[Token(Token = "0x2000168")]
		[CompilerGenerated]
		private sealed class <StartWait>d__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000998")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000999")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400099A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Stabber <>4__this;

			[Token(Token = "0x400099B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x170000BD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A14")]
				[Address(RVA = "0xB721EC", Offset = "0xB721EC", VA = "0xB721EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A16")]
				[Address(RVA = "0xB72234", Offset = "0xB72234", VA = "0xB72234", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A11")]
			[Address(RVA = "0xB70838", Offset = "0xB70838", VA = "0xB70838")]
			[DebuggerHidden]
			public <StartWait>d__31(int <>1__state)
			{
			}

			[Token(Token = "0x6000A12")]
			[Address(RVA = "0xB720E8", Offset = "0xB720E8", VA = "0xB720E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A13")]
			[Address(RVA = "0xB720EC", Offset = "0xB720EC", VA = "0xB720EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A15")]
			[Address(RVA = "0xB721F4", Offset = "0xB721F4", VA = "0xB721F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400097A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Can be left empty/null")]
		public Grabbable grabbable;

		[Token(Token = "0x400097B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Stab Settings")]
		public CapsuleCollider stabCapsule;

		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If left empty, will default to grabbable layers")]
		public LayerMask stabbableLayers;

		[Token(Token = "0x400097D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("The index that must match the stabbables index to allow stabbing")]
		public int stabIndex;

		[Token(Token = "0x400097E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int maxStabs;

		[Token(Token = "0x400097F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Header("Joint Settings")]
		public Vector3 axis;

		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float limit;

		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public ConfigurableJointMotion xMotion;

		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ConfigurableJointMotion yMotion;

		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public ConfigurableJointMotion zMotion;

		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public ConfigurableJointMotion angularXMotion;

		[Token(Token = "0x4000985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public ConfigurableJointMotion angularYMotion;

		[Token(Token = "0x4000986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ConfigurableJointMotion angularZMotion;

		[Token(Token = "0x4000987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Space]
		public float positionDampeningMultiplyer;

		[Token(Token = "0x4000988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float rotationDampeningMultiplyer;

		[Token(Token = "0x4000989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("Events")]
		public UnityEvent StartStab;

		[Token(Token = "0x400098A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UnityEvent EndStab;

		[Token(Token = "0x400098B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public StabEvent StartStabEvent;

		[Token(Token = "0x400098C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public StabEvent EndStabEvent;

		[Token(Token = "0x400098D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<Stabbable> stabbed;

		[Token(Token = "0x400098E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<ConfigurableJoint> stabbedJoints;

		[Token(Token = "0x400098F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Dictionary<Stabbable, int> stabbedFrames;

		[Token(Token = "0x4000990")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Collider[] resultsNonAlloc;

		[Token(Token = "0x4000991")]
		private const int STABFRAMES = 3;

		[Token(Token = "0x4000992")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 startPos;

		[Token(Token = "0x4000993")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private Quaternion startRot;

		[Token(Token = "0x4000994")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Vector3 lastPos;

		[Token(Token = "0x4000995")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion lastRot;

		[Token(Token = "0x4000996")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int frames;

		[Token(Token = "0x4000997")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Dictionary<Transform, Transform> originalParents;

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0xB70474", Offset = "0xB70474", VA = "0xB70474")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0xB707C4", Offset = "0xB707C4", VA = "0xB707C4")]
		[IteratorStateMachine(typeof(<StartWait>d__31))]
		private IEnumerator StartWait()
		{
			return null;
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0xB70860", Offset = "0xB70860", VA = "0xB70860")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0xB70988", Offset = "0xB70988", VA = "0xB70988", Slot = "4")]
		protected virtual void CheckStabArea()
		{
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0xB712DC", Offset = "0xB712DC", VA = "0xB712DC", Slot = "5")]
		protected virtual void OnStabbableEnter(Stabbable stab)
		{
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0xB71960", Offset = "0xB71960", VA = "0xB71960", Slot = "6")]
		protected virtual void OnStabbableExit(Stabbable stab)
		{
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0xB71B58", Offset = "0xB71B58", VA = "0xB71B58")]
		public List<Stabbable> GetStabbed()
		{
			return null;
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0xB71B60", Offset = "0xB71B60", VA = "0xB71B60")]
		public int GetStabbedCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0xB71BA8", Offset = "0xB71BA8", VA = "0xB71BA8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0xB72020", Offset = "0xB72020", VA = "0xB72020")]
		public Stabber()
		{
		}
	}
	[Token(Token = "0x2000169")]
	public class Stickable : MonoBehaviour
	{
		[Token(Token = "0x400099C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Sticky Settings")]
		public Rigidbody body;

		[Token(Token = "0x400099D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("How strong the joint is between the stickable and this")]
		public float stickStrength;

		[Token(Token = "0x400099E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Multiplyer for required stick speed to activate")]
		public float stickSpeedMultiplyer;

		[Token(Token = "0x400099F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("This index must match the sticky object to stick")]
		public int stickIndex;

		[Token(Token = "0x40009A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Event")]
		public UnityEvent OnStick;

		[Token(Token = "0x40009A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UnityEvent EndStick;

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0xB7223C", Offset = "0xB7223C", VA = "0xB7223C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0xB7231C", Offset = "0xB7231C", VA = "0xB7231C")]
		public Stickable()
		{
		}
	}
	[Token(Token = "0x200016A")]
	[RequireComponent(typeof(Rigidbody))]
	public class Sticky : MonoBehaviour
	{
		[Token(Token = "0x200016B")]
		[CompilerGenerated]
		private sealed class <JointBreak>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Sticky <>4__this;

			[Token(Token = "0x170000BF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A23")]
				[Address(RVA = "0xB72B2C", Offset = "0xB72B2C", VA = "0xB72B2C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A25")]
				[Address(RVA = "0xB72B74", Offset = "0xB72B74", VA = "0xB72B74", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A20")]
			[Address(RVA = "0xB72828", Offset = "0xB72828", VA = "0xB72828")]
			[DebuggerHidden]
			public <JointBreak>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000A21")]
			[Address(RVA = "0xB72940", Offset = "0xB72940", VA = "0xB72940", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A22")]
			[Address(RVA = "0xB72944", Offset = "0xB72944", VA = "0xB72944", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A24")]
			[Address(RVA = "0xB72B34", Offset = "0xB72B34", VA = "0xB72B34", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40009A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Sticky Settings")]
		[Tooltip("How strong the joint is between the stickable and this")]
		public float stickStrength;

		[Token(Token = "0x40009A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Multiplyer for required stick speed to activate")]
		public float requiredStickSpeed;

		[Token(Token = "0x40009A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("This index must match the stickable object to stick")]
		public int stickIndex;

		[Token(Token = "0x40009A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Event")]
		public UnityEvent OnStick;

		[Token(Token = "0x40009A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody body;

		[Token(Token = "0x40009A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Stickable> stickers;

		[Token(Token = "0x40009A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Joint> joints;

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0xB7232C", Offset = "0xB7232C", VA = "0xB7232C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0xB72470", Offset = "0xB72470", VA = "0xB72470")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0xB724F0", Offset = "0xB724F0", VA = "0xB724F0")]
		private void CreateStick(Stickable sticker)
		{
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0xB72794", Offset = "0xB72794", VA = "0xB72794")]
		private void OnJointBreak(float breakForce)
		{
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0xB727B4", Offset = "0xB727B4", VA = "0xB727B4")]
		[IteratorStateMachine(typeof(<JointBreak>d__11))]
		private IEnumerator JointBreak()
		{
			return null;
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0xB72850", Offset = "0xB72850", VA = "0xB72850")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0xB72930", Offset = "0xB72930", VA = "0xB72930")]
		public Sticky()
		{
		}
	}
}
namespace Autohand.Demo
{
	[Token(Token = "0x200016C")]
	public class XRAutoHandAxisFingerBender : MonoBehaviour
	{
		[Token(Token = "0x40009AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public XRHandControllerLink controller;

		[Token(Token = "0x40009AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CommonAxis axis;

		[Token(Token = "0x40009AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public float[] bendOffsets;

		[Token(Token = "0x40009AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float lastAxis;

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0xB72B7C", Offset = "0xB72B7C", VA = "0xB72B7C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0xB72C7C", Offset = "0xB72C7C", VA = "0xB72C7C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0xB72DAC", Offset = "0xB72DAC", VA = "0xB72DAC")]
		public XRAutoHandAxisFingerBender()
		{
		}
	}
	[Token(Token = "0x200016D")]
	public class XRAutoHandFingerBender : MonoBehaviour
	{
		[Token(Token = "0x40009B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public XRHandControllerLink controller;

		[Token(Token = "0x40009B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CommonButton button;

		[Token(Token = "0x40009B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public float[] bendOffsets;

		[Token(Token = "0x40009B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool pressed;

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0xB72DB4", Offset = "0xB72DB4", VA = "0xB72DB4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0xB72F5C", Offset = "0xB72F5C", VA = "0xB72F5C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0xB7308C", Offset = "0xB7308C", VA = "0xB7308C")]
		public XRAutoHandFingerBender()
		{
		}
	}
	[Token(Token = "0x200016E")]
	public class XRControllerEvent : MonoBehaviour
	{
		[Token(Token = "0x40009B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public XRHandControllerLink link;

		[Token(Token = "0x40009B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CommonButton button;

		[Token(Token = "0x40009B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEvent Pressed;

		[Token(Token = "0x40009B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityEvent Released;

		[Token(Token = "0x40009B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool pressed;

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0xB73094", Offset = "0xB73094", VA = "0xB73094")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0xB73110", Offset = "0xB73110", VA = "0xB73110")]
		public XRControllerEvent()
		{
		}
	}
	[Token(Token = "0x200016F")]
	public enum CommonButton
	{
		[Token(Token = "0x40009BA")]
		gripButton,
		[Token(Token = "0x40009BB")]
		menuButton,
		[Token(Token = "0x40009BC")]
		primaryButton,
		[Token(Token = "0x40009BD")]
		secondaryButton,
		[Token(Token = "0x40009BE")]
		triggerButton,
		[Token(Token = "0x40009BF")]
		primary2DAxisClick,
		[Token(Token = "0x40009C0")]
		primary2DAxisTouch,
		[Token(Token = "0x40009C1")]
		secondary2DAxisClick,
		[Token(Token = "0x40009C2")]
		secondary2DAxisTouch,
		[Token(Token = "0x40009C3")]
		primaryTouch,
		[Token(Token = "0x40009C4")]
		secondaryTouch,
		[Token(Token = "0x40009C5")]
		none
	}
	[Token(Token = "0x2000170")]
	public enum CommonAxis
	{
		[Token(Token = "0x40009C7")]
		trigger,
		[Token(Token = "0x40009C8")]
		grip,
		[Token(Token = "0x40009C9")]
		none
	}
	[Token(Token = "0x2000171")]
	public enum Common2DAxis
	{
		[Token(Token = "0x40009CB")]
		primaryAxis,
		[Token(Token = "0x40009CC")]
		secondaryAxis,
		[Token(Token = "0x40009CD")]
		none
	}
	[Token(Token = "0x2000172")]
	public class XRHandControllerLink : HandControllerLink
	{
		[Token(Token = "0x40009CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CommonButton grabButton;

		[Token(Token = "0x40009CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("This axis will bend all the fingers on the hand -> replaced with finger bender scripts")]
		public CommonAxis grabAxis;

		[Token(Token = "0x40009D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CommonButton squeezeButton;

		[Token(Token = "0x40009D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private XRNode role;

		[Token(Token = "0x40009D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool squeezing;

		[Token(Token = "0x40009D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool grabbing;

		[Token(Token = "0x40009D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InputDevice device;

		[Token(Token = "0x40009D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<InputDevice> devices;

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0xB73118", Offset = "0xB73118", VA = "0xB73118")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0xB731C8", Offset = "0xB731C8", VA = "0xB731C8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0xB734B4", Offset = "0xB734B4", VA = "0xB734B4")]
		public List<InputDevice> Devices()
		{
			return null;
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0xB72EFC", Offset = "0xB72EFC", VA = "0xB72EFC")]
		public bool ButtonPressed(CommonButton button)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0xB72C28", Offset = "0xB72C28", VA = "0xB72C28")]
		public float GetAxis(CommonAxis axis)
		{
			return default(float);
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0xB73528", Offset = "0xB73528", VA = "0xB73528")]
		public Vector2 GetAxis2D(Common2DAxis axis)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0xB73620", Offset = "0xB73620", VA = "0xB73620", Slot = "4")]
		public override void TryHapticImpulse(float duration, float amp, float freq = 0f)
		{
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0xB73300", Offset = "0xB73300", VA = "0xB73300")]
		public static InputFeatureUsage<bool> GetCommonButton(CommonButton button)
		{
			return default(InputFeatureUsage<bool>);
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0xB734BC", Offset = "0xB734BC", VA = "0xB734BC")]
		public static InputFeatureUsage<float> GetCommonAxis(CommonAxis axis)
		{
			return default(InputFeatureUsage<float>);
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0xB735B4", Offset = "0xB735B4", VA = "0xB735B4")]
		public static InputFeatureUsage<Vector2> GetCommon2DAxis(Common2DAxis axis)
		{
			return default(InputFeatureUsage<Vector2>);
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0xB737C8", Offset = "0xB737C8", VA = "0xB737C8")]
		public XRHandControllerLink()
		{
		}
	}
	[Token(Token = "0x2000173")]
	public class XRHandPlayerControllerLink : MonoBehaviour
	{
		[Token(Token = "0x40009D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public XRHandControllerLink moveController;

		[Token(Token = "0x40009D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public XRHandControllerLink turnController;

		[Token(Token = "0x40009D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AutoHandPlayer player;

		[Token(Token = "0x40009D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Input")]
		public Common2DAxis moveAxis;

		[Token(Token = "0x40009DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Common2DAxis turnAxis;

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0xB73858", Offset = "0xB73858", VA = "0xB73858")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0xB738C8", Offset = "0xB738C8", VA = "0xB738C8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0xB73908", Offset = "0xB73908", VA = "0xB73908")]
		public XRHandPlayerControllerLink()
		{
		}
	}
	[Token(Token = "0x2000174")]
	public class XRHandPointGrabLink : MonoBehaviour
	{
		[Token(Token = "0x40009DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HandDistanceGrabber pointGrab;

		[Token(Token = "0x40009DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public XRHandControllerLink link;

		[Token(Token = "0x40009DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Input")]
		public CommonButton pointInput;

		[Token(Token = "0x40009DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public CommonButton selectInput;

		[Token(Token = "0x40009DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool pointing;

		[Token(Token = "0x40009E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool selecting;

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0xB73910", Offset = "0xB73910", VA = "0xB73910")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0xB73A00", Offset = "0xB73A00", VA = "0xB73A00")]
		public XRHandPointGrabLink()
		{
		}
	}
	[Token(Token = "0x2000175")]
	public class XRHeadTracking : MonoBehaviour
	{
		[Token(Token = "0x40009E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TrackingOriginModeFlags mode;

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0xB73A08", Offset = "0xB73A08", VA = "0xB73A08")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0xB73B24", Offset = "0xB73B24", VA = "0xB73B24")]
		public XRHeadTracking()
		{
		}
	}
	[Token(Token = "0x2000176")]
	public class XRTeleporterLink : MonoBehaviour
	{
		[Token(Token = "0x40009E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Teleporter hand;

		[Token(Token = "0x40009E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public XRNode role;

		[Token(Token = "0x40009E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public CommonButton button;

		[Token(Token = "0x40009E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool teleporting;

		[Token(Token = "0x40009E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private InputDevice device;

		[Token(Token = "0x40009E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<InputDevice> devices;

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0xB73B34", Offset = "0xB73B34", VA = "0xB73B34")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0xB73BB0", Offset = "0xB73BB0", VA = "0xB73BB0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0xB73CC0", Offset = "0xB73CC0", VA = "0xB73CC0")]
		public XRTeleporterLink()
		{
		}
	}
	[Token(Token = "0x2000177")]
	public class BoxingGlove : MonoBehaviour
	{
		[Token(Token = "0x40009E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody body;

		[Token(Token = "0x40009E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float power;

		[Token(Token = "0x40009EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float lastHitTime;

		[Token(Token = "0x40009EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float delay;

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0xB73CC8", Offset = "0xB73CC8", VA = "0xB73CC8")]
		public void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0xB73D58", Offset = "0xB73D58", VA = "0xB73D58")]
		public BoxingGlove()
		{
		}
	}
	[Token(Token = "0x2000178")]
	public class CubeBreak : MonoBehaviour
	{
		[Token(Token = "0x40009EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float force;

		[Token(Token = "0x40009ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3[] offsets;

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0xB73D70", Offset = "0xB73D70", VA = "0xB73D70")]
		[ContextMenu("Break")]
		public void Break()
		{
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0xB7436C", Offset = "0xB7436C", VA = "0xB7436C")]
		public CubeBreak()
		{
		}
	}
	[Token(Token = "0x2000179")]
	public class DemoFlyingToggle : MonoBehaviour
	{
		[Token(Token = "0x6000A47")]
		[Address(RVA = "0xB7448C", Offset = "0xB7448C", VA = "0xB7448C")]
		public void ToggleFlying()
		{
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0xB744AC", Offset = "0xB744AC", VA = "0xB744AC")]
		public DemoFlyingToggle()
		{
		}
	}
	[Token(Token = "0x200017A")]
	public class Door : PhysicsGadgetHingeAngleReader
	{
		[Token(Token = "0x40009EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Door should start closed")]
		public Rigidbody body;

		[Token(Token = "0x40009EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 closedPosition;

		[Token(Token = "0x40009F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Quaternion closedRotation;

		[Token(Token = "0x40009F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("The door needs to reach this level of open before it can be reset")]
		public float minThreshold;

		[Token(Token = "0x40009F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float midThreshold;

		[Token(Token = "0x40009F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Tooltip("The door needs to reach this level of open before it can be reset")]
		public float maxThreshold;

		[Token(Token = "0x40009F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Space]
		public UnityEvent OnMax;

		[Token(Token = "0x40009F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public UnityEvent OnMid;

		[Token(Token = "0x40009F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UnityEvent OnMin;

		[Token(Token = "0x40009F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool min;

		[Token(Token = "0x40009F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		private bool max;

		[Token(Token = "0x40009F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9A")]
		private bool mid;

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0xB744B4", Offset = "0xB744B4", VA = "0xB744B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0xB745CC", Offset = "0xB745CC", VA = "0xB745CC")]
		protected void FixedUpdate()
		{
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0xB74708", Offset = "0xB74708", VA = "0xB74708")]
		private void Max()
		{
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0xB7474C", Offset = "0xB7474C", VA = "0xB7474C")]
		private void Mid()
		{
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0xB74728", Offset = "0xB74728", VA = "0xB74728")]
		private void Min()
		{
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0xB74770", Offset = "0xB74770", VA = "0xB74770")]
		public void ClosedDoor()
		{
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0xB747D0", Offset = "0xB747D0", VA = "0xB747D0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0xB748B0", Offset = "0xB748B0", VA = "0xB748B0")]
		public Door()
		{
		}
	}
	[Token(Token = "0x200017B")]
	public class ExplosionSource : MonoBehaviour
	{
		[Token(Token = "0x40009FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float radius;

		[Token(Token = "0x40009FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float force;

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0xB748D4", Offset = "0xB748D4", VA = "0xB748D4")]
		public void Explode(bool destroy)
		{
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0xB74A74", Offset = "0xB74A74", VA = "0xB74A74")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0xB74AC0", Offset = "0xB74AC0", VA = "0xB74AC0")]
		public ExplosionSource()
		{
		}
	}
	[Token(Token = "0x200017C")]
	public class Grenade : MonoBehaviour
	{
		[Token(Token = "0x40009FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Grabbable grenade;

		[Token(Token = "0x40009FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Grabbable pin;

		[Token(Token = "0x40009FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ConfigurableJoint pinJoint;

		[Token(Token = "0x40009FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float explosionDelay;

		[Token(Token = "0x4000A00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool startDelayOnRelease;

		[Token(Token = "0x4000A01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float explosionForce;

		[Token(Token = "0x4000A02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float explosionRadius;

		[Token(Token = "0x4000A03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pinJointStrength;

		[Token(Token = "0x4000A04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject explosionEffect;

		[Token(Token = "0x4000A05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityEvent pinBreakEvent;

		[Token(Token = "0x4000A06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UnityEvent explosionEvent;

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0xB74AD4", Offset = "0xB74AD4", VA = "0xB74AD4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0xB74EE4", Offset = "0xB74EE4", VA = "0xB74EE4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0xB75170", Offset = "0xB75170", VA = "0xB75170")]
		private void OnGrenadeGrab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0xB751EC", Offset = "0xB751EC", VA = "0xB751EC")]
		private void OnGrenadeRelease(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0xB752E4", Offset = "0xB752E4", VA = "0xB752E4")]
		private void OnPinGrab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0xB7536C", Offset = "0xB7536C", VA = "0xB7536C")]
		private void OnPinRelease(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0xB753F8", Offset = "0xB753F8", VA = "0xB753F8")]
		private void OnJointBreak(float breakForce)
		{
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0xB75450", Offset = "0xB75450", VA = "0xB75450")]
		private void CheckJointBreak()
		{
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0xB75530", Offset = "0xB75530", VA = "0xB75530")]
		private void Explode()
		{
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0xB759B4", Offset = "0xB759B4", VA = "0xB759B4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0xB75A04", Offset = "0xB75A04", VA = "0xB75A04")]
		public Grenade()
		{
		}
	}
	[Token(Token = "0x200017D")]
	public class HandSwapper : MonoBehaviour
	{
		[Token(Token = "0x4000A07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AutoHandPlayer player;

		[Token(Token = "0x4000A08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Hand fromHand;

		[Token(Token = "0x4000A09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Hand toHand;

		[Token(Token = "0x4000A0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject fromModel;

		[Token(Token = "0x4000A0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject toModel;

		[Token(Token = "0x4000A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool swapped;

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0xB75A2C", Offset = "0xB75A2C", VA = "0xB75A2C")]
		public void Swap()
		{
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0xB75BC0", Offset = "0xB75BC0", VA = "0xB75BC0")]
		public HandSwapper()
		{
		}
	}
	[Token(Token = "0x200017E")]
	public class JointBreakStopForce1 : MonoBehaviour
	{
		[Token(Token = "0x6000A61")]
		[Address(RVA = "0xB75BC8", Offset = "0xB75BC8", VA = "0xB75BC8")]
		private void OnJointBreak(float breakForce)
		{
		}

		[Token(Token = "0x6000A62")]
		[Address(RVA = "0xB75CC0", Offset = "0xB75CC0", VA = "0xB75CC0")]
		public JointBreakStopForce1()
		{
		}
	}
	[Token(Token = "0x200017F")]
	public class Pistol : MonoBehaviour
	{
		[Token(Token = "0x4000A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody body;

		[Token(Token = "0x4000A0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform barrelTip;

		[Token(Token = "0x4000A0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float hitPower;

		[Token(Token = "0x4000A10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float recoilPower;

		[Token(Token = "0x4000A11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float range;

		[Token(Token = "0x4000A12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask layer;

		[Token(Token = "0x4000A13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioClip shootSound;

		[Token(Token = "0x4000A14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float shootVolume;

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0xB75CC8", Offset = "0xB75CC8", VA = "0xB75CC8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0xB75DB0", Offset = "0xB75DB0", VA = "0xB75DB0")]
		public void Shoot()
		{
		}

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0xB7623C", Offset = "0xB7623C", VA = "0xB7623C")]
		public Pistol()
		{
		}
	}
	[Token(Token = "0x2000180")]
	public class PlayerFallCatcher : MonoBehaviour
	{
		[Token(Token = "0x4000A15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 startPos;

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0xB7625C", Offset = "0xB7625C", VA = "0xB7625C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0xB76388", Offset = "0xB76388", VA = "0xB76388")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0xB76458", Offset = "0xB76458", VA = "0xB76458")]
		public PlayerFallCatcher()
		{
		}
	}
	[Token(Token = "0x2000181")]
	public class ScaleHighlight : MonoBehaviour
	{
		[Token(Token = "0x4000A16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 highlighScale;

		[Token(Token = "0x4000A17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 normalScale;

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0xB76460", Offset = "0xB76460", VA = "0xB76460")]
		public void Highlight()
		{
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0xB7648C", Offset = "0xB7648C", VA = "0xB7648C")]
		public void HighlightStop()
		{
		}

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0xB764B8", Offset = "0xB764B8", VA = "0xB764B8")]
		public ScaleHighlight()
		{
		}
	}
	[Token(Token = "0x2000182")]
	public class Spinner : MonoBehaviour
	{
		[Token(Token = "0x4000A18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 rotationSpeed;

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0xB764C0", Offset = "0xB764C0", VA = "0xB764C0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0xB7651C", Offset = "0xB7651C", VA = "0xB7651C")]
		public Spinner()
		{
		}
	}
	[Token(Token = "0x2000183")]
	public class ToggleAutoMoveFlying : MonoBehaviour
	{
		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0xB76524", Offset = "0xB76524", VA = "0xB76524")]
		public void ToggleFlying()
		{
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0xB765A0", Offset = "0xB765A0", VA = "0xB765A0")]
		public ToggleAutoMoveFlying()
		{
		}
	}
	[Token(Token = "0x2000184")]
	public class ToggleHandProjection : MonoBehaviour
	{
		[Token(Token = "0x6000A70")]
		[Address(RVA = "0xB765A8", Offset = "0xB765A8", VA = "0xB765A8")]
		public void DisableGripProjection()
		{
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0xB7666C", Offset = "0xB7666C", VA = "0xB7666C")]
		public void EnableGripProjection()
		{
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0xB76730", Offset = "0xB76730", VA = "0xB76730")]
		public void DisableHighlightProjection()
		{
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0xB767F4", Offset = "0xB767F4", VA = "0xB767F4")]
		public void EnableHighlightProjection()
		{
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0xB768B8", Offset = "0xB768B8", VA = "0xB768B8")]
		public ToggleHandProjection()
		{
		}
	}
	[Token(Token = "0x2000185")]
	public class TomatoSpawner : MonoBehaviour
	{
		[Token(Token = "0x4000A19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] tomatoes;

		[Token(Token = "0x4000A1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<GameObject> copies;

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0xB768C0", Offset = "0xB768C0", VA = "0xB768C0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0xB76B34", Offset = "0xB76B34", VA = "0xB76B34")]
		public void SpawnTomato()
		{
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0xB76CCC", Offset = "0xB76CCC", VA = "0xB76CCC")]
		public TomatoSpawner()
		{
		}
	}
	[Token(Token = "0x2000186")]
	public class ButtonDemoRespawn : MonoBehaviour
	{
		[Token(Token = "0x4000A1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform root;

		[Token(Token = "0x4000A1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Transform> respawns;

		[Token(Token = "0x4000A1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Vector3> startPos;

		[Token(Token = "0x4000A1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<Quaternion> startRot;

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0xB76CD4", Offset = "0xB76CD4", VA = "0xB76CD4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0xB771B4", Offset = "0xB771B4", VA = "0xB771B4")]
		public void Respawn()
		{
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0xB774E8", Offset = "0xB774E8", VA = "0xB774E8")]
		public void ReloadScene()
		{
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0xB77558", Offset = "0xB77558", VA = "0xB77558")]
		public ButtonDemoRespawn()
		{
		}
	}
	[Token(Token = "0x2000187")]
	public class DialHandScaler : PhysicsGadgetHingeAngleReader
	{
		[Token(Token = "0x4000A1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Hand hand;

		[Token(Token = "0x4000A20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 minScale;

		[Token(Token = "0x4000A21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector3 maxScale;

		[Token(Token = "0x4000A22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float startReach;

		[Token(Token = "0x4000A23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 startScale;

		[Token(Token = "0x4000A24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float[] fingersStartScale;

		[Token(Token = "0x4000A25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 lastHandScale;

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0xB775E0", Offset = "0xB775E0", VA = "0xB775E0")]
		protected new void Start()
		{
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0xB77714", Offset = "0xB77714", VA = "0xB77714")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0xB779D8", Offset = "0xB779D8", VA = "0xB779D8")]
		public DialHandScaler()
		{
		}
	}
	[Token(Token = "0x2000188")]
	public class JoystickObjectMover : PhysicsGadgetJoystick
	{
		[Token(Token = "0x4000A26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform move;

		[Token(Token = "0x4000A27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float speed;

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0xB779E0", Offset = "0xB779E0", VA = "0xB779E0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A80")]
		[Address(RVA = "0xB77A84", Offset = "0xB77A84", VA = "0xB77A84")]
		public JoystickObjectMover()
		{
		}
	}
	[Token(Token = "0x2000189")]
	public class MoverLever : PhysicsGadgetHingeAngleReader
	{
		[Token(Token = "0x4000A28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform move;

		[Token(Token = "0x4000A29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 axis;

		[Token(Token = "0x4000A2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float speed;

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0xB77A94", Offset = "0xB77A94", VA = "0xB77A94")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0xB77C54", Offset = "0xB77C54", VA = "0xB77C54")]
		public MoverLever()
		{
		}
	}
	[Token(Token = "0x200018A")]
	public class PhysicsSliderPositionMover : PhysicsGadgetConfigurableLimitReader
	{
		[Token(Token = "0x4000A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Movement")]
		public Transform move;

		[Token(Token = "0x4000A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Acts as speed")]
		public Vector3 axis;

		[Token(Token = "0x4000A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Header("Range")]
		public bool useRange;

		[Token(Token = "0x4000A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 minRange;

		[Token(Token = "0x4000A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 maxRange;

		[Token(Token = "0x4000A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 startPos;

		[Token(Token = "0x6000A83")]
		[Address(RVA = "0xB77C64", Offset = "0xB77C64", VA = "0xB77C64")]
		protected new void Start()
		{
		}

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0xB77C98", Offset = "0xB77C98", VA = "0xB77C98")]
		public void FixedUpdate()
		{
		}

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0xB77DF0", Offset = "0xB77DF0", VA = "0xB77DF0")]
		public PhysicsSliderPositionMover()
		{
		}
	}
	[Token(Token = "0x200018B")]
	public class WheelRotator : PhysicsGadgetHingeAngleReader
	{
		[Token(Token = "0x4000A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform move;

		[Token(Token = "0x4000A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 angle;

		[Token(Token = "0x4000A33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool useLocal;

		[Token(Token = "0x6000A86")]
		[Address(RVA = "0xB77E80", Offset = "0xB77E80", VA = "0xB77E80")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0xB780AC", Offset = "0xB780AC", VA = "0xB780AC")]
		public WheelRotator()
		{
		}
	}
	[Token(Token = "0x200018C")]
	public class LeverTextChanger : MonoBehaviour
	{
		[Token(Token = "0x4000A34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshPro text;

		[Token(Token = "0x4000A35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PhysicsGadgetHingeAngleReader sliderReader;

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0xB780B4", Offset = "0xB780B4", VA = "0xB780B4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0xB781A0", Offset = "0xB781A0", VA = "0xB781A0")]
		public LeverTextChanger()
		{
		}
	}
	[Token(Token = "0x200018D")]
	public class SliderTextChanger : MonoBehaviour
	{
		[Token(Token = "0x4000A36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshPro text;

		[Token(Token = "0x4000A37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PhysicsGadgetConfigurableLimitReader sliderReader;

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0xB781A8", Offset = "0xB781A8", VA = "0xB781A8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0xB78294", Offset = "0xB78294", VA = "0xB78294")]
		public SliderTextChanger()
		{
		}
	}
	[Token(Token = "0x200018E")]
	public class TextChanger : MonoBehaviour
	{
		[Token(Token = "0x200018F")]
		[CompilerGenerated]
		private sealed class <ChangeText>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TextChanger <>4__this;

			[Token(Token = "0x170000C1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A94")]
				[Address(RVA = "0xB7847C", Offset = "0xB7847C", VA = "0xB7847C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A96")]
				[Address(RVA = "0xB784C4", Offset = "0xB784C4", VA = "0xB784C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A91")]
			[Address(RVA = "0xB78318", Offset = "0xB78318", VA = "0xB78318")]
			[DebuggerHidden]
			public <ChangeText>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000A92")]
			[Address(RVA = "0xB783A4", Offset = "0xB783A4", VA = "0xB783A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A93")]
			[Address(RVA = "0xB783A8", Offset = "0xB783A8", VA = "0xB783A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A95")]
			[Address(RVA = "0xB78484", Offset = "0xB78484", VA = "0xB78484", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000A38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshPro text;

		[Token(Token = "0x4000A39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Coroutine changing;

		[Token(Token = "0x4000A3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Coroutine hide;

		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0xB7829C", Offset = "0xB7829C", VA = "0xB7829C")]
		public void UpdateText(string newText, float upTime)
		{
		}

		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0xB782A0", Offset = "0xB782A0", VA = "0xB782A0")]
		public void UpdateText(string newText)
		{
		}

		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0xB782A4", Offset = "0xB782A4", VA = "0xB782A4")]
		[IteratorStateMachine(typeof(<ChangeText>d__5))]
		private IEnumerator ChangeText(float seconds, string newText)
		{
			return null;
		}

		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0xB78340", Offset = "0xB78340", VA = "0xB78340")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000A90")]
		[Address(RVA = "0xB7839C", Offset = "0xB7839C", VA = "0xB7839C")]
		public TextChanger()
		{
		}
	}
	[Token(Token = "0x2000190")]
	public class TextGrabEvent : MonoBehaviour
	{
		[Token(Token = "0x4000A3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextChanger changer;

		[Token(Token = "0x4000A3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Grabbable grab;

		[Token(Token = "0x4000A40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[TextArea]
		public string message;

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0xB784CC", Offset = "0xB784CC", VA = "0xB784CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0xB786BC", Offset = "0xB786BC", VA = "0xB786BC")]
		private void OnGrab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0xB786C0", Offset = "0xB786C0", VA = "0xB786C0")]
		public TextGrabEvent()
		{
		}
	}
	[Token(Token = "0x2000191")]
	public class TextPlacePointEvent : MonoBehaviour
	{
		[Token(Token = "0x4000A41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextChanger changer;

		[Token(Token = "0x4000A42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlacePoint point;

		[Token(Token = "0x4000A43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x4000A44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[TextArea]
		public string placeMessage;

		[Token(Token = "0x4000A45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[TextArea]
		public string highlightMessage;

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0xB786C8", Offset = "0xB786C8", VA = "0xB786C8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0xB788DC", Offset = "0xB788DC", VA = "0xB788DC")]
		private void OnGrab(PlacePoint hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0xB788F4", Offset = "0xB788F4", VA = "0xB788F4")]
		private void OnHighlight(PlacePoint hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0xB7890C", Offset = "0xB7890C", VA = "0xB7890C")]
		public TextPlacePointEvent()
		{
		}
	}
	[Token(Token = "0x2000192")]
	public class WristLookEvent : MonoBehaviour
	{
		[Token(Token = "0x4000A46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Hand hand;

		[Token(Token = "0x4000A47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Camera head;

		[Token(Token = "0x4000A48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The minimum head->wrist distance required to activate")]
		public float maxDistance;

		[Token(Token = "0x4000A49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("The angle precisness required to activate; 0 is any angle, 1 is exactly pointed at the face")]
		[Range(0f, 1f)]
		public float anglePreciseness;

		[Token(Token = "0x4000A4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool disableWhileHolding;

		[Token(Token = "0x4000A4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Events")]
		public UnityHandEvent OnShow;

		[Token(Token = "0x4000A4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityHandEvent OnHide;

		[Token(Token = "0x4000A4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool showing;

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0xB7891C", Offset = "0xB7891C", VA = "0xB7891C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0xB78C30", Offset = "0xB78C30", VA = "0xB78C30")]
		public WristLookEvent()
		{
		}
	}
	[Token(Token = "0x2000193")]
	[RequireComponent(typeof(Grabbable))]
	public class GrabbableEventDebugger : MonoBehaviour
	{
		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0xB78C48", Offset = "0xB78C48", VA = "0xB78C48")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0xB79378", Offset = "0xB79378", VA = "0xB79378")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0xB79AA8", Offset = "0xB79AA8", VA = "0xB79AA8")]
		public GrabbableEventDebugger()
		{
		}
	}
	[Token(Token = "0x2000195")]
	[RequireComponent(typeof(Hand))]
	public class HandEventDebugger : MonoBehaviour
	{
		[Token(Token = "0x4000A5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool showSqueezeEvents;

		[Token(Token = "0x4000A60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool showHighlightEvents;

		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0xB7A468", Offset = "0xB7A468", VA = "0xB7A468")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0xB7A72C", Offset = "0xB7A72C", VA = "0xB7A72C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0xB7A9F0", Offset = "0xB7A9F0", VA = "0xB7A9F0")]
		public HandEventDebugger()
		{
		}
	}
	[Token(Token = "0x2000196")]
	public class HandTouchEventDebugger : MonoBehaviour
	{
		[Token(Token = "0x4000A61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HandTouchEvent touchEvent;

		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0xB7B440", Offset = "0xB7B440", VA = "0xB7B440")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0xB7B5A4", Offset = "0xB7B5A4", VA = "0xB7B5A4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0xB7B708", Offset = "0xB7B708", VA = "0xB7B708")]
		private void StartTouch(Hand hand)
		{
		}

		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0xB7B7A4", Offset = "0xB7B7A4", VA = "0xB7B7A4")]
		private void StopTouch(Hand hand)
		{
		}

		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0xB7B840", Offset = "0xB7B840", VA = "0xB7B840")]
		public HandTouchEventDebugger()
		{
		}
	}
	[Token(Token = "0x2000197")]
	public class Smash : MonoBehaviour
	{
		[Token(Token = "0x4000A62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Smash Options")]
		[Tooltip("Required velocity magnitude from Smasher to smash")]
		public float smashForce;

		[Token(Token = "0x4000A63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Whether or not to destroy this object on smash")]
		public bool destroyOnSmash;

		[Token(Token = "0x4000A64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		[HideIf("destroyOnSmash")]
		[Tooltip("Whether or not to release this object on smash")]
		public bool releaseOnSmash;

		[Token(Token = "0x4000A65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Plays this effect on smash")]
		[Header("Particle Effect")]
		public ParticleSystem effect;

		[Token(Token = "0x4000A66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Whether or not to instantiates a new a particle system on smash")]
		public bool createNewEffect;

		[Token(Token = "0x4000A67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[Tooltip("Whether or not to apply rigidbody velocity to particle velocity on smash")]
		public bool applyVelocityOnSmash;

		[Token(Token = "0x4000A68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Sound Options")]
		public AudioClip smashSound;

		[Token(Token = "0x4000A69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float smashVolume;

		[Token(Token = "0x4000A6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Event")]
		public UnityEvent OnSmash;

		[Token(Token = "0x4000A6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public SmashEvent OnSmashEvent;

		[Token(Token = "0x4000A6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal Grabbable grabbable;

		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0xB7B848", Offset = "0xB7B848", VA = "0xB7B848")]
		public void Start()
		{
		}

		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0xB7BAF4", Offset = "0xB7BAF4", VA = "0xB7BAF4")]
		public void DelayedSmash(float delay)
		{
		}

		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0xB76234", Offset = "0xB76234", VA = "0xB76234")]
		public void DoSmash()
		{
		}

		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0xB7BB50", Offset = "0xB7BB50", VA = "0xB7BB50")]
		public void DoSmash(Smasher smash)
		{
		}

		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0xB7BEF0", Offset = "0xB7BEF0", VA = "0xB7BEF0")]
		public Smash()
		{
		}
	}
	[Token(Token = "0x2000198")]
	public delegate void SmashEvent(Smasher smasher, Smash smashable);
	[Token(Token = "0x2000199")]
	[RequireComponent(typeof(Rigidbody))]
	public class Smasher : MonoBehaviour
	{
		[Token(Token = "0x4000A6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Rigidbody rb;

		[Token(Token = "0x4000A6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Options")]
		public LayerMask smashableLayers;

		[Token(Token = "0x4000A6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("How much to multiply the magnitude on smash")]
		public float forceMulti;

		[Token(Token = "0x4000A70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Can be left empty - The center of mass point to calculate velocity magnitude - for example: the camera of the hammer is a better point vs the pivot center of the hammer object")]
		public Transform centerOfMassPoint;

		[Token(Token = "0x4000A71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Event")]
		public UnityEvent OnSmash;

		[Token(Token = "0x4000A72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SmashEvent OnSmashEvent;

		[Token(Token = "0x4000A73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3[] velocityOverTime;

		[Token(Token = "0x4000A74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 lastPos;

		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0xB7BF68", Offset = "0xB7BF68", VA = "0xB7BF68")]
		private void Start()
		{
		}

		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0xB7C130", Offset = "0xB7C130", VA = "0xB7C130")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0xB7C29C", Offset = "0xB7C29C", VA = "0xB7C29C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0xB7C354", Offset = "0xB7C354", VA = "0xB7C354")]
		private float GetMagnitude()
		{
			return default(float);
		}

		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0xB7C470", Offset = "0xB7C470", VA = "0xB7C470")]
		public Smasher()
		{
		}
	}
}
