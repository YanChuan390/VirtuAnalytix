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
	[Address(RVA = "0x1EAB8FC", Offset = "0x1EAB8FC", VA = "0x1EAB8FC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1EAB900", Offset = "0x1EAB900", VA = "0x1EAB900")]
	private void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1EABA38", Offset = "0x1EABA38", VA = "0x1EABA38")]
	public BodyWithoutCameraMotion()
	{
	}
}
[Token(Token = "0x2000003")]
public class DesintegrateAndRespawn : MonoBehaviour
{
	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA0F8", Offset = "0xAAA0F8")]
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
			[Address(RVA = "0x1F4EF64", Offset = "0x1F4EF64", VA = "0x1F4EF64", Slot = "4")]
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
			[Address(RVA = "0x1F4EFAC", Offset = "0x1F4EFAC", VA = "0x1F4EFAC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x1F4ED08", Offset = "0x1F4ED08", VA = "0x1F4ED08")]
		[DebuggerHidden]
		public <desintegrationCoroutine>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x1F4ED34", Offset = "0x1F4ED34", VA = "0x1F4ED34", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x1F4ED38", Offset = "0x1F4ED38", VA = "0x1F4ED38", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x1F4EF6C", Offset = "0x1F4EF6C", VA = "0x1F4EF6C", Slot = "8")]
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
	[Address(RVA = "0x1EB4AE8", Offset = "0x1EB4AE8", VA = "0x1EB4AE8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1EB4CE0", Offset = "0x1EB4CE0", VA = "0x1EB4CE0")]
	private void Desintegrate(HVRGrabberBase arg0, HVRGrabbable arg1)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1EB4D0C", Offset = "0x1EB4D0C", VA = "0x1EB4D0C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAC5FC", Offset = "0xAAC5FC")]
	private IEnumerator desintegrationCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1EB4D78", Offset = "0x1EB4D78", VA = "0x1EB4D78")]
	private void StopDesintegraiton(HVRGrabberBase arg0, HVRGrabbable arg1)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1EB4DA4", Offset = "0x1EB4DA4", VA = "0x1EB4DA4")]
	private void SetDissolveAmount(float dissolveAmount)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1EB4EE4", Offset = "0x1EB4EE4", VA = "0x1EB4EE4")]
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
	[Address(RVA = "0x1F19E3C", Offset = "0x1F19E3C", VA = "0x1F19E3C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1F19F98", Offset = "0x1F19F98", VA = "0x1F19F98")]
	private void DisableChildHandCollision(HVRGrabberBase graber, HVRGrabbable grabbable)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1F1A080", Offset = "0x1F1A080", VA = "0x1F1A080")]
	public void FindDirectHandDisableChild(HVRGrabberBase socketGrabber, HVRGrabbable socketgrabbable)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1F1A1E0", Offset = "0x1F1A1E0", VA = "0x1F1A1E0")]
	private void DisableHandCollision(HVRGrabberBase graber, HVRGrabbable grabbable)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1F1A1E4", Offset = "0x1F1A1E4", VA = "0x1F1A1E4")]
	public DisableChildCollisionsTest()
	{
	}
}
[Token(Token = "0x2000006")]
public class FloatingBeersHelperScript : MonoBehaviour
{
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1F1FC70", Offset = "0x1F1FC70", VA = "0x1F1FC70")]
	private void Start()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1F1FC74", Offset = "0x1F1FC74", VA = "0x1F1FC74")]
	private void Update()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1F1FC78", Offset = "0x1F1FC78", VA = "0x1F1FC78")]
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
			[Address(RVA = "0x1FE6B48", Offset = "0x1FE6B48", VA = "0x1FE6B48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		public InputAction Trigger
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x1FE6B64", Offset = "0x1FE6B64", VA = "0x1FE6B64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		public InputAction PrimaryButton
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x1FE6B80", Offset = "0x1FE6B80", VA = "0x1FE6B80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		public InputAction PrimaryTouch
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x1FE6B9C", Offset = "0x1FE6B9C", VA = "0x1FE6B9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		public InputAction Menu
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x1FE6BB8", Offset = "0x1FE6BB8", VA = "0x1FE6BB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public InputAction Primary2DAxis
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x1FE6BD4", Offset = "0x1FE6BD4", VA = "0x1FE6BD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		public InputAction Primary2DAxisClick
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x1FE6BF0", Offset = "0x1FE6BF0", VA = "0x1FE6BF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		public InputAction Primary2DAxisTouch
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x1FE6C0C", Offset = "0x1FE6C0C", VA = "0x1FE6C0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		public InputAction Secondary2DAxis
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x1FE6C28", Offset = "0x1FE6C28", VA = "0x1FE6C28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public InputAction Secondary2DAxisClick
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x1FE6C44", Offset = "0x1FE6C44", VA = "0x1FE6C44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public InputAction Secondary2DAxisTouch
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x1FE6C60", Offset = "0x1FE6C60", VA = "0x1FE6C60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public InputAction Grip
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x1FE6C7C", Offset = "0x1FE6C7C", VA = "0x1FE6C7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		public InputAction GripPress
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x1FE6C98", Offset = "0x1FE6C98", VA = "0x1FE6C98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public InputAction SecondaryButton
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x1FE6CB4", Offset = "0x1FE6CB4", VA = "0x1FE6CB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public InputAction SecondaryTouch
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x1FE6CD0", Offset = "0x1FE6CD0", VA = "0x1FE6CD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		public InputAction TriggerTouch
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x1FE6CEC", Offset = "0x1FE6CEC", VA = "0x1FE6CEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public bool enabled
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x1FE6D74", Offset = "0x1FE6D74", VA = "0x1FE6D74")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1FE6B40", Offset = "0x1FE6B40", VA = "0x1FE6B40")]
		public LeftHandActions(HVRInputActions wrapper)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1FE6D08", Offset = "0x1FE6D08", VA = "0x1FE6D08")]
		public InputActionMap Get()
		{
			return null;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1FE6D24", Offset = "0x1FE6D24", VA = "0x1FE6D24")]
		public void Enable()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1FE6D4C", Offset = "0x1FE6D4C", VA = "0x1FE6D4C")]
		public void Disable()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1FE6D9C", Offset = "0x1FE6D9C", VA = "0x1FE6D9C")]
		public static implicit operator InputActionMap(LeftHandActions set)
		{
			return null;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1FE6DB4", Offset = "0x1FE6DB4", VA = "0x1FE6DB4")]
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
			[Address(RVA = "0x1FEA8E8", Offset = "0x1FEA8E8", VA = "0x1FEA8E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		public InputAction Trigger
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x1FEA904", Offset = "0x1FEA904", VA = "0x1FEA904")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		public InputAction PrimaryButton
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x1FEA920", Offset = "0x1FEA920", VA = "0x1FEA920")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		public InputAction PrimaryTouch
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x1FEA93C", Offset = "0x1FEA93C", VA = "0x1FEA93C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		public InputAction Menu
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x1FEA958", Offset = "0x1FEA958", VA = "0x1FEA958")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		public InputAction Primary2DAxis
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x1FEA974", Offset = "0x1FEA974", VA = "0x1FEA974")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		public InputAction Primary2DAxisClick
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x1FEA990", Offset = "0x1FEA990", VA = "0x1FEA990")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		public InputAction Primary2DAxisTouch
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x1FEA9AC", Offset = "0x1FEA9AC", VA = "0x1FEA9AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		public InputAction Secondary2DAxis
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x1FEA9C8", Offset = "0x1FEA9C8", VA = "0x1FEA9C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		public InputAction Secondary2DAxisClick
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x1FEA9E4", Offset = "0x1FEA9E4", VA = "0x1FEA9E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		public InputAction Secondary2DAxisTouch
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x1FEAA00", Offset = "0x1FEAA00", VA = "0x1FEAA00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		public InputAction Grip
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x1FEAA1C", Offset = "0x1FEAA1C", VA = "0x1FEAA1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		public InputAction GripPress
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x1FEAA38", Offset = "0x1FEAA38", VA = "0x1FEAA38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		public InputAction SecondaryButton
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x1FEAA54", Offset = "0x1FEAA54", VA = "0x1FEAA54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public InputAction SecondaryTouch
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x1FEAA70", Offset = "0x1FEAA70", VA = "0x1FEAA70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public InputAction TriggerTouch
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x1FEAA8C", Offset = "0x1FEAA8C", VA = "0x1FEAA8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public bool enabled
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x1FEAB14", Offset = "0x1FEAB14", VA = "0x1FEAB14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1FEA8E0", Offset = "0x1FEA8E0", VA = "0x1FEA8E0")]
		public RightHandActions(HVRInputActions wrapper)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1FEAAA8", Offset = "0x1FEAAA8", VA = "0x1FEAAA8")]
		public InputActionMap Get()
		{
			return null;
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1FEAAC4", Offset = "0x1FEAAC4", VA = "0x1FEAAC4")]
		public void Enable()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1FEAAEC", Offset = "0x1FEAAEC", VA = "0x1FEAAEC")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1FEAB3C", Offset = "0x1FEAB3C", VA = "0x1FEAB3C")]
		public static implicit operator InputActionMap(RightHandActions set)
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1FEAB54", Offset = "0x1FEAB54", VA = "0x1FEAB54")]
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
			[Address(RVA = "0x1FE6264", Offset = "0x1FE6264", VA = "0x1FE6264")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public InputAction hmdRotation
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x1FE6280", Offset = "0x1FE6280", VA = "0x1FE6280")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public bool enabled
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x1FE6308", Offset = "0x1FE6308", VA = "0x1FE6308")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1FE625C", Offset = "0x1FE625C", VA = "0x1FE625C")]
		public HMDActions(HVRInputActions wrapper)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1FE629C", Offset = "0x1FE629C", VA = "0x1FE629C")]
		public InputActionMap Get()
		{
			return null;
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1FE62B8", Offset = "0x1FE62B8", VA = "0x1FE62B8")]
		public void Enable()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1FE62E0", Offset = "0x1FE62E0", VA = "0x1FE62E0")]
		public void Disable()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1FE6330", Offset = "0x1FE6330", VA = "0x1FE6330")]
		public static implicit operator InputActionMap(HMDActions set)
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1FE6348", Offset = "0x1FE6348", VA = "0x1FE6348")]
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
			[Address(RVA = "0x1FEE688", Offset = "0x1FEE688", VA = "0x1FEE688")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public InputAction pointerPosition
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x1FEE6A4", Offset = "0x1FEE6A4", VA = "0x1FEE6A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public InputAction pointerRotation
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x1FEE6C0", Offset = "0x1FEE6C0", VA = "0x1FEE6C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public bool enabled
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x1FEE748", Offset = "0x1FEE748", VA = "0x1FEE748")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1FEE680", Offset = "0x1FEE680", VA = "0x1FEE680")]
		public UIActions(HVRInputActions wrapper)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1FEE6DC", Offset = "0x1FEE6DC", VA = "0x1FEE6DC")]
		public InputActionMap Get()
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1FEE6F8", Offset = "0x1FEE6F8", VA = "0x1FEE6F8")]
		public void Enable()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1FEE720", Offset = "0x1FEE720", VA = "0x1FEE720")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1FEE770", Offset = "0x1FEE770", VA = "0x1FEE770")]
		public static implicit operator InputActionMap(UIActions set)
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1FEE788", Offset = "0x1FEE788", VA = "0x1FEE788")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAB18C", Offset = "0xAAB18C")]
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
		[Address(RVA = "0x1F265B4", Offset = "0x1F265B4", VA = "0x1F265B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAC6AC", Offset = "0xAAC6AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	public InputBinding? bindingMask
	{
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1F26DD4", Offset = "0x1F26DD4", VA = "0x1F26DD4", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x1F26E00", Offset = "0x1F26E00", VA = "0x1F26E00", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public ReadOnlyArray<InputDevice>? devices
	{
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1F26E58", Offset = "0x1F26E58", VA = "0x1F26E58", Slot = "6")]
		get
		{
			return null;
		}
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1F26EA4", Offset = "0x1F26EA4", VA = "0x1F26EA4", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public ReadOnlyArray<InputControlScheme> controlSchemes
	{
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1F26EF4", Offset = "0x1F26EF4", VA = "0x1F26EF4", Slot = "8")]
		get
		{
			return default(ReadOnlyArray<InputControlScheme>);
		}
	}

	[Token(Token = "0x17000007")]
	public LeftHandActions LeftHand
	{
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1F26F9C", Offset = "0x1F26F9C", VA = "0x1F26F9C")]
		get
		{
			return default(LeftHandActions);
		}
	}

	[Token(Token = "0x17000008")]
	public RightHandActions RightHand
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1F26FA0", Offset = "0x1F26FA0", VA = "0x1F26FA0")]
		get
		{
			return default(RightHandActions);
		}
	}

	[Token(Token = "0x17000009")]
	public HMDActions HMD
	{
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1F26FA4", Offset = "0x1F26FA4", VA = "0x1F26FA4")]
		get
		{
			return default(HMDActions);
		}
	}

	[Token(Token = "0x1700000A")]
	public UIActions UI
	{
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1F26FA8", Offset = "0x1F26FA8", VA = "0x1F26FA8")]
		get
		{
			return default(UIActions);
		}
	}

	[Token(Token = "0x1700000B")]
	public InputControlScheme XRUsageScheme
	{
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1F26FAC", Offset = "0x1F26FAC", VA = "0x1F26FAC")]
		get
		{
			return default(InputControlScheme);
		}
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1F265BC", Offset = "0x1F265BC", VA = "0x1F265BC")]
	public HVRInputActions()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1F26D6C", Offset = "0x1F26D6C", VA = "0x1F26D6C", Slot = "14")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1F26F10", Offset = "0x1F26F10", VA = "0x1F26F10", Slot = "9")]
	public bool Contains(InputAction action)
	{
		return default(bool);
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1F26F2C", Offset = "0x1F26F2C", VA = "0x1F26F2C", Slot = "12")]
	public IEnumerator<InputAction> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1F26F48", Offset = "0x1F26F48", VA = "0x1F26F48", Slot = "13")]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1F26F64", Offset = "0x1F26F64", VA = "0x1F26F64", Slot = "10")]
	public void Enable()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1F26F80", Offset = "0x1F26F80", VA = "0x1F26F80", Slot = "11")]
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
	[Address(RVA = "0x1F298BC", Offset = "0x1F298BC", VA = "0x1F298BC")]
	public KetchupOrMustard()
	{
	}
}
[Token(Token = "0x2000011")]
public class KnifeBehaviour : MonoBehaviour
{
	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject knife;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject spoon;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MeshRenderer knifeMeshRenderer;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private MeshRenderer spoonMeshRenderer;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public HVRGrabbable grabbable;

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x1F298C4", Offset = "0x1F298C4", VA = "0x1F298C4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x1F29A70", Offset = "0x1F29A70", VA = "0x1F29A70")]
	private void ChangeToSpoon(HVRHandGrabber arg0, HVRGrabbable arg1)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x1F29B5C", Offset = "0x1F29B5C", VA = "0x1F29B5C")]
	public KnifeBehaviour()
	{
	}
}
[Token(Token = "0x2000012")]
public class RadioKnobJokeBehaviour : MonoBehaviour
{
	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject springObject;

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x1F1155C", Offset = "0x1F1155C", VA = "0x1F1155C")]
	private void OnJointBreak(float breakForce)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x1F115F4", Offset = "0x1F115F4", VA = "0x1F115F4")]
	public RadioKnobJokeBehaviour()
	{
	}
}
[Token(Token = "0x2000013")]
public class HellRubish : MonoBehaviour
{
	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool onHisWay;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UnityEvent OnRubishHitFloor;

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x1F27A84", Offset = "0x1F27A84", VA = "0x1F27A84")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x1F27B28", Offset = "0x1F27B28", VA = "0x1F27B28")]
	public HellRubish()
	{
	}
}
[Token(Token = "0x2000014")]
public class ParachuteBabyrooBehaviour : babyrooBehaviour
{
	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private GameObject parachute;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public GameObject parachuteGoneParticles;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private CapsuleCollider col;

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x1F0B1D8", Offset = "0x1F0B1D8", VA = "0x1F0B1D8", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x1F0B2DC", Offset = "0x1F0B2DC", VA = "0x1F0B2DC", Slot = "9")]
	protected override void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x1F0B5CC", Offset = "0x1F0B5CC", VA = "0x1F0B5CC", Slot = "6")]
	public override void KillMe()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x1F0B708", Offset = "0x1F0B708", VA = "0x1F0B708")]
	public ParachuteBabyrooBehaviour()
	{
	}
}
[Token(Token = "0x2000015")]
public class ParachuteBehaviour : MonoBehaviour
{
	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float yVelocity;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float xRadius;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float zRadius;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float rotationTime;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float initialX;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float initialY;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float initialZ;

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x1F0B710", Offset = "0x1F0B710", VA = "0x1F0B710")]
	private void Start()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x1F0B780", Offset = "0x1F0B780", VA = "0x1F0B780")]
	private void Update()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x1F0B88C", Offset = "0x1F0B88C", VA = "0x1F0B88C")]
	public ParachuteBehaviour()
	{
	}
}
[Token(Token = "0x2000016")]
public class babyrooBehaviour : Enemy
{
	[Serializable]
	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA108", Offset = "0xAAA108")]
	private sealed class <>c
	{
		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<HVRSocket> <>9__21_0;

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x22D15A0", Offset = "0x22D15A0", VA = "0x22D15A0")]
		public <>c()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x22D15A8", Offset = "0x22D15A8", VA = "0x22D15A8")]
		internal bool <OnCollisionEnter>b__21_0(HVRSocket s)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA118", Offset = "0xAAA118")]
	private sealed class <DontDetectCollisions>d__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public babyrooBehaviour <>4__this;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float _secondsToWait;

		[Token(Token = "0x17000035")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x22D1720", Offset = "0x22D1720", VA = "0x22D1720", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x22D1768", Offset = "0x22D1768", VA = "0x22D1768", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x22D161C", Offset = "0x22D161C", VA = "0x22D161C")]
		[DebuggerHidden]
		public <DontDetectCollisions>d__35(int <>1__state)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x22D1648", Offset = "0x22D1648", VA = "0x22D1648", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x22D164C", Offset = "0x22D164C", VA = "0x22D164C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x22D1728", Offset = "0x22D1728", VA = "0x22D1728", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA128", Offset = "0xAAA128")]
	private sealed class <RagDollDestroy>d__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public babyrooBehaviour <>4__this;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float delay;

		[Token(Token = "0x17000037")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x22D1938", Offset = "0x22D1938", VA = "0x22D1938", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x22D1980", Offset = "0x22D1980", VA = "0x22D1980", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x22D1770", Offset = "0x22D1770", VA = "0x22D1770")]
		[DebuggerHidden]
		public <RagDollDestroy>d__37(int <>1__state)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x22D179C", Offset = "0x22D179C", VA = "0x22D179C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x22D17A0", Offset = "0x22D17A0", VA = "0x22D17A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x22D1940", Offset = "0x22D1940", VA = "0x22D1940", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject grilledParticles;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject ragDollPoofParticles;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[HideInInspector]
	public Beer beerHeld;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected Rigidbody rb;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected Animator animator;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected HVRGrabbable grabbable;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private HVRSocket handSocket;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public int damageOnThrow;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAAB1AC", Offset = "0xAAB1AC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAAB1AC", Offset = "0xAAB1AC")]
	public float velocityToExplode;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected bool held;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	protected bool thrown;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAAB200", Offset = "0xAAB200")]
	public float scaleWhenGrabbed;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject grabbedCanBeerUI;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject grabbedBottleBeerUI;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public bool isFastRoo;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAAB218", Offset = "0xAAB218")]
	private bool useRagDoll;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public List<Collider> ragColliders;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Rigidbody mainBonerb;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public bool isRagdoll;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
	private bool aboutToDie;

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x1F44DE0", Offset = "0x1F44DE0", VA = "0x1F44DE0", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x1F452BC", Offset = "0x1F452BC", VA = "0x1F452BC", Slot = "9")]
	protected override void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x1F45B88", Offset = "0x1F45B88", VA = "0x1F45B88")]
	public GameObject FindClosestBeer()
	{
		return null;
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x1F45A30", Offset = "0x1F45A30", VA = "0x1F45A30")]
	private void GrabBeer(Beer _beer)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x1F45E80", Offset = "0x1F45E80", VA = "0x1F45E80", Slot = "11")]
	protected virtual void hopWithoutBeer()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x1F45FEC", Offset = "0x1F45FEC", VA = "0x1F45FEC", Slot = "12")]
	protected virtual void hopWithBeer()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x1F4613C", Offset = "0x1F4613C", VA = "0x1F4613C")]
	private void lookOutForBeers()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x1F461F4", Offset = "0x1F461F4", VA = "0x1F461F4", Slot = "6")]
	public override void KillMe()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x1F463D0", Offset = "0x1F463D0", VA = "0x1F463D0", Slot = "7")]
	public override void DestroyMe()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x1F464DC", Offset = "0x1F464DC", VA = "0x1F464DC", Slot = "13")]
	public virtual void onHeld([Optional] HVRGrabberBase _grabberBase, [Optional] HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x1F465F0", Offset = "0x1F465F0", VA = "0x1F465F0")]
	public void onThrow([Optional] HVRGrabberBase _grabberBase, [Optional] HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x1F465FC", Offset = "0x1F465FC", VA = "0x1F465FC", Slot = "14")]
	protected virtual void RecoverAfterThrow()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x1F46278", Offset = "0x1F46278", VA = "0x1F46278")]
	public void DropBeer(bool flyingBeer)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x1F46134", Offset = "0x1F46134", VA = "0x1F46134")]
	public void DropBeer()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1F45858", Offset = "0x1F45858", VA = "0x1F45858")]
	private void GrillBabyroo()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x1F46704", Offset = "0x1F46704", VA = "0x1F46704")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAC6BC", Offset = "0xAAC6BC")]
	private IEnumerator DontDetectCollisions(float _secondsToWait)
	{
		return null;
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x1F46780", Offset = "0x1F46780", VA = "0x1F46780")]
	public void OnHatOnHead()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x1F46460", Offset = "0x1F46460", VA = "0x1F46460")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAC71C", Offset = "0xAAC71C")]
	private IEnumerator RagDollDestroy(float delay)
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x1F46820", Offset = "0x1F46820", VA = "0x1F46820")]
	public void HitTheFloor()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x1F46848", Offset = "0x1F46848", VA = "0x1F46848")]
	public void SetRagDoll()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x1F46B48", Offset = "0x1F46B48", VA = "0x1F46B48")]
	public babyrooBehaviour()
	{
	}
}
[Token(Token = "0x200001A")]
public class DingoBehaviour : Enemy
{
	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA138", Offset = "0xAAA138")]
	private sealed class <UntoutchableFor>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DingoBehaviour <>4__this;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float _secondsToWait;

		[Token(Token = "0x17000039")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x1F4F19C", Offset = "0x1F4F19C", VA = "0x1F4F19C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x1F4F1E4", Offset = "0x1F4F1E4", VA = "0x1F4F1E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1F4EFF0", Offset = "0x1F4EFF0", VA = "0x1F4EFF0")]
		[DebuggerHidden]
		public <UntoutchableFor>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1F4F01C", Offset = "0x1F4F01C", VA = "0x1F4F01C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1F4F020", Offset = "0x1F4F020", VA = "0x1F4F020", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1F4F1A4", Offset = "0x1F4F1A4", VA = "0x1F4F1A4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public BeerBox beerBoxHeld;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected Rigidbody rb;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected Animator animator;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAAB260", Offset = "0xAAB260")]
	public Transform mouthTransform;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject grabbedBeerBoxUI;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool canGrabBeerBox;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public Vector3 startingPosition;

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x1EB55B4", Offset = "0x1EB55B4", VA = "0x1EB55B4", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x1EB5A44", Offset = "0x1EB5A44", VA = "0x1EB5A44", Slot = "9")]
	protected override void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x1EB574C", Offset = "0x1EB574C", VA = "0x1EB574C")]
	public GameObject FindClosestBeerBox()
	{
		return null;
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x1EB5AF0", Offset = "0x1EB5AF0", VA = "0x1EB5AF0")]
	private void GrabBeerBox(BeerBox _beerBox)
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x1EB5BF0", Offset = "0x1EB5BF0", VA = "0x1EB5BF0", Slot = "11")]
	protected virtual void HopWithoutBeerBox()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x1EB5D58", Offset = "0x1EB5D58", VA = "0x1EB5D58", Slot = "12")]
	protected virtual void HopWithBeerBox()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x1EB5DA0", Offset = "0x1EB5DA0", VA = "0x1EB5DA0")]
	private void lookOutForBeerBoxes()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x1EB5E58", Offset = "0x1EB5E58", VA = "0x1EB5E58", Slot = "6")]
	public override void KillMe()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x1EB5ED8", Offset = "0x1EB5ED8", VA = "0x1EB5ED8")]
	public void DropBeerBox()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x1EB5FD0", Offset = "0x1EB5FD0", VA = "0x1EB5FD0", Slot = "13")]
	public virtual void BeerBoxSteal()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x1EB6164", Offset = "0x1EB6164", VA = "0x1EB6164")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAC81C", Offset = "0xAAC81C")]
	private IEnumerator UntoutchableFor(float _secondsToWait)
	{
		return null;
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x1EB61E0", Offset = "0x1EB61E0", VA = "0x1EB61E0")]
	public DingoBehaviour()
	{
	}
}
[Token(Token = "0x200001C")]
public class Egg : MonoBehaviour
{
	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject spawnObject;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioHandler audioHandler;

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x1F1C41C", Offset = "0x1F1C41C", VA = "0x1F1C41C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x1F1C470", Offset = "0x1F1C470", VA = "0x1F1C470")]
	private void Spawn()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x1F1C544", Offset = "0x1F1C544", VA = "0x1F1C544")]
	public void CrackSound()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x1F1C59C", Offset = "0x1F1C59C", VA = "0x1F1C59C")]
	public Egg()
	{
	}
}
[Token(Token = "0x200001D")]
public class Emu : Enemy
{
	[Token(Token = "0x200001E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA148", Offset = "0xAAA148")]
	private sealed class <EmuInitialCoroutine>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Emu <>4__this;

		[Token(Token = "0x1700003B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x1FE23CC", Offset = "0x1FE23CC", VA = "0x1FE23CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x1FE2414", Offset = "0x1FE2414", VA = "0x1FE2414", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1FE22E4", Offset = "0x1FE22E4", VA = "0x1FE22E4")]
		[DebuggerHidden]
		public <EmuInitialCoroutine>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1FE2310", Offset = "0x1FE2310", VA = "0x1FE2310", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1FE2314", Offset = "0x1FE2314", VA = "0x1FE2314", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1FE23D4", Offset = "0x1FE23D4", VA = "0x1FE23D4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA158", Offset = "0xAAA158")]
	private sealed class <MoveToNextPointCoroutine>d__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Emu <>4__this;

		[Token(Token = "0x1700003D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x1FE2BA8", Offset = "0x1FE2BA8", VA = "0x1FE2BA8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x1FE2BF0", Offset = "0x1FE2BF0", VA = "0x1FE2BF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1FE2924", Offset = "0x1FE2924", VA = "0x1FE2924")]
		[DebuggerHidden]
		public <MoveToNextPointCoroutine>d__34(int <>1__state)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1FE2950", Offset = "0x1FE2950", VA = "0x1FE2950", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1FE2954", Offset = "0x1FE2954", VA = "0x1FE2954", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1FE2BB0", Offset = "0x1FE2BB0", VA = "0x1FE2BB0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA168", Offset = "0xAAA168")]
	private sealed class <CleanMoveToNextPointCoroutine>d__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Emu <>4__this;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int furthestPoint;

		[Token(Token = "0x1700003F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x1FE2294", Offset = "0x1FE2294", VA = "0x1FE2294", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x1FE22DC", Offset = "0x1FE22DC", VA = "0x1FE22DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1FE2028", Offset = "0x1FE2028", VA = "0x1FE2028")]
		[DebuggerHidden]
		public <CleanMoveToNextPointCoroutine>d__35(int <>1__state)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1FE2054", Offset = "0x1FE2054", VA = "0x1FE2054", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x1FE2058", Offset = "0x1FE2058", VA = "0x1FE2058", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1FE229C", Offset = "0x1FE229C", VA = "0x1FE229C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA178", Offset = "0xAAA178")]
	private sealed class <SpawnMiniEmuCoroutine>d__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Emu <>4__this;

		[Token(Token = "0x17000041")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x1FE37AC", Offset = "0x1FE37AC", VA = "0x1FE37AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x1FE37F4", Offset = "0x1FE37F4", VA = "0x1FE37F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1FE343C", Offset = "0x1FE343C", VA = "0x1FE343C")]
		[DebuggerHidden]
		public <SpawnMiniEmuCoroutine>d__37(int <>1__state)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1FE3468", Offset = "0x1FE3468", VA = "0x1FE3468", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1FE346C", Offset = "0x1FE346C", VA = "0x1FE346C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1FE37B4", Offset = "0x1FE37B4", VA = "0x1FE37B4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA188", Offset = "0xAAA188")]
	private sealed class <SpawnSpecialMiniEmuCoroutine>d__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Emu <>4__this;

		[Token(Token = "0x17000043")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x1FE3A54", Offset = "0x1FE3A54", VA = "0x1FE3A54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x1FE3A9C", Offset = "0x1FE3A9C", VA = "0x1FE3A9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1FE37FC", Offset = "0x1FE37FC", VA = "0x1FE37FC")]
		[DebuggerHidden]
		public <SpawnSpecialMiniEmuCoroutine>d__38(int <>1__state)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1FE3828", Offset = "0x1FE3828", VA = "0x1FE3828", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1FE382C", Offset = "0x1FE382C", VA = "0x1FE382C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1FE3A5C", Offset = "0x1FE3A5C", VA = "0x1FE3A5C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA198", Offset = "0xAAA198")]
	private sealed class <SpawnMiniEmuAndRocketCoroutine>d__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Emu <>4__this;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int rocketNumber;

		[Token(Token = "0x17000045")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x1FE33EC", Offset = "0x1FE33EC", VA = "0x1FE33EC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x1FE3434", Offset = "0x1FE3434", VA = "0x1FE3434", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1FE3094", Offset = "0x1FE3094", VA = "0x1FE3094")]
		[DebuggerHidden]
		public <SpawnMiniEmuAndRocketCoroutine>d__39(int <>1__state)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1FE30C0", Offset = "0x1FE30C0", VA = "0x1FE30C0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1FE30C4", Offset = "0x1FE30C4", VA = "0x1FE30C4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1FE33F4", Offset = "0x1FE33F4", VA = "0x1FE33F4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA1A8", Offset = "0xAAA1A8")]
	private sealed class <VulnerableCoroutine>d__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Emu <>4__this;

		[Token(Token = "0x17000047")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x1FE3F44", Offset = "0x1FE3F44", VA = "0x1FE3F44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x1FE3F8C", Offset = "0x1FE3F8C", VA = "0x1FE3F8C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1FE3AA4", Offset = "0x1FE3AA4", VA = "0x1FE3AA4")]
		[DebuggerHidden]
		public <VulnerableCoroutine>d__40(int <>1__state)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1FE3AD0", Offset = "0x1FE3AD0", VA = "0x1FE3AD0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1FE3AD4", Offset = "0x1FE3AD4", VA = "0x1FE3AD4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1FE3F4C", Offset = "0x1FE3F4C", VA = "0x1FE3F4C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA1B8", Offset = "0xAAA1B8")]
	private sealed class <GetHit>d__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Emu <>4__this;

		[Token(Token = "0x17000049")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x1FE2640", Offset = "0x1FE2640", VA = "0x1FE2640", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x1FE2688", Offset = "0x1FE2688", VA = "0x1FE2688", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1FE241C", Offset = "0x1FE241C", VA = "0x1FE241C")]
		[DebuggerHidden]
		public <GetHit>d__42(int <>1__state)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1FE2448", Offset = "0x1FE2448", VA = "0x1FE2448", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1FE244C", Offset = "0x1FE244C", VA = "0x1FE244C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1FE2648", Offset = "0x1FE2648", VA = "0x1FE2648", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA1C8", Offset = "0xAAA1C8")]
	private sealed class <RocketCoroutine>d__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Emu <>4__this;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int rocketNumber;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int <i>5__2;

		[Token(Token = "0x1700004B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x1FE3044", Offset = "0x1FE3044", VA = "0x1FE3044", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x1FE308C", Offset = "0x1FE308C", VA = "0x1FE308C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1FE2BF8", Offset = "0x1FE2BF8", VA = "0x1FE2BF8")]
		[DebuggerHidden]
		public <RocketCoroutine>d__43(int <>1__state)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1FE2C24", Offset = "0x1FE2C24", VA = "0x1FE2C24", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1FE2C28", Offset = "0x1FE2C28", VA = "0x1FE2C28", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1FE304C", Offset = "0x1FE304C", VA = "0x1FE304C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA1D8", Offset = "0xAAA1D8")]
	private sealed class <KillEmu>d__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Emu <>4__this;

		[Token(Token = "0x1700004D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x1FE28D4", Offset = "0x1FE28D4", VA = "0x1FE28D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x1FE291C", Offset = "0x1FE291C", VA = "0x1FE291C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1FE2690", Offset = "0x1FE2690", VA = "0x1FE2690")]
		[DebuggerHidden]
		public <KillEmu>d__44(int <>1__state)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1FE26BC", Offset = "0x1FE26BC", VA = "0x1FE26BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1FE26C0", Offset = "0x1FE26C0", VA = "0x1FE26C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1FE28DC", Offset = "0x1FE28DC", VA = "0x1FE28DC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAAB298", Offset = "0xAAB298")]
	public float chanceOfChangingDirection;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAAB2B0", Offset = "0xAAB2B0")]
	public float chanceOfRandom;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAAB2C8", Offset = "0xAAB2C8")]
	public float chanceOfRealEgg;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject pointsOfMovementParent;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<Transform> pointsOfMovement;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform pointToSpawnProjectile;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Transform pointToSpawnEmus;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject DirtParticles;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject miniEmuPrefab;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject specialMiniEmuPrefab;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject fakeMiniEmuPrefab;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject rocketPrefab;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public BossHealthBar healthBar;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public float[] rocketTimes;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public float[] rocketSharpnesses;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Transform playerTransform;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Animator animator;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Level15GPM gamePlayManager;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAAB2E0", Offset = "0xAAB2E0")]
	public bool reverseDirection;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public int currentMovementPoint;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public int nextMovementPoint;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public int moveNumbers;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public int trueEggsSpawned;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public int phaseNumber;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public bool isWaiting;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public int fakeEggsCounter;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private float rocketQuantityMultiplier;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	public float tauntWaitTime;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public GameObject tauntButtTarget;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private Vector3[] offsets;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public float offsetMultiplier;

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x1F1C5A4", Offset = "0x1F1C5A4", VA = "0x1F1C5A4")]
	private new void Start()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x1F1C914", Offset = "0x1F1C914", VA = "0x1F1C914")]
	private void DecideWhatToDo()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x1F1C8A8", Offset = "0x1F1C8A8", VA = "0x1F1C8A8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAC8CC", Offset = "0xAAC8CC")]
	private IEnumerator EmuInitialCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x1F1CBD0", Offset = "0x1F1CBD0", VA = "0x1F1CBD0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAC92C", Offset = "0xAAC92C")]
	private IEnumerator MoveToNextPointCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x1F1CE0C", Offset = "0x1F1CE0C", VA = "0x1F1CE0C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAC98C", Offset = "0xAAC98C")]
	private IEnumerator CleanMoveToNextPointCoroutine(int furthestPoint = 2)
	{
		return null;
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x1F1CE88", Offset = "0x1F1CE88", VA = "0x1F1CE88")]
	private int GetNextMovementPoint(int furthestPoint = 2)
	{
		return default(int);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x1F1CCA8", Offset = "0x1F1CCA8", VA = "0x1F1CCA8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAC9EC", Offset = "0xAAC9EC")]
	public IEnumerator SpawnMiniEmuCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x1F1CF5C", Offset = "0x1F1CF5C", VA = "0x1F1CF5C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAACA4C", Offset = "0xAACA4C")]
	public IEnumerator SpawnSpecialMiniEmuCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x1F1CD90", Offset = "0x1F1CD90", VA = "0x1F1CD90")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAACAAC", Offset = "0xAACAAC")]
	public IEnumerator SpawnMiniEmuAndRocketCoroutine(int rocketNumber)
	{
		return null;
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x1F1CC3C", Offset = "0x1F1CC3C", VA = "0x1F1CC3C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAACB0C", Offset = "0xAACB0C")]
	private IEnumerator VulnerableCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x1F1CFC8", Offset = "0x1F1CFC8", VA = "0x1F1CFC8", Slot = "5")]
	public override void GiveDamage(int damageToGive)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x1F1D168", Offset = "0x1F1D168", VA = "0x1F1D168")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAACB6C", Offset = "0xAACB6C")]
	private IEnumerator GetHit()
	{
		return null;
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x1F1CD14", Offset = "0x1F1CD14", VA = "0x1F1CD14")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAACBCC", Offset = "0xAACBCC")]
	private IEnumerator RocketCoroutine(int rocketNumber)
	{
		return null;
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x1F1D1D4", Offset = "0x1F1D1D4", VA = "0x1F1D1D4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAACC2C", Offset = "0xAACC2C")]
	private IEnumerator KillEmu()
	{
		return null;
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x1F1D240", Offset = "0x1F1D240", VA = "0x1F1D240")]
	public void DirtPopParticles()
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x1F1D260", Offset = "0x1F1D260", VA = "0x1F1D260")]
	public Emu()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x1F1D43C", Offset = "0x1F1D43C", VA = "0x1F1D43C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAACC8C", Offset = "0xAACC8C")]
	private bool <MoveToNextPointCoroutine>b__34_0()
	{
		return default(bool);
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x1F1D468", Offset = "0x1F1D468", VA = "0x1F1D468")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAACC9C", Offset = "0xAACC9C")]
	private bool <CleanMoveToNextPointCoroutine>b__35_0()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000028")]
public class MiniEmu : Enemy
{
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA1E8", Offset = "0xAAA1E8")]
	private sealed class <FollowAndExplode>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MiniEmu <>4__this;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds <_waitForSeconds>5__2;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <success>5__3;

		[Token(Token = "0x1700004F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x1FF41B0", Offset = "0x1FF41B0", VA = "0x1FF41B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x1FF41F8", Offset = "0x1FF41F8", VA = "0x1FF41F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1FF3EC8", Offset = "0x1FF3EC8", VA = "0x1FF3EC8")]
		[DebuggerHidden]
		public <FollowAndExplode>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1FF3EF4", Offset = "0x1FF3EF4", VA = "0x1FF3EF4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1FF3EF8", Offset = "0x1FF3EF8", VA = "0x1FF3EF8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1FF41B8", Offset = "0x1FF41B8", VA = "0x1FF41B8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA1F8", Offset = "0xAAA1F8")]
	private sealed class <delayedThrown>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float _time;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MiniEmu <>4__this;

		[Token(Token = "0x17000051")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x1FF42E8", Offset = "0x1FF42E8", VA = "0x1FF42E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x1FF4330", Offset = "0x1FF4330", VA = "0x1FF4330", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1FF4200", Offset = "0x1FF4200", VA = "0x1FF4200")]
		[DebuggerHidden]
		public <delayedThrown>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1FF422C", Offset = "0x1FF422C", VA = "0x1FF422C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1FF4230", Offset = "0x1FF4230", VA = "0x1FF4230", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1FF42F0", Offset = "0x1FF42F0", VA = "0x1FF42F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA208", Offset = "0xAAA208")]
	private sealed class <Autoaim>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MiniEmu <>4__this;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Emu <bigEmu>5__2;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForFixedUpdate <waitForFixedUpdate>5__3;

		[Token(Token = "0x17000053")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x1FF3E78", Offset = "0x1FF3E78", VA = "0x1FF3E78", Slot = "4")]
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
			[Address(RVA = "0x1FF3EC0", Offset = "0x1FF3EC0", VA = "0x1FF3EC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1FF3BC0", Offset = "0x1FF3BC0", VA = "0x1FF3BC0")]
		[DebuggerHidden]
		public <Autoaim>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1FF3BEC", Offset = "0x1FF3BEC", VA = "0x1FF3BEC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1FF3BF0", Offset = "0x1FF3BF0", VA = "0x1FF3BF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1FF3E80", Offset = "0x1FF3E80", VA = "0x1FF3E80", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Transform playerTransform;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Animator animator;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Rigidbody rb;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Dynamite dynamite;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float distanceToExplode;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public bool isSpecial;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
	private bool isRunningAway;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x76")]
	private bool thrown;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x77")]
	private bool exploded;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float autoAimMultiplier;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject cricketBatIconCanvas;

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x1F06100", Offset = "0x1F06100", VA = "0x1F06100", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x1F06404", Offset = "0x1F06404", VA = "0x1F06404")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAACFCC", Offset = "0xAACFCC")]
	private IEnumerator FollowAndExplode()
	{
		return null;
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x1F06470", Offset = "0x1F06470", VA = "0x1F06470")]
	public void Explode()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x1F06508", Offset = "0x1F06508", VA = "0x1F06508")]
	private void Explode(Dynamite _)
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x1F066EC", Offset = "0x1F066EC", VA = "0x1F066EC")]
	public void RunAway()
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x1F06890", Offset = "0x1F06890", VA = "0x1F06890")]
	public void BatHit()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x1F06AD4", Offset = "0x1F06AD4", VA = "0x1F06AD4")]
	public void FailedHit()
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x1F069EC", Offset = "0x1F069EC", VA = "0x1F069EC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAE02C", Offset = "0xAAE02C")]
	private IEnumerator delayedThrown(float _time)
	{
		return null;
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x1F06A68", Offset = "0x1F06A68", VA = "0x1F06A68")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAE08C", Offset = "0xAAE08C")]
	private IEnumerator Autoaim()
	{
		return null;
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x1F06B2C", Offset = "0x1F06B2C", VA = "0x1F06B2C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x1F06C70", Offset = "0x1F06C70", VA = "0x1F06C70")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x1F06CF0", Offset = "0x1F06CF0", VA = "0x1F06CF0")]
	private void OnFinish()
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x1F06D7C", Offset = "0x1F06D7C", VA = "0x1F06D7C")]
	private new void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x1F06F20", Offset = "0x1F06F20", VA = "0x1F06F20", Slot = "5")]
	public override void GiveDamage(int damageToGive)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x1F06FAC", Offset = "0x1F06FAC", VA = "0x1F06FAC")]
	public MiniEmu()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x1F06FC8", Offset = "0x1F06FC8", VA = "0x1F06FC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAE0EC", Offset = "0xAAE0EC")]
	private bool <FollowAndExplode>b__12_0()
	{
		return default(bool);
	}
}
[Token(Token = "0x200002C")]
public class Rocket : HomingProjectile
{
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA218", Offset = "0xAAA218")]
	private sealed class <ControlProjectileSharpness>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float[] times;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rocket <>4__this;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float[] sharpnesses;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <timeStamp>5__2;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <timeBetweenPoints>5__3;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int <i>5__4;

		[Token(Token = "0x17000055")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x22CDD10", Offset = "0x22CDD10", VA = "0x22CDD10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x22CDD58", Offset = "0x22CDD58", VA = "0x22CDD58", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x22CDB44", Offset = "0x22CDB44", VA = "0x22CDB44")]
		[DebuggerHidden]
		public <ControlProjectileSharpness>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x22CDB70", Offset = "0x22CDB70", VA = "0x22CDB70", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x22CDB74", Offset = "0x22CDB74", VA = "0x22CDB74", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x22CDD18", Offset = "0x22CDD18", VA = "0x22CDD18", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA228", Offset = "0xAAA228")]
	private sealed class <SetTarget>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float timeToWait;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rocket <>4__this;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 _offset;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float _randomRange;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <distance>5__2;

		[Token(Token = "0x17000057")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x22CE564", Offset = "0x22CE564", VA = "0x22CE564", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x22CE5AC", Offset = "0x22CE5AC", VA = "0x22CE5AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x22CDD60", Offset = "0x22CDD60", VA = "0x22CDD60")]
		[DebuggerHidden]
		public <SetTarget>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x22CDD8C", Offset = "0x22CDD8C", VA = "0x22CDD8C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x22CDD90", Offset = "0x22CDD90", VA = "0x22CDD90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x22CE56C", Offset = "0x22CE56C", VA = "0x22CE56C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Transform childTransform;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Transform playerTransform;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public float explosionRadius;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public CanvasGroup targetMarker;

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x1F15294", Offset = "0x1F15294", VA = "0x1F15294", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x1F15374", Offset = "0x1F15374", VA = "0x1F15374", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x1F15414", Offset = "0x1F15414", VA = "0x1F15414", Slot = "7")]
	protected override void DestroyProjectile(GameObject _particles, string _sound = "DestroySound")
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x1F15530", Offset = "0x1F15530", VA = "0x1F15530")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAE1EC", Offset = "0xAAE1EC")]
	public IEnumerator ControlProjectileSharpness(float[] times, float[] sharpnesses)
	{
		return null;
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x1F155B0", Offset = "0x1F155B0", VA = "0x1F155B0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x1F15678", Offset = "0x1F15678", VA = "0x1F15678")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAE24C", Offset = "0xAAE24C")]
	public IEnumerator SetTarget(float timeToWait, float _randomRange, Vector3 _offset)
	{
		return null;
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x1F1571C", Offset = "0x1F1571C", VA = "0x1F1571C")]
	public Rocket()
	{
	}
}
[Token(Token = "0x200002F")]
public class kangarooBehaviour : Enemy
{
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA238", Offset = "0xAAA238")]
	private sealed class <HopCoroutine>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public kangarooBehaviour <>4__this;

		[Token(Token = "0x17000059")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x22D1B90", Offset = "0x22D1B90", VA = "0x22D1B90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x22D1BD8", Offset = "0x22D1BD8", VA = "0x22D1BD8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x22D1988", Offset = "0x22D1988", VA = "0x22D1988")]
		[DebuggerHidden]
		public <HopCoroutine>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x22D19B4", Offset = "0x22D19B4", VA = "0x22D19B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x22D19B8", Offset = "0x22D19B8", VA = "0x22D19B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x22D1B98", Offset = "0x22D1B98", VA = "0x22D1B98", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA248", Offset = "0xAAA248")]
	private sealed class <MiniHopCoroutine>d__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public kangarooBehaviour <>4__this;

		[Token(Token = "0x1700005B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x22D1E3C", Offset = "0x22D1E3C", VA = "0x22D1E3C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x22D1E84", Offset = "0x22D1E84", VA = "0x22D1E84", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x22D1BE0", Offset = "0x22D1BE0", VA = "0x22D1BE0")]
		[DebuggerHidden]
		public <MiniHopCoroutine>d__34(int <>1__state)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x22D1C0C", Offset = "0x22D1C0C", VA = "0x22D1C0C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x22D1C10", Offset = "0x22D1C10", VA = "0x22D1C10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x22D1E44", Offset = "0x22D1E44", VA = "0x22D1E44", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float hopVelocity;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Rigidbody rb;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Animator animator;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool isHopping;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int hopSinceThrow;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int hopsLimitBetweenThrows;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAAB318", Offset = "0xAAB318")]
	public int minAngleRotation;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAAB334", Offset = "0xAAB334")]
	public int maxAngleRotation;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Transform babyrooEmission;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Transform babyrooDirection;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject babyroo;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float throwForce;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public int babyrooLimit;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float hopLimitMultiplier;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Transform playerCameraTransform;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAAB350", Offset = "0xAAB350")]
	public float distanceToFight;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public float perferedFighingDistance;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private bool fightMode;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject[] firstInjury;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public GameObject[] secondInjury;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Collider leftFist;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Collider rightFist;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public GameObject[] SlamParticles;

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x1F46F0C", Offset = "0x1F46F0C", VA = "0x1F46F0C", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x1F470A4", Offset = "0x1F470A4", VA = "0x1F470A4")]
	private void Update()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x1F471D0", Offset = "0x1F471D0", VA = "0x1F471D0", Slot = "5")]
	public override void GiveDamage(int damageToGive)
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x1F47324", Offset = "0x1F47324", VA = "0x1F47324")]
	public void HopStart()
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x1F475A8", Offset = "0x1F475A8", VA = "0x1F475A8")]
	public void HopEnd()
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x1F476E4", Offset = "0x1F476E4", VA = "0x1F476E4")]
	public void MiniHopStart()
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x1F47784", Offset = "0x1F47784", VA = "0x1F47784")]
	public void MiniHopEnd()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x1F477F0", Offset = "0x1F477F0", VA = "0x1F477F0")]
	public void ThrowBabyroo()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x1F47A28", Offset = "0x1F47A28", VA = "0x1F47A28")]
	public void randomRotation()
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x1F470B4", Offset = "0x1F470B4", VA = "0x1F470B4")]
	public void LookAtPlayer()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x1F4753C", Offset = "0x1F4753C", VA = "0x1F4753C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAE34C", Offset = "0xAAE34C")]
	private IEnumerator HopCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x1F47718", Offset = "0x1F47718", VA = "0x1F47718")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAE3AC", Offset = "0xAAE3AC")]
	private IEnumerator MiniHopCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x1F47370", Offset = "0x1F47370", VA = "0x1F47370")]
	private bool CloseToPlayer()
	{
		return default(bool);
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x1F47A98", Offset = "0x1F47A98", VA = "0x1F47A98")]
	private bool OneOutOfX(int x)
	{
		return default(bool);
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x1F47AC0", Offset = "0x1F47AC0", VA = "0x1F47AC0")]
	public void EnableRightFist()
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x1F47AE0", Offset = "0x1F47AE0", VA = "0x1F47AE0")]
	public void DisableRightFist()
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x1F47B00", Offset = "0x1F47B00", VA = "0x1F47B00")]
	public void EnableLeftFist()
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x1F47B20", Offset = "0x1F47B20", VA = "0x1F47B20")]
	public void DisableLeftFist()
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x1F47B40", Offset = "0x1F47B40", VA = "0x1F47B40", Slot = "10")]
	protected override void SlapEnemy(Collision collision)
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x1F47D84", Offset = "0x1F47D84", VA = "0x1F47D84")]
	public kangarooBehaviour()
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x1F47DAC", Offset = "0x1F47DAC", VA = "0x1F47DAC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAE40C", Offset = "0xAAE40C")]
	private bool <HopCoroutine>b__33_0()
	{
		return default(bool);
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x1F47DB4", Offset = "0x1F47DB4", VA = "0x1F47DB4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAE41C", Offset = "0xAAE41C")]
	private bool <MiniHopCoroutine>b__34_0()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000032")]
public class KoalaBehaviour : Enemy
{
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA258", Offset = "0xAAA258")]
	private sealed class <ThrowProjectileCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public KoalaBehaviour <>4__this;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds <_waitForSeconds>5__2;

		[Token(Token = "0x1700005D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x1FEFF00", Offset = "0x1FEFF00", VA = "0x1FEFF00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x1FEFF48", Offset = "0x1FEFF48", VA = "0x1FEFF48", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x1FEFDBC", Offset = "0x1FEFDBC", VA = "0x1FEFDBC")]
		[DebuggerHidden]
		public <ThrowProjectileCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1FEFDE8", Offset = "0x1FEFDE8", VA = "0x1FEFDE8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1FEFDEC", Offset = "0x1FEFDEC", VA = "0x1FEFDEC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1FEFF08", Offset = "0x1FEFF08", VA = "0x1FEFF08", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform pointToSpawnProjectile;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject projectile;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAAB388", Offset = "0xAAB388")]
	public float timeBetweenProjectiles;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float timeBetweenProjectilesMultiplier;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float timeToFirstProjectile;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float timeToFirstProjectileMultiplier;

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x1F29B64", Offset = "0x1F29B64", VA = "0x1F29B64", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x1F29C74", Offset = "0x1F29C74", VA = "0x1F29C74")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAE4CC", Offset = "0xAAE4CC")]
	private IEnumerator ThrowProjectileCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x1F29CE0", Offset = "0x1F29CE0", VA = "0x1F29CE0")]
	private void ThrowProjectile()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x1F29E64", Offset = "0x1F29E64", VA = "0x1F29E64")]
	public KoalaBehaviour()
	{
	}
}
[Token(Token = "0x2000034")]
public class platypusBehaviour : babyrooBehaviour
{
	[Token(Token = "0x6000188")]
	[Address(RVA = "0x1F47DBC", Offset = "0x1F47DBC", VA = "0x1F47DBC", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x1F47DFC", Offset = "0x1F47DFC", VA = "0x1F47DFC", Slot = "11")]
	protected override void hopWithoutBeer()
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x1F47E24", Offset = "0x1F47E24", VA = "0x1F47E24", Slot = "12")]
	protected override void hopWithBeer()
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x1F47E48", Offset = "0x1F47E48", VA = "0x1F47E48")]
	public platypusBehaviour()
	{
	}
}
[Token(Token = "0x2000035")]
public class QuokkaBehaviour : Enemy
{
	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA268", Offset = "0xAAA268")]
	private sealed class <WaitingForPhotoCoroutine>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public QuokkaBehaviour <>4__this;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int _timeToWait;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <_deltaTime>5__2;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <_timePassed>5__3;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <_timePassedSinceTextUpdate>5__4;

		[Token(Token = "0x1700005F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x22CAE9C", Offset = "0x22CAE9C", VA = "0x22CAE9C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x22CAEE4", Offset = "0x22CAEE4", VA = "0x22CAEE4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x22CAA44", Offset = "0x22CAA44", VA = "0x22CAA44")]
		[DebuggerHidden]
		public <WaitingForPhotoCoroutine>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x22CAA70", Offset = "0x22CAA70", VA = "0x22CAA70", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x22CAA74", Offset = "0x22CAA74", VA = "0x22CAA74", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x22CAEA4", Offset = "0x22CAEA4", VA = "0x22CAEA4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA278", Offset = "0xAAA278")]
	private sealed class <DelayDisaper>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public QuokkaBehaviour <>4__this;

		[Token(Token = "0x17000061")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x22CA9F4", Offset = "0x22CA9F4", VA = "0x22CA9F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x22CAA3C", Offset = "0x22CAA3C", VA = "0x22CAA3C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x22CA890", Offset = "0x22CA890", VA = "0x22CA890")]
		[DebuggerHidden]
		public <DelayDisaper>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x22CA8BC", Offset = "0x22CA8BC", VA = "0x22CA8BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x22CA8C0", Offset = "0x22CA8C0", VA = "0x22CA8C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x22CA9FC", Offset = "0x22CA9FC", VA = "0x22CA9FC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool readyForPhoto;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	private bool goingAway;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int timeToPhograph;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform pointToGoObject;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ParticleSystem photograhpedParticles;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ParticleSystem LeaveGameParticles;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject QuokkaSlot;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Renderer counterCircleRenderer;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Material counterCircleMaterial;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public TextMeshProUGUI timeText;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private IEnumerator waitingForPhoto;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected Animator animator;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Transform playerTransform;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private int jumps;

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x1F10614", Offset = "0x1F10614", VA = "0x1F10614", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x1F1087C", Offset = "0x1F1087C", VA = "0x1F1087C")]
	private void Update()
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x1F1092C", Offset = "0x1F1092C", VA = "0x1F1092C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x1F10BF0", Offset = "0x1F10BF0", VA = "0x1F10BF0")]
	private void CheckIfReachedDestination()
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x1F10C54", Offset = "0x1F10C54", VA = "0x1F10C54")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAE57C", Offset = "0xAAE57C")]
	private IEnumerator WaitingForPhotoCoroutine(int _timeToWait)
	{
		return null;
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x1F10CD0", Offset = "0x1F10CD0", VA = "0x1F10CD0")]
	private void RollAway()
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x1F10DE0", Offset = "0x1F10DE0", VA = "0x1F10DE0")]
	private void HappyJump()
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x1F10BC4", Offset = "0x1F10BC4", VA = "0x1F10BC4")]
	private void Disapear(float delay = 0f)
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x1F10E44", Offset = "0x1F10E44", VA = "0x1F10E44")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAE5DC", Offset = "0xAAE5DC")]
	private IEnumerator DelayDisaper(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x1F10EC0", Offset = "0x1F10EC0", VA = "0x1F10EC0")]
	public QuokkaBehaviour()
	{
	}
}
[Token(Token = "0x2000038")]
public class StickMealPart : MealPart
{
	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<ShrimpFoodAction> shrimps;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<HVRGrabbable> shrimpsGrabbables;

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x1F187A4", Offset = "0x1F187A4", VA = "0x1F187A4", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x1F17588", Offset = "0x1F17588", VA = "0x1F17588")]
	public void AddShrimp(ShrimpFoodAction shrimp)
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x1F18870", Offset = "0x1F18870", VA = "0x1F18870")]
	private void OnStickRelease(HVRHandGrabber grabber, HVRGrabbable _)
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x1F18998", Offset = "0x1F18998", VA = "0x1F18998")]
	public StickMealPart()
	{
	}
}
[Token(Token = "0x2000039")]
public class VegemiteSpawner : MonoBehaviour
{
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA288", Offset = "0xAAA288")]
	private sealed class <SpawnVegemite>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VegemiteSpawner <>4__this;

		[Token(Token = "0x17000063")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x22D0978", Offset = "0x22D0978", VA = "0x22D0978", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x22D09C0", Offset = "0x22D09C0", VA = "0x22D09C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x22D0268", Offset = "0x22D0268", VA = "0x22D0268")]
		[DebuggerHidden]
		public <SpawnVegemite>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x22D0294", Offset = "0x22D0294", VA = "0x22D0294", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x22D0298", Offset = "0x22D0298", VA = "0x22D0298", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x22D0980", Offset = "0x22D0980", VA = "0x22D0980", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform pointToGo;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform spawnPoint;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject cloud;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject breadPrefab;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject vegemitePrefab;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject particles;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float flyTime;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private AudioHandler audioHandler;

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x1F41060", Offset = "0x1F41060", VA = "0x1F41060")]
	private void Start()
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x1F410D4", Offset = "0x1F410D4", VA = "0x1F410D4")]
	private void FlyToPoint(Transform _transform)
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x1F41438", Offset = "0x1F41438", VA = "0x1F41438")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAE6DC", Offset = "0xAAE6DC")]
	private IEnumerator SpawnVegemite()
	{
		return null;
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x1F414A4", Offset = "0x1F414A4", VA = "0x1F414A4")]
	public VegemiteSpawner()
	{
	}
}
[Token(Token = "0x200003B")]
public class CricketGoal : MonoBehaviour
{
	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject successParticles;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioHandler audioHandler;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Rigidbody topBar1;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Rigidbody topBar2;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3 forceToApplyOnBar;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector3 torqueToApplyOnBar;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool canFall;

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x1EB4164", Offset = "0x1EB4164", VA = "0x1EB4164")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x1EB4354", Offset = "0x1EB4354", VA = "0x1EB4354")]
	private AudioHandler GetAudioHandler()
	{
		return null;
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x1EB43F4", Offset = "0x1EB43F4", VA = "0x1EB43F4")]
	public CricketGoal()
	{
	}
}
[Token(Token = "0x200003C")]
public class DownUnderDetection : MonoBehaviour
{
	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA298", Offset = "0xAAA298")]
	private sealed class <Cooldown>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DownUnderDetection <>4__this;

		[Token(Token = "0x17000065")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x1F4F460", Offset = "0x1F4F460", VA = "0x1F4F460", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000066")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x1F4F4A8", Offset = "0x1F4F4A8", VA = "0x1F4F4A8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1F4F368", Offset = "0x1F4F368", VA = "0x1F4F368")]
		[DebuggerHidden]
		public <Cooldown>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1F4F394", Offset = "0x1F4F394", VA = "0x1F4F394", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x1F4F398", Offset = "0x1F4F398", VA = "0x1F4F398", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x1F4F468", Offset = "0x1F4F468", VA = "0x1F4F468", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int[] targetNotesHit;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool inCooldown;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float cooldown;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int currentIndex;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioHandler audiohandler;

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x1F1AF78", Offset = "0x1F1AF78", VA = "0x1F1AF78")]
	private void Start()
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x1F1AFCC", Offset = "0x1F1AFCC", VA = "0x1F1AFCC")]
	public void HitNote(int i)
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x1F1B120", Offset = "0x1F1B120", VA = "0x1F1B120")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAE78C", Offset = "0xAAE78C")]
	private IEnumerator Cooldown()
	{
		return null;
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x1F1B18C", Offset = "0x1F1B18C", VA = "0x1F1B18C")]
	public DownUnderDetection()
	{
	}
}
[Token(Token = "0x200003E")]
public class AutoAimCone : MonoBehaviour
{
	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Boomerang boomerang;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Rigidbody boomerangRigidBody;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float autoAimIntensity;

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x1EA9010", Offset = "0x1EA9010", VA = "0x1EA9010")]
	private void Start()
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x1EA91C0", Offset = "0x1EA91C0", VA = "0x1EA91C0")]
	private void Update()
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x1EA90EC", Offset = "0x1EA90EC", VA = "0x1EA90EC")]
	public void SetAutoAimIntensity(int _autoAimValue)
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x1EA9270", Offset = "0x1EA9270", VA = "0x1EA9270")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x1EA94E8", Offset = "0x1EA94E8", VA = "0x1EA94E8")]
	public AutoAimCone()
	{
	}
}
[Token(Token = "0x200003F")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xAAA2A8", Offset = "0xAAA2A8")]
public class Boomerang : MonoBehaviour
{
	[Token(Token = "0x2000040")]
	public enum BoomerangState
	{
		[Token(Token = "0x4000170")]
		POCKET,
		[Token(Token = "0x4000171")]
		ON_HAND,
		[Token(Token = "0x4000172")]
		FLYING_OUT,
		[Token(Token = "0x4000173")]
		FLYING_IN,
		[Token(Token = "0x4000174")]
		FLOP,
		[Token(Token = "0x4000175")]
		BETWEEN_ELECTRIC_HITS
	}

	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA308", Offset = "0xAAA308")]
	private sealed class <ElectricVibration>d__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Boomerang <>4__this;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds <waitHalfSecond>5__2;

		[Token(Token = "0x17000067")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x1F4AF4C", Offset = "0x1F4AF4C", VA = "0x1F4AF4C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x1F4AF94", Offset = "0x1F4AF94", VA = "0x1F4AF94", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x1F4ADE4", Offset = "0x1F4ADE4", VA = "0x1F4ADE4")]
		[DebuggerHidden]
		public <ElectricVibration>d__41(int <>1__state)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x1F4AE10", Offset = "0x1F4AE10", VA = "0x1F4AE10", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x1F4AE14", Offset = "0x1F4AE14", VA = "0x1F4AE14", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x1F4AF54", Offset = "0x1F4AF54", VA = "0x1F4AF54", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA318", Offset = "0xAAA318")]
	private sealed class <DoubleHit>d__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Boomerang <>4__this;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Enemy _targetEnemy;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <time>5__2;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 <origin>5__3;

		[Token(Token = "0x17000069")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x1F4AD94", Offset = "0x1F4AD94", VA = "0x1F4AD94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x1F4ADDC", Offset = "0x1F4ADDC", VA = "0x1F4ADDC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x1F4AA48", Offset = "0x1F4AA48", VA = "0x1F4AA48")]
		[DebuggerHidden]
		public <DoubleHit>d__42(int <>1__state)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x1F4AA74", Offset = "0x1F4AA74", VA = "0x1F4AA74", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x1F4AA78", Offset = "0x1F4AA78", VA = "0x1F4AA78", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x1F4AD9C", Offset = "0x1F4AD9C", VA = "0x1F4AD9C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA328", Offset = "0xAAA328")]
	private sealed class <DestroyBoomerang>d__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Boomerang <>4__this;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x1700006B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x1F4A9F8", Offset = "0x1F4A9F8", VA = "0x1F4A9F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x1F4AA40", Offset = "0x1F4AA40", VA = "0x1F4AA40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x1F4A7B8", Offset = "0x1F4A7B8", VA = "0x1F4A7B8")]
		[DebuggerHidden]
		public <DestroyBoomerang>d__48(int <>1__state)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x1F4A7E4", Offset = "0x1F4A7E4", VA = "0x1F4A7E4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x1F4A7E8", Offset = "0x1F4A7E8", VA = "0x1F4A7E8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x1F4AA00", Offset = "0x1F4AA00", VA = "0x1F4AA00", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA338", Offset = "0xAAA338")]
	private sealed class <FlyOut>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Boomerang <>4__this;

		[Token(Token = "0x1700006D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x1F4B880", Offset = "0x1F4B880", VA = "0x1F4B880", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x1F4B8C8", Offset = "0x1F4B8C8", VA = "0x1F4B8C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1F4B4A8", Offset = "0x1F4B4A8", VA = "0x1F4B4A8")]
		[DebuggerHidden]
		public <FlyOut>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x1F4B4D4", Offset = "0x1F4B4D4", VA = "0x1F4B4D4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x1F4B4D8", Offset = "0x1F4B4D8", VA = "0x1F4B4D8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x1F4B888", Offset = "0x1F4B888", VA = "0x1F4B888", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA348", Offset = "0xAAA348")]
	private sealed class <FlyIn>d__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Boomerang <>4__this;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3[] _curvePoints;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float _startSlowDown;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float _curveTime;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <time>5__2;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <slowReceptionMultiplier>5__3;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool <setOriginalLayerFlag>5__4;

		[Token(Token = "0x1700006F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x1F4B458", Offset = "0x1F4B458", VA = "0x1F4B458", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x1F4B4A0", Offset = "0x1F4B4A0", VA = "0x1F4B4A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x1F4AF9C", Offset = "0x1F4AF9C", VA = "0x1F4AF9C")]
		[DebuggerHidden]
		public <FlyIn>d__51(int <>1__state)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x1F4AFC8", Offset = "0x1F4AFC8", VA = "0x1F4AFC8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x1F4AFCC", Offset = "0x1F4AFCC", VA = "0x1F4AFCC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x1F4B460", Offset = "0x1F4B460", VA = "0x1F4B460", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000046")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA358", Offset = "0xAAA358")]
	private sealed class <SpawnAnimation>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Boomerang <>4__this;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <animationTime>5__2;

		[Token(Token = "0x17000071")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x1F4BC94", Offset = "0x1F4BC94", VA = "0x1F4BC94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x1F4BCDC", Offset = "0x1F4BCDC", VA = "0x1F4BCDC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x1F4BB8C", Offset = "0x1F4BB8C", VA = "0x1F4BB8C")]
		[DebuggerHidden]
		public <SpawnAnimation>d__52(int <>1__state)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x1F4BBB8", Offset = "0x1F4BBB8", VA = "0x1F4BBB8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x1F4BBBC", Offset = "0x1F4BBBC", VA = "0x1F4BBBC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x1F4BC9C", Offset = "0x1F4BC9C", VA = "0x1F4BC9C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA368", Offset = "0xAAA368")]
	private sealed class <DestroyAnimation>d__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Boomerang <>4__this;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <animationTime>5__2;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <_time>5__3;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <dissolveAmount>5__4;

		[Token(Token = "0x17000073")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x1F4A768", Offset = "0x1F4A768", VA = "0x1F4A768", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000210")]
			[Address(RVA = "0x1F4A7B0", Offset = "0x1F4A7B0", VA = "0x1F4A7B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x1F4A5DC", Offset = "0x1F4A5DC", VA = "0x1F4A5DC")]
		[DebuggerHidden]
		public <DestroyAnimation>d__53(int <>1__state)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x1F4A608", Offset = "0x1F4A608", VA = "0x1F4A608", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x1F4A60C", Offset = "0x1F4A60C", VA = "0x1F4A60C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1F4A770", Offset = "0x1F4A770", VA = "0x1F4A770", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA378", Offset = "0xAAA378")]
	private sealed class <>c__DisplayClass59_0
	{
		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Enemy _hitEnemy;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<Enemy, bool> <>9__0;

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1F4A55C", Offset = "0x1F4A55C", VA = "0x1F4A55C")]
		public <>c__DisplayClass59_0()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x1F4A564", Offset = "0x1F4A564", VA = "0x1F4A564")]
		internal bool <FindRandomCloseEnemy>b__0(Enemy val)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA388", Offset = "0xAAA388")]
	private sealed class <ShortlyIgnoringEnemies>d__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Boomerang <>4__this;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float _time;

		[Token(Token = "0x17000075")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x1F4B9D8", Offset = "0x1F4B9D8", VA = "0x1F4B9D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x1F4BA20", Offset = "0x1F4BA20", VA = "0x1F4BA20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x1F4B8D0", Offset = "0x1F4B8D0", VA = "0x1F4B8D0")]
		[DebuggerHidden]
		public <ShortlyIgnoringEnemies>d__62(int <>1__state)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x1F4B8FC", Offset = "0x1F4B8FC", VA = "0x1F4B8FC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x1F4B900", Offset = "0x1F4B900", VA = "0x1F4B900", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x1F4B9E0", Offset = "0x1F4B9E0", VA = "0x1F4B9E0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA398", Offset = "0xAAA398")]
	private sealed class <ShortlyUncolidable>d__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Boomerang <>4__this;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float _time;

		[Token(Token = "0x17000077")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x1F4BB3C", Offset = "0x1F4BB3C", VA = "0x1F4BB3C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x1F4BB84", Offset = "0x1F4BB84", VA = "0x1F4BB84", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x1F4BA28", Offset = "0x1F4BA28", VA = "0x1F4BA28")]
		[DebuggerHidden]
		public <ShortlyUncolidable>d__63(int <>1__state)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1F4BA54", Offset = "0x1F4BA54", VA = "0x1F4BA54", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1F4BA58", Offset = "0x1F4BA58", VA = "0x1F4BA58", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1F4BB44", Offset = "0x1F4BB44", VA = "0x1F4BB44", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float angularVelocityMultiplier;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float velocityMultiplier;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float timeBeforeReturn;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float timeFlyInNatural;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float timeFlyInHitEnemy;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAAB3A0", Offset = "0xAAB3A0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAAB3A0", Offset = "0xAAB3A0")]
	public float HardnessToThrow;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool isFrisbie;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAAB3F4", Offset = "0xAAB3F4")]
	public float gravityFlyingOut;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int damageToGive;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float timeUntilDestruction;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int timesCatched;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool electric;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ParticleSystem OnCatchParticles;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ParticleSystem ElectricityParticles;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject ElectricTrailRenderer;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject ElectricHitParticles;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float ElectricDoubleHitDistance;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public BoomerangState state;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private TrailRenderer trailRenderer;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Rigidbody rb;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Collider[] _colliders;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Material material;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public AudioHandler audioHandler;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private int layerBoomerangFlyingIn;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private int layerDefault;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public AutoAimCone autoAimCone;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public bool ignoreEnemies;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[HideInInspector]
	public HVRGrabbable grabbable;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private float slowMoBoostFlyingOut;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private float slowMoBoostFlyingIn;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private CharacterController playerController;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private WaitForFixedUpdate waitForFixedUpdate;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private float _dissolveAmount;

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x1EABA40", Offset = "0x1EABA40", VA = "0x1EABA40")]
	protected void Awake()
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x1EABD04", Offset = "0x1EABD04", VA = "0x1EABD04")]
	protected void Start()
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x1EABFD0", Offset = "0x1EABFD0", VA = "0x1EABFD0")]
	private void Update()
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x1EAC094", Offset = "0x1EAC094", VA = "0x1EAC094")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x1EAC1D8", Offset = "0x1EAC1D8", VA = "0x1EAC1D8")]
	protected void BoomerangGrabbed(HVRGrabberBase grabber, HVRGrabbable grabable)
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x1EAC2D4", Offset = "0x1EAC2D4", VA = "0x1EAC2D4")]
	protected void BecomeElectric()
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x1EAC3D0", Offset = "0x1EAC3D0", VA = "0x1EAC3D0")]
	protected void BecomeFaster()
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x1EAC524", Offset = "0x1EAC524", VA = "0x1EAC524")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAE83C", Offset = "0xAAE83C")]
	private IEnumerator ElectricVibration()
	{
		return null;
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x1EAC590", Offset = "0x1EAC590", VA = "0x1EAC590")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAE89C", Offset = "0xAAE89C")]
	private IEnumerator DoubleHit(Enemy _targetEnemy)
	{
		return null;
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x1EAC608", Offset = "0x1EAC608", VA = "0x1EAC608")]
	private void FlyInAfterEnemyHit()
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x1EAC9EC", Offset = "0x1EAC9EC", VA = "0x1EAC9EC")]
	protected void BoomerangHandRelease(HVRHandGrabber hand, HVRGrabbable grabable)
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x1EAD1D0", Offset = "0x1EAD1D0", VA = "0x1EAD1D0")]
	public void InstantDestroyInPlace()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x1EAD744", Offset = "0x1EAD744", VA = "0x1EAD744")]
	protected void BoomerangRelease(HVRGrabberBase grabber, HVRGrabbable grabable)
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x1EAC51C", Offset = "0x1EAC51C", VA = "0x1EAC51C")]
	protected void UpdateState(BoomerangState new_state)
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x1EAC16C", Offset = "0x1EAC16C", VA = "0x1EAC16C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAE8FC", Offset = "0xAAE8FC")]
	private IEnumerator DestroyBoomerang()
	{
		return null;
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x1EAD748", Offset = "0x1EAD748", VA = "0x1EAD748")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x1EACFA4", Offset = "0x1EACFA4", VA = "0x1EACFA4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAE95C", Offset = "0xAAE95C")]
	private IEnumerator FlyOut()
	{
		return null;
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x1EAC960", Offset = "0x1EAC960", VA = "0x1EAC960")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAE9BC", Offset = "0xAAE9BC")]
	private IEnumerator FlyIn(Vector3[] _curvePoints, float _curveTime = 1f, float _startSlowDown = 0.8f)
	{
		return null;
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x1EAC100", Offset = "0x1EAC100", VA = "0x1EAC100")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAEA1C", Offset = "0xAAEA1C")]
	private IEnumerator SpawnAnimation()
	{
		return null;
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x1EAD6D8", Offset = "0x1EAD6D8", VA = "0x1EAD6D8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAEA7C", Offset = "0xAAEA7C")]
	private IEnumerator DestroyAnimation()
	{
		return null;
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x1EACD80", Offset = "0x1EACD80", VA = "0x1EACD80")]
	public bool isGoodThrow(Vector3 _velocity, Vector3 _angularVelocity)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x1EAE3FC", Offset = "0x1EAE3FC", VA = "0x1EAE3FC")]
	private Vector3 GetBezCurve(float t, Vector3[] _listOfPoints)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x1EAE540", Offset = "0x1EAE540", VA = "0x1EAE540")]
	private float BinCoef(int _n, int _k)
	{
		return default(float);
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x1EAC7CC", Offset = "0x1EAC7CC", VA = "0x1EAC7CC")]
	private Vector3 BoomerangReturnPosition(bool hit_enemy = false)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x1EACF24", Offset = "0x1EACF24", VA = "0x1EACF24")]
	public void EnableTrailRenderer(bool _bool)
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x1EADF0C", Offset = "0x1EADF0C", VA = "0x1EADF0C")]
	private Enemy FindRandomCloseEnemy(float _distance, Enemy _hitEnemy)
	{
		return null;
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x1EAE580", Offset = "0x1EAE580", VA = "0x1EAE580")]
	public void SetCollisionStatus(bool active)
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x1EAD010", Offset = "0x1EAD010", VA = "0x1EAD010")]
	private void RegisterBoomerangThrow()
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x1EADE90", Offset = "0x1EADE90", VA = "0x1EADE90")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAEADC", Offset = "0xAAEADC")]
	private IEnumerator ShortlyIgnoringEnemies(float _time)
	{
		return null;
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x1EADE14", Offset = "0x1EADE14", VA = "0x1EADE14")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAEB3C", Offset = "0xAAEB3C")]
	private IEnumerator ShortlyUncolidable(float _time)
	{
		return null;
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x1EABAF8", Offset = "0x1EABAF8", VA = "0x1EABAF8")]
	private Material GetBoomerangMaterial()
	{
		return null;
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x1EAE5A0", Offset = "0x1EAE5A0", VA = "0x1EAE5A0")]
	public Collider[] GetColliders()
	{
		return null;
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x1EAC3F0", Offset = "0x1EAC3F0", VA = "0x1EAC3F0")]
	private void ToggleCollisionLayer(bool flyingIn)
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x1EAE5FC", Offset = "0x1EAE5FC", VA = "0x1EAE5FC")]
	private void OnChangeLevel()
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x1EACCA8", Offset = "0x1EACCA8", VA = "0x1EACCA8")]
	private CharacterController GetPlayerController()
	{
		return null;
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x1EAE6C8", Offset = "0x1EAE6C8", VA = "0x1EAE6C8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x1EAE830", Offset = "0x1EAE830", VA = "0x1EAE830")]
	public Boomerang()
	{
	}
}
[Token(Token = "0x200004B")]
public class BoomerangGrabHelper : MonoBehaviour
{
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA3A8", Offset = "0xAAA3A8")]
	private sealed class <LetItFallIn>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BoomerangGrabHelper <>4__this;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HVRGrabbable _grabbable;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Boomerang _boomerang;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float timeOfHelp;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <timerTime>5__2;

		[Token(Token = "0x17000079")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x1F4BF18", Offset = "0x1F4BF18", VA = "0x1F4BF18", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x1F4BF60", Offset = "0x1F4BF60", VA = "0x1F4BF60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x1F4BCE4", Offset = "0x1F4BCE4", VA = "0x1F4BCE4")]
		[DebuggerHidden]
		public <LetItFallIn>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1F4BD10", Offset = "0x1F4BD10", VA = "0x1F4BD10", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x1F4BD14", Offset = "0x1F4BD14", VA = "0x1F4BD14", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x1F4BF20", Offset = "0x1F4BF20", VA = "0x1F4BF20", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public HVRPlayerInputs inputs;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public HVRHandGrabber hand;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioHandler audioHandler;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int timesCatchedBefore;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private WaitForFixedUpdate waitForFixedUpdate;

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x1EAE8D4", Offset = "0x1EAE8D4", VA = "0x1EAE8D4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x1EAE998", Offset = "0x1EAE998", VA = "0x1EAE998")]
	private void Start()
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x1EAE9EC", Offset = "0x1EAE9EC", VA = "0x1EAE9EC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x1EAEC54", Offset = "0x1EAEC54", VA = "0x1EAEC54")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAEE6C", Offset = "0xAAEE6C")]
	private IEnumerator LetItFallIn(HVRGrabbable _grabbable, float timeOfHelp, Boomerang _boomerang)
	{
		return null;
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x1EAECE4", Offset = "0x1EAECE4", VA = "0x1EAECE4")]
	private void RegisterBoomerangGrab(Boomerang _boomerang)
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x1EAF048", Offset = "0x1EAF048", VA = "0x1EAF048")]
	private void dingSound(HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x1EAF174", Offset = "0x1EAF174", VA = "0x1EAF174")]
	public BoomerangGrabHelper()
	{
	}
}
[Token(Token = "0x200004D")]
public class BoomerangHolster : Holster
{
	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private AudioHandler audioHandler;

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x1EAF1D8", Offset = "0x1EAF1D8", VA = "0x1EAF1D8", Slot = "25")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x1EAF238", Offset = "0x1EAF238", VA = "0x1EAF238", Slot = "62")]
	protected override void PlaySocketedSFX(HVRSocketable socketable)
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x1EAF28C", Offset = "0x1EAF28C", VA = "0x1EAF28C", Slot = "63")]
	protected override void PlayUnsocketedSFX(HVRGrabbable grabbable)
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x1EAF2E0", Offset = "0x1EAF2E0", VA = "0x1EAF2E0", Slot = "47")]
	public override bool CanHover(HVRGrabbable grabbable)
	{
		return default(bool);
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x1EAF3BC", Offset = "0x1EAF3BC", VA = "0x1EAF3BC", Slot = "67")]
	public override bool TryGrab(HVRGrabbable grabbable, bool force = false, bool ignoreGrabSound = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x1EAF508", Offset = "0x1EAF508", VA = "0x1EAF508")]
	public BoomerangHolster()
	{
	}
}
[Token(Token = "0x200004E")]
public class BoomerangSpawner : MonoBehaviour
{
	[Token(Token = "0x200004F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA3B8", Offset = "0xAAA3B8")]
	private sealed class <CooldownBoomerang>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BoomerangSpawner <>4__this;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float cooldownTime;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <relative_time>5__2;

		[Token(Token = "0x1700007B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x1F4C0C4", Offset = "0x1F4C0C4", VA = "0x1F4C0C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x1F4C10C", Offset = "0x1F4C10C", VA = "0x1F4C10C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1F4BF68", Offset = "0x1F4BF68", VA = "0x1F4BF68")]
		[DebuggerHidden]
		public <CooldownBoomerang>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1F4BF94", Offset = "0x1F4BF94", VA = "0x1F4BF94", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1F4BF98", Offset = "0x1F4BF98", VA = "0x1F4BF98", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1F4C0CC", Offset = "0x1F4C0CC", VA = "0x1F4C0CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject spawnableBoomerang;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float coolDownTime;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject[] boomerangSkins;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Holster holster;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Material ringMaterial;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool pauseCooldownOnHover;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private bool pauseCooldown;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private WaitForFixedUpdate waitForFixedUpdate;

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x1EAF510", Offset = "0x1EAF510", VA = "0x1EAF510")]
	private void Start()
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x1EAF774", Offset = "0x1EAF774", VA = "0x1EAF774")]
	public void SpawnNewBoomerang()
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x1EAF984", Offset = "0x1EAF984", VA = "0x1EAF984")]
	private void removeFromPocket(HVRGrabberBase grabberBase, HVRGrabbable grabbable)
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x1EAFA30", Offset = "0x1EAFA30", VA = "0x1EAFA30")]
	private void OnHoverEnter(HVRGrabberBase grabberBase, HVRGrabbable grabbable)
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x1EAFA44", Offset = "0x1EAFA44", VA = "0x1EAFA44")]
	private void OnHoverExit(HVRGrabberBase grabberBase, HVRGrabbable grabbable)
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x1EAF9B4", Offset = "0x1EAF9B4", VA = "0x1EAF9B4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAEF1C", Offset = "0xAAEF1C")]
	private IEnumerator CooldownBoomerang(float cooldownTime = 5f)
	{
		return null;
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x1EAFA4C", Offset = "0x1EAFA4C", VA = "0x1EAFA4C")]
	private void cancelCooldown(HVRGrabberBase grabberBase, HVRGrabbable grabbable)
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x1EAFAB4", Offset = "0x1EAFAB4", VA = "0x1EAFAB4")]
	private void NewPrefab(HVRGrabberBase grabberBase, HVRGrabbable grabbable)
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x1EAFC10", Offset = "0x1EAFC10", VA = "0x1EAFC10")]
	public BoomerangSpawner()
	{
	}
}
[Token(Token = "0x2000050")]
public class BossHealthBar : MonoBehaviour
{
	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Gradient gradient;

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image bar;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int maxHealth;

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x1EAFC84", Offset = "0x1EAFC84", VA = "0x1EAFC84")]
	private void Start()
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x1EAFCE4", Offset = "0x1EAFCE4", VA = "0x1EAFCE4")]
	public void Damage(int healthValue)
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x1EAFD5C", Offset = "0x1EAFD5C", VA = "0x1EAFD5C")]
	public BossHealthBar()
	{
	}
}
[Token(Token = "0x2000051")]
public class CanGuru : Enemy
{
	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA3C8", Offset = "0xAAA3C8")]
	private sealed class <CanGuruInitialCoroutine>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CanGuru <>4__this;

		[Token(Token = "0x1700007D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x1F4C71C", Offset = "0x1F4C71C", VA = "0x1F4C71C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x1F4C764", Offset = "0x1F4C764", VA = "0x1F4C764", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1F4C634", Offset = "0x1F4C634", VA = "0x1F4C634")]
		[DebuggerHidden]
		public <CanGuruInitialCoroutine>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1F4C660", Offset = "0x1F4C660", VA = "0x1F4C660", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1F4C664", Offset = "0x1F4C664", VA = "0x1F4C664", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1F4C724", Offset = "0x1F4C724", VA = "0x1F4C724", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA3D8", Offset = "0xAAA3D8")]
	private sealed class <MoveToNextPointCoroutine>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CanGuru <>4__this;

		[Token(Token = "0x1700007F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x1F4D1F4", Offset = "0x1F4D1F4", VA = "0x1F4D1F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x1F4D23C", Offset = "0x1F4D23C", VA = "0x1F4D23C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1F4CDAC", Offset = "0x1F4CDAC", VA = "0x1F4CDAC")]
		[DebuggerHidden]
		public <MoveToNextPointCoroutine>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x1F4CDD8", Offset = "0x1F4CDD8", VA = "0x1F4CDD8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1F4CDDC", Offset = "0x1F4CDDC", VA = "0x1F4CDDC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1F4D1FC", Offset = "0x1F4D1FC", VA = "0x1F4D1FC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA3E8", Offset = "0xAAA3E8")]
	private sealed class <RegularFlameBeerCoroutine>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CanGuru <>4__this;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int beerNumber;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <i>5__2;

		[Token(Token = "0x17000081")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x1F4DAEC", Offset = "0x1F4DAEC", VA = "0x1F4DAEC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x1F4DB34", Offset = "0x1F4DB34", VA = "0x1F4DB34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x1F4D598", Offset = "0x1F4D598", VA = "0x1F4D598")]
		[DebuggerHidden]
		public <RegularFlameBeerCoroutine>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x1F4D5C4", Offset = "0x1F4D5C4", VA = "0x1F4D5C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1F4D5C8", Offset = "0x1F4D5C8", VA = "0x1F4D5C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x1F4DAF4", Offset = "0x1F4DAF4", VA = "0x1F4DAF4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000055")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA3F8", Offset = "0xAAA3F8")]
	private sealed class <BigFlameBeerCoroutine>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CanGuru <>4__this;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float size;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <animationTime>5__2;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject <bigFlameBeer>5__3;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Collider[] <beerColliders>5__4;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <_time>5__5;

		[Token(Token = "0x17000083")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x1F4C5E4", Offset = "0x1F4C5E4", VA = "0x1F4C5E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x1F4C62C", Offset = "0x1F4C62C", VA = "0x1F4C62C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1F4C188", Offset = "0x1F4C188", VA = "0x1F4C188")]
		[DebuggerHidden]
		public <BigFlameBeerCoroutine>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1F4C1B4", Offset = "0x1F4C1B4", VA = "0x1F4C1B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x1F4C1B8", Offset = "0x1F4C1B8", VA = "0x1F4C1B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x1F4C5EC", Offset = "0x1F4C5EC", VA = "0x1F4C5EC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA408", Offset = "0xAAA408")]
	private sealed class <>c__DisplayClass33_0
	{
		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject reflectiveBeer;

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x1F4C114", Offset = "0x1F4C114", VA = "0x1F4C114")]
		public <>c__DisplayClass33_0()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x1F4C11C", Offset = "0x1F4C11C", VA = "0x1F4C11C")]
		internal bool <ReflectiveBeerCoroutine>b__0()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA418", Offset = "0xAAA418")]
	private sealed class <ReflectiveBeerCoroutine>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private <>c__DisplayClass33_0 <>8__1;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CanGuru <>4__this;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float velocityMultiplier;

		[Token(Token = "0x17000085")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x1F4D548", Offset = "0x1F4D548", VA = "0x1F4D548", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x1F4D590", Offset = "0x1F4D590", VA = "0x1F4D590", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1F4D244", Offset = "0x1F4D244", VA = "0x1F4D244")]
		[DebuggerHidden]
		public <ReflectiveBeerCoroutine>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1F4D270", Offset = "0x1F4D270", VA = "0x1F4D270", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x1F4D274", Offset = "0x1F4D274", VA = "0x1F4D274", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x1F4D550", Offset = "0x1F4D550", VA = "0x1F4D550", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA428", Offset = "0xAAA428")]
	private sealed class <VulnerableCoroutine>d__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CanGuru <>4__this;

		[Token(Token = "0x17000087")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x1F4DCE8", Offset = "0x1F4DCE8", VA = "0x1F4DCE8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000088")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x1F4DD30", Offset = "0x1F4DD30", VA = "0x1F4DD30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x1F4DB3C", Offset = "0x1F4DB3C", VA = "0x1F4DB3C")]
		[DebuggerHidden]
		public <VulnerableCoroutine>d__35(int <>1__state)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x1F4DB68", Offset = "0x1F4DB68", VA = "0x1F4DB68", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1F4DB6C", Offset = "0x1F4DB6C", VA = "0x1F4DB6C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1F4DCF0", Offset = "0x1F4DCF0", VA = "0x1F4DCF0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA438", Offset = "0xAAA438")]
	private sealed class <GetHit>d__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CanGuru <>4__this;

		[Token(Token = "0x17000089")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x1F4CB44", Offset = "0x1F4CB44", VA = "0x1F4CB44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0x1F4CB8C", Offset = "0x1F4CB8C", VA = "0x1F4CB8C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1F4C76C", Offset = "0x1F4C76C", VA = "0x1F4C76C")]
		[DebuggerHidden]
		public <GetHit>d__36(int <>1__state)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1F4C798", Offset = "0x1F4C798", VA = "0x1F4C798", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1F4C79C", Offset = "0x1F4C79C", VA = "0x1F4C79C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x1F4CB4C", Offset = "0x1F4CB4C", VA = "0x1F4CB4C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA448", Offset = "0xAAA448")]
	private sealed class <KillCanGuru>d__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CanGuru <>4__this;

		[Token(Token = "0x1700008B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x1F4CD5C", Offset = "0x1F4CD5C", VA = "0x1F4CD5C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x1F4CDA4", Offset = "0x1F4CDA4", VA = "0x1F4CDA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x1F4CB94", Offset = "0x1F4CB94", VA = "0x1F4CB94")]
		[DebuggerHidden]
		public <KillCanGuru>d__40(int <>1__state)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x1F4CBC0", Offset = "0x1F4CBC0", VA = "0x1F4CBC0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x1F4CBC4", Offset = "0x1F4CBC4", VA = "0x1F4CBC4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x1F4CD64", Offset = "0x1F4CD64", VA = "0x1F4CD64", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAAB41C", Offset = "0xAAB41C")]
	public float chanceOfChangingDirection;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAAB434", Offset = "0xAAB434")]
	public float chanceOfRandom;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject pointsOfMovementParent;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<Transform> pointsOfMovement;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float movespeed;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject flameBeerPrefab;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject bigFlameBeerPrefab;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject reflectiveBeerPrefab;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Transform pointToSpawnProjectile;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Animator canGuruAnimator;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Animator cansAnimator;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Transform playerTransform;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject cricketBatPrefab;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public EnemyShield shield;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GameObject impactParticles;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public BossHealthBar healthBar;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public GameObject dirtPopParticles;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAAB44C", Offset = "0xAAB44C")]
	public int currentMovementPoint;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public int nextMovementPoint;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public bool reverseDirection;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public int moveNumbers;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public int phaseNumber;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public bool isReflectingPhase;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Level5GPM gamePlayManager;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private float timeBetweenAttackedMultiplier;

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x1EB1328", Offset = "0x1EB1328", VA = "0x1EB1328")]
	private new void Start()
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x1EB1638", Offset = "0x1EB1638", VA = "0x1EB1638")]
	private void Update()
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x1EB15CC", Offset = "0x1EB15CC", VA = "0x1EB15CC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAAEFCC", Offset = "0xAAEFCC")]
	private IEnumerator CanGuruInitialCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x1EB1684", Offset = "0x1EB1684", VA = "0x1EB1684")]
	private void DecideWhatToDo()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x1EB1884", Offset = "0x1EB1884", VA = "0x1EB1884")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB002C", Offset = "0xAB002C")]
	private IEnumerator MoveToNextPointCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x1EB1A74", Offset = "0x1EB1A74", VA = "0x1EB1A74")]
	public void MoveToNextPoint()
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x1EB196C", Offset = "0x1EB196C", VA = "0x1EB196C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB008C", Offset = "0xAB008C")]
	public IEnumerator RegularFlameBeerCoroutine(int beerNumber, float delay = 0f)
	{
		return null;
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x1EB18F0", Offset = "0x1EB18F0", VA = "0x1EB18F0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB00EC", Offset = "0xAB00EC")]
	private IEnumerator BigFlameBeerCoroutine(float size)
	{
		return null;
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x1EB19F8", Offset = "0x1EB19F8", VA = "0x1EB19F8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB014C", Offset = "0xAB014C")]
	private IEnumerator ReflectiveBeerCoroutine(float velocityMultiplier = 1f)
	{
		return null;
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x1EB1AA0", Offset = "0x1EB1AA0", VA = "0x1EB1AA0")]
	public void DeflectReflectiveCan()
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x1EB1B1C", Offset = "0x1EB1B1C", VA = "0x1EB1B1C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB01AC", Offset = "0xAB01AC")]
	private IEnumerator VulnerableCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x1EB1B88", Offset = "0x1EB1B88", VA = "0x1EB1B88")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB020C", Offset = "0xAB020C")]
	private IEnumerator GetHit()
	{
		return null;
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x1EB1BF4", Offset = "0x1EB1BF4", VA = "0x1EB1BF4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x1EB1C24", Offset = "0x1EB1C24", VA = "0x1EB1C24", Slot = "5")]
	public override void GiveDamage(int damageToGive)
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x1EB1D70", Offset = "0x1EB1D70", VA = "0x1EB1D70")]
	private int GetNextMovementPoint()
	{
		return default(int);
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x1EB1D04", Offset = "0x1EB1D04", VA = "0x1EB1D04")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB026C", Offset = "0xAB026C")]
	private IEnumerator KillCanGuru()
	{
		return null;
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x1EB1E3C", Offset = "0x1EB1E3C", VA = "0x1EB1E3C")]
	public CanGuru()
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x1EB1E4C", Offset = "0x1EB1E4C", VA = "0x1EB1E4C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB02CC", Offset = "0xAB02CC")]
	private Vector3 <RegularFlameBeerCoroutine>g__PlayerDirection|31_0()
	{
		return default(Vector3);
	}
}
[Token(Token = "0x200005B")]
public class EmuShield : EnemyShield
{
	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Emu emu;

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x1F1D494", Offset = "0x1F1D494", VA = "0x1F1D494", Slot = "4")]
	protected override void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x1F1D730", Offset = "0x1F1D730", VA = "0x1F1D730")]
	public EmuShield()
	{
	}
}
[Token(Token = "0x200005C")]
public class Enemy : MonoBehaviour
{
	[Token(Token = "0x200005D")]
	public enum TypeOfEnemy
	{
		[Token(Token = "0x400020B")]
		Babyroo,
		[Token(Token = "0x400020C")]
		Kangaroo,
		[Token(Token = "0x400020D")]
		Koala,
		[Token(Token = "0x400020E")]
		Platypus,
		[Token(Token = "0x400020F")]
		Dingo,
		[Token(Token = "0x4000210")]
		Quokka,
		[Token(Token = "0x4000211")]
		Other
	}

	[Token(Token = "0x200005E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA458", Offset = "0xAAA458")]
	private sealed class <TemporarilyImuneCoroutine>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Enemy <>4__this;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float immuneTime;

		[Token(Token = "0x1700008D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x1FE41D4", Offset = "0x1FE41D4", VA = "0x1FE41D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x1FE421C", Offset = "0x1FE421C", VA = "0x1FE421C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1FE40DC", Offset = "0x1FE40DC", VA = "0x1FE40DC")]
		[DebuggerHidden]
		public <TemporarilyImuneCoroutine>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x1FE4108", Offset = "0x1FE4108", VA = "0x1FE4108", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x1FE410C", Offset = "0x1FE410C", VA = "0x1FE410C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x1FE41DC", Offset = "0x1FE41DC", VA = "0x1FE41DC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA468", Offset = "0xAAA468")]
	private sealed class <UnslapableFor>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Enemy <>4__this;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float _secondsToWait;

		[Token(Token = "0x1700008F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x1FE4314", Offset = "0x1FE4314", VA = "0x1FE4314", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000090")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x1FE435C", Offset = "0x1FE435C", VA = "0x1FE435C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x1FE4224", Offset = "0x1FE4224", VA = "0x1FE4224")]
		[DebuggerHidden]
		public <UnslapableFor>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x1FE4250", Offset = "0x1FE4250", VA = "0x1FE4250", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x1FE4254", Offset = "0x1FE4254", VA = "0x1FE4254", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x1FE431C", Offset = "0x1FE431C", VA = "0x1FE431C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA478", Offset = "0xAAA478")]
	private sealed class <ImmuneFor>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Enemy <>4__this;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float _secondsToWait;

		[Token(Token = "0x17000091")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x1FE408C", Offset = "0x1FE408C", VA = "0x1FE408C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000092")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x1FE40D4", Offset = "0x1FE40D4", VA = "0x1FE40D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x1FE3F94", Offset = "0x1FE3F94", VA = "0x1FE3F94")]
		[DebuggerHidden]
		public <ImmuneFor>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x1FE3FC0", Offset = "0x1FE3FC0", VA = "0x1FE3FC0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x1FE3FC4", Offset = "0x1FE3FC4", VA = "0x1FE3FC4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1FE4094", Offset = "0x1FE4094", VA = "0x1FE4094", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int enemyHealth;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool CanGrabBeer;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool imuneToDamage;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject deathEffect;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject beerStealParticles;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected AudioHandler audioHandler;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public NavMeshAgent agent;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool isSlappable;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	protected bool slapCooledDown;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float slapSpeedTreshold;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int pointsOnKill;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public TypeOfEnemy typeOfEnemy;

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x1F1D824", Offset = "0x1F1D824", VA = "0x1F1D824", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x1F1D930", Offset = "0x1F1D930", VA = "0x1F1D930", Slot = "5")]
	public virtual void GiveDamage(int damageToGive)
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x1F1DA1C", Offset = "0x1F1DA1C", VA = "0x1F1DA1C", Slot = "6")]
	public virtual void KillMe()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x1F1DB0C", Offset = "0x1F1DB0C", VA = "0x1F1DB0C", Slot = "7")]
	public virtual void DestroyMe()
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x1F1DB94", Offset = "0x1F1DB94", VA = "0x1F1DB94", Slot = "8")]
	public virtual void BeerSteal()
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x1F1D9A0", Offset = "0x1F1D9A0", VA = "0x1F1D9A0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB055C", Offset = "0xAB055C")]
	private IEnumerator TemporarilyImuneCoroutine(float immuneTime)
	{
		return null;
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x1F1DCBC", Offset = "0x1F1DCBC", VA = "0x1F1DCBC", Slot = "9")]
	protected virtual void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x1F1DDCC", Offset = "0x1F1DDCC", VA = "0x1F1DDCC", Slot = "10")]
	protected virtual void SlapEnemy(Collision collision)
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x1F1DE6C", Offset = "0x1F1DE6C", VA = "0x1F1DE6C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB05BC", Offset = "0xAB05BC")]
	private IEnumerator UnslapableFor(float _secondsToWait)
	{
		return null;
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x1F1DEE8", Offset = "0x1F1DEE8", VA = "0x1F1DEE8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB061C", Offset = "0xAB061C")]
	private IEnumerator ImmuneFor(float _secondsToWait)
	{
		return null;
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x1F1D424", Offset = "0x1F1D424", VA = "0x1F1D424")]
	public Enemy()
	{
	}
}
[Token(Token = "0x2000061")]
public class EnemyShield : MonoBehaviour
{
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA488", Offset = "0xAAA488")]
	private sealed class <ActivateShield>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EnemyShield <>4__this;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <_initialAlpha>5__2;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <_time>5__3;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <flashDecayTime>5__4;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <_alpha>5__5;

		[Token(Token = "0x17000093")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x1FE45E4", Offset = "0x1FE45E4", VA = "0x1FE45E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x1FE462C", Offset = "0x1FE462C", VA = "0x1FE462C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x1FE4364", Offset = "0x1FE4364", VA = "0x1FE4364")]
		[DebuggerHidden]
		public <ActivateShield>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x1FE4390", Offset = "0x1FE4390", VA = "0x1FE4390", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x1FE4394", Offset = "0x1FE4394", VA = "0x1FE4394", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1FE45EC", Offset = "0x1FE45EC", VA = "0x1FE45EC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioHandler audioHandler;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Material shieldMaterial;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected float cooldown;

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x1F1DF64", Offset = "0x1F1DF64", VA = "0x1F1DF64")]
	private void Start()
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x1F1DFEC", Offset = "0x1F1DFEC", VA = "0x1F1DFEC")]
	private void Update()
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x1F1D568", Offset = "0x1F1D568", VA = "0x1F1D568", Slot = "4")]
	protected virtual void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x1F1E02C", Offset = "0x1F1E02C", VA = "0x1F1E02C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB076C", Offset = "0xAB076C")]
	protected IEnumerator ActivateShield()
	{
		return null;
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x1F1D738", Offset = "0x1F1D738", VA = "0x1F1D738")]
	public EnemyShield()
	{
	}
}
[Token(Token = "0x2000063")]
public class HatManager : MonoBehaviour
{
	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool showXmasHat;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject xmasHat;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static DateTime endXmasDate;

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x1F2707C", Offset = "0x1F2707C", VA = "0x1F2707C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x1F27164", Offset = "0x1F27164", VA = "0x1F27164")]
	public HatManager()
	{
	}
}
[Token(Token = "0x2000064")]
public class HittingBat : MonoBehaviour
{
	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA498", Offset = "0xAAA498")]
	private sealed class <CooldownHitCoroutine>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HittingBat <>4__this;

		[Token(Token = "0x17000095")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x1FEF418", Offset = "0x1FEF418", VA = "0x1FEF418", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x1FEF460", Offset = "0x1FEF460", VA = "0x1FEF460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1FEF328", Offset = "0x1FEF328", VA = "0x1FEF328")]
		[DebuggerHidden]
		public <CooldownHitCoroutine>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1FEF354", Offset = "0x1FEF354", VA = "0x1FEF354", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1FEF358", Offset = "0x1FEF358", VA = "0x1FEF358", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1FEF420", Offset = "0x1FEF420", VA = "0x1FEF420", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA4A8", Offset = "0xAAA4A8")]
	private sealed class <DelayedBabyrooReaction>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public babyrooBehaviour babyroo;

		[Token(Token = "0x17000097")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x1FEF544", Offset = "0x1FEF544", VA = "0x1FEF544", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000098")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x1FEF58C", Offset = "0x1FEF58C", VA = "0x1FEF58C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x1FEF468", Offset = "0x1FEF468", VA = "0x1FEF468")]
		[DebuggerHidden]
		public <DelayedBabyrooReaction>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1FEF494", Offset = "0x1FEF494", VA = "0x1FEF494", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x1FEF498", Offset = "0x1FEF498", VA = "0x1FEF498", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x1FEF54C", Offset = "0x1FEF54C", VA = "0x1FEF54C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Rigidbody hitPointRB;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject FlyingAwayParticlesPrefab;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioHandler audioHandler;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float velocityToHit;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float velocityMultiplier;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float upBonus;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool onCooldown;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject onSmashParticles;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private HVRGrabbable grabbable;

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x1F27B30", Offset = "0x1F27B30", VA = "0x1F27B30")]
	private void Start()
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x1F27BA8", Offset = "0x1F27BA8", VA = "0x1F27BA8")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x1F283F4", Offset = "0x1F283F4", VA = "0x1F283F4")]
	private void Cooldown()
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x1F28420", Offset = "0x1F28420", VA = "0x1F28420")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB081C", Offset = "0xAB081C")]
	private IEnumerator CooldownHitCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x1F28388", Offset = "0x1F28388", VA = "0x1F28388")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB087C", Offset = "0xAB087C")]
	private IEnumerator DelayedBabyrooReaction(babyrooBehaviour babyroo)
	{
		return null;
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x1F281C8", Offset = "0x1F281C8", VA = "0x1F281C8")]
	private void SendFlying(Rigidbody rb, Collision collision, bool playSound = true)
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x1F2848C", Offset = "0x1F2848C", VA = "0x1F2848C")]
	public HittingBat()
	{
	}
}
[Token(Token = "0x2000067")]
public class HomingProjectile : MonoBehaviour
{
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA4B8", Offset = "0xAAA4B8")]
	private sealed class <SelfDestructCoroutine>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int _projectileLifeTime;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HomingProjectile <>4__this;

		[Token(Token = "0x17000099")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x1FEFA54", Offset = "0x1FEFA54", VA = "0x1FEFA54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x1FEFA9C", Offset = "0x1FEFA9C", VA = "0x1FEFA9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1FEF954", Offset = "0x1FEF954", VA = "0x1FEF954")]
		[DebuggerHidden]
		public <SelfDestructCoroutine>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1FEF980", Offset = "0x1FEF980", VA = "0x1FEF980", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x1FEF984", Offset = "0x1FEF984", VA = "0x1FEF984", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1FEFA5C", Offset = "0x1FEFA5C", VA = "0x1FEFA5C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA4C8", Offset = "0xAAA4C8")]
	private sealed class <DelayedColliderActivation>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float _delayTime;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HomingProjectile <>4__this;

		[Token(Token = "0x1700009B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x1FEF6A0", Offset = "0x1FEF6A0", VA = "0x1FEF6A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x1FEF6E8", Offset = "0x1FEF6E8", VA = "0x1FEF6E8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1FEF594", Offset = "0x1FEF594", VA = "0x1FEF594")]
		[DebuggerHidden]
		public <DelayedColliderActivation>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1FEF5C0", Offset = "0x1FEF5C0", VA = "0x1FEF5C0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x1FEF5C4", Offset = "0x1FEF5C4", VA = "0x1FEF5C4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1FEF6A8", Offset = "0x1FEF6A8", VA = "0x1FEF6A8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200006A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA4D8", Offset = "0xAAA4D8")]
	private sealed class <UnHomeProjectileCoroutine>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HomingProjectile <>4__this;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AudioSource <hoverSound>5__2;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <i>5__3;

		[Token(Token = "0x1700009D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x1FEFC2C", Offset = "0x1FEFC2C", VA = "0x1FEFC2C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x1FEFC74", Offset = "0x1FEFC74", VA = "0x1FEFC74", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1FEFAA4", Offset = "0x1FEFAA4", VA = "0x1FEFAA4")]
		[DebuggerHidden]
		public <UnHomeProjectileCoroutine>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1FEFAD0", Offset = "0x1FEFAD0", VA = "0x1FEFAD0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1FEFAD4", Offset = "0x1FEFAD4", VA = "0x1FEFAD4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1FEFC34", Offset = "0x1FEFC34", VA = "0x1FEFC34", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200006B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA4E8", Offset = "0xAAA4E8")]
	private sealed class <MingleProjectile>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HomingProjectile <>4__this;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <time>5__2;

		[Token(Token = "0x1700009F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x1FEF904", Offset = "0x1FEF904", VA = "0x1FEF904", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A0")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x1FEF94C", Offset = "0x1FEF94C", VA = "0x1FEF94C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x1FEF6F0", Offset = "0x1FEF6F0", VA = "0x1FEF6F0")]
		[DebuggerHidden]
		public <MingleProjectile>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1FEF71C", Offset = "0x1FEF71C", VA = "0x1FEF71C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1FEF720", Offset = "0x1FEF720", VA = "0x1FEF720", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x1FEF90C", Offset = "0x1FEF90C", VA = "0x1FEF90C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform targetTransform;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float velocity;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float projectileVelocityMultiplier;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool velocityInfluencedByDifficulty;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAAB484", Offset = "0xAAB484")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAAB484", Offset = "0xAAB484")]
	public float sharpTurn;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int damageToGive;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool hurtsEnemies;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int projectileLifeTime;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float projectileActivationDelay;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject HitParticles;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject SelfDesctructParticles;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected Rigidbody rb;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected Vector3 pushVector;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector3 previouspushVector;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected Vector3 vectorToTarget;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	protected bool randomized;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected Vector3 targetPosition;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected AudioHandler audioHandler;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public bool activeProjectile;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
	public bool homingProjectile;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected Coroutine selfDestruction;

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x1F28494", Offset = "0x1F28494", VA = "0x1F28494", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x1F28834", Offset = "0x1F28834", VA = "0x1F28834", Slot = "5")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x1F28A74", Offset = "0x1F28A74", VA = "0x1F28A74", Slot = "6")]
	protected virtual void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x1F28BB4", Offset = "0x1F28BB4", VA = "0x1F28BB4")]
	protected void HurtPlayer(int _damageToGive)
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x1F28DA8", Offset = "0x1F28DA8", VA = "0x1F28DA8")]
	protected void HurtEnemy(int _damageToGive, Enemy _enemy)
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x1F28C74", Offset = "0x1F28C74", VA = "0x1F28C74")]
	protected void DestroyOnHit()
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x1F2873C", Offset = "0x1F2873C", VA = "0x1F2873C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB097C", Offset = "0xAB097C")]
	protected IEnumerator SelfDestructCoroutine(int _projectileLifeTime)
	{
		return null;
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x1F287B8", Offset = "0x1F287B8", VA = "0x1F287B8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB09DC", Offset = "0xAB09DC")]
	private IEnumerator DelayedColliderActivation(float _delayTime)
	{
		return null;
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x1F28A08", Offset = "0x1F28A08", VA = "0x1F28A08")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB0A3C", Offset = "0xAB0A3C")]
	private IEnumerator UnHomeProjectileCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x1F28F04", Offset = "0x1F28F04", VA = "0x1F28F04")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB0A9C", Offset = "0xAB0A9C")]
	public IEnumerator MingleProjectile()
	{
		return null;
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x1F28F70", Offset = "0x1F28F70", VA = "0x1F28F70")]
	private void MingleProjectileFunction()
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x1F28F9C", Offset = "0x1F28F9C", VA = "0x1F28F9C", Slot = "7")]
	protected virtual void DestroyProjectile(GameObject _particles, string _sound = "DestroySound")
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x1F291F0", Offset = "0x1F291F0", VA = "0x1F291F0", Slot = "8")]
	protected virtual void DestroyProjectile()
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x1F293C8", Offset = "0x1F293C8", VA = "0x1F293C8")]
	public HomingProjectile()
	{
	}
}
[Token(Token = "0x200006C")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xAAA4F8", Offset = "0xAAA4F8")]
public class HurtPlayerOnContact : MonoBehaviour
{
	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA558", Offset = "0xAAA558")]
	private sealed class <HurtPlayerCooldown>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HurtPlayerOnContact <>4__this;

		[Token(Token = "0x170000A1")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x1FEFD6C", Offset = "0x1FEFD6C", VA = "0x1FEFD6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A2")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x1FEFDB4", Offset = "0x1FEFDB4", VA = "0x1FEFDB4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x1FEFC7C", Offset = "0x1FEFC7C", VA = "0x1FEFC7C")]
		[DebuggerHidden]
		public <HurtPlayerCooldown>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x1FEFCA8", Offset = "0x1FEFCA8", VA = "0x1FEFCA8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x1FEFCAC", Offset = "0x1FEFCAC", VA = "0x1FEFCAC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x1FEFD74", Offset = "0x1FEFD74", VA = "0x1FEFD74", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int damageToGive;

	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParticleSystem hitParticles;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioHandler audioHandler;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float hurtCooldown;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool hurting;

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x1F293EC", Offset = "0x1F293EC", VA = "0x1F293EC")]
	private void Start()
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x1F29448", Offset = "0x1F29448", VA = "0x1F29448")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x1F294CC", Offset = "0x1F294CC", VA = "0x1F294CC")]
	private void HurtPlayer(int _damageToGive)
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x1F29628", Offset = "0x1F29628", VA = "0x1F29628")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB0C3C", Offset = "0xAB0C3C")]
	private IEnumerator HurtPlayerCooldown()
	{
		return null;
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x1F29694", Offset = "0x1F29694", VA = "0x1F29694")]
	public HurtPlayerOnContact()
	{
	}
}
[Token(Token = "0x200006E")]
public class DummyMole : MonoBehaviour
{
	[Token(Token = "0x200006F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA568", Offset = "0xAAA568")]
	private sealed class <ActivateExplosionParticles>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DummyMole <>4__this;

		[Token(Token = "0x170000A3")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x1F4F654", Offset = "0x1F4F654", VA = "0x1F4F654", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A4")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x1F4F69C", Offset = "0x1F4F69C", VA = "0x1F4F69C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x1F4F4B0", Offset = "0x1F4F4B0", VA = "0x1F4F4B0")]
		[DebuggerHidden]
		public <ActivateExplosionParticles>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x1F4F4DC", Offset = "0x1F4F4DC", VA = "0x1F4F4DC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x1F4F4E0", Offset = "0x1F4F4E0", VA = "0x1F4F4E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x1F4F65C", Offset = "0x1F4F65C", VA = "0x1F4F65C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA578", Offset = "0xAAA578")]
	private sealed class <PeakCoroutine>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DummyMole <>4__this;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float delay;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float timeUp;

		[Token(Token = "0x170000A5")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600030B")]
			[Address(RVA = "0x1F5009C", Offset = "0x1F5009C", VA = "0x1F5009C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A6")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x1F500E4", Offset = "0x1F500E4", VA = "0x1F500E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x1F4FBA0", Offset = "0x1F4FBA0", VA = "0x1F4FBA0")]
		[DebuggerHidden]
		public <PeakCoroutine>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x1F4FBCC", Offset = "0x1F4FBCC", VA = "0x1F4FBCC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x1F4FBD0", Offset = "0x1F4FBD0", VA = "0x1F4FBD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x1F500A4", Offset = "0x1F500A4", VA = "0x1F500A4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA588", Offset = "0xAAA588")]
	private sealed class <HideCoroutine>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DummyMole <>4__this;

		[Token(Token = "0x170000A7")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000311")]
			[Address(RVA = "0x1F4FB50", Offset = "0x1F4FB50", VA = "0x1F4FB50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A8")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000313")]
			[Address(RVA = "0x1F4FB98", Offset = "0x1F4FB98", VA = "0x1F4FB98", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1F4F6A4", Offset = "0x1F4F6A4", VA = "0x1F4F6A4")]
		[DebuggerHidden]
		public <HideCoroutine>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x1F4F6D0", Offset = "0x1F4F6D0", VA = "0x1F4F6D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1F4F6D4", Offset = "0x1F4F6D4", VA = "0x1F4F6D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1F4FB58", Offset = "0x1F4FB58", VA = "0x1F4FB58", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public Events.EventDummyExploded OnDummyMoleExploded;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float depthMoleOutside;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 restPosition;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool exploded;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private AudioHandler audioHandler;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject explosionParticles;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject sparksParticles;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float moveDuration;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool isPeaking;

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x1F1B218", Offset = "0x1F1B218", VA = "0x1F1B218")]
	private void Start()
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x1F1B290", Offset = "0x1F1B290", VA = "0x1F1B290", Slot = "4")]
	protected virtual void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x1F1B3C0", Offset = "0x1F1B3C0", VA = "0x1F1B3C0")]
	public void Explode()
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x1F1B514", Offset = "0x1F1B514", VA = "0x1F1B514")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB0CEC", Offset = "0xAB0CEC")]
	private IEnumerator ActivateExplosionParticles()
	{
		return null;
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x1F1B6CC", Offset = "0x1F1B6CC", VA = "0x1F1B6CC")]
	public void Peak(float timeUp, float delay = 0f)
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x1F1B704", Offset = "0x1F1B704", VA = "0x1F1B704")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB0D4C", Offset = "0xAB0D4C")]
	private IEnumerator PeakCoroutine(float timeUp, float delay)
	{
		return null;
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x1F1B784", Offset = "0x1F1B784", VA = "0x1F1B784")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x1F1B7C0", Offset = "0x1F1B7C0", VA = "0x1F1B7C0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB0DAC", Offset = "0xAB0DAC")]
	private IEnumerator HideCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x1F1B82C", Offset = "0x1F1B82C", VA = "0x1F1B82C")]
	public DummyMole()
	{
	}
}
[Token(Token = "0x2000072")]
public class Dynamite : MonoBehaviour
{
	[Token(Token = "0x2000073")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA598", Offset = "0xAAA598")]
	private sealed class <CountDown>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Dynamite <>4__this;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <interval>5__2;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <fuseSectionInterval>5__3;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <fuseSectionCounter>5__4;

		[Token(Token = "0x170000A9")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x1FE1FD8", Offset = "0x1FE1FD8", VA = "0x1FE1FD8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AA")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x1FE2020", Offset = "0x1FE2020", VA = "0x1FE2020", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1FE1D6C", Offset = "0x1FE1D6C", VA = "0x1FE1D6C")]
		[DebuggerHidden]
		public <CountDown>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x1FE1D98", Offset = "0x1FE1D98", VA = "0x1FE1D98", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x1FE1D9C", Offset = "0x1FE1D9C", VA = "0x1FE1D9C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1FE1FE0", Offset = "0x1FE1FE0", VA = "0x1FE1FE0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float timeToExplode;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float timeLeft;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float explosionRadius;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MoleHole isInHole;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected Transform playerTransform;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected AudioHandler audioHandler;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected AudioSource tickingSound;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject explosionParticles;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject activeFuseSection;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject fuseParticles;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int fuseSections;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector3 fuseParticlesLocalPosition;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<Mesh> fuseVariationList;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Queue<Mesh> fuseVariationsQueue;

	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private SkinnedMeshRenderer skinnedMeshRenderer;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Events.EventDynamiteExploded OnExplode;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Animator animator;

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x1F1B844", Offset = "0x1F1B844", VA = "0x1F1B844")]
	private void Start()
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x1F1BA74", Offset = "0x1F1BA74", VA = "0x1F1BA74")]
	public void Explode()
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x1F1BA08", Offset = "0x1F1BA08", VA = "0x1F1BA08")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB0EFC", Offset = "0xAB0EFC")]
	private IEnumerator CountDown()
	{
		return null;
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x1F1BD08", Offset = "0x1F1BD08", VA = "0x1F1BD08")]
	private void useFuse()
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x1F1BED8", Offset = "0x1F1BED8", VA = "0x1F1BED8")]
	public Dynamite()
	{
	}
}
[Token(Token = "0x2000074")]
public class Mole : Enemy
{
	[Token(Token = "0x2000075")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA5A8", Offset = "0xAAA5A8")]
	private sealed class <ThrowProjectile>d__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Mole <>4__this;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject projectilePrefab;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int numberOfProjectiles;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <waitBeforeFirstThrow>5__2;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <waitBeforeOneThrow>5__3;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <waitAfterOneThrow>5__4;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <waitAfterAllThrows>5__5;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float <targetVariance>5__6;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int <i>5__7;

		[Token(Token = "0x170000AB")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600033C")]
			[Address(RVA = "0x1FF61CC", Offset = "0x1FF61CC", VA = "0x1FF61CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AC")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600033E")]
			[Address(RVA = "0x1FF6214", Offset = "0x1FF6214", VA = "0x1FF6214", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1FF5BE8", Offset = "0x1FF5BE8", VA = "0x1FF5BE8")]
		[DebuggerHidden]
		public <ThrowProjectile>d__36(int <>1__state)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1FF5C14", Offset = "0x1FF5C14", VA = "0x1FF5C14", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1FF5C18", Offset = "0x1FF5C18", VA = "0x1FF5C18", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1FF61D4", Offset = "0x1FF61D4", VA = "0x1FF61D4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA5B8", Offset = "0xAAA5B8")]
	private sealed class <ShortlyUncolidable>d__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject projectile;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float _time;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Collider <_collider>5__2;

		[Token(Token = "0x170000AD")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0x1FF5B98", Offset = "0x1FF5B98", VA = "0x1FF5B98", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AE")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000344")]
			[Address(RVA = "0x1FF5BE0", Offset = "0x1FF5BE0", VA = "0x1FF5BE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1FF5A7C", Offset = "0x1FF5A7C", VA = "0x1FF5A7C")]
		[DebuggerHidden]
		public <ShortlyUncolidable>d__37(int <>1__state)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1FF5AA8", Offset = "0x1FF5AA8", VA = "0x1FF5AA8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1FF5AAC", Offset = "0x1FF5AAC", VA = "0x1FF5AAC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1FF5BA0", Offset = "0x1FF5BA0", VA = "0x1FF5BA0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA5C8", Offset = "0xAAA5C8")]
	private sealed class <PeakCoroutine>d__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Mole <>4__this;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int hole;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float waitTime;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject projectile;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 <insidePosition>5__2;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 <outPosition>5__3;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string <onCompleteAction>5__4;

		[Token(Token = "0x170000AF")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x1FF5710", Offset = "0x1FF5710", VA = "0x1FF5710", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B0")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600034A")]
			[Address(RVA = "0x1FF5758", Offset = "0x1FF5758", VA = "0x1FF5758", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1FF4D94", Offset = "0x1FF4D94", VA = "0x1FF4D94")]
		[DebuggerHidden]
		public <PeakCoroutine>d__38(int <>1__state)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1FF4DC0", Offset = "0x1FF4DC0", VA = "0x1FF4DC0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x1FF4DC4", Offset = "0x1FF4DC4", VA = "0x1FF4DC4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1FF5718", Offset = "0x1FF5718", VA = "0x1FF5718", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000078")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA5D8", Offset = "0xAAA5D8")]
	private sealed class <Hide>d__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Mole <>4__this;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 outPosition;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 insidePosition;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string onComplete;

		[Token(Token = "0x170000B1")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600034E")]
			[Address(RVA = "0x1FF4D44", Offset = "0x1FF4D44", VA = "0x1FF4D44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B2")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x1FF4D8C", Offset = "0x1FF4D8C", VA = "0x1FF4D8C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x1FF4904", Offset = "0x1FF4904", VA = "0x1FF4904")]
		[DebuggerHidden]
		public <Hide>d__40(int <>1__state)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x1FF4930", Offset = "0x1FF4930", VA = "0x1FF4930", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x1FF4934", Offset = "0x1FF4934", VA = "0x1FF4934", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x1FF4D4C", Offset = "0x1FF4D4C", VA = "0x1FF4D4C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000079")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA5E8", Offset = "0xAAA5E8")]
	private sealed class <GetHit>d__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Mole <>4__this;

		[Token(Token = "0x170000B3")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000354")]
			[Address(RVA = "0x1FF48B4", Offset = "0x1FF48B4", VA = "0x1FF48B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B4")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000356")]
			[Address(RVA = "0x1FF48FC", Offset = "0x1FF48FC", VA = "0x1FF48FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x1FF4338", Offset = "0x1FF4338", VA = "0x1FF4338")]
		[DebuggerHidden]
		public <GetHit>d__41(int <>1__state)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x1FF4364", Offset = "0x1FF4364", VA = "0x1FF4364", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x1FF4368", Offset = "0x1FF4368", VA = "0x1FF4368", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x1FF48BC", Offset = "0x1FF48BC", VA = "0x1FF48BC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200007A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA5F8", Offset = "0xAAA5F8")]
	private sealed class <ReThrowDynamite>d__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Dynamite dynamite;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Mole <>4__this;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MoleHole hole;

		[Token(Token = "0x170000B5")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x1FF5A2C", Offset = "0x1FF5A2C", VA = "0x1FF5A2C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B6")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x1FF5A74", Offset = "0x1FF5A74", VA = "0x1FF5A74", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x1FF5760", Offset = "0x1FF5760", VA = "0x1FF5760")]
		[DebuggerHidden]
		public <ReThrowDynamite>d__48(int <>1__state)
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x1FF578C", Offset = "0x1FF578C", VA = "0x1FF578C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x1FF5790", Offset = "0x1FF5790", VA = "0x1FF5790", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x1FF5A34", Offset = "0x1FF5A34", VA = "0x1FF5A34", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200007B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA608", Offset = "0xAAA608")]
	private sealed class <WaitThenDecideWhatToDo>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float waitTime;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Mole <>4__this;

		[Token(Token = "0x170000B7")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x1FF636C", Offset = "0x1FF636C", VA = "0x1FF636C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B8")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x1FF63B4", Offset = "0x1FF63B4", VA = "0x1FF63B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1FF621C", Offset = "0x1FF621C", VA = "0x1FF621C")]
		[DebuggerHidden]
		public <WaitThenDecideWhatToDo>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x1FF6248", Offset = "0x1FF6248", VA = "0x1FF6248", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1FF624C", Offset = "0x1FF624C", VA = "0x1FF624C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1FF6374", Offset = "0x1FF6374", VA = "0x1FF6374", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject moleHolesParent;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<Transform> moleHoles;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int currentHole;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int peakCounter;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float depthMoleInside;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float depthMoleOutside;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float moveDuration;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Transform pointToSpawnProjectile;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Transform playerTransform;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Animator animator;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public MeshRenderer hat;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject damageParticles;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public BossHealthBar healthBar;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float minTimeOutside;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public float maxTimeOutside;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public float timeBetweenShowingUp;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public float timeAfterGettingHit;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GameObject dummyMolesParent;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public DummyMole[] dummyMoles;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public GameObject poopProjectile;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public GameObject dynamiteProjectile;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public GameObject bigDynamiteProjectile;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public float projectileVerticalForceMultiplier;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public float projectileHorizontalForceMultiplier;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public GameObject beerPrefab;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public EnemyShield shield;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAAB4E8", Offset = "0xAAB4E8")]
	public int phaseNumber;

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private float timeInPhase;

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x1F06FE4", Offset = "0x1F06FE4", VA = "0x1F06FE4")]
	private new void Start()
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x1F07408", Offset = "0x1F07408", VA = "0x1F07408")]
	private void Update()
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0x1F07308", Offset = "0x1F07308", VA = "0x1F07308")]
	private void DecideWhatToDo()
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x1F07928", Offset = "0x1F07928", VA = "0x1F07928")]
	private float GetRandomWaitTime()
	{
		return default(float);
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x1F07440", Offset = "0x1F07440", VA = "0x1F07440")]
	private void GoToRandomHoleOrShowDummy()
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x1F0752C", Offset = "0x1F0752C", VA = "0x1F0752C")]
	private void ShowDummyAndGoToRandomHole()
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x1F07864", Offset = "0x1F07864", VA = "0x1F07864")]
	private void GoToRandomtHoleAndThrowProjectile()
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x1F07A5C", Offset = "0x1F07A5C", VA = "0x1F07A5C")]
	private void ShowRandomDummy(int hole, float waitTime, float delay = 0f)
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x1F07C54", Offset = "0x1F07C54", VA = "0x1F07C54")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB0FAC", Offset = "0xAB0FAC")]
	private IEnumerator ThrowProjectile(GameObject projectilePrefab, int numberOfProjectiles = 1)
	{
		return null;
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x1F07CD4", Offset = "0x1F07CD4", VA = "0x1F07CD4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB100C", Offset = "0xAB100C")]
	private IEnumerator ShortlyUncolidable(GameObject projectile, float _time)
	{
		return null;
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x1F079C8", Offset = "0x1F079C8", VA = "0x1F079C8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB106C", Offset = "0xAB106C")]
	private IEnumerator PeakCoroutine(int hole, float waitTime, [Optional] GameObject projectile)
	{
		return null;
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x1F07D50", Offset = "0x1F07D50", VA = "0x1F07D50")]
	private int GetProjectileFrequency(int lowerEnd, int higherEnd)
	{
		return default(int);
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x1F07E0C", Offset = "0x1F07E0C", VA = "0x1F07E0C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB10CC", Offset = "0xAB10CC")]
	private IEnumerator Hide(Vector3 outPosition, Vector3 insidePosition, string onComplete = "DecideWhatToDo")
	{
		return null;
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x1F07EC4", Offset = "0x1F07EC4", VA = "0x1F07EC4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB112C", Offset = "0xAB112C")]
	private IEnumerator GetHit()
	{
		return null;
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x1F07F30", Offset = "0x1F07F30", VA = "0x1F07F30")]
	public void DropABeer([Optional] Transform origin)
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x1F08094", Offset = "0x1F08094", VA = "0x1F08094", Slot = "5")]
	public override void GiveDamage(int damageToGive)
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x1F08270", Offset = "0x1F08270", VA = "0x1F08270")]
	private void OnDummyExplode()
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x1F08338", Offset = "0x1F08338", VA = "0x1F08338")]
	private void GettingHitThenDecideWhatToDo()
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x1F08368", Offset = "0x1F08368", VA = "0x1F08368")]
	private void OnDynamiteExplode(Dynamite dynamite)
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x1F0854C", Offset = "0x1F0854C", VA = "0x1F0854C")]
	private void OnDynamiteEntersHole(MoleHole hole, Dynamite dynamite)
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x1F08710", Offset = "0x1F08710", VA = "0x1F08710")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB118C", Offset = "0xAB118C")]
	private IEnumerator ReThrowDynamite(MoleHole hole, Dynamite dynamite)
	{
		return null;
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0x1F08790", Offset = "0x1F08790", VA = "0x1F08790")]
	private void MoveOnToNextPhase()
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0x1F07AC8", Offset = "0x1F07AC8", VA = "0x1F07AC8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB11EC", Offset = "0xAB11EC")]
	private IEnumerator WaitThenDecideWhatToDo(float waitTime)
	{
		return null;
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x1F07960", Offset = "0x1F07960", VA = "0x1F07960")]
	private int GetNextHole()
	{
		return default(int);
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x1F07B44", Offset = "0x1F07B44", VA = "0x1F07B44")]
	private int[] GetNextHoles(int n = 1)
	{
		return null;
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x1F0885C", Offset = "0x1F0885C", VA = "0x1F0885C")]
	public Mole()
	{
	}
}
[Token(Token = "0x200007C")]
public class MoleHole : MonoBehaviour
{
	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Events.EventDynamiteEntersHole OnDynamiteEnterHole;

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject SmokeParticles;

	[Token(Token = "0x6000363")]
	[Address(RVA = "0x1F08884", Offset = "0x1F08884", VA = "0x1F08884")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x1F08920", Offset = "0x1F08920", VA = "0x1F08920")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x1F0852C", Offset = "0x1F0852C", VA = "0x1F0852C")]
	public void Explode()
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x1F08998", Offset = "0x1F08998", VA = "0x1F08998")]
	public MoleHole()
	{
	}
}
[Token(Token = "0x200007D")]
public class PoopProjectile : MonoBehaviour
{
	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected AudioHandler audioHandler;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected Collider _collider;

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected Renderer _renderer;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ParticleSystem optionalHitParticles;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int damageToGive;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool hasHurtPlayer;

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x1F0F5EC", Offset = "0x1F0F5EC", VA = "0x1F0F5EC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x1F0F688", Offset = "0x1F0F688", VA = "0x1F0F688")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x1F0F914", Offset = "0x1F0F914", VA = "0x1F0F914")]
	public PoopProjectile()
	{
	}
}
[Token(Token = "0x200007E")]
public class ReflectiveBat : MonoBehaviour
{
	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Rigidbody hitPointRB;

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x1F115FC", Offset = "0x1F115FC", VA = "0x1F115FC")]
	public ReflectiveBat()
	{
	}
}
[Token(Token = "0x200007F")]
public class ReflectiveBeer : HomingProjectile
{
	[Token(Token = "0x2000080")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA618", Offset = "0xAAA618")]
	private sealed class <TemporarilyDontHurtPlayer>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ReflectiveBeer <>4__this;

		[Token(Token = "0x170000B9")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x22CC6CC", Offset = "0x22CC6CC", VA = "0x22CC6CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BA")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x22CC714", Offset = "0x22CC714", VA = "0x22CC714", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x22CC5E8", Offset = "0x22CC5E8", VA = "0x22CC5E8")]
		[DebuggerHidden]
		public <TemporarilyDontHurtPlayer>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x22CC614", Offset = "0x22CC614", VA = "0x22CC614", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x22CC618", Offset = "0x22CC618", VA = "0x22CC618", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x22CC6D4", Offset = "0x22CC6D4", VA = "0x22CC6D4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private int reflectedTimes;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private int phaseNumber;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public GameObject cricketBatIndicator;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GameObject batHitParticles;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject hardHitParticles;

	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public GameObject reflectiveParticles;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private bool hurtPlayer;

	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private float[] pitchMultiplier;

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x1F11604", Offset = "0x1F11604", VA = "0x1F11604", Slot = "6")]
	protected override void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x1F11C34", Offset = "0x1F11C34", VA = "0x1F11C34")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB147C", Offset = "0xAB147C")]
	private IEnumerator TemporarilyDontHurtPlayer()
	{
		return null;
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x1F11CA0", Offset = "0x1F11CA0", VA = "0x1F11CA0")]
	public ReflectiveBeer()
	{
	}
}
[Token(Token = "0x2000081")]
public class BurgerFiniteSpawnerSocket : FiniteSpawnerSocket
{
	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	public GameObject meatOption;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public GameObject veggieOption;

	[Token(Token = "0x6000374")]
	[Address(RVA = "0x1EB0D90", Offset = "0x1EB0D90", VA = "0x1EB0D90", Slot = "25")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x1EB0E40", Offset = "0x1EB0E40", VA = "0x1EB0E40")]
	public BurgerFiniteSpawnerSocket()
	{
	}
}
[Token(Token = "0x2000082")]
public class Plate : MonoBehaviour
{
	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private HVRGrabbable grabbable;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AussieSocket socket;

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private LayerMask layerMask;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float raycastDistance;

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x1F0D228", Offset = "0x1F0D228", VA = "0x1F0D228")]
	private void Start()
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0x1F0D2D0", Offset = "0x1F0D2D0", VA = "0x1F0D2D0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0x1F0D600", Offset = "0x1F0D600", VA = "0x1F0D600")]
	public Plate()
	{
	}
}
[Token(Token = "0x2000083")]
public enum RequestType
{
	[Token(Token = "0x40002F5")]
	PrimaryBeer,
	[Token(Token = "0x40002F6")]
	SecondaryBeer,
	[Token(Token = "0x40002F7")]
	Burger,
	[Token(Token = "0x40002F8")]
	Snag,
	[Token(Token = "0x40002F9")]
	Vegemite,
	[Token(Token = "0x40002FA")]
	Skewer
}
[Token(Token = "0x2000084")]
public class RequestHandler : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000085")]
	public class Request
	{
		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float deadlineInSeconds;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float delayIntervalInSeconds;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RequestType requestType;

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x22CD15C", Offset = "0x22CD15C", VA = "0x22CD15C")]
		public Request(float _deadlineInSeconds, float _delayIntervalInSeconds, RequestType _requestType)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000086")]
	public class RequestTypeMap
	{
		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RequestType requestType;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Sprite requestIcon;

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x22CD19C", Offset = "0x22CD19C", VA = "0x22CD19C")]
		public RequestTypeMap()
		{
		}
	}

	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA628", Offset = "0xAAA628")]
	private sealed class <AddRequestToSlot>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RequestHandler <>4__this;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Request _request;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RequestSlot _slot;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <i>5__2;

		[Token(Token = "0x170000BB")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x22CCD60", Offset = "0x22CCD60", VA = "0x22CCD60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BC")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x22CCDA8", Offset = "0x22CCDA8", VA = "0x22CCDA8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x22CCB20", Offset = "0x22CCB20", VA = "0x22CCB20")]
		[DebuggerHidden]
		public <AddRequestToSlot>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x22CCB4C", Offset = "0x22CCB4C", VA = "0x22CCB4C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x22CCB50", Offset = "0x22CCB50", VA = "0x22CCB50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x22CCD68", Offset = "0x22CCD68", VA = "0x22CCD68", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA638", Offset = "0xAAA638")]
	private sealed class <>c
	{
		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<RequestSlot> <>9__22_0;

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x22CCAF0", Offset = "0x22CCAF0", VA = "0x22CCAF0")]
		public <>c()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x22CCAF8", Offset = "0x22CCAF8", VA = "0x22CCAF8")]
		internal int <GetSlotForRequest>b__22_0(RequestSlot s1, RequestSlot s2)
		{
			return default(int);
		}
	}

	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA648", Offset = "0xAAA648")]
	private sealed class <ThrowAway>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RequestHandler <>4__this;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HVRGrabbable _grabbable;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody <g_rb>5__2;

		[Token(Token = "0x170000BD")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x22CD10C", Offset = "0x22CD10C", VA = "0x22CD10C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BE")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x22CD154", Offset = "0x22CD154", VA = "0x22CD154", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x22CCDB0", Offset = "0x22CCDB0", VA = "0x22CCDB0")]
		[DebuggerHidden]
		public <ThrowAway>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x22CCDDC", Offset = "0x22CCDDC", VA = "0x22CCDDC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x22CCDE0", Offset = "0x22CCDE0", VA = "0x22CCDE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x22CD114", Offset = "0x22CD114", VA = "0x22CD114", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isTutorialTable;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RequestSlot defaultSlot;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<RequestSlot> requestSlots;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Request> listOfRequests;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Queue<Request> _queueOfRequests;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private AudioHandler audioHandler;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject sucessParticles;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool failCoolingDown;

	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float requestDelayMultiplier;

	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int finalRequestsCounter;

	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject weAreDone;

	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject requestSuccessFailCanvas;

	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float requestTimeLimitMultiplier;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float timeBetweenRequestsMultiplier;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public List<RequestTypeMap> requestTypeSpriteMap;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Dictionary<RequestType, Sprite> _requestTypeSpriteMap;

	[Token(Token = "0x6000379")]
	[Address(RVA = "0x1F11DCC", Offset = "0x1F11DCC", VA = "0x1F11DCC")]
	protected void Start()
	{
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0x1F123AC", Offset = "0x1F123AC", VA = "0x1F123AC")]
	private void AddNewRequestToSlot(RequestSlot _slot)
	{
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0x1F1261C", Offset = "0x1F1261C", VA = "0x1F1261C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB152C", Offset = "0xAB152C")]
	private IEnumerator AddRequestToSlot(RequestSlot _slot, Request _request)
	{
		return null;
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0x1F1269C", Offset = "0x1F1269C", VA = "0x1F1269C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0x1F13028", Offset = "0x1F13028", VA = "0x1F13028")]
	protected RequestSlot GetSlotForRequest(RequestType _requestType)
	{
		return null;
	}

	[Token(Token = "0x600037E")]
	[Address(RVA = "0x1F13270", Offset = "0x1F13270", VA = "0x1F13270")]
	protected bool CheckIfBeer(Beer beer)
	{
		return default(bool);
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0x1F13A78", Offset = "0x1F13A78", VA = "0x1F13A78")]
	private bool CheckIfHamburger(RequestSlot _slot, MealPart _botBun)
	{
		return default(bool);
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0x1F14024", Offset = "0x1F14024", VA = "0x1F14024")]
	private bool CheckIfSnag(RequestSlot _slot, MealPart _bread)
	{
		return default(bool);
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0x1F13CC0", Offset = "0x1F13CC0", VA = "0x1F13CC0")]
	private bool CheckIfSkewers(RequestSlot _slot, MealPart _skewerMealPart)
	{
		return default(bool);
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0x1F132F8", Offset = "0x1F132F8", VA = "0x1F132F8")]
	protected void Success(GameObject _requestedObject, RequestSlot _slot, bool _isDrink = false)
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x1F139DC", Offset = "0x1F139DC", VA = "0x1F139DC")]
	protected void Fail(GameObject _requestedObject)
	{
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x1F141C8", Offset = "0x1F141C8", VA = "0x1F141C8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB158C", Offset = "0xAB158C")]
	private IEnumerator ThrowAway(HVRGrabbable _grabbable)
	{
		return null;
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x1F14240", Offset = "0x1F14240", VA = "0x1F14240")]
	public void SetAllCollidersStatus(GameObject collidersParent, bool active)
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x1F142FC", Offset = "0x1F142FC", VA = "0x1F142FC")]
	public void OverrideRequestList(List<Request> _requests)
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x1F135E0", Offset = "0x1F135E0", VA = "0x1F135E0")]
	private void InstanciateRequestSuccessIcon(Vector3 deliveryPosition, RequestType type, bool success)
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0x1F14578", Offset = "0x1F14578", VA = "0x1F14578")]
	public RequestHandler()
	{
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x1F14588", Offset = "0x1F14588", VA = "0x1F14588")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB15EC", Offset = "0xAB15EC")]
	private void <Start>b__18_0()
	{
	}
}
[Token(Token = "0x200008A")]
public class RequestSlot : MonoBehaviour
{
	[Token(Token = "0x200008B")]
	public enum InteractionType
	{
		[Token(Token = "0x4000331")]
		BeerRequestCan,
		[Token(Token = "0x4000332")]
		BeerRequestBottle,
		[Token(Token = "0x4000333")]
		BeerWarm,
		[Token(Token = "0x4000334")]
		BurgerRequest,
		[Token(Token = "0x4000335")]
		BurgerRaw,
		[Token(Token = "0x4000336")]
		BurgerOvercooked,
		[Token(Token = "0x4000337")]
		BurgerOneSide,
		[Token(Token = "0x4000338")]
		BurgerPlateMissing,
		[Token(Token = "0x4000339")]
		SnagRequest,
		[Token(Token = "0x400033A")]
		SnagDry,
		[Token(Token = "0x400033B")]
		SnagOvercooked,
		[Token(Token = "0x400033C")]
		SnagRaw,
		[Token(Token = "0x400033D")]
		SkewerRequest,
		[Token(Token = "0x400033E")]
		SkewerComplaint,
		[Token(Token = "0x400033F")]
		GeneralComplaint,
		[Token(Token = "0x4000340")]
		Impatience,
		[Token(Token = "0x4000341")]
		Leaving,
		[Token(Token = "0x4000342")]
		Thanks,
		[Token(Token = "0x4000343")]
		WrongOrder,
		[Token(Token = "0x4000344")]
		VegemiteTutorial,
		[Token(Token = "0x4000345")]
		QuokkaTutorial,
		[Token(Token = "0x4000346")]
		BabyrooStoleMyBeer,
		[Token(Token = "0x4000347")]
		ParachuteRoo,
		[Token(Token = "0x4000348")]
		SodaRequestCan,
		[Token(Token = "0x4000349")]
		SodaRequestBottle,
		[Token(Token = "0x400034A")]
		SodaWarm
	}

	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA658", Offset = "0xAAA658")]
	private sealed class <RemoveRequest>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RequestSlot <>4__this;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x170000BF")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x22CD3CC", Offset = "0x22CD3CC", VA = "0x22CD3CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x22CD414", Offset = "0x22CD414", VA = "0x22CD414", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x22CD1A4", Offset = "0x22CD1A4", VA = "0x22CD1A4")]
		[DebuggerHidden]
		public <RemoveRequest>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x22CD1D0", Offset = "0x22CD1D0", VA = "0x22CD1D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x22CD1D4", Offset = "0x22CD1D4", VA = "0x22CD1D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x22CD3D4", Offset = "0x22CD3D4", VA = "0x22CD3D4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA668", Offset = "0xAAA668")]
	private sealed class <showStillWaitingInteraction>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float timeToDisplayMessage;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RequestSlot <>4__this;

		[Token(Token = "0x170000C1")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x22CD67C", Offset = "0x22CD67C", VA = "0x22CD67C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C2")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x22CD6C4", Offset = "0x22CD6C4", VA = "0x22CD6C4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x22CD594", Offset = "0x22CD594", VA = "0x22CD594")]
		[DebuggerHidden]
		public <showStillWaitingInteraction>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x22CD5C0", Offset = "0x22CD5C0", VA = "0x22CD5C0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x22CD5C4", Offset = "0x22CD5C4", VA = "0x22CD5C4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x22CD684", Offset = "0x22CD684", VA = "0x22CD684", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA678", Offset = "0xAAA678")]
	private sealed class <hideInteraction>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float _interactionTime;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RequestSlot <>4__this;

		[Token(Token = "0x170000C3")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x22CD544", Offset = "0x22CD544", VA = "0x22CD544", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C4")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x22CD58C", Offset = "0x22CD58C", VA = "0x22CD58C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x22CD41C", Offset = "0x22CD41C", VA = "0x22CD41C")]
		[DebuggerHidden]
		public <hideInteraction>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x22CD448", Offset = "0x22CD448", VA = "0x22CD448", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x22CD44C", Offset = "0x22CD44C", VA = "0x22CD44C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x22CD54C", Offset = "0x22CD54C", VA = "0x22CD54C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioHandler audioHandler;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float deadline;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float timeLeft;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI timeText;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Renderer counterCircleRenderer;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Material counterCircleMaterial;

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float slackTime;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Image _requestIcon;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RequestType requestType;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int slotNumber;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool requestClone;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Canvas requestCloneCanvas;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Image requestCloneSprite;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private TextMeshProUGUI requestCloneTimeText;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public TextMeshProUGUI interactionTextCanvas;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int interactionTime;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Coroutine _runningHideInteractionCoroutine;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float timeSinceLastCalled;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private bool stopTimer;

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x1F14594", Offset = "0x1F14594", VA = "0x1F14594")]
	private void Awake()
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x1F146F0", Offset = "0x1F146F0", VA = "0x1F146F0")]
	private void Update()
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0x1F14828", Offset = "0x1F14828", VA = "0x1F14828")]
	private void UpdateTimer()
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x1F149A8", Offset = "0x1F149A8", VA = "0x1F149A8")]
	public void SetupNewRequest(RequestType _requestType, float _deadline, Sprite _icon)
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x1F1493C", Offset = "0x1F1493C", VA = "0x1F1493C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB169C", Offset = "0xAB169C")]
	private IEnumerator RemoveRequest()
	{
		return null;
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x1F14DF4", Offset = "0x1F14DF4", VA = "0x1F14DF4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x1F14B84", Offset = "0x1F14B84", VA = "0x1F14B84")]
	private void showNewRequestInteraction(RequestType _requestType)
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x1F14D78", Offset = "0x1F14D78", VA = "0x1F14D78")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB16FC", Offset = "0xAB16FC")]
	private IEnumerator showStillWaitingInteraction(float timeToDisplayMessage)
	{
		return null;
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x1F13778", Offset = "0x1F13778", VA = "0x1F13778")]
	public void showInteraction(InteractionType _type, bool showText = true)
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x1F14ED8", Offset = "0x1F14ED8", VA = "0x1F14ED8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB175C", Offset = "0xAB175C")]
	private IEnumerator hideInteraction(float _interactionTime)
	{
		return null;
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x1F14F54", Offset = "0x1F14F54", VA = "0x1F14F54")]
	public RequestSlot()
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x1F14F6C", Offset = "0x1F14F6C", VA = "0x1F14F6C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB17BC", Offset = "0xAB17BC")]
	private void <showInteraction>b__28_0(string s)
	{
	}
}
[Token(Token = "0x200008F")]
public class RequestSuccessFailIconDisplay : MonoBehaviour
{
	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA688", Offset = "0xAAA688")]
	private sealed class <FadeOut>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RequestSuccessFailIconDisplay <>4__this;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForFixedUpdate <wait>5__2;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <time>5__3;

		[Token(Token = "0x170000C5")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x22CD89C", Offset = "0x22CD89C", VA = "0x22CD89C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x22CD8E4", Offset = "0x22CD8E4", VA = "0x22CD8E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x22CD6CC", Offset = "0x22CD6CC", VA = "0x22CD6CC")]
		[DebuggerHidden]
		public <FadeOut>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x22CD6F8", Offset = "0x22CD6F8", VA = "0x22CD6F8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x22CD6FC", Offset = "0x22CD6FC", VA = "0x22CD6FC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x22CD8A4", Offset = "0x22CD8A4", VA = "0x22CD8A4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CanvasGroup canvasGroup;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image requestIcon;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject successIcon;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject failIcon;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float fadeTime;

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x1F14504", Offset = "0x1F14504", VA = "0x1F14504")]
	public void DisplayRequest(Sprite icon, bool success)
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x1F1500C", Offset = "0x1F1500C", VA = "0x1F1500C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB18BC", Offset = "0xAB18BC")]
	private IEnumerator FadeOut()
	{
		return null;
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x1F15078", Offset = "0x1F15078", VA = "0x1F15078")]
	public RequestSuccessFailIconDisplay()
	{
	}
}
[Token(Token = "0x2000091")]
public class SauceBehaviour : MonoBehaviour
{
	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioHandler audioHandler;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem particleSystem;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private HVRGrabbable grabbable;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private HVRHandGrabber hand;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool squirting;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool achievementAwarded;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float timeSauceOn;

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x1F15724", Offset = "0x1F15724", VA = "0x1F15724")]
	private void Start()
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x1F15864", Offset = "0x1F15864", VA = "0x1F15864")]
	private void RegisterHandGrab(HVRGrabberBase _grabber, HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x1F15964", Offset = "0x1F15964", VA = "0x1F15964")]
	private void UnregisterHandGrab(HVRGrabberBase _grabber, HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x1F15A68", Offset = "0x1F15A68", VA = "0x1F15A68")]
	private void Update()
	{
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x1F15CE8", Offset = "0x1F15CE8", VA = "0x1F15CE8")]
	public SauceBehaviour()
	{
	}
}
[Token(Token = "0x2000092")]
public class GameManager : Singleton<GameManager>
{
	[Token(Token = "0x2000093")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA698", Offset = "0xAAA698")]
	private sealed class <FadeInScreen>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameManager <>4__this;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float delay;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timeout>5__2;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSecondsRealtime <wait>5__3;

		[Token(Token = "0x170000C8")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x1FE549C", Offset = "0x1FE549C", VA = "0x1FE549C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C9")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x1FE54E4", Offset = "0x1FE54E4", VA = "0x1FE54E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1FE5254", Offset = "0x1FE5254", VA = "0x1FE5254")]
		[DebuggerHidden]
		public <FadeInScreen>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x1FE5280", Offset = "0x1FE5280", VA = "0x1FE5280", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x1FE5284", Offset = "0x1FE5284", VA = "0x1FE5284", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1FE54A4", Offset = "0x1FE54A4", VA = "0x1FE54A4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA6A8", Offset = "0xAAA6A8")]
	private sealed class <LoadScene>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameManager <>4__this;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string sceneName;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string <currentScene>5__2;

		[Token(Token = "0x170000CA")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x1FE5AFC", Offset = "0x1FE5AFC", VA = "0x1FE5AFC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CB")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x1FE5B44", Offset = "0x1FE5B44", VA = "0x1FE5B44", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1FE54EC", Offset = "0x1FE54EC", VA = "0x1FE54EC")]
		[DebuggerHidden]
		public <LoadScene>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1FE5518", Offset = "0x1FE5518", VA = "0x1FE5518", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x1FE551C", Offset = "0x1FE551C", VA = "0x1FE551C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1FE5B04", Offset = "0x1FE5B04", VA = "0x1FE5B04", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject playerPrefab;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float fadeSpeed;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public SavedData savedData;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public GameStatistics gameStatistics;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private AussiePlayer aussiePlayer;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private HVRScreenFade screenFader;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public BeerSkin beerSkin;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public HVRTimeManager timeManager;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool pauseBool;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float timeScaleBeforePause;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int arcadeStartWave;

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public DifficultyConfig difficulty;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public Events.EventSettingsChanged OnSettingsChange;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[HideInInspector]
	public Events.EventEnterNewLevel OnEnterNewLevel;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Events.EventExitLevel OnExitLevel;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public Events.EventPause OnPause;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[HideInInspector]
	public Events.EventUnPause OnUnPause;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private string mainMenuScenename;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool accessOnlineServices;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private AsyncOperation asyncLoad;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private bool pauseWhenUnfocus;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[HideInInspector]
	public Dictionary<string, Texture2D> leaderboardSignatureCache;

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	internal ES3Settings saveSettings;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	internal bool waitForSaveFile;

	[Token(Token = "0x170000C7")]
	public bool isDemo
	{
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x1F20694", Offset = "0x1F20694", VA = "0x1F20694")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x1F206EC", Offset = "0x1F206EC", VA = "0x1F206EC", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x1F21318", Offset = "0x1F21318", VA = "0x1F21318")]
	private void Start()
	{
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x1F21584", Offset = "0x1F21584", VA = "0x1F21584")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB196C", Offset = "0xAB196C")]
	private IEnumerator FadeInScreen(float delay)
	{
		return null;
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x1F21600", Offset = "0x1F21600", VA = "0x1F21600")]
	private void Update()
	{
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x1F217CC", Offset = "0x1F217CC", VA = "0x1F217CC")]
	public void StartGame(string scenename = "SampleScene")
	{
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x1F21870", Offset = "0x1F21870", VA = "0x1F21870")]
	public void QuitGame()
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x1F21878", Offset = "0x1F21878", VA = "0x1F21878")]
	public void BackToMenu()
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x1F217F8", Offset = "0x1F217F8", VA = "0x1F217F8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB19CC", Offset = "0xAB19CC")]
	private IEnumerator LoadScene(string sceneName)
	{
		return null;
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x1F218AC", Offset = "0x1F218AC", VA = "0x1F218AC")]
	public void GetPlayerNeutralForNewScene()
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x1F219B8", Offset = "0x1F219B8", VA = "0x1F219B8")]
	public void AddLevelStatsToGeneral(GameStatistics _levelData)
	{
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x1F221C0", Offset = "0x1F221C0", VA = "0x1F221C0")]
	public void AddStarsToLevel(int _stars, int _level, int _levelDuration = 0)
	{
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x1F22274", Offset = "0x1F22274", VA = "0x1F22274")]
	public void SaveSignature(Texture2D _signature, string _signatureImageSource)
	{
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x1F22328", Offset = "0x1F22328", VA = "0x1F22328")]
	public int GetArcadeHighscore(ArcadeMode _mode)
	{
		return default(int);
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x1F22344", Offset = "0x1F22344", VA = "0x1F22344")]
	public int GetArcadeLowestScore(ArcadeMode _mode)
	{
		return default(int);
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x1F22360", Offset = "0x1F22360", VA = "0x1F22360")]
	public void GetArcadeScoreRank(ArcadeMode _mode, int _score, out List<SavedData.ArcadeScore> tempListScores, out int index)
	{
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x1F2237C", Offset = "0x1F2237C", VA = "0x1F2237C")]
	public int GetLongestArcadeWaveRun(ArcadeMode _mode)
	{
		return default(int);
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x1F22398", Offset = "0x1F22398", VA = "0x1F22398")]
	public void SaveArcadeScore(int _score, int _waves, float _timeElapsed, ArcadeMode _mode, [Optional] Texture2D _signature)
	{
	}

	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x1F22500", Offset = "0x1F22500", VA = "0x1F22500")]
	public float GetHeightAdjustment(HeightAdjustmentOption keyword)
	{
		return default(float);
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x1F2251C", Offset = "0x1F2251C", VA = "0x1F2251C")]
	public void SetHeightAdjustment(HeightAdjustmentOption keyword, float value)
	{
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x1F22550", Offset = "0x1F22550", VA = "0x1F22550")]
	public void ChangeDifficulty(DifficultyConfig _difficulty)
	{
	}

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x1F22588", Offset = "0x1F22588", VA = "0x1F22588")]
	public void DeleteSavedFiles()
	{
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x1F22770", Offset = "0x1F22770", VA = "0x1F22770")]
	public void MagicStarsUnlock()
	{
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x1F1EADC", Offset = "0x1F1EADC", VA = "0x1F1EADC")]
	public void SaveGameData()
	{
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x1F22158", Offset = "0x1F22158", VA = "0x1F22158")]
	public void SaveGameStats()
	{
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x1F218A8", Offset = "0x1F218A8", VA = "0x1F218A8")]
	public void SavePlayerPrefs()
	{
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x1F227B8", Offset = "0x1F227B8", VA = "0x1F227B8")]
	public void RecordCricketGoal()
	{
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x1F21B20", Offset = "0x1F21B20", VA = "0x1F21B20")]
	public void AchievementCheck()
	{
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x1F2288C", Offset = "0x1F2288C", VA = "0x1F2288C")]
	public void FadeScreenToBlack(float _fadeSpeed)
	{
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x1F20D3C", Offset = "0x1F20D3C", VA = "0x1F20D3C")]
	private void LoadLocalLeaderboardSignatures()
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x1F216FC", Offset = "0x1F216FC", VA = "0x1F216FC")]
	public void Pause()
	{
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x1F2176C", Offset = "0x1F2176C", VA = "0x1F2176C")]
	public void Unpause()
	{
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x1F228B0", Offset = "0x1F228B0", VA = "0x1F228B0")]
	private void OnApplicationFocus(bool focus)
	{
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x1F20968", Offset = "0x1F20968", VA = "0x1F20968")]
	public void DisableOnlineServices()
	{
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x1F228C4", Offset = "0x1F228C4", VA = "0x1F228C4")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x1F20AE0", Offset = "0x1F20AE0", VA = "0x1F20AE0")]
	private void LoadSaveOrCreateNew()
	{
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x1F228E8", Offset = "0x1F228E8", VA = "0x1F228E8")]
	internal bool LoadSaveFileFromES3()
	{
		return default(bool);
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x1F2267C", Offset = "0x1F2267C", VA = "0x1F2267C")]
	public void CreateNewSaveData()
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x1F229E0", Offset = "0x1F229E0", VA = "0x1F229E0")]
	public GameManager()
	{
	}
}
[Token(Token = "0x2000095")]
public class AussieDestructible : HVRDestructible
{
	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA6B8", Offset = "0xAAA6B8")]
	private sealed class <ShortlyUncolidableCoroutine>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AussieDestructible <>4__this;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float _time;

		[Token(Token = "0x170000CC")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x1F49D34", Offset = "0x1F49D34", VA = "0x1F49D34", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CD")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0x1F49D7C", Offset = "0x1F49D7C", VA = "0x1F49D7C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1F49C18", Offset = "0x1F49C18", VA = "0x1F49C18")]
		[DebuggerHidden]
		public <ShortlyUncolidableCoroutine>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1F49C44", Offset = "0x1F49C44", VA = "0x1F49C44", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x1F49C48", Offset = "0x1F49C48", VA = "0x1F49C48", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1F49D3C", Offset = "0x1F49D3C", VA = "0x1F49D3C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA6C8", Offset = "0xAAA6C8")]
	private sealed class <MakeBottleTemporarilyUnbreakeableCoroutine>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AussieDestructible <>4__this;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <originalForceThrehold>5__2;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <originalVelocityThrehold>5__3;

		[Token(Token = "0x170000CE")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600040B")]
			[Address(RVA = "0x1F49BC8", Offset = "0x1F49BC8", VA = "0x1F49BC8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CF")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600040D")]
			[Address(RVA = "0x1F49C10", Offset = "0x1F49C10", VA = "0x1F49C10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1F49A90", Offset = "0x1F49A90", VA = "0x1F49A90")]
		[DebuggerHidden]
		public <MakeBottleTemporarilyUnbreakeableCoroutine>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1F49ABC", Offset = "0x1F49ABC", VA = "0x1F49ABC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1F49AC0", Offset = "0x1F49AC0", VA = "0x1F49AC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x1F49BD0", Offset = "0x1F49BD0", VA = "0x1F49BD0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private HVRSocket socket;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float forceToAddToGrabbable;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool wasDestroyed;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private HVRGrabbable grabbable;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Collider[] colliders;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private HVRCollisionEvents collisionHandler;

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x1EA6BD0", Offset = "0x1EA6BD0", VA = "0x1EA6BD0")]
	private void Start()
	{
	}

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0x1EA6D04", Offset = "0x1EA6D04", VA = "0x1EA6D04")]
	private void ShortlyUncolideble(HVRHandGrabber arg0, HVRGrabbable arg1)
	{
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x1EA6D38", Offset = "0x1EA6D38", VA = "0x1EA6D38")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB1ACC", Offset = "0xAB1ACC")]
	private IEnumerator ShortlyUncolidableCoroutine(float _time)
	{
		return null;
	}

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0x1EA6DB4", Offset = "0x1EA6DB4", VA = "0x1EA6DB4", Slot = "4")]
	public override void Destroy()
	{
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0x1EA7470", Offset = "0x1EA7470", VA = "0x1EA7470")]
	public void SetAllCollidersAsTrigger(bool _active)
	{
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x1EA74EC", Offset = "0x1EA74EC", VA = "0x1EA74EC")]
	public void MakeBottleTemporarilyUnbreakeable()
	{
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0x1EA7518", Offset = "0x1EA7518", VA = "0x1EA7518")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB1B2C", Offset = "0xAB1B2C")]
	private IEnumerator MakeBottleTemporarilyUnbreakeableCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0x1EA7584", Offset = "0x1EA7584", VA = "0x1EA7584")]
	public AussieDestructible()
	{
	}
}
[Token(Token = "0x2000098")]
public class Beer : MonoBehaviour
{
	[Token(Token = "0x2000099")]
	public enum BeerType
	{
		[Token(Token = "0x40003A9")]
		PrimaryBeers,
		[Token(Token = "0x40003AA")]
		SecondaryBeers,
		[Token(Token = "0x40003AB")]
		TertiaryBeers
	}

	[Token(Token = "0x200009A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA6D8", Offset = "0xAAA6D8")]
	private sealed class <ShortlyUncolidableCoroutine>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Beer <>4__this;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float _time;

		[Token(Token = "0x170000D0")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000420")]
			[Address(RVA = "0x1F4A3D4", Offset = "0x1F4A3D4", VA = "0x1F4A3D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D1")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x1F4A41C", Offset = "0x1F4A41C", VA = "0x1F4A41C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x1F4A2C0", Offset = "0x1F4A2C0", VA = "0x1F4A2C0")]
		[DebuggerHidden]
		public <ShortlyUncolidableCoroutine>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x1F4A2EC", Offset = "0x1F4A2EC", VA = "0x1F4A2EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x1F4A2F0", Offset = "0x1F4A2F0", VA = "0x1F4A2F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x1F4A3DC", Offset = "0x1F4A3DC", VA = "0x1F4A3DC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200009B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA6E8", Offset = "0xAAA6E8")]
	private sealed class <GuideToPlayer>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Beer <>4__this;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForFixedUpdate <waitForFixedUpdate>5__2;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <hasUpdatedColliders>5__3;

		[Token(Token = "0x170000D2")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x1F4A270", Offset = "0x1F4A270", VA = "0x1F4A270", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D3")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000428")]
			[Address(RVA = "0x1F4A2B8", Offset = "0x1F4A2B8", VA = "0x1F4A2B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1F49F04", Offset = "0x1F49F04", VA = "0x1F49F04")]
		[DebuggerHidden]
		public <GuideToPlayer>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x1F49F30", Offset = "0x1F49F30", VA = "0x1F49F30", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x1F49F34", Offset = "0x1F49F34", VA = "0x1F49F34", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1F4A278", Offset = "0x1F4A278", VA = "0x1F4A278", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool upForGrabs;

	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Enemy enemyGrabbing;

	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public HVRGrabbable grabbable;

	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAAB5B0", Offset = "0xAAB5B0")]
	public GameObject BeerStealParticles;

	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Rigidbody rb;

	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool isFlying;

	[Token(Token = "0x40003A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Collider[] _colliders;

	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public BeerType beerType;

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Transform playerTransform;

	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float upForceMultiplier;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float sideForceMultiplier;

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAAB5E8", Offset = "0xAAB5E8")]
	public BeerSkin beerSkin;

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool selectionMenuBeer;

	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
	private bool lostAlreadySafetyBool;

	[Token(Token = "0x600040E")]
	[Address(RVA = "0x1EA94F0", Offset = "0x1EA94F0", VA = "0x1EA94F0")]
	private void Start()
	{
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0x1EA9638", Offset = "0x1EA9638", VA = "0x1EA9638")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000410")]
	[Address(RVA = "0x1EA7278", Offset = "0x1EA7278", VA = "0x1EA7278")]
	public void LoseBeer()
	{
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0x1EA96C8", Offset = "0x1EA96C8", VA = "0x1EA96C8")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0x1EA96D8", Offset = "0x1EA96D8", VA = "0x1EA96D8")]
	private void DropedBeer()
	{
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0x1EA96E4", Offset = "0x1EA96E4", VA = "0x1EA96E4")]
	public void BeerJumpBack(float extraForceMultipler = 1f)
	{
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0x1EA9AB0", Offset = "0x1EA9AB0", VA = "0x1EA9AB0")]
	public void ShortlyUncolidable(float _time)
	{
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0x1EA985C", Offset = "0x1EA985C", VA = "0x1EA985C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB1C2C", Offset = "0xAB1C2C")]
	private IEnumerator ShortlyUncolidableCoroutine(float _time)
	{
		return null;
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0x1EA9A44", Offset = "0x1EA9A44", VA = "0x1EA9A44")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB1C8C", Offset = "0xAB1C8C")]
	private IEnumerator GuideToPlayer()
	{
		return null;
	}

	[Token(Token = "0x6000417")]
	[Address(RVA = "0x1EA9ADC", Offset = "0x1EA9ADC", VA = "0x1EA9ADC")]
	public void SetCollisionDetectionStatus(bool active)
	{
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0x1EA9B0C", Offset = "0x1EA9B0C", VA = "0x1EA9B0C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0x1EA98D8", Offset = "0x1EA98D8", VA = "0x1EA98D8")]
	private Transform GetPlayerTransform()
	{
		return null;
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0x1EA99A4", Offset = "0x1EA99A4", VA = "0x1EA99A4")]
	private Rigidbody GetRigidBody()
	{
		return null;
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0x1EA9598", Offset = "0x1EA9598", VA = "0x1EA9598")]
	private HVRGrabbable GetGrabbable()
	{
		return null;
	}

	[Token(Token = "0x600041C")]
	[Address(RVA = "0x1EA9B14", Offset = "0x1EA9B14", VA = "0x1EA9B14")]
	public Beer()
	{
	}
}
[Token(Token = "0x200009C")]
public class BeerBox : MonoBehaviour
{
	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool upForGrabs;

	[Token(Token = "0x40003B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public DingoBehaviour enemyGrabbing;

	[Token(Token = "0x6000429")]
	[Address(RVA = "0x1EA9B24", Offset = "0x1EA9B24", VA = "0x1EA9B24")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600042A")]
	[Address(RVA = "0x1EA9C78", Offset = "0x1EA9C78", VA = "0x1EA9C78")]
	public BeerBox()
	{
	}
}
[Token(Token = "0x200009D")]
public class BeerCollector : MonoBehaviour
{
	[Token(Token = "0x200009E")]
	public enum BeerType
	{
		[Token(Token = "0x40003BD")]
		PrimaryBeers,
		[Token(Token = "0x40003BE")]
		SecondaryBeers,
		[Token(Token = "0x40003BF")]
		TertiaryBeers
	}

	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public HVRSocketContainer socketContainer;

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float spitBeerForceMultiplier;

	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioHandler audioHandler;

	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject backInTheBoxParticles;

	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public BeerType beerType;

	[Token(Token = "0x600042B")]
	[Address(RVA = "0x1EA9C88", Offset = "0x1EA9C88", VA = "0x1EA9C88")]
	public void Start()
	{
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0x1EA9CDC", Offset = "0x1EA9CDC", VA = "0x1EA9CDC")]
	public void ThrowObjectAway(GameObject obj)
	{
	}

	[Token(Token = "0x600042D")]
	[Address(RVA = "0x1EA9E30", Offset = "0x1EA9E30", VA = "0x1EA9E30")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0x1EAA144", Offset = "0x1EAA144", VA = "0x1EAA144")]
	public BeerCollector()
	{
	}
}
[Token(Token = "0x200009F")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xAAA6F8", Offset = "0xAAA6F8")]
public class BeerCooling : FoodAction
{
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA758", Offset = "0xAAA758")]
	private sealed class <WaitThenStartWarming>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BeerCooling <>4__this;

		[Token(Token = "0x170000D4")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600043B")]
			[Address(RVA = "0x1F4A50C", Offset = "0x1F4A50C", VA = "0x1F4A50C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D5")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x1F4A554", Offset = "0x1F4A554", VA = "0x1F4A554", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1F4A424", Offset = "0x1F4A424", VA = "0x1F4A424")]
		[DebuggerHidden]
		public <WaitThenStartWarming>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x1F4A450", Offset = "0x1F4A450", VA = "0x1F4A450", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1F4A454", Offset = "0x1F4A454", VA = "0x1F4A454", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1F4A514", Offset = "0x1F4A514", VA = "0x1F4A514", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private HVRGrabbable grababble;

	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float timeBeforeStartingToWarmUp;

	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private IEnumerator warmingCoroutine;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private ParticleSystem particleSys;

	[Token(Token = "0x600042F")]
	[Address(RVA = "0x1EAA158", Offset = "0x1EAA158", VA = "0x1EAA158", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0x1EAA4B4", Offset = "0x1EAA4B4", VA = "0x1EAA4B4")]
	private void OnGrab(HVRGrabberBase grabberBase, HVRGrabbable obj)
	{
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0x1EAA55C", Offset = "0x1EAA55C", VA = "0x1EAA55C")]
	private void OnRelease(HVRGrabberBase grabberBase, HVRGrabbable obj)
	{
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0x1EAA634", Offset = "0x1EAA634", VA = "0x1EAA634")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB1D8C", Offset = "0xAB1D8C")]
	public IEnumerator WaitThenStartWarming()
	{
		return null;
	}

	[Token(Token = "0x6000433")]
	[Address(RVA = "0x1EAA6A0", Offset = "0x1EAA6A0", VA = "0x1EAA6A0", Slot = "6")]
	public override void updateMaterial()
	{
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0x1EAA360", Offset = "0x1EAA360", VA = "0x1EAA360")]
	private void setDisplayMaterials()
	{
	}

	[Token(Token = "0x6000435")]
	[Address(RVA = "0x1EAA808", Offset = "0x1EAA808", VA = "0x1EAA808")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000436")]
	[Address(RVA = "0x1EAA768", Offset = "0x1EAA768", VA = "0x1EAA768")]
	private ParticleSystem GetParticlesSystem()
	{
		return null;
	}

	[Token(Token = "0x6000437")]
	[Address(RVA = "0x1EAA970", Offset = "0x1EAA970", VA = "0x1EAA970")]
	public BeerCooling()
	{
	}
}
[Token(Token = "0x20000A1")]
public class BeerPouringHandler : MonoBehaviour
{
	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleSystem beerPouring;

	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private HVRGrabbable grababble;

	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioHandler audioHandler;

	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject cap;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool beerOpen;

	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAAB630", Offset = "0xAAB630")]
	[SerializeField]
	private float boomerangSpeedToOpen;

	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material beerCanOpenMaterial;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ParticleSystem sprayParticles;

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool bottle;

	[Token(Token = "0x600043E")]
	[Address(RVA = "0x1EAA980", Offset = "0x1EAA980", VA = "0x1EAA980")]
	private void Start()
	{
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0x1EAA9D4", Offset = "0x1EAA9D4", VA = "0x1EAA9D4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0x1EAAC28", Offset = "0x1EAAC28", VA = "0x1EAAC28")]
	private void Update()
	{
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0x1EAAD28", Offset = "0x1EAAD28", VA = "0x1EAAD28")]
	private void StartPouring()
	{
	}

	[Token(Token = "0x6000442")]
	[Address(RVA = "0x1EAAD8C", Offset = "0x1EAAD8C", VA = "0x1EAAD8C")]
	private void StopPouring()
	{
	}

	[Token(Token = "0x6000443")]
	[Address(RVA = "0x1EAAB5C", Offset = "0x1EAAB5C", VA = "0x1EAAB5C")]
	public void BeerOpen(bool _bool)
	{
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0x1EAADF0", Offset = "0x1EAADF0", VA = "0x1EAADF0")]
	private void SetBeerOpenMaterial()
	{
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0x1EAAF70", Offset = "0x1EAAF70", VA = "0x1EAAF70")]
	public BeerPouringHandler()
	{
	}
}
[Token(Token = "0x20000A2")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xAAA768", Offset = "0xAAA768")]
public class BeerSkin : ScriptableObject
{
	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string skinName;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material canNormalMaterial;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material canFrostyMaterial;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material canNormalMaterialNA;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Material canFrostyMaterialNA;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material bottleNormalMaterial;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material bottleFrostyMaterial;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material bottleNormalMaterialNA;

	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Material bottleFrostyMaterialNA;

	[Token(Token = "0x6000446")]
	[Address(RVA = "0x1EAAF78", Offset = "0x1EAAF78", VA = "0x1EAAF78")]
	public BeerSkin()
	{
	}
}
[Token(Token = "0x20000A3")]
public class BeerSkinSelector : MonoBehaviour
{
	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public BeerSkin currentBeerSkin;

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int currentBeerSkinIndex;

	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject selectionBeerDisplay;

	[Token(Token = "0x40003DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Renderer skinRenderer;

	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public HVRSocket socket;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject beerbox;

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public MeshRenderer selectedBeer;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject magicGlow;

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject constantGlow;

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public AudioHandler socketAudioHandler;

	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<BeerSkin> beerSkins;

	[Token(Token = "0x6000447")]
	[Address(RVA = "0x1EAAF80", Offset = "0x1EAAF80", VA = "0x1EAAF80")]
	private void Start()
	{
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0x1EAB424", Offset = "0x1EAB424", VA = "0x1EAB424")]
	private void setDisplayMaterial()
	{
	}

	[Token(Token = "0x6000449")]
	[Address(RVA = "0x1EAB500", Offset = "0x1EAB500", VA = "0x1EAB500")]
	public void SelectSkin(HVRGrabberBase grabber, HVRGrabbable grabbable)
	{
	}

	[Token(Token = "0x600044A")]
	[Address(RVA = "0x1EAB680", Offset = "0x1EAB680", VA = "0x1EAB680")]
	private void PlaySelectSkinAnimation(HVRGrabberBase grabber, HVRGrabbable grabbable)
	{
	}

	[Token(Token = "0x600044B")]
	[Address(RVA = "0x1EAB710", Offset = "0x1EAB710", VA = "0x1EAB710")]
	private void StopSelectSkinAnimation(HVRGrabberBase grabber, HVRGrabbable grabbable)
	{
	}

	[Token(Token = "0x600044C")]
	[Address(RVA = "0x1EAB78C", Offset = "0x1EAB78C", VA = "0x1EAB78C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600044D")]
	[Address(RVA = "0x1EAB8F4", Offset = "0x1EAB8F4", VA = "0x1EAB8F4")]
	public BeerSkinSelector()
	{
	}
}
[Token(Token = "0x20000A4")]
public class BreadMealPart : MealPart
{
	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Renderer breadRenderer;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private SnagMealPart snagMealPart;

	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool vegemited;

	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Texture2D vegemitedTexture;

	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject particlesObject;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	private Animator animator;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Transform cameraTransform;

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private MeshCollider meshColllider;

	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Mesh defaultMesh;

	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Mesh foldedMesh;

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAAB690", Offset = "0xAAB690")]
	public HVRSocket socket;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject ketchup;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject mustard;

	[Token(Token = "0x600044E")]
	[Address(RVA = "0x1EAFD6C", Offset = "0x1EAFD6C", VA = "0x1EAFD6C", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x1EAFF64", Offset = "0x1EAFF64", VA = "0x1EAFF64")]
	private void OnSocketGrab(HVRGrabberBase _grabber, HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0x1EB0040", Offset = "0x1EB0040", VA = "0x1EB0040")]
	private void ResetGrabber()
	{
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0x1EB011C", Offset = "0x1EB011C", VA = "0x1EB011C")]
	private void OnSocketRelease(HVRGrabberBase _grabber, HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x6000452")]
	[Address(RVA = "0x1EB01AC", Offset = "0x1EB01AC", VA = "0x1EB01AC")]
	public void GetVegemited()
	{
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0x1EB0284", Offset = "0x1EB0284", VA = "0x1EB0284")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0x1EB0374", Offset = "0x1EB0374", VA = "0x1EB0374")]
	private void Update()
	{
	}

	[Token(Token = "0x6000455")]
	[Address(RVA = "0x1EB059C", Offset = "0x1EB059C", VA = "0x1EB059C")]
	public BreadMealPart()
	{
	}
}
[Token(Token = "0x20000A5")]
public class BurgerSide : FoodAction
{
	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public BurgerSide otherSide;

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Collider currentGrill;

	[Token(Token = "0x6000456")]
	[Address(RVA = "0x1EB0E48", Offset = "0x1EB0E48", VA = "0x1EB0E48")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0x1EB0F34", Offset = "0x1EB0F34", VA = "0x1EB0F34")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0x1EB1080", Offset = "0x1EB1080", VA = "0x1EB1080", Slot = "5")]
	public override void DoneStateUpdate(DoneState newDoneState)
	{
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0x1EB10BC", Offset = "0x1EB10BC", VA = "0x1EB10BC")]
	public void burnAllBurger()
	{
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0x1EB0FC8", Offset = "0x1EB0FC8", VA = "0x1EB0FC8")]
	public void StopGrilling()
	{
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0x1EB1104", Offset = "0x1EB1104", VA = "0x1EB1104")]
	public BurgerSide()
	{
	}
}
[Token(Token = "0x20000A6")]
public class BurnableFoodAction : FoodAction
{
	[Token(Token = "0x600045C")]
	[Address(RVA = "0x1EB110C", Offset = "0x1EB110C", VA = "0x1EB110C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0x1EB11F4", Offset = "0x1EB11F4", VA = "0x1EB11F4")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0x1EB1320", Offset = "0x1EB1320", VA = "0x1EB1320")]
	public BurnableFoodAction()
	{
	}
}
[Token(Token = "0x20000A7")]
public class FoodAction : MonoBehaviour
{
	[Token(Token = "0x20000A8")]
	public enum DoneState
	{
		[Token(Token = "0x4000405")]
		UNDONE,
		[Token(Token = "0x4000406")]
		DONE,
		[Token(Token = "0x4000407")]
		OVERDONE
	}

	[Token(Token = "0x20000A9")]
	public enum State
	{
		[Token(Token = "0x4000409")]
		IDLE,
		[Token(Token = "0x400040A")]
		DOING,
		[Token(Token = "0x400040B")]
		UNDOING
	}

	[Token(Token = "0x20000AA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA7BC", Offset = "0xAAA7BC")]
	private sealed class <Success>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FoodAction <>4__this;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <animationTime>5__2;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject <successIconObject>5__3;

		[Token(Token = "0x170000D6")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x1FE5204", Offset = "0x1FE5204", VA = "0x1FE5204", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D7")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600046F")]
			[Address(RVA = "0x1FE524C", Offset = "0x1FE524C", VA = "0x1FE524C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x1FE4EF4", Offset = "0x1FE4EF4", VA = "0x1FE4EF4")]
		[DebuggerHidden]
		public <Success>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x1FE4F20", Offset = "0x1FE4F20", VA = "0x1FE4F20", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x1FE4F24", Offset = "0x1FE4F24", VA = "0x1FE4F24", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x1FE520C", Offset = "0x1FE520C", VA = "0x1FE520C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000AB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA7CC", Offset = "0xAAA7CC")]
	private sealed class <Overdoing>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FoodAction <>4__this;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SpriteRenderer <warningSpriteRenderer>5__2;

		[Token(Token = "0x170000D8")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000473")]
			[Address(RVA = "0x1FE4EA4", Offset = "0x1FE4EA4", VA = "0x1FE4EA4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D9")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000475")]
			[Address(RVA = "0x1FE4EEC", Offset = "0x1FE4EEC", VA = "0x1FE4EEC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x1FE4ADC", Offset = "0x1FE4ADC", VA = "0x1FE4ADC")]
		[DebuggerHidden]
		public <Overdoing>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x1FE4B08", Offset = "0x1FE4B08", VA = "0x1FE4B08", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x1FE4B0C", Offset = "0x1FE4B0C", VA = "0x1FE4B0C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x1FE4EAC", Offset = "0x1FE4EAC", VA = "0x1FE4EAC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject progressBar;

	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Material progressBarMaterial;

	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject progressIcon;

	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject successIcon;

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject warningIcon;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material originalMaterial;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material undoneDoneMaterial;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material overDoneMaterial;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected AudioHandler audioHandler;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Coroutine overdoing;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject burningParticles;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public DoneState doneState;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public State state;

	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float timeUntilReady;

	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float timeUntilOverdone;

	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float donePercentage;

	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public bool canBeOverdone;

	[Token(Token = "0x600045F")]
	[Address(RVA = "0x1F1FEA8", Offset = "0x1F1FEA8", VA = "0x1F1FEA8", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0x1F200E4", Offset = "0x1F200E4", VA = "0x1F200E4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000461")]
	[Address(RVA = "0x1F20248", Offset = "0x1F20248", VA = "0x1F20248")]
	public void StateUpdate(State newState)
	{
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0x1F2002C", Offset = "0x1F2002C", VA = "0x1F2002C")]
	private void setProgressBarActive(bool active)
	{
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x1F20460", Offset = "0x1F20460", VA = "0x1F20460", Slot = "5")]
	public virtual void DoneStateUpdate(DoneState newDoneState)
	{
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0x1F20530", Offset = "0x1F20530", VA = "0x1F20530", Slot = "6")]
	public virtual void updateMaterial()
	{
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0x1F204C4", Offset = "0x1F204C4", VA = "0x1F204C4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB1E3C", Offset = "0xAB1E3C")]
	private IEnumerator Success()
	{
		return null;
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0x1F202DC", Offset = "0x1F202DC", VA = "0x1F202DC")]
	private void StopOverdoing()
	{
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0x1F203F4", Offset = "0x1F203F4", VA = "0x1F203F4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB1E9C", Offset = "0xAB1E9C")]
	private IEnumerator Overdoing()
	{
		return null;
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0x1F2067C", Offset = "0x1F2067C", VA = "0x1F2067C")]
	protected void SetStateToIdle()
	{
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0x1F20684", Offset = "0x1F20684", VA = "0x1F20684")]
	public FoodAction()
	{
	}
}
[Token(Token = "0x20000AC")]
public class Grill : MonoBehaviour
{
	[Token(Token = "0x6000476")]
	[Address(RVA = "0x1F265A4", Offset = "0x1F265A4", VA = "0x1F265A4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000477")]
	[Address(RVA = "0x1F265A8", Offset = "0x1F265A8", VA = "0x1F265A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0x1F265AC", Offset = "0x1F265AC", VA = "0x1F265AC")]
	public Grill()
	{
	}
}
[Token(Token = "0x20000AD")]
public class LockedSkinEnabler : MonoBehaviour
{
	[Token(Token = "0x20000AE")]
	public enum UnlockType
	{
		[Token(Token = "0x400041A")]
		Stars,
		[Token(Token = "0x400041B")]
		ArcadeCooking,
		[Token(Token = "0x400041C")]
		ArcadeSurvival
	}

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject unlockedObject;

	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject lockedObject;

	[Token(Token = "0x4000417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int numberToUnlock;

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public UnlockType unlockType;

	[Token(Token = "0x6000479")]
	[Address(RVA = "0x1F02FCC", Offset = "0x1F02FCC", VA = "0x1F02FCC")]
	private void Start()
	{
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0x1F02FF4", Offset = "0x1F02FF4", VA = "0x1F02FF4")]
	public void CheckStars()
	{
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0x1F030D8", Offset = "0x1F030D8", VA = "0x1F030D8")]
	public void CheckArcadeCooking()
	{
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0x1F031B4", Offset = "0x1F031B4", VA = "0x1F031B4")]
	public void CheckArcadeSurvival()
	{
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0x1F032FC", Offset = "0x1F032FC", VA = "0x1F032FC")]
	public LockedSkinEnabler()
	{
	}
}
[Token(Token = "0x20000AF")]
public class MealPart : MonoBehaviour
{
	[Token(Token = "0x20000B0")]
	public enum Part
	{
		[Token(Token = "0x4000421")]
		Plate,
		[Token(Token = "0x4000422")]
		BottomBun,
		[Token(Token = "0x4000423")]
		Hamburger,
		[Token(Token = "0x4000424")]
		TopBun,
		[Token(Token = "0x4000425")]
		Skewer,
		[Token(Token = "0x4000426")]
		Snag,
		[Token(Token = "0x4000427")]
		Bread,
		[Token(Token = "0x4000428")]
		Vegemite,
		[Token(Token = "0x4000429")]
		Shrimp
	}

	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool stuck;

	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Part mealPart;

	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected HVRGrabbable grabbable;

	[Token(Token = "0x600047E")]
	[Address(RVA = "0x1F05F54", Offset = "0x1F05F54", VA = "0x1F05F54", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x600047F")]
	[Address(RVA = "0x1F06064", Offset = "0x1F06064", VA = "0x1F06064")]
	private void OnGrabbed(HVRGrabberBase _grabber, HVRGrabbable _grabbabble)
	{
	}

	[Token(Token = "0x6000480")]
	[Address(RVA = "0x1F060F0", Offset = "0x1F060F0", VA = "0x1F060F0")]
	public MealPart()
	{
	}
}
[Token(Token = "0x20000B1")]
public class PhotoCameraBehaviour : MonoBehaviour
{
	[Token(Token = "0x20000B2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA7DC", Offset = "0xAAA7DC")]
	private sealed class <FlashCoroutine>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PhotoCameraBehaviour <>4__this;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <quokasPre>5__2;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <_initialAlpha>5__3;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <_time>5__4;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <flashDecayTime>5__5;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <_alpha>5__6;

		[Token(Token = "0x170000DA")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x1FF77E8", Offset = "0x1FF77E8", VA = "0x1FF77E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DB")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x1FF7830", Offset = "0x1FF7830", VA = "0x1FF7830", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x1FF736C", Offset = "0x1FF736C", VA = "0x1FF736C")]
		[DebuggerHidden]
		public <FlashCoroutine>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x1FF7398", Offset = "0x1FF7398", VA = "0x1FF7398", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x1FF739C", Offset = "0x1FF739C", VA = "0x1FF739C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x1FF77F0", Offset = "0x1FF77F0", VA = "0x1FF77F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject flashCone;

	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioHandler audioHandler;

	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Collider flashCollider;

	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAAB6C8", Offset = "0xAAB6C8")]
	private Material flashMaterial;

	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool readyToFlash;

	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool flashDone;

	[Token(Token = "0x4000430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public HVRGrabbable grabbable;

	[Token(Token = "0x4000431")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public HVRHandGrabber hand;

	[Token(Token = "0x4000432")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private IEnumerator flash;

	[Token(Token = "0x6000481")]
	[Address(RVA = "0x1F0BA24", Offset = "0x1F0BA24", VA = "0x1F0BA24")]
	private void Start()
	{
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x1F0BC70", Offset = "0x1F0BC70", VA = "0x1F0BC70")]
	private void RegisterHandGrab(HVRGrabberBase _grabber, HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x1F0BCF0", Offset = "0x1F0BCF0", VA = "0x1F0BCF0")]
	private void UnregisterHandGrab(HVRGrabberBase _grabber, HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0x1F0BCFC", Offset = "0x1F0BCFC", VA = "0x1F0BCFC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0x1F0BC04", Offset = "0x1F0BC04", VA = "0x1F0BC04")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB1F9C", Offset = "0xAB1F9C")]
	private IEnumerator FlashCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0x1F0BE10", Offset = "0x1F0BE10", VA = "0x1F0BE10")]
	public PhotoCameraBehaviour()
	{
	}
}
[Token(Token = "0x20000B3")]
public class Radio : MonoBehaviour
{
	[Token(Token = "0x20000B4")]
	public enum Behavior
	{
		[Token(Token = "0x400044E")]
		Default,
		[Token(Token = "0x400044F")]
		Tutorial,
		[Token(Token = "0x4000450")]
		MainMenu,
		[Token(Token = "0x4000451")]
		Filming
	}

	[Token(Token = "0x20000B5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA7EC", Offset = "0xAAA7EC")]
	private sealed class <PlaySound>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Radio <>4__this;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string soundName;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject <particles>5__2;

		[Token(Token = "0x170000DC")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x22CBE10", Offset = "0x22CBE10", VA = "0x22CBE10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DD")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x22CBE58", Offset = "0x22CBE58", VA = "0x22CBE58", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x22CBBAC", Offset = "0x22CBBAC", VA = "0x22CBBAC")]
		[DebuggerHidden]
		public <PlaySound>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x22CBBD8", Offset = "0x22CBBD8", VA = "0x22CBBD8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x22CBBDC", Offset = "0x22CBBDC", VA = "0x22CBBDC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x22CBE18", Offset = "0x22CBE18", VA = "0x22CBE18", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA7FC", Offset = "0xAAA7FC")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float waitTimer;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool boomerangCaught;

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x22CAEEC", Offset = "0x22CAEEC", VA = "0x22CAEEC")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x22CAEF4", Offset = "0x22CAEF4", VA = "0x22CAEF4")]
		internal bool <TutorialBehavior>g__WaitForTimeOrCondition|0(bool condition)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x22CAF40", Offset = "0x22CAF40", VA = "0x22CAF40")]
		internal bool <TutorialBehavior>b__1()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x22CB024", Offset = "0x22CB024", VA = "0x22CB024")]
		internal void <TutorialBehavior>b__2(Boomerang _)
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x22CB030", Offset = "0x22CB030", VA = "0x22CB030")]
		internal bool <TutorialBehavior>b__3()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000B7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA80C", Offset = "0xAAA80C")]
	private sealed class <TutorialBehavior>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Radio <>4__this;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private <>c__DisplayClass24_0 <>8__1;

		[Token(Token = "0x170000DE")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x22CC598", Offset = "0x22CC598", VA = "0x22CC598", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DF")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x22CC5E0", Offset = "0x22CC5E0", VA = "0x22CC5E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x22CBE60", Offset = "0x22CBE60", VA = "0x22CBE60")]
		[DebuggerHidden]
		public <TutorialBehavior>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x22CBE8C", Offset = "0x22CBE8C", VA = "0x22CBE8C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x22CBE90", Offset = "0x22CBE90", VA = "0x22CBE90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x22CC5A0", Offset = "0x22CC5A0", VA = "0x22CC5A0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA81C", Offset = "0xAAA81C")]
	private sealed class <ObjectivesBehavior>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Radio <>4__this;

		[Token(Token = "0x170000E0")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x22CBB5C", Offset = "0x22CBB5C", VA = "0x22CBB5C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E1")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x22CBBA4", Offset = "0x22CBBA4", VA = "0x22CBBA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x22CB9AC", Offset = "0x22CB9AC", VA = "0x22CB9AC")]
		[DebuggerHidden]
		public <ObjectivesBehavior>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x22CB9D8", Offset = "0x22CB9D8", VA = "0x22CB9D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x22CB9DC", Offset = "0x22CB9DC", VA = "0x22CB9DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x22CBB64", Offset = "0x22CBB64", VA = "0x22CBB64", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA82C", Offset = "0xAAA82C")]
	private sealed class <FilmingBehavior>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Radio <>4__this;

		[Token(Token = "0x170000E2")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x22CB95C", Offset = "0x22CB95C", VA = "0x22CB95C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E3")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x22CB9A4", Offset = "0x22CB9A4", VA = "0x22CB9A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x22CB748", Offset = "0x22CB748", VA = "0x22CB748")]
		[DebuggerHidden]
		public <FilmingBehavior>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x22CB774", Offset = "0x22CB774", VA = "0x22CB774", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x22CB778", Offset = "0x22CB778", VA = "0x22CB778", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x22CB964", Offset = "0x22CB964", VA = "0x22CB964", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000BA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA83C", Offset = "0xAAA83C")]
	private sealed class <DefaultBehavior>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Radio <>4__this;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float delay;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool playStaticOnStart;

		[Token(Token = "0x170000E4")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x22CB6F8", Offset = "0x22CB6F8", VA = "0x22CB6F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E5")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x22CB740", Offset = "0x22CB740", VA = "0x22CB740", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x22CB098", Offset = "0x22CB098", VA = "0x22CB098")]
		[DebuggerHidden]
		public <DefaultBehavior>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x22CB0C4", Offset = "0x22CB0C4", VA = "0x22CB0C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x22CB0C8", Offset = "0x22CB0C8", VA = "0x22CB0C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x22CB700", Offset = "0x22CB700", VA = "0x22CB700", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000BB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA84C", Offset = "0xAAA84C")]
	private sealed class <>c__DisplayClass28_0
	{
		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int n;

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x22CB080", Offset = "0x22CB080", VA = "0x22CB080")]
		public <>c__DisplayClass28_0()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x22CB088", Offset = "0x22CB088", VA = "0x22CB088")]
		internal int <RestartCounters>b__1(int x)
		{
			return default(int);
		}
	}

	[Token(Token = "0x400043B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float timeUntilStart;

	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float timeBetweenNews;

	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject staticParticles;

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject playParticles;

	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AudioHandler audioHandler;

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float minDistanceAudioSources;

	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float maxDistanceAudioSources;

	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int numberOfNewsIntro;

	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int numberOfNews;

	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int numberOfNewsOutro;

	[Token(Token = "0x4000445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string playingSound;

	[Token(Token = "0x4000446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<int> newsIntroOrder;

	[Token(Token = "0x4000447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<int> newsOrder;

	[Token(Token = "0x4000448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private List<int> newsOutroOrder;

	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int newsIntroCounter;

	[Token(Token = "0x400044A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int newsCounter;

	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int newsOutroCounter;

	[Token(Token = "0x400044C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public Behavior startBehavior;

	[Token(Token = "0x600048D")]
	[Address(RVA = "0x1F10EC8", Offset = "0x1F10EC8", VA = "0x1F10EC8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600048E")]
	[Address(RVA = "0x1F11168", Offset = "0x1F11168", VA = "0x1F11168")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600048F")]
	[Address(RVA = "0x1F11230", Offset = "0x1F11230", VA = "0x1F11230")]
	private void Start()
	{
	}

	[Token(Token = "0x6000490")]
	[Address(RVA = "0x1F11234", Offset = "0x1F11234", VA = "0x1F11234")]
	private void UpdateSourcesMinMaxDistances()
	{
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0x1F112D4", Offset = "0x1F112D4", VA = "0x1F112D4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB204C", Offset = "0xAB204C")]
	private IEnumerator PlaySound(string soundName)
	{
		return null;
	}

	[Token(Token = "0x6000492")]
	[Address(RVA = "0x1F10F94", Offset = "0x1F10F94", VA = "0x1F10F94")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB20AC", Offset = "0xAB20AC")]
	private IEnumerator TutorialBehavior()
	{
		return null;
	}

	[Token(Token = "0x6000493")]
	[Address(RVA = "0x1F11000", Offset = "0x1F11000", VA = "0x1F11000")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB210C", Offset = "0xAB210C")]
	private IEnumerator ObjectivesBehavior()
	{
		return null;
	}

	[Token(Token = "0x6000494")]
	[Address(RVA = "0x1F1106C", Offset = "0x1F1106C", VA = "0x1F1106C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB216C", Offset = "0xAB216C")]
	private IEnumerator FilmingBehavior()
	{
		return null;
	}

	[Token(Token = "0x6000495")]
	[Address(RVA = "0x1F110D8", Offset = "0x1F110D8", VA = "0x1F110D8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB21CC", Offset = "0xAB21CC")]
	private IEnumerator DefaultBehavior(float delay, bool playStaticOnStart = false)
	{
		return null;
	}

	[Token(Token = "0x6000496")]
	[Address(RVA = "0x1F10F44", Offset = "0x1F10F44", VA = "0x1F10F44")]
	private void RestartCounters()
	{
	}

	[Token(Token = "0x6000497")]
	[Address(RVA = "0x1F1116C", Offset = "0x1F1116C", VA = "0x1F1116C")]
	public void StopRadio()
	{
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0x1F11464", Offset = "0x1F11464", VA = "0x1F11464")]
	public void RestartRadio()
	{
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0x1F11498", Offset = "0x1F11498", VA = "0x1F11498")]
	public Radio()
	{
	}

	[Token(Token = "0x600049A")]
	[Address(RVA = "0x1F1134C", Offset = "0x1F1134C", VA = "0x1F1134C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB222C", Offset = "0xAB222C")]
	internal static List<int> <RestartCounters>g__GetRandomOrder|28_0(int n)
	{
		return null;
	}
}
[Token(Token = "0x20000BC")]
public class ShrimpFoodAction : FoodAction
{
	[Token(Token = "0x20000BD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA85C", Offset = "0xAAA85C")]
	private sealed class <LockAfterWaiting>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ShrimpFoodAction <>4__this;

		[Token(Token = "0x170000E6")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x22CE98C", Offset = "0x22CE98C", VA = "0x22CE98C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E7")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x22CE9D4", Offset = "0x22CE9D4", VA = "0x22CE9D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x22CE8B4", Offset = "0x22CE8B4", VA = "0x22CE8B4")]
		[DebuggerHidden]
		public <LockAfterWaiting>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x22CE8E0", Offset = "0x22CE8E0", VA = "0x22CE8E0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x22CE8E4", Offset = "0x22CE8E4", VA = "0x22CE8E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x22CE994", Offset = "0x22CE994", VA = "0x22CE994", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private HVRStabbable stababble;

	[Token(Token = "0x400046A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private HVRGrabbable grabbable;

	[Token(Token = "0x400046B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private HVRStabber stabber;

	[Token(Token = "0x400046C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Rigidbody rb;

	[Token(Token = "0x400046D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Collider[] _colliders;

	[Token(Token = "0x400046E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private int layerDefault;

	[Token(Token = "0x400046F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private int layerDontCollideWithPlayer;

	[Token(Token = "0x60004C0")]
	[Address(RVA = "0x1F171E4", Offset = "0x1F171E4", VA = "0x1F171E4", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60004C1")]
	[Address(RVA = "0x1F17460", Offset = "0x1F17460", VA = "0x1F17460")]
	private void Lock()
	{
	}

	[Token(Token = "0x60004C2")]
	[Address(RVA = "0x1F1763C", Offset = "0x1F1763C", VA = "0x1F1763C")]
	private void Lock(HVRGrabberBase arg0, HVRGrabbable arg1)
	{
	}

	[Token(Token = "0x60004C3")]
	[Address(RVA = "0x1F17640", Offset = "0x1F17640", VA = "0x1F17640")]
	private void OnStab(HVRStabber arg0, HVRStabbable arg1, Collision arg2)
	{
	}

	[Token(Token = "0x60004C4")]
	[Address(RVA = "0x1F17838", Offset = "0x1F17838", VA = "0x1F17838")]
	private void OnUnstab(HVRStabber arg0, HVRStabbable arg1)
	{
	}

	[Token(Token = "0x60004C5")]
	[Address(RVA = "0x1F177CC", Offset = "0x1F177CC", VA = "0x1F177CC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB23CC", Offset = "0xAB23CC")]
	private IEnumerator LockAfterWaiting()
	{
		return null;
	}

	[Token(Token = "0x60004C6")]
	[Address(RVA = "0x1F17844", Offset = "0x1F17844", VA = "0x1F17844")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60004C7")]
	[Address(RVA = "0x1F17930", Offset = "0x1F17930", VA = "0x1F17930")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60004C8")]
	[Address(RVA = "0x1F17A1C", Offset = "0x1F17A1C", VA = "0x1F17A1C")]
	public void SetCollisionDetection(bool active)
	{
	}

	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x1F17A3C", Offset = "0x1F17A3C", VA = "0x1F17A3C")]
	public Collider[] GetColliders()
	{
		return null;
	}

	[Token(Token = "0x60004CA")]
	[Address(RVA = "0x1F176A0", Offset = "0x1F176A0", VA = "0x1F176A0")]
	private void ToggleCollisionLayer(bool collideWithPlayer)
	{
	}

	[Token(Token = "0x60004CB")]
	[Address(RVA = "0x1F17A98", Offset = "0x1F17A98", VA = "0x1F17A98")]
	public ShrimpFoodAction()
	{
	}
}
[Token(Token = "0x20000BE")]
public class SnagFoodAction : FoodAction
{
	[Token(Token = "0x4000473")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Collider currentGrill;

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x1F17E8C", Offset = "0x1F17E8C", VA = "0x1F17E8C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0x1F17F7C", Offset = "0x1F17F7C", VA = "0x1F17F7C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60004D4")]
	[Address(RVA = "0x1F18010", Offset = "0x1F18010", VA = "0x1F18010")]
	public void StopGrilling()
	{
	}

	[Token(Token = "0x60004D5")]
	[Address(RVA = "0x1F180CC", Offset = "0x1F180CC", VA = "0x1F180CC")]
	public SnagFoodAction()
	{
	}
}
[Token(Token = "0x20000BF")]
public class SnagMealPart : MealPart
{
	[Token(Token = "0x4000474")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject ketchup;

	[Token(Token = "0x4000475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject mustard;

	[Token(Token = "0x4000476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool isKetchuped;

	[Token(Token = "0x4000477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool isMustarded;

	[Token(Token = "0x4000478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private AudioHandler audioHandler;

	[Token(Token = "0x4000479")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public CapsuleCollider snagCollider;

	[Token(Token = "0x60004D6")]
	[Address(RVA = "0x1F180D4", Offset = "0x1F180D4", VA = "0x1F180D4")]
	private new void Start()
	{
	}

	[Token(Token = "0x60004D7")]
	[Address(RVA = "0x1F18130", Offset = "0x1F18130", VA = "0x1F18130")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x60004D8")]
	[Address(RVA = "0x1F18230", Offset = "0x1F18230", VA = "0x1F18230")]
	public void ShortenSnagColider()
	{
	}

	[Token(Token = "0x60004D9")]
	[Address(RVA = "0x1F18270", Offset = "0x1F18270", VA = "0x1F18270")]
	public void RestoreSnagCollider()
	{
	}

	[Token(Token = "0x60004DA")]
	[Address(RVA = "0x1F182B4", Offset = "0x1F182B4", VA = "0x1F182B4")]
	public SnagMealPart()
	{
	}
}
[Token(Token = "0x20000C0")]
public class SpawnWhenHit : MonoBehaviour
{
	[Token(Token = "0x20000C1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA86C", Offset = "0xAAA86C")]
	private sealed class <InstantiateWithModeration>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpawnWhenHit <>4__this;

		[Token(Token = "0x170000E8")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x22CEDEC", Offset = "0x22CEDEC", VA = "0x22CEDEC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E9")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x22CEE34", Offset = "0x22CEE34", VA = "0x22CEE34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x22CEBFC", Offset = "0x22CEBFC", VA = "0x22CEBFC")]
		[DebuggerHidden]
		public <InstantiateWithModeration>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x22CEC28", Offset = "0x22CEC28", VA = "0x22CEC28", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x22CEC2C", Offset = "0x22CEC2C", VA = "0x22CEC2C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x22CEDF4", Offset = "0x22CEDF4", VA = "0x22CEDF4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform pointToSpawn;

	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject vegetarianOption;

	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject meatOption;

	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject objectToSpawn;

	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int maxObjects;

	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<GameObject> objectList;

	[Token(Token = "0x4000480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool readyToInstantiate;

	[Token(Token = "0x60004DB")]
	[Address(RVA = "0x1F18314", Offset = "0x1F18314", VA = "0x1F18314")]
	private void Start()
	{
	}

	[Token(Token = "0x60004DC")]
	[Address(RVA = "0x1F183BC", Offset = "0x1F183BC", VA = "0x1F183BC")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60004DD")]
	[Address(RVA = "0x1F1848C", Offset = "0x1F1848C", VA = "0x1F1848C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB247C", Offset = "0xAB247C")]
	private IEnumerator InstantiateWithModeration()
	{
		return null;
	}

	[Token(Token = "0x60004DE")]
	[Address(RVA = "0x1F184F8", Offset = "0x1F184F8", VA = "0x1F184F8")]
	private void DestroyFunction(GameObject _objectToDestroy)
	{
	}

	[Token(Token = "0x60004DF")]
	[Address(RVA = "0x1F1855C", Offset = "0x1F1855C", VA = "0x1F1855C")]
	public SpawnWhenHit()
	{
	}
}
[Token(Token = "0x20000C2")]
public class StickStabChecker : MonoBehaviour
{
	[Token(Token = "0x20000C3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA87C", Offset = "0xAAA87C")]
	private sealed class <DelayedGoToHell>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x170000EA")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x22CEFE4", Offset = "0x22CEFE4", VA = "0x22CEFE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EB")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x22CF02C", Offset = "0x22CF02C", VA = "0x22CF02C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x22CEE3C", Offset = "0x22CEE3C", VA = "0x22CEE3C")]
		[DebuggerHidden]
		public <DelayedGoToHell>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x22CEE68", Offset = "0x22CEE68", VA = "0x22CEE68", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x22CEE6C", Offset = "0x22CEE6C", VA = "0x22CEE6C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x22CEFEC", Offset = "0x22CEFEC", VA = "0x22CEFEC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000484")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public HVRStabber stabber;

	[Token(Token = "0x60004E6")]
	[Address(RVA = "0x1F189A8", Offset = "0x1F189A8", VA = "0x1F189A8")]
	private void Start()
	{
	}

	[Token(Token = "0x60004E7")]
	[Address(RVA = "0x1F18A8C", Offset = "0x1F18A8C", VA = "0x1F18A8C")]
	private void CheckStab(HVRStabber arg0, HVRStabbable _stabbable, Collision arg2)
	{
	}

	[Token(Token = "0x60004E8")]
	[Address(RVA = "0x1F18CC0", Offset = "0x1F18CC0", VA = "0x1F18CC0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB252C", Offset = "0xAB252C")]
	private IEnumerator DelayedGoToHell()
	{
		return null;
	}

	[Token(Token = "0x60004E9")]
	[Address(RVA = "0x1F18D1C", Offset = "0x1F18D1C", VA = "0x1F18D1C")]
	public StickStabChecker()
	{
	}
}
[Token(Token = "0x20000C4")]
public class TreeBehaviour : MonoBehaviour
{
	[Token(Token = "0x4000487")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioHandler audioHandler;

	[Token(Token = "0x4000488")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject LeftParticles;

	[Token(Token = "0x60004F0")]
	[Address(RVA = "0x1F3F3A4", Offset = "0x1F3F3A4", VA = "0x1F3F3A4")]
	private void Start()
	{
	}

	[Token(Token = "0x60004F1")]
	[Address(RVA = "0x1F3F3F8", Offset = "0x1F3F3F8", VA = "0x1F3F3F8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60004F2")]
	[Address(RVA = "0x1F3F608", Offset = "0x1F3F608", VA = "0x1F3F608")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60004F3")]
	[Address(RVA = "0x1F3F488", Offset = "0x1F3F488", VA = "0x1F3F488")]
	private void EmitLeaves(Transform _transform)
	{
	}

	[Token(Token = "0x60004F4")]
	[Address(RVA = "0x1F3F698", Offset = "0x1F3F698", VA = "0x1F3F698")]
	public TreeBehaviour()
	{
	}
}
[Token(Token = "0x20000C5")]
public class AchievementsHandler : Singleton<AchievementsHandler>
{
	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x1E9FDF0", Offset = "0x1E9FDF0", VA = "0x1E9FDF0", Slot = "6")]
	public virtual void AwardAchievement(string achievementID)
	{
	}

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x1E9FE98", Offset = "0x1E9FE98", VA = "0x1E9FE98")]
	public AchievementsHandler()
	{
	}
}
[Token(Token = "0x20000C6")]
public class Leaderboard : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000C7")]
	public class Score
	{
		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string playerName;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D playerSignature;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int score;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int rank;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isCurrentPlayer;

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1FF08BC", Offset = "0x1FF08BC", VA = "0x1FF08BC")]
		public Score(string _playerName, int _score, int _rank = 0, bool _isCurrentPlayer = false, [Optional] Texture2D _playerSignature)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20000C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA88C", Offset = "0xAAA88C")]
	private sealed class <>c
	{
		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<Score> <>9__6_0;

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1FF0474", Offset = "0x1FF0474", VA = "0x1FF0474")]
		public <>c()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1FF047C", Offset = "0x1FF047C", VA = "0x1FF047C")]
		internal int <OrderAndFillIn>b__6_0(Score a, Score b)
		{
			return default(int);
		}
	}

	[Token(Token = "0x20000C9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA89C", Offset = "0xAAA89C")]
	private sealed class <FillInTable>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Leaderboard <>4__this;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float delay;

		[Token(Token = "0x170000EC")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000507")]
			[Address(RVA = "0x1FF086C", Offset = "0x1FF086C", VA = "0x1FF086C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000ED")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x1FF08B4", Offset = "0x1FF08B4", VA = "0x1FF08B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x1FF04A8", Offset = "0x1FF04A8", VA = "0x1FF04A8")]
		[DebuggerHidden]
		public <FillInTable>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x1FF04D4", Offset = "0x1FF04D4", VA = "0x1FF04D4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x1FF04D8", Offset = "0x1FF04D8", VA = "0x1FF04D8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x1FF0874", Offset = "0x1FF0874", VA = "0x1FF0874", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000489")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public ScorePlace[] scorePlaces;

	[Token(Token = "0x400048A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ScoreType scoreType;

	[Token(Token = "0x400048B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Score> display_scores;

	[Token(Token = "0x400048C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Animator animator;

	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x1F2A90C", Offset = "0x1F2A90C", VA = "0x1F2A90C", Slot = "4")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x60004F8")]
	[Address(RVA = "0x1F2AA74", Offset = "0x1F2AA74", VA = "0x1F2AA74")]
	public void OrderAndFillIn(List<Score> scores)
	{
	}

	[Token(Token = "0x60004F9")]
	[Address(RVA = "0x1F2AC54", Offset = "0x1F2AC54", VA = "0x1F2AC54", Slot = "5")]
	public virtual void ClearLeaderboard()
	{
	}

	[Token(Token = "0x60004FA")]
	[Address(RVA = "0x1F2ABAC", Offset = "0x1F2ABAC", VA = "0x1F2ABAC")]
	public void FillIn(List<Score> scores)
	{
	}

	[Token(Token = "0x60004FB")]
	[Address(RVA = "0x1F2ACD0", Offset = "0x1F2ACD0", VA = "0x1F2ACD0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB25DC", Offset = "0xAB25DC")]
	private IEnumerator FillInTable(float delay)
	{
		return null;
	}

	[Token(Token = "0x60004FC")]
	[Address(RVA = "0x1F2AD4C", Offset = "0x1F2AD4C", VA = "0x1F2AD4C")]
	private string FormatScore(int _score)
	{
		return null;
	}

	[Token(Token = "0x60004FD")]
	[Address(RVA = "0x1F2A930", Offset = "0x1F2A930", VA = "0x1F2A930")]
	public Animator GetAnimator()
	{
		return null;
	}

	[Token(Token = "0x60004FE")]
	[Address(RVA = "0x1F2AA10", Offset = "0x1F2AA10", VA = "0x1F2AA10")]
	public ScorePlace[] GetScorePlaces()
	{
		return null;
	}

	[Token(Token = "0x60004FF")]
	[Address(RVA = "0x1F2AE14", Offset = "0x1F2AE14", VA = "0x1F2AE14")]
	public Leaderboard()
	{
	}
}
[Token(Token = "0x20000CA")]
public class LocalLeaderboard : Leaderboard
{
	[Token(Token = "0x20000CB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA8AC", Offset = "0xAAA8AC")]
	private sealed class <WaitGettingScoresAgain>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocalLeaderboard <>4__this;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ArcadeMode _mode;

		[Token(Token = "0x170000EE")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000514")]
			[Address(RVA = "0x1FF3190", Offset = "0x1FF3190", VA = "0x1FF3190", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EF")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x1FF31D8", Offset = "0x1FF31D8", VA = "0x1FF31D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1FF2FBC", Offset = "0x1FF2FBC", VA = "0x1FF2FBC")]
		[DebuggerHidden]
		public <WaitGettingScoresAgain>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1FF2FE8", Offset = "0x1FF2FE8", VA = "0x1FF2FE8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x1FF2FEC", Offset = "0x1FF2FEC", VA = "0x1FF2FEC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x1FF3198", Offset = "0x1FF3198", VA = "0x1FF3198", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000498")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<ArcadeMode, List<Score>> arcadeScoresCache;

	[Token(Token = "0x4000499")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int retryCount;

	[Token(Token = "0x400049A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int maxRetries;

	[Token(Token = "0x600050A")]
	[Address(RVA = "0x1F2D42C", Offset = "0x1F2D42C", VA = "0x1F2D42C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600050B")]
	[Address(RVA = "0x1F2D430", Offset = "0x1F2D430", VA = "0x1F2D430")]
	public void Setup()
	{
	}

	[Token(Token = "0x600050C")]
	[Address(RVA = "0x1F2D59C", Offset = "0x1F2D59C", VA = "0x1F2D59C")]
	private List<Score> TranslateIntoLeaderboardScores(List<SavedData.ArcadeScore> savedScores)
	{
		return null;
	}

	[Token(Token = "0x600050D")]
	[Address(RVA = "0x1F2D8FC", Offset = "0x1F2D8FC", VA = "0x1F2D8FC")]
	public void ChangeLeaderboardMode(ArcadeMode _mode)
	{
	}

	[Token(Token = "0x600050E")]
	[Address(RVA = "0x1F2DA84", Offset = "0x1F2DA84", VA = "0x1F2DA84")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB268C", Offset = "0xAB268C")]
	private IEnumerator WaitGettingScoresAgain(ArcadeMode _mode)
	{
		return null;
	}

	[Token(Token = "0x600050F")]
	[Address(RVA = "0x1F2DB00", Offset = "0x1F2DB00", VA = "0x1F2DB00")]
	public bool TemporarilyAddNewScore(ArcadeMode _mode, int _score)
	{
		return default(bool);
	}

	[Token(Token = "0x6000510")]
	[Address(RVA = "0x1F2DC8C", Offset = "0x1F2DC8C", VA = "0x1F2DC8C")]
	public LocalLeaderboard()
	{
	}
}
[Token(Token = "0x20000CC")]
public class OculusAchievementsHandler : AchievementsHandler
{
	[Token(Token = "0x20000CD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA8BC", Offset = "0xAAA8BC")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string achievementID;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public OculusAchievementsHandler <>4__this;

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1FF63BC", Offset = "0x1FF63BC", VA = "0x1FF63BC")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1FF63C4", Offset = "0x1FF63C4", VA = "0x1FF63C4")]
		internal void <UnlockAchievement>b__0(Message<AchievementUpdate> msg)
		{
		}
	}

	[Token(Token = "0x400049F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int maxRetryCounts;

	[Token(Token = "0x40004A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<string, int> achivementRetries;

	[Token(Token = "0x40004A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<string> backupAchievementQueue;

	[Token(Token = "0x40004A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private HashSet<string> achivementsAwarded;

	[Token(Token = "0x6000517")]
	[Address(RVA = "0x1F09468", Offset = "0x1F09468", VA = "0x1F09468", Slot = "6")]
	public override void AwardAchievement(string achievementID)
	{
	}

	[Token(Token = "0x6000518")]
	[Address(RVA = "0x1F0946C", Offset = "0x1F0946C", VA = "0x1F0946C")]
	private void UnlockAchievement(string achievementID)
	{
	}

	[Token(Token = "0x6000519")]
	[Address(RVA = "0x1F09620", Offset = "0x1F09620", VA = "0x1F09620")]
	public OculusAchievementsHandler()
	{
	}
}
[Token(Token = "0x20000CE")]
public class OculusInitializer : Singleton<OculusInitializer>
{
	[Token(Token = "0x40004A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool initialized;

	[Token(Token = "0x40004A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool error;

	[Token(Token = "0x40004A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ulong userID;

	[Token(Token = "0x600051C")]
	[Address(RVA = "0x1F09720", Offset = "0x1F09720", VA = "0x1F09720")]
	private void Start()
	{
	}

	[Token(Token = "0x600051D")]
	[Address(RVA = "0x1F099C4", Offset = "0x1F099C4", VA = "0x1F099C4")]
	private void InitializeCallback(Message msg)
	{
	}

	[Token(Token = "0x600051E")]
	[Address(RVA = "0x1F09B1C", Offset = "0x1F09B1C", VA = "0x1F09B1C")]
	private void EntitlementCallback(Message msg)
	{
	}

	[Token(Token = "0x600051F")]
	[Address(RVA = "0x1F09C60", Offset = "0x1F09C60", VA = "0x1F09C60")]
	private void SetUserID(Message<User> msg)
	{
	}

	[Token(Token = "0x6000520")]
	[Address(RVA = "0x1F098AC", Offset = "0x1F098AC", VA = "0x1F098AC")]
	private void QuitApplication([Optional] UnityException e)
	{
	}

	[Token(Token = "0x6000521")]
	[Address(RVA = "0x1F09D7C", Offset = "0x1F09D7C", VA = "0x1F09D7C")]
	public OculusInitializer()
	{
	}
}
[Token(Token = "0x20000CF")]
public class OculusOnlineLeaderboardHandler : OnlineLeaderboardHandler
{
	[Token(Token = "0x20000D0")]
	public class OculusLeaderboard
	{
		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string leaderboardName;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Events.EventLeaderboardUpdated updateEvent;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private OnlineLeaderboardType rankType;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int scoreCount;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ulong UserId;

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1FF6B24", Offset = "0x1FF6B24", VA = "0x1FF6B24")]
		public OculusLeaderboard(string _name, Events.EventLeaderboardUpdated _event, ulong _userID)
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1FF697C", Offset = "0x1FF697C", VA = "0x1FF697C")]
		public void GetLeaderboardData(OnlineLeaderboardType _method = OnlineLeaderboardType.NONE)
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1FF6B6C", Offset = "0x1FF6B6C", VA = "0x1FF6B6C")]
		public void GetLeaderboardDataCallback(Message<LeaderboardEntryList> msg)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1FF6FE8", Offset = "0x1FF6FE8", VA = "0x1FF6FE8", Slot = "4")]
		public virtual void SubmitScore(int _score)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1FF70DC", Offset = "0x1FF70DC", VA = "0x1FF70DC")]
		public void OnSubmitScore(Message<bool> msg)
		{
		}
	}

	[Token(Token = "0x20000D1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA8CC", Offset = "0xAAA8CC")]
	private sealed class <WaitAndDownloadLeaderboard>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string key;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OculusOnlineLeaderboardHandler <>4__this;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public OnlineLeaderboardType method;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <max_tries>5__2;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <current_try>5__3;

		[Token(Token = "0x170000F0")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x1FF6AD4", Offset = "0x1FF6AD4", VA = "0x1FF6AD4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F1")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x1FF6B1C", Offset = "0x1FF6B1C", VA = "0x1FF6B1C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x1FF6660", Offset = "0x1FF6660", VA = "0x1FF6660")]
		[DebuggerHidden]
		public <WaitAndDownloadLeaderboard>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x1FF668C", Offset = "0x1FF668C", VA = "0x1FF668C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x1FF6690", Offset = "0x1FF6690", VA = "0x1FF6690", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x1FF6ADC", Offset = "0x1FF6ADC", VA = "0x1FF6ADC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000D2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA8DC", Offset = "0xAAA8DC")]
	private sealed class <RetrySubmitScore>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OculusOnlineLeaderboardHandler <>4__this;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string key;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int score;

		[Token(Token = "0x170000F2")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000536")]
			[Address(RVA = "0x1FF6610", Offset = "0x1FF6610", VA = "0x1FF6610", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F3")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000538")]
			[Address(RVA = "0x1FF6658", Offset = "0x1FF6658", VA = "0x1FF6658", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x1FF6520", Offset = "0x1FF6520", VA = "0x1FF6520")]
		[DebuggerHidden]
		public <RetrySubmitScore>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x1FF654C", Offset = "0x1FF654C", VA = "0x1FF654C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x1FF6550", Offset = "0x1FF6550", VA = "0x1FF6550", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1FF6618", Offset = "0x1FF6618", VA = "0x1FF6618", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Dictionary<string, OculusLeaderboard> leaderboards;

	[Token(Token = "0x40004A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int retryAttempts;

	[Token(Token = "0x40004AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool error;

	[Token(Token = "0x6000522")]
	[Address(RVA = "0x1F09DC8", Offset = "0x1F09DC8", VA = "0x1F09DC8", Slot = "6")]
	public override void Start()
	{
	}

	[Token(Token = "0x6000523")]
	[Address(RVA = "0x1F0A444", Offset = "0x1F0A444", VA = "0x1F0A444", Slot = "7")]
	public override void UpdateLeaderboard(string key, OnlineLeaderboardType method)
	{
	}

	[Token(Token = "0x6000524")]
	[Address(RVA = "0x1F0A470", Offset = "0x1F0A470", VA = "0x1F0A470")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB273C", Offset = "0xAB273C")]
	private IEnumerator WaitAndDownloadLeaderboard(string key, OnlineLeaderboardType method)
	{
		return null;
	}

	[Token(Token = "0x6000525")]
	[Address(RVA = "0x1F0A4F0", Offset = "0x1F0A4F0", VA = "0x1F0A4F0", Slot = "9")]
	public override void SubmitScore(string key, int score)
	{
	}

	[Token(Token = "0x6000526")]
	[Address(RVA = "0x1F0A698", Offset = "0x1F0A698", VA = "0x1F0A698")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB279C", Offset = "0xAB279C")]
	private IEnumerator RetrySubmitScore(string key, int score)
	{
		return null;
	}

	[Token(Token = "0x6000527")]
	[Address(RVA = "0x1F0A718", Offset = "0x1F0A718", VA = "0x1F0A718")]
	public OculusOnlineLeaderboardHandler()
	{
	}
}
[Token(Token = "0x20000D3")]
public class OnlineLeaderboard : Leaderboard
{
	[Token(Token = "0x40004BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<string> leaderboardKeys;

	[Token(Token = "0x40004BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int rankTypeIndex;

	[Token(Token = "0x40004BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public OnlineLeaderboardType[] availableTypes;

	[Token(Token = "0x40004BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Sprite[] rankIcons;

	[Token(Token = "0x40004C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string currentKey;

	[Token(Token = "0x40004C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Image rankTypeIcon;

	[Token(Token = "0x40004C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool setEvents;

	[Token(Token = "0x40004C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool toggleOnEmptyStart;

	[Token(Token = "0x6000539")]
	[Address(RVA = "0x1F0A83C", Offset = "0x1F0A83C", VA = "0x1F0A83C")]
	public void UpdateLeaderboard(List<Score> _scores)
	{
	}

	[Token(Token = "0x600053A")]
	[Address(RVA = "0x1F04338", Offset = "0x1F04338", VA = "0x1F04338")]
	public void UpdateLeaderboardMode(string key)
	{
	}

	[Token(Token = "0x600053B")]
	[Address(RVA = "0x1F0A9BC", Offset = "0x1F0A9BC", VA = "0x1F0A9BC")]
	public void ToggleLeaderboardListType()
	{
	}

	[Token(Token = "0x600053C")]
	[Address(RVA = "0x1F0AB18", Offset = "0x1F0AB18", VA = "0x1F0AB18")]
	public void EnableLeaderboard()
	{
	}

	[Token(Token = "0x600053D")]
	[Address(RVA = "0x1F04518", Offset = "0x1F04518", VA = "0x1F04518")]
	public void DisableLeaderboard()
	{
	}

	[Token(Token = "0x600053E")]
	[Address(RVA = "0x1F0AB70", Offset = "0x1F0AB70", VA = "0x1F0AB70")]
	private void SetEvents()
	{
	}

	[Token(Token = "0x600053F")]
	[Address(RVA = "0x1F0AF18", Offset = "0x1F0AF18", VA = "0x1F0AF18")]
	public OnlineLeaderboard()
	{
	}
}
[Token(Token = "0x20000D4")]
public class OnlineLeaderboardHandler : Singleton<OnlineLeaderboardHandler>
{
	[Token(Token = "0x40004C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public string DEFENSE_LEADERBOARD_NAME;

	[Token(Token = "0x40004C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public string COOKING_LEADERBOARD_NAME;

	[Token(Token = "0x40004C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public string FASTEST_LEVEL_LEADERBOARD_NAME;

	[Token(Token = "0x40004C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Dictionary<string, string> leaderboardNames;

	[Token(Token = "0x40004C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public Dictionary<string, Events.EventLeaderboardUpdated> leaderboardEvents;

	[Token(Token = "0x6000540")]
	[Address(RVA = "0x1F0A0A0", Offset = "0x1F0A0A0", VA = "0x1F0A0A0", Slot = "6")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x6000541")]
	[Address(RVA = "0x1F0AF98", Offset = "0x1F0AF98", VA = "0x1F0AF98", Slot = "7")]
	public virtual void UpdateLeaderboard(string key, OnlineLeaderboardType method)
	{
	}

	[Token(Token = "0x6000542")]
	[Address(RVA = "0x1F0B00C", Offset = "0x1F0B00C", VA = "0x1F0B00C", Slot = "8")]
	public virtual void UpdateLeaderboard(ArcadeMode mode, OnlineLeaderboardType method)
	{
	}

	[Token(Token = "0x6000543")]
	[Address(RVA = "0x1F0B0B8", Offset = "0x1F0B0B8", VA = "0x1F0B0B8", Slot = "9")]
	public virtual void SubmitScore(string key, int score)
	{
	}

	[Token(Token = "0x6000544")]
	[Address(RVA = "0x1F0B12C", Offset = "0x1F0B12C", VA = "0x1F0B12C", Slot = "10")]
	public virtual void SubmitScore(ArcadeMode mode, int score)
	{
	}

	[Token(Token = "0x6000545")]
	[Address(RVA = "0x1F0A71C", Offset = "0x1F0A71C", VA = "0x1F0A71C")]
	public OnlineLeaderboardHandler()
	{
	}
}
[Token(Token = "0x20000D5")]
public class PicoAchievementsHandler : AchievementsHandler
{
	[Token(Token = "0x6000546")]
	[Address(RVA = "0x1F0BEE0", Offset = "0x1F0BEE0", VA = "0x1F0BEE0")]
	public PicoAchievementsHandler()
	{
	}
}
[Token(Token = "0x20000D6")]
public class PicoInitializer : Singleton<PicoInitializer>
{
	[Token(Token = "0x40004C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool initialized;

	[Token(Token = "0x40004CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool error;

	[Token(Token = "0x40004CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string userID;

	[Token(Token = "0x6000547")]
	[Address(RVA = "0x1F0BEE8", Offset = "0x1F0BEE8", VA = "0x1F0BEE8")]
	public PicoInitializer()
	{
	}
}
[Token(Token = "0x20000D7")]
public class PicoOnlineLeaderboardHandler : OnlineLeaderboardHandler
{
	[Token(Token = "0x6000548")]
	[Address(RVA = "0x1F0BF34", Offset = "0x1F0BF34", VA = "0x1F0BF34")]
	public PicoOnlineLeaderboardHandler()
	{
	}
}
[Token(Token = "0x20000D8")]
public class ScorePlace : MonoBehaviour
{
	[Token(Token = "0x20000D9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA8EC", Offset = "0xAAA8EC")]
	private sealed class <CopyTexture>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ScorePlace <>4__this;

		[Token(Token = "0x170000F4")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000554")]
			[Address(RVA = "0x22CE864", Offset = "0x22CE864", VA = "0x22CE864", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F5")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000556")]
			[Address(RVA = "0x22CE8AC", Offset = "0x22CE8AC", VA = "0x22CE8AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x22CE6FC", Offset = "0x22CE6FC", VA = "0x22CE6FC")]
		[DebuggerHidden]
		public <CopyTexture>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x22CE728", Offset = "0x22CE728", VA = "0x22CE728", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x22CE72C", Offset = "0x22CE72C", VA = "0x22CE72C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x22CE86C", Offset = "0x22CE86C", VA = "0x22CE86C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI placeText;

	[Token(Token = "0x40004CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI playerNameText;

	[Token(Token = "0x40004CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RawImage playerSignature;

	[Token(Token = "0x40004CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI scoreText;

	[Token(Token = "0x40004D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Color originalTextColor;

	[Token(Token = "0x40004D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Color liveUpdateTextColor;

	[Token(Token = "0x40004D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool isLiveUpdating;

	[Token(Token = "0x40004D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Whiteboard whiteboard;

	[Token(Token = "0x6000549")]
	[Address(RVA = "0x1F16AE8", Offset = "0x1F16AE8", VA = "0x1F16AE8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600054A")]
	[Address(RVA = "0x1F16B28", Offset = "0x1F16B28", VA = "0x1F16B28")]
	public void LiveInsertNewScore()
	{
	}

	[Token(Token = "0x600054B")]
	[Address(RVA = "0x1F16C6C", Offset = "0x1F16C6C", VA = "0x1F16C6C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB289C", Offset = "0xAB289C")]
	private IEnumerator CopyTexture()
	{
		return null;
	}

	[Token(Token = "0x600054C")]
	[Address(RVA = "0x1F16CD8", Offset = "0x1F16CD8", VA = "0x1F16CD8")]
	private void StopLiveUpdate()
	{
	}

	[Token(Token = "0x600054D")]
	[Address(RVA = "0x1F16E08", Offset = "0x1F16E08", VA = "0x1F16E08")]
	private Whiteboard GetWhiteboard()
	{
		return null;
	}

	[Token(Token = "0x600054E")]
	[Address(RVA = "0x1F16ED4", Offset = "0x1F16ED4", VA = "0x1F16ED4")]
	public void Clear()
	{
	}

	[Token(Token = "0x600054F")]
	[Address(RVA = "0x1F16F8C", Offset = "0x1F16F8C", VA = "0x1F16F8C")]
	public ScorePlace()
	{
	}

	[Token(Token = "0x6000550")]
	[Address(RVA = "0x1F16F94", Offset = "0x1F16F94", VA = "0x1F16F94")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB28FC", Offset = "0xAB28FC")]
	private bool <CopyTexture>b__10_0()
	{
		return default(bool);
	}
}
[Token(Token = "0x20000DA")]
public class SteamAchievementsHandler : AchievementsHandler
{
	[Token(Token = "0x6000557")]
	[Address(RVA = "0x1F18734", Offset = "0x1F18734", VA = "0x1F18734")]
	public SteamAchievementsHandler()
	{
	}
}
[Token(Token = "0x20000DB")]
public class SteamInitializer : Singleton<SteamInitializer>
{
	[Token(Token = "0x40004D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool initialized;

	[Token(Token = "0x40004D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool error;

	[Token(Token = "0x40004D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ulong userID;

	[Token(Token = "0x40004DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int maxRetries;

	[Token(Token = "0x40004DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int retryCount;

	[Token(Token = "0x6000558")]
	[Address(RVA = "0x1F1873C", Offset = "0x1F1873C", VA = "0x1F1873C")]
	public SteamInitializer()
	{
	}
}
[Token(Token = "0x20000DC")]
public class SteamOnlineLeaderboardHandler : OnlineLeaderboardHandler
{
	[Token(Token = "0x6000559")]
	[Address(RVA = "0x1F187A0", Offset = "0x1F187A0", VA = "0x1F187A0")]
	public SteamOnlineLeaderboardHandler()
	{
	}
}
[Token(Token = "0x20000DD")]
public class iQiyiInitializer : Singleton<iQiyiInitializer>
{
	[Token(Token = "0x40004DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool initialized;

	[Token(Token = "0x40004DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool error;

	[Token(Token = "0x40004DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string userID;

	[Token(Token = "0x600055A")]
	[Address(RVA = "0x1F46B50", Offset = "0x1F46B50", VA = "0x1F46B50")]
	public iQiyiInitializer()
	{
	}
}
[Token(Token = "0x20000DE")]
public class ArcadeGPM : GamePlayManager
{
	[Token(Token = "0x20000DF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA8FC", Offset = "0xAAA8FC")]
	private sealed class <HandleLeaderboardsAndAchievements>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ArcadeGPM <>4__this;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <highestScore>5__2;

		[Token(Token = "0x170000F6")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600056C")]
			[Address(RVA = "0x1F484A8", Offset = "0x1F484A8", VA = "0x1F484A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F7")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600056E")]
			[Address(RVA = "0x1F484F0", Offset = "0x1F484F0", VA = "0x1F484F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x1F47E50", Offset = "0x1F47E50", VA = "0x1F47E50")]
		[DebuggerHidden]
		public <HandleLeaderboardsAndAchievements>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1F47E7C", Offset = "0x1F47E7C", VA = "0x1F47E7C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x1F47E80", Offset = "0x1F47E80", VA = "0x1F47E80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x1F484B0", Offset = "0x1F484B0", VA = "0x1F484B0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public AudioHandler arcadeCenterAudioHandler;

	[Token(Token = "0x40004E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public OnlineLeaderboard onlineLeaderboard;

	[Token(Token = "0x40004E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public LocalLeaderboard localLeaderboard;

	[Token(Token = "0x40004E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public GameObject newHighScore;

	[Token(Token = "0x40004E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public int score;

	[Token(Token = "0x40004E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
	private float scoreDifficultyMultiplier;

	[Token(Token = "0x40004E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public Whiteboard signatureBoard;

	[Token(Token = "0x40004E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private bool pointsSubmitted;

	[Token(Token = "0x40004E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	public GameObject areYouSureSign;

	[Token(Token = "0x40004E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	public Button areYouSureButton;

	[Token(Token = "0x40004E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	public TextMeshProUGUI pointsDisplay;

	[Token(Token = "0x40004EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	public TextMeshProUGUI waveDisplay;

	[Token(Token = "0x40004EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private Animator waveDisplayAnimator;

	[Token(Token = "0x40004EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public GameObject pointsCanvasPrefab;

	[Token(Token = "0x40004ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public TextMeshProUGUI finishPointsText;

	[Token(Token = "0x40004EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	public TextMeshProUGUI finishTimeText;

	[Token(Token = "0x40004EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	public TextMeshProUGUI finishWaveText;

	[Token(Token = "0x40004F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	protected int arcadeWave;

	[Token(Token = "0x40004F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	public ArcadeWaveHandler arcadeWaveSpawner;

	[Token(Token = "0x40004F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	public int multiplier;

	[Token(Token = "0x40004F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
	private float secondsSinceLastEnemyDeath;

	[Token(Token = "0x40004F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	public float[] multiplierThresholds;

	[Token(Token = "0x40004F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	public bool showMultiplerDisplay;

	[Token(Token = "0x40004F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	public TextMeshProUGUI multiplierDisplay;

	[Token(Token = "0x40004F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	public GameObject multiplierTimerBar;

	[Token(Token = "0x40004F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private Material multiplierTimerBarMaterial;

	[Token(Token = "0x40004F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	public GameObject multiplierCanvas;

	[Token(Token = "0x40004FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	public GameObject multiplierCanvasEletricParticles;

	[Token(Token = "0x40004FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	public ArcadeMode arcadeMode;

	[Token(Token = "0x600055B")]
	[Address(RVA = "0x1EA06BC", Offset = "0x1EA06BC", VA = "0x1EA06BC", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600055C")]
	[Address(RVA = "0x1EA0B28", Offset = "0x1EA0B28", VA = "0x1EA0B28", Slot = "7")]
	protected override void Update()
	{
	}

	[Token(Token = "0x600055D")]
	[Address(RVA = "0x1EA0E3C", Offset = "0x1EA0E3C", VA = "0x1EA0E3C", Slot = "19")]
	public override void GameFinished([Optional] string finishText, bool _won = true, LosingReason reason = LosingReason.Null)
	{
	}

	[Token(Token = "0x600055E")]
	[Address(RVA = "0x1EA1360", Offset = "0x1EA1360", VA = "0x1EA1360")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB295C", Offset = "0xAB295C")]
	private IEnumerator HandleLeaderboardsAndAchievements()
	{
		return null;
	}

	[Token(Token = "0x600055F")]
	[Address(RVA = "0x1EA13CC", Offset = "0x1EA13CC", VA = "0x1EA13CC")]
	public void SubmitLocalScore()
	{
	}

	[Token(Token = "0x6000560")]
	[Address(RVA = "0x1EA0D80", Offset = "0x1EA0D80", VA = "0x1EA0D80")]
	private void DivideMultiplier()
	{
	}

	[Token(Token = "0x6000561")]
	[Address(RVA = "0x1EA14B0", Offset = "0x1EA14B0", VA = "0x1EA14B0")]
	private void MultiplyMultiplier()
	{
	}

	[Token(Token = "0x6000562")]
	[Address(RVA = "0x1EA15B8", Offset = "0x1EA15B8", VA = "0x1EA15B8")]
	public void ScorePoints(Enemy _enemy)
	{
	}

	[Token(Token = "0x6000563")]
	[Address(RVA = "0x1EA1974", Offset = "0x1EA1974", VA = "0x1EA1974")]
	public void ScorePoints(RequestSlot _slot)
	{
	}

	[Token(Token = "0x6000564")]
	[Address(RVA = "0x1EA1920", Offset = "0x1EA1920", VA = "0x1EA1920")]
	private void UpdatePoints(int pointsToAdd)
	{
	}

	[Token(Token = "0x6000565")]
	[Address(RVA = "0x1EA0A38", Offset = "0x1EA0A38", VA = "0x1EA0A38")]
	private void UpdateWaveDisplay(int waveNumber)
	{
	}

	[Token(Token = "0x6000566")]
	[Address(RVA = "0x1EA1CB4", Offset = "0x1EA1CB4", VA = "0x1EA1CB4", Slot = "8")]
	public override void RestartCurrentLevel()
	{
	}

	[Token(Token = "0x6000567")]
	[Address(RVA = "0x1EA1D88", Offset = "0x1EA1D88", VA = "0x1EA1D88", Slot = "9")]
	public override void BackToMenu()
	{
	}

	[Token(Token = "0x6000568")]
	[Address(RVA = "0x1EA1E5C", Offset = "0x1EA1E5C", VA = "0x1EA1E5C")]
	public ArcadeGPM()
	{
	}
}
[Token(Token = "0x20000E0")]
public class ArcadeTutorialGPM : GamePlayManager
{
	[Token(Token = "0x4000500")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public GameObject[] disableOnPhase2;

	[Token(Token = "0x4000501")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public GameObject[] enableOnPhase2;

	[Token(Token = "0x4000502")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public GameObject[] disableOnPhase3;

	[Token(Token = "0x4000503")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public GameObject[] enableOnPhase3;

	[Token(Token = "0x4000504")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private int phase;

	[Token(Token = "0x4000505")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
	private bool completedAllRequests;

	[Token(Token = "0x4000506")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public int nOfEnemiesForGameFinish;

	[Token(Token = "0x4000507")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAAB770", Offset = "0xAAB770")]
	public bool hasElectricExited;

	[Token(Token = "0x600056F")]
	[Address(RVA = "0x1EA31CC", Offset = "0x1EA31CC", VA = "0x1EA31CC", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000570")]
	[Address(RVA = "0x1EA32F0", Offset = "0x1EA32F0", VA = "0x1EA32F0")]
	private void CheckIfElectricExited(Boomerang _boomerang)
	{
	}

	[Token(Token = "0x6000571")]
	[Address(RVA = "0x1EA331C", Offset = "0x1EA331C", VA = "0x1EA331C", Slot = "11")]
	protected override void KillEnemy(Enemy _enemy)
	{
	}

	[Token(Token = "0x6000572")]
	[Address(RVA = "0x1EA3394", Offset = "0x1EA3394", VA = "0x1EA3394")]
	private void SetGroupActive(GameObject[] objs, bool active)
	{
	}

	[Token(Token = "0x6000573")]
	[Address(RVA = "0x1EA3410", Offset = "0x1EA3410", VA = "0x1EA3410")]
	private void OnAllRequestsComplete()
	{
	}

	[Token(Token = "0x6000574")]
	[Address(RVA = "0x1EA34AC", Offset = "0x1EA34AC", VA = "0x1EA34AC", Slot = "21")]
	protected new virtual int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x6000575")]
	[Address(RVA = "0x1EA34FC", Offset = "0x1EA34FC", VA = "0x1EA34FC", Slot = "19")]
	public override void GameFinished([Optional] string finishText, bool _won = true, LosingReason reason = LosingReason.Null)
	{
	}

	[Token(Token = "0x6000576")]
	[Address(RVA = "0x1EA36E8", Offset = "0x1EA36E8", VA = "0x1EA36E8")]
	public ArcadeTutorialGPM()
	{
	}
}
[Token(Token = "0x20000E1")]
public class CookingArcadeGPM : ArcadeGPM
{
	[Token(Token = "0x4000508")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x254")]
	public int requestsMissed;

	[Token(Token = "0x6000577")]
	[Address(RVA = "0x1EB2950", Offset = "0x1EB2950", VA = "0x1EB2950", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000578")]
	[Address(RVA = "0x1EB2A70", Offset = "0x1EB2A70", VA = "0x1EB2A70", Slot = "18")]
	public override void BeerDelivered()
	{
	}

	[Token(Token = "0x6000579")]
	[Address(RVA = "0x1EB2A94", Offset = "0x1EB2A94", VA = "0x1EB2A94", Slot = "12")]
	protected override void LostABeer(Beer beer)
	{
	}

	[Token(Token = "0x600057A")]
	[Address(RVA = "0x1EB2B4C", Offset = "0x1EB2B4C", VA = "0x1EB2B4C")]
	public CookingArcadeGPM()
	{
	}
}
[Token(Token = "0x20000E2")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xAAA90C", Offset = "0xAAA90C")]
public class DifficultyConfig : ScriptableObject
{
	[Token(Token = "0x4000509")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string difficultyName;

	[Token(Token = "0x400050A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int difficultyLevel;

	[Token(Token = "0x400050B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float enemyFrequencyMultiplier;

	[Token(Token = "0x400050C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float koalaFartFrequencyMultiplier;

	[Token(Token = "0x400050D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float koalaFartStartMultiplier;

	[Token(Token = "0x400050E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float kangarooSpawningBabiesMultiplier;

	[Token(Token = "0x400050F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float levelDurationMultipler;

	[Token(Token = "0x4000510")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float timeBetweenRequestsMultiplier;

	[Token(Token = "0x4000511")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float requestTimeLimitMultiplier;

	[Token(Token = "0x4000512")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float quokkaTimeLimitMultiplier;

	[Token(Token = "0x4000513")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float canGuruTimeBetweenAttacksMultiplier;

	[Token(Token = "0x4000514")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float canGuruProjectilesSpeedMultipler;

	[Token(Token = "0x4000515")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float wombatPoopFrequencyMultiplier;

	[Token(Token = "0x4000516")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float miniEmusSpeedMultiplier;

	[Token(Token = "0x4000517")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float emuRocketFrequencyMultiplier;

	[Token(Token = "0x4000518")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float arcadeScoreMultiplier;

	[Token(Token = "0x600057B")]
	[Address(RVA = "0x1EB5178", Offset = "0x1EB5178", VA = "0x1EB5178")]
	public DifficultyConfig()
	{
	}
}
[Token(Token = "0x20000E3")]
public enum LosingReason
{
	[Token(Token = "0x400051A")]
	Null,
	[Token(Token = "0x400051B")]
	Health,
	[Token(Token = "0x400051C")]
	Beers,
	[Token(Token = "0x400051D")]
	Requests
}
[Token(Token = "0x20000E4")]
public class GamePlayManager : Singleton<GamePlayManager>
{
	[Serializable]
	[Token(Token = "0x20000E5")]
	public class FoodReplaceableVariables
	{
		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform beerInstanciateTransform;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform beerSecondaryInstanciateTransform;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject primaryBeerPrefab;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject secondaryBeerPrefab;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FiniteSpawnerSocket burgerTopBreadSpawner;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public FiniteSpawnerSocket burgerMeatSpawner;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public FiniteSpawnerSocket burgerBottomBreadSpawner;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FiniteSpawnerSocket snagBreadSpawner;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public FiniteSpawnerSocket snagMeatSpawner;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public FiniteSpawnerSocket skewerStickSpawner;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FiniteSpawnerSocket skewerShrimpSpawner;

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x1FE6254", Offset = "0x1FE6254", VA = "0x1FE6254")]
		public FoodReplaceableVariables()
		{
		}
	}

	[Token(Token = "0x20000E6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA958", Offset = "0xAAA958")]
	private sealed class <SlowDownTimeCoroutine>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GamePlayManager <>4__this;

		[Token(Token = "0x170000F9")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x1FE6204", Offset = "0x1FE6204", VA = "0x1FE6204", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FA")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x1FE624C", Offset = "0x1FE624C", VA = "0x1FE624C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1FE60E0", Offset = "0x1FE60E0", VA = "0x1FE60E0")]
		[DebuggerHidden]
		public <SlowDownTimeCoroutine>d__64(int <>1__state)
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x1FE610C", Offset = "0x1FE610C", VA = "0x1FE610C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x1FE6110", Offset = "0x1FE6110", VA = "0x1FE6110", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x1FE620C", Offset = "0x1FE620C", VA = "0x1FE620C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA968", Offset = "0xAAA968")]
	private sealed class <PlayerInvulnerability>d__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GamePlayManager <>4__this;

		[Token(Token = "0x170000FB")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x1FE6090", Offset = "0x1FE6090", VA = "0x1FE6090", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FC")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x1FE60D8", Offset = "0x1FE60D8", VA = "0x1FE60D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x1FE5FA8", Offset = "0x1FE5FA8", VA = "0x1FE5FA8")]
		[DebuggerHidden]
		public <PlayerInvulnerability>d__74(int <>1__state)
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x1FE5FD4", Offset = "0x1FE5FD4", VA = "0x1FE5FD4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x1FE5FD8", Offset = "0x1FE5FD8", VA = "0x1FE5FD8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x1FE6098", Offset = "0x1FE6098", VA = "0x1FE6098", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA978", Offset = "0xAAA978")]
	private sealed class <KillPlayer>d__82 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GamePlayManager <>4__this;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HVRScreenFade <fader>5__2;

		[Token(Token = "0x170000FD")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x1FE5F58", Offset = "0x1FE5F58", VA = "0x1FE5F58", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FE")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x1FE5FA0", Offset = "0x1FE5FA0", VA = "0x1FE5FA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1FE5D34", Offset = "0x1FE5D34", VA = "0x1FE5D34")]
		[DebuggerHidden]
		public <KillPlayer>d__82(int <>1__state)
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1FE5D60", Offset = "0x1FE5D60", VA = "0x1FE5D60", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1FE5D64", Offset = "0x1FE5D64", VA = "0x1FE5D64", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x1FE5F60", Offset = "0x1FE5F60", VA = "0x1FE5F60", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA988", Offset = "0xAAA988")]
	private sealed class <<WaitToAnnounceAllEnemiesGone>g__WaitUntilAllEnemiesGone|83_0>d : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GamePlayManager <>4__this;

		[Token(Token = "0x170000FF")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x1FE5CE4", Offset = "0x1FE5CE4", VA = "0x1FE5CE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000100")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x1FE5D2C", Offset = "0x1FE5D2C", VA = "0x1FE5D2C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1FE5B4C", Offset = "0x1FE5B4C", VA = "0x1FE5B4C")]
		[DebuggerHidden]
		public <<WaitToAnnounceAllEnemiesGone>g__WaitUntilAllEnemiesGone|83_0>d(int <>1__state)
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1FE5B78", Offset = "0x1FE5B78", VA = "0x1FE5B78", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1FE5B7C", Offset = "0x1FE5B7C", VA = "0x1FE5B7C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1FE5CEC", Offset = "0x1FE5CEC", VA = "0x1FE5CEC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400051E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected int levelDurationSeconds;

	[Token(Token = "0x400051F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	protected float levelSecondsLeft;

	[Token(Token = "0x4000520")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected bool gameWithTime;

	[Token(Token = "0x4000521")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool gameRunning;

	[Token(Token = "0x4000522")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	protected bool levelFinished;

	[Token(Token = "0x4000523")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
	protected bool levelWon;

	[Token(Token = "0x4000524")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	protected bool playerDying;

	[Token(Token = "0x4000525")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAAB7A8", Offset = "0xAAB7A8")]
	public LevelInfo levelInfo;

	[Token(Token = "0x4000526")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject showOnceGameFinished;

	[Token(Token = "0x4000527")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject goneOnceGameFinished;

	[Token(Token = "0x4000528")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public FinishedSign finishedSign;

	[Token(Token = "0x4000529")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI timeText;

	[Token(Token = "0x400052A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public Events.EventPlayerHurt OnPlayerHurt;

	[Token(Token = "0x400052B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public Events.EventBeerDisapeared OnBeerLost;

	[Token(Token = "0x400052C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[HideInInspector]
	public Events.EventBeerBoxDisapeared OnBeerBoxSteal;

	[Token(Token = "0x400052D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public Events.EventEnemyDeath OnEnemyDeath;

	[Token(Token = "0x400052E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public Events.EventEnemyGone OnEnemyGone;

	[Token(Token = "0x400052F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[HideInInspector]
	public Events.EventEnemySpawn OnEnemySpawn;

	[Token(Token = "0x4000530")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[HideInInspector]
	public Events.EventFinishGame OnGameFinished;

	[Token(Token = "0x4000531")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public Events.EventScoreSubmit OnScoreSubmited;

	[Token(Token = "0x4000532")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[HideInInspector]
	public Events.EventBeerDelivered OnBeerDelivered;

	[Token(Token = "0x4000533")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[HideInInspector]
	public Events.EventHamburgerDelivered OnHamburgerDelivered;

	[Token(Token = "0x4000534")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	public Events.EventSnagDelivered OnSnagDelivered;

	[Token(Token = "0x4000535")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[HideInInspector]
	public Events.EventSkewerDelivered OnSkewerDelivered;

	[Token(Token = "0x4000536")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[HideInInspector]
	public Events.EventAllEnemiesGone OnAllEnemiesGone;

	[Token(Token = "0x4000537")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[HideInInspector]
	public Events.EventBoomerangDestroy OnBoomerangDestroy;

	[Token(Token = "0x4000538")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[HideInInspector]
	public Events.EventBoomerangGrab OnBoomerangGrab;

	[Token(Token = "0x4000539")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[HideInInspector]
	public Events.EventRequestMissed OnRequestMissedEvent;

	[Token(Token = "0x400053A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[HideInInspector]
	public Events.EventRequestCompleted OnRequestCompleteEvent;

	[Token(Token = "0x400053B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[HideInInspector]
	public Events.EventAllRequestsComplete OnAllRequestComplete;

	[Token(Token = "0x400053C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Events.EventLevelActualStart onLevelActualStart;

	[Token(Token = "0x400053D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAAB900", Offset = "0xAAB900")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xAAB900", Offset = "0xAAB900")]
	public int playerHealth;

	[Token(Token = "0x400053E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public int beersToLose;

	[Token(Token = "0x400053F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public int requestsToLose;

	[Token(Token = "0x4000540")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public int currentBeersInLevel;

	[Token(Token = "0x4000541")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public int enemiesKilled;

	[Token(Token = "0x4000542")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	public int parachutesLanded;

	[Token(Token = "0x4000543")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public int objectivesComplete;

	[Token(Token = "0x4000544")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public GameStatistics levelStats;

	[Token(Token = "0x4000545")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[HideInInspector]
	public List<Enemy> enemies;

	[Token(Token = "0x4000546")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private float startTime;

	[Token(Token = "0x4000547")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	private bool playerInvulnerable;

	[Token(Token = "0x4000548")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private float playerInvulnerablityTime;

	[Token(Token = "0x4000549")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public FoodReplaceableVariables foodItems;

	[Token(Token = "0x400054A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	[HideInInspector]
	public AudioHandler audioHandler;

	[Token(Token = "0x400054B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public TimerBirdBehaviour timerBird;

	[Token(Token = "0x400054C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private TextMeshProUGUI watchTimeText;

	[Token(Token = "0x400054D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	protected float timeSinceLastCalled;

	[Token(Token = "0x400054E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private HVRTimeManager timeManager;

	[Token(Token = "0x400054F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public bool isSlowedDown;

	[Token(Token = "0x4000550")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	private float timeLeftInSlowDown;

	[Token(Token = "0x4000551")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private int slowDownDuration;

	[Token(Token = "0x4000552")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	protected int minutes;

	[Token(Token = "0x4000553")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	protected int seconds;

	[Token(Token = "0x4000554")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
	private int attemptNumber;

	[Token(Token = "0x4000555")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public XDisplayManager beersLostDisplay;

	[Token(Token = "0x4000556")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public XDisplayManager requestsLostDisplay;

	[Token(Token = "0x170000F8")]
	public int enemiesNumber
	{
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x1F22A44", Offset = "0x1F22A44", VA = "0x1F22A44")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600057D")]
	[Address(RVA = "0x1F22A90", Offset = "0x1F22A90", VA = "0x1F22A90", Slot = "6")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x600057E")]
	[Address(RVA = "0x1F23404", Offset = "0x1F23404", VA = "0x1F23404", Slot = "7")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x600057F")]
	[Address(RVA = "0x1F235E0", Offset = "0x1F235E0", VA = "0x1F235E0")]
	public int CountBeers()
	{
		return default(int);
	}

	[Token(Token = "0x6000580")]
	[Address(RVA = "0x1F23660", Offset = "0x1F23660", VA = "0x1F23660")]
	public void SlowDownTime()
	{
	}

	[Token(Token = "0x6000581")]
	[Address(RVA = "0x1F236AC", Offset = "0x1F236AC", VA = "0x1F236AC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB2A0C", Offset = "0xAB2A0C")]
	public IEnumerator SlowDownTimeCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000582")]
	[Address(RVA = "0x1F23718", Offset = "0x1F23718", VA = "0x1F23718")]
	private void ForceTimeReset()
	{
	}

	[Token(Token = "0x6000583")]
	[Address(RVA = "0x1F237D0", Offset = "0x1F237D0", VA = "0x1F237D0")]
	public void GoToLevel(string levelName)
	{
	}

	[Token(Token = "0x6000584")]
	[Address(RVA = "0x1F2469C", Offset = "0x1F2469C", VA = "0x1F2469C", Slot = "8")]
	public virtual void RestartCurrentLevel()
	{
	}

	[Token(Token = "0x6000585")]
	[Address(RVA = "0x1F24728", Offset = "0x1F24728", VA = "0x1F24728", Slot = "9")]
	public virtual void BackToMenu()
	{
	}

	[Token(Token = "0x6000586")]
	[Address(RVA = "0x1F248B4", Offset = "0x1F248B4", VA = "0x1F248B4", Slot = "10")]
	protected virtual void LevelActualStartsFunction()
	{
	}

	[Token(Token = "0x6000587")]
	[Address(RVA = "0x1F24944", Offset = "0x1F24944", VA = "0x1F24944", Slot = "11")]
	protected virtual void KillEnemy(Enemy _enemy)
	{
	}

	[Token(Token = "0x6000588")]
	[Address(RVA = "0x1F24AB4", Offset = "0x1F24AB4", VA = "0x1F24AB4")]
	private void RemoveEnemy(Enemy _enemy)
	{
	}

	[Token(Token = "0x6000589")]
	[Address(RVA = "0x1F24B18", Offset = "0x1F24B18", VA = "0x1F24B18")]
	private void AddEnemy(Enemy _enemy)
	{
	}

	[Token(Token = "0x600058A")]
	[Address(RVA = "0x1F1B580", Offset = "0x1F1B580", VA = "0x1F1B580")]
	public void PlayerHurt(int damageToGive)
	{
	}

	[Token(Token = "0x600058B")]
	[Address(RVA = "0x1F24BE8", Offset = "0x1F24BE8", VA = "0x1F24BE8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB2A6C", Offset = "0xAB2A6C")]
	private IEnumerator PlayerInvulnerability()
	{
		return null;
	}

	[Token(Token = "0x600058C")]
	[Address(RVA = "0x1F24C54", Offset = "0x1F24C54", VA = "0x1F24C54", Slot = "12")]
	protected virtual void LostABeer(Beer beer)
	{
	}

	[Token(Token = "0x600058D")]
	[Address(RVA = "0x1F24D50", Offset = "0x1F24D50", VA = "0x1F24D50", Slot = "13")]
	protected virtual void RequestMissed(RequestSlot _)
	{
	}

	[Token(Token = "0x600058E")]
	[Address(RVA = "0x1F24E40", Offset = "0x1F24E40", VA = "0x1F24E40", Slot = "14")]
	protected virtual void RequestComplete(RequestSlot _)
	{
	}

	[Token(Token = "0x600058F")]
	[Address(RVA = "0x1F24E64", Offset = "0x1F24E64", VA = "0x1F24E64", Slot = "15")]
	protected virtual void HamburgerDelivered()
	{
	}

	[Token(Token = "0x6000590")]
	[Address(RVA = "0x1F24E88", Offset = "0x1F24E88", VA = "0x1F24E88", Slot = "16")]
	protected virtual void SnagDelivered()
	{
	}

	[Token(Token = "0x6000591")]
	[Address(RVA = "0x1F24EAC", Offset = "0x1F24EAC", VA = "0x1F24EAC", Slot = "17")]
	protected virtual void SkewerDelivered()
	{
	}

	[Token(Token = "0x6000592")]
	[Address(RVA = "0x1F24ED0", Offset = "0x1F24ED0", VA = "0x1F24ED0", Slot = "18")]
	public virtual void BeerDelivered()
	{
	}

	[Token(Token = "0x6000593")]
	[Address(RVA = "0x1F24B7C", Offset = "0x1F24B7C", VA = "0x1F24B7C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB2ACC", Offset = "0xAB2ACC")]
	private IEnumerator KillPlayer()
	{
		return null;
	}

	[Token(Token = "0x6000594")]
	[Address(RVA = "0x1F24F00", Offset = "0x1F24F00", VA = "0x1F24F00")]
	public void WaitToAnnounceAllEnemiesGone()
	{
	}

	[Token(Token = "0x6000595")]
	[Address(RVA = "0x1F24F98", Offset = "0x1F24F98", VA = "0x1F24F98")]
	public void AwardAchievement(string _achievementID)
	{
	}

	[Token(Token = "0x6000596")]
	[Address(RVA = "0x1F25028", Offset = "0x1F25028", VA = "0x1F25028", Slot = "19")]
	public virtual void GameFinished([Optional] string finishText, bool won = true, LosingReason reason = LosingReason.Null)
	{
	}

	[Token(Token = "0x6000597")]
	[Address(RVA = "0x1F2591C", Offset = "0x1F2591C", VA = "0x1F2591C", Slot = "20")]
	protected virtual int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x6000598")]
	[Address(RVA = "0x1F25924", Offset = "0x1F25924", VA = "0x1F25924")]
	protected void ObjectiveCheck(int i)
	{
	}

	[Token(Token = "0x6000599")]
	[Address(RVA = "0x1F256C4", Offset = "0x1F256C4", VA = "0x1F256C4")]
	public void FinishScreen(int _objectivesComplete)
	{
	}

	[Token(Token = "0x600059A")]
	[Address(RVA = "0x1F23960", Offset = "0x1F23960", VA = "0x1F23960")]
	public void LevelAchievementCheck()
	{
	}

	[Token(Token = "0x600059B")]
	[Address(RVA = "0x1F24988", Offset = "0x1F24988", VA = "0x1F24988")]
	private void AddEnemyConcussedToLevelStatistics(Enemy.TypeOfEnemy _typeOfEnemy)
	{
	}

	[Token(Token = "0x600059C")]
	[Address(RVA = "0x1F25C04", Offset = "0x1F25C04", VA = "0x1F25C04")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600059D")]
	[Address(RVA = "0x1F23AAC", Offset = "0x1F23AAC", VA = "0x1F23AAC")]
	private void SendLevelAttemptAnalyticsEvent(bool quitApplication = false)
	{
	}

	[Token(Token = "0x600059E")]
	[Address(RVA = "0x1F25C0C", Offset = "0x1F25C0C", VA = "0x1F25C0C")]
	private void ReplaceDeliveredItem(RequestSlot _slot)
	{
	}

	[Token(Token = "0x600059F")]
	[Address(RVA = "0x1F26004", Offset = "0x1F26004", VA = "0x1F26004")]
	private void InstanciateBeerInBeerBox(GameObject beerPrefab, Transform beerBox)
	{
	}

	[Token(Token = "0x60005A0")]
	[Address(RVA = "0x1F260D8", Offset = "0x1F260D8", VA = "0x1F260D8")]
	private void UpdateSpawnerLimit(FiniteSpawnerSocket spawner, int n = 1)
	{
	}

	[Token(Token = "0x60005A1")]
	[Address(RVA = "0x1F261B0", Offset = "0x1F261B0", VA = "0x1F261B0")]
	public GamePlayManager()
	{
	}

	[Token(Token = "0x60005A2")]
	[Address(RVA = "0x1F24F2C", Offset = "0x1F24F2C", VA = "0x1F24F2C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB2B2C", Offset = "0xAB2B2C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB2B2C", Offset = "0xAB2B2C")]
	private IEnumerator <WaitToAnnounceAllEnemiesGone>g__WaitUntilAllEnemiesGone|83_0()
	{
		return null;
	}

	[Token(Token = "0x60005A3")]
	[Address(RVA = "0x1F2621C", Offset = "0x1F2621C", VA = "0x1F2621C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB2B9C", Offset = "0xAB2B9C")]
	private bool <WaitToAnnounceAllEnemiesGone>b__83_1()
	{
		return default(bool);
	}
}
[Token(Token = "0x20000EA")]
public class HellGPM : GamePlayManager
{
	[Token(Token = "0x60005BD")]
	[Address(RVA = "0x1F277A0", Offset = "0x1F277A0", VA = "0x1F277A0", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x60005BE")]
	[Address(RVA = "0x1F277A8", Offset = "0x1F277A8", VA = "0x1F277A8")]
	public HellGPM()
	{
	}
}
[Token(Token = "0x20000EB")]
public class Level10GPM : GamePlayManager
{
	[Token(Token = "0x20000EC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA998", Offset = "0xAAA998")]
	private sealed class <>c__DisplayClass6_0
	{
		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource s;

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x1FF0914", Offset = "0x1FF0914", VA = "0x1FF0914")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x1FF091C", Offset = "0x1FF091C", VA = "0x1FF091C")]
		internal bool <MusicSetup>b__0()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000ED")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA9A8", Offset = "0xAAA9A8")]
	private sealed class <MusicSetup>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level10GPM <>4__this;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private <>c__DisplayClass6_0 <>8__1;

		[Token(Token = "0x17000101")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x1FF0C24", Offset = "0x1FF0C24", VA = "0x1FF0C24", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000102")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x1FF0C6C", Offset = "0x1FF0C6C", VA = "0x1FF0C6C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x1FF0938", Offset = "0x1FF0938", VA = "0x1FF0938")]
		[DebuggerHidden]
		public <MusicSetup>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x1FF0964", Offset = "0x1FF0964", VA = "0x1FF0964", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x1FF0968", Offset = "0x1FF0968", VA = "0x1FF0968", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x1FF0C2C", Offset = "0x1FF0C2C", VA = "0x1FF0C2C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000EE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA9B8", Offset = "0xAAA9B8")]
	private sealed class <StartMole>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level10GPM <>4__this;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <time>5__2;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 <startingPos>5__3;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 <startingPosLevelEssentials>5__4;

		[Token(Token = "0x17000103")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x1FF123C", Offset = "0x1FF123C", VA = "0x1FF123C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000104")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x1FF1284", Offset = "0x1FF1284", VA = "0x1FF1284", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x1FF0C74", Offset = "0x1FF0C74", VA = "0x1FF0C74")]
		[DebuggerHidden]
		public <StartMole>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x1FF0CA0", Offset = "0x1FF0CA0", VA = "0x1FF0CA0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x1FF0CA4", Offset = "0x1FF0CA4", VA = "0x1FF0CA4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x1FF1244", Offset = "0x1FF1244", VA = "0x1FF1244", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400056F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public GameObject originalMap;

	[Token(Token = "0x4000570")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public GameObject moleMap;

	[Token(Token = "0x4000571")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public AudioHandler mapAudioHandler;

	[Token(Token = "0x4000572")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public GameObject mole;

	[Token(Token = "0x60005BF")]
	[Address(RVA = "0x1F2AE1C", Offset = "0x1F2AE1C", VA = "0x1F2AE1C", Slot = "11")]
	protected override void KillEnemy(Enemy _enemy)
	{
	}

	[Token(Token = "0x60005C0")]
	[Address(RVA = "0x1F2AE58", Offset = "0x1F2AE58", VA = "0x1F2AE58", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60005C1")]
	[Address(RVA = "0x1F2AF10", Offset = "0x1F2AF10", VA = "0x1F2AF10")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB2CEC", Offset = "0xAB2CEC")]
	private IEnumerator MusicSetup()
	{
		return null;
	}

	[Token(Token = "0x60005C2")]
	[Address(RVA = "0x1F2AEA4", Offset = "0x1F2AEA4", VA = "0x1F2AEA4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB2D4C", Offset = "0xAB2D4C")]
	private IEnumerator StartMole()
	{
		return null;
	}

	[Token(Token = "0x60005C3")]
	[Address(RVA = "0x1F2AF7C", Offset = "0x1F2AF7C", VA = "0x1F2AF7C")]
	public void AddMusicIntensity(int _stage)
	{
	}

	[Token(Token = "0x60005C4")]
	[Address(RVA = "0x1F2B10C", Offset = "0x1F2B10C", VA = "0x1F2B10C", Slot = "12")]
	protected override void LostABeer(Beer beer)
	{
	}

	[Token(Token = "0x60005C5")]
	[Address(RVA = "0x1F2B110", Offset = "0x1F2B110", VA = "0x1F2B110", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x60005C6")]
	[Address(RVA = "0x1F2B19C", Offset = "0x1F2B19C", VA = "0x1F2B19C", Slot = "19")]
	public override void GameFinished([Optional] string finishText, bool won = true, LosingReason reason = LosingReason.Null)
	{
	}

	[Token(Token = "0x60005C7")]
	[Address(RVA = "0x1F2B1C8", Offset = "0x1F2B1C8", VA = "0x1F2B1C8")]
	public Level10GPM()
	{
	}
}
[Token(Token = "0x20000EF")]
public class Level11GPM : GamePlayManager
{
	[Token(Token = "0x20000F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA9C8", Offset = "0xAAA9C8")]
	private sealed class <WaitUntilLevelStart>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level11GPM <>4__this;

		[Token(Token = "0x17000105")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x1FF1418", Offset = "0x1FF1418", VA = "0x1FF1418", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000106")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x1FF1460", Offset = "0x1FF1460", VA = "0x1FF1460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x1FF128C", Offset = "0x1FF128C", VA = "0x1FF128C")]
		[DebuggerHidden]
		public <WaitUntilLevelStart>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x1FF12B8", Offset = "0x1FF12B8", VA = "0x1FF12B8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x1FF12BC", Offset = "0x1FF12BC", VA = "0x1FF12BC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x1FF1420", Offset = "0x1FF1420", VA = "0x1FF1420", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x60005D6")]
	[Address(RVA = "0x1F2B1CC", Offset = "0x1F2B1CC", VA = "0x1F2B1CC", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60005D7")]
	[Address(RVA = "0x1F2B200", Offset = "0x1F2B200", VA = "0x1F2B200")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB2E4C", Offset = "0xAB2E4C")]
	private IEnumerator WaitUntilLevelStart()
	{
		return null;
	}

	[Token(Token = "0x60005D8")]
	[Address(RVA = "0x1F2B26C", Offset = "0x1F2B26C", VA = "0x1F2B26C", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x60005D9")]
	[Address(RVA = "0x1F2B304", Offset = "0x1F2B304", VA = "0x1F2B304")]
	public Level11GPM()
	{
	}

	[Token(Token = "0x60005DA")]
	[Address(RVA = "0x1F2B308", Offset = "0x1F2B308", VA = "0x1F2B308")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB2EAC", Offset = "0xAB2EAC")]
	private bool <WaitUntilLevelStart>b__1_0()
	{
		return default(bool);
	}
}
[Token(Token = "0x20000F1")]
public class Level12GPM : GamePlayManager
{
	[Token(Token = "0x20000F2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA9D8", Offset = "0xAAA9D8")]
	private sealed class <WaitUntilLevelStart>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level12GPM <>4__this;

		[Token(Token = "0x17000107")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x1FF15F4", Offset = "0x1FF15F4", VA = "0x1FF15F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000108")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x1FF163C", Offset = "0x1FF163C", VA = "0x1FF163C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x1FF1468", Offset = "0x1FF1468", VA = "0x1FF1468")]
		[DebuggerHidden]
		public <WaitUntilLevelStart>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x1FF1494", Offset = "0x1FF1494", VA = "0x1FF1494", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x1FF1498", Offset = "0x1FF1498", VA = "0x1FF1498", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x1FF15FC", Offset = "0x1FF15FC", VA = "0x1FF15FC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x60005E1")]
	[Address(RVA = "0x1F2B340", Offset = "0x1F2B340", VA = "0x1F2B340", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60005E2")]
	[Address(RVA = "0x1F2B374", Offset = "0x1F2B374", VA = "0x1F2B374")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB2F0C", Offset = "0xAB2F0C")]
	private IEnumerator WaitUntilLevelStart()
	{
		return null;
	}

	[Token(Token = "0x60005E3")]
	[Address(RVA = "0x1F2B3E0", Offset = "0x1F2B3E0", VA = "0x1F2B3E0", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x60005E4")]
	[Address(RVA = "0x1F2B47C", Offset = "0x1F2B47C", VA = "0x1F2B47C")]
	public Level12GPM()
	{
	}

	[Token(Token = "0x60005E5")]
	[Address(RVA = "0x1F2B480", Offset = "0x1F2B480", VA = "0x1F2B480")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB2F6C", Offset = "0xAB2F6C")]
	private bool <WaitUntilLevelStart>b__1_0()
	{
		return default(bool);
	}
}
[Token(Token = "0x20000F3")]
public class Level13GPM : GamePlayManager
{
	[Token(Token = "0x20000F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA9E8", Offset = "0xAAA9E8")]
	private sealed class <WaitUntilLevelStart>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level13GPM <>4__this;

		[Token(Token = "0x17000109")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x1FF17D0", Offset = "0x1FF17D0", VA = "0x1FF17D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x1FF1818", Offset = "0x1FF1818", VA = "0x1FF1818", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x1FF1644", Offset = "0x1FF1644", VA = "0x1FF1644")]
		[DebuggerHidden]
		public <WaitUntilLevelStart>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x1FF1670", Offset = "0x1FF1670", VA = "0x1FF1670", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x1FF1674", Offset = "0x1FF1674", VA = "0x1FF1674", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x1FF17D8", Offset = "0x1FF17D8", VA = "0x1FF17D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x60005EC")]
	[Address(RVA = "0x1F2B4B8", Offset = "0x1F2B4B8", VA = "0x1F2B4B8", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60005ED")]
	[Address(RVA = "0x1F2B4EC", Offset = "0x1F2B4EC", VA = "0x1F2B4EC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB2FCC", Offset = "0xAB2FCC")]
	private IEnumerator WaitUntilLevelStart()
	{
		return null;
	}

	[Token(Token = "0x60005EE")]
	[Address(RVA = "0x1F2B558", Offset = "0x1F2B558", VA = "0x1F2B558", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x60005EF")]
	[Address(RVA = "0x1F2B5F4", Offset = "0x1F2B5F4", VA = "0x1F2B5F4")]
	public Level13GPM()
	{
	}

	[Token(Token = "0x60005F0")]
	[Address(RVA = "0x1F2B5F8", Offset = "0x1F2B5F8", VA = "0x1F2B5F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB402C", Offset = "0xAB402C")]
	private bool <WaitUntilLevelStart>b__1_0()
	{
		return default(bool);
	}
}
[Token(Token = "0x20000F5")]
public class Level14GPM : GamePlayManager
{
	[Token(Token = "0x60005F7")]
	[Address(RVA = "0x1F2B630", Offset = "0x1F2B630", VA = "0x1F2B630", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x60005F8")]
	[Address(RVA = "0x1F2B6C8", Offset = "0x1F2B6C8", VA = "0x1F2B6C8")]
	public Level14GPM()
	{
	}
}
[Token(Token = "0x20000F6")]
public class Level15GPM : GamePlayManager
{
	[Token(Token = "0x20000F7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAA9F8", Offset = "0xAAA9F8")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource s;

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x1FF1820", Offset = "0x1FF1820", VA = "0x1FF1820")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x1FF1828", Offset = "0x1FF1828", VA = "0x1FF1828")]
		internal bool <MusicSetup>b__0()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAA08", Offset = "0xAAAA08")]
	private sealed class <MusicSetup>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level15GPM <>4__this;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private <>c__DisplayClass3_0 <>8__1;

		[Token(Token = "0x1700010B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000605")]
			[Address(RVA = "0x1FF1D04", Offset = "0x1FF1D04", VA = "0x1FF1D04", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000607")]
			[Address(RVA = "0x1FF1D4C", Offset = "0x1FF1D4C", VA = "0x1FF1D4C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x1FF1A18", Offset = "0x1FF1A18", VA = "0x1FF1A18")]
		[DebuggerHidden]
		public <MusicSetup>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x1FF1A44", Offset = "0x1FF1A44", VA = "0x1FF1A44", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x1FF1A48", Offset = "0x1FF1A48", VA = "0x1FF1A48", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x1FF1D0C", Offset = "0x1FF1D0C", VA = "0x1FF1D0C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000F9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAA18", Offset = "0xAAAA18")]
	private sealed class <BackToMenuAfterSeconds>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Level15GPM <>4__this;

		[Token(Token = "0x1700010D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600060B")]
			[Address(RVA = "0x1FF19C8", Offset = "0x1FF19C8", VA = "0x1FF19C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600060D")]
			[Address(RVA = "0x1FF1A10", Offset = "0x1FF1A10", VA = "0x1FF1A10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x1FF1844", Offset = "0x1FF1844", VA = "0x1FF1844")]
		[DebuggerHidden]
		public <BackToMenuAfterSeconds>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x1FF1870", Offset = "0x1FF1870", VA = "0x1FF1870", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x1FF1874", Offset = "0x1FF1874", VA = "0x1FF1874", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x1FF19D0", Offset = "0x1FF19D0", VA = "0x1FF19D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000587")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public GameObject creditsSign;

	[Token(Token = "0x4000588")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public bool playEndingSong;

	[Token(Token = "0x60005F9")]
	[Address(RVA = "0x1F2B6CC", Offset = "0x1F2B6CC", VA = "0x1F2B6CC", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60005FA")]
	[Address(RVA = "0x1F2B700", Offset = "0x1F2B700", VA = "0x1F2B700")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB408C", Offset = "0xAB408C")]
	private IEnumerator MusicSetup()
	{
		return null;
	}

	[Token(Token = "0x60005FB")]
	[Address(RVA = "0x1F2B76C", Offset = "0x1F2B76C", VA = "0x1F2B76C")]
	public void AddMusicIntensity(int _stage)
	{
	}

	[Token(Token = "0x60005FC")]
	[Address(RVA = "0x1F2B8FC", Offset = "0x1F2B8FC", VA = "0x1F2B8FC", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x60005FD")]
	[Address(RVA = "0x1F2B95C", Offset = "0x1F2B95C", VA = "0x1F2B95C", Slot = "19")]
	public override void GameFinished([Optional] string finishText, bool won = true, LosingReason reason = LosingReason.Null)
	{
	}

	[Token(Token = "0x60005FE")]
	[Address(RVA = "0x1F2BB20", Offset = "0x1F2BB20", VA = "0x1F2BB20")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB40EC", Offset = "0xAB40EC")]
	private IEnumerator BackToMenuAfterSeconds(float delay)
	{
		return null;
	}

	[Token(Token = "0x60005FF")]
	[Address(RVA = "0x1F2BB9C", Offset = "0x1F2BB9C", VA = "0x1F2BB9C")]
	public Level15GPM()
	{
	}
}
[Token(Token = "0x20000FA")]
public class Level1GPM : GamePlayManager
{
	[Token(Token = "0x600060E")]
	[Address(RVA = "0x1F2BBA0", Offset = "0x1F2BBA0", VA = "0x1F2BBA0", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600060F")]
	[Address(RVA = "0x1F2BC3C", Offset = "0x1F2BC3C", VA = "0x1F2BC3C")]
	public int CountColdBeers()
	{
		return default(int);
	}

	[Token(Token = "0x6000610")]
	[Address(RVA = "0x1F2BDA0", Offset = "0x1F2BDA0", VA = "0x1F2BDA0", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x6000611")]
	[Address(RVA = "0x1F2BE44", Offset = "0x1F2BE44", VA = "0x1F2BE44")]
	private void OneMinLeftAchievement()
	{
	}

	[Token(Token = "0x6000612")]
	[Address(RVA = "0x1F2BF08", Offset = "0x1F2BF08", VA = "0x1F2BF08")]
	public Level1GPM()
	{
	}
}
[Token(Token = "0x20000FB")]
public class Level2DemoGPM : GamePlayManager
{
	[Token(Token = "0x20000FC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAA28", Offset = "0xAAAA28")]
	private sealed class <WaitAndEnableSkip>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level2DemoGPM <>4__this;

		[Token(Token = "0x1700010F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x1FF1EBC", Offset = "0x1FF1EBC", VA = "0x1FF1EBC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000110")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000621")]
			[Address(RVA = "0x1FF1F04", Offset = "0x1FF1F04", VA = "0x1FF1F04", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x1FF1D54", Offset = "0x1FF1D54", VA = "0x1FF1D54")]
		[DebuggerHidden]
		public <WaitAndEnableSkip>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x1FF1D80", Offset = "0x1FF1D80", VA = "0x1FF1D80", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x1FF1D84", Offset = "0x1FF1D84", VA = "0x1FF1D84", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x1FF1EC4", Offset = "0x1FF1EC4", VA = "0x1FF1EC4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000FD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAA38", Offset = "0xAAAA38")]
	private sealed class <WatchTrailerCoroutine>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level2DemoGPM <>4__this;

		[Token(Token = "0x17000111")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000625")]
			[Address(RVA = "0x1FF2524", Offset = "0x1FF2524", VA = "0x1FF2524", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000112")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x1FF256C", Offset = "0x1FF256C", VA = "0x1FF256C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x1FF1F0C", Offset = "0x1FF1F0C", VA = "0x1FF1F0C")]
		[DebuggerHidden]
		public <WatchTrailerCoroutine>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x1FF1F38", Offset = "0x1FF1F38", VA = "0x1FF1F38", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x1FF1F3C", Offset = "0x1FF1F3C", VA = "0x1FF1F3C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x1FF252C", Offset = "0x1FF252C", VA = "0x1FF252C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000592")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public GameObject showOnceGameBurgered;

	[Token(Token = "0x4000593")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public GameObject trailerCanvasPrefab;

	[Token(Token = "0x4000594")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private bool skipable;

	[Token(Token = "0x4000595")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private AussiePlayer aussiePlayer;

	[Token(Token = "0x6000613")]
	[Address(RVA = "0x1F2BF0C", Offset = "0x1F2BF0C", VA = "0x1F2BF0C", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000614")]
	[Address(RVA = "0x1F2BFF8", Offset = "0x1F2BFF8", VA = "0x1F2BFF8", Slot = "7")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000615")]
	[Address(RVA = "0x1F2C0D0", Offset = "0x1F2C0D0", VA = "0x1F2C0D0", Slot = "15")]
	protected override void HamburgerDelivered()
	{
	}

	[Token(Token = "0x6000616")]
	[Address(RVA = "0x1F2C288", Offset = "0x1F2C288", VA = "0x1F2C288", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x6000617")]
	[Address(RVA = "0x1F2C310", Offset = "0x1F2C310", VA = "0x1F2C310")]
	public void WatchTrailer()
	{
	}

	[Token(Token = "0x6000618")]
	[Address(RVA = "0x1F2C354", Offset = "0x1F2C354", VA = "0x1F2C354")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB41EC", Offset = "0xAB41EC")]
	private IEnumerator WaitAndEnableSkip()
	{
		return null;
	}

	[Token(Token = "0x6000619")]
	[Address(RVA = "0x1F2C3C0", Offset = "0x1F2C3C0", VA = "0x1F2C3C0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB424C", Offset = "0xAB424C")]
	private IEnumerator WatchTrailerCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600061A")]
	[Address(RVA = "0x1F2C42C", Offset = "0x1F2C42C", VA = "0x1F2C42C", Slot = "13")]
	protected override void RequestMissed(RequestSlot _)
	{
	}

	[Token(Token = "0x600061B")]
	[Address(RVA = "0x1F2C4A4", Offset = "0x1F2C4A4", VA = "0x1F2C4A4")]
	public Level2DemoGPM()
	{
	}
}
[Token(Token = "0x20000FE")]
public class Level2GPM : GamePlayManager
{
	[Token(Token = "0x6000628")]
	[Address(RVA = "0x1F2C4A8", Offset = "0x1F2C4A8", VA = "0x1F2C4A8", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x6000629")]
	[Address(RVA = "0x1F2C544", Offset = "0x1F2C544", VA = "0x1F2C544")]
	public Level2GPM()
	{
	}
}
[Token(Token = "0x20000FF")]
public class Level3GPM : GamePlayManager
{
	[Token(Token = "0x600062A")]
	[Address(RVA = "0x1F2C548", Offset = "0x1F2C548", VA = "0x1F2C548", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x600062B")]
	[Address(RVA = "0x1F2C5E4", Offset = "0x1F2C5E4", VA = "0x1F2C5E4")]
	public Level3GPM()
	{
	}
}
[Token(Token = "0x2000100")]
public class Level4GPM : GamePlayManager
{
	[Token(Token = "0x2000101")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAA48", Offset = "0xAAAA48")]
	private sealed class <WaitUntilLevelStart>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level4GPM <>4__this;

		[Token(Token = "0x17000113")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x1FF26B0", Offset = "0x1FF26B0", VA = "0x1FF26B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000114")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000636")]
			[Address(RVA = "0x1FF26F8", Offset = "0x1FF26F8", VA = "0x1FF26F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x1FF2574", Offset = "0x1FF2574", VA = "0x1FF2574")]
		[DebuggerHidden]
		public <WaitUntilLevelStart>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x1FF25A0", Offset = "0x1FF25A0", VA = "0x1FF25A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x1FF25A4", Offset = "0x1FF25A4", VA = "0x1FF25A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x1FF26B8", Offset = "0x1FF26B8", VA = "0x1FF26B8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x600062C")]
	[Address(RVA = "0x1F2C5E8", Offset = "0x1F2C5E8", VA = "0x1F2C5E8", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600062D")]
	[Address(RVA = "0x1F2C61C", Offset = "0x1F2C61C", VA = "0x1F2C61C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB434C", Offset = "0xAB434C")]
	private IEnumerator WaitUntilLevelStart()
	{
		return null;
	}

	[Token(Token = "0x600062E")]
	[Address(RVA = "0x1F2C688", Offset = "0x1F2C688", VA = "0x1F2C688", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x600062F")]
	[Address(RVA = "0x1F2C728", Offset = "0x1F2C728", VA = "0x1F2C728")]
	public Level4GPM()
	{
	}

	[Token(Token = "0x6000630")]
	[Address(RVA = "0x1F2C72C", Offset = "0x1F2C72C", VA = "0x1F2C72C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB43AC", Offset = "0xAB43AC")]
	private bool <WaitUntilLevelStart>b__1_0()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000102")]
public class Level5GPM : GamePlayManager
{
	[Token(Token = "0x2000103")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAA58", Offset = "0xAAAA58")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource s;

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x1FF2700", Offset = "0x1FF2700", VA = "0x1FF2700")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x1FF2708", Offset = "0x1FF2708", VA = "0x1FF2708")]
		internal bool <MusicSetup>b__0()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000104")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAA68", Offset = "0xAAAA68")]
	private sealed class <MusicSetup>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level5GPM <>4__this;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private <>c__DisplayClass2_0 <>8__1;

		[Token(Token = "0x17000115")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x1FF2A10", Offset = "0x1FF2A10", VA = "0x1FF2A10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000116")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000644")]
			[Address(RVA = "0x1FF2A58", Offset = "0x1FF2A58", VA = "0x1FF2A58", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x1FF2724", Offset = "0x1FF2724", VA = "0x1FF2724")]
		[DebuggerHidden]
		public <MusicSetup>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x1FF2750", Offset = "0x1FF2750", VA = "0x1FF2750", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x1FF2754", Offset = "0x1FF2754", VA = "0x1FF2754", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x1FF2A18", Offset = "0x1FF2A18", VA = "0x1FF2A18", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400059F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private PicNicArea picnicArea;

	[Token(Token = "0x6000637")]
	[Address(RVA = "0x1F2C750", Offset = "0x1F2C750", VA = "0x1F2C750", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000638")]
	[Address(RVA = "0x1F2C7EC", Offset = "0x1F2C7EC", VA = "0x1F2C7EC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB440C", Offset = "0xAB440C")]
	private IEnumerator MusicSetup()
	{
		return null;
	}

	[Token(Token = "0x6000639")]
	[Address(RVA = "0x1F2C858", Offset = "0x1F2C858", VA = "0x1F2C858")]
	public void AddMusicIntensity(int _stage)
	{
	}

	[Token(Token = "0x600063A")]
	[Address(RVA = "0x1F2CA3C", Offset = "0x1F2CA3C", VA = "0x1F2CA3C", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x600063B")]
	[Address(RVA = "0x1F2CAC4", Offset = "0x1F2CAC4", VA = "0x1F2CAC4", Slot = "19")]
	public override void GameFinished([Optional] string finishText, bool won = true, LosingReason reason = LosingReason.Null)
	{
	}

	[Token(Token = "0x600063C")]
	[Address(RVA = "0x1F2CAF0", Offset = "0x1F2CAF0", VA = "0x1F2CAF0")]
	public Level5GPM()
	{
	}
}
[Token(Token = "0x2000105")]
public class Level6GPM : GamePlayManager
{
	[Token(Token = "0x2000106")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAA78", Offset = "0xAAAA78")]
	private sealed class <WaitUntilLevelStart>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level6GPM <>4__this;

		[Token(Token = "0x17000117")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600064D")]
			[Address(RVA = "0x1FF2BEC", Offset = "0x1FF2BEC", VA = "0x1FF2BEC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000118")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600064F")]
			[Address(RVA = "0x1FF2C34", Offset = "0x1FF2C34", VA = "0x1FF2C34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x1FF2A60", Offset = "0x1FF2A60", VA = "0x1FF2A60")]
		[DebuggerHidden]
		public <WaitUntilLevelStart>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x1FF2A8C", Offset = "0x1FF2A8C", VA = "0x1FF2A8C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x1FF2A90", Offset = "0x1FF2A90", VA = "0x1FF2A90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x1FF2BF4", Offset = "0x1FF2BF4", VA = "0x1FF2BF4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000645")]
	[Address(RVA = "0x1F2CAF4", Offset = "0x1F2CAF4", VA = "0x1F2CAF4", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000646")]
	[Address(RVA = "0x1F2CB28", Offset = "0x1F2CB28", VA = "0x1F2CB28")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB44BC", Offset = "0xAB44BC")]
	private IEnumerator WaitUntilLevelStart()
	{
		return null;
	}

	[Token(Token = "0x6000647")]
	[Address(RVA = "0x1F2CB94", Offset = "0x1F2CB94", VA = "0x1F2CB94", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x6000648")]
	[Address(RVA = "0x1F2CC2C", Offset = "0x1F2CC2C", VA = "0x1F2CC2C")]
	public Level6GPM()
	{
	}

	[Token(Token = "0x6000649")]
	[Address(RVA = "0x1F2CC30", Offset = "0x1F2CC30", VA = "0x1F2CC30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB451C", Offset = "0xAB451C")]
	private bool <WaitUntilLevelStart>b__1_0()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000107")]
public class Level7GPM : GamePlayManager
{
	[Token(Token = "0x2000108")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAA88", Offset = "0xAAAA88")]
	private sealed class <WaitUntilLevelStart>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level7GPM <>4__this;

		[Token(Token = "0x17000119")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000658")]
			[Address(RVA = "0x1FF2D78", Offset = "0x1FF2D78", VA = "0x1FF2D78", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600065A")]
			[Address(RVA = "0x1FF2DC0", Offset = "0x1FF2DC0", VA = "0x1FF2DC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x1FF2C3C", Offset = "0x1FF2C3C", VA = "0x1FF2C3C")]
		[DebuggerHidden]
		public <WaitUntilLevelStart>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x1FF2C68", Offset = "0x1FF2C68", VA = "0x1FF2C68", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x1FF2C6C", Offset = "0x1FF2C6C", VA = "0x1FF2C6C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x1FF2D80", Offset = "0x1FF2D80", VA = "0x1FF2D80", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40005A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public AudioHandler quokkaTutorialAudioHandler;

	[Token(Token = "0x6000650")]
	[Address(RVA = "0x1F2CC68", Offset = "0x1F2CC68", VA = "0x1F2CC68", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000651")]
	[Address(RVA = "0x1F2CD30", Offset = "0x1F2CD30", VA = "0x1F2CD30")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB457C", Offset = "0xAB457C")]
	private IEnumerator WaitUntilLevelStart()
	{
		return null;
	}

	[Token(Token = "0x6000652")]
	[Address(RVA = "0x1F2CD9C", Offset = "0x1F2CD9C", VA = "0x1F2CD9C", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x6000653")]
	[Address(RVA = "0x1F2CE34", Offset = "0x1F2CE34", VA = "0x1F2CE34")]
	public Level7GPM()
	{
	}

	[Token(Token = "0x6000654")]
	[Address(RVA = "0x1F2CE38", Offset = "0x1F2CE38", VA = "0x1F2CE38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB45DC", Offset = "0xAB45DC")]
	private bool <WaitUntilLevelStart>b__2_0()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000109")]
public class Level8GPM : GamePlayManager
{
	[Token(Token = "0x200010A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAA98", Offset = "0xAAAA98")]
	private sealed class <WaitUntilLevelStart>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Level8GPM <>4__this;

		[Token(Token = "0x1700011B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000663")]
			[Address(RVA = "0x1FF2F54", Offset = "0x1FF2F54", VA = "0x1FF2F54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000665")]
			[Address(RVA = "0x1FF2F9C", Offset = "0x1FF2F9C", VA = "0x1FF2F9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x1FF2DC8", Offset = "0x1FF2DC8", VA = "0x1FF2DC8")]
		[DebuggerHidden]
		public <WaitUntilLevelStart>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x1FF2DF4", Offset = "0x1FF2DF4", VA = "0x1FF2DF4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x1FF2DF8", Offset = "0x1FF2DF8", VA = "0x1FF2DF8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x1FF2F5C", Offset = "0x1FF2F5C", VA = "0x1FF2F5C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x600065B")]
	[Address(RVA = "0x1F2CE70", Offset = "0x1F2CE70", VA = "0x1F2CE70", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600065C")]
	[Address(RVA = "0x1F2CEA4", Offset = "0x1F2CEA4", VA = "0x1F2CEA4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB463C", Offset = "0xAB463C")]
	private IEnumerator WaitUntilLevelStart()
	{
		return null;
	}

	[Token(Token = "0x600065D")]
	[Address(RVA = "0x1F2CF10", Offset = "0x1F2CF10", VA = "0x1F2CF10", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x600065E")]
	[Address(RVA = "0x1F2CFA8", Offset = "0x1F2CFA8", VA = "0x1F2CFA8")]
	public Level8GPM()
	{
	}

	[Token(Token = "0x600065F")]
	[Address(RVA = "0x1F2CFAC", Offset = "0x1F2CFAC", VA = "0x1F2CFAC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB469C", Offset = "0xAB469C")]
	private bool <WaitUntilLevelStart>b__1_0()
	{
		return default(bool);
	}
}
[Token(Token = "0x200010B")]
public class Level9GPM : GamePlayManager
{
	[Token(Token = "0x6000666")]
	[Address(RVA = "0x1F2CFE4", Offset = "0x1F2CFE4", VA = "0x1F2CFE4", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x6000667")]
	[Address(RVA = "0x1F2D080", Offset = "0x1F2D080", VA = "0x1F2D080")]
	public Level9GPM()
	{
	}
}
[Token(Token = "0x200010C")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xAAAAA8", Offset = "0xAAAAA8")]
public class LevelInfo : ScriptableObject
{
	[Token(Token = "0x200010D")]
	public enum ObjectiveKeys
	{
		[Token(Token = "0x40005B7")]
		WhackXEnemies,
		[Token(Token = "0x40005B8")]
		CatchXBoomerangs,
		[Token(Token = "0x40005B9")]
		LookAwesome,
		[Token(Token = "0x40005BA")]
		DontLoseDrinks,
		[Token(Token = "0x40005BB")]
		KeepXDrinksCold,
		[Token(Token = "0x40005BC")]
		DontThrowBoomerangs,
		[Token(Token = "0x40005BD")]
		CatchAllBoomerangsYouThrow,
		[Token(Token = "0x40005BE")]
		DontLoseHP,
		[Token(Token = "0x40005BF")]
		PunchBigKangarooXTimes,
		[Token(Token = "0x40005C0")]
		DontHurtKoalas,
		[Token(Token = "0x40005C1")]
		ServeXDrinks,
		[Token(Token = "0x40005C2")]
		PhotographXQuokkas,
		[Token(Token = "0x40005C3")]
		DontLetParachutersTouchTheGround,
		[Token(Token = "0x40005C4")]
		DontMissAnyRequest,
		[Token(Token = "0x40005C5")]
		ServeXRequests,
		[Token(Token = "0x40005C6")]
		ServeXBurgers,
		[Token(Token = "0x40005C7")]
		ServeXSnags,
		[Token(Token = "0x40005C8")]
		ServeXSkewers,
		[Token(Token = "0x40005C9")]
		StayWithinPicnicArea,
		[Token(Token = "0x40005CA")]
		DontCatchAnyBoomerangsYouThrow,
		[Token(Token = "0x40005CB")]
		DontBreakAnyBottle,
		[Token(Token = "0x40005CC")]
		LoseLessThanXDrinks,
		[Token(Token = "0x40005CD")]
		DefeatX,
		[Token(Token = "0x40005CE")]
		ServeYourFriends,
		[Token(Token = "0x40005CF")]
		ProtectYourDrinks,
		[Token(Token = "0x40005D0")]
		DontGetKnockedOut,
		[Token(Token = "0x40005D1")]
		WhackEnemies,
		[Token(Token = "0x40005D2")]
		HitXTargets,
		[Token(Token = "0x40005D3")]
		SaveAustraliasHonor,
		[Token(Token = "0x40005D4")]
		PutAnEndToTheMeme,
		[Token(Token = "0x40005D5")]
		WatchTrailer,
		[Token(Token = "0x40005D6")]
		CatchABoomerang,
		[Token(Token = "0x40005D7")]
		DefeatCanGuru,
		[Token(Token = "0x40005D8")]
		DefeatMole,
		[Token(Token = "0x40005D9")]
		DefeatEmu
	}

	[Serializable]
	[Token(Token = "0x200010E")]
	public class Objective
	{
		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ObjectiveKeys key;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string xValue;

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x1FF2FB4", Offset = "0x1FF2FB4", VA = "0x1FF2FB4")]
		public Objective()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200010F")]
	public class LosingConditions
	{
		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int gameDurationSeconds;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int beersToLose;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int requestsToLose;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[HideInInspector]
		public int playerHealth;

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x1FF2FA4", Offset = "0x1FF2FA4", VA = "0x1FF2FA4")]
		public LosingConditions()
		{
		}
	}

	[Token(Token = "0x40005AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAAB96C", Offset = "0xAAB96C")]
	public bool attemptOfBBQ;

	[Token(Token = "0x40005B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int numberOfLevel;

	[Token(Token = "0x40005B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string nameOfScene;

	[Token(Token = "0x40005B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public string nameOfLevel;

	[Token(Token = "0x40005B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public LosingConditions levelConditions;

	[Token(Token = "0x40005B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool bossFight;

	[Token(Token = "0x40005B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Objective[] levelOjectives;

	[Token(Token = "0x1700011D")]
	public int levelDuration
	{
		[Token(Token = "0x6000668")]
		[Address(RVA = "0x1F2334C", Offset = "0x1F2334C", VA = "0x1F2334C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000669")]
	[Address(RVA = "0x1F25978", Offset = "0x1F25978", VA = "0x1F25978")]
	public void SetObjectiveText(int objectiveIndex, TextMeshProUGUI tmp)
	{
	}

	[Token(Token = "0x600066A")]
	[Address(RVA = "0x1F2D320", Offset = "0x1F2D320", VA = "0x1F2D320")]
	public void SetTitleText(TextMeshProUGUI tmp)
	{
	}

	[Token(Token = "0x600066B")]
	[Address(RVA = "0x1F2D3D0", Offset = "0x1F2D3D0", VA = "0x1F2D3D0")]
	public LevelInfo()
	{
	}
}
[Token(Token = "0x2000110")]
public class Tutorial1GPM : GamePlayManager
{
	[Token(Token = "0x40005E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public int nOfEnemiesForGameFinish;

	[Token(Token = "0x40005E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public GameObject targetCounterPrefab;

	[Token(Token = "0x40005E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private int hitCounter;

	[Token(Token = "0x40005E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAAB9C4", Offset = "0xAAB9C4")]
	public bool hasCaughtBoomerang;

	[Token(Token = "0x600066E")]
	[Address(RVA = "0x1F3F6A0", Offset = "0x1F3F6A0", VA = "0x1F3F6A0", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600066F")]
	[Address(RVA = "0x1F3F858", Offset = "0x1F3F858", VA = "0x1F3F858", Slot = "20")]
	protected override int ObjectivesComplete()
	{
		return default(int);
	}

	[Token(Token = "0x6000670")]
	[Address(RVA = "0x1F3F8B8", Offset = "0x1F3F8B8", VA = "0x1F3F8B8")]
	public void CountTargetsHit(Enemy _enemy)
	{
	}

	[Token(Token = "0x6000671")]
	[Address(RVA = "0x1F3FACC", Offset = "0x1F3FACC", VA = "0x1F3FACC")]
	private void OnBoomerangCatch(Boomerang _boomerang)
	{
	}

	[Token(Token = "0x6000672")]
	[Address(RVA = "0x1F3FAD8", Offset = "0x1F3FAD8", VA = "0x1F3FAD8", Slot = "11")]
	protected override void KillEnemy(Enemy _enemy)
	{
	}

	[Token(Token = "0x6000673")]
	[Address(RVA = "0x1F3FB24", Offset = "0x1F3FB24", VA = "0x1F3FB24")]
	private void FinishTutorial()
	{
	}

	[Token(Token = "0x6000674")]
	[Address(RVA = "0x1F3FB84", Offset = "0x1F3FB84", VA = "0x1F3FB84")]
	public void LitteredApple()
	{
	}

	[Token(Token = "0x6000675")]
	[Address(RVA = "0x1F3FC4C", Offset = "0x1F3FC4C", VA = "0x1F3FC4C")]
	public Tutorial1GPM()
	{
	}
}
[Token(Token = "0x2000111")]
public class AussiePlayer : Singleton<AussiePlayer>
{
	[Token(Token = "0x40005E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CharacterController characterController;

	[Token(Token = "0x40005E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private HVRPlayerController playerController;

	[Token(Token = "0x40005E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private HVRPlayerInputs playerInputs;

	[Token(Token = "0x40005E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public HVRTeleporter playerTeleporter;

	[Token(Token = "0x40005E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI subtitlesHolder;

	[Token(Token = "0x40005E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	public HVRHandGrabber rightHand;

	[Token(Token = "0x40005EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	public HVRHandGrabber leftHand;

	[Token(Token = "0x40005EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<HVRUIPointer> pointersToEnableOnUnpause;

	[Token(Token = "0x40005EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<Canvas> canvasToEnableOnUnpause;

	[Token(Token = "0x40005ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<Canvas> allHandCanvases;

	[Token(Token = "0x40005EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<Collider> handColliders;

	[Token(Token = "0x40005EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Material handMaterial;

	[Token(Token = "0x6000676")]
	[Address(RVA = "0x1EA7624", Offset = "0x1EA7624", VA = "0x1EA7624")]
	private void Start()
	{
	}

	[Token(Token = "0x6000677")]
	[Address(RVA = "0x1EA78AC", Offset = "0x1EA78AC", VA = "0x1EA78AC")]
	public void SetPlayerSettings()
	{
	}

	[Token(Token = "0x6000678")]
	[Address(RVA = "0x1EA10C4", Offset = "0x1EA10C4", VA = "0x1EA10C4")]
	public void DropEverything()
	{
	}

	[Token(Token = "0x6000679")]
	[Address(RVA = "0x1EA7AF0", Offset = "0x1EA7AF0", VA = "0x1EA7AF0")]
	private void FindHands()
	{
	}

	[Token(Token = "0x600067A")]
	[Address(RVA = "0x1EA7BAC", Offset = "0x1EA7BAC", VA = "0x1EA7BAC")]
	public void PauseHands()
	{
	}

	[Token(Token = "0x600067B")]
	[Address(RVA = "0x1EA7FA0", Offset = "0x1EA7FA0", VA = "0x1EA7FA0")]
	public void UnPauseHands()
	{
	}

	[Token(Token = "0x600067C")]
	[Address(RVA = "0x1EA7EA4", Offset = "0x1EA7EA4", VA = "0x1EA7EA4")]
	private List<Canvas> GetHandCanvas()
	{
		return null;
	}

	[Token(Token = "0x600067D")]
	[Address(RVA = "0x1EA82DC", Offset = "0x1EA82DC", VA = "0x1EA82DC")]
	private List<Collider> GetHandColliders()
	{
		return null;
	}

	[Token(Token = "0x600067E")]
	[Address(RVA = "0x1EA83D8", Offset = "0x1EA83D8", VA = "0x1EA83D8")]
	public AussiePlayer()
	{
	}
}
[Token(Token = "0x2000112")]
public class DontDestroyHatOnLoad : MonoBehaviour
{
	[Token(Token = "0x40005F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private HVRGrabbable hatGrabbable;

	[Token(Token = "0x40005F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject actualHat;

	[Token(Token = "0x600067F")]
	[Address(RVA = "0x1F1AD10", Offset = "0x1F1AD10", VA = "0x1F1AD10")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000680")]
	[Address(RVA = "0x1F1AD88", Offset = "0x1F1AD88", VA = "0x1F1AD88")]
	private void Start()
	{
	}

	[Token(Token = "0x6000681")]
	[Address(RVA = "0x1F1ADDC", Offset = "0x1F1ADDC", VA = "0x1F1ADDC")]
	private void OnLevelWasLoaded(int level)
	{
	}

	[Token(Token = "0x6000682")]
	[Address(RVA = "0x1F1AF70", Offset = "0x1F1AF70", VA = "0x1F1AF70")]
	public DontDestroyHatOnLoad()
	{
	}
}
[Token(Token = "0x2000113")]
public class HellLever : MonoBehaviour
{
	[Token(Token = "0x40005F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject failSign;

	[Token(Token = "0x6000683")]
	[Address(RVA = "0x1F277AC", Offset = "0x1F277AC", VA = "0x1F277AC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000684")]
	[Address(RVA = "0x1F2788C", Offset = "0x1F2788C", VA = "0x1F2788C")]
	private void OnHellLever(int i)
	{
	}

	[Token(Token = "0x6000685")]
	[Address(RVA = "0x1F27944", Offset = "0x1F27944", VA = "0x1F27944")]
	public HellLever()
	{
	}
}
[Token(Token = "0x2000114")]
public class HellPlane : MonoBehaviour
{
	[Token(Token = "0x40005F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool onHisWay;

	[Token(Token = "0x6000686")]
	[Address(RVA = "0x1F2794C", Offset = "0x1F2794C", VA = "0x1F2794C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000687")]
	[Address(RVA = "0x1F27A7C", Offset = "0x1F27A7C", VA = "0x1F27A7C")]
	public HellPlane()
	{
	}
}
[Token(Token = "0x2000115")]
public class MusicInstrument : MonoBehaviour
{
	[Token(Token = "0x40005F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private HVRGrabbable grabbable;

	[Token(Token = "0x40005F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioHandler AudioHandler;

	[Token(Token = "0x40005F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform headTransform;

	[Token(Token = "0x40005F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isPlaying;

	[Token(Token = "0x40005F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float distanceToTrigger;

	[Token(Token = "0x40005F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string soundName;

	[Token(Token = "0x40005FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject particlesObject;

	[Token(Token = "0x6000688")]
	[Address(RVA = "0x1F089A0", Offset = "0x1F089A0", VA = "0x1F089A0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000689")]
	[Address(RVA = "0x1F08A8C", Offset = "0x1F08A8C", VA = "0x1F08A8C")]
	private void Update()
	{
	}

	[Token(Token = "0x600068A")]
	[Address(RVA = "0x1F08BF8", Offset = "0x1F08BF8", VA = "0x1F08BF8")]
	public MusicInstrument()
	{
	}
}
[Token(Token = "0x2000116")]
public class PicNicArea : MonoBehaviour
{
	[Token(Token = "0x2000117")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAAF4", Offset = "0xAAAAF4")]
	private sealed class <WaitThenSetStartChecking>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float waitTime;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PicNicArea <>4__this;

		[Token(Token = "0x1700011E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x1FF7920", Offset = "0x1FF7920", VA = "0x1FF7920", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x1FF7968", Offset = "0x1FF7968", VA = "0x1FF7968", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x1FF7838", Offset = "0x1FF7838", VA = "0x1FF7838")]
		[DebuggerHidden]
		public <WaitThenSetStartChecking>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x1FF7864", Offset = "0x1FF7864", VA = "0x1FF7864", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x1FF7868", Offset = "0x1FF7868", VA = "0x1FF7868", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x1FF7928", Offset = "0x1FF7928", VA = "0x1FF7928", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40005FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool leftArea;

	[Token(Token = "0x40005FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool startChecking;

	[Token(Token = "0x600068B")]
	[Address(RVA = "0x1F0BE18", Offset = "0x1F0BE18", VA = "0x1F0BE18")]
	private void Start()
	{
	}

	[Token(Token = "0x600068C")]
	[Address(RVA = "0x1F0BEC4", Offset = "0x1F0BEC4", VA = "0x1F0BEC4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600068D")]
	[Address(RVA = "0x1F0BE48", Offset = "0x1F0BE48", VA = "0x1F0BE48")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB46FC", Offset = "0xAB46FC")]
	private IEnumerator WaitThenSetStartChecking(float waitTime)
	{
		return null;
	}

	[Token(Token = "0x600068E")]
	[Address(RVA = "0x1F0BED8", Offset = "0x1F0BED8", VA = "0x1F0BED8")]
	public PicNicArea()
	{
	}
}
[Token(Token = "0x2000118")]
public class SetAimToPlayer : MonoBehaviour
{
	[Token(Token = "0x4000601")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MultiAimConstraint multiAimConstraint;

	[Token(Token = "0x4000602")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RigBuilder rigBuilder;

	[Token(Token = "0x4000603")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAABA1C", Offset = "0xAABA1C")]
	public float weight;

	[Token(Token = "0x6000695")]
	[Address(RVA = "0x1F1700C", Offset = "0x1F1700C", VA = "0x1F1700C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000696")]
	[Address(RVA = "0x1F17060", Offset = "0x1F17060", VA = "0x1F17060")]
	private void Start()
	{
	}

	[Token(Token = "0x6000697")]
	[Address(RVA = "0x1F171DC", Offset = "0x1F171DC", VA = "0x1F171DC")]
	public SetAimToPlayer()
	{
	}
}
[Token(Token = "0x2000119")]
[DisallowMultipleComponent]
public class SteamManager : MonoBehaviour
{
	[Token(Token = "0x17000120")]
	public static bool Initialized
	{
		[Token(Token = "0x6000698")]
		[Address(RVA = "0x1F18790", Offset = "0x1F18790", VA = "0x1F18790")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000699")]
	[Address(RVA = "0x1F18798", Offset = "0x1F18798", VA = "0x1F18798")]
	public SteamManager()
	{
	}
}
[Token(Token = "0x200011A")]
public class ActivatableGrabIndicator : MonoBehaviour
{
	[Token(Token = "0x4000604")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject grabIndicator;

	[Token(Token = "0x4000605")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Image icon;

	[Token(Token = "0x4000606")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Sprite> optionalIconPerChildren;

	[Token(Token = "0x600069A")]
	[Address(RVA = "0x1E9FF84", Offset = "0x1E9FF84", VA = "0x1E9FF84")]
	private void Start()
	{
	}

	[Token(Token = "0x600069B")]
	[Address(RVA = "0x1EA0028", Offset = "0x1EA0028", VA = "0x1EA0028")]
	public void Activate()
	{
	}

	[Token(Token = "0x600069C")]
	[Address(RVA = "0x1EA0048", Offset = "0x1EA0048", VA = "0x1EA0048")]
	public void Deactivate()
	{
	}

	[Token(Token = "0x600069D")]
	[Address(RVA = "0x1EA0068", Offset = "0x1EA0068", VA = "0x1EA0068")]
	public void ShowGrabIndicator()
	{
	}

	[Token(Token = "0x600069E")]
	[Address(RVA = "0x1EA0148", Offset = "0x1EA0148", VA = "0x1EA0148")]
	public void HideGrabIndicator()
	{
	}

	[Token(Token = "0x600069F")]
	[Address(RVA = "0x1EA0168", Offset = "0x1EA0168", VA = "0x1EA0168")]
	public ActivatableGrabIndicator()
	{
	}
}
[Token(Token = "0x200011B")]
public enum ArcadeMode
{
	[Token(Token = "0x4000608")]
	DEFENSE,
	[Token(Token = "0x4000609")]
	COOKING,
	[Token(Token = "0x400060A")]
	TUTORIAL
}
[Token(Token = "0x200011C")]
public enum ScoreType
{
	[Token(Token = "0x400060C")]
	INT,
	[Token(Token = "0x400060D")]
	TIME
}
[Token(Token = "0x200011D")]
public enum OnlineLeaderboardType
{
	[Token(Token = "0x400060F")]
	NONE,
	[Token(Token = "0x4000610")]
	GLOBAL_RANK,
	[Token(Token = "0x4000611")]
	AROUND_ME,
	[Token(Token = "0x4000612")]
	FRIENDS,
	[Token(Token = "0x4000613")]
	FRIENDS_AROUND_ME
}
[Token(Token = "0x200011E")]
public class ArcadeMenuUI : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200011F")]
	public class ArcadeModeDetails
	{
		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ArcadeMode mode;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LevelInfo arcadeInfo;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Toggle modeButton;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool isLocked;

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x1F4852C", Offset = "0x1F4852C", VA = "0x1F4852C")]
		public ArcadeModeDetails()
		{
		}
	}

	[Token(Token = "0x2000120")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAB14", Offset = "0xAAAB14")]
	private sealed class <>c__DisplayClass20_0
	{
		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ArcadeModeDetails details;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ArcadeMenuUI <>4__this;

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x1F484F8", Offset = "0x1F484F8", VA = "0x1F484F8")]
		public <>c__DisplayClass20_0()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x1F48500", Offset = "0x1F48500", VA = "0x1F48500")]
		internal void <Start>b__0(bool value)
		{
		}
	}

	[Token(Token = "0x4000614")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject arcadeDetailsMenu;

	[Token(Token = "0x4000615")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI arcadeDetailsTitle;

	[Token(Token = "0x4000616")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI arcadeDetailsObj1;

	[Token(Token = "0x4000617")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI arcadeDetailsObj2;

	[Token(Token = "0x4000618")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI arcadeDetailsObj3;

	[Token(Token = "0x4000619")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI playerHealth;

	[Token(Token = "0x400061A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI beersToLose;

	[Token(Token = "0x400061B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextMeshProUGUI requestsToLose;

	[Token(Token = "0x400061C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[HideInInspector]
	private Animator arcadeDetailsAnimator;

	[Token(Token = "0x400061D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int arcadeStartWaveIndex;

	[Token(Token = "0x400061E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TextMeshProUGUI arcadeStartWaveNumber;

	[Token(Token = "0x400061F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Button arcadeStartWaveIncrease;

	[Token(Token = "0x4000620")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Button arcadeStartWaveDecrease;

	[Token(Token = "0x4000621")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private int[] arcadeStartWaveOptions;

	[Token(Token = "0x4000622")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<ArcadeModeDetails> arcadeModeDetails;

	[Token(Token = "0x4000623")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public ArcadeModeDetails selectedMode;

	[Token(Token = "0x4000624")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public OnlineLeaderboard onlineLeaderboard;

	[Token(Token = "0x4000625")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public LocalLeaderboard localLeaderboard;

	[Token(Token = "0x4000626")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private bool hideOnlineLeaderboard;

	[Token(Token = "0x60006A0")]
	[Address(RVA = "0x1EA1ECC", Offset = "0x1EA1ECC", VA = "0x1EA1ECC")]
	private void Start()
	{
	}

	[Token(Token = "0x60006A1")]
	[Address(RVA = "0x1EA25C8", Offset = "0x1EA25C8", VA = "0x1EA25C8")]
	private void ToggleValueChanged(ArcadeModeDetails mode, bool value)
	{
	}

	[Token(Token = "0x60006A2")]
	[Address(RVA = "0x1EA22B4", Offset = "0x1EA22B4", VA = "0x1EA22B4")]
	public void ChangeArcadeMode(ArcadeModeDetails mode)
	{
	}

	[Token(Token = "0x60006A3")]
	[Address(RVA = "0x1EA267C", Offset = "0x1EA267C", VA = "0x1EA267C")]
	private void ResetStartWave()
	{
	}

	[Token(Token = "0x60006A4")]
	[Address(RVA = "0x1EA2818", Offset = "0x1EA2818", VA = "0x1EA2818")]
	public void IncreaseStartWave()
	{
	}

	[Token(Token = "0x60006A5")]
	[Address(RVA = "0x1EA29CC", Offset = "0x1EA29CC", VA = "0x1EA29CC")]
	public void DecreaseStartWave()
	{
	}

	[Token(Token = "0x60006A6")]
	[Address(RVA = "0x1EA2A9C", Offset = "0x1EA2A9C", VA = "0x1EA2A9C")]
	public void StartArcade()
	{
	}

	[Token(Token = "0x60006A7")]
	[Address(RVA = "0x1EA25D4", Offset = "0x1EA25D4", VA = "0x1EA25D4")]
	private Animator GetArcadeDetailsAnimator()
	{
		return null;
	}

	[Token(Token = "0x60006A8")]
	[Address(RVA = "0x1EA2BAC", Offset = "0x1EA2BAC", VA = "0x1EA2BAC")]
	private void UpdateSignsLanguage()
	{
	}

	[Token(Token = "0x60006A9")]
	[Address(RVA = "0x1EA2CB0", Offset = "0x1EA2CB0", VA = "0x1EA2CB0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60006AA")]
	[Address(RVA = "0x1EA2E18", Offset = "0x1EA2E18", VA = "0x1EA2E18")]
	public ArcadeMenuUI()
	{
	}
}
[Token(Token = "0x2000121")]
public class ArcadePointsDisplayer : MonoBehaviour
{
	[Token(Token = "0x2000122")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAB24", Offset = "0xAAAB24")]
	private sealed class <WaitToDestroy>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ArcadePointsDisplayer <>4__this;

		[Token(Token = "0x17000121")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x1F48648", Offset = "0x1F48648", VA = "0x1F48648", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000122")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x1F48690", Offset = "0x1F48690", VA = "0x1F48690", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x1F48534", Offset = "0x1F48534", VA = "0x1F48534")]
		[DebuggerHidden]
		public <WaitToDestroy>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x1F48560", Offset = "0x1F48560", VA = "0x1F48560", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x1F48564", Offset = "0x1F48564", VA = "0x1F48564", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x1F48650", Offset = "0x1F48650", VA = "0x1F48650", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400062E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI pointsText;

	[Token(Token = "0x400062F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI multiplierText;

	[Token(Token = "0x4000630")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI adderText;

	[Token(Token = "0x4000631")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Color[] colorPerMultiplier;

	[Token(Token = "0x4000632")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Image multiplierBG;

	[Token(Token = "0x4000633")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject particles;

	[Token(Token = "0x60006AE")]
	[Address(RVA = "0x1EA1B6C", Offset = "0x1EA1B6C", VA = "0x1EA1B6C")]
	public void DisplayPoints(int points, int multiplier, int extraPoints)
	{
	}

	[Token(Token = "0x60006AF")]
	[Address(RVA = "0x1EA1760", Offset = "0x1EA1760", VA = "0x1EA1760")]
	public void DisplayPoints(int points, int multiplier)
	{
	}

	[Token(Token = "0x60006B0")]
	[Address(RVA = "0x1EA2E98", Offset = "0x1EA2E98", VA = "0x1EA2E98")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB47AC", Offset = "0xAB47AC")]
	private IEnumerator WaitToDestroy()
	{
		return null;
	}

	[Token(Token = "0x60006B1")]
	[Address(RVA = "0x1EA3170", Offset = "0x1EA3170", VA = "0x1EA3170")]
	public ArcadePointsDisplayer()
	{
	}
}
[Token(Token = "0x2000123")]
public class AudioSettingsSlider : MonoBehaviour
{
	[Token(Token = "0x4000637")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Slider slider;

	[Token(Token = "0x4000638")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI valueText;

	[Token(Token = "0x4000639")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SoundType soundType;

	[Token(Token = "0x400063A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioHandler[] audioHandlers;

	[Token(Token = "0x400063B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int initialValue;

	[Token(Token = "0x60006B8")]
	[Address(RVA = "0x1EA6630", Offset = "0x1EA6630", VA = "0x1EA6630")]
	public void Start()
	{
	}

	[Token(Token = "0x60006B9")]
	[Address(RVA = "0x1EA67AC", Offset = "0x1EA67AC", VA = "0x1EA67AC")]
	private AudioHandler[] GetAudioHandlers()
	{
		return null;
	}

	[Token(Token = "0x60006BA")]
	[Address(RVA = "0x1EA693C", Offset = "0x1EA693C", VA = "0x1EA693C")]
	private float TranslateToFloat(int _value)
	{
		return default(float);
	}

	[Token(Token = "0x60006BB")]
	[Address(RVA = "0x1EA6760", Offset = "0x1EA6760", VA = "0x1EA6760")]
	private int TranslateToInt(float _value)
	{
		return default(int);
	}

	[Token(Token = "0x60006BC")]
	[Address(RVA = "0x1EA6974", Offset = "0x1EA6974", VA = "0x1EA6974")]
	private void UpdateSoundVolume(float multipler)
	{
	}

	[Token(Token = "0x60006BD")]
	[Address(RVA = "0x1EA6A10", Offset = "0x1EA6A10", VA = "0x1EA6A10")]
	public void UpdateValue()
	{
	}

	[Token(Token = "0x60006BE")]
	[Address(RVA = "0x1EA6BA4", Offset = "0x1EA6BA4", VA = "0x1EA6BA4")]
	public AudioSettingsSlider()
	{
	}

	[Token(Token = "0x60006BF")]
	[Address(RVA = "0x1EA6BAC", Offset = "0x1EA6BAC", VA = "0x1EA6BAC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB485C", Offset = "0xAB485C")]
	private bool <GetAudioHandlers>b__6_0(AudioHandler h)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000124")]
public class ChangeHandMaterial : MonoBehaviour
{
	[Token(Token = "0x400063C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private FlexibleColorPicker colorPicker;

	[Token(Token = "0x400063D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<UpdateHandMaterial> handMaterials;

	[Token(Token = "0x60006C0")]
	[Address(RVA = "0x1EB1EE0", Offset = "0x1EB1EE0", VA = "0x1EB1EE0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60006C1")]
	[Address(RVA = "0x1EB1FA0", Offset = "0x1EB1FA0", VA = "0x1EB1FA0")]
	public void ColorChange(Color color)
	{
	}

	[Token(Token = "0x60006C2")]
	[Address(RVA = "0x1EB2270", Offset = "0x1EB2270", VA = "0x1EB2270")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60006C3")]
	[Address(RVA = "0x1EB2198", Offset = "0x1EB2198", VA = "0x1EB2198")]
	private List<UpdateHandMaterial> GetUpdateHandMaterials()
	{
		return null;
	}

	[Token(Token = "0x60006C4")]
	[Address(RVA = "0x1EB2314", Offset = "0x1EB2314", VA = "0x1EB2314")]
	public ChangeHandMaterial()
	{
	}
}
[Token(Token = "0x2000125")]
public class CloneRequestSlotsFinder : MonoBehaviour
{
	[Token(Token = "0x60006C5")]
	[Address(RVA = "0x1EB231C", Offset = "0x1EB231C", VA = "0x1EB231C")]
	private void Start()
	{
	}

	[Token(Token = "0x60006C6")]
	[Address(RVA = "0x1EB2320", Offset = "0x1EB2320", VA = "0x1EB2320")]
	private void Update()
	{
	}

	[Token(Token = "0x60006C7")]
	[Address(RVA = "0x1EB2324", Offset = "0x1EB2324", VA = "0x1EB2324")]
	public CloneRequestSlotsFinder()
	{
	}
}
[Token(Token = "0x2000126")]
public class Credits : MonoBehaviour
{
	[Token(Token = "0x2000127")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAB34", Offset = "0xAAAB34")]
	private sealed class <ChangePage>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Credits <>4__this;

		[Token(Token = "0x17000123")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x1F4E4C8", Offset = "0x1F4E4C8", VA = "0x1F4E4C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000124")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x1F4E510", Offset = "0x1F4E510", VA = "0x1F4E510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x1F4E208", Offset = "0x1F4E208", VA = "0x1F4E208")]
		[DebuggerHidden]
		public <ChangePage>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x1F4E234", Offset = "0x1F4E234", VA = "0x1F4E234", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x1F4E238", Offset = "0x1F4E238", VA = "0x1F4E238", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x1F4E4D0", Offset = "0x1F4E4D0", VA = "0x1F4E4D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400063E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float timeUntilFirstChange;

	[Token(Token = "0x400063F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float timeBetweenCredits;

	[Token(Token = "0x4000640")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Animator animator;

	[Token(Token = "0x4000641")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0xAABA44", Offset = "0xAABA44")]
	public List<string> creditsPages;

	[Token(Token = "0x4000642")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<string[]> _creditsPageSplit;

	[Token(Token = "0x4000643")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int currentPage;

	[Token(Token = "0x4000644")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private TextMeshProUGUI[] lines;

	[Token(Token = "0x60006C8")]
	[Address(RVA = "0x1EB3B70", Offset = "0x1EB3B70", VA = "0x1EB3B70")]
	private void Start()
	{
	}

	[Token(Token = "0x60006C9")]
	[Address(RVA = "0x1EB3EC0", Offset = "0x1EB3EC0", VA = "0x1EB3EC0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB486C", Offset = "0xAB486C")]
	private IEnumerator ChangePage(float delay)
	{
		return null;
	}

	[Token(Token = "0x60006CA")]
	[Address(RVA = "0x1EB3F3C", Offset = "0x1EB3F3C", VA = "0x1EB3F3C")]
	private void Translate(string _text, TextMeshProUGUI _line)
	{
	}

	[Token(Token = "0x60006CB")]
	[Address(RVA = "0x1EB415C", Offset = "0x1EB415C", VA = "0x1EB415C")]
	public Credits()
	{
	}
}
[Token(Token = "0x2000128")]
public class DisplayUnlockedItem : MonoBehaviour
{
	[Token(Token = "0x2000129")]
	public enum ItemsToUnlock
	{
		[Token(Token = "0x400064F")]
		None,
		[Token(Token = "0x4000650")]
		Beer_skin_2,
		[Token(Token = "0x4000651")]
		Beer_skin_3,
		[Token(Token = "0x4000652")]
		Beer_skin_4,
		[Token(Token = "0x4000653")]
		Beer_skin_5,
		[Token(Token = "0x4000654")]
		Boomerang_2,
		[Token(Token = "0x4000655")]
		Boomerang_3,
		[Token(Token = "0x4000656")]
		Boomerang_4,
		[Token(Token = "0x4000657")]
		Boomerang_5
	}

	[Serializable]
	[Token(Token = "0x200012A")]
	public class Item
	{
		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ItemsToUnlock itemType;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int starsToUnlock;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material material;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BeerSkin skin;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Mesh mesh;

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x1F4F360", Offset = "0x1F4F360", VA = "0x1F4F360")]
		public Item()
		{
		}
	}

	[Token(Token = "0x4000649")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Item> availableItems;

	[Token(Token = "0x400064A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Item possibleItemToUnlock;

	[Token(Token = "0x400064B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int starsBeforeLevel;

	[Token(Token = "0x400064C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int previousAttemptStars;

	[Token(Token = "0x400064D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public MeshRenderer itemRenderer;

	[Token(Token = "0x60006D2")]
	[Address(RVA = "0x1F1A398", Offset = "0x1F1A398", VA = "0x1F1A398")]
	private void Start()
	{
	}

	[Token(Token = "0x60006D3")]
	[Address(RVA = "0x1F1A8F0", Offset = "0x1F1A8F0", VA = "0x1F1A8F0")]
	public void CheckUnlockItem()
	{
	}

	[Token(Token = "0x60006D4")]
	[Address(RVA = "0x1F1AC60", Offset = "0x1F1AC60", VA = "0x1F1AC60")]
	public DisplayUnlockedItem()
	{
	}
}
[Token(Token = "0x200012B")]
public class FinishUI : MonoBehaviour
{
	[Token(Token = "0x400065D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAABA5C", Offset = "0xAABA5C")]
	public TextMeshProUGUI statsText;

	[Token(Token = "0x400065E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GamePlayManager gamePlayManager;

	[Token(Token = "0x60006D6")]
	[Address(RVA = "0x1F1ED74", Offset = "0x1F1ED74", VA = "0x1F1ED74")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60006D7")]
	[Address(RVA = "0x1F1F0C0", Offset = "0x1F1F0C0", VA = "0x1F1F0C0")]
	public FinishUI()
	{
	}
}
[Token(Token = "0x200012C")]
public class FinishedSign : MonoBehaviour
{
	[Token(Token = "0x400065F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI titleText;

	[Token(Token = "0x4000660")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject failedSign;

	[Token(Token = "0x4000661")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI failedSignText;

	[Token(Token = "0x4000662")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AudioHandler audioHandler;

	[Token(Token = "0x4000663")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Animator animator;

	[Token(Token = "0x4000664")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI[] objectivesTexts;

	[Token(Token = "0x4000665")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject[] objectivesChecks;

	[Token(Token = "0x4000666")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject[] stars;

	[Token(Token = "0x4000667")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject continueText;

	[Token(Token = "0x4000668")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject backToMenuText;

	[Token(Token = "0x4000669")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject levelConditionsBar;

	[Token(Token = "0x400066A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public TextMeshProUGUI levelTime;

	[Token(Token = "0x400066B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public TextMeshProUGUI healthLost;

	[Token(Token = "0x400066C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public TextMeshProUGUI beersLost;

	[Token(Token = "0x400066D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public TextMeshProUGUI requestsLost;

	[Token(Token = "0x400066E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public SpriteRenderer healthLostIcon;

	[Token(Token = "0x400066F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public SpriteRenderer beersLostIcon;

	[Token(Token = "0x4000670")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public SpriteRenderer requestsLostIcon;

	[Token(Token = "0x4000671")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public OnlineLeaderboard leaderboard;

	[Token(Token = "0x60006D8")]
	[Address(RVA = "0x1F1F0C8", Offset = "0x1F1F0C8", VA = "0x1F1F0C8")]
	public void ToggleText(bool _continue = true)
	{
	}

	[Token(Token = "0x60006D9")]
	[Address(RVA = "0x1F1F114", Offset = "0x1F1F114", VA = "0x1F1F114")]
	public void SetConditions(int[] _healthToLose, int[] _beersToLose, int[] _requestsTolose, string _levelTime, bool levelWithTime = true)
	{
	}

	[Token(Token = "0x60006DA")]
	[Address(RVA = "0x1F1F4C8", Offset = "0x1F1F4C8", VA = "0x1F1F4C8")]
	public void ShowFailedSign(string text)
	{
	}

	[Token(Token = "0x60006DB")]
	[Address(RVA = "0x1F1F848", Offset = "0x1F1F848", VA = "0x1F1F848")]
	public FinishedSign()
	{
	}
}
[Token(Token = "0x200012D")]
public class FloatOverObject : MonoBehaviour
{
	[Token(Token = "0x4000672")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform objectToFloatOver;

	[Token(Token = "0x4000673")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float distanceToFloat;

	[Token(Token = "0x4000674")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public Transform playerTransform;

	[Token(Token = "0x60006DC")]
	[Address(RVA = "0x1F1FAC4", Offset = "0x1F1FAC4", VA = "0x1F1FAC4")]
	private void Start()
	{
	}

	[Token(Token = "0x60006DD")]
	[Address(RVA = "0x1F1FB74", Offset = "0x1F1FB74", VA = "0x1F1FB74")]
	private void Update()
	{
	}

	[Token(Token = "0x60006DE")]
	[Address(RVA = "0x1F1FC68", Offset = "0x1F1FC68", VA = "0x1F1FC68")]
	public FloatOverObject()
	{
	}
}
[Token(Token = "0x200012E")]
public class GetStarNumber : MonoBehaviour
{
	[Token(Token = "0x60006DF")]
	[Address(RVA = "0x1F264AC", Offset = "0x1F264AC", VA = "0x1F264AC")]
	private void Start()
	{
	}

	[Token(Token = "0x60006E0")]
	[Address(RVA = "0x1F2659C", Offset = "0x1F2659C", VA = "0x1F2659C")]
	public GetStarNumber()
	{
	}
}
[Token(Token = "0x200012F")]
public class HeightAdjustmentSlider : MonoBehaviour
{
	[Token(Token = "0x4000675")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private HVRCameraRig cameraRig;

	[Token(Token = "0x4000676")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private HVRPlayerWaist playerWaist;

	[Token(Token = "0x4000677")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float originalWaistOffset;

	[Token(Token = "0x4000678")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Slider slider;

	[Token(Token = "0x4000679")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI valueText;

	[Token(Token = "0x400067A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float initialValue;

	[Token(Token = "0x400067B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public InstanceHeightAdjustment tableExample;

	[Token(Token = "0x400067C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public InstanceHeightAdjustment beerboxExample;

	[Token(Token = "0x400067D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public HeightAdjustmentOption targetInstance;

	[Token(Token = "0x400067E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float minValue;

	[Token(Token = "0x400067F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float maxValue;

	[Token(Token = "0x4000680")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAABAA4", Offset = "0xAABAA4")]
	public int multipler;

	[Token(Token = "0x4000681")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private AudioHandler audioHandler;

	[Token(Token = "0x60006E1")]
	[Address(RVA = "0x1F271E4", Offset = "0x1F271E4", VA = "0x1F271E4")]
	private void Start()
	{
	}

	[Token(Token = "0x60006E2")]
	[Address(RVA = "0x1F274C0", Offset = "0x1F274C0", VA = "0x1F274C0")]
	public void UpdateDisplayValue()
	{
	}

	[Token(Token = "0x60006E3")]
	[Address(RVA = "0x1F275F8", Offset = "0x1F275F8", VA = "0x1F275F8")]
	public void UpdateValue()
	{
	}

	[Token(Token = "0x60006E4")]
	[Address(RVA = "0x1F27790", Offset = "0x1F27790", VA = "0x1F27790")]
	public HeightAdjustmentSlider()
	{
	}
}
[Token(Token = "0x2000130")]
public class MainMenuLevelUI : MonoBehaviour
{
	[Token(Token = "0x4000682")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int currentlySelected;

	[Token(Token = "0x4000683")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LevelInfo levelInfo;

	[Token(Token = "0x4000684")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool amUnlocked;

	[Token(Token = "0x4000685")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool amVisible;

	[Token(Token = "0x4000686")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI Title;

	[Token(Token = "0x4000687")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI obj1;

	[Token(Token = "0x4000688")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI obj2;

	[Token(Token = "0x4000689")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI obj3;

	[Token(Token = "0x400068A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI levelDuration;

	[Token(Token = "0x400068B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextMeshProUGUI playerHealth;

	[Token(Token = "0x400068C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextMeshProUGUI beersToLose;

	[Token(Token = "0x400068D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TextMeshProUGUI requestsToLose;

	[Token(Token = "0x400068E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Button goButton;

	[Token(Token = "0x400068F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject levelSign;

	[Token(Token = "0x4000690")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAABADC", Offset = "0xAABADC")]
	public GameObject LockedLevelUI;

	[Token(Token = "0x4000691")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int starsNeededToUnlock;

	[Token(Token = "0x4000692")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Button levelBadge;

	[Token(Token = "0x4000693")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private string sceneToLoad;

	[Token(Token = "0x4000694")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private int numOfStars;

	[Token(Token = "0x4000695")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private bool unlocking;

	[Token(Token = "0x4000696")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAABB14", Offset = "0xAABB14")]
	public OnlineLeaderboard onlineLeaderboard;

	[Token(Token = "0x4000697")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TextMeshProUGUI leaderboardTitle;

	[Token(Token = "0x4000698")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public GameObject enableOnLevelSelect;

	[Token(Token = "0x4000699")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GameObject difficultySelector;

	[Token(Token = "0x60006E5")]
	[Address(RVA = "0x1F03484", Offset = "0x1F03484", VA = "0x1F03484")]
	private void Start()
	{
	}

	[Token(Token = "0x60006E6")]
	[Address(RVA = "0x1F03C04", Offset = "0x1F03C04", VA = "0x1F03C04")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60006E7")]
	[Address(RVA = "0x1F03C30", Offset = "0x1F03C30", VA = "0x1F03C30")]
	public void OnLevelClick()
	{
	}

	[Token(Token = "0x60006E8")]
	[Address(RVA = "0x1F04218", Offset = "0x1F04218", VA = "0x1F04218")]
	private void UpdateLeaderboard()
	{
	}

	[Token(Token = "0x60006E9")]
	[Address(RVA = "0x1F04570", Offset = "0x1F04570", VA = "0x1F04570")]
	private void LocalLoadScene()
	{
	}

	[Token(Token = "0x60006EA")]
	[Address(RVA = "0x1F03DC0", Offset = "0x1F03DC0", VA = "0x1F03DC0")]
	private void LevelSignPopsUp()
	{
	}

	[Token(Token = "0x60006EB")]
	[Address(RVA = "0x1F03E10", Offset = "0x1F03E10", VA = "0x1F03E10")]
	private void ChangeSignsAnimation()
	{
	}

	[Token(Token = "0x60006EC")]
	[Address(RVA = "0x1F03B34", Offset = "0x1F03B34", VA = "0x1F03B34")]
	private void HideMe()
	{
	}

	[Token(Token = "0x60006ED")]
	[Address(RVA = "0x1F0477C", Offset = "0x1F0477C", VA = "0x1F0477C")]
	public void UnlockLevel()
	{
	}

	[Token(Token = "0x60006EE")]
	[Address(RVA = "0x1F0486C", Offset = "0x1F0486C", VA = "0x1F0486C")]
	public void OnSettingsChnange()
	{
	}

	[Token(Token = "0x60006EF")]
	[Address(RVA = "0x1F045FC", Offset = "0x1F045FC", VA = "0x1F045FC")]
	public void UpdateLevelDuration()
	{
	}

	[Token(Token = "0x60006F0")]
	[Address(RVA = "0x1F03B5C", Offset = "0x1F03B5C", VA = "0x1F03B5C")]
	private void DisableLockedUI()
	{
	}

	[Token(Token = "0x60006F1")]
	[Address(RVA = "0x1F048FC", Offset = "0x1F048FC", VA = "0x1F048FC")]
	private void UpdateLevelName()
	{
	}

	[Token(Token = "0x60006F2")]
	[Address(RVA = "0x1F04A68", Offset = "0x1F04A68", VA = "0x1F04A68")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60006F3")]
	[Address(RVA = "0x1F04BD0", Offset = "0x1F04BD0", VA = "0x1F04BD0")]
	public MainMenuLevelUI()
	{
	}
}
[Token(Token = "0x2000131")]
public class PlayerUIWatch : Singleton<PlayerUIWatch>
{
	[Serializable]
	[Token(Token = "0x2000132")]
	public class RequestSlotClone
	{
		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Canvas requestCanvas;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI requestTime;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image requestIcon;

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x22CA7B8", Offset = "0x22CA7B8", VA = "0x22CA7B8")]
		public RequestSlotClone()
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000133")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAB44", Offset = "0xAAAB44")]
	private struct <>c__DisplayClass43_0
	{
		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Color color;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PlayerUIWatch <>4__this;
	}

	[Token(Token = "0x2000134")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAB54", Offset = "0xAAAB54")]
	private sealed class <BlinkUntilOpenedCoroutine>d__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlayerUIWatch <>4__this;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float delay;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private <>c__DisplayClass43_0 <>8__1;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float <time>5__2;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float <maxAlpha>5__3;

		[Token(Token = "0x17000125")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600070D")]
			[Address(RVA = "0x22CA768", Offset = "0x22CA768", VA = "0x22CA768", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000126")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600070F")]
			[Address(RVA = "0x22CA7B0", Offset = "0x22CA7B0", VA = "0x22CA7B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x22CA350", Offset = "0x22CA350", VA = "0x22CA350")]
		[DebuggerHidden]
		public <BlinkUntilOpenedCoroutine>d__43(int <>1__state)
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x22CA37C", Offset = "0x22CA37C", VA = "0x22CA37C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x22CA380", Offset = "0x22CA380", VA = "0x22CA380", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x22CA770", Offset = "0x22CA770", VA = "0x22CA770", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400069A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI watchTimeText;

	[Token(Token = "0x400069B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] hearts;

	[Token(Token = "0x400069C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Renderer screenRenderer;

	[Token(Token = "0x400069D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI objective1InWatch;

	[Token(Token = "0x400069E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI objective2InWatch;

	[Token(Token = "0x400069F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI objective3InWatch;

	[Token(Token = "0x40006A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject objectivesInWatchTitle;

	[Token(Token = "0x40006A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextMeshProUGUI playerHealthInWatch;

	[Token(Token = "0x40006A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int playerHealth;

	[Token(Token = "0x40006A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TextMeshProUGUI beersToLoseInWatch;

	[Token(Token = "0x40006A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int beersToLose;

	[Token(Token = "0x40006A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int beersLeftToLose;

	[Token(Token = "0x40006A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public TextMeshProUGUI requestsToLoseInWatch;

	[Token(Token = "0x40006A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int requestsToLose;

	[Token(Token = "0x40006A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int requestsLeftToLose;

	[Token(Token = "0x40006A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject watchUICanvas;

	[Token(Token = "0x40006AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float coolddownToToggle;

	[Token(Token = "0x40006AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float currentCooldownTime;

	[Token(Token = "0x40006AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool displayingWatchUICanvas;

	[Token(Token = "0x40006AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Animator watchUICanvasAnimator;

	[Token(Token = "0x40006AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float distanceUntilTurnWatchOff;

	[Token(Token = "0x40006AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public float angleUntilTurnWatchOff;

	[Token(Token = "0x40006B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Image blinkingCanvas;

	[Token(Token = "0x40006B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private AudioHandler audioHandler;

	[Token(Token = "0x40006B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private HVRHandGrabber hand;

	[Token(Token = "0x40006B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public RequestSlotClone[] requestSlotClones;

	[Token(Token = "0x60006F5")]
	[Address(RVA = "0x1F0D608", Offset = "0x1F0D608", VA = "0x1F0D608")]
	private void Start()
	{
	}

	[Token(Token = "0x60006F6")]
	[Address(RVA = "0x1F0E150", Offset = "0x1F0E150", VA = "0x1F0E150")]
	private void Update()
	{
	}

	[Token(Token = "0x60006F7")]
	[Address(RVA = "0x1F0E37C", Offset = "0x1F0E37C", VA = "0x1F0E37C")]
	private void UpdateHP()
	{
	}

	[Token(Token = "0x60006F8")]
	[Address(RVA = "0x1F0E930", Offset = "0x1F0E930", VA = "0x1F0E930")]
	private void UpdateHP(int i)
	{
	}

	[Token(Token = "0x60006F9")]
	[Address(RVA = "0x1F0E934", Offset = "0x1F0E934", VA = "0x1F0E934")]
	private void UpdateBeersLost(Beer _)
	{
	}

	[Token(Token = "0x60006FA")]
	[Address(RVA = "0x1F0EA10", Offset = "0x1F0EA10", VA = "0x1F0EA10")]
	private void UpdateRequestsLost(RequestSlot _)
	{
	}

	[Token(Token = "0x60006FB")]
	[Address(RVA = "0x1F0DB28", Offset = "0x1F0DB28", VA = "0x1F0DB28")]
	private void NewLevel()
	{
	}

	[Token(Token = "0x60006FC")]
	[Address(RVA = "0x1F0ECC8", Offset = "0x1F0ECC8", VA = "0x1F0ECC8")]
	private void ResetWatchCanvasText()
	{
	}

	[Token(Token = "0x60006FD")]
	[Address(RVA = "0x1F0EDC0", Offset = "0x1F0EDC0", VA = "0x1F0EDC0")]
	private void DisableWatchCanvasButtons()
	{
	}

	[Token(Token = "0x60006FE")]
	[Address(RVA = "0x1F0EAEC", Offset = "0x1F0EAEC", VA = "0x1F0EAEC")]
	private void EnableWatchCanvasButtons()
	{
	}

	[Token(Token = "0x60006FF")]
	[Address(RVA = "0x1F0EF9C", Offset = "0x1F0EF9C", VA = "0x1F0EF9C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000700")]
	[Address(RVA = "0x1F0F104", Offset = "0x1F0F104", VA = "0x1F0F104")]
	public void RestartButton()
	{
	}

	[Token(Token = "0x6000701")]
	[Address(RVA = "0x1F0F2B0", Offset = "0x1F0F2B0", VA = "0x1F0F2B0")]
	public void QuitLevelButton()
	{
	}

	[Token(Token = "0x6000702")]
	[Address(RVA = "0x1F0F45C", Offset = "0x1F0F45C", VA = "0x1F0F45C")]
	public void ShowWatchUICanvas()
	{
	}

	[Token(Token = "0x6000703")]
	[Address(RVA = "0x1F0E2F4", Offset = "0x1F0E2F4", VA = "0x1F0E2F4")]
	public void HideWatchUICanvas()
	{
	}

	[Token(Token = "0x6000704")]
	[Address(RVA = "0x1F0F0EC", Offset = "0x1F0F0EC", VA = "0x1F0F0EC")]
	private void ToggleWatchCanvas()
	{
	}

	[Token(Token = "0x6000705")]
	[Address(RVA = "0x1F0F4E8", Offset = "0x1F0F4E8", VA = "0x1F0F4E8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB491C", Offset = "0xAB491C")]
	public IEnumerator BlinkUntilOpenedCoroutine(float delay = 0f)
	{
		return null;
	}

	[Token(Token = "0x6000706")]
	[Address(RVA = "0x1F0E874", Offset = "0x1F0E874", VA = "0x1F0E874")]
	private void VibrateWatch()
	{
	}

	[Token(Token = "0x6000707")]
	[Address(RVA = "0x1F0F564", Offset = "0x1F0F564", VA = "0x1F0F564")]
	public PlayerUIWatch()
	{
	}

	[Token(Token = "0x6000708")]
	[Address(RVA = "0x1F0F5B8", Offset = "0x1F0F5B8", VA = "0x1F0F5B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB497C", Offset = "0xAB497C")]
	private void <BlinkUntilOpenedCoroutine>g__SetCanvasAlpha|43_0(float alpha, ref <>c__DisplayClass43_0 P_1)
	{
	}
}
[Token(Token = "0x2000135")]
public class TrailerPlayer : MonoBehaviour
{
	[Token(Token = "0x2000136")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAB64", Offset = "0xAAAB64")]
	private sealed class <PlayVideo>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TrailerPlayer <>4__this;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <time>5__2;

		[Token(Token = "0x17000127")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600071A")]
			[Address(RVA = "0x22CFD78", Offset = "0x22CFD78", VA = "0x22CFD78", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000128")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600071C")]
			[Address(RVA = "0x22CFDC0", Offset = "0x22CFDC0", VA = "0x22CFDC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x22CFB2C", Offset = "0x22CFB2C", VA = "0x22CFB2C")]
		[DebuggerHidden]
		public <PlayVideo>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x22CFB58", Offset = "0x22CFB58", VA = "0x22CFB58", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x22CFB5C", Offset = "0x22CFB5C", VA = "0x22CFB5C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x22CFD80", Offset = "0x22CFD80", VA = "0x22CFD80", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000137")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAB74", Offset = "0xAAAB74")]
	private sealed class <FadeOutCoroutine>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TrailerPlayer <>4__this;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <time>5__2;

		[Token(Token = "0x17000129")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000720")]
			[Address(RVA = "0x22CFADC", Offset = "0x22CFADC", VA = "0x22CFADC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000722")]
			[Address(RVA = "0x22CFB24", Offset = "0x22CFB24", VA = "0x22CFB24", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x22CF92C", Offset = "0x22CF92C", VA = "0x22CF92C")]
		[DebuggerHidden]
		public <FadeOutCoroutine>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x22CF958", Offset = "0x22CF958", VA = "0x22CF958", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x22CF95C", Offset = "0x22CF95C", VA = "0x22CF95C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x22CFAE4", Offset = "0x22CFAE4", VA = "0x22CFAE4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40006C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public VideoPlayer steamTrailer;

	[Token(Token = "0x40006C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public VideoPlayer oculusTrailer;

	[Token(Token = "0x40006C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public VideoPlayer video;

	[Token(Token = "0x40006C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private SpriteRenderer spriteRenderer;

	[Token(Token = "0x40006C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool allowSkip;

	[Token(Token = "0x40006C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject skipText;

	[Token(Token = "0x40006C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Color transparentColor;

	[Token(Token = "0x40006C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Color fullAlphaColor;

	[Token(Token = "0x6000710")]
	[Address(RVA = "0x1F3EEBC", Offset = "0x1F3EEBC", VA = "0x1F3EEBC")]
	public void Play(float delay)
	{
	}

	[Token(Token = "0x6000711")]
	[Address(RVA = "0x1F3F044", Offset = "0x1F3F044", VA = "0x1F3F044")]
	public void Stop()
	{
	}

	[Token(Token = "0x6000712")]
	[Address(RVA = "0x1F3F154", Offset = "0x1F3F154", VA = "0x1F3F154")]
	public VideoPlayer GetVideo()
	{
		return null;
	}

	[Token(Token = "0x6000713")]
	[Address(RVA = "0x1F3F260", Offset = "0x1F3F260", VA = "0x1F3F260")]
	public SpriteRenderer GetRenderer()
	{
		return null;
	}

	[Token(Token = "0x6000714")]
	[Address(RVA = "0x1F3EFC8", Offset = "0x1F3EFC8", VA = "0x1F3EFC8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB49DC", Offset = "0xAB49DC")]
	private IEnumerator PlayVideo(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000715")]
	[Address(RVA = "0x1F3F1F4", Offset = "0x1F3F1F4", VA = "0x1F3F1F4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB4A3C", Offset = "0xAB4A3C")]
	private IEnumerator FadeOutCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000716")]
	[Address(RVA = "0x1F3F324", Offset = "0x1F3F324", VA = "0x1F3F324")]
	public TrailerPlayer()
	{
	}
}
[Token(Token = "0x2000138")]
public class UIActions : Singleton<UIActions>
{
	[Token(Token = "0x40006D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject MainMenu;

	[Token(Token = "0x40006D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject CampaignMenu;

	[Token(Token = "0x40006D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject ArcadeMenu;

	[Token(Token = "0x40006D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject SettingsMenu;

	[Token(Token = "0x40006D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAABB4C", Offset = "0xAABB4C")]
	public TextMeshProUGUI attemptOfBBQValue;

	[Token(Token = "0x40006D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI boomerangsThrownValue;

	[Token(Token = "0x40006D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI boomerangsCaughtValue;

	[Token(Token = "0x40006D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextMeshProUGUI beersLostValue;

	[Token(Token = "0x40006D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextMeshProUGUI beersServedValue;

	[Token(Token = "0x40006DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TextMeshProUGUI hamburgersServedValue;

	[Token(Token = "0x40006DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TextMeshProUGUI skewersServedValue;

	[Token(Token = "0x40006DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public TextMeshProUGUI platesSmashedValue;

	[Token(Token = "0x40006DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public TextMeshProUGUI animalsWhackedValue;

	[Token(Token = "0x40006DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public TextMeshProUGUI animalsPettedValue;

	[Token(Token = "0x40006DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private AussiePlayer aussiePlayer;

	[Token(Token = "0x6000723")]
	[Address(RVA = "0x1F3FC5C", Offset = "0x1F3FC5C", VA = "0x1F3FC5C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000724")]
	[Address(RVA = "0x1F3FF60", Offset = "0x1F3FF60", VA = "0x1F3FF60")]
	public void Tutorial()
	{
	}

	[Token(Token = "0x6000725")]
	[Address(RVA = "0x1F3FFFC", Offset = "0x1F3FFFC", VA = "0x1F3FFFC")]
	public void GoToScene(string _scene)
	{
	}

	[Token(Token = "0x6000726")]
	[Address(RVA = "0x1F40088", Offset = "0x1F40088", VA = "0x1F40088")]
	public void DeleteSave()
	{
	}

	[Token(Token = "0x6000727")]
	[Address(RVA = "0x1F4010C", Offset = "0x1F4010C", VA = "0x1F4010C")]
	public void MagicStarsUnlock()
	{
	}

	[Token(Token = "0x6000728")]
	[Address(RVA = "0x1F40190", Offset = "0x1F40190", VA = "0x1F40190")]
	public void Quit()
	{
	}

	[Token(Token = "0x6000729")]
	[Address(RVA = "0x1F40214", Offset = "0x1F40214", VA = "0x1F40214")]
	public void OpenCampaingMenu()
	{
	}

	[Token(Token = "0x600072A")]
	[Address(RVA = "0x1F4031C", Offset = "0x1F4031C", VA = "0x1F4031C")]
	public void OpenMainMenu()
	{
	}

	[Token(Token = "0x600072B")]
	[Address(RVA = "0x1F40474", Offset = "0x1F40474", VA = "0x1F40474")]
	public void OpenArcadeMenu()
	{
	}

	[Token(Token = "0x600072C")]
	[Address(RVA = "0x1F4057C", Offset = "0x1F4057C", VA = "0x1F4057C")]
	public void OpenSettingsMenu()
	{
	}

	[Token(Token = "0x600072D")]
	[Address(RVA = "0x1F3FCE0", Offset = "0x1F3FCE0", VA = "0x1F3FCE0")]
	public void UpdateStatisticsOnBoard()
	{
	}

	[Token(Token = "0x600072E")]
	[Address(RVA = "0x1F40630", Offset = "0x1F40630", VA = "0x1F40630")]
	public UIActions()
	{
	}
}
[Token(Token = "0x2000139")]
public class VignetteCanvas : MonoBehaviour
{
	[Token(Token = "0x200013A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAB84", Offset = "0xAAAB84")]
	private sealed class <DelayedVignetteListners>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VignetteCanvas <>4__this;

		[Token(Token = "0x1700012B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000741")]
			[Address(RVA = "0x22D0BE0", Offset = "0x22D0BE0", VA = "0x22D0BE0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000743")]
			[Address(RVA = "0x22D0C28", Offset = "0x22D0C28", VA = "0x22D0C28", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x22D09C8", Offset = "0x22D09C8", VA = "0x22D09C8")]
		[DebuggerHidden]
		public <DelayedVignetteListners>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x22D09F4", Offset = "0x22D09F4", VA = "0x22D09F4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x22D09F8", Offset = "0x22D09F8", VA = "0x22D09F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x22D0BE8", Offset = "0x22D0BE8", VA = "0x22D0BE8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200013B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAB94", Offset = "0xAAAB94")]
	private sealed class <EnableLoadingSequenceAfterDelay>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VignetteCanvas <>4__this;

		[Token(Token = "0x1700012D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000747")]
			[Address(RVA = "0x22D0D10", Offset = "0x22D0D10", VA = "0x22D0D10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000749")]
			[Address(RVA = "0x22D0D58", Offset = "0x22D0D58", VA = "0x22D0D58", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x22D0C30", Offset = "0x22D0C30", VA = "0x22D0C30")]
		[DebuggerHidden]
		public <EnableLoadingSequenceAfterDelay>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x22D0C5C", Offset = "0x22D0C5C", VA = "0x22D0C5C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x22D0C60", Offset = "0x22D0C60", VA = "0x22D0C60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x22D0D18", Offset = "0x22D0D18", VA = "0x22D0D18", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200013C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAABA4", Offset = "0xAAABA4")]
	private sealed class <FadoutVignetteCoroutine>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool _damage;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public VignetteCanvas <>4__this;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float _fadoutTime;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public CanvasGroup _canvasGroup;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <time>5__2;

		[Token(Token = "0x1700012F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600074D")]
			[Address(RVA = "0x22D10A0", Offset = "0x22D10A0", VA = "0x22D10A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000130")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600074F")]
			[Address(RVA = "0x22D10E8", Offset = "0x22D10E8", VA = "0x22D10E8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x22D0D60", Offset = "0x22D0D60", VA = "0x22D0D60")]
		[DebuggerHidden]
		public <FadoutVignetteCoroutine>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x22D0D8C", Offset = "0x22D0D8C", VA = "0x22D0D8C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x22D0D90", Offset = "0x22D0D90", VA = "0x22D0D90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x22D10A8", Offset = "0x22D10A8", VA = "0x22D10A8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40006E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float teleportFadeOut;

	[Token(Token = "0x40006E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float damageFadeOut;

	[Token(Token = "0x40006E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CanvasGroup damageCanvasGroup;

	[Token(Token = "0x40006E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public CanvasGroup teleportCanvasGroup;

	[Token(Token = "0x40006E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public CanvasGroup pauseCanvasGroup;

	[Token(Token = "0x40006E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject loadingAnimation;

	[Token(Token = "0x40006E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public CanvasGroup blackScreenCanvasGroup;

	[Token(Token = "0x40006E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private IEnumerator loadingCoroutine;

	[Token(Token = "0x40006E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private AudioHandler audioHandler;

	[Token(Token = "0x40006E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool streamingCanvas;

	[Token(Token = "0x600072F")]
	[Address(RVA = "0x1F419E8", Offset = "0x1F419E8", VA = "0x1F419E8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000730")]
	[Address(RVA = "0x1F420E8", Offset = "0x1F420E8", VA = "0x1F420E8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB4B3C", Offset = "0xAB4B3C")]
	private IEnumerator DelayedVignetteListners()
	{
		return null;
	}

	[Token(Token = "0x6000731")]
	[Address(RVA = "0x1F42154", Offset = "0x1F42154", VA = "0x1F42154")]
	private void UpdateGamePlayManagerDamage()
	{
	}

	[Token(Token = "0x6000732")]
	[Address(RVA = "0x1F422E4", Offset = "0x1F422E4", VA = "0x1F422E4")]
	private void EnableLoadingSequence()
	{
	}

	[Token(Token = "0x6000733")]
	[Address(RVA = "0x1F4207C", Offset = "0x1F4207C", VA = "0x1F4207C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB4B9C", Offset = "0xAB4B9C")]
	private IEnumerator EnableLoadingSequenceAfterDelay()
	{
		return null;
	}

	[Token(Token = "0x6000734")]
	[Address(RVA = "0x1F42038", Offset = "0x1F42038", VA = "0x1F42038")]
	private void DisableLoadingSequence()
	{
	}

	[Token(Token = "0x6000735")]
	[Address(RVA = "0x1F422F0", Offset = "0x1F422F0", VA = "0x1F422F0")]
	private void DamageVignetteOn(int _)
	{
	}

	[Token(Token = "0x6000736")]
	[Address(RVA = "0x1F4238C", Offset = "0x1F4238C", VA = "0x1F4238C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB4BFC", Offset = "0xAB4BFC")]
	private IEnumerator FadoutVignetteCoroutine(CanvasGroup _canvasGroup, float _fadoutTime = 1f, bool _damage = false)
	{
		return null;
	}

	[Token(Token = "0x6000737")]
	[Address(RVA = "0x1F42424", Offset = "0x1F42424", VA = "0x1F42424")]
	private void TeleportVignetteOn()
	{
	}

	[Token(Token = "0x6000738")]
	[Address(RVA = "0x1F424B4", Offset = "0x1F424B4", VA = "0x1F424B4")]
	private void TeleportVignetteOff()
	{
	}

	[Token(Token = "0x6000739")]
	[Address(RVA = "0x1F424EC", Offset = "0x1F424EC", VA = "0x1F424EC")]
	private void PauseVignetteOn()
	{
	}

	[Token(Token = "0x600073A")]
	[Address(RVA = "0x1F4250C", Offset = "0x1F4250C", VA = "0x1F4250C")]
	private void PauseVignetteOff()
	{
	}

	[Token(Token = "0x600073B")]
	[Address(RVA = "0x1F4252C", Offset = "0x1F4252C", VA = "0x1F4252C")]
	public void CameraFadeVignetteOn()
	{
	}

	[Token(Token = "0x600073C")]
	[Address(RVA = "0x1F4254C", Offset = "0x1F4254C", VA = "0x1F4254C")]
	private void CameraFadeVignetteOff()
	{
	}

	[Token(Token = "0x600073D")]
	[Address(RVA = "0x1F42584", Offset = "0x1F42584", VA = "0x1F42584")]
	public VignetteCanvas()
	{
	}
}
[Token(Token = "0x200013D")]
public class WatchMenuButton : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200013E")]
	public class ActionOnSelect : UnityEvent
	{
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x22D1320", Offset = "0x22D1320", VA = "0x22D1320")]
		public ActionOnSelect()
		{
		}
	}

	[Token(Token = "0x40006F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<WatchMenuButton> instances;

	[Token(Token = "0x40006F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject button;

	[Token(Token = "0x40006F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private HVRHandGrabber hand;

	[Token(Token = "0x40006FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioHandler audioHandler;

	[Token(Token = "0x40006FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public BoxCollider buttonCollider;

	[Token(Token = "0x40006FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI buttonText;

	[Token(Token = "0x40006FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool disabled;

	[Token(Token = "0x40006FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float cooldown;

	[Token(Token = "0x40006FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float timeToSelect;

	[Token(Token = "0x4000700")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float selectionPercentage;

	[Token(Token = "0x4000701")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool selecting;

	[Token(Token = "0x4000702")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	public ActionOnSelect actionOnSelect;

	[Token(Token = "0x4000703")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material buttonMaterial;

	[Token(Token = "0x4000704")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3 originalButtonPosition;

	[Token(Token = "0x6000750")]
	[Address(RVA = "0x1F43088", Offset = "0x1F43088", VA = "0x1F43088")]
	private void Start()
	{
	}

	[Token(Token = "0x6000751")]
	[Address(RVA = "0x1F43234", Offset = "0x1F43234", VA = "0x1F43234")]
	private void Update()
	{
	}

	[Token(Token = "0x6000752")]
	[Address(RVA = "0x1F43310", Offset = "0x1F43310", VA = "0x1F43310")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000753")]
	[Address(RVA = "0x1F4331C", Offset = "0x1F4331C", VA = "0x1F4331C")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x6000754")]
	[Address(RVA = "0x1F434B8", Offset = "0x1F434B8", VA = "0x1F434B8")]
	private void selectButton()
	{
	}

	[Token(Token = "0x6000755")]
	[Address(RVA = "0x1F43584", Offset = "0x1F43584", VA = "0x1F43584")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000756")]
	[Address(RVA = "0x1F432B4", Offset = "0x1F432B4", VA = "0x1F432B4")]
	private void updateShader()
	{
	}

	[Token(Token = "0x6000757")]
	[Address(RVA = "0x1F4364C", Offset = "0x1F4364C", VA = "0x1F4364C")]
	public void DisableButton()
	{
	}

	[Token(Token = "0x6000758")]
	[Address(RVA = "0x1F43718", Offset = "0x1F43718", VA = "0x1F43718")]
	public void EnableButton()
	{
	}

	[Token(Token = "0x6000759")]
	[Address(RVA = "0x1F437C4", Offset = "0x1F437C4", VA = "0x1F437C4")]
	public WatchMenuButton()
	{
	}
}
[Token(Token = "0x200013F")]
public class Whiteboard : Singleton<Whiteboard>
{
	[Token(Token = "0x4000705")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Renderer _renderer;

	[Token(Token = "0x4000706")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Texture2D texture;

	[Token(Token = "0x4000707")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 textureSize;

	[Token(Token = "0x4000708")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Color[] resetPixels;

	[Token(Token = "0x4000709")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject disableParticles;

	[Token(Token = "0x400070A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject submitButton;

	[Token(Token = "0x400070B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject submitButtonDisabler;

	[Token(Token = "0x400070C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Sprite cantSubmitTexture;

	[Token(Token = "0x400070D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject markers;

	[Token(Token = "0x600075B")]
	[Address(RVA = "0x1F437D4", Offset = "0x1F437D4", VA = "0x1F437D4", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600075C")]
	[Address(RVA = "0x1F438F8", Offset = "0x1F438F8", VA = "0x1F438F8")]
	private void Start()
	{
	}

	[Token(Token = "0x600075D")]
	[Address(RVA = "0x1F439DC", Offset = "0x1F439DC", VA = "0x1F439DC")]
	public void ResetBoard()
	{
	}

	[Token(Token = "0x600075E")]
	[Address(RVA = "0x1F43A1C", Offset = "0x1F43A1C", VA = "0x1F43A1C")]
	public void DisableSubmit()
	{
	}

	[Token(Token = "0x600075F")]
	[Address(RVA = "0x1F43D00", Offset = "0x1F43D00", VA = "0x1F43D00")]
	public void Disable()
	{
	}

	[Token(Token = "0x6000760")]
	[Address(RVA = "0x1F43D84", Offset = "0x1F43D84", VA = "0x1F43D84")]
	public void Enable()
	{
	}

	[Token(Token = "0x6000761")]
	[Address(RVA = "0x1F43E1C", Offset = "0x1F43E1C", VA = "0x1F43E1C")]
	public Whiteboard()
	{
	}
}
[Token(Token = "0x2000140")]
public class WhiteboardMarker : MonoBehaviour
{
	[Token(Token = "0x400070E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform _tip;

	[Token(Token = "0x400070F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int _penSize;

	[Token(Token = "0x4000710")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private Color _color;

	[Token(Token = "0x4000711")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Color[] _colors;

	[Token(Token = "0x4000712")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float _tipHeight;

	[Token(Token = "0x4000713")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private RaycastHit _touch;

	[Token(Token = "0x4000714")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Whiteboard _whiteboard;

	[Token(Token = "0x4000715")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector2 _touchPos;

	[Token(Token = "0x4000716")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Vector2 _lastTouchPos;

	[Token(Token = "0x4000717")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int _lastTouchIntensity;

	[Token(Token = "0x4000718")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private bool _touchedLastFrame;

	[Token(Token = "0x4000719")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private AudioHandler audioHandler;

	[Token(Token = "0x400071A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float _drawingTime;

	[Token(Token = "0x400071B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private HVRGrabbable grabbable;

	[Token(Token = "0x400071C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private bool isBeingGrabbed;

	[Token(Token = "0x6000762")]
	[Address(RVA = "0x1F43E74", Offset = "0x1F43E74", VA = "0x1F43E74")]
	private void Start()
	{
	}

	[Token(Token = "0x6000763")]
	[Address(RVA = "0x1F440CC", Offset = "0x1F440CC", VA = "0x1F440CC")]
	private void OnGrab(HVRGrabberBase grabber, HVRGrabbable hvrGrabbable)
	{
	}

	[Token(Token = "0x6000764")]
	[Address(RVA = "0x1F440D8", Offset = "0x1F440D8", VA = "0x1F440D8")]
	private void OnRelease(HVRGrabberBase grabber, HVRGrabbable hvrGrabbable)
	{
	}

	[Token(Token = "0x6000765")]
	[Address(RVA = "0x1F440E0", Offset = "0x1F440E0", VA = "0x1F440E0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000766")]
	[Address(RVA = "0x1F440F0", Offset = "0x1F440F0", VA = "0x1F440F0")]
	private void Draw()
	{
	}

	[Token(Token = "0x6000767")]
	[Address(RVA = "0x1F4441C", Offset = "0x1F4441C", VA = "0x1F4441C")]
	private void SetPixelsCircle(int _x, int _y, int _intensity)
	{
	}

	[Token(Token = "0x6000768")]
	[Address(RVA = "0x1F44520", Offset = "0x1F44520", VA = "0x1F44520")]
	public WhiteboardMarker()
	{
	}
}
[Token(Token = "0x2000141")]
public class ActionOnTriggerEnter : MonoBehaviour
{
	[Token(Token = "0x400071D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityEvent onTriggerEnterEvent;

	[Token(Token = "0x400071E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string tagFilter;

	[Token(Token = "0x400071F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool useTag;

	[Token(Token = "0x6000769")]
	[Address(RVA = "0x1E9FEE4", Offset = "0x1E9FEE4", VA = "0x1E9FEE4")]
	private void Start()
	{
	}

	[Token(Token = "0x600076A")]
	[Address(RVA = "0x1E9FF18", Offset = "0x1E9FF18", VA = "0x1E9FF18")]
	private void OnTriggerEnter(Collider collider)
	{
	}

	[Token(Token = "0x600076B")]
	[Address(RVA = "0x1E9FF7C", Offset = "0x1E9FF7C", VA = "0x1E9FF7C")]
	public ActionOnTriggerEnter()
	{
	}
}
[Token(Token = "0x2000142")]
public class ActivateOnPlatform : MonoBehaviour
{
	[Token(Token = "0x2000143")]
	public enum Platform
	{
		[Token(Token = "0x4000724")]
		STEAM,
		[Token(Token = "0x4000725")]
		OCULUS,
		[Token(Token = "0x4000726")]
		PICO,
		[Token(Token = "0x4000727")]
		IQIYI
	}

	[Token(Token = "0x4000720")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] activatableObjects;

	[Token(Token = "0x4000721")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Platform platform;

	[Token(Token = "0x4000722")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private bool activate;

	[Token(Token = "0x600076C")]
	[Address(RVA = "0x1EA0170", Offset = "0x1EA0170", VA = "0x1EA0170")]
	private void Start()
	{
	}

	[Token(Token = "0x600076D")]
	[Address(RVA = "0x1EA0204", Offset = "0x1EA0204", VA = "0x1EA0204")]
	public ActivateOnPlatform()
	{
	}
}
[Token(Token = "0x2000144")]
public class ActivateOnQualityLevel : MonoBehaviour
{
	[Token(Token = "0x4000728")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] activatableObjectsLevel3;

	[Token(Token = "0x4000729")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int qualityLevel;

	[Token(Token = "0x600076E")]
	[Address(RVA = "0x1EA020C", Offset = "0x1EA020C", VA = "0x1EA020C")]
	private void Start()
	{
	}

	[Token(Token = "0x600076F")]
	[Address(RVA = "0x1EA02F8", Offset = "0x1EA02F8", VA = "0x1EA02F8")]
	public void ifQualityOverOrEqual3()
	{
	}

	[Token(Token = "0x6000770")]
	[Address(RVA = "0x1EA0444", Offset = "0x1EA0444", VA = "0x1EA0444")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000771")]
	[Address(RVA = "0x1EA05AC", Offset = "0x1EA05AC", VA = "0x1EA05AC")]
	public ActivateOnQualityLevel()
	{
	}
}
[Token(Token = "0x2000145")]
public class AddPrefabAsChild : MonoBehaviour
{
	[Token(Token = "0x400072A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] prefabs;

	[Token(Token = "0x6000772")]
	[Address(RVA = "0x1EA05BC", Offset = "0x1EA05BC", VA = "0x1EA05BC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000773")]
	[Address(RVA = "0x1EA06B4", Offset = "0x1EA06B4", VA = "0x1EA06B4")]
	public AddPrefabAsChild()
	{
	}
}
[Token(Token = "0x2000146")]
public class ArcadeWaveHandler : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000147")]
	public class EnemyTemplate
	{
		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject enemyPrefab;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<Transform> spawnPlaces;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool spawnPlaceUniquePerWave;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int firstSpawnAtWave;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int initialSpawnNumber;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float increaseRate;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int maxAmount;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAABC5C", Offset = "0xAABC5C")]
		public float waitTimeBetweenSpawns;

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x1F490C8", Offset = "0x1F490C8", VA = "0x1F490C8")]
		public EnemyTemplate()
		{
		}
	}

	[Token(Token = "0x2000148")]
	public class EnemyToSpawn
	{
		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject enemyPrefab;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform spawnPlace;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float secondsToWaitAfterSpawn;

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x1F490DC", Offset = "0x1F490DC", VA = "0x1F490DC")]
		public EnemyToSpawn(GameObject _prefab, Transform _transform, float _secondsToWaitAfterSpawn)
		{
		}
	}

	[Token(Token = "0x2000149")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAABB4", Offset = "0xAAABB4")]
	private sealed class <PrepareWave>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ArcadeWaveHandler <>4__this;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int waveNumber;

		[Token(Token = "0x17000131")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000788")]
			[Address(RVA = "0x1F48900", Offset = "0x1F48900", VA = "0x1F48900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000132")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600078A")]
			[Address(RVA = "0x1F48948", Offset = "0x1F48948", VA = "0x1F48948", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x1F48708", Offset = "0x1F48708", VA = "0x1F48708")]
		[DebuggerHidden]
		public <PrepareWave>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x1F48734", Offset = "0x1F48734", VA = "0x1F48734", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x1F48738", Offset = "0x1F48738", VA = "0x1F48738", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x1F48908", Offset = "0x1F48908", VA = "0x1F48908", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200014A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAABC4", Offset = "0xAAABC4")]
	private sealed class <>c
	{
		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<EnemyToSpawn, float> <>9__14_0;

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x1F486F8", Offset = "0x1F486F8", VA = "0x1F486F8")]
		public <>c()
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x1F48700", Offset = "0x1F48700", VA = "0x1F48700")]
		internal float <StartNextProceduralGeneratedEnemyWave>b__14_0(EnemyToSpawn x)
		{
			return default(float);
		}
	}

	[Token(Token = "0x200014B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAABD4", Offset = "0xAAABD4")]
	private sealed class <SpawnEnemiesCoroutine>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ArcadeWaveHandler <>4__this;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<EnemyToSpawn> enemies;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<EnemyToSpawn>.Enumerator <>7__wrap1;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EnemyToSpawn <enemy>5__3;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int <i>5__4;

		[Token(Token = "0x17000133")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000792")]
			[Address(RVA = "0x1F48DA8", Offset = "0x1F48DA8", VA = "0x1F48DA8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000134")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000794")]
			[Address(RVA = "0x1F48DF0", Offset = "0x1F48DF0", VA = "0x1F48DF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x1F48950", Offset = "0x1F48950", VA = "0x1F48950")]
		[DebuggerHidden]
		public <SpawnEnemiesCoroutine>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x1F4897C", Offset = "0x1F4897C", VA = "0x1F4897C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x1F489EC", Offset = "0x1F489EC", VA = "0x1F489EC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x1F48998", Offset = "0x1F48998", VA = "0x1F48998")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x1F48DB0", Offset = "0x1F48DB0", VA = "0x1F48DB0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200014C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAABE4", Offset = "0xAAABE4")]
	private sealed class <Wave5Update>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000135")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000798")]
			[Address(RVA = "0x1F49078", Offset = "0x1F49078", VA = "0x1F49078", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000136")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600079A")]
			[Address(RVA = "0x1F490C0", Offset = "0x1F490C0", VA = "0x1F490C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x1F49014", Offset = "0x1F49014", VA = "0x1F49014")]
		[DebuggerHidden]
		public <Wave5Update>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x1F49040", Offset = "0x1F49040", VA = "0x1F49040", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x1F49044", Offset = "0x1F49044", VA = "0x1F49044", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x1F49080", Offset = "0x1F49080", VA = "0x1F49080", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200014D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAABF4", Offset = "0xAAABF4")]
	private sealed class <Wave10Update>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000137")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600079E")]
			[Address(RVA = "0x1F48E5C", Offset = "0x1F48E5C", VA = "0x1F48E5C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000138")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x1F48EA4", Offset = "0x1F48EA4", VA = "0x1F48EA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x1F48DF8", Offset = "0x1F48DF8", VA = "0x1F48DF8")]
		[DebuggerHidden]
		public <Wave10Update>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x1F48E24", Offset = "0x1F48E24", VA = "0x1F48E24", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x1F48E28", Offset = "0x1F48E28", VA = "0x1F48E28", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x1F48E64", Offset = "0x1F48E64", VA = "0x1F48E64", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200014E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAC04", Offset = "0xAAAC04")]
	private sealed class <Wave15Update>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000139")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x1F48F10", Offset = "0x1F48F10", VA = "0x1F48F10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x1F48F58", Offset = "0x1F48F58", VA = "0x1F48F58", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x1F48EAC", Offset = "0x1F48EAC", VA = "0x1F48EAC")]
		[DebuggerHidden]
		public <Wave15Update>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x1F48ED8", Offset = "0x1F48ED8", VA = "0x1F48ED8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x1F48EDC", Offset = "0x1F48EDC", VA = "0x1F48EDC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x1F48F18", Offset = "0x1F48F18", VA = "0x1F48F18", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200014F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAC14", Offset = "0xAAAC14")]
	private sealed class <Wave20Update>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x1700013B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x1F48FC4", Offset = "0x1F48FC4", VA = "0x1F48FC4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007AC")]
			[Address(RVA = "0x1F4900C", Offset = "0x1F4900C", VA = "0x1F4900C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x1F48F60", Offset = "0x1F48F60", VA = "0x1F48F60")]
		[DebuggerHidden]
		public <Wave20Update>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x1F48F8C", Offset = "0x1F48F8C", VA = "0x1F48F8C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x1F48F90", Offset = "0x1F48F90", VA = "0x1F48F90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x1F48FCC", Offset = "0x1F48FCC", VA = "0x1F48FCC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400072B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int currentWave;

	[Token(Token = "0x400072C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float timeToWaitBetweenWaves;

	[Token(Token = "0x400072D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public Events.EventNewArcadeWave OnWaveStart;

	[Token(Token = "0x400072E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xAABBD4", Offset = "0xAABBD4")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAABBD4", Offset = "0xAABBD4")]
	public GameObject[] premadeEnemySpawners;

	[Token(Token = "0x400072F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public EnemyTemplate[] enemyTemplates;

	[Token(Token = "0x4000730")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool startedInfiniteEnemySpawner;

	[Token(Token = "0x4000731")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAABC24", Offset = "0xAABC24")]
	public float[] enemySpawningTimeElasticity;

	[Token(Token = "0x6000774")]
	[Address(RVA = "0x1EA0AF8", Offset = "0x1EA0AF8", VA = "0x1EA0AF8")]
	public void StartArcade(int waveNumber)
	{
	}

	[Token(Token = "0x6000775")]
	[Address(RVA = "0x1EA3774", Offset = "0x1EA3774", VA = "0x1EA3774")]
	public void QueueNextWave()
	{
	}

	[Token(Token = "0x6000776")]
	[Address(RVA = "0x1EA36F8", Offset = "0x1EA36F8", VA = "0x1EA36F8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB4D4C", Offset = "0xAB4D4C")]
	private IEnumerator PrepareWave(int waveNumber)
	{
		return null;
	}

	[Token(Token = "0x6000777")]
	[Address(RVA = "0x1EA37AC", Offset = "0x1EA37AC", VA = "0x1EA37AC")]
	private void StartWave(int waveNumber)
	{
	}

	[Token(Token = "0x6000778")]
	[Address(RVA = "0x1EA38A0", Offset = "0x1EA38A0", VA = "0x1EA38A0", Slot = "4")]
	public virtual void StartSpawners(int waveNumber)
	{
	}

	[Token(Token = "0x6000779")]
	[Address(RVA = "0x1EA3914", Offset = "0x1EA3914", VA = "0x1EA3914")]
	public void StartNextProceduralGeneratedEnemyWave(int waveNumber)
	{
	}

	[Token(Token = "0x600077A")]
	[Address(RVA = "0x1EA3D9C", Offset = "0x1EA3D9C", VA = "0x1EA3D9C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB4DAC", Offset = "0xAB4DAC")]
	private IEnumerator SpawnEnemiesCoroutine(List<EnemyToSpawn> enemies)
	{
		return null;
	}

	[Token(Token = "0x600077B")]
	[Address(RVA = "0x1EA3E14", Offset = "0x1EA3E14", VA = "0x1EA3E14")]
	private void UpdateTimeElasticity()
	{
	}

	[Token(Token = "0x600077C")]
	[Address(RVA = "0x1EA3FEC", Offset = "0x1EA3FEC", VA = "0x1EA3FEC")]
	private float ElasticTimeIncrement()
	{
		return default(float);
	}

	[Token(Token = "0x600077D")]
	[Address(RVA = "0x1EA4164", Offset = "0x1EA4164", VA = "0x1EA4164", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB4E0C", Offset = "0xAB4E0C")]
	public virtual IEnumerator Wave5Update()
	{
		return null;
	}

	[Token(Token = "0x600077E")]
	[Address(RVA = "0x1EA41C0", Offset = "0x1EA41C0", VA = "0x1EA41C0", Slot = "6")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB4E6C", Offset = "0xAB4E6C")]
	public virtual IEnumerator Wave10Update()
	{
		return null;
	}

	[Token(Token = "0x600077F")]
	[Address(RVA = "0x1EA421C", Offset = "0x1EA421C", VA = "0x1EA421C", Slot = "7")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB4ECC", Offset = "0xAB4ECC")]
	public virtual IEnumerator Wave15Update()
	{
		return null;
	}

	[Token(Token = "0x6000780")]
	[Address(RVA = "0x1EA4278", Offset = "0x1EA4278", VA = "0x1EA4278", Slot = "8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB4F2C", Offset = "0xAB4F2C")]
	public virtual IEnumerator Wave20Update()
	{
		return null;
	}

	[Token(Token = "0x6000781")]
	[Address(RVA = "0x1EA42D4", Offset = "0x1EA42D4", VA = "0x1EA42D4")]
	public ArcadeWaveHandler()
	{
	}

	[Token(Token = "0x6000782")]
	[Address(RVA = "0x1EA3FE0", Offset = "0x1EA3FE0", VA = "0x1EA3FE0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB4F8C", Offset = "0xAB4F8C")]
	internal static float <UpdateTimeElasticity>g__calculateElasticity|16_0(float _min, float _changeMultiplier, float originalElasticity)
	{
		return default(float);
	}
}
[Token(Token = "0x2000150")]
public enum SoundType
{
	[Token(Token = "0x4000754")]
	SFX,
	[Token(Token = "0x4000755")]
	Music
}
[Token(Token = "0x2000151")]
public class AudioHandler : MonoBehaviour
{
	[Token(Token = "0x2000152")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAC24", Offset = "0xAAAC24")]
	private sealed class <>c__DisplayClass23_0
	{
		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string sound;

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x1F49124", Offset = "0x1F49124", VA = "0x1F49124")]
		public <>c__DisplayClass23_0()
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x1F4912C", Offset = "0x1F4912C", VA = "0x1F4912C")]
		internal bool <Play>b__0(Sound item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000153")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAC34", Offset = "0xAAAC34")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string sound;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Sound s;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioHandler <>4__this;

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x1F49150", Offset = "0x1F49150", VA = "0x1F49150")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x1F49158", Offset = "0x1F49158", VA = "0x1F49158")]
		internal bool <PlayCoroutine>b__0(Sound item)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x1F4917C", Offset = "0x1F4917C", VA = "0x1F4917C")]
		internal bool <PlayCoroutine>b__1()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000154")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAC44", Offset = "0xAAAC44")]
	private sealed class <PlayCoroutine>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string sound;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioHandler <>4__this;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private <>c__DisplayClass24_0 <>8__1;

		[Token(Token = "0x1700013D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x1F4957C", Offset = "0x1F4957C", VA = "0x1F4957C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x1F495C4", Offset = "0x1F495C4", VA = "0x1F495C4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x1F49258", Offset = "0x1F49258", VA = "0x1F49258")]
		[DebuggerHidden]
		public <PlayCoroutine>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x1F49284", Offset = "0x1F49284", VA = "0x1F49284", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x1F49288", Offset = "0x1F49288", VA = "0x1F49288", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x1F49584", Offset = "0x1F49584", VA = "0x1F49584", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000155")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAC54", Offset = "0xAAAC54")]
	private sealed class <>c__DisplayClass25_0
	{
		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string sound;

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x1F491D4", Offset = "0x1F491D4", VA = "0x1F491D4")]
		public <>c__DisplayClass25_0()
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x1F491DC", Offset = "0x1F491DC", VA = "0x1F491DC")]
		internal bool <Play>b__0(Sound item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000156")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAC64", Offset = "0xAAAC64")]
	private sealed class <PlayFromGroupWithDelayCoroutine>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioHandler <>4__this;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string sound;

		[Token(Token = "0x1700013F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x1F496B0", Offset = "0x1F496B0", VA = "0x1F496B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000140")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x1F496F8", Offset = "0x1F496F8", VA = "0x1F496F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x1F495CC", Offset = "0x1F495CC", VA = "0x1F495CC")]
		[DebuggerHidden]
		public <PlayFromGroupWithDelayCoroutine>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x1F495F8", Offset = "0x1F495F8", VA = "0x1F495F8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x1F495FC", Offset = "0x1F495FC", VA = "0x1F495FC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x1F496B8", Offset = "0x1F496B8", VA = "0x1F496B8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000157")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAC74", Offset = "0xAAAC74")]
	private sealed class <>c__DisplayClass32_0
	{
		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string sound;

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x1F49200", Offset = "0x1F49200", VA = "0x1F49200")]
		public <>c__DisplayClass32_0()
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x1F49208", Offset = "0x1F49208", VA = "0x1F49208")]
		internal bool <Stop>b__0(Sound item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000158")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAC84", Offset = "0xAAAC84")]
	private sealed class <>c__DisplayClass33_0
	{
		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string sound;

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x1F4922C", Offset = "0x1F4922C", VA = "0x1F4922C")]
		public <>c__DisplayClass33_0()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x1F49234", Offset = "0x1F49234", VA = "0x1F49234")]
		internal bool <GetSound>b__0(Sound item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000159")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAC94", Offset = "0xAAAC94")]
	private sealed class <UpdatePitchCoroutine>d__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource source;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float startingPitch;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float targetPitch;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float timeToTransition;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <time>5__2;

		[Token(Token = "0x17000141")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x1F497E0", Offset = "0x1F497E0", VA = "0x1F497E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000142")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x1F49828", Offset = "0x1F49828", VA = "0x1F49828", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x1F49700", Offset = "0x1F49700", VA = "0x1F49700")]
		[DebuggerHidden]
		public <UpdatePitchCoroutine>d__41(int <>1__state)
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x1F4972C", Offset = "0x1F4972C", VA = "0x1F4972C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x1F49730", Offset = "0x1F49730", VA = "0x1F49730", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x1F497E8", Offset = "0x1F497E8", VA = "0x1F497E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200015A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAACA4", Offset = "0xAAACA4")]
	private sealed class <UpdateVolumeCoroutine>d__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource source;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float startingVolume;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float targetVolume;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float timeToTransition;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <time>5__2;

		[Token(Token = "0x17000143")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x1F49A40", Offset = "0x1F49A40", VA = "0x1F49A40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000144")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x1F49A88", Offset = "0x1F49A88", VA = "0x1F49A88", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x1F49960", Offset = "0x1F49960", VA = "0x1F49960")]
		[DebuggerHidden]
		public <UpdateVolumeCoroutine>d__43(int <>1__state)
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x1F4998C", Offset = "0x1F4998C", VA = "0x1F4998C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x1F49990", Offset = "0x1F49990", VA = "0x1F49990", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x1F49A48", Offset = "0x1F49A48", VA = "0x1F49A48", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200015B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAACB4", Offset = "0xAAACB4")]
	private sealed class <UpdatePitchCoroutine>d__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource source;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float startingPitch;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float timeToTransition;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <time>5__2;

		[Token(Token = "0x17000145")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x1F49910", Offset = "0x1F49910", VA = "0x1F49910", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000146")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x1F49958", Offset = "0x1F49958", VA = "0x1F49958", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x1F49830", Offset = "0x1F49830", VA = "0x1F49830")]
		[DebuggerHidden]
		public <UpdatePitchCoroutine>d__44(int <>1__state)
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x1F4985C", Offset = "0x1F4985C", VA = "0x1F4985C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x1F49860", Offset = "0x1F49860", VA = "0x1F49860", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x1F49918", Offset = "0x1F49918", VA = "0x1F49918", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000756")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SoundType soundType;

	[Token(Token = "0x4000757")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioMixerGroup mixerGroup;

	[Token(Token = "0x4000758")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string playOnStart;

	[Token(Token = "0x4000759")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Sound[] sounds;

	[Token(Token = "0x400075A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public SoundGroup[] soundGroups;

	[Token(Token = "0x400075B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Dictionary<string, SoundGroup> soundGroupsDict;

	[Token(Token = "0x400075C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected float volumeLevel;

	[Token(Token = "0x400075D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject audioSourcesOrigin;

	[Token(Token = "0x400075E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject audioSourcesParent;

	[Token(Token = "0x400075F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float slowDownInfluence;

	[Token(Token = "0x4000760")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool quitting;

	[Token(Token = "0x4000761")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float timeUntilAudioSourcesDestroyed;

	[Token(Token = "0x4000762")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool isPaused;

	[Token(Token = "0x4000763")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private List<AudioSource> pausedSources;

	[Token(Token = "0x60007AD")]
	[Address(RVA = "0x1EA435C", Offset = "0x1EA435C", VA = "0x1EA435C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60007AE")]
	[Address(RVA = "0x1EA497C", Offset = "0x1EA497C", VA = "0x1EA497C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60007AF")]
	[Address(RVA = "0x1EA4A30", Offset = "0x1EA4A30", VA = "0x1EA4A30")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60007B0")]
	[Address(RVA = "0x1EA4A40", Offset = "0x1EA4A40", VA = "0x1EA4A40")]
	private void UnparentAudioSources()
	{
	}

	[Token(Token = "0x60007B1")]
	[Address(RVA = "0x1EA48FC", Offset = "0x1EA48FC", VA = "0x1EA48FC")]
	private void ResetAudioSourcesTransform()
	{
	}

	[Token(Token = "0x60007B2")]
	[Address(RVA = "0x1EA4AE0", Offset = "0x1EA4AE0", VA = "0x1EA4AE0")]
	private void Start()
	{
	}

	[Token(Token = "0x60007B3")]
	[Address(RVA = "0x1EA511C", Offset = "0x1EA511C", VA = "0x1EA511C")]
	private void OnPause()
	{
	}

	[Token(Token = "0x60007B4")]
	[Address(RVA = "0x1EA5214", Offset = "0x1EA5214", VA = "0x1EA5214")]
	private void OnUnPause()
	{
	}

	[Token(Token = "0x60007B5")]
	[Address(RVA = "0x1EA5370", Offset = "0x1EA5370", VA = "0x1EA5370")]
	private float SlowDownMultiplier()
	{
		return default(float);
	}

	[Token(Token = "0x60007B6")]
	[Address(RVA = "0x1EA1110", Offset = "0x1EA1110", VA = "0x1EA1110")]
	public void Play(string sound)
	{
	}

	[Token(Token = "0x60007B7")]
	[Address(RVA = "0x1EA53A8", Offset = "0x1EA53A8", VA = "0x1EA53A8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB517C", Offset = "0xAB517C")]
	public IEnumerator PlayCoroutine(string sound)
	{
		return null;
	}

	[Token(Token = "0x60007B8")]
	[Address(RVA = "0x1EA2F04", Offset = "0x1EA2F04", VA = "0x1EA2F04")]
	public void Play(string sound, float volumneMultiplier = 1f, float pitchMultiplier = 1f)
	{
	}

	[Token(Token = "0x60007B9")]
	[Address(RVA = "0x1EA5420", Offset = "0x1EA5420", VA = "0x1EA5420")]
	public string PlayRandom(string[] sounds, float volumneMultiplier = 1f, float pitchMultiplier = 1f)
	{
		return null;
	}

	[Token(Token = "0x60007BA")]
	[Address(RVA = "0x1EA54B4", Offset = "0x1EA54B4", VA = "0x1EA54B4")]
	public void PlayRandomWithPrefix(string prefix, float volumneMultiplier = 1f, float pitchMultiplier = 1f)
	{
	}

	[Token(Token = "0x60007BB")]
	[Address(RVA = "0x1EA5784", Offset = "0x1EA5784", VA = "0x1EA5784")]
	public void PlayRandomFromGroup(string groupName, float volumneMultiplier = 1f, float pitchMultiplier = 1f)
	{
	}

	[Token(Token = "0x60007BC")]
	[Address(RVA = "0x1EA4ED0", Offset = "0x1EA4ED0", VA = "0x1EA4ED0")]
	public void PlayRandomFromGroup(string groupName)
	{
	}

	[Token(Token = "0x60007BD")]
	[Address(RVA = "0x1EA59EC", Offset = "0x1EA59EC", VA = "0x1EA59EC")]
	public void PlayFromGroupWithDelay(string sound, float delay)
	{
	}

	[Token(Token = "0x60007BE")]
	[Address(RVA = "0x1EA5A18", Offset = "0x1EA5A18", VA = "0x1EA5A18")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB51DC", Offset = "0xAB51DC")]
	private IEnumerator PlayFromGroupWithDelayCoroutine(string sound, float delay)
	{
		return null;
	}

	[Token(Token = "0x60007BF")]
	[Address(RVA = "0x1EA5AA0", Offset = "0x1EA5AA0", VA = "0x1EA5AA0")]
	public void Stop(string sound)
	{
	}

	[Token(Token = "0x60007C0")]
	[Address(RVA = "0x1EA4DE4", Offset = "0x1EA4DE4", VA = "0x1EA4DE4")]
	public Sound GetSound(string sound)
	{
		return null;
	}

	[Token(Token = "0x60007C1")]
	[Address(RVA = "0x1EA5C80", Offset = "0x1EA5C80", VA = "0x1EA5C80")]
	public AudioSource GetAudioSource(string sound)
	{
		return null;
	}

	[Token(Token = "0x60007C2")]
	[Address(RVA = "0x1EA5CA0", Offset = "0x1EA5CA0", VA = "0x1EA5CA0")]
	public void UpdateVolumeLevelOfPlayingSounds(float multiplier)
	{
	}

	[Token(Token = "0x60007C3")]
	[Address(RVA = "0x1EA5D88", Offset = "0x1EA5D88", VA = "0x1EA5D88")]
	public void UpdateVolumeLevel(float multiplier)
	{
	}

	[Token(Token = "0x60007C4")]
	[Address(RVA = "0x1EA5D90", Offset = "0x1EA5D90", VA = "0x1EA5D90")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60007C5")]
	[Address(RVA = "0x1EA5D9C", Offset = "0x1EA5D9C", VA = "0x1EA5D9C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60007C6")]
	[Address(RVA = "0x1EA60E0", Offset = "0x1EA60E0", VA = "0x1EA60E0")]
	public void ResetSoundsPitch(float timeToResume)
	{
	}

	[Token(Token = "0x60007C7")]
	[Address(RVA = "0x1EA62C8", Offset = "0x1EA62C8", VA = "0x1EA62C8")]
	public void PitchDownSounds(float timeToSlow)
	{
	}

	[Token(Token = "0x60007C8")]
	[Address(RVA = "0x1EA6238", Offset = "0x1EA6238", VA = "0x1EA6238")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB523C", Offset = "0xAB523C")]
	private IEnumerator UpdatePitchCoroutine(AudioSource source, float timeToTransition, float startingPitch, float targetPitch)
	{
		return null;
	}

	[Token(Token = "0x60007C9")]
	[Address(RVA = "0x1EA6490", Offset = "0x1EA6490", VA = "0x1EA6490")]
	public void LerpSoundVolume(string soundName, float timeToTransition, float targetVolumeMultipler)
	{
	}

	[Token(Token = "0x60007CA")]
	[Address(RVA = "0x1EA6514", Offset = "0x1EA6514", VA = "0x1EA6514")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB529C", Offset = "0xAB529C")]
	private IEnumerator UpdateVolumeCoroutine(AudioSource source, float timeToTransition, float startingVolume, float targetVolume)
	{
		return null;
	}

	[Token(Token = "0x60007CB")]
	[Address(RVA = "0x1EA6410", Offset = "0x1EA6410", VA = "0x1EA6410")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB52FC", Offset = "0xAB52FC")]
	private IEnumerator UpdatePitchCoroutine(AudioSource source, float timeToTransition, float startingPitch)
	{
		return null;
	}

	[Token(Token = "0x60007CC")]
	[Address(RVA = "0x1EA65A4", Offset = "0x1EA65A4", VA = "0x1EA65A4")]
	public AudioHandler()
	{
	}
}
[Token(Token = "0x200015C")]
public class AussieSocket : HVRSocket
{
	[Token(Token = "0x200015D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAACC4", Offset = "0xAAACC4")]
	private sealed class <DisableColliders>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Rigidbody rb;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HVRGrabbable g;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <time>5__2;

		[Token(Token = "0x17000147")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000808")]
			[Address(RVA = "0x1F49EB4", Offset = "0x1F49EB4", VA = "0x1F49EB4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000148")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600080A")]
			[Address(RVA = "0x1F49EFC", Offset = "0x1F49EFC", VA = "0x1F49EFC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x1F49D84", Offset = "0x1F49D84", VA = "0x1F49D84")]
		[DebuggerHidden]
		public <DisableColliders>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x1F49DB0", Offset = "0x1F49DB0", VA = "0x1F49DB0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x1F49DB4", Offset = "0x1F49DB4", VA = "0x1F49DB4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x1F49EBC", Offset = "0x1F49EBC", VA = "0x1F49EBC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000789")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private AudioHandler audioHandler;

	[Token(Token = "0x400078A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	public bool canRemoveGrabbableWhenHeld;

	[Token(Token = "0x400078B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	public HVRGrabbable grabbable;

	[Token(Token = "0x400078C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private HVRGrabbable _socketedObject;

	[Token(Token = "0x400078D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private ActivatableGrabIndicator selfGrabIndicator;

	[Token(Token = "0x400078E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private List<ActivatableGrabIndicator> activatedGrabInidcators;

	[Token(Token = "0x400078F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public bool popOnRelease;

	[Token(Token = "0x4000790")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D9")]
	public bool inSpawner;

	[Token(Token = "0x60007F6")]
	[Address(RVA = "0x1EA8424", Offset = "0x1EA8424", VA = "0x1EA8424", Slot = "25")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60007F7")]
	[Address(RVA = "0x1EA8760", Offset = "0x1EA8760", VA = "0x1EA8760", Slot = "62")]
	protected override void PlaySocketedSFX(HVRSocketable socketable)
	{
	}

	[Token(Token = "0x60007F8")]
	[Address(RVA = "0x1EA8858", Offset = "0x1EA8858", VA = "0x1EA8858", Slot = "63")]
	protected override void PlayUnsocketedSFX(HVRGrabbable grabbable)
	{
	}

	[Token(Token = "0x60007F9")]
	[Address(RVA = "0x1EA87B8", Offset = "0x1EA87B8", VA = "0x1EA87B8")]
	private AudioHandler GetAudioHandler()
	{
		return null;
	}

	[Token(Token = "0x60007FA")]
	[Address(RVA = "0x1EA88B0", Offset = "0x1EA88B0", VA = "0x1EA88B0")]
	public void OnObjectSocketed(HVRGrabberBase _grabber, HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x60007FB")]
	[Address(RVA = "0x1EA8D04", Offset = "0x1EA8D04", VA = "0x1EA8D04")]
	public void OnObjectUnsocketed(HVRGrabberBase _grabber, HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x60007FC")]
	[Address(RVA = "0x1EA8DF0", Offset = "0x1EA8DF0", VA = "0x1EA8DF0")]
	public void OnObjectHandGrabbed(HVRGrabberBase _grabber, HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x60007FD")]
	[Address(RVA = "0x1EA8E80", Offset = "0x1EA8E80", VA = "0x1EA8E80")]
	public void OnObjectHandReleased(HVRGrabberBase _grabber, HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x60007FE")]
	[Address(RVA = "0x1EA8994", Offset = "0x1EA8994", VA = "0x1EA8994")]
	private void DisableGrabbable(HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x60007FF")]
	[Address(RVA = "0x1EA8D34", Offset = "0x1EA8D34", VA = "0x1EA8D34")]
	private void EnableGrabbable(HVRGrabbable _grabbable)
	{
	}

	[Token(Token = "0x6000800")]
	[Address(RVA = "0x1EA8BB4", Offset = "0x1EA8BB4", VA = "0x1EA8BB4")]
	private void ActivateGrabIndicators()
	{
	}

	[Token(Token = "0x6000801")]
	[Address(RVA = "0x1EA8A50", Offset = "0x1EA8A50", VA = "0x1EA8A50")]
	private void DeactivateGrabIndicators()
	{
	}

	[Token(Token = "0x6000802")]
	[Address(RVA = "0x1EA8F0C", Offset = "0x1EA8F0C", VA = "0x1EA8F0C", Slot = "29")]
	public override void ForceRelease()
	{
	}

	[Token(Token = "0x6000803")]
	[Address(RVA = "0x1EA8F90", Offset = "0x1EA8F90", VA = "0x1EA8F90")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB54EC", Offset = "0xAB54EC")]
	private IEnumerator DisableColliders(Rigidbody rb, HVRGrabbable g)
	{
		return null;
	}

	[Token(Token = "0x6000804")]
	[Address(RVA = "0x1EA9008", Offset = "0x1EA9008", VA = "0x1EA9008")]
	public AussieSocket()
	{
	}
}
[Token(Token = "0x200015E")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xAAACD4", Offset = "0xAAACD4")]
public class CollisionSounds : MonoBehaviour
{
	[Token(Token = "0x200015F")]
	public enum materialTypes
	{
		[Token(Token = "0x40007A0")]
		Wood,
		[Token(Token = "0x40007A1")]
		Metal,
		[Token(Token = "0x40007A2")]
		Glass,
		[Token(Token = "0x40007A3")]
		Boomerang,
		[Token(Token = "0x40007A4")]
		Organic,
		[Token(Token = "0x40007A5")]
		Floor
	}

	[Token(Token = "0x4000796")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAABC94", Offset = "0xAABC94")]
	public float minimumColisionStrengh;

	[Token(Token = "0x4000797")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAABCCC", Offset = "0xAABCCC")]
	public float maximumColisionStrengh;

	[Token(Token = "0x4000798")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public materialTypes materialType;

	[Token(Token = "0x4000799")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int audioPriority;

	[Token(Token = "0x400079A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioHandler audioHandler;

	[Token(Token = "0x400079B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<string> availableSounds;

	[Token(Token = "0x400079C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject collisionParticles;

	[Token(Token = "0x400079D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int particlesForceThreshold;

	[Token(Token = "0x400079E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int collisionParticlesSizeRatio;

	[Token(Token = "0x600080B")]
	[Address(RVA = "0x1EB232C", Offset = "0x1EB232C", VA = "0x1EB232C")]
	private void Start()
	{
	}

	[Token(Token = "0x600080C")]
	[Address(RVA = "0x1EB2400", Offset = "0x1EB2400", VA = "0x1EB2400")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600080D")]
	[Address(RVA = "0x1EB276C", Offset = "0x1EB276C", VA = "0x1EB276C")]
	private void PlayCollisionSound(string sound, Collision collision)
	{
	}

	[Token(Token = "0x600080E")]
	[Address(RVA = "0x1EB28C0", Offset = "0x1EB28C0", VA = "0x1EB28C0")]
	public CollisionSounds()
	{
	}
}
[Token(Token = "0x2000160")]
public class CookingArcadeWaveHandler : ArcadeWaveHandler
{
	[Serializable]
	[Token(Token = "0x2000161")]
	public class RequestList
	{
		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<RequestHandler.Request> requests;

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x1F4E1D0", Offset = "0x1F4E1D0", VA = "0x1F4E1D0")]
		public RequestList()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000162")]
	public class RequestTemplate
	{
		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RequestType type;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int firstSpawnAtWave;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int initialTimeLimit;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int minimumTimeLimit;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float timeRatioPerWave;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int waitTimeBeforeRequest;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float randomnessWeight;

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x1F4E1D8", Offset = "0x1F4E1D8", VA = "0x1F4E1D8")]
		public RequestTemplate()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000163")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAD34", Offset = "0xAAAD34")]
	private sealed class <>c
	{
		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<RequestTemplate, float> <>9__12_0;

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x1F4DD98", Offset = "0x1F4DD98", VA = "0x1F4DD98")]
		public <>c()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x1F4DDA0", Offset = "0x1F4DDA0", VA = "0x1F4DDA0")]
		internal float <StartNextProceduralGeneratedRequestsWave>b__12_0(RequestTemplate x)
		{
			return default(float);
		}
	}

	[Token(Token = "0x2000164")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAD44", Offset = "0xAAAD44")]
	private sealed class <OverrideRequestListCoroutine>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CookingArcadeWaveHandler <>4__this;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<RequestHandler.Request> requestsToSpawn;

		[Token(Token = "0x17000149")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000820")]
			[Address(RVA = "0x1F4DEB4", Offset = "0x1F4DEB4", VA = "0x1F4DEB4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000822")]
			[Address(RVA = "0x1F4DEFC", Offset = "0x1F4DEFC", VA = "0x1F4DEFC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x1F4DDD4", Offset = "0x1F4DDD4", VA = "0x1F4DDD4")]
		[DebuggerHidden]
		public <OverrideRequestListCoroutine>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x1F4DE00", Offset = "0x1F4DE00", VA = "0x1F4DE00", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x1F4DE04", Offset = "0x1F4DE04", VA = "0x1F4DE04", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x1F4DEBC", Offset = "0x1F4DEBC", VA = "0x1F4DEBC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000165")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAD54", Offset = "0xAAAD54")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int waveNumber;

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x1F4DDA8", Offset = "0x1F4DDA8", VA = "0x1F4DDA8")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x1F4DDB0", Offset = "0x1F4DDB0", VA = "0x1F4DDB0")]
		internal bool <GetWeightedTemplates>b__0(RequestTemplate item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000166")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAD64", Offset = "0xAAAD64")]
	private sealed class <Wave5Update>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CookingArcadeWaveHandler <>4__this;

		[Token(Token = "0x1700014B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000828")]
			[Address(RVA = "0x1F4E180", Offset = "0x1F4E180", VA = "0x1F4E180", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600082A")]
			[Address(RVA = "0x1F4E1C8", Offset = "0x1F4E1C8", VA = "0x1F4E1C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x1F4E060", Offset = "0x1F4E060", VA = "0x1F4E060")]
		[DebuggerHidden]
		public <Wave5Update>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x1F4E08C", Offset = "0x1F4E08C", VA = "0x1F4E08C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x1F4E090", Offset = "0x1F4E090", VA = "0x1F4E090", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x1F4E188", Offset = "0x1F4E188", VA = "0x1F4E188", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000167")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAD74", Offset = "0xAAAD74")]
	private sealed class <Wave10Update>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CookingArcadeWaveHandler <>4__this;

		[Token(Token = "0x1700014D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600082E")]
			[Address(RVA = "0x1F4E010", Offset = "0x1F4E010", VA = "0x1F4E010", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000830")]
			[Address(RVA = "0x1F4E058", Offset = "0x1F4E058", VA = "0x1F4E058", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x1F4DF04", Offset = "0x1F4DF04", VA = "0x1F4DF04")]
		[DebuggerHidden]
		public <Wave10Update>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x1F4DF30", Offset = "0x1F4DF30", VA = "0x1F4DF30", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x1F4DF34", Offset = "0x1F4DF34", VA = "0x1F4DF34", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x1F4E018", Offset = "0x1F4E018", VA = "0x1F4E018", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40007A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xAABD04", Offset = "0xAABD04")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAABD04", Offset = "0xAABD04")]
	public List<RequestList> premadeRequestsLists;

	[Token(Token = "0x40007A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool startedInfiniteRequestsSpawner;

	[Token(Token = "0x40007A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RequestHandler infiniteRequestHandler;

	[Token(Token = "0x40007A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RequestTemplate[] requestTemplates;

	[Token(Token = "0x40007AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Dictionary<int, List<RequestTemplate>> weigthedTemplateCache;

	[Token(Token = "0x40007AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject secondaryBeerbox;

	[Token(Token = "0x40007AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject[] snagSpawners;

	[Token(Token = "0x40007AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject[] skewerSpawners;

	[Token(Token = "0x600080F")]
	[Address(RVA = "0x1EB2B50", Offset = "0x1EB2B50", VA = "0x1EB2B50", Slot = "9")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x6000810")]
	[Address(RVA = "0x1EB2C34", Offset = "0x1EB2C34", VA = "0x1EB2C34", Slot = "4")]
	public override void StartSpawners(int waveNumber)
	{
	}

	[Token(Token = "0x6000811")]
	[Address(RVA = "0x1EB2DD0", Offset = "0x1EB2DD0", VA = "0x1EB2DD0")]
	private void StartNextProceduralGeneratedRequestsWave(int waveNumber)
	{
	}

	[Token(Token = "0x6000812")]
	[Address(RVA = "0x1EB2D58", Offset = "0x1EB2D58", VA = "0x1EB2D58")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB559C", Offset = "0xAB559C")]
	private IEnumerator OverrideRequestListCoroutine(List<RequestHandler.Request> requestsToSpawn)
	{
		return null;
	}

	[Token(Token = "0x6000813")]
	[Address(RVA = "0x1EB32B0", Offset = "0x1EB32B0", VA = "0x1EB32B0")]
	private List<RequestTemplate> GetWeightedTemplates(int waveNumber)
	{
		return null;
	}

	[Token(Token = "0x6000814")]
	[Address(RVA = "0x1EB35F0", Offset = "0x1EB35F0", VA = "0x1EB35F0")]
	private void OnAllRequestsHandled()
	{
	}

	[Token(Token = "0x6000815")]
	[Address(RVA = "0x1EB376C", Offset = "0x1EB376C", VA = "0x1EB376C", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB55FC", Offset = "0xAB55FC")]
	public override IEnumerator Wave5Update()
	{
		return null;
	}

	[Token(Token = "0x6000816")]
	[Address(RVA = "0x1EB37D8", Offset = "0x1EB37D8", VA = "0x1EB37D8", Slot = "6")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB565C", Offset = "0xAB565C")]
	public override IEnumerator Wave10Update()
	{
		return null;
	}

	[Token(Token = "0x6000817")]
	[Address(RVA = "0x1EB3844", Offset = "0x1EB3844", VA = "0x1EB3844")]
	public CookingArcadeWaveHandler()
	{
	}
}
[Token(Token = "0x2000168")]
public class CreateVRUtils : MonoBehaviour
{
	[Token(Token = "0x40007C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject vrUtilsPrefab;

	[Token(Token = "0x40007C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject vrUtils;

	[Token(Token = "0x40007C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject easySaveMngr;

	[Token(Token = "0x40007C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject steamUtils;

	[Token(Token = "0x40007C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject picoUtils;

	[Token(Token = "0x6000831")]
	[Address(RVA = "0x1EB3940", Offset = "0x1EB3940", VA = "0x1EB3940")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000832")]
	[Address(RVA = "0x1EB3A44", Offset = "0x1EB3A44", VA = "0x1EB3A44")]
	private void Start()
	{
	}

	[Token(Token = "0x6000833")]
	[Address(RVA = "0x1EB3B68", Offset = "0x1EB3B68", VA = "0x1EB3B68")]
	public CreateVRUtils()
	{
	}
}
[Token(Token = "0x2000169")]
public class DefenseArcadeWaveHandler : ArcadeWaveHandler
{
	[Token(Token = "0x200016A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAD84", Offset = "0xAAAD84")]
	private sealed class <Wave5Update>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DefenseArcadeWaveHandler <>4__this;

		[Token(Token = "0x1700014F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000840")]
			[Address(RVA = "0x1F4ECB8", Offset = "0x1F4ECB8", VA = "0x1F4ECB8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000150")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000842")]
			[Address(RVA = "0x1F4ED00", Offset = "0x1F4ED00", VA = "0x1F4ED00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x1F4EBD0", Offset = "0x1F4EBD0", VA = "0x1F4EBD0")]
		[DebuggerHidden]
		public <Wave5Update>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x1F4EBFC", Offset = "0x1F4EBFC", VA = "0x1F4EBFC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x1F4EC00", Offset = "0x1F4EC00", VA = "0x1F4EC00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x1F4ECC0", Offset = "0x1F4ECC0", VA = "0x1F4ECC0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200016B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAD94", Offset = "0xAAAD94")]
	private sealed class <Wave10Update>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DefenseArcadeWaveHandler <>4__this;

		[Token(Token = "0x17000151")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000846")]
			[Address(RVA = "0x1F4E678", Offset = "0x1F4E678", VA = "0x1F4E678", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000152")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000848")]
			[Address(RVA = "0x1F4E6C0", Offset = "0x1F4E6C0", VA = "0x1F4E6C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x1F4E518", Offset = "0x1F4E518", VA = "0x1F4E518")]
		[DebuggerHidden]
		public <Wave10Update>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x1F4E544", Offset = "0x1F4E544", VA = "0x1F4E544", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x1F4E548", Offset = "0x1F4E548", VA = "0x1F4E548", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x1F4E680", Offset = "0x1F4E680", VA = "0x1F4E680", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200016C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAADA4", Offset = "0xAAADA4")]
	private sealed class <Wave15Update>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DefenseArcadeWaveHandler <>4__this;

		[Token(Token = "0x17000153")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600084C")]
			[Address(RVA = "0x1F4E8E8", Offset = "0x1F4E8E8", VA = "0x1F4E8E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000154")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600084E")]
			[Address(RVA = "0x1F4E930", Offset = "0x1F4E930", VA = "0x1F4E930", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x1F4E6C8", Offset = "0x1F4E6C8", VA = "0x1F4E6C8")]
		[DebuggerHidden]
		public <Wave15Update>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x1F4E6F4", Offset = "0x1F4E6F4", VA = "0x1F4E6F4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x1F4E6F8", Offset = "0x1F4E6F8", VA = "0x1F4E6F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x1F4E8F0", Offset = "0x1F4E8F0", VA = "0x1F4E8F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200016D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAADB4", Offset = "0xAAADB4")]
	private sealed class <Wave20Update>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DefenseArcadeWaveHandler <>4__this;

		[Token(Token = "0x17000155")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000852")]
			[Address(RVA = "0x1F4EB80", Offset = "0x1F4EB80", VA = "0x1F4EB80", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000156")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000854")]
			[Address(RVA = "0x1F4EBC8", Offset = "0x1F4EBC8", VA = "0x1F4EBC8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x1F4E938", Offset = "0x1F4E938", VA = "0x1F4E938")]
		[DebuggerHidden]
		public <Wave20Update>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x1F4E964", Offset = "0x1F4E964", VA = "0x1F4E964", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x1F4E968", Offset = "0x1F4E968", VA = "0x1F4E968", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x1F4EB88", Offset = "0x1F4EB88", VA = "0x1F4EB88", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40007C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xAABD54", Offset = "0xAABD54")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAABD54", Offset = "0xAABD54")]
	public GameObject swapableBeerbox;

	[Token(Token = "0x40007CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject secondSwapableBeerbox;

	[Token(Token = "0x40007CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject thirdBeerbox;

	[Token(Token = "0x40007CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xAABDA4", Offset = "0xAABDA4")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAABDA4", Offset = "0xAABDA4")]
	public Transform targetBeer1boxWave10;

	[Token(Token = "0x40007CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform targetBeer2boxWave10;

	[Token(Token = "0x40007CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform targetBeer1boxWave20;

	[Token(Token = "0x40007CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Transform targetBeer2boxWave20;

	[Token(Token = "0x40007D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Transform targetBeer3boxWave20;

	[Token(Token = "0x6000834")]
	[Address(RVA = "0x1EB4404", Offset = "0x1EB4404", VA = "0x1EB4404", Slot = "9")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x6000835")]
	[Address(RVA = "0x1EB44E8", Offset = "0x1EB44E8", VA = "0x1EB44E8", Slot = "4")]
	public override void StartSpawners(int waveNumber)
	{
	}

	[Token(Token = "0x6000836")]
	[Address(RVA = "0x1EB454C", Offset = "0x1EB454C", VA = "0x1EB454C")]
	private void OnAllEnemiesGone()
	{
	}

	[Token(Token = "0x6000837")]
	[Address(RVA = "0x1EB4584", Offset = "0x1EB4584", VA = "0x1EB4584", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB57AC", Offset = "0xAB57AC")]
	public override IEnumerator Wave5Update()
	{
		return null;
	}

	[Token(Token = "0x6000838")]
	[Address(RVA = "0x1EB45F0", Offset = "0x1EB45F0", VA = "0x1EB45F0", Slot = "6")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB580C", Offset = "0xAB580C")]
	public override IEnumerator Wave10Update()
	{
		return null;
	}

	[Token(Token = "0x6000839")]
	[Address(RVA = "0x1EB465C", Offset = "0x1EB465C", VA = "0x1EB465C", Slot = "7")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB586C", Offset = "0xAB586C")]
	public override IEnumerator Wave15Update()
	{
		return null;
	}

	[Token(Token = "0x600083A")]
	[Address(RVA = "0x1EB46C8", Offset = "0x1EB46C8", VA = "0x1EB46C8", Slot = "8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB58CC", Offset = "0xAB58CC")]
	public override IEnumerator Wave20Update()
	{
		return null;
	}

	[Token(Token = "0x600083B")]
	[Address(RVA = "0x1EB4734", Offset = "0x1EB4734", VA = "0x1EB4734")]
	private void MoveAndRotateObject(GameObject obj, Transform target)
	{
	}

	[Token(Token = "0x600083C")]
	[Address(RVA = "0x1EB4AE4", Offset = "0x1EB4AE4", VA = "0x1EB4AE4")]
	public DefenseArcadeWaveHandler()
	{
	}
}
[Token(Token = "0x200016E")]
public class DestroyOnLoadScene : MonoBehaviour
{
	[Token(Token = "0x6000855")]
	[Address(RVA = "0x1EB4F5C", Offset = "0x1EB4F5C", VA = "0x1EB4F5C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000856")]
	[Address(RVA = "0x1EB5040", Offset = "0x1EB5040", VA = "0x1EB5040")]
	private void SelfDestruct()
	{
	}

	[Token(Token = "0x6000857")]
	[Address(RVA = "0x1EB5170", Offset = "0x1EB5170", VA = "0x1EB5170")]
	public DestroyOnLoadScene()
	{
	}
}
[Token(Token = "0x200016F")]
public class DifficultySelection : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000170")]
	public class Difficulty
	{
		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle toggle;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DifficultyConfig config;

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x1F4EFE8", Offset = "0x1F4EFE8", VA = "0x1F4EFE8")]
		public Difficulty()
		{
		}
	}

	[Token(Token = "0x2000171")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAADC4", Offset = "0xAAADC4")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Difficulty d;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DifficultySelection <>4__this;

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x1F4EFB4", Offset = "0x1F4EFB4", VA = "0x1F4EFB4")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x1F4EFBC", Offset = "0x1F4EFBC", VA = "0x1F4EFBC")]
		internal void <Start>b__0(bool value)
		{
		}
	}

	[Token(Token = "0x40007DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Difficulty[] difficultyOptions;

	[Token(Token = "0x40007DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image levelDurationIndicator;

	[Token(Token = "0x6000858")]
	[Address(RVA = "0x1EB5198", Offset = "0x1EB5198", VA = "0x1EB5198")]
	private void Start()
	{
	}

	[Token(Token = "0x6000859")]
	[Address(RVA = "0x1EB52F8", Offset = "0x1EB52F8", VA = "0x1EB52F8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600085A")]
	[Address(RVA = "0x1EB5478", Offset = "0x1EB5478", VA = "0x1EB5478")]
	private void SelectDifficulty(Difficulty difficulty, bool value)
	{
	}

	[Token(Token = "0x600085B")]
	[Address(RVA = "0x1EB5528", Offset = "0x1EB5528", VA = "0x1EB5528")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600085C")]
	[Address(RVA = "0x1EB55AC", Offset = "0x1EB55AC", VA = "0x1EB55AC")]
	public DifficultySelection()
	{
	}
}
[Token(Token = "0x2000172")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xAAADD4", Offset = "0xAAADD4")]
public class DisableCollisionsOnForceGrab : MonoBehaviour
{
	[Token(Token = "0x2000173")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAE34", Offset = "0xAAAE34")]
	private sealed class <DisableCollisionsTemporarily>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DisableCollisionsOnForceGrab <>4__this;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <counter>5__2;

		[Token(Token = "0x17000157")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000867")]
			[Address(RVA = "0x1F4F310", Offset = "0x1F4F310", VA = "0x1F4F310", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000158")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000869")]
			[Address(RVA = "0x1F4F358", Offset = "0x1F4F358", VA = "0x1F4F358", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x1F4F1EC", Offset = "0x1F4F1EC", VA = "0x1F4F1EC")]
		[DebuggerHidden]
		public <DisableCollisionsTemporarily>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x1F4F218", Offset = "0x1F4F218", VA = "0x1F4F218", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x1F4F21C", Offset = "0x1F4F21C", VA = "0x1F4F21C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x1F4F318", Offset = "0x1F4F318", VA = "0x1F4F318", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40007E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Rigidbody rb;

	[Token(Token = "0x40007E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private HVRGrabbable grabbable;

	[Token(Token = "0x6000860")]
	[Address(RVA = "0x1F1A1EC", Offset = "0x1F1A1EC", VA = "0x1F1A1EC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000861")]
	[Address(RVA = "0x1F1A2F8", Offset = "0x1F1A2F8", VA = "0x1F1A2F8")]
	private void OnGrabbed(HVRGrabberBase _, HVRGrabbable __)
	{
	}

	[Token(Token = "0x6000862")]
	[Address(RVA = "0x1F1A324", Offset = "0x1F1A324", VA = "0x1F1A324")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB5A6C", Offset = "0xAB5A6C")]
	private IEnumerator DisableCollisionsTemporarily()
	{
		return null;
	}

	[Token(Token = "0x6000863")]
	[Address(RVA = "0x1F1A390", Offset = "0x1F1A390", VA = "0x1F1A390")]
	public DisableCollisionsOnForceGrab()
	{
	}
}
[Token(Token = "0x2000174")]
public class DisplayVersion : MonoBehaviour
{
	[Token(Token = "0x40007EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TextMeshProUGUI text;

	[Token(Token = "0x600086A")]
	[Address(RVA = "0x1F1AC68", Offset = "0x1F1AC68", VA = "0x1F1AC68")]
	private void Start()
	{
	}

	[Token(Token = "0x600086B")]
	[Address(RVA = "0x1F1AD08", Offset = "0x1F1AD08", VA = "0x1F1AD08")]
	public DisplayVersion()
	{
	}
}
[Token(Token = "0x2000175")]
public class EnableIfLevelUnlocked : MonoBehaviour
{
	[Token(Token = "0x40007EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int level;

	[Token(Token = "0x40007EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject objectToEnable;

	[Token(Token = "0x600086C")]
	[Address(RVA = "0x1F1D740", Offset = "0x1F1D740", VA = "0x1F1D740")]
	private void Start()
	{
	}

	[Token(Token = "0x600086D")]
	[Address(RVA = "0x1F1D744", Offset = "0x1F1D744", VA = "0x1F1D744")]
	public void CheckLevels()
	{
	}

	[Token(Token = "0x600086E")]
	[Address(RVA = "0x1F1D81C", Offset = "0x1F1D81C", VA = "0x1F1D81C")]
	public EnableIfLevelUnlocked()
	{
	}
}
[Token(Token = "0x2000176")]
public class Events
{
	[Serializable]
	[Token(Token = "0x2000177")]
	public class EventEnterNewLevel : UnityEvent
	{
		[Token(Token = "0x6000870")]
		[Address(RVA = "0x1FE4900", Offset = "0x1FE4900", VA = "0x1FE4900")]
		public EventEnterNewLevel()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000178")]
	public class EventExitLevel : UnityEvent
	{
		[Token(Token = "0x6000871")]
		[Address(RVA = "0x1FE4908", Offset = "0x1FE4908", VA = "0x1FE4908")]
		public EventExitLevel()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000179")]
	public class EventEnemyDeath : UnityEvent<Enemy>
	{
		[Token(Token = "0x6000872")]
		[Address(RVA = "0x1FE481C", Offset = "0x1FE481C", VA = "0x1FE481C")]
		public EventEnemyDeath()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200017A")]
	public class EventEnemyGone : UnityEvent<Enemy>
	{
		[Token(Token = "0x6000873")]
		[Address(RVA = "0x1FE4868", Offset = "0x1FE4868", VA = "0x1FE4868")]
		public EventEnemyGone()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200017B")]
	public class EventEnemySpawn : UnityEvent<Enemy>
	{
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x1FE48B4", Offset = "0x1FE48B4", VA = "0x1FE48B4")]
		public EventEnemySpawn()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200017C")]
	public class EventBeerDisapeared : UnityEvent<Beer>
	{
		[Token(Token = "0x6000875")]
		[Address(RVA = "0x1FE4698", Offset = "0x1FE4698", VA = "0x1FE4698")]
		public EventBeerDisapeared()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200017D")]
	public class EventBeerBoxDisapeared : UnityEvent<BeerBox>
	{
		[Token(Token = "0x6000876")]
		[Address(RVA = "0x1FE4644", Offset = "0x1FE4644", VA = "0x1FE4644")]
		public EventBeerBoxDisapeared()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200017E")]
	public class EventBoomerangDestroy : UnityEvent<Boomerang>
	{
		[Token(Token = "0x6000877")]
		[Address(RVA = "0x1FE46E4", Offset = "0x1FE46E4", VA = "0x1FE46E4")]
		public EventBoomerangDestroy()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200017F")]
	public class EventBoomerangGrab : UnityEvent<Boomerang>
	{
		[Token(Token = "0x6000878")]
		[Address(RVA = "0x1FE4730", Offset = "0x1FE4730", VA = "0x1FE4730")]
		public EventBoomerangGrab()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000180")]
	public class EventFinishGame : UnityEvent
	{
		[Token(Token = "0x6000879")]
		[Address(RVA = "0x1FE4910", Offset = "0x1FE4910", VA = "0x1FE4910")]
		public EventFinishGame()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000181")]
	public class EventScoreSubmit : UnityEvent
	{
		[Token(Token = "0x600087A")]
		[Address(RVA = "0x1FE4AB4", Offset = "0x1FE4AB4", VA = "0x1FE4AB4")]
		public EventScoreSubmit()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000182")]
	public class EventBeerDelivered : UnityEvent
	{
		[Token(Token = "0x600087B")]
		[Address(RVA = "0x1FE4690", Offset = "0x1FE4690", VA = "0x1FE4690")]
		public EventBeerDelivered()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000183")]
	public class EventHamburgerDelivered : UnityEvent
	{
		[Token(Token = "0x600087C")]
		[Address(RVA = "0x1FE4918", Offset = "0x1FE4918", VA = "0x1FE4918")]
		public EventHamburgerDelivered()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000184")]
	public class EventSnagDelivered : UnityEvent
	{
		[Token(Token = "0x600087D")]
		[Address(RVA = "0x1FE4ACC", Offset = "0x1FE4ACC", VA = "0x1FE4ACC")]
		public EventSnagDelivered()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000185")]
	public class EventSkewerDelivered : UnityEvent
	{
		[Token(Token = "0x600087E")]
		[Address(RVA = "0x1FE4AC4", Offset = "0x1FE4AC4", VA = "0x1FE4AC4")]
		public EventSkewerDelivered()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000186")]
	public class EventPlayerHurt : UnityEvent<int>
	{
		[Token(Token = "0x600087F")]
		[Address(RVA = "0x1FE49D0", Offset = "0x1FE49D0", VA = "0x1FE49D0")]
		public EventPlayerHurt()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000187")]
	public class EventSettingsChanged : UnityEvent
	{
		[Token(Token = "0x6000880")]
		[Address(RVA = "0x1FE4ABC", Offset = "0x1FE4ABC", VA = "0x1FE4ABC")]
		public EventSettingsChanged()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000188")]
	public class EventAllEnemiesGone : UnityEvent
	{
		[Token(Token = "0x6000881")]
		[Address(RVA = "0x1FE4634", Offset = "0x1FE4634", VA = "0x1FE4634")]
		public EventAllEnemiesGone()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000189")]
	public class EventRequestMissed : UnityEvent<RequestSlot>
	{
		[Token(Token = "0x6000882")]
		[Address(RVA = "0x1FE4A68", Offset = "0x1FE4A68", VA = "0x1FE4A68")]
		public EventRequestMissed()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200018A")]
	public class EventRequestCompleted : UnityEvent<RequestSlot>
	{
		[Token(Token = "0x6000883")]
		[Address(RVA = "0x1FE4A1C", Offset = "0x1FE4A1C", VA = "0x1FE4A1C")]
		public EventRequestCompleted()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200018B")]
	public class EventAllRequestsComplete : UnityEvent
	{
		[Token(Token = "0x6000884")]
		[Address(RVA = "0x1FE463C", Offset = "0x1FE463C", VA = "0x1FE463C")]
		public EventAllRequestsComplete()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200018C")]
	public class EventDummyExploded : UnityEvent
	{
		[Token(Token = "0x6000885")]
		[Address(RVA = "0x1FE477C", Offset = "0x1FE477C", VA = "0x1FE477C")]
		public EventDummyExploded()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200018D")]
	public class EventDynamiteExploded : UnityEvent<Dynamite>
	{
		[Token(Token = "0x6000886")]
		[Address(RVA = "0x1FE47D0", Offset = "0x1FE47D0", VA = "0x1FE47D0")]
		public EventDynamiteExploded()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200018E")]
	public class EventDynamiteEntersHole : UnityEvent<MoleHole, Dynamite>
	{
		[Token(Token = "0x6000887")]
		[Address(RVA = "0x1FE4784", Offset = "0x1FE4784", VA = "0x1FE4784")]
		public EventDynamiteEntersHole()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200018F")]
	public class EventLevelActualStart : UnityEvent
	{
		[Token(Token = "0x6000888")]
		[Address(RVA = "0x1FE4974", Offset = "0x1FE4974", VA = "0x1FE4974")]
		public EventLevelActualStart()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000190")]
	public class EventNewArcadeWave : UnityEvent<int>
	{
		[Token(Token = "0x6000889")]
		[Address(RVA = "0x1FE497C", Offset = "0x1FE497C", VA = "0x1FE497C")]
		public EventNewArcadeWave()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000191")]
	public class EventPause : UnityEvent
	{
		[Token(Token = "0x600088A")]
		[Address(RVA = "0x1FE49C8", Offset = "0x1FE49C8", VA = "0x1FE49C8")]
		public EventPause()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000192")]
	public class EventUnPause : UnityEvent
	{
		[Token(Token = "0x600088B")]
		[Address(RVA = "0x1FE4AD4", Offset = "0x1FE4AD4", VA = "0x1FE4AD4")]
		public EventUnPause()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000193")]
	public class EventLanguageUpdate : UnityEvent
	{
		[Token(Token = "0x600088C")]
		[Address(RVA = "0x1FE4920", Offset = "0x1FE4920", VA = "0x1FE4920")]
		public EventLanguageUpdate()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000194")]
	public class EventLeaderboardUpdated : UnityEvent<List<Leaderboard.Score>>
	{
		[Token(Token = "0x600088D")]
		[Address(RVA = "0x1FE4928", Offset = "0x1FE4928", VA = "0x1FE4928")]
		public EventLeaderboardUpdated()
		{
		}
	}

	[Token(Token = "0x600086F")]
	[Address(RVA = "0x1F1E098", Offset = "0x1F1E098", VA = "0x1F1E098")]
	public Events()
	{
	}
}
[Token(Token = "0x2000195")]
public class FiniteSpawnerSocket : AussieSocket
{
	[Token(Token = "0x40007ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
	public int maxItemsToSpawn;

	[Token(Token = "0x40007EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public int itemsLeftToSpawn;

	[Token(Token = "0x40007EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
	public float coolDownTime;

	[Token(Token = "0x40007F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public TextMeshProUGUI textToDisplayItemsLeft;

	[Token(Token = "0x40007F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private GameObject originalItemPrefab;

	[Token(Token = "0x600088E")]
	[Address(RVA = "0x1F1F850", Offset = "0x1F1F850", VA = "0x1F1F850", Slot = "25")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600088F")]
	[Address(RVA = "0x1F1F958", Offset = "0x1F1F958", VA = "0x1F1F958")]
	private void UpdateItemsLeft(HVRGrabberBase _, HVRGrabbable __)
	{
	}

	[Token(Token = "0x6000890")]
	[Address(RVA = "0x1F1FA0C", Offset = "0x1F1FA0C", VA = "0x1F1FA0C")]
	public void AddMoreItems(int _number)
	{
	}

	[Token(Token = "0x6000891")]
	[Address(RVA = "0x1F1FABC", Offset = "0x1F1FABC", VA = "0x1F1FABC")]
	public FiniteSpawnerSocket()
	{
	}
}
[Token(Token = "0x2000196")]
public class Floor : Singleton<Floor>
{
	[Token(Token = "0x40007F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshCollider floorCollider;

	[Token(Token = "0x6000892")]
	[Address(RVA = "0x1F1FC80", Offset = "0x1F1FC80", VA = "0x1F1FC80")]
	private void Start()
	{
	}

	[Token(Token = "0x6000893")]
	[Address(RVA = "0x1F1FCD4", Offset = "0x1F1FCD4", VA = "0x1F1FCD4")]
	public RaycastHit ProjectOnFloor(Vector3 origin, float distance = 100f)
	{
		return default(RaycastHit);
	}

	[Token(Token = "0x6000894")]
	[Address(RVA = "0x1F1FE5C", Offset = "0x1F1FE5C", VA = "0x1F1FE5C")]
	public Floor()
	{
	}
}
[Serializable]
[Token(Token = "0x2000197")]
public class GameStatistics
{
	[Token(Token = "0x40007F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int attemptsOfBBQ;

	[Token(Token = "0x40007F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int boomerangsThrown;

	[Token(Token = "0x40007F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int boomerangsCaught;

	[Token(Token = "0x40007F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int maxTimesBoomerangWasCatched;

	[Token(Token = "0x40007F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int requestsServed;

	[Token(Token = "0x40007F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int beersLost;

	[Token(Token = "0x40007F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int beersServed;

	[Token(Token = "0x40007FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int hamburgersServed;

	[Token(Token = "0x40007FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int snagsServed;

	[Token(Token = "0x40007FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int skewersServed;

	[Token(Token = "0x40007FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int platesSmashed;

	[Token(Token = "0x40007FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int bottlesSmashed;

	[Token(Token = "0x40007FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int friendsDisapointed;

	[Token(Token = "0x4000800")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int vegemiteSandwichEaten;

	[Token(Token = "0x4000801")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int babyroosConcussed;

	[Token(Token = "0x4000802")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int kangaroosConcussed;

	[Token(Token = "0x4000803")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int koalasConcussed;

	[Token(Token = "0x4000804")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int platypusConcussed;

	[Token(Token = "0x4000805")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int dingosConcussed;

	[Token(Token = "0x4000806")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int quokkaPhotographed;

	[Token(Token = "0x4000807")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int quokkaMissed;

	[Token(Token = "0x4000808")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int punchesOnKangaroo;

	[Token(Token = "0x4000809")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int cricketGoals;

	[Token(Token = "0x6000895")]
	[Address(RVA = "0x1F229D8", Offset = "0x1F229D8", VA = "0x1F229D8")]
	public GameStatistics()
	{
	}

	[Token(Token = "0x6000896")]
	[Address(RVA = "0x1F219F0", Offset = "0x1F219F0", VA = "0x1F219F0")]
	public void AddLevelStats(GameStatistics levelStats)
	{
	}
}
[Token(Token = "0x2000198")]
public class ImageSequence : MonoBehaviour
{
	[Token(Token = "0x400080A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float repeatRate;

	[Token(Token = "0x400080B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image imageHolder;

	[Token(Token = "0x400080C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Sprite> images;

	[Token(Token = "0x400080D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int index;

	[Token(Token = "0x6000897")]
	[Address(RVA = "0x1F296AC", Offset = "0x1F296AC", VA = "0x1F296AC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000898")]
	[Address(RVA = "0x1F29704", Offset = "0x1F29704", VA = "0x1F29704")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000899")]
	[Address(RVA = "0x1F2970C", Offset = "0x1F2970C", VA = "0x1F2970C")]
	private void NextImage()
	{
	}

	[Token(Token = "0x600089A")]
	[Address(RVA = "0x1F297C0", Offset = "0x1F297C0", VA = "0x1F297C0")]
	public ImageSequence()
	{
	}
}
[Token(Token = "0x2000199")]
public enum HeightAdjustmentOption
{
	[Token(Token = "0x400080F")]
	player,
	[Token(Token = "0x4000810")]
	waist,
	[Token(Token = "0x4000811")]
	tables,
	[Token(Token = "0x4000812")]
	beerbox
}
[Token(Token = "0x200019A")]
public class InstanceHeightAdjustment : MonoBehaviour
{
	[Token(Token = "0x4000813")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public HeightAdjustmentOption key;

	[Token(Token = "0x4000814")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Vector3 originalPosition;

	[Token(Token = "0x600089B")]
	[Address(RVA = "0x1F297D0", Offset = "0x1F297D0", VA = "0x1F297D0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600089C")]
	[Address(RVA = "0x1F29818", Offset = "0x1F29818", VA = "0x1F29818")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600089D")]
	[Address(RVA = "0x1F2771C", Offset = "0x1F2771C", VA = "0x1F2771C")]
	public void SetPosition(float offset)
	{
	}

	[Token(Token = "0x600089E")]
	[Address(RVA = "0x1F298B4", Offset = "0x1F298B4", VA = "0x1F298B4")]
	public InstanceHeightAdjustment()
	{
	}
}
[Token(Token = "0x200019B")]
public class LanguageSettingsUI : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200019C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAE44", Offset = "0xAAAE44")]
	private sealed class <>c
	{
		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<bool> <>9__9_0;

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x1FEFFB0", Offset = "0x1FEFFB0", VA = "0x1FEFFB0")]
		public <>c()
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x1FEFFB8", Offset = "0x1FEFFB8", VA = "0x1FEFFB8")]
		internal bool <WaitForLanguageSelection>b__9_0()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200019D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAE54", Offset = "0xAAAE54")]
	private sealed class <WaitForLanguageSelection>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LanguageSettingsUI <>4__this;

		[Token(Token = "0x17000159")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008AC")]
			[Address(RVA = "0x1FF03C4", Offset = "0x1FF03C4", VA = "0x1FF03C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008AE")]
			[Address(RVA = "0x1FF040C", Offset = "0x1FF040C", VA = "0x1FF040C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x1FF003C", Offset = "0x1FF003C", VA = "0x1FF003C")]
		[DebuggerHidden]
		public <WaitForLanguageSelection>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x1FF0068", Offset = "0x1FF0068", VA = "0x1FF0068", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x1FF006C", Offset = "0x1FF006C", VA = "0x1FF006C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x1FF03CC", Offset = "0x1FF03CC", VA = "0x1FF03CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000815")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int selected;

	[Token(Token = "0x4000816")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private TextMeshProUGUI languageDisplay;

	[Token(Token = "0x4000817")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Toggle subtitlesToggle;

	[Token(Token = "0x4000818")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<string> languagesWithSubtitleSupport;

	[Token(Token = "0x600089F")]
	[Address(RVA = "0x1F29E88", Offset = "0x1F29E88", VA = "0x1F29E88")]
	private void Start()
	{
	}

	[Token(Token = "0x60008A0")]
	[Address(RVA = "0x1F29F5C", Offset = "0x1F29F5C", VA = "0x1F29F5C")]
	public void OnLowerButtonPress()
	{
	}

	[Token(Token = "0x60008A1")]
	[Address(RVA = "0x1F2A1D8", Offset = "0x1F2A1D8", VA = "0x1F2A1D8")]
	public void OnUpperButtonPress()
	{
	}

	[Token(Token = "0x60008A2")]
	[Address(RVA = "0x1F2A2A4", Offset = "0x1F2A2A4", VA = "0x1F2A2A4")]
	public void OnSubtitleToggle()
	{
	}

	[Token(Token = "0x60008A3")]
	[Address(RVA = "0x1F2A014", Offset = "0x1F2A014", VA = "0x1F2A014")]
	public void SelectLanguage(int index)
	{
	}

	[Token(Token = "0x60008A4")]
	[Address(RVA = "0x1F29EF0", Offset = "0x1F29EF0", VA = "0x1F29EF0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB5B1C", Offset = "0xAB5B1C")]
	private IEnumerator WaitForLanguageSelection()
	{
		return null;
	}

	[Token(Token = "0x60008A5")]
	[Address(RVA = "0x1F2A698", Offset = "0x1F2A698", VA = "0x1F2A698")]
	public LanguageSettingsUI()
	{
	}
}
[Token(Token = "0x200019E")]
public class LayerChanger : MonoBehaviour
{
	[Token(Token = "0x400081E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform[] childrenTransformList;

	[Token(Token = "0x60008AF")]
	[Address(RVA = "0x1F2A81C", Offset = "0x1F2A81C", VA = "0x1F2A81C")]
	public Transform[] GetAllChildrenTransform()
	{
		return null;
	}

	[Token(Token = "0x60008B0")]
	[Address(RVA = "0x1F2A878", Offset = "0x1F2A878", VA = "0x1F2A878")]
	public void ChangeSelfAndChildrenLayer(int _layer)
	{
	}

	[Token(Token = "0x60008B1")]
	[Address(RVA = "0x1F2A904", Offset = "0x1F2A904", VA = "0x1F2A904")]
	public LayerChanger()
	{
	}
}
[Token(Token = "0x200019F")]
public class LocalizationFilter : MonoBehaviour
{
	[Token(Token = "0x400081F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] objects;

	[Token(Token = "0x4000820")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<string> languageCodes;

	[Token(Token = "0x60008B2")]
	[Address(RVA = "0x1F2DC9C", Offset = "0x1F2DC9C", VA = "0x1F2DC9C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60008B3")]
	[Address(RVA = "0x1F2DE98", Offset = "0x1F2DE98", VA = "0x1F2DE98")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60008B4")]
	[Address(RVA = "0x1F2DD88", Offset = "0x1F2DD88", VA = "0x1F2DD88")]
	private void CheckLanguage()
	{
	}

	[Token(Token = "0x60008B5")]
	[Address(RVA = "0x1F2DF7C", Offset = "0x1F2DF7C", VA = "0x1F2DF7C")]
	public LocalizationFilter()
	{
	}
}
[Token(Token = "0x20001A0")]
public class LocalizationManager : Singleton<LocalizationManager>
{
	[Token(Token = "0x20001A1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAE64", Offset = "0xAAAE64")]
	private sealed class <InitializeLocalization>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocalizationManager <>4__this;

		[Token(Token = "0x1700015B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x1FF3A40", Offset = "0x1FF3A40", VA = "0x1FF3A40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0x1FF3A88", Offset = "0x1FF3A88", VA = "0x1FF3A88", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x1FF344C", Offset = "0x1FF344C", VA = "0x1FF344C")]
		[DebuggerHidden]
		public <InitializeLocalization>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x1FF3478", Offset = "0x1FF3478", VA = "0x1FF3478", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x1FF347C", Offset = "0x1FF347C", VA = "0x1FF347C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x1FF3A48", Offset = "0x1FF3A48", VA = "0x1FF3A48", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001A2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAE74", Offset = "0xAAAE74")]
	private sealed class <WaitThenInvokeLocaleSelectedEvent>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocalizationManager <>4__this;

		[Token(Token = "0x1700015D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x1FF3B70", Offset = "0x1FF3B70", VA = "0x1FF3B70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x1FF3BB8", Offset = "0x1FF3BB8", VA = "0x1FF3BB8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x1FF3A90", Offset = "0x1FF3A90", VA = "0x1FF3A90")]
		[DebuggerHidden]
		public <WaitThenInvokeLocaleSelectedEvent>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x1FF3ABC", Offset = "0x1FF3ABC", VA = "0x1FF3ABC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x1FF3AC0", Offset = "0x1FF3AC0", VA = "0x1FF3AC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x1FF3B78", Offset = "0x1FF3B78", VA = "0x1FF3B78", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001A3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAE84", Offset = "0xAAAE84")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TextMeshProUGUI tmpComponent;

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x1FF31E0", Offset = "0x1FF31E0", VA = "0x1FF31E0")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x1FF31E8", Offset = "0x1FF31E8", VA = "0x1FF31E8")]
		internal void <SetLocalizedText>b__0(AsyncOperationHandle<string> op)
		{
		}
	}

	[Token(Token = "0x20001A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAE94", Offset = "0xAAAE94")]
	private sealed class <>c__DisplayClass15_0
	{
		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TextMeshProUGUI tmpComponent;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string prefix;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string sufix;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string textKey;

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x1FF3260", Offset = "0x1FF3260", VA = "0x1FF3260")]
		public <>c__DisplayClass15_0()
		{
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x1FF3268", Offset = "0x1FF3268", VA = "0x1FF3268")]
		internal void <SetLocalizedTextOrOriginal>b__0(AsyncOperationHandle<string> op)
		{
		}
	}

	[Token(Token = "0x20001A5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAEA4", Offset = "0xAAAEA4")]
	private sealed class <>c__DisplayClass16_0
	{
		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TextMeshProUGUI tmpComponent;

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x1FF333C", Offset = "0x1FF333C", VA = "0x1FF333C")]
		public <>c__DisplayClass16_0()
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x1FF3344", Offset = "0x1FF3344", VA = "0x1FF3344")]
		internal void <SetLocalizedText>b__0(AsyncOperationHandle<string> op)
		{
		}
	}

	[Token(Token = "0x20001A6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAEB4", Offset = "0xAAAEB4")]
	private sealed class <>c__DisplayClass17_0
	{
		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action<string> action;

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x1FF33BC", Offset = "0x1FF33BC", VA = "0x1FF33BC")]
		public <>c__DisplayClass17_0()
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x1FF33C4", Offset = "0x1FF33C4", VA = "0x1FF33C4")]
		internal void <SetLocalizedText>b__0(AsyncOperationHandle<string> op)
		{
		}
	}

	[Token(Token = "0x4000821")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string selectedLanguageName;

	[Token(Token = "0x4000822")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string selectedLanguageCode;

	[Token(Token = "0x4000823")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int selectedLanguageIndex;

	[Token(Token = "0x4000824")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Locale> languageOptions;

	[Token(Token = "0x4000825")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool initialized;

	[Token(Token = "0x4000826")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool displaySubtitles;

	[Token(Token = "0x4000827")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private TextMeshProUGUI subtitlesTMP;

	[Token(Token = "0x4000828")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public Events.EventLanguageUpdate OnLanguageUpdate;

	[Token(Token = "0x60008B6")]
	[Address(RVA = "0x1F2DF84", Offset = "0x1F2DF84", VA = "0x1F2DF84")]
	private void Start()
	{
	}

	[Token(Token = "0x60008B7")]
	[Address(RVA = "0x1F2E170", Offset = "0x1F2E170", VA = "0x1F2E170")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB5BCC", Offset = "0xAB5BCC")]
	private IEnumerator InitializeLocalization()
	{
		return null;
	}

	[Token(Token = "0x60008B8")]
	[Address(RVA = "0x1F2E1DC", Offset = "0x1F2E1DC", VA = "0x1F2E1DC")]
	public void LocaleSelected(string languageCode)
	{
	}

	[Token(Token = "0x60008B9")]
	[Address(RVA = "0x1F2A41C", Offset = "0x1F2A41C", VA = "0x1F2A41C")]
	public string LocaleSelected(int index)
	{
		return null;
	}

	[Token(Token = "0x60008BA")]
	[Address(RVA = "0x1F2A334", Offset = "0x1F2A334", VA = "0x1F2A334")]
	public void SetSubtitlesDisplay(bool val)
	{
	}

	[Token(Token = "0x60008BB")]
	[Address(RVA = "0x1F2E3A8", Offset = "0x1F2E3A8", VA = "0x1F2E3A8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB5C2C", Offset = "0xAB5C2C")]
	private IEnumerator WaitThenInvokeLocaleSelectedEvent()
	{
		return null;
	}

	[Token(Token = "0x60008BC")]
	[Address(RVA = "0x1F1F58C", Offset = "0x1F1F58C", VA = "0x1F1F58C")]
	public void SetLocalizedText(string tableKey, string textKey, TextMeshProUGUI tmpComponent)
	{
	}

	[Token(Token = "0x60008BD")]
	[Address(RVA = "0x1F2E45C", Offset = "0x1F2E45C", VA = "0x1F2E45C")]
	public void SetLocalizedTextOrOriginal(string tableKey, string textKey, TextMeshProUGUI tmpComponent, string prefix = "", string sufix = "")
	{
	}

	[Token(Token = "0x60008BE")]
	[Address(RVA = "0x1F2D084", Offset = "0x1F2D084", VA = "0x1F2D084")]
	public void SetLocalizedText(string tableKey, string textKey, TextMeshProUGUI tmpComponent, Dictionary<string, string> arguments)
	{
	}

	[Token(Token = "0x60008BF")]
	[Address(RVA = "0x1F2E788", Offset = "0x1F2E788", VA = "0x1F2E788")]
	public void SetLocalizedText(string tableKey, string textKey, Action<string> action)
	{
	}

	[Token(Token = "0x60008C0")]
	[Address(RVA = "0x1F2EA54", Offset = "0x1F2EA54", VA = "0x1F2EA54")]
	public void SubtitlesOn(string textKey)
	{
	}

	[Token(Token = "0x60008C1")]
	[Address(RVA = "0x1F2ECE0", Offset = "0x1F2ECE0", VA = "0x1F2ECE0")]
	public void SetSubtitleText(string text)
	{
	}

	[Token(Token = "0x60008C2")]
	[Address(RVA = "0x1F2E414", Offset = "0x1F2E414", VA = "0x1F2E414")]
	public void SubtitlesOff()
	{
	}

	[Token(Token = "0x60008C3")]
	[Address(RVA = "0x1F2EDCC", Offset = "0x1F2EDCC", VA = "0x1F2EDCC")]
	public LocalizationManager()
	{
	}

	[Token(Token = "0x60008C4")]
	[Address(RVA = "0x1F2EE58", Offset = "0x1F2EE58", VA = "0x1F2EE58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB5C8C", Offset = "0xAB5C8C")]
	private void <SubtitlesOn>b__18_0(AsyncOperationHandle<string> op)
	{
	}
}
[Token(Token = "0x20001A7")]
public class LookAtPlayer : MonoBehaviour
{
	[Token(Token = "0x4000836")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public Transform playerTransform;

	[Token(Token = "0x4000837")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool allAngles;

	[Token(Token = "0x60008D9")]
	[Address(RVA = "0x1F03304", Offset = "0x1F03304", VA = "0x1F03304")]
	private void Start()
	{
	}

	[Token(Token = "0x60008DA")]
	[Address(RVA = "0x1F033B4", Offset = "0x1F033B4", VA = "0x1F033B4")]
	private void Update()
	{
	}

	[Token(Token = "0x60008DB")]
	[Address(RVA = "0x1F0347C", Offset = "0x1F0347C", VA = "0x1F0347C")]
	public LookAtPlayer()
	{
	}
}
[Token(Token = "0x20001A8")]
public class MainMenuSettingsUI : MonoBehaviour
{
	[Token(Token = "0x20001A9")]
	public enum TypeOfButton
	{
		[Token(Token = "0x400083E")]
		Meat,
		[Token(Token = "0x400083F")]
		Alcoholic,
		[Token(Token = "0x4000840")]
		SnapTurn,
		[Token(Token = "0x4000841")]
		LocomotionTypes,
		[Token(Token = "0x4000842")]
		ForceGrabber,
		[Token(Token = "0x4000843")]
		AutoAimValues,
		[Token(Token = "0x4000844")]
		QualityLevel,
		[Token(Token = "0x4000845")]
		Ragdoll
	}

	[Token(Token = "0x4000838")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private int currentValue;

	[Token(Token = "0x4000839")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI currentTMP;

	[Token(Token = "0x400083A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Image currentImage;

	[Token(Token = "0x400083B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TypeOfButton typeOfButton;

	[Token(Token = "0x400083C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Sprite[] valueSprites;

	[Token(Token = "0x60008DC")]
	[Address(RVA = "0x1F04C28", Offset = "0x1F04C28", VA = "0x1F04C28")]
	private void Start()
	{
	}

	[Token(Token = "0x60008DD")]
	[Address(RVA = "0x1F05CD8", Offset = "0x1F05CD8", VA = "0x1F05CD8")]
	public void ClickButton()
	{
	}

	[Token(Token = "0x60008DE")]
	[Address(RVA = "0x1F04D70", Offset = "0x1F04D70", VA = "0x1F04D70")]
	private int GetCurrentValue()
	{
		return default(int);
	}

	[Token(Token = "0x60008DF")]
	[Address(RVA = "0x1F05404", Offset = "0x1F05404", VA = "0x1F05404")]
	private void SetSetting()
	{
	}

	[Token(Token = "0x60008E0")]
	[Address(RVA = "0x1F05B64", Offset = "0x1F05B64", VA = "0x1F05B64")]
	private void UpdateSpriteAndString()
	{
	}

	[Token(Token = "0x60008E1")]
	[Address(RVA = "0x1F05DDC", Offset = "0x1F05DDC", VA = "0x1F05DDC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60008E2")]
	[Address(RVA = "0x1F05F44", Offset = "0x1F05F44", VA = "0x1F05F44")]
	public MainMenuSettingsUI()
	{
	}
}
[Token(Token = "0x20001AA")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xAAAEC4", Offset = "0xAAAEC4")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xAAAEC4", Offset = "0xAAAEC4")]
public class ParticleSystemAudio : MonoBehaviour
{
	[Token(Token = "0x20001AB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAF58", Offset = "0xAAAF58")]
	private sealed class <PlayWhileEmiting>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string[] sounds;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystemAudio <>4__this;

		[Token(Token = "0x1700015F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008EB")]
			[Address(RVA = "0x1FF731C", Offset = "0x1FF731C", VA = "0x1FF731C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000160")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008ED")]
			[Address(RVA = "0x1FF7364", Offset = "0x1FF7364", VA = "0x1FF7364", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x1FF7190", Offset = "0x1FF7190", VA = "0x1FF7190")]
		[DebuggerHidden]
		public <PlayWhileEmiting>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x1FF71BC", Offset = "0x1FF71BC", VA = "0x1FF71BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x1FF71C0", Offset = "0x1FF71C0", VA = "0x1FF71C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x1FF7324", Offset = "0x1FF7324", VA = "0x1FF7324", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000846")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string[] onBirthSounds;

	[Token(Token = "0x4000847")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string[] onDeathSounds;

	[Token(Token = "0x4000848")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int _numberOfParticles;

	[Token(Token = "0x4000849")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioHandler _audioHandler;

	[Token(Token = "0x400084A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private ParticleSystem _particleSystem;

	[Token(Token = "0x400084B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string playingSound;

	[Token(Token = "0x60008E3")]
	[Address(RVA = "0x1F0B894", Offset = "0x1F0B894", VA = "0x1F0B894")]
	private void Start()
	{
	}

	[Token(Token = "0x60008E4")]
	[Address(RVA = "0x1F0B90C", Offset = "0x1F0B90C", VA = "0x1F0B90C")]
	private void Update()
	{
	}

	[Token(Token = "0x60008E5")]
	[Address(RVA = "0x1F0B978", Offset = "0x1F0B978", VA = "0x1F0B978")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB5D3C", Offset = "0xAB5D3C")]
	private IEnumerator PlayWhileEmiting(string[] sounds)
	{
		return null;
	}

	[Token(Token = "0x60008E6")]
	[Address(RVA = "0x1F0B9F0", Offset = "0x1F0B9F0", VA = "0x1F0B9F0")]
	public ParticleSystemAudio()
	{
	}

	[Token(Token = "0x60008E7")]
	[Address(RVA = "0x1F0B9F8", Offset = "0x1F0B9F8", VA = "0x1F0B9F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB5D9C", Offset = "0xAB5D9C")]
	private bool <PlayWhileEmiting>b__8_0()
	{
		return default(bool);
	}
}
[Token(Token = "0x20001AC")]
public class PrintLogsOnTMP : MonoBehaviour
{
	[Token(Token = "0x4000850")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI logText;

	[Token(Token = "0x4000851")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string myLog;

	[Token(Token = "0x4000852")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Queue myLogQueue;

	[Token(Token = "0x60008EE")]
	[Address(RVA = "0x1F0F924", Offset = "0x1F0F924", VA = "0x1F0F924")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60008EF")]
	[Address(RVA = "0x1F0F9A0", Offset = "0x1F0F9A0", VA = "0x1F0F9A0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60008F0")]
	[Address(RVA = "0x1F0FA1C", Offset = "0x1F0FA1C", VA = "0x1F0FA1C")]
	private void HandleLog(string logString, string stackTrace, LogType type)
	{
	}

	[Token(Token = "0x60008F1")]
	[Address(RVA = "0x1F0FE00", Offset = "0x1F0FE00", VA = "0x1F0FE00")]
	public PrintLogsOnTMP()
	{
	}
}
[Token(Token = "0x20001AD")]
public class PushBeersAway : MonoBehaviour
{
	[Token(Token = "0x20001AE")]
	public enum PushingType
	{
		[Token(Token = "0x4000859")]
		FROM_POINT,
		[Token(Token = "0x400085A")]
		DIRECTION_X,
		[Token(Token = "0x400085B")]
		DIRECTION_Z
	}

	[Serializable]
	[Token(Token = "0x20001AF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAF68", Offset = "0xAAAF68")]
	private sealed class <>c
	{
		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<Rigidbody, bool> <>9__10_0;

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x22CA820", Offset = "0x22CA820", VA = "0x22CA820")]
		public <>c()
		{
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x22CA828", Offset = "0x22CA828", VA = "0x22CA828")]
		internal bool <RemoveNullValues>b__10_0(Rigidbody beer)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000853")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Rigidbody> beersInTrigger;

	[Token(Token = "0x4000854")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float pushForceMultipler;

	[Token(Token = "0x4000855")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float toppleForceMultipler;

	[Token(Token = "0x4000856")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform centerToPushAwayFrom;

	[Token(Token = "0x4000857")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public PushingType pushingType;

	[Token(Token = "0x60008F2")]
	[Address(RVA = "0x1F0FE64", Offset = "0x1F0FE64", VA = "0x1F0FE64")]
	private void Start()
	{
	}

	[Token(Token = "0x60008F3")]
	[Address(RVA = "0x1F0FEBC", Offset = "0x1F0FEBC", VA = "0x1F0FEBC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60008F4")]
	[Address(RVA = "0x1F0FF88", Offset = "0x1F0FF88", VA = "0x1F0FF88")]
	private void Update()
	{
	}

	[Token(Token = "0x60008F5")]
	[Address(RVA = "0x1F10364", Offset = "0x1F10364", VA = "0x1F10364")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60008F6")]
	[Address(RVA = "0x1F103FC", Offset = "0x1F103FC", VA = "0x1F103FC")]
	private void RemoveNullValues()
	{
	}

	[Token(Token = "0x60008F7")]
	[Address(RVA = "0x1F10544", Offset = "0x1F10544", VA = "0x1F10544")]
	public PushBeersAway()
	{
	}
}
[Token(Token = "0x20001B0")]
public class QualitySettingsChange : MonoBehaviour
{
	[Token(Token = "0x400085E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int AndroidQualityInThisScene;

	[Token(Token = "0x60008FB")]
	[Address(RVA = "0x1F10558", Offset = "0x1F10558", VA = "0x1F10558")]
	private void Start()
	{
	}

	[Token(Token = "0x60008FC")]
	[Address(RVA = "0x1F10568", Offset = "0x1F10568", VA = "0x1F10568")]
	public void ChangeQualitySettings(int qualitySetting)
	{
	}

	[Token(Token = "0x60008FD")]
	[Address(RVA = "0x1F10578", Offset = "0x1F10578", VA = "0x1F10578")]
	public void ChangeQualitySettings()
	{
	}

	[Token(Token = "0x60008FE")]
	[Address(RVA = "0x1F1060C", Offset = "0x1F1060C", VA = "0x1F1060C")]
	public QualitySettingsChange()
	{
	}
}
[Token(Token = "0x20001B1")]
public class RestartBirdBehaviour : MonoBehaviour
{
	[Token(Token = "0x20001B2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAF78", Offset = "0xAAAF78")]
	private sealed class <AskForConfirmation>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RestartBirdBehaviour <>4__this;

		[Token(Token = "0x17000161")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000906")]
			[Address(RVA = "0x22CDAF4", Offset = "0x22CDAF4", VA = "0x22CDAF4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000162")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000908")]
			[Address(RVA = "0x22CDB3C", Offset = "0x22CDB3C", VA = "0x22CDB3C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x22CD8EC", Offset = "0x22CD8EC", VA = "0x22CD8EC")]
		[DebuggerHidden]
		public <AskForConfirmation>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x22CD918", Offset = "0x22CD918", VA = "0x22CD918", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x22CD91C", Offset = "0x22CD91C", VA = "0x22CD91C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x22CDAFC", Offset = "0x22CDAFC", VA = "0x22CDAFC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400085F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool readyToRestart;

	[Token(Token = "0x4000860")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI text;

	[Token(Token = "0x4000861")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Animator animator;

	[Token(Token = "0x4000862")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioHandler audioHandler;

	[Token(Token = "0x4000863")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float timeToConfirm;

	[Token(Token = "0x60008FF")]
	[Address(RVA = "0x1F15088", Offset = "0x1F15088", VA = "0x1F15088")]
	private void Start()
	{
	}

	[Token(Token = "0x6000900")]
	[Address(RVA = "0x1F15100", Offset = "0x1F15100", VA = "0x1F15100")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000901")]
	[Address(RVA = "0x1F15218", Offset = "0x1F15218", VA = "0x1F15218")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB5DFC", Offset = "0xAB5DFC")]
	private IEnumerator AskForConfirmation()
	{
		return null;
	}

	[Token(Token = "0x6000902")]
	[Address(RVA = "0x1F15284", Offset = "0x1F15284", VA = "0x1F15284")]
	public RestartBirdBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x20001B3")]
public class SavedData
{
	[Serializable]
	[Token(Token = "0x20001B4")]
	[ES3Serializable]
	public class ArcadeScore
	{
		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int score;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float timeElapsed;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int wavesSurvived;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string signatureImageSource;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string playerName;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public DateTime date;

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x22CE64C", Offset = "0x22CE64C", VA = "0x22CE64C")]
		public ArcadeScore(int _score = 0, float _timeElpased = 0f, int _wavesSurvived = 0, string _signature = "", string _playerName = "Annon")
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20001B5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAF98", Offset = "0xAAAF98")]
	private sealed class <>c
	{
		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<ArcadeScore, int> <>9__35_0;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<ArcadeScore, int> <>9__40_0;

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x22CE614", Offset = "0x22CE614", VA = "0x22CE614")]
		public <>c()
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x22CE61C", Offset = "0x22CE61C", VA = "0x22CE61C")]
		internal int <AddScoreAndReorder>b__35_0(ArcadeScore x)
		{
			return default(int);
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x22CE634", Offset = "0x22CE634", VA = "0x22CE634")]
		internal int <GetScoreRank>b__40_0(ArcadeScore x)
		{
			return default(int);
		}
	}

	[Token(Token = "0x4000867")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int[] levelStars;

	[Token(Token = "0x4000868")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool[] levelUnlocked;

	[Token(Token = "0x4000869")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int[] levelAttempt;

	[Token(Token = "0x400086A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int difficulty;

	[Token(Token = "0x400086B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int qualityLevel;

	[Token(Token = "0x400086C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int[] levelFastestRun;

	[Token(Token = "0x400086D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool enablesTeleport;

	[Token(Token = "0x400086E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool enablesLocomotion;

	[Token(Token = "0x400086F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	public bool snapTurn;

	[Token(Token = "0x4000870")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int autoAimLevel;

	[Token(Token = "0x4000871")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool forceGrabWithTrigger;

	[Token(Token = "0x4000872")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float playerHeightAdjustment;

	[Token(Token = "0x4000873")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float waistHeightAdjustment;

	[Token(Token = "0x4000874")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float tableHeightAdjustment;

	[Token(Token = "0x4000875")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float beerboxHeightAdjustment;

	[Token(Token = "0x4000876")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string languageCode;

	[Token(Token = "0x4000877")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool displaySubtitles;

	[Token(Token = "0x4000878")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	public bool meat;

	[Token(Token = "0x4000879")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
	public bool alcoholic;

	[Token(Token = "0x400087A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int beerSkinIndex;

	[Token(Token = "0x400087B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string boomerangSkin;

	[Token(Token = "0x400087C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Color skinColor;

	[Token(Token = "0x400087D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAABE24", Offset = "0xAABE24")]
	public float musicVolumeLevel;

	[Token(Token = "0x400087E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAABE3C", Offset = "0xAABE3C")]
	public float sfxVolumeLevel;

	[Token(Token = "0x400087F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<ArcadeScore> bestArcadeScores;

	[Token(Token = "0x4000880")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<ArcadeScore> bestCookingArcadeScores;

	[Token(Token = "0x4000881")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public int longestWaveRunArcade;

	[Token(Token = "0x4000882")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public int longestWaveRunCookingArcade;

	[Token(Token = "0x4000883")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool ragDollBabyroos;

	[Token(Token = "0x4000884")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float[] levelPassingFunFeedback;

	[Token(Token = "0x4000885")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public float[] levelPassingHardFeedback;

	[Token(Token = "0x4000886")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public float[] level3StarsFunFeedback;

	[Token(Token = "0x4000887")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public float[] level3StarsHardFeedback;

	[Token(Token = "0x6000909")]
	[Address(RVA = "0x1F15CF0", Offset = "0x1F15CF0", VA = "0x1F15CF0")]
	public void MagicStarsUnlock()
	{
	}

	[Token(Token = "0x600090A")]
	[Address(RVA = "0x1F15D6C", Offset = "0x1F15D6C", VA = "0x1F15D6C")]
	private List<ArcadeScore> AddScoreAndReorder(List<ArcadeScore> _scores, ArcadeScore _newScore)
	{
		return null;
	}

	[Token(Token = "0x600090B")]
	[Address(RVA = "0x1F16048", Offset = "0x1F16048", VA = "0x1F16048")]
	public string UpdateArcadeScore(int _score, int _waves, float _timeElapsed, ArcadeMode _mode, [Optional] Texture2D _signature)
	{
		return null;
	}

	[Token(Token = "0x600090C")]
	[Address(RVA = "0x1F16414", Offset = "0x1F16414", VA = "0x1F16414")]
	public int GetLongestArcadeWaveRun(ArcadeMode _mode)
	{
		return default(int);
	}

	[Token(Token = "0x600090D")]
	[Address(RVA = "0x1F1642C", Offset = "0x1F1642C", VA = "0x1F1642C")]
	public int GetHighscore(ArcadeMode _mode)
	{
		return default(int);
	}

	[Token(Token = "0x600090E")]
	[Address(RVA = "0x1F164BC", Offset = "0x1F164BC", VA = "0x1F164BC")]
	public int GetLowScore(ArcadeMode _mode)
	{
		return default(int);
	}

	[Token(Token = "0x600090F")]
	[Address(RVA = "0x1F16550", Offset = "0x1F16550", VA = "0x1F16550")]
	public void GetScoreRank(ArcadeMode _mode, int _score, out List<ArcadeScore> tempListScores, out int index)
	{
	}

	[Token(Token = "0x6000910")]
	[Address(RVA = "0x1F16868", Offset = "0x1F16868", VA = "0x1F16868")]
	public float GetHeightAdjustment(HeightAdjustmentOption _keyword)
	{
		return default(float);
	}

	[Token(Token = "0x6000911")]
	[Address(RVA = "0x1F168B0", Offset = "0x1F168B0", VA = "0x1F168B0")]
	public void SetHeightAdjustment(HeightAdjustmentOption _keyword, float _value)
	{
	}

	[Token(Token = "0x6000912")]
	[Address(RVA = "0x1F03290", Offset = "0x1F03290", VA = "0x1F03290")]
	public int CountStars()
	{
		return default(int);
	}

	[Token(Token = "0x6000913")]
	[Address(RVA = "0x1F168F0", Offset = "0x1F168F0", VA = "0x1F168F0")]
	public void SetDefaults()
	{
	}

	[Token(Token = "0x6000914")]
	[Address(RVA = "0x1F16338", Offset = "0x1F16338", VA = "0x1F16338")]
	private string RandomStringGenerator(int lenght)
	{
		return null;
	}

	[Token(Token = "0x6000915")]
	[Address(RVA = "0x1F16970", Offset = "0x1F16970", VA = "0x1F16970")]
	public SavedData()
	{
	}
}
[Token(Token = "0x20001B6")]
public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
	[Token(Token = "0x4000891")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static T instance;

	[Token(Token = "0x17000163")]
	public static T Instance
	{
		[Token(Token = "0x600091B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000164")]
	public static bool IsInitialized
	{
		[Token(Token = "0x600091C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600091D")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x600091E")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x600091F")]
	public Singleton()
	{
	}
}
[Serializable]
[Token(Token = "0x20001B7")]
public class Sound
{
	[Token(Token = "0x4000892")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x4000893")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip clip;

	[Token(Token = "0x4000894")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAABE54", Offset = "0xAABE54")]
	public float volume;

	[Token(Token = "0x4000895")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAABE6C", Offset = "0xAABE6C")]
	public float volumeVariance;

	[Token(Token = "0x4000896")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAABE84", Offset = "0xAABE84")]
	public float pitch;

	[Token(Token = "0x4000897")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAABEA0", Offset = "0xAABEA0")]
	public float pitchVariance;

	[Token(Token = "0x4000898")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public float dopplerLevel;

	[Token(Token = "0x4000899")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[HideInInspector]
	public float spread;

	[Token(Token = "0x400089A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAABED8", Offset = "0xAABED8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAABED8", Offset = "0xAABED8")]
	public float spatialBlend;

	[Token(Token = "0x400089B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool loop;

	[Token(Token = "0x400089C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public AudioMixerGroup mixerGroup;

	[Token(Token = "0x400089D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public AudioSource source;

	[Token(Token = "0x6000920")]
	[Address(RVA = "0x1F182C4", Offset = "0x1F182C4", VA = "0x1F182C4")]
	public Sound()
	{
	}
}
[Serializable]
[Token(Token = "0x20001B8")]
public class SoundGroup
{
	[Token(Token = "0x400089E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x400089F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip[] clips;

	[Token(Token = "0x40008A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAABF4C", Offset = "0xAABF4C")]
	public float volume;

	[Token(Token = "0x40008A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAABF64", Offset = "0xAABF64")]
	public float volumeVariance;

	[Token(Token = "0x40008A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAABF7C", Offset = "0xAABF7C")]
	public float pitch;

	[Token(Token = "0x40008A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAABF98", Offset = "0xAABF98")]
	public float pitchVariance;

	[Token(Token = "0x40008A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public float dopplerLevel;

	[Token(Token = "0x40008A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[HideInInspector]
	public float spread;

	[Token(Token = "0x40008A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAABFD0", Offset = "0xAABFD0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAABFD0", Offset = "0xAABFD0")]
	public float spatialBlend;

	[Token(Token = "0x40008A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool loop;

	[Token(Token = "0x40008A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public AudioMixerGroup mixerGroup;

	[Token(Token = "0x40008A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public AudioSource source;

	[Token(Token = "0x6000921")]
	[Address(RVA = "0x1F182EC", Offset = "0x1F182EC", VA = "0x1F182EC")]
	public SoundGroup()
	{
	}
}
[Token(Token = "0x20001B9")]
public class SwappableBeerbox : MonoBehaviour
{
	[Token(Token = "0x20001BA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAFA8", Offset = "0xAAAFA8")]
	private sealed class <SwapCoroutine>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SwappableBeerbox <>4__this;

		[Token(Token = "0x17000165")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000929")]
			[Address(RVA = "0x22CF2FC", Offset = "0x22CF2FC", VA = "0x22CF2FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000166")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600092B")]
			[Address(RVA = "0x22CF344", Offset = "0x22CF344", VA = "0x22CF344", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x22CF034", Offset = "0x22CF034", VA = "0x22CF034")]
		[DebuggerHidden]
		public <SwapCoroutine>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x22CF060", Offset = "0x22CF060", VA = "0x22CF060", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x22CF064", Offset = "0x22CF064", VA = "0x22CF064", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x22CF304", Offset = "0x22CF304", VA = "0x22CF304", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40008AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject originalBox;

	[Token(Token = "0x40008AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject replaceBox;

	[Token(Token = "0x40008AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject replaceBeers;

	[Token(Token = "0x40008AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject SwapParticles;

	[Token(Token = "0x40008AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject beerPuffParticles;

	[Token(Token = "0x40008AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Beer[] beerCans;

	[Token(Token = "0x40008B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private AudioHandler audioHandler;

	[Token(Token = "0x6000922")]
	[Address(RVA = "0x1F18D24", Offset = "0x1F18D24", VA = "0x1F18D24")]
	private void Start()
	{
	}

	[Token(Token = "0x6000923")]
	[Address(RVA = "0x1F18D9C", Offset = "0x1F18D9C", VA = "0x1F18D9C")]
	public void Swap()
	{
	}

	[Token(Token = "0x6000924")]
	[Address(RVA = "0x1F18DC8", Offset = "0x1F18DC8", VA = "0x1F18DC8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB5EAC", Offset = "0xAB5EAC")]
	public IEnumerator SwapCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000925")]
	[Address(RVA = "0x1F18E34", Offset = "0x1F18E34", VA = "0x1F18E34")]
	public SwappableBeerbox()
	{
	}
}
[Token(Token = "0x20001BB")]
public class TimeAndObjectEnabler : MonoBehaviour
{
	[Token(Token = "0x20001BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAFB8", Offset = "0xAAAFB8")]
	private sealed class <SpawnNextEnemyCoroutine>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TimeAndObjectEnabler <>4__this;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float _time;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject _gameObject;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <i>5__2;

		[Token(Token = "0x17000167")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000936")]
			[Address(RVA = "0x22CF510", Offset = "0x22CF510", VA = "0x22CF510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000168")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000938")]
			[Address(RVA = "0x22CF558", Offset = "0x22CF558", VA = "0x22CF558", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0x22CF34C", Offset = "0x22CF34C", VA = "0x22CF34C")]
		[DebuggerHidden]
		public <SpawnNextEnemyCoroutine>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x22CF378", Offset = "0x22CF378", VA = "0x22CF378", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0x22CF37C", Offset = "0x22CF37C", VA = "0x22CF37C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0x22CF518", Offset = "0x22CF518", VA = "0x22CF518", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40008B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool doneOnceFinished;

	[Token(Token = "0x40008B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int enemyCall;

	[Token(Token = "0x40008B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAAC044", Offset = "0xAAC044")]
	public float elasticityMultiplier;

	[Token(Token = "0x40008B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAAC07C", Offset = "0xAAC07C")]
	public float[] intervalArray;

	[Token(Token = "0x40008B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAAC0B4", Offset = "0xAAC0B4")]
	public float[] timeElasticity;

	[Token(Token = "0x40008B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public Transform[] EnemyArray;

	[Token(Token = "0x40008BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool stopSpawning;

	[Token(Token = "0x600092C")]
	[Address(RVA = "0x1F3D9A8", Offset = "0x1F3D9A8", VA = "0x1F3D9A8")]
	private void Start()
	{
	}

	[Token(Token = "0x600092D")]
	[Address(RVA = "0x1F3DC74", Offset = "0x1F3DC74", VA = "0x1F3DC74")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB5F5C", Offset = "0xAB5F5C")]
	private IEnumerator SpawnNextEnemyCoroutine(GameObject _gameObject, float _time)
	{
		return null;
	}

	[Token(Token = "0x600092E")]
	[Address(RVA = "0x1F3DD00", Offset = "0x1F3DD00", VA = "0x1F3DD00")]
	private float ElasticTimeIncrement()
	{
		return default(float);
	}

	[Token(Token = "0x600092F")]
	[Address(RVA = "0x1F3DE78", Offset = "0x1F3DE78", VA = "0x1F3DE78")]
	private void FinishedTheEnemies()
	{
	}

	[Token(Token = "0x6000930")]
	[Address(RVA = "0x1F3DF14", Offset = "0x1F3DF14", VA = "0x1F3DF14")]
	public void StopSpawning()
	{
	}

	[Token(Token = "0x6000931")]
	[Address(RVA = "0x1F3DF40", Offset = "0x1F3DF40", VA = "0x1F3DF40")]
	private void OnAllRequestComplete()
	{
	}

	[Token(Token = "0x6000932")]
	[Address(RVA = "0x1F3DFA0", Offset = "0x1F3DFA0", VA = "0x1F3DFA0")]
	public TimeAndObjectEnabler()
	{
	}
}
[Token(Token = "0x20001BD")]
public class TimeAndPlaceSpawner : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20001BE")]
	public struct timePlaceObject
	{
		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float time;

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform transform;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject gameObject;
	}

	[Token(Token = "0x20001BF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAFC8", Offset = "0xAAAFC8")]
	private sealed class <SpawnEnemyCoroutine>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float _time;

		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject _gameObject;

		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform _transform;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TimeAndPlaceSpawner <>4__this;

		[Token(Token = "0x17000169")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600093F")]
			[Address(RVA = "0x22CF738", Offset = "0x22CF738", VA = "0x22CF738", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000941")]
			[Address(RVA = "0x22CF780", Offset = "0x22CF780", VA = "0x22CF780", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x22CF560", Offset = "0x22CF560", VA = "0x22CF560")]
		[DebuggerHidden]
		public <SpawnEnemyCoroutine>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x22CF58C", Offset = "0x22CF58C", VA = "0x22CF58C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x22CF590", Offset = "0x22CF590", VA = "0x22CF590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0x22CF740", Offset = "0x22CF740", VA = "0x22CF740", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40008C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public timePlaceObject[] spawnableEnemiesArray;

	[Token(Token = "0x6000939")]
	[Address(RVA = "0x1F3E028", Offset = "0x1F3E028", VA = "0x1F3E028")]
	private void Start()
	{
	}

	[Token(Token = "0x600093A")]
	[Address(RVA = "0x1F3E0B8", Offset = "0x1F3E0B8", VA = "0x1F3E0B8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB600C", Offset = "0xAB600C")]
	private IEnumerator SpawnEnemyCoroutine(GameObject _gameObject, Transform _transform, float _time)
	{
		return null;
	}

	[Token(Token = "0x600093B")]
	[Address(RVA = "0x1F3E148", Offset = "0x1F3E148", VA = "0x1F3E148")]
	public TimeAndPlaceSpawner()
	{
	}
}
[Token(Token = "0x20001C0")]
public class TimerBirdBehaviour : MonoBehaviour
{
	[Token(Token = "0x20001C1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAFD8", Offset = "0xAAAFD8")]
	private sealed class <Warn>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TimerBirdBehaviour <>4__this;

		[Token(Token = "0x1700016B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600094F")]
			[Address(RVA = "0x22CF8DC", Offset = "0x22CF8DC", VA = "0x22CF8DC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000951")]
			[Address(RVA = "0x22CF924", Offset = "0x22CF924", VA = "0x22CF924", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0x22CF788", Offset = "0x22CF788", VA = "0x22CF788")]
		[DebuggerHidden]
		public <Warn>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x22CF7B4", Offset = "0x22CF7B4", VA = "0x22CF7B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x22CF7B8", Offset = "0x22CF7B8", VA = "0x22CF7B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x22CF8E4", Offset = "0x22CF8E4", VA = "0x22CF8E4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40008CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool readyToFinish;

	[Token(Token = "0x40008CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool finished;

	[Token(Token = "0x40008CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject birdObject;

	[Token(Token = "0x40008CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform pointToGo;

	[Token(Token = "0x40008CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float verticalCurveValue;

	[Token(Token = "0x40008D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Animator animator;

	[Token(Token = "0x40008D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private AudioHandler audioHandler;

	[Token(Token = "0x40008D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool flyOnAllEnemiesGone;

	[Token(Token = "0x40008D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	private bool allRequestsComplete;

	[Token(Token = "0x40008D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	private bool allEnemiesGone;

	[Token(Token = "0x40008D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float warnInterval;

	[Token(Token = "0x40008D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool warning;

	[Token(Token = "0x40008D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private int urgencyLevel;

	[Token(Token = "0x6000942")]
	[Address(RVA = "0x1F3E150", Offset = "0x1F3E150", VA = "0x1F3E150")]
	private void Start()
	{
	}

	[Token(Token = "0x6000943")]
	[Address(RVA = "0x1F3E42C", Offset = "0x1F3E42C", VA = "0x1F3E42C")]
	private void AllEnemiesGone()
	{
	}

	[Token(Token = "0x6000944")]
	[Address(RVA = "0x1F3EA9C", Offset = "0x1F3EA9C", VA = "0x1F3EA9C")]
	private void AllRequestsComplete()
	{
	}

	[Token(Token = "0x6000945")]
	[Address(RVA = "0x1F3EB38", Offset = "0x1F3EB38", VA = "0x1F3EB38")]
	private void GameFinished()
	{
	}

	[Token(Token = "0x6000946")]
	[Address(RVA = "0x1F3EBC8", Offset = "0x1F3EBC8", VA = "0x1F3EBC8")]
	private void HitByBoomerangAnimation()
	{
	}

	[Token(Token = "0x6000947")]
	[Address(RVA = "0x1F3EC34", Offset = "0x1F3EC34", VA = "0x1F3EC34")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000948")]
	[Address(RVA = "0x1F3E4C8", Offset = "0x1F3E4C8", VA = "0x1F3E4C8")]
	private void FlyToPoint(Transform _transform)
	{
	}

	[Token(Token = "0x6000949")]
	[Address(RVA = "0x1F3ED88", Offset = "0x1F3ED88", VA = "0x1F3ED88")]
	public void WarnTime(float levelSecondsLeft)
	{
	}

	[Token(Token = "0x600094A")]
	[Address(RVA = "0x1F3EE38", Offset = "0x1F3EE38", VA = "0x1F3EE38")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB60BC", Offset = "0xAB60BC")]
	private IEnumerator Warn()
	{
		return null;
	}

	[Token(Token = "0x600094B")]
	[Address(RVA = "0x1F3EEA4", Offset = "0x1F3EEA4", VA = "0x1F3EEA4")]
	public TimerBirdBehaviour()
	{
	}
}
[Token(Token = "0x20001C2")]
public class UnityAnalyticsStarter : MonoBehaviour
{
	[StructLayout(3)]
	[Token(Token = "0x20001C3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAFE8", Offset = "0xAAAFE8")]
	private struct <Start>d__1 : IAsyncStateMachine
	{
		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityAnalyticsStarter <>4__this;

		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter<List<string>> <>u__2;

		[Token(Token = "0x6000955")]
		[Address(RVA = "0x22CFDC8", Offset = "0x22CFDC8", VA = "0x22CFDC8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0x22D025C", Offset = "0x22D025C", VA = "0x22D025C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x40008DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool analyticsEnabled;

	[Token(Token = "0x6000952")]
	[Address(RVA = "0x1F4067C", Offset = "0x1F4067C", VA = "0x1F4067C")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xAB616C", Offset = "0xAB616C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000953")]
	[Address(RVA = "0x1F40740", Offset = "0x1F40740", VA = "0x1F40740")]
	public void TestButton()
	{
	}

	[Token(Token = "0x6000954")]
	[Address(RVA = "0x1F40AFC", Offset = "0x1F40AFC", VA = "0x1F40AFC")]
	public UnityAnalyticsStarter()
	{
	}
}
[Token(Token = "0x20001C4")]
public class UpdateHandMaterial : MonoBehaviour
{
	[Token(Token = "0x40008E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material handMaterial;

	[Token(Token = "0x40008E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private SkinnedMeshRenderer _renderer;

	[Token(Token = "0x6000957")]
	[Address(RVA = "0x1F40B04", Offset = "0x1F40B04", VA = "0x1F40B04")]
	private void Start()
	{
	}

	[Token(Token = "0x6000958")]
	[Address(RVA = "0x1F40C04", Offset = "0x1F40C04", VA = "0x1F40C04")]
	public void UpdateColor(Color newColor)
	{
	}

	[Token(Token = "0x6000959")]
	[Address(RVA = "0x1F40C98", Offset = "0x1F40C98", VA = "0x1F40C98")]
	public UpdateHandMaterial()
	{
	}
}
[Token(Token = "0x20001C5")]
public class VolumeSpawner : MonoBehaviour
{
	[Token(Token = "0x20001C6")]
	public enum SpawnType
	{
		[Token(Token = "0x40008F1")]
		CircularArea,
		[Token(Token = "0x40008F2")]
		SemicircularArea,
		[Token(Token = "0x40008F3")]
		CubicVolume,
		[Token(Token = "0x40008F4")]
		SpawnPoints
	}

	[Token(Token = "0x20001C7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAAFF8", Offset = "0xAAAFF8")]
	private sealed class <SpawnStuffCoroutine>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VolumeSpawner <>4__this;

		[Token(Token = "0x1700016D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000963")]
			[Address(RVA = "0x22D12D0", Offset = "0x22D12D0", VA = "0x22D12D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000965")]
			[Address(RVA = "0x22D1318", Offset = "0x22D1318", VA = "0x22D1318", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x22D10F0", Offset = "0x22D10F0", VA = "0x22D10F0")]
		[DebuggerHidden]
		public <SpawnStuffCoroutine>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x22D111C", Offset = "0x22D111C", VA = "0x22D111C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x22D1120", Offset = "0x22D1120", VA = "0x22D1120", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x22D12D8", Offset = "0x22D12D8", VA = "0x22D12D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40008E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SpawnType spawnType;

	[Token(Token = "0x40008E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAAC0FC", Offset = "0xAAC0FC")]
	public float xRange;

	[Token(Token = "0x40008E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float yRange;

	[Token(Token = "0x40008E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float zRange;

	[Token(Token = "0x40008E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAAC134", Offset = "0xAAC134")]
	public float radius;

	[Token(Token = "0x40008E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform[] pointsToSpawn;

	[Token(Token = "0x40008E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int indexToSpawn;

	[Token(Token = "0x40008EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAAC16C", Offset = "0xAAC16C")]
	public int numberOfTargets;

	[Token(Token = "0x40008EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float timeDelay;

	[Token(Token = "0x40008EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float timeUntilFirstSpawn;

	[Token(Token = "0x40008ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject[] listOfObjectsToSpawn;

	[Token(Token = "0x40008EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool spawnOnStart;

	[Token(Token = "0x40008EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Vector3 positionToSpawn;

	[Token(Token = "0x600095A")]
	[Address(RVA = "0x1F4258C", Offset = "0x1F4258C", VA = "0x1F4258C")]
	private void Start()
	{
	}

	[Token(Token = "0x600095B")]
	[Address(RVA = "0x1F42B6C", Offset = "0x1F42B6C", VA = "0x1F42B6C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB61DC", Offset = "0xAB61DC")]
	private IEnumerator SpawnStuffCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600095C")]
	[Address(RVA = "0x1F42608", Offset = "0x1F42608", VA = "0x1F42608")]
	public void SpawnStuff(GameObject[] _listOfObjectsToSpawn)
	{
	}

	[Token(Token = "0x600095D")]
	[Address(RVA = "0x1F42BD8", Offset = "0x1F42BD8", VA = "0x1F42BD8")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600095E")]
	[Address(RVA = "0x1F42FE0", Offset = "0x1F42FE0", VA = "0x1F42FE0")]
	public VolumeSpawner()
	{
	}

	[Token(Token = "0x600095F")]
	[Address(RVA = "0x1F42FE8", Offset = "0x1F42FE8", VA = "0x1F42FE8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB623C", Offset = "0xAB623C")]
	private bool <SpawnStuffCoroutine>b__15_0()
	{
		return default(bool);
	}
}
[Token(Token = "0x20001C8")]
public class VrUtilsSingleton : Singleton<VrUtilsSingleton>
{
	[Token(Token = "0x6000966")]
	[Address(RVA = "0x1F4303C", Offset = "0x1F4303C", VA = "0x1F4303C")]
	public VrUtilsSingleton()
	{
	}
}
[Token(Token = "0x20001C9")]
public class XDisplayManager : MonoBehaviour
{
	[Token(Token = "0x20001CA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAB008", Offset = "0xAAB008")]
	private sealed class <FadeCanvasAlpha>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public XDisplayManager <>4__this;

		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float targetAlpha;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <initialValue>5__2;

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <diff>5__3;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <time>5__4;

		[Token(Token = "0x1700016F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000971")]
			[Address(RVA = "0x22D14F0", Offset = "0x22D14F0", VA = "0x22D14F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000170")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000973")]
			[Address(RVA = "0x22D1538", Offset = "0x22D1538", VA = "0x22D1538", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0x22D1328", Offset = "0x22D1328", VA = "0x22D1328")]
		[DebuggerHidden]
		public <FadeCanvasAlpha>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x22D1354", Offset = "0x22D1354", VA = "0x22D1354", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x22D1358", Offset = "0x22D1358", VA = "0x22D1358", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x22D14F8", Offset = "0x22D14F8", VA = "0x22D14F8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40008F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Image[] Xs;

	[Token(Token = "0x40008F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int nextXIndex;

	[Token(Token = "0x40008FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Sprite XOnSprite;

	[Token(Token = "0x40008FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioHandler audioHandler;

	[Token(Token = "0x40008FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool decreaseAlphaWhenNear;

	[Token(Token = "0x40008FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float distanceToLowAlpha;

	[Token(Token = "0x40008FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float minAlpha;

	[Token(Token = "0x40008FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private bool isWithLowAlpha;

	[Token(Token = "0x4000900")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private CanvasGroup[] canvasGroups;

	[Token(Token = "0x4000901")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Transform playerTransform;

	[Token(Token = "0x4000902")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private WaitForFixedUpdate waitForFixedUpdate;

	[Token(Token = "0x6000967")]
	[Address(RVA = "0x1F44528", Offset = "0x1F44528", VA = "0x1F44528")]
	private void Start()
	{
	}

	[Token(Token = "0x6000968")]
	[Address(RVA = "0x1F4465C", Offset = "0x1F4465C", VA = "0x1F4465C")]
	public void SetXNumber(int n)
	{
	}

	[Token(Token = "0x6000969")]
	[Address(RVA = "0x1F44810", Offset = "0x1F44810", VA = "0x1F44810")]
	public void TurnXOn()
	{
	}

	[Token(Token = "0x600096A")]
	[Address(RVA = "0x1F44710", Offset = "0x1F44710", VA = "0x1F44710")]
	private Image[] GetXs()
	{
		return null;
	}

	[Token(Token = "0x600096B")]
	[Address(RVA = "0x1F448FC", Offset = "0x1F448FC", VA = "0x1F448FC")]
	private void CheckDistance()
	{
	}

	[Token(Token = "0x600096C")]
	[Address(RVA = "0x1F449D4", Offset = "0x1F449D4", VA = "0x1F449D4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB629C", Offset = "0xAB629C")]
	private IEnumerator FadeCanvasAlpha(float targetAlpha)
	{
		return null;
	}

	[Token(Token = "0x600096D")]
	[Address(RVA = "0x1F44A50", Offset = "0x1F44A50", VA = "0x1F44A50")]
	public XDisplayManager()
	{
	}
}
[Token(Token = "0x20001CB")]
public class Spoon : MonoBehaviour
{
	[Token(Token = "0x400090A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool spoonVegemited;

	[Token(Token = "0x400090B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer spoonVegemiteMeshRenderer;

	[Token(Token = "0x400090C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioHandler audioHandler;

	[Token(Token = "0x6000974")]
	[Address(RVA = "0x1F18574", Offset = "0x1F18574", VA = "0x1F18574")]
	private void Start()
	{
	}

	[Token(Token = "0x6000975")]
	[Address(RVA = "0x1F185C8", Offset = "0x1F185C8", VA = "0x1F185C8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000976")]
	[Address(RVA = "0x1F1872C", Offset = "0x1F1872C", VA = "0x1F1872C")]
	public Spoon()
	{
	}
}
[Token(Token = "0x20001CC")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xAAB018", Offset = "0xAAB018")]
public class BuoyantObject : MonoBehaviour
{
	[Token(Token = "0x400090D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Color red;

	[Token(Token = "0x400090E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Color green;

	[Token(Token = "0x400090F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Color blue;

	[Token(Token = "0x4000910")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Color orange;

	[Token(Token = "0x4000911")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float steepness;

	[Token(Token = "0x4000912")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float wavelength;

	[Token(Token = "0x4000913")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float speed;

	[Token(Token = "0x4000914")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float[] directions;

	[Token(Token = "0x4000915")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAAC1A4", Offset = "0xAAC1A4")]
	public StylizedWaterURP water;

	[Token(Token = "0x4000916")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAAC1DC", Offset = "0xAAC1DC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAAC1DC", Offset = "0xAAC1DC")]
	public float strength;

	[Token(Token = "0x4000917")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAAC230", Offset = "0xAAC230")]
	public float objectDepth;

	[Token(Token = "0x4000918")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float velocityDrag;

	[Token(Token = "0x4000919")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float angularDrag;

	[Token(Token = "0x400091A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAAC24C", Offset = "0xAAC24C")]
	public Transform[] effectors;

	[Token(Token = "0x400091B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Rigidbody rb;

	[Token(Token = "0x400091C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Vector3[] effectorProjections;

	[Token(Token = "0x6000977")]
	[Address(RVA = "0x1EB05A4", Offset = "0x1EB05A4", VA = "0x1EB05A4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000978")]
	[Address(RVA = "0x1EB06E4", Offset = "0x1EB06E4", VA = "0x1EB06E4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000979")]
	[Address(RVA = "0x1EB0704", Offset = "0x1EB0704", VA = "0x1EB0704")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600097A")]
	[Address(RVA = "0x1EB09A4", Offset = "0x1EB09A4", VA = "0x1EB09A4")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600097B")]
	[Address(RVA = "0x1EB0C60", Offset = "0x1EB0C60", VA = "0x1EB0C60")]
	public BuoyantObject()
	{
	}
}
[Token(Token = "0x20001CD")]
[ExecuteAlways]
public class PlanarReflectionsRenderer : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20001CE")]
	public enum ResolutionScales
	{
		[Token(Token = "0x400092D")]
		Full,
		[Token(Token = "0x400092E")]
		Half,
		[Token(Token = "0x400092F")]
		Third,
		[Token(Token = "0x4000930")]
		Quarter
	}

	[Serializable]
	[Token(Token = "0x20001CF")]
	public enum SkipFrames
	{
		[Token(Token = "0x4000932")]
		NoSkipFrame,
		[Token(Token = "0x4000933")]
		EverySecondFrame,
		[Token(Token = "0x4000934")]
		EveryThirdFrame,
		[Token(Token = "0x4000935")]
		EveryFourthFrame
	}

	[Token(Token = "0x400091D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAAC284", Offset = "0xAAC284")]
	public ResolutionScales ResolutionScale;

	[Token(Token = "0x400091E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAAC2BC", Offset = "0xAAC2BC")]
	public SkipFrames SkipEveryNFrame;

	[Token(Token = "0x400091F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAAC2F4", Offset = "0xAAC2F4")]
	public LayerMask LayersToReflect;

	[Token(Token = "0x4000920")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAAC32C", Offset = "0xAAC32C")]
	public bool RenderWithShadows;

	[Token(Token = "0x4000921")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAAC364", Offset = "0xAAC364")]
	public bool RenderWithOcclusionCulling;

	[Token(Token = "0x4000922")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAAC39C", Offset = "0xAAC39C")]
	public GameObject WaterPlane;

	[Token(Token = "0x4000923")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAAC3D4", Offset = "0xAAC3D4")]
	public float ClipPlaneOffset;

	[Token(Token = "0x4000924")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAAC40C", Offset = "0xAAC40C")]
	public int CameraRendererIndex;

	[Token(Token = "0x4000925")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Camera reflectionCamera;

	[Token(Token = "0x4000926")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private RenderTexture reflectionTexture;

	[Token(Token = "0x4000927")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int reflectionTextureId;

	[Token(Token = "0x4000928")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool fogBeforeReflections;

	[Token(Token = "0x4000929")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int maxLodBeforeReflections;

	[Token(Token = "0x400092A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float lodBiasBeforeReflections;

	[Token(Token = "0x400092B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int currentFrame;

	[Token(Token = "0x600097C")]
	[Address(RVA = "0x1F0BF38", Offset = "0x1F0BF38", VA = "0x1F0BF38")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600097D")]
	[Address(RVA = "0x1F0BFF4", Offset = "0x1F0BFF4", VA = "0x1F0BFF4")]
	private void Cleanup()
	{
	}

	[Token(Token = "0x600097E")]
	[Address(RVA = "0x1F0C1CC", Offset = "0x1F0C1CC", VA = "0x1F0C1CC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600097F")]
	[Address(RVA = "0x1F0C1D0", Offset = "0x1F0C1D0", VA = "0x1F0C1D0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000980")]
	[Address(RVA = "0x1F0C1D4", Offset = "0x1F0C1D4", VA = "0x1F0C1D4")]
	private void UpdateCamera(Camera src, Camera dest)
	{
	}

	[Token(Token = "0x6000981")]
	[Address(RVA = "0x1F0C2E8", Offset = "0x1F0C2E8", VA = "0x1F0C2E8")]
	private void UpdateReflectionCamera(Camera realCamera)
	{
	}

	[Token(Token = "0x6000982")]
	[Address(RVA = "0x1F0C74C", Offset = "0x1F0C74C", VA = "0x1F0C74C")]
	private Camera CreateReflectionCamera()
	{
		return null;
	}

	[Token(Token = "0x6000983")]
	[Address(RVA = "0x1F0CC50", Offset = "0x1F0CC50", VA = "0x1F0CC50")]
	private Vector4 WorldToCameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6000984")]
	[Address(RVA = "0x1F0CD7C", Offset = "0x1F0CD7C", VA = "0x1F0CD7C")]
	private void CreatePlanarReflectionTexture(Camera cam)
	{
	}

	[Token(Token = "0x6000985")]
	[Address(RVA = "0x1F0CFE4", Offset = "0x1F0CFE4", VA = "0x1F0CFE4")]
	private void RenderReflections(ScriptableRenderContext context, Camera camera)
	{
	}

	[Token(Token = "0x6000986")]
	[Address(RVA = "0x1F0C9AC", Offset = "0x1F0C9AC", VA = "0x1F0C9AC")]
	private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
	{
	}

	[Token(Token = "0x6000987")]
	[Address(RVA = "0x1F0CFC0", Offset = "0x1F0CFC0", VA = "0x1F0CFC0")]
	private float GetScaleValue()
	{
		return default(float);
	}

	[Token(Token = "0x6000988")]
	[Address(RVA = "0x1F0D184", Offset = "0x1F0D184", VA = "0x1F0D184")]
	private int GetSkipFrameValue()
	{
		return default(int);
	}

	[Token(Token = "0x6000989")]
	[Address(RVA = "0x1F0D1A4", Offset = "0x1F0D1A4", VA = "0x1F0D1A4")]
	public PlanarReflectionsRenderer()
	{
	}
}
[Token(Token = "0x20001D0")]
public class Feedback : MonoBehaviour
{
	[Token(Token = "0x4000936")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject passingLevelFeedbackMagnetPrefab;

	[Token(Token = "0x4000937")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject threeStarsFeedbackMagnetPrefab;

	[Token(Token = "0x4000938")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject magnetsParent;

	[Token(Token = "0x600098A")]
	[Address(RVA = "0x1F1E0A0", Offset = "0x1F1E0A0", VA = "0x1F1E0A0")]
	private void Start()
	{
	}

	[Token(Token = "0x600098B")]
	[Address(RVA = "0x1F1E9F4", Offset = "0x1F1E9F4", VA = "0x1F1E9F4")]
	public Feedback()
	{
	}
}
[Token(Token = "0x20001D1")]
public class FeedbackMagnet : MonoBehaviour
{
	[Token(Token = "0x4000939")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int level;

	[Token(Token = "0x400093A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool threeStarFeedback;

	[Token(Token = "0x600098C")]
	[Address(RVA = "0x1F1E9FC", Offset = "0x1F1E9FC", VA = "0x1F1E9FC")]
	private void Start()
	{
	}

	[Token(Token = "0x600098D")]
	[Address(RVA = "0x1F1E1D4", Offset = "0x1F1E1D4", VA = "0x1F1E1D4")]
	public void SetLevel(int _level)
	{
	}

	[Token(Token = "0x600098E")]
	[Address(RVA = "0x1F1EB44", Offset = "0x1F1EB44", VA = "0x1F1EB44")]
	private void SaveNewLocation(HVRGrabberBase arg0, HVRGrabbable arg1)
	{
	}

	[Token(Token = "0x600098F")]
	[Address(RVA = "0x1F1ED6C", Offset = "0x1F1ED6C", VA = "0x1F1ED6C")]
	public FeedbackMagnet()
	{
	}
}
[Token(Token = "0x20001D2")]
public class VegemiteInJar : MonoBehaviour
{
	[Token(Token = "0x400093B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float distanceToSpread;

	[Token(Token = "0x400093C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioHandler audioHandler;

	[Token(Token = "0x400093D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool empty;

	[Token(Token = "0x6000990")]
	[Address(RVA = "0x1F40CA0", Offset = "0x1F40CA0", VA = "0x1F40CA0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000991")]
	[Address(RVA = "0x1F40D10", Offset = "0x1F40D10", VA = "0x1F40D10")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000992")]
	[Address(RVA = "0x1F40FB4", Offset = "0x1F40FB4", VA = "0x1F40FB4")]
	private void DestroyOnRelease(HVRGrabberBase _, HVRGrabbable __)
	{
	}

	[Token(Token = "0x6000993")]
	[Address(RVA = "0x1F41058", Offset = "0x1F41058", VA = "0x1F41058")]
	public VegemiteInJar()
	{
	}
}
[Token(Token = "0x20001D3")]
public class VegemiteTop : MonoBehaviour
{
	[Token(Token = "0x400093E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Joint joint;

	[Token(Token = "0x400093F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioHandler audioHandler;

	[Token(Token = "0x4000940")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool topOff;

	[Token(Token = "0x4000941")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private HVRGrabbable grabbableBase;

	[Token(Token = "0x4000942")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private HVRGrabbable grabbable;

	[Token(Token = "0x4000943")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private HVRHandGrabber hand;

	[Token(Token = "0x4000944")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private MeshRenderer meshRenderer;

	[Token(Token = "0x4000945")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public MeshRenderer fakeTopMeshRenderer;

	[Token(Token = "0x4000946")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public VegemiteInJar vegemiteInJar;

	[Token(Token = "0x4000947")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float topPopingForce;

	[Token(Token = "0x6000994")]
	[Address(RVA = "0x1F414AC", Offset = "0x1F414AC", VA = "0x1F414AC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000995")]
	[Address(RVA = "0x1F416D4", Offset = "0x1F416D4", VA = "0x1F416D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000996")]
	[Address(RVA = "0x1F418F4", Offset = "0x1F418F4", VA = "0x1F418F4")]
	private void ReleaseBase(HVRGrabberBase arg0, HVRGrabbable arg1)
	{
	}

	[Token(Token = "0x6000997")]
	[Address(RVA = "0x1F41934", Offset = "0x1F41934", VA = "0x1F41934")]
	private void GrabBase(HVRGrabberBase grabber, HVRGrabbable arg1)
	{
	}

	[Token(Token = "0x6000998")]
	[Address(RVA = "0x1F419C0", Offset = "0x1F419C0", VA = "0x1F419C0")]
	private void GrabTop(HVRGrabberBase arg0, HVRGrabbable arg1)
	{
	}

	[Token(Token = "0x6000999")]
	[Address(RVA = "0x1F41784", Offset = "0x1F41784", VA = "0x1F41784")]
	public void TopComesOff(bool addForce = false)
	{
	}

	[Token(Token = "0x600099A")]
	[Address(RVA = "0x1F419D4", Offset = "0x1F419D4", VA = "0x1F419D4")]
	public VegemiteTop()
	{
	}
}
[Token(Token = "0x20001D4")]
public class XROculusCaptureHelperTest : MonoBehaviour
{
	[Token(Token = "0x600099B")]
	[Address(RVA = "0x1F44AC0", Offset = "0x1F44AC0", VA = "0x1F44AC0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600099C")]
	[Address(RVA = "0x1F44CE8", Offset = "0x1F44CE8", VA = "0x1F44CE8")]
	private void Start()
	{
	}

	[Token(Token = "0x600099D")]
	[Address(RVA = "0x1F44DD8", Offset = "0x1F44DD8", VA = "0x1F44DD8")]
	public XROculusCaptureHelperTest()
	{
	}
}
namespace StylizedWater
{
	[Token(Token = "0x20001D5")]
	public static class GerstnerWaveDisplacement
	{
		[Token(Token = "0x600099E")]
		[Address(RVA = "0x1F26238", Offset = "0x1F26238", VA = "0x1F26238")]
		private static Vector3 GerstnerWave(Vector3 position, float steepness, float wavelength, float speed, float direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x1F26328", Offset = "0x1F26328", VA = "0x1F26328")]
		public static Vector3 GetWaveDisplacement(Vector3 position, float steepness, float wavelength, float speed, float[] directions)
		{
			return default(Vector3);
		}
	}
}
namespace DebugStuff
{
	[Token(Token = "0x20001D6")]
	public class inGameLogger : MonoBehaviour
	{
		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string myLog;

		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string output;

		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string stack;

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x1F46B9C", Offset = "0x1F46B9C", VA = "0x1F46B9C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x1F46C18", Offset = "0x1F46C18", VA = "0x1F46C18")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x1F46C94", Offset = "0x1F46C94", VA = "0x1F46C94")]
		public void Log(string logString, string stackTrace, LogType type)
		{
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x1F46DA8", Offset = "0x1F46DA8", VA = "0x1F46DA8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x1F46EA0", Offset = "0x1F46EA0", VA = "0x1F46EA0")]
		public inGameLogger()
		{
		}
	}
}
namespace UnityTemplateProjects
{
	[Token(Token = "0x20001D7")]
	public class SimpleCameraController : MonoBehaviour
	{
		[Token(Token = "0x20001D8")]
		private class CameraState
		{
			[Token(Token = "0x4000952")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yaw;

			[Token(Token = "0x4000953")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pitch;

			[Token(Token = "0x4000954")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float roll;

			[Token(Token = "0x4000955")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float x;

			[Token(Token = "0x4000956")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float y;

			[Token(Token = "0x4000957")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float z;

			[Token(Token = "0x60009AA")]
			[Address(RVA = "0x22CE9DC", Offset = "0x22CE9DC", VA = "0x22CE9DC")]
			public void SetFromTransform(Transform t)
			{
			}

			[Token(Token = "0x60009AB")]
			[Address(RVA = "0x22CEA64", Offset = "0x22CEA64", VA = "0x22CEA64")]
			public void Translate(Vector3 translation)
			{
			}

			[Token(Token = "0x60009AC")]
			[Address(RVA = "0x22CEAE0", Offset = "0x22CEAE0", VA = "0x22CEAE0")]
			public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
			{
			}

			[Token(Token = "0x60009AD")]
			[Address(RVA = "0x22CEBA8", Offset = "0x22CEBA8", VA = "0x22CEBA8")]
			public void UpdateTransform(Transform t)
			{
			}

			[Token(Token = "0x60009AE")]
			[Address(RVA = "0x22CEBF4", Offset = "0x22CEBF4", VA = "0x22CEBF4")]
			public CameraState()
			{
			}
		}

		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CameraState m_TargetCameraState;

		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CameraState m_InterpolatingCameraState;

		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAAC444", Offset = "0xAAC444")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAAC444", Offset = "0xAAC444")]
		public float boost;

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAAC4A4", Offset = "0xAAC4A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAAC4A4", Offset = "0xAAC4A4")]
		public float positionLerpTime;

		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAAC4FC", Offset = "0xAAC4FC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAAC4FC", Offset = "0xAAC4FC")]
		public AnimationCurve mouseSensitivityCurve;

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAAC55C", Offset = "0xAAC55C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAAC55C", Offset = "0xAAC55C")]
		public float rotationLerpTime;

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAAC5B4", Offset = "0xAAC5B4")]
		public bool invertY;

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x1F17AA0", Offset = "0x1F17AA0", VA = "0x1F17AA0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x1F17B00", Offset = "0x1F17B00", VA = "0x1F17B00")]
		private Vector3 GetInputTranslationDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x1F17C14", Offset = "0x1F17C14", VA = "0x1F17C14")]
		private void Update()
		{
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x1F17CD8", Offset = "0x1F17CD8", VA = "0x1F17CD8")]
		public SimpleCameraController()
		{
		}
	}
}
namespace HurricaneVR.Samples
{
	[Token(Token = "0x20001D9")]
	public class AussieItemsSocketFilter : HVREnumFlagsSocketFilter<AussieItems>
	{
		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x1EA758C", Offset = "0x1EA758C", VA = "0x1EA758C")]
		public AussieItemsSocketFilter()
		{
		}
	}
	[Token(Token = "0x20001DA")]
	public class AussieItemsSocketable : HVREnumFlagsSocketable<AussieItems>
	{
		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x1EA75D8", Offset = "0x1EA75D8", VA = "0x1EA75D8")]
		public AussieItemsSocketable()
		{
		}
	}
	[Token(Token = "0x20001DB")]
	[Flags]
	public enum AussieItems
	{
		[Token(Token = "0x4000959")]
		None = 0,
		[Token(Token = "0x400095A")]
		Boomerang = 1,
		[Token(Token = "0x400095B")]
		BeerPrimary = 2,
		[Token(Token = "0x400095C")]
		Food = 4,
		[Token(Token = "0x400095D")]
		BottomBun = 8,
		[Token(Token = "0x400095E")]
		Hamburger = 0x10,
		[Token(Token = "0x400095F")]
		TopBun = 0x20,
		[Token(Token = "0x4000960")]
		Plate = 0x40,
		[Token(Token = "0x4000961")]
		BeerSecondary = 0x80,
		[Token(Token = "0x4000962")]
		BeerTertiary = 0x100,
		[Token(Token = "0x4000963")]
		Snag = 0x200,
		[Token(Token = "0x4000964")]
		Bread = 0x400,
		[Token(Token = "0x4000965")]
		Cap = 0x800,
		[Token(Token = "0x4000966")]
		SkewerStick = 0x1000,
		[Token(Token = "0x4000967")]
		Shrimp = 0x2000,
		[Token(Token = "0x4000968")]
		Hat = 0x4000,
		[Token(Token = "0x4000969")]
		All = -1
	}
}
namespace MRCHelpers
{
	[Token(Token = "0x20001DC")]
	public class CopyTransform : MonoBehaviour
	{
		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform m_originalTransform;

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x1EB38B8", Offset = "0x1EB38B8", VA = "0x1EB38B8")]
		private void Update()
		{
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x1EB3938", Offset = "0x1EB3938", VA = "0x1EB3938")]
		public CopyTransform()
		{
		}
	}
	[Token(Token = "0x20001DD")]
	public class OVRMixedRealityCaptureTestMod : MonoBehaviour
	{
		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inited;

		[Token(Token = "0x400096C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Camera defaultExternalCamera;

		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private OVRPlugin.Fovf defaultFov;

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x1F08C0C", Offset = "0x1F08C0C", VA = "0x1F08C0C")]
		private void Start()
		{
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x1F08CD0", Offset = "0x1F08CD0", VA = "0x1F08CD0")]
		private void Initialize()
		{
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x1F08F3C", Offset = "0x1F08F3C", VA = "0x1F08F3C")]
		private void UpdateDefaultExternalCamera()
		{
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x1F092E0", Offset = "0x1F092E0", VA = "0x1F092E0")]
		private void Update()
		{
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x1F09460", Offset = "0x1F09460", VA = "0x1F09460")]
		public OVRMixedRealityCaptureTestMod()
		{
		}
	}
	[Token(Token = "0x20001DE")]
	public class RemoveMRCamerasTracking : MonoBehaviour
	{
		[Token(Token = "0x20001DF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAAB098", Offset = "0xAAB098")]
		private sealed class <RemoveCamerasTracking>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400096E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400096F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000970")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RemoveMRCamerasTracking <>4__this;

			[Token(Token = "0x4000971")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform <trackingSpaceTransform>5__2;

			[Token(Token = "0x4000972")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string[] <camerasNames>5__3;

			[Token(Token = "0x4000973")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private WaitForSeconds <waiter>5__4;

			[Token(Token = "0x17000171")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009BE")]
				[Address(RVA = "0x22CCA40", Offset = "0x22CCA40", VA = "0x22CCA40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000172")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009C0")]
				[Address(RVA = "0x22CCA88", Offset = "0x22CCA88", VA = "0x22CCA88", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009BB")]
			[Address(RVA = "0x22CC71C", Offset = "0x22CC71C", VA = "0x22CC71C")]
			[DebuggerHidden]
			public <RemoveCamerasTracking>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x60009BC")]
			[Address(RVA = "0x22CC748", Offset = "0x22CC748", VA = "0x22CC748", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009BD")]
			[Address(RVA = "0x22CC74C", Offset = "0x22CC74C", VA = "0x22CC74C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x22CCA48", Offset = "0x22CCA48", VA = "0x22CCA48", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x1F11D2C", Offset = "0x1F11D2C", VA = "0x1F11D2C")]
		private void Start()
		{
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x1F11D58", Offset = "0x1F11D58", VA = "0x1F11D58")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB634C", Offset = "0xAB634C")]
		private IEnumerator RemoveCamerasTracking()
		{
			return null;
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x1F11DC4", Offset = "0x1F11DC4", VA = "0x1F11DC4")]
		public RemoveMRCamerasTracking()
		{
		}
	}
}
namespace ES3Types
{
	[Token(Token = "0x20001E0")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0xAAB0A8", Offset = "0xAAB0A8")]
	[Preserve]
	public class ES3UserType_ArcadeScore : ES3ObjectType
	{
		[Token(Token = "0x4000974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x1F1BEF0", Offset = "0x1F1BEF0", VA = "0x1F1BEF0")]
		public ES3UserType_ArcadeScore()
		{
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x1F1BFC0", Offset = "0x1F1BFC0", VA = "0x1F1BFC0", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60009C3")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60009C4")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20001E1")]
	public class ES3UserType_ArcadeScoreArray : ES3ArrayType
	{
		[Token(Token = "0x4000975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x1F1C324", Offset = "0x1F1C324", VA = "0x1F1C324")]
		public ES3UserType_ArcadeScoreArray()
		{
		}
	}
}
