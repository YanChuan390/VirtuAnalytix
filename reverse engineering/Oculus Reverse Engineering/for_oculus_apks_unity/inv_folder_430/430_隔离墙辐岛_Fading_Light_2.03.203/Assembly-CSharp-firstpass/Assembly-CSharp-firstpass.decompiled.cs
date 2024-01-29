using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Autohand;
using Autohand.Demo;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.XR;

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
	[Address(RVA = "0x233D48C", Offset = "0x233D48C", VA = "0x233D48C")]
	public DeviceData(string name, Vector3 pos, Vector3 rot)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x233D570", Offset = "0x233D570", VA = "0x233D570")]
	public DeviceData(string[] names, Vector3 pos, Vector3 rot)
	{
	}
}
[Token(Token = "0x2000003")]
public class XRHandOffset : MonoBehaviour
{
	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD599BC", Offset = "0xD599BC")]
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
	[Address(RVA = "0x225FC40", Offset = "0x225FC40", VA = "0x225FC40")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2260080", Offset = "0x2260080", VA = "0x2260080")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2260124", Offset = "0x2260124", VA = "0x2260124")]
	internal void AdjustPositions(XRHandOffset otherOffset)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x225FE00", Offset = "0x225FE00", VA = "0x225FE00")]
	private void DeviceConnected(InputDevice inputDevice)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2260504", Offset = "0x2260504", VA = "0x2260504")]
	private Vector3 GetPositionOffset(string from, string to)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x22606B8", Offset = "0x22606B8", VA = "0x22606B8")]
	private Vector3 GetRotationOffset(string from, string to)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x22602EC", Offset = "0x22602EC", VA = "0x22602EC")]
	protected Vector3 GetDefaultPositionOffset()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x22603F8", Offset = "0x22603F8", VA = "0x22603F8")]
	protected Vector3 GetDefaultRotationOffset()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x226086C", Offset = "0x226086C", VA = "0x226086C")]
	public XRHandOffset()
	{
	}
}
[Token(Token = "0x2000004")]
public class BowlingManager : MonoBehaviour
{
	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD59A24", Offset = "0xD59A24")]
	public GameObject bowlingBall;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD59A5C", Offset = "0xD59A5C")]
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
	[Address(RVA = "0x233A508", Offset = "0x233A508", VA = "0x233A508")]
	private void Start()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x233A798", Offset = "0x233A798", VA = "0x233A798")]
	public void ResetBall()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x233A550", Offset = "0x233A550", VA = "0x233A550")]
	public void ResetPins()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x233A840", Offset = "0x233A840", VA = "0x233A840")]
	public BowlingManager()
	{
	}
}
[Token(Token = "0x2000005")]
public class DemoExitCondition : MonoBehaviour
{
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x233D374", Offset = "0x233D374", VA = "0x233D374")]
	private void Update()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x233D418", Offset = "0x233D418", VA = "0x233D418")]
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
	[Address(RVA = "0x1CAC8B8", Offset = "0x1CAC8B8", VA = "0x1CAC8B8")]
	public void OpenLinkURL()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1CAC8C4", Offset = "0x1CAC8C4", VA = "0x1CAC8C4")]
	public OpenLink()
	{
	}
}
[Token(Token = "0x2000007")]
public class PlatformMover : MonoBehaviour
{
	[Token(Token = "0x2000008")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD589D0", Offset = "0xD589D0")]
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
			[Address(RVA = "0x226626C", Offset = "0x226626C", VA = "0x226626C", Slot = "4")]
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
			[Address(RVA = "0x22662B4", Offset = "0x22662B4", VA = "0x22662B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2265FD8", Offset = "0x2265FD8", VA = "0x2265FD8")]
		[DebuggerHidden]
		public <Move>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2266004", Offset = "0x2266004", VA = "0x2266004", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2266008", Offset = "0x2266008", VA = "0x2266008", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2266274", Offset = "0x2266274", VA = "0x2266274", Slot = "8")]
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
	[Address(RVA = "0x1CB06C8", Offset = "0x1CB06C8", VA = "0x1CB06C8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1CB0718", Offset = "0x1CB0718", VA = "0x1CB0718")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD5F3A0", Offset = "0xD5F3A0")]
	private IEnumerator Move()
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1CB0784", Offset = "0x1CB0784", VA = "0x1CB0784")]
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
	[Address(RVA = "0x225D518", Offset = "0x225D518", VA = "0x225D518")]
	public void Unlock()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x225D67C", Offset = "0x225D67C", VA = "0x225D67C")]
	public void Lock()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x225D7B4", Offset = "0x225D7B4", VA = "0x225D7B4")]
	public UnlockChest()
	{
	}
}
[Token(Token = "0x200000A")]
public class TMPSizeProtector : MonoBehaviour
{
	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float size;

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x225B940", Offset = "0x225B940", VA = "0x225B940")]
	private void Start()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x225BA0C", Offset = "0x225BA0C", VA = "0x225BA0C")]
	public TMPSizeProtector()
	{
	}
}
[Token(Token = "0x200000B")]
public class TextFieldInspector : MonoBehaviour
{
	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0xD59A94", Offset = "0xD59A94")]
	public string text;

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x225C704", Offset = "0x225C704", VA = "0x225C704")]
	public TextFieldInspector()
	{
	}
}
[Token(Token = "0x200000C")]
public class TextInformation : MonoBehaviour
{
	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject activateImage;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject deactivateImage;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject[] texts;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool active;

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x225C904", Offset = "0x225C904", VA = "0x225C904")]
	public void ActivateText()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x225C9AC", Offset = "0x225C9AC", VA = "0x225C9AC")]
	public void DeactivateText()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x225CA50", Offset = "0x225CA50", VA = "0x225CA50")]
	public void ToggleText()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x225CA60", Offset = "0x225CA60", VA = "0x225CA60")]
	public TextInformation()
	{
	}
}
[Token(Token = "0x200000D")]
public static class JointExtensions
{
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1CABE48", Offset = "0x1CABE48", VA = "0x1CABE48")]
	public static Vector3 Angles(this ConfigurableJoint joint)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1CAC0D0", Offset = "0x1CAC0D0", VA = "0x1CAC0D0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5F460", Offset = "0xD5F460")]
	internal static float <Angles>g__to180|0_0(float v)
	{
		return default(float);
	}
}
[Token(Token = "0x200000E")]
[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0xD589F0", Offset = "0xD589F0")]
public class IgnoreHandLayer : MonoBehaviour
{
	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool includeChildren;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int startLayer;

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1CAAF90", Offset = "0x1CAAF90", VA = "0x1CAAF90")]
	private void Awake()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1CAB008", Offset = "0x1CAB008", VA = "0x1CAB008")]
	private void LateStart()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1CAB06C", Offset = "0x1CAB06C", VA = "0x1CAB06C")]
	internal void SetLayerRecursive(Transform obj, int newLayer)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1CAB10C", Offset = "0x1CAB10C", VA = "0x1CAB10C")]
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
	[Address(RVA = "0x1CAA4F4", Offset = "0x1CAA4F4", VA = "0x1CAA4F4")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1CAA550", Offset = "0x1CAA550", VA = "0x1CAA550")]
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
	[Address(RVA = "0x1CA138C", Offset = "0x1CA138C", VA = "0x1CA138C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1CA183C", Offset = "0x1CA183C", VA = "0x1CA183C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1CA1CDC", Offset = "0x1CA1CDC", VA = "0x1CA1CDC")]
	private void OnBeforeGrabbed(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1CA1CE0", Offset = "0x1CA1CE0", VA = "0x1CA1CE0")]
	private void OnGrabbed(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1CA1CE4", Offset = "0x1CA1CE4", VA = "0x1CA1CE4")]
	private void OnBeforeReleased(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1CA1CE8", Offset = "0x1CA1CE8", VA = "0x1CA1CE8")]
	private void OnReleased(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1CA1CEC", Offset = "0x1CA1CEC", VA = "0x1CA1CEC")]
	private void OnForcedRelease(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1CA1CF0", Offset = "0x1CA1CF0", VA = "0x1CA1CF0")]
	private void OnGrabJointBreak(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1CA1CF4", Offset = "0x1CA1CF4", VA = "0x1CA1CF4")]
	private void OnHighlight(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1CA1CF8", Offset = "0x1CA1CF8", VA = "0x1CA1CF8")]
	private void OnStopHighlight(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1CA1CFC", Offset = "0x1CA1CFC", VA = "0x1CA1CFC")]
	private void OnSqueezed(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1CA1D00", Offset = "0x1CA1D00", VA = "0x1CA1D00")]
	private void OnUnsqueezed(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x1CA1D04", Offset = "0x1CA1D04", VA = "0x1CA1D04")]
	private void OnTriggerGrab(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1CA1D08", Offset = "0x1CA1D08", VA = "0x1CA1D08")]
	private void OnTriggerRelease(Autohand.Hand hand, Grabbable grab)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1CA1D0C", Offset = "0x1CA1D0C", VA = "0x1CA1D0C")]
	private void OnHandCollisionStart(Autohand.Hand hand, GameObject other)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x1CA1D10", Offset = "0x1CA1D10", VA = "0x1CA1D10")]
	private void OnHandCollisionStop(Autohand.Hand hand, GameObject other)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x1CA1D14", Offset = "0x1CA1D14", VA = "0x1CA1D14")]
	private void OnHandTriggerStart(Autohand.Hand hand, GameObject other)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x1CA1D18", Offset = "0x1CA1D18", VA = "0x1CA1D18")]
	private void OnHandTriggerStop(Autohand.Hand hand, GameObject other)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1CA1D1C", Offset = "0x1CA1D1C", VA = "0x1CA1D1C")]
	public HandEventTemplate()
	{
	}
}
[Token(Token = "0x2000011")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xD58A08", Offset = "0xD58A08")]
public class PlacePointEventDebugger : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000012")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58A68", Offset = "0xD58A68")]
	private sealed class <>c
	{
		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static PlacePointEvent <>9__1_0;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static PlacePointEvent <>9__1_1;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static PlacePointEvent <>9__1_2;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static PlacePointEvent <>9__1_3;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static PlacePointEvent <>9__2_0;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static PlacePointEvent <>9__2_1;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static PlacePointEvent <>9__2_2;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static PlacePointEvent <>9__2_3;

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2265C30", Offset = "0x2265C30", VA = "0x2265C30")]
		public <>c()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2265C38", Offset = "0x2265C38", VA = "0x2265C38")]
		internal void <OnEnable>b__1_0(PlacePoint point, Grabbable grabbable)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2265CAC", Offset = "0x2265CAC", VA = "0x2265CAC")]
		internal void <OnEnable>b__1_1(PlacePoint point, Grabbable grabbable)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2265D20", Offset = "0x2265D20", VA = "0x2265D20")]
		internal void <OnEnable>b__1_2(PlacePoint point, Grabbable grabbable)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2265D94", Offset = "0x2265D94", VA = "0x2265D94")]
		internal void <OnEnable>b__1_3(PlacePoint point, Grabbable grabbable)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2265E08", Offset = "0x2265E08", VA = "0x2265E08")]
		internal void <OnDisable>b__2_0(PlacePoint point, Grabbable grabbable)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2265E7C", Offset = "0x2265E7C", VA = "0x2265E7C")]
		internal void <OnDisable>b__2_1(PlacePoint point, Grabbable grabbable)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2265EF0", Offset = "0x2265EF0", VA = "0x2265EF0")]
		internal void <OnDisable>b__2_2(PlacePoint point, Grabbable grabbable)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2265F64", Offset = "0x2265F64", VA = "0x2265F64")]
		internal void <OnDisable>b__2_3(PlacePoint point, Grabbable grabbable)
		{
		}
	}

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private PlacePoint placePoint;

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1CAFC40", Offset = "0x1CAFC40", VA = "0x1CAFC40")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x1CAFFAC", Offset = "0x1CAFFAC", VA = "0x1CAFFAC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1CB0318", Offset = "0x1CB0318", VA = "0x1CB0318")]
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
	[Address(RVA = "0x1CB0320", Offset = "0x1CB0320", VA = "0x1CB0320")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1CB04E8", Offset = "0x1CB04E8", VA = "0x1CB04E8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1CB06B0", Offset = "0x1CB06B0", VA = "0x1CB06B0")]
	public void OnPlace(PlacePoint point, Grabbable grab)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x1CB06B4", Offset = "0x1CB06B4", VA = "0x1CB06B4")]
	public void OnRemove(PlacePoint point, Grabbable grab)
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1CB06B8", Offset = "0x1CB06B8", VA = "0x1CB06B8")]
	public void OnHighlight(PlacePoint point, Grabbable grab)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1CB06BC", Offset = "0x1CB06BC", VA = "0x1CB06BC")]
	public void OnStopHighlight(PlacePoint point, Grabbable grab)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1CB06C0", Offset = "0x1CB06C0", VA = "0x1CB06C0")]
	public PlacePointEventTemplate()
	{
	}
}
[Token(Token = "0x2000014")]
public class AutoHandSettings : ScriptableObject
{
	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD59AA4", Offset = "0xD59AA4")]
	public bool ignoreSetup;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD59ADC", Offset = "0xD59ADC")]
	public float quality;

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x23390A4", Offset = "0x23390A4", VA = "0x23390A4")]
	public static void ClearSettings()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x2339118", Offset = "0x2339118", VA = "0x2339118")]
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
	[Address(RVA = "0x233B660", Offset = "0x233B660", VA = "0x233B660")]
	private void Start()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x233B71C", Offset = "0x233B71C", VA = "0x233B71C")]
	public void EnableCollisions()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x233B664", Offset = "0x233B664", VA = "0x233B664")]
	public void DisableCollisions()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x233B7D4", Offset = "0x233B7D4", VA = "0x233B7D4")]
	public CollisionIgnores()
	{
	}
}
namespace AutoHand
{
	[Token(Token = "0x2000016")]
	public class HandTouchButton : MonoBehaviour
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HideIfAttribute", RVA = "0xD59B14", Offset = "0xD59B14")]
		public bool startPress;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "HideIfAttribute", RVA = "0xD59B4C", Offset = "0xD59B4C")]
		public bool startUnpress;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HandTouchEvent touchEvent;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform button;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 pressOffset;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color unpressColor;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Color pressColor;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool toggle;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD59B84", Offset = "0xD59B84")]
		public UnityHandEvent OnPressed;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public UnityHandEvent OnUnpressed;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool pressed;

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1CA77B8", Offset = "0x1CA77B8", VA = "0x1CA77B8")]
		private void Start()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1CA79B0", Offset = "0x1CA79B0", VA = "0x1CA79B0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1CA7AC4", Offset = "0x1CA7AC4", VA = "0x1CA7AC4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1CA7BD8", Offset = "0x1CA7BD8", VA = "0x1CA7BD8")]
		private void OnTouch(Autohand.Hand hand)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1CA7BF8", Offset = "0x1CA7BF8", VA = "0x1CA7BF8")]
		private void OnUntouch(Autohand.Hand hand)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1CA77DC", Offset = "0x1CA77DC", VA = "0x1CA77DC")]
		private void PressButton(Autohand.Hand hand)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1CA78C8", Offset = "0x1CA78C8", VA = "0x1CA78C8")]
		private void ReleaseButton(Autohand.Hand hand)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1CA7C10", Offset = "0x1CA7C10", VA = "0x1CA7C10")]
		public HandTouchButton()
		{
		}
	}
}
namespace Autohand
{
	[Token(Token = "0x2000017")]
	public class XRMover : MonoBehaviour
	{
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD59B94", Offset = "0xD59B94")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD59B94", Offset = "0xD59B94")]
		public XRHandControllerLink moverController;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public XRHandControllerLink turningController;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Common2DAxis moverAxis;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD59BF4", Offset = "0xD59BF4")]
		public GameObject cam;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CharacterController controller;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CapsuleCollider collisionCapsule;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD59C2C", Offset = "0xD59C2C")]
		public bool snapTurning;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float turnAngle;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float speed;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float gravity;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float currentGravity;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool axisReset;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 moveAxis;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector2 turningAxis;

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2260EA8", Offset = "0x2260EA8", VA = "0x2260EA8")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x22611E0", Offset = "0x22611E0", VA = "0x22611E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2260F08", Offset = "0x2260F08", VA = "0x2260F08")]
		public void Move(float x, float y, float z)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x226100C", Offset = "0x226100C", VA = "0x226100C")]
		private void Turning()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2261280", Offset = "0x2261280", VA = "0x2261280")]
		public XRMover()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class AutoHeaderAttribute : PropertyAttribute
	{
		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int count;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int depth;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string label;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string tooltip;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string toggleBool;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Type type;

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2339128", Offset = "0x2339128", VA = "0x2339128")]
		public AutoHeaderAttribute(string label, int count = 0, int depth = 0)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2339168", Offset = "0x2339168", VA = "0x2339168")]
		public AutoHeaderAttribute(string label, string tooltip, string toggleName, Type classType, int count = 0, int depth = 0)
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class AutoLineAttribute : PropertyAttribute
	{
		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int count;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int depth;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string tooltip;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string toggleBool;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Type type;

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x233A404", Offset = "0x233A404", VA = "0x233A404")]
		public AutoLineAttribute(int count = 0, int depth = 0)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x233A43C", Offset = "0x233A43C", VA = "0x233A43C")]
		public AutoLineAttribute(string tooltip, string toggleName, Type classType, int count = 0, int depth = 0)
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class AutoToggleHeaderAttribute : PropertyAttribute
	{
		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int count;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int depth;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string label;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string tooltip;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string toggleBool;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Type type;

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x233A47C", Offset = "0x233A47C", VA = "0x233A47C")]
		public AutoToggleHeaderAttribute(string label, int count = 0, int depth = 0)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x233A4BC", Offset = "0x233A4BC", VA = "0x233A4BC")]
		public AutoToggleHeaderAttribute(string label, string tooltip, string toggleName, Type classType, int count = 0, int depth = 0)
		{
		}
	}
	[Token(Token = "0x200001B")]
	public static class AutoHandExtensions
	{
		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Transform _transformRuler;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Transform _transformRulerChild;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Transform _transformParent;

		[Token(Token = "0x17000003")]
		public static Transform transformRuler
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x2332044", Offset = "0x2332044", VA = "0x2332044")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		public static Transform transformRulerChild
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x2332474", Offset = "0x2332474", VA = "0x2332474")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		public static Transform transformParent
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x2332300", Offset = "0x2332300", VA = "0x2332300")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2332744", Offset = "0x2332744", VA = "0x2332744")]
		public static void RotateAround(this Transform target, Transform center, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2332950", Offset = "0x2332950", VA = "0x2332950")]
		public static float Round(this float value, int digits)
		{
			return default(float);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2332A00", Offset = "0x2332A00", VA = "0x2332A00")]
		public static bool HasGrabbable(this Hand hand, GameObject obj, out Grabbable grabbable)
		{
			return default(bool);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2332A70", Offset = "0x2332A70", VA = "0x2332A70")]
		public static bool HasGrabbable(this GameObject obj, out Grabbable grabbable)
		{
			return default(bool);
		}

		[Token(Token = "0x6000076")]
		public static T GetCopyOf<T>(this Component comp, T other) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		public static bool CanGetComponent<T>(this Component componentClass, out T component)
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		public static bool CanGetComponent<T>(this GameObject componentClass, out T component)
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2332BA8", Offset = "0x2332BA8", VA = "0x2332BA8")]
		public static LayerMask GetPhysicsLayerMask(int currentLayer)
		{
			return default(LayerMask);
		}
	}
	[Token(Token = "0x200001C")]
	public class PhysicsGadgetButton : PhysicsGadgetConfigurableLimitReader
	{
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool pressed;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xD59C64", Offset = "0xD59C64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD59C64", Offset = "0xD59C64")]
		public float threshold;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool lockOnPressed;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD59CB8", Offset = "0xD59CB8")]
		public UnityEvent OnPressed;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UnityEvent OnUnpressed;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 startPos;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pressedPos;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float pressedValue;

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1CAD2E8", Offset = "0x1CAD2E8", VA = "0x1CAD2E8")]
		protected new void Start()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1CAD428", Offset = "0x1CAD428", VA = "0x1CAD428")]
		protected void FixedUpdate()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1CAD644", Offset = "0x1CAD644", VA = "0x1CAD644")]
		public void Pressed()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1CAD6AC", Offset = "0x1CAD6AC", VA = "0x1CAD6AC")]
		public void Unpressed()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1CAD6C8", Offset = "0x1CAD6C8", VA = "0x1CAD6C8")]
		public void Unlock()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1CAD728", Offset = "0x1CAD728", VA = "0x1CAD728")]
		public PhysicsGadgetButton()
		{
		}
	}
	[Token(Token = "0x200001D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD58A88", Offset = "0xD58A88")]
	public class PhysicsGadgetConfigurableLimitReader : MonoBehaviour
	{
		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool invertValue;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD59CC8", Offset = "0xD59CC8")]
		public float playRange;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ConfigurableJoint joint;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Vector3 axisPos;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float value;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 limitAxis;

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1CAD32C", Offset = "0x1CAD32C", VA = "0x1CAD32C")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1CAD528", Offset = "0x1CAD528", VA = "0x1CAD528")]
		public float GetValue()
		{
			return default(float);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1CAD748", Offset = "0x1CAD748", VA = "0x1CAD748")]
		public PhysicsGadgetConfigurableLimitReader()
		{
		}
	}
	[Token(Token = "0x200001E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD58AE8", Offset = "0xD58AE8")]
	public class PhysicsGadgetHingeAngleReader : MonoBehaviour
	{
		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool invertValue;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD59D00", Offset = "0xD59D00")]
		public float playRange;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HingeJoint joint;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float value;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion startRot;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion deltaParentRotation;

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1CAD75C", Offset = "0x1CAD75C", VA = "0x1CAD75C")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1CAC684", Offset = "0x1CAC684", VA = "0x1CAC684")]
		public float GetValue()
		{
			return default(float);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1CAC8A4", Offset = "0x1CAC8A4", VA = "0x1CAC8A4")]
		public PhysicsGadgetHingeAngleReader()
		{
		}
	}
	[Token(Token = "0x200001F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD58B48", Offset = "0xD58B48")]
	public class PhysicsGadgetJoystick : MonoBehaviour
	{
		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ConfigurableJoint joint;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool invertX;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool invertY;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD59D38", Offset = "0xD59D38")]
		public float playRange;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector2 xRange;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector2 zRange;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector2 value;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 jointRotation;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Rigidbody body;

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1CAD7D4", Offset = "0x1CAD7D4", VA = "0x1CAD7D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1CAD84C", Offset = "0x1CAD84C", VA = "0x1CAD84C")]
		public void FixedUpdate()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1CAC19C", Offset = "0x1CAC19C", VA = "0x1CAC19C")]
		public Vector2 GetValue()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1CAC278", Offset = "0x1CAC278", VA = "0x1CAC278")]
		public PhysicsGadgetJoystick()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class PhysicsGadgetLever : PhysicsGadgetHingeAngleReader
	{
		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xD59D70", Offset = "0xD59D70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD59D70", Offset = "0xD59D70")]
		public float threshold;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityEvent OnMax;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UnityEvent OnMid;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public UnityEvent OnMin;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool min;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool max;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool mid;

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1CAD95C", Offset = "0x1CAD95C", VA = "0x1CAD95C")]
		protected void FixedUpdate()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1CADA8C", Offset = "0x1CADA8C", VA = "0x1CADA8C")]
		private void Max()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1CADAD0", Offset = "0x1CADAD0", VA = "0x1CADAD0")]
		private void Mid()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1CADAAC", Offset = "0x1CADAAC", VA = "0x1CADAAC")]
		private void Min()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1CADAF4", Offset = "0x1CADAF4", VA = "0x1CADAF4")]
		public PhysicsGadgetLever()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class PhysicsGadgetSlider : PhysicsGadgetConfigurableLimitReader
	{
		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD59DC4", Offset = "0xD59DC4")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xD59DC4", Offset = "0xD59DC4")]
		public float threshold;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UnityEvent OnMax;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityEvent OnMid;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UnityEvent OnMin;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool min;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool max;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool mid;

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1CADB14", Offset = "0x1CADB14", VA = "0x1CADB14")]
		protected void FixedUpdate()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1CADC44", Offset = "0x1CADC44", VA = "0x1CADC44")]
		private void Max()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1CADC88", Offset = "0x1CADC88", VA = "0x1CADC88")]
		private void Mid()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1CADC64", Offset = "0x1CADC64", VA = "0x1CADC64")]
		private void Min()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1CADCAC", Offset = "0x1CADCAC", VA = "0x1CADCAC")]
		public PhysicsGadgetSlider()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public enum DistanceGrabType
	{
		[Token(Token = "0x400008D")]
		Velocity,
		[Token(Token = "0x400008E")]
		Linear
	}
	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD58BA8", Offset = "0xD58BA8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD58BA8", Offset = "0xD58BA8")]
	public class DistanceGrabbable : MonoBehaviour
	{
		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "AutoHeaderAttribute", RVA = "0xD59E18", Offset = "0xD59E18")]
		public bool ignoreMe;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD59E58", Offset = "0xD59E58")]
		public bool instantPull;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public DistanceGrabType grabType;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD59E90", Offset = "0xD59E90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD59E90", Offset = "0xD59E90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD59E90", Offset = "0xD59E90")]
		public float archMultiplier;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD59F60", Offset = "0xD59F60")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD59F60", Offset = "0xD59F60")]
		public float gravitationVelocity;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5A010", Offset = "0xD5A010")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5A010", Offset = "0xD5A010")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5A010", Offset = "0xD5A010")]
		public bool rotate;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5A0E4", Offset = "0xD5A0E4")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5A0E4", Offset = "0xD5A0E4")]
		public float rotationSpeed;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "AutoToggleHeaderAttribute", RVA = "0xD5A194", Offset = "0xD5A194")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5A194", Offset = "0xD5A194")]
		public bool ignoreHighlights;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "EnableIfAttribute", RVA = "0xD5A1FC", Offset = "0xD5A1FC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5A1FC", Offset = "0xD5A1FC")]
		public Material targetedMaterial;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "EnableIfAttribute", RVA = "0xD5A25C", Offset = "0xD5A25C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5A25C", Offset = "0xD5A25C")]
		public Material selectedMaterial;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "AutoToggleHeaderAttribute", RVA = "0xD5A2BC", Offset = "0xD5A2BC")]
		public bool showEvents;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5A2FC", Offset = "0xD5A2FC")]
		public UnityHandGrabEvent OnPull;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5A334", Offset = "0xD5A334")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5A334", Offset = "0xD5A334")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD5A334", Offset = "0xD5A334")]
		public UnityHandGrabEvent StartTargeting;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5A3A4", Offset = "0xD5A3A4")]
		public UnityHandGrabEvent StopTargeting;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD5A3DC", Offset = "0xD5A3DC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5A3DC", Offset = "0xD5A3DC")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5A3DC", Offset = "0xD5A3DC")]
		public UnityHandGrabEvent StartSelecting;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5A44C", Offset = "0xD5A44C")]
		public UnityHandGrabEvent StopSelecting;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public HandGrabEvent OnPullCanceled;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal Grabbable grabbable;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform target;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 calculatedNecessaryVelocity;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool gravitationEnabled;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
		private bool gravitationMethodBegun;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9E")]
		private bool pullStarted;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody body;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float timePassedSincePull;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 lastGravitationVelocity;

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x233D8E0", Offset = "0x233D8E0", VA = "0x233D8E0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x233D9D4", Offset = "0x233D9D4", VA = "0x233D9D4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x233DB70", Offset = "0x233DB70", VA = "0x233DB70")]
		private void FollowHandRotation()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x233DC54", Offset = "0x233DC54", VA = "0x233DC54")]
		private void GravitateTowardsHand()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x233DA9C", Offset = "0x233DA9C", VA = "0x233DA9C")]
		private void InitialVelocityPushToHand()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x233DDF8", Offset = "0x233DDF8", VA = "0x233DDF8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x233DD84", Offset = "0x233DD84", VA = "0x233DD84")]
		private Vector3 CalculateTrajectoryVelocity(Vector3 origin, Vector3 target, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x233DE28", Offset = "0x233DE28", VA = "0x233DE28")]
		public void SetTarget(Transform theObject)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x233DE1C", Offset = "0x233DE1C", VA = "0x233DE1C")]
		public void CancelTarget()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x233DE38", Offset = "0x233DE38", VA = "0x233DE38")]
		public DistanceGrabbable()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x233DE68", Offset = "0x233DE68", VA = "0x233DE68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5F4E0", Offset = "0xD5F4E0")]
		private void <Start>b__25_0(Hand hand, Grabbable grab)
		{
		}
	}
	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD58C2C", Offset = "0xD58C2C")]
	public class GrabLock : MonoBehaviour
	{
		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5A484", Offset = "0xD5A484")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5A484", Offset = "0xD5A484")]
		public UnityEvent OnGrabPressed;

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2340134", Offset = "0x2340134", VA = "0x2340134")]
		public GrabLock()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public enum HandGrabType
	{
		[Token(Token = "0x40000AB")]
		Default,
		[Token(Token = "0x40000AC")]
		HandToGrabbable,
		[Token(Token = "0x40000AD")]
		GrabbableToHand
	}
	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD58C8C", Offset = "0xD58C8C")]
	[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0xD58C8C", Offset = "0xD58C8C")]
	public class Grabbable : GrabbableBase
	{
		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5A4E4", Offset = "0xD5A4E4")]
		public bool KeepCatching;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "OnValueChangedAttribute", RVA = "0xD5A51C", Offset = "0xD5A51C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5A51C", Offset = "0xD5A51C")]
		public Grabbable CopySettings;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5A57C", Offset = "0xD5A57C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5A57C", Offset = "0xD5A57C")]
		public bool singleHandOnly;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5A5DC", Offset = "0xD5A5DC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5A5DC", Offset = "0xD5A5DC")]
		public bool allowHeldSwapping;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE2")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5A63C", Offset = "0xD5A63C")]
		public bool instantGrab;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE3")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5A674", Offset = "0xD5A674")]
		public bool ignoreWeight;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5A6AC", Offset = "0xD5A6AC")]
		public bool maintainGrabOffset;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE5")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5A6E4", Offset = "0xD5A6E4")]
		public bool parentOnGrab;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5A71C", Offset = "0xD5A71C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5A71C", Offset = "0xD5A71C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xD5A71C", Offset = "0xD5A71C")]
		public float throwPower;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5A7A0", Offset = "0xD5A7A0")]
		public float jointBreakForce;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "AutoToggleHeaderAttribute", RVA = "0xD5A7D8", Offset = "0xD5A7D8")]
		public bool showAdvancedSettings;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5A818", Offset = "0xD5A818")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5A818", Offset = "0xD5A818")]
		public HandType handType;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5A878", Offset = "0xD5A878")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5A878", Offset = "0xD5A878")]
		public HandGrabType grabType;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5A8D8", Offset = "0xD5A8D8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5A8D8", Offset = "0xD5A8D8")]
		public bool useGentleGrab;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFD")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5A938", Offset = "0xD5A938")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5A938", Offset = "0xD5A938")]
		public bool makeChildrenGrabbable;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFE")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5A998", Offset = "0xD5A998")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5A998", Offset = "0xD5A998")]
		public bool pullApartBreakOnly;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5A9F8", Offset = "0xD5A9F8")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD5A9F8", Offset = "0xD5A9F8")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5A9F8", Offset = "0xD5A9F8")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xD5A9F8", Offset = "0xD5A9F8")]
		public ConfigurableJoint customGrabJoint;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5AA7C", Offset = "0xD5AA7C")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xD5AA7C", Offset = "0xD5AA7C")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5AA7C", Offset = "0xD5AA7C")]
		public float ignoreReleaseTime;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xD5AAF0", Offset = "0xD5AAF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5AAF0", Offset = "0xD5AAF0")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5AAF0", Offset = "0xD5AAF0")]
		public float grabPriorityWeight;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5AB64", Offset = "0xD5AB64")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5AB64", Offset = "0xD5AB64")]
		public Vector3 heldPositionOffset;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5ABC4", Offset = "0xD5ABC4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5ABC4", Offset = "0xD5ABC4")]
		public Vector3 heldRotationOffset;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5AC24", Offset = "0xD5AC24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5AC24", Offset = "0xD5AC24")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD5AC24", Offset = "0xD5AC24")]
		public List<Rigidbody> jointedBodies;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5AC94", Offset = "0xD5AC94")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5AC94", Offset = "0xD5AC94")]
		public List<Collider> heldIgnoreColliders;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[AttributeAttribute(Name = "AutoToggleHeaderAttribute", RVA = "0xD5ACF4", Offset = "0xD5ACF4")]
		public bool showEvents;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5AD34", Offset = "0xD5AD34")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD5AD34", Offset = "0xD5AD34")]
		public UnityHandGrabEvent onGrab;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5AD80", Offset = "0xD5AD80")]
		public UnityHandGrabEvent onRelease;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[AttributeAttribute(Name = "AutoToggleHeaderAttribute", RVA = "0xD5ADB8", Offset = "0xD5ADB8")]
		public bool showAdvancedEvents;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5ADF8", Offset = "0xD5ADF8")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD5ADF8", Offset = "0xD5ADF8")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD5ADF8", Offset = "0xD5ADF8")]
		public UnityHandGrabEvent onSqueeze;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5AE54", Offset = "0xD5AE54")]
		public UnityHandGrabEvent onUnsqueeze;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD5AE8C", Offset = "0xD5AE8C")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5AE8C", Offset = "0xD5AE8C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD5AE8C", Offset = "0xD5AE8C")]
		public UnityHandGrabEvent onHighlight;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5AEE8", Offset = "0xD5AEE8")]
		public UnityHandGrabEvent onUnhighlight;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD5AF20", Offset = "0xD5AF20")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5AF20", Offset = "0xD5AF20")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD5AF20", Offset = "0xD5AF20")]
		public UnityHandGrabEvent OnJointBreak;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[HideInInspector]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5AF7C", Offset = "0xD5AF7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5AF7C", Offset = "0xD5AF7C")]
		public bool lockHandOnGrab;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public HandGrabEvent OnBeforeGrabEvent;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public HandGrabEvent OnGrabEvent;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public HandGrabEvent OnReleaseEvent;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public HandGrabEvent OnJointBreakEvent;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public HandGrabEvent OnSqueezeEvent;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public HandGrabEvent OnUnsqueezeEvent;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public HandGrabEvent OnHighlightEvent;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public HandGrabEvent OnUnhighlightEvent;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5AFEC", Offset = "0xD5AFEC")]
		private bool <wasForceReleased>k__BackingField;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5AFFC", Offset = "0xD5AFFC")]
		private Hand <lastHeldBy>k__BackingField;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private List<Grabbable> jointedGrabbables;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private float lastUpdateTime;

		[Token(Token = "0x17000006")]
		public float throwMultiplyer
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x234013C", Offset = "0x234013C", VA = "0x234013C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x2340144", Offset = "0x2340144", VA = "0x2340144")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public bool wasForceReleased
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x234014C", Offset = "0x234014C", VA = "0x234014C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5F4F0", Offset = "0xD5F4F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x2340154", Offset = "0x2340154", VA = "0x2340154")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5F500", Offset = "0xD5F500")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public Hand lastHeldBy
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x2340160", Offset = "0x2340160", VA = "0x2340160")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5F510", Offset = "0xD5F510")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x2340168", Offset = "0x2340168", VA = "0x2340168")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5F520", Offset = "0xD5F520")]
			protected set
			{
			}
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2340170", Offset = "0x2340170", VA = "0x2340170", Slot = "8")]
		protected new virtual void Awake()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2340708", Offset = "0x2340708", VA = "0x2340708", Slot = "9")]
		protected new virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2340828", Offset = "0x2340828", VA = "0x2340828", Slot = "10")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x23410AC", Offset = "0x23410AC", VA = "0x23410AC", Slot = "11")]
		public virtual void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x23411BC", Offset = "0x23411BC", VA = "0x23411BC", Slot = "12")]
		public virtual void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2333AC8", Offset = "0x2333AC8", VA = "0x2333AC8")]
		internal void IgnoreColliders(Collider bodyCapsule, bool ignore = true)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2341334", Offset = "0x2341334", VA = "0x2341334", Slot = "13")]
		internal virtual void Highlight(Hand hand, [Optional] Material customMat)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2341728", Offset = "0x2341728", VA = "0x2341728", Slot = "14")]
		internal virtual void Unhighlight(Hand hand)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x234182C", Offset = "0x234182C", VA = "0x234182C", Slot = "15")]
		internal virtual void OnSqueeze(Hand hand)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x23418B8", Offset = "0x23418B8", VA = "0x23418B8", Slot = "16")]
		internal virtual void OnUnsqueeze(Hand hand)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2341944", Offset = "0x2341944", VA = "0x2341944", Slot = "17")]
		internal virtual void OnBeforeGrab(Hand hand)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2341A68", Offset = "0x2341A68", VA = "0x2341A68", Slot = "18")]
		internal virtual void OnGrab(Hand hand)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x2341F34", Offset = "0x2341F34", VA = "0x2341F34", Slot = "19")]
		public virtual bool CanGrab(HandBase hand)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2341FB0", Offset = "0x2341FB0", VA = "0x2341FB0", Slot = "20")]
		internal virtual void OnRelease(Hand hand)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x234220C", Offset = "0x234220C", VA = "0x234220C", Slot = "21")]
		internal virtual void BreakHandConnection(Hand hand)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x234260C", Offset = "0x234260C", VA = "0x234260C", Slot = "22")]
		public virtual void HandsRelease()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x23426C0", Offset = "0x23426C0", VA = "0x23426C0", Slot = "23")]
		public virtual void HandRelease(Hand hand)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2342750", Offset = "0x2342750", VA = "0x2342750", Slot = "24")]
		public virtual void ForceHandsRelease()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x234281C", Offset = "0x234281C", VA = "0x234281C", Slot = "25")]
		public virtual void ForceHandRelease(Hand hand)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x23428D4", Offset = "0x23428D4", VA = "0x23428D4", Slot = "26")]
		public virtual void OnHandJointBreak(Hand hand)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2342B58", Offset = "0x2342B58", VA = "0x2342B58")]
		public Vector3 GetVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2342BA4", Offset = "0x2342BA4", VA = "0x2342BA4")]
		public Vector3 GetAngularVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x2342CAC", Offset = "0x2342CAC", VA = "0x2342CAC")]
		public List<Hand> GetHeldBy()
		{
			return null;
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2340FE0", Offset = "0x2340FE0", VA = "0x2340FE0")]
		public int HeldCount(bool includedJointedCount = true)
		{
			return default(int);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2342CB4", Offset = "0x2342CB4", VA = "0x2342CB4")]
		public bool IsHeld()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2342D08", Offset = "0x2342D08", VA = "0x2342D08")]
		public bool BeingGrabbed()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x2342D10", Offset = "0x2342D10", VA = "0x2342D10")]
		public void PlayHapticVibration()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x2342E28", Offset = "0x2342E28", VA = "0x2342E28")]
		public void PlayHapticVibration(float duration = 0.025f)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2342F50", Offset = "0x2342F50", VA = "0x2342F50")]
		public void PlayHapticVibration(float duration, float amp = 0.5f)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2343080", Offset = "0x2343080", VA = "0x2343080", Slot = "27")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x23431EC", Offset = "0x23431EC", VA = "0x23431EC")]
		public void SetParentOnGrab(bool parentOnGrab)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x23431F8", Offset = "0x23431F8", VA = "0x23431F8")]
		public void AddJointedBody(Rigidbody body)
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2343454", Offset = "0x2343454", VA = "0x2343454")]
		public void RemoveJointedBody(Rigidbody body)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x234366C", Offset = "0x234366C", VA = "0x234366C")]
		public void DoDestroy()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x2340F88", Offset = "0x2340F88", VA = "0x2340F88")]
		public int CollisionCount()
		{
			return default(int);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x23436E4", Offset = "0x23436E4", VA = "0x23436E4")]
		public int JointedCollisionCount()
		{
			return default(int);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x2340344", Offset = "0x2340344", VA = "0x2340344")]
		private void MakeChildrenGrabbable()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x2343170", Offset = "0x2343170", VA = "0x2343170")]
		private void MakeChildrenUngrabbable()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x2342414", Offset = "0x2342414", VA = "0x2342414")]
		internal void ResetGrabbableAfterRlease()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2343BCC", Offset = "0x2343BCC", VA = "0x2343BCC")]
		public Grabbable()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2343790", Offset = "0x2343790", VA = "0x2343790")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5F530", Offset = "0xD5F530")]
		private void <MakeChildrenGrabbable>g__AddChildGrabbableRecursive|90_0(Transform obj)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x23439F0", Offset = "0x23439F0", VA = "0x23439F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5F540", Offset = "0xD5F540")]
		private void <MakeChildrenUngrabbable>g__RemoveChildGrabbableRecursive|91_0(Transform obj)
		{
		}
	}
	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0xD58CDC", Offset = "0xD58CDC")]
	public class GrabbableChild : MonoBehaviour
	{
		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Grabbable grabParent;

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x234483C", Offset = "0x234483C", VA = "0x234483C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x234497C", Offset = "0x234497C", VA = "0x234497C")]
		public GrabbableChild()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD58CF0", Offset = "0xD58CF0")]
	public class GrabbableCollisionHaptics : MonoBehaviour
	{
		[Token(Token = "0x2000029")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58D50", Offset = "0xD58D50")]
		private sealed class <PlayBuffer>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GrabbableCollisionHaptics <>4__this;

			[Token(Token = "0x17000009")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000DC")]
				[Address(RVA = "0x2261B58", Offset = "0x2261B58", VA = "0x2261B58", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000DE")]
				[Address(RVA = "0x2261BA0", Offset = "0x2261BA0", VA = "0x2261BA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x2261A64", Offset = "0x2261A64", VA = "0x2261A64")]
			[DebuggerHidden]
			public <PlayBuffer>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x2261A90", Offset = "0x2261A90", VA = "0x2261A90", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x2261A94", Offset = "0x2261A94", VA = "0x2261A94", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x2261B60", Offset = "0x2261B60", VA = "0x2261B60", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200002A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58D60", Offset = "0xD58D60")]
		private sealed class <HapticPlayBuffer>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GrabbableCollisionHaptics <>4__this;

			[Token(Token = "0x40000ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float time;

			[Token(Token = "0x1700000B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000E2")]
				[Address(RVA = "0x2261A14", Offset = "0x2261A14", VA = "0x2261A14", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000E4")]
				[Address(RVA = "0x2261A5C", Offset = "0x2261A5C", VA = "0x2261A5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x2261920", Offset = "0x2261920", VA = "0x2261920")]
			[DebuggerHidden]
			public <HapticPlayBuffer>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x226194C", Offset = "0x226194C", VA = "0x226194C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x2261950", Offset = "0x2261950", VA = "0x2261950", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x2261A1C", Offset = "0x2261A1C", VA = "0x2261A1C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B00C", Offset = "0xD5B00C")]
		public LayerMask collisionTriggers;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float hapticAmp;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float velocityAmp;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float repeatDelay;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float maxDuration;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B044", Offset = "0xD5B044")]
		public AnimationCurve velocityAmpCurve;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B07C", Offset = "0xD5B07C")]
		public AnimationCurve velocityDurationCurve;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Grabbable grab;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Rigidbody body;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool canPlay;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine playRoutine;

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x2344984", Offset = "0x2344984", VA = "0x2344984")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x2344A90", Offset = "0x2344A90", VA = "0x2344A90")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x2344AA4", Offset = "0x2344AA4", VA = "0x2344AA4")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x2344CC8", Offset = "0x2344CC8", VA = "0x2344CC8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD5F550", Offset = "0xD5F550")]
		private IEnumerator PlayBuffer()
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x2344A14", Offset = "0x2344A14", VA = "0x2344A14")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD5F5B0", Offset = "0xD5F5B0")]
		private IEnumerator HapticPlayBuffer(float time)
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x2344D34", Offset = "0x2344D34", VA = "0x2344D34")]
		public GrabbableCollisionHaptics()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD58D70", Offset = "0xD58D70")]
	public class GrabbableExtraEvents : MonoBehaviour
	{
		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityHandGrabEvent OnFirstGrab;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityHandGrabEvent OnLastRelease;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityHandGrabEvent OnTwoHandedGrab;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityHandGrabEvent OnTwoHandedRelease;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Grabbable grab;

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x23CE1F8", Offset = "0x23CE1F8", VA = "0x23CE1F8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x23CE340", Offset = "0x23CE340", VA = "0x23CE340")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x23CE490", Offset = "0x23CE490", VA = "0x23CE490")]
		public void Grab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x23CE560", Offset = "0x23CE560", VA = "0x23CE560")]
		public void Release(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x23CE62C", Offset = "0x23CE62C", VA = "0x23CE62C")]
		public GrabbableExtraEvents()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD58DD0", Offset = "0xD58DD0")]
	public class GrabbableOnlyJoint : MonoBehaviour
	{
		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Grabbable jointedGrabbable;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool resetOnRelease;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Grabbable localGrabbable;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Joint freezeJoint;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 localStartPosition;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion localStartRotation;

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x23CE634", Offset = "0x23CE634", VA = "0x23CE634")]
		private void Start()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x23CE978", Offset = "0x23CE978", VA = "0x23CE978")]
		private void OnGrab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x23CEA1C", Offset = "0x23CEA1C", VA = "0x23CEA1C")]
		private void OnRelease(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x23CEBD0", Offset = "0x23CEBD0", VA = "0x23CEBD0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x23CECE8", Offset = "0x23CECE8", VA = "0x23CECE8")]
		private void CreateJoint()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x23CEE58", Offset = "0x23CEE58", VA = "0x23CEE58")]
		public GrabbableOnlyJoint()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD58E30", Offset = "0xD58E30")]
	public class GrabbablePose : MonoBehaviour
	{
		[StructLayout(3)]
		[Token(Token = "0x200002E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58E68", Offset = "0xD58E68")]
		private struct <>c__DisplayClass22_0
		{
			[Token(Token = "0x400010A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public List<Vector3> posePositionsList;

			[Token(Token = "0x400010B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public List<Quaternion> poseRotationsList;
		}

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "AutoHeaderAttribute", RVA = "0xD5B0B4", Offset = "0xD5B0B4")]
		public bool ignoreMe;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool poseEnabled;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B0F4", Offset = "0xD5B0F4")]
		public string poseName;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B12C", Offset = "0xD5B12C")]
		public int poseIndex;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B164", Offset = "0xD5B164")]
		public bool singleHanded;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "AutoToggleHeaderAttribute", RVA = "0xD5B19C", Offset = "0xD5B19C")]
		public bool showAdvanced;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float positionWeight;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rotationWeight;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B1DC", Offset = "0xD5B1DC")]
		public GrabbablePose[] linkedPoses;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public bool showEditorTools;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B224", Offset = "0xD5B224")]
		public HandPoseScriptable poseScriptable;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B270", Offset = "0xD5B270")]
		public Hand editorHand;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public HandPoseData rightPose;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[HideInInspector]
		public bool rightPoseSet;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public HandPoseData leftPose;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[HideInInspector]
		public bool leftPoseSet;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private List<Hand> posingHands;

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x23CEE68", Offset = "0x23CEE68", VA = "0x23CEE68", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x23CEEC4", Offset = "0x23CEEC4", VA = "0x23CEEC4")]
		public bool CanSetPose(Hand hand)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x23CEF90", Offset = "0x23CEF90", VA = "0x23CEF90", Slot = "5")]
		public virtual HandPoseData GetHandPoseData(Hand hand)
		{
			return default(HandPoseData);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x23CF088", Offset = "0x23CF088", VA = "0x23CF088", Slot = "6")]
		public virtual void SetHandPose(Hand hand, bool isProjection = false)
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x23CF1DC", Offset = "0x23CF1DC", VA = "0x23CF1DC", Slot = "7")]
		public virtual void CancelHandPose(Hand hand)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x23CF2B8", Offset = "0x23CF2B8", VA = "0x23CF2B8")]
		public HandPoseData GetNewPoseData(Hand hand)
		{
			return default(HandPoseData);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x23CF774", Offset = "0x23CF774", VA = "0x23CF774")]
		public bool HasPose(bool left)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x23CF82C", Offset = "0x23CF82C", VA = "0x23CF82C")]
		public GrabbablePose()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x23CF698", Offset = "0x23CF698", VA = "0x23CF698")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5F6B0", Offset = "0xD5F6B0")]
		internal static void <GetNewPoseData>g__AssignChildrenPose|22_0(Transform obj, ref <>c__DisplayClass22_0 P_1)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x23CF8D8", Offset = "0x23CF8D8", VA = "0x23CF8D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5F6C0", Offset = "0xD5F6C0")]
		internal static void <GetNewPoseData>g__AddPoint|22_1(Vector3 pos, Quaternion rot, ref <>c__DisplayClass22_0 P_2)
		{
		}
	}
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD58E78", Offset = "0xD58E78")]
	public class GrabbablePoseAdvanced : GrabbablePose
	{
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B2FC", Offset = "0xD5B2FC")]
		public Transform centerObject;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD5B334", Offset = "0xD5B334")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B334", Offset = "0xD5B334")]
		public Vector3 up;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD5B380", Offset = "0xD5B380")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B380", Offset = "0xD5B380")]
		public bool useInvertPose;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD5B3CC", Offset = "0xD5B3CC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B3CC", Offset = "0xD5B3CC")]
		public int minAngle;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B418", Offset = "0xD5B418")]
		public int maxAngle;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD5B450", Offset = "0xD5B450")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B450", Offset = "0xD5B450")]
		public float maxRange;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B49C", Offset = "0xD5B49C")]
		public float minRange;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B4D4", Offset = "0xD5B4D4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5B4D4", Offset = "0xD5B4D4")]
		public int testAngle;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B534", Offset = "0xD5B534")]
		public float testRange;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int lastAngle;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private float lastRange;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 pregrabPos;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Quaternion pregrabRot;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Transform tempContainer;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Transform handMatch;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Transform getTransform;

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x23CF9A8", Offset = "0x23CF9A8", VA = "0x23CF9A8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x23CF9F0", Offset = "0x23CF9F0", VA = "0x23CF9F0", Slot = "5")]
		public override HandPoseData GetHandPoseData(Hand hand)
		{
			return default(HandPoseData);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x23CFDB8", Offset = "0x23CFDB8", VA = "0x23CFDB8")]
		public Quaternion GetClosestRotation(Hand hand, Vector3 up, bool addInverse)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x23D0804", Offset = "0x23D0804", VA = "0x23D0804")]
		public Vector3 GetClosestPosition(Vector3 up)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x23D0AFC", Offset = "0x23D0AFC", VA = "0x23D0AFC")]
		public HandPoseData GetHandPoseData(Hand hand, int angle, float range)
		{
			return default(HandPoseData);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x23CFD2C", Offset = "0x23CFD2C", VA = "0x23CFD2C")]
		private Transform GetTransform()
		{
			return null;
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x23D0E4C", Offset = "0x23D0E4C", VA = "0x23D0E4C")]
		public GrabbablePoseAdvanced()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class GrabbablePoseCombiner : MonoBehaviour
	{
		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<GrabbablePose> poses;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HandPoseData pose;

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x23D0E84", Offset = "0x23D0E84", VA = "0x23D0E84")]
		public bool CanSetPose(Hand hand)
		{
			return default(bool);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x23D1018", Offset = "0x23D1018", VA = "0x23D1018")]
		public void AddPose(GrabbablePose pose)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x23D10B8", Offset = "0x23D10B8", VA = "0x23D10B8")]
		public GrabbablePose GetClosestPose(Hand hand)
		{
			return null;
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x23D16C8", Offset = "0x23D16C8", VA = "0x23D16C8")]
		internal int PoseCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x23D1714", Offset = "0x23D1714", VA = "0x23D1714")]
		public GrabbablePoseCombiner()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD58EB0", Offset = "0xD58EB0")]
	public class GrabbableSubstitute : MonoBehaviour
	{
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B56C", Offset = "0xD5B56C")]
		public bool disableOnGrab;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B5A4", Offset = "0xD5B5A4")]
		public bool returnOnRelease;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Grabbable grabbableSubstitute;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Grabbable localGrabbable;

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x23D178C", Offset = "0x23D178C", VA = "0x23D178C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x23D18D4", Offset = "0x23D18D4", VA = "0x23D18D4")]
		private void OnGrabOriginal(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x23D1A78", Offset = "0x23D1A78", VA = "0x23D1A78")]
		private void OnReleaseSub(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x23D1BF0", Offset = "0x23D1BF0", VA = "0x23D1BF0")]
		public void LocalSubstitute(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x23D1D70", Offset = "0x23D1D70", VA = "0x23D1D70")]
		public GrabbableSubstitute()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD58F10", Offset = "0xD58F10")]
	public class GrabbableThrowEvent : MonoBehaviour
	{
		[Token(Token = "0x2000033")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD58F98", Offset = "0xD58F98")]
		private sealed class <ResetThrown>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400012A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400012B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400012C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GrabbableThrowEvent <>4__this;

			[Token(Token = "0x1700000D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000116")]
				[Address(RVA = "0x22626FC", Offset = "0x22626FC", VA = "0x22626FC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000118")]
				[Address(RVA = "0x2262744", Offset = "0x2262744", VA = "0x2262744", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000113")]
			[Address(RVA = "0x2262610", Offset = "0x2262610", VA = "0x2262610")]
			[DebuggerHidden]
			public <ResetThrown>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x6000114")]
			[Address(RVA = "0x226263C", Offset = "0x226263C", VA = "0x226263C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000115")]
			[Address(RVA = "0x2262640", Offset = "0x2262640", VA = "0x2262640", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000117")]
			[Address(RVA = "0x2262704", Offset = "0x2262704", VA = "0x2262704", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B5DC", Offset = "0xD5B5DC")]
		public float breakVelocity;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B614", Offset = "0xD5B614")]
		public LayerMask collisionLayers;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEvent OnBreak;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody rb;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Grabbable grab;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool thrown;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine resetThrowing;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float throwTime;

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x23D1D80", Offset = "0x23D1D80", VA = "0x23D1D80")]
		private void Awake()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x23D1DF8", Offset = "0x23D1DF8", VA = "0x23D1DF8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x23D1EB8", Offset = "0x23D1EB8", VA = "0x23D1EB8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x23D1F78", Offset = "0x23D1F78", VA = "0x23D1F78")]
		private void OnReleased(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x23D2010", Offset = "0x23D2010", VA = "0x23D2010")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD5F6D0", Offset = "0xD5F6D0")]
		private IEnumerator ResetThrown()
		{
			return null;
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x23D207C", Offset = "0x23D207C", VA = "0x23D207C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x23D21C0", Offset = "0x23D21C0", VA = "0x23D21C0")]
		private void Break()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x23D21DC", Offset = "0x23D21DC", VA = "0x23D21DC")]
		public GrabbableThrowEvent()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public delegate void PlacePointEvent(PlacePoint point, Grabbable grabbable);
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD58FA8", Offset = "0xD58FA8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD58FA8", Offset = "0xD58FA8")]
	public class PlacePoint : MonoBehaviour
	{
		[Token(Token = "0x2000036")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5902C", Offset = "0xD5902C")]
		private sealed class <HighlightSafetyCheck>d__47 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000152")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000153")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000154")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlacePoint <>4__this;

			[Token(Token = "0x17000012")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000137")]
				[Address(RVA = "0x2265B80", Offset = "0x2265B80", VA = "0x2265B80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000013")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000139")]
				[Address(RVA = "0x2265BC8", Offset = "0x2265BC8", VA = "0x2265BC8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000134")]
			[Address(RVA = "0x2265A1C", Offset = "0x2265A1C", VA = "0x2265A1C")]
			[DebuggerHidden]
			public <HighlightSafetyCheck>d__47(int <>1__state)
			{
			}

			[Token(Token = "0x6000135")]
			[Address(RVA = "0x2265A48", Offset = "0x2265A48", VA = "0x2265A48", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000136")]
			[Address(RVA = "0x2265A4C", Offset = "0x2265A4C", VA = "0x2265A4C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000138")]
			[Address(RVA = "0x2265B88", Offset = "0x2265B88", VA = "0x2265B88", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "AutoHeaderAttribute", RVA = "0xD5B64C", Offset = "0xD5B64C")]
		public bool ignoreMe;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B68C", Offset = "0xD5B68C")]
		public Grabbable matchTarget;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B6C4", Offset = "0xD5B6C4")]
		public string[] placeNames;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B6FC", Offset = "0xD5B6FC")]
		public float placeRadius;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B734", Offset = "0xD5B734")]
		public bool forcePlace;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B76C", Offset = "0xD5B76C")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5B76C", Offset = "0xD5B76C")]
		public bool forceHandRelease;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B7CC", Offset = "0xD5B7CC")]
		public bool disableGrabOnPlace;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B804", Offset = "0xD5B804")]
		public bool disableObjectOnPlace;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B83C", Offset = "0xD5B83C")]
		public bool destroyObjectOnPlace;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[AttributeAttribute(Name = "AutoToggleHeaderAttribute", RVA = "0xD5B874", Offset = "0xD5B874")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B874", Offset = "0xD5B874")]
		public bool makePlacedKinematic;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HideIfAttribute", RVA = "0xD5B8DC", Offset = "0xD5B8DC")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD5B8DC", Offset = "0xD5B8DC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B8DC", Offset = "0xD5B8DC")]
		public Rigidbody placedJointLink;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "HideIfAttribute", RVA = "0xD5B94C", Offset = "0xD5B94C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xD5B94C", Offset = "0xD5B94C")]
		public float jointBreakForce;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "AutoToggleHeaderAttribute", RVA = "0xD5B9AC", Offset = "0xD5B9AC")]
		public bool showAdvanced;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5B9EC", Offset = "0xD5B9EC")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5B9EC", Offset = "0xD5B9EC")]
		public Grabbable startPlaced;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5BA4C", Offset = "0xD5BA4C")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5BA4C", Offset = "0xD5BA4C")]
		public Transform placedOffset;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5BAAC", Offset = "0xD5BAAC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5BAAC", Offset = "0xD5BAAC")]
		public bool parentOnPlace;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5BB0C", Offset = "0xD5BB0C")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5BB0C", Offset = "0xD5BB0C")]
		public bool heldPlaceOnly;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5BB6C", Offset = "0xD5BB6C")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5BB6C", Offset = "0xD5BB6C")]
		public string[] blacklistNames;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "AutoToggleHeaderAttribute", RVA = "0xD5BBCC", Offset = "0xD5BBCC")]
		public bool showEvents;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5BC0C", Offset = "0xD5BC0C")]
		public UnityEvent OnPlace;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5BC44", Offset = "0xD5BC44")]
		public UnityEvent OnRemove;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5BC7C", Offset = "0xD5BC7C")]
		public UnityEvent OnHighlight;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5BCB4", Offset = "0xD5BCB4")]
		public UnityEvent OnStopHighlight;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public PlacePointEvent OnPlaceEvent;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public PlacePointEvent OnRemoveEvent;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public PlacePointEvent OnHighlightEvent;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public PlacePointEvent OnStopHighlightEvent;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5BCEC", Offset = "0xD5BCEC")]
		private Grabbable <highlightingObj>k__BackingField;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5BCFC", Offset = "0xD5BCFC")]
		private Grabbable <placedObject>k__BackingField;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5BD0C", Offset = "0xD5BD0C")]
		private Grabbable <lastPlacedObject>k__BackingField;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		protected FixedJoint joint;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected float removalDistance;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		protected Vector3 placePosition;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		protected SphereCollider col;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected Transform originParent;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected bool placingFrame;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		protected CollisionDetectionMode placedObjDetectionMode;

		[Token(Token = "0x1700000F")]
		public Grabbable highlightingObj
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x1CAE3F8", Offset = "0x1CAE3F8", VA = "0x1CAE3F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5F780", Offset = "0xD5F780")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x1CAE400", Offset = "0x1CAE400", VA = "0x1CAE400")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5F790", Offset = "0xD5F790")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public Grabbable placedObject
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x1CAE408", Offset = "0x1CAE408", VA = "0x1CAE408")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5F7A0", Offset = "0xD5F7A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x1CAE410", Offset = "0x1CAE410", VA = "0x1CAE410")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5F7B0", Offset = "0xD5F7B0")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public Grabbable lastPlacedObject
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x1CAE418", Offset = "0x1CAE418", VA = "0x1CAE418")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5F7C0", Offset = "0xD5F7C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x1CAE420", Offset = "0x1CAE420", VA = "0x1CAE420")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5F7D0", Offset = "0xD5F7D0")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1CAE428", Offset = "0x1CAE428", VA = "0x1CAE428", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1CAE528", Offset = "0x1CAE528", VA = "0x1CAE528")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD5F7E0", Offset = "0xD5F7E0")]
		private IEnumerator HighlightSafetyCheck()
		{
			return null;
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1CAE594", Offset = "0x1CAE594", VA = "0x1CAE594", Slot = "5")]
		public virtual bool CanPlace(Grabbable placeObj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1CAE7A0", Offset = "0x1CAE7A0", VA = "0x1CAE7A0", Slot = "6")]
		public virtual void Place(Grabbable placeObj)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1CAF0A0", Offset = "0x1CAF0A0", VA = "0x1CAF0A0")]
		public void Remove()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1CAF130", Offset = "0x1CAF130", VA = "0x1CAF130", Slot = "7")]
		public virtual void Remove(Grabbable placeObj)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1CAF390", Offset = "0x1CAF390", VA = "0x1CAF390", Slot = "8")]
		internal virtual void Highlight(Grabbable from)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1CAF4A8", Offset = "0x1CAF4A8", VA = "0x1CAF4A8", Slot = "9")]
		internal virtual void StopHighlight(Grabbable from)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1CAF5E0", Offset = "0x1CAF5E0", VA = "0x1CAF5E0")]
		protected bool IsOverlapping(Grabbable from)
		{
			return default(bool);
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1CAF784", Offset = "0x1CAF784", VA = "0x1CAF784", Slot = "10")]
		public virtual void SetStartPlaced()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1CAF82C", Offset = "0x1CAF82C", VA = "0x1CAF82C")]
		public Grabbable GetPlacedObject()
		{
			return null;
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1CAF834", Offset = "0x1CAF834", VA = "0x1CAF834")]
		internal float Distance(Transform from)
		{
			return default(float);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1CAF8FC", Offset = "0x1CAF8FC", VA = "0x1CAF8FC", Slot = "11")]
		protected virtual void OnPlacedObjectGrabbed(Hand pHand, Grabbable pGrabbable)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1CAF934", Offset = "0x1CAF934", VA = "0x1CAF934", Slot = "12")]
		protected virtual void OnPlacedObjectReleased(Hand pHand, Grabbable pGrabbable)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1CAF954", Offset = "0x1CAF954", VA = "0x1CAF954", Slot = "13")]
		protected virtual void OnJointBreak(float breakForce)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1CAF9E4", Offset = "0x1CAF9E4", VA = "0x1CAF9E4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1CAFBB8", Offset = "0x1CAFBB8", VA = "0x1CAFBB8")]
		public PlacePoint()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0xD5903C", Offset = "0xD5903C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD5903C", Offset = "0xD5903C")]
	public class WeightlessFollower : MonoBehaviour
	{
		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public Transform follow;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public Transform follow1;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dictionary<Hand, Transform> heldMoveTo;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public float followPositionStrength;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[HideInInspector]
		public float followRotationStrength;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public float maxVelocity;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public Grabbable grab;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal Rigidbody body;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform moveTo;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float startMass;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float startDrag;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float startAngleDrag;

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x225D7BC", Offset = "0x225D7BC", VA = "0x225D7BC")]
		public void Start()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x225D8A0", Offset = "0x225D8A0", VA = "0x225D8A0", Slot = "4")]
		public virtual void Set(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x225DEA0", Offset = "0x225DEA0", VA = "0x225DEA0", Slot = "5")]
		public virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x225DF3C", Offset = "0x225DF3C", VA = "0x225DF3C")]
		protected void SetMoveTo()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x225E158", Offset = "0x225E158", VA = "0x225E158", Slot = "6")]
		protected virtual void MoveTo()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x225E374", Offset = "0x225E374", VA = "0x225E374", Slot = "7")]
		protected virtual void TorqueTo()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x225E52C", Offset = "0x225E52C", VA = "0x225E52C")]
		private int CollisionCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x225E548", Offset = "0x225E548", VA = "0x225E548")]
		public void RemoveFollow(Hand hand, Transform follow)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x225E7C4", Offset = "0x225E7C4", VA = "0x225E7C4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x225E9AC", Offset = "0x225E9AC", VA = "0x225E9AC")]
		public WeightlessFollower()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x225EA34", Offset = "0x225EA34", VA = "0x225EA34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5F890", Offset = "0xD5F890")]
		private void <Set>b__13_0(Hand hand1, Grabbable grab1)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x225EAA8", Offset = "0x225EAA8", VA = "0x225EAA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5F8A0", Offset = "0xD5F8A0")]
		private void <RemoveFollow>b__19_0(Hand hand1, Grabbable grab1)
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD590B0", Offset = "0xD590B0")]
	public class Finger : MonoBehaviour
	{
		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5BD7C", Offset = "0xD5BD7C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5BD7C", Offset = "0xD5BD7C")]
		public Transform tip;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5BDDC", Offset = "0xD5BDDC")]
		public float tipRadius;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5BE14", Offset = "0xD5BE14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD5BE14", Offset = "0xD5BE14")]
		public float bendOffset;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fingerSmoothSpeed;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		public float secondaryOffset;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float currBendOffset;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float bend;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private Quaternion[] minGripRotPose;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		private Vector3[] minGripPosPose;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		private Quaternion[] maxGripRotPose;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		private Vector3[] maxGripPosPose;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[HideInInspector]
		private Transform[] fingerJoints;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float lastHitBend;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Collider[] results;

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x233E58C", Offset = "0x233E58C", VA = "0x233E58C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x233E5FC", Offset = "0x233E5FC", VA = "0x233E5FC")]
		public bool BendFingerUntilHit(int steps, int layermask)
		{
			return default(bool);
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x233EC0C", Offset = "0x233EC0C", VA = "0x233EC0C")]
		public bool UpdateFingerBend(float bend, int layermask)
		{
			return default(bool);
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x233EE8C", Offset = "0x233EE8C", VA = "0x233EE8C")]
		public void UpdateFinger()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x233F028", Offset = "0x233F028", VA = "0x233F028")]
		public void UpdateFinger(float bend)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x233F1C8", Offset = "0x233F1C8", VA = "0x233F1C8")]
		public void SetFingerBend(float bend)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x233F368", Offset = "0x233F368", VA = "0x233F368")]
		public void SetCurrentFingerBend(float bend)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x233E590", Offset = "0x233E590", VA = "0x233E590")]
		private void SlowBend()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x233EB10", Offset = "0x233EB10", VA = "0x233EB10")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD5F8B0", Offset = "0xD5F8B0")]
		public void ResetBend()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x233F508", Offset = "0x233F508", VA = "0x233F508")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD5F8E8", Offset = "0xD5F8E8")]
		public void Grip()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x233F604", Offset = "0x233F604", VA = "0x233F604")]
		public float GetLastHitBend()
		{
			return default(float);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x233F60C", Offset = "0x233F60C", VA = "0x233F60C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD5F920", Offset = "0xD5F920")]
		public void SetMinPose()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x233F93C", Offset = "0x233F93C", VA = "0x233F93C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD5F958", Offset = "0xD5F958")]
		public void SetMaxPose()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x233FC6C", Offset = "0x233FC6C", VA = "0x233FC6C")]
		public bool IsMinPoseSaved()
		{
			return default(bool);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x233FC90", Offset = "0x233FC90", VA = "0x233FC90")]
		public bool IsMaxPoseSaved()
		{
			return default(bool);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x233FCB4", Offset = "0x233FCB4", VA = "0x233FCB4")]
		public float GetCurrentBend()
		{
			return default(float);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x233FCC0", Offset = "0x233FCC0", VA = "0x233FCC0")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x233FD78", Offset = "0x233FD78", VA = "0x233FD78")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x233FF44", Offset = "0x233FF44", VA = "0x233FF44")]
		public Finger()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x233F6F4", Offset = "0x233F6F4", VA = "0x233F6F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5F990", Offset = "0xD5F990")]
		private int <SetMinPose>g__GetKidsCount|25_0(Transform obj, ref int count)
		{
			return default(int);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x233F7E0", Offset = "0x233F7E0", VA = "0x233F7E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5F9A0", Offset = "0xD5F9A0")]
		private void <SetMinPose>g__AssignChildrenPose|25_1(Transform obj, ref int index)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x233FFB4", Offset = "0x233FFB4", VA = "0x233FFB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5F9B0", Offset = "0xD5F9B0")]
		private void <SetMinPose>g__AssignPoint|25_2(int point, Vector3 pos, Quaternion rot, Transform joint)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x233FA24", Offset = "0x233FA24", VA = "0x233FA24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5F9C0", Offset = "0xD5F9C0")]
		private int <SetMaxPose>g__GetKidsCount|26_0(Transform obj, ref int count)
		{
			return default(int);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x233FB10", Offset = "0x233FB10", VA = "0x233FB10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5F9D0", Offset = "0xD5F9D0")]
		private void <SetMaxPose>g__AssignChildrenPose|26_1(Transform obj, ref int index)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x2340074", Offset = "0x2340074", VA = "0x2340074")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5F9E0", Offset = "0xD5F9E0")]
		private void <SetMaxPose>g__AssignPoint|26_2(int point, Vector3 pos, Quaternion rot, Transform joint)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x233FDB8", Offset = "0x233FDB8", VA = "0x233FDB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5F9F0", Offset = "0xD5F9F0")]
		private void <OnDrawGizmosSelected>g__DrawSphereBetweenChild|31_0(Transform transform)
		{
		}
	}
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD590E8", Offset = "0xD590E8")]
	[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0xD590E8", Offset = "0xD590E8")]
	public class Hand : HandBase
	{
		[StructLayout(3)]
		[Token(Token = "0x200003A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD59138", Offset = "0xD59138")]
		private struct <>c__DisplayClass97_0
		{
			[Token(Token = "0x4000198")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RaycastHit hit;

			[Token(Token = "0x4000199")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Hand <>4__this;

			[Token(Token = "0x400019A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 palmLocalPos;

			[Token(Token = "0x400019B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion palmLocalRot;
		}

		[Token(Token = "0x200003B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD59148", Offset = "0xD59148")]
		private sealed class <HighlightUpdate>d__125 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400019C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400019D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400019E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Hand <>4__this;

			[Token(Token = "0x400019F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float timestep;

			[Token(Token = "0x17000015")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001CD")]
				[Address(RVA = "0x226440C", Offset = "0x226440C", VA = "0x226440C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000016")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001CF")]
				[Address(RVA = "0x2264454", Offset = "0x2264454", VA = "0x2264454", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x22642D8", Offset = "0x22642D8", VA = "0x22642D8")]
			[DebuggerHidden]
			public <HighlightUpdate>d__125(int <>1__state)
			{
			}

			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x2264304", Offset = "0x2264304", VA = "0x2264304", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x2264308", Offset = "0x2264308", VA = "0x2264308", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x2264414", Offset = "0x2264414", VA = "0x2264414", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200003C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD59158", Offset = "0xD59158")]
		private struct <>c__DisplayClass127_0
		{
			[Token(Token = "0x40001A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Hand <>4__this;

			[Token(Token = "0x40001A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Grabbable startHoldingObj;
		}

		[Token(Token = "0x200003D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD59168", Offset = "0xD59168")]
		private sealed class <GrabObject>d__127 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Hand <>4__this;

			[Token(Token = "0x40001A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Grabbable grab;

			[Token(Token = "0x40001A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public RaycastHit hit;

			[Token(Token = "0x40001A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public GrabType grabType;

			[Token(Token = "0x40001A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private <>c__DisplayClass127_0 <>8__1;

			[Token(Token = "0x40001A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool <instantGrab>5__2;

			[Token(Token = "0x40001AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private HandPoseData <startGrabPose>5__3;

			[Token(Token = "0x40001AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Vector3 <startGrabbablePosition>5__4;

			[Token(Token = "0x40001AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private Quaternion <startGrabbableRotation>5__5;

			[Token(Token = "0x40001AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private float <adjustedGrabTime>5__6;

			[Token(Token = "0x40001AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private Transform <grabTarget>5__7;

			[Token(Token = "0x40001AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private HandPoseData <postGrabPose>5__8;

			[Token(Token = "0x40001B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			private Vector3 <endGrabbablePosition>5__9;

			[Token(Token = "0x40001B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			private Quaternion <endGrabbableRotation>5__10;

			[Token(Token = "0x40001B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private float <i>5__11;

			[Token(Token = "0x40001B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			private bool <useGravity>5__12;

			[Token(Token = "0x17000017")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001D3")]
				[Address(RVA = "0x2264288", Offset = "0x2264288", VA = "0x2264288", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000018")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001D5")]
				[Address(RVA = "0x22642D0", Offset = "0x22642D0", VA = "0x22642D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x226274C", Offset = "0x226274C", VA = "0x226274C")]
			[DebuggerHidden]
			public <GrabObject>d__127(int <>1__state)
			{
			}

			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x2262778", Offset = "0x2262778", VA = "0x2262778", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x226277C", Offset = "0x226277C", VA = "0x226277C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x2264290", Offset = "0x2264290", VA = "0x2264290", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200003E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD59178", Offset = "0xD59178")]
		private sealed class <LerpHandPose>d__129 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Hand <>4__this;

			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HandPoseData fromPose;

			[Token(Token = "0x40001B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public HandPoseData toPose;

			[Token(Token = "0x40001B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public float totalTime;

			[Token(Token = "0x40001BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float <timePassed>5__2;

			[Token(Token = "0x17000019")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001D9")]
				[Address(RVA = "0x22646C0", Offset = "0x22646C0", VA = "0x22646C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001DB")]
				[Address(RVA = "0x2264708", Offset = "0x2264708", VA = "0x2264708", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x226445C", Offset = "0x226445C", VA = "0x226445C")]
			[DebuggerHidden]
			public <LerpHandPose>d__129(int <>1__state)
			{
			}

			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x2264488", Offset = "0x2264488", VA = "0x2264488", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x226448C", Offset = "0x226448C", VA = "0x226448C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x22646C8", Offset = "0x22646C8", VA = "0x22646C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		[AttributeAttribute(Name = "AutoToggleHeaderAttribute", RVA = "0xD5BF90", Offset = "0xD5BF90")]
		public bool usingHighlight;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x244")]
		[AttributeAttribute(Name = "EnableIfAttribute", RVA = "0xD5BFE4", Offset = "0xD5BFE4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5BFE4", Offset = "0xD5BFE4")]
		public LayerMask highlightLayers;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		[AttributeAttribute(Name = "EnableIfAttribute", RVA = "0xD5C044", Offset = "0xD5C044")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5C044", Offset = "0xD5C044")]
		public Material defaultHighlight;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		[AttributeAttribute(Name = "AutoToggleHeaderAttribute", RVA = "0xD5C0A4", Offset = "0xD5C0A4")]
		public bool showAdvanced;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x254")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5C0E4", Offset = "0xD5C0E4")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5C0E4", Offset = "0xD5C0E4")]
		public GrabType grabType;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xD5C144", Offset = "0xD5C144")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5C144", Offset = "0xD5C144")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5C144", Offset = "0xD5C144")]
		public float minGrabTime;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5C1B8", Offset = "0xD5C1B8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5C1B8", Offset = "0xD5C1B8")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xD5C1B8", Offset = "0xD5C1B8")]
		public float maxGrabTime;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5C22C", Offset = "0xD5C22C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5C22C", Offset = "0xD5C22C")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xD5C22C", Offset = "0xD5C22C")]
		public AnimationCurve grabCurve;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xD5C2A0", Offset = "0xD5C2A0")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5C2A0", Offset = "0xD5C2A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5C2A0", Offset = "0xD5C2A0")]
		public float smoothReturnSpeed;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5C314", Offset = "0xD5C314")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5C314", Offset = "0xD5C314")]
		public int poseIndex;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		[AttributeAttribute(Name = "AutoLineAttribute", RVA = "0xD5C374", Offset = "0xD5C374")]
		public bool ignoreMe1;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] grabbableLayers;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string grabbableLayerNameDefault;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string grabbingLayerName;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string rightHandLayerName;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string leftHandLayerName;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private List<HandTriggerAreaEvents> triggerEventAreas;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private Coroutine tryGrab;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private Coroutine highlightRoutine;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private float startGrabDist;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private HandPoseData openHandPose;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		private Grabbable lastHoldingObj;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		private Coroutine _grabRoutine;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		private Vector3 startHandGrabPosition;

		[Token(Token = "0x17000014")]
		private Coroutine grabRoutine
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x23D45B4", Offset = "0x23D45B4", VA = "0x23D45B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x23D45BC", Offset = "0x23D45BC", VA = "0x23D45BC")]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public event HandGrabEvent OnTriggerGrab
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x23D2FEC", Offset = "0x23D2FEC", VA = "0x23D2FEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FA00", Offset = "0xD5FA00")]
			add
			{
			}
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x23D3090", Offset = "0x23D3090", VA = "0x23D3090")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FA10", Offset = "0xD5FA10")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event HandGrabEvent OnBeforeGrabbed
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x23D3134", Offset = "0x23D3134", VA = "0x23D3134")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FA20", Offset = "0xD5FA20")]
			add
			{
			}
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x23D31D8", Offset = "0x23D31D8", VA = "0x23D31D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FA30", Offset = "0xD5FA30")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event HandGrabEvent OnGrabbed
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x23D327C", Offset = "0x23D327C", VA = "0x23D327C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FA40", Offset = "0xD5FA40")]
			add
			{
			}
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x23D3320", Offset = "0x23D3320", VA = "0x23D3320")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FA50", Offset = "0xD5FA50")]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event HandGrabEvent OnTriggerRelease
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x23D33C4", Offset = "0x23D33C4", VA = "0x23D33C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FA60", Offset = "0xD5FA60")]
			add
			{
			}
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x23D3468", Offset = "0x23D3468", VA = "0x23D3468")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FA70", Offset = "0xD5FA70")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event HandGrabEvent OnBeforeReleased
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x23D350C", Offset = "0x23D350C", VA = "0x23D350C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FA80", Offset = "0xD5FA80")]
			add
			{
			}
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x23D35B0", Offset = "0x23D35B0", VA = "0x23D35B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FA90", Offset = "0xD5FA90")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event HandGrabEvent OnReleased
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x23D3654", Offset = "0x23D3654", VA = "0x23D3654")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FAA0", Offset = "0xD5FAA0")]
			add
			{
			}
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x23D36F8", Offset = "0x23D36F8", VA = "0x23D36F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FAB0", Offset = "0xD5FAB0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event HandGrabEvent OnSqueezed
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x23D379C", Offset = "0x23D379C", VA = "0x23D379C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FAC0", Offset = "0xD5FAC0")]
			add
			{
			}
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x23D3840", Offset = "0x23D3840", VA = "0x23D3840")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FAD0", Offset = "0xD5FAD0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		public event HandGrabEvent OnUnsqueezed
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x23D38E4", Offset = "0x23D38E4", VA = "0x23D38E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FAE0", Offset = "0xD5FAE0")]
			add
			{
			}
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x23D3988", Offset = "0x23D3988", VA = "0x23D3988")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FAF0", Offset = "0xD5FAF0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public event HandGrabEvent OnHighlight
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x23D3A2C", Offset = "0x23D3A2C", VA = "0x23D3A2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FB00", Offset = "0xD5FB00")]
			add
			{
			}
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x23D3AD0", Offset = "0x23D3AD0", VA = "0x23D3AD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FB10", Offset = "0xD5FB10")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event HandGrabEvent OnStopHighlight
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x23D3B74", Offset = "0x23D3B74", VA = "0x23D3B74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FB20", Offset = "0xD5FB20")]
			add
			{
			}
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x23D3C18", Offset = "0x23D3C18", VA = "0x23D3C18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FB30", Offset = "0xD5FB30")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public event HandGrabEvent OnForcedRelease
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x23D3CBC", Offset = "0x23D3CBC", VA = "0x23D3CBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FB40", Offset = "0xD5FB40")]
			add
			{
			}
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x23D3D60", Offset = "0x23D3D60", VA = "0x23D3D60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FB50", Offset = "0xD5FB50")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000C")]
		public event HandGrabEvent OnGrabJointBreak
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x23D3E04", Offset = "0x23D3E04", VA = "0x23D3E04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FB60", Offset = "0xD5FB60")]
			add
			{
			}
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x23D3EA8", Offset = "0x23D3EA8", VA = "0x23D3EA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FB70", Offset = "0xD5FB70")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000D")]
		public event HandGrabEvent OnHeldConnectionBreak
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x23D3F4C", Offset = "0x23D3F4C", VA = "0x23D3F4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FB80", Offset = "0xD5FB80")]
			add
			{
			}
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x23D3FF0", Offset = "0x23D3FF0", VA = "0x23D3FF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FB90", Offset = "0xD5FB90")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public event HandGameObjectEvent OnHandCollisionStart
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x23D4094", Offset = "0x23D4094", VA = "0x23D4094")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FBA0", Offset = "0xD5FBA0")]
			add
			{
			}
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x23D4138", Offset = "0x23D4138", VA = "0x23D4138")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FBB0", Offset = "0xD5FBB0")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000F")]
		public event HandGameObjectEvent OnHandCollisionStop
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x23D41DC", Offset = "0x23D41DC", VA = "0x23D41DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FBC0", Offset = "0xD5FBC0")]
			add
			{
			}
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x23D4280", Offset = "0x23D4280", VA = "0x23D4280")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FBD0", Offset = "0xD5FBD0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000010")]
		public event HandGameObjectEvent OnHandTriggerStart
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x23D4324", Offset = "0x23D4324", VA = "0x23D4324")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FBE0", Offset = "0xD5FBE0")]
			add
			{
			}
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x23D43C8", Offset = "0x23D43C8", VA = "0x23D43C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FBF0", Offset = "0xD5FBF0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event HandGameObjectEvent OnHandTriggerStop
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x23D446C", Offset = "0x23D446C", VA = "0x23D446C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FC00", Offset = "0xD5FC00")]
			add
			{
			}
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x23D4510", Offset = "0x23D4510", VA = "0x23D4510")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FC10", Offset = "0xD5FC10")]
			remove
			{
			}
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x23D46CC", Offset = "0x23D46CC", VA = "0x23D46CC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x23D4C58", Offset = "0x23D4C58", VA = "0x23D4C58", Slot = "20")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x23D4DE8", Offset = "0x23D4DE8", VA = "0x23D4DE8", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x23D518C", Offset = "0x23D518C", VA = "0x23D518C", Slot = "6")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x23D55BC", Offset = "0x23D55BC", VA = "0x23D55BC", Slot = "9")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x23D5910", Offset = "0x23D5910", VA = "0x23D5910")]
		private float GetGrabTime()
		{
			return default(float);
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x23D5F78", Offset = "0x23D5F78", VA = "0x23D5F78", Slot = "21")]
		public virtual void Grab()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x23D5F8C", Offset = "0x23D5F8C", VA = "0x23D5F8C", Slot = "22")]
		public virtual void Grab(GrabType grabType)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x23D64FC", Offset = "0x23D64FC", VA = "0x23D64FC", Slot = "23")]
		public virtual void Grab(RaycastHit hit, Grabbable grab, GrabType grabType = GrabType.InstantGrab)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x23D66D8", Offset = "0x23D66D8", VA = "0x23D66D8", Slot = "24")]
		public virtual void TryGrab(Grabbable grab)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x23D6E68", Offset = "0x23D6E68", VA = "0x23D6E68", Slot = "25")]
		public virtual void Release()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x23D7114", Offset = "0x23D7114", VA = "0x23D7114", Slot = "26")]
		public virtual void ForceReleaseGrab()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x23D71C4", Offset = "0x23D71C4", VA = "0x23D71C4", Slot = "27")]
		public virtual void ReleaseGrabLock()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x23D71D4", Offset = "0x23D71D4", VA = "0x23D71D4", Slot = "28")]
		public virtual void Squeeze()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x23D7330", Offset = "0x23D7330", VA = "0x23D7330", Slot = "29")]
		public virtual void Unsqueeze()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x23D7488", Offset = "0x23D7488", VA = "0x23D7488", Slot = "30")]
		public virtual void BreakGrabConnection(bool callEvent = true)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x23D785C", Offset = "0x23D785C", VA = "0x23D785C", Slot = "31")]
		public virtual void CreateGrabConnection(Grabbable grab, Vector3 handPos, Quaternion handRot, Vector3 grabPos, Quaternion grabRot, bool executeGrabEvents = false)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x23D7F6C", Offset = "0x23D7F6C", VA = "0x23D7F6C", Slot = "32")]
		public virtual void OnJointBreak(float breakForce)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x23D8104", Offset = "0x23D8104", VA = "0x23D8104", Slot = "33")]
		public virtual void UpdateHighlight()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x23D63DC", Offset = "0x23D63DC", VA = "0x23D63DC")]
		public RaycastHit GetHighlightHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x23D83F0", Offset = "0x23D83F0", VA = "0x23D83F0")]
		public void AutoPose(RaycastHit hit, Grabbable grabbable)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x23D89D4", Offset = "0x23D89D4", VA = "0x23D89D4")]
		public HandPoseData GetHandPose()
		{
			return default(HandPoseData);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x23D89F4", Offset = "0x23D89F4", VA = "0x23D89F4")]
		public HandPoseData GetHeldPose()
		{
			return default(HandPoseData);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x23D8ABC", Offset = "0x23D8ABC", VA = "0x23D8ABC", Slot = "34")]
		public virtual void SetHeldPose(HandPoseData pose, Grabbable grabbable, bool createJoint = true)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x23D8E68", Offset = "0x23D8E68", VA = "0x23D8E68")]
		public void SetHandPose(HandPoseData pose)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x23D8E80", Offset = "0x23D8E80", VA = "0x23D8E80")]
		public void SetHandPose(GrabbablePose pose)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x23D8F04", Offset = "0x23D8F04", VA = "0x23D8F04")]
		public void UpdatePose(HandPoseData pose, float time)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x23D902C", Offset = "0x23D902C", VA = "0x23D902C")]
		public GrabbablePose GetGrabPose(Transform from, Grabbable grabbable)
		{
			return null;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x23D909C", Offset = "0x23D909C", VA = "0x23D909C")]
		public bool GetCurrentHeldGrabPose(Transform from, Grabbable grabbable, out GrabbablePose grabPose, out Transform relativeTo)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x23D918C", Offset = "0x23D918C", VA = "0x23D918C")]
		public Grabbable GetHeldGrabbable()
		{
			return null;
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x23D9194", Offset = "0x23D9194", VA = "0x23D9194")]
		public Grabbable GetHeld()
		{
			return null;
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x23D919C", Offset = "0x23D919C", VA = "0x23D919C")]
		public bool IsSqueezing()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x23D91A4", Offset = "0x23D91A4", VA = "0x23D91A4")]
		public void SetGrip(float grip)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x23D91AC", Offset = "0x23D91AC", VA = "0x23D91AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD5FC20", Offset = "0xD5FC20")]
		public void RelaxHand()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x23D9228", Offset = "0x23D9228", VA = "0x23D9228")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD5FC58", Offset = "0xD5FC58")]
		public void OpenHand()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x23D9298", Offset = "0x23D9298", VA = "0x23D9298")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD5FC90", Offset = "0xD5FC90")]
		public void CloseHand()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x23D9314", Offset = "0x23D9314", VA = "0x23D9314")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD5FCC8", Offset = "0xD5FCC8")]
		public void ProceduralFingerBend()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x23D9438", Offset = "0x23D9438", VA = "0x23D9438")]
		public void ProceduralFingerBend(int layermask)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x23D94BC", Offset = "0x23D94BC", VA = "0x23D94BC")]
		public void ProceduralFingerBend(RaycastHit hit)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x23D9574", Offset = "0x23D9574", VA = "0x23D9574")]
		public void PlayHapticVibration()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x23D9610", Offset = "0x23D9610", VA = "0x23D9610")]
		public void PlayHapticVibration(float duration)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x23D9584", Offset = "0x23D9584", VA = "0x23D9584")]
		public void PlayHapticVibration(float duration, float amp = 0.5f)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x23D9618", Offset = "0x23D9618", VA = "0x23D9618")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD5FD00", Offset = "0xD5FD00")]
		[AttributeAttribute(Name = "ButtonAttribute", RVA = "0xD5FD00", Offset = "0xD5FD00")]
		public void SaveOpenPose()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x23D96E4", Offset = "0x23D96E4", VA = "0x23D96E4")]
		[AttributeAttribute(Name = "ButtonAttribute", RVA = "0xD5FD64", Offset = "0xD5FD64")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD5FD64", Offset = "0xD5FD64")]
		public void SaveClosedPose()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x23D97B0", Offset = "0x23D97B0", VA = "0x23D97B0", Slot = "35")]
		protected virtual void OnCollisionFirstEnter(GameObject collision)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x23D985C", Offset = "0x23D985C", VA = "0x23D985C", Slot = "36")]
		protected virtual void OnCollisionLastExit(GameObject collision)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x23D9908", Offset = "0x23D9908", VA = "0x23D9908", Slot = "37")]
		protected virtual void OnTriggerFirstEnter(GameObject other)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x23D99F8", Offset = "0x23D99F8", VA = "0x23D99F8", Slot = "38")]
		protected virtual void OnTriggerLastExit(GameObject other)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x23D4D6C", Offset = "0x23D4D6C", VA = "0x23D4D6C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD5FDC8", Offset = "0xD5FDC8")]
		private IEnumerator HighlightUpdate(float timestep)
		{
			return null;
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x23D6458", Offset = "0x23D6458", VA = "0x23D6458")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD5FE28", Offset = "0xD5FE28")]
		protected IEnumerator GrabObject(RaycastHit hit, Grabbable grab, GrabType grabType)
		{
			return null;
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x23D9AE8", Offset = "0x23D9AE8", VA = "0x23D9AE8")]
		protected void CancelPose()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x23D9B24", Offset = "0x23D9B24", VA = "0x23D9B24", Slot = "39")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD5FE88", Offset = "0xD5FE88")]
		protected virtual IEnumerator LerpHandPose(HandPoseData fromPose, HandPoseData toPose, float totalTime)
		{
			return null;
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x23D9BE4", Offset = "0x23D9BE4", VA = "0x23D9BE4", Slot = "40")]
		protected virtual void CheckEnterPoseArea(GameObject other)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x23DA124", Offset = "0x23DA124", VA = "0x23DA124", Slot = "41")]
		protected virtual void CheckExitPoseArea(GameObject other)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x23D9F48", Offset = "0x23D9F48", VA = "0x23D9F48")]
		internal void TryRemoveHandPoseArea(HandPoseArea poseArea)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x23DA1F0", Offset = "0x23DA1F0", VA = "0x23DA1F0")]
		private void ClearPoseArea()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x23DA29C", Offset = "0x23DA29C", VA = "0x23DA29C", Slot = "42")]
		internal virtual void RemoveHandTriggerArea(HandTriggerAreaEvents handTrigger)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x23DA318", Offset = "0x23DA318", VA = "0x23DA318")]
		public Hand()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x23DA6D4", Offset = "0x23DA6D4", VA = "0x23DA6D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FEE8", Offset = "0xD5FEE8")]
		private void <OnEnable>b__79_0(GameObject collision)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x23DA6F4", Offset = "0x23DA6F4", VA = "0x23DA6F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FEF8", Offset = "0xD5FEF8")]
		private void <OnEnable>b__79_1(GameObject collision)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x23DA714", Offset = "0x23DA714", VA = "0x23DA714")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FF08", Offset = "0xD5FF08")]
		private void <OnEnable>b__79_2(GameObject collision)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x23DA734", Offset = "0x23DA734", VA = "0x23DA734")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FF18", Offset = "0xD5FF18")]
		private void <OnEnable>b__79_3(GameObject collision)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x23DA754", Offset = "0x23DA754", VA = "0x23DA754")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FF28", Offset = "0xD5FF28")]
		private void <OnDisable>b__80_0(GameObject collision)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x23DA774", Offset = "0x23DA774", VA = "0x23DA774")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FF38", Offset = "0xD5FF38")]
		private void <OnDisable>b__80_1(GameObject collision)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x23DA794", Offset = "0x23DA794", VA = "0x23DA794")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FF48", Offset = "0xD5FF48")]
		private void <OnDisable>b__80_2(GameObject collision)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x23DA7B4", Offset = "0x23DA7B4", VA = "0x23DA7B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FF58", Offset = "0xD5FF58")]
		private void <OnDisable>b__80_3(GameObject collision)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x23D8668", Offset = "0x23D8668", VA = "0x23D8668")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FF68", Offset = "0xD5FF68")]
		private void <AutoPose>g__Calculate|97_0(ref <>c__DisplayClass97_0 P_0)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x23DA7D4", Offset = "0x23DA7D4", VA = "0x23DA7D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FF78", Offset = "0xD5FF78")]
		private void <AutoPose>g__Align|97_1(ref <>c__DisplayClass97_0 P_0)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x23DA94C", Offset = "0x23DA94C", VA = "0x23DA94C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5FF88", Offset = "0xD5FF88")]
		private void <GrabObject>g__CancelGrab|127_0(ref <>c__DisplayClass127_0 P_0)
		{
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD59188", Offset = "0xD59188")]
	[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0xD59188", Offset = "0xD59188")]
	public class HandAdvancedOptions : MonoBehaviour
	{
		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5C49C", Offset = "0xD5C49C")]
		public List<Collider> ignoreHandCollider;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Hand hand;

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x23DAA60", Offset = "0x23DAA60", VA = "0x23DAA60")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x23DAAB4", Offset = "0x23DAAB4", VA = "0x23DAAB4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x23DAC1C", Offset = "0x23DAC1C", VA = "0x23DAC1C")]
		public HandAdvancedOptions()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class HandClippingGuard : MonoBehaviour
	{
		[Token(Token = "0x2000041")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD591FC", Offset = "0xD591FC")]
		private sealed class <Guard>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Hand hand;

			[Token(Token = "0x40001C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HandClippingGuard <>4__this;

			[Token(Token = "0x1700001B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001E7")]
				[Address(RVA = "0x2264914", Offset = "0x2264914", VA = "0x2264914", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001E9")]
				[Address(RVA = "0x226495C", Offset = "0x226495C", VA = "0x226495C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x2264710", Offset = "0x2264710", VA = "0x2264710")]
			[DebuggerHidden]
			public <Guard>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x226473C", Offset = "0x226473C", VA = "0x226473C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x2264740", Offset = "0x2264740", VA = "0x2264740", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x226491C", Offset = "0x226491C", VA = "0x226491C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Hand hand;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5C4D4", Offset = "0xD5C4D4")]
		public SphereCollider collisionGuard;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform body;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float guardTime;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 grabPoint;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool runProtection;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Coroutine guardRoutine;

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x23DEE7C", Offset = "0x23DEE7C", VA = "0x23DEE7C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x23DEF64", Offset = "0x23DEF64", VA = "0x23DEF64")]
		private void BeforeGrab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x23DF078", Offset = "0x23DF078", VA = "0x23DF078")]
		private void OnRelease(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x23DF0B8", Offset = "0x23DF0B8", VA = "0x23DF0B8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD60088", Offset = "0xD60088")]
		private IEnumerator Guard(Hand hand)
		{
			return null;
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x23DF130", Offset = "0x23DF130", VA = "0x23DF130")]
		public HandClippingGuard()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD5920C", Offset = "0xD5920C")]
	public class HandCollisionHaptics : MonoBehaviour
	{
		[Token(Token = "0x2000043")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5926C", Offset = "0xD5926C")]
		private sealed class <PlayBuffer>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandCollisionHaptics <>4__this;

			[Token(Token = "0x1700001D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001F3")]
				[Address(RVA = "0x2264B9C", Offset = "0x2264B9C", VA = "0x2264B9C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001F5")]
				[Address(RVA = "0x2264BE4", Offset = "0x2264BE4", VA = "0x2264BE4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x2264AA8", Offset = "0x2264AA8", VA = "0x2264AA8")]
			[DebuggerHidden]
			public <PlayBuffer>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x2264AD4", Offset = "0x2264AD4", VA = "0x2264AD4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x2264AD8", Offset = "0x2264AD8", VA = "0x2264AD8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x2264BA4", Offset = "0x2264BA4", VA = "0x2264BA4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000044")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5927C", Offset = "0xD5927C")]
		private sealed class <HapticPlayBuffer>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandCollisionHaptics <>4__this;

			[Token(Token = "0x40001D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float time;

			[Token(Token = "0x1700001F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001F9")]
				[Address(RVA = "0x2264A58", Offset = "0x2264A58", VA = "0x2264A58", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000020")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001FB")]
				[Address(RVA = "0x2264AA0", Offset = "0x2264AA0", VA = "0x2264AA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x2264964", Offset = "0x2264964", VA = "0x2264964")]
			[DebuggerHidden]
			public <HapticPlayBuffer>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x2264990", Offset = "0x2264990", VA = "0x2264990", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x2264994", Offset = "0x2264994", VA = "0x2264994", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x2264A60", Offset = "0x2264A60", VA = "0x2264A60", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5C50C", Offset = "0xD5C50C")]
		public LayerMask collisionTriggers;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float hapticAmp;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float velocityAmp;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float repeatDelay;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float maxDuration;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5C544", Offset = "0xD5C544")]
		public AnimationCurve velocityAmpCurve;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5C57C", Offset = "0xD5C57C")]
		public AnimationCurve velocityDurationCurve;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Hand hand;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Rigidbody body;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool canPlay;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine playRoutine;

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x23DF144", Offset = "0x23DF144", VA = "0x23DF144")]
		private void Start()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x23DF250", Offset = "0x23DF250", VA = "0x23DF250")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x23DF264", Offset = "0x23DF264", VA = "0x23DF264")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x23DF488", Offset = "0x23DF488", VA = "0x23DF488")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD60138", Offset = "0xD60138")]
		private IEnumerator PlayBuffer()
		{
			return null;
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x23DF1D4", Offset = "0x23DF1D4", VA = "0x23DF1D4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD60198", Offset = "0xD60198")]
		private IEnumerator HapticPlayBuffer(float time)
		{
			return null;
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x23DF4F4", Offset = "0x23DF4F4", VA = "0x23DF4F4")]
		public HandCollisionHaptics()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class HandControllerLink : MonoBehaviour
	{
		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static HandControllerLink handLeft;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static HandControllerLink handRight;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Hand hand;

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x23DF580", Offset = "0x23DF580", VA = "0x23DF580", Slot = "4")]
		public virtual void TryHapticImpulse(float duration, float amp, float freq = 10f)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x23DF584", Offset = "0x23DF584", VA = "0x23DF584")]
		public HandControllerLink()
		{
		}
	}
	[Token(Token = "0x2000046")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD5928C", Offset = "0xD5928C")]
	[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0xD5928C", Offset = "0xD5928C")]
	public class HandDistanceGrabber : MonoBehaviour
	{
		[Token(Token = "0x2000047")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD592DC", Offset = "0xD592DC")]
		private sealed class <>c__DisplayClass62_0
		{
			[Token(Token = "0x4000204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public HandDistanceGrabber <>4__this;

			[Token(Token = "0x4000205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DistanceGrabbable grab;

			[Token(Token = "0x4000206")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float estimatedRadius;

			[Token(Token = "0x600021B")]
			[Address(RVA = "0x2264BEC", Offset = "0x2264BEC", VA = "0x2264BEC")]
			public <>c__DisplayClass62_0()
			{
			}

			[Token(Token = "0x600021C")]
			[Address(RVA = "0x2264BF4", Offset = "0x2264BF4", VA = "0x2264BF4")]
			internal void <StartCatchAssist>b__0(Hand hand, Grabbable grabbable)
			{
			}

			[Token(Token = "0x600021D")]
			[Address(RVA = "0x2264C94", Offset = "0x2264C94", VA = "0x2264C94")]
			internal void <StartCatchAssist>b__1(Hand hand, Grabbable grabbable)
			{
			}

			[Token(Token = "0x600021E")]
			[Address(RVA = "0x2264D34", Offset = "0x2264D34", VA = "0x2264D34")]
			internal bool <StartCatchAssist>g__TryCatch|3(Hand hand)
			{
				return default(bool);
			}

			[Token(Token = "0x600021F")]
			[Address(RVA = "0x22651A0", Offset = "0x22651A0", VA = "0x22651A0")]
			internal void <StartCatchAssist>b__5(Hand hand, Grabbable grabbable)
			{
			}

			[Token(Token = "0x6000220")]
			[Address(RVA = "0x2265240", Offset = "0x2265240", VA = "0x2265240")]
			internal void <StartCatchAssist>b__6(Hand hand, Grabbable grabbable)
			{
			}
		}

		[Token(Token = "0x2000048")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD592EC", Offset = "0xD592EC")]
		private sealed class <>c__DisplayClass62_1
		{
			[Token(Token = "0x4000207")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool cancelInstantGrab;

			[Token(Token = "0x6000221")]
			[Address(RVA = "0x22652E0", Offset = "0x22652E0", VA = "0x22652E0")]
			public <>c__DisplayClass62_1()
			{
			}

			[Token(Token = "0x6000222")]
			[Address(RVA = "0x22652E8", Offset = "0x22652E8", VA = "0x22652E8")]
			internal void <StartCatchAssist>b__2(Hand hand, Grabbable grabbable)
			{
			}

			[Token(Token = "0x6000223")]
			[Address(RVA = "0x22652F4", Offset = "0x22652F4", VA = "0x22652F4")]
			internal void <StartCatchAssist>b__4(Hand hand, Grabbable grabbable)
			{
			}
		}

		[Token(Token = "0x2000049")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD592FC", Offset = "0xD592FC")]
		private sealed class <StartCatchAssist>d__62 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000208")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000209")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400020A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandDistanceGrabber <>4__this;

			[Token(Token = "0x400020B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DistanceGrabbable grab;

			[Token(Token = "0x400020C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float estimatedRadius;

			[Token(Token = "0x400020D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private <>c__DisplayClass62_0 <>8__1;

			[Token(Token = "0x400020E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private <>c__DisplayClass62_1 <>8__2;

			[Token(Token = "0x400020F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <time>5__2;

			[Token(Token = "0x17000022")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000227")]
				[Address(RVA = "0x2265868", Offset = "0x2265868", VA = "0x2265868", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000023")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000229")]
				[Address(RVA = "0x22658B0", Offset = "0x22658B0", VA = "0x22658B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000224")]
			[Address(RVA = "0x2265300", Offset = "0x2265300", VA = "0x2265300")]
			[DebuggerHidden]
			public <StartCatchAssist>d__62(int <>1__state)
			{
			}

			[Token(Token = "0x6000225")]
			[Address(RVA = "0x226532C", Offset = "0x226532C", VA = "0x226532C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000226")]
			[Address(RVA = "0x2265330", Offset = "0x2265330", VA = "0x2265330", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000228")]
			[Address(RVA = "0x2265870", Offset = "0x2265870", VA = "0x2265870", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5C5B4", Offset = "0xD5C5B4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5C5B4", Offset = "0xD5C5B4")]
		public Hand primaryHand;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5C614", Offset = "0xD5C614")]
		public Hand secondaryHand;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5C64C", Offset = "0xD5C64C")]
		public Transform forwardPointer;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LineRenderer line;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD5C684", Offset = "0xD5C684")]
		public float maxRange;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5C694", Offset = "0xD5C694")]
		public LayerMask layers;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD5C6CC", Offset = "0xD5C6CC")]
		public Material defaultTargetedMaterial;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5C6DC", Offset = "0xD5C6DC")]
		public Material defaultSelectedMaterial;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5C714", Offset = "0xD5C714")]
		public bool useInstantPull;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5C74C", Offset = "0xD5C74C")]
		public bool useFlickPull;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5C784", Offset = "0xD5C784")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5C784", Offset = "0xD5C784")]
		public float flickThreshold;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5C7E4", Offset = "0xD5C7E4")]
		[AttributeAttribute(Name = "HideIfAttribute", RVA = "0xD5C7E4", Offset = "0xD5C7E4")]
		public float pullGrabDistance;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD5C844", Offset = "0xD5C844")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5C844", Offset = "0xD5C844")]
		public bool instantGrabAssist;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5C890", Offset = "0xD5C890")]
		public float catchAssistRadius;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "AutoToggleHeaderAttribute", RVA = "0xD5C8C8", Offset = "0xD5C8C8")]
		public bool showEvents;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5C908", Offset = "0xD5C908")]
		public UnityHandGrabEvent OnPull;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5C940", Offset = "0xD5C940")]
		public UnityHandEvent StartPoint;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5C978", Offset = "0xD5C978")]
		public UnityHandEvent StopPoint;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5C9B0", Offset = "0xD5C9B0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5C9B0", Offset = "0xD5C9B0")]
		public UnityHandGrabEvent StartTarget;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5CA10", Offset = "0xD5CA10")]
		public UnityHandGrabEvent StopTarget;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5CA48", Offset = "0xD5CA48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5CA48", Offset = "0xD5CA48")]
		public UnityHandGrabEvent StartSelect;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5CAA8", Offset = "0xD5CAA8")]
		public UnityHandGrabEvent StopSelect;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<CatchAssistData> catchAssisted;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private DistanceGrabbable targetingDistanceGrabbable;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private DistanceGrabbable selectingDistanceGrabbable;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float catchAssistSeconds;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private bool pointing;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		private bool pulling;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3 startPullPosition;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private RaycastHit hit;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion lastRotation;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private RaycastHit selectionHit;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private float selectedEstimatedRadius;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float startLookAssist;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private bool lastInstantPull;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private GameObject _hitPoint;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Coroutine catchAssistRoutine;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private DistanceGrabbable catchAsistGrabbable;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private CatchAssistData catchAssistData;

		[Token(Token = "0x17000021")]
		private GameObject hitPoint
		{
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x23DF58C", Offset = "0x23DF58C", VA = "0x23DF58C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x23DF680", Offset = "0x23DF680", VA = "0x23DF680")]
		private void Start()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x23DF7E0", Offset = "0x23DF7E0", VA = "0x23DF7E0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x23DF930", Offset = "0x23DF930", VA = "0x23DF930")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x23DFB70", Offset = "0x23DFB70", VA = "0x23DFB70")]
		private void Update()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x23E0068", Offset = "0x23E0068", VA = "0x23E0068")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x23DF7D4", Offset = "0x23DF7D4", VA = "0x23DF7D4")]
		public void SetInstantPull()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x23E00DC", Offset = "0x23E00DC", VA = "0x23E00DC")]
		public void SetPull(float distance)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x23E00E8", Offset = "0x23E00E8", VA = "0x23E00E8")]
		public void SetFlickPull(float threshold)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x23DFBC0", Offset = "0x23DFBC0", VA = "0x23DFBC0")]
		private void CheckDistanceGrabbable()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x23E037C", Offset = "0x23E037C", VA = "0x23E037C", Slot = "4")]
		public virtual void StartPointing()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x23E03E4", Offset = "0x23E03E4", VA = "0x23E03E4", Slot = "5")]
		public virtual void StopPointing()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x23E04E0", Offset = "0x23E04E0", VA = "0x23E04E0", Slot = "6")]
		public virtual void StartTargeting(DistanceGrabbable target)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x23E06DC", Offset = "0x23E06DC", VA = "0x23E06DC", Slot = "7")]
		public virtual void StopTargeting()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x23E082C", Offset = "0x23E082C", VA = "0x23E082C", Slot = "8")]
		public virtual void SelectTarget()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x23E0BCC", Offset = "0x23E0BCC", VA = "0x23E0BCC", Slot = "9")]
		public virtual void CancelSelect()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x23E0CE4", Offset = "0x23E0CE4", VA = "0x23E0CE4", Slot = "10")]
		public virtual void ActivatePull()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x23E02DC", Offset = "0x23E02DC", VA = "0x23E02DC")]
		private void TryDistancePull()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x23E00F8", Offset = "0x23E00F8", VA = "0x23E00F8")]
		private void TryFlickPull()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x23E0B28", Offset = "0x23E0B28", VA = "0x23E0B28")]
		private Material GetSelectedMaterial(DistanceGrabbable grabbable)
		{
			return null;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x23E0634", Offset = "0x23E0634", VA = "0x23E0634")]
		private Material GetTargetedMaterial(DistanceGrabbable grabbable)
		{
			return null;
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x23E1070", Offset = "0x23E1070", VA = "0x23E1070")]
		private void TryCatchAssist(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x23E0FE8", Offset = "0x23E0FE8", VA = "0x23E0FE8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD60298", Offset = "0xD60298")]
		private IEnumerator StartCatchAssist(DistanceGrabbable grab, float estimatedRadius)
		{
			return null;
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x23E1560", Offset = "0x23E1560", VA = "0x23E1560")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x23E16B8", Offset = "0x23E16B8", VA = "0x23E16B8")]
		public HandDistanceGrabber()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x23E16F4", Offset = "0x23E16F4", VA = "0x23E16F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD602F8", Offset = "0xD602F8")]
		private void <OnEnable>b__42_0(Hand hand, Grabbable grabbable)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x23E1728", Offset = "0x23E1728", VA = "0x23E1728")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60308", Offset = "0xD60308")]
		private void <OnDisable>b__43_0(Hand hand, Grabbable grabbable)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x23E175C", Offset = "0x23E175C", VA = "0x23E175C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60318", Offset = "0xD60318")]
		private void <OnDisable>b__43_1(Hand hand, Grabbable grabbable)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x23E17EC", Offset = "0x23E17EC", VA = "0x23E17EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60328", Offset = "0xD60328")]
		private void <OnDisable>b__43_2(Hand hand, Grabbable grabbable)
		{
		}
	}
	[Token(Token = "0x200004A")]
	internal struct CatchAssistData
	{
		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Grabbable grab;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float estimatedRadius;

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x233B0EC", Offset = "0x233B0EC", VA = "0x233B0EC")]
		public CatchAssistData(Grabbable grab, float estimatedRadius)
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD5930C", Offset = "0xD5930C")]
	public class HandPoseArea : MonoBehaviour
	{
		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string poseName;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int poseIndex;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float transitionTime;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5CAE0", Offset = "0xD5CAE0")]
		public UnityHandEvent OnHandEnter;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityHandEvent OnHandExit;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5CB18", Offset = "0xD5CB18")]
		[HideInInspector]
		public HandPoseScriptable poseScriptable;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public HandPoseData rightPose;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public bool rightPoseSet;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public HandPoseData leftPose;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		public bool leftPoseSet;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		internal HandPoseArea[] poseAreas;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private List<Hand> posingHands;

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1CA24C4", Offset = "0x1CA24C4", VA = "0x1CA24C4")]
		private void Start()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x1CA2518", Offset = "0x1CA2518", VA = "0x1CA2518")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1CA2624", Offset = "0x1CA2624", VA = "0x1CA2624")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1CA279C", Offset = "0x1CA279C", VA = "0x1CA279C")]
		private void HandEnter(Hand hand)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1CA2800", Offset = "0x1CA2800", VA = "0x1CA2800")]
		private void HandExit(Hand hand)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x1CA2864", Offset = "0x1CA2864", VA = "0x1CA2864", Slot = "4")]
		public virtual HandPoseData GetHandPoseData(bool left)
		{
			return default(HandPoseData);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1CA294C", Offset = "0x1CA294C", VA = "0x1CA294C")]
		public void SetHandPose(Hand hand)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x1CA2CAC", Offset = "0x1CA2CAC", VA = "0x1CA2CAC")]
		public bool HasPose(bool left)
		{
			return default(bool);
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x1CA2D64", Offset = "0x1CA2D64", VA = "0x1CA2D64")]
		public HandPoseArea()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class HandProjector : MonoBehaviour
	{
		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5CBA4", Offset = "0xD5CBA4")]
		public Hand hand;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5CBDC", Offset = "0xD5CBDC")]
		public Hand handProjection;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5CC14", Offset = "0xD5CC14")]
		public Transform[] handProjectionVisuals;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5CC4C", Offset = "0xD5CC4C")]
		public float speed;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5CC84", Offset = "0xD5CC84")]
		public bool hideHand;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5CCBC", Offset = "0xD5CCBC")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5CCBC", Offset = "0xD5CCBC")]
		public Transform[] handVisuals;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5CD1C", Offset = "0xD5CD1C")]
		public bool useGrabTransition;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "EnableIfAttribute", RVA = "0xD5CD54", Offset = "0xD5CD54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5CD54", Offset = "0xD5CD54")]
		public float grabTransitionOffset;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "EnableIfAttribute", RVA = "0xD5CDB4", Offset = "0xD5CDB4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5CDB4", Offset = "0xD5CDB4")]
		public float grabDistanceMultiplyer;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5CE14", Offset = "0xD5CE14")]
		[AttributeAttribute(Name = "EnableIfAttribute", RVA = "0xD5CE14", Offset = "0xD5CE14")]
		public float grabTransitionMultiplyer;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "DisableIfAttribute", RVA = "0xD5CE74", Offset = "0xD5CE74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5CE74", Offset = "0xD5CE74")]
		public float grabPercent;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5CED4", Offset = "0xD5CED4")]
		public UnityHandGrabEvent OnStartProjection;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public UnityHandGrabEvent OnEndProjection;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private HandPoseData lastProjectionPose;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private HandPoseData newProjectionPose;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastProjectionPosition;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion lastProjectionRotation;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Grabbable target;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private float startMass;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private float minGrabTime;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private float currAmount;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool tryingGrab;

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x1CA4288", Offset = "0x1CA4288", VA = "0x1CA4288")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1CA4628", Offset = "0x1CA4628", VA = "0x1CA4628")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1CA5484", Offset = "0x1CA5484", VA = "0x1CA5484")]
		private void OnTriggerGrab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1CA5490", Offset = "0x1CA5490", VA = "0x1CA5490")]
		private void OnBeforeGrab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1CA55B4", Offset = "0x1CA55B4", VA = "0x1CA55B4")]
		private void OnGrab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x1CA55D8", Offset = "0x1CA55D8", VA = "0x1CA55D8")]
		private void OnRelease(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1CA57FC", Offset = "0x1CA57FC", VA = "0x1CA57FC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1CA5C64", Offset = "0x1CA5C64", VA = "0x1CA5C64")]
		private void OnProjectionStart(Hand projectionHand, Grabbable target)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1CA5CDC", Offset = "0x1CA5CDC", VA = "0x1CA5CDC")]
		private void OnProjectionEnd(Hand projectionHand, Grabbable target)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1CA4790", Offset = "0x1CA4790", VA = "0x1CA4790")]
		private void ShowProjection(bool show)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1CA5868", Offset = "0x1CA5868", VA = "0x1CA5868")]
		private void SetTarget(Grabbable newTarget)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1CA5B88", Offset = "0x1CA5B88", VA = "0x1CA5B88")]
		private bool IsProjectionActive()
		{
			return default(bool);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1CA5D54", Offset = "0x1CA5D54", VA = "0x1CA5D54")]
		public HandProjector()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class HandPublicEvents : MonoBehaviour
	{
		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Hand hand;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityHandGrabEvent OnBeforeGrab;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityHandGrabEvent OnGrab;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityHandGrabEvent OnRelease;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UnityHandGrabEvent OnForceRelease;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityHandGrabEvent OnSqueeze;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UnityHandGrabEvent OnUnsqueeze;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityHandGrabEvent OnHighlight;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UnityHandGrabEvent OnStopHighlight;

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1CA5D74", Offset = "0x1CA5D74", VA = "0x1CA5D74")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1CA5F9C", Offset = "0x1CA5F9C", VA = "0x1CA5F9C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1CA61C4", Offset = "0x1CA61C4", VA = "0x1CA61C4")]
		public void OnBeforeGrabEvent(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x1CA623C", Offset = "0x1CA623C", VA = "0x1CA623C")]
		public void OnGrabEvent(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1CA62B4", Offset = "0x1CA62B4", VA = "0x1CA62B4")]
		public void OnReleaseEvent(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1CA632C", Offset = "0x1CA632C", VA = "0x1CA632C")]
		public void OnSqueezeEvent(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1CA63A4", Offset = "0x1CA63A4", VA = "0x1CA63A4")]
		public void OnUnsqueezeEvent(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1CA641C", Offset = "0x1CA641C", VA = "0x1CA641C")]
		public void OnHighlightEvent(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1CA6494", Offset = "0x1CA6494", VA = "0x1CA6494")]
		public void OnStopHighlightEvent(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1CA650C", Offset = "0x1CA650C", VA = "0x1CA650C")]
		public void OnForceReleaseEvent(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1CA6584", Offset = "0x1CA6584", VA = "0x1CA6584")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x1CA6660", Offset = "0x1CA6660", VA = "0x1CA6660")]
		public HandPublicEvents()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0xD59344", Offset = "0xD59344")]
	public class HandTeleportGuard : MonoBehaviour
	{
		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5CF0C", Offset = "0xD5CF0C")]
		public Hand hand;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5CF44", Offset = "0xD5CF44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5CF44", Offset = "0xD5CF44")]
		public LayerMask ignoreMask;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5CFA4", Offset = "0xD5CFA4")]
		public float buffer;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5CFDC", Offset = "0xD5CFDC")]
		public bool alwaysRun;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xD5D014", Offset = "0xD5D014")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5D014", Offset = "0xD5D014")]
		public bool ignoreMaxHandDistance;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 deltaHandPos;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 deltaHandFixedPos;

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x1CA6E80", Offset = "0x1CA6E80", VA = "0x1CA6E80")]
		private void Awake()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x1CA71E4", Offset = "0x1CA71E4", VA = "0x1CA71E4")]
		private void Update()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x1CA7644", Offset = "0x1CA7644", VA = "0x1CA7644")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x1CA7344", Offset = "0x1CA7344", VA = "0x1CA7344")]
		public void TeleportProtection(Vector3 fromPos, Vector3 toPos)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1CA77A4", Offset = "0x1CA77A4", VA = "0x1CA77A4")]
		public HandTeleportGuard()
		{
		}
	}
	[Token(Token = "0x200004F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD59358", Offset = "0xD59358")]
	public class HandTouchEvent : MonoBehaviour
	{
		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5D074", Offset = "0xD5D074")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5D074", Offset = "0xD5D074")]
		public bool oneHanded;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public HandType handType;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5D0D4", Offset = "0xD5D0D4")]
		public UnityHandEvent HandStartTouch;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityHandEvent HandStopTouch;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HandEvent HandStartTouchEvent;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public HandEvent HandStopTouchEvent;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Hand> hands;

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x1CA7C5C", Offset = "0x1CA7C5C", VA = "0x1CA7C5C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1CA7D9C", Offset = "0x1CA7D9C", VA = "0x1CA7D9C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1CA7E9C", Offset = "0x1CA7E9C", VA = "0x1CA7E9C")]
		public void Touch(Hand hand)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1CA7FA8", Offset = "0x1CA7FA8", VA = "0x1CA7FA8")]
		public void Untouch(Hand hand)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1CA8110", Offset = "0x1CA8110", VA = "0x1CA8110")]
		public HandTouchEvent()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1CA8120", Offset = "0x1CA8120", VA = "0x1CA8120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60388", Offset = "0xD60388")]
		private void <OnEnable>b__6_0(Hand hand)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1CA8190", Offset = "0x1CA8190", VA = "0x1CA8190")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60398", Offset = "0xD60398")]
		private void <OnEnable>b__6_1(Hand hand)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x1CA8200", Offset = "0x1CA8200", VA = "0x1CA8200")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD603A8", Offset = "0xD603A8")]
		private void <OnDisable>b__7_0(Hand hand)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1CA8270", Offset = "0x1CA8270", VA = "0x1CA8270")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD603B8", Offset = "0xD603B8")]
		private void <OnDisable>b__7_1(Hand hand)
		{
		}
	}
	[Token(Token = "0x2000050")]
	public delegate void HandEvent(Hand hand);
	[Token(Token = "0x2000051")]
	public class HandTriggerAreaEvents : MonoBehaviour
	{
		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5D10C", Offset = "0xD5D10C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5D10C", Offset = "0xD5D10C")]
		public bool oneHanded;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public HandType handType;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5D16C", Offset = "0xD5D16C")]
		public bool exitTriggerRelease;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5D1A4", Offset = "0xD5D1A4")]
		public bool exitTriggerUnsqueeze;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5D1DC", Offset = "0xD5D1DC")]
		public UnityHandEvent HandEnter;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityHandEvent HandExit;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UnityHandEvent HandGrab;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityHandEvent HandRelease;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UnityHandEvent HandSqueeze;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityHandEvent HandUnsqueeze;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public HandEvent HandEnterEvent;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public HandEvent HandExitEvent;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public HandEvent HandGrabEvent;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public HandEvent HandReleaseEvent;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public HandEvent HandSqueezeEvent;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public HandEvent HandUnsqueezeEvent;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<Hand> hands;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool grabbing;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		private bool squeezing;

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1CA8660", Offset = "0x1CA8660", VA = "0x1CA8660", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1CA8900", Offset = "0x1CA8900", VA = "0x1CA8900", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x1CA8BE0", Offset = "0x1CA8BE0", VA = "0x1CA8BE0", Slot = "6")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x1CA8D38", Offset = "0x1CA8D38", VA = "0x1CA8D38", Slot = "7")]
		public virtual void Enter(Hand hand)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x1CA8E48", Offset = "0x1CA8E48", VA = "0x1CA8E48", Slot = "8")]
		public virtual void Exit(Hand hand)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1CA90A0", Offset = "0x1CA90A0", VA = "0x1CA90A0", Slot = "9")]
		public virtual void Grab(Hand hand)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1CA91B8", Offset = "0x1CA91B8", VA = "0x1CA91B8", Slot = "10")]
		public virtual void Release(Hand hand)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x1CA92CC", Offset = "0x1CA92CC", VA = "0x1CA92CC", Slot = "11")]
		public virtual void Squeeze(Hand hand)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1CA940C", Offset = "0x1CA940C", VA = "0x1CA940C", Slot = "12")]
		public virtual void Unsqueeze(Hand hand)
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1CA9544", Offset = "0x1CA9544", VA = "0x1CA9544")]
		public HandTriggerAreaEvents()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1CA955C", Offset = "0x1CA955C", VA = "0x1CA955C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD603C8", Offset = "0xD603C8")]
		private void <OnEnable>b__19_0(Hand hand)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x1CA95CC", Offset = "0x1CA95CC", VA = "0x1CA95CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD603D8", Offset = "0xD603D8")]
		private void <OnEnable>b__19_1(Hand hand)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x1CA963C", Offset = "0x1CA963C", VA = "0x1CA963C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD603E8", Offset = "0xD603E8")]
		private void <OnEnable>b__19_2(Hand hand)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x1CA96AC", Offset = "0x1CA96AC", VA = "0x1CA96AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD603F8", Offset = "0xD603F8")]
		private void <OnEnable>b__19_3(Hand hand)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1CA971C", Offset = "0x1CA971C", VA = "0x1CA971C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60408", Offset = "0xD60408")]
		private void <OnEnable>b__19_4(Hand hand)
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x1CA978C", Offset = "0x1CA978C", VA = "0x1CA978C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60418", Offset = "0xD60418")]
		private void <OnEnable>b__19_5(Hand hand)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x1CA97FC", Offset = "0x1CA97FC", VA = "0x1CA97FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60428", Offset = "0xD60428")]
		private void <OnDisable>b__20_0(Hand hand)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1CA986C", Offset = "0x1CA986C", VA = "0x1CA986C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60438", Offset = "0xD60438")]
		private void <OnDisable>b__20_1(Hand hand)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1CA98DC", Offset = "0x1CA98DC", VA = "0x1CA98DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60448", Offset = "0xD60448")]
		private void <OnDisable>b__20_2(Hand hand)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x1CA994C", Offset = "0x1CA994C", VA = "0x1CA994C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60458", Offset = "0xD60458")]
		private void <OnDisable>b__20_3(Hand hand)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x1CA99BC", Offset = "0x1CA99BC", VA = "0x1CA99BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60468", Offset = "0xD60468")]
		private void <OnDisable>b__20_4(Hand hand)
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x1CA9A2C", Offset = "0x1CA9A2C", VA = "0x1CA9A2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60478", Offset = "0xD60478")]
		private void <OnDisable>b__20_5(Hand hand)
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class EditorHand : MonoBehaviour
	{
		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool useEditorGUI;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GrabbablePose grabbablePose;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HandPoseArea grabbablePoseArea;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Hand _hand;

		[Token(Token = "0x17000024")]
		public Hand hand
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x233E2A8", Offset = "0x233E2A8", VA = "0x233E2A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x233E348", Offset = "0x233E348", VA = "0x233E348")]
		public EditorHand()
		{
		}
	}
	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0xD59390", Offset = "0xD59390")]
	public class GrabbableBase : MonoBehaviour
	{
		[StructLayout(3)]
		[Token(Token = "0x2000054")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD593A4", Offset = "0xD593A4")]
		private struct <>c__DisplayClass38_0
		{
			[Token(Token = "0x400027C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int oldLayer;

			[Token(Token = "0x400027D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int newLayer;
		}

		[Token(Token = "0x2000055")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD593B4", Offset = "0xD593B4")]
		private sealed class <IgnoreHandCollision>d__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400027E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400027F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000280")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GrabbableBase <>4__this;

			[Token(Token = "0x4000281")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Hand hand;

			[Token(Token = "0x4000282")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float time;

			[Token(Token = "0x17000027")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000292")]
				[Address(RVA = "0x22618D0", Offset = "0x22618D0", VA = "0x22618D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000028")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000294")]
				[Address(RVA = "0x2261918", Offset = "0x2261918", VA = "0x2261918", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600028F")]
			[Address(RVA = "0x22617B4", Offset = "0x22617B4", VA = "0x22617B4")]
			[DebuggerHidden]
			public <IgnoreHandCollision>d__40(int <>1__state)
			{
			}

			[Token(Token = "0x6000290")]
			[Address(RVA = "0x22617E0", Offset = "0x22617E0", VA = "0x22617E0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000291")]
			[Address(RVA = "0x22617E4", Offset = "0x22617E4", VA = "0x22617E4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000293")]
			[Address(RVA = "0x22618D8", Offset = "0x22618D8", VA = "0x22618D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "AutoHeaderAttribute", RVA = "0xD5D214", Offset = "0xD5D214")]
		public bool ignoreMe;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5D254", Offset = "0xD5D254")]
		public Rigidbody body;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5D28C", Offset = "0xD5D28C")]
		public Material hightlightMaterial;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public bool isGrabbable;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PlacePoint _placePoint;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal bool ignoreParent;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected List<Hand> heldBy;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected bool hightlighting;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected GameObject highlightObj;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected PlacePoint lastPlacePoint;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected Transform originalParent;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected Vector3 lastCenterOfMassPos;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		protected Quaternion lastCenterOfMassRot;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		protected CollisionDetectionMode detectionMode;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected RigidbodyInterpolation startInterpolation;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		protected internal bool beingGrabbed;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
		protected bool heldBodyJointed;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x96")]
		protected bool wasIsGrabbable;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x97")]
		protected bool beingDestroyed;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected int originalLayer;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		protected Coroutine resetLayerRoutine;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		protected List<GrabbableChild> grabChildren;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected List<Transform> jointedParents;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected GrabbablePoseCombiner poseCombiner;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private CollisionTracker _collisionTracker;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected List<Collider> grabColliders;

		[Token(Token = "0x17000025")]
		public PlacePoint placePoint
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x2343EF4", Offset = "0x2343EF4", VA = "0x2343EF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x2343EFC", Offset = "0x2343EFC", VA = "0x2343EFC")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public CollisionTracker collisionTracker
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x2341E7C", Offset = "0x2341E7C", VA = "0x2341E7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x2343F04", Offset = "0x2343F04", VA = "0x2343F04")]
			protected set
			{
			}
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x23403C0", Offset = "0x23403C0", VA = "0x23403C0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x23440D4", Offset = "0x23440D4", VA = "0x23440D4", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x234078C", Offset = "0x234078C", VA = "0x234078C", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x2344368", Offset = "0x2344368", VA = "0x2344368", Slot = "7")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x2344398", Offset = "0x2344398", VA = "0x2344398")]
		internal void SetPlacePoint(PlacePoint point)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x23443A0", Offset = "0x23443A0", VA = "0x23443A0")]
		internal void SetGrabbableChild(GrabbableChild child)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x2344440", Offset = "0x2344440", VA = "0x2344440")]
		protected int GetOriginalLayer()
		{
			return default(int);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x2344448", Offset = "0x2344448", VA = "0x2344448")]
		internal void SetLayerRecursive(Transform obj, int oldLayer, int newLayer)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x2344620", Offset = "0x2344620", VA = "0x2344620")]
		internal void SetLayerRecursive(Transform obj, int newLayer)
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x23419E0", Offset = "0x23419E0", VA = "0x23419E0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD60488", Offset = "0xD60488")]
		protected IEnumerator IgnoreHandCollision(float time, Hand hand)
		{
			return null;
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x234467C", Offset = "0x234467C", VA = "0x234467C")]
		public bool GetSavedPose(out GrabbablePoseCombiner pose)
		{
			return default(bool);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x23446D0", Offset = "0x23446D0", VA = "0x23446D0")]
		public bool HasCustomPose()
		{
			return default(bool);
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x23446FC", Offset = "0x23446FC", VA = "0x23446FC")]
		public void IgnoreHand(Hand hand, bool ignore)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x2343FB0", Offset = "0x2343FB0", VA = "0x2343FB0")]
		private void SetCollidersRecursive(Transform obj)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x2343B88", Offset = "0x2343B88", VA = "0x2343B88")]
		protected void ResetRigidbody()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x2344830", Offset = "0x2344830", VA = "0x2344830")]
		public bool BeingDestroyed()
		{
			return default(bool);
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x2344838", Offset = "0x2344838", VA = "0x2344838")]
		public void DebugBreak()
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x2343DB4", Offset = "0x2343DB4", VA = "0x2343DB4")]
		public GrabbableBase()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x23441BC", Offset = "0x23441BC", VA = "0x23441BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD604E8", Offset = "0xD604E8")]
		private void <Start>g__GetPoseSaves|32_0(Transform obj)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x234456C", Offset = "0x234456C", VA = "0x234456C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD604F8", Offset = "0xD604F8")]
		internal static void <SetLayerRecursive>g__SetChildrenLayers|38_0(Transform obj1, ref <>c__DisplayClass38_0 P_1)
		{
		}
	}
	[Token(Token = "0x2000056")]
	public enum HandMovementType
	{
		[Token(Token = "0x4000284")]
		Legacy,
		[Token(Token = "0x4000285")]
		Forces
	}
	[Token(Token = "0x2000057")]
	public enum HandType
	{
		[Token(Token = "0x4000287")]
		both,
		[Token(Token = "0x4000288")]
		right,
		[Token(Token = "0x4000289")]
		left,
		[Token(Token = "0x400028A")]
		none
	}
	[Token(Token = "0x2000058")]
	public enum GrabType
	{
		[Token(Token = "0x400028C")]
		HandToGrabbable,
		[Token(Token = "0x400028D")]
		GrabbableToHand,
		[Token(Token = "0x400028E")]
		InstantGrab
	}
	[Serializable]
	[Token(Token = "0x2000059")]
	public struct VelocityTimePair
	{
		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float time;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Vector3 velocity;
	}
	[Token(Token = "0x200005A")]
	public delegate void HandGrabEvent(Hand hand, Grabbable grabbable);
	[Token(Token = "0x200005B")]
	public delegate void HandGameObjectEvent(Hand hand, GameObject other);
	[Serializable]
	[Token(Token = "0x200005C")]
	public class UnityHandGrabEvent : UnityEvent<Hand, Grabbable>
	{
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x225D4CC", Offset = "0x225D4CC", VA = "0x225D4CC")]
		public UnityHandGrabEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005D")]
	public class UnityHandEvent : UnityEvent<Hand>
	{
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x225D480", Offset = "0x225D480", VA = "0x225D480")]
		public UnityHandEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005E")]
	[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0xD593C4", Offset = "0xD593C4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD593C4", Offset = "0xD593C4")]
	public class HandBase : MonoBehaviour
	{
		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "AutoHeaderAttribute", RVA = "0xD5D2D4", Offset = "0xD5D2D4")]
		public bool ignoreMe;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Finger[] fingers;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5D314", Offset = "0xD5D314")]
		public Transform palmTransform;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xD5D34C", Offset = "0xD5D34C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5D34C", Offset = "0xD5D34C")]
		public bool left;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD5D3AC", Offset = "0xD5D3AC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5D3AC", Offset = "0xD5D3AC")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xD5D3AC", Offset = "0xD5D3AC")]
		public float reachDistance;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "AutoToggleHeaderAttribute", RVA = "0xD5D410", Offset = "0xD5D410")]
		public bool enableMovement;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "EnableIfAttribute", RVA = "0xD5D464", Offset = "0xD5D464")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5D464", Offset = "0xD5D464")]
		public Transform follow;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5D4C4", Offset = "0xD5D4C4")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xD5D4C4", Offset = "0xD5D4C4")]
		[AttributeAttribute(Name = "EnableIfAttribute", RVA = "0xD5D4C4", Offset = "0xD5D4C4")]
		public float maxFollowDistance;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "EnableIfAttribute", RVA = "0xD5D538", Offset = "0xD5D538")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xD5D538", Offset = "0xD5D538")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5D538", Offset = "0xD5D538")]
		public float throwPower;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public bool advancedFollowSettings;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		[AttributeAttribute(Name = "AutoToggleHeaderAttribute", RVA = "0xD5D5BC", Offset = "0xD5D5BC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5D5BC", Offset = "0xD5D5BC")]
		public bool enableIK;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "EnableIfAttribute", RVA = "0xD5D634", Offset = "0xD5D634")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5D634", Offset = "0xD5D634")]
		public float swayStrength;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5D694", Offset = "0xD5D694")]
		[AttributeAttribute(Name = "EnableIfAttribute", RVA = "0xD5D694", Offset = "0xD5D694")]
		public float gripOffset;

		[NonSerialized]
		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5D6F4", Offset = "0xD5D6F4")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xD5D6F4", Offset = "0xD5D6F4")]
		public float maxVelocity;

		[NonSerialized]
		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xD5D744", Offset = "0xD5D744")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5D744", Offset = "0xD5D744")]
		public float followPositionStrength;

		[NonSerialized]
		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xD5D794", Offset = "0xD5D794")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5D794", Offset = "0xD5D794")]
		[HideInInspector]
		public float followRotationStrength;

		[NonSerialized]
		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5D7F4", Offset = "0xD5D7F4")]
		[HideInInspector]
		public float throwVelocityExpireTime;

		[NonSerialized]
		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[HideInInspector]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5D840", Offset = "0xD5D840")]
		public int fingerBendSteps;

		[NonSerialized]
		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public float sphereCastRadius;

		[NonSerialized]
		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[HideInInspector]
		public float maxCollisionDistance;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public bool usingPoseAreas;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[HideInInspector]
		public QueryTriggerInteraction queryTriggerInteraction;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Grabbable HoldingObj;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Grabbable _lookingAtObj;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Transform _moveTo;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5D8CC", Offset = "0xD5D8CC")]
		private Rigidbody <body>k__BackingField;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 _grabPositionOffset;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Quaternion _grabRotationOffset;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private CollisionTracker _collisionTracker;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected GrabbablePose _grabPose;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		protected Joint heldJoint;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected bool grabbing;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		protected bool squeezing;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDA")]
		protected bool grabbed;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		protected float triggerPoint;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		protected Coroutine handAnimateRoutine;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		protected HandPoseArea handPoseArea;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected HandPoseData preHandPoseAreaPose;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		protected List<Collider> handColliders;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Transform _grabPoint;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Transform _grabPosition;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		internal int handLayers;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		protected Collider palmCollider;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		protected RaycastHit highlightHit;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		protected HandVelocityTracker velocityTracker;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		protected Transform palmChild;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		protected Vector3 lastFrameFollowPos;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		protected Quaternion lastFrameFollowRot;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		protected Vector3 followVel;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		protected Vector3 followAngularVel;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		internal bool allowUpdateMovement;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Vector3[] handRays;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private RaycastHit[] rayHits;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private List<RaycastHit> closestHits;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private List<Grabbable> closestGrabs;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private int tryMaxDistanceCount;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
		private Vector3 lastFollowPosition;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Vector3 lastFollowRotation;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private bool prerendered;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private Vector3 preRenderPos;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
		private Quaternion preRenderRot;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		private float currGrip;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		protected Vector3 lastFixedPosition;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x234")]
		private float lastUpdateTime;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		protected bool ignoreMoveFrame;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
		private float fingerSwayVel;

		[Token(Token = "0x17000029")]
		public Grabbable holdingObj
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x23DAC94", Offset = "0x23DAC94", VA = "0x23DAC94")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x23DAC9C", Offset = "0x23DAC9C", VA = "0x23DAC9C")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public Grabbable lookingAtObj
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x23DACA4", Offset = "0x23DACA4", VA = "0x23DACA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x23DACAC", Offset = "0x23DACAC", VA = "0x23DACAC")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public Transform moveTo
		{
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x23D8D34", Offset = "0x23D8D34", VA = "0x23D8D34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public Rigidbody body
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x23DACB4", Offset = "0x23DACB4", VA = "0x23DACB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60558", Offset = "0xD60558")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x23DACBC", Offset = "0x23DACBC", VA = "0x23DACBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60568", Offset = "0xD60568")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public Vector3 grabPositionOffset
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x23DACC4", Offset = "0x23DACC4", VA = "0x23DACC4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x23DACD0", Offset = "0x23DACD0", VA = "0x23DACD0")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public Quaternion grabRotationOffset
		{
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x23DACDC", Offset = "0x23DACDC", VA = "0x23DACDC")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x23DACE8", Offset = "0x23DACE8", VA = "0x23DACE8")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public bool disableIK
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x23DACF4", Offset = "0x23DACF4", VA = "0x23DACF4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x23DAD04", Offset = "0x23DAD04", VA = "0x23DAD04")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public CollisionTracker collisionTracker
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x23D50DC", Offset = "0x23D50DC", VA = "0x23D50DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x23DAD14", Offset = "0x23DAD14", VA = "0x23DAD14")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000031")]
		protected GrabbablePose grabPose
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x23DADC0", Offset = "0x23DADC0", VA = "0x23DADC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x23D774C", Offset = "0x23D774C", VA = "0x23D774C")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		internal Transform grabPoint
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x23D7D34", Offset = "0x23D7D34", VA = "0x23D7D34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		internal Transform grabPosition
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x23D7E48", Offset = "0x23D7E48", VA = "0x23D7E48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x23D48E0", Offset = "0x23D48E0", VA = "0x23D48E0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x23D50B0", Offset = "0x23D50B0", VA = "0x23D50B0", Slot = "5")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x23D5568", Offset = "0x23D5568", VA = "0x23D5568", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x23DAE34", Offset = "0x23DAE34", VA = "0x23DAE34", Slot = "7")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x23DB004", Offset = "0x23DB004", VA = "0x23DB004", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x23D59F4", Offset = "0x23D59F4", VA = "0x23D59F4", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x23DB330", Offset = "0x23DB330", VA = "0x23DB330", Slot = "10")]
		public virtual void OnPreRender()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x23DB9DC", Offset = "0x23DB9DC", VA = "0x23DB9DC", Slot = "11")]
		public virtual void OnPostRender()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x23DBAF4", Offset = "0x23DBAF4", VA = "0x23DBAF4", Slot = "12")]
		protected virtual void CreateJoint(Grabbable grab, float breakForce, float breakTorque)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x23DBDF8", Offset = "0x23DBDF8", VA = "0x23DBDF8", Slot = "13")]
		protected virtual void MoveTo()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x23DC660", Offset = "0x23DC660", VA = "0x23DC660", Slot = "14")]
		protected virtual void TorqueTo()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x23DC810", Offset = "0x23DC810", VA = "0x23DC810", Slot = "15")]
		public virtual void SetHandLocation(Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x23DCEF8", Offset = "0x23DCEF8", VA = "0x23DCEF8", Slot = "16")]
		public virtual void SetHandLocation(Vector3 pos)
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x23DCF94", Offset = "0x23DCF94", VA = "0x23DCF94")]
		public void ResetHandLocation()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x23DC278", Offset = "0x23DC278", VA = "0x23DC278")]
		protected void SetMoveTo()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x23D664C", Offset = "0x23D664C", VA = "0x23D664C")]
		public bool CanGrab(Grabbable grab)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x23DD030", Offset = "0x23DD030", VA = "0x23DD030")]
		public float GetTriggerAxis()
		{
			return default(float);
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x23DD038", Offset = "0x23DD038", VA = "0x23DD038", Slot = "17")]
		protected virtual Vector3 HandClosestHit(out RaycastHit closestHit, out Grabbable grabbable, float dist, int layerMask, [Optional] Grabbable target)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x23DD91C", Offset = "0x23DD91C", VA = "0x23DD91C")]
		public bool IsPosing()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x23DD9F4", Offset = "0x23DD9F4", VA = "0x23DD9F4", Slot = "18")]
		protected virtual void UpdateFingers()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x23DB260", Offset = "0x23DB260", VA = "0x23DB260")]
		public int CollisionCount()
		{
			return default(int);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x23DAB60", Offset = "0x23DAB60", VA = "0x23DAB60")]
		public void HandIgnoreCollider(Collider collider, bool ignore)
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x23D4CA4", Offset = "0x23D4CA4", VA = "0x23D4CA4")]
		public void SetLayer()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x23D6DC8", Offset = "0x23D6DC8", VA = "0x23D6DC8")]
		internal void SetLayerRecursive(Transform obj, int newLayer)
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x23DADC8", Offset = "0x23DADC8", VA = "0x23DADC8")]
		protected void SetHandCollidersRecursive(Transform obj)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x23DDC24", Offset = "0x23DDC24", VA = "0x23DDC24")]
		public Vector3[] GetPalmRays()
		{
			return null;
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x23DDC54", Offset = "0x23DDC54", VA = "0x23DDC54", Slot = "19")]
		protected virtual void SetPalmRays()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x23DDE54", Offset = "0x23DDE54", VA = "0x23DDE54")]
		public Vector3 ThrowVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x23DDE70", Offset = "0x23DDE70", VA = "0x23DDE70")]
		public Vector3 ThrowAngularVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x23DDE8C", Offset = "0x23DDE8C", VA = "0x23DDE8C")]
		public bool IsGrabbing()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x23DDE94", Offset = "0x23DDE94", VA = "0x23DDE94")]
		public static int GetHandsLayerMask()
		{
			return default(int);
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x23DA3A8", Offset = "0x23DA3A8", VA = "0x23DA3A8")]
		public HandBase()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x23DDB00", Offset = "0x23DDB00", VA = "0x23DDB00")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60578", Offset = "0xD60578")]
		private void <SetHandCollidersRecursive>g__AddHandCol|120_0(Transform obj1)
		{
		}
	}
	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD59438", Offset = "0xD59438")]
	public class HandGizmos : MonoBehaviour
	{
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1CA20F0", Offset = "0x1CA20F0", VA = "0x1CA20F0")]
		public HandGizmos()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000060")]
	public struct HandPoseData
	{
		[StructLayout(3)]
		[Token(Token = "0x2000061")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD59498", Offset = "0xD59498")]
		private struct <>c__DisplayClass9_0
		{
			[Token(Token = "0x40002D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public List<Vector3> posePositionsList;

			[Token(Token = "0x40002D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public List<Quaternion> poseRotationsList;
		}

		[StructLayout(3)]
		[Token(Token = "0x2000062")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD594A8", Offset = "0xD594A8")]
		private struct <>c__DisplayClass11_0
		{
			[Token(Token = "0x40002DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int i;
		}

		[StructLayout(3)]
		[Token(Token = "0x2000063")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD594B8", Offset = "0xD594B8")]
		private struct <>c__DisplayClass12_0
		{
			[Token(Token = "0x40002DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int i;
		}

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 handOffset;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 rotationOffset;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Quaternion localQuaternionOffset;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3[] posePositions;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Quaternion[] poseRotations;

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1CA2E34", Offset = "0x1CA2E34", VA = "0x1CA2E34")]
		public HandPoseData(Hand hand, Grabbable grabbable)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x1CA3334", Offset = "0x1CA3334", VA = "0x1CA3334")]
		public HandPoseData(Hand hand, Transform point)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1CA33F0", Offset = "0x1CA33F0", VA = "0x1CA33F0")]
		public HandPoseData(Hand hand)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1CA34A8", Offset = "0x1CA34A8", VA = "0x1CA34A8")]
		public HandPoseData(HandPoseData data)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x1CA2F04", Offset = "0x1CA2F04", VA = "0x1CA2F04")]
		public void SavePose(Hand hand, Transform relativeTo)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1CA3674", Offset = "0x1CA3674", VA = "0x1CA3674")]
		public Quaternion GetRotationOffset()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1CA29E0", Offset = "0x1CA29E0", VA = "0x1CA29E0")]
		public void SetPose(Hand hand, [Optional] Transform relativeTo)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x1CA3814", Offset = "0x1CA3814", VA = "0x1CA3814")]
		public void SetFingerPose(Hand hand, [Optional] Transform relativeTo)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1CA39E8", Offset = "0x1CA39E8", VA = "0x1CA39E8")]
		public void SetPosition(Hand hand, [Optional] Transform relativeTo)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1CA3C34", Offset = "0x1CA3C34", VA = "0x1CA3C34")]
		public static HandPoseData LerpPose(HandPoseData from, HandPoseData to, float point)
		{
			return default(HandPoseData);
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x1CA3ECC", Offset = "0x1CA3ECC", VA = "0x1CA3ECC")]
		public static void LerpPose(ref HandPoseData lerpPose, HandPoseData from, HandPoseData to, float point)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1CA3598", Offset = "0x1CA3598", VA = "0x1CA3598")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60588", Offset = "0xD60588")]
		internal static void <SavePose>g__AssignChildrenPose|9_0(Transform obj, ref <>c__DisplayClass9_0 P_1)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1CA4120", Offset = "0x1CA4120", VA = "0x1CA4120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60598", Offset = "0xD60598")]
		internal static void <SavePose>g__AddPoint|9_1(Vector3 pos, Quaternion rot, ref <>c__DisplayClass9_0 P_2)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1CA36F8", Offset = "0x1CA36F8", VA = "0x1CA36F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD605A8", Offset = "0xD605A8")]
		internal static void <SetPose>g__AssignChildrenPose|11_0(Transform obj, HandPoseData pose, ref <>c__DisplayClass11_0 P_2)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1CA38CC", Offset = "0x1CA38CC", VA = "0x1CA38CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD605B8", Offset = "0xD605B8")]
		internal static void <SetFingerPose>g__AssignChildrenPose|12_0(Transform obj, HandPoseData pose, ref <>c__DisplayClass12_0 P_2)
		{
		}
	}
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xD594C8", Offset = "0xD594C8")]
	public class HandPoseScriptable : ScriptableObject
	{
		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public bool rightSaved;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[HideInInspector]
		public bool leftSaved;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HandPoseData rightPose;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public HandPoseData leftPose;

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1CA41F0", Offset = "0x1CA41F0", VA = "0x1CA41F0")]
		public void SavePoses(HandPoseData right, HandPoseData left)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1CA4234", Offset = "0x1CA4234", VA = "0x1CA4234")]
		public void SaveRightPose(HandPoseData right)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1CA4258", Offset = "0x1CA4258", VA = "0x1CA4258")]
		public void SaveLeftPose(HandPoseData left)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1CA4280", Offset = "0x1CA4280", VA = "0x1CA4280")]
		public HandPoseScriptable()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0xD5951C", Offset = "0xD5951C")]
	public class HandStabilizer : MonoBehaviour
	{
		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HandBase hand;

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x1CA6774", Offset = "0x1CA6774", VA = "0x1CA6774")]
		private void Start()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x1CA6834", Offset = "0x1CA6834", VA = "0x1CA6834")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1CA6994", Offset = "0x1CA6994", VA = "0x1CA6994")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1CA6AF4", Offset = "0x1CA6AF4", VA = "0x1CA6AF4")]
		private void Update()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1CA6B80", Offset = "0x1CA6B80", VA = "0x1CA6B80")]
		private void OnPreRender()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x1CA6BDC", Offset = "0x1CA6BDC", VA = "0x1CA6BDC")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x1CA6C38", Offset = "0x1CA6C38", VA = "0x1CA6C38")]
		private void OnPreRender(ScriptableRenderContext src, Camera cam)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x1CA6C94", Offset = "0x1CA6C94", VA = "0x1CA6C94")]
		private void OnPostRender(ScriptableRenderContext src, Camera cam)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x1CA6CF0", Offset = "0x1CA6CF0", VA = "0x1CA6CF0")]
		public HandStabilizer()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class HandVelocityTracker
	{
		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandBase hand;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float minThrowVelocity;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected List<VelocityTimePair> m_ThrowVelocityList;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected List<VelocityTimePair> m_ThrowFrameVelocityList;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected List<VelocityTimePair> m_ThrowAngleVelocityList;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float disableTime;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float disableSeconds;

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1CA9A9C", Offset = "0x1CA9A9C", VA = "0x1CA9A9C")]
		public void ClearThrow()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1CA9B10", Offset = "0x1CA9B10", VA = "0x1CA9B10")]
		public void Disable(float seconds)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x1CA9B48", Offset = "0x1CA9B48", VA = "0x1CA9B48")]
		public HandVelocityTracker(HandBase hand)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x1CA9C0C", Offset = "0x1CA9C0C", VA = "0x1CA9C0C")]
		public void UpdateThrowing()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x1CA9F30", Offset = "0x1CA9F30", VA = "0x1CA9F30")]
		public Vector3 ThrowVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x1CAA2C8", Offset = "0x1CAA2C8", VA = "0x1CAA2C8")]
		public Vector3 ThrowAngularVelocity()
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000067")]
	public class KeyboardHand : MonoBehaviour
	{
		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Hand hand;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float speed;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float flySpeed;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool useLocal;

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x1CAC28C", Offset = "0x1CAC28C", VA = "0x1CAC28C")]
		private void Update()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x1CAC5B0", Offset = "0x1CAC5B0", VA = "0x1CAC5B0")]
		public KeyboardHand()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD59530", Offset = "0xD59530")]
	[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0xD59530", Offset = "0xD59530")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD59530", Offset = "0xD59530")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD59530", Offset = "0xD59530")]
	public class AutoHandPlayer : MonoBehaviour
	{
		[Token(Token = "0x2000069")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD595FC", Offset = "0xD595FC")]
		private sealed class <CheckForTrackingStart>d__83 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400033B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400033C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400033D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AutoHandPlayer <>4__this;

			[Token(Token = "0x17000036")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600032E")]
				[Address(RVA = "0x2261624", Offset = "0x2261624", VA = "0x2261624", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000037")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000330")]
				[Address(RVA = "0x226166C", Offset = "0x226166C", VA = "0x226166C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600032B")]
			[Address(RVA = "0x226142C", Offset = "0x226142C", VA = "0x226142C")]
			[DebuggerHidden]
			public <CheckForTrackingStart>d__83(int <>1__state)
			{
			}

			[Token(Token = "0x600032C")]
			[Address(RVA = "0x2261458", Offset = "0x2261458", VA = "0x2261458", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600032D")]
			[Address(RVA = "0x226145C", Offset = "0x226145C", VA = "0x226145C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600032F")]
			[Address(RVA = "0x226162C", Offset = "0x226162C", VA = "0x226162C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200006A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5960C", Offset = "0xD5960C")]
		private sealed class <DisableGroundingSecondsRoutine>d__111 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400033E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400033F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000340")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AutoHandPlayer <>4__this;

			[Token(Token = "0x4000341")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float seconds;

			[Token(Token = "0x17000038")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000334")]
				[Address(RVA = "0x2261764", Offset = "0x2261764", VA = "0x2261764", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000039")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000336")]
				[Address(RVA = "0x22617AC", Offset = "0x22617AC", VA = "0x22617AC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000331")]
			[Address(RVA = "0x2261674", Offset = "0x2261674", VA = "0x2261674")]
			[DebuggerHidden]
			public <DisableGroundingSecondsRoutine>d__111(int <>1__state)
			{
			}

			[Token(Token = "0x6000332")]
			[Address(RVA = "0x22616A0", Offset = "0x22616A0", VA = "0x22616A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000333")]
			[Address(RVA = "0x22616A4", Offset = "0x22616A4", VA = "0x22616A4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000335")]
			[Address(RVA = "0x226176C", Offset = "0x226176C", VA = "0x226176C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool notFound;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static AutoHandPlayer _Instance;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "AutoHeaderAttribute", RVA = "0xD5D8FC", Offset = "0xD5D8FC")]
		public bool ignoreMe;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5D93C", Offset = "0xD5D93C")]
		public Camera headCamera;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5D974", Offset = "0xD5D974")]
		public Transform forwardFollow;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5D9AC", Offset = "0xD5D9AC")]
		public Transform trackingContainer;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Hand handRight;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Hand handLeft;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "AutoToggleHeaderAttribute", RVA = "0xD5D9E4", Offset = "0xD5D9E4")]
		public bool useMovement;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "EnableIfAttribute", RVA = "0xD5DA24", Offset = "0xD5DA24")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xD5DA24", Offset = "0xD5DA24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5DA24", Offset = "0xD5DA24")]
		public float maxMoveSpeed;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "EnableIfAttribute", RVA = "0xD5DAA8", Offset = "0xD5DAA8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5DAA8", Offset = "0xD5DAA8")]
		public float moveAcceleration;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "EnableIfAttribute", RVA = "0xD5DB08", Offset = "0xD5DB08")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5DB08", Offset = "0xD5DB08")]
		public float groundedDrag;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "EnableIfAttribute", RVA = "0xD5DB68", Offset = "0xD5DB68")]
		public float heightSmoothSpeed;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "AutoToggleHeaderAttribute", RVA = "0xD5DBA0", Offset = "0xD5DBA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5DBA0", Offset = "0xD5DBA0")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xD5DBA0", Offset = "0xD5DBA0")]
		public bool snapTurning;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5DC1C", Offset = "0xD5DC1C")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5DC1C", Offset = "0xD5DC1C")]
		public float snapTurnAngle;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HideIfAttribute", RVA = "0xD5DC7C", Offset = "0xD5DC7C")]
		public float smoothTurnSpeed;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "AutoToggleHeaderAttribute", RVA = "0xD5DCB4", Offset = "0xD5DCB4")]
		public bool ignoreMe2;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5DCF4", Offset = "0xD5DCF4")]
		public float heightOffset;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5DD2C", Offset = "0xD5DD2C")]
		public bool crouching;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5DD64", Offset = "0xD5DD64")]
		public float crouchHeight;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5DD9C", Offset = "0xD5DD9C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5DD9C", Offset = "0xD5DD9C")]
		public bool autoAdjustColliderHeight;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5DDFC", Offset = "0xD5DDFC")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5DDFC", Offset = "0xD5DDFC")]
		public Vector2 minMaxHeight;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5DE5C", Offset = "0xD5DE5C")]
		public bool useHeadCollision;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5DE94", Offset = "0xD5DE94")]
		public float headRadius;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "AutoToggleHeaderAttribute", RVA = "0xD5DECC", Offset = "0xD5DECC")]
		public bool useGrounding;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "EnableIfAttribute", RVA = "0xD5DF0C", Offset = "0xD5DF0C")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xD5DF0C", Offset = "0xD5DF0C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5DF0C", Offset = "0xD5DF0C")]
		public float maxStepHeight;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5DF80", Offset = "0xD5DF80")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xD5DF80", Offset = "0xD5DF80")]
		[AttributeAttribute(Name = "EnableIfAttribute", RVA = "0xD5DF80", Offset = "0xD5DF80")]
		public float maxStepAngle;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "EnableIfAttribute", RVA = "0xD5DFF4", Offset = "0xD5DFF4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5DFF4", Offset = "0xD5DFF4")]
		public LayerMask groundLayerMask;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[AttributeAttribute(Name = "AutoToggleHeaderAttribute", RVA = "0xD5E054", Offset = "0xD5E054")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5E054", Offset = "0xD5E054")]
		public bool allowClimbing;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5E0BC", Offset = "0xD5E0BC")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5E0BC", Offset = "0xD5E0BC")]
		public bool allowClimbingMovement;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0xD5E11C", Offset = "0xD5E11C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5E11C", Offset = "0xD5E11C")]
		public Vector3 climbingStrength;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float climbingAcceleration;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float climbingDrag;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "AutoToggleHeaderAttribute", RVA = "0xD5E17C", Offset = "0xD5E17C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5E17C", Offset = "0xD5E17C")]
		public bool allowBodyPushing;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "EnableIfAttribute", RVA = "0xD5E1E4", Offset = "0xD5E1E4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5E1E4", Offset = "0xD5E1E4")]
		public Vector3 pushingStrength;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float pushingAcceleration;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float pushingDrag;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "AutoToggleHeaderAttribute", RVA = "0xD5E244", Offset = "0xD5E244")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5E244", Offset = "0xD5E244")]
		public bool allowPlatforms;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "AutoToggleHeaderAttribute", RVA = "0xD5E2AC", Offset = "0xD5E2AC")]
		private float movementDeadzone;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float turnDeadzone;

		[Token(Token = "0x4000314")]
		public const string HandPlayerLayer = "HandPlayer";

		[Token(Token = "0x4000315")]
		private const int groundRayCount = 21;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5E2EC", Offset = "0xD5E2EC")]
		private Rigidbody <body>k__BackingField;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float turnResetzone;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float groundedOffset;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private HeadPhysicsFollower headPhysicsFollower;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private CapsuleCollider bodyCapsule;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Vector3 moveDirection;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private float turningAxis;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool isGrounded;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
		private bool axisReset;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private float playerHeight;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private bool lastCrouching;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private float lastCrouchingHeight;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion startRot;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 targetTrackedPos;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 lastUpdatePosition;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Hand lastRightHand;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Hand lastLeftHand;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3 climbAxis;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Dictionary<Hand, Climbable> climbing;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Dictionary<Pushable, Hand> pushRight;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Dictionary<Pushable, int> pushRightCount;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Dictionary<Pushable, Hand> pushLeft;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Dictionary<Pushable, int> pushLeftCount;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private Vector3 pushAxis;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		private Vector3 lastPlatformPosition;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private Quaternion lastPlatformRotation;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private RaycastHit closestHit;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		private float lastUpdateTime;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private bool ignoreIterpolationFrame;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private Vector3 targetPosOffset;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private int handPlayerMask;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
		private bool trackingStarted;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Vector3 lastHeadPos;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private Vector3 offset;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private RaycastHit newClosestHit;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
		private float highestPoint;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private Coroutine disableGroundingRoutine;

		[Token(Token = "0x17000034")]
		public static AutoHandPlayer Instance
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x2332C18", Offset = "0x2332C18", VA = "0x2332C18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public Rigidbody body
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x2332DF0", Offset = "0x2332DF0", VA = "0x2332DF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD605C8", Offset = "0xD605C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x2332DF8", Offset = "0x2332DF8", VA = "0x2332DF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD605D8", Offset = "0xD605D8")]
			private set
			{
			}
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x2332E00", Offset = "0x2332E00", VA = "0x2332E00", Slot = "4")]
		public virtual void Start()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x233337C", Offset = "0x233337C", VA = "0x233337C", Slot = "5")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x23335D0", Offset = "0x23335D0", VA = "0x23335D0", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x2333310", Offset = "0x2333310", VA = "0x2333310")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD605E8", Offset = "0xD605E8")]
		private IEnumerator CheckForTrackingStart()
		{
			return null;
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x23338EC", Offset = "0x23338EC", VA = "0x23338EC", Slot = "7")]
		protected virtual void OnHeadTrackingStarted()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x2333060", Offset = "0x2333060", VA = "0x2333060")]
		private void CreateHeadFollower()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x2333930", Offset = "0x2333930", VA = "0x2333930")]
		private void CheckHands()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x23333A8", Offset = "0x23333A8", VA = "0x23333A8")]
		private void EnableHand(Hand hand)
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x23335FC", Offset = "0x23335FC", VA = "0x23335FC")]
		private void DisableHand(Hand hand)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x2333A0C", Offset = "0x2333A0C", VA = "0x2333A0C")]
		private void OnHandGrab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x2333BF0", Offset = "0x2333BF0", VA = "0x2333BF0")]
		private void OnHandRelease(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x2333D54", Offset = "0x2333D54", VA = "0x2333D54", Slot = "8")]
		public virtual void Move(Vector2 axis, bool useDeadzone = true, bool useRelativeDirection = false)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x2333DE0", Offset = "0x2333DE0", VA = "0x2333DE0", Slot = "9")]
		public virtual void Turn(float turnAxis)
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x2333DFC", Offset = "0x2333DFC", VA = "0x2333DFC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x2334290", Offset = "0x2334290", VA = "0x2334290", Slot = "10")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x2334350", Offset = "0x2334350", VA = "0x2334350", Slot = "11")]
		protected virtual void UpdateRigidbody(Vector3 moveDir)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x2334A8C", Offset = "0x2334A8C", VA = "0x2334A8C")]
		private void SyncBodyHead()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x2335288", Offset = "0x2335288", VA = "0x2335288", Slot = "12")]
		protected virtual bool CanInputMove()
		{
			return default(bool);
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x23352B4", Offset = "0x23352B4", VA = "0x23352B4", Slot = "13")]
		protected virtual void InterpolateMovement()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x2335EBC", Offset = "0x2335EBC", VA = "0x2335EBC", Slot = "14")]
		protected virtual void UpdateTurn(float deltaTime)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x23362F8", Offset = "0x23362F8", VA = "0x23362F8", Slot = "15")]
		protected virtual void Ground()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x2336838", Offset = "0x2336838", VA = "0x2336838")]
		public bool IsGrounded()
		{
			return default(bool);
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x2336840", Offset = "0x2336840", VA = "0x2336840")]
		public void ToggleFlying()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x2336874", Offset = "0x2336874", VA = "0x2336874", Slot = "16")]
		protected virtual void UpdatePlayerHeight()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x2333E3C", Offset = "0x2333E3C", VA = "0x2333E3C")]
		protected void UpdatePlatform(bool isFixedUpdate)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x23369C4", Offset = "0x23369C4", VA = "0x23369C4")]
		public void Jump(float jumpPower = 1f)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x2336A68", Offset = "0x2336A68", VA = "0x2336A68")]
		public void DisableGrounding(float seconds)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x2336AC4", Offset = "0x2336AC4", VA = "0x2336AC4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD60648", Offset = "0xD60648")]
		private IEnumerator DisableGroundingSecondsRoutine(float seconds)
		{
			return null;
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x2336B40", Offset = "0x2336B40", VA = "0x2336B40")]
		public void AddVelocity(Vector3 force, ForceMode mode = ForceMode.Acceleration)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x2336B5C", Offset = "0x2336B5C", VA = "0x2336B5C", Slot = "17")]
		protected virtual void StartPush(Hand hand, GameObject other)
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x2336DD8", Offset = "0x2336DD8", VA = "0x2336DD8", Slot = "18")]
		protected virtual void StopPush(Hand hand, GameObject other)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x2337014", Offset = "0x2337014", VA = "0x2337014", Slot = "19")]
		protected virtual void StartGrabPush(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x23371CC", Offset = "0x23371CC", VA = "0x23371CC", Slot = "20")]
		protected virtual void EndGrabPush(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x2337388", Offset = "0x2337388", VA = "0x2337388", Slot = "21")]
		protected virtual void ApplyPushingForce()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x2337BF0", Offset = "0x2337BF0", VA = "0x2337BF0")]
		public bool IsPushing()
		{
			return default(bool);
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x2337E80", Offset = "0x2337E80", VA = "0x2337E80", Slot = "22")]
		protected virtual void StartClimb(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x2338068", Offset = "0x2338068", VA = "0x2338068", Slot = "23")]
		protected virtual void EndClimb(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x2338110", Offset = "0x2338110", VA = "0x2338110", Slot = "24")]
		protected virtual void ApplyClimbingForce()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x233493C", Offset = "0x233493C", VA = "0x233493C")]
		public bool IsClimbing()
		{
			return default(bool);
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x23383C0", Offset = "0x23383C0", VA = "0x23383C0", Slot = "25")]
		public virtual void SetPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x2338454", Offset = "0x2338454", VA = "0x2338454", Slot = "26")]
		public virtual void SetPosition(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x23387B0", Offset = "0x23387B0", VA = "0x23387B0", Slot = "27")]
		public virtual void SetRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x2338A7C", Offset = "0x2338A7C", VA = "0x2338A7C", Slot = "28")]
		public virtual void AddRotation(Quaternion addRotation)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x2338CE0", Offset = "0x2338CE0", VA = "0x2338CE0", Slot = "29")]
		public virtual void Recenter()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x23348A4", Offset = "0x23348A4", VA = "0x23348A4")]
		private Vector3 AlterDirection(Vector3 moveAxis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x2338EB4", Offset = "0x2338EB4", VA = "0x2338EB4")]
		public AutoHandPlayer()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x23364BC", Offset = "0x23364BC", VA = "0x23364BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD606A8", Offset = "0xD606A8")]
		private void <Ground>g__CheckGroundRadius|103_0(int groundRayCount, float multi)
		{
		}
	}
	[Token(Token = "0x200006B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD5961C", Offset = "0xD5961C")]
	public class Climbable : MonoBehaviour
	{
		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Stabber stabber;

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x233B0F8", Offset = "0x233B0F8", VA = "0x233B0F8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x233B260", Offset = "0x233B260", VA = "0x233B260")]
		public Climbable()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x233B294", Offset = "0x233B294", VA = "0x233B294")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60758", Offset = "0xD60758")]
		private void <Start>b__2_0(Stabber hand, Stabbable grab)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x233B2A0", Offset = "0x233B2A0", VA = "0x233B2A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60768", Offset = "0xD60768")]
		private void <Start>b__2_1(Stabber hand, Stabbable grab)
		{
		}
	}
	[Token(Token = "0x200006C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD5967C", Offset = "0xD5967C")]
	public class HeadPhysicsFollower : MonoBehaviour
	{
		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5E2FC", Offset = "0xD5E2FC")]
		public Camera headCamera;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingContainer;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform followBody;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5E334", Offset = "0xD5E334")]
		public float followStrength;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5E36C", Offset = "0xD5E36C")]
		internal SphereCollider headCollider;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 startHeadPos;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool started;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _moveTo;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal Rigidbody body;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CollisionTracker collisionTracker;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float lastUpdateTime;

		[Token(Token = "0x1700003A")]
		private Transform moveTo
		{
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x1CAA558", Offset = "0x1CAA558", VA = "0x1CAA558")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1CAA70C", Offset = "0x1CAA70C", VA = "0x1CAA70C")]
		public void Start()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1CAA8F8", Offset = "0x1CAA8F8", VA = "0x1CAA8F8")]
		internal void Init()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x1CAAAC0", Offset = "0x1CAAAC0", VA = "0x1CAAAC0")]
		protected void FixedUpdate()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1CAABAC", Offset = "0x1CAABAC", VA = "0x1CAABAC")]
		public bool Started()
		{
			return default(bool);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1CAABB4", Offset = "0x1CAABB4", VA = "0x1CAABB4", Slot = "4")]
		internal virtual void MoveTo()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1CAACF8", Offset = "0x1CAACF8", VA = "0x1CAACF8", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1CAAF64", Offset = "0x1CAAF64", VA = "0x1CAAF64")]
		public int CollisionCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1CAAF80", Offset = "0x1CAAF80", VA = "0x1CAAF80")]
		public HeadPhysicsFollower()
		{
		}
	}
	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0xD596DC", Offset = "0xD596DC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD596DC", Offset = "0xD596DC")]
	public class InterpolatedTransform : MonoBehaviour
	{
		[Token(Token = "0x200006E")]
		private struct TransformData
		{
			[Token(Token = "0x4000353")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x4000354")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Quaternion rotation;

			[Token(Token = "0x4000355")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 scale;

			[Token(Token = "0x600034D")]
			[Address(RVA = "0x22659F8", Offset = "0x22659F8", VA = "0x22659F8")]
			public TransformData(Vector3 position, Quaternion rotation, Vector3 scale)
			{
			}
		}

		[Token(Token = "0x200006F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD59750", Offset = "0xD59750")]
		private sealed class <Disable>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000356")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000357")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000358")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public InterpolatedTransform <>4__this;

			[Token(Token = "0x4000359")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float time;

			[Token(Token = "0x1700003B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000351")]
				[Address(RVA = "0x22659A8", Offset = "0x22659A8", VA = "0x22659A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000353")]
				[Address(RVA = "0x22659F0", Offset = "0x22659F0", VA = "0x22659F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600034E")]
			[Address(RVA = "0x22658B8", Offset = "0x22658B8", VA = "0x22658B8")]
			[DebuggerHidden]
			public <Disable>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600034F")]
			[Address(RVA = "0x22658E4", Offset = "0x22658E4", VA = "0x22658E4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000350")]
			[Address(RVA = "0x22658E8", Offset = "0x22658E8", VA = "0x22658E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000352")]
			[Address(RVA = "0x22659B0", Offset = "0x22659B0", VA = "0x22659B0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TransformData[] m_lastTransforms;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_newTransformIndex;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool run;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Coroutine disableForTime;

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1CAB11C", Offset = "0x1CAB11C", VA = "0x1CAB11C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1CAB120", Offset = "0x1CAB120", VA = "0x1CAB120")]
		public void ForgetPreviousTransforms()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1CAB2E4", Offset = "0x1CAB2E4", VA = "0x1CAB2E4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x1CAB3F8", Offset = "0x1CAB3F8", VA = "0x1CAB3F8")]
		public void LateFixedUpdate()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x1CAB55C", Offset = "0x1CAB55C", VA = "0x1CAB55C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1CAB7D4", Offset = "0x1CAB7D4", VA = "0x1CAB7D4")]
		public void DisableForSeconds(float time)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1CAB854", Offset = "0x1CAB854", VA = "0x1CAB854")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD60778", Offset = "0xD60778")]
		private IEnumerator Disable(float time)
		{
			return null;
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x1CAB54C", Offset = "0x1CAB54C", VA = "0x1CAB54C")]
		private int OldTransformIndex()
		{
			return default(int);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x1CAB8D0", Offset = "0x1CAB8D0", VA = "0x1CAB8D0")]
		public InterpolatedTransform()
		{
		}
	}
	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0xD59760", Offset = "0xD59760")]
	public class InterpolatedTransformUpdater : MonoBehaviour
	{
		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private InterpolatedTransform _interpolatedTransform;

		[Token(Token = "0x1700003D")]
		private InterpolatedTransform interpolatedTransform
		{
			[Token(Token = "0x6000354")]
			[Address(RVA = "0x1CAB8E0", Offset = "0x1CAB8E0", VA = "0x1CAB8E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x1CAB980", Offset = "0x1CAB980", VA = "0x1CAB980")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x1CAB9A0", Offset = "0x1CAB9A0", VA = "0x1CAB9A0")]
		public InterpolatedTransformUpdater()
		{
		}
	}
	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0xD59774", Offset = "0xD59774")]
	public class InterpolationController : MonoBehaviour
	{
		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float[] m_lastFixedUpdateTimes;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_newTimeIndex;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float m_interpolationFactor;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static InterpolationController _Instance;

		[Token(Token = "0x1700003E")]
		public static float InterpolationFactor
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x1CAB9A8", Offset = "0x1CAB9A8", VA = "0x1CAB9A8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003F")]
		public static InterpolationController Instance
		{
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x1CAB9F4", Offset = "0x1CAB9F4", VA = "0x1CAB9F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x1CABBB8", Offset = "0x1CABBB8", VA = "0x1CABBB8")]
		public void Start()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x1CABC10", Offset = "0x1CABC10", VA = "0x1CABC10")]
		public void FixedUpdate()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x1CABC8C", Offset = "0x1CABC8C", VA = "0x1CABC8C")]
		public void Update()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x1CABC7C", Offset = "0x1CABC7C", VA = "0x1CABC7C")]
		private int OldTimeIndex()
		{
			return default(int);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1CABD58", Offset = "0x1CABD58", VA = "0x1CABD58")]
		public InterpolationController()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class PlayerPlatform : MonoBehaviour
	{
		[Token(Token = "0x600035E")]
		[Address(RVA = "0x1CB0A64", Offset = "0x1CB0A64", VA = "0x1CB0A64")]
		public PlayerPlatform()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class Pushable : MonoBehaviour
	{
		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 strengthScale;

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1CB0A6C", Offset = "0x1CB0A6C", VA = "0x1CB0A6C")]
		public Pushable()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class Teleporter : MonoBehaviour
	{
		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5E3A4", Offset = "0xD5E3A4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5E3A4", Offset = "0xD5E3A4")]
		public GameObject teleportObject;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5E404", Offset = "0xD5E404")]
		public Transform[] additionalTeleports;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5E43C", Offset = "0xD5E43C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5E43C", Offset = "0xD5E43C")]
		public Transform aimer;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5E49C", Offset = "0xD5E49C")]
		public LayerMask layer;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5E4D4", Offset = "0xD5E4D4")]
		public float maxSurfaceAngle;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xD5E50C", Offset = "0xD5E50C")]
		public float distanceMultiplyer;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xD5E520", Offset = "0xD5E520")]
		public float curveStrength;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5E534", Offset = "0xD5E534")]
		public LineRenderer line;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5E56C", Offset = "0xD5E56C")]
		public int lineSegments;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5E5A4", Offset = "0xD5E5A4")]
		public Gradient canTeleportColor;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Gradient cantTeleportColor;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5E5DC", Offset = "0xD5E5DC")]
		public GameObject indicator;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5E614", Offset = "0xD5E614")]
		public UnityEvent OnStartTeleport;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UnityEvent OnStopTeleport;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public UnityEvent OnTeleport;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3[] lineArr;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool aiming;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool hitting;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private RaycastHit aimHit;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private HandTeleportGuard[] teleportGuards;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AutoHandPlayer playerBody;

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x225BA14", Offset = "0x225BA14", VA = "0x225BA14")]
		private void Start()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x225BB60", Offset = "0x225BB60", VA = "0x225BB60")]
		private void Update()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x225BBAC", Offset = "0x225BBAC", VA = "0x225BBAC")]
		private void CalculateTeleport()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x225BFA4", Offset = "0x225BFA4", VA = "0x225BFA4")]
		private void DrawIndicator()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x225C0D4", Offset = "0x225C0D4", VA = "0x225C0D4")]
		public void StartTeleport()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x225C0F4", Offset = "0x225C0F4", VA = "0x225C0F4")]
		public void CancelTeleport()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x225C144", Offset = "0x225C144", VA = "0x225C144")]
		public void Teleport()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x225C4A8", Offset = "0x225C4A8", VA = "0x225C4A8")]
		public Teleporter()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class AutoInputModule : BaseInputModule
	{
		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<HandCanvasPointer> pointers;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private PointerEventData[] eventDatas;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AutoInputModule _instance;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool _isDestroyed;

		[Token(Token = "0x17000040")]
		public AutoInputModule Instance
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x23391B4", Offset = "0x23391B4", VA = "0x23391B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x2339334", Offset = "0x2339334", VA = "0x2339334", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x233933C", Offset = "0x233933C", VA = "0x233933C", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x2339348", Offset = "0x2339348", VA = "0x2339348")]
		public int AddPointer(HandCanvasPointer pointer)
		{
			return default(int);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x233955C", Offset = "0x233955C", VA = "0x233955C")]
		public void RemovePointer(HandCanvasPointer pointer)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x233986C", Offset = "0x233986C", VA = "0x233986C", Slot = "17")]
		public override void Process()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x2339CA8", Offset = "0x2339CA8", VA = "0x2339CA8")]
		public void ProcessPress(int index)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x2339F50", Offset = "0x2339F50", VA = "0x2339F50")]
		public void ProcessRelease(int index)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x233A350", Offset = "0x233A350", VA = "0x233A350")]
		public PointerEventData GetData(int index)
		{
			return null;
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x233A38C", Offset = "0x233A38C", VA = "0x233A38C")]
		public AutoInputModule()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public delegate void CollisionEvent(GameObject from);
	[Token(Token = "0x2000077")]
	public class CollisionTracker : MonoBehaviour
	{
		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool disableCollisionTracking;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool disableTriggersTracking;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5E68C", Offset = "0xD5E68C")]
		private List<GameObject> <triggerObjects>k__BackingField;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5E69C", Offset = "0xD5E69C")]
		private List<int> <triggerObjectsCount>k__BackingField;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5E6AC", Offset = "0xD5E6AC")]
		private List<GameObject> <collisionObjects>k__BackingField;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5E6BC", Offset = "0xD5E6BC")]
		private List<int> <collisionObjectsCount>k__BackingField;

		[Token(Token = "0x17000041")]
		public int collisionCount
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x233BCE4", Offset = "0x233BCE4", VA = "0x233BCE4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000042")]
		public int triggerCount
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x233BD30", Offset = "0x233BD30", VA = "0x233BD30")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000043")]
		public List<GameObject> triggerObjects
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x233BD7C", Offset = "0x233BD7C", VA = "0x233BD7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD608A8", Offset = "0xD608A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x233BD84", Offset = "0x233BD84", VA = "0x233BD84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD608B8", Offset = "0xD608B8")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public List<int> triggerObjectsCount
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x233BD8C", Offset = "0x233BD8C", VA = "0x233BD8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD608C8", Offset = "0xD608C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x233BD94", Offset = "0x233BD94", VA = "0x233BD94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD608D8", Offset = "0xD608D8")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public List<GameObject> collisionObjects
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x233BD9C", Offset = "0x233BD9C", VA = "0x233BD9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD608E8", Offset = "0xD608E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x233BDA4", Offset = "0x233BDA4", VA = "0x233BDA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD608F8", Offset = "0xD608F8")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public List<int> collisionObjectsCount
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x233BDAC", Offset = "0x233BDAC", VA = "0x233BDAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60908", Offset = "0xD60908")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x233BDB4", Offset = "0x233BDB4", VA = "0x233BDB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60918", Offset = "0xD60918")]
			protected set
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event CollisionEvent OnCollisionFirstEnter
		{
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x233B7E4", Offset = "0x233B7E4", VA = "0x233B7E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60828", Offset = "0xD60828")]
			add
			{
			}
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x233B884", Offset = "0x233B884", VA = "0x233B884")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60838", Offset = "0xD60838")]
			remove
			{
			}
		}

		[Token(Token = "0x14000013")]
		public event CollisionEvent OnCollisionLastExit
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x233B924", Offset = "0x233B924", VA = "0x233B924")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60848", Offset = "0xD60848")]
			add
			{
			}
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x233B9C4", Offset = "0x233B9C4", VA = "0x233B9C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60858", Offset = "0xD60858")]
			remove
			{
			}
		}

		[Token(Token = "0x14000014")]
		public event CollisionEvent OnTriggerFirstEnter
		{
			[Token(Token = "0x600037A")]
			[Address(RVA = "0x233BA64", Offset = "0x233BA64", VA = "0x233BA64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60868", Offset = "0xD60868")]
			add
			{
			}
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x233BB04", Offset = "0x233BB04", VA = "0x233BB04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60878", Offset = "0xD60878")]
			remove
			{
			}
		}

		[Token(Token = "0x14000015")]
		public event CollisionEvent OnTriggeLastExit
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x233BBA4", Offset = "0x233BBA4", VA = "0x233BBA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60888", Offset = "0xD60888")]
			add
			{
			}
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x233BC44", Offset = "0x233BC44", VA = "0x233BC44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60898", Offset = "0xD60898")]
			remove
			{
			}
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x233BDBC", Offset = "0x233BDBC", VA = "0x233BDBC")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x233BE5C", Offset = "0x233BE5C", VA = "0x233BE5C", Slot = "4")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x233C0A8", Offset = "0x233C0A8", VA = "0x233C0A8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x233C0AC", Offset = "0x233C0AC", VA = "0x233C0AC")]
		private void CheckCollisions()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x233C3B0", Offset = "0x233C3B0", VA = "0x233C3B0", Slot = "5")]
		protected virtual void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x233C594", Offset = "0x233C594", VA = "0x233C594", Slot = "6")]
		protected virtual void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x233C784", Offset = "0x233C784", VA = "0x233C784", Slot = "7")]
		protected virtual void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x233C938", Offset = "0x233C938", VA = "0x233C938", Slot = "8")]
		protected virtual void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x233CB20", Offset = "0x233CB20", VA = "0x233CB20")]
		public CollisionTracker()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class HandCanvasPointer : MonoBehaviour
	{
		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5E6CC", Offset = "0xD5E6CC")]
		public GameObject hitPointMarker;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private LineRenderer lineRenderer;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5E704", Offset = "0xD5E704")]
		public float raycastLength;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool autoShowTarget;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LayerMask UILayer;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5E73C", Offset = "0xD5E73C")]
		public UnityEvent StartSelect;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityEvent StopSelect;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UnityEvent StartPoint;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityEvent StopPoint;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool hover;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AutoInputModule inputModule;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float lineSegements;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Camera cam;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int pointerIndex;

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x23DDFA8", Offset = "0x23DDFA8", VA = "0x23DDFA8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x23DE388", Offset = "0x23DE388", VA = "0x23DE388")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x23DE424", Offset = "0x23DE424", VA = "0x23DE424")]
		public void SetIndex(int index)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x23DE42C", Offset = "0x23DE42C", VA = "0x23DE42C")]
		internal void Preprocess()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x23DE500", Offset = "0x23DE500", VA = "0x23DE500")]
		public void Press()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x23DE604", Offset = "0x23DE604", VA = "0x23DE604")]
		public void Release()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x23DE6A4", Offset = "0x23DE6A4", VA = "0x23DE6A4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x23DE9B0", Offset = "0x23DE9B0", VA = "0x23DE9B0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x23DE9B4", Offset = "0x23DE9B4", VA = "0x23DE9B4")]
		private void UpdateLine()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x23DED64", Offset = "0x23DED64", VA = "0x23DED64")]
		private RaycastHit CreateRaycast(float dist)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x23DE5BC", Offset = "0x23DE5BC", VA = "0x23DE5BC")]
		private void ShowRay(bool show)
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x23DEE5C", Offset = "0x23DEE5C", VA = "0x23DEE5C")]
		public HandCanvasPointer()
		{
		}
	}
	[Token(Token = "0x2000079")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD59788", Offset = "0xD59788")]
	[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0xD59788", Offset = "0xD59788")]
	public class PhysicsFollower : MonoBehaviour
	{
		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5E774", Offset = "0xD5E774")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5E774", Offset = "0xD5E774")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD5E774", Offset = "0xD5E774")]
		public Transform follow;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5E7E4", Offset = "0xD5E7E4")]
		public bool freezePos;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5E81C", Offset = "0xD5E81C")]
		public bool freezeRot;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5E854", Offset = "0xD5E854")]
		public Vector3 followPositionOffset;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5E88C", Offset = "0xD5E88C")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xD5E88C", Offset = "0xD5E88C")]
		public float followPositionStrength;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5E8DC", Offset = "0xD5E8DC")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xD5E8DC", Offset = "0xD5E8DC")]
		public float followRotationStrength;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5E92C", Offset = "0xD5E92C")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0xD5E92C", Offset = "0xD5E92C")]
		public float maxVelocity;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal Rigidbody body;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform moveTo;

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x1CAC8CC", Offset = "0x1CAC8CC", VA = "0x1CAC8CC")]
		public void Start()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x1CAC8D8", Offset = "0x1CAC8D8", VA = "0x1CAC8D8", Slot = "4")]
		public virtual void Set()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x1CACA88", Offset = "0x1CACA88", VA = "0x1CACA88")]
		public void Update()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1CACA94", Offset = "0x1CACA94", VA = "0x1CACA94", Slot = "5")]
		protected virtual void OnUpdate()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1CACBFC", Offset = "0x1CACBFC", VA = "0x1CACBFC")]
		public void FixedUpdate()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x1CACC08", Offset = "0x1CACC08", VA = "0x1CACC08", Slot = "6")]
		protected virtual void OnFixedUpdate()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x1CACDA0", Offset = "0x1CACDA0", VA = "0x1CACDA0", Slot = "7")]
		internal virtual void MoveTo()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x1CACF04", Offset = "0x1CACF04", VA = "0x1CACF04", Slot = "8")]
		internal virtual void TorqueTo()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1CAD250", Offset = "0x1CAD250", VA = "0x1CAD250")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x1CAD2D0", Offset = "0x1CAD2D0", VA = "0x1CAD2D0")]
		public PhysicsFollower()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class Stabbable : MonoBehaviour
	{
		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody body;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Grabbable grabbable;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5E97C", Offset = "0xD5E97C")]
		public int stabIndex;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int maxStabbers;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float positionDamper;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rotationDamper;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool parentOnStab;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5E9B4", Offset = "0xD5E9B4")]
		public UnityEvent StartStab;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UnityEvent EndStab;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public StabEvent StartStabEvent;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public StabEvent EndStabEvent;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int currentStabs;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<Stabber> stabbing;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform stabParent;

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1CB1F54", Offset = "0x1CB1F54", VA = "0x1CB1F54")]
		public void Start()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x1CB2150", Offset = "0x1CB2150", VA = "0x1CB2150", Slot = "4")]
		public virtual void OnStab(Stabber stabber)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x1CB21F8", Offset = "0x1CB21F8", VA = "0x1CB21F8", Slot = "5")]
		public virtual void OnEndStab(Stabber stabber)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x1CB228C", Offset = "0x1CB228C", VA = "0x1CB228C", Slot = "6")]
		public virtual bool CanStab(Stabber stabber)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1CB22C8", Offset = "0x1CB22C8", VA = "0x1CB22C8")]
		public int StabbedCount()
		{
			return default(int);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1CB2314", Offset = "0x1CB2314", VA = "0x1CB2314")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x1CB23EC", Offset = "0x1CB23EC", VA = "0x1CB23EC")]
		public Stabbable()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x1CB240C", Offset = "0x1CB240C", VA = "0x1CB240C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60928", Offset = "0xD60928")]
		private void <Start>b__14_0(Stabber stabber, Stabbable stabbable)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x1CB2420", Offset = "0x1CB2420", VA = "0x1CB2420")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60938", Offset = "0xD60938")]
		private void <Start>b__14_1(Stabber stabber, Stabbable stabbable)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x1CB2434", Offset = "0x1CB2434", VA = "0x1CB2434")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60948", Offset = "0xD60948")]
		private void <Start>b__14_2(Hand hand, Grabbable grab)
		{
		}
	}
	[Token(Token = "0x200007B")]
	public delegate void StabEvent(Stabber stabber, Stabbable stab);
	[Token(Token = "0x200007C")]
	public class Stabber : MonoBehaviour
	{
		[Token(Token = "0x200007D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD597FC", Offset = "0xD597FC")]
		private sealed class <StartWait>d__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Stabber <>4__this;

			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x17000047")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003C4")]
				[Address(RVA = "0x22663E0", Offset = "0x22663E0", VA = "0x22663E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000048")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003C6")]
				[Address(RVA = "0x2266428", Offset = "0x2266428", VA = "0x2266428", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x22662BC", Offset = "0x22662BC", VA = "0x22662BC")]
			[DebuggerHidden]
			public <StartWait>d__31(int <>1__state)
			{
			}

			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x22662E8", Offset = "0x22662E8", VA = "0x22662E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x22662EC", Offset = "0x22662EC", VA = "0x22662EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x22663E8", Offset = "0x22663E8", VA = "0x22663E8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5E9EC", Offset = "0xD5E9EC")]
		public Grabbable grabbable;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5EA24", Offset = "0xD5EA24")]
		public CapsuleCollider stabCapsule;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5EA5C", Offset = "0xD5EA5C")]
		public LayerMask stabbableLayers;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5EA94", Offset = "0xD5EA94")]
		public int stabIndex;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int maxStabs;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5EACC", Offset = "0xD5EACC")]
		public Vector3 axis;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float limit;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public ConfigurableJointMotion xMotion;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ConfigurableJointMotion yMotion;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public ConfigurableJointMotion zMotion;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public ConfigurableJointMotion angularXMotion;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public ConfigurableJointMotion angularYMotion;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ConfigurableJointMotion angularZMotion;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD5EB04", Offset = "0xD5EB04")]
		public float positionDampeningMultiplyer;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float rotationDampeningMultiplyer;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5EB14", Offset = "0xD5EB14")]
		public UnityEvent StartStab;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UnityEvent EndStab;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public StabEvent StartStabEvent;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public StabEvent EndStabEvent;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<Stabbable> stabbed;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<ConfigurableJoint> stabbedJoints;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Dictionary<Stabbable, int> stabbedFrames;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Collider[] resultsNonAlloc;

		[Token(Token = "0x40003C0")]
		private const int STABFRAMES = 3;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 startPos;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private Quaternion startRot;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Vector3 lastPos;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion lastRot;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int frames;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Dictionary<Transform, Transform> originalParents;

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x1CB24B0", Offset = "0x1CB24B0", VA = "0x1CB24B0")]
		private void Start()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x1CB27B0", Offset = "0x1CB27B0", VA = "0x1CB27B0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD60958", Offset = "0xD60958")]
		private IEnumerator StartWait()
		{
			return null;
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x1CB281C", Offset = "0x1CB281C", VA = "0x1CB281C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x1CB2938", Offset = "0x1CB2938", VA = "0x1CB2938", Slot = "4")]
		protected virtual void CheckStabArea()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x1CB3240", Offset = "0x1CB3240", VA = "0x1CB3240", Slot = "5")]
		protected virtual void OnStabbableEnter(Stabbable stab)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x1CB3860", Offset = "0x1CB3860", VA = "0x1CB3860", Slot = "6")]
		protected virtual void OnStabbableExit(Stabbable stab)
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x1CB3A90", Offset = "0x1CB3A90", VA = "0x1CB3A90")]
		public List<Stabbable> GetStabbed()
		{
			return null;
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x1CB3A98", Offset = "0x1CB3A98", VA = "0x1CB3A98")]
		public int GetStabbedCount()
		{
			return default(int);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x1CB3AE4", Offset = "0x1CB3AE4", VA = "0x1CB3AE4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x1CB3EE0", Offset = "0x1CB3EE0", VA = "0x1CB3EE0")]
		public Stabber()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x1CB3F70", Offset = "0x1CB3F70", VA = "0x1CB3F70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD609B8", Offset = "0xD609B8")]
		private void <Start>b__30_0(Stabber stabber, Stabbable stabbable)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x1CB3F84", Offset = "0x1CB3F84", VA = "0x1CB3F84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD609C8", Offset = "0xD609C8")]
		private void <Start>b__30_1(Stabber stabber, Stabbable stabbable)
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class Stickable : MonoBehaviour
	{
		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5EB4C", Offset = "0xD5EB4C")]
		public Rigidbody body;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5EB84", Offset = "0xD5EB84")]
		public float stickStrength;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5EBBC", Offset = "0xD5EBBC")]
		public float stickSpeedMultiplyer;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5EBF4", Offset = "0xD5EBF4")]
		public int stickIndex;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5EC2C", Offset = "0xD5EC2C")]
		public UnityEvent OnStick;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UnityEvent EndStick;

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x225B2D4", Offset = "0x225B2D4", VA = "0x225B2D4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x225B3AC", Offset = "0x225B3AC", VA = "0x225B3AC")]
		public Stickable()
		{
		}
	}
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD5980C", Offset = "0xD5980C")]
	public class Sticky : MonoBehaviour
	{
		[Token(Token = "0x2000080")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5986C", Offset = "0xD5986C")]
		private sealed class <JointBreak>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Sticky <>4__this;

			[Token(Token = "0x17000049")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003D3")]
				[Address(RVA = "0x2266640", Offset = "0x2266640", VA = "0x2266640", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003D5")]
				[Address(RVA = "0x2266688", Offset = "0x2266688", VA = "0x2266688", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x225B82C", Offset = "0x225B82C", VA = "0x225B82C")]
			[DebuggerHidden]
			public <JointBreak>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x2266430", Offset = "0x2266430", VA = "0x2266430", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x2266434", Offset = "0x2266434", VA = "0x2266434", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x2266648", Offset = "0x2266648", VA = "0x2266648", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5EC64", Offset = "0xD5EC64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5EC64", Offset = "0xD5EC64")]
		public float stickStrength;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5ECC4", Offset = "0xD5ECC4")]
		public float requiredStickSpeed;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5ECFC", Offset = "0xD5ECFC")]
		public int stickIndex;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5ED34", Offset = "0xD5ED34")]
		public UnityEvent OnStick;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody body;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Stickable> stickers;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Joint> joints;

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x225B3BC", Offset = "0x225B3BC", VA = "0x225B3BC")]
		private void Start()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x225B4D4", Offset = "0x225B4D4", VA = "0x225B4D4")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x225B590", Offset = "0x225B590", VA = "0x225B590")]
		private void CreateStick(Stickable sticker)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x225B794", Offset = "0x225B794", VA = "0x225B794")]
		private void OnJointBreak(float breakForce)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x225B7C0", Offset = "0x225B7C0", VA = "0x225B7C0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD60A28", Offset = "0xD60A28")]
		private IEnumerator JointBreak()
		{
			return null;
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x225B858", Offset = "0x225B858", VA = "0x225B858")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x225B930", Offset = "0x225B930", VA = "0x225B930")]
		public Sticky()
		{
		}
	}
}
namespace Autohand.Demo
{
	[Token(Token = "0x2000081")]
	public class XRAutoHandAxisFingerBender : MonoBehaviour
	{
		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public XRHandControllerLink controller;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CommonAxis axis;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public float[] bendOffsets;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float lastAxis;

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x225EF48", Offset = "0x225EF48", VA = "0x225EF48")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x225F05C", Offset = "0x225F05C", VA = "0x225F05C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x225F174", Offset = "0x225F174", VA = "0x225F174")]
		public XRAutoHandAxisFingerBender()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class XRAutoHandFingerBender : MonoBehaviour
	{
		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public XRHandControllerLink controller;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CommonButton button;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public float[] bendOffsets;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool pressed;

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x225F17C", Offset = "0x225F17C", VA = "0x225F17C")]
		private void Update()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x225F334", Offset = "0x225F334", VA = "0x225F334")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x225F44C", Offset = "0x225F44C", VA = "0x225F44C")]
		public XRAutoHandFingerBender()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class XRControllerEvent : MonoBehaviour
	{
		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public XRHandControllerLink link;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CommonButton button;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEvent Pressed;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityEvent Released;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool pressed;

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x225F454", Offset = "0x225F454", VA = "0x225F454")]
		private void Update()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x225F4DC", Offset = "0x225F4DC", VA = "0x225F4DC")]
		public XRControllerEvent()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public enum CommonButton
	{
		[Token(Token = "0x40003E9")]
		gripButton,
		[Token(Token = "0x40003EA")]
		menuButton,
		[Token(Token = "0x40003EB")]
		primaryButton,
		[Token(Token = "0x40003EC")]
		secondaryButton,
		[Token(Token = "0x40003ED")]
		triggerButton,
		[Token(Token = "0x40003EE")]
		primary2DAxisClick,
		[Token(Token = "0x40003EF")]
		primary2DAxisTouch,
		[Token(Token = "0x40003F0")]
		secondary2DAxisClick,
		[Token(Token = "0x40003F1")]
		secondary2DAxisTouch,
		[Token(Token = "0x40003F2")]
		primaryTouch,
		[Token(Token = "0x40003F3")]
		secondaryTouch,
		[Token(Token = "0x40003F4")]
		none
	}
	[Token(Token = "0x2000085")]
	public enum CommonAxis
	{
		[Token(Token = "0x40003F6")]
		trigger,
		[Token(Token = "0x40003F7")]
		grip,
		[Token(Token = "0x40003F8")]
		none
	}
	[Token(Token = "0x2000086")]
	public enum Common2DAxis
	{
		[Token(Token = "0x40003FA")]
		primaryAxis,
		[Token(Token = "0x40003FB")]
		secondaryAxis,
		[Token(Token = "0x40003FC")]
		none
	}
	[Token(Token = "0x2000087")]
	public class XRHandControllerLink : HandControllerLink
	{
		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CommonButton grabButton;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5ED8C", Offset = "0xD5ED8C")]
		public CommonAxis grabAxis;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CommonButton squeezeButton;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private XRNode role;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool squeezing;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool grabbing;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InputDevice device;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<InputDevice> devices;

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x225F4E4", Offset = "0x225F4E4", VA = "0x225F4E4")]
		private void Start()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x225F5C0", Offset = "0x225F5C0", VA = "0x225F5C0")]
		private void Update()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x225F664", Offset = "0x225F664", VA = "0x225F664")]
		public List<InputDevice> Devices()
		{
			return null;
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x225F2D0", Offset = "0x225F2D0", VA = "0x225F2D0")]
		public bool ButtonPressed(CommonButton button)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x225F004", Offset = "0x225F004", VA = "0x225F004")]
		public float GetAxis(CommonAxis axis)
		{
			return default(float);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x225F964", Offset = "0x225F964", VA = "0x225F964")]
		public Vector2 GetAxis2D(Common2DAxis axis)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x225FA4C", Offset = "0x225FA4C", VA = "0x225FA4C", Slot = "4")]
		public override void TryHapticImpulse(float duration, float amp, float freq = 0f)
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x225F66C", Offset = "0x225F66C", VA = "0x225F66C")]
		public static InputFeatureUsage<bool> GetCommonButton(CommonButton button)
		{
			return default(InputFeatureUsage<bool>);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x225F8D0", Offset = "0x225F8D0", VA = "0x225F8D0")]
		public static InputFeatureUsage<float> GetCommonAxis(CommonAxis axis)
		{
			return default(InputFeatureUsage<float>);
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x225F9BC", Offset = "0x225F9BC", VA = "0x225F9BC")]
		public static InputFeatureUsage<Vector2> GetCommon2DAxis(Common2DAxis axis)
		{
			return default(InputFeatureUsage<Vector2>);
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x225FBC0", Offset = "0x225FBC0", VA = "0x225FBC0")]
		public XRHandControllerLink()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class XRHandPlayerControllerLink : MonoBehaviour
	{
		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public XRHandControllerLink moveController;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public XRHandControllerLink turnController;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AutoHandPlayer player;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5EDC4", Offset = "0xD5EDC4")]
		public Common2DAxis moveAxis;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Common2DAxis turnAxis;

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x2260B9C", Offset = "0x2260B9C", VA = "0x2260B9C")]
		private void Update()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x2260C10", Offset = "0x2260C10", VA = "0x2260C10")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x2260C5C", Offset = "0x2260C5C", VA = "0x2260C5C")]
		public XRHandPlayerControllerLink()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class XRHandPointGrabLink : MonoBehaviour
	{
		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HandDistanceGrabber pointGrab;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public XRHandControllerLink link;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5EDFC", Offset = "0xD5EDFC")]
		public CommonButton pointInput;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public CommonButton selectInput;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool pointing;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool selecting;

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x2260C64", Offset = "0x2260C64", VA = "0x2260C64")]
		private void Update()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x2260D64", Offset = "0x2260D64", VA = "0x2260D64")]
		public XRHandPointGrabLink()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class XRHeadTracking : MonoBehaviour
	{
		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TrackingOriginModeFlags mode;

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x2260D6C", Offset = "0x2260D6C", VA = "0x2260D6C")]
		private void Start()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x2260E98", Offset = "0x2260E98", VA = "0x2260E98")]
		public XRHeadTracking()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class XRTeleporterLink : MonoBehaviour
	{
		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Teleporter hand;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public XRNode role;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public CommonButton button;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool teleporting;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private InputDevice device;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<InputDevice> devices;

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x226129C", Offset = "0x226129C", VA = "0x226129C")]
		private void Start()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x226130C", Offset = "0x226130C", VA = "0x226130C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x2261424", Offset = "0x2261424", VA = "0x2261424")]
		public XRTeleporterLink()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public class BoxingGlove : MonoBehaviour
	{
		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody body;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float power;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float lastHitTime;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float delay;

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x233A8B8", Offset = "0x233A8B8", VA = "0x233A8B8")]
		public void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x233A94C", Offset = "0x233A94C", VA = "0x233A94C")]
		public BoxingGlove()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class CubeBreak : MonoBehaviour
	{
		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float force;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3[] offsets;

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x233CC18", Offset = "0x233CC18", VA = "0x233CC18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD60AD8", Offset = "0xD60AD8")]
		public void Break()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x233D254", Offset = "0x233D254", VA = "0x233D254")]
		public CubeBreak()
		{
		}
	}
	[Token(Token = "0x200008E")]
	public class DemoFlyingToggle : MonoBehaviour
	{
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x233D420", Offset = "0x233D420", VA = "0x233D420")]
		public void ToggleFlying()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x233D484", Offset = "0x233D484", VA = "0x233D484")]
		public DemoFlyingToggle()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class Door : PhysicsGadgetHingeAngleReader
	{
		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5EE34", Offset = "0xD5EE34")]
		public Rigidbody body;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 closedPosition;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Quaternion closedRotation;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5EE6C", Offset = "0xD5EE6C")]
		public float minThreshold;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float midThreshold;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5EEA4", Offset = "0xD5EEA4")]
		public float maxThreshold;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD5EEDC", Offset = "0xD5EEDC")]
		public UnityEvent OnMax;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public UnityEvent OnMid;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UnityEvent OnMin;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool min;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		private bool max;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9A")]
		private bool mid;

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x233DE70", Offset = "0x233DE70", VA = "0x233DE70")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x233DF8C", Offset = "0x233DF8C", VA = "0x233DF8C")]
		protected void FixedUpdate()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x233E0D8", Offset = "0x233E0D8", VA = "0x233E0D8")]
		private void Max()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x233E11C", Offset = "0x233E11C", VA = "0x233E11C")]
		private void Mid()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x233E0F8", Offset = "0x233E0F8", VA = "0x233E0F8")]
		private void Min()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x233E140", Offset = "0x233E140", VA = "0x233E140")]
		public void ClosedDoor()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x233E1AC", Offset = "0x233E1AC", VA = "0x233E1AC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x233E284", Offset = "0x233E284", VA = "0x233E284")]
		public Door()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class ExplosionSource : MonoBehaviour
	{
		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float radius;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float force;

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x233E358", Offset = "0x233E358", VA = "0x233E358")]
		public void Explode(bool destroy)
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x233E528", Offset = "0x233E528", VA = "0x233E528")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x233E578", Offset = "0x233E578", VA = "0x233E578")]
		public ExplosionSource()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class Grenade : MonoBehaviour
	{
		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Grabbable grenade;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Grabbable pin;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ConfigurableJoint pinJoint;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float explosionDelay;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool startDelayOnRelease;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float explosionForce;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float explosionRadius;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pinJointStrength;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject explosionEffect;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityEvent pinBreakEvent;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UnityEvent explosionEvent;

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x23D2220", Offset = "0x23D2220", VA = "0x23D2220")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x23D24F0", Offset = "0x23D24F0", VA = "0x23D24F0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x23D26DC", Offset = "0x23D26DC", VA = "0x23D26DC")]
		private void OnGrenadeGrab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x23D2764", Offset = "0x23D2764", VA = "0x23D2764")]
		private void OnGrenadeRelease(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x23D287C", Offset = "0x23D287C", VA = "0x23D287C")]
		private void OnPinGrab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x23D2910", Offset = "0x23D2910", VA = "0x23D2910")]
		private void OnPinRelease(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x23D29A8", Offset = "0x23D29A8", VA = "0x23D29A8")]
		private void OnJointBreak(float breakForce)
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x23D2A04", Offset = "0x23D2A04", VA = "0x23D2A04")]
		private void CheckJointBreak()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x23D2AF8", Offset = "0x23D2AF8", VA = "0x23D2AF8")]
		private void Explode()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x23D2F70", Offset = "0x23D2F70", VA = "0x23D2F70")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x23D2FC4", Offset = "0x23D2FC4", VA = "0x23D2FC4")]
		public Grenade()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class HandSwapper : MonoBehaviour
	{
		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AutoHandPlayer player;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Hand fromHand;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Hand toHand;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject fromModel;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject toModel;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool swapped;

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x1CA6CF8", Offset = "0x1CA6CF8", VA = "0x1CA6CF8")]
		public void Swap()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x1CA6E78", Offset = "0x1CA6E78", VA = "0x1CA6E78")]
		public HandSwapper()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class JointBreakStopForce1 : MonoBehaviour
	{
		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1CABD60", Offset = "0x1CABD60", VA = "0x1CABD60")]
		private void OnJointBreak(float breakForce)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x1CABE40", Offset = "0x1CABE40", VA = "0x1CABE40")]
		public JointBreakStopForce1()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class Pistol : MonoBehaviour
	{
		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody body;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform barrelTip;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float hitPower;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float recoilPower;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float range;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask layer;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioClip shootSound;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float shootVolume;

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1CADEB4", Offset = "0x1CADEB4", VA = "0x1CADEB4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x1CADF94", Offset = "0x1CADF94", VA = "0x1CADF94")]
		public void Shoot()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x1CAE3D8", Offset = "0x1CAE3D8", VA = "0x1CAE3D8")]
		public Pistol()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class PlayerFallCatcher : MonoBehaviour
	{
		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 startPos;

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1CB0794", Offset = "0x1CB0794", VA = "0x1CB0794")]
		private void Start()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1CB0918", Offset = "0x1CB0918", VA = "0x1CB0918")]
		private void Update()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x1CB0A5C", Offset = "0x1CB0A5C", VA = "0x1CB0A5C")]
		public PlayerFallCatcher()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class ScaleHighlight : MonoBehaviour
	{
		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 highlighScale;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 normalScale;

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x1CB0AA0", Offset = "0x1CB0AA0", VA = "0x1CB0AA0")]
		public void Highlight()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x1CB0AD8", Offset = "0x1CB0AD8", VA = "0x1CB0AD8")]
		public void HighlightStop()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x1CB0B10", Offset = "0x1CB0B10", VA = "0x1CB0B10")]
		public ScaleHighlight()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class Spinner : MonoBehaviour
	{
		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 rotationSpeed;

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x1CB1B08", Offset = "0x1CB1B08", VA = "0x1CB1B08")]
		private void Update()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x1CB1B70", Offset = "0x1CB1B70", VA = "0x1CB1B70")]
		public Spinner()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class ToggleAutoMoveFlying : MonoBehaviour
	{
		[Token(Token = "0x600041E")]
		[Address(RVA = "0x225CC80", Offset = "0x225CC80", VA = "0x225CC80")]
		public void ToggleFlying()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x225CD08", Offset = "0x225CD08", VA = "0x225CD08")]
		public ToggleAutoMoveFlying()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class ToggleHandProjection : MonoBehaviour
	{
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x225CD10", Offset = "0x225CD10", VA = "0x225CD10")]
		public void DisableGripProjection()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x225CDE4", Offset = "0x225CDE4", VA = "0x225CDE4")]
		public void EnableGripProjection()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x225CEB8", Offset = "0x225CEB8", VA = "0x225CEB8")]
		public void DisableHighlightProjection()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x225CF8C", Offset = "0x225CF8C", VA = "0x225CF8C")]
		public void EnableHighlightProjection()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x225D060", Offset = "0x225D060", VA = "0x225D060")]
		public ToggleHandProjection()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class TomatoSpawner : MonoBehaviour
	{
		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] tomatoes;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<GameObject> copies;

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x225D068", Offset = "0x225D068", VA = "0x225D068")]
		private void Start()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x225D28C", Offset = "0x225D28C", VA = "0x225D28C")]
		public void SpawnTomato()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x225D478", Offset = "0x225D478", VA = "0x225D478")]
		public TomatoSpawner()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class ButtonDemoRespawn : MonoBehaviour
	{
		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform root;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Transform> respawns;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Vector3> startPos;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<Quaternion> startRot;

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x233A964", Offset = "0x233A964", VA = "0x233A964")]
		private void Start()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x233AC58", Offset = "0x233AC58", VA = "0x233AC58")]
		public void Respawn()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x233AFF8", Offset = "0x233AFF8", VA = "0x233AFF8")]
		public void ReloadScene()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x233B074", Offset = "0x233B074", VA = "0x233B074")]
		public ButtonDemoRespawn()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class DialHandScaler : PhysicsGadgetHingeAngleReader
	{
		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Hand hand;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 minScale;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector3 maxScale;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float startReach;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 startScale;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float[] fingersStartScale;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 lastHandScale;

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x233D584", Offset = "0x233D584", VA = "0x233D584")]
		protected new void Start()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x233D6B4", Offset = "0x233D6B4", VA = "0x233D6B4")]
		private void Update()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x233D8D8", Offset = "0x233D8D8", VA = "0x233D8D8")]
		public DialHandScaler()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class JoystickObjectMover : PhysicsGadgetJoystick
	{
		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform move;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float speed;

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1CAC0F0", Offset = "0x1CAC0F0", VA = "0x1CAC0F0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x1CAC25C", Offset = "0x1CAC25C", VA = "0x1CAC25C")]
		public JoystickObjectMover()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class MoverLever : PhysicsGadgetHingeAngleReader
	{
		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform move;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 axis;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float speed;

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x1CAC788", Offset = "0x1CAC788", VA = "0x1CAC788")]
		private void Update()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1CAC888", Offset = "0x1CAC888", VA = "0x1CAC888")]
		public MoverLever()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class PhysicsSliderPositionMover : PhysicsGadgetConfigurableLimitReader
	{
		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5EEEC", Offset = "0xD5EEEC")]
		public Transform move;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5EF24", Offset = "0xD5EF24")]
		public Vector3 axis;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5EF5C", Offset = "0xD5EF5C")]
		public bool useRange;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 minRange;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 maxRange;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 startPos;

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1CADCD4", Offset = "0x1CADCD4", VA = "0x1CADCD4")]
		protected new void Start()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1CADD10", Offset = "0x1CADD10", VA = "0x1CADD10")]
		public void FixedUpdate()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x1CADE48", Offset = "0x1CADE48", VA = "0x1CADE48")]
		public PhysicsSliderPositionMover()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class WheelRotator : PhysicsGadgetHingeAngleReader
	{
		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform move;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 angle;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool useLocal;

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x225EB1C", Offset = "0x225EB1C", VA = "0x225EB1C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x225ECA0", Offset = "0x225ECA0", VA = "0x225ECA0")]
		public WheelRotator()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class LeverTextChanger : MonoBehaviour
	{
		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshPro text;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PhysicsGadgetHingeAngleReader sliderReader;

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1CAC5C8", Offset = "0x1CAC5C8", VA = "0x1CAC5C8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x1CAC780", Offset = "0x1CAC780", VA = "0x1CAC780")]
		public LeverTextChanger()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class SliderTextChanger : MonoBehaviour
	{
		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshPro text;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PhysicsGadgetConfigurableLimitReader sliderReader;

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1CB0B18", Offset = "0x1CB0B18", VA = "0x1CB0B18")]
		private void Update()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1CB0BD4", Offset = "0x1CB0BD4", VA = "0x1CB0BD4")]
		public SliderTextChanger()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public class TextChanger : MonoBehaviour
	{
		[Token(Token = "0x20000A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD5987C", Offset = "0xD5987C")]
		private sealed class <ChangeText>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TextChanger <>4__this;

			[Token(Token = "0x1700004B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000444")]
				[Address(RVA = "0x226675C", Offset = "0x226675C", VA = "0x226675C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000446")]
				[Address(RVA = "0x22667A4", Offset = "0x22667A4", VA = "0x22667A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000441")]
			[Address(RVA = "0x225C670", Offset = "0x225C670", VA = "0x225C670")]
			[DebuggerHidden]
			public <ChangeText>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000442")]
			[Address(RVA = "0x2266690", Offset = "0x2266690", VA = "0x2266690", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000443")]
			[Address(RVA = "0x2266694", Offset = "0x2266694", VA = "0x2266694", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000445")]
			[Address(RVA = "0x2266764", Offset = "0x2266764", VA = "0x2266764", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshPro text;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Coroutine changing;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Coroutine hide;

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x225C5FC", Offset = "0x225C5FC", VA = "0x225C5FC")]
		public void UpdateText(string newText, float upTime)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x225C600", Offset = "0x225C600", VA = "0x225C600")]
		public void UpdateText(string newText)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x225C604", Offset = "0x225C604", VA = "0x225C604")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD60B10", Offset = "0xD60B10")]
		private IEnumerator ChangeText(float seconds, string newText)
		{
			return null;
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x225C69C", Offset = "0x225C69C", VA = "0x225C69C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x225C6FC", Offset = "0x225C6FC", VA = "0x225C6FC")]
		public TextChanger()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class TextGrabEvent : MonoBehaviour
	{
		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextChanger changer;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Grabbable grab;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0xD5EF94", Offset = "0xD5EF94")]
		public string message;

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x225C70C", Offset = "0x225C70C", VA = "0x225C70C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x225C8F8", Offset = "0x225C8F8", VA = "0x225C8F8")]
		private void OnGrab(Hand hand, Grabbable grab)
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x225C8FC", Offset = "0x225C8FC", VA = "0x225C8FC")]
		public TextGrabEvent()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class TextPlacePointEvent : MonoBehaviour
	{
		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextChanger changer;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlacePoint point;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0xD5EFA4", Offset = "0xD5EFA4")]
		public string placeMessage;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0xD5EFB4", Offset = "0xD5EFB4")]
		public string highlightMessage;

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x225CA68", Offset = "0x225CA68", VA = "0x225CA68")]
		private void Start()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x225CC40", Offset = "0x225CC40", VA = "0x225CC40")]
		private void OnGrab(PlacePoint hand, Grabbable grab)
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x225CC58", Offset = "0x225CC58", VA = "0x225CC58")]
		private void OnHighlight(PlacePoint hand, Grabbable grab)
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x225CC70", Offset = "0x225CC70", VA = "0x225CC70")]
		public TextPlacePointEvent()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class WristLookEvent : MonoBehaviour
	{
		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Hand hand;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Camera head;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5EFC4", Offset = "0xD5EFC4")]
		public float maxDistance;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD5EFFC", Offset = "0xD5EFFC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5EFFC", Offset = "0xD5EFFC")]
		public float anglePreciseness;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool disableWhileHolding;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5F050", Offset = "0xD5F050")]
		public UnityHandEvent OnShow;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityHandEvent OnHide;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool showing;

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x225ECA8", Offset = "0x225ECA8", VA = "0x225ECA8")]
		private void Update()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x225EF30", Offset = "0x225EF30", VA = "0x225EF30")]
		public WristLookEvent()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD5988C", Offset = "0xD5988C")]
	public class GrabbableEventDebugger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD598EC", Offset = "0xD598EC")]
		private sealed class <>c
		{
			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static HandGrabEvent <>9__0_0;

			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static HandGrabEvent <>9__0_1;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static HandGrabEvent <>9__0_2;

			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static HandGrabEvent <>9__0_3;

			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static HandGrabEvent <>9__0_4;

			[Token(Token = "0x4000483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static HandGrabEvent <>9__0_5;

			[Token(Token = "0x4000484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static HandGrabEvent <>9__0_6;

			[Token(Token = "0x4000485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static HandGrabEvent <>9__0_7;

			[Token(Token = "0x4000486")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static HandGrabEvent <>9__1_0;

			[Token(Token = "0x4000487")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static HandGrabEvent <>9__1_1;

			[Token(Token = "0x4000488")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public static HandGrabEvent <>9__1_2;

			[Token(Token = "0x4000489")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public static HandGrabEvent <>9__1_3;

			[Token(Token = "0x400048A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public static HandGrabEvent <>9__1_4;

			[Token(Token = "0x400048B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public static HandGrabEvent <>9__1_5;

			[Token(Token = "0x400048C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public static HandGrabEvent <>9__1_6;

			[Token(Token = "0x400048D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public static HandGrabEvent <>9__1_7;

			[Token(Token = "0x6000454")]
			[Address(RVA = "0x2261C08", Offset = "0x2261C08", VA = "0x2261C08")]
			public <>c()
			{
			}

			[Token(Token = "0x6000455")]
			[Address(RVA = "0x2261C10", Offset = "0x2261C10", VA = "0x2261C10")]
			internal void <OnEnable>b__0_0(Hand hand, Grabbable grabbable)
			{
			}

			[Token(Token = "0x6000456")]
			[Address(RVA = "0x2261CB0", Offset = "0x2261CB0", VA = "0x2261CB0")]
			internal void <OnEnable>b__0_1(Hand hand, Grabbable grabbable)
			{
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0x2261D50", Offset = "0x2261D50", VA = "0x2261D50")]
			internal void <OnEnable>b__0_2(Hand hand, Grabbable grabbable)
			{
			}

			[Token(Token = "0x6000458")]
			[Address(RVA = "0x2261DF0", Offset = "0x2261DF0", VA = "0x2261DF0")]
			internal void <OnEnable>b__0_3(Hand hand, Grabbable grabbable)
			{
			}

			[Token(Token = "0x6000459")]
			[Address(RVA = "0x2261E90", Offset = "0x2261E90", VA = "0x2261E90")]
			internal void <OnEnable>b__0_4(Hand hand, Grabbable grabbable)
			{
			}

			[Token(Token = "0x600045A")]
			[Address(RVA = "0x2261F30", Offset = "0x2261F30", VA = "0x2261F30")]
			internal void <OnEnable>b__0_5(Hand hand, Grabbable grabbable)
			{
			}

			[Token(Token = "0x600045B")]
			[Address(RVA = "0x2261FD0", Offset = "0x2261FD0", VA = "0x2261FD0")]
			internal void <OnEnable>b__0_6(Hand hand, Grabbable grabbable)
			{
			}

			[Token(Token = "0x600045C")]
			[Address(RVA = "0x2262070", Offset = "0x2262070", VA = "0x2262070")]
			internal void <OnEnable>b__0_7(Hand hand, Grabbable grabbable)
			{
			}

			[Token(Token = "0x600045D")]
			[Address(RVA = "0x2262110", Offset = "0x2262110", VA = "0x2262110")]
			internal void <OnDisable>b__1_0(Hand hand, Grabbable grabbable)
			{
			}

			[Token(Token = "0x600045E")]
			[Address(RVA = "0x22621B0", Offset = "0x22621B0", VA = "0x22621B0")]
			internal void <OnDisable>b__1_1(Hand hand, Grabbable grabbable)
			{
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0x2262250", Offset = "0x2262250", VA = "0x2262250")]
			internal void <OnDisable>b__1_2(Hand hand, Grabbable grabbable)
			{
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0x22622F0", Offset = "0x22622F0", VA = "0x22622F0")]
			internal void <OnDisable>b__1_3(Hand hand, Grabbable grabbable)
			{
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0x2262390", Offset = "0x2262390", VA = "0x2262390")]
			internal void <OnDisable>b__1_4(Hand hand, Grabbable grabbable)
			{
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0x2262430", Offset = "0x2262430", VA = "0x2262430")]
			internal void <OnDisable>b__1_5(Hand hand, Grabbable grabbable)
			{
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0x22624D0", Offset = "0x22624D0", VA = "0x22624D0")]
			internal void <OnDisable>b__1_6(Hand hand, Grabbable grabbable)
			{
			}

			[Token(Token = "0x6000464")]
			[Address(RVA = "0x2262570", Offset = "0x2262570", VA = "0x2262570")]
			internal void <OnDisable>b__1_7(Hand hand, Grabbable grabbable)
			{
			}
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x23CD5B0", Offset = "0x23CD5B0", VA = "0x23CD5B0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x23CDBD0", Offset = "0x23CDBD0", VA = "0x23CDBD0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x23CE1F0", Offset = "0x23CE1F0", VA = "0x23CE1F0")]
		public GrabbableEventDebugger()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD598FC", Offset = "0xD598FC")]
	public class HandEventDebugger : MonoBehaviour
	{
		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool showSqueezeEvents;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool showHighlightEvents;

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1CA035C", Offset = "0x1CA035C", VA = "0x1CA035C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x1CA05F4", Offset = "0x1CA05F4", VA = "0x1CA05F4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x1CA087C", Offset = "0x1CA087C", VA = "0x1CA087C")]
		public HandEventDebugger()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x1CA088C", Offset = "0x1CA088C", VA = "0x1CA088C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60BC0", Offset = "0xD60BC0")]
		private void <OnEnable>b__2_0(Hand hand, Grabbable grabbable)
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x1CA093C", Offset = "0x1CA093C", VA = "0x1CA093C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60BD0", Offset = "0xD60BD0")]
		private void <OnEnable>b__2_1(Hand hand, Grabbable grabbable)
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x1CA09EC", Offset = "0x1CA09EC", VA = "0x1CA09EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60BE0", Offset = "0xD60BE0")]
		private void <OnEnable>b__2_2(Hand hand, Grabbable grabbable)
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x1CA0A9C", Offset = "0x1CA0A9C", VA = "0x1CA0A9C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60BF0", Offset = "0xD60BF0")]
		private void <OnEnable>b__2_3(Hand hand, Grabbable grabbable)
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x1CA0B4C", Offset = "0x1CA0B4C", VA = "0x1CA0B4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60C00", Offset = "0xD60C00")]
		private void <OnEnable>b__2_4(Hand hand, Grabbable grabbable)
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x1CA0BFC", Offset = "0x1CA0BFC", VA = "0x1CA0BFC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60C10", Offset = "0xD60C10")]
		private void <OnEnable>b__2_5(Hand hand, Grabbable grabbable)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x1CA0CAC", Offset = "0x1CA0CAC", VA = "0x1CA0CAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60C20", Offset = "0xD60C20")]
		private void <OnEnable>b__2_6(Hand hand, Grabbable grabbable)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x1CA0D5C", Offset = "0x1CA0D5C", VA = "0x1CA0D5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60C30", Offset = "0xD60C30")]
		private void <OnEnable>b__2_7(Hand hand, Grabbable grabbable)
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x1CA0E0C", Offset = "0x1CA0E0C", VA = "0x1CA0E0C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60C40", Offset = "0xD60C40")]
		private void <OnDisable>b__3_0(Hand hand, Grabbable grabbable)
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x1CA0EBC", Offset = "0x1CA0EBC", VA = "0x1CA0EBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60C50", Offset = "0xD60C50")]
		private void <OnDisable>b__3_1(Hand hand, Grabbable grabbable)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x1CA0F6C", Offset = "0x1CA0F6C", VA = "0x1CA0F6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60C60", Offset = "0xD60C60")]
		private void <OnDisable>b__3_2(Hand hand, Grabbable grabbable)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x1CA101C", Offset = "0x1CA101C", VA = "0x1CA101C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60C70", Offset = "0xD60C70")]
		private void <OnDisable>b__3_3(Hand hand, Grabbable grabbable)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x1CA10CC", Offset = "0x1CA10CC", VA = "0x1CA10CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60C80", Offset = "0xD60C80")]
		private void <OnDisable>b__3_4(Hand hand, Grabbable grabbable)
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x1CA117C", Offset = "0x1CA117C", VA = "0x1CA117C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60C90", Offset = "0xD60C90")]
		private void <OnDisable>b__3_5(Hand hand, Grabbable grabbable)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x1CA122C", Offset = "0x1CA122C", VA = "0x1CA122C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60CA0", Offset = "0xD60CA0")]
		private void <OnDisable>b__3_6(Hand hand, Grabbable grabbable)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x1CA12DC", Offset = "0x1CA12DC", VA = "0x1CA12DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60CB0", Offset = "0xD60CB0")]
		private void <OnDisable>b__3_7(Hand hand, Grabbable grabbable)
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class HandTouchEventDebugger : MonoBehaviour
	{
		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HandTouchEvent touchEvent;

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x1CA82E0", Offset = "0x1CA82E0", VA = "0x1CA82E0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x1CA83F4", Offset = "0x1CA83F4", VA = "0x1CA83F4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x1CA8508", Offset = "0x1CA8508", VA = "0x1CA8508")]
		private void StartTouch(Hand hand)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x1CA85B0", Offset = "0x1CA85B0", VA = "0x1CA85B0")]
		private void StopTouch(Hand hand)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x1CA8658", Offset = "0x1CA8658", VA = "0x1CA8658")]
		public HandTouchEventDebugger()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class Smash : MonoBehaviour
	{
		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5F088", Offset = "0xD5F088")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5F088", Offset = "0xD5F088")]
		public float smashForce;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5F0E8", Offset = "0xD5F0E8")]
		public bool destroyOnSmash;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5F120", Offset = "0xD5F120")]
		[AttributeAttribute(Name = "HideIfAttribute", RVA = "0xD5F120", Offset = "0xD5F120")]
		public bool releaseOnSmash;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5F180", Offset = "0xD5F180")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5F180", Offset = "0xD5F180")]
		public ParticleSystem effect;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5F1E0", Offset = "0xD5F1E0")]
		public bool createNewEffect;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5F218", Offset = "0xD5F218")]
		public bool applyVelocityOnSmash;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5F250", Offset = "0xD5F250")]
		public AudioClip smashSound;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float smashVolume;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5F288", Offset = "0xD5F288")]
		public UnityEvent OnSmash;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public SmashEvent OnSmashEvent;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal Grabbable grabbable;

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x1CB0BDC", Offset = "0x1CB0BDC", VA = "0x1CB0BDC")]
		public void Start()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x1CB0D58", Offset = "0x1CB0D58", VA = "0x1CB0D58")]
		public void DelayedSmash(float delay)
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x1CAE3D0", Offset = "0x1CAE3D0", VA = "0x1CAE3D0")]
		public void DoSmash()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x1CB0DB8", Offset = "0x1CB0DB8", VA = "0x1CB0DB8")]
		public void DoSmash(Smasher smash)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x1CB1550", Offset = "0x1CB1550", VA = "0x1CB1550")]
		public Smash()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x1CB156C", Offset = "0x1CB156C", VA = "0x1CB156C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60CC0", Offset = "0xD60CC0")]
		private void <Start>b__11_0(Smasher smasher, Smash smashable)
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public delegate void SmashEvent(Smasher smasher, Smash smashable);
	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD5995C", Offset = "0xD5995C")]
	public class Smasher : MonoBehaviour
	{
		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Rigidbody rb;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5F2C0", Offset = "0xD5F2C0")]
		public LayerMask smashableLayers;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5F2F8", Offset = "0xD5F2F8")]
		public float forceMulti;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD5F330", Offset = "0xD5F330")]
		public Transform centerOfMassPoint;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD5F368", Offset = "0xD5F368")]
		public UnityEvent OnSmash;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SmashEvent OnSmashEvent;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3[] velocityOverTime;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 lastPos;

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x1CB15BC", Offset = "0x1CB15BC", VA = "0x1CB15BC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x1CB1758", Offset = "0x1CB1758", VA = "0x1CB1758")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x1CB18E0", Offset = "0x1CB18E0", VA = "0x1CB18E0")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x1CB19C8", Offset = "0x1CB19C8", VA = "0x1CB19C8")]
		private float GetMagnitude()
		{
			return default(float);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x1CB1A90", Offset = "0x1CB1A90", VA = "0x1CB1A90")]
		public Smasher()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x1CB1AF4", Offset = "0x1CB1AF4", VA = "0x1CB1AF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD60CD0", Offset = "0xD60CD0")]
		private void <Start>b__8_0(Smasher smasher, Smash smashable)
		{
		}
	}
}
