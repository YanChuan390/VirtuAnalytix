using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HurricaneVR.Framework.Components;
using HurricaneVR.Framework.ControllerInput;
using HurricaneVR.Framework.Core;
using HurricaneVR.Framework.Core.Grabbers;
using HurricaneVR.Framework.Core.Player;
using HurricaneVR.Framework.Core.Sockets;
using HurricaneVR.Framework.Core.Stabbing;
using HurricaneVR.Framework.Core.UI;
using HurricaneVR.Framework.Core.Utils;
using HurricaneVR.Samples;
using Il2CppDummyDll;
using Oculus.Platform;
using Oculus.Platform.Models;
using Pico.Platform;
using Pico.Platform.Models;
using StylizedWater;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations.Rigging;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.Localization;
using UnityEngine.Rendering;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.Scripting;
using UnityEngine.UI;
using UnityEngine.Video;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class BodyWithoutCameraMotion : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform cameraRig;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform player;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xD2D3E0", Offset = "0xD2D3E0", VA = "0xD2D3E0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xD2D3E4", Offset = "0xD2D3E4", VA = "0xD2D3E4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xD2D51C", Offset = "0xD2D51C", VA = "0xD2D51C")]
	public BodyWithoutCameraMotion()
	{
	}
}
[Token(Token = "0x2000003")]
public class DesintegrateAndRespawn : MonoBehaviour
{
	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADB50", Offset = "0x9ADB50")]
	private sealed class <desintegrationCoroutine>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DesintegrateAndRespawn <>4__this;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <time>5__2;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0xEDCE08", Offset = "0xEDCE08", VA = "0xEDCE08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0xEDCE50", Offset = "0xEDCE50", VA = "0xEDCE50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0xEDCBAC", Offset = "0xEDCBAC", VA = "0xEDCBAC")]
		[DebuggerHidden]
		public <desintegrationCoroutine>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0xEDCBD8", Offset = "0xEDCBD8", VA = "0xEDCBD8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0xEDCBDC", Offset = "0xEDCBDC", VA = "0xEDCBDC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0xEDCE10", Offset = "0xEDCE10", VA = "0xEDCE10", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private HVRGrabbable grabbable;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float timeUntilDesintegration;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 pointToRespawn;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float disolveTime;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Renderer[] rendereresToDissolve;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Material> materialsToDissolve;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xD35F5C", Offset = "0xD35F5C", VA = "0xD35F5C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xD36154", Offset = "0xD36154", VA = "0xD36154")]
	private void Desintegrate(HVRGrabberBase arg0, HVRGrabbable arg1)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xD36180", Offset = "0xD36180", VA = "0xD36180")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9AFF50", Offset = "0x9AFF50")]
	private IEnumerator desintegrationCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xD361EC", Offset = "0xD361EC", VA = "0xD361EC")]
	private void StopDesintegraiton(HVRGrabberBase arg0, HVRGrabbable arg1)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xD36218", Offset = "0xD36218", VA = "0xD36218")]
	private void SetDissolveAmount(float dissolveAmount)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xD36358", Offset = "0xD36358", VA = "0xD36358")]
	public DesintegrateAndRespawn()
	{
	}
}
[Token(Token = "0x2000005")]
public class DisableChildCollisionsTest : MonoBehaviour
{
	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private HVRGrabbable grabbable;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private HVRSocket socket;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public HVRHandGrabber HandGrabber;

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xD37158", Offset = "0xD37158", VA = "0xD37158")]
	private void Start()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xD372B4", Offset = "0xD372B4", VA = "0xD372B4")]
	private void DisableChildHandCollision(HVRGrabberBase graber, HVRGrabbable grabbable)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xD3739C", Offset = "0xD3739C", VA = "0xD3739C")]
	public void FindDirectHandDisableChild(HVRGrabberBase socketGrabber, HVRGrabbable socketgrabbable)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xD374FC", Offset = "0xD374FC", VA = "0xD374FC")]
	private void DisableHandCollision(HVRGrabberBase graber, HVRGrabbable grabbable)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xD37500", Offset = "0xD37500", VA = "0xD37500")]
	public DisableChildCollisionsTest()
	{
	}
}
[Token(Token = "0x2000006")]
public class FloatingBeersHelperScript : MonoBehaviour
{
	[Token(Token = "0x6000015")]
	[Address(RVA = "0xDE0A5C", Offset = "0xDE0A5C", VA = "0xDE0A5C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xDE0A60", Offset = "0xDE0A60", VA = "0xDE0A60")]
	private void Update()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xDE0A64", Offset = "0xDE0A64", VA = "0xDE0A64")]
	public FloatingBeersHelperScript()
	{
	}
}
[Token(Token = "0x2000007")]
public class HVRInputActions : IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
{
	[Token(Token = "0x2000008")]
	public struct LeftHandActions
	{
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private HVRInputActions m_Wrapper;

		[Token(Token = "0x1700000C")]
		public InputAction TriggerPress
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0xF59CB0", Offset = "0xF59CB0", VA = "0xF59CB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		public InputAction Trigger
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0xF59CCC", Offset = "0xF59CCC", VA = "0xF59CCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		public InputAction PrimaryButton
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0xF59CE8", Offset = "0xF59CE8", VA = "0xF59CE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		public InputAction PrimaryTouch
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0xF59D04", Offset = "0xF59D04", VA = "0xF59D04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		public InputAction Menu
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0xF59D20", Offset = "0xF59D20", VA = "0xF59D20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public InputAction Primary2DAxis
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0xF59D3C", Offset = "0xF59D3C", VA = "0xF59D3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		public InputAction Primary2DAxisClick
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0xF59D58", Offset = "0xF59D58", VA = "0xF59D58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		public InputAction Primary2DAxisTouch
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0xF59D74", Offset = "0xF59D74", VA = "0xF59D74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		public InputAction Secondary2DAxis
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0xF59D90", Offset = "0xF59D90", VA = "0xF59D90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public InputAction Secondary2DAxisClick
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0xF59DAC", Offset = "0xF59DAC", VA = "0xF59DAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public InputAction Secondary2DAxisTouch
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0xF59DC8", Offset = "0xF59DC8", VA = "0xF59DC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public InputAction Grip
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0xF59DE4", Offset = "0xF59DE4", VA = "0xF59DE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		public InputAction GripPress
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0xF59E00", Offset = "0xF59E00", VA = "0xF59E00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public InputAction SecondaryButton
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0xF59E1C", Offset = "0xF59E1C", VA = "0xF59E1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public InputAction SecondaryTouch
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0xF59E38", Offset = "0xF59E38", VA = "0xF59E38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		public InputAction TriggerTouch
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0xF59E54", Offset = "0xF59E54", VA = "0xF59E54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public bool enabled
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0xF59EDC", Offset = "0xF59EDC", VA = "0xF59EDC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xF59CA8", Offset = "0xF59CA8", VA = "0xF59CA8")]
		public LeftHandActions(HVRInputActions wrapper)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xF59E70", Offset = "0xF59E70", VA = "0xF59E70")]
		public InputActionMap Get()
		{
			return null;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xF59E8C", Offset = "0xF59E8C", VA = "0xF59E8C")]
		public void Enable()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xF59EB4", Offset = "0xF59EB4", VA = "0xF59EB4")]
		public void Disable()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xF59F04", Offset = "0xF59F04", VA = "0xF59F04")]
		public static implicit operator InputActionMap(LeftHandActions set)
		{
			return null;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xF59F1C", Offset = "0xF59F1C", VA = "0xF59F1C")]
		public void SetCallbacks(ILeftHandActions instance)
		{
		}
	}

	[Token(Token = "0x2000009")]
	public struct RightHandActions
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private HVRInputActions m_Wrapper;

		[Token(Token = "0x1700001D")]
		public InputAction TriggerPress
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0xF5DA50", Offset = "0xF5DA50", VA = "0xF5DA50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		public InputAction Trigger
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0xF5DA6C", Offset = "0xF5DA6C", VA = "0xF5DA6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		public InputAction PrimaryButton
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0xF5DA88", Offset = "0xF5DA88", VA = "0xF5DA88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		public InputAction PrimaryTouch
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0xF5DAA4", Offset = "0xF5DAA4", VA = "0xF5DAA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		public InputAction Menu
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0xF5DAC0", Offset = "0xF5DAC0", VA = "0xF5DAC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		public InputAction Primary2DAxis
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0xF5DADC", Offset = "0xF5DADC", VA = "0xF5DADC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		public InputAction Primary2DAxisClick
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0xF5DAF8", Offset = "0xF5DAF8", VA = "0xF5DAF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		public InputAction Primary2DAxisTouch
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0xF5DB14", Offset = "0xF5DB14", VA = "0xF5DB14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		public InputAction Secondary2DAxis
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0xF5DB30", Offset = "0xF5DB30", VA = "0xF5DB30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		public InputAction Secondary2DAxisClick
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0xF5DB4C", Offset = "0xF5DB4C", VA = "0xF5DB4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		public InputAction Secondary2DAxisTouch
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0xF5DB68", Offset = "0xF5DB68", VA = "0xF5DB68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		public InputAction Grip
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0xF5DB84", Offset = "0xF5DB84", VA = "0xF5DB84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		public InputAction GripPress
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0xF5DBA0", Offset = "0xF5DBA0", VA = "0xF5DBA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		public InputAction SecondaryButton
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0xF5DBBC", Offset = "0xF5DBBC", VA = "0xF5DBBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public InputAction SecondaryTouch
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0xF5DBD8", Offset = "0xF5DBD8", VA = "0xF5DBD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public InputAction TriggerTouch
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0xF5DBF4", Offset = "0xF5DBF4", VA = "0xF5DBF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public bool enabled
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0xF5DC7C", Offset = "0xF5DC7C", VA = "0xF5DC7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xF5DA48", Offset = "0xF5DA48", VA = "0xF5DA48")]
		public RightHandActions(HVRInputActions wrapper)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xF5DC10", Offset = "0xF5DC10", VA = "0xF5DC10")]
		public InputActionMap Get()
		{
			return null;
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xF5DC2C", Offset = "0xF5DC2C", VA = "0xF5DC2C")]
		public void Enable()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xF5DC54", Offset = "0xF5DC54", VA = "0xF5DC54")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xF5DCA4", Offset = "0xF5DCA4", VA = "0xF5DCA4")]
		public static implicit operator InputActionMap(RightHandActions set)
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xF5DCBC", Offset = "0xF5DCBC", VA = "0xF5DCBC")]
		public void SetCallbacks(IRightHandActions instance)
		{
		}
	}

	[Token(Token = "0x200000A")]
	public struct HMDActions
	{
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private HVRInputActions m_Wrapper;

		[Token(Token = "0x1700002E")]
		public InputAction hmdPosition
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0xF593CC", Offset = "0xF593CC", VA = "0xF593CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public InputAction hmdRotation
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0xF593E8", Offset = "0xF593E8", VA = "0xF593E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public bool enabled
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0xF59470", Offset = "0xF59470", VA = "0xF59470")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xF593C4", Offset = "0xF593C4", VA = "0xF593C4")]
		public HMDActions(HVRInputActions wrapper)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xF59404", Offset = "0xF59404", VA = "0xF59404")]
		public InputActionMap Get()
		{
			return null;
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xF59420", Offset = "0xF59420", VA = "0xF59420")]
		public void Enable()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xF59448", Offset = "0xF59448", VA = "0xF59448")]
		public void Disable()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xF59498", Offset = "0xF59498", VA = "0xF59498")]
		public static implicit operator InputActionMap(HMDActions set)
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xF594B0", Offset = "0xF594B0", VA = "0xF594B0")]
		public void SetCallbacks(IHMDActions instance)
		{
		}
	}

	[Token(Token = "0x200000B")]
	public struct UIActions
	{
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private HVRInputActions m_Wrapper;

		[Token(Token = "0x17000031")]
		public InputAction Click
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0xF617F0", Offset = "0xF617F0", VA = "0xF617F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public InputAction pointerPosition
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0xF6180C", Offset = "0xF6180C", VA = "0xF6180C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public InputAction pointerRotation
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0xF61828", Offset = "0xF61828", VA = "0xF61828")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public bool enabled
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0xF618B0", Offset = "0xF618B0", VA = "0xF618B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xF617E8", Offset = "0xF617E8", VA = "0xF617E8")]
		public UIActions(HVRInputActions wrapper)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xF61844", Offset = "0xF61844", VA = "0xF61844")]
		public InputActionMap Get()
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xF61860", Offset = "0xF61860", VA = "0xF61860")]
		public void Enable()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xF61888", Offset = "0xF61888", VA = "0xF61888")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xF618D8", Offset = "0xF618D8", VA = "0xF618D8")]
		public static implicit operator InputActionMap(UIActions set)
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xF618F0", Offset = "0xF618F0", VA = "0xF618F0")]
		public void SetCallbacks(IUIActions instance)
		{
		}
	}

	[Token(Token = "0x200000C")]
	public interface ILeftHandActions
	{
		[Token(Token = "0x600006B")]
		void OnTriggerPress(InputAction.CallbackContext context);

		[Token(Token = "0x600006C")]
		void OnTrigger(InputAction.CallbackContext context);

		[Token(Token = "0x600006D")]
		void OnPrimaryButton(InputAction.CallbackContext context);

		[Token(Token = "0x600006E")]
		void OnPrimaryTouch(InputAction.CallbackContext context);

		[Token(Token = "0x600006F")]
		void OnMenu(InputAction.CallbackContext context);

		[Token(Token = "0x6000070")]
		void OnPrimary2DAxis(InputAction.CallbackContext context);

		[Token(Token = "0x6000071")]
		void OnPrimary2DAxisClick(InputAction.CallbackContext context);

		[Token(Token = "0x6000072")]
		void OnPrimary2DAxisTouch(InputAction.CallbackContext context);

		[Token(Token = "0x6000073")]
		void OnSecondary2DAxis(InputAction.CallbackContext context);

		[Token(Token = "0x6000074")]
		void OnSecondary2DAxisClick(InputAction.CallbackContext context);

		[Token(Token = "0x6000075")]
		void OnSecondary2DAxisTouch(InputAction.CallbackContext context);

		[Token(Token = "0x6000076")]
		void OnGrip(InputAction.CallbackContext context);

		[Token(Token = "0x6000077")]
		void OnGripPress(InputAction.CallbackContext context);

		[Token(Token = "0x6000078")]
		void OnSecondaryButton(InputAction.CallbackContext context);

		[Token(Token = "0x6000079")]
		void OnSecondaryTouch(InputAction.CallbackContext context);

		[Token(Token = "0x600007A")]
		void OnTriggerTouch(InputAction.CallbackContext context);
	}

	[Token(Token = "0x200000D")]
	public interface IRightHandActions
	{
		[Token(Token = "0x600007B")]
		void OnTriggerPress(InputAction.CallbackContext context);

		[Token(Token = "0x600007C")]
		void OnTrigger(InputAction.CallbackContext context);

		[Token(Token = "0x600007D")]
		void OnPrimaryButton(InputAction.CallbackContext context);

		[Token(Token = "0x600007E")]
		void OnPrimaryTouch(InputAction.CallbackContext context);

		[Token(Token = "0x600007F")]
		void OnMenu(InputAction.CallbackContext context);

		[Token(Token = "0x6000080")]
		void OnPrimary2DAxis(InputAction.CallbackContext context);

		[Token(Token = "0x6000081")]
		void OnPrimary2DAxisClick(InputAction.CallbackContext context);

		[Token(Token = "0x6000082")]
		void OnPrimary2DAxisTouch(InputAction.CallbackContext context);

		[Token(Token = "0x6000083")]
		void OnSecondary2DAxis(InputAction.CallbackContext context);

		[Token(Token = "0x6000084")]
		void OnSecondary2DAxisClick(InputAction.CallbackContext context);

		[Token(Token = "0x6000085")]
		void OnSecondary2DAxisTouch(InputAction.CallbackContext context);

		[Token(Token = "0x6000086")]
		void OnGrip(InputAction.CallbackContext context);

		[Token(Token = "0x6000087")]
		void OnGripPress(InputAction.CallbackContext context);

		[Token(Token = "0x6000088")]
		void OnSecondaryButton(InputAction.CallbackContext context);

		[Token(Token = "0x6000089")]
		void OnSecondaryTouch(InputAction.CallbackContext context);

		[Token(Token = "0x600008A")]
		void OnTriggerTouch(InputAction.CallbackContext context);
	}

	[Token(Token = "0x200000E")]
	public interface IHMDActions
	{
		[Token(Token = "0x600008B")]
		void OnHmdPosition(InputAction.CallbackContext context);

		[Token(Token = "0x600008C")]
		void OnHmdRotation(InputAction.CallbackContext context);
	}

	[Token(Token = "0x200000F")]
	public interface IUIActions
	{
		[Token(Token = "0x600008D")]
		void OnClick(InputAction.CallbackContext context);

		[Token(Token = "0x600008E")]
		void OnPointerPosition(InputAction.CallbackContext context);

		[Token(Token = "0x600008F")]
		void OnPointerRotation(InputAction.CallbackContext context);
	}

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AEB28", Offset = "0x9AEB28")]
	private readonly InputActionAsset <asset>k__BackingField;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly InputActionMap m_LeftHand;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ILeftHandActions m_LeftHandActionsCallbackInterface;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly InputAction m_LeftHand_TriggerPress;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly InputAction m_LeftHand_Trigger;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly InputAction m_LeftHand_PrimaryButton;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly InputAction m_LeftHand_PrimaryTouch;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly InputAction m_LeftHand_Menu;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly InputAction m_LeftHand_Primary2DAxis;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly InputAction m_LeftHand_Primary2DAxisClick;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly InputAction m_LeftHand_Primary2DAxisTouch;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly InputAction m_LeftHand_Secondary2DAxis;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly InputAction m_LeftHand_Secondary2DAxisClick;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly InputAction m_LeftHand_Secondary2DAxisTouch;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly InputAction m_LeftHand_Grip;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly InputAction m_LeftHand_GripPress;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly InputAction m_LeftHand_SecondaryButton;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly InputAction m_LeftHand_SecondaryTouch;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly InputAction m_LeftHand_TriggerTouch;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private readonly InputActionMap m_RightHand;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private IRightHandActions m_RightHandActionsCallbackInterface;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private readonly InputAction m_RightHand_TriggerPress;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private readonly InputAction m_RightHand_Trigger;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private readonly InputAction m_RightHand_PrimaryButton;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly InputAction m_RightHand_PrimaryTouch;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly InputAction m_RightHand_Menu;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly InputAction m_RightHand_Primary2DAxis;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly InputAction m_RightHand_Primary2DAxisClick;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly InputAction m_RightHand_Primary2DAxisTouch;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly InputAction m_RightHand_Secondary2DAxis;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly InputAction m_RightHand_Secondary2DAxisClick;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly InputAction m_RightHand_Secondary2DAxisTouch;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly InputAction m_RightHand_Grip;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly InputAction m_RightHand_GripPress;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private readonly InputAction m_RightHand_SecondaryButton;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private readonly InputAction m_RightHand_SecondaryTouch;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private readonly InputAction m_RightHand_TriggerTouch;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private readonly InputActionMap m_HMD;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private IHMDActions m_HMDActionsCallbackInterface;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private readonly InputAction m_HMD_hmdPosition;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private readonly InputAction m_HMD_hmdRotation;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private readonly InputActionMap m_UI;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private IUIActions m_UIActionsCallbackInterface;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private readonly InputAction m_UI_Click;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private readonly InputAction m_UI_pointerPosition;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private readonly InputAction m_UI_pointerRotation;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private int m_XRUsageSchemeIndex;

	[Token(Token = "0x17000003")]
	public InputActionAsset asset
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0xDE71FC", Offset = "0xDE71FC", VA = "0xDE71FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B0000", Offset = "0x9B0000")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	public InputBinding? bindingMask
	{
		[Token(Token = "0x600001B")]
		[Address(RVA = "0xDE7A1C", Offset = "0xDE7A1C", VA = "0xDE7A1C", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600001C")]
		[Address(RVA = "0xDE7A48", Offset = "0xDE7A48", VA = "0xDE7A48", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public ReadOnlyArray<InputDevice>? devices
	{
		[Token(Token = "0x600001D")]
		[Address(RVA = "0xDE7AA0", Offset = "0xDE7AA0", VA = "0xDE7AA0", Slot = "6")]
		get
		{
			return null;
		}
		[Token(Token = "0x600001E")]
		[Address(RVA = "0xDE7AEC", Offset = "0xDE7AEC", VA = "0xDE7AEC", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public ReadOnlyArray<InputControlScheme> controlSchemes
	{
		[Token(Token = "0x600001F")]
		[Address(RVA = "0xDE7B3C", Offset = "0xDE7B3C", VA = "0xDE7B3C", Slot = "8")]
		get
		{
			return default(ReadOnlyArray<InputControlScheme>);
		}
	}

	[Token(Token = "0x17000007")]
	public LeftHandActions LeftHand
	{
		[Token(Token = "0x6000025")]
		[Address(RVA = "0xDE7BE4", Offset = "0xDE7BE4", VA = "0xDE7BE4")]
		get
		{
			return default(LeftHandActions);
		}
	}

	[Token(Token = "0x17000008")]
	public RightHandActions RightHand
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0xDE7BE8", Offset = "0xDE7BE8", VA = "0xDE7BE8")]
		get
		{
			return default(RightHandActions);
		}
	}

	[Token(Token = "0x17000009")]
	public HMDActions HMD
	{
		[Token(Token = "0x6000027")]
		[Address(RVA = "0xDE7BEC", Offset = "0xDE7BEC", VA = "0xDE7BEC")]
		get
		{
			return default(HMDActions);
		}
	}

	[Token(Token = "0x1700000A")]
	public UIActions UI
	{
		[Token(Token = "0x6000028")]
		[Address(RVA = "0xDE7BF0", Offset = "0xDE7BF0", VA = "0xDE7BF0")]
		get
		{
			return default(UIActions);
		}
	}

	[Token(Token = "0x1700000B")]
	public InputControlScheme XRUsageScheme
	{
		[Token(Token = "0x6000029")]
		[Address(RVA = "0xDE7BF4", Offset = "0xDE7BF4", VA = "0xDE7BF4")]
		get
		{
			return default(InputControlScheme);
		}
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xDE7204", Offset = "0xDE7204", VA = "0xDE7204")]
	public HVRInputActions()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xDE79B4", Offset = "0xDE79B4", VA = "0xDE79B4", Slot = "14")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xDE7B58", Offset = "0xDE7B58", VA = "0xDE7B58", Slot = "9")]
	public bool Contains(InputAction action)
	{
		return default(bool);
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xDE7B74", Offset = "0xDE7B74", VA = "0xDE7B74", Slot = "12")]
	public IEnumerator<InputAction> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xDE7B90", Offset = "0xDE7B90", VA = "0xDE7B90", Slot = "13")]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xDE7BAC", Offset = "0xDE7BAC", VA = "0xDE7BAC", Slot = "10")]
	public void Enable()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xDE7BC8", Offset = "0xDE7BC8", VA = "0xDE7BC8", Slot = "11")]
	public void Disable()
	{
	}
}
[Token(Token = "0x2000010")]
public class KetchupOrMustard : MonoBehaviour
{
	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isKetchup;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool isMustard;

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xDEA390", Offset = "0xDEA390", VA = "0xDEA390")]
	public KetchupOrMustard()
	{
	}
}
[Token(Token = "0x2000011")]
public class RadioKnobJokeBehaviour : MonoBehaviour
{
	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject springObject;

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x273BDBC", Offset = "0x273BDBC", VA = "0x273BDBC")]
	private void OnJointBreak(float breakForce)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x273BE54", Offset = "0x273BE54", VA = "0x273BE54")]
	public RadioKnobJokeBehaviour()
	{
	}
}
[Token(Token = "0x2000012")]
public class HellRubish : MonoBehaviour
{
	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool onHisWay;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UnityEvent OnRubishHitFloor;

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xDE8564", Offset = "0xDE8564", VA = "0xDE8564")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xDE8608", Offset = "0xDE8608", VA = "0xDE8608")]
	public HellRubish()
	{
	}
}
[Token(Token = "0x2000013")]
public class ParachuteBabyrooBehaviour : babyrooBehaviour
{
	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private GameObject parachute;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public GameObject parachuteGoneParticles;

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x2734C28", Offset = "0x2734C28", VA = "0x2734C28", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x2734CE4", Offset = "0x2734CE4", VA = "0x2734CE4", Slot = "8")]
	protected override void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x2734FAC", Offset = "0x2734FAC", VA = "0x2734FAC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x2735014", Offset = "0x2735014", VA = "0x2735014")]
	public ParachuteBabyrooBehaviour()
	{
	}
}
[Token(Token = "0x2000014")]
public class ParachuteBehaviour : MonoBehaviour
{
	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float yVelocity;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float xRadius;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float zRadius;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float rotationTime;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float initialX;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float initialY;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float initialZ;

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x273501C", Offset = "0x273501C", VA = "0x273501C")]
	private void Start()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x273508C", Offset = "0x273508C", VA = "0x273508C")]
	private void Update()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x2735198", Offset = "0x2735198", VA = "0x2735198")]
	public ParachuteBehaviour()
	{
	}
}
[Token(Token = "0x2000015")]
public class babyrooBehaviour : Enemy
{
	[Serializable]
	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADB60", Offset = "0x9ADB60")]
	private sealed class <>c
	{
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<HVRSocket> <>9__15_0;

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2291C8C", Offset = "0x2291C8C", VA = "0x2291C8C")]
		public <>c()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2291C94", Offset = "0x2291C94", VA = "0x2291C94")]
		internal bool <OnCollisionEnter>b__15_0(HVRSocket s)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADB70", Offset = "0x9ADB70")]
	private sealed class <UntoutchableFor>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public babyrooBehaviour <>4__this;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float _secondsToWait;

		[Token(Token = "0x17000035")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x2291EB4", Offset = "0x2291EB4", VA = "0x2291EB4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x2291EFC", Offset = "0x2291EFC", VA = "0x2291EFC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2291D08", Offset = "0x2291D08", VA = "0x2291D08")]
		[DebuggerHidden]
		public <UntoutchableFor>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2291D34", Offset = "0x2291D34", VA = "0x2291D34", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2291D38", Offset = "0x2291D38", VA = "0x2291D38", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2291EBC", Offset = "0x2291EBC", VA = "0x2291EBC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject grilledParticles;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public Beer beerHeld;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected Rigidbody rb;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected Animator animator;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected HVRGrabbable grabbable;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private HVRSocket handSocket;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int damageOnThrow;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AEB48", Offset = "0x9AEB48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AEB48", Offset = "0x9AEB48")]
	public float velocityToExplode;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected bool held;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
	protected bool thrown;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AEB9C", Offset = "0x9AEB9C")]
	public float scaleWhenGrabbed;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject grabbedCanBeerUI;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject grabbedBottleBeerUI;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool isFastRoo;

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xED36F8", Offset = "0xED36F8", VA = "0xED36F8", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xED3A78", Offset = "0xED3A78", VA = "0xED3A78", Slot = "8")]
	protected override void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xED434C", Offset = "0xED434C", VA = "0xED434C")]
	public GameObject FindClosestBeer()
	{
		return null;
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xED41F4", Offset = "0xED41F4", VA = "0xED41F4")]
	private void GrabBeer(Beer _beer)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xED4644", Offset = "0xED4644", VA = "0xED4644", Slot = "10")]
	protected virtual void hopWithoutBeer()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xED47B0", Offset = "0xED47B0", VA = "0xED47B0", Slot = "11")]
	protected virtual void hopWithBeer()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xED4900", Offset = "0xED4900", VA = "0xED4900")]
	private void lookOutForBeers()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xED49B8", Offset = "0xED49B8", VA = "0xED49B8", Slot = "6")]
	public override void KillMe()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xED4B94", Offset = "0xED4B94", VA = "0xED4B94", Slot = "12")]
	public virtual void onHeld([Optional] HVRGrabberBase _grabberBase, [Optional] HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xED4CA8", Offset = "0xED4CA8", VA = "0xED4CA8")]
	public void onThrow([Optional] HVRGrabberBase _grabberBase, [Optional] HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xED4CB4", Offset = "0xED4CB4", VA = "0xED4CB4", Slot = "13")]
	protected virtual void RecoverAfterThrow()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xED4A3C", Offset = "0xED4A3C", VA = "0xED4A3C")]
	public void DropBeer(bool flyingBeer)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xED48F8", Offset = "0xED48F8", VA = "0xED48F8")]
	public void DropBeer()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xED4024", Offset = "0xED4024", VA = "0xED4024")]
	private void GrillBabyroo()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xED4DBC", Offset = "0xED4DBC", VA = "0xED4DBC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B0010", Offset = "0x9B0010")]
	private IEnumerator UntoutchableFor(float _secondsToWait)
	{
		return null;
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xED4E38", Offset = "0xED4E38", VA = "0xED4E38")]
	public void OnHatOnHead()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xED4ED8", Offset = "0xED4ED8", VA = "0xED4ED8")]
	public babyrooBehaviour()
	{
	}
}
[Token(Token = "0x2000018")]
public class DingoBehaviour : Enemy
{
	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADB80", Offset = "0x9ADB80")]
	private sealed class <UntoutchableFor>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DingoBehaviour <>4__this;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float _secondsToWait;

		[Token(Token = "0x17000037")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0xEDD004", Offset = "0xEDD004", VA = "0xEDD004", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0xEDD04C", Offset = "0xEDD04C", VA = "0xEDD04C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xEDCE58", Offset = "0xEDCE58", VA = "0xEDCE58")]
		[DebuggerHidden]
		public <UntoutchableFor>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xEDCE84", Offset = "0xEDCE84", VA = "0xEDCE84", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xEDCE88", Offset = "0xEDCE88", VA = "0xEDCE88", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xEDD00C", Offset = "0xEDD00C", VA = "0xEDD00C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public BeerBox beerBoxHeld;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected Rigidbody rb;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected Animator animator;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AEBC4", Offset = "0x9AEBC4")]
	public Transform mouthTransform;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject grabbedBeerBoxUI;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool canGrabBeerBox;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public Vector3 startingPosition;

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xD36534", Offset = "0xD36534", VA = "0xD36534", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xD369C4", Offset = "0xD369C4", VA = "0xD369C4", Slot = "8")]
	protected override void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xD366CC", Offset = "0xD366CC", VA = "0xD366CC")]
	public GameObject FindClosestBeerBox()
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xD36A70", Offset = "0xD36A70", VA = "0xD36A70")]
	private void GrabBeerBox(BeerBox _beerBox)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xD36B70", Offset = "0xD36B70", VA = "0xD36B70", Slot = "10")]
	protected virtual void HopWithoutBeerBox()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xD36CD8", Offset = "0xD36CD8", VA = "0xD36CD8", Slot = "11")]
	protected virtual void HopWithBeerBox()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xD36D20", Offset = "0xD36D20", VA = "0xD36D20")]
	private void lookOutForBeerBoxes()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xD36DD8", Offset = "0xD36DD8", VA = "0xD36DD8", Slot = "6")]
	public override void KillMe()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xD36E58", Offset = "0xD36E58", VA = "0xD36E58")]
	public void DropBeerBox()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xD36F50", Offset = "0xD36F50", VA = "0xD36F50", Slot = "12")]
	public virtual void BeerBoxSteal()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xD370CC", Offset = "0xD370CC", VA = "0xD370CC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B00C0", Offset = "0x9B00C0")]
	private IEnumerator UntoutchableFor(float _secondsToWait)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xD37148", Offset = "0xD37148", VA = "0xD37148")]
	public DingoBehaviour()
	{
	}
}
[Token(Token = "0x200001A")]
public class Egg : MonoBehaviour
{
	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject spawnObject;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioHandler audioHandler;

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xDDD420", Offset = "0xDDD420", VA = "0xDDD420")]
	private void Start()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xDDD474", Offset = "0xDDD474", VA = "0xDDD474")]
	private void Spawn()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xDDD548", Offset = "0xDDD548", VA = "0xDDD548")]
	public void CrackSound()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xDDD5A0", Offset = "0xDDD5A0", VA = "0xDDD5A0")]
	public Egg()
	{
	}
}
[Token(Token = "0x200001B")]
public class Emu : Enemy
{
	[Token(Token = "0x200001C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADB90", Offset = "0x9ADB90")]
	private sealed class <EmuInitialCoroutine>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Emu <>4__this;

		[Token(Token = "0x17000039")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0xEDE468", Offset = "0xEDE468", VA = "0xEDE468", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0xEDE4B0", Offset = "0xEDE4B0", VA = "0xEDE4B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xEDE380", Offset = "0xEDE380", VA = "0xEDE380")]
		[DebuggerHidden]
		public <EmuInitialCoroutine>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xEDE3AC", Offset = "0xEDE3AC", VA = "0xEDE3AC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xEDE3B0", Offset = "0xEDE3B0", VA = "0xEDE3B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xEDE470", Offset = "0xEDE470", VA = "0xEDE470", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADBA0", Offset = "0x9ADBA0")]
	private sealed class <MoveToNextPointCoroutine>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Emu <>4__this;

		[Token(Token = "0x1700003B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0xEDEC40", Offset = "0xEDEC40", VA = "0xEDEC40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0xEDEC88", Offset = "0xEDEC88", VA = "0xEDEC88", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xEDE9C0", Offset = "0xEDE9C0", VA = "0xEDE9C0")]
		[DebuggerHidden]
		public <MoveToNextPointCoroutine>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xEDE9EC", Offset = "0xEDE9EC", VA = "0xEDE9EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xEDE9F0", Offset = "0xEDE9F0", VA = "0xEDE9F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xEDEC48", Offset = "0xEDEC48", VA = "0xEDEC48", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADBB0", Offset = "0x9ADBB0")]
	private sealed class <CleanMoveToNextPointCoroutine>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Emu <>4__this;

		[Token(Token = "0x1700003D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0xEDE330", Offset = "0xEDE330", VA = "0xEDE330", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0xEDE378", Offset = "0xEDE378", VA = "0xEDE378", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xEDE0C8", Offset = "0xEDE0C8", VA = "0xEDE0C8")]
		[DebuggerHidden]
		public <CleanMoveToNextPointCoroutine>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xEDE0F4", Offset = "0xEDE0F4", VA = "0xEDE0F4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xEDE0F8", Offset = "0xEDE0F8", VA = "0xEDE0F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xEDE338", Offset = "0xEDE338", VA = "0xEDE338", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADBC0", Offset = "0x9ADBC0")]
	private sealed class <SpawnMiniEmuCoroutine>d__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Emu <>4__this;

		[Token(Token = "0x1700003F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0xEDF844", Offset = "0xEDF844", VA = "0xEDF844", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0xEDF88C", Offset = "0xEDF88C", VA = "0xEDF88C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xEDF4D4", Offset = "0xEDF4D4", VA = "0xEDF4D4")]
		[DebuggerHidden]
		public <SpawnMiniEmuCoroutine>d__35(int <>1__state)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xEDF500", Offset = "0xEDF500", VA = "0xEDF500", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xEDF504", Offset = "0xEDF504", VA = "0xEDF504", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xEDF84C", Offset = "0xEDF84C", VA = "0xEDF84C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADBD0", Offset = "0x9ADBD0")]
	private sealed class <SpawnSpecialMiniEmuCoroutine>d__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Emu <>4__this;

		[Token(Token = "0x17000041")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0xEDFAEC", Offset = "0xEDFAEC", VA = "0xEDFAEC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0xEDFB34", Offset = "0xEDFB34", VA = "0xEDFB34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xEDF894", Offset = "0xEDF894", VA = "0xEDF894")]
		[DebuggerHidden]
		public <SpawnSpecialMiniEmuCoroutine>d__36(int <>1__state)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xEDF8C0", Offset = "0xEDF8C0", VA = "0xEDF8C0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xEDF8C4", Offset = "0xEDF8C4", VA = "0xEDF8C4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xEDFAF4", Offset = "0xEDFAF4", VA = "0xEDFAF4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADBE0", Offset = "0x9ADBE0")]
	private sealed class <SpawnMiniEmuAndRocketCoroutine>d__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Emu <>4__this;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int rocketNumber;

		[Token(Token = "0x17000043")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0xEDF484", Offset = "0xEDF484", VA = "0xEDF484", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0xEDF4CC", Offset = "0xEDF4CC", VA = "0xEDF4CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xEDF12C", Offset = "0xEDF12C", VA = "0xEDF12C")]
		[DebuggerHidden]
		public <SpawnMiniEmuAndRocketCoroutine>d__37(int <>1__state)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xEDF158", Offset = "0xEDF158", VA = "0xEDF158", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xEDF15C", Offset = "0xEDF15C", VA = "0xEDF15C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xEDF48C", Offset = "0xEDF48C", VA = "0xEDF48C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADBF0", Offset = "0x9ADBF0")]
	private sealed class <VulnerableCoroutine>d__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Emu <>4__this;

		[Token(Token = "0x17000045")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0xEDFFA8", Offset = "0xEDFFA8", VA = "0xEDFFA8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0xEDFFF0", Offset = "0xEDFFF0", VA = "0xEDFFF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xEDFB3C", Offset = "0xEDFB3C", VA = "0xEDFB3C")]
		[DebuggerHidden]
		public <VulnerableCoroutine>d__38(int <>1__state)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xEDFB68", Offset = "0xEDFB68", VA = "0xEDFB68", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xEDFB6C", Offset = "0xEDFB6C", VA = "0xEDFB6C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xEDFFB0", Offset = "0xEDFFB0", VA = "0xEDFFB0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADC00", Offset = "0x9ADC00")]
	private sealed class <GetHit>d__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Emu <>4__this;

		[Token(Token = "0x17000047")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0xEDE6DC", Offset = "0xEDE6DC", VA = "0xEDE6DC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0xEDE724", Offset = "0xEDE724", VA = "0xEDE724", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xEDE4B8", Offset = "0xEDE4B8", VA = "0xEDE4B8")]
		[DebuggerHidden]
		public <GetHit>d__40(int <>1__state)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xEDE4E4", Offset = "0xEDE4E4", VA = "0xEDE4E4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xEDE4E8", Offset = "0xEDE4E8", VA = "0xEDE4E8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xEDE6E4", Offset = "0xEDE6E4", VA = "0xEDE6E4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADC10", Offset = "0x9ADC10")]
	private sealed class <RocketCoroutine>d__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Emu <>4__this;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int rocketNumber;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int <i>5__2;

		[Token(Token = "0x17000049")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0xEDF0DC", Offset = "0xEDF0DC", VA = "0xEDF0DC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0xEDF124", Offset = "0xEDF124", VA = "0xEDF124", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xEDEC90", Offset = "0xEDEC90", VA = "0xEDEC90")]
		[DebuggerHidden]
		public <RocketCoroutine>d__41(int <>1__state)
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xEDECBC", Offset = "0xEDECBC", VA = "0xEDECBC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xEDECC0", Offset = "0xEDECC0", VA = "0xEDECC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xEDF0E4", Offset = "0xEDF0E4", VA = "0xEDF0E4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADC20", Offset = "0x9ADC20")]
	private sealed class <KillEmu>d__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Emu <>4__this;

		[Token(Token = "0x1700004B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0xEDE970", Offset = "0xEDE970", VA = "0xEDE970", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0xEDE9B8", Offset = "0xEDE9B8", VA = "0xEDE9B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xEDE72C", Offset = "0xEDE72C", VA = "0xEDE72C")]
		[DebuggerHidden]
		public <KillEmu>d__42(int <>1__state)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xEDE758", Offset = "0xEDE758", VA = "0xEDE758", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xEDE75C", Offset = "0xEDE75C", VA = "0xEDE75C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xEDE978", Offset = "0xEDE978", VA = "0xEDE978", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AEBFC", Offset = "0x9AEBFC")]
	public float chanceOfChangingDirection;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AEC14", Offset = "0x9AEC14")]
	public float chanceOfRandom;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AEC2C", Offset = "0x9AEC2C")]
	public float chanceOfRealEgg;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject pointsOfMovementParent;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<Transform> pointsOfMovement;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform pointToSpawnProjectile;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Transform pointToSpawnEmus;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject DirtParticles;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject miniEmuPrefab;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject specialMiniEmuPrefab;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject fakeMiniEmuPrefab;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject rocketPrefab;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public BossHealthBar healthBar;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public float[] rocketTimes;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public float[] rocketSharpnesses;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Transform playerTransform;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Animator animator;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Level15GPM gamePlayManager;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9AEC44", Offset = "0x9AEC44")]
	public bool reverseDirection;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public int currentMovementPoint;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public int nextMovementPoint;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public int moveNumbers;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public int trueEggsSpawned;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public int phaseNumber;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public bool isWaiting;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public int fakeEggsCounter;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public float tauntWaitTime;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private Vector3[] offsets;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public float offsetMultiplier;

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xDDD5A8", Offset = "0xDDD5A8", VA = "0xDDD5A8")]
	private new void Start()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xDDD8B8", Offset = "0xDDD8B8", VA = "0xDDD8B8")]
	private void DecideWhatToDo()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xDDD84C", Offset = "0xDDD84C", VA = "0xDDD84C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B0170", Offset = "0x9B0170")]
	private IEnumerator EmuInitialCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xDDDB64", Offset = "0xDDDB64", VA = "0xDDDB64")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B01D0", Offset = "0x9B01D0")]
	private IEnumerator MoveToNextPointCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xDDDDA0", Offset = "0xDDDDA0", VA = "0xDDDDA0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B0230", Offset = "0x9B0230")]
	private IEnumerator CleanMoveToNextPointCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xDDDE0C", Offset = "0xDDDE0C", VA = "0xDDDE0C")]
	private int GetNextMovementPoint()
	{
		return default(int);
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xDDDC3C", Offset = "0xDDDC3C", VA = "0xDDDC3C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B0290", Offset = "0x9B0290")]
	public IEnumerator SpawnMiniEmuCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xDDDED4", Offset = "0xDDDED4", VA = "0xDDDED4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B02F0", Offset = "0x9B02F0")]
	public IEnumerator SpawnSpecialMiniEmuCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xDDDD24", Offset = "0xDDDD24", VA = "0xDDDD24")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B0350", Offset = "0x9B0350")]
	public IEnumerator SpawnMiniEmuAndRocketCoroutine(int rocketNumber)
	{
		return null;
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xDDDBD0", Offset = "0xDDDBD0", VA = "0xDDDBD0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B03B0", Offset = "0x9B03B0")]
	private IEnumerator VulnerableCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xDDDF40", Offset = "0xDDDF40", VA = "0xDDDF40", Slot = "5")]
	public override void GiveDamage(int damageToGive)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xDDE0CC", Offset = "0xDDE0CC", VA = "0xDDE0CC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B0410", Offset = "0x9B0410")]
	private IEnumerator GetHit()
	{
		return null;
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xDDDCA8", Offset = "0xDDDCA8", VA = "0xDDDCA8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B0470", Offset = "0x9B0470")]
	private IEnumerator RocketCoroutine(int rocketNumber)
	{
		return null;
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xDDE138", Offset = "0xDDE138", VA = "0xDDE138")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B04D0", Offset = "0x9B04D0")]
	private IEnumerator KillEmu()
	{
		return null;
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xDDE1A4", Offset = "0xDDE1A4", VA = "0xDDE1A4")]
	public void DirtPopParticles()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xDDE1C4", Offset = "0xDDE1C4", VA = "0xDDE1C4")]
	public Emu()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xDDE378", Offset = "0xDDE378", VA = "0xDDE378")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B0530", Offset = "0x9B0530")]
	private bool <MoveToNextPointCoroutine>b__32_0()
	{
		return default(bool);
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xDDE3A4", Offset = "0xDDE3A4", VA = "0xDDE3A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B0540", Offset = "0x9B0540")]
	private bool <CleanMoveToNextPointCoroutine>b__33_0()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000026")]
public class MiniEmu : Enemy
{
	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADC30", Offset = "0x9ADC30")]
	private sealed class <FollowAndExplode>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MiniEmu <>4__this;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds <_waitForSeconds>5__2;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <success>5__3;

		[Token(Token = "0x1700004D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0xF66E18", Offset = "0xF66E18", VA = "0xF66E18", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0xF66E60", Offset = "0xF66E60", VA = "0xF66E60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xF66B30", Offset = "0xF66B30", VA = "0xF66B30")]
		[DebuggerHidden]
		public <FollowAndExplode>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xF66B5C", Offset = "0xF66B5C", VA = "0xF66B5C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xF66B60", Offset = "0xF66B60", VA = "0xF66B60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xF66E20", Offset = "0xF66E20", VA = "0xF66E20", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADC40", Offset = "0x9ADC40")]
	private sealed class <delayedThrown>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float _time;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MiniEmu <>4__this;

		[Token(Token = "0x1700004F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0xF66F50", Offset = "0xF66F50", VA = "0xF66F50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0xF66F98", Offset = "0xF66F98", VA = "0xF66F98", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xF66E68", Offset = "0xF66E68", VA = "0xF66E68")]
		[DebuggerHidden]
		public <delayedThrown>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xF66E94", Offset = "0xF66E94", VA = "0xF66E94", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xF66E98", Offset = "0xF66E98", VA = "0xF66E98", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xF66F58", Offset = "0xF66F58", VA = "0xF66F58", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADC50", Offset = "0x9ADC50")]
	private sealed class <Autoaim>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MiniEmu <>4__this;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Emu <bigEmu>5__2;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForFixedUpdate <waitForFixedUpdate>5__3;

		[Token(Token = "0x17000051")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0xF66AE0", Offset = "0xF66AE0", VA = "0xF66AE0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0xF66B28", Offset = "0xF66B28", VA = "0xF66B28", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xF66828", Offset = "0xF66828", VA = "0xF66828")]
		[DebuggerHidden]
		public <Autoaim>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xF66854", Offset = "0xF66854", VA = "0xF66854", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xF66858", Offset = "0xF66858", VA = "0xF66858", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xF66AE8", Offset = "0xF66AE8", VA = "0xF66AE8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Transform playerTransform;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Animator animator;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Rigidbody rb;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Dynamite dynamite;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float distanceToExplode;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public bool isSpecial;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
	private bool isRunningAway;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x76")]
	private bool thrown;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x77")]
	private bool exploded;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float autoAimMultiplier;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject cricketBatIconCanvas;

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x272FADC", Offset = "0x272FADC", VA = "0x272FADC", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x272FD54", Offset = "0x272FD54", VA = "0x272FD54")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B0870", Offset = "0x9B0870")]
	private IEnumerator FollowAndExplode()
	{
		return null;
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x272FDC0", Offset = "0x272FDC0", VA = "0x272FDC0")]
	public void Explode()
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x272FE58", Offset = "0x272FE58", VA = "0x272FE58")]
	private void Explode(Dynamite _)
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x273003C", Offset = "0x273003C", VA = "0x273003C")]
	public void RunAway()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x27301E0", Offset = "0x27301E0", VA = "0x27301E0")]
	public void BatHit()
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x2730424", Offset = "0x2730424", VA = "0x2730424")]
	public void FailedHit()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x273033C", Offset = "0x273033C", VA = "0x273033C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B08D0", Offset = "0x9B08D0")]
	private IEnumerator delayedThrown(float _time)
	{
		return null;
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x27303B8", Offset = "0x27303B8", VA = "0x27303B8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B0930", Offset = "0x9B0930")]
	private IEnumerator Autoaim()
	{
		return null;
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x273047C", Offset = "0x273047C", VA = "0x273047C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x27305A8", Offset = "0x27305A8", VA = "0x27305A8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x2730628", Offset = "0x2730628", VA = "0x2730628")]
	private void OnFinish()
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x27306B4", Offset = "0x27306B4", VA = "0x27306B4")]
	private new void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x2730858", Offset = "0x2730858", VA = "0x2730858", Slot = "5")]
	public override void GiveDamage(int damageToGive)
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x27308E4", Offset = "0x27308E4", VA = "0x27308E4")]
	public MiniEmu()
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x2730900", Offset = "0x2730900", VA = "0x2730900")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B0990", Offset = "0x9B0990")]
	private bool <FollowAndExplode>b__12_0()
	{
		return default(bool);
	}
}
[Token(Token = "0x200002A")]
public class Rocket : HomingProjectile
{
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADC60", Offset = "0x9ADC60")]
	private sealed class <ControlProjectileSharpness>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float[] times;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rocket <>4__this;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float[] sharpnesses;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <timeStamp>5__2;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <timeBetweenPoints>5__3;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int <i>5__4;

		[Token(Token = "0x17000053")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x228E89C", Offset = "0x228E89C", VA = "0x228E89C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x228E8E4", Offset = "0x228E8E4", VA = "0x228E8E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x228E6D0", Offset = "0x228E6D0", VA = "0x228E6D0")]
		[DebuggerHidden]
		public <ControlProjectileSharpness>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x228E6FC", Offset = "0x228E6FC", VA = "0x228E6FC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x228E700", Offset = "0x228E700", VA = "0x228E700", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x228E8A4", Offset = "0x228E8A4", VA = "0x228E8A4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADC70", Offset = "0x9ADC70")]
	private sealed class <SetTarget>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float timeToWait;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rocket <>4__this;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 _offset;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float _randomRange;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <distance>5__2;

		[Token(Token = "0x17000055")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x228F0F0", Offset = "0x228F0F0", VA = "0x228F0F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x228F138", Offset = "0x228F138", VA = "0x228F138", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x228E8EC", Offset = "0x228E8EC", VA = "0x228E8EC")]
		[DebuggerHidden]
		public <SetTarget>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x228E918", Offset = "0x228E918", VA = "0x228E918", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x228E91C", Offset = "0x228E91C", VA = "0x228E91C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x228F0F8", Offset = "0x228F0F8", VA = "0x228F0F8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Transform childTransform;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Transform playerTransform;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public float explosionRadius;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public CanvasGroup targetMarker;

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x273F78C", Offset = "0x273F78C", VA = "0x273F78C", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x273F86C", Offset = "0x273F86C", VA = "0x273F86C", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x273F90C", Offset = "0x273F90C", VA = "0x273F90C", Slot = "7")]
	protected override void DestroyProjectile(GameObject _particles, string _sound = "DestroySound")
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x273FA28", Offset = "0x273FA28", VA = "0x273FA28")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B0A90", Offset = "0x9B0A90")]
	public IEnumerator ControlProjectileSharpness(float[] times, float[] sharpnesses)
	{
		return null;
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x273FAA8", Offset = "0x273FAA8", VA = "0x273FAA8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x273FB28", Offset = "0x273FB28", VA = "0x273FB28")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B0AF0", Offset = "0x9B0AF0")]
	public IEnumerator SetTarget(float timeToWait, float _randomRange, Vector3 _offset)
	{
		return null;
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x273FBCC", Offset = "0x273FBCC", VA = "0x273FBCC")]
	public Rocket()
	{
	}
}
[Token(Token = "0x200002D")]
public class kangarooBehaviour : Enemy
{
	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADC80", Offset = "0x9ADC80")]
	private sealed class <HopCoroutine>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public kangarooBehaviour <>4__this;

		[Token(Token = "0x17000057")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x229210C", Offset = "0x229210C", VA = "0x229210C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x2292154", Offset = "0x2292154", VA = "0x2292154", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x2291F04", Offset = "0x2291F04", VA = "0x2291F04")]
		[DebuggerHidden]
		public <HopCoroutine>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x2291F30", Offset = "0x2291F30", VA = "0x2291F30", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x2291F34", Offset = "0x2291F34", VA = "0x2291F34", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x2292114", Offset = "0x2292114", VA = "0x2292114", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADC90", Offset = "0x9ADC90")]
	private sealed class <MiniHopCoroutine>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public kangarooBehaviour <>4__this;

		[Token(Token = "0x17000059")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x22923B8", Offset = "0x22923B8", VA = "0x22923B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x2292400", Offset = "0x2292400", VA = "0x2292400", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x229215C", Offset = "0x229215C", VA = "0x229215C")]
		[DebuggerHidden]
		public <MiniHopCoroutine>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x2292188", Offset = "0x2292188", VA = "0x2292188", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x229218C", Offset = "0x229218C", VA = "0x229218C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x22923C0", Offset = "0x22923C0", VA = "0x22923C0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float hopVelocity;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Rigidbody rb;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Animator animator;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool isHopping;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int hopSinceThrow;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int hopsLimitBetweenThrows;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AEC7C", Offset = "0x9AEC7C")]
	public int minAngleRotation;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AEC98", Offset = "0x9AEC98")]
	public int maxAngleRotation;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Transform babyrooEmission;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Transform babyrooDirection;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject babyroo;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float throwForce;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public int babyrooLimit;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Transform playerCameraTransform;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9AECB4", Offset = "0x9AECB4")]
	public float distanceToFight;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public float perferedFighingDistance;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private bool fightMode;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GameObject[] firstInjury;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject[] secondInjury;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Collider leftFist;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Collider rightFist;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public GameObject[] SlamParticles;

	[Token(Token = "0x600014F")]
	[Address(RVA = "0xED529C", Offset = "0xED529C", VA = "0xED529C", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0xED53D4", Offset = "0xED53D4", VA = "0xED53D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0xED5500", Offset = "0xED5500", VA = "0xED5500", Slot = "5")]
	public override void GiveDamage(int damageToGive)
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0xED5654", Offset = "0xED5654", VA = "0xED5654")]
	public void HopStart()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0xED58D8", Offset = "0xED58D8", VA = "0xED58D8")]
	public void HopEnd()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0xED5A04", Offset = "0xED5A04", VA = "0xED5A04")]
	public void MiniHopStart()
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0xED5AA4", Offset = "0xED5AA4", VA = "0xED5AA4")]
	public void MiniHopEnd()
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0xED5B10", Offset = "0xED5B10", VA = "0xED5B10")]
	public void ThrowBabyroo()
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0xED5D48", Offset = "0xED5D48", VA = "0xED5D48")]
	public void randomRotation()
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0xED53E4", Offset = "0xED53E4", VA = "0xED53E4")]
	public void LookAtPlayer()
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0xED586C", Offset = "0xED586C", VA = "0xED586C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B0BF0", Offset = "0x9B0BF0")]
	private IEnumerator HopCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0xED5A38", Offset = "0xED5A38", VA = "0xED5A38")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B0C50", Offset = "0x9B0C50")]
	private IEnumerator MiniHopCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0xED56A0", Offset = "0xED56A0", VA = "0xED56A0")]
	private bool CloseToPlayer()
	{
		return default(bool);
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0xED5DB8", Offset = "0xED5DB8", VA = "0xED5DB8")]
	private bool OneOutOfX(int x)
	{
		return default(bool);
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0xED5DE0", Offset = "0xED5DE0", VA = "0xED5DE0")]
	public void EnableRightFist()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0xED5E00", Offset = "0xED5E00", VA = "0xED5E00")]
	public void DisableRightFist()
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0xED5E20", Offset = "0xED5E20", VA = "0xED5E20")]
	public void EnableLeftFist()
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0xED5E40", Offset = "0xED5E40", VA = "0xED5E40")]
	public void DisableLeftFist()
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0xED5E60", Offset = "0xED5E60", VA = "0xED5E60", Slot = "9")]
	protected override void SlapEnemy(Collision collision)
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0xED60A4", Offset = "0xED60A4", VA = "0xED60A4")]
	public kangarooBehaviour()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0xED60CC", Offset = "0xED60CC", VA = "0xED60CC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B0CB0", Offset = "0x9B0CB0")]
	private bool <HopCoroutine>b__32_0()
	{
		return default(bool);
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0xED60D4", Offset = "0xED60D4", VA = "0xED60D4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B0CC0", Offset = "0x9B0CC0")]
	private bool <MiniHopCoroutine>b__33_0()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000030")]
public class KoalaBehaviour : Enemy
{
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADCA0", Offset = "0x9ADCA0")]
	private sealed class <ThrowProjectileCoroutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public KoalaBehaviour <>4__this;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds <_waitForSeconds>5__2;

		[Token(Token = "0x1700005B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0xF63068", Offset = "0xF63068", VA = "0xF63068", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0xF630B0", Offset = "0xF630B0", VA = "0xF630B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xF62F24", Offset = "0xF62F24", VA = "0xF62F24")]
		[DebuggerHidden]
		public <ThrowProjectileCoroutine>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xF62F50", Offset = "0xF62F50", VA = "0xF62F50", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xF62F54", Offset = "0xF62F54", VA = "0xF62F54", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xF63070", Offset = "0xF63070", VA = "0xF63070", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform pointToSpawnProjectile;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject projectile;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AECEC", Offset = "0x9AECEC")]
	public float timeBetweenProjectiles;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float timeToFirstProjectile;

	[Token(Token = "0x6000171")]
	[Address(RVA = "0xDEA398", Offset = "0xDEA398", VA = "0xDEA398", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0xDEA3D8", Offset = "0xDEA3D8", VA = "0xDEA3D8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B0D70", Offset = "0x9B0D70")]
	private IEnumerator ThrowProjectileCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0xDEA444", Offset = "0xDEA444", VA = "0xDEA444")]
	private void ThrowProjectile()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0xDEA5D0", Offset = "0xDEA5D0", VA = "0xDEA5D0")]
	public KoalaBehaviour()
	{
	}
}
[Token(Token = "0x2000032")]
public class platypusBehaviour : babyrooBehaviour
{
	[Token(Token = "0x600017B")]
	[Address(RVA = "0xED60DC", Offset = "0xED60DC", VA = "0xED60DC", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0xED611C", Offset = "0xED611C", VA = "0xED611C", Slot = "10")]
	protected override void hopWithoutBeer()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0xED6144", Offset = "0xED6144", VA = "0xED6144", Slot = "11")]
	protected override void hopWithBeer()
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0xED6168", Offset = "0xED6168", VA = "0xED6168")]
	public platypusBehaviour()
	{
	}
}
[Token(Token = "0x2000033")]
public class QuokkaBehaviour : Enemy
{
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADCB0", Offset = "0x9ADCB0")]
	private sealed class <WaitingForPhotoCoroutine>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public QuokkaBehaviour <>4__this;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int _timeToWait;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <_deltaTime>5__2;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <_timePassed>5__3;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <_timePassedSinceTextUpdate>5__4;

		[Token(Token = "0x1700005D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0xF6C02C", Offset = "0xF6C02C", VA = "0xF6C02C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0xF6C074", Offset = "0xF6C074", VA = "0xF6C074", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xF6BBF4", Offset = "0xF6BBF4", VA = "0xF6BBF4")]
		[DebuggerHidden]
		public <WaitingForPhotoCoroutine>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xF6BC20", Offset = "0xF6BC20", VA = "0xF6BC20", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xF6BC24", Offset = "0xF6BC24", VA = "0xF6BC24", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xF6C034", Offset = "0xF6C034", VA = "0xF6C034", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool readyForPhoto;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	private bool goingAway;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int timeToPhograph;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform pointToGoObject;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ParticleSystem photograhpedParticles;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ParticleSystem LeaveGameParticles;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject QuokkaSlot;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Renderer counterCircleRenderer;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Material counterCircleMaterial;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public TextMeshProUGUI timeText;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private IEnumerator waitingForPhoto;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected Animator animator;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Transform playerTransform;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private int jumps;

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x273B048", Offset = "0x273B048", VA = "0x273B048", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x273B158", Offset = "0x273B158", VA = "0x273B158")]
	private void Update()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x273B208", Offset = "0x273B208", VA = "0x273B208")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x273B4E8", Offset = "0x273B4E8", VA = "0x273B4E8")]
	private void CheckIfReachedDestination()
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x273B54C", Offset = "0x273B54C", VA = "0x273B54C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B0E20", Offset = "0x9B0E20")]
	private IEnumerator WaitingForPhotoCoroutine(int _timeToWait)
	{
		return null;
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x273B5C8", Offset = "0x273B5C8", VA = "0x273B5C8")]
	private void RollAway()
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x273B6BC", Offset = "0x273B6BC", VA = "0x273B6BC")]
	private void HappyJump()
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x273B720", Offset = "0x273B720", VA = "0x273B720")]
	public QuokkaBehaviour()
	{
	}
}
[Token(Token = "0x2000035")]
public class StickMealPart : MealPart
{
	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<ShrimpFoodAction> shrimps;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<HVRGrabbable> shrimpsGrabbables;

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x2742BF0", Offset = "0x2742BF0", VA = "0x2742BF0", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x274194C", Offset = "0x274194C", VA = "0x274194C")]
	public void AddShrimp(ShrimpFoodAction shrimp)
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x2742CBC", Offset = "0x2742CBC", VA = "0x2742CBC")]
	private void OnStickRelease(HVRHandGrabber grabber, HVRGrabbable _)
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x2742DE4", Offset = "0x2742DE4", VA = "0x2742DE4")]
	public StickMealPart()
	{
	}
}
[Token(Token = "0x2000036")]
public class VegemiteSpawner : MonoBehaviour
{
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADCC0", Offset = "0x9ADCC0")]
	private sealed class <SpawnVegemite>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VegemiteSpawner <>4__this;

		[Token(Token = "0x1700005F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x22914E4", Offset = "0x22914E4", VA = "0x22914E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x229152C", Offset = "0x229152C", VA = "0x229152C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2290DD4", Offset = "0x2290DD4", VA = "0x2290DD4")]
		[DebuggerHidden]
		public <SpawnVegemite>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x2290E00", Offset = "0x2290E00", VA = "0x2290E00", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2290E04", Offset = "0x2290E04", VA = "0x2290E04", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x22914EC", Offset = "0x22914EC", VA = "0x22914EC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform pointToGo;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform spawnPoint;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject cloud;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject breadPrefab;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject vegemitePrefab;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject particles;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float flyTime;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private AudioHandler audioHandler;

	[Token(Token = "0x6000191")]
	[Address(RVA = "0xECFD60", Offset = "0xECFD60", VA = "0xECFD60")]
	private void Start()
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0xECFDD4", Offset = "0xECFDD4", VA = "0xECFDD4")]
	private void FlyToPoint(Transform _transform)
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0xED0138", Offset = "0xED0138", VA = "0xED0138")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B0ED0", Offset = "0x9B0ED0")]
	private IEnumerator SpawnVegemite()
	{
		return null;
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0xED01A4", Offset = "0xED01A4", VA = "0xED01A4")]
	public VegemiteSpawner()
	{
	}
}
[Token(Token = "0x2000038")]
public class AutoAimCone : MonoBehaviour
{
	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Boomerang boomerang;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Rigidbody boomerangRigidBody;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float autoAimIntensity;

	[Token(Token = "0x600019B")]
	[Address(RVA = "0xD2AF98", Offset = "0xD2AF98", VA = "0xD2AF98")]
	private void Start()
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0xD2B148", Offset = "0xD2B148", VA = "0xD2B148")]
	private void Update()
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0xD2B074", Offset = "0xD2B074", VA = "0xD2B074")]
	public void SetAutoAimIntensity(int _autoAimValue)
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0xD2B1F8", Offset = "0xD2B1F8", VA = "0xD2B1F8")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0xD2B4A4", Offset = "0xD2B4A4", VA = "0xD2B4A4")]
	public AutoAimCone()
	{
	}
}
[Token(Token = "0x2000039")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x9ADCD0", Offset = "0x9ADCD0")]
public class Boomerang : MonoBehaviour
{
	[Token(Token = "0x200003A")]
	public enum BoomerangState
	{
		[Token(Token = "0x4000148")]
		POCKET,
		[Token(Token = "0x4000149")]
		ON_HAND,
		[Token(Token = "0x400014A")]
		FLYING_OUT,
		[Token(Token = "0x400014B")]
		FLYING_IN,
		[Token(Token = "0x400014C")]
		FLOP,
		[Token(Token = "0x400014D")]
		BETWEEN_ELECTRIC_HITS
	}

	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADD30", Offset = "0x9ADD30")]
	private sealed class <ElectricVibration>d__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Boomerang <>4__this;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds <waitHalfSecond>5__2;

		[Token(Token = "0x17000061")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0xED8EC0", Offset = "0xED8EC0", VA = "0xED8EC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0xED8F08", Offset = "0xED8F08", VA = "0xED8F08", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xED8D58", Offset = "0xED8D58", VA = "0xED8D58")]
		[DebuggerHidden]
		public <ElectricVibration>d__42(int <>1__state)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xED8D84", Offset = "0xED8D84", VA = "0xED8D84", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xED8D88", Offset = "0xED8D88", VA = "0xED8D88", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xED8EC8", Offset = "0xED8EC8", VA = "0xED8EC8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADD40", Offset = "0x9ADD40")]
	private sealed class <DestroyBoomerang>d__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Boomerang <>4__this;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x17000063")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0xED8D08", Offset = "0xED8D08", VA = "0xED8D08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0xED8D50", Offset = "0xED8D50", VA = "0xED8D50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xED8AC8", Offset = "0xED8AC8", VA = "0xED8AC8")]
		[DebuggerHidden]
		public <DestroyBoomerang>d__48(int <>1__state)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xED8AF4", Offset = "0xED8AF4", VA = "0xED8AF4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xED8AF8", Offset = "0xED8AF8", VA = "0xED8AF8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xED8D10", Offset = "0xED8D10", VA = "0xED8D10", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADD50", Offset = "0x9ADD50")]
	private sealed class <FlyOut>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Boomerang <>4__this;

		[Token(Token = "0x17000065")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0xED9750", Offset = "0xED9750", VA = "0xED9750", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000066")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0xED9798", Offset = "0xED9798", VA = "0xED9798", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xED9380", Offset = "0xED9380", VA = "0xED9380")]
		[DebuggerHidden]
		public <FlyOut>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xED93AC", Offset = "0xED93AC", VA = "0xED93AC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xED93B0", Offset = "0xED93B0", VA = "0xED93B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xED9758", Offset = "0xED9758", VA = "0xED9758", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADD60", Offset = "0x9ADD60")]
	private sealed class <FlyIn>d__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Boomerang <>4__this;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3[] _curvePoints;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float _curveTime;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <time>5__2;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <start_slow_time>5__3;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <slowReceptionMultiplier>5__4;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool <setOriginalLayerFlag>5__5;

		[Token(Token = "0x17000067")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0xED9330", Offset = "0xED9330", VA = "0xED9330", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0xED9378", Offset = "0xED9378", VA = "0xED9378", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xED8F10", Offset = "0xED8F10", VA = "0xED8F10")]
		[DebuggerHidden]
		public <FlyIn>d__51(int <>1__state)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xED8F3C", Offset = "0xED8F3C", VA = "0xED8F3C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xED8F40", Offset = "0xED8F40", VA = "0xED8F40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xED9338", Offset = "0xED9338", VA = "0xED9338", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADD70", Offset = "0x9ADD70")]
	private sealed class <SpawnAnimation>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Boomerang <>4__this;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <animationTime>5__2;

		[Token(Token = "0x17000069")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0xED9B64", Offset = "0xED9B64", VA = "0xED9B64", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0xED9BAC", Offset = "0xED9BAC", VA = "0xED9BAC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xED9A5C", Offset = "0xED9A5C", VA = "0xED9A5C")]
		[DebuggerHidden]
		public <SpawnAnimation>d__52(int <>1__state)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xED9A88", Offset = "0xED9A88", VA = "0xED9A88", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xED9A8C", Offset = "0xED9A8C", VA = "0xED9A8C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xED9B6C", Offset = "0xED9B6C", VA = "0xED9B6C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADD80", Offset = "0x9ADD80")]
	private sealed class <DestroyAnimation>d__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Boomerang <>4__this;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <animationTime>5__2;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <_time>5__3;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <dissolveAmount>5__4;

		[Token(Token = "0x1700006B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0xED8A78", Offset = "0xED8A78", VA = "0xED8A78", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0xED8AC0", Offset = "0xED8AC0", VA = "0xED8AC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xED88EC", Offset = "0xED88EC", VA = "0xED88EC")]
		[DebuggerHidden]
		public <DestroyAnimation>d__53(int <>1__state)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xED8918", Offset = "0xED8918", VA = "0xED8918", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xED891C", Offset = "0xED891C", VA = "0xED891C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xED8A80", Offset = "0xED8A80", VA = "0xED8A80", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADD90", Offset = "0x9ADD90")]
	private sealed class <>c__DisplayClass59_0
	{
		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Enemy _hitEnemy;

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xED886C", Offset = "0xED886C", VA = "0xED886C")]
		public <>c__DisplayClass59_0()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xED8874", Offset = "0xED8874", VA = "0xED8874")]
		internal bool <FindRandomCloseEnemy>b__0(Enemy val)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADDA0", Offset = "0x9ADDA0")]
	private sealed class <ShortlyIgnoringEnemies>d__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Boomerang <>4__this;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float _time;

		[Token(Token = "0x1700006D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0xED98A8", Offset = "0xED98A8", VA = "0xED98A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0xED98F0", Offset = "0xED98F0", VA = "0xED98F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xED97A0", Offset = "0xED97A0", VA = "0xED97A0")]
		[DebuggerHidden]
		public <ShortlyIgnoringEnemies>d__62(int <>1__state)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xED97CC", Offset = "0xED97CC", VA = "0xED97CC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xED97D0", Offset = "0xED97D0", VA = "0xED97D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xED98B0", Offset = "0xED98B0", VA = "0xED98B0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADDB0", Offset = "0x9ADDB0")]
	private sealed class <ShortlyUncolidable>d__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Boomerang <>4__this;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float _time;

		[Token(Token = "0x1700006F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0xED9A0C", Offset = "0xED9A0C", VA = "0xED9A0C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0xED9A54", Offset = "0xED9A54", VA = "0xED9A54", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xED98F8", Offset = "0xED98F8", VA = "0xED98F8")]
		[DebuggerHidden]
		public <ShortlyUncolidable>d__63(int <>1__state)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xED9924", Offset = "0xED9924", VA = "0xED9924", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xED9928", Offset = "0xED9928", VA = "0xED9928", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xED9A14", Offset = "0xED9A14", VA = "0xED9A14", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float angularVelocityMultiplier;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float velocityMultiplier;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float timeBeforeReturn;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float timeFlyInNatural;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float timeFlyInHitEnemy;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AED04", Offset = "0x9AED04")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AED04", Offset = "0x9AED04")]
	public float HardnessToThrow;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool isFrisbie;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AED58", Offset = "0x9AED58")]
	public float gravityFlyingOut;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int damageToGive;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float timeUntilDestruction;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int timesCatched;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool electric;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ParticleSystem OnCatchParticles;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ParticleSystem ElectricityParticles;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject ElectricTrailRenderer;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject ElectricHitParticles;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float ElectricDoubleHitDistance;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public BoomerangState state;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject onHitParticles;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private TrailRenderer trailRenderer;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Rigidbody rb;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Collider[] _colliders;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Material material;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public AudioHandler audioHandler;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private int layerBoomerangFlyingIn;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private int layerDefault;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public AutoAimCone autoAimCone;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public bool ignoreEnemies;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[HideInInspector]
	public HVRGrabbable grabbable;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float slowMoBoostFlyingOut;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private float slowMoBoostFlyingIn;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private CharacterController playerController;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private WaitForFixedUpdate waitForFixedUpdate;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private float _dissolveAmount;

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0xD2D524", Offset = "0xD2D524", VA = "0xD2D524")]
	protected void Awake()
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0xD2D74C", Offset = "0xD2D74C", VA = "0xD2D74C")]
	protected void Start()
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0xD2DA18", Offset = "0xD2DA18", VA = "0xD2DA18")]
	private void Update()
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0xD2DADC", Offset = "0xD2DADC", VA = "0xD2DADC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0xD2DC20", Offset = "0xD2DC20", VA = "0xD2DC20")]
	protected void BoomerangGrabbed(HVRGrabberBase grabber, HVRGrabbable grabable)
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0xD2DD1C", Offset = "0xD2DD1C", VA = "0xD2DD1C")]
	protected void BecomeElectric()
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0xD2DE18", Offset = "0xD2DE18", VA = "0xD2DE18")]
	protected void BecomeFaster()
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0xD2DF6C", Offset = "0xD2DF6C", VA = "0xD2DF6C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B0F80", Offset = "0x9B0F80")]
	private IEnumerator ElectricVibration()
	{
		return null;
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0xD2DFD8", Offset = "0xD2DFD8", VA = "0xD2DFD8")]
	protected void DoubleHit(Transform _closeEnemyTransform)
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0xD2E198", Offset = "0xD2E198", VA = "0xD2E198")]
	protected void BoomerangHandRelease(HVRHandGrabber hand, HVRGrabbable grabable)
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0xD2E930", Offset = "0xD2E930", VA = "0xD2E930")]
	public void InstantDestroyInPlace()
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0xD2EEA4", Offset = "0xD2EEA4", VA = "0xD2EEA4")]
	protected void BoomerangRelease(HVRGrabberBase grabber, HVRGrabbable grabable)
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0xD2DF64", Offset = "0xD2DF64", VA = "0xD2DF64")]
	protected void UpdateState(BoomerangState new_state)
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0xD2DBB4", Offset = "0xD2DBB4", VA = "0xD2DBB4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B0FE0", Offset = "0x9B0FE0")]
	private IEnumerator DestroyBoomerang()
	{
		return null;
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0xD2EEA8", Offset = "0xD2EEA8", VA = "0xD2EEA8")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0xD2E704", Offset = "0xD2E704", VA = "0xD2E704")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B1040", Offset = "0x9B1040")]
	private IEnumerator FlyOut()
	{
		return null;
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0xD2E110", Offset = "0xD2E110", VA = "0xD2E110")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B10A0", Offset = "0x9B10A0")]
	private IEnumerator FlyIn(Vector3[] _curvePoints, float _curveTime = 1f)
	{
		return null;
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0xD2DB48", Offset = "0xD2DB48", VA = "0xD2DB48")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B1100", Offset = "0x9B1100")]
	private IEnumerator SpawnAnimation()
	{
		return null;
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0xD2EE38", Offset = "0xD2EE38", VA = "0xD2EE38")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B1160", Offset = "0x9B1160")]
	private IEnumerator DestroyAnimation()
	{
		return null;
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0xD2E4E0", Offset = "0xD2E4E0", VA = "0xD2E4E0")]
	public bool isGoodThrow(Vector3 _velocity, Vector3 _angularVelocity)
	{
		return default(bool);
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0xD2FF2C", Offset = "0xD2FF2C", VA = "0xD2FF2C")]
	private Vector3 GetBezCurve(float t, Vector3[] _listOfPoints)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0xD30070", Offset = "0xD30070", VA = "0xD30070")]
	private float BinCoef(int _n, int _k)
	{
		return default(float);
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0xD2FD98", Offset = "0xD2FD98", VA = "0xD2FD98")]
	private Vector3 BoomerangReturnPosition(bool hit_enemy = false)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0xD2E684", Offset = "0xD2E684", VA = "0xD2E684")]
	public void EnableTrailRenderer(bool _bool)
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0xD2FB04", Offset = "0xD2FB04", VA = "0xD2FB04")]
	private GameObject FindRandomCloseEnemy(float _distance, Enemy _hitEnemy)
	{
		return null;
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0xD300B0", Offset = "0xD300B0", VA = "0xD300B0")]
	public void SetCollisionStatus(bool active)
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0xD2E770", Offset = "0xD2E770", VA = "0xD2E770")]
	private void RegisterBoomerangThrow()
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0xD2FA88", Offset = "0xD2FA88", VA = "0xD2FA88")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B11C0", Offset = "0x9B11C0")]
	private IEnumerator ShortlyIgnoringEnemies(float _time)
	{
		return null;
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0xD2FA0C", Offset = "0xD2FA0C", VA = "0xD2FA0C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B1220", Offset = "0x9B1220")]
	private IEnumerator ShortlyUncolidable(float _time)
	{
		return null;
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0xD2D5DC", Offset = "0xD2D5DC", VA = "0xD2D5DC")]
	private Material GetBoomerangMaterial()
	{
		return null;
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0xD300D0", Offset = "0xD300D0", VA = "0xD300D0")]
	public Collider[] GetColliders()
	{
		return null;
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0xD2DE38", Offset = "0xD2DE38", VA = "0xD2DE38")]
	private void ToggleCollisionLayer(bool flyingIn)
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0xD3012C", Offset = "0xD3012C", VA = "0xD3012C")]
	private void OnChangeLevel()
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0xD2E408", Offset = "0xD2E408", VA = "0xD2E408")]
	private CharacterController GetPlayerController()
	{
		return null;
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0xD301F8", Offset = "0xD301F8", VA = "0xD301F8")]
	public Boomerang()
	{
	}
}
[Token(Token = "0x2000044")]
public class BoomerangGrabHelper : MonoBehaviour
{
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADDC0", Offset = "0x9ADDC0")]
	private sealed class <LetItFallIn>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BoomerangGrabHelper <>4__this;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HVRGrabbable _grabbable;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Boomerang _boomerang;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float timeOfHelp;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <timerTime>5__2;

		[Token(Token = "0x17000071")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0xED9DE8", Offset = "0xED9DE8", VA = "0xED9DE8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0xED9E30", Offset = "0xED9E30", VA = "0xED9E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xED9BB4", Offset = "0xED9BB4", VA = "0xED9BB4")]
		[DebuggerHidden]
		public <LetItFallIn>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xED9BE0", Offset = "0xED9BE0", VA = "0xED9BE0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xED9BE4", Offset = "0xED9BE4", VA = "0xED9BE4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xED9DF0", Offset = "0xED9DF0", VA = "0xED9DF0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public HVRPlayerInputs inputs;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public HVRHandGrabber hand;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioHandler audioHandler;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int timesCatchedBefore;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private WaitForFixedUpdate waitForFixedUpdate;

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0xD3029C", Offset = "0xD3029C", VA = "0xD3029C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0xD30360", Offset = "0xD30360", VA = "0xD30360")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0xD303B4", Offset = "0xD303B4", VA = "0xD303B4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0xD3061C", Offset = "0xD3061C", VA = "0xD3061C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B1500", Offset = "0x9B1500")]
	private IEnumerator LetItFallIn(HVRGrabbable _grabbable, float timeOfHelp, Boomerang _boomerang)
	{
		return null;
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0xD306AC", Offset = "0xD306AC", VA = "0xD306AC")]
	private void RegisterBoomerangGrab(Boomerang _boomerang)
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0xD30A10", Offset = "0xD30A10", VA = "0xD30A10")]
	private void dingSound(HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0xD30B3C", Offset = "0xD30B3C", VA = "0xD30B3C")]
	public BoomerangGrabHelper()
	{
	}
}
[Token(Token = "0x2000046")]
public class BoomerangHolster : Holster
{
	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private AudioHandler audioHandler;

	[Token(Token = "0x6000202")]
	[Address(RVA = "0xD30BA0", Offset = "0xD30BA0", VA = "0xD30BA0", Slot = "25")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0xD30C00", Offset = "0xD30C00", VA = "0xD30C00", Slot = "62")]
	protected override void PlaySocketedSFX(HVRSocketable socketable)
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0xD30C54", Offset = "0xD30C54", VA = "0xD30C54", Slot = "63")]
	protected override void PlayUnsocketedSFX(HVRGrabbable grabbable)
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0xD30CA8", Offset = "0xD30CA8", VA = "0xD30CA8", Slot = "47")]
	public override bool CanHover(HVRGrabbable grabbable)
	{
		return default(bool);
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0xD30D84", Offset = "0xD30D84", VA = "0xD30D84", Slot = "67")]
	public override bool TryGrab(HVRGrabbable grabbable, bool force = false, bool ignoreGrabSound = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0xD30ED0", Offset = "0xD30ED0", VA = "0xD30ED0")]
	public BoomerangHolster()
	{
	}
}
[Token(Token = "0x2000047")]
public class BoomerangSpawner : MonoBehaviour
{
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADDD0", Offset = "0x9ADDD0")]
	private sealed class <CooldownBoomerang>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BoomerangSpawner <>4__this;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float cooldownTime;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <relative_time>5__2;

		[Token(Token = "0x17000073")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0xED9F94", Offset = "0xED9F94", VA = "0xED9F94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0xED9FDC", Offset = "0xED9FDC", VA = "0xED9FDC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xED9E38", Offset = "0xED9E38", VA = "0xED9E38")]
		[DebuggerHidden]
		public <CooldownBoomerang>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xED9E64", Offset = "0xED9E64", VA = "0xED9E64", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xED9E68", Offset = "0xED9E68", VA = "0xED9E68", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xED9F9C", Offset = "0xED9F9C", VA = "0xED9F9C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject spawnableBoomerang;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float coolDownTime;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject[] boomerangSkins;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Holster holster;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Material ringMaterial;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool pauseCooldownOnHover;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private bool pauseCooldown;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private WaitForFixedUpdate waitForFixedUpdate;

	[Token(Token = "0x6000208")]
	[Address(RVA = "0xD30ED8", Offset = "0xD30ED8", VA = "0xD30ED8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0xD3113C", Offset = "0xD3113C", VA = "0xD3113C")]
	public void SpawnNewBoomerang()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0xD3134C", Offset = "0xD3134C", VA = "0xD3134C")]
	private void removeFromPocket(HVRGrabberBase grabberBase, HVRGrabbable grabbable)
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0xD313F8", Offset = "0xD313F8", VA = "0xD313F8")]
	private void OnHoverEnter(HVRGrabberBase grabberBase, HVRGrabbable grabbable)
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0xD3140C", Offset = "0xD3140C", VA = "0xD3140C")]
	private void OnHoverExit(HVRGrabberBase grabberBase, HVRGrabbable grabbable)
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0xD3137C", Offset = "0xD3137C", VA = "0xD3137C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B15B0", Offset = "0x9B15B0")]
	private IEnumerator CooldownBoomerang(float cooldownTime = 5f)
	{
		return null;
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0xD31414", Offset = "0xD31414", VA = "0xD31414")]
	private void cancelCooldown(HVRGrabberBase grabberBase, HVRGrabbable grabbable)
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0xD3147C", Offset = "0xD3147C", VA = "0xD3147C")]
	private void NewPrefab(HVRGrabberBase grabberBase, HVRGrabbable grabbable)
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0xD315D8", Offset = "0xD315D8", VA = "0xD315D8")]
	public BoomerangSpawner()
	{
	}
}
[Token(Token = "0x2000049")]
public class BossHealthBar : MonoBehaviour
{
	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Gradient gradient;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image bar;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int maxHealth;

	[Token(Token = "0x6000217")]
	[Address(RVA = "0xD3164C", Offset = "0xD3164C", VA = "0xD3164C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0xD316AC", Offset = "0xD316AC", VA = "0xD316AC")]
	public void Damage(int healthValue)
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0xD31724", Offset = "0xD31724", VA = "0xD31724")]
	public BossHealthBar()
	{
	}
}
[Token(Token = "0x200004A")]
public class CanGuru : Enemy
{
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADDE0", Offset = "0x9ADDE0")]
	private sealed class <CanGuruInitialCoroutine>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CanGuru <>4__this;

		[Token(Token = "0x17000075")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0xEDA5EC", Offset = "0xEDA5EC", VA = "0xEDA5EC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0xEDA634", Offset = "0xEDA634", VA = "0xEDA634", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xEDA504", Offset = "0xEDA504", VA = "0xEDA504")]
		[DebuggerHidden]
		public <CanGuruInitialCoroutine>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xEDA530", Offset = "0xEDA530", VA = "0xEDA530", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xEDA534", Offset = "0xEDA534", VA = "0xEDA534", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xEDA5F4", Offset = "0xEDA5F4", VA = "0xEDA5F4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADDF0", Offset = "0x9ADDF0")]
	private sealed class <MoveToNextPointCoroutine>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CanGuru <>4__this;

		[Token(Token = "0x17000077")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0xEDB0C4", Offset = "0xEDB0C4", VA = "0xEDB0C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0xEDB10C", Offset = "0xEDB10C", VA = "0xEDB10C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xEDAC7C", Offset = "0xEDAC7C", VA = "0xEDAC7C")]
		[DebuggerHidden]
		public <MoveToNextPointCoroutine>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xEDACA8", Offset = "0xEDACA8", VA = "0xEDACA8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xEDACAC", Offset = "0xEDACAC", VA = "0xEDACAC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xEDB0CC", Offset = "0xEDB0CC", VA = "0xEDB0CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200004D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADE00", Offset = "0x9ADE00")]
	private sealed class <RegularFlameBeerCoroutine>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CanGuru <>4__this;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int beerNumber;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <i>5__2;

		[Token(Token = "0x17000079")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0xEDB9A4", Offset = "0xEDB9A4", VA = "0xEDB9A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0xEDB9EC", Offset = "0xEDB9EC", VA = "0xEDB9EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xEDB45C", Offset = "0xEDB45C", VA = "0xEDB45C")]
		[DebuggerHidden]
		public <RegularFlameBeerCoroutine>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xEDB488", Offset = "0xEDB488", VA = "0xEDB488", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xEDB48C", Offset = "0xEDB48C", VA = "0xEDB48C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xEDB9AC", Offset = "0xEDB9AC", VA = "0xEDB9AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200004E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADE10", Offset = "0x9ADE10")]
	private sealed class <BigFlameBeerCoroutine>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CanGuru <>4__this;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float size;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <animationTime>5__2;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject <bigFlameBeer>5__3;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Collider[] <beerColliders>5__4;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <_time>5__5;

		[Token(Token = "0x1700007B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0xEDA4B4", Offset = "0xEDA4B4", VA = "0xEDA4B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0xEDA4FC", Offset = "0xEDA4FC", VA = "0xEDA4FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xEDA058", Offset = "0xEDA058", VA = "0xEDA058")]
		[DebuggerHidden]
		public <BigFlameBeerCoroutine>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xEDA084", Offset = "0xEDA084", VA = "0xEDA084", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xEDA088", Offset = "0xEDA088", VA = "0xEDA088", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xEDA4BC", Offset = "0xEDA4BC", VA = "0xEDA4BC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200004F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADE20", Offset = "0x9ADE20")]
	private sealed class <>c__DisplayClass32_0
	{
		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject reflectiveBeer;

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xED9FE4", Offset = "0xED9FE4", VA = "0xED9FE4")]
		public <>c__DisplayClass32_0()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xED9FEC", Offset = "0xED9FEC", VA = "0xED9FEC")]
		internal bool <ReflectiveBeerCoroutine>b__0()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000050")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADE30", Offset = "0x9ADE30")]
	private sealed class <ReflectiveBeerCoroutine>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private <>c__DisplayClass32_0 <>8__1;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CanGuru <>4__this;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float velocityMultiplier;

		[Token(Token = "0x1700007D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0xEDB40C", Offset = "0xEDB40C", VA = "0xEDB40C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0xEDB454", Offset = "0xEDB454", VA = "0xEDB454", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xEDB114", Offset = "0xEDB114", VA = "0xEDB114")]
		[DebuggerHidden]
		public <ReflectiveBeerCoroutine>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xEDB140", Offset = "0xEDB140", VA = "0xEDB140", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xEDB144", Offset = "0xEDB144", VA = "0xEDB144", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xEDB414", Offset = "0xEDB414", VA = "0xEDB414", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADE40", Offset = "0x9ADE40")]
	private sealed class <VulnerableCoroutine>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CanGuru <>4__this;

		[Token(Token = "0x1700007F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600024E")]
			[Address(RVA = "0xEDBBA0", Offset = "0xEDBBA0", VA = "0xEDBBA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0xEDBBE8", Offset = "0xEDBBE8", VA = "0xEDBBE8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xEDB9F4", Offset = "0xEDB9F4", VA = "0xEDB9F4")]
		[DebuggerHidden]
		public <VulnerableCoroutine>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xEDBA20", Offset = "0xEDBA20", VA = "0xEDBA20", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xEDBA24", Offset = "0xEDBA24", VA = "0xEDBA24", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xEDBBA8", Offset = "0xEDBBA8", VA = "0xEDBBA8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADE50", Offset = "0x9ADE50")]
	private sealed class <GetHit>d__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CanGuru <>4__this;

		[Token(Token = "0x17000081")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0xEDAA14", Offset = "0xEDAA14", VA = "0xEDAA14", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0xEDAA5C", Offset = "0xEDAA5C", VA = "0xEDAA5C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xEDA63C", Offset = "0xEDA63C", VA = "0xEDA63C")]
		[DebuggerHidden]
		public <GetHit>d__34(int <>1__state)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xEDA668", Offset = "0xEDA668", VA = "0xEDA668", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xEDA66C", Offset = "0xEDA66C", VA = "0xEDA66C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xEDAA1C", Offset = "0xEDAA1C", VA = "0xEDAA1C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADE60", Offset = "0x9ADE60")]
	private sealed class <KillCanGuru>d__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CanGuru <>4__this;

		[Token(Token = "0x17000083")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0xEDAC2C", Offset = "0xEDAC2C", VA = "0xEDAC2C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0xEDAC74", Offset = "0xEDAC74", VA = "0xEDAC74", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xEDAA64", Offset = "0xEDAA64", VA = "0xEDAA64")]
		[DebuggerHidden]
		public <KillCanGuru>d__38(int <>1__state)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xEDAA90", Offset = "0xEDAA90", VA = "0xEDAA90", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xEDAA94", Offset = "0xEDAA94", VA = "0xEDAA94", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xEDAC34", Offset = "0xEDAC34", VA = "0xEDAC34", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AED80", Offset = "0x9AED80")]
	public float chanceOfChangingDirection;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AED98", Offset = "0x9AED98")]
	public float chanceOfRandom;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject pointsOfMovementParent;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<Transform> pointsOfMovement;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float movespeed;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject flameBeerPrefab;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject bigFlameBeerPrefab;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject reflectiveBeerPrefab;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Transform pointToSpawnProjectile;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Animator canGuruAnimator;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Animator cansAnimator;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Transform playerTransform;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject cricketBatPrefab;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public EnemyShield shield;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GameObject impactParticles;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public BossHealthBar healthBar;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public GameObject dirtPopParticles;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9AEDB0", Offset = "0x9AEDB0")]
	public int currentMovementPoint;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public int nextMovementPoint;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public bool reverseDirection;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public int moveNumbers;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public int phaseNumber;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public bool isReflectingPhase;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Level5GPM gamePlayManager;

	[Token(Token = "0x600021A")]
	[Address(RVA = "0xD32D78", Offset = "0xD32D78", VA = "0xD32D78")]
	private new void Start()
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0xD33024", Offset = "0xD33024", VA = "0xD33024")]
	private void Update()
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0xD32FB8", Offset = "0xD32FB8", VA = "0xD32FB8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B1660", Offset = "0x9B1660")]
	private IEnumerator CanGuruInitialCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0xD33070", Offset = "0xD33070", VA = "0xD33070")]
	private void DecideWhatToDo()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0xD33270", Offset = "0xD33270", VA = "0xD33270")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B16C0", Offset = "0x9B16C0")]
	private IEnumerator MoveToNextPointCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0xD33460", Offset = "0xD33460", VA = "0xD33460")]
	public void MoveToNextPoint()
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0xD33358", Offset = "0xD33358", VA = "0xD33358")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B1720", Offset = "0x9B1720")]
	public IEnumerator RegularFlameBeerCoroutine(int beerNumber, float delay = 0f)
	{
		return null;
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0xD332DC", Offset = "0xD332DC", VA = "0xD332DC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B1780", Offset = "0x9B1780")]
	private IEnumerator BigFlameBeerCoroutine(float size)
	{
		return null;
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0xD333E4", Offset = "0xD333E4", VA = "0xD333E4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B17E0", Offset = "0x9B17E0")]
	private IEnumerator ReflectiveBeerCoroutine(float velocityMultiplier = 1f)
	{
		return null;
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0xD3348C", Offset = "0xD3348C", VA = "0xD3348C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B1840", Offset = "0x9B1840")]
	private IEnumerator VulnerableCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0xD334F8", Offset = "0xD334F8", VA = "0xD334F8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B18A0", Offset = "0x9B18A0")]
	private IEnumerator GetHit()
	{
		return null;
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0xD33564", Offset = "0xD33564", VA = "0xD33564")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0xD33594", Offset = "0xD33594", VA = "0xD33594", Slot = "5")]
	public override void GiveDamage(int damageToGive)
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0xD336E0", Offset = "0xD336E0", VA = "0xD336E0")]
	private int GetNextMovementPoint()
	{
		return default(int);
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0xD33674", Offset = "0xD33674", VA = "0xD33674")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B1900", Offset = "0x9B1900")]
	private IEnumerator KillCanGuru()
	{
		return null;
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0xD337AC", Offset = "0xD337AC", VA = "0xD337AC")]
	public CanGuru()
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0xD337BC", Offset = "0xD337BC", VA = "0xD337BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B1960", Offset = "0x9B1960")]
	private Vector3 <RegularFlameBeerCoroutine>g__PlayerDirection|30_0()
	{
		return default(Vector3);
	}
}
[Token(Token = "0x2000054")]
public class EmuShield : EnemyShield
{
	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Emu emu;

	[Token(Token = "0x600025D")]
	[Address(RVA = "0xDDE3D0", Offset = "0xDDE3D0", VA = "0xDDE3D0", Slot = "4")]
	protected override void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0xDDE66C", Offset = "0xDDE66C", VA = "0xDDE66C")]
	public EmuShield()
	{
	}
}
[Token(Token = "0x2000055")]
public class Enemy : MonoBehaviour
{
	[Token(Token = "0x2000056")]
	public enum TypeOfEnemy
	{
		[Token(Token = "0x40001DB")]
		Babyroo,
		[Token(Token = "0x40001DC")]
		Kangaroo,
		[Token(Token = "0x40001DD")]
		Koala,
		[Token(Token = "0x40001DE")]
		Platypus,
		[Token(Token = "0x40001DF")]
		Dingo,
		[Token(Token = "0x40001E0")]
		Quokka,
		[Token(Token = "0x40001E1")]
		Other
	}

	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADE70", Offset = "0x9ADE70")]
	private sealed class <TemporarilyImuneCoroutine>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Enemy <>4__this;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float immuneTime;

		[Token(Token = "0x17000085")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0xEE0238", Offset = "0xEE0238", VA = "0xEE0238", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0xEE0280", Offset = "0xEE0280", VA = "0xEE0280", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xEE0140", Offset = "0xEE0140", VA = "0xEE0140")]
		[DebuggerHidden]
		public <TemporarilyImuneCoroutine>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xEE016C", Offset = "0xEE016C", VA = "0xEE016C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xEE0170", Offset = "0xEE0170", VA = "0xEE0170", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xEE0240", Offset = "0xEE0240", VA = "0xEE0240", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADE80", Offset = "0x9ADE80")]
	private sealed class <UnslapableFor>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Enemy <>4__this;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float _secondsToWait;

		[Token(Token = "0x17000087")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0xEE0378", Offset = "0xEE0378", VA = "0xEE0378", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000088")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0xEE03C0", Offset = "0xEE03C0", VA = "0xEE03C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xEE0288", Offset = "0xEE0288", VA = "0xEE0288")]
		[DebuggerHidden]
		public <UnslapableFor>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xEE02B4", Offset = "0xEE02B4", VA = "0xEE02B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xEE02B8", Offset = "0xEE02B8", VA = "0xEE02B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xEE0380", Offset = "0xEE0380", VA = "0xEE0380", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADE90", Offset = "0x9ADE90")]
	private sealed class <ImmuneFor>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Enemy <>4__this;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float _secondsToWait;

		[Token(Token = "0x17000089")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0xEE00F0", Offset = "0xEE00F0", VA = "0xEE00F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0xEE0138", Offset = "0xEE0138", VA = "0xEE0138", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xEDFFF8", Offset = "0xEDFFF8", VA = "0xEDFFF8")]
		[DebuggerHidden]
		public <ImmuneFor>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xEE0024", Offset = "0xEE0024", VA = "0xEE0024", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xEE0028", Offset = "0xEE0028", VA = "0xEE0028", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xEE00F8", Offset = "0xEE00F8", VA = "0xEE00F8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int enemyHealth;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool CanGrabBeer;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool imuneToDamage;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject deathEffect;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject beerStealParticles;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected AudioHandler audioHandler;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public NavMeshAgent agent;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool isSlappable;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	protected bool slapCooledDown;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float slapSpeedTreshold;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int pointsOnKill;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public TypeOfEnemy typeOfEnemy;

	[Token(Token = "0x600025F")]
	[Address(RVA = "0xDDE67C", Offset = "0xDDE67C", VA = "0xDDE67C", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0xDDE770", Offset = "0xDDE770", VA = "0xDDE770", Slot = "5")]
	public virtual void GiveDamage(int damageToGive)
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0xDDE85C", Offset = "0xDDE85C", VA = "0xDDE85C", Slot = "6")]
	public virtual void KillMe()
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0xDDE998", Offset = "0xDDE998", VA = "0xDDE998", Slot = "7")]
	public virtual void BeerSteal()
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0xDDE7E0", Offset = "0xDDE7E0", VA = "0xDDE7E0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B1BF0", Offset = "0x9B1BF0")]
	private IEnumerator TemporarilyImuneCoroutine(float immuneTime)
	{
		return null;
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0xDDEAA8", Offset = "0xDDEAA8", VA = "0xDDEAA8", Slot = "8")]
	protected virtual void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0xDDEBB8", Offset = "0xDDEBB8", VA = "0xDDEBB8", Slot = "9")]
	protected virtual void SlapEnemy(Collision collision)
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0xDDEC58", Offset = "0xDDEC58", VA = "0xDDEC58")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B1C50", Offset = "0x9B1C50")]
	private IEnumerator UnslapableFor(float _secondsToWait)
	{
		return null;
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0xDDECD4", Offset = "0xDDECD4", VA = "0xDDECD4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B1CB0", Offset = "0x9B1CB0")]
	private IEnumerator ImmuneFor(float _secondsToWait)
	{
		return null;
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0xDDE360", Offset = "0xDDE360", VA = "0xDDE360")]
	public Enemy()
	{
	}
}
[Token(Token = "0x200005A")]
public class EnemyShield : MonoBehaviour
{
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADEA0", Offset = "0x9ADEA0")]
	private sealed class <ActivateShield>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EnemyShield <>4__this;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <_initialAlpha>5__2;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <_time>5__3;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <flashDecayTime>5__4;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <_alpha>5__5;

		[Token(Token = "0x1700008B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000283")]
			[Address(RVA = "0xEE0648", Offset = "0xEE0648", VA = "0xEE0648", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0xEE0690", Offset = "0xEE0690", VA = "0xEE0690", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xEE03C8", Offset = "0xEE03C8", VA = "0xEE03C8")]
		[DebuggerHidden]
		public <ActivateShield>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xEE03F4", Offset = "0xEE03F4", VA = "0xEE03F4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xEE03F8", Offset = "0xEE03F8", VA = "0xEE03F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xEE0650", Offset = "0xEE0650", VA = "0xEE0650", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioHandler audioHandler;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Material shieldMaterial;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected float cooldown;

	[Token(Token = "0x600027B")]
	[Address(RVA = "0xDDED50", Offset = "0xDDED50", VA = "0xDDED50")]
	private void Start()
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0xDDEDD8", Offset = "0xDDEDD8", VA = "0xDDEDD8")]
	private void Update()
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0xDDE4A4", Offset = "0xDDE4A4", VA = "0xDDE4A4", Slot = "4")]
	protected virtual void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0xDDEE18", Offset = "0xDDEE18", VA = "0xDDEE18")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B1E00", Offset = "0x9B1E00")]
	protected IEnumerator ActivateShield()
	{
		return null;
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0xDDE674", Offset = "0xDDE674", VA = "0xDDE674")]
	public EnemyShield()
	{
	}
}
[Token(Token = "0x200005C")]
public class HittingBat : MonoBehaviour
{
	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADEB0", Offset = "0x9ADEB0")]
	private sealed class <CooldownHitCoroutine>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HittingBat <>4__this;

		[Token(Token = "0x1700008D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000290")]
			[Address(RVA = "0xF62580", Offset = "0xF62580", VA = "0xF62580", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0xF625C8", Offset = "0xF625C8", VA = "0xF625C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xF62490", Offset = "0xF62490", VA = "0xF62490")]
		[DebuggerHidden]
		public <CooldownHitCoroutine>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xF624BC", Offset = "0xF624BC", VA = "0xF624BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xF624C0", Offset = "0xF624C0", VA = "0xF624C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xF62588", Offset = "0xF62588", VA = "0xF62588", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200005E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADEC0", Offset = "0x9ADEC0")]
	private sealed class <DelayedBabyrooReaction>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public babyrooBehaviour babyroo;

		[Token(Token = "0x1700008F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000296")]
			[Address(RVA = "0xF626AC", Offset = "0xF626AC", VA = "0xF626AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000090")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000298")]
			[Address(RVA = "0xF626F4", Offset = "0xF626F4", VA = "0xF626F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xF625D0", Offset = "0xF625D0", VA = "0xF625D0")]
		[DebuggerHidden]
		public <DelayedBabyrooReaction>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xF625FC", Offset = "0xF625FC", VA = "0xF625FC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xF62600", Offset = "0xF62600", VA = "0xF62600", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xF626B4", Offset = "0xF626B4", VA = "0xF626B4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Rigidbody hitPointRB;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject FlyingAwayParticlesPrefab;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioHandler audioHandler;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float velocityToHit;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float velocityMultiplier;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float upBonus;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool onCooldown;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject onHitParticles;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject onSmashParticles;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private HVRGrabbable grabbable;

	[Token(Token = "0x6000286")]
	[Address(RVA = "0xDE8610", Offset = "0xDE8610", VA = "0xDE8610")]
	private void Start()
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0xDE8688", Offset = "0xDE8688", VA = "0xDE8688")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0xDE8F40", Offset = "0xDE8F40", VA = "0xDE8F40")]
	private void Cooldown()
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0xDE8F6C", Offset = "0xDE8F6C", VA = "0xDE8F6C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B1EB0", Offset = "0x9B1EB0")]
	private IEnumerator CooldownHitCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0xDE8ED4", Offset = "0xDE8ED4", VA = "0xDE8ED4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B1F10", Offset = "0x9B1F10")]
	private IEnumerator DelayedBabyrooReaction(babyrooBehaviour babyroo)
	{
		return null;
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0xDE8D14", Offset = "0xDE8D14", VA = "0xDE8D14")]
	private void SendFlying(Rigidbody rb, Collision collision, bool playSound = true)
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0xDE8FD8", Offset = "0xDE8FD8", VA = "0xDE8FD8")]
	public HittingBat()
	{
	}
}
[Token(Token = "0x200005F")]
public class HomingProjectile : MonoBehaviour
{
	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADED0", Offset = "0x9ADED0")]
	private sealed class <SelfDestructCoroutine>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int _projectileLifeTime;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HomingProjectile <>4__this;

		[Token(Token = "0x17000091")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0xF62BBC", Offset = "0xF62BBC", VA = "0xF62BBC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000092")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0xF62C04", Offset = "0xF62C04", VA = "0xF62C04", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xF62ABC", Offset = "0xF62ABC", VA = "0xF62ABC")]
		[DebuggerHidden]
		public <SelfDestructCoroutine>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xF62AE8", Offset = "0xF62AE8", VA = "0xF62AE8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xF62AEC", Offset = "0xF62AEC", VA = "0xF62AEC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xF62BC4", Offset = "0xF62BC4", VA = "0xF62BC4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADEE0", Offset = "0x9ADEE0")]
	private sealed class <DelayedColliderActivation>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float _delayTime;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HomingProjectile <>4__this;

		[Token(Token = "0x17000093")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0xF62808", Offset = "0xF62808", VA = "0xF62808", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0xF62850", Offset = "0xF62850", VA = "0xF62850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xF626FC", Offset = "0xF626FC", VA = "0xF626FC")]
		[DebuggerHidden]
		public <DelayedColliderActivation>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xF62728", Offset = "0xF62728", VA = "0xF62728", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xF6272C", Offset = "0xF6272C", VA = "0xF6272C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xF62810", Offset = "0xF62810", VA = "0xF62810", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADEF0", Offset = "0x9ADEF0")]
	private sealed class <UnHomeProjectileCoroutine>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HomingProjectile <>4__this;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AudioSource <hoverSound>5__2;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <i>5__3;

		[Token(Token = "0x17000095")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0xF62D94", Offset = "0xF62D94", VA = "0xF62D94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0xF62DDC", Offset = "0xF62DDC", VA = "0xF62DDC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xF62C0C", Offset = "0xF62C0C", VA = "0xF62C0C")]
		[DebuggerHidden]
		public <UnHomeProjectileCoroutine>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xF62C38", Offset = "0xF62C38", VA = "0xF62C38", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xF62C3C", Offset = "0xF62C3C", VA = "0xF62C3C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xF62D9C", Offset = "0xF62D9C", VA = "0xF62D9C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADF00", Offset = "0x9ADF00")]
	private sealed class <MingleProjectile>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HomingProjectile <>4__this;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <time>5__2;

		[Token(Token = "0x17000097")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0xF62A6C", Offset = "0xF62A6C", VA = "0xF62A6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000098")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0xF62AB4", Offset = "0xF62AB4", VA = "0xF62AB4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xF62858", Offset = "0xF62858", VA = "0xF62858")]
		[DebuggerHidden]
		public <MingleProjectile>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xF62884", Offset = "0xF62884", VA = "0xF62884", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xF62888", Offset = "0xF62888", VA = "0xF62888", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xF62A74", Offset = "0xF62A74", VA = "0xF62A74", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform targetTransform;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float velocity;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AEDE8", Offset = "0x9AEDE8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AEDE8", Offset = "0x9AEDE8")]
	public float sharpTurn;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int damageToGive;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool hurtsEnemies;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int projectileLifeTime;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float projectileActivationDelay;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject HitParticles;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject SelfDesctructParticles;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected Rigidbody rb;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected Vector3 pushVector;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Vector3 previouspushVector;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected Vector3 vectorToTarget;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	protected bool randomized;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected Vector3 targetPosition;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected AudioHandler audioHandler;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool activeProjectile;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	public bool homingProjectile;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected Coroutine selfDestruction;

	[Token(Token = "0x6000299")]
	[Address(RVA = "0xDE8FE0", Offset = "0xDE8FE0", VA = "0xDE8FE0", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0xDE931C", Offset = "0xDE931C", VA = "0xDE931C", Slot = "5")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0xDE9550", Offset = "0xDE9550", VA = "0xDE9550", Slot = "6")]
	protected virtual void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0xDE9690", Offset = "0xDE9690", VA = "0xDE9690")]
	protected void HurtPlayer(int _damageToGive)
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0xDE9884", Offset = "0xDE9884", VA = "0xDE9884")]
	protected void HurtEnemy(int _damageToGive, Enemy _enemy)
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0xDE9750", Offset = "0xDE9750", VA = "0xDE9750")]
	protected void HitFloor()
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0xDE9224", Offset = "0xDE9224", VA = "0xDE9224")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B2010", Offset = "0x9B2010")]
	protected IEnumerator SelfDestructCoroutine(int _projectileLifeTime)
	{
		return null;
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0xDE92A0", Offset = "0xDE92A0", VA = "0xDE92A0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B2070", Offset = "0x9B2070")]
	private IEnumerator DelayedColliderActivation(float _delayTime)
	{
		return null;
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0xDE94E4", Offset = "0xDE94E4", VA = "0xDE94E4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B20D0", Offset = "0x9B20D0")]
	private IEnumerator UnHomeProjectileCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0xDE99E0", Offset = "0xDE99E0", VA = "0xDE99E0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B2130", Offset = "0x9B2130")]
	public IEnumerator MingleProjectile()
	{
		return null;
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0xDE9A4C", Offset = "0xDE9A4C", VA = "0xDE9A4C")]
	private void MingleProjectileFunction()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0xDE9A78", Offset = "0xDE9A78", VA = "0xDE9A78", Slot = "7")]
	protected virtual void DestroyProjectile(GameObject _particles, string _sound = "DestroySound")
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0xDE9CCC", Offset = "0xDE9CCC", VA = "0xDE9CCC", Slot = "8")]
	protected virtual void DestroyProjectile()
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0xDE9EA4", Offset = "0xDE9EA4", VA = "0xDE9EA4")]
	public HomingProjectile()
	{
	}
}
[Token(Token = "0x2000064")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x9ADF10", Offset = "0x9ADF10")]
public class HurtPlayerOnContact : MonoBehaviour
{
	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADF70", Offset = "0x9ADF70")]
	private sealed class <HurtPlayerCooldown>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HurtPlayerOnContact <>4__this;

		[Token(Token = "0x17000099")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0xF62ED4", Offset = "0xF62ED4", VA = "0xF62ED4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0xF62F1C", Offset = "0xF62F1C", VA = "0xF62F1C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xF62DE4", Offset = "0xF62DE4", VA = "0xF62DE4")]
		[DebuggerHidden]
		public <HurtPlayerCooldown>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xF62E10", Offset = "0xF62E10", VA = "0xF62E10", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xF62E14", Offset = "0xF62E14", VA = "0xF62E14", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xF62EDC", Offset = "0xF62EDC", VA = "0xF62EDC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int damageToGive;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParticleSystem hitParticles;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioHandler audioHandler;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float hurtCooldown;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool hurting;

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0xDE9EC0", Offset = "0xDE9EC0", VA = "0xDE9EC0")]
	private void Start()
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0xDE9F1C", Offset = "0xDE9F1C", VA = "0xDE9F1C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0xDE9FA0", Offset = "0xDE9FA0", VA = "0xDE9FA0")]
	private void HurtPlayer(int _damageToGive)
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0xDEA0FC", Offset = "0xDEA0FC", VA = "0xDEA0FC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B22D0", Offset = "0x9B22D0")]
	private IEnumerator HurtPlayerCooldown()
	{
		return null;
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0xDEA168", Offset = "0xDEA168", VA = "0xDEA168")]
	public HurtPlayerOnContact()
	{
	}
}
[Token(Token = "0x2000066")]
public class DummyMole : MonoBehaviour
{
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADF80", Offset = "0x9ADF80")]
	private sealed class <ActivateExplosionParticles>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DummyMole <>4__this;

		[Token(Token = "0x1700009B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0xEDD374", Offset = "0xEDD374", VA = "0xEDD374", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0xEDD3BC", Offset = "0xEDD3BC", VA = "0xEDD3BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xEDD1D0", Offset = "0xEDD1D0", VA = "0xEDD1D0")]
		[DebuggerHidden]
		public <ActivateExplosionParticles>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xEDD1FC", Offset = "0xEDD1FC", VA = "0xEDD1FC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xEDD200", Offset = "0xEDD200", VA = "0xEDD200", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xEDD37C", Offset = "0xEDD37C", VA = "0xEDD37C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADF90", Offset = "0x9ADF90")]
	private sealed class <PeakCoroutine>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DummyMole <>4__this;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float delay;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float timeUp;

		[Token(Token = "0x1700009D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0xEDDDBC", Offset = "0xEDDDBC", VA = "0xEDDDBC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0xEDDE04", Offset = "0xEDDE04", VA = "0xEDDE04", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xEDD8C0", Offset = "0xEDD8C0", VA = "0xEDD8C0")]
		[DebuggerHidden]
		public <PeakCoroutine>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xEDD8EC", Offset = "0xEDD8EC", VA = "0xEDD8EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xEDD8F0", Offset = "0xEDD8F0", VA = "0xEDD8F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xEDDDC4", Offset = "0xEDDDC4", VA = "0xEDDDC4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADFA0", Offset = "0x9ADFA0")]
	private sealed class <HideCoroutine>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DummyMole <>4__this;

		[Token(Token = "0x1700009F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0xEDD870", Offset = "0xEDD870", VA = "0xEDD870", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A0")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0xEDD8B8", Offset = "0xEDD8B8", VA = "0xEDD8B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xEDD3C4", Offset = "0xEDD3C4", VA = "0xEDD3C4")]
		[DebuggerHidden]
		public <HideCoroutine>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xEDD3F0", Offset = "0xEDD3F0", VA = "0xEDD3F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xEDD3F4", Offset = "0xEDD3F4", VA = "0xEDD3F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xEDD878", Offset = "0xEDD878", VA = "0xEDD878", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public Events.EventDummyExploded OnDummyMoleExploded;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float depthMoleOutside;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 restPosition;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool exploded;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private AudioHandler audioHandler;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject explosionParticles;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject sparksParticles;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float moveDuration;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool isPeaking;

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0xDDC234", Offset = "0xDDC234", VA = "0xDDC234")]
	private void Start()
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0xDDC2AC", Offset = "0xDDC2AC", VA = "0xDDC2AC", Slot = "4")]
	protected virtual void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0xDDC3DC", Offset = "0xDDC3DC", VA = "0xDDC3DC")]
	public void Explode()
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0xDDC530", Offset = "0xDDC530", VA = "0xDDC530")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B2380", Offset = "0x9B2380")]
	private IEnumerator ActivateExplosionParticles()
	{
		return null;
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0xDDC6D0", Offset = "0xDDC6D0", VA = "0xDDC6D0")]
	public void Peak(float timeUp, float delay = 0f)
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0xDDC708", Offset = "0xDDC708", VA = "0xDDC708")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B23E0", Offset = "0x9B23E0")]
	private IEnumerator PeakCoroutine(float timeUp, float delay)
	{
		return null;
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0xDDC788", Offset = "0xDDC788", VA = "0xDDC788")]
	public void Hide()
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0xDDC7C4", Offset = "0xDDC7C4", VA = "0xDDC7C4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B2440", Offset = "0x9B2440")]
	private IEnumerator HideCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0xDDC830", Offset = "0xDDC830", VA = "0xDDC830")]
	public DummyMole()
	{
	}
}
[Token(Token = "0x200006A")]
public class Dynamite : MonoBehaviour
{
	[Token(Token = "0x200006B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADFB0", Offset = "0x9ADFB0")]
	private sealed class <CountDown>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Dynamite <>4__this;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <interval>5__2;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <fuseSectionInterval>5__3;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <fuseSectionCounter>5__4;

		[Token(Token = "0x170000A1")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0xEDE078", Offset = "0xEDE078", VA = "0xEDE078", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A2")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0xEDE0C0", Offset = "0xEDE0C0", VA = "0xEDE0C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xEDDE0C", Offset = "0xEDDE0C", VA = "0xEDDE0C")]
		[DebuggerHidden]
		public <CountDown>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xEDDE38", Offset = "0xEDDE38", VA = "0xEDDE38", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xEDDE3C", Offset = "0xEDDE3C", VA = "0xEDDE3C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xEDE080", Offset = "0xEDE080", VA = "0xEDE080", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float timeToExplode;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float timeLeft;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float explosionRadius;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MoleHole isInHole;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected Transform playerTransform;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected AudioHandler audioHandler;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected AudioSource tickingSound;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject explosionParticles;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject activeFuseSection;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject fuseParticles;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int fuseSections;

	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector3 fuseParticlesLocalPosition;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<Mesh> fuseVariationList;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Queue<Mesh> fuseVariationsQueue;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private SkinnedMeshRenderer skinnedMeshRenderer;

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Events.EventDynamiteExploded OnExplode;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Animator animator;

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0xDDC848", Offset = "0xDDC848", VA = "0xDDC848")]
	private void Start()
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0xDDCA78", Offset = "0xDDCA78", VA = "0xDDCA78")]
	public void Explode()
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0xDDCA0C", Offset = "0xDDCA0C", VA = "0xDDCA0C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B2590", Offset = "0x9B2590")]
	private IEnumerator CountDown()
	{
		return null;
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0xDDCD0C", Offset = "0xDDCD0C", VA = "0xDDCD0C")]
	private void useFuse()
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0xDDCEDC", Offset = "0xDDCEDC", VA = "0xDDCEDC")]
	public Dynamite()
	{
	}
}
[Token(Token = "0x200006C")]
public class Mole : Enemy
{
	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADFC0", Offset = "0x9ADFC0")]
	private sealed class <ThrowProjectile>d__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Mole <>4__this;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject projectilePrefab;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int numberOfProjectiles;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <waitBeforeFirstThrow>5__2;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <waitBeforeOneThrow>5__3;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <waitAfterOneThrow>5__4;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <waitAfterAllThrows>5__5;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float <targetVariance>5__6;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int <i>5__7;

		[Token(Token = "0x170000A3")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0xF68E30", Offset = "0xF68E30", VA = "0xF68E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A4")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600030E")]
			[Address(RVA = "0xF68E78", Offset = "0xF68E78", VA = "0xF68E78", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xF6884C", Offset = "0xF6884C", VA = "0xF6884C")]
		[DebuggerHidden]
		public <ThrowProjectile>d__36(int <>1__state)
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xF68878", Offset = "0xF68878", VA = "0xF68878", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xF6887C", Offset = "0xF6887C", VA = "0xF6887C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xF68E38", Offset = "0xF68E38", VA = "0xF68E38", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200006E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADFD0", Offset = "0x9ADFD0")]
	private sealed class <ShortlyUncolidable>d__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject projectile;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float _time;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Collider <_collider>5__2;

		[Token(Token = "0x170000A5")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000312")]
			[Address(RVA = "0xF687FC", Offset = "0xF687FC", VA = "0xF687FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A6")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000314")]
			[Address(RVA = "0xF68844", Offset = "0xF68844", VA = "0xF68844", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xF686E0", Offset = "0xF686E0", VA = "0xF686E0")]
		[DebuggerHidden]
		public <ShortlyUncolidable>d__37(int <>1__state)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xF6870C", Offset = "0xF6870C", VA = "0xF6870C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xF68710", Offset = "0xF68710", VA = "0xF68710", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xF68804", Offset = "0xF68804", VA = "0xF68804", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200006F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADFE0", Offset = "0x9ADFE0")]
	private sealed class <PeakCoroutine>d__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Mole <>4__this;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int hole;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float waitTime;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject projectile;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 <insidePosition>5__2;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 <outPosition>5__3;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string <onCompleteAction>5__4;

		[Token(Token = "0x170000A7")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0xF68374", Offset = "0xF68374", VA = "0xF68374", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A8")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0xF683BC", Offset = "0xF683BC", VA = "0xF683BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xF679FC", Offset = "0xF679FC", VA = "0xF679FC")]
		[DebuggerHidden]
		public <PeakCoroutine>d__38(int <>1__state)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xF67A28", Offset = "0xF67A28", VA = "0xF67A28", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xF67A2C", Offset = "0xF67A2C", VA = "0xF67A2C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xF6837C", Offset = "0xF6837C", VA = "0xF6837C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9ADFF0", Offset = "0x9ADFF0")]
	private sealed class <Hide>d__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Mole <>4__this;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 outPosition;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 insidePosition;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string onComplete;

		[Token(Token = "0x170000A9")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0xF679AC", Offset = "0xF679AC", VA = "0xF679AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AA")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000320")]
			[Address(RVA = "0xF679F4", Offset = "0xF679F4", VA = "0xF679F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xF6756C", Offset = "0xF6756C", VA = "0xF6756C")]
		[DebuggerHidden]
		public <Hide>d__39(int <>1__state)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xF67598", Offset = "0xF67598", VA = "0xF67598", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xF6759C", Offset = "0xF6759C", VA = "0xF6759C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xF679B4", Offset = "0xF679B4", VA = "0xF679B4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE000", Offset = "0x9AE000")]
	private sealed class <GetHit>d__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Mole <>4__this;

		[Token(Token = "0x170000AB")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0xF6751C", Offset = "0xF6751C", VA = "0xF6751C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AC")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0xF67564", Offset = "0xF67564", VA = "0xF67564", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xF66FA0", Offset = "0xF66FA0", VA = "0xF66FA0")]
		[DebuggerHidden]
		public <GetHit>d__40(int <>1__state)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xF66FCC", Offset = "0xF66FCC", VA = "0xF66FCC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xF66FD0", Offset = "0xF66FD0", VA = "0xF66FD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xF67524", Offset = "0xF67524", VA = "0xF67524", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE010", Offset = "0x9AE010")]
	private sealed class <ReThrowDynamite>d__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Dynamite dynamite;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Mole <>4__this;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MoleHole hole;

		[Token(Token = "0x170000AD")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0xF68690", Offset = "0xF68690", VA = "0xF68690", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AE")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0xF686D8", Offset = "0xF686D8", VA = "0xF686D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xF683C4", Offset = "0xF683C4", VA = "0xF683C4")]
		[DebuggerHidden]
		public <ReThrowDynamite>d__47(int <>1__state)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xF683F0", Offset = "0xF683F0", VA = "0xF683F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xF683F4", Offset = "0xF683F4", VA = "0xF683F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xF68698", Offset = "0xF68698", VA = "0xF68698", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000073")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE020", Offset = "0x9AE020")]
	private sealed class <WaitThenDecideWhatToDo>d__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float waitTime;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Mole <>4__this;

		[Token(Token = "0x170000AF")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0xF68FD0", Offset = "0xF68FD0", VA = "0xF68FD0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B0")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0xF69018", Offset = "0xF69018", VA = "0xF69018", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xF68E80", Offset = "0xF68E80", VA = "0xF68E80")]
		[DebuggerHidden]
		public <WaitThenDecideWhatToDo>d__49(int <>1__state)
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xF68EAC", Offset = "0xF68EAC", VA = "0xF68EAC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xF68EB0", Offset = "0xF68EB0", VA = "0xF68EB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xF68FD8", Offset = "0xF68FD8", VA = "0xF68FD8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject moleHolesParent;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<Transform> moleHoles;

	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int currentHole;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int peakCounter;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float depthMoleInside;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float depthMoleOutside;

	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float moveDuration;

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Transform pointToSpawnProjectile;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Transform playerTransform;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Animator animator;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public MeshRenderer hat;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject damageParticles;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public BossHealthBar healthBar;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float minTimeOutside;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public float maxTimeOutside;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public float timeBetweenShowingUp;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public float timeAfterGettingHit;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GameObject dummyMolesParent;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public DummyMole[] dummyMoles;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public GameObject poopProjectile;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public GameObject dynamiteProjectile;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public GameObject bigDynamiteProjectile;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public float projectileVerticalForceMultiplier;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public float projectileHorizontalForceMultiplier;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public GameObject beerPrefab;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public EnemyShield shield;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9AEE4C", Offset = "0x9AEE4C")]
	public int phaseNumber;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private float timeInPhase;

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x273091C", Offset = "0x273091C", VA = "0x273091C")]
	private new void Start()
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x2730D40", Offset = "0x2730D40", VA = "0x2730D40")]
	private void Update()
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x2730C40", Offset = "0x2730C40", VA = "0x2730C40")]
	private void DecideWhatToDo()
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x2731260", Offset = "0x2731260", VA = "0x2731260")]
	private float GetRandomWaitTime()
	{
		return default(float);
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x2730D78", Offset = "0x2730D78", VA = "0x2730D78")]
	private void GoToRandomHoleOrShowDummy()
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x2730E64", Offset = "0x2730E64", VA = "0x2730E64")]
	private void ShowDummyAndGoToRandomHole()
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x273119C", Offset = "0x273119C", VA = "0x273119C")]
	private void GoToRandomtHoleAndThrowProjectile()
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x2731394", Offset = "0x2731394", VA = "0x2731394")]
	private void ShowRandomDummy(int hole, float waitTime, float delay = 0f)
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x273158C", Offset = "0x273158C", VA = "0x273158C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B2640", Offset = "0x9B2640")]
	private IEnumerator ThrowProjectile(GameObject projectilePrefab, int numberOfProjectiles = 1)
	{
		return null;
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x273160C", Offset = "0x273160C", VA = "0x273160C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B26A0", Offset = "0x9B26A0")]
	private IEnumerator ShortlyUncolidable(GameObject projectile, float _time)
	{
		return null;
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x2731300", Offset = "0x2731300", VA = "0x2731300")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B2700", Offset = "0x9B2700")]
	private IEnumerator PeakCoroutine(int hole, float waitTime, [Optional] GameObject projectile)
	{
		return null;
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x2731688", Offset = "0x2731688", VA = "0x2731688")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B2760", Offset = "0x9B2760")]
	private IEnumerator Hide(Vector3 outPosition, Vector3 insidePosition, string onComplete = "DecideWhatToDo")
	{
		return null;
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x2731740", Offset = "0x2731740", VA = "0x2731740")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B27C0", Offset = "0x9B27C0")]
	private IEnumerator GetHit()
	{
		return null;
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x27317AC", Offset = "0x27317AC", VA = "0x27317AC")]
	public void DropABeer([Optional] Transform origin)
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x2731910", Offset = "0x2731910", VA = "0x2731910", Slot = "5")]
	public override void GiveDamage(int damageToGive)
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x2731AEC", Offset = "0x2731AEC", VA = "0x2731AEC")]
	private void OnDummyExplode()
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x2731BB4", Offset = "0x2731BB4", VA = "0x2731BB4")]
	private void GettingHitThenDecideWhatToDo()
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x2731BE4", Offset = "0x2731BE4", VA = "0x2731BE4")]
	private void OnDynamiteExplode(Dynamite dynamite)
	{
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x2731DC8", Offset = "0x2731DC8", VA = "0x2731DC8")]
	private void OnDynamiteEntersHole(MoleHole hole, Dynamite dynamite)
	{
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x2731F8C", Offset = "0x2731F8C", VA = "0x2731F8C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B2820", Offset = "0x9B2820")]
	private IEnumerator ReThrowDynamite(MoleHole hole, Dynamite dynamite)
	{
		return null;
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x273200C", Offset = "0x273200C", VA = "0x273200C")]
	private void MoveOnToNextPhase()
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x2731400", Offset = "0x2731400", VA = "0x2731400")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B2880", Offset = "0x9B2880")]
	private IEnumerator WaitThenDecideWhatToDo(float waitTime)
	{
		return null;
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x2731298", Offset = "0x2731298", VA = "0x2731298")]
	private int GetNextHole()
	{
		return default(int);
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x273147C", Offset = "0x273147C", VA = "0x273147C")]
	private int[] GetNextHoles(int n = 1)
	{
		return null;
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x27320D8", Offset = "0x27320D8", VA = "0x27320D8")]
	public Mole()
	{
	}
}
[Token(Token = "0x2000074")]
public class MoleHole : MonoBehaviour
{
	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Events.EventDynamiteEntersHole OnDynamiteEnterHole;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject SmokeParticles;

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x2732100", Offset = "0x2732100", VA = "0x2732100")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0x273219C", Offset = "0x273219C", VA = "0x273219C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0x2731DA8", Offset = "0x2731DA8", VA = "0x2731DA8")]
	public void Explode()
	{
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x2732214", Offset = "0x2732214", VA = "0x2732214")]
	public MoleHole()
	{
	}
}
[Token(Token = "0x2000075")]
public class PoopProjectile : MonoBehaviour
{
	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected AudioHandler audioHandler;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected Collider _collider;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected Renderer _renderer;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ParticleSystem optionalHitParticles;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int damageToGive;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool hasHurtPlayer;

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x273A020", Offset = "0x273A020", VA = "0x273A020")]
	private void Start()
	{
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x273A0BC", Offset = "0x273A0BC", VA = "0x273A0BC")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x273A348", Offset = "0x273A348", VA = "0x273A348")]
	public PoopProjectile()
	{
	}
}
[Token(Token = "0x2000076")]
public class ReflectiveBat : MonoBehaviour
{
	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Rigidbody hitPointRB;

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x273BE5C", Offset = "0x273BE5C", VA = "0x273BE5C")]
	public ReflectiveBat()
	{
	}
}
[Token(Token = "0x2000077")]
public class ReflectiveBeer : HomingProjectile
{
	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private int reflectedTimes;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject cricketBatIndicator;

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x273BE64", Offset = "0x273BE64", VA = "0x273BE64", Slot = "6")]
	protected override void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x273C308", Offset = "0x273C308", VA = "0x273C308")]
	public ReflectiveBeer()
	{
	}
}
[Token(Token = "0x2000078")]
public class BurgerFiniteSpawnerSocket : FiniteSpawnerSocket
{
	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	public GameObject meatOption;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public GameObject veggieOption;

	[Token(Token = "0x600033D")]
	[Address(RVA = "0xD32758", Offset = "0xD32758", VA = "0xD32758", Slot = "25")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0xD32808", Offset = "0xD32808", VA = "0xD32808")]
	public BurgerFiniteSpawnerSocket()
	{
	}
}
[Token(Token = "0x2000079")]
public class Plate : MonoBehaviour
{
	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private HVRGrabbable grabbable;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AussieSocket socket;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private LayerMask layerMask;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float raycastDistance;

	[Token(Token = "0x600033F")]
	[Address(RVA = "0x27380A4", Offset = "0x27380A4", VA = "0x27380A4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0x273814C", Offset = "0x273814C", VA = "0x273814C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0x273847C", Offset = "0x273847C", VA = "0x273847C")]
	public Plate()
	{
	}
}
[Token(Token = "0x200007A")]
public enum RequestType
{
	[Token(Token = "0x40002B8")]
	PrimaryBeer,
	[Token(Token = "0x40002B9")]
	SecondaryBeer,
	[Token(Token = "0x40002BA")]
	Burger,
	[Token(Token = "0x40002BB")]
	Snag,
	[Token(Token = "0x40002BC")]
	Vegemite,
	[Token(Token = "0x40002BD")]
	Skewer
}
[Token(Token = "0x200007B")]
public class RequestHandler : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200007C")]
	public class Request
	{
		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float deadlineInSeconds;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float delayIntervalInSeconds;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RequestType requestType;

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x228DCE0", Offset = "0x228DCE0", VA = "0x228DCE0")]
		public Request(float _deadlineInSeconds, float _delayIntervalInSeconds, RequestType _requestType)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200007D")]
	public class RequestTypeMap
	{
		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RequestType requestType;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Sprite requestIcon;

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x228DD20", Offset = "0x228DD20", VA = "0x228DD20")]
		public RequestTypeMap()
		{
		}
	}

	[Token(Token = "0x200007E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE030", Offset = "0x9AE030")]
	private sealed class <AddRequestToSlot>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RequestHandler <>4__this;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Request _request;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RequestSlot _slot;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <i>5__2;

		[Token(Token = "0x170000B1")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x228D8D4", Offset = "0x228D8D4", VA = "0x228D8D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B2")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x228D91C", Offset = "0x228D91C", VA = "0x228D91C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x228D69C", Offset = "0x228D69C", VA = "0x228D69C")]
		[DebuggerHidden]
		public <AddRequestToSlot>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x228D6C8", Offset = "0x228D6C8", VA = "0x228D6C8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x228D6CC", Offset = "0x228D6CC", VA = "0x228D6CC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x228D8DC", Offset = "0x228D8DC", VA = "0x228D8DC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE040", Offset = "0x9AE040")]
	private sealed class <>c
	{
		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<RequestSlot> <>9__19_0;

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x228D66C", Offset = "0x228D66C", VA = "0x228D66C")]
		public <>c()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x228D674", Offset = "0x228D674", VA = "0x228D674")]
		internal int <GetSlotForRequest>b__19_0(RequestSlot s1, RequestSlot s2)
		{
			return default(int);
		}
	}

	[Token(Token = "0x2000080")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE050", Offset = "0x9AE050")]
	private sealed class <ThrowAway>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RequestHandler <>4__this;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HVRGrabbable _grabbable;

		[Token(Token = "0x170000B3")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x228DC90", Offset = "0x228DC90", VA = "0x228DC90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B4")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x228DCD8", Offset = "0x228DCD8", VA = "0x228DCD8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x228D924", Offset = "0x228D924", VA = "0x228D924")]
		[DebuggerHidden]
		public <ThrowAway>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x228D950", Offset = "0x228D950", VA = "0x228D950", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x228D954", Offset = "0x228D954", VA = "0x228D954", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x228DC98", Offset = "0x228DC98", VA = "0x228DC98", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RequestSlot defaultSlot;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<RequestSlot> requestSlots;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Request> listOfRequests;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Queue<Request> _queueOfRequests;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private AudioHandler audioHandler;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject sucessParticles;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool failCoolingDown;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float requestDelayMultiplier;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int finalRequestsCounter;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject weAreDone;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject requestSuccessFailCanvas;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<RequestTypeMap> requestTypeSpriteMap;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Dictionary<RequestType, Sprite> _requestTypeSpriteMap;

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x273C3B0", Offset = "0x273C3B0", VA = "0x273C3B0")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0x273C8E0", Offset = "0x273C8E0", VA = "0x273C8E0")]
	private void AddNewRequestToSlot(RequestSlot _slot)
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0x273CB48", Offset = "0x273CB48", VA = "0x273CB48")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B2B10", Offset = "0x9B2B10")]
	private IEnumerator AddRequestToSlot(RequestSlot _slot, Request _request)
	{
		return null;
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0x273CBC8", Offset = "0x273CBC8", VA = "0x273CBC8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0x273D534", Offset = "0x273D534", VA = "0x273D534")]
	protected RequestSlot GetSlotForRequest(RequestType _requestType)
	{
		return null;
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0x273D77C", Offset = "0x273D77C", VA = "0x273D77C")]
	protected bool CheckIfBeer(Beer beer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x273DF70", Offset = "0x273DF70", VA = "0x273DF70")]
	private bool CheckIfHamburger(RequestSlot _slot, MealPart _botBun)
	{
		return default(bool);
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x273E51C", Offset = "0x273E51C", VA = "0x273E51C")]
	private bool CheckIfSnag(RequestSlot _slot, MealPart _bread)
	{
		return default(bool);
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0x273E1B8", Offset = "0x273E1B8", VA = "0x273E1B8")]
	private bool CheckIfSkewers(RequestSlot _slot, MealPart _skewerMealPart)
	{
		return default(bool);
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x273D99C", Offset = "0x273D99C", VA = "0x273D99C")]
	protected void Success(GameObject _requestedObject, RequestSlot _slot, bool _isDrink = false)
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x273DED4", Offset = "0x273DED4", VA = "0x273DED4")]
	protected void Fail(GameObject _requestedObject)
	{
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x273E6C0", Offset = "0x273E6C0", VA = "0x273E6C0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B2B70", Offset = "0x9B2B70")]
	private IEnumerator ThrowAway(HVRGrabbable _grabbable)
	{
		return null;
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x273E738", Offset = "0x273E738", VA = "0x273E738")]
	public void SetAllCollidersStatus(GameObject collidersParent, bool active)
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x273E7F4", Offset = "0x273E7F4", VA = "0x273E7F4")]
	public void OverrideRequestList(List<Request> _requests)
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x273D804", Offset = "0x273D804", VA = "0x273D804")]
	private void InstanciateRequestSuccessIcon(Vector3 deliveryPosition, RequestType type, bool success)
	{
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x273EA70", Offset = "0x273EA70", VA = "0x273EA70")]
	public RequestHandler()
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x273EA80", Offset = "0x273EA80", VA = "0x273EA80")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B2BD0", Offset = "0x9B2BD0")]
	private void <Start>b__15_0()
	{
	}
}
[Token(Token = "0x2000081")]
public class RequestSlot : MonoBehaviour
{
	[Token(Token = "0x2000082")]
	public enum InteractionType
	{
		[Token(Token = "0x40002F0")]
		BeerRequestCan,
		[Token(Token = "0x40002F1")]
		BeerRequestBottle,
		[Token(Token = "0x40002F2")]
		BeerWarm,
		[Token(Token = "0x40002F3")]
		BurgerRequest,
		[Token(Token = "0x40002F4")]
		BurgerRaw,
		[Token(Token = "0x40002F5")]
		BurgerOvercooked,
		[Token(Token = "0x40002F6")]
		BurgerOneSide,
		[Token(Token = "0x40002F7")]
		BurgerPlateMissing,
		[Token(Token = "0x40002F8")]
		SnagRequest,
		[Token(Token = "0x40002F9")]
		SnagDry,
		[Token(Token = "0x40002FA")]
		SnagOvercooked,
		[Token(Token = "0x40002FB")]
		SnagRaw,
		[Token(Token = "0x40002FC")]
		SkewerRequest,
		[Token(Token = "0x40002FD")]
		SkewerComplaint,
		[Token(Token = "0x40002FE")]
		GeneralComplaint,
		[Token(Token = "0x40002FF")]
		Impatience,
		[Token(Token = "0x4000300")]
		Leaving,
		[Token(Token = "0x4000301")]
		Thanks,
		[Token(Token = "0x4000302")]
		WrongOrder,
		[Token(Token = "0x4000303")]
		VegemiteTutorial,
		[Token(Token = "0x4000304")]
		QuokkaTutorial,
		[Token(Token = "0x4000305")]
		BabyrooStoleMyBeer,
		[Token(Token = "0x4000306")]
		ParachuteRoo,
		[Token(Token = "0x4000307")]
		SodaRequestCan,
		[Token(Token = "0x4000308")]
		SodaRequestBottle,
		[Token(Token = "0x4000309")]
		SodaWarm
	}

	[Token(Token = "0x2000083")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE060", Offset = "0x9AE060")]
	private sealed class <RemoveRequest>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RequestSlot <>4__this;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x170000B5")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x228DF58", Offset = "0x228DF58", VA = "0x228DF58", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B6")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x228DFA0", Offset = "0x228DFA0", VA = "0x228DFA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x228DD28", Offset = "0x228DD28", VA = "0x228DD28")]
		[DebuggerHidden]
		public <RemoveRequest>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x228DD54", Offset = "0x228DD54", VA = "0x228DD54", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x228DD58", Offset = "0x228DD58", VA = "0x228DD58", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x228DF60", Offset = "0x228DF60", VA = "0x228DF60", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE070", Offset = "0x9AE070")]
	private sealed class <showStillWaitingInteraction>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float timeToDisplayMessage;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RequestSlot <>4__this;

		[Token(Token = "0x170000B7")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x228E208", Offset = "0x228E208", VA = "0x228E208", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B8")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x228E250", Offset = "0x228E250", VA = "0x228E250", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x228E120", Offset = "0x228E120", VA = "0x228E120")]
		[DebuggerHidden]
		public <showStillWaitingInteraction>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x228E14C", Offset = "0x228E14C", VA = "0x228E14C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x228E150", Offset = "0x228E150", VA = "0x228E150", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x228E210", Offset = "0x228E210", VA = "0x228E210", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE080", Offset = "0x9AE080")]
	private sealed class <hideInteraction>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float _interactionTime;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RequestSlot <>4__this;

		[Token(Token = "0x170000B9")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x228E0D0", Offset = "0x228E0D0", VA = "0x228E0D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BA")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x228E118", Offset = "0x228E118", VA = "0x228E118", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x228DFA8", Offset = "0x228DFA8", VA = "0x228DFA8")]
		[DebuggerHidden]
		public <hideInteraction>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x228DFD4", Offset = "0x228DFD4", VA = "0x228DFD4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x228DFD8", Offset = "0x228DFD8", VA = "0x228DFD8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x228E0D8", Offset = "0x228E0D8", VA = "0x228E0D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioHandler audioHandler;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float deadline;

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float timeLeft;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI timeText;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Renderer counterCircleRenderer;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Material counterCircleMaterial;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float slackTime;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Image _requestIcon;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RequestType requestType;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int slotNumber;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool requestClone;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Canvas requestCloneCanvas;

	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Image requestCloneSprite;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private TextMeshProUGUI requestCloneTimeText;

	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public TextMeshProUGUI interactionTextCanvas;

	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int interactionTime;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Coroutine _runningHideInteractionCoroutine;

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float timeSinceLastCalled;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private bool stopTimer;

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x273EA8C", Offset = "0x273EA8C", VA = "0x273EA8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x273EBE8", Offset = "0x273EBE8", VA = "0x273EBE8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x273ED20", Offset = "0x273ED20", VA = "0x273ED20")]
	private void UpdateTimer()
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x273EEA0", Offset = "0x273EEA0", VA = "0x273EEA0")]
	public void SetupNewRequest(RequestType _requestType, float _deadline, Sprite _icon)
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x273EE34", Offset = "0x273EE34", VA = "0x273EE34")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B2C80", Offset = "0x9B2C80")]
	private IEnumerator RemoveRequest()
	{
		return null;
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x273F2EC", Offset = "0x273F2EC", VA = "0x273F2EC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x273F07C", Offset = "0x273F07C", VA = "0x273F07C")]
	private void showNewRequestInteraction(RequestType _requestType)
	{
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x273F270", Offset = "0x273F270", VA = "0x273F270")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B2CE0", Offset = "0x9B2CE0")]
	private IEnumerator showStillWaitingInteraction(float timeToDisplayMessage)
	{
		return null;
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x273DC68", Offset = "0x273DC68", VA = "0x273DC68")]
	public void showInteraction(InteractionType _type, bool showText = true)
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x273F3D0", Offset = "0x273F3D0", VA = "0x273F3D0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B2D40", Offset = "0x9B2D40")]
	private IEnumerator hideInteraction(float _interactionTime)
	{
		return null;
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x273F44C", Offset = "0x273F44C", VA = "0x273F44C")]
	public RequestSlot()
	{
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x273F464", Offset = "0x273F464", VA = "0x273F464")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B2DA0", Offset = "0x9B2DA0")]
	private void <showInteraction>b__28_0(string s)
	{
	}
}
[Token(Token = "0x2000086")]
public class RequestSuccessFailIconDisplay : MonoBehaviour
{
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE090", Offset = "0x9AE090")]
	private sealed class <FadeOut>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RequestSuccessFailIconDisplay <>4__this;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForFixedUpdate <wait>5__2;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <time>5__3;

		[Token(Token = "0x170000BB")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0x228E428", Offset = "0x228E428", VA = "0x228E428", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BC")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x228E470", Offset = "0x228E470", VA = "0x228E470", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x228E258", Offset = "0x228E258", VA = "0x228E258")]
		[DebuggerHidden]
		public <FadeOut>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x228E284", Offset = "0x228E284", VA = "0x228E284", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x228E288", Offset = "0x228E288", VA = "0x228E288", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x228E430", Offset = "0x228E430", VA = "0x228E430", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CanvasGroup canvasGroup;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image requestIcon;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject successIcon;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject failIcon;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float fadeTime;

	[Token(Token = "0x6000382")]
	[Address(RVA = "0x273E9FC", Offset = "0x273E9FC", VA = "0x273E9FC")]
	public void DisplayRequest(Sprite icon, bool success)
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x273F504", Offset = "0x273F504", VA = "0x273F504")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B2EA0", Offset = "0x9B2EA0")]
	private IEnumerator FadeOut()
	{
		return null;
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x273F570", Offset = "0x273F570", VA = "0x273F570")]
	public RequestSuccessFailIconDisplay()
	{
	}
}
[Token(Token = "0x2000088")]
public class SauceBehaviour : MonoBehaviour
{
	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioHandler audioHandler;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem particleSystem;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private HVRGrabbable grabbable;

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private HVRHandGrabber hand;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool squirting;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool achievementAwarded;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float timeSauceOn;

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x273FBD4", Offset = "0x273FBD4", VA = "0x273FBD4")]
	private void Start()
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x273FD14", Offset = "0x273FD14", VA = "0x273FD14")]
	private void RegisterHandGrab(HVRGrabberBase _grabber, HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x273FE14", Offset = "0x273FE14", VA = "0x273FE14")]
	private void UnregisterHandGrab(HVRGrabberBase _grabber, HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x273FE84", Offset = "0x273FE84", VA = "0x273FE84")]
	private void Update()
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x2740104", Offset = "0x2740104", VA = "0x2740104")]
	public SauceBehaviour()
	{
	}
}
[Token(Token = "0x2000089")]
public class GameManager : Singleton<GameManager>
{
	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE0A0", Offset = "0x9AE0A0")]
	private sealed class <FadeInScreen>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameManager <>4__this;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float delay;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timeout>5__2;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSecondsRealtime <wait>5__3;

		[Token(Token = "0x170000BE")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0xF5875C", Offset = "0xF5875C", VA = "0xF5875C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BF")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0xF587A4", Offset = "0xF587A4", VA = "0xF587A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xF58514", Offset = "0xF58514", VA = "0xF58514")]
		[DebuggerHidden]
		public <FadeInScreen>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xF58540", Offset = "0xF58540", VA = "0xF58540", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xF58544", Offset = "0xF58544", VA = "0xF58544", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xF58764", Offset = "0xF58764", VA = "0xF58764", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE0B0", Offset = "0x9AE0B0")]
	private sealed class <LoadScene>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameManager <>4__this;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string sceneName;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string <currentScene>5__2;

		[Token(Token = "0x170000C0")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0xF58DBC", Offset = "0xF58DBC", VA = "0xF58DBC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C1")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0xF58E04", Offset = "0xF58E04", VA = "0xF58E04", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xF587AC", Offset = "0xF587AC", VA = "0xF587AC")]
		[DebuggerHidden]
		public <LoadScene>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xF587D8", Offset = "0xF587D8", VA = "0xF587D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xF587DC", Offset = "0xF587DC", VA = "0xF587DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xF58DC4", Offset = "0xF58DC4", VA = "0xF58DC4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject playerPrefab;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float fadeSpeed;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public SavedData savedData;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public GameStatistics gameStatistics;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private AussiePlayer aussiePlayer;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private HVRScreenFade screenFader;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public BeerSkin beerSkin;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public HVRTimeManager timeManager;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool pauseBool;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float timeScaleBeforePause;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int arcadeStartWave;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public Events.EventSettingsChanged OnSettingsChange;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public Events.EventEnterNewLevel OnEnterNewLevel;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Events.EventExitLevel OnExitLevel;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[HideInInspector]
	public Events.EventPause OnPause;

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public Events.EventUnPause OnUnPause;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private string mainMenuScenename;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public bool accessOnlineServices;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private AsyncOperation asyncLoad;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private bool pauseWhenUnfocus;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[HideInInspector]
	public Dictionary<string, Texture2D> leaderboardSignatureCache;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	internal ES3Settings saveSettings;

	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	internal bool waitForSaveFile;

	[Token(Token = "0x170000BD")]
	public bool isDemo
	{
		[Token(Token = "0x6000390")]
		[Address(RVA = "0xDE1480", Offset = "0xDE1480", VA = "0xDE1480")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0xDE14D8", Offset = "0xDE14D8", VA = "0xDE14D8", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0xDE2104", Offset = "0xDE2104", VA = "0xDE2104")]
	private void Start()
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0xDE2370", Offset = "0xDE2370", VA = "0xDE2370")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B2F50", Offset = "0x9B2F50")]
	private IEnumerator FadeInScreen(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0xDE23EC", Offset = "0xDE23EC", VA = "0xDE23EC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0xDE25B8", Offset = "0xDE25B8", VA = "0xDE25B8")]
	public void StartGame(string scenename = "SampleScene")
	{
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0xDE265C", Offset = "0xDE265C", VA = "0xDE265C")]
	public void QuitGame()
	{
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0xDE2664", Offset = "0xDE2664", VA = "0xDE2664")]
	public void BackToMenu()
	{
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0xDE25E4", Offset = "0xDE25E4", VA = "0xDE25E4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B2FB0", Offset = "0x9B2FB0")]
	private IEnumerator LoadScene(string sceneName)
	{
		return null;
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0xDE2698", Offset = "0xDE2698", VA = "0xDE2698")]
	public void GetPlayerNeutralForNewScene()
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0xDE27A4", Offset = "0xDE27A4", VA = "0xDE27A4")]
	public void AddLevelStatsToGeneral(GameStatistics _levelData)
	{
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0xDE2FAC", Offset = "0xDE2FAC", VA = "0xDE2FAC")]
	public void AddStarsToLevel(int _stars, int _level, int _levelDuration = 0)
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0xDE3060", Offset = "0xDE3060", VA = "0xDE3060")]
	public void SaveSignature(Texture2D _signature, string _signatureImageSource)
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0xDE3114", Offset = "0xDE3114", VA = "0xDE3114")]
	public int GetArcadeHighscore(ArcadeMode _mode)
	{
		return default(int);
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0xDE3130", Offset = "0xDE3130", VA = "0xDE3130")]
	public int GetArcadeLowestScore(ArcadeMode _mode)
	{
		return default(int);
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0xDE314C", Offset = "0xDE314C", VA = "0xDE314C")]
	public void GetArcadeScoreRank(ArcadeMode _mode, int _score, out List<SavedData.ArcadeScore> tempListScores, out int index)
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0xDE3168", Offset = "0xDE3168", VA = "0xDE3168")]
	public int GetLongestArcadeWaveRun(ArcadeMode _mode)
	{
		return default(int);
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0xDE3184", Offset = "0xDE3184", VA = "0xDE3184")]
	public void SaveArcadeScore(int _score, int _waves, float _timeElapsed, ArcadeMode _mode, [Optional] Texture2D _signature)
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0xDE32EC", Offset = "0xDE32EC", VA = "0xDE32EC")]
	public float GetHeightAdjustment(HeightAdjustmentOption keyword)
	{
		return default(float);
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0xDE3308", Offset = "0xDE3308", VA = "0xDE3308")]
	public void SetHeightAdjustment(HeightAdjustmentOption keyword, float value)
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0xDE333C", Offset = "0xDE333C", VA = "0xDE333C")]
	public void DeleteSavedFiles()
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0xDE3524", Offset = "0xDE3524", VA = "0xDE3524")]
	public void MagicStarsUnlock()
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0xDDF8C8", Offset = "0xDDF8C8", VA = "0xDDF8C8")]
	public void SaveGameData()
	{
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0xDE2F44", Offset = "0xDE2F44", VA = "0xDE2F44")]
	public void SaveGameStats()
	{
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0xDE2694", Offset = "0xDE2694", VA = "0xDE2694")]
	public void SavePlayerPrefs()
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0xDE290C", Offset = "0xDE290C", VA = "0xDE290C")]
	public void AchievementCheck()
	{
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0xDE356C", Offset = "0xDE356C", VA = "0xDE356C")]
	public void FadeScreenToBlack(float _fadeSpeed)
	{
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0xDE1B28", Offset = "0xDE1B28", VA = "0xDE1B28")]
	private void LoadLocalLeaderboardSignatures()
	{
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0xDE24E8", Offset = "0xDE24E8", VA = "0xDE24E8")]
	public void Pause()
	{
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0xDE2558", Offset = "0xDE2558", VA = "0xDE2558")]
	public void Unpause()
	{
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0xDE3590", Offset = "0xDE3590", VA = "0xDE3590")]
	private void OnApplicationFocus(bool focus)
	{
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0xDE1754", Offset = "0xDE1754", VA = "0xDE1754")]
	public void DisableOnlineServices()
	{
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0xDE35A4", Offset = "0xDE35A4", VA = "0xDE35A4")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0xDE18CC", Offset = "0xDE18CC", VA = "0xDE18CC")]
	private void LoadSaveOrCreateNew()
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0xDE35C8", Offset = "0xDE35C8", VA = "0xDE35C8")]
	internal bool LoadSaveFileFromES3()
	{
		return default(bool);
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0xDE3430", Offset = "0xDE3430", VA = "0xDE3430")]
	public void CreateNewSaveData()
	{
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0xDE36C0", Offset = "0xDE36C0", VA = "0xDE36C0")]
	public GameManager()
	{
	}
}
[Token(Token = "0x200008C")]
public class AussieDestructible : HVRDestructible
{
	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE0C0", Offset = "0x9AE0C0")]
	private sealed class <ShortlyUncolidableCoroutine>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AussieDestructible <>4__this;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float _time;

		[Token(Token = "0x170000C2")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0xED8044", Offset = "0xED8044", VA = "0xED8044", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C3")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0xED808C", Offset = "0xED808C", VA = "0xED808C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xED7F28", Offset = "0xED7F28", VA = "0xED7F28")]
		[DebuggerHidden]
		public <ShortlyUncolidableCoroutine>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xED7F54", Offset = "0xED7F54", VA = "0xED7F54", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xED7F58", Offset = "0xED7F58", VA = "0xED7F58", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xED804C", Offset = "0xED804C", VA = "0xED804C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE0D0", Offset = "0x9AE0D0")]
	private sealed class <MakeBottleTemporarilyUnbreakeableCoroutine>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AussieDestructible <>4__this;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <originalForceThrehold>5__2;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <originalVelocityThrehold>5__3;

		[Token(Token = "0x170000C4")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0xED7ED8", Offset = "0xED7ED8", VA = "0xED7ED8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C5")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0xED7F20", Offset = "0xED7F20", VA = "0xED7F20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xED7DA0", Offset = "0xED7DA0", VA = "0xED7DA0")]
		[DebuggerHidden]
		public <MakeBottleTemporarilyUnbreakeableCoroutine>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xED7DCC", Offset = "0xED7DCC", VA = "0xED7DCC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xED7DD0", Offset = "0xED7DD0", VA = "0xED7DD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xED7EE0", Offset = "0xED7EE0", VA = "0xED7EE0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private HVRSocket socket;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float forceToAddToGrabbable;

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool wasDestroyed;

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private HVRGrabbable grabbable;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Collider[] colliders;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private HVRCollisionEvents collisionHandler;

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0xD28C54", Offset = "0xD28C54", VA = "0xD28C54")]
	private void Start()
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0xD28D88", Offset = "0xD28D88", VA = "0xD28D88")]
	private void ShortlyUncolideble(HVRHandGrabber arg0, HVRGrabbable arg1)
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0xD28DBC", Offset = "0xD28DBC", VA = "0xD28DBC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B30B0", Offset = "0x9B30B0")]
	private IEnumerator ShortlyUncolidableCoroutine(float _time)
	{
		return null;
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0xD28E38", Offset = "0xD28E38", VA = "0xD28E38", Slot = "4")]
	public override void Destroy()
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0xD293F8", Offset = "0xD293F8", VA = "0xD293F8")]
	public void SetAllCollidersAsTrigger(bool _active)
	{
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0xD29474", Offset = "0xD29474", VA = "0xD29474")]
	public void MakeBottleTemporarilyUnbreakeable()
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0xD294A0", Offset = "0xD294A0", VA = "0xD294A0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B3110", Offset = "0x9B3110")]
	private IEnumerator MakeBottleTemporarilyUnbreakeableCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0xD2950C", Offset = "0xD2950C", VA = "0xD2950C")]
	public AussieDestructible()
	{
	}
}
[Token(Token = "0x200008F")]
public class Beer : MonoBehaviour
{
	[Token(Token = "0x2000090")]
	public enum BeerType
	{
		[Token(Token = "0x4000367")]
		PrimaryBeers,
		[Token(Token = "0x4000368")]
		SecondaryBeers,
		[Token(Token = "0x4000369")]
		TertiaryBeers
	}

	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE0E0", Offset = "0x9AE0E0")]
	private sealed class <ShortlyUncolidableCoroutine>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Beer <>4__this;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float _time;

		[Token(Token = "0x170000C6")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0xED86E4", Offset = "0xED86E4", VA = "0xED86E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C7")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0xED872C", Offset = "0xED872C", VA = "0xED872C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xED85D0", Offset = "0xED85D0", VA = "0xED85D0")]
		[DebuggerHidden]
		public <ShortlyUncolidableCoroutine>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xED85FC", Offset = "0xED85FC", VA = "0xED85FC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xED8600", Offset = "0xED8600", VA = "0xED8600", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xED86EC", Offset = "0xED86EC", VA = "0xED86EC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE0F0", Offset = "0x9AE0F0")]
	private sealed class <GuideToPlayer>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Beer <>4__this;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForFixedUpdate <waitForFixedUpdate>5__2;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <hasUpdatedColliders>5__3;

		[Token(Token = "0x170000C8")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0xED8580", Offset = "0xED8580", VA = "0xED8580", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C9")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0xED85C8", Offset = "0xED85C8", VA = "0xED85C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xED8214", Offset = "0xED8214", VA = "0xED8214")]
		[DebuggerHidden]
		public <GuideToPlayer>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xED8240", Offset = "0xED8240", VA = "0xED8240", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xED8244", Offset = "0xED8244", VA = "0xED8244", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xED8588", Offset = "0xED8588", VA = "0xED8588", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool upForGrabs;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Enemy enemyGrabbing;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public HVRGrabbable grabbable;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AEF14", Offset = "0x9AEF14")]
	public GameObject BeerStealParticles;

	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Rigidbody rb;

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool isFlying;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Collider[] _colliders;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public BeerType beerType;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Transform playerTransform;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float upForceMultiplier;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float sideForceMultiplier;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AEF4C", Offset = "0x9AEF4C")]
	public BeerSkin beerSkin;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool selectionMenuBeer;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
	private bool lostAlreadySafetyBool;

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0xD2B4AC", Offset = "0xD2B4AC", VA = "0xD2B4AC")]
	private void Start()
	{
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0xD2B5F4", Offset = "0xD2B5F4", VA = "0xD2B5F4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0xD29200", Offset = "0xD29200", VA = "0xD29200")]
	public void LoseBeer()
	{
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0xD2B684", Offset = "0xD2B684", VA = "0xD2B684")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60003D9")]
	[Address(RVA = "0xD2B694", Offset = "0xD2B694", VA = "0xD2B694")]
	private void DropedBeer()
	{
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0xD2B6A0", Offset = "0xD2B6A0", VA = "0xD2B6A0")]
	public void BeerJumpBack(float extraForceMultipler = 1f)
	{
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0xD2BA6C", Offset = "0xD2BA6C", VA = "0xD2BA6C")]
	public void ShortlyUncolidable(float _time)
	{
	}

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0xD2B818", Offset = "0xD2B818", VA = "0xD2B818")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B3210", Offset = "0x9B3210")]
	private IEnumerator ShortlyUncolidableCoroutine(float _time)
	{
		return null;
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0xD2BA00", Offset = "0xD2BA00", VA = "0xD2BA00")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B3270", Offset = "0x9B3270")]
	private IEnumerator GuideToPlayer()
	{
		return null;
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0xD2BA98", Offset = "0xD2BA98", VA = "0xD2BA98")]
	public void SetCollisionDetectionStatus(bool active)
	{
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0xD2BAC8", Offset = "0xD2BAC8", VA = "0xD2BAC8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0xD2B894", Offset = "0xD2B894", VA = "0xD2B894")]
	private Transform GetPlayerTransform()
	{
		return null;
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0xD2B960", Offset = "0xD2B960", VA = "0xD2B960")]
	private Rigidbody GetRigidBody()
	{
		return null;
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0xD2B554", Offset = "0xD2B554", VA = "0xD2B554")]
	private HVRGrabbable GetGrabbable()
	{
		return null;
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0xD2BAD0", Offset = "0xD2BAD0", VA = "0xD2BAD0")]
	public Beer()
	{
	}
}
[Token(Token = "0x2000093")]
public class BeerBox : MonoBehaviour
{
	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool upForGrabs;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public DingoBehaviour enemyGrabbing;

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0xD2BAE0", Offset = "0xD2BAE0", VA = "0xD2BAE0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0xD2BC30", Offset = "0xD2BC30", VA = "0xD2BC30")]
	public BeerBox()
	{
	}
}
[Token(Token = "0x2000094")]
public class BeerCollector : MonoBehaviour
{
	[Token(Token = "0x2000095")]
	public enum BeerType
	{
		[Token(Token = "0x400037B")]
		PrimaryBeers,
		[Token(Token = "0x400037C")]
		SecondaryBeers,
		[Token(Token = "0x400037D")]
		TertiaryBeers
	}

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public HVRSocketContainer socketContainer;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float spitBeerForceMultiplier;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioHandler audioHandler;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject backInTheBoxParticles;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public BeerType beerType;

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0xD2BC40", Offset = "0xD2BC40", VA = "0xD2BC40")]
	public void Start()
	{
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0xD2BC94", Offset = "0xD2BC94", VA = "0xD2BC94")]
	public void ThrowObjectAway(GameObject obj)
	{
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0xD2BDE8", Offset = "0xD2BDE8", VA = "0xD2BDE8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0xD2C0FC", Offset = "0xD2C0FC", VA = "0xD2C0FC")]
	public BeerCollector()
	{
	}
}
[Token(Token = "0x2000096")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x9AE100", Offset = "0x9AE100")]
public class BeerCooling : FoodAction
{
	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE160", Offset = "0x9AE160")]
	private sealed class <WaitThenStartWarming>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BeerCooling <>4__this;

		[Token(Token = "0x170000CA")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000400")]
			[Address(RVA = "0xED881C", Offset = "0xED881C", VA = "0xED881C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CB")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0xED8864", Offset = "0xED8864", VA = "0xED8864", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xED8734", Offset = "0xED8734", VA = "0xED8734")]
		[DebuggerHidden]
		public <WaitThenStartWarming>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xED8760", Offset = "0xED8760", VA = "0xED8760", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xED8764", Offset = "0xED8764", VA = "0xED8764", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xED8824", Offset = "0xED8824", VA = "0xED8824", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private HVRGrabbable grababble;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float timeBeforeStartingToWarmUp;

	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private IEnumerator warmingCoroutine;

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0xD2C110", Offset = "0xD2C110", VA = "0xD2C110", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0xD2C46C", Offset = "0xD2C46C", VA = "0xD2C46C")]
	private void OnGrab(HVRGrabberBase grabberBase, HVRGrabbable obj)
	{
	}

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0xD2C514", Offset = "0xD2C514", VA = "0xD2C514")]
	private void OnRelease(HVRGrabberBase grabberBase, HVRGrabbable obj)
	{
	}

	[Token(Token = "0x60003F9")]
	[Address(RVA = "0xD2C5EC", Offset = "0xD2C5EC", VA = "0xD2C5EC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B3370", Offset = "0x9B3370")]
	public IEnumerator WaitThenStartWarming()
	{
		return null;
	}

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0xD2C658", Offset = "0xD2C658", VA = "0xD2C658", Slot = "6")]
	public override void updateMaterial()
	{
	}

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0xD2C318", Offset = "0xD2C318", VA = "0xD2C318")]
	private void setDisplayMaterials()
	{
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0xD2C6DC", Offset = "0xD2C6DC", VA = "0xD2C6DC")]
	public BeerCooling()
	{
	}
}
[Token(Token = "0x2000098")]
public class BeerPouringHandler : MonoBehaviour
{
	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleSystem beerPouring;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private HVRGrabbable grababble;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioHandler audioHandler;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject cap;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool beerOpen;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AEF94", Offset = "0x9AEF94")]
	[SerializeField]
	private float boomerangSpeedToOpen;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ParticleSystem sprayParticles;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool bottle;

	[Token(Token = "0x6000403")]
	[Address(RVA = "0xD2C6EC", Offset = "0xD2C6EC", VA = "0xD2C6EC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000404")]
	[Address(RVA = "0xD2C740", Offset = "0xD2C740", VA = "0xD2C740")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0xD2C9F4", Offset = "0xD2C9F4", VA = "0xD2C9F4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0xD2CAF4", Offset = "0xD2CAF4", VA = "0xD2CAF4")]
	private void StartPouring()
	{
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0xD2CB58", Offset = "0xD2CB58", VA = "0xD2CB58")]
	private void StopPouring()
	{
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0xD2C930", Offset = "0xD2C930", VA = "0xD2C930")]
	public void BeerOpen(bool _bool)
	{
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0xD2CBBC", Offset = "0xD2CBBC", VA = "0xD2CBBC")]
	public BeerPouringHandler()
	{
	}
}
[Token(Token = "0x2000099")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x9AE170", Offset = "0x9AE170")]
public class BeerSkin : ScriptableObject
{
	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string skinName;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material canNormalMaterial;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material canFrostyMaterial;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material canNormalMaterialNA;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Material canFrostyMaterialNA;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material bottleNormalMaterial;

	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material bottleFrostyMaterial;

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material bottleNormalMaterialNA;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Material bottleFrostyMaterialNA;

	[Token(Token = "0x600040A")]
	[Address(RVA = "0xD2CBC4", Offset = "0xD2CBC4", VA = "0xD2CBC4")]
	public BeerSkin()
	{
	}
}
[Token(Token = "0x200009A")]
public class BeerSkinSelector : MonoBehaviour
{
	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public BeerSkin currentBeerSkin;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int currentBeerSkinIndex;

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject selectionBeerDisplay;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Renderer skinRenderer;

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public HVRSocket socket;

	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject beerbox;

	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public MeshRenderer selectedBeer;

	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject magicGlow;

	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject constantGlow;

	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public AudioHandler socketAudioHandler;

	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<BeerSkin> beerSkins;

	[Token(Token = "0x600040B")]
	[Address(RVA = "0xD2CBCC", Offset = "0xD2CBCC", VA = "0xD2CBCC")]
	private void Start()
	{
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0xD2D070", Offset = "0xD2D070", VA = "0xD2D070")]
	private void setDisplayMaterial()
	{
	}

	[Token(Token = "0x600040D")]
	[Address(RVA = "0xD2D14C", Offset = "0xD2D14C", VA = "0xD2D14C")]
	public void SelectSkin(HVRGrabberBase grabber, HVRGrabbable grabbable)
	{
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0xD2D2CC", Offset = "0xD2D2CC", VA = "0xD2D2CC")]
	private void PlaySelectSkinAnimation(HVRGrabberBase grabber, HVRGrabbable grabbable)
	{
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0xD2D35C", Offset = "0xD2D35C", VA = "0xD2D35C")]
	private void StopSelectSkinAnimation(HVRGrabberBase grabber, HVRGrabbable grabbable)
	{
	}

	[Token(Token = "0x6000410")]
	[Address(RVA = "0xD2D3D8", Offset = "0xD2D3D8", VA = "0xD2D3D8")]
	public BeerSkinSelector()
	{
	}
}
[Token(Token = "0x200009B")]
public class BreadMealPart : MealPart
{
	[Token(Token = "0x40003A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Renderer breadRenderer;

	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private SnagMealPart snagMealPart;

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool vegemited;

	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Texture2D vegemitedTexture;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject particlesObject;

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	private Animator animator;

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Transform cameraTransform;

	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private MeshCollider meshColllider;

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Mesh defaultMesh;

	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Mesh foldedMesh;

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9AEFF4", Offset = "0x9AEFF4")]
	public HVRSocket socket;

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject ketchup;

	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject mustard;

	[Token(Token = "0x6000411")]
	[Address(RVA = "0xD31734", Offset = "0xD31734", VA = "0xD31734", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0xD3192C", Offset = "0xD3192C", VA = "0xD3192C")]
	private void OnSocketGrab(HVRGrabberBase _grabber, HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0xD31A08", Offset = "0xD31A08", VA = "0xD31A08")]
	private void ResetGrabber()
	{
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0xD31AE4", Offset = "0xD31AE4", VA = "0xD31AE4")]
	private void OnSocketRelease(HVRGrabberBase _grabber, HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0xD31B74", Offset = "0xD31B74", VA = "0xD31B74")]
	public void GetVegemited()
	{
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0xD31C4C", Offset = "0xD31C4C", VA = "0xD31C4C")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x6000417")]
	[Address(RVA = "0xD31D3C", Offset = "0xD31D3C", VA = "0xD31D3C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0xD31F64", Offset = "0xD31F64", VA = "0xD31F64")]
	public BreadMealPart()
	{
	}
}
[Token(Token = "0x200009C")]
public class BurgerSide : FoodAction
{
	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public BurgerSide otherSide;

	[Token(Token = "0x6000419")]
	[Address(RVA = "0xD32810", Offset = "0xD32810", VA = "0xD32810", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0xD32900", Offset = "0xD32900", VA = "0xD32900")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0xD329E8", Offset = "0xD329E8", VA = "0xD329E8")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600041C")]
	[Address(RVA = "0xD32AD0", Offset = "0xD32AD0", VA = "0xD32AD0", Slot = "5")]
	public override void DoneStateUpdate(DoneState newDoneState)
	{
	}

	[Token(Token = "0x600041D")]
	[Address(RVA = "0xD32B0C", Offset = "0xD32B0C", VA = "0xD32B0C")]
	public void burnAllBurger()
	{
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0xD32B54", Offset = "0xD32B54", VA = "0xD32B54")]
	public BurgerSide()
	{
	}
}
[Token(Token = "0x200009D")]
public class BurnableFoodAction : FoodAction
{
	[Token(Token = "0x600041F")]
	[Address(RVA = "0xD32B5C", Offset = "0xD32B5C", VA = "0xD32B5C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000420")]
	[Address(RVA = "0xD32C44", Offset = "0xD32C44", VA = "0xD32C44")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000421")]
	[Address(RVA = "0xD32D70", Offset = "0xD32D70", VA = "0xD32D70")]
	public BurnableFoodAction()
	{
	}
}
[Token(Token = "0x200009E")]
public class FoodAction : MonoBehaviour
{
	[Token(Token = "0x200009F")]
	public enum DoneState
	{
		[Token(Token = "0x40003C0")]
		UNDONE,
		[Token(Token = "0x40003C1")]
		DONE,
		[Token(Token = "0x40003C2")]
		OVERDONE
	}

	[Token(Token = "0x20000A0")]
	public enum State
	{
		[Token(Token = "0x40003C4")]
		IDLE,
		[Token(Token = "0x40003C5")]
		DOING,
		[Token(Token = "0x40003C6")]
		UNDOING
	}

	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE1C4", Offset = "0x9AE1C4")]
	private sealed class <Success>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FoodAction <>4__this;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <animationTime>5__2;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject <successIconObject>5__3;

		[Token(Token = "0x170000CC")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000430")]
			[Address(RVA = "0xF584C4", Offset = "0xF584C4", VA = "0xF584C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CD")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000432")]
			[Address(RVA = "0xF5850C", Offset = "0xF5850C", VA = "0xF5850C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xF581B4", Offset = "0xF581B4", VA = "0xF581B4")]
		[DebuggerHidden]
		public <Success>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xF581E0", Offset = "0xF581E0", VA = "0xF581E0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xF581E4", Offset = "0xF581E4", VA = "0xF581E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xF584CC", Offset = "0xF584CC", VA = "0xF584CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000A2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE1D4", Offset = "0x9AE1D4")]
	private sealed class <Overdoing>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FoodAction <>4__this;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SpriteRenderer <warningSpriteRenderer>5__2;

		[Token(Token = "0x170000CE")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000436")]
			[Address(RVA = "0xF58164", Offset = "0xF58164", VA = "0xF58164", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CF")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000438")]
			[Address(RVA = "0xF581AC", Offset = "0xF581AC", VA = "0xF581AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xF57D9C", Offset = "0xF57D9C", VA = "0xF57D9C")]
		[DebuggerHidden]
		public <Overdoing>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xF57DC8", Offset = "0xF57DC8", VA = "0xF57DC8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xF57DCC", Offset = "0xF57DCC", VA = "0xF57DCC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xF5816C", Offset = "0xF5816C", VA = "0xF5816C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject progressBar;

	[Token(Token = "0x40003AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Material progressBarMaterial;

	[Token(Token = "0x40003B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject progressIcon;

	[Token(Token = "0x40003B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject successIcon;

	[Token(Token = "0x40003B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject warningIcon;

	[Token(Token = "0x40003B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material originalMaterial;

	[Token(Token = "0x40003B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material undoneDoneMaterial;

	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material overDoneMaterial;

	[Token(Token = "0x40003B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected AudioHandler audioHandler;

	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Coroutine overdoing;

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject burningParticles;

	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public DoneState doneState;

	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public State state;

	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float timeUntilReady;

	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float timeUntilOverdone;

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float donePercentage;

	[Token(Token = "0x40003BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public bool canBeOverdone;

	[Token(Token = "0x6000422")]
	[Address(RVA = "0xDE0C94", Offset = "0xDE0C94", VA = "0xDE0C94", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000423")]
	[Address(RVA = "0xDE0ED0", Offset = "0xDE0ED0", VA = "0xDE0ED0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0xDE1034", Offset = "0xDE1034", VA = "0xDE1034")]
	public void StateUpdate(State newState)
	{
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0xDE0E18", Offset = "0xDE0E18", VA = "0xDE0E18")]
	private void setProgressBarActive(bool active)
	{
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0xDE124C", Offset = "0xDE124C", VA = "0xDE124C", Slot = "5")]
	public virtual void DoneStateUpdate(DoneState newDoneState)
	{
	}

	[Token(Token = "0x6000427")]
	[Address(RVA = "0xDE131C", Offset = "0xDE131C", VA = "0xDE131C", Slot = "6")]
	public virtual void updateMaterial()
	{
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0xDE12B0", Offset = "0xDE12B0", VA = "0xDE12B0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B3420", Offset = "0x9B3420")]
	private IEnumerator Success()
	{
		return null;
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0xDE10C8", Offset = "0xDE10C8", VA = "0xDE10C8")]
	private void StopOverdoing()
	{
	}

	[Token(Token = "0x600042A")]
	[Address(RVA = "0xDE11E0", Offset = "0xDE11E0", VA = "0xDE11E0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B3480", Offset = "0x9B3480")]
	private IEnumerator Overdoing()
	{
		return null;
	}

	[Token(Token = "0x600042B")]
	[Address(RVA = "0xDE1468", Offset = "0xDE1468", VA = "0xDE1468")]
	protected void SetStateToIdle()
	{
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0xDE1470", Offset = "0xDE1470", VA = "0xDE1470")]
	public FoodAction()
	{
	}
}
[Token(Token = "0x20000A3")]
public class Grill : MonoBehaviour
{
	[Token(Token = "0x6000439")]
	[Address(RVA = "0xDE71EC", Offset = "0xDE71EC", VA = "0xDE71EC")]
	private void Start()
	{
	}

	[Token(Token = "0x600043A")]
	[Address(RVA = "0xDE71F0", Offset = "0xDE71F0", VA = "0xDE71F0")]
	private void Update()
	{
	}

	[Token(Token = "0x600043B")]
	[Address(RVA = "0xDE71F4", Offset = "0xDE71F4", VA = "0xDE71F4")]
	public Grill()
	{
	}
}
[Token(Token = "0x20000A4")]
public class LockedSkinEnabler : MonoBehaviour
{
	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject enoughStarsObject;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject notEnoughStarsObject;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int starsToUnlock;

	[Token(Token = "0x600043C")]
	[Address(RVA = "0xDEF164", Offset = "0xDEF164", VA = "0xDEF164")]
	private void Start()
	{
	}

	[Token(Token = "0x600043D")]
	[Address(RVA = "0xDEF24C", Offset = "0xDEF24C", VA = "0xDEF24C")]
	public LockedSkinEnabler()
	{
	}
}
[Token(Token = "0x20000A5")]
public class MealPart : MonoBehaviour
{
	[Token(Token = "0x20000A6")]
	public enum Part
	{
		[Token(Token = "0x40003D7")]
		Plate,
		[Token(Token = "0x40003D8")]
		BottomBun,
		[Token(Token = "0x40003D9")]
		Hamburger,
		[Token(Token = "0x40003DA")]
		TopBun,
		[Token(Token = "0x40003DB")]
		Skewer,
		[Token(Token = "0x40003DC")]
		Snag,
		[Token(Token = "0x40003DD")]
		Bread,
		[Token(Token = "0x40003DE")]
		Vegemite,
		[Token(Token = "0x40003DF")]
		Shrimp
	}

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool stuck;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Part mealPart;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected HVRGrabbable grabbable;

	[Token(Token = "0x600043E")]
	[Address(RVA = "0x272F930", Offset = "0x272F930", VA = "0x272F930", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0x272FA40", Offset = "0x272FA40", VA = "0x272FA40")]
	private void OnGrabbed(HVRGrabberBase _grabber, HVRGrabbable _grabbabble)
	{
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0x272FACC", Offset = "0x272FACC", VA = "0x272FACC")]
	public MealPart()
	{
	}
}
[Token(Token = "0x20000A7")]
public class PhotoCameraBehaviour : MonoBehaviour
{
	[Token(Token = "0x20000A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE1E4", Offset = "0x9AE1E4")]
	private sealed class <FlashCoroutine>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PhotoCameraBehaviour <>4__this;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <quokasPre>5__2;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <_initialAlpha>5__3;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <_time>5__4;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <flashDecayTime>5__5;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <_alpha>5__6;

		[Token(Token = "0x170000D0")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600044A")]
			[Address(RVA = "0xF6A4F0", Offset = "0xF6A4F0", VA = "0xF6A4F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D1")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0xF6A538", Offset = "0xF6A538", VA = "0xF6A538", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xF69FB0", Offset = "0xF69FB0", VA = "0xF69FB0")]
		[DebuggerHidden]
		public <FlashCoroutine>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xF69FDC", Offset = "0xF69FDC", VA = "0xF69FDC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xF69FE0", Offset = "0xF69FE0", VA = "0xF69FE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xF6A4F8", Offset = "0xF6A4F8", VA = "0xF6A4F8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject flashCone;

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioHandler audioHandler;

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Collider flashCollider;

	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9AF02C", Offset = "0x9AF02C")]
	private Material flashMaterial;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool readyToFlash;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool flashDone;

	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public HVRGrabbable grabbable;

	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public HVRHandGrabber hand;

	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private IEnumerator flash;

	[Token(Token = "0x6000441")]
	[Address(RVA = "0x2735330", Offset = "0x2735330", VA = "0x2735330")]
	private void Start()
	{
	}

	[Token(Token = "0x6000442")]
	[Address(RVA = "0x273557C", Offset = "0x273557C", VA = "0x273557C")]
	private void RegisterHandGrab(HVRGrabberBase _grabber, HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x6000443")]
	[Address(RVA = "0x27355FC", Offset = "0x27355FC", VA = "0x27355FC")]
	private void UnregisterHandGrab(HVRGrabberBase _grabber, HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0x2735608", Offset = "0x2735608", VA = "0x2735608")]
	private void Update()
	{
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0x2735510", Offset = "0x2735510", VA = "0x2735510")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B3580", Offset = "0x9B3580")]
	private IEnumerator FlashCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000446")]
	[Address(RVA = "0x273571C", Offset = "0x273571C", VA = "0x273571C")]
	public PhotoCameraBehaviour()
	{
	}
}
[Token(Token = "0x20000A9")]
public class Radio : MonoBehaviour
{
	[Token(Token = "0x20000AA")]
	public enum Behavior
	{
		[Token(Token = "0x4000404")]
		Default,
		[Token(Token = "0x4000405")]
		Tutorial,
		[Token(Token = "0x4000406")]
		MainMenu,
		[Token(Token = "0x4000407")]
		Filming
	}

	[Token(Token = "0x20000AB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE1F4", Offset = "0x9AE1F4")]
	private sealed class <PlaySound>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Radio <>4__this;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string soundName;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject <particles>5__2;

		[Token(Token = "0x170000D2")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0xF6CFA0", Offset = "0xF6CFA0", VA = "0xF6CFA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D3")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0xF6CFE8", Offset = "0xF6CFE8", VA = "0xF6CFE8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xF6CD3C", Offset = "0xF6CD3C", VA = "0xF6CD3C")]
		[DebuggerHidden]
		public <PlaySound>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xF6CD68", Offset = "0xF6CD68", VA = "0xF6CD68", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xF6CD6C", Offset = "0xF6CD6C", VA = "0xF6CD6C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xF6CFA8", Offset = "0xF6CFA8", VA = "0xF6CFA8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE204", Offset = "0x9AE204")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float waitTimer;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool boomerangCaught;

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xF6C07C", Offset = "0xF6C07C", VA = "0xF6C07C")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xF6C084", Offset = "0xF6C084", VA = "0xF6C084")]
		internal bool <TutorialBehavior>g__WaitForTimeOrCondition|0(bool condition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xF6C0D0", Offset = "0xF6C0D0", VA = "0xF6C0D0")]
		internal bool <TutorialBehavior>b__1()
		{
			return default(bool);
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xF6C1B4", Offset = "0xF6C1B4", VA = "0xF6C1B4")]
		internal void <TutorialBehavior>b__2(Boomerang _)
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xF6C1C0", Offset = "0xF6C1C0", VA = "0xF6C1C0")]
		internal bool <TutorialBehavior>b__3()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000AD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE214", Offset = "0x9AE214")]
	private sealed class <TutorialBehavior>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Radio <>4__this;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private <>c__DisplayClass24_0 <>8__1;

		[Token(Token = "0x170000D4")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000469")]
			[Address(RVA = "0xF6D728", Offset = "0xF6D728", VA = "0xF6D728", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D5")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600046B")]
			[Address(RVA = "0xF6D770", Offset = "0xF6D770", VA = "0xF6D770", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xF6CFF0", Offset = "0xF6CFF0", VA = "0xF6CFF0")]
		[DebuggerHidden]
		public <TutorialBehavior>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xF6D01C", Offset = "0xF6D01C", VA = "0xF6D01C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xF6D020", Offset = "0xF6D020", VA = "0xF6D020", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xF6D730", Offset = "0xF6D730", VA = "0xF6D730", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE224", Offset = "0x9AE224")]
	private sealed class <ObjectivesBehavior>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Radio <>4__this;

		[Token(Token = "0x170000D6")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600046F")]
			[Address(RVA = "0xF6CCEC", Offset = "0xF6CCEC", VA = "0xF6CCEC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D7")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000471")]
			[Address(RVA = "0xF6CD34", Offset = "0xF6CD34", VA = "0xF6CD34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xF6CB3C", Offset = "0xF6CB3C", VA = "0xF6CB3C")]
		[DebuggerHidden]
		public <ObjectivesBehavior>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xF6CB68", Offset = "0xF6CB68", VA = "0xF6CB68", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xF6CB6C", Offset = "0xF6CB6C", VA = "0xF6CB6C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xF6CCF4", Offset = "0xF6CCF4", VA = "0xF6CCF4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000AF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE234", Offset = "0x9AE234")]
	private sealed class <FilmingBehavior>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Radio <>4__this;

		[Token(Token = "0x170000D8")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000475")]
			[Address(RVA = "0xF6CAEC", Offset = "0xF6CAEC", VA = "0xF6CAEC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D9")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000477")]
			[Address(RVA = "0xF6CB34", Offset = "0xF6CB34", VA = "0xF6CB34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xF6C8D8", Offset = "0xF6C8D8", VA = "0xF6C8D8")]
		[DebuggerHidden]
		public <FilmingBehavior>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xF6C904", Offset = "0xF6C904", VA = "0xF6C904", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xF6C908", Offset = "0xF6C908", VA = "0xF6C908", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xF6CAF4", Offset = "0xF6CAF4", VA = "0xF6CAF4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE244", Offset = "0x9AE244")]
	private sealed class <DefaultBehavior>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Radio <>4__this;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float delay;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool playStaticOnStart;

		[Token(Token = "0x170000DA")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600047B")]
			[Address(RVA = "0xF6C888", Offset = "0xF6C888", VA = "0xF6C888", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DB")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600047D")]
			[Address(RVA = "0xF6C8D0", Offset = "0xF6C8D0", VA = "0xF6C8D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xF6C228", Offset = "0xF6C228", VA = "0xF6C228")]
		[DebuggerHidden]
		public <DefaultBehavior>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xF6C254", Offset = "0xF6C254", VA = "0xF6C254", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xF6C258", Offset = "0xF6C258", VA = "0xF6C258", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xF6C890", Offset = "0xF6C890", VA = "0xF6C890", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE254", Offset = "0x9AE254")]
	private sealed class <>c__DisplayClass28_0
	{
		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int n;

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xF6C210", Offset = "0xF6C210", VA = "0xF6C210")]
		public <>c__DisplayClass28_0()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xF6C218", Offset = "0xF6C218", VA = "0xF6C218")]
		internal int <RestartCounters>b__1(int x)
		{
			return default(int);
		}
	}

	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float timeUntilStart;

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float timeBetweenNews;

	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject staticParticles;

	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject playParticles;

	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AudioHandler audioHandler;

	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float minDistanceAudioSources;

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float maxDistanceAudioSources;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int numberOfNewsIntro;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int numberOfNews;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int numberOfNewsOutro;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string playingSound;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<int> newsIntroOrder;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<int> newsOrder;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private List<int> newsOutroOrder;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int newsIntroCounter;

	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int newsCounter;

	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int newsOutroCounter;

	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public Behavior startBehavior;

	[Token(Token = "0x600044D")]
	[Address(RVA = "0x273B728", Offset = "0x273B728", VA = "0x273B728")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0x273B9C8", Offset = "0x273B9C8", VA = "0x273B9C8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x273BA90", Offset = "0x273BA90", VA = "0x273BA90")]
	private void Start()
	{
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0x273BA94", Offset = "0x273BA94", VA = "0x273BA94")]
	private void UpdateSourcesMinMaxDistances()
	{
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0x273BB34", Offset = "0x273BB34", VA = "0x273BB34")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B3630", Offset = "0x9B3630")]
	private IEnumerator PlaySound(string soundName)
	{
		return null;
	}

	[Token(Token = "0x6000452")]
	[Address(RVA = "0x273B7F4", Offset = "0x273B7F4", VA = "0x273B7F4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B3690", Offset = "0x9B3690")]
	private IEnumerator TutorialBehavior()
	{
		return null;
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0x273B860", Offset = "0x273B860", VA = "0x273B860")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B36F0", Offset = "0x9B36F0")]
	private IEnumerator ObjectivesBehavior()
	{
		return null;
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0x273B8CC", Offset = "0x273B8CC", VA = "0x273B8CC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B3750", Offset = "0x9B3750")]
	private IEnumerator FilmingBehavior()
	{
		return null;
	}

	[Token(Token = "0x6000455")]
	[Address(RVA = "0x273B938", Offset = "0x273B938", VA = "0x273B938")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B37B0", Offset = "0x9B37B0")]
	private IEnumerator DefaultBehavior(float delay, bool playStaticOnStart = false)
	{
		return null;
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0x273B7A4", Offset = "0x273B7A4", VA = "0x273B7A4")]
	private void RestartCounters()
	{
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0x273B9CC", Offset = "0x273B9CC", VA = "0x273B9CC")]
	public void StopRadio()
	{
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0x273BCC4", Offset = "0x273BCC4", VA = "0x273BCC4")]
	public void RestartRadio()
	{
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0x273BCF8", Offset = "0x273BCF8", VA = "0x273BCF8")]
	public Radio()
	{
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0x273BBAC", Offset = "0x273BBAC", VA = "0x273BBAC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B3810", Offset = "0x9B3810")]
	internal static List<int> <RestartCounters>g__GetRandomOrder|28_0(int n)
	{
		return null;
	}
}
[Token(Token = "0x20000B2")]
public class ShrimpFoodAction : FoodAction
{
	[Token(Token = "0x20000B3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE264", Offset = "0x9AE264")]
	private sealed class <LockAfterWaiting>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ShrimpFoodAction <>4__this;

		[Token(Token = "0x170000DC")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600048F")]
			[Address(RVA = "0x228F4F8", Offset = "0x228F4F8", VA = "0x228F4F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DD")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x228F540", Offset = "0x228F540", VA = "0x228F540", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x228F420", Offset = "0x228F420", VA = "0x228F420")]
		[DebuggerHidden]
		public <LockAfterWaiting>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x228F44C", Offset = "0x228F44C", VA = "0x228F44C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x228F450", Offset = "0x228F450", VA = "0x228F450", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x228F500", Offset = "0x228F500", VA = "0x228F500", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private HVRStabbable stababble;

	[Token(Token = "0x4000420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private HVRGrabbable grabbable;

	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private HVRStabber stabber;

	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Rigidbody rb;

	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Collider[] _colliders;

	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private int layerDefault;

	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private int layerDontCollideWithPlayer;

	[Token(Token = "0x6000480")]
	[Address(RVA = "0x27414FC", Offset = "0x27414FC", VA = "0x27414FC", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0x2741824", Offset = "0x2741824", VA = "0x2741824")]
	private void Lock()
	{
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x2741A00", Offset = "0x2741A00", VA = "0x2741A00")]
	private void Lock(HVRGrabberBase arg0, HVRGrabbable arg1)
	{
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x2741A04", Offset = "0x2741A04", VA = "0x2741A04")]
	private void OnStab(HVRStabber arg0, HVRStabbable arg1, Collision arg2)
	{
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0x2741BFC", Offset = "0x2741BFC", VA = "0x2741BFC")]
	private void OnUnstab(HVRStabber arg0, HVRStabbable arg1)
	{
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0x2741B90", Offset = "0x2741B90", VA = "0x2741B90")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B39B0", Offset = "0x9B39B0")]
	private IEnumerator LockAfterWaiting()
	{
		return null;
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0x2741C08", Offset = "0x2741C08", VA = "0x2741C08")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000487")]
	[Address(RVA = "0x2741CF4", Offset = "0x2741CF4", VA = "0x2741CF4")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000488")]
	[Address(RVA = "0x2741DE0", Offset = "0x2741DE0", VA = "0x2741DE0")]
	public void SetCollisionDetection(bool active)
	{
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0x2741E00", Offset = "0x2741E00", VA = "0x2741E00")]
	public Collider[] GetColliders()
	{
		return null;
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0x2741A64", Offset = "0x2741A64", VA = "0x2741A64")]
	private void ToggleCollisionLayer(bool collideWithPlayer)
	{
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0x2741E5C", Offset = "0x2741E5C", VA = "0x2741E5C")]
	public ShrimpFoodAction()
	{
	}
}
[Token(Token = "0x20000B4")]
public class SnagFoodAction : FoodAction
{
	[Token(Token = "0x6000492")]
	[Address(RVA = "0x2742250", Offset = "0x2742250", VA = "0x2742250", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000493")]
	[Address(RVA = "0x2742340", Offset = "0x2742340", VA = "0x2742340")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000494")]
	[Address(RVA = "0x274242C", Offset = "0x274242C", VA = "0x274242C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000495")]
	[Address(RVA = "0x2742518", Offset = "0x2742518", VA = "0x2742518")]
	public SnagFoodAction()
	{
	}
}
[Token(Token = "0x20000B5")]
public class SnagMealPart : MealPart
{
	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject ketchup;

	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject mustard;

	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool isKetchuped;

	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool isMustarded;

	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private AudioHandler audioHandler;

	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public CapsuleCollider snagCollider;

	[Token(Token = "0x6000496")]
	[Address(RVA = "0x2742520", Offset = "0x2742520", VA = "0x2742520")]
	private new void Start()
	{
	}

	[Token(Token = "0x6000497")]
	[Address(RVA = "0x274257C", Offset = "0x274257C", VA = "0x274257C")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0x274267C", Offset = "0x274267C", VA = "0x274267C")]
	public void ShortenSnagColider()
	{
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0x27426BC", Offset = "0x27426BC", VA = "0x27426BC")]
	public void RestoreSnagCollider()
	{
	}

	[Token(Token = "0x600049A")]
	[Address(RVA = "0x2742700", Offset = "0x2742700", VA = "0x2742700")]
	public SnagMealPart()
	{
	}
}
[Token(Token = "0x20000B6")]
public class SpawnWhenHit : MonoBehaviour
{
	[Token(Token = "0x20000B7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE274", Offset = "0x9AE274")]
	private sealed class <InstantiateWithModeration>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpawnWhenHit <>4__this;

		[Token(Token = "0x170000DE")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x228F958", Offset = "0x228F958", VA = "0x228F958", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DF")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x228F9A0", Offset = "0x228F9A0", VA = "0x228F9A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x228F768", Offset = "0x228F768", VA = "0x228F768")]
		[DebuggerHidden]
		public <InstantiateWithModeration>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x228F794", Offset = "0x228F794", VA = "0x228F794", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x228F798", Offset = "0x228F798", VA = "0x228F798", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x228F960", Offset = "0x228F960", VA = "0x228F960", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform pointToSpawn;

	[Token(Token = "0x4000430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject vegetarianOption;

	[Token(Token = "0x4000431")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject meatOption;

	[Token(Token = "0x4000432")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject objectToSpawn;

	[Token(Token = "0x4000433")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int maxObjects;

	[Token(Token = "0x4000434")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<GameObject> objectList;

	[Token(Token = "0x4000435")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool readyToInstantiate;

	[Token(Token = "0x600049B")]
	[Address(RVA = "0x2742760", Offset = "0x2742760", VA = "0x2742760")]
	private void Start()
	{
	}

	[Token(Token = "0x600049C")]
	[Address(RVA = "0x2742808", Offset = "0x2742808", VA = "0x2742808")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600049D")]
	[Address(RVA = "0x27428D8", Offset = "0x27428D8", VA = "0x27428D8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B3A60", Offset = "0x9B3A60")]
	private IEnumerator InstantiateWithModeration()
	{
		return null;
	}

	[Token(Token = "0x600049E")]
	[Address(RVA = "0x2742944", Offset = "0x2742944", VA = "0x2742944")]
	private void DestroyFunction(GameObject _objectToDestroy)
	{
	}

	[Token(Token = "0x600049F")]
	[Address(RVA = "0x27429A8", Offset = "0x27429A8", VA = "0x27429A8")]
	public SpawnWhenHit()
	{
	}
}
[Token(Token = "0x20000B8")]
public class StickStabChecker : MonoBehaviour
{
	[Token(Token = "0x20000B9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE284", Offset = "0x9AE284")]
	private sealed class <DelayedGoToHell>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x170000E0")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x228FB50", Offset = "0x228FB50", VA = "0x228FB50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E1")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x228FB98", Offset = "0x228FB98", VA = "0x228FB98", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x228F9A8", Offset = "0x228F9A8", VA = "0x228F9A8")]
		[DebuggerHidden]
		public <DelayedGoToHell>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x228F9D4", Offset = "0x228F9D4", VA = "0x228F9D4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x228F9D8", Offset = "0x228F9D8", VA = "0x228F9D8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x228FB58", Offset = "0x228FB58", VA = "0x228FB58", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000439")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public HVRStabber stabber;

	[Token(Token = "0x60004A6")]
	[Address(RVA = "0x2742DF4", Offset = "0x2742DF4", VA = "0x2742DF4")]
	private void Start()
	{
	}

	[Token(Token = "0x60004A7")]
	[Address(RVA = "0x2742ED8", Offset = "0x2742ED8", VA = "0x2742ED8")]
	private void CheckStab(HVRStabber arg0, HVRStabbable _stabbable, Collision arg2)
	{
	}

	[Token(Token = "0x60004A8")]
	[Address(RVA = "0x274310C", Offset = "0x274310C", VA = "0x274310C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B3B10", Offset = "0x9B3B10")]
	private IEnumerator DelayedGoToHell()
	{
		return null;
	}

	[Token(Token = "0x60004A9")]
	[Address(RVA = "0x2743168", Offset = "0x2743168", VA = "0x2743168")]
	public StickStabChecker()
	{
	}
}
[Token(Token = "0x20000BA")]
public class TreeBehaviour : MonoBehaviour
{
	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioHandler audioHandler;

	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject LeftParticles;

	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x2744D54", Offset = "0x2744D54", VA = "0x2744D54")]
	private void Start()
	{
	}

	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x2744DA8", Offset = "0x2744DA8", VA = "0x2744DA8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60004B2")]
	[Address(RVA = "0x2744FB8", Offset = "0x2744FB8", VA = "0x2744FB8")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60004B3")]
	[Address(RVA = "0x2744E38", Offset = "0x2744E38", VA = "0x2744E38")]
	private void EmitLeaves(Transform _transform)
	{
	}

	[Token(Token = "0x60004B4")]
	[Address(RVA = "0x2745048", Offset = "0x2745048", VA = "0x2745048")]
	public TreeBehaviour()
	{
	}
}
[Token(Token = "0x20000BB")]
public class AchievementsHandler : Singleton<AchievementsHandler>
{
	[Token(Token = "0x60004B5")]
	[Address(RVA = "0xD228A4", Offset = "0xD228A4", VA = "0xD228A4", Slot = "6")]
	public virtual void AwardAchievement(string achievementID)
	{
	}

	[Token(Token = "0x60004B6")]
	[Address(RVA = "0xD2294C", Offset = "0xD2294C", VA = "0xD2294C")]
	public AchievementsHandler()
	{
	}
}
[Token(Token = "0x20000BC")]
public class Leaderboard : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000BD")]
	public class Score
	{
		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string playerName;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D playerSignature;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int score;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int rank;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isCurrentPlayer;

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xF63610", Offset = "0xF63610", VA = "0xF63610")]
		public Score(string _playerName, int _score, int _rank = 0, bool _isCurrentPlayer = false, [Optional] Texture2D _playerSignature)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20000BE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE294", Offset = "0x9AE294")]
	private sealed class <>c
	{
		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<Score> <>9__6_0;

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xF635DC", Offset = "0xF635DC", VA = "0xF635DC")]
		public <>c()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xF635E4", Offset = "0xF635E4", VA = "0xF635E4")]
		internal int <OrderAndFillIn>b__6_0(Score a, Score b)
		{
			return default(int);
		}
	}

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public ScorePlace[] scorePlaces;

	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ScoreType scoreType;

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Score> display_scores;

	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Animator animator;

	[Token(Token = "0x60004B7")]
	[Address(RVA = "0xDEB064", Offset = "0xDEB064", VA = "0xDEB064", Slot = "4")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x60004B8")]
	[Address(RVA = "0xDEB1CC", Offset = "0xDEB1CC", VA = "0xDEB1CC")]
	public void OrderAndFillIn(List<Score> scores)
	{
	}

	[Token(Token = "0x60004B9")]
	[Address(RVA = "0xDEB650", Offset = "0xDEB650", VA = "0xDEB650", Slot = "5")]
	public virtual void ClearLeaderboard()
	{
	}

	[Token(Token = "0x60004BA")]
	[Address(RVA = "0xDEB304", Offset = "0xDEB304", VA = "0xDEB304")]
	public void FillIn(List<Score> scores)
	{
	}

	[Token(Token = "0x60004BB")]
	[Address(RVA = "0xDEB76C", Offset = "0xDEB76C", VA = "0xDEB76C")]
	private string FormatScore(int _score)
	{
		return null;
	}

	[Token(Token = "0x60004BC")]
	[Address(RVA = "0xDEB088", Offset = "0xDEB088", VA = "0xDEB088")]
	public Animator GetAnimator()
	{
		return null;
	}

	[Token(Token = "0x60004BD")]
	[Address(RVA = "0xDEB168", Offset = "0xDEB168", VA = "0xDEB168")]
	public ScorePlace[] GetScorePlaces()
	{
		return null;
	}

	[Token(Token = "0x60004BE")]
	[Address(RVA = "0xDEB834", Offset = "0xDEB834", VA = "0xDEB834")]
	public Leaderboard()
	{
	}
}
[Token(Token = "0x20000BF")]
public class LocalLeaderboard : Leaderboard
{
	[Token(Token = "0x20000C0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE2A4", Offset = "0x9AE2A4")]
	private sealed class <WaitGettingScoresAgain>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocalLeaderboard <>4__this;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ArcadeMode _mode;

		[Token(Token = "0x170000E2")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0xF65EE4", Offset = "0xF65EE4", VA = "0xF65EE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E3")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0xF65F2C", Offset = "0xF65F2C", VA = "0xF65F2C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xF65D10", Offset = "0xF65D10", VA = "0xF65D10")]
		[DebuggerHidden]
		public <WaitGettingScoresAgain>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xF65D3C", Offset = "0xF65D3C", VA = "0xF65D3C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xF65D40", Offset = "0xF65D40", VA = "0xF65D40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xF65EEC", Offset = "0xF65EEC", VA = "0xF65EEC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<ArcadeMode, List<Score>> arcadeScoresCache;

	[Token(Token = "0x400044A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int retryCount;

	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int maxRetries;

	[Token(Token = "0x60004C3")]
	[Address(RVA = "0xDEDCE8", Offset = "0xDEDCE8", VA = "0xDEDCE8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004C4")]
	[Address(RVA = "0xDEDCEC", Offset = "0xDEDCEC", VA = "0xDEDCEC")]
	public void Setup()
	{
	}

	[Token(Token = "0x60004C5")]
	[Address(RVA = "0xDEDE58", Offset = "0xDEDE58", VA = "0xDEDE58")]
	private List<Score> TranslateIntoLeaderboardScores(List<SavedData.ArcadeScore> savedScores)
	{
		return null;
	}

	[Token(Token = "0x60004C6")]
	[Address(RVA = "0xDEE1B8", Offset = "0xDEE1B8", VA = "0xDEE1B8")]
	public void ChangeLeaderboardMode(ArcadeMode _mode)
	{
	}

	[Token(Token = "0x60004C7")]
	[Address(RVA = "0xDEE340", Offset = "0xDEE340", VA = "0xDEE340")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B3BC0", Offset = "0x9B3BC0")]
	private IEnumerator WaitGettingScoresAgain(ArcadeMode _mode)
	{
		return null;
	}

	[Token(Token = "0x60004C8")]
	[Address(RVA = "0xDEE3BC", Offset = "0xDEE3BC", VA = "0xDEE3BC")]
	public bool TemporarilyAddNewScore(ArcadeMode _mode, int _score)
	{
		return default(bool);
	}

	[Token(Token = "0x60004C9")]
	[Address(RVA = "0xDEE548", Offset = "0xDEE548", VA = "0xDEE548")]
	public LocalLeaderboard()
	{
	}
}
[Token(Token = "0x20000C1")]
public class OculusAchievementsHandler : AchievementsHandler
{
	[Token(Token = "0x20000C2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE2B4", Offset = "0x9AE2B4")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string achievementID;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public OculusAchievementsHandler <>4__this;

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xF69020", Offset = "0xF69020", VA = "0xF69020")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xF69028", Offset = "0xF69028", VA = "0xF69028")]
		internal void <UnlockAchievement>b__0(Oculus.Platform.Message<Oculus.Platform.Models.AchievementUpdate> msg)
		{
		}
	}

	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int maxRetryCounts;

	[Token(Token = "0x4000451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<string, int> achivementRetries;

	[Token(Token = "0x4000452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<string> backupAchievementQueue;

	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private HashSet<string> achivementsAwarded;

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x2732CE4", Offset = "0x2732CE4", VA = "0x2732CE4", Slot = "6")]
	public override void AwardAchievement(string achievementID)
	{
	}

	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x2732CE8", Offset = "0x2732CE8", VA = "0x2732CE8")]
	private void UnlockAchievement(string achievementID)
	{
	}

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x2732E9C", Offset = "0x2732E9C", VA = "0x2732E9C")]
	public OculusAchievementsHandler()
	{
	}
}
[Token(Token = "0x20000C3")]
public class OculusInitializer : Singleton<OculusInitializer>
{
	[Token(Token = "0x4000456")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool initialized;

	[Token(Token = "0x4000457")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool error;

	[Token(Token = "0x4000458")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ulong userID;

	[Token(Token = "0x60004D5")]
	[Address(RVA = "0x2732F9C", Offset = "0x2732F9C", VA = "0x2732F9C")]
	private void Start()
	{
	}

	[Token(Token = "0x60004D6")]
	[Address(RVA = "0x2733240", Offset = "0x2733240", VA = "0x2733240")]
	private void InitializeCallback(Oculus.Platform.Message msg)
	{
	}

	[Token(Token = "0x60004D7")]
	[Address(RVA = "0x2733398", Offset = "0x2733398", VA = "0x2733398")]
	private void EntitlementCallback(Oculus.Platform.Message msg)
	{
	}

	[Token(Token = "0x60004D8")]
	[Address(RVA = "0x27334DC", Offset = "0x27334DC", VA = "0x27334DC")]
	private void SetUserID(Oculus.Platform.Message<Oculus.Platform.Models.User> msg)
	{
	}

	[Token(Token = "0x60004D9")]
	[Address(RVA = "0x2733128", Offset = "0x2733128", VA = "0x2733128")]
	private void QuitApplication([Optional] UnityException e)
	{
	}

	[Token(Token = "0x60004DA")]
	[Address(RVA = "0x27335F8", Offset = "0x27335F8", VA = "0x27335F8")]
	public OculusInitializer()
	{
	}
}
[Token(Token = "0x20000C4")]
public class OculusOnlineLeaderboardHandler : OnlineLeaderboardHandler
{
	[Token(Token = "0x20000C5")]
	public class OculusLeaderboard
	{
		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string leaderboardName;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Events.EventLeaderboardUpdated updateEvent;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private OnlineLeaderboardType rankType;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int scoreCount;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ulong UserId;

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xF69780", Offset = "0xF69780", VA = "0xF69780")]
		public OculusLeaderboard(string _name, Events.EventLeaderboardUpdated _event, ulong _userID)
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xF695E0", Offset = "0xF695E0", VA = "0xF695E0")]
		public void GetLeaderboardData(OnlineLeaderboardType _method = OnlineLeaderboardType.NONE)
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xF697C8", Offset = "0xF697C8", VA = "0xF697C8")]
		public void GetLeaderboardDataCallback(Oculus.Platform.Message<Oculus.Platform.Models.LeaderboardEntryList> msg)
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xF69C2C", Offset = "0xF69C2C", VA = "0xF69C2C", Slot = "4")]
		public virtual void SubmitScore(int _score)
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xF69D20", Offset = "0xF69D20", VA = "0xF69D20")]
		public void OnSubmitScore(Oculus.Platform.Message<bool> msg)
		{
		}
	}

	[Token(Token = "0x20000C6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE2C4", Offset = "0x9AE2C4")]
	private sealed class <WaitAndDownloadLeaderboard>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string key;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OculusOnlineLeaderboardHandler <>4__this;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public OnlineLeaderboardType method;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <max_tries>5__2;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <current_try>5__3;

		[Token(Token = "0x170000E4")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0xF69730", Offset = "0xF69730", VA = "0xF69730", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E5")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0xF69778", Offset = "0xF69778", VA = "0xF69778", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xF692C4", Offset = "0xF692C4", VA = "0xF692C4")]
		[DebuggerHidden]
		public <WaitAndDownloadLeaderboard>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xF692F0", Offset = "0xF692F0", VA = "0xF692F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xF692F4", Offset = "0xF692F4", VA = "0xF692F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xF69738", Offset = "0xF69738", VA = "0xF69738", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000C7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE2D4", Offset = "0x9AE2D4")]
	private sealed class <RetrySubmitScore>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OculusOnlineLeaderboardHandler <>4__this;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string key;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int score;

		[Token(Token = "0x170000E6")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0xF69274", Offset = "0xF69274", VA = "0xF69274", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E7")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0xF692BC", Offset = "0xF692BC", VA = "0xF692BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xF69184", Offset = "0xF69184", VA = "0xF69184")]
		[DebuggerHidden]
		public <RetrySubmitScore>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xF691B0", Offset = "0xF691B0", VA = "0xF691B0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xF691B4", Offset = "0xF691B4", VA = "0xF691B4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xF6927C", Offset = "0xF6927C", VA = "0xF6927C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000459")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Dictionary<string, OculusLeaderboard> leaderboards;

	[Token(Token = "0x400045A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int retryAttempts;

	[Token(Token = "0x400045B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool error;

	[Token(Token = "0x60004DB")]
	[Address(RVA = "0x2733644", Offset = "0x2733644", VA = "0x2733644", Slot = "6")]
	public override void Start()
	{
	}

	[Token(Token = "0x60004DC")]
	[Address(RVA = "0x2733CC0", Offset = "0x2733CC0", VA = "0x2733CC0", Slot = "7")]
	public override void UpdateLeaderboard(string key, OnlineLeaderboardType method)
	{
	}

	[Token(Token = "0x60004DD")]
	[Address(RVA = "0x2733CEC", Offset = "0x2733CEC", VA = "0x2733CEC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B3C70", Offset = "0x9B3C70")]
	private IEnumerator WaitAndDownloadLeaderboard(string key, OnlineLeaderboardType method)
	{
		return null;
	}

	[Token(Token = "0x60004DE")]
	[Address(RVA = "0x2733D6C", Offset = "0x2733D6C", VA = "0x2733D6C", Slot = "9")]
	public override void SubmitScore(string key, int score)
	{
	}

	[Token(Token = "0x60004DF")]
	[Address(RVA = "0x2733F14", Offset = "0x2733F14", VA = "0x2733F14")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B3CD0", Offset = "0x9B3CD0")]
	private IEnumerator RetrySubmitScore(string key, int score)
	{
		return null;
	}

	[Token(Token = "0x60004E0")]
	[Address(RVA = "0x2733F94", Offset = "0x2733F94", VA = "0x2733F94")]
	public OculusOnlineLeaderboardHandler()
	{
	}
}
[Token(Token = "0x20000C8")]
public class OnlineLeaderboard : Leaderboard
{
	[Token(Token = "0x400046D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<string> leaderboardKeys;

	[Token(Token = "0x400046E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int rankTypeIndex;

	[Token(Token = "0x400046F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public OnlineLeaderboardType[] availableTypes;

	[Token(Token = "0x4000470")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Sprite[] rankIcons;

	[Token(Token = "0x4000471")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string currentKey;

	[Token(Token = "0x4000472")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Image rankTypeIcon;

	[Token(Token = "0x4000473")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool setEvents;

	[Token(Token = "0x60004F2")]
	[Address(RVA = "0x27340B8", Offset = "0x27340B8", VA = "0x27340B8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004F3")]
	[Address(RVA = "0x2734140", Offset = "0x2734140", VA = "0x2734140")]
	public void UpdateLeaderboard(List<Score> _scores)
	{
	}

	[Token(Token = "0x60004F4")]
	[Address(RVA = "0x27341D4", Offset = "0x27341D4", VA = "0x27341D4")]
	public void UpdateLeaderboardMode(string key)
	{
	}

	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x273480C", Offset = "0x273480C", VA = "0x273480C")]
	public void ToggleLeaderboardListType()
	{
	}

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x273440C", Offset = "0x273440C", VA = "0x273440C")]
	public void EnableLeaderboard()
	{
	}

	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x27343B4", Offset = "0x27343B4", VA = "0x27343B4")]
	public void DisableLeaderboard()
	{
	}

	[Token(Token = "0x60004F8")]
	[Address(RVA = "0x2734464", Offset = "0x2734464", VA = "0x2734464")]
	private void SetEvents()
	{
	}

	[Token(Token = "0x60004F9")]
	[Address(RVA = "0x2734968", Offset = "0x2734968", VA = "0x2734968")]
	public OnlineLeaderboard()
	{
	}
}
[Token(Token = "0x20000C9")]
public class OnlineLeaderboardHandler : Singleton<OnlineLeaderboardHandler>
{
	[Token(Token = "0x4000474")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public string DEFENSE_LEADERBOARD_NAME;

	[Token(Token = "0x4000475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public string COOKING_LEADERBOARD_NAME;

	[Token(Token = "0x4000476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public string FASTEST_LEVEL_LEADERBOARD_NAME;

	[Token(Token = "0x4000477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Dictionary<string, string> leaderboardNames;

	[Token(Token = "0x4000478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public Dictionary<string, Events.EventLeaderboardUpdated> leaderboardEvents;

	[Token(Token = "0x60004FA")]
	[Address(RVA = "0x273391C", Offset = "0x273391C", VA = "0x273391C", Slot = "6")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x60004FB")]
	[Address(RVA = "0x27349E8", Offset = "0x27349E8", VA = "0x27349E8", Slot = "7")]
	public virtual void UpdateLeaderboard(string key, OnlineLeaderboardType method)
	{
	}

	[Token(Token = "0x60004FC")]
	[Address(RVA = "0x2734A5C", Offset = "0x2734A5C", VA = "0x2734A5C", Slot = "8")]
	public virtual void UpdateLeaderboard(ArcadeMode mode, OnlineLeaderboardType method)
	{
	}

	[Token(Token = "0x60004FD")]
	[Address(RVA = "0x2734B08", Offset = "0x2734B08", VA = "0x2734B08", Slot = "9")]
	public virtual void SubmitScore(string key, int score)
	{
	}

	[Token(Token = "0x60004FE")]
	[Address(RVA = "0x2734B7C", Offset = "0x2734B7C", VA = "0x2734B7C", Slot = "10")]
	public virtual void SubmitScore(ArcadeMode mode, int score)
	{
	}

	[Token(Token = "0x60004FF")]
	[Address(RVA = "0x2733F98", Offset = "0x2733F98", VA = "0x2733F98")]
	public OnlineLeaderboardHandler()
	{
	}
}
[Token(Token = "0x20000CA")]
public class PicoAchievementsHandler : AchievementsHandler
{
	[Token(Token = "0x20000CB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE2E4", Offset = "0x9AE2E4")]
	private sealed class <WaitAndRetryAwardAchievements>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PicoAchievementsHandler <>4__this;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string achievementID;

		[Token(Token = "0x170000E8")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600050B")]
			[Address(RVA = "0xF6A878", Offset = "0xF6A878", VA = "0xF6A878", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E9")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600050D")]
			[Address(RVA = "0xF6A8C0", Offset = "0xF6A8C0", VA = "0xF6A8C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xF6A79C", Offset = "0xF6A79C", VA = "0xF6A79C")]
		[DebuggerHidden]
		public <WaitAndRetryAwardAchievements>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xF6A7C8", Offset = "0xF6A7C8", VA = "0xF6A7C8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xF6A7CC", Offset = "0xF6A7CC", VA = "0xF6A7CC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xF6A880", Offset = "0xF6A880", VA = "0xF6A880", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000CC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE2F4", Offset = "0x9AE2F4")]
	private sealed class <WaitAndAwardBackUpQueuedAchievements>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PicoAchievementsHandler <>4__this;

		[Token(Token = "0x170000EA")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000511")]
			[Address(RVA = "0xF6A74C", Offset = "0xF6A74C", VA = "0xF6A74C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EB")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000513")]
			[Address(RVA = "0xF6A794", Offset = "0xF6A794", VA = "0xF6A794", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xF6A678", Offset = "0xF6A678", VA = "0xF6A678")]
		[DebuggerHidden]
		public <WaitAndAwardBackUpQueuedAchievements>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xF6A6A4", Offset = "0xF6A6A4", VA = "0xF6A6A4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xF6A6A8", Offset = "0xF6A6A8", VA = "0xF6A6A8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xF6A754", Offset = "0xF6A754", VA = "0xF6A754", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000479")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool canAward;

	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int retryCount;

	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int maxRetryCounts;

	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<string, int> achivementRetries;

	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<string> backupAchievementQueue;

	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private HashSet<string> alreadyAwardedList;

	[Token(Token = "0x6000500")]
	[Address(RVA = "0x27357EC", Offset = "0x27357EC", VA = "0x27357EC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000501")]
	[Address(RVA = "0x2735898", Offset = "0x2735898", VA = "0x2735898", Slot = "6")]
	public override void AwardAchievement(string achievementID)
	{
	}

	[Token(Token = "0x6000502")]
	[Address(RVA = "0x2735A44", Offset = "0x2735A44", VA = "0x2735A44")]
	private void UnlockAchievement(string achievementID)
	{
	}

	[Token(Token = "0x6000503")]
	[Address(RVA = "0x2735C84", Offset = "0x2735C84", VA = "0x2735C84")]
	private void AchievementUnlockedCallback(Pico.Platform.Message<Pico.Platform.Models.AchievementUpdate> msg)
	{
	}

	[Token(Token = "0x6000504")]
	[Address(RVA = "0x27357F0", Offset = "0x27357F0", VA = "0x27357F0")]
	public void AwardBackUpQueuedAchievements()
	{
	}

	[Token(Token = "0x6000505")]
	[Address(RVA = "0x2735C0C", Offset = "0x2735C0C", VA = "0x2735C0C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B3DD0", Offset = "0x9B3DD0")]
	private IEnumerator WaitAndRetryAwardAchievements(string achievementID)
	{
		return null;
	}

	[Token(Token = "0x6000506")]
	[Address(RVA = "0x2735E94", Offset = "0x2735E94", VA = "0x2735E94")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B3E30", Offset = "0x9B3E30")]
	private IEnumerator WaitAndAwardBackUpQueuedAchievements()
	{
		return null;
	}

	[Token(Token = "0x6000507")]
	[Address(RVA = "0x2735F00", Offset = "0x2735F00", VA = "0x2735F00")]
	public PicoAchievementsHandler()
	{
	}
}
[Token(Token = "0x20000CD")]
public class PicoInitializer : Singleton<PicoInitializer>
{
	[Token(Token = "0x4000486")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool initialized;

	[Token(Token = "0x4000487")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool error;

	[Token(Token = "0x4000488")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string userID;

	[Token(Token = "0x4000489")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string appID;

	[Token(Token = "0x400048A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string appSecret;

	[Token(Token = "0x400048B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string appKey;

	[Token(Token = "0x400048C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string accessToken;

	[Token(Token = "0x6000514")]
	[Address(RVA = "0x2735FC8", Offset = "0x2735FC8", VA = "0x2735FC8")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000515")]
	[Address(RVA = "0x27362E0", Offset = "0x27362E0", VA = "0x27362E0")]
	private void InitializeCallback(Pico.Platform.Message<Pico.Platform.PlatformInitializeResult> msg)
	{
	}

	[Token(Token = "0x6000516")]
	[Address(RVA = "0x273654C", Offset = "0x273654C", VA = "0x273654C")]
	private void SetUserID(Pico.Platform.Message<Pico.Platform.Models.User> msg)
	{
	}

	[Token(Token = "0x6000517")]
	[Address(RVA = "0x2736434", Offset = "0x2736434", VA = "0x2736434")]
	private void QuitApplication([Optional] UnityException e)
	{
	}

	[Token(Token = "0x6000518")]
	[Address(RVA = "0x27366D4", Offset = "0x27366D4", VA = "0x27366D4")]
	public PicoInitializer()
	{
	}
}
[Token(Token = "0x20000CE")]
public class PicoOnlineLeaderboardHandler : OnlineLeaderboardHandler
{
	[Token(Token = "0x20000CF")]
	public class PicoLeaderboard
	{
		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string leaderboardName;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Events.EventLeaderboardUpdated updateEvent;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int scoreCount;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool canSubmit;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string currentUserID;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Pico.Platform.LeaderboardStartAt centerType;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Pico.Platform.LeaderboardFilterType filterType;

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xF6AF9C", Offset = "0xF6AF9C", VA = "0xF6AF9C")]
		public PicoLeaderboard(string _name, Events.EventLeaderboardUpdated _event, string _userID = "")
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xF6AD3C", Offset = "0xF6AD3C", VA = "0xF6AD3C")]
		public void DownloadLeaderboardScores(OnlineLeaderboardType method = OnlineLeaderboardType.NONE)
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xF6B064", Offset = "0xF6B064", VA = "0xF6B064")]
		private void OnDownloadLeaderboard(Pico.Platform.Message<Pico.Platform.Models.LeaderboardEntryList> msg)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xF6B418", Offset = "0xF6B418", VA = "0xF6B418")]
		public void SubmitScore(int _score)
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xF6B564", Offset = "0xF6B564", VA = "0xF6B564")]
		private void OnSubmitScore(Pico.Platform.Message<bool> msg)
		{
		}
	}

	[Token(Token = "0x20000D0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE304", Offset = "0x9AE304")]
	private sealed class <WaitAndDownloadLeaderboard>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string key;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PicoOnlineLeaderboardHandler <>4__this;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public OnlineLeaderboardType method;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <max_tries>5__2;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <current_try>5__3;

		[Token(Token = "0x170000EC")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000527")]
			[Address(RVA = "0xF6AF4C", Offset = "0xF6AF4C", VA = "0xF6AF4C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000ED")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0xF6AF94", Offset = "0xF6AF94", VA = "0xF6AF94", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xF6AA08", Offset = "0xF6AA08", VA = "0xF6AA08")]
		[DebuggerHidden]
		public <WaitAndDownloadLeaderboard>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xF6AA34", Offset = "0xF6AA34", VA = "0xF6AA34", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xF6AA38", Offset = "0xF6AA38", VA = "0xF6AA38", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xF6AF54", Offset = "0xF6AF54", VA = "0xF6AF54", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000D1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE314", Offset = "0x9AE314")]
	private sealed class <RetrySubmitScore>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PicoOnlineLeaderboardHandler <>4__this;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string key;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int score;

		[Token(Token = "0x170000EE")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600052D")]
			[Address(RVA = "0xF6A9B8", Offset = "0xF6A9B8", VA = "0xF6A9B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EF")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600052F")]
			[Address(RVA = "0xF6AA00", Offset = "0xF6AA00", VA = "0xF6AA00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xF6A8C8", Offset = "0xF6A8C8", VA = "0xF6A8C8")]
		[DebuggerHidden]
		public <RetrySubmitScore>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xF6A8F4", Offset = "0xF6A8F4", VA = "0xF6A8F4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xF6A8F8", Offset = "0xF6A8F8", VA = "0xF6A8F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xF6A9C0", Offset = "0xF6A9C0", VA = "0xF6A9C0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400048D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Dictionary<string, PicoLeaderboard> leaderboards;

	[Token(Token = "0x400048E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int retryAttempts;

	[Token(Token = "0x6000519")]
	[Address(RVA = "0x2736774", Offset = "0x2736774", VA = "0x2736774", Slot = "6")]
	public override void Start()
	{
	}

	[Token(Token = "0x600051A")]
	[Address(RVA = "0x2736A4C", Offset = "0x2736A4C", VA = "0x2736A4C", Slot = "7")]
	public override void UpdateLeaderboard(string key, OnlineLeaderboardType method)
	{
	}

	[Token(Token = "0x600051B")]
	[Address(RVA = "0x2736AF4", Offset = "0x2736AF4", VA = "0x2736AF4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B3F30", Offset = "0x9B3F30")]
	private IEnumerator WaitAndDownloadLeaderboard(string key, OnlineLeaderboardType method)
	{
		return null;
	}

	[Token(Token = "0x600051C")]
	[Address(RVA = "0x2736B74", Offset = "0x2736B74", VA = "0x2736B74", Slot = "9")]
	public override void SubmitScore(string key, int score)
	{
	}

	[Token(Token = "0x600051D")]
	[Address(RVA = "0x2736D30", Offset = "0x2736D30", VA = "0x2736D30")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B3F90", Offset = "0x9B3F90")]
	private IEnumerator RetrySubmitScore(string key, int score)
	{
		return null;
	}

	[Token(Token = "0x600051E")]
	[Address(RVA = "0x2736DB0", Offset = "0x2736DB0", VA = "0x2736DB0")]
	public PicoOnlineLeaderboardHandler()
	{
	}
}
[Token(Token = "0x20000D2")]
public class ScorePlace : MonoBehaviour
{
	[Token(Token = "0x20000D3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE324", Offset = "0x9AE324")]
	private sealed class <CopyTexture>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ScorePlace <>4__this;

		[Token(Token = "0x170000F0")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600053A")]
			[Address(RVA = "0x228F3D0", Offset = "0x228F3D0", VA = "0x228F3D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F1")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600053C")]
			[Address(RVA = "0x228F418", Offset = "0x228F418", VA = "0x228F418", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x228F288", Offset = "0x228F288", VA = "0x228F288")]
		[DebuggerHidden]
		public <CopyTexture>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x228F2B4", Offset = "0x228F2B4", VA = "0x228F2B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x228F2B8", Offset = "0x228F2B8", VA = "0x228F2B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x228F3D8", Offset = "0x228F3D8", VA = "0x228F3D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI placeText;

	[Token(Token = "0x40004A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI playerNameText;

	[Token(Token = "0x40004A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RawImage playerSignature;

	[Token(Token = "0x40004A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI scoreText;

	[Token(Token = "0x40004A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Color originalTextColor;

	[Token(Token = "0x40004A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Color liveUpdateTextColor;

	[Token(Token = "0x40004A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Whiteboard whiteboard;

	[Token(Token = "0x6000530")]
	[Address(RVA = "0x2740F6C", Offset = "0x2740F6C", VA = "0x2740F6C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000531")]
	[Address(RVA = "0x2740FAC", Offset = "0x2740FAC", VA = "0x2740FAC")]
	public void LiveInsertNewScore()
	{
	}

	[Token(Token = "0x6000532")]
	[Address(RVA = "0x2741108", Offset = "0x2741108", VA = "0x2741108")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B4090", Offset = "0x9B4090")]
	private IEnumerator CopyTexture()
	{
		return null;
	}

	[Token(Token = "0x6000533")]
	[Address(RVA = "0x2741174", Offset = "0x2741174", VA = "0x2741174")]
	private void StopLiveUpdate()
	{
	}

	[Token(Token = "0x6000534")]
	[Address(RVA = "0x27411D8", Offset = "0x27411D8", VA = "0x27411D8")]
	private Whiteboard GetWhiteboard()
	{
		return null;
	}

	[Token(Token = "0x6000535")]
	[Address(RVA = "0x27412A4", Offset = "0x27412A4", VA = "0x27412A4")]
	public ScorePlace()
	{
	}

	[Token(Token = "0x6000536")]
	[Address(RVA = "0x27412AC", Offset = "0x27412AC", VA = "0x27412AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B40F0", Offset = "0x9B40F0")]
	private bool <CopyTexture>b__9_0()
	{
		return default(bool);
	}
}
[Token(Token = "0x20000D4")]
public class SteamAchievementsHandler : AchievementsHandler
{
	[Token(Token = "0x600053D")]
	[Address(RVA = "0x2742B80", Offset = "0x2742B80", VA = "0x2742B80")]
	public SteamAchievementsHandler()
	{
	}
}
[Token(Token = "0x20000D5")]
public class SteamInitializer : Singleton<SteamInitializer>
{
	[Token(Token = "0x40004AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool initialized;

	[Token(Token = "0x40004AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool error;

	[Token(Token = "0x40004AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ulong userID;

	[Token(Token = "0x40004AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int maxRetries;

	[Token(Token = "0x40004B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int retryCount;

	[Token(Token = "0x600053E")]
	[Address(RVA = "0x2742B88", Offset = "0x2742B88", VA = "0x2742B88")]
	public SteamInitializer()
	{
	}
}
[Token(Token = "0x20000D6")]
public class SteamOnlineLeaderboardHandler : OnlineLeaderboardHandler
{
	[Token(Token = "0x600053F")]
	[Address(RVA = "0x2742BEC", Offset = "0x2742BEC", VA = "0x2742BEC")]
	public SteamOnlineLeaderboardHandler()
	{
	}
}
[Token(Token = "0x20000D7")]
public class iQiyiInitializer : Singleton<iQiyiInitializer>
{
	[Token(Token = "0x40004B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool initialized;

	[Token(Token = "0x40004B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool error;

	[Token(Token = "0x40004B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string userID;

	[Token(Token = "0x6000540")]
	[Address(RVA = "0xED4EE0", Offset = "0xED4EE0", VA = "0xED4EE0")]
	public iQiyiInitializer()
	{
	}
}
[Token(Token = "0x20000D8")]
public class ArcadeGPM : GamePlayManager
{
	[Token(Token = "0x20000D9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE334", Offset = "0x9AE334")]
	private sealed class <HandleLeaderboardsAndAchievements>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ArcadeGPM <>4__this;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <highestScore>5__2;

		[Token(Token = "0x170000F2")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0xED67C8", Offset = "0xED67C8", VA = "0xED67C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F3")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000554")]
			[Address(RVA = "0xED6810", Offset = "0xED6810", VA = "0xED6810", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xED6170", Offset = "0xED6170", VA = "0xED6170")]
		[DebuggerHidden]
		public <HandleLeaderboardsAndAchievements>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xED619C", Offset = "0xED619C", VA = "0xED619C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xED61A0", Offset = "0xED61A0", VA = "0xED61A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xED67D0", Offset = "0xED67D0", VA = "0xED67D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public AudioHandler arcadeCenterAudioHandler;

	[Token(Token = "0x40004B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public OnlineLeaderboard onlineLeaderboard;

	[Token(Token = "0x40004B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public LocalLeaderboard localLeaderboard;

	[Token(Token = "0x40004B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public GameObject newHighScore;

	[Token(Token = "0x40004B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public int score;

	[Token(Token = "0x40004B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public Whiteboard signatureBoard;

	[Token(Token = "0x40004BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private bool pointsSubmitted;

	[Token(Token = "0x40004BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public GameObject areYouSureSign;

	[Token(Token = "0x40004BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	public Button areYouSureButton;

	[Token(Token = "0x40004BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	public TextMeshProUGUI pointsDisplay;

	[Token(Token = "0x40004BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	public TextMeshProUGUI waveDisplay;

	[Token(Token = "0x40004BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private Animator waveDisplayAnimator;

	[Token(Token = "0x40004C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	public GameObject pointsCanvasPrefab;

	[Token(Token = "0x40004C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public TextMeshProUGUI finishPointsText;

	[Token(Token = "0x40004C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public TextMeshProUGUI finishTimeText;

	[Token(Token = "0x40004C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public TextMeshProUGUI finishWaveText;

	[Token(Token = "0x40004C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	protected int arcadeWave;

	[Token(Token = "0x40004C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	public ArcadeWaveHandler arcadeWaveSpawner;

	[Token(Token = "0x40004C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public int multiplier;

	[Token(Token = "0x40004C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
	private float secondsSinceLastEnemyDeath;

	[Token(Token = "0x40004C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	public float[] multiplierThresholds;

	[Token(Token = "0x40004C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	public bool showMultiplerDisplay;

	[Token(Token = "0x40004CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	public TextMeshProUGUI multiplierDisplay;

	[Token(Token = "0x40004CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	public GameObject multiplierTimerBar;

	[Token(Token = "0x40004CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private Material multiplierTimerBarMaterial;

	[Token(Token = "0x40004CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	public GameObject multiplierCanvas;

	[Token(Token = "0x40004CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	public GameObject multiplierCanvasEletricParticles;

	[Token(Token = "0x40004CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	public ArcadeMode arcadeMode;

	[Token(Token = "0x6000541")]
	[Address(RVA = "0xD22F64", Offset = "0xD22F64", VA = "0xD22F64", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000542")]
	[Address(RVA = "0xD23384", Offset = "0xD23384", VA = "0xD23384", Slot = "7")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000543")]
	[Address(RVA = "0xD23698", Offset = "0xD23698", VA = "0xD23698", Slot = "19")]
	public override void GameFinished([Optional] string finishText, bool _won = true, LosingReason reason = LosingReason.Null)
	{
	}

	[Token(Token = "0x6000544")]
	[Address(RVA = "0xD23C18", Offset = "0xD23C18", VA = "0xD23C18")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B4150", Offset = "0x9B4150")]
	private IEnumerator HandleLeaderboardsAndAchievements()
	{
		return null;
	}

	[Token(Token = "0x6000545")]
	[Address(RVA = "0xD23C84", Offset = "0xD23C84", VA = "0xD23C84")]
	public void SubmitLocalScore()
	{
	}

	[Token(Token = "0x6000546")]
	[Address(RVA = "0xD235DC", Offset = "0xD235DC", VA = "0xD235DC")]
	private void DivideMultiplier()
	{
	}

	[Token(Token = "0x6000547")]
	[Address(RVA = "0xD23D68", Offset = "0xD23D68", VA = "0xD23D68")]
	private void MultiplyMultiplier()
	{
	}

	[Token(Token = "0x6000548")]
	[Address(RVA = "0xD23E70", Offset = "0xD23E70", VA = "0xD23E70")]
	public void ScorePoints(Enemy _enemy)
	{
	}

	[Token(Token = "0x6000549")]
	[Address(RVA = "0xD24214", Offset = "0xD24214", VA = "0xD24214")]
	public void ScorePoints(RequestSlot _slot)
	{
	}

	[Token(Token = "0x600054A")]
	[Address(RVA = "0xD241C0", Offset = "0xD241C0", VA = "0xD241C0")]
	private void UpdatePoints(int pointsToAdd)
	{
	}

	[Token(Token = "0x600054B")]
	[Address(RVA = "0xD23294", Offset = "0xD23294", VA = "0xD23294")]
	private void UpdateWaveDisplay(int waveNumber)
	{
	}

	[Token(Token = "0x600054C")]
	[Address(RVA = "0xD2453C", Offset = "0xD2453C", VA = "0xD2453C", Slot = "8")]
	public override void RestartCurrentLevel()
	{
	}

	[Token(Token = "0x600054D")]
	[Address(RVA = "0xD24610", Offset = "0xD24610", VA = "0xD24610", Slot = "9")]
	public override void BackToMenu()
	{
	}

	[Token(Token = "0x600054E")]
	[Address(RVA = "0xD246E4", Offset = "0xD246E4", VA = "0xD246E4")]
	public ArcadeGPM()
	{
	}
}
[Token(Token = "0x20000DA")]
public class ArcadeTutorialGPM : GamePlayManager
{
	[Token(Token = "0x40004D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public GameObject[] disableOnPhase2;

	[Token(Token = "0x40004D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public GameObject[] enableOnPhase2;

	[Token(Token = "0x40004D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public GameObject[] disableOnPhase3;

	[Token(Token = "0x40004D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public GameObject[] enableOnPhase3;

	[Token(Token = "0x40004D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private int phase;

	[Token(Token = "0x40004D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
	private bool completedAllRequests;

	[Token(Token = "0x40004DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public int nOfEnemiesForGameFinish;

	[Token(Token = "0x40004DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9AF0D4", Offset = "0x9AF0D4")]
	public bool hasElectricExited;

	[Token(Token = "0x6000555")]
	[Address(RVA = "0xD258E4", Offset = "0xD258E4", VA = "0xD258E4", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000556")]
	[Address(RVA = "0xD25A08", Offset = "0xD25A08", VA = "0xD25A08")]
	private void CheckIfElectricExited(Boomerang _boomerang)
	{
	}

	[Token(Token = "0x6000557")]
	[Address(RVA = "0xD25A34", Offset = "0xD25A34", VA = "0xD25A34", Slot = "11")]
	protected override void KillEnemy(Enemy _enemy)
	{
	}

	[Token(Token = "0x6000558")]
	[Address(RVA = "0xD25AAC", Offset = "0xD25AAC", VA = "0xD25AAC")]
	private void SetGroupActive(GameObject[] objs, bool active)
	{
	}

	[Token(Token = "0x6000559")]
	[Address(RVA = "0xD25B28", Offset = "0xD25B28", VA = "0xD25B28")]
	private void OnAllRequestsComplete()
	{
	}

	[Token(Token = "0x600055A")]
	[Address(RVA = "0xD25BC4", Offset = "0xD25BC4", VA = "0xD25BC4", Slot = "21")]
	protected new virtual int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x600055B")]
	[Address(RVA = "0xD25C14", Offset = "0xD25C14", VA = "0xD25C14", Slot = "19")]
	public override void GameFinished([Optional] string finishText, bool _won = true, LosingReason reason = LosingReason.Null)
	{
	}

	[Token(Token = "0x600055C")]
	[Address(RVA = "0xD25E00", Offset = "0xD25E00", VA = "0xD25E00")]
	public ArcadeTutorialGPM()
	{
	}
}
[Token(Token = "0x20000DB")]
public class CookingArcadeGPM : ArcadeGPM
{
	[Token(Token = "0x40004DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x244")]
	public int requestsMissed;

	[Token(Token = "0x600055D")]
	[Address(RVA = "0xD340D4", Offset = "0xD340D4", VA = "0xD340D4", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600055E")]
	[Address(RVA = "0xD341F4", Offset = "0xD341F4", VA = "0xD341F4", Slot = "18")]
	public override void BeerDelivered()
	{
	}

	[Token(Token = "0x600055F")]
	[Address(RVA = "0xD34218", Offset = "0xD34218", VA = "0xD34218", Slot = "12")]
	protected override void LostABeer(Beer beer)
	{
	}

	[Token(Token = "0x6000560")]
	[Address(RVA = "0xD342D0", Offset = "0xD342D0", VA = "0xD342D0")]
	public CookingArcadeGPM()
	{
	}
}
[Token(Token = "0x20000DC")]
public enum LosingReason
{
	[Token(Token = "0x40004DE")]
	Null,
	[Token(Token = "0x40004DF")]
	Health,
	[Token(Token = "0x40004E0")]
	Beers,
	[Token(Token = "0x40004E1")]
	Requests
}
[Token(Token = "0x20000DD")]
public class GamePlayManager : Singleton<GamePlayManager>
{
	[Serializable]
	[Token(Token = "0x20000DE")]
	public class FoodReplaceableVariables
	{
		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform beerInstanciateTransform;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform beerSecondaryInstanciateTransform;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject primaryBeerPrefab;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject secondaryBeerPrefab;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FiniteSpawnerSocket burgerTopBreadSpawner;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public FiniteSpawnerSocket burgerMeatSpawner;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public FiniteSpawnerSocket burgerBottomBreadSpawner;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FiniteSpawnerSocket snagBreadSpawner;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public FiniteSpawnerSocket snagMeatSpawner;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public FiniteSpawnerSocket skewerStickSpawner;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FiniteSpawnerSocket skewerShrimpSpawner;

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xF593BC", Offset = "0xF593BC", VA = "0xF593BC")]
		public FoodReplaceableVariables()
		{
		}
	}

	[Token(Token = "0x20000DF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE344", Offset = "0x9AE344")]
	private sealed class <SlowDownTimeCoroutine>d__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GamePlayManager <>4__this;

		[Token(Token = "0x170000F4")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600058C")]
			[Address(RVA = "0xF5936C", Offset = "0xF5936C", VA = "0xF5936C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F5")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0xF593B4", Offset = "0xF593B4", VA = "0xF593B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xF59248", Offset = "0xF59248", VA = "0xF59248")]
		[DebuggerHidden]
		public <SlowDownTimeCoroutine>d__59(int <>1__state)
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xF59274", Offset = "0xF59274", VA = "0xF59274", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xF59278", Offset = "0xF59278", VA = "0xF59278", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xF59374", Offset = "0xF59374", VA = "0xF59374", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE354", Offset = "0x9AE354")]
	private sealed class <KillPlayer>d__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GamePlayManager <>4__this;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HVRScreenFade <fader>5__2;

		[Token(Token = "0x170000F6")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0xF591F8", Offset = "0xF591F8", VA = "0xF591F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F7")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000594")]
			[Address(RVA = "0xF59240", Offset = "0xF59240", VA = "0xF59240", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xF58FEC", Offset = "0xF58FEC", VA = "0xF58FEC")]
		[DebuggerHidden]
		public <KillPlayer>d__76(int <>1__state)
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xF59018", Offset = "0xF59018", VA = "0xF59018", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xF5901C", Offset = "0xF5901C", VA = "0xF5901C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xF59200", Offset = "0xF59200", VA = "0xF59200", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE364", Offset = "0x9AE364")]
	private sealed class <<WaitToAnnounceAllEnemiesGone>g__WaitUntilAllEnemiesGone|77_0>d : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GamePlayManager <>4__this;

		[Token(Token = "0x170000F8")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0xF58F9C", Offset = "0xF58F9C", VA = "0xF58F9C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F9")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600059A")]
			[Address(RVA = "0xF58FE4", Offset = "0xF58FE4", VA = "0xF58FE4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xF58E0C", Offset = "0xF58E0C", VA = "0xF58E0C")]
		[DebuggerHidden]
		public <<WaitToAnnounceAllEnemiesGone>g__WaitUntilAllEnemiesGone|77_0>d(int <>1__state)
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xF58E38", Offset = "0xF58E38", VA = "0xF58E38", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xF58E3C", Offset = "0xF58E3C", VA = "0xF58E3C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xF58FA4", Offset = "0xF58FA4", VA = "0xF58FA4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected int levelDurationSeconds;

	[Token(Token = "0x40004E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	protected float levelSecondsLeft;

	[Token(Token = "0x40004E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected bool gameWithTime;

	[Token(Token = "0x40004E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool gameRunning;

	[Token(Token = "0x40004E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	protected bool levelFinished;

	[Token(Token = "0x40004E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
	protected bool levelWon;

	[Token(Token = "0x40004E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9AF10C", Offset = "0x9AF10C")]
	public LevelInfo levelInfo;

	[Token(Token = "0x40004E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject showOnceGameFinished;

	[Token(Token = "0x40004EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject goneOnceGameFinished;

	[Token(Token = "0x40004EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public FinishedSign finishedSign;

	[Token(Token = "0x40004EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI timeText;

	[Token(Token = "0x40004ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public Events.EventPlayerHurt OnPlayerHurt;

	[Token(Token = "0x40004EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public Events.EventBeerDisapeared OnBeerLost;

	[Token(Token = "0x40004EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[HideInInspector]
	public Events.EventBeerBoxDisapeared OnBeerBoxSteal;

	[Token(Token = "0x40004F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public Events.EventEnemyDeath OnEnemyDeath;

	[Token(Token = "0x40004F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public Events.EventEnemyGone OnEnemyGone;

	[Token(Token = "0x40004F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[HideInInspector]
	public Events.EventEnemySpawn OnEnemySpawn;

	[Token(Token = "0x40004F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[HideInInspector]
	public Events.EventFinishGame OnGameFinished;

	[Token(Token = "0x40004F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public Events.EventScoreSubmit OnScoreSubmited;

	[Token(Token = "0x40004F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[HideInInspector]
	public Events.EventBeerDelivered OnBeerDelivered;

	[Token(Token = "0x40004F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[HideInInspector]
	public Events.EventHamburgerDelivered OnHamburgerDelivered;

	[Token(Token = "0x40004F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	public Events.EventSnagDelivered OnSnagDelivered;

	[Token(Token = "0x40004F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[HideInInspector]
	public Events.EventSkewerDelivered OnSkewerDelivered;

	[Token(Token = "0x40004F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[HideInInspector]
	public Events.EventAllEnemiesGone OnAllEnemiesGone;

	[Token(Token = "0x40004FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[HideInInspector]
	public Events.EventBoomerangDestroy OnBoomerangDestroy;

	[Token(Token = "0x40004FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[HideInInspector]
	public Events.EventBoomerangGrab OnBoomerangGrab;

	[Token(Token = "0x40004FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[HideInInspector]
	public Events.EventRequestMissed OnRequestMissedEvent;

	[Token(Token = "0x40004FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[HideInInspector]
	public Events.EventRequestCompleted OnRequestCompleteEvent;

	[Token(Token = "0x40004FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[HideInInspector]
	public Events.EventAllRequestsComplete OnAllRequestComplete;

	[Token(Token = "0x40004FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Events.EventLevelActualStart onLevelActualStart;

	[Token(Token = "0x4000500")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9AF264", Offset = "0x9AF264")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9AF264", Offset = "0x9AF264")]
	public int playerHealth;

	[Token(Token = "0x4000501")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public int beersToLose;

	[Token(Token = "0x4000502")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public int requestsToLose;

	[Token(Token = "0x4000503")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public int currentBeersInLevel;

	[Token(Token = "0x4000504")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public int enemiesNumber;

	[Token(Token = "0x4000505")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	public int enemiesKilled;

	[Token(Token = "0x4000506")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public int parachutesLanded;

	[Token(Token = "0x4000507")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public int objectivesComplete;

	[Token(Token = "0x4000508")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public GameStatistics levelStats;

	[Token(Token = "0x4000509")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private float startTime;

	[Token(Token = "0x400050A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public FoodReplaceableVariables foodItems;

	[Token(Token = "0x400050B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	[HideInInspector]
	public AudioHandler audioHandler;

	[Token(Token = "0x400050C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public TimerBirdBehaviour timerBird;

	[Token(Token = "0x400050D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private TextMeshProUGUI watchTimeText;

	[Token(Token = "0x400050E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	protected float timeSinceLastCalled;

	[Token(Token = "0x400050F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private HVRTimeManager timeManager;

	[Token(Token = "0x4000510")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public bool isSlowedDown;

	[Token(Token = "0x4000511")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	private float timeLeftInSlowDown;

	[Token(Token = "0x4000512")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private int slowDownDuration;

	[Token(Token = "0x4000513")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	protected int minutes;

	[Token(Token = "0x4000514")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	protected int seconds;

	[Token(Token = "0x4000515")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	private int attemptNumber;

	[Token(Token = "0x4000516")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public XDisplayManager beersLostDisplay;

	[Token(Token = "0x4000517")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public XDisplayManager requestsLostDisplay;

	[Token(Token = "0x6000561")]
	[Address(RVA = "0xDE3724", Offset = "0xDE3724", VA = "0xDE3724", Slot = "6")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000562")]
	[Address(RVA = "0xDE4014", Offset = "0xDE4014", VA = "0xDE4014", Slot = "7")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6000563")]
	[Address(RVA = "0xDE41F0", Offset = "0xDE41F0", VA = "0xDE41F0")]
	public int CountBeers()
	{
		return default(int);
	}

	[Token(Token = "0x6000564")]
	[Address(RVA = "0xDE4270", Offset = "0xDE4270", VA = "0xDE4270")]
	public void SlowDownTime()
	{
	}

	[Token(Token = "0x6000565")]
	[Address(RVA = "0xDE42BC", Offset = "0xDE42BC", VA = "0xDE42BC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B4200", Offset = "0x9B4200")]
	public IEnumerator SlowDownTimeCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000566")]
	[Address(RVA = "0xDE4328", Offset = "0xDE4328", VA = "0xDE4328")]
	private void ForceTimeReset()
	{
	}

	[Token(Token = "0x6000567")]
	[Address(RVA = "0xDE43E0", Offset = "0xDE43E0", VA = "0xDE43E0")]
	public void GoToLevel(string levelName)
	{
	}

	[Token(Token = "0x6000568")]
	[Address(RVA = "0xDE52AC", Offset = "0xDE52AC", VA = "0xDE52AC", Slot = "8")]
	public virtual void RestartCurrentLevel()
	{
	}

	[Token(Token = "0x6000569")]
	[Address(RVA = "0xDE5338", Offset = "0xDE5338", VA = "0xDE5338", Slot = "9")]
	public virtual void BackToMenu()
	{
	}

	[Token(Token = "0x600056A")]
	[Address(RVA = "0xDE54C4", Offset = "0xDE54C4", VA = "0xDE54C4", Slot = "10")]
	protected virtual void LevelActualStartsFunction()
	{
	}

	[Token(Token = "0x600056B")]
	[Address(RVA = "0xDE5554", Offset = "0xDE5554", VA = "0xDE5554", Slot = "11")]
	protected virtual void KillEnemy(Enemy _enemy)
	{
	}

	[Token(Token = "0x600056C")]
	[Address(RVA = "0xDE56C4", Offset = "0xDE56C4", VA = "0xDE56C4")]
	private void RemoveEnemy()
	{
	}

	[Token(Token = "0x600056D")]
	[Address(RVA = "0xDE56D4", Offset = "0xDE56D4", VA = "0xDE56D4")]
	private void addEnemy()
	{
	}

	[Token(Token = "0x600056E")]
	[Address(RVA = "0xDDC59C", Offset = "0xDDC59C", VA = "0xDDC59C")]
	public void PlayerHurt(int damageToGive)
	{
	}

	[Token(Token = "0x600056F")]
	[Address(RVA = "0xDE5750", Offset = "0xDE5750", VA = "0xDE5750", Slot = "12")]
	protected virtual void LostABeer(Beer beer)
	{
	}

	[Token(Token = "0x6000570")]
	[Address(RVA = "0xDE584C", Offset = "0xDE584C", VA = "0xDE584C", Slot = "13")]
	protected virtual void RequestMissed(RequestSlot _)
	{
	}

	[Token(Token = "0x6000571")]
	[Address(RVA = "0xDE593C", Offset = "0xDE593C", VA = "0xDE593C", Slot = "14")]
	protected virtual void RequestComplete(RequestSlot _)
	{
	}

	[Token(Token = "0x6000572")]
	[Address(RVA = "0xDE5960", Offset = "0xDE5960", VA = "0xDE5960", Slot = "15")]
	protected virtual void HamburgerDelivered()
	{
	}

	[Token(Token = "0x6000573")]
	[Address(RVA = "0xDE5984", Offset = "0xDE5984", VA = "0xDE5984", Slot = "16")]
	protected virtual void SnagDelivered()
	{
	}

	[Token(Token = "0x6000574")]
	[Address(RVA = "0xDE59A8", Offset = "0xDE59A8", VA = "0xDE59A8", Slot = "17")]
	protected virtual void SkewerDelivered()
	{
	}

	[Token(Token = "0x6000575")]
	[Address(RVA = "0xDE59CC", Offset = "0xDE59CC", VA = "0xDE59CC", Slot = "18")]
	public virtual void BeerDelivered()
	{
	}

	[Token(Token = "0x6000576")]
	[Address(RVA = "0xDE56E4", Offset = "0xDE56E4", VA = "0xDE56E4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B4260", Offset = "0x9B4260")]
	private IEnumerator KillPlayer()
	{
		return null;
	}

	[Token(Token = "0x6000577")]
	[Address(RVA = "0xDE59FC", Offset = "0xDE59FC", VA = "0xDE59FC")]
	public void WaitToAnnounceAllEnemiesGone()
	{
	}

	[Token(Token = "0x6000578")]
	[Address(RVA = "0xDE5A94", Offset = "0xDE5A94", VA = "0xDE5A94")]
	public void AwardAchievement(string _achievementID)
	{
	}

	[Token(Token = "0x6000579")]
	[Address(RVA = "0xDE5B24", Offset = "0xDE5B24", VA = "0xDE5B24", Slot = "19")]
	public virtual void GameFinished([Optional] string finishText, bool won = true, LosingReason reason = LosingReason.Null)
	{
	}

	[Token(Token = "0x600057A")]
	[Address(RVA = "0xDE6414", Offset = "0xDE6414", VA = "0xDE6414")]
	public int CountColdBeers()
	{
		return default(int);
	}

	[Token(Token = "0x600057B")]
	[Address(RVA = "0xDE6578", Offset = "0xDE6578", VA = "0xDE6578", Slot = "20")]
	protected virtual int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x600057C")]
	[Address(RVA = "0xDE6580", Offset = "0xDE6580", VA = "0xDE6580")]
	protected void ObjectiveCheck(int i)
	{
	}

	[Token(Token = "0x600057D")]
	[Address(RVA = "0xDE61BC", Offset = "0xDE61BC", VA = "0xDE61BC")]
	public void FinishScreen(int _objectivesComplete)
	{
	}

	[Token(Token = "0x600057E")]
	[Address(RVA = "0xDE4570", Offset = "0xDE4570", VA = "0xDE4570")]
	public void LevelAchievementCheck()
	{
	}

	[Token(Token = "0x600057F")]
	[Address(RVA = "0xDE5598", Offset = "0xDE5598", VA = "0xDE5598")]
	private void AddEnemyConcussedToLevelStatistics(Enemy.TypeOfEnemy _typeOfEnemy)
	{
	}

	[Token(Token = "0x6000580")]
	[Address(RVA = "0xDE6860", Offset = "0xDE6860", VA = "0xDE6860")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000581")]
	[Address(RVA = "0xDE46BC", Offset = "0xDE46BC", VA = "0xDE46BC")]
	private void SendLevelAttemptAnalyticsEvent(bool quitApplication = false)
	{
	}

	[Token(Token = "0x6000582")]
	[Address(RVA = "0xDE6868", Offset = "0xDE6868", VA = "0xDE6868")]
	private void ReplaceDeliveredItem(RequestSlot _slot)
	{
	}

	[Token(Token = "0x6000583")]
	[Address(RVA = "0xDE6C60", Offset = "0xDE6C60", VA = "0xDE6C60")]
	private void InstanciateBeerInBeerBox(GameObject beerPrefab, Transform beerBox)
	{
	}

	[Token(Token = "0x6000584")]
	[Address(RVA = "0xDE6D34", Offset = "0xDE6D34", VA = "0xDE6D34")]
	private void UpdateSpawnerLimit(FiniteSpawnerSocket spawner, int n = 1)
	{
	}

	[Token(Token = "0x6000585")]
	[Address(RVA = "0xDE6E0C", Offset = "0xDE6E0C", VA = "0xDE6E0C")]
	public GamePlayManager()
	{
	}

	[Token(Token = "0x6000586")]
	[Address(RVA = "0xDE5A28", Offset = "0xDE5A28", VA = "0xDE5A28")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B42C0", Offset = "0x9B42C0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B42C0", Offset = "0x9B42C0")]
	private IEnumerator <WaitToAnnounceAllEnemiesGone>g__WaitUntilAllEnemiesGone|77_0()
	{
		return null;
	}

	[Token(Token = "0x6000587")]
	[Address(RVA = "0xDE6E70", Offset = "0xDE6E70", VA = "0xDE6E70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B4330", Offset = "0x9B4330")]
	private bool <WaitToAnnounceAllEnemiesGone>b__77_1()
	{
		return default(bool);
	}
}
[Token(Token = "0x20000E2")]
public class HellGPM : GamePlayManager
{
	[Token(Token = "0x600059B")]
	[Address(RVA = "0xDE8280", Offset = "0xDE8280", VA = "0xDE8280", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x600059C")]
	[Address(RVA = "0xDE8288", Offset = "0xDE8288", VA = "0xDE8288")]
	public HellGPM()
	{
	}
}
[Token(Token = "0x20000E3")]
public class Level10GPM : GamePlayManager
{
	[Token(Token = "0x20000E4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE374", Offset = "0x9AE374")]
	private sealed class <>c__DisplayClass6_0
	{
		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource s;

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xF63668", Offset = "0xF63668", VA = "0xF63668")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xF63670", Offset = "0xF63670", VA = "0xF63670")]
		internal bool <MusicSetup>b__0()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000E5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE384", Offset = "0x9AE384")]
	private sealed class <MusicSetup>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level10GPM <>4__this;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private <>c__DisplayClass6_0 <>8__1;

		[Token(Token = "0x170000FA")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0xF63978", Offset = "0xF63978", VA = "0xF63978", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FB")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0xF639C0", Offset = "0xF639C0", VA = "0xF639C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xF6368C", Offset = "0xF6368C", VA = "0xF6368C")]
		[DebuggerHidden]
		public <MusicSetup>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xF636B8", Offset = "0xF636B8", VA = "0xF636B8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xF636BC", Offset = "0xF636BC", VA = "0xF636BC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xF63980", Offset = "0xF63980", VA = "0xF63980", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE394", Offset = "0x9AE394")]
	private sealed class <StartMole>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level10GPM <>4__this;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <time>5__2;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 <startingPos>5__3;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 <startingPosLevelEssentials>5__4;

		[Token(Token = "0x170000FC")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0xF63F90", Offset = "0xF63F90", VA = "0xF63F90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FD")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0xF63FD8", Offset = "0xF63FD8", VA = "0xF63FD8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xF639C8", Offset = "0xF639C8", VA = "0xF639C8")]
		[DebuggerHidden]
		public <StartMole>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xF639F4", Offset = "0xF639F4", VA = "0xF639F4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xF639F8", Offset = "0xF639F8", VA = "0xF639F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xF63F98", Offset = "0xF63F98", VA = "0xF63F98", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400052D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public GameObject originalMap;

	[Token(Token = "0x400052E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public GameObject moleMap;

	[Token(Token = "0x400052F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public AudioHandler mapAudioHandler;

	[Token(Token = "0x4000530")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public GameObject mole;

	[Token(Token = "0x600059D")]
	[Address(RVA = "0xDEB83C", Offset = "0xDEB83C", VA = "0xDEB83C", Slot = "11")]
	protected override void KillEnemy(Enemy _enemy)
	{
	}

	[Token(Token = "0x600059E")]
	[Address(RVA = "0xDEB878", Offset = "0xDEB878", VA = "0xDEB878", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600059F")]
	[Address(RVA = "0xDEB930", Offset = "0xDEB930", VA = "0xDEB930")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B4430", Offset = "0x9B4430")]
	private IEnumerator MusicSetup()
	{
		return null;
	}

	[Token(Token = "0x60005A0")]
	[Address(RVA = "0xDEB8C4", Offset = "0xDEB8C4", VA = "0xDEB8C4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B4490", Offset = "0x9B4490")]
	private IEnumerator StartMole()
	{
		return null;
	}

	[Token(Token = "0x60005A1")]
	[Address(RVA = "0xDEB99C", Offset = "0xDEB99C", VA = "0xDEB99C")]
	public void AddMusicIntensity(int _stage)
	{
	}

	[Token(Token = "0x60005A2")]
	[Address(RVA = "0xDEBB2C", Offset = "0xDEBB2C", VA = "0xDEBB2C", Slot = "12")]
	protected override void LostABeer(Beer beer)
	{
	}

	[Token(Token = "0x60005A3")]
	[Address(RVA = "0xDEBB30", Offset = "0xDEBB30", VA = "0xDEBB30", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x60005A4")]
	[Address(RVA = "0xDEBBBC", Offset = "0xDEBBBC", VA = "0xDEBBBC", Slot = "19")]
	public override void GameFinished([Optional] string finishText, bool won = true, LosingReason reason = LosingReason.Null)
	{
	}

	[Token(Token = "0x60005A5")]
	[Address(RVA = "0xDEBBE8", Offset = "0xDEBBE8", VA = "0xDEBBE8")]
	public Level10GPM()
	{
	}
}
[Token(Token = "0x20000E7")]
public class Level11GPM : GamePlayManager
{
	[Token(Token = "0x20000E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE3A4", Offset = "0x9AE3A4")]
	private sealed class <WaitUntilLevelStart>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level11GPM <>4__this;

		[Token(Token = "0x170000FE")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0xF6416C", Offset = "0xF6416C", VA = "0xF6416C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FF")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005BE")]
			[Address(RVA = "0xF641B4", Offset = "0xF641B4", VA = "0xF641B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xF63FE0", Offset = "0xF63FE0", VA = "0xF63FE0")]
		[DebuggerHidden]
		public <WaitUntilLevelStart>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xF6400C", Offset = "0xF6400C", VA = "0xF6400C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xF64010", Offset = "0xF64010", VA = "0xF64010", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xF64174", Offset = "0xF64174", VA = "0xF64174", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x60005B4")]
	[Address(RVA = "0xDEBBEC", Offset = "0xDEBBEC", VA = "0xDEBBEC", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60005B5")]
	[Address(RVA = "0xDEBC20", Offset = "0xDEBC20", VA = "0xDEBC20")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B4590", Offset = "0x9B4590")]
	private IEnumerator WaitUntilLevelStart()
	{
		return null;
	}

	[Token(Token = "0x60005B6")]
	[Address(RVA = "0xDEBC8C", Offset = "0xDEBC8C", VA = "0xDEBC8C", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x60005B7")]
	[Address(RVA = "0xDEBD24", Offset = "0xDEBD24", VA = "0xDEBD24")]
	public Level11GPM()
	{
	}

	[Token(Token = "0x60005B8")]
	[Address(RVA = "0xDEBD28", Offset = "0xDEBD28", VA = "0xDEBD28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B45F0", Offset = "0x9B45F0")]
	private bool <WaitUntilLevelStart>b__1_0()
	{
		return default(bool);
	}
}
[Token(Token = "0x20000E9")]
public class Level12GPM : GamePlayManager
{
	[Token(Token = "0x20000EA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE3B4", Offset = "0x9AE3B4")]
	private sealed class <WaitUntilLevelStart>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level12GPM <>4__this;

		[Token(Token = "0x17000100")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0xF64348", Offset = "0xF64348", VA = "0xF64348", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000101")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0xF64390", Offset = "0xF64390", VA = "0xF64390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xF641BC", Offset = "0xF641BC", VA = "0xF641BC")]
		[DebuggerHidden]
		public <WaitUntilLevelStart>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xF641E8", Offset = "0xF641E8", VA = "0xF641E8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xF641EC", Offset = "0xF641EC", VA = "0xF641EC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xF64350", Offset = "0xF64350", VA = "0xF64350", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x60005BF")]
	[Address(RVA = "0xDEBD60", Offset = "0xDEBD60", VA = "0xDEBD60", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60005C0")]
	[Address(RVA = "0xDEBD94", Offset = "0xDEBD94", VA = "0xDEBD94")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B4650", Offset = "0x9B4650")]
	private IEnumerator WaitUntilLevelStart()
	{
		return null;
	}

	[Token(Token = "0x60005C1")]
	[Address(RVA = "0xDEBE00", Offset = "0xDEBE00", VA = "0xDEBE00", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x60005C2")]
	[Address(RVA = "0xDEBE9C", Offset = "0xDEBE9C", VA = "0xDEBE9C")]
	public Level12GPM()
	{
	}

	[Token(Token = "0x60005C3")]
	[Address(RVA = "0xDEBEA0", Offset = "0xDEBEA0", VA = "0xDEBEA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B46B0", Offset = "0x9B46B0")]
	private bool <WaitUntilLevelStart>b__1_0()
	{
		return default(bool);
	}
}
[Token(Token = "0x20000EB")]
public class Level13GPM : GamePlayManager
{
	[Token(Token = "0x20000EC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE3C4", Offset = "0x9AE3C4")]
	private sealed class <WaitUntilLevelStart>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level13GPM <>4__this;

		[Token(Token = "0x17000102")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0xF64524", Offset = "0xF64524", VA = "0xF64524", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000103")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005D4")]
			[Address(RVA = "0xF6456C", Offset = "0xF6456C", VA = "0xF6456C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xF64398", Offset = "0xF64398", VA = "0xF64398")]
		[DebuggerHidden]
		public <WaitUntilLevelStart>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xF643C4", Offset = "0xF643C4", VA = "0xF643C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xF643C8", Offset = "0xF643C8", VA = "0xF643C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xF6452C", Offset = "0xF6452C", VA = "0xF6452C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x60005CA")]
	[Address(RVA = "0xDEBED8", Offset = "0xDEBED8", VA = "0xDEBED8", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60005CB")]
	[Address(RVA = "0xDEBF0C", Offset = "0xDEBF0C", VA = "0xDEBF0C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B4710", Offset = "0x9B4710")]
	private IEnumerator WaitUntilLevelStart()
	{
		return null;
	}

	[Token(Token = "0x60005CC")]
	[Address(RVA = "0xDEBF78", Offset = "0xDEBF78", VA = "0xDEBF78", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x60005CD")]
	[Address(RVA = "0xDEC014", Offset = "0xDEC014", VA = "0xDEC014")]
	public Level13GPM()
	{
	}

	[Token(Token = "0x60005CE")]
	[Address(RVA = "0xDEC018", Offset = "0xDEC018", VA = "0xDEC018")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B4770", Offset = "0x9B4770")]
	private bool <WaitUntilLevelStart>b__1_0()
	{
		return default(bool);
	}
}
[Token(Token = "0x20000ED")]
public class Level14GPM : GamePlayManager
{
	[Token(Token = "0x60005D5")]
	[Address(RVA = "0xDEC050", Offset = "0xDEC050", VA = "0xDEC050", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x60005D6")]
	[Address(RVA = "0xDEC0E8", Offset = "0xDEC0E8", VA = "0xDEC0E8")]
	public Level14GPM()
	{
	}
}
[Token(Token = "0x20000EE")]
public class Level15GPM : GamePlayManager
{
	[Token(Token = "0x20000EF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE3D4", Offset = "0x9AE3D4")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource s;

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xF64574", Offset = "0xF64574", VA = "0xF64574")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xF6457C", Offset = "0xF6457C", VA = "0xF6457C")]
		internal bool <MusicSetup>b__0()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE3E4", Offset = "0x9AE3E4")]
	private sealed class <MusicSetup>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level15GPM <>4__this;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private <>c__DisplayClass3_0 <>8__1;

		[Token(Token = "0x17000104")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0xF64A58", Offset = "0xF64A58", VA = "0xF64A58", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000105")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0xF64AA0", Offset = "0xF64AA0", VA = "0xF64AA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xF6476C", Offset = "0xF6476C", VA = "0xF6476C")]
		[DebuggerHidden]
		public <MusicSetup>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xF64798", Offset = "0xF64798", VA = "0xF64798", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xF6479C", Offset = "0xF6479C", VA = "0xF6479C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xF64A60", Offset = "0xF64A60", VA = "0xF64A60", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000F1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE3F4", Offset = "0x9AE3F4")]
	private sealed class <BackToMenuAfterSeconds>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Level15GPM <>4__this;

		[Token(Token = "0x17000106")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0xF6471C", Offset = "0xF6471C", VA = "0xF6471C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000107")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0xF64764", Offset = "0xF64764", VA = "0xF64764", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xF64598", Offset = "0xF64598", VA = "0xF64598")]
		[DebuggerHidden]
		public <BackToMenuAfterSeconds>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xF645C4", Offset = "0xF645C4", VA = "0xF645C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xF645C8", Offset = "0xF645C8", VA = "0xF645C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xF64724", Offset = "0xF64724", VA = "0xF64724", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000545")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public GameObject creditsSign;

	[Token(Token = "0x4000546")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public bool playEndingSong;

	[Token(Token = "0x60005D7")]
	[Address(RVA = "0xDEC0EC", Offset = "0xDEC0EC", VA = "0xDEC0EC", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60005D8")]
	[Address(RVA = "0xDEC120", Offset = "0xDEC120", VA = "0xDEC120")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B47D0", Offset = "0x9B47D0")]
	private IEnumerator MusicSetup()
	{
		return null;
	}

	[Token(Token = "0x60005D9")]
	[Address(RVA = "0xDEC18C", Offset = "0xDEC18C", VA = "0xDEC18C")]
	public void AddMusicIntensity(int _stage)
	{
	}

	[Token(Token = "0x60005DA")]
	[Address(RVA = "0xDEC31C", Offset = "0xDEC31C", VA = "0xDEC31C", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x60005DB")]
	[Address(RVA = "0xDEC37C", Offset = "0xDEC37C", VA = "0xDEC37C", Slot = "19")]
	public override void GameFinished([Optional] string finishText, bool won = true, LosingReason reason = LosingReason.Null)
	{
	}

	[Token(Token = "0x60005DC")]
	[Address(RVA = "0xDEC540", Offset = "0xDEC540", VA = "0xDEC540")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B4830", Offset = "0x9B4830")]
	private IEnumerator BackToMenuAfterSeconds(float delay)
	{
		return null;
	}

	[Token(Token = "0x60005DD")]
	[Address(RVA = "0xDEC5BC", Offset = "0xDEC5BC", VA = "0xDEC5BC")]
	public Level15GPM()
	{
	}
}
[Token(Token = "0x20000F2")]
public class Level1GPM : GamePlayManager
{
	[Token(Token = "0x60005EC")]
	[Address(RVA = "0xDEC5C0", Offset = "0xDEC5C0", VA = "0xDEC5C0", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60005ED")]
	[Address(RVA = "0xDEC65C", Offset = "0xDEC65C", VA = "0xDEC65C", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x60005EE")]
	[Address(RVA = "0xDEC700", Offset = "0xDEC700", VA = "0xDEC700")]
	private void OneMinLeftAchievement()
	{
	}

	[Token(Token = "0x60005EF")]
	[Address(RVA = "0xDEC7C4", Offset = "0xDEC7C4", VA = "0xDEC7C4")]
	public Level1GPM()
	{
	}
}
[Token(Token = "0x20000F3")]
public class Level2DemoGPM : GamePlayManager
{
	[Token(Token = "0x20000F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE404", Offset = "0x9AE404")]
	private sealed class <WaitAndEnableSkip>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level2DemoGPM <>4__this;

		[Token(Token = "0x17000108")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005FC")]
			[Address(RVA = "0xF64C10", Offset = "0xF64C10", VA = "0xF64C10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000109")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0xF64C58", Offset = "0xF64C58", VA = "0xF64C58", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xF64AA8", Offset = "0xF64AA8", VA = "0xF64AA8")]
		[DebuggerHidden]
		public <WaitAndEnableSkip>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xF64AD4", Offset = "0xF64AD4", VA = "0xF64AD4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xF64AD8", Offset = "0xF64AD8", VA = "0xF64AD8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xF64C18", Offset = "0xF64C18", VA = "0xF64C18", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000F5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE414", Offset = "0x9AE414")]
	private sealed class <WatchTrailerCoroutine>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level2DemoGPM <>4__this;

		[Token(Token = "0x1700010A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000602")]
			[Address(RVA = "0xF65278", Offset = "0xF65278", VA = "0xF65278", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000604")]
			[Address(RVA = "0xF652C0", Offset = "0xF652C0", VA = "0xF652C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xF64C60", Offset = "0xF64C60", VA = "0xF64C60")]
		[DebuggerHidden]
		public <WatchTrailerCoroutine>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xF64C8C", Offset = "0xF64C8C", VA = "0xF64C8C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xF64C90", Offset = "0xF64C90", VA = "0xF64C90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xF65280", Offset = "0xF65280", VA = "0xF65280", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000550")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public GameObject showOnceGameBurgered;

	[Token(Token = "0x4000551")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public GameObject trailerCanvasPrefab;

	[Token(Token = "0x4000552")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private bool skipable;

	[Token(Token = "0x4000553")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private AussiePlayer aussiePlayer;

	[Token(Token = "0x60005F0")]
	[Address(RVA = "0xDEC7C8", Offset = "0xDEC7C8", VA = "0xDEC7C8", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60005F1")]
	[Address(RVA = "0xDEC8B4", Offset = "0xDEC8B4", VA = "0xDEC8B4", Slot = "7")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60005F2")]
	[Address(RVA = "0xDEC98C", Offset = "0xDEC98C", VA = "0xDEC98C", Slot = "15")]
	protected override void HamburgerDelivered()
	{
	}

	[Token(Token = "0x60005F3")]
	[Address(RVA = "0xDECB44", Offset = "0xDECB44", VA = "0xDECB44", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x60005F4")]
	[Address(RVA = "0xDECBCC", Offset = "0xDECBCC", VA = "0xDECBCC")]
	public void WatchTrailer()
	{
	}

	[Token(Token = "0x60005F5")]
	[Address(RVA = "0xDECC10", Offset = "0xDECC10", VA = "0xDECC10")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B4930", Offset = "0x9B4930")]
	private IEnumerator WaitAndEnableSkip()
	{
		return null;
	}

	[Token(Token = "0x60005F6")]
	[Address(RVA = "0xDECC7C", Offset = "0xDECC7C", VA = "0xDECC7C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B4990", Offset = "0x9B4990")]
	private IEnumerator WatchTrailerCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60005F7")]
	[Address(RVA = "0xDECCE8", Offset = "0xDECCE8", VA = "0xDECCE8", Slot = "13")]
	protected override void RequestMissed(RequestSlot _)
	{
	}

	[Token(Token = "0x60005F8")]
	[Address(RVA = "0xDECD60", Offset = "0xDECD60", VA = "0xDECD60")]
	public Level2DemoGPM()
	{
	}
}
[Token(Token = "0x20000F6")]
public class Level2GPM : GamePlayManager
{
	[Token(Token = "0x6000605")]
	[Address(RVA = "0xDECD64", Offset = "0xDECD64", VA = "0xDECD64", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x6000606")]
	[Address(RVA = "0xDECE00", Offset = "0xDECE00", VA = "0xDECE00")]
	public Level2GPM()
	{
	}
}
[Token(Token = "0x20000F7")]
public class Level3GPM : GamePlayManager
{
	[Token(Token = "0x6000607")]
	[Address(RVA = "0xDECE04", Offset = "0xDECE04", VA = "0xDECE04", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x6000608")]
	[Address(RVA = "0xDECEA0", Offset = "0xDECEA0", VA = "0xDECEA0")]
	public Level3GPM()
	{
	}
}
[Token(Token = "0x20000F8")]
public class Level4GPM : GamePlayManager
{
	[Token(Token = "0x20000F9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE424", Offset = "0x9AE424")]
	private sealed class <WaitUntilLevelStart>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level4GPM <>4__this;

		[Token(Token = "0x1700010C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000611")]
			[Address(RVA = "0xF65404", Offset = "0xF65404", VA = "0xF65404", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000613")]
			[Address(RVA = "0xF6544C", Offset = "0xF6544C", VA = "0xF6544C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xF652C8", Offset = "0xF652C8", VA = "0xF652C8")]
		[DebuggerHidden]
		public <WaitUntilLevelStart>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xF652F4", Offset = "0xF652F4", VA = "0xF652F4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xF652F8", Offset = "0xF652F8", VA = "0xF652F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xF6540C", Offset = "0xF6540C", VA = "0xF6540C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000609")]
	[Address(RVA = "0xDECEA4", Offset = "0xDECEA4", VA = "0xDECEA4", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600060A")]
	[Address(RVA = "0xDECED8", Offset = "0xDECED8", VA = "0xDECED8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B4A90", Offset = "0x9B4A90")]
	private IEnumerator WaitUntilLevelStart()
	{
		return null;
	}

	[Token(Token = "0x600060B")]
	[Address(RVA = "0xDECF44", Offset = "0xDECF44", VA = "0xDECF44", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x600060C")]
	[Address(RVA = "0xDECFE4", Offset = "0xDECFE4", VA = "0xDECFE4")]
	public Level4GPM()
	{
	}

	[Token(Token = "0x600060D")]
	[Address(RVA = "0xDECFE8", Offset = "0xDECFE8", VA = "0xDECFE8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B4AF0", Offset = "0x9B4AF0")]
	private bool <WaitUntilLevelStart>b__1_0()
	{
		return default(bool);
	}
}
[Token(Token = "0x20000FA")]
public class Level5GPM : GamePlayManager
{
	[Token(Token = "0x20000FB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE434", Offset = "0x9AE434")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource s;

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xF65454", Offset = "0xF65454", VA = "0xF65454")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xF6545C", Offset = "0xF6545C", VA = "0xF6545C")]
		internal bool <MusicSetup>b__0()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000FC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE444", Offset = "0x9AE444")]
	private sealed class <MusicSetup>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level5GPM <>4__this;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private <>c__DisplayClass2_0 <>8__1;

		[Token(Token = "0x1700010E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0xF65764", Offset = "0xF65764", VA = "0xF65764", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000621")]
			[Address(RVA = "0xF657AC", Offset = "0xF657AC", VA = "0xF657AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xF65478", Offset = "0xF65478", VA = "0xF65478")]
		[DebuggerHidden]
		public <MusicSetup>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xF654A4", Offset = "0xF654A4", VA = "0xF654A4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xF654A8", Offset = "0xF654A8", VA = "0xF654A8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xF6576C", Offset = "0xF6576C", VA = "0xF6576C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400055D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private PicNicArea picnicArea;

	[Token(Token = "0x6000614")]
	[Address(RVA = "0xDED00C", Offset = "0xDED00C", VA = "0xDED00C", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000615")]
	[Address(RVA = "0xDED0A8", Offset = "0xDED0A8", VA = "0xDED0A8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B4B50", Offset = "0x9B4B50")]
	private IEnumerator MusicSetup()
	{
		return null;
	}

	[Token(Token = "0x6000616")]
	[Address(RVA = "0xDED114", Offset = "0xDED114", VA = "0xDED114")]
	public void AddMusicIntensity(int _stage)
	{
	}

	[Token(Token = "0x6000617")]
	[Address(RVA = "0xDED2F8", Offset = "0xDED2F8", VA = "0xDED2F8", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x6000618")]
	[Address(RVA = "0xDED380", Offset = "0xDED380", VA = "0xDED380", Slot = "19")]
	public override void GameFinished([Optional] string finishText, bool won = true, LosingReason reason = LosingReason.Null)
	{
	}

	[Token(Token = "0x6000619")]
	[Address(RVA = "0xDED3AC", Offset = "0xDED3AC", VA = "0xDED3AC")]
	public Level5GPM()
	{
	}
}
[Token(Token = "0x20000FD")]
public class Level6GPM : GamePlayManager
{
	[Token(Token = "0x20000FE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE454", Offset = "0x9AE454")]
	private sealed class <WaitUntilLevelStart>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level6GPM <>4__this;

		[Token(Token = "0x17000110")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600062A")]
			[Address(RVA = "0xF65940", Offset = "0xF65940", VA = "0xF65940", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000111")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600062C")]
			[Address(RVA = "0xF65988", Offset = "0xF65988", VA = "0xF65988", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xF657B4", Offset = "0xF657B4", VA = "0xF657B4")]
		[DebuggerHidden]
		public <WaitUntilLevelStart>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xF657E0", Offset = "0xF657E0", VA = "0xF657E0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xF657E4", Offset = "0xF657E4", VA = "0xF657E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xF65948", Offset = "0xF65948", VA = "0xF65948", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000622")]
	[Address(RVA = "0xDED3B0", Offset = "0xDED3B0", VA = "0xDED3B0", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000623")]
	[Address(RVA = "0xDED3E4", Offset = "0xDED3E4", VA = "0xDED3E4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B4C00", Offset = "0x9B4C00")]
	private IEnumerator WaitUntilLevelStart()
	{
		return null;
	}

	[Token(Token = "0x6000624")]
	[Address(RVA = "0xDED450", Offset = "0xDED450", VA = "0xDED450", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x6000625")]
	[Address(RVA = "0xDED4E8", Offset = "0xDED4E8", VA = "0xDED4E8")]
	public Level6GPM()
	{
	}

	[Token(Token = "0x6000626")]
	[Address(RVA = "0xDED4EC", Offset = "0xDED4EC", VA = "0xDED4EC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B4C60", Offset = "0x9B4C60")]
	private bool <WaitUntilLevelStart>b__1_0()
	{
		return default(bool);
	}
}
[Token(Token = "0x20000FF")]
public class Level7GPM : GamePlayManager
{
	[Token(Token = "0x2000100")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE464", Offset = "0x9AE464")]
	private sealed class <WaitUntilLevelStart>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level7GPM <>4__this;

		[Token(Token = "0x17000112")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000635")]
			[Address(RVA = "0xF65ACC", Offset = "0xF65ACC", VA = "0xF65ACC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000113")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000637")]
			[Address(RVA = "0xF65B14", Offset = "0xF65B14", VA = "0xF65B14", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xF65990", Offset = "0xF65990", VA = "0xF65990")]
		[DebuggerHidden]
		public <WaitUntilLevelStart>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xF659BC", Offset = "0xF659BC", VA = "0xF659BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xF659C0", Offset = "0xF659C0", VA = "0xF659C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xF65AD4", Offset = "0xF65AD4", VA = "0xF65AD4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000566")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public AudioHandler quokkaTutorialAudioHandler;

	[Token(Token = "0x600062D")]
	[Address(RVA = "0xDED524", Offset = "0xDED524", VA = "0xDED524", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600062E")]
	[Address(RVA = "0xDED5EC", Offset = "0xDED5EC", VA = "0xDED5EC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B4CC0", Offset = "0x9B4CC0")]
	private IEnumerator WaitUntilLevelStart()
	{
		return null;
	}

	[Token(Token = "0x600062F")]
	[Address(RVA = "0xDED658", Offset = "0xDED658", VA = "0xDED658", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x6000630")]
	[Address(RVA = "0xDED6F0", Offset = "0xDED6F0", VA = "0xDED6F0")]
	public Level7GPM()
	{
	}

	[Token(Token = "0x6000631")]
	[Address(RVA = "0xDED6F4", Offset = "0xDED6F4", VA = "0xDED6F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B4D20", Offset = "0x9B4D20")]
	private bool <WaitUntilLevelStart>b__2_0()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000101")]
public class Level8GPM : GamePlayManager
{
	[Token(Token = "0x2000102")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE474", Offset = "0x9AE474")]
	private sealed class <WaitUntilLevelStart>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level8GPM <>4__this;

		[Token(Token = "0x17000114")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000640")]
			[Address(RVA = "0xF65CA8", Offset = "0xF65CA8", VA = "0xF65CA8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000115")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000642")]
			[Address(RVA = "0xF65CF0", Offset = "0xF65CF0", VA = "0xF65CF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xF65B1C", Offset = "0xF65B1C", VA = "0xF65B1C")]
		[DebuggerHidden]
		public <WaitUntilLevelStart>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xF65B48", Offset = "0xF65B48", VA = "0xF65B48", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xF65B4C", Offset = "0xF65B4C", VA = "0xF65B4C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xF65CB0", Offset = "0xF65CB0", VA = "0xF65CB0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000638")]
	[Address(RVA = "0xDED72C", Offset = "0xDED72C", VA = "0xDED72C", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000639")]
	[Address(RVA = "0xDED760", Offset = "0xDED760", VA = "0xDED760")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B4D80", Offset = "0x9B4D80")]
	private IEnumerator WaitUntilLevelStart()
	{
		return null;
	}

	[Token(Token = "0x600063A")]
	[Address(RVA = "0xDED7CC", Offset = "0xDED7CC", VA = "0xDED7CC", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x600063B")]
	[Address(RVA = "0xDED864", Offset = "0xDED864", VA = "0xDED864")]
	public Level8GPM()
	{
	}

	[Token(Token = "0x600063C")]
	[Address(RVA = "0xDED868", Offset = "0xDED868", VA = "0xDED868")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B4DE0", Offset = "0x9B4DE0")]
	private bool <WaitUntilLevelStart>b__1_0()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000103")]
public class Level9GPM : GamePlayManager
{
	[Token(Token = "0x6000643")]
	[Address(RVA = "0xDED8A0", Offset = "0xDED8A0", VA = "0xDED8A0", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x6000644")]
	[Address(RVA = "0xDED93C", Offset = "0xDED93C", VA = "0xDED93C")]
	public Level9GPM()
	{
	}
}
[Token(Token = "0x2000104")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x9AE484", Offset = "0x9AE484")]
public class LevelInfo : ScriptableObject
{
	[Token(Token = "0x2000105")]
	public enum ObjectiveKeys
	{
		[Token(Token = "0x4000575")]
		WhackXEnemies,
		[Token(Token = "0x4000576")]
		CatchXBoomerangs,
		[Token(Token = "0x4000577")]
		LookAwesome,
		[Token(Token = "0x4000578")]
		DontLoseDrinks,
		[Token(Token = "0x4000579")]
		KeepXDrinksCold,
		[Token(Token = "0x400057A")]
		DontThrowBoomerangs,
		[Token(Token = "0x400057B")]
		CatchAllBoomerangsYouThrow,
		[Token(Token = "0x400057C")]
		DontLoseHP,
		[Token(Token = "0x400057D")]
		PunchBigKangarooXTimes,
		[Token(Token = "0x400057E")]
		DontHurtKoalas,
		[Token(Token = "0x400057F")]
		ServeXDrinks,
		[Token(Token = "0x4000580")]
		PhotographXQuokkas,
		[Token(Token = "0x4000581")]
		DontLetParachutersTouchTheGround,
		[Token(Token = "0x4000582")]
		DontMissAnyRequest,
		[Token(Token = "0x4000583")]
		ServeXRequests,
		[Token(Token = "0x4000584")]
		ServeXBurgers,
		[Token(Token = "0x4000585")]
		ServeXSnags,
		[Token(Token = "0x4000586")]
		ServeXSkewers,
		[Token(Token = "0x4000587")]
		StayWithinPicnicArea,
		[Token(Token = "0x4000588")]
		DontCatchAnyBoomerangsYouThrow,
		[Token(Token = "0x4000589")]
		DontBreakAnyBottle,
		[Token(Token = "0x400058A")]
		LoseLessThanXDrinks,
		[Token(Token = "0x400058B")]
		DefeatX,
		[Token(Token = "0x400058C")]
		ServeYourFriends,
		[Token(Token = "0x400058D")]
		ProtectYourDrinks,
		[Token(Token = "0x400058E")]
		DontGetKnockedOut,
		[Token(Token = "0x400058F")]
		WhackEnemies,
		[Token(Token = "0x4000590")]
		HitXTargets,
		[Token(Token = "0x4000591")]
		SaveAustraliasHonor,
		[Token(Token = "0x4000592")]
		PutAnEndToTheMeme,
		[Token(Token = "0x4000593")]
		WatchTrailer,
		[Token(Token = "0x4000594")]
		CatchABoomerang,
		[Token(Token = "0x4000595")]
		DefeatCanGuru,
		[Token(Token = "0x4000596")]
		DefeatMole,
		[Token(Token = "0x4000597")]
		DefeatEmu
	}

	[Serializable]
	[Token(Token = "0x2000106")]
	public class Objective
	{
		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ObjectiveKeys key;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string xValue;

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xF65D08", Offset = "0xF65D08", VA = "0xF65D08")]
		public Objective()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000107")]
	public class LosingConditions
	{
		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int gameDurationSeconds;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int beersToLose;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int requestsToLose;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[HideInInspector]
		public int playerHealth;

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xF65CF8", Offset = "0xF65CF8", VA = "0xF65CF8")]
		public LosingConditions()
		{
		}
	}

	[Token(Token = "0x400056D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AF2C0", Offset = "0x9AF2C0")]
	public bool attemptOfBBQ;

	[Token(Token = "0x400056E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int numberOfLevel;

	[Token(Token = "0x400056F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string nameOfScene;

	[Token(Token = "0x4000570")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public string nameOfLevel;

	[Token(Token = "0x4000571")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public LosingConditions levelConditions;

	[Token(Token = "0x4000572")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool bossFight;

	[Token(Token = "0x4000573")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Objective[] levelOjectives;

	[Token(Token = "0x6000645")]
	[Address(RVA = "0xDE65D4", Offset = "0xDE65D4", VA = "0xDE65D4")]
	public void SetObjectiveText(int objectiveIndex, TextMeshProUGUI tmp)
	{
	}

	[Token(Token = "0x6000646")]
	[Address(RVA = "0xDEDBDC", Offset = "0xDEDBDC", VA = "0xDEDBDC")]
	public void SetTitleText(TextMeshProUGUI tmp)
	{
	}

	[Token(Token = "0x6000647")]
	[Address(RVA = "0xDEDC8C", Offset = "0xDEDC8C", VA = "0xDEDC8C")]
	public LevelInfo()
	{
	}
}
[Token(Token = "0x2000108")]
public class Tutorial1GPM : GamePlayManager
{
	[Token(Token = "0x400059E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public int nOfEnemiesForGameFinish;

	[Token(Token = "0x400059F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public GameObject targetCounterPrefab;

	[Token(Token = "0x40005A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private int hitCounter;

	[Token(Token = "0x40005A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9AF318", Offset = "0x9AF318")]
	public bool hasCaughtBoomerang;

	[Token(Token = "0x600064A")]
	[Address(RVA = "0x2745050", Offset = "0x2745050", VA = "0x2745050", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600064B")]
	[Address(RVA = "0x2745204", Offset = "0x2745204", VA = "0x2745204", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x600064C")]
	[Address(RVA = "0x2745264", Offset = "0x2745264", VA = "0x2745264")]
	public void CountTargetsHit(Enemy _enemy)
	{
	}

	[Token(Token = "0x600064D")]
	[Address(RVA = "0x2745478", Offset = "0x2745478", VA = "0x2745478")]
	private void OnBoomerangCatch(Boomerang _boomerang)
	{
	}

	[Token(Token = "0x600064E")]
	[Address(RVA = "0x2745484", Offset = "0x2745484", VA = "0x2745484", Slot = "11")]
	protected override void KillEnemy(Enemy _enemy)
	{
	}

	[Token(Token = "0x600064F")]
	[Address(RVA = "0x27454D0", Offset = "0x27454D0", VA = "0x27454D0")]
	private void FinishTutorial()
	{
	}

	[Token(Token = "0x6000650")]
	[Address(RVA = "0x2745530", Offset = "0x2745530", VA = "0x2745530")]
	public void LitteredApple()
	{
	}

	[Token(Token = "0x6000651")]
	[Address(RVA = "0x27455F8", Offset = "0x27455F8", VA = "0x27455F8")]
	public Tutorial1GPM()
	{
	}
}
[Token(Token = "0x2000109")]
public class AussiePlayer : Singleton<AussiePlayer>
{
	[Token(Token = "0x40005A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CharacterController characterController;

	[Token(Token = "0x40005A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private HVRPlayerController playerController;

	[Token(Token = "0x40005A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private HVRPlayerInputs playerInputs;

	[Token(Token = "0x40005A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public HVRTeleporter playerTeleporter;

	[Token(Token = "0x40005A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI subtitlesHolder;

	[Token(Token = "0x40005A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	public HVRHandGrabber rightHand;

	[Token(Token = "0x40005A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	public HVRHandGrabber leftHand;

	[Token(Token = "0x40005A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<HVRUIPointer> pointersToEnableOnUnpause;

	[Token(Token = "0x40005AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<Canvas> canvasToEnableOnUnpause;

	[Token(Token = "0x40005AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<Canvas> allHandCanvases;

	[Token(Token = "0x40005AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<Collider> handColliders;

	[Token(Token = "0x40005AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Material handMaterial;

	[Token(Token = "0x6000652")]
	[Address(RVA = "0xD295AC", Offset = "0xD295AC", VA = "0xD295AC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000653")]
	[Address(RVA = "0xD29834", Offset = "0xD29834", VA = "0xD29834")]
	public void SetPlayerSettings()
	{
	}

	[Token(Token = "0x6000654")]
	[Address(RVA = "0xD2397C", Offset = "0xD2397C", VA = "0xD2397C")]
	public void DropEverything()
	{
	}

	[Token(Token = "0x6000655")]
	[Address(RVA = "0xD29A78", Offset = "0xD29A78", VA = "0xD29A78")]
	private void FindHands()
	{
	}

	[Token(Token = "0x6000656")]
	[Address(RVA = "0xD29B34", Offset = "0xD29B34", VA = "0xD29B34")]
	public void PauseHands()
	{
	}

	[Token(Token = "0x6000657")]
	[Address(RVA = "0xD29F28", Offset = "0xD29F28", VA = "0xD29F28")]
	public void UnPauseHands()
	{
	}

	[Token(Token = "0x6000658")]
	[Address(RVA = "0xD29E2C", Offset = "0xD29E2C", VA = "0xD29E2C")]
	private List<Canvas> GetHandCanvas()
	{
		return null;
	}

	[Token(Token = "0x6000659")]
	[Address(RVA = "0xD2A264", Offset = "0xD2A264", VA = "0xD2A264")]
	private List<Collider> GetHandColliders()
	{
		return null;
	}

	[Token(Token = "0x600065A")]
	[Address(RVA = "0xD2A360", Offset = "0xD2A360", VA = "0xD2A360")]
	public AussiePlayer()
	{
	}
}
[Token(Token = "0x200010A")]
public class DontDestroyHatOnLoad : MonoBehaviour
{
	[Token(Token = "0x40005AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private HVRGrabbable hatGrabbable;

	[Token(Token = "0x40005AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject actualHat;

	[Token(Token = "0x600065B")]
	[Address(RVA = "0xD37FA0", Offset = "0xD37FA0", VA = "0xD37FA0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600065C")]
	[Address(RVA = "0xD38018", Offset = "0xD38018", VA = "0xD38018")]
	private void Start()
	{
	}

	[Token(Token = "0x600065D")]
	[Address(RVA = "0xD3806C", Offset = "0xD3806C", VA = "0xD3806C")]
	private void OnLevelWasLoaded(int level)
	{
	}

	[Token(Token = "0x600065E")]
	[Address(RVA = "0xD38200", Offset = "0xD38200", VA = "0xD38200")]
	public DontDestroyHatOnLoad()
	{
	}
}
[Token(Token = "0x200010B")]
public class HellLever : MonoBehaviour
{
	[Token(Token = "0x40005B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject failSign;

	[Token(Token = "0x600065F")]
	[Address(RVA = "0xDE828C", Offset = "0xDE828C", VA = "0xDE828C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000660")]
	[Address(RVA = "0xDE836C", Offset = "0xDE836C", VA = "0xDE836C")]
	private void OnHellLever(int i)
	{
	}

	[Token(Token = "0x6000661")]
	[Address(RVA = "0xDE8424", Offset = "0xDE8424", VA = "0xDE8424")]
	public HellLever()
	{
	}
}
[Token(Token = "0x200010C")]
public class HellPlane : MonoBehaviour
{
	[Token(Token = "0x40005B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool onHisWay;

	[Token(Token = "0x6000662")]
	[Address(RVA = "0xDE842C", Offset = "0xDE842C", VA = "0xDE842C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000663")]
	[Address(RVA = "0xDE855C", Offset = "0xDE855C", VA = "0xDE855C")]
	public HellPlane()
	{
	}
}
[Token(Token = "0x200010D")]
public class MusicInstrument : MonoBehaviour
{
	[Token(Token = "0x40005B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private HVRGrabbable grabbable;

	[Token(Token = "0x40005B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioHandler AudioHandler;

	[Token(Token = "0x40005B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform headTransform;

	[Token(Token = "0x40005B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isPlaying;

	[Token(Token = "0x40005B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float distanceToTrigger;

	[Token(Token = "0x40005B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string soundName;

	[Token(Token = "0x40005B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject particlesObject;

	[Token(Token = "0x6000664")]
	[Address(RVA = "0x273221C", Offset = "0x273221C", VA = "0x273221C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000665")]
	[Address(RVA = "0x2732308", Offset = "0x2732308", VA = "0x2732308")]
	private void Update()
	{
	}

	[Token(Token = "0x6000666")]
	[Address(RVA = "0x2732474", Offset = "0x2732474", VA = "0x2732474")]
	public MusicInstrument()
	{
	}
}
[Token(Token = "0x200010E")]
public class PicNicArea : MonoBehaviour
{
	[Token(Token = "0x200010F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE4D0", Offset = "0x9AE4D0")]
	private sealed class <WaitThenSetStartChecking>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float waitTime;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PicNicArea <>4__this;

		[Token(Token = "0x17000116")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600066E")]
			[Address(RVA = "0xF6A628", Offset = "0xF6A628", VA = "0xF6A628", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000117")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000670")]
			[Address(RVA = "0xF6A670", Offset = "0xF6A670", VA = "0xF6A670", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xF6A540", Offset = "0xF6A540", VA = "0xF6A540")]
		[DebuggerHidden]
		public <WaitThenSetStartChecking>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xF6A56C", Offset = "0xF6A56C", VA = "0xF6A56C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xF6A570", Offset = "0xF6A570", VA = "0xF6A570", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xF6A630", Offset = "0xF6A630", VA = "0xF6A630", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40005B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool leftArea;

	[Token(Token = "0x40005BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool startChecking;

	[Token(Token = "0x6000667")]
	[Address(RVA = "0x2735724", Offset = "0x2735724", VA = "0x2735724")]
	private void Start()
	{
	}

	[Token(Token = "0x6000668")]
	[Address(RVA = "0x27357D0", Offset = "0x27357D0", VA = "0x27357D0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000669")]
	[Address(RVA = "0x2735754", Offset = "0x2735754", VA = "0x2735754")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B4E40", Offset = "0x9B4E40")]
	private IEnumerator WaitThenSetStartChecking(float waitTime)
	{
		return null;
	}

	[Token(Token = "0x600066A")]
	[Address(RVA = "0x27357E4", Offset = "0x27357E4", VA = "0x27357E4")]
	public PicNicArea()
	{
	}
}
[Token(Token = "0x2000110")]
public class SetAimToPlayer : MonoBehaviour
{
	[Token(Token = "0x40005BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MultiAimConstraint multiAimConstraint;

	[Token(Token = "0x40005C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RigBuilder rigBuilder;

	[Token(Token = "0x40005C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AF370", Offset = "0x9AF370")]
	public float weight;

	[Token(Token = "0x6000671")]
	[Address(RVA = "0x2741324", Offset = "0x2741324", VA = "0x2741324")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000672")]
	[Address(RVA = "0x2741378", Offset = "0x2741378", VA = "0x2741378")]
	private void Start()
	{
	}

	[Token(Token = "0x6000673")]
	[Address(RVA = "0x27414F4", Offset = "0x27414F4", VA = "0x27414F4")]
	public SetAimToPlayer()
	{
	}
}
[Token(Token = "0x2000111")]
[DisallowMultipleComponent]
public class SteamManager : MonoBehaviour
{
	[Token(Token = "0x17000118")]
	public static bool Initialized
	{
		[Token(Token = "0x6000674")]
		[Address(RVA = "0x2742BDC", Offset = "0x2742BDC", VA = "0x2742BDC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000675")]
	[Address(RVA = "0x2742BE4", Offset = "0x2742BE4", VA = "0x2742BE4")]
	public SteamManager()
	{
	}
}
[Token(Token = "0x2000112")]
public class ActivatableGrabIndicator : MonoBehaviour
{
	[Token(Token = "0x40005C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject grabIndicator;

	[Token(Token = "0x40005C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Image icon;

	[Token(Token = "0x40005C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Sprite> optionalIconPerChildren;

	[Token(Token = "0x6000676")]
	[Address(RVA = "0xD22998", Offset = "0xD22998", VA = "0xD22998")]
	private void Start()
	{
	}

	[Token(Token = "0x6000677")]
	[Address(RVA = "0xD22A3C", Offset = "0xD22A3C", VA = "0xD22A3C")]
	public void Activate()
	{
	}

	[Token(Token = "0x6000678")]
	[Address(RVA = "0xD22A5C", Offset = "0xD22A5C", VA = "0xD22A5C")]
	public void Deactivate()
	{
	}

	[Token(Token = "0x6000679")]
	[Address(RVA = "0xD22A7C", Offset = "0xD22A7C", VA = "0xD22A7C")]
	public void ShowGrabIndicator()
	{
	}

	[Token(Token = "0x600067A")]
	[Address(RVA = "0xD22B5C", Offset = "0xD22B5C", VA = "0xD22B5C")]
	public void HideGrabIndicator()
	{
	}

	[Token(Token = "0x600067B")]
	[Address(RVA = "0xD22B7C", Offset = "0xD22B7C", VA = "0xD22B7C")]
	public ActivatableGrabIndicator()
	{
	}
}
[Token(Token = "0x2000113")]
public enum ArcadeMode
{
	[Token(Token = "0x40005C6")]
	DEFENSE,
	[Token(Token = "0x40005C7")]
	COOKING,
	[Token(Token = "0x40005C8")]
	TUTORIAL
}
[Token(Token = "0x2000114")]
public enum ScoreType
{
	[Token(Token = "0x40005CA")]
	INT,
	[Token(Token = "0x40005CB")]
	TIME
}
[Token(Token = "0x2000115")]
public enum OnlineLeaderboardType
{
	[Token(Token = "0x40005CD")]
	NONE,
	[Token(Token = "0x40005CE")]
	GLOBAL_RANK,
	[Token(Token = "0x40005CF")]
	AROUND_ME,
	[Token(Token = "0x40005D0")]
	FRIENDS,
	[Token(Token = "0x40005D1")]
	FRIENDS_AROUND_ME
}
[Token(Token = "0x2000116")]
public class ArcadeMenuUI : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000117")]
	public class ArcadeModeDetails
	{
		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ArcadeMode mode;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LevelInfo arcadeInfo;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Toggle modeButton;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool isLocked;

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xED684C", Offset = "0xED684C", VA = "0xED684C")]
		public ArcadeModeDetails()
		{
		}
	}

	[Token(Token = "0x2000118")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE4F0", Offset = "0x9AE4F0")]
	private sealed class <>c__DisplayClass20_0
	{
		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ArcadeModeDetails details;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ArcadeMenuUI <>4__this;

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xED6818", Offset = "0xED6818", VA = "0xED6818")]
		public <>c__DisplayClass20_0()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xED6820", Offset = "0xED6820", VA = "0xED6820")]
		internal void <Start>b__0(bool value)
		{
		}
	}

	[Token(Token = "0x40005D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject arcadeDetailsMenu;

	[Token(Token = "0x40005D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI arcadeDetailsTitle;

	[Token(Token = "0x40005D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI arcadeDetailsObj1;

	[Token(Token = "0x40005D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI arcadeDetailsObj2;

	[Token(Token = "0x40005D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI arcadeDetailsObj3;

	[Token(Token = "0x40005D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI playerHealth;

	[Token(Token = "0x40005D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI beersToLose;

	[Token(Token = "0x40005D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextMeshProUGUI requestsToLose;

	[Token(Token = "0x40005DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[HideInInspector]
	private Animator arcadeDetailsAnimator;

	[Token(Token = "0x40005DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int arcadeStartWaveIndex;

	[Token(Token = "0x40005DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TextMeshProUGUI arcadeStartWaveNumber;

	[Token(Token = "0x40005DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Button arcadeStartWaveIncrease;

	[Token(Token = "0x40005DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Button arcadeStartWaveDecrease;

	[Token(Token = "0x40005DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private int[] arcadeStartWaveOptions;

	[Token(Token = "0x40005E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<ArcadeModeDetails> arcadeModeDetails;

	[Token(Token = "0x40005E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public ArcadeModeDetails selectedMode;

	[Token(Token = "0x40005E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public OnlineLeaderboard onlineLeaderboard;

	[Token(Token = "0x40005E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public LocalLeaderboard localLeaderboard;

	[Token(Token = "0x40005E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private bool hideOnlineLeaderboard;

	[Token(Token = "0x600067C")]
	[Address(RVA = "0xD2474C", Offset = "0xD2474C", VA = "0xD2474C")]
	private void Start()
	{
	}

	[Token(Token = "0x600067D")]
	[Address(RVA = "0xD24E48", Offset = "0xD24E48", VA = "0xD24E48")]
	private void ToggleValueChanged(ArcadeModeDetails mode, bool value)
	{
	}

	[Token(Token = "0x600067E")]
	[Address(RVA = "0xD24B34", Offset = "0xD24B34", VA = "0xD24B34")]
	public void ChangeArcadeMode(ArcadeModeDetails mode)
	{
	}

	[Token(Token = "0x600067F")]
	[Address(RVA = "0xD24EFC", Offset = "0xD24EFC", VA = "0xD24EFC")]
	private void ResetStartWave()
	{
	}

	[Token(Token = "0x6000680")]
	[Address(RVA = "0xD25098", Offset = "0xD25098", VA = "0xD25098")]
	public void IncreaseStartWave()
	{
	}

	[Token(Token = "0x6000681")]
	[Address(RVA = "0xD2524C", Offset = "0xD2524C", VA = "0xD2524C")]
	public void DecreaseStartWave()
	{
	}

	[Token(Token = "0x6000682")]
	[Address(RVA = "0xD2531C", Offset = "0xD2531C", VA = "0xD2531C")]
	public void StartArcade()
	{
	}

	[Token(Token = "0x6000683")]
	[Address(RVA = "0xD24E54", Offset = "0xD24E54", VA = "0xD24E54")]
	private Animator GetArcadeDetailsAnimator()
	{
		return null;
	}

	[Token(Token = "0x6000684")]
	[Address(RVA = "0xD2542C", Offset = "0xD2542C", VA = "0xD2542C")]
	private void UpdateSignsLanguage()
	{
	}

	[Token(Token = "0x6000685")]
	[Address(RVA = "0xD25530", Offset = "0xD25530", VA = "0xD25530")]
	public ArcadeMenuUI()
	{
	}
}
[Token(Token = "0x2000119")]
public class ArcadePointsDisplayer : MonoBehaviour
{
	[Token(Token = "0x200011A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE500", Offset = "0x9AE500")]
	private sealed class <WaitToDestroy>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ArcadePointsDisplayer <>4__this;

		[Token(Token = "0x17000119")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0xED6968", Offset = "0xED6968", VA = "0xED6968", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000692")]
			[Address(RVA = "0xED69B0", Offset = "0xED69B0", VA = "0xED69B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xED6854", Offset = "0xED6854", VA = "0xED6854")]
		[DebuggerHidden]
		public <WaitToDestroy>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xED6880", Offset = "0xED6880", VA = "0xED6880", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xED6884", Offset = "0xED6884", VA = "0xED6884", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xED6970", Offset = "0xED6970", VA = "0xED6970", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40005EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI pointsText;

	[Token(Token = "0x40005ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI multiplierText;

	[Token(Token = "0x40005EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI adderText;

	[Token(Token = "0x40005EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Color[] colorPerMultiplier;

	[Token(Token = "0x40005F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Image multiplierBG;

	[Token(Token = "0x40005F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject particles;

	[Token(Token = "0x6000689")]
	[Address(RVA = "0xD243F4", Offset = "0xD243F4", VA = "0xD243F4")]
	public void DisplayPoints(int points, int multiplier, int extraPoints)
	{
	}

	[Token(Token = "0x600068A")]
	[Address(RVA = "0xD24000", Offset = "0xD24000", VA = "0xD24000")]
	public void DisplayPoints(int points, int multiplier)
	{
	}

	[Token(Token = "0x600068B")]
	[Address(RVA = "0xD255B0", Offset = "0xD255B0", VA = "0xD255B0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B4EF0", Offset = "0x9B4EF0")]
	private IEnumerator WaitToDestroy()
	{
		return null;
	}

	[Token(Token = "0x600068C")]
	[Address(RVA = "0xD25888", Offset = "0xD25888", VA = "0xD25888")]
	public ArcadePointsDisplayer()
	{
	}
}
[Token(Token = "0x200011B")]
public class AudioSettingsSlider : MonoBehaviour
{
	[Token(Token = "0x40005F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Slider slider;

	[Token(Token = "0x40005F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI valueText;

	[Token(Token = "0x40005F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SoundType soundType;

	[Token(Token = "0x40005F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioHandler[] audioHandlers;

	[Token(Token = "0x40005F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int initialValue;

	[Token(Token = "0x6000693")]
	[Address(RVA = "0xD286B4", Offset = "0xD286B4", VA = "0xD286B4")]
	public void Start()
	{
	}

	[Token(Token = "0x6000694")]
	[Address(RVA = "0xD28830", Offset = "0xD28830", VA = "0xD28830")]
	private AudioHandler[] GetAudioHandlers()
	{
		return null;
	}

	[Token(Token = "0x6000695")]
	[Address(RVA = "0xD289C0", Offset = "0xD289C0", VA = "0xD289C0")]
	private float TranslateToFloat(int _value)
	{
		return default(float);
	}

	[Token(Token = "0x6000696")]
	[Address(RVA = "0xD287E4", Offset = "0xD287E4", VA = "0xD287E4")]
	private int TranslateToInt(float _value)
	{
		return default(int);
	}

	[Token(Token = "0x6000697")]
	[Address(RVA = "0xD289F8", Offset = "0xD289F8", VA = "0xD289F8")]
	private void UpdateSoundVolume(float multipler)
	{
	}

	[Token(Token = "0x6000698")]
	[Address(RVA = "0xD28A94", Offset = "0xD28A94", VA = "0xD28A94")]
	public void UpdateValue()
	{
	}

	[Token(Token = "0x6000699")]
	[Address(RVA = "0xD28C28", Offset = "0xD28C28", VA = "0xD28C28")]
	public AudioSettingsSlider()
	{
	}

	[Token(Token = "0x600069A")]
	[Address(RVA = "0xD28C30", Offset = "0xD28C30", VA = "0xD28C30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B4FA0", Offset = "0x9B4FA0")]
	private bool <GetAudioHandlers>b__6_0(AudioHandler h)
	{
		return default(bool);
	}
}
[Token(Token = "0x200011C")]
public class ChangeHandMaterial : MonoBehaviour
{
	[Token(Token = "0x40005FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private FlexibleColorPicker colorPicker;

	[Token(Token = "0x40005FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<UpdateHandMaterial> handMaterials;

	[Token(Token = "0x600069B")]
	[Address(RVA = "0xD33850", Offset = "0xD33850", VA = "0xD33850")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600069C")]
	[Address(RVA = "0xD33910", Offset = "0xD33910", VA = "0xD33910")]
	public void ColorChange(Color color)
	{
	}

	[Token(Token = "0x600069D")]
	[Address(RVA = "0xD33BE0", Offset = "0xD33BE0", VA = "0xD33BE0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600069E")]
	[Address(RVA = "0xD33B08", Offset = "0xD33B08", VA = "0xD33B08")]
	private List<UpdateHandMaterial> GetUpdateHandMaterials()
	{
		return null;
	}

	[Token(Token = "0x600069F")]
	[Address(RVA = "0xD33C84", Offset = "0xD33C84", VA = "0xD33C84")]
	public ChangeHandMaterial()
	{
	}
}
[Token(Token = "0x200011D")]
public class CloneRequestSlotsFinder : MonoBehaviour
{
	[Token(Token = "0x60006A0")]
	[Address(RVA = "0xD33C8C", Offset = "0xD33C8C", VA = "0xD33C8C")]
	private void Start()
	{
	}

	[Token(Token = "0x60006A1")]
	[Address(RVA = "0xD33C90", Offset = "0xD33C90", VA = "0xD33C90")]
	private void Update()
	{
	}

	[Token(Token = "0x60006A2")]
	[Address(RVA = "0xD33C94", Offset = "0xD33C94", VA = "0xD33C94")]
	public CloneRequestSlotsFinder()
	{
	}
}
[Token(Token = "0x200011E")]
public class Credits : MonoBehaviour
{
	[Token(Token = "0x200011F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE510", Offset = "0x9AE510")]
	private sealed class <ChangePage>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Credits <>4__this;

		[Token(Token = "0x1700011B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0xEDC36C", Offset = "0xEDC36C", VA = "0xEDC36C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0xEDC3B4", Offset = "0xEDC3B4", VA = "0xEDC3B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xEDC0C0", Offset = "0xEDC0C0", VA = "0xEDC0C0")]
		[DebuggerHidden]
		public <ChangePage>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xEDC0EC", Offset = "0xEDC0EC", VA = "0xEDC0EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xEDC0F0", Offset = "0xEDC0F0", VA = "0xEDC0F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xEDC374", Offset = "0xEDC374", VA = "0xEDC374", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40005FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float timeUntilFirstChange;

	[Token(Token = "0x40005FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float timeBetweenCredits;

	[Token(Token = "0x40005FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Animator animator;

	[Token(Token = "0x40005FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0x9AF398", Offset = "0x9AF398")]
	public List<string> creditsPages;

	[Token(Token = "0x4000600")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<string[]> _creditsPageSplit;

	[Token(Token = "0x4000601")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int currentPage;

	[Token(Token = "0x4000602")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private TextMeshProUGUI[] lines;

	[Token(Token = "0x60006A3")]
	[Address(RVA = "0xD35334", Offset = "0xD35334", VA = "0xD35334")]
	private void Start()
	{
	}

	[Token(Token = "0x60006A4")]
	[Address(RVA = "0xD35684", Offset = "0xD35684", VA = "0xD35684")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B4FB0", Offset = "0x9B4FB0")]
	private IEnumerator ChangePage(float delay)
	{
		return null;
	}

	[Token(Token = "0x60006A5")]
	[Address(RVA = "0xD35700", Offset = "0xD35700", VA = "0xD35700")]
	private void Translate(string _text, TextMeshProUGUI _line)
	{
	}

	[Token(Token = "0x60006A6")]
	[Address(RVA = "0xD35870", Offset = "0xD35870", VA = "0xD35870")]
	public Credits()
	{
	}
}
[Token(Token = "0x2000120")]
public class DisplayUnlockedItem : MonoBehaviour
{
	[Token(Token = "0x2000121")]
	public enum ItemsToUnlock
	{
		[Token(Token = "0x400060D")]
		None,
		[Token(Token = "0x400060E")]
		Beer_skin_2,
		[Token(Token = "0x400060F")]
		Beer_skin_3,
		[Token(Token = "0x4000610")]
		Beer_skin_4,
		[Token(Token = "0x4000611")]
		Beer_skin_5,
		[Token(Token = "0x4000612")]
		Boomerang_2,
		[Token(Token = "0x4000613")]
		Boomerang_3,
		[Token(Token = "0x4000614")]
		Boomerang_4
	}

	[Serializable]
	[Token(Token = "0x2000122")]
	public class Item
	{
		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ItemsToUnlock itemType;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int starsToUnlock;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material material;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BeerSkin skin;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Mesh mesh;

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xEDD1C8", Offset = "0xEDD1C8", VA = "0xEDD1C8")]
		public Item()
		{
		}
	}

	[Token(Token = "0x4000607")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Item> availableItems;

	[Token(Token = "0x4000608")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Item possibleItemToUnlock;

	[Token(Token = "0x4000609")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int starsBeforeLevel;

	[Token(Token = "0x400060A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int previousAttemptStars;

	[Token(Token = "0x400060B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public MeshRenderer itemRenderer;

	[Token(Token = "0x60006AD")]
	[Address(RVA = "0xD376B4", Offset = "0xD376B4", VA = "0xD376B4")]
	private void Start()
	{
	}

	[Token(Token = "0x60006AE")]
	[Address(RVA = "0xD37C0C", Offset = "0xD37C0C", VA = "0xD37C0C")]
	public void CheckUnlockItem()
	{
	}

	[Token(Token = "0x60006AF")]
	[Address(RVA = "0xD37EF0", Offset = "0xD37EF0", VA = "0xD37EF0")]
	public DisplayUnlockedItem()
	{
	}
}
[Token(Token = "0x2000123")]
public class FinishUI : MonoBehaviour
{
	[Token(Token = "0x400061A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AF3B0", Offset = "0x9AF3B0")]
	public TextMeshProUGUI statsText;

	[Token(Token = "0x400061B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GamePlayManager gamePlayManager;

	[Token(Token = "0x60006B1")]
	[Address(RVA = "0xDDFB60", Offset = "0xDDFB60", VA = "0xDDFB60")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60006B2")]
	[Address(RVA = "0xDDFEAC", Offset = "0xDDFEAC", VA = "0xDDFEAC")]
	public FinishUI()
	{
	}
}
[Token(Token = "0x2000124")]
public class FinishedSign : MonoBehaviour
{
	[Token(Token = "0x400061C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI titleText;

	[Token(Token = "0x400061D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject failedSign;

	[Token(Token = "0x400061E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI failedSignText;

	[Token(Token = "0x400061F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AudioHandler audioHandler;

	[Token(Token = "0x4000620")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Animator animator;

	[Token(Token = "0x4000621")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI[] objectivesTexts;

	[Token(Token = "0x4000622")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject[] objectivesChecks;

	[Token(Token = "0x4000623")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject[] stars;

	[Token(Token = "0x4000624")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject continueText;

	[Token(Token = "0x4000625")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject backToMenuText;

	[Token(Token = "0x4000626")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject levelConditionsBar;

	[Token(Token = "0x4000627")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public TextMeshProUGUI levelTime;

	[Token(Token = "0x4000628")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public TextMeshProUGUI healthLost;

	[Token(Token = "0x4000629")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public TextMeshProUGUI beersLost;

	[Token(Token = "0x400062A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public TextMeshProUGUI requestsLost;

	[Token(Token = "0x400062B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public SpriteRenderer healthLostIcon;

	[Token(Token = "0x400062C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public SpriteRenderer beersLostIcon;

	[Token(Token = "0x400062D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public SpriteRenderer requestsLostIcon;

	[Token(Token = "0x400062E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public OnlineLeaderboard leaderboard;

	[Token(Token = "0x60006B3")]
	[Address(RVA = "0xDDFEB4", Offset = "0xDDFEB4", VA = "0xDDFEB4")]
	public void ToggleText(bool _continue = true)
	{
	}

	[Token(Token = "0x60006B4")]
	[Address(RVA = "0xDDFF00", Offset = "0xDDFF00", VA = "0xDDFF00")]
	public void SetConditions(int[] _healthToLose, int[] _beersToLose, int[] _requestsTolose, string _levelTime, bool levelWithTime = true)
	{
	}

	[Token(Token = "0x60006B5")]
	[Address(RVA = "0xDE02B4", Offset = "0xDE02B4", VA = "0xDE02B4")]
	public void ShowFailedSign(string text)
	{
	}

	[Token(Token = "0x60006B6")]
	[Address(RVA = "0xDE0634", Offset = "0xDE0634", VA = "0xDE0634")]
	public FinishedSign()
	{
	}
}
[Token(Token = "0x2000125")]
public class FloatOverObject : MonoBehaviour
{
	[Token(Token = "0x400062F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform objectToFloatOver;

	[Token(Token = "0x4000630")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float distanceToFloat;

	[Token(Token = "0x4000631")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public Transform playerTransform;

	[Token(Token = "0x60006B7")]
	[Address(RVA = "0xDE08B0", Offset = "0xDE08B0", VA = "0xDE08B0")]
	private void Start()
	{
	}

	[Token(Token = "0x60006B8")]
	[Address(RVA = "0xDE0960", Offset = "0xDE0960", VA = "0xDE0960")]
	private void Update()
	{
	}

	[Token(Token = "0x60006B9")]
	[Address(RVA = "0xDE0A54", Offset = "0xDE0A54", VA = "0xDE0A54")]
	public FloatOverObject()
	{
	}
}
[Token(Token = "0x2000126")]
public class GetStarNumber : MonoBehaviour
{
	[Token(Token = "0x60006BA")]
	[Address(RVA = "0xDE70F4", Offset = "0xDE70F4", VA = "0xDE70F4")]
	private void Start()
	{
	}

	[Token(Token = "0x60006BB")]
	[Address(RVA = "0xDE71E4", Offset = "0xDE71E4", VA = "0xDE71E4")]
	public GetStarNumber()
	{
	}
}
[Token(Token = "0x2000127")]
public class HeightAdjustmentSlider : MonoBehaviour
{
	[Token(Token = "0x4000632")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private HVRCameraRig cameraRig;

	[Token(Token = "0x4000633")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private HVRPlayerWaist playerWaist;

	[Token(Token = "0x4000634")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float originalWaistOffset;

	[Token(Token = "0x4000635")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Slider slider;

	[Token(Token = "0x4000636")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI valueText;

	[Token(Token = "0x4000637")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float initialValue;

	[Token(Token = "0x4000638")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public InstanceHeightAdjustment tableExample;

	[Token(Token = "0x4000639")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public InstanceHeightAdjustment beerboxExample;

	[Token(Token = "0x400063A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public HeightAdjustmentOption targetInstance;

	[Token(Token = "0x400063B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float minValue;

	[Token(Token = "0x400063C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float maxValue;

	[Token(Token = "0x400063D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AF3F8", Offset = "0x9AF3F8")]
	public int multipler;

	[Token(Token = "0x400063E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private AudioHandler audioHandler;

	[Token(Token = "0x60006BC")]
	[Address(RVA = "0xDE7CC4", Offset = "0xDE7CC4", VA = "0xDE7CC4")]
	private void Start()
	{
	}

	[Token(Token = "0x60006BD")]
	[Address(RVA = "0xDE7FA0", Offset = "0xDE7FA0", VA = "0xDE7FA0")]
	public void UpdateDisplayValue()
	{
	}

	[Token(Token = "0x60006BE")]
	[Address(RVA = "0xDE80D8", Offset = "0xDE80D8", VA = "0xDE80D8")]
	public void UpdateValue()
	{
	}

	[Token(Token = "0x60006BF")]
	[Address(RVA = "0xDE8270", Offset = "0xDE8270", VA = "0xDE8270")]
	public HeightAdjustmentSlider()
	{
	}
}
[Token(Token = "0x2000128")]
public class MainMenuLevelUI : MonoBehaviour
{
	[Token(Token = "0x400063F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int currentlySelected;

	[Token(Token = "0x4000640")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LevelInfo levelInfo;

	[Token(Token = "0x4000641")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool amUnlocked;

	[Token(Token = "0x4000642")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool amVisible;

	[Token(Token = "0x4000643")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI Title;

	[Token(Token = "0x4000644")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI obj1;

	[Token(Token = "0x4000645")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI obj2;

	[Token(Token = "0x4000646")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI obj3;

	[Token(Token = "0x4000647")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI levelDuration;

	[Token(Token = "0x4000648")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextMeshProUGUI playerHealth;

	[Token(Token = "0x4000649")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextMeshProUGUI beersToLose;

	[Token(Token = "0x400064A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TextMeshProUGUI requestsToLose;

	[Token(Token = "0x400064B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Button goButton;

	[Token(Token = "0x400064C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject levelSign;

	[Token(Token = "0x400064D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9AF430", Offset = "0x9AF430")]
	public GameObject LockedLevelUI;

	[Token(Token = "0x400064E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int starsNeededToUnlock;

	[Token(Token = "0x400064F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Button levelBadge;

	[Token(Token = "0x4000650")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private string sceneToLoad;

	[Token(Token = "0x4000651")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private int numOfStars;

	[Token(Token = "0x4000652")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private bool unlocking;

	[Token(Token = "0x4000653")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9AF468", Offset = "0x9AF468")]
	public OnlineLeaderboard onlineLeaderboard;

	[Token(Token = "0x4000654")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TextMeshProUGUI leaderboardTitle;

	[Token(Token = "0x4000655")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public GameObject enableOnLevelSelect;

	[Token(Token = "0x60006C0")]
	[Address(RVA = "0xDEF3D4", Offset = "0xDEF3D4", VA = "0xDEF3D4")]
	private void Start()
	{
	}

	[Token(Token = "0x60006C1")]
	[Address(RVA = "0xDEFA40", Offset = "0xDEFA40", VA = "0xDEFA40")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60006C2")]
	[Address(RVA = "0xDEFB6C", Offset = "0xDEFB6C", VA = "0xDEFB6C")]
	public void OnLevelClick()
	{
	}

	[Token(Token = "0x60006C3")]
	[Address(RVA = "0xDF0244", Offset = "0xDF0244", VA = "0xDF0244")]
	private void UpdateLeaderboard()
	{
	}

	[Token(Token = "0x60006C4")]
	[Address(RVA = "0xDF036C", Offset = "0xDF036C", VA = "0xDF036C")]
	private void LocalLoadScene()
	{
	}

	[Token(Token = "0x60006C5")]
	[Address(RVA = "0xDEFCC0", Offset = "0xDEFCC0", VA = "0xDEFCC0")]
	private void LevelSignPopsUp()
	{
	}

	[Token(Token = "0x60006C6")]
	[Address(RVA = "0xDEFD10", Offset = "0xDEFD10", VA = "0xDEFD10")]
	private void ChangeSignsAnimation()
	{
	}

	[Token(Token = "0x60006C7")]
	[Address(RVA = "0xDEF970", Offset = "0xDEF970", VA = "0xDEF970")]
	private void HideMe()
	{
	}

	[Token(Token = "0x60006C8")]
	[Address(RVA = "0xDF0408", Offset = "0xDF0408", VA = "0xDF0408")]
	public void UnlockLevel()
	{
	}

	[Token(Token = "0x60006C9")]
	[Address(RVA = "0xDEF998", Offset = "0xDEF998", VA = "0xDEF998")]
	private void DisableLockedUI()
	{
	}

	[Token(Token = "0x60006CA")]
	[Address(RVA = "0xDF04F8", Offset = "0xDF04F8", VA = "0xDF04F8")]
	private void UpdateLevelName()
	{
	}

	[Token(Token = "0x60006CB")]
	[Address(RVA = "0xDF064C", Offset = "0xDF064C", VA = "0xDF064C")]
	public MainMenuLevelUI()
	{
	}
}
[Token(Token = "0x2000129")]
public class PlayerUIWatch : Singleton<PlayerUIWatch>
{
	[Serializable]
	[Token(Token = "0x200012A")]
	public class RequestSlotClone
	{
		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Canvas requestCanvas;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI requestTime;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image requestIcon;

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xF6BB1C", Offset = "0xF6BB1C", VA = "0xF6BB1C")]
		public RequestSlotClone()
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200012B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE520", Offset = "0x9AE520")]
	private struct <>c__DisplayClass39_0
	{
		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Color color;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PlayerUIWatch <>4__this;
	}

	[Token(Token = "0x200012C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE530", Offset = "0x9AE530")]
	private sealed class <BlinkUntilOpenedCoroutine>d__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlayerUIWatch <>4__this;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float delay;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private <>c__DisplayClass39_0 <>8__1;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float <time>5__2;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float <maxAlpha>5__3;

		[Token(Token = "0x1700011D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006E2")]
			[Address(RVA = "0xF6BACC", Offset = "0xF6BACC", VA = "0xF6BACC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006E4")]
			[Address(RVA = "0xF6BB14", Offset = "0xF6BB14", VA = "0xF6BB14", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xF6B6B4", Offset = "0xF6B6B4", VA = "0xF6B6B4")]
		[DebuggerHidden]
		public <BlinkUntilOpenedCoroutine>d__39(int <>1__state)
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xF6B6E0", Offset = "0xF6B6E0", VA = "0xF6B6E0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xF6B6E4", Offset = "0xF6B6E4", VA = "0xF6B6E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xF6BAD4", Offset = "0xF6BAD4", VA = "0xF6BAD4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000656")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI watchTimeText;

	[Token(Token = "0x4000657")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] hearts;

	[Token(Token = "0x4000658")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Renderer screenRenderer;

	[Token(Token = "0x4000659")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI objective1InWatch;

	[Token(Token = "0x400065A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI objective2InWatch;

	[Token(Token = "0x400065B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI objective3InWatch;

	[Token(Token = "0x400065C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI playerHealthInWatch;

	[Token(Token = "0x400065D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int playerHealth;

	[Token(Token = "0x400065E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextMeshProUGUI beersToLoseInWatch;

	[Token(Token = "0x400065F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int beersToLose;

	[Token(Token = "0x4000660")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int beersLeftToLose;

	[Token(Token = "0x4000661")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TextMeshProUGUI requestsToLoseInWatch;

	[Token(Token = "0x4000662")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int requestsToLose;

	[Token(Token = "0x4000663")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int requestsLeftToLose;

	[Token(Token = "0x4000664")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject watchUICanvas;

	[Token(Token = "0x4000665")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float coolddownToToggle;

	[Token(Token = "0x4000666")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private float currentCooldownTime;

	[Token(Token = "0x4000667")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public bool displayingWatchUICanvas;

	[Token(Token = "0x4000668")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Animator watchUICanvasAnimator;

	[Token(Token = "0x4000669")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float distanceUntilTurnWatchOff;

	[Token(Token = "0x400066A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public float angleUntilTurnWatchOff;

	[Token(Token = "0x400066B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Image blinkingCanvas;

	[Token(Token = "0x400066C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private AudioHandler audioHandler;

	[Token(Token = "0x400066D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private HVRHandGrabber hand;

	[Token(Token = "0x400066E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public RequestSlotClone[] requestSlotClones;

	[Token(Token = "0x60006CD")]
	[Address(RVA = "0x2738484", Offset = "0x2738484", VA = "0x2738484")]
	private void Start()
	{
	}

	[Token(Token = "0x60006CE")]
	[Address(RVA = "0x2738FB0", Offset = "0x2738FB0", VA = "0x2738FB0")]
	private void Update()
	{
	}

	[Token(Token = "0x60006CF")]
	[Address(RVA = "0x27391DC", Offset = "0x27391DC", VA = "0x27391DC")]
	private void UpdateHP()
	{
	}

	[Token(Token = "0x60006D0")]
	[Address(RVA = "0x2739790", Offset = "0x2739790", VA = "0x2739790")]
	private void UpdateHP(int i)
	{
	}

	[Token(Token = "0x60006D1")]
	[Address(RVA = "0x2739794", Offset = "0x2739794", VA = "0x2739794")]
	private void UpdateBeersLost(Beer _)
	{
	}

	[Token(Token = "0x60006D2")]
	[Address(RVA = "0x2739870", Offset = "0x2739870", VA = "0x2739870")]
	private void UpdateRequestsLost(RequestSlot _)
	{
	}

	[Token(Token = "0x60006D3")]
	[Address(RVA = "0x27389A4", Offset = "0x27389A4", VA = "0x27389A4")]
	private void NewLevel()
	{
	}

	[Token(Token = "0x60006D4")]
	[Address(RVA = "0x273994C", Offset = "0x273994C", VA = "0x273994C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60006D5")]
	[Address(RVA = "0x2739B38", Offset = "0x2739B38", VA = "0x2739B38")]
	public void RestartButton()
	{
	}

	[Token(Token = "0x60006D6")]
	[Address(RVA = "0x2739CE4", Offset = "0x2739CE4", VA = "0x2739CE4")]
	public void QuitLevelButton()
	{
	}

	[Token(Token = "0x60006D7")]
	[Address(RVA = "0x2739E90", Offset = "0x2739E90", VA = "0x2739E90")]
	public void ShowWatchUICanvas()
	{
	}

	[Token(Token = "0x60006D8")]
	[Address(RVA = "0x2739154", Offset = "0x2739154", VA = "0x2739154")]
	public void HideWatchUICanvas()
	{
	}

	[Token(Token = "0x60006D9")]
	[Address(RVA = "0x2739A24", Offset = "0x2739A24", VA = "0x2739A24")]
	private void ToggleWatchCanvas()
	{
	}

	[Token(Token = "0x60006DA")]
	[Address(RVA = "0x2739F1C", Offset = "0x2739F1C", VA = "0x2739F1C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B5060", Offset = "0x9B5060")]
	public IEnumerator BlinkUntilOpenedCoroutine(float delay = 0f)
	{
		return null;
	}

	[Token(Token = "0x60006DB")]
	[Address(RVA = "0x27396D4", Offset = "0x27396D4", VA = "0x27396D4")]
	private void VibrateWatch()
	{
	}

	[Token(Token = "0x60006DC")]
	[Address(RVA = "0x2739F98", Offset = "0x2739F98", VA = "0x2739F98")]
	public PlayerUIWatch()
	{
	}

	[Token(Token = "0x60006DD")]
	[Address(RVA = "0x2739FEC", Offset = "0x2739FEC", VA = "0x2739FEC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B50C0", Offset = "0x9B50C0")]
	private void <BlinkUntilOpenedCoroutine>g__SetCanvasAlpha|39_0(float alpha, ref <>c__DisplayClass39_0 P_1)
	{
	}
}
[Token(Token = "0x200012D")]
public class TrailerPlayer : MonoBehaviour
{
	[Token(Token = "0x200012E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE540", Offset = "0x9AE540")]
	private sealed class <PlayVideo>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TrailerPlayer <>4__this;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <time>5__2;

		[Token(Token = "0x1700011F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x22908E4", Offset = "0x22908E4", VA = "0x22908E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000120")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x229092C", Offset = "0x229092C", VA = "0x229092C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x2290698", Offset = "0x2290698", VA = "0x2290698")]
		[DebuggerHidden]
		public <PlayVideo>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x22906C4", Offset = "0x22906C4", VA = "0x22906C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x22906C8", Offset = "0x22906C8", VA = "0x22906C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x22908EC", Offset = "0x22908EC", VA = "0x22908EC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200012F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE550", Offset = "0x9AE550")]
	private sealed class <FadeOutCoroutine>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TrailerPlayer <>4__this;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <time>5__2;

		[Token(Token = "0x17000121")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x2290648", Offset = "0x2290648", VA = "0x2290648", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000122")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x2290690", Offset = "0x2290690", VA = "0x2290690", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x2290498", Offset = "0x2290498", VA = "0x2290498")]
		[DebuggerHidden]
		public <FadeOutCoroutine>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x22904C4", Offset = "0x22904C4", VA = "0x22904C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x22904C8", Offset = "0x22904C8", VA = "0x22904C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x2290650", Offset = "0x2290650", VA = "0x2290650", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400067B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public VideoPlayer steamTrailer;

	[Token(Token = "0x400067C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public VideoPlayer oculusTrailer;

	[Token(Token = "0x400067D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public VideoPlayer video;

	[Token(Token = "0x400067E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private SpriteRenderer spriteRenderer;

	[Token(Token = "0x400067F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool allowSkip;

	[Token(Token = "0x4000680")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject skipText;

	[Token(Token = "0x4000681")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Color transparentColor;

	[Token(Token = "0x4000682")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Color fullAlphaColor;

	[Token(Token = "0x60006E5")]
	[Address(RVA = "0x274486C", Offset = "0x274486C", VA = "0x274486C")]
	public void Play(float delay)
	{
	}

	[Token(Token = "0x60006E6")]
	[Address(RVA = "0x27449F4", Offset = "0x27449F4", VA = "0x27449F4")]
	public void Stop()
	{
	}

	[Token(Token = "0x60006E7")]
	[Address(RVA = "0x2744B04", Offset = "0x2744B04", VA = "0x2744B04")]
	public VideoPlayer GetVideo()
	{
		return null;
	}

	[Token(Token = "0x60006E8")]
	[Address(RVA = "0x2744C10", Offset = "0x2744C10", VA = "0x2744C10")]
	public SpriteRenderer GetRenderer()
	{
		return null;
	}

	[Token(Token = "0x60006E9")]
	[Address(RVA = "0x2744978", Offset = "0x2744978", VA = "0x2744978")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B5120", Offset = "0x9B5120")]
	private IEnumerator PlayVideo(float delay)
	{
		return null;
	}

	[Token(Token = "0x60006EA")]
	[Address(RVA = "0x2744BA4", Offset = "0x2744BA4", VA = "0x2744BA4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B5180", Offset = "0x9B5180")]
	private IEnumerator FadeOutCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60006EB")]
	[Address(RVA = "0x2744CD4", Offset = "0x2744CD4", VA = "0x2744CD4")]
	public TrailerPlayer()
	{
	}
}
[Token(Token = "0x2000130")]
public class UIActions : Singleton<UIActions>
{
	[Token(Token = "0x400068C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject MainMenu;

	[Token(Token = "0x400068D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject CampaignMenu;

	[Token(Token = "0x400068E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject ArcadeMenu;

	[Token(Token = "0x400068F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject SettingsMenu;

	[Token(Token = "0x4000690")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9AF4A0", Offset = "0x9AF4A0")]
	public TextMeshProUGUI attemptOfBBQValue;

	[Token(Token = "0x4000691")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI boomerangsThrownValue;

	[Token(Token = "0x4000692")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI boomerangsCaughtValue;

	[Token(Token = "0x4000693")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextMeshProUGUI beersLostValue;

	[Token(Token = "0x4000694")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextMeshProUGUI beersServedValue;

	[Token(Token = "0x4000695")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TextMeshProUGUI hamburgersServedValue;

	[Token(Token = "0x4000696")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TextMeshProUGUI skewersServedValue;

	[Token(Token = "0x4000697")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public TextMeshProUGUI platesSmashedValue;

	[Token(Token = "0x4000698")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public TextMeshProUGUI animalsWhackedValue;

	[Token(Token = "0x4000699")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public TextMeshProUGUI animalsPettedValue;

	[Token(Token = "0x400069A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private AussiePlayer aussiePlayer;

	[Token(Token = "0x60006F8")]
	[Address(RVA = "0xECE95C", Offset = "0xECE95C", VA = "0xECE95C")]
	private void Start()
	{
	}

	[Token(Token = "0x60006F9")]
	[Address(RVA = "0xECEC60", Offset = "0xECEC60", VA = "0xECEC60")]
	public void Tutorial()
	{
	}

	[Token(Token = "0x60006FA")]
	[Address(RVA = "0xECECFC", Offset = "0xECECFC", VA = "0xECECFC")]
	public void GoToScene(string _scene)
	{
	}

	[Token(Token = "0x60006FB")]
	[Address(RVA = "0xECED88", Offset = "0xECED88", VA = "0xECED88")]
	public void DeleteSave()
	{
	}

	[Token(Token = "0x60006FC")]
	[Address(RVA = "0xECEE0C", Offset = "0xECEE0C", VA = "0xECEE0C")]
	public void MagicStarsUnlock()
	{
	}

	[Token(Token = "0x60006FD")]
	[Address(RVA = "0xECEE90", Offset = "0xECEE90", VA = "0xECEE90")]
	public void Quit()
	{
	}

	[Token(Token = "0x60006FE")]
	[Address(RVA = "0xECEF14", Offset = "0xECEF14", VA = "0xECEF14")]
	public void OpenCampaingMenu()
	{
	}

	[Token(Token = "0x60006FF")]
	[Address(RVA = "0xECF01C", Offset = "0xECF01C", VA = "0xECF01C")]
	public void OpenMainMenu()
	{
	}

	[Token(Token = "0x6000700")]
	[Address(RVA = "0xECF174", Offset = "0xECF174", VA = "0xECF174")]
	public void OpenArcadeMenu()
	{
	}

	[Token(Token = "0x6000701")]
	[Address(RVA = "0xECF27C", Offset = "0xECF27C", VA = "0xECF27C")]
	public void OpenSettingsMenu()
	{
	}

	[Token(Token = "0x6000702")]
	[Address(RVA = "0xECE9E0", Offset = "0xECE9E0", VA = "0xECE9E0")]
	public void UpdateStatisticsOnBoard()
	{
	}

	[Token(Token = "0x6000703")]
	[Address(RVA = "0xECF330", Offset = "0xECF330", VA = "0xECF330")]
	public UIActions()
	{
	}
}
[Token(Token = "0x2000131")]
public class VignetteCanvas : MonoBehaviour
{
	[Token(Token = "0x2000132")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE560", Offset = "0x9AE560")]
	private sealed class <EnableLoadingSequenceAfterDelay>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VignetteCanvas <>4__this;

		[Token(Token = "0x17000123")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000715")]
			[Address(RVA = "0x2291614", Offset = "0x2291614", VA = "0x2291614", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000124")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000717")]
			[Address(RVA = "0x229165C", Offset = "0x229165C", VA = "0x229165C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x2291534", Offset = "0x2291534", VA = "0x2291534")]
		[DebuggerHidden]
		public <EnableLoadingSequenceAfterDelay>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x2291560", Offset = "0x2291560", VA = "0x2291560", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x2291564", Offset = "0x2291564", VA = "0x2291564", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x229161C", Offset = "0x229161C", VA = "0x229161C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000133")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE570", Offset = "0x9AE570")]
	private sealed class <FadoutVignetteCoroutine>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool _damage;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public VignetteCanvas <>4__this;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float _fadoutTime;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public CanvasGroup _canvasGroup;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <time>5__2;

		[Token(Token = "0x17000125")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600071B")]
			[Address(RVA = "0x22919A4", Offset = "0x22919A4", VA = "0x22919A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000126")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600071D")]
			[Address(RVA = "0x22919EC", Offset = "0x22919EC", VA = "0x22919EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x2291664", Offset = "0x2291664", VA = "0x2291664")]
		[DebuggerHidden]
		public <FadoutVignetteCoroutine>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x2291690", Offset = "0x2291690", VA = "0x2291690", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x2291694", Offset = "0x2291694", VA = "0x2291694", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x22919AC", Offset = "0x22919AC", VA = "0x22919AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400069B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float teleportFadeOut;

	[Token(Token = "0x400069C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float damageFadeOut;

	[Token(Token = "0x400069D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CanvasGroup damageCanvasGroup;

	[Token(Token = "0x400069E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public CanvasGroup teleportCanvasGroup;

	[Token(Token = "0x400069F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public CanvasGroup pauseCanvasGroup;

	[Token(Token = "0x40006A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject loadingAnimation;

	[Token(Token = "0x40006A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public CanvasGroup blackScreenCanvasGroup;

	[Token(Token = "0x40006A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private IEnumerator loadingCoroutine;

	[Token(Token = "0x40006A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private AudioHandler audioHandler;

	[Token(Token = "0x40006A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool streamingCanvas;

	[Token(Token = "0x6000704")]
	[Address(RVA = "0xED06E8", Offset = "0xED06E8", VA = "0xED06E8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000705")]
	[Address(RVA = "0xED0FD8", Offset = "0xED0FD8", VA = "0xED0FD8")]
	private void UpdateGamePlayManagerDamage()
	{
	}

	[Token(Token = "0x6000706")]
	[Address(RVA = "0xED1168", Offset = "0xED1168", VA = "0xED1168")]
	private void EnableLoadingSequence()
	{
	}

	[Token(Token = "0x6000707")]
	[Address(RVA = "0xED0F6C", Offset = "0xED0F6C", VA = "0xED0F6C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B5280", Offset = "0x9B5280")]
	private IEnumerator EnableLoadingSequenceAfterDelay()
	{
		return null;
	}

	[Token(Token = "0x6000708")]
	[Address(RVA = "0xED0F28", Offset = "0xED0F28", VA = "0xED0F28")]
	private void DisableLoadingSequence()
	{
	}

	[Token(Token = "0x6000709")]
	[Address(RVA = "0xED1174", Offset = "0xED1174", VA = "0xED1174")]
	private void DamageVignetteOn(int _)
	{
	}

	[Token(Token = "0x600070A")]
	[Address(RVA = "0xED1210", Offset = "0xED1210", VA = "0xED1210")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B52E0", Offset = "0x9B52E0")]
	private IEnumerator FadoutVignetteCoroutine(CanvasGroup _canvasGroup, float _fadoutTime = 1f, bool _damage = false)
	{
		return null;
	}

	[Token(Token = "0x600070B")]
	[Address(RVA = "0xED12A8", Offset = "0xED12A8", VA = "0xED12A8")]
	private void TeleportVignetteOn()
	{
	}

	[Token(Token = "0x600070C")]
	[Address(RVA = "0xED12C8", Offset = "0xED12C8", VA = "0xED12C8")]
	private void TeleportVignetteOff()
	{
	}

	[Token(Token = "0x600070D")]
	[Address(RVA = "0xED1300", Offset = "0xED1300", VA = "0xED1300")]
	private void PauseVignetteOn()
	{
	}

	[Token(Token = "0x600070E")]
	[Address(RVA = "0xED1320", Offset = "0xED1320", VA = "0xED1320")]
	private void PauseVignetteOff()
	{
	}

	[Token(Token = "0x600070F")]
	[Address(RVA = "0xED1340", Offset = "0xED1340", VA = "0xED1340")]
	public void CameraFadeVignetteOn()
	{
	}

	[Token(Token = "0x6000710")]
	[Address(RVA = "0xED1360", Offset = "0xED1360", VA = "0xED1360")]
	private void CameraFadeVignetteOff()
	{
	}

	[Token(Token = "0x6000711")]
	[Address(RVA = "0xED1398", Offset = "0xED1398", VA = "0xED1398")]
	public VignetteCanvas()
	{
	}
}
[Token(Token = "0x2000134")]
public class WatchMenuButton : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000135")]
	public class ActionOnSelect : UnityEvent
	{
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x2291C24", Offset = "0x2291C24", VA = "0x2291C24")]
		public ActionOnSelect()
		{
		}
	}

	[Token(Token = "0x40006AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject button;

	[Token(Token = "0x40006B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private HVRHandGrabber hand;

	[Token(Token = "0x40006B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioHandler audioHandler;

	[Token(Token = "0x40006B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float timeToSelect;

	[Token(Token = "0x40006B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float selectionPercentage;

	[Token(Token = "0x40006B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool selecting;

	[Token(Token = "0x40006B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	public ActionOnSelect actionOnSelect;

	[Token(Token = "0x40006B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Material buttonMaterial;

	[Token(Token = "0x40006B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 originalButtonPosition;

	[Token(Token = "0x600071E")]
	[Address(RVA = "0xED1E9C", Offset = "0xED1E9C", VA = "0xED1E9C")]
	private void Start()
	{
	}

	[Token(Token = "0x600071F")]
	[Address(RVA = "0xED1FA4", Offset = "0xED1FA4", VA = "0xED1FA4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000720")]
	[Address(RVA = "0xED2064", Offset = "0xED2064", VA = "0xED2064")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x6000721")]
	[Address(RVA = "0xED21EC", Offset = "0xED21EC", VA = "0xED21EC")]
	private void selectButton()
	{
	}

	[Token(Token = "0x6000722")]
	[Address(RVA = "0xED22B0", Offset = "0xED22B0", VA = "0xED22B0")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000723")]
	[Address(RVA = "0xED2008", Offset = "0xED2008", VA = "0xED2008")]
	private void updateShader()
	{
	}

	[Token(Token = "0x6000724")]
	[Address(RVA = "0xED2378", Offset = "0xED2378", VA = "0xED2378")]
	public WatchMenuButton()
	{
	}
}
[Token(Token = "0x2000136")]
public class Whiteboard : Singleton<Whiteboard>
{
	[Token(Token = "0x40006B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Renderer _renderer;

	[Token(Token = "0x40006B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Texture2D texture;

	[Token(Token = "0x40006BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 textureSize;

	[Token(Token = "0x40006BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Color[] resetPixels;

	[Token(Token = "0x40006BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject disableParticles;

	[Token(Token = "0x40006BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject submitButton;

	[Token(Token = "0x40006BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject submitButtonDisabler;

	[Token(Token = "0x40006BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Sprite cantSubmitTexture;

	[Token(Token = "0x40006C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject markers;

	[Token(Token = "0x6000726")]
	[Address(RVA = "0xED2388", Offset = "0xED2388", VA = "0xED2388", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000727")]
	[Address(RVA = "0xED24AC", Offset = "0xED24AC", VA = "0xED24AC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000728")]
	[Address(RVA = "0xED2590", Offset = "0xED2590", VA = "0xED2590")]
	public void ResetBoard()
	{
	}

	[Token(Token = "0x6000729")]
	[Address(RVA = "0xED25D0", Offset = "0xED25D0", VA = "0xED25D0")]
	public void DisableSubmit()
	{
	}

	[Token(Token = "0x600072A")]
	[Address(RVA = "0xED28B4", Offset = "0xED28B4", VA = "0xED28B4")]
	public void Disable()
	{
	}

	[Token(Token = "0x600072B")]
	[Address(RVA = "0xED2938", Offset = "0xED2938", VA = "0xED2938")]
	public void Enable()
	{
	}

	[Token(Token = "0x600072C")]
	[Address(RVA = "0xED29D0", Offset = "0xED29D0", VA = "0xED29D0")]
	public Whiteboard()
	{
	}
}
[Token(Token = "0x2000137")]
public class WhiteboardMarker : MonoBehaviour
{
	[Token(Token = "0x40006C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform _tip;

	[Token(Token = "0x40006C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int _penSize;

	[Token(Token = "0x40006C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private Color _color;

	[Token(Token = "0x40006C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Color[] _colors;

	[Token(Token = "0x40006C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float _tipHeight;

	[Token(Token = "0x40006C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private RaycastHit _touch;

	[Token(Token = "0x40006C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Whiteboard _whiteboard;

	[Token(Token = "0x40006C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector2 _touchPos;

	[Token(Token = "0x40006C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Vector2 _lastTouchPos;

	[Token(Token = "0x40006CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int _lastTouchIntensity;

	[Token(Token = "0x40006CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private bool _touchedLastFrame;

	[Token(Token = "0x40006CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private AudioHandler audioHandler;

	[Token(Token = "0x40006CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float _drawingTime;

	[Token(Token = "0x40006CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private HVRGrabbable grabbable;

	[Token(Token = "0x40006CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private bool isBeingGrabbed;

	[Token(Token = "0x600072D")]
	[Address(RVA = "0xED2A28", Offset = "0xED2A28", VA = "0xED2A28")]
	private void Start()
	{
	}

	[Token(Token = "0x600072E")]
	[Address(RVA = "0xED2C80", Offset = "0xED2C80", VA = "0xED2C80")]
	private void OnGrab(HVRGrabberBase grabber, HVRGrabbable hvrGrabbable)
	{
	}

	[Token(Token = "0x600072F")]
	[Address(RVA = "0xED2C8C", Offset = "0xED2C8C", VA = "0xED2C8C")]
	private void OnRelease(HVRGrabberBase grabber, HVRGrabbable hvrGrabbable)
	{
	}

	[Token(Token = "0x6000730")]
	[Address(RVA = "0xED2C94", Offset = "0xED2C94", VA = "0xED2C94")]
	private void Update()
	{
	}

	[Token(Token = "0x6000731")]
	[Address(RVA = "0xED2CA4", Offset = "0xED2CA4", VA = "0xED2CA4")]
	private void Draw()
	{
	}

	[Token(Token = "0x6000732")]
	[Address(RVA = "0xED2FD0", Offset = "0xED2FD0", VA = "0xED2FD0")]
	private void SetPixelsCircle(int _x, int _y, int _intensity)
	{
	}

	[Token(Token = "0x6000733")]
	[Address(RVA = "0xED30D4", Offset = "0xED30D4", VA = "0xED30D4")]
	public WhiteboardMarker()
	{
	}
}
[Token(Token = "0x2000138")]
public class ActivateOnPlatform : MonoBehaviour
{
	[Token(Token = "0x2000139")]
	public enum Platform
	{
		[Token(Token = "0x40006D4")]
		STEAM,
		[Token(Token = "0x40006D5")]
		OCULUS,
		[Token(Token = "0x40006D6")]
		PICO,
		[Token(Token = "0x40006D7")]
		IQIYI
	}

	[Token(Token = "0x40006D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] activatableObjects;

	[Token(Token = "0x40006D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Platform platform;

	[Token(Token = "0x40006D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private bool activate;

	[Token(Token = "0x6000734")]
	[Address(RVA = "0xD22B84", Offset = "0xD22B84", VA = "0xD22B84")]
	private void Start()
	{
	}

	[Token(Token = "0x6000735")]
	[Address(RVA = "0xD22C14", Offset = "0xD22C14", VA = "0xD22C14")]
	public ActivateOnPlatform()
	{
	}
}
[Token(Token = "0x200013A")]
public class ActivateOnQualityLevel : MonoBehaviour
{
	[Token(Token = "0x40006D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] activatableObjectsLevel3;

	[Token(Token = "0x40006D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int qualityLevel;

	[Token(Token = "0x6000736")]
	[Address(RVA = "0xD22C1C", Offset = "0xD22C1C", VA = "0xD22C1C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000737")]
	[Address(RVA = "0xD22D08", Offset = "0xD22D08", VA = "0xD22D08")]
	public void ifQualityOverOrEqual3()
	{
	}

	[Token(Token = "0x6000738")]
	[Address(RVA = "0xD22E54", Offset = "0xD22E54", VA = "0xD22E54")]
	public ActivateOnQualityLevel()
	{
	}
}
[Token(Token = "0x200013B")]
public class AddPrefabAsChild : MonoBehaviour
{
	[Token(Token = "0x40006DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] prefabs;

	[Token(Token = "0x6000739")]
	[Address(RVA = "0xD22E64", Offset = "0xD22E64", VA = "0xD22E64")]
	private void Start()
	{
	}

	[Token(Token = "0x600073A")]
	[Address(RVA = "0xD22F5C", Offset = "0xD22F5C", VA = "0xD22F5C")]
	public AddPrefabAsChild()
	{
	}
}
[Token(Token = "0x200013C")]
public class ArcadeWaveHandler : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200013D")]
	public class EnemyTemplate
	{
		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject enemyPrefab;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<Transform> spawnPlaces;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool spawnPlaceUniquePerWave;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int firstSpawnAtWave;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int initialSpawnNumber;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float increaseRate;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int maxAmount;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AF5B0", Offset = "0x9AF5B0")]
		public float waitTimeBetweenSpawns;

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xED7404", Offset = "0xED7404", VA = "0xED7404")]
		public EnemyTemplate()
		{
		}
	}

	[Token(Token = "0x200013E")]
	public class EnemyToSpawn
	{
		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject enemyPrefab;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform spawnPlace;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float secondsToWaitAfterSpawn;

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xED7418", Offset = "0xED7418", VA = "0xED7418")]
		public EnemyToSpawn(GameObject _prefab, Transform _transform, float _secondsToWaitAfterSpawn)
		{
		}
	}

	[Token(Token = "0x200013F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE580", Offset = "0x9AE580")]
	private sealed class <PrepareWave>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ArcadeWaveHandler <>4__this;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int waveNumber;

		[Token(Token = "0x17000127")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600074F")]
			[Address(RVA = "0xED6C20", Offset = "0xED6C20", VA = "0xED6C20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000128")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000751")]
			[Address(RVA = "0xED6C68", Offset = "0xED6C68", VA = "0xED6C68", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xED6A28", Offset = "0xED6A28", VA = "0xED6A28")]
		[DebuggerHidden]
		public <PrepareWave>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0xED6A54", Offset = "0xED6A54", VA = "0xED6A54", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0xED6A58", Offset = "0xED6A58", VA = "0xED6A58", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xED6C28", Offset = "0xED6C28", VA = "0xED6C28", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000140")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE590", Offset = "0x9AE590")]
	private sealed class <>c
	{
		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<EnemyToSpawn, float> <>9__14_0;

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xED6A18", Offset = "0xED6A18", VA = "0xED6A18")]
		public <>c()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xED6A20", Offset = "0xED6A20", VA = "0xED6A20")]
		internal float <StartNextProceduralGeneratedEnemyWave>b__14_0(EnemyToSpawn x)
		{
			return default(float);
		}
	}

	[Token(Token = "0x2000141")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE5A0", Offset = "0x9AE5A0")]
	private sealed class <SpawnEnemiesCoroutine>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ArcadeWaveHandler <>4__this;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<EnemyToSpawn> enemies;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<EnemyToSpawn>.Enumerator <>7__wrap1;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EnemyToSpawn <enemy>5__3;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int <i>5__4;

		[Token(Token = "0x17000129")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000759")]
			[Address(RVA = "0xED70E4", Offset = "0xED70E4", VA = "0xED70E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600075B")]
			[Address(RVA = "0xED712C", Offset = "0xED712C", VA = "0xED712C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xED6C70", Offset = "0xED6C70", VA = "0xED6C70")]
		[DebuggerHidden]
		public <SpawnEnemiesCoroutine>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0xED6C9C", Offset = "0xED6C9C", VA = "0xED6C9C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xED6D0C", Offset = "0xED6D0C", VA = "0xED6D0C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xED6CB8", Offset = "0xED6CB8", VA = "0xED6CB8")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0xED70EC", Offset = "0xED70EC", VA = "0xED70EC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000142")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE5B0", Offset = "0x9AE5B0")]
	private sealed class <Wave5Update>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x1700012B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600075F")]
			[Address(RVA = "0xED73B4", Offset = "0xED73B4", VA = "0xED73B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000761")]
			[Address(RVA = "0xED73FC", Offset = "0xED73FC", VA = "0xED73FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xED7350", Offset = "0xED7350", VA = "0xED7350")]
		[DebuggerHidden]
		public <Wave5Update>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0xED737C", Offset = "0xED737C", VA = "0xED737C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0xED7380", Offset = "0xED7380", VA = "0xED7380", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0xED73BC", Offset = "0xED73BC", VA = "0xED73BC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000143")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE5C0", Offset = "0x9AE5C0")]
	private sealed class <Wave10Update>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x1700012D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000765")]
			[Address(RVA = "0xED7198", Offset = "0xED7198", VA = "0xED7198", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000767")]
			[Address(RVA = "0xED71E0", Offset = "0xED71E0", VA = "0xED71E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0xED7134", Offset = "0xED7134", VA = "0xED7134")]
		[DebuggerHidden]
		public <Wave10Update>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0xED7160", Offset = "0xED7160", VA = "0xED7160", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0xED7164", Offset = "0xED7164", VA = "0xED7164", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0xED71A0", Offset = "0xED71A0", VA = "0xED71A0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000144")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE5D0", Offset = "0x9AE5D0")]
	private sealed class <Wave15Update>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x1700012F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600076B")]
			[Address(RVA = "0xED724C", Offset = "0xED724C", VA = "0xED724C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000130")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600076D")]
			[Address(RVA = "0xED7294", Offset = "0xED7294", VA = "0xED7294", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0xED71E8", Offset = "0xED71E8", VA = "0xED71E8")]
		[DebuggerHidden]
		public <Wave15Update>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xED7214", Offset = "0xED7214", VA = "0xED7214", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0xED7218", Offset = "0xED7218", VA = "0xED7218", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0xED7254", Offset = "0xED7254", VA = "0xED7254", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000145")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE5E0", Offset = "0x9AE5E0")]
	private sealed class <Wave20Update>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000131")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000771")]
			[Address(RVA = "0xED7300", Offset = "0xED7300", VA = "0xED7300", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000132")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000773")]
			[Address(RVA = "0xED7348", Offset = "0xED7348", VA = "0xED7348", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0xED729C", Offset = "0xED729C", VA = "0xED729C")]
		[DebuggerHidden]
		public <Wave20Update>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0xED72C8", Offset = "0xED72C8", VA = "0xED72C8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0xED72CC", Offset = "0xED72CC", VA = "0xED72CC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0xED7308", Offset = "0xED7308", VA = "0xED7308", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40006DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int currentWave;

	[Token(Token = "0x40006DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float timeToWaitBetweenWaves;

	[Token(Token = "0x40006DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public Events.EventNewArcadeWave OnWaveStart;

	[Token(Token = "0x40006DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9AF528", Offset = "0x9AF528")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9AF528", Offset = "0x9AF528")]
	public GameObject[] premadeEnemySpawners;

	[Token(Token = "0x40006DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public EnemyTemplate[] enemyTemplates;

	[Token(Token = "0x40006E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool startedInfiniteEnemySpawner;

	[Token(Token = "0x40006E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AF578", Offset = "0x9AF578")]
	public float[] enemySpawningTimeElasticity;

	[Token(Token = "0x600073B")]
	[Address(RVA = "0xD23354", Offset = "0xD23354", VA = "0xD23354")]
	public void StartArcade(int waveNumber)
	{
	}

	[Token(Token = "0x600073C")]
	[Address(RVA = "0xD25E8C", Offset = "0xD25E8C", VA = "0xD25E8C")]
	public void QueueNextWave()
	{
	}

	[Token(Token = "0x600073D")]
	[Address(RVA = "0xD25E10", Offset = "0xD25E10", VA = "0xD25E10")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B53E0", Offset = "0x9B53E0")]
	private IEnumerator PrepareWave(int waveNumber)
	{
		return null;
	}

	[Token(Token = "0x600073E")]
	[Address(RVA = "0xD25EC4", Offset = "0xD25EC4", VA = "0xD25EC4")]
	private void StartWave(int waveNumber)
	{
	}

	[Token(Token = "0x600073F")]
	[Address(RVA = "0xD25FB8", Offset = "0xD25FB8", VA = "0xD25FB8", Slot = "4")]
	public virtual void StartSpawners(int waveNumber)
	{
	}

	[Token(Token = "0x6000740")]
	[Address(RVA = "0xD2602C", Offset = "0xD2602C", VA = "0xD2602C")]
	public void StartNextProceduralGeneratedEnemyWave(int waveNumber)
	{
	}

	[Token(Token = "0x6000741")]
	[Address(RVA = "0xD264B4", Offset = "0xD264B4", VA = "0xD264B4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B5440", Offset = "0x9B5440")]
	private IEnumerator SpawnEnemiesCoroutine(List<EnemyToSpawn> enemies)
	{
		return null;
	}

	[Token(Token = "0x6000742")]
	[Address(RVA = "0xD2652C", Offset = "0xD2652C", VA = "0xD2652C")]
	private void UpdateTimeElsaticity()
	{
	}

	[Token(Token = "0x6000743")]
	[Address(RVA = "0xD26704", Offset = "0xD26704", VA = "0xD26704")]
	private float ElasticTimeIncrement()
	{
		return default(float);
	}

	[Token(Token = "0x6000744")]
	[Address(RVA = "0xD26874", Offset = "0xD26874", VA = "0xD26874", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B54A0", Offset = "0x9B54A0")]
	public virtual IEnumerator Wave5Update()
	{
		return null;
	}

	[Token(Token = "0x6000745")]
	[Address(RVA = "0xD268D0", Offset = "0xD268D0", VA = "0xD268D0", Slot = "6")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B5500", Offset = "0x9B5500")]
	public virtual IEnumerator Wave10Update()
	{
		return null;
	}

	[Token(Token = "0x6000746")]
	[Address(RVA = "0xD2692C", Offset = "0xD2692C", VA = "0xD2692C", Slot = "7")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B5560", Offset = "0x9B5560")]
	public virtual IEnumerator Wave15Update()
	{
		return null;
	}

	[Token(Token = "0x6000747")]
	[Address(RVA = "0xD26988", Offset = "0xD26988", VA = "0xD26988", Slot = "8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B55C0", Offset = "0x9B55C0")]
	public virtual IEnumerator Wave20Update()
	{
		return null;
	}

	[Token(Token = "0x6000748")]
	[Address(RVA = "0xD269E4", Offset = "0xD269E4", VA = "0xD269E4")]
	public ArcadeWaveHandler()
	{
	}

	[Token(Token = "0x6000749")]
	[Address(RVA = "0xD266F8", Offset = "0xD266F8", VA = "0xD266F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B5620", Offset = "0x9B5620")]
	internal static float <UpdateTimeElsaticity>g__calculateElasticity|16_0(float _min, float _changeMultiplier, float originalElasticity)
	{
		return default(float);
	}
}
[Token(Token = "0x2000146")]
public enum SoundType
{
	[Token(Token = "0x4000704")]
	SFX,
	[Token(Token = "0x4000705")]
	Music
}
[Token(Token = "0x2000147")]
public class AudioHandler : MonoBehaviour
{
	[Token(Token = "0x2000148")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE5F0", Offset = "0x9AE5F0")]
	private sealed class <>c__DisplayClass19_0
	{
		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string sound;

		[Token(Token = "0x6000791")]
		[Address(RVA = "0xED7460", Offset = "0xED7460", VA = "0xED7460")]
		public <>c__DisplayClass19_0()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0xED7468", Offset = "0xED7468", VA = "0xED7468")]
		internal bool <Play>b__0(Sound item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000149")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE600", Offset = "0x9AE600")]
	private sealed class <>c__DisplayClass20_0
	{
		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string sound;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Sound s;

		[Token(Token = "0x6000793")]
		[Address(RVA = "0xED748C", Offset = "0xED748C", VA = "0xED748C")]
		public <>c__DisplayClass20_0()
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0xED7494", Offset = "0xED7494", VA = "0xED7494")]
		internal bool <PlayCoroutine>b__0(Sound item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0xED74B8", Offset = "0xED74B8", VA = "0xED74B8")]
		internal bool <PlayCoroutine>b__1()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200014A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE610", Offset = "0x9AE610")]
	private sealed class <PlayCoroutine>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string sound;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioHandler <>4__this;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private <>c__DisplayClass20_0 <>8__1;

		[Token(Token = "0x17000133")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000799")]
			[Address(RVA = "0xED7884", Offset = "0xED7884", VA = "0xED7884", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000134")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600079B")]
			[Address(RVA = "0xED78CC", Offset = "0xED78CC", VA = "0xED78CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0xED7570", Offset = "0xED7570", VA = "0xED7570")]
		[DebuggerHidden]
		public <PlayCoroutine>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0xED759C", Offset = "0xED759C", VA = "0xED759C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xED75A0", Offset = "0xED75A0", VA = "0xED75A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xED788C", Offset = "0xED788C", VA = "0xED788C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200014B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE620", Offset = "0x9AE620")]
	private sealed class <>c__DisplayClass21_0
	{
		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string sound;

		[Token(Token = "0x600079C")]
		[Address(RVA = "0xED74EC", Offset = "0xED74EC", VA = "0xED74EC")]
		public <>c__DisplayClass21_0()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xED74F4", Offset = "0xED74F4", VA = "0xED74F4")]
		internal bool <Play>b__0(Sound item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200014C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE630", Offset = "0x9AE630")]
	private sealed class <PlayFromGroupWithDelayCoroutine>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioHandler <>4__this;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string sound;

		[Token(Token = "0x17000135")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007A1")]
			[Address(RVA = "0xED79C0", Offset = "0xED79C0", VA = "0xED79C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000136")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007A3")]
			[Address(RVA = "0xED7A08", Offset = "0xED7A08", VA = "0xED7A08", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xED78D4", Offset = "0xED78D4", VA = "0xED78D4")]
		[DebuggerHidden]
		public <PlayFromGroupWithDelayCoroutine>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0xED7900", Offset = "0xED7900", VA = "0xED7900", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xED7904", Offset = "0xED7904", VA = "0xED7904", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xED79C8", Offset = "0xED79C8", VA = "0xED79C8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200014D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE640", Offset = "0x9AE640")]
	private sealed class <>c__DisplayClass27_0
	{
		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string sound;

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xED7518", Offset = "0xED7518", VA = "0xED7518")]
		public <>c__DisplayClass27_0()
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xED7520", Offset = "0xED7520", VA = "0xED7520")]
		internal bool <Stop>b__0(Sound item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200014E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE650", Offset = "0x9AE650")]
	private sealed class <>c__DisplayClass28_0
	{
		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string sound;

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xED7544", Offset = "0xED7544", VA = "0xED7544")]
		public <>c__DisplayClass28_0()
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xED754C", Offset = "0xED754C", VA = "0xED754C")]
		internal bool <GetSound>b__0(Sound item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200014F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE660", Offset = "0x9AE660")]
	private sealed class <UpdatePitchCoroutine>d__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource source;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float startingPitch;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float targetPitch;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float timeToTransition;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <time>5__2;

		[Token(Token = "0x17000137")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007AB")]
			[Address(RVA = "0xED7AF0", Offset = "0xED7AF0", VA = "0xED7AF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000138")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007AD")]
			[Address(RVA = "0xED7B38", Offset = "0xED7B38", VA = "0xED7B38", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xED7A10", Offset = "0xED7A10", VA = "0xED7A10")]
		[DebuggerHidden]
		public <UpdatePitchCoroutine>d__36(int <>1__state)
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xED7A3C", Offset = "0xED7A3C", VA = "0xED7A3C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xED7A40", Offset = "0xED7A40", VA = "0xED7A40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xED7AF8", Offset = "0xED7AF8", VA = "0xED7AF8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000150")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE670", Offset = "0x9AE670")]
	private sealed class <UpdateVolumeCoroutine>d__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource source;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float startingVolume;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float targetVolume;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float timeToTransition;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <time>5__2;

		[Token(Token = "0x17000139")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007B1")]
			[Address(RVA = "0xED7D50", Offset = "0xED7D50", VA = "0xED7D50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007B3")]
			[Address(RVA = "0xED7D98", Offset = "0xED7D98", VA = "0xED7D98", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xED7C70", Offset = "0xED7C70", VA = "0xED7C70")]
		[DebuggerHidden]
		public <UpdateVolumeCoroutine>d__38(int <>1__state)
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xED7C9C", Offset = "0xED7C9C", VA = "0xED7C9C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xED7CA0", Offset = "0xED7CA0", VA = "0xED7CA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0xED7D58", Offset = "0xED7D58", VA = "0xED7D58", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000151")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE680", Offset = "0x9AE680")]
	private sealed class <UpdatePitchCoroutine>d__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource source;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float startingPitch;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float timeToTransition;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <time>5__2;

		[Token(Token = "0x1700013B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007B7")]
			[Address(RVA = "0xED7C20", Offset = "0xED7C20", VA = "0xED7C20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007B9")]
			[Address(RVA = "0xED7C68", Offset = "0xED7C68", VA = "0xED7C68", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0xED7B40", Offset = "0xED7B40", VA = "0xED7B40")]
		[DebuggerHidden]
		public <UpdatePitchCoroutine>d__39(int <>1__state)
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xED7B6C", Offset = "0xED7B6C", VA = "0xED7B6C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xED7B70", Offset = "0xED7B70", VA = "0xED7B70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xED7C28", Offset = "0xED7C28", VA = "0xED7C28", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000706")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SoundType soundType;

	[Token(Token = "0x4000707")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioMixerGroup mixerGroup;

	[Token(Token = "0x4000708")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string playOnStart;

	[Token(Token = "0x4000709")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Sound[] sounds;

	[Token(Token = "0x400070A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public SoundGroup[] soundGroups;

	[Token(Token = "0x400070B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Dictionary<string, SoundGroup> soundGroupsDict;

	[Token(Token = "0x400070C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected float volumeLevel;

	[Token(Token = "0x400070D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject audioSourcesOrigin;

	[Token(Token = "0x400070E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject audioSourcesParent;

	[Token(Token = "0x400070F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float slowDownInfluence;

	[Token(Token = "0x4000710")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool quitting;

	[Token(Token = "0x4000711")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float timeUntilAudioSourcesDestroyed;

	[Token(Token = "0x6000774")]
	[Address(RVA = "0xD26A6C", Offset = "0xD26A6C", VA = "0xD26A6C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000775")]
	[Address(RVA = "0xD2708C", Offset = "0xD2708C", VA = "0xD2708C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000776")]
	[Address(RVA = "0xD27140", Offset = "0xD27140", VA = "0xD27140")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000777")]
	[Address(RVA = "0xD27150", Offset = "0xD27150", VA = "0xD27150")]
	private void UnparentAudioSources()
	{
	}

	[Token(Token = "0x6000778")]
	[Address(RVA = "0xD2700C", Offset = "0xD2700C", VA = "0xD2700C")]
	private void ResetAudioSourcesTransform()
	{
	}

	[Token(Token = "0x6000779")]
	[Address(RVA = "0xD271F0", Offset = "0xD271F0", VA = "0xD271F0")]
	private void Start()
	{
	}

	[Token(Token = "0x600077A")]
	[Address(RVA = "0xD2789C", Offset = "0xD2789C", VA = "0xD2789C")]
	private float SlowDownMultiplier()
	{
		return default(float);
	}

	[Token(Token = "0x600077B")]
	[Address(RVA = "0xD239C8", Offset = "0xD239C8", VA = "0xD239C8")]
	public void Play(string sound)
	{
	}

	[Token(Token = "0x600077C")]
	[Address(RVA = "0xD278D4", Offset = "0xD278D4", VA = "0xD278D4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B5810", Offset = "0x9B5810")]
	public IEnumerator PlayCoroutine(string sound)
	{
		return null;
	}

	[Token(Token = "0x600077D")]
	[Address(RVA = "0xD2561C", Offset = "0xD2561C", VA = "0xD2561C")]
	public void Play(string sound, float volumneMultiplier = 1f, float pitchMultiplier = 1f)
	{
	}

	[Token(Token = "0x600077E")]
	[Address(RVA = "0xD2794C", Offset = "0xD2794C", VA = "0xD2794C")]
	public string PlayRandom(string[] sounds, float volumneMultiplier = 1f, float pitchMultiplier = 1f)
	{
		return null;
	}

	[Token(Token = "0x600077F")]
	[Address(RVA = "0xD279E0", Offset = "0xD279E0", VA = "0xD279E0")]
	public void PlayRandomWithPrefix(string prefix, float volumneMultiplier = 1f, float pitchMultiplier = 1f)
	{
	}

	[Token(Token = "0x6000780")]
	[Address(RVA = "0xD27634", Offset = "0xD27634", VA = "0xD27634")]
	public void PlayRandomFromGroup(string groupName, float volumneMultiplier = 1f, float pitchMultiplier = 1f)
	{
	}

	[Token(Token = "0x6000781")]
	[Address(RVA = "0xD27CB0", Offset = "0xD27CB0", VA = "0xD27CB0")]
	public void PlayFromGroupWithDelay(string sound, float delay)
	{
	}

	[Token(Token = "0x6000782")]
	[Address(RVA = "0xD27CDC", Offset = "0xD27CDC", VA = "0xD27CDC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B5870", Offset = "0x9B5870")]
	private IEnumerator PlayFromGroupWithDelayCoroutine(string sound, float delay)
	{
		return null;
	}

	[Token(Token = "0x6000783")]
	[Address(RVA = "0xD27D64", Offset = "0xD27D64", VA = "0xD27D64")]
	public void Stop(string sound)
	{
	}

	[Token(Token = "0x6000784")]
	[Address(RVA = "0xD27548", Offset = "0xD27548", VA = "0xD27548")]
	public Sound GetSound(string sound)
	{
		return null;
	}

	[Token(Token = "0x6000785")]
	[Address(RVA = "0xD27F44", Offset = "0xD27F44", VA = "0xD27F44")]
	public AudioSource GetAudioSource(string sound)
	{
		return null;
	}

	[Token(Token = "0x6000786")]
	[Address(RVA = "0xD27F64", Offset = "0xD27F64", VA = "0xD27F64")]
	public void UpdateVolumeLevelOfPlayingSounds(float multiplier)
	{
	}

	[Token(Token = "0x6000787")]
	[Address(RVA = "0xD2804C", Offset = "0xD2804C", VA = "0xD2804C")]
	public void UpdateVolumeLevel(float multiplier)
	{
	}

	[Token(Token = "0x6000788")]
	[Address(RVA = "0xD28054", Offset = "0xD28054", VA = "0xD28054")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000789")]
	[Address(RVA = "0xD28060", Offset = "0xD28060", VA = "0xD28060")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600078A")]
	[Address(RVA = "0xD281D4", Offset = "0xD281D4", VA = "0xD281D4")]
	public void ResetSoundsPitch(float timeToResume)
	{
	}

	[Token(Token = "0x600078B")]
	[Address(RVA = "0xD283BC", Offset = "0xD283BC", VA = "0xD283BC")]
	public void PitchDownSounds(float timeToSlow)
	{
	}

	[Token(Token = "0x600078C")]
	[Address(RVA = "0xD2832C", Offset = "0xD2832C", VA = "0xD2832C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B58D0", Offset = "0x9B58D0")]
	private IEnumerator UpdatePitchCoroutine(AudioSource source, float timeToTransition, float startingPitch, float targetPitch)
	{
		return null;
	}

	[Token(Token = "0x600078D")]
	[Address(RVA = "0xD28584", Offset = "0xD28584", VA = "0xD28584")]
	public void LerpSoundVolume(string soundName, float timeToTransition, float targetVolumeMultipler)
	{
	}

	[Token(Token = "0x600078E")]
	[Address(RVA = "0xD28608", Offset = "0xD28608", VA = "0xD28608")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B5930", Offset = "0x9B5930")]
	private IEnumerator UpdateVolumeCoroutine(AudioSource source, float timeToTransition, float startingVolume, float targetVolume)
	{
		return null;
	}

	[Token(Token = "0x600078F")]
	[Address(RVA = "0xD28504", Offset = "0xD28504", VA = "0xD28504")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B5990", Offset = "0x9B5990")]
	private IEnumerator UpdatePitchCoroutine(AudioSource source, float timeToTransition, float startingPitch)
	{
		return null;
	}

	[Token(Token = "0x6000790")]
	[Address(RVA = "0xD28698", Offset = "0xD28698", VA = "0xD28698")]
	public AudioHandler()
	{
	}
}
[Token(Token = "0x2000152")]
public class AussieSocket : HVRSocket
{
	[Token(Token = "0x2000153")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE690", Offset = "0x9AE690")]
	private sealed class <DisableColliders>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Rigidbody rb;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HVRGrabbable g;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <time>5__2;

		[Token(Token = "0x1700013D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007CC")]
			[Address(RVA = "0xED81C4", Offset = "0xED81C4", VA = "0xED81C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007CE")]
			[Address(RVA = "0xED820C", Offset = "0xED820C", VA = "0xED820C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xED8094", Offset = "0xED8094", VA = "0xED8094")]
		[DebuggerHidden]
		public <DisableColliders>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xED80C0", Offset = "0xED80C0", VA = "0xED80C0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xED80C4", Offset = "0xED80C4", VA = "0xED80C4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xED81CC", Offset = "0xED81CC", VA = "0xED81CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000736")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private AudioHandler audioHandler;

	[Token(Token = "0x4000737")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	public bool canRemoveGrabbableWhenHeld;

	[Token(Token = "0x4000738")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	public HVRGrabbable grabbable;

	[Token(Token = "0x4000739")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private HVRGrabbable _socketedObject;

	[Token(Token = "0x400073A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private ActivatableGrabIndicator selfGrabIndicator;

	[Token(Token = "0x400073B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private List<ActivatableGrabIndicator> activatedGrabInidcators;

	[Token(Token = "0x400073C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public bool popOnRelease;

	[Token(Token = "0x400073D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D9")]
	public bool inSpawner;

	[Token(Token = "0x60007BA")]
	[Address(RVA = "0xD2A3AC", Offset = "0xD2A3AC", VA = "0xD2A3AC", Slot = "25")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60007BB")]
	[Address(RVA = "0xD2A6E8", Offset = "0xD2A6E8", VA = "0xD2A6E8", Slot = "62")]
	protected override void PlaySocketedSFX(HVRSocketable socketable)
	{
	}

	[Token(Token = "0x60007BC")]
	[Address(RVA = "0xD2A7E0", Offset = "0xD2A7E0", VA = "0xD2A7E0", Slot = "63")]
	protected override void PlayUnsocketedSFX(HVRGrabbable grabbable)
	{
	}

	[Token(Token = "0x60007BD")]
	[Address(RVA = "0xD2A740", Offset = "0xD2A740", VA = "0xD2A740")]
	private AudioHandler GetAudioHandler()
	{
		return null;
	}

	[Token(Token = "0x60007BE")]
	[Address(RVA = "0xD2A838", Offset = "0xD2A838", VA = "0xD2A838")]
	public void OnObjectSocketed(HVRGrabberBase _grabber, HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x60007BF")]
	[Address(RVA = "0xD2AC8C", Offset = "0xD2AC8C", VA = "0xD2AC8C")]
	public void OnObjectUnsocketed(HVRGrabberBase _grabber, HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x60007C0")]
	[Address(RVA = "0xD2AD78", Offset = "0xD2AD78", VA = "0xD2AD78")]
	public void OnObjectHandGrabbed(HVRGrabberBase _grabber, HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x60007C1")]
	[Address(RVA = "0xD2AE08", Offset = "0xD2AE08", VA = "0xD2AE08")]
	public void OnObjectHandReleased(HVRGrabberBase _grabber, HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x60007C2")]
	[Address(RVA = "0xD2A91C", Offset = "0xD2A91C", VA = "0xD2A91C")]
	private void DisableGrabbable(HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x60007C3")]
	[Address(RVA = "0xD2ACBC", Offset = "0xD2ACBC", VA = "0xD2ACBC")]
	private void EnableGrabbable(HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x60007C4")]
	[Address(RVA = "0xD2AB3C", Offset = "0xD2AB3C", VA = "0xD2AB3C")]
	private void ActivateGrabIndicators()
	{
	}

	[Token(Token = "0x60007C5")]
	[Address(RVA = "0xD2A9D8", Offset = "0xD2A9D8", VA = "0xD2A9D8")]
	private void DeactivateGrabIndicators()
	{
	}

	[Token(Token = "0x60007C6")]
	[Address(RVA = "0xD2AE94", Offset = "0xD2AE94", VA = "0xD2AE94", Slot = "29")]
	public override void ForceRelease()
	{
	}

	[Token(Token = "0x60007C7")]
	[Address(RVA = "0xD2AF18", Offset = "0xD2AF18", VA = "0xD2AF18")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B5B80", Offset = "0x9B5B80")]
	private IEnumerator DisableColliders(Rigidbody rb, HVRGrabbable g)
	{
		return null;
	}

	[Token(Token = "0x60007C8")]
	[Address(RVA = "0xD2AF90", Offset = "0xD2AF90", VA = "0xD2AF90")]
	public AussieSocket()
	{
	}
}
[Token(Token = "0x2000154")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x9AE6A0", Offset = "0x9AE6A0")]
public class CollisionSounds : MonoBehaviour
{
	[Token(Token = "0x2000155")]
	public enum materialTypes
	{
		[Token(Token = "0x400074A")]
		Wood,
		[Token(Token = "0x400074B")]
		Metal,
		[Token(Token = "0x400074C")]
		Glass,
		[Token(Token = "0x400074D")]
		Boomerang,
		[Token(Token = "0x400074E")]
		Organic,
		[Token(Token = "0x400074F")]
		Floor
	}

	[Token(Token = "0x4000743")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AF5E8", Offset = "0x9AF5E8")]
	public float minimumColisionStrengh;

	[Token(Token = "0x4000744")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AF620", Offset = "0x9AF620")]
	public float maximumColisionStrengh;

	[Token(Token = "0x4000745")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public materialTypes materialType;

	[Token(Token = "0x4000746")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int audioPriority;

	[Token(Token = "0x4000747")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioHandler audioHandler;

	[Token(Token = "0x4000748")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<string> availableSounds;

	[Token(Token = "0x60007CF")]
	[Address(RVA = "0xD33C9C", Offset = "0xD33C9C", VA = "0xD33C9C")]
	private void Start()
	{
	}

	[Token(Token = "0x60007D0")]
	[Address(RVA = "0xD33D70", Offset = "0xD33D70", VA = "0xD33D70")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60007D1")]
	[Address(RVA = "0xD33EFC", Offset = "0xD33EFC", VA = "0xD33EFC")]
	private void PlayCollisionSound(string sound, Collision collision)
	{
	}

	[Token(Token = "0x60007D2")]
	[Address(RVA = "0xD34050", Offset = "0xD34050", VA = "0xD34050")]
	public CollisionSounds()
	{
	}
}
[Token(Token = "0x2000156")]
public class CookingArcadeWaveHandler : ArcadeWaveHandler
{
	[Serializable]
	[Token(Token = "0x2000157")]
	public class RequestList
	{
		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<RequestHandler.Request> requests;

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xEDC088", Offset = "0xEDC088", VA = "0xEDC088")]
		public RequestList()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000158")]
	public class RequestTemplate
	{
		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RequestType type;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int firstSpawnAtWave;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int initialTimeLimit;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int minimumTimeLimit;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float timeRatioPerWave;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int waitTimeBeforeRequest;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float randomnessWeight;

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xEDC090", Offset = "0xEDC090", VA = "0xEDC090")]
		public RequestTemplate()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000159")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE700", Offset = "0x9AE700")]
	private sealed class <>c
	{
		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<RequestTemplate, float> <>9__12_0;

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xEDBC50", Offset = "0xEDBC50", VA = "0xEDBC50")]
		public <>c()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xEDBC58", Offset = "0xEDBC58", VA = "0xEDBC58")]
		internal float <StartNextProceduralGeneratedRequestsWave>b__12_0(RequestTemplate x)
		{
			return default(float);
		}
	}

	[Token(Token = "0x200015A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE710", Offset = "0x9AE710")]
	private sealed class <OverrideRequestListCoroutine>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CookingArcadeWaveHandler <>4__this;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<RequestHandler.Request> requestsToSpawn;

		[Token(Token = "0x1700013F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007E4")]
			[Address(RVA = "0xEDBD6C", Offset = "0xEDBD6C", VA = "0xEDBD6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000140")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007E6")]
			[Address(RVA = "0xEDBDB4", Offset = "0xEDBDB4", VA = "0xEDBDB4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xEDBC8C", Offset = "0xEDBC8C", VA = "0xEDBC8C")]
		[DebuggerHidden]
		public <OverrideRequestListCoroutine>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xEDBCB8", Offset = "0xEDBCB8", VA = "0xEDBCB8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xEDBCBC", Offset = "0xEDBCBC", VA = "0xEDBCBC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xEDBD74", Offset = "0xEDBD74", VA = "0xEDBD74", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200015B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE720", Offset = "0x9AE720")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int waveNumber;

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xEDBC60", Offset = "0xEDBC60", VA = "0xEDBC60")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xEDBC68", Offset = "0xEDBC68", VA = "0xEDBC68")]
		internal bool <GetWeightedTemplates>b__0(RequestTemplate item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200015C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE730", Offset = "0x9AE730")]
	private sealed class <Wave5Update>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CookingArcadeWaveHandler <>4__this;

		[Token(Token = "0x17000141")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007EC")]
			[Address(RVA = "0xEDC038", Offset = "0xEDC038", VA = "0xEDC038", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000142")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007EE")]
			[Address(RVA = "0xEDC080", Offset = "0xEDC080", VA = "0xEDC080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xEDBF18", Offset = "0xEDBF18", VA = "0xEDBF18")]
		[DebuggerHidden]
		public <Wave5Update>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xEDBF44", Offset = "0xEDBF44", VA = "0xEDBF44", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xEDBF48", Offset = "0xEDBF48", VA = "0xEDBF48", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xEDC040", Offset = "0xEDC040", VA = "0xEDC040", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200015D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE740", Offset = "0x9AE740")]
	private sealed class <Wave10Update>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CookingArcadeWaveHandler <>4__this;

		[Token(Token = "0x17000143")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007F2")]
			[Address(RVA = "0xEDBEC8", Offset = "0xEDBEC8", VA = "0xEDBEC8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000144")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007F4")]
			[Address(RVA = "0xEDBF10", Offset = "0xEDBF10", VA = "0xEDBF10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xEDBDBC", Offset = "0xEDBDBC", VA = "0xEDBDBC")]
		[DebuggerHidden]
		public <Wave10Update>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xEDBDE8", Offset = "0xEDBDE8", VA = "0xEDBDE8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xEDBDEC", Offset = "0xEDBDEC", VA = "0xEDBDEC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xEDBED0", Offset = "0xEDBED0", VA = "0xEDBED0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000750")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9AF658", Offset = "0x9AF658")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9AF658", Offset = "0x9AF658")]
	public List<RequestList> premadeRequestsLists;

	[Token(Token = "0x4000751")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool startedInfiniteRequestsSpawner;

	[Token(Token = "0x4000752")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RequestHandler infiniteRequestHandler;

	[Token(Token = "0x4000753")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RequestTemplate[] requestTemplates;

	[Token(Token = "0x4000754")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Dictionary<int, List<RequestTemplate>> weigthedTemplateCache;

	[Token(Token = "0x4000755")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject secondaryBeerbox;

	[Token(Token = "0x4000756")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject[] snagSpawners;

	[Token(Token = "0x4000757")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject[] skewerSpawners;

	[Token(Token = "0x60007D3")]
	[Address(RVA = "0xD342D4", Offset = "0xD342D4", VA = "0xD342D4", Slot = "9")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x60007D4")]
	[Address(RVA = "0xD343B8", Offset = "0xD343B8", VA = "0xD343B8", Slot = "4")]
	public override void StartSpawners(int waveNumber)
	{
	}

	[Token(Token = "0x60007D5")]
	[Address(RVA = "0xD34554", Offset = "0xD34554", VA = "0xD34554")]
	private void StartNextProceduralGeneratedRequestsWave(int waveNumber)
	{
	}

	[Token(Token = "0x60007D6")]
	[Address(RVA = "0xD344DC", Offset = "0xD344DC", VA = "0xD344DC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B5C30", Offset = "0x9B5C30")]
	private IEnumerator OverrideRequestListCoroutine(List<RequestHandler.Request> requestsToSpawn)
	{
		return null;
	}

	[Token(Token = "0x60007D7")]
	[Address(RVA = "0xD34A34", Offset = "0xD34A34", VA = "0xD34A34")]
	private List<RequestTemplate> GetWeightedTemplates(int waveNumber)
	{
		return null;
	}

	[Token(Token = "0x60007D8")]
	[Address(RVA = "0xD34D74", Offset = "0xD34D74", VA = "0xD34D74")]
	private void OnAllRequestsHandled()
	{
	}

	[Token(Token = "0x60007D9")]
	[Address(RVA = "0xD34EF0", Offset = "0xD34EF0", VA = "0xD34EF0", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B5C90", Offset = "0x9B5C90")]
	public override IEnumerator Wave5Update()
	{
		return null;
	}

	[Token(Token = "0x60007DA")]
	[Address(RVA = "0xD34F5C", Offset = "0xD34F5C", VA = "0xD34F5C", Slot = "6")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B5CF0", Offset = "0x9B5CF0")]
	public override IEnumerator Wave10Update()
	{
		return null;
	}

	[Token(Token = "0x60007DB")]
	[Address(RVA = "0xD34FC8", Offset = "0xD34FC8", VA = "0xD34FC8")]
	public CookingArcadeWaveHandler()
	{
	}
}
[Token(Token = "0x200015E")]
public class CreateVRUtils : MonoBehaviour
{
	[Token(Token = "0x400076E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject vrUtilsPrefab;

	[Token(Token = "0x400076F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject vrUtils;

	[Token(Token = "0x4000770")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject easySaveMngr;

	[Token(Token = "0x4000771")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject steamUtils;

	[Token(Token = "0x4000772")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject picoUtils;

	[Token(Token = "0x60007F5")]
	[Address(RVA = "0xD350C4", Offset = "0xD350C4", VA = "0xD350C4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60007F6")]
	[Address(RVA = "0xD35208", Offset = "0xD35208", VA = "0xD35208")]
	private void Start()
	{
	}

	[Token(Token = "0x60007F7")]
	[Address(RVA = "0xD3532C", Offset = "0xD3532C", VA = "0xD3532C")]
	public CreateVRUtils()
	{
	}
}
[Token(Token = "0x200015F")]
public class DefenseArcadeWaveHandler : ArcadeWaveHandler
{
	[Token(Token = "0x2000160")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE750", Offset = "0x9AE750")]
	private sealed class <Wave5Update>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DefenseArcadeWaveHandler <>4__this;

		[Token(Token = "0x17000145")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000804")]
			[Address(RVA = "0xEDCB5C", Offset = "0xEDCB5C", VA = "0xEDCB5C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000146")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000806")]
			[Address(RVA = "0xEDCBA4", Offset = "0xEDCBA4", VA = "0xEDCBA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xEDCA74", Offset = "0xEDCA74", VA = "0xEDCA74")]
		[DebuggerHidden]
		public <Wave5Update>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xEDCAA0", Offset = "0xEDCAA0", VA = "0xEDCAA0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xEDCAA4", Offset = "0xEDCAA4", VA = "0xEDCAA4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0xEDCB64", Offset = "0xEDCB64", VA = "0xEDCB64", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000161")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE760", Offset = "0x9AE760")]
	private sealed class <Wave10Update>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DefenseArcadeWaveHandler <>4__this;

		[Token(Token = "0x17000147")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600080A")]
			[Address(RVA = "0xEDC51C", Offset = "0xEDC51C", VA = "0xEDC51C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000148")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600080C")]
			[Address(RVA = "0xEDC564", Offset = "0xEDC564", VA = "0xEDC564", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xEDC3BC", Offset = "0xEDC3BC", VA = "0xEDC3BC")]
		[DebuggerHidden]
		public <Wave10Update>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xEDC3E8", Offset = "0xEDC3E8", VA = "0xEDC3E8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xEDC3EC", Offset = "0xEDC3EC", VA = "0xEDC3EC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xEDC524", Offset = "0xEDC524", VA = "0xEDC524", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000162")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE770", Offset = "0x9AE770")]
	private sealed class <Wave15Update>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DefenseArcadeWaveHandler <>4__this;

		[Token(Token = "0x17000149")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000810")]
			[Address(RVA = "0xEDC78C", Offset = "0xEDC78C", VA = "0xEDC78C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000812")]
			[Address(RVA = "0xEDC7D4", Offset = "0xEDC7D4", VA = "0xEDC7D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xEDC56C", Offset = "0xEDC56C", VA = "0xEDC56C")]
		[DebuggerHidden]
		public <Wave15Update>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0xEDC598", Offset = "0xEDC598", VA = "0xEDC598", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xEDC59C", Offset = "0xEDC59C", VA = "0xEDC59C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xEDC794", Offset = "0xEDC794", VA = "0xEDC794", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000163")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE780", Offset = "0x9AE780")]
	private sealed class <Wave20Update>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DefenseArcadeWaveHandler <>4__this;

		[Token(Token = "0x1700014B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000816")]
			[Address(RVA = "0xEDCA24", Offset = "0xEDCA24", VA = "0xEDCA24", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000818")]
			[Address(RVA = "0xEDCA6C", Offset = "0xEDCA6C", VA = "0xEDCA6C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xEDC7DC", Offset = "0xEDC7DC", VA = "0xEDC7DC")]
		[DebuggerHidden]
		public <Wave20Update>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0xEDC808", Offset = "0xEDC808", VA = "0xEDC808", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xEDC80C", Offset = "0xEDC80C", VA = "0xEDC80C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0xEDCA2C", Offset = "0xEDCA2C", VA = "0xEDCA2C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000773")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9AF6A8", Offset = "0x9AF6A8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9AF6A8", Offset = "0x9AF6A8")]
	public GameObject swapableBeerbox;

	[Token(Token = "0x4000774")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject secondSwapableBeerbox;

	[Token(Token = "0x4000775")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject thirdBeerbox;

	[Token(Token = "0x4000776")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9AF6F8", Offset = "0x9AF6F8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9AF6F8", Offset = "0x9AF6F8")]
	public Transform targetBeer1boxWave10;

	[Token(Token = "0x4000777")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform targetBeer2boxWave10;

	[Token(Token = "0x4000778")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform targetBeer1boxWave20;

	[Token(Token = "0x4000779")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Transform targetBeer2boxWave20;

	[Token(Token = "0x400077A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Transform targetBeer3boxWave20;

	[Token(Token = "0x60007F8")]
	[Address(RVA = "0xD35878", Offset = "0xD35878", VA = "0xD35878", Slot = "9")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x60007F9")]
	[Address(RVA = "0xD3595C", Offset = "0xD3595C", VA = "0xD3595C", Slot = "4")]
	public override void StartSpawners(int waveNumber)
	{
	}

	[Token(Token = "0x60007FA")]
	[Address(RVA = "0xD359C0", Offset = "0xD359C0", VA = "0xD359C0")]
	private void OnAllEnemiesGone()
	{
	}

	[Token(Token = "0x60007FB")]
	[Address(RVA = "0xD359F8", Offset = "0xD359F8", VA = "0xD359F8", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B5E40", Offset = "0x9B5E40")]
	public override IEnumerator Wave5Update()
	{
		return null;
	}

	[Token(Token = "0x60007FC")]
	[Address(RVA = "0xD35A64", Offset = "0xD35A64", VA = "0xD35A64", Slot = "6")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B5EA0", Offset = "0x9B5EA0")]
	public override IEnumerator Wave10Update()
	{
		return null;
	}

	[Token(Token = "0x60007FD")]
	[Address(RVA = "0xD35AD0", Offset = "0xD35AD0", VA = "0xD35AD0", Slot = "7")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B5F00", Offset = "0x9B5F00")]
	public override IEnumerator Wave15Update()
	{
		return null;
	}

	[Token(Token = "0x60007FE")]
	[Address(RVA = "0xD35B3C", Offset = "0xD35B3C", VA = "0xD35B3C", Slot = "8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B5F60", Offset = "0x9B5F60")]
	public override IEnumerator Wave20Update()
	{
		return null;
	}

	[Token(Token = "0x60007FF")]
	[Address(RVA = "0xD35BA8", Offset = "0xD35BA8", VA = "0xD35BA8")]
	private void MoveAndRotateObject(GameObject obj, Transform target)
	{
	}

	[Token(Token = "0x6000800")]
	[Address(RVA = "0xD35F58", Offset = "0xD35F58", VA = "0xD35F58")]
	public DefenseArcadeWaveHandler()
	{
	}
}
[Token(Token = "0x2000164")]
public class DestroyOnLoadScene : MonoBehaviour
{
	[Token(Token = "0x6000819")]
	[Address(RVA = "0xD363D0", Offset = "0xD363D0", VA = "0xD363D0")]
	private void Start()
	{
	}

	[Token(Token = "0x600081A")]
	[Address(RVA = "0xD364B4", Offset = "0xD364B4", VA = "0xD364B4")]
	private void SelfDestruct()
	{
	}

	[Token(Token = "0x600081B")]
	[Address(RVA = "0xD3652C", Offset = "0xD3652C", VA = "0xD3652C")]
	public DestroyOnLoadScene()
	{
	}
}
[Token(Token = "0x2000165")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x9AE790", Offset = "0x9AE790")]
public class DisableCollisionsOnForceGrab : MonoBehaviour
{
	[Token(Token = "0x2000166")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE7F0", Offset = "0x9AE7F0")]
	private sealed class <DisableCollisionsTemporarily>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DisableCollisionsOnForceGrab <>4__this;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <counter>5__2;

		[Token(Token = "0x1700014D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000823")]
			[Address(RVA = "0xEDD178", Offset = "0xEDD178", VA = "0xEDD178", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000825")]
			[Address(RVA = "0xEDD1C0", Offset = "0xEDD1C0", VA = "0xEDD1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xEDD054", Offset = "0xEDD054", VA = "0xEDD054")]
		[DebuggerHidden]
		public <DisableCollisionsTemporarily>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xEDD080", Offset = "0xEDD080", VA = "0xEDD080", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xEDD084", Offset = "0xEDD084", VA = "0xEDD084", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xEDD180", Offset = "0xEDD180", VA = "0xEDD180", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000787")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Rigidbody rb;

	[Token(Token = "0x4000788")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private HVRGrabbable grabbable;

	[Token(Token = "0x600081C")]
	[Address(RVA = "0xD37508", Offset = "0xD37508", VA = "0xD37508")]
	private void Start()
	{
	}

	[Token(Token = "0x600081D")]
	[Address(RVA = "0xD37614", Offset = "0xD37614", VA = "0xD37614")]
	private void OnGrabbed(HVRGrabberBase _, HVRGrabbable __)
	{
	}

	[Token(Token = "0x600081E")]
	[Address(RVA = "0xD37640", Offset = "0xD37640", VA = "0xD37640")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B6100", Offset = "0x9B6100")]
	private IEnumerator DisableCollisionsTemporarily()
	{
		return null;
	}

	[Token(Token = "0x600081F")]
	[Address(RVA = "0xD376AC", Offset = "0xD376AC", VA = "0xD376AC")]
	public DisableCollisionsOnForceGrab()
	{
	}
}
[Token(Token = "0x2000167")]
public class DisplayVersion : MonoBehaviour
{
	[Token(Token = "0x400078D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TextMeshProUGUI text;

	[Token(Token = "0x6000826")]
	[Address(RVA = "0xD37EF8", Offset = "0xD37EF8", VA = "0xD37EF8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000827")]
	[Address(RVA = "0xD37F98", Offset = "0xD37F98", VA = "0xD37F98")]
	public DisplayVersion()
	{
	}
}
[Token(Token = "0x2000168")]
public class Events
{
	[Serializable]
	[Token(Token = "0x2000169")]
	public class EventEnterNewLevel : UnityEvent
	{
		[Token(Token = "0x6000829")]
		[Address(RVA = "0xF57BC0", Offset = "0xF57BC0", VA = "0xF57BC0")]
		public EventEnterNewLevel()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200016A")]
	public class EventExitLevel : UnityEvent
	{
		[Token(Token = "0x600082A")]
		[Address(RVA = "0xF57BC8", Offset = "0xF57BC8", VA = "0xF57BC8")]
		public EventExitLevel()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200016B")]
	public class EventEnemyDeath : UnityEvent<Enemy>
	{
		[Token(Token = "0x600082B")]
		[Address(RVA = "0xF57B64", Offset = "0xF57B64", VA = "0xF57B64")]
		public EventEnemyDeath()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200016C")]
	public class EventEnemyGone : UnityEvent
	{
		[Token(Token = "0x600082C")]
		[Address(RVA = "0xF57BB0", Offset = "0xF57BB0", VA = "0xF57BB0")]
		public EventEnemyGone()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200016D")]
	public class EventEnemySpawn : UnityEvent
	{
		[Token(Token = "0x600082D")]
		[Address(RVA = "0xF57BB8", Offset = "0xF57BB8", VA = "0xF57BB8")]
		public EventEnemySpawn()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200016E")]
	public class EventBeerDisapeared : UnityEvent<Beer>
	{
		[Token(Token = "0x600082E")]
		[Address(RVA = "0xF579E0", Offset = "0xF579E0", VA = "0xF579E0")]
		public EventBeerDisapeared()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200016F")]
	public class EventBeerBoxDisapeared : UnityEvent<BeerBox>
	{
		[Token(Token = "0x600082F")]
		[Address(RVA = "0xF5798C", Offset = "0xF5798C", VA = "0xF5798C")]
		public EventBeerBoxDisapeared()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000170")]
	public class EventBoomerangDestroy : UnityEvent<Boomerang>
	{
		[Token(Token = "0x6000830")]
		[Address(RVA = "0xF57A2C", Offset = "0xF57A2C", VA = "0xF57A2C")]
		public EventBoomerangDestroy()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000171")]
	public class EventBoomerangGrab : UnityEvent<Boomerang>
	{
		[Token(Token = "0x6000831")]
		[Address(RVA = "0xF57A78", Offset = "0xF57A78", VA = "0xF57A78")]
		public EventBoomerangGrab()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000172")]
	public class EventFinishGame : UnityEvent
	{
		[Token(Token = "0x6000832")]
		[Address(RVA = "0xF57BD0", Offset = "0xF57BD0", VA = "0xF57BD0")]
		public EventFinishGame()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000173")]
	public class EventScoreSubmit : UnityEvent
	{
		[Token(Token = "0x6000833")]
		[Address(RVA = "0xF57D74", Offset = "0xF57D74", VA = "0xF57D74")]
		public EventScoreSubmit()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000174")]
	public class EventBeerDelivered : UnityEvent
	{
		[Token(Token = "0x6000834")]
		[Address(RVA = "0xF579D8", Offset = "0xF579D8", VA = "0xF579D8")]
		public EventBeerDelivered()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000175")]
	public class EventHamburgerDelivered : UnityEvent
	{
		[Token(Token = "0x6000835")]
		[Address(RVA = "0xF57BD8", Offset = "0xF57BD8", VA = "0xF57BD8")]
		public EventHamburgerDelivered()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000176")]
	public class EventSnagDelivered : UnityEvent
	{
		[Token(Token = "0x6000836")]
		[Address(RVA = "0xF57D8C", Offset = "0xF57D8C", VA = "0xF57D8C")]
		public EventSnagDelivered()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000177")]
	public class EventSkewerDelivered : UnityEvent
	{
		[Token(Token = "0x6000837")]
		[Address(RVA = "0xF57D84", Offset = "0xF57D84", VA = "0xF57D84")]
		public EventSkewerDelivered()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000178")]
	public class EventPlayerHurt : UnityEvent<int>
	{
		[Token(Token = "0x6000838")]
		[Address(RVA = "0xF57C90", Offset = "0xF57C90", VA = "0xF57C90")]
		public EventPlayerHurt()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000179")]
	public class EventSettingsChanged : UnityEvent
	{
		[Token(Token = "0x6000839")]
		[Address(RVA = "0xF57D7C", Offset = "0xF57D7C", VA = "0xF57D7C")]
		public EventSettingsChanged()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200017A")]
	public class EventAllEnemiesGone : UnityEvent
	{
		[Token(Token = "0x600083A")]
		[Address(RVA = "0xF5797C", Offset = "0xF5797C", VA = "0xF5797C")]
		public EventAllEnemiesGone()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200017B")]
	public class EventRequestMissed : UnityEvent<RequestSlot>
	{
		[Token(Token = "0x600083B")]
		[Address(RVA = "0xF57D28", Offset = "0xF57D28", VA = "0xF57D28")]
		public EventRequestMissed()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200017C")]
	public class EventRequestCompleted : UnityEvent<RequestSlot>
	{
		[Token(Token = "0x600083C")]
		[Address(RVA = "0xF57CDC", Offset = "0xF57CDC", VA = "0xF57CDC")]
		public EventRequestCompleted()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200017D")]
	public class EventAllRequestsComplete : UnityEvent
	{
		[Token(Token = "0x600083D")]
		[Address(RVA = "0xF57984", Offset = "0xF57984", VA = "0xF57984")]
		public EventAllRequestsComplete()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200017E")]
	public class EventDummyExploded : UnityEvent
	{
		[Token(Token = "0x600083E")]
		[Address(RVA = "0xF57AC4", Offset = "0xF57AC4", VA = "0xF57AC4")]
		public EventDummyExploded()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200017F")]
	public class EventDynamiteExploded : UnityEvent<Dynamite>
	{
		[Token(Token = "0x600083F")]
		[Address(RVA = "0xF57B18", Offset = "0xF57B18", VA = "0xF57B18")]
		public EventDynamiteExploded()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000180")]
	public class EventDynamiteEntersHole : UnityEvent<MoleHole, Dynamite>
	{
		[Token(Token = "0x6000840")]
		[Address(RVA = "0xF57ACC", Offset = "0xF57ACC", VA = "0xF57ACC")]
		public EventDynamiteEntersHole()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000181")]
	public class EventLevelActualStart : UnityEvent
	{
		[Token(Token = "0x6000841")]
		[Address(RVA = "0xF57C34", Offset = "0xF57C34", VA = "0xF57C34")]
		public EventLevelActualStart()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000182")]
	public class EventNewArcadeWave : UnityEvent<int>
	{
		[Token(Token = "0x6000842")]
		[Address(RVA = "0xF57C3C", Offset = "0xF57C3C", VA = "0xF57C3C")]
		public EventNewArcadeWave()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000183")]
	public class EventPause : UnityEvent
	{
		[Token(Token = "0x6000843")]
		[Address(RVA = "0xF57C88", Offset = "0xF57C88", VA = "0xF57C88")]
		public EventPause()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000184")]
	public class EventUnPause : UnityEvent
	{
		[Token(Token = "0x6000844")]
		[Address(RVA = "0xF57D94", Offset = "0xF57D94", VA = "0xF57D94")]
		public EventUnPause()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000185")]
	public class EventLanguageUpdate : UnityEvent
	{
		[Token(Token = "0x6000845")]
		[Address(RVA = "0xF57BE0", Offset = "0xF57BE0", VA = "0xF57BE0")]
		public EventLanguageUpdate()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000186")]
	public class EventLeaderboardUpdated : UnityEvent<List<Leaderboard.Score>>
	{
		[Token(Token = "0x6000846")]
		[Address(RVA = "0xF57BE8", Offset = "0xF57BE8", VA = "0xF57BE8")]
		public EventLeaderboardUpdated()
		{
		}
	}

	[Token(Token = "0x6000828")]
	[Address(RVA = "0xDDEE84", Offset = "0xDDEE84", VA = "0xDDEE84")]
	public Events()
	{
	}
}
[Token(Token = "0x2000187")]
public class FiniteSpawnerSocket : AussieSocket
{
	[Token(Token = "0x400078E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
	public int maxItemsToSpawn;

	[Token(Token = "0x400078F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public int itemsLeftToSpawn;

	[Token(Token = "0x4000790")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
	public float coolDownTime;

	[Token(Token = "0x4000791")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public TextMeshProUGUI textToDisplayItemsLeft;

	[Token(Token = "0x4000792")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private GameObject originalItemPrefab;

	[Token(Token = "0x6000847")]
	[Address(RVA = "0xDE063C", Offset = "0xDE063C", VA = "0xDE063C", Slot = "25")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000848")]
	[Address(RVA = "0xDE0744", Offset = "0xDE0744", VA = "0xDE0744")]
	private void UpdateItemsLeft(HVRGrabberBase _, HVRGrabbable __)
	{
	}

	[Token(Token = "0x6000849")]
	[Address(RVA = "0xDE07F8", Offset = "0xDE07F8", VA = "0xDE07F8")]
	public void AddMoreItems(int _number)
	{
	}

	[Token(Token = "0x600084A")]
	[Address(RVA = "0xDE08A8", Offset = "0xDE08A8", VA = "0xDE08A8")]
	public FiniteSpawnerSocket()
	{
	}
}
[Token(Token = "0x2000188")]
public class Floor : Singleton<Floor>
{
	[Token(Token = "0x4000793")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshCollider floorCollider;

	[Token(Token = "0x600084B")]
	[Address(RVA = "0xDE0A6C", Offset = "0xDE0A6C", VA = "0xDE0A6C")]
	private void Start()
	{
	}

	[Token(Token = "0x600084C")]
	[Address(RVA = "0xDE0AC0", Offset = "0xDE0AC0", VA = "0xDE0AC0")]
	public RaycastHit ProjectOnFloor(Vector3 origin, float distance = 100f)
	{
		return default(RaycastHit);
	}

	[Token(Token = "0x600084D")]
	[Address(RVA = "0xDE0C48", Offset = "0xDE0C48", VA = "0xDE0C48")]
	public Floor()
	{
	}
}
[Serializable]
[Token(Token = "0x2000189")]
public class GameStatistics
{
	[Token(Token = "0x4000794")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int attemptsOfBBQ;

	[Token(Token = "0x4000795")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int boomerangsThrown;

	[Token(Token = "0x4000796")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int boomerangsCaught;

	[Token(Token = "0x4000797")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int maxTimesBoomerangWasCatched;

	[Token(Token = "0x4000798")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int requestsServed;

	[Token(Token = "0x4000799")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int beersLost;

	[Token(Token = "0x400079A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int beersServed;

	[Token(Token = "0x400079B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int hamburgersServed;

	[Token(Token = "0x400079C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int snagsServed;

	[Token(Token = "0x400079D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int skewersServed;

	[Token(Token = "0x400079E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int platesSmashed;

	[Token(Token = "0x400079F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int bottlesSmashed;

	[Token(Token = "0x40007A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int friendsDisapointed;

	[Token(Token = "0x40007A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int vegemiteSandwichEaten;

	[Token(Token = "0x40007A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int babyroosConcussed;

	[Token(Token = "0x40007A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int kangaroosConcussed;

	[Token(Token = "0x40007A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int koalasConcussed;

	[Token(Token = "0x40007A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int platypusConcussed;

	[Token(Token = "0x40007A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int dingosConcussed;

	[Token(Token = "0x40007A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int quokkaPhotographed;

	[Token(Token = "0x40007A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int quokkaMissed;

	[Token(Token = "0x40007A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int punchesOnKangaroo;

	[Token(Token = "0x600084E")]
	[Address(RVA = "0xDE36B8", Offset = "0xDE36B8", VA = "0xDE36B8")]
	public GameStatistics()
	{
	}

	[Token(Token = "0x600084F")]
	[Address(RVA = "0xDE27DC", Offset = "0xDE27DC", VA = "0xDE27DC")]
	public void AddLevelStats(GameStatistics levelStats)
	{
	}
}
[Token(Token = "0x200018A")]
public class ImageSequence : MonoBehaviour
{
	[Token(Token = "0x40007AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float repeatRate;

	[Token(Token = "0x40007AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image imageHolder;

	[Token(Token = "0x40007AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Sprite> images;

	[Token(Token = "0x40007AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int index;

	[Token(Token = "0x6000850")]
	[Address(RVA = "0xDEA180", Offset = "0xDEA180", VA = "0xDEA180")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000851")]
	[Address(RVA = "0xDEA1D8", Offset = "0xDEA1D8", VA = "0xDEA1D8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000852")]
	[Address(RVA = "0xDEA1E0", Offset = "0xDEA1E0", VA = "0xDEA1E0")]
	private void NextImage()
	{
	}

	[Token(Token = "0x6000853")]
	[Address(RVA = "0xDEA294", Offset = "0xDEA294", VA = "0xDEA294")]
	public ImageSequence()
	{
	}
}
[Token(Token = "0x200018B")]
public enum HeightAdjustmentOption
{
	[Token(Token = "0x40007AF")]
	player,
	[Token(Token = "0x40007B0")]
	waist,
	[Token(Token = "0x40007B1")]
	tables,
	[Token(Token = "0x40007B2")]
	beerbox
}
[Token(Token = "0x200018C")]
public class InstanceHeightAdjustment : MonoBehaviour
{
	[Token(Token = "0x40007B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public HeightAdjustmentOption key;

	[Token(Token = "0x40007B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Vector3 originalPosition;

	[Token(Token = "0x6000854")]
	[Address(RVA = "0xDEA2A4", Offset = "0xDEA2A4", VA = "0xDEA2A4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000855")]
	[Address(RVA = "0xDEA2EC", Offset = "0xDEA2EC", VA = "0xDEA2EC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000856")]
	[Address(RVA = "0xDE81FC", Offset = "0xDE81FC", VA = "0xDE81FC")]
	public void SetPosition(float offset)
	{
	}

	[Token(Token = "0x6000857")]
	[Address(RVA = "0xDEA388", Offset = "0xDEA388", VA = "0xDEA388")]
	public InstanceHeightAdjustment()
	{
	}
}
[Token(Token = "0x200018D")]
public class LanguageSettingsUI : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200018E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE800", Offset = "0x9AE800")]
	private sealed class <>c
	{
		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<bool> <>9__9_0;

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xF63118", Offset = "0xF63118", VA = "0xF63118")]
		public <>c()
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xF63120", Offset = "0xF63120", VA = "0xF63120")]
		internal bool <WaitForLanguageSelection>b__9_0()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200018F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE810", Offset = "0x9AE810")]
	private sealed class <WaitForLanguageSelection>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LanguageSettingsUI <>4__this;

		[Token(Token = "0x1700014F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000865")]
			[Address(RVA = "0xF6352C", Offset = "0xF6352C", VA = "0xF6352C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000150")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000867")]
			[Address(RVA = "0xF63574", Offset = "0xF63574", VA = "0xF63574", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0xF631A4", Offset = "0xF631A4", VA = "0xF631A4")]
		[DebuggerHidden]
		public <WaitForLanguageSelection>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0xF631D0", Offset = "0xF631D0", VA = "0xF631D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0xF631D4", Offset = "0xF631D4", VA = "0xF631D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xF63534", Offset = "0xF63534", VA = "0xF63534", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40007B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int selected;

	[Token(Token = "0x40007B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private TextMeshProUGUI languageDisplay;

	[Token(Token = "0x40007B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Toggle subtitlesToggle;

	[Token(Token = "0x40007B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<string> languagesWithSubtitleSupport;

	[Token(Token = "0x6000858")]
	[Address(RVA = "0xDEA5E8", Offset = "0xDEA5E8", VA = "0xDEA5E8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000859")]
	[Address(RVA = "0xDEA6BC", Offset = "0xDEA6BC", VA = "0xDEA6BC")]
	public void OnLowerButtonPress()
	{
	}

	[Token(Token = "0x600085A")]
	[Address(RVA = "0xDEA930", Offset = "0xDEA930", VA = "0xDEA930")]
	public void OnUpperButtonPress()
	{
	}

	[Token(Token = "0x600085B")]
	[Address(RVA = "0xDEA9FC", Offset = "0xDEA9FC", VA = "0xDEA9FC")]
	public void OnSubtitleToggle()
	{
	}

	[Token(Token = "0x600085C")]
	[Address(RVA = "0xDEA774", Offset = "0xDEA774", VA = "0xDEA774")]
	public void SelectLanguage(int index)
	{
	}

	[Token(Token = "0x600085D")]
	[Address(RVA = "0xDEA650", Offset = "0xDEA650", VA = "0xDEA650")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B61B0", Offset = "0x9B61B0")]
	private IEnumerator WaitForLanguageSelection()
	{
		return null;
	}

	[Token(Token = "0x600085E")]
	[Address(RVA = "0xDEADF0", Offset = "0xDEADF0", VA = "0xDEADF0")]
	public LanguageSettingsUI()
	{
	}
}
[Token(Token = "0x2000190")]
public class LayerChanger : MonoBehaviour
{
	[Token(Token = "0x40007BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform[] childrenTransformList;

	[Token(Token = "0x6000868")]
	[Address(RVA = "0xDEAF74", Offset = "0xDEAF74", VA = "0xDEAF74")]
	public Transform[] GetAllChildrenTransform()
	{
		return null;
	}

	[Token(Token = "0x6000869")]
	[Address(RVA = "0xDEAFD0", Offset = "0xDEAFD0", VA = "0xDEAFD0")]
	public void ChangeSelfAndChildrenLayer(int _layer)
	{
	}

	[Token(Token = "0x600086A")]
	[Address(RVA = "0xDEB05C", Offset = "0xDEB05C", VA = "0xDEB05C")]
	public LayerChanger()
	{
	}
}
[Token(Token = "0x2000191")]
public class LocalizationManager : Singleton<LocalizationManager>
{
	[Token(Token = "0x2000192")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE820", Offset = "0x9AE820")]
	private sealed class <InitializeLocalization>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocalizationManager <>4__this;

		[Token(Token = "0x17000151")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600087C")]
			[Address(RVA = "0xF666A8", Offset = "0xF666A8", VA = "0xF666A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000152")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600087E")]
			[Address(RVA = "0xF666F0", Offset = "0xF666F0", VA = "0xF666F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0xF660C4", Offset = "0xF660C4", VA = "0xF660C4")]
		[DebuggerHidden]
		public <InitializeLocalization>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0xF660F0", Offset = "0xF660F0", VA = "0xF660F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0xF660F4", Offset = "0xF660F4", VA = "0xF660F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0xF666B0", Offset = "0xF666B0", VA = "0xF666B0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000193")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE830", Offset = "0x9AE830")]
	private sealed class <WaitThenInvokeLocaleSelectedEvent>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocalizationManager <>4__this;

		[Token(Token = "0x17000153")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000882")]
			[Address(RVA = "0xF667D8", Offset = "0xF667D8", VA = "0xF667D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000154")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000884")]
			[Address(RVA = "0xF66820", Offset = "0xF66820", VA = "0xF66820", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0xF666F8", Offset = "0xF666F8", VA = "0xF666F8")]
		[DebuggerHidden]
		public <WaitThenInvokeLocaleSelectedEvent>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0xF66724", Offset = "0xF66724", VA = "0xF66724", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0xF66728", Offset = "0xF66728", VA = "0xF66728", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0xF667E0", Offset = "0xF667E0", VA = "0xF667E0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000194")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE840", Offset = "0x9AE840")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TextMeshProUGUI tmpComponent;

		[Token(Token = "0x6000885")]
		[Address(RVA = "0xF65F34", Offset = "0xF65F34", VA = "0xF65F34")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0xF65F3C", Offset = "0xF65F3C", VA = "0xF65F3C")]
		internal void <SetLocalizedText>b__0(AsyncOperationHandle<string> op)
		{
		}
	}

	[Token(Token = "0x2000195")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE850", Offset = "0x9AE850")]
	private sealed class <>c__DisplayClass15_0
	{
		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TextMeshProUGUI tmpComponent;

		[Token(Token = "0x6000887")]
		[Address(RVA = "0xF65FB4", Offset = "0xF65FB4", VA = "0xF65FB4")]
		public <>c__DisplayClass15_0()
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0xF65FBC", Offset = "0xF65FBC", VA = "0xF65FBC")]
		internal void <SetLocalizedText>b__0(AsyncOperationHandle<string> op)
		{
		}
	}

	[Token(Token = "0x2000196")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE860", Offset = "0x9AE860")]
	private sealed class <>c__DisplayClass16_0
	{
		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action<string> action;

		[Token(Token = "0x6000889")]
		[Address(RVA = "0xF66034", Offset = "0xF66034", VA = "0xF66034")]
		public <>c__DisplayClass16_0()
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0xF6603C", Offset = "0xF6603C", VA = "0xF6603C")]
		internal void <SetLocalizedText>b__0(AsyncOperationHandle<string> op)
		{
		}
	}

	[Token(Token = "0x40007BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string selectedLanguageName;

	[Token(Token = "0x40007C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string selectedLanguageCode;

	[Token(Token = "0x40007C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int selectedLanguageIndex;

	[Token(Token = "0x40007C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Locale> languageOptions;

	[Token(Token = "0x40007C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool initialized;

	[Token(Token = "0x40007C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool displaySubtitles;

	[Token(Token = "0x40007C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private TextMeshProUGUI subtitlesTMP;

	[Token(Token = "0x40007C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public Events.EventLanguageUpdate OnLanguageUpdate;

	[Token(Token = "0x600086B")]
	[Address(RVA = "0xDEE558", Offset = "0xDEE558", VA = "0xDEE558")]
	private void Start()
	{
	}

	[Token(Token = "0x600086C")]
	[Address(RVA = "0xDEE744", Offset = "0xDEE744", VA = "0xDEE744")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B6260", Offset = "0x9B6260")]
	private IEnumerator InitializeLocalization()
	{
		return null;
	}

	[Token(Token = "0x600086D")]
	[Address(RVA = "0xDEE7B0", Offset = "0xDEE7B0", VA = "0xDEE7B0")]
	public void LocaleSelected(string languageCode)
	{
	}

	[Token(Token = "0x600086E")]
	[Address(RVA = "0xDEAB74", Offset = "0xDEAB74", VA = "0xDEAB74")]
	public string LocaleSelected(int index)
	{
		return null;
	}

	[Token(Token = "0x600086F")]
	[Address(RVA = "0xDEAA8C", Offset = "0xDEAA8C", VA = "0xDEAA8C")]
	public void SetSubtitlesDisplay(bool val)
	{
	}

	[Token(Token = "0x6000870")]
	[Address(RVA = "0xDEE97C", Offset = "0xDEE97C", VA = "0xDEE97C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B62C0", Offset = "0x9B62C0")]
	private IEnumerator WaitThenInvokeLocaleSelectedEvent()
	{
		return null;
	}

	[Token(Token = "0x6000871")]
	[Address(RVA = "0xDE0378", Offset = "0xDE0378", VA = "0xDE0378")]
	public void SetLocalizedText(string tableKey, string textKey, TextMeshProUGUI tmpComponent)
	{
	}

	[Token(Token = "0x6000872")]
	[Address(RVA = "0xDED940", Offset = "0xDED940", VA = "0xDED940")]
	public void SetLocalizedText(string tableKey, string textKey, TextMeshProUGUI tmpComponent, Dictionary<string, string> arguments)
	{
	}

	[Token(Token = "0x6000873")]
	[Address(RVA = "0xDEEA30", Offset = "0xDEEA30", VA = "0xDEEA30")]
	public void SetLocalizedText(string tableKey, string textKey, Action<string> action)
	{
	}

	[Token(Token = "0x6000874")]
	[Address(RVA = "0xDEECFC", Offset = "0xDEECFC", VA = "0xDEECFC")]
	public void SubtitlesOn(string textKey)
	{
	}

	[Token(Token = "0x6000875")]
	[Address(RVA = "0xDEEF88", Offset = "0xDEEF88", VA = "0xDEEF88")]
	public void SetSubtitleText(string text)
	{
	}

	[Token(Token = "0x6000876")]
	[Address(RVA = "0xDEE9E8", Offset = "0xDEE9E8", VA = "0xDEE9E8")]
	public void SubtitlesOff()
	{
	}

	[Token(Token = "0x6000877")]
	[Address(RVA = "0xDEF074", Offset = "0xDEF074", VA = "0xDEF074")]
	public LocalizationManager()
	{
	}

	[Token(Token = "0x6000878")]
	[Address(RVA = "0xDEF100", Offset = "0xDEF100", VA = "0xDEF100")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B6320", Offset = "0x9B6320")]
	private void <SubtitlesOn>b__17_0(AsyncOperationHandle<string> op)
	{
	}
}
[Token(Token = "0x2000197")]
public class LookAtPlayer : MonoBehaviour
{
	[Token(Token = "0x40007D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public Transform playerTransform;

	[Token(Token = "0x40007D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool allAngles;

	[Token(Token = "0x600088B")]
	[Address(RVA = "0xDEF254", Offset = "0xDEF254", VA = "0xDEF254")]
	private void Start()
	{
	}

	[Token(Token = "0x600088C")]
	[Address(RVA = "0xDEF304", Offset = "0xDEF304", VA = "0xDEF304")]
	private void Update()
	{
	}

	[Token(Token = "0x600088D")]
	[Address(RVA = "0xDEF3CC", Offset = "0xDEF3CC", VA = "0xDEF3CC")]
	public LookAtPlayer()
	{
	}
}
[Token(Token = "0x2000198")]
public class MainMenuSettingsUI : MonoBehaviour
{
	[Token(Token = "0x2000199")]
	public enum TypeOfButton
	{
		[Token(Token = "0x40007D8")]
		Meat,
		[Token(Token = "0x40007D9")]
		Alcoholic,
		[Token(Token = "0x40007DA")]
		SnapTurn,
		[Token(Token = "0x40007DB")]
		LocomotionTypes,
		[Token(Token = "0x40007DC")]
		ForceGrabber,
		[Token(Token = "0x40007DD")]
		AutoAimValues,
		[Token(Token = "0x40007DE")]
		QualityLevel
	}

	[Token(Token = "0x40007D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private int currentValue;

	[Token(Token = "0x40007D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI currentTMP;

	[Token(Token = "0x40007D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Image currentImage;

	[Token(Token = "0x40007D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TypeOfButton typeOfButton;

	[Token(Token = "0x40007D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Sprite[] valueSprites;

	[Token(Token = "0x600088E")]
	[Address(RVA = "0x272E8D0", Offset = "0x272E8D0", VA = "0x272E8D0")]
	private void Start()
	{
	}

	[Token(Token = "0x600088F")]
	[Address(RVA = "0x272F81C", Offset = "0x272F81C", VA = "0x272F81C")]
	public void ClickButton()
	{
	}

	[Token(Token = "0x6000890")]
	[Address(RVA = "0x272EA18", Offset = "0x272EA18", VA = "0x272EA18")]
	private int GetCurrentValue()
	{
		return default(int);
	}

	[Token(Token = "0x6000891")]
	[Address(RVA = "0x272F004", Offset = "0x272F004", VA = "0x272F004")]
	private void SetSetting()
	{
	}

	[Token(Token = "0x6000892")]
	[Address(RVA = "0x272F6A8", Offset = "0x272F6A8", VA = "0x272F6A8")]
	private void UpdateSpriteAndString()
	{
	}

	[Token(Token = "0x6000893")]
	[Address(RVA = "0x272F920", Offset = "0x272F920", VA = "0x272F920")]
	public MainMenuSettingsUI()
	{
	}
}
[Token(Token = "0x200019A")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x9AE870", Offset = "0x9AE870")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x9AE870", Offset = "0x9AE870")]
public class ParticleSystemAudio : MonoBehaviour
{
	[Token(Token = "0x200019B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE904", Offset = "0x9AE904")]
	private sealed class <PlayWhileEmiting>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string[] sounds;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystemAudio <>4__this;

		[Token(Token = "0x17000155")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600089C")]
			[Address(RVA = "0xF69F60", Offset = "0xF69F60", VA = "0xF69F60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000156")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600089E")]
			[Address(RVA = "0xF69FA8", Offset = "0xF69FA8", VA = "0xF69FA8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0xF69DD4", Offset = "0xF69DD4", VA = "0xF69DD4")]
		[DebuggerHidden]
		public <PlayWhileEmiting>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0xF69E00", Offset = "0xF69E00", VA = "0xF69E00", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0xF69E04", Offset = "0xF69E04", VA = "0xF69E04", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0xF69F68", Offset = "0xF69F68", VA = "0xF69F68", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40007DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string[] onBirthSounds;

	[Token(Token = "0x40007E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string[] onDeathSounds;

	[Token(Token = "0x40007E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int _numberOfParticles;

	[Token(Token = "0x40007E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioHandler _audioHandler;

	[Token(Token = "0x40007E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private ParticleSystem _particleSystem;

	[Token(Token = "0x40007E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string playingSound;

	[Token(Token = "0x6000894")]
	[Address(RVA = "0x27351A0", Offset = "0x27351A0", VA = "0x27351A0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000895")]
	[Address(RVA = "0x2735218", Offset = "0x2735218", VA = "0x2735218")]
	private void Update()
	{
	}

	[Token(Token = "0x6000896")]
	[Address(RVA = "0x2735284", Offset = "0x2735284", VA = "0x2735284")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B63D0", Offset = "0x9B63D0")]
	private IEnumerator PlayWhileEmiting(string[] sounds)
	{
		return null;
	}

	[Token(Token = "0x6000897")]
	[Address(RVA = "0x27352FC", Offset = "0x27352FC", VA = "0x27352FC")]
	public ParticleSystemAudio()
	{
	}

	[Token(Token = "0x6000898")]
	[Address(RVA = "0x2735304", Offset = "0x2735304", VA = "0x2735304")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B6430", Offset = "0x9B6430")]
	private bool <PlayWhileEmiting>b__8_0()
	{
		return default(bool);
	}
}
[Token(Token = "0x200019C")]
public class PrintLogsOnTMP : MonoBehaviour
{
	[Token(Token = "0x40007E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI logText;

	[Token(Token = "0x40007EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string myLog;

	[Token(Token = "0x40007EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Queue myLogQueue;

	[Token(Token = "0x600089F")]
	[Address(RVA = "0x273A358", Offset = "0x273A358", VA = "0x273A358")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60008A0")]
	[Address(RVA = "0x273A3D4", Offset = "0x273A3D4", VA = "0x273A3D4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60008A1")]
	[Address(RVA = "0x273A450", Offset = "0x273A450", VA = "0x273A450")]
	private void HandleLog(string logString, string stackTrace, LogType type)
	{
	}

	[Token(Token = "0x60008A2")]
	[Address(RVA = "0x273A834", Offset = "0x273A834", VA = "0x273A834")]
	public PrintLogsOnTMP()
	{
	}
}
[Token(Token = "0x200019D")]
public class PushBeersAway : MonoBehaviour
{
	[Token(Token = "0x200019E")]
	public enum PushingType
	{
		[Token(Token = "0x40007F2")]
		FROM_POINT,
		[Token(Token = "0x40007F3")]
		DIRECTION_X,
		[Token(Token = "0x40007F4")]
		DIRECTION_Z
	}

	[Serializable]
	[Token(Token = "0x200019F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE914", Offset = "0x9AE914")]
	private sealed class <>c
	{
		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<Rigidbody, bool> <>9__10_0;

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0xF6BB84", Offset = "0xF6BB84", VA = "0xF6BB84")]
		public <>c()
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0xF6BB8C", Offset = "0xF6BB8C", VA = "0xF6BB8C")]
		internal bool <RemoveNullValues>b__10_0(Rigidbody beer)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40007EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Rigidbody> beersInTrigger;

	[Token(Token = "0x40007ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float pushForceMultipler;

	[Token(Token = "0x40007EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float toppleForceMultipler;

	[Token(Token = "0x40007EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform centerToPushAwayFrom;

	[Token(Token = "0x40007F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public PushingType pushingType;

	[Token(Token = "0x60008A3")]
	[Address(RVA = "0x273A898", Offset = "0x273A898", VA = "0x273A898")]
	private void Start()
	{
	}

	[Token(Token = "0x60008A4")]
	[Address(RVA = "0x273A8F0", Offset = "0x273A8F0", VA = "0x273A8F0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60008A5")]
	[Address(RVA = "0x273A9BC", Offset = "0x273A9BC", VA = "0x273A9BC")]
	private void Update()
	{
	}

	[Token(Token = "0x60008A6")]
	[Address(RVA = "0x273AD98", Offset = "0x273AD98", VA = "0x273AD98")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60008A7")]
	[Address(RVA = "0x273AE30", Offset = "0x273AE30", VA = "0x273AE30")]
	private void RemoveNullValues()
	{
	}

	[Token(Token = "0x60008A8")]
	[Address(RVA = "0x273AF78", Offset = "0x273AF78", VA = "0x273AF78")]
	public PushBeersAway()
	{
	}
}
[Token(Token = "0x20001A0")]
public class QualitySettingsChange : MonoBehaviour
{
	[Token(Token = "0x40007F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int AndroidQualityInThisScene;

	[Token(Token = "0x60008AC")]
	[Address(RVA = "0x273AF8C", Offset = "0x273AF8C", VA = "0x273AF8C")]
	private void Start()
	{
	}

	[Token(Token = "0x60008AD")]
	[Address(RVA = "0x273AF9C", Offset = "0x273AF9C", VA = "0x273AF9C")]
	public void ChangeQualitySettings(int qualitySetting)
	{
	}

	[Token(Token = "0x60008AE")]
	[Address(RVA = "0x273AFAC", Offset = "0x273AFAC", VA = "0x273AFAC")]
	public void ChangeQualitySettings()
	{
	}

	[Token(Token = "0x60008AF")]
	[Address(RVA = "0x273B040", Offset = "0x273B040", VA = "0x273B040")]
	public QualitySettingsChange()
	{
	}
}
[Token(Token = "0x20001A1")]
public class RestartBirdBehaviour : MonoBehaviour
{
	[Token(Token = "0x20001A2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE924", Offset = "0x9AE924")]
	private sealed class <AskForConfirmation>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RestartBirdBehaviour <>4__this;

		[Token(Token = "0x17000157")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x228E680", Offset = "0x228E680", VA = "0x228E680", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000158")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x228E6C8", Offset = "0x228E6C8", VA = "0x228E6C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x228E478", Offset = "0x228E478", VA = "0x228E478")]
		[DebuggerHidden]
		public <AskForConfirmation>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x228E4A4", Offset = "0x228E4A4", VA = "0x228E4A4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x228E4A8", Offset = "0x228E4A8", VA = "0x228E4A8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x228E688", Offset = "0x228E688", VA = "0x228E688", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40007F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool readyToRestart;

	[Token(Token = "0x40007F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI text;

	[Token(Token = "0x40007FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Animator animator;

	[Token(Token = "0x40007FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioHandler audioHandler;

	[Token(Token = "0x40007FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float timeToConfirm;

	[Token(Token = "0x60008B0")]
	[Address(RVA = "0x273F580", Offset = "0x273F580", VA = "0x273F580")]
	private void Start()
	{
	}

	[Token(Token = "0x60008B1")]
	[Address(RVA = "0x273F5F8", Offset = "0x273F5F8", VA = "0x273F5F8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60008B2")]
	[Address(RVA = "0x273F710", Offset = "0x273F710", VA = "0x273F710")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B6490", Offset = "0x9B6490")]
	private IEnumerator AskForConfirmation()
	{
		return null;
	}

	[Token(Token = "0x60008B3")]
	[Address(RVA = "0x273F77C", Offset = "0x273F77C", VA = "0x273F77C")]
	public RestartBirdBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x20001A3")]
public class SavedData
{
	[Serializable]
	[Token(Token = "0x20001A4")]
	[ES3Serializable]
	public class ArcadeScore
	{
		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int score;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float timeElapsed;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int wavesSurvived;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string signatureImageSource;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string playerName;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public DateTime date;

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x228F1D8", Offset = "0x228F1D8", VA = "0x228F1D8")]
		public ArcadeScore(int _score = 0, float _timeElpased = 0f, int _wavesSurvived = 0, string _signature = "", string _playerName = "Annon")
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20001A5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE944", Offset = "0x9AE944")]
	private sealed class <>c
	{
		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<ArcadeScore, int> <>9__33_0;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<ArcadeScore, int> <>9__38_0;

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x228F1A0", Offset = "0x228F1A0", VA = "0x228F1A0")]
		public <>c()
		{
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x228F1A8", Offset = "0x228F1A8", VA = "0x228F1A8")]
		internal int <AddScoreAndReorder>b__33_0(ArcadeScore x)
		{
			return default(int);
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x228F1C0", Offset = "0x228F1C0", VA = "0x228F1C0")]
		internal int <GetScoreRank>b__38_0(ArcadeScore x)
		{
			return default(int);
		}
	}

	[Token(Token = "0x4000800")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int[] levelStars;

	[Token(Token = "0x4000801")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool[] levelUnlocked;

	[Token(Token = "0x4000802")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int[] levelAttempt;

	[Token(Token = "0x4000803")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int qualityLevel;

	[Token(Token = "0x4000804")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int[] levelFastestRun;

	[Token(Token = "0x4000805")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool enablesTeleport;

	[Token(Token = "0x4000806")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool enablesLocomotion;

	[Token(Token = "0x4000807")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	public bool snapTurn;

	[Token(Token = "0x4000808")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int autoAimLevel;

	[Token(Token = "0x4000809")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool forceGrabWithTrigger;

	[Token(Token = "0x400080A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float playerHeightAdjustment;

	[Token(Token = "0x400080B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float waistHeightAdjustment;

	[Token(Token = "0x400080C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float tableHeightAdjustment;

	[Token(Token = "0x400080D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float beerboxHeightAdjustment;

	[Token(Token = "0x400080E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string languageCode;

	[Token(Token = "0x400080F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool displaySubtitles;

	[Token(Token = "0x4000810")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	public bool meat;

	[Token(Token = "0x4000811")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
	public bool alcoholic;

	[Token(Token = "0x4000812")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int beerSkinIndex;

	[Token(Token = "0x4000813")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string boomerangSkin;

	[Token(Token = "0x4000814")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Color skinColor;

	[Token(Token = "0x4000815")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AF778", Offset = "0x9AF778")]
	public float musicVolumeLevel;

	[Token(Token = "0x4000816")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AF790", Offset = "0x9AF790")]
	public float sfxVolumeLevel;

	[Token(Token = "0x4000817")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<ArcadeScore> bestArcadeScores;

	[Token(Token = "0x4000818")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<ArcadeScore> bestCookingArcadeScores;

	[Token(Token = "0x4000819")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public int longestWaveRunArcade;

	[Token(Token = "0x400081A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public int longestWaveRunCookingArcade;

	[Token(Token = "0x400081B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float[] levelPassingFunFeedback;

	[Token(Token = "0x400081C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float[] levelPassingHardFeedback;

	[Token(Token = "0x400081D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public float[] level3StarsFunFeedback;

	[Token(Token = "0x400081E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public float[] level3StarsHardFeedback;

	[Token(Token = "0x60008BA")]
	[Address(RVA = "0x274010C", Offset = "0x274010C", VA = "0x274010C")]
	public void MagicStarsUnlock()
	{
	}

	[Token(Token = "0x60008BB")]
	[Address(RVA = "0x2740188", Offset = "0x2740188", VA = "0x2740188")]
	private List<ArcadeScore> AddScoreAndReorder(List<ArcadeScore> _scores, ArcadeScore _newScore)
	{
		return null;
	}

	[Token(Token = "0x60008BC")]
	[Address(RVA = "0x2740464", Offset = "0x2740464", VA = "0x2740464")]
	public string UpdateArcadeScore(int _score, int _waves, float _timeElapsed, ArcadeMode _mode, [Optional] Texture2D _signature)
	{
		return null;
	}

	[Token(Token = "0x60008BD")]
	[Address(RVA = "0x2740830", Offset = "0x2740830", VA = "0x2740830")]
	public int GetLongestArcadeWaveRun(ArcadeMode _mode)
	{
		return default(int);
	}

	[Token(Token = "0x60008BE")]
	[Address(RVA = "0x2740848", Offset = "0x2740848", VA = "0x2740848")]
	public int GetHighscore(ArcadeMode _mode)
	{
		return default(int);
	}

	[Token(Token = "0x60008BF")]
	[Address(RVA = "0x27408D8", Offset = "0x27408D8", VA = "0x27408D8")]
	public int GetLowScore(ArcadeMode _mode)
	{
		return default(int);
	}

	[Token(Token = "0x60008C0")]
	[Address(RVA = "0x274096C", Offset = "0x274096C", VA = "0x274096C")]
	public void GetScoreRank(ArcadeMode _mode, int _score, out List<ArcadeScore> tempListScores, out int index)
	{
	}

	[Token(Token = "0x60008C1")]
	[Address(RVA = "0x2740C84", Offset = "0x2740C84", VA = "0x2740C84")]
	public float GetHeightAdjustment(HeightAdjustmentOption _keyword)
	{
		return default(float);
	}

	[Token(Token = "0x60008C2")]
	[Address(RVA = "0x2740CCC", Offset = "0x2740CCC", VA = "0x2740CCC")]
	public void SetHeightAdjustment(HeightAdjustmentOption _keyword, float _value)
	{
	}

	[Token(Token = "0x60008C3")]
	[Address(RVA = "0x2740D0C", Offset = "0x2740D0C", VA = "0x2740D0C")]
	public int CountStars()
	{
		return default(int);
	}

	[Token(Token = "0x60008C4")]
	[Address(RVA = "0x2740D78", Offset = "0x2740D78", VA = "0x2740D78")]
	public void SetDefaults()
	{
	}

	[Token(Token = "0x60008C5")]
	[Address(RVA = "0x2740754", Offset = "0x2740754", VA = "0x2740754")]
	private string RandomStringGenerator(int lenght)
	{
		return null;
	}

	[Token(Token = "0x60008C6")]
	[Address(RVA = "0x2740DF4", Offset = "0x2740DF4", VA = "0x2740DF4")]
	public SavedData()
	{
	}
}
[Token(Token = "0x20001A6")]
public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
	[Token(Token = "0x4000828")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static T instance;

	[Token(Token = "0x17000159")]
	public static T Instance
	{
		[Token(Token = "0x60008CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700015A")]
	public static bool IsInitialized
	{
		[Token(Token = "0x60008CD")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60008CE")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x60008CF")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x60008D0")]
	public Singleton()
	{
	}
}
[Serializable]
[Token(Token = "0x20001A7")]
public class Sound
{
	[Token(Token = "0x4000829")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x400082A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip clip;

	[Token(Token = "0x400082B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AF7A8", Offset = "0x9AF7A8")]
	public float volume;

	[Token(Token = "0x400082C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AF7C0", Offset = "0x9AF7C0")]
	public float volumeVariance;

	[Token(Token = "0x400082D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AF7D8", Offset = "0x9AF7D8")]
	public float pitch;

	[Token(Token = "0x400082E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AF7F4", Offset = "0x9AF7F4")]
	public float pitchVariance;

	[Token(Token = "0x400082F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public float dopplerLevel;

	[Token(Token = "0x4000830")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[HideInInspector]
	public float spread;

	[Token(Token = "0x4000831")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AF82C", Offset = "0x9AF82C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AF82C", Offset = "0x9AF82C")]
	public float spatialBlend;

	[Token(Token = "0x4000832")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool loop;

	[Token(Token = "0x4000833")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public AudioMixerGroup mixerGroup;

	[Token(Token = "0x4000834")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public AudioSource source;

	[Token(Token = "0x60008D1")]
	[Address(RVA = "0x2742710", Offset = "0x2742710", VA = "0x2742710")]
	public Sound()
	{
	}
}
[Serializable]
[Token(Token = "0x20001A8")]
public class SoundGroup
{
	[Token(Token = "0x4000835")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x4000836")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip[] clips;

	[Token(Token = "0x4000837")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AF8A0", Offset = "0x9AF8A0")]
	public float volume;

	[Token(Token = "0x4000838")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AF8B8", Offset = "0x9AF8B8")]
	public float volumeVariance;

	[Token(Token = "0x4000839")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AF8D0", Offset = "0x9AF8D0")]
	public float pitch;

	[Token(Token = "0x400083A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AF8EC", Offset = "0x9AF8EC")]
	public float pitchVariance;

	[Token(Token = "0x400083B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public float dopplerLevel;

	[Token(Token = "0x400083C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[HideInInspector]
	public float spread;

	[Token(Token = "0x400083D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AF924", Offset = "0x9AF924")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AF924", Offset = "0x9AF924")]
	public float spatialBlend;

	[Token(Token = "0x400083E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool loop;

	[Token(Token = "0x400083F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public AudioMixerGroup mixerGroup;

	[Token(Token = "0x4000840")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public AudioSource source;

	[Token(Token = "0x60008D2")]
	[Address(RVA = "0x2742738", Offset = "0x2742738", VA = "0x2742738")]
	public SoundGroup()
	{
	}
}
[Token(Token = "0x20001A9")]
public class SwappableBeerbox : MonoBehaviour
{
	[Token(Token = "0x20001AA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE954", Offset = "0x9AE954")]
	private sealed class <SwapCoroutine>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SwappableBeerbox <>4__this;

		[Token(Token = "0x1700015B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008DA")]
			[Address(RVA = "0x228FE68", Offset = "0x228FE68", VA = "0x228FE68", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008DC")]
			[Address(RVA = "0x228FEB0", Offset = "0x228FEB0", VA = "0x228FEB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x228FBA0", Offset = "0x228FBA0", VA = "0x228FBA0")]
		[DebuggerHidden]
		public <SwapCoroutine>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x228FBCC", Offset = "0x228FBCC", VA = "0x228FBCC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x228FBD0", Offset = "0x228FBD0", VA = "0x228FBD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x228FE70", Offset = "0x228FE70", VA = "0x228FE70", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000841")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject originalBox;

	[Token(Token = "0x4000842")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject replaceBox;

	[Token(Token = "0x4000843")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject replaceBeers;

	[Token(Token = "0x4000844")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject SwapParticles;

	[Token(Token = "0x4000845")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject beerPuffParticles;

	[Token(Token = "0x4000846")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Beer[] beerCans;

	[Token(Token = "0x4000847")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private AudioHandler audioHandler;

	[Token(Token = "0x60008D3")]
	[Address(RVA = "0x2743170", Offset = "0x2743170", VA = "0x2743170")]
	private void Start()
	{
	}

	[Token(Token = "0x60008D4")]
	[Address(RVA = "0x27431E8", Offset = "0x27431E8", VA = "0x27431E8")]
	public void Swap()
	{
	}

	[Token(Token = "0x60008D5")]
	[Address(RVA = "0x2743214", Offset = "0x2743214", VA = "0x2743214")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B6540", Offset = "0x9B6540")]
	public IEnumerator SwapCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60008D6")]
	[Address(RVA = "0x2743280", Offset = "0x2743280", VA = "0x2743280")]
	public SwappableBeerbox()
	{
	}
}
[Token(Token = "0x20001AB")]
public class TimeAndObjectEnabler : MonoBehaviour
{
	[Token(Token = "0x20001AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE964", Offset = "0x9AE964")]
	private sealed class <SpawnNextEnemyCoroutine>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TimeAndObjectEnabler <>4__this;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float _time;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject _gameObject;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <i>5__2;

		[Token(Token = "0x1700015D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x229007C", Offset = "0x229007C", VA = "0x229007C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008E9")]
			[Address(RVA = "0x22900C4", Offset = "0x22900C4", VA = "0x22900C4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x228FEB8", Offset = "0x228FEB8", VA = "0x228FEB8")]
		[DebuggerHidden]
		public <SpawnNextEnemyCoroutine>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x228FEE4", Offset = "0x228FEE4", VA = "0x228FEE4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x228FEE8", Offset = "0x228FEE8", VA = "0x228FEE8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x2290084", Offset = "0x2290084", VA = "0x2290084", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400084B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool doneOnceFinished;

	[Token(Token = "0x400084C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int enemyCall;

	[Token(Token = "0x400084D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AF998", Offset = "0x9AF998")]
	public float elasticityMultiplier;

	[Token(Token = "0x400084E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9AF9D0", Offset = "0x9AF9D0")]
	public float[] intervalArray;

	[Token(Token = "0x400084F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AFA08", Offset = "0x9AFA08")]
	public float[] timeElasticity;

	[Token(Token = "0x4000850")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public Transform[] EnemyArray;

	[Token(Token = "0x4000851")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool stopSpawning;

	[Token(Token = "0x60008DD")]
	[Address(RVA = "0x2743288", Offset = "0x2743288", VA = "0x2743288")]
	private void Start()
	{
	}

	[Token(Token = "0x60008DE")]
	[Address(RVA = "0x27434F4", Offset = "0x27434F4", VA = "0x27434F4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B65F0", Offset = "0x9B65F0")]
	private IEnumerator SpawnNextEnemyCoroutine(GameObject _gameObject, float _time)
	{
		return null;
	}

	[Token(Token = "0x60008DF")]
	[Address(RVA = "0x2743580", Offset = "0x2743580", VA = "0x2743580")]
	private float ElasticTimeIncrement()
	{
		return default(float);
	}

	[Token(Token = "0x60008E0")]
	[Address(RVA = "0x27436F0", Offset = "0x27436F0", VA = "0x27436F0")]
	private void FinishedTheEnemies()
	{
	}

	[Token(Token = "0x60008E1")]
	[Address(RVA = "0x274378C", Offset = "0x274378C", VA = "0x274378C")]
	public void StopSpawning()
	{
	}

	[Token(Token = "0x60008E2")]
	[Address(RVA = "0x27437B8", Offset = "0x27437B8", VA = "0x27437B8")]
	private void OnAllRequestComplete()
	{
	}

	[Token(Token = "0x60008E3")]
	[Address(RVA = "0x2743818", Offset = "0x2743818", VA = "0x2743818")]
	public TimeAndObjectEnabler()
	{
	}
}
[Token(Token = "0x20001AD")]
public class TimeAndPlaceSpawner : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20001AE")]
	public struct timePlaceObject
	{
		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float time;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform transform;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject gameObject;
	}

	[Token(Token = "0x20001AF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE974", Offset = "0x9AE974")]
	private sealed class <SpawnEnemyCoroutine>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float _time;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject _gameObject;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform _transform;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TimeAndPlaceSpawner <>4__this;

		[Token(Token = "0x1700015F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008F0")]
			[Address(RVA = "0x22902A4", Offset = "0x22902A4", VA = "0x22902A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000160")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008F2")]
			[Address(RVA = "0x22902EC", Offset = "0x22902EC", VA = "0x22902EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x22900CC", Offset = "0x22900CC", VA = "0x22900CC")]
		[DebuggerHidden]
		public <SpawnEnemyCoroutine>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x22900F8", Offset = "0x22900F8", VA = "0x22900F8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x22900FC", Offset = "0x22900FC", VA = "0x22900FC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x22902AC", Offset = "0x22902AC", VA = "0x22902AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000858")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public timePlaceObject[] spawnableEnemiesArray;

	[Token(Token = "0x60008EA")]
	[Address(RVA = "0x27438A0", Offset = "0x27438A0", VA = "0x27438A0")]
	private void Start()
	{
	}

	[Token(Token = "0x60008EB")]
	[Address(RVA = "0x2743930", Offset = "0x2743930", VA = "0x2743930")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B66A0", Offset = "0x9B66A0")]
	private IEnumerator SpawnEnemyCoroutine(GameObject _gameObject, Transform _transform, float _time)
	{
		return null;
	}

	[Token(Token = "0x60008EC")]
	[Address(RVA = "0x27439C0", Offset = "0x27439C0", VA = "0x27439C0")]
	public TimeAndPlaceSpawner()
	{
	}
}
[Token(Token = "0x20001B0")]
public class TimerBirdBehaviour : MonoBehaviour
{
	[Token(Token = "0x20001B1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE984", Offset = "0x9AE984")]
	private sealed class <Warn>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TimerBirdBehaviour <>4__this;

		[Token(Token = "0x17000161")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000901")]
			[Address(RVA = "0x2290448", Offset = "0x2290448", VA = "0x2290448", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000162")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000903")]
			[Address(RVA = "0x2290490", Offset = "0x2290490", VA = "0x2290490", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x22902F4", Offset = "0x22902F4", VA = "0x22902F4")]
		[DebuggerHidden]
		public <Warn>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x2290320", Offset = "0x2290320", VA = "0x2290320", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x2290324", Offset = "0x2290324", VA = "0x2290324", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x2290450", Offset = "0x2290450", VA = "0x2290450", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000862")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool readyToFinish;

	[Token(Token = "0x4000863")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool finished;

	[Token(Token = "0x4000864")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject birdObject;

	[Token(Token = "0x4000865")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform pointToGo;

	[Token(Token = "0x4000866")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float verticalCurveValue;

	[Token(Token = "0x4000867")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Animator animator;

	[Token(Token = "0x4000868")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private AudioHandler audioHandler;

	[Token(Token = "0x4000869")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool flyOnAllEnemiesGone;

	[Token(Token = "0x400086A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	private bool allRequestsComplete;

	[Token(Token = "0x400086B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	private bool allEnemiesGone;

	[Token(Token = "0x400086C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float warnInterval;

	[Token(Token = "0x400086D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool warning;

	[Token(Token = "0x400086E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private int urgencyLevel;

	[Token(Token = "0x60008F3")]
	[Address(RVA = "0x27439C8", Offset = "0x27439C8", VA = "0x27439C8")]
	private void Start()
	{
	}

	[Token(Token = "0x60008F4")]
	[Address(RVA = "0x2743C68", Offset = "0x2743C68", VA = "0x2743C68")]
	private void AddLevelListeners()
	{
	}

	[Token(Token = "0x60008F5")]
	[Address(RVA = "0x2743E24", Offset = "0x2743E24", VA = "0x2743E24")]
	private void AllEnemiesGone()
	{
	}

	[Token(Token = "0x60008F6")]
	[Address(RVA = "0x2744450", Offset = "0x2744450", VA = "0x2744450")]
	private void AllRequestsComplete()
	{
	}

	[Token(Token = "0x60008F7")]
	[Address(RVA = "0x27444EC", Offset = "0x27444EC", VA = "0x27444EC")]
	private void GameFinished()
	{
	}

	[Token(Token = "0x60008F8")]
	[Address(RVA = "0x274457C", Offset = "0x274457C", VA = "0x274457C")]
	private void HitByBoomerangAnimation()
	{
	}

	[Token(Token = "0x60008F9")]
	[Address(RVA = "0x27445E8", Offset = "0x27445E8", VA = "0x27445E8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60008FA")]
	[Address(RVA = "0x2743EC0", Offset = "0x2743EC0", VA = "0x2743EC0")]
	private void FlyToPoint(Transform _transform)
	{
	}

	[Token(Token = "0x60008FB")]
	[Address(RVA = "0x2744738", Offset = "0x2744738", VA = "0x2744738")]
	public void WarnTime(float levelSecondsLeft)
	{
	}

	[Token(Token = "0x60008FC")]
	[Address(RVA = "0x27447E8", Offset = "0x27447E8", VA = "0x27447E8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B6750", Offset = "0x9B6750")]
	private IEnumerator Warn()
	{
		return null;
	}

	[Token(Token = "0x60008FD")]
	[Address(RVA = "0x2744854", Offset = "0x2744854", VA = "0x2744854")]
	public TimerBirdBehaviour()
	{
	}
}
[Token(Token = "0x20001B2")]
public class UnityAnalyticsStarter : MonoBehaviour
{
	[StructLayout(3)]
	[Token(Token = "0x20001B3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE994", Offset = "0x9AE994")]
	private struct <Start>d__1 : IAsyncStateMachine
	{
		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityAnalyticsStarter <>4__this;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter<List<string>> <>u__2;

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x2290934", Offset = "0x2290934", VA = "0x2290934", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x2290DC8", Offset = "0x2290DC8", VA = "0x2290DC8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000872")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool analyticsEnabled;

	[Token(Token = "0x6000904")]
	[Address(RVA = "0xECF37C", Offset = "0xECF37C", VA = "0xECF37C")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x9B6800", Offset = "0x9B6800")]
	private void Start()
	{
	}

	[Token(Token = "0x6000905")]
	[Address(RVA = "0xECF440", Offset = "0xECF440", VA = "0xECF440")]
	public void TestButton()
	{
	}

	[Token(Token = "0x6000906")]
	[Address(RVA = "0xECF7FC", Offset = "0xECF7FC", VA = "0xECF7FC")]
	public UnityAnalyticsStarter()
	{
	}
}
[Token(Token = "0x20001B4")]
public class UpdateHandMaterial : MonoBehaviour
{
	[Token(Token = "0x4000878")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material handMaterial;

	[Token(Token = "0x4000879")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private SkinnedMeshRenderer _renderer;

	[Token(Token = "0x6000909")]
	[Address(RVA = "0xECF804", Offset = "0xECF804", VA = "0xECF804")]
	private void Start()
	{
	}

	[Token(Token = "0x600090A")]
	[Address(RVA = "0xECF904", Offset = "0xECF904", VA = "0xECF904")]
	public void UpdateColor(Color newColor)
	{
	}

	[Token(Token = "0x600090B")]
	[Address(RVA = "0xECF998", Offset = "0xECF998", VA = "0xECF998")]
	public UpdateHandMaterial()
	{
	}
}
[Token(Token = "0x20001B5")]
public class VolumeSpawner : MonoBehaviour
{
	[Token(Token = "0x20001B6")]
	public enum SpawnType
	{
		[Token(Token = "0x4000888")]
		CircularArea,
		[Token(Token = "0x4000889")]
		SemicircularArea,
		[Token(Token = "0x400088A")]
		CubicVolume,
		[Token(Token = "0x400088B")]
		SpawnPoints
	}

	[Token(Token = "0x20001B7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AE9A4", Offset = "0x9AE9A4")]
	private sealed class <SpawnStuffCoroutine>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VolumeSpawner <>4__this;

		[Token(Token = "0x17000163")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000915")]
			[Address(RVA = "0x2291BD4", Offset = "0x2291BD4", VA = "0x2291BD4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000164")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000917")]
			[Address(RVA = "0x2291C1C", Offset = "0x2291C1C", VA = "0x2291C1C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x22919F4", Offset = "0x22919F4", VA = "0x22919F4")]
		[DebuggerHidden]
		public <SpawnStuffCoroutine>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x2291A20", Offset = "0x2291A20", VA = "0x2291A20", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x2291A24", Offset = "0x2291A24", VA = "0x2291A24", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x2291BDC", Offset = "0x2291BDC", VA = "0x2291BDC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400087A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SpawnType spawnType;

	[Token(Token = "0x400087B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9AFA50", Offset = "0x9AFA50")]
	public float xRange;

	[Token(Token = "0x400087C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float yRange;

	[Token(Token = "0x400087D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float zRange;

	[Token(Token = "0x400087E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9AFA88", Offset = "0x9AFA88")]
	public float radius;

	[Token(Token = "0x400087F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform[] pointsToSpawn;

	[Token(Token = "0x4000880")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int indexToSpawn;

	[Token(Token = "0x4000881")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9AFAC0", Offset = "0x9AFAC0")]
	public int numberOfTargets;

	[Token(Token = "0x4000882")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float timeDelay;

	[Token(Token = "0x4000883")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float timeUntilFirstSpawn;

	[Token(Token = "0x4000884")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject[] listOfObjectsToSpawn;

	[Token(Token = "0x4000885")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool spawnOnStart;

	[Token(Token = "0x4000886")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Vector3 positionToSpawn;

	[Token(Token = "0x600090C")]
	[Address(RVA = "0xED13A0", Offset = "0xED13A0", VA = "0xED13A0")]
	private void Start()
	{
	}

	[Token(Token = "0x600090D")]
	[Address(RVA = "0xED1980", Offset = "0xED1980", VA = "0xED1980")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B6870", Offset = "0x9B6870")]
	private IEnumerator SpawnStuffCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600090E")]
	[Address(RVA = "0xED141C", Offset = "0xED141C", VA = "0xED141C")]
	public void SpawnStuff(GameObject[] _listOfObjectsToSpawn)
	{
	}

	[Token(Token = "0x600090F")]
	[Address(RVA = "0xED19EC", Offset = "0xED19EC", VA = "0xED19EC")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000910")]
	[Address(RVA = "0xED1DF4", Offset = "0xED1DF4", VA = "0xED1DF4")]
	public VolumeSpawner()
	{
	}

	[Token(Token = "0x6000911")]
	[Address(RVA = "0xED1DFC", Offset = "0xED1DFC", VA = "0xED1DFC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9B68D0", Offset = "0x9B68D0")]
	private bool <SpawnStuffCoroutine>b__15_0()
	{
		return default(bool);
	}
}
[Token(Token = "0x20001B8")]
public class VrUtilsSingleton : Singleton<VrUtilsSingleton>
{
	[Token(Token = "0x6000918")]
	[Address(RVA = "0xED1E50", Offset = "0xED1E50", VA = "0xED1E50")]
	public VrUtilsSingleton()
	{
	}
}
[Token(Token = "0x20001B9")]
public class XDisplayManager : MonoBehaviour
{
	[Token(Token = "0x400088F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Image[] Xs;

	[Token(Token = "0x4000890")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int nextXIndex;

	[Token(Token = "0x4000891")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Sprite XOnSprite;

	[Token(Token = "0x4000892")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioHandler audioHandler;

	[Token(Token = "0x6000919")]
	[Address(RVA = "0xED30DC", Offset = "0xED30DC", VA = "0xED30DC")]
	private void Start()
	{
	}

	[Token(Token = "0x600091A")]
	[Address(RVA = "0xED3130", Offset = "0xED3130", VA = "0xED3130")]
	public void SetXNumber(int n)
	{
	}

	[Token(Token = "0x600091B")]
	[Address(RVA = "0xED32E4", Offset = "0xED32E4", VA = "0xED32E4")]
	public void TurnXOn()
	{
	}

	[Token(Token = "0x600091C")]
	[Address(RVA = "0xED31E4", Offset = "0xED31E4", VA = "0xED31E4")]
	private Image[] GetXs()
	{
		return null;
	}

	[Token(Token = "0x600091D")]
	[Address(RVA = "0xED33D0", Offset = "0xED33D0", VA = "0xED33D0")]
	public XDisplayManager()
	{
	}
}
[Token(Token = "0x20001BA")]
public class Spoon : MonoBehaviour
{
	[Token(Token = "0x4000893")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool spoonVegemited;

	[Token(Token = "0x4000894")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer spoonVegemiteMeshRenderer;

	[Token(Token = "0x4000895")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioHandler audioHandler;

	[Token(Token = "0x600091E")]
	[Address(RVA = "0x27429C0", Offset = "0x27429C0", VA = "0x27429C0")]
	private void Start()
	{
	}

	[Token(Token = "0x600091F")]
	[Address(RVA = "0x2742A14", Offset = "0x2742A14", VA = "0x2742A14")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000920")]
	[Address(RVA = "0x2742B78", Offset = "0x2742B78", VA = "0x2742B78")]
	public Spoon()
	{
	}
}
[Token(Token = "0x20001BB")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x9AE9B4", Offset = "0x9AE9B4")]
public class BuoyantObject : MonoBehaviour
{
	[Token(Token = "0x4000896")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Color red;

	[Token(Token = "0x4000897")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Color green;

	[Token(Token = "0x4000898")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Color blue;

	[Token(Token = "0x4000899")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Color orange;

	[Token(Token = "0x400089A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float steepness;

	[Token(Token = "0x400089B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float wavelength;

	[Token(Token = "0x400089C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float speed;

	[Token(Token = "0x400089D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float[] directions;

	[Token(Token = "0x400089E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9AFAF8", Offset = "0x9AFAF8")]
	public StylizedWaterURP water;

	[Token(Token = "0x400089F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9AFB30", Offset = "0x9AFB30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AFB30", Offset = "0x9AFB30")]
	public float strength;

	[Token(Token = "0x40008A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AFB84", Offset = "0x9AFB84")]
	public float objectDepth;

	[Token(Token = "0x40008A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float velocityDrag;

	[Token(Token = "0x40008A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float angularDrag;

	[Token(Token = "0x40008A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9AFBA0", Offset = "0x9AFBA0")]
	public Transform[] effectors;

	[Token(Token = "0x40008A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Rigidbody rb;

	[Token(Token = "0x40008A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Vector3[] effectorProjections;

	[Token(Token = "0x6000921")]
	[Address(RVA = "0xD31F6C", Offset = "0xD31F6C", VA = "0xD31F6C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000922")]
	[Address(RVA = "0xD320AC", Offset = "0xD320AC", VA = "0xD320AC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000923")]
	[Address(RVA = "0xD320CC", Offset = "0xD320CC", VA = "0xD320CC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000924")]
	[Address(RVA = "0xD3236C", Offset = "0xD3236C", VA = "0xD3236C")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000925")]
	[Address(RVA = "0xD32628", Offset = "0xD32628", VA = "0xD32628")]
	public BuoyantObject()
	{
	}
}
[Token(Token = "0x20001BC")]
[ExecuteAlways]
public class PlanarReflectionsRenderer : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20001BD")]
	public enum ResolutionScales
	{
		[Token(Token = "0x40008B6")]
		Full,
		[Token(Token = "0x40008B7")]
		Half,
		[Token(Token = "0x40008B8")]
		Third,
		[Token(Token = "0x40008B9")]
		Quarter
	}

	[Serializable]
	[Token(Token = "0x20001BE")]
	public enum SkipFrames
	{
		[Token(Token = "0x40008BB")]
		NoSkipFrame,
		[Token(Token = "0x40008BC")]
		EverySecondFrame,
		[Token(Token = "0x40008BD")]
		EveryThirdFrame,
		[Token(Token = "0x40008BE")]
		EveryFourthFrame
	}

	[Token(Token = "0x40008A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AFBD8", Offset = "0x9AFBD8")]
	public ResolutionScales ResolutionScale;

	[Token(Token = "0x40008A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AFC10", Offset = "0x9AFC10")]
	public SkipFrames SkipEveryNFrame;

	[Token(Token = "0x40008A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AFC48", Offset = "0x9AFC48")]
	public LayerMask LayersToReflect;

	[Token(Token = "0x40008A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AFC80", Offset = "0x9AFC80")]
	public bool RenderWithShadows;

	[Token(Token = "0x40008AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AFCB8", Offset = "0x9AFCB8")]
	public bool RenderWithOcclusionCulling;

	[Token(Token = "0x40008AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AFCF0", Offset = "0x9AFCF0")]
	public GameObject WaterPlane;

	[Token(Token = "0x40008AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AFD28", Offset = "0x9AFD28")]
	public float ClipPlaneOffset;

	[Token(Token = "0x40008AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AFD60", Offset = "0x9AFD60")]
	public int CameraRendererIndex;

	[Token(Token = "0x40008AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Camera reflectionCamera;

	[Token(Token = "0x40008AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private RenderTexture reflectionTexture;

	[Token(Token = "0x40008B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int reflectionTextureId;

	[Token(Token = "0x40008B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool fogBeforeReflections;

	[Token(Token = "0x40008B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int maxLodBeforeReflections;

	[Token(Token = "0x40008B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float lodBiasBeforeReflections;

	[Token(Token = "0x40008B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int currentFrame;

	[Token(Token = "0x6000926")]
	[Address(RVA = "0x2736DB4", Offset = "0x2736DB4", VA = "0x2736DB4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000927")]
	[Address(RVA = "0x2736E70", Offset = "0x2736E70", VA = "0x2736E70")]
	private void Cleanup()
	{
	}

	[Token(Token = "0x6000928")]
	[Address(RVA = "0x2737048", Offset = "0x2737048", VA = "0x2737048")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000929")]
	[Address(RVA = "0x273704C", Offset = "0x273704C", VA = "0x273704C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600092A")]
	[Address(RVA = "0x2737050", Offset = "0x2737050", VA = "0x2737050")]
	private void UpdateCamera(Camera src, Camera dest)
	{
	}

	[Token(Token = "0x600092B")]
	[Address(RVA = "0x2737164", Offset = "0x2737164", VA = "0x2737164")]
	private void UpdateReflectionCamera(Camera realCamera)
	{
	}

	[Token(Token = "0x600092C")]
	[Address(RVA = "0x27375C8", Offset = "0x27375C8", VA = "0x27375C8")]
	private Camera CreateReflectionCamera()
	{
		return null;
	}

	[Token(Token = "0x600092D")]
	[Address(RVA = "0x2737ACC", Offset = "0x2737ACC", VA = "0x2737ACC")]
	private Vector4 WorldToCameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
	{
		return default(Vector4);
	}

	[Token(Token = "0x600092E")]
	[Address(RVA = "0x2737BF8", Offset = "0x2737BF8", VA = "0x2737BF8")]
	private void CreatePlanarReflectionTexture(Camera cam)
	{
	}

	[Token(Token = "0x600092F")]
	[Address(RVA = "0x2737E60", Offset = "0x2737E60", VA = "0x2737E60")]
	private void RenderReflections(ScriptableRenderContext context, Camera camera)
	{
	}

	[Token(Token = "0x6000930")]
	[Address(RVA = "0x2737828", Offset = "0x2737828", VA = "0x2737828")]
	private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
	{
	}

	[Token(Token = "0x6000931")]
	[Address(RVA = "0x2737E3C", Offset = "0x2737E3C", VA = "0x2737E3C")]
	private float GetScaleValue()
	{
		return default(float);
	}

	[Token(Token = "0x6000932")]
	[Address(RVA = "0x2738000", Offset = "0x2738000", VA = "0x2738000")]
	private int GetSkipFrameValue()
	{
		return default(int);
	}

	[Token(Token = "0x6000933")]
	[Address(RVA = "0x2738020", Offset = "0x2738020", VA = "0x2738020")]
	public PlanarReflectionsRenderer()
	{
	}
}
[Token(Token = "0x20001BF")]
public class Feedback : MonoBehaviour
{
	[Token(Token = "0x40008BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject passingLevelFeedbackMagnetPrefab;

	[Token(Token = "0x40008C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject threeStarsFeedbackMagnetPrefab;

	[Token(Token = "0x40008C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject magnetsParent;

	[Token(Token = "0x6000934")]
	[Address(RVA = "0xDDEE8C", Offset = "0xDDEE8C", VA = "0xDDEE8C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000935")]
	[Address(RVA = "0xDDF7E0", Offset = "0xDDF7E0", VA = "0xDDF7E0")]
	public Feedback()
	{
	}
}
[Token(Token = "0x20001C0")]
public class FeedbackMagnet : MonoBehaviour
{
	[Token(Token = "0x40008C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int level;

	[Token(Token = "0x40008C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool threeStarFeedback;

	[Token(Token = "0x6000936")]
	[Address(RVA = "0xDDF7E8", Offset = "0xDDF7E8", VA = "0xDDF7E8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000937")]
	[Address(RVA = "0xDDEFC0", Offset = "0xDDEFC0", VA = "0xDDEFC0")]
	public void SetLevel(int _level)
	{
	}

	[Token(Token = "0x6000938")]
	[Address(RVA = "0xDDF930", Offset = "0xDDF930", VA = "0xDDF930")]
	private void SaveNewLocation(HVRGrabberBase arg0, HVRGrabbable arg1)
	{
	}

	[Token(Token = "0x6000939")]
	[Address(RVA = "0xDDFB58", Offset = "0xDDFB58", VA = "0xDDFB58")]
	public FeedbackMagnet()
	{
	}
}
[Token(Token = "0x20001C1")]
public class VegemiteInJar : MonoBehaviour
{
	[Token(Token = "0x40008C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float distanceToSpread;

	[Token(Token = "0x40008C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioHandler audioHandler;

	[Token(Token = "0x40008C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool empty;

	[Token(Token = "0x600093A")]
	[Address(RVA = "0xECF9A0", Offset = "0xECF9A0", VA = "0xECF9A0")]
	private void Start()
	{
	}

	[Token(Token = "0x600093B")]
	[Address(RVA = "0xECFA10", Offset = "0xECFA10", VA = "0xECFA10")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600093C")]
	[Address(RVA = "0xECFCB4", Offset = "0xECFCB4", VA = "0xECFCB4")]
	private void DestroyOnRelease(HVRGrabberBase _, HVRGrabbable __)
	{
	}

	[Token(Token = "0x600093D")]
	[Address(RVA = "0xECFD58", Offset = "0xECFD58", VA = "0xECFD58")]
	public VegemiteInJar()
	{
	}
}
[Token(Token = "0x20001C2")]
public class VegemiteTop : MonoBehaviour
{
	[Token(Token = "0x40008C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Joint joint;

	[Token(Token = "0x40008C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioHandler audioHandler;

	[Token(Token = "0x40008C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool topOff;

	[Token(Token = "0x40008CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private HVRGrabbable grabbableBase;

	[Token(Token = "0x40008CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private HVRGrabbable grabbable;

	[Token(Token = "0x40008CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private HVRHandGrabber hand;

	[Token(Token = "0x40008CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private MeshRenderer meshRenderer;

	[Token(Token = "0x40008CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public MeshRenderer fakeTopMeshRenderer;

	[Token(Token = "0x40008CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public VegemiteInJar vegemiteInJar;

	[Token(Token = "0x40008D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float topPopingForce;

	[Token(Token = "0x600093E")]
	[Address(RVA = "0xED01AC", Offset = "0xED01AC", VA = "0xED01AC")]
	private void Start()
	{
	}

	[Token(Token = "0x600093F")]
	[Address(RVA = "0xED03D4", Offset = "0xED03D4", VA = "0xED03D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000940")]
	[Address(RVA = "0xED05F4", Offset = "0xED05F4", VA = "0xED05F4")]
	private void ReleaseBase(HVRGrabberBase arg0, HVRGrabbable arg1)
	{
	}

	[Token(Token = "0x6000941")]
	[Address(RVA = "0xED0634", Offset = "0xED0634", VA = "0xED0634")]
	private void GrabBase(HVRGrabberBase grabber, HVRGrabbable arg1)
	{
	}

	[Token(Token = "0x6000942")]
	[Address(RVA = "0xED06C0", Offset = "0xED06C0", VA = "0xED06C0")]
	private void GrabTop(HVRGrabberBase arg0, HVRGrabbable arg1)
	{
	}

	[Token(Token = "0x6000943")]
	[Address(RVA = "0xED0484", Offset = "0xED0484", VA = "0xED0484")]
	public void TopComesOff(bool addForce = false)
	{
	}

	[Token(Token = "0x6000944")]
	[Address(RVA = "0xED06D4", Offset = "0xED06D4", VA = "0xED06D4")]
	public VegemiteTop()
	{
	}
}
[Token(Token = "0x20001C3")]
public class XROculusCaptureHelperTest : MonoBehaviour
{
	[Token(Token = "0x6000945")]
	[Address(RVA = "0xED33D8", Offset = "0xED33D8", VA = "0xED33D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000946")]
	[Address(RVA = "0xED3600", Offset = "0xED3600", VA = "0xED3600")]
	private void Start()
	{
	}

	[Token(Token = "0x6000947")]
	[Address(RVA = "0xED36F0", Offset = "0xED36F0", VA = "0xED36F0")]
	public XROculusCaptureHelperTest()
	{
	}
}
namespace StylizedWater
{
	[Token(Token = "0x20001C4")]
	public static class GerstnerWaveDisplacement
	{
		[Token(Token = "0x6000948")]
		[Address(RVA = "0xDE6E80", Offset = "0xDE6E80", VA = "0xDE6E80")]
		private static Vector3 GerstnerWave(Vector3 position, float steepness, float wavelength, float speed, float direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0xDE6F70", Offset = "0xDE6F70", VA = "0xDE6F70")]
		public static Vector3 GetWaveDisplacement(Vector3 position, float steepness, float wavelength, float speed, float[] directions)
		{
			return default(Vector3);
		}
	}
}
namespace DebugStuff
{
	[Token(Token = "0x20001C5")]
	public class inGameLogger : MonoBehaviour
	{
		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string myLog;

		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string output;

		[Token(Token = "0x40008D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string stack;

		[Token(Token = "0x600094A")]
		[Address(RVA = "0xED4F2C", Offset = "0xED4F2C", VA = "0xED4F2C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0xED4FA8", Offset = "0xED4FA8", VA = "0xED4FA8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0xED5024", Offset = "0xED5024", VA = "0xED5024")]
		public void Log(string logString, string stackTrace, LogType type)
		{
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0xED5138", Offset = "0xED5138", VA = "0xED5138")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0xED5230", Offset = "0xED5230", VA = "0xED5230")]
		public inGameLogger()
		{
		}
	}
}
namespace UnityTemplateProjects
{
	[Token(Token = "0x20001C6")]
	public class SimpleCameraController : MonoBehaviour
	{
		[Token(Token = "0x20001C7")]
		private class CameraState
		{
			[Token(Token = "0x40008DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yaw;

			[Token(Token = "0x40008DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pitch;

			[Token(Token = "0x40008DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float roll;

			[Token(Token = "0x40008DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float x;

			[Token(Token = "0x40008DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float y;

			[Token(Token = "0x40008E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float z;

			[Token(Token = "0x6000954")]
			[Address(RVA = "0x228F548", Offset = "0x228F548", VA = "0x228F548")]
			public void SetFromTransform(Transform t)
			{
			}

			[Token(Token = "0x6000955")]
			[Address(RVA = "0x228F5D0", Offset = "0x228F5D0", VA = "0x228F5D0")]
			public void Translate(Vector3 translation)
			{
			}

			[Token(Token = "0x6000956")]
			[Address(RVA = "0x228F64C", Offset = "0x228F64C", VA = "0x228F64C")]
			public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
			{
			}

			[Token(Token = "0x6000957")]
			[Address(RVA = "0x228F714", Offset = "0x228F714", VA = "0x228F714")]
			public void UpdateTransform(Transform t)
			{
			}

			[Token(Token = "0x6000958")]
			[Address(RVA = "0x228F760", Offset = "0x228F760", VA = "0x228F760")]
			public CameraState()
			{
			}
		}

		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CameraState m_TargetCameraState;

		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CameraState m_InterpolatingCameraState;

		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9AFD98", Offset = "0x9AFD98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AFD98", Offset = "0x9AFD98")]
		public float boost;

		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AFDF8", Offset = "0x9AFDF8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AFDF8", Offset = "0x9AFDF8")]
		public float positionLerpTime;

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9AFE50", Offset = "0x9AFE50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AFE50", Offset = "0x9AFE50")]
		public AnimationCurve mouseSensitivityCurve;

		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9AFEB0", Offset = "0x9AFEB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AFEB0", Offset = "0x9AFEB0")]
		public float rotationLerpTime;

		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9AFF08", Offset = "0x9AFF08")]
		public bool invertY;

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x2741E64", Offset = "0x2741E64", VA = "0x2741E64")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x2741EC4", Offset = "0x2741EC4", VA = "0x2741EC4")]
		private Vector3 GetInputTranslationDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0x2741FD8", Offset = "0x2741FD8", VA = "0x2741FD8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0x274209C", Offset = "0x274209C", VA = "0x274209C")]
		public SimpleCameraController()
		{
		}
	}
}
namespace HurricaneVR.Samples
{
	[Token(Token = "0x20001C8")]
	public class AussieItemsSocketFilter : HVREnumFlagsSocketFilter<AussieItems>
	{
		[Token(Token = "0x6000959")]
		[Address(RVA = "0xD29514", Offset = "0xD29514", VA = "0xD29514")]
		public AussieItemsSocketFilter()
		{
		}
	}
	[Token(Token = "0x20001C9")]
	public class AussieItemsSocketable : HVREnumFlagsSocketable<AussieItems>
	{
		[Token(Token = "0x600095A")]
		[Address(RVA = "0xD29560", Offset = "0xD29560", VA = "0xD29560")]
		public AussieItemsSocketable()
		{
		}
	}
	[Token(Token = "0x20001CA")]
	[Flags]
	public enum AussieItems
	{
		[Token(Token = "0x40008E2")]
		None = 0,
		[Token(Token = "0x40008E3")]
		Boomerang = 1,
		[Token(Token = "0x40008E4")]
		BeerPrimary = 2,
		[Token(Token = "0x40008E5")]
		Food = 4,
		[Token(Token = "0x40008E6")]
		BottomBun = 8,
		[Token(Token = "0x40008E7")]
		Hamburger = 0x10,
		[Token(Token = "0x40008E8")]
		TopBun = 0x20,
		[Token(Token = "0x40008E9")]
		Plate = 0x40,
		[Token(Token = "0x40008EA")]
		BeerSecondary = 0x80,
		[Token(Token = "0x40008EB")]
		BeerTertiary = 0x100,
		[Token(Token = "0x40008EC")]
		Snag = 0x200,
		[Token(Token = "0x40008ED")]
		Bread = 0x400,
		[Token(Token = "0x40008EE")]
		Cap = 0x800,
		[Token(Token = "0x40008EF")]
		SkewerStick = 0x1000,
		[Token(Token = "0x40008F0")]
		Shrimp = 0x2000,
		[Token(Token = "0x40008F1")]
		Hat = 0x4000,
		[Token(Token = "0x40008F2")]
		All = -1
	}
}
namespace MRCHelpers
{
	[Token(Token = "0x20001CB")]
	public class CopyTransform : MonoBehaviour
	{
		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_originalTransform;

		[Token(Token = "0x600095B")]
		[Address(RVA = "0xD3503C", Offset = "0xD3503C", VA = "0xD3503C")]
		private void Update()
		{
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0xD350BC", Offset = "0xD350BC", VA = "0xD350BC")]
		public CopyTransform()
		{
		}
	}
	[Token(Token = "0x20001CC")]
	public class OVRMixedRealityCaptureTestMod : MonoBehaviour
	{
		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inited;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Camera defaultExternalCamera;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private OVRPlugin.Fovf defaultFov;

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x2732488", Offset = "0x2732488", VA = "0x2732488")]
		private void Start()
		{
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x273254C", Offset = "0x273254C", VA = "0x273254C")]
		private void Initialize()
		{
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x27327B8", Offset = "0x27327B8", VA = "0x27327B8")]
		private void UpdateDefaultExternalCamera()
		{
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x2732B5C", Offset = "0x2732B5C", VA = "0x2732B5C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x2732CDC", Offset = "0x2732CDC", VA = "0x2732CDC")]
		public OVRMixedRealityCaptureTestMod()
		{
		}
	}
	[Token(Token = "0x20001CD")]
	public class RemoveMRCamerasTracking : MonoBehaviour
	{
		[Token(Token = "0x20001CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9AEA34", Offset = "0x9AEA34")]
		private sealed class <RemoveCamerasTracking>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RemoveMRCamerasTracking <>4__this;

			[Token(Token = "0x40008FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform <trackingSpaceTransform>5__2;

			[Token(Token = "0x40008FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string[] <camerasNames>5__3;

			[Token(Token = "0x40008FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private WaitForSeconds <waiter>5__4;

			[Token(Token = "0x17000165")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000968")]
				[Address(RVA = "0xF6DA9C", Offset = "0xF6DA9C", VA = "0xF6DA9C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000166")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600096A")]
				[Address(RVA = "0xF6DAE4", Offset = "0xF6DAE4", VA = "0xF6DAE4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000965")]
			[Address(RVA = "0xF6D778", Offset = "0xF6D778", VA = "0xF6D778")]
			[DebuggerHidden]
			public <RemoveCamerasTracking>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000966")]
			[Address(RVA = "0xF6D7A4", Offset = "0xF6D7A4", VA = "0xF6D7A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000967")]
			[Address(RVA = "0xF6D7A8", Offset = "0xF6D7A8", VA = "0xF6D7A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000969")]
			[Address(RVA = "0xF6DAA4", Offset = "0xF6DAA4", VA = "0xF6DAA4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x273C310", Offset = "0x273C310", VA = "0x273C310")]
		private void Start()
		{
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x273C33C", Offset = "0x273C33C", VA = "0x273C33C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B6930", Offset = "0x9B6930")]
		private IEnumerator RemoveCamerasTracking()
		{
			return null;
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x273C3A8", Offset = "0x273C3A8", VA = "0x273C3A8")]
		public RemoveMRCamerasTracking()
		{
		}
	}
}
namespace ES3Types
{
	[Token(Token = "0x20001CF")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x9AEA44", Offset = "0x9AEA44")]
	public class ES3UserType_ArcadeScore : ES3ObjectType
	{
		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600096B")]
		[Address(RVA = "0xDDCEF4", Offset = "0xDDCEF4", VA = "0xDDCEF4")]
		public ES3UserType_ArcadeScore()
		{
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0xDDCFC4", Offset = "0xDDCFC4", VA = "0xDDCFC4", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600096D")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600096E")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20001D0")]
	public class ES3UserType_ArcadeScoreArray : ES3ArrayType
	{
		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000970")]
		[Address(RVA = "0xDDD328", Offset = "0xDDD328", VA = "0xDDD328")]
		public ES3UserType_ArcadeScoreArray()
		{
		}
	}
}
